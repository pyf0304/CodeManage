
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_StructureSectionTypeBL
 表名:ge_StructureSectionType(01120901)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:19:16
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
public static class  clsge_StructureSectionTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strSectionTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsge_StructureSectionTypeEN GetObj(this K_SectionTypeId_ge_StructureSectionType myKey)
{
clsge_StructureSectionTypeEN objge_StructureSectionTypeEN = clsge_StructureSectionTypeBL.ge_StructureSectionTypeDA.GetObjBySectionTypeId(myKey.Value);
return objge_StructureSectionTypeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objge_StructureSectionTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsge_StructureSectionTypeEN objge_StructureSectionTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objge_StructureSectionTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!节点类型名称 = [{0}]的数据已经存在!(in clsge_StructureSectionTypeBL.AddNewRecord)", objge_StructureSectionTypeEN.SectionTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objge_StructureSectionTypeEN.SectionTypeId) == true || clsge_StructureSectionTypeBL.IsExist(objge_StructureSectionTypeEN.SectionTypeId) == true)
 {
     objge_StructureSectionTypeEN.SectionTypeId = clsge_StructureSectionTypeBL.GetMaxStrId_S();
 }
bool bolResult = clsge_StructureSectionTypeBL.ge_StructureSectionTypeDA.AddNewRecordBySQL2(objge_StructureSectionTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureSectionTypeBL.ReFreshCache(objge_StructureSectionTypeEN.CourseId);

if (clsge_StructureSectionTypeBL.relatedActions != null)
{
clsge_StructureSectionTypeBL.relatedActions.UpdRelaTabDate(objge_StructureSectionTypeEN.SectionTypeId, "SetUpdDate");
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
public static bool AddRecordEx(this clsge_StructureSectionTypeEN objge_StructureSectionTypeEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsge_StructureSectionTypeBL.IsExist(objge_StructureSectionTypeEN.SectionTypeId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objge_StructureSectionTypeEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objge_StructureSectionTypeEN.CheckUniqueness() == false)
{
strMsg = string.Format("(节点类型名称(SectionTypeName)=[{0}])已经存在,不能重复!", objge_StructureSectionTypeEN.SectionTypeName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objge_StructureSectionTypeEN.SectionTypeId) == true || clsge_StructureSectionTypeBL.IsExist(objge_StructureSectionTypeEN.SectionTypeId) == true)
 {
     objge_StructureSectionTypeEN.SectionTypeId = clsge_StructureSectionTypeBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objge_StructureSectionTypeEN.AddNewRecord();
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
 /// <param name = "objge_StructureSectionTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsge_StructureSectionTypeEN objge_StructureSectionTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objge_StructureSectionTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!节点类型名称 = [{0}]的数据已经存在!(in clsge_StructureSectionTypeBL.AddNewRecordWithMaxId)", objge_StructureSectionTypeEN.SectionTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objge_StructureSectionTypeEN.SectionTypeId) == true || clsge_StructureSectionTypeBL.IsExist(objge_StructureSectionTypeEN.SectionTypeId) == true)
 {
     objge_StructureSectionTypeEN.SectionTypeId = clsge_StructureSectionTypeBL.GetMaxStrId_S();
 }
string strSectionTypeId = clsge_StructureSectionTypeBL.ge_StructureSectionTypeDA.AddNewRecordBySQL2WithReturnKey(objge_StructureSectionTypeEN);
     objge_StructureSectionTypeEN.SectionTypeId = strSectionTypeId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureSectionTypeBL.ReFreshCache(objge_StructureSectionTypeEN.CourseId);

if (clsge_StructureSectionTypeBL.relatedActions != null)
{
clsge_StructureSectionTypeBL.relatedActions.UpdRelaTabDate(objge_StructureSectionTypeEN.SectionTypeId, "SetUpdDate");
}
return strSectionTypeId;
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
 /// <param name = "objge_StructureSectionTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsge_StructureSectionTypeEN objge_StructureSectionTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objge_StructureSectionTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!节点类型名称 = [{0}]的数据已经存在!(in clsge_StructureSectionTypeBL.AddNewRecordWithReturnKey)", objge_StructureSectionTypeEN.SectionTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objge_StructureSectionTypeEN.SectionTypeId) == true || clsge_StructureSectionTypeBL.IsExist(objge_StructureSectionTypeEN.SectionTypeId) == true)
 {
     objge_StructureSectionTypeEN.SectionTypeId = clsge_StructureSectionTypeBL.GetMaxStrId_S();
 }
string strKey = clsge_StructureSectionTypeBL.ge_StructureSectionTypeDA.AddNewRecordBySQL2WithReturnKey(objge_StructureSectionTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureSectionTypeBL.ReFreshCache(objge_StructureSectionTypeEN.CourseId);

if (clsge_StructureSectionTypeBL.relatedActions != null)
{
clsge_StructureSectionTypeBL.relatedActions.UpdRelaTabDate(objge_StructureSectionTypeEN.SectionTypeId, "SetUpdDate");
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
 /// <param name = "objge_StructureSectionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureSectionTypeEN SetSectionTypeId(this clsge_StructureSectionTypeEN objge_StructureSectionTypeEN, string strSectionTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionTypeId, 8, conge_StructureSectionType.SectionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSectionTypeId, 8, conge_StructureSectionType.SectionTypeId);
}
objge_StructureSectionTypeEN.SectionTypeId = strSectionTypeId; //节点类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureSectionTypeEN.dicFldComparisonOp.ContainsKey(conge_StructureSectionType.SectionTypeId) == false)
{
objge_StructureSectionTypeEN.dicFldComparisonOp.Add(conge_StructureSectionType.SectionTypeId, strComparisonOp);
}
else
{
objge_StructureSectionTypeEN.dicFldComparisonOp[conge_StructureSectionType.SectionTypeId] = strComparisonOp;
}
}
return objge_StructureSectionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureSectionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureSectionTypeEN SetSectionTypeName(this clsge_StructureSectionTypeEN objge_StructureSectionTypeEN, string strSectionTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSectionTypeName, conge_StructureSectionType.SectionTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionTypeName, 100, conge_StructureSectionType.SectionTypeName);
}
objge_StructureSectionTypeEN.SectionTypeName = strSectionTypeName; //节点类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureSectionTypeEN.dicFldComparisonOp.ContainsKey(conge_StructureSectionType.SectionTypeName) == false)
{
objge_StructureSectionTypeEN.dicFldComparisonOp.Add(conge_StructureSectionType.SectionTypeName, strComparisonOp);
}
else
{
objge_StructureSectionTypeEN.dicFldComparisonOp[conge_StructureSectionType.SectionTypeName] = strComparisonOp;
}
}
return objge_StructureSectionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureSectionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureSectionTypeEN SetSectionTypeEnName(this clsge_StructureSectionTypeEN objge_StructureSectionTypeEN, string strSectionTypeEnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionTypeEnName, 100, conge_StructureSectionType.SectionTypeEnName);
}
objge_StructureSectionTypeEN.SectionTypeEnName = strSectionTypeEnName; //节点类型英文名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureSectionTypeEN.dicFldComparisonOp.ContainsKey(conge_StructureSectionType.SectionTypeEnName) == false)
{
objge_StructureSectionTypeEN.dicFldComparisonOp.Add(conge_StructureSectionType.SectionTypeEnName, strComparisonOp);
}
else
{
objge_StructureSectionTypeEN.dicFldComparisonOp[conge_StructureSectionType.SectionTypeEnName] = strComparisonOp;
}
}
return objge_StructureSectionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureSectionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureSectionTypeEN SetCourseId(this clsge_StructureSectionTypeEN objge_StructureSectionTypeEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, conge_StructureSectionType.CourseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, conge_StructureSectionType.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, conge_StructureSectionType.CourseId);
}
objge_StructureSectionTypeEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureSectionTypeEN.dicFldComparisonOp.ContainsKey(conge_StructureSectionType.CourseId) == false)
{
objge_StructureSectionTypeEN.dicFldComparisonOp.Add(conge_StructureSectionType.CourseId, strComparisonOp);
}
else
{
objge_StructureSectionTypeEN.dicFldComparisonOp[conge_StructureSectionType.CourseId] = strComparisonOp;
}
}
return objge_StructureSectionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureSectionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureSectionTypeEN SetUpdDate(this clsge_StructureSectionTypeEN objge_StructureSectionTypeEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conge_StructureSectionType.UpdDate);
}
objge_StructureSectionTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureSectionTypeEN.dicFldComparisonOp.ContainsKey(conge_StructureSectionType.UpdDate) == false)
{
objge_StructureSectionTypeEN.dicFldComparisonOp.Add(conge_StructureSectionType.UpdDate, strComparisonOp);
}
else
{
objge_StructureSectionTypeEN.dicFldComparisonOp[conge_StructureSectionType.UpdDate] = strComparisonOp;
}
}
return objge_StructureSectionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureSectionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureSectionTypeEN SetUpdUser(this clsge_StructureSectionTypeEN objge_StructureSectionTypeEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conge_StructureSectionType.UpdUser);
}
objge_StructureSectionTypeEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureSectionTypeEN.dicFldComparisonOp.ContainsKey(conge_StructureSectionType.UpdUser) == false)
{
objge_StructureSectionTypeEN.dicFldComparisonOp.Add(conge_StructureSectionType.UpdUser, strComparisonOp);
}
else
{
objge_StructureSectionTypeEN.dicFldComparisonOp[conge_StructureSectionType.UpdUser] = strComparisonOp;
}
}
return objge_StructureSectionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureSectionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureSectionTypeEN SetMemo(this clsge_StructureSectionTypeEN objge_StructureSectionTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conge_StructureSectionType.Memo);
}
objge_StructureSectionTypeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureSectionTypeEN.dicFldComparisonOp.ContainsKey(conge_StructureSectionType.Memo) == false)
{
objge_StructureSectionTypeEN.dicFldComparisonOp.Add(conge_StructureSectionType.Memo, strComparisonOp);
}
else
{
objge_StructureSectionTypeEN.dicFldComparisonOp[conge_StructureSectionType.Memo] = strComparisonOp;
}
}
return objge_StructureSectionTypeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objge_StructureSectionTypeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsge_StructureSectionTypeEN objge_StructureSectionTypeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objge_StructureSectionTypeEN.CheckPropertyNew();
clsge_StructureSectionTypeEN objge_StructureSectionTypeCond = new clsge_StructureSectionTypeEN();
string strCondition = objge_StructureSectionTypeCond
.SetSectionTypeId(objge_StructureSectionTypeEN.SectionTypeId, "<>")
.SetSectionTypeName(objge_StructureSectionTypeEN.SectionTypeName, "=")
.GetCombineCondition();
objge_StructureSectionTypeEN._IsCheckProperty = true;
bool bolIsExist = clsge_StructureSectionTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(SectionTypeName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objge_StructureSectionTypeEN.Update();
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
 /// <param name = "objge_StructureSectionType">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsge_StructureSectionTypeEN objge_StructureSectionType)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsge_StructureSectionTypeEN objge_StructureSectionTypeCond = new clsge_StructureSectionTypeEN();
string strCondition = objge_StructureSectionTypeCond
.SetSectionTypeName(objge_StructureSectionType.SectionTypeName, "=")
.GetCombineCondition();
objge_StructureSectionType._IsCheckProperty = true;
bool bolIsExist = clsge_StructureSectionTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objge_StructureSectionType.SectionTypeId = clsge_StructureSectionTypeBL.GetFirstID_S(strCondition);
objge_StructureSectionType.UpdateWithCondition(strCondition);
}
else
{
objge_StructureSectionType.SectionTypeId = clsge_StructureSectionTypeBL.GetMaxStrId_S();
objge_StructureSectionType.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objge_StructureSectionTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsge_StructureSectionTypeEN objge_StructureSectionTypeEN)
{
 if (string.IsNullOrEmpty(objge_StructureSectionTypeEN.SectionTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsge_StructureSectionTypeBL.ge_StructureSectionTypeDA.UpdateBySql2(objge_StructureSectionTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureSectionTypeBL.ReFreshCache(objge_StructureSectionTypeEN.CourseId);

if (clsge_StructureSectionTypeBL.relatedActions != null)
{
clsge_StructureSectionTypeBL.relatedActions.UpdRelaTabDate(objge_StructureSectionTypeEN.SectionTypeId, "SetUpdDate");
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
 /// <param name = "objge_StructureSectionTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsge_StructureSectionTypeEN objge_StructureSectionTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objge_StructureSectionTypeEN.SectionTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsge_StructureSectionTypeBL.ge_StructureSectionTypeDA.UpdateBySql2(objge_StructureSectionTypeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureSectionTypeBL.ReFreshCache(objge_StructureSectionTypeEN.CourseId);

if (clsge_StructureSectionTypeBL.relatedActions != null)
{
clsge_StructureSectionTypeBL.relatedActions.UpdRelaTabDate(objge_StructureSectionTypeEN.SectionTypeId, "SetUpdDate");
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
 /// <param name = "objge_StructureSectionTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsge_StructureSectionTypeEN objge_StructureSectionTypeEN, string strWhereCond)
{
try
{
bool bolResult = clsge_StructureSectionTypeBL.ge_StructureSectionTypeDA.UpdateBySqlWithCondition(objge_StructureSectionTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureSectionTypeBL.ReFreshCache(objge_StructureSectionTypeEN.CourseId);

if (clsge_StructureSectionTypeBL.relatedActions != null)
{
clsge_StructureSectionTypeBL.relatedActions.UpdRelaTabDate(objge_StructureSectionTypeEN.SectionTypeId, "SetUpdDate");
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
 /// <param name = "objge_StructureSectionTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsge_StructureSectionTypeEN objge_StructureSectionTypeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsge_StructureSectionTypeBL.ge_StructureSectionTypeDA.UpdateBySqlWithConditionTransaction(objge_StructureSectionTypeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureSectionTypeBL.ReFreshCache(objge_StructureSectionTypeEN.CourseId);

if (clsge_StructureSectionTypeBL.relatedActions != null)
{
clsge_StructureSectionTypeBL.relatedActions.UpdRelaTabDate(objge_StructureSectionTypeEN.SectionTypeId, "SetUpdDate");
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
 /// <param name = "strSectionTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsge_StructureSectionTypeEN objge_StructureSectionTypeEN)
{
try
{
int intRecNum = clsge_StructureSectionTypeBL.ge_StructureSectionTypeDA.DelRecord(objge_StructureSectionTypeEN.SectionTypeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureSectionTypeBL.ReFreshCache(objge_StructureSectionTypeEN.CourseId);

if (clsge_StructureSectionTypeBL.relatedActions != null)
{
clsge_StructureSectionTypeBL.relatedActions.UpdRelaTabDate(objge_StructureSectionTypeEN.SectionTypeId, "SetUpdDate");
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
 /// <param name = "objge_StructureSectionTypeENS">源对象</param>
 /// <param name = "objge_StructureSectionTypeENT">目标对象</param>
 public static void CopyTo(this clsge_StructureSectionTypeEN objge_StructureSectionTypeENS, clsge_StructureSectionTypeEN objge_StructureSectionTypeENT)
{
try
{
objge_StructureSectionTypeENT.SectionTypeId = objge_StructureSectionTypeENS.SectionTypeId; //节点类型Id
objge_StructureSectionTypeENT.SectionTypeName = objge_StructureSectionTypeENS.SectionTypeName; //节点类型名称
objge_StructureSectionTypeENT.SectionTypeEnName = objge_StructureSectionTypeENS.SectionTypeEnName; //节点类型英文名称
objge_StructureSectionTypeENT.CourseId = objge_StructureSectionTypeENS.CourseId; //课程Id
objge_StructureSectionTypeENT.UpdDate = objge_StructureSectionTypeENS.UpdDate; //修改日期
objge_StructureSectionTypeENT.UpdUser = objge_StructureSectionTypeENS.UpdUser; //修改人
objge_StructureSectionTypeENT.Memo = objge_StructureSectionTypeENS.Memo; //备注
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
 /// <param name = "objge_StructureSectionTypeENS">源对象</param>
 /// <returns>目标对象=>clsge_StructureSectionTypeEN:objge_StructureSectionTypeENT</returns>
 public static clsge_StructureSectionTypeEN CopyTo(this clsge_StructureSectionTypeEN objge_StructureSectionTypeENS)
{
try
{
 clsge_StructureSectionTypeEN objge_StructureSectionTypeENT = new clsge_StructureSectionTypeEN()
{
SectionTypeId = objge_StructureSectionTypeENS.SectionTypeId, //节点类型Id
SectionTypeName = objge_StructureSectionTypeENS.SectionTypeName, //节点类型名称
SectionTypeEnName = objge_StructureSectionTypeENS.SectionTypeEnName, //节点类型英文名称
CourseId = objge_StructureSectionTypeENS.CourseId, //课程Id
UpdDate = objge_StructureSectionTypeENS.UpdDate, //修改日期
UpdUser = objge_StructureSectionTypeENS.UpdUser, //修改人
Memo = objge_StructureSectionTypeENS.Memo, //备注
};
 return objge_StructureSectionTypeENT;
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
public static void CheckPropertyNew(this clsge_StructureSectionTypeEN objge_StructureSectionTypeEN)
{
 clsge_StructureSectionTypeBL.ge_StructureSectionTypeDA.CheckPropertyNew(objge_StructureSectionTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsge_StructureSectionTypeEN objge_StructureSectionTypeEN)
{
 clsge_StructureSectionTypeBL.ge_StructureSectionTypeDA.CheckProperty4Condition(objge_StructureSectionTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsge_StructureSectionTypeEN objge_StructureSectionTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objge_StructureSectionTypeCond.IsUpdated(conge_StructureSectionType.SectionTypeId) == true)
{
string strComparisonOpSectionTypeId = objge_StructureSectionTypeCond.dicFldComparisonOp[conge_StructureSectionType.SectionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StructureSectionType.SectionTypeId, objge_StructureSectionTypeCond.SectionTypeId, strComparisonOpSectionTypeId);
}
if (objge_StructureSectionTypeCond.IsUpdated(conge_StructureSectionType.SectionTypeName) == true)
{
string strComparisonOpSectionTypeName = objge_StructureSectionTypeCond.dicFldComparisonOp[conge_StructureSectionType.SectionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StructureSectionType.SectionTypeName, objge_StructureSectionTypeCond.SectionTypeName, strComparisonOpSectionTypeName);
}
if (objge_StructureSectionTypeCond.IsUpdated(conge_StructureSectionType.SectionTypeEnName) == true)
{
string strComparisonOpSectionTypeEnName = objge_StructureSectionTypeCond.dicFldComparisonOp[conge_StructureSectionType.SectionTypeEnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StructureSectionType.SectionTypeEnName, objge_StructureSectionTypeCond.SectionTypeEnName, strComparisonOpSectionTypeEnName);
}
if (objge_StructureSectionTypeCond.IsUpdated(conge_StructureSectionType.CourseId) == true)
{
string strComparisonOpCourseId = objge_StructureSectionTypeCond.dicFldComparisonOp[conge_StructureSectionType.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StructureSectionType.CourseId, objge_StructureSectionTypeCond.CourseId, strComparisonOpCourseId);
}
if (objge_StructureSectionTypeCond.IsUpdated(conge_StructureSectionType.UpdDate) == true)
{
string strComparisonOpUpdDate = objge_StructureSectionTypeCond.dicFldComparisonOp[conge_StructureSectionType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StructureSectionType.UpdDate, objge_StructureSectionTypeCond.UpdDate, strComparisonOpUpdDate);
}
if (objge_StructureSectionTypeCond.IsUpdated(conge_StructureSectionType.UpdUser) == true)
{
string strComparisonOpUpdUser = objge_StructureSectionTypeCond.dicFldComparisonOp[conge_StructureSectionType.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StructureSectionType.UpdUser, objge_StructureSectionTypeCond.UpdUser, strComparisonOpUpdUser);
}
if (objge_StructureSectionTypeCond.IsUpdated(conge_StructureSectionType.Memo) == true)
{
string strComparisonOpMemo = objge_StructureSectionTypeCond.dicFldComparisonOp[conge_StructureSectionType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StructureSectionType.Memo, objge_StructureSectionTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--ge_StructureSectionType(结构章节类型), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:SectionTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objge_StructureSectionTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsge_StructureSectionTypeEN objge_StructureSectionTypeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objge_StructureSectionTypeEN == null) return true;
if (objge_StructureSectionTypeEN.SectionTypeId == null || objge_StructureSectionTypeEN.SectionTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and SectionTypeName = '{0}'", objge_StructureSectionTypeEN.SectionTypeName);
if (clsge_StructureSectionTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("SectionTypeId !=  '{0}'", objge_StructureSectionTypeEN.SectionTypeId);
 sbCondition.AppendFormat(" and SectionTypeName = '{0}'", objge_StructureSectionTypeEN.SectionTypeName);
if (clsge_StructureSectionTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--ge_StructureSectionType(结构章节类型), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:SectionTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objge_StructureSectionTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsge_StructureSectionTypeEN objge_StructureSectionTypeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objge_StructureSectionTypeEN == null) return "";
if (objge_StructureSectionTypeEN.SectionTypeId == null || objge_StructureSectionTypeEN.SectionTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and SectionTypeName = '{0}'", objge_StructureSectionTypeEN.SectionTypeName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("SectionTypeId !=  '{0}'", objge_StructureSectionTypeEN.SectionTypeId);
 sbCondition.AppendFormat(" and SectionTypeName = '{0}'", objge_StructureSectionTypeEN.SectionTypeName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ge_StructureSectionType
{
public virtual bool UpdRelaTabDate(string strSectionTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 根据表内容设置enum列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GeneEnumConstList)
 /// </summary>
public class enumge_StructureSectionType
{
 /// <summary>
 /// 类型1
 /// </summary>
public const string Type1_00000001 = "00000001";
 /// <summary>
 /// 类型2
 /// </summary>
public const string Type2_00000002 = "00000002";
 /// <summary>
 /// 类型3
 /// </summary>
public const string Type3_00000003 = "00000003";
 /// <summary>
 /// 类型4
 /// </summary>
public const string Type4_00000004 = "00000004";
 /// <summary>
 /// 类型1
 /// </summary>
public const string Type1_00000005 = "00000005";
 /// <summary>
 /// 类型5
 /// </summary>
public const string Type5_00000006 = "00000006";
 /// <summary>
 /// 文档的对象模型
 /// </summary>
public const string FileObjModule_00000007 = "00000007";
 /// <summary>
 /// 事件处理
 /// </summary>
public const string EventAccess_00000008 = "00000008";
 /// <summary>
 /// AAA2
 /// </summary>
public const string BBB_00000010 = "00000010";
 /// <summary>
 /// DDD
 /// </summary>
public const string D_00000012 = "00000012";
 /// <summary>
 /// EEE
 /// </summary>
public const string E_00000013 = "00000013";
 /// <summary>
 /// FF
 /// </summary>
public const string F_00000014 = "00000014";
}
 /// <summary>
 /// 结构章节类型(ge_StructureSectionType)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsge_StructureSectionTypeBL
{
public static RelatedActions_ge_StructureSectionType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsge_StructureSectionTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsge_StructureSectionTypeDA ge_StructureSectionTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsge_StructureSectionTypeDA();
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
 public clsge_StructureSectionTypeBL()
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
if (string.IsNullOrEmpty(clsge_StructureSectionTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsge_StructureSectionTypeEN._ConnectString);
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
public static DataTable GetDataTable_ge_StructureSectionType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ge_StructureSectionTypeDA.GetDataTable_ge_StructureSectionType(strWhereCond);
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
objDT = ge_StructureSectionTypeDA.GetDataTable(strWhereCond);
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
objDT = ge_StructureSectionTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ge_StructureSectionTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ge_StructureSectionTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ge_StructureSectionTypeDA.GetDataTable_Top(objTopPara);
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
objDT = ge_StructureSectionTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ge_StructureSectionTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ge_StructureSectionTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrSectionTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsge_StructureSectionTypeEN> GetObjLstBySectionTypeIdLst(List<string> arrSectionTypeIdLst)
{
List<clsge_StructureSectionTypeEN> arrObjLst = new List<clsge_StructureSectionTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrSectionTypeIdLst, true);
 string strWhereCond = string.Format("SectionTypeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StructureSectionTypeEN objge_StructureSectionTypeEN = new clsge_StructureSectionTypeEN();
try
{
objge_StructureSectionTypeEN.SectionTypeId = objRow[conge_StructureSectionType.SectionTypeId].ToString().Trim(); //节点类型Id
objge_StructureSectionTypeEN.SectionTypeName = objRow[conge_StructureSectionType.SectionTypeName].ToString().Trim(); //节点类型名称
objge_StructureSectionTypeEN.SectionTypeEnName = objRow[conge_StructureSectionType.SectionTypeEnName] == DBNull.Value ? null : objRow[conge_StructureSectionType.SectionTypeEnName].ToString().Trim(); //节点类型英文名称
objge_StructureSectionTypeEN.CourseId = objRow[conge_StructureSectionType.CourseId].ToString().Trim(); //课程Id
objge_StructureSectionTypeEN.UpdDate = objRow[conge_StructureSectionType.UpdDate] == DBNull.Value ? null : objRow[conge_StructureSectionType.UpdDate].ToString().Trim(); //修改日期
objge_StructureSectionTypeEN.UpdUser = objRow[conge_StructureSectionType.UpdUser] == DBNull.Value ? null : objRow[conge_StructureSectionType.UpdUser].ToString().Trim(); //修改人
objge_StructureSectionTypeEN.Memo = objRow[conge_StructureSectionType.Memo] == DBNull.Value ? null : objRow[conge_StructureSectionType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StructureSectionTypeEN.SectionTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StructureSectionTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrSectionTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsge_StructureSectionTypeEN> GetObjLstBySectionTypeIdLstCache(List<string> arrSectionTypeIdLst, string strCourseId)
{
string strKey = string.Format("{0}_{1}", clsge_StructureSectionTypeEN._CurrTabName, strCourseId);
List<clsge_StructureSectionTypeEN> arrge_StructureSectionTypeObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsge_StructureSectionTypeEN> arrge_StructureSectionTypeObjLst_Sel =
arrge_StructureSectionTypeObjLstCache
.Where(x => arrSectionTypeIdLst.Contains(x.SectionTypeId));
return arrge_StructureSectionTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_StructureSectionTypeEN> GetObjLst(string strWhereCond)
{
List<clsge_StructureSectionTypeEN> arrObjLst = new List<clsge_StructureSectionTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StructureSectionTypeEN objge_StructureSectionTypeEN = new clsge_StructureSectionTypeEN();
try
{
objge_StructureSectionTypeEN.SectionTypeId = objRow[conge_StructureSectionType.SectionTypeId].ToString().Trim(); //节点类型Id
objge_StructureSectionTypeEN.SectionTypeName = objRow[conge_StructureSectionType.SectionTypeName].ToString().Trim(); //节点类型名称
objge_StructureSectionTypeEN.SectionTypeEnName = objRow[conge_StructureSectionType.SectionTypeEnName] == DBNull.Value ? null : objRow[conge_StructureSectionType.SectionTypeEnName].ToString().Trim(); //节点类型英文名称
objge_StructureSectionTypeEN.CourseId = objRow[conge_StructureSectionType.CourseId].ToString().Trim(); //课程Id
objge_StructureSectionTypeEN.UpdDate = objRow[conge_StructureSectionType.UpdDate] == DBNull.Value ? null : objRow[conge_StructureSectionType.UpdDate].ToString().Trim(); //修改日期
objge_StructureSectionTypeEN.UpdUser = objRow[conge_StructureSectionType.UpdUser] == DBNull.Value ? null : objRow[conge_StructureSectionType.UpdUser].ToString().Trim(); //修改人
objge_StructureSectionTypeEN.Memo = objRow[conge_StructureSectionType.Memo] == DBNull.Value ? null : objRow[conge_StructureSectionType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StructureSectionTypeEN.SectionTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StructureSectionTypeEN);
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
public static List<clsge_StructureSectionTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsge_StructureSectionTypeEN> arrObjLst = new List<clsge_StructureSectionTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StructureSectionTypeEN objge_StructureSectionTypeEN = new clsge_StructureSectionTypeEN();
try
{
objge_StructureSectionTypeEN.SectionTypeId = objRow[conge_StructureSectionType.SectionTypeId].ToString().Trim(); //节点类型Id
objge_StructureSectionTypeEN.SectionTypeName = objRow[conge_StructureSectionType.SectionTypeName].ToString().Trim(); //节点类型名称
objge_StructureSectionTypeEN.SectionTypeEnName = objRow[conge_StructureSectionType.SectionTypeEnName] == DBNull.Value ? null : objRow[conge_StructureSectionType.SectionTypeEnName].ToString().Trim(); //节点类型英文名称
objge_StructureSectionTypeEN.CourseId = objRow[conge_StructureSectionType.CourseId].ToString().Trim(); //课程Id
objge_StructureSectionTypeEN.UpdDate = objRow[conge_StructureSectionType.UpdDate] == DBNull.Value ? null : objRow[conge_StructureSectionType.UpdDate].ToString().Trim(); //修改日期
objge_StructureSectionTypeEN.UpdUser = objRow[conge_StructureSectionType.UpdUser] == DBNull.Value ? null : objRow[conge_StructureSectionType.UpdUser].ToString().Trim(); //修改人
objge_StructureSectionTypeEN.Memo = objRow[conge_StructureSectionType.Memo] == DBNull.Value ? null : objRow[conge_StructureSectionType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StructureSectionTypeEN.SectionTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StructureSectionTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objge_StructureSectionTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsge_StructureSectionTypeEN> GetSubObjLstCache(clsge_StructureSectionTypeEN objge_StructureSectionTypeCond)
{
 string strCourseId = objge_StructureSectionTypeCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsge_StructureSectionTypeBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsge_StructureSectionTypeEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsge_StructureSectionTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conge_StructureSectionType.AttributeName)
{
if (objge_StructureSectionTypeCond.IsUpdated(strFldName) == false) continue;
if (objge_StructureSectionTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_StructureSectionTypeCond[strFldName].ToString());
}
else
{
if (objge_StructureSectionTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objge_StructureSectionTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_StructureSectionTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objge_StructureSectionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objge_StructureSectionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objge_StructureSectionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objge_StructureSectionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objge_StructureSectionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objge_StructureSectionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objge_StructureSectionTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objge_StructureSectionTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objge_StructureSectionTypeCond[strFldName]));
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
public static List<clsge_StructureSectionTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsge_StructureSectionTypeEN> arrObjLst = new List<clsge_StructureSectionTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StructureSectionTypeEN objge_StructureSectionTypeEN = new clsge_StructureSectionTypeEN();
try
{
objge_StructureSectionTypeEN.SectionTypeId = objRow[conge_StructureSectionType.SectionTypeId].ToString().Trim(); //节点类型Id
objge_StructureSectionTypeEN.SectionTypeName = objRow[conge_StructureSectionType.SectionTypeName].ToString().Trim(); //节点类型名称
objge_StructureSectionTypeEN.SectionTypeEnName = objRow[conge_StructureSectionType.SectionTypeEnName] == DBNull.Value ? null : objRow[conge_StructureSectionType.SectionTypeEnName].ToString().Trim(); //节点类型英文名称
objge_StructureSectionTypeEN.CourseId = objRow[conge_StructureSectionType.CourseId].ToString().Trim(); //课程Id
objge_StructureSectionTypeEN.UpdDate = objRow[conge_StructureSectionType.UpdDate] == DBNull.Value ? null : objRow[conge_StructureSectionType.UpdDate].ToString().Trim(); //修改日期
objge_StructureSectionTypeEN.UpdUser = objRow[conge_StructureSectionType.UpdUser] == DBNull.Value ? null : objRow[conge_StructureSectionType.UpdUser].ToString().Trim(); //修改人
objge_StructureSectionTypeEN.Memo = objRow[conge_StructureSectionType.Memo] == DBNull.Value ? null : objRow[conge_StructureSectionType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StructureSectionTypeEN.SectionTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StructureSectionTypeEN);
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
public static List<clsge_StructureSectionTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsge_StructureSectionTypeEN> arrObjLst = new List<clsge_StructureSectionTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StructureSectionTypeEN objge_StructureSectionTypeEN = new clsge_StructureSectionTypeEN();
try
{
objge_StructureSectionTypeEN.SectionTypeId = objRow[conge_StructureSectionType.SectionTypeId].ToString().Trim(); //节点类型Id
objge_StructureSectionTypeEN.SectionTypeName = objRow[conge_StructureSectionType.SectionTypeName].ToString().Trim(); //节点类型名称
objge_StructureSectionTypeEN.SectionTypeEnName = objRow[conge_StructureSectionType.SectionTypeEnName] == DBNull.Value ? null : objRow[conge_StructureSectionType.SectionTypeEnName].ToString().Trim(); //节点类型英文名称
objge_StructureSectionTypeEN.CourseId = objRow[conge_StructureSectionType.CourseId].ToString().Trim(); //课程Id
objge_StructureSectionTypeEN.UpdDate = objRow[conge_StructureSectionType.UpdDate] == DBNull.Value ? null : objRow[conge_StructureSectionType.UpdDate].ToString().Trim(); //修改日期
objge_StructureSectionTypeEN.UpdUser = objRow[conge_StructureSectionType.UpdUser] == DBNull.Value ? null : objRow[conge_StructureSectionType.UpdUser].ToString().Trim(); //修改人
objge_StructureSectionTypeEN.Memo = objRow[conge_StructureSectionType.Memo] == DBNull.Value ? null : objRow[conge_StructureSectionType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StructureSectionTypeEN.SectionTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StructureSectionTypeEN);
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
List<clsge_StructureSectionTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsge_StructureSectionTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_StructureSectionTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsge_StructureSectionTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsge_StructureSectionTypeEN> arrObjLst = new List<clsge_StructureSectionTypeEN>(); 
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
	clsge_StructureSectionTypeEN objge_StructureSectionTypeEN = new clsge_StructureSectionTypeEN();
try
{
objge_StructureSectionTypeEN.SectionTypeId = objRow[conge_StructureSectionType.SectionTypeId].ToString().Trim(); //节点类型Id
objge_StructureSectionTypeEN.SectionTypeName = objRow[conge_StructureSectionType.SectionTypeName].ToString().Trim(); //节点类型名称
objge_StructureSectionTypeEN.SectionTypeEnName = objRow[conge_StructureSectionType.SectionTypeEnName] == DBNull.Value ? null : objRow[conge_StructureSectionType.SectionTypeEnName].ToString().Trim(); //节点类型英文名称
objge_StructureSectionTypeEN.CourseId = objRow[conge_StructureSectionType.CourseId].ToString().Trim(); //课程Id
objge_StructureSectionTypeEN.UpdDate = objRow[conge_StructureSectionType.UpdDate] == DBNull.Value ? null : objRow[conge_StructureSectionType.UpdDate].ToString().Trim(); //修改日期
objge_StructureSectionTypeEN.UpdUser = objRow[conge_StructureSectionType.UpdUser] == DBNull.Value ? null : objRow[conge_StructureSectionType.UpdUser].ToString().Trim(); //修改人
objge_StructureSectionTypeEN.Memo = objRow[conge_StructureSectionType.Memo] == DBNull.Value ? null : objRow[conge_StructureSectionType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StructureSectionTypeEN.SectionTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StructureSectionTypeEN);
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
public static List<clsge_StructureSectionTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsge_StructureSectionTypeEN> arrObjLst = new List<clsge_StructureSectionTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StructureSectionTypeEN objge_StructureSectionTypeEN = new clsge_StructureSectionTypeEN();
try
{
objge_StructureSectionTypeEN.SectionTypeId = objRow[conge_StructureSectionType.SectionTypeId].ToString().Trim(); //节点类型Id
objge_StructureSectionTypeEN.SectionTypeName = objRow[conge_StructureSectionType.SectionTypeName].ToString().Trim(); //节点类型名称
objge_StructureSectionTypeEN.SectionTypeEnName = objRow[conge_StructureSectionType.SectionTypeEnName] == DBNull.Value ? null : objRow[conge_StructureSectionType.SectionTypeEnName].ToString().Trim(); //节点类型英文名称
objge_StructureSectionTypeEN.CourseId = objRow[conge_StructureSectionType.CourseId].ToString().Trim(); //课程Id
objge_StructureSectionTypeEN.UpdDate = objRow[conge_StructureSectionType.UpdDate] == DBNull.Value ? null : objRow[conge_StructureSectionType.UpdDate].ToString().Trim(); //修改日期
objge_StructureSectionTypeEN.UpdUser = objRow[conge_StructureSectionType.UpdUser] == DBNull.Value ? null : objRow[conge_StructureSectionType.UpdUser].ToString().Trim(); //修改人
objge_StructureSectionTypeEN.Memo = objRow[conge_StructureSectionType.Memo] == DBNull.Value ? null : objRow[conge_StructureSectionType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StructureSectionTypeEN.SectionTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StructureSectionTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsge_StructureSectionTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsge_StructureSectionTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsge_StructureSectionTypeEN> arrObjLst = new List<clsge_StructureSectionTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StructureSectionTypeEN objge_StructureSectionTypeEN = new clsge_StructureSectionTypeEN();
try
{
objge_StructureSectionTypeEN.SectionTypeId = objRow[conge_StructureSectionType.SectionTypeId].ToString().Trim(); //节点类型Id
objge_StructureSectionTypeEN.SectionTypeName = objRow[conge_StructureSectionType.SectionTypeName].ToString().Trim(); //节点类型名称
objge_StructureSectionTypeEN.SectionTypeEnName = objRow[conge_StructureSectionType.SectionTypeEnName] == DBNull.Value ? null : objRow[conge_StructureSectionType.SectionTypeEnName].ToString().Trim(); //节点类型英文名称
objge_StructureSectionTypeEN.CourseId = objRow[conge_StructureSectionType.CourseId].ToString().Trim(); //课程Id
objge_StructureSectionTypeEN.UpdDate = objRow[conge_StructureSectionType.UpdDate] == DBNull.Value ? null : objRow[conge_StructureSectionType.UpdDate].ToString().Trim(); //修改日期
objge_StructureSectionTypeEN.UpdUser = objRow[conge_StructureSectionType.UpdUser] == DBNull.Value ? null : objRow[conge_StructureSectionType.UpdUser].ToString().Trim(); //修改人
objge_StructureSectionTypeEN.Memo = objRow[conge_StructureSectionType.Memo] == DBNull.Value ? null : objRow[conge_StructureSectionType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StructureSectionTypeEN.SectionTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StructureSectionTypeEN);
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
public static List<clsge_StructureSectionTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsge_StructureSectionTypeEN> arrObjLst = new List<clsge_StructureSectionTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StructureSectionTypeEN objge_StructureSectionTypeEN = new clsge_StructureSectionTypeEN();
try
{
objge_StructureSectionTypeEN.SectionTypeId = objRow[conge_StructureSectionType.SectionTypeId].ToString().Trim(); //节点类型Id
objge_StructureSectionTypeEN.SectionTypeName = objRow[conge_StructureSectionType.SectionTypeName].ToString().Trim(); //节点类型名称
objge_StructureSectionTypeEN.SectionTypeEnName = objRow[conge_StructureSectionType.SectionTypeEnName] == DBNull.Value ? null : objRow[conge_StructureSectionType.SectionTypeEnName].ToString().Trim(); //节点类型英文名称
objge_StructureSectionTypeEN.CourseId = objRow[conge_StructureSectionType.CourseId].ToString().Trim(); //课程Id
objge_StructureSectionTypeEN.UpdDate = objRow[conge_StructureSectionType.UpdDate] == DBNull.Value ? null : objRow[conge_StructureSectionType.UpdDate].ToString().Trim(); //修改日期
objge_StructureSectionTypeEN.UpdUser = objRow[conge_StructureSectionType.UpdUser] == DBNull.Value ? null : objRow[conge_StructureSectionType.UpdUser].ToString().Trim(); //修改人
objge_StructureSectionTypeEN.Memo = objRow[conge_StructureSectionType.Memo] == DBNull.Value ? null : objRow[conge_StructureSectionType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StructureSectionTypeEN.SectionTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StructureSectionTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_StructureSectionTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsge_StructureSectionTypeEN> arrObjLst = new List<clsge_StructureSectionTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StructureSectionTypeEN objge_StructureSectionTypeEN = new clsge_StructureSectionTypeEN();
try
{
objge_StructureSectionTypeEN.SectionTypeId = objRow[conge_StructureSectionType.SectionTypeId].ToString().Trim(); //节点类型Id
objge_StructureSectionTypeEN.SectionTypeName = objRow[conge_StructureSectionType.SectionTypeName].ToString().Trim(); //节点类型名称
objge_StructureSectionTypeEN.SectionTypeEnName = objRow[conge_StructureSectionType.SectionTypeEnName] == DBNull.Value ? null : objRow[conge_StructureSectionType.SectionTypeEnName].ToString().Trim(); //节点类型英文名称
objge_StructureSectionTypeEN.CourseId = objRow[conge_StructureSectionType.CourseId].ToString().Trim(); //课程Id
objge_StructureSectionTypeEN.UpdDate = objRow[conge_StructureSectionType.UpdDate] == DBNull.Value ? null : objRow[conge_StructureSectionType.UpdDate].ToString().Trim(); //修改日期
objge_StructureSectionTypeEN.UpdUser = objRow[conge_StructureSectionType.UpdUser] == DBNull.Value ? null : objRow[conge_StructureSectionType.UpdUser].ToString().Trim(); //修改人
objge_StructureSectionTypeEN.Memo = objRow[conge_StructureSectionType.Memo] == DBNull.Value ? null : objRow[conge_StructureSectionType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StructureSectionTypeEN.SectionTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StructureSectionTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objge_StructureSectionTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getge_StructureSectionType(ref clsge_StructureSectionTypeEN objge_StructureSectionTypeEN)
{
bool bolResult = ge_StructureSectionTypeDA.Getge_StructureSectionType(ref objge_StructureSectionTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strSectionTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsge_StructureSectionTypeEN GetObjBySectionTypeId(string strSectionTypeId)
{
if (strSectionTypeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strSectionTypeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strSectionTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strSectionTypeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsge_StructureSectionTypeEN objge_StructureSectionTypeEN = ge_StructureSectionTypeDA.GetObjBySectionTypeId(strSectionTypeId);
return objge_StructureSectionTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsge_StructureSectionTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsge_StructureSectionTypeEN objge_StructureSectionTypeEN = ge_StructureSectionTypeDA.GetFirstObj(strWhereCond);
 return objge_StructureSectionTypeEN;
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
public static clsge_StructureSectionTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsge_StructureSectionTypeEN objge_StructureSectionTypeEN = ge_StructureSectionTypeDA.GetObjByDataRow(objRow);
 return objge_StructureSectionTypeEN;
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
public static clsge_StructureSectionTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsge_StructureSectionTypeEN objge_StructureSectionTypeEN = ge_StructureSectionTypeDA.GetObjByDataRow(objRow);
 return objge_StructureSectionTypeEN;
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
 /// <param name = "strSectionTypeId">所给的关键字</param>
 /// <param name = "lstge_StructureSectionTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsge_StructureSectionTypeEN GetObjBySectionTypeIdFromList(string strSectionTypeId, List<clsge_StructureSectionTypeEN> lstge_StructureSectionTypeObjLst)
{
foreach (clsge_StructureSectionTypeEN objge_StructureSectionTypeEN in lstge_StructureSectionTypeObjLst)
{
if (objge_StructureSectionTypeEN.SectionTypeId == strSectionTypeId)
{
return objge_StructureSectionTypeEN;
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
 string strMaxSectionTypeId;
 try
 {
 strMaxSectionTypeId = clsge_StructureSectionTypeDA.GetMaxStrId();
 return strMaxSectionTypeId;
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
 string strSectionTypeId;
 try
 {
 strSectionTypeId = new clsge_StructureSectionTypeDA().GetFirstID(strWhereCond);
 return strSectionTypeId;
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
 arrList = ge_StructureSectionTypeDA.GetID(strWhereCond);
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
bool bolIsExist = ge_StructureSectionTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strSectionTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strSectionTypeId)
{
if (string.IsNullOrEmpty(strSectionTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strSectionTypeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = ge_StructureSectionTypeDA.IsExist(strSectionTypeId);
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
 bolIsExist = clsge_StructureSectionTypeDA.IsExistTable();
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
 bolIsExist = ge_StructureSectionTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objge_StructureSectionTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsge_StructureSectionTypeEN objge_StructureSectionTypeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objge_StructureSectionTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!节点类型名称 = [{0}]的数据已经存在!(in clsge_StructureSectionTypeBL.AddNewRecordBySql2)", objge_StructureSectionTypeEN.SectionTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objge_StructureSectionTypeEN.SectionTypeId) == true || clsge_StructureSectionTypeBL.IsExist(objge_StructureSectionTypeEN.SectionTypeId) == true)
 {
     objge_StructureSectionTypeEN.SectionTypeId = clsge_StructureSectionTypeBL.GetMaxStrId_S();
 }
bool bolResult = ge_StructureSectionTypeDA.AddNewRecordBySQL2(objge_StructureSectionTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureSectionTypeBL.ReFreshCache(objge_StructureSectionTypeEN.CourseId);

if (clsge_StructureSectionTypeBL.relatedActions != null)
{
clsge_StructureSectionTypeBL.relatedActions.UpdRelaTabDate(objge_StructureSectionTypeEN.SectionTypeId, "SetUpdDate");
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
 /// <param name = "objge_StructureSectionTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsge_StructureSectionTypeEN objge_StructureSectionTypeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objge_StructureSectionTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!节点类型名称 = [{0}]的数据已经存在!(in clsge_StructureSectionTypeBL.AddNewRecordBySql2WithReturnKey)", objge_StructureSectionTypeEN.SectionTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objge_StructureSectionTypeEN.SectionTypeId) == true || clsge_StructureSectionTypeBL.IsExist(objge_StructureSectionTypeEN.SectionTypeId) == true)
 {
     objge_StructureSectionTypeEN.SectionTypeId = clsge_StructureSectionTypeBL.GetMaxStrId_S();
 }
string strKey = ge_StructureSectionTypeDA.AddNewRecordBySQL2WithReturnKey(objge_StructureSectionTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureSectionTypeBL.ReFreshCache(objge_StructureSectionTypeEN.CourseId);

if (clsge_StructureSectionTypeBL.relatedActions != null)
{
clsge_StructureSectionTypeBL.relatedActions.UpdRelaTabDate(objge_StructureSectionTypeEN.SectionTypeId, "SetUpdDate");
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
 /// <param name = "objge_StructureSectionTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsge_StructureSectionTypeEN objge_StructureSectionTypeEN)
{
try
{
bool bolResult = ge_StructureSectionTypeDA.Update(objge_StructureSectionTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureSectionTypeBL.ReFreshCache(objge_StructureSectionTypeEN.CourseId);

if (clsge_StructureSectionTypeBL.relatedActions != null)
{
clsge_StructureSectionTypeBL.relatedActions.UpdRelaTabDate(objge_StructureSectionTypeEN.SectionTypeId, "SetUpdDate");
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
 /// <param name = "objge_StructureSectionTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsge_StructureSectionTypeEN objge_StructureSectionTypeEN)
{
 if (string.IsNullOrEmpty(objge_StructureSectionTypeEN.SectionTypeId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ge_StructureSectionTypeDA.UpdateBySql2(objge_StructureSectionTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureSectionTypeBL.ReFreshCache(objge_StructureSectionTypeEN.CourseId);

if (clsge_StructureSectionTypeBL.relatedActions != null)
{
clsge_StructureSectionTypeBL.relatedActions.UpdRelaTabDate(objge_StructureSectionTypeEN.SectionTypeId, "SetUpdDate");
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
 /// <param name = "strSectionTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strSectionTypeId)
{
try
{
 clsge_StructureSectionTypeEN objge_StructureSectionTypeEN = clsge_StructureSectionTypeBL.GetObjBySectionTypeId(strSectionTypeId);

if (clsge_StructureSectionTypeBL.relatedActions != null)
{
clsge_StructureSectionTypeBL.relatedActions.UpdRelaTabDate(objge_StructureSectionTypeEN.SectionTypeId, "SetUpdDate");
}
if (objge_StructureSectionTypeEN != null)
{
int intRecNum = ge_StructureSectionTypeDA.DelRecord(strSectionTypeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objge_StructureSectionTypeEN.CourseId);
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
/// <param name="strSectionTypeId">表关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strSectionTypeId , string strCourseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsge_StructureSectionTypeDA.GetSpecSQLObj();
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
//删除与表:[ge_StructureSectionType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conge_StructureSectionType.SectionTypeId,
//strSectionTypeId);
//        clsge_StructureSectionTypeBL.Delge_StructureSectionTypesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsge_StructureSectionTypeBL.DelRecord(strSectionTypeId, strCourseId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsge_StructureSectionTypeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strSectionTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strSectionTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strSectionTypeId, string strCourseId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsge_StructureSectionTypeBL.relatedActions != null)
{
clsge_StructureSectionTypeBL.relatedActions.UpdRelaTabDate(strSectionTypeId, "UpdRelaTabDate");
}
bool bolResult = ge_StructureSectionTypeDA.DelRecord(strSectionTypeId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrSectionTypeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delge_StructureSectionTypes(List<string> arrSectionTypeIdLst)
{
if (arrSectionTypeIdLst.Count == 0) return 0;
try
{
if (clsge_StructureSectionTypeBL.relatedActions != null)
{
foreach (var strSectionTypeId in arrSectionTypeIdLst)
{
clsge_StructureSectionTypeBL.relatedActions.UpdRelaTabDate(strSectionTypeId, "UpdRelaTabDate");
}
}
 clsge_StructureSectionTypeEN objge_StructureSectionTypeEN = clsge_StructureSectionTypeBL.GetObjBySectionTypeId(arrSectionTypeIdLst[0]);
int intDelRecNum = ge_StructureSectionTypeDA.Delge_StructureSectionType(arrSectionTypeIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objge_StructureSectionTypeEN.CourseId);
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
public static int Delge_StructureSectionTypesByCond(string strWhereCond)
{
try
{
if (clsge_StructureSectionTypeBL.relatedActions != null)
{
List<string> arrSectionTypeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strSectionTypeId in arrSectionTypeId)
{
clsge_StructureSectionTypeBL.relatedActions.UpdRelaTabDate(strSectionTypeId, "UpdRelaTabDate");
}
}
List<string> arrCourseId = GetFldValue(conge_StructureSectionType.CourseId, strWhereCond);
int intRecNum = ge_StructureSectionTypeDA.Delge_StructureSectionType(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[ge_StructureSectionType]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strSectionTypeId">表关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strSectionTypeId, string strCourseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsge_StructureSectionTypeDA.GetSpecSQLObj();
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
//删除与表:[ge_StructureSectionType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsge_StructureSectionTypeBL.DelRecord(strSectionTypeId, strCourseId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsge_StructureSectionTypeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strSectionTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objge_StructureSectionTypeENS">源对象</param>
 /// <param name = "objge_StructureSectionTypeENT">目标对象</param>
 public static void CopyTo(clsge_StructureSectionTypeEN objge_StructureSectionTypeENS, clsge_StructureSectionTypeEN objge_StructureSectionTypeENT)
{
try
{
objge_StructureSectionTypeENT.SectionTypeId = objge_StructureSectionTypeENS.SectionTypeId; //节点类型Id
objge_StructureSectionTypeENT.SectionTypeName = objge_StructureSectionTypeENS.SectionTypeName; //节点类型名称
objge_StructureSectionTypeENT.SectionTypeEnName = objge_StructureSectionTypeENS.SectionTypeEnName; //节点类型英文名称
objge_StructureSectionTypeENT.CourseId = objge_StructureSectionTypeENS.CourseId; //课程Id
objge_StructureSectionTypeENT.UpdDate = objge_StructureSectionTypeENS.UpdDate; //修改日期
objge_StructureSectionTypeENT.UpdUser = objge_StructureSectionTypeENS.UpdUser; //修改人
objge_StructureSectionTypeENT.Memo = objge_StructureSectionTypeENS.Memo; //备注
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
 /// <param name = "objge_StructureSectionTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsge_StructureSectionTypeEN objge_StructureSectionTypeEN)
{
try
{
objge_StructureSectionTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objge_StructureSectionTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conge_StructureSectionType.SectionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureSectionTypeEN.SectionTypeId = objge_StructureSectionTypeEN.SectionTypeId; //节点类型Id
}
if (arrFldSet.Contains(conge_StructureSectionType.SectionTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureSectionTypeEN.SectionTypeName = objge_StructureSectionTypeEN.SectionTypeName; //节点类型名称
}
if (arrFldSet.Contains(conge_StructureSectionType.SectionTypeEnName, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureSectionTypeEN.SectionTypeEnName = objge_StructureSectionTypeEN.SectionTypeEnName == "[null]" ? null :  objge_StructureSectionTypeEN.SectionTypeEnName; //节点类型英文名称
}
if (arrFldSet.Contains(conge_StructureSectionType.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureSectionTypeEN.CourseId = objge_StructureSectionTypeEN.CourseId; //课程Id
}
if (arrFldSet.Contains(conge_StructureSectionType.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureSectionTypeEN.UpdDate = objge_StructureSectionTypeEN.UpdDate == "[null]" ? null :  objge_StructureSectionTypeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conge_StructureSectionType.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureSectionTypeEN.UpdUser = objge_StructureSectionTypeEN.UpdUser == "[null]" ? null :  objge_StructureSectionTypeEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conge_StructureSectionType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureSectionTypeEN.Memo = objge_StructureSectionTypeEN.Memo == "[null]" ? null :  objge_StructureSectionTypeEN.Memo; //备注
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
 /// <param name = "objge_StructureSectionTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsge_StructureSectionTypeEN objge_StructureSectionTypeEN)
{
try
{
if (objge_StructureSectionTypeEN.SectionTypeEnName == "[null]") objge_StructureSectionTypeEN.SectionTypeEnName = null; //节点类型英文名称
if (objge_StructureSectionTypeEN.UpdDate == "[null]") objge_StructureSectionTypeEN.UpdDate = null; //修改日期
if (objge_StructureSectionTypeEN.UpdUser == "[null]") objge_StructureSectionTypeEN.UpdUser = null; //修改人
if (objge_StructureSectionTypeEN.Memo == "[null]") objge_StructureSectionTypeEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsge_StructureSectionTypeEN objge_StructureSectionTypeEN)
{
 ge_StructureSectionTypeDA.CheckPropertyNew(objge_StructureSectionTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsge_StructureSectionTypeEN objge_StructureSectionTypeEN)
{
 ge_StructureSectionTypeDA.CheckProperty4Condition(objge_StructureSectionTypeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_SectionTypeIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strCourseId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[结构章节类型]...","0");
List<clsge_StructureSectionTypeEN> arrge_StructureSectionTypeObjLst = GetAllge_StructureSectionTypeObjLstCache(strCourseId); 
objDDL.DataValueField = conge_StructureSectionType.SectionTypeId;
objDDL.DataTextField = conge_StructureSectionType.SectionTypeName;
objDDL.DataSource = arrge_StructureSectionTypeObjLst;
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
if (clsge_StructureSectionTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsge_StructureSectionTypeBL没有刷新缓存机制(clsge_StructureSectionTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by SectionTypeId");
//if (arrge_StructureSectionTypeObjLstCache == null)
//{
//arrge_StructureSectionTypeObjLstCache = ge_StructureSectionTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strSectionTypeId">所给的关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsge_StructureSectionTypeEN GetObjBySectionTypeIdCache(string strSectionTypeId, string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsge_StructureSectionTypeEN._CurrTabName, strCourseId);
List<clsge_StructureSectionTypeEN> arrge_StructureSectionTypeObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsge_StructureSectionTypeEN> arrge_StructureSectionTypeObjLst_Sel =
arrge_StructureSectionTypeObjLstCache
.Where(x=> x.SectionTypeId == strSectionTypeId 
);
if (arrge_StructureSectionTypeObjLst_Sel.Count() == 0)
{
   clsge_StructureSectionTypeEN obj = clsge_StructureSectionTypeBL.GetObjBySectionTypeId(strSectionTypeId);
   if (obj != null)
 {
if (obj.CourseId == strCourseId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strSectionTypeId, strCourseId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrge_StructureSectionTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strSectionTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetSectionTypeNameBySectionTypeIdCache(string strSectionTypeId, string strCourseId)
{
if (string.IsNullOrEmpty(strSectionTypeId) == true) return "";
//获取缓存中的对象列表
clsge_StructureSectionTypeEN objge_StructureSectionType = GetObjBySectionTypeIdCache(strSectionTypeId, strCourseId);
if (objge_StructureSectionType == null) return "";
return objge_StructureSectionType.SectionTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strSectionTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameBySectionTypeIdCache(string strSectionTypeId, string strCourseId)
{
if (string.IsNullOrEmpty(strSectionTypeId) == true) return "";
//获取缓存中的对象列表
clsge_StructureSectionTypeEN objge_StructureSectionType = GetObjBySectionTypeIdCache(strSectionTypeId, strCourseId);
if (objge_StructureSectionType == null) return "";
return objge_StructureSectionType.SectionTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsge_StructureSectionTypeEN> GetAllge_StructureSectionTypeObjLstCache(string strCourseId)
{
//获取缓存中的对象列表
List<clsge_StructureSectionTypeEN> arrge_StructureSectionTypeObjLstCache = GetObjLstCache(strCourseId); 
return arrge_StructureSectionTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsge_StructureSectionTypeEN> GetObjLstCache(string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsge_StructureSectionTypeEN._CurrTabName, strCourseId);
string strCondition = string.Format("CourseId='{0}'", strCourseId);
List<clsge_StructureSectionTypeEN> arrge_StructureSectionTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrge_StructureSectionTypeObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsge_StructureSectionTypeEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clsge_StructureSectionTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsge_StructureSectionTypeEN._RefreshTimeLst.Count == 0) return "";
return clsge_StructureSectionTypeEN._RefreshTimeLst[clsge_StructureSectionTypeEN._RefreshTimeLst.Count - 1];
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
if (clsge_StructureSectionTypeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsge_StructureSectionTypeEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clsge_StructureSectionTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsge_StructureSectionTypeBL.objCommFun4BL.ReFreshCache(strCourseId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--ge_StructureSectionType(结构章节类型)
 /// 唯一性条件:SectionTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objge_StructureSectionTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsge_StructureSectionTypeEN objge_StructureSectionTypeEN)
{
//检测记录是否存在
string strResult = ge_StructureSectionTypeDA.GetUniCondStr(objge_StructureSectionTypeEN);
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
public static string Func(string strInFldName, string strOutFldName, string strSectionTypeId, string strCourseId)
{
if (strInFldName != conge_StructureSectionType.SectionTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conge_StructureSectionType.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conge_StructureSectionType.AttributeName));
throw new Exception(strMsg);
}
var objge_StructureSectionType = clsge_StructureSectionTypeBL.GetObjBySectionTypeIdCache(strSectionTypeId, strCourseId);
if (objge_StructureSectionType == null) return "";
return objge_StructureSectionType[strOutFldName].ToString();
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
int intRecCount = clsge_StructureSectionTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsge_StructureSectionTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsge_StructureSectionTypeDA.GetRecCount();
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
int intRecCount = clsge_StructureSectionTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objge_StructureSectionTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsge_StructureSectionTypeEN objge_StructureSectionTypeCond)
{
 string strCourseId = objge_StructureSectionTypeCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsge_StructureSectionTypeBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsge_StructureSectionTypeEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsge_StructureSectionTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conge_StructureSectionType.AttributeName)
{
if (objge_StructureSectionTypeCond.IsUpdated(strFldName) == false) continue;
if (objge_StructureSectionTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_StructureSectionTypeCond[strFldName].ToString());
}
else
{
if (objge_StructureSectionTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objge_StructureSectionTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_StructureSectionTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objge_StructureSectionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objge_StructureSectionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objge_StructureSectionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objge_StructureSectionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objge_StructureSectionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objge_StructureSectionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objge_StructureSectionTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objge_StructureSectionTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objge_StructureSectionTypeCond[strFldName]));
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
 List<string> arrList = clsge_StructureSectionTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ge_StructureSectionTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ge_StructureSectionTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ge_StructureSectionTypeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsge_StructureSectionTypeDA.SetFldValue(clsge_StructureSectionTypeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ge_StructureSectionTypeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsge_StructureSectionTypeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsge_StructureSectionTypeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsge_StructureSectionTypeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ge_StructureSectionType] "); 
 strCreateTabCode.Append(" ( "); 
 // /**节点类型Id*/ 
 strCreateTabCode.Append(" SectionTypeId char(8) primary key, "); 
 // /**节点类型名称*/ 
 strCreateTabCode.Append(" SectionTypeName varchar(100) not Null, "); 
 // /**节点类型英文名称*/ 
 strCreateTabCode.Append(" SectionTypeEnName varchar(100) Null, "); 
 // /**课程Id*/ 
 strCreateTabCode.Append(" CourseId char(8) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 结构章节类型(ge_StructureSectionType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4ge_StructureSectionType : clsCommFun4BLV2
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
clsge_StructureSectionTypeBL.ReFreshThisCache(strCourseId);
}
}

}