
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_StructureGraphBL
 表名:ge_StructureGraph(01120895)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:10:11
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
public static class  clsge_StructureGraphBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strStructureGraphId">表关键字</param>
 /// <returns>表对象</returns>
public static clsge_StructureGraphEN GetObj(this K_StructureGraphId_ge_StructureGraph myKey)
{
clsge_StructureGraphEN objge_StructureGraphEN = clsge_StructureGraphBL.ge_StructureGraphDA.GetObjByStructureGraphId(myKey.Value);
return objge_StructureGraphEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objge_StructureGraphEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsge_StructureGraphEN objge_StructureGraphEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objge_StructureGraphEN) == false)
{
var strMsg = string.Format("记录已经存在!知识图谱Id = [{0}]的数据已经存在!(in clsge_StructureGraphBL.AddNewRecord)", objge_StructureGraphEN.StructureGraphId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objge_StructureGraphEN.StructureGraphId) == true || clsge_StructureGraphBL.IsExist(objge_StructureGraphEN.StructureGraphId) == true)
 {
     objge_StructureGraphEN.StructureGraphId = clsge_StructureGraphBL.GetMaxStrId_S();
 }
bool bolResult = clsge_StructureGraphBL.ge_StructureGraphDA.AddNewRecordBySQL2(objge_StructureGraphEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureGraphBL.ReFreshCache(objge_StructureGraphEN.CourseId);

if (clsge_StructureGraphBL.relatedActions != null)
{
clsge_StructureGraphBL.relatedActions.UpdRelaTabDate(objge_StructureGraphEN.StructureGraphId, "SetUpdDate");
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
public static bool AddRecordEx(this clsge_StructureGraphEN objge_StructureGraphEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsge_StructureGraphBL.IsExist(objge_StructureGraphEN.StructureGraphId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objge_StructureGraphEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objge_StructureGraphEN.CheckUniqueness() == false)
{
strMsg = string.Format("(知识图谱Id(StructureGraphId)=[{0}])已经存在,不能重复!", objge_StructureGraphEN.StructureGraphId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objge_StructureGraphEN.StructureGraphId) == true || clsge_StructureGraphBL.IsExist(objge_StructureGraphEN.StructureGraphId) == true)
 {
     objge_StructureGraphEN.StructureGraphId = clsge_StructureGraphBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objge_StructureGraphEN.AddNewRecord();
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
 /// <param name = "objge_StructureGraphEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsge_StructureGraphEN objge_StructureGraphEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objge_StructureGraphEN) == false)
{
var strMsg = string.Format("记录已经存在!知识图谱Id = [{0}]的数据已经存在!(in clsge_StructureGraphBL.AddNewRecordWithMaxId)", objge_StructureGraphEN.StructureGraphId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objge_StructureGraphEN.StructureGraphId) == true || clsge_StructureGraphBL.IsExist(objge_StructureGraphEN.StructureGraphId) == true)
 {
     objge_StructureGraphEN.StructureGraphId = clsge_StructureGraphBL.GetMaxStrId_S();
 }
string strStructureGraphId = clsge_StructureGraphBL.ge_StructureGraphDA.AddNewRecordBySQL2WithReturnKey(objge_StructureGraphEN);
     objge_StructureGraphEN.StructureGraphId = strStructureGraphId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureGraphBL.ReFreshCache(objge_StructureGraphEN.CourseId);

if (clsge_StructureGraphBL.relatedActions != null)
{
clsge_StructureGraphBL.relatedActions.UpdRelaTabDate(objge_StructureGraphEN.StructureGraphId, "SetUpdDate");
}
return strStructureGraphId;
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
 /// <param name = "objge_StructureGraphEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsge_StructureGraphEN objge_StructureGraphEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objge_StructureGraphEN) == false)
{
var strMsg = string.Format("记录已经存在!知识图谱Id = [{0}]的数据已经存在!(in clsge_StructureGraphBL.AddNewRecordWithReturnKey)", objge_StructureGraphEN.StructureGraphId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objge_StructureGraphEN.StructureGraphId) == true || clsge_StructureGraphBL.IsExist(objge_StructureGraphEN.StructureGraphId) == true)
 {
     objge_StructureGraphEN.StructureGraphId = clsge_StructureGraphBL.GetMaxStrId_S();
 }
string strKey = clsge_StructureGraphBL.ge_StructureGraphDA.AddNewRecordBySQL2WithReturnKey(objge_StructureGraphEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureGraphBL.ReFreshCache(objge_StructureGraphEN.CourseId);

if (clsge_StructureGraphBL.relatedActions != null)
{
clsge_StructureGraphBL.relatedActions.UpdRelaTabDate(objge_StructureGraphEN.StructureGraphId, "SetUpdDate");
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
 /// <param name = "objge_StructureGraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureGraphEN SetStructureGraphId(this clsge_StructureGraphEN objge_StructureGraphEN, string strStructureGraphId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStructureGraphId, 10, conge_StructureGraph.StructureGraphId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strStructureGraphId, 10, conge_StructureGraph.StructureGraphId);
}
objge_StructureGraphEN.StructureGraphId = strStructureGraphId; //知识图谱Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureGraphEN.dicFldComparisonOp.ContainsKey(conge_StructureGraph.StructureGraphId) == false)
{
objge_StructureGraphEN.dicFldComparisonOp.Add(conge_StructureGraph.StructureGraphId, strComparisonOp);
}
else
{
objge_StructureGraphEN.dicFldComparisonOp[conge_StructureGraph.StructureGraphId] = strComparisonOp;
}
}
return objge_StructureGraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureGraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureGraphEN SetStructureGraphName(this clsge_StructureGraphEN objge_StructureGraphEN, string strStructureGraphName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStructureGraphName, 100, conge_StructureGraph.StructureGraphName);
}
objge_StructureGraphEN.StructureGraphName = strStructureGraphName; //结构图谱名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureGraphEN.dicFldComparisonOp.ContainsKey(conge_StructureGraph.StructureGraphName) == false)
{
objge_StructureGraphEN.dicFldComparisonOp.Add(conge_StructureGraph.StructureGraphName, strComparisonOp);
}
else
{
objge_StructureGraphEN.dicFldComparisonOp[conge_StructureGraph.StructureGraphName] = strComparisonOp;
}
}
return objge_StructureGraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureGraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureGraphEN SetIdCurrEduCls(this clsge_StructureGraphEN objge_StructureGraphEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conge_StructureGraph.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conge_StructureGraph.IdCurrEduCls);
}
objge_StructureGraphEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureGraphEN.dicFldComparisonOp.ContainsKey(conge_StructureGraph.IdCurrEduCls) == false)
{
objge_StructureGraphEN.dicFldComparisonOp.Add(conge_StructureGraph.IdCurrEduCls, strComparisonOp);
}
else
{
objge_StructureGraphEN.dicFldComparisonOp[conge_StructureGraph.IdCurrEduCls] = strComparisonOp;
}
}
return objge_StructureGraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureGraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureGraphEN SetCourseId(this clsge_StructureGraphEN objge_StructureGraphEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, conge_StructureGraph.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, conge_StructureGraph.CourseId);
}
objge_StructureGraphEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureGraphEN.dicFldComparisonOp.ContainsKey(conge_StructureGraph.CourseId) == false)
{
objge_StructureGraphEN.dicFldComparisonOp.Add(conge_StructureGraph.CourseId, strComparisonOp);
}
else
{
objge_StructureGraphEN.dicFldComparisonOp[conge_StructureGraph.CourseId] = strComparisonOp;
}
}
return objge_StructureGraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureGraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureGraphEN SetCreateUser(this clsge_StructureGraphEN objge_StructureGraphEN, string strCreateUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateUser, 50, conge_StructureGraph.CreateUser);
}
objge_StructureGraphEN.CreateUser = strCreateUser; //建立用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureGraphEN.dicFldComparisonOp.ContainsKey(conge_StructureGraph.CreateUser) == false)
{
objge_StructureGraphEN.dicFldComparisonOp.Add(conge_StructureGraph.CreateUser, strComparisonOp);
}
else
{
objge_StructureGraphEN.dicFldComparisonOp[conge_StructureGraph.CreateUser] = strComparisonOp;
}
}
return objge_StructureGraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureGraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureGraphEN SetUpdDate(this clsge_StructureGraphEN objge_StructureGraphEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conge_StructureGraph.UpdDate);
}
objge_StructureGraphEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureGraphEN.dicFldComparisonOp.ContainsKey(conge_StructureGraph.UpdDate) == false)
{
objge_StructureGraphEN.dicFldComparisonOp.Add(conge_StructureGraph.UpdDate, strComparisonOp);
}
else
{
objge_StructureGraphEN.dicFldComparisonOp[conge_StructureGraph.UpdDate] = strComparisonOp;
}
}
return objge_StructureGraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureGraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureGraphEN SetUpdUser(this clsge_StructureGraphEN objge_StructureGraphEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conge_StructureGraph.UpdUser);
}
objge_StructureGraphEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureGraphEN.dicFldComparisonOp.ContainsKey(conge_StructureGraph.UpdUser) == false)
{
objge_StructureGraphEN.dicFldComparisonOp.Add(conge_StructureGraph.UpdUser, strComparisonOp);
}
else
{
objge_StructureGraphEN.dicFldComparisonOp[conge_StructureGraph.UpdUser] = strComparisonOp;
}
}
return objge_StructureGraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureGraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureGraphEN SetMemo(this clsge_StructureGraphEN objge_StructureGraphEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conge_StructureGraph.Memo);
}
objge_StructureGraphEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureGraphEN.dicFldComparisonOp.ContainsKey(conge_StructureGraph.Memo) == false)
{
objge_StructureGraphEN.dicFldComparisonOp.Add(conge_StructureGraph.Memo, strComparisonOp);
}
else
{
objge_StructureGraphEN.dicFldComparisonOp[conge_StructureGraph.Memo] = strComparisonOp;
}
}
return objge_StructureGraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureGraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureGraphEN SetGraphTypeId(this clsge_StructureGraphEN objge_StructureGraphEN, string strGraphTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGraphTypeId, 2, conge_StructureGraph.GraphTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGraphTypeId, 2, conge_StructureGraph.GraphTypeId);
}
objge_StructureGraphEN.GraphTypeId = strGraphTypeId; //图谱类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureGraphEN.dicFldComparisonOp.ContainsKey(conge_StructureGraph.GraphTypeId) == false)
{
objge_StructureGraphEN.dicFldComparisonOp.Add(conge_StructureGraph.GraphTypeId, strComparisonOp);
}
else
{
objge_StructureGraphEN.dicFldComparisonOp[conge_StructureGraph.GraphTypeId] = strComparisonOp;
}
}
return objge_StructureGraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureGraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureGraphEN SetIsDisplay(this clsge_StructureGraphEN objge_StructureGraphEN, bool bolIsDisplay, string strComparisonOp="")
	{
objge_StructureGraphEN.IsDisplay = bolIsDisplay; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureGraphEN.dicFldComparisonOp.ContainsKey(conge_StructureGraph.IsDisplay) == false)
{
objge_StructureGraphEN.dicFldComparisonOp.Add(conge_StructureGraph.IsDisplay, strComparisonOp);
}
else
{
objge_StructureGraphEN.dicFldComparisonOp[conge_StructureGraph.IsDisplay] = strComparisonOp;
}
}
return objge_StructureGraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureGraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureGraphEN SetIsExtend(this clsge_StructureGraphEN objge_StructureGraphEN, bool bolIsExtend, string strComparisonOp="")
	{
objge_StructureGraphEN.IsExtend = bolIsExtend; //是否扩展
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureGraphEN.dicFldComparisonOp.ContainsKey(conge_StructureGraph.IsExtend) == false)
{
objge_StructureGraphEN.dicFldComparisonOp.Add(conge_StructureGraph.IsExtend, strComparisonOp);
}
else
{
objge_StructureGraphEN.dicFldComparisonOp[conge_StructureGraph.IsExtend] = strComparisonOp;
}
}
return objge_StructureGraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureGraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureGraphEN SetIsRecommend(this clsge_StructureGraphEN objge_StructureGraphEN, bool bolIsRecommend, string strComparisonOp="")
	{
objge_StructureGraphEN.IsRecommend = bolIsRecommend; //是否推荐
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureGraphEN.dicFldComparisonOp.ContainsKey(conge_StructureGraph.IsRecommend) == false)
{
objge_StructureGraphEN.dicFldComparisonOp.Add(conge_StructureGraph.IsRecommend, strComparisonOp);
}
else
{
objge_StructureGraphEN.dicFldComparisonOp[conge_StructureGraph.IsRecommend] = strComparisonOp;
}
}
return objge_StructureGraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureGraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureGraphEN SetTheme(this clsge_StructureGraphEN objge_StructureGraphEN, string strTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTheme, 100, conge_StructureGraph.Theme);
}
objge_StructureGraphEN.Theme = strTheme; //主题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureGraphEN.dicFldComparisonOp.ContainsKey(conge_StructureGraph.Theme) == false)
{
objge_StructureGraphEN.dicFldComparisonOp.Add(conge_StructureGraph.Theme, strComparisonOp);
}
else
{
objge_StructureGraphEN.dicFldComparisonOp[conge_StructureGraph.Theme] = strComparisonOp;
}
}
return objge_StructureGraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureGraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureGraphEN SetIsSubmit(this clsge_StructureGraphEN objge_StructureGraphEN, bool bolIsSubmit, string strComparisonOp="")
	{
objge_StructureGraphEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureGraphEN.dicFldComparisonOp.ContainsKey(conge_StructureGraph.IsSubmit) == false)
{
objge_StructureGraphEN.dicFldComparisonOp.Add(conge_StructureGraph.IsSubmit, strComparisonOp);
}
else
{
objge_StructureGraphEN.dicFldComparisonOp[conge_StructureGraph.IsSubmit] = strComparisonOp;
}
}
return objge_StructureGraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureGraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureGraphEN SetSectionTypeId(this clsge_StructureGraphEN objge_StructureGraphEN, string strSectionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSectionTypeId, conge_StructureGraph.SectionTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionTypeId, 8, conge_StructureGraph.SectionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSectionTypeId, 8, conge_StructureGraph.SectionTypeId);
}
objge_StructureGraphEN.SectionTypeId = strSectionTypeId; //节点类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureGraphEN.dicFldComparisonOp.ContainsKey(conge_StructureGraph.SectionTypeId) == false)
{
objge_StructureGraphEN.dicFldComparisonOp.Add(conge_StructureGraph.SectionTypeId, strComparisonOp);
}
else
{
objge_StructureGraphEN.dicFldComparisonOp[conge_StructureGraph.SectionTypeId] = strComparisonOp;
}
}
return objge_StructureGraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureGraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureGraphEN SetTakeUpTime(this clsge_StructureGraphEN objge_StructureGraphEN, string strTakeUpTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTakeUpTime, 50, conge_StructureGraph.TakeUpTime);
}
objge_StructureGraphEN.TakeUpTime = strTakeUpTime; //耗时
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureGraphEN.dicFldComparisonOp.ContainsKey(conge_StructureGraph.TakeUpTime) == false)
{
objge_StructureGraphEN.dicFldComparisonOp.Add(conge_StructureGraph.TakeUpTime, strComparisonOp);
}
else
{
objge_StructureGraphEN.dicFldComparisonOp[conge_StructureGraph.TakeUpTime] = strComparisonOp;
}
}
return objge_StructureGraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureGraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureGraphEN SetStartTime(this clsge_StructureGraphEN objge_StructureGraphEN, string strStartTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStartTime, 20, conge_StructureGraph.StartTime);
}
objge_StructureGraphEN.StartTime = strStartTime; //开始时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureGraphEN.dicFldComparisonOp.ContainsKey(conge_StructureGraph.StartTime) == false)
{
objge_StructureGraphEN.dicFldComparisonOp.Add(conge_StructureGraph.StartTime, strComparisonOp);
}
else
{
objge_StructureGraphEN.dicFldComparisonOp[conge_StructureGraph.StartTime] = strComparisonOp;
}
}
return objge_StructureGraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureGraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureGraphEN SetSubmitTime(this clsge_StructureGraphEN objge_StructureGraphEN, string strSubmitTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSubmitTime, 20, conge_StructureGraph.SubmitTime);
}
objge_StructureGraphEN.SubmitTime = strSubmitTime; //提交时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureGraphEN.dicFldComparisonOp.ContainsKey(conge_StructureGraph.SubmitTime) == false)
{
objge_StructureGraphEN.dicFldComparisonOp.Add(conge_StructureGraph.SubmitTime, strComparisonOp);
}
else
{
objge_StructureGraphEN.dicFldComparisonOp[conge_StructureGraph.SubmitTime] = strComparisonOp;
}
}
return objge_StructureGraphEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objge_StructureGraphEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsge_StructureGraphEN objge_StructureGraphEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objge_StructureGraphEN.CheckPropertyNew();
clsge_StructureGraphEN objge_StructureGraphCond = new clsge_StructureGraphEN();
string strCondition = objge_StructureGraphCond
.SetStructureGraphId(objge_StructureGraphEN.StructureGraphId, "<>")
.SetStructureGraphId(objge_StructureGraphEN.StructureGraphId, "=")
.GetCombineCondition();
objge_StructureGraphEN._IsCheckProperty = true;
bool bolIsExist = clsge_StructureGraphBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(StructureGraphId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objge_StructureGraphEN.Update();
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
 /// <param name = "objge_StructureGraph">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsge_StructureGraphEN objge_StructureGraph)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsge_StructureGraphEN objge_StructureGraphCond = new clsge_StructureGraphEN();
string strCondition = objge_StructureGraphCond
.SetStructureGraphId(objge_StructureGraph.StructureGraphId, "=")
.GetCombineCondition();
objge_StructureGraph._IsCheckProperty = true;
bool bolIsExist = clsge_StructureGraphBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objge_StructureGraph.StructureGraphId = clsge_StructureGraphBL.GetFirstID_S(strCondition);
objge_StructureGraph.UpdateWithCondition(strCondition);
}
else
{
objge_StructureGraph.StructureGraphId = clsge_StructureGraphBL.GetMaxStrId_S();
objge_StructureGraph.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objge_StructureGraphEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsge_StructureGraphEN objge_StructureGraphEN)
{
 if (string.IsNullOrEmpty(objge_StructureGraphEN.StructureGraphId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsge_StructureGraphBL.ge_StructureGraphDA.UpdateBySql2(objge_StructureGraphEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureGraphBL.ReFreshCache(objge_StructureGraphEN.CourseId);

if (clsge_StructureGraphBL.relatedActions != null)
{
clsge_StructureGraphBL.relatedActions.UpdRelaTabDate(objge_StructureGraphEN.StructureGraphId, "SetUpdDate");
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
 /// <param name = "objge_StructureGraphEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsge_StructureGraphEN objge_StructureGraphEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objge_StructureGraphEN.StructureGraphId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsge_StructureGraphBL.ge_StructureGraphDA.UpdateBySql2(objge_StructureGraphEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureGraphBL.ReFreshCache(objge_StructureGraphEN.CourseId);

if (clsge_StructureGraphBL.relatedActions != null)
{
clsge_StructureGraphBL.relatedActions.UpdRelaTabDate(objge_StructureGraphEN.StructureGraphId, "SetUpdDate");
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
 /// <param name = "objge_StructureGraphEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsge_StructureGraphEN objge_StructureGraphEN, string strWhereCond)
{
try
{
bool bolResult = clsge_StructureGraphBL.ge_StructureGraphDA.UpdateBySqlWithCondition(objge_StructureGraphEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureGraphBL.ReFreshCache(objge_StructureGraphEN.CourseId);

if (clsge_StructureGraphBL.relatedActions != null)
{
clsge_StructureGraphBL.relatedActions.UpdRelaTabDate(objge_StructureGraphEN.StructureGraphId, "SetUpdDate");
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
 /// <param name = "objge_StructureGraphEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsge_StructureGraphEN objge_StructureGraphEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsge_StructureGraphBL.ge_StructureGraphDA.UpdateBySqlWithConditionTransaction(objge_StructureGraphEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureGraphBL.ReFreshCache(objge_StructureGraphEN.CourseId);

if (clsge_StructureGraphBL.relatedActions != null)
{
clsge_StructureGraphBL.relatedActions.UpdRelaTabDate(objge_StructureGraphEN.StructureGraphId, "SetUpdDate");
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
 /// <param name = "strStructureGraphId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsge_StructureGraphEN objge_StructureGraphEN)
{
try
{
int intRecNum = clsge_StructureGraphBL.ge_StructureGraphDA.DelRecord(objge_StructureGraphEN.StructureGraphId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureGraphBL.ReFreshCache(objge_StructureGraphEN.CourseId);

if (clsge_StructureGraphBL.relatedActions != null)
{
clsge_StructureGraphBL.relatedActions.UpdRelaTabDate(objge_StructureGraphEN.StructureGraphId, "SetUpdDate");
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
 /// <param name = "objge_StructureGraphENS">源对象</param>
 /// <param name = "objge_StructureGraphENT">目标对象</param>
 public static void CopyTo(this clsge_StructureGraphEN objge_StructureGraphENS, clsge_StructureGraphEN objge_StructureGraphENT)
{
try
{
objge_StructureGraphENT.StructureGraphId = objge_StructureGraphENS.StructureGraphId; //知识图谱Id
objge_StructureGraphENT.StructureGraphName = objge_StructureGraphENS.StructureGraphName; //结构图谱名称
objge_StructureGraphENT.IdCurrEduCls = objge_StructureGraphENS.IdCurrEduCls; //教学班流水号
objge_StructureGraphENT.CourseId = objge_StructureGraphENS.CourseId; //课程Id
objge_StructureGraphENT.CreateUser = objge_StructureGraphENS.CreateUser; //建立用户
objge_StructureGraphENT.UpdDate = objge_StructureGraphENS.UpdDate; //修改日期
objge_StructureGraphENT.UpdUser = objge_StructureGraphENS.UpdUser; //修改人
objge_StructureGraphENT.Memo = objge_StructureGraphENS.Memo; //备注
objge_StructureGraphENT.GraphTypeId = objge_StructureGraphENS.GraphTypeId; //图谱类型Id
objge_StructureGraphENT.IsDisplay = objge_StructureGraphENS.IsDisplay; //是否显示
objge_StructureGraphENT.IsExtend = objge_StructureGraphENS.IsExtend; //是否扩展
objge_StructureGraphENT.IsRecommend = objge_StructureGraphENS.IsRecommend; //是否推荐
objge_StructureGraphENT.Theme = objge_StructureGraphENS.Theme; //主题
objge_StructureGraphENT.IsSubmit = objge_StructureGraphENS.IsSubmit; //是否提交
objge_StructureGraphENT.SectionTypeId = objge_StructureGraphENS.SectionTypeId; //节点类型Id
objge_StructureGraphENT.TakeUpTime = objge_StructureGraphENS.TakeUpTime; //耗时
objge_StructureGraphENT.StartTime = objge_StructureGraphENS.StartTime; //开始时间
objge_StructureGraphENT.SubmitTime = objge_StructureGraphENS.SubmitTime; //提交时间
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
 /// <param name = "objge_StructureGraphENS">源对象</param>
 /// <returns>目标对象=>clsge_StructureGraphEN:objge_StructureGraphENT</returns>
 public static clsge_StructureGraphEN CopyTo(this clsge_StructureGraphEN objge_StructureGraphENS)
{
try
{
 clsge_StructureGraphEN objge_StructureGraphENT = new clsge_StructureGraphEN()
{
StructureGraphId = objge_StructureGraphENS.StructureGraphId, //知识图谱Id
StructureGraphName = objge_StructureGraphENS.StructureGraphName, //结构图谱名称
IdCurrEduCls = objge_StructureGraphENS.IdCurrEduCls, //教学班流水号
CourseId = objge_StructureGraphENS.CourseId, //课程Id
CreateUser = objge_StructureGraphENS.CreateUser, //建立用户
UpdDate = objge_StructureGraphENS.UpdDate, //修改日期
UpdUser = objge_StructureGraphENS.UpdUser, //修改人
Memo = objge_StructureGraphENS.Memo, //备注
GraphTypeId = objge_StructureGraphENS.GraphTypeId, //图谱类型Id
IsDisplay = objge_StructureGraphENS.IsDisplay, //是否显示
IsExtend = objge_StructureGraphENS.IsExtend, //是否扩展
IsRecommend = objge_StructureGraphENS.IsRecommend, //是否推荐
Theme = objge_StructureGraphENS.Theme, //主题
IsSubmit = objge_StructureGraphENS.IsSubmit, //是否提交
SectionTypeId = objge_StructureGraphENS.SectionTypeId, //节点类型Id
TakeUpTime = objge_StructureGraphENS.TakeUpTime, //耗时
StartTime = objge_StructureGraphENS.StartTime, //开始时间
SubmitTime = objge_StructureGraphENS.SubmitTime, //提交时间
};
 return objge_StructureGraphENT;
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
public static void CheckPropertyNew(this clsge_StructureGraphEN objge_StructureGraphEN)
{
 clsge_StructureGraphBL.ge_StructureGraphDA.CheckPropertyNew(objge_StructureGraphEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsge_StructureGraphEN objge_StructureGraphEN)
{
 clsge_StructureGraphBL.ge_StructureGraphDA.CheckProperty4Condition(objge_StructureGraphEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsge_StructureGraphEN objge_StructureGraphCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objge_StructureGraphCond.IsUpdated(conge_StructureGraph.StructureGraphId) == true)
{
string strComparisonOpStructureGraphId = objge_StructureGraphCond.dicFldComparisonOp[conge_StructureGraph.StructureGraphId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StructureGraph.StructureGraphId, objge_StructureGraphCond.StructureGraphId, strComparisonOpStructureGraphId);
}
if (objge_StructureGraphCond.IsUpdated(conge_StructureGraph.StructureGraphName) == true)
{
string strComparisonOpStructureGraphName = objge_StructureGraphCond.dicFldComparisonOp[conge_StructureGraph.StructureGraphName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StructureGraph.StructureGraphName, objge_StructureGraphCond.StructureGraphName, strComparisonOpStructureGraphName);
}
if (objge_StructureGraphCond.IsUpdated(conge_StructureGraph.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objge_StructureGraphCond.dicFldComparisonOp[conge_StructureGraph.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StructureGraph.IdCurrEduCls, objge_StructureGraphCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objge_StructureGraphCond.IsUpdated(conge_StructureGraph.CourseId) == true)
{
string strComparisonOpCourseId = objge_StructureGraphCond.dicFldComparisonOp[conge_StructureGraph.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StructureGraph.CourseId, objge_StructureGraphCond.CourseId, strComparisonOpCourseId);
}
if (objge_StructureGraphCond.IsUpdated(conge_StructureGraph.CreateUser) == true)
{
string strComparisonOpCreateUser = objge_StructureGraphCond.dicFldComparisonOp[conge_StructureGraph.CreateUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StructureGraph.CreateUser, objge_StructureGraphCond.CreateUser, strComparisonOpCreateUser);
}
if (objge_StructureGraphCond.IsUpdated(conge_StructureGraph.UpdDate) == true)
{
string strComparisonOpUpdDate = objge_StructureGraphCond.dicFldComparisonOp[conge_StructureGraph.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StructureGraph.UpdDate, objge_StructureGraphCond.UpdDate, strComparisonOpUpdDate);
}
if (objge_StructureGraphCond.IsUpdated(conge_StructureGraph.UpdUser) == true)
{
string strComparisonOpUpdUser = objge_StructureGraphCond.dicFldComparisonOp[conge_StructureGraph.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StructureGraph.UpdUser, objge_StructureGraphCond.UpdUser, strComparisonOpUpdUser);
}
if (objge_StructureGraphCond.IsUpdated(conge_StructureGraph.Memo) == true)
{
string strComparisonOpMemo = objge_StructureGraphCond.dicFldComparisonOp[conge_StructureGraph.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StructureGraph.Memo, objge_StructureGraphCond.Memo, strComparisonOpMemo);
}
if (objge_StructureGraphCond.IsUpdated(conge_StructureGraph.GraphTypeId) == true)
{
string strComparisonOpGraphTypeId = objge_StructureGraphCond.dicFldComparisonOp[conge_StructureGraph.GraphTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StructureGraph.GraphTypeId, objge_StructureGraphCond.GraphTypeId, strComparisonOpGraphTypeId);
}
if (objge_StructureGraphCond.IsUpdated(conge_StructureGraph.IsDisplay) == true)
{
if (objge_StructureGraphCond.IsDisplay == true)
{
strWhereCond += string.Format(" And {0} = '1'", conge_StructureGraph.IsDisplay);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conge_StructureGraph.IsDisplay);
}
}
if (objge_StructureGraphCond.IsUpdated(conge_StructureGraph.IsExtend) == true)
{
if (objge_StructureGraphCond.IsExtend == true)
{
strWhereCond += string.Format(" And {0} = '1'", conge_StructureGraph.IsExtend);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conge_StructureGraph.IsExtend);
}
}
if (objge_StructureGraphCond.IsUpdated(conge_StructureGraph.IsRecommend) == true)
{
if (objge_StructureGraphCond.IsRecommend == true)
{
strWhereCond += string.Format(" And {0} = '1'", conge_StructureGraph.IsRecommend);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conge_StructureGraph.IsRecommend);
}
}
if (objge_StructureGraphCond.IsUpdated(conge_StructureGraph.Theme) == true)
{
string strComparisonOpTheme = objge_StructureGraphCond.dicFldComparisonOp[conge_StructureGraph.Theme];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StructureGraph.Theme, objge_StructureGraphCond.Theme, strComparisonOpTheme);
}
if (objge_StructureGraphCond.IsUpdated(conge_StructureGraph.IsSubmit) == true)
{
if (objge_StructureGraphCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", conge_StructureGraph.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conge_StructureGraph.IsSubmit);
}
}
if (objge_StructureGraphCond.IsUpdated(conge_StructureGraph.SectionTypeId) == true)
{
string strComparisonOpSectionTypeId = objge_StructureGraphCond.dicFldComparisonOp[conge_StructureGraph.SectionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StructureGraph.SectionTypeId, objge_StructureGraphCond.SectionTypeId, strComparisonOpSectionTypeId);
}
if (objge_StructureGraphCond.IsUpdated(conge_StructureGraph.TakeUpTime) == true)
{
string strComparisonOpTakeUpTime = objge_StructureGraphCond.dicFldComparisonOp[conge_StructureGraph.TakeUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StructureGraph.TakeUpTime, objge_StructureGraphCond.TakeUpTime, strComparisonOpTakeUpTime);
}
if (objge_StructureGraphCond.IsUpdated(conge_StructureGraph.StartTime) == true)
{
string strComparisonOpStartTime = objge_StructureGraphCond.dicFldComparisonOp[conge_StructureGraph.StartTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StructureGraph.StartTime, objge_StructureGraphCond.StartTime, strComparisonOpStartTime);
}
if (objge_StructureGraphCond.IsUpdated(conge_StructureGraph.SubmitTime) == true)
{
string strComparisonOpSubmitTime = objge_StructureGraphCond.dicFldComparisonOp[conge_StructureGraph.SubmitTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StructureGraph.SubmitTime, objge_StructureGraphCond.SubmitTime, strComparisonOpSubmitTime);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--ge_StructureGraph(结构图谱表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:StructureGraphId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objge_StructureGraphEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsge_StructureGraphEN objge_StructureGraphEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objge_StructureGraphEN == null) return true;
if (objge_StructureGraphEN.StructureGraphId == null || objge_StructureGraphEN.StructureGraphId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and StructureGraphId = '{0}'", objge_StructureGraphEN.StructureGraphId);
if (clsge_StructureGraphBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("StructureGraphId !=  '{0}'", objge_StructureGraphEN.StructureGraphId);
 sbCondition.AppendFormat(" and StructureGraphId = '{0}'", objge_StructureGraphEN.StructureGraphId);
if (clsge_StructureGraphBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--ge_StructureGraph(结构图谱表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:StructureGraphId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objge_StructureGraphEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsge_StructureGraphEN objge_StructureGraphEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objge_StructureGraphEN == null) return "";
if (objge_StructureGraphEN.StructureGraphId == null || objge_StructureGraphEN.StructureGraphId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and StructureGraphId = '{0}'", objge_StructureGraphEN.StructureGraphId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("StructureGraphId !=  '{0}'", objge_StructureGraphEN.StructureGraphId);
 sbCondition.AppendFormat(" and StructureGraphId = '{0}'", objge_StructureGraphEN.StructureGraphId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ge_StructureGraph
{
public virtual bool UpdRelaTabDate(string strStructureGraphId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 结构图谱表(ge_StructureGraph)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsge_StructureGraphBL
{
public static RelatedActions_ge_StructureGraph relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsge_StructureGraphDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsge_StructureGraphDA ge_StructureGraphDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsge_StructureGraphDA();
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
 public clsge_StructureGraphBL()
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
if (string.IsNullOrEmpty(clsge_StructureGraphEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsge_StructureGraphEN._ConnectString);
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
public static DataTable GetDataTable_ge_StructureGraph(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ge_StructureGraphDA.GetDataTable_ge_StructureGraph(strWhereCond);
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
objDT = ge_StructureGraphDA.GetDataTable(strWhereCond);
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
objDT = ge_StructureGraphDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ge_StructureGraphDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ge_StructureGraphDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ge_StructureGraphDA.GetDataTable_Top(objTopPara);
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
objDT = ge_StructureGraphDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ge_StructureGraphDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ge_StructureGraphDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrStructureGraphIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsge_StructureGraphEN> GetObjLstByStructureGraphIdLst(List<string> arrStructureGraphIdLst)
{
List<clsge_StructureGraphEN> arrObjLst = new List<clsge_StructureGraphEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrStructureGraphIdLst, true);
 string strWhereCond = string.Format("StructureGraphId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StructureGraphEN objge_StructureGraphEN = new clsge_StructureGraphEN();
try
{
objge_StructureGraphEN.StructureGraphId = objRow[conge_StructureGraph.StructureGraphId].ToString().Trim(); //知识图谱Id
objge_StructureGraphEN.StructureGraphName = objRow[conge_StructureGraph.StructureGraphName] == DBNull.Value ? null : objRow[conge_StructureGraph.StructureGraphName].ToString().Trim(); //结构图谱名称
objge_StructureGraphEN.IdCurrEduCls = objRow[conge_StructureGraph.IdCurrEduCls] == DBNull.Value ? null : objRow[conge_StructureGraph.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_StructureGraphEN.CourseId = objRow[conge_StructureGraph.CourseId] == DBNull.Value ? null : objRow[conge_StructureGraph.CourseId].ToString().Trim(); //课程Id
objge_StructureGraphEN.CreateUser = objRow[conge_StructureGraph.CreateUser] == DBNull.Value ? null : objRow[conge_StructureGraph.CreateUser].ToString().Trim(); //建立用户
objge_StructureGraphEN.UpdDate = objRow[conge_StructureGraph.UpdDate] == DBNull.Value ? null : objRow[conge_StructureGraph.UpdDate].ToString().Trim(); //修改日期
objge_StructureGraphEN.UpdUser = objRow[conge_StructureGraph.UpdUser] == DBNull.Value ? null : objRow[conge_StructureGraph.UpdUser].ToString().Trim(); //修改人
objge_StructureGraphEN.Memo = objRow[conge_StructureGraph.Memo] == DBNull.Value ? null : objRow[conge_StructureGraph.Memo].ToString().Trim(); //备注
objge_StructureGraphEN.GraphTypeId = objRow[conge_StructureGraph.GraphTypeId] == DBNull.Value ? null : objRow[conge_StructureGraph.GraphTypeId].ToString().Trim(); //图谱类型Id
objge_StructureGraphEN.IsDisplay = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureGraph.IsDisplay].ToString().Trim()); //是否显示
objge_StructureGraphEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureGraph.IsExtend].ToString().Trim()); //是否扩展
objge_StructureGraphEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureGraph.IsRecommend].ToString().Trim()); //是否推荐
objge_StructureGraphEN.Theme = objRow[conge_StructureGraph.Theme] == DBNull.Value ? null : objRow[conge_StructureGraph.Theme].ToString().Trim(); //主题
objge_StructureGraphEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureGraph.IsSubmit].ToString().Trim()); //是否提交
objge_StructureGraphEN.SectionTypeId = objRow[conge_StructureGraph.SectionTypeId].ToString().Trim(); //节点类型Id
objge_StructureGraphEN.TakeUpTime = objRow[conge_StructureGraph.TakeUpTime] == DBNull.Value ? null : objRow[conge_StructureGraph.TakeUpTime].ToString().Trim(); //耗时
objge_StructureGraphEN.StartTime = objRow[conge_StructureGraph.StartTime] == DBNull.Value ? null : objRow[conge_StructureGraph.StartTime].ToString().Trim(); //开始时间
objge_StructureGraphEN.SubmitTime = objRow[conge_StructureGraph.SubmitTime] == DBNull.Value ? null : objRow[conge_StructureGraph.SubmitTime].ToString().Trim(); //提交时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StructureGraphEN.StructureGraphId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StructureGraphEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrStructureGraphIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsge_StructureGraphEN> GetObjLstByStructureGraphIdLstCache(List<string> arrStructureGraphIdLst, string strCourseId)
{
string strKey = string.Format("{0}_{1}", clsge_StructureGraphEN._CurrTabName, strCourseId);
List<clsge_StructureGraphEN> arrge_StructureGraphObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsge_StructureGraphEN> arrge_StructureGraphObjLst_Sel =
arrge_StructureGraphObjLstCache
.Where(x => arrStructureGraphIdLst.Contains(x.StructureGraphId));
return arrge_StructureGraphObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_StructureGraphEN> GetObjLst(string strWhereCond)
{
List<clsge_StructureGraphEN> arrObjLst = new List<clsge_StructureGraphEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StructureGraphEN objge_StructureGraphEN = new clsge_StructureGraphEN();
try
{
objge_StructureGraphEN.StructureGraphId = objRow[conge_StructureGraph.StructureGraphId].ToString().Trim(); //知识图谱Id
objge_StructureGraphEN.StructureGraphName = objRow[conge_StructureGraph.StructureGraphName] == DBNull.Value ? null : objRow[conge_StructureGraph.StructureGraphName].ToString().Trim(); //结构图谱名称
objge_StructureGraphEN.IdCurrEduCls = objRow[conge_StructureGraph.IdCurrEduCls] == DBNull.Value ? null : objRow[conge_StructureGraph.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_StructureGraphEN.CourseId = objRow[conge_StructureGraph.CourseId] == DBNull.Value ? null : objRow[conge_StructureGraph.CourseId].ToString().Trim(); //课程Id
objge_StructureGraphEN.CreateUser = objRow[conge_StructureGraph.CreateUser] == DBNull.Value ? null : objRow[conge_StructureGraph.CreateUser].ToString().Trim(); //建立用户
objge_StructureGraphEN.UpdDate = objRow[conge_StructureGraph.UpdDate] == DBNull.Value ? null : objRow[conge_StructureGraph.UpdDate].ToString().Trim(); //修改日期
objge_StructureGraphEN.UpdUser = objRow[conge_StructureGraph.UpdUser] == DBNull.Value ? null : objRow[conge_StructureGraph.UpdUser].ToString().Trim(); //修改人
objge_StructureGraphEN.Memo = objRow[conge_StructureGraph.Memo] == DBNull.Value ? null : objRow[conge_StructureGraph.Memo].ToString().Trim(); //备注
objge_StructureGraphEN.GraphTypeId = objRow[conge_StructureGraph.GraphTypeId] == DBNull.Value ? null : objRow[conge_StructureGraph.GraphTypeId].ToString().Trim(); //图谱类型Id
objge_StructureGraphEN.IsDisplay = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureGraph.IsDisplay].ToString().Trim()); //是否显示
objge_StructureGraphEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureGraph.IsExtend].ToString().Trim()); //是否扩展
objge_StructureGraphEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureGraph.IsRecommend].ToString().Trim()); //是否推荐
objge_StructureGraphEN.Theme = objRow[conge_StructureGraph.Theme] == DBNull.Value ? null : objRow[conge_StructureGraph.Theme].ToString().Trim(); //主题
objge_StructureGraphEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureGraph.IsSubmit].ToString().Trim()); //是否提交
objge_StructureGraphEN.SectionTypeId = objRow[conge_StructureGraph.SectionTypeId].ToString().Trim(); //节点类型Id
objge_StructureGraphEN.TakeUpTime = objRow[conge_StructureGraph.TakeUpTime] == DBNull.Value ? null : objRow[conge_StructureGraph.TakeUpTime].ToString().Trim(); //耗时
objge_StructureGraphEN.StartTime = objRow[conge_StructureGraph.StartTime] == DBNull.Value ? null : objRow[conge_StructureGraph.StartTime].ToString().Trim(); //开始时间
objge_StructureGraphEN.SubmitTime = objRow[conge_StructureGraph.SubmitTime] == DBNull.Value ? null : objRow[conge_StructureGraph.SubmitTime].ToString().Trim(); //提交时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StructureGraphEN.StructureGraphId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StructureGraphEN);
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
public static List<clsge_StructureGraphEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsge_StructureGraphEN> arrObjLst = new List<clsge_StructureGraphEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StructureGraphEN objge_StructureGraphEN = new clsge_StructureGraphEN();
try
{
objge_StructureGraphEN.StructureGraphId = objRow[conge_StructureGraph.StructureGraphId].ToString().Trim(); //知识图谱Id
objge_StructureGraphEN.StructureGraphName = objRow[conge_StructureGraph.StructureGraphName] == DBNull.Value ? null : objRow[conge_StructureGraph.StructureGraphName].ToString().Trim(); //结构图谱名称
objge_StructureGraphEN.IdCurrEduCls = objRow[conge_StructureGraph.IdCurrEduCls] == DBNull.Value ? null : objRow[conge_StructureGraph.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_StructureGraphEN.CourseId = objRow[conge_StructureGraph.CourseId] == DBNull.Value ? null : objRow[conge_StructureGraph.CourseId].ToString().Trim(); //课程Id
objge_StructureGraphEN.CreateUser = objRow[conge_StructureGraph.CreateUser] == DBNull.Value ? null : objRow[conge_StructureGraph.CreateUser].ToString().Trim(); //建立用户
objge_StructureGraphEN.UpdDate = objRow[conge_StructureGraph.UpdDate] == DBNull.Value ? null : objRow[conge_StructureGraph.UpdDate].ToString().Trim(); //修改日期
objge_StructureGraphEN.UpdUser = objRow[conge_StructureGraph.UpdUser] == DBNull.Value ? null : objRow[conge_StructureGraph.UpdUser].ToString().Trim(); //修改人
objge_StructureGraphEN.Memo = objRow[conge_StructureGraph.Memo] == DBNull.Value ? null : objRow[conge_StructureGraph.Memo].ToString().Trim(); //备注
objge_StructureGraphEN.GraphTypeId = objRow[conge_StructureGraph.GraphTypeId] == DBNull.Value ? null : objRow[conge_StructureGraph.GraphTypeId].ToString().Trim(); //图谱类型Id
objge_StructureGraphEN.IsDisplay = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureGraph.IsDisplay].ToString().Trim()); //是否显示
objge_StructureGraphEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureGraph.IsExtend].ToString().Trim()); //是否扩展
objge_StructureGraphEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureGraph.IsRecommend].ToString().Trim()); //是否推荐
objge_StructureGraphEN.Theme = objRow[conge_StructureGraph.Theme] == DBNull.Value ? null : objRow[conge_StructureGraph.Theme].ToString().Trim(); //主题
objge_StructureGraphEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureGraph.IsSubmit].ToString().Trim()); //是否提交
objge_StructureGraphEN.SectionTypeId = objRow[conge_StructureGraph.SectionTypeId].ToString().Trim(); //节点类型Id
objge_StructureGraphEN.TakeUpTime = objRow[conge_StructureGraph.TakeUpTime] == DBNull.Value ? null : objRow[conge_StructureGraph.TakeUpTime].ToString().Trim(); //耗时
objge_StructureGraphEN.StartTime = objRow[conge_StructureGraph.StartTime] == DBNull.Value ? null : objRow[conge_StructureGraph.StartTime].ToString().Trim(); //开始时间
objge_StructureGraphEN.SubmitTime = objRow[conge_StructureGraph.SubmitTime] == DBNull.Value ? null : objRow[conge_StructureGraph.SubmitTime].ToString().Trim(); //提交时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StructureGraphEN.StructureGraphId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StructureGraphEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objge_StructureGraphCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsge_StructureGraphEN> GetSubObjLstCache(clsge_StructureGraphEN objge_StructureGraphCond)
{
 string strCourseId = objge_StructureGraphCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsge_StructureGraphBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsge_StructureGraphEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsge_StructureGraphEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conge_StructureGraph.AttributeName)
{
if (objge_StructureGraphCond.IsUpdated(strFldName) == false) continue;
if (objge_StructureGraphCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_StructureGraphCond[strFldName].ToString());
}
else
{
if (objge_StructureGraphCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objge_StructureGraphCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_StructureGraphCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objge_StructureGraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objge_StructureGraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objge_StructureGraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objge_StructureGraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objge_StructureGraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objge_StructureGraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objge_StructureGraphCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objge_StructureGraphCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objge_StructureGraphCond[strFldName]));
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
public static List<clsge_StructureGraphEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsge_StructureGraphEN> arrObjLst = new List<clsge_StructureGraphEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StructureGraphEN objge_StructureGraphEN = new clsge_StructureGraphEN();
try
{
objge_StructureGraphEN.StructureGraphId = objRow[conge_StructureGraph.StructureGraphId].ToString().Trim(); //知识图谱Id
objge_StructureGraphEN.StructureGraphName = objRow[conge_StructureGraph.StructureGraphName] == DBNull.Value ? null : objRow[conge_StructureGraph.StructureGraphName].ToString().Trim(); //结构图谱名称
objge_StructureGraphEN.IdCurrEduCls = objRow[conge_StructureGraph.IdCurrEduCls] == DBNull.Value ? null : objRow[conge_StructureGraph.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_StructureGraphEN.CourseId = objRow[conge_StructureGraph.CourseId] == DBNull.Value ? null : objRow[conge_StructureGraph.CourseId].ToString().Trim(); //课程Id
objge_StructureGraphEN.CreateUser = objRow[conge_StructureGraph.CreateUser] == DBNull.Value ? null : objRow[conge_StructureGraph.CreateUser].ToString().Trim(); //建立用户
objge_StructureGraphEN.UpdDate = objRow[conge_StructureGraph.UpdDate] == DBNull.Value ? null : objRow[conge_StructureGraph.UpdDate].ToString().Trim(); //修改日期
objge_StructureGraphEN.UpdUser = objRow[conge_StructureGraph.UpdUser] == DBNull.Value ? null : objRow[conge_StructureGraph.UpdUser].ToString().Trim(); //修改人
objge_StructureGraphEN.Memo = objRow[conge_StructureGraph.Memo] == DBNull.Value ? null : objRow[conge_StructureGraph.Memo].ToString().Trim(); //备注
objge_StructureGraphEN.GraphTypeId = objRow[conge_StructureGraph.GraphTypeId] == DBNull.Value ? null : objRow[conge_StructureGraph.GraphTypeId].ToString().Trim(); //图谱类型Id
objge_StructureGraphEN.IsDisplay = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureGraph.IsDisplay].ToString().Trim()); //是否显示
objge_StructureGraphEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureGraph.IsExtend].ToString().Trim()); //是否扩展
objge_StructureGraphEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureGraph.IsRecommend].ToString().Trim()); //是否推荐
objge_StructureGraphEN.Theme = objRow[conge_StructureGraph.Theme] == DBNull.Value ? null : objRow[conge_StructureGraph.Theme].ToString().Trim(); //主题
objge_StructureGraphEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureGraph.IsSubmit].ToString().Trim()); //是否提交
objge_StructureGraphEN.SectionTypeId = objRow[conge_StructureGraph.SectionTypeId].ToString().Trim(); //节点类型Id
objge_StructureGraphEN.TakeUpTime = objRow[conge_StructureGraph.TakeUpTime] == DBNull.Value ? null : objRow[conge_StructureGraph.TakeUpTime].ToString().Trim(); //耗时
objge_StructureGraphEN.StartTime = objRow[conge_StructureGraph.StartTime] == DBNull.Value ? null : objRow[conge_StructureGraph.StartTime].ToString().Trim(); //开始时间
objge_StructureGraphEN.SubmitTime = objRow[conge_StructureGraph.SubmitTime] == DBNull.Value ? null : objRow[conge_StructureGraph.SubmitTime].ToString().Trim(); //提交时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StructureGraphEN.StructureGraphId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StructureGraphEN);
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
public static List<clsge_StructureGraphEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsge_StructureGraphEN> arrObjLst = new List<clsge_StructureGraphEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StructureGraphEN objge_StructureGraphEN = new clsge_StructureGraphEN();
try
{
objge_StructureGraphEN.StructureGraphId = objRow[conge_StructureGraph.StructureGraphId].ToString().Trim(); //知识图谱Id
objge_StructureGraphEN.StructureGraphName = objRow[conge_StructureGraph.StructureGraphName] == DBNull.Value ? null : objRow[conge_StructureGraph.StructureGraphName].ToString().Trim(); //结构图谱名称
objge_StructureGraphEN.IdCurrEduCls = objRow[conge_StructureGraph.IdCurrEduCls] == DBNull.Value ? null : objRow[conge_StructureGraph.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_StructureGraphEN.CourseId = objRow[conge_StructureGraph.CourseId] == DBNull.Value ? null : objRow[conge_StructureGraph.CourseId].ToString().Trim(); //课程Id
objge_StructureGraphEN.CreateUser = objRow[conge_StructureGraph.CreateUser] == DBNull.Value ? null : objRow[conge_StructureGraph.CreateUser].ToString().Trim(); //建立用户
objge_StructureGraphEN.UpdDate = objRow[conge_StructureGraph.UpdDate] == DBNull.Value ? null : objRow[conge_StructureGraph.UpdDate].ToString().Trim(); //修改日期
objge_StructureGraphEN.UpdUser = objRow[conge_StructureGraph.UpdUser] == DBNull.Value ? null : objRow[conge_StructureGraph.UpdUser].ToString().Trim(); //修改人
objge_StructureGraphEN.Memo = objRow[conge_StructureGraph.Memo] == DBNull.Value ? null : objRow[conge_StructureGraph.Memo].ToString().Trim(); //备注
objge_StructureGraphEN.GraphTypeId = objRow[conge_StructureGraph.GraphTypeId] == DBNull.Value ? null : objRow[conge_StructureGraph.GraphTypeId].ToString().Trim(); //图谱类型Id
objge_StructureGraphEN.IsDisplay = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureGraph.IsDisplay].ToString().Trim()); //是否显示
objge_StructureGraphEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureGraph.IsExtend].ToString().Trim()); //是否扩展
objge_StructureGraphEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureGraph.IsRecommend].ToString().Trim()); //是否推荐
objge_StructureGraphEN.Theme = objRow[conge_StructureGraph.Theme] == DBNull.Value ? null : objRow[conge_StructureGraph.Theme].ToString().Trim(); //主题
objge_StructureGraphEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureGraph.IsSubmit].ToString().Trim()); //是否提交
objge_StructureGraphEN.SectionTypeId = objRow[conge_StructureGraph.SectionTypeId].ToString().Trim(); //节点类型Id
objge_StructureGraphEN.TakeUpTime = objRow[conge_StructureGraph.TakeUpTime] == DBNull.Value ? null : objRow[conge_StructureGraph.TakeUpTime].ToString().Trim(); //耗时
objge_StructureGraphEN.StartTime = objRow[conge_StructureGraph.StartTime] == DBNull.Value ? null : objRow[conge_StructureGraph.StartTime].ToString().Trim(); //开始时间
objge_StructureGraphEN.SubmitTime = objRow[conge_StructureGraph.SubmitTime] == DBNull.Value ? null : objRow[conge_StructureGraph.SubmitTime].ToString().Trim(); //提交时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StructureGraphEN.StructureGraphId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StructureGraphEN);
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
List<clsge_StructureGraphEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsge_StructureGraphEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_StructureGraphEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsge_StructureGraphEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsge_StructureGraphEN> arrObjLst = new List<clsge_StructureGraphEN>(); 
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
	clsge_StructureGraphEN objge_StructureGraphEN = new clsge_StructureGraphEN();
try
{
objge_StructureGraphEN.StructureGraphId = objRow[conge_StructureGraph.StructureGraphId].ToString().Trim(); //知识图谱Id
objge_StructureGraphEN.StructureGraphName = objRow[conge_StructureGraph.StructureGraphName] == DBNull.Value ? null : objRow[conge_StructureGraph.StructureGraphName].ToString().Trim(); //结构图谱名称
objge_StructureGraphEN.IdCurrEduCls = objRow[conge_StructureGraph.IdCurrEduCls] == DBNull.Value ? null : objRow[conge_StructureGraph.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_StructureGraphEN.CourseId = objRow[conge_StructureGraph.CourseId] == DBNull.Value ? null : objRow[conge_StructureGraph.CourseId].ToString().Trim(); //课程Id
objge_StructureGraphEN.CreateUser = objRow[conge_StructureGraph.CreateUser] == DBNull.Value ? null : objRow[conge_StructureGraph.CreateUser].ToString().Trim(); //建立用户
objge_StructureGraphEN.UpdDate = objRow[conge_StructureGraph.UpdDate] == DBNull.Value ? null : objRow[conge_StructureGraph.UpdDate].ToString().Trim(); //修改日期
objge_StructureGraphEN.UpdUser = objRow[conge_StructureGraph.UpdUser] == DBNull.Value ? null : objRow[conge_StructureGraph.UpdUser].ToString().Trim(); //修改人
objge_StructureGraphEN.Memo = objRow[conge_StructureGraph.Memo] == DBNull.Value ? null : objRow[conge_StructureGraph.Memo].ToString().Trim(); //备注
objge_StructureGraphEN.GraphTypeId = objRow[conge_StructureGraph.GraphTypeId] == DBNull.Value ? null : objRow[conge_StructureGraph.GraphTypeId].ToString().Trim(); //图谱类型Id
objge_StructureGraphEN.IsDisplay = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureGraph.IsDisplay].ToString().Trim()); //是否显示
objge_StructureGraphEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureGraph.IsExtend].ToString().Trim()); //是否扩展
objge_StructureGraphEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureGraph.IsRecommend].ToString().Trim()); //是否推荐
objge_StructureGraphEN.Theme = objRow[conge_StructureGraph.Theme] == DBNull.Value ? null : objRow[conge_StructureGraph.Theme].ToString().Trim(); //主题
objge_StructureGraphEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureGraph.IsSubmit].ToString().Trim()); //是否提交
objge_StructureGraphEN.SectionTypeId = objRow[conge_StructureGraph.SectionTypeId].ToString().Trim(); //节点类型Id
objge_StructureGraphEN.TakeUpTime = objRow[conge_StructureGraph.TakeUpTime] == DBNull.Value ? null : objRow[conge_StructureGraph.TakeUpTime].ToString().Trim(); //耗时
objge_StructureGraphEN.StartTime = objRow[conge_StructureGraph.StartTime] == DBNull.Value ? null : objRow[conge_StructureGraph.StartTime].ToString().Trim(); //开始时间
objge_StructureGraphEN.SubmitTime = objRow[conge_StructureGraph.SubmitTime] == DBNull.Value ? null : objRow[conge_StructureGraph.SubmitTime].ToString().Trim(); //提交时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StructureGraphEN.StructureGraphId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StructureGraphEN);
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
public static List<clsge_StructureGraphEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsge_StructureGraphEN> arrObjLst = new List<clsge_StructureGraphEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StructureGraphEN objge_StructureGraphEN = new clsge_StructureGraphEN();
try
{
objge_StructureGraphEN.StructureGraphId = objRow[conge_StructureGraph.StructureGraphId].ToString().Trim(); //知识图谱Id
objge_StructureGraphEN.StructureGraphName = objRow[conge_StructureGraph.StructureGraphName] == DBNull.Value ? null : objRow[conge_StructureGraph.StructureGraphName].ToString().Trim(); //结构图谱名称
objge_StructureGraphEN.IdCurrEduCls = objRow[conge_StructureGraph.IdCurrEduCls] == DBNull.Value ? null : objRow[conge_StructureGraph.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_StructureGraphEN.CourseId = objRow[conge_StructureGraph.CourseId] == DBNull.Value ? null : objRow[conge_StructureGraph.CourseId].ToString().Trim(); //课程Id
objge_StructureGraphEN.CreateUser = objRow[conge_StructureGraph.CreateUser] == DBNull.Value ? null : objRow[conge_StructureGraph.CreateUser].ToString().Trim(); //建立用户
objge_StructureGraphEN.UpdDate = objRow[conge_StructureGraph.UpdDate] == DBNull.Value ? null : objRow[conge_StructureGraph.UpdDate].ToString().Trim(); //修改日期
objge_StructureGraphEN.UpdUser = objRow[conge_StructureGraph.UpdUser] == DBNull.Value ? null : objRow[conge_StructureGraph.UpdUser].ToString().Trim(); //修改人
objge_StructureGraphEN.Memo = objRow[conge_StructureGraph.Memo] == DBNull.Value ? null : objRow[conge_StructureGraph.Memo].ToString().Trim(); //备注
objge_StructureGraphEN.GraphTypeId = objRow[conge_StructureGraph.GraphTypeId] == DBNull.Value ? null : objRow[conge_StructureGraph.GraphTypeId].ToString().Trim(); //图谱类型Id
objge_StructureGraphEN.IsDisplay = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureGraph.IsDisplay].ToString().Trim()); //是否显示
objge_StructureGraphEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureGraph.IsExtend].ToString().Trim()); //是否扩展
objge_StructureGraphEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureGraph.IsRecommend].ToString().Trim()); //是否推荐
objge_StructureGraphEN.Theme = objRow[conge_StructureGraph.Theme] == DBNull.Value ? null : objRow[conge_StructureGraph.Theme].ToString().Trim(); //主题
objge_StructureGraphEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureGraph.IsSubmit].ToString().Trim()); //是否提交
objge_StructureGraphEN.SectionTypeId = objRow[conge_StructureGraph.SectionTypeId].ToString().Trim(); //节点类型Id
objge_StructureGraphEN.TakeUpTime = objRow[conge_StructureGraph.TakeUpTime] == DBNull.Value ? null : objRow[conge_StructureGraph.TakeUpTime].ToString().Trim(); //耗时
objge_StructureGraphEN.StartTime = objRow[conge_StructureGraph.StartTime] == DBNull.Value ? null : objRow[conge_StructureGraph.StartTime].ToString().Trim(); //开始时间
objge_StructureGraphEN.SubmitTime = objRow[conge_StructureGraph.SubmitTime] == DBNull.Value ? null : objRow[conge_StructureGraph.SubmitTime].ToString().Trim(); //提交时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StructureGraphEN.StructureGraphId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StructureGraphEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsge_StructureGraphEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsge_StructureGraphEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsge_StructureGraphEN> arrObjLst = new List<clsge_StructureGraphEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StructureGraphEN objge_StructureGraphEN = new clsge_StructureGraphEN();
try
{
objge_StructureGraphEN.StructureGraphId = objRow[conge_StructureGraph.StructureGraphId].ToString().Trim(); //知识图谱Id
objge_StructureGraphEN.StructureGraphName = objRow[conge_StructureGraph.StructureGraphName] == DBNull.Value ? null : objRow[conge_StructureGraph.StructureGraphName].ToString().Trim(); //结构图谱名称
objge_StructureGraphEN.IdCurrEduCls = objRow[conge_StructureGraph.IdCurrEduCls] == DBNull.Value ? null : objRow[conge_StructureGraph.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_StructureGraphEN.CourseId = objRow[conge_StructureGraph.CourseId] == DBNull.Value ? null : objRow[conge_StructureGraph.CourseId].ToString().Trim(); //课程Id
objge_StructureGraphEN.CreateUser = objRow[conge_StructureGraph.CreateUser] == DBNull.Value ? null : objRow[conge_StructureGraph.CreateUser].ToString().Trim(); //建立用户
objge_StructureGraphEN.UpdDate = objRow[conge_StructureGraph.UpdDate] == DBNull.Value ? null : objRow[conge_StructureGraph.UpdDate].ToString().Trim(); //修改日期
objge_StructureGraphEN.UpdUser = objRow[conge_StructureGraph.UpdUser] == DBNull.Value ? null : objRow[conge_StructureGraph.UpdUser].ToString().Trim(); //修改人
objge_StructureGraphEN.Memo = objRow[conge_StructureGraph.Memo] == DBNull.Value ? null : objRow[conge_StructureGraph.Memo].ToString().Trim(); //备注
objge_StructureGraphEN.GraphTypeId = objRow[conge_StructureGraph.GraphTypeId] == DBNull.Value ? null : objRow[conge_StructureGraph.GraphTypeId].ToString().Trim(); //图谱类型Id
objge_StructureGraphEN.IsDisplay = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureGraph.IsDisplay].ToString().Trim()); //是否显示
objge_StructureGraphEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureGraph.IsExtend].ToString().Trim()); //是否扩展
objge_StructureGraphEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureGraph.IsRecommend].ToString().Trim()); //是否推荐
objge_StructureGraphEN.Theme = objRow[conge_StructureGraph.Theme] == DBNull.Value ? null : objRow[conge_StructureGraph.Theme].ToString().Trim(); //主题
objge_StructureGraphEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureGraph.IsSubmit].ToString().Trim()); //是否提交
objge_StructureGraphEN.SectionTypeId = objRow[conge_StructureGraph.SectionTypeId].ToString().Trim(); //节点类型Id
objge_StructureGraphEN.TakeUpTime = objRow[conge_StructureGraph.TakeUpTime] == DBNull.Value ? null : objRow[conge_StructureGraph.TakeUpTime].ToString().Trim(); //耗时
objge_StructureGraphEN.StartTime = objRow[conge_StructureGraph.StartTime] == DBNull.Value ? null : objRow[conge_StructureGraph.StartTime].ToString().Trim(); //开始时间
objge_StructureGraphEN.SubmitTime = objRow[conge_StructureGraph.SubmitTime] == DBNull.Value ? null : objRow[conge_StructureGraph.SubmitTime].ToString().Trim(); //提交时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StructureGraphEN.StructureGraphId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StructureGraphEN);
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
public static List<clsge_StructureGraphEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsge_StructureGraphEN> arrObjLst = new List<clsge_StructureGraphEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StructureGraphEN objge_StructureGraphEN = new clsge_StructureGraphEN();
try
{
objge_StructureGraphEN.StructureGraphId = objRow[conge_StructureGraph.StructureGraphId].ToString().Trim(); //知识图谱Id
objge_StructureGraphEN.StructureGraphName = objRow[conge_StructureGraph.StructureGraphName] == DBNull.Value ? null : objRow[conge_StructureGraph.StructureGraphName].ToString().Trim(); //结构图谱名称
objge_StructureGraphEN.IdCurrEduCls = objRow[conge_StructureGraph.IdCurrEduCls] == DBNull.Value ? null : objRow[conge_StructureGraph.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_StructureGraphEN.CourseId = objRow[conge_StructureGraph.CourseId] == DBNull.Value ? null : objRow[conge_StructureGraph.CourseId].ToString().Trim(); //课程Id
objge_StructureGraphEN.CreateUser = objRow[conge_StructureGraph.CreateUser] == DBNull.Value ? null : objRow[conge_StructureGraph.CreateUser].ToString().Trim(); //建立用户
objge_StructureGraphEN.UpdDate = objRow[conge_StructureGraph.UpdDate] == DBNull.Value ? null : objRow[conge_StructureGraph.UpdDate].ToString().Trim(); //修改日期
objge_StructureGraphEN.UpdUser = objRow[conge_StructureGraph.UpdUser] == DBNull.Value ? null : objRow[conge_StructureGraph.UpdUser].ToString().Trim(); //修改人
objge_StructureGraphEN.Memo = objRow[conge_StructureGraph.Memo] == DBNull.Value ? null : objRow[conge_StructureGraph.Memo].ToString().Trim(); //备注
objge_StructureGraphEN.GraphTypeId = objRow[conge_StructureGraph.GraphTypeId] == DBNull.Value ? null : objRow[conge_StructureGraph.GraphTypeId].ToString().Trim(); //图谱类型Id
objge_StructureGraphEN.IsDisplay = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureGraph.IsDisplay].ToString().Trim()); //是否显示
objge_StructureGraphEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureGraph.IsExtend].ToString().Trim()); //是否扩展
objge_StructureGraphEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureGraph.IsRecommend].ToString().Trim()); //是否推荐
objge_StructureGraphEN.Theme = objRow[conge_StructureGraph.Theme] == DBNull.Value ? null : objRow[conge_StructureGraph.Theme].ToString().Trim(); //主题
objge_StructureGraphEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureGraph.IsSubmit].ToString().Trim()); //是否提交
objge_StructureGraphEN.SectionTypeId = objRow[conge_StructureGraph.SectionTypeId].ToString().Trim(); //节点类型Id
objge_StructureGraphEN.TakeUpTime = objRow[conge_StructureGraph.TakeUpTime] == DBNull.Value ? null : objRow[conge_StructureGraph.TakeUpTime].ToString().Trim(); //耗时
objge_StructureGraphEN.StartTime = objRow[conge_StructureGraph.StartTime] == DBNull.Value ? null : objRow[conge_StructureGraph.StartTime].ToString().Trim(); //开始时间
objge_StructureGraphEN.SubmitTime = objRow[conge_StructureGraph.SubmitTime] == DBNull.Value ? null : objRow[conge_StructureGraph.SubmitTime].ToString().Trim(); //提交时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StructureGraphEN.StructureGraphId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StructureGraphEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_StructureGraphEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsge_StructureGraphEN> arrObjLst = new List<clsge_StructureGraphEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StructureGraphEN objge_StructureGraphEN = new clsge_StructureGraphEN();
try
{
objge_StructureGraphEN.StructureGraphId = objRow[conge_StructureGraph.StructureGraphId].ToString().Trim(); //知识图谱Id
objge_StructureGraphEN.StructureGraphName = objRow[conge_StructureGraph.StructureGraphName] == DBNull.Value ? null : objRow[conge_StructureGraph.StructureGraphName].ToString().Trim(); //结构图谱名称
objge_StructureGraphEN.IdCurrEduCls = objRow[conge_StructureGraph.IdCurrEduCls] == DBNull.Value ? null : objRow[conge_StructureGraph.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_StructureGraphEN.CourseId = objRow[conge_StructureGraph.CourseId] == DBNull.Value ? null : objRow[conge_StructureGraph.CourseId].ToString().Trim(); //课程Id
objge_StructureGraphEN.CreateUser = objRow[conge_StructureGraph.CreateUser] == DBNull.Value ? null : objRow[conge_StructureGraph.CreateUser].ToString().Trim(); //建立用户
objge_StructureGraphEN.UpdDate = objRow[conge_StructureGraph.UpdDate] == DBNull.Value ? null : objRow[conge_StructureGraph.UpdDate].ToString().Trim(); //修改日期
objge_StructureGraphEN.UpdUser = objRow[conge_StructureGraph.UpdUser] == DBNull.Value ? null : objRow[conge_StructureGraph.UpdUser].ToString().Trim(); //修改人
objge_StructureGraphEN.Memo = objRow[conge_StructureGraph.Memo] == DBNull.Value ? null : objRow[conge_StructureGraph.Memo].ToString().Trim(); //备注
objge_StructureGraphEN.GraphTypeId = objRow[conge_StructureGraph.GraphTypeId] == DBNull.Value ? null : objRow[conge_StructureGraph.GraphTypeId].ToString().Trim(); //图谱类型Id
objge_StructureGraphEN.IsDisplay = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureGraph.IsDisplay].ToString().Trim()); //是否显示
objge_StructureGraphEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureGraph.IsExtend].ToString().Trim()); //是否扩展
objge_StructureGraphEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureGraph.IsRecommend].ToString().Trim()); //是否推荐
objge_StructureGraphEN.Theme = objRow[conge_StructureGraph.Theme] == DBNull.Value ? null : objRow[conge_StructureGraph.Theme].ToString().Trim(); //主题
objge_StructureGraphEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureGraph.IsSubmit].ToString().Trim()); //是否提交
objge_StructureGraphEN.SectionTypeId = objRow[conge_StructureGraph.SectionTypeId].ToString().Trim(); //节点类型Id
objge_StructureGraphEN.TakeUpTime = objRow[conge_StructureGraph.TakeUpTime] == DBNull.Value ? null : objRow[conge_StructureGraph.TakeUpTime].ToString().Trim(); //耗时
objge_StructureGraphEN.StartTime = objRow[conge_StructureGraph.StartTime] == DBNull.Value ? null : objRow[conge_StructureGraph.StartTime].ToString().Trim(); //开始时间
objge_StructureGraphEN.SubmitTime = objRow[conge_StructureGraph.SubmitTime] == DBNull.Value ? null : objRow[conge_StructureGraph.SubmitTime].ToString().Trim(); //提交时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StructureGraphEN.StructureGraphId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StructureGraphEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objge_StructureGraphEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getge_StructureGraph(ref clsge_StructureGraphEN objge_StructureGraphEN)
{
bool bolResult = ge_StructureGraphDA.Getge_StructureGraph(ref objge_StructureGraphEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strStructureGraphId">表关键字</param>
 /// <returns>表对象</returns>
public static clsge_StructureGraphEN GetObjByStructureGraphId(string strStructureGraphId)
{
if (strStructureGraphId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strStructureGraphId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strStructureGraphId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strStructureGraphId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsge_StructureGraphEN objge_StructureGraphEN = ge_StructureGraphDA.GetObjByStructureGraphId(strStructureGraphId);
return objge_StructureGraphEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsge_StructureGraphEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsge_StructureGraphEN objge_StructureGraphEN = ge_StructureGraphDA.GetFirstObj(strWhereCond);
 return objge_StructureGraphEN;
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
public static clsge_StructureGraphEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsge_StructureGraphEN objge_StructureGraphEN = ge_StructureGraphDA.GetObjByDataRow(objRow);
 return objge_StructureGraphEN;
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
public static clsge_StructureGraphEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsge_StructureGraphEN objge_StructureGraphEN = ge_StructureGraphDA.GetObjByDataRow(objRow);
 return objge_StructureGraphEN;
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
 /// <param name = "strStructureGraphId">所给的关键字</param>
 /// <param name = "lstge_StructureGraphObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsge_StructureGraphEN GetObjByStructureGraphIdFromList(string strStructureGraphId, List<clsge_StructureGraphEN> lstge_StructureGraphObjLst)
{
foreach (clsge_StructureGraphEN objge_StructureGraphEN in lstge_StructureGraphObjLst)
{
if (objge_StructureGraphEN.StructureGraphId == strStructureGraphId)
{
return objge_StructureGraphEN;
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
 string strMaxStructureGraphId;
 try
 {
 strMaxStructureGraphId = clsge_StructureGraphDA.GetMaxStrId();
 return strMaxStructureGraphId;
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
 string strStructureGraphId;
 try
 {
 strStructureGraphId = new clsge_StructureGraphDA().GetFirstID(strWhereCond);
 return strStructureGraphId;
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
 arrList = ge_StructureGraphDA.GetID(strWhereCond);
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
bool bolIsExist = ge_StructureGraphDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strStructureGraphId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strStructureGraphId)
{
if (string.IsNullOrEmpty(strStructureGraphId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strStructureGraphId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = ge_StructureGraphDA.IsExist(strStructureGraphId);
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
 bolIsExist = clsge_StructureGraphDA.IsExistTable();
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
 bolIsExist = ge_StructureGraphDA.IsExistTable(strTabName);
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
 /// <param name = "objge_StructureGraphEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsge_StructureGraphEN objge_StructureGraphEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objge_StructureGraphEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!知识图谱Id = [{0}]的数据已经存在!(in clsge_StructureGraphBL.AddNewRecordBySql2)", objge_StructureGraphEN.StructureGraphId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objge_StructureGraphEN.StructureGraphId) == true || clsge_StructureGraphBL.IsExist(objge_StructureGraphEN.StructureGraphId) == true)
 {
     objge_StructureGraphEN.StructureGraphId = clsge_StructureGraphBL.GetMaxStrId_S();
 }
bool bolResult = ge_StructureGraphDA.AddNewRecordBySQL2(objge_StructureGraphEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureGraphBL.ReFreshCache(objge_StructureGraphEN.CourseId);

if (clsge_StructureGraphBL.relatedActions != null)
{
clsge_StructureGraphBL.relatedActions.UpdRelaTabDate(objge_StructureGraphEN.StructureGraphId, "SetUpdDate");
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
 /// <param name = "objge_StructureGraphEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsge_StructureGraphEN objge_StructureGraphEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objge_StructureGraphEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!知识图谱Id = [{0}]的数据已经存在!(in clsge_StructureGraphBL.AddNewRecordBySql2WithReturnKey)", objge_StructureGraphEN.StructureGraphId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objge_StructureGraphEN.StructureGraphId) == true || clsge_StructureGraphBL.IsExist(objge_StructureGraphEN.StructureGraphId) == true)
 {
     objge_StructureGraphEN.StructureGraphId = clsge_StructureGraphBL.GetMaxStrId_S();
 }
string strKey = ge_StructureGraphDA.AddNewRecordBySQL2WithReturnKey(objge_StructureGraphEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureGraphBL.ReFreshCache(objge_StructureGraphEN.CourseId);

if (clsge_StructureGraphBL.relatedActions != null)
{
clsge_StructureGraphBL.relatedActions.UpdRelaTabDate(objge_StructureGraphEN.StructureGraphId, "SetUpdDate");
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
 /// <param name = "objge_StructureGraphEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsge_StructureGraphEN objge_StructureGraphEN)
{
try
{
bool bolResult = ge_StructureGraphDA.Update(objge_StructureGraphEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureGraphBL.ReFreshCache(objge_StructureGraphEN.CourseId);

if (clsge_StructureGraphBL.relatedActions != null)
{
clsge_StructureGraphBL.relatedActions.UpdRelaTabDate(objge_StructureGraphEN.StructureGraphId, "SetUpdDate");
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
 /// <param name = "objge_StructureGraphEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsge_StructureGraphEN objge_StructureGraphEN)
{
 if (string.IsNullOrEmpty(objge_StructureGraphEN.StructureGraphId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ge_StructureGraphDA.UpdateBySql2(objge_StructureGraphEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureGraphBL.ReFreshCache(objge_StructureGraphEN.CourseId);

if (clsge_StructureGraphBL.relatedActions != null)
{
clsge_StructureGraphBL.relatedActions.UpdRelaTabDate(objge_StructureGraphEN.StructureGraphId, "SetUpdDate");
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
 /// <param name = "strStructureGraphId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strStructureGraphId)
{
try
{
 clsge_StructureGraphEN objge_StructureGraphEN = clsge_StructureGraphBL.GetObjByStructureGraphId(strStructureGraphId);

if (clsge_StructureGraphBL.relatedActions != null)
{
clsge_StructureGraphBL.relatedActions.UpdRelaTabDate(objge_StructureGraphEN.StructureGraphId, "SetUpdDate");
}
if (objge_StructureGraphEN != null)
{
int intRecNum = ge_StructureGraphDA.DelRecord(strStructureGraphId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objge_StructureGraphEN.CourseId);
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
/// <param name="strStructureGraphId">表关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strStructureGraphId , string strCourseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsge_StructureGraphDA.GetSpecSQLObj();
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
//删除与表:[ge_StructureGraph]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conge_StructureGraph.StructureGraphId,
//strStructureGraphId);
//        clsge_StructureGraphBL.Delge_StructureGraphsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsge_StructureGraphBL.DelRecord(strStructureGraphId, strCourseId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsge_StructureGraphBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strStructureGraphId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strStructureGraphId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strStructureGraphId, string strCourseId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsge_StructureGraphBL.relatedActions != null)
{
clsge_StructureGraphBL.relatedActions.UpdRelaTabDate(strStructureGraphId, "UpdRelaTabDate");
}
bool bolResult = ge_StructureGraphDA.DelRecord(strStructureGraphId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrStructureGraphIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delge_StructureGraphs(List<string> arrStructureGraphIdLst)
{
if (arrStructureGraphIdLst.Count == 0) return 0;
try
{
if (clsge_StructureGraphBL.relatedActions != null)
{
foreach (var strStructureGraphId in arrStructureGraphIdLst)
{
clsge_StructureGraphBL.relatedActions.UpdRelaTabDate(strStructureGraphId, "UpdRelaTabDate");
}
}
 clsge_StructureGraphEN objge_StructureGraphEN = clsge_StructureGraphBL.GetObjByStructureGraphId(arrStructureGraphIdLst[0]);
int intDelRecNum = ge_StructureGraphDA.Delge_StructureGraph(arrStructureGraphIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objge_StructureGraphEN.CourseId);
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
public static int Delge_StructureGraphsByCond(string strWhereCond)
{
try
{
if (clsge_StructureGraphBL.relatedActions != null)
{
List<string> arrStructureGraphId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strStructureGraphId in arrStructureGraphId)
{
clsge_StructureGraphBL.relatedActions.UpdRelaTabDate(strStructureGraphId, "UpdRelaTabDate");
}
}
List<string> arrCourseId = GetFldValue(conge_StructureGraph.CourseId, strWhereCond);
int intRecNum = ge_StructureGraphDA.Delge_StructureGraph(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[ge_StructureGraph]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strStructureGraphId">表关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strStructureGraphId, string strCourseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsge_StructureGraphDA.GetSpecSQLObj();
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
//删除与表:[ge_StructureGraph]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsge_StructureGraphBL.DelRecord(strStructureGraphId, strCourseId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsge_StructureGraphBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strStructureGraphId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objge_StructureGraphENS">源对象</param>
 /// <param name = "objge_StructureGraphENT">目标对象</param>
 public static void CopyTo(clsge_StructureGraphEN objge_StructureGraphENS, clsge_StructureGraphEN objge_StructureGraphENT)
{
try
{
objge_StructureGraphENT.StructureGraphId = objge_StructureGraphENS.StructureGraphId; //知识图谱Id
objge_StructureGraphENT.StructureGraphName = objge_StructureGraphENS.StructureGraphName; //结构图谱名称
objge_StructureGraphENT.IdCurrEduCls = objge_StructureGraphENS.IdCurrEduCls; //教学班流水号
objge_StructureGraphENT.CourseId = objge_StructureGraphENS.CourseId; //课程Id
objge_StructureGraphENT.CreateUser = objge_StructureGraphENS.CreateUser; //建立用户
objge_StructureGraphENT.UpdDate = objge_StructureGraphENS.UpdDate; //修改日期
objge_StructureGraphENT.UpdUser = objge_StructureGraphENS.UpdUser; //修改人
objge_StructureGraphENT.Memo = objge_StructureGraphENS.Memo; //备注
objge_StructureGraphENT.GraphTypeId = objge_StructureGraphENS.GraphTypeId; //图谱类型Id
objge_StructureGraphENT.IsDisplay = objge_StructureGraphENS.IsDisplay; //是否显示
objge_StructureGraphENT.IsExtend = objge_StructureGraphENS.IsExtend; //是否扩展
objge_StructureGraphENT.IsRecommend = objge_StructureGraphENS.IsRecommend; //是否推荐
objge_StructureGraphENT.Theme = objge_StructureGraphENS.Theme; //主题
objge_StructureGraphENT.IsSubmit = objge_StructureGraphENS.IsSubmit; //是否提交
objge_StructureGraphENT.SectionTypeId = objge_StructureGraphENS.SectionTypeId; //节点类型Id
objge_StructureGraphENT.TakeUpTime = objge_StructureGraphENS.TakeUpTime; //耗时
objge_StructureGraphENT.StartTime = objge_StructureGraphENS.StartTime; //开始时间
objge_StructureGraphENT.SubmitTime = objge_StructureGraphENS.SubmitTime; //提交时间
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
 /// <param name = "objge_StructureGraphEN">源简化对象</param>
 public static void SetUpdFlag(clsge_StructureGraphEN objge_StructureGraphEN)
{
try
{
objge_StructureGraphEN.ClearUpdateState();
   string strsfUpdFldSetStr = objge_StructureGraphEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conge_StructureGraph.StructureGraphId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureGraphEN.StructureGraphId = objge_StructureGraphEN.StructureGraphId; //知识图谱Id
}
if (arrFldSet.Contains(conge_StructureGraph.StructureGraphName, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureGraphEN.StructureGraphName = objge_StructureGraphEN.StructureGraphName == "[null]" ? null :  objge_StructureGraphEN.StructureGraphName; //结构图谱名称
}
if (arrFldSet.Contains(conge_StructureGraph.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureGraphEN.IdCurrEduCls = objge_StructureGraphEN.IdCurrEduCls == "[null]" ? null :  objge_StructureGraphEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conge_StructureGraph.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureGraphEN.CourseId = objge_StructureGraphEN.CourseId == "[null]" ? null :  objge_StructureGraphEN.CourseId; //课程Id
}
if (arrFldSet.Contains(conge_StructureGraph.CreateUser, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureGraphEN.CreateUser = objge_StructureGraphEN.CreateUser == "[null]" ? null :  objge_StructureGraphEN.CreateUser; //建立用户
}
if (arrFldSet.Contains(conge_StructureGraph.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureGraphEN.UpdDate = objge_StructureGraphEN.UpdDate == "[null]" ? null :  objge_StructureGraphEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conge_StructureGraph.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureGraphEN.UpdUser = objge_StructureGraphEN.UpdUser == "[null]" ? null :  objge_StructureGraphEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conge_StructureGraph.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureGraphEN.Memo = objge_StructureGraphEN.Memo == "[null]" ? null :  objge_StructureGraphEN.Memo; //备注
}
if (arrFldSet.Contains(conge_StructureGraph.GraphTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureGraphEN.GraphTypeId = objge_StructureGraphEN.GraphTypeId == "[null]" ? null :  objge_StructureGraphEN.GraphTypeId; //图谱类型Id
}
if (arrFldSet.Contains(conge_StructureGraph.IsDisplay, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureGraphEN.IsDisplay = objge_StructureGraphEN.IsDisplay; //是否显示
}
if (arrFldSet.Contains(conge_StructureGraph.IsExtend, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureGraphEN.IsExtend = objge_StructureGraphEN.IsExtend; //是否扩展
}
if (arrFldSet.Contains(conge_StructureGraph.IsRecommend, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureGraphEN.IsRecommend = objge_StructureGraphEN.IsRecommend; //是否推荐
}
if (arrFldSet.Contains(conge_StructureGraph.Theme, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureGraphEN.Theme = objge_StructureGraphEN.Theme == "[null]" ? null :  objge_StructureGraphEN.Theme; //主题
}
if (arrFldSet.Contains(conge_StructureGraph.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureGraphEN.IsSubmit = objge_StructureGraphEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(conge_StructureGraph.SectionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureGraphEN.SectionTypeId = objge_StructureGraphEN.SectionTypeId; //节点类型Id
}
if (arrFldSet.Contains(conge_StructureGraph.TakeUpTime, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureGraphEN.TakeUpTime = objge_StructureGraphEN.TakeUpTime == "[null]" ? null :  objge_StructureGraphEN.TakeUpTime; //耗时
}
if (arrFldSet.Contains(conge_StructureGraph.StartTime, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureGraphEN.StartTime = objge_StructureGraphEN.StartTime == "[null]" ? null :  objge_StructureGraphEN.StartTime; //开始时间
}
if (arrFldSet.Contains(conge_StructureGraph.SubmitTime, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureGraphEN.SubmitTime = objge_StructureGraphEN.SubmitTime == "[null]" ? null :  objge_StructureGraphEN.SubmitTime; //提交时间
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
 /// <param name = "objge_StructureGraphEN">源简化对象</param>
 public static void AccessFldValueNull(clsge_StructureGraphEN objge_StructureGraphEN)
{
try
{
if (objge_StructureGraphEN.StructureGraphName == "[null]") objge_StructureGraphEN.StructureGraphName = null; //结构图谱名称
if (objge_StructureGraphEN.IdCurrEduCls == "[null]") objge_StructureGraphEN.IdCurrEduCls = null; //教学班流水号
if (objge_StructureGraphEN.CourseId == "[null]") objge_StructureGraphEN.CourseId = null; //课程Id
if (objge_StructureGraphEN.CreateUser == "[null]") objge_StructureGraphEN.CreateUser = null; //建立用户
if (objge_StructureGraphEN.UpdDate == "[null]") objge_StructureGraphEN.UpdDate = null; //修改日期
if (objge_StructureGraphEN.UpdUser == "[null]") objge_StructureGraphEN.UpdUser = null; //修改人
if (objge_StructureGraphEN.Memo == "[null]") objge_StructureGraphEN.Memo = null; //备注
if (objge_StructureGraphEN.GraphTypeId == "[null]") objge_StructureGraphEN.GraphTypeId = null; //图谱类型Id
if (objge_StructureGraphEN.Theme == "[null]") objge_StructureGraphEN.Theme = null; //主题
if (objge_StructureGraphEN.TakeUpTime == "[null]") objge_StructureGraphEN.TakeUpTime = null; //耗时
if (objge_StructureGraphEN.StartTime == "[null]") objge_StructureGraphEN.StartTime = null; //开始时间
if (objge_StructureGraphEN.SubmitTime == "[null]") objge_StructureGraphEN.SubmitTime = null; //提交时间
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
public static void CheckPropertyNew(clsge_StructureGraphEN objge_StructureGraphEN)
{
 ge_StructureGraphDA.CheckPropertyNew(objge_StructureGraphEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsge_StructureGraphEN objge_StructureGraphEN)
{
 ge_StructureGraphDA.CheckProperty4Condition(objge_StructureGraphEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strCourseId"></param>
public static void BindCbo_StructureGraphId(System.Windows.Forms.ComboBox objComboBox , string strCourseId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conge_StructureGraph.StructureGraphId); 
List<clsge_StructureGraphEN> arrObjLst = clsge_StructureGraphBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.CourseId == strCourseId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsge_StructureGraphEN objge_StructureGraphEN = new clsge_StructureGraphEN()
{
StructureGraphId = "0",
StructureGraphName = "选[结构图谱表]..."
};
arrObjLstSel.Insert(0, objge_StructureGraphEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conge_StructureGraph.StructureGraphId;
objComboBox.DisplayMember = conge_StructureGraph.StructureGraphName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strCourseId"></param>
public static void BindDdl_StructureGraphId(System.Web.UI.WebControls.DropDownList objDDL , string strCourseId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[结构图谱表]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conge_StructureGraph.StructureGraphId); 
IEnumerable<clsge_StructureGraphEN> arrObjLst = clsge_StructureGraphBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.CourseId == strCourseId).ToList();
objDDL.DataValueField = conge_StructureGraph.StructureGraphId;
objDDL.DataTextField = conge_StructureGraph.StructureGraphName;
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
public static void BindDdl_StructureGraphIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strCourseId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[结构图谱表]...","0");
List<clsge_StructureGraphEN> arrge_StructureGraphObjLst = GetAllge_StructureGraphObjLstCache(strCourseId); 
objDDL.DataValueField = conge_StructureGraph.StructureGraphId;
objDDL.DataTextField = conge_StructureGraph.StructureGraphName;
objDDL.DataSource = arrge_StructureGraphObjLst;
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
if (clsge_StructureGraphBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsge_StructureGraphBL没有刷新缓存机制(clsge_StructureGraphBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by StructureGraphId");
//if (arrge_StructureGraphObjLstCache == null)
//{
//arrge_StructureGraphObjLstCache = ge_StructureGraphDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strStructureGraphId">所给的关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsge_StructureGraphEN GetObjByStructureGraphIdCache(string strStructureGraphId, string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsge_StructureGraphEN._CurrTabName, strCourseId);
List<clsge_StructureGraphEN> arrge_StructureGraphObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsge_StructureGraphEN> arrge_StructureGraphObjLst_Sel =
arrge_StructureGraphObjLstCache
.Where(x=> x.StructureGraphId == strStructureGraphId 
);
if (arrge_StructureGraphObjLst_Sel.Count() == 0)
{
   clsge_StructureGraphEN obj = clsge_StructureGraphBL.GetObjByStructureGraphId(strStructureGraphId);
   if (obj != null)
 {
if (obj.CourseId == strCourseId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strStructureGraphId, strCourseId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrge_StructureGraphObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strStructureGraphId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetStructureGraphNameByStructureGraphIdCache(string strStructureGraphId, string strCourseId)
{
if (string.IsNullOrEmpty(strStructureGraphId) == true) return "";
//获取缓存中的对象列表
clsge_StructureGraphEN objge_StructureGraph = GetObjByStructureGraphIdCache(strStructureGraphId, strCourseId);
if (objge_StructureGraph == null) return "";
return objge_StructureGraph.StructureGraphName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strStructureGraphId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByStructureGraphIdCache(string strStructureGraphId, string strCourseId)
{
if (string.IsNullOrEmpty(strStructureGraphId) == true) return "";
//获取缓存中的对象列表
clsge_StructureGraphEN objge_StructureGraph = GetObjByStructureGraphIdCache(strStructureGraphId, strCourseId);
if (objge_StructureGraph == null) return "";
return objge_StructureGraph.StructureGraphName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsge_StructureGraphEN> GetAllge_StructureGraphObjLstCache(string strCourseId)
{
//获取缓存中的对象列表
List<clsge_StructureGraphEN> arrge_StructureGraphObjLstCache = GetObjLstCache(strCourseId); 
return arrge_StructureGraphObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsge_StructureGraphEN> GetObjLstCache(string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsge_StructureGraphEN._CurrTabName, strCourseId);
string strCondition = string.Format("CourseId='{0}'", strCourseId);
List<clsge_StructureGraphEN> arrge_StructureGraphObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrge_StructureGraphObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsge_StructureGraphEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clsge_StructureGraphEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsge_StructureGraphEN._RefreshTimeLst.Count == 0) return "";
return clsge_StructureGraphEN._RefreshTimeLst[clsge_StructureGraphEN._RefreshTimeLst.Count - 1];
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
if (clsge_StructureGraphBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsge_StructureGraphEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clsge_StructureGraphEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsge_StructureGraphBL.objCommFun4BL.ReFreshCache(strCourseId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--ge_StructureGraph(结构图谱表)
 /// 唯一性条件:StructureGraphId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objge_StructureGraphEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsge_StructureGraphEN objge_StructureGraphEN)
{
//检测记录是否存在
string strResult = ge_StructureGraphDA.GetUniCondStr(objge_StructureGraphEN);
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
public static string Func(string strInFldName, string strOutFldName, string strStructureGraphId, string strCourseId)
{
if (strInFldName != conge_StructureGraph.StructureGraphId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conge_StructureGraph.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conge_StructureGraph.AttributeName));
throw new Exception(strMsg);
}
var objge_StructureGraph = clsge_StructureGraphBL.GetObjByStructureGraphIdCache(strStructureGraphId, strCourseId);
if (objge_StructureGraph == null) return "";
return objge_StructureGraph[strOutFldName].ToString();
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
int intRecCount = clsge_StructureGraphDA.GetRecCount(strTabName);
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
int intRecCount = clsge_StructureGraphDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsge_StructureGraphDA.GetRecCount();
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
int intRecCount = clsge_StructureGraphDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objge_StructureGraphCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsge_StructureGraphEN objge_StructureGraphCond)
{
 string strCourseId = objge_StructureGraphCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsge_StructureGraphBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsge_StructureGraphEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsge_StructureGraphEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conge_StructureGraph.AttributeName)
{
if (objge_StructureGraphCond.IsUpdated(strFldName) == false) continue;
if (objge_StructureGraphCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_StructureGraphCond[strFldName].ToString());
}
else
{
if (objge_StructureGraphCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objge_StructureGraphCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_StructureGraphCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objge_StructureGraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objge_StructureGraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objge_StructureGraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objge_StructureGraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objge_StructureGraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objge_StructureGraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objge_StructureGraphCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objge_StructureGraphCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objge_StructureGraphCond[strFldName]));
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
 List<string> arrList = clsge_StructureGraphDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ge_StructureGraphDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ge_StructureGraphDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ge_StructureGraphDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsge_StructureGraphDA.SetFldValue(clsge_StructureGraphEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ge_StructureGraphDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsge_StructureGraphDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsge_StructureGraphDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsge_StructureGraphDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ge_StructureGraph] "); 
 strCreateTabCode.Append(" ( "); 
 // /**知识图谱Id*/ 
 strCreateTabCode.Append(" StructureGraphId char(10) primary key, "); 
 // /**结构图谱名称*/ 
 strCreateTabCode.Append(" StructureGraphName varchar(100) Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) Null, "); 
 // /**课程Id*/ 
 strCreateTabCode.Append(" CourseId char(8) Null, "); 
 // /**建立用户*/ 
 strCreateTabCode.Append(" CreateUser varchar(50) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**图谱类型Id*/ 
 strCreateTabCode.Append(" GraphTypeId char(2) Null, "); 
 // /**是否显示*/ 
 strCreateTabCode.Append(" IsDisplay bit Null, "); 
 // /**是否扩展*/ 
 strCreateTabCode.Append(" IsExtend bit Null, "); 
 // /**是否推荐*/ 
 strCreateTabCode.Append(" IsRecommend bit Null, "); 
 // /**主题*/ 
 strCreateTabCode.Append(" Theme varchar(100) Null, "); 
 // /**是否提交*/ 
 strCreateTabCode.Append(" IsSubmit bit Null, "); 
 // /**节点类型Id*/ 
 strCreateTabCode.Append(" SectionTypeId char(8) not Null, "); 
 // /**耗时*/ 
 strCreateTabCode.Append(" TakeUpTime varchar(50) Null, "); 
 // /**开始时间*/ 
 strCreateTabCode.Append(" StartTime varchar(20) Null, "); 
 // /**提交时间*/ 
 strCreateTabCode.Append(" SubmitTime varchar(20) Null, "); 
 // /**教学班名*/ 
 strCreateTabCode.Append(" EduClsName varchar(100) Null, "); 
 // /**课程名称*/ 
 strCreateTabCode.Append(" CourseName varchar(100) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 结构图谱表(ge_StructureGraph)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4ge_StructureGraph : clsCommFun4BLV2
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
clsge_StructureGraphBL.ReFreshThisCache(strCourseId);
}
}

}