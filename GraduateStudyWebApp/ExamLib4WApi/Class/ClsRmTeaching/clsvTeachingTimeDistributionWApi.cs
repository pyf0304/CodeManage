
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTeachingTimeDistributionWApi
 表名:vTeachingTimeDistribution(01120441)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:49:42
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课堂教学
 模块英文名:ClsRmTeaching
 框架-层名:WA_访问层_CS(WA_Access)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Data; 
using System.Data.SqlClient;
using System.Text; 
using System.Web;
using System.Collections; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using com.taishsoft.common;
using com.taishsoft.comm_db_obj;
using com.taishsoft.dynamiccompiler;
using com.taishsoft.json;
using ExamLib.Entity;

namespace ExamLib4WApi
{
public static class clsvTeachingTimeDistributionWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingTimeDistributionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingTimeDistributionEN SetmId(this clsvTeachingTimeDistributionEN objvTeachingTimeDistributionEN, long lngmId, string strComparisonOp="")
	{
objvTeachingTimeDistributionEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingTimeDistributionEN.dicFldComparisonOp.ContainsKey(convTeachingTimeDistribution.mId) == false)
{
objvTeachingTimeDistributionEN.dicFldComparisonOp.Add(convTeachingTimeDistribution.mId, strComparisonOp);
}
else
{
objvTeachingTimeDistributionEN.dicFldComparisonOp[convTeachingTimeDistribution.mId] = strComparisonOp;
}
}
return objvTeachingTimeDistributionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingTimeDistributionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingTimeDistributionEN SetFuncModuleId(this clsvTeachingTimeDistributionEN objvTeachingTimeDistributionEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convTeachingTimeDistribution.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convTeachingTimeDistribution.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convTeachingTimeDistribution.FuncModuleId);
objvTeachingTimeDistributionEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingTimeDistributionEN.dicFldComparisonOp.ContainsKey(convTeachingTimeDistribution.FuncModuleId) == false)
{
objvTeachingTimeDistributionEN.dicFldComparisonOp.Add(convTeachingTimeDistribution.FuncModuleId, strComparisonOp);
}
else
{
objvTeachingTimeDistributionEN.dicFldComparisonOp[convTeachingTimeDistribution.FuncModuleId] = strComparisonOp;
}
}
return objvTeachingTimeDistributionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingTimeDistributionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingTimeDistributionEN SetFuncModuleName(this clsvTeachingTimeDistributionEN objvTeachingTimeDistributionEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleName, convTeachingTimeDistribution.FuncModuleName);
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convTeachingTimeDistribution.FuncModuleName);
objvTeachingTimeDistributionEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingTimeDistributionEN.dicFldComparisonOp.ContainsKey(convTeachingTimeDistribution.FuncModuleName) == false)
{
objvTeachingTimeDistributionEN.dicFldComparisonOp.Add(convTeachingTimeDistribution.FuncModuleName, strComparisonOp);
}
else
{
objvTeachingTimeDistributionEN.dicFldComparisonOp[convTeachingTimeDistribution.FuncModuleName] = strComparisonOp;
}
}
return objvTeachingTimeDistributionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingTimeDistributionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingTimeDistributionEN SetFuncModuleName_Sim(this clsvTeachingTimeDistributionEN objvTeachingTimeDistributionEN, string strFuncModuleName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName_Sim, 30, convTeachingTimeDistribution.FuncModuleName_Sim);
objvTeachingTimeDistributionEN.FuncModuleName_Sim = strFuncModuleName_Sim; //功能模块简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingTimeDistributionEN.dicFldComparisonOp.ContainsKey(convTeachingTimeDistribution.FuncModuleName_Sim) == false)
{
objvTeachingTimeDistributionEN.dicFldComparisonOp.Add(convTeachingTimeDistribution.FuncModuleName_Sim, strComparisonOp);
}
else
{
objvTeachingTimeDistributionEN.dicFldComparisonOp[convTeachingTimeDistribution.FuncModuleName_Sim] = strComparisonOp;
}
}
return objvTeachingTimeDistributionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingTimeDistributionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingTimeDistributionEN Setid_MicroteachCase(this clsvTeachingTimeDistributionEN objvTeachingTimeDistributionEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroteachCase, convTeachingTimeDistribution.id_MicroteachCase);
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convTeachingTimeDistribution.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convTeachingTimeDistribution.id_MicroteachCase);
objvTeachingTimeDistributionEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingTimeDistributionEN.dicFldComparisonOp.ContainsKey(convTeachingTimeDistribution.id_MicroteachCase) == false)
{
objvTeachingTimeDistributionEN.dicFldComparisonOp.Add(convTeachingTimeDistribution.id_MicroteachCase, strComparisonOp);
}
else
{
objvTeachingTimeDistributionEN.dicFldComparisonOp[convTeachingTimeDistribution.id_MicroteachCase] = strComparisonOp;
}
}
return objvTeachingTimeDistributionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingTimeDistributionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingTimeDistributionEN SetCaseName(this clsvTeachingTimeDistributionEN objvTeachingTimeDistributionEN, string strCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseName, 100, convTeachingTimeDistribution.CaseName);
objvTeachingTimeDistributionEN.CaseName = strCaseName; //案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingTimeDistributionEN.dicFldComparisonOp.ContainsKey(convTeachingTimeDistribution.CaseName) == false)
{
objvTeachingTimeDistributionEN.dicFldComparisonOp.Add(convTeachingTimeDistribution.CaseName, strComparisonOp);
}
else
{
objvTeachingTimeDistributionEN.dicFldComparisonOp[convTeachingTimeDistribution.CaseName] = strComparisonOp;
}
}
return objvTeachingTimeDistributionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingTimeDistributionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingTimeDistributionEN SetOwnerId(this clsvTeachingTimeDistributionEN objvTeachingTimeDistributionEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, convTeachingTimeDistribution.OwnerId);
clsCheckSql.CheckFieldLen(strOwnerId, 20, convTeachingTimeDistribution.OwnerId);
objvTeachingTimeDistributionEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingTimeDistributionEN.dicFldComparisonOp.ContainsKey(convTeachingTimeDistribution.OwnerId) == false)
{
objvTeachingTimeDistributionEN.dicFldComparisonOp.Add(convTeachingTimeDistribution.OwnerId, strComparisonOp);
}
else
{
objvTeachingTimeDistributionEN.dicFldComparisonOp[convTeachingTimeDistribution.OwnerId] = strComparisonOp;
}
}
return objvTeachingTimeDistributionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingTimeDistributionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingTimeDistributionEN SetTeachingActivityTypeId(this clsvTeachingTimeDistributionEN objvTeachingTimeDistributionEN, string strTeachingActivityTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachingActivityTypeId, convTeachingTimeDistribution.TeachingActivityTypeId);
clsCheckSql.CheckFieldLen(strTeachingActivityTypeId, 2, convTeachingTimeDistribution.TeachingActivityTypeId);
clsCheckSql.CheckFieldForeignKey(strTeachingActivityTypeId, 2, convTeachingTimeDistribution.TeachingActivityTypeId);
objvTeachingTimeDistributionEN.TeachingActivityTypeId = strTeachingActivityTypeId; //教学活动类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingTimeDistributionEN.dicFldComparisonOp.ContainsKey(convTeachingTimeDistribution.TeachingActivityTypeId) == false)
{
objvTeachingTimeDistributionEN.dicFldComparisonOp.Add(convTeachingTimeDistribution.TeachingActivityTypeId, strComparisonOp);
}
else
{
objvTeachingTimeDistributionEN.dicFldComparisonOp[convTeachingTimeDistribution.TeachingActivityTypeId] = strComparisonOp;
}
}
return objvTeachingTimeDistributionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingTimeDistributionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingTimeDistributionEN SetTeachingActivityTypeName(this clsvTeachingTimeDistributionEN objvTeachingTimeDistributionEN, string strTeachingActivityTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachingActivityTypeName, convTeachingTimeDistribution.TeachingActivityTypeName);
clsCheckSql.CheckFieldLen(strTeachingActivityTypeName, 30, convTeachingTimeDistribution.TeachingActivityTypeName);
objvTeachingTimeDistributionEN.TeachingActivityTypeName = strTeachingActivityTypeName; //教学活动类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingTimeDistributionEN.dicFldComparisonOp.ContainsKey(convTeachingTimeDistribution.TeachingActivityTypeName) == false)
{
objvTeachingTimeDistributionEN.dicFldComparisonOp.Add(convTeachingTimeDistribution.TeachingActivityTypeName, strComparisonOp);
}
else
{
objvTeachingTimeDistributionEN.dicFldComparisonOp[convTeachingTimeDistribution.TeachingActivityTypeName] = strComparisonOp;
}
}
return objvTeachingTimeDistributionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingTimeDistributionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingTimeDistributionEN SetUseTime(this clsvTeachingTimeDistributionEN objvTeachingTimeDistributionEN, double dblUseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(dblUseTime, convTeachingTimeDistribution.UseTime);
objvTeachingTimeDistributionEN.UseTime = dblUseTime; //使用时间s
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingTimeDistributionEN.dicFldComparisonOp.ContainsKey(convTeachingTimeDistribution.UseTime) == false)
{
objvTeachingTimeDistributionEN.dicFldComparisonOp.Add(convTeachingTimeDistribution.UseTime, strComparisonOp);
}
else
{
objvTeachingTimeDistributionEN.dicFldComparisonOp[convTeachingTimeDistribution.UseTime] = strComparisonOp;
}
}
return objvTeachingTimeDistributionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingTimeDistributionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingTimeDistributionEN SetTimePercent(this clsvTeachingTimeDistributionEN objvTeachingTimeDistributionEN, double dblTimePercent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(dblTimePercent, convTeachingTimeDistribution.TimePercent);
objvTeachingTimeDistributionEN.TimePercent = dblTimePercent; //时间比例
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingTimeDistributionEN.dicFldComparisonOp.ContainsKey(convTeachingTimeDistribution.TimePercent) == false)
{
objvTeachingTimeDistributionEN.dicFldComparisonOp.Add(convTeachingTimeDistribution.TimePercent, strComparisonOp);
}
else
{
objvTeachingTimeDistributionEN.dicFldComparisonOp[convTeachingTimeDistribution.TimePercent] = strComparisonOp;
}
}
return objvTeachingTimeDistributionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingTimeDistributionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingTimeDistributionEN SetUseMedia(this clsvTeachingTimeDistributionEN objvTeachingTimeDistributionEN, string strUseMedia, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUseMedia, convTeachingTimeDistribution.UseMedia);
clsCheckSql.CheckFieldLen(strUseMedia, 30, convTeachingTimeDistribution.UseMedia);
objvTeachingTimeDistributionEN.UseMedia = strUseMedia; //使用媒体
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingTimeDistributionEN.dicFldComparisonOp.ContainsKey(convTeachingTimeDistribution.UseMedia) == false)
{
objvTeachingTimeDistributionEN.dicFldComparisonOp.Add(convTeachingTimeDistribution.UseMedia, strComparisonOp);
}
else
{
objvTeachingTimeDistributionEN.dicFldComparisonOp[convTeachingTimeDistribution.UseMedia] = strComparisonOp;
}
}
return objvTeachingTimeDistributionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingTimeDistributionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingTimeDistributionEN SetTimeLengthOfVideo(this clsvTeachingTimeDistributionEN objvTeachingTimeDistributionEN, double dblTimeLengthOfVideo, string strComparisonOp="")
	{
objvTeachingTimeDistributionEN.TimeLengthOfVideo = dblTimeLengthOfVideo; //视频时长
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingTimeDistributionEN.dicFldComparisonOp.ContainsKey(convTeachingTimeDistribution.TimeLengthOfVideo) == false)
{
objvTeachingTimeDistributionEN.dicFldComparisonOp.Add(convTeachingTimeDistribution.TimeLengthOfVideo, strComparisonOp);
}
else
{
objvTeachingTimeDistributionEN.dicFldComparisonOp[convTeachingTimeDistribution.TimeLengthOfVideo] = strComparisonOp;
}
}
return objvTeachingTimeDistributionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingTimeDistributionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingTimeDistributionEN Setid_School(this clsvTeachingTimeDistributionEN objvTeachingTimeDistributionEN, string strid_School, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_School, 4, convTeachingTimeDistribution.id_School);
clsCheckSql.CheckFieldForeignKey(strid_School, 4, convTeachingTimeDistribution.id_School);
objvTeachingTimeDistributionEN.id_School = strid_School; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingTimeDistributionEN.dicFldComparisonOp.ContainsKey(convTeachingTimeDistribution.id_School) == false)
{
objvTeachingTimeDistributionEN.dicFldComparisonOp.Add(convTeachingTimeDistribution.id_School, strComparisonOp);
}
else
{
objvTeachingTimeDistributionEN.dicFldComparisonOp[convTeachingTimeDistribution.id_School] = strComparisonOp;
}
}
return objvTeachingTimeDistributionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingTimeDistributionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingTimeDistributionEN SetSchoolId(this clsvTeachingTimeDistributionEN objvTeachingTimeDistributionEN, string strSchoolId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolId, convTeachingTimeDistribution.SchoolId);
clsCheckSql.CheckFieldLen(strSchoolId, 10, convTeachingTimeDistribution.SchoolId);
objvTeachingTimeDistributionEN.SchoolId = strSchoolId; //学校编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingTimeDistributionEN.dicFldComparisonOp.ContainsKey(convTeachingTimeDistribution.SchoolId) == false)
{
objvTeachingTimeDistributionEN.dicFldComparisonOp.Add(convTeachingTimeDistribution.SchoolId, strComparisonOp);
}
else
{
objvTeachingTimeDistributionEN.dicFldComparisonOp[convTeachingTimeDistribution.SchoolId] = strComparisonOp;
}
}
return objvTeachingTimeDistributionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingTimeDistributionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingTimeDistributionEN SetSchoolName(this clsvTeachingTimeDistributionEN objvTeachingTimeDistributionEN, string strSchoolName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolName, convTeachingTimeDistribution.SchoolName);
clsCheckSql.CheckFieldLen(strSchoolName, 50, convTeachingTimeDistribution.SchoolName);
objvTeachingTimeDistributionEN.SchoolName = strSchoolName; //学校名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingTimeDistributionEN.dicFldComparisonOp.ContainsKey(convTeachingTimeDistribution.SchoolName) == false)
{
objvTeachingTimeDistributionEN.dicFldComparisonOp.Add(convTeachingTimeDistribution.SchoolName, strComparisonOp);
}
else
{
objvTeachingTimeDistributionEN.dicFldComparisonOp[convTeachingTimeDistribution.SchoolName] = strComparisonOp;
}
}
return objvTeachingTimeDistributionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingTimeDistributionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingTimeDistributionEN SetUpdDate(this clsvTeachingTimeDistributionEN objvTeachingTimeDistributionEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convTeachingTimeDistribution.UpdDate);
objvTeachingTimeDistributionEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingTimeDistributionEN.dicFldComparisonOp.ContainsKey(convTeachingTimeDistribution.UpdDate) == false)
{
objvTeachingTimeDistributionEN.dicFldComparisonOp.Add(convTeachingTimeDistribution.UpdDate, strComparisonOp);
}
else
{
objvTeachingTimeDistributionEN.dicFldComparisonOp[convTeachingTimeDistribution.UpdDate] = strComparisonOp;
}
}
return objvTeachingTimeDistributionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingTimeDistributionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingTimeDistributionEN SetUpdUserId(this clsvTeachingTimeDistributionEN objvTeachingTimeDistributionEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convTeachingTimeDistribution.UpdUserId);
objvTeachingTimeDistributionEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingTimeDistributionEN.dicFldComparisonOp.ContainsKey(convTeachingTimeDistribution.UpdUserId) == false)
{
objvTeachingTimeDistributionEN.dicFldComparisonOp.Add(convTeachingTimeDistribution.UpdUserId, strComparisonOp);
}
else
{
objvTeachingTimeDistributionEN.dicFldComparisonOp[convTeachingTimeDistribution.UpdUserId] = strComparisonOp;
}
}
return objvTeachingTimeDistributionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingTimeDistributionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingTimeDistributionEN SetMemo(this clsvTeachingTimeDistributionEN objvTeachingTimeDistributionEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convTeachingTimeDistribution.Memo);
objvTeachingTimeDistributionEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingTimeDistributionEN.dicFldComparisonOp.ContainsKey(convTeachingTimeDistribution.Memo) == false)
{
objvTeachingTimeDistributionEN.dicFldComparisonOp.Add(convTeachingTimeDistribution.Memo, strComparisonOp);
}
else
{
objvTeachingTimeDistributionEN.dicFldComparisonOp[convTeachingTimeDistribution.Memo] = strComparisonOp;
}
}
return objvTeachingTimeDistributionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingTimeDistributionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingTimeDistributionEN SetOrderNum(this clsvTeachingTimeDistributionEN objvTeachingTimeDistributionEN, int intOrderNum, string strComparisonOp="")
	{
objvTeachingTimeDistributionEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingTimeDistributionEN.dicFldComparisonOp.ContainsKey(convTeachingTimeDistribution.OrderNum) == false)
{
objvTeachingTimeDistributionEN.dicFldComparisonOp.Add(convTeachingTimeDistribution.OrderNum, strComparisonOp);
}
else
{
objvTeachingTimeDistributionEN.dicFldComparisonOp[convTeachingTimeDistribution.OrderNum] = strComparisonOp;
}
}
return objvTeachingTimeDistributionEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvTeachingTimeDistributionEN objvTeachingTimeDistribution_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvTeachingTimeDistribution_Cond.IsUpdated(convTeachingTimeDistribution.mId) == true)
{
string strComparisonOp_mId = objvTeachingTimeDistribution_Cond.dicFldComparisonOp[convTeachingTimeDistribution.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingTimeDistribution.mId, objvTeachingTimeDistribution_Cond.mId, strComparisonOp_mId);
}
if (objvTeachingTimeDistribution_Cond.IsUpdated(convTeachingTimeDistribution.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvTeachingTimeDistribution_Cond.dicFldComparisonOp[convTeachingTimeDistribution.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingTimeDistribution.FuncModuleId, objvTeachingTimeDistribution_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvTeachingTimeDistribution_Cond.IsUpdated(convTeachingTimeDistribution.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvTeachingTimeDistribution_Cond.dicFldComparisonOp[convTeachingTimeDistribution.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingTimeDistribution.FuncModuleName, objvTeachingTimeDistribution_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvTeachingTimeDistribution_Cond.IsUpdated(convTeachingTimeDistribution.FuncModuleName_Sim) == true)
{
string strComparisonOp_FuncModuleName_Sim = objvTeachingTimeDistribution_Cond.dicFldComparisonOp[convTeachingTimeDistribution.FuncModuleName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingTimeDistribution.FuncModuleName_Sim, objvTeachingTimeDistribution_Cond.FuncModuleName_Sim, strComparisonOp_FuncModuleName_Sim);
}
if (objvTeachingTimeDistribution_Cond.IsUpdated(convTeachingTimeDistribution.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvTeachingTimeDistribution_Cond.dicFldComparisonOp[convTeachingTimeDistribution.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingTimeDistribution.id_MicroteachCase, objvTeachingTimeDistribution_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvTeachingTimeDistribution_Cond.IsUpdated(convTeachingTimeDistribution.CaseName) == true)
{
string strComparisonOp_CaseName = objvTeachingTimeDistribution_Cond.dicFldComparisonOp[convTeachingTimeDistribution.CaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingTimeDistribution.CaseName, objvTeachingTimeDistribution_Cond.CaseName, strComparisonOp_CaseName);
}
if (objvTeachingTimeDistribution_Cond.IsUpdated(convTeachingTimeDistribution.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvTeachingTimeDistribution_Cond.dicFldComparisonOp[convTeachingTimeDistribution.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingTimeDistribution.OwnerId, objvTeachingTimeDistribution_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvTeachingTimeDistribution_Cond.IsUpdated(convTeachingTimeDistribution.TeachingActivityTypeId) == true)
{
string strComparisonOp_TeachingActivityTypeId = objvTeachingTimeDistribution_Cond.dicFldComparisonOp[convTeachingTimeDistribution.TeachingActivityTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingTimeDistribution.TeachingActivityTypeId, objvTeachingTimeDistribution_Cond.TeachingActivityTypeId, strComparisonOp_TeachingActivityTypeId);
}
if (objvTeachingTimeDistribution_Cond.IsUpdated(convTeachingTimeDistribution.TeachingActivityTypeName) == true)
{
string strComparisonOp_TeachingActivityTypeName = objvTeachingTimeDistribution_Cond.dicFldComparisonOp[convTeachingTimeDistribution.TeachingActivityTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingTimeDistribution.TeachingActivityTypeName, objvTeachingTimeDistribution_Cond.TeachingActivityTypeName, strComparisonOp_TeachingActivityTypeName);
}
if (objvTeachingTimeDistribution_Cond.IsUpdated(convTeachingTimeDistribution.UseTime) == true)
{
string strComparisonOp_UseTime = objvTeachingTimeDistribution_Cond.dicFldComparisonOp[convTeachingTimeDistribution.UseTime];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingTimeDistribution.UseTime, objvTeachingTimeDistribution_Cond.UseTime, strComparisonOp_UseTime);
}
if (objvTeachingTimeDistribution_Cond.IsUpdated(convTeachingTimeDistribution.TimePercent) == true)
{
string strComparisonOp_TimePercent = objvTeachingTimeDistribution_Cond.dicFldComparisonOp[convTeachingTimeDistribution.TimePercent];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingTimeDistribution.TimePercent, objvTeachingTimeDistribution_Cond.TimePercent, strComparisonOp_TimePercent);
}
if (objvTeachingTimeDistribution_Cond.IsUpdated(convTeachingTimeDistribution.UseMedia) == true)
{
string strComparisonOp_UseMedia = objvTeachingTimeDistribution_Cond.dicFldComparisonOp[convTeachingTimeDistribution.UseMedia];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingTimeDistribution.UseMedia, objvTeachingTimeDistribution_Cond.UseMedia, strComparisonOp_UseMedia);
}
if (objvTeachingTimeDistribution_Cond.IsUpdated(convTeachingTimeDistribution.TimeLengthOfVideo) == true)
{
string strComparisonOp_TimeLengthOfVideo = objvTeachingTimeDistribution_Cond.dicFldComparisonOp[convTeachingTimeDistribution.TimeLengthOfVideo];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingTimeDistribution.TimeLengthOfVideo, objvTeachingTimeDistribution_Cond.TimeLengthOfVideo, strComparisonOp_TimeLengthOfVideo);
}
if (objvTeachingTimeDistribution_Cond.IsUpdated(convTeachingTimeDistribution.id_School) == true)
{
string strComparisonOp_id_School = objvTeachingTimeDistribution_Cond.dicFldComparisonOp[convTeachingTimeDistribution.id_School];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingTimeDistribution.id_School, objvTeachingTimeDistribution_Cond.id_School, strComparisonOp_id_School);
}
if (objvTeachingTimeDistribution_Cond.IsUpdated(convTeachingTimeDistribution.SchoolId) == true)
{
string strComparisonOp_SchoolId = objvTeachingTimeDistribution_Cond.dicFldComparisonOp[convTeachingTimeDistribution.SchoolId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingTimeDistribution.SchoolId, objvTeachingTimeDistribution_Cond.SchoolId, strComparisonOp_SchoolId);
}
if (objvTeachingTimeDistribution_Cond.IsUpdated(convTeachingTimeDistribution.SchoolName) == true)
{
string strComparisonOp_SchoolName = objvTeachingTimeDistribution_Cond.dicFldComparisonOp[convTeachingTimeDistribution.SchoolName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingTimeDistribution.SchoolName, objvTeachingTimeDistribution_Cond.SchoolName, strComparisonOp_SchoolName);
}
if (objvTeachingTimeDistribution_Cond.IsUpdated(convTeachingTimeDistribution.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvTeachingTimeDistribution_Cond.dicFldComparisonOp[convTeachingTimeDistribution.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingTimeDistribution.UpdDate, objvTeachingTimeDistribution_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvTeachingTimeDistribution_Cond.IsUpdated(convTeachingTimeDistribution.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objvTeachingTimeDistribution_Cond.dicFldComparisonOp[convTeachingTimeDistribution.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingTimeDistribution.UpdUserId, objvTeachingTimeDistribution_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objvTeachingTimeDistribution_Cond.IsUpdated(convTeachingTimeDistribution.Memo) == true)
{
string strComparisonOp_Memo = objvTeachingTimeDistribution_Cond.dicFldComparisonOp[convTeachingTimeDistribution.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingTimeDistribution.Memo, objvTeachingTimeDistribution_Cond.Memo, strComparisonOp_Memo);
}
if (objvTeachingTimeDistribution_Cond.IsUpdated(convTeachingTimeDistribution.OrderNum) == true)
{
string strComparisonOp_OrderNum = objvTeachingTimeDistribution_Cond.dicFldComparisonOp[convTeachingTimeDistribution.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingTimeDistribution.OrderNum, objvTeachingTimeDistribution_Cond.OrderNum, strComparisonOp_OrderNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v教学时间分布(vTeachingTimeDistribution)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvTeachingTimeDistributionWApi
{
private static readonly string mstrApiControllerName = "vTeachingTimeDistributionApi";

 public clsvTeachingTimeDistributionWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTeachingTimeDistributionEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clsvTeachingTimeDistributionEN objvTeachingTimeDistributionEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvTeachingTimeDistributionEN = JsonConvert.DeserializeObject<clsvTeachingTimeDistributionEN>((string)jobjReturn["ReturnObj"]);
return objvTeachingTimeDistributionEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId_WA_Cache)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTeachingTimeDistributionEN GetObjBymId_WA_Cache(long lngmId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvTeachingTimeDistributionEN objvTeachingTimeDistributionEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvTeachingTimeDistributionEN = JsonConvert.DeserializeObject<clsvTeachingTimeDistributionEN>((string)jobjReturn["ReturnObj"]);
return objvTeachingTimeDistributionEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstID)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static long GetFirstID(string strWhereCond)
{
string strAction = "GetFirstID";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var strReturnStr = (string)jobjReturn["ReturnStr"];
return long.Parse(strReturnStr);
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsvTeachingTimeDistributionEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvTeachingTimeDistributionEN objvTeachingTimeDistributionEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvTeachingTimeDistributionEN = JsonConvert.DeserializeObject<clsvTeachingTimeDistributionEN>((string)jobjReturn["ReturnObj"]);
return objvTeachingTimeDistributionEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTeachingTimeDistributionEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvTeachingTimeDistributionEN._CurrTabName_S);
List<clsvTeachingTimeDistributionEN> arrvTeachingTimeDistributionObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvTeachingTimeDistributionEN> arrvTeachingTimeDistributionObjLst_Sel =
from objvTeachingTimeDistributionEN in arrvTeachingTimeDistributionObjLst_Cache
where objvTeachingTimeDistributionEN.mId == lngmId
select objvTeachingTimeDistributionEN;
if (arrvTeachingTimeDistributionObjLst_Sel.Count() == 0)
{
   clsvTeachingTimeDistributionEN obj = clsvTeachingTimeDistributionWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvTeachingTimeDistributionObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachingTimeDistributionEN> GetObjLst(string strWhereCond)
{
 List<clsvTeachingTimeDistributionEN> arrObjLst = null; 
string strAction = "GetObjLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingTimeDistributionEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachingTimeDistributionEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvTeachingTimeDistributionEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingTimeDistributionEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("根据关键字列表获取对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_Cache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvTeachingTimeDistributionEN> GetObjLstByMIdLst_Cache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvTeachingTimeDistributionEN._CurrTabName_S);
List<clsvTeachingTimeDistributionEN> arrvTeachingTimeDistributionObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvTeachingTimeDistributionEN> arrvTeachingTimeDistributionObjLst_Sel =
from objvTeachingTimeDistributionEN in arrvTeachingTimeDistributionObjLst_Cache
where arrMId.Contains(objvTeachingTimeDistributionEN.mId)
select objvTeachingTimeDistributionEN;
return arrvTeachingTimeDistributionObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachingTimeDistributionEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId)
{
 List<clsvTeachingTimeDistributionEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingTimeDistributionEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("根据关键字列表获取对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachingTimeDistributionEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvTeachingTimeDistributionEN> arrObjLst = null; 
string strAction = "GetTopObjLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objTopPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuTopPara>(objTopPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingTimeDistributionEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("根据条件获取顶部对象列表,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取范围内的对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachingTimeDistributionEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvTeachingTimeDistributionEN> arrObjLst = null; 
string strAction = "GetObjLstByRange";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam =  objRangePara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuRangePara>(objRangePara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingTimeDistributionEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件分页获取JSON对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clsvTeachingTimeDistributionEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvTeachingTimeDistributionEN> arrObjLst = null; 
string strAction = "GetObjLstByPager";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingTimeDistributionEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件分页获取JSON对象列表, 使用缓存
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPager_Cache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clsvTeachingTimeDistributionEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvTeachingTimeDistributionEN> arrObjLst = null; 
string strAction = "GetObjLstByPager_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingTimeDistributionEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件判断是否存在记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_IsExistRecord)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistRecord(string strWhereCond)
{
//检测记录是否存在
string strAction = "IsExistRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_IsExist)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相关记录数
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int GetRecCountByCond(string strWhereCond)
{
string strAction = "GetRecCountByCond";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相关记录数
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFldValue)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static List<string> GetFldValue(string strFldName, string strWhereCond)
{
string strAction = "GetFldValue";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
string strReturnStrLst = (string)jobjReturn["ReturnStrLst"];
var arrReturnStrLst = strReturnStrLst.Split(",".ToCharArray());
return arrReturnStrLst.Select(x => x).ToList();
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objvTeachingTimeDistributionENS">源对象</param>
 /// <param name = "objvTeachingTimeDistributionENT">目标对象</param>
 public static void CopyTo(clsvTeachingTimeDistributionEN objvTeachingTimeDistributionENS, clsvTeachingTimeDistributionEN objvTeachingTimeDistributionENT)
{
try
{
objvTeachingTimeDistributionENT.mId = objvTeachingTimeDistributionENS.mId; //mId
objvTeachingTimeDistributionENT.FuncModuleId = objvTeachingTimeDistributionENS.FuncModuleId; //功能模块Id
objvTeachingTimeDistributionENT.FuncModuleName = objvTeachingTimeDistributionENS.FuncModuleName; //功能模块名称
objvTeachingTimeDistributionENT.FuncModuleName_Sim = objvTeachingTimeDistributionENS.FuncModuleName_Sim; //功能模块简称
objvTeachingTimeDistributionENT.id_MicroteachCase = objvTeachingTimeDistributionENS.id_MicroteachCase; //微格教学案例流水号
objvTeachingTimeDistributionENT.CaseName = objvTeachingTimeDistributionENS.CaseName; //案例名称
objvTeachingTimeDistributionENT.OwnerId = objvTeachingTimeDistributionENS.OwnerId; //拥有者Id
objvTeachingTimeDistributionENT.TeachingActivityTypeId = objvTeachingTimeDistributionENS.TeachingActivityTypeId; //教学活动类型Id
objvTeachingTimeDistributionENT.TeachingActivityTypeName = objvTeachingTimeDistributionENS.TeachingActivityTypeName; //教学活动类型名称
objvTeachingTimeDistributionENT.UseTime = objvTeachingTimeDistributionENS.UseTime; //使用时间s
objvTeachingTimeDistributionENT.TimePercent = objvTeachingTimeDistributionENS.TimePercent; //时间比例
objvTeachingTimeDistributionENT.UseMedia = objvTeachingTimeDistributionENS.UseMedia; //使用媒体
objvTeachingTimeDistributionENT.TimeLengthOfVideo = objvTeachingTimeDistributionENS.TimeLengthOfVideo; //视频时长
objvTeachingTimeDistributionENT.id_School = objvTeachingTimeDistributionENS.id_School; //学校流水号
objvTeachingTimeDistributionENT.SchoolId = objvTeachingTimeDistributionENS.SchoolId; //学校编号
objvTeachingTimeDistributionENT.SchoolName = objvTeachingTimeDistributionENS.SchoolName; //学校名称
objvTeachingTimeDistributionENT.UpdDate = objvTeachingTimeDistributionENS.UpdDate; //修改日期
objvTeachingTimeDistributionENT.UpdUserId = objvTeachingTimeDistributionENS.UpdUserId; //修改用户Id
objvTeachingTimeDistributionENT.Memo = objvTeachingTimeDistributionENS.Memo; //备注
objvTeachingTimeDistributionENT.OrderNum = objvTeachingTimeDistributionENS.OrderNum; //序号
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000001)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

/// <summary>
/// 对象列表 转换为 DataTable数据集合
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ToDataTable)
/// </summary>
/// <param name="arrObj">原对象列表</param>
/// <returns>返回的DataTable</returns>
public static DataTable ToDataTable(List<clsvTeachingTimeDistributionEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvTeachingTimeDistributionEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvTeachingTimeDistributionEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvTeachingTimeDistributionEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvTeachingTimeDistributionEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvTeachingTimeDistributionEN.AttributeName)
{
dataRow[strAttrName] = objInFor[strAttrName];
}
dataTable.Rows.Add(dataRow); //循环添加行到DataTable中
}
}
catch (Exception objExceptoin)
{
throw objExceptoin;
}
result = dataTable;
return result;
}

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_InitListCache)
 /// </summary>
public static void InitListCache()
{
//检查缓存刷新机制
string strMsg = "";
if (clsFuncModuleWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleWApi没有刷新缓存机制(clsFuncModuleWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachingTimeDistributionWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachingTimeDistributionWApi没有刷新缓存机制(clsTeachingTimeDistributionWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzSchoolWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzSchoolWApi没有刷新缓存机制(clsXzSchoolWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachingActivityTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachingActivityTypeWApi没有刷新缓存机制(clsTeachingActivityTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvTeachingTimeDistributionObjLst_Cache == null)
//{
//arrvTeachingTimeDistributionObjLst_Cache = await clsvTeachingTimeDistributionWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvTeachingTimeDistributionEN._CurrTabName_S);
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
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTeachingTimeDistributionEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvTeachingTimeDistributionEN._CurrTabName_S);
List<clsvTeachingTimeDistributionEN> arrvTeachingTimeDistributionObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvTeachingTimeDistributionObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvTeachingTimeDistributionEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convTeachingTimeDistribution.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convTeachingTimeDistribution.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingTimeDistribution.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingTimeDistribution.FuncModuleName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingTimeDistribution.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingTimeDistribution.CaseName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingTimeDistribution.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingTimeDistribution.TeachingActivityTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingTimeDistribution.TeachingActivityTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingTimeDistribution.UseTime, Type.GetType("System.Decimal"));
objDT.Columns.Add(convTeachingTimeDistribution.TimePercent, Type.GetType("System.Decimal"));
objDT.Columns.Add(convTeachingTimeDistribution.UseMedia, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingTimeDistribution.TimeLengthOfVideo, Type.GetType("System.Decimal"));
objDT.Columns.Add(convTeachingTimeDistribution.id_School, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingTimeDistribution.SchoolId, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingTimeDistribution.SchoolName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingTimeDistribution.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingTimeDistribution.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingTimeDistribution.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingTimeDistribution.OrderNum, Type.GetType("System.Int32"));
foreach (clsvTeachingTimeDistributionEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convTeachingTimeDistribution.mId] = objInFor[convTeachingTimeDistribution.mId];
objDR[convTeachingTimeDistribution.FuncModuleId] = objInFor[convTeachingTimeDistribution.FuncModuleId];
objDR[convTeachingTimeDistribution.FuncModuleName] = objInFor[convTeachingTimeDistribution.FuncModuleName];
objDR[convTeachingTimeDistribution.FuncModuleName_Sim] = objInFor[convTeachingTimeDistribution.FuncModuleName_Sim];
objDR[convTeachingTimeDistribution.id_MicroteachCase] = objInFor[convTeachingTimeDistribution.id_MicroteachCase];
objDR[convTeachingTimeDistribution.CaseName] = objInFor[convTeachingTimeDistribution.CaseName];
objDR[convTeachingTimeDistribution.OwnerId] = objInFor[convTeachingTimeDistribution.OwnerId];
objDR[convTeachingTimeDistribution.TeachingActivityTypeId] = objInFor[convTeachingTimeDistribution.TeachingActivityTypeId];
objDR[convTeachingTimeDistribution.TeachingActivityTypeName] = objInFor[convTeachingTimeDistribution.TeachingActivityTypeName];
objDR[convTeachingTimeDistribution.UseTime] = objInFor[convTeachingTimeDistribution.UseTime];
objDR[convTeachingTimeDistribution.TimePercent] = objInFor[convTeachingTimeDistribution.TimePercent];
objDR[convTeachingTimeDistribution.UseMedia] = objInFor[convTeachingTimeDistribution.UseMedia];
objDR[convTeachingTimeDistribution.TimeLengthOfVideo] = objInFor[convTeachingTimeDistribution.TimeLengthOfVideo];
objDR[convTeachingTimeDistribution.id_School] = objInFor[convTeachingTimeDistribution.id_School];
objDR[convTeachingTimeDistribution.SchoolId] = objInFor[convTeachingTimeDistribution.SchoolId];
objDR[convTeachingTimeDistribution.SchoolName] = objInFor[convTeachingTimeDistribution.SchoolName];
objDR[convTeachingTimeDistribution.UpdDate] = objInFor[convTeachingTimeDistribution.UpdDate];
objDR[convTeachingTimeDistribution.UpdUserId] = objInFor[convTeachingTimeDistribution.UpdUserId];
objDR[convTeachingTimeDistribution.Memo] = objInFor[convTeachingTimeDistribution.Memo];
objDR[convTeachingTimeDistribution.OrderNum] = objInFor[convTeachingTimeDistribution.OrderNum];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}