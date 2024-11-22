
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsConceptVerBL
 表名:ConceptVer(01120649)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:15:30
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
public static class  clsConceptVerBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngConceptVId">表关键字</param>
 /// <returns>表对象</returns>
public static clsConceptVerEN GetObj(this K_ConceptVId_ConceptVer myKey)
{
clsConceptVerEN objConceptVerEN = clsConceptVerBL.ConceptVerDA.GetObjByConceptVId(myKey.Value);
return objConceptVerEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objConceptVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsConceptVerEN objConceptVerEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objConceptVerEN) == false)
{
var strMsg = string.Format("记录已经存在!ConceptVId = [{0}]的数据已经存在!(in clsConceptVerBL.AddNewRecord)", objConceptVerEN.ConceptVId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsConceptVerBL.ConceptVerDA.AddNewRecordBySQL2(objConceptVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConceptVerBL.ReFreshCache();

if (clsConceptVerBL.relatedActions != null)
{
clsConceptVerBL.relatedActions.UpdRelaTabDate(objConceptVerEN.ConceptVId, "SetUpdDate");
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
public static bool AddRecordEx(this clsConceptVerEN objConceptVerEN, bool bolIsNeedCheckUniqueness = true)
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
objConceptVerEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objConceptVerEN.CheckUniqueness() == false)
{
strMsg = string.Format("(ConceptVId(ConceptVId)=[{0}])已经存在,不能重复!", objConceptVerEN.ConceptVId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objConceptVerEN.AddNewRecord();
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
 /// <param name = "objConceptVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsConceptVerEN objConceptVerEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objConceptVerEN) == false)
{
var strMsg = string.Format("记录已经存在!ConceptVId = [{0}]的数据已经存在!(in clsConceptVerBL.AddNewRecordWithReturnKey)", objConceptVerEN.ConceptVId);
throw new Exception(strMsg);
}
try
{
string strKey = clsConceptVerBL.ConceptVerDA.AddNewRecordBySQL2WithReturnKey(objConceptVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConceptVerBL.ReFreshCache();

if (clsConceptVerBL.relatedActions != null)
{
clsConceptVerBL.relatedActions.UpdRelaTabDate(objConceptVerEN.ConceptVId, "SetUpdDate");
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
 /// <param name = "objConceptVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConceptVerEN SetConceptVId(this clsConceptVerEN objConceptVerEN, long lngConceptVId, string strComparisonOp="")
	{
objConceptVerEN.ConceptVId = lngConceptVId; //ConceptVId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConceptVerEN.dicFldComparisonOp.ContainsKey(conConceptVer.ConceptVId) == false)
{
objConceptVerEN.dicFldComparisonOp.Add(conConceptVer.ConceptVId, strComparisonOp);
}
else
{
objConceptVerEN.dicFldComparisonOp[conConceptVer.ConceptVId] = strComparisonOp;
}
}
return objConceptVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConceptVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConceptVerEN SetConceptId(this clsConceptVerEN objConceptVerEN, string strConceptId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strConceptId, conConceptVer.ConceptId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConceptId, 8, conConceptVer.ConceptId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strConceptId, 8, conConceptVer.ConceptId);
}
objConceptVerEN.ConceptId = strConceptId; //概念Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConceptVerEN.dicFldComparisonOp.ContainsKey(conConceptVer.ConceptId) == false)
{
objConceptVerEN.dicFldComparisonOp.Add(conConceptVer.ConceptId, strComparisonOp);
}
else
{
objConceptVerEN.dicFldComparisonOp[conConceptVer.ConceptId] = strComparisonOp;
}
}
return objConceptVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConceptVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConceptVerEN SetConceptContent(this clsConceptVerEN objConceptVerEN, string strConceptContent, string strComparisonOp="")
	{
objConceptVerEN.ConceptContent = strConceptContent; //概念内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConceptVerEN.dicFldComparisonOp.ContainsKey(conConceptVer.ConceptContent) == false)
{
objConceptVerEN.dicFldComparisonOp.Add(conConceptVer.ConceptContent, strComparisonOp);
}
else
{
objConceptVerEN.dicFldComparisonOp[conConceptVer.ConceptContent] = strComparisonOp;
}
}
return objConceptVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConceptVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConceptVerEN SetConceptName(this clsConceptVerEN objConceptVerEN, string strConceptName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConceptName, 500, conConceptVer.ConceptName);
}
objConceptVerEN.ConceptName = strConceptName; //概念名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConceptVerEN.dicFldComparisonOp.ContainsKey(conConceptVer.ConceptName) == false)
{
objConceptVerEN.dicFldComparisonOp.Add(conConceptVer.ConceptName, strComparisonOp);
}
else
{
objConceptVerEN.dicFldComparisonOp[conConceptVer.ConceptName] = strComparisonOp;
}
}
return objConceptVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConceptVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConceptVerEN SetCitationId(this clsConceptVerEN objConceptVerEN, string strCitationId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCitationId, 8, conConceptVer.CitationId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCitationId, 8, conConceptVer.CitationId);
}
objConceptVerEN.CitationId = strCitationId; //引用Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConceptVerEN.dicFldComparisonOp.ContainsKey(conConceptVer.CitationId) == false)
{
objConceptVerEN.dicFldComparisonOp.Add(conConceptVer.CitationId, strComparisonOp);
}
else
{
objConceptVerEN.dicFldComparisonOp[conConceptVer.CitationId] = strComparisonOp;
}
}
return objConceptVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConceptVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConceptVerEN SetUpdDate(this clsConceptVerEN objConceptVerEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conConceptVer.UpdDate);
}
objConceptVerEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConceptVerEN.dicFldComparisonOp.ContainsKey(conConceptVer.UpdDate) == false)
{
objConceptVerEN.dicFldComparisonOp.Add(conConceptVer.UpdDate, strComparisonOp);
}
else
{
objConceptVerEN.dicFldComparisonOp[conConceptVer.UpdDate] = strComparisonOp;
}
}
return objConceptVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConceptVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConceptVerEN SetUpdUser(this clsConceptVerEN objConceptVerEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conConceptVer.UpdUser);
}
objConceptVerEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConceptVerEN.dicFldComparisonOp.ContainsKey(conConceptVer.UpdUser) == false)
{
objConceptVerEN.dicFldComparisonOp.Add(conConceptVer.UpdUser, strComparisonOp);
}
else
{
objConceptVerEN.dicFldComparisonOp[conConceptVer.UpdUser] = strComparisonOp;
}
}
return objConceptVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConceptVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConceptVerEN SetIdCurrEduCls(this clsConceptVerEN objConceptVerEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conConceptVer.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conConceptVer.IdCurrEduCls);
}
objConceptVerEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConceptVerEN.dicFldComparisonOp.ContainsKey(conConceptVer.IdCurrEduCls) == false)
{
objConceptVerEN.dicFldComparisonOp.Add(conConceptVer.IdCurrEduCls, strComparisonOp);
}
else
{
objConceptVerEN.dicFldComparisonOp[conConceptVer.IdCurrEduCls] = strComparisonOp;
}
}
return objConceptVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConceptVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConceptVerEN SetPdfContent(this clsConceptVerEN objConceptVerEN, string strPdfContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfContent, 2000, conConceptVer.PdfContent);
}
objConceptVerEN.PdfContent = strPdfContent; //Pdf内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConceptVerEN.dicFldComparisonOp.ContainsKey(conConceptVer.PdfContent) == false)
{
objConceptVerEN.dicFldComparisonOp.Add(conConceptVer.PdfContent, strComparisonOp);
}
else
{
objConceptVerEN.dicFldComparisonOp[conConceptVer.PdfContent] = strComparisonOp;
}
}
return objConceptVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConceptVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConceptVerEN SetPdfPageNum(this clsConceptVerEN objConceptVerEN, int? intPdfPageNum, string strComparisonOp="")
	{
objConceptVerEN.PdfPageNum = intPdfPageNum; //Pdf页码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConceptVerEN.dicFldComparisonOp.ContainsKey(conConceptVer.PdfPageNum) == false)
{
objConceptVerEN.dicFldComparisonOp.Add(conConceptVer.PdfPageNum, strComparisonOp);
}
else
{
objConceptVerEN.dicFldComparisonOp[conConceptVer.PdfPageNum] = strComparisonOp;
}
}
return objConceptVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConceptVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConceptVerEN SetMemo(this clsConceptVerEN objConceptVerEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conConceptVer.Memo);
}
objConceptVerEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConceptVerEN.dicFldComparisonOp.ContainsKey(conConceptVer.Memo) == false)
{
objConceptVerEN.dicFldComparisonOp.Add(conConceptVer.Memo, strComparisonOp);
}
else
{
objConceptVerEN.dicFldComparisonOp[conConceptVer.Memo] = strComparisonOp;
}
}
return objConceptVerEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objConceptVerEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsConceptVerEN objConceptVerEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objConceptVerEN.CheckPropertyNew();
clsConceptVerEN objConceptVerCond = new clsConceptVerEN();
string strCondition = objConceptVerCond
.SetConceptVId(objConceptVerEN.ConceptVId, "<>")
.SetConceptVId(objConceptVerEN.ConceptVId, "=")
.GetCombineCondition();
objConceptVerEN._IsCheckProperty = true;
bool bolIsExist = clsConceptVerBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(ConceptVId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objConceptVerEN.Update();
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
 /// <param name = "objConceptVer">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsConceptVerEN objConceptVer)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsConceptVerEN objConceptVerCond = new clsConceptVerEN();
string strCondition = objConceptVerCond
.SetConceptVId(objConceptVer.ConceptVId, "=")
.GetCombineCondition();
objConceptVer._IsCheckProperty = true;
bool bolIsExist = clsConceptVerBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objConceptVer.ConceptVId = clsConceptVerBL.GetFirstID_S(strCondition);
objConceptVer.UpdateWithCondition(strCondition);
}
else
{
objConceptVer.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objConceptVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsConceptVerEN objConceptVerEN)
{
 if (objConceptVerEN.ConceptVId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsConceptVerBL.ConceptVerDA.UpdateBySql2(objConceptVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConceptVerBL.ReFreshCache();

if (clsConceptVerBL.relatedActions != null)
{
clsConceptVerBL.relatedActions.UpdRelaTabDate(objConceptVerEN.ConceptVId, "SetUpdDate");
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
 /// <param name = "objConceptVerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsConceptVerEN objConceptVerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objConceptVerEN.ConceptVId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsConceptVerBL.ConceptVerDA.UpdateBySql2(objConceptVerEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConceptVerBL.ReFreshCache();

if (clsConceptVerBL.relatedActions != null)
{
clsConceptVerBL.relatedActions.UpdRelaTabDate(objConceptVerEN.ConceptVId, "SetUpdDate");
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
 /// <param name = "objConceptVerEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsConceptVerEN objConceptVerEN, string strWhereCond)
{
try
{
bool bolResult = clsConceptVerBL.ConceptVerDA.UpdateBySqlWithCondition(objConceptVerEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConceptVerBL.ReFreshCache();

if (clsConceptVerBL.relatedActions != null)
{
clsConceptVerBL.relatedActions.UpdRelaTabDate(objConceptVerEN.ConceptVId, "SetUpdDate");
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
 /// <param name = "objConceptVerEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsConceptVerEN objConceptVerEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsConceptVerBL.ConceptVerDA.UpdateBySqlWithConditionTransaction(objConceptVerEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConceptVerBL.ReFreshCache();

if (clsConceptVerBL.relatedActions != null)
{
clsConceptVerBL.relatedActions.UpdRelaTabDate(objConceptVerEN.ConceptVId, "SetUpdDate");
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
public static int Delete(this clsConceptVerEN objConceptVerEN)
{
try
{
int intRecNum = clsConceptVerBL.ConceptVerDA.DelRecord(objConceptVerEN.ConceptVId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConceptVerBL.ReFreshCache();

if (clsConceptVerBL.relatedActions != null)
{
clsConceptVerBL.relatedActions.UpdRelaTabDate(objConceptVerEN.ConceptVId, "SetUpdDate");
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
 /// <param name = "objConceptVerENS">源对象</param>
 /// <param name = "objConceptVerENT">目标对象</param>
 public static void CopyTo(this clsConceptVerEN objConceptVerENS, clsConceptVerEN objConceptVerENT)
{
try
{
objConceptVerENT.ConceptVId = objConceptVerENS.ConceptVId; //ConceptVId
objConceptVerENT.ConceptId = objConceptVerENS.ConceptId; //概念Id
objConceptVerENT.ConceptContent = objConceptVerENS.ConceptContent; //概念内容
objConceptVerENT.ConceptName = objConceptVerENS.ConceptName; //概念名称
objConceptVerENT.CitationId = objConceptVerENS.CitationId; //引用Id
objConceptVerENT.UpdDate = objConceptVerENS.UpdDate; //修改日期
objConceptVerENT.UpdUser = objConceptVerENS.UpdUser; //修改人
objConceptVerENT.IdCurrEduCls = objConceptVerENS.IdCurrEduCls; //教学班流水号
objConceptVerENT.PdfContent = objConceptVerENS.PdfContent; //Pdf内容
objConceptVerENT.PdfPageNum = objConceptVerENS.PdfPageNum; //Pdf页码
objConceptVerENT.Memo = objConceptVerENS.Memo; //备注
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
 /// <param name = "objConceptVerENS">源对象</param>
 /// <returns>目标对象=>clsConceptVerEN:objConceptVerENT</returns>
 public static clsConceptVerEN CopyTo(this clsConceptVerEN objConceptVerENS)
{
try
{
 clsConceptVerEN objConceptVerENT = new clsConceptVerEN()
{
ConceptVId = objConceptVerENS.ConceptVId, //ConceptVId
ConceptId = objConceptVerENS.ConceptId, //概念Id
ConceptContent = objConceptVerENS.ConceptContent, //概念内容
ConceptName = objConceptVerENS.ConceptName, //概念名称
CitationId = objConceptVerENS.CitationId, //引用Id
UpdDate = objConceptVerENS.UpdDate, //修改日期
UpdUser = objConceptVerENS.UpdUser, //修改人
IdCurrEduCls = objConceptVerENS.IdCurrEduCls, //教学班流水号
PdfContent = objConceptVerENS.PdfContent, //Pdf内容
PdfPageNum = objConceptVerENS.PdfPageNum, //Pdf页码
Memo = objConceptVerENS.Memo, //备注
};
 return objConceptVerENT;
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
public static void CheckPropertyNew(this clsConceptVerEN objConceptVerEN)
{
 clsConceptVerBL.ConceptVerDA.CheckPropertyNew(objConceptVerEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsConceptVerEN objConceptVerEN)
{
 clsConceptVerBL.ConceptVerDA.CheckProperty4Condition(objConceptVerEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsConceptVerEN objConceptVerCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objConceptVerCond.IsUpdated(conConceptVer.ConceptVId) == true)
{
string strComparisonOpConceptVId = objConceptVerCond.dicFldComparisonOp[conConceptVer.ConceptVId];
strWhereCond += string.Format(" And {0} {2} {1}", conConceptVer.ConceptVId, objConceptVerCond.ConceptVId, strComparisonOpConceptVId);
}
if (objConceptVerCond.IsUpdated(conConceptVer.ConceptId) == true)
{
string strComparisonOpConceptId = objConceptVerCond.dicFldComparisonOp[conConceptVer.ConceptId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conConceptVer.ConceptId, objConceptVerCond.ConceptId, strComparisonOpConceptId);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objConceptVerCond.IsUpdated(conConceptVer.ConceptName) == true)
{
string strComparisonOpConceptName = objConceptVerCond.dicFldComparisonOp[conConceptVer.ConceptName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conConceptVer.ConceptName, objConceptVerCond.ConceptName, strComparisonOpConceptName);
}
if (objConceptVerCond.IsUpdated(conConceptVer.CitationId) == true)
{
string strComparisonOpCitationId = objConceptVerCond.dicFldComparisonOp[conConceptVer.CitationId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conConceptVer.CitationId, objConceptVerCond.CitationId, strComparisonOpCitationId);
}
if (objConceptVerCond.IsUpdated(conConceptVer.UpdDate) == true)
{
string strComparisonOpUpdDate = objConceptVerCond.dicFldComparisonOp[conConceptVer.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conConceptVer.UpdDate, objConceptVerCond.UpdDate, strComparisonOpUpdDate);
}
if (objConceptVerCond.IsUpdated(conConceptVer.UpdUser) == true)
{
string strComparisonOpUpdUser = objConceptVerCond.dicFldComparisonOp[conConceptVer.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conConceptVer.UpdUser, objConceptVerCond.UpdUser, strComparisonOpUpdUser);
}
if (objConceptVerCond.IsUpdated(conConceptVer.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objConceptVerCond.dicFldComparisonOp[conConceptVer.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conConceptVer.IdCurrEduCls, objConceptVerCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objConceptVerCond.IsUpdated(conConceptVer.PdfContent) == true)
{
string strComparisonOpPdfContent = objConceptVerCond.dicFldComparisonOp[conConceptVer.PdfContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conConceptVer.PdfContent, objConceptVerCond.PdfContent, strComparisonOpPdfContent);
}
if (objConceptVerCond.IsUpdated(conConceptVer.PdfPageNum) == true)
{
string strComparisonOpPdfPageNum = objConceptVerCond.dicFldComparisonOp[conConceptVer.PdfPageNum];
strWhereCond += string.Format(" And {0} {2} {1}", conConceptVer.PdfPageNum, objConceptVerCond.PdfPageNum, strComparisonOpPdfPageNum);
}
if (objConceptVerCond.IsUpdated(conConceptVer.Memo) == true)
{
string strComparisonOpMemo = objConceptVerCond.dicFldComparisonOp[conConceptVer.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conConceptVer.Memo, objConceptVerCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--ConceptVer(概念版本表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:ConceptVId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objConceptVerEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsConceptVerEN objConceptVerEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objConceptVerEN == null) return true;
if (objConceptVerEN.ConceptVId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ConceptVId = '{0}'", objConceptVerEN.ConceptVId);
if (clsConceptVerBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("ConceptVId !=  {0}", objConceptVerEN.ConceptVId);
 sbCondition.AppendFormat(" and ConceptVId = '{0}'", objConceptVerEN.ConceptVId);
if (clsConceptVerBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--ConceptVer(概念版本表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ConceptVId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objConceptVerEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsConceptVerEN objConceptVerEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objConceptVerEN == null) return "";
if (objConceptVerEN.ConceptVId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ConceptVId = '{0}'", objConceptVerEN.ConceptVId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ConceptVId !=  {0}", objConceptVerEN.ConceptVId);
 sbCondition.AppendFormat(" and ConceptVId = '{0}'", objConceptVerEN.ConceptVId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ConceptVer
{
public virtual bool UpdRelaTabDate(long lngConceptVId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 概念版本表(ConceptVer)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsConceptVerBL
{
public static RelatedActions_ConceptVer relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsConceptVerDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsConceptVerDA ConceptVerDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsConceptVerDA();
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
 public clsConceptVerBL()
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
if (string.IsNullOrEmpty(clsConceptVerEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsConceptVerEN._ConnectString);
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
public static DataTable GetDataTable_ConceptVer(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ConceptVerDA.GetDataTable_ConceptVer(strWhereCond);
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
objDT = ConceptVerDA.GetDataTable(strWhereCond);
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
objDT = ConceptVerDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ConceptVerDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ConceptVerDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ConceptVerDA.GetDataTable_Top(objTopPara);
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
objDT = ConceptVerDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ConceptVerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ConceptVerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsConceptVerEN> GetObjLstByConceptVIdLst(List<long> arrConceptVIdLst)
{
List<clsConceptVerEN> arrObjLst = new List<clsConceptVerEN>(); 
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
	clsConceptVerEN objConceptVerEN = new clsConceptVerEN();
try
{
objConceptVerEN.ConceptVId = Int32.Parse(objRow[conConceptVer.ConceptVId].ToString().Trim()); //ConceptVId
objConceptVerEN.ConceptId = objRow[conConceptVer.ConceptId].ToString().Trim(); //概念Id
objConceptVerEN.ConceptContent = objRow[conConceptVer.ConceptContent] == DBNull.Value ? null : objRow[conConceptVer.ConceptContent].ToString().Trim(); //概念内容
objConceptVerEN.ConceptName = objRow[conConceptVer.ConceptName] == DBNull.Value ? null : objRow[conConceptVer.ConceptName].ToString().Trim(); //概念名称
objConceptVerEN.CitationId = objRow[conConceptVer.CitationId] == DBNull.Value ? null : objRow[conConceptVer.CitationId].ToString().Trim(); //引用Id
objConceptVerEN.UpdDate = objRow[conConceptVer.UpdDate] == DBNull.Value ? null : objRow[conConceptVer.UpdDate].ToString().Trim(); //修改日期
objConceptVerEN.UpdUser = objRow[conConceptVer.UpdUser] == DBNull.Value ? null : objRow[conConceptVer.UpdUser].ToString().Trim(); //修改人
objConceptVerEN.IdCurrEduCls = objRow[conConceptVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conConceptVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objConceptVerEN.PdfContent = objRow[conConceptVer.PdfContent] == DBNull.Value ? null : objRow[conConceptVer.PdfContent].ToString().Trim(); //Pdf内容
objConceptVerEN.PdfPageNum = objRow[conConceptVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConceptVer.PdfPageNum].ToString().Trim()); //Pdf页码
objConceptVerEN.Memo = objRow[conConceptVer.Memo] == DBNull.Value ? null : objRow[conConceptVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objConceptVerEN.ConceptVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objConceptVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrConceptVIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsConceptVerEN> GetObjLstByConceptVIdLstCache(List<long> arrConceptVIdLst)
{
string strKey = string.Format("{0}", clsConceptVerEN._CurrTabName);
List<clsConceptVerEN> arrConceptVerObjLstCache = GetObjLstCache();
IEnumerable <clsConceptVerEN> arrConceptVerObjLst_Sel =
arrConceptVerObjLstCache
.Where(x => arrConceptVIdLst.Contains(x.ConceptVId));
return arrConceptVerObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsConceptVerEN> GetObjLst(string strWhereCond)
{
List<clsConceptVerEN> arrObjLst = new List<clsConceptVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsConceptVerEN objConceptVerEN = new clsConceptVerEN();
try
{
objConceptVerEN.ConceptVId = Int32.Parse(objRow[conConceptVer.ConceptVId].ToString().Trim()); //ConceptVId
objConceptVerEN.ConceptId = objRow[conConceptVer.ConceptId].ToString().Trim(); //概念Id
objConceptVerEN.ConceptContent = objRow[conConceptVer.ConceptContent] == DBNull.Value ? null : objRow[conConceptVer.ConceptContent].ToString().Trim(); //概念内容
objConceptVerEN.ConceptName = objRow[conConceptVer.ConceptName] == DBNull.Value ? null : objRow[conConceptVer.ConceptName].ToString().Trim(); //概念名称
objConceptVerEN.CitationId = objRow[conConceptVer.CitationId] == DBNull.Value ? null : objRow[conConceptVer.CitationId].ToString().Trim(); //引用Id
objConceptVerEN.UpdDate = objRow[conConceptVer.UpdDate] == DBNull.Value ? null : objRow[conConceptVer.UpdDate].ToString().Trim(); //修改日期
objConceptVerEN.UpdUser = objRow[conConceptVer.UpdUser] == DBNull.Value ? null : objRow[conConceptVer.UpdUser].ToString().Trim(); //修改人
objConceptVerEN.IdCurrEduCls = objRow[conConceptVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conConceptVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objConceptVerEN.PdfContent = objRow[conConceptVer.PdfContent] == DBNull.Value ? null : objRow[conConceptVer.PdfContent].ToString().Trim(); //Pdf内容
objConceptVerEN.PdfPageNum = objRow[conConceptVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConceptVer.PdfPageNum].ToString().Trim()); //Pdf页码
objConceptVerEN.Memo = objRow[conConceptVer.Memo] == DBNull.Value ? null : objRow[conConceptVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objConceptVerEN.ConceptVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objConceptVerEN);
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
public static List<clsConceptVerEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsConceptVerEN> arrObjLst = new List<clsConceptVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsConceptVerEN objConceptVerEN = new clsConceptVerEN();
try
{
objConceptVerEN.ConceptVId = Int32.Parse(objRow[conConceptVer.ConceptVId].ToString().Trim()); //ConceptVId
objConceptVerEN.ConceptId = objRow[conConceptVer.ConceptId].ToString().Trim(); //概念Id
objConceptVerEN.ConceptContent = objRow[conConceptVer.ConceptContent] == DBNull.Value ? null : objRow[conConceptVer.ConceptContent].ToString().Trim(); //概念内容
objConceptVerEN.ConceptName = objRow[conConceptVer.ConceptName] == DBNull.Value ? null : objRow[conConceptVer.ConceptName].ToString().Trim(); //概念名称
objConceptVerEN.CitationId = objRow[conConceptVer.CitationId] == DBNull.Value ? null : objRow[conConceptVer.CitationId].ToString().Trim(); //引用Id
objConceptVerEN.UpdDate = objRow[conConceptVer.UpdDate] == DBNull.Value ? null : objRow[conConceptVer.UpdDate].ToString().Trim(); //修改日期
objConceptVerEN.UpdUser = objRow[conConceptVer.UpdUser] == DBNull.Value ? null : objRow[conConceptVer.UpdUser].ToString().Trim(); //修改人
objConceptVerEN.IdCurrEduCls = objRow[conConceptVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conConceptVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objConceptVerEN.PdfContent = objRow[conConceptVer.PdfContent] == DBNull.Value ? null : objRow[conConceptVer.PdfContent].ToString().Trim(); //Pdf内容
objConceptVerEN.PdfPageNum = objRow[conConceptVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConceptVer.PdfPageNum].ToString().Trim()); //Pdf页码
objConceptVerEN.Memo = objRow[conConceptVer.Memo] == DBNull.Value ? null : objRow[conConceptVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objConceptVerEN.ConceptVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objConceptVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objConceptVerCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsConceptVerEN> GetSubObjLstCache(clsConceptVerEN objConceptVerCond)
{
List<clsConceptVerEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsConceptVerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conConceptVer.AttributeName)
{
if (objConceptVerCond.IsUpdated(strFldName) == false) continue;
if (objConceptVerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objConceptVerCond[strFldName].ToString());
}
else
{
if (objConceptVerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objConceptVerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objConceptVerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objConceptVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objConceptVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objConceptVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objConceptVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objConceptVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objConceptVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objConceptVerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objConceptVerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objConceptVerCond[strFldName]));
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
public static List<clsConceptVerEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsConceptVerEN> arrObjLst = new List<clsConceptVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsConceptVerEN objConceptVerEN = new clsConceptVerEN();
try
{
objConceptVerEN.ConceptVId = Int32.Parse(objRow[conConceptVer.ConceptVId].ToString().Trim()); //ConceptVId
objConceptVerEN.ConceptId = objRow[conConceptVer.ConceptId].ToString().Trim(); //概念Id
objConceptVerEN.ConceptContent = objRow[conConceptVer.ConceptContent] == DBNull.Value ? null : objRow[conConceptVer.ConceptContent].ToString().Trim(); //概念内容
objConceptVerEN.ConceptName = objRow[conConceptVer.ConceptName] == DBNull.Value ? null : objRow[conConceptVer.ConceptName].ToString().Trim(); //概念名称
objConceptVerEN.CitationId = objRow[conConceptVer.CitationId] == DBNull.Value ? null : objRow[conConceptVer.CitationId].ToString().Trim(); //引用Id
objConceptVerEN.UpdDate = objRow[conConceptVer.UpdDate] == DBNull.Value ? null : objRow[conConceptVer.UpdDate].ToString().Trim(); //修改日期
objConceptVerEN.UpdUser = objRow[conConceptVer.UpdUser] == DBNull.Value ? null : objRow[conConceptVer.UpdUser].ToString().Trim(); //修改人
objConceptVerEN.IdCurrEduCls = objRow[conConceptVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conConceptVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objConceptVerEN.PdfContent = objRow[conConceptVer.PdfContent] == DBNull.Value ? null : objRow[conConceptVer.PdfContent].ToString().Trim(); //Pdf内容
objConceptVerEN.PdfPageNum = objRow[conConceptVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConceptVer.PdfPageNum].ToString().Trim()); //Pdf页码
objConceptVerEN.Memo = objRow[conConceptVer.Memo] == DBNull.Value ? null : objRow[conConceptVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objConceptVerEN.ConceptVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objConceptVerEN);
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
public static List<clsConceptVerEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsConceptVerEN> arrObjLst = new List<clsConceptVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsConceptVerEN objConceptVerEN = new clsConceptVerEN();
try
{
objConceptVerEN.ConceptVId = Int32.Parse(objRow[conConceptVer.ConceptVId].ToString().Trim()); //ConceptVId
objConceptVerEN.ConceptId = objRow[conConceptVer.ConceptId].ToString().Trim(); //概念Id
objConceptVerEN.ConceptContent = objRow[conConceptVer.ConceptContent] == DBNull.Value ? null : objRow[conConceptVer.ConceptContent].ToString().Trim(); //概念内容
objConceptVerEN.ConceptName = objRow[conConceptVer.ConceptName] == DBNull.Value ? null : objRow[conConceptVer.ConceptName].ToString().Trim(); //概念名称
objConceptVerEN.CitationId = objRow[conConceptVer.CitationId] == DBNull.Value ? null : objRow[conConceptVer.CitationId].ToString().Trim(); //引用Id
objConceptVerEN.UpdDate = objRow[conConceptVer.UpdDate] == DBNull.Value ? null : objRow[conConceptVer.UpdDate].ToString().Trim(); //修改日期
objConceptVerEN.UpdUser = objRow[conConceptVer.UpdUser] == DBNull.Value ? null : objRow[conConceptVer.UpdUser].ToString().Trim(); //修改人
objConceptVerEN.IdCurrEduCls = objRow[conConceptVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conConceptVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objConceptVerEN.PdfContent = objRow[conConceptVer.PdfContent] == DBNull.Value ? null : objRow[conConceptVer.PdfContent].ToString().Trim(); //Pdf内容
objConceptVerEN.PdfPageNum = objRow[conConceptVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConceptVer.PdfPageNum].ToString().Trim()); //Pdf页码
objConceptVerEN.Memo = objRow[conConceptVer.Memo] == DBNull.Value ? null : objRow[conConceptVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objConceptVerEN.ConceptVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objConceptVerEN);
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
List<clsConceptVerEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsConceptVerEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsConceptVerEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsConceptVerEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsConceptVerEN> arrObjLst = new List<clsConceptVerEN>(); 
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
	clsConceptVerEN objConceptVerEN = new clsConceptVerEN();
try
{
objConceptVerEN.ConceptVId = Int32.Parse(objRow[conConceptVer.ConceptVId].ToString().Trim()); //ConceptVId
objConceptVerEN.ConceptId = objRow[conConceptVer.ConceptId].ToString().Trim(); //概念Id
objConceptVerEN.ConceptContent = objRow[conConceptVer.ConceptContent] == DBNull.Value ? null : objRow[conConceptVer.ConceptContent].ToString().Trim(); //概念内容
objConceptVerEN.ConceptName = objRow[conConceptVer.ConceptName] == DBNull.Value ? null : objRow[conConceptVer.ConceptName].ToString().Trim(); //概念名称
objConceptVerEN.CitationId = objRow[conConceptVer.CitationId] == DBNull.Value ? null : objRow[conConceptVer.CitationId].ToString().Trim(); //引用Id
objConceptVerEN.UpdDate = objRow[conConceptVer.UpdDate] == DBNull.Value ? null : objRow[conConceptVer.UpdDate].ToString().Trim(); //修改日期
objConceptVerEN.UpdUser = objRow[conConceptVer.UpdUser] == DBNull.Value ? null : objRow[conConceptVer.UpdUser].ToString().Trim(); //修改人
objConceptVerEN.IdCurrEduCls = objRow[conConceptVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conConceptVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objConceptVerEN.PdfContent = objRow[conConceptVer.PdfContent] == DBNull.Value ? null : objRow[conConceptVer.PdfContent].ToString().Trim(); //Pdf内容
objConceptVerEN.PdfPageNum = objRow[conConceptVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConceptVer.PdfPageNum].ToString().Trim()); //Pdf页码
objConceptVerEN.Memo = objRow[conConceptVer.Memo] == DBNull.Value ? null : objRow[conConceptVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objConceptVerEN.ConceptVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objConceptVerEN);
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
public static List<clsConceptVerEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsConceptVerEN> arrObjLst = new List<clsConceptVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsConceptVerEN objConceptVerEN = new clsConceptVerEN();
try
{
objConceptVerEN.ConceptVId = Int32.Parse(objRow[conConceptVer.ConceptVId].ToString().Trim()); //ConceptVId
objConceptVerEN.ConceptId = objRow[conConceptVer.ConceptId].ToString().Trim(); //概念Id
objConceptVerEN.ConceptContent = objRow[conConceptVer.ConceptContent] == DBNull.Value ? null : objRow[conConceptVer.ConceptContent].ToString().Trim(); //概念内容
objConceptVerEN.ConceptName = objRow[conConceptVer.ConceptName] == DBNull.Value ? null : objRow[conConceptVer.ConceptName].ToString().Trim(); //概念名称
objConceptVerEN.CitationId = objRow[conConceptVer.CitationId] == DBNull.Value ? null : objRow[conConceptVer.CitationId].ToString().Trim(); //引用Id
objConceptVerEN.UpdDate = objRow[conConceptVer.UpdDate] == DBNull.Value ? null : objRow[conConceptVer.UpdDate].ToString().Trim(); //修改日期
objConceptVerEN.UpdUser = objRow[conConceptVer.UpdUser] == DBNull.Value ? null : objRow[conConceptVer.UpdUser].ToString().Trim(); //修改人
objConceptVerEN.IdCurrEduCls = objRow[conConceptVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conConceptVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objConceptVerEN.PdfContent = objRow[conConceptVer.PdfContent] == DBNull.Value ? null : objRow[conConceptVer.PdfContent].ToString().Trim(); //Pdf内容
objConceptVerEN.PdfPageNum = objRow[conConceptVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConceptVer.PdfPageNum].ToString().Trim()); //Pdf页码
objConceptVerEN.Memo = objRow[conConceptVer.Memo] == DBNull.Value ? null : objRow[conConceptVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objConceptVerEN.ConceptVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objConceptVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsConceptVerEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsConceptVerEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsConceptVerEN> arrObjLst = new List<clsConceptVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsConceptVerEN objConceptVerEN = new clsConceptVerEN();
try
{
objConceptVerEN.ConceptVId = Int32.Parse(objRow[conConceptVer.ConceptVId].ToString().Trim()); //ConceptVId
objConceptVerEN.ConceptId = objRow[conConceptVer.ConceptId].ToString().Trim(); //概念Id
objConceptVerEN.ConceptContent = objRow[conConceptVer.ConceptContent] == DBNull.Value ? null : objRow[conConceptVer.ConceptContent].ToString().Trim(); //概念内容
objConceptVerEN.ConceptName = objRow[conConceptVer.ConceptName] == DBNull.Value ? null : objRow[conConceptVer.ConceptName].ToString().Trim(); //概念名称
objConceptVerEN.CitationId = objRow[conConceptVer.CitationId] == DBNull.Value ? null : objRow[conConceptVer.CitationId].ToString().Trim(); //引用Id
objConceptVerEN.UpdDate = objRow[conConceptVer.UpdDate] == DBNull.Value ? null : objRow[conConceptVer.UpdDate].ToString().Trim(); //修改日期
objConceptVerEN.UpdUser = objRow[conConceptVer.UpdUser] == DBNull.Value ? null : objRow[conConceptVer.UpdUser].ToString().Trim(); //修改人
objConceptVerEN.IdCurrEduCls = objRow[conConceptVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conConceptVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objConceptVerEN.PdfContent = objRow[conConceptVer.PdfContent] == DBNull.Value ? null : objRow[conConceptVer.PdfContent].ToString().Trim(); //Pdf内容
objConceptVerEN.PdfPageNum = objRow[conConceptVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConceptVer.PdfPageNum].ToString().Trim()); //Pdf页码
objConceptVerEN.Memo = objRow[conConceptVer.Memo] == DBNull.Value ? null : objRow[conConceptVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objConceptVerEN.ConceptVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objConceptVerEN);
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
public static List<clsConceptVerEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsConceptVerEN> arrObjLst = new List<clsConceptVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsConceptVerEN objConceptVerEN = new clsConceptVerEN();
try
{
objConceptVerEN.ConceptVId = Int32.Parse(objRow[conConceptVer.ConceptVId].ToString().Trim()); //ConceptVId
objConceptVerEN.ConceptId = objRow[conConceptVer.ConceptId].ToString().Trim(); //概念Id
objConceptVerEN.ConceptContent = objRow[conConceptVer.ConceptContent] == DBNull.Value ? null : objRow[conConceptVer.ConceptContent].ToString().Trim(); //概念内容
objConceptVerEN.ConceptName = objRow[conConceptVer.ConceptName] == DBNull.Value ? null : objRow[conConceptVer.ConceptName].ToString().Trim(); //概念名称
objConceptVerEN.CitationId = objRow[conConceptVer.CitationId] == DBNull.Value ? null : objRow[conConceptVer.CitationId].ToString().Trim(); //引用Id
objConceptVerEN.UpdDate = objRow[conConceptVer.UpdDate] == DBNull.Value ? null : objRow[conConceptVer.UpdDate].ToString().Trim(); //修改日期
objConceptVerEN.UpdUser = objRow[conConceptVer.UpdUser] == DBNull.Value ? null : objRow[conConceptVer.UpdUser].ToString().Trim(); //修改人
objConceptVerEN.IdCurrEduCls = objRow[conConceptVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conConceptVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objConceptVerEN.PdfContent = objRow[conConceptVer.PdfContent] == DBNull.Value ? null : objRow[conConceptVer.PdfContent].ToString().Trim(); //Pdf内容
objConceptVerEN.PdfPageNum = objRow[conConceptVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConceptVer.PdfPageNum].ToString().Trim()); //Pdf页码
objConceptVerEN.Memo = objRow[conConceptVer.Memo] == DBNull.Value ? null : objRow[conConceptVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objConceptVerEN.ConceptVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objConceptVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsConceptVerEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsConceptVerEN> arrObjLst = new List<clsConceptVerEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsConceptVerEN objConceptVerEN = new clsConceptVerEN();
try
{
objConceptVerEN.ConceptVId = Int32.Parse(objRow[conConceptVer.ConceptVId].ToString().Trim()); //ConceptVId
objConceptVerEN.ConceptId = objRow[conConceptVer.ConceptId].ToString().Trim(); //概念Id
objConceptVerEN.ConceptContent = objRow[conConceptVer.ConceptContent] == DBNull.Value ? null : objRow[conConceptVer.ConceptContent].ToString().Trim(); //概念内容
objConceptVerEN.ConceptName = objRow[conConceptVer.ConceptName] == DBNull.Value ? null : objRow[conConceptVer.ConceptName].ToString().Trim(); //概念名称
objConceptVerEN.CitationId = objRow[conConceptVer.CitationId] == DBNull.Value ? null : objRow[conConceptVer.CitationId].ToString().Trim(); //引用Id
objConceptVerEN.UpdDate = objRow[conConceptVer.UpdDate] == DBNull.Value ? null : objRow[conConceptVer.UpdDate].ToString().Trim(); //修改日期
objConceptVerEN.UpdUser = objRow[conConceptVer.UpdUser] == DBNull.Value ? null : objRow[conConceptVer.UpdUser].ToString().Trim(); //修改人
objConceptVerEN.IdCurrEduCls = objRow[conConceptVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conConceptVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objConceptVerEN.PdfContent = objRow[conConceptVer.PdfContent] == DBNull.Value ? null : objRow[conConceptVer.PdfContent].ToString().Trim(); //Pdf内容
objConceptVerEN.PdfPageNum = objRow[conConceptVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConceptVer.PdfPageNum].ToString().Trim()); //Pdf页码
objConceptVerEN.Memo = objRow[conConceptVer.Memo] == DBNull.Value ? null : objRow[conConceptVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objConceptVerEN.ConceptVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objConceptVerEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objConceptVerEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetConceptVer(ref clsConceptVerEN objConceptVerEN)
{
bool bolResult = ConceptVerDA.GetConceptVer(ref objConceptVerEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngConceptVId">表关键字</param>
 /// <returns>表对象</returns>
public static clsConceptVerEN GetObjByConceptVId(long lngConceptVId)
{
clsConceptVerEN objConceptVerEN = ConceptVerDA.GetObjByConceptVId(lngConceptVId);
return objConceptVerEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsConceptVerEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsConceptVerEN objConceptVerEN = ConceptVerDA.GetFirstObj(strWhereCond);
 return objConceptVerEN;
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
public static clsConceptVerEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsConceptVerEN objConceptVerEN = ConceptVerDA.GetObjByDataRow(objRow);
 return objConceptVerEN;
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
public static clsConceptVerEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsConceptVerEN objConceptVerEN = ConceptVerDA.GetObjByDataRow(objRow);
 return objConceptVerEN;
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
 /// <param name = "lstConceptVerObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsConceptVerEN GetObjByConceptVIdFromList(long lngConceptVId, List<clsConceptVerEN> lstConceptVerObjLst)
{
foreach (clsConceptVerEN objConceptVerEN in lstConceptVerObjLst)
{
if (objConceptVerEN.ConceptVId == lngConceptVId)
{
return objConceptVerEN;
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
 lngConceptVId = new clsConceptVerDA().GetFirstID(strWhereCond);
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
 arrList = ConceptVerDA.GetID(strWhereCond);
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
bool bolIsExist = ConceptVerDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = ConceptVerDA.IsExist(lngConceptVId);
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
 bolIsExist = clsConceptVerDA.IsExistTable();
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
 bolIsExist = ConceptVerDA.IsExistTable(strTabName);
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
 /// <param name = "objConceptVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsConceptVerEN objConceptVerEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objConceptVerEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!ConceptVId = [{0}]的数据已经存在!(in clsConceptVerBL.AddNewRecordBySql2)", objConceptVerEN.ConceptVId);
throw new Exception(strMsg);
}
try
{
bool bolResult = ConceptVerDA.AddNewRecordBySQL2(objConceptVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConceptVerBL.ReFreshCache();

if (clsConceptVerBL.relatedActions != null)
{
clsConceptVerBL.relatedActions.UpdRelaTabDate(objConceptVerEN.ConceptVId, "SetUpdDate");
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
 /// <param name = "objConceptVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsConceptVerEN objConceptVerEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objConceptVerEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!ConceptVId = [{0}]的数据已经存在!(in clsConceptVerBL.AddNewRecordBySql2WithReturnKey)", objConceptVerEN.ConceptVId);
throw new Exception(strMsg);
}
try
{
string strKey = ConceptVerDA.AddNewRecordBySQL2WithReturnKey(objConceptVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConceptVerBL.ReFreshCache();

if (clsConceptVerBL.relatedActions != null)
{
clsConceptVerBL.relatedActions.UpdRelaTabDate(objConceptVerEN.ConceptVId, "SetUpdDate");
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
 /// <param name = "objConceptVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsConceptVerEN objConceptVerEN)
{
try
{
bool bolResult = ConceptVerDA.Update(objConceptVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConceptVerBL.ReFreshCache();

if (clsConceptVerBL.relatedActions != null)
{
clsConceptVerBL.relatedActions.UpdRelaTabDate(objConceptVerEN.ConceptVId, "SetUpdDate");
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
 /// <param name = "objConceptVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsConceptVerEN objConceptVerEN)
{
 if (objConceptVerEN.ConceptVId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ConceptVerDA.UpdateBySql2(objConceptVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConceptVerBL.ReFreshCache();

if (clsConceptVerBL.relatedActions != null)
{
clsConceptVerBL.relatedActions.UpdRelaTabDate(objConceptVerEN.ConceptVId, "SetUpdDate");
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
 clsConceptVerEN objConceptVerEN = clsConceptVerBL.GetObjByConceptVId(lngConceptVId);

if (clsConceptVerBL.relatedActions != null)
{
clsConceptVerBL.relatedActions.UpdRelaTabDate(objConceptVerEN.ConceptVId, "SetUpdDate");
}
if (objConceptVerEN != null)
{
int intRecNum = ConceptVerDA.DelRecord(lngConceptVId);
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
objSQL = clsConceptVerDA.GetSpecSQLObj();
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
//删除与表:[ConceptVer]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conConceptVer.ConceptVId,
//lngConceptVId);
//        clsConceptVerBL.DelConceptVersByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsConceptVerBL.DelRecord(lngConceptVId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsConceptVerBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clsConceptVerBL.relatedActions != null)
{
clsConceptVerBL.relatedActions.UpdRelaTabDate(lngConceptVId, "UpdRelaTabDate");
}
bool bolResult = ConceptVerDA.DelRecord(lngConceptVId,objSqlConnection,objSqlTransaction);
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
public static int DelConceptVers(List<string> arrConceptVIdLst)
{
if (arrConceptVIdLst.Count == 0) return 0;
try
{
if (clsConceptVerBL.relatedActions != null)
{
foreach (var strConceptVId in arrConceptVIdLst)
{
long lngConceptVId = long.Parse(strConceptVId);
clsConceptVerBL.relatedActions.UpdRelaTabDate(lngConceptVId, "UpdRelaTabDate");
}
}
int intDelRecNum = ConceptVerDA.DelConceptVer(arrConceptVIdLst);
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
public static int DelConceptVersByCond(string strWhereCond)
{
try
{
if (clsConceptVerBL.relatedActions != null)
{
List<string> arrConceptVId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strConceptVId in arrConceptVId)
{
long lngConceptVId = long.Parse(strConceptVId);
clsConceptVerBL.relatedActions.UpdRelaTabDate(lngConceptVId, "UpdRelaTabDate");
}
}
int intRecNum = ConceptVerDA.DelConceptVer(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[ConceptVer]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngConceptVId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngConceptVId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsConceptVerDA.GetSpecSQLObj();
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
//删除与表:[ConceptVer]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsConceptVerBL.DelRecord(lngConceptVId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsConceptVerBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objConceptVerENS">源对象</param>
 /// <param name = "objConceptVerENT">目标对象</param>
 public static void CopyTo(clsConceptVerEN objConceptVerENS, clsConceptVerEN objConceptVerENT)
{
try
{
objConceptVerENT.ConceptVId = objConceptVerENS.ConceptVId; //ConceptVId
objConceptVerENT.ConceptId = objConceptVerENS.ConceptId; //概念Id
objConceptVerENT.ConceptContent = objConceptVerENS.ConceptContent; //概念内容
objConceptVerENT.ConceptName = objConceptVerENS.ConceptName; //概念名称
objConceptVerENT.CitationId = objConceptVerENS.CitationId; //引用Id
objConceptVerENT.UpdDate = objConceptVerENS.UpdDate; //修改日期
objConceptVerENT.UpdUser = objConceptVerENS.UpdUser; //修改人
objConceptVerENT.IdCurrEduCls = objConceptVerENS.IdCurrEduCls; //教学班流水号
objConceptVerENT.PdfContent = objConceptVerENS.PdfContent; //Pdf内容
objConceptVerENT.PdfPageNum = objConceptVerENS.PdfPageNum; //Pdf页码
objConceptVerENT.Memo = objConceptVerENS.Memo; //备注
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
 /// <param name = "objConceptVerEN">源简化对象</param>
 public static void SetUpdFlag(clsConceptVerEN objConceptVerEN)
{
try
{
objConceptVerEN.ClearUpdateState();
   string strsfUpdFldSetStr = objConceptVerEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conConceptVer.ConceptVId, new clsStrCompareIgnoreCase())  ==  true)
{
objConceptVerEN.ConceptVId = objConceptVerEN.ConceptVId; //ConceptVId
}
if (arrFldSet.Contains(conConceptVer.ConceptId, new clsStrCompareIgnoreCase())  ==  true)
{
objConceptVerEN.ConceptId = objConceptVerEN.ConceptId; //概念Id
}
if (arrFldSet.Contains(conConceptVer.ConceptContent, new clsStrCompareIgnoreCase())  ==  true)
{
objConceptVerEN.ConceptContent = objConceptVerEN.ConceptContent == "[null]" ? null :  objConceptVerEN.ConceptContent; //概念内容
}
if (arrFldSet.Contains(conConceptVer.ConceptName, new clsStrCompareIgnoreCase())  ==  true)
{
objConceptVerEN.ConceptName = objConceptVerEN.ConceptName == "[null]" ? null :  objConceptVerEN.ConceptName; //概念名称
}
if (arrFldSet.Contains(conConceptVer.CitationId, new clsStrCompareIgnoreCase())  ==  true)
{
objConceptVerEN.CitationId = objConceptVerEN.CitationId == "[null]" ? null :  objConceptVerEN.CitationId; //引用Id
}
if (arrFldSet.Contains(conConceptVer.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objConceptVerEN.UpdDate = objConceptVerEN.UpdDate == "[null]" ? null :  objConceptVerEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conConceptVer.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objConceptVerEN.UpdUser = objConceptVerEN.UpdUser == "[null]" ? null :  objConceptVerEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conConceptVer.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objConceptVerEN.IdCurrEduCls = objConceptVerEN.IdCurrEduCls == "[null]" ? null :  objConceptVerEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conConceptVer.PdfContent, new clsStrCompareIgnoreCase())  ==  true)
{
objConceptVerEN.PdfContent = objConceptVerEN.PdfContent == "[null]" ? null :  objConceptVerEN.PdfContent; //Pdf内容
}
if (arrFldSet.Contains(conConceptVer.PdfPageNum, new clsStrCompareIgnoreCase())  ==  true)
{
objConceptVerEN.PdfPageNum = objConceptVerEN.PdfPageNum; //Pdf页码
}
if (arrFldSet.Contains(conConceptVer.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objConceptVerEN.Memo = objConceptVerEN.Memo == "[null]" ? null :  objConceptVerEN.Memo; //备注
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
 /// <param name = "objConceptVerEN">源简化对象</param>
 public static void AccessFldValueNull(clsConceptVerEN objConceptVerEN)
{
try
{
if (objConceptVerEN.ConceptContent == "[null]") objConceptVerEN.ConceptContent = null; //概念内容
if (objConceptVerEN.ConceptName == "[null]") objConceptVerEN.ConceptName = null; //概念名称
if (objConceptVerEN.CitationId == "[null]") objConceptVerEN.CitationId = null; //引用Id
if (objConceptVerEN.UpdDate == "[null]") objConceptVerEN.UpdDate = null; //修改日期
if (objConceptVerEN.UpdUser == "[null]") objConceptVerEN.UpdUser = null; //修改人
if (objConceptVerEN.IdCurrEduCls == "[null]") objConceptVerEN.IdCurrEduCls = null; //教学班流水号
if (objConceptVerEN.PdfContent == "[null]") objConceptVerEN.PdfContent = null; //Pdf内容
if (objConceptVerEN.Memo == "[null]") objConceptVerEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsConceptVerEN objConceptVerEN)
{
 ConceptVerDA.CheckPropertyNew(objConceptVerEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsConceptVerEN objConceptVerEN)
{
 ConceptVerDA.CheckProperty4Condition(objConceptVerEN);
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
if (clsConceptVerBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsConceptVerBL没有刷新缓存机制(clsConceptVerBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ConceptVId");
//if (arrConceptVerObjLstCache == null)
//{
//arrConceptVerObjLstCache = ConceptVerDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngConceptVId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsConceptVerEN GetObjByConceptVIdCache(long lngConceptVId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsConceptVerEN._CurrTabName);
List<clsConceptVerEN> arrConceptVerObjLstCache = GetObjLstCache();
IEnumerable <clsConceptVerEN> arrConceptVerObjLst_Sel =
arrConceptVerObjLstCache
.Where(x=> x.ConceptVId == lngConceptVId 
);
if (arrConceptVerObjLst_Sel.Count() == 0)
{
   clsConceptVerEN obj = clsConceptVerBL.GetObjByConceptVId(lngConceptVId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrConceptVerObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsConceptVerEN> GetAllConceptVerObjLstCache()
{
//获取缓存中的对象列表
List<clsConceptVerEN> arrConceptVerObjLstCache = GetObjLstCache(); 
return arrConceptVerObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsConceptVerEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsConceptVerEN._CurrTabName);
List<clsConceptVerEN> arrConceptVerObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrConceptVerObjLstCache;
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
string strKey = string.Format("{0}", clsConceptVerEN._CurrTabName);
CacheHelper.Remove(strKey);
clsConceptVerEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsConceptVerEN._RefreshTimeLst.Count == 0) return "";
return clsConceptVerEN._RefreshTimeLst[clsConceptVerEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsConceptVerBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsConceptVerEN._CurrTabName);
CacheHelper.Remove(strKey);
clsConceptVerEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsConceptVerBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--ConceptVer(概念版本表)
 /// 唯一性条件:ConceptVId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objConceptVerEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsConceptVerEN objConceptVerEN)
{
//检测记录是否存在
string strResult = ConceptVerDA.GetUniCondStr(objConceptVerEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngConceptVId)
{
if (strInFldName != conConceptVer.ConceptVId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conConceptVer.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conConceptVer.AttributeName));
throw new Exception(strMsg);
}
var objConceptVer = clsConceptVerBL.GetObjByConceptVIdCache(lngConceptVId);
if (objConceptVer == null) return "";
return objConceptVer[strOutFldName].ToString();
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
int intRecCount = clsConceptVerDA.GetRecCount(strTabName);
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
int intRecCount = clsConceptVerDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsConceptVerDA.GetRecCount();
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
int intRecCount = clsConceptVerDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objConceptVerCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsConceptVerEN objConceptVerCond)
{
List<clsConceptVerEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsConceptVerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conConceptVer.AttributeName)
{
if (objConceptVerCond.IsUpdated(strFldName) == false) continue;
if (objConceptVerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objConceptVerCond[strFldName].ToString());
}
else
{
if (objConceptVerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objConceptVerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objConceptVerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objConceptVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objConceptVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objConceptVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objConceptVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objConceptVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objConceptVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objConceptVerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objConceptVerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objConceptVerCond[strFldName]));
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
 List<string> arrList = clsConceptVerDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ConceptVerDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ConceptVerDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ConceptVerDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsConceptVerDA.SetFldValue(clsConceptVerEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ConceptVerDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsConceptVerDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsConceptVerDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsConceptVerDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ConceptVer] "); 
 strCreateTabCode.Append(" ( "); 
 // /**ConceptVId*/ 
 strCreateTabCode.Append(" ConceptVId bigint primary key identity, "); 
 // /**概念Id*/ 
 strCreateTabCode.Append(" ConceptId char(8) not Null, "); 
 // /**概念内容*/ 
 strCreateTabCode.Append(" ConceptContent text Null, "); 
 // /**概念名称*/ 
 strCreateTabCode.Append(" ConceptName varchar(500) Null, "); 
 // /**引用Id*/ 
 strCreateTabCode.Append(" CitationId char(8) Null, "); 
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
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 概念版本表(ConceptVer)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4ConceptVer : clsCommFun4BL
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
clsConceptVerBL.ReFreshThisCache();
}
}

}