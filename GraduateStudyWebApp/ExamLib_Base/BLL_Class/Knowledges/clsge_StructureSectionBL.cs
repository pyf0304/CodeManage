
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_StructureSectionBL
 表名:ge_StructureSection(01120896)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:04:13
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
public static class  clsge_StructureSectionBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strStructureSectionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsge_StructureSectionEN GetObj(this K_StructureSectionId_ge_StructureSection myKey)
{
clsge_StructureSectionEN objge_StructureSectionEN = clsge_StructureSectionBL.ge_StructureSectionDA.GetObjByStructureSectionId(myKey.Value);
return objge_StructureSectionEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objge_StructureSectionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsge_StructureSectionEN objge_StructureSectionEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objge_StructureSectionEN) == false)
{
var strMsg = string.Format("记录已经存在!结构章节Id = [{0}]的数据已经存在!(in clsge_StructureSectionBL.AddNewRecord)", objge_StructureSectionEN.StructureSectionId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objge_StructureSectionEN.StructureSectionId) == true || clsge_StructureSectionBL.IsExist(objge_StructureSectionEN.StructureSectionId) == true)
 {
     objge_StructureSectionEN.StructureSectionId = clsge_StructureSectionBL.GetMaxStrId_S();
 }
bool bolResult = clsge_StructureSectionBL.ge_StructureSectionDA.AddNewRecordBySQL2(objge_StructureSectionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureSectionBL.ReFreshCache(objge_StructureSectionEN.CourseId);

if (clsge_StructureSectionBL.relatedActions != null)
{
clsge_StructureSectionBL.relatedActions.UpdRelaTabDate(objge_StructureSectionEN.StructureSectionId, "SetUpdDate");
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
public static bool AddRecordEx(this clsge_StructureSectionEN objge_StructureSectionEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsge_StructureSectionBL.IsExist(objge_StructureSectionEN.StructureSectionId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objge_StructureSectionEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objge_StructureSectionEN.CheckUniqueness() == false)
{
strMsg = string.Format("(结构章节Id(StructureSectionId)=[{0}])已经存在,不能重复!", objge_StructureSectionEN.StructureSectionId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objge_StructureSectionEN.StructureSectionId) == true || clsge_StructureSectionBL.IsExist(objge_StructureSectionEN.StructureSectionId) == true)
 {
     objge_StructureSectionEN.StructureSectionId = clsge_StructureSectionBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objge_StructureSectionEN.AddNewRecord();
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
 /// <param name = "objge_StructureSectionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsge_StructureSectionEN objge_StructureSectionEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objge_StructureSectionEN) == false)
{
var strMsg = string.Format("记录已经存在!结构章节Id = [{0}]的数据已经存在!(in clsge_StructureSectionBL.AddNewRecordWithMaxId)", objge_StructureSectionEN.StructureSectionId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objge_StructureSectionEN.StructureSectionId) == true || clsge_StructureSectionBL.IsExist(objge_StructureSectionEN.StructureSectionId) == true)
 {
     objge_StructureSectionEN.StructureSectionId = clsge_StructureSectionBL.GetMaxStrId_S();
 }
string strStructureSectionId = clsge_StructureSectionBL.ge_StructureSectionDA.AddNewRecordBySQL2WithReturnKey(objge_StructureSectionEN);
     objge_StructureSectionEN.StructureSectionId = strStructureSectionId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureSectionBL.ReFreshCache(objge_StructureSectionEN.CourseId);

if (clsge_StructureSectionBL.relatedActions != null)
{
clsge_StructureSectionBL.relatedActions.UpdRelaTabDate(objge_StructureSectionEN.StructureSectionId, "SetUpdDate");
}
return strStructureSectionId;
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
 /// <param name = "objge_StructureSectionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsge_StructureSectionEN objge_StructureSectionEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objge_StructureSectionEN) == false)
{
var strMsg = string.Format("记录已经存在!结构章节Id = [{0}]的数据已经存在!(in clsge_StructureSectionBL.AddNewRecordWithReturnKey)", objge_StructureSectionEN.StructureSectionId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objge_StructureSectionEN.StructureSectionId) == true || clsge_StructureSectionBL.IsExist(objge_StructureSectionEN.StructureSectionId) == true)
 {
     objge_StructureSectionEN.StructureSectionId = clsge_StructureSectionBL.GetMaxStrId_S();
 }
string strKey = clsge_StructureSectionBL.ge_StructureSectionDA.AddNewRecordBySQL2WithReturnKey(objge_StructureSectionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureSectionBL.ReFreshCache(objge_StructureSectionEN.CourseId);

if (clsge_StructureSectionBL.relatedActions != null)
{
clsge_StructureSectionBL.relatedActions.UpdRelaTabDate(objge_StructureSectionEN.StructureSectionId, "SetUpdDate");
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
 /// <param name = "objge_StructureSectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureSectionEN SetStructureSectionId(this clsge_StructureSectionEN objge_StructureSectionEN, string strStructureSectionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStructureSectionId, 10, conge_StructureSection.StructureSectionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strStructureSectionId, 10, conge_StructureSection.StructureSectionId);
}
objge_StructureSectionEN.StructureSectionId = strStructureSectionId; //结构章节Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureSectionEN.dicFldComparisonOp.ContainsKey(conge_StructureSection.StructureSectionId) == false)
{
objge_StructureSectionEN.dicFldComparisonOp.Add(conge_StructureSection.StructureSectionId, strComparisonOp);
}
else
{
objge_StructureSectionEN.dicFldComparisonOp[conge_StructureSection.StructureSectionId] = strComparisonOp;
}
}
return objge_StructureSectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureSectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureSectionEN SetStructureSectionName(this clsge_StructureSectionEN objge_StructureSectionEN, string strStructureSectionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStructureSectionName, conge_StructureSection.StructureSectionName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStructureSectionName, 50, conge_StructureSection.StructureSectionName);
}
objge_StructureSectionEN.StructureSectionName = strStructureSectionName; //结构章节名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureSectionEN.dicFldComparisonOp.ContainsKey(conge_StructureSection.StructureSectionName) == false)
{
objge_StructureSectionEN.dicFldComparisonOp.Add(conge_StructureSection.StructureSectionName, strComparisonOp);
}
else
{
objge_StructureSectionEN.dicFldComparisonOp[conge_StructureSection.StructureSectionName] = strComparisonOp;
}
}
return objge_StructureSectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureSectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureSectionEN SetStructureSectionContent(this clsge_StructureSectionEN objge_StructureSectionEN, string strStructureSectionContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStructureSectionContent, 3000, conge_StructureSection.StructureSectionContent);
}
objge_StructureSectionEN.StructureSectionContent = strStructureSectionContent; //结构章节内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureSectionEN.dicFldComparisonOp.ContainsKey(conge_StructureSection.StructureSectionContent) == false)
{
objge_StructureSectionEN.dicFldComparisonOp.Add(conge_StructureSection.StructureSectionContent, strComparisonOp);
}
else
{
objge_StructureSectionEN.dicFldComparisonOp[conge_StructureSection.StructureSectionContent] = strComparisonOp;
}
}
return objge_StructureSectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureSectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureSectionEN SetCourseId(this clsge_StructureSectionEN objge_StructureSectionEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, conge_StructureSection.CourseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, conge_StructureSection.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, conge_StructureSection.CourseId);
}
objge_StructureSectionEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureSectionEN.dicFldComparisonOp.ContainsKey(conge_StructureSection.CourseId) == false)
{
objge_StructureSectionEN.dicFldComparisonOp.Add(conge_StructureSection.CourseId, strComparisonOp);
}
else
{
objge_StructureSectionEN.dicFldComparisonOp[conge_StructureSection.CourseId] = strComparisonOp;
}
}
return objge_StructureSectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureSectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureSectionEN SetIsShow(this clsge_StructureSectionEN objge_StructureSectionEN, bool bolIsShow, string strComparisonOp="")
	{
objge_StructureSectionEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureSectionEN.dicFldComparisonOp.ContainsKey(conge_StructureSection.IsShow) == false)
{
objge_StructureSectionEN.dicFldComparisonOp.Add(conge_StructureSection.IsShow, strComparisonOp);
}
else
{
objge_StructureSectionEN.dicFldComparisonOp[conge_StructureSection.IsShow] = strComparisonOp;
}
}
return objge_StructureSectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureSectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureSectionEN SetUpdDate(this clsge_StructureSectionEN objge_StructureSectionEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conge_StructureSection.UpdDate);
}
objge_StructureSectionEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureSectionEN.dicFldComparisonOp.ContainsKey(conge_StructureSection.UpdDate) == false)
{
objge_StructureSectionEN.dicFldComparisonOp.Add(conge_StructureSection.UpdDate, strComparisonOp);
}
else
{
objge_StructureSectionEN.dicFldComparisonOp[conge_StructureSection.UpdDate] = strComparisonOp;
}
}
return objge_StructureSectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureSectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureSectionEN SetUpdUser(this clsge_StructureSectionEN objge_StructureSectionEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conge_StructureSection.UpdUser);
}
objge_StructureSectionEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureSectionEN.dicFldComparisonOp.ContainsKey(conge_StructureSection.UpdUser) == false)
{
objge_StructureSectionEN.dicFldComparisonOp.Add(conge_StructureSection.UpdUser, strComparisonOp);
}
else
{
objge_StructureSectionEN.dicFldComparisonOp[conge_StructureSection.UpdUser] = strComparisonOp;
}
}
return objge_StructureSectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureSectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureSectionEN SetMemo(this clsge_StructureSectionEN objge_StructureSectionEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conge_StructureSection.Memo);
}
objge_StructureSectionEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureSectionEN.dicFldComparisonOp.ContainsKey(conge_StructureSection.Memo) == false)
{
objge_StructureSectionEN.dicFldComparisonOp.Add(conge_StructureSection.Memo, strComparisonOp);
}
else
{
objge_StructureSectionEN.dicFldComparisonOp[conge_StructureSection.Memo] = strComparisonOp;
}
}
return objge_StructureSectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureSectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureSectionEN SetSectionTypeId(this clsge_StructureSectionEN objge_StructureSectionEN, string strSectionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSectionTypeId, conge_StructureSection.SectionTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionTypeId, 8, conge_StructureSection.SectionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSectionTypeId, 8, conge_StructureSection.SectionTypeId);
}
objge_StructureSectionEN.SectionTypeId = strSectionTypeId; //节点类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureSectionEN.dicFldComparisonOp.ContainsKey(conge_StructureSection.SectionTypeId) == false)
{
objge_StructureSectionEN.dicFldComparisonOp.Add(conge_StructureSection.SectionTypeId, strComparisonOp);
}
else
{
objge_StructureSectionEN.dicFldComparisonOp[conge_StructureSection.SectionTypeId] = strComparisonOp;
}
}
return objge_StructureSectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureSectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureSectionEN SetDirection(this clsge_StructureSectionEN objge_StructureSectionEN, string strDirection, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDirection, 50, conge_StructureSection.Direction);
}
objge_StructureSectionEN.Direction = strDirection; //方向
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureSectionEN.dicFldComparisonOp.ContainsKey(conge_StructureSection.Direction) == false)
{
objge_StructureSectionEN.dicFldComparisonOp.Add(conge_StructureSection.Direction, strComparisonOp);
}
else
{
objge_StructureSectionEN.dicFldComparisonOp[conge_StructureSection.Direction] = strComparisonOp;
}
}
return objge_StructureSectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureSectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureSectionEN SetIsExpanded(this clsge_StructureSectionEN objge_StructureSectionEN, bool bolIsExpanded, string strComparisonOp="")
	{
objge_StructureSectionEN.IsExpanded = bolIsExpanded; //是否扩展
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureSectionEN.dicFldComparisonOp.ContainsKey(conge_StructureSection.IsExpanded) == false)
{
objge_StructureSectionEN.dicFldComparisonOp.Add(conge_StructureSection.IsExpanded, strComparisonOp);
}
else
{
objge_StructureSectionEN.dicFldComparisonOp[conge_StructureSection.IsExpanded] = strComparisonOp;
}
}
return objge_StructureSectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureSectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureSectionEN SetIsRoot(this clsge_StructureSectionEN objge_StructureSectionEN, bool bolIsRoot, string strComparisonOp="")
	{
objge_StructureSectionEN.IsRoot = bolIsRoot; //IsRoot
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureSectionEN.dicFldComparisonOp.ContainsKey(conge_StructureSection.IsRoot) == false)
{
objge_StructureSectionEN.dicFldComparisonOp.Add(conge_StructureSection.IsRoot, strComparisonOp);
}
else
{
objge_StructureSectionEN.dicFldComparisonOp[conge_StructureSection.IsRoot] = strComparisonOp;
}
}
return objge_StructureSectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureSectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureSectionEN SetParentId(this clsge_StructureSectionEN objge_StructureSectionEN, string strParentId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentId, 10, conge_StructureSection.ParentId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strParentId, 10, conge_StructureSection.ParentId);
}
objge_StructureSectionEN.ParentId = strParentId; //父节点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureSectionEN.dicFldComparisonOp.ContainsKey(conge_StructureSection.ParentId) == false)
{
objge_StructureSectionEN.dicFldComparisonOp.Add(conge_StructureSection.ParentId, strComparisonOp);
}
else
{
objge_StructureSectionEN.dicFldComparisonOp[conge_StructureSection.ParentId] = strComparisonOp;
}
}
return objge_StructureSectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureSectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureSectionEN SetOrderNum(this clsge_StructureSectionEN objge_StructureSectionEN, int? intOrderNum, string strComparisonOp="")
	{
objge_StructureSectionEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureSectionEN.dicFldComparisonOp.ContainsKey(conge_StructureSection.OrderNum) == false)
{
objge_StructureSectionEN.dicFldComparisonOp.Add(conge_StructureSection.OrderNum, strComparisonOp);
}
else
{
objge_StructureSectionEN.dicFldComparisonOp[conge_StructureSection.OrderNum] = strComparisonOp;
}
}
return objge_StructureSectionEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objge_StructureSectionEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsge_StructureSectionEN objge_StructureSectionEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objge_StructureSectionEN.CheckPropertyNew();
clsge_StructureSectionEN objge_StructureSectionCond = new clsge_StructureSectionEN();
string strCondition = objge_StructureSectionCond
.SetStructureSectionId(objge_StructureSectionEN.StructureSectionId, "<>")
.SetStructureSectionId(objge_StructureSectionEN.StructureSectionId, "=")
.GetCombineCondition();
objge_StructureSectionEN._IsCheckProperty = true;
bool bolIsExist = clsge_StructureSectionBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(StructureSectionId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objge_StructureSectionEN.Update();
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
 /// <param name = "objge_StructureSection">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsge_StructureSectionEN objge_StructureSection)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsge_StructureSectionEN objge_StructureSectionCond = new clsge_StructureSectionEN();
string strCondition = objge_StructureSectionCond
.SetStructureSectionId(objge_StructureSection.StructureSectionId, "=")
.GetCombineCondition();
objge_StructureSection._IsCheckProperty = true;
bool bolIsExist = clsge_StructureSectionBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objge_StructureSection.StructureSectionId = clsge_StructureSectionBL.GetFirstID_S(strCondition);
objge_StructureSection.UpdateWithCondition(strCondition);
}
else
{
objge_StructureSection.StructureSectionId = clsge_StructureSectionBL.GetMaxStrId_S();
objge_StructureSection.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objge_StructureSectionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsge_StructureSectionEN objge_StructureSectionEN)
{
 if (string.IsNullOrEmpty(objge_StructureSectionEN.StructureSectionId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsge_StructureSectionBL.ge_StructureSectionDA.UpdateBySql2(objge_StructureSectionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureSectionBL.ReFreshCache(objge_StructureSectionEN.CourseId);

if (clsge_StructureSectionBL.relatedActions != null)
{
clsge_StructureSectionBL.relatedActions.UpdRelaTabDate(objge_StructureSectionEN.StructureSectionId, "SetUpdDate");
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
 /// <param name = "objge_StructureSectionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsge_StructureSectionEN objge_StructureSectionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objge_StructureSectionEN.StructureSectionId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsge_StructureSectionBL.ge_StructureSectionDA.UpdateBySql2(objge_StructureSectionEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureSectionBL.ReFreshCache(objge_StructureSectionEN.CourseId);

if (clsge_StructureSectionBL.relatedActions != null)
{
clsge_StructureSectionBL.relatedActions.UpdRelaTabDate(objge_StructureSectionEN.StructureSectionId, "SetUpdDate");
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
 /// <param name = "objge_StructureSectionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsge_StructureSectionEN objge_StructureSectionEN, string strWhereCond)
{
try
{
bool bolResult = clsge_StructureSectionBL.ge_StructureSectionDA.UpdateBySqlWithCondition(objge_StructureSectionEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureSectionBL.ReFreshCache(objge_StructureSectionEN.CourseId);

if (clsge_StructureSectionBL.relatedActions != null)
{
clsge_StructureSectionBL.relatedActions.UpdRelaTabDate(objge_StructureSectionEN.StructureSectionId, "SetUpdDate");
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
 /// <param name = "objge_StructureSectionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsge_StructureSectionEN objge_StructureSectionEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsge_StructureSectionBL.ge_StructureSectionDA.UpdateBySqlWithConditionTransaction(objge_StructureSectionEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureSectionBL.ReFreshCache(objge_StructureSectionEN.CourseId);

if (clsge_StructureSectionBL.relatedActions != null)
{
clsge_StructureSectionBL.relatedActions.UpdRelaTabDate(objge_StructureSectionEN.StructureSectionId, "SetUpdDate");
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
 /// <param name = "strStructureSectionId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsge_StructureSectionEN objge_StructureSectionEN)
{
try
{
int intRecNum = clsge_StructureSectionBL.ge_StructureSectionDA.DelRecord(objge_StructureSectionEN.StructureSectionId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureSectionBL.ReFreshCache(objge_StructureSectionEN.CourseId);

if (clsge_StructureSectionBL.relatedActions != null)
{
clsge_StructureSectionBL.relatedActions.UpdRelaTabDate(objge_StructureSectionEN.StructureSectionId, "SetUpdDate");
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
 /// <param name = "objge_StructureSectionENS">源对象</param>
 /// <param name = "objge_StructureSectionENT">目标对象</param>
 public static void CopyTo(this clsge_StructureSectionEN objge_StructureSectionENS, clsge_StructureSectionEN objge_StructureSectionENT)
{
try
{
objge_StructureSectionENT.StructureSectionId = objge_StructureSectionENS.StructureSectionId; //结构章节Id
objge_StructureSectionENT.StructureSectionName = objge_StructureSectionENS.StructureSectionName; //结构章节名称
objge_StructureSectionENT.StructureSectionContent = objge_StructureSectionENS.StructureSectionContent; //结构章节内容
objge_StructureSectionENT.CourseId = objge_StructureSectionENS.CourseId; //课程Id
objge_StructureSectionENT.IsShow = objge_StructureSectionENS.IsShow; //是否启用
objge_StructureSectionENT.UpdDate = objge_StructureSectionENS.UpdDate; //修改日期
objge_StructureSectionENT.UpdUser = objge_StructureSectionENS.UpdUser; //修改人
objge_StructureSectionENT.Memo = objge_StructureSectionENS.Memo; //备注
objge_StructureSectionENT.SectionTypeId = objge_StructureSectionENS.SectionTypeId; //节点类型Id
objge_StructureSectionENT.Direction = objge_StructureSectionENS.Direction; //方向
objge_StructureSectionENT.IsExpanded = objge_StructureSectionENS.IsExpanded; //是否扩展
objge_StructureSectionENT.IsRoot = objge_StructureSectionENS.IsRoot; //IsRoot
objge_StructureSectionENT.ParentId = objge_StructureSectionENS.ParentId; //父节点Id
objge_StructureSectionENT.OrderNum = objge_StructureSectionENS.OrderNum; //序号
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
 /// <param name = "objge_StructureSectionENS">源对象</param>
 /// <returns>目标对象=>clsge_StructureSectionEN:objge_StructureSectionENT</returns>
 public static clsge_StructureSectionEN CopyTo(this clsge_StructureSectionEN objge_StructureSectionENS)
{
try
{
 clsge_StructureSectionEN objge_StructureSectionENT = new clsge_StructureSectionEN()
{
StructureSectionId = objge_StructureSectionENS.StructureSectionId, //结构章节Id
StructureSectionName = objge_StructureSectionENS.StructureSectionName, //结构章节名称
StructureSectionContent = objge_StructureSectionENS.StructureSectionContent, //结构章节内容
CourseId = objge_StructureSectionENS.CourseId, //课程Id
IsShow = objge_StructureSectionENS.IsShow, //是否启用
UpdDate = objge_StructureSectionENS.UpdDate, //修改日期
UpdUser = objge_StructureSectionENS.UpdUser, //修改人
Memo = objge_StructureSectionENS.Memo, //备注
SectionTypeId = objge_StructureSectionENS.SectionTypeId, //节点类型Id
Direction = objge_StructureSectionENS.Direction, //方向
IsExpanded = objge_StructureSectionENS.IsExpanded, //是否扩展
IsRoot = objge_StructureSectionENS.IsRoot, //IsRoot
ParentId = objge_StructureSectionENS.ParentId, //父节点Id
OrderNum = objge_StructureSectionENS.OrderNum, //序号
};
 return objge_StructureSectionENT;
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
public static void CheckPropertyNew(this clsge_StructureSectionEN objge_StructureSectionEN)
{
 clsge_StructureSectionBL.ge_StructureSectionDA.CheckPropertyNew(objge_StructureSectionEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsge_StructureSectionEN objge_StructureSectionEN)
{
 clsge_StructureSectionBL.ge_StructureSectionDA.CheckProperty4Condition(objge_StructureSectionEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsge_StructureSectionEN objge_StructureSectionCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objge_StructureSectionCond.IsUpdated(conge_StructureSection.StructureSectionId) == true)
{
string strComparisonOpStructureSectionId = objge_StructureSectionCond.dicFldComparisonOp[conge_StructureSection.StructureSectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StructureSection.StructureSectionId, objge_StructureSectionCond.StructureSectionId, strComparisonOpStructureSectionId);
}
if (objge_StructureSectionCond.IsUpdated(conge_StructureSection.StructureSectionName) == true)
{
string strComparisonOpStructureSectionName = objge_StructureSectionCond.dicFldComparisonOp[conge_StructureSection.StructureSectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StructureSection.StructureSectionName, objge_StructureSectionCond.StructureSectionName, strComparisonOpStructureSectionName);
}
if (objge_StructureSectionCond.IsUpdated(conge_StructureSection.StructureSectionContent) == true)
{
string strComparisonOpStructureSectionContent = objge_StructureSectionCond.dicFldComparisonOp[conge_StructureSection.StructureSectionContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StructureSection.StructureSectionContent, objge_StructureSectionCond.StructureSectionContent, strComparisonOpStructureSectionContent);
}
if (objge_StructureSectionCond.IsUpdated(conge_StructureSection.CourseId) == true)
{
string strComparisonOpCourseId = objge_StructureSectionCond.dicFldComparisonOp[conge_StructureSection.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StructureSection.CourseId, objge_StructureSectionCond.CourseId, strComparisonOpCourseId);
}
if (objge_StructureSectionCond.IsUpdated(conge_StructureSection.IsShow) == true)
{
if (objge_StructureSectionCond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", conge_StructureSection.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conge_StructureSection.IsShow);
}
}
if (objge_StructureSectionCond.IsUpdated(conge_StructureSection.UpdDate) == true)
{
string strComparisonOpUpdDate = objge_StructureSectionCond.dicFldComparisonOp[conge_StructureSection.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StructureSection.UpdDate, objge_StructureSectionCond.UpdDate, strComparisonOpUpdDate);
}
if (objge_StructureSectionCond.IsUpdated(conge_StructureSection.UpdUser) == true)
{
string strComparisonOpUpdUser = objge_StructureSectionCond.dicFldComparisonOp[conge_StructureSection.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StructureSection.UpdUser, objge_StructureSectionCond.UpdUser, strComparisonOpUpdUser);
}
if (objge_StructureSectionCond.IsUpdated(conge_StructureSection.Memo) == true)
{
string strComparisonOpMemo = objge_StructureSectionCond.dicFldComparisonOp[conge_StructureSection.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StructureSection.Memo, objge_StructureSectionCond.Memo, strComparisonOpMemo);
}
if (objge_StructureSectionCond.IsUpdated(conge_StructureSection.SectionTypeId) == true)
{
string strComparisonOpSectionTypeId = objge_StructureSectionCond.dicFldComparisonOp[conge_StructureSection.SectionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StructureSection.SectionTypeId, objge_StructureSectionCond.SectionTypeId, strComparisonOpSectionTypeId);
}
if (objge_StructureSectionCond.IsUpdated(conge_StructureSection.Direction) == true)
{
string strComparisonOpDirection = objge_StructureSectionCond.dicFldComparisonOp[conge_StructureSection.Direction];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StructureSection.Direction, objge_StructureSectionCond.Direction, strComparisonOpDirection);
}
if (objge_StructureSectionCond.IsUpdated(conge_StructureSection.IsExpanded) == true)
{
if (objge_StructureSectionCond.IsExpanded == true)
{
strWhereCond += string.Format(" And {0} = '1'", conge_StructureSection.IsExpanded);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conge_StructureSection.IsExpanded);
}
}
if (objge_StructureSectionCond.IsUpdated(conge_StructureSection.IsRoot) == true)
{
if (objge_StructureSectionCond.IsRoot == true)
{
strWhereCond += string.Format(" And {0} = '1'", conge_StructureSection.IsRoot);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conge_StructureSection.IsRoot);
}
}
if (objge_StructureSectionCond.IsUpdated(conge_StructureSection.ParentId) == true)
{
string strComparisonOpParentId = objge_StructureSectionCond.dicFldComparisonOp[conge_StructureSection.ParentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StructureSection.ParentId, objge_StructureSectionCond.ParentId, strComparisonOpParentId);
}
if (objge_StructureSectionCond.IsUpdated(conge_StructureSection.OrderNum) == true)
{
string strComparisonOpOrderNum = objge_StructureSectionCond.dicFldComparisonOp[conge_StructureSection.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conge_StructureSection.OrderNum, objge_StructureSectionCond.OrderNum, strComparisonOpOrderNum);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--ge_StructureSection(结构章节), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:StructureSectionId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objge_StructureSectionEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsge_StructureSectionEN objge_StructureSectionEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objge_StructureSectionEN == null) return true;
if (objge_StructureSectionEN.StructureSectionId == null || objge_StructureSectionEN.StructureSectionId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and StructureSectionId = '{0}'", objge_StructureSectionEN.StructureSectionId);
if (clsge_StructureSectionBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("StructureSectionId !=  '{0}'", objge_StructureSectionEN.StructureSectionId);
 sbCondition.AppendFormat(" and StructureSectionId = '{0}'", objge_StructureSectionEN.StructureSectionId);
if (clsge_StructureSectionBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--ge_StructureSection(结构章节), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:StructureSectionId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objge_StructureSectionEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsge_StructureSectionEN objge_StructureSectionEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objge_StructureSectionEN == null) return "";
if (objge_StructureSectionEN.StructureSectionId == null || objge_StructureSectionEN.StructureSectionId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and StructureSectionId = '{0}'", objge_StructureSectionEN.StructureSectionId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("StructureSectionId !=  '{0}'", objge_StructureSectionEN.StructureSectionId);
 sbCondition.AppendFormat(" and StructureSectionId = '{0}'", objge_StructureSectionEN.StructureSectionId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ge_StructureSection
{
public virtual bool UpdRelaTabDate(string strStructureSectionId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 结构章节(ge_StructureSection)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsge_StructureSectionBL
{
public static RelatedActions_ge_StructureSection relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsge_StructureSectionDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsge_StructureSectionDA ge_StructureSectionDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsge_StructureSectionDA();
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
 public clsge_StructureSectionBL()
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
if (string.IsNullOrEmpty(clsge_StructureSectionEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsge_StructureSectionEN._ConnectString);
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
public static DataTable GetDataTable_ge_StructureSection(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ge_StructureSectionDA.GetDataTable_ge_StructureSection(strWhereCond);
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
objDT = ge_StructureSectionDA.GetDataTable(strWhereCond);
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
objDT = ge_StructureSectionDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ge_StructureSectionDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ge_StructureSectionDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ge_StructureSectionDA.GetDataTable_Top(objTopPara);
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
objDT = ge_StructureSectionDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ge_StructureSectionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ge_StructureSectionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrStructureSectionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsge_StructureSectionEN> GetObjLstByStructureSectionIdLst(List<string> arrStructureSectionIdLst)
{
List<clsge_StructureSectionEN> arrObjLst = new List<clsge_StructureSectionEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrStructureSectionIdLst, true);
 string strWhereCond = string.Format("StructureSectionId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StructureSectionEN objge_StructureSectionEN = new clsge_StructureSectionEN();
try
{
objge_StructureSectionEN.StructureSectionId = objRow[conge_StructureSection.StructureSectionId].ToString().Trim(); //结构章节Id
objge_StructureSectionEN.StructureSectionName = objRow[conge_StructureSection.StructureSectionName].ToString().Trim(); //结构章节名称
objge_StructureSectionEN.StructureSectionContent = objRow[conge_StructureSection.StructureSectionContent] == DBNull.Value ? null : objRow[conge_StructureSection.StructureSectionContent].ToString().Trim(); //结构章节内容
objge_StructureSectionEN.CourseId = objRow[conge_StructureSection.CourseId].ToString().Trim(); //课程Id
objge_StructureSectionEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureSection.IsShow].ToString().Trim()); //是否启用
objge_StructureSectionEN.UpdDate = objRow[conge_StructureSection.UpdDate] == DBNull.Value ? null : objRow[conge_StructureSection.UpdDate].ToString().Trim(); //修改日期
objge_StructureSectionEN.UpdUser = objRow[conge_StructureSection.UpdUser] == DBNull.Value ? null : objRow[conge_StructureSection.UpdUser].ToString().Trim(); //修改人
objge_StructureSectionEN.Memo = objRow[conge_StructureSection.Memo] == DBNull.Value ? null : objRow[conge_StructureSection.Memo].ToString().Trim(); //备注
objge_StructureSectionEN.SectionTypeId = objRow[conge_StructureSection.SectionTypeId].ToString().Trim(); //节点类型Id
objge_StructureSectionEN.Direction = objRow[conge_StructureSection.Direction] == DBNull.Value ? null : objRow[conge_StructureSection.Direction].ToString().Trim(); //方向
objge_StructureSectionEN.IsExpanded = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureSection.IsExpanded].ToString().Trim()); //是否扩展
objge_StructureSectionEN.IsRoot = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureSection.IsRoot].ToString().Trim()); //IsRoot
objge_StructureSectionEN.ParentId = objRow[conge_StructureSection.ParentId] == DBNull.Value ? null : objRow[conge_StructureSection.ParentId].ToString().Trim(); //父节点Id
objge_StructureSectionEN.OrderNum = objRow[conge_StructureSection.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StructureSection.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StructureSectionEN.StructureSectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StructureSectionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrStructureSectionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsge_StructureSectionEN> GetObjLstByStructureSectionIdLstCache(List<string> arrStructureSectionIdLst, string strCourseId)
{
string strKey = string.Format("{0}_{1}", clsge_StructureSectionEN._CurrTabName, strCourseId);
List<clsge_StructureSectionEN> arrge_StructureSectionObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsge_StructureSectionEN> arrge_StructureSectionObjLst_Sel =
arrge_StructureSectionObjLstCache
.Where(x => arrStructureSectionIdLst.Contains(x.StructureSectionId));
return arrge_StructureSectionObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_StructureSectionEN> GetObjLst(string strWhereCond)
{
List<clsge_StructureSectionEN> arrObjLst = new List<clsge_StructureSectionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StructureSectionEN objge_StructureSectionEN = new clsge_StructureSectionEN();
try
{
objge_StructureSectionEN.StructureSectionId = objRow[conge_StructureSection.StructureSectionId].ToString().Trim(); //结构章节Id
objge_StructureSectionEN.StructureSectionName = objRow[conge_StructureSection.StructureSectionName].ToString().Trim(); //结构章节名称
objge_StructureSectionEN.StructureSectionContent = objRow[conge_StructureSection.StructureSectionContent] == DBNull.Value ? null : objRow[conge_StructureSection.StructureSectionContent].ToString().Trim(); //结构章节内容
objge_StructureSectionEN.CourseId = objRow[conge_StructureSection.CourseId].ToString().Trim(); //课程Id
objge_StructureSectionEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureSection.IsShow].ToString().Trim()); //是否启用
objge_StructureSectionEN.UpdDate = objRow[conge_StructureSection.UpdDate] == DBNull.Value ? null : objRow[conge_StructureSection.UpdDate].ToString().Trim(); //修改日期
objge_StructureSectionEN.UpdUser = objRow[conge_StructureSection.UpdUser] == DBNull.Value ? null : objRow[conge_StructureSection.UpdUser].ToString().Trim(); //修改人
objge_StructureSectionEN.Memo = objRow[conge_StructureSection.Memo] == DBNull.Value ? null : objRow[conge_StructureSection.Memo].ToString().Trim(); //备注
objge_StructureSectionEN.SectionTypeId = objRow[conge_StructureSection.SectionTypeId].ToString().Trim(); //节点类型Id
objge_StructureSectionEN.Direction = objRow[conge_StructureSection.Direction] == DBNull.Value ? null : objRow[conge_StructureSection.Direction].ToString().Trim(); //方向
objge_StructureSectionEN.IsExpanded = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureSection.IsExpanded].ToString().Trim()); //是否扩展
objge_StructureSectionEN.IsRoot = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureSection.IsRoot].ToString().Trim()); //IsRoot
objge_StructureSectionEN.ParentId = objRow[conge_StructureSection.ParentId] == DBNull.Value ? null : objRow[conge_StructureSection.ParentId].ToString().Trim(); //父节点Id
objge_StructureSectionEN.OrderNum = objRow[conge_StructureSection.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StructureSection.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StructureSectionEN.StructureSectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StructureSectionEN);
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
public static List<clsge_StructureSectionEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsge_StructureSectionEN> arrObjLst = new List<clsge_StructureSectionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StructureSectionEN objge_StructureSectionEN = new clsge_StructureSectionEN();
try
{
objge_StructureSectionEN.StructureSectionId = objRow[conge_StructureSection.StructureSectionId].ToString().Trim(); //结构章节Id
objge_StructureSectionEN.StructureSectionName = objRow[conge_StructureSection.StructureSectionName].ToString().Trim(); //结构章节名称
objge_StructureSectionEN.StructureSectionContent = objRow[conge_StructureSection.StructureSectionContent] == DBNull.Value ? null : objRow[conge_StructureSection.StructureSectionContent].ToString().Trim(); //结构章节内容
objge_StructureSectionEN.CourseId = objRow[conge_StructureSection.CourseId].ToString().Trim(); //课程Id
objge_StructureSectionEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureSection.IsShow].ToString().Trim()); //是否启用
objge_StructureSectionEN.UpdDate = objRow[conge_StructureSection.UpdDate] == DBNull.Value ? null : objRow[conge_StructureSection.UpdDate].ToString().Trim(); //修改日期
objge_StructureSectionEN.UpdUser = objRow[conge_StructureSection.UpdUser] == DBNull.Value ? null : objRow[conge_StructureSection.UpdUser].ToString().Trim(); //修改人
objge_StructureSectionEN.Memo = objRow[conge_StructureSection.Memo] == DBNull.Value ? null : objRow[conge_StructureSection.Memo].ToString().Trim(); //备注
objge_StructureSectionEN.SectionTypeId = objRow[conge_StructureSection.SectionTypeId].ToString().Trim(); //节点类型Id
objge_StructureSectionEN.Direction = objRow[conge_StructureSection.Direction] == DBNull.Value ? null : objRow[conge_StructureSection.Direction].ToString().Trim(); //方向
objge_StructureSectionEN.IsExpanded = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureSection.IsExpanded].ToString().Trim()); //是否扩展
objge_StructureSectionEN.IsRoot = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureSection.IsRoot].ToString().Trim()); //IsRoot
objge_StructureSectionEN.ParentId = objRow[conge_StructureSection.ParentId] == DBNull.Value ? null : objRow[conge_StructureSection.ParentId].ToString().Trim(); //父节点Id
objge_StructureSectionEN.OrderNum = objRow[conge_StructureSection.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StructureSection.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StructureSectionEN.StructureSectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StructureSectionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objge_StructureSectionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsge_StructureSectionEN> GetSubObjLstCache(clsge_StructureSectionEN objge_StructureSectionCond)
{
 string strCourseId = objge_StructureSectionCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsge_StructureSectionBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsge_StructureSectionEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsge_StructureSectionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conge_StructureSection.AttributeName)
{
if (objge_StructureSectionCond.IsUpdated(strFldName) == false) continue;
if (objge_StructureSectionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_StructureSectionCond[strFldName].ToString());
}
else
{
if (objge_StructureSectionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objge_StructureSectionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_StructureSectionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objge_StructureSectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objge_StructureSectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objge_StructureSectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objge_StructureSectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objge_StructureSectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objge_StructureSectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objge_StructureSectionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objge_StructureSectionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objge_StructureSectionCond[strFldName]));
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
public static List<clsge_StructureSectionEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsge_StructureSectionEN> arrObjLst = new List<clsge_StructureSectionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StructureSectionEN objge_StructureSectionEN = new clsge_StructureSectionEN();
try
{
objge_StructureSectionEN.StructureSectionId = objRow[conge_StructureSection.StructureSectionId].ToString().Trim(); //结构章节Id
objge_StructureSectionEN.StructureSectionName = objRow[conge_StructureSection.StructureSectionName].ToString().Trim(); //结构章节名称
objge_StructureSectionEN.StructureSectionContent = objRow[conge_StructureSection.StructureSectionContent] == DBNull.Value ? null : objRow[conge_StructureSection.StructureSectionContent].ToString().Trim(); //结构章节内容
objge_StructureSectionEN.CourseId = objRow[conge_StructureSection.CourseId].ToString().Trim(); //课程Id
objge_StructureSectionEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureSection.IsShow].ToString().Trim()); //是否启用
objge_StructureSectionEN.UpdDate = objRow[conge_StructureSection.UpdDate] == DBNull.Value ? null : objRow[conge_StructureSection.UpdDate].ToString().Trim(); //修改日期
objge_StructureSectionEN.UpdUser = objRow[conge_StructureSection.UpdUser] == DBNull.Value ? null : objRow[conge_StructureSection.UpdUser].ToString().Trim(); //修改人
objge_StructureSectionEN.Memo = objRow[conge_StructureSection.Memo] == DBNull.Value ? null : objRow[conge_StructureSection.Memo].ToString().Trim(); //备注
objge_StructureSectionEN.SectionTypeId = objRow[conge_StructureSection.SectionTypeId].ToString().Trim(); //节点类型Id
objge_StructureSectionEN.Direction = objRow[conge_StructureSection.Direction] == DBNull.Value ? null : objRow[conge_StructureSection.Direction].ToString().Trim(); //方向
objge_StructureSectionEN.IsExpanded = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureSection.IsExpanded].ToString().Trim()); //是否扩展
objge_StructureSectionEN.IsRoot = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureSection.IsRoot].ToString().Trim()); //IsRoot
objge_StructureSectionEN.ParentId = objRow[conge_StructureSection.ParentId] == DBNull.Value ? null : objRow[conge_StructureSection.ParentId].ToString().Trim(); //父节点Id
objge_StructureSectionEN.OrderNum = objRow[conge_StructureSection.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StructureSection.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StructureSectionEN.StructureSectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StructureSectionEN);
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
public static List<clsge_StructureSectionEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsge_StructureSectionEN> arrObjLst = new List<clsge_StructureSectionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StructureSectionEN objge_StructureSectionEN = new clsge_StructureSectionEN();
try
{
objge_StructureSectionEN.StructureSectionId = objRow[conge_StructureSection.StructureSectionId].ToString().Trim(); //结构章节Id
objge_StructureSectionEN.StructureSectionName = objRow[conge_StructureSection.StructureSectionName].ToString().Trim(); //结构章节名称
objge_StructureSectionEN.StructureSectionContent = objRow[conge_StructureSection.StructureSectionContent] == DBNull.Value ? null : objRow[conge_StructureSection.StructureSectionContent].ToString().Trim(); //结构章节内容
objge_StructureSectionEN.CourseId = objRow[conge_StructureSection.CourseId].ToString().Trim(); //课程Id
objge_StructureSectionEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureSection.IsShow].ToString().Trim()); //是否启用
objge_StructureSectionEN.UpdDate = objRow[conge_StructureSection.UpdDate] == DBNull.Value ? null : objRow[conge_StructureSection.UpdDate].ToString().Trim(); //修改日期
objge_StructureSectionEN.UpdUser = objRow[conge_StructureSection.UpdUser] == DBNull.Value ? null : objRow[conge_StructureSection.UpdUser].ToString().Trim(); //修改人
objge_StructureSectionEN.Memo = objRow[conge_StructureSection.Memo] == DBNull.Value ? null : objRow[conge_StructureSection.Memo].ToString().Trim(); //备注
objge_StructureSectionEN.SectionTypeId = objRow[conge_StructureSection.SectionTypeId].ToString().Trim(); //节点类型Id
objge_StructureSectionEN.Direction = objRow[conge_StructureSection.Direction] == DBNull.Value ? null : objRow[conge_StructureSection.Direction].ToString().Trim(); //方向
objge_StructureSectionEN.IsExpanded = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureSection.IsExpanded].ToString().Trim()); //是否扩展
objge_StructureSectionEN.IsRoot = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureSection.IsRoot].ToString().Trim()); //IsRoot
objge_StructureSectionEN.ParentId = objRow[conge_StructureSection.ParentId] == DBNull.Value ? null : objRow[conge_StructureSection.ParentId].ToString().Trim(); //父节点Id
objge_StructureSectionEN.OrderNum = objRow[conge_StructureSection.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StructureSection.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StructureSectionEN.StructureSectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StructureSectionEN);
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
List<clsge_StructureSectionEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsge_StructureSectionEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_StructureSectionEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsge_StructureSectionEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsge_StructureSectionEN> arrObjLst = new List<clsge_StructureSectionEN>(); 
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
	clsge_StructureSectionEN objge_StructureSectionEN = new clsge_StructureSectionEN();
try
{
objge_StructureSectionEN.StructureSectionId = objRow[conge_StructureSection.StructureSectionId].ToString().Trim(); //结构章节Id
objge_StructureSectionEN.StructureSectionName = objRow[conge_StructureSection.StructureSectionName].ToString().Trim(); //结构章节名称
objge_StructureSectionEN.StructureSectionContent = objRow[conge_StructureSection.StructureSectionContent] == DBNull.Value ? null : objRow[conge_StructureSection.StructureSectionContent].ToString().Trim(); //结构章节内容
objge_StructureSectionEN.CourseId = objRow[conge_StructureSection.CourseId].ToString().Trim(); //课程Id
objge_StructureSectionEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureSection.IsShow].ToString().Trim()); //是否启用
objge_StructureSectionEN.UpdDate = objRow[conge_StructureSection.UpdDate] == DBNull.Value ? null : objRow[conge_StructureSection.UpdDate].ToString().Trim(); //修改日期
objge_StructureSectionEN.UpdUser = objRow[conge_StructureSection.UpdUser] == DBNull.Value ? null : objRow[conge_StructureSection.UpdUser].ToString().Trim(); //修改人
objge_StructureSectionEN.Memo = objRow[conge_StructureSection.Memo] == DBNull.Value ? null : objRow[conge_StructureSection.Memo].ToString().Trim(); //备注
objge_StructureSectionEN.SectionTypeId = objRow[conge_StructureSection.SectionTypeId].ToString().Trim(); //节点类型Id
objge_StructureSectionEN.Direction = objRow[conge_StructureSection.Direction] == DBNull.Value ? null : objRow[conge_StructureSection.Direction].ToString().Trim(); //方向
objge_StructureSectionEN.IsExpanded = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureSection.IsExpanded].ToString().Trim()); //是否扩展
objge_StructureSectionEN.IsRoot = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureSection.IsRoot].ToString().Trim()); //IsRoot
objge_StructureSectionEN.ParentId = objRow[conge_StructureSection.ParentId] == DBNull.Value ? null : objRow[conge_StructureSection.ParentId].ToString().Trim(); //父节点Id
objge_StructureSectionEN.OrderNum = objRow[conge_StructureSection.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StructureSection.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StructureSectionEN.StructureSectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StructureSectionEN);
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
public static List<clsge_StructureSectionEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsge_StructureSectionEN> arrObjLst = new List<clsge_StructureSectionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StructureSectionEN objge_StructureSectionEN = new clsge_StructureSectionEN();
try
{
objge_StructureSectionEN.StructureSectionId = objRow[conge_StructureSection.StructureSectionId].ToString().Trim(); //结构章节Id
objge_StructureSectionEN.StructureSectionName = objRow[conge_StructureSection.StructureSectionName].ToString().Trim(); //结构章节名称
objge_StructureSectionEN.StructureSectionContent = objRow[conge_StructureSection.StructureSectionContent] == DBNull.Value ? null : objRow[conge_StructureSection.StructureSectionContent].ToString().Trim(); //结构章节内容
objge_StructureSectionEN.CourseId = objRow[conge_StructureSection.CourseId].ToString().Trim(); //课程Id
objge_StructureSectionEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureSection.IsShow].ToString().Trim()); //是否启用
objge_StructureSectionEN.UpdDate = objRow[conge_StructureSection.UpdDate] == DBNull.Value ? null : objRow[conge_StructureSection.UpdDate].ToString().Trim(); //修改日期
objge_StructureSectionEN.UpdUser = objRow[conge_StructureSection.UpdUser] == DBNull.Value ? null : objRow[conge_StructureSection.UpdUser].ToString().Trim(); //修改人
objge_StructureSectionEN.Memo = objRow[conge_StructureSection.Memo] == DBNull.Value ? null : objRow[conge_StructureSection.Memo].ToString().Trim(); //备注
objge_StructureSectionEN.SectionTypeId = objRow[conge_StructureSection.SectionTypeId].ToString().Trim(); //节点类型Id
objge_StructureSectionEN.Direction = objRow[conge_StructureSection.Direction] == DBNull.Value ? null : objRow[conge_StructureSection.Direction].ToString().Trim(); //方向
objge_StructureSectionEN.IsExpanded = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureSection.IsExpanded].ToString().Trim()); //是否扩展
objge_StructureSectionEN.IsRoot = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureSection.IsRoot].ToString().Trim()); //IsRoot
objge_StructureSectionEN.ParentId = objRow[conge_StructureSection.ParentId] == DBNull.Value ? null : objRow[conge_StructureSection.ParentId].ToString().Trim(); //父节点Id
objge_StructureSectionEN.OrderNum = objRow[conge_StructureSection.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StructureSection.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StructureSectionEN.StructureSectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StructureSectionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsge_StructureSectionEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsge_StructureSectionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsge_StructureSectionEN> arrObjLst = new List<clsge_StructureSectionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StructureSectionEN objge_StructureSectionEN = new clsge_StructureSectionEN();
try
{
objge_StructureSectionEN.StructureSectionId = objRow[conge_StructureSection.StructureSectionId].ToString().Trim(); //结构章节Id
objge_StructureSectionEN.StructureSectionName = objRow[conge_StructureSection.StructureSectionName].ToString().Trim(); //结构章节名称
objge_StructureSectionEN.StructureSectionContent = objRow[conge_StructureSection.StructureSectionContent] == DBNull.Value ? null : objRow[conge_StructureSection.StructureSectionContent].ToString().Trim(); //结构章节内容
objge_StructureSectionEN.CourseId = objRow[conge_StructureSection.CourseId].ToString().Trim(); //课程Id
objge_StructureSectionEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureSection.IsShow].ToString().Trim()); //是否启用
objge_StructureSectionEN.UpdDate = objRow[conge_StructureSection.UpdDate] == DBNull.Value ? null : objRow[conge_StructureSection.UpdDate].ToString().Trim(); //修改日期
objge_StructureSectionEN.UpdUser = objRow[conge_StructureSection.UpdUser] == DBNull.Value ? null : objRow[conge_StructureSection.UpdUser].ToString().Trim(); //修改人
objge_StructureSectionEN.Memo = objRow[conge_StructureSection.Memo] == DBNull.Value ? null : objRow[conge_StructureSection.Memo].ToString().Trim(); //备注
objge_StructureSectionEN.SectionTypeId = objRow[conge_StructureSection.SectionTypeId].ToString().Trim(); //节点类型Id
objge_StructureSectionEN.Direction = objRow[conge_StructureSection.Direction] == DBNull.Value ? null : objRow[conge_StructureSection.Direction].ToString().Trim(); //方向
objge_StructureSectionEN.IsExpanded = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureSection.IsExpanded].ToString().Trim()); //是否扩展
objge_StructureSectionEN.IsRoot = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureSection.IsRoot].ToString().Trim()); //IsRoot
objge_StructureSectionEN.ParentId = objRow[conge_StructureSection.ParentId] == DBNull.Value ? null : objRow[conge_StructureSection.ParentId].ToString().Trim(); //父节点Id
objge_StructureSectionEN.OrderNum = objRow[conge_StructureSection.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StructureSection.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StructureSectionEN.StructureSectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StructureSectionEN);
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
public static List<clsge_StructureSectionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsge_StructureSectionEN> arrObjLst = new List<clsge_StructureSectionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StructureSectionEN objge_StructureSectionEN = new clsge_StructureSectionEN();
try
{
objge_StructureSectionEN.StructureSectionId = objRow[conge_StructureSection.StructureSectionId].ToString().Trim(); //结构章节Id
objge_StructureSectionEN.StructureSectionName = objRow[conge_StructureSection.StructureSectionName].ToString().Trim(); //结构章节名称
objge_StructureSectionEN.StructureSectionContent = objRow[conge_StructureSection.StructureSectionContent] == DBNull.Value ? null : objRow[conge_StructureSection.StructureSectionContent].ToString().Trim(); //结构章节内容
objge_StructureSectionEN.CourseId = objRow[conge_StructureSection.CourseId].ToString().Trim(); //课程Id
objge_StructureSectionEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureSection.IsShow].ToString().Trim()); //是否启用
objge_StructureSectionEN.UpdDate = objRow[conge_StructureSection.UpdDate] == DBNull.Value ? null : objRow[conge_StructureSection.UpdDate].ToString().Trim(); //修改日期
objge_StructureSectionEN.UpdUser = objRow[conge_StructureSection.UpdUser] == DBNull.Value ? null : objRow[conge_StructureSection.UpdUser].ToString().Trim(); //修改人
objge_StructureSectionEN.Memo = objRow[conge_StructureSection.Memo] == DBNull.Value ? null : objRow[conge_StructureSection.Memo].ToString().Trim(); //备注
objge_StructureSectionEN.SectionTypeId = objRow[conge_StructureSection.SectionTypeId].ToString().Trim(); //节点类型Id
objge_StructureSectionEN.Direction = objRow[conge_StructureSection.Direction] == DBNull.Value ? null : objRow[conge_StructureSection.Direction].ToString().Trim(); //方向
objge_StructureSectionEN.IsExpanded = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureSection.IsExpanded].ToString().Trim()); //是否扩展
objge_StructureSectionEN.IsRoot = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureSection.IsRoot].ToString().Trim()); //IsRoot
objge_StructureSectionEN.ParentId = objRow[conge_StructureSection.ParentId] == DBNull.Value ? null : objRow[conge_StructureSection.ParentId].ToString().Trim(); //父节点Id
objge_StructureSectionEN.OrderNum = objRow[conge_StructureSection.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StructureSection.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StructureSectionEN.StructureSectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StructureSectionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_StructureSectionEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsge_StructureSectionEN> arrObjLst = new List<clsge_StructureSectionEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StructureSectionEN objge_StructureSectionEN = new clsge_StructureSectionEN();
try
{
objge_StructureSectionEN.StructureSectionId = objRow[conge_StructureSection.StructureSectionId].ToString().Trim(); //结构章节Id
objge_StructureSectionEN.StructureSectionName = objRow[conge_StructureSection.StructureSectionName].ToString().Trim(); //结构章节名称
objge_StructureSectionEN.StructureSectionContent = objRow[conge_StructureSection.StructureSectionContent] == DBNull.Value ? null : objRow[conge_StructureSection.StructureSectionContent].ToString().Trim(); //结构章节内容
objge_StructureSectionEN.CourseId = objRow[conge_StructureSection.CourseId].ToString().Trim(); //课程Id
objge_StructureSectionEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureSection.IsShow].ToString().Trim()); //是否启用
objge_StructureSectionEN.UpdDate = objRow[conge_StructureSection.UpdDate] == DBNull.Value ? null : objRow[conge_StructureSection.UpdDate].ToString().Trim(); //修改日期
objge_StructureSectionEN.UpdUser = objRow[conge_StructureSection.UpdUser] == DBNull.Value ? null : objRow[conge_StructureSection.UpdUser].ToString().Trim(); //修改人
objge_StructureSectionEN.Memo = objRow[conge_StructureSection.Memo] == DBNull.Value ? null : objRow[conge_StructureSection.Memo].ToString().Trim(); //备注
objge_StructureSectionEN.SectionTypeId = objRow[conge_StructureSection.SectionTypeId].ToString().Trim(); //节点类型Id
objge_StructureSectionEN.Direction = objRow[conge_StructureSection.Direction] == DBNull.Value ? null : objRow[conge_StructureSection.Direction].ToString().Trim(); //方向
objge_StructureSectionEN.IsExpanded = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureSection.IsExpanded].ToString().Trim()); //是否扩展
objge_StructureSectionEN.IsRoot = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureSection.IsRoot].ToString().Trim()); //IsRoot
objge_StructureSectionEN.ParentId = objRow[conge_StructureSection.ParentId] == DBNull.Value ? null : objRow[conge_StructureSection.ParentId].ToString().Trim(); //父节点Id
objge_StructureSectionEN.OrderNum = objRow[conge_StructureSection.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StructureSection.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StructureSectionEN.StructureSectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StructureSectionEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objge_StructureSectionEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getge_StructureSection(ref clsge_StructureSectionEN objge_StructureSectionEN)
{
bool bolResult = ge_StructureSectionDA.Getge_StructureSection(ref objge_StructureSectionEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strStructureSectionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsge_StructureSectionEN GetObjByStructureSectionId(string strStructureSectionId)
{
if (strStructureSectionId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strStructureSectionId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strStructureSectionId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strStructureSectionId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsge_StructureSectionEN objge_StructureSectionEN = ge_StructureSectionDA.GetObjByStructureSectionId(strStructureSectionId);
return objge_StructureSectionEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsge_StructureSectionEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsge_StructureSectionEN objge_StructureSectionEN = ge_StructureSectionDA.GetFirstObj(strWhereCond);
 return objge_StructureSectionEN;
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
public static clsge_StructureSectionEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsge_StructureSectionEN objge_StructureSectionEN = ge_StructureSectionDA.GetObjByDataRow(objRow);
 return objge_StructureSectionEN;
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
public static clsge_StructureSectionEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsge_StructureSectionEN objge_StructureSectionEN = ge_StructureSectionDA.GetObjByDataRow(objRow);
 return objge_StructureSectionEN;
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
 /// <param name = "strStructureSectionId">所给的关键字</param>
 /// <param name = "lstge_StructureSectionObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsge_StructureSectionEN GetObjByStructureSectionIdFromList(string strStructureSectionId, List<clsge_StructureSectionEN> lstge_StructureSectionObjLst)
{
foreach (clsge_StructureSectionEN objge_StructureSectionEN in lstge_StructureSectionObjLst)
{
if (objge_StructureSectionEN.StructureSectionId == strStructureSectionId)
{
return objge_StructureSectionEN;
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
 string strMaxStructureSectionId;
 try
 {
 strMaxStructureSectionId = clsge_StructureSectionDA.GetMaxStrId();
 return strMaxStructureSectionId;
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
 string strStructureSectionId;
 try
 {
 strStructureSectionId = new clsge_StructureSectionDA().GetFirstID(strWhereCond);
 return strStructureSectionId;
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
 arrList = ge_StructureSectionDA.GetID(strWhereCond);
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
bool bolIsExist = ge_StructureSectionDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strStructureSectionId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strStructureSectionId)
{
if (string.IsNullOrEmpty(strStructureSectionId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strStructureSectionId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = ge_StructureSectionDA.IsExist(strStructureSectionId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strStructureSectionId">结构章节Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strStructureSectionId, string strOpUser)
{
clsge_StructureSectionEN objge_StructureSectionEN = clsge_StructureSectionBL.GetObjByStructureSectionId(strStructureSectionId);
objge_StructureSectionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
return clsge_StructureSectionBL.UpdateBySql2(objge_StructureSectionEN);
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
 bolIsExist = clsge_StructureSectionDA.IsExistTable();
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
 bolIsExist = ge_StructureSectionDA.IsExistTable(strTabName);
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
 /// <param name = "objge_StructureSectionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsge_StructureSectionEN objge_StructureSectionEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objge_StructureSectionEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!结构章节Id = [{0}]的数据已经存在!(in clsge_StructureSectionBL.AddNewRecordBySql2)", objge_StructureSectionEN.StructureSectionId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objge_StructureSectionEN.StructureSectionId) == true || clsge_StructureSectionBL.IsExist(objge_StructureSectionEN.StructureSectionId) == true)
 {
     objge_StructureSectionEN.StructureSectionId = clsge_StructureSectionBL.GetMaxStrId_S();
 }
bool bolResult = ge_StructureSectionDA.AddNewRecordBySQL2(objge_StructureSectionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureSectionBL.ReFreshCache(objge_StructureSectionEN.CourseId);

if (clsge_StructureSectionBL.relatedActions != null)
{
clsge_StructureSectionBL.relatedActions.UpdRelaTabDate(objge_StructureSectionEN.StructureSectionId, "SetUpdDate");
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
 /// <param name = "objge_StructureSectionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsge_StructureSectionEN objge_StructureSectionEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objge_StructureSectionEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!结构章节Id = [{0}]的数据已经存在!(in clsge_StructureSectionBL.AddNewRecordBySql2WithReturnKey)", objge_StructureSectionEN.StructureSectionId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objge_StructureSectionEN.StructureSectionId) == true || clsge_StructureSectionBL.IsExist(objge_StructureSectionEN.StructureSectionId) == true)
 {
     objge_StructureSectionEN.StructureSectionId = clsge_StructureSectionBL.GetMaxStrId_S();
 }
string strKey = ge_StructureSectionDA.AddNewRecordBySQL2WithReturnKey(objge_StructureSectionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureSectionBL.ReFreshCache(objge_StructureSectionEN.CourseId);

if (clsge_StructureSectionBL.relatedActions != null)
{
clsge_StructureSectionBL.relatedActions.UpdRelaTabDate(objge_StructureSectionEN.StructureSectionId, "SetUpdDate");
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
 /// <param name = "objge_StructureSectionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsge_StructureSectionEN objge_StructureSectionEN)
{
try
{
bool bolResult = ge_StructureSectionDA.Update(objge_StructureSectionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureSectionBL.ReFreshCache(objge_StructureSectionEN.CourseId);

if (clsge_StructureSectionBL.relatedActions != null)
{
clsge_StructureSectionBL.relatedActions.UpdRelaTabDate(objge_StructureSectionEN.StructureSectionId, "SetUpdDate");
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
 /// <param name = "objge_StructureSectionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsge_StructureSectionEN objge_StructureSectionEN)
{
 if (string.IsNullOrEmpty(objge_StructureSectionEN.StructureSectionId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ge_StructureSectionDA.UpdateBySql2(objge_StructureSectionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureSectionBL.ReFreshCache(objge_StructureSectionEN.CourseId);

if (clsge_StructureSectionBL.relatedActions != null)
{
clsge_StructureSectionBL.relatedActions.UpdRelaTabDate(objge_StructureSectionEN.StructureSectionId, "SetUpdDate");
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
 /// <param name = "strStructureSectionId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strStructureSectionId)
{
try
{
 clsge_StructureSectionEN objge_StructureSectionEN = clsge_StructureSectionBL.GetObjByStructureSectionId(strStructureSectionId);

if (clsge_StructureSectionBL.relatedActions != null)
{
clsge_StructureSectionBL.relatedActions.UpdRelaTabDate(objge_StructureSectionEN.StructureSectionId, "SetUpdDate");
}
if (objge_StructureSectionEN != null)
{
int intRecNum = ge_StructureSectionDA.DelRecord(strStructureSectionId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objge_StructureSectionEN.CourseId);
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
/// <param name="strStructureSectionId">表关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strStructureSectionId , string strCourseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsge_StructureSectionDA.GetSpecSQLObj();
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
//删除与表:[ge_StructureSection]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conge_StructureSection.StructureSectionId,
//strStructureSectionId);
//        clsge_StructureSectionBL.Delge_StructureSectionsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsge_StructureSectionBL.DelRecord(strStructureSectionId, strCourseId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsge_StructureSectionBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strStructureSectionId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strStructureSectionId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strStructureSectionId, string strCourseId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsge_StructureSectionBL.relatedActions != null)
{
clsge_StructureSectionBL.relatedActions.UpdRelaTabDate(strStructureSectionId, "UpdRelaTabDate");
}
bool bolResult = ge_StructureSectionDA.DelRecord(strStructureSectionId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrStructureSectionIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delge_StructureSections(List<string> arrStructureSectionIdLst)
{
if (arrStructureSectionIdLst.Count == 0) return 0;
try
{
if (clsge_StructureSectionBL.relatedActions != null)
{
foreach (var strStructureSectionId in arrStructureSectionIdLst)
{
clsge_StructureSectionBL.relatedActions.UpdRelaTabDate(strStructureSectionId, "UpdRelaTabDate");
}
}
 clsge_StructureSectionEN objge_StructureSectionEN = clsge_StructureSectionBL.GetObjByStructureSectionId(arrStructureSectionIdLst[0]);
int intDelRecNum = ge_StructureSectionDA.Delge_StructureSection(arrStructureSectionIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objge_StructureSectionEN.CourseId);
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
public static int Delge_StructureSectionsByCond(string strWhereCond)
{
try
{
if (clsge_StructureSectionBL.relatedActions != null)
{
List<string> arrStructureSectionId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strStructureSectionId in arrStructureSectionId)
{
clsge_StructureSectionBL.relatedActions.UpdRelaTabDate(strStructureSectionId, "UpdRelaTabDate");
}
}
List<string> arrCourseId = GetFldValue(conge_StructureSection.CourseId, strWhereCond);
int intRecNum = ge_StructureSectionDA.Delge_StructureSection(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[ge_StructureSection]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strStructureSectionId">表关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strStructureSectionId, string strCourseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsge_StructureSectionDA.GetSpecSQLObj();
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
//删除与表:[ge_StructureSection]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsge_StructureSectionBL.DelRecord(strStructureSectionId, strCourseId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsge_StructureSectionBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strStructureSectionId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objge_StructureSectionENS">源对象</param>
 /// <param name = "objge_StructureSectionENT">目标对象</param>
 public static void CopyTo(clsge_StructureSectionEN objge_StructureSectionENS, clsge_StructureSectionEN objge_StructureSectionENT)
{
try
{
objge_StructureSectionENT.StructureSectionId = objge_StructureSectionENS.StructureSectionId; //结构章节Id
objge_StructureSectionENT.StructureSectionName = objge_StructureSectionENS.StructureSectionName; //结构章节名称
objge_StructureSectionENT.StructureSectionContent = objge_StructureSectionENS.StructureSectionContent; //结构章节内容
objge_StructureSectionENT.CourseId = objge_StructureSectionENS.CourseId; //课程Id
objge_StructureSectionENT.IsShow = objge_StructureSectionENS.IsShow; //是否启用
objge_StructureSectionENT.UpdDate = objge_StructureSectionENS.UpdDate; //修改日期
objge_StructureSectionENT.UpdUser = objge_StructureSectionENS.UpdUser; //修改人
objge_StructureSectionENT.Memo = objge_StructureSectionENS.Memo; //备注
objge_StructureSectionENT.SectionTypeId = objge_StructureSectionENS.SectionTypeId; //节点类型Id
objge_StructureSectionENT.Direction = objge_StructureSectionENS.Direction; //方向
objge_StructureSectionENT.IsExpanded = objge_StructureSectionENS.IsExpanded; //是否扩展
objge_StructureSectionENT.IsRoot = objge_StructureSectionENS.IsRoot; //IsRoot
objge_StructureSectionENT.ParentId = objge_StructureSectionENS.ParentId; //父节点Id
objge_StructureSectionENT.OrderNum = objge_StructureSectionENS.OrderNum; //序号
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
 /// <param name = "objge_StructureSectionEN">源简化对象</param>
 public static void SetUpdFlag(clsge_StructureSectionEN objge_StructureSectionEN)
{
try
{
objge_StructureSectionEN.ClearUpdateState();
   string strsfUpdFldSetStr = objge_StructureSectionEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conge_StructureSection.StructureSectionId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureSectionEN.StructureSectionId = objge_StructureSectionEN.StructureSectionId; //结构章节Id
}
if (arrFldSet.Contains(conge_StructureSection.StructureSectionName, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureSectionEN.StructureSectionName = objge_StructureSectionEN.StructureSectionName; //结构章节名称
}
if (arrFldSet.Contains(conge_StructureSection.StructureSectionContent, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureSectionEN.StructureSectionContent = objge_StructureSectionEN.StructureSectionContent == "[null]" ? null :  objge_StructureSectionEN.StructureSectionContent; //结构章节内容
}
if (arrFldSet.Contains(conge_StructureSection.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureSectionEN.CourseId = objge_StructureSectionEN.CourseId; //课程Id
}
if (arrFldSet.Contains(conge_StructureSection.IsShow, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureSectionEN.IsShow = objge_StructureSectionEN.IsShow; //是否启用
}
if (arrFldSet.Contains(conge_StructureSection.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureSectionEN.UpdDate = objge_StructureSectionEN.UpdDate == "[null]" ? null :  objge_StructureSectionEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conge_StructureSection.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureSectionEN.UpdUser = objge_StructureSectionEN.UpdUser == "[null]" ? null :  objge_StructureSectionEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conge_StructureSection.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureSectionEN.Memo = objge_StructureSectionEN.Memo == "[null]" ? null :  objge_StructureSectionEN.Memo; //备注
}
if (arrFldSet.Contains(conge_StructureSection.SectionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureSectionEN.SectionTypeId = objge_StructureSectionEN.SectionTypeId; //节点类型Id
}
if (arrFldSet.Contains(conge_StructureSection.Direction, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureSectionEN.Direction = objge_StructureSectionEN.Direction == "[null]" ? null :  objge_StructureSectionEN.Direction; //方向
}
if (arrFldSet.Contains(conge_StructureSection.IsExpanded, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureSectionEN.IsExpanded = objge_StructureSectionEN.IsExpanded; //是否扩展
}
if (arrFldSet.Contains(conge_StructureSection.IsRoot, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureSectionEN.IsRoot = objge_StructureSectionEN.IsRoot; //IsRoot
}
if (arrFldSet.Contains(conge_StructureSection.ParentId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureSectionEN.ParentId = objge_StructureSectionEN.ParentId == "[null]" ? null :  objge_StructureSectionEN.ParentId; //父节点Id
}
if (arrFldSet.Contains(conge_StructureSection.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureSectionEN.OrderNum = objge_StructureSectionEN.OrderNum; //序号
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
 /// <param name = "objge_StructureSectionEN">源简化对象</param>
 public static void AccessFldValueNull(clsge_StructureSectionEN objge_StructureSectionEN)
{
try
{
if (objge_StructureSectionEN.StructureSectionContent == "[null]") objge_StructureSectionEN.StructureSectionContent = null; //结构章节内容
if (objge_StructureSectionEN.UpdDate == "[null]") objge_StructureSectionEN.UpdDate = null; //修改日期
if (objge_StructureSectionEN.UpdUser == "[null]") objge_StructureSectionEN.UpdUser = null; //修改人
if (objge_StructureSectionEN.Memo == "[null]") objge_StructureSectionEN.Memo = null; //备注
if (objge_StructureSectionEN.Direction == "[null]") objge_StructureSectionEN.Direction = null; //方向
if (objge_StructureSectionEN.ParentId == "[null]") objge_StructureSectionEN.ParentId = null; //父节点Id
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
public static void CheckPropertyNew(clsge_StructureSectionEN objge_StructureSectionEN)
{
 ge_StructureSectionDA.CheckPropertyNew(objge_StructureSectionEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsge_StructureSectionEN objge_StructureSectionEN)
{
 ge_StructureSectionDA.CheckProperty4Condition(objge_StructureSectionEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strCourseId"></param>
public static void BindCbo_StructureSectionId(System.Windows.Forms.ComboBox objComboBox , string strCourseId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conge_StructureSection.StructureSectionId); 
List<clsge_StructureSectionEN> arrObjLst = clsge_StructureSectionBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.CourseId == strCourseId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsge_StructureSectionEN objge_StructureSectionEN = new clsge_StructureSectionEN()
{
StructureSectionId = "0",
StructureSectionName = "选[结构章节]..."
};
arrObjLstSel.Insert(0, objge_StructureSectionEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conge_StructureSection.StructureSectionId;
objComboBox.DisplayMember = conge_StructureSection.StructureSectionName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strCourseId"></param>
public static void BindDdl_StructureSectionId(System.Web.UI.WebControls.DropDownList objDDL , string strCourseId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[结构章节]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conge_StructureSection.StructureSectionId); 
IEnumerable<clsge_StructureSectionEN> arrObjLst = clsge_StructureSectionBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.CourseId == strCourseId).ToList();
objDDL.DataValueField = conge_StructureSection.StructureSectionId;
objDDL.DataTextField = conge_StructureSection.StructureSectionName;
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
public static void BindDdl_StructureSectionIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strCourseId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[结构章节]...","0");
List<clsge_StructureSectionEN> arrge_StructureSectionObjLst = GetAllge_StructureSectionObjLstCache(strCourseId); 
arrge_StructureSectionObjLst = arrge_StructureSectionObjLst.OrderBy(x=>x.OrderNum).ToList(); 
objDDL.DataValueField = conge_StructureSection.StructureSectionId;
objDDL.DataTextField = conge_StructureSection.StructureSectionName;
objDDL.DataSource = arrge_StructureSectionObjLst;
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
if (clsge_StructureSectionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsge_StructureSectionBL没有刷新缓存机制(clsge_StructureSectionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by StructureSectionId");
//if (arrge_StructureSectionObjLstCache == null)
//{
//arrge_StructureSectionObjLstCache = ge_StructureSectionDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strStructureSectionId">所给的关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsge_StructureSectionEN GetObjByStructureSectionIdCache(string strStructureSectionId, string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsge_StructureSectionEN._CurrTabName, strCourseId);
List<clsge_StructureSectionEN> arrge_StructureSectionObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsge_StructureSectionEN> arrge_StructureSectionObjLst_Sel =
arrge_StructureSectionObjLstCache
.Where(x=> x.StructureSectionId == strStructureSectionId 
);
if (arrge_StructureSectionObjLst_Sel.Count() == 0)
{
   clsge_StructureSectionEN obj = clsge_StructureSectionBL.GetObjByStructureSectionId(strStructureSectionId);
   if (obj != null)
 {
if (obj.CourseId == strCourseId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strStructureSectionId, strCourseId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrge_StructureSectionObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strStructureSectionId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetStructureSectionNameByStructureSectionIdCache(string strStructureSectionId, string strCourseId)
{
if (string.IsNullOrEmpty(strStructureSectionId) == true) return "";
//获取缓存中的对象列表
clsge_StructureSectionEN objge_StructureSection = GetObjByStructureSectionIdCache(strStructureSectionId, strCourseId);
if (objge_StructureSection == null) return "";
return objge_StructureSection.StructureSectionName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strStructureSectionId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByStructureSectionIdCache(string strStructureSectionId, string strCourseId)
{
if (string.IsNullOrEmpty(strStructureSectionId) == true) return "";
//获取缓存中的对象列表
clsge_StructureSectionEN objge_StructureSection = GetObjByStructureSectionIdCache(strStructureSectionId, strCourseId);
if (objge_StructureSection == null) return "";
return objge_StructureSection.StructureSectionName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsge_StructureSectionEN> GetAllge_StructureSectionObjLstCache(string strCourseId)
{
//获取缓存中的对象列表
List<clsge_StructureSectionEN> arrge_StructureSectionObjLstCache = GetObjLstCache(strCourseId); 
return arrge_StructureSectionObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsge_StructureSectionEN> GetObjLstCache(string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsge_StructureSectionEN._CurrTabName, strCourseId);
string strCondition = string.Format("CourseId='{0}'", strCourseId);
List<clsge_StructureSectionEN> arrge_StructureSectionObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrge_StructureSectionObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsge_StructureSectionEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clsge_StructureSectionEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsge_StructureSectionEN._RefreshTimeLst.Count == 0) return "";
return clsge_StructureSectionEN._RefreshTimeLst[clsge_StructureSectionEN._RefreshTimeLst.Count - 1];
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
if (clsge_StructureSectionBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsge_StructureSectionEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clsge_StructureSectionEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsge_StructureSectionBL.objCommFun4BL.ReFreshCache(strCourseId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--ge_StructureSection(结构章节)
 /// 唯一性条件:StructureSectionId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objge_StructureSectionEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsge_StructureSectionEN objge_StructureSectionEN)
{
//检测记录是否存在
string strResult = ge_StructureSectionDA.GetUniCondStr(objge_StructureSectionEN);
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
public static string Func(string strInFldName, string strOutFldName, string strStructureSectionId, string strCourseId)
{
if (strInFldName != conge_StructureSection.StructureSectionId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conge_StructureSection.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conge_StructureSection.AttributeName));
throw new Exception(strMsg);
}
var objge_StructureSection = clsge_StructureSectionBL.GetObjByStructureSectionIdCache(strStructureSectionId, strCourseId);
if (objge_StructureSection == null) return "";
return objge_StructureSection[strOutFldName].ToString();
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
int intRecCount = clsge_StructureSectionDA.GetRecCount(strTabName);
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
int intRecCount = clsge_StructureSectionDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsge_StructureSectionDA.GetRecCount();
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
int intRecCount = clsge_StructureSectionDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objge_StructureSectionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsge_StructureSectionEN objge_StructureSectionCond)
{
 string strCourseId = objge_StructureSectionCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsge_StructureSectionBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsge_StructureSectionEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsge_StructureSectionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conge_StructureSection.AttributeName)
{
if (objge_StructureSectionCond.IsUpdated(strFldName) == false) continue;
if (objge_StructureSectionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_StructureSectionCond[strFldName].ToString());
}
else
{
if (objge_StructureSectionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objge_StructureSectionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_StructureSectionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objge_StructureSectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objge_StructureSectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objge_StructureSectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objge_StructureSectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objge_StructureSectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objge_StructureSectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objge_StructureSectionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objge_StructureSectionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objge_StructureSectionCond[strFldName]));
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
 List<string> arrList = clsge_StructureSectionDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ge_StructureSectionDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ge_StructureSectionDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ge_StructureSectionDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsge_StructureSectionDA.SetFldValue(clsge_StructureSectionEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ge_StructureSectionDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsge_StructureSectionDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsge_StructureSectionDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsge_StructureSectionDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ge_StructureSection] "); 
 strCreateTabCode.Append(" ( "); 
 // /**结构章节Id*/ 
 strCreateTabCode.Append(" StructureSectionId char(10) primary key, "); 
 // /**结构章节名称*/ 
 strCreateTabCode.Append(" StructureSectionName varchar(50) not Null, "); 
 // /**结构章节内容*/ 
 strCreateTabCode.Append(" StructureSectionContent varchar(3000) Null, "); 
 // /**课程Id*/ 
 strCreateTabCode.Append(" CourseId char(8) not Null, "); 
 // /**是否启用*/ 
 strCreateTabCode.Append(" IsShow bit Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**节点类型Id*/ 
 strCreateTabCode.Append(" SectionTypeId char(8) not Null, "); 
 // /**方向*/ 
 strCreateTabCode.Append(" Direction varchar(50) Null, "); 
 // /**是否扩展*/ 
 strCreateTabCode.Append(" IsExpanded bit Null, "); 
 // /**IsRoot*/ 
 strCreateTabCode.Append(" IsRoot bit Null, "); 
 // /**父节点Id*/ 
 strCreateTabCode.Append(" ParentId char(10) Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**课程名称*/ 
 strCreateTabCode.Append(" CourseName varchar(100) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 排序相关函数

/// <summary>
/// 重新排序。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ReOrder)
/// </summary>
/// <returns></returns>
public static bool ReOrder()
{
try
{
string strCondition = string.Format("1 = 1 order by {0} ", conge_StructureSection.OrderNum); 
List<clsge_StructureSectionEN> arrge_StructureSectionObjList = new clsge_StructureSectionDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsge_StructureSectionEN objge_StructureSection in arrge_StructureSectionObjList)
{
objge_StructureSection.OrderNum = intIndex;
UpdateBySql2(objge_StructureSection);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("重序出错, {0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 调整所给关键字记录的序号。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_AdjustOrderNum)
/// </summary>
/// <param name="strDirect">方向：用"Up","Down"表示</param>
/// <param name="strStructureSectionId">所给的关键字</param>
/// <returns>是否成绩</returns>
public static bool AdjustOrderNum(string strDirect, string strStructureSectionId)
{
try
{
//操作步骤：
//1、根据所给定的关键字[StructureSectionId],获取相应的序号[OrderNum]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//   3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字StructureSectionId
//5、把当前关键字StructureSectionId所对应记录的序号加(减)1
//6、把下(上)一个序号关键字StructureSectionId所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
string strPrevStructureSectionId = "";    //上一条序号的关键字StructureSectionId
string strNextStructureSectionId = "";    //下一条序号的关键字StructureSectionId
int intTabRecNum;       //当前表中字段的记录数
StringBuilder strCondition = new StringBuilder();
//1、根据所给定的关键字[StructureSectionId],获取相应的序号[OrderNum]。

clsge_StructureSectionEN objge_StructureSection = clsge_StructureSectionBL.GetObjByStructureSectionId(strStructureSectionId);

intOrderNum = objge_StructureSection.OrderNum ?? 0;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

intTabRecNum = clsge_StructureSectionBL.GetRecCountByCond(clsge_StructureSectionEN._CurrTabName, "1 = 1");    //获取当前表的记录数
switch (strDirect)
{
case "UP":
case "Up":
case "up":
//3、如果是末端序号,就退出；
//  3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	     即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
if (intOrderNum <= 1)
{
strMsg = string.Format("已经是第一条记录,不能再上移.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//		3.2 如果不是,即如果是向下移动,就判断当前序号是否“小于”当前表中的字段数,
//		    即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//		    如果是向上移动,就判断当前序号是否“大于”1,
//		    即不是最开始一个记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
strCondition.AppendFormat(" {0} = {1}", conge_StructureSection.OrderNum, intOrderNum - 1);
//4、获取上一个序号字段的关键字StructureSectionId
strPrevStructureSectionId = clsge_StructureSectionBL.GetFirstID_S(strCondition.ToString());
if (string.IsNullOrEmpty(strPrevStructureSectionId) == true)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字StructureSectionId所对应记录的序号减1
//6、把下(上)一个序号关键字StructureSectionId所对应的记录序号加1
clsge_StructureSectionBL.SetFldValue(clsge_StructureSectionEN._CurrTabName, conge_StructureSection.OrderNum,
intOrderNum - 1,
string.Format("{0} = '{1}'", conge_StructureSection.StructureSectionId, strStructureSectionId));
clsge_StructureSectionBL.SetFldValue(clsge_StructureSectionEN._CurrTabName, conge_StructureSection.OrderNum,
intPrevOrderNum + 1,
string.Format("{0} = '{1}'", conge_StructureSection.StructureSectionId, strPrevStructureSectionId));
break;
case "DOWN":
case "Down":
case "down":
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
if (intOrderNum >= intTabRecNum)    //如果当前序号大于表记录数
{
strMsg = string.Format("已经是最后一条记录,不能再下移.(from {0})", clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
}

//4、获取下一个序号字段的关键字StructureSectionId
strCondition.AppendFormat(" {0} = {1}", conge_StructureSection.OrderNum, intOrderNum + 1);

strNextStructureSectionId = clsge_StructureSectionBL.GetFirstID_S(strCondition.ToString());
if (string.IsNullOrEmpty(strNextStructureSectionId) == true)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字StructureSectionId所对应记录的序号加1
//6、把下(上)一个序号关键字StructureSectionId所对应的记录序号减1
clsge_StructureSectionBL.SetFldValue(clsge_StructureSectionEN._CurrTabName, conge_StructureSection.OrderNum,
intOrderNum + 1,
string.Format("{0} = '{1}'", conge_StructureSection.StructureSectionId, strStructureSectionId));
clsge_StructureSectionBL.SetFldValue(clsge_StructureSectionEN._CurrTabName, conge_StructureSection.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conge_StructureSection.StructureSectionId, strNextStructureSectionId));
break;
default:
strMsg = string.Format("方向参数出错!strDirect=[{0}]({1})",
strDirect,
clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
clsge_StructureSectionBL.ReFreshCache(objge_StructureSection.CourseId);
if (clsge_StructureSectionBL.relatedActions != null)
{
clsge_StructureSectionBL.relatedActions.UpdRelaTabDate(objge_StructureSection.StructureSectionId, "UpdRelaTabDate");
}
return true;
}
catch (Exception objException)
{
string strMsg = string.Format("调整记录次序出错!错误:[{0}]({1})",
objException.Message,
clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 把所给的关键字列表所对应的对象置底。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoBottom)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoBottom(List<string> arrKeyId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", conge_StructureSection.StructureSectionId, strKeyList);
List<clsge_StructureSectionEN> arrge_StructureSectionLst = GetObjLst(strCondition);
foreach (clsge_StructureSectionEN objge_StructureSection in arrge_StructureSectionLst)
{
objge_StructureSection.OrderNum = objge_StructureSection.OrderNum + 10000;
UpdateBySql2(objge_StructureSection);
}
strCondition = string.Format("1 = 1 order by {0} ", conge_StructureSection.OrderNum); 
List<clsge_StructureSectionEN> arrge_StructureSectionObjList = new clsge_StructureSectionDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsge_StructureSectionEN objge_StructureSection in arrge_StructureSectionObjList)
{
objge_StructureSection.OrderNum = intIndex;
UpdateBySql2(objge_StructureSection);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错, {0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 把所给的关键字列表所对应的对象置顶。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoTop)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoTop(List<string> arrKeyId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", conge_StructureSection.StructureSectionId, strKeyList);
List<clsge_StructureSectionEN> arrge_StructureSectionLst = GetObjLst(strCondition);
foreach (clsge_StructureSectionEN objge_StructureSection in arrge_StructureSectionLst)
{
objge_StructureSection.OrderNum = objge_StructureSection.OrderNum - 10000;
UpdateBySql2(objge_StructureSection);
}
strCondition = string.Format("1 = 1 order by {0} ", conge_StructureSection.OrderNum); 
List<clsge_StructureSectionEN> arrge_StructureSectionObjList = new clsge_StructureSectionDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsge_StructureSectionEN objge_StructureSection in arrge_StructureSectionObjList)
{
objge_StructureSection.OrderNum = intIndex;
UpdateBySql2(objge_StructureSection);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错!错误:{0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}


 #endregion 排序相关函数
}
 /// <summary>
 /// 结构章节(ge_StructureSection)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4ge_StructureSection : clsCommFun4BLV2
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
clsge_StructureSectionBL.ReFreshThisCache(strCourseId);
}
}

}