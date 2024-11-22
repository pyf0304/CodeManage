
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCurrEduClsTeacherBL
 表名:CurrEduClsTeacher(01120124)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 05:59:34
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:日常运行(DailyRunning)
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
public static class  clsCurrEduClsTeacherBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdEduClsTeacher">表关键字</param>
 /// <returns>表对象</returns>
public static clsCurrEduClsTeacherEN GetObj(this K_IdEduClsTeacher_CurrEduClsTeacher myKey)
{
clsCurrEduClsTeacherEN objCurrEduClsTeacherEN = clsCurrEduClsTeacherBL.CurrEduClsTeacherDA.GetObjByIdEduClsTeacher(myKey.Value);
return objCurrEduClsTeacherEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCurrEduClsTeacherEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCurrEduClsTeacherEN objCurrEduClsTeacherEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCurrEduClsTeacherEN) == false)
{
var strMsg = string.Format("记录已经存在!教学班流水号 = [{0}],教师流水号 = [{1}]的数据已经存在!(in clsCurrEduClsTeacherBL.AddNewRecord)", objCurrEduClsTeacherEN.IdCurrEduCls,objCurrEduClsTeacherEN.IdTeacher);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsCurrEduClsTeacherBL.CurrEduClsTeacherDA.AddNewRecordBySQL2(objCurrEduClsTeacherEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsTeacherBL.ReFreshCache(objCurrEduClsTeacherEN.IdCurrEduCls);

if (clsCurrEduClsTeacherBL.relatedActions != null)
{
clsCurrEduClsTeacherBL.relatedActions.UpdRelaTabDate(objCurrEduClsTeacherEN.IdEduClsTeacher, objCurrEduClsTeacherEN.UpdUser);
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
public static bool AddRecordEx(this clsCurrEduClsTeacherEN objCurrEduClsTeacherEN, bool bolIsNeedCheckUniqueness = true)
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
objCurrEduClsTeacherEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objCurrEduClsTeacherEN.CheckUniqueness() == false)
{
strMsg = string.Format("(教学班流水号(IdCurrEduCls)=[{0}],教师流水号(IdTeacher)=[{1}])已经存在,不能重复!", objCurrEduClsTeacherEN.IdCurrEduCls, objCurrEduClsTeacherEN.IdTeacher);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objCurrEduClsTeacherEN.AddNewRecord();
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
 /// <param name = "objCurrEduClsTeacherEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsCurrEduClsTeacherEN objCurrEduClsTeacherEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCurrEduClsTeacherEN) == false)
{
var strMsg = string.Format("记录已经存在!教学班流水号 = [{0}],教师流水号 = [{1}]的数据已经存在!(in clsCurrEduClsTeacherBL.AddNewRecordWithReturnKey)", objCurrEduClsTeacherEN.IdCurrEduCls,objCurrEduClsTeacherEN.IdTeacher);
throw new Exception(strMsg);
}
try
{
string strKey = clsCurrEduClsTeacherBL.CurrEduClsTeacherDA.AddNewRecordBySQL2WithReturnKey(objCurrEduClsTeacherEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsTeacherBL.ReFreshCache(objCurrEduClsTeacherEN.IdCurrEduCls);

if (clsCurrEduClsTeacherBL.relatedActions != null)
{
clsCurrEduClsTeacherBL.relatedActions.UpdRelaTabDate(objCurrEduClsTeacherEN.IdEduClsTeacher, objCurrEduClsTeacherEN.UpdUser);
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
 /// <param name = "objCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsTeacherEN SetIdEduClsTeacher(this clsCurrEduClsTeacherEN objCurrEduClsTeacherEN, long lngIdEduClsTeacher, string strComparisonOp="")
	{
objCurrEduClsTeacherEN.IdEduClsTeacher = lngIdEduClsTeacher; //教学班老师流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(conCurrEduClsTeacher.IdEduClsTeacher) == false)
{
objCurrEduClsTeacherEN.dicFldComparisonOp.Add(conCurrEduClsTeacher.IdEduClsTeacher, strComparisonOp);
}
else
{
objCurrEduClsTeacherEN.dicFldComparisonOp[conCurrEduClsTeacher.IdEduClsTeacher] = strComparisonOp;
}
}
return objCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsTeacherEN SetIdCurrEduCls(this clsCurrEduClsTeacherEN objCurrEduClsTeacherEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conCurrEduClsTeacher.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conCurrEduClsTeacher.IdCurrEduCls);
}
objCurrEduClsTeacherEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(conCurrEduClsTeacher.IdCurrEduCls) == false)
{
objCurrEduClsTeacherEN.dicFldComparisonOp.Add(conCurrEduClsTeacher.IdCurrEduCls, strComparisonOp);
}
else
{
objCurrEduClsTeacherEN.dicFldComparisonOp[conCurrEduClsTeacher.IdCurrEduCls] = strComparisonOp;
}
}
return objCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsTeacherEN SetIdTeacher(this clsCurrEduClsTeacherEN objCurrEduClsTeacherEN, string strIdTeacher, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeacher, 8, conCurrEduClsTeacher.IdTeacher);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeacher, 8, conCurrEduClsTeacher.IdTeacher);
}
objCurrEduClsTeacherEN.IdTeacher = strIdTeacher; //教师流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(conCurrEduClsTeacher.IdTeacher) == false)
{
objCurrEduClsTeacherEN.dicFldComparisonOp.Add(conCurrEduClsTeacher.IdTeacher, strComparisonOp);
}
else
{
objCurrEduClsTeacherEN.dicFldComparisonOp[conCurrEduClsTeacher.IdTeacher] = strComparisonOp;
}
}
return objCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsTeacherEN SetIdPk2EduClsTeacherType(this clsCurrEduClsTeacherEN objCurrEduClsTeacherEN, string strIdPk2EduClsTeacherType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdPk2EduClsTeacherType, 4, conCurrEduClsTeacher.IdPk2EduClsTeacherType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdPk2EduClsTeacherType, 4, conCurrEduClsTeacher.IdPk2EduClsTeacherType);
}
objCurrEduClsTeacherEN.IdPk2EduClsTeacherType = strIdPk2EduClsTeacherType; //教学班老师角色(主讲,辅导)流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(conCurrEduClsTeacher.IdPk2EduClsTeacherType) == false)
{
objCurrEduClsTeacherEN.dicFldComparisonOp.Add(conCurrEduClsTeacher.IdPk2EduClsTeacherType, strComparisonOp);
}
else
{
objCurrEduClsTeacherEN.dicFldComparisonOp[conCurrEduClsTeacher.IdPk2EduClsTeacherType] = strComparisonOp;
}
}
return objCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsTeacherEN SetSchoolTerm(this clsCurrEduClsTeacherEN objCurrEduClsTeacherEN, string strSchoolTerm, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, conCurrEduClsTeacher.SchoolTerm);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, conCurrEduClsTeacher.SchoolTerm);
}
objCurrEduClsTeacherEN.SchoolTerm = strSchoolTerm; //学期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(conCurrEduClsTeacher.SchoolTerm) == false)
{
objCurrEduClsTeacherEN.dicFldComparisonOp.Add(conCurrEduClsTeacher.SchoolTerm, strComparisonOp);
}
else
{
objCurrEduClsTeacherEN.dicFldComparisonOp[conCurrEduClsTeacher.SchoolTerm] = strComparisonOp;
}
}
return objCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsTeacherEN SetSchoolYear(this clsCurrEduClsTeacherEN objCurrEduClsTeacherEN, string strSchoolYear, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, conCurrEduClsTeacher.SchoolYear);
}
objCurrEduClsTeacherEN.SchoolYear = strSchoolYear; //学年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(conCurrEduClsTeacher.SchoolYear) == false)
{
objCurrEduClsTeacherEN.dicFldComparisonOp.Add(conCurrEduClsTeacher.SchoolYear, strComparisonOp);
}
else
{
objCurrEduClsTeacherEN.dicFldComparisonOp[conCurrEduClsTeacher.SchoolYear] = strComparisonOp;
}
}
return objCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsTeacherEN SetOpenBeginDate(this clsCurrEduClsTeacherEN objCurrEduClsTeacherEN, string strOpenBeginDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOpenBeginDate, 8, conCurrEduClsTeacher.OpenBeginDate);
}
objCurrEduClsTeacherEN.OpenBeginDate = strOpenBeginDate; //开放开始日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(conCurrEduClsTeacher.OpenBeginDate) == false)
{
objCurrEduClsTeacherEN.dicFldComparisonOp.Add(conCurrEduClsTeacher.OpenBeginDate, strComparisonOp);
}
else
{
objCurrEduClsTeacherEN.dicFldComparisonOp[conCurrEduClsTeacher.OpenBeginDate] = strComparisonOp;
}
}
return objCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsTeacherEN SetOpenEndDate(this clsCurrEduClsTeacherEN objCurrEduClsTeacherEN, string strOpenEndDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOpenEndDate, 8, conCurrEduClsTeacher.OpenEndDate);
}
objCurrEduClsTeacherEN.OpenEndDate = strOpenEndDate; //开放结束日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(conCurrEduClsTeacher.OpenEndDate) == false)
{
objCurrEduClsTeacherEN.dicFldComparisonOp.Add(conCurrEduClsTeacher.OpenEndDate, strComparisonOp);
}
else
{
objCurrEduClsTeacherEN.dicFldComparisonOp[conCurrEduClsTeacher.OpenEndDate] = strComparisonOp;
}
}
return objCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsTeacherEN SetOrderNum(this clsCurrEduClsTeacherEN objCurrEduClsTeacherEN, int? intOrderNum, string strComparisonOp="")
	{
objCurrEduClsTeacherEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(conCurrEduClsTeacher.OrderNum) == false)
{
objCurrEduClsTeacherEN.dicFldComparisonOp.Add(conCurrEduClsTeacher.OrderNum, strComparisonOp);
}
else
{
objCurrEduClsTeacherEN.dicFldComparisonOp[conCurrEduClsTeacher.OrderNum] = strComparisonOp;
}
}
return objCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsTeacherEN SetUpdDate(this clsCurrEduClsTeacherEN objCurrEduClsTeacherEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conCurrEduClsTeacher.UpdDate);
}
objCurrEduClsTeacherEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(conCurrEduClsTeacher.UpdDate) == false)
{
objCurrEduClsTeacherEN.dicFldComparisonOp.Add(conCurrEduClsTeacher.UpdDate, strComparisonOp);
}
else
{
objCurrEduClsTeacherEN.dicFldComparisonOp[conCurrEduClsTeacher.UpdDate] = strComparisonOp;
}
}
return objCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsTeacherEN SetLastVisitedDate(this clsCurrEduClsTeacherEN objCurrEduClsTeacherEN, string strLastVisitedDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strLastVisitedDate, conCurrEduClsTeacher.LastVisitedDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLastVisitedDate, 20, conCurrEduClsTeacher.LastVisitedDate);
}
objCurrEduClsTeacherEN.LastVisitedDate = strLastVisitedDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(conCurrEduClsTeacher.LastVisitedDate) == false)
{
objCurrEduClsTeacherEN.dicFldComparisonOp.Add(conCurrEduClsTeacher.LastVisitedDate, strComparisonOp);
}
else
{
objCurrEduClsTeacherEN.dicFldComparisonOp[conCurrEduClsTeacher.LastVisitedDate] = strComparisonOp;
}
}
return objCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsTeacherEN SetUpdUser(this clsCurrEduClsTeacherEN objCurrEduClsTeacherEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conCurrEduClsTeacher.UpdUser);
}
objCurrEduClsTeacherEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(conCurrEduClsTeacher.UpdUser) == false)
{
objCurrEduClsTeacherEN.dicFldComparisonOp.Add(conCurrEduClsTeacher.UpdUser, strComparisonOp);
}
else
{
objCurrEduClsTeacherEN.dicFldComparisonOp[conCurrEduClsTeacher.UpdUser] = strComparisonOp;
}
}
return objCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsTeacherEN SetMemo(this clsCurrEduClsTeacherEN objCurrEduClsTeacherEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCurrEduClsTeacher.Memo);
}
objCurrEduClsTeacherEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(conCurrEduClsTeacher.Memo) == false)
{
objCurrEduClsTeacherEN.dicFldComparisonOp.Add(conCurrEduClsTeacher.Memo, strComparisonOp);
}
else
{
objCurrEduClsTeacherEN.dicFldComparisonOp[conCurrEduClsTeacher.Memo] = strComparisonOp;
}
}
return objCurrEduClsTeacherEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objCurrEduClsTeacherEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsCurrEduClsTeacherEN objCurrEduClsTeacherEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objCurrEduClsTeacherEN.CheckPropertyNew();
clsCurrEduClsTeacherEN objCurrEduClsTeacherCond = new clsCurrEduClsTeacherEN();
string strCondition = objCurrEduClsTeacherCond
.SetIdEduClsTeacher(objCurrEduClsTeacherEN.IdEduClsTeacher, "<>")
.SetIdCurrEduCls(objCurrEduClsTeacherEN.IdCurrEduCls, "=")
.SetIdTeacher(objCurrEduClsTeacherEN.IdTeacher, "=")
.GetCombineCondition();
objCurrEduClsTeacherEN._IsCheckProperty = true;
bool bolIsExist = clsCurrEduClsTeacherBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(id_CurrEduCls_id_Teacher)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objCurrEduClsTeacherEN.Update();
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
 /// <param name = "objCurrEduClsTeacher">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsCurrEduClsTeacherEN objCurrEduClsTeacher)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsCurrEduClsTeacherEN objCurrEduClsTeacherCond = new clsCurrEduClsTeacherEN();
