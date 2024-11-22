
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvVideoLibAppraiseWApi
 表名:vVideoLibAppraise(01120266)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:42:31
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:视频库
 模块英文名:VideoLib
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
public static class clsvVideoLibAppraiseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibAppraiseEN Setid_MicroteachAppraise(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, long lngid_MicroteachAppraise, string strComparisonOp="")
	{
objvVideoLibAppraiseEN.id_MicroteachAppraise = lngid_MicroteachAppraise; //评议流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.id_MicroteachAppraise) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.id_MicroteachAppraise, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.id_MicroteachAppraise] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetFuncModuleId(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convVideoLibAppraise.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convVideoLibAppraise.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convVideoLibAppraise.FuncModuleId);
objvVideoLibAppraiseEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.FuncModuleId) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.FuncModuleId, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.FuncModuleId] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetFuncModuleName(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convVideoLibAppraise.FuncModuleName);
objvVideoLibAppraiseEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.FuncModuleName) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.FuncModuleName, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.FuncModuleName] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibAppraiseEN Setid_MicroteachCase(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroteachCase, convVideoLibAppraise.id_MicroteachCase);
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convVideoLibAppraise.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convVideoLibAppraise.id_MicroteachCase);
objvVideoLibAppraiseEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.id_MicroteachCase) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.id_MicroteachCase, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.id_MicroteachCase] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetId_VideoLib(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strId_VideoLib, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_VideoLib, 8, convVideoLibAppraise.Id_VideoLib);
clsCheckSql.CheckFieldForeignKey(strId_VideoLib, 8, convVideoLibAppraise.Id_VideoLib);
objvVideoLibAppraiseEN.Id_VideoLib = strId_VideoLib; //视频库流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.Id_VideoLib) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.Id_VideoLib, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.Id_VideoLib] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetVideoLibID(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strVideoLibID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoLibID, 8, convVideoLibAppraise.VideoLibID);
clsCheckSql.CheckFieldForeignKey(strVideoLibID, 8, convVideoLibAppraise.VideoLibID);
objvVideoLibAppraiseEN.VideoLibID = strVideoLibID; //视频库ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.VideoLibID) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.VideoLibID, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.VideoLibID] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetVideoLibName(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strVideoLibName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoLibName, 100, convVideoLibAppraise.VideoLibName);
objvVideoLibAppraiseEN.VideoLibName = strVideoLibName; //视频名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.VideoLibName) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.VideoLibName, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.VideoLibName] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetVideoLibTheme(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strVideoLibTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoLibTheme, 200, convVideoLibAppraise.VideoLibTheme);
objvVideoLibAppraiseEN.VideoLibTheme = strVideoLibTheme; //视频库主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.VideoLibTheme) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.VideoLibTheme, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.VideoLibTheme] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetVideoLibTypeName(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strVideoLibTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoLibTypeName, 30, convVideoLibAppraise.VideoLibTypeName);
objvVideoLibAppraiseEN.VideoLibTypeName = strVideoLibTypeName; //视频库类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.VideoLibTypeName) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.VideoLibTypeName, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.VideoLibTypeName] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetVideoLibDate(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strVideoLibDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoLibDate, 20, convVideoLibAppraise.VideoLibDate);
objvVideoLibAppraiseEN.VideoLibDate = strVideoLibDate; //视频资源日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.VideoLibDate) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.VideoLibDate, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.VideoLibDate] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetVideoLibTime(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strVideoLibTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoLibTime, 6, convVideoLibAppraise.VideoLibTime);
clsCheckSql.CheckFieldForeignKey(strVideoLibTime, 6, convVideoLibAppraise.VideoLibTime);
objvVideoLibAppraiseEN.VideoLibTime = strVideoLibTime; //视频资源时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.VideoLibTime) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.VideoLibTime, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.VideoLibTime] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetVideoLibDateIn(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strVideoLibDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoLibDateIn, 8, convVideoLibAppraise.VideoLibDateIn);
clsCheckSql.CheckFieldForeignKey(strVideoLibDateIn, 8, convVideoLibAppraise.VideoLibDateIn);
objvVideoLibAppraiseEN.VideoLibDateIn = strVideoLibDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.VideoLibDateIn) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.VideoLibDateIn, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.VideoLibDateIn] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetVideoLibTimeIn(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strVideoLibTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoLibTimeIn, 6, convVideoLibAppraise.VideoLibTimeIn);
clsCheckSql.CheckFieldForeignKey(strVideoLibTimeIn, 6, convVideoLibAppraise.VideoLibTimeIn);
objvVideoLibAppraiseEN.VideoLibTimeIn = strVideoLibTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.VideoLibTimeIn) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.VideoLibTimeIn, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.VideoLibTimeIn] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibAppraiseEN Setid_XzCollege(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convVideoLibAppraise.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convVideoLibAppraise.id_XzCollege);
objvVideoLibAppraiseEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.id_XzCollege) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.id_XzCollege, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.id_XzCollege] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetCollegeID(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convVideoLibAppraise.CollegeID);
objvVideoLibAppraiseEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.CollegeID) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.CollegeID, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.CollegeID] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetCollegeName(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convVideoLibAppraise.CollegeName);
objvVideoLibAppraiseEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.CollegeName) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.CollegeName, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.CollegeName] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetCourseId(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convVideoLibAppraise.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convVideoLibAppraise.CourseId);
objvVideoLibAppraiseEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.CourseId) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.CourseId, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.CourseId] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetCourseCode(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strCourseCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convVideoLibAppraise.CourseCode);
objvVideoLibAppraiseEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.CourseCode) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.CourseCode, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.CourseCode] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetCourseName(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convVideoLibAppraise.CourseName);
objvVideoLibAppraiseEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.CourseName) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.CourseName, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.CourseName] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetBrowseCount4Case(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, int intBrowseCount4Case, string strComparisonOp="")
	{
objvVideoLibAppraiseEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.BrowseCount4Case) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.BrowseCount4Case, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.BrowseCount4Case] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibAppraiseEN Setid_AppraiseType(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strid_AppraiseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_AppraiseType, convVideoLibAppraise.id_AppraiseType);
clsCheckSql.CheckFieldLen(strid_AppraiseType, 4, convVideoLibAppraise.id_AppraiseType);
clsCheckSql.CheckFieldForeignKey(strid_AppraiseType, 4, convVideoLibAppraise.id_AppraiseType);
objvVideoLibAppraiseEN.id_AppraiseType = strid_AppraiseType; //评议类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.id_AppraiseType) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.id_AppraiseType, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.id_AppraiseType] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetAppraiseTypeName(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strAppraiseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAppraiseTypeName, 50, convVideoLibAppraise.AppraiseTypeName);
objvVideoLibAppraiseEN.AppraiseTypeName = strAppraiseTypeName; //评议类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.AppraiseTypeName) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.AppraiseTypeName, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.AppraiseTypeName] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetAppraiseTheme(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strAppraiseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAppraiseTheme, 200, convVideoLibAppraise.AppraiseTheme);
objvVideoLibAppraiseEN.AppraiseTheme = strAppraiseTheme; //评议主题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.AppraiseTheme) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.AppraiseTheme, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.AppraiseTheme] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetAppraiseContent(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strAppraiseContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAppraiseContent, 2000, convVideoLibAppraise.AppraiseContent);
objvVideoLibAppraiseEN.AppraiseContent = strAppraiseContent; //评议内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.AppraiseContent) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.AppraiseContent, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.AppraiseContent] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetAppraiseDate(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strAppraiseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAppraiseDate, 8, convVideoLibAppraise.AppraiseDate);
clsCheckSql.CheckFieldForeignKey(strAppraiseDate, 8, convVideoLibAppraise.AppraiseDate);
objvVideoLibAppraiseEN.AppraiseDate = strAppraiseDate; //评议日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.AppraiseDate) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.AppraiseDate, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.AppraiseDate] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetAppraiseTime(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strAppraiseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAppraiseTime, 6, convVideoLibAppraise.AppraiseTime);
clsCheckSql.CheckFieldForeignKey(strAppraiseTime, 6, convVideoLibAppraise.AppraiseTime);
objvVideoLibAppraiseEN.AppraiseTime = strAppraiseTime; //评议时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.AppraiseTime) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.AppraiseTime, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.AppraiseTime] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetIsVisual(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, bool bolIsVisual, string strComparisonOp="")
	{
objvVideoLibAppraiseEN.IsVisual = bolIsVisual; //隐藏标志
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.IsVisual) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.IsVisual, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.IsVisual] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetIsElite(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, bool bolIsElite, string strComparisonOp="")
	{
objvVideoLibAppraiseEN.IsElite = bolIsElite; //精华标志
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.IsElite) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.IsElite, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.IsElite] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetExcellentOne(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strExcellentOne, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExcellentOne, 1000, convVideoLibAppraise.ExcellentOne);
objvVideoLibAppraiseEN.ExcellentOne = strExcellentOne; //优点1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.ExcellentOne) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.ExcellentOne, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.ExcellentOne] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetExcellentTwo(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strExcellentTwo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExcellentTwo, 1000, convVideoLibAppraise.ExcellentTwo);
objvVideoLibAppraiseEN.ExcellentTwo = strExcellentTwo; //优点2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.ExcellentTwo) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.ExcellentTwo, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.ExcellentTwo] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetSuggestOne(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strSuggestOne, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSuggestOne, 1000, convVideoLibAppraise.SuggestOne);
objvVideoLibAppraiseEN.SuggestOne = strSuggestOne; //建议1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.SuggestOne) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.SuggestOne, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.SuggestOne] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetSuggestTwo(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strSuggestTwo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSuggestTwo, 1000, convVideoLibAppraise.SuggestTwo);
objvVideoLibAppraiseEN.SuggestTwo = strSuggestTwo; //建议2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.SuggestTwo) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.SuggestTwo, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.SuggestTwo] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetMicroteachAppriseScore(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, float fltMicroteachAppriseScore, string strComparisonOp="")
	{
objvVideoLibAppraiseEN.MicroteachAppriseScore = fltMicroteachAppriseScore; //打分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.MicroteachAppriseScore) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.MicroteachAppriseScore, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.MicroteachAppriseScore] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetVideoStopTime(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strVideoStopTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoStopTime, 48, convVideoLibAppraise.VideoStopTime);
objvVideoLibAppraiseEN.VideoStopTime = strVideoStopTime; //公开课案例视频暂停时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.VideoStopTime) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.VideoStopTime, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.VideoStopTime] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetBrowseCount(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, int intBrowseCount, string strComparisonOp="")
	{
objvVideoLibAppraiseEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.BrowseCount) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.BrowseCount, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.BrowseCount] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetUserId(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convVideoLibAppraise.UserId);
clsCheckSql.CheckFieldLen(strUserId, 20, convVideoLibAppraise.UserId);
objvVideoLibAppraiseEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.UserId) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.UserId, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.UserId] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetUserName(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserName, 50, convVideoLibAppraise.UserName);
objvVideoLibAppraiseEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.UserName) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.UserName, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.UserName] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibAppraiseEN SetUserNameWithUserId(this clsvVideoLibAppraiseEN objvVideoLibAppraiseEN, string strUserNameWithUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserNameWithUserId, 51, convVideoLibAppraise.UserNameWithUserId);
objvVideoLibAppraiseEN.UserNameWithUserId = strUserNameWithUserId; //UserNameWithUserId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibAppraiseEN.dicFldComparisonOp.ContainsKey(convVideoLibAppraise.UserNameWithUserId) == false)
{
objvVideoLibAppraiseEN.dicFldComparisonOp.Add(convVideoLibAppraise.UserNameWithUserId, strComparisonOp);
}
else
{
objvVideoLibAppraiseEN.dicFldComparisonOp[convVideoLibAppraise.UserNameWithUserId] = strComparisonOp;
}
}
return objvVideoLibAppraiseEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvVideoLibAppraiseEN objvVideoLibAppraise_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvVideoLibAppraise_Cond.IsUpdated(convVideoLibAppraise.id_MicroteachAppraise) == true)
{
string strComparisonOp_id_MicroteachAppraise = objvVideoLibAppraise_Cond.dicFldComparisonOp[convVideoLibAppraise.id_MicroteachAppraise];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLibAppraise.id_MicroteachAppraise, objvVideoLibAppraise_Cond.id_MicroteachAppraise, strComparisonOp_id_MicroteachAppraise);
}
if (objvVideoLibAppraise_Cond.IsUpdated(convVideoLibAppraise.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvVideoLibAppraise_Cond.dicFldComparisonOp[convVideoLibAppraise.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.FuncModuleId, objvVideoLibAppraise_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvVideoLibAppraise_Cond.IsUpdated(convVideoLibAppraise.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvVideoLibAppraise_Cond.dicFldComparisonOp[convVideoLibAppraise.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.FuncModuleName, objvVideoLibAppraise_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvVideoLibAppraise_Cond.IsUpdated(convVideoLibAppraise.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvVideoLibAppraise_Cond.dicFldComparisonOp[convVideoLibAppraise.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.id_MicroteachCase, objvVideoLibAppraise_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvVideoLibAppraise_Cond.IsUpdated(convVideoLibAppraise.Id_VideoLib) == true)
{
string strComparisonOp_Id_VideoLib = objvVideoLibAppraise_Cond.dicFldComparisonOp[convVideoLibAppraise.Id_VideoLib];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.Id_VideoLib, objvVideoLibAppraise_Cond.Id_VideoLib, strComparisonOp_Id_VideoLib);
}
if (objvVideoLibAppraise_Cond.IsUpdated(convVideoLibAppraise.VideoLibID) == true)
{
string strComparisonOp_VideoLibID = objvVideoLibAppraise_Cond.dicFldComparisonOp[convVideoLibAppraise.VideoLibID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.VideoLibID, objvVideoLibAppraise_Cond.VideoLibID, strComparisonOp_VideoLibID);
}
if (objvVideoLibAppraise_Cond.IsUpdated(convVideoLibAppraise.VideoLibName) == true)
{
string strComparisonOp_VideoLibName = objvVideoLibAppraise_Cond.dicFldComparisonOp[convVideoLibAppraise.VideoLibName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.VideoLibName, objvVideoLibAppraise_Cond.VideoLibName, strComparisonOp_VideoLibName);
}
if (objvVideoLibAppraise_Cond.IsUpdated(convVideoLibAppraise.VideoLibTheme) == true)
{
string strComparisonOp_VideoLibTheme = objvVideoLibAppraise_Cond.dicFldComparisonOp[convVideoLibAppraise.VideoLibTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.VideoLibTheme, objvVideoLibAppraise_Cond.VideoLibTheme, strComparisonOp_VideoLibTheme);
}
if (objvVideoLibAppraise_Cond.IsUpdated(convVideoLibAppraise.VideoLibTypeName) == true)
{
string strComparisonOp_VideoLibTypeName = objvVideoLibAppraise_Cond.dicFldComparisonOp[convVideoLibAppraise.VideoLibTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.VideoLibTypeName, objvVideoLibAppraise_Cond.VideoLibTypeName, strComparisonOp_VideoLibTypeName);
}
if (objvVideoLibAppraise_Cond.IsUpdated(convVideoLibAppraise.VideoLibDate) == true)
{
string strComparisonOp_VideoLibDate = objvVideoLibAppraise_Cond.dicFldComparisonOp[convVideoLibAppraise.VideoLibDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.VideoLibDate, objvVideoLibAppraise_Cond.VideoLibDate, strComparisonOp_VideoLibDate);
}
if (objvVideoLibAppraise_Cond.IsUpdated(convVideoLibAppraise.VideoLibTime) == true)
{
string strComparisonOp_VideoLibTime = objvVideoLibAppraise_Cond.dicFldComparisonOp[convVideoLibAppraise.VideoLibTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.VideoLibTime, objvVideoLibAppraise_Cond.VideoLibTime, strComparisonOp_VideoLibTime);
}
if (objvVideoLibAppraise_Cond.IsUpdated(convVideoLibAppraise.VideoLibDateIn) == true)
{
string strComparisonOp_VideoLibDateIn = objvVideoLibAppraise_Cond.dicFldComparisonOp[convVideoLibAppraise.VideoLibDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.VideoLibDateIn, objvVideoLibAppraise_Cond.VideoLibDateIn, strComparisonOp_VideoLibDateIn);
}
if (objvVideoLibAppraise_Cond.IsUpdated(convVideoLibAppraise.VideoLibTimeIn) == true)
{
string strComparisonOp_VideoLibTimeIn = objvVideoLibAppraise_Cond.dicFldComparisonOp[convVideoLibAppraise.VideoLibTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.VideoLibTimeIn, objvVideoLibAppraise_Cond.VideoLibTimeIn, strComparisonOp_VideoLibTimeIn);
}
if (objvVideoLibAppraise_Cond.IsUpdated(convVideoLibAppraise.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvVideoLibAppraise_Cond.dicFldComparisonOp[convVideoLibAppraise.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.id_XzCollege, objvVideoLibAppraise_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvVideoLibAppraise_Cond.IsUpdated(convVideoLibAppraise.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvVideoLibAppraise_Cond.dicFldComparisonOp[convVideoLibAppraise.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.CollegeID, objvVideoLibAppraise_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvVideoLibAppraise_Cond.IsUpdated(convVideoLibAppraise.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvVideoLibAppraise_Cond.dicFldComparisonOp[convVideoLibAppraise.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.CollegeName, objvVideoLibAppraise_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvVideoLibAppraise_Cond.IsUpdated(convVideoLibAppraise.CourseId) == true)
{
string strComparisonOp_CourseId = objvVideoLibAppraise_Cond.dicFldComparisonOp[convVideoLibAppraise.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.CourseId, objvVideoLibAppraise_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvVideoLibAppraise_Cond.IsUpdated(convVideoLibAppraise.CourseCode) == true)
{
string strComparisonOp_CourseCode = objvVideoLibAppraise_Cond.dicFldComparisonOp[convVideoLibAppraise.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.CourseCode, objvVideoLibAppraise_Cond.CourseCode, strComparisonOp_CourseCode);
}
if (objvVideoLibAppraise_Cond.IsUpdated(convVideoLibAppraise.CourseName) == true)
{
string strComparisonOp_CourseName = objvVideoLibAppraise_Cond.dicFldComparisonOp[convVideoLibAppraise.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.CourseName, objvVideoLibAppraise_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvVideoLibAppraise_Cond.IsUpdated(convVideoLibAppraise.BrowseCount4Case) == true)
{
string strComparisonOp_BrowseCount4Case = objvVideoLibAppraise_Cond.dicFldComparisonOp[convVideoLibAppraise.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLibAppraise.BrowseCount4Case, objvVideoLibAppraise_Cond.BrowseCount4Case, strComparisonOp_BrowseCount4Case);
}
if (objvVideoLibAppraise_Cond.IsUpdated(convVideoLibAppraise.id_AppraiseType) == true)
{
string strComparisonOp_id_AppraiseType = objvVideoLibAppraise_Cond.dicFldComparisonOp[convVideoLibAppraise.id_AppraiseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.id_AppraiseType, objvVideoLibAppraise_Cond.id_AppraiseType, strComparisonOp_id_AppraiseType);
}
if (objvVideoLibAppraise_Cond.IsUpdated(convVideoLibAppraise.AppraiseTypeName) == true)
{
string strComparisonOp_AppraiseTypeName = objvVideoLibAppraise_Cond.dicFldComparisonOp[convVideoLibAppraise.AppraiseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.AppraiseTypeName, objvVideoLibAppraise_Cond.AppraiseTypeName, strComparisonOp_AppraiseTypeName);
}
if (objvVideoLibAppraise_Cond.IsUpdated(convVideoLibAppraise.AppraiseTheme) == true)
{
string strComparisonOp_AppraiseTheme = objvVideoLibAppraise_Cond.dicFldComparisonOp[convVideoLibAppraise.AppraiseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.AppraiseTheme, objvVideoLibAppraise_Cond.AppraiseTheme, strComparisonOp_AppraiseTheme);
}
if (objvVideoLibAppraise_Cond.IsUpdated(convVideoLibAppraise.AppraiseContent) == true)
{
string strComparisonOp_AppraiseContent = objvVideoLibAppraise_Cond.dicFldComparisonOp[convVideoLibAppraise.AppraiseContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.AppraiseContent, objvVideoLibAppraise_Cond.AppraiseContent, strComparisonOp_AppraiseContent);
}
if (objvVideoLibAppraise_Cond.IsUpdated(convVideoLibAppraise.AppraiseDate) == true)
{
string strComparisonOp_AppraiseDate = objvVideoLibAppraise_Cond.dicFldComparisonOp[convVideoLibAppraise.AppraiseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.AppraiseDate, objvVideoLibAppraise_Cond.AppraiseDate, strComparisonOp_AppraiseDate);
}
if (objvVideoLibAppraise_Cond.IsUpdated(convVideoLibAppraise.AppraiseTime) == true)
{
string strComparisonOp_AppraiseTime = objvVideoLibAppraise_Cond.dicFldComparisonOp[convVideoLibAppraise.AppraiseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.AppraiseTime, objvVideoLibAppraise_Cond.AppraiseTime, strComparisonOp_AppraiseTime);
}
if (objvVideoLibAppraise_Cond.IsUpdated(convVideoLibAppraise.IsVisual) == true)
{
if (objvVideoLibAppraise_Cond.IsVisual == true)
{
strWhereCond += string.Format(" And {0} = '1'", convVideoLibAppraise.IsVisual);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convVideoLibAppraise.IsVisual);
}
}
if (objvVideoLibAppraise_Cond.IsUpdated(convVideoLibAppraise.IsElite) == true)
{
if (objvVideoLibAppraise_Cond.IsElite == true)
{
strWhereCond += string.Format(" And {0} = '1'", convVideoLibAppraise.IsElite);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convVideoLibAppraise.IsElite);
}
}
if (objvVideoLibAppraise_Cond.IsUpdated(convVideoLibAppraise.ExcellentOne) == true)
{
string strComparisonOp_ExcellentOne = objvVideoLibAppraise_Cond.dicFldComparisonOp[convVideoLibAppraise.ExcellentOne];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.ExcellentOne, objvVideoLibAppraise_Cond.ExcellentOne, strComparisonOp_ExcellentOne);
}
if (objvVideoLibAppraise_Cond.IsUpdated(convVideoLibAppraise.ExcellentTwo) == true)
{
string strComparisonOp_ExcellentTwo = objvVideoLibAppraise_Cond.dicFldComparisonOp[convVideoLibAppraise.ExcellentTwo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.ExcellentTwo, objvVideoLibAppraise_Cond.ExcellentTwo, strComparisonOp_ExcellentTwo);
}
if (objvVideoLibAppraise_Cond.IsUpdated(convVideoLibAppraise.SuggestOne) == true)
{
string strComparisonOp_SuggestOne = objvVideoLibAppraise_Cond.dicFldComparisonOp[convVideoLibAppraise.SuggestOne];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.SuggestOne, objvVideoLibAppraise_Cond.SuggestOne, strComparisonOp_SuggestOne);
}
if (objvVideoLibAppraise_Cond.IsUpdated(convVideoLibAppraise.SuggestTwo) == true)
{
string strComparisonOp_SuggestTwo = objvVideoLibAppraise_Cond.dicFldComparisonOp[convVideoLibAppraise.SuggestTwo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.SuggestTwo, objvVideoLibAppraise_Cond.SuggestTwo, strComparisonOp_SuggestTwo);
}
if (objvVideoLibAppraise_Cond.IsUpdated(convVideoLibAppraise.MicroteachAppriseScore) == true)
{
string strComparisonOp_MicroteachAppriseScore = objvVideoLibAppraise_Cond.dicFldComparisonOp[convVideoLibAppraise.MicroteachAppriseScore];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLibAppraise.MicroteachAppriseScore, objvVideoLibAppraise_Cond.MicroteachAppriseScore, strComparisonOp_MicroteachAppriseScore);
}
if (objvVideoLibAppraise_Cond.IsUpdated(convVideoLibAppraise.VideoStopTime) == true)
{
string strComparisonOp_VideoStopTime = objvVideoLibAppraise_Cond.dicFldComparisonOp[convVideoLibAppraise.VideoStopTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.VideoStopTime, objvVideoLibAppraise_Cond.VideoStopTime, strComparisonOp_VideoStopTime);
}
if (objvVideoLibAppraise_Cond.IsUpdated(convVideoLibAppraise.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvVideoLibAppraise_Cond.dicFldComparisonOp[convVideoLibAppraise.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLibAppraise.BrowseCount, objvVideoLibAppraise_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objvVideoLibAppraise_Cond.IsUpdated(convVideoLibAppraise.UserId) == true)
{
string strComparisonOp_UserId = objvVideoLibAppraise_Cond.dicFldComparisonOp[convVideoLibAppraise.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.UserId, objvVideoLibAppraise_Cond.UserId, strComparisonOp_UserId);
}
if (objvVideoLibAppraise_Cond.IsUpdated(convVideoLibAppraise.UserName) == true)
{
string strComparisonOp_UserName = objvVideoLibAppraise_Cond.dicFldComparisonOp[convVideoLibAppraise.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.UserName, objvVideoLibAppraise_Cond.UserName, strComparisonOp_UserName);
}
if (objvVideoLibAppraise_Cond.IsUpdated(convVideoLibAppraise.UserNameWithUserId) == true)
{
string strComparisonOp_UserNameWithUserId = objvVideoLibAppraise_Cond.dicFldComparisonOp[convVideoLibAppraise.UserNameWithUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibAppraise.UserNameWithUserId, objvVideoLibAppraise_Cond.UserNameWithUserId, strComparisonOp_UserNameWithUserId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v视频库定性评议(vVideoLibAppraise)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvVideoLibAppraiseWApi
{
private static readonly string mstrApiControllerName = "vVideoLibAppraiseApi";

 public clsvVideoLibAppraiseWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_MicroteachAppraise">表关键字</param>
 /// <returns>表对象</returns>
public static clsvVideoLibAppraiseEN GetObjByid_MicroteachAppraise(long lngid_MicroteachAppraise)
{
string strAction = "GetObjByid_MicroteachAppraise";
string strErrMsg = string.Empty;
string strResult = "";
clsvVideoLibAppraiseEN objvVideoLibAppraiseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MicroteachAppraise"] = lngid_MicroteachAppraise.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvVideoLibAppraiseEN = JsonConvert.DeserializeObject<clsvVideoLibAppraiseEN>((string)jobjReturn["ReturnObj"]);
return objvVideoLibAppraiseEN;
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
 /// <param name = "lngid_MicroteachAppraise">表关键字</param>
 /// <returns>表对象</returns>
public static clsvVideoLibAppraiseEN GetObjByid_MicroteachAppraise_WA_Cache(long lngid_MicroteachAppraise)
{
string strAction = "GetObjByid_MicroteachAppraise_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvVideoLibAppraiseEN objvVideoLibAppraiseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MicroteachAppraise"] = lngid_MicroteachAppraise.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvVideoLibAppraiseEN = JsonConvert.DeserializeObject<clsvVideoLibAppraiseEN>((string)jobjReturn["ReturnObj"]);
return objvVideoLibAppraiseEN;
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
public static clsvVideoLibAppraiseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvVideoLibAppraiseEN objvVideoLibAppraiseEN = null;
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
objvVideoLibAppraiseEN = JsonConvert.DeserializeObject<clsvVideoLibAppraiseEN>((string)jobjReturn["ReturnObj"]);
return objvVideoLibAppraiseEN;
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
 /// <param name = "lngid_MicroteachAppraise">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvVideoLibAppraiseEN GetObjByid_MicroteachAppraise_Cache(long lngid_MicroteachAppraise)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvVideoLibAppraiseEN._CurrTabName_S);
List<clsvVideoLibAppraiseEN> arrvVideoLibAppraiseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvVideoLibAppraiseEN> arrvVideoLibAppraiseObjLst_Sel =
from objvVideoLibAppraiseEN in arrvVideoLibAppraiseObjLst_Cache
where objvVideoLibAppraiseEN.id_MicroteachAppraise == lngid_MicroteachAppraise
select objvVideoLibAppraiseEN;
if (arrvVideoLibAppraiseObjLst_Sel.Count() == 0)
{
   clsvVideoLibAppraiseEN obj = clsvVideoLibAppraiseWApi.GetObjByid_MicroteachAppraise(lngid_MicroteachAppraise);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvVideoLibAppraiseObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoLibAppraiseEN> GetObjLst(string strWhereCond)
{
 List<clsvVideoLibAppraiseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLibAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoLibAppraiseEN> GetObjLstById_MicroteachAppraiseLst(List<long> arrId_MicroteachAppraise)
{
 List<clsvVideoLibAppraiseEN> arrObjLst = null; 
string strAction = "GetObjLstById_MicroteachAppraiseLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_MicroteachAppraise);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLibAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngid_MicroteachAppraise">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvVideoLibAppraiseEN> GetObjLstById_MicroteachAppraiseLst_Cache(List<long> arrId_MicroteachAppraise)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvVideoLibAppraiseEN._CurrTabName_S);
List<clsvVideoLibAppraiseEN> arrvVideoLibAppraiseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvVideoLibAppraiseEN> arrvVideoLibAppraiseObjLst_Sel =
from objvVideoLibAppraiseEN in arrvVideoLibAppraiseObjLst_Cache
where arrId_MicroteachAppraise.Contains(objvVideoLibAppraiseEN.id_MicroteachAppraise)
select objvVideoLibAppraiseEN;
return arrvVideoLibAppraiseObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoLibAppraiseEN> GetObjLstById_MicroteachAppraiseLst_WA_Cache(List<long> arrId_MicroteachAppraise)
{
 List<clsvVideoLibAppraiseEN> arrObjLst = null; 
string strAction = "GetObjLstById_MicroteachAppraiseLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_MicroteachAppraise);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLibAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoLibAppraiseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvVideoLibAppraiseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLibAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoLibAppraiseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvVideoLibAppraiseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLibAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoLibAppraiseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvVideoLibAppraiseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLibAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoLibAppraiseEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvVideoLibAppraiseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLibAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngid_MicroteachAppraise)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MicroteachAppraise"] = lngid_MicroteachAppraise.ToString()
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
 /// <param name = "objvVideoLibAppraiseENS">源对象</param>
 /// <param name = "objvVideoLibAppraiseENT">目标对象</param>
 public static void CopyTo(clsvVideoLibAppraiseEN objvVideoLibAppraiseENS, clsvVideoLibAppraiseEN objvVideoLibAppraiseENT)
{
try
{
objvVideoLibAppraiseENT.id_MicroteachAppraise = objvVideoLibAppraiseENS.id_MicroteachAppraise; //评议流水号
objvVideoLibAppraiseENT.FuncModuleId = objvVideoLibAppraiseENS.FuncModuleId; //功能模块Id
objvVideoLibAppraiseENT.FuncModuleName = objvVideoLibAppraiseENS.FuncModuleName; //功能模块名称
objvVideoLibAppraiseENT.id_MicroteachCase = objvVideoLibAppraiseENS.id_MicroteachCase; //微格教学案例流水号
objvVideoLibAppraiseENT.Id_VideoLib = objvVideoLibAppraiseENS.Id_VideoLib; //视频库流水号
objvVideoLibAppraiseENT.VideoLibID = objvVideoLibAppraiseENS.VideoLibID; //视频库ID
objvVideoLibAppraiseENT.VideoLibName = objvVideoLibAppraiseENS.VideoLibName; //视频名称
objvVideoLibAppraiseENT.VideoLibTheme = objvVideoLibAppraiseENS.VideoLibTheme; //视频库主题词
objvVideoLibAppraiseENT.VideoLibTypeName = objvVideoLibAppraiseENS.VideoLibTypeName; //视频库类型名称
objvVideoLibAppraiseENT.VideoLibDate = objvVideoLibAppraiseENS.VideoLibDate; //视频资源日期
objvVideoLibAppraiseENT.VideoLibTime = objvVideoLibAppraiseENS.VideoLibTime; //视频资源时间
objvVideoLibAppraiseENT.VideoLibDateIn = objvVideoLibAppraiseENS.VideoLibDateIn; //案例入库日期
objvVideoLibAppraiseENT.VideoLibTimeIn = objvVideoLibAppraiseENS.VideoLibTimeIn; //案例入库时间
objvVideoLibAppraiseENT.id_XzCollege = objvVideoLibAppraiseENS.id_XzCollege; //学院流水号
objvVideoLibAppraiseENT.CollegeID = objvVideoLibAppraiseENS.CollegeID; //学院ID
objvVideoLibAppraiseENT.CollegeName = objvVideoLibAppraiseENS.CollegeName; //学院名称
objvVideoLibAppraiseENT.CourseId = objvVideoLibAppraiseENS.CourseId; //课程Id
objvVideoLibAppraiseENT.CourseCode = objvVideoLibAppraiseENS.CourseCode; //课程代码
objvVideoLibAppraiseENT.CourseName = objvVideoLibAppraiseENS.CourseName; //课程名称
objvVideoLibAppraiseENT.BrowseCount4Case = objvVideoLibAppraiseENS.BrowseCount4Case; //课例浏览次数
objvVideoLibAppraiseENT.id_AppraiseType = objvVideoLibAppraiseENS.id_AppraiseType; //评议类型流水号
objvVideoLibAppraiseENT.AppraiseTypeName = objvVideoLibAppraiseENS.AppraiseTypeName; //评议类型名称
objvVideoLibAppraiseENT.AppraiseTheme = objvVideoLibAppraiseENS.AppraiseTheme; //评议主题
objvVideoLibAppraiseENT.AppraiseContent = objvVideoLibAppraiseENS.AppraiseContent; //评议内容
objvVideoLibAppraiseENT.AppraiseDate = objvVideoLibAppraiseENS.AppraiseDate; //评议日期
objvVideoLibAppraiseENT.AppraiseTime = objvVideoLibAppraiseENS.AppraiseTime; //评议时间
objvVideoLibAppraiseENT.IsVisual = objvVideoLibAppraiseENS.IsVisual; //隐藏标志
objvVideoLibAppraiseENT.IsElite = objvVideoLibAppraiseENS.IsElite; //精华标志
objvVideoLibAppraiseENT.ExcellentOne = objvVideoLibAppraiseENS.ExcellentOne; //优点1
objvVideoLibAppraiseENT.ExcellentTwo = objvVideoLibAppraiseENS.ExcellentTwo; //优点2
objvVideoLibAppraiseENT.SuggestOne = objvVideoLibAppraiseENS.SuggestOne; //建议1
objvVideoLibAppraiseENT.SuggestTwo = objvVideoLibAppraiseENS.SuggestTwo; //建议2
objvVideoLibAppraiseENT.MicroteachAppriseScore = objvVideoLibAppraiseENS.MicroteachAppriseScore; //打分
objvVideoLibAppraiseENT.VideoStopTime = objvVideoLibAppraiseENS.VideoStopTime; //公开课案例视频暂停时间
objvVideoLibAppraiseENT.BrowseCount = objvVideoLibAppraiseENS.BrowseCount; //浏览次数
objvVideoLibAppraiseENT.UserId = objvVideoLibAppraiseENS.UserId; //用户ID
objvVideoLibAppraiseENT.UserName = objvVideoLibAppraiseENS.UserName; //用户名
objvVideoLibAppraiseENT.UserNameWithUserId = objvVideoLibAppraiseENS.UserNameWithUserId; //UserNameWithUserId
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
public static DataTable ToDataTable(List<clsvVideoLibAppraiseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvVideoLibAppraiseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvVideoLibAppraiseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvVideoLibAppraiseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvVideoLibAppraiseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvVideoLibAppraiseEN.AttributeName)
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
if (clsMicroteachAppraiseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachAppraiseWApi没有刷新缓存机制(clsMicroteachAppraiseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAppraiseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsAppraiseTypeWApi没有刷新缓存机制(clsAppraiseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUsersWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersWApi没有刷新缓存机制(clsUsersWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserStateWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserStateWApi没有刷新缓存机制(clsUserStateWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzClgWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgWApi没有刷新缓存机制(clsXzClgWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorWApi没有刷新缓存机制(clsXzMajorWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzGradeBaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGradeBaseWApi没有刷新缓存机制(clsXzGradeBaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserIdentityWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserIdentityWApi没有刷新缓存机制(clsUserIdentityWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsVideoLibWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsVideoLibWApi没有刷新缓存机制(clsVideoLibWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRecommendedDegreeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRecommendedDegreeWApi没有刷新缓存机制(clsRecommendedDegreeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsVideoLibTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsVideoLibTypeWApi没有刷新缓存机制(clsVideoLibTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSenateGaugeVersionWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSenateGaugeVersionWApi没有刷新缓存机制(clsSenateGaugeVersionWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCaseLevelWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseLevelWApi没有刷新缓存机制(clsCaseLevelWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseWApi没有刷新缓存机制(clscc_CourseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseTypeWApi没有刷新缓存机制(clscc_CourseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExcellentTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExcellentTypeWApi没有刷新缓存机制(clscc_ExcellentTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ThemesWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ThemesWApi没有刷新缓存机制(clscc_ThemesWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseIsLikeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeWApi没有刷新缓存机制(clscc_CourseIsLikeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_MicroteachAppraise");
//if (arrvVideoLibAppraiseObjLst_Cache == null)
//{
//arrvVideoLibAppraiseObjLst_Cache = await clsvVideoLibAppraiseWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvVideoLibAppraiseEN._CurrTabName_S);
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
public static List<clsvVideoLibAppraiseEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvVideoLibAppraiseEN._CurrTabName_S);
List<clsvVideoLibAppraiseEN> arrvVideoLibAppraiseObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvVideoLibAppraiseObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvVideoLibAppraiseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convVideoLibAppraise.id_MicroteachAppraise, Type.GetType("System.Int64"));
objDT.Columns.Add(convVideoLibAppraise.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibAppraise.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibAppraise.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibAppraise.Id_VideoLib, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibAppraise.VideoLibID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibAppraise.VideoLibName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibAppraise.VideoLibTheme, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibAppraise.VideoLibTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibAppraise.VideoLibDate, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibAppraise.VideoLibTime, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibAppraise.VideoLibDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibAppraise.VideoLibTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibAppraise.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibAppraise.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibAppraise.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibAppraise.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibAppraise.CourseCode, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibAppraise.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibAppraise.BrowseCount4Case, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoLibAppraise.id_AppraiseType, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibAppraise.AppraiseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibAppraise.AppraiseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibAppraise.AppraiseContent, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibAppraise.AppraiseDate, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibAppraise.AppraiseTime, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibAppraise.IsVisual, Type.GetType("System.Boolean"));
objDT.Columns.Add(convVideoLibAppraise.IsElite, Type.GetType("System.Boolean"));
objDT.Columns.Add(convVideoLibAppraise.ExcellentOne, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibAppraise.ExcellentTwo, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibAppraise.SuggestOne, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibAppraise.SuggestTwo, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibAppraise.MicroteachAppriseScore, Type.GetType("System.Single"));
objDT.Columns.Add(convVideoLibAppraise.VideoStopTime, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibAppraise.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoLibAppraise.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibAppraise.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibAppraise.UserNameWithUserId, Type.GetType("System.String"));
foreach (clsvVideoLibAppraiseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convVideoLibAppraise.id_MicroteachAppraise] = objInFor[convVideoLibAppraise.id_MicroteachAppraise];
objDR[convVideoLibAppraise.FuncModuleId] = objInFor[convVideoLibAppraise.FuncModuleId];
objDR[convVideoLibAppraise.FuncModuleName] = objInFor[convVideoLibAppraise.FuncModuleName];
objDR[convVideoLibAppraise.id_MicroteachCase] = objInFor[convVideoLibAppraise.id_MicroteachCase];
objDR[convVideoLibAppraise.Id_VideoLib] = objInFor[convVideoLibAppraise.Id_VideoLib];
objDR[convVideoLibAppraise.VideoLibID] = objInFor[convVideoLibAppraise.VideoLibID];
objDR[convVideoLibAppraise.VideoLibName] = objInFor[convVideoLibAppraise.VideoLibName];
objDR[convVideoLibAppraise.VideoLibTheme] = objInFor[convVideoLibAppraise.VideoLibTheme];
objDR[convVideoLibAppraise.VideoLibTypeName] = objInFor[convVideoLibAppraise.VideoLibTypeName];
objDR[convVideoLibAppraise.VideoLibDate] = objInFor[convVideoLibAppraise.VideoLibDate];
objDR[convVideoLibAppraise.VideoLibTime] = objInFor[convVideoLibAppraise.VideoLibTime];
objDR[convVideoLibAppraise.VideoLibDateIn] = objInFor[convVideoLibAppraise.VideoLibDateIn];
objDR[convVideoLibAppraise.VideoLibTimeIn] = objInFor[convVideoLibAppraise.VideoLibTimeIn];
objDR[convVideoLibAppraise.id_XzCollege] = objInFor[convVideoLibAppraise.id_XzCollege];
objDR[convVideoLibAppraise.CollegeID] = objInFor[convVideoLibAppraise.CollegeID];
objDR[convVideoLibAppraise.CollegeName] = objInFor[convVideoLibAppraise.CollegeName];
objDR[convVideoLibAppraise.CourseId] = objInFor[convVideoLibAppraise.CourseId];
objDR[convVideoLibAppraise.CourseCode] = objInFor[convVideoLibAppraise.CourseCode];
objDR[convVideoLibAppraise.CourseName] = objInFor[convVideoLibAppraise.CourseName];
objDR[convVideoLibAppraise.BrowseCount4Case] = objInFor[convVideoLibAppraise.BrowseCount4Case];
objDR[convVideoLibAppraise.id_AppraiseType] = objInFor[convVideoLibAppraise.id_AppraiseType];
objDR[convVideoLibAppraise.AppraiseTypeName] = objInFor[convVideoLibAppraise.AppraiseTypeName];
objDR[convVideoLibAppraise.AppraiseTheme] = objInFor[convVideoLibAppraise.AppraiseTheme];
objDR[convVideoLibAppraise.AppraiseContent] = objInFor[convVideoLibAppraise.AppraiseContent];
objDR[convVideoLibAppraise.AppraiseDate] = objInFor[convVideoLibAppraise.AppraiseDate];
objDR[convVideoLibAppraise.AppraiseTime] = objInFor[convVideoLibAppraise.AppraiseTime];
objDR[convVideoLibAppraise.IsVisual] = objInFor[convVideoLibAppraise.IsVisual];
objDR[convVideoLibAppraise.IsElite] = objInFor[convVideoLibAppraise.IsElite];
objDR[convVideoLibAppraise.ExcellentOne] = objInFor[convVideoLibAppraise.ExcellentOne];
objDR[convVideoLibAppraise.ExcellentTwo] = objInFor[convVideoLibAppraise.ExcellentTwo];
objDR[convVideoLibAppraise.SuggestOne] = objInFor[convVideoLibAppraise.SuggestOne];
objDR[convVideoLibAppraise.SuggestTwo] = objInFor[convVideoLibAppraise.SuggestTwo];
objDR[convVideoLibAppraise.MicroteachAppriseScore] = objInFor[convVideoLibAppraise.MicroteachAppriseScore];
objDR[convVideoLibAppraise.VideoStopTime] = objInFor[convVideoLibAppraise.VideoStopTime];
objDR[convVideoLibAppraise.BrowseCount] = objInFor[convVideoLibAppraise.BrowseCount];
objDR[convVideoLibAppraise.UserId] = objInFor[convVideoLibAppraise.UserId];
objDR[convVideoLibAppraise.UserName] = objInFor[convVideoLibAppraise.UserName];
objDR[convVideoLibAppraise.UserNameWithUserId] = objInFor[convVideoLibAppraise.UserNameWithUserId];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}