
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_TotalDataStatisticsBL
 表名:vgs_TotalDataStatistics(01120682)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:02:20
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培设置(GradEduTools)
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
public static class  clsvgs_TotalDataStatisticsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strTotalDataId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvgs_TotalDataStatisticsEN GetObj(this K_TotalDataId_vgs_TotalDataStatistics myKey)
{
clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsEN = clsvgs_TotalDataStatisticsBL.vgs_TotalDataStatisticsDA.GetObjByTotalDataId(myKey.Value);
return objvgs_TotalDataStatisticsEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TotalDataStatisticsEN SetTotalDataId(this clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsEN, string strTotalDataId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTotalDataId, 12, convgs_TotalDataStatistics.TotalDataId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTotalDataId, 12, convgs_TotalDataStatistics.TotalDataId);
}
objvgs_TotalDataStatisticsEN.TotalDataId = strTotalDataId; //TotalDataId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(convgs_TotalDataStatistics.TotalDataId) == false)
{
objvgs_TotalDataStatisticsEN.dicFldComparisonOp.Add(convgs_TotalDataStatistics.TotalDataId, strComparisonOp);
}
else
{
objvgs_TotalDataStatisticsEN.dicFldComparisonOp[convgs_TotalDataStatistics.TotalDataId] = strComparisonOp;
}
}
return objvgs_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TotalDataStatisticsEN SetIdCurrEduCls(this clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsEN, string strIdCurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdCurrEduCls, convgs_TotalDataStatistics.IdCurrEduCls);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convgs_TotalDataStatistics.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convgs_TotalDataStatistics.IdCurrEduCls);
}
objvgs_TotalDataStatisticsEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(convgs_TotalDataStatistics.IdCurrEduCls) == false)
{
objvgs_TotalDataStatisticsEN.dicFldComparisonOp.Add(convgs_TotalDataStatistics.IdCurrEduCls, strComparisonOp);
}
else
{
objvgs_TotalDataStatisticsEN.dicFldComparisonOp[convgs_TotalDataStatistics.IdCurrEduCls] = strComparisonOp;
}
}
return objvgs_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TotalDataStatisticsEN SetEduClsName(this clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsEN, string strEduClsName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduClsName, 100, convgs_TotalDataStatistics.EduClsName);
}
objvgs_TotalDataStatisticsEN.EduClsName = strEduClsName; //教学班名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(convgs_TotalDataStatistics.EduClsName) == false)
{
objvgs_TotalDataStatisticsEN.dicFldComparisonOp.Add(convgs_TotalDataStatistics.EduClsName, strComparisonOp);
}
else
{
objvgs_TotalDataStatisticsEN.dicFldComparisonOp[convgs_TotalDataStatistics.EduClsName] = strComparisonOp;
}
}
return objvgs_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TotalDataStatisticsEN SetSchoolYear(this clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsEN, string strSchoolYear, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, convgs_TotalDataStatistics.SchoolYear);
}
objvgs_TotalDataStatisticsEN.SchoolYear = strSchoolYear; //学年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(convgs_TotalDataStatistics.SchoolYear) == false)
{
objvgs_TotalDataStatisticsEN.dicFldComparisonOp.Add(convgs_TotalDataStatistics.SchoolYear, strComparisonOp);
}
else
{
objvgs_TotalDataStatisticsEN.dicFldComparisonOp[convgs_TotalDataStatistics.SchoolYear] = strComparisonOp;
}
}
return objvgs_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TotalDataStatisticsEN SetTotalDataTypeId(this clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsEN, string strTotalDataTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTotalDataTypeId, convgs_TotalDataStatistics.TotalDataTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTotalDataTypeId, 2, convgs_TotalDataStatistics.TotalDataTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTotalDataTypeId, 2, convgs_TotalDataStatistics.TotalDataTypeId);
}
objvgs_TotalDataStatisticsEN.TotalDataTypeId = strTotalDataTypeId; //总数据类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(convgs_TotalDataStatistics.TotalDataTypeId) == false)
{
objvgs_TotalDataStatisticsEN.dicFldComparisonOp.Add(convgs_TotalDataStatistics.TotalDataTypeId, strComparisonOp);
}
else
{
objvgs_TotalDataStatisticsEN.dicFldComparisonOp[convgs_TotalDataStatistics.TotalDataTypeId] = strComparisonOp;
}
}
return objvgs_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TotalDataStatisticsEN SetSchoolTerm(this clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsEN, string strSchoolTerm, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, convgs_TotalDataStatistics.SchoolTerm);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, convgs_TotalDataStatistics.SchoolTerm);
}
objvgs_TotalDataStatisticsEN.SchoolTerm = strSchoolTerm; //学期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(convgs_TotalDataStatistics.SchoolTerm) == false)
{
objvgs_TotalDataStatisticsEN.dicFldComparisonOp.Add(convgs_TotalDataStatistics.SchoolTerm, strComparisonOp);
}
else
{
objvgs_TotalDataStatisticsEN.dicFldComparisonOp[convgs_TotalDataStatistics.SchoolTerm] = strComparisonOp;
}
}
return objvgs_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TotalDataStatisticsEN SetTableKey(this clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsEN, string strTableKey, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTableKey, 20, convgs_TotalDataStatistics.TableKey);
}
objvgs_TotalDataStatisticsEN.TableKey = strTableKey; //表主键
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(convgs_TotalDataStatistics.TableKey) == false)
{
objvgs_TotalDataStatisticsEN.dicFldComparisonOp.Add(convgs_TotalDataStatistics.TableKey, strComparisonOp);
}
else
{
objvgs_TotalDataStatisticsEN.dicFldComparisonOp[convgs_TotalDataStatistics.TableKey] = strComparisonOp;
}
}
return objvgs_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TotalDataStatisticsEN SetDataUser(this clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsEN, string strDataUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataUser, 20, convgs_TotalDataStatistics.DataUser);
}
objvgs_TotalDataStatisticsEN.DataUser = strDataUser; //数据用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(convgs_TotalDataStatistics.DataUser) == false)
{
objvgs_TotalDataStatisticsEN.dicFldComparisonOp.Add(convgs_TotalDataStatistics.DataUser, strComparisonOp);
}
else
{
objvgs_TotalDataStatisticsEN.dicFldComparisonOp[convgs_TotalDataStatistics.DataUser] = strComparisonOp;
}
}
return objvgs_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TotalDataStatisticsEN SetDataAddDate(this clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsEN, string strDataAddDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataAddDate, 20, convgs_TotalDataStatistics.DataAddDate);
}
objvgs_TotalDataStatisticsEN.DataAddDate = strDataAddDate; //数据添加日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(convgs_TotalDataStatistics.DataAddDate) == false)
{
objvgs_TotalDataStatisticsEN.dicFldComparisonOp.Add(convgs_TotalDataStatistics.DataAddDate, strComparisonOp);
}
else
{
objvgs_TotalDataStatisticsEN.dicFldComparisonOp[convgs_TotalDataStatistics.DataAddDate] = strComparisonOp;
}
}
return objvgs_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TotalDataStatisticsEN SetDataTable(this clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsEN, string strDataTable, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataTable, 100, convgs_TotalDataStatistics.DataTable);
}
objvgs_TotalDataStatisticsEN.DataTable = strDataTable; //数据表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(convgs_TotalDataStatistics.DataTable) == false)
{
objvgs_TotalDataStatisticsEN.dicFldComparisonOp.Add(convgs_TotalDataStatistics.DataTable, strComparisonOp);
}
else
{
objvgs_TotalDataStatisticsEN.dicFldComparisonOp[convgs_TotalDataStatistics.DataTable] = strComparisonOp;
}
}
return objvgs_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TotalDataStatisticsEN SetMonth(this clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsEN, int? intMonth, string strComparisonOp="")
	{
objvgs_TotalDataStatisticsEN.Month = intMonth; //月
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(convgs_TotalDataStatistics.Month) == false)
{
objvgs_TotalDataStatisticsEN.dicFldComparisonOp.Add(convgs_TotalDataStatistics.Month, strComparisonOp);
}
else
{
objvgs_TotalDataStatisticsEN.dicFldComparisonOp[convgs_TotalDataStatistics.Month] = strComparisonOp;
}
}
return objvgs_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TotalDataStatisticsEN SetDataTableId(this clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsEN, string strDataTableId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataTableId, 50, convgs_TotalDataStatistics.DataTableId);
}
objvgs_TotalDataStatisticsEN.DataTableId = strDataTableId; //数据表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(convgs_TotalDataStatistics.DataTableId) == false)
{
objvgs_TotalDataStatisticsEN.dicFldComparisonOp.Add(convgs_TotalDataStatistics.DataTableId, strComparisonOp);
}
else
{
objvgs_TotalDataStatisticsEN.dicFldComparisonOp[convgs_TotalDataStatistics.DataTableId] = strComparisonOp;
}
}
return objvgs_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TotalDataStatisticsEN SetWeek(this clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsEN, int? intWeek, string strComparisonOp="")
	{
objvgs_TotalDataStatisticsEN.Week = intWeek; //周
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(convgs_TotalDataStatistics.Week) == false)
{
objvgs_TotalDataStatisticsEN.dicFldComparisonOp.Add(convgs_TotalDataStatistics.Week, strComparisonOp);
}
else
{
objvgs_TotalDataStatisticsEN.dicFldComparisonOp[convgs_TotalDataStatistics.Week] = strComparisonOp;
}
}
return objvgs_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TotalDataStatisticsEN SetUpdDate(this clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convgs_TotalDataStatistics.UpdDate);
}
objvgs_TotalDataStatisticsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(convgs_TotalDataStatistics.UpdDate) == false)
{
objvgs_TotalDataStatisticsEN.dicFldComparisonOp.Add(convgs_TotalDataStatistics.UpdDate, strComparisonOp);
}
else
{
objvgs_TotalDataStatisticsEN.dicFldComparisonOp[convgs_TotalDataStatistics.UpdDate] = strComparisonOp;
}
}
return objvgs_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TotalDataStatisticsEN SetUpdUser(this clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convgs_TotalDataStatistics.UpdUser);
}
objvgs_TotalDataStatisticsEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(convgs_TotalDataStatistics.UpdUser) == false)
{
objvgs_TotalDataStatisticsEN.dicFldComparisonOp.Add(convgs_TotalDataStatistics.UpdUser, strComparisonOp);
}
else
{
objvgs_TotalDataStatisticsEN.dicFldComparisonOp[convgs_TotalDataStatistics.UpdUser] = strComparisonOp;
}
}
return objvgs_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TotalDataStatisticsEN SetMemo(this clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convgs_TotalDataStatistics.Memo);
}
objvgs_TotalDataStatisticsEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(convgs_TotalDataStatistics.Memo) == false)
{
objvgs_TotalDataStatisticsEN.dicFldComparisonOp.Add(convgs_TotalDataStatistics.Memo, strComparisonOp);
}
else
{
objvgs_TotalDataStatisticsEN.dicFldComparisonOp[convgs_TotalDataStatistics.Memo] = strComparisonOp;
}
}
return objvgs_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TotalDataStatisticsEN SetScore(this clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsEN, float? fltScore, string strComparisonOp="")
	{
objvgs_TotalDataStatisticsEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(convgs_TotalDataStatistics.Score) == false)
{
objvgs_TotalDataStatisticsEN.dicFldComparisonOp.Add(convgs_TotalDataStatistics.Score, strComparisonOp);
}
else
{
objvgs_TotalDataStatisticsEN.dicFldComparisonOp[convgs_TotalDataStatistics.Score] = strComparisonOp;
}
}
return objvgs_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TotalDataStatisticsEN SetTeaScore(this clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsEN, float? fltTeaScore, string strComparisonOp="")
	{
objvgs_TotalDataStatisticsEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(convgs_TotalDataStatistics.TeaScore) == false)
{
objvgs_TotalDataStatisticsEN.dicFldComparisonOp.Add(convgs_TotalDataStatistics.TeaScore, strComparisonOp);
}
else
{
objvgs_TotalDataStatisticsEN.dicFldComparisonOp[convgs_TotalDataStatistics.TeaScore] = strComparisonOp;
}
}
return objvgs_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TotalDataStatisticsEN SetWeekTimeRange(this clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsEN, string strWeekTimeRange, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWeekTimeRange, 100, convgs_TotalDataStatistics.WeekTimeRange);
}
objvgs_TotalDataStatisticsEN.WeekTimeRange = strWeekTimeRange; //WeekTimeRange
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(convgs_TotalDataStatistics.WeekTimeRange) == false)
{
objvgs_TotalDataStatisticsEN.dicFldComparisonOp.Add(convgs_TotalDataStatistics.WeekTimeRange, strComparisonOp);
}
else
{
objvgs_TotalDataStatisticsEN.dicFldComparisonOp[convgs_TotalDataStatistics.WeekTimeRange] = strComparisonOp;
}
}
return objvgs_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TotalDataStatisticsEN SetOnlyId(this clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsEN, string strOnlyId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOnlyId, 20, convgs_TotalDataStatistics.OnlyId);
}
objvgs_TotalDataStatisticsEN.OnlyId = strOnlyId; //OnlyId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(convgs_TotalDataStatistics.OnlyId) == false)
{
objvgs_TotalDataStatisticsEN.dicFldComparisonOp.Add(convgs_TotalDataStatistics.OnlyId, strComparisonOp);
}
else
{
objvgs_TotalDataStatisticsEN.dicFldComparisonOp[convgs_TotalDataStatistics.OnlyId] = strComparisonOp;
}
}
return objvgs_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TotalDataStatisticsEN SetTotalDataTypeName(this clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsEN, string strTotalDataTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTotalDataTypeName, 500, convgs_TotalDataStatistics.TotalDataTypeName);
}
objvgs_TotalDataStatisticsEN.TotalDataTypeName = strTotalDataTypeName; //总数据类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(convgs_TotalDataStatistics.TotalDataTypeName) == false)
{
objvgs_TotalDataStatisticsEN.dicFldComparisonOp.Add(convgs_TotalDataStatistics.TotalDataTypeName, strComparisonOp);
}
else
{
objvgs_TotalDataStatisticsEN.dicFldComparisonOp[convgs_TotalDataStatistics.TotalDataTypeName] = strComparisonOp;
}
}
return objvgs_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TotalDataStatisticsEN SetStuScore(this clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsEN, float? fltStuScore, string strComparisonOp="")
	{
objvgs_TotalDataStatisticsEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(convgs_TotalDataStatistics.StuScore) == false)
{
objvgs_TotalDataStatisticsEN.dicFldComparisonOp.Add(convgs_TotalDataStatistics.StuScore, strComparisonOp);
}
else
{
objvgs_TotalDataStatisticsEN.dicFldComparisonOp[convgs_TotalDataStatistics.StuScore] = strComparisonOp;
}
}
return objvgs_TotalDataStatisticsEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvgs_TotalDataStatisticsENS">源对象</param>
 /// <param name = "objvgs_TotalDataStatisticsENT">目标对象</param>
 public static void CopyTo(this clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsENS, clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsENT)
{
try
{
objvgs_TotalDataStatisticsENT.TotalDataId = objvgs_TotalDataStatisticsENS.TotalDataId; //TotalDataId
objvgs_TotalDataStatisticsENT.IdCurrEduCls = objvgs_TotalDataStatisticsENS.IdCurrEduCls; //教学班流水号
objvgs_TotalDataStatisticsENT.EduClsName = objvgs_TotalDataStatisticsENS.EduClsName; //教学班名
objvgs_TotalDataStatisticsENT.SchoolYear = objvgs_TotalDataStatisticsENS.SchoolYear; //学年
objvgs_TotalDataStatisticsENT.TotalDataTypeId = objvgs_TotalDataStatisticsENS.TotalDataTypeId; //总数据类型Id
objvgs_TotalDataStatisticsENT.SchoolTerm = objvgs_TotalDataStatisticsENS.SchoolTerm; //学期
objvgs_TotalDataStatisticsENT.TableKey = objvgs_TotalDataStatisticsENS.TableKey; //表主键
objvgs_TotalDataStatisticsENT.DataUser = objvgs_TotalDataStatisticsENS.DataUser; //数据用户
objvgs_TotalDataStatisticsENT.DataAddDate = objvgs_TotalDataStatisticsENS.DataAddDate; //数据添加日期
objvgs_TotalDataStatisticsENT.DataTable = objvgs_TotalDataStatisticsENS.DataTable; //数据表
objvgs_TotalDataStatisticsENT.Month = objvgs_TotalDataStatisticsENS.Month; //月
objvgs_TotalDataStatisticsENT.DataTableId = objvgs_TotalDataStatisticsENS.DataTableId; //数据表Id
objvgs_TotalDataStatisticsENT.Week = objvgs_TotalDataStatisticsENS.Week; //周
objvgs_TotalDataStatisticsENT.UpdDate = objvgs_TotalDataStatisticsENS.UpdDate; //修改日期
objvgs_TotalDataStatisticsENT.UpdUser = objvgs_TotalDataStatisticsENS.UpdUser; //修改人
objvgs_TotalDataStatisticsENT.Memo = objvgs_TotalDataStatisticsENS.Memo; //备注
objvgs_TotalDataStatisticsENT.Score = objvgs_TotalDataStatisticsENS.Score; //评分
objvgs_TotalDataStatisticsENT.TeaScore = objvgs_TotalDataStatisticsENS.TeaScore; //教师评分
objvgs_TotalDataStatisticsENT.WeekTimeRange = objvgs_TotalDataStatisticsENS.WeekTimeRange; //WeekTimeRange
objvgs_TotalDataStatisticsENT.OnlyId = objvgs_TotalDataStatisticsENS.OnlyId; //OnlyId
objvgs_TotalDataStatisticsENT.TotalDataTypeName = objvgs_TotalDataStatisticsENS.TotalDataTypeName; //总数据类型名称
objvgs_TotalDataStatisticsENT.StuScore = objvgs_TotalDataStatisticsENS.StuScore; //学生平均分
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
 /// <param name = "objvgs_TotalDataStatisticsENS">源对象</param>
 /// <returns>目标对象=>clsvgs_TotalDataStatisticsEN:objvgs_TotalDataStatisticsENT</returns>
 public static clsvgs_TotalDataStatisticsEN CopyTo(this clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsENS)
{
try
{
 clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsENT = new clsvgs_TotalDataStatisticsEN()
{
TotalDataId = objvgs_TotalDataStatisticsENS.TotalDataId, //TotalDataId
IdCurrEduCls = objvgs_TotalDataStatisticsENS.IdCurrEduCls, //教学班流水号
EduClsName = objvgs_TotalDataStatisticsENS.EduClsName, //教学班名
SchoolYear = objvgs_TotalDataStatisticsENS.SchoolYear, //学年
TotalDataTypeId = objvgs_TotalDataStatisticsENS.TotalDataTypeId, //总数据类型Id
SchoolTerm = objvgs_TotalDataStatisticsENS.SchoolTerm, //学期
TableKey = objvgs_TotalDataStatisticsENS.TableKey, //表主键
DataUser = objvgs_TotalDataStatisticsENS.DataUser, //数据用户
DataAddDate = objvgs_TotalDataStatisticsENS.DataAddDate, //数据添加日期
DataTable = objvgs_TotalDataStatisticsENS.DataTable, //数据表
Month = objvgs_TotalDataStatisticsENS.Month, //月
DataTableId = objvgs_TotalDataStatisticsENS.DataTableId, //数据表Id
Week = objvgs_TotalDataStatisticsENS.Week, //周
UpdDate = objvgs_TotalDataStatisticsENS.UpdDate, //修改日期
UpdUser = objvgs_TotalDataStatisticsENS.UpdUser, //修改人
Memo = objvgs_TotalDataStatisticsENS.Memo, //备注
Score = objvgs_TotalDataStatisticsENS.Score, //评分
TeaScore = objvgs_TotalDataStatisticsENS.TeaScore, //教师评分
WeekTimeRange = objvgs_TotalDataStatisticsENS.WeekTimeRange, //WeekTimeRange
OnlyId = objvgs_TotalDataStatisticsENS.OnlyId, //OnlyId
TotalDataTypeName = objvgs_TotalDataStatisticsENS.TotalDataTypeName, //总数据类型名称
StuScore = objvgs_TotalDataStatisticsENS.StuScore, //学生平均分
};
 return objvgs_TotalDataStatisticsENT;
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
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsEN)
{
 clsvgs_TotalDataStatisticsBL.vgs_TotalDataStatisticsDA.CheckProperty4Condition(objvgs_TotalDataStatisticsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvgs_TotalDataStatisticsCond.IsUpdated(convgs_TotalDataStatistics.TotalDataId) == true)
{
string strComparisonOpTotalDataId = objvgs_TotalDataStatisticsCond.dicFldComparisonOp[convgs_TotalDataStatistics.TotalDataId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_TotalDataStatistics.TotalDataId, objvgs_TotalDataStatisticsCond.TotalDataId, strComparisonOpTotalDataId);
}
if (objvgs_TotalDataStatisticsCond.IsUpdated(convgs_TotalDataStatistics.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvgs_TotalDataStatisticsCond.dicFldComparisonOp[convgs_TotalDataStatistics.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_TotalDataStatistics.IdCurrEduCls, objvgs_TotalDataStatisticsCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvgs_TotalDataStatisticsCond.IsUpdated(convgs_TotalDataStatistics.EduClsName) == true)
{
string strComparisonOpEduClsName = objvgs_TotalDataStatisticsCond.dicFldComparisonOp[convgs_TotalDataStatistics.EduClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_TotalDataStatistics.EduClsName, objvgs_TotalDataStatisticsCond.EduClsName, strComparisonOpEduClsName);
}
if (objvgs_TotalDataStatisticsCond.IsUpdated(convgs_TotalDataStatistics.SchoolYear) == true)
{
string strComparisonOpSchoolYear = objvgs_TotalDataStatisticsCond.dicFldComparisonOp[convgs_TotalDataStatistics.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_TotalDataStatistics.SchoolYear, objvgs_TotalDataStatisticsCond.SchoolYear, strComparisonOpSchoolYear);
}
if (objvgs_TotalDataStatisticsCond.IsUpdated(convgs_TotalDataStatistics.TotalDataTypeId) == true)
{
string strComparisonOpTotalDataTypeId = objvgs_TotalDataStatisticsCond.dicFldComparisonOp[convgs_TotalDataStatistics.TotalDataTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_TotalDataStatistics.TotalDataTypeId, objvgs_TotalDataStatisticsCond.TotalDataTypeId, strComparisonOpTotalDataTypeId);
}
if (objvgs_TotalDataStatisticsCond.IsUpdated(convgs_TotalDataStatistics.SchoolTerm) == true)
{
string strComparisonOpSchoolTerm = objvgs_TotalDataStatisticsCond.dicFldComparisonOp[convgs_TotalDataStatistics.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_TotalDataStatistics.SchoolTerm, objvgs_TotalDataStatisticsCond.SchoolTerm, strComparisonOpSchoolTerm);
}
if (objvgs_TotalDataStatisticsCond.IsUpdated(convgs_TotalDataStatistics.TableKey) == true)
{
string strComparisonOpTableKey = objvgs_TotalDataStatisticsCond.dicFldComparisonOp[convgs_TotalDataStatistics.TableKey];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_TotalDataStatistics.TableKey, objvgs_TotalDataStatisticsCond.TableKey, strComparisonOpTableKey);
}
if (objvgs_TotalDataStatisticsCond.IsUpdated(convgs_TotalDataStatistics.DataUser) == true)
{
string strComparisonOpDataUser = objvgs_TotalDataStatisticsCond.dicFldComparisonOp[convgs_TotalDataStatistics.DataUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_TotalDataStatistics.DataUser, objvgs_TotalDataStatisticsCond.DataUser, strComparisonOpDataUser);
}
if (objvgs_TotalDataStatisticsCond.IsUpdated(convgs_TotalDataStatistics.DataAddDate) == true)
{
string strComparisonOpDataAddDate = objvgs_TotalDataStatisticsCond.dicFldComparisonOp[convgs_TotalDataStatistics.DataAddDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_TotalDataStatistics.DataAddDate, objvgs_TotalDataStatisticsCond.DataAddDate, strComparisonOpDataAddDate);
}
if (objvgs_TotalDataStatisticsCond.IsUpdated(convgs_TotalDataStatistics.DataTable) == true)
{
string strComparisonOpDataTable = objvgs_TotalDataStatisticsCond.dicFldComparisonOp[convgs_TotalDataStatistics.DataTable];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_TotalDataStatistics.DataTable, objvgs_TotalDataStatisticsCond.DataTable, strComparisonOpDataTable);
}
if (objvgs_TotalDataStatisticsCond.IsUpdated(convgs_TotalDataStatistics.Month) == true)
{
string strComparisonOpMonth = objvgs_TotalDataStatisticsCond.dicFldComparisonOp[convgs_TotalDataStatistics.Month];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_TotalDataStatistics.Month, objvgs_TotalDataStatisticsCond.Month, strComparisonOpMonth);
}
if (objvgs_TotalDataStatisticsCond.IsUpdated(convgs_TotalDataStatistics.DataTableId) == true)
{
string strComparisonOpDataTableId = objvgs_TotalDataStatisticsCond.dicFldComparisonOp[convgs_TotalDataStatistics.DataTableId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_TotalDataStatistics.DataTableId, objvgs_TotalDataStatisticsCond.DataTableId, strComparisonOpDataTableId);
}
if (objvgs_TotalDataStatisticsCond.IsUpdated(convgs_TotalDataStatistics.Week) == true)
{
string strComparisonOpWeek = objvgs_TotalDataStatisticsCond.dicFldComparisonOp[convgs_TotalDataStatistics.Week];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_TotalDataStatistics.Week, objvgs_TotalDataStatisticsCond.Week, strComparisonOpWeek);
}
if (objvgs_TotalDataStatisticsCond.IsUpdated(convgs_TotalDataStatistics.UpdDate) == true)
{
string strComparisonOpUpdDate = objvgs_TotalDataStatisticsCond.dicFldComparisonOp[convgs_TotalDataStatistics.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_TotalDataStatistics.UpdDate, objvgs_TotalDataStatisticsCond.UpdDate, strComparisonOpUpdDate);
}
if (objvgs_TotalDataStatisticsCond.IsUpdated(convgs_TotalDataStatistics.UpdUser) == true)
{
string strComparisonOpUpdUser = objvgs_TotalDataStatisticsCond.dicFldComparisonOp[convgs_TotalDataStatistics.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_TotalDataStatistics.UpdUser, objvgs_TotalDataStatisticsCond.UpdUser, strComparisonOpUpdUser);
}
if (objvgs_TotalDataStatisticsCond.IsUpdated(convgs_TotalDataStatistics.Memo) == true)
{
string strComparisonOpMemo = objvgs_TotalDataStatisticsCond.dicFldComparisonOp[convgs_TotalDataStatistics.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_TotalDataStatistics.Memo, objvgs_TotalDataStatisticsCond.Memo, strComparisonOpMemo);
}
if (objvgs_TotalDataStatisticsCond.IsUpdated(convgs_TotalDataStatistics.Score) == true)
{
string strComparisonOpScore = objvgs_TotalDataStatisticsCond.dicFldComparisonOp[convgs_TotalDataStatistics.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_TotalDataStatistics.Score, objvgs_TotalDataStatisticsCond.Score, strComparisonOpScore);
}
if (objvgs_TotalDataStatisticsCond.IsUpdated(convgs_TotalDataStatistics.TeaScore) == true)
{
string strComparisonOpTeaScore = objvgs_TotalDataStatisticsCond.dicFldComparisonOp[convgs_TotalDataStatistics.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_TotalDataStatistics.TeaScore, objvgs_TotalDataStatisticsCond.TeaScore, strComparisonOpTeaScore);
}
if (objvgs_TotalDataStatisticsCond.IsUpdated(convgs_TotalDataStatistics.WeekTimeRange) == true)
{
string strComparisonOpWeekTimeRange = objvgs_TotalDataStatisticsCond.dicFldComparisonOp[convgs_TotalDataStatistics.WeekTimeRange];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_TotalDataStatistics.WeekTimeRange, objvgs_TotalDataStatisticsCond.WeekTimeRange, strComparisonOpWeekTimeRange);
}
if (objvgs_TotalDataStatisticsCond.IsUpdated(convgs_TotalDataStatistics.OnlyId) == true)
{
string strComparisonOpOnlyId = objvgs_TotalDataStatisticsCond.dicFldComparisonOp[convgs_TotalDataStatistics.OnlyId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_TotalDataStatistics.OnlyId, objvgs_TotalDataStatisticsCond.OnlyId, strComparisonOpOnlyId);
}
if (objvgs_TotalDataStatisticsCond.IsUpdated(convgs_TotalDataStatistics.TotalDataTypeName) == true)
{
string strComparisonOpTotalDataTypeName = objvgs_TotalDataStatisticsCond.dicFldComparisonOp[convgs_TotalDataStatistics.TotalDataTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_TotalDataStatistics.TotalDataTypeName, objvgs_TotalDataStatisticsCond.TotalDataTypeName, strComparisonOpTotalDataTypeName);
}
if (objvgs_TotalDataStatisticsCond.IsUpdated(convgs_TotalDataStatistics.StuScore) == true)
{
string strComparisonOpStuScore = objvgs_TotalDataStatisticsCond.dicFldComparisonOp[convgs_TotalDataStatistics.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_TotalDataStatistics.StuScore, objvgs_TotalDataStatisticsCond.StuScore, strComparisonOpStuScore);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vgs_TotalDataStatistics
{
public virtual bool UpdRelaTabDate(string strTotalDataId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 总数据统计视图(vgs_TotalDataStatistics)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvgs_TotalDataStatisticsBL
{
public static RelatedActions_vgs_TotalDataStatistics relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvgs_TotalDataStatisticsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvgs_TotalDataStatisticsDA vgs_TotalDataStatisticsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvgs_TotalDataStatisticsDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvgs_TotalDataStatisticsBL()
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
if (string.IsNullOrEmpty(clsvgs_TotalDataStatisticsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvgs_TotalDataStatisticsEN._ConnectString);
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
public static DataTable GetDataTable_vgs_TotalDataStatistics(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vgs_TotalDataStatisticsDA.GetDataTable_vgs_TotalDataStatistics(strWhereCond);
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
objDT = vgs_TotalDataStatisticsDA.GetDataTable(strWhereCond);
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
objDT = vgs_TotalDataStatisticsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vgs_TotalDataStatisticsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vgs_TotalDataStatisticsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vgs_TotalDataStatisticsDA.GetDataTable_Top(objTopPara);
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
objDT = vgs_TotalDataStatisticsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vgs_TotalDataStatisticsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vgs_TotalDataStatisticsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrTotalDataIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvgs_TotalDataStatisticsEN> GetObjLstByTotalDataIdLst(List<string> arrTotalDataIdLst)
{
List<clsvgs_TotalDataStatisticsEN> arrObjLst = new List<clsvgs_TotalDataStatisticsEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrTotalDataIdLst, true);
 string strWhereCond = string.Format("TotalDataId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsEN = new clsvgs_TotalDataStatisticsEN();
try
{
objvgs_TotalDataStatisticsEN.TotalDataId = objRow[convgs_TotalDataStatistics.TotalDataId].ToString().Trim(); //TotalDataId
objvgs_TotalDataStatisticsEN.IdCurrEduCls = objRow[convgs_TotalDataStatistics.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_TotalDataStatisticsEN.EduClsName = objRow[convgs_TotalDataStatistics.EduClsName] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.EduClsName].ToString().Trim(); //教学班名
objvgs_TotalDataStatisticsEN.SchoolYear = objRow[convgs_TotalDataStatistics.SchoolYear] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.SchoolYear].ToString().Trim(); //学年
objvgs_TotalDataStatisticsEN.TotalDataTypeId = objRow[convgs_TotalDataStatistics.TotalDataTypeId].ToString().Trim(); //总数据类型Id
objvgs_TotalDataStatisticsEN.SchoolTerm = objRow[convgs_TotalDataStatistics.SchoolTerm] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.SchoolTerm].ToString().Trim(); //学期
objvgs_TotalDataStatisticsEN.TableKey = objRow[convgs_TotalDataStatistics.TableKey] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.TableKey].ToString().Trim(); //表主键
objvgs_TotalDataStatisticsEN.DataUser = objRow[convgs_TotalDataStatistics.DataUser] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.DataUser].ToString().Trim(); //数据用户
objvgs_TotalDataStatisticsEN.DataAddDate = objRow[convgs_TotalDataStatistics.DataAddDate] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.DataAddDate].ToString().Trim(); //数据添加日期
objvgs_TotalDataStatisticsEN.DataTable = objRow[convgs_TotalDataStatistics.DataTable] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.DataTable].ToString().Trim(); //数据表
objvgs_TotalDataStatisticsEN.Month = objRow[convgs_TotalDataStatistics.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_TotalDataStatistics.Month].ToString().Trim()); //月
objvgs_TotalDataStatisticsEN.DataTableId = objRow[convgs_TotalDataStatistics.DataTableId] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.DataTableId].ToString().Trim(); //数据表Id
objvgs_TotalDataStatisticsEN.Week = objRow[convgs_TotalDataStatistics.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_TotalDataStatistics.Week].ToString().Trim()); //周
objvgs_TotalDataStatisticsEN.UpdDate = objRow[convgs_TotalDataStatistics.UpdDate] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.UpdDate].ToString().Trim(); //修改日期
objvgs_TotalDataStatisticsEN.UpdUser = objRow[convgs_TotalDataStatistics.UpdUser] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.UpdUser].ToString().Trim(); //修改人
objvgs_TotalDataStatisticsEN.Memo = objRow[convgs_TotalDataStatistics.Memo] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.Memo].ToString().Trim(); //备注
objvgs_TotalDataStatisticsEN.Score = objRow[convgs_TotalDataStatistics.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_TotalDataStatistics.Score].ToString().Trim()); //评分
objvgs_TotalDataStatisticsEN.TeaScore = objRow[convgs_TotalDataStatistics.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_TotalDataStatistics.TeaScore].ToString().Trim()); //教师评分
objvgs_TotalDataStatisticsEN.WeekTimeRange = objRow[convgs_TotalDataStatistics.WeekTimeRange] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objvgs_TotalDataStatisticsEN.OnlyId = objRow[convgs_TotalDataStatistics.OnlyId] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.OnlyId].ToString().Trim(); //OnlyId
objvgs_TotalDataStatisticsEN.TotalDataTypeName = objRow[convgs_TotalDataStatistics.TotalDataTypeName] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.TotalDataTypeName].ToString().Trim(); //总数据类型名称
objvgs_TotalDataStatisticsEN.StuScore = objRow[convgs_TotalDataStatistics.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_TotalDataStatistics.StuScore].ToString().Trim()); //学生平均分
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_TotalDataStatisticsEN.TotalDataId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_TotalDataStatisticsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrTotalDataIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvgs_TotalDataStatisticsEN> GetObjLstByTotalDataIdLstCache(List<string> arrTotalDataIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsvgs_TotalDataStatisticsEN._CurrTabName, strIdCurrEduCls);
List<clsvgs_TotalDataStatisticsEN> arrvgs_TotalDataStatisticsObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvgs_TotalDataStatisticsEN> arrvgs_TotalDataStatisticsObjLst_Sel =
arrvgs_TotalDataStatisticsObjLstCache
.Where(x => arrTotalDataIdLst.Contains(x.TotalDataId));
return arrvgs_TotalDataStatisticsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_TotalDataStatisticsEN> GetObjLst(string strWhereCond)
{
List<clsvgs_TotalDataStatisticsEN> arrObjLst = new List<clsvgs_TotalDataStatisticsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsEN = new clsvgs_TotalDataStatisticsEN();
try
{
objvgs_TotalDataStatisticsEN.TotalDataId = objRow[convgs_TotalDataStatistics.TotalDataId].ToString().Trim(); //TotalDataId
objvgs_TotalDataStatisticsEN.IdCurrEduCls = objRow[convgs_TotalDataStatistics.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_TotalDataStatisticsEN.EduClsName = objRow[convgs_TotalDataStatistics.EduClsName] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.EduClsName].ToString().Trim(); //教学班名
objvgs_TotalDataStatisticsEN.SchoolYear = objRow[convgs_TotalDataStatistics.SchoolYear] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.SchoolYear].ToString().Trim(); //学年
objvgs_TotalDataStatisticsEN.TotalDataTypeId = objRow[convgs_TotalDataStatistics.TotalDataTypeId].ToString().Trim(); //总数据类型Id
objvgs_TotalDataStatisticsEN.SchoolTerm = objRow[convgs_TotalDataStatistics.SchoolTerm] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.SchoolTerm].ToString().Trim(); //学期
objvgs_TotalDataStatisticsEN.TableKey = objRow[convgs_TotalDataStatistics.TableKey] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.TableKey].ToString().Trim(); //表主键
objvgs_TotalDataStatisticsEN.DataUser = objRow[convgs_TotalDataStatistics.DataUser] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.DataUser].ToString().Trim(); //数据用户
objvgs_TotalDataStatisticsEN.DataAddDate = objRow[convgs_TotalDataStatistics.DataAddDate] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.DataAddDate].ToString().Trim(); //数据添加日期
objvgs_TotalDataStatisticsEN.DataTable = objRow[convgs_TotalDataStatistics.DataTable] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.DataTable].ToString().Trim(); //数据表
objvgs_TotalDataStatisticsEN.Month = objRow[convgs_TotalDataStatistics.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_TotalDataStatistics.Month].ToString().Trim()); //月
objvgs_TotalDataStatisticsEN.DataTableId = objRow[convgs_TotalDataStatistics.DataTableId] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.DataTableId].ToString().Trim(); //数据表Id
objvgs_TotalDataStatisticsEN.Week = objRow[convgs_TotalDataStatistics.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_TotalDataStatistics.Week].ToString().Trim()); //周
objvgs_TotalDataStatisticsEN.UpdDate = objRow[convgs_TotalDataStatistics.UpdDate] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.UpdDate].ToString().Trim(); //修改日期
objvgs_TotalDataStatisticsEN.UpdUser = objRow[convgs_TotalDataStatistics.UpdUser] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.UpdUser].ToString().Trim(); //修改人
objvgs_TotalDataStatisticsEN.Memo = objRow[convgs_TotalDataStatistics.Memo] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.Memo].ToString().Trim(); //备注
objvgs_TotalDataStatisticsEN.Score = objRow[convgs_TotalDataStatistics.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_TotalDataStatistics.Score].ToString().Trim()); //评分
objvgs_TotalDataStatisticsEN.TeaScore = objRow[convgs_TotalDataStatistics.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_TotalDataStatistics.TeaScore].ToString().Trim()); //教师评分
objvgs_TotalDataStatisticsEN.WeekTimeRange = objRow[convgs_TotalDataStatistics.WeekTimeRange] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objvgs_TotalDataStatisticsEN.OnlyId = objRow[convgs_TotalDataStatistics.OnlyId] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.OnlyId].ToString().Trim(); //OnlyId
objvgs_TotalDataStatisticsEN.TotalDataTypeName = objRow[convgs_TotalDataStatistics.TotalDataTypeName] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.TotalDataTypeName].ToString().Trim(); //总数据类型名称
objvgs_TotalDataStatisticsEN.StuScore = objRow[convgs_TotalDataStatistics.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_TotalDataStatistics.StuScore].ToString().Trim()); //学生平均分
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_TotalDataStatisticsEN.TotalDataId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_TotalDataStatisticsEN);
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
public static List<clsvgs_TotalDataStatisticsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvgs_TotalDataStatisticsEN> arrObjLst = new List<clsvgs_TotalDataStatisticsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsEN = new clsvgs_TotalDataStatisticsEN();
try
{
objvgs_TotalDataStatisticsEN.TotalDataId = objRow[convgs_TotalDataStatistics.TotalDataId].ToString().Trim(); //TotalDataId
objvgs_TotalDataStatisticsEN.IdCurrEduCls = objRow[convgs_TotalDataStatistics.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_TotalDataStatisticsEN.EduClsName = objRow[convgs_TotalDataStatistics.EduClsName] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.EduClsName].ToString().Trim(); //教学班名
objvgs_TotalDataStatisticsEN.SchoolYear = objRow[convgs_TotalDataStatistics.SchoolYear] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.SchoolYear].ToString().Trim(); //学年
objvgs_TotalDataStatisticsEN.TotalDataTypeId = objRow[convgs_TotalDataStatistics.TotalDataTypeId].ToString().Trim(); //总数据类型Id
objvgs_TotalDataStatisticsEN.SchoolTerm = objRow[convgs_TotalDataStatistics.SchoolTerm] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.SchoolTerm].ToString().Trim(); //学期
objvgs_TotalDataStatisticsEN.TableKey = objRow[convgs_TotalDataStatistics.TableKey] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.TableKey].ToString().Trim(); //表主键
objvgs_TotalDataStatisticsEN.DataUser = objRow[convgs_TotalDataStatistics.DataUser] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.DataUser].ToString().Trim(); //数据用户
objvgs_TotalDataStatisticsEN.DataAddDate = objRow[convgs_TotalDataStatistics.DataAddDate] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.DataAddDate].ToString().Trim(); //数据添加日期
objvgs_TotalDataStatisticsEN.DataTable = objRow[convgs_TotalDataStatistics.DataTable] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.DataTable].ToString().Trim(); //数据表
objvgs_TotalDataStatisticsEN.Month = objRow[convgs_TotalDataStatistics.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_TotalDataStatistics.Month].ToString().Trim()); //月
objvgs_TotalDataStatisticsEN.DataTableId = objRow[convgs_TotalDataStatistics.DataTableId] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.DataTableId].ToString().Trim(); //数据表Id
objvgs_TotalDataStatisticsEN.Week = objRow[convgs_TotalDataStatistics.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_TotalDataStatistics.Week].ToString().Trim()); //周
objvgs_TotalDataStatisticsEN.UpdDate = objRow[convgs_TotalDataStatistics.UpdDate] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.UpdDate].ToString().Trim(); //修改日期
objvgs_TotalDataStatisticsEN.UpdUser = objRow[convgs_TotalDataStatistics.UpdUser] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.UpdUser].ToString().Trim(); //修改人
objvgs_TotalDataStatisticsEN.Memo = objRow[convgs_TotalDataStatistics.Memo] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.Memo].ToString().Trim(); //备注
objvgs_TotalDataStatisticsEN.Score = objRow[convgs_TotalDataStatistics.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_TotalDataStatistics.Score].ToString().Trim()); //评分
objvgs_TotalDataStatisticsEN.TeaScore = objRow[convgs_TotalDataStatistics.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_TotalDataStatistics.TeaScore].ToString().Trim()); //教师评分
objvgs_TotalDataStatisticsEN.WeekTimeRange = objRow[convgs_TotalDataStatistics.WeekTimeRange] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objvgs_TotalDataStatisticsEN.OnlyId = objRow[convgs_TotalDataStatistics.OnlyId] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.OnlyId].ToString().Trim(); //OnlyId
objvgs_TotalDataStatisticsEN.TotalDataTypeName = objRow[convgs_TotalDataStatistics.TotalDataTypeName] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.TotalDataTypeName].ToString().Trim(); //总数据类型名称
objvgs_TotalDataStatisticsEN.StuScore = objRow[convgs_TotalDataStatistics.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_TotalDataStatistics.StuScore].ToString().Trim()); //学生平均分
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_TotalDataStatisticsEN.TotalDataId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_TotalDataStatisticsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvgs_TotalDataStatisticsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvgs_TotalDataStatisticsEN> GetSubObjLstCache(clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsCond)
{
 string strIdCurrEduCls = objvgs_TotalDataStatisticsCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvgs_TotalDataStatisticsBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvgs_TotalDataStatisticsEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvgs_TotalDataStatisticsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convgs_TotalDataStatistics.AttributeName)
{
if (objvgs_TotalDataStatisticsCond.IsUpdated(strFldName) == false) continue;
if (objvgs_TotalDataStatisticsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_TotalDataStatisticsCond[strFldName].ToString());
}
else
{
if (objvgs_TotalDataStatisticsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvgs_TotalDataStatisticsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_TotalDataStatisticsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvgs_TotalDataStatisticsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvgs_TotalDataStatisticsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvgs_TotalDataStatisticsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvgs_TotalDataStatisticsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvgs_TotalDataStatisticsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvgs_TotalDataStatisticsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvgs_TotalDataStatisticsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvgs_TotalDataStatisticsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvgs_TotalDataStatisticsCond[strFldName]));
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
public static List<clsvgs_TotalDataStatisticsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvgs_TotalDataStatisticsEN> arrObjLst = new List<clsvgs_TotalDataStatisticsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsEN = new clsvgs_TotalDataStatisticsEN();
try
{
objvgs_TotalDataStatisticsEN.TotalDataId = objRow[convgs_TotalDataStatistics.TotalDataId].ToString().Trim(); //TotalDataId
objvgs_TotalDataStatisticsEN.IdCurrEduCls = objRow[convgs_TotalDataStatistics.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_TotalDataStatisticsEN.EduClsName = objRow[convgs_TotalDataStatistics.EduClsName] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.EduClsName].ToString().Trim(); //教学班名
objvgs_TotalDataStatisticsEN.SchoolYear = objRow[convgs_TotalDataStatistics.SchoolYear] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.SchoolYear].ToString().Trim(); //学年
objvgs_TotalDataStatisticsEN.TotalDataTypeId = objRow[convgs_TotalDataStatistics.TotalDataTypeId].ToString().Trim(); //总数据类型Id
objvgs_TotalDataStatisticsEN.SchoolTerm = objRow[convgs_TotalDataStatistics.SchoolTerm] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.SchoolTerm].ToString().Trim(); //学期
objvgs_TotalDataStatisticsEN.TableKey = objRow[convgs_TotalDataStatistics.TableKey] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.TableKey].ToString().Trim(); //表主键
objvgs_TotalDataStatisticsEN.DataUser = objRow[convgs_TotalDataStatistics.DataUser] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.DataUser].ToString().Trim(); //数据用户
objvgs_TotalDataStatisticsEN.DataAddDate = objRow[convgs_TotalDataStatistics.DataAddDate] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.DataAddDate].ToString().Trim(); //数据添加日期
objvgs_TotalDataStatisticsEN.DataTable = objRow[convgs_TotalDataStatistics.DataTable] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.DataTable].ToString().Trim(); //数据表
objvgs_TotalDataStatisticsEN.Month = objRow[convgs_TotalDataStatistics.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_TotalDataStatistics.Month].ToString().Trim()); //月
objvgs_TotalDataStatisticsEN.DataTableId = objRow[convgs_TotalDataStatistics.DataTableId] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.DataTableId].ToString().Trim(); //数据表Id
objvgs_TotalDataStatisticsEN.Week = objRow[convgs_TotalDataStatistics.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_TotalDataStatistics.Week].ToString().Trim()); //周
objvgs_TotalDataStatisticsEN.UpdDate = objRow[convgs_TotalDataStatistics.UpdDate] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.UpdDate].ToString().Trim(); //修改日期
objvgs_TotalDataStatisticsEN.UpdUser = objRow[convgs_TotalDataStatistics.UpdUser] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.UpdUser].ToString().Trim(); //修改人
objvgs_TotalDataStatisticsEN.Memo = objRow[convgs_TotalDataStatistics.Memo] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.Memo].ToString().Trim(); //备注
objvgs_TotalDataStatisticsEN.Score = objRow[convgs_TotalDataStatistics.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_TotalDataStatistics.Score].ToString().Trim()); //评分
objvgs_TotalDataStatisticsEN.TeaScore = objRow[convgs_TotalDataStatistics.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_TotalDataStatistics.TeaScore].ToString().Trim()); //教师评分
objvgs_TotalDataStatisticsEN.WeekTimeRange = objRow[convgs_TotalDataStatistics.WeekTimeRange] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objvgs_TotalDataStatisticsEN.OnlyId = objRow[convgs_TotalDataStatistics.OnlyId] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.OnlyId].ToString().Trim(); //OnlyId
objvgs_TotalDataStatisticsEN.TotalDataTypeName = objRow[convgs_TotalDataStatistics.TotalDataTypeName] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.TotalDataTypeName].ToString().Trim(); //总数据类型名称
objvgs_TotalDataStatisticsEN.StuScore = objRow[convgs_TotalDataStatistics.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_TotalDataStatistics.StuScore].ToString().Trim()); //学生平均分
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_TotalDataStatisticsEN.TotalDataId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_TotalDataStatisticsEN);
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
public static List<clsvgs_TotalDataStatisticsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvgs_TotalDataStatisticsEN> arrObjLst = new List<clsvgs_TotalDataStatisticsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsEN = new clsvgs_TotalDataStatisticsEN();
try
{
objvgs_TotalDataStatisticsEN.TotalDataId = objRow[convgs_TotalDataStatistics.TotalDataId].ToString().Trim(); //TotalDataId
objvgs_TotalDataStatisticsEN.IdCurrEduCls = objRow[convgs_TotalDataStatistics.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_TotalDataStatisticsEN.EduClsName = objRow[convgs_TotalDataStatistics.EduClsName] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.EduClsName].ToString().Trim(); //教学班名
objvgs_TotalDataStatisticsEN.SchoolYear = objRow[convgs_TotalDataStatistics.SchoolYear] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.SchoolYear].ToString().Trim(); //学年
objvgs_TotalDataStatisticsEN.TotalDataTypeId = objRow[convgs_TotalDataStatistics.TotalDataTypeId].ToString().Trim(); //总数据类型Id
objvgs_TotalDataStatisticsEN.SchoolTerm = objRow[convgs_TotalDataStatistics.SchoolTerm] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.SchoolTerm].ToString().Trim(); //学期
objvgs_TotalDataStatisticsEN.TableKey = objRow[convgs_TotalDataStatistics.TableKey] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.TableKey].ToString().Trim(); //表主键
objvgs_TotalDataStatisticsEN.DataUser = objRow[convgs_TotalDataStatistics.DataUser] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.DataUser].ToString().Trim(); //数据用户
objvgs_TotalDataStatisticsEN.DataAddDate = objRow[convgs_TotalDataStatistics.DataAddDate] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.DataAddDate].ToString().Trim(); //数据添加日期
objvgs_TotalDataStatisticsEN.DataTable = objRow[convgs_TotalDataStatistics.DataTable] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.DataTable].ToString().Trim(); //数据表
objvgs_TotalDataStatisticsEN.Month = objRow[convgs_TotalDataStatistics.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_TotalDataStatistics.Month].ToString().Trim()); //月
objvgs_TotalDataStatisticsEN.DataTableId = objRow[convgs_TotalDataStatistics.DataTableId] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.DataTableId].ToString().Trim(); //数据表Id
objvgs_TotalDataStatisticsEN.Week = objRow[convgs_TotalDataStatistics.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_TotalDataStatistics.Week].ToString().Trim()); //周
objvgs_TotalDataStatisticsEN.UpdDate = objRow[convgs_TotalDataStatistics.UpdDate] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.UpdDate].ToString().Trim(); //修改日期
objvgs_TotalDataStatisticsEN.UpdUser = objRow[convgs_TotalDataStatistics.UpdUser] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.UpdUser].ToString().Trim(); //修改人
objvgs_TotalDataStatisticsEN.Memo = objRow[convgs_TotalDataStatistics.Memo] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.Memo].ToString().Trim(); //备注
objvgs_TotalDataStatisticsEN.Score = objRow[convgs_TotalDataStatistics.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_TotalDataStatistics.Score].ToString().Trim()); //评分
objvgs_TotalDataStatisticsEN.TeaScore = objRow[convgs_TotalDataStatistics.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_TotalDataStatistics.TeaScore].ToString().Trim()); //教师评分
objvgs_TotalDataStatisticsEN.WeekTimeRange = objRow[convgs_TotalDataStatistics.WeekTimeRange] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objvgs_TotalDataStatisticsEN.OnlyId = objRow[convgs_TotalDataStatistics.OnlyId] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.OnlyId].ToString().Trim(); //OnlyId
objvgs_TotalDataStatisticsEN.TotalDataTypeName = objRow[convgs_TotalDataStatistics.TotalDataTypeName] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.TotalDataTypeName].ToString().Trim(); //总数据类型名称
objvgs_TotalDataStatisticsEN.StuScore = objRow[convgs_TotalDataStatistics.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_TotalDataStatistics.StuScore].ToString().Trim()); //学生平均分
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_TotalDataStatisticsEN.TotalDataId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_TotalDataStatisticsEN);
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
List<clsvgs_TotalDataStatisticsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvgs_TotalDataStatisticsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_TotalDataStatisticsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvgs_TotalDataStatisticsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvgs_TotalDataStatisticsEN> arrObjLst = new List<clsvgs_TotalDataStatisticsEN>(); 
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
	clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsEN = new clsvgs_TotalDataStatisticsEN();
try
{
objvgs_TotalDataStatisticsEN.TotalDataId = objRow[convgs_TotalDataStatistics.TotalDataId].ToString().Trim(); //TotalDataId
objvgs_TotalDataStatisticsEN.IdCurrEduCls = objRow[convgs_TotalDataStatistics.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_TotalDataStatisticsEN.EduClsName = objRow[convgs_TotalDataStatistics.EduClsName] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.EduClsName].ToString().Trim(); //教学班名
objvgs_TotalDataStatisticsEN.SchoolYear = objRow[convgs_TotalDataStatistics.SchoolYear] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.SchoolYear].ToString().Trim(); //学年
objvgs_TotalDataStatisticsEN.TotalDataTypeId = objRow[convgs_TotalDataStatistics.TotalDataTypeId].ToString().Trim(); //总数据类型Id
objvgs_TotalDataStatisticsEN.SchoolTerm = objRow[convgs_TotalDataStatistics.SchoolTerm] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.SchoolTerm].ToString().Trim(); //学期
objvgs_TotalDataStatisticsEN.TableKey = objRow[convgs_TotalDataStatistics.TableKey] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.TableKey].ToString().Trim(); //表主键
objvgs_TotalDataStatisticsEN.DataUser = objRow[convgs_TotalDataStatistics.DataUser] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.DataUser].ToString().Trim(); //数据用户
objvgs_TotalDataStatisticsEN.DataAddDate = objRow[convgs_TotalDataStatistics.DataAddDate] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.DataAddDate].ToString().Trim(); //数据添加日期
objvgs_TotalDataStatisticsEN.DataTable = objRow[convgs_TotalDataStatistics.DataTable] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.DataTable].ToString().Trim(); //数据表
objvgs_TotalDataStatisticsEN.Month = objRow[convgs_TotalDataStatistics.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_TotalDataStatistics.Month].ToString().Trim()); //月
objvgs_TotalDataStatisticsEN.DataTableId = objRow[convgs_TotalDataStatistics.DataTableId] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.DataTableId].ToString().Trim(); //数据表Id
objvgs_TotalDataStatisticsEN.Week = objRow[convgs_TotalDataStatistics.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_TotalDataStatistics.Week].ToString().Trim()); //周
objvgs_TotalDataStatisticsEN.UpdDate = objRow[convgs_TotalDataStatistics.UpdDate] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.UpdDate].ToString().Trim(); //修改日期
objvgs_TotalDataStatisticsEN.UpdUser = objRow[convgs_TotalDataStatistics.UpdUser] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.UpdUser].ToString().Trim(); //修改人
objvgs_TotalDataStatisticsEN.Memo = objRow[convgs_TotalDataStatistics.Memo] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.Memo].ToString().Trim(); //备注
objvgs_TotalDataStatisticsEN.Score = objRow[convgs_TotalDataStatistics.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_TotalDataStatistics.Score].ToString().Trim()); //评分
objvgs_TotalDataStatisticsEN.TeaScore = objRow[convgs_TotalDataStatistics.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_TotalDataStatistics.TeaScore].ToString().Trim()); //教师评分
objvgs_TotalDataStatisticsEN.WeekTimeRange = objRow[convgs_TotalDataStatistics.WeekTimeRange] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objvgs_TotalDataStatisticsEN.OnlyId = objRow[convgs_TotalDataStatistics.OnlyId] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.OnlyId].ToString().Trim(); //OnlyId
objvgs_TotalDataStatisticsEN.TotalDataTypeName = objRow[convgs_TotalDataStatistics.TotalDataTypeName] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.TotalDataTypeName].ToString().Trim(); //总数据类型名称
objvgs_TotalDataStatisticsEN.StuScore = objRow[convgs_TotalDataStatistics.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_TotalDataStatistics.StuScore].ToString().Trim()); //学生平均分
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_TotalDataStatisticsEN.TotalDataId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_TotalDataStatisticsEN);
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
public static List<clsvgs_TotalDataStatisticsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvgs_TotalDataStatisticsEN> arrObjLst = new List<clsvgs_TotalDataStatisticsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsEN = new clsvgs_TotalDataStatisticsEN();
try
{
objvgs_TotalDataStatisticsEN.TotalDataId = objRow[convgs_TotalDataStatistics.TotalDataId].ToString().Trim(); //TotalDataId
objvgs_TotalDataStatisticsEN.IdCurrEduCls = objRow[convgs_TotalDataStatistics.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_TotalDataStatisticsEN.EduClsName = objRow[convgs_TotalDataStatistics.EduClsName] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.EduClsName].ToString().Trim(); //教学班名
objvgs_TotalDataStatisticsEN.SchoolYear = objRow[convgs_TotalDataStatistics.SchoolYear] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.SchoolYear].ToString().Trim(); //学年
objvgs_TotalDataStatisticsEN.TotalDataTypeId = objRow[convgs_TotalDataStatistics.TotalDataTypeId].ToString().Trim(); //总数据类型Id
objvgs_TotalDataStatisticsEN.SchoolTerm = objRow[convgs_TotalDataStatistics.SchoolTerm] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.SchoolTerm].ToString().Trim(); //学期
objvgs_TotalDataStatisticsEN.TableKey = objRow[convgs_TotalDataStatistics.TableKey] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.TableKey].ToString().Trim(); //表主键
objvgs_TotalDataStatisticsEN.DataUser = objRow[convgs_TotalDataStatistics.DataUser] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.DataUser].ToString().Trim(); //数据用户
objvgs_TotalDataStatisticsEN.DataAddDate = objRow[convgs_TotalDataStatistics.DataAddDate] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.DataAddDate].ToString().Trim(); //数据添加日期
objvgs_TotalDataStatisticsEN.DataTable = objRow[convgs_TotalDataStatistics.DataTable] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.DataTable].ToString().Trim(); //数据表
objvgs_TotalDataStatisticsEN.Month = objRow[convgs_TotalDataStatistics.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_TotalDataStatistics.Month].ToString().Trim()); //月
objvgs_TotalDataStatisticsEN.DataTableId = objRow[convgs_TotalDataStatistics.DataTableId] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.DataTableId].ToString().Trim(); //数据表Id
objvgs_TotalDataStatisticsEN.Week = objRow[convgs_TotalDataStatistics.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_TotalDataStatistics.Week].ToString().Trim()); //周
objvgs_TotalDataStatisticsEN.UpdDate = objRow[convgs_TotalDataStatistics.UpdDate] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.UpdDate].ToString().Trim(); //修改日期
objvgs_TotalDataStatisticsEN.UpdUser = objRow[convgs_TotalDataStatistics.UpdUser] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.UpdUser].ToString().Trim(); //修改人
objvgs_TotalDataStatisticsEN.Memo = objRow[convgs_TotalDataStatistics.Memo] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.Memo].ToString().Trim(); //备注
objvgs_TotalDataStatisticsEN.Score = objRow[convgs_TotalDataStatistics.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_TotalDataStatistics.Score].ToString().Trim()); //评分
objvgs_TotalDataStatisticsEN.TeaScore = objRow[convgs_TotalDataStatistics.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_TotalDataStatistics.TeaScore].ToString().Trim()); //教师评分
objvgs_TotalDataStatisticsEN.WeekTimeRange = objRow[convgs_TotalDataStatistics.WeekTimeRange] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objvgs_TotalDataStatisticsEN.OnlyId = objRow[convgs_TotalDataStatistics.OnlyId] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.OnlyId].ToString().Trim(); //OnlyId
objvgs_TotalDataStatisticsEN.TotalDataTypeName = objRow[convgs_TotalDataStatistics.TotalDataTypeName] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.TotalDataTypeName].ToString().Trim(); //总数据类型名称
objvgs_TotalDataStatisticsEN.StuScore = objRow[convgs_TotalDataStatistics.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_TotalDataStatistics.StuScore].ToString().Trim()); //学生平均分
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_TotalDataStatisticsEN.TotalDataId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_TotalDataStatisticsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvgs_TotalDataStatisticsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvgs_TotalDataStatisticsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvgs_TotalDataStatisticsEN> arrObjLst = new List<clsvgs_TotalDataStatisticsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsEN = new clsvgs_TotalDataStatisticsEN();
try
{
objvgs_TotalDataStatisticsEN.TotalDataId = objRow[convgs_TotalDataStatistics.TotalDataId].ToString().Trim(); //TotalDataId
objvgs_TotalDataStatisticsEN.IdCurrEduCls = objRow[convgs_TotalDataStatistics.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_TotalDataStatisticsEN.EduClsName = objRow[convgs_TotalDataStatistics.EduClsName] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.EduClsName].ToString().Trim(); //教学班名
objvgs_TotalDataStatisticsEN.SchoolYear = objRow[convgs_TotalDataStatistics.SchoolYear] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.SchoolYear].ToString().Trim(); //学年
objvgs_TotalDataStatisticsEN.TotalDataTypeId = objRow[convgs_TotalDataStatistics.TotalDataTypeId].ToString().Trim(); //总数据类型Id
objvgs_TotalDataStatisticsEN.SchoolTerm = objRow[convgs_TotalDataStatistics.SchoolTerm] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.SchoolTerm].ToString().Trim(); //学期
objvgs_TotalDataStatisticsEN.TableKey = objRow[convgs_TotalDataStatistics.TableKey] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.TableKey].ToString().Trim(); //表主键
objvgs_TotalDataStatisticsEN.DataUser = objRow[convgs_TotalDataStatistics.DataUser] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.DataUser].ToString().Trim(); //数据用户
objvgs_TotalDataStatisticsEN.DataAddDate = objRow[convgs_TotalDataStatistics.DataAddDate] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.DataAddDate].ToString().Trim(); //数据添加日期
objvgs_TotalDataStatisticsEN.DataTable = objRow[convgs_TotalDataStatistics.DataTable] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.DataTable].ToString().Trim(); //数据表
objvgs_TotalDataStatisticsEN.Month = objRow[convgs_TotalDataStatistics.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_TotalDataStatistics.Month].ToString().Trim()); //月
objvgs_TotalDataStatisticsEN.DataTableId = objRow[convgs_TotalDataStatistics.DataTableId] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.DataTableId].ToString().Trim(); //数据表Id
objvgs_TotalDataStatisticsEN.Week = objRow[convgs_TotalDataStatistics.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_TotalDataStatistics.Week].ToString().Trim()); //周
objvgs_TotalDataStatisticsEN.UpdDate = objRow[convgs_TotalDataStatistics.UpdDate] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.UpdDate].ToString().Trim(); //修改日期
objvgs_TotalDataStatisticsEN.UpdUser = objRow[convgs_TotalDataStatistics.UpdUser] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.UpdUser].ToString().Trim(); //修改人
objvgs_TotalDataStatisticsEN.Memo = objRow[convgs_TotalDataStatistics.Memo] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.Memo].ToString().Trim(); //备注
objvgs_TotalDataStatisticsEN.Score = objRow[convgs_TotalDataStatistics.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_TotalDataStatistics.Score].ToString().Trim()); //评分
objvgs_TotalDataStatisticsEN.TeaScore = objRow[convgs_TotalDataStatistics.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_TotalDataStatistics.TeaScore].ToString().Trim()); //教师评分
objvgs_TotalDataStatisticsEN.WeekTimeRange = objRow[convgs_TotalDataStatistics.WeekTimeRange] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objvgs_TotalDataStatisticsEN.OnlyId = objRow[convgs_TotalDataStatistics.OnlyId] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.OnlyId].ToString().Trim(); //OnlyId
objvgs_TotalDataStatisticsEN.TotalDataTypeName = objRow[convgs_TotalDataStatistics.TotalDataTypeName] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.TotalDataTypeName].ToString().Trim(); //总数据类型名称
objvgs_TotalDataStatisticsEN.StuScore = objRow[convgs_TotalDataStatistics.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_TotalDataStatistics.StuScore].ToString().Trim()); //学生平均分
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_TotalDataStatisticsEN.TotalDataId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_TotalDataStatisticsEN);
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
public static List<clsvgs_TotalDataStatisticsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvgs_TotalDataStatisticsEN> arrObjLst = new List<clsvgs_TotalDataStatisticsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsEN = new clsvgs_TotalDataStatisticsEN();
try
{
objvgs_TotalDataStatisticsEN.TotalDataId = objRow[convgs_TotalDataStatistics.TotalDataId].ToString().Trim(); //TotalDataId
objvgs_TotalDataStatisticsEN.IdCurrEduCls = objRow[convgs_TotalDataStatistics.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_TotalDataStatisticsEN.EduClsName = objRow[convgs_TotalDataStatistics.EduClsName] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.EduClsName].ToString().Trim(); //教学班名
objvgs_TotalDataStatisticsEN.SchoolYear = objRow[convgs_TotalDataStatistics.SchoolYear] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.SchoolYear].ToString().Trim(); //学年
objvgs_TotalDataStatisticsEN.TotalDataTypeId = objRow[convgs_TotalDataStatistics.TotalDataTypeId].ToString().Trim(); //总数据类型Id
objvgs_TotalDataStatisticsEN.SchoolTerm = objRow[convgs_TotalDataStatistics.SchoolTerm] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.SchoolTerm].ToString().Trim(); //学期
objvgs_TotalDataStatisticsEN.TableKey = objRow[convgs_TotalDataStatistics.TableKey] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.TableKey].ToString().Trim(); //表主键
objvgs_TotalDataStatisticsEN.DataUser = objRow[convgs_TotalDataStatistics.DataUser] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.DataUser].ToString().Trim(); //数据用户
objvgs_TotalDataStatisticsEN.DataAddDate = objRow[convgs_TotalDataStatistics.DataAddDate] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.DataAddDate].ToString().Trim(); //数据添加日期
objvgs_TotalDataStatisticsEN.DataTable = objRow[convgs_TotalDataStatistics.DataTable] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.DataTable].ToString().Trim(); //数据表
objvgs_TotalDataStatisticsEN.Month = objRow[convgs_TotalDataStatistics.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_TotalDataStatistics.Month].ToString().Trim()); //月
objvgs_TotalDataStatisticsEN.DataTableId = objRow[convgs_TotalDataStatistics.DataTableId] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.DataTableId].ToString().Trim(); //数据表Id
objvgs_TotalDataStatisticsEN.Week = objRow[convgs_TotalDataStatistics.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_TotalDataStatistics.Week].ToString().Trim()); //周
objvgs_TotalDataStatisticsEN.UpdDate = objRow[convgs_TotalDataStatistics.UpdDate] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.UpdDate].ToString().Trim(); //修改日期
objvgs_TotalDataStatisticsEN.UpdUser = objRow[convgs_TotalDataStatistics.UpdUser] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.UpdUser].ToString().Trim(); //修改人
objvgs_TotalDataStatisticsEN.Memo = objRow[convgs_TotalDataStatistics.Memo] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.Memo].ToString().Trim(); //备注
objvgs_TotalDataStatisticsEN.Score = objRow[convgs_TotalDataStatistics.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_TotalDataStatistics.Score].ToString().Trim()); //评分
objvgs_TotalDataStatisticsEN.TeaScore = objRow[convgs_TotalDataStatistics.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_TotalDataStatistics.TeaScore].ToString().Trim()); //教师评分
objvgs_TotalDataStatisticsEN.WeekTimeRange = objRow[convgs_TotalDataStatistics.WeekTimeRange] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objvgs_TotalDataStatisticsEN.OnlyId = objRow[convgs_TotalDataStatistics.OnlyId] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.OnlyId].ToString().Trim(); //OnlyId
objvgs_TotalDataStatisticsEN.TotalDataTypeName = objRow[convgs_TotalDataStatistics.TotalDataTypeName] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.TotalDataTypeName].ToString().Trim(); //总数据类型名称
objvgs_TotalDataStatisticsEN.StuScore = objRow[convgs_TotalDataStatistics.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_TotalDataStatistics.StuScore].ToString().Trim()); //学生平均分
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_TotalDataStatisticsEN.TotalDataId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_TotalDataStatisticsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_TotalDataStatisticsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvgs_TotalDataStatisticsEN> arrObjLst = new List<clsvgs_TotalDataStatisticsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsEN = new clsvgs_TotalDataStatisticsEN();
try
{
objvgs_TotalDataStatisticsEN.TotalDataId = objRow[convgs_TotalDataStatistics.TotalDataId].ToString().Trim(); //TotalDataId
objvgs_TotalDataStatisticsEN.IdCurrEduCls = objRow[convgs_TotalDataStatistics.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_TotalDataStatisticsEN.EduClsName = objRow[convgs_TotalDataStatistics.EduClsName] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.EduClsName].ToString().Trim(); //教学班名
objvgs_TotalDataStatisticsEN.SchoolYear = objRow[convgs_TotalDataStatistics.SchoolYear] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.SchoolYear].ToString().Trim(); //学年
objvgs_TotalDataStatisticsEN.TotalDataTypeId = objRow[convgs_TotalDataStatistics.TotalDataTypeId].ToString().Trim(); //总数据类型Id
objvgs_TotalDataStatisticsEN.SchoolTerm = objRow[convgs_TotalDataStatistics.SchoolTerm] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.SchoolTerm].ToString().Trim(); //学期
objvgs_TotalDataStatisticsEN.TableKey = objRow[convgs_TotalDataStatistics.TableKey] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.TableKey].ToString().Trim(); //表主键
objvgs_TotalDataStatisticsEN.DataUser = objRow[convgs_TotalDataStatistics.DataUser] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.DataUser].ToString().Trim(); //数据用户
objvgs_TotalDataStatisticsEN.DataAddDate = objRow[convgs_TotalDataStatistics.DataAddDate] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.DataAddDate].ToString().Trim(); //数据添加日期
objvgs_TotalDataStatisticsEN.DataTable = objRow[convgs_TotalDataStatistics.DataTable] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.DataTable].ToString().Trim(); //数据表
objvgs_TotalDataStatisticsEN.Month = objRow[convgs_TotalDataStatistics.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_TotalDataStatistics.Month].ToString().Trim()); //月
objvgs_TotalDataStatisticsEN.DataTableId = objRow[convgs_TotalDataStatistics.DataTableId] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.DataTableId].ToString().Trim(); //数据表Id
objvgs_TotalDataStatisticsEN.Week = objRow[convgs_TotalDataStatistics.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_TotalDataStatistics.Week].ToString().Trim()); //周
objvgs_TotalDataStatisticsEN.UpdDate = objRow[convgs_TotalDataStatistics.UpdDate] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.UpdDate].ToString().Trim(); //修改日期
objvgs_TotalDataStatisticsEN.UpdUser = objRow[convgs_TotalDataStatistics.UpdUser] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.UpdUser].ToString().Trim(); //修改人
objvgs_TotalDataStatisticsEN.Memo = objRow[convgs_TotalDataStatistics.Memo] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.Memo].ToString().Trim(); //备注
objvgs_TotalDataStatisticsEN.Score = objRow[convgs_TotalDataStatistics.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_TotalDataStatistics.Score].ToString().Trim()); //评分
objvgs_TotalDataStatisticsEN.TeaScore = objRow[convgs_TotalDataStatistics.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_TotalDataStatistics.TeaScore].ToString().Trim()); //教师评分
objvgs_TotalDataStatisticsEN.WeekTimeRange = objRow[convgs_TotalDataStatistics.WeekTimeRange] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objvgs_TotalDataStatisticsEN.OnlyId = objRow[convgs_TotalDataStatistics.OnlyId] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.OnlyId].ToString().Trim(); //OnlyId
objvgs_TotalDataStatisticsEN.TotalDataTypeName = objRow[convgs_TotalDataStatistics.TotalDataTypeName] == DBNull.Value ? null : objRow[convgs_TotalDataStatistics.TotalDataTypeName].ToString().Trim(); //总数据类型名称
objvgs_TotalDataStatisticsEN.StuScore = objRow[convgs_TotalDataStatistics.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_TotalDataStatistics.StuScore].ToString().Trim()); //学生平均分
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_TotalDataStatisticsEN.TotalDataId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_TotalDataStatisticsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvgs_TotalDataStatisticsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvgs_TotalDataStatistics(ref clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsEN)
{
bool bolResult = vgs_TotalDataStatisticsDA.Getvgs_TotalDataStatistics(ref objvgs_TotalDataStatisticsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strTotalDataId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvgs_TotalDataStatisticsEN GetObjByTotalDataId(string strTotalDataId)
{
if (strTotalDataId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strTotalDataId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strTotalDataId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strTotalDataId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsEN = vgs_TotalDataStatisticsDA.GetObjByTotalDataId(strTotalDataId);
return objvgs_TotalDataStatisticsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvgs_TotalDataStatisticsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsEN = vgs_TotalDataStatisticsDA.GetFirstObj(strWhereCond);
 return objvgs_TotalDataStatisticsEN;
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
public static clsvgs_TotalDataStatisticsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsEN = vgs_TotalDataStatisticsDA.GetObjByDataRow(objRow);
 return objvgs_TotalDataStatisticsEN;
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
public static clsvgs_TotalDataStatisticsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsEN = vgs_TotalDataStatisticsDA.GetObjByDataRow(objRow);
 return objvgs_TotalDataStatisticsEN;
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
 /// <param name = "strTotalDataId">所给的关键字</param>
 /// <param name = "lstvgs_TotalDataStatisticsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvgs_TotalDataStatisticsEN GetObjByTotalDataIdFromList(string strTotalDataId, List<clsvgs_TotalDataStatisticsEN> lstvgs_TotalDataStatisticsObjLst)
{
foreach (clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsEN in lstvgs_TotalDataStatisticsObjLst)
{
if (objvgs_TotalDataStatisticsEN.TotalDataId == strTotalDataId)
{
return objvgs_TotalDataStatisticsEN;
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
public static string GetFirstID_S(string strWhereCond) 
{
 string strTotalDataId;
 try
 {
 strTotalDataId = new clsvgs_TotalDataStatisticsDA().GetFirstID(strWhereCond);
 return strTotalDataId;
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
 arrList = vgs_TotalDataStatisticsDA.GetID(strWhereCond);
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
bool bolIsExist = vgs_TotalDataStatisticsDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strTotalDataId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strTotalDataId)
{
if (string.IsNullOrEmpty(strTotalDataId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strTotalDataId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vgs_TotalDataStatisticsDA.IsExist(strTotalDataId);
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
 bolIsExist = clsvgs_TotalDataStatisticsDA.IsExistTable();
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
 bolIsExist = vgs_TotalDataStatisticsDA.IsExistTable(strTabName);
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


 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CopyObj_S)
 /// </summary>
 /// <param name = "objvgs_TotalDataStatisticsENS">源对象</param>
 /// <param name = "objvgs_TotalDataStatisticsENT">目标对象</param>
 public static void CopyTo(clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsENS, clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsENT)
{
try
{
objvgs_TotalDataStatisticsENT.TotalDataId = objvgs_TotalDataStatisticsENS.TotalDataId; //TotalDataId
objvgs_TotalDataStatisticsENT.IdCurrEduCls = objvgs_TotalDataStatisticsENS.IdCurrEduCls; //教学班流水号
objvgs_TotalDataStatisticsENT.EduClsName = objvgs_TotalDataStatisticsENS.EduClsName; //教学班名
objvgs_TotalDataStatisticsENT.SchoolYear = objvgs_TotalDataStatisticsENS.SchoolYear; //学年
objvgs_TotalDataStatisticsENT.TotalDataTypeId = objvgs_TotalDataStatisticsENS.TotalDataTypeId; //总数据类型Id
objvgs_TotalDataStatisticsENT.SchoolTerm = objvgs_TotalDataStatisticsENS.SchoolTerm; //学期
objvgs_TotalDataStatisticsENT.TableKey = objvgs_TotalDataStatisticsENS.TableKey; //表主键
objvgs_TotalDataStatisticsENT.DataUser = objvgs_TotalDataStatisticsENS.DataUser; //数据用户
objvgs_TotalDataStatisticsENT.DataAddDate = objvgs_TotalDataStatisticsENS.DataAddDate; //数据添加日期
objvgs_TotalDataStatisticsENT.DataTable = objvgs_TotalDataStatisticsENS.DataTable; //数据表
objvgs_TotalDataStatisticsENT.Month = objvgs_TotalDataStatisticsENS.Month; //月
objvgs_TotalDataStatisticsENT.DataTableId = objvgs_TotalDataStatisticsENS.DataTableId; //数据表Id
objvgs_TotalDataStatisticsENT.Week = objvgs_TotalDataStatisticsENS.Week; //周
objvgs_TotalDataStatisticsENT.UpdDate = objvgs_TotalDataStatisticsENS.UpdDate; //修改日期
objvgs_TotalDataStatisticsENT.UpdUser = objvgs_TotalDataStatisticsENS.UpdUser; //修改人
objvgs_TotalDataStatisticsENT.Memo = objvgs_TotalDataStatisticsENS.Memo; //备注
objvgs_TotalDataStatisticsENT.Score = objvgs_TotalDataStatisticsENS.Score; //评分
objvgs_TotalDataStatisticsENT.TeaScore = objvgs_TotalDataStatisticsENS.TeaScore; //教师评分
objvgs_TotalDataStatisticsENT.WeekTimeRange = objvgs_TotalDataStatisticsENS.WeekTimeRange; //WeekTimeRange
objvgs_TotalDataStatisticsENT.OnlyId = objvgs_TotalDataStatisticsENS.OnlyId; //OnlyId
objvgs_TotalDataStatisticsENT.TotalDataTypeName = objvgs_TotalDataStatisticsENS.TotalDataTypeName; //总数据类型名称
objvgs_TotalDataStatisticsENT.StuScore = objvgs_TotalDataStatisticsENS.StuScore; //学生平均分
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
 /// <param name = "objvgs_TotalDataStatisticsEN">源简化对象</param>
 public static void SetUpdFlag(clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsEN)
{
try
{
objvgs_TotalDataStatisticsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvgs_TotalDataStatisticsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convgs_TotalDataStatistics.TotalDataId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TotalDataStatisticsEN.TotalDataId = objvgs_TotalDataStatisticsEN.TotalDataId; //TotalDataId
}
if (arrFldSet.Contains(convgs_TotalDataStatistics.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TotalDataStatisticsEN.IdCurrEduCls = objvgs_TotalDataStatisticsEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convgs_TotalDataStatistics.EduClsName, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TotalDataStatisticsEN.EduClsName = objvgs_TotalDataStatisticsEN.EduClsName == "[null]" ? null :  objvgs_TotalDataStatisticsEN.EduClsName; //教学班名
}
if (arrFldSet.Contains(convgs_TotalDataStatistics.SchoolYear, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TotalDataStatisticsEN.SchoolYear = objvgs_TotalDataStatisticsEN.SchoolYear == "[null]" ? null :  objvgs_TotalDataStatisticsEN.SchoolYear; //学年
}
if (arrFldSet.Contains(convgs_TotalDataStatistics.TotalDataTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TotalDataStatisticsEN.TotalDataTypeId = objvgs_TotalDataStatisticsEN.TotalDataTypeId; //总数据类型Id
}
if (arrFldSet.Contains(convgs_TotalDataStatistics.SchoolTerm, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TotalDataStatisticsEN.SchoolTerm = objvgs_TotalDataStatisticsEN.SchoolTerm == "[null]" ? null :  objvgs_TotalDataStatisticsEN.SchoolTerm; //学期
}
if (arrFldSet.Contains(convgs_TotalDataStatistics.TableKey, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TotalDataStatisticsEN.TableKey = objvgs_TotalDataStatisticsEN.TableKey == "[null]" ? null :  objvgs_TotalDataStatisticsEN.TableKey; //表主键
}
if (arrFldSet.Contains(convgs_TotalDataStatistics.DataUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TotalDataStatisticsEN.DataUser = objvgs_TotalDataStatisticsEN.DataUser == "[null]" ? null :  objvgs_TotalDataStatisticsEN.DataUser; //数据用户
}
if (arrFldSet.Contains(convgs_TotalDataStatistics.DataAddDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TotalDataStatisticsEN.DataAddDate = objvgs_TotalDataStatisticsEN.DataAddDate == "[null]" ? null :  objvgs_TotalDataStatisticsEN.DataAddDate; //数据添加日期
}
if (arrFldSet.Contains(convgs_TotalDataStatistics.DataTable, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TotalDataStatisticsEN.DataTable = objvgs_TotalDataStatisticsEN.DataTable == "[null]" ? null :  objvgs_TotalDataStatisticsEN.DataTable; //数据表
}
if (arrFldSet.Contains(convgs_TotalDataStatistics.Month, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TotalDataStatisticsEN.Month = objvgs_TotalDataStatisticsEN.Month; //月
}
if (arrFldSet.Contains(convgs_TotalDataStatistics.DataTableId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TotalDataStatisticsEN.DataTableId = objvgs_TotalDataStatisticsEN.DataTableId == "[null]" ? null :  objvgs_TotalDataStatisticsEN.DataTableId; //数据表Id
}
if (arrFldSet.Contains(convgs_TotalDataStatistics.Week, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TotalDataStatisticsEN.Week = objvgs_TotalDataStatisticsEN.Week; //周
}
if (arrFldSet.Contains(convgs_TotalDataStatistics.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TotalDataStatisticsEN.UpdDate = objvgs_TotalDataStatisticsEN.UpdDate == "[null]" ? null :  objvgs_TotalDataStatisticsEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convgs_TotalDataStatistics.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TotalDataStatisticsEN.UpdUser = objvgs_TotalDataStatisticsEN.UpdUser == "[null]" ? null :  objvgs_TotalDataStatisticsEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convgs_TotalDataStatistics.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TotalDataStatisticsEN.Memo = objvgs_TotalDataStatisticsEN.Memo == "[null]" ? null :  objvgs_TotalDataStatisticsEN.Memo; //备注
}
if (arrFldSet.Contains(convgs_TotalDataStatistics.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TotalDataStatisticsEN.Score = objvgs_TotalDataStatisticsEN.Score; //评分
}
if (arrFldSet.Contains(convgs_TotalDataStatistics.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TotalDataStatisticsEN.TeaScore = objvgs_TotalDataStatisticsEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(convgs_TotalDataStatistics.WeekTimeRange, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TotalDataStatisticsEN.WeekTimeRange = objvgs_TotalDataStatisticsEN.WeekTimeRange == "[null]" ? null :  objvgs_TotalDataStatisticsEN.WeekTimeRange; //WeekTimeRange
}
if (arrFldSet.Contains(convgs_TotalDataStatistics.OnlyId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TotalDataStatisticsEN.OnlyId = objvgs_TotalDataStatisticsEN.OnlyId == "[null]" ? null :  objvgs_TotalDataStatisticsEN.OnlyId; //OnlyId
}
if (arrFldSet.Contains(convgs_TotalDataStatistics.TotalDataTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TotalDataStatisticsEN.TotalDataTypeName = objvgs_TotalDataStatisticsEN.TotalDataTypeName == "[null]" ? null :  objvgs_TotalDataStatisticsEN.TotalDataTypeName; //总数据类型名称
}
if (arrFldSet.Contains(convgs_TotalDataStatistics.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TotalDataStatisticsEN.StuScore = objvgs_TotalDataStatisticsEN.StuScore; //学生平均分
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
 /// <param name = "objvgs_TotalDataStatisticsEN">源简化对象</param>
 public static void AccessFldValueNull(clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsEN)
{
try
{
if (objvgs_TotalDataStatisticsEN.EduClsName == "[null]") objvgs_TotalDataStatisticsEN.EduClsName = null; //教学班名
if (objvgs_TotalDataStatisticsEN.SchoolYear == "[null]") objvgs_TotalDataStatisticsEN.SchoolYear = null; //学年
if (objvgs_TotalDataStatisticsEN.SchoolTerm == "[null]") objvgs_TotalDataStatisticsEN.SchoolTerm = null; //学期
if (objvgs_TotalDataStatisticsEN.TableKey == "[null]") objvgs_TotalDataStatisticsEN.TableKey = null; //表主键
if (objvgs_TotalDataStatisticsEN.DataUser == "[null]") objvgs_TotalDataStatisticsEN.DataUser = null; //数据用户
if (objvgs_TotalDataStatisticsEN.DataAddDate == "[null]") objvgs_TotalDataStatisticsEN.DataAddDate = null; //数据添加日期
if (objvgs_TotalDataStatisticsEN.DataTable == "[null]") objvgs_TotalDataStatisticsEN.DataTable = null; //数据表
if (objvgs_TotalDataStatisticsEN.DataTableId == "[null]") objvgs_TotalDataStatisticsEN.DataTableId = null; //数据表Id
if (objvgs_TotalDataStatisticsEN.UpdDate == "[null]") objvgs_TotalDataStatisticsEN.UpdDate = null; //修改日期
if (objvgs_TotalDataStatisticsEN.UpdUser == "[null]") objvgs_TotalDataStatisticsEN.UpdUser = null; //修改人
if (objvgs_TotalDataStatisticsEN.Memo == "[null]") objvgs_TotalDataStatisticsEN.Memo = null; //备注
if (objvgs_TotalDataStatisticsEN.WeekTimeRange == "[null]") objvgs_TotalDataStatisticsEN.WeekTimeRange = null; //WeekTimeRange
if (objvgs_TotalDataStatisticsEN.OnlyId == "[null]") objvgs_TotalDataStatisticsEN.OnlyId = null; //OnlyId
if (objvgs_TotalDataStatisticsEN.TotalDataTypeName == "[null]") objvgs_TotalDataStatisticsEN.TotalDataTypeName = null; //总数据类型名称
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
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsEN)
{
 vgs_TotalDataStatisticsDA.CheckProperty4Condition(objvgs_TotalDataStatisticsEN);
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
if (clsCurrEduClsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCurrEduClsBL没有刷新缓存机制(clsCurrEduClsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsgs_TotalDataStatisticsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_TotalDataStatisticsBL没有刷新缓存机制(clsgs_TotalDataStatisticsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsgs_TotalDataTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_TotalDataTypeBL没有刷新缓存机制(clsgs_TotalDataTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by TotalDataId");
//if (arrvgs_TotalDataStatisticsObjLstCache == null)
//{
//arrvgs_TotalDataStatisticsObjLstCache = vgs_TotalDataStatisticsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strTotalDataId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvgs_TotalDataStatisticsEN GetObjByTotalDataIdCache(string strTotalDataId, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvgs_TotalDataStatisticsEN._CurrTabName, strIdCurrEduCls);
List<clsvgs_TotalDataStatisticsEN> arrvgs_TotalDataStatisticsObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvgs_TotalDataStatisticsEN> arrvgs_TotalDataStatisticsObjLst_Sel =
arrvgs_TotalDataStatisticsObjLstCache
.Where(x=> x.TotalDataId == strTotalDataId 
);
if (arrvgs_TotalDataStatisticsObjLst_Sel.Count() == 0)
{
   clsvgs_TotalDataStatisticsEN obj = clsvgs_TotalDataStatisticsBL.GetObjByTotalDataId(strTotalDataId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strTotalDataId, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvgs_TotalDataStatisticsObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvgs_TotalDataStatisticsEN> GetAllvgs_TotalDataStatisticsObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsvgs_TotalDataStatisticsEN> arrvgs_TotalDataStatisticsObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrvgs_TotalDataStatisticsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvgs_TotalDataStatisticsEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvgs_TotalDataStatisticsEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsvgs_TotalDataStatisticsEN> arrvgs_TotalDataStatisticsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvgs_TotalDataStatisticsObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvgs_TotalDataStatisticsEN._CurrTabName, strIdCurrEduCls);
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


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-08-24
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strTotalDataId, string strIdCurrEduCls)
{
if (strInFldName != convgs_TotalDataStatistics.TotalDataId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convgs_TotalDataStatistics.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convgs_TotalDataStatistics.AttributeName));
throw new Exception(strMsg);
}
var objvgs_TotalDataStatistics = clsvgs_TotalDataStatisticsBL.GetObjByTotalDataIdCache(strTotalDataId, strIdCurrEduCls);
if (objvgs_TotalDataStatistics == null) return "";
return objvgs_TotalDataStatistics[strOutFldName].ToString();
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
int intRecCount = clsvgs_TotalDataStatisticsDA.GetRecCount(strTabName);
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
int intRecCount = clsvgs_TotalDataStatisticsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvgs_TotalDataStatisticsDA.GetRecCount();
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
int intRecCount = clsvgs_TotalDataStatisticsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvgs_TotalDataStatisticsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvgs_TotalDataStatisticsEN objvgs_TotalDataStatisticsCond)
{
 string strIdCurrEduCls = objvgs_TotalDataStatisticsCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvgs_TotalDataStatisticsBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvgs_TotalDataStatisticsEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvgs_TotalDataStatisticsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convgs_TotalDataStatistics.AttributeName)
{
if (objvgs_TotalDataStatisticsCond.IsUpdated(strFldName) == false) continue;
if (objvgs_TotalDataStatisticsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_TotalDataStatisticsCond[strFldName].ToString());
}
else
{
if (objvgs_TotalDataStatisticsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvgs_TotalDataStatisticsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_TotalDataStatisticsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvgs_TotalDataStatisticsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvgs_TotalDataStatisticsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvgs_TotalDataStatisticsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvgs_TotalDataStatisticsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvgs_TotalDataStatisticsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvgs_TotalDataStatisticsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvgs_TotalDataStatisticsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvgs_TotalDataStatisticsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvgs_TotalDataStatisticsCond[strFldName]));
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
 List<string> arrList = clsvgs_TotalDataStatisticsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vgs_TotalDataStatisticsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vgs_TotalDataStatisticsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}