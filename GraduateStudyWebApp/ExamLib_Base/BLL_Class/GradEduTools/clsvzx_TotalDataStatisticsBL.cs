
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_TotalDataStatisticsBL
 表名:vzx_TotalDataStatistics(01120841)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:14:27
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
public static class  clsvzx_TotalDataStatisticsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strTotalDataId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_TotalDataStatisticsEN GetObj(this K_TotalDataId_vzx_TotalDataStatistics myKey)
{
clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsEN = clsvzx_TotalDataStatisticsBL.vzx_TotalDataStatisticsDA.GetObjByTotalDataId(myKey.Value);
return objvzx_TotalDataStatisticsEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TotalDataStatisticsEN SetEduClsName(this clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsEN, string strEduClsName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduClsName, 100, convzx_TotalDataStatistics.EduClsName);
}
objvzx_TotalDataStatisticsEN.EduClsName = strEduClsName; //教学班名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(convzx_TotalDataStatistics.EduClsName) == false)
{
objvzx_TotalDataStatisticsEN.dicFldComparisonOp.Add(convzx_TotalDataStatistics.EduClsName, strComparisonOp);
}
else
{
objvzx_TotalDataStatisticsEN.dicFldComparisonOp[convzx_TotalDataStatistics.EduClsName] = strComparisonOp;
}
}
return objvzx_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TotalDataStatisticsEN SetTotalDataId(this clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsEN, string strTotalDataId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTotalDataId, 12, convzx_TotalDataStatistics.TotalDataId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTotalDataId, 12, convzx_TotalDataStatistics.TotalDataId);
}
objvzx_TotalDataStatisticsEN.TotalDataId = strTotalDataId; //TotalDataId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(convzx_TotalDataStatistics.TotalDataId) == false)
{
objvzx_TotalDataStatisticsEN.dicFldComparisonOp.Add(convzx_TotalDataStatistics.TotalDataId, strComparisonOp);
}
else
{
objvzx_TotalDataStatisticsEN.dicFldComparisonOp[convzx_TotalDataStatistics.TotalDataId] = strComparisonOp;
}
}
return objvzx_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TotalDataStatisticsEN SetIdCurrEduCls(this clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsEN, string strIdCurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdCurrEduCls, convzx_TotalDataStatistics.IdCurrEduCls);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convzx_TotalDataStatistics.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convzx_TotalDataStatistics.IdCurrEduCls);
}
objvzx_TotalDataStatisticsEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(convzx_TotalDataStatistics.IdCurrEduCls) == false)
{
objvzx_TotalDataStatisticsEN.dicFldComparisonOp.Add(convzx_TotalDataStatistics.IdCurrEduCls, strComparisonOp);
}
else
{
objvzx_TotalDataStatisticsEN.dicFldComparisonOp[convzx_TotalDataStatistics.IdCurrEduCls] = strComparisonOp;
}
}
return objvzx_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TotalDataStatisticsEN SetzxTotalDataTypeId(this clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsEN, string strzxTotalDataTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strzxTotalDataTypeId, convzx_TotalDataStatistics.zxTotalDataTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxTotalDataTypeId, 2, convzx_TotalDataStatistics.zxTotalDataTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxTotalDataTypeId, 2, convzx_TotalDataStatistics.zxTotalDataTypeId);
}
objvzx_TotalDataStatisticsEN.zxTotalDataTypeId = strzxTotalDataTypeId; //总数据类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(convzx_TotalDataStatistics.zxTotalDataTypeId) == false)
{
objvzx_TotalDataStatisticsEN.dicFldComparisonOp.Add(convzx_TotalDataStatistics.zxTotalDataTypeId, strComparisonOp);
}
else
{
objvzx_TotalDataStatisticsEN.dicFldComparisonOp[convzx_TotalDataStatistics.zxTotalDataTypeId] = strComparisonOp;
}
}
return objvzx_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TotalDataStatisticsEN SetTableKey(this clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsEN, string strTableKey, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTableKey, 20, convzx_TotalDataStatistics.TableKey);
}
objvzx_TotalDataStatisticsEN.TableKey = strTableKey; //表主键
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(convzx_TotalDataStatistics.TableKey) == false)
{
objvzx_TotalDataStatisticsEN.dicFldComparisonOp.Add(convzx_TotalDataStatistics.TableKey, strComparisonOp);
}
else
{
objvzx_TotalDataStatisticsEN.dicFldComparisonOp[convzx_TotalDataStatistics.TableKey] = strComparisonOp;
}
}
return objvzx_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TotalDataStatisticsEN SetDataUser(this clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsEN, string strDataUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataUser, 20, convzx_TotalDataStatistics.DataUser);
}
objvzx_TotalDataStatisticsEN.DataUser = strDataUser; //数据用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(convzx_TotalDataStatistics.DataUser) == false)
{
objvzx_TotalDataStatisticsEN.dicFldComparisonOp.Add(convzx_TotalDataStatistics.DataUser, strComparisonOp);
}
else
{
objvzx_TotalDataStatisticsEN.dicFldComparisonOp[convzx_TotalDataStatistics.DataUser] = strComparisonOp;
}
}
return objvzx_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TotalDataStatisticsEN SetDataAddDate(this clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsEN, string strDataAddDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataAddDate, 20, convzx_TotalDataStatistics.DataAddDate);
}
objvzx_TotalDataStatisticsEN.DataAddDate = strDataAddDate; //数据添加日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(convzx_TotalDataStatistics.DataAddDate) == false)
{
objvzx_TotalDataStatisticsEN.dicFldComparisonOp.Add(convzx_TotalDataStatistics.DataAddDate, strComparisonOp);
}
else
{
objvzx_TotalDataStatisticsEN.dicFldComparisonOp[convzx_TotalDataStatistics.DataAddDate] = strComparisonOp;
}
}
return objvzx_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TotalDataStatisticsEN SetMonth(this clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsEN, int? intMonth, string strComparisonOp="")
	{
objvzx_TotalDataStatisticsEN.Month = intMonth; //月
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(convzx_TotalDataStatistics.Month) == false)
{
objvzx_TotalDataStatisticsEN.dicFldComparisonOp.Add(convzx_TotalDataStatistics.Month, strComparisonOp);
}
else
{
objvzx_TotalDataStatisticsEN.dicFldComparisonOp[convzx_TotalDataStatistics.Month] = strComparisonOp;
}
}
return objvzx_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TotalDataStatisticsEN SetWeek(this clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsEN, int? intWeek, string strComparisonOp="")
	{
objvzx_TotalDataStatisticsEN.Week = intWeek; //周
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(convzx_TotalDataStatistics.Week) == false)
{
objvzx_TotalDataStatisticsEN.dicFldComparisonOp.Add(convzx_TotalDataStatistics.Week, strComparisonOp);
}
else
{
objvzx_TotalDataStatisticsEN.dicFldComparisonOp[convzx_TotalDataStatistics.Week] = strComparisonOp;
}
}
return objvzx_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TotalDataStatisticsEN SetUpdDate(this clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convzx_TotalDataStatistics.UpdDate);
}
objvzx_TotalDataStatisticsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(convzx_TotalDataStatistics.UpdDate) == false)
{
objvzx_TotalDataStatisticsEN.dicFldComparisonOp.Add(convzx_TotalDataStatistics.UpdDate, strComparisonOp);
}
else
{
objvzx_TotalDataStatisticsEN.dicFldComparisonOp[convzx_TotalDataStatistics.UpdDate] = strComparisonOp;
}
}
return objvzx_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TotalDataStatisticsEN SetUpdUser(this clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convzx_TotalDataStatistics.UpdUser);
}
objvzx_TotalDataStatisticsEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(convzx_TotalDataStatistics.UpdUser) == false)
{
objvzx_TotalDataStatisticsEN.dicFldComparisonOp.Add(convzx_TotalDataStatistics.UpdUser, strComparisonOp);
}
else
{
objvzx_TotalDataStatisticsEN.dicFldComparisonOp[convzx_TotalDataStatistics.UpdUser] = strComparisonOp;
}
}
return objvzx_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TotalDataStatisticsEN SetMemo(this clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convzx_TotalDataStatistics.Memo);
}
objvzx_TotalDataStatisticsEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(convzx_TotalDataStatistics.Memo) == false)
{
objvzx_TotalDataStatisticsEN.dicFldComparisonOp.Add(convzx_TotalDataStatistics.Memo, strComparisonOp);
}
else
{
objvzx_TotalDataStatisticsEN.dicFldComparisonOp[convzx_TotalDataStatistics.Memo] = strComparisonOp;
}
}
return objvzx_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TotalDataStatisticsEN SetScore(this clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsEN, float? fltScore, string strComparisonOp="")
	{
objvzx_TotalDataStatisticsEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(convzx_TotalDataStatistics.Score) == false)
{
objvzx_TotalDataStatisticsEN.dicFldComparisonOp.Add(convzx_TotalDataStatistics.Score, strComparisonOp);
}
else
{
objvzx_TotalDataStatisticsEN.dicFldComparisonOp[convzx_TotalDataStatistics.Score] = strComparisonOp;
}
}
return objvzx_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TotalDataStatisticsEN SetTeaScore(this clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsEN, float? fltTeaScore, string strComparisonOp="")
	{
objvzx_TotalDataStatisticsEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(convzx_TotalDataStatistics.TeaScore) == false)
{
objvzx_TotalDataStatisticsEN.dicFldComparisonOp.Add(convzx_TotalDataStatistics.TeaScore, strComparisonOp);
}
else
{
objvzx_TotalDataStatisticsEN.dicFldComparisonOp[convzx_TotalDataStatistics.TeaScore] = strComparisonOp;
}
}
return objvzx_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TotalDataStatisticsEN SetWeekTimeRange(this clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsEN, string strWeekTimeRange, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWeekTimeRange, 100, convzx_TotalDataStatistics.WeekTimeRange);
}
objvzx_TotalDataStatisticsEN.WeekTimeRange = strWeekTimeRange; //WeekTimeRange
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(convzx_TotalDataStatistics.WeekTimeRange) == false)
{
objvzx_TotalDataStatisticsEN.dicFldComparisonOp.Add(convzx_TotalDataStatistics.WeekTimeRange, strComparisonOp);
}
else
{
objvzx_TotalDataStatisticsEN.dicFldComparisonOp[convzx_TotalDataStatistics.WeekTimeRange] = strComparisonOp;
}
}
return objvzx_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TotalDataStatisticsEN SetStuScore(this clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsEN, float? fltStuScore, string strComparisonOp="")
	{
objvzx_TotalDataStatisticsEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(convzx_TotalDataStatistics.StuScore) == false)
{
objvzx_TotalDataStatisticsEN.dicFldComparisonOp.Add(convzx_TotalDataStatistics.StuScore, strComparisonOp);
}
else
{
objvzx_TotalDataStatisticsEN.dicFldComparisonOp[convzx_TotalDataStatistics.StuScore] = strComparisonOp;
}
}
return objvzx_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TotalDataStatisticsEN SetOnlyId(this clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsEN, string strOnlyId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOnlyId, 20, convzx_TotalDataStatistics.OnlyId);
}
objvzx_TotalDataStatisticsEN.OnlyId = strOnlyId; //OnlyId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(convzx_TotalDataStatistics.OnlyId) == false)
{
objvzx_TotalDataStatisticsEN.dicFldComparisonOp.Add(convzx_TotalDataStatistics.OnlyId, strComparisonOp);
}
else
{
objvzx_TotalDataStatisticsEN.dicFldComparisonOp[convzx_TotalDataStatistics.OnlyId] = strComparisonOp;
}
}
return objvzx_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TotalDataStatisticsEN SetDataTableId(this clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsEN, string strDataTableId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataTableId, 50, convzx_TotalDataStatistics.DataTableId);
}
objvzx_TotalDataStatisticsEN.DataTableId = strDataTableId; //数据表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(convzx_TotalDataStatistics.DataTableId) == false)
{
objvzx_TotalDataStatisticsEN.dicFldComparisonOp.Add(convzx_TotalDataStatistics.DataTableId, strComparisonOp);
}
else
{
objvzx_TotalDataStatisticsEN.dicFldComparisonOp[convzx_TotalDataStatistics.DataTableId] = strComparisonOp;
}
}
return objvzx_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TotalDataStatisticsEN SetDataTable(this clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsEN, string strDataTable, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataTable, 100, convzx_TotalDataStatistics.DataTable);
}
objvzx_TotalDataStatisticsEN.DataTable = strDataTable; //数据表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(convzx_TotalDataStatistics.DataTable) == false)
{
objvzx_TotalDataStatisticsEN.dicFldComparisonOp.Add(convzx_TotalDataStatistics.DataTable, strComparisonOp);
}
else
{
objvzx_TotalDataStatisticsEN.dicFldComparisonOp[convzx_TotalDataStatistics.DataTable] = strComparisonOp;
}
}
return objvzx_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TotalDataStatisticsEN SetTotalDataTypeName(this clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsEN, string strTotalDataTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTotalDataTypeName, 500, convzx_TotalDataStatistics.TotalDataTypeName);
}
objvzx_TotalDataStatisticsEN.TotalDataTypeName = strTotalDataTypeName; //总数据类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(convzx_TotalDataStatistics.TotalDataTypeName) == false)
{
objvzx_TotalDataStatisticsEN.dicFldComparisonOp.Add(convzx_TotalDataStatistics.TotalDataTypeName, strComparisonOp);
}
else
{
objvzx_TotalDataStatisticsEN.dicFldComparisonOp[convzx_TotalDataStatistics.TotalDataTypeName] = strComparisonOp;
}
}
return objvzx_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TotalDataStatisticsEN SetSchoolTerm(this clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsEN, string strSchoolTerm, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, convzx_TotalDataStatistics.SchoolTerm);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, convzx_TotalDataStatistics.SchoolTerm);
}
objvzx_TotalDataStatisticsEN.SchoolTerm = strSchoolTerm; //学期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(convzx_TotalDataStatistics.SchoolTerm) == false)
{
objvzx_TotalDataStatisticsEN.dicFldComparisonOp.Add(convzx_TotalDataStatistics.SchoolTerm, strComparisonOp);
}
else
{
objvzx_TotalDataStatisticsEN.dicFldComparisonOp[convzx_TotalDataStatistics.SchoolTerm] = strComparisonOp;
}
}
return objvzx_TotalDataStatisticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TotalDataStatisticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TotalDataStatisticsEN SetSchoolYear(this clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsEN, string strSchoolYear, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, convzx_TotalDataStatistics.SchoolYear);
}
objvzx_TotalDataStatisticsEN.SchoolYear = strSchoolYear; //学年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TotalDataStatisticsEN.dicFldComparisonOp.ContainsKey(convzx_TotalDataStatistics.SchoolYear) == false)
{
objvzx_TotalDataStatisticsEN.dicFldComparisonOp.Add(convzx_TotalDataStatistics.SchoolYear, strComparisonOp);
}
else
{
objvzx_TotalDataStatisticsEN.dicFldComparisonOp[convzx_TotalDataStatistics.SchoolYear] = strComparisonOp;
}
}
return objvzx_TotalDataStatisticsEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvzx_TotalDataStatisticsENS">源对象</param>
 /// <param name = "objvzx_TotalDataStatisticsENT">目标对象</param>
 public static void CopyTo(this clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsENS, clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsENT)
{
try
{
objvzx_TotalDataStatisticsENT.EduClsName = objvzx_TotalDataStatisticsENS.EduClsName; //教学班名
objvzx_TotalDataStatisticsENT.TotalDataId = objvzx_TotalDataStatisticsENS.TotalDataId; //TotalDataId
objvzx_TotalDataStatisticsENT.IdCurrEduCls = objvzx_TotalDataStatisticsENS.IdCurrEduCls; //教学班流水号
objvzx_TotalDataStatisticsENT.zxTotalDataTypeId = objvzx_TotalDataStatisticsENS.zxTotalDataTypeId; //总数据类型Id
objvzx_TotalDataStatisticsENT.TableKey = objvzx_TotalDataStatisticsENS.TableKey; //表主键
objvzx_TotalDataStatisticsENT.DataUser = objvzx_TotalDataStatisticsENS.DataUser; //数据用户
objvzx_TotalDataStatisticsENT.DataAddDate = objvzx_TotalDataStatisticsENS.DataAddDate; //数据添加日期
objvzx_TotalDataStatisticsENT.Month = objvzx_TotalDataStatisticsENS.Month; //月
objvzx_TotalDataStatisticsENT.Week = objvzx_TotalDataStatisticsENS.Week; //周
objvzx_TotalDataStatisticsENT.UpdDate = objvzx_TotalDataStatisticsENS.UpdDate; //修改日期
objvzx_TotalDataStatisticsENT.UpdUser = objvzx_TotalDataStatisticsENS.UpdUser; //修改人
objvzx_TotalDataStatisticsENT.Memo = objvzx_TotalDataStatisticsENS.Memo; //备注
objvzx_TotalDataStatisticsENT.Score = objvzx_TotalDataStatisticsENS.Score; //评分
objvzx_TotalDataStatisticsENT.TeaScore = objvzx_TotalDataStatisticsENS.TeaScore; //教师评分
objvzx_TotalDataStatisticsENT.WeekTimeRange = objvzx_TotalDataStatisticsENS.WeekTimeRange; //WeekTimeRange
objvzx_TotalDataStatisticsENT.StuScore = objvzx_TotalDataStatisticsENS.StuScore; //学生平均分
objvzx_TotalDataStatisticsENT.OnlyId = objvzx_TotalDataStatisticsENS.OnlyId; //OnlyId
objvzx_TotalDataStatisticsENT.DataTableId = objvzx_TotalDataStatisticsENS.DataTableId; //数据表Id
objvzx_TotalDataStatisticsENT.DataTable = objvzx_TotalDataStatisticsENS.DataTable; //数据表
objvzx_TotalDataStatisticsENT.TotalDataTypeName = objvzx_TotalDataStatisticsENS.TotalDataTypeName; //总数据类型名称
objvzx_TotalDataStatisticsENT.SchoolTerm = objvzx_TotalDataStatisticsENS.SchoolTerm; //学期
objvzx_TotalDataStatisticsENT.SchoolYear = objvzx_TotalDataStatisticsENS.SchoolYear; //学年
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
 /// <param name = "objvzx_TotalDataStatisticsENS">源对象</param>
 /// <returns>目标对象=>clsvzx_TotalDataStatisticsEN:objvzx_TotalDataStatisticsENT</returns>
 public static clsvzx_TotalDataStatisticsEN CopyTo(this clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsENS)
{
try
{
 clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsENT = new clsvzx_TotalDataStatisticsEN()
{
EduClsName = objvzx_TotalDataStatisticsENS.EduClsName, //教学班名
TotalDataId = objvzx_TotalDataStatisticsENS.TotalDataId, //TotalDataId
IdCurrEduCls = objvzx_TotalDataStatisticsENS.IdCurrEduCls, //教学班流水号
zxTotalDataTypeId = objvzx_TotalDataStatisticsENS.zxTotalDataTypeId, //总数据类型Id
TableKey = objvzx_TotalDataStatisticsENS.TableKey, //表主键
DataUser = objvzx_TotalDataStatisticsENS.DataUser, //数据用户
DataAddDate = objvzx_TotalDataStatisticsENS.DataAddDate, //数据添加日期
Month = objvzx_TotalDataStatisticsENS.Month, //月
Week = objvzx_TotalDataStatisticsENS.Week, //周
UpdDate = objvzx_TotalDataStatisticsENS.UpdDate, //修改日期
UpdUser = objvzx_TotalDataStatisticsENS.UpdUser, //修改人
Memo = objvzx_TotalDataStatisticsENS.Memo, //备注
Score = objvzx_TotalDataStatisticsENS.Score, //评分
TeaScore = objvzx_TotalDataStatisticsENS.TeaScore, //教师评分
WeekTimeRange = objvzx_TotalDataStatisticsENS.WeekTimeRange, //WeekTimeRange
StuScore = objvzx_TotalDataStatisticsENS.StuScore, //学生平均分
OnlyId = objvzx_TotalDataStatisticsENS.OnlyId, //OnlyId
DataTableId = objvzx_TotalDataStatisticsENS.DataTableId, //数据表Id
DataTable = objvzx_TotalDataStatisticsENS.DataTable, //数据表
TotalDataTypeName = objvzx_TotalDataStatisticsENS.TotalDataTypeName, //总数据类型名称
SchoolTerm = objvzx_TotalDataStatisticsENS.SchoolTerm, //学期
SchoolYear = objvzx_TotalDataStatisticsENS.SchoolYear, //学年
};
 return objvzx_TotalDataStatisticsENT;
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
public static void CheckProperty4Condition(this clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsEN)
{
 clsvzx_TotalDataStatisticsBL.vzx_TotalDataStatisticsDA.CheckProperty4Condition(objvzx_TotalDataStatisticsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvzx_TotalDataStatisticsCond.IsUpdated(convzx_TotalDataStatistics.EduClsName) == true)
{
string strComparisonOpEduClsName = objvzx_TotalDataStatisticsCond.dicFldComparisonOp[convzx_TotalDataStatistics.EduClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TotalDataStatistics.EduClsName, objvzx_TotalDataStatisticsCond.EduClsName, strComparisonOpEduClsName);
}
if (objvzx_TotalDataStatisticsCond.IsUpdated(convzx_TotalDataStatistics.TotalDataId) == true)
{
string strComparisonOpTotalDataId = objvzx_TotalDataStatisticsCond.dicFldComparisonOp[convzx_TotalDataStatistics.TotalDataId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TotalDataStatistics.TotalDataId, objvzx_TotalDataStatisticsCond.TotalDataId, strComparisonOpTotalDataId);
}
if (objvzx_TotalDataStatisticsCond.IsUpdated(convzx_TotalDataStatistics.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvzx_TotalDataStatisticsCond.dicFldComparisonOp[convzx_TotalDataStatistics.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TotalDataStatistics.IdCurrEduCls, objvzx_TotalDataStatisticsCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvzx_TotalDataStatisticsCond.IsUpdated(convzx_TotalDataStatistics.zxTotalDataTypeId) == true)
{
string strComparisonOpzxTotalDataTypeId = objvzx_TotalDataStatisticsCond.dicFldComparisonOp[convzx_TotalDataStatistics.zxTotalDataTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TotalDataStatistics.zxTotalDataTypeId, objvzx_TotalDataStatisticsCond.zxTotalDataTypeId, strComparisonOpzxTotalDataTypeId);
}
if (objvzx_TotalDataStatisticsCond.IsUpdated(convzx_TotalDataStatistics.TableKey) == true)
{
string strComparisonOpTableKey = objvzx_TotalDataStatisticsCond.dicFldComparisonOp[convzx_TotalDataStatistics.TableKey];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TotalDataStatistics.TableKey, objvzx_TotalDataStatisticsCond.TableKey, strComparisonOpTableKey);
}
if (objvzx_TotalDataStatisticsCond.IsUpdated(convzx_TotalDataStatistics.DataUser) == true)
{
string strComparisonOpDataUser = objvzx_TotalDataStatisticsCond.dicFldComparisonOp[convzx_TotalDataStatistics.DataUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TotalDataStatistics.DataUser, objvzx_TotalDataStatisticsCond.DataUser, strComparisonOpDataUser);
}
if (objvzx_TotalDataStatisticsCond.IsUpdated(convzx_TotalDataStatistics.DataAddDate) == true)
{
string strComparisonOpDataAddDate = objvzx_TotalDataStatisticsCond.dicFldComparisonOp[convzx_TotalDataStatistics.DataAddDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TotalDataStatistics.DataAddDate, objvzx_TotalDataStatisticsCond.DataAddDate, strComparisonOpDataAddDate);
}
if (objvzx_TotalDataStatisticsCond.IsUpdated(convzx_TotalDataStatistics.Month) == true)
{
string strComparisonOpMonth = objvzx_TotalDataStatisticsCond.dicFldComparisonOp[convzx_TotalDataStatistics.Month];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_TotalDataStatistics.Month, objvzx_TotalDataStatisticsCond.Month, strComparisonOpMonth);
}
if (objvzx_TotalDataStatisticsCond.IsUpdated(convzx_TotalDataStatistics.Week) == true)
{
string strComparisonOpWeek = objvzx_TotalDataStatisticsCond.dicFldComparisonOp[convzx_TotalDataStatistics.Week];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_TotalDataStatistics.Week, objvzx_TotalDataStatisticsCond.Week, strComparisonOpWeek);
}
if (objvzx_TotalDataStatisticsCond.IsUpdated(convzx_TotalDataStatistics.UpdDate) == true)
{
string strComparisonOpUpdDate = objvzx_TotalDataStatisticsCond.dicFldComparisonOp[convzx_TotalDataStatistics.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TotalDataStatistics.UpdDate, objvzx_TotalDataStatisticsCond.UpdDate, strComparisonOpUpdDate);
}
if (objvzx_TotalDataStatisticsCond.IsUpdated(convzx_TotalDataStatistics.UpdUser) == true)
{
string strComparisonOpUpdUser = objvzx_TotalDataStatisticsCond.dicFldComparisonOp[convzx_TotalDataStatistics.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TotalDataStatistics.UpdUser, objvzx_TotalDataStatisticsCond.UpdUser, strComparisonOpUpdUser);
}
if (objvzx_TotalDataStatisticsCond.IsUpdated(convzx_TotalDataStatistics.Memo) == true)
{
string strComparisonOpMemo = objvzx_TotalDataStatisticsCond.dicFldComparisonOp[convzx_TotalDataStatistics.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TotalDataStatistics.Memo, objvzx_TotalDataStatisticsCond.Memo, strComparisonOpMemo);
}
if (objvzx_TotalDataStatisticsCond.IsUpdated(convzx_TotalDataStatistics.Score) == true)
{
string strComparisonOpScore = objvzx_TotalDataStatisticsCond.dicFldComparisonOp[convzx_TotalDataStatistics.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_TotalDataStatistics.Score, objvzx_TotalDataStatisticsCond.Score, strComparisonOpScore);
}
if (objvzx_TotalDataStatisticsCond.IsUpdated(convzx_TotalDataStatistics.TeaScore) == true)
{
string strComparisonOpTeaScore = objvzx_TotalDataStatisticsCond.dicFldComparisonOp[convzx_TotalDataStatistics.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_TotalDataStatistics.TeaScore, objvzx_TotalDataStatisticsCond.TeaScore, strComparisonOpTeaScore);
}
if (objvzx_TotalDataStatisticsCond.IsUpdated(convzx_TotalDataStatistics.WeekTimeRange) == true)
{
string strComparisonOpWeekTimeRange = objvzx_TotalDataStatisticsCond.dicFldComparisonOp[convzx_TotalDataStatistics.WeekTimeRange];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TotalDataStatistics.WeekTimeRange, objvzx_TotalDataStatisticsCond.WeekTimeRange, strComparisonOpWeekTimeRange);
}
if (objvzx_TotalDataStatisticsCond.IsUpdated(convzx_TotalDataStatistics.StuScore) == true)
{
string strComparisonOpStuScore = objvzx_TotalDataStatisticsCond.dicFldComparisonOp[convzx_TotalDataStatistics.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_TotalDataStatistics.StuScore, objvzx_TotalDataStatisticsCond.StuScore, strComparisonOpStuScore);
}
if (objvzx_TotalDataStatisticsCond.IsUpdated(convzx_TotalDataStatistics.OnlyId) == true)
{
string strComparisonOpOnlyId = objvzx_TotalDataStatisticsCond.dicFldComparisonOp[convzx_TotalDataStatistics.OnlyId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TotalDataStatistics.OnlyId, objvzx_TotalDataStatisticsCond.OnlyId, strComparisonOpOnlyId);
}
if (objvzx_TotalDataStatisticsCond.IsUpdated(convzx_TotalDataStatistics.DataTableId) == true)
{
string strComparisonOpDataTableId = objvzx_TotalDataStatisticsCond.dicFldComparisonOp[convzx_TotalDataStatistics.DataTableId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TotalDataStatistics.DataTableId, objvzx_TotalDataStatisticsCond.DataTableId, strComparisonOpDataTableId);
}
if (objvzx_TotalDataStatisticsCond.IsUpdated(convzx_TotalDataStatistics.DataTable) == true)
{
string strComparisonOpDataTable = objvzx_TotalDataStatisticsCond.dicFldComparisonOp[convzx_TotalDataStatistics.DataTable];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TotalDataStatistics.DataTable, objvzx_TotalDataStatisticsCond.DataTable, strComparisonOpDataTable);
}
if (objvzx_TotalDataStatisticsCond.IsUpdated(convzx_TotalDataStatistics.TotalDataTypeName) == true)
{
string strComparisonOpTotalDataTypeName = objvzx_TotalDataStatisticsCond.dicFldComparisonOp[convzx_TotalDataStatistics.TotalDataTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TotalDataStatistics.TotalDataTypeName, objvzx_TotalDataStatisticsCond.TotalDataTypeName, strComparisonOpTotalDataTypeName);
}
if (objvzx_TotalDataStatisticsCond.IsUpdated(convzx_TotalDataStatistics.SchoolTerm) == true)
{
string strComparisonOpSchoolTerm = objvzx_TotalDataStatisticsCond.dicFldComparisonOp[convzx_TotalDataStatistics.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TotalDataStatistics.SchoolTerm, objvzx_TotalDataStatisticsCond.SchoolTerm, strComparisonOpSchoolTerm);
}
if (objvzx_TotalDataStatisticsCond.IsUpdated(convzx_TotalDataStatistics.SchoolYear) == true)
{
string strComparisonOpSchoolYear = objvzx_TotalDataStatisticsCond.dicFldComparisonOp[convzx_TotalDataStatistics.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TotalDataStatistics.SchoolYear, objvzx_TotalDataStatisticsCond.SchoolYear, strComparisonOpSchoolYear);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vzx_TotalDataStatistics
{
public virtual bool UpdRelaTabDate(string strTotalDataId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vzx_TotalDataStatistics(vzx_TotalDataStatistics)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvzx_TotalDataStatisticsBL
{
public static RelatedActions_vzx_TotalDataStatistics relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvzx_TotalDataStatisticsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvzx_TotalDataStatisticsDA vzx_TotalDataStatisticsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvzx_TotalDataStatisticsDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvzx_TotalDataStatisticsBL()
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
if (string.IsNullOrEmpty(clsvzx_TotalDataStatisticsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_TotalDataStatisticsEN._ConnectString);
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
public static DataTable GetDataTable_vzx_TotalDataStatistics(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vzx_TotalDataStatisticsDA.GetDataTable_vzx_TotalDataStatistics(strWhereCond);
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
objDT = vzx_TotalDataStatisticsDA.GetDataTable(strWhereCond);
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
objDT = vzx_TotalDataStatisticsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vzx_TotalDataStatisticsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vzx_TotalDataStatisticsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vzx_TotalDataStatisticsDA.GetDataTable_Top(objTopPara);
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
objDT = vzx_TotalDataStatisticsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vzx_TotalDataStatisticsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vzx_TotalDataStatisticsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvzx_TotalDataStatisticsEN> GetObjLstByTotalDataIdLst(List<string> arrTotalDataIdLst)
{
List<clsvzx_TotalDataStatisticsEN> arrObjLst = new List<clsvzx_TotalDataStatisticsEN>(); 
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
	clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsEN = new clsvzx_TotalDataStatisticsEN();
try
{
objvzx_TotalDataStatisticsEN.EduClsName = objRow[convzx_TotalDataStatistics.EduClsName] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.EduClsName].ToString().Trim(); //教学班名
objvzx_TotalDataStatisticsEN.TotalDataId = objRow[convzx_TotalDataStatistics.TotalDataId].ToString().Trim(); //TotalDataId
objvzx_TotalDataStatisticsEN.IdCurrEduCls = objRow[convzx_TotalDataStatistics.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TotalDataStatisticsEN.zxTotalDataTypeId = objRow[convzx_TotalDataStatistics.zxTotalDataTypeId].ToString().Trim(); //总数据类型Id
objvzx_TotalDataStatisticsEN.TableKey = objRow[convzx_TotalDataStatistics.TableKey] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.TableKey].ToString().Trim(); //表主键
objvzx_TotalDataStatisticsEN.DataUser = objRow[convzx_TotalDataStatistics.DataUser] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataUser].ToString().Trim(); //数据用户
objvzx_TotalDataStatisticsEN.DataAddDate = objRow[convzx_TotalDataStatistics.DataAddDate] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataAddDate].ToString().Trim(); //数据添加日期
objvzx_TotalDataStatisticsEN.Month = objRow[convzx_TotalDataStatistics.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TotalDataStatistics.Month].ToString().Trim()); //月
objvzx_TotalDataStatisticsEN.Week = objRow[convzx_TotalDataStatistics.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TotalDataStatistics.Week].ToString().Trim()); //周
objvzx_TotalDataStatisticsEN.UpdDate = objRow[convzx_TotalDataStatistics.UpdDate] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.UpdDate].ToString().Trim(); //修改日期
objvzx_TotalDataStatisticsEN.UpdUser = objRow[convzx_TotalDataStatistics.UpdUser] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.UpdUser].ToString().Trim(); //修改人
objvzx_TotalDataStatisticsEN.Memo = objRow[convzx_TotalDataStatistics.Memo] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.Memo].ToString().Trim(); //备注
objvzx_TotalDataStatisticsEN.Score = objRow[convzx_TotalDataStatistics.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TotalDataStatistics.Score].ToString().Trim()); //评分
objvzx_TotalDataStatisticsEN.TeaScore = objRow[convzx_TotalDataStatistics.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TotalDataStatistics.TeaScore].ToString().Trim()); //教师评分
objvzx_TotalDataStatisticsEN.WeekTimeRange = objRow[convzx_TotalDataStatistics.WeekTimeRange] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objvzx_TotalDataStatisticsEN.StuScore = objRow[convzx_TotalDataStatistics.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TotalDataStatistics.StuScore].ToString().Trim()); //学生平均分
objvzx_TotalDataStatisticsEN.OnlyId = objRow[convzx_TotalDataStatistics.OnlyId] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.OnlyId].ToString().Trim(); //OnlyId
objvzx_TotalDataStatisticsEN.DataTableId = objRow[convzx_TotalDataStatistics.DataTableId] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataTableId].ToString().Trim(); //数据表Id
objvzx_TotalDataStatisticsEN.DataTable = objRow[convzx_TotalDataStatistics.DataTable] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataTable].ToString().Trim(); //数据表
objvzx_TotalDataStatisticsEN.TotalDataTypeName = objRow[convzx_TotalDataStatistics.TotalDataTypeName] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.TotalDataTypeName].ToString().Trim(); //总数据类型名称
objvzx_TotalDataStatisticsEN.SchoolTerm = objRow[convzx_TotalDataStatistics.SchoolTerm] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.SchoolTerm].ToString().Trim(); //学期
objvzx_TotalDataStatisticsEN.SchoolYear = objRow[convzx_TotalDataStatistics.SchoolYear] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.SchoolYear].ToString().Trim(); //学年
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TotalDataStatisticsEN.TotalDataId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TotalDataStatisticsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrTotalDataIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvzx_TotalDataStatisticsEN> GetObjLstByTotalDataIdLstCache(List<string> arrTotalDataIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsvzx_TotalDataStatisticsEN._CurrTabName, strIdCurrEduCls);
List<clsvzx_TotalDataStatisticsEN> arrvzx_TotalDataStatisticsObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvzx_TotalDataStatisticsEN> arrvzx_TotalDataStatisticsObjLst_Sel =
arrvzx_TotalDataStatisticsObjLstCache
.Where(x => arrTotalDataIdLst.Contains(x.TotalDataId));
return arrvzx_TotalDataStatisticsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_TotalDataStatisticsEN> GetObjLst(string strWhereCond)
{
List<clsvzx_TotalDataStatisticsEN> arrObjLst = new List<clsvzx_TotalDataStatisticsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsEN = new clsvzx_TotalDataStatisticsEN();
try
{
objvzx_TotalDataStatisticsEN.EduClsName = objRow[convzx_TotalDataStatistics.EduClsName] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.EduClsName].ToString().Trim(); //教学班名
objvzx_TotalDataStatisticsEN.TotalDataId = objRow[convzx_TotalDataStatistics.TotalDataId].ToString().Trim(); //TotalDataId
objvzx_TotalDataStatisticsEN.IdCurrEduCls = objRow[convzx_TotalDataStatistics.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TotalDataStatisticsEN.zxTotalDataTypeId = objRow[convzx_TotalDataStatistics.zxTotalDataTypeId].ToString().Trim(); //总数据类型Id
objvzx_TotalDataStatisticsEN.TableKey = objRow[convzx_TotalDataStatistics.TableKey] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.TableKey].ToString().Trim(); //表主键
objvzx_TotalDataStatisticsEN.DataUser = objRow[convzx_TotalDataStatistics.DataUser] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataUser].ToString().Trim(); //数据用户
objvzx_TotalDataStatisticsEN.DataAddDate = objRow[convzx_TotalDataStatistics.DataAddDate] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataAddDate].ToString().Trim(); //数据添加日期
objvzx_TotalDataStatisticsEN.Month = objRow[convzx_TotalDataStatistics.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TotalDataStatistics.Month].ToString().Trim()); //月
objvzx_TotalDataStatisticsEN.Week = objRow[convzx_TotalDataStatistics.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TotalDataStatistics.Week].ToString().Trim()); //周
objvzx_TotalDataStatisticsEN.UpdDate = objRow[convzx_TotalDataStatistics.UpdDate] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.UpdDate].ToString().Trim(); //修改日期
objvzx_TotalDataStatisticsEN.UpdUser = objRow[convzx_TotalDataStatistics.UpdUser] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.UpdUser].ToString().Trim(); //修改人
objvzx_TotalDataStatisticsEN.Memo = objRow[convzx_TotalDataStatistics.Memo] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.Memo].ToString().Trim(); //备注
objvzx_TotalDataStatisticsEN.Score = objRow[convzx_TotalDataStatistics.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TotalDataStatistics.Score].ToString().Trim()); //评分
objvzx_TotalDataStatisticsEN.TeaScore = objRow[convzx_TotalDataStatistics.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TotalDataStatistics.TeaScore].ToString().Trim()); //教师评分
objvzx_TotalDataStatisticsEN.WeekTimeRange = objRow[convzx_TotalDataStatistics.WeekTimeRange] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objvzx_TotalDataStatisticsEN.StuScore = objRow[convzx_TotalDataStatistics.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TotalDataStatistics.StuScore].ToString().Trim()); //学生平均分
objvzx_TotalDataStatisticsEN.OnlyId = objRow[convzx_TotalDataStatistics.OnlyId] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.OnlyId].ToString().Trim(); //OnlyId
objvzx_TotalDataStatisticsEN.DataTableId = objRow[convzx_TotalDataStatistics.DataTableId] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataTableId].ToString().Trim(); //数据表Id
objvzx_TotalDataStatisticsEN.DataTable = objRow[convzx_TotalDataStatistics.DataTable] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataTable].ToString().Trim(); //数据表
objvzx_TotalDataStatisticsEN.TotalDataTypeName = objRow[convzx_TotalDataStatistics.TotalDataTypeName] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.TotalDataTypeName].ToString().Trim(); //总数据类型名称
objvzx_TotalDataStatisticsEN.SchoolTerm = objRow[convzx_TotalDataStatistics.SchoolTerm] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.SchoolTerm].ToString().Trim(); //学期
objvzx_TotalDataStatisticsEN.SchoolYear = objRow[convzx_TotalDataStatistics.SchoolYear] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.SchoolYear].ToString().Trim(); //学年
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TotalDataStatisticsEN.TotalDataId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TotalDataStatisticsEN);
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
public static List<clsvzx_TotalDataStatisticsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvzx_TotalDataStatisticsEN> arrObjLst = new List<clsvzx_TotalDataStatisticsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsEN = new clsvzx_TotalDataStatisticsEN();
try
{
objvzx_TotalDataStatisticsEN.EduClsName = objRow[convzx_TotalDataStatistics.EduClsName] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.EduClsName].ToString().Trim(); //教学班名
objvzx_TotalDataStatisticsEN.TotalDataId = objRow[convzx_TotalDataStatistics.TotalDataId].ToString().Trim(); //TotalDataId
objvzx_TotalDataStatisticsEN.IdCurrEduCls = objRow[convzx_TotalDataStatistics.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TotalDataStatisticsEN.zxTotalDataTypeId = objRow[convzx_TotalDataStatistics.zxTotalDataTypeId].ToString().Trim(); //总数据类型Id
objvzx_TotalDataStatisticsEN.TableKey = objRow[convzx_TotalDataStatistics.TableKey] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.TableKey].ToString().Trim(); //表主键
objvzx_TotalDataStatisticsEN.DataUser = objRow[convzx_TotalDataStatistics.DataUser] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataUser].ToString().Trim(); //数据用户
objvzx_TotalDataStatisticsEN.DataAddDate = objRow[convzx_TotalDataStatistics.DataAddDate] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataAddDate].ToString().Trim(); //数据添加日期
objvzx_TotalDataStatisticsEN.Month = objRow[convzx_TotalDataStatistics.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TotalDataStatistics.Month].ToString().Trim()); //月
objvzx_TotalDataStatisticsEN.Week = objRow[convzx_TotalDataStatistics.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TotalDataStatistics.Week].ToString().Trim()); //周
objvzx_TotalDataStatisticsEN.UpdDate = objRow[convzx_TotalDataStatistics.UpdDate] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.UpdDate].ToString().Trim(); //修改日期
objvzx_TotalDataStatisticsEN.UpdUser = objRow[convzx_TotalDataStatistics.UpdUser] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.UpdUser].ToString().Trim(); //修改人
objvzx_TotalDataStatisticsEN.Memo = objRow[convzx_TotalDataStatistics.Memo] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.Memo].ToString().Trim(); //备注
objvzx_TotalDataStatisticsEN.Score = objRow[convzx_TotalDataStatistics.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TotalDataStatistics.Score].ToString().Trim()); //评分
objvzx_TotalDataStatisticsEN.TeaScore = objRow[convzx_TotalDataStatistics.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TotalDataStatistics.TeaScore].ToString().Trim()); //教师评分
objvzx_TotalDataStatisticsEN.WeekTimeRange = objRow[convzx_TotalDataStatistics.WeekTimeRange] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objvzx_TotalDataStatisticsEN.StuScore = objRow[convzx_TotalDataStatistics.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TotalDataStatistics.StuScore].ToString().Trim()); //学生平均分
objvzx_TotalDataStatisticsEN.OnlyId = objRow[convzx_TotalDataStatistics.OnlyId] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.OnlyId].ToString().Trim(); //OnlyId
objvzx_TotalDataStatisticsEN.DataTableId = objRow[convzx_TotalDataStatistics.DataTableId] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataTableId].ToString().Trim(); //数据表Id
objvzx_TotalDataStatisticsEN.DataTable = objRow[convzx_TotalDataStatistics.DataTable] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataTable].ToString().Trim(); //数据表
objvzx_TotalDataStatisticsEN.TotalDataTypeName = objRow[convzx_TotalDataStatistics.TotalDataTypeName] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.TotalDataTypeName].ToString().Trim(); //总数据类型名称
objvzx_TotalDataStatisticsEN.SchoolTerm = objRow[convzx_TotalDataStatistics.SchoolTerm] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.SchoolTerm].ToString().Trim(); //学期
objvzx_TotalDataStatisticsEN.SchoolYear = objRow[convzx_TotalDataStatistics.SchoolYear] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.SchoolYear].ToString().Trim(); //学年
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TotalDataStatisticsEN.TotalDataId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TotalDataStatisticsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvzx_TotalDataStatisticsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvzx_TotalDataStatisticsEN> GetSubObjLstCache(clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsCond)
{
 string strIdCurrEduCls = objvzx_TotalDataStatisticsCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvzx_TotalDataStatisticsBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvzx_TotalDataStatisticsEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvzx_TotalDataStatisticsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_TotalDataStatistics.AttributeName)
{
if (objvzx_TotalDataStatisticsCond.IsUpdated(strFldName) == false) continue;
if (objvzx_TotalDataStatisticsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_TotalDataStatisticsCond[strFldName].ToString());
}
else
{
if (objvzx_TotalDataStatisticsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_TotalDataStatisticsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_TotalDataStatisticsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_TotalDataStatisticsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_TotalDataStatisticsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_TotalDataStatisticsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_TotalDataStatisticsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_TotalDataStatisticsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_TotalDataStatisticsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_TotalDataStatisticsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_TotalDataStatisticsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_TotalDataStatisticsCond[strFldName]));
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
public static List<clsvzx_TotalDataStatisticsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvzx_TotalDataStatisticsEN> arrObjLst = new List<clsvzx_TotalDataStatisticsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsEN = new clsvzx_TotalDataStatisticsEN();
try
{
objvzx_TotalDataStatisticsEN.EduClsName = objRow[convzx_TotalDataStatistics.EduClsName] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.EduClsName].ToString().Trim(); //教学班名
objvzx_TotalDataStatisticsEN.TotalDataId = objRow[convzx_TotalDataStatistics.TotalDataId].ToString().Trim(); //TotalDataId
objvzx_TotalDataStatisticsEN.IdCurrEduCls = objRow[convzx_TotalDataStatistics.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TotalDataStatisticsEN.zxTotalDataTypeId = objRow[convzx_TotalDataStatistics.zxTotalDataTypeId].ToString().Trim(); //总数据类型Id
objvzx_TotalDataStatisticsEN.TableKey = objRow[convzx_TotalDataStatistics.TableKey] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.TableKey].ToString().Trim(); //表主键
objvzx_TotalDataStatisticsEN.DataUser = objRow[convzx_TotalDataStatistics.DataUser] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataUser].ToString().Trim(); //数据用户
objvzx_TotalDataStatisticsEN.DataAddDate = objRow[convzx_TotalDataStatistics.DataAddDate] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataAddDate].ToString().Trim(); //数据添加日期
objvzx_TotalDataStatisticsEN.Month = objRow[convzx_TotalDataStatistics.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TotalDataStatistics.Month].ToString().Trim()); //月
objvzx_TotalDataStatisticsEN.Week = objRow[convzx_TotalDataStatistics.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TotalDataStatistics.Week].ToString().Trim()); //周
objvzx_TotalDataStatisticsEN.UpdDate = objRow[convzx_TotalDataStatistics.UpdDate] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.UpdDate].ToString().Trim(); //修改日期
objvzx_TotalDataStatisticsEN.UpdUser = objRow[convzx_TotalDataStatistics.UpdUser] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.UpdUser].ToString().Trim(); //修改人
objvzx_TotalDataStatisticsEN.Memo = objRow[convzx_TotalDataStatistics.Memo] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.Memo].ToString().Trim(); //备注
objvzx_TotalDataStatisticsEN.Score = objRow[convzx_TotalDataStatistics.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TotalDataStatistics.Score].ToString().Trim()); //评分
objvzx_TotalDataStatisticsEN.TeaScore = objRow[convzx_TotalDataStatistics.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TotalDataStatistics.TeaScore].ToString().Trim()); //教师评分
objvzx_TotalDataStatisticsEN.WeekTimeRange = objRow[convzx_TotalDataStatistics.WeekTimeRange] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objvzx_TotalDataStatisticsEN.StuScore = objRow[convzx_TotalDataStatistics.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TotalDataStatistics.StuScore].ToString().Trim()); //学生平均分
objvzx_TotalDataStatisticsEN.OnlyId = objRow[convzx_TotalDataStatistics.OnlyId] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.OnlyId].ToString().Trim(); //OnlyId
objvzx_TotalDataStatisticsEN.DataTableId = objRow[convzx_TotalDataStatistics.DataTableId] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataTableId].ToString().Trim(); //数据表Id
objvzx_TotalDataStatisticsEN.DataTable = objRow[convzx_TotalDataStatistics.DataTable] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataTable].ToString().Trim(); //数据表
objvzx_TotalDataStatisticsEN.TotalDataTypeName = objRow[convzx_TotalDataStatistics.TotalDataTypeName] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.TotalDataTypeName].ToString().Trim(); //总数据类型名称
objvzx_TotalDataStatisticsEN.SchoolTerm = objRow[convzx_TotalDataStatistics.SchoolTerm] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.SchoolTerm].ToString().Trim(); //学期
objvzx_TotalDataStatisticsEN.SchoolYear = objRow[convzx_TotalDataStatistics.SchoolYear] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.SchoolYear].ToString().Trim(); //学年
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TotalDataStatisticsEN.TotalDataId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TotalDataStatisticsEN);
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
public static List<clsvzx_TotalDataStatisticsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvzx_TotalDataStatisticsEN> arrObjLst = new List<clsvzx_TotalDataStatisticsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsEN = new clsvzx_TotalDataStatisticsEN();
try
{
objvzx_TotalDataStatisticsEN.EduClsName = objRow[convzx_TotalDataStatistics.EduClsName] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.EduClsName].ToString().Trim(); //教学班名
objvzx_TotalDataStatisticsEN.TotalDataId = objRow[convzx_TotalDataStatistics.TotalDataId].ToString().Trim(); //TotalDataId
objvzx_TotalDataStatisticsEN.IdCurrEduCls = objRow[convzx_TotalDataStatistics.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TotalDataStatisticsEN.zxTotalDataTypeId = objRow[convzx_TotalDataStatistics.zxTotalDataTypeId].ToString().Trim(); //总数据类型Id
objvzx_TotalDataStatisticsEN.TableKey = objRow[convzx_TotalDataStatistics.TableKey] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.TableKey].ToString().Trim(); //表主键
objvzx_TotalDataStatisticsEN.DataUser = objRow[convzx_TotalDataStatistics.DataUser] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataUser].ToString().Trim(); //数据用户
objvzx_TotalDataStatisticsEN.DataAddDate = objRow[convzx_TotalDataStatistics.DataAddDate] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataAddDate].ToString().Trim(); //数据添加日期
objvzx_TotalDataStatisticsEN.Month = objRow[convzx_TotalDataStatistics.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TotalDataStatistics.Month].ToString().Trim()); //月
objvzx_TotalDataStatisticsEN.Week = objRow[convzx_TotalDataStatistics.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TotalDataStatistics.Week].ToString().Trim()); //周
objvzx_TotalDataStatisticsEN.UpdDate = objRow[convzx_TotalDataStatistics.UpdDate] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.UpdDate].ToString().Trim(); //修改日期
objvzx_TotalDataStatisticsEN.UpdUser = objRow[convzx_TotalDataStatistics.UpdUser] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.UpdUser].ToString().Trim(); //修改人
objvzx_TotalDataStatisticsEN.Memo = objRow[convzx_TotalDataStatistics.Memo] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.Memo].ToString().Trim(); //备注
objvzx_TotalDataStatisticsEN.Score = objRow[convzx_TotalDataStatistics.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TotalDataStatistics.Score].ToString().Trim()); //评分
objvzx_TotalDataStatisticsEN.TeaScore = objRow[convzx_TotalDataStatistics.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TotalDataStatistics.TeaScore].ToString().Trim()); //教师评分
objvzx_TotalDataStatisticsEN.WeekTimeRange = objRow[convzx_TotalDataStatistics.WeekTimeRange] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objvzx_TotalDataStatisticsEN.StuScore = objRow[convzx_TotalDataStatistics.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TotalDataStatistics.StuScore].ToString().Trim()); //学生平均分
objvzx_TotalDataStatisticsEN.OnlyId = objRow[convzx_TotalDataStatistics.OnlyId] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.OnlyId].ToString().Trim(); //OnlyId
objvzx_TotalDataStatisticsEN.DataTableId = objRow[convzx_TotalDataStatistics.DataTableId] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataTableId].ToString().Trim(); //数据表Id
objvzx_TotalDataStatisticsEN.DataTable = objRow[convzx_TotalDataStatistics.DataTable] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataTable].ToString().Trim(); //数据表
objvzx_TotalDataStatisticsEN.TotalDataTypeName = objRow[convzx_TotalDataStatistics.TotalDataTypeName] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.TotalDataTypeName].ToString().Trim(); //总数据类型名称
objvzx_TotalDataStatisticsEN.SchoolTerm = objRow[convzx_TotalDataStatistics.SchoolTerm] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.SchoolTerm].ToString().Trim(); //学期
objvzx_TotalDataStatisticsEN.SchoolYear = objRow[convzx_TotalDataStatistics.SchoolYear] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.SchoolYear].ToString().Trim(); //学年
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TotalDataStatisticsEN.TotalDataId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TotalDataStatisticsEN);
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
List<clsvzx_TotalDataStatisticsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvzx_TotalDataStatisticsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_TotalDataStatisticsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvzx_TotalDataStatisticsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_TotalDataStatisticsEN> arrObjLst = new List<clsvzx_TotalDataStatisticsEN>(); 
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
	clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsEN = new clsvzx_TotalDataStatisticsEN();
try
{
objvzx_TotalDataStatisticsEN.EduClsName = objRow[convzx_TotalDataStatistics.EduClsName] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.EduClsName].ToString().Trim(); //教学班名
objvzx_TotalDataStatisticsEN.TotalDataId = objRow[convzx_TotalDataStatistics.TotalDataId].ToString().Trim(); //TotalDataId
objvzx_TotalDataStatisticsEN.IdCurrEduCls = objRow[convzx_TotalDataStatistics.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TotalDataStatisticsEN.zxTotalDataTypeId = objRow[convzx_TotalDataStatistics.zxTotalDataTypeId].ToString().Trim(); //总数据类型Id
objvzx_TotalDataStatisticsEN.TableKey = objRow[convzx_TotalDataStatistics.TableKey] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.TableKey].ToString().Trim(); //表主键
objvzx_TotalDataStatisticsEN.DataUser = objRow[convzx_TotalDataStatistics.DataUser] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataUser].ToString().Trim(); //数据用户
objvzx_TotalDataStatisticsEN.DataAddDate = objRow[convzx_TotalDataStatistics.DataAddDate] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataAddDate].ToString().Trim(); //数据添加日期
objvzx_TotalDataStatisticsEN.Month = objRow[convzx_TotalDataStatistics.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TotalDataStatistics.Month].ToString().Trim()); //月
objvzx_TotalDataStatisticsEN.Week = objRow[convzx_TotalDataStatistics.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TotalDataStatistics.Week].ToString().Trim()); //周
objvzx_TotalDataStatisticsEN.UpdDate = objRow[convzx_TotalDataStatistics.UpdDate] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.UpdDate].ToString().Trim(); //修改日期
objvzx_TotalDataStatisticsEN.UpdUser = objRow[convzx_TotalDataStatistics.UpdUser] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.UpdUser].ToString().Trim(); //修改人
objvzx_TotalDataStatisticsEN.Memo = objRow[convzx_TotalDataStatistics.Memo] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.Memo].ToString().Trim(); //备注
objvzx_TotalDataStatisticsEN.Score = objRow[convzx_TotalDataStatistics.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TotalDataStatistics.Score].ToString().Trim()); //评分
objvzx_TotalDataStatisticsEN.TeaScore = objRow[convzx_TotalDataStatistics.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TotalDataStatistics.TeaScore].ToString().Trim()); //教师评分
objvzx_TotalDataStatisticsEN.WeekTimeRange = objRow[convzx_TotalDataStatistics.WeekTimeRange] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objvzx_TotalDataStatisticsEN.StuScore = objRow[convzx_TotalDataStatistics.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TotalDataStatistics.StuScore].ToString().Trim()); //学生平均分
objvzx_TotalDataStatisticsEN.OnlyId = objRow[convzx_TotalDataStatistics.OnlyId] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.OnlyId].ToString().Trim(); //OnlyId
objvzx_TotalDataStatisticsEN.DataTableId = objRow[convzx_TotalDataStatistics.DataTableId] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataTableId].ToString().Trim(); //数据表Id
objvzx_TotalDataStatisticsEN.DataTable = objRow[convzx_TotalDataStatistics.DataTable] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataTable].ToString().Trim(); //数据表
objvzx_TotalDataStatisticsEN.TotalDataTypeName = objRow[convzx_TotalDataStatistics.TotalDataTypeName] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.TotalDataTypeName].ToString().Trim(); //总数据类型名称
objvzx_TotalDataStatisticsEN.SchoolTerm = objRow[convzx_TotalDataStatistics.SchoolTerm] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.SchoolTerm].ToString().Trim(); //学期
objvzx_TotalDataStatisticsEN.SchoolYear = objRow[convzx_TotalDataStatistics.SchoolYear] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.SchoolYear].ToString().Trim(); //学年
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TotalDataStatisticsEN.TotalDataId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TotalDataStatisticsEN);
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
public static List<clsvzx_TotalDataStatisticsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvzx_TotalDataStatisticsEN> arrObjLst = new List<clsvzx_TotalDataStatisticsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsEN = new clsvzx_TotalDataStatisticsEN();
try
{
objvzx_TotalDataStatisticsEN.EduClsName = objRow[convzx_TotalDataStatistics.EduClsName] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.EduClsName].ToString().Trim(); //教学班名
objvzx_TotalDataStatisticsEN.TotalDataId = objRow[convzx_TotalDataStatistics.TotalDataId].ToString().Trim(); //TotalDataId
objvzx_TotalDataStatisticsEN.IdCurrEduCls = objRow[convzx_TotalDataStatistics.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TotalDataStatisticsEN.zxTotalDataTypeId = objRow[convzx_TotalDataStatistics.zxTotalDataTypeId].ToString().Trim(); //总数据类型Id
objvzx_TotalDataStatisticsEN.TableKey = objRow[convzx_TotalDataStatistics.TableKey] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.TableKey].ToString().Trim(); //表主键
objvzx_TotalDataStatisticsEN.DataUser = objRow[convzx_TotalDataStatistics.DataUser] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataUser].ToString().Trim(); //数据用户
objvzx_TotalDataStatisticsEN.DataAddDate = objRow[convzx_TotalDataStatistics.DataAddDate] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataAddDate].ToString().Trim(); //数据添加日期
objvzx_TotalDataStatisticsEN.Month = objRow[convzx_TotalDataStatistics.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TotalDataStatistics.Month].ToString().Trim()); //月
objvzx_TotalDataStatisticsEN.Week = objRow[convzx_TotalDataStatistics.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TotalDataStatistics.Week].ToString().Trim()); //周
objvzx_TotalDataStatisticsEN.UpdDate = objRow[convzx_TotalDataStatistics.UpdDate] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.UpdDate].ToString().Trim(); //修改日期
objvzx_TotalDataStatisticsEN.UpdUser = objRow[convzx_TotalDataStatistics.UpdUser] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.UpdUser].ToString().Trim(); //修改人
objvzx_TotalDataStatisticsEN.Memo = objRow[convzx_TotalDataStatistics.Memo] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.Memo].ToString().Trim(); //备注
objvzx_TotalDataStatisticsEN.Score = objRow[convzx_TotalDataStatistics.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TotalDataStatistics.Score].ToString().Trim()); //评分
objvzx_TotalDataStatisticsEN.TeaScore = objRow[convzx_TotalDataStatistics.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TotalDataStatistics.TeaScore].ToString().Trim()); //教师评分
objvzx_TotalDataStatisticsEN.WeekTimeRange = objRow[convzx_TotalDataStatistics.WeekTimeRange] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objvzx_TotalDataStatisticsEN.StuScore = objRow[convzx_TotalDataStatistics.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TotalDataStatistics.StuScore].ToString().Trim()); //学生平均分
objvzx_TotalDataStatisticsEN.OnlyId = objRow[convzx_TotalDataStatistics.OnlyId] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.OnlyId].ToString().Trim(); //OnlyId
objvzx_TotalDataStatisticsEN.DataTableId = objRow[convzx_TotalDataStatistics.DataTableId] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataTableId].ToString().Trim(); //数据表Id
objvzx_TotalDataStatisticsEN.DataTable = objRow[convzx_TotalDataStatistics.DataTable] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataTable].ToString().Trim(); //数据表
objvzx_TotalDataStatisticsEN.TotalDataTypeName = objRow[convzx_TotalDataStatistics.TotalDataTypeName] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.TotalDataTypeName].ToString().Trim(); //总数据类型名称
objvzx_TotalDataStatisticsEN.SchoolTerm = objRow[convzx_TotalDataStatistics.SchoolTerm] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.SchoolTerm].ToString().Trim(); //学期
objvzx_TotalDataStatisticsEN.SchoolYear = objRow[convzx_TotalDataStatistics.SchoolYear] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.SchoolYear].ToString().Trim(); //学年
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TotalDataStatisticsEN.TotalDataId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TotalDataStatisticsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvzx_TotalDataStatisticsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvzx_TotalDataStatisticsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_TotalDataStatisticsEN> arrObjLst = new List<clsvzx_TotalDataStatisticsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsEN = new clsvzx_TotalDataStatisticsEN();
try
{
objvzx_TotalDataStatisticsEN.EduClsName = objRow[convzx_TotalDataStatistics.EduClsName] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.EduClsName].ToString().Trim(); //教学班名
objvzx_TotalDataStatisticsEN.TotalDataId = objRow[convzx_TotalDataStatistics.TotalDataId].ToString().Trim(); //TotalDataId
objvzx_TotalDataStatisticsEN.IdCurrEduCls = objRow[convzx_TotalDataStatistics.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TotalDataStatisticsEN.zxTotalDataTypeId = objRow[convzx_TotalDataStatistics.zxTotalDataTypeId].ToString().Trim(); //总数据类型Id
objvzx_TotalDataStatisticsEN.TableKey = objRow[convzx_TotalDataStatistics.TableKey] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.TableKey].ToString().Trim(); //表主键
objvzx_TotalDataStatisticsEN.DataUser = objRow[convzx_TotalDataStatistics.DataUser] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataUser].ToString().Trim(); //数据用户
objvzx_TotalDataStatisticsEN.DataAddDate = objRow[convzx_TotalDataStatistics.DataAddDate] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataAddDate].ToString().Trim(); //数据添加日期
objvzx_TotalDataStatisticsEN.Month = objRow[convzx_TotalDataStatistics.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TotalDataStatistics.Month].ToString().Trim()); //月
objvzx_TotalDataStatisticsEN.Week = objRow[convzx_TotalDataStatistics.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TotalDataStatistics.Week].ToString().Trim()); //周
objvzx_TotalDataStatisticsEN.UpdDate = objRow[convzx_TotalDataStatistics.UpdDate] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.UpdDate].ToString().Trim(); //修改日期
objvzx_TotalDataStatisticsEN.UpdUser = objRow[convzx_TotalDataStatistics.UpdUser] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.UpdUser].ToString().Trim(); //修改人
objvzx_TotalDataStatisticsEN.Memo = objRow[convzx_TotalDataStatistics.Memo] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.Memo].ToString().Trim(); //备注
objvzx_TotalDataStatisticsEN.Score = objRow[convzx_TotalDataStatistics.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TotalDataStatistics.Score].ToString().Trim()); //评分
objvzx_TotalDataStatisticsEN.TeaScore = objRow[convzx_TotalDataStatistics.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TotalDataStatistics.TeaScore].ToString().Trim()); //教师评分
objvzx_TotalDataStatisticsEN.WeekTimeRange = objRow[convzx_TotalDataStatistics.WeekTimeRange] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objvzx_TotalDataStatisticsEN.StuScore = objRow[convzx_TotalDataStatistics.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TotalDataStatistics.StuScore].ToString().Trim()); //学生平均分
objvzx_TotalDataStatisticsEN.OnlyId = objRow[convzx_TotalDataStatistics.OnlyId] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.OnlyId].ToString().Trim(); //OnlyId
objvzx_TotalDataStatisticsEN.DataTableId = objRow[convzx_TotalDataStatistics.DataTableId] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataTableId].ToString().Trim(); //数据表Id
objvzx_TotalDataStatisticsEN.DataTable = objRow[convzx_TotalDataStatistics.DataTable] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataTable].ToString().Trim(); //数据表
objvzx_TotalDataStatisticsEN.TotalDataTypeName = objRow[convzx_TotalDataStatistics.TotalDataTypeName] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.TotalDataTypeName].ToString().Trim(); //总数据类型名称
objvzx_TotalDataStatisticsEN.SchoolTerm = objRow[convzx_TotalDataStatistics.SchoolTerm] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.SchoolTerm].ToString().Trim(); //学期
objvzx_TotalDataStatisticsEN.SchoolYear = objRow[convzx_TotalDataStatistics.SchoolYear] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.SchoolYear].ToString().Trim(); //学年
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TotalDataStatisticsEN.TotalDataId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TotalDataStatisticsEN);
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
public static List<clsvzx_TotalDataStatisticsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvzx_TotalDataStatisticsEN> arrObjLst = new List<clsvzx_TotalDataStatisticsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsEN = new clsvzx_TotalDataStatisticsEN();
try
{
objvzx_TotalDataStatisticsEN.EduClsName = objRow[convzx_TotalDataStatistics.EduClsName] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.EduClsName].ToString().Trim(); //教学班名
objvzx_TotalDataStatisticsEN.TotalDataId = objRow[convzx_TotalDataStatistics.TotalDataId].ToString().Trim(); //TotalDataId
objvzx_TotalDataStatisticsEN.IdCurrEduCls = objRow[convzx_TotalDataStatistics.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TotalDataStatisticsEN.zxTotalDataTypeId = objRow[convzx_TotalDataStatistics.zxTotalDataTypeId].ToString().Trim(); //总数据类型Id
objvzx_TotalDataStatisticsEN.TableKey = objRow[convzx_TotalDataStatistics.TableKey] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.TableKey].ToString().Trim(); //表主键
objvzx_TotalDataStatisticsEN.DataUser = objRow[convzx_TotalDataStatistics.DataUser] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataUser].ToString().Trim(); //数据用户
objvzx_TotalDataStatisticsEN.DataAddDate = objRow[convzx_TotalDataStatistics.DataAddDate] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataAddDate].ToString().Trim(); //数据添加日期
objvzx_TotalDataStatisticsEN.Month = objRow[convzx_TotalDataStatistics.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TotalDataStatistics.Month].ToString().Trim()); //月
objvzx_TotalDataStatisticsEN.Week = objRow[convzx_TotalDataStatistics.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TotalDataStatistics.Week].ToString().Trim()); //周
objvzx_TotalDataStatisticsEN.UpdDate = objRow[convzx_TotalDataStatistics.UpdDate] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.UpdDate].ToString().Trim(); //修改日期
objvzx_TotalDataStatisticsEN.UpdUser = objRow[convzx_TotalDataStatistics.UpdUser] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.UpdUser].ToString().Trim(); //修改人
objvzx_TotalDataStatisticsEN.Memo = objRow[convzx_TotalDataStatistics.Memo] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.Memo].ToString().Trim(); //备注
objvzx_TotalDataStatisticsEN.Score = objRow[convzx_TotalDataStatistics.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TotalDataStatistics.Score].ToString().Trim()); //评分
objvzx_TotalDataStatisticsEN.TeaScore = objRow[convzx_TotalDataStatistics.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TotalDataStatistics.TeaScore].ToString().Trim()); //教师评分
objvzx_TotalDataStatisticsEN.WeekTimeRange = objRow[convzx_TotalDataStatistics.WeekTimeRange] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objvzx_TotalDataStatisticsEN.StuScore = objRow[convzx_TotalDataStatistics.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TotalDataStatistics.StuScore].ToString().Trim()); //学生平均分
objvzx_TotalDataStatisticsEN.OnlyId = objRow[convzx_TotalDataStatistics.OnlyId] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.OnlyId].ToString().Trim(); //OnlyId
objvzx_TotalDataStatisticsEN.DataTableId = objRow[convzx_TotalDataStatistics.DataTableId] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataTableId].ToString().Trim(); //数据表Id
objvzx_TotalDataStatisticsEN.DataTable = objRow[convzx_TotalDataStatistics.DataTable] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataTable].ToString().Trim(); //数据表
objvzx_TotalDataStatisticsEN.TotalDataTypeName = objRow[convzx_TotalDataStatistics.TotalDataTypeName] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.TotalDataTypeName].ToString().Trim(); //总数据类型名称
objvzx_TotalDataStatisticsEN.SchoolTerm = objRow[convzx_TotalDataStatistics.SchoolTerm] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.SchoolTerm].ToString().Trim(); //学期
objvzx_TotalDataStatisticsEN.SchoolYear = objRow[convzx_TotalDataStatistics.SchoolYear] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.SchoolYear].ToString().Trim(); //学年
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TotalDataStatisticsEN.TotalDataId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TotalDataStatisticsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_TotalDataStatisticsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvzx_TotalDataStatisticsEN> arrObjLst = new List<clsvzx_TotalDataStatisticsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsEN = new clsvzx_TotalDataStatisticsEN();
try
{
objvzx_TotalDataStatisticsEN.EduClsName = objRow[convzx_TotalDataStatistics.EduClsName] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.EduClsName].ToString().Trim(); //教学班名
objvzx_TotalDataStatisticsEN.TotalDataId = objRow[convzx_TotalDataStatistics.TotalDataId].ToString().Trim(); //TotalDataId
objvzx_TotalDataStatisticsEN.IdCurrEduCls = objRow[convzx_TotalDataStatistics.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TotalDataStatisticsEN.zxTotalDataTypeId = objRow[convzx_TotalDataStatistics.zxTotalDataTypeId].ToString().Trim(); //总数据类型Id
objvzx_TotalDataStatisticsEN.TableKey = objRow[convzx_TotalDataStatistics.TableKey] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.TableKey].ToString().Trim(); //表主键
objvzx_TotalDataStatisticsEN.DataUser = objRow[convzx_TotalDataStatistics.DataUser] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataUser].ToString().Trim(); //数据用户
objvzx_TotalDataStatisticsEN.DataAddDate = objRow[convzx_TotalDataStatistics.DataAddDate] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataAddDate].ToString().Trim(); //数据添加日期
objvzx_TotalDataStatisticsEN.Month = objRow[convzx_TotalDataStatistics.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TotalDataStatistics.Month].ToString().Trim()); //月
objvzx_TotalDataStatisticsEN.Week = objRow[convzx_TotalDataStatistics.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TotalDataStatistics.Week].ToString().Trim()); //周
objvzx_TotalDataStatisticsEN.UpdDate = objRow[convzx_TotalDataStatistics.UpdDate] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.UpdDate].ToString().Trim(); //修改日期
objvzx_TotalDataStatisticsEN.UpdUser = objRow[convzx_TotalDataStatistics.UpdUser] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.UpdUser].ToString().Trim(); //修改人
objvzx_TotalDataStatisticsEN.Memo = objRow[convzx_TotalDataStatistics.Memo] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.Memo].ToString().Trim(); //备注
objvzx_TotalDataStatisticsEN.Score = objRow[convzx_TotalDataStatistics.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TotalDataStatistics.Score].ToString().Trim()); //评分
objvzx_TotalDataStatisticsEN.TeaScore = objRow[convzx_TotalDataStatistics.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TotalDataStatistics.TeaScore].ToString().Trim()); //教师评分
objvzx_TotalDataStatisticsEN.WeekTimeRange = objRow[convzx_TotalDataStatistics.WeekTimeRange] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objvzx_TotalDataStatisticsEN.StuScore = objRow[convzx_TotalDataStatistics.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TotalDataStatistics.StuScore].ToString().Trim()); //学生平均分
objvzx_TotalDataStatisticsEN.OnlyId = objRow[convzx_TotalDataStatistics.OnlyId] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.OnlyId].ToString().Trim(); //OnlyId
objvzx_TotalDataStatisticsEN.DataTableId = objRow[convzx_TotalDataStatistics.DataTableId] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataTableId].ToString().Trim(); //数据表Id
objvzx_TotalDataStatisticsEN.DataTable = objRow[convzx_TotalDataStatistics.DataTable] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataTable].ToString().Trim(); //数据表
objvzx_TotalDataStatisticsEN.TotalDataTypeName = objRow[convzx_TotalDataStatistics.TotalDataTypeName] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.TotalDataTypeName].ToString().Trim(); //总数据类型名称
objvzx_TotalDataStatisticsEN.SchoolTerm = objRow[convzx_TotalDataStatistics.SchoolTerm] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.SchoolTerm].ToString().Trim(); //学期
objvzx_TotalDataStatisticsEN.SchoolYear = objRow[convzx_TotalDataStatistics.SchoolYear] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.SchoolYear].ToString().Trim(); //学年
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TotalDataStatisticsEN.TotalDataId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TotalDataStatisticsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvzx_TotalDataStatisticsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvzx_TotalDataStatistics(ref clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsEN)
{
bool bolResult = vzx_TotalDataStatisticsDA.Getvzx_TotalDataStatistics(ref objvzx_TotalDataStatisticsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strTotalDataId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_TotalDataStatisticsEN GetObjByTotalDataId(string strTotalDataId)
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
clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsEN = vzx_TotalDataStatisticsDA.GetObjByTotalDataId(strTotalDataId);
return objvzx_TotalDataStatisticsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvzx_TotalDataStatisticsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsEN = vzx_TotalDataStatisticsDA.GetFirstObj(strWhereCond);
 return objvzx_TotalDataStatisticsEN;
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
public static clsvzx_TotalDataStatisticsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsEN = vzx_TotalDataStatisticsDA.GetObjByDataRow(objRow);
 return objvzx_TotalDataStatisticsEN;
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
public static clsvzx_TotalDataStatisticsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsEN = vzx_TotalDataStatisticsDA.GetObjByDataRow(objRow);
 return objvzx_TotalDataStatisticsEN;
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
 /// <param name = "lstvzx_TotalDataStatisticsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_TotalDataStatisticsEN GetObjByTotalDataIdFromList(string strTotalDataId, List<clsvzx_TotalDataStatisticsEN> lstvzx_TotalDataStatisticsObjLst)
{
foreach (clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsEN in lstvzx_TotalDataStatisticsObjLst)
{
if (objvzx_TotalDataStatisticsEN.TotalDataId == strTotalDataId)
{
return objvzx_TotalDataStatisticsEN;
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
 strTotalDataId = new clsvzx_TotalDataStatisticsDA().GetFirstID(strWhereCond);
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
 arrList = vzx_TotalDataStatisticsDA.GetID(strWhereCond);
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
bool bolIsExist = vzx_TotalDataStatisticsDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vzx_TotalDataStatisticsDA.IsExist(strTotalDataId);
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
 bolIsExist = clsvzx_TotalDataStatisticsDA.IsExistTable();
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
 bolIsExist = vzx_TotalDataStatisticsDA.IsExistTable(strTabName);
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
 /// <param name = "objvzx_TotalDataStatisticsENS">源对象</param>
 /// <param name = "objvzx_TotalDataStatisticsENT">目标对象</param>
 public static void CopyTo(clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsENS, clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsENT)
{
try
{
objvzx_TotalDataStatisticsENT.EduClsName = objvzx_TotalDataStatisticsENS.EduClsName; //教学班名
objvzx_TotalDataStatisticsENT.TotalDataId = objvzx_TotalDataStatisticsENS.TotalDataId; //TotalDataId
objvzx_TotalDataStatisticsENT.IdCurrEduCls = objvzx_TotalDataStatisticsENS.IdCurrEduCls; //教学班流水号
objvzx_TotalDataStatisticsENT.zxTotalDataTypeId = objvzx_TotalDataStatisticsENS.zxTotalDataTypeId; //总数据类型Id
objvzx_TotalDataStatisticsENT.TableKey = objvzx_TotalDataStatisticsENS.TableKey; //表主键
objvzx_TotalDataStatisticsENT.DataUser = objvzx_TotalDataStatisticsENS.DataUser; //数据用户
objvzx_TotalDataStatisticsENT.DataAddDate = objvzx_TotalDataStatisticsENS.DataAddDate; //数据添加日期
objvzx_TotalDataStatisticsENT.Month = objvzx_TotalDataStatisticsENS.Month; //月
objvzx_TotalDataStatisticsENT.Week = objvzx_TotalDataStatisticsENS.Week; //周
objvzx_TotalDataStatisticsENT.UpdDate = objvzx_TotalDataStatisticsENS.UpdDate; //修改日期
objvzx_TotalDataStatisticsENT.UpdUser = objvzx_TotalDataStatisticsENS.UpdUser; //修改人
objvzx_TotalDataStatisticsENT.Memo = objvzx_TotalDataStatisticsENS.Memo; //备注
objvzx_TotalDataStatisticsENT.Score = objvzx_TotalDataStatisticsENS.Score; //评分
objvzx_TotalDataStatisticsENT.TeaScore = objvzx_TotalDataStatisticsENS.TeaScore; //教师评分
objvzx_TotalDataStatisticsENT.WeekTimeRange = objvzx_TotalDataStatisticsENS.WeekTimeRange; //WeekTimeRange
objvzx_TotalDataStatisticsENT.StuScore = objvzx_TotalDataStatisticsENS.StuScore; //学生平均分
objvzx_TotalDataStatisticsENT.OnlyId = objvzx_TotalDataStatisticsENS.OnlyId; //OnlyId
objvzx_TotalDataStatisticsENT.DataTableId = objvzx_TotalDataStatisticsENS.DataTableId; //数据表Id
objvzx_TotalDataStatisticsENT.DataTable = objvzx_TotalDataStatisticsENS.DataTable; //数据表
objvzx_TotalDataStatisticsENT.TotalDataTypeName = objvzx_TotalDataStatisticsENS.TotalDataTypeName; //总数据类型名称
objvzx_TotalDataStatisticsENT.SchoolTerm = objvzx_TotalDataStatisticsENS.SchoolTerm; //学期
objvzx_TotalDataStatisticsENT.SchoolYear = objvzx_TotalDataStatisticsENS.SchoolYear; //学年
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
 /// <param name = "objvzx_TotalDataStatisticsEN">源简化对象</param>
 public static void SetUpdFlag(clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsEN)
{
try
{
objvzx_TotalDataStatisticsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvzx_TotalDataStatisticsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convzx_TotalDataStatistics.EduClsName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TotalDataStatisticsEN.EduClsName = objvzx_TotalDataStatisticsEN.EduClsName == "[null]" ? null :  objvzx_TotalDataStatisticsEN.EduClsName; //教学班名
}
if (arrFldSet.Contains(convzx_TotalDataStatistics.TotalDataId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TotalDataStatisticsEN.TotalDataId = objvzx_TotalDataStatisticsEN.TotalDataId; //TotalDataId
}
if (arrFldSet.Contains(convzx_TotalDataStatistics.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TotalDataStatisticsEN.IdCurrEduCls = objvzx_TotalDataStatisticsEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convzx_TotalDataStatistics.zxTotalDataTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TotalDataStatisticsEN.zxTotalDataTypeId = objvzx_TotalDataStatisticsEN.zxTotalDataTypeId; //总数据类型Id
}
if (arrFldSet.Contains(convzx_TotalDataStatistics.TableKey, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TotalDataStatisticsEN.TableKey = objvzx_TotalDataStatisticsEN.TableKey == "[null]" ? null :  objvzx_TotalDataStatisticsEN.TableKey; //表主键
}
if (arrFldSet.Contains(convzx_TotalDataStatistics.DataUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TotalDataStatisticsEN.DataUser = objvzx_TotalDataStatisticsEN.DataUser == "[null]" ? null :  objvzx_TotalDataStatisticsEN.DataUser; //数据用户
}
if (arrFldSet.Contains(convzx_TotalDataStatistics.DataAddDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TotalDataStatisticsEN.DataAddDate = objvzx_TotalDataStatisticsEN.DataAddDate == "[null]" ? null :  objvzx_TotalDataStatisticsEN.DataAddDate; //数据添加日期
}
if (arrFldSet.Contains(convzx_TotalDataStatistics.Month, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TotalDataStatisticsEN.Month = objvzx_TotalDataStatisticsEN.Month; //月
}
if (arrFldSet.Contains(convzx_TotalDataStatistics.Week, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TotalDataStatisticsEN.Week = objvzx_TotalDataStatisticsEN.Week; //周
}
if (arrFldSet.Contains(convzx_TotalDataStatistics.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TotalDataStatisticsEN.UpdDate = objvzx_TotalDataStatisticsEN.UpdDate == "[null]" ? null :  objvzx_TotalDataStatisticsEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convzx_TotalDataStatistics.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TotalDataStatisticsEN.UpdUser = objvzx_TotalDataStatisticsEN.UpdUser == "[null]" ? null :  objvzx_TotalDataStatisticsEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convzx_TotalDataStatistics.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TotalDataStatisticsEN.Memo = objvzx_TotalDataStatisticsEN.Memo == "[null]" ? null :  objvzx_TotalDataStatisticsEN.Memo; //备注
}
if (arrFldSet.Contains(convzx_TotalDataStatistics.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TotalDataStatisticsEN.Score = objvzx_TotalDataStatisticsEN.Score; //评分
}
if (arrFldSet.Contains(convzx_TotalDataStatistics.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TotalDataStatisticsEN.TeaScore = objvzx_TotalDataStatisticsEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(convzx_TotalDataStatistics.WeekTimeRange, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TotalDataStatisticsEN.WeekTimeRange = objvzx_TotalDataStatisticsEN.WeekTimeRange == "[null]" ? null :  objvzx_TotalDataStatisticsEN.WeekTimeRange; //WeekTimeRange
}
if (arrFldSet.Contains(convzx_TotalDataStatistics.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TotalDataStatisticsEN.StuScore = objvzx_TotalDataStatisticsEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(convzx_TotalDataStatistics.OnlyId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TotalDataStatisticsEN.OnlyId = objvzx_TotalDataStatisticsEN.OnlyId == "[null]" ? null :  objvzx_TotalDataStatisticsEN.OnlyId; //OnlyId
}
if (arrFldSet.Contains(convzx_TotalDataStatistics.DataTableId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TotalDataStatisticsEN.DataTableId = objvzx_TotalDataStatisticsEN.DataTableId == "[null]" ? null :  objvzx_TotalDataStatisticsEN.DataTableId; //数据表Id
}
if (arrFldSet.Contains(convzx_TotalDataStatistics.DataTable, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TotalDataStatisticsEN.DataTable = objvzx_TotalDataStatisticsEN.DataTable == "[null]" ? null :  objvzx_TotalDataStatisticsEN.DataTable; //数据表
}
if (arrFldSet.Contains(convzx_TotalDataStatistics.TotalDataTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TotalDataStatisticsEN.TotalDataTypeName = objvzx_TotalDataStatisticsEN.TotalDataTypeName == "[null]" ? null :  objvzx_TotalDataStatisticsEN.TotalDataTypeName; //总数据类型名称
}
if (arrFldSet.Contains(convzx_TotalDataStatistics.SchoolTerm, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TotalDataStatisticsEN.SchoolTerm = objvzx_TotalDataStatisticsEN.SchoolTerm == "[null]" ? null :  objvzx_TotalDataStatisticsEN.SchoolTerm; //学期
}
if (arrFldSet.Contains(convzx_TotalDataStatistics.SchoolYear, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TotalDataStatisticsEN.SchoolYear = objvzx_TotalDataStatisticsEN.SchoolYear == "[null]" ? null :  objvzx_TotalDataStatisticsEN.SchoolYear; //学年
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
 /// <param name = "objvzx_TotalDataStatisticsEN">源简化对象</param>
 public static void AccessFldValueNull(clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsEN)
{
try
{
if (objvzx_TotalDataStatisticsEN.EduClsName == "[null]") objvzx_TotalDataStatisticsEN.EduClsName = null; //教学班名
if (objvzx_TotalDataStatisticsEN.TableKey == "[null]") objvzx_TotalDataStatisticsEN.TableKey = null; //表主键
if (objvzx_TotalDataStatisticsEN.DataUser == "[null]") objvzx_TotalDataStatisticsEN.DataUser = null; //数据用户
if (objvzx_TotalDataStatisticsEN.DataAddDate == "[null]") objvzx_TotalDataStatisticsEN.DataAddDate = null; //数据添加日期
if (objvzx_TotalDataStatisticsEN.UpdDate == "[null]") objvzx_TotalDataStatisticsEN.UpdDate = null; //修改日期
if (objvzx_TotalDataStatisticsEN.UpdUser == "[null]") objvzx_TotalDataStatisticsEN.UpdUser = null; //修改人
if (objvzx_TotalDataStatisticsEN.Memo == "[null]") objvzx_TotalDataStatisticsEN.Memo = null; //备注
if (objvzx_TotalDataStatisticsEN.WeekTimeRange == "[null]") objvzx_TotalDataStatisticsEN.WeekTimeRange = null; //WeekTimeRange
if (objvzx_TotalDataStatisticsEN.OnlyId == "[null]") objvzx_TotalDataStatisticsEN.OnlyId = null; //OnlyId
if (objvzx_TotalDataStatisticsEN.DataTableId == "[null]") objvzx_TotalDataStatisticsEN.DataTableId = null; //数据表Id
if (objvzx_TotalDataStatisticsEN.DataTable == "[null]") objvzx_TotalDataStatisticsEN.DataTable = null; //数据表
if (objvzx_TotalDataStatisticsEN.TotalDataTypeName == "[null]") objvzx_TotalDataStatisticsEN.TotalDataTypeName = null; //总数据类型名称
if (objvzx_TotalDataStatisticsEN.SchoolTerm == "[null]") objvzx_TotalDataStatisticsEN.SchoolTerm = null; //学期
if (objvzx_TotalDataStatisticsEN.SchoolYear == "[null]") objvzx_TotalDataStatisticsEN.SchoolYear = null; //学年
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
public static void CheckProperty4Condition(clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsEN)
{
 vzx_TotalDataStatisticsDA.CheckProperty4Condition(objvzx_TotalDataStatisticsEN);
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
if (clszx_TotalDataStatisticsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_TotalDataStatisticsBL没有刷新缓存机制(clszx_TotalDataStatisticsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clszx_TotalDataTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_TotalDataTypeBL没有刷新缓存机制(clszx_TotalDataTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by TotalDataId");
//if (arrvzx_TotalDataStatisticsObjLstCache == null)
//{
//arrvzx_TotalDataStatisticsObjLstCache = vzx_TotalDataStatisticsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strTotalDataId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_TotalDataStatisticsEN GetObjByTotalDataIdCache(string strTotalDataId, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvzx_TotalDataStatisticsEN._CurrTabName, strIdCurrEduCls);
List<clsvzx_TotalDataStatisticsEN> arrvzx_TotalDataStatisticsObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvzx_TotalDataStatisticsEN> arrvzx_TotalDataStatisticsObjLst_Sel =
arrvzx_TotalDataStatisticsObjLstCache
.Where(x=> x.TotalDataId == strTotalDataId 
);
if (arrvzx_TotalDataStatisticsObjLst_Sel.Count() == 0)
{
   clsvzx_TotalDataStatisticsEN obj = clsvzx_TotalDataStatisticsBL.GetObjByTotalDataId(strTotalDataId);
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
return arrvzx_TotalDataStatisticsObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_TotalDataStatisticsEN> GetAllvzx_TotalDataStatisticsObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsvzx_TotalDataStatisticsEN> arrvzx_TotalDataStatisticsObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrvzx_TotalDataStatisticsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_TotalDataStatisticsEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvzx_TotalDataStatisticsEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsvzx_TotalDataStatisticsEN> arrvzx_TotalDataStatisticsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvzx_TotalDataStatisticsObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvzx_TotalDataStatisticsEN._CurrTabName, strIdCurrEduCls);
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
if (strInFldName != convzx_TotalDataStatistics.TotalDataId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convzx_TotalDataStatistics.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convzx_TotalDataStatistics.AttributeName));
throw new Exception(strMsg);
}
var objvzx_TotalDataStatistics = clsvzx_TotalDataStatisticsBL.GetObjByTotalDataIdCache(strTotalDataId, strIdCurrEduCls);
if (objvzx_TotalDataStatistics == null) return "";
return objvzx_TotalDataStatistics[strOutFldName].ToString();
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
int intRecCount = clsvzx_TotalDataStatisticsDA.GetRecCount(strTabName);
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
int intRecCount = clsvzx_TotalDataStatisticsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvzx_TotalDataStatisticsDA.GetRecCount();
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
int intRecCount = clsvzx_TotalDataStatisticsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvzx_TotalDataStatisticsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsCond)
{
 string strIdCurrEduCls = objvzx_TotalDataStatisticsCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvzx_TotalDataStatisticsBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvzx_TotalDataStatisticsEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvzx_TotalDataStatisticsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_TotalDataStatistics.AttributeName)
{
if (objvzx_TotalDataStatisticsCond.IsUpdated(strFldName) == false) continue;
if (objvzx_TotalDataStatisticsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_TotalDataStatisticsCond[strFldName].ToString());
}
else
{
if (objvzx_TotalDataStatisticsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_TotalDataStatisticsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_TotalDataStatisticsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_TotalDataStatisticsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_TotalDataStatisticsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_TotalDataStatisticsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_TotalDataStatisticsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_TotalDataStatisticsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_TotalDataStatisticsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_TotalDataStatisticsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_TotalDataStatisticsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_TotalDataStatisticsCond[strFldName]));
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
 List<string> arrList = clsvzx_TotalDataStatisticsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vzx_TotalDataStatisticsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vzx_TotalDataStatisticsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}