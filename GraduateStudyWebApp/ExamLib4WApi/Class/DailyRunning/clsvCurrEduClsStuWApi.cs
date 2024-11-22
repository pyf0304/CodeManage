
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCurrEduClsStuWApi
 表名:vCurrEduClsStu(01120127)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:44:31
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
public static class clsvCurrEduClsStuWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStuEN Setid_EduClsStu(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, long lngid_EduClsStu, string strComparisonOp="")
	{
objvCurrEduClsStuEN.id_EduClsStu = lngid_EduClsStu; //教学班学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.id_EduClsStu) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.id_EduClsStu, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.id_EduClsStu] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStuEN Setid_CurrEduCls(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strid_CurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_CurrEduCls, convCurrEduClsStu.id_CurrEduCls);
clsCheckSql.CheckFieldLen(strid_CurrEduCls, 8, convCurrEduClsStu.id_CurrEduCls);
clsCheckSql.CheckFieldForeignKey(strid_CurrEduCls, 8, convCurrEduClsStu.id_CurrEduCls);
objvCurrEduClsStuEN.id_CurrEduCls = strid_CurrEduCls; //当前教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.id_CurrEduCls) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.id_CurrEduCls, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.id_CurrEduCls] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStuEN SetCurrEduClsId(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strCurrEduClsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCurrEduClsId, 15, convCurrEduClsStu.CurrEduClsId);
objvCurrEduClsStuEN.CurrEduClsId = strCurrEduClsId; //当前教学班Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.CurrEduClsId) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.CurrEduClsId, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.CurrEduClsId] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStuEN SetEduClsName(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strEduClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEduClsName, convCurrEduClsStu.EduClsName);
clsCheckSql.CheckFieldLen(strEduClsName, 100, convCurrEduClsStu.EduClsName);
objvCurrEduClsStuEN.EduClsName = strEduClsName; //教学班名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.EduClsName) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.EduClsName, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.EduClsName] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStuEN SetCourseId(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convCurrEduClsStu.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convCurrEduClsStu.CourseId);
objvCurrEduClsStuEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.CourseId) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.CourseId, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.CourseId] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStuEN SetCourseCode(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strCourseCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convCurrEduClsStu.CourseCode);
objvCurrEduClsStuEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.CourseCode) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.CourseCode, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.CourseCode] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStuEN SetCourseName(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convCurrEduClsStu.CourseName);
objvCurrEduClsStuEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.CourseName) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.CourseName, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.CourseName] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStuEN SetTeachingSolutionId(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strTeachingSolutionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingSolutionId, 8, convCurrEduClsStu.TeachingSolutionId);
clsCheckSql.CheckFieldForeignKey(strTeachingSolutionId, 8, convCurrEduClsStu.TeachingSolutionId);
objvCurrEduClsStuEN.TeachingSolutionId = strTeachingSolutionId; //教学方案Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.TeachingSolutionId) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.TeachingSolutionId, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.TeachingSolutionId] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStuEN SetTeachingSolutionName(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strTeachingSolutionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingSolutionName, 100, convCurrEduClsStu.TeachingSolutionName);
objvCurrEduClsStuEN.TeachingSolutionName = strTeachingSolutionName; //教学方案名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.TeachingSolutionName) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.TeachingSolutionName, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.TeachingSolutionName] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStuEN Setid_XzCollege(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convCurrEduClsStu.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convCurrEduClsStu.id_XzCollege);
objvCurrEduClsStuEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.id_XzCollege) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.id_XzCollege, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.id_XzCollege] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStuEN SetCollegeID(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convCurrEduClsStu.CollegeID);
objvCurrEduClsStuEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.CollegeID) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.CollegeID, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.CollegeID] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStuEN SetCollegeName(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convCurrEduClsStu.CollegeName);
objvCurrEduClsStuEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.CollegeName) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.CollegeName, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.CollegeName] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStuEN SetLessonQtyPerWeek(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, short shtLessonQtyPerWeek, string strComparisonOp="")
	{
objvCurrEduClsStuEN.LessonQtyPerWeek = shtLessonQtyPerWeek; //周课时数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.LessonQtyPerWeek) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.LessonQtyPerWeek, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.LessonQtyPerWeek] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStuEN SetMark(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, double dblMark, string strComparisonOp="")
	{
objvCurrEduClsStuEN.Mark = dblMark; //获得学分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.Mark) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.Mark, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.Mark] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStuEN Setid_UniZone(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strid_UniZone, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_UniZone, 4, convCurrEduClsStu.id_UniZone);
clsCheckSql.CheckFieldForeignKey(strid_UniZone, 4, convCurrEduClsStu.id_UniZone);
objvCurrEduClsStuEN.id_UniZone = strid_UniZone; //校区流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.id_UniZone) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.id_UniZone, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.id_UniZone] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStuEN SetGradeBaseName(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strGradeBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convCurrEduClsStu.GradeBaseName);
objvCurrEduClsStuEN.GradeBaseName = strGradeBaseName; //年级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.GradeBaseName) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.GradeBaseName, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.GradeBaseName] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStuEN SetIsEffective(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, bool bolIsEffective, string strComparisonOp="")
	{
objvCurrEduClsStuEN.IsEffective = bolIsEffective; //是否有效
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.IsEffective) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.IsEffective, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.IsEffective] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStuEN Setid_CourseType(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strid_CourseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_CourseType, 4, convCurrEduClsStu.id_CourseType);
clsCheckSql.CheckFieldForeignKey(strid_CourseType, 4, convCurrEduClsStu.id_CourseType);
objvCurrEduClsStuEN.id_CourseType = strid_CourseType; //课程类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.id_CourseType) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.id_CourseType, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.id_CourseType] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStuEN SetCourseTypeID(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strCourseTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseTypeID, 4, convCurrEduClsStu.CourseTypeID);
clsCheckSql.CheckFieldForeignKey(strCourseTypeID, 4, convCurrEduClsStu.CourseTypeID);
objvCurrEduClsStuEN.CourseTypeID = strCourseTypeID; //课程类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.CourseTypeID) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.CourseTypeID, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.CourseTypeID] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStuEN SetCourseTypeName(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strCourseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseTypeName, 30, convCurrEduClsStu.CourseTypeName);
objvCurrEduClsStuEN.CourseTypeName = strCourseTypeName; //课程类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.CourseTypeName) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.CourseTypeName, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.CourseTypeName] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStuEN SetIsDegree(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, bool bolIsDegree, string strComparisonOp="")
	{
objvCurrEduClsStuEN.IsDegree = bolIsDegree; //是否学位课
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.IsDegree) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.IsDegree, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.IsDegree] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStuEN SetCurrStuNum(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, int intCurrStuNum, string strComparisonOp="")
	{
objvCurrEduClsStuEN.CurrStuNum = intCurrStuNum; //当前学生数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.CurrStuNum) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.CurrStuNum, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.CurrStuNum] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStuEN Setid_Stu(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strid_Stu, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Stu, 8, convCurrEduClsStu.id_Stu);
clsCheckSql.CheckFieldForeignKey(strid_Stu, 8, convCurrEduClsStu.id_Stu);
objvCurrEduClsStuEN.id_Stu = strid_Stu; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.id_Stu) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.id_Stu, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.id_Stu] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStuEN SetStuID(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strStuID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuID, 20, convCurrEduClsStu.StuID);
objvCurrEduClsStuEN.StuID = strStuID; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.StuID) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.StuID, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.StuID] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStuEN SetStuName(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strStuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuName, 50, convCurrEduClsStu.StuName);
objvCurrEduClsStuEN.StuName = strStuName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.StuName) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.StuName, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.StuName] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStuEN Setid_Sex(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strid_Sex, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Sex, convCurrEduClsStu.id_Sex);
clsCheckSql.CheckFieldLen(strid_Sex, 4, convCurrEduClsStu.id_Sex);
clsCheckSql.CheckFieldForeignKey(strid_Sex, 4, convCurrEduClsStu.id_Sex);
objvCurrEduClsStuEN.id_Sex = strid_Sex; //性别流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.id_Sex) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.id_Sex, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.id_Sex] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStuEN SetSexDesc(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strSexDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSexDesc, 10, convCurrEduClsStu.SexDesc);
objvCurrEduClsStuEN.SexDesc = strSexDesc; //性别名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.SexDesc) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.SexDesc, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.SexDesc] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStuEN SetMajorID(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strMajorID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorID, 4, convCurrEduClsStu.MajorID);
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convCurrEduClsStu.MajorID);
objvCurrEduClsStuEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.MajorID) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.MajorID, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.MajorID] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStuEN SetMajorName(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convCurrEduClsStu.MajorName);
objvCurrEduClsStuEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.MajorName) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.MajorName, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.MajorName] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStuEN Setid_AdminCls(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strid_AdminCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_AdminCls, 8, convCurrEduClsStu.id_AdminCls);
clsCheckSql.CheckFieldForeignKey(strid_AdminCls, 8, convCurrEduClsStu.id_AdminCls);
objvCurrEduClsStuEN.id_AdminCls = strid_AdminCls; //行政班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.id_AdminCls) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.id_AdminCls, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.id_AdminCls] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStuEN SetBirthday(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strBirthday, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strBirthday, 8, convCurrEduClsStu.Birthday);
clsCheckSql.CheckFieldForeignKey(strBirthday, 8, convCurrEduClsStu.Birthday);
objvCurrEduClsStuEN.Birthday = strBirthday; //出生日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.Birthday) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.Birthday, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.Birthday] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStuEN SetEduClsStuStateID(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strEduClsStuStateID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduClsStuStateID, 2, convCurrEduClsStu.EduClsStuStateID);
clsCheckSql.CheckFieldForeignKey(strEduClsStuStateID, 2, convCurrEduClsStu.EduClsStuStateID);
objvCurrEduClsStuEN.EduClsStuStateID = strEduClsStuStateID; //教学班学生状态编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.EduClsStuStateID) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.EduClsStuStateID, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.EduClsStuStateID] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStuEN SetGetScoreTimes(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, short shtGetScoreTimes, string strComparisonOp="")
	{
objvCurrEduClsStuEN.GetScoreTimes = shtGetScoreTimes; //获得成绩次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.GetScoreTimes) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.GetScoreTimes, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.GetScoreTimes] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStuEN SetScore(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, double dblScore, string strComparisonOp="")
	{
objvCurrEduClsStuEN.Score = dblScore; //得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.Score) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.Score, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.Score] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStuEN SetTotalScores(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, double dblTotalScores, string strComparisonOp="")
	{
objvCurrEduClsStuEN.TotalScores = dblTotalScores; //总分值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.TotalScores) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.TotalScores, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.TotalScores] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStuEN SetRanking(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, int intRanking, string strComparisonOp="")
	{
objvCurrEduClsStuEN.Ranking = intRanking; //名次
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.Ranking) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.Ranking, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.Ranking] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStuEN SetPercentile(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, double dblPercentile, string strComparisonOp="")
	{
objvCurrEduClsStuEN.Percentile = dblPercentile; //百分位
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.Percentile) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.Percentile, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.Percentile] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStuEN SetConfirmed(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, bool bolConfirmed, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolConfirmed, convCurrEduClsStu.Confirmed);
objvCurrEduClsStuEN.Confirmed = bolConfirmed; //是否确认
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.Confirmed) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.Confirmed, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.Confirmed] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStuEN SetSchoolTerm(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strSchoolTerm, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, convCurrEduClsStu.SchoolTerm);
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, convCurrEduClsStu.SchoolTerm);
objvCurrEduClsStuEN.SchoolTerm = strSchoolTerm; //学期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.SchoolTerm) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.SchoolTerm, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.SchoolTerm] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStuEN SetSchoolYear(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strSchoolYear, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, convCurrEduClsStu.SchoolYear);
objvCurrEduClsStuEN.SchoolYear = strSchoolYear; //学年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.SchoolYear) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.SchoolYear, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.SchoolYear] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStuEN SetSignInDate(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strSignInDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSignInDate, 20, convCurrEduClsStu.SignInDate);
objvCurrEduClsStuEN.SignInDate = strSignInDate; //签入时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.SignInDate) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.SignInDate, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.SignInDate] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStuEN SetSignInStateID(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strSignInStateID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSignInStateID, 2, convCurrEduClsStu.SignInStateID);
clsCheckSql.CheckFieldForeignKey(strSignInStateID, 2, convCurrEduClsStu.SignInStateID);
objvCurrEduClsStuEN.SignInStateID = strSignInStateID; //签入状态表流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.SignInStateID) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.SignInStateID, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.SignInStateID] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStuEN SetSignInUser(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strSignInUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSignInUser, 18, convCurrEduClsStu.SignInUser);
objvCurrEduClsStuEN.SignInUser = strSignInUser; //签入人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.SignInUser) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.SignInUser, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.SignInUser] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStuEN SetModifyDate(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strModifyDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyDate, 20, convCurrEduClsStu.ModifyDate);
objvCurrEduClsStuEN.ModifyDate = strModifyDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.ModifyDate) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.ModifyDate, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.ModifyDate] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStuEN SetModifyUserID(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strModifyUserID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyUserID, 18, convCurrEduClsStu.ModifyUserID);
objvCurrEduClsStuEN.ModifyUserID = strModifyUserID; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.ModifyUserID) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.ModifyUserID, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.ModifyUserID] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStuEN SetCollegeName4Stu(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strCollegeName4Stu, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName4Stu, 100, convCurrEduClsStu.CollegeName4Stu);
objvCurrEduClsStuEN.CollegeName4Stu = strCollegeName4Stu; //CollegeName4Stu
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.CollegeName4Stu) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.CollegeName4Stu, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.CollegeName4Stu] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStuEN SetEduClsTypeName(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strEduClsTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduClsTypeName, 100, convCurrEduClsStu.EduClsTypeName);
objvCurrEduClsStuEN.EduClsTypeName = strEduClsTypeName; //教学班类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.EduClsTypeName) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.EduClsTypeName, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.EduClsTypeName] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStuEN SetIsSynScore(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, bool bolIsSynScore, string strComparisonOp="")
	{
objvCurrEduClsStuEN.IsSynScore = bolIsSynScore; //是否同步成绩
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.IsSynScore) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.IsSynScore, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.IsSynScore] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduClsStuEN SetEduClsTypeId(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strEduClsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduClsTypeId, 4, convCurrEduClsStu.EduClsTypeId);
clsCheckSql.CheckFieldForeignKey(strEduClsTypeId, 4, convCurrEduClsStu.EduClsTypeId);
objvCurrEduClsStuEN.EduClsTypeId = strEduClsTypeId; //教学班类型代号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.EduClsTypeId) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.EduClsTypeId, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.EduClsTypeId] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCurrEduClsStuEN objvCurrEduClsStu_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCurrEduClsStu_Cond.IsUpdated(convCurrEduClsStu.id_EduClsStu) == true)
{
string strComparisonOp_id_EduClsStu = objvCurrEduClsStu_Cond.dicFldComparisonOp[convCurrEduClsStu.id_EduClsStu];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduClsStu.id_EduClsStu, objvCurrEduClsStu_Cond.id_EduClsStu, strComparisonOp_id_EduClsStu);
}
if (objvCurrEduClsStu_Cond.IsUpdated(convCurrEduClsStu.id_CurrEduCls) == true)
{
string strComparisonOp_id_CurrEduCls = objvCurrEduClsStu_Cond.dicFldComparisonOp[convCurrEduClsStu.id_CurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.id_CurrEduCls, objvCurrEduClsStu_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (objvCurrEduClsStu_Cond.IsUpdated(convCurrEduClsStu.CurrEduClsId) == true)
{
string strComparisonOp_CurrEduClsId = objvCurrEduClsStu_Cond.dicFldComparisonOp[convCurrEduClsStu.CurrEduClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.CurrEduClsId, objvCurrEduClsStu_Cond.CurrEduClsId, strComparisonOp_CurrEduClsId);
}
if (objvCurrEduClsStu_Cond.IsUpdated(convCurrEduClsStu.EduClsName) == true)
{
string strComparisonOp_EduClsName = objvCurrEduClsStu_Cond.dicFldComparisonOp[convCurrEduClsStu.EduClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.EduClsName, objvCurrEduClsStu_Cond.EduClsName, strComparisonOp_EduClsName);
}
if (objvCurrEduClsStu_Cond.IsUpdated(convCurrEduClsStu.CourseId) == true)
{
string strComparisonOp_CourseId = objvCurrEduClsStu_Cond.dicFldComparisonOp[convCurrEduClsStu.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.CourseId, objvCurrEduClsStu_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvCurrEduClsStu_Cond.IsUpdated(convCurrEduClsStu.CourseCode) == true)
{
string strComparisonOp_CourseCode = objvCurrEduClsStu_Cond.dicFldComparisonOp[convCurrEduClsStu.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.CourseCode, objvCurrEduClsStu_Cond.CourseCode, strComparisonOp_CourseCode);
}
if (objvCurrEduClsStu_Cond.IsUpdated(convCurrEduClsStu.CourseName) == true)
{
string strComparisonOp_CourseName = objvCurrEduClsStu_Cond.dicFldComparisonOp[convCurrEduClsStu.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.CourseName, objvCurrEduClsStu_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvCurrEduClsStu_Cond.IsUpdated(convCurrEduClsStu.TeachingSolutionId) == true)
{
string strComparisonOp_TeachingSolutionId = objvCurrEduClsStu_Cond.dicFldComparisonOp[convCurrEduClsStu.TeachingSolutionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.TeachingSolutionId, objvCurrEduClsStu_Cond.TeachingSolutionId, strComparisonOp_TeachingSolutionId);
}
if (objvCurrEduClsStu_Cond.IsUpdated(convCurrEduClsStu.TeachingSolutionName) == true)
{
string strComparisonOp_TeachingSolutionName = objvCurrEduClsStu_Cond.dicFldComparisonOp[convCurrEduClsStu.TeachingSolutionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.TeachingSolutionName, objvCurrEduClsStu_Cond.TeachingSolutionName, strComparisonOp_TeachingSolutionName);
}
if (objvCurrEduClsStu_Cond.IsUpdated(convCurrEduClsStu.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvCurrEduClsStu_Cond.dicFldComparisonOp[convCurrEduClsStu.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.id_XzCollege, objvCurrEduClsStu_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvCurrEduClsStu_Cond.IsUpdated(convCurrEduClsStu.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvCurrEduClsStu_Cond.dicFldComparisonOp[convCurrEduClsStu.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.CollegeID, objvCurrEduClsStu_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvCurrEduClsStu_Cond.IsUpdated(convCurrEduClsStu.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvCurrEduClsStu_Cond.dicFldComparisonOp[convCurrEduClsStu.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.CollegeName, objvCurrEduClsStu_Cond.CollegeName, strComparisonOp_CollegeName);
}
//数据类型short(smallint)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvCurrEduClsStu_Cond.IsUpdated(convCurrEduClsStu.Mark) == true)
{
string strComparisonOp_Mark = objvCurrEduClsStu_Cond.dicFldComparisonOp[convCurrEduClsStu.Mark];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduClsStu.Mark, objvCurrEduClsStu_Cond.Mark, strComparisonOp_Mark);
}
if (objvCurrEduClsStu_Cond.IsUpdated(convCurrEduClsStu.id_UniZone) == true)
{
string strComparisonOp_id_UniZone = objvCurrEduClsStu_Cond.dicFldComparisonOp[convCurrEduClsStu.id_UniZone];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.id_UniZone, objvCurrEduClsStu_Cond.id_UniZone, strComparisonOp_id_UniZone);
}
if (objvCurrEduClsStu_Cond.IsUpdated(convCurrEduClsStu.GradeBaseName) == true)
{
string strComparisonOp_GradeBaseName = objvCurrEduClsStu_Cond.dicFldComparisonOp[convCurrEduClsStu.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.GradeBaseName, objvCurrEduClsStu_Cond.GradeBaseName, strComparisonOp_GradeBaseName);
}
if (objvCurrEduClsStu_Cond.IsUpdated(convCurrEduClsStu.IsEffective) == true)
{
if (objvCurrEduClsStu_Cond.IsEffective == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduClsStu.IsEffective);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduClsStu.IsEffective);
}
}
if (objvCurrEduClsStu_Cond.IsUpdated(convCurrEduClsStu.id_CourseType) == true)
{
string strComparisonOp_id_CourseType = objvCurrEduClsStu_Cond.dicFldComparisonOp[convCurrEduClsStu.id_CourseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.id_CourseType, objvCurrEduClsStu_Cond.id_CourseType, strComparisonOp_id_CourseType);
}
if (objvCurrEduClsStu_Cond.IsUpdated(convCurrEduClsStu.CourseTypeID) == true)
{
string strComparisonOp_CourseTypeID = objvCurrEduClsStu_Cond.dicFldComparisonOp[convCurrEduClsStu.CourseTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.CourseTypeID, objvCurrEduClsStu_Cond.CourseTypeID, strComparisonOp_CourseTypeID);
}
if (objvCurrEduClsStu_Cond.IsUpdated(convCurrEduClsStu.CourseTypeName) == true)
{
string strComparisonOp_CourseTypeName = objvCurrEduClsStu_Cond.dicFldComparisonOp[convCurrEduClsStu.CourseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.CourseTypeName, objvCurrEduClsStu_Cond.CourseTypeName, strComparisonOp_CourseTypeName);
}
if (objvCurrEduClsStu_Cond.IsUpdated(convCurrEduClsStu.IsDegree) == true)
{
if (objvCurrEduClsStu_Cond.IsDegree == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduClsStu.IsDegree);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduClsStu.IsDegree);
}
}
if (objvCurrEduClsStu_Cond.IsUpdated(convCurrEduClsStu.CurrStuNum) == true)
{
string strComparisonOp_CurrStuNum = objvCurrEduClsStu_Cond.dicFldComparisonOp[convCurrEduClsStu.CurrStuNum];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduClsStu.CurrStuNum, objvCurrEduClsStu_Cond.CurrStuNum, strComparisonOp_CurrStuNum);
}
if (objvCurrEduClsStu_Cond.IsUpdated(convCurrEduClsStu.id_Stu) == true)
{
string strComparisonOp_id_Stu = objvCurrEduClsStu_Cond.dicFldComparisonOp[convCurrEduClsStu.id_Stu];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.id_Stu, objvCurrEduClsStu_Cond.id_Stu, strComparisonOp_id_Stu);
}
if (objvCurrEduClsStu_Cond.IsUpdated(convCurrEduClsStu.StuID) == true)
{
string strComparisonOp_StuID = objvCurrEduClsStu_Cond.dicFldComparisonOp[convCurrEduClsStu.StuID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.StuID, objvCurrEduClsStu_Cond.StuID, strComparisonOp_StuID);
}
if (objvCurrEduClsStu_Cond.IsUpdated(convCurrEduClsStu.StuName) == true)
{
string strComparisonOp_StuName = objvCurrEduClsStu_Cond.dicFldComparisonOp[convCurrEduClsStu.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.StuName, objvCurrEduClsStu_Cond.StuName, strComparisonOp_StuName);
}
if (objvCurrEduClsStu_Cond.IsUpdated(convCurrEduClsStu.id_Sex) == true)
{
string strComparisonOp_id_Sex = objvCurrEduClsStu_Cond.dicFldComparisonOp[convCurrEduClsStu.id_Sex];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.id_Sex, objvCurrEduClsStu_Cond.id_Sex, strComparisonOp_id_Sex);
}
if (objvCurrEduClsStu_Cond.IsUpdated(convCurrEduClsStu.SexDesc) == true)
{
string strComparisonOp_SexDesc = objvCurrEduClsStu_Cond.dicFldComparisonOp[convCurrEduClsStu.SexDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.SexDesc, objvCurrEduClsStu_Cond.SexDesc, strComparisonOp_SexDesc);
}
if (objvCurrEduClsStu_Cond.IsUpdated(convCurrEduClsStu.MajorID) == true)
{
string strComparisonOp_MajorID = objvCurrEduClsStu_Cond.dicFldComparisonOp[convCurrEduClsStu.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.MajorID, objvCurrEduClsStu_Cond.MajorID, strComparisonOp_MajorID);
}
if (objvCurrEduClsStu_Cond.IsUpdated(convCurrEduClsStu.MajorName) == true)
{
string strComparisonOp_MajorName = objvCurrEduClsStu_Cond.dicFldComparisonOp[convCurrEduClsStu.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.MajorName, objvCurrEduClsStu_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvCurrEduClsStu_Cond.IsUpdated(convCurrEduClsStu.id_AdminCls) == true)
{
string strComparisonOp_id_AdminCls = objvCurrEduClsStu_Cond.dicFldComparisonOp[convCurrEduClsStu.id_AdminCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.id_AdminCls, objvCurrEduClsStu_Cond.id_AdminCls, strComparisonOp_id_AdminCls);
}
if (objvCurrEduClsStu_Cond.IsUpdated(convCurrEduClsStu.Birthday) == true)
{
string strComparisonOp_Birthday = objvCurrEduClsStu_Cond.dicFldComparisonOp[convCurrEduClsStu.Birthday];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.Birthday, objvCurrEduClsStu_Cond.Birthday, strComparisonOp_Birthday);
}
if (objvCurrEduClsStu_Cond.IsUpdated(convCurrEduClsStu.EduClsStuStateID) == true)
{
string strComparisonOp_EduClsStuStateID = objvCurrEduClsStu_Cond.dicFldComparisonOp[convCurrEduClsStu.EduClsStuStateID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.EduClsStuStateID, objvCurrEduClsStu_Cond.EduClsStuStateID, strComparisonOp_EduClsStuStateID);
}
//数据类型short(tinyint)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvCurrEduClsStu_Cond.IsUpdated(convCurrEduClsStu.Score) == true)
{
string strComparisonOp_Score = objvCurrEduClsStu_Cond.dicFldComparisonOp[convCurrEduClsStu.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduClsStu.Score, objvCurrEduClsStu_Cond.Score, strComparisonOp_Score);
}
if (objvCurrEduClsStu_Cond.IsUpdated(convCurrEduClsStu.TotalScores) == true)
{
string strComparisonOp_TotalScores = objvCurrEduClsStu_Cond.dicFldComparisonOp[convCurrEduClsStu.TotalScores];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduClsStu.TotalScores, objvCurrEduClsStu_Cond.TotalScores, strComparisonOp_TotalScores);
}
if (objvCurrEduClsStu_Cond.IsUpdated(convCurrEduClsStu.Ranking) == true)
{
string strComparisonOp_Ranking = objvCurrEduClsStu_Cond.dicFldComparisonOp[convCurrEduClsStu.Ranking];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduClsStu.Ranking, objvCurrEduClsStu_Cond.Ranking, strComparisonOp_Ranking);
}
if (objvCurrEduClsStu_Cond.IsUpdated(convCurrEduClsStu.Percentile) == true)
{
string strComparisonOp_Percentile = objvCurrEduClsStu_Cond.dicFldComparisonOp[convCurrEduClsStu.Percentile];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduClsStu.Percentile, objvCurrEduClsStu_Cond.Percentile, strComparisonOp_Percentile);
}
if (objvCurrEduClsStu_Cond.IsUpdated(convCurrEduClsStu.Confirmed) == true)
{
if (objvCurrEduClsStu_Cond.Confirmed == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduClsStu.Confirmed);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduClsStu.Confirmed);
}
}
if (objvCurrEduClsStu_Cond.IsUpdated(convCurrEduClsStu.SchoolTerm) == true)
{
string strComparisonOp_SchoolTerm = objvCurrEduClsStu_Cond.dicFldComparisonOp[convCurrEduClsStu.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.SchoolTerm, objvCurrEduClsStu_Cond.SchoolTerm, strComparisonOp_SchoolTerm);
}
if (objvCurrEduClsStu_Cond.IsUpdated(convCurrEduClsStu.SchoolYear) == true)
{
string strComparisonOp_SchoolYear = objvCurrEduClsStu_Cond.dicFldComparisonOp[convCurrEduClsStu.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.SchoolYear, objvCurrEduClsStu_Cond.SchoolYear, strComparisonOp_SchoolYear);
}
if (objvCurrEduClsStu_Cond.IsUpdated(convCurrEduClsStu.SignInDate) == true)
{
string strComparisonOp_SignInDate = objvCurrEduClsStu_Cond.dicFldComparisonOp[convCurrEduClsStu.SignInDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.SignInDate, objvCurrEduClsStu_Cond.SignInDate, strComparisonOp_SignInDate);
}
if (objvCurrEduClsStu_Cond.IsUpdated(convCurrEduClsStu.SignInStateID) == true)
{
string strComparisonOp_SignInStateID = objvCurrEduClsStu_Cond.dicFldComparisonOp[convCurrEduClsStu.SignInStateID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.SignInStateID, objvCurrEduClsStu_Cond.SignInStateID, strComparisonOp_SignInStateID);
}
if (objvCurrEduClsStu_Cond.IsUpdated(convCurrEduClsStu.SignInUser) == true)
{
string strComparisonOp_SignInUser = objvCurrEduClsStu_Cond.dicFldComparisonOp[convCurrEduClsStu.SignInUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.SignInUser, objvCurrEduClsStu_Cond.SignInUser, strComparisonOp_SignInUser);
}
if (objvCurrEduClsStu_Cond.IsUpdated(convCurrEduClsStu.ModifyDate) == true)
{
string strComparisonOp_ModifyDate = objvCurrEduClsStu_Cond.dicFldComparisonOp[convCurrEduClsStu.ModifyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.ModifyDate, objvCurrEduClsStu_Cond.ModifyDate, strComparisonOp_ModifyDate);
}
if (objvCurrEduClsStu_Cond.IsUpdated(convCurrEduClsStu.ModifyUserID) == true)
{
string strComparisonOp_ModifyUserID = objvCurrEduClsStu_Cond.dicFldComparisonOp[convCurrEduClsStu.ModifyUserID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.ModifyUserID, objvCurrEduClsStu_Cond.ModifyUserID, strComparisonOp_ModifyUserID);
}
if (objvCurrEduClsStu_Cond.IsUpdated(convCurrEduClsStu.CollegeName4Stu) == true)
{
string strComparisonOp_CollegeName4Stu = objvCurrEduClsStu_Cond.dicFldComparisonOp[convCurrEduClsStu.CollegeName4Stu];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.CollegeName4Stu, objvCurrEduClsStu_Cond.CollegeName4Stu, strComparisonOp_CollegeName4Stu);
}
if (objvCurrEduClsStu_Cond.IsUpdated(convCurrEduClsStu.EduClsTypeName) == true)
{
string strComparisonOp_EduClsTypeName = objvCurrEduClsStu_Cond.dicFldComparisonOp[convCurrEduClsStu.EduClsTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.EduClsTypeName, objvCurrEduClsStu_Cond.EduClsTypeName, strComparisonOp_EduClsTypeName);
}
if (objvCurrEduClsStu_Cond.IsUpdated(convCurrEduClsStu.IsSynScore) == true)
{
if (objvCurrEduClsStu_Cond.IsSynScore == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduClsStu.IsSynScore);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduClsStu.IsSynScore);
}
}
if (objvCurrEduClsStu_Cond.IsUpdated(convCurrEduClsStu.EduClsTypeId) == true)
{
string strComparisonOp_EduClsTypeId = objvCurrEduClsStu_Cond.dicFldComparisonOp[convCurrEduClsStu.EduClsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.EduClsTypeId, objvCurrEduClsStu_Cond.EduClsTypeId, strComparisonOp_EduClsTypeId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v教学班与学生关系(vCurrEduClsStu)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCurrEduClsStuWApi
{
private static readonly string mstrApiControllerName = "vCurrEduClsStuApi";

 public clsvCurrEduClsStuWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_EduClsStu">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCurrEduClsStuEN GetObjByid_EduClsStu(long lngid_EduClsStu)
{
string strAction = "GetObjByid_EduClsStu";
string strErrMsg = string.Empty;
string strResult = "";
clsvCurrEduClsStuEN objvCurrEduClsStuEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_EduClsStu"] = lngid_EduClsStu.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvCurrEduClsStuEN = JsonConvert.DeserializeObject<clsvCurrEduClsStuEN>((string)jobjReturn["ReturnObj"]);
return objvCurrEduClsStuEN;
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
 /// <param name = "lngid_EduClsStu">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCurrEduClsStuEN GetObjByid_EduClsStu_WA_Cache(long lngid_EduClsStu, string strid_CurrEduCls)
{
string strAction = "GetObjByid_EduClsStu_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvCurrEduClsStuEN objvCurrEduClsStuEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_EduClsStu"] = lngid_EduClsStu.ToString(),
["id_CurrEduCls"] = strid_CurrEduCls
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvCurrEduClsStuEN = JsonConvert.DeserializeObject<clsvCurrEduClsStuEN>((string)jobjReturn["ReturnObj"]);
return objvCurrEduClsStuEN;
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
public static clsvCurrEduClsStuEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvCurrEduClsStuEN objvCurrEduClsStuEN = null;
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
objvCurrEduClsStuEN = JsonConvert.DeserializeObject<clsvCurrEduClsStuEN>((string)jobjReturn["ReturnObj"]);
return objvCurrEduClsStuEN;
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
 /// <param name = "lngid_EduClsStu">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCurrEduClsStuEN GetObjByid_EduClsStu_Cache(long lngid_EduClsStu, string strid_CurrEduCls)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvCurrEduClsStuEN._CurrTabName_S, strid_CurrEduCls);
List<clsvCurrEduClsStuEN> arrvCurrEduClsStuObjLst_Cache = GetObjLst_Cache(strid_CurrEduCls);
IEnumerable <clsvCurrEduClsStuEN> arrvCurrEduClsStuObjLst_Sel =
from objvCurrEduClsStuEN in arrvCurrEduClsStuObjLst_Cache
where objvCurrEduClsStuEN.id_EduClsStu == lngid_EduClsStu
select objvCurrEduClsStuEN;
if (arrvCurrEduClsStuObjLst_Sel.Count() == 0)
{
   clsvCurrEduClsStuEN obj = clsvCurrEduClsStuWApi.GetObjByid_EduClsStu(lngid_EduClsStu);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCurrEduClsStuObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCurrEduClsStuEN> GetObjLst(string strWhereCond)
{
 List<clsvCurrEduClsStuEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduClsStuEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCurrEduClsStuEN> GetObjLstById_EduClsStuLst(List<long> arrId_EduClsStu)
{
 List<clsvCurrEduClsStuEN> arrObjLst = null; 
string strAction = "GetObjLstById_EduClsStuLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_EduClsStu);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduClsStuEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngid_EduClsStu">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvCurrEduClsStuEN> GetObjLstById_EduClsStuLst_Cache(List<long> arrId_EduClsStu, string strid_CurrEduCls)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvCurrEduClsStuEN._CurrTabName_S, strid_CurrEduCls);
List<clsvCurrEduClsStuEN> arrvCurrEduClsStuObjLst_Cache = GetObjLst_Cache(strid_CurrEduCls);
IEnumerable <clsvCurrEduClsStuEN> arrvCurrEduClsStuObjLst_Sel =
from objvCurrEduClsStuEN in arrvCurrEduClsStuObjLst_Cache
where arrId_EduClsStu.Contains(objvCurrEduClsStuEN.id_EduClsStu)
select objvCurrEduClsStuEN;
return arrvCurrEduClsStuObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCurrEduClsStuEN> GetObjLstById_EduClsStuLst_WA_Cache(List<long> arrId_EduClsStu, string strid_CurrEduCls)
{
 List<clsvCurrEduClsStuEN> arrObjLst = null; 
string strAction = "GetObjLstById_EduClsStuLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CurrEduCls"] = strid_CurrEduCls
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_EduClsStu);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduClsStuEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCurrEduClsStuEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCurrEduClsStuEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduClsStuEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCurrEduClsStuEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCurrEduClsStuEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduClsStuEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCurrEduClsStuEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCurrEduClsStuEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduClsStuEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCurrEduClsStuEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvCurrEduClsStuEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduClsStuEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngid_EduClsStu)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_EduClsStu"] = lngid_EduClsStu.ToString()
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
 /// <param name = "objvCurrEduClsStuENS">源对象</param>
 /// <param name = "objvCurrEduClsStuENT">目标对象</param>
 public static void CopyTo(clsvCurrEduClsStuEN objvCurrEduClsStuENS, clsvCurrEduClsStuEN objvCurrEduClsStuENT)
{
try
{
objvCurrEduClsStuENT.id_EduClsStu = objvCurrEduClsStuENS.id_EduClsStu; //教学班学生流水号
objvCurrEduClsStuENT.id_CurrEduCls = objvCurrEduClsStuENS.id_CurrEduCls; //当前教学班流水号
objvCurrEduClsStuENT.CurrEduClsId = objvCurrEduClsStuENS.CurrEduClsId; //当前教学班Id
objvCurrEduClsStuENT.EduClsName = objvCurrEduClsStuENS.EduClsName; //教学班名称
objvCurrEduClsStuENT.CourseId = objvCurrEduClsStuENS.CourseId; //课程Id
objvCurrEduClsStuENT.CourseCode = objvCurrEduClsStuENS.CourseCode; //课程代码
objvCurrEduClsStuENT.CourseName = objvCurrEduClsStuENS.CourseName; //课程名称
objvCurrEduClsStuENT.TeachingSolutionId = objvCurrEduClsStuENS.TeachingSolutionId; //教学方案Id
objvCurrEduClsStuENT.TeachingSolutionName = objvCurrEduClsStuENS.TeachingSolutionName; //教学方案名称
objvCurrEduClsStuENT.id_XzCollege = objvCurrEduClsStuENS.id_XzCollege; //学院流水号
objvCurrEduClsStuENT.CollegeID = objvCurrEduClsStuENS.CollegeID; //学院ID
objvCurrEduClsStuENT.CollegeName = objvCurrEduClsStuENS.CollegeName; //学院名称
objvCurrEduClsStuENT.LessonQtyPerWeek = objvCurrEduClsStuENS.LessonQtyPerWeek; //周课时数
objvCurrEduClsStuENT.Mark = objvCurrEduClsStuENS.Mark; //获得学分
objvCurrEduClsStuENT.id_UniZone = objvCurrEduClsStuENS.id_UniZone; //校区流水号
objvCurrEduClsStuENT.GradeBaseName = objvCurrEduClsStuENS.GradeBaseName; //年级名称
objvCurrEduClsStuENT.IsEffective = objvCurrEduClsStuENS.IsEffective; //是否有效
objvCurrEduClsStuENT.id_CourseType = objvCurrEduClsStuENS.id_CourseType; //课程类型流水号
objvCurrEduClsStuENT.CourseTypeID = objvCurrEduClsStuENS.CourseTypeID; //课程类型ID
objvCurrEduClsStuENT.CourseTypeName = objvCurrEduClsStuENS.CourseTypeName; //课程类型名称
objvCurrEduClsStuENT.IsDegree = objvCurrEduClsStuENS.IsDegree; //是否学位课
objvCurrEduClsStuENT.CurrStuNum = objvCurrEduClsStuENS.CurrStuNum; //当前学生数
objvCurrEduClsStuENT.id_Stu = objvCurrEduClsStuENS.id_Stu; //学生流水号
objvCurrEduClsStuENT.StuID = objvCurrEduClsStuENS.StuID; //学号
objvCurrEduClsStuENT.StuName = objvCurrEduClsStuENS.StuName; //姓名
objvCurrEduClsStuENT.id_Sex = objvCurrEduClsStuENS.id_Sex; //性别流水号
objvCurrEduClsStuENT.SexDesc = objvCurrEduClsStuENS.SexDesc; //性别名称
objvCurrEduClsStuENT.MajorID = objvCurrEduClsStuENS.MajorID; //专业ID
objvCurrEduClsStuENT.MajorName = objvCurrEduClsStuENS.MajorName; //专业名称
objvCurrEduClsStuENT.id_AdminCls = objvCurrEduClsStuENS.id_AdminCls; //行政班流水号
objvCurrEduClsStuENT.Birthday = objvCurrEduClsStuENS.Birthday; //出生日期
objvCurrEduClsStuENT.EduClsStuStateID = objvCurrEduClsStuENS.EduClsStuStateID; //教学班学生状态编号
objvCurrEduClsStuENT.GetScoreTimes = objvCurrEduClsStuENS.GetScoreTimes; //获得成绩次数
objvCurrEduClsStuENT.Score = objvCurrEduClsStuENS.Score; //得分
objvCurrEduClsStuENT.TotalScores = objvCurrEduClsStuENS.TotalScores; //总分值
objvCurrEduClsStuENT.Ranking = objvCurrEduClsStuENS.Ranking; //名次
objvCurrEduClsStuENT.Percentile = objvCurrEduClsStuENS.Percentile; //百分位
objvCurrEduClsStuENT.Confirmed = objvCurrEduClsStuENS.Confirmed; //是否确认
objvCurrEduClsStuENT.SchoolTerm = objvCurrEduClsStuENS.SchoolTerm; //学期
objvCurrEduClsStuENT.SchoolYear = objvCurrEduClsStuENS.SchoolYear; //学年
objvCurrEduClsStuENT.SignInDate = objvCurrEduClsStuENS.SignInDate; //签入时间
objvCurrEduClsStuENT.SignInStateID = objvCurrEduClsStuENS.SignInStateID; //签入状态表流水号
objvCurrEduClsStuENT.SignInUser = objvCurrEduClsStuENS.SignInUser; //签入人
objvCurrEduClsStuENT.ModifyDate = objvCurrEduClsStuENS.ModifyDate; //修改日期
objvCurrEduClsStuENT.ModifyUserID = objvCurrEduClsStuENS.ModifyUserID; //修改人
objvCurrEduClsStuENT.CollegeName4Stu = objvCurrEduClsStuENS.CollegeName4Stu; //CollegeName4Stu
objvCurrEduClsStuENT.EduClsTypeName = objvCurrEduClsStuENS.EduClsTypeName; //教学班类型名称
objvCurrEduClsStuENT.IsSynScore = objvCurrEduClsStuENS.IsSynScore; //是否同步成绩
objvCurrEduClsStuENT.EduClsTypeId = objvCurrEduClsStuENS.EduClsTypeId; //教学班类型代号
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
public static DataTable ToDataTable(List<clsvCurrEduClsStuEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCurrEduClsStuEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCurrEduClsStuEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCurrEduClsStuEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCurrEduClsStuEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCurrEduClsStuEN.AttributeName)
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
if (clsCurrEduClsStuWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCurrEduClsStuWApi没有刷新缓存机制(clsCurrEduClsStuWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseTypeWApi没有刷新缓存机制(clscc_CourseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsCurrEduClsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCurrEduClsWApi没有刷新缓存机制(clsCurrEduClsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzGradeBaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGradeBaseWApi没有刷新缓存机制(clsXzGradeBaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsgs_EduClsTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_EduClsTypeWApi没有刷新缓存机制(clsgs_EduClsTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzUniZoneWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzUniZoneWApi没有刷新缓存机制(clsXzUniZoneWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSexWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSexWApi没有刷新缓存机制(clsSexWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsEthnicWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsEthnicWApi没有刷新缓存机制(clsRsEthnicWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsPoliticsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsPoliticsWApi没有刷新缓存机制(clsRsPoliticsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudentInfoWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudentInfoWApi没有刷新缓存机制(clsStudentInfoWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsStuTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsStuTypeWApi没有刷新缓存机制(clsRsStuTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseWApi没有刷新缓存机制(clscc_CourseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsTeachingSolutionWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachingSolutionWApi没有刷新缓存机制(clsTeachingSolutionWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzAdminClsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzAdminClsWApi没有刷新缓存机制(clsXzAdminClsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzAdminClsTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzAdminClsTypeWApi没有刷新缓存机制(clsXzAdminClsTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseIsLikeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeWApi没有刷新缓存机制(clscc_CourseIsLikeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeacherInfoWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeacherInfoWApi没有刷新缓存机制(clsTeacherInfoWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDiscipline_psWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsDiscipline_psWApi没有刷新缓存机制(clsDiscipline_psWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsStaffTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsStaffTypeWApi没有刷新缓存机制(clsRsStaffTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzSchool_PsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzSchool_PsWApi没有刷新缓存机制(clsXzSchool_PsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsProfGradeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsProfGradeWApi没有刷新缓存机制(clsRsProfGradeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsDegreeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsDegreeWApi没有刷新缓存机制(clsRsDegreeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsProvinceWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsProvinceWApi没有刷新缓存机制(clsRsProvinceWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsReligionWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsReligionWApi没有刷新缓存机制(clsRsReligionWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsQualifWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsQualifWApi没有刷新缓存机制(clsRsQualifWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsAdminGradeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsAdminGradeWApi没有刷新缓存机制(clsRsAdminGradeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudyLevelWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelWApi没有刷新缓存机制(clsStudyLevelWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_EduClsStu");
//if (arrvCurrEduClsStuObjLst_Cache == null)
//{
//arrvCurrEduClsStuObjLst_Cache = await clsvCurrEduClsStuWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strid_CurrEduCls = "")
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvCurrEduClsStuEN._CurrTabName_S, strid_CurrEduCls);
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
public static List<clsvCurrEduClsStuEN> GetObjLst_Cache(string strid_CurrEduCls)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvCurrEduClsStuEN._CurrTabName_S, strid_CurrEduCls);
List<clsvCurrEduClsStuEN> arrvCurrEduClsStuObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("id_CurrEduCls='{0}'", strid_CurrEduCls)); });
return arrvCurrEduClsStuObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCurrEduClsStuEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCurrEduClsStu.id_EduClsStu, Type.GetType("System.Int64"));
objDT.Columns.Add(convCurrEduClsStu.id_CurrEduCls, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu.CurrEduClsId, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu.EduClsName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu.CourseCode, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu.TeachingSolutionId, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu.TeachingSolutionName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu.LessonQtyPerWeek, Type.GetType("System.Int16"));
objDT.Columns.Add(convCurrEduClsStu.Mark, Type.GetType("System.Decimal"));
objDT.Columns.Add(convCurrEduClsStu.id_UniZone, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu.GradeBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu.IsEffective, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCurrEduClsStu.id_CourseType, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu.CourseTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu.CourseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu.IsDegree, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCurrEduClsStu.CurrStuNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convCurrEduClsStu.id_Stu, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu.StuID, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu.StuName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu.id_Sex, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu.SexDesc, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu.MajorID, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu.id_AdminCls, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu.Birthday, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu.EduClsStuStateID, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu.GetScoreTimes, Type.GetType("System.Int16"));
objDT.Columns.Add(convCurrEduClsStu.Score, Type.GetType("System.Decimal"));
objDT.Columns.Add(convCurrEduClsStu.TotalScores, Type.GetType("System.Decimal"));
objDT.Columns.Add(convCurrEduClsStu.Ranking, Type.GetType("System.Int32"));
objDT.Columns.Add(convCurrEduClsStu.Percentile, Type.GetType("System.Decimal"));
objDT.Columns.Add(convCurrEduClsStu.Confirmed, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCurrEduClsStu.SchoolTerm, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu.SchoolYear, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu.SignInDate, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu.SignInStateID, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu.SignInUser, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu.ModifyDate, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu.ModifyUserID, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu.CollegeName4Stu, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu.EduClsTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduClsStu.IsSynScore, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCurrEduClsStu.EduClsTypeId, Type.GetType("System.String"));
foreach (clsvCurrEduClsStuEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCurrEduClsStu.id_EduClsStu] = objInFor[convCurrEduClsStu.id_EduClsStu];
objDR[convCurrEduClsStu.id_CurrEduCls] = objInFor[convCurrEduClsStu.id_CurrEduCls];
objDR[convCurrEduClsStu.CurrEduClsId] = objInFor[convCurrEduClsStu.CurrEduClsId];
objDR[convCurrEduClsStu.EduClsName] = objInFor[convCurrEduClsStu.EduClsName];
objDR[convCurrEduClsStu.CourseId] = objInFor[convCurrEduClsStu.CourseId];
objDR[convCurrEduClsStu.CourseCode] = objInFor[convCurrEduClsStu.CourseCode];
objDR[convCurrEduClsStu.CourseName] = objInFor[convCurrEduClsStu.CourseName];
objDR[convCurrEduClsStu.TeachingSolutionId] = objInFor[convCurrEduClsStu.TeachingSolutionId];
objDR[convCurrEduClsStu.TeachingSolutionName] = objInFor[convCurrEduClsStu.TeachingSolutionName];
objDR[convCurrEduClsStu.id_XzCollege] = objInFor[convCurrEduClsStu.id_XzCollege];
objDR[convCurrEduClsStu.CollegeID] = objInFor[convCurrEduClsStu.CollegeID];
objDR[convCurrEduClsStu.CollegeName] = objInFor[convCurrEduClsStu.CollegeName];
objDR[convCurrEduClsStu.LessonQtyPerWeek] = objInFor[convCurrEduClsStu.LessonQtyPerWeek];
objDR[convCurrEduClsStu.Mark] = objInFor[convCurrEduClsStu.Mark];
objDR[convCurrEduClsStu.id_UniZone] = objInFor[convCurrEduClsStu.id_UniZone];
objDR[convCurrEduClsStu.GradeBaseName] = objInFor[convCurrEduClsStu.GradeBaseName];
objDR[convCurrEduClsStu.IsEffective] = objInFor[convCurrEduClsStu.IsEffective];
objDR[convCurrEduClsStu.id_CourseType] = objInFor[convCurrEduClsStu.id_CourseType];
objDR[convCurrEduClsStu.CourseTypeID] = objInFor[convCurrEduClsStu.CourseTypeID];
objDR[convCurrEduClsStu.CourseTypeName] = objInFor[convCurrEduClsStu.CourseTypeName];
objDR[convCurrEduClsStu.IsDegree] = objInFor[convCurrEduClsStu.IsDegree];
objDR[convCurrEduClsStu.CurrStuNum] = objInFor[convCurrEduClsStu.CurrStuNum];
objDR[convCurrEduClsStu.id_Stu] = objInFor[convCurrEduClsStu.id_Stu];
objDR[convCurrEduClsStu.StuID] = objInFor[convCurrEduClsStu.StuID];
objDR[convCurrEduClsStu.StuName] = objInFor[convCurrEduClsStu.StuName];
objDR[convCurrEduClsStu.id_Sex] = objInFor[convCurrEduClsStu.id_Sex];
objDR[convCurrEduClsStu.SexDesc] = objInFor[convCurrEduClsStu.SexDesc];
objDR[convCurrEduClsStu.MajorID] = objInFor[convCurrEduClsStu.MajorID];
objDR[convCurrEduClsStu.MajorName] = objInFor[convCurrEduClsStu.MajorName];
objDR[convCurrEduClsStu.id_AdminCls] = objInFor[convCurrEduClsStu.id_AdminCls];
objDR[convCurrEduClsStu.Birthday] = objInFor[convCurrEduClsStu.Birthday];
objDR[convCurrEduClsStu.EduClsStuStateID] = objInFor[convCurrEduClsStu.EduClsStuStateID];
objDR[convCurrEduClsStu.GetScoreTimes] = objInFor[convCurrEduClsStu.GetScoreTimes];
objDR[convCurrEduClsStu.Score] = objInFor[convCurrEduClsStu.Score];
objDR[convCurrEduClsStu.TotalScores] = objInFor[convCurrEduClsStu.TotalScores];
objDR[convCurrEduClsStu.Ranking] = objInFor[convCurrEduClsStu.Ranking];
objDR[convCurrEduClsStu.Percentile] = objInFor[convCurrEduClsStu.Percentile];
objDR[convCurrEduClsStu.Confirmed] = objInFor[convCurrEduClsStu.Confirmed];
objDR[convCurrEduClsStu.SchoolTerm] = objInFor[convCurrEduClsStu.SchoolTerm];
objDR[convCurrEduClsStu.SchoolYear] = objInFor[convCurrEduClsStu.SchoolYear];
objDR[convCurrEduClsStu.SignInDate] = objInFor[convCurrEduClsStu.SignInDate];
objDR[convCurrEduClsStu.SignInStateID] = objInFor[convCurrEduClsStu.SignInStateID];
objDR[convCurrEduClsStu.SignInUser] = objInFor[convCurrEduClsStu.SignInUser];
objDR[convCurrEduClsStu.ModifyDate] = objInFor[convCurrEduClsStu.ModifyDate];
objDR[convCurrEduClsStu.ModifyUserID] = objInFor[convCurrEduClsStu.ModifyUserID];
objDR[convCurrEduClsStu.CollegeName4Stu] = objInFor[convCurrEduClsStu.CollegeName4Stu];
objDR[convCurrEduClsStu.EduClsTypeName] = objInFor[convCurrEduClsStu.EduClsTypeName];
objDR[convCurrEduClsStu.IsSynScore] = objInFor[convCurrEduClsStu.IsSynScore];
objDR[convCurrEduClsStu.EduClsTypeId] = objInFor[convCurrEduClsStu.EduClsTypeId];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}