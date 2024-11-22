
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTeachingTimeDistributionWApi
 表名:TeachingTimeDistribution(01120440)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:37:54
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
public static class clsTeachingTimeDistributionWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingTimeDistributionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingTimeDistributionEN SetmId(this clsTeachingTimeDistributionEN objTeachingTimeDistributionEN, long lngmId, string strComparisonOp="")
	{
objTeachingTimeDistributionEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingTimeDistributionEN.dicFldComparisonOp.ContainsKey(conTeachingTimeDistribution.mId) == false)
{
objTeachingTimeDistributionEN.dicFldComparisonOp.Add(conTeachingTimeDistribution.mId, strComparisonOp);
}
else
{
objTeachingTimeDistributionEN.dicFldComparisonOp[conTeachingTimeDistribution.mId] = strComparisonOp;
}
}
return objTeachingTimeDistributionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingTimeDistributionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingTimeDistributionEN SetFuncModuleId(this clsTeachingTimeDistributionEN objTeachingTimeDistributionEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, conTeachingTimeDistribution.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, conTeachingTimeDistribution.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, conTeachingTimeDistribution.FuncModuleId);
objTeachingTimeDistributionEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingTimeDistributionEN.dicFldComparisonOp.ContainsKey(conTeachingTimeDistribution.FuncModuleId) == false)
{
objTeachingTimeDistributionEN.dicFldComparisonOp.Add(conTeachingTimeDistribution.FuncModuleId, strComparisonOp);
}
else
{
objTeachingTimeDistributionEN.dicFldComparisonOp[conTeachingTimeDistribution.FuncModuleId] = strComparisonOp;
}
}
return objTeachingTimeDistributionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingTimeDistributionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingTimeDistributionEN Setid_MicroteachCase(this clsTeachingTimeDistributionEN objTeachingTimeDistributionEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroteachCase, conTeachingTimeDistribution.id_MicroteachCase);
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, conTeachingTimeDistribution.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, conTeachingTimeDistribution.id_MicroteachCase);
objTeachingTimeDistributionEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingTimeDistributionEN.dicFldComparisonOp.ContainsKey(conTeachingTimeDistribution.id_MicroteachCase) == false)
{
objTeachingTimeDistributionEN.dicFldComparisonOp.Add(conTeachingTimeDistribution.id_MicroteachCase, strComparisonOp);
}
else
{
objTeachingTimeDistributionEN.dicFldComparisonOp[conTeachingTimeDistribution.id_MicroteachCase] = strComparisonOp;
}
}
return objTeachingTimeDistributionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingTimeDistributionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingTimeDistributionEN SetCaseName(this clsTeachingTimeDistributionEN objTeachingTimeDistributionEN, string strCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseName, 100, conTeachingTimeDistribution.CaseName);
objTeachingTimeDistributionEN.CaseName = strCaseName; //案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingTimeDistributionEN.dicFldComparisonOp.ContainsKey(conTeachingTimeDistribution.CaseName) == false)
{
objTeachingTimeDistributionEN.dicFldComparisonOp.Add(conTeachingTimeDistribution.CaseName, strComparisonOp);
}
else
{
objTeachingTimeDistributionEN.dicFldComparisonOp[conTeachingTimeDistribution.CaseName] = strComparisonOp;
}
}
return objTeachingTimeDistributionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingTimeDistributionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingTimeDistributionEN SetOwnerId(this clsTeachingTimeDistributionEN objTeachingTimeDistributionEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerId, 20, conTeachingTimeDistribution.OwnerId);
objTeachingTimeDistributionEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingTimeDistributionEN.dicFldComparisonOp.ContainsKey(conTeachingTimeDistribution.OwnerId) == false)
{
objTeachingTimeDistributionEN.dicFldComparisonOp.Add(conTeachingTimeDistribution.OwnerId, strComparisonOp);
}
else
{
objTeachingTimeDistributionEN.dicFldComparisonOp[conTeachingTimeDistribution.OwnerId] = strComparisonOp;
}
}
return objTeachingTimeDistributionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingTimeDistributionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingTimeDistributionEN SetTeachingActivityTypeId(this clsTeachingTimeDistributionEN objTeachingTimeDistributionEN, string strTeachingActivityTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachingActivityTypeId, conTeachingTimeDistribution.TeachingActivityTypeId);
clsCheckSql.CheckFieldLen(strTeachingActivityTypeId, 2, conTeachingTimeDistribution.TeachingActivityTypeId);
clsCheckSql.CheckFieldForeignKey(strTeachingActivityTypeId, 2, conTeachingTimeDistribution.TeachingActivityTypeId);
objTeachingTimeDistributionEN.TeachingActivityTypeId = strTeachingActivityTypeId; //教学活动类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingTimeDistributionEN.dicFldComparisonOp.ContainsKey(conTeachingTimeDistribution.TeachingActivityTypeId) == false)
{
objTeachingTimeDistributionEN.dicFldComparisonOp.Add(conTeachingTimeDistribution.TeachingActivityTypeId, strComparisonOp);
}
else
{
objTeachingTimeDistributionEN.dicFldComparisonOp[conTeachingTimeDistribution.TeachingActivityTypeId] = strComparisonOp;
}
}
return objTeachingTimeDistributionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingTimeDistributionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingTimeDistributionEN SetUseTime(this clsTeachingTimeDistributionEN objTeachingTimeDistributionEN, double dblUseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(dblUseTime, conTeachingTimeDistribution.UseTime);
objTeachingTimeDistributionEN.UseTime = dblUseTime; //使用时间s
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingTimeDistributionEN.dicFldComparisonOp.ContainsKey(conTeachingTimeDistribution.UseTime) == false)
{
objTeachingTimeDistributionEN.dicFldComparisonOp.Add(conTeachingTimeDistribution.UseTime, strComparisonOp);
}
else
{
objTeachingTimeDistributionEN.dicFldComparisonOp[conTeachingTimeDistribution.UseTime] = strComparisonOp;
}
}
return objTeachingTimeDistributionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingTimeDistributionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingTimeDistributionEN SetTimePercent(this clsTeachingTimeDistributionEN objTeachingTimeDistributionEN, double dblTimePercent, string strComparisonOp="")
	{
objTeachingTimeDistributionEN.TimePercent = dblTimePercent; //时间比例
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingTimeDistributionEN.dicFldComparisonOp.ContainsKey(conTeachingTimeDistribution.TimePercent) == false)
{
objTeachingTimeDistributionEN.dicFldComparisonOp.Add(conTeachingTimeDistribution.TimePercent, strComparisonOp);
}
else
{
objTeachingTimeDistributionEN.dicFldComparisonOp[conTeachingTimeDistribution.TimePercent] = strComparisonOp;
}
}
return objTeachingTimeDistributionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingTimeDistributionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingTimeDistributionEN SetTimeLengthOfVideo(this clsTeachingTimeDistributionEN objTeachingTimeDistributionEN, double dblTimeLengthOfVideo, string strComparisonOp="")
	{
objTeachingTimeDistributionEN.TimeLengthOfVideo = dblTimeLengthOfVideo; //视频时长
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingTimeDistributionEN.dicFldComparisonOp.ContainsKey(conTeachingTimeDistribution.TimeLengthOfVideo) == false)
{
objTeachingTimeDistributionEN.dicFldComparisonOp.Add(conTeachingTimeDistribution.TimeLengthOfVideo, strComparisonOp);
}
else
{
objTeachingTimeDistributionEN.dicFldComparisonOp[conTeachingTimeDistribution.TimeLengthOfVideo] = strComparisonOp;
}
}
return objTeachingTimeDistributionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingTimeDistributionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingTimeDistributionEN SetTeachingTimeDistributionDetailMainTypeId(this clsTeachingTimeDistributionEN objTeachingTimeDistributionEN, string strTeachingTimeDistributionDetailMainTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingTimeDistributionDetailMainTypeId, 4, conTeachingTimeDistribution.TeachingTimeDistributionDetailMainTypeId);
clsCheckSql.CheckFieldForeignKey(strTeachingTimeDistributionDetailMainTypeId, 4, conTeachingTimeDistribution.TeachingTimeDistributionDetailMainTypeId);
objTeachingTimeDistributionEN.TeachingTimeDistributionDetailMainTypeId = strTeachingTimeDistributionDetailMainTypeId; //教学时间分布主类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingTimeDistributionEN.dicFldComparisonOp.ContainsKey(conTeachingTimeDistribution.TeachingTimeDistributionDetailMainTypeId) == false)
{
objTeachingTimeDistributionEN.dicFldComparisonOp.Add(conTeachingTimeDistribution.TeachingTimeDistributionDetailMainTypeId, strComparisonOp);
}
else
{
objTeachingTimeDistributionEN.dicFldComparisonOp[conTeachingTimeDistribution.TeachingTimeDistributionDetailMainTypeId] = strComparisonOp;
}
}
return objTeachingTimeDistributionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingTimeDistributionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingTimeDistributionEN SetTimeLengthPercent(this clsTeachingTimeDistributionEN objTeachingTimeDistributionEN, double dblTimeLengthPercent, string strComparisonOp="")
	{
objTeachingTimeDistributionEN.TimeLengthPercent = dblTimeLengthPercent; //时长和占总视频时长百分比
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingTimeDistributionEN.dicFldComparisonOp.ContainsKey(conTeachingTimeDistribution.TimeLengthPercent) == false)
{
objTeachingTimeDistributionEN.dicFldComparisonOp.Add(conTeachingTimeDistribution.TimeLengthPercent, strComparisonOp);
}
else
{
objTeachingTimeDistributionEN.dicFldComparisonOp[conTeachingTimeDistribution.TimeLengthPercent] = strComparisonOp;
}
}
return objTeachingTimeDistributionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingTimeDistributionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingTimeDistributionEN SetUseMedia(this clsTeachingTimeDistributionEN objTeachingTimeDistributionEN, string strUseMedia, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUseMedia, 30, conTeachingTimeDistribution.UseMedia);
objTeachingTimeDistributionEN.UseMedia = strUseMedia; //使用媒体
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingTimeDistributionEN.dicFldComparisonOp.ContainsKey(conTeachingTimeDistribution.UseMedia) == false)
{
objTeachingTimeDistributionEN.dicFldComparisonOp.Add(conTeachingTimeDistribution.UseMedia, strComparisonOp);
}
else
{
objTeachingTimeDistributionEN.dicFldComparisonOp[conTeachingTimeDistribution.UseMedia] = strComparisonOp;
}
}
return objTeachingTimeDistributionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingTimeDistributionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingTimeDistributionEN SetUpdDate(this clsTeachingTimeDistributionEN objTeachingTimeDistributionEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conTeachingTimeDistribution.UpdDate);
objTeachingTimeDistributionEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingTimeDistributionEN.dicFldComparisonOp.ContainsKey(conTeachingTimeDistribution.UpdDate) == false)
{
objTeachingTimeDistributionEN.dicFldComparisonOp.Add(conTeachingTimeDistribution.UpdDate, strComparisonOp);
}
else
{
objTeachingTimeDistributionEN.dicFldComparisonOp[conTeachingTimeDistribution.UpdDate] = strComparisonOp;
}
}
return objTeachingTimeDistributionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingTimeDistributionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingTimeDistributionEN SetUpdUserId(this clsTeachingTimeDistributionEN objTeachingTimeDistributionEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conTeachingTimeDistribution.UpdUserId);
objTeachingTimeDistributionEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingTimeDistributionEN.dicFldComparisonOp.ContainsKey(conTeachingTimeDistribution.UpdUserId) == false)
{
objTeachingTimeDistributionEN.dicFldComparisonOp.Add(conTeachingTimeDistribution.UpdUserId, strComparisonOp);
}
else
{
objTeachingTimeDistributionEN.dicFldComparisonOp[conTeachingTimeDistribution.UpdUserId] = strComparisonOp;
}
}
return objTeachingTimeDistributionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingTimeDistributionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingTimeDistributionEN SetMemo(this clsTeachingTimeDistributionEN objTeachingTimeDistributionEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conTeachingTimeDistribution.Memo);
objTeachingTimeDistributionEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingTimeDistributionEN.dicFldComparisonOp.ContainsKey(conTeachingTimeDistribution.Memo) == false)
{
objTeachingTimeDistributionEN.dicFldComparisonOp.Add(conTeachingTimeDistribution.Memo, strComparisonOp);
}
else
{
objTeachingTimeDistributionEN.dicFldComparisonOp[conTeachingTimeDistribution.Memo] = strComparisonOp;
}
}
return objTeachingTimeDistributionEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsTeachingTimeDistributionEN objTeachingTimeDistribution_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objTeachingTimeDistribution_Cond.IsUpdated(conTeachingTimeDistribution.mId) == true)
{
string strComparisonOp_mId = objTeachingTimeDistribution_Cond.dicFldComparisonOp[conTeachingTimeDistribution.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conTeachingTimeDistribution.mId, objTeachingTimeDistribution_Cond.mId, strComparisonOp_mId);
}
if (objTeachingTimeDistribution_Cond.IsUpdated(conTeachingTimeDistribution.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objTeachingTimeDistribution_Cond.dicFldComparisonOp[conTeachingTimeDistribution.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingTimeDistribution.FuncModuleId, objTeachingTimeDistribution_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objTeachingTimeDistribution_Cond.IsUpdated(conTeachingTimeDistribution.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objTeachingTimeDistribution_Cond.dicFldComparisonOp[conTeachingTimeDistribution.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingTimeDistribution.id_MicroteachCase, objTeachingTimeDistribution_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objTeachingTimeDistribution_Cond.IsUpdated(conTeachingTimeDistribution.CaseName) == true)
{
string strComparisonOp_CaseName = objTeachingTimeDistribution_Cond.dicFldComparisonOp[conTeachingTimeDistribution.CaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingTimeDistribution.CaseName, objTeachingTimeDistribution_Cond.CaseName, strComparisonOp_CaseName);
}
if (objTeachingTimeDistribution_Cond.IsUpdated(conTeachingTimeDistribution.OwnerId) == true)
{
string strComparisonOp_OwnerId = objTeachingTimeDistribution_Cond.dicFldComparisonOp[conTeachingTimeDistribution.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingTimeDistribution.OwnerId, objTeachingTimeDistribution_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objTeachingTimeDistribution_Cond.IsUpdated(conTeachingTimeDistribution.TeachingActivityTypeId) == true)
{
string strComparisonOp_TeachingActivityTypeId = objTeachingTimeDistribution_Cond.dicFldComparisonOp[conTeachingTimeDistribution.TeachingActivityTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingTimeDistribution.TeachingActivityTypeId, objTeachingTimeDistribution_Cond.TeachingActivityTypeId, strComparisonOp_TeachingActivityTypeId);
}
if (objTeachingTimeDistribution_Cond.IsUpdated(conTeachingTimeDistribution.UseTime) == true)
{
string strComparisonOp_UseTime = objTeachingTimeDistribution_Cond.dicFldComparisonOp[conTeachingTimeDistribution.UseTime];
strWhereCond += string.Format(" And {0} {2} {1}", conTeachingTimeDistribution.UseTime, objTeachingTimeDistribution_Cond.UseTime, strComparisonOp_UseTime);
}
if (objTeachingTimeDistribution_Cond.IsUpdated(conTeachingTimeDistribution.TimePercent) == true)
{
string strComparisonOp_TimePercent = objTeachingTimeDistribution_Cond.dicFldComparisonOp[conTeachingTimeDistribution.TimePercent];
strWhereCond += string.Format(" And {0} {2} {1}", conTeachingTimeDistribution.TimePercent, objTeachingTimeDistribution_Cond.TimePercent, strComparisonOp_TimePercent);
}
if (objTeachingTimeDistribution_Cond.IsUpdated(conTeachingTimeDistribution.TimeLengthOfVideo) == true)
{
string strComparisonOp_TimeLengthOfVideo = objTeachingTimeDistribution_Cond.dicFldComparisonOp[conTeachingTimeDistribution.TimeLengthOfVideo];
strWhereCond += string.Format(" And {0} {2} {1}", conTeachingTimeDistribution.TimeLengthOfVideo, objTeachingTimeDistribution_Cond.TimeLengthOfVideo, strComparisonOp_TimeLengthOfVideo);
}
if (objTeachingTimeDistribution_Cond.IsUpdated(conTeachingTimeDistribution.TeachingTimeDistributionDetailMainTypeId) == true)
{
string strComparisonOp_TeachingTimeDistributionDetailMainTypeId = objTeachingTimeDistribution_Cond.dicFldComparisonOp[conTeachingTimeDistribution.TeachingTimeDistributionDetailMainTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingTimeDistribution.TeachingTimeDistributionDetailMainTypeId, objTeachingTimeDistribution_Cond.TeachingTimeDistributionDetailMainTypeId, strComparisonOp_TeachingTimeDistributionDetailMainTypeId);
}
if (objTeachingTimeDistribution_Cond.IsUpdated(conTeachingTimeDistribution.TimeLengthPercent) == true)
{
string strComparisonOp_TimeLengthPercent = objTeachingTimeDistribution_Cond.dicFldComparisonOp[conTeachingTimeDistribution.TimeLengthPercent];
strWhereCond += string.Format(" And {0} {2} {1}", conTeachingTimeDistribution.TimeLengthPercent, objTeachingTimeDistribution_Cond.TimeLengthPercent, strComparisonOp_TimeLengthPercent);
}
if (objTeachingTimeDistribution_Cond.IsUpdated(conTeachingTimeDistribution.UseMedia) == true)
{
string strComparisonOp_UseMedia = objTeachingTimeDistribution_Cond.dicFldComparisonOp[conTeachingTimeDistribution.UseMedia];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingTimeDistribution.UseMedia, objTeachingTimeDistribution_Cond.UseMedia, strComparisonOp_UseMedia);
}
if (objTeachingTimeDistribution_Cond.IsUpdated(conTeachingTimeDistribution.UpdDate) == true)
{
string strComparisonOp_UpdDate = objTeachingTimeDistribution_Cond.dicFldComparisonOp[conTeachingTimeDistribution.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingTimeDistribution.UpdDate, objTeachingTimeDistribution_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objTeachingTimeDistribution_Cond.IsUpdated(conTeachingTimeDistribution.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objTeachingTimeDistribution_Cond.dicFldComparisonOp[conTeachingTimeDistribution.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingTimeDistribution.UpdUserId, objTeachingTimeDistribution_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objTeachingTimeDistribution_Cond.IsUpdated(conTeachingTimeDistribution.Memo) == true)
{
string strComparisonOp_Memo = objTeachingTimeDistribution_Cond.dicFldComparisonOp[conTeachingTimeDistribution.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingTimeDistribution.Memo, objTeachingTimeDistribution_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objTeachingTimeDistributionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsTeachingTimeDistributionEN objTeachingTimeDistributionEN)
{
 if (objTeachingTimeDistributionEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objTeachingTimeDistributionEN.sf_UpdFldSetStr = objTeachingTimeDistributionEN.getsf_UpdFldSetStr();
clsTeachingTimeDistributionWApi.CheckPropertyNew(objTeachingTimeDistributionEN); 
bool bolResult = clsTeachingTimeDistributionWApi.UpdateRecord(objTeachingTimeDistributionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingTimeDistributionWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000004)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--TeachingTimeDistribution(教学时间分布), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objTeachingTimeDistributionEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_FuncModuleId_id_MicroteachCase_OwnerId(this clsTeachingTimeDistributionEN objTeachingTimeDistributionEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objTeachingTimeDistributionEN == null) return "";
if (objTeachingTimeDistributionEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FuncModuleId = '{0}'", objTeachingTimeDistributionEN.FuncModuleId);
 sbCondition.AppendFormat(" and id_MicroteachCase = '{0}'", objTeachingTimeDistributionEN.id_MicroteachCase);
 sbCondition.AppendFormat(" and OwnerId = '{0}'", objTeachingTimeDistributionEN.OwnerId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objTeachingTimeDistributionEN.mId);
 sbCondition.AppendFormat(" and FuncModuleId = '{0}'", objTeachingTimeDistributionEN.FuncModuleId);
 sbCondition.AppendFormat(" and id_MicroteachCase = '{0}'", objTeachingTimeDistributionEN.id_MicroteachCase);
 sbCondition.AppendFormat(" and OwnerId = '{0}'", objTeachingTimeDistributionEN.OwnerId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objTeachingTimeDistributionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsTeachingTimeDistributionEN objTeachingTimeDistributionEN)
{
try
{
clsTeachingTimeDistributionWApi.CheckPropertyNew(objTeachingTimeDistributionEN); 
bool bolResult = clsTeachingTimeDistributionWApi.AddNewRecord(objTeachingTimeDistributionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingTimeDistributionWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000008)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objTeachingTimeDistributionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsTeachingTimeDistributionEN objTeachingTimeDistributionEN, string strWhereCond)
{
try
{
clsTeachingTimeDistributionWApi.CheckPropertyNew(objTeachingTimeDistributionEN); 
bool bolResult = clsTeachingTimeDistributionWApi.UpdateWithCondition(objTeachingTimeDistributionEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingTimeDistributionWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000007)根据条件修改记录出错, {1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// 教学时间分布(TeachingTimeDistribution)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsTeachingTimeDistributionWApi
{
private static readonly string mstrApiControllerName = "TeachingTimeDistributionApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsTeachingTimeDistributionWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsTeachingTimeDistributionEN objTeachingTimeDistributionEN)
{
if (!Object.Equals(null, objTeachingTimeDistributionEN.FuncModuleId) && GetStrLen(objTeachingTimeDistributionEN.FuncModuleId) > 4)
{
 throw new Exception("字段[功能模块Id]的长度不能超过4!");
}
if (!Object.Equals(null, objTeachingTimeDistributionEN.id_MicroteachCase) && GetStrLen(objTeachingTimeDistributionEN.id_MicroteachCase) > 8)
{
 throw new Exception("字段[微格教学案例流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objTeachingTimeDistributionEN.CaseName) && GetStrLen(objTeachingTimeDistributionEN.CaseName) > 100)
{
 throw new Exception("字段[案例名称]的长度不能超过100!");
}
if (!Object.Equals(null, objTeachingTimeDistributionEN.OwnerId) && GetStrLen(objTeachingTimeDistributionEN.OwnerId) > 20)
{
 throw new Exception("字段[拥有者Id]的长度不能超过20!");
}
if (!Object.Equals(null, objTeachingTimeDistributionEN.TeachingActivityTypeId) && GetStrLen(objTeachingTimeDistributionEN.TeachingActivityTypeId) > 2)
{
 throw new Exception("字段[教学活动类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objTeachingTimeDistributionEN.TeachingTimeDistributionDetailMainTypeId) && GetStrLen(objTeachingTimeDistributionEN.TeachingTimeDistributionDetailMainTypeId) > 4)
{
 throw new Exception("字段[教学时间分布主类型Id]的长度不能超过4!");
}
if (!Object.Equals(null, objTeachingTimeDistributionEN.UseMedia) && GetStrLen(objTeachingTimeDistributionEN.UseMedia) > 30)
{
 throw new Exception("字段[使用媒体]的长度不能超过30!");
}
if (!Object.Equals(null, objTeachingTimeDistributionEN.UpdDate) && GetStrLen(objTeachingTimeDistributionEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objTeachingTimeDistributionEN.UpdUserId) && GetStrLen(objTeachingTimeDistributionEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objTeachingTimeDistributionEN.Memo) && GetStrLen(objTeachingTimeDistributionEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objTeachingTimeDistributionEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsTeachingTimeDistributionEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clsTeachingTimeDistributionEN objTeachingTimeDistributionEN = null;
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
objTeachingTimeDistributionEN = JsonConvert.DeserializeObject<clsTeachingTimeDistributionEN>((string)jobjReturn["ReturnObj"]);
return objTeachingTimeDistributionEN;
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
public static clsTeachingTimeDistributionEN GetObjBymId_WA_Cache(long lngmId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsTeachingTimeDistributionEN objTeachingTimeDistributionEN = null;
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
objTeachingTimeDistributionEN = JsonConvert.DeserializeObject<clsTeachingTimeDistributionEN>((string)jobjReturn["ReturnObj"]);
return objTeachingTimeDistributionEN;
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
public static clsTeachingTimeDistributionEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsTeachingTimeDistributionEN objTeachingTimeDistributionEN = null;
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
objTeachingTimeDistributionEN = JsonConvert.DeserializeObject<clsTeachingTimeDistributionEN>((string)jobjReturn["ReturnObj"]);
return objTeachingTimeDistributionEN;
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
public static clsTeachingTimeDistributionEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsTeachingTimeDistributionEN._CurrTabName_S);
List<clsTeachingTimeDistributionEN> arrTeachingTimeDistributionObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsTeachingTimeDistributionEN> arrTeachingTimeDistributionObjLst_Sel =
from objTeachingTimeDistributionEN in arrTeachingTimeDistributionObjLst_Cache
where objTeachingTimeDistributionEN.mId == lngmId
select objTeachingTimeDistributionEN;
if (arrTeachingTimeDistributionObjLst_Sel.Count() == 0)
{
   clsTeachingTimeDistributionEN obj = clsTeachingTimeDistributionWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrTeachingTimeDistributionObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsTeachingTimeDistributionEN> GetObjLst(string strWhereCond)
{
 List<clsTeachingTimeDistributionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTeachingTimeDistributionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsTeachingTimeDistributionEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsTeachingTimeDistributionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTeachingTimeDistributionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsTeachingTimeDistributionEN> GetObjLstByMIdLst_Cache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsTeachingTimeDistributionEN._CurrTabName_S);
List<clsTeachingTimeDistributionEN> arrTeachingTimeDistributionObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsTeachingTimeDistributionEN> arrTeachingTimeDistributionObjLst_Sel =
from objTeachingTimeDistributionEN in arrTeachingTimeDistributionObjLst_Cache
where arrMId.Contains(objTeachingTimeDistributionEN.mId)
select objTeachingTimeDistributionEN;
return arrTeachingTimeDistributionObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsTeachingTimeDistributionEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId)
{
 List<clsTeachingTimeDistributionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTeachingTimeDistributionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsTeachingTimeDistributionEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsTeachingTimeDistributionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTeachingTimeDistributionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsTeachingTimeDistributionEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsTeachingTimeDistributionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTeachingTimeDistributionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsTeachingTimeDistributionEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsTeachingTimeDistributionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTeachingTimeDistributionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsTeachingTimeDistributionEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsTeachingTimeDistributionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTeachingTimeDistributionEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// 根据关键字删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecord(long lngmId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsTeachingTimeDistributionEN objTeachingTimeDistributionEN = clsTeachingTimeDistributionWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsTeachingTimeDistributionWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecords)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecords(string strKeyIdLst)
{
string strAction = "DelRecords";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out strResult, out strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelTeachingTimeDistributions(List<string> arrmId)
{
string strAction = "DelTeachingTimeDistributions";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrmId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsTeachingTimeDistributionWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelTeachingTimeDistributionsByCond(string strWhereCond)
{
string strAction = "DelTeachingTimeDistributionsByCond";
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool AddNewRecord(clsTeachingTimeDistributionEN objTeachingTimeDistributionEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTeachingTimeDistributionEN>(objTeachingTimeDistributionEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingTimeDistributionWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objTeachingTimeDistributionEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsTeachingTimeDistributionEN objTeachingTimeDistributionEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTeachingTimeDistributionEN>(objTeachingTimeDistributionEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingTimeDistributionWApi.ReFreshCache();
var strReturnStr = (string)jobjReturn["ReturnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsTeachingTimeDistributionEN objTeachingTimeDistributionEN)
{
if (string.IsNullOrEmpty(objTeachingTimeDistributionEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objTeachingTimeDistributionEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTeachingTimeDistributionEN>(objTeachingTimeDistributionEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateWithCondition)
 /// </summary>
 /// <param name = "objTeachingTimeDistributionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsTeachingTimeDistributionEN objTeachingTimeDistributionEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objTeachingTimeDistributionEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objTeachingTimeDistributionEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objTeachingTimeDistributionEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTeachingTimeDistributionEN>(objTeachingTimeDistributionEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
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
 /// 根据条件设置字段值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_funSetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int SetFldValue(string strFldName, string strValue, string strWhereCond)
{
string strAction = "SetFldValue";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strValue"] = strValue,
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
string strMsg = string.Format("根据条件设置字段值,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
 /// (AutoGCLib.clsGeneCodeBase:GengetStrLen)
 /// </summary>
 /// <param name = "strTemp">给定的原字符串</param>
 /// <returns>返回字符串长度</returns>
public static int GetStrLen(string strTemp)
{
int len ;
byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
len = sarr.Length;//will output as 3+3*2 = 9
return len;
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objTeachingTimeDistributionENS">源对象</param>
 /// <param name = "objTeachingTimeDistributionENT">目标对象</param>
 public static void CopyTo(clsTeachingTimeDistributionEN objTeachingTimeDistributionENS, clsTeachingTimeDistributionEN objTeachingTimeDistributionENT)
{
try
{
objTeachingTimeDistributionENT.mId = objTeachingTimeDistributionENS.mId; //mId
objTeachingTimeDistributionENT.FuncModuleId = objTeachingTimeDistributionENS.FuncModuleId; //功能模块Id
objTeachingTimeDistributionENT.id_MicroteachCase = objTeachingTimeDistributionENS.id_MicroteachCase; //微格教学案例流水号
objTeachingTimeDistributionENT.CaseName = objTeachingTimeDistributionENS.CaseName; //案例名称
objTeachingTimeDistributionENT.OwnerId = objTeachingTimeDistributionENS.OwnerId; //拥有者Id
objTeachingTimeDistributionENT.TeachingActivityTypeId = objTeachingTimeDistributionENS.TeachingActivityTypeId; //教学活动类型Id
objTeachingTimeDistributionENT.UseTime = objTeachingTimeDistributionENS.UseTime; //使用时间s
objTeachingTimeDistributionENT.TimePercent = objTeachingTimeDistributionENS.TimePercent; //时间比例
objTeachingTimeDistributionENT.TimeLengthOfVideo = objTeachingTimeDistributionENS.TimeLengthOfVideo; //视频时长
objTeachingTimeDistributionENT.TeachingTimeDistributionDetailMainTypeId = objTeachingTimeDistributionENS.TeachingTimeDistributionDetailMainTypeId; //教学时间分布主类型Id
objTeachingTimeDistributionENT.TimeLengthPercent = objTeachingTimeDistributionENS.TimeLengthPercent; //时长和占总视频时长百分比
objTeachingTimeDistributionENT.UseMedia = objTeachingTimeDistributionENS.UseMedia; //使用媒体
objTeachingTimeDistributionENT.UpdDate = objTeachingTimeDistributionENS.UpdDate; //修改日期
objTeachingTimeDistributionENT.UpdUserId = objTeachingTimeDistributionENS.UpdUserId; //修改用户Id
objTeachingTimeDistributionENT.Memo = objTeachingTimeDistributionENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsTeachingTimeDistributionEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsTeachingTimeDistributionEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsTeachingTimeDistributionEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsTeachingTimeDistributionEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsTeachingTimeDistributionEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsTeachingTimeDistributionEN.AttributeName)
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
if (clsTeachingTimeDistributionWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachingTimeDistributionWApi没有刷新缓存机制(clsTeachingTimeDistributionWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrTeachingTimeDistributionObjLst_Cache == null)
//{
//arrTeachingTimeDistributionObjLst_Cache = await clsTeachingTimeDistributionWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsTeachingTimeDistributionEN._CurrTabName_S);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsTeachingTimeDistributionWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsTeachingTimeDistributionEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsTeachingTimeDistributionWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsTeachingTimeDistributionEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsTeachingTimeDistributionEN._CurrTabName_S);
List<clsTeachingTimeDistributionEN> arrTeachingTimeDistributionObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrTeachingTimeDistributionObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsTeachingTimeDistributionEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conTeachingTimeDistribution.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(conTeachingTimeDistribution.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingTimeDistribution.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingTimeDistribution.CaseName, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingTimeDistribution.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingTimeDistribution.TeachingActivityTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingTimeDistribution.UseTime, Type.GetType("System.Decimal"));
objDT.Columns.Add(conTeachingTimeDistribution.TimePercent, Type.GetType("System.Decimal"));
objDT.Columns.Add(conTeachingTimeDistribution.TimeLengthOfVideo, Type.GetType("System.Decimal"));
objDT.Columns.Add(conTeachingTimeDistribution.TeachingTimeDistributionDetailMainTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingTimeDistribution.TimeLengthPercent, Type.GetType("System.Decimal"));
objDT.Columns.Add(conTeachingTimeDistribution.UseMedia, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingTimeDistribution.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingTimeDistribution.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingTimeDistribution.Memo, Type.GetType("System.String"));
foreach (clsTeachingTimeDistributionEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conTeachingTimeDistribution.mId] = objInFor[conTeachingTimeDistribution.mId];
objDR[conTeachingTimeDistribution.FuncModuleId] = objInFor[conTeachingTimeDistribution.FuncModuleId];
objDR[conTeachingTimeDistribution.id_MicroteachCase] = objInFor[conTeachingTimeDistribution.id_MicroteachCase];
objDR[conTeachingTimeDistribution.CaseName] = objInFor[conTeachingTimeDistribution.CaseName];
objDR[conTeachingTimeDistribution.OwnerId] = objInFor[conTeachingTimeDistribution.OwnerId];
objDR[conTeachingTimeDistribution.TeachingActivityTypeId] = objInFor[conTeachingTimeDistribution.TeachingActivityTypeId];
objDR[conTeachingTimeDistribution.UseTime] = objInFor[conTeachingTimeDistribution.UseTime];
objDR[conTeachingTimeDistribution.TimePercent] = objInFor[conTeachingTimeDistribution.TimePercent];
objDR[conTeachingTimeDistribution.TimeLengthOfVideo] = objInFor[conTeachingTimeDistribution.TimeLengthOfVideo];
objDR[conTeachingTimeDistribution.TeachingTimeDistributionDetailMainTypeId] = objInFor[conTeachingTimeDistribution.TeachingTimeDistributionDetailMainTypeId];
objDR[conTeachingTimeDistribution.TimeLengthPercent] = objInFor[conTeachingTimeDistribution.TimeLengthPercent];
objDR[conTeachingTimeDistribution.UseMedia] = objInFor[conTeachingTimeDistribution.UseMedia];
objDR[conTeachingTimeDistribution.UpdDate] = objInFor[conTeachingTimeDistribution.UpdDate];
objDR[conTeachingTimeDistribution.UpdUserId] = objInFor[conTeachingTimeDistribution.UpdUserId];
objDR[conTeachingTimeDistribution.Memo] = objInFor[conTeachingTimeDistribution.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 教学时间分布(TeachingTimeDistribution)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4TeachingTimeDistribution : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache()
{
string strMsg = "";
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
clsTeachingTimeDistributionWApi.ReFreshThisCache();
}
}

}