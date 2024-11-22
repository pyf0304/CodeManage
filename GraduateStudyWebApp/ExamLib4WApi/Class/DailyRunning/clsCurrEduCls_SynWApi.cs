
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCurrEduCls_SynWApi
 表名:CurrEduCls_Syn(01120927)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:44:56
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:日常运行
 模块英文名:DailyRunning
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
public static class clsCurrEduCls_SynWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls_SynEN Setid_CurrEduCls(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strid_CurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_CurrEduCls, 8, conCurrEduCls_Syn.id_CurrEduCls);
clsCheckSql.CheckFieldForeignKey(strid_CurrEduCls, 8, conCurrEduCls_Syn.id_CurrEduCls);
objCurrEduCls_SynEN.id_CurrEduCls = strid_CurrEduCls; //当前教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.id_CurrEduCls) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.id_CurrEduCls, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.id_CurrEduCls] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls_SynEN SetCurrEduClsId(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strCurrEduClsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCurrEduClsId, conCurrEduCls_Syn.CurrEduClsId);
clsCheckSql.CheckFieldLen(strCurrEduClsId, 15, conCurrEduCls_Syn.CurrEduClsId);
objCurrEduCls_SynEN.CurrEduClsId = strCurrEduClsId; //当前教学班Id
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls_SynEN SetEduClsName(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strEduClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduClsName, 100, conCurrEduCls_Syn.EduClsName);
objCurrEduCls_SynEN.EduClsName = strEduClsName; //教学班名称
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls_SynEN SetEduClsTypeId(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strEduClsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduClsTypeId, 4, conCurrEduCls_Syn.EduClsTypeId);
clsCheckSql.CheckFieldForeignKey(strEduClsTypeId, 4, conCurrEduCls_Syn.EduClsTypeId);
objCurrEduCls_SynEN.EduClsTypeId = strEduClsTypeId; //教学班类型代号
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls_SynEN SetCourseId(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, conCurrEduCls_Syn.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, conCurrEduCls_Syn.CourseId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls_SynEN SetTeachingSolutionId(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strTeachingSolutionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingSolutionId, 8, conCurrEduCls_Syn.TeachingSolutionId);
clsCheckSql.CheckFieldForeignKey(strTeachingSolutionId, 8, conCurrEduCls_Syn.TeachingSolutionId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls_SynEN Setid_XzCollege(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, conCurrEduCls_Syn.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, conCurrEduCls_Syn.id_XzCollege);
objCurrEduCls_SynEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.id_XzCollege) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.id_XzCollege, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.id_XzCollege] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls_SynEN Setid_Major(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strid_Major, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Major, conCurrEduCls_Syn.id_Major);
clsCheckSql.CheckFieldLen(strid_Major, 8, conCurrEduCls_Syn.id_Major);
clsCheckSql.CheckFieldForeignKey(strid_Major, 8, conCurrEduCls_Syn.id_Major);
objCurrEduCls_SynEN.id_Major = strid_Major; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.id_Major) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.id_Major, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.id_Major] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls_SynEN Setid_EduWay(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strid_EduWay, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_EduWay, 4, conCurrEduCls_Syn.id_EduWay);
clsCheckSql.CheckFieldForeignKey(strid_EduWay, 4, conCurrEduCls_Syn.id_EduWay);
objCurrEduCls_SynEN.id_EduWay = strid_EduWay; //教学方式流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.id_EduWay) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.id_EduWay, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.id_EduWay] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls_SynEN Setid_ClassRoomType(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strid_ClassRoomType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_ClassRoomType, 4, conCurrEduCls_Syn.id_ClassRoomType);
clsCheckSql.CheckFieldForeignKey(strid_ClassRoomType, 4, conCurrEduCls_Syn.id_ClassRoomType);
objCurrEduCls_SynEN.id_ClassRoomType = strid_ClassRoomType; //教室类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.id_ClassRoomType) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.id_ClassRoomType, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.id_ClassRoomType] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls_SynEN SetTotalLessonQty(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, int intTotalLessonQty, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls_SynEN SetMaxStuQty(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, int intMaxStuQty, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls_SynEN SetCurrentStuQty(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, int intCurrentStuQty, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls_SynEN SetWeekQty(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, int intWeekQty, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls_SynEN SetScheUnitPW(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, short shtScheUnitPW, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls_SynEN SetWeekStatusID(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strWeekStatusID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWeekStatusID, 2, conCurrEduCls_Syn.WeekStatusID);
clsCheckSql.CheckFieldForeignKey(strWeekStatusID, 2, conCurrEduCls_Syn.WeekStatusID);
objCurrEduCls_SynEN.WeekStatusID = strWeekStatusID; //周状态编号(单,双,全周)
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.WeekStatusID) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.WeekStatusID, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.WeekStatusID] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls_SynEN SetCustomerWeek(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strCustomerWeek, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCustomerWeek, 50, conCurrEduCls_Syn.CustomerWeek);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls_SynEN Setid_ExecPlan(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strid_ExecPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_ExecPlan, 8, conCurrEduCls_Syn.id_ExecPlan);
clsCheckSql.CheckFieldForeignKey(strid_ExecPlan, 8, conCurrEduCls_Syn.id_ExecPlan);
objCurrEduCls_SynEN.id_ExecPlan = strid_ExecPlan; //执行计划流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.id_ExecPlan) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.id_ExecPlan, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.id_ExecPlan] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls_SynEN SetLessonQtyPerWeek(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, short shtLessonQtyPerWeek, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls_SynEN SetMark(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, double dblMark, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls_SynEN SetCheckClassRoom(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strCheckClassRoom, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCheckClassRoom, 2000, conCurrEduCls_Syn.CheckClassRoom);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls_SynEN SetCheckAdminCls(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strCheckAdminCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCheckAdminCls, 2000, conCurrEduCls_Syn.CheckAdminCls);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls_SynEN SetCheckTeacher(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strCheckTeacher, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCheckTeacher, 2000, conCurrEduCls_Syn.CheckTeacher);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls_SynEN Setid_UniZone(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strid_UniZone, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_UniZone, 4, conCurrEduCls_Syn.id_UniZone);
clsCheckSql.CheckFieldForeignKey(strid_UniZone, 4, conCurrEduCls_Syn.id_UniZone);
objCurrEduCls_SynEN.id_UniZone = strid_UniZone; //校区流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.id_UniZone) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.id_UniZone, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.id_UniZone] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls_SynEN Setid_GradeBase(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strid_GradeBase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_GradeBase, 4, conCurrEduCls_Syn.id_GradeBase);
clsCheckSql.CheckFieldForeignKey(strid_GradeBase, 4, conCurrEduCls_Syn.id_GradeBase);
objCurrEduCls_SynEN.id_GradeBase = strid_GradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.id_GradeBase) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.id_GradeBase, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.id_GradeBase] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls_SynEN SetSchoolYear(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strSchoolYear, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, conCurrEduCls_Syn.SchoolYear);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls_SynEN SetSchoolTerm(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strSchoolTerm, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, conCurrEduCls_Syn.SchoolTerm);
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, conCurrEduCls_Syn.SchoolTerm);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls_SynEN SetArrangeCourseMemo(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strArrangeCourseMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strArrangeCourseMemo, 50, conCurrEduCls_Syn.ArrangeCourseMemo);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls_SynEN Setid_CourseType(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strid_CourseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_CourseType, 4, conCurrEduCls_Syn.id_CourseType);
clsCheckSql.CheckFieldForeignKey(strid_CourseType, 4, conCurrEduCls_Syn.id_CourseType);
objCurrEduCls_SynEN.id_CourseType = strid_CourseType; //课程类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.id_CourseType) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.id_CourseType, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.id_CourseType] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls_SynEN SetExportDate(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strExportDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExportDate, 8, conCurrEduCls_Syn.ExportDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls_SynEN Setid_ScoreType(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strid_ScoreType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_ScoreType, 4, conCurrEduCls_Syn.id_ScoreType);
clsCheckSql.CheckFieldForeignKey(strid_ScoreType, 4, conCurrEduCls_Syn.id_ScoreType);
objCurrEduCls_SynEN.id_ScoreType = strid_ScoreType; //成绩类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.id_ScoreType) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.id_ScoreType, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.id_ScoreType] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls_SynEN SetGetScoreWayId(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strGetScoreWayId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGetScoreWayId, 2, conCurrEduCls_Syn.GetScoreWayId);
clsCheckSql.CheckFieldForeignKey(strGetScoreWayId, 2, conCurrEduCls_Syn.GetScoreWayId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls_SynEN Setid_ExamType(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strid_ExamType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_ExamType, 4, conCurrEduCls_Syn.id_ExamType);
clsCheckSql.CheckFieldForeignKey(strid_ExamType, 4, conCurrEduCls_Syn.id_ExamType);
objCurrEduCls_SynEN.id_ExamType = strid_ExamType; //考试方式流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.id_ExamType) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.id_ExamType, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.id_ExamType] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls_SynEN SetExamPortion(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, short shtExamPortion, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls_SynEN SetMidExamScorePortion(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, short shtMidExamScorePortion, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls_SynEN SetGeneratePwdDate(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strGeneratePwdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGeneratePwdDate, 20, conCurrEduCls_Syn.GeneratePwdDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls_SynEN SetExamTime(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strExamTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamTime, 8, conCurrEduCls_Syn.ExamTime);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls_SynEN SetCheckDate(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strCheckDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCheckDate, 20, conCurrEduCls_Syn.CheckDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls_SynEN Setid_EduClassInPk(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strid_EduClassInPk, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_EduClassInPk, 8, conCurrEduCls_Syn.id_EduClassInPk);
clsCheckSql.CheckFieldForeignKey(strid_EduClassInPk, 8, conCurrEduCls_Syn.id_EduClassInPk);
objCurrEduCls_SynEN.id_EduClassInPk = strid_EduClassInPk; //id_EduClassInPk
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.id_EduClassInPk) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.id_EduClassInPk, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.id_EduClassInPk] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls_SynEN SetPkWeekTime(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strPkWeekTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPkWeekTime, 2000, conCurrEduCls_Syn.PkWeekTime);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls_SynEN SetPkClassRooms(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strPkClassRooms, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPkClassRooms, 150, conCurrEduCls_Syn.PkClassRooms);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls_SynEN SetBeginWeek(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, short shtBeginWeek, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls_SynEN SetTeacherNames(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strTeacherNames, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeacherNames, 100, conCurrEduCls_Syn.TeacherNames);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls_SynEN SetSynchDate(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strSynchDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSynchDate, 30, conCurrEduCls_Syn.SynchDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls_SynEN SetModifyDate(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strModifyDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyDate, 20, conCurrEduCls_Syn.ModifyDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls_SynEN SetModifyUserID(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strModifyUserID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyUserID, 18, conCurrEduCls_Syn.ModifyUserID);
objCurrEduCls_SynEN.ModifyUserID = strModifyUserID; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls_SynEN.dicFldComparisonOp.ContainsKey(conCurrEduCls_Syn.ModifyUserID) == false)
{
objCurrEduCls_SynEN.dicFldComparisonOp.Add(conCurrEduCls_Syn.ModifyUserID, strComparisonOp);
}
else
{
objCurrEduCls_SynEN.dicFldComparisonOp[conCurrEduCls_Syn.ModifyUserID] = strComparisonOp;
}
}
return objCurrEduCls_SynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls_SynEN SetMemo(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCurrEduCls_Syn.Memo);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls_SynEN SetSignInDate(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strSignInDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSignInDate, 20, conCurrEduCls_Syn.SignInDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls_SynEN SetSignInStateID(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strSignInStateID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSignInStateID, 2, conCurrEduCls_Syn.SignInStateID);
clsCheckSql.CheckFieldForeignKey(strSignInStateID, 2, conCurrEduCls_Syn.SignInStateID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls_SynEN SetSignInUser(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strSignInUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSignInUser, 18, conCurrEduCls_Syn.SignInUser);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls_SynEN SetSynchToWebUser(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strSynchToWebUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSynchToWebUser, 18, conCurrEduCls_Syn.SynchToWebUser);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls_SynEN SetSynchToWebDate(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strSynchToWebDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSynchToWebDate, 20, conCurrEduCls_Syn.SynchToWebDate);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCurrEduCls_SynEN objCurrEduCls_Syn_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.id_CurrEduCls) == true)
{
string strComparisonOp_id_CurrEduCls = objCurrEduCls_Syn_Cond.dicFldComparisonOp[conCurrEduCls_Syn.id_CurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.id_CurrEduCls, objCurrEduCls_Syn_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.CurrEduClsId) == true)
{
string strComparisonOp_CurrEduClsId = objCurrEduCls_Syn_Cond.dicFldComparisonOp[conCurrEduCls_Syn.CurrEduClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.CurrEduClsId, objCurrEduCls_Syn_Cond.CurrEduClsId, strComparisonOp_CurrEduClsId);
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.EduClsName) == true)
{
string strComparisonOp_EduClsName = objCurrEduCls_Syn_Cond.dicFldComparisonOp[conCurrEduCls_Syn.EduClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.EduClsName, objCurrEduCls_Syn_Cond.EduClsName, strComparisonOp_EduClsName);
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.EduClsTypeId) == true)
{
string strComparisonOp_EduClsTypeId = objCurrEduCls_Syn_Cond.dicFldComparisonOp[conCurrEduCls_Syn.EduClsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.EduClsTypeId, objCurrEduCls_Syn_Cond.EduClsTypeId, strComparisonOp_EduClsTypeId);
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.CourseId) == true)
{
string strComparisonOp_CourseId = objCurrEduCls_Syn_Cond.dicFldComparisonOp[conCurrEduCls_Syn.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.CourseId, objCurrEduCls_Syn_Cond.CourseId, strComparisonOp_CourseId);
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.TeachingSolutionId) == true)
{
string strComparisonOp_TeachingSolutionId = objCurrEduCls_Syn_Cond.dicFldComparisonOp[conCurrEduCls_Syn.TeachingSolutionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.TeachingSolutionId, objCurrEduCls_Syn_Cond.TeachingSolutionId, strComparisonOp_TeachingSolutionId);
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objCurrEduCls_Syn_Cond.dicFldComparisonOp[conCurrEduCls_Syn.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.id_XzCollege, objCurrEduCls_Syn_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.id_Major) == true)
{
string strComparisonOp_id_Major = objCurrEduCls_Syn_Cond.dicFldComparisonOp[conCurrEduCls_Syn.id_Major];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.id_Major, objCurrEduCls_Syn_Cond.id_Major, strComparisonOp_id_Major);
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.id_EduWay) == true)
{
string strComparisonOp_id_EduWay = objCurrEduCls_Syn_Cond.dicFldComparisonOp[conCurrEduCls_Syn.id_EduWay];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.id_EduWay, objCurrEduCls_Syn_Cond.id_EduWay, strComparisonOp_id_EduWay);
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.id_ClassRoomType) == true)
{
string strComparisonOp_id_ClassRoomType = objCurrEduCls_Syn_Cond.dicFldComparisonOp[conCurrEduCls_Syn.id_ClassRoomType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.id_ClassRoomType, objCurrEduCls_Syn_Cond.id_ClassRoomType, strComparisonOp_id_ClassRoomType);
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.TotalLessonQty) == true)
{
string strComparisonOp_TotalLessonQty = objCurrEduCls_Syn_Cond.dicFldComparisonOp[conCurrEduCls_Syn.TotalLessonQty];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduCls_Syn.TotalLessonQty, objCurrEduCls_Syn_Cond.TotalLessonQty, strComparisonOp_TotalLessonQty);
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.MaxStuQty) == true)
{
string strComparisonOp_MaxStuQty = objCurrEduCls_Syn_Cond.dicFldComparisonOp[conCurrEduCls_Syn.MaxStuQty];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduCls_Syn.MaxStuQty, objCurrEduCls_Syn_Cond.MaxStuQty, strComparisonOp_MaxStuQty);
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.CurrentStuQty) == true)
{
string strComparisonOp_CurrentStuQty = objCurrEduCls_Syn_Cond.dicFldComparisonOp[conCurrEduCls_Syn.CurrentStuQty];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduCls_Syn.CurrentStuQty, objCurrEduCls_Syn_Cond.CurrentStuQty, strComparisonOp_CurrentStuQty);
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.WeekQty) == true)
{
string strComparisonOp_WeekQty = objCurrEduCls_Syn_Cond.dicFldComparisonOp[conCurrEduCls_Syn.WeekQty];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduCls_Syn.WeekQty, objCurrEduCls_Syn_Cond.WeekQty, strComparisonOp_WeekQty);
}
//数据类型short(smallint)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.WeekStatusID) == true)
{
string strComparisonOp_WeekStatusID = objCurrEduCls_Syn_Cond.dicFldComparisonOp[conCurrEduCls_Syn.WeekStatusID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.WeekStatusID, objCurrEduCls_Syn_Cond.WeekStatusID, strComparisonOp_WeekStatusID);
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.CustomerWeek) == true)
{
string strComparisonOp_CustomerWeek = objCurrEduCls_Syn_Cond.dicFldComparisonOp[conCurrEduCls_Syn.CustomerWeek];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.CustomerWeek, objCurrEduCls_Syn_Cond.CustomerWeek, strComparisonOp_CustomerWeek);
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.IsCompleteScore) == true)
{
if (objCurrEduCls_Syn_Cond.IsCompleteScore == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls_Syn.IsCompleteScore);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls_Syn.IsCompleteScore);
}
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.id_ExecPlan) == true)
{
string strComparisonOp_id_ExecPlan = objCurrEduCls_Syn_Cond.dicFldComparisonOp[conCurrEduCls_Syn.id_ExecPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.id_ExecPlan, objCurrEduCls_Syn_Cond.id_ExecPlan, strComparisonOp_id_ExecPlan);
}
//数据类型short(smallint)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.Mark) == true)
{
string strComparisonOp_Mark = objCurrEduCls_Syn_Cond.dicFldComparisonOp[conCurrEduCls_Syn.Mark];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduCls_Syn.Mark, objCurrEduCls_Syn_Cond.Mark, strComparisonOp_Mark);
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.CheckClassRoom) == true)
{
string strComparisonOp_CheckClassRoom = objCurrEduCls_Syn_Cond.dicFldComparisonOp[conCurrEduCls_Syn.CheckClassRoom];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.CheckClassRoom, objCurrEduCls_Syn_Cond.CheckClassRoom, strComparisonOp_CheckClassRoom);
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.CheckAdminCls) == true)
{
string strComparisonOp_CheckAdminCls = objCurrEduCls_Syn_Cond.dicFldComparisonOp[conCurrEduCls_Syn.CheckAdminCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.CheckAdminCls, objCurrEduCls_Syn_Cond.CheckAdminCls, strComparisonOp_CheckAdminCls);
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.CheckTeacher) == true)
{
string strComparisonOp_CheckTeacher = objCurrEduCls_Syn_Cond.dicFldComparisonOp[conCurrEduCls_Syn.CheckTeacher];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.CheckTeacher, objCurrEduCls_Syn_Cond.CheckTeacher, strComparisonOp_CheckTeacher);
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.EditLocked) == true)
{
if (objCurrEduCls_Syn_Cond.EditLocked == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls_Syn.EditLocked);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls_Syn.EditLocked);
}
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.Sched) == true)
{
if (objCurrEduCls_Syn_Cond.Sched == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls_Syn.Sched);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls_Syn.Sched);
}
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.id_UniZone) == true)
{
string strComparisonOp_id_UniZone = objCurrEduCls_Syn_Cond.dicFldComparisonOp[conCurrEduCls_Syn.id_UniZone];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.id_UniZone, objCurrEduCls_Syn_Cond.id_UniZone, strComparisonOp_id_UniZone);
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.Locked) == true)
{
if (objCurrEduCls_Syn_Cond.Locked == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls_Syn.Locked);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls_Syn.Locked);
}
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.id_GradeBase) == true)
{
string strComparisonOp_id_GradeBase = objCurrEduCls_Syn_Cond.dicFldComparisonOp[conCurrEduCls_Syn.id_GradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.id_GradeBase, objCurrEduCls_Syn_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.IsEffective) == true)
{
if (objCurrEduCls_Syn_Cond.IsEffective == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls_Syn.IsEffective);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls_Syn.IsEffective);
}
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.IsForPaperReading) == true)
{
if (objCurrEduCls_Syn_Cond.IsForPaperReading == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls_Syn.IsForPaperReading);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls_Syn.IsForPaperReading);
}
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.IsUnDeterminedClsRm) == true)
{
if (objCurrEduCls_Syn_Cond.IsUnDeterminedClsRm == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls_Syn.IsUnDeterminedClsRm);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls_Syn.IsUnDeterminedClsRm);
}
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.SchoolYear) == true)
{
string strComparisonOp_SchoolYear = objCurrEduCls_Syn_Cond.dicFldComparisonOp[conCurrEduCls_Syn.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.SchoolYear, objCurrEduCls_Syn_Cond.SchoolYear, strComparisonOp_SchoolYear);
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.SchoolTerm) == true)
{
string strComparisonOp_SchoolTerm = objCurrEduCls_Syn_Cond.dicFldComparisonOp[conCurrEduCls_Syn.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.SchoolTerm, objCurrEduCls_Syn_Cond.SchoolTerm, strComparisonOp_SchoolTerm);
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.ArrangeCourseMemo) == true)
{
string strComparisonOp_ArrangeCourseMemo = objCurrEduCls_Syn_Cond.dicFldComparisonOp[conCurrEduCls_Syn.ArrangeCourseMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.ArrangeCourseMemo, objCurrEduCls_Syn_Cond.ArrangeCourseMemo, strComparisonOp_ArrangeCourseMemo);
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.id_CourseType) == true)
{
string strComparisonOp_id_CourseType = objCurrEduCls_Syn_Cond.dicFldComparisonOp[conCurrEduCls_Syn.id_CourseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.id_CourseType, objCurrEduCls_Syn_Cond.id_CourseType, strComparisonOp_id_CourseType);
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.ExportDate) == true)
{
string strComparisonOp_ExportDate = objCurrEduCls_Syn_Cond.dicFldComparisonOp[conCurrEduCls_Syn.ExportDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.ExportDate, objCurrEduCls_Syn_Cond.ExportDate, strComparisonOp_ExportDate);
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.IsDegree) == true)
{
if (objCurrEduCls_Syn_Cond.IsDegree == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls_Syn.IsDegree);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls_Syn.IsDegree);
}
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.id_ScoreType) == true)
{
string strComparisonOp_id_ScoreType = objCurrEduCls_Syn_Cond.dicFldComparisonOp[conCurrEduCls_Syn.id_ScoreType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.id_ScoreType, objCurrEduCls_Syn_Cond.id_ScoreType, strComparisonOp_id_ScoreType);
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.GetScoreWayId) == true)
{
string strComparisonOp_GetScoreWayId = objCurrEduCls_Syn_Cond.dicFldComparisonOp[conCurrEduCls_Syn.GetScoreWayId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.GetScoreWayId, objCurrEduCls_Syn_Cond.GetScoreWayId, strComparisonOp_GetScoreWayId);
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.IsProportionalCtrl) == true)
{
if (objCurrEduCls_Syn_Cond.IsProportionalCtrl == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls_Syn.IsProportionalCtrl);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls_Syn.IsProportionalCtrl);
}
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.id_ExamType) == true)
{
string strComparisonOp_id_ExamType = objCurrEduCls_Syn_Cond.dicFldComparisonOp[conCurrEduCls_Syn.id_ExamType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.id_ExamType, objCurrEduCls_Syn_Cond.id_ExamType, strComparisonOp_id_ExamType);
}
//数据类型short(smallint)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
//数据类型short(smallint)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.IsClearScore) == true)
{
if (objCurrEduCls_Syn_Cond.IsClearScore == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls_Syn.IsClearScore);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls_Syn.IsClearScore);
}
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.IsGeneratePwd) == true)
{
if (objCurrEduCls_Syn_Cond.IsGeneratePwd == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls_Syn.IsGeneratePwd);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls_Syn.IsGeneratePwd);
}
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.GeneratePwdDate) == true)
{
string strComparisonOp_GeneratePwdDate = objCurrEduCls_Syn_Cond.dicFldComparisonOp[conCurrEduCls_Syn.GeneratePwdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.GeneratePwdDate, objCurrEduCls_Syn_Cond.GeneratePwdDate, strComparisonOp_GeneratePwdDate);
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.IsExportToGP) == true)
{
if (objCurrEduCls_Syn_Cond.IsExportToGP == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls_Syn.IsExportToGP);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls_Syn.IsExportToGP);
}
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.IsExportToGPWeb) == true)
{
if (objCurrEduCls_Syn_Cond.IsExportToGPWeb == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls_Syn.IsExportToGPWeb);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls_Syn.IsExportToGPWeb);
}
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.IsReservedDecimal) == true)
{
if (objCurrEduCls_Syn_Cond.IsReservedDecimal == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls_Syn.IsReservedDecimal);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls_Syn.IsReservedDecimal);
}
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.ExamTime) == true)
{
string strComparisonOp_ExamTime = objCurrEduCls_Syn_Cond.dicFldComparisonOp[conCurrEduCls_Syn.ExamTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.ExamTime, objCurrEduCls_Syn_Cond.ExamTime, strComparisonOp_ExamTime);
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.CheckState) == true)
{
if (objCurrEduCls_Syn_Cond.CheckState == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls_Syn.CheckState);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls_Syn.CheckState);
}
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.CheckDate) == true)
{
string strComparisonOp_CheckDate = objCurrEduCls_Syn_Cond.dicFldComparisonOp[conCurrEduCls_Syn.CheckDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.CheckDate, objCurrEduCls_Syn_Cond.CheckDate, strComparisonOp_CheckDate);
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.id_EduClassInPk) == true)
{
string strComparisonOp_id_EduClassInPk = objCurrEduCls_Syn_Cond.dicFldComparisonOp[conCurrEduCls_Syn.id_EduClassInPk];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.id_EduClassInPk, objCurrEduCls_Syn_Cond.id_EduClassInPk, strComparisonOp_id_EduClassInPk);
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.PkWeekTime) == true)
{
string strComparisonOp_PkWeekTime = objCurrEduCls_Syn_Cond.dicFldComparisonOp[conCurrEduCls_Syn.PkWeekTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.PkWeekTime, objCurrEduCls_Syn_Cond.PkWeekTime, strComparisonOp_PkWeekTime);
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.PkClassRooms) == true)
{
string strComparisonOp_PkClassRooms = objCurrEduCls_Syn_Cond.dicFldComparisonOp[conCurrEduCls_Syn.PkClassRooms];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.PkClassRooms, objCurrEduCls_Syn_Cond.PkClassRooms, strComparisonOp_PkClassRooms);
}
//数据类型short(smallint)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.TeacherNames) == true)
{
string strComparisonOp_TeacherNames = objCurrEduCls_Syn_Cond.dicFldComparisonOp[conCurrEduCls_Syn.TeacherNames];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.TeacherNames, objCurrEduCls_Syn_Cond.TeacherNames, strComparisonOp_TeacherNames);
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.IsSynch) == true)
{
if (objCurrEduCls_Syn_Cond.IsSynch == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls_Syn.IsSynch);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls_Syn.IsSynch);
}
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.SynchDate) == true)
{
string strComparisonOp_SynchDate = objCurrEduCls_Syn_Cond.dicFldComparisonOp[conCurrEduCls_Syn.SynchDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.SynchDate, objCurrEduCls_Syn_Cond.SynchDate, strComparisonOp_SynchDate);
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.ModifyDate) == true)
{
string strComparisonOp_ModifyDate = objCurrEduCls_Syn_Cond.dicFldComparisonOp[conCurrEduCls_Syn.ModifyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.ModifyDate, objCurrEduCls_Syn_Cond.ModifyDate, strComparisonOp_ModifyDate);
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.ModifyUserID) == true)
{
string strComparisonOp_ModifyUserID = objCurrEduCls_Syn_Cond.dicFldComparisonOp[conCurrEduCls_Syn.ModifyUserID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.ModifyUserID, objCurrEduCls_Syn_Cond.ModifyUserID, strComparisonOp_ModifyUserID);
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.Memo) == true)
{
string strComparisonOp_Memo = objCurrEduCls_Syn_Cond.dicFldComparisonOp[conCurrEduCls_Syn.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.Memo, objCurrEduCls_Syn_Cond.Memo, strComparisonOp_Memo);
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.SignInDate) == true)
{
string strComparisonOp_SignInDate = objCurrEduCls_Syn_Cond.dicFldComparisonOp[conCurrEduCls_Syn.SignInDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.SignInDate, objCurrEduCls_Syn_Cond.SignInDate, strComparisonOp_SignInDate);
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.SignInStateID) == true)
{
string strComparisonOp_SignInStateID = objCurrEduCls_Syn_Cond.dicFldComparisonOp[conCurrEduCls_Syn.SignInStateID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.SignInStateID, objCurrEduCls_Syn_Cond.SignInStateID, strComparisonOp_SignInStateID);
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.SignInUser) == true)
{
string strComparisonOp_SignInUser = objCurrEduCls_Syn_Cond.dicFldComparisonOp[conCurrEduCls_Syn.SignInUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.SignInUser, objCurrEduCls_Syn_Cond.SignInUser, strComparisonOp_SignInUser);
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.SynchToWebUser) == true)
{
string strComparisonOp_SynchToWebUser = objCurrEduCls_Syn_Cond.dicFldComparisonOp[conCurrEduCls_Syn.SynchToWebUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.SynchToWebUser, objCurrEduCls_Syn_Cond.SynchToWebUser, strComparisonOp_SynchToWebUser);
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.IsSynchToWeb) == true)
{
if (objCurrEduCls_Syn_Cond.IsSynchToWeb == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls_Syn.IsSynchToWeb);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls_Syn.IsSynchToWeb);
}
}
if (objCurrEduCls_Syn_Cond.IsUpdated(conCurrEduCls_Syn.SynchToWebDate) == true)
{
string strComparisonOp_SynchToWebDate = objCurrEduCls_Syn_Cond.dicFldComparisonOp[conCurrEduCls_Syn.SynchToWebDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls_Syn.SynchToWebDate, objCurrEduCls_Syn_Cond.SynchToWebDate, strComparisonOp_SynchToWebDate);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCurrEduCls_SynEN objCurrEduCls_SynEN)
{
 if (string.IsNullOrEmpty(objCurrEduCls_SynEN.id_CurrEduCls) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objCurrEduCls_SynEN.sf_UpdFldSetStr = objCurrEduCls_SynEN.getsf_UpdFldSetStr();
clsCurrEduCls_SynWApi.CheckPropertyNew(objCurrEduCls_SynEN); 
bool bolResult = clsCurrEduCls_SynWApi.UpdateRecord(objCurrEduCls_SynEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduCls_SynWApi.ReFreshCache();
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
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCurrEduCls_SynEN objCurrEduCls_SynEN)
{
try
{
 if (string.IsNullOrEmpty(objCurrEduCls_SynEN.id_CurrEduCls) == true || clsCurrEduCls_SynWApi.IsExist(objCurrEduCls_SynEN.id_CurrEduCls) == true)
 {
     objCurrEduCls_SynEN.id_CurrEduCls = clsCurrEduCls_SynWApi.GetMaxStrId();
 }
clsCurrEduCls_SynWApi.CheckPropertyNew(objCurrEduCls_SynEN); 
bool bolResult = clsCurrEduCls_SynWApi.AddNewRecord(objCurrEduCls_SynEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduCls_SynWApi.ReFreshCache();
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
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值. 该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsCurrEduCls_SynEN objCurrEduCls_SynEN)
{
try
{
clsCurrEduCls_SynWApi.CheckPropertyNew(objCurrEduCls_SynEN); 
string strid_CurrEduCls = clsCurrEduCls_SynWApi.AddNewRecordWithMaxId(objCurrEduCls_SynEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduCls_SynWApi.ReFreshCache();
return strid_CurrEduCls;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000009)添加记录出错, {1}.(from {0})",
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
 /// <param name = "objCurrEduCls_SynEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strWhereCond)
{
try
{
clsCurrEduCls_SynWApi.CheckPropertyNew(objCurrEduCls_SynEN); 
bool bolResult = clsCurrEduCls_SynWApi.UpdateWithCondition(objCurrEduCls_SynEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduCls_SynWApi.ReFreshCache();
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
 /// 当前教学班_动态(CurrEduCls_Syn)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsCurrEduCls_SynWApi
{
private static readonly string mstrApiControllerName = "CurrEduCls_SynApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsCurrEduCls_SynWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_id_CurrEduCls(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[当前教学班_动态]...","0");
List<clsCurrEduCls_SynEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="id_CurrEduCls";
objDDL.DataTextField="EduClsName";
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_id_CurrEduCls(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conCurrEduCls_Syn.id_CurrEduCls); 
List<clsCurrEduCls_SynEN> arrObjLst = clsCurrEduCls_SynWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsCurrEduCls_SynEN objCurrEduCls_SynEN = new clsCurrEduCls_SynEN()
{
id_CurrEduCls = "0",
EduClsName = "选[当前教学班_动态]..."
};
arrObjLst.Insert(0, objCurrEduCls_SynEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conCurrEduCls_Syn.id_CurrEduCls;
objComboBox.DisplayMember = conCurrEduCls_Syn.EduClsName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsCurrEduCls_SynEN objCurrEduCls_SynEN)
{
if (!Object.Equals(null, objCurrEduCls_SynEN.id_CurrEduCls) && GetStrLen(objCurrEduCls_SynEN.id_CurrEduCls) > 8)
{
 throw new Exception("字段[当前教学班流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objCurrEduCls_SynEN.CurrEduClsId) && GetStrLen(objCurrEduCls_SynEN.CurrEduClsId) > 15)
{
 throw new Exception("字段[当前教学班Id]的长度不能超过15!");
}
if (!Object.Equals(null, objCurrEduCls_SynEN.EduClsName) && GetStrLen(objCurrEduCls_SynEN.EduClsName) > 100)
{
 throw new Exception("字段[教学班名称]的长度不能超过100!");
}
if (!Object.Equals(null, objCurrEduCls_SynEN.EduClsTypeId) && GetStrLen(objCurrEduCls_SynEN.EduClsTypeId) > 4)
{
 throw new Exception("字段[教学班类型代号]的长度不能超过4!");
}
if (!Object.Equals(null, objCurrEduCls_SynEN.CourseId) && GetStrLen(objCurrEduCls_SynEN.CourseId) > 8)
{
 throw new Exception("字段[课程Id]的长度不能超过8!");
}
if (!Object.Equals(null, objCurrEduCls_SynEN.TeachingSolutionId) && GetStrLen(objCurrEduCls_SynEN.TeachingSolutionId) > 8)
{
 throw new Exception("字段[教学方案Id]的长度不能超过8!");
}
if (!Object.Equals(null, objCurrEduCls_SynEN.id_XzCollege) && GetStrLen(objCurrEduCls_SynEN.id_XzCollege) > 4)
{
 throw new Exception("字段[学院流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objCurrEduCls_SynEN.id_Major) && GetStrLen(objCurrEduCls_SynEN.id_Major) > 8)
{
 throw new Exception("字段[专业流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objCurrEduCls_SynEN.id_EduWay) && GetStrLen(objCurrEduCls_SynEN.id_EduWay) > 4)
{
 throw new Exception("字段[教学方式流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objCurrEduCls_SynEN.id_ClassRoomType) && GetStrLen(objCurrEduCls_SynEN.id_ClassRoomType) > 4)
{
 throw new Exception("字段[教室类型流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objCurrEduCls_SynEN.WeekStatusID) && GetStrLen(objCurrEduCls_SynEN.WeekStatusID) > 2)
{
 throw new Exception("字段[周状态编号(单,双,全周)]的长度不能超过2!");
}
if (!Object.Equals(null, objCurrEduCls_SynEN.CustomerWeek) && GetStrLen(objCurrEduCls_SynEN.CustomerWeek) > 50)
{
 throw new Exception("字段[自定义上课周]的长度不能超过50!");
}
if (!Object.Equals(null, objCurrEduCls_SynEN.id_ExecPlan) && GetStrLen(objCurrEduCls_SynEN.id_ExecPlan) > 8)
{
 throw new Exception("字段[执行计划流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objCurrEduCls_SynEN.CheckClassRoom) && GetStrLen(objCurrEduCls_SynEN.CheckClassRoom) > 2000)
{
 throw new Exception("字段[检查教室结果]的长度不能超过2000!");
}
if (!Object.Equals(null, objCurrEduCls_SynEN.CheckAdminCls) && GetStrLen(objCurrEduCls_SynEN.CheckAdminCls) > 2000)
{
 throw new Exception("字段[检查行政班结果]的长度不能超过2000!");
}
if (!Object.Equals(null, objCurrEduCls_SynEN.CheckTeacher) && GetStrLen(objCurrEduCls_SynEN.CheckTeacher) > 2000)
{
 throw new Exception("字段[检查教师结果]的长度不能超过2000!");
}
if (!Object.Equals(null, objCurrEduCls_SynEN.id_UniZone) && GetStrLen(objCurrEduCls_SynEN.id_UniZone) > 4)
{
 throw new Exception("字段[校区流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objCurrEduCls_SynEN.id_GradeBase) && GetStrLen(objCurrEduCls_SynEN.id_GradeBase) > 4)
{
 throw new Exception("字段[年级流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objCurrEduCls_SynEN.SchoolYear) && GetStrLen(objCurrEduCls_SynEN.SchoolYear) > 10)
{
 throw new Exception("字段[学年]的长度不能超过10!");
}
if (!Object.Equals(null, objCurrEduCls_SynEN.SchoolTerm) && GetStrLen(objCurrEduCls_SynEN.SchoolTerm) > 1)
{
 throw new Exception("字段[学期]的长度不能超过1!");
}
if (!Object.Equals(null, objCurrEduCls_SynEN.ArrangeCourseMemo) && GetStrLen(objCurrEduCls_SynEN.ArrangeCourseMemo) > 50)
{
 throw new Exception("字段[排课备注]的长度不能超过50!");
}
if (!Object.Equals(null, objCurrEduCls_SynEN.id_CourseType) && GetStrLen(objCurrEduCls_SynEN.id_CourseType) > 4)
{
 throw new Exception("字段[课程类型流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objCurrEduCls_SynEN.ExportDate) && GetStrLen(objCurrEduCls_SynEN.ExportDate) > 8)
{
 throw new Exception("字段[导出日期]的长度不能超过8!");
}
if (!Object.Equals(null, objCurrEduCls_SynEN.id_ScoreType) && GetStrLen(objCurrEduCls_SynEN.id_ScoreType) > 4)
{
 throw new Exception("字段[成绩类型流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objCurrEduCls_SynEN.GetScoreWayId) && GetStrLen(objCurrEduCls_SynEN.GetScoreWayId) > 2)
{
 throw new Exception("字段[获得成绩方式Id]的长度不能超过2!");
}
if (!Object.Equals(null, objCurrEduCls_SynEN.id_ExamType) && GetStrLen(objCurrEduCls_SynEN.id_ExamType) > 4)
{
 throw new Exception("字段[考试方式流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objCurrEduCls_SynEN.GeneratePwdDate) && GetStrLen(objCurrEduCls_SynEN.GeneratePwdDate) > 20)
{
 throw new Exception("字段[生成口令时间]的长度不能超过20!");
}
if (!Object.Equals(null, objCurrEduCls_SynEN.ExamTime) && GetStrLen(objCurrEduCls_SynEN.ExamTime) > 8)
{
 throw new Exception("字段[考试时间]的长度不能超过8!");
}
if (!Object.Equals(null, objCurrEduCls_SynEN.CheckDate) && GetStrLen(objCurrEduCls_SynEN.CheckDate) > 20)
{
 throw new Exception("字段[检查日期]的长度不能超过20!");
}
if (!Object.Equals(null, objCurrEduCls_SynEN.id_EduClassInPk) && GetStrLen(objCurrEduCls_SynEN.id_EduClassInPk) > 8)
{
 throw new Exception("字段[id_EduClassInPk]的长度不能超过8!");
}
if (!Object.Equals(null, objCurrEduCls_SynEN.PkWeekTime) && GetStrLen(objCurrEduCls_SynEN.PkWeekTime) > 2000)
{
 throw new Exception("字段[排课时间]的长度不能超过2000!");
}
if (!Object.Equals(null, objCurrEduCls_SynEN.PkClassRooms) && GetStrLen(objCurrEduCls_SynEN.PkClassRooms) > 150)
{
 throw new Exception("字段[排课教室]的长度不能超过150!");
}
if (!Object.Equals(null, objCurrEduCls_SynEN.TeacherNames) && GetStrLen(objCurrEduCls_SynEN.TeacherNames) > 100)
{
 throw new Exception("字段[教师姓名]的长度不能超过100!");
}
if (!Object.Equals(null, objCurrEduCls_SynEN.SynchDate) && GetStrLen(objCurrEduCls_SynEN.SynchDate) > 30)
{
 throw new Exception("字段[同步日期]的长度不能超过30!");
}
if (!Object.Equals(null, objCurrEduCls_SynEN.ModifyDate) && GetStrLen(objCurrEduCls_SynEN.ModifyDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objCurrEduCls_SynEN.ModifyUserID) && GetStrLen(objCurrEduCls_SynEN.ModifyUserID) > 18)
{
 throw new Exception("字段[修改人]的长度不能超过18!");
}
if (!Object.Equals(null, objCurrEduCls_SynEN.Memo) && GetStrLen(objCurrEduCls_SynEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
if (!Object.Equals(null, objCurrEduCls_SynEN.SignInDate) && GetStrLen(objCurrEduCls_SynEN.SignInDate) > 20)
{
 throw new Exception("字段[签入时间]的长度不能超过20!");
}
if (!Object.Equals(null, objCurrEduCls_SynEN.SignInStateID) && GetStrLen(objCurrEduCls_SynEN.SignInStateID) > 2)
{
 throw new Exception("字段[签入状态表流水号]的长度不能超过2!");
}
if (!Object.Equals(null, objCurrEduCls_SynEN.SignInUser) && GetStrLen(objCurrEduCls_SynEN.SignInUser) > 18)
{
 throw new Exception("字段[签入人]的长度不能超过18!");
}
if (!Object.Equals(null, objCurrEduCls_SynEN.SynchToWebUser) && GetStrLen(objCurrEduCls_SynEN.SynchToWebUser) > 18)
{
 throw new Exception("字段[同步Web用户]的长度不能超过18!");
}
if (!Object.Equals(null, objCurrEduCls_SynEN.SynchToWebDate) && GetStrLen(objCurrEduCls_SynEN.SynchToWebDate) > 20)
{
 throw new Exception("字段[同步Web日期]的长度不能超过20!");
}
 objCurrEduCls_SynEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_CurrEduCls">表关键字</param>
 /// <returns>表对象</returns>
public static clsCurrEduCls_SynEN GetObjByid_CurrEduCls(string strid_CurrEduCls)
{
string strAction = "GetObjByid_CurrEduCls";
string strErrMsg = string.Empty;
string strResult = "";
clsCurrEduCls_SynEN objCurrEduCls_SynEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CurrEduCls"] = strid_CurrEduCls
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objCurrEduCls_SynEN = JsonConvert.DeserializeObject<clsCurrEduCls_SynEN>((string)jobjReturn["ReturnObj"]);
return objCurrEduCls_SynEN;
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
 /// <param name = "strid_CurrEduCls">表关键字</param>
 /// <returns>表对象</returns>
public static clsCurrEduCls_SynEN GetObjByid_CurrEduCls_WA_Cache(string strid_CurrEduCls)
{
string strAction = "GetObjByid_CurrEduCls_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsCurrEduCls_SynEN objCurrEduCls_SynEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CurrEduCls"] = strid_CurrEduCls
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objCurrEduCls_SynEN = JsonConvert.DeserializeObject<clsCurrEduCls_SynEN>((string)jobjReturn["ReturnObj"]);
return objCurrEduCls_SynEN;
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
public static string GetFirstID(string strWhereCond)
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
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsCurrEduCls_SynEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsCurrEduCls_SynEN objCurrEduCls_SynEN = null;
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
objCurrEduCls_SynEN = JsonConvert.DeserializeObject<clsCurrEduCls_SynEN>((string)jobjReturn["ReturnObj"]);
return objCurrEduCls_SynEN;
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
 /// <param name = "strid_CurrEduCls">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCurrEduCls_SynEN GetObjByid_CurrEduCls_Cache(string strid_CurrEduCls)
{
if (string.IsNullOrEmpty(strid_CurrEduCls) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsCurrEduCls_SynEN._CurrTabName_S);
List<clsCurrEduCls_SynEN> arrCurrEduCls_SynObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsCurrEduCls_SynEN> arrCurrEduCls_SynObjLst_Sel =
from objCurrEduCls_SynEN in arrCurrEduCls_SynObjLst_Cache
where objCurrEduCls_SynEN.id_CurrEduCls == strid_CurrEduCls
select objCurrEduCls_SynEN;
if (arrCurrEduCls_SynObjLst_Sel.Count() == 0)
{
   clsCurrEduCls_SynEN obj = clsCurrEduCls_SynWApi.GetObjByid_CurrEduCls(strid_CurrEduCls);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrCurrEduCls_SynObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_CurrEduCls">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetEduClsNameByid_CurrEduCls_Cache(string strid_CurrEduCls)
{
if (string.IsNullOrEmpty(strid_CurrEduCls) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsCurrEduCls_SynEN._CurrTabName_S);
List<clsCurrEduCls_SynEN> arrCurrEduCls_SynObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsCurrEduCls_SynEN> arrCurrEduCls_SynObjLst_Sel1 =
from objCurrEduCls_SynEN in arrCurrEduCls_SynObjLst_Cache
where objCurrEduCls_SynEN.id_CurrEduCls == strid_CurrEduCls
select objCurrEduCls_SynEN;
List <clsCurrEduCls_SynEN> arrCurrEduCls_SynObjLst_Sel = new List<clsCurrEduCls_SynEN>();
foreach (clsCurrEduCls_SynEN obj in arrCurrEduCls_SynObjLst_Sel1)
{
arrCurrEduCls_SynObjLst_Sel.Add(obj);
}
if (arrCurrEduCls_SynObjLst_Sel.Count > 0)
{
return arrCurrEduCls_SynObjLst_Sel[0].EduClsName;
}
string strErrMsgForGetObjById = string.Format("在CurrEduCls_Syn对象缓存列表中,找不到记录[id_CurrEduCls = {0}](函数:{1})", strid_CurrEduCls, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsCurrEduCls_SynBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_CurrEduCls">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByid_CurrEduCls_Cache(string strid_CurrEduCls)
{
if (string.IsNullOrEmpty(strid_CurrEduCls) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsCurrEduCls_SynEN._CurrTabName_S);
List<clsCurrEduCls_SynEN> arrCurrEduCls_SynObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsCurrEduCls_SynEN> arrCurrEduCls_SynObjLst_Sel1 =
from objCurrEduCls_SynEN in arrCurrEduCls_SynObjLst_Cache
where objCurrEduCls_SynEN.id_CurrEduCls == strid_CurrEduCls
select objCurrEduCls_SynEN;
List <clsCurrEduCls_SynEN> arrCurrEduCls_SynObjLst_Sel = new List<clsCurrEduCls_SynEN>();
foreach (clsCurrEduCls_SynEN obj in arrCurrEduCls_SynObjLst_Sel1)
{
arrCurrEduCls_SynObjLst_Sel.Add(obj);
}
if (arrCurrEduCls_SynObjLst_Sel.Count > 0)
{
return arrCurrEduCls_SynObjLst_Sel[0].EduClsName;
}
string strErrMsgForGetObjById = string.Format("在CurrEduCls_Syn对象缓存列表中,找不到记录的相关名称[id_CurrEduCls = {0}](函数:{1})", strid_CurrEduCls, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsCurrEduCls_SynBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCurrEduCls_SynEN> GetObjLst(string strWhereCond)
{
 List<clsCurrEduCls_SynEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCurrEduCls_SynEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCurrEduCls_SynEN> GetObjLstById_CurrEduClsLst(List<string> arrId_CurrEduCls)
{
 List<clsCurrEduCls_SynEN> arrObjLst = null; 
string strAction = "GetObjLstById_CurrEduClsLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_CurrEduCls);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsCurrEduCls_SynEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strid_CurrEduCls">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsCurrEduCls_SynEN> GetObjLstById_CurrEduClsLst_Cache(List<string> arrId_CurrEduCls)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsCurrEduCls_SynEN._CurrTabName_S);
List<clsCurrEduCls_SynEN> arrCurrEduCls_SynObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsCurrEduCls_SynEN> arrCurrEduCls_SynObjLst_Sel =
from objCurrEduCls_SynEN in arrCurrEduCls_SynObjLst_Cache
where arrId_CurrEduCls.Contains(objCurrEduCls_SynEN.id_CurrEduCls)
select objCurrEduCls_SynEN;
return arrCurrEduCls_SynObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCurrEduCls_SynEN> GetObjLstById_CurrEduClsLst_WA_Cache(List<string> arrId_CurrEduCls)
{
 List<clsCurrEduCls_SynEN> arrObjLst = null; 
string strAction = "GetObjLstById_CurrEduClsLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_CurrEduCls);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsCurrEduCls_SynEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCurrEduCls_SynEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsCurrEduCls_SynEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCurrEduCls_SynEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCurrEduCls_SynEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsCurrEduCls_SynEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCurrEduCls_SynEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCurrEduCls_SynEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsCurrEduCls_SynEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCurrEduCls_SynEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCurrEduCls_SynEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsCurrEduCls_SynEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCurrEduCls_SynEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(string strid_CurrEduCls)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsCurrEduCls_SynEN objCurrEduCls_SynEN = clsCurrEduCls_SynWApi.GetObjByid_CurrEduCls(strid_CurrEduCls);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strid_CurrEduCls.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsCurrEduCls_SynWApi.ReFreshCache();
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
public static int DelCurrEduCls_Syns(List<string> arrid_CurrEduCls)
{
string strAction = "DelCurrEduCls_Syns";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrid_CurrEduCls);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsCurrEduCls_SynWApi.ReFreshCache();
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
public static int DelCurrEduCls_SynsByCond(string strWhereCond)
{
string strAction = "DelCurrEduCls_SynsByCond";
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
public static bool AddNewRecord(clsCurrEduCls_SynEN objCurrEduCls_SynEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCurrEduCls_SynEN>(objCurrEduCls_SynEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduCls_SynWApi.ReFreshCache();
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
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithMaxId)
 /// </summary>
 /// <returns>是否成功?</returns>
public static string AddNewRecordWithMaxId(clsCurrEduCls_SynEN objCurrEduCls_SynEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCurrEduCls_SynEN>(objCurrEduCls_SynEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduCls_SynWApi.ReFreshCache();
var strid_CurrEduCls = (string)jobjReturn["ReturnStr"];
return strid_CurrEduCls;
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
public static bool UpdateRecord(clsCurrEduCls_SynEN objCurrEduCls_SynEN)
{
if (string.IsNullOrEmpty(objCurrEduCls_SynEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCurrEduCls_SynEN.id_CurrEduCls, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCurrEduCls_SynEN>(objCurrEduCls_SynEN);
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
 /// <param name = "objCurrEduCls_SynEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objCurrEduCls_SynEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCurrEduCls_SynEN.id_CurrEduCls, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCurrEduCls_SynEN.id_CurrEduCls, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCurrEduCls_SynEN>(objCurrEduCls_SynEN);
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
public static bool IsExist(string strid_CurrEduCls)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CurrEduCls"] = strid_CurrEduCls
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
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId()
{
string strAction = "GetMaxStrId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
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
string strMsg = string.Format("获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix(string strPrefix)
{
//检测记录是否存在
string strAction = "GetMaxStrIdByPrefix";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strPrefix", strPrefix);
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
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
string strMsg = string.Format("根据前缀获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objCurrEduCls_SynENS">源对象</param>
 /// <param name = "objCurrEduCls_SynENT">目标对象</param>
 public static void CopyTo(clsCurrEduCls_SynEN objCurrEduCls_SynENS, clsCurrEduCls_SynEN objCurrEduCls_SynENT)
{
try
{
objCurrEduCls_SynENT.id_CurrEduCls = objCurrEduCls_SynENS.id_CurrEduCls; //当前教学班流水号
objCurrEduCls_SynENT.CurrEduClsId = objCurrEduCls_SynENS.CurrEduClsId; //当前教学班Id
objCurrEduCls_SynENT.EduClsName = objCurrEduCls_SynENS.EduClsName; //教学班名称
objCurrEduCls_SynENT.EduClsTypeId = objCurrEduCls_SynENS.EduClsTypeId; //教学班类型代号
objCurrEduCls_SynENT.CourseId = objCurrEduCls_SynENS.CourseId; //课程Id
objCurrEduCls_SynENT.TeachingSolutionId = objCurrEduCls_SynENS.TeachingSolutionId; //教学方案Id
objCurrEduCls_SynENT.id_XzCollege = objCurrEduCls_SynENS.id_XzCollege; //学院流水号
objCurrEduCls_SynENT.id_Major = objCurrEduCls_SynENS.id_Major; //专业流水号
objCurrEduCls_SynENT.id_EduWay = objCurrEduCls_SynENS.id_EduWay; //教学方式流水号
objCurrEduCls_SynENT.id_ClassRoomType = objCurrEduCls_SynENS.id_ClassRoomType; //教室类型流水号
objCurrEduCls_SynENT.TotalLessonQty = objCurrEduCls_SynENS.TotalLessonQty; //总课时数
objCurrEduCls_SynENT.MaxStuQty = objCurrEduCls_SynENS.MaxStuQty; //最大学生数
objCurrEduCls_SynENT.CurrentStuQty = objCurrEduCls_SynENS.CurrentStuQty; //当前学生数
objCurrEduCls_SynENT.WeekQty = objCurrEduCls_SynENS.WeekQty; //总周数
objCurrEduCls_SynENT.ScheUnitPW = objCurrEduCls_SynENS.ScheUnitPW; //周排课次数
objCurrEduCls_SynENT.WeekStatusID = objCurrEduCls_SynENS.WeekStatusID; //周状态编号(单,双,全周)
objCurrEduCls_SynENT.CustomerWeek = objCurrEduCls_SynENS.CustomerWeek; //自定义上课周
objCurrEduCls_SynENT.IsCompleteScore = objCurrEduCls_SynENS.IsCompleteScore; //是否成绩齐全
objCurrEduCls_SynENT.id_ExecPlan = objCurrEduCls_SynENS.id_ExecPlan; //执行计划流水号
objCurrEduCls_SynENT.LessonQtyPerWeek = objCurrEduCls_SynENS.LessonQtyPerWeek; //周课时数
objCurrEduCls_SynENT.Mark = objCurrEduCls_SynENS.Mark; //获得学分
objCurrEduCls_SynENT.CheckClassRoom = objCurrEduCls_SynENS.CheckClassRoom; //检查教室结果
objCurrEduCls_SynENT.CheckAdminCls = objCurrEduCls_SynENS.CheckAdminCls; //检查行政班结果
objCurrEduCls_SynENT.CheckTeacher = objCurrEduCls_SynENS.CheckTeacher; //检查教师结果
objCurrEduCls_SynENT.EditLocked = objCurrEduCls_SynENS.EditLocked; //编辑锁定
objCurrEduCls_SynENT.Sched = objCurrEduCls_SynENS.Sched; //是否排课
objCurrEduCls_SynENT.id_UniZone = objCurrEduCls_SynENS.id_UniZone; //校区流水号
objCurrEduCls_SynENT.Locked = objCurrEduCls_SynENS.Locked; //锁定状态
objCurrEduCls_SynENT.id_GradeBase = objCurrEduCls_SynENS.id_GradeBase; //年级流水号
objCurrEduCls_SynENT.IsEffective = objCurrEduCls_SynENS.IsEffective; //是否有效
objCurrEduCls_SynENT.IsForPaperReading = objCurrEduCls_SynENS.IsForPaperReading; //是否参与论文阅读
objCurrEduCls_SynENT.IsUnDeterminedClsRm = objCurrEduCls_SynENS.IsUnDeterminedClsRm; //是否待定教室
objCurrEduCls_SynENT.SchoolYear = objCurrEduCls_SynENS.SchoolYear; //学年
objCurrEduCls_SynENT.SchoolTerm = objCurrEduCls_SynENS.SchoolTerm; //学期
objCurrEduCls_SynENT.ArrangeCourseMemo = objCurrEduCls_SynENS.ArrangeCourseMemo; //排课备注
objCurrEduCls_SynENT.id_CourseType = objCurrEduCls_SynENS.id_CourseType; //课程类型流水号
objCurrEduCls_SynENT.ExportDate = objCurrEduCls_SynENS.ExportDate; //导出日期
objCurrEduCls_SynENT.IsDegree = objCurrEduCls_SynENS.IsDegree; //是否学位课
objCurrEduCls_SynENT.id_ScoreType = objCurrEduCls_SynENS.id_ScoreType; //成绩类型流水号
objCurrEduCls_SynENT.GetScoreWayId = objCurrEduCls_SynENS.GetScoreWayId; //获得成绩方式Id
objCurrEduCls_SynENT.IsProportionalCtrl = objCurrEduCls_SynENS.IsProportionalCtrl; //是否比例控制
objCurrEduCls_SynENT.id_ExamType = objCurrEduCls_SynENS.id_ExamType; //考试方式流水号
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
objCurrEduCls_SynENT.id_EduClassInPk = objCurrEduCls_SynENS.id_EduClassInPk; //id_EduClassInPk
objCurrEduCls_SynENT.PkWeekTime = objCurrEduCls_SynENS.PkWeekTime; //排课时间
objCurrEduCls_SynENT.PkClassRooms = objCurrEduCls_SynENS.PkClassRooms; //排课教室
objCurrEduCls_SynENT.BeginWeek = objCurrEduCls_SynENS.BeginWeek; //开始周
objCurrEduCls_SynENT.TeacherNames = objCurrEduCls_SynENS.TeacherNames; //教师姓名
objCurrEduCls_SynENT.IsSynch = objCurrEduCls_SynENS.IsSynch; //是否同步
objCurrEduCls_SynENT.SynchDate = objCurrEduCls_SynENS.SynchDate; //同步日期
objCurrEduCls_SynENT.ModifyDate = objCurrEduCls_SynENS.ModifyDate; //修改日期
objCurrEduCls_SynENT.ModifyUserID = objCurrEduCls_SynENS.ModifyUserID; //修改人
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
public static DataTable ToDataTable(List<clsCurrEduCls_SynEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsCurrEduCls_SynEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsCurrEduCls_SynEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsCurrEduCls_SynEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsCurrEduCls_SynEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsCurrEduCls_SynEN.AttributeName)
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
if (clsCurrEduCls_SynWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCurrEduCls_SynWApi没有刷新缓存机制(clsCurrEduCls_SynWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_CurrEduCls");
//if (arrCurrEduCls_SynObjLst_Cache == null)
//{
//arrCurrEduCls_SynObjLst_Cache = await clsCurrEduCls_SynWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsCurrEduCls_SynEN._CurrTabName_S);
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
if (clsCurrEduCls_SynWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCurrEduCls_SynEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsCurrEduCls_SynWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCurrEduCls_SynEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsCurrEduCls_SynEN._CurrTabName_S);
List<clsCurrEduCls_SynEN> arrCurrEduCls_SynObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrCurrEduCls_SynObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsCurrEduCls_SynEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conCurrEduCls_Syn.id_CurrEduCls, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls_Syn.CurrEduClsId, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls_Syn.EduClsName, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls_Syn.EduClsTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls_Syn.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls_Syn.TeachingSolutionId, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls_Syn.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls_Syn.id_Major, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls_Syn.id_EduWay, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls_Syn.id_ClassRoomType, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls_Syn.TotalLessonQty, Type.GetType("System.Int32"));
objDT.Columns.Add(conCurrEduCls_Syn.MaxStuQty, Type.GetType("System.Int32"));
objDT.Columns.Add(conCurrEduCls_Syn.CurrentStuQty, Type.GetType("System.Int32"));
objDT.Columns.Add(conCurrEduCls_Syn.WeekQty, Type.GetType("System.Int32"));
objDT.Columns.Add(conCurrEduCls_Syn.ScheUnitPW, Type.GetType("System.Int16"));
objDT.Columns.Add(conCurrEduCls_Syn.WeekStatusID, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls_Syn.CustomerWeek, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls_Syn.IsCompleteScore, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCurrEduCls_Syn.id_ExecPlan, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls_Syn.LessonQtyPerWeek, Type.GetType("System.Int16"));
objDT.Columns.Add(conCurrEduCls_Syn.Mark, Type.GetType("System.Decimal"));
objDT.Columns.Add(conCurrEduCls_Syn.CheckClassRoom, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls_Syn.CheckAdminCls, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls_Syn.CheckTeacher, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls_Syn.EditLocked, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCurrEduCls_Syn.Sched, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCurrEduCls_Syn.id_UniZone, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls_Syn.Locked, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCurrEduCls_Syn.id_GradeBase, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls_Syn.IsEffective, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCurrEduCls_Syn.IsForPaperReading, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCurrEduCls_Syn.IsUnDeterminedClsRm, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCurrEduCls_Syn.SchoolYear, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls_Syn.SchoolTerm, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls_Syn.ArrangeCourseMemo, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls_Syn.id_CourseType, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls_Syn.ExportDate, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls_Syn.IsDegree, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCurrEduCls_Syn.id_ScoreType, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls_Syn.GetScoreWayId, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls_Syn.IsProportionalCtrl, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCurrEduCls_Syn.id_ExamType, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls_Syn.ExamPortion, Type.GetType("System.Int16"));
objDT.Columns.Add(conCurrEduCls_Syn.MidExamScorePortion, Type.GetType("System.Int16"));
objDT.Columns.Add(conCurrEduCls_Syn.IsClearScore, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCurrEduCls_Syn.IsGeneratePwd, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCurrEduCls_Syn.GeneratePwdDate, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls_Syn.IsExportToGP, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCurrEduCls_Syn.IsExportToGPWeb, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCurrEduCls_Syn.IsReservedDecimal, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCurrEduCls_Syn.ExamTime, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls_Syn.CheckState, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCurrEduCls_Syn.CheckDate, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls_Syn.id_EduClassInPk, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls_Syn.PkWeekTime, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls_Syn.PkClassRooms, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls_Syn.BeginWeek, Type.GetType("System.Int16"));
objDT.Columns.Add(conCurrEduCls_Syn.TeacherNames, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls_Syn.IsSynch, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCurrEduCls_Syn.SynchDate, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls_Syn.ModifyDate, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls_Syn.ModifyUserID, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls_Syn.Memo, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls_Syn.SignInDate, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls_Syn.SignInStateID, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls_Syn.SignInUser, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls_Syn.SynchToWebUser, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls_Syn.IsSynchToWeb, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCurrEduCls_Syn.SynchToWebDate, Type.GetType("System.String"));
foreach (clsCurrEduCls_SynEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conCurrEduCls_Syn.id_CurrEduCls] = objInFor[conCurrEduCls_Syn.id_CurrEduCls];
objDR[conCurrEduCls_Syn.CurrEduClsId] = objInFor[conCurrEduCls_Syn.CurrEduClsId];
objDR[conCurrEduCls_Syn.EduClsName] = objInFor[conCurrEduCls_Syn.EduClsName];
objDR[conCurrEduCls_Syn.EduClsTypeId] = objInFor[conCurrEduCls_Syn.EduClsTypeId];
objDR[conCurrEduCls_Syn.CourseId] = objInFor[conCurrEduCls_Syn.CourseId];
objDR[conCurrEduCls_Syn.TeachingSolutionId] = objInFor[conCurrEduCls_Syn.TeachingSolutionId];
objDR[conCurrEduCls_Syn.id_XzCollege] = objInFor[conCurrEduCls_Syn.id_XzCollege];
objDR[conCurrEduCls_Syn.id_Major] = objInFor[conCurrEduCls_Syn.id_Major];
objDR[conCurrEduCls_Syn.id_EduWay] = objInFor[conCurrEduCls_Syn.id_EduWay];
objDR[conCurrEduCls_Syn.id_ClassRoomType] = objInFor[conCurrEduCls_Syn.id_ClassRoomType];
objDR[conCurrEduCls_Syn.TotalLessonQty] = objInFor[conCurrEduCls_Syn.TotalLessonQty];
objDR[conCurrEduCls_Syn.MaxStuQty] = objInFor[conCurrEduCls_Syn.MaxStuQty];
objDR[conCurrEduCls_Syn.CurrentStuQty] = objInFor[conCurrEduCls_Syn.CurrentStuQty];
objDR[conCurrEduCls_Syn.WeekQty] = objInFor[conCurrEduCls_Syn.WeekQty];
objDR[conCurrEduCls_Syn.ScheUnitPW] = objInFor[conCurrEduCls_Syn.ScheUnitPW];
objDR[conCurrEduCls_Syn.WeekStatusID] = objInFor[conCurrEduCls_Syn.WeekStatusID];
objDR[conCurrEduCls_Syn.CustomerWeek] = objInFor[conCurrEduCls_Syn.CustomerWeek];
objDR[conCurrEduCls_Syn.IsCompleteScore] = objInFor[conCurrEduCls_Syn.IsCompleteScore];
objDR[conCurrEduCls_Syn.id_ExecPlan] = objInFor[conCurrEduCls_Syn.id_ExecPlan];
objDR[conCurrEduCls_Syn.LessonQtyPerWeek] = objInFor[conCurrEduCls_Syn.LessonQtyPerWeek];
objDR[conCurrEduCls_Syn.Mark] = objInFor[conCurrEduCls_Syn.Mark];
objDR[conCurrEduCls_Syn.CheckClassRoom] = objInFor[conCurrEduCls_Syn.CheckClassRoom];
objDR[conCurrEduCls_Syn.CheckAdminCls] = objInFor[conCurrEduCls_Syn.CheckAdminCls];
objDR[conCurrEduCls_Syn.CheckTeacher] = objInFor[conCurrEduCls_Syn.CheckTeacher];
objDR[conCurrEduCls_Syn.EditLocked] = objInFor[conCurrEduCls_Syn.EditLocked];
objDR[conCurrEduCls_Syn.Sched] = objInFor[conCurrEduCls_Syn.Sched];
objDR[conCurrEduCls_Syn.id_UniZone] = objInFor[conCurrEduCls_Syn.id_UniZone];
objDR[conCurrEduCls_Syn.Locked] = objInFor[conCurrEduCls_Syn.Locked];
objDR[conCurrEduCls_Syn.id_GradeBase] = objInFor[conCurrEduCls_Syn.id_GradeBase];
objDR[conCurrEduCls_Syn.IsEffective] = objInFor[conCurrEduCls_Syn.IsEffective];
objDR[conCurrEduCls_Syn.IsForPaperReading] = objInFor[conCurrEduCls_Syn.IsForPaperReading];
objDR[conCurrEduCls_Syn.IsUnDeterminedClsRm] = objInFor[conCurrEduCls_Syn.IsUnDeterminedClsRm];
objDR[conCurrEduCls_Syn.SchoolYear] = objInFor[conCurrEduCls_Syn.SchoolYear];
objDR[conCurrEduCls_Syn.SchoolTerm] = objInFor[conCurrEduCls_Syn.SchoolTerm];
objDR[conCurrEduCls_Syn.ArrangeCourseMemo] = objInFor[conCurrEduCls_Syn.ArrangeCourseMemo];
objDR[conCurrEduCls_Syn.id_CourseType] = objInFor[conCurrEduCls_Syn.id_CourseType];
objDR[conCurrEduCls_Syn.ExportDate] = objInFor[conCurrEduCls_Syn.ExportDate];
objDR[conCurrEduCls_Syn.IsDegree] = objInFor[conCurrEduCls_Syn.IsDegree];
objDR[conCurrEduCls_Syn.id_ScoreType] = objInFor[conCurrEduCls_Syn.id_ScoreType];
objDR[conCurrEduCls_Syn.GetScoreWayId] = objInFor[conCurrEduCls_Syn.GetScoreWayId];
objDR[conCurrEduCls_Syn.IsProportionalCtrl] = objInFor[conCurrEduCls_Syn.IsProportionalCtrl];
objDR[conCurrEduCls_Syn.id_ExamType] = objInFor[conCurrEduCls_Syn.id_ExamType];
objDR[conCurrEduCls_Syn.ExamPortion] = objInFor[conCurrEduCls_Syn.ExamPortion];
objDR[conCurrEduCls_Syn.MidExamScorePortion] = objInFor[conCurrEduCls_Syn.MidExamScorePortion];
objDR[conCurrEduCls_Syn.IsClearScore] = objInFor[conCurrEduCls_Syn.IsClearScore];
objDR[conCurrEduCls_Syn.IsGeneratePwd] = objInFor[conCurrEduCls_Syn.IsGeneratePwd];
objDR[conCurrEduCls_Syn.GeneratePwdDate] = objInFor[conCurrEduCls_Syn.GeneratePwdDate];
objDR[conCurrEduCls_Syn.IsExportToGP] = objInFor[conCurrEduCls_Syn.IsExportToGP];
objDR[conCurrEduCls_Syn.IsExportToGPWeb] = objInFor[conCurrEduCls_Syn.IsExportToGPWeb];
objDR[conCurrEduCls_Syn.IsReservedDecimal] = objInFor[conCurrEduCls_Syn.IsReservedDecimal];
objDR[conCurrEduCls_Syn.ExamTime] = objInFor[conCurrEduCls_Syn.ExamTime];
objDR[conCurrEduCls_Syn.CheckState] = objInFor[conCurrEduCls_Syn.CheckState];
objDR[conCurrEduCls_Syn.CheckDate] = objInFor[conCurrEduCls_Syn.CheckDate];
objDR[conCurrEduCls_Syn.id_EduClassInPk] = objInFor[conCurrEduCls_Syn.id_EduClassInPk];
objDR[conCurrEduCls_Syn.PkWeekTime] = objInFor[conCurrEduCls_Syn.PkWeekTime];
objDR[conCurrEduCls_Syn.PkClassRooms] = objInFor[conCurrEduCls_Syn.PkClassRooms];
objDR[conCurrEduCls_Syn.BeginWeek] = objInFor[conCurrEduCls_Syn.BeginWeek];
objDR[conCurrEduCls_Syn.TeacherNames] = objInFor[conCurrEduCls_Syn.TeacherNames];
objDR[conCurrEduCls_Syn.IsSynch] = objInFor[conCurrEduCls_Syn.IsSynch];
objDR[conCurrEduCls_Syn.SynchDate] = objInFor[conCurrEduCls_Syn.SynchDate];
objDR[conCurrEduCls_Syn.ModifyDate] = objInFor[conCurrEduCls_Syn.ModifyDate];
objDR[conCurrEduCls_Syn.ModifyUserID] = objInFor[conCurrEduCls_Syn.ModifyUserID];
objDR[conCurrEduCls_Syn.Memo] = objInFor[conCurrEduCls_Syn.Memo];
objDR[conCurrEduCls_Syn.SignInDate] = objInFor[conCurrEduCls_Syn.SignInDate];
objDR[conCurrEduCls_Syn.SignInStateID] = objInFor[conCurrEduCls_Syn.SignInStateID];
objDR[conCurrEduCls_Syn.SignInUser] = objInFor[conCurrEduCls_Syn.SignInUser];
objDR[conCurrEduCls_Syn.SynchToWebUser] = objInFor[conCurrEduCls_Syn.SynchToWebUser];
objDR[conCurrEduCls_Syn.IsSynchToWeb] = objInFor[conCurrEduCls_Syn.IsSynchToWeb];
objDR[conCurrEduCls_Syn.SynchToWebDate] = objInFor[conCurrEduCls_Syn.SynchToWebDate];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 当前教学班_动态(CurrEduCls_Syn)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4CurrEduCls_Syn : clsCommFun4BL
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
clsCurrEduCls_SynWApi.ReFreshThisCache();
clsvCurrEduCls_SynWApi.ReFreshThisCache();
}
}

}