string strCondition = objCurrEduClsTeacherCond
.SetIdCurrEduCls(objCurrEduClsTeacher.IdCurrEduCls, "=")
.SetIdTeacher(objCurrEduClsTeacher.IdTeacher, "=")
.GetCombineCondition();
objCurrEduClsTeacher._IsCheckProperty = true;
bool bolIsExist = clsCurrEduClsTeacherBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objCurrEduClsTeacher.IdEduClsTeacher = clsCurrEduClsTeacherBL.GetFirstID_S(strCondition);
objCurrEduClsTeacher.UpdateWithCondition(strCondition);
}
else
{
objCurrEduClsTeacher.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objCurrEduClsTeacherEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCurrEduClsTeacherEN objCurrEduClsTeacherEN)
{
 if (objCurrEduClsTeacherEN.IdEduClsTeacher == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCurrEduClsTeacherBL.CurrEduClsTeacherDA.UpdateBySql2(objCurrEduClsTeacherEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsTeacherBL.ReFreshCache(objCurrEduClsTeacherEN.IdCurrEduCls);

if (clsCurrEduClsTeacherBL.relatedActions != null)
{
clsCurrEduClsTeacherBL.relatedActions.UpdRelaTabDate(objCurrEduClsTeacherEN.IdEduClsTeacher, objCurrEduClsTeacherEN.UpdUser);
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
 /// <param name = "objCurrEduClsTeacherEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCurrEduClsTeacherEN objCurrEduClsTeacherEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objCurrEduClsTeacherEN.IdEduClsTeacher == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCurrEduClsTeacherBL.CurrEduClsTeacherDA.UpdateBySql2(objCurrEduClsTeacherEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsTeacherBL.ReFreshCache(objCurrEduClsTeacherEN.IdCurrEduCls);

if (clsCurrEduClsTeacherBL.relatedActions != null)
{
clsCurrEduClsTeacherBL.relatedActions.UpdRelaTabDate(objCurrEduClsTeacherEN.IdEduClsTeacher, objCurrEduClsTeacherEN.UpdUser);
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
 /// <param name = "objCurrEduClsTeacherEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCurrEduClsTeacherEN objCurrEduClsTeacherEN, string strWhereCond)
{
try
{
bool bolResult = clsCurrEduClsTeacherBL.CurrEduClsTeacherDA.UpdateBySqlWithCondition(objCurrEduClsTeacherEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsTeacherBL.ReFreshCache(objCurrEduClsTeacherEN.IdCurrEduCls);

if (clsCurrEduClsTeacherBL.relatedActions != null)
{
clsCurrEduClsTeacherBL.relatedActions.UpdRelaTabDate(objCurrEduClsTeacherEN.IdEduClsTeacher, objCurrEduClsTeacherEN.UpdUser);
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
 /// <param name = "objCurrEduClsTeacherEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCurrEduClsTeacherEN objCurrEduClsTeacherEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsCurrEduClsTeacherBL.CurrEduClsTeacherDA.UpdateBySqlWithConditionTransaction(objCurrEduClsTeacherEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsTeacherBL.ReFreshCache(objCurrEduClsTeacherEN.IdCurrEduCls);

if (clsCurrEduClsTeacherBL.relatedActions != null)
{
clsCurrEduClsTeacherBL.relatedActions.UpdRelaTabDate(objCurrEduClsTeacherEN.IdEduClsTeacher, objCurrEduClsTeacherEN.UpdUser);
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
 /// <param name = "lngIdEduClsTeacher">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsCurrEduClsTeacherEN objCurrEduClsTeacherEN)
{
try
{
int intRecNum = clsCurrEduClsTeacherBL.CurrEduClsTeacherDA.DelRecord(objCurrEduClsTeacherEN.IdEduClsTeacher);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsTeacherBL.ReFreshCache(objCurrEduClsTeacherEN.IdCurrEduCls);

if (clsCurrEduClsTeacherBL.relatedActions != null)
{
clsCurrEduClsTeacherBL.relatedActions.UpdRelaTabDate(objCurrEduClsTeacherEN.IdEduClsTeacher, objCurrEduClsTeacherEN.UpdUser);
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
 /// <param name = "objCurrEduClsTeacherENS">源对象</param>
 /// <param name = "objCurrEduClsTeacherENT">目标对象</param>
 public static void CopyTo(this clsCurrEduClsTeacherEN objCurrEduClsTeacherENS, clsCurrEduClsTeacherEN objCurrEduClsTeacherENT)
{
try
{
objCurrEduClsTeacherENT.IdEduClsTeacher = objCurrEduClsTeacherENS.IdEduClsTeacher; //教学班老师流水号
objCurrEduClsTeacherENT.IdCurrEduCls = objCurrEduClsTeacherENS.IdCurrEduCls; //教学班流水号
objCurrEduClsTeacherENT.IdTeacher = objCurrEduClsTeacherENS.IdTeacher; //教师流水号
objCurrEduClsTeacherENT.IdPk2EduClsTeacherType = objCurrEduClsTeacherENS.IdPk2EduClsTeacherType; //教学班老师角色(主讲,辅导)流水号
objCurrEduClsTeacherENT.SchoolTerm = objCurrEduClsTeacherENS.SchoolTerm; //学期
objCurrEduClsTeacherENT.SchoolYear = objCurrEduClsTeacherENS.SchoolYear; //学年
objCurrEduClsTeacherENT.OpenBeginDate = objCurrEduClsTeacherENS.OpenBeginDate; //开放开始日期
objCurrEduClsTeacherENT.OpenEndDate = objCurrEduClsTeacherENS.OpenEndDate; //开放结束日期
objCurrEduClsTeacherENT.OrderNum = objCurrEduClsTeacherENS.OrderNum; //序号
objCurrEduClsTeacherENT.UpdDate = objCurrEduClsTeacherENS.UpdDate; //修改日期
objCurrEduClsTeacherENT.LastVisitedDate = objCurrEduClsTeacherENS.LastVisitedDate; //修改日期
objCurrEduClsTeacherENT.UpdUser = objCurrEduClsTeacherENS.UpdUser; //修改人
objCurrEduClsTeacherENT.Memo = objCurrEduClsTeacherENS.Memo; //备注
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
 /// <param name = "objCurrEduClsTeacherENS">源对象</param>
 /// <returns>目标对象=>clsCurrEduClsTeacherEN:objCurrEduClsTeacherENT</returns>
 public static clsCurrEduClsTeacherEN CopyTo(this clsCurrEduClsTeacherEN objCurrEduClsTeacherENS)
{
try
{
 clsCurrEduClsTeacherEN objCurrEduClsTeacherENT = new clsCurrEduClsTeacherEN()
{
IdEduClsTeacher = objCurrEduClsTeacherENS.IdEduClsTeacher, //教学班老师流水号
IdCurrEduCls = objCurrEduClsTeacherENS.IdCurrEduCls, //教学班流水号
IdTeacher = objCurrEduClsTeacherENS.IdTeacher, //教师流水号
IdPk2EduClsTeacherType = objCurrEduClsTeacherENS.IdPk2EduClsTeacherType, //教学班老师角色(主讲,辅导)流水号
SchoolTerm = objCurrEduClsTeacherENS.SchoolTerm, //学期
SchoolYear = objCurrEduClsTeacherENS.SchoolYear, //学年
OpenBeginDate = objCurrEduClsTeacherENS.OpenBeginDate, //开放开始日期
OpenEndDate = objCurrEduClsTeacherENS.OpenEndDate, //开放结束日期
OrderNum = objCurrEduClsTeacherENS.OrderNum, //序号
UpdDate = objCurrEduClsTeacherENS.UpdDate, //修改日期
LastVisitedDate = objCurrEduClsTeacherENS.LastVisitedDate, //修改日期
UpdUser = objCurrEduClsTeacherENS.UpdUser, //修改人
Memo = objCurrEduClsTeacherENS.Memo, //备注
};
 return objCurrEduClsTeacherENT;
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
public static void CheckPropertyNew(this clsCurrEduClsTeacherEN objCurrEduClsTeacherEN)
{
 clsCurrEduClsTeacherBL.CurrEduClsTeacherDA.CheckPropertyNew(objCurrEduClsTeacherEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsCurrEduClsTeacherEN objCurrEduClsTeacherEN)
{
 clsCurrEduClsTeacherBL.CurrEduClsTeacherDA.CheckProperty4Condition(objCurrEduClsTeacherEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCurrEduClsTeacherEN objCurrEduClsTeacherCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCurrEduClsTeacherCond.IsUpdated(conCurrEduClsTeacher.IdEduClsTeacher) == true)
{
string strComparisonOpIdEduClsTeacher = objCurrEduClsTeacherCond.dicFldComparisonOp[conCurrEduClsTeacher.IdEduClsTeacher];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduClsTeacher.IdEduClsTeacher, objCurrEduClsTeacherCond.IdEduClsTeacher, strComparisonOpIdEduClsTeacher);
}
if (objCurrEduClsTeacherCond.IsUpdated(conCurrEduClsTeacher.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objCurrEduClsTeacherCond.dicFldComparisonOp[conCurrEduClsTeacher.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsTeacher.IdCurrEduCls, objCurrEduClsTeacherCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objCurrEduClsTeacherCond.IsUpdated(conCurrEduClsTeacher.IdTeacher) == true)
{
string strComparisonOpIdTeacher = objCurrEduClsTeacherCond.dicFldComparisonOp[conCurrEduClsTeacher.IdTeacher];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsTeacher.IdTeacher, objCurrEduClsTeacherCond.IdTeacher, strComparisonOpIdTeacher);
}
if (objCurrEduClsTeacherCond.IsUpdated(conCurrEduClsTeacher.IdPk2EduClsTeacherType) == true)
{
string strComparisonOpIdPk2EduClsTeacherType = objCurrEduClsTeacherCond.dicFldComparisonOp[conCurrEduClsTeacher.IdPk2EduClsTeacherType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsTeacher.IdPk2EduClsTeacherType, objCurrEduClsTeacherCond.IdPk2EduClsTeacherType, strComparisonOpIdPk2EduClsTeacherType);
}
if (objCurrEduClsTeacherCond.IsUpdated(conCurrEduClsTeacher.SchoolTerm) == true)
{
string strComparisonOpSchoolTerm = objCurrEduClsTeacherCond.dicFldComparisonOp[conCurrEduClsTeacher.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsTeacher.SchoolTerm, objCurrEduClsTeacherCond.SchoolTerm, strComparisonOpSchoolTerm);
}
if (objCurrEduClsTeacherCond.IsUpdated(conCurrEduClsTeacher.SchoolYear) == true)
{
string strComparisonOpSchoolYear = objCurrEduClsTeacherCond.dicFldComparisonOp[conCurrEduClsTeacher.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsTeacher.SchoolYear, objCurrEduClsTeacherCond.SchoolYear, strComparisonOpSchoolYear);
}
if (objCurrEduClsTeacherCond.IsUpdated(conCurrEduClsTeacher.OpenBeginDate) == true)
{
string strComparisonOpOpenBeginDate = objCurrEduClsTeacherCond.dicFldComparisonOp[conCurrEduClsTeacher.OpenBeginDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsTeacher.OpenBeginDate, objCurrEduClsTeacherCond.OpenBeginDate, strComparisonOpOpenBeginDate);
}
if (objCurrEduClsTeacherCond.IsUpdated(conCurrEduClsTeacher.OpenEndDate) == true)
{
string strComparisonOpOpenEndDate = objCurrEduClsTeacherCond.dicFldComparisonOp[conCurrEduClsTeacher.OpenEndDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsTeacher.OpenEndDate, objCurrEduClsTeacherCond.OpenEndDate, strComparisonOpOpenEndDate);
}
if (objCurrEduClsTeacherCond.IsUpdated(conCurrEduClsTeacher.OrderNum) == true)
{
string strComparisonOpOrderNum = objCurrEduClsTeacherCond.dicFldComparisonOp[conCurrEduClsTeacher.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduClsTeacher.OrderNum, objCurrEduClsTeacherCond.OrderNum, strComparisonOpOrderNum);
}
if (objCurrEduClsTeacherCond.IsUpdated(conCurrEduClsTeacher.UpdDate) == true)
{
string strComparisonOpUpdDate = objCurrEduClsTeacherCond.dicFldComparisonOp[conCurrEduClsTeacher.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsTeacher.UpdDate, objCurrEduClsTeacherCond.UpdDate, strComparisonOpUpdDate);
}
if (objCurrEduClsTeacherCond.IsUpdated(conCurrEduClsTeacher.LastVisitedDate) == true)
{
string strComparisonOpLastVisitedDate = objCurrEduClsTeacherCond.dicFldComparisonOp[conCurrEduClsTeacher.LastVisitedDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsTeacher.LastVisitedDate, objCurrEduClsTeacherCond.LastVisitedDate, strComparisonOpLastVisitedDate);
}
if (objCurrEduClsTeacherCond.IsUpdated(conCurrEduClsTeacher.UpdUser) == true)
{
string strComparisonOpUpdUser = objCurrEduClsTeacherCond.dicFldComparisonOp[conCurrEduClsTeacher.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsTeacher.UpdUser, objCurrEduClsTeacherCond.UpdUser, strComparisonOpUpdUser);
}
if (objCurrEduClsTeacherCond.IsUpdated(conCurrEduClsTeacher.Memo) == true)
{
string strComparisonOpMemo = objCurrEduClsTeacherCond.dicFldComparisonOp[conCurrEduClsTeacher.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsTeacher.Memo, objCurrEduClsTeacherCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--CurrEduClsTeacher(当前教学班教师), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:id_CurrEduCls_id_Teacher
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objCurrEduClsTeacherEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsCurrEduClsTeacherEN objCurrEduClsTeacherEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objCurrEduClsTeacherEN == null) return true;
if (objCurrEduClsTeacherEN.IdEduClsTeacher == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objCurrEduClsTeacherEN.IdCurrEduCls == null)
{
 sbCondition.AppendFormat(" and IdCurrEduCls is null", objCurrEduClsTeacherEN.IdCurrEduCls);
}
else
{
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objCurrEduClsTeacherEN.IdCurrEduCls);
}
 if (objCurrEduClsTeacherEN.IdTeacher == null)
{
 sbCondition.AppendFormat(" and IdTeacher is null", objCurrEduClsTeacherEN.IdTeacher);
}
else
{
 sbCondition.AppendFormat(" and IdTeacher = '{0}'", objCurrEduClsTeacherEN.IdTeacher);
}
if (clsCurrEduClsTeacherBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("IdEduClsTeacher !=  {0}", objCurrEduClsTeacherEN.IdEduClsTeacher);
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objCurrEduClsTeacherEN.IdCurrEduCls);
 sbCondition.AppendFormat(" and IdTeacher = '{0}'", objCurrEduClsTeacherEN.IdTeacher);
if (clsCurrEduClsTeacherBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--CurrEduClsTeacher(当前教学班教师), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:id_CurrEduCls_id_Teacher
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCurrEduClsTeacherEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsCurrEduClsTeacherEN objCurrEduClsTeacherEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCurrEduClsTeacherEN == null) return "";
if (objCurrEduClsTeacherEN.IdEduClsTeacher == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objCurrEduClsTeacherEN.IdCurrEduCls == null)
{
 sbCondition.AppendFormat(" and IdCurrEduCls is null", objCurrEduClsTeacherEN.IdCurrEduCls);
}
else
{
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objCurrEduClsTeacherEN.IdCurrEduCls);
}
 if (objCurrEduClsTeacherEN.IdTeacher == null)
{
 sbCondition.AppendFormat(" and IdTeacher is null", objCurrEduClsTeacherEN.IdTeacher);
}
else
{
 sbCondition.AppendFormat(" and IdTeacher = '{0}'", objCurrEduClsTeacherEN.IdTeacher);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("IdEduClsTeacher !=  {0}", objCurrEduClsTeacherEN.IdEduClsTeacher);
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objCurrEduClsTeacherEN.IdCurrEduCls);
 sbCondition.AppendFormat(" and IdTeacher = '{0}'", objCurrEduClsTeacherEN.IdTeacher);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_CurrEduClsTeacher
{
public virtual bool UpdRelaTabDate(long lngIdEduClsTeacher, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 当前教学班教师(CurrEduClsTeacher)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsCurrEduClsTeacherBL
{
public static RelatedActions_CurrEduClsTeacher relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsCurrEduClsTeacherDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsCurrEduClsTeacherDA CurrEduClsTeacherDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsCurrEduClsTeacherDA();
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
 public clsCurrEduClsTeacherBL()
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
if (string.IsNullOrEmpty(clsCurrEduClsTeacherEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCurrEduClsTeacherEN._ConnectString);
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
public static DataTable GetDataTable_CurrEduClsTeacher(string strWhereCond)
{
DataTable objDT;
try
{
objDT = CurrEduClsTeacherDA.GetDataTable_CurrEduClsTeacher(strWhereCond);
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
objDT = CurrEduClsTeacherDA.GetDataTable(strWhereCond);
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
objDT = CurrEduClsTeacherDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = CurrEduClsTeacherDA.GetDataTable(strWhereCond, strTabName);
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
objDT = CurrEduClsTeacherDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = CurrEduClsTeacherDA.GetDataTable_Top(objTopPara);
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
objDT = CurrEduClsTeacherDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = CurrEduClsTeacherDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = CurrEduClsTeacherDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdEduClsTeacherLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsCurrEduClsTeacherEN> GetObjLstByIdEduClsTeacherLst(List<long> arrIdEduClsTeacherLst)
{
List<clsCurrEduClsTeacherEN> arrObjLst = new List<clsCurrEduClsTeacherEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdEduClsTeacherLst);
 string strWhereCond = string.Format("IdEduClsTeacher in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduClsTeacherEN objCurrEduClsTeacherEN = new clsCurrEduClsTeacherEN();
try
{
objCurrEduClsTeacherEN.IdEduClsTeacher = Int32.Parse(objRow[conCurrEduClsTeacher.IdEduClsTeacher].ToString().Trim()); //教学班老师流水号
objCurrEduClsTeacherEN.IdCurrEduCls = objRow[conCurrEduClsTeacher.IdCurrEduCls] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsTeacherEN.IdTeacher = objRow[conCurrEduClsTeacher.IdTeacher] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.IdTeacher].ToString().Trim(); //教师流水号
objCurrEduClsTeacherEN.IdPk2EduClsTeacherType = objRow[conCurrEduClsTeacher.IdPk2EduClsTeacherType] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.IdPk2EduClsTeacherType].ToString().Trim(); //教学班老师角色(主讲,辅导)流水号
objCurrEduClsTeacherEN.SchoolTerm = objRow[conCurrEduClsTeacher.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsTeacherEN.SchoolYear = objRow[conCurrEduClsTeacher.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.SchoolYear].ToString().Trim(); //学年
objCurrEduClsTeacherEN.OpenBeginDate = objRow[conCurrEduClsTeacher.OpenBeginDate] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.OpenBeginDate].ToString().Trim(); //开放开始日期
objCurrEduClsTeacherEN.OpenEndDate = objRow[conCurrEduClsTeacher.OpenEndDate] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.OpenEndDate].ToString().Trim(); //开放结束日期
objCurrEduClsTeacherEN.OrderNum = objRow[conCurrEduClsTeacher.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduClsTeacher.OrderNum].ToString().Trim()); //序号
objCurrEduClsTeacherEN.UpdDate = objRow[conCurrEduClsTeacher.UpdDate] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.UpdDate].ToString().Trim(); //修改日期
objCurrEduClsTeacherEN.LastVisitedDate = objRow[conCurrEduClsTeacher.LastVisitedDate].ToString().Trim(); //修改日期
objCurrEduClsTeacherEN.UpdUser = objRow[conCurrEduClsTeacher.UpdUser] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.UpdUser].ToString().Trim(); //修改人
objCurrEduClsTeacherEN.Memo = objRow[conCurrEduClsTeacher.Memo] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduClsTeacherEN.IdEduClsTeacher, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduClsTeacherEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdEduClsTeacherLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsCurrEduClsTeacherEN> GetObjLstByIdEduClsTeacherLstCache(List<long> arrIdEduClsTeacherLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsCurrEduClsTeacherEN._CurrTabName, strIdCurrEduCls);
List<clsCurrEduClsTeacherEN> arrCurrEduClsTeacherObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsCurrEduClsTeacherEN> arrCurrEduClsTeacherObjLst_Sel =
arrCurrEduClsTeacherObjLstCache
.Where(x => arrIdEduClsTeacherLst.Contains(x.IdEduClsTeacher));
return arrCurrEduClsTeacherObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCurrEduClsTeacherEN> GetObjLst(string strWhereCond)
{
List<clsCurrEduClsTeacherEN> arrObjLst = new List<clsCurrEduClsTeacherEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduClsTeacherEN objCurrEduClsTeacherEN = new clsCurrEduClsTeacherEN();
try
{
objCurrEduClsTeacherEN.IdEduClsTeacher = Int32.Parse(objRow[conCurrEduClsTeacher.IdEduClsTeacher].ToString().Trim()); //教学班老师流水号
objCurrEduClsTeacherEN.IdCurrEduCls = objRow[conCurrEduClsTeacher.IdCurrEduCls] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsTeacherEN.IdTeacher = objRow[conCurrEduClsTeacher.IdTeacher] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.IdTeacher].ToString().Trim(); //教师流水号
objCurrEduClsTeacherEN.IdPk2EduClsTeacherType = objRow[conCurrEduClsTeacher.IdPk2EduClsTeacherType] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.IdPk2EduClsTeacherType].ToString().Trim(); //教学班老师角色(主讲,辅导)流水号
objCurrEduClsTeacherEN.SchoolTerm = objRow[conCurrEduClsTeacher.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsTeacherEN.SchoolYear = objRow[conCurrEduClsTeacher.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.SchoolYear].ToString().Trim(); //学年
objCurrEduClsTeacherEN.OpenBeginDate = objRow[conCurrEduClsTeacher.OpenBeginDate] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.OpenBeginDate].ToString().Trim(); //开放开始日期
objCurrEduClsTeacherEN.OpenEndDate = objRow[conCurrEduClsTeacher.OpenEndDate] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.OpenEndDate].ToString().Trim(); //开放结束日期
objCurrEduClsTeacherEN.OrderNum = objRow[conCurrEduClsTeacher.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduClsTeacher.OrderNum].ToString().Trim()); //序号
objCurrEduClsTeacherEN.UpdDate = objRow[conCurrEduClsTeacher.UpdDate] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.UpdDate].ToString().Trim(); //修改日期
objCurrEduClsTeacherEN.LastVisitedDate = objRow[conCurrEduClsTeacher.LastVisitedDate].ToString().Trim(); //修改日期
objCurrEduClsTeacherEN.UpdUser = objRow[conCurrEduClsTeacher.UpdUser] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.UpdUser].ToString().Trim(); //修改人
objCurrEduClsTeacherEN.Memo = objRow[conCurrEduClsTeacher.Memo] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduClsTeacherEN.IdEduClsTeacher, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduClsTeacherEN);
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
public static List<clsCurrEduClsTeacherEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsCurrEduClsTeacherEN> arrObjLst = new List<clsCurrEduClsTeacherEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduClsTeacherEN objCurrEduClsTeacherEN = new clsCurrEduClsTeacherEN();
try
{
objCurrEduClsTeacherEN.IdEduClsTeacher = Int32.Parse(objRow[conCurrEduClsTeacher.IdEduClsTeacher].ToString().Trim()); //教学班老师流水号
objCurrEduClsTeacherEN.IdCurrEduCls = objRow[conCurrEduClsTeacher.IdCurrEduCls] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsTeacherEN.IdTeacher = objRow[conCurrEduClsTeacher.IdTeacher] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.IdTeacher].ToString().Trim(); //教师流水号
objCurrEduClsTeacherEN.IdPk2EduClsTeacherType = objRow[conCurrEduClsTeacher.IdPk2EduClsTeacherType] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.IdPk2EduClsTeacherType].ToString().Trim(); //教学班老师角色(主讲,辅导)流水号
objCurrEduClsTeacherEN.SchoolTerm = objRow[conCurrEduClsTeacher.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsTeacherEN.SchoolYear = objRow[conCurrEduClsTeacher.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.SchoolYear].ToString().Trim(); //学年
objCurrEduClsTeacherEN.OpenBeginDate = objRow[conCurrEduClsTeacher.OpenBeginDate] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.OpenBeginDate].ToString().Trim(); //开放开始日期
objCurrEduClsTeacherEN.OpenEndDate = objRow[conCurrEduClsTeacher.OpenEndDate] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.OpenEndDate].ToString().Trim(); //开放结束日期
objCurrEduClsTeacherEN.OrderNum = objRow[conCurrEduClsTeacher.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduClsTeacher.OrderNum].ToString().Trim()); //序号
objCurrEduClsTeacherEN.UpdDate = objRow[conCurrEduClsTeacher.UpdDate] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.UpdDate].ToString().Trim(); //修改日期
objCurrEduClsTeacherEN.LastVisitedDate = objRow[conCurrEduClsTeacher.LastVisitedDate].ToString().Trim(); //修改日期
objCurrEduClsTeacherEN.UpdUser = objRow[conCurrEduClsTeacher.UpdUser] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.UpdUser].ToString().Trim(); //修改人
objCurrEduClsTeacherEN.Memo = objRow[conCurrEduClsTeacher.Memo] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduClsTeacherEN.IdEduClsTeacher, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduClsTeacherEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objCurrEduClsTeacherCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsCurrEduClsTeacherEN> GetSubObjLstCache(clsCurrEduClsTeacherEN objCurrEduClsTeacherCond)
{
 string strIdCurrEduCls = objCurrEduClsTeacherCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsCurrEduClsTeacherBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsCurrEduClsTeacherEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsCurrEduClsTeacherEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCurrEduClsTeacher.AttributeName)
{
if (objCurrEduClsTeacherCond.IsUpdated(strFldName) == false) continue;
if (objCurrEduClsTeacherCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCurrEduClsTeacherCond[strFldName].ToString());
}
else
{
if (objCurrEduClsTeacherCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCurrEduClsTeacherCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCurrEduClsTeacherCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCurrEduClsTeacherCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCurrEduClsTeacherCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCurrEduClsTeacherCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCurrEduClsTeacherCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCurrEduClsTeacherCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCurrEduClsTeacherCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCurrEduClsTeacherCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCurrEduClsTeacherCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCurrEduClsTeacherCond[strFldName]));
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
public static List<clsCurrEduClsTeacherEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsCurrEduClsTeacherEN> arrObjLst = new List<clsCurrEduClsTeacherEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduClsTeacherEN objCurrEduClsTeacherEN = new clsCurrEduClsTeacherEN();
try
{
objCurrEduClsTeacherEN.IdEduClsTeacher = Int32.Parse(objRow[conCurrEduClsTeacher.IdEduClsTeacher].ToString().Trim()); //教学班老师流水号
objCurrEduClsTeacherEN.IdCurrEduCls = objRow[conCurrEduClsTeacher.IdCurrEduCls] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsTeacherEN.IdTeacher = objRow[conCurrEduClsTeacher.IdTeacher] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.IdTeacher].ToString().Trim(); //教师流水号
objCurrEduClsTeacherEN.IdPk2EduClsTeacherType = objRow[conCurrEduClsTeacher.IdPk2EduClsTeacherType] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.IdPk2EduClsTeacherType].ToString().Trim(); //教学班老师角色(主讲,辅导)流水号
objCurrEduClsTeacherEN.SchoolTerm = objRow[conCurrEduClsTeacher.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsTeacherEN.SchoolYear = objRow[conCurrEduClsTeacher.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.SchoolYear].ToString().Trim(); //学年
objCurrEduClsTeacherEN.OpenBeginDate = objRow[conCurrEduClsTeacher.OpenBeginDate] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.OpenBeginDate].ToString().Trim(); //开放开始日期
objCurrEduClsTeacherEN.OpenEndDate = objRow[conCurrEduClsTeacher.OpenEndDate] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.OpenEndDate].ToString().Trim(); //开放结束日期
objCurrEduClsTeacherEN.OrderNum = objRow[conCurrEduClsTeacher.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduClsTeacher.OrderNum].ToString().Trim()); //序号
objCurrEduClsTeacherEN.UpdDate = objRow[conCurrEduClsTeacher.UpdDate] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.UpdDate].ToString().Trim(); //修改日期
objCurrEduClsTeacherEN.LastVisitedDate = objRow[conCurrEduClsTeacher.LastVisitedDate].ToString().Trim(); //修改日期
objCurrEduClsTeacherEN.UpdUser = objRow[conCurrEduClsTeacher.UpdUser] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.UpdUser].ToString().Trim(); //修改人
objCurrEduClsTeacherEN.Memo = objRow[conCurrEduClsTeacher.Memo] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduClsTeacherEN.IdEduClsTeacher, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduClsTeacherEN);
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
public static List<clsCurrEduClsTeacherEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsCurrEduClsTeacherEN> arrObjLst = new List<clsCurrEduClsTeacherEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduClsTeacherEN objCurrEduClsTeacherEN = new clsCurrEduClsTeacherEN();
try
{
objCurrEduClsTeacherEN.IdEduClsTeacher = Int32.Parse(objRow[conCurrEduClsTeacher.IdEduClsTeacher].ToString().Trim()); //教学班老师流水号
objCurrEduClsTeacherEN.IdCurrEduCls = objRow[conCurrEduClsTeacher.IdCurrEduCls] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsTeacherEN.IdTeacher = objRow[conCurrEduClsTeacher.IdTeacher] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.IdTeacher].ToString().Trim(); //教师流水号
objCurrEduClsTeacherEN.IdPk2EduClsTeacherType = objRow[conCurrEduClsTeacher.IdPk2EduClsTeacherType] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.IdPk2EduClsTeacherType].ToString().Trim(); //教学班老师角色(主讲,辅导)流水号
objCurrEduClsTeacherEN.SchoolTerm = objRow[conCurrEduClsTeacher.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsTeacherEN.SchoolYear = objRow[conCurrEduClsTeacher.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.SchoolYear].ToString().Trim(); //学年
objCurrEduClsTeacherEN.OpenBeginDate = objRow[conCurrEduClsTeacher.OpenBeginDate] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.OpenBeginDate].ToString().Trim(); //开放开始日期
objCurrEduClsTeacherEN.OpenEndDate = objRow[conCurrEduClsTeacher.OpenEndDate] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.OpenEndDate].ToString().Trim(); //开放结束日期
objCurrEduClsTeacherEN.OrderNum = objRow[conCurrEduClsTeacher.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduClsTeacher.OrderNum].ToString().Trim()); //序号
objCurrEduClsTeacherEN.UpdDate = objRow[conCurrEduClsTeacher.UpdDate] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.UpdDate].ToString().Trim(); //修改日期
objCurrEduClsTeacherEN.LastVisitedDate = objRow[conCurrEduClsTeacher.LastVisitedDate].ToString().Trim(); //修改日期
objCurrEduClsTeacherEN.UpdUser = objRow[conCurrEduClsTeacher.UpdUser] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.UpdUser].ToString().Trim(); //修改人
objCurrEduClsTeacherEN.Memo = objRow[conCurrEduClsTeacher.Memo] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduClsTeacherEN.IdEduClsTeacher, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduClsTeacherEN);
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
List<clsCurrEduClsTeacherEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsCurrEduClsTeacherEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsCurrEduClsTeacherEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsCurrEduClsTeacherEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsCurrEduClsTeacherEN> arrObjLst = new List<clsCurrEduClsTeacherEN>(); 
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
	clsCurrEduClsTeacherEN objCurrEduClsTeacherEN = new clsCurrEduClsTeacherEN();
try
{
objCurrEduClsTeacherEN.IdEduClsTeacher = Int32.Parse(objRow[conCurrEduClsTeacher.IdEduClsTeacher].ToString().Trim()); //教学班老师流水号
objCurrEduClsTeacherEN.IdCurrEduCls = objRow[conCurrEduClsTeacher.IdCurrEduCls] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsTeacherEN.IdTeacher = objRow[conCurrEduClsTeacher.IdTeacher] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.IdTeacher].ToString().Trim(); //教师流水号
objCurrEduClsTeacherEN.IdPk2EduClsTeacherType = objRow[conCurrEduClsTeacher.IdPk2EduClsTeacherType] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.IdPk2EduClsTeacherType].ToString().Trim(); //教学班老师角色(主讲,辅导)流水号
objCurrEduClsTeacherEN.SchoolTerm = objRow[conCurrEduClsTeacher.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsTeacherEN.SchoolYear = objRow[conCurrEduClsTeacher.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.SchoolYear].ToString().Trim(); //学年
objCurrEduClsTeacherEN.OpenBeginDate = objRow[conCurrEduClsTeacher.OpenBeginDate] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.OpenBeginDate].ToString().Trim(); //开放开始日期
objCurrEduClsTeacherEN.OpenEndDate = objRow[conCurrEduClsTeacher.OpenEndDate] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.OpenEndDate].ToString().Trim(); //开放结束日期
objCurrEduClsTeacherEN.OrderNum = objRow[conCurrEduClsTeacher.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduClsTeacher.OrderNum].ToString().Trim()); //序号
objCurrEduClsTeacherEN.UpdDate = objRow[conCurrEduClsTeacher.UpdDate] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.UpdDate].ToString().Trim(); //修改日期
objCurrEduClsTeacherEN.LastVisitedDate = objRow[conCurrEduClsTeacher.LastVisitedDate].ToString().Trim(); //修改日期
objCurrEduClsTeacherEN.UpdUser = objRow[conCurrEduClsTeacher.UpdUser] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.UpdUser].ToString().Trim(); //修改人
objCurrEduClsTeacherEN.Memo = objRow[conCurrEduClsTeacher.Memo] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduClsTeacherEN.IdEduClsTeacher, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduClsTeacherEN);
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
public static List<clsCurrEduClsTeacherEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsCurrEduClsTeacherEN> arrObjLst = new List<clsCurrEduClsTeacherEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduClsTeacherEN objCurrEduClsTeacherEN = new clsCurrEduClsTeacherEN();
try
{
objCurrEduClsTeacherEN.IdEduClsTeacher = Int32.Parse(objRow[conCurrEduClsTeacher.IdEduClsTeacher].ToString().Trim()); //教学班老师流水号
objCurrEduClsTeacherEN.IdCurrEduCls = objRow[conCurrEduClsTeacher.IdCurrEduCls] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsTeacherEN.IdTeacher = objRow[conCurrEduClsTeacher.IdTeacher] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.IdTeacher].ToString().Trim(); //教师流水号
objCurrEduClsTeacherEN.IdPk2EduClsTeacherType = objRow[conCurrEduClsTeacher.IdPk2EduClsTeacherType] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.IdPk2EduClsTeacherType].ToString().Trim(); //教学班老师角色(主讲,辅导)流水号
objCurrEduClsTeacherEN.SchoolTerm = objRow[conCurrEduClsTeacher.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsTeacherEN.SchoolYear = objRow[conCurrEduClsTeacher.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.SchoolYear].ToString().Trim(); //学年
objCurrEduClsTeacherEN.OpenBeginDate = objRow[conCurrEduClsTeacher.OpenBeginDate] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.OpenBeginDate].ToString().Trim(); //开放开始日期
objCurrEduClsTeacherEN.OpenEndDate = objRow[conCurrEduClsTeacher.OpenEndDate] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.OpenEndDate].ToString().Trim(); //开放结束日期
objCurrEduClsTeacherEN.OrderNum = objRow[conCurrEduClsTeacher.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduClsTeacher.OrderNum].ToString().Trim()); //序号
objCurrEduClsTeacherEN.UpdDate = objRow[conCurrEduClsTeacher.UpdDate] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.UpdDate].ToString().Trim(); //修改日期
objCurrEduClsTeacherEN.LastVisitedDate = objRow[conCurrEduClsTeacher.LastVisitedDate].ToString().Trim(); //修改日期
objCurrEduClsTeacherEN.UpdUser = objRow[conCurrEduClsTeacher.UpdUser] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.UpdUser].ToString().Trim(); //修改人
objCurrEduClsTeacherEN.Memo = objRow[conCurrEduClsTeacher.Memo] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduClsTeacherEN.IdEduClsTeacher, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduClsTeacherEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsCurrEduClsTeacherEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsCurrEduClsTeacherEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsCurrEduClsTeacherEN> arrObjLst = new List<clsCurrEduClsTeacherEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduClsTeacherEN objCurrEduClsTeacherEN = new clsCurrEduClsTeacherEN();
try
{
objCurrEduClsTeacherEN.IdEduClsTeacher = Int32.Parse(objRow[conCurrEduClsTeacher.IdEduClsTeacher].ToString().Trim()); //教学班老师流水号
objCurrEduClsTeacherEN.IdCurrEduCls = objRow[conCurrEduClsTeacher.IdCurrEduCls] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsTeacherEN.IdTeacher = objRow[conCurrEduClsTeacher.IdTeacher] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.IdTeacher].ToString().Trim(); //教师流水号
objCurrEduClsTeacherEN.IdPk2EduClsTeacherType = objRow[conCurrEduClsTeacher.IdPk2EduClsTeacherType] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.IdPk2EduClsTeacherType].ToString().Trim(); //教学班老师角色(主讲,辅导)流水号
objCurrEduClsTeacherEN.SchoolTerm = objRow[conCurrEduClsTeacher.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsTeacherEN.SchoolYear = objRow[conCurrEduClsTeacher.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.SchoolYear].ToString().Trim(); //学年
objCurrEduClsTeacherEN.OpenBeginDate = objRow[conCurrEduClsTeacher.OpenBeginDate] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.OpenBeginDate].ToString().Trim(); //开放开始日期
objCurrEduClsTeacherEN.OpenEndDate = objRow[conCurrEduClsTeacher.OpenEndDate] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.OpenEndDate].ToString().Trim(); //开放结束日期
objCurrEduClsTeacherEN.OrderNum = objRow[conCurrEduClsTeacher.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduClsTeacher.OrderNum].ToString().Trim()); //序号
objCurrEduClsTeacherEN.UpdDate = objRow[conCurrEduClsTeacher.UpdDate] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.UpdDate].ToString().Trim(); //修改日期
objCurrEduClsTeacherEN.LastVisitedDate = objRow[conCurrEduClsTeacher.LastVisitedDate].ToString().Trim(); //修改日期
objCurrEduClsTeacherEN.UpdUser = objRow[conCurrEduClsTeacher.UpdUser] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.UpdUser].ToString().Trim(); //修改人
objCurrEduClsTeacherEN.Memo = objRow[conCurrEduClsTeacher.Memo] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduClsTeacherEN.IdEduClsTeacher, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduClsTeacherEN);
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
public static List<clsCurrEduClsTeacherEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsCurrEduClsTeacherEN> arrObjLst = new List<clsCurrEduClsTeacherEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduClsTeacherEN objCurrEduClsTeacherEN = new clsCurrEduClsTeacherEN();
try
{
objCurrEduClsTeacherEN.IdEduClsTeacher = Int32.Parse(objRow[conCurrEduClsTeacher.IdEduClsTeacher].ToString().Trim()); //教学班老师流水号
objCurrEduClsTeacherEN.IdCurrEduCls = objRow[conCurrEduClsTeacher.IdCurrEduCls] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsTeacherEN.IdTeacher = objRow[conCurrEduClsTeacher.IdTeacher] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.IdTeacher].ToString().Trim(); //教师流水号
objCurrEduClsTeacherEN.IdPk2EduClsTeacherType = objRow[conCurrEduClsTeacher.IdPk2EduClsTeacherType] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.IdPk2EduClsTeacherType].ToString().Trim(); //教学班老师角色(主讲,辅导)流水号
objCurrEduClsTeacherEN.SchoolTerm = objRow[conCurrEduClsTeacher.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsTeacherEN.SchoolYear = objRow[conCurrEduClsTeacher.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.SchoolYear].ToString().Trim(); //学年
objCurrEduClsTeacherEN.OpenBeginDate = objRow[conCurrEduClsTeacher.OpenBeginDate] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.OpenBeginDate].ToString().Trim(); //开放开始日期
objCurrEduClsTeacherEN.OpenEndDate = objRow[conCurrEduClsTeacher.OpenEndDate] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.OpenEndDate].ToString().Trim(); //开放结束日期
objCurrEduClsTeacherEN.OrderNum = objRow[conCurrEduClsTeacher.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduClsTeacher.OrderNum].ToString().Trim()); //序号
objCurrEduClsTeacherEN.UpdDate = objRow[conCurrEduClsTeacher.UpdDate] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.UpdDate].ToString().Trim(); //修改日期
objCurrEduClsTeacherEN.LastVisitedDate = objRow[conCurrEduClsTeacher.LastVisitedDate].ToString().Trim(); //修改日期
objCurrEduClsTeacherEN.UpdUser = objRow[conCurrEduClsTeacher.UpdUser] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.UpdUser].ToString().Trim(); //修改人
objCurrEduClsTeacherEN.Memo = objRow[conCurrEduClsTeacher.Memo] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduClsTeacherEN.IdEduClsTeacher, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduClsTeacherEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsCurrEduClsTeacherEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsCurrEduClsTeacherEN> arrObjLst = new List<clsCurrEduClsTeacherEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduClsTeacherEN objCurrEduClsTeacherEN = new clsCurrEduClsTeacherEN();
try
{
objCurrEduClsTeacherEN.IdEduClsTeacher = Int32.Parse(objRow[conCurrEduClsTeacher.IdEduClsTeacher].ToString().Trim()); //教学班老师流水号
objCurrEduClsTeacherEN.IdCurrEduCls = objRow[conCurrEduClsTeacher.IdCurrEduCls] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsTeacherEN.IdTeacher = objRow[conCurrEduClsTeacher.IdTeacher] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.IdTeacher].ToString().Trim(); //教师流水号
objCurrEduClsTeacherEN.IdPk2EduClsTeacherType = objRow[conCurrEduClsTeacher.IdPk2EduClsTeacherType] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.IdPk2EduClsTeacherType].ToString().Trim(); //教学班老师角色(主讲,辅导)流水号
objCurrEduClsTeacherEN.SchoolTerm = objRow[conCurrEduClsTeacher.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsTeacherEN.SchoolYear = objRow[conCurrEduClsTeacher.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.SchoolYear].ToString().Trim(); //学年
objCurrEduClsTeacherEN.OpenBeginDate = objRow[conCurrEduClsTeacher.OpenBeginDate] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.OpenBeginDate].ToString().Trim(); //开放开始日期
objCurrEduClsTeacherEN.OpenEndDate = objRow[conCurrEduClsTeacher.OpenEndDate] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.OpenEndDate].ToString().Trim(); //开放结束日期
objCurrEduClsTeacherEN.OrderNum = objRow[conCurrEduClsTeacher.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduClsTeacher.OrderNum].ToString().Trim()); //序号
objCurrEduClsTeacherEN.UpdDate = objRow[conCurrEduClsTeacher.UpdDate] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.UpdDate].ToString().Trim(); //修改日期
objCurrEduClsTeacherEN.LastVisitedDate = objRow[conCurrEduClsTeacher.LastVisitedDate].ToString().Trim(); //修改日期
objCurrEduClsTeacherEN.UpdUser = objRow[conCurrEduClsTeacher.UpdUser] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.UpdUser].ToString().Trim(); //修改人
objCurrEduClsTeacherEN.Memo = objRow[conCurrEduClsTeacher.Memo] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduClsTeacherEN.IdEduClsTeacher, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduClsTeacherEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objCurrEduClsTeacherEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetCurrEduClsTeacher(ref clsCurrEduClsTeacherEN objCurrEduClsTeacherEN)
{
bool bolResult = CurrEduClsTeacherDA.GetCurrEduClsTeacher(ref objCurrEduClsTeacherEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdEduClsTeacher">表关键字</param>
 /// <returns>表对象</returns>
public static clsCurrEduClsTeacherEN GetObjByIdEduClsTeacher(long lngIdEduClsTeacher)
{
clsCurrEduClsTeacherEN objCurrEduClsTeacherEN = CurrEduClsTeacherDA.GetObjByIdEduClsTeacher(lngIdEduClsTeacher);
return objCurrEduClsTeacherEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsCurrEduClsTeacherEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsCurrEduClsTeacherEN objCurrEduClsTeacherEN = CurrEduClsTeacherDA.GetFirstObj(strWhereCond);
 return objCurrEduClsTeacherEN;
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
public static clsCurrEduClsTeacherEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsCurrEduClsTeacherEN objCurrEduClsTeacherEN = CurrEduClsTeacherDA.GetObjByDataRow(objRow);
 return objCurrEduClsTeacherEN;
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
public static clsCurrEduClsTeacherEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsCurrEduClsTeacherEN objCurrEduClsTeacherEN = CurrEduClsTeacherDA.GetObjByDataRow(objRow);
 return objCurrEduClsTeacherEN;
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
 /// <param name = "lngIdEduClsTeacher">所给的关键字</param>
 /// <param name = "lstCurrEduClsTeacherObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCurrEduClsTeacherEN GetObjByIdEduClsTeacherFromList(long lngIdEduClsTeacher, List<clsCurrEduClsTeacherEN> lstCurrEduClsTeacherObjLst)
{
foreach (clsCurrEduClsTeacherEN objCurrEduClsTeacherEN in lstCurrEduClsTeacherObjLst)
{
if (objCurrEduClsTeacherEN.IdEduClsTeacher == lngIdEduClsTeacher)
{
return objCurrEduClsTeacherEN;
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
 long lngIdEduClsTeacher;
 try
 {
 lngIdEduClsTeacher = new clsCurrEduClsTeacherDA().GetFirstID(strWhereCond);
 return lngIdEduClsTeacher;
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
 arrList = CurrEduClsTeacherDA.GetID(strWhereCond);
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
bool bolIsExist = CurrEduClsTeacherDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdEduClsTeacher">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdEduClsTeacher)
{
//检测记录是否存在
bool bolIsExist = CurrEduClsTeacherDA.IsExist(lngIdEduClsTeacher);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngIdEduClsTeacher">教学班老师流水号</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngIdEduClsTeacher, string strOpUser)
{
clsCurrEduClsTeacherEN objCurrEduClsTeacherEN = clsCurrEduClsTeacherBL.GetObjByIdEduClsTeacher(lngIdEduClsTeacher);
objCurrEduClsTeacherEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objCurrEduClsTeacherEN.UpdUser = strOpUser;
return clsCurrEduClsTeacherBL.UpdateBySql2(objCurrEduClsTeacherEN);
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
 bolIsExist = clsCurrEduClsTeacherDA.IsExistTable();
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
 bolIsExist = CurrEduClsTeacherDA.IsExistTable(strTabName);
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
 /// <param name = "objCurrEduClsTeacherEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsCurrEduClsTeacherEN objCurrEduClsTeacherEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objCurrEduClsTeacherEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!教学班流水号 = [{0}],教师流水号 = [{1}]的数据已经存在!(in clsCurrEduClsTeacherBL.AddNewRecordBySql2)", objCurrEduClsTeacherEN.IdCurrEduCls,objCurrEduClsTeacherEN.IdTeacher);
throw new Exception(strMsg);
}
try
{
bool bolResult = CurrEduClsTeacherDA.AddNewRecordBySQL2(objCurrEduClsTeacherEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsTeacherBL.ReFreshCache(objCurrEduClsTeacherEN.IdCurrEduCls);

if (clsCurrEduClsTeacherBL.relatedActions != null)
{
clsCurrEduClsTeacherBL.relatedActions.UpdRelaTabDate(objCurrEduClsTeacherEN.IdEduClsTeacher, objCurrEduClsTeacherEN.UpdUser);
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
 /// <param name = "objCurrEduClsTeacherEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsCurrEduClsTeacherEN objCurrEduClsTeacherEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objCurrEduClsTeacherEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!教学班流水号 = [{0}],教师流水号 = [{1}]的数据已经存在!(in clsCurrEduClsTeacherBL.AddNewRecordBySql2WithReturnKey)", objCurrEduClsTeacherEN.IdCurrEduCls,objCurrEduClsTeacherEN.IdTeacher);
throw new Exception(strMsg);
}
try
{
string strKey = CurrEduClsTeacherDA.AddNewRecordBySQL2WithReturnKey(objCurrEduClsTeacherEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsTeacherBL.ReFreshCache(objCurrEduClsTeacherEN.IdCurrEduCls);

if (clsCurrEduClsTeacherBL.relatedActions != null)
{
clsCurrEduClsTeacherBL.relatedActions.UpdRelaTabDate(objCurrEduClsTeacherEN.IdEduClsTeacher, objCurrEduClsTeacherEN.UpdUser);
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
 /// <param name = "objCurrEduClsTeacherEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsCurrEduClsTeacherEN objCurrEduClsTeacherEN)
{
try
{
bool bolResult = CurrEduClsTeacherDA.Update(objCurrEduClsTeacherEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsTeacherBL.ReFreshCache(objCurrEduClsTeacherEN.IdCurrEduCls);

if (clsCurrEduClsTeacherBL.relatedActions != null)
{
clsCurrEduClsTeacherBL.relatedActions.UpdRelaTabDate(objCurrEduClsTeacherEN.IdEduClsTeacher, objCurrEduClsTeacherEN.UpdUser);
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
 /// <param name = "objCurrEduClsTeacherEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsCurrEduClsTeacherEN objCurrEduClsTeacherEN)
{
 if (objCurrEduClsTeacherEN.IdEduClsTeacher == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = CurrEduClsTeacherDA.UpdateBySql2(objCurrEduClsTeacherEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsTeacherBL.ReFreshCache(objCurrEduClsTeacherEN.IdCurrEduCls);

if (clsCurrEduClsTeacherBL.relatedActions != null)
{
clsCurrEduClsTeacherBL.relatedActions.UpdRelaTabDate(objCurrEduClsTeacherEN.IdEduClsTeacher, objCurrEduClsTeacherEN.UpdUser);
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
 /// <param name = "lngIdEduClsTeacher">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngIdEduClsTeacher)
{
try
{
 clsCurrEduClsTeacherEN objCurrEduClsTeacherEN = clsCurrEduClsTeacherBL.GetObjByIdEduClsTeacher(lngIdEduClsTeacher);

if (clsCurrEduClsTeacherBL.relatedActions != null)
{
clsCurrEduClsTeacherBL.relatedActions.UpdRelaTabDate(objCurrEduClsTeacherEN.IdEduClsTeacher, objCurrEduClsTeacherEN.UpdUser);
}
if (objCurrEduClsTeacherEN != null)
{
int intRecNum = CurrEduClsTeacherDA.DelRecord(lngIdEduClsTeacher);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objCurrEduClsTeacherEN.IdCurrEduCls);
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
/// <param name="lngIdEduClsTeacher">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(long lngIdEduClsTeacher , string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCurrEduClsTeacherDA.GetSpecSQLObj();
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
//删除与表:[CurrEduClsTeacher]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conCurrEduClsTeacher.IdEduClsTeacher,
//lngIdEduClsTeacher);
//        clsCurrEduClsTeacherBL.DelCurrEduClsTeachersByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCurrEduClsTeacherBL.DelRecord(lngIdEduClsTeacher, strIdCurrEduCls, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCurrEduClsTeacherBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngIdEduClsTeacher, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngIdEduClsTeacher">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngIdEduClsTeacher, string strIdCurrEduCls, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsCurrEduClsTeacherBL.relatedActions != null)
{
clsCurrEduClsTeacherBL.relatedActions.UpdRelaTabDate(lngIdEduClsTeacher, "UpdRelaTabDate");
}
bool bolResult = CurrEduClsTeacherDA.DelRecord(lngIdEduClsTeacher,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdEduClsTeacherLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelCurrEduClsTeachers(List<string> arrIdEduClsTeacherLst)
{
if (arrIdEduClsTeacherLst.Count == 0) return 0;
try
{
if (clsCurrEduClsTeacherBL.relatedActions != null)
{
foreach (var strIdEduClsTeacher in arrIdEduClsTeacherLst)
{
long lngIdEduClsTeacher = long.Parse(strIdEduClsTeacher);
clsCurrEduClsTeacherBL.relatedActions.UpdRelaTabDate(lngIdEduClsTeacher, "UpdRelaTabDate");
}
}
 clsCurrEduClsTeacherEN objCurrEduClsTeacherEN = clsCurrEduClsTeacherBL.GetObjByIdEduClsTeacher(long.Parse(arrIdEduClsTeacherLst[0]));
int intDelRecNum = CurrEduClsTeacherDA.DelCurrEduClsTeacher(arrIdEduClsTeacherLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objCurrEduClsTeacherEN.IdCurrEduCls);
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
public static int DelCurrEduClsTeachersByCond(string strWhereCond)
{
try
{
if (clsCurrEduClsTeacherBL.relatedActions != null)
{
List<string> arrIdEduClsTeacher = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdEduClsTeacher in arrIdEduClsTeacher)
{
long lngIdEduClsTeacher = long.Parse(strIdEduClsTeacher);
clsCurrEduClsTeacherBL.relatedActions.UpdRelaTabDate(lngIdEduClsTeacher, "UpdRelaTabDate");
}
}
List<string> arrIdCurrEduCls = GetFldValue(conCurrEduClsTeacher.IdCurrEduCls, strWhereCond);
int intRecNum = CurrEduClsTeacherDA.DelCurrEduClsTeacher(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[CurrEduClsTeacher]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngIdEduClsTeacher">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngIdEduClsTeacher, string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCurrEduClsTeacherDA.GetSpecSQLObj();
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
//删除与表:[CurrEduClsTeacher]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCurrEduClsTeacherBL.DelRecord(lngIdEduClsTeacher, strIdCurrEduCls, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCurrEduClsTeacherBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngIdEduClsTeacher, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objCurrEduClsTeacherENS">源对象</param>
 /// <param name = "objCurrEduClsTeacherENT">目标对象</param>
 public static void CopyTo(clsCurrEduClsTeacherEN objCurrEduClsTeacherENS, clsCurrEduClsTeacherEN objCurrEduClsTeacherENT)
{
try
{
objCurrEduClsTeacherENT.IdEduClsTeacher = objCurrEduClsTeacherENS.IdEduClsTeacher; //教学班老师流水号
objCurrEduClsTeacherENT.IdCurrEduCls = objCurrEduClsTeacherENS.IdCurrEduCls; //教学班流水号
objCurrEduClsTeacherENT.IdTeacher = objCurrEduClsTeacherENS.IdTeacher; //教师流水号
objCurrEduClsTeacherENT.IdPk2EduClsTeacherType = objCurrEduClsTeacherENS.IdPk2EduClsTeacherType; //教学班老师角色(主讲,辅导)流水号
objCurrEduClsTeacherENT.SchoolTerm = objCurrEduClsTeacherENS.SchoolTerm; //学期
objCurrEduClsTeacherENT.SchoolYear = objCurrEduClsTeacherENS.SchoolYear; //学年
objCurrEduClsTeacherENT.OpenBeginDate = objCurrEduClsTeacherENS.OpenBeginDate; //开放开始日期
objCurrEduClsTeacherENT.OpenEndDate = objCurrEduClsTeacherENS.OpenEndDate; //开放结束日期
objCurrEduClsTeacherENT.OrderNum = objCurrEduClsTeacherENS.OrderNum; //序号
objCurrEduClsTeacherENT.UpdDate = objCurrEduClsTeacherENS.UpdDate; //修改日期
objCurrEduClsTeacherENT.LastVisitedDate = objCurrEduClsTeacherENS.LastVisitedDate; //修改日期
objCurrEduClsTeacherENT.UpdUser = objCurrEduClsTeacherENS.UpdUser; //修改人
objCurrEduClsTeacherENT.Memo = objCurrEduClsTeacherENS.Memo; //备注
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
 /// <param name = "objCurrEduClsTeacherEN">源简化对象</param>
 public static void SetUpdFlag(clsCurrEduClsTeacherEN objCurrEduClsTeacherEN)
{
try
{
objCurrEduClsTeacherEN.ClearUpdateState();
   string strsfUpdFldSetStr = objCurrEduClsTeacherEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conCurrEduClsTeacher.IdEduClsTeacher, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsTeacherEN.IdEduClsTeacher = objCurrEduClsTeacherEN.IdEduClsTeacher; //教学班老师流水号
}
if (arrFldSet.Contains(conCurrEduClsTeacher.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsTeacherEN.IdCurrEduCls = objCurrEduClsTeacherEN.IdCurrEduCls == "[null]" ? null :  objCurrEduClsTeacherEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conCurrEduClsTeacher.IdTeacher, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsTeacherEN.IdTeacher = objCurrEduClsTeacherEN.IdTeacher == "[null]" ? null :  objCurrEduClsTeacherEN.IdTeacher; //教师流水号
}
if (arrFldSet.Contains(conCurrEduClsTeacher.IdPk2EduClsTeacherType, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsTeacherEN.IdPk2EduClsTeacherType = objCurrEduClsTeacherEN.IdPk2EduClsTeacherType == "[null]" ? null :  objCurrEduClsTeacherEN.IdPk2EduClsTeacherType; //教学班老师角色(主讲,辅导)流水号
}
if (arrFldSet.Contains(conCurrEduClsTeacher.SchoolTerm, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsTeacherEN.SchoolTerm = objCurrEduClsTeacherEN.SchoolTerm == "[null]" ? null :  objCurrEduClsTeacherEN.SchoolTerm; //学期
}
if (arrFldSet.Contains(conCurrEduClsTeacher.SchoolYear, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsTeacherEN.SchoolYear = objCurrEduClsTeacherEN.SchoolYear == "[null]" ? null :  objCurrEduClsTeacherEN.SchoolYear; //学年
}
if (arrFldSet.Contains(conCurrEduClsTeacher.OpenBeginDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsTeacherEN.OpenBeginDate = objCurrEduClsTeacherEN.OpenBeginDate == "[null]" ? null :  objCurrEduClsTeacherEN.OpenBeginDate; //开放开始日期
}
if (arrFldSet.Contains(conCurrEduClsTeacher.OpenEndDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsTeacherEN.OpenEndDate = objCurrEduClsTeacherEN.OpenEndDate == "[null]" ? null :  objCurrEduClsTeacherEN.OpenEndDate; //开放结束日期
}
if (arrFldSet.Contains(conCurrEduClsTeacher.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsTeacherEN.OrderNum = objCurrEduClsTeacherEN.OrderNum; //序号
}
if (arrFldSet.Contains(conCurrEduClsTeacher.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsTeacherEN.UpdDate = objCurrEduClsTeacherEN.UpdDate == "[null]" ? null :  objCurrEduClsTeacherEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conCurrEduClsTeacher.LastVisitedDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsTeacherEN.LastVisitedDate = objCurrEduClsTeacherEN.LastVisitedDate; //修改日期
}
if (arrFldSet.Contains(conCurrEduClsTeacher.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsTeacherEN.UpdUser = objCurrEduClsTeacherEN.UpdUser == "[null]" ? null :  objCurrEduClsTeacherEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conCurrEduClsTeacher.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsTeacherEN.Memo = objCurrEduClsTeacherEN.Memo == "[null]" ? null :  objCurrEduClsTeacherEN.Memo; //备注
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
 /// <param name = "objCurrEduClsTeacherEN">源简化对象</param>
 public static void AccessFldValueNull(clsCurrEduClsTeacherEN objCurrEduClsTeacherEN)
{
try
{
if (objCurrEduClsTeacherEN.IdCurrEduCls == "[null]") objCurrEduClsTeacherEN.IdCurrEduCls = null; //教学班流水号
if (objCurrEduClsTeacherEN.IdTeacher == "[null]") objCurrEduClsTeacherEN.IdTeacher = null; //教师流水号
if (objCurrEduClsTeacherEN.IdPk2EduClsTeacherType == "[null]") objCurrEduClsTeacherEN.IdPk2EduClsTeacherType = null; //教学班老师角色(主讲,辅导)流水号
if (objCurrEduClsTeacherEN.SchoolTerm == "[null]") objCurrEduClsTeacherEN.SchoolTerm = null; //学期
if (objCurrEduClsTeacherEN.SchoolYear == "[null]") objCurrEduClsTeacherEN.SchoolYear = null; //学年
if (objCurrEduClsTeacherEN.OpenBeginDate == "[null]") objCurrEduClsTeacherEN.OpenBeginDate = null; //开放开始日期
if (objCurrEduClsTeacherEN.OpenEndDate == "[null]") objCurrEduClsTeacherEN.OpenEndDate = null; //开放结束日期
if (objCurrEduClsTeacherEN.UpdDate == "[null]") objCurrEduClsTeacherEN.UpdDate = null; //修改日期
if (objCurrEduClsTeacherEN.UpdUser == "[null]") objCurrEduClsTeacherEN.UpdUser = null; //修改人
if (objCurrEduClsTeacherEN.Memo == "[null]") objCurrEduClsTeacherEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsCurrEduClsTeacherEN objCurrEduClsTeacherEN)
{
 CurrEduClsTeacherDA.CheckPropertyNew(objCurrEduClsTeacherEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsCurrEduClsTeacherEN objCurrEduClsTeacherEN)
{
 CurrEduClsTeacherDA.CheckProperty4Condition(objCurrEduClsTeacherEN);
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
if (clsCurrEduClsTeacherBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCurrEduClsTeacherBL没有刷新缓存机制(clsCurrEduClsTeacherBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdEduClsTeacher");
//if (arrCurrEduClsTeacherObjLstCache == null)
//{
//arrCurrEduClsTeacherObjLstCache = CurrEduClsTeacherDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdEduClsTeacher">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCurrEduClsTeacherEN GetObjByIdEduClsTeacherCache(long lngIdEduClsTeacher, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsCurrEduClsTeacherEN._CurrTabName, strIdCurrEduCls);
List<clsCurrEduClsTeacherEN> arrCurrEduClsTeacherObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsCurrEduClsTeacherEN> arrCurrEduClsTeacherObjLst_Sel =
arrCurrEduClsTeacherObjLstCache
.Where(x=> x.IdEduClsTeacher == lngIdEduClsTeacher 
);
if (arrCurrEduClsTeacherObjLst_Sel.Count() == 0)
{
   clsCurrEduClsTeacherEN obj = clsCurrEduClsTeacherBL.GetObjByIdEduClsTeacher(lngIdEduClsTeacher);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngIdEduClsTeacher, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrCurrEduClsTeacherObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCurrEduClsTeacherEN> GetAllCurrEduClsTeacherObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsCurrEduClsTeacherEN> arrCurrEduClsTeacherObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrCurrEduClsTeacherObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCurrEduClsTeacherEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsCurrEduClsTeacherEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsCurrEduClsTeacherEN> arrCurrEduClsTeacherObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrCurrEduClsTeacherObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsCurrEduClsTeacherEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clsCurrEduClsTeacherEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsCurrEduClsTeacherEN._RefreshTimeLst.Count == 0) return "";
return clsCurrEduClsTeacherEN._RefreshTimeLst[clsCurrEduClsTeacherEN._RefreshTimeLst.Count - 1];
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
if (clsCurrEduClsTeacherBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsCurrEduClsTeacherEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clsCurrEduClsTeacherEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsCurrEduClsTeacherBL.objCommFun4BL.ReFreshCache(strIdCurrEduCls);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--CurrEduClsTeacher(当前教学班教师)
 /// 唯一性条件:id_CurrEduCls_id_Teacher
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCurrEduClsTeacherEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsCurrEduClsTeacherEN objCurrEduClsTeacherEN)
{
//检测记录是否存在
string strResult = CurrEduClsTeacherDA.GetUniCondStr(objCurrEduClsTeacherEN);
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
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngIdEduClsTeacher, string strIdCurrEduCls)
{
if (strInFldName != conCurrEduClsTeacher.IdEduClsTeacher)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conCurrEduClsTeacher.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conCurrEduClsTeacher.AttributeName));
throw new Exception(strMsg);
}
var objCurrEduClsTeacher = clsCurrEduClsTeacherBL.GetObjByIdEduClsTeacherCache(lngIdEduClsTeacher, strIdCurrEduCls);
if (objCurrEduClsTeacher == null) return "";
return objCurrEduClsTeacher[strOutFldName].ToString();
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
int intRecCount = clsCurrEduClsTeacherDA.GetRecCount(strTabName);
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
int intRecCount = clsCurrEduClsTeacherDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsCurrEduClsTeacherDA.GetRecCount();
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
int intRecCount = clsCurrEduClsTeacherDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objCurrEduClsTeacherCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsCurrEduClsTeacherEN objCurrEduClsTeacherCond)
{
 string strIdCurrEduCls = objCurrEduClsTeacherCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsCurrEduClsTeacherBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsCurrEduClsTeacherEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsCurrEduClsTeacherEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCurrEduClsTeacher.AttributeName)
{
if (objCurrEduClsTeacherCond.IsUpdated(strFldName) == false) continue;
if (objCurrEduClsTeacherCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCurrEduClsTeacherCond[strFldName].ToString());
}
else
{
if (objCurrEduClsTeacherCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCurrEduClsTeacherCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCurrEduClsTeacherCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCurrEduClsTeacherCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCurrEduClsTeacherCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCurrEduClsTeacherCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCurrEduClsTeacherCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCurrEduClsTeacherCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCurrEduClsTeacherCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCurrEduClsTeacherCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCurrEduClsTeacherCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCurrEduClsTeacherCond[strFldName]));
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
 List<string> arrList = clsCurrEduClsTeacherDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = CurrEduClsTeacherDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = CurrEduClsTeacherDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = CurrEduClsTeacherDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsCurrEduClsTeacherDA.SetFldValue(clsCurrEduClsTeacherEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = CurrEduClsTeacherDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsCurrEduClsTeacherDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsCurrEduClsTeacherDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsCurrEduClsTeacherDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[CurrEduClsTeacher] "); 
 strCreateTabCode.Append(" ( "); 
 // /**教学班老师流水号*/ 
 strCreateTabCode.Append(" IdEduClsTeacher bigint primary key identity, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) Null, "); 
 // /**教师流水号*/ 
 strCreateTabCode.Append(" IdTeacher char(8) Null, "); 
 // /**教学班老师角色(主讲,辅导)流水号*/ 
 strCreateTabCode.Append(" IdPk2EduClsTeacherType char(4) Null, "); 
 // /**学期*/ 
 strCreateTabCode.Append(" SchoolTerm char(1) Null, "); 
 // /**学年*/ 
 strCreateTabCode.Append(" SchoolYear varchar(10) Null, "); 
 // /**开放开始日期*/ 
 strCreateTabCode.Append(" OpenBeginDate varchar(8) Null, "); 
 // /**开放结束日期*/ 
 strCreateTabCode.Append(" OpenEndDate varchar(8) Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" LastVisitedDate varchar(20) not Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**学院名称*/ 
 strCreateTabCode.Append(" CollegeName varchar(100) Null, "); 
 // /**教师工号*/ 
 strCreateTabCode.Append(" TeacherId varchar(12) Null, "); 
 // /**课程Id*/ 
 strCreateTabCode.Append(" CourseId char(8) Null, "); 
 // /**教师姓名*/ 
 strCreateTabCode.Append(" TeacherName varchar(50) Null, "); 
 // /**教学班名*/ 
 strCreateTabCode.Append(" EduClsName varchar(100) Null, "); 
 // /**课程名称*/ 
 strCreateTabCode.Append(" CourseName varchar(100) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 排序相关函数

/// <summary>
/// 重新排序。根据分类字段：IdTeacher单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ReOrder)
/// </summary>
/// <param name="strIdTeacher">分类字段</param>
/// <returns></returns>
public static bool ReOrder(string strIdTeacher)
{
try
{
string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conCurrEduClsTeacher.IdTeacher, strIdTeacher);
 strCondition += string.Format(" order by OrderNum ");
List<clsCurrEduClsTeacherEN> arrCurrEduClsTeacherObjList = new clsCurrEduClsTeacherDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsCurrEduClsTeacherEN objCurrEduClsTeacher in arrCurrEduClsTeacherObjList)
{
objCurrEduClsTeacher.OrderNum = intIndex;
UpdateBySql2(objCurrEduClsTeacher);
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
/// 调整所给关键字记录的序号。根据分类字段：IdTeacher单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_AdjustOrderNum)
/// </summary>
/// <param name="strDirect">方向：用"Up","Down"表示</param>
/// <param name="lngIdEduClsTeacher">所给的关键字</param>
/// <param name="strIdTeacher">分类字段</param>
/// <returns>是否成功?</returns>
public static bool AdjustOrderNum(string strDirect, long lngIdEduClsTeacher ,string strIdTeacher)
{
try
{
//操作步骤：
//1、根据所给定的关键字[IdEduClsTeacher],获取相应的序号[OrderNum]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//   3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字IdEduClsTeacher
//5、把当前关键字IdEduClsTeacher所对应记录的序号加(减)1
//6、把下(上)一个序号关键字IdEduClsTeacher所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
long lngPrevIdEduClsTeacher = 0;    //上一条序号的关键字IdEduClsTeacher
long lngNextIdEduClsTeacher = 0;    //下一条序号的关键字IdEduClsTeacher
int intTabRecNum;       //当前表中字段的记录数
StringBuilder sbCondition = new StringBuilder();
//1、根据所给定的关键字[IdEduClsTeacher],获取相应的序号[OrderNum]。

clsCurrEduClsTeacherEN objCurrEduClsTeacher = clsCurrEduClsTeacherBL.GetObjByIdEduClsTeacher(lngIdEduClsTeacher);

intOrderNum = objCurrEduClsTeacher.OrderNum ?? 0;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conCurrEduClsTeacher.IdTeacher, strIdTeacher);
intTabRecNum = clsCurrEduClsTeacherBL.GetRecCountByCond(clsCurrEduClsTeacherEN._CurrTabName, strCondition);    //获取当前表的记录数
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
sbCondition.AppendFormat(" {0} = {1} ", conCurrEduClsTeacher.OrderNum, intOrderNum - 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conCurrEduClsTeacher.IdTeacher, strIdTeacher);
//4、获取上一个序号字段的关键字IdEduClsTeacher
lngPrevIdEduClsTeacher = clsCurrEduClsTeacherBL.GetFirstID_S(sbCondition.ToString());
if (lngPrevIdEduClsTeacher == 0)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字IdEduClsTeacher所对应记录的序号减1
//6、把下(上)一个序号关键字IdEduClsTeacher所对应的记录序号加1
clsCurrEduClsTeacherBL.SetFldValue(clsCurrEduClsTeacherEN._CurrTabName, conCurrEduClsTeacher.OrderNum,
 	 	intOrderNum - 1,
  	 	string.Format("{0} = '{1}'", conCurrEduClsTeacher.IdEduClsTeacher, lngIdEduClsTeacher));
clsCurrEduClsTeacherBL.SetFldValue(clsCurrEduClsTeacherEN._CurrTabName, conCurrEduClsTeacher.OrderNum,
 	 	intPrevOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conCurrEduClsTeacher.IdEduClsTeacher, lngPrevIdEduClsTeacher));
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

//4、获取下一个序号字段的关键字IdEduClsTeacher
sbCondition.AppendFormat(" {0} = {1} ", conCurrEduClsTeacher.OrderNum, intOrderNum + 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conCurrEduClsTeacher.IdTeacher, strIdTeacher);

lngNextIdEduClsTeacher = clsCurrEduClsTeacherBL.GetFirstID_S(sbCondition.ToString());
if (lngNextIdEduClsTeacher == 0)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字IdEduClsTeacher所对应记录的序号加1
//6、把下(上)一个序号关键字IdEduClsTeacher所对应的记录序号减1
clsCurrEduClsTeacherBL.SetFldValue(clsCurrEduClsTeacherEN._CurrTabName, conCurrEduClsTeacher.OrderNum,
 	 	intOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conCurrEduClsTeacher.IdEduClsTeacher, lngIdEduClsTeacher));
clsCurrEduClsTeacherBL.SetFldValue(clsCurrEduClsTeacherEN._CurrTabName, conCurrEduClsTeacher.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conCurrEduClsTeacher.IdEduClsTeacher, lngNextIdEduClsTeacher));
break;
default:
strMsg = string.Format("方向参数出错!strDirect=[{0}]({1})",
 	 	strDirect,
 	 	clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
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
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：IdTeacher单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoBottom)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoBottom(List<long> arrKeyId ,string strIdTeacher)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId);
string strCondition = string.Format("{0} in ({1})", conCurrEduClsTeacher.IdEduClsTeacher, strKeyList);
List<clsCurrEduClsTeacherEN> arrCurrEduClsTeacherLst = GetObjLst(strCondition);
foreach (clsCurrEduClsTeacherEN objCurrEduClsTeacher in arrCurrEduClsTeacherLst)
{
objCurrEduClsTeacher.OrderNum = objCurrEduClsTeacher.OrderNum + 10000;
UpdateBySql2(objCurrEduClsTeacher);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conCurrEduClsTeacher.IdTeacher, strIdTeacher);
 strCondition += string.Format(" order by OrderNum ");
List<clsCurrEduClsTeacherEN> arrCurrEduClsTeacherObjList = new clsCurrEduClsTeacherDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsCurrEduClsTeacherEN objCurrEduClsTeacher in arrCurrEduClsTeacherObjList)
{
objCurrEduClsTeacher.OrderNum = intIndex;
UpdateBySql2(objCurrEduClsTeacher);
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
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：IdTeacher单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoTop)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <param name="strIdTeacher">分类字段</param>
/// <returns></returns>
public static bool GoTop(List<long> arrKeyId ,string strIdTeacher)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId);
string strCondition = string.Format("{0} in ({1})", conCurrEduClsTeacher.IdEduClsTeacher, strKeyList);
List<clsCurrEduClsTeacherEN> arrCurrEduClsTeacherLst = GetObjLst(strCondition);
foreach (clsCurrEduClsTeacherEN objCurrEduClsTeacher in arrCurrEduClsTeacherLst)
{
objCurrEduClsTeacher.OrderNum = objCurrEduClsTeacher.OrderNum - 10000;
UpdateBySql2(objCurrEduClsTeacher);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conCurrEduClsTeacher.IdTeacher, strIdTeacher);
 strCondition += string.Format(" order by OrderNum ");
List<clsCurrEduClsTeacherEN> arrCurrEduClsTeacherObjList = new clsCurrEduClsTeacherDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsCurrEduClsTeacherEN objCurrEduClsTeacher in arrCurrEduClsTeacherObjList)
{
objCurrEduClsTeacher.OrderNum = intIndex;
UpdateBySql2(objCurrEduClsTeacher);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错,{0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}


 #endregion 排序相关函数
}
 /// <summary>
 /// 当前教学班教师(CurrEduClsTeacher)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4CurrEduClsTeacher : clsCommFun4BLV2
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
clsCurrEduClsTeacherBL.ReFreshThisCache(strIdCurrEduCls);
}
}

}