
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCurrEduCls_SynBL
 表名:CurrEduCls_Syn(01120927)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:23:44
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:日常运行(DailyRunning)
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
public static class  clsCurrEduCls_SynBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdCurrEduCls">表关键字</param>
 /// <returns>表对象</returns>
public static clsCurrEduCls_SynEN GetObj(this K_IdCurrEduCls_CurrEduCls_Syn myKey)
{
clsCurrEduCls_SynEN objCurrEduCls_SynEN = clsCurrEduCls_SynBL.CurrEduCls_SynDA.GetObjByIdCurrEduCls(myKey.Value);
return objCurrEduCls_SynEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCurrEduCls_SynEN objCurrEduCls_SynEN)
{
try
{
 if (string.IsNullOrEmpty(objCurrEduCls_SynEN.IdCurrEduCls) == true || clsCurrEduCls_SynBL.IsExist(objCurrEduCls_SynEN.IdCurrEduCls) == true)
 {
     objCurrEduCls_SynEN.IdCurrEduCls = clsCurrEduCls_SynBL.GetMaxStrId_S();
 }
bool bolResult = clsCurrEduCls_SynBL.CurrEduCls_SynDA.AddNewRecordBySQL2(objCurrEduCls_SynEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduCls_SynBL.ReFreshCache();

if (clsCurrEduCls_SynBL.relatedActions != null)
{
clsCurrEduCls_SynBL.relatedActions.UpdRelaTabDate(objCurrEduCls_SynEN.IdCurrEduCls, objCurrEduCls_SynEN.ModifyUserId);
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
public static bool AddRecordEx(this clsCurrEduCls_SynEN objCurrEduCls_SynEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsCurrEduCls_SynBL.IsExist(objCurrEduCls_SynEN.IdCurrEduCls))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objCurrEduCls_SynEN.CheckPropertyNew();
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objCurrEduCls_SynEN.IdCurrEduCls) == true || clsCurrEduCls_SynBL.IsExist(objCurrEduCls_SynEN.IdCurrEduCls) == true)
 {
     objCurrEduCls_SynEN.IdCurrEduCls = clsCurrEduCls_SynBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objCurrEduCls_SynEN.AddNewRecord();
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
 /// <param name = "objCurrEduCls_SynEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsCurrEduCls_SynEN objCurrEduCls_SynEN)
{
try
{
 if (string.IsNullOrEmpty(objCurrEduCls_SynEN.IdCurrEduCls) == true || clsCurrEduCls_SynBL.IsExist(objCurrEduCls_SynEN.IdCurrEduCls) == true)
 {
     objCurrEduCls_SynEN.IdCurrEduCls = clsCurrEduCls_SynBL.GetMaxStrId_S();
 }
string strIdCurrEduCls = clsCurrEduCls_SynBL.CurrEduCls_SynDA.AddNewRecordBySQL2WithReturnKey(objCurrEduCls_SynEN);
     objCurrEduCls_SynEN.IdCurrEduCls = strIdCurrEduCls;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduCls_SynBL.ReFreshCache();

if (clsCurrEduCls_SynBL.relatedActions != null)
{
clsCurrEduCls_SynBL.relatedActions.UpdRelaTabDate(objCurrEduCls_SynEN.IdCurrEduCls, objCurrEduCls_SynEN.ModifyUserId);
}
return strIdCurrEduCls;
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
 /// <param name = "objCurrEduCls_SynEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsCurrEduCls_SynEN objCurrEduCls_SynEN)
{
try
{
 if (string.IsNullOrEmpty(objCurrEduCls_SynEN.IdCurrEduCls) == true || clsCurrEduCls_SynBL.IsExist(objCurrEduCls_SynEN.IdCurrEduCls) == true)
 {
     objCurrEduCls_SynEN.IdCurrEduCls = clsCurrEduCls_SynBL.GetMaxStrId_S();
 }
string strKey = clsCurrEduCls_SynBL.CurrEduCls_SynDA.AddNewRecordBySQL2WithReturnKey(objCurrEduCls_SynEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduCls_SynBL.ReFreshCache();

if (clsCurrEduCls_SynBL.relatedActions != null)
{
clsCurrEduCls_SynBL.relatedActions.UpdRelaTabDate(objCurrEduCls_SynEN.IdCurrEduCls, objCurrEduCls_SynEN.ModifyUserId);
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
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetIdCurrEduCls(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conCurrEduCls_Syn.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conCurrEduCls_Syn.IdCurrEduCls);
}
objCurrEduCls_SynEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.IdCurrEduCls) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.IdCurrEduCls, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.IdCurrEduCls] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetCurrEduClsId(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strCurrEduClsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCurrEduClsId, conCurrEduCls_Syn.CurrEduClsId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCurrEduClsId, 15, conCurrEduCls_Syn.CurrEduClsId);
}
objCurrEduCls_SynEN.CurrEduClsId = strCurrEduClsId; //教学班Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.CurrEduClsId) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.CurrEduClsId, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.CurrEduClsId] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetEduClsName(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strEduClsName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduClsName, 100, conCurrEduCls_Syn.EduClsName);
}
objCurrEduCls_SynEN.EduClsName = strEduClsName; //教学班名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.EduClsName) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.EduClsName, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.EduClsName] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetEduClsTypeId(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strEduClsTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduClsTypeId, 4, conCurrEduCls_Syn.EduClsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strEduClsTypeId, 4, conCurrEduCls_Syn.EduClsTypeId);
}
objCurrEduCls_SynEN.EduClsTypeId = strEduClsTypeId; //教学班类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.EduClsTypeId) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.EduClsTypeId, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.EduClsTypeId] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetCourseId(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, conCurrEduCls_Syn.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, conCurrEduCls_Syn.CourseId);
}
objCurrEduCls_SynEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.CourseId) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.CourseId, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.CourseId] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetTeachingSolutionId(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strTeachingSolutionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingSolutionId, 8, conCurrEduCls_Syn.TeachingSolutionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachingSolutionId, 8, conCurrEduCls_Syn.TeachingSolutionId);
}
objCurrEduCls_SynEN.TeachingSolutionId = strTeachingSolutionId; //教学方案Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.TeachingSolutionId) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.TeachingSolutionId, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.TeachingSolutionId] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetIdXzCollege(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, conCurrEduCls_Syn.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, conCurrEduCls_Syn.IdXzCollege);
}
objCurrEduCls_SynEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.IdXzCollege) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.IdXzCollege, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.IdXzCollege] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetIdMajor(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strIdMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdMajor, conCurrEduCls_Syn.IdMajor);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdMajor, 8, conCurrEduCls_Syn.IdMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdMajor, 8, conCurrEduCls_Syn.IdMajor);
}
objCurrEduCls_SynEN.IdMajor = strIdMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.IdMajor) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.IdMajor, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.IdMajor] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetIdEduWay(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strIdEduWay, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdEduWay, 4, conCurrEduCls_Syn.IdEduWay);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdEduWay, 4, conCurrEduCls_Syn.IdEduWay);
}
objCurrEduCls_SynEN.IdEduWay = strIdEduWay; //教学方式流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.IdEduWay) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.IdEduWay, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.IdEduWay] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetIdClassRoomType(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strIdClassRoomType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdClassRoomType, 4, conCurrEduCls_Syn.IdClassRoomType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdClassRoomType, 4, conCurrEduCls_Syn.IdClassRoomType);
}
objCurrEduCls_SynEN.IdClassRoomType = strIdClassRoomType; //教室类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.IdClassRoomType) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.IdClassRoomType, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.IdClassRoomType] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetTotalLessonQty(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, int? intTotalLessonQty, string strComparisonOp="")
	{
objCurrEduCls_SynEN.TotalLessonQty = intTotalLessonQty; //总课时数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.TotalLessonQty) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.TotalLessonQty, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.TotalLessonQty] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetMaxStuQty(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, int? intMaxStuQty, string strComparisonOp="")
	{
objCurrEduCls_SynEN.MaxStuQty = intMaxStuQty; //最大学生数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.MaxStuQty) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.MaxStuQty, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.MaxStuQty] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetCurrentStuQty(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, int? intCurrentStuQty, string strComparisonOp="")
	{
objCurrEduCls_SynEN.CurrentStuQty = intCurrentStuQty; //当前学生数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.CurrentStuQty) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.CurrentStuQty, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.CurrentStuQty] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetWeekQty(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, int? intWeekQty, string strComparisonOp="")
	{
objCurrEduCls_SynEN.WeekQty = intWeekQty; //总周数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.WeekQty) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.WeekQty, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.WeekQty] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetScheUnitPW(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, short? shtScheUnitPW, string strComparisonOp="")
	{
objCurrEduCls_SynEN.ScheUnitPW = shtScheUnitPW; //周排课次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.ScheUnitPW) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.ScheUnitPW, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.ScheUnitPW] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetWeekStatusId(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strWeekStatusId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWeekStatusId, 2, conCurrEduCls_Syn.WeekStatusId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strWeekStatusId, 2, conCurrEduCls_Syn.WeekStatusId);
}
objCurrEduCls_SynEN.WeekStatusId = strWeekStatusId; //周状态编号(单,双,全周)
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.WeekStatusId) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.WeekStatusId, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.WeekStatusId] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetCustomerWeek(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strCustomerWeek, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCustomerWeek, 50, conCurrEduCls_Syn.CustomerWeek);
}
objCurrEduCls_SynEN.CustomerWeek = strCustomerWeek; //自定义上课周
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.CustomerWeek) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.CustomerWeek, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.CustomerWeek] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetIsCompleteScore(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, bool bolIsCompleteScore, string strComparisonOp="")
	{
objCurrEduCls_SynEN.IsCompleteScore = bolIsCompleteScore; //是否成绩齐全
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.IsCompleteScore) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.IsCompleteScore, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.IsCompleteScore] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetIdExecPlan(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strIdExecPlan, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdExecPlan, 8, conCurrEduCls_Syn.IdExecPlan);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdExecPlan, 8, conCurrEduCls_Syn.IdExecPlan);
}
objCurrEduCls_SynEN.IdExecPlan = strIdExecPlan; //执行计划流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.IdExecPlan) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.IdExecPlan, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.IdExecPlan] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetLessonQtyPerWeek(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, short? shtLessonQtyPerWeek, string strComparisonOp="")
	{
objCurrEduCls_SynEN.LessonQtyPerWeek = shtLessonQtyPerWeek; //周课时数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.LessonQtyPerWeek) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.LessonQtyPerWeek, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.LessonQtyPerWeek] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetMark(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, double? dblMark, string strComparisonOp="")
	{
objCurrEduCls_SynEN.Mark = dblMark; //获得学分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.Mark) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.Mark, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.Mark] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetCheckClassRoom(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strCheckClassRoom, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCheckClassRoom, 2000, conCurrEduCls_Syn.CheckClassRoom);
}
objCurrEduCls_SynEN.CheckClassRoom = strCheckClassRoom; //检查教室结果
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.CheckClassRoom) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.CheckClassRoom, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.CheckClassRoom] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetCheckAdminCls(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strCheckAdminCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCheckAdminCls, 2000, conCurrEduCls_Syn.CheckAdminCls);
}
objCurrEduCls_SynEN.CheckAdminCls = strCheckAdminCls; //检查行政班结果
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.CheckAdminCls) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.CheckAdminCls, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.CheckAdminCls] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetCheckTeacher(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strCheckTeacher, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCheckTeacher, 2000, conCurrEduCls_Syn.CheckTeacher);
}
objCurrEduCls_SynEN.CheckTeacher = strCheckTeacher; //检查教师结果
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.CheckTeacher) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.CheckTeacher, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.CheckTeacher] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetEditLocked(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, bool bolEditLocked, string strComparisonOp="")
	{
objCurrEduCls_SynEN.EditLocked = bolEditLocked; //编辑锁定
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.EditLocked) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.EditLocked, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.EditLocked] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetSched(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, bool bolSched, string strComparisonOp="")
	{
objCurrEduCls_SynEN.Sched = bolSched; //是否排课
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.Sched) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.Sched, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.Sched] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetIdUniZone(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strIdUniZone, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdUniZone, 4, conCurrEduCls_Syn.IdUniZone);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdUniZone, 4, conCurrEduCls_Syn.IdUniZone);
}
objCurrEduCls_SynEN.IdUniZone = strIdUniZone; //校区流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.IdUniZone) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.IdUniZone, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.IdUniZone] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetLocked(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, bool bolLocked, string strComparisonOp="")
	{
objCurrEduCls_SynEN.Locked = bolLocked; //锁定状态
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.Locked) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.Locked, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.Locked] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetIdGradeBase(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strIdGradeBase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdGradeBase, 4, conCurrEduCls_Syn.IdGradeBase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdGradeBase, 4, conCurrEduCls_Syn.IdGradeBase);
}
objCurrEduCls_SynEN.IdGradeBase = strIdGradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.IdGradeBase) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.IdGradeBase, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.IdGradeBase] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetIsEffective(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, bool bolIsEffective, string strComparisonOp="")
	{
objCurrEduCls_SynEN.IsEffective = bolIsEffective; //是否有效
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.IsEffective) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.IsEffective, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.IsEffective] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetIsForPaperReading(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, bool bolIsForPaperReading, string strComparisonOp="")
	{
objCurrEduCls_SynEN.IsForPaperReading = bolIsForPaperReading; //是否参与论文阅读
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.IsForPaperReading) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.IsForPaperReading, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.IsForPaperReading] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetIsUnDeterminedClsRm(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, bool bolIsUnDeterminedClsRm, string strComparisonOp="")
	{
objCurrEduCls_SynEN.IsUnDeterminedClsRm = bolIsUnDeterminedClsRm; //是否待定教室
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.IsUnDeterminedClsRm) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.IsUnDeterminedClsRm, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.IsUnDeterminedClsRm] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetSchoolYear(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strSchoolYear, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, conCurrEduCls_Syn.SchoolYear);
}
objCurrEduCls_SynEN.SchoolYear = strSchoolYear; //学年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.SchoolYear) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.SchoolYear, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.SchoolYear] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetSchoolTerm(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strSchoolTerm, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, conCurrEduCls_Syn.SchoolTerm);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, conCurrEduCls_Syn.SchoolTerm);
}
objCurrEduCls_SynEN.SchoolTerm = strSchoolTerm; //学期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.SchoolTerm) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.SchoolTerm, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.SchoolTerm] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetArrangeCourseMemo(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strArrangeCourseMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strArrangeCourseMemo, 50, conCurrEduCls_Syn.ArrangeCourseMemo);
}
objCurrEduCls_SynEN.ArrangeCourseMemo = strArrangeCourseMemo; //排课备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.ArrangeCourseMemo) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.ArrangeCourseMemo, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.ArrangeCourseMemo] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetIdCourseType(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strIdCourseType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCourseType, 4, conCurrEduCls_Syn.IdCourseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCourseType, 4, conCurrEduCls_Syn.IdCourseType);
}
objCurrEduCls_SynEN.IdCourseType = strIdCourseType; //课程类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.IdCourseType) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.IdCourseType, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.IdCourseType] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetExportDate(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strExportDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExportDate, 8, conCurrEduCls_Syn.ExportDate);
}
objCurrEduCls_SynEN.ExportDate = strExportDate; //导出日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.ExportDate) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.ExportDate, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.ExportDate] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetIsDegree(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, bool bolIsDegree, string strComparisonOp="")
	{
objCurrEduCls_SynEN.IsDegree = bolIsDegree; //是否学位课
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.IsDegree) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.IsDegree, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.IsDegree] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetIdScoreType(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strIdScoreType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdScoreType, 4, conCurrEduCls_Syn.IdScoreType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdScoreType, 4, conCurrEduCls_Syn.IdScoreType);
}
objCurrEduCls_SynEN.IdScoreType = strIdScoreType; //成绩类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.IdScoreType) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.IdScoreType, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.IdScoreType] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetGetScoreWayId(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strGetScoreWayId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGetScoreWayId, 2, conCurrEduCls_Syn.GetScoreWayId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGetScoreWayId, 2, conCurrEduCls_Syn.GetScoreWayId);
}
objCurrEduCls_SynEN.GetScoreWayId = strGetScoreWayId; //获得成绩方式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.GetScoreWayId) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.GetScoreWayId, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.GetScoreWayId] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetIsProportionalCtrl(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, bool bolIsProportionalCtrl, string strComparisonOp="")
	{
objCurrEduCls_SynEN.IsProportionalCtrl = bolIsProportionalCtrl; //是否比例控制
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.IsProportionalCtrl) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.IsProportionalCtrl, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.IsProportionalCtrl] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetIdExamType(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strIdExamType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdExamType, 4, conCurrEduCls_Syn.IdExamType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdExamType, 4, conCurrEduCls_Syn.IdExamType);
}
objCurrEduCls_SynEN.IdExamType = strIdExamType; //考试方式流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.IdExamType) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.IdExamType, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.IdExamType] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetExamPortion(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, short? shtExamPortion, string strComparisonOp="")
	{
objCurrEduCls_SynEN.ExamPortion = shtExamPortion; //平时成绩所占比例
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.ExamPortion) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.ExamPortion, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.ExamPortion] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetMidExamScorePortion(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, short? shtMidExamScorePortion, string strComparisonOp="")
	{
objCurrEduCls_SynEN.MidExamScorePortion = shtMidExamScorePortion; //期末成绩所占比例
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.MidExamScorePortion) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.MidExamScorePortion, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.MidExamScorePortion] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetIsClearScore(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, bool bolIsClearScore, string strComparisonOp="")
	{
objCurrEduCls_SynEN.IsClearScore = bolIsClearScore; //是否重录成绩
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.IsClearScore) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.IsClearScore, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.IsClearScore] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetIsGeneratePwd(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, bool bolIsGeneratePwd, string strComparisonOp="")
	{
objCurrEduCls_SynEN.IsGeneratePwd = bolIsGeneratePwd; //是否生成口令
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.IsGeneratePwd) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.IsGeneratePwd, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.IsGeneratePwd] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetGeneratePwdDate(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strGeneratePwdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGeneratePwdDate, 20, conCurrEduCls_Syn.GeneratePwdDate);
}
objCurrEduCls_SynEN.GeneratePwdDate = strGeneratePwdDate; //生成口令时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.GeneratePwdDate) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.GeneratePwdDate, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.GeneratePwdDate] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetIsExportToGP(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, bool bolIsExportToGP, string strComparisonOp="")
	{
objCurrEduCls_SynEN.IsExportToGP = bolIsExportToGP; //是否导出到平台
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.IsExportToGP) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.IsExportToGP, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.IsExportToGP] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetIsExportToGPWeb(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, bool bolIsExportToGPWeb, string strComparisonOp="")
	{
objCurrEduCls_SynEN.IsExportToGPWeb = bolIsExportToGPWeb; //是否导出到Web平台
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.IsExportToGPWeb) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.IsExportToGPWeb, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.IsExportToGPWeb] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetIsReservedDecimal(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, bool bolIsReservedDecimal, string strComparisonOp="")
	{
objCurrEduCls_SynEN.IsReservedDecimal = bolIsReservedDecimal; //是否保留小数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.IsReservedDecimal) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.IsReservedDecimal, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.IsReservedDecimal] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetExamTime(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strExamTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExamTime, 8, conCurrEduCls_Syn.ExamTime);
}
objCurrEduCls_SynEN.ExamTime = strExamTime; //考试时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.ExamTime) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.ExamTime, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.ExamTime] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetCheckState(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, bool bolCheckState, string strComparisonOp="")
	{
objCurrEduCls_SynEN.CheckState = bolCheckState; //检查状态
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.CheckState) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.CheckState, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.CheckState] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetCheckDate(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strCheckDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCheckDate, 20, conCurrEduCls_Syn.CheckDate);
}
objCurrEduCls_SynEN.CheckDate = strCheckDate; //检查日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.CheckDate) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.CheckDate, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.CheckDate] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetIdEduClassInPk(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strIdEduClassInPk, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdEduClassInPk, 8, conCurrEduCls_Syn.IdEduClassInPk);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdEduClassInPk, 8, conCurrEduCls_Syn.IdEduClassInPk);
}
objCurrEduCls_SynEN.IdEduClassInPk = strIdEduClassInPk; //id_EduClassInPk
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.IdEduClassInPk) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.IdEduClassInPk, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.IdEduClassInPk] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetPkWeekTime(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strPkWeekTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPkWeekTime, 2000, conCurrEduCls_Syn.PkWeekTime);
}
objCurrEduCls_SynEN.PkWeekTime = strPkWeekTime; //排课时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.PkWeekTime) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.PkWeekTime, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.PkWeekTime] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetPkClassRooms(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strPkClassRooms, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPkClassRooms, 150, conCurrEduCls_Syn.PkClassRooms);
}
objCurrEduCls_SynEN.PkClassRooms = strPkClassRooms; //排课教室
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.PkClassRooms) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.PkClassRooms, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.PkClassRooms] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetBeginWeek(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, short? shtBeginWeek, string strComparisonOp="")
	{
objCurrEduCls_SynEN.BeginWeek = shtBeginWeek; //开始周
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.BeginWeek) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.BeginWeek, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.BeginWeek] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetTeacherNames(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strTeacherNames, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeacherNames, 100, conCurrEduCls_Syn.TeacherNames);
}
objCurrEduCls_SynEN.TeacherNames = strTeacherNames; //教师姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.TeacherNames) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.TeacherNames, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.TeacherNames] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetIsSynch(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, bool bolIsSynch, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsSynch, conCurrEduCls_Syn.IsSynch);
objCurrEduCls_SynEN.IsSynch = bolIsSynch; //是否同步
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.IsSynch) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.IsSynch, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.IsSynch] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetSynchDate(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strSynchDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSynchDate, 30, conCurrEduCls_Syn.SynchDate);
}
objCurrEduCls_SynEN.SynchDate = strSynchDate; //同步日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.SynchDate) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.SynchDate, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.SynchDate] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetModifyDate(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strModifyDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModifyDate, 20, conCurrEduCls_Syn.ModifyDate);
}
objCurrEduCls_SynEN.ModifyDate = strModifyDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.ModifyDate) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.ModifyDate, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.ModifyDate] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetModifyUserId(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strModifyUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModifyUserId, 18, conCurrEduCls_Syn.ModifyUserId);
}
objCurrEduCls_SynEN.ModifyUserId = strModifyUserId; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.ModifyUserId) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.ModifyUserId, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.ModifyUserId] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetMemo(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCurrEduCls_Syn.Memo);
}
objCurrEduCls_SynEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.Memo) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.Memo, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.Memo] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetSignInDate(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strSignInDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSignInDate, 20, conCurrEduCls_Syn.SignInDate);
}
objCurrEduCls_SynEN.SignInDate = strSignInDate; //签入时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.SignInDate) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.SignInDate, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.SignInDate] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetSignInStateID(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strSignInStateID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSignInStateID, 2, conCurrEduCls_Syn.SignInStateID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSignInStateID, 2, conCurrEduCls_Syn.SignInStateID);
}
objCurrEduCls_SynEN.SignInStateID = strSignInStateID; //签入状态表流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.SignInStateID) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.SignInStateID, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.SignInStateID] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetSignInUser(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strSignInUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSignInUser, 18, conCurrEduCls_Syn.SignInUser);
}
objCurrEduCls_SynEN.SignInUser = strSignInUser; //签入人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.SignInUser) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.SignInUser, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.SignInUser] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetSynchToWebUser(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strSynchToWebUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSynchToWebUser, 18, conCurrEduCls_Syn.SynchToWebUser);
}
objCurrEduCls_SynEN.SynchToWebUser = strSynchToWebUser; //同步Web用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.SynchToWebUser) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.SynchToWebUser, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.SynchToWebUser] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetIsSynchToWeb(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, bool bolIsSynchToWeb, string strComparisonOp="")
	{
objCurrEduCls_SynEN.IsSynchToWeb = bolIsSynchToWeb; //是否同步Web
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.IsSynchToWeb) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.IsSynchToWeb, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.IsSynchToWeb] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls_SynEN SetSynchToWebDate(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strSynchToWebDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSynchToWebDate, 20, conCurrEduCls_Syn.SynchToWebDate);
}
objCurrEduCls_SynEN.SynchToWebDate = strSynchToWebDate; //同步Web日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.SynchToWebDate) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.SynchToWebDate, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.SynchToWebDate] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCurrEduCls_SynEN objCurrEduCls_SynEN)
{
 if (string.IsNullOrEmpty(objCurrEduCls_SynEN.IdCurrEduCls) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCurrEduCls_SynBL.CurrEduCls_SynDA.UpdateBySql2(objCurrEduCls_SynEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduCls_SynBL.ReFreshCache();

if (clsCurrEduCls_SynBL.relatedActions != null)
{
clsCurrEduCls_SynBL.relatedActions.UpdRelaTabDate(objCurrEduCls_SynEN.IdCurrEduCls, objCurrEduCls_SynEN.ModifyUserId);
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
 /// <param name = "objCurrEduCls_SynEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objCurrEduCls_SynEN.IdCurrEduCls) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCurrEduCls_SynBL.CurrEduCls_SynDA.UpdateBySql2(objCurrEduCls_SynEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduCls_SynBL.ReFreshCache();

if (clsCurrEduCls_SynBL.relatedActions != null)
{
clsCurrEduCls_SynBL.relatedActions.UpdRelaTabDate(objCurrEduCls_SynEN.IdCurrEduCls, objCurrEduCls_SynEN.ModifyUserId);
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
 /// <param name = "objCurrEduCls_SynEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strWhereCond)
{
try
{
bool bolResult = clsCurrEduCls_SynBL.CurrEduCls_SynDA.UpdateBySqlWithCondition(objCurrEduCls_SynEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduCls_SynBL.ReFreshCache();

if (clsCurrEduCls_SynBL.relatedActions != null)
{
clsCurrEduCls_SynBL.relatedActions.UpdRelaTabDate(objCurrEduCls_SynEN.IdCurrEduCls, objCurrEduCls_SynEN.ModifyUserId);
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
 /// <param name = "objCurrEduCls_SynEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsCurrEduCls_SynBL.CurrEduCls_SynDA.UpdateBySqlWithConditionTransaction(objCurrEduCls_SynEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduCls_SynBL.ReFreshCache();

if (clsCurrEduCls_SynBL.relatedActions != null)
{
clsCurrEduCls_SynBL.relatedActions.UpdRelaTabDate(objCurrEduCls_SynEN.IdCurrEduCls, objCurrEduCls_SynEN.ModifyUserId);
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
 /// <param name = "strIdCurrEduCls">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsCurrEduCls_SynEN objCurrEduCls_SynEN)
{
try
{
int intRecNum = clsCurrEduCls_SynBL.CurrEduCls_SynDA.DelRecord(objCurrEduCls_SynEN.IdCurrEduCls);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduCls_SynBL.ReFreshCache();

if (clsCurrEduCls_SynBL.relatedActions != null)
{
clsCurrEduCls_SynBL.relatedActions.UpdRelaTabDate(objCurrEduCls_SynEN.IdCurrEduCls, objCurrEduCls_SynEN.ModifyUserId);
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
 /// <param name = "objCurrEduCls_SynENS">源对象</param>
 /// <param name = "objCurrEduCls_SynENT">目标对象</param>
 public static void CopyTo(this clsCurrEduCls_SynEN objCurrEduCls_SynENS, clsCurrEduCls_SynEN objCurrEduCls_SynENT)
{
try
{
objCurrEduCls_SynENT.IdCurrEduCls = objCurrEduCls_SynENS.IdCurrEduCls; //教学班流水号
objCurrEduCls_SynENT.CurrEduClsId = objCurrEduCls_SynENS.CurrEduClsId; //教学班Id
objCurrEduCls_SynENT.EduClsName = objCurrEduCls_SynENS.EduClsName; //教学班名
objCurrEduCls_SynENT.EduClsTypeId = objCurrEduCls_SynENS.EduClsTypeId; //教学班类型Id
objCurrEduCls_SynENT.CourseId = objCurrEduCls_SynENS.CourseId; //课程Id
objCurrEduCls_SynENT.TeachingSolutionId = objCurrEduCls_SynENS.TeachingSolutionId; //教学方案Id
objCurrEduCls_SynENT.IdXzCollege = objCurrEduCls_SynENS.IdXzCollege; //学院流水号
objCurrEduCls_SynENT.IdMajor = objCurrEduCls_SynENS.IdMajor; //专业流水号
objCurrEduCls_SynENT.IdEduWay = objCurrEduCls_SynENS.IdEduWay; //教学方式流水号
objCurrEduCls_SynENT.IdClassRoomType = objCurrEduCls_SynENS.IdClassRoomType; //教室类型流水号
objCurrEduCls_SynENT.TotalLessonQty = objCurrEduCls_SynENS.TotalLessonQty; //总课时数
objCurrEduCls_SynENT.MaxStuQty = objCurrEduCls_SynENS.MaxStuQty; //最大学生数
objCurrEduCls_SynENT.CurrentStuQty = objCurrEduCls_SynENS.CurrentStuQty; //当前学生数
objCurrEduCls_SynENT.WeekQty = objCurrEduCls_SynENS.WeekQty; //总周数
objCurrEduCls_SynENT.ScheUnitPW = objCurrEduCls_SynENS.ScheUnitPW; //周排课次数
objCurrEduCls_SynENT.WeekStatusId = objCurrEduCls_SynENS.WeekStatusId; //周状态编号(单,双,全周)
objCurrEduCls_SynENT.CustomerWeek = objCurrEduCls_SynENS.CustomerWeek; //自定义上课周
objCurrEduCls_SynENT.IsCompleteScore = objCurrEduCls_SynENS.IsCompleteScore; //是否成绩齐全
objCurrEduCls_SynENT.IdExecPlan = objCurrEduCls_SynENS.IdExecPlan; //执行计划流水号
objCurrEduCls_SynENT.LessonQtyPerWeek = objCurrEduCls_SynENS.LessonQtyPerWeek; //周课时数
objCurrEduCls_SynENT.Mark = objCurrEduCls_SynENS.Mark; //获得学分
objCurrEduCls_SynENT.CheckClassRoom = objCurrEduCls_SynENS.CheckClassRoom; //检查教室结果
objCurrEduCls_SynENT.CheckAdminCls = objCurrEduCls_SynENS.CheckAdminCls; //检查行政班结果
objCurrEduCls_SynENT.CheckTeacher = objCurrEduCls_SynENS.CheckTeacher; //检查教师结果
objCurrEduCls_SynENT.EditLocked = objCurrEduCls_SynENS.EditLocked; //编辑锁定
objCurrEduCls_SynENT.Sched = objCurrEduCls_SynENS.Sched; //是否排课
objCurrEduCls_SynENT.IdUniZone = objCurrEduCls_SynENS.IdUniZone; //校区流水号
objCurrEduCls_SynENT.Locked = objCurrEduCls_SynENS.Locked; //锁定状态
objCurrEduCls_SynENT.IdGradeBase = objCurrEduCls_SynENS.IdGradeBase; //年级流水号
objCurrEduCls_SynENT.IsEffective = objCurrEduCls_SynENS.IsEffective; //是否有效
objCurrEduCls_SynENT.IsForPaperReading = objCurrEduCls_SynENS.IsForPaperReading; //是否参与论文阅读
objCurrEduCls_SynENT.IsUnDeterminedClsRm = objCurrEduCls_SynENS.IsUnDeterminedClsRm; //是否待定教室
objCurrEduCls_SynENT.SchoolYear = objCurrEduCls_SynENS.SchoolYear; //学年
objCurrEduCls_SynENT.SchoolTerm = objCurrEduCls_SynENS.SchoolTerm; //学期
objCurrEduCls_SynENT.ArrangeCourseMemo = objCurrEduCls_SynENS.ArrangeCourseMemo; //排课备注
objCurrEduCls_SynENT.IdCourseType = objCurrEduCls_SynENS.IdCourseType; //课程类型流水号
objCurrEduCls_SynENT.ExportDate = objCurrEduCls_SynENS.ExportDate; //导出日期
objCurrEduCls_SynENT.IsDegree = objCurrEduCls_SynENS.IsDegree; //是否学位课
objCurrEduCls_SynENT.IdScoreType = objCurrEduCls_SynENS.IdScoreType; //成绩类型流水号
objCurrEduCls_SynENT.GetScoreWayId = objCurrEduCls_SynENS.GetScoreWayId; //获得成绩方式Id
objCurrEduCls_SynENT.IsProportionalCtrl = objCurrEduCls_SynENS.IsProportionalCtrl; //是否比例控制
objCurrEduCls_SynENT.IdExamType = objCurrEduCls_SynENS.IdExamType; //考试方式流水号
objCurrEduCls_SynENT.ExamPortion = objCurrEduCls_SynENS.ExamPortion; //平时成绩所占比例
objCurrEduCls_SynENT.MidExamScorePortion = objCurrEduCls_SynENS.MidExamScorePortion; //期末成绩所占比例
objCurrEduCls_SynENT.IsClearScore = objCurrEduCls_SynENS.IsClearScore; //是否重录成绩
objCurrEduCls_SynENT.IsGeneratePwd = objCurrEduCls_SynENS.IsGeneratePwd; //是否生成口令
objCurrEduCls_SynENT.GeneratePwdDate = objCurrEduCls_SynENS.GeneratePwdDate; //生成口令时间
objCurrEduCls_SynENT.IsExportToGP = objCurrEduCls_SynENS.IsExportToGP; //是否导出到平台
objCurrEduCls_SynENT.IsExportToGPWeb = objCurrEduCls_SynENS.IsExportToGPWeb; //是否导出到Web平台
objCurrEduCls_SynENT.IsReservedDecimal = objCurrEduCls_SynENS.IsReservedDecimal; //是否保留小数
objCurrEduCls_SynENT.ExamTime = objCurrEduCls_SynENS.ExamTime; //考试时间
objCurrEduCls_SynENT.CheckState = objCurrEduCls_SynENS.CheckState; //检查状态
objCurrEduCls_SynENT.CheckDate = objCurrEduCls_SynENS.CheckDate; //检查日期
objCurrEduCls_SynENT.IdEduClassInPk = objCurrEduCls_SynENS.IdEduClassInPk; //id_EduClassInPk
objCurrEduCls_SynENT.PkWeekTime = objCurrEduCls_SynENS.PkWeekTime; //排课时间
objCurrEduCls_SynENT.PkClassRooms = objCurrEduCls_SynENS.PkClassRooms; //排课教室
objCurrEduCls_SynENT.BeginWeek = objCurrEduCls_SynENS.BeginWeek; //开始周
objCurrEduCls_SynENT.TeacherNames = objCurrEduCls_SynENS.TeacherNames; //教师姓名
objCurrEduCls_SynENT.IsSynch = objCurrEduCls_SynENS.IsSynch; //是否同步
objCurrEduCls_SynENT.SynchDate = objCurrEduCls_SynENS.SynchDate; //同步日期
objCurrEduCls_SynENT.ModifyDate = objCurrEduCls_SynENS.ModifyDate; //修改日期
objCurrEduCls_SynENT.ModifyUserId = objCurrEduCls_SynENS.ModifyUserId; //修改人
objCurrEduCls_SynENT.Memo = objCurrEduCls_SynENS.Memo; //备注
objCurrEduCls_SynENT.SignInDate = objCurrEduCls_SynENS.SignInDate; //签入时间
objCurrEduCls_SynENT.SignInStateID = objCurrEduCls_SynENS.SignInStateID; //签入状态表流水号
objCurrEduCls_SynENT.SignInUser = objCurrEduCls_SynENS.SignInUser; //签入人
objCurrEduCls_SynENT.SynchToWebUser = objCurrEduCls_SynENS.SynchToWebUser; //同步Web用户
objCurrEduCls_SynENT.IsSynchToWeb = objCurrEduCls_SynENS.IsSynchToWeb; //是否同步Web
objCurrEduCls_SynENT.SynchToWebDate = objCurrEduCls_SynENS.SynchToWebDate; //同步Web日期
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
 /// <param name = "objCurrEduCls_SynENS">源对象</param>
 /// <returns>目标对象=>clsCurrEduCls_SynEN:objCurrEduCls_SynENT</returns>
 public static clsCurrEduCls_SynEN CopyTo(this clsCurrEduCls_SynEN objCurrEduCls_SynENS)
{
try
{
 clsCurrEduCls_SynEN objCurrEduCls_SynENT = new clsCurrEduCls_SynEN()
{
IdCurrEduCls = objCurrEduCls_SynENS.IdCurrEduCls, //教学班流水号
CurrEduClsId = objCurrEduCls_SynENS.CurrEduClsId, //教学班Id
EduClsName = objCurrEduCls_SynENS.EduClsName, //教学班名
EduClsTypeId = objCurrEduCls_SynENS.EduClsTypeId, //教学班类型Id
CourseId = objCurrEduCls_SynENS.CourseId, //课程Id
TeachingSolutionId = objCurrEduCls_SynENS.TeachingSolutionId, //教学方案Id
IdXzCollege = objCurrEduCls_SynENS.IdXzCollege, //学院流水号
IdMajor = objCurrEduCls_SynENS.IdMajor, //专业流水号
IdEduWay = objCurrEduCls_SynENS.IdEduWay, //教学方式流水号
IdClassRoomType = objCurrEduCls_SynENS.IdClassRoomType, //教室类型流水号
TotalLessonQty = objCurrEduCls_SynENS.TotalLessonQty, //总课时数
MaxStuQty = objCurrEduCls_SynENS.MaxStuQty, //最大学生数
CurrentStuQty = objCurrEduCls_SynENS.CurrentStuQty, //当前学生数
WeekQty = objCurrEduCls_SynENS.WeekQty, //总周数
ScheUnitPW = objCurrEduCls_SynENS.ScheUnitPW, //周排课次数
WeekStatusId = objCurrEduCls_SynENS.WeekStatusId, //周状态编号(单,双,全周)
CustomerWeek = objCurrEduCls_SynENS.CustomerWeek, //自定义上课周
IsCompleteScore = objCurrEduCls_SynENS.IsCompleteScore, //是否成绩齐全
IdExecPlan = objCurrEduCls_SynENS.IdExecPlan, //执行计划流水号
LessonQtyPerWeek = objCurrEduCls_SynENS.LessonQtyPerWeek, //周课时数
Mark = objCurrEduCls_SynENS.Mark, //获得学分
CheckClassRoom = objCurrEduCls_SynENS.CheckClassRoom, //检查教室结果
CheckAdminCls = objCurrEduCls_SynENS.CheckAdminCls, //检查行政班结果
CheckTeacher = objCurrEduCls_SynENS.CheckTeacher, //检查教师结果
EditLocked = objCurrEduCls_SynENS.EditLocked, //编辑锁定
Sched = objCurrEduCls_SynENS.Sched, //是否排课
IdUniZone = objCurrEduCls_SynENS.IdUniZone, //校区流水号
Locked = objCurrEduCls_SynENS.Locked, //锁定状态
IdGradeBase = objCurrEduCls_SynENS.IdGradeBase, //年级流水号
IsEffective = objCurrEduCls_SynENS.IsEffective, //是否有效
IsForPaperReading = objCurrEduCls_SynENS.IsForPaperReading, //是否参与论文阅读
IsUnDeterminedClsRm = objCurrEduCls_SynENS.IsUnDeterminedClsRm, //是否待定教室
SchoolYear = objCurrEduCls_SynENS.SchoolYear, //学年
SchoolTerm = objCurrEduCls_SynENS.SchoolTerm, //学期
ArrangeCourseMemo = objCurrEduCls_SynENS.ArrangeCourseMemo, //排课备注
IdCourseType = objCurrEduCls_SynENS.IdCourseType, //课程类型流水号
ExportDate = objCurrEduCls_SynENS.ExportDate, //导出日期
IsDegree = objCurrEduCls_SynENS.IsDegree, //是否学位课
IdScoreType = objCurrEduCls_SynENS.IdScoreType, //成绩类型流水号
GetScoreWayId = objCurrEduCls_SynENS.GetScoreWayId, //获得成绩方式Id
IsProportionalCtrl = objCurrEduCls_SynENS.IsProportionalCtrl, //是否比例控制
IdExamType = objCurrEduCls_SynENS.IdExamType, //考试方式流水号
ExamPortion = objCurrEduCls_SynENS.ExamPortion, //平时成绩所占比例
MidExamScorePortion = objCurrEduCls_SynENS.MidExamScorePortion, //期末成绩所占比例
IsClearScore = objCurrEduCls_SynENS.IsClearScore, //是否重录成绩
IsGeneratePwd = objCurrEduCls_SynENS.IsGeneratePwd, //是否生成口令
GeneratePwdDate = objCurrEduCls_SynENS.GeneratePwdDate, //生成口令时间
IsExportToGP = objCurrEduCls_SynENS.IsExportToGP, //是否导出到平台
IsExportToGPWeb = objCurrEduCls_SynENS.IsExportToGPWeb, //是否导出到Web平台
IsReservedDecimal = objCurrEduCls_SynENS.IsReservedDecimal, //是否保留小数
ExamTime = objCurrEduCls_SynENS.ExamTime, //考试时间
CheckState = objCurrEduCls_SynENS.CheckState, //检查状态
CheckDate = objCurrEduCls_SynENS.CheckDate, //检查日期
IdEduClassInPk = objCurrEduCls_SynENS.IdEduClassInPk, //id_EduClassInPk
PkWeekTime = objCurrEduCls_SynENS.PkWeekTime, //排课时间
PkClassRooms = objCurrEduCls_SynENS.PkClassRooms, //排课教室
BeginWeek = objCurrEduCls_SynENS.BeginWeek, //开始周
TeacherNames = objCurrEduCls_SynENS.TeacherNames, //教师姓名
IsSynch = objCurrEduCls_SynENS.IsSynch, //是否同步
SynchDate = objCurrEduCls_SynENS.SynchDate, //同步日期
ModifyDate = objCurrEduCls_SynENS.ModifyDate, //修改日期
ModifyUserId = objCurrEduCls_SynENS.ModifyUserId, //修改人
Memo = objCurrEduCls_SynENS.Memo, //备注
SignInDate = objCurrEduCls_SynENS.SignInDate, //签入时间
SignInStateID = objCurrEduCls_SynENS.SignInStateID, //签入状态表流水号
SignInUser = objCurrEduCls_SynENS.SignInUser, //签入人
SynchToWebUser = objCurrEduCls_SynENS.SynchToWebUser, //同步Web用户
IsSynchToWeb = objCurrEduCls_SynENS.IsSynchToWeb, //是否同步Web
SynchToWebDate = objCurrEduCls_SynENS.SynchToWebDate, //同步Web日期
};
 return objCurrEduCls_SynENT;
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
public static void CheckPropertyNew(this clsCurrEduCls_SynEN objCurrEduCls_SynEN)
{
 clsCurrEduCls_SynBL.CurrEduCls_SynDA.CheckPropertyNew(objCurrEduCls_SynEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsCurrEduCls_SynEN objCurrEduCls_SynEN)
{
 clsCurrEduCls_SynBL.CurrEduCls_SynDA.CheckProperty4Condition(objCurrEduCls_SynEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCurrEduCls_SynEN objCurrEduCls_SynCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objCurrEduCls_SynCond.dicFldComparisonOp[conCurrEduCls_Syn.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.IdCurrEduCls, objCurrEduCls_SynCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.CurrEduClsId) == true)
{
string strComparisonOpCurrEduClsId = objCurrEduCls_SynCond.dicFldComparisonOp[conCurrEduCls_Syn.CurrEduClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.CurrEduClsId, objCurrEduCls_SynCond.CurrEduClsId, strComparisonOpCurrEduClsId);
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.EduClsName) == true)
{
string strComparisonOpEduClsName = objCurrEduCls_SynCond.dicFldComparisonOp[conCurrEduCls_Syn.EduClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.EduClsName, objCurrEduCls_SynCond.EduClsName, strComparisonOpEduClsName);
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.EduClsTypeId) == true)
{
string strComparisonOpEduClsTypeId = objCurrEduCls_SynCond.dicFldComparisonOp[conCurrEduCls_Syn.EduClsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.EduClsTypeId, objCurrEduCls_SynCond.EduClsTypeId, strComparisonOpEduClsTypeId);
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.CourseId) == true)
{
string strComparisonOpCourseId = objCurrEduCls_SynCond.dicFldComparisonOp[conCurrEduCls_Syn.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.CourseId, objCurrEduCls_SynCond.CourseId, strComparisonOpCourseId);
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.TeachingSolutionId) == true)
{
string strComparisonOpTeachingSolutionId = objCurrEduCls_SynCond.dicFldComparisonOp[conCurrEduCls_Syn.TeachingSolutionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.TeachingSolutionId, objCurrEduCls_SynCond.TeachingSolutionId, strComparisonOpTeachingSolutionId);
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objCurrEduCls_SynCond.dicFldComparisonOp[conCurrEduCls_Syn.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.IdXzCollege, objCurrEduCls_SynCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.IdMajor) == true)
{
string strComparisonOpIdMajor = objCurrEduCls_SynCond.dicFldComparisonOp[conCurrEduCls_Syn.IdMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.IdMajor, objCurrEduCls_SynCond.IdMajor, strComparisonOpIdMajor);
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.IdEduWay) == true)
{
string strComparisonOpIdEduWay = objCurrEduCls_SynCond.dicFldComparisonOp[conCurrEduCls_Syn.IdEduWay];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.IdEduWay, objCurrEduCls_SynCond.IdEduWay, strComparisonOpIdEduWay);
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.IdClassRoomType) == true)
{
string strComparisonOpIdClassRoomType = objCurrEduCls_SynCond.dicFldComparisonOp[conCurrEduCls_Syn.IdClassRoomType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.IdClassRoomType, objCurrEduCls_SynCond.IdClassRoomType, strComparisonOpIdClassRoomType);
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.TotalLessonQty) == true)
{
string strComparisonOpTotalLessonQty = objCurrEduCls_SynCond.dicFldComparisonOp[conCurrEduCls_Syn.TotalLessonQty];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduCls_Syn.TotalLessonQty, objCurrEduCls_SynCond.TotalLessonQty, strComparisonOpTotalLessonQty);
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.MaxStuQty) == true)
{
string strComparisonOpMaxStuQty = objCurrEduCls_SynCond.dicFldComparisonOp[conCurrEduCls_Syn.MaxStuQty];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduCls_Syn.MaxStuQty, objCurrEduCls_SynCond.MaxStuQty, strComparisonOpMaxStuQty);
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.CurrentStuQty) == true)
{
string strComparisonOpCurrentStuQty = objCurrEduCls_SynCond.dicFldComparisonOp[conCurrEduCls_Syn.CurrentStuQty];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduCls_Syn.CurrentStuQty, objCurrEduCls_SynCond.CurrentStuQty, strComparisonOpCurrentStuQty);
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.WeekQty) == true)
{
string strComparisonOpWeekQty = objCurrEduCls_SynCond.dicFldComparisonOp[conCurrEduCls_Syn.WeekQty];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduCls_Syn.WeekQty, objCurrEduCls_SynCond.WeekQty, strComparisonOpWeekQty);
}
//数据类型short(smallint)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.WeekStatusId) == true)
{
string strComparisonOpWeekStatusId = objCurrEduCls_SynCond.dicFldComparisonOp[conCurrEduCls_Syn.WeekStatusId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.WeekStatusId, objCurrEduCls_SynCond.WeekStatusId, strComparisonOpWeekStatusId);
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.CustomerWeek) == true)
{
string strComparisonOpCustomerWeek = objCurrEduCls_SynCond.dicFldComparisonOp[conCurrEduCls_Syn.CustomerWeek];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.CustomerWeek, objCurrEduCls_SynCond.CustomerWeek, strComparisonOpCustomerWeek);
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.IsCompleteScore) == true)
{
if (objCurrEduCls_SynCond.IsCompleteScore == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls_Syn.IsCompleteScore);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls_Syn.IsCompleteScore);
}
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.IdExecPlan) == true)
{
string strComparisonOpIdExecPlan = objCurrEduCls_SynCond.dicFldComparisonOp[conCurrEduCls_Syn.IdExecPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.IdExecPlan, objCurrEduCls_SynCond.IdExecPlan, strComparisonOpIdExecPlan);
}
//数据类型short(smallint)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.Mark) == true)
{
string strComparisonOpMark = objCurrEduCls_SynCond.dicFldComparisonOp[conCurrEduCls_Syn.Mark];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduCls_Syn.Mark, objCurrEduCls_SynCond.Mark, strComparisonOpMark);
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.CheckClassRoom) == true)
{
string strComparisonOpCheckClassRoom = objCurrEduCls_SynCond.dicFldComparisonOp[conCurrEduCls_Syn.CheckClassRoom];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.CheckClassRoom, objCurrEduCls_SynCond.CheckClassRoom, strComparisonOpCheckClassRoom);
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.CheckAdminCls) == true)
{
string strComparisonOpCheckAdminCls = objCurrEduCls_SynCond.dicFldComparisonOp[conCurrEduCls_Syn.CheckAdminCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.CheckAdminCls, objCurrEduCls_SynCond.CheckAdminCls, strComparisonOpCheckAdminCls);
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.CheckTeacher) == true)
{
string strComparisonOpCheckTeacher = objCurrEduCls_SynCond.dicFldComparisonOp[conCurrEduCls_Syn.CheckTeacher];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.CheckTeacher, objCurrEduCls_SynCond.CheckTeacher, strComparisonOpCheckTeacher);
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.EditLocked) == true)
{
if (objCurrEduCls_SynCond.EditLocked == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls_Syn.EditLocked);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls_Syn.EditLocked);
}
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.Sched) == true)
{
if (objCurrEduCls_SynCond.Sched == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls_Syn.Sched);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls_Syn.Sched);
}
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.IdUniZone) == true)
{
string strComparisonOpIdUniZone = objCurrEduCls_SynCond.dicFldComparisonOp[conCurrEduCls_Syn.IdUniZone];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.IdUniZone, objCurrEduCls_SynCond.IdUniZone, strComparisonOpIdUniZone);
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.Locked) == true)
{
if (objCurrEduCls_SynCond.Locked == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls_Syn.Locked);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls_Syn.Locked);
}
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.IdGradeBase) == true)
{
string strComparisonOpIdGradeBase = objCurrEduCls_SynCond.dicFldComparisonOp[conCurrEduCls_Syn.IdGradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.IdGradeBase, objCurrEduCls_SynCond.IdGradeBase, strComparisonOpIdGradeBase);
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.IsEffective) == true)
{
if (objCurrEduCls_SynCond.IsEffective == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls_Syn.IsEffective);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls_Syn.IsEffective);
}
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.IsForPaperReading) == true)
{
if (objCurrEduCls_SynCond.IsForPaperReading == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls_Syn.IsForPaperReading);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls_Syn.IsForPaperReading);
}
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.IsUnDeterminedClsRm) == true)
{
if (objCurrEduCls_SynCond.IsUnDeterminedClsRm == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls_Syn.IsUnDeterminedClsRm);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls_Syn.IsUnDeterminedClsRm);
}
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.SchoolYear) == true)
{
string strComparisonOpSchoolYear = objCurrEduCls_SynCond.dicFldComparisonOp[conCurrEduCls_Syn.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.SchoolYear, objCurrEduCls_SynCond.SchoolYear, strComparisonOpSchoolYear);
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.SchoolTerm) == true)
{
string strComparisonOpSchoolTerm = objCurrEduCls_SynCond.dicFldComparisonOp[conCurrEduCls_Syn.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.SchoolTerm, objCurrEduCls_SynCond.SchoolTerm, strComparisonOpSchoolTerm);
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.ArrangeCourseMemo) == true)
{
string strComparisonOpArrangeCourseMemo = objCurrEduCls_SynCond.dicFldComparisonOp[conCurrEduCls_Syn.ArrangeCourseMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.ArrangeCourseMemo, objCurrEduCls_SynCond.ArrangeCourseMemo, strComparisonOpArrangeCourseMemo);
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.IdCourseType) == true)
{
string strComparisonOpIdCourseType = objCurrEduCls_SynCond.dicFldComparisonOp[conCurrEduCls_Syn.IdCourseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.IdCourseType, objCurrEduCls_SynCond.IdCourseType, strComparisonOpIdCourseType);
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.ExportDate) == true)
{
string strComparisonOpExportDate = objCurrEduCls_SynCond.dicFldComparisonOp[conCurrEduCls_Syn.ExportDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.ExportDate, objCurrEduCls_SynCond.ExportDate, strComparisonOpExportDate);
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.IsDegree) == true)
{
if (objCurrEduCls_SynCond.IsDegree == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls_Syn.IsDegree);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls_Syn.IsDegree);
}
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.IdScoreType) == true)
{
string strComparisonOpIdScoreType = objCurrEduCls_SynCond.dicFldComparisonOp[conCurrEduCls_Syn.IdScoreType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.IdScoreType, objCurrEduCls_SynCond.IdScoreType, strComparisonOpIdScoreType);
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.GetScoreWayId) == true)
{
string strComparisonOpGetScoreWayId = objCurrEduCls_SynCond.dicFldComparisonOp[conCurrEduCls_Syn.GetScoreWayId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.GetScoreWayId, objCurrEduCls_SynCond.GetScoreWayId, strComparisonOpGetScoreWayId);
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.IsProportionalCtrl) == true)
{
if (objCurrEduCls_SynCond.IsProportionalCtrl == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls_Syn.IsProportionalCtrl);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls_Syn.IsProportionalCtrl);
}
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.IdExamType) == true)
{
string strComparisonOpIdExamType = objCurrEduCls_SynCond.dicFldComparisonOp[conCurrEduCls_Syn.IdExamType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.IdExamType, objCurrEduCls_SynCond.IdExamType, strComparisonOpIdExamType);
}
//数据类型short(smallint)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
//数据类型short(smallint)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.IsClearScore) == true)
{
if (objCurrEduCls_SynCond.IsClearScore == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls_Syn.IsClearScore);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls_Syn.IsClearScore);
}
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.IsGeneratePwd) == true)
{
if (objCurrEduCls_SynCond.IsGeneratePwd == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls_Syn.IsGeneratePwd);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls_Syn.IsGeneratePwd);
}
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.GeneratePwdDate) == true)
{
string strComparisonOpGeneratePwdDate = objCurrEduCls_SynCond.dicFldComparisonOp[conCurrEduCls_Syn.GeneratePwdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.GeneratePwdDate, objCurrEduCls_SynCond.GeneratePwdDate, strComparisonOpGeneratePwdDate);
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.IsExportToGP) == true)
{
if (objCurrEduCls_SynCond.IsExportToGP == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls_Syn.IsExportToGP);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls_Syn.IsExportToGP);
}
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.IsExportToGPWeb) == true)
{
if (objCurrEduCls_SynCond.IsExportToGPWeb == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls_Syn.IsExportToGPWeb);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls_Syn.IsExportToGPWeb);
}
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.IsReservedDecimal) == true)
{
if (objCurrEduCls_SynCond.IsReservedDecimal == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls_Syn.IsReservedDecimal);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls_Syn.IsReservedDecimal);
}
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.ExamTime) == true)
{
string strComparisonOpExamTime = objCurrEduCls_SynCond.dicFldComparisonOp[conCurrEduCls_Syn.ExamTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.ExamTime, objCurrEduCls_SynCond.ExamTime, strComparisonOpExamTime);
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.CheckState) == true)
{
if (objCurrEduCls_SynCond.CheckState == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls_Syn.CheckState);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls_Syn.CheckState);
}
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.CheckDate) == true)
{
string strComparisonOpCheckDate = objCurrEduCls_SynCond.dicFldComparisonOp[conCurrEduCls_Syn.CheckDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.CheckDate, objCurrEduCls_SynCond.CheckDate, strComparisonOpCheckDate);
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.IdEduClassInPk) == true)
{
string strComparisonOpIdEduClassInPk = objCurrEduCls_SynCond.dicFldComparisonOp[conCurrEduCls_Syn.IdEduClassInPk];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.IdEduClassInPk, objCurrEduCls_SynCond.IdEduClassInPk, strComparisonOpIdEduClassInPk);
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.PkWeekTime) == true)
{
string strComparisonOpPkWeekTime = objCurrEduCls_SynCond.dicFldComparisonOp[conCurrEduCls_Syn.PkWeekTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.PkWeekTime, objCurrEduCls_SynCond.PkWeekTime, strComparisonOpPkWeekTime);
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.PkClassRooms) == true)
{
string strComparisonOpPkClassRooms = objCurrEduCls_SynCond.dicFldComparisonOp[conCurrEduCls_Syn.PkClassRooms];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.PkClassRooms, objCurrEduCls_SynCond.PkClassRooms, strComparisonOpPkClassRooms);
}
//数据类型short(smallint)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.TeacherNames) == true)
{
string strComparisonOpTeacherNames = objCurrEduCls_SynCond.dicFldComparisonOp[conCurrEduCls_Syn.TeacherNames];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.TeacherNames, objCurrEduCls_SynCond.TeacherNames, strComparisonOpTeacherNames);
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.IsSynch) == true)
{
if (objCurrEduCls_SynCond.IsSynch == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls_Syn.IsSynch);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls_Syn.IsSynch);
}
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.SynchDate) == true)
{
string strComparisonOpSynchDate = objCurrEduCls_SynCond.dicFldComparisonOp[conCurrEduCls_Syn.SynchDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.SynchDate, objCurrEduCls_SynCond.SynchDate, strComparisonOpSynchDate);
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.ModifyDate) == true)
{
string strComparisonOpModifyDate = objCurrEduCls_SynCond.dicFldComparisonOp[conCurrEduCls_Syn.ModifyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.ModifyDate, objCurrEduCls_SynCond.ModifyDate, strComparisonOpModifyDate);
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.ModifyUserId) == true)
{
string strComparisonOpModifyUserId = objCurrEduCls_SynCond.dicFldComparisonOp[conCurrEduCls_Syn.ModifyUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.ModifyUserId, objCurrEduCls_SynCond.ModifyUserId, strComparisonOpModifyUserId);
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.Memo) == true)
{
string strComparisonOpMemo = objCurrEduCls_SynCond.dicFldComparisonOp[conCurrEduCls_Syn.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.Memo, objCurrEduCls_SynCond.Memo, strComparisonOpMemo);
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.SignInDate) == true)
{
string strComparisonOpSignInDate = objCurrEduCls_SynCond.dicFldComparisonOp[conCurrEduCls_Syn.SignInDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.SignInDate, objCurrEduCls_SynCond.SignInDate, strComparisonOpSignInDate);
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.SignInStateID) == true)
{
string strComparisonOpSignInStateID = objCurrEduCls_SynCond.dicFldComparisonOp[conCurrEduCls_Syn.SignInStateID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.SignInStateID, objCurrEduCls_SynCond.SignInStateID, strComparisonOpSignInStateID);
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.SignInUser) == true)
{
string strComparisonOpSignInUser = objCurrEduCls_SynCond.dicFldComparisonOp[conCurrEduCls_Syn.SignInUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.SignInUser, objCurrEduCls_SynCond.SignInUser, strComparisonOpSignInUser);
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.SynchToWebUser) == true)
{
string strComparisonOpSynchToWebUser = objCurrEduCls_SynCond.dicFldComparisonOp[conCurrEduCls_Syn.SynchToWebUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.SynchToWebUser, objCurrEduCls_SynCond.SynchToWebUser, strComparisonOpSynchToWebUser);
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.IsSynchToWeb) == true)
{
if (objCurrEduCls_SynCond.IsSynchToWeb == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls_Syn.IsSynchToWeb);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls_Syn.IsSynchToWeb);
}
}
if (objCurrEduCls_SynCond.IsUpdated(conCurrEduCls_Syn.SynchToWebDate) == true)
{
string strComparisonOpSynchToWebDate = objCurrEduCls_SynCond.dicFldComparisonOp[conCurrEduCls_Syn.SynchToWebDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.SynchToWebDate, objCurrEduCls_SynCond.SynchToWebDate, strComparisonOpSynchToWebDate);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_CurrEduCls_Syn
{
public virtual bool UpdRelaTabDate(string strIdCurrEduCls, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 当前教学班_动态(CurrEduCls_Syn)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsCurrEduCls_SynBL
{
public static RelatedActions_CurrEduCls_Syn relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsCurrEduCls_SynDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsCurrEduCls_SynDA CurrEduCls_SynDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsCurrEduCls_SynDA();
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
 public clsCurrEduCls_SynBL()
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
if (string.IsNullOrEmpty(clsCurrEduCls_SynEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCurrEduCls_SynEN._ConnectString);
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
public static DataTable GetDataTable_CurrEduCls_Syn(string strWhereCond)
{
DataTable objDT;
try
{
objDT = CurrEduCls_SynDA.GetDataTable_CurrEduCls_Syn(strWhereCond);
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
objDT = CurrEduCls_SynDA.GetDataTable(strWhereCond);
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
objDT = CurrEduCls_SynDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = CurrEduCls_SynDA.GetDataTable(strWhereCond, strTabName);
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
objDT = CurrEduCls_SynDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = CurrEduCls_SynDA.GetDataTable_Top(objTopPara);
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
objDT = CurrEduCls_SynDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = CurrEduCls_SynDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = CurrEduCls_SynDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdCurrEduClsLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsCurrEduCls_SynEN> GetObjLstByIdCurrEduClsLst(List<string> arrIdCurrEduClsLst)
{
List<clsCurrEduCls_SynEN> arrObjLst = new List<clsCurrEduCls_SynEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdCurrEduClsLst, true);
 string strWhereCond = string.Format("IdCurrEduCls in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduCls_SynEN objCurrEduCls_SynEN = new clsCurrEduCls_SynEN();
try
{
objCurrEduCls_SynEN.IdCurrEduCls = objRow[conCurrEduCls_Syn.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduCls_SynEN.CurrEduClsId = objRow[conCurrEduCls_Syn.CurrEduClsId].ToString().Trim(); //教学班Id
objCurrEduCls_SynEN.EduClsName = objRow[conCurrEduCls_Syn.EduClsName] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.EduClsName].ToString().Trim(); //教学班名
objCurrEduCls_SynEN.EduClsTypeId = objRow[conCurrEduCls_Syn.EduClsTypeId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.EduClsTypeId].ToString().Trim(); //教学班类型Id
objCurrEduCls_SynEN.CourseId = objRow[conCurrEduCls_Syn.CourseId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CourseId].ToString().Trim(); //课程Id
objCurrEduCls_SynEN.TeachingSolutionId = objRow[conCurrEduCls_Syn.TeachingSolutionId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCurrEduCls_SynEN.IdXzCollege = objRow[conCurrEduCls_Syn.IdXzCollege] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdXzCollege].ToString().Trim(); //学院流水号
objCurrEduCls_SynEN.IdMajor = objRow[conCurrEduCls_Syn.IdMajor].ToString().Trim(); //专业流水号
objCurrEduCls_SynEN.IdEduWay = objRow[conCurrEduCls_Syn.IdEduWay] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdEduWay].ToString().Trim(); //教学方式流水号
objCurrEduCls_SynEN.IdClassRoomType = objRow[conCurrEduCls_Syn.IdClassRoomType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdClassRoomType].ToString().Trim(); //教室类型流水号
objCurrEduCls_SynEN.TotalLessonQty = objRow[conCurrEduCls_Syn.TotalLessonQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls_Syn.TotalLessonQty].ToString().Trim()); //总课时数
objCurrEduCls_SynEN.MaxStuQty = objRow[conCurrEduCls_Syn.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls_Syn.MaxStuQty].ToString().Trim()); //最大学生数
objCurrEduCls_SynEN.CurrentStuQty = objRow[conCurrEduCls_Syn.CurrentStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls_Syn.CurrentStuQty].ToString().Trim()); //当前学生数
objCurrEduCls_SynEN.WeekQty = objRow[conCurrEduCls_Syn.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls_Syn.WeekQty].ToString().Trim()); //总周数
objCurrEduCls_SynEN.ScheUnitPW = objRow[conCurrEduCls_Syn.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.ScheUnitPW].ToString().Trim()); //周排课次数
objCurrEduCls_SynEN.WeekStatusId = objRow[conCurrEduCls_Syn.WeekStatusId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objCurrEduCls_SynEN.CustomerWeek = objRow[conCurrEduCls_Syn.CustomerWeek] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CustomerWeek].ToString().Trim(); //自定义上课周
objCurrEduCls_SynEN.IsCompleteScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsCompleteScore].ToString().Trim()); //是否成绩齐全
objCurrEduCls_SynEN.IdExecPlan = objRow[conCurrEduCls_Syn.IdExecPlan] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdExecPlan].ToString().Trim(); //执行计划流水号
objCurrEduCls_SynEN.LessonQtyPerWeek = objRow[conCurrEduCls_Syn.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.LessonQtyPerWeek].ToString().Trim()); //周课时数
objCurrEduCls_SynEN.Mark = objRow[conCurrEduCls_Syn.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduCls_Syn.Mark].ToString().Trim()); //获得学分
objCurrEduCls_SynEN.CheckClassRoom = objRow[conCurrEduCls_Syn.CheckClassRoom] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckClassRoom].ToString().Trim(); //检查教室结果
objCurrEduCls_SynEN.CheckAdminCls = objRow[conCurrEduCls_Syn.CheckAdminCls] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckAdminCls].ToString().Trim(); //检查行政班结果
objCurrEduCls_SynEN.CheckTeacher = objRow[conCurrEduCls_Syn.CheckTeacher] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckTeacher].ToString().Trim(); //检查教师结果
objCurrEduCls_SynEN.EditLocked = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.EditLocked].ToString().Trim()); //编辑锁定
objCurrEduCls_SynEN.Sched = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.Sched].ToString().Trim()); //是否排课
objCurrEduCls_SynEN.IdUniZone = objRow[conCurrEduCls_Syn.IdUniZone] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdUniZone].ToString().Trim(); //校区流水号
objCurrEduCls_SynEN.Locked = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.Locked].ToString().Trim()); //锁定状态
objCurrEduCls_SynEN.IdGradeBase = objRow[conCurrEduCls_Syn.IdGradeBase] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdGradeBase].ToString().Trim(); //年级流水号
objCurrEduCls_SynEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsEffective].ToString().Trim()); //是否有效
objCurrEduCls_SynEN.IsForPaperReading = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objCurrEduCls_SynEN.IsUnDeterminedClsRm = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsUnDeterminedClsRm].ToString().Trim()); //是否待定教室
objCurrEduCls_SynEN.SchoolYear = objRow[conCurrEduCls_Syn.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SchoolYear].ToString().Trim(); //学年
objCurrEduCls_SynEN.SchoolTerm = objRow[conCurrEduCls_Syn.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SchoolTerm].ToString().Trim(); //学期
objCurrEduCls_SynEN.ArrangeCourseMemo = objRow[conCurrEduCls_Syn.ArrangeCourseMemo] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ArrangeCourseMemo].ToString().Trim(); //排课备注
objCurrEduCls_SynEN.IdCourseType = objRow[conCurrEduCls_Syn.IdCourseType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdCourseType].ToString().Trim(); //课程类型流水号
objCurrEduCls_SynEN.ExportDate = objRow[conCurrEduCls_Syn.ExportDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ExportDate].ToString().Trim(); //导出日期
objCurrEduCls_SynEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsDegree].ToString().Trim()); //是否学位课
objCurrEduCls_SynEN.IdScoreType = objRow[conCurrEduCls_Syn.IdScoreType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdScoreType].ToString().Trim(); //成绩类型流水号
objCurrEduCls_SynEN.GetScoreWayId = objRow[conCurrEduCls_Syn.GetScoreWayId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objCurrEduCls_SynEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objCurrEduCls_SynEN.IdExamType = objRow[conCurrEduCls_Syn.IdExamType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdExamType].ToString().Trim(); //考试方式流水号
objCurrEduCls_SynEN.ExamPortion = objRow[conCurrEduCls_Syn.ExamPortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.ExamPortion].ToString().Trim()); //平时成绩所占比例
objCurrEduCls_SynEN.MidExamScorePortion = objRow[conCurrEduCls_Syn.MidExamScorePortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.MidExamScorePortion].ToString().Trim()); //期末成绩所占比例
objCurrEduCls_SynEN.IsClearScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsClearScore].ToString().Trim()); //是否重录成绩
objCurrEduCls_SynEN.IsGeneratePwd = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsGeneratePwd].ToString().Trim()); //是否生成口令
objCurrEduCls_SynEN.GeneratePwdDate = objRow[conCurrEduCls_Syn.GeneratePwdDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.GeneratePwdDate].ToString().Trim(); //生成口令时间
objCurrEduCls_SynEN.IsExportToGP = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsExportToGP].ToString().Trim()); //是否导出到平台
objCurrEduCls_SynEN.IsExportToGPWeb = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsExportToGPWeb].ToString().Trim()); //是否导出到Web平台
objCurrEduCls_SynEN.IsReservedDecimal = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsReservedDecimal].ToString().Trim()); //是否保留小数
objCurrEduCls_SynEN.ExamTime = objRow[conCurrEduCls_Syn.ExamTime] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ExamTime].ToString().Trim(); //考试时间
objCurrEduCls_SynEN.CheckState = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.CheckState].ToString().Trim()); //检查状态
objCurrEduCls_SynEN.CheckDate = objRow[conCurrEduCls_Syn.CheckDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckDate].ToString().Trim(); //检查日期
objCurrEduCls_SynEN.IdEduClassInPk = objRow[conCurrEduCls_Syn.IdEduClassInPk] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdEduClassInPk].ToString().Trim(); //id_EduClassInPk
objCurrEduCls_SynEN.PkWeekTime = objRow[conCurrEduCls_Syn.PkWeekTime] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.PkWeekTime].ToString().Trim(); //排课时间
objCurrEduCls_SynEN.PkClassRooms = objRow[conCurrEduCls_Syn.PkClassRooms] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.PkClassRooms].ToString().Trim(); //排课教室
objCurrEduCls_SynEN.BeginWeek = objRow[conCurrEduCls_Syn.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.BeginWeek].ToString().Trim()); //开始周
objCurrEduCls_SynEN.TeacherNames = objRow[conCurrEduCls_Syn.TeacherNames] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.TeacherNames].ToString().Trim(); //教师姓名
objCurrEduCls_SynEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsSynch].ToString().Trim()); //是否同步
objCurrEduCls_SynEN.SynchDate = objRow[conCurrEduCls_Syn.SynchDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SynchDate].ToString().Trim(); //同步日期
objCurrEduCls_SynEN.ModifyDate = objRow[conCurrEduCls_Syn.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ModifyDate].ToString().Trim(); //修改日期
objCurrEduCls_SynEN.ModifyUserId = objRow[conCurrEduCls_Syn.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ModifyUserId].ToString().Trim(); //修改人
objCurrEduCls_SynEN.Memo = objRow[conCurrEduCls_Syn.Memo] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.Memo].ToString().Trim(); //备注
objCurrEduCls_SynEN.SignInDate = objRow[conCurrEduCls_Syn.SignInDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SignInDate].ToString().Trim(); //签入时间
objCurrEduCls_SynEN.SignInStateID = objRow[conCurrEduCls_Syn.SignInStateID] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SignInStateID].ToString().Trim(); //签入状态表流水号
objCurrEduCls_SynEN.SignInUser = objRow[conCurrEduCls_Syn.SignInUser] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SignInUser].ToString().Trim(); //签入人
objCurrEduCls_SynEN.SynchToWebUser = objRow[conCurrEduCls_Syn.SynchToWebUser] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SynchToWebUser].ToString().Trim(); //同步Web用户
objCurrEduCls_SynEN.IsSynchToWeb = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsSynchToWeb].ToString().Trim()); //是否同步Web
objCurrEduCls_SynEN.SynchToWebDate = objRow[conCurrEduCls_Syn.SynchToWebDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SynchToWebDate].ToString().Trim(); //同步Web日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduCls_SynEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduCls_SynEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdCurrEduClsLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsCurrEduCls_SynEN> GetObjLstByIdCurrEduClsLstCache(List<string> arrIdCurrEduClsLst)
{
string strKey = string.Format("{0}", clsCurrEduCls_SynEN._CurrTabName);
List<clsCurrEduCls_SynEN> arrCurrEduCls_SynObjLstCache = GetObjLstCache();
IEnumerable <clsCurrEduCls_SynEN> arrCurrEduCls_SynObjLst_Sel =
arrCurrEduCls_SynObjLstCache
.Where(x => arrIdCurrEduClsLst.Contains(x.IdCurrEduCls));
return arrCurrEduCls_SynObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCurrEduCls_SynEN> GetObjLst(string strWhereCond)
{
List<clsCurrEduCls_SynEN> arrObjLst = new List<clsCurrEduCls_SynEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduCls_SynEN objCurrEduCls_SynEN = new clsCurrEduCls_SynEN();
try
{
objCurrEduCls_SynEN.IdCurrEduCls = objRow[conCurrEduCls_Syn.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduCls_SynEN.CurrEduClsId = objRow[conCurrEduCls_Syn.CurrEduClsId].ToString().Trim(); //教学班Id
objCurrEduCls_SynEN.EduClsName = objRow[conCurrEduCls_Syn.EduClsName] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.EduClsName].ToString().Trim(); //教学班名
objCurrEduCls_SynEN.EduClsTypeId = objRow[conCurrEduCls_Syn.EduClsTypeId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.EduClsTypeId].ToString().Trim(); //教学班类型Id
objCurrEduCls_SynEN.CourseId = objRow[conCurrEduCls_Syn.CourseId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CourseId].ToString().Trim(); //课程Id
objCurrEduCls_SynEN.TeachingSolutionId = objRow[conCurrEduCls_Syn.TeachingSolutionId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCurrEduCls_SynEN.IdXzCollege = objRow[conCurrEduCls_Syn.IdXzCollege] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdXzCollege].ToString().Trim(); //学院流水号
objCurrEduCls_SynEN.IdMajor = objRow[conCurrEduCls_Syn.IdMajor].ToString().Trim(); //专业流水号
objCurrEduCls_SynEN.IdEduWay = objRow[conCurrEduCls_Syn.IdEduWay] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdEduWay].ToString().Trim(); //教学方式流水号
objCurrEduCls_SynEN.IdClassRoomType = objRow[conCurrEduCls_Syn.IdClassRoomType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdClassRoomType].ToString().Trim(); //教室类型流水号
objCurrEduCls_SynEN.TotalLessonQty = objRow[conCurrEduCls_Syn.TotalLessonQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls_Syn.TotalLessonQty].ToString().Trim()); //总课时数
objCurrEduCls_SynEN.MaxStuQty = objRow[conCurrEduCls_Syn.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls_Syn.MaxStuQty].ToString().Trim()); //最大学生数
objCurrEduCls_SynEN.CurrentStuQty = objRow[conCurrEduCls_Syn.CurrentStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls_Syn.CurrentStuQty].ToString().Trim()); //当前学生数
objCurrEduCls_SynEN.WeekQty = objRow[conCurrEduCls_Syn.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls_Syn.WeekQty].ToString().Trim()); //总周数
objCurrEduCls_SynEN.ScheUnitPW = objRow[conCurrEduCls_Syn.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.ScheUnitPW].ToString().Trim()); //周排课次数
objCurrEduCls_SynEN.WeekStatusId = objRow[conCurrEduCls_Syn.WeekStatusId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objCurrEduCls_SynEN.CustomerWeek = objRow[conCurrEduCls_Syn.CustomerWeek] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CustomerWeek].ToString().Trim(); //自定义上课周
objCurrEduCls_SynEN.IsCompleteScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsCompleteScore].ToString().Trim()); //是否成绩齐全
objCurrEduCls_SynEN.IdExecPlan = objRow[conCurrEduCls_Syn.IdExecPlan] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdExecPlan].ToString().Trim(); //执行计划流水号
objCurrEduCls_SynEN.LessonQtyPerWeek = objRow[conCurrEduCls_Syn.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.LessonQtyPerWeek].ToString().Trim()); //周课时数
objCurrEduCls_SynEN.Mark = objRow[conCurrEduCls_Syn.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduCls_Syn.Mark].ToString().Trim()); //获得学分
objCurrEduCls_SynEN.CheckClassRoom = objRow[conCurrEduCls_Syn.CheckClassRoom] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckClassRoom].ToString().Trim(); //检查教室结果
objCurrEduCls_SynEN.CheckAdminCls = objRow[conCurrEduCls_Syn.CheckAdminCls] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckAdminCls].ToString().Trim(); //检查行政班结果
objCurrEduCls_SynEN.CheckTeacher = objRow[conCurrEduCls_Syn.CheckTeacher] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckTeacher].ToString().Trim(); //检查教师结果
objCurrEduCls_SynEN.EditLocked = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.EditLocked].ToString().Trim()); //编辑锁定
objCurrEduCls_SynEN.Sched = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.Sched].ToString().Trim()); //是否排课
objCurrEduCls_SynEN.IdUniZone = objRow[conCurrEduCls_Syn.IdUniZone] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdUniZone].ToString().Trim(); //校区流水号
objCurrEduCls_SynEN.Locked = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.Locked].ToString().Trim()); //锁定状态
objCurrEduCls_SynEN.IdGradeBase = objRow[conCurrEduCls_Syn.IdGradeBase] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdGradeBase].ToString().Trim(); //年级流水号
objCurrEduCls_SynEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsEffective].ToString().Trim()); //是否有效
objCurrEduCls_SynEN.IsForPaperReading = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objCurrEduCls_SynEN.IsUnDeterminedClsRm = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsUnDeterminedClsRm].ToString().Trim()); //是否待定教室
objCurrEduCls_SynEN.SchoolYear = objRow[conCurrEduCls_Syn.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SchoolYear].ToString().Trim(); //学年
objCurrEduCls_SynEN.SchoolTerm = objRow[conCurrEduCls_Syn.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SchoolTerm].ToString().Trim(); //学期
objCurrEduCls_SynEN.ArrangeCourseMemo = objRow[conCurrEduCls_Syn.ArrangeCourseMemo] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ArrangeCourseMemo].ToString().Trim(); //排课备注
objCurrEduCls_SynEN.IdCourseType = objRow[conCurrEduCls_Syn.IdCourseType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdCourseType].ToString().Trim(); //课程类型流水号
objCurrEduCls_SynEN.ExportDate = objRow[conCurrEduCls_Syn.ExportDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ExportDate].ToString().Trim(); //导出日期
objCurrEduCls_SynEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsDegree].ToString().Trim()); //是否学位课
objCurrEduCls_SynEN.IdScoreType = objRow[conCurrEduCls_Syn.IdScoreType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdScoreType].ToString().Trim(); //成绩类型流水号
objCurrEduCls_SynEN.GetScoreWayId = objRow[conCurrEduCls_Syn.GetScoreWayId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objCurrEduCls_SynEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objCurrEduCls_SynEN.IdExamType = objRow[conCurrEduCls_Syn.IdExamType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdExamType].ToString().Trim(); //考试方式流水号
objCurrEduCls_SynEN.ExamPortion = objRow[conCurrEduCls_Syn.ExamPortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.ExamPortion].ToString().Trim()); //平时成绩所占比例
objCurrEduCls_SynEN.MidExamScorePortion = objRow[conCurrEduCls_Syn.MidExamScorePortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.MidExamScorePortion].ToString().Trim()); //期末成绩所占比例
objCurrEduCls_SynEN.IsClearScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsClearScore].ToString().Trim()); //是否重录成绩
objCurrEduCls_SynEN.IsGeneratePwd = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsGeneratePwd].ToString().Trim()); //是否生成口令
objCurrEduCls_SynEN.GeneratePwdDate = objRow[conCurrEduCls_Syn.GeneratePwdDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.GeneratePwdDate].ToString().Trim(); //生成口令时间
objCurrEduCls_SynEN.IsExportToGP = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsExportToGP].ToString().Trim()); //是否导出到平台
objCurrEduCls_SynEN.IsExportToGPWeb = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsExportToGPWeb].ToString().Trim()); //是否导出到Web平台
objCurrEduCls_SynEN.IsReservedDecimal = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsReservedDecimal].ToString().Trim()); //是否保留小数
objCurrEduCls_SynEN.ExamTime = objRow[conCurrEduCls_Syn.ExamTime] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ExamTime].ToString().Trim(); //考试时间
objCurrEduCls_SynEN.CheckState = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.CheckState].ToString().Trim()); //检查状态
objCurrEduCls_SynEN.CheckDate = objRow[conCurrEduCls_Syn.CheckDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckDate].ToString().Trim(); //检查日期
objCurrEduCls_SynEN.IdEduClassInPk = objRow[conCurrEduCls_Syn.IdEduClassInPk] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdEduClassInPk].ToString().Trim(); //id_EduClassInPk
objCurrEduCls_SynEN.PkWeekTime = objRow[conCurrEduCls_Syn.PkWeekTime] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.PkWeekTime].ToString().Trim(); //排课时间
objCurrEduCls_SynEN.PkClassRooms = objRow[conCurrEduCls_Syn.PkClassRooms] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.PkClassRooms].ToString().Trim(); //排课教室
objCurrEduCls_SynEN.BeginWeek = objRow[conCurrEduCls_Syn.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.BeginWeek].ToString().Trim()); //开始周
objCurrEduCls_SynEN.TeacherNames = objRow[conCurrEduCls_Syn.TeacherNames] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.TeacherNames].ToString().Trim(); //教师姓名
objCurrEduCls_SynEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsSynch].ToString().Trim()); //是否同步
objCurrEduCls_SynEN.SynchDate = objRow[conCurrEduCls_Syn.SynchDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SynchDate].ToString().Trim(); //同步日期
objCurrEduCls_SynEN.ModifyDate = objRow[conCurrEduCls_Syn.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ModifyDate].ToString().Trim(); //修改日期
objCurrEduCls_SynEN.ModifyUserId = objRow[conCurrEduCls_Syn.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ModifyUserId].ToString().Trim(); //修改人
objCurrEduCls_SynEN.Memo = objRow[conCurrEduCls_Syn.Memo] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.Memo].ToString().Trim(); //备注
objCurrEduCls_SynEN.SignInDate = objRow[conCurrEduCls_Syn.SignInDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SignInDate].ToString().Trim(); //签入时间
objCurrEduCls_SynEN.SignInStateID = objRow[conCurrEduCls_Syn.SignInStateID] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SignInStateID].ToString().Trim(); //签入状态表流水号
objCurrEduCls_SynEN.SignInUser = objRow[conCurrEduCls_Syn.SignInUser] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SignInUser].ToString().Trim(); //签入人
objCurrEduCls_SynEN.SynchToWebUser = objRow[conCurrEduCls_Syn.SynchToWebUser] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SynchToWebUser].ToString().Trim(); //同步Web用户
objCurrEduCls_SynEN.IsSynchToWeb = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsSynchToWeb].ToString().Trim()); //是否同步Web
objCurrEduCls_SynEN.SynchToWebDate = objRow[conCurrEduCls_Syn.SynchToWebDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SynchToWebDate].ToString().Trim(); //同步Web日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduCls_SynEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduCls_SynEN);
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
public static List<clsCurrEduCls_SynEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsCurrEduCls_SynEN> arrObjLst = new List<clsCurrEduCls_SynEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduCls_SynEN objCurrEduCls_SynEN = new clsCurrEduCls_SynEN();
try
{
objCurrEduCls_SynEN.IdCurrEduCls = objRow[conCurrEduCls_Syn.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduCls_SynEN.CurrEduClsId = objRow[conCurrEduCls_Syn.CurrEduClsId].ToString().Trim(); //教学班Id
objCurrEduCls_SynEN.EduClsName = objRow[conCurrEduCls_Syn.EduClsName] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.EduClsName].ToString().Trim(); //教学班名
objCurrEduCls_SynEN.EduClsTypeId = objRow[conCurrEduCls_Syn.EduClsTypeId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.EduClsTypeId].ToString().Trim(); //教学班类型Id
objCurrEduCls_SynEN.CourseId = objRow[conCurrEduCls_Syn.CourseId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CourseId].ToString().Trim(); //课程Id
objCurrEduCls_SynEN.TeachingSolutionId = objRow[conCurrEduCls_Syn.TeachingSolutionId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCurrEduCls_SynEN.IdXzCollege = objRow[conCurrEduCls_Syn.IdXzCollege] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdXzCollege].ToString().Trim(); //学院流水号
objCurrEduCls_SynEN.IdMajor = objRow[conCurrEduCls_Syn.IdMajor].ToString().Trim(); //专业流水号
objCurrEduCls_SynEN.IdEduWay = objRow[conCurrEduCls_Syn.IdEduWay] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdEduWay].ToString().Trim(); //教学方式流水号
objCurrEduCls_SynEN.IdClassRoomType = objRow[conCurrEduCls_Syn.IdClassRoomType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdClassRoomType].ToString().Trim(); //教室类型流水号
objCurrEduCls_SynEN.TotalLessonQty = objRow[conCurrEduCls_Syn.TotalLessonQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls_Syn.TotalLessonQty].ToString().Trim()); //总课时数
objCurrEduCls_SynEN.MaxStuQty = objRow[conCurrEduCls_Syn.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls_Syn.MaxStuQty].ToString().Trim()); //最大学生数
objCurrEduCls_SynEN.CurrentStuQty = objRow[conCurrEduCls_Syn.CurrentStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls_Syn.CurrentStuQty].ToString().Trim()); //当前学生数
objCurrEduCls_SynEN.WeekQty = objRow[conCurrEduCls_Syn.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls_Syn.WeekQty].ToString().Trim()); //总周数
objCurrEduCls_SynEN.ScheUnitPW = objRow[conCurrEduCls_Syn.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.ScheUnitPW].ToString().Trim()); //周排课次数
objCurrEduCls_SynEN.WeekStatusId = objRow[conCurrEduCls_Syn.WeekStatusId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objCurrEduCls_SynEN.CustomerWeek = objRow[conCurrEduCls_Syn.CustomerWeek] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CustomerWeek].ToString().Trim(); //自定义上课周
objCurrEduCls_SynEN.IsCompleteScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsCompleteScore].ToString().Trim()); //是否成绩齐全
objCurrEduCls_SynEN.IdExecPlan = objRow[conCurrEduCls_Syn.IdExecPlan] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdExecPlan].ToString().Trim(); //执行计划流水号
objCurrEduCls_SynEN.LessonQtyPerWeek = objRow[conCurrEduCls_Syn.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.LessonQtyPerWeek].ToString().Trim()); //周课时数
objCurrEduCls_SynEN.Mark = objRow[conCurrEduCls_Syn.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduCls_Syn.Mark].ToString().Trim()); //获得学分
objCurrEduCls_SynEN.CheckClassRoom = objRow[conCurrEduCls_Syn.CheckClassRoom] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckClassRoom].ToString().Trim(); //检查教室结果
objCurrEduCls_SynEN.CheckAdminCls = objRow[conCurrEduCls_Syn.CheckAdminCls] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckAdminCls].ToString().Trim(); //检查行政班结果
objCurrEduCls_SynEN.CheckTeacher = objRow[conCurrEduCls_Syn.CheckTeacher] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckTeacher].ToString().Trim(); //检查教师结果
objCurrEduCls_SynEN.EditLocked = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.EditLocked].ToString().Trim()); //编辑锁定
objCurrEduCls_SynEN.Sched = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.Sched].ToString().Trim()); //是否排课
objCurrEduCls_SynEN.IdUniZone = objRow[conCurrEduCls_Syn.IdUniZone] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdUniZone].ToString().Trim(); //校区流水号
objCurrEduCls_SynEN.Locked = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.Locked].ToString().Trim()); //锁定状态
objCurrEduCls_SynEN.IdGradeBase = objRow[conCurrEduCls_Syn.IdGradeBase] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdGradeBase].ToString().Trim(); //年级流水号
objCurrEduCls_SynEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsEffective].ToString().Trim()); //是否有效
objCurrEduCls_SynEN.IsForPaperReading = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objCurrEduCls_SynEN.IsUnDeterminedClsRm = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsUnDeterminedClsRm].ToString().Trim()); //是否待定教室
objCurrEduCls_SynEN.SchoolYear = objRow[conCurrEduCls_Syn.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SchoolYear].ToString().Trim(); //学年
objCurrEduCls_SynEN.SchoolTerm = objRow[conCurrEduCls_Syn.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SchoolTerm].ToString().Trim(); //学期
objCurrEduCls_SynEN.ArrangeCourseMemo = objRow[conCurrEduCls_Syn.ArrangeCourseMemo] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ArrangeCourseMemo].ToString().Trim(); //排课备注
objCurrEduCls_SynEN.IdCourseType = objRow[conCurrEduCls_Syn.IdCourseType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdCourseType].ToString().Trim(); //课程类型流水号
objCurrEduCls_SynEN.ExportDate = objRow[conCurrEduCls_Syn.ExportDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ExportDate].ToString().Trim(); //导出日期
objCurrEduCls_SynEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsDegree].ToString().Trim()); //是否学位课
objCurrEduCls_SynEN.IdScoreType = objRow[conCurrEduCls_Syn.IdScoreType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdScoreType].ToString().Trim(); //成绩类型流水号
objCurrEduCls_SynEN.GetScoreWayId = objRow[conCurrEduCls_Syn.GetScoreWayId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objCurrEduCls_SynEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objCurrEduCls_SynEN.IdExamType = objRow[conCurrEduCls_Syn.IdExamType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdExamType].ToString().Trim(); //考试方式流水号
objCurrEduCls_SynEN.ExamPortion = objRow[conCurrEduCls_Syn.ExamPortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.ExamPortion].ToString().Trim()); //平时成绩所占比例
objCurrEduCls_SynEN.MidExamScorePortion = objRow[conCurrEduCls_Syn.MidExamScorePortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.MidExamScorePortion].ToString().Trim()); //期末成绩所占比例
objCurrEduCls_SynEN.IsClearScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsClearScore].ToString().Trim()); //是否重录成绩
objCurrEduCls_SynEN.IsGeneratePwd = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsGeneratePwd].ToString().Trim()); //是否生成口令
objCurrEduCls_SynEN.GeneratePwdDate = objRow[conCurrEduCls_Syn.GeneratePwdDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.GeneratePwdDate].ToString().Trim(); //生成口令时间
objCurrEduCls_SynEN.IsExportToGP = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsExportToGP].ToString().Trim()); //是否导出到平台
objCurrEduCls_SynEN.IsExportToGPWeb = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsExportToGPWeb].ToString().Trim()); //是否导出到Web平台
objCurrEduCls_SynEN.IsReservedDecimal = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsReservedDecimal].ToString().Trim()); //是否保留小数
objCurrEduCls_SynEN.ExamTime = objRow[conCurrEduCls_Syn.ExamTime] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ExamTime].ToString().Trim(); //考试时间
objCurrEduCls_SynEN.CheckState = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.CheckState].ToString().Trim()); //检查状态
objCurrEduCls_SynEN.CheckDate = objRow[conCurrEduCls_Syn.CheckDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckDate].ToString().Trim(); //检查日期
objCurrEduCls_SynEN.IdEduClassInPk = objRow[conCurrEduCls_Syn.IdEduClassInPk] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdEduClassInPk].ToString().Trim(); //id_EduClassInPk
objCurrEduCls_SynEN.PkWeekTime = objRow[conCurrEduCls_Syn.PkWeekTime] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.PkWeekTime].ToString().Trim(); //排课时间
objCurrEduCls_SynEN.PkClassRooms = objRow[conCurrEduCls_Syn.PkClassRooms] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.PkClassRooms].ToString().Trim(); //排课教室
objCurrEduCls_SynEN.BeginWeek = objRow[conCurrEduCls_Syn.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.BeginWeek].ToString().Trim()); //开始周
objCurrEduCls_SynEN.TeacherNames = objRow[conCurrEduCls_Syn.TeacherNames] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.TeacherNames].ToString().Trim(); //教师姓名
objCurrEduCls_SynEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsSynch].ToString().Trim()); //是否同步
objCurrEduCls_SynEN.SynchDate = objRow[conCurrEduCls_Syn.SynchDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SynchDate].ToString().Trim(); //同步日期
objCurrEduCls_SynEN.ModifyDate = objRow[conCurrEduCls_Syn.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ModifyDate].ToString().Trim(); //修改日期
objCurrEduCls_SynEN.ModifyUserId = objRow[conCurrEduCls_Syn.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ModifyUserId].ToString().Trim(); //修改人
objCurrEduCls_SynEN.Memo = objRow[conCurrEduCls_Syn.Memo] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.Memo].ToString().Trim(); //备注
objCurrEduCls_SynEN.SignInDate = objRow[conCurrEduCls_Syn.SignInDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SignInDate].ToString().Trim(); //签入时间
objCurrEduCls_SynEN.SignInStateID = objRow[conCurrEduCls_Syn.SignInStateID] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SignInStateID].ToString().Trim(); //签入状态表流水号
objCurrEduCls_SynEN.SignInUser = objRow[conCurrEduCls_Syn.SignInUser] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SignInUser].ToString().Trim(); //签入人
objCurrEduCls_SynEN.SynchToWebUser = objRow[conCurrEduCls_Syn.SynchToWebUser] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SynchToWebUser].ToString().Trim(); //同步Web用户
objCurrEduCls_SynEN.IsSynchToWeb = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsSynchToWeb].ToString().Trim()); //是否同步Web
objCurrEduCls_SynEN.SynchToWebDate = objRow[conCurrEduCls_Syn.SynchToWebDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SynchToWebDate].ToString().Trim(); //同步Web日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduCls_SynEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduCls_SynEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objCurrEduCls_SynCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsCurrEduCls_SynEN> GetSubObjLstCache(clsCurrEduCls_SynEN objCurrEduCls_SynCond)
{
List<clsCurrEduCls_SynEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsCurrEduCls_SynEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCurrEduCls_Syn.AttributeName)
{
if (objCurrEduCls_SynCond.IsUpdated(strFldName) == false) continue;
if (objCurrEduCls_SynCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCurrEduCls_SynCond[strFldName].ToString());
}
else
{
if (objCurrEduCls_SynCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCurrEduCls_SynCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCurrEduCls_SynCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCurrEduCls_SynCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCurrEduCls_SynCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCurrEduCls_SynCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCurrEduCls_SynCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCurrEduCls_SynCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCurrEduCls_SynCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCurrEduCls_SynCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCurrEduCls_SynCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCurrEduCls_SynCond[strFldName]));
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
public static List<clsCurrEduCls_SynEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsCurrEduCls_SynEN> arrObjLst = new List<clsCurrEduCls_SynEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduCls_SynEN objCurrEduCls_SynEN = new clsCurrEduCls_SynEN();
try
{
objCurrEduCls_SynEN.IdCurrEduCls = objRow[conCurrEduCls_Syn.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduCls_SynEN.CurrEduClsId = objRow[conCurrEduCls_Syn.CurrEduClsId].ToString().Trim(); //教学班Id
objCurrEduCls_SynEN.EduClsName = objRow[conCurrEduCls_Syn.EduClsName] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.EduClsName].ToString().Trim(); //教学班名
objCurrEduCls_SynEN.EduClsTypeId = objRow[conCurrEduCls_Syn.EduClsTypeId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.EduClsTypeId].ToString().Trim(); //教学班类型Id
objCurrEduCls_SynEN.CourseId = objRow[conCurrEduCls_Syn.CourseId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CourseId].ToString().Trim(); //课程Id
objCurrEduCls_SynEN.TeachingSolutionId = objRow[conCurrEduCls_Syn.TeachingSolutionId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCurrEduCls_SynEN.IdXzCollege = objRow[conCurrEduCls_Syn.IdXzCollege] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdXzCollege].ToString().Trim(); //学院流水号
objCurrEduCls_SynEN.IdMajor = objRow[conCurrEduCls_Syn.IdMajor].ToString().Trim(); //专业流水号
objCurrEduCls_SynEN.IdEduWay = objRow[conCurrEduCls_Syn.IdEduWay] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdEduWay].ToString().Trim(); //教学方式流水号
objCurrEduCls_SynEN.IdClassRoomType = objRow[conCurrEduCls_Syn.IdClassRoomType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdClassRoomType].ToString().Trim(); //教室类型流水号
objCurrEduCls_SynEN.TotalLessonQty = objRow[conCurrEduCls_Syn.TotalLessonQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls_Syn.TotalLessonQty].ToString().Trim()); //总课时数
objCurrEduCls_SynEN.MaxStuQty = objRow[conCurrEduCls_Syn.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls_Syn.MaxStuQty].ToString().Trim()); //最大学生数
objCurrEduCls_SynEN.CurrentStuQty = objRow[conCurrEduCls_Syn.CurrentStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls_Syn.CurrentStuQty].ToString().Trim()); //当前学生数
objCurrEduCls_SynEN.WeekQty = objRow[conCurrEduCls_Syn.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls_Syn.WeekQty].ToString().Trim()); //总周数
objCurrEduCls_SynEN.ScheUnitPW = objRow[conCurrEduCls_Syn.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.ScheUnitPW].ToString().Trim()); //周排课次数
objCurrEduCls_SynEN.WeekStatusId = objRow[conCurrEduCls_Syn.WeekStatusId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objCurrEduCls_SynEN.CustomerWeek = objRow[conCurrEduCls_Syn.CustomerWeek] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CustomerWeek].ToString().Trim(); //自定义上课周
objCurrEduCls_SynEN.IsCompleteScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsCompleteScore].ToString().Trim()); //是否成绩齐全
objCurrEduCls_SynEN.IdExecPlan = objRow[conCurrEduCls_Syn.IdExecPlan] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdExecPlan].ToString().Trim(); //执行计划流水号
objCurrEduCls_SynEN.LessonQtyPerWeek = objRow[conCurrEduCls_Syn.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.LessonQtyPerWeek].ToString().Trim()); //周课时数
objCurrEduCls_SynEN.Mark = objRow[conCurrEduCls_Syn.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduCls_Syn.Mark].ToString().Trim()); //获得学分
objCurrEduCls_SynEN.CheckClassRoom = objRow[conCurrEduCls_Syn.CheckClassRoom] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckClassRoom].ToString().Trim(); //检查教室结果
objCurrEduCls_SynEN.CheckAdminCls = objRow[conCurrEduCls_Syn.CheckAdminCls] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckAdminCls].ToString().Trim(); //检查行政班结果
objCurrEduCls_SynEN.CheckTeacher = objRow[conCurrEduCls_Syn.CheckTeacher] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckTeacher].ToString().Trim(); //检查教师结果
objCurrEduCls_SynEN.EditLocked = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.EditLocked].ToString().Trim()); //编辑锁定
objCurrEduCls_SynEN.Sched = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.Sched].ToString().Trim()); //是否排课
objCurrEduCls_SynEN.IdUniZone = objRow[conCurrEduCls_Syn.IdUniZone] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdUniZone].ToString().Trim(); //校区流水号
objCurrEduCls_SynEN.Locked = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.Locked].ToString().Trim()); //锁定状态
objCurrEduCls_SynEN.IdGradeBase = objRow[conCurrEduCls_Syn.IdGradeBase] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdGradeBase].ToString().Trim(); //年级流水号
objCurrEduCls_SynEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsEffective].ToString().Trim()); //是否有效
objCurrEduCls_SynEN.IsForPaperReading = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objCurrEduCls_SynEN.IsUnDeterminedClsRm = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsUnDeterminedClsRm].ToString().Trim()); //是否待定教室
objCurrEduCls_SynEN.SchoolYear = objRow[conCurrEduCls_Syn.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SchoolYear].ToString().Trim(); //学年
objCurrEduCls_SynEN.SchoolTerm = objRow[conCurrEduCls_Syn.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SchoolTerm].ToString().Trim(); //学期
objCurrEduCls_SynEN.ArrangeCourseMemo = objRow[conCurrEduCls_Syn.ArrangeCourseMemo] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ArrangeCourseMemo].ToString().Trim(); //排课备注
objCurrEduCls_SynEN.IdCourseType = objRow[conCurrEduCls_Syn.IdCourseType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdCourseType].ToString().Trim(); //课程类型流水号
objCurrEduCls_SynEN.ExportDate = objRow[conCurrEduCls_Syn.ExportDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ExportDate].ToString().Trim(); //导出日期
objCurrEduCls_SynEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsDegree].ToString().Trim()); //是否学位课
objCurrEduCls_SynEN.IdScoreType = objRow[conCurrEduCls_Syn.IdScoreType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdScoreType].ToString().Trim(); //成绩类型流水号
objCurrEduCls_SynEN.GetScoreWayId = objRow[conCurrEduCls_Syn.GetScoreWayId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objCurrEduCls_SynEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objCurrEduCls_SynEN.IdExamType = objRow[conCurrEduCls_Syn.IdExamType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdExamType].ToString().Trim(); //考试方式流水号
objCurrEduCls_SynEN.ExamPortion = objRow[conCurrEduCls_Syn.ExamPortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.ExamPortion].ToString().Trim()); //平时成绩所占比例
objCurrEduCls_SynEN.MidExamScorePortion = objRow[conCurrEduCls_Syn.MidExamScorePortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.MidExamScorePortion].ToString().Trim()); //期末成绩所占比例
objCurrEduCls_SynEN.IsClearScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsClearScore].ToString().Trim()); //是否重录成绩
objCurrEduCls_SynEN.IsGeneratePwd = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsGeneratePwd].ToString().Trim()); //是否生成口令
objCurrEduCls_SynEN.GeneratePwdDate = objRow[conCurrEduCls_Syn.GeneratePwdDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.GeneratePwdDate].ToString().Trim(); //生成口令时间
objCurrEduCls_SynEN.IsExportToGP = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsExportToGP].ToString().Trim()); //是否导出到平台
objCurrEduCls_SynEN.IsExportToGPWeb = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsExportToGPWeb].ToString().Trim()); //是否导出到Web平台
objCurrEduCls_SynEN.IsReservedDecimal = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsReservedDecimal].ToString().Trim()); //是否保留小数
objCurrEduCls_SynEN.ExamTime = objRow[conCurrEduCls_Syn.ExamTime] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ExamTime].ToString().Trim(); //考试时间
objCurrEduCls_SynEN.CheckState = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.CheckState].ToString().Trim()); //检查状态
objCurrEduCls_SynEN.CheckDate = objRow[conCurrEduCls_Syn.CheckDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckDate].ToString().Trim(); //检查日期
objCurrEduCls_SynEN.IdEduClassInPk = objRow[conCurrEduCls_Syn.IdEduClassInPk] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdEduClassInPk].ToString().Trim(); //id_EduClassInPk
objCurrEduCls_SynEN.PkWeekTime = objRow[conCurrEduCls_Syn.PkWeekTime] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.PkWeekTime].ToString().Trim(); //排课时间
objCurrEduCls_SynEN.PkClassRooms = objRow[conCurrEduCls_Syn.PkClassRooms] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.PkClassRooms].ToString().Trim(); //排课教室
objCurrEduCls_SynEN.BeginWeek = objRow[conCurrEduCls_Syn.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.BeginWeek].ToString().Trim()); //开始周
objCurrEduCls_SynEN.TeacherNames = objRow[conCurrEduCls_Syn.TeacherNames] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.TeacherNames].ToString().Trim(); //教师姓名
objCurrEduCls_SynEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsSynch].ToString().Trim()); //是否同步
objCurrEduCls_SynEN.SynchDate = objRow[conCurrEduCls_Syn.SynchDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SynchDate].ToString().Trim(); //同步日期
objCurrEduCls_SynEN.ModifyDate = objRow[conCurrEduCls_Syn.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ModifyDate].ToString().Trim(); //修改日期
objCurrEduCls_SynEN.ModifyUserId = objRow[conCurrEduCls_Syn.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ModifyUserId].ToString().Trim(); //修改人
objCurrEduCls_SynEN.Memo = objRow[conCurrEduCls_Syn.Memo] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.Memo].ToString().Trim(); //备注
objCurrEduCls_SynEN.SignInDate = objRow[conCurrEduCls_Syn.SignInDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SignInDate].ToString().Trim(); //签入时间
objCurrEduCls_SynEN.SignInStateID = objRow[conCurrEduCls_Syn.SignInStateID] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SignInStateID].ToString().Trim(); //签入状态表流水号
objCurrEduCls_SynEN.SignInUser = objRow[conCurrEduCls_Syn.SignInUser] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SignInUser].ToString().Trim(); //签入人
objCurrEduCls_SynEN.SynchToWebUser = objRow[conCurrEduCls_Syn.SynchToWebUser] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SynchToWebUser].ToString().Trim(); //同步Web用户
objCurrEduCls_SynEN.IsSynchToWeb = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsSynchToWeb].ToString().Trim()); //是否同步Web
objCurrEduCls_SynEN.SynchToWebDate = objRow[conCurrEduCls_Syn.SynchToWebDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SynchToWebDate].ToString().Trim(); //同步Web日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduCls_SynEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduCls_SynEN);
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
public static List<clsCurrEduCls_SynEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsCurrEduCls_SynEN> arrObjLst = new List<clsCurrEduCls_SynEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduCls_SynEN objCurrEduCls_SynEN = new clsCurrEduCls_SynEN();
try
{
objCurrEduCls_SynEN.IdCurrEduCls = objRow[conCurrEduCls_Syn.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduCls_SynEN.CurrEduClsId = objRow[conCurrEduCls_Syn.CurrEduClsId].ToString().Trim(); //教学班Id
objCurrEduCls_SynEN.EduClsName = objRow[conCurrEduCls_Syn.EduClsName] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.EduClsName].ToString().Trim(); //教学班名
objCurrEduCls_SynEN.EduClsTypeId = objRow[conCurrEduCls_Syn.EduClsTypeId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.EduClsTypeId].ToString().Trim(); //教学班类型Id
objCurrEduCls_SynEN.CourseId = objRow[conCurrEduCls_Syn.CourseId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CourseId].ToString().Trim(); //课程Id
objCurrEduCls_SynEN.TeachingSolutionId = objRow[conCurrEduCls_Syn.TeachingSolutionId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCurrEduCls_SynEN.IdXzCollege = objRow[conCurrEduCls_Syn.IdXzCollege] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdXzCollege].ToString().Trim(); //学院流水号
objCurrEduCls_SynEN.IdMajor = objRow[conCurrEduCls_Syn.IdMajor].ToString().Trim(); //专业流水号
objCurrEduCls_SynEN.IdEduWay = objRow[conCurrEduCls_Syn.IdEduWay] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdEduWay].ToString().Trim(); //教学方式流水号
objCurrEduCls_SynEN.IdClassRoomType = objRow[conCurrEduCls_Syn.IdClassRoomType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdClassRoomType].ToString().Trim(); //教室类型流水号
objCurrEduCls_SynEN.TotalLessonQty = objRow[conCurrEduCls_Syn.TotalLessonQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls_Syn.TotalLessonQty].ToString().Trim()); //总课时数
objCurrEduCls_SynEN.MaxStuQty = objRow[conCurrEduCls_Syn.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls_Syn.MaxStuQty].ToString().Trim()); //最大学生数
objCurrEduCls_SynEN.CurrentStuQty = objRow[conCurrEduCls_Syn.CurrentStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls_Syn.CurrentStuQty].ToString().Trim()); //当前学生数
objCurrEduCls_SynEN.WeekQty = objRow[conCurrEduCls_Syn.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls_Syn.WeekQty].ToString().Trim()); //总周数
objCurrEduCls_SynEN.ScheUnitPW = objRow[conCurrEduCls_Syn.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.ScheUnitPW].ToString().Trim()); //周排课次数
objCurrEduCls_SynEN.WeekStatusId = objRow[conCurrEduCls_Syn.WeekStatusId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objCurrEduCls_SynEN.CustomerWeek = objRow[conCurrEduCls_Syn.CustomerWeek] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CustomerWeek].ToString().Trim(); //自定义上课周
objCurrEduCls_SynEN.IsCompleteScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsCompleteScore].ToString().Trim()); //是否成绩齐全
objCurrEduCls_SynEN.IdExecPlan = objRow[conCurrEduCls_Syn.IdExecPlan] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdExecPlan].ToString().Trim(); //执行计划流水号
objCurrEduCls_SynEN.LessonQtyPerWeek = objRow[conCurrEduCls_Syn.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.LessonQtyPerWeek].ToString().Trim()); //周课时数
objCurrEduCls_SynEN.Mark = objRow[conCurrEduCls_Syn.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduCls_Syn.Mark].ToString().Trim()); //获得学分
objCurrEduCls_SynEN.CheckClassRoom = objRow[conCurrEduCls_Syn.CheckClassRoom] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckClassRoom].ToString().Trim(); //检查教室结果
objCurrEduCls_SynEN.CheckAdminCls = objRow[conCurrEduCls_Syn.CheckAdminCls] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckAdminCls].ToString().Trim(); //检查行政班结果
objCurrEduCls_SynEN.CheckTeacher = objRow[conCurrEduCls_Syn.CheckTeacher] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckTeacher].ToString().Trim(); //检查教师结果
objCurrEduCls_SynEN.EditLocked = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.EditLocked].ToString().Trim()); //编辑锁定
objCurrEduCls_SynEN.Sched = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.Sched].ToString().Trim()); //是否排课
objCurrEduCls_SynEN.IdUniZone = objRow[conCurrEduCls_Syn.IdUniZone] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdUniZone].ToString().Trim(); //校区流水号
objCurrEduCls_SynEN.Locked = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.Locked].ToString().Trim()); //锁定状态
objCurrEduCls_SynEN.IdGradeBase = objRow[conCurrEduCls_Syn.IdGradeBase] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdGradeBase].ToString().Trim(); //年级流水号
objCurrEduCls_SynEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsEffective].ToString().Trim()); //是否有效
objCurrEduCls_SynEN.IsForPaperReading = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objCurrEduCls_SynEN.IsUnDeterminedClsRm = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsUnDeterminedClsRm].ToString().Trim()); //是否待定教室
objCurrEduCls_SynEN.SchoolYear = objRow[conCurrEduCls_Syn.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SchoolYear].ToString().Trim(); //学年
objCurrEduCls_SynEN.SchoolTerm = objRow[conCurrEduCls_Syn.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SchoolTerm].ToString().Trim(); //学期
objCurrEduCls_SynEN.ArrangeCourseMemo = objRow[conCurrEduCls_Syn.ArrangeCourseMemo] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ArrangeCourseMemo].ToString().Trim(); //排课备注
objCurrEduCls_SynEN.IdCourseType = objRow[conCurrEduCls_Syn.IdCourseType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdCourseType].ToString().Trim(); //课程类型流水号
objCurrEduCls_SynEN.ExportDate = objRow[conCurrEduCls_Syn.ExportDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ExportDate].ToString().Trim(); //导出日期
objCurrEduCls_SynEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsDegree].ToString().Trim()); //是否学位课
objCurrEduCls_SynEN.IdScoreType = objRow[conCurrEduCls_Syn.IdScoreType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdScoreType].ToString().Trim(); //成绩类型流水号
objCurrEduCls_SynEN.GetScoreWayId = objRow[conCurrEduCls_Syn.GetScoreWayId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objCurrEduCls_SynEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objCurrEduCls_SynEN.IdExamType = objRow[conCurrEduCls_Syn.IdExamType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdExamType].ToString().Trim(); //考试方式流水号
objCurrEduCls_SynEN.ExamPortion = objRow[conCurrEduCls_Syn.ExamPortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.ExamPortion].ToString().Trim()); //平时成绩所占比例
objCurrEduCls_SynEN.MidExamScorePortion = objRow[conCurrEduCls_Syn.MidExamScorePortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.MidExamScorePortion].ToString().Trim()); //期末成绩所占比例
objCurrEduCls_SynEN.IsClearScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsClearScore].ToString().Trim()); //是否重录成绩
objCurrEduCls_SynEN.IsGeneratePwd = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsGeneratePwd].ToString().Trim()); //是否生成口令
objCurrEduCls_SynEN.GeneratePwdDate = objRow[conCurrEduCls_Syn.GeneratePwdDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.GeneratePwdDate].ToString().Trim(); //生成口令时间
objCurrEduCls_SynEN.IsExportToGP = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsExportToGP].ToString().Trim()); //是否导出到平台
objCurrEduCls_SynEN.IsExportToGPWeb = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsExportToGPWeb].ToString().Trim()); //是否导出到Web平台
objCurrEduCls_SynEN.IsReservedDecimal = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsReservedDecimal].ToString().Trim()); //是否保留小数
objCurrEduCls_SynEN.ExamTime = objRow[conCurrEduCls_Syn.ExamTime] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ExamTime].ToString().Trim(); //考试时间
objCurrEduCls_SynEN.CheckState = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.CheckState].ToString().Trim()); //检查状态
objCurrEduCls_SynEN.CheckDate = objRow[conCurrEduCls_Syn.CheckDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckDate].ToString().Trim(); //检查日期
objCurrEduCls_SynEN.IdEduClassInPk = objRow[conCurrEduCls_Syn.IdEduClassInPk] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdEduClassInPk].ToString().Trim(); //id_EduClassInPk
objCurrEduCls_SynEN.PkWeekTime = objRow[conCurrEduCls_Syn.PkWeekTime] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.PkWeekTime].ToString().Trim(); //排课时间
objCurrEduCls_SynEN.PkClassRooms = objRow[conCurrEduCls_Syn.PkClassRooms] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.PkClassRooms].ToString().Trim(); //排课教室
objCurrEduCls_SynEN.BeginWeek = objRow[conCurrEduCls_Syn.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.BeginWeek].ToString().Trim()); //开始周
objCurrEduCls_SynEN.TeacherNames = objRow[conCurrEduCls_Syn.TeacherNames] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.TeacherNames].ToString().Trim(); //教师姓名
objCurrEduCls_SynEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsSynch].ToString().Trim()); //是否同步
objCurrEduCls_SynEN.SynchDate = objRow[conCurrEduCls_Syn.SynchDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SynchDate].ToString().Trim(); //同步日期
objCurrEduCls_SynEN.ModifyDate = objRow[conCurrEduCls_Syn.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ModifyDate].ToString().Trim(); //修改日期
objCurrEduCls_SynEN.ModifyUserId = objRow[conCurrEduCls_Syn.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ModifyUserId].ToString().Trim(); //修改人
objCurrEduCls_SynEN.Memo = objRow[conCurrEduCls_Syn.Memo] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.Memo].ToString().Trim(); //备注
objCurrEduCls_SynEN.SignInDate = objRow[conCurrEduCls_Syn.SignInDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SignInDate].ToString().Trim(); //签入时间
objCurrEduCls_SynEN.SignInStateID = objRow[conCurrEduCls_Syn.SignInStateID] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SignInStateID].ToString().Trim(); //签入状态表流水号
objCurrEduCls_SynEN.SignInUser = objRow[conCurrEduCls_Syn.SignInUser] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SignInUser].ToString().Trim(); //签入人
objCurrEduCls_SynEN.SynchToWebUser = objRow[conCurrEduCls_Syn.SynchToWebUser] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SynchToWebUser].ToString().Trim(); //同步Web用户
objCurrEduCls_SynEN.IsSynchToWeb = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsSynchToWeb].ToString().Trim()); //是否同步Web
objCurrEduCls_SynEN.SynchToWebDate = objRow[conCurrEduCls_Syn.SynchToWebDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SynchToWebDate].ToString().Trim(); //同步Web日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduCls_SynEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduCls_SynEN);
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
List<clsCurrEduCls_SynEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsCurrEduCls_SynEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsCurrEduCls_SynEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsCurrEduCls_SynEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsCurrEduCls_SynEN> arrObjLst = new List<clsCurrEduCls_SynEN>(); 
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
	clsCurrEduCls_SynEN objCurrEduCls_SynEN = new clsCurrEduCls_SynEN();
try
{
objCurrEduCls_SynEN.IdCurrEduCls = objRow[conCurrEduCls_Syn.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduCls_SynEN.CurrEduClsId = objRow[conCurrEduCls_Syn.CurrEduClsId].ToString().Trim(); //教学班Id
objCurrEduCls_SynEN.EduClsName = objRow[conCurrEduCls_Syn.EduClsName] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.EduClsName].ToString().Trim(); //教学班名
objCurrEduCls_SynEN.EduClsTypeId = objRow[conCurrEduCls_Syn.EduClsTypeId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.EduClsTypeId].ToString().Trim(); //教学班类型Id
objCurrEduCls_SynEN.CourseId = objRow[conCurrEduCls_Syn.CourseId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CourseId].ToString().Trim(); //课程Id
objCurrEduCls_SynEN.TeachingSolutionId = objRow[conCurrEduCls_Syn.TeachingSolutionId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCurrEduCls_SynEN.IdXzCollege = objRow[conCurrEduCls_Syn.IdXzCollege] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdXzCollege].ToString().Trim(); //学院流水号
objCurrEduCls_SynEN.IdMajor = objRow[conCurrEduCls_Syn.IdMajor].ToString().Trim(); //专业流水号
objCurrEduCls_SynEN.IdEduWay = objRow[conCurrEduCls_Syn.IdEduWay] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdEduWay].ToString().Trim(); //教学方式流水号
objCurrEduCls_SynEN.IdClassRoomType = objRow[conCurrEduCls_Syn.IdClassRoomType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdClassRoomType].ToString().Trim(); //教室类型流水号
objCurrEduCls_SynEN.TotalLessonQty = objRow[conCurrEduCls_Syn.TotalLessonQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls_Syn.TotalLessonQty].ToString().Trim()); //总课时数
objCurrEduCls_SynEN.MaxStuQty = objRow[conCurrEduCls_Syn.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls_Syn.MaxStuQty].ToString().Trim()); //最大学生数
objCurrEduCls_SynEN.CurrentStuQty = objRow[conCurrEduCls_Syn.CurrentStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls_Syn.CurrentStuQty].ToString().Trim()); //当前学生数
objCurrEduCls_SynEN.WeekQty = objRow[conCurrEduCls_Syn.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls_Syn.WeekQty].ToString().Trim()); //总周数
objCurrEduCls_SynEN.ScheUnitPW = objRow[conCurrEduCls_Syn.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.ScheUnitPW].ToString().Trim()); //周排课次数
objCurrEduCls_SynEN.WeekStatusId = objRow[conCurrEduCls_Syn.WeekStatusId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objCurrEduCls_SynEN.CustomerWeek = objRow[conCurrEduCls_Syn.CustomerWeek] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CustomerWeek].ToString().Trim(); //自定义上课周
objCurrEduCls_SynEN.IsCompleteScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsCompleteScore].ToString().Trim()); //是否成绩齐全
objCurrEduCls_SynEN.IdExecPlan = objRow[conCurrEduCls_Syn.IdExecPlan] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdExecPlan].ToString().Trim(); //执行计划流水号
objCurrEduCls_SynEN.LessonQtyPerWeek = objRow[conCurrEduCls_Syn.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.LessonQtyPerWeek].ToString().Trim()); //周课时数
objCurrEduCls_SynEN.Mark = objRow[conCurrEduCls_Syn.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduCls_Syn.Mark].ToString().Trim()); //获得学分
objCurrEduCls_SynEN.CheckClassRoom = objRow[conCurrEduCls_Syn.CheckClassRoom] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckClassRoom].ToString().Trim(); //检查教室结果
objCurrEduCls_SynEN.CheckAdminCls = objRow[conCurrEduCls_Syn.CheckAdminCls] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckAdminCls].ToString().Trim(); //检查行政班结果
objCurrEduCls_SynEN.CheckTeacher = objRow[conCurrEduCls_Syn.CheckTeacher] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckTeacher].ToString().Trim(); //检查教师结果
objCurrEduCls_SynEN.EditLocked = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.EditLocked].ToString().Trim()); //编辑锁定
objCurrEduCls_SynEN.Sched = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.Sched].ToString().Trim()); //是否排课
objCurrEduCls_SynEN.IdUniZone = objRow[conCurrEduCls_Syn.IdUniZone] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdUniZone].ToString().Trim(); //校区流水号
objCurrEduCls_SynEN.Locked = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.Locked].ToString().Trim()); //锁定状态
objCurrEduCls_SynEN.IdGradeBase = objRow[conCurrEduCls_Syn.IdGradeBase] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdGradeBase].ToString().Trim(); //年级流水号
objCurrEduCls_SynEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsEffective].ToString().Trim()); //是否有效
objCurrEduCls_SynEN.IsForPaperReading = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objCurrEduCls_SynEN.IsUnDeterminedClsRm = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsUnDeterminedClsRm].ToString().Trim()); //是否待定教室
objCurrEduCls_SynEN.SchoolYear = objRow[conCurrEduCls_Syn.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SchoolYear].ToString().Trim(); //学年
objCurrEduCls_SynEN.SchoolTerm = objRow[conCurrEduCls_Syn.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SchoolTerm].ToString().Trim(); //学期
objCurrEduCls_SynEN.ArrangeCourseMemo = objRow[conCurrEduCls_Syn.ArrangeCourseMemo] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ArrangeCourseMemo].ToString().Trim(); //排课备注
objCurrEduCls_SynEN.IdCourseType = objRow[conCurrEduCls_Syn.IdCourseType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdCourseType].ToString().Trim(); //课程类型流水号
objCurrEduCls_SynEN.ExportDate = objRow[conCurrEduCls_Syn.ExportDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ExportDate].ToString().Trim(); //导出日期
objCurrEduCls_SynEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsDegree].ToString().Trim()); //是否学位课
objCurrEduCls_SynEN.IdScoreType = objRow[conCurrEduCls_Syn.IdScoreType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdScoreType].ToString().Trim(); //成绩类型流水号
objCurrEduCls_SynEN.GetScoreWayId = objRow[conCurrEduCls_Syn.GetScoreWayId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objCurrEduCls_SynEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objCurrEduCls_SynEN.IdExamType = objRow[conCurrEduCls_Syn.IdExamType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdExamType].ToString().Trim(); //考试方式流水号
objCurrEduCls_SynEN.ExamPortion = objRow[conCurrEduCls_Syn.ExamPortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.ExamPortion].ToString().Trim()); //平时成绩所占比例
objCurrEduCls_SynEN.MidExamScorePortion = objRow[conCurrEduCls_Syn.MidExamScorePortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.MidExamScorePortion].ToString().Trim()); //期末成绩所占比例
objCurrEduCls_SynEN.IsClearScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsClearScore].ToString().Trim()); //是否重录成绩
objCurrEduCls_SynEN.IsGeneratePwd = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsGeneratePwd].ToString().Trim()); //是否生成口令
objCurrEduCls_SynEN.GeneratePwdDate = objRow[conCurrEduCls_Syn.GeneratePwdDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.GeneratePwdDate].ToString().Trim(); //生成口令时间
objCurrEduCls_SynEN.IsExportToGP = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsExportToGP].ToString().Trim()); //是否导出到平台
objCurrEduCls_SynEN.IsExportToGPWeb = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsExportToGPWeb].ToString().Trim()); //是否导出到Web平台
objCurrEduCls_SynEN.IsReservedDecimal = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsReservedDecimal].ToString().Trim()); //是否保留小数
objCurrEduCls_SynEN.ExamTime = objRow[conCurrEduCls_Syn.ExamTime] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ExamTime].ToString().Trim(); //考试时间
objCurrEduCls_SynEN.CheckState = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.CheckState].ToString().Trim()); //检查状态
objCurrEduCls_SynEN.CheckDate = objRow[conCurrEduCls_Syn.CheckDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckDate].ToString().Trim(); //检查日期
objCurrEduCls_SynEN.IdEduClassInPk = objRow[conCurrEduCls_Syn.IdEduClassInPk] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdEduClassInPk].ToString().Trim(); //id_EduClassInPk
objCurrEduCls_SynEN.PkWeekTime = objRow[conCurrEduCls_Syn.PkWeekTime] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.PkWeekTime].ToString().Trim(); //排课时间
objCurrEduCls_SynEN.PkClassRooms = objRow[conCurrEduCls_Syn.PkClassRooms] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.PkClassRooms].ToString().Trim(); //排课教室
objCurrEduCls_SynEN.BeginWeek = objRow[conCurrEduCls_Syn.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.BeginWeek].ToString().Trim()); //开始周
objCurrEduCls_SynEN.TeacherNames = objRow[conCurrEduCls_Syn.TeacherNames] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.TeacherNames].ToString().Trim(); //教师姓名
objCurrEduCls_SynEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsSynch].ToString().Trim()); //是否同步
objCurrEduCls_SynEN.SynchDate = objRow[conCurrEduCls_Syn.SynchDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SynchDate].ToString().Trim(); //同步日期
objCurrEduCls_SynEN.ModifyDate = objRow[conCurrEduCls_Syn.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ModifyDate].ToString().Trim(); //修改日期
objCurrEduCls_SynEN.ModifyUserId = objRow[conCurrEduCls_Syn.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ModifyUserId].ToString().Trim(); //修改人
objCurrEduCls_SynEN.Memo = objRow[conCurrEduCls_Syn.Memo] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.Memo].ToString().Trim(); //备注
objCurrEduCls_SynEN.SignInDate = objRow[conCurrEduCls_Syn.SignInDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SignInDate].ToString().Trim(); //签入时间
objCurrEduCls_SynEN.SignInStateID = objRow[conCurrEduCls_Syn.SignInStateID] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SignInStateID].ToString().Trim(); //签入状态表流水号
objCurrEduCls_SynEN.SignInUser = objRow[conCurrEduCls_Syn.SignInUser] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SignInUser].ToString().Trim(); //签入人
objCurrEduCls_SynEN.SynchToWebUser = objRow[conCurrEduCls_Syn.SynchToWebUser] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SynchToWebUser].ToString().Trim(); //同步Web用户
objCurrEduCls_SynEN.IsSynchToWeb = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsSynchToWeb].ToString().Trim()); //是否同步Web
objCurrEduCls_SynEN.SynchToWebDate = objRow[conCurrEduCls_Syn.SynchToWebDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SynchToWebDate].ToString().Trim(); //同步Web日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduCls_SynEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduCls_SynEN);
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
public static List<clsCurrEduCls_SynEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsCurrEduCls_SynEN> arrObjLst = new List<clsCurrEduCls_SynEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduCls_SynEN objCurrEduCls_SynEN = new clsCurrEduCls_SynEN();
try
{
objCurrEduCls_SynEN.IdCurrEduCls = objRow[conCurrEduCls_Syn.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduCls_SynEN.CurrEduClsId = objRow[conCurrEduCls_Syn.CurrEduClsId].ToString().Trim(); //教学班Id
objCurrEduCls_SynEN.EduClsName = objRow[conCurrEduCls_Syn.EduClsName] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.EduClsName].ToString().Trim(); //教学班名
objCurrEduCls_SynEN.EduClsTypeId = objRow[conCurrEduCls_Syn.EduClsTypeId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.EduClsTypeId].ToString().Trim(); //教学班类型Id
objCurrEduCls_SynEN.CourseId = objRow[conCurrEduCls_Syn.CourseId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CourseId].ToString().Trim(); //课程Id
objCurrEduCls_SynEN.TeachingSolutionId = objRow[conCurrEduCls_Syn.TeachingSolutionId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCurrEduCls_SynEN.IdXzCollege = objRow[conCurrEduCls_Syn.IdXzCollege] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdXzCollege].ToString().Trim(); //学院流水号
objCurrEduCls_SynEN.IdMajor = objRow[conCurrEduCls_Syn.IdMajor].ToString().Trim(); //专业流水号
objCurrEduCls_SynEN.IdEduWay = objRow[conCurrEduCls_Syn.IdEduWay] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdEduWay].ToString().Trim(); //教学方式流水号
objCurrEduCls_SynEN.IdClassRoomType = objRow[conCurrEduCls_Syn.IdClassRoomType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdClassRoomType].ToString().Trim(); //教室类型流水号
objCurrEduCls_SynEN.TotalLessonQty = objRow[conCurrEduCls_Syn.TotalLessonQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls_Syn.TotalLessonQty].ToString().Trim()); //总课时数
objCurrEduCls_SynEN.MaxStuQty = objRow[conCurrEduCls_Syn.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls_Syn.MaxStuQty].ToString().Trim()); //最大学生数
objCurrEduCls_SynEN.CurrentStuQty = objRow[conCurrEduCls_Syn.CurrentStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls_Syn.CurrentStuQty].ToString().Trim()); //当前学生数
objCurrEduCls_SynEN.WeekQty = objRow[conCurrEduCls_Syn.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls_Syn.WeekQty].ToString().Trim()); //总周数
objCurrEduCls_SynEN.ScheUnitPW = objRow[conCurrEduCls_Syn.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.ScheUnitPW].ToString().Trim()); //周排课次数
objCurrEduCls_SynEN.WeekStatusId = objRow[conCurrEduCls_Syn.WeekStatusId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objCurrEduCls_SynEN.CustomerWeek = objRow[conCurrEduCls_Syn.CustomerWeek] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CustomerWeek].ToString().Trim(); //自定义上课周
objCurrEduCls_SynEN.IsCompleteScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsCompleteScore].ToString().Trim()); //是否成绩齐全
objCurrEduCls_SynEN.IdExecPlan = objRow[conCurrEduCls_Syn.IdExecPlan] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdExecPlan].ToString().Trim(); //执行计划流水号
objCurrEduCls_SynEN.LessonQtyPerWeek = objRow[conCurrEduCls_Syn.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.LessonQtyPerWeek].ToString().Trim()); //周课时数
objCurrEduCls_SynEN.Mark = objRow[conCurrEduCls_Syn.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduCls_Syn.Mark].ToString().Trim()); //获得学分
objCurrEduCls_SynEN.CheckClassRoom = objRow[conCurrEduCls_Syn.CheckClassRoom] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckClassRoom].ToString().Trim(); //检查教室结果
objCurrEduCls_SynEN.CheckAdminCls = objRow[conCurrEduCls_Syn.CheckAdminCls] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckAdminCls].ToString().Trim(); //检查行政班结果
objCurrEduCls_SynEN.CheckTeacher = objRow[conCurrEduCls_Syn.CheckTeacher] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckTeacher].ToString().Trim(); //检查教师结果
objCurrEduCls_SynEN.EditLocked = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.EditLocked].ToString().Trim()); //编辑锁定
objCurrEduCls_SynEN.Sched = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.Sched].ToString().Trim()); //是否排课
objCurrEduCls_SynEN.IdUniZone = objRow[conCurrEduCls_Syn.IdUniZone] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdUniZone].ToString().Trim(); //校区流水号
objCurrEduCls_SynEN.Locked = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.Locked].ToString().Trim()); //锁定状态
objCurrEduCls_SynEN.IdGradeBase = objRow[conCurrEduCls_Syn.IdGradeBase] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdGradeBase].ToString().Trim(); //年级流水号
objCurrEduCls_SynEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsEffective].ToString().Trim()); //是否有效
objCurrEduCls_SynEN.IsForPaperReading = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objCurrEduCls_SynEN.IsUnDeterminedClsRm = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsUnDeterminedClsRm].ToString().Trim()); //是否待定教室
objCurrEduCls_SynEN.SchoolYear = objRow[conCurrEduCls_Syn.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SchoolYear].ToString().Trim(); //学年
objCurrEduCls_SynEN.SchoolTerm = objRow[conCurrEduCls_Syn.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SchoolTerm].ToString().Trim(); //学期
objCurrEduCls_SynEN.ArrangeCourseMemo = objRow[conCurrEduCls_Syn.ArrangeCourseMemo] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ArrangeCourseMemo].ToString().Trim(); //排课备注
objCurrEduCls_SynEN.IdCourseType = objRow[conCurrEduCls_Syn.IdCourseType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdCourseType].ToString().Trim(); //课程类型流水号
objCurrEduCls_SynEN.ExportDate = objRow[conCurrEduCls_Syn.ExportDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ExportDate].ToString().Trim(); //导出日期
objCurrEduCls_SynEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsDegree].ToString().Trim()); //是否学位课
objCurrEduCls_SynEN.IdScoreType = objRow[conCurrEduCls_Syn.IdScoreType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdScoreType].ToString().Trim(); //成绩类型流水号
objCurrEduCls_SynEN.GetScoreWayId = objRow[conCurrEduCls_Syn.GetScoreWayId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objCurrEduCls_SynEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objCurrEduCls_SynEN.IdExamType = objRow[conCurrEduCls_Syn.IdExamType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdExamType].ToString().Trim(); //考试方式流水号
objCurrEduCls_SynEN.ExamPortion = objRow[conCurrEduCls_Syn.ExamPortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.ExamPortion].ToString().Trim()); //平时成绩所占比例
objCurrEduCls_SynEN.MidExamScorePortion = objRow[conCurrEduCls_Syn.MidExamScorePortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.MidExamScorePortion].ToString().Trim()); //期末成绩所占比例
objCurrEduCls_SynEN.IsClearScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsClearScore].ToString().Trim()); //是否重录成绩
objCurrEduCls_SynEN.IsGeneratePwd = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsGeneratePwd].ToString().Trim()); //是否生成口令
objCurrEduCls_SynEN.GeneratePwdDate = objRow[conCurrEduCls_Syn.GeneratePwdDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.GeneratePwdDate].ToString().Trim(); //生成口令时间
objCurrEduCls_SynEN.IsExportToGP = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsExportToGP].ToString().Trim()); //是否导出到平台
objCurrEduCls_SynEN.IsExportToGPWeb = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsExportToGPWeb].ToString().Trim()); //是否导出到Web平台
objCurrEduCls_SynEN.IsReservedDecimal = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsReservedDecimal].ToString().Trim()); //是否保留小数
objCurrEduCls_SynEN.ExamTime = objRow[conCurrEduCls_Syn.ExamTime] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ExamTime].ToString().Trim(); //考试时间
objCurrEduCls_SynEN.CheckState = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.CheckState].ToString().Trim()); //检查状态
objCurrEduCls_SynEN.CheckDate = objRow[conCurrEduCls_Syn.CheckDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckDate].ToString().Trim(); //检查日期
objCurrEduCls_SynEN.IdEduClassInPk = objRow[conCurrEduCls_Syn.IdEduClassInPk] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdEduClassInPk].ToString().Trim(); //id_EduClassInPk
objCurrEduCls_SynEN.PkWeekTime = objRow[conCurrEduCls_Syn.PkWeekTime] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.PkWeekTime].ToString().Trim(); //排课时间
objCurrEduCls_SynEN.PkClassRooms = objRow[conCurrEduCls_Syn.PkClassRooms] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.PkClassRooms].ToString().Trim(); //排课教室
objCurrEduCls_SynEN.BeginWeek = objRow[conCurrEduCls_Syn.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.BeginWeek].ToString().Trim()); //开始周
objCurrEduCls_SynEN.TeacherNames = objRow[conCurrEduCls_Syn.TeacherNames] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.TeacherNames].ToString().Trim(); //教师姓名
objCurrEduCls_SynEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsSynch].ToString().Trim()); //是否同步
objCurrEduCls_SynEN.SynchDate = objRow[conCurrEduCls_Syn.SynchDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SynchDate].ToString().Trim(); //同步日期
objCurrEduCls_SynEN.ModifyDate = objRow[conCurrEduCls_Syn.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ModifyDate].ToString().Trim(); //修改日期
objCurrEduCls_SynEN.ModifyUserId = objRow[conCurrEduCls_Syn.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ModifyUserId].ToString().Trim(); //修改人
objCurrEduCls_SynEN.Memo = objRow[conCurrEduCls_Syn.Memo] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.Memo].ToString().Trim(); //备注
objCurrEduCls_SynEN.SignInDate = objRow[conCurrEduCls_Syn.SignInDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SignInDate].ToString().Trim(); //签入时间
objCurrEduCls_SynEN.SignInStateID = objRow[conCurrEduCls_Syn.SignInStateID] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SignInStateID].ToString().Trim(); //签入状态表流水号
objCurrEduCls_SynEN.SignInUser = objRow[conCurrEduCls_Syn.SignInUser] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SignInUser].ToString().Trim(); //签入人
objCurrEduCls_SynEN.SynchToWebUser = objRow[conCurrEduCls_Syn.SynchToWebUser] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SynchToWebUser].ToString().Trim(); //同步Web用户
objCurrEduCls_SynEN.IsSynchToWeb = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsSynchToWeb].ToString().Trim()); //是否同步Web
objCurrEduCls_SynEN.SynchToWebDate = objRow[conCurrEduCls_Syn.SynchToWebDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SynchToWebDate].ToString().Trim(); //同步Web日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduCls_SynEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduCls_SynEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsCurrEduCls_SynEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsCurrEduCls_SynEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsCurrEduCls_SynEN> arrObjLst = new List<clsCurrEduCls_SynEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduCls_SynEN objCurrEduCls_SynEN = new clsCurrEduCls_SynEN();
try
{
objCurrEduCls_SynEN.IdCurrEduCls = objRow[conCurrEduCls_Syn.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduCls_SynEN.CurrEduClsId = objRow[conCurrEduCls_Syn.CurrEduClsId].ToString().Trim(); //教学班Id
objCurrEduCls_SynEN.EduClsName = objRow[conCurrEduCls_Syn.EduClsName] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.EduClsName].ToString().Trim(); //教学班名
objCurrEduCls_SynEN.EduClsTypeId = objRow[conCurrEduCls_Syn.EduClsTypeId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.EduClsTypeId].ToString().Trim(); //教学班类型Id
objCurrEduCls_SynEN.CourseId = objRow[conCurrEduCls_Syn.CourseId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CourseId].ToString().Trim(); //课程Id
objCurrEduCls_SynEN.TeachingSolutionId = objRow[conCurrEduCls_Syn.TeachingSolutionId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCurrEduCls_SynEN.IdXzCollege = objRow[conCurrEduCls_Syn.IdXzCollege] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdXzCollege].ToString().Trim(); //学院流水号
objCurrEduCls_SynEN.IdMajor = objRow[conCurrEduCls_Syn.IdMajor].ToString().Trim(); //专业流水号
objCurrEduCls_SynEN.IdEduWay = objRow[conCurrEduCls_Syn.IdEduWay] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdEduWay].ToString().Trim(); //教学方式流水号
objCurrEduCls_SynEN.IdClassRoomType = objRow[conCurrEduCls_Syn.IdClassRoomType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdClassRoomType].ToString().Trim(); //教室类型流水号
objCurrEduCls_SynEN.TotalLessonQty = objRow[conCurrEduCls_Syn.TotalLessonQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls_Syn.TotalLessonQty].ToString().Trim()); //总课时数
objCurrEduCls_SynEN.MaxStuQty = objRow[conCurrEduCls_Syn.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls_Syn.MaxStuQty].ToString().Trim()); //最大学生数
objCurrEduCls_SynEN.CurrentStuQty = objRow[conCurrEduCls_Syn.CurrentStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls_Syn.CurrentStuQty].ToString().Trim()); //当前学生数
objCurrEduCls_SynEN.WeekQty = objRow[conCurrEduCls_Syn.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls_Syn.WeekQty].ToString().Trim()); //总周数
objCurrEduCls_SynEN.ScheUnitPW = objRow[conCurrEduCls_Syn.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.ScheUnitPW].ToString().Trim()); //周排课次数
objCurrEduCls_SynEN.WeekStatusId = objRow[conCurrEduCls_Syn.WeekStatusId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objCurrEduCls_SynEN.CustomerWeek = objRow[conCurrEduCls_Syn.CustomerWeek] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CustomerWeek].ToString().Trim(); //自定义上课周
objCurrEduCls_SynEN.IsCompleteScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsCompleteScore].ToString().Trim()); //是否成绩齐全
objCurrEduCls_SynEN.IdExecPlan = objRow[conCurrEduCls_Syn.IdExecPlan] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdExecPlan].ToString().Trim(); //执行计划流水号
objCurrEduCls_SynEN.LessonQtyPerWeek = objRow[conCurrEduCls_Syn.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.LessonQtyPerWeek].ToString().Trim()); //周课时数
objCurrEduCls_SynEN.Mark = objRow[conCurrEduCls_Syn.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduCls_Syn.Mark].ToString().Trim()); //获得学分
objCurrEduCls_SynEN.CheckClassRoom = objRow[conCurrEduCls_Syn.CheckClassRoom] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckClassRoom].ToString().Trim(); //检查教室结果
objCurrEduCls_SynEN.CheckAdminCls = objRow[conCurrEduCls_Syn.CheckAdminCls] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckAdminCls].ToString().Trim(); //检查行政班结果
objCurrEduCls_SynEN.CheckTeacher = objRow[conCurrEduCls_Syn.CheckTeacher] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckTeacher].ToString().Trim(); //检查教师结果
objCurrEduCls_SynEN.EditLocked = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.EditLocked].ToString().Trim()); //编辑锁定
objCurrEduCls_SynEN.Sched = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.Sched].ToString().Trim()); //是否排课
objCurrEduCls_SynEN.IdUniZone = objRow[conCurrEduCls_Syn.IdUniZone] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdUniZone].ToString().Trim(); //校区流水号
objCurrEduCls_SynEN.Locked = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.Locked].ToString().Trim()); //锁定状态
objCurrEduCls_SynEN.IdGradeBase = objRow[conCurrEduCls_Syn.IdGradeBase] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdGradeBase].ToString().Trim(); //年级流水号
objCurrEduCls_SynEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsEffective].ToString().Trim()); //是否有效
objCurrEduCls_SynEN.IsForPaperReading = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objCurrEduCls_SynEN.IsUnDeterminedClsRm = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsUnDeterminedClsRm].ToString().Trim()); //是否待定教室
objCurrEduCls_SynEN.SchoolYear = objRow[conCurrEduCls_Syn.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SchoolYear].ToString().Trim(); //学年
objCurrEduCls_SynEN.SchoolTerm = objRow[conCurrEduCls_Syn.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SchoolTerm].ToString().Trim(); //学期
objCurrEduCls_SynEN.ArrangeCourseMemo = objRow[conCurrEduCls_Syn.ArrangeCourseMemo] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ArrangeCourseMemo].ToString().Trim(); //排课备注
objCurrEduCls_SynEN.IdCourseType = objRow[conCurrEduCls_Syn.IdCourseType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdCourseType].ToString().Trim(); //课程类型流水号
objCurrEduCls_SynEN.ExportDate = objRow[conCurrEduCls_Syn.ExportDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ExportDate].ToString().Trim(); //导出日期
objCurrEduCls_SynEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsDegree].ToString().Trim()); //是否学位课
objCurrEduCls_SynEN.IdScoreType = objRow[conCurrEduCls_Syn.IdScoreType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdScoreType].ToString().Trim(); //成绩类型流水号
objCurrEduCls_SynEN.GetScoreWayId = objRow[conCurrEduCls_Syn.GetScoreWayId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objCurrEduCls_SynEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objCurrEduCls_SynEN.IdExamType = objRow[conCurrEduCls_Syn.IdExamType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdExamType].ToString().Trim(); //考试方式流水号
objCurrEduCls_SynEN.ExamPortion = objRow[conCurrEduCls_Syn.ExamPortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.ExamPortion].ToString().Trim()); //平时成绩所占比例
objCurrEduCls_SynEN.MidExamScorePortion = objRow[conCurrEduCls_Syn.MidExamScorePortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.MidExamScorePortion].ToString().Trim()); //期末成绩所占比例
objCurrEduCls_SynEN.IsClearScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsClearScore].ToString().Trim()); //是否重录成绩
objCurrEduCls_SynEN.IsGeneratePwd = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsGeneratePwd].ToString().Trim()); //是否生成口令
objCurrEduCls_SynEN.GeneratePwdDate = objRow[conCurrEduCls_Syn.GeneratePwdDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.GeneratePwdDate].ToString().Trim(); //生成口令时间
objCurrEduCls_SynEN.IsExportToGP = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsExportToGP].ToString().Trim()); //是否导出到平台
objCurrEduCls_SynEN.IsExportToGPWeb = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsExportToGPWeb].ToString().Trim()); //是否导出到Web平台
objCurrEduCls_SynEN.IsReservedDecimal = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsReservedDecimal].ToString().Trim()); //是否保留小数
objCurrEduCls_SynEN.ExamTime = objRow[conCurrEduCls_Syn.ExamTime] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ExamTime].ToString().Trim(); //考试时间
objCurrEduCls_SynEN.CheckState = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.CheckState].ToString().Trim()); //检查状态
objCurrEduCls_SynEN.CheckDate = objRow[conCurrEduCls_Syn.CheckDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckDate].ToString().Trim(); //检查日期
objCurrEduCls_SynEN.IdEduClassInPk = objRow[conCurrEduCls_Syn.IdEduClassInPk] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdEduClassInPk].ToString().Trim(); //id_EduClassInPk
objCurrEduCls_SynEN.PkWeekTime = objRow[conCurrEduCls_Syn.PkWeekTime] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.PkWeekTime].ToString().Trim(); //排课时间
objCurrEduCls_SynEN.PkClassRooms = objRow[conCurrEduCls_Syn.PkClassRooms] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.PkClassRooms].ToString().Trim(); //排课教室
objCurrEduCls_SynEN.BeginWeek = objRow[conCurrEduCls_Syn.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.BeginWeek].ToString().Trim()); //开始周
objCurrEduCls_SynEN.TeacherNames = objRow[conCurrEduCls_Syn.TeacherNames] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.TeacherNames].ToString().Trim(); //教师姓名
objCurrEduCls_SynEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsSynch].ToString().Trim()); //是否同步
objCurrEduCls_SynEN.SynchDate = objRow[conCurrEduCls_Syn.SynchDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SynchDate].ToString().Trim(); //同步日期
objCurrEduCls_SynEN.ModifyDate = objRow[conCurrEduCls_Syn.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ModifyDate].ToString().Trim(); //修改日期
objCurrEduCls_SynEN.ModifyUserId = objRow[conCurrEduCls_Syn.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ModifyUserId].ToString().Trim(); //修改人
objCurrEduCls_SynEN.Memo = objRow[conCurrEduCls_Syn.Memo] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.Memo].ToString().Trim(); //备注
objCurrEduCls_SynEN.SignInDate = objRow[conCurrEduCls_Syn.SignInDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SignInDate].ToString().Trim(); //签入时间
objCurrEduCls_SynEN.SignInStateID = objRow[conCurrEduCls_Syn.SignInStateID] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SignInStateID].ToString().Trim(); //签入状态表流水号
objCurrEduCls_SynEN.SignInUser = objRow[conCurrEduCls_Syn.SignInUser] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SignInUser].ToString().Trim(); //签入人
objCurrEduCls_SynEN.SynchToWebUser = objRow[conCurrEduCls_Syn.SynchToWebUser] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SynchToWebUser].ToString().Trim(); //同步Web用户
objCurrEduCls_SynEN.IsSynchToWeb = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsSynchToWeb].ToString().Trim()); //是否同步Web
objCurrEduCls_SynEN.SynchToWebDate = objRow[conCurrEduCls_Syn.SynchToWebDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SynchToWebDate].ToString().Trim(); //同步Web日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduCls_SynEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduCls_SynEN);
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
public static List<clsCurrEduCls_SynEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsCurrEduCls_SynEN> arrObjLst = new List<clsCurrEduCls_SynEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduCls_SynEN objCurrEduCls_SynEN = new clsCurrEduCls_SynEN();
try
{
objCurrEduCls_SynEN.IdCurrEduCls = objRow[conCurrEduCls_Syn.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduCls_SynEN.CurrEduClsId = objRow[conCurrEduCls_Syn.CurrEduClsId].ToString().Trim(); //教学班Id
objCurrEduCls_SynEN.EduClsName = objRow[conCurrEduCls_Syn.EduClsName] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.EduClsName].ToString().Trim(); //教学班名
objCurrEduCls_SynEN.EduClsTypeId = objRow[conCurrEduCls_Syn.EduClsTypeId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.EduClsTypeId].ToString().Trim(); //教学班类型Id
objCurrEduCls_SynEN.CourseId = objRow[conCurrEduCls_Syn.CourseId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CourseId].ToString().Trim(); //课程Id
objCurrEduCls_SynEN.TeachingSolutionId = objRow[conCurrEduCls_Syn.TeachingSolutionId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCurrEduCls_SynEN.IdXzCollege = objRow[conCurrEduCls_Syn.IdXzCollege] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdXzCollege].ToString().Trim(); //学院流水号
objCurrEduCls_SynEN.IdMajor = objRow[conCurrEduCls_Syn.IdMajor].ToString().Trim(); //专业流水号
objCurrEduCls_SynEN.IdEduWay = objRow[conCurrEduCls_Syn.IdEduWay] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdEduWay].ToString().Trim(); //教学方式流水号
objCurrEduCls_SynEN.IdClassRoomType = objRow[conCurrEduCls_Syn.IdClassRoomType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdClassRoomType].ToString().Trim(); //教室类型流水号
objCurrEduCls_SynEN.TotalLessonQty = objRow[conCurrEduCls_Syn.TotalLessonQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls_Syn.TotalLessonQty].ToString().Trim()); //总课时数
objCurrEduCls_SynEN.MaxStuQty = objRow[conCurrEduCls_Syn.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls_Syn.MaxStuQty].ToString().Trim()); //最大学生数
objCurrEduCls_SynEN.CurrentStuQty = objRow[conCurrEduCls_Syn.CurrentStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls_Syn.CurrentStuQty].ToString().Trim()); //当前学生数
objCurrEduCls_SynEN.WeekQty = objRow[conCurrEduCls_Syn.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls_Syn.WeekQty].ToString().Trim()); //总周数
objCurrEduCls_SynEN.ScheUnitPW = objRow[conCurrEduCls_Syn.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.ScheUnitPW].ToString().Trim()); //周排课次数
objCurrEduCls_SynEN.WeekStatusId = objRow[conCurrEduCls_Syn.WeekStatusId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objCurrEduCls_SynEN.CustomerWeek = objRow[conCurrEduCls_Syn.CustomerWeek] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CustomerWeek].ToString().Trim(); //自定义上课周
objCurrEduCls_SynEN.IsCompleteScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsCompleteScore].ToString().Trim()); //是否成绩齐全
objCurrEduCls_SynEN.IdExecPlan = objRow[conCurrEduCls_Syn.IdExecPlan] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdExecPlan].ToString().Trim(); //执行计划流水号
objCurrEduCls_SynEN.LessonQtyPerWeek = objRow[conCurrEduCls_Syn.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.LessonQtyPerWeek].ToString().Trim()); //周课时数
objCurrEduCls_SynEN.Mark = objRow[conCurrEduCls_Syn.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduCls_Syn.Mark].ToString().Trim()); //获得学分
objCurrEduCls_SynEN.CheckClassRoom = objRow[conCurrEduCls_Syn.CheckClassRoom] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckClassRoom].ToString().Trim(); //检查教室结果
objCurrEduCls_SynEN.CheckAdminCls = objRow[conCurrEduCls_Syn.CheckAdminCls] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckAdminCls].ToString().Trim(); //检查行政班结果
objCurrEduCls_SynEN.CheckTeacher = objRow[conCurrEduCls_Syn.CheckTeacher] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckTeacher].ToString().Trim(); //检查教师结果
objCurrEduCls_SynEN.EditLocked = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.EditLocked].ToString().Trim()); //编辑锁定
objCurrEduCls_SynEN.Sched = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.Sched].ToString().Trim()); //是否排课
objCurrEduCls_SynEN.IdUniZone = objRow[conCurrEduCls_Syn.IdUniZone] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdUniZone].ToString().Trim(); //校区流水号
objCurrEduCls_SynEN.Locked = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.Locked].ToString().Trim()); //锁定状态
objCurrEduCls_SynEN.IdGradeBase = objRow[conCurrEduCls_Syn.IdGradeBase] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdGradeBase].ToString().Trim(); //年级流水号
objCurrEduCls_SynEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsEffective].ToString().Trim()); //是否有效
objCurrEduCls_SynEN.IsForPaperReading = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objCurrEduCls_SynEN.IsUnDeterminedClsRm = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsUnDeterminedClsRm].ToString().Trim()); //是否待定教室
objCurrEduCls_SynEN.SchoolYear = objRow[conCurrEduCls_Syn.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SchoolYear].ToString().Trim(); //学年
objCurrEduCls_SynEN.SchoolTerm = objRow[conCurrEduCls_Syn.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SchoolTerm].ToString().Trim(); //学期
objCurrEduCls_SynEN.ArrangeCourseMemo = objRow[conCurrEduCls_Syn.ArrangeCourseMemo] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ArrangeCourseMemo].ToString().Trim(); //排课备注
objCurrEduCls_SynEN.IdCourseType = objRow[conCurrEduCls_Syn.IdCourseType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdCourseType].ToString().Trim(); //课程类型流水号
objCurrEduCls_SynEN.ExportDate = objRow[conCurrEduCls_Syn.ExportDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ExportDate].ToString().Trim(); //导出日期
objCurrEduCls_SynEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsDegree].ToString().Trim()); //是否学位课
objCurrEduCls_SynEN.IdScoreType = objRow[conCurrEduCls_Syn.IdScoreType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdScoreType].ToString().Trim(); //成绩类型流水号
objCurrEduCls_SynEN.GetScoreWayId = objRow[conCurrEduCls_Syn.GetScoreWayId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objCurrEduCls_SynEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objCurrEduCls_SynEN.IdExamType = objRow[conCurrEduCls_Syn.IdExamType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdExamType].ToString().Trim(); //考试方式流水号
objCurrEduCls_SynEN.ExamPortion = objRow[conCurrEduCls_Syn.ExamPortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.ExamPortion].ToString().Trim()); //平时成绩所占比例
objCurrEduCls_SynEN.MidExamScorePortion = objRow[conCurrEduCls_Syn.MidExamScorePortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.MidExamScorePortion].ToString().Trim()); //期末成绩所占比例
objCurrEduCls_SynEN.IsClearScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsClearScore].ToString().Trim()); //是否重录成绩
objCurrEduCls_SynEN.IsGeneratePwd = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsGeneratePwd].ToString().Trim()); //是否生成口令
objCurrEduCls_SynEN.GeneratePwdDate = objRow[conCurrEduCls_Syn.GeneratePwdDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.GeneratePwdDate].ToString().Trim(); //生成口令时间
objCurrEduCls_SynEN.IsExportToGP = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsExportToGP].ToString().Trim()); //是否导出到平台
objCurrEduCls_SynEN.IsExportToGPWeb = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsExportToGPWeb].ToString().Trim()); //是否导出到Web平台
objCurrEduCls_SynEN.IsReservedDecimal = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsReservedDecimal].ToString().Trim()); //是否保留小数
objCurrEduCls_SynEN.ExamTime = objRow[conCurrEduCls_Syn.ExamTime] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ExamTime].ToString().Trim(); //考试时间
objCurrEduCls_SynEN.CheckState = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.CheckState].ToString().Trim()); //检查状态
objCurrEduCls_SynEN.CheckDate = objRow[conCurrEduCls_Syn.CheckDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckDate].ToString().Trim(); //检查日期
objCurrEduCls_SynEN.IdEduClassInPk = objRow[conCurrEduCls_Syn.IdEduClassInPk] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdEduClassInPk].ToString().Trim(); //id_EduClassInPk
objCurrEduCls_SynEN.PkWeekTime = objRow[conCurrEduCls_Syn.PkWeekTime] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.PkWeekTime].ToString().Trim(); //排课时间
objCurrEduCls_SynEN.PkClassRooms = objRow[conCurrEduCls_Syn.PkClassRooms] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.PkClassRooms].ToString().Trim(); //排课教室
objCurrEduCls_SynEN.BeginWeek = objRow[conCurrEduCls_Syn.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.BeginWeek].ToString().Trim()); //开始周
objCurrEduCls_SynEN.TeacherNames = objRow[conCurrEduCls_Syn.TeacherNames] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.TeacherNames].ToString().Trim(); //教师姓名
objCurrEduCls_SynEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsSynch].ToString().Trim()); //是否同步
objCurrEduCls_SynEN.SynchDate = objRow[conCurrEduCls_Syn.SynchDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SynchDate].ToString().Trim(); //同步日期
objCurrEduCls_SynEN.ModifyDate = objRow[conCurrEduCls_Syn.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ModifyDate].ToString().Trim(); //修改日期
objCurrEduCls_SynEN.ModifyUserId = objRow[conCurrEduCls_Syn.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ModifyUserId].ToString().Trim(); //修改人
objCurrEduCls_SynEN.Memo = objRow[conCurrEduCls_Syn.Memo] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.Memo].ToString().Trim(); //备注
objCurrEduCls_SynEN.SignInDate = objRow[conCurrEduCls_Syn.SignInDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SignInDate].ToString().Trim(); //签入时间
objCurrEduCls_SynEN.SignInStateID = objRow[conCurrEduCls_Syn.SignInStateID] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SignInStateID].ToString().Trim(); //签入状态表流水号
objCurrEduCls_SynEN.SignInUser = objRow[conCurrEduCls_Syn.SignInUser] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SignInUser].ToString().Trim(); //签入人
objCurrEduCls_SynEN.SynchToWebUser = objRow[conCurrEduCls_Syn.SynchToWebUser] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SynchToWebUser].ToString().Trim(); //同步Web用户
objCurrEduCls_SynEN.IsSynchToWeb = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsSynchToWeb].ToString().Trim()); //是否同步Web
objCurrEduCls_SynEN.SynchToWebDate = objRow[conCurrEduCls_Syn.SynchToWebDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SynchToWebDate].ToString().Trim(); //同步Web日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduCls_SynEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduCls_SynEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsCurrEduCls_SynEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsCurrEduCls_SynEN> arrObjLst = new List<clsCurrEduCls_SynEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduCls_SynEN objCurrEduCls_SynEN = new clsCurrEduCls_SynEN();
try
{
objCurrEduCls_SynEN.IdCurrEduCls = objRow[conCurrEduCls_Syn.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduCls_SynEN.CurrEduClsId = objRow[conCurrEduCls_Syn.CurrEduClsId].ToString().Trim(); //教学班Id
objCurrEduCls_SynEN.EduClsName = objRow[conCurrEduCls_Syn.EduClsName] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.EduClsName].ToString().Trim(); //教学班名
objCurrEduCls_SynEN.EduClsTypeId = objRow[conCurrEduCls_Syn.EduClsTypeId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.EduClsTypeId].ToString().Trim(); //教学班类型Id
objCurrEduCls_SynEN.CourseId = objRow[conCurrEduCls_Syn.CourseId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CourseId].ToString().Trim(); //课程Id
objCurrEduCls_SynEN.TeachingSolutionId = objRow[conCurrEduCls_Syn.TeachingSolutionId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCurrEduCls_SynEN.IdXzCollege = objRow[conCurrEduCls_Syn.IdXzCollege] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdXzCollege].ToString().Trim(); //学院流水号
objCurrEduCls_SynEN.IdMajor = objRow[conCurrEduCls_Syn.IdMajor].ToString().Trim(); //专业流水号
objCurrEduCls_SynEN.IdEduWay = objRow[conCurrEduCls_Syn.IdEduWay] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdEduWay].ToString().Trim(); //教学方式流水号
objCurrEduCls_SynEN.IdClassRoomType = objRow[conCurrEduCls_Syn.IdClassRoomType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdClassRoomType].ToString().Trim(); //教室类型流水号
objCurrEduCls_SynEN.TotalLessonQty = objRow[conCurrEduCls_Syn.TotalLessonQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls_Syn.TotalLessonQty].ToString().Trim()); //总课时数
objCurrEduCls_SynEN.MaxStuQty = objRow[conCurrEduCls_Syn.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls_Syn.MaxStuQty].ToString().Trim()); //最大学生数
objCurrEduCls_SynEN.CurrentStuQty = objRow[conCurrEduCls_Syn.CurrentStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls_Syn.CurrentStuQty].ToString().Trim()); //当前学生数
objCurrEduCls_SynEN.WeekQty = objRow[conCurrEduCls_Syn.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls_Syn.WeekQty].ToString().Trim()); //总周数
objCurrEduCls_SynEN.ScheUnitPW = objRow[conCurrEduCls_Syn.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.ScheUnitPW].ToString().Trim()); //周排课次数
objCurrEduCls_SynEN.WeekStatusId = objRow[conCurrEduCls_Syn.WeekStatusId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objCurrEduCls_SynEN.CustomerWeek = objRow[conCurrEduCls_Syn.CustomerWeek] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CustomerWeek].ToString().Trim(); //自定义上课周
objCurrEduCls_SynEN.IsCompleteScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsCompleteScore].ToString().Trim()); //是否成绩齐全
objCurrEduCls_SynEN.IdExecPlan = objRow[conCurrEduCls_Syn.IdExecPlan] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdExecPlan].ToString().Trim(); //执行计划流水号
objCurrEduCls_SynEN.LessonQtyPerWeek = objRow[conCurrEduCls_Syn.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.LessonQtyPerWeek].ToString().Trim()); //周课时数
objCurrEduCls_SynEN.Mark = objRow[conCurrEduCls_Syn.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduCls_Syn.Mark].ToString().Trim()); //获得学分
objCurrEduCls_SynEN.CheckClassRoom = objRow[conCurrEduCls_Syn.CheckClassRoom] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckClassRoom].ToString().Trim(); //检查教室结果
objCurrEduCls_SynEN.CheckAdminCls = objRow[conCurrEduCls_Syn.CheckAdminCls] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckAdminCls].ToString().Trim(); //检查行政班结果
objCurrEduCls_SynEN.CheckTeacher = objRow[conCurrEduCls_Syn.CheckTeacher] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckTeacher].ToString().Trim(); //检查教师结果
objCurrEduCls_SynEN.EditLocked = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.EditLocked].ToString().Trim()); //编辑锁定
objCurrEduCls_SynEN.Sched = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.Sched].ToString().Trim()); //是否排课
objCurrEduCls_SynEN.IdUniZone = objRow[conCurrEduCls_Syn.IdUniZone] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdUniZone].ToString().Trim(); //校区流水号
objCurrEduCls_SynEN.Locked = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.Locked].ToString().Trim()); //锁定状态
objCurrEduCls_SynEN.IdGradeBase = objRow[conCurrEduCls_Syn.IdGradeBase] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdGradeBase].ToString().Trim(); //年级流水号
objCurrEduCls_SynEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsEffective].ToString().Trim()); //是否有效
objCurrEduCls_SynEN.IsForPaperReading = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objCurrEduCls_SynEN.IsUnDeterminedClsRm = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsUnDeterminedClsRm].ToString().Trim()); //是否待定教室
objCurrEduCls_SynEN.SchoolYear = objRow[conCurrEduCls_Syn.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SchoolYear].ToString().Trim(); //学年
objCurrEduCls_SynEN.SchoolTerm = objRow[conCurrEduCls_Syn.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SchoolTerm].ToString().Trim(); //学期
objCurrEduCls_SynEN.ArrangeCourseMemo = objRow[conCurrEduCls_Syn.ArrangeCourseMemo] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ArrangeCourseMemo].ToString().Trim(); //排课备注
objCurrEduCls_SynEN.IdCourseType = objRow[conCurrEduCls_Syn.IdCourseType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdCourseType].ToString().Trim(); //课程类型流水号
objCurrEduCls_SynEN.ExportDate = objRow[conCurrEduCls_Syn.ExportDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ExportDate].ToString().Trim(); //导出日期
objCurrEduCls_SynEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsDegree].ToString().Trim()); //是否学位课
objCurrEduCls_SynEN.IdScoreType = objRow[conCurrEduCls_Syn.IdScoreType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdScoreType].ToString().Trim(); //成绩类型流水号
objCurrEduCls_SynEN.GetScoreWayId = objRow[conCurrEduCls_Syn.GetScoreWayId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objCurrEduCls_SynEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objCurrEduCls_SynEN.IdExamType = objRow[conCurrEduCls_Syn.IdExamType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdExamType].ToString().Trim(); //考试方式流水号
objCurrEduCls_SynEN.ExamPortion = objRow[conCurrEduCls_Syn.ExamPortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.ExamPortion].ToString().Trim()); //平时成绩所占比例
objCurrEduCls_SynEN.MidExamScorePortion = objRow[conCurrEduCls_Syn.MidExamScorePortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.MidExamScorePortion].ToString().Trim()); //期末成绩所占比例
objCurrEduCls_SynEN.IsClearScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsClearScore].ToString().Trim()); //是否重录成绩
objCurrEduCls_SynEN.IsGeneratePwd = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsGeneratePwd].ToString().Trim()); //是否生成口令
objCurrEduCls_SynEN.GeneratePwdDate = objRow[conCurrEduCls_Syn.GeneratePwdDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.GeneratePwdDate].ToString().Trim(); //生成口令时间
objCurrEduCls_SynEN.IsExportToGP = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsExportToGP].ToString().Trim()); //是否导出到平台
objCurrEduCls_SynEN.IsExportToGPWeb = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsExportToGPWeb].ToString().Trim()); //是否导出到Web平台
objCurrEduCls_SynEN.IsReservedDecimal = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsReservedDecimal].ToString().Trim()); //是否保留小数
objCurrEduCls_SynEN.ExamTime = objRow[conCurrEduCls_Syn.ExamTime] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ExamTime].ToString().Trim(); //考试时间
objCurrEduCls_SynEN.CheckState = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.CheckState].ToString().Trim()); //检查状态
objCurrEduCls_SynEN.CheckDate = objRow[conCurrEduCls_Syn.CheckDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckDate].ToString().Trim(); //检查日期
objCurrEduCls_SynEN.IdEduClassInPk = objRow[conCurrEduCls_Syn.IdEduClassInPk] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdEduClassInPk].ToString().Trim(); //id_EduClassInPk
objCurrEduCls_SynEN.PkWeekTime = objRow[conCurrEduCls_Syn.PkWeekTime] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.PkWeekTime].ToString().Trim(); //排课时间
objCurrEduCls_SynEN.PkClassRooms = objRow[conCurrEduCls_Syn.PkClassRooms] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.PkClassRooms].ToString().Trim(); //排课教室
objCurrEduCls_SynEN.BeginWeek = objRow[conCurrEduCls_Syn.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.BeginWeek].ToString().Trim()); //开始周
objCurrEduCls_SynEN.TeacherNames = objRow[conCurrEduCls_Syn.TeacherNames] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.TeacherNames].ToString().Trim(); //教师姓名
objCurrEduCls_SynEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsSynch].ToString().Trim()); //是否同步
objCurrEduCls_SynEN.SynchDate = objRow[conCurrEduCls_Syn.SynchDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SynchDate].ToString().Trim(); //同步日期
objCurrEduCls_SynEN.ModifyDate = objRow[conCurrEduCls_Syn.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ModifyDate].ToString().Trim(); //修改日期
objCurrEduCls_SynEN.ModifyUserId = objRow[conCurrEduCls_Syn.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ModifyUserId].ToString().Trim(); //修改人
objCurrEduCls_SynEN.Memo = objRow[conCurrEduCls_Syn.Memo] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.Memo].ToString().Trim(); //备注
objCurrEduCls_SynEN.SignInDate = objRow[conCurrEduCls_Syn.SignInDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SignInDate].ToString().Trim(); //签入时间
objCurrEduCls_SynEN.SignInStateID = objRow[conCurrEduCls_Syn.SignInStateID] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SignInStateID].ToString().Trim(); //签入状态表流水号
objCurrEduCls_SynEN.SignInUser = objRow[conCurrEduCls_Syn.SignInUser] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SignInUser].ToString().Trim(); //签入人
objCurrEduCls_SynEN.SynchToWebUser = objRow[conCurrEduCls_Syn.SynchToWebUser] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SynchToWebUser].ToString().Trim(); //同步Web用户
objCurrEduCls_SynEN.IsSynchToWeb = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsSynchToWeb].ToString().Trim()); //是否同步Web
objCurrEduCls_SynEN.SynchToWebDate = objRow[conCurrEduCls_Syn.SynchToWebDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SynchToWebDate].ToString().Trim(); //同步Web日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduCls_SynEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduCls_SynEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetCurrEduCls_Syn(ref clsCurrEduCls_SynEN objCurrEduCls_SynEN)
{
bool bolResult = CurrEduCls_SynDA.GetCurrEduCls_Syn(ref objCurrEduCls_SynEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdCurrEduCls">表关键字</param>
 /// <returns>表对象</returns>
public static clsCurrEduCls_SynEN GetObjByIdCurrEduCls(string strIdCurrEduCls)
{
if (strIdCurrEduCls.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdCurrEduCls]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdCurrEduCls]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsCurrEduCls_SynEN objCurrEduCls_SynEN = CurrEduCls_SynDA.GetObjByIdCurrEduCls(strIdCurrEduCls);
return objCurrEduCls_SynEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsCurrEduCls_SynEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsCurrEduCls_SynEN objCurrEduCls_SynEN = CurrEduCls_SynDA.GetFirstObj(strWhereCond);
 return objCurrEduCls_SynEN;
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
public static clsCurrEduCls_SynEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsCurrEduCls_SynEN objCurrEduCls_SynEN = CurrEduCls_SynDA.GetObjByDataRow(objRow);
 return objCurrEduCls_SynEN;
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
public static clsCurrEduCls_SynEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsCurrEduCls_SynEN objCurrEduCls_SynEN = CurrEduCls_SynDA.GetObjByDataRow(objRow);
 return objCurrEduCls_SynEN;
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
 /// <param name = "strIdCurrEduCls">所给的关键字</param>
 /// <param name = "lstCurrEduCls_SynObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCurrEduCls_SynEN GetObjByIdCurrEduClsFromList(string strIdCurrEduCls, List<clsCurrEduCls_SynEN> lstCurrEduCls_SynObjLst)
{
foreach (clsCurrEduCls_SynEN objCurrEduCls_SynEN in lstCurrEduCls_SynObjLst)
{
if (objCurrEduCls_SynEN.IdCurrEduCls == strIdCurrEduCls)
{
return objCurrEduCls_SynEN;
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
 string strMaxIdCurrEduCls;
 try
 {
 strMaxIdCurrEduCls = clsCurrEduCls_SynDA.GetMaxStrId();
 return strMaxIdCurrEduCls;
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
 string strIdCurrEduCls;
 try
 {
 strIdCurrEduCls = new clsCurrEduCls_SynDA().GetFirstID(strWhereCond);
 return strIdCurrEduCls;
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
 arrList = CurrEduCls_SynDA.GetID(strWhereCond);
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
bool bolIsExist = CurrEduCls_SynDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdCurrEduCls">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdCurrEduCls)
{
if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdCurrEduCls]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = CurrEduCls_SynDA.IsExist(strIdCurrEduCls);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strIdCurrEduCls">教学班流水号</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strIdCurrEduCls, string strOpUser)
{
clsCurrEduCls_SynEN objCurrEduCls_SynEN = clsCurrEduCls_SynBL.GetObjByIdCurrEduCls(strIdCurrEduCls);
objCurrEduCls_SynEN.ModifyDate = clsDateTime.getTodayDateTimeStr(1);
objCurrEduCls_SynEN.ModifyUserId = strOpUser;
return clsCurrEduCls_SynBL.UpdateBySql2(objCurrEduCls_SynEN);
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
 bolIsExist = clsCurrEduCls_SynDA.IsExistTable();
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
 bolIsExist = CurrEduCls_SynDA.IsExistTable(strTabName);
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
 /// <param name = "objCurrEduCls_SynEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsCurrEduCls_SynEN objCurrEduCls_SynEN)
{
try
{
 if (string.IsNullOrEmpty(objCurrEduCls_SynEN.IdCurrEduCls) == true || clsCurrEduCls_SynBL.IsExist(objCurrEduCls_SynEN.IdCurrEduCls) == true)
 {
     objCurrEduCls_SynEN.IdCurrEduCls = clsCurrEduCls_SynBL.GetMaxStrId_S();
 }
bool bolResult = CurrEduCls_SynDA.AddNewRecordBySQL2(objCurrEduCls_SynEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduCls_SynBL.ReFreshCache();

if (clsCurrEduCls_SynBL.relatedActions != null)
{
clsCurrEduCls_SynBL.relatedActions.UpdRelaTabDate(objCurrEduCls_SynEN.IdCurrEduCls, objCurrEduCls_SynEN.ModifyUserId);
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
 /// <param name = "objCurrEduCls_SynEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsCurrEduCls_SynEN objCurrEduCls_SynEN)
{
try
{
 if (string.IsNullOrEmpty(objCurrEduCls_SynEN.IdCurrEduCls) == true || clsCurrEduCls_SynBL.IsExist(objCurrEduCls_SynEN.IdCurrEduCls) == true)
 {
     objCurrEduCls_SynEN.IdCurrEduCls = clsCurrEduCls_SynBL.GetMaxStrId_S();
 }
string strKey = CurrEduCls_SynDA.AddNewRecordBySQL2WithReturnKey(objCurrEduCls_SynEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduCls_SynBL.ReFreshCache();

if (clsCurrEduCls_SynBL.relatedActions != null)
{
clsCurrEduCls_SynBL.relatedActions.UpdRelaTabDate(objCurrEduCls_SynEN.IdCurrEduCls, objCurrEduCls_SynEN.ModifyUserId);
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
 /// <param name = "objCurrEduCls_SynEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsCurrEduCls_SynEN objCurrEduCls_SynEN)
{
try
{
bool bolResult = CurrEduCls_SynDA.Update(objCurrEduCls_SynEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduCls_SynBL.ReFreshCache();

if (clsCurrEduCls_SynBL.relatedActions != null)
{
clsCurrEduCls_SynBL.relatedActions.UpdRelaTabDate(objCurrEduCls_SynEN.IdCurrEduCls, objCurrEduCls_SynEN.ModifyUserId);
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
 /// <param name = "objCurrEduCls_SynEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsCurrEduCls_SynEN objCurrEduCls_SynEN)
{
 if (string.IsNullOrEmpty(objCurrEduCls_SynEN.IdCurrEduCls) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = CurrEduCls_SynDA.UpdateBySql2(objCurrEduCls_SynEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduCls_SynBL.ReFreshCache();

if (clsCurrEduCls_SynBL.relatedActions != null)
{
clsCurrEduCls_SynBL.relatedActions.UpdRelaTabDate(objCurrEduCls_SynEN.IdCurrEduCls, objCurrEduCls_SynEN.ModifyUserId);
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
 /// <param name = "strIdCurrEduCls">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strIdCurrEduCls)
{
try
{
 clsCurrEduCls_SynEN objCurrEduCls_SynEN = clsCurrEduCls_SynBL.GetObjByIdCurrEduCls(strIdCurrEduCls);

if (clsCurrEduCls_SynBL.relatedActions != null)
{
clsCurrEduCls_SynBL.relatedActions.UpdRelaTabDate(objCurrEduCls_SynEN.IdCurrEduCls, objCurrEduCls_SynEN.ModifyUserId);
}
if (objCurrEduCls_SynEN != null)
{
int intRecNum = CurrEduCls_SynDA.DelRecord(strIdCurrEduCls);
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
/// <param name="strIdCurrEduCls">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strIdCurrEduCls )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCurrEduCls_SynDA.GetSpecSQLObj();
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
//删除与表:[CurrEduCls_Syn]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conCurrEduCls_Syn.IdCurrEduCls,
//strIdCurrEduCls);
//        clsCurrEduCls_SynBL.DelCurrEduCls_SynsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCurrEduCls_SynBL.DelRecord(strIdCurrEduCls, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCurrEduCls_SynBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strIdCurrEduCls">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strIdCurrEduCls, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsCurrEduCls_SynBL.relatedActions != null)
{
clsCurrEduCls_SynBL.relatedActions.UpdRelaTabDate(strIdCurrEduCls, "UpdRelaTabDate");
}
bool bolResult = CurrEduCls_SynDA.DelRecord(strIdCurrEduCls,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdCurrEduClsLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelCurrEduCls_Syns(List<string> arrIdCurrEduClsLst)
{
if (arrIdCurrEduClsLst.Count == 0) return 0;
try
{
if (clsCurrEduCls_SynBL.relatedActions != null)
{
foreach (var strIdCurrEduCls in arrIdCurrEduClsLst)
{
clsCurrEduCls_SynBL.relatedActions.UpdRelaTabDate(strIdCurrEduCls, "UpdRelaTabDate");
}
}
int intDelRecNum = CurrEduCls_SynDA.DelCurrEduCls_Syn(arrIdCurrEduClsLst);
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
public static int DelCurrEduCls_SynsByCond(string strWhereCond)
{
try
{
if (clsCurrEduCls_SynBL.relatedActions != null)
{
List<string> arrIdCurrEduCls = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdCurrEduCls in arrIdCurrEduCls)
{
clsCurrEduCls_SynBL.relatedActions.UpdRelaTabDate(strIdCurrEduCls, "UpdRelaTabDate");
}
}
int intRecNum = CurrEduCls_SynDA.DelCurrEduCls_Syn(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[CurrEduCls_Syn]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strIdCurrEduCls">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCurrEduCls_SynDA.GetSpecSQLObj();
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
//删除与表:[CurrEduCls_Syn]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCurrEduCls_SynBL.DelRecord(strIdCurrEduCls, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCurrEduCls_SynBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objCurrEduCls_SynENS">源对象</param>
 /// <param name = "objCurrEduCls_SynENT">目标对象</param>
 public static void CopyTo(clsCurrEduCls_SynEN objCurrEduCls_SynENS, clsCurrEduCls_SynEN objCurrEduCls_SynENT)
{
try
{
objCurrEduCls_SynENT.IdCurrEduCls = objCurrEduCls_SynENS.IdCurrEduCls; //教学班流水号
objCurrEduCls_SynENT.CurrEduClsId = objCurrEduCls_SynENS.CurrEduClsId; //教学班Id
objCurrEduCls_SynENT.EduClsName = objCurrEduCls_SynENS.EduClsName; //教学班名
objCurrEduCls_SynENT.EduClsTypeId = objCurrEduCls_SynENS.EduClsTypeId; //教学班类型Id
objCurrEduCls_SynENT.CourseId = objCurrEduCls_SynENS.CourseId; //课程Id
objCurrEduCls_SynENT.TeachingSolutionId = objCurrEduCls_SynENS.TeachingSolutionId; //教学方案Id
objCurrEduCls_SynENT.IdXzCollege = objCurrEduCls_SynENS.IdXzCollege; //学院流水号
objCurrEduCls_SynENT.IdMajor = objCurrEduCls_SynENS.IdMajor; //专业流水号
objCurrEduCls_SynENT.IdEduWay = objCurrEduCls_SynENS.IdEduWay; //教学方式流水号
objCurrEduCls_SynENT.IdClassRoomType = objCurrEduCls_SynENS.IdClassRoomType; //教室类型流水号
objCurrEduCls_SynENT.TotalLessonQty = objCurrEduCls_SynENS.TotalLessonQty; //总课时数
objCurrEduCls_SynENT.MaxStuQty = objCurrEduCls_SynENS.MaxStuQty; //最大学生数
objCurrEduCls_SynENT.CurrentStuQty = objCurrEduCls_SynENS.CurrentStuQty; //当前学生数
objCurrEduCls_SynENT.WeekQty = objCurrEduCls_SynENS.WeekQty; //总周数
objCurrEduCls_SynENT.ScheUnitPW = objCurrEduCls_SynENS.ScheUnitPW; //周排课次数
objCurrEduCls_SynENT.WeekStatusId = objCurrEduCls_SynENS.WeekStatusId; //周状态编号(单,双,全周)
objCurrEduCls_SynENT.CustomerWeek = objCurrEduCls_SynENS.CustomerWeek; //自定义上课周
objCurrEduCls_SynENT.IsCompleteScore = objCurrEduCls_SynENS.IsCompleteScore; //是否成绩齐全
objCurrEduCls_SynENT.IdExecPlan = objCurrEduCls_SynENS.IdExecPlan; //执行计划流水号
objCurrEduCls_SynENT.LessonQtyPerWeek = objCurrEduCls_SynENS.LessonQtyPerWeek; //周课时数
objCurrEduCls_SynENT.Mark = objCurrEduCls_SynENS.Mark; //获得学分
objCurrEduCls_SynENT.CheckClassRoom = objCurrEduCls_SynENS.CheckClassRoom; //检查教室结果
objCurrEduCls_SynENT.CheckAdminCls = objCurrEduCls_SynENS.CheckAdminCls; //检查行政班结果
objCurrEduCls_SynENT.CheckTeacher = objCurrEduCls_SynENS.CheckTeacher; //检查教师结果
objCurrEduCls_SynENT.EditLocked = objCurrEduCls_SynENS.EditLocked; //编辑锁定
objCurrEduCls_SynENT.Sched = objCurrEduCls_SynENS.Sched; //是否排课
objCurrEduCls_SynENT.IdUniZone = objCurrEduCls_SynENS.IdUniZone; //校区流水号
objCurrEduCls_SynENT.Locked = objCurrEduCls_SynENS.Locked; //锁定状态
objCurrEduCls_SynENT.IdGradeBase = objCurrEduCls_SynENS.IdGradeBase; //年级流水号
objCurrEduCls_SynENT.IsEffective = objCurrEduCls_SynENS.IsEffective; //是否有效
objCurrEduCls_SynENT.IsForPaperReading = objCurrEduCls_SynENS.IsForPaperReading; //是否参与论文阅读
objCurrEduCls_SynENT.IsUnDeterminedClsRm = objCurrEduCls_SynENS.IsUnDeterminedClsRm; //是否待定教室
objCurrEduCls_SynENT.SchoolYear = objCurrEduCls_SynENS.SchoolYear; //学年
objCurrEduCls_SynENT.SchoolTerm = objCurrEduCls_SynENS.SchoolTerm; //学期
objCurrEduCls_SynENT.ArrangeCourseMemo = objCurrEduCls_SynENS.ArrangeCourseMemo; //排课备注
objCurrEduCls_SynENT.IdCourseType = objCurrEduCls_SynENS.IdCourseType; //课程类型流水号
objCurrEduCls_SynENT.ExportDate = objCurrEduCls_SynENS.ExportDate; //导出日期
objCurrEduCls_SynENT.IsDegree = objCurrEduCls_SynENS.IsDegree; //是否学位课
objCurrEduCls_SynENT.IdScoreType = objCurrEduCls_SynENS.IdScoreType; //成绩类型流水号
objCurrEduCls_SynENT.GetScoreWayId = objCurrEduCls_SynENS.GetScoreWayId; //获得成绩方式Id
objCurrEduCls_SynENT.IsProportionalCtrl = objCurrEduCls_SynENS.IsProportionalCtrl; //是否比例控制
objCurrEduCls_SynENT.IdExamType = objCurrEduCls_SynENS.IdExamType; //考试方式流水号
objCurrEduCls_SynENT.ExamPortion = objCurrEduCls_SynENS.ExamPortion; //平时成绩所占比例
objCurrEduCls_SynENT.MidExamScorePortion = objCurrEduCls_SynENS.MidExamScorePortion; //期末成绩所占比例
objCurrEduCls_SynENT.IsClearScore = objCurrEduCls_SynENS.IsClearScore; //是否重录成绩
objCurrEduCls_SynENT.IsGeneratePwd = objCurrEduCls_SynENS.IsGeneratePwd; //是否生成口令
objCurrEduCls_SynENT.GeneratePwdDate = objCurrEduCls_SynENS.GeneratePwdDate; //生成口令时间
objCurrEduCls_SynENT.IsExportToGP = objCurrEduCls_SynENS.IsExportToGP; //是否导出到平台
objCurrEduCls_SynENT.IsExportToGPWeb = objCurrEduCls_SynENS.IsExportToGPWeb; //是否导出到Web平台
objCurrEduCls_SynENT.IsReservedDecimal = objCurrEduCls_SynENS.IsReservedDecimal; //是否保留小数
objCurrEduCls_SynENT.ExamTime = objCurrEduCls_SynENS.ExamTime; //考试时间
objCurrEduCls_SynENT.CheckState = objCurrEduCls_SynENS.CheckState; //检查状态
objCurrEduCls_SynENT.CheckDate = objCurrEduCls_SynENS.CheckDate; //检查日期
objCurrEduCls_SynENT.IdEduClassInPk = objCurrEduCls_SynENS.IdEduClassInPk; //id_EduClassInPk
objCurrEduCls_SynENT.PkWeekTime = objCurrEduCls_SynENS.PkWeekTime; //排课时间
objCurrEduCls_SynENT.PkClassRooms = objCurrEduCls_SynENS.PkClassRooms; //排课教室
objCurrEduCls_SynENT.BeginWeek = objCurrEduCls_SynENS.BeginWeek; //开始周
objCurrEduCls_SynENT.TeacherNames = objCurrEduCls_SynENS.TeacherNames; //教师姓名
objCurrEduCls_SynENT.IsSynch = objCurrEduCls_SynENS.IsSynch; //是否同步
objCurrEduCls_SynENT.SynchDate = objCurrEduCls_SynENS.SynchDate; //同步日期
objCurrEduCls_SynENT.ModifyDate = objCurrEduCls_SynENS.ModifyDate; //修改日期
objCurrEduCls_SynENT.ModifyUserId = objCurrEduCls_SynENS.ModifyUserId; //修改人
objCurrEduCls_SynENT.Memo = objCurrEduCls_SynENS.Memo; //备注
objCurrEduCls_SynENT.SignInDate = objCurrEduCls_SynENS.SignInDate; //签入时间
objCurrEduCls_SynENT.SignInStateID = objCurrEduCls_SynENS.SignInStateID; //签入状态表流水号
objCurrEduCls_SynENT.SignInUser = objCurrEduCls_SynENS.SignInUser; //签入人
objCurrEduCls_SynENT.SynchToWebUser = objCurrEduCls_SynENS.SynchToWebUser; //同步Web用户
objCurrEduCls_SynENT.IsSynchToWeb = objCurrEduCls_SynENS.IsSynchToWeb; //是否同步Web
objCurrEduCls_SynENT.SynchToWebDate = objCurrEduCls_SynENS.SynchToWebDate; //同步Web日期
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
 /// <param name = "objCurrEduCls_SynEN">源简化对象</param>
 public static void SetUpdFlag(clsCurrEduCls_SynEN objCurrEduCls_SynEN)
{
try
{
objCurrEduCls_SynEN.ClearUpdateState();
   string strsfUpdFldSetStr = objCurrEduCls_SynEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conCurrEduCls_Syn.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.IdCurrEduCls = objCurrEduCls_SynEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conCurrEduCls_Syn.CurrEduClsId, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.CurrEduClsId = objCurrEduCls_SynEN.CurrEduClsId; //教学班Id
}
if (arrFldSet.Contains(conCurrEduCls_Syn.EduClsName, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.EduClsName = objCurrEduCls_SynEN.EduClsName == "[null]" ? null :  objCurrEduCls_SynEN.EduClsName; //教学班名
}
if (arrFldSet.Contains(conCurrEduCls_Syn.EduClsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.EduClsTypeId = objCurrEduCls_SynEN.EduClsTypeId == "[null]" ? null :  objCurrEduCls_SynEN.EduClsTypeId; //教学班类型Id
}
if (arrFldSet.Contains(conCurrEduCls_Syn.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.CourseId = objCurrEduCls_SynEN.CourseId == "[null]" ? null :  objCurrEduCls_SynEN.CourseId; //课程Id
}
if (arrFldSet.Contains(conCurrEduCls_Syn.TeachingSolutionId, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.TeachingSolutionId = objCurrEduCls_SynEN.TeachingSolutionId == "[null]" ? null :  objCurrEduCls_SynEN.TeachingSolutionId; //教学方案Id
}
if (arrFldSet.Contains(conCurrEduCls_Syn.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.IdXzCollege = objCurrEduCls_SynEN.IdXzCollege == "[null]" ? null :  objCurrEduCls_SynEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(conCurrEduCls_Syn.IdMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.IdMajor = objCurrEduCls_SynEN.IdMajor; //专业流水号
}
if (arrFldSet.Contains(conCurrEduCls_Syn.IdEduWay, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.IdEduWay = objCurrEduCls_SynEN.IdEduWay == "[null]" ? null :  objCurrEduCls_SynEN.IdEduWay; //教学方式流水号
}
if (arrFldSet.Contains(conCurrEduCls_Syn.IdClassRoomType, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.IdClassRoomType = objCurrEduCls_SynEN.IdClassRoomType == "[null]" ? null :  objCurrEduCls_SynEN.IdClassRoomType; //教室类型流水号
}
if (arrFldSet.Contains(conCurrEduCls_Syn.TotalLessonQty, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.TotalLessonQty = objCurrEduCls_SynEN.TotalLessonQty; //总课时数
}
if (arrFldSet.Contains(conCurrEduCls_Syn.MaxStuQty, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.MaxStuQty = objCurrEduCls_SynEN.MaxStuQty; //最大学生数
}
if (arrFldSet.Contains(conCurrEduCls_Syn.CurrentStuQty, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.CurrentStuQty = objCurrEduCls_SynEN.CurrentStuQty; //当前学生数
}
if (arrFldSet.Contains(conCurrEduCls_Syn.WeekQty, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.WeekQty = objCurrEduCls_SynEN.WeekQty; //总周数
}
if (arrFldSet.Contains(conCurrEduCls_Syn.ScheUnitPW, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.ScheUnitPW = objCurrEduCls_SynEN.ScheUnitPW; //周排课次数
}
if (arrFldSet.Contains(conCurrEduCls_Syn.WeekStatusId, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.WeekStatusId = objCurrEduCls_SynEN.WeekStatusId == "[null]" ? null :  objCurrEduCls_SynEN.WeekStatusId; //周状态编号(单,双,全周)
}
if (arrFldSet.Contains(conCurrEduCls_Syn.CustomerWeek, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.CustomerWeek = objCurrEduCls_SynEN.CustomerWeek == "[null]" ? null :  objCurrEduCls_SynEN.CustomerWeek; //自定义上课周
}
if (arrFldSet.Contains(conCurrEduCls_Syn.IsCompleteScore, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.IsCompleteScore = objCurrEduCls_SynEN.IsCompleteScore; //是否成绩齐全
}
if (arrFldSet.Contains(conCurrEduCls_Syn.IdExecPlan, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.IdExecPlan = objCurrEduCls_SynEN.IdExecPlan == "[null]" ? null :  objCurrEduCls_SynEN.IdExecPlan; //执行计划流水号
}
if (arrFldSet.Contains(conCurrEduCls_Syn.LessonQtyPerWeek, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.LessonQtyPerWeek = objCurrEduCls_SynEN.LessonQtyPerWeek; //周课时数
}
if (arrFldSet.Contains(conCurrEduCls_Syn.Mark, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.Mark = objCurrEduCls_SynEN.Mark; //获得学分
}
if (arrFldSet.Contains(conCurrEduCls_Syn.CheckClassRoom, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.CheckClassRoom = objCurrEduCls_SynEN.CheckClassRoom == "[null]" ? null :  objCurrEduCls_SynEN.CheckClassRoom; //检查教室结果
}
if (arrFldSet.Contains(conCurrEduCls_Syn.CheckAdminCls, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.CheckAdminCls = objCurrEduCls_SynEN.CheckAdminCls == "[null]" ? null :  objCurrEduCls_SynEN.CheckAdminCls; //检查行政班结果
}
if (arrFldSet.Contains(conCurrEduCls_Syn.CheckTeacher, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.CheckTeacher = objCurrEduCls_SynEN.CheckTeacher == "[null]" ? null :  objCurrEduCls_SynEN.CheckTeacher; //检查教师结果
}
if (arrFldSet.Contains(conCurrEduCls_Syn.EditLocked, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.EditLocked = objCurrEduCls_SynEN.EditLocked; //编辑锁定
}
if (arrFldSet.Contains(conCurrEduCls_Syn.Sched, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.Sched = objCurrEduCls_SynEN.Sched; //是否排课
}
if (arrFldSet.Contains(conCurrEduCls_Syn.IdUniZone, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.IdUniZone = objCurrEduCls_SynEN.IdUniZone == "[null]" ? null :  objCurrEduCls_SynEN.IdUniZone; //校区流水号
}
if (arrFldSet.Contains(conCurrEduCls_Syn.Locked, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.Locked = objCurrEduCls_SynEN.Locked; //锁定状态
}
if (arrFldSet.Contains(conCurrEduCls_Syn.IdGradeBase, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.IdGradeBase = objCurrEduCls_SynEN.IdGradeBase == "[null]" ? null :  objCurrEduCls_SynEN.IdGradeBase; //年级流水号
}
if (arrFldSet.Contains(conCurrEduCls_Syn.IsEffective, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.IsEffective = objCurrEduCls_SynEN.IsEffective; //是否有效
}
if (arrFldSet.Contains(conCurrEduCls_Syn.IsForPaperReading, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.IsForPaperReading = objCurrEduCls_SynEN.IsForPaperReading; //是否参与论文阅读
}
if (arrFldSet.Contains(conCurrEduCls_Syn.IsUnDeterminedClsRm, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.IsUnDeterminedClsRm = objCurrEduCls_SynEN.IsUnDeterminedClsRm; //是否待定教室
}
if (arrFldSet.Contains(conCurrEduCls_Syn.SchoolYear, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.SchoolYear = objCurrEduCls_SynEN.SchoolYear == "[null]" ? null :  objCurrEduCls_SynEN.SchoolYear; //学年
}
if (arrFldSet.Contains(conCurrEduCls_Syn.SchoolTerm, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.SchoolTerm = objCurrEduCls_SynEN.SchoolTerm == "[null]" ? null :  objCurrEduCls_SynEN.SchoolTerm; //学期
}
if (arrFldSet.Contains(conCurrEduCls_Syn.ArrangeCourseMemo, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.ArrangeCourseMemo = objCurrEduCls_SynEN.ArrangeCourseMemo == "[null]" ? null :  objCurrEduCls_SynEN.ArrangeCourseMemo; //排课备注
}
if (arrFldSet.Contains(conCurrEduCls_Syn.IdCourseType, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.IdCourseType = objCurrEduCls_SynEN.IdCourseType == "[null]" ? null :  objCurrEduCls_SynEN.IdCourseType; //课程类型流水号
}
if (arrFldSet.Contains(conCurrEduCls_Syn.ExportDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.ExportDate = objCurrEduCls_SynEN.ExportDate == "[null]" ? null :  objCurrEduCls_SynEN.ExportDate; //导出日期
}
if (arrFldSet.Contains(conCurrEduCls_Syn.IsDegree, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.IsDegree = objCurrEduCls_SynEN.IsDegree; //是否学位课
}
if (arrFldSet.Contains(conCurrEduCls_Syn.IdScoreType, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.IdScoreType = objCurrEduCls_SynEN.IdScoreType == "[null]" ? null :  objCurrEduCls_SynEN.IdScoreType; //成绩类型流水号
}
if (arrFldSet.Contains(conCurrEduCls_Syn.GetScoreWayId, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.GetScoreWayId = objCurrEduCls_SynEN.GetScoreWayId == "[null]" ? null :  objCurrEduCls_SynEN.GetScoreWayId; //获得成绩方式Id
}
if (arrFldSet.Contains(conCurrEduCls_Syn.IsProportionalCtrl, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.IsProportionalCtrl = objCurrEduCls_SynEN.IsProportionalCtrl; //是否比例控制
}
if (arrFldSet.Contains(conCurrEduCls_Syn.IdExamType, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.IdExamType = objCurrEduCls_SynEN.IdExamType == "[null]" ? null :  objCurrEduCls_SynEN.IdExamType; //考试方式流水号
}
if (arrFldSet.Contains(conCurrEduCls_Syn.ExamPortion, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.ExamPortion = objCurrEduCls_SynEN.ExamPortion; //平时成绩所占比例
}
if (arrFldSet.Contains(conCurrEduCls_Syn.MidExamScorePortion, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.MidExamScorePortion = objCurrEduCls_SynEN.MidExamScorePortion; //期末成绩所占比例
}
if (arrFldSet.Contains(conCurrEduCls_Syn.IsClearScore, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.IsClearScore = objCurrEduCls_SynEN.IsClearScore; //是否重录成绩
}
if (arrFldSet.Contains(conCurrEduCls_Syn.IsGeneratePwd, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.IsGeneratePwd = objCurrEduCls_SynEN.IsGeneratePwd; //是否生成口令
}
if (arrFldSet.Contains(conCurrEduCls_Syn.GeneratePwdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.GeneratePwdDate = objCurrEduCls_SynEN.GeneratePwdDate == "[null]" ? null :  objCurrEduCls_SynEN.GeneratePwdDate; //生成口令时间
}
if (arrFldSet.Contains(conCurrEduCls_Syn.IsExportToGP, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.IsExportToGP = objCurrEduCls_SynEN.IsExportToGP; //是否导出到平台
}
if (arrFldSet.Contains(conCurrEduCls_Syn.IsExportToGPWeb, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.IsExportToGPWeb = objCurrEduCls_SynEN.IsExportToGPWeb; //是否导出到Web平台
}
if (arrFldSet.Contains(conCurrEduCls_Syn.IsReservedDecimal, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.IsReservedDecimal = objCurrEduCls_SynEN.IsReservedDecimal; //是否保留小数
}
if (arrFldSet.Contains(conCurrEduCls_Syn.ExamTime, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.ExamTime = objCurrEduCls_SynEN.ExamTime == "[null]" ? null :  objCurrEduCls_SynEN.ExamTime; //考试时间
}
if (arrFldSet.Contains(conCurrEduCls_Syn.CheckState, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.CheckState = objCurrEduCls_SynEN.CheckState; //检查状态
}
if (arrFldSet.Contains(conCurrEduCls_Syn.CheckDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.CheckDate = objCurrEduCls_SynEN.CheckDate == "[null]" ? null :  objCurrEduCls_SynEN.CheckDate; //检查日期
}
if (arrFldSet.Contains(conCurrEduCls_Syn.IdEduClassInPk, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.IdEduClassInPk = objCurrEduCls_SynEN.IdEduClassInPk == "[null]" ? null :  objCurrEduCls_SynEN.IdEduClassInPk; //id_EduClassInPk
}
if (arrFldSet.Contains(conCurrEduCls_Syn.PkWeekTime, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.PkWeekTime = objCurrEduCls_SynEN.PkWeekTime == "[null]" ? null :  objCurrEduCls_SynEN.PkWeekTime; //排课时间
}
if (arrFldSet.Contains(conCurrEduCls_Syn.PkClassRooms, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.PkClassRooms = objCurrEduCls_SynEN.PkClassRooms == "[null]" ? null :  objCurrEduCls_SynEN.PkClassRooms; //排课教室
}
if (arrFldSet.Contains(conCurrEduCls_Syn.BeginWeek, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.BeginWeek = objCurrEduCls_SynEN.BeginWeek; //开始周
}
if (arrFldSet.Contains(conCurrEduCls_Syn.TeacherNames, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.TeacherNames = objCurrEduCls_SynEN.TeacherNames == "[null]" ? null :  objCurrEduCls_SynEN.TeacherNames; //教师姓名
}
if (arrFldSet.Contains(conCurrEduCls_Syn.IsSynch, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.IsSynch = objCurrEduCls_SynEN.IsSynch; //是否同步
}
if (arrFldSet.Contains(conCurrEduCls_Syn.SynchDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.SynchDate = objCurrEduCls_SynEN.SynchDate == "[null]" ? null :  objCurrEduCls_SynEN.SynchDate; //同步日期
}
if (arrFldSet.Contains(conCurrEduCls_Syn.ModifyDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.ModifyDate = objCurrEduCls_SynEN.ModifyDate == "[null]" ? null :  objCurrEduCls_SynEN.ModifyDate; //修改日期
}
if (arrFldSet.Contains(conCurrEduCls_Syn.ModifyUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.ModifyUserId = objCurrEduCls_SynEN.ModifyUserId == "[null]" ? null :  objCurrEduCls_SynEN.ModifyUserId; //修改人
}
if (arrFldSet.Contains(conCurrEduCls_Syn.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.Memo = objCurrEduCls_SynEN.Memo == "[null]" ? null :  objCurrEduCls_SynEN.Memo; //备注
}
if (arrFldSet.Contains(conCurrEduCls_Syn.SignInDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.SignInDate = objCurrEduCls_SynEN.SignInDate == "[null]" ? null :  objCurrEduCls_SynEN.SignInDate; //签入时间
}
if (arrFldSet.Contains(conCurrEduCls_Syn.SignInStateID, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.SignInStateID = objCurrEduCls_SynEN.SignInStateID == "[null]" ? null :  objCurrEduCls_SynEN.SignInStateID; //签入状态表流水号
}
if (arrFldSet.Contains(conCurrEduCls_Syn.SignInUser, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.SignInUser = objCurrEduCls_SynEN.SignInUser == "[null]" ? null :  objCurrEduCls_SynEN.SignInUser; //签入人
}
if (arrFldSet.Contains(conCurrEduCls_Syn.SynchToWebUser, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.SynchToWebUser = objCurrEduCls_SynEN.SynchToWebUser == "[null]" ? null :  objCurrEduCls_SynEN.SynchToWebUser; //同步Web用户
}
if (arrFldSet.Contains(conCurrEduCls_Syn.IsSynchToWeb, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.IsSynchToWeb = objCurrEduCls_SynEN.IsSynchToWeb; //是否同步Web
}
if (arrFldSet.Contains(conCurrEduCls_Syn.SynchToWebDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls_SynEN.SynchToWebDate = objCurrEduCls_SynEN.SynchToWebDate == "[null]" ? null :  objCurrEduCls_SynEN.SynchToWebDate; //同步Web日期
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
 /// <param name = "objCurrEduCls_SynEN">源简化对象</param>
 public static void AccessFldValueNull(clsCurrEduCls_SynEN objCurrEduCls_SynEN)
{
try
{
if (objCurrEduCls_SynEN.EduClsName == "[null]") objCurrEduCls_SynEN.EduClsName = null; //教学班名
if (objCurrEduCls_SynEN.EduClsTypeId == "[null]") objCurrEduCls_SynEN.EduClsTypeId = null; //教学班类型Id
if (objCurrEduCls_SynEN.CourseId == "[null]") objCurrEduCls_SynEN.CourseId = null; //课程Id
if (objCurrEduCls_SynEN.TeachingSolutionId == "[null]") objCurrEduCls_SynEN.TeachingSolutionId = null; //教学方案Id
if (objCurrEduCls_SynEN.IdXzCollege == "[null]") objCurrEduCls_SynEN.IdXzCollege = null; //学院流水号
if (objCurrEduCls_SynEN.IdEduWay == "[null]") objCurrEduCls_SynEN.IdEduWay = null; //教学方式流水号
if (objCurrEduCls_SynEN.IdClassRoomType == "[null]") objCurrEduCls_SynEN.IdClassRoomType = null; //教室类型流水号
if (objCurrEduCls_SynEN.WeekStatusId == "[null]") objCurrEduCls_SynEN.WeekStatusId = null; //周状态编号(单,双,全周)
if (objCurrEduCls_SynEN.CustomerWeek == "[null]") objCurrEduCls_SynEN.CustomerWeek = null; //自定义上课周
if (objCurrEduCls_SynEN.IdExecPlan == "[null]") objCurrEduCls_SynEN.IdExecPlan = null; //执行计划流水号
if (objCurrEduCls_SynEN.CheckClassRoom == "[null]") objCurrEduCls_SynEN.CheckClassRoom = null; //检查教室结果
if (objCurrEduCls_SynEN.CheckAdminCls == "[null]") objCurrEduCls_SynEN.CheckAdminCls = null; //检查行政班结果
if (objCurrEduCls_SynEN.CheckTeacher == "[null]") objCurrEduCls_SynEN.CheckTeacher = null; //检查教师结果
if (objCurrEduCls_SynEN.IdUniZone == "[null]") objCurrEduCls_SynEN.IdUniZone = null; //校区流水号
if (objCurrEduCls_SynEN.IdGradeBase == "[null]") objCurrEduCls_SynEN.IdGradeBase = null; //年级流水号
if (objCurrEduCls_SynEN.SchoolYear == "[null]") objCurrEduCls_SynEN.SchoolYear = null; //学年
if (objCurrEduCls_SynEN.SchoolTerm == "[null]") objCurrEduCls_SynEN.SchoolTerm = null; //学期
if (objCurrEduCls_SynEN.ArrangeCourseMemo == "[null]") objCurrEduCls_SynEN.ArrangeCourseMemo = null; //排课备注
if (objCurrEduCls_SynEN.IdCourseType == "[null]") objCurrEduCls_SynEN.IdCourseType = null; //课程类型流水号
if (objCurrEduCls_SynEN.ExportDate == "[null]") objCurrEduCls_SynEN.ExportDate = null; //导出日期
if (objCurrEduCls_SynEN.IdScoreType == "[null]") objCurrEduCls_SynEN.IdScoreType = null; //成绩类型流水号
if (objCurrEduCls_SynEN.GetScoreWayId == "[null]") objCurrEduCls_SynEN.GetScoreWayId = null; //获得成绩方式Id
if (objCurrEduCls_SynEN.IdExamType == "[null]") objCurrEduCls_SynEN.IdExamType = null; //考试方式流水号
if (objCurrEduCls_SynEN.GeneratePwdDate == "[null]") objCurrEduCls_SynEN.GeneratePwdDate = null; //生成口令时间
if (objCurrEduCls_SynEN.ExamTime == "[null]") objCurrEduCls_SynEN.ExamTime = null; //考试时间
if (objCurrEduCls_SynEN.CheckDate == "[null]") objCurrEduCls_SynEN.CheckDate = null; //检查日期
if (objCurrEduCls_SynEN.IdEduClassInPk == "[null]") objCurrEduCls_SynEN.IdEduClassInPk = null; //id_EduClassInPk
if (objCurrEduCls_SynEN.PkWeekTime == "[null]") objCurrEduCls_SynEN.PkWeekTime = null; //排课时间
if (objCurrEduCls_SynEN.PkClassRooms == "[null]") objCurrEduCls_SynEN.PkClassRooms = null; //排课教室
if (objCurrEduCls_SynEN.TeacherNames == "[null]") objCurrEduCls_SynEN.TeacherNames = null; //教师姓名
if (objCurrEduCls_SynEN.SynchDate == "[null]") objCurrEduCls_SynEN.SynchDate = null; //同步日期
if (objCurrEduCls_SynEN.ModifyDate == "[null]") objCurrEduCls_SynEN.ModifyDate = null; //修改日期
if (objCurrEduCls_SynEN.ModifyUserId == "[null]") objCurrEduCls_SynEN.ModifyUserId = null; //修改人
if (objCurrEduCls_SynEN.Memo == "[null]") objCurrEduCls_SynEN.Memo = null; //备注
if (objCurrEduCls_SynEN.SignInDate == "[null]") objCurrEduCls_SynEN.SignInDate = null; //签入时间
if (objCurrEduCls_SynEN.SignInStateID == "[null]") objCurrEduCls_SynEN.SignInStateID = null; //签入状态表流水号
if (objCurrEduCls_SynEN.SignInUser == "[null]") objCurrEduCls_SynEN.SignInUser = null; //签入人
if (objCurrEduCls_SynEN.SynchToWebUser == "[null]") objCurrEduCls_SynEN.SynchToWebUser = null; //同步Web用户
if (objCurrEduCls_SynEN.SynchToWebDate == "[null]") objCurrEduCls_SynEN.SynchToWebDate = null; //同步Web日期
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
public static void CheckPropertyNew(clsCurrEduCls_SynEN objCurrEduCls_SynEN)
{
 CurrEduCls_SynDA.CheckPropertyNew(objCurrEduCls_SynEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsCurrEduCls_SynEN objCurrEduCls_SynEN)
{
 CurrEduCls_SynDA.CheckProperty4Condition(objCurrEduCls_SynEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_IdCurrEduCls(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conCurrEduCls_Syn.IdCurrEduCls); 
List<clsCurrEduCls_SynEN> arrObjLst = clsCurrEduCls_SynBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsCurrEduCls_SynEN objCurrEduCls_SynEN = new clsCurrEduCls_SynEN()
{
IdCurrEduCls = "0",
EduClsName = "选[当前教学班_动态]..."
};
arrObjLst.Insert(0, objCurrEduCls_SynEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conCurrEduCls_Syn.IdCurrEduCls;
objComboBox.DisplayMember = conCurrEduCls_Syn.EduClsName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_IdCurrEduCls(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[当前教学班_动态]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conCurrEduCls_Syn.IdCurrEduCls); 
IEnumerable<clsCurrEduCls_SynEN> arrObjLst = clsCurrEduCls_SynBL.GetObjLst(strCondition);
objDDL.DataValueField = conCurrEduCls_Syn.IdCurrEduCls;
objDDL.DataTextField = conCurrEduCls_Syn.EduClsName;
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_IdCurrEduClsCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[当前教学班_动态]...","0");
List<clsCurrEduCls_SynEN> arrCurrEduCls_SynObjLst = GetAllCurrEduCls_SynObjLstCache(); 
objDDL.DataValueField = conCurrEduCls_Syn.IdCurrEduCls;
objDDL.DataTextField = conCurrEduCls_Syn.EduClsName;
objDDL.DataSource = arrCurrEduCls_SynObjLst;
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
if (clsCurrEduCls_SynBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCurrEduCls_SynBL没有刷新缓存机制(clsCurrEduCls_SynBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdCurrEduCls");
//if (arrCurrEduCls_SynObjLstCache == null)
//{
//arrCurrEduCls_SynObjLstCache = CurrEduCls_SynDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdCurrEduCls">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCurrEduCls_SynEN GetObjByIdCurrEduClsCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsCurrEduCls_SynEN._CurrTabName);
List<clsCurrEduCls_SynEN> arrCurrEduCls_SynObjLstCache = GetObjLstCache();
IEnumerable <clsCurrEduCls_SynEN> arrCurrEduCls_SynObjLst_Sel =
arrCurrEduCls_SynObjLstCache
.Where(x=> x.IdCurrEduCls == strIdCurrEduCls 
);
if (arrCurrEduCls_SynObjLst_Sel.Count() == 0)
{
   clsCurrEduCls_SynEN obj = clsCurrEduCls_SynBL.GetObjByIdCurrEduCls(strIdCurrEduCls);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrCurrEduCls_SynObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdCurrEduCls">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetEduClsNameByIdCurrEduClsCache(string strIdCurrEduCls)
{
if (string.IsNullOrEmpty(strIdCurrEduCls) == true) return "";
//获取缓存中的对象列表
clsCurrEduCls_SynEN objCurrEduCls_Syn = GetObjByIdCurrEduClsCache(strIdCurrEduCls);
if (objCurrEduCls_Syn == null) return "";
return objCurrEduCls_Syn.EduClsName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdCurrEduCls">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByIdCurrEduClsCache(string strIdCurrEduCls)
{
if (string.IsNullOrEmpty(strIdCurrEduCls) == true) return "";
//获取缓存中的对象列表
clsCurrEduCls_SynEN objCurrEduCls_Syn = GetObjByIdCurrEduClsCache(strIdCurrEduCls);
if (objCurrEduCls_Syn == null) return "";
return objCurrEduCls_Syn.EduClsName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCurrEduCls_SynEN> GetAllCurrEduCls_SynObjLstCache()
{
//获取缓存中的对象列表
List<clsCurrEduCls_SynEN> arrCurrEduCls_SynObjLstCache = GetObjLstCache(); 
return arrCurrEduCls_SynObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCurrEduCls_SynEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsCurrEduCls_SynEN._CurrTabName);
List<clsCurrEduCls_SynEN> arrCurrEduCls_SynObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrCurrEduCls_SynObjLstCache;
}

 /// <summary>
 /// 根据分类字段获取缓存中对象列表的子集,根据:CourseId字段
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubSet4ObjLst)
 /// </summary>
 /// <param name = "parrCurrEduCls_SynObjLst">需要排序的对象列表</param>
public static List <clsCurrEduCls_SynEN> GetSubSet4CurrEduCls_SynObjLstByCourseIdCache(string strCourseId)
{
   if (string.IsNullOrEmpty(strCourseId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsCurrEduCls_SynEN._CurrTabName);
List<clsCurrEduCls_SynEN> arrCurrEduCls_SynObjLstCache = GetObjLstCache();
IEnumerable <clsCurrEduCls_SynEN> arrCurrEduCls_SynObjLst_Sel1 =
from objCurrEduCls_SynEN in arrCurrEduCls_SynObjLstCache
where objCurrEduCls_SynEN.CourseId == strCourseId
select objCurrEduCls_SynEN;
List <clsCurrEduCls_SynEN> arrCurrEduCls_SynObjLst_Sel = new List<clsCurrEduCls_SynEN>();
foreach (clsCurrEduCls_SynEN obj in arrCurrEduCls_SynObjLst_Sel1)
{
arrCurrEduCls_SynObjLst_Sel.Add(obj);
}
return arrCurrEduCls_SynObjLst_Sel;
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
string strKey = string.Format("{0}", clsCurrEduCls_SynEN._CurrTabName);
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
public static void ReFreshCache()
{
if (clsCurrEduCls_SynBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCurrEduCls_SynEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCurrEduCls_SynBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2024-02-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strIdCurrEduCls)
{
if (strInFldName != conCurrEduCls_Syn.IdCurrEduCls)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conCurrEduCls_Syn.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conCurrEduCls_Syn.AttributeName));
throw new Exception(strMsg);
}
var objCurrEduCls_Syn = clsCurrEduCls_SynBL.GetObjByIdCurrEduClsCache(strIdCurrEduCls);
if (objCurrEduCls_Syn == null) return "";
return objCurrEduCls_Syn[strOutFldName].ToString();
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
int intRecCount = clsCurrEduCls_SynDA.GetRecCount(strTabName);
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
int intRecCount = clsCurrEduCls_SynDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsCurrEduCls_SynDA.GetRecCount();
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
int intRecCount = clsCurrEduCls_SynDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objCurrEduCls_SynCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsCurrEduCls_SynEN objCurrEduCls_SynCond)
{
List<clsCurrEduCls_SynEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsCurrEduCls_SynEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCurrEduCls_Syn.AttributeName)
{
if (objCurrEduCls_SynCond.IsUpdated(strFldName) == false) continue;
if (objCurrEduCls_SynCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCurrEduCls_SynCond[strFldName].ToString());
}
else
{
if (objCurrEduCls_SynCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCurrEduCls_SynCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCurrEduCls_SynCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCurrEduCls_SynCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCurrEduCls_SynCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCurrEduCls_SynCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCurrEduCls_SynCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCurrEduCls_SynCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCurrEduCls_SynCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCurrEduCls_SynCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCurrEduCls_SynCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCurrEduCls_SynCond[strFldName]));
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
 List<string> arrList = clsCurrEduCls_SynDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = CurrEduCls_SynDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = CurrEduCls_SynDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = CurrEduCls_SynDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsCurrEduCls_SynDA.SetFldValue(clsCurrEduCls_SynEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = CurrEduCls_SynDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsCurrEduCls_SynDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsCurrEduCls_SynDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsCurrEduCls_SynDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[CurrEduCls_Syn] "); 
 strCreateTabCode.Append(" ( "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) primary key, "); 
 // /**教学班Id*/ 
 strCreateTabCode.Append(" CurrEduClsId varchar(15) not Null, "); 
 // /**教学班名*/ 
 strCreateTabCode.Append(" EduClsName varchar(100) Null, "); 
 // /**教学班类型Id*/ 
 strCreateTabCode.Append(" EduClsTypeId char(4) Null, "); 
 // /**课程Id*/ 
 strCreateTabCode.Append(" CourseId char(8) Null, "); 
 // /**教学方案Id*/ 
 strCreateTabCode.Append(" TeachingSolutionId char(8) Null, "); 
 // /**学院流水号*/ 
 strCreateTabCode.Append(" IdXzCollege char(4) Null, "); 
 // /**专业流水号*/ 
 strCreateTabCode.Append(" IdMajor char(8) not Null, "); 
 // /**教学方式流水号*/ 
 strCreateTabCode.Append(" IdEduWay char(4) Null, "); 
 // /**教室类型流水号*/ 
 strCreateTabCode.Append(" IdClassRoomType char(4) Null, "); 
 // /**总课时数*/ 
 strCreateTabCode.Append(" TotalLessonQty int Null, "); 
 // /**最大学生数*/ 
 strCreateTabCode.Append(" MaxStuQty int Null, "); 
 // /**当前学生数*/ 
 strCreateTabCode.Append(" CurrentStuQty int Null, "); 
 // /**总周数*/ 
 strCreateTabCode.Append(" WeekQty int Null, "); 
 // /**周排课次数*/ 
 strCreateTabCode.Append(" ScheUnitPW smallint Null, "); 
 // /**周状态编号(单,双,全周)*/ 
 strCreateTabCode.Append(" WeekStatusId char(2) Null, "); 
 // /**自定义上课周*/ 
 strCreateTabCode.Append(" CustomerWeek varchar(50) Null, "); 
 // /**是否成绩齐全*/ 
 strCreateTabCode.Append(" IsCompleteScore bit Null, "); 
 // /**执行计划流水号*/ 
 strCreateTabCode.Append(" IdExecPlan char(8) Null, "); 
 // /**周课时数*/ 
 strCreateTabCode.Append(" LessonQtyPerWeek smallint Null, "); 
 // /**获得学分*/ 
 strCreateTabCode.Append(" Mark decimal(7,2) Null, "); 
 // /**检查教室结果*/ 
 strCreateTabCode.Append(" CheckClassRoom varchar(2000) Null, "); 
 // /**检查行政班结果*/ 
 strCreateTabCode.Append(" CheckAdminCls varchar(2000) Null, "); 
 // /**检查教师结果*/ 
 strCreateTabCode.Append(" CheckTeacher varchar(2000) Null, "); 
 // /**编辑锁定*/ 
 strCreateTabCode.Append(" EditLocked bit Null, "); 
 // /**是否排课*/ 
 strCreateTabCode.Append(" Sched bit Null, "); 
 // /**校区流水号*/ 
 strCreateTabCode.Append(" IdUniZone char(4) Null, "); 
 // /**锁定状态*/ 
 strCreateTabCode.Append(" Locked bit Null, "); 
 // /**年级流水号*/ 
 strCreateTabCode.Append(" IdGradeBase char(4) Null, "); 
 // /**是否有效*/ 
 strCreateTabCode.Append(" IsEffective bit Null, "); 
 // /**是否参与论文阅读*/ 
 strCreateTabCode.Append(" IsForPaperReading bit Null, "); 
 // /**是否待定教室*/ 
 strCreateTabCode.Append(" IsUnDeterminedClsRm bit Null, "); 
 // /**学年*/ 
 strCreateTabCode.Append(" SchoolYear varchar(10) Null, "); 
 // /**学期*/ 
 strCreateTabCode.Append(" SchoolTerm char(1) Null, "); 
 // /**排课备注*/ 
 strCreateTabCode.Append(" ArrangeCourseMemo varchar(50) Null, "); 
 // /**课程类型流水号*/ 
 strCreateTabCode.Append(" IdCourseType char(4) Null, "); 
 // /**导出日期*/ 
 strCreateTabCode.Append(" ExportDate varchar(8) Null, "); 
 // /**是否学位课*/ 
 strCreateTabCode.Append(" IsDegree bit Null, "); 
 // /**成绩类型流水号*/ 
 strCreateTabCode.Append(" IdScoreType char(4) Null, "); 
 // /**获得成绩方式Id*/ 
 strCreateTabCode.Append(" GetScoreWayId char(2) Null, "); 
 // /**是否比例控制*/ 
 strCreateTabCode.Append(" IsProportionalCtrl bit Null, "); 
 // /**考试方式流水号*/ 
 strCreateTabCode.Append(" IdExamType char(4) Null, "); 
 // /**平时成绩所占比例*/ 
 strCreateTabCode.Append(" ExamPortion smallint Null, "); 
 // /**期末成绩所占比例*/ 
 strCreateTabCode.Append(" MidExamScorePortion smallint Null, "); 
 // /**是否重录成绩*/ 
 strCreateTabCode.Append(" IsClearScore bit Null, "); 
 // /**是否生成口令*/ 
 strCreateTabCode.Append(" IsGeneratePwd bit Null, "); 
 // /**生成口令时间*/ 
 strCreateTabCode.Append(" GeneratePwdDate varchar(20) Null, "); 
 // /**是否导出到平台*/ 
 strCreateTabCode.Append(" IsExportToGP bit Null, "); 
 // /**是否导出到Web平台*/ 
 strCreateTabCode.Append(" IsExportToGPWeb bit Null, "); 
 // /**是否保留小数*/ 
 strCreateTabCode.Append(" IsReservedDecimal bit Null, "); 
 // /**考试时间*/ 
 strCreateTabCode.Append(" ExamTime varchar(8) Null, "); 
 // /**检查状态*/ 
 strCreateTabCode.Append(" CheckState bit Null, "); 
 // /**检查日期*/ 
 strCreateTabCode.Append(" CheckDate varchar(20) Null, "); 
 // /**id_EduClassInPk*/ 
 strCreateTabCode.Append(" IdEduClassInPk char(8) Null, "); 
 // /**排课时间*/ 
 strCreateTabCode.Append(" PkWeekTime varchar(2000) Null, "); 
 // /**排课教室*/ 
 strCreateTabCode.Append(" PkClassRooms varchar(150) Null, "); 
 // /**开始周*/ 
 strCreateTabCode.Append(" BeginWeek smallint Null, "); 
 // /**教师姓名*/ 
 strCreateTabCode.Append(" TeacherNames varchar(100) Null, "); 
 // /**是否同步*/ 
 strCreateTabCode.Append(" IsSynch bit not Null, "); 
 // /**同步日期*/ 
 strCreateTabCode.Append(" SynchDate varchar(30) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" ModifyDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" ModifyUserId varchar(18) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**签入时间*/ 
 strCreateTabCode.Append(" SignInDate varchar(20) Null, "); 
 // /**签入状态表流水号*/ 
 strCreateTabCode.Append(" SignInStateID char(2) Null, "); 
 // /**签入人*/ 
 strCreateTabCode.Append(" SignInUser varchar(18) Null, "); 
 // /**同步Web用户*/ 
 strCreateTabCode.Append(" SynchToWebUser varchar(18) Null, "); 
 // /**是否同步Web*/ 
 strCreateTabCode.Append(" IsSynchToWeb bit Null, "); 
 // /**同步Web日期*/ 
 strCreateTabCode.Append(" SynchToWebDate varchar(20) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 当前教学班_动态(CurrEduCls_Syn)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4CurrEduCls_Syn : clsCommFun4BL
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
clsCurrEduCls_SynBL.ReFreshThisCache();
}
}

}