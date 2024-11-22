
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCurrEduCls4SynchBL
 表名:CurrEduCls4Synch(01120358)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:06:54
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:数据同步(DataSynch)
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
public static class  clsCurrEduCls4SynchBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCurrEduCls4SynchEN GetObj(this K_mId_CurrEduCls4Synch myKey)
{
clsCurrEduCls4SynchEN objCurrEduCls4SynchEN = clsCurrEduCls4SynchBL.CurrEduCls4SynchDA.GetObjBymId(myKey.Value);
return objCurrEduCls4SynchEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCurrEduCls4SynchEN) == false)
{
var strMsg = string.Format("记录已经存在!教学班流水号 = [{0}],Ip地址 = [{1}]的数据已经存在!(in clsCurrEduCls4SynchBL.AddNewRecord)", objCurrEduCls4SynchEN.IdCurrEduCls,objCurrEduCls4SynchEN.IpAddress);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsCurrEduCls4SynchBL.CurrEduCls4SynchDA.AddNewRecordBySQL2(objCurrEduCls4SynchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduCls4SynchBL.ReFreshCache();

if (clsCurrEduCls4SynchBL.relatedActions != null)
{
clsCurrEduCls4SynchBL.relatedActions.UpdRelaTabDate(objCurrEduCls4SynchEN.mId, "SetUpdDate");
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
public static bool AddRecordEx(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, bool bolIsNeedCheckUniqueness = true)
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
objCurrEduCls4SynchEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objCurrEduCls4SynchEN.CheckUniqueness() == false)
{
strMsg = string.Format("(教学班流水号(IdCurrEduCls)=[{0}],Ip地址(IpAddress)=[{1}])已经存在,不能重复!", objCurrEduCls4SynchEN.IdCurrEduCls, objCurrEduCls4SynchEN.IpAddress);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objCurrEduCls4SynchEN.AddNewRecord();
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
 /// <param name = "objCurrEduCls4SynchEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCurrEduCls4SynchEN) == false)
{
var strMsg = string.Format("记录已经存在!教学班流水号 = [{0}],Ip地址 = [{1}]的数据已经存在!(in clsCurrEduCls4SynchBL.AddNewRecordWithReturnKey)", objCurrEduCls4SynchEN.IdCurrEduCls,objCurrEduCls4SynchEN.IpAddress);
throw new Exception(strMsg);
}
try
{
string strKey = clsCurrEduCls4SynchBL.CurrEduCls4SynchDA.AddNewRecordBySQL2WithReturnKey(objCurrEduCls4SynchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduCls4SynchBL.ReFreshCache();

if (clsCurrEduCls4SynchBL.relatedActions != null)
{
clsCurrEduCls4SynchBL.relatedActions.UpdRelaTabDate(objCurrEduCls4SynchEN.mId, "SetUpdDate");
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
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetmId(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, long lngmId, string strComparisonOp="")
	{
objCurrEduCls4SynchEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.mId) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.mId, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.mId] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetIpAddress(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strIpAddress, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIpAddress, 50, conCurrEduCls4Synch.IpAddress);
}
objCurrEduCls4SynchEN.IpAddress = strIpAddress; //Ip地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.IpAddress) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.IpAddress, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.IpAddress] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetIdCurrEduCls(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strIdCurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdCurrEduCls, conCurrEduCls4Synch.IdCurrEduCls);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conCurrEduCls4Synch.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conCurrEduCls4Synch.IdCurrEduCls);
}
objCurrEduCls4SynchEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.IdCurrEduCls) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.IdCurrEduCls, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.IdCurrEduCls] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetCurrEduClsId(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strCurrEduClsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCurrEduClsId, conCurrEduCls4Synch.CurrEduClsId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCurrEduClsId, 15, conCurrEduCls4Synch.CurrEduClsId);
}
objCurrEduCls4SynchEN.CurrEduClsId = strCurrEduClsId; //教学班Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.CurrEduClsId) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.CurrEduClsId, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.CurrEduClsId] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetEduClsName(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strEduClsName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduClsName, 100, conCurrEduCls4Synch.EduClsName);
}
objCurrEduCls4SynchEN.EduClsName = strEduClsName; //教学班名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.EduClsName) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.EduClsName, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.EduClsName] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetEduClsTypeId(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strEduClsTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduClsTypeId, 4, conCurrEduCls4Synch.EduClsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strEduClsTypeId, 4, conCurrEduCls4Synch.EduClsTypeId);
}
objCurrEduCls4SynchEN.EduClsTypeId = strEduClsTypeId; //教学班类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.EduClsTypeId) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.EduClsTypeId, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.EduClsTypeId] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetCourseId(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, conCurrEduCls4Synch.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, conCurrEduCls4Synch.CourseId);
}
objCurrEduCls4SynchEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.CourseId) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.CourseId, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.CourseId] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetTeachingSolutionId(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strTeachingSolutionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingSolutionId, 8, conCurrEduCls4Synch.TeachingSolutionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachingSolutionId, 8, conCurrEduCls4Synch.TeachingSolutionId);
}
objCurrEduCls4SynchEN.TeachingSolutionId = strTeachingSolutionId; //教学方案Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.TeachingSolutionId) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.TeachingSolutionId, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.TeachingSolutionId] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetIdXzCollege(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, conCurrEduCls4Synch.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, conCurrEduCls4Synch.IdXzCollege);
}
objCurrEduCls4SynchEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.IdXzCollege) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.IdXzCollege, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.IdXzCollege] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetIdEduWay(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strIdEduWay, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdEduWay, 4, conCurrEduCls4Synch.IdEduWay);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdEduWay, 4, conCurrEduCls4Synch.IdEduWay);
}
objCurrEduCls4SynchEN.IdEduWay = strIdEduWay; //教学方式流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.IdEduWay) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.IdEduWay, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.IdEduWay] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetIdClassRoomType(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strIdClassRoomType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdClassRoomType, 4, conCurrEduCls4Synch.IdClassRoomType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdClassRoomType, 4, conCurrEduCls4Synch.IdClassRoomType);
}
objCurrEduCls4SynchEN.IdClassRoomType = strIdClassRoomType; //教室类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.IdClassRoomType) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.IdClassRoomType, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.IdClassRoomType] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetTotalLessonQty(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, int? intTotalLessonQty, string strComparisonOp="")
	{
objCurrEduCls4SynchEN.TotalLessonQty = intTotalLessonQty; //总课时数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.TotalLessonQty) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.TotalLessonQty, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.TotalLessonQty] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetMaxStuQty(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, int? intMaxStuQty, string strComparisonOp="")
	{
objCurrEduCls4SynchEN.MaxStuQty = intMaxStuQty; //最大学生数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.MaxStuQty) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.MaxStuQty, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.MaxStuQty] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetCurrentStuQty(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, int? intCurrentStuQty, string strComparisonOp="")
	{
objCurrEduCls4SynchEN.CurrentStuQty = intCurrentStuQty; //当前学生数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.CurrentStuQty) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.CurrentStuQty, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.CurrentStuQty] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetWeekQty(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, int? intWeekQty, string strComparisonOp="")
	{
objCurrEduCls4SynchEN.WeekQty = intWeekQty; //总周数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.WeekQty) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.WeekQty, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.WeekQty] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetScheUnitPW(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, short? shtScheUnitPW, string strComparisonOp="")
	{
objCurrEduCls4SynchEN.ScheUnitPW = shtScheUnitPW; //周排课次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.ScheUnitPW) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.ScheUnitPW, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.ScheUnitPW] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetWeekStatusId(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strWeekStatusId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWeekStatusId, 2, conCurrEduCls4Synch.WeekStatusId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strWeekStatusId, 2, conCurrEduCls4Synch.WeekStatusId);
}
objCurrEduCls4SynchEN.WeekStatusId = strWeekStatusId; //周状态编号(单,双,全周)
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.WeekStatusId) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.WeekStatusId, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.WeekStatusId] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetCustomerWeek(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strCustomerWeek, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCustomerWeek, 50, conCurrEduCls4Synch.CustomerWeek);
}
objCurrEduCls4SynchEN.CustomerWeek = strCustomerWeek; //自定义上课周
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.CustomerWeek) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.CustomerWeek, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.CustomerWeek] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetIsCompleteScore(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, bool bolIsCompleteScore, string strComparisonOp="")
	{
objCurrEduCls4SynchEN.IsCompleteScore = bolIsCompleteScore; //是否成绩齐全
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.IsCompleteScore) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.IsCompleteScore, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.IsCompleteScore] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetIdExecPlan(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strIdExecPlan, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdExecPlan, 8, conCurrEduCls4Synch.IdExecPlan);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdExecPlan, 8, conCurrEduCls4Synch.IdExecPlan);
}
objCurrEduCls4SynchEN.IdExecPlan = strIdExecPlan; //执行计划流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.IdExecPlan) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.IdExecPlan, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.IdExecPlan] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetLessonQtyPerWeek(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, short? shtLessonQtyPerWeek, string strComparisonOp="")
	{
objCurrEduCls4SynchEN.LessonQtyPerWeek = shtLessonQtyPerWeek; //周课时数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.LessonQtyPerWeek) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.LessonQtyPerWeek, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.LessonQtyPerWeek] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetMark(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, double? dblMark, string strComparisonOp="")
	{
objCurrEduCls4SynchEN.Mark = dblMark; //获得学分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.Mark) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.Mark, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.Mark] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetCheckClassRoom(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strCheckClassRoom, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCheckClassRoom, 2000, conCurrEduCls4Synch.CheckClassRoom);
}
objCurrEduCls4SynchEN.CheckClassRoom = strCheckClassRoom; //检查教室结果
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.CheckClassRoom) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.CheckClassRoom, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.CheckClassRoom] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetCheckAdminCls(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strCheckAdminCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCheckAdminCls, 2000, conCurrEduCls4Synch.CheckAdminCls);
}
objCurrEduCls4SynchEN.CheckAdminCls = strCheckAdminCls; //检查行政班结果
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.CheckAdminCls) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.CheckAdminCls, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.CheckAdminCls] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetCheckTeacher(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strCheckTeacher, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCheckTeacher, 2000, conCurrEduCls4Synch.CheckTeacher);
}
objCurrEduCls4SynchEN.CheckTeacher = strCheckTeacher; //检查教师结果
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.CheckTeacher) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.CheckTeacher, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.CheckTeacher] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetEditLocked(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, bool bolEditLocked, string strComparisonOp="")
	{
objCurrEduCls4SynchEN.EditLocked = bolEditLocked; //编辑锁定
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.EditLocked) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.EditLocked, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.EditLocked] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetSched(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, bool bolSched, string strComparisonOp="")
	{
objCurrEduCls4SynchEN.Sched = bolSched; //是否排课
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.Sched) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.Sched, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.Sched] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetIdUniZone(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strIdUniZone, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdUniZone, 4, conCurrEduCls4Synch.IdUniZone);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdUniZone, 4, conCurrEduCls4Synch.IdUniZone);
}
objCurrEduCls4SynchEN.IdUniZone = strIdUniZone; //校区流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.IdUniZone) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.IdUniZone, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.IdUniZone] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetLocked(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, bool bolLocked, string strComparisonOp="")
	{
objCurrEduCls4SynchEN.Locked = bolLocked; //锁定状态
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.Locked) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.Locked, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.Locked] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetIdGradeBase(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strIdGradeBase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdGradeBase, 4, conCurrEduCls4Synch.IdGradeBase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdGradeBase, 4, conCurrEduCls4Synch.IdGradeBase);
}
objCurrEduCls4SynchEN.IdGradeBase = strIdGradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.IdGradeBase) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.IdGradeBase, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.IdGradeBase] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetIsEffective(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, bool bolIsEffective, string strComparisonOp="")
	{
objCurrEduCls4SynchEN.IsEffective = bolIsEffective; //是否有效
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.IsEffective) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.IsEffective, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.IsEffective] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetIsUnDeterminedClsRm(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, bool bolIsUnDeterminedClsRm, string strComparisonOp="")
	{
objCurrEduCls4SynchEN.IsUnDeterminedClsRm = bolIsUnDeterminedClsRm; //是否待定教室
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.IsUnDeterminedClsRm) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.IsUnDeterminedClsRm, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.IsUnDeterminedClsRm] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetSchoolYear(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strSchoolYear, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, conCurrEduCls4Synch.SchoolYear);
}
objCurrEduCls4SynchEN.SchoolYear = strSchoolYear; //学年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.SchoolYear) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.SchoolYear, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.SchoolYear] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetSchoolTerm(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strSchoolTerm, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, conCurrEduCls4Synch.SchoolTerm);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, conCurrEduCls4Synch.SchoolTerm);
}
objCurrEduCls4SynchEN.SchoolTerm = strSchoolTerm; //学期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.SchoolTerm) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.SchoolTerm, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.SchoolTerm] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetArrangeCourseMemo(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strArrangeCourseMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strArrangeCourseMemo, 50, conCurrEduCls4Synch.ArrangeCourseMemo);
}
objCurrEduCls4SynchEN.ArrangeCourseMemo = strArrangeCourseMemo; //排课备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.ArrangeCourseMemo) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.ArrangeCourseMemo, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.ArrangeCourseMemo] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetIdCourseType(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strIdCourseType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCourseType, 4, conCurrEduCls4Synch.IdCourseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCourseType, 4, conCurrEduCls4Synch.IdCourseType);
}
objCurrEduCls4SynchEN.IdCourseType = strIdCourseType; //课程类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.IdCourseType) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.IdCourseType, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.IdCourseType] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetExportDate(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strExportDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExportDate, 8, conCurrEduCls4Synch.ExportDate);
}
objCurrEduCls4SynchEN.ExportDate = strExportDate; //导出日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.ExportDate) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.ExportDate, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.ExportDate] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetIsDegree(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, bool bolIsDegree, string strComparisonOp="")
	{
objCurrEduCls4SynchEN.IsDegree = bolIsDegree; //是否学位课
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.IsDegree) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.IsDegree, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.IsDegree] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetIdScoreType(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strIdScoreType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdScoreType, 4, conCurrEduCls4Synch.IdScoreType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdScoreType, 4, conCurrEduCls4Synch.IdScoreType);
}
objCurrEduCls4SynchEN.IdScoreType = strIdScoreType; //成绩类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.IdScoreType) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.IdScoreType, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.IdScoreType] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetGetScoreWayId(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strGetScoreWayId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGetScoreWayId, 2, conCurrEduCls4Synch.GetScoreWayId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGetScoreWayId, 2, conCurrEduCls4Synch.GetScoreWayId);
}
objCurrEduCls4SynchEN.GetScoreWayId = strGetScoreWayId; //获得成绩方式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.GetScoreWayId) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.GetScoreWayId, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.GetScoreWayId] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetIsProportionalCtrl(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, bool bolIsProportionalCtrl, string strComparisonOp="")
	{
objCurrEduCls4SynchEN.IsProportionalCtrl = bolIsProportionalCtrl; //是否比例控制
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.IsProportionalCtrl) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.IsProportionalCtrl, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.IsProportionalCtrl] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetIsSynchToWeb(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, bool bolIsSynchToWeb, string strComparisonOp="")
	{
objCurrEduCls4SynchEN.IsSynchToWeb = bolIsSynchToWeb; //是否同步Web
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.IsSynchToWeb) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.IsSynchToWeb, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.IsSynchToWeb] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetSynchToWebDate(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strSynchToWebDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSynchToWebDate, 20, conCurrEduCls4Synch.SynchToWebDate);
}
objCurrEduCls4SynchEN.SynchToWebDate = strSynchToWebDate; //同步Web日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.SynchToWebDate) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.SynchToWebDate, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.SynchToWebDate] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetSynchToWebUser(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strSynchToWebUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSynchToWebUser, 18, conCurrEduCls4Synch.SynchToWebUser);
}
objCurrEduCls4SynchEN.SynchToWebUser = strSynchToWebUser; //同步Web用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.SynchToWebUser) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.SynchToWebUser, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.SynchToWebUser] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetSignInDate(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strSignInDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSignInDate, 20, conCurrEduCls4Synch.SignInDate);
}
objCurrEduCls4SynchEN.SignInDate = strSignInDate; //签入时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.SignInDate) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.SignInDate, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.SignInDate] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetSignInStateID(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strSignInStateID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSignInStateID, 2, conCurrEduCls4Synch.SignInStateID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSignInStateID, 2, conCurrEduCls4Synch.SignInStateID);
}
objCurrEduCls4SynchEN.SignInStateID = strSignInStateID; //签入状态表流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.SignInStateID) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.SignInStateID, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.SignInStateID] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetSignInUser(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strSignInUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSignInUser, 18, conCurrEduCls4Synch.SignInUser);
}
objCurrEduCls4SynchEN.SignInUser = strSignInUser; //签入人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.SignInUser) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.SignInUser, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.SignInUser] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetIdExamType(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strIdExamType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdExamType, 4, conCurrEduCls4Synch.IdExamType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdExamType, 4, conCurrEduCls4Synch.IdExamType);
}
objCurrEduCls4SynchEN.IdExamType = strIdExamType; //考试方式流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.IdExamType) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.IdExamType, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.IdExamType] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetExamPortion(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, short? shtExamPortion, string strComparisonOp="")
	{
objCurrEduCls4SynchEN.ExamPortion = shtExamPortion; //平时成绩所占比例
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.ExamPortion) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.ExamPortion, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.ExamPortion] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetMidExamScorePortion(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, short? shtMidExamScorePortion, string strComparisonOp="")
	{
objCurrEduCls4SynchEN.MidExamScorePortion = shtMidExamScorePortion; //期末成绩所占比例
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.MidExamScorePortion) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.MidExamScorePortion, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.MidExamScorePortion] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetIsClearScore(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, bool bolIsClearScore, string strComparisonOp="")
	{
objCurrEduCls4SynchEN.IsClearScore = bolIsClearScore; //是否重录成绩
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.IsClearScore) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.IsClearScore, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.IsClearScore] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetIsGeneratePwd(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, bool bolIsGeneratePwd, string strComparisonOp="")
	{
objCurrEduCls4SynchEN.IsGeneratePwd = bolIsGeneratePwd; //是否生成口令
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.IsGeneratePwd) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.IsGeneratePwd, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.IsGeneratePwd] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetGeneratePwdDate(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strGeneratePwdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGeneratePwdDate, 20, conCurrEduCls4Synch.GeneratePwdDate);
}
objCurrEduCls4SynchEN.GeneratePwdDate = strGeneratePwdDate; //生成口令时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.GeneratePwdDate) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.GeneratePwdDate, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.GeneratePwdDate] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetIsExportToGP(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, bool bolIsExportToGP, string strComparisonOp="")
	{
objCurrEduCls4SynchEN.IsExportToGP = bolIsExportToGP; //是否导出到平台
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.IsExportToGP) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.IsExportToGP, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.IsExportToGP] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetIsExportToGPWeb(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, bool bolIsExportToGPWeb, string strComparisonOp="")
	{
objCurrEduCls4SynchEN.IsExportToGPWeb = bolIsExportToGPWeb; //是否导出到Web平台
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.IsExportToGPWeb) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.IsExportToGPWeb, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.IsExportToGPWeb] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetIsReservedDecimal(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, bool bolIsReservedDecimal, string strComparisonOp="")
	{
objCurrEduCls4SynchEN.IsReservedDecimal = bolIsReservedDecimal; //是否保留小数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.IsReservedDecimal) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.IsReservedDecimal, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.IsReservedDecimal] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetExamTime(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strExamTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExamTime, 8, conCurrEduCls4Synch.ExamTime);
}
objCurrEduCls4SynchEN.ExamTime = strExamTime; //考试时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.ExamTime) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.ExamTime, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.ExamTime] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetCheckState(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, bool bolCheckState, string strComparisonOp="")
	{
objCurrEduCls4SynchEN.CheckState = bolCheckState; //检查状态
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.CheckState) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.CheckState, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.CheckState] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetCheckDate(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strCheckDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCheckDate, 20, conCurrEduCls4Synch.CheckDate);
}
objCurrEduCls4SynchEN.CheckDate = strCheckDate; //检查日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.CheckDate) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.CheckDate, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.CheckDate] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetIdEduClassInPk(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strIdEduClassInPk, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdEduClassInPk, 8, conCurrEduCls4Synch.IdEduClassInPk);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdEduClassInPk, 8, conCurrEduCls4Synch.IdEduClassInPk);
}
objCurrEduCls4SynchEN.IdEduClassInPk = strIdEduClassInPk; //id_EduClassInPk
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.IdEduClassInPk) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.IdEduClassInPk, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.IdEduClassInPk] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetPkWeekTime(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strPkWeekTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPkWeekTime, 2000, conCurrEduCls4Synch.PkWeekTime);
}
objCurrEduCls4SynchEN.PkWeekTime = strPkWeekTime; //排课时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.PkWeekTime) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.PkWeekTime, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.PkWeekTime] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetPkClassRooms(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strPkClassRooms, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPkClassRooms, 150, conCurrEduCls4Synch.PkClassRooms);
}
objCurrEduCls4SynchEN.PkClassRooms = strPkClassRooms; //排课教室
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.PkClassRooms) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.PkClassRooms, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.PkClassRooms] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetBeginWeek(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, short? shtBeginWeek, string strComparisonOp="")
	{
objCurrEduCls4SynchEN.BeginWeek = shtBeginWeek; //开始周
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.BeginWeek) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.BeginWeek, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.BeginWeek] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetTeacherNames(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strTeacherNames, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeacherNames, 100, conCurrEduCls4Synch.TeacherNames);
}
objCurrEduCls4SynchEN.TeacherNames = strTeacherNames; //教师姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.TeacherNames) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.TeacherNames, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.TeacherNames] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetIsAccessSynch(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, bool bolIsAccessSynch, string strComparisonOp="")
	{
objCurrEduCls4SynchEN.IsAccessSynch = bolIsAccessSynch; //是否处理同步
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.IsAccessSynch) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.IsAccessSynch, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.IsAccessSynch] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetAccessSynchDate(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strAccessSynchDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAccessSynchDate, 14, conCurrEduCls4Synch.AccessSynchDate);
}
objCurrEduCls4SynchEN.AccessSynchDate = strAccessSynchDate; //处理同步日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.AccessSynchDate) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.AccessSynchDate, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.AccessSynchDate] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetIsExistEduClsInCurr(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, bool bolIsExistEduClsInCurr, string strComparisonOp="")
	{
objCurrEduCls4SynchEN.IsExistEduClsInCurr = bolIsExistEduClsInCurr; //当前是否存在教学班
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.IsExistEduClsInCurr) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.IsExistEduClsInCurr, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.IsExistEduClsInCurr] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetModifyDate(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strModifyDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModifyDate, 20, conCurrEduCls4Synch.ModifyDate);
}
objCurrEduCls4SynchEN.ModifyDate = strModifyDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.ModifyDate) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.ModifyDate, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.ModifyDate] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetModifyUserId(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strModifyUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModifyUserId, 18, conCurrEduCls4Synch.ModifyUserId);
}
objCurrEduCls4SynchEN.ModifyUserId = strModifyUserId; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.ModifyUserId) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.ModifyUserId, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.ModifyUserId] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetMemo(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCurrEduCls4Synch.Memo);
}
objCurrEduCls4SynchEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.Memo) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.Memo, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.Memo] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objCurrEduCls4SynchEN.CheckPropertyNew();
clsCurrEduCls4SynchEN objCurrEduCls4SynchCond = new clsCurrEduCls4SynchEN();
string strCondition = objCurrEduCls4SynchCond
.SetmId(objCurrEduCls4SynchEN.mId, "<>")
.SetIdCurrEduCls(objCurrEduCls4SynchEN.IdCurrEduCls, "=")
.SetIpAddress(objCurrEduCls4SynchEN.IpAddress, "=")
.GetCombineCondition();
objCurrEduCls4SynchEN._IsCheckProperty = true;
bool bolIsExist = clsCurrEduCls4SynchBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(id_CurrEduCls_IpAddress)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objCurrEduCls4SynchEN.Update();
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
 /// <param name = "objCurrEduCls4Synch">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsCurrEduCls4SynchEN objCurrEduCls4Synch)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsCurrEduCls4SynchEN objCurrEduCls4SynchCond = new clsCurrEduCls4SynchEN();
string strCondition = objCurrEduCls4SynchCond
.SetIdCurrEduCls(objCurrEduCls4Synch.IdCurrEduCls, "=")
.SetIpAddress(objCurrEduCls4Synch.IpAddress, "=")
.GetCombineCondition();
objCurrEduCls4Synch._IsCheckProperty = true;
bool bolIsExist = clsCurrEduCls4SynchBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objCurrEduCls4Synch.mId = clsCurrEduCls4SynchBL.GetFirstID_S(strCondition);
objCurrEduCls4Synch.UpdateWithCondition(strCondition);
}
else
{
objCurrEduCls4Synch.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN)
{
 if (objCurrEduCls4SynchEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCurrEduCls4SynchBL.CurrEduCls4SynchDA.UpdateBySql2(objCurrEduCls4SynchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduCls4SynchBL.ReFreshCache();

if (clsCurrEduCls4SynchBL.relatedActions != null)
{
clsCurrEduCls4SynchBL.relatedActions.UpdRelaTabDate(objCurrEduCls4SynchEN.mId, "SetUpdDate");
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
 /// <param name = "objCurrEduCls4SynchEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objCurrEduCls4SynchEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCurrEduCls4SynchBL.CurrEduCls4SynchDA.UpdateBySql2(objCurrEduCls4SynchEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduCls4SynchBL.ReFreshCache();

if (clsCurrEduCls4SynchBL.relatedActions != null)
{
clsCurrEduCls4SynchBL.relatedActions.UpdRelaTabDate(objCurrEduCls4SynchEN.mId, "SetUpdDate");
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
 /// <param name = "objCurrEduCls4SynchEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strWhereCond)
{
try
{
bool bolResult = clsCurrEduCls4SynchBL.CurrEduCls4SynchDA.UpdateBySqlWithCondition(objCurrEduCls4SynchEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduCls4SynchBL.ReFreshCache();

if (clsCurrEduCls4SynchBL.relatedActions != null)
{
clsCurrEduCls4SynchBL.relatedActions.UpdRelaTabDate(objCurrEduCls4SynchEN.mId, "SetUpdDate");
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
 /// <param name = "objCurrEduCls4SynchEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsCurrEduCls4SynchBL.CurrEduCls4SynchDA.UpdateBySqlWithConditionTransaction(objCurrEduCls4SynchEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduCls4SynchBL.ReFreshCache();

if (clsCurrEduCls4SynchBL.relatedActions != null)
{
clsCurrEduCls4SynchBL.relatedActions.UpdRelaTabDate(objCurrEduCls4SynchEN.mId, "SetUpdDate");
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN)
{
try
{
int intRecNum = clsCurrEduCls4SynchBL.CurrEduCls4SynchDA.DelRecord(objCurrEduCls4SynchEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduCls4SynchBL.ReFreshCache();

if (clsCurrEduCls4SynchBL.relatedActions != null)
{
clsCurrEduCls4SynchBL.relatedActions.UpdRelaTabDate(objCurrEduCls4SynchEN.mId, "SetUpdDate");
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
 /// <param name = "objCurrEduCls4SynchENS">源对象</param>
 /// <param name = "objCurrEduCls4SynchENT">目标对象</param>
 public static void CopyTo(this clsCurrEduCls4SynchEN objCurrEduCls4SynchENS, clsCurrEduCls4SynchEN objCurrEduCls4SynchENT)
{
try
{
objCurrEduCls4SynchENT.mId = objCurrEduCls4SynchENS.mId; //mId
objCurrEduCls4SynchENT.IpAddress = objCurrEduCls4SynchENS.IpAddress; //Ip地址
objCurrEduCls4SynchENT.IdCurrEduCls = objCurrEduCls4SynchENS.IdCurrEduCls; //教学班流水号
objCurrEduCls4SynchENT.CurrEduClsId = objCurrEduCls4SynchENS.CurrEduClsId; //教学班Id
objCurrEduCls4SynchENT.EduClsName = objCurrEduCls4SynchENS.EduClsName; //教学班名
objCurrEduCls4SynchENT.EduClsTypeId = objCurrEduCls4SynchENS.EduClsTypeId; //教学班类型Id
objCurrEduCls4SynchENT.CourseId = objCurrEduCls4SynchENS.CourseId; //课程Id
objCurrEduCls4SynchENT.TeachingSolutionId = objCurrEduCls4SynchENS.TeachingSolutionId; //教学方案Id
objCurrEduCls4SynchENT.IdXzCollege = objCurrEduCls4SynchENS.IdXzCollege; //学院流水号
objCurrEduCls4SynchENT.IdEduWay = objCurrEduCls4SynchENS.IdEduWay; //教学方式流水号
objCurrEduCls4SynchENT.IdClassRoomType = objCurrEduCls4SynchENS.IdClassRoomType; //教室类型流水号
objCurrEduCls4SynchENT.TotalLessonQty = objCurrEduCls4SynchENS.TotalLessonQty; //总课时数
objCurrEduCls4SynchENT.MaxStuQty = objCurrEduCls4SynchENS.MaxStuQty; //最大学生数
objCurrEduCls4SynchENT.CurrentStuQty = objCurrEduCls4SynchENS.CurrentStuQty; //当前学生数
objCurrEduCls4SynchENT.WeekQty = objCurrEduCls4SynchENS.WeekQty; //总周数
objCurrEduCls4SynchENT.ScheUnitPW = objCurrEduCls4SynchENS.ScheUnitPW; //周排课次数
objCurrEduCls4SynchENT.WeekStatusId = objCurrEduCls4SynchENS.WeekStatusId; //周状态编号(单,双,全周)
objCurrEduCls4SynchENT.CustomerWeek = objCurrEduCls4SynchENS.CustomerWeek; //自定义上课周
objCurrEduCls4SynchENT.IsCompleteScore = objCurrEduCls4SynchENS.IsCompleteScore; //是否成绩齐全
objCurrEduCls4SynchENT.IdExecPlan = objCurrEduCls4SynchENS.IdExecPlan; //执行计划流水号
objCurrEduCls4SynchENT.LessonQtyPerWeek = objCurrEduCls4SynchENS.LessonQtyPerWeek; //周课时数
objCurrEduCls4SynchENT.Mark = objCurrEduCls4SynchENS.Mark; //获得学分
objCurrEduCls4SynchENT.CheckClassRoom = objCurrEduCls4SynchENS.CheckClassRoom; //检查教室结果
objCurrEduCls4SynchENT.CheckAdminCls = objCurrEduCls4SynchENS.CheckAdminCls; //检查行政班结果
objCurrEduCls4SynchENT.CheckTeacher = objCurrEduCls4SynchENS.CheckTeacher; //检查教师结果
objCurrEduCls4SynchENT.EditLocked = objCurrEduCls4SynchENS.EditLocked; //编辑锁定
objCurrEduCls4SynchENT.Sched = objCurrEduCls4SynchENS.Sched; //是否排课
objCurrEduCls4SynchENT.IdUniZone = objCurrEduCls4SynchENS.IdUniZone; //校区流水号
objCurrEduCls4SynchENT.Locked = objCurrEduCls4SynchENS.Locked; //锁定状态
objCurrEduCls4SynchENT.IdGradeBase = objCurrEduCls4SynchENS.IdGradeBase; //年级流水号
objCurrEduCls4SynchENT.IsEffective = objCurrEduCls4SynchENS.IsEffective; //是否有效
objCurrEduCls4SynchENT.IsUnDeterminedClsRm = objCurrEduCls4SynchENS.IsUnDeterminedClsRm; //是否待定教室
objCurrEduCls4SynchENT.SchoolYear = objCurrEduCls4SynchENS.SchoolYear; //学年
objCurrEduCls4SynchENT.SchoolTerm = objCurrEduCls4SynchENS.SchoolTerm; //学期
objCurrEduCls4SynchENT.ArrangeCourseMemo = objCurrEduCls4SynchENS.ArrangeCourseMemo; //排课备注
objCurrEduCls4SynchENT.IdCourseType = objCurrEduCls4SynchENS.IdCourseType; //课程类型流水号
objCurrEduCls4SynchENT.ExportDate = objCurrEduCls4SynchENS.ExportDate; //导出日期
objCurrEduCls4SynchENT.IsDegree = objCurrEduCls4SynchENS.IsDegree; //是否学位课
objCurrEduCls4SynchENT.IdScoreType = objCurrEduCls4SynchENS.IdScoreType; //成绩类型流水号
objCurrEduCls4SynchENT.GetScoreWayId = objCurrEduCls4SynchENS.GetScoreWayId; //获得成绩方式Id
objCurrEduCls4SynchENT.IsProportionalCtrl = objCurrEduCls4SynchENS.IsProportionalCtrl; //是否比例控制
objCurrEduCls4SynchENT.IsSynchToWeb = objCurrEduCls4SynchENS.IsSynchToWeb; //是否同步Web
objCurrEduCls4SynchENT.SynchToWebDate = objCurrEduCls4SynchENS.SynchToWebDate; //同步Web日期
objCurrEduCls4SynchENT.SynchToWebUser = objCurrEduCls4SynchENS.SynchToWebUser; //同步Web用户
objCurrEduCls4SynchENT.SignInDate = objCurrEduCls4SynchENS.SignInDate; //签入时间
objCurrEduCls4SynchENT.SignInStateID = objCurrEduCls4SynchENS.SignInStateID; //签入状态表流水号
objCurrEduCls4SynchENT.SignInUser = objCurrEduCls4SynchENS.SignInUser; //签入人
objCurrEduCls4SynchENT.IdExamType = objCurrEduCls4SynchENS.IdExamType; //考试方式流水号
objCurrEduCls4SynchENT.ExamPortion = objCurrEduCls4SynchENS.ExamPortion; //平时成绩所占比例
objCurrEduCls4SynchENT.MidExamScorePortion = objCurrEduCls4SynchENS.MidExamScorePortion; //期末成绩所占比例
objCurrEduCls4SynchENT.IsClearScore = objCurrEduCls4SynchENS.IsClearScore; //是否重录成绩
objCurrEduCls4SynchENT.IsGeneratePwd = objCurrEduCls4SynchENS.IsGeneratePwd; //是否生成口令
objCurrEduCls4SynchENT.GeneratePwdDate = objCurrEduCls4SynchENS.GeneratePwdDate; //生成口令时间
objCurrEduCls4SynchENT.IsExportToGP = objCurrEduCls4SynchENS.IsExportToGP; //是否导出到平台
objCurrEduCls4SynchENT.IsExportToGPWeb = objCurrEduCls4SynchENS.IsExportToGPWeb; //是否导出到Web平台
objCurrEduCls4SynchENT.IsReservedDecimal = objCurrEduCls4SynchENS.IsReservedDecimal; //是否保留小数
objCurrEduCls4SynchENT.ExamTime = objCurrEduCls4SynchENS.ExamTime; //考试时间
objCurrEduCls4SynchENT.CheckState = objCurrEduCls4SynchENS.CheckState; //检查状态
objCurrEduCls4SynchENT.CheckDate = objCurrEduCls4SynchENS.CheckDate; //检查日期
objCurrEduCls4SynchENT.IdEduClassInPk = objCurrEduCls4SynchENS.IdEduClassInPk; //id_EduClassInPk
objCurrEduCls4SynchENT.PkWeekTime = objCurrEduCls4SynchENS.PkWeekTime; //排课时间
objCurrEduCls4SynchENT.PkClassRooms = objCurrEduCls4SynchENS.PkClassRooms; //排课教室
objCurrEduCls4SynchENT.BeginWeek = objCurrEduCls4SynchENS.BeginWeek; //开始周
objCurrEduCls4SynchENT.TeacherNames = objCurrEduCls4SynchENS.TeacherNames; //教师姓名
objCurrEduCls4SynchENT.IsAccessSynch = objCurrEduCls4SynchENS.IsAccessSynch; //是否处理同步
objCurrEduCls4SynchENT.AccessSynchDate = objCurrEduCls4SynchENS.AccessSynchDate; //处理同步日期
objCurrEduCls4SynchENT.IsExistEduClsInCurr = objCurrEduCls4SynchENS.IsExistEduClsInCurr; //当前是否存在教学班
objCurrEduCls4SynchENT.ModifyDate = objCurrEduCls4SynchENS.ModifyDate; //修改日期
objCurrEduCls4SynchENT.ModifyUserId = objCurrEduCls4SynchENS.ModifyUserId; //修改人
objCurrEduCls4SynchENT.Memo = objCurrEduCls4SynchENS.Memo; //备注
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
 /// <param name = "objCurrEduCls4SynchENS">源对象</param>
 /// <returns>目标对象=>clsCurrEduCls4SynchEN:objCurrEduCls4SynchENT</returns>
 public static clsCurrEduCls4SynchEN CopyTo(this clsCurrEduCls4SynchEN objCurrEduCls4SynchENS)
{
try
{
 clsCurrEduCls4SynchEN objCurrEduCls4SynchENT = new clsCurrEduCls4SynchEN()
{
mId = objCurrEduCls4SynchENS.mId, //mId
IpAddress = objCurrEduCls4SynchENS.IpAddress, //Ip地址
IdCurrEduCls = objCurrEduCls4SynchENS.IdCurrEduCls, //教学班流水号
CurrEduClsId = objCurrEduCls4SynchENS.CurrEduClsId, //教学班Id
EduClsName = objCurrEduCls4SynchENS.EduClsName, //教学班名
EduClsTypeId = objCurrEduCls4SynchENS.EduClsTypeId, //教学班类型Id
CourseId = objCurrEduCls4SynchENS.CourseId, //课程Id
TeachingSolutionId = objCurrEduCls4SynchENS.TeachingSolutionId, //教学方案Id
IdXzCollege = objCurrEduCls4SynchENS.IdXzCollege, //学院流水号
IdEduWay = objCurrEduCls4SynchENS.IdEduWay, //教学方式流水号
IdClassRoomType = objCurrEduCls4SynchENS.IdClassRoomType, //教室类型流水号
TotalLessonQty = objCurrEduCls4SynchENS.TotalLessonQty, //总课时数
MaxStuQty = objCurrEduCls4SynchENS.MaxStuQty, //最大学生数
CurrentStuQty = objCurrEduCls4SynchENS.CurrentStuQty, //当前学生数
WeekQty = objCurrEduCls4SynchENS.WeekQty, //总周数
ScheUnitPW = objCurrEduCls4SynchENS.ScheUnitPW, //周排课次数
WeekStatusId = objCurrEduCls4SynchENS.WeekStatusId, //周状态编号(单,双,全周)
CustomerWeek = objCurrEduCls4SynchENS.CustomerWeek, //自定义上课周
IsCompleteScore = objCurrEduCls4SynchENS.IsCompleteScore, //是否成绩齐全
IdExecPlan = objCurrEduCls4SynchENS.IdExecPlan, //执行计划流水号
LessonQtyPerWeek = objCurrEduCls4SynchENS.LessonQtyPerWeek, //周课时数
Mark = objCurrEduCls4SynchENS.Mark, //获得学分
CheckClassRoom = objCurrEduCls4SynchENS.CheckClassRoom, //检查教室结果
CheckAdminCls = objCurrEduCls4SynchENS.CheckAdminCls, //检查行政班结果
CheckTeacher = objCurrEduCls4SynchENS.CheckTeacher, //检查教师结果
EditLocked = objCurrEduCls4SynchENS.EditLocked, //编辑锁定
Sched = objCurrEduCls4SynchENS.Sched, //是否排课
IdUniZone = objCurrEduCls4SynchENS.IdUniZone, //校区流水号
Locked = objCurrEduCls4SynchENS.Locked, //锁定状态
IdGradeBase = objCurrEduCls4SynchENS.IdGradeBase, //年级流水号
IsEffective = objCurrEduCls4SynchENS.IsEffective, //是否有效
IsUnDeterminedClsRm = objCurrEduCls4SynchENS.IsUnDeterminedClsRm, //是否待定教室
SchoolYear = objCurrEduCls4SynchENS.SchoolYear, //学年
SchoolTerm = objCurrEduCls4SynchENS.SchoolTerm, //学期
ArrangeCourseMemo = objCurrEduCls4SynchENS.ArrangeCourseMemo, //排课备注
IdCourseType = objCurrEduCls4SynchENS.IdCourseType, //课程类型流水号
ExportDate = objCurrEduCls4SynchENS.ExportDate, //导出日期
IsDegree = objCurrEduCls4SynchENS.IsDegree, //是否学位课
IdScoreType = objCurrEduCls4SynchENS.IdScoreType, //成绩类型流水号
GetScoreWayId = objCurrEduCls4SynchENS.GetScoreWayId, //获得成绩方式Id
IsProportionalCtrl = objCurrEduCls4SynchENS.IsProportionalCtrl, //是否比例控制
IsSynchToWeb = objCurrEduCls4SynchENS.IsSynchToWeb, //是否同步Web
SynchToWebDate = objCurrEduCls4SynchENS.SynchToWebDate, //同步Web日期
SynchToWebUser = objCurrEduCls4SynchENS.SynchToWebUser, //同步Web用户
SignInDate = objCurrEduCls4SynchENS.SignInDate, //签入时间
SignInStateID = objCurrEduCls4SynchENS.SignInStateID, //签入状态表流水号
SignInUser = objCurrEduCls4SynchENS.SignInUser, //签入人
IdExamType = objCurrEduCls4SynchENS.IdExamType, //考试方式流水号
ExamPortion = objCurrEduCls4SynchENS.ExamPortion, //平时成绩所占比例
MidExamScorePortion = objCurrEduCls4SynchENS.MidExamScorePortion, //期末成绩所占比例
IsClearScore = objCurrEduCls4SynchENS.IsClearScore, //是否重录成绩
IsGeneratePwd = objCurrEduCls4SynchENS.IsGeneratePwd, //是否生成口令
GeneratePwdDate = objCurrEduCls4SynchENS.GeneratePwdDate, //生成口令时间
IsExportToGP = objCurrEduCls4SynchENS.IsExportToGP, //是否导出到平台
IsExportToGPWeb = objCurrEduCls4SynchENS.IsExportToGPWeb, //是否导出到Web平台
IsReservedDecimal = objCurrEduCls4SynchENS.IsReservedDecimal, //是否保留小数
ExamTime = objCurrEduCls4SynchENS.ExamTime, //考试时间
CheckState = objCurrEduCls4SynchENS.CheckState, //检查状态
CheckDate = objCurrEduCls4SynchENS.CheckDate, //检查日期
IdEduClassInPk = objCurrEduCls4SynchENS.IdEduClassInPk, //id_EduClassInPk
PkWeekTime = objCurrEduCls4SynchENS.PkWeekTime, //排课时间
PkClassRooms = objCurrEduCls4SynchENS.PkClassRooms, //排课教室
BeginWeek = objCurrEduCls4SynchENS.BeginWeek, //开始周
TeacherNames = objCurrEduCls4SynchENS.TeacherNames, //教师姓名
IsAccessSynch = objCurrEduCls4SynchENS.IsAccessSynch, //是否处理同步
AccessSynchDate = objCurrEduCls4SynchENS.AccessSynchDate, //处理同步日期
IsExistEduClsInCurr = objCurrEduCls4SynchENS.IsExistEduClsInCurr, //当前是否存在教学班
ModifyDate = objCurrEduCls4SynchENS.ModifyDate, //修改日期
ModifyUserId = objCurrEduCls4SynchENS.ModifyUserId, //修改人
Memo = objCurrEduCls4SynchENS.Memo, //备注
};
 return objCurrEduCls4SynchENT;
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
public static void CheckPropertyNew(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN)
{
 clsCurrEduCls4SynchBL.CurrEduCls4SynchDA.CheckPropertyNew(objCurrEduCls4SynchEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN)
{
 clsCurrEduCls4SynchBL.CurrEduCls4SynchDA.CheckProperty4Condition(objCurrEduCls4SynchEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCurrEduCls4SynchEN objCurrEduCls4SynchCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.mId) == true)
{
string strComparisonOpmId = objCurrEduCls4SynchCond.dicFldComparisonOp[conCurrEduCls4Synch.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduCls4Synch.mId, objCurrEduCls4SynchCond.mId, strComparisonOpmId);
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.IpAddress) == true)
{
string strComparisonOpIpAddress = objCurrEduCls4SynchCond.dicFldComparisonOp[conCurrEduCls4Synch.IpAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.IpAddress, objCurrEduCls4SynchCond.IpAddress, strComparisonOpIpAddress);
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objCurrEduCls4SynchCond.dicFldComparisonOp[conCurrEduCls4Synch.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.IdCurrEduCls, objCurrEduCls4SynchCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.CurrEduClsId) == true)
{
string strComparisonOpCurrEduClsId = objCurrEduCls4SynchCond.dicFldComparisonOp[conCurrEduCls4Synch.CurrEduClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.CurrEduClsId, objCurrEduCls4SynchCond.CurrEduClsId, strComparisonOpCurrEduClsId);
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.EduClsName) == true)
{
string strComparisonOpEduClsName = objCurrEduCls4SynchCond.dicFldComparisonOp[conCurrEduCls4Synch.EduClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.EduClsName, objCurrEduCls4SynchCond.EduClsName, strComparisonOpEduClsName);
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.EduClsTypeId) == true)
{
string strComparisonOpEduClsTypeId = objCurrEduCls4SynchCond.dicFldComparisonOp[conCurrEduCls4Synch.EduClsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.EduClsTypeId, objCurrEduCls4SynchCond.EduClsTypeId, strComparisonOpEduClsTypeId);
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.CourseId) == true)
{
string strComparisonOpCourseId = objCurrEduCls4SynchCond.dicFldComparisonOp[conCurrEduCls4Synch.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.CourseId, objCurrEduCls4SynchCond.CourseId, strComparisonOpCourseId);
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.TeachingSolutionId) == true)
{
string strComparisonOpTeachingSolutionId = objCurrEduCls4SynchCond.dicFldComparisonOp[conCurrEduCls4Synch.TeachingSolutionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.TeachingSolutionId, objCurrEduCls4SynchCond.TeachingSolutionId, strComparisonOpTeachingSolutionId);
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objCurrEduCls4SynchCond.dicFldComparisonOp[conCurrEduCls4Synch.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.IdXzCollege, objCurrEduCls4SynchCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.IdEduWay) == true)
{
string strComparisonOpIdEduWay = objCurrEduCls4SynchCond.dicFldComparisonOp[conCurrEduCls4Synch.IdEduWay];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.IdEduWay, objCurrEduCls4SynchCond.IdEduWay, strComparisonOpIdEduWay);
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.IdClassRoomType) == true)
{
string strComparisonOpIdClassRoomType = objCurrEduCls4SynchCond.dicFldComparisonOp[conCurrEduCls4Synch.IdClassRoomType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.IdClassRoomType, objCurrEduCls4SynchCond.IdClassRoomType, strComparisonOpIdClassRoomType);
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.TotalLessonQty) == true)
{
string strComparisonOpTotalLessonQty = objCurrEduCls4SynchCond.dicFldComparisonOp[conCurrEduCls4Synch.TotalLessonQty];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduCls4Synch.TotalLessonQty, objCurrEduCls4SynchCond.TotalLessonQty, strComparisonOpTotalLessonQty);
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.MaxStuQty) == true)
{
string strComparisonOpMaxStuQty = objCurrEduCls4SynchCond.dicFldComparisonOp[conCurrEduCls4Synch.MaxStuQty];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduCls4Synch.MaxStuQty, objCurrEduCls4SynchCond.MaxStuQty, strComparisonOpMaxStuQty);
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.CurrentStuQty) == true)
{
string strComparisonOpCurrentStuQty = objCurrEduCls4SynchCond.dicFldComparisonOp[conCurrEduCls4Synch.CurrentStuQty];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduCls4Synch.CurrentStuQty, objCurrEduCls4SynchCond.CurrentStuQty, strComparisonOpCurrentStuQty);
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.WeekQty) == true)
{
string strComparisonOpWeekQty = objCurrEduCls4SynchCond.dicFldComparisonOp[conCurrEduCls4Synch.WeekQty];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduCls4Synch.WeekQty, objCurrEduCls4SynchCond.WeekQty, strComparisonOpWeekQty);
}
//数据类型short(smallint)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.WeekStatusId) == true)
{
string strComparisonOpWeekStatusId = objCurrEduCls4SynchCond.dicFldComparisonOp[conCurrEduCls4Synch.WeekStatusId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.WeekStatusId, objCurrEduCls4SynchCond.WeekStatusId, strComparisonOpWeekStatusId);
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.CustomerWeek) == true)
{
string strComparisonOpCustomerWeek = objCurrEduCls4SynchCond.dicFldComparisonOp[conCurrEduCls4Synch.CustomerWeek];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.CustomerWeek, objCurrEduCls4SynchCond.CustomerWeek, strComparisonOpCustomerWeek);
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.IsCompleteScore) == true)
{
if (objCurrEduCls4SynchCond.IsCompleteScore == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls4Synch.IsCompleteScore);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls4Synch.IsCompleteScore);
}
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.IdExecPlan) == true)
{
string strComparisonOpIdExecPlan = objCurrEduCls4SynchCond.dicFldComparisonOp[conCurrEduCls4Synch.IdExecPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.IdExecPlan, objCurrEduCls4SynchCond.IdExecPlan, strComparisonOpIdExecPlan);
}
//数据类型short(smallint)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.Mark) == true)
{
string strComparisonOpMark = objCurrEduCls4SynchCond.dicFldComparisonOp[conCurrEduCls4Synch.Mark];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduCls4Synch.Mark, objCurrEduCls4SynchCond.Mark, strComparisonOpMark);
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.CheckClassRoom) == true)
{
string strComparisonOpCheckClassRoom = objCurrEduCls4SynchCond.dicFldComparisonOp[conCurrEduCls4Synch.CheckClassRoom];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.CheckClassRoom, objCurrEduCls4SynchCond.CheckClassRoom, strComparisonOpCheckClassRoom);
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.CheckAdminCls) == true)
{
string strComparisonOpCheckAdminCls = objCurrEduCls4SynchCond.dicFldComparisonOp[conCurrEduCls4Synch.CheckAdminCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.CheckAdminCls, objCurrEduCls4SynchCond.CheckAdminCls, strComparisonOpCheckAdminCls);
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.CheckTeacher) == true)
{
string strComparisonOpCheckTeacher = objCurrEduCls4SynchCond.dicFldComparisonOp[conCurrEduCls4Synch.CheckTeacher];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.CheckTeacher, objCurrEduCls4SynchCond.CheckTeacher, strComparisonOpCheckTeacher);
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.EditLocked) == true)
{
if (objCurrEduCls4SynchCond.EditLocked == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls4Synch.EditLocked);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls4Synch.EditLocked);
}
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.Sched) == true)
{
if (objCurrEduCls4SynchCond.Sched == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls4Synch.Sched);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls4Synch.Sched);
}
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.IdUniZone) == true)
{
string strComparisonOpIdUniZone = objCurrEduCls4SynchCond.dicFldComparisonOp[conCurrEduCls4Synch.IdUniZone];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.IdUniZone, objCurrEduCls4SynchCond.IdUniZone, strComparisonOpIdUniZone);
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.Locked) == true)
{
if (objCurrEduCls4SynchCond.Locked == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls4Synch.Locked);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls4Synch.Locked);
}
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.IdGradeBase) == true)
{
string strComparisonOpIdGradeBase = objCurrEduCls4SynchCond.dicFldComparisonOp[conCurrEduCls4Synch.IdGradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.IdGradeBase, objCurrEduCls4SynchCond.IdGradeBase, strComparisonOpIdGradeBase);
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.IsEffective) == true)
{
if (objCurrEduCls4SynchCond.IsEffective == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls4Synch.IsEffective);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls4Synch.IsEffective);
}
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.IsUnDeterminedClsRm) == true)
{
if (objCurrEduCls4SynchCond.IsUnDeterminedClsRm == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls4Synch.IsUnDeterminedClsRm);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls4Synch.IsUnDeterminedClsRm);
}
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.SchoolYear) == true)
{
string strComparisonOpSchoolYear = objCurrEduCls4SynchCond.dicFldComparisonOp[conCurrEduCls4Synch.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.SchoolYear, objCurrEduCls4SynchCond.SchoolYear, strComparisonOpSchoolYear);
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.SchoolTerm) == true)
{
string strComparisonOpSchoolTerm = objCurrEduCls4SynchCond.dicFldComparisonOp[conCurrEduCls4Synch.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.SchoolTerm, objCurrEduCls4SynchCond.SchoolTerm, strComparisonOpSchoolTerm);
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.ArrangeCourseMemo) == true)
{
string strComparisonOpArrangeCourseMemo = objCurrEduCls4SynchCond.dicFldComparisonOp[conCurrEduCls4Synch.ArrangeCourseMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.ArrangeCourseMemo, objCurrEduCls4SynchCond.ArrangeCourseMemo, strComparisonOpArrangeCourseMemo);
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.IdCourseType) == true)
{
string strComparisonOpIdCourseType = objCurrEduCls4SynchCond.dicFldComparisonOp[conCurrEduCls4Synch.IdCourseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.IdCourseType, objCurrEduCls4SynchCond.IdCourseType, strComparisonOpIdCourseType);
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.ExportDate) == true)
{
string strComparisonOpExportDate = objCurrEduCls4SynchCond.dicFldComparisonOp[conCurrEduCls4Synch.ExportDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.ExportDate, objCurrEduCls4SynchCond.ExportDate, strComparisonOpExportDate);
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.IsDegree) == true)
{
if (objCurrEduCls4SynchCond.IsDegree == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls4Synch.IsDegree);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls4Synch.IsDegree);
}
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.IdScoreType) == true)
{
string strComparisonOpIdScoreType = objCurrEduCls4SynchCond.dicFldComparisonOp[conCurrEduCls4Synch.IdScoreType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.IdScoreType, objCurrEduCls4SynchCond.IdScoreType, strComparisonOpIdScoreType);
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.GetScoreWayId) == true)
{
string strComparisonOpGetScoreWayId = objCurrEduCls4SynchCond.dicFldComparisonOp[conCurrEduCls4Synch.GetScoreWayId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.GetScoreWayId, objCurrEduCls4SynchCond.GetScoreWayId, strComparisonOpGetScoreWayId);
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.IsProportionalCtrl) == true)
{
if (objCurrEduCls4SynchCond.IsProportionalCtrl == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls4Synch.IsProportionalCtrl);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls4Synch.IsProportionalCtrl);
}
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.IsSynchToWeb) == true)
{
if (objCurrEduCls4SynchCond.IsSynchToWeb == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls4Synch.IsSynchToWeb);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls4Synch.IsSynchToWeb);
}
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.SynchToWebDate) == true)
{
string strComparisonOpSynchToWebDate = objCurrEduCls4SynchCond.dicFldComparisonOp[conCurrEduCls4Synch.SynchToWebDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.SynchToWebDate, objCurrEduCls4SynchCond.SynchToWebDate, strComparisonOpSynchToWebDate);
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.SynchToWebUser) == true)
{
string strComparisonOpSynchToWebUser = objCurrEduCls4SynchCond.dicFldComparisonOp[conCurrEduCls4Synch.SynchToWebUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.SynchToWebUser, objCurrEduCls4SynchCond.SynchToWebUser, strComparisonOpSynchToWebUser);
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.SignInDate) == true)
{
string strComparisonOpSignInDate = objCurrEduCls4SynchCond.dicFldComparisonOp[conCurrEduCls4Synch.SignInDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.SignInDate, objCurrEduCls4SynchCond.SignInDate, strComparisonOpSignInDate);
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.SignInStateID) == true)
{
string strComparisonOpSignInStateID = objCurrEduCls4SynchCond.dicFldComparisonOp[conCurrEduCls4Synch.SignInStateID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.SignInStateID, objCurrEduCls4SynchCond.SignInStateID, strComparisonOpSignInStateID);
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.SignInUser) == true)
{
string strComparisonOpSignInUser = objCurrEduCls4SynchCond.dicFldComparisonOp[conCurrEduCls4Synch.SignInUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.SignInUser, objCurrEduCls4SynchCond.SignInUser, strComparisonOpSignInUser);
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.IdExamType) == true)
{
string strComparisonOpIdExamType = objCurrEduCls4SynchCond.dicFldComparisonOp[conCurrEduCls4Synch.IdExamType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.IdExamType, objCurrEduCls4SynchCond.IdExamType, strComparisonOpIdExamType);
}
//数据类型short(smallint)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
//数据类型short(smallint)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.IsClearScore) == true)
{
if (objCurrEduCls4SynchCond.IsClearScore == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls4Synch.IsClearScore);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls4Synch.IsClearScore);
}
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.IsGeneratePwd) == true)
{
if (objCurrEduCls4SynchCond.IsGeneratePwd == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls4Synch.IsGeneratePwd);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls4Synch.IsGeneratePwd);
}
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.GeneratePwdDate) == true)
{
string strComparisonOpGeneratePwdDate = objCurrEduCls4SynchCond.dicFldComparisonOp[conCurrEduCls4Synch.GeneratePwdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.GeneratePwdDate, objCurrEduCls4SynchCond.GeneratePwdDate, strComparisonOpGeneratePwdDate);
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.IsExportToGP) == true)
{
if (objCurrEduCls4SynchCond.IsExportToGP == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls4Synch.IsExportToGP);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls4Synch.IsExportToGP);
}
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.IsExportToGPWeb) == true)
{
if (objCurrEduCls4SynchCond.IsExportToGPWeb == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls4Synch.IsExportToGPWeb);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls4Synch.IsExportToGPWeb);
}
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.IsReservedDecimal) == true)
{
if (objCurrEduCls4SynchCond.IsReservedDecimal == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls4Synch.IsReservedDecimal);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls4Synch.IsReservedDecimal);
}
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.ExamTime) == true)
{
string strComparisonOpExamTime = objCurrEduCls4SynchCond.dicFldComparisonOp[conCurrEduCls4Synch.ExamTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.ExamTime, objCurrEduCls4SynchCond.ExamTime, strComparisonOpExamTime);
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.CheckState) == true)
{
if (objCurrEduCls4SynchCond.CheckState == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls4Synch.CheckState);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls4Synch.CheckState);
}
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.CheckDate) == true)
{
string strComparisonOpCheckDate = objCurrEduCls4SynchCond.dicFldComparisonOp[conCurrEduCls4Synch.CheckDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.CheckDate, objCurrEduCls4SynchCond.CheckDate, strComparisonOpCheckDate);
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.IdEduClassInPk) == true)
{
string strComparisonOpIdEduClassInPk = objCurrEduCls4SynchCond.dicFldComparisonOp[conCurrEduCls4Synch.IdEduClassInPk];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.IdEduClassInPk, objCurrEduCls4SynchCond.IdEduClassInPk, strComparisonOpIdEduClassInPk);
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.PkWeekTime) == true)
{
string strComparisonOpPkWeekTime = objCurrEduCls4SynchCond.dicFldComparisonOp[conCurrEduCls4Synch.PkWeekTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.PkWeekTime, objCurrEduCls4SynchCond.PkWeekTime, strComparisonOpPkWeekTime);
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.PkClassRooms) == true)
{
string strComparisonOpPkClassRooms = objCurrEduCls4SynchCond.dicFldComparisonOp[conCurrEduCls4Synch.PkClassRooms];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.PkClassRooms, objCurrEduCls4SynchCond.PkClassRooms, strComparisonOpPkClassRooms);
}
//数据类型short(smallint)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.TeacherNames) == true)
{
string strComparisonOpTeacherNames = objCurrEduCls4SynchCond.dicFldComparisonOp[conCurrEduCls4Synch.TeacherNames];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.TeacherNames, objCurrEduCls4SynchCond.TeacherNames, strComparisonOpTeacherNames);
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.IsAccessSynch) == true)
{
if (objCurrEduCls4SynchCond.IsAccessSynch == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls4Synch.IsAccessSynch);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls4Synch.IsAccessSynch);
}
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.AccessSynchDate) == true)
{
string strComparisonOpAccessSynchDate = objCurrEduCls4SynchCond.dicFldComparisonOp[conCurrEduCls4Synch.AccessSynchDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.AccessSynchDate, objCurrEduCls4SynchCond.AccessSynchDate, strComparisonOpAccessSynchDate);
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.IsExistEduClsInCurr) == true)
{
if (objCurrEduCls4SynchCond.IsExistEduClsInCurr == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls4Synch.IsExistEduClsInCurr);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls4Synch.IsExistEduClsInCurr);
}
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.ModifyDate) == true)
{
string strComparisonOpModifyDate = objCurrEduCls4SynchCond.dicFldComparisonOp[conCurrEduCls4Synch.ModifyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.ModifyDate, objCurrEduCls4SynchCond.ModifyDate, strComparisonOpModifyDate);
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.ModifyUserId) == true)
{
string strComparisonOpModifyUserId = objCurrEduCls4SynchCond.dicFldComparisonOp[conCurrEduCls4Synch.ModifyUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.ModifyUserId, objCurrEduCls4SynchCond.ModifyUserId, strComparisonOpModifyUserId);
}
if (objCurrEduCls4SynchCond.IsUpdated(conCurrEduCls4Synch.Memo) == true)
{
string strComparisonOpMemo = objCurrEduCls4SynchCond.dicFldComparisonOp[conCurrEduCls4Synch.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.Memo, objCurrEduCls4SynchCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--CurrEduCls4Synch(当前教学班_同步), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:id_CurrEduCls_IpAddress
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objCurrEduCls4SynchEN == null) return true;
if (objCurrEduCls4SynchEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objCurrEduCls4SynchEN.IdCurrEduCls);
 if (objCurrEduCls4SynchEN.IpAddress == null)
{
 sbCondition.AppendFormat(" and IpAddress is null", objCurrEduCls4SynchEN.IpAddress);
}
else
{
 sbCondition.AppendFormat(" and IpAddress = '{0}'", objCurrEduCls4SynchEN.IpAddress);
}
if (clsCurrEduCls4SynchBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objCurrEduCls4SynchEN.mId);
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objCurrEduCls4SynchEN.IdCurrEduCls);
 sbCondition.AppendFormat(" and IpAddress = '{0}'", objCurrEduCls4SynchEN.IpAddress);
if (clsCurrEduCls4SynchBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--CurrEduCls4Synch(当前教学班_同步), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:id_CurrEduCls_IpAddress
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCurrEduCls4SynchEN == null) return "";
if (objCurrEduCls4SynchEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objCurrEduCls4SynchEN.IdCurrEduCls);
 if (objCurrEduCls4SynchEN.IpAddress == null)
{
 sbCondition.AppendFormat(" and IpAddress is null", objCurrEduCls4SynchEN.IpAddress);
}
else
{
 sbCondition.AppendFormat(" and IpAddress = '{0}'", objCurrEduCls4SynchEN.IpAddress);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objCurrEduCls4SynchEN.mId);
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objCurrEduCls4SynchEN.IdCurrEduCls);
 sbCondition.AppendFormat(" and IpAddress = '{0}'", objCurrEduCls4SynchEN.IpAddress);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_CurrEduCls4Synch
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 当前教学班_同步(CurrEduCls4Synch)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsCurrEduCls4SynchBL
{
public static RelatedActions_CurrEduCls4Synch relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsCurrEduCls4SynchDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsCurrEduCls4SynchDA CurrEduCls4SynchDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsCurrEduCls4SynchDA();
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
 public clsCurrEduCls4SynchBL()
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
if (string.IsNullOrEmpty(clsCurrEduCls4SynchEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCurrEduCls4SynchEN._ConnectString);
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
public static DataTable GetDataTable_CurrEduCls4Synch(string strWhereCond)
{
DataTable objDT;
try
{
objDT = CurrEduCls4SynchDA.GetDataTable_CurrEduCls4Synch(strWhereCond);
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
objDT = CurrEduCls4SynchDA.GetDataTable(strWhereCond);
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
objDT = CurrEduCls4SynchDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = CurrEduCls4SynchDA.GetDataTable(strWhereCond, strTabName);
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
objDT = CurrEduCls4SynchDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = CurrEduCls4SynchDA.GetDataTable_Top(objTopPara);
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
objDT = CurrEduCls4SynchDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = CurrEduCls4SynchDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = CurrEduCls4SynchDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsCurrEduCls4SynchEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsCurrEduCls4SynchEN> arrObjLst = new List<clsCurrEduCls4SynchEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMIdLst);
 string strWhereCond = string.Format("mId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduCls4SynchEN objCurrEduCls4SynchEN = new clsCurrEduCls4SynchEN();
try
{
objCurrEduCls4SynchEN.mId = Int32.Parse(objRow[conCurrEduCls4Synch.mId].ToString().Trim()); //mId
objCurrEduCls4SynchEN.IpAddress = objRow[conCurrEduCls4Synch.IpAddress] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IpAddress].ToString().Trim(); //Ip地址
objCurrEduCls4SynchEN.IdCurrEduCls = objRow[conCurrEduCls4Synch.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduCls4SynchEN.CurrEduClsId = objRow[conCurrEduCls4Synch.CurrEduClsId].ToString().Trim(); //教学班Id
objCurrEduCls4SynchEN.EduClsName = objRow[conCurrEduCls4Synch.EduClsName] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.EduClsName].ToString().Trim(); //教学班名
objCurrEduCls4SynchEN.EduClsTypeId = objRow[conCurrEduCls4Synch.EduClsTypeId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.EduClsTypeId].ToString().Trim(); //教学班类型Id
objCurrEduCls4SynchEN.CourseId = objRow[conCurrEduCls4Synch.CourseId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CourseId].ToString().Trim(); //课程Id
objCurrEduCls4SynchEN.TeachingSolutionId = objRow[conCurrEduCls4Synch.TeachingSolutionId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCurrEduCls4SynchEN.IdXzCollege = objRow[conCurrEduCls4Synch.IdXzCollege] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdXzCollege].ToString().Trim(); //学院流水号
objCurrEduCls4SynchEN.IdEduWay = objRow[conCurrEduCls4Synch.IdEduWay] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdEduWay].ToString().Trim(); //教学方式流水号
objCurrEduCls4SynchEN.IdClassRoomType = objRow[conCurrEduCls4Synch.IdClassRoomType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdClassRoomType].ToString().Trim(); //教室类型流水号
objCurrEduCls4SynchEN.TotalLessonQty = objRow[conCurrEduCls4Synch.TotalLessonQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls4Synch.TotalLessonQty].ToString().Trim()); //总课时数
objCurrEduCls4SynchEN.MaxStuQty = objRow[conCurrEduCls4Synch.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls4Synch.MaxStuQty].ToString().Trim()); //最大学生数
objCurrEduCls4SynchEN.CurrentStuQty = objRow[conCurrEduCls4Synch.CurrentStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls4Synch.CurrentStuQty].ToString().Trim()); //当前学生数
objCurrEduCls4SynchEN.WeekQty = objRow[conCurrEduCls4Synch.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls4Synch.WeekQty].ToString().Trim()); //总周数
objCurrEduCls4SynchEN.ScheUnitPW = objRow[conCurrEduCls4Synch.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.ScheUnitPW].ToString().Trim()); //周排课次数
objCurrEduCls4SynchEN.WeekStatusId = objRow[conCurrEduCls4Synch.WeekStatusId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objCurrEduCls4SynchEN.CustomerWeek = objRow[conCurrEduCls4Synch.CustomerWeek] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CustomerWeek].ToString().Trim(); //自定义上课周
objCurrEduCls4SynchEN.IsCompleteScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsCompleteScore].ToString().Trim()); //是否成绩齐全
objCurrEduCls4SynchEN.IdExecPlan = objRow[conCurrEduCls4Synch.IdExecPlan] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdExecPlan].ToString().Trim(); //执行计划流水号
objCurrEduCls4SynchEN.LessonQtyPerWeek = objRow[conCurrEduCls4Synch.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.LessonQtyPerWeek].ToString().Trim()); //周课时数
objCurrEduCls4SynchEN.Mark = objRow[conCurrEduCls4Synch.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduCls4Synch.Mark].ToString().Trim()); //获得学分
objCurrEduCls4SynchEN.CheckClassRoom = objRow[conCurrEduCls4Synch.CheckClassRoom] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckClassRoom].ToString().Trim(); //检查教室结果
objCurrEduCls4SynchEN.CheckAdminCls = objRow[conCurrEduCls4Synch.CheckAdminCls] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckAdminCls].ToString().Trim(); //检查行政班结果
objCurrEduCls4SynchEN.CheckTeacher = objRow[conCurrEduCls4Synch.CheckTeacher] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckTeacher].ToString().Trim(); //检查教师结果
objCurrEduCls4SynchEN.EditLocked = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.EditLocked].ToString().Trim()); //编辑锁定
objCurrEduCls4SynchEN.Sched = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.Sched].ToString().Trim()); //是否排课
objCurrEduCls4SynchEN.IdUniZone = objRow[conCurrEduCls4Synch.IdUniZone] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdUniZone].ToString().Trim(); //校区流水号
objCurrEduCls4SynchEN.Locked = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.Locked].ToString().Trim()); //锁定状态
objCurrEduCls4SynchEN.IdGradeBase = objRow[conCurrEduCls4Synch.IdGradeBase] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdGradeBase].ToString().Trim(); //年级流水号
objCurrEduCls4SynchEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsEffective].ToString().Trim()); //是否有效
objCurrEduCls4SynchEN.IsUnDeterminedClsRm = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsUnDeterminedClsRm].ToString().Trim()); //是否待定教室
objCurrEduCls4SynchEN.SchoolYear = objRow[conCurrEduCls4Synch.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SchoolYear].ToString().Trim(); //学年
objCurrEduCls4SynchEN.SchoolTerm = objRow[conCurrEduCls4Synch.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SchoolTerm].ToString().Trim(); //学期
objCurrEduCls4SynchEN.ArrangeCourseMemo = objRow[conCurrEduCls4Synch.ArrangeCourseMemo] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ArrangeCourseMemo].ToString().Trim(); //排课备注
objCurrEduCls4SynchEN.IdCourseType = objRow[conCurrEduCls4Synch.IdCourseType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdCourseType].ToString().Trim(); //课程类型流水号
objCurrEduCls4SynchEN.ExportDate = objRow[conCurrEduCls4Synch.ExportDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ExportDate].ToString().Trim(); //导出日期
objCurrEduCls4SynchEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsDegree].ToString().Trim()); //是否学位课
objCurrEduCls4SynchEN.IdScoreType = objRow[conCurrEduCls4Synch.IdScoreType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdScoreType].ToString().Trim(); //成绩类型流水号
objCurrEduCls4SynchEN.GetScoreWayId = objRow[conCurrEduCls4Synch.GetScoreWayId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objCurrEduCls4SynchEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objCurrEduCls4SynchEN.IsSynchToWeb = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsSynchToWeb].ToString().Trim()); //是否同步Web
objCurrEduCls4SynchEN.SynchToWebDate = objRow[conCurrEduCls4Synch.SynchToWebDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SynchToWebDate].ToString().Trim(); //同步Web日期
objCurrEduCls4SynchEN.SynchToWebUser = objRow[conCurrEduCls4Synch.SynchToWebUser] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SynchToWebUser].ToString().Trim(); //同步Web用户
objCurrEduCls4SynchEN.SignInDate = objRow[conCurrEduCls4Synch.SignInDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SignInDate].ToString().Trim(); //签入时间
objCurrEduCls4SynchEN.SignInStateID = objRow[conCurrEduCls4Synch.SignInStateID] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SignInStateID].ToString().Trim(); //签入状态表流水号
objCurrEduCls4SynchEN.SignInUser = objRow[conCurrEduCls4Synch.SignInUser] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SignInUser].ToString().Trim(); //签入人
objCurrEduCls4SynchEN.IdExamType = objRow[conCurrEduCls4Synch.IdExamType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdExamType].ToString().Trim(); //考试方式流水号
objCurrEduCls4SynchEN.ExamPortion = objRow[conCurrEduCls4Synch.ExamPortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.ExamPortion].ToString().Trim()); //平时成绩所占比例
objCurrEduCls4SynchEN.MidExamScorePortion = objRow[conCurrEduCls4Synch.MidExamScorePortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.MidExamScorePortion].ToString().Trim()); //期末成绩所占比例
objCurrEduCls4SynchEN.IsClearScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsClearScore].ToString().Trim()); //是否重录成绩
objCurrEduCls4SynchEN.IsGeneratePwd = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsGeneratePwd].ToString().Trim()); //是否生成口令
objCurrEduCls4SynchEN.GeneratePwdDate = objRow[conCurrEduCls4Synch.GeneratePwdDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.GeneratePwdDate].ToString().Trim(); //生成口令时间
objCurrEduCls4SynchEN.IsExportToGP = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsExportToGP].ToString().Trim()); //是否导出到平台
objCurrEduCls4SynchEN.IsExportToGPWeb = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsExportToGPWeb].ToString().Trim()); //是否导出到Web平台
objCurrEduCls4SynchEN.IsReservedDecimal = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsReservedDecimal].ToString().Trim()); //是否保留小数
objCurrEduCls4SynchEN.ExamTime = objRow[conCurrEduCls4Synch.ExamTime] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ExamTime].ToString().Trim(); //考试时间
objCurrEduCls4SynchEN.CheckState = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.CheckState].ToString().Trim()); //检查状态
objCurrEduCls4SynchEN.CheckDate = objRow[conCurrEduCls4Synch.CheckDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckDate].ToString().Trim(); //检查日期
objCurrEduCls4SynchEN.IdEduClassInPk = objRow[conCurrEduCls4Synch.IdEduClassInPk] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdEduClassInPk].ToString().Trim(); //id_EduClassInPk
objCurrEduCls4SynchEN.PkWeekTime = objRow[conCurrEduCls4Synch.PkWeekTime] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.PkWeekTime].ToString().Trim(); //排课时间
objCurrEduCls4SynchEN.PkClassRooms = objRow[conCurrEduCls4Synch.PkClassRooms] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.PkClassRooms].ToString().Trim(); //排课教室
objCurrEduCls4SynchEN.BeginWeek = objRow[conCurrEduCls4Synch.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.BeginWeek].ToString().Trim()); //开始周
objCurrEduCls4SynchEN.TeacherNames = objRow[conCurrEduCls4Synch.TeacherNames] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.TeacherNames].ToString().Trim(); //教师姓名
objCurrEduCls4SynchEN.IsAccessSynch = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步
objCurrEduCls4SynchEN.AccessSynchDate = objRow[conCurrEduCls4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期
objCurrEduCls4SynchEN.IsExistEduClsInCurr = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsExistEduClsInCurr].ToString().Trim()); //当前是否存在教学班
objCurrEduCls4SynchEN.ModifyDate = objRow[conCurrEduCls4Synch.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ModifyDate].ToString().Trim(); //修改日期
objCurrEduCls4SynchEN.ModifyUserId = objRow[conCurrEduCls4Synch.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ModifyUserId].ToString().Trim(); //修改人
objCurrEduCls4SynchEN.Memo = objRow[conCurrEduCls4Synch.Memo] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduCls4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduCls4SynchEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsCurrEduCls4SynchEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsCurrEduCls4SynchEN._CurrTabName);
List<clsCurrEduCls4SynchEN> arrCurrEduCls4SynchObjLstCache = GetObjLstCache();
IEnumerable <clsCurrEduCls4SynchEN> arrCurrEduCls4SynchObjLst_Sel =
arrCurrEduCls4SynchObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrCurrEduCls4SynchObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCurrEduCls4SynchEN> GetObjLst(string strWhereCond)
{
List<clsCurrEduCls4SynchEN> arrObjLst = new List<clsCurrEduCls4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduCls4SynchEN objCurrEduCls4SynchEN = new clsCurrEduCls4SynchEN();
try
{
objCurrEduCls4SynchEN.mId = Int32.Parse(objRow[conCurrEduCls4Synch.mId].ToString().Trim()); //mId
objCurrEduCls4SynchEN.IpAddress = objRow[conCurrEduCls4Synch.IpAddress] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IpAddress].ToString().Trim(); //Ip地址
objCurrEduCls4SynchEN.IdCurrEduCls = objRow[conCurrEduCls4Synch.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduCls4SynchEN.CurrEduClsId = objRow[conCurrEduCls4Synch.CurrEduClsId].ToString().Trim(); //教学班Id
objCurrEduCls4SynchEN.EduClsName = objRow[conCurrEduCls4Synch.EduClsName] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.EduClsName].ToString().Trim(); //教学班名
objCurrEduCls4SynchEN.EduClsTypeId = objRow[conCurrEduCls4Synch.EduClsTypeId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.EduClsTypeId].ToString().Trim(); //教学班类型Id
objCurrEduCls4SynchEN.CourseId = objRow[conCurrEduCls4Synch.CourseId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CourseId].ToString().Trim(); //课程Id
objCurrEduCls4SynchEN.TeachingSolutionId = objRow[conCurrEduCls4Synch.TeachingSolutionId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCurrEduCls4SynchEN.IdXzCollege = objRow[conCurrEduCls4Synch.IdXzCollege] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdXzCollege].ToString().Trim(); //学院流水号
objCurrEduCls4SynchEN.IdEduWay = objRow[conCurrEduCls4Synch.IdEduWay] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdEduWay].ToString().Trim(); //教学方式流水号
objCurrEduCls4SynchEN.IdClassRoomType = objRow[conCurrEduCls4Synch.IdClassRoomType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdClassRoomType].ToString().Trim(); //教室类型流水号
objCurrEduCls4SynchEN.TotalLessonQty = objRow[conCurrEduCls4Synch.TotalLessonQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls4Synch.TotalLessonQty].ToString().Trim()); //总课时数
objCurrEduCls4SynchEN.MaxStuQty = objRow[conCurrEduCls4Synch.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls4Synch.MaxStuQty].ToString().Trim()); //最大学生数
objCurrEduCls4SynchEN.CurrentStuQty = objRow[conCurrEduCls4Synch.CurrentStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls4Synch.CurrentStuQty].ToString().Trim()); //当前学生数
objCurrEduCls4SynchEN.WeekQty = objRow[conCurrEduCls4Synch.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls4Synch.WeekQty].ToString().Trim()); //总周数
objCurrEduCls4SynchEN.ScheUnitPW = objRow[conCurrEduCls4Synch.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.ScheUnitPW].ToString().Trim()); //周排课次数
objCurrEduCls4SynchEN.WeekStatusId = objRow[conCurrEduCls4Synch.WeekStatusId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objCurrEduCls4SynchEN.CustomerWeek = objRow[conCurrEduCls4Synch.CustomerWeek] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CustomerWeek].ToString().Trim(); //自定义上课周
objCurrEduCls4SynchEN.IsCompleteScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsCompleteScore].ToString().Trim()); //是否成绩齐全
objCurrEduCls4SynchEN.IdExecPlan = objRow[conCurrEduCls4Synch.IdExecPlan] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdExecPlan].ToString().Trim(); //执行计划流水号
objCurrEduCls4SynchEN.LessonQtyPerWeek = objRow[conCurrEduCls4Synch.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.LessonQtyPerWeek].ToString().Trim()); //周课时数
objCurrEduCls4SynchEN.Mark = objRow[conCurrEduCls4Synch.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduCls4Synch.Mark].ToString().Trim()); //获得学分
objCurrEduCls4SynchEN.CheckClassRoom = objRow[conCurrEduCls4Synch.CheckClassRoom] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckClassRoom].ToString().Trim(); //检查教室结果
objCurrEduCls4SynchEN.CheckAdminCls = objRow[conCurrEduCls4Synch.CheckAdminCls] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckAdminCls].ToString().Trim(); //检查行政班结果
objCurrEduCls4SynchEN.CheckTeacher = objRow[conCurrEduCls4Synch.CheckTeacher] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckTeacher].ToString().Trim(); //检查教师结果
objCurrEduCls4SynchEN.EditLocked = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.EditLocked].ToString().Trim()); //编辑锁定
objCurrEduCls4SynchEN.Sched = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.Sched].ToString().Trim()); //是否排课
objCurrEduCls4SynchEN.IdUniZone = objRow[conCurrEduCls4Synch.IdUniZone] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdUniZone].ToString().Trim(); //校区流水号
objCurrEduCls4SynchEN.Locked = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.Locked].ToString().Trim()); //锁定状态
objCurrEduCls4SynchEN.IdGradeBase = objRow[conCurrEduCls4Synch.IdGradeBase] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdGradeBase].ToString().Trim(); //年级流水号
objCurrEduCls4SynchEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsEffective].ToString().Trim()); //是否有效
objCurrEduCls4SynchEN.IsUnDeterminedClsRm = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsUnDeterminedClsRm].ToString().Trim()); //是否待定教室
objCurrEduCls4SynchEN.SchoolYear = objRow[conCurrEduCls4Synch.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SchoolYear].ToString().Trim(); //学年
objCurrEduCls4SynchEN.SchoolTerm = objRow[conCurrEduCls4Synch.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SchoolTerm].ToString().Trim(); //学期
objCurrEduCls4SynchEN.ArrangeCourseMemo = objRow[conCurrEduCls4Synch.ArrangeCourseMemo] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ArrangeCourseMemo].ToString().Trim(); //排课备注
objCurrEduCls4SynchEN.IdCourseType = objRow[conCurrEduCls4Synch.IdCourseType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdCourseType].ToString().Trim(); //课程类型流水号
objCurrEduCls4SynchEN.ExportDate = objRow[conCurrEduCls4Synch.ExportDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ExportDate].ToString().Trim(); //导出日期
objCurrEduCls4SynchEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsDegree].ToString().Trim()); //是否学位课
objCurrEduCls4SynchEN.IdScoreType = objRow[conCurrEduCls4Synch.IdScoreType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdScoreType].ToString().Trim(); //成绩类型流水号
objCurrEduCls4SynchEN.GetScoreWayId = objRow[conCurrEduCls4Synch.GetScoreWayId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objCurrEduCls4SynchEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objCurrEduCls4SynchEN.IsSynchToWeb = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsSynchToWeb].ToString().Trim()); //是否同步Web
objCurrEduCls4SynchEN.SynchToWebDate = objRow[conCurrEduCls4Synch.SynchToWebDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SynchToWebDate].ToString().Trim(); //同步Web日期
objCurrEduCls4SynchEN.SynchToWebUser = objRow[conCurrEduCls4Synch.SynchToWebUser] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SynchToWebUser].ToString().Trim(); //同步Web用户
objCurrEduCls4SynchEN.SignInDate = objRow[conCurrEduCls4Synch.SignInDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SignInDate].ToString().Trim(); //签入时间
objCurrEduCls4SynchEN.SignInStateID = objRow[conCurrEduCls4Synch.SignInStateID] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SignInStateID].ToString().Trim(); //签入状态表流水号
objCurrEduCls4SynchEN.SignInUser = objRow[conCurrEduCls4Synch.SignInUser] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SignInUser].ToString().Trim(); //签入人
objCurrEduCls4SynchEN.IdExamType = objRow[conCurrEduCls4Synch.IdExamType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdExamType].ToString().Trim(); //考试方式流水号
objCurrEduCls4SynchEN.ExamPortion = objRow[conCurrEduCls4Synch.ExamPortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.ExamPortion].ToString().Trim()); //平时成绩所占比例
objCurrEduCls4SynchEN.MidExamScorePortion = objRow[conCurrEduCls4Synch.MidExamScorePortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.MidExamScorePortion].ToString().Trim()); //期末成绩所占比例
objCurrEduCls4SynchEN.IsClearScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsClearScore].ToString().Trim()); //是否重录成绩
objCurrEduCls4SynchEN.IsGeneratePwd = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsGeneratePwd].ToString().Trim()); //是否生成口令
objCurrEduCls4SynchEN.GeneratePwdDate = objRow[conCurrEduCls4Synch.GeneratePwdDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.GeneratePwdDate].ToString().Trim(); //生成口令时间
objCurrEduCls4SynchEN.IsExportToGP = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsExportToGP].ToString().Trim()); //是否导出到平台
objCurrEduCls4SynchEN.IsExportToGPWeb = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsExportToGPWeb].ToString().Trim()); //是否导出到Web平台
objCurrEduCls4SynchEN.IsReservedDecimal = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsReservedDecimal].ToString().Trim()); //是否保留小数
objCurrEduCls4SynchEN.ExamTime = objRow[conCurrEduCls4Synch.ExamTime] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ExamTime].ToString().Trim(); //考试时间
objCurrEduCls4SynchEN.CheckState = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.CheckState].ToString().Trim()); //检查状态
objCurrEduCls4SynchEN.CheckDate = objRow[conCurrEduCls4Synch.CheckDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckDate].ToString().Trim(); //检查日期
objCurrEduCls4SynchEN.IdEduClassInPk = objRow[conCurrEduCls4Synch.IdEduClassInPk] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdEduClassInPk].ToString().Trim(); //id_EduClassInPk
objCurrEduCls4SynchEN.PkWeekTime = objRow[conCurrEduCls4Synch.PkWeekTime] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.PkWeekTime].ToString().Trim(); //排课时间
objCurrEduCls4SynchEN.PkClassRooms = objRow[conCurrEduCls4Synch.PkClassRooms] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.PkClassRooms].ToString().Trim(); //排课教室
objCurrEduCls4SynchEN.BeginWeek = objRow[conCurrEduCls4Synch.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.BeginWeek].ToString().Trim()); //开始周
objCurrEduCls4SynchEN.TeacherNames = objRow[conCurrEduCls4Synch.TeacherNames] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.TeacherNames].ToString().Trim(); //教师姓名
objCurrEduCls4SynchEN.IsAccessSynch = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步
objCurrEduCls4SynchEN.AccessSynchDate = objRow[conCurrEduCls4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期
objCurrEduCls4SynchEN.IsExistEduClsInCurr = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsExistEduClsInCurr].ToString().Trim()); //当前是否存在教学班
objCurrEduCls4SynchEN.ModifyDate = objRow[conCurrEduCls4Synch.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ModifyDate].ToString().Trim(); //修改日期
objCurrEduCls4SynchEN.ModifyUserId = objRow[conCurrEduCls4Synch.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ModifyUserId].ToString().Trim(); //修改人
objCurrEduCls4SynchEN.Memo = objRow[conCurrEduCls4Synch.Memo] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduCls4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduCls4SynchEN);
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
public static List<clsCurrEduCls4SynchEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsCurrEduCls4SynchEN> arrObjLst = new List<clsCurrEduCls4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduCls4SynchEN objCurrEduCls4SynchEN = new clsCurrEduCls4SynchEN();
try
{
objCurrEduCls4SynchEN.mId = Int32.Parse(objRow[conCurrEduCls4Synch.mId].ToString().Trim()); //mId
objCurrEduCls4SynchEN.IpAddress = objRow[conCurrEduCls4Synch.IpAddress] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IpAddress].ToString().Trim(); //Ip地址
objCurrEduCls4SynchEN.IdCurrEduCls = objRow[conCurrEduCls4Synch.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduCls4SynchEN.CurrEduClsId = objRow[conCurrEduCls4Synch.CurrEduClsId].ToString().Trim(); //教学班Id
objCurrEduCls4SynchEN.EduClsName = objRow[conCurrEduCls4Synch.EduClsName] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.EduClsName].ToString().Trim(); //教学班名
objCurrEduCls4SynchEN.EduClsTypeId = objRow[conCurrEduCls4Synch.EduClsTypeId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.EduClsTypeId].ToString().Trim(); //教学班类型Id
objCurrEduCls4SynchEN.CourseId = objRow[conCurrEduCls4Synch.CourseId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CourseId].ToString().Trim(); //课程Id
objCurrEduCls4SynchEN.TeachingSolutionId = objRow[conCurrEduCls4Synch.TeachingSolutionId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCurrEduCls4SynchEN.IdXzCollege = objRow[conCurrEduCls4Synch.IdXzCollege] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdXzCollege].ToString().Trim(); //学院流水号
objCurrEduCls4SynchEN.IdEduWay = objRow[conCurrEduCls4Synch.IdEduWay] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdEduWay].ToString().Trim(); //教学方式流水号
objCurrEduCls4SynchEN.IdClassRoomType = objRow[conCurrEduCls4Synch.IdClassRoomType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdClassRoomType].ToString().Trim(); //教室类型流水号
objCurrEduCls4SynchEN.TotalLessonQty = objRow[conCurrEduCls4Synch.TotalLessonQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls4Synch.TotalLessonQty].ToString().Trim()); //总课时数
objCurrEduCls4SynchEN.MaxStuQty = objRow[conCurrEduCls4Synch.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls4Synch.MaxStuQty].ToString().Trim()); //最大学生数
objCurrEduCls4SynchEN.CurrentStuQty = objRow[conCurrEduCls4Synch.CurrentStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls4Synch.CurrentStuQty].ToString().Trim()); //当前学生数
objCurrEduCls4SynchEN.WeekQty = objRow[conCurrEduCls4Synch.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls4Synch.WeekQty].ToString().Trim()); //总周数
objCurrEduCls4SynchEN.ScheUnitPW = objRow[conCurrEduCls4Synch.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.ScheUnitPW].ToString().Trim()); //周排课次数
objCurrEduCls4SynchEN.WeekStatusId = objRow[conCurrEduCls4Synch.WeekStatusId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objCurrEduCls4SynchEN.CustomerWeek = objRow[conCurrEduCls4Synch.CustomerWeek] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CustomerWeek].ToString().Trim(); //自定义上课周
objCurrEduCls4SynchEN.IsCompleteScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsCompleteScore].ToString().Trim()); //是否成绩齐全
objCurrEduCls4SynchEN.IdExecPlan = objRow[conCurrEduCls4Synch.IdExecPlan] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdExecPlan].ToString().Trim(); //执行计划流水号
objCurrEduCls4SynchEN.LessonQtyPerWeek = objRow[conCurrEduCls4Synch.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.LessonQtyPerWeek].ToString().Trim()); //周课时数
objCurrEduCls4SynchEN.Mark = objRow[conCurrEduCls4Synch.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduCls4Synch.Mark].ToString().Trim()); //获得学分
objCurrEduCls4SynchEN.CheckClassRoom = objRow[conCurrEduCls4Synch.CheckClassRoom] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckClassRoom].ToString().Trim(); //检查教室结果
objCurrEduCls4SynchEN.CheckAdminCls = objRow[conCurrEduCls4Synch.CheckAdminCls] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckAdminCls].ToString().Trim(); //检查行政班结果
objCurrEduCls4SynchEN.CheckTeacher = objRow[conCurrEduCls4Synch.CheckTeacher] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckTeacher].ToString().Trim(); //检查教师结果
objCurrEduCls4SynchEN.EditLocked = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.EditLocked].ToString().Trim()); //编辑锁定
objCurrEduCls4SynchEN.Sched = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.Sched].ToString().Trim()); //是否排课
objCurrEduCls4SynchEN.IdUniZone = objRow[conCurrEduCls4Synch.IdUniZone] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdUniZone].ToString().Trim(); //校区流水号
objCurrEduCls4SynchEN.Locked = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.Locked].ToString().Trim()); //锁定状态
objCurrEduCls4SynchEN.IdGradeBase = objRow[conCurrEduCls4Synch.IdGradeBase] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdGradeBase].ToString().Trim(); //年级流水号
objCurrEduCls4SynchEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsEffective].ToString().Trim()); //是否有效
objCurrEduCls4SynchEN.IsUnDeterminedClsRm = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsUnDeterminedClsRm].ToString().Trim()); //是否待定教室
objCurrEduCls4SynchEN.SchoolYear = objRow[conCurrEduCls4Synch.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SchoolYear].ToString().Trim(); //学年
objCurrEduCls4SynchEN.SchoolTerm = objRow[conCurrEduCls4Synch.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SchoolTerm].ToString().Trim(); //学期
objCurrEduCls4SynchEN.ArrangeCourseMemo = objRow[conCurrEduCls4Synch.ArrangeCourseMemo] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ArrangeCourseMemo].ToString().Trim(); //排课备注
objCurrEduCls4SynchEN.IdCourseType = objRow[conCurrEduCls4Synch.IdCourseType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdCourseType].ToString().Trim(); //课程类型流水号
objCurrEduCls4SynchEN.ExportDate = objRow[conCurrEduCls4Synch.ExportDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ExportDate].ToString().Trim(); //导出日期
objCurrEduCls4SynchEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsDegree].ToString().Trim()); //是否学位课
objCurrEduCls4SynchEN.IdScoreType = objRow[conCurrEduCls4Synch.IdScoreType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdScoreType].ToString().Trim(); //成绩类型流水号
objCurrEduCls4SynchEN.GetScoreWayId = objRow[conCurrEduCls4Synch.GetScoreWayId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objCurrEduCls4SynchEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objCurrEduCls4SynchEN.IsSynchToWeb = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsSynchToWeb].ToString().Trim()); //是否同步Web
objCurrEduCls4SynchEN.SynchToWebDate = objRow[conCurrEduCls4Synch.SynchToWebDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SynchToWebDate].ToString().Trim(); //同步Web日期
objCurrEduCls4SynchEN.SynchToWebUser = objRow[conCurrEduCls4Synch.SynchToWebUser] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SynchToWebUser].ToString().Trim(); //同步Web用户
objCurrEduCls4SynchEN.SignInDate = objRow[conCurrEduCls4Synch.SignInDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SignInDate].ToString().Trim(); //签入时间
objCurrEduCls4SynchEN.SignInStateID = objRow[conCurrEduCls4Synch.SignInStateID] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SignInStateID].ToString().Trim(); //签入状态表流水号
objCurrEduCls4SynchEN.SignInUser = objRow[conCurrEduCls4Synch.SignInUser] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SignInUser].ToString().Trim(); //签入人
objCurrEduCls4SynchEN.IdExamType = objRow[conCurrEduCls4Synch.IdExamType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdExamType].ToString().Trim(); //考试方式流水号
objCurrEduCls4SynchEN.ExamPortion = objRow[conCurrEduCls4Synch.ExamPortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.ExamPortion].ToString().Trim()); //平时成绩所占比例
objCurrEduCls4SynchEN.MidExamScorePortion = objRow[conCurrEduCls4Synch.MidExamScorePortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.MidExamScorePortion].ToString().Trim()); //期末成绩所占比例
objCurrEduCls4SynchEN.IsClearScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsClearScore].ToString().Trim()); //是否重录成绩
objCurrEduCls4SynchEN.IsGeneratePwd = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsGeneratePwd].ToString().Trim()); //是否生成口令
objCurrEduCls4SynchEN.GeneratePwdDate = objRow[conCurrEduCls4Synch.GeneratePwdDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.GeneratePwdDate].ToString().Trim(); //生成口令时间
objCurrEduCls4SynchEN.IsExportToGP = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsExportToGP].ToString().Trim()); //是否导出到平台
objCurrEduCls4SynchEN.IsExportToGPWeb = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsExportToGPWeb].ToString().Trim()); //是否导出到Web平台
objCurrEduCls4SynchEN.IsReservedDecimal = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsReservedDecimal].ToString().Trim()); //是否保留小数
objCurrEduCls4SynchEN.ExamTime = objRow[conCurrEduCls4Synch.ExamTime] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ExamTime].ToString().Trim(); //考试时间
objCurrEduCls4SynchEN.CheckState = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.CheckState].ToString().Trim()); //检查状态
objCurrEduCls4SynchEN.CheckDate = objRow[conCurrEduCls4Synch.CheckDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckDate].ToString().Trim(); //检查日期
objCurrEduCls4SynchEN.IdEduClassInPk = objRow[conCurrEduCls4Synch.IdEduClassInPk] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdEduClassInPk].ToString().Trim(); //id_EduClassInPk
objCurrEduCls4SynchEN.PkWeekTime = objRow[conCurrEduCls4Synch.PkWeekTime] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.PkWeekTime].ToString().Trim(); //排课时间
objCurrEduCls4SynchEN.PkClassRooms = objRow[conCurrEduCls4Synch.PkClassRooms] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.PkClassRooms].ToString().Trim(); //排课教室
objCurrEduCls4SynchEN.BeginWeek = objRow[conCurrEduCls4Synch.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.BeginWeek].ToString().Trim()); //开始周
objCurrEduCls4SynchEN.TeacherNames = objRow[conCurrEduCls4Synch.TeacherNames] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.TeacherNames].ToString().Trim(); //教师姓名
objCurrEduCls4SynchEN.IsAccessSynch = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步
objCurrEduCls4SynchEN.AccessSynchDate = objRow[conCurrEduCls4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期
objCurrEduCls4SynchEN.IsExistEduClsInCurr = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsExistEduClsInCurr].ToString().Trim()); //当前是否存在教学班
objCurrEduCls4SynchEN.ModifyDate = objRow[conCurrEduCls4Synch.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ModifyDate].ToString().Trim(); //修改日期
objCurrEduCls4SynchEN.ModifyUserId = objRow[conCurrEduCls4Synch.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ModifyUserId].ToString().Trim(); //修改人
objCurrEduCls4SynchEN.Memo = objRow[conCurrEduCls4Synch.Memo] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduCls4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduCls4SynchEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsCurrEduCls4SynchEN> GetSubObjLstCache(clsCurrEduCls4SynchEN objCurrEduCls4SynchCond)
{
List<clsCurrEduCls4SynchEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsCurrEduCls4SynchEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCurrEduCls4Synch.AttributeName)
{
if (objCurrEduCls4SynchCond.IsUpdated(strFldName) == false) continue;
if (objCurrEduCls4SynchCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCurrEduCls4SynchCond[strFldName].ToString());
}
else
{
if (objCurrEduCls4SynchCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCurrEduCls4SynchCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCurrEduCls4SynchCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCurrEduCls4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCurrEduCls4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCurrEduCls4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCurrEduCls4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCurrEduCls4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCurrEduCls4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCurrEduCls4SynchCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCurrEduCls4SynchCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCurrEduCls4SynchCond[strFldName]));
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
public static List<clsCurrEduCls4SynchEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsCurrEduCls4SynchEN> arrObjLst = new List<clsCurrEduCls4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduCls4SynchEN objCurrEduCls4SynchEN = new clsCurrEduCls4SynchEN();
try
{
objCurrEduCls4SynchEN.mId = Int32.Parse(objRow[conCurrEduCls4Synch.mId].ToString().Trim()); //mId
objCurrEduCls4SynchEN.IpAddress = objRow[conCurrEduCls4Synch.IpAddress] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IpAddress].ToString().Trim(); //Ip地址
objCurrEduCls4SynchEN.IdCurrEduCls = objRow[conCurrEduCls4Synch.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduCls4SynchEN.CurrEduClsId = objRow[conCurrEduCls4Synch.CurrEduClsId].ToString().Trim(); //教学班Id
objCurrEduCls4SynchEN.EduClsName = objRow[conCurrEduCls4Synch.EduClsName] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.EduClsName].ToString().Trim(); //教学班名
objCurrEduCls4SynchEN.EduClsTypeId = objRow[conCurrEduCls4Synch.EduClsTypeId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.EduClsTypeId].ToString().Trim(); //教学班类型Id
objCurrEduCls4SynchEN.CourseId = objRow[conCurrEduCls4Synch.CourseId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CourseId].ToString().Trim(); //课程Id
objCurrEduCls4SynchEN.TeachingSolutionId = objRow[conCurrEduCls4Synch.TeachingSolutionId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCurrEduCls4SynchEN.IdXzCollege = objRow[conCurrEduCls4Synch.IdXzCollege] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdXzCollege].ToString().Trim(); //学院流水号
objCurrEduCls4SynchEN.IdEduWay = objRow[conCurrEduCls4Synch.IdEduWay] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdEduWay].ToString().Trim(); //教学方式流水号
objCurrEduCls4SynchEN.IdClassRoomType = objRow[conCurrEduCls4Synch.IdClassRoomType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdClassRoomType].ToString().Trim(); //教室类型流水号
objCurrEduCls4SynchEN.TotalLessonQty = objRow[conCurrEduCls4Synch.TotalLessonQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls4Synch.TotalLessonQty].ToString().Trim()); //总课时数
objCurrEduCls4SynchEN.MaxStuQty = objRow[conCurrEduCls4Synch.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls4Synch.MaxStuQty].ToString().Trim()); //最大学生数
objCurrEduCls4SynchEN.CurrentStuQty = objRow[conCurrEduCls4Synch.CurrentStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls4Synch.CurrentStuQty].ToString().Trim()); //当前学生数
objCurrEduCls4SynchEN.WeekQty = objRow[conCurrEduCls4Synch.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls4Synch.WeekQty].ToString().Trim()); //总周数
objCurrEduCls4SynchEN.ScheUnitPW = objRow[conCurrEduCls4Synch.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.ScheUnitPW].ToString().Trim()); //周排课次数
objCurrEduCls4SynchEN.WeekStatusId = objRow[conCurrEduCls4Synch.WeekStatusId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objCurrEduCls4SynchEN.CustomerWeek = objRow[conCurrEduCls4Synch.CustomerWeek] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CustomerWeek].ToString().Trim(); //自定义上课周
objCurrEduCls4SynchEN.IsCompleteScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsCompleteScore].ToString().Trim()); //是否成绩齐全
objCurrEduCls4SynchEN.IdExecPlan = objRow[conCurrEduCls4Synch.IdExecPlan] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdExecPlan].ToString().Trim(); //执行计划流水号
objCurrEduCls4SynchEN.LessonQtyPerWeek = objRow[conCurrEduCls4Synch.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.LessonQtyPerWeek].ToString().Trim()); //周课时数
objCurrEduCls4SynchEN.Mark = objRow[conCurrEduCls4Synch.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduCls4Synch.Mark].ToString().Trim()); //获得学分
objCurrEduCls4SynchEN.CheckClassRoom = objRow[conCurrEduCls4Synch.CheckClassRoom] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckClassRoom].ToString().Trim(); //检查教室结果
objCurrEduCls4SynchEN.CheckAdminCls = objRow[conCurrEduCls4Synch.CheckAdminCls] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckAdminCls].ToString().Trim(); //检查行政班结果
objCurrEduCls4SynchEN.CheckTeacher = objRow[conCurrEduCls4Synch.CheckTeacher] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckTeacher].ToString().Trim(); //检查教师结果
objCurrEduCls4SynchEN.EditLocked = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.EditLocked].ToString().Trim()); //编辑锁定
objCurrEduCls4SynchEN.Sched = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.Sched].ToString().Trim()); //是否排课
objCurrEduCls4SynchEN.IdUniZone = objRow[conCurrEduCls4Synch.IdUniZone] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdUniZone].ToString().Trim(); //校区流水号
objCurrEduCls4SynchEN.Locked = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.Locked].ToString().Trim()); //锁定状态
objCurrEduCls4SynchEN.IdGradeBase = objRow[conCurrEduCls4Synch.IdGradeBase] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdGradeBase].ToString().Trim(); //年级流水号
objCurrEduCls4SynchEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsEffective].ToString().Trim()); //是否有效
objCurrEduCls4SynchEN.IsUnDeterminedClsRm = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsUnDeterminedClsRm].ToString().Trim()); //是否待定教室
objCurrEduCls4SynchEN.SchoolYear = objRow[conCurrEduCls4Synch.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SchoolYear].ToString().Trim(); //学年
objCurrEduCls4SynchEN.SchoolTerm = objRow[conCurrEduCls4Synch.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SchoolTerm].ToString().Trim(); //学期
objCurrEduCls4SynchEN.ArrangeCourseMemo = objRow[conCurrEduCls4Synch.ArrangeCourseMemo] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ArrangeCourseMemo].ToString().Trim(); //排课备注
objCurrEduCls4SynchEN.IdCourseType = objRow[conCurrEduCls4Synch.IdCourseType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdCourseType].ToString().Trim(); //课程类型流水号
objCurrEduCls4SynchEN.ExportDate = objRow[conCurrEduCls4Synch.ExportDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ExportDate].ToString().Trim(); //导出日期
objCurrEduCls4SynchEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsDegree].ToString().Trim()); //是否学位课
objCurrEduCls4SynchEN.IdScoreType = objRow[conCurrEduCls4Synch.IdScoreType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdScoreType].ToString().Trim(); //成绩类型流水号
objCurrEduCls4SynchEN.GetScoreWayId = objRow[conCurrEduCls4Synch.GetScoreWayId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objCurrEduCls4SynchEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objCurrEduCls4SynchEN.IsSynchToWeb = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsSynchToWeb].ToString().Trim()); //是否同步Web
objCurrEduCls4SynchEN.SynchToWebDate = objRow[conCurrEduCls4Synch.SynchToWebDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SynchToWebDate].ToString().Trim(); //同步Web日期
objCurrEduCls4SynchEN.SynchToWebUser = objRow[conCurrEduCls4Synch.SynchToWebUser] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SynchToWebUser].ToString().Trim(); //同步Web用户
objCurrEduCls4SynchEN.SignInDate = objRow[conCurrEduCls4Synch.SignInDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SignInDate].ToString().Trim(); //签入时间
objCurrEduCls4SynchEN.SignInStateID = objRow[conCurrEduCls4Synch.SignInStateID] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SignInStateID].ToString().Trim(); //签入状态表流水号
objCurrEduCls4SynchEN.SignInUser = objRow[conCurrEduCls4Synch.SignInUser] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SignInUser].ToString().Trim(); //签入人
objCurrEduCls4SynchEN.IdExamType = objRow[conCurrEduCls4Synch.IdExamType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdExamType].ToString().Trim(); //考试方式流水号
objCurrEduCls4SynchEN.ExamPortion = objRow[conCurrEduCls4Synch.ExamPortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.ExamPortion].ToString().Trim()); //平时成绩所占比例
objCurrEduCls4SynchEN.MidExamScorePortion = objRow[conCurrEduCls4Synch.MidExamScorePortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.MidExamScorePortion].ToString().Trim()); //期末成绩所占比例
objCurrEduCls4SynchEN.IsClearScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsClearScore].ToString().Trim()); //是否重录成绩
objCurrEduCls4SynchEN.IsGeneratePwd = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsGeneratePwd].ToString().Trim()); //是否生成口令
objCurrEduCls4SynchEN.GeneratePwdDate = objRow[conCurrEduCls4Synch.GeneratePwdDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.GeneratePwdDate].ToString().Trim(); //生成口令时间
objCurrEduCls4SynchEN.IsExportToGP = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsExportToGP].ToString().Trim()); //是否导出到平台
objCurrEduCls4SynchEN.IsExportToGPWeb = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsExportToGPWeb].ToString().Trim()); //是否导出到Web平台
objCurrEduCls4SynchEN.IsReservedDecimal = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsReservedDecimal].ToString().Trim()); //是否保留小数
objCurrEduCls4SynchEN.ExamTime = objRow[conCurrEduCls4Synch.ExamTime] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ExamTime].ToString().Trim(); //考试时间
objCurrEduCls4SynchEN.CheckState = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.CheckState].ToString().Trim()); //检查状态
objCurrEduCls4SynchEN.CheckDate = objRow[conCurrEduCls4Synch.CheckDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckDate].ToString().Trim(); //检查日期
objCurrEduCls4SynchEN.IdEduClassInPk = objRow[conCurrEduCls4Synch.IdEduClassInPk] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdEduClassInPk].ToString().Trim(); //id_EduClassInPk
objCurrEduCls4SynchEN.PkWeekTime = objRow[conCurrEduCls4Synch.PkWeekTime] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.PkWeekTime].ToString().Trim(); //排课时间
objCurrEduCls4SynchEN.PkClassRooms = objRow[conCurrEduCls4Synch.PkClassRooms] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.PkClassRooms].ToString().Trim(); //排课教室
objCurrEduCls4SynchEN.BeginWeek = objRow[conCurrEduCls4Synch.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.BeginWeek].ToString().Trim()); //开始周
objCurrEduCls4SynchEN.TeacherNames = objRow[conCurrEduCls4Synch.TeacherNames] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.TeacherNames].ToString().Trim(); //教师姓名
objCurrEduCls4SynchEN.IsAccessSynch = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步
objCurrEduCls4SynchEN.AccessSynchDate = objRow[conCurrEduCls4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期
objCurrEduCls4SynchEN.IsExistEduClsInCurr = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsExistEduClsInCurr].ToString().Trim()); //当前是否存在教学班
objCurrEduCls4SynchEN.ModifyDate = objRow[conCurrEduCls4Synch.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ModifyDate].ToString().Trim(); //修改日期
objCurrEduCls4SynchEN.ModifyUserId = objRow[conCurrEduCls4Synch.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ModifyUserId].ToString().Trim(); //修改人
objCurrEduCls4SynchEN.Memo = objRow[conCurrEduCls4Synch.Memo] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduCls4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduCls4SynchEN);
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
public static List<clsCurrEduCls4SynchEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsCurrEduCls4SynchEN> arrObjLst = new List<clsCurrEduCls4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduCls4SynchEN objCurrEduCls4SynchEN = new clsCurrEduCls4SynchEN();
try
{
objCurrEduCls4SynchEN.mId = Int32.Parse(objRow[conCurrEduCls4Synch.mId].ToString().Trim()); //mId
objCurrEduCls4SynchEN.IpAddress = objRow[conCurrEduCls4Synch.IpAddress] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IpAddress].ToString().Trim(); //Ip地址
objCurrEduCls4SynchEN.IdCurrEduCls = objRow[conCurrEduCls4Synch.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduCls4SynchEN.CurrEduClsId = objRow[conCurrEduCls4Synch.CurrEduClsId].ToString().Trim(); //教学班Id
objCurrEduCls4SynchEN.EduClsName = objRow[conCurrEduCls4Synch.EduClsName] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.EduClsName].ToString().Trim(); //教学班名
objCurrEduCls4SynchEN.EduClsTypeId = objRow[conCurrEduCls4Synch.EduClsTypeId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.EduClsTypeId].ToString().Trim(); //教学班类型Id
objCurrEduCls4SynchEN.CourseId = objRow[conCurrEduCls4Synch.CourseId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CourseId].ToString().Trim(); //课程Id
objCurrEduCls4SynchEN.TeachingSolutionId = objRow[conCurrEduCls4Synch.TeachingSolutionId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCurrEduCls4SynchEN.IdXzCollege = objRow[conCurrEduCls4Synch.IdXzCollege] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdXzCollege].ToString().Trim(); //学院流水号
objCurrEduCls4SynchEN.IdEduWay = objRow[conCurrEduCls4Synch.IdEduWay] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdEduWay].ToString().Trim(); //教学方式流水号
objCurrEduCls4SynchEN.IdClassRoomType = objRow[conCurrEduCls4Synch.IdClassRoomType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdClassRoomType].ToString().Trim(); //教室类型流水号
objCurrEduCls4SynchEN.TotalLessonQty = objRow[conCurrEduCls4Synch.TotalLessonQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls4Synch.TotalLessonQty].ToString().Trim()); //总课时数
objCurrEduCls4SynchEN.MaxStuQty = objRow[conCurrEduCls4Synch.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls4Synch.MaxStuQty].ToString().Trim()); //最大学生数
objCurrEduCls4SynchEN.CurrentStuQty = objRow[conCurrEduCls4Synch.CurrentStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls4Synch.CurrentStuQty].ToString().Trim()); //当前学生数
objCurrEduCls4SynchEN.WeekQty = objRow[conCurrEduCls4Synch.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls4Synch.WeekQty].ToString().Trim()); //总周数
objCurrEduCls4SynchEN.ScheUnitPW = objRow[conCurrEduCls4Synch.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.ScheUnitPW].ToString().Trim()); //周排课次数
objCurrEduCls4SynchEN.WeekStatusId = objRow[conCurrEduCls4Synch.WeekStatusId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objCurrEduCls4SynchEN.CustomerWeek = objRow[conCurrEduCls4Synch.CustomerWeek] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CustomerWeek].ToString().Trim(); //自定义上课周
objCurrEduCls4SynchEN.IsCompleteScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsCompleteScore].ToString().Trim()); //是否成绩齐全
objCurrEduCls4SynchEN.IdExecPlan = objRow[conCurrEduCls4Synch.IdExecPlan] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdExecPlan].ToString().Trim(); //执行计划流水号
objCurrEduCls4SynchEN.LessonQtyPerWeek = objRow[conCurrEduCls4Synch.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.LessonQtyPerWeek].ToString().Trim()); //周课时数
objCurrEduCls4SynchEN.Mark = objRow[conCurrEduCls4Synch.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduCls4Synch.Mark].ToString().Trim()); //获得学分
objCurrEduCls4SynchEN.CheckClassRoom = objRow[conCurrEduCls4Synch.CheckClassRoom] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckClassRoom].ToString().Trim(); //检查教室结果
objCurrEduCls4SynchEN.CheckAdminCls = objRow[conCurrEduCls4Synch.CheckAdminCls] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckAdminCls].ToString().Trim(); //检查行政班结果
objCurrEduCls4SynchEN.CheckTeacher = objRow[conCurrEduCls4Synch.CheckTeacher] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckTeacher].ToString().Trim(); //检查教师结果
objCurrEduCls4SynchEN.EditLocked = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.EditLocked].ToString().Trim()); //编辑锁定
objCurrEduCls4SynchEN.Sched = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.Sched].ToString().Trim()); //是否排课
objCurrEduCls4SynchEN.IdUniZone = objRow[conCurrEduCls4Synch.IdUniZone] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdUniZone].ToString().Trim(); //校区流水号
objCurrEduCls4SynchEN.Locked = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.Locked].ToString().Trim()); //锁定状态
objCurrEduCls4SynchEN.IdGradeBase = objRow[conCurrEduCls4Synch.IdGradeBase] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdGradeBase].ToString().Trim(); //年级流水号
objCurrEduCls4SynchEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsEffective].ToString().Trim()); //是否有效
objCurrEduCls4SynchEN.IsUnDeterminedClsRm = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsUnDeterminedClsRm].ToString().Trim()); //是否待定教室
objCurrEduCls4SynchEN.SchoolYear = objRow[conCurrEduCls4Synch.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SchoolYear].ToString().Trim(); //学年
objCurrEduCls4SynchEN.SchoolTerm = objRow[conCurrEduCls4Synch.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SchoolTerm].ToString().Trim(); //学期
objCurrEduCls4SynchEN.ArrangeCourseMemo = objRow[conCurrEduCls4Synch.ArrangeCourseMemo] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ArrangeCourseMemo].ToString().Trim(); //排课备注
objCurrEduCls4SynchEN.IdCourseType = objRow[conCurrEduCls4Synch.IdCourseType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdCourseType].ToString().Trim(); //课程类型流水号
objCurrEduCls4SynchEN.ExportDate = objRow[conCurrEduCls4Synch.ExportDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ExportDate].ToString().Trim(); //导出日期
objCurrEduCls4SynchEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsDegree].ToString().Trim()); //是否学位课
objCurrEduCls4SynchEN.IdScoreType = objRow[conCurrEduCls4Synch.IdScoreType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdScoreType].ToString().Trim(); //成绩类型流水号
objCurrEduCls4SynchEN.GetScoreWayId = objRow[conCurrEduCls4Synch.GetScoreWayId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objCurrEduCls4SynchEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objCurrEduCls4SynchEN.IsSynchToWeb = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsSynchToWeb].ToString().Trim()); //是否同步Web
objCurrEduCls4SynchEN.SynchToWebDate = objRow[conCurrEduCls4Synch.SynchToWebDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SynchToWebDate].ToString().Trim(); //同步Web日期
objCurrEduCls4SynchEN.SynchToWebUser = objRow[conCurrEduCls4Synch.SynchToWebUser] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SynchToWebUser].ToString().Trim(); //同步Web用户
objCurrEduCls4SynchEN.SignInDate = objRow[conCurrEduCls4Synch.SignInDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SignInDate].ToString().Trim(); //签入时间
objCurrEduCls4SynchEN.SignInStateID = objRow[conCurrEduCls4Synch.SignInStateID] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SignInStateID].ToString().Trim(); //签入状态表流水号
objCurrEduCls4SynchEN.SignInUser = objRow[conCurrEduCls4Synch.SignInUser] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SignInUser].ToString().Trim(); //签入人
objCurrEduCls4SynchEN.IdExamType = objRow[conCurrEduCls4Synch.IdExamType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdExamType].ToString().Trim(); //考试方式流水号
objCurrEduCls4SynchEN.ExamPortion = objRow[conCurrEduCls4Synch.ExamPortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.ExamPortion].ToString().Trim()); //平时成绩所占比例
objCurrEduCls4SynchEN.MidExamScorePortion = objRow[conCurrEduCls4Synch.MidExamScorePortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.MidExamScorePortion].ToString().Trim()); //期末成绩所占比例
objCurrEduCls4SynchEN.IsClearScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsClearScore].ToString().Trim()); //是否重录成绩
objCurrEduCls4SynchEN.IsGeneratePwd = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsGeneratePwd].ToString().Trim()); //是否生成口令
objCurrEduCls4SynchEN.GeneratePwdDate = objRow[conCurrEduCls4Synch.GeneratePwdDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.GeneratePwdDate].ToString().Trim(); //生成口令时间
objCurrEduCls4SynchEN.IsExportToGP = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsExportToGP].ToString().Trim()); //是否导出到平台
objCurrEduCls4SynchEN.IsExportToGPWeb = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsExportToGPWeb].ToString().Trim()); //是否导出到Web平台
objCurrEduCls4SynchEN.IsReservedDecimal = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsReservedDecimal].ToString().Trim()); //是否保留小数
objCurrEduCls4SynchEN.ExamTime = objRow[conCurrEduCls4Synch.ExamTime] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ExamTime].ToString().Trim(); //考试时间
objCurrEduCls4SynchEN.CheckState = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.CheckState].ToString().Trim()); //检查状态
objCurrEduCls4SynchEN.CheckDate = objRow[conCurrEduCls4Synch.CheckDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckDate].ToString().Trim(); //检查日期
objCurrEduCls4SynchEN.IdEduClassInPk = objRow[conCurrEduCls4Synch.IdEduClassInPk] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdEduClassInPk].ToString().Trim(); //id_EduClassInPk
objCurrEduCls4SynchEN.PkWeekTime = objRow[conCurrEduCls4Synch.PkWeekTime] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.PkWeekTime].ToString().Trim(); //排课时间
objCurrEduCls4SynchEN.PkClassRooms = objRow[conCurrEduCls4Synch.PkClassRooms] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.PkClassRooms].ToString().Trim(); //排课教室
objCurrEduCls4SynchEN.BeginWeek = objRow[conCurrEduCls4Synch.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.BeginWeek].ToString().Trim()); //开始周
objCurrEduCls4SynchEN.TeacherNames = objRow[conCurrEduCls4Synch.TeacherNames] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.TeacherNames].ToString().Trim(); //教师姓名
objCurrEduCls4SynchEN.IsAccessSynch = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步
objCurrEduCls4SynchEN.AccessSynchDate = objRow[conCurrEduCls4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期
objCurrEduCls4SynchEN.IsExistEduClsInCurr = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsExistEduClsInCurr].ToString().Trim()); //当前是否存在教学班
objCurrEduCls4SynchEN.ModifyDate = objRow[conCurrEduCls4Synch.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ModifyDate].ToString().Trim(); //修改日期
objCurrEduCls4SynchEN.ModifyUserId = objRow[conCurrEduCls4Synch.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ModifyUserId].ToString().Trim(); //修改人
objCurrEduCls4SynchEN.Memo = objRow[conCurrEduCls4Synch.Memo] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduCls4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduCls4SynchEN);
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
List<clsCurrEduCls4SynchEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsCurrEduCls4SynchEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsCurrEduCls4SynchEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsCurrEduCls4SynchEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsCurrEduCls4SynchEN> arrObjLst = new List<clsCurrEduCls4SynchEN>(); 
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
	clsCurrEduCls4SynchEN objCurrEduCls4SynchEN = new clsCurrEduCls4SynchEN();
try
{
objCurrEduCls4SynchEN.mId = Int32.Parse(objRow[conCurrEduCls4Synch.mId].ToString().Trim()); //mId
objCurrEduCls4SynchEN.IpAddress = objRow[conCurrEduCls4Synch.IpAddress] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IpAddress].ToString().Trim(); //Ip地址
objCurrEduCls4SynchEN.IdCurrEduCls = objRow[conCurrEduCls4Synch.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduCls4SynchEN.CurrEduClsId = objRow[conCurrEduCls4Synch.CurrEduClsId].ToString().Trim(); //教学班Id
objCurrEduCls4SynchEN.EduClsName = objRow[conCurrEduCls4Synch.EduClsName] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.EduClsName].ToString().Trim(); //教学班名
objCurrEduCls4SynchEN.EduClsTypeId = objRow[conCurrEduCls4Synch.EduClsTypeId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.EduClsTypeId].ToString().Trim(); //教学班类型Id
objCurrEduCls4SynchEN.CourseId = objRow[conCurrEduCls4Synch.CourseId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CourseId].ToString().Trim(); //课程Id
objCurrEduCls4SynchEN.TeachingSolutionId = objRow[conCurrEduCls4Synch.TeachingSolutionId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCurrEduCls4SynchEN.IdXzCollege = objRow[conCurrEduCls4Synch.IdXzCollege] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdXzCollege].ToString().Trim(); //学院流水号
objCurrEduCls4SynchEN.IdEduWay = objRow[conCurrEduCls4Synch.IdEduWay] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdEduWay].ToString().Trim(); //教学方式流水号
objCurrEduCls4SynchEN.IdClassRoomType = objRow[conCurrEduCls4Synch.IdClassRoomType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdClassRoomType].ToString().Trim(); //教室类型流水号
objCurrEduCls4SynchEN.TotalLessonQty = objRow[conCurrEduCls4Synch.TotalLessonQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls4Synch.TotalLessonQty].ToString().Trim()); //总课时数
objCurrEduCls4SynchEN.MaxStuQty = objRow[conCurrEduCls4Synch.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls4Synch.MaxStuQty].ToString().Trim()); //最大学生数
objCurrEduCls4SynchEN.CurrentStuQty = objRow[conCurrEduCls4Synch.CurrentStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls4Synch.CurrentStuQty].ToString().Trim()); //当前学生数
objCurrEduCls4SynchEN.WeekQty = objRow[conCurrEduCls4Synch.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls4Synch.WeekQty].ToString().Trim()); //总周数
objCurrEduCls4SynchEN.ScheUnitPW = objRow[conCurrEduCls4Synch.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.ScheUnitPW].ToString().Trim()); //周排课次数
objCurrEduCls4SynchEN.WeekStatusId = objRow[conCurrEduCls4Synch.WeekStatusId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objCurrEduCls4SynchEN.CustomerWeek = objRow[conCurrEduCls4Synch.CustomerWeek] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CustomerWeek].ToString().Trim(); //自定义上课周
objCurrEduCls4SynchEN.IsCompleteScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsCompleteScore].ToString().Trim()); //是否成绩齐全
objCurrEduCls4SynchEN.IdExecPlan = objRow[conCurrEduCls4Synch.IdExecPlan] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdExecPlan].ToString().Trim(); //执行计划流水号
objCurrEduCls4SynchEN.LessonQtyPerWeek = objRow[conCurrEduCls4Synch.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.LessonQtyPerWeek].ToString().Trim()); //周课时数
objCurrEduCls4SynchEN.Mark = objRow[conCurrEduCls4Synch.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduCls4Synch.Mark].ToString().Trim()); //获得学分
objCurrEduCls4SynchEN.CheckClassRoom = objRow[conCurrEduCls4Synch.CheckClassRoom] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckClassRoom].ToString().Trim(); //检查教室结果
objCurrEduCls4SynchEN.CheckAdminCls = objRow[conCurrEduCls4Synch.CheckAdminCls] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckAdminCls].ToString().Trim(); //检查行政班结果
objCurrEduCls4SynchEN.CheckTeacher = objRow[conCurrEduCls4Synch.CheckTeacher] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckTeacher].ToString().Trim(); //检查教师结果
objCurrEduCls4SynchEN.EditLocked = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.EditLocked].ToString().Trim()); //编辑锁定
objCurrEduCls4SynchEN.Sched = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.Sched].ToString().Trim()); //是否排课
objCurrEduCls4SynchEN.IdUniZone = objRow[conCurrEduCls4Synch.IdUniZone] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdUniZone].ToString().Trim(); //校区流水号
objCurrEduCls4SynchEN.Locked = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.Locked].ToString().Trim()); //锁定状态
objCurrEduCls4SynchEN.IdGradeBase = objRow[conCurrEduCls4Synch.IdGradeBase] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdGradeBase].ToString().Trim(); //年级流水号
objCurrEduCls4SynchEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsEffective].ToString().Trim()); //是否有效
objCurrEduCls4SynchEN.IsUnDeterminedClsRm = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsUnDeterminedClsRm].ToString().Trim()); //是否待定教室
objCurrEduCls4SynchEN.SchoolYear = objRow[conCurrEduCls4Synch.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SchoolYear].ToString().Trim(); //学年
objCurrEduCls4SynchEN.SchoolTerm = objRow[conCurrEduCls4Synch.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SchoolTerm].ToString().Trim(); //学期
objCurrEduCls4SynchEN.ArrangeCourseMemo = objRow[conCurrEduCls4Synch.ArrangeCourseMemo] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ArrangeCourseMemo].ToString().Trim(); //排课备注
objCurrEduCls4SynchEN.IdCourseType = objRow[conCurrEduCls4Synch.IdCourseType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdCourseType].ToString().Trim(); //课程类型流水号
objCurrEduCls4SynchEN.ExportDate = objRow[conCurrEduCls4Synch.ExportDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ExportDate].ToString().Trim(); //导出日期
objCurrEduCls4SynchEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsDegree].ToString().Trim()); //是否学位课
objCurrEduCls4SynchEN.IdScoreType = objRow[conCurrEduCls4Synch.IdScoreType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdScoreType].ToString().Trim(); //成绩类型流水号
objCurrEduCls4SynchEN.GetScoreWayId = objRow[conCurrEduCls4Synch.GetScoreWayId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objCurrEduCls4SynchEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objCurrEduCls4SynchEN.IsSynchToWeb = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsSynchToWeb].ToString().Trim()); //是否同步Web
objCurrEduCls4SynchEN.SynchToWebDate = objRow[conCurrEduCls4Synch.SynchToWebDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SynchToWebDate].ToString().Trim(); //同步Web日期
objCurrEduCls4SynchEN.SynchToWebUser = objRow[conCurrEduCls4Synch.SynchToWebUser] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SynchToWebUser].ToString().Trim(); //同步Web用户
objCurrEduCls4SynchEN.SignInDate = objRow[conCurrEduCls4Synch.SignInDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SignInDate].ToString().Trim(); //签入时间
objCurrEduCls4SynchEN.SignInStateID = objRow[conCurrEduCls4Synch.SignInStateID] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SignInStateID].ToString().Trim(); //签入状态表流水号
objCurrEduCls4SynchEN.SignInUser = objRow[conCurrEduCls4Synch.SignInUser] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SignInUser].ToString().Trim(); //签入人
objCurrEduCls4SynchEN.IdExamType = objRow[conCurrEduCls4Synch.IdExamType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdExamType].ToString().Trim(); //考试方式流水号
objCurrEduCls4SynchEN.ExamPortion = objRow[conCurrEduCls4Synch.ExamPortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.ExamPortion].ToString().Trim()); //平时成绩所占比例
objCurrEduCls4SynchEN.MidExamScorePortion = objRow[conCurrEduCls4Synch.MidExamScorePortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.MidExamScorePortion].ToString().Trim()); //期末成绩所占比例
objCurrEduCls4SynchEN.IsClearScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsClearScore].ToString().Trim()); //是否重录成绩
objCurrEduCls4SynchEN.IsGeneratePwd = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsGeneratePwd].ToString().Trim()); //是否生成口令
objCurrEduCls4SynchEN.GeneratePwdDate = objRow[conCurrEduCls4Synch.GeneratePwdDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.GeneratePwdDate].ToString().Trim(); //生成口令时间
objCurrEduCls4SynchEN.IsExportToGP = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsExportToGP].ToString().Trim()); //是否导出到平台
objCurrEduCls4SynchEN.IsExportToGPWeb = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsExportToGPWeb].ToString().Trim()); //是否导出到Web平台
objCurrEduCls4SynchEN.IsReservedDecimal = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsReservedDecimal].ToString().Trim()); //是否保留小数
objCurrEduCls4SynchEN.ExamTime = objRow[conCurrEduCls4Synch.ExamTime] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ExamTime].ToString().Trim(); //考试时间
objCurrEduCls4SynchEN.CheckState = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.CheckState].ToString().Trim()); //检查状态
objCurrEduCls4SynchEN.CheckDate = objRow[conCurrEduCls4Synch.CheckDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckDate].ToString().Trim(); //检查日期
objCurrEduCls4SynchEN.IdEduClassInPk = objRow[conCurrEduCls4Synch.IdEduClassInPk] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdEduClassInPk].ToString().Trim(); //id_EduClassInPk
objCurrEduCls4SynchEN.PkWeekTime = objRow[conCurrEduCls4Synch.PkWeekTime] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.PkWeekTime].ToString().Trim(); //排课时间
objCurrEduCls4SynchEN.PkClassRooms = objRow[conCurrEduCls4Synch.PkClassRooms] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.PkClassRooms].ToString().Trim(); //排课教室
objCurrEduCls4SynchEN.BeginWeek = objRow[conCurrEduCls4Synch.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.BeginWeek].ToString().Trim()); //开始周
objCurrEduCls4SynchEN.TeacherNames = objRow[conCurrEduCls4Synch.TeacherNames] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.TeacherNames].ToString().Trim(); //教师姓名
objCurrEduCls4SynchEN.IsAccessSynch = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步
objCurrEduCls4SynchEN.AccessSynchDate = objRow[conCurrEduCls4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期
objCurrEduCls4SynchEN.IsExistEduClsInCurr = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsExistEduClsInCurr].ToString().Trim()); //当前是否存在教学班
objCurrEduCls4SynchEN.ModifyDate = objRow[conCurrEduCls4Synch.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ModifyDate].ToString().Trim(); //修改日期
objCurrEduCls4SynchEN.ModifyUserId = objRow[conCurrEduCls4Synch.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ModifyUserId].ToString().Trim(); //修改人
objCurrEduCls4SynchEN.Memo = objRow[conCurrEduCls4Synch.Memo] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduCls4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduCls4SynchEN);
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
public static List<clsCurrEduCls4SynchEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsCurrEduCls4SynchEN> arrObjLst = new List<clsCurrEduCls4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduCls4SynchEN objCurrEduCls4SynchEN = new clsCurrEduCls4SynchEN();
try
{
objCurrEduCls4SynchEN.mId = Int32.Parse(objRow[conCurrEduCls4Synch.mId].ToString().Trim()); //mId
objCurrEduCls4SynchEN.IpAddress = objRow[conCurrEduCls4Synch.IpAddress] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IpAddress].ToString().Trim(); //Ip地址
objCurrEduCls4SynchEN.IdCurrEduCls = objRow[conCurrEduCls4Synch.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduCls4SynchEN.CurrEduClsId = objRow[conCurrEduCls4Synch.CurrEduClsId].ToString().Trim(); //教学班Id
objCurrEduCls4SynchEN.EduClsName = objRow[conCurrEduCls4Synch.EduClsName] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.EduClsName].ToString().Trim(); //教学班名
objCurrEduCls4SynchEN.EduClsTypeId = objRow[conCurrEduCls4Synch.EduClsTypeId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.EduClsTypeId].ToString().Trim(); //教学班类型Id
objCurrEduCls4SynchEN.CourseId = objRow[conCurrEduCls4Synch.CourseId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CourseId].ToString().Trim(); //课程Id
objCurrEduCls4SynchEN.TeachingSolutionId = objRow[conCurrEduCls4Synch.TeachingSolutionId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCurrEduCls4SynchEN.IdXzCollege = objRow[conCurrEduCls4Synch.IdXzCollege] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdXzCollege].ToString().Trim(); //学院流水号
objCurrEduCls4SynchEN.IdEduWay = objRow[conCurrEduCls4Synch.IdEduWay] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdEduWay].ToString().Trim(); //教学方式流水号
objCurrEduCls4SynchEN.IdClassRoomType = objRow[conCurrEduCls4Synch.IdClassRoomType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdClassRoomType].ToString().Trim(); //教室类型流水号
objCurrEduCls4SynchEN.TotalLessonQty = objRow[conCurrEduCls4Synch.TotalLessonQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls4Synch.TotalLessonQty].ToString().Trim()); //总课时数
objCurrEduCls4SynchEN.MaxStuQty = objRow[conCurrEduCls4Synch.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls4Synch.MaxStuQty].ToString().Trim()); //最大学生数
objCurrEduCls4SynchEN.CurrentStuQty = objRow[conCurrEduCls4Synch.CurrentStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls4Synch.CurrentStuQty].ToString().Trim()); //当前学生数
objCurrEduCls4SynchEN.WeekQty = objRow[conCurrEduCls4Synch.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls4Synch.WeekQty].ToString().Trim()); //总周数
objCurrEduCls4SynchEN.ScheUnitPW = objRow[conCurrEduCls4Synch.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.ScheUnitPW].ToString().Trim()); //周排课次数
objCurrEduCls4SynchEN.WeekStatusId = objRow[conCurrEduCls4Synch.WeekStatusId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objCurrEduCls4SynchEN.CustomerWeek = objRow[conCurrEduCls4Synch.CustomerWeek] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CustomerWeek].ToString().Trim(); //自定义上课周
objCurrEduCls4SynchEN.IsCompleteScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsCompleteScore].ToString().Trim()); //是否成绩齐全
objCurrEduCls4SynchEN.IdExecPlan = objRow[conCurrEduCls4Synch.IdExecPlan] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdExecPlan].ToString().Trim(); //执行计划流水号
objCurrEduCls4SynchEN.LessonQtyPerWeek = objRow[conCurrEduCls4Synch.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.LessonQtyPerWeek].ToString().Trim()); //周课时数
objCurrEduCls4SynchEN.Mark = objRow[conCurrEduCls4Synch.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduCls4Synch.Mark].ToString().Trim()); //获得学分
objCurrEduCls4SynchEN.CheckClassRoom = objRow[conCurrEduCls4Synch.CheckClassRoom] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckClassRoom].ToString().Trim(); //检查教室结果
objCurrEduCls4SynchEN.CheckAdminCls = objRow[conCurrEduCls4Synch.CheckAdminCls] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckAdminCls].ToString().Trim(); //检查行政班结果
objCurrEduCls4SynchEN.CheckTeacher = objRow[conCurrEduCls4Synch.CheckTeacher] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckTeacher].ToString().Trim(); //检查教师结果
objCurrEduCls4SynchEN.EditLocked = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.EditLocked].ToString().Trim()); //编辑锁定
objCurrEduCls4SynchEN.Sched = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.Sched].ToString().Trim()); //是否排课
objCurrEduCls4SynchEN.IdUniZone = objRow[conCurrEduCls4Synch.IdUniZone] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdUniZone].ToString().Trim(); //校区流水号
objCurrEduCls4SynchEN.Locked = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.Locked].ToString().Trim()); //锁定状态
objCurrEduCls4SynchEN.IdGradeBase = objRow[conCurrEduCls4Synch.IdGradeBase] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdGradeBase].ToString().Trim(); //年级流水号
objCurrEduCls4SynchEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsEffective].ToString().Trim()); //是否有效
objCurrEduCls4SynchEN.IsUnDeterminedClsRm = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsUnDeterminedClsRm].ToString().Trim()); //是否待定教室
objCurrEduCls4SynchEN.SchoolYear = objRow[conCurrEduCls4Synch.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SchoolYear].ToString().Trim(); //学年
objCurrEduCls4SynchEN.SchoolTerm = objRow[conCurrEduCls4Synch.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SchoolTerm].ToString().Trim(); //学期
objCurrEduCls4SynchEN.ArrangeCourseMemo = objRow[conCurrEduCls4Synch.ArrangeCourseMemo] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ArrangeCourseMemo].ToString().Trim(); //排课备注
objCurrEduCls4SynchEN.IdCourseType = objRow[conCurrEduCls4Synch.IdCourseType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdCourseType].ToString().Trim(); //课程类型流水号
objCurrEduCls4SynchEN.ExportDate = objRow[conCurrEduCls4Synch.ExportDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ExportDate].ToString().Trim(); //导出日期
objCurrEduCls4SynchEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsDegree].ToString().Trim()); //是否学位课
objCurrEduCls4SynchEN.IdScoreType = objRow[conCurrEduCls4Synch.IdScoreType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdScoreType].ToString().Trim(); //成绩类型流水号
objCurrEduCls4SynchEN.GetScoreWayId = objRow[conCurrEduCls4Synch.GetScoreWayId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objCurrEduCls4SynchEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objCurrEduCls4SynchEN.IsSynchToWeb = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsSynchToWeb].ToString().Trim()); //是否同步Web
objCurrEduCls4SynchEN.SynchToWebDate = objRow[conCurrEduCls4Synch.SynchToWebDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SynchToWebDate].ToString().Trim(); //同步Web日期
objCurrEduCls4SynchEN.SynchToWebUser = objRow[conCurrEduCls4Synch.SynchToWebUser] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SynchToWebUser].ToString().Trim(); //同步Web用户
objCurrEduCls4SynchEN.SignInDate = objRow[conCurrEduCls4Synch.SignInDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SignInDate].ToString().Trim(); //签入时间
objCurrEduCls4SynchEN.SignInStateID = objRow[conCurrEduCls4Synch.SignInStateID] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SignInStateID].ToString().Trim(); //签入状态表流水号
objCurrEduCls4SynchEN.SignInUser = objRow[conCurrEduCls4Synch.SignInUser] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SignInUser].ToString().Trim(); //签入人
objCurrEduCls4SynchEN.IdExamType = objRow[conCurrEduCls4Synch.IdExamType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdExamType].ToString().Trim(); //考试方式流水号
objCurrEduCls4SynchEN.ExamPortion = objRow[conCurrEduCls4Synch.ExamPortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.ExamPortion].ToString().Trim()); //平时成绩所占比例
objCurrEduCls4SynchEN.MidExamScorePortion = objRow[conCurrEduCls4Synch.MidExamScorePortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.MidExamScorePortion].ToString().Trim()); //期末成绩所占比例
objCurrEduCls4SynchEN.IsClearScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsClearScore].ToString().Trim()); //是否重录成绩
objCurrEduCls4SynchEN.IsGeneratePwd = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsGeneratePwd].ToString().Trim()); //是否生成口令
objCurrEduCls4SynchEN.GeneratePwdDate = objRow[conCurrEduCls4Synch.GeneratePwdDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.GeneratePwdDate].ToString().Trim(); //生成口令时间
objCurrEduCls4SynchEN.IsExportToGP = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsExportToGP].ToString().Trim()); //是否导出到平台
objCurrEduCls4SynchEN.IsExportToGPWeb = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsExportToGPWeb].ToString().Trim()); //是否导出到Web平台
objCurrEduCls4SynchEN.IsReservedDecimal = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsReservedDecimal].ToString().Trim()); //是否保留小数
objCurrEduCls4SynchEN.ExamTime = objRow[conCurrEduCls4Synch.ExamTime] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ExamTime].ToString().Trim(); //考试时间
objCurrEduCls4SynchEN.CheckState = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.CheckState].ToString().Trim()); //检查状态
objCurrEduCls4SynchEN.CheckDate = objRow[conCurrEduCls4Synch.CheckDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckDate].ToString().Trim(); //检查日期
objCurrEduCls4SynchEN.IdEduClassInPk = objRow[conCurrEduCls4Synch.IdEduClassInPk] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdEduClassInPk].ToString().Trim(); //id_EduClassInPk
objCurrEduCls4SynchEN.PkWeekTime = objRow[conCurrEduCls4Synch.PkWeekTime] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.PkWeekTime].ToString().Trim(); //排课时间
objCurrEduCls4SynchEN.PkClassRooms = objRow[conCurrEduCls4Synch.PkClassRooms] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.PkClassRooms].ToString().Trim(); //排课教室
objCurrEduCls4SynchEN.BeginWeek = objRow[conCurrEduCls4Synch.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.BeginWeek].ToString().Trim()); //开始周
objCurrEduCls4SynchEN.TeacherNames = objRow[conCurrEduCls4Synch.TeacherNames] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.TeacherNames].ToString().Trim(); //教师姓名
objCurrEduCls4SynchEN.IsAccessSynch = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步
objCurrEduCls4SynchEN.AccessSynchDate = objRow[conCurrEduCls4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期
objCurrEduCls4SynchEN.IsExistEduClsInCurr = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsExistEduClsInCurr].ToString().Trim()); //当前是否存在教学班
objCurrEduCls4SynchEN.ModifyDate = objRow[conCurrEduCls4Synch.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ModifyDate].ToString().Trim(); //修改日期
objCurrEduCls4SynchEN.ModifyUserId = objRow[conCurrEduCls4Synch.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ModifyUserId].ToString().Trim(); //修改人
objCurrEduCls4SynchEN.Memo = objRow[conCurrEduCls4Synch.Memo] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduCls4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduCls4SynchEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsCurrEduCls4SynchEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsCurrEduCls4SynchEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsCurrEduCls4SynchEN> arrObjLst = new List<clsCurrEduCls4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduCls4SynchEN objCurrEduCls4SynchEN = new clsCurrEduCls4SynchEN();
try
{
objCurrEduCls4SynchEN.mId = Int32.Parse(objRow[conCurrEduCls4Synch.mId].ToString().Trim()); //mId
objCurrEduCls4SynchEN.IpAddress = objRow[conCurrEduCls4Synch.IpAddress] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IpAddress].ToString().Trim(); //Ip地址
objCurrEduCls4SynchEN.IdCurrEduCls = objRow[conCurrEduCls4Synch.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduCls4SynchEN.CurrEduClsId = objRow[conCurrEduCls4Synch.CurrEduClsId].ToString().Trim(); //教学班Id
objCurrEduCls4SynchEN.EduClsName = objRow[conCurrEduCls4Synch.EduClsName] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.EduClsName].ToString().Trim(); //教学班名
objCurrEduCls4SynchEN.EduClsTypeId = objRow[conCurrEduCls4Synch.EduClsTypeId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.EduClsTypeId].ToString().Trim(); //教学班类型Id
objCurrEduCls4SynchEN.CourseId = objRow[conCurrEduCls4Synch.CourseId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CourseId].ToString().Trim(); //课程Id
objCurrEduCls4SynchEN.TeachingSolutionId = objRow[conCurrEduCls4Synch.TeachingSolutionId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCurrEduCls4SynchEN.IdXzCollege = objRow[conCurrEduCls4Synch.IdXzCollege] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdXzCollege].ToString().Trim(); //学院流水号
objCurrEduCls4SynchEN.IdEduWay = objRow[conCurrEduCls4Synch.IdEduWay] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdEduWay].ToString().Trim(); //教学方式流水号
objCurrEduCls4SynchEN.IdClassRoomType = objRow[conCurrEduCls4Synch.IdClassRoomType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdClassRoomType].ToString().Trim(); //教室类型流水号
objCurrEduCls4SynchEN.TotalLessonQty = objRow[conCurrEduCls4Synch.TotalLessonQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls4Synch.TotalLessonQty].ToString().Trim()); //总课时数
objCurrEduCls4SynchEN.MaxStuQty = objRow[conCurrEduCls4Synch.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls4Synch.MaxStuQty].ToString().Trim()); //最大学生数
objCurrEduCls4SynchEN.CurrentStuQty = objRow[conCurrEduCls4Synch.CurrentStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls4Synch.CurrentStuQty].ToString().Trim()); //当前学生数
objCurrEduCls4SynchEN.WeekQty = objRow[conCurrEduCls4Synch.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls4Synch.WeekQty].ToString().Trim()); //总周数
objCurrEduCls4SynchEN.ScheUnitPW = objRow[conCurrEduCls4Synch.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.ScheUnitPW].ToString().Trim()); //周排课次数
objCurrEduCls4SynchEN.WeekStatusId = objRow[conCurrEduCls4Synch.WeekStatusId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objCurrEduCls4SynchEN.CustomerWeek = objRow[conCurrEduCls4Synch.CustomerWeek] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CustomerWeek].ToString().Trim(); //自定义上课周
objCurrEduCls4SynchEN.IsCompleteScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsCompleteScore].ToString().Trim()); //是否成绩齐全
objCurrEduCls4SynchEN.IdExecPlan = objRow[conCurrEduCls4Synch.IdExecPlan] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdExecPlan].ToString().Trim(); //执行计划流水号
objCurrEduCls4SynchEN.LessonQtyPerWeek = objRow[conCurrEduCls4Synch.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.LessonQtyPerWeek].ToString().Trim()); //周课时数
objCurrEduCls4SynchEN.Mark = objRow[conCurrEduCls4Synch.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduCls4Synch.Mark].ToString().Trim()); //获得学分
objCurrEduCls4SynchEN.CheckClassRoom = objRow[conCurrEduCls4Synch.CheckClassRoom] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckClassRoom].ToString().Trim(); //检查教室结果
objCurrEduCls4SynchEN.CheckAdminCls = objRow[conCurrEduCls4Synch.CheckAdminCls] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckAdminCls].ToString().Trim(); //检查行政班结果
objCurrEduCls4SynchEN.CheckTeacher = objRow[conCurrEduCls4Synch.CheckTeacher] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckTeacher].ToString().Trim(); //检查教师结果
objCurrEduCls4SynchEN.EditLocked = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.EditLocked].ToString().Trim()); //编辑锁定
objCurrEduCls4SynchEN.Sched = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.Sched].ToString().Trim()); //是否排课
objCurrEduCls4SynchEN.IdUniZone = objRow[conCurrEduCls4Synch.IdUniZone] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdUniZone].ToString().Trim(); //校区流水号
objCurrEduCls4SynchEN.Locked = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.Locked].ToString().Trim()); //锁定状态
objCurrEduCls4SynchEN.IdGradeBase = objRow[conCurrEduCls4Synch.IdGradeBase] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdGradeBase].ToString().Trim(); //年级流水号
objCurrEduCls4SynchEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsEffective].ToString().Trim()); //是否有效
objCurrEduCls4SynchEN.IsUnDeterminedClsRm = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsUnDeterminedClsRm].ToString().Trim()); //是否待定教室
objCurrEduCls4SynchEN.SchoolYear = objRow[conCurrEduCls4Synch.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SchoolYear].ToString().Trim(); //学年
objCurrEduCls4SynchEN.SchoolTerm = objRow[conCurrEduCls4Synch.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SchoolTerm].ToString().Trim(); //学期
objCurrEduCls4SynchEN.ArrangeCourseMemo = objRow[conCurrEduCls4Synch.ArrangeCourseMemo] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ArrangeCourseMemo].ToString().Trim(); //排课备注
objCurrEduCls4SynchEN.IdCourseType = objRow[conCurrEduCls4Synch.IdCourseType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdCourseType].ToString().Trim(); //课程类型流水号
objCurrEduCls4SynchEN.ExportDate = objRow[conCurrEduCls4Synch.ExportDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ExportDate].ToString().Trim(); //导出日期
objCurrEduCls4SynchEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsDegree].ToString().Trim()); //是否学位课
objCurrEduCls4SynchEN.IdScoreType = objRow[conCurrEduCls4Synch.IdScoreType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdScoreType].ToString().Trim(); //成绩类型流水号
objCurrEduCls4SynchEN.GetScoreWayId = objRow[conCurrEduCls4Synch.GetScoreWayId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objCurrEduCls4SynchEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objCurrEduCls4SynchEN.IsSynchToWeb = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsSynchToWeb].ToString().Trim()); //是否同步Web
objCurrEduCls4SynchEN.SynchToWebDate = objRow[conCurrEduCls4Synch.SynchToWebDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SynchToWebDate].ToString().Trim(); //同步Web日期
objCurrEduCls4SynchEN.SynchToWebUser = objRow[conCurrEduCls4Synch.SynchToWebUser] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SynchToWebUser].ToString().Trim(); //同步Web用户
objCurrEduCls4SynchEN.SignInDate = objRow[conCurrEduCls4Synch.SignInDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SignInDate].ToString().Trim(); //签入时间
objCurrEduCls4SynchEN.SignInStateID = objRow[conCurrEduCls4Synch.SignInStateID] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SignInStateID].ToString().Trim(); //签入状态表流水号
objCurrEduCls4SynchEN.SignInUser = objRow[conCurrEduCls4Synch.SignInUser] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SignInUser].ToString().Trim(); //签入人
objCurrEduCls4SynchEN.IdExamType = objRow[conCurrEduCls4Synch.IdExamType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdExamType].ToString().Trim(); //考试方式流水号
objCurrEduCls4SynchEN.ExamPortion = objRow[conCurrEduCls4Synch.ExamPortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.ExamPortion].ToString().Trim()); //平时成绩所占比例
objCurrEduCls4SynchEN.MidExamScorePortion = objRow[conCurrEduCls4Synch.MidExamScorePortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.MidExamScorePortion].ToString().Trim()); //期末成绩所占比例
objCurrEduCls4SynchEN.IsClearScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsClearScore].ToString().Trim()); //是否重录成绩
objCurrEduCls4SynchEN.IsGeneratePwd = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsGeneratePwd].ToString().Trim()); //是否生成口令
objCurrEduCls4SynchEN.GeneratePwdDate = objRow[conCurrEduCls4Synch.GeneratePwdDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.GeneratePwdDate].ToString().Trim(); //生成口令时间
objCurrEduCls4SynchEN.IsExportToGP = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsExportToGP].ToString().Trim()); //是否导出到平台
objCurrEduCls4SynchEN.IsExportToGPWeb = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsExportToGPWeb].ToString().Trim()); //是否导出到Web平台
objCurrEduCls4SynchEN.IsReservedDecimal = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsReservedDecimal].ToString().Trim()); //是否保留小数
objCurrEduCls4SynchEN.ExamTime = objRow[conCurrEduCls4Synch.ExamTime] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ExamTime].ToString().Trim(); //考试时间
objCurrEduCls4SynchEN.CheckState = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.CheckState].ToString().Trim()); //检查状态
objCurrEduCls4SynchEN.CheckDate = objRow[conCurrEduCls4Synch.CheckDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckDate].ToString().Trim(); //检查日期
objCurrEduCls4SynchEN.IdEduClassInPk = objRow[conCurrEduCls4Synch.IdEduClassInPk] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdEduClassInPk].ToString().Trim(); //id_EduClassInPk
objCurrEduCls4SynchEN.PkWeekTime = objRow[conCurrEduCls4Synch.PkWeekTime] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.PkWeekTime].ToString().Trim(); //排课时间
objCurrEduCls4SynchEN.PkClassRooms = objRow[conCurrEduCls4Synch.PkClassRooms] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.PkClassRooms].ToString().Trim(); //排课教室
objCurrEduCls4SynchEN.BeginWeek = objRow[conCurrEduCls4Synch.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.BeginWeek].ToString().Trim()); //开始周
objCurrEduCls4SynchEN.TeacherNames = objRow[conCurrEduCls4Synch.TeacherNames] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.TeacherNames].ToString().Trim(); //教师姓名
objCurrEduCls4SynchEN.IsAccessSynch = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步
objCurrEduCls4SynchEN.AccessSynchDate = objRow[conCurrEduCls4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期
objCurrEduCls4SynchEN.IsExistEduClsInCurr = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsExistEduClsInCurr].ToString().Trim()); //当前是否存在教学班
objCurrEduCls4SynchEN.ModifyDate = objRow[conCurrEduCls4Synch.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ModifyDate].ToString().Trim(); //修改日期
objCurrEduCls4SynchEN.ModifyUserId = objRow[conCurrEduCls4Synch.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ModifyUserId].ToString().Trim(); //修改人
objCurrEduCls4SynchEN.Memo = objRow[conCurrEduCls4Synch.Memo] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduCls4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduCls4SynchEN);
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
public static List<clsCurrEduCls4SynchEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsCurrEduCls4SynchEN> arrObjLst = new List<clsCurrEduCls4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduCls4SynchEN objCurrEduCls4SynchEN = new clsCurrEduCls4SynchEN();
try
{
objCurrEduCls4SynchEN.mId = Int32.Parse(objRow[conCurrEduCls4Synch.mId].ToString().Trim()); //mId
objCurrEduCls4SynchEN.IpAddress = objRow[conCurrEduCls4Synch.IpAddress] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IpAddress].ToString().Trim(); //Ip地址
objCurrEduCls4SynchEN.IdCurrEduCls = objRow[conCurrEduCls4Synch.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduCls4SynchEN.CurrEduClsId = objRow[conCurrEduCls4Synch.CurrEduClsId].ToString().Trim(); //教学班Id
objCurrEduCls4SynchEN.EduClsName = objRow[conCurrEduCls4Synch.EduClsName] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.EduClsName].ToString().Trim(); //教学班名
objCurrEduCls4SynchEN.EduClsTypeId = objRow[conCurrEduCls4Synch.EduClsTypeId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.EduClsTypeId].ToString().Trim(); //教学班类型Id
objCurrEduCls4SynchEN.CourseId = objRow[conCurrEduCls4Synch.CourseId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CourseId].ToString().Trim(); //课程Id
objCurrEduCls4SynchEN.TeachingSolutionId = objRow[conCurrEduCls4Synch.TeachingSolutionId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCurrEduCls4SynchEN.IdXzCollege = objRow[conCurrEduCls4Synch.IdXzCollege] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdXzCollege].ToString().Trim(); //学院流水号
objCurrEduCls4SynchEN.IdEduWay = objRow[conCurrEduCls4Synch.IdEduWay] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdEduWay].ToString().Trim(); //教学方式流水号
objCurrEduCls4SynchEN.IdClassRoomType = objRow[conCurrEduCls4Synch.IdClassRoomType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdClassRoomType].ToString().Trim(); //教室类型流水号
objCurrEduCls4SynchEN.TotalLessonQty = objRow[conCurrEduCls4Synch.TotalLessonQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls4Synch.TotalLessonQty].ToString().Trim()); //总课时数
objCurrEduCls4SynchEN.MaxStuQty = objRow[conCurrEduCls4Synch.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls4Synch.MaxStuQty].ToString().Trim()); //最大学生数
objCurrEduCls4SynchEN.CurrentStuQty = objRow[conCurrEduCls4Synch.CurrentStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls4Synch.CurrentStuQty].ToString().Trim()); //当前学生数
objCurrEduCls4SynchEN.WeekQty = objRow[conCurrEduCls4Synch.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls4Synch.WeekQty].ToString().Trim()); //总周数
objCurrEduCls4SynchEN.ScheUnitPW = objRow[conCurrEduCls4Synch.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.ScheUnitPW].ToString().Trim()); //周排课次数
objCurrEduCls4SynchEN.WeekStatusId = objRow[conCurrEduCls4Synch.WeekStatusId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objCurrEduCls4SynchEN.CustomerWeek = objRow[conCurrEduCls4Synch.CustomerWeek] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CustomerWeek].ToString().Trim(); //自定义上课周
objCurrEduCls4SynchEN.IsCompleteScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsCompleteScore].ToString().Trim()); //是否成绩齐全
objCurrEduCls4SynchEN.IdExecPlan = objRow[conCurrEduCls4Synch.IdExecPlan] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdExecPlan].ToString().Trim(); //执行计划流水号
objCurrEduCls4SynchEN.LessonQtyPerWeek = objRow[conCurrEduCls4Synch.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.LessonQtyPerWeek].ToString().Trim()); //周课时数
objCurrEduCls4SynchEN.Mark = objRow[conCurrEduCls4Synch.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduCls4Synch.Mark].ToString().Trim()); //获得学分
objCurrEduCls4SynchEN.CheckClassRoom = objRow[conCurrEduCls4Synch.CheckClassRoom] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckClassRoom].ToString().Trim(); //检查教室结果
objCurrEduCls4SynchEN.CheckAdminCls = objRow[conCurrEduCls4Synch.CheckAdminCls] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckAdminCls].ToString().Trim(); //检查行政班结果
objCurrEduCls4SynchEN.CheckTeacher = objRow[conCurrEduCls4Synch.CheckTeacher] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckTeacher].ToString().Trim(); //检查教师结果
objCurrEduCls4SynchEN.EditLocked = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.EditLocked].ToString().Trim()); //编辑锁定
objCurrEduCls4SynchEN.Sched = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.Sched].ToString().Trim()); //是否排课
objCurrEduCls4SynchEN.IdUniZone = objRow[conCurrEduCls4Synch.IdUniZone] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdUniZone].ToString().Trim(); //校区流水号
objCurrEduCls4SynchEN.Locked = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.Locked].ToString().Trim()); //锁定状态
objCurrEduCls4SynchEN.IdGradeBase = objRow[conCurrEduCls4Synch.IdGradeBase] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdGradeBase].ToString().Trim(); //年级流水号
objCurrEduCls4SynchEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsEffective].ToString().Trim()); //是否有效
objCurrEduCls4SynchEN.IsUnDeterminedClsRm = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsUnDeterminedClsRm].ToString().Trim()); //是否待定教室
objCurrEduCls4SynchEN.SchoolYear = objRow[conCurrEduCls4Synch.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SchoolYear].ToString().Trim(); //学年
objCurrEduCls4SynchEN.SchoolTerm = objRow[conCurrEduCls4Synch.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SchoolTerm].ToString().Trim(); //学期
objCurrEduCls4SynchEN.ArrangeCourseMemo = objRow[conCurrEduCls4Synch.ArrangeCourseMemo] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ArrangeCourseMemo].ToString().Trim(); //排课备注
objCurrEduCls4SynchEN.IdCourseType = objRow[conCurrEduCls4Synch.IdCourseType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdCourseType].ToString().Trim(); //课程类型流水号
objCurrEduCls4SynchEN.ExportDate = objRow[conCurrEduCls4Synch.ExportDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ExportDate].ToString().Trim(); //导出日期
objCurrEduCls4SynchEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsDegree].ToString().Trim()); //是否学位课
objCurrEduCls4SynchEN.IdScoreType = objRow[conCurrEduCls4Synch.IdScoreType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdScoreType].ToString().Trim(); //成绩类型流水号
objCurrEduCls4SynchEN.GetScoreWayId = objRow[conCurrEduCls4Synch.GetScoreWayId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objCurrEduCls4SynchEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objCurrEduCls4SynchEN.IsSynchToWeb = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsSynchToWeb].ToString().Trim()); //是否同步Web
objCurrEduCls4SynchEN.SynchToWebDate = objRow[conCurrEduCls4Synch.SynchToWebDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SynchToWebDate].ToString().Trim(); //同步Web日期
objCurrEduCls4SynchEN.SynchToWebUser = objRow[conCurrEduCls4Synch.SynchToWebUser] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SynchToWebUser].ToString().Trim(); //同步Web用户
objCurrEduCls4SynchEN.SignInDate = objRow[conCurrEduCls4Synch.SignInDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SignInDate].ToString().Trim(); //签入时间
objCurrEduCls4SynchEN.SignInStateID = objRow[conCurrEduCls4Synch.SignInStateID] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SignInStateID].ToString().Trim(); //签入状态表流水号
objCurrEduCls4SynchEN.SignInUser = objRow[conCurrEduCls4Synch.SignInUser] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SignInUser].ToString().Trim(); //签入人
objCurrEduCls4SynchEN.IdExamType = objRow[conCurrEduCls4Synch.IdExamType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdExamType].ToString().Trim(); //考试方式流水号
objCurrEduCls4SynchEN.ExamPortion = objRow[conCurrEduCls4Synch.ExamPortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.ExamPortion].ToString().Trim()); //平时成绩所占比例
objCurrEduCls4SynchEN.MidExamScorePortion = objRow[conCurrEduCls4Synch.MidExamScorePortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.MidExamScorePortion].ToString().Trim()); //期末成绩所占比例
objCurrEduCls4SynchEN.IsClearScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsClearScore].ToString().Trim()); //是否重录成绩
objCurrEduCls4SynchEN.IsGeneratePwd = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsGeneratePwd].ToString().Trim()); //是否生成口令
objCurrEduCls4SynchEN.GeneratePwdDate = objRow[conCurrEduCls4Synch.GeneratePwdDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.GeneratePwdDate].ToString().Trim(); //生成口令时间
objCurrEduCls4SynchEN.IsExportToGP = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsExportToGP].ToString().Trim()); //是否导出到平台
objCurrEduCls4SynchEN.IsExportToGPWeb = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsExportToGPWeb].ToString().Trim()); //是否导出到Web平台
objCurrEduCls4SynchEN.IsReservedDecimal = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsReservedDecimal].ToString().Trim()); //是否保留小数
objCurrEduCls4SynchEN.ExamTime = objRow[conCurrEduCls4Synch.ExamTime] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ExamTime].ToString().Trim(); //考试时间
objCurrEduCls4SynchEN.CheckState = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.CheckState].ToString().Trim()); //检查状态
objCurrEduCls4SynchEN.CheckDate = objRow[conCurrEduCls4Synch.CheckDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckDate].ToString().Trim(); //检查日期
objCurrEduCls4SynchEN.IdEduClassInPk = objRow[conCurrEduCls4Synch.IdEduClassInPk] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdEduClassInPk].ToString().Trim(); //id_EduClassInPk
objCurrEduCls4SynchEN.PkWeekTime = objRow[conCurrEduCls4Synch.PkWeekTime] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.PkWeekTime].ToString().Trim(); //排课时间
objCurrEduCls4SynchEN.PkClassRooms = objRow[conCurrEduCls4Synch.PkClassRooms] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.PkClassRooms].ToString().Trim(); //排课教室
objCurrEduCls4SynchEN.BeginWeek = objRow[conCurrEduCls4Synch.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.BeginWeek].ToString().Trim()); //开始周
objCurrEduCls4SynchEN.TeacherNames = objRow[conCurrEduCls4Synch.TeacherNames] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.TeacherNames].ToString().Trim(); //教师姓名
objCurrEduCls4SynchEN.IsAccessSynch = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步
objCurrEduCls4SynchEN.AccessSynchDate = objRow[conCurrEduCls4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期
objCurrEduCls4SynchEN.IsExistEduClsInCurr = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsExistEduClsInCurr].ToString().Trim()); //当前是否存在教学班
objCurrEduCls4SynchEN.ModifyDate = objRow[conCurrEduCls4Synch.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ModifyDate].ToString().Trim(); //修改日期
objCurrEduCls4SynchEN.ModifyUserId = objRow[conCurrEduCls4Synch.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ModifyUserId].ToString().Trim(); //修改人
objCurrEduCls4SynchEN.Memo = objRow[conCurrEduCls4Synch.Memo] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduCls4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduCls4SynchEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsCurrEduCls4SynchEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsCurrEduCls4SynchEN> arrObjLst = new List<clsCurrEduCls4SynchEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduCls4SynchEN objCurrEduCls4SynchEN = new clsCurrEduCls4SynchEN();
try
{
objCurrEduCls4SynchEN.mId = Int32.Parse(objRow[conCurrEduCls4Synch.mId].ToString().Trim()); //mId
objCurrEduCls4SynchEN.IpAddress = objRow[conCurrEduCls4Synch.IpAddress] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IpAddress].ToString().Trim(); //Ip地址
objCurrEduCls4SynchEN.IdCurrEduCls = objRow[conCurrEduCls4Synch.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduCls4SynchEN.CurrEduClsId = objRow[conCurrEduCls4Synch.CurrEduClsId].ToString().Trim(); //教学班Id
objCurrEduCls4SynchEN.EduClsName = objRow[conCurrEduCls4Synch.EduClsName] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.EduClsName].ToString().Trim(); //教学班名
objCurrEduCls4SynchEN.EduClsTypeId = objRow[conCurrEduCls4Synch.EduClsTypeId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.EduClsTypeId].ToString().Trim(); //教学班类型Id
objCurrEduCls4SynchEN.CourseId = objRow[conCurrEduCls4Synch.CourseId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CourseId].ToString().Trim(); //课程Id
objCurrEduCls4SynchEN.TeachingSolutionId = objRow[conCurrEduCls4Synch.TeachingSolutionId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCurrEduCls4SynchEN.IdXzCollege = objRow[conCurrEduCls4Synch.IdXzCollege] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdXzCollege].ToString().Trim(); //学院流水号
objCurrEduCls4SynchEN.IdEduWay = objRow[conCurrEduCls4Synch.IdEduWay] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdEduWay].ToString().Trim(); //教学方式流水号
objCurrEduCls4SynchEN.IdClassRoomType = objRow[conCurrEduCls4Synch.IdClassRoomType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdClassRoomType].ToString().Trim(); //教室类型流水号
objCurrEduCls4SynchEN.TotalLessonQty = objRow[conCurrEduCls4Synch.TotalLessonQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls4Synch.TotalLessonQty].ToString().Trim()); //总课时数
objCurrEduCls4SynchEN.MaxStuQty = objRow[conCurrEduCls4Synch.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls4Synch.MaxStuQty].ToString().Trim()); //最大学生数
objCurrEduCls4SynchEN.CurrentStuQty = objRow[conCurrEduCls4Synch.CurrentStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls4Synch.CurrentStuQty].ToString().Trim()); //当前学生数
objCurrEduCls4SynchEN.WeekQty = objRow[conCurrEduCls4Synch.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls4Synch.WeekQty].ToString().Trim()); //总周数
objCurrEduCls4SynchEN.ScheUnitPW = objRow[conCurrEduCls4Synch.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.ScheUnitPW].ToString().Trim()); //周排课次数
objCurrEduCls4SynchEN.WeekStatusId = objRow[conCurrEduCls4Synch.WeekStatusId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objCurrEduCls4SynchEN.CustomerWeek = objRow[conCurrEduCls4Synch.CustomerWeek] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CustomerWeek].ToString().Trim(); //自定义上课周
objCurrEduCls4SynchEN.IsCompleteScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsCompleteScore].ToString().Trim()); //是否成绩齐全
objCurrEduCls4SynchEN.IdExecPlan = objRow[conCurrEduCls4Synch.IdExecPlan] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdExecPlan].ToString().Trim(); //执行计划流水号
objCurrEduCls4SynchEN.LessonQtyPerWeek = objRow[conCurrEduCls4Synch.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.LessonQtyPerWeek].ToString().Trim()); //周课时数
objCurrEduCls4SynchEN.Mark = objRow[conCurrEduCls4Synch.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduCls4Synch.Mark].ToString().Trim()); //获得学分
objCurrEduCls4SynchEN.CheckClassRoom = objRow[conCurrEduCls4Synch.CheckClassRoom] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckClassRoom].ToString().Trim(); //检查教室结果
objCurrEduCls4SynchEN.CheckAdminCls = objRow[conCurrEduCls4Synch.CheckAdminCls] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckAdminCls].ToString().Trim(); //检查行政班结果
objCurrEduCls4SynchEN.CheckTeacher = objRow[conCurrEduCls4Synch.CheckTeacher] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckTeacher].ToString().Trim(); //检查教师结果
objCurrEduCls4SynchEN.EditLocked = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.EditLocked].ToString().Trim()); //编辑锁定
objCurrEduCls4SynchEN.Sched = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.Sched].ToString().Trim()); //是否排课
objCurrEduCls4SynchEN.IdUniZone = objRow[conCurrEduCls4Synch.IdUniZone] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdUniZone].ToString().Trim(); //校区流水号
objCurrEduCls4SynchEN.Locked = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.Locked].ToString().Trim()); //锁定状态
objCurrEduCls4SynchEN.IdGradeBase = objRow[conCurrEduCls4Synch.IdGradeBase] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdGradeBase].ToString().Trim(); //年级流水号
objCurrEduCls4SynchEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsEffective].ToString().Trim()); //是否有效
objCurrEduCls4SynchEN.IsUnDeterminedClsRm = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsUnDeterminedClsRm].ToString().Trim()); //是否待定教室
objCurrEduCls4SynchEN.SchoolYear = objRow[conCurrEduCls4Synch.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SchoolYear].ToString().Trim(); //学年
objCurrEduCls4SynchEN.SchoolTerm = objRow[conCurrEduCls4Synch.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SchoolTerm].ToString().Trim(); //学期
objCurrEduCls4SynchEN.ArrangeCourseMemo = objRow[conCurrEduCls4Synch.ArrangeCourseMemo] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ArrangeCourseMemo].ToString().Trim(); //排课备注
objCurrEduCls4SynchEN.IdCourseType = objRow[conCurrEduCls4Synch.IdCourseType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdCourseType].ToString().Trim(); //课程类型流水号
objCurrEduCls4SynchEN.ExportDate = objRow[conCurrEduCls4Synch.ExportDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ExportDate].ToString().Trim(); //导出日期
objCurrEduCls4SynchEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsDegree].ToString().Trim()); //是否学位课
objCurrEduCls4SynchEN.IdScoreType = objRow[conCurrEduCls4Synch.IdScoreType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdScoreType].ToString().Trim(); //成绩类型流水号
objCurrEduCls4SynchEN.GetScoreWayId = objRow[conCurrEduCls4Synch.GetScoreWayId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objCurrEduCls4SynchEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objCurrEduCls4SynchEN.IsSynchToWeb = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsSynchToWeb].ToString().Trim()); //是否同步Web
objCurrEduCls4SynchEN.SynchToWebDate = objRow[conCurrEduCls4Synch.SynchToWebDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SynchToWebDate].ToString().Trim(); //同步Web日期
objCurrEduCls4SynchEN.SynchToWebUser = objRow[conCurrEduCls4Synch.SynchToWebUser] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SynchToWebUser].ToString().Trim(); //同步Web用户
objCurrEduCls4SynchEN.SignInDate = objRow[conCurrEduCls4Synch.SignInDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SignInDate].ToString().Trim(); //签入时间
objCurrEduCls4SynchEN.SignInStateID = objRow[conCurrEduCls4Synch.SignInStateID] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SignInStateID].ToString().Trim(); //签入状态表流水号
objCurrEduCls4SynchEN.SignInUser = objRow[conCurrEduCls4Synch.SignInUser] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.SignInUser].ToString().Trim(); //签入人
objCurrEduCls4SynchEN.IdExamType = objRow[conCurrEduCls4Synch.IdExamType] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdExamType].ToString().Trim(); //考试方式流水号
objCurrEduCls4SynchEN.ExamPortion = objRow[conCurrEduCls4Synch.ExamPortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.ExamPortion].ToString().Trim()); //平时成绩所占比例
objCurrEduCls4SynchEN.MidExamScorePortion = objRow[conCurrEduCls4Synch.MidExamScorePortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.MidExamScorePortion].ToString().Trim()); //期末成绩所占比例
objCurrEduCls4SynchEN.IsClearScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsClearScore].ToString().Trim()); //是否重录成绩
objCurrEduCls4SynchEN.IsGeneratePwd = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsGeneratePwd].ToString().Trim()); //是否生成口令
objCurrEduCls4SynchEN.GeneratePwdDate = objRow[conCurrEduCls4Synch.GeneratePwdDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.GeneratePwdDate].ToString().Trim(); //生成口令时间
objCurrEduCls4SynchEN.IsExportToGP = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsExportToGP].ToString().Trim()); //是否导出到平台
objCurrEduCls4SynchEN.IsExportToGPWeb = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsExportToGPWeb].ToString().Trim()); //是否导出到Web平台
objCurrEduCls4SynchEN.IsReservedDecimal = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsReservedDecimal].ToString().Trim()); //是否保留小数
objCurrEduCls4SynchEN.ExamTime = objRow[conCurrEduCls4Synch.ExamTime] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ExamTime].ToString().Trim(); //考试时间
objCurrEduCls4SynchEN.CheckState = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.CheckState].ToString().Trim()); //检查状态
objCurrEduCls4SynchEN.CheckDate = objRow[conCurrEduCls4Synch.CheckDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.CheckDate].ToString().Trim(); //检查日期
objCurrEduCls4SynchEN.IdEduClassInPk = objRow[conCurrEduCls4Synch.IdEduClassInPk] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.IdEduClassInPk].ToString().Trim(); //id_EduClassInPk
objCurrEduCls4SynchEN.PkWeekTime = objRow[conCurrEduCls4Synch.PkWeekTime] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.PkWeekTime].ToString().Trim(); //排课时间
objCurrEduCls4SynchEN.PkClassRooms = objRow[conCurrEduCls4Synch.PkClassRooms] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.PkClassRooms].ToString().Trim(); //排课教室
objCurrEduCls4SynchEN.BeginWeek = objRow[conCurrEduCls4Synch.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls4Synch.BeginWeek].ToString().Trim()); //开始周
objCurrEduCls4SynchEN.TeacherNames = objRow[conCurrEduCls4Synch.TeacherNames] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.TeacherNames].ToString().Trim(); //教师姓名
objCurrEduCls4SynchEN.IsAccessSynch = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步
objCurrEduCls4SynchEN.AccessSynchDate = objRow[conCurrEduCls4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期
objCurrEduCls4SynchEN.IsExistEduClsInCurr = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls4Synch.IsExistEduClsInCurr].ToString().Trim()); //当前是否存在教学班
objCurrEduCls4SynchEN.ModifyDate = objRow[conCurrEduCls4Synch.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ModifyDate].ToString().Trim(); //修改日期
objCurrEduCls4SynchEN.ModifyUserId = objRow[conCurrEduCls4Synch.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.ModifyUserId].ToString().Trim(); //修改人
objCurrEduCls4SynchEN.Memo = objRow[conCurrEduCls4Synch.Memo] == DBNull.Value ? null : objRow[conCurrEduCls4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduCls4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduCls4SynchEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetCurrEduCls4Synch(ref clsCurrEduCls4SynchEN objCurrEduCls4SynchEN)
{
bool bolResult = CurrEduCls4SynchDA.GetCurrEduCls4Synch(ref objCurrEduCls4SynchEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCurrEduCls4SynchEN GetObjBymId(long lngmId)
{
clsCurrEduCls4SynchEN objCurrEduCls4SynchEN = CurrEduCls4SynchDA.GetObjBymId(lngmId);
return objCurrEduCls4SynchEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsCurrEduCls4SynchEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsCurrEduCls4SynchEN objCurrEduCls4SynchEN = CurrEduCls4SynchDA.GetFirstObj(strWhereCond);
 return objCurrEduCls4SynchEN;
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
public static clsCurrEduCls4SynchEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsCurrEduCls4SynchEN objCurrEduCls4SynchEN = CurrEduCls4SynchDA.GetObjByDataRow(objRow);
 return objCurrEduCls4SynchEN;
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
public static clsCurrEduCls4SynchEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsCurrEduCls4SynchEN objCurrEduCls4SynchEN = CurrEduCls4SynchDA.GetObjByDataRow(objRow);
 return objCurrEduCls4SynchEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "lstCurrEduCls4SynchObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCurrEduCls4SynchEN GetObjBymIdFromList(long lngmId, List<clsCurrEduCls4SynchEN> lstCurrEduCls4SynchObjLst)
{
foreach (clsCurrEduCls4SynchEN objCurrEduCls4SynchEN in lstCurrEduCls4SynchObjLst)
{
if (objCurrEduCls4SynchEN.mId == lngmId)
{
return objCurrEduCls4SynchEN;
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
 long lngmId;
 try
 {
 lngmId = new clsCurrEduCls4SynchDA().GetFirstID(strWhereCond);
 return lngmId;
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
 arrList = CurrEduCls4SynchDA.GetID(strWhereCond);
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
bool bolIsExist = CurrEduCls4SynchDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
bool bolIsExist = CurrEduCls4SynchDA.IsExist(lngmId);
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
 bolIsExist = clsCurrEduCls4SynchDA.IsExistTable();
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
 bolIsExist = CurrEduCls4SynchDA.IsExistTable(strTabName);
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
 /// <param name = "objCurrEduCls4SynchEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objCurrEduCls4SynchEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!教学班流水号 = [{0}],Ip地址 = [{1}]的数据已经存在!(in clsCurrEduCls4SynchBL.AddNewRecordBySql2)", objCurrEduCls4SynchEN.IdCurrEduCls,objCurrEduCls4SynchEN.IpAddress);
throw new Exception(strMsg);
}
try
{
bool bolResult = CurrEduCls4SynchDA.AddNewRecordBySQL2(objCurrEduCls4SynchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduCls4SynchBL.ReFreshCache();

if (clsCurrEduCls4SynchBL.relatedActions != null)
{
clsCurrEduCls4SynchBL.relatedActions.UpdRelaTabDate(objCurrEduCls4SynchEN.mId, "SetUpdDate");
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
 /// <param name = "objCurrEduCls4SynchEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objCurrEduCls4SynchEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!教学班流水号 = [{0}],Ip地址 = [{1}]的数据已经存在!(in clsCurrEduCls4SynchBL.AddNewRecordBySql2WithReturnKey)", objCurrEduCls4SynchEN.IdCurrEduCls,objCurrEduCls4SynchEN.IpAddress);
throw new Exception(strMsg);
}
try
{
string strKey = CurrEduCls4SynchDA.AddNewRecordBySQL2WithReturnKey(objCurrEduCls4SynchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduCls4SynchBL.ReFreshCache();

if (clsCurrEduCls4SynchBL.relatedActions != null)
{
clsCurrEduCls4SynchBL.relatedActions.UpdRelaTabDate(objCurrEduCls4SynchEN.mId, "SetUpdDate");
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
 /// <param name = "objCurrEduCls4SynchEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsCurrEduCls4SynchEN objCurrEduCls4SynchEN)
{
try
{
bool bolResult = CurrEduCls4SynchDA.Update(objCurrEduCls4SynchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduCls4SynchBL.ReFreshCache();

if (clsCurrEduCls4SynchBL.relatedActions != null)
{
clsCurrEduCls4SynchBL.relatedActions.UpdRelaTabDate(objCurrEduCls4SynchEN.mId, "SetUpdDate");
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
 /// <param name = "objCurrEduCls4SynchEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsCurrEduCls4SynchEN objCurrEduCls4SynchEN)
{
 if (objCurrEduCls4SynchEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = CurrEduCls4SynchDA.UpdateBySql2(objCurrEduCls4SynchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduCls4SynchBL.ReFreshCache();

if (clsCurrEduCls4SynchBL.relatedActions != null)
{
clsCurrEduCls4SynchBL.relatedActions.UpdRelaTabDate(objCurrEduCls4SynchEN.mId, "SetUpdDate");
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngmId)
{
try
{
 clsCurrEduCls4SynchEN objCurrEduCls4SynchEN = clsCurrEduCls4SynchBL.GetObjBymId(lngmId);

if (clsCurrEduCls4SynchBL.relatedActions != null)
{
clsCurrEduCls4SynchBL.relatedActions.UpdRelaTabDate(objCurrEduCls4SynchEN.mId, "SetUpdDate");
}
if (objCurrEduCls4SynchEN != null)
{
int intRecNum = CurrEduCls4SynchDA.DelRecord(lngmId);
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
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngmId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCurrEduCls4SynchDA.GetSpecSQLObj();
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
//删除与表:[CurrEduCls4Synch]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conCurrEduCls4Synch.mId,
//lngmId);
//        clsCurrEduCls4SynchBL.DelCurrEduCls4SynchsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCurrEduCls4SynchBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCurrEduCls4SynchBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngmId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngmId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsCurrEduCls4SynchBL.relatedActions != null)
{
clsCurrEduCls4SynchBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = CurrEduCls4SynchDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrmIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelCurrEduCls4Synchs(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsCurrEduCls4SynchBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsCurrEduCls4SynchBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = CurrEduCls4SynchDA.DelCurrEduCls4Synch(arrmIdLst);
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
public static int DelCurrEduCls4SynchsByCond(string strWhereCond)
{
try
{
if (clsCurrEduCls4SynchBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsCurrEduCls4SynchBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = CurrEduCls4SynchDA.DelCurrEduCls4Synch(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[CurrEduCls4Synch]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCurrEduCls4SynchDA.GetSpecSQLObj();
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
//删除与表:[CurrEduCls4Synch]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCurrEduCls4SynchBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCurrEduCls4SynchBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngmId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objCurrEduCls4SynchENS">源对象</param>
 /// <param name = "objCurrEduCls4SynchENT">目标对象</param>
 public static void CopyTo(clsCurrEduCls4SynchEN objCurrEduCls4SynchENS, clsCurrEduCls4SynchEN objCurrEduCls4SynchENT)
{
try
{
objCurrEduCls4SynchENT.mId = objCurrEduCls4SynchENS.mId; //mId
objCurrEduCls4SynchENT.IpAddress = objCurrEduCls4SynchENS.IpAddress; //Ip地址
objCurrEduCls4SynchENT.IdCurrEduCls = objCurrEduCls4SynchENS.IdCurrEduCls; //教学班流水号
objCurrEduCls4SynchENT.CurrEduClsId = objCurrEduCls4SynchENS.CurrEduClsId; //教学班Id
objCurrEduCls4SynchENT.EduClsName = objCurrEduCls4SynchENS.EduClsName; //教学班名
objCurrEduCls4SynchENT.EduClsTypeId = objCurrEduCls4SynchENS.EduClsTypeId; //教学班类型Id
objCurrEduCls4SynchENT.CourseId = objCurrEduCls4SynchENS.CourseId; //课程Id
objCurrEduCls4SynchENT.TeachingSolutionId = objCurrEduCls4SynchENS.TeachingSolutionId; //教学方案Id
objCurrEduCls4SynchENT.IdXzCollege = objCurrEduCls4SynchENS.IdXzCollege; //学院流水号
objCurrEduCls4SynchENT.IdEduWay = objCurrEduCls4SynchENS.IdEduWay; //教学方式流水号
objCurrEduCls4SynchENT.IdClassRoomType = objCurrEduCls4SynchENS.IdClassRoomType; //教室类型流水号
objCurrEduCls4SynchENT.TotalLessonQty = objCurrEduCls4SynchENS.TotalLessonQty; //总课时数
objCurrEduCls4SynchENT.MaxStuQty = objCurrEduCls4SynchENS.MaxStuQty; //最大学生数
objCurrEduCls4SynchENT.CurrentStuQty = objCurrEduCls4SynchENS.CurrentStuQty; //当前学生数
objCurrEduCls4SynchENT.WeekQty = objCurrEduCls4SynchENS.WeekQty; //总周数
objCurrEduCls4SynchENT.ScheUnitPW = objCurrEduCls4SynchENS.ScheUnitPW; //周排课次数
objCurrEduCls4SynchENT.WeekStatusId = objCurrEduCls4SynchENS.WeekStatusId; //周状态编号(单,双,全周)
objCurrEduCls4SynchENT.CustomerWeek = objCurrEduCls4SynchENS.CustomerWeek; //自定义上课周
objCurrEduCls4SynchENT.IsCompleteScore = objCurrEduCls4SynchENS.IsCompleteScore; //是否成绩齐全
objCurrEduCls4SynchENT.IdExecPlan = objCurrEduCls4SynchENS.IdExecPlan; //执行计划流水号
objCurrEduCls4SynchENT.LessonQtyPerWeek = objCurrEduCls4SynchENS.LessonQtyPerWeek; //周课时数
objCurrEduCls4SynchENT.Mark = objCurrEduCls4SynchENS.Mark; //获得学分
objCurrEduCls4SynchENT.CheckClassRoom = objCurrEduCls4SynchENS.CheckClassRoom; //检查教室结果
objCurrEduCls4SynchENT.CheckAdminCls = objCurrEduCls4SynchENS.CheckAdminCls; //检查行政班结果
objCurrEduCls4SynchENT.CheckTeacher = objCurrEduCls4SynchENS.CheckTeacher; //检查教师结果
objCurrEduCls4SynchENT.EditLocked = objCurrEduCls4SynchENS.EditLocked; //编辑锁定
objCurrEduCls4SynchENT.Sched = objCurrEduCls4SynchENS.Sched; //是否排课
objCurrEduCls4SynchENT.IdUniZone = objCurrEduCls4SynchENS.IdUniZone; //校区流水号
objCurrEduCls4SynchENT.Locked = objCurrEduCls4SynchENS.Locked; //锁定状态
objCurrEduCls4SynchENT.IdGradeBase = objCurrEduCls4SynchENS.IdGradeBase; //年级流水号
objCurrEduCls4SynchENT.IsEffective = objCurrEduCls4SynchENS.IsEffective; //是否有效
objCurrEduCls4SynchENT.IsUnDeterminedClsRm = objCurrEduCls4SynchENS.IsUnDeterminedClsRm; //是否待定教室
objCurrEduCls4SynchENT.SchoolYear = objCurrEduCls4SynchENS.SchoolYear; //学年
objCurrEduCls4SynchENT.SchoolTerm = objCurrEduCls4SynchENS.SchoolTerm; //学期
objCurrEduCls4SynchENT.ArrangeCourseMemo = objCurrEduCls4SynchENS.ArrangeCourseMemo; //排课备注
objCurrEduCls4SynchENT.IdCourseType = objCurrEduCls4SynchENS.IdCourseType; //课程类型流水号
objCurrEduCls4SynchENT.ExportDate = objCurrEduCls4SynchENS.ExportDate; //导出日期
objCurrEduCls4SynchENT.IsDegree = objCurrEduCls4SynchENS.IsDegree; //是否学位课
objCurrEduCls4SynchENT.IdScoreType = objCurrEduCls4SynchENS.IdScoreType; //成绩类型流水号
objCurrEduCls4SynchENT.GetScoreWayId = objCurrEduCls4SynchENS.GetScoreWayId; //获得成绩方式Id
objCurrEduCls4SynchENT.IsProportionalCtrl = objCurrEduCls4SynchENS.IsProportionalCtrl; //是否比例控制
objCurrEduCls4SynchENT.IsSynchToWeb = objCurrEduCls4SynchENS.IsSynchToWeb; //是否同步Web
objCurrEduCls4SynchENT.SynchToWebDate = objCurrEduCls4SynchENS.SynchToWebDate; //同步Web日期
objCurrEduCls4SynchENT.SynchToWebUser = objCurrEduCls4SynchENS.SynchToWebUser; //同步Web用户
objCurrEduCls4SynchENT.SignInDate = objCurrEduCls4SynchENS.SignInDate; //签入时间
objCurrEduCls4SynchENT.SignInStateID = objCurrEduCls4SynchENS.SignInStateID; //签入状态表流水号
objCurrEduCls4SynchENT.SignInUser = objCurrEduCls4SynchENS.SignInUser; //签入人
objCurrEduCls4SynchENT.IdExamType = objCurrEduCls4SynchENS.IdExamType; //考试方式流水号
objCurrEduCls4SynchENT.ExamPortion = objCurrEduCls4SynchENS.ExamPortion; //平时成绩所占比例
objCurrEduCls4SynchENT.MidExamScorePortion = objCurrEduCls4SynchENS.MidExamScorePortion; //期末成绩所占比例
objCurrEduCls4SynchENT.IsClearScore = objCurrEduCls4SynchENS.IsClearScore; //是否重录成绩
objCurrEduCls4SynchENT.IsGeneratePwd = objCurrEduCls4SynchENS.IsGeneratePwd; //是否生成口令
objCurrEduCls4SynchENT.GeneratePwdDate = objCurrEduCls4SynchENS.GeneratePwdDate; //生成口令时间
objCurrEduCls4SynchENT.IsExportToGP = objCurrEduCls4SynchENS.IsExportToGP; //是否导出到平台
objCurrEduCls4SynchENT.IsExportToGPWeb = objCurrEduCls4SynchENS.IsExportToGPWeb; //是否导出到Web平台
objCurrEduCls4SynchENT.IsReservedDecimal = objCurrEduCls4SynchENS.IsReservedDecimal; //是否保留小数
objCurrEduCls4SynchENT.ExamTime = objCurrEduCls4SynchENS.ExamTime; //考试时间
objCurrEduCls4SynchENT.CheckState = objCurrEduCls4SynchENS.CheckState; //检查状态
objCurrEduCls4SynchENT.CheckDate = objCurrEduCls4SynchENS.CheckDate; //检查日期
objCurrEduCls4SynchENT.IdEduClassInPk = objCurrEduCls4SynchENS.IdEduClassInPk; //id_EduClassInPk
objCurrEduCls4SynchENT.PkWeekTime = objCurrEduCls4SynchENS.PkWeekTime; //排课时间
objCurrEduCls4SynchENT.PkClassRooms = objCurrEduCls4SynchENS.PkClassRooms; //排课教室
objCurrEduCls4SynchENT.BeginWeek = objCurrEduCls4SynchENS.BeginWeek; //开始周
objCurrEduCls4SynchENT.TeacherNames = objCurrEduCls4SynchENS.TeacherNames; //教师姓名
objCurrEduCls4SynchENT.IsAccessSynch = objCurrEduCls4SynchENS.IsAccessSynch; //是否处理同步
objCurrEduCls4SynchENT.AccessSynchDate = objCurrEduCls4SynchENS.AccessSynchDate; //处理同步日期
objCurrEduCls4SynchENT.IsExistEduClsInCurr = objCurrEduCls4SynchENS.IsExistEduClsInCurr; //当前是否存在教学班
objCurrEduCls4SynchENT.ModifyDate = objCurrEduCls4SynchENS.ModifyDate; //修改日期
objCurrEduCls4SynchENT.ModifyUserId = objCurrEduCls4SynchENS.ModifyUserId; //修改人
objCurrEduCls4SynchENT.Memo = objCurrEduCls4SynchENS.Memo; //备注
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
 /// <param name = "objCurrEduCls4SynchEN">源简化对象</param>
 public static void SetUpdFlag(clsCurrEduCls4SynchEN objCurrEduCls4SynchEN)
{
try
{
objCurrEduCls4SynchEN.ClearUpdateState();
   string strsfUpdFldSetStr = objCurrEduCls4SynchEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conCurrEduCls4Synch.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.mId = objCurrEduCls4SynchEN.mId; //mId
}
if (arrFldSet.Contains(conCurrEduCls4Synch.IpAddress, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.IpAddress = objCurrEduCls4SynchEN.IpAddress == "[null]" ? null :  objCurrEduCls4SynchEN.IpAddress; //Ip地址
}
if (arrFldSet.Contains(conCurrEduCls4Synch.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.IdCurrEduCls = objCurrEduCls4SynchEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conCurrEduCls4Synch.CurrEduClsId, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.CurrEduClsId = objCurrEduCls4SynchEN.CurrEduClsId; //教学班Id
}
if (arrFldSet.Contains(conCurrEduCls4Synch.EduClsName, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.EduClsName = objCurrEduCls4SynchEN.EduClsName == "[null]" ? null :  objCurrEduCls4SynchEN.EduClsName; //教学班名
}
if (arrFldSet.Contains(conCurrEduCls4Synch.EduClsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.EduClsTypeId = objCurrEduCls4SynchEN.EduClsTypeId == "[null]" ? null :  objCurrEduCls4SynchEN.EduClsTypeId; //教学班类型Id
}
if (arrFldSet.Contains(conCurrEduCls4Synch.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.CourseId = objCurrEduCls4SynchEN.CourseId == "[null]" ? null :  objCurrEduCls4SynchEN.CourseId; //课程Id
}
if (arrFldSet.Contains(conCurrEduCls4Synch.TeachingSolutionId, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.TeachingSolutionId = objCurrEduCls4SynchEN.TeachingSolutionId == "[null]" ? null :  objCurrEduCls4SynchEN.TeachingSolutionId; //教学方案Id
}
if (arrFldSet.Contains(conCurrEduCls4Synch.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.IdXzCollege = objCurrEduCls4SynchEN.IdXzCollege == "[null]" ? null :  objCurrEduCls4SynchEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(conCurrEduCls4Synch.IdEduWay, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.IdEduWay = objCurrEduCls4SynchEN.IdEduWay == "[null]" ? null :  objCurrEduCls4SynchEN.IdEduWay; //教学方式流水号
}
if (arrFldSet.Contains(conCurrEduCls4Synch.IdClassRoomType, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.IdClassRoomType = objCurrEduCls4SynchEN.IdClassRoomType == "[null]" ? null :  objCurrEduCls4SynchEN.IdClassRoomType; //教室类型流水号
}
if (arrFldSet.Contains(conCurrEduCls4Synch.TotalLessonQty, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.TotalLessonQty = objCurrEduCls4SynchEN.TotalLessonQty; //总课时数
}
if (arrFldSet.Contains(conCurrEduCls4Synch.MaxStuQty, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.MaxStuQty = objCurrEduCls4SynchEN.MaxStuQty; //最大学生数
}
if (arrFldSet.Contains(conCurrEduCls4Synch.CurrentStuQty, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.CurrentStuQty = objCurrEduCls4SynchEN.CurrentStuQty; //当前学生数
}
if (arrFldSet.Contains(conCurrEduCls4Synch.WeekQty, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.WeekQty = objCurrEduCls4SynchEN.WeekQty; //总周数
}
if (arrFldSet.Contains(conCurrEduCls4Synch.ScheUnitPW, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.ScheUnitPW = objCurrEduCls4SynchEN.ScheUnitPW; //周排课次数
}
if (arrFldSet.Contains(conCurrEduCls4Synch.WeekStatusId, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.WeekStatusId = objCurrEduCls4SynchEN.WeekStatusId == "[null]" ? null :  objCurrEduCls4SynchEN.WeekStatusId; //周状态编号(单,双,全周)
}
if (arrFldSet.Contains(conCurrEduCls4Synch.CustomerWeek, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.CustomerWeek = objCurrEduCls4SynchEN.CustomerWeek == "[null]" ? null :  objCurrEduCls4SynchEN.CustomerWeek; //自定义上课周
}
if (arrFldSet.Contains(conCurrEduCls4Synch.IsCompleteScore, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.IsCompleteScore = objCurrEduCls4SynchEN.IsCompleteScore; //是否成绩齐全
}
if (arrFldSet.Contains(conCurrEduCls4Synch.IdExecPlan, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.IdExecPlan = objCurrEduCls4SynchEN.IdExecPlan == "[null]" ? null :  objCurrEduCls4SynchEN.IdExecPlan; //执行计划流水号
}
if (arrFldSet.Contains(conCurrEduCls4Synch.LessonQtyPerWeek, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.LessonQtyPerWeek = objCurrEduCls4SynchEN.LessonQtyPerWeek; //周课时数
}
if (arrFldSet.Contains(conCurrEduCls4Synch.Mark, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.Mark = objCurrEduCls4SynchEN.Mark; //获得学分
}
if (arrFldSet.Contains(conCurrEduCls4Synch.CheckClassRoom, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.CheckClassRoom = objCurrEduCls4SynchEN.CheckClassRoom == "[null]" ? null :  objCurrEduCls4SynchEN.CheckClassRoom; //检查教室结果
}
if (arrFldSet.Contains(conCurrEduCls4Synch.CheckAdminCls, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.CheckAdminCls = objCurrEduCls4SynchEN.CheckAdminCls == "[null]" ? null :  objCurrEduCls4SynchEN.CheckAdminCls; //检查行政班结果
}
if (arrFldSet.Contains(conCurrEduCls4Synch.CheckTeacher, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.CheckTeacher = objCurrEduCls4SynchEN.CheckTeacher == "[null]" ? null :  objCurrEduCls4SynchEN.CheckTeacher; //检查教师结果
}
if (arrFldSet.Contains(conCurrEduCls4Synch.EditLocked, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.EditLocked = objCurrEduCls4SynchEN.EditLocked; //编辑锁定
}
if (arrFldSet.Contains(conCurrEduCls4Synch.Sched, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.Sched = objCurrEduCls4SynchEN.Sched; //是否排课
}
if (arrFldSet.Contains(conCurrEduCls4Synch.IdUniZone, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.IdUniZone = objCurrEduCls4SynchEN.IdUniZone == "[null]" ? null :  objCurrEduCls4SynchEN.IdUniZone; //校区流水号
}
if (arrFldSet.Contains(conCurrEduCls4Synch.Locked, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.Locked = objCurrEduCls4SynchEN.Locked; //锁定状态
}
if (arrFldSet.Contains(conCurrEduCls4Synch.IdGradeBase, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.IdGradeBase = objCurrEduCls4SynchEN.IdGradeBase == "[null]" ? null :  objCurrEduCls4SynchEN.IdGradeBase; //年级流水号
}
if (arrFldSet.Contains(conCurrEduCls4Synch.IsEffective, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.IsEffective = objCurrEduCls4SynchEN.IsEffective; //是否有效
}
if (arrFldSet.Contains(conCurrEduCls4Synch.IsUnDeterminedClsRm, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.IsUnDeterminedClsRm = objCurrEduCls4SynchEN.IsUnDeterminedClsRm; //是否待定教室
}
if (arrFldSet.Contains(conCurrEduCls4Synch.SchoolYear, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.SchoolYear = objCurrEduCls4SynchEN.SchoolYear == "[null]" ? null :  objCurrEduCls4SynchEN.SchoolYear; //学年
}
if (arrFldSet.Contains(conCurrEduCls4Synch.SchoolTerm, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.SchoolTerm = objCurrEduCls4SynchEN.SchoolTerm == "[null]" ? null :  objCurrEduCls4SynchEN.SchoolTerm; //学期
}
if (arrFldSet.Contains(conCurrEduCls4Synch.ArrangeCourseMemo, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.ArrangeCourseMemo = objCurrEduCls4SynchEN.ArrangeCourseMemo == "[null]" ? null :  objCurrEduCls4SynchEN.ArrangeCourseMemo; //排课备注
}
if (arrFldSet.Contains(conCurrEduCls4Synch.IdCourseType, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.IdCourseType = objCurrEduCls4SynchEN.IdCourseType == "[null]" ? null :  objCurrEduCls4SynchEN.IdCourseType; //课程类型流水号
}
if (arrFldSet.Contains(conCurrEduCls4Synch.ExportDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.ExportDate = objCurrEduCls4SynchEN.ExportDate == "[null]" ? null :  objCurrEduCls4SynchEN.ExportDate; //导出日期
}
if (arrFldSet.Contains(conCurrEduCls4Synch.IsDegree, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.IsDegree = objCurrEduCls4SynchEN.IsDegree; //是否学位课
}
if (arrFldSet.Contains(conCurrEduCls4Synch.IdScoreType, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.IdScoreType = objCurrEduCls4SynchEN.IdScoreType == "[null]" ? null :  objCurrEduCls4SynchEN.IdScoreType; //成绩类型流水号
}
if (arrFldSet.Contains(conCurrEduCls4Synch.GetScoreWayId, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.GetScoreWayId = objCurrEduCls4SynchEN.GetScoreWayId == "[null]" ? null :  objCurrEduCls4SynchEN.GetScoreWayId; //获得成绩方式Id
}
if (arrFldSet.Contains(conCurrEduCls4Synch.IsProportionalCtrl, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.IsProportionalCtrl = objCurrEduCls4SynchEN.IsProportionalCtrl; //是否比例控制
}
if (arrFldSet.Contains(conCurrEduCls4Synch.IsSynchToWeb, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.IsSynchToWeb = objCurrEduCls4SynchEN.IsSynchToWeb; //是否同步Web
}
if (arrFldSet.Contains(conCurrEduCls4Synch.SynchToWebDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.SynchToWebDate = objCurrEduCls4SynchEN.SynchToWebDate == "[null]" ? null :  objCurrEduCls4SynchEN.SynchToWebDate; //同步Web日期
}
if (arrFldSet.Contains(conCurrEduCls4Synch.SynchToWebUser, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.SynchToWebUser = objCurrEduCls4SynchEN.SynchToWebUser == "[null]" ? null :  objCurrEduCls4SynchEN.SynchToWebUser; //同步Web用户
}
if (arrFldSet.Contains(conCurrEduCls4Synch.SignInDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.SignInDate = objCurrEduCls4SynchEN.SignInDate == "[null]" ? null :  objCurrEduCls4SynchEN.SignInDate; //签入时间
}
if (arrFldSet.Contains(conCurrEduCls4Synch.SignInStateID, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.SignInStateID = objCurrEduCls4SynchEN.SignInStateID == "[null]" ? null :  objCurrEduCls4SynchEN.SignInStateID; //签入状态表流水号
}
if (arrFldSet.Contains(conCurrEduCls4Synch.SignInUser, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.SignInUser = objCurrEduCls4SynchEN.SignInUser == "[null]" ? null :  objCurrEduCls4SynchEN.SignInUser; //签入人
}
if (arrFldSet.Contains(conCurrEduCls4Synch.IdExamType, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.IdExamType = objCurrEduCls4SynchEN.IdExamType == "[null]" ? null :  objCurrEduCls4SynchEN.IdExamType; //考试方式流水号
}
if (arrFldSet.Contains(conCurrEduCls4Synch.ExamPortion, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.ExamPortion = objCurrEduCls4SynchEN.ExamPortion; //平时成绩所占比例
}
if (arrFldSet.Contains(conCurrEduCls4Synch.MidExamScorePortion, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.MidExamScorePortion = objCurrEduCls4SynchEN.MidExamScorePortion; //期末成绩所占比例
}
if (arrFldSet.Contains(conCurrEduCls4Synch.IsClearScore, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.IsClearScore = objCurrEduCls4SynchEN.IsClearScore; //是否重录成绩
}
if (arrFldSet.Contains(conCurrEduCls4Synch.IsGeneratePwd, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.IsGeneratePwd = objCurrEduCls4SynchEN.IsGeneratePwd; //是否生成口令
}
if (arrFldSet.Contains(conCurrEduCls4Synch.GeneratePwdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.GeneratePwdDate = objCurrEduCls4SynchEN.GeneratePwdDate == "[null]" ? null :  objCurrEduCls4SynchEN.GeneratePwdDate; //生成口令时间
}
if (arrFldSet.Contains(conCurrEduCls4Synch.IsExportToGP, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.IsExportToGP = objCurrEduCls4SynchEN.IsExportToGP; //是否导出到平台
}
if (arrFldSet.Contains(conCurrEduCls4Synch.IsExportToGPWeb, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.IsExportToGPWeb = objCurrEduCls4SynchEN.IsExportToGPWeb; //是否导出到Web平台
}
if (arrFldSet.Contains(conCurrEduCls4Synch.IsReservedDecimal, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.IsReservedDecimal = objCurrEduCls4SynchEN.IsReservedDecimal; //是否保留小数
}
if (arrFldSet.Contains(conCurrEduCls4Synch.ExamTime, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.ExamTime = objCurrEduCls4SynchEN.ExamTime == "[null]" ? null :  objCurrEduCls4SynchEN.ExamTime; //考试时间
}
if (arrFldSet.Contains(conCurrEduCls4Synch.CheckState, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.CheckState = objCurrEduCls4SynchEN.CheckState; //检查状态
}
if (arrFldSet.Contains(conCurrEduCls4Synch.CheckDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.CheckDate = objCurrEduCls4SynchEN.CheckDate == "[null]" ? null :  objCurrEduCls4SynchEN.CheckDate; //检查日期
}
if (arrFldSet.Contains(conCurrEduCls4Synch.IdEduClassInPk, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.IdEduClassInPk = objCurrEduCls4SynchEN.IdEduClassInPk == "[null]" ? null :  objCurrEduCls4SynchEN.IdEduClassInPk; //id_EduClassInPk
}
if (arrFldSet.Contains(conCurrEduCls4Synch.PkWeekTime, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.PkWeekTime = objCurrEduCls4SynchEN.PkWeekTime == "[null]" ? null :  objCurrEduCls4SynchEN.PkWeekTime; //排课时间
}
if (arrFldSet.Contains(conCurrEduCls4Synch.PkClassRooms, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.PkClassRooms = objCurrEduCls4SynchEN.PkClassRooms == "[null]" ? null :  objCurrEduCls4SynchEN.PkClassRooms; //排课教室
}
if (arrFldSet.Contains(conCurrEduCls4Synch.BeginWeek, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.BeginWeek = objCurrEduCls4SynchEN.BeginWeek; //开始周
}
if (arrFldSet.Contains(conCurrEduCls4Synch.TeacherNames, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.TeacherNames = objCurrEduCls4SynchEN.TeacherNames == "[null]" ? null :  objCurrEduCls4SynchEN.TeacherNames; //教师姓名
}
if (arrFldSet.Contains(conCurrEduCls4Synch.IsAccessSynch, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.IsAccessSynch = objCurrEduCls4SynchEN.IsAccessSynch; //是否处理同步
}
if (arrFldSet.Contains(conCurrEduCls4Synch.AccessSynchDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.AccessSynchDate = objCurrEduCls4SynchEN.AccessSynchDate == "[null]" ? null :  objCurrEduCls4SynchEN.AccessSynchDate; //处理同步日期
}
if (arrFldSet.Contains(conCurrEduCls4Synch.IsExistEduClsInCurr, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.IsExistEduClsInCurr = objCurrEduCls4SynchEN.IsExistEduClsInCurr; //当前是否存在教学班
}
if (arrFldSet.Contains(conCurrEduCls4Synch.ModifyDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.ModifyDate = objCurrEduCls4SynchEN.ModifyDate == "[null]" ? null :  objCurrEduCls4SynchEN.ModifyDate; //修改日期
}
if (arrFldSet.Contains(conCurrEduCls4Synch.ModifyUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.ModifyUserId = objCurrEduCls4SynchEN.ModifyUserId == "[null]" ? null :  objCurrEduCls4SynchEN.ModifyUserId; //修改人
}
if (arrFldSet.Contains(conCurrEduCls4Synch.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduCls4SynchEN.Memo = objCurrEduCls4SynchEN.Memo == "[null]" ? null :  objCurrEduCls4SynchEN.Memo; //备注
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
 /// <param name = "objCurrEduCls4SynchEN">源简化对象</param>
 public static void AccessFldValueNull(clsCurrEduCls4SynchEN objCurrEduCls4SynchEN)
{
try
{
if (objCurrEduCls4SynchEN.IpAddress == "[null]") objCurrEduCls4SynchEN.IpAddress = null; //Ip地址
if (objCurrEduCls4SynchEN.EduClsName == "[null]") objCurrEduCls4SynchEN.EduClsName = null; //教学班名
if (objCurrEduCls4SynchEN.EduClsTypeId == "[null]") objCurrEduCls4SynchEN.EduClsTypeId = null; //教学班类型Id
if (objCurrEduCls4SynchEN.CourseId == "[null]") objCurrEduCls4SynchEN.CourseId = null; //课程Id
if (objCurrEduCls4SynchEN.TeachingSolutionId == "[null]") objCurrEduCls4SynchEN.TeachingSolutionId = null; //教学方案Id
if (objCurrEduCls4SynchEN.IdXzCollege == "[null]") objCurrEduCls4SynchEN.IdXzCollege = null; //学院流水号
if (objCurrEduCls4SynchEN.IdEduWay == "[null]") objCurrEduCls4SynchEN.IdEduWay = null; //教学方式流水号
if (objCurrEduCls4SynchEN.IdClassRoomType == "[null]") objCurrEduCls4SynchEN.IdClassRoomType = null; //教室类型流水号
if (objCurrEduCls4SynchEN.WeekStatusId == "[null]") objCurrEduCls4SynchEN.WeekStatusId = null; //周状态编号(单,双,全周)
if (objCurrEduCls4SynchEN.CustomerWeek == "[null]") objCurrEduCls4SynchEN.CustomerWeek = null; //自定义上课周
if (objCurrEduCls4SynchEN.IdExecPlan == "[null]") objCurrEduCls4SynchEN.IdExecPlan = null; //执行计划流水号
if (objCurrEduCls4SynchEN.CheckClassRoom == "[null]") objCurrEduCls4SynchEN.CheckClassRoom = null; //检查教室结果
if (objCurrEduCls4SynchEN.CheckAdminCls == "[null]") objCurrEduCls4SynchEN.CheckAdminCls = null; //检查行政班结果
if (objCurrEduCls4SynchEN.CheckTeacher == "[null]") objCurrEduCls4SynchEN.CheckTeacher = null; //检查教师结果
if (objCurrEduCls4SynchEN.IdUniZone == "[null]") objCurrEduCls4SynchEN.IdUniZone = null; //校区流水号
if (objCurrEduCls4SynchEN.IdGradeBase == "[null]") objCurrEduCls4SynchEN.IdGradeBase = null; //年级流水号
if (objCurrEduCls4SynchEN.SchoolYear == "[null]") objCurrEduCls4SynchEN.SchoolYear = null; //学年
if (objCurrEduCls4SynchEN.SchoolTerm == "[null]") objCurrEduCls4SynchEN.SchoolTerm = null; //学期
if (objCurrEduCls4SynchEN.ArrangeCourseMemo == "[null]") objCurrEduCls4SynchEN.ArrangeCourseMemo = null; //排课备注
if (objCurrEduCls4SynchEN.IdCourseType == "[null]") objCurrEduCls4SynchEN.IdCourseType = null; //课程类型流水号
if (objCurrEduCls4SynchEN.ExportDate == "[null]") objCurrEduCls4SynchEN.ExportDate = null; //导出日期
if (objCurrEduCls4SynchEN.IdScoreType == "[null]") objCurrEduCls4SynchEN.IdScoreType = null; //成绩类型流水号
if (objCurrEduCls4SynchEN.GetScoreWayId == "[null]") objCurrEduCls4SynchEN.GetScoreWayId = null; //获得成绩方式Id
if (objCurrEduCls4SynchEN.SynchToWebDate == "[null]") objCurrEduCls4SynchEN.SynchToWebDate = null; //同步Web日期
if (objCurrEduCls4SynchEN.SynchToWebUser == "[null]") objCurrEduCls4SynchEN.SynchToWebUser = null; //同步Web用户
if (objCurrEduCls4SynchEN.SignInDate == "[null]") objCurrEduCls4SynchEN.SignInDate = null; //签入时间
if (objCurrEduCls4SynchEN.SignInStateID == "[null]") objCurrEduCls4SynchEN.SignInStateID = null; //签入状态表流水号
if (objCurrEduCls4SynchEN.SignInUser == "[null]") objCurrEduCls4SynchEN.SignInUser = null; //签入人
if (objCurrEduCls4SynchEN.IdExamType == "[null]") objCurrEduCls4SynchEN.IdExamType = null; //考试方式流水号
if (objCurrEduCls4SynchEN.GeneratePwdDate == "[null]") objCurrEduCls4SynchEN.GeneratePwdDate = null; //生成口令时间
if (objCurrEduCls4SynchEN.ExamTime == "[null]") objCurrEduCls4SynchEN.ExamTime = null; //考试时间
if (objCurrEduCls4SynchEN.CheckDate == "[null]") objCurrEduCls4SynchEN.CheckDate = null; //检查日期
if (objCurrEduCls4SynchEN.IdEduClassInPk == "[null]") objCurrEduCls4SynchEN.IdEduClassInPk = null; //id_EduClassInPk
if (objCurrEduCls4SynchEN.PkWeekTime == "[null]") objCurrEduCls4SynchEN.PkWeekTime = null; //排课时间
if (objCurrEduCls4SynchEN.PkClassRooms == "[null]") objCurrEduCls4SynchEN.PkClassRooms = null; //排课教室
if (objCurrEduCls4SynchEN.TeacherNames == "[null]") objCurrEduCls4SynchEN.TeacherNames = null; //教师姓名
if (objCurrEduCls4SynchEN.AccessSynchDate == "[null]") objCurrEduCls4SynchEN.AccessSynchDate = null; //处理同步日期
if (objCurrEduCls4SynchEN.ModifyDate == "[null]") objCurrEduCls4SynchEN.ModifyDate = null; //修改日期
if (objCurrEduCls4SynchEN.ModifyUserId == "[null]") objCurrEduCls4SynchEN.ModifyUserId = null; //修改人
if (objCurrEduCls4SynchEN.Memo == "[null]") objCurrEduCls4SynchEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsCurrEduCls4SynchEN objCurrEduCls4SynchEN)
{
 CurrEduCls4SynchDA.CheckPropertyNew(objCurrEduCls4SynchEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsCurrEduCls4SynchEN objCurrEduCls4SynchEN)
{
 CurrEduCls4SynchDA.CheckProperty4Condition(objCurrEduCls4SynchEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_mId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conCurrEduCls4Synch.mId); 
List<clsCurrEduCls4SynchEN> arrObjLst = clsCurrEduCls4SynchBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsCurrEduCls4SynchEN objCurrEduCls4SynchEN = new clsCurrEduCls4SynchEN()
{
mId = 0,
EduClsName = "选[当前教学班_同步]..."
};
arrObjLst.Insert(0, objCurrEduCls4SynchEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conCurrEduCls4Synch.mId;
objComboBox.DisplayMember = conCurrEduCls4Synch.EduClsName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_mId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[当前教学班_同步]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conCurrEduCls4Synch.mId); 
IEnumerable<clsCurrEduCls4SynchEN> arrObjLst = clsCurrEduCls4SynchBL.GetObjLst(strCondition);
objDDL.DataValueField = conCurrEduCls4Synch.mId;
objDDL.DataTextField = conCurrEduCls4Synch.EduClsName;
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
public static void BindDdl_mIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[当前教学班_同步]...","0");
List<clsCurrEduCls4SynchEN> arrCurrEduCls4SynchObjLst = GetAllCurrEduCls4SynchObjLstCache(); 
objDDL.DataValueField = conCurrEduCls4Synch.mId;
objDDL.DataTextField = conCurrEduCls4Synch.EduClsName;
objDDL.DataSource = arrCurrEduCls4SynchObjLst;
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
if (clsCurrEduCls4SynchBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCurrEduCls4SynchBL没有刷新缓存机制(clsCurrEduCls4SynchBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrCurrEduCls4SynchObjLstCache == null)
//{
//arrCurrEduCls4SynchObjLstCache = CurrEduCls4SynchDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCurrEduCls4SynchEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsCurrEduCls4SynchEN._CurrTabName);
List<clsCurrEduCls4SynchEN> arrCurrEduCls4SynchObjLstCache = GetObjLstCache();
IEnumerable <clsCurrEduCls4SynchEN> arrCurrEduCls4SynchObjLst_Sel =
arrCurrEduCls4SynchObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrCurrEduCls4SynchObjLst_Sel.Count() == 0)
{
   clsCurrEduCls4SynchEN obj = clsCurrEduCls4SynchBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrCurrEduCls4SynchObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetEduClsNameBymIdCache(long lngmId)
{
//获取缓存中的对象列表
clsCurrEduCls4SynchEN objCurrEduCls4Synch = GetObjBymIdCache(lngmId);
if (objCurrEduCls4Synch == null) return "";
return objCurrEduCls4Synch.EduClsName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameBymIdCache(long lngmId)
{
//获取缓存中的对象列表
clsCurrEduCls4SynchEN objCurrEduCls4Synch = GetObjBymIdCache(lngmId);
if (objCurrEduCls4Synch == null) return "";
return objCurrEduCls4Synch.EduClsName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCurrEduCls4SynchEN> GetAllCurrEduCls4SynchObjLstCache()
{
//获取缓存中的对象列表
List<clsCurrEduCls4SynchEN> arrCurrEduCls4SynchObjLstCache = GetObjLstCache(); 
return arrCurrEduCls4SynchObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCurrEduCls4SynchEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsCurrEduCls4SynchEN._CurrTabName);
List<clsCurrEduCls4SynchEN> arrCurrEduCls4SynchObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrCurrEduCls4SynchObjLstCache;
}

 /// <summary>
 /// 根据分类字段获取缓存中对象列表的子集,根据:CourseId字段
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubSet4ObjLst)
 /// </summary>
 /// <param name = "parrCurrEduCls4SynchObjLst">需要排序的对象列表</param>
public static List <clsCurrEduCls4SynchEN> GetSubSet4CurrEduCls4SynchObjLstByCourseIdCache(string strCourseId)
{
   if (string.IsNullOrEmpty(strCourseId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsCurrEduCls4SynchEN._CurrTabName);
List<clsCurrEduCls4SynchEN> arrCurrEduCls4SynchObjLstCache = GetObjLstCache();
IEnumerable <clsCurrEduCls4SynchEN> arrCurrEduCls4SynchObjLst_Sel1 =
from objCurrEduCls4SynchEN in arrCurrEduCls4SynchObjLstCache
where objCurrEduCls4SynchEN.CourseId == strCourseId
select objCurrEduCls4SynchEN;
List <clsCurrEduCls4SynchEN> arrCurrEduCls4SynchObjLst_Sel = new List<clsCurrEduCls4SynchEN>();
foreach (clsCurrEduCls4SynchEN obj in arrCurrEduCls4SynchObjLst_Sel1)
{
arrCurrEduCls4SynchObjLst_Sel.Add(obj);
}
return arrCurrEduCls4SynchObjLst_Sel;
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
string strKey = string.Format("{0}", clsCurrEduCls4SynchEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCurrEduCls4SynchEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsCurrEduCls4SynchEN._RefreshTimeLst.Count == 0) return "";
return clsCurrEduCls4SynchEN._RefreshTimeLst[clsCurrEduCls4SynchEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsCurrEduCls4SynchBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCurrEduCls4SynchEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCurrEduCls4SynchEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsCurrEduCls4SynchBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--CurrEduCls4Synch(当前教学班_同步)
 /// 唯一性条件:id_CurrEduCls_IpAddress
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsCurrEduCls4SynchEN objCurrEduCls4SynchEN)
{
//检测记录是否存在
string strResult = CurrEduCls4SynchDA.GetUniCondStr(objCurrEduCls4SynchEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != conCurrEduCls4Synch.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conCurrEduCls4Synch.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conCurrEduCls4Synch.AttributeName));
throw new Exception(strMsg);
}
var objCurrEduCls4Synch = clsCurrEduCls4SynchBL.GetObjBymIdCache(lngmId);
if (objCurrEduCls4Synch == null) return "";
return objCurrEduCls4Synch[strOutFldName].ToString();
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
int intRecCount = clsCurrEduCls4SynchDA.GetRecCount(strTabName);
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
int intRecCount = clsCurrEduCls4SynchDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsCurrEduCls4SynchDA.GetRecCount();
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
int intRecCount = clsCurrEduCls4SynchDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsCurrEduCls4SynchEN objCurrEduCls4SynchCond)
{
List<clsCurrEduCls4SynchEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsCurrEduCls4SynchEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCurrEduCls4Synch.AttributeName)
{
if (objCurrEduCls4SynchCond.IsUpdated(strFldName) == false) continue;
if (objCurrEduCls4SynchCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCurrEduCls4SynchCond[strFldName].ToString());
}
else
{
if (objCurrEduCls4SynchCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCurrEduCls4SynchCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCurrEduCls4SynchCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCurrEduCls4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCurrEduCls4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCurrEduCls4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCurrEduCls4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCurrEduCls4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCurrEduCls4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCurrEduCls4SynchCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCurrEduCls4SynchCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCurrEduCls4SynchCond[strFldName]));
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
 List<string> arrList = clsCurrEduCls4SynchDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = CurrEduCls4SynchDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = CurrEduCls4SynchDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = CurrEduCls4SynchDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsCurrEduCls4SynchDA.SetFldValue(clsCurrEduCls4SynchEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = CurrEduCls4SynchDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsCurrEduCls4SynchDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsCurrEduCls4SynchDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsCurrEduCls4SynchDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[CurrEduCls4Synch] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**Ip地址*/ 
 strCreateTabCode.Append(" IpAddress varchar(50) Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) not Null, "); 
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
 // /**是否同步Web*/ 
 strCreateTabCode.Append(" IsSynchToWeb bit Null, "); 
 // /**同步Web日期*/ 
 strCreateTabCode.Append(" SynchToWebDate varchar(20) Null, "); 
 // /**同步Web用户*/ 
 strCreateTabCode.Append(" SynchToWebUser varchar(18) Null, "); 
 // /**签入时间*/ 
 strCreateTabCode.Append(" SignInDate varchar(20) Null, "); 
 // /**签入状态表流水号*/ 
 strCreateTabCode.Append(" SignInStateID char(2) Null, "); 
 // /**签入人*/ 
 strCreateTabCode.Append(" SignInUser varchar(18) Null, "); 
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
 // /**是否处理同步*/ 
 strCreateTabCode.Append(" IsAccessSynch bit Null, "); 
 // /**处理同步日期*/ 
 strCreateTabCode.Append(" AccessSynchDate varchar(14) Null, "); 
 // /**当前是否存在教学班*/ 
 strCreateTabCode.Append(" IsExistEduClsInCurr bit Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" ModifyDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" ModifyUserId varchar(18) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 当前教学班_同步(CurrEduCls4Synch)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4CurrEduCls4Synch : clsCommFun4BL
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
clsCurrEduCls4SynchBL.ReFreshThisCache();
}
}

}