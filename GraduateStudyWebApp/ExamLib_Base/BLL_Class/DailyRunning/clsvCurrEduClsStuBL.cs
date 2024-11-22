
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCurrEduClsStuBL
 表名:vCurrEduClsStu(01120127)
 * 版本:2024.03.11.1(服务器:WIN-SRV103-116)
 日期:2024/03/18 17:50:17
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
public static class  clsvCurrEduClsStuBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdEduClsStu">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCurrEduClsStuEN GetObj(this K_IdEduClsStu_vCurrEduClsStu myKey)
{
clsvCurrEduClsStuEN objvCurrEduClsStuEN = clsvCurrEduClsStuBL.vCurrEduClsStuDA.GetObjByIdEduClsStu(myKey.Value);
return objvCurrEduClsStuEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsStuEN SetIdEduClsStu(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, long lngIdEduClsStu, string strComparisonOp="")
	{
objvCurrEduClsStuEN.IdEduClsStu = lngIdEduClsStu; //教学班学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.IdEduClsStu) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.IdEduClsStu, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.IdEduClsStu] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsStuEN SetIdCurrEduCls(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strIdCurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdCurrEduCls, convCurrEduClsStu.IdCurrEduCls);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convCurrEduClsStu.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convCurrEduClsStu.IdCurrEduCls);
}
objvCurrEduClsStuEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.IdCurrEduCls) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.IdCurrEduCls, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.IdCurrEduCls] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsStuEN SetCurrEduClsId(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strCurrEduClsId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCurrEduClsId, 15, convCurrEduClsStu.CurrEduClsId);
}
objvCurrEduClsStuEN.CurrEduClsId = strCurrEduClsId; //教学班Id
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsStuEN SetEduClsName(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strEduClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEduClsName, convCurrEduClsStu.EduClsName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduClsName, 100, convCurrEduClsStu.EduClsName);
}
objvCurrEduClsStuEN.EduClsName = strEduClsName; //教学班名
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsStuEN SetCourseId(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convCurrEduClsStu.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convCurrEduClsStu.CourseId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsStuEN SetCourseCode(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strCourseCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convCurrEduClsStu.CourseCode);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsStuEN SetCourseName(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convCurrEduClsStu.CourseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsStuEN SetTeachingSolutionId(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strTeachingSolutionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingSolutionId, 8, convCurrEduClsStu.TeachingSolutionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachingSolutionId, 8, convCurrEduClsStu.TeachingSolutionId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsStuEN SetTeachingSolutionName(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strTeachingSolutionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingSolutionName, 100, convCurrEduClsStu.TeachingSolutionName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsStuEN SetIdXzCollege(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convCurrEduClsStu.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convCurrEduClsStu.IdXzCollege);
}
objvCurrEduClsStuEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.IdXzCollege) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.IdXzCollege, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.IdXzCollege] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsStuEN SetCollegeId(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strCollegeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeId, 4, convCurrEduClsStu.CollegeId);
}
objvCurrEduClsStuEN.CollegeId = strCollegeId; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.CollegeId) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.CollegeId, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.CollegeId] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsStuEN SetCollegeName(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convCurrEduClsStu.CollegeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsStuEN SetLessonQtyPerWeek(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, short? shtLessonQtyPerWeek, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsStuEN SetMark(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, double? dblMark, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsStuEN SetIdUniZone(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strIdUniZone, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdUniZone, 4, convCurrEduClsStu.IdUniZone);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdUniZone, 4, convCurrEduClsStu.IdUniZone);
}
objvCurrEduClsStuEN.IdUniZone = strIdUniZone; //校区流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.IdUniZone) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.IdUniZone, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.IdUniZone] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsStuEN SetGradeBaseName(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strGradeBaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convCurrEduClsStu.GradeBaseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsStuEN SetIdCourseType(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strIdCourseType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCourseType, 4, convCurrEduClsStu.IdCourseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCourseType, 4, convCurrEduClsStu.IdCourseType);
}
objvCurrEduClsStuEN.IdCourseType = strIdCourseType; //课程类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.IdCourseType) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.IdCourseType, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.IdCourseType] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsStuEN SetCourseTypeId(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strCourseTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseTypeId, 4, convCurrEduClsStu.CourseTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseTypeId, 4, convCurrEduClsStu.CourseTypeId);
}
objvCurrEduClsStuEN.CourseTypeId = strCourseTypeId; //课程类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.CourseTypeId) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.CourseTypeId, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.CourseTypeId] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsStuEN SetCourseTypeName(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strCourseTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseTypeName, 30, convCurrEduClsStu.CourseTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsStuEN SetCurrStuNum(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, int? intCurrStuNum, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsStuEN SetIdStu(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strIdStu, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStu, 8, convCurrEduClsStu.IdStu);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStu, 8, convCurrEduClsStu.IdStu);
}
objvCurrEduClsStuEN.IdStu = strIdStu; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.IdStu) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.IdStu, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.IdStu] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsStuEN SetStuId(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strStuId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuId, 20, convCurrEduClsStu.StuId);
}
objvCurrEduClsStuEN.StuId = strStuId; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.StuId) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.StuId, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.StuId] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsStuEN SetStuName(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strStuName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuName, 50, convCurrEduClsStu.StuName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsStuEN SetIdSex(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strIdSex, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdSex, convCurrEduClsStu.IdSex);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSex, 4, convCurrEduClsStu.IdSex);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSex, 4, convCurrEduClsStu.IdSex);
}
objvCurrEduClsStuEN.IdSex = strIdSex; //性别流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.IdSex) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.IdSex, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.IdSex] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsStuEN SetSexDesc(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strSexDesc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSexDesc, 10, convCurrEduClsStu.SexDesc);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsStuEN SetMajorID(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strMajorID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorID, 4, convCurrEduClsStu.MajorID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convCurrEduClsStu.MajorID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsStuEN SetMajorName(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strMajorName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convCurrEduClsStu.MajorName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsStuEN SetIdAdminCls(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strIdAdminCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdAdminCls, 8, convCurrEduClsStu.IdAdminCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdAdminCls, 8, convCurrEduClsStu.IdAdminCls);
}
objvCurrEduClsStuEN.IdAdminCls = strIdAdminCls; //行政班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.IdAdminCls) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.IdAdminCls, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.IdAdminCls] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsStuEN SetBirthday(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strBirthday, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strBirthday, 8, convCurrEduClsStu.Birthday);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strBirthday, 8, convCurrEduClsStu.Birthday);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsStuEN SetEduClsStuStateId(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strEduClsStuStateId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduClsStuStateId, 2, convCurrEduClsStu.EduClsStuStateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strEduClsStuStateId, 2, convCurrEduClsStu.EduClsStuStateId);
}
objvCurrEduClsStuEN.EduClsStuStateId = strEduClsStuStateId; //教学班学生状态编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.EduClsStuStateId) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.EduClsStuStateId, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.EduClsStuStateId] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsStuEN SetGetScoreTimes(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, short? shtGetScoreTimes, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsStuEN SetScore(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, double? dblScore, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsStuEN SetTotalScores(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, double? dblTotalScores, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsStuEN SetRanking(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, int? intRanking, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsStuEN SetPercentile(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, double? dblPercentile, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsStuEN SetSchoolTerm(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strSchoolTerm, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, convCurrEduClsStu.SchoolTerm);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, convCurrEduClsStu.SchoolTerm);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsStuEN SetSchoolYear(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strSchoolYear, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, convCurrEduClsStu.SchoolYear);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsStuEN SetSignInDate(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strSignInDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSignInDate, 20, convCurrEduClsStu.SignInDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsStuEN SetSignInStateID(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strSignInStateID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSignInStateID, 2, convCurrEduClsStu.SignInStateID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSignInStateID, 2, convCurrEduClsStu.SignInStateID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsStuEN SetSignInUser(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strSignInUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSignInUser, 18, convCurrEduClsStu.SignInUser);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsStuEN SetModifyDate(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strModifyDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModifyDate, 20, convCurrEduClsStu.ModifyDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsStuEN SetModifyUserId(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strModifyUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModifyUserId, 18, convCurrEduClsStu.ModifyUserId);
}
objvCurrEduClsStuEN.ModifyUserId = strModifyUserId; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.ModifyUserId) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.ModifyUserId, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.ModifyUserId] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsStuEN SetCollegeName4Stu(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strCollegeName4Stu, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName4Stu, 100, convCurrEduClsStu.CollegeName4Stu);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsStuEN SetEduClsTypeName(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strEduClsTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduClsTypeName, 100, convCurrEduClsStu.EduClsTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsStuEN SetEduClsTypeId(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strEduClsTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduClsTypeId, 4, convCurrEduClsStu.EduClsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strEduClsTypeId, 4, convCurrEduClsStu.EduClsTypeId);
}
objvCurrEduClsStuEN.EduClsTypeId = strEduClsTypeId; //教学班类型Id
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
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduClsStuEN SetUserType(this clsvCurrEduClsStuEN objvCurrEduClsStuEN, string strUserType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserType, 50, convCurrEduClsStu.UserType);
}
objvCurrEduClsStuEN.UserType = strUserType; //用户类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(convCurrEduClsStu.UserType) == false)
{
objvCurrEduClsStuEN.dicFldComparisonOp.Add(convCurrEduClsStu.UserType, strComparisonOp);
}
else
{
objvCurrEduClsStuEN.dicFldComparisonOp[convCurrEduClsStu.UserType] = strComparisonOp;
}
}
return objvCurrEduClsStuEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvCurrEduClsStuENS">源对象</param>
 /// <param name = "objvCurrEduClsStuENT">目标对象</param>
 public static void CopyTo(this clsvCurrEduClsStuEN objvCurrEduClsStuENS, clsvCurrEduClsStuEN objvCurrEduClsStuENT)
{
try
{
objvCurrEduClsStuENT.IdEduClsStu = objvCurrEduClsStuENS.IdEduClsStu; //教学班学生流水号
objvCurrEduClsStuENT.IdCurrEduCls = objvCurrEduClsStuENS.IdCurrEduCls; //教学班流水号
objvCurrEduClsStuENT.CurrEduClsId = objvCurrEduClsStuENS.CurrEduClsId; //教学班Id
objvCurrEduClsStuENT.EduClsName = objvCurrEduClsStuENS.EduClsName; //教学班名
objvCurrEduClsStuENT.CourseId = objvCurrEduClsStuENS.CourseId; //课程Id
objvCurrEduClsStuENT.CourseCode = objvCurrEduClsStuENS.CourseCode; //课程代码
objvCurrEduClsStuENT.CourseName = objvCurrEduClsStuENS.CourseName; //课程名称
objvCurrEduClsStuENT.TeachingSolutionId = objvCurrEduClsStuENS.TeachingSolutionId; //教学方案Id
objvCurrEduClsStuENT.TeachingSolutionName = objvCurrEduClsStuENS.TeachingSolutionName; //教学方案名称
objvCurrEduClsStuENT.IdXzCollege = objvCurrEduClsStuENS.IdXzCollege; //学院流水号
objvCurrEduClsStuENT.CollegeId = objvCurrEduClsStuENS.CollegeId; //学院ID
objvCurrEduClsStuENT.CollegeName = objvCurrEduClsStuENS.CollegeName; //学院名称
objvCurrEduClsStuENT.LessonQtyPerWeek = objvCurrEduClsStuENS.LessonQtyPerWeek; //周课时数
objvCurrEduClsStuENT.Mark = objvCurrEduClsStuENS.Mark; //获得学分
objvCurrEduClsStuENT.IdUniZone = objvCurrEduClsStuENS.IdUniZone; //校区流水号
objvCurrEduClsStuENT.GradeBaseName = objvCurrEduClsStuENS.GradeBaseName; //年级名称
objvCurrEduClsStuENT.IsEffective = objvCurrEduClsStuENS.IsEffective; //是否有效
objvCurrEduClsStuENT.IdCourseType = objvCurrEduClsStuENS.IdCourseType; //课程类型流水号
objvCurrEduClsStuENT.CourseTypeId = objvCurrEduClsStuENS.CourseTypeId; //课程类型ID
objvCurrEduClsStuENT.CourseTypeName = objvCurrEduClsStuENS.CourseTypeName; //课程类型名称
objvCurrEduClsStuENT.IsDegree = objvCurrEduClsStuENS.IsDegree; //是否学位课
objvCurrEduClsStuENT.CurrStuNum = objvCurrEduClsStuENS.CurrStuNum; //当前学生数
objvCurrEduClsStuENT.IdStu = objvCurrEduClsStuENS.IdStu; //学生流水号
objvCurrEduClsStuENT.StuId = objvCurrEduClsStuENS.StuId; //学号
objvCurrEduClsStuENT.StuName = objvCurrEduClsStuENS.StuName; //姓名
objvCurrEduClsStuENT.IdSex = objvCurrEduClsStuENS.IdSex; //性别流水号
objvCurrEduClsStuENT.SexDesc = objvCurrEduClsStuENS.SexDesc; //性别名称
objvCurrEduClsStuENT.MajorID = objvCurrEduClsStuENS.MajorID; //专业ID
objvCurrEduClsStuENT.MajorName = objvCurrEduClsStuENS.MajorName; //专业名称
objvCurrEduClsStuENT.IdAdminCls = objvCurrEduClsStuENS.IdAdminCls; //行政班流水号
objvCurrEduClsStuENT.Birthday = objvCurrEduClsStuENS.Birthday; //出生日期
objvCurrEduClsStuENT.EduClsStuStateId = objvCurrEduClsStuENS.EduClsStuStateId; //教学班学生状态编号
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
objvCurrEduClsStuENT.ModifyUserId = objvCurrEduClsStuENS.ModifyUserId; //修改人
objvCurrEduClsStuENT.CollegeName4Stu = objvCurrEduClsStuENS.CollegeName4Stu; //CollegeName4Stu
objvCurrEduClsStuENT.EduClsTypeName = objvCurrEduClsStuENS.EduClsTypeName; //教学班类型名称
objvCurrEduClsStuENT.IsSynScore = objvCurrEduClsStuENS.IsSynScore; //是否同步成绩
objvCurrEduClsStuENT.EduClsTypeId = objvCurrEduClsStuENS.EduClsTypeId; //教学班类型Id
objvCurrEduClsStuENT.UserType = objvCurrEduClsStuENS.UserType; //用户类型
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
 /// <param name = "objvCurrEduClsStuENS">源对象</param>
 /// <returns>目标对象=>clsvCurrEduClsStuEN:objvCurrEduClsStuENT</returns>
 public static clsvCurrEduClsStuEN CopyTo(this clsvCurrEduClsStuEN objvCurrEduClsStuENS)
{
try
{
 clsvCurrEduClsStuEN objvCurrEduClsStuENT = new clsvCurrEduClsStuEN()
{
IdEduClsStu = objvCurrEduClsStuENS.IdEduClsStu, //教学班学生流水号
IdCurrEduCls = objvCurrEduClsStuENS.IdCurrEduCls, //教学班流水号
CurrEduClsId = objvCurrEduClsStuENS.CurrEduClsId, //教学班Id
EduClsName = objvCurrEduClsStuENS.EduClsName, //教学班名
CourseId = objvCurrEduClsStuENS.CourseId, //课程Id
CourseCode = objvCurrEduClsStuENS.CourseCode, //课程代码
CourseName = objvCurrEduClsStuENS.CourseName, //课程名称
TeachingSolutionId = objvCurrEduClsStuENS.TeachingSolutionId, //教学方案Id
TeachingSolutionName = objvCurrEduClsStuENS.TeachingSolutionName, //教学方案名称
IdXzCollege = objvCurrEduClsStuENS.IdXzCollege, //学院流水号
CollegeId = objvCurrEduClsStuENS.CollegeId, //学院ID
CollegeName = objvCurrEduClsStuENS.CollegeName, //学院名称
LessonQtyPerWeek = objvCurrEduClsStuENS.LessonQtyPerWeek, //周课时数
Mark = objvCurrEduClsStuENS.Mark, //获得学分
IdUniZone = objvCurrEduClsStuENS.IdUniZone, //校区流水号
GradeBaseName = objvCurrEduClsStuENS.GradeBaseName, //年级名称
IsEffective = objvCurrEduClsStuENS.IsEffective, //是否有效
IdCourseType = objvCurrEduClsStuENS.IdCourseType, //课程类型流水号
CourseTypeId = objvCurrEduClsStuENS.CourseTypeId, //课程类型ID
CourseTypeName = objvCurrEduClsStuENS.CourseTypeName, //课程类型名称
IsDegree = objvCurrEduClsStuENS.IsDegree, //是否学位课
CurrStuNum = objvCurrEduClsStuENS.CurrStuNum, //当前学生数
IdStu = objvCurrEduClsStuENS.IdStu, //学生流水号
StuId = objvCurrEduClsStuENS.StuId, //学号
StuName = objvCurrEduClsStuENS.StuName, //姓名
IdSex = objvCurrEduClsStuENS.IdSex, //性别流水号
SexDesc = objvCurrEduClsStuENS.SexDesc, //性别名称
MajorID = objvCurrEduClsStuENS.MajorID, //专业ID
MajorName = objvCurrEduClsStuENS.MajorName, //专业名称
IdAdminCls = objvCurrEduClsStuENS.IdAdminCls, //行政班流水号
Birthday = objvCurrEduClsStuENS.Birthday, //出生日期
EduClsStuStateId = objvCurrEduClsStuENS.EduClsStuStateId, //教学班学生状态编号
GetScoreTimes = objvCurrEduClsStuENS.GetScoreTimes, //获得成绩次数
Score = objvCurrEduClsStuENS.Score, //得分
TotalScores = objvCurrEduClsStuENS.TotalScores, //总分值
Ranking = objvCurrEduClsStuENS.Ranking, //名次
Percentile = objvCurrEduClsStuENS.Percentile, //百分位
Confirmed = objvCurrEduClsStuENS.Confirmed, //是否确认
SchoolTerm = objvCurrEduClsStuENS.SchoolTerm, //学期
SchoolYear = objvCurrEduClsStuENS.SchoolYear, //学年
SignInDate = objvCurrEduClsStuENS.SignInDate, //签入时间
SignInStateID = objvCurrEduClsStuENS.SignInStateID, //签入状态表流水号
SignInUser = objvCurrEduClsStuENS.SignInUser, //签入人
ModifyDate = objvCurrEduClsStuENS.ModifyDate, //修改日期
ModifyUserId = objvCurrEduClsStuENS.ModifyUserId, //修改人
CollegeName4Stu = objvCurrEduClsStuENS.CollegeName4Stu, //CollegeName4Stu
EduClsTypeName = objvCurrEduClsStuENS.EduClsTypeName, //教学班类型名称
IsSynScore = objvCurrEduClsStuENS.IsSynScore, //是否同步成绩
EduClsTypeId = objvCurrEduClsStuENS.EduClsTypeId, //教学班类型Id
UserType = objvCurrEduClsStuENS.UserType, //用户类型
};
 return objvCurrEduClsStuENT;
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
public static void CheckProperty4Condition(this clsvCurrEduClsStuEN objvCurrEduClsStuEN)
{
 clsvCurrEduClsStuBL.vCurrEduClsStuDA.CheckProperty4Condition(objvCurrEduClsStuEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCurrEduClsStuEN objvCurrEduClsStuCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCurrEduClsStuCond.IsUpdated(convCurrEduClsStu.IdEduClsStu) == true)
{
string strComparisonOpIdEduClsStu = objvCurrEduClsStuCond.dicFldComparisonOp[convCurrEduClsStu.IdEduClsStu];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduClsStu.IdEduClsStu, objvCurrEduClsStuCond.IdEduClsStu, strComparisonOpIdEduClsStu);
}
if (objvCurrEduClsStuCond.IsUpdated(convCurrEduClsStu.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvCurrEduClsStuCond.dicFldComparisonOp[convCurrEduClsStu.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.IdCurrEduCls, objvCurrEduClsStuCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvCurrEduClsStuCond.IsUpdated(convCurrEduClsStu.CurrEduClsId) == true)
{
string strComparisonOpCurrEduClsId = objvCurrEduClsStuCond.dicFldComparisonOp[convCurrEduClsStu.CurrEduClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.CurrEduClsId, objvCurrEduClsStuCond.CurrEduClsId, strComparisonOpCurrEduClsId);
}
if (objvCurrEduClsStuCond.IsUpdated(convCurrEduClsStu.EduClsName) == true)
{
string strComparisonOpEduClsName = objvCurrEduClsStuCond.dicFldComparisonOp[convCurrEduClsStu.EduClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.EduClsName, objvCurrEduClsStuCond.EduClsName, strComparisonOpEduClsName);
}
if (objvCurrEduClsStuCond.IsUpdated(convCurrEduClsStu.CourseId) == true)
{
string strComparisonOpCourseId = objvCurrEduClsStuCond.dicFldComparisonOp[convCurrEduClsStu.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.CourseId, objvCurrEduClsStuCond.CourseId, strComparisonOpCourseId);
}
if (objvCurrEduClsStuCond.IsUpdated(convCurrEduClsStu.CourseCode) == true)
{
string strComparisonOpCourseCode = objvCurrEduClsStuCond.dicFldComparisonOp[convCurrEduClsStu.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.CourseCode, objvCurrEduClsStuCond.CourseCode, strComparisonOpCourseCode);
}
if (objvCurrEduClsStuCond.IsUpdated(convCurrEduClsStu.CourseName) == true)
{
string strComparisonOpCourseName = objvCurrEduClsStuCond.dicFldComparisonOp[convCurrEduClsStu.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.CourseName, objvCurrEduClsStuCond.CourseName, strComparisonOpCourseName);
}
if (objvCurrEduClsStuCond.IsUpdated(convCurrEduClsStu.TeachingSolutionId) == true)
{
string strComparisonOpTeachingSolutionId = objvCurrEduClsStuCond.dicFldComparisonOp[convCurrEduClsStu.TeachingSolutionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.TeachingSolutionId, objvCurrEduClsStuCond.TeachingSolutionId, strComparisonOpTeachingSolutionId);
}
if (objvCurrEduClsStuCond.IsUpdated(convCurrEduClsStu.TeachingSolutionName) == true)
{
string strComparisonOpTeachingSolutionName = objvCurrEduClsStuCond.dicFldComparisonOp[convCurrEduClsStu.TeachingSolutionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.TeachingSolutionName, objvCurrEduClsStuCond.TeachingSolutionName, strComparisonOpTeachingSolutionName);
}
if (objvCurrEduClsStuCond.IsUpdated(convCurrEduClsStu.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvCurrEduClsStuCond.dicFldComparisonOp[convCurrEduClsStu.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.IdXzCollege, objvCurrEduClsStuCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvCurrEduClsStuCond.IsUpdated(convCurrEduClsStu.CollegeId) == true)
{
string strComparisonOpCollegeId = objvCurrEduClsStuCond.dicFldComparisonOp[convCurrEduClsStu.CollegeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.CollegeId, objvCurrEduClsStuCond.CollegeId, strComparisonOpCollegeId);
}
if (objvCurrEduClsStuCond.IsUpdated(convCurrEduClsStu.CollegeName) == true)
{
string strComparisonOpCollegeName = objvCurrEduClsStuCond.dicFldComparisonOp[convCurrEduClsStu.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.CollegeName, objvCurrEduClsStuCond.CollegeName, strComparisonOpCollegeName);
}
//数据类型short(smallint)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvCurrEduClsStuCond.IsUpdated(convCurrEduClsStu.Mark) == true)
{
string strComparisonOpMark = objvCurrEduClsStuCond.dicFldComparisonOp[convCurrEduClsStu.Mark];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduClsStu.Mark, objvCurrEduClsStuCond.Mark, strComparisonOpMark);
}
if (objvCurrEduClsStuCond.IsUpdated(convCurrEduClsStu.IdUniZone) == true)
{
string strComparisonOpIdUniZone = objvCurrEduClsStuCond.dicFldComparisonOp[convCurrEduClsStu.IdUniZone];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.IdUniZone, objvCurrEduClsStuCond.IdUniZone, strComparisonOpIdUniZone);
}
if (objvCurrEduClsStuCond.IsUpdated(convCurrEduClsStu.GradeBaseName) == true)
{
string strComparisonOpGradeBaseName = objvCurrEduClsStuCond.dicFldComparisonOp[convCurrEduClsStu.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.GradeBaseName, objvCurrEduClsStuCond.GradeBaseName, strComparisonOpGradeBaseName);
}
if (objvCurrEduClsStuCond.IsUpdated(convCurrEduClsStu.IsEffective) == true)
{
if (objvCurrEduClsStuCond.IsEffective == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduClsStu.IsEffective);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduClsStu.IsEffective);
}
}
if (objvCurrEduClsStuCond.IsUpdated(convCurrEduClsStu.IdCourseType) == true)
{
string strComparisonOpIdCourseType = objvCurrEduClsStuCond.dicFldComparisonOp[convCurrEduClsStu.IdCourseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.IdCourseType, objvCurrEduClsStuCond.IdCourseType, strComparisonOpIdCourseType);
}
if (objvCurrEduClsStuCond.IsUpdated(convCurrEduClsStu.CourseTypeId) == true)
{
string strComparisonOpCourseTypeId = objvCurrEduClsStuCond.dicFldComparisonOp[convCurrEduClsStu.CourseTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.CourseTypeId, objvCurrEduClsStuCond.CourseTypeId, strComparisonOpCourseTypeId);
}
if (objvCurrEduClsStuCond.IsUpdated(convCurrEduClsStu.CourseTypeName) == true)
{
string strComparisonOpCourseTypeName = objvCurrEduClsStuCond.dicFldComparisonOp[convCurrEduClsStu.CourseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.CourseTypeName, objvCurrEduClsStuCond.CourseTypeName, strComparisonOpCourseTypeName);
}
if (objvCurrEduClsStuCond.IsUpdated(convCurrEduClsStu.IsDegree) == true)
{
if (objvCurrEduClsStuCond.IsDegree == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduClsStu.IsDegree);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduClsStu.IsDegree);
}
}
if (objvCurrEduClsStuCond.IsUpdated(convCurrEduClsStu.CurrStuNum) == true)
{
string strComparisonOpCurrStuNum = objvCurrEduClsStuCond.dicFldComparisonOp[convCurrEduClsStu.CurrStuNum];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduClsStu.CurrStuNum, objvCurrEduClsStuCond.CurrStuNum, strComparisonOpCurrStuNum);
}
if (objvCurrEduClsStuCond.IsUpdated(convCurrEduClsStu.IdStu) == true)
{
string strComparisonOpIdStu = objvCurrEduClsStuCond.dicFldComparisonOp[convCurrEduClsStu.IdStu];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.IdStu, objvCurrEduClsStuCond.IdStu, strComparisonOpIdStu);
}
if (objvCurrEduClsStuCond.IsUpdated(convCurrEduClsStu.StuId) == true)
{
string strComparisonOpStuId = objvCurrEduClsStuCond.dicFldComparisonOp[convCurrEduClsStu.StuId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.StuId, objvCurrEduClsStuCond.StuId, strComparisonOpStuId);
}
if (objvCurrEduClsStuCond.IsUpdated(convCurrEduClsStu.StuName) == true)
{
string strComparisonOpStuName = objvCurrEduClsStuCond.dicFldComparisonOp[convCurrEduClsStu.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.StuName, objvCurrEduClsStuCond.StuName, strComparisonOpStuName);
}
if (objvCurrEduClsStuCond.IsUpdated(convCurrEduClsStu.IdSex) == true)
{
string strComparisonOpIdSex = objvCurrEduClsStuCond.dicFldComparisonOp[convCurrEduClsStu.IdSex];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.IdSex, objvCurrEduClsStuCond.IdSex, strComparisonOpIdSex);
}
if (objvCurrEduClsStuCond.IsUpdated(convCurrEduClsStu.SexDesc) == true)
{
string strComparisonOpSexDesc = objvCurrEduClsStuCond.dicFldComparisonOp[convCurrEduClsStu.SexDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.SexDesc, objvCurrEduClsStuCond.SexDesc, strComparisonOpSexDesc);
}
if (objvCurrEduClsStuCond.IsUpdated(convCurrEduClsStu.MajorID) == true)
{
string strComparisonOpMajorID = objvCurrEduClsStuCond.dicFldComparisonOp[convCurrEduClsStu.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.MajorID, objvCurrEduClsStuCond.MajorID, strComparisonOpMajorID);
}
if (objvCurrEduClsStuCond.IsUpdated(convCurrEduClsStu.MajorName) == true)
{
string strComparisonOpMajorName = objvCurrEduClsStuCond.dicFldComparisonOp[convCurrEduClsStu.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.MajorName, objvCurrEduClsStuCond.MajorName, strComparisonOpMajorName);
}
if (objvCurrEduClsStuCond.IsUpdated(convCurrEduClsStu.IdAdminCls) == true)
{
string strComparisonOpIdAdminCls = objvCurrEduClsStuCond.dicFldComparisonOp[convCurrEduClsStu.IdAdminCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.IdAdminCls, objvCurrEduClsStuCond.IdAdminCls, strComparisonOpIdAdminCls);
}
if (objvCurrEduClsStuCond.IsUpdated(convCurrEduClsStu.Birthday) == true)
{
string strComparisonOpBirthday = objvCurrEduClsStuCond.dicFldComparisonOp[convCurrEduClsStu.Birthday];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.Birthday, objvCurrEduClsStuCond.Birthday, strComparisonOpBirthday);
}
if (objvCurrEduClsStuCond.IsUpdated(convCurrEduClsStu.EduClsStuStateId) == true)
{
string strComparisonOpEduClsStuStateId = objvCurrEduClsStuCond.dicFldComparisonOp[convCurrEduClsStu.EduClsStuStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.EduClsStuStateId, objvCurrEduClsStuCond.EduClsStuStateId, strComparisonOpEduClsStuStateId);
}
//数据类型short(tinyint)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvCurrEduClsStuCond.IsUpdated(convCurrEduClsStu.Score) == true)
{
string strComparisonOpScore = objvCurrEduClsStuCond.dicFldComparisonOp[convCurrEduClsStu.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduClsStu.Score, objvCurrEduClsStuCond.Score, strComparisonOpScore);
}
if (objvCurrEduClsStuCond.IsUpdated(convCurrEduClsStu.TotalScores) == true)
{
string strComparisonOpTotalScores = objvCurrEduClsStuCond.dicFldComparisonOp[convCurrEduClsStu.TotalScores];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduClsStu.TotalScores, objvCurrEduClsStuCond.TotalScores, strComparisonOpTotalScores);
}
if (objvCurrEduClsStuCond.IsUpdated(convCurrEduClsStu.Ranking) == true)
{
string strComparisonOpRanking = objvCurrEduClsStuCond.dicFldComparisonOp[convCurrEduClsStu.Ranking];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduClsStu.Ranking, objvCurrEduClsStuCond.Ranking, strComparisonOpRanking);
}
if (objvCurrEduClsStuCond.IsUpdated(convCurrEduClsStu.Percentile) == true)
{
string strComparisonOpPercentile = objvCurrEduClsStuCond.dicFldComparisonOp[convCurrEduClsStu.Percentile];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduClsStu.Percentile, objvCurrEduClsStuCond.Percentile, strComparisonOpPercentile);
}
if (objvCurrEduClsStuCond.IsUpdated(convCurrEduClsStu.Confirmed) == true)
{
if (objvCurrEduClsStuCond.Confirmed == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduClsStu.Confirmed);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduClsStu.Confirmed);
}
}
if (objvCurrEduClsStuCond.IsUpdated(convCurrEduClsStu.SchoolTerm) == true)
{
string strComparisonOpSchoolTerm = objvCurrEduClsStuCond.dicFldComparisonOp[convCurrEduClsStu.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.SchoolTerm, objvCurrEduClsStuCond.SchoolTerm, strComparisonOpSchoolTerm);
}
if (objvCurrEduClsStuCond.IsUpdated(convCurrEduClsStu.SchoolYear) == true)
{
string strComparisonOpSchoolYear = objvCurrEduClsStuCond.dicFldComparisonOp[convCurrEduClsStu.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.SchoolYear, objvCurrEduClsStuCond.SchoolYear, strComparisonOpSchoolYear);
}
if (objvCurrEduClsStuCond.IsUpdated(convCurrEduClsStu.SignInDate) == true)
{
string strComparisonOpSignInDate = objvCurrEduClsStuCond.dicFldComparisonOp[convCurrEduClsStu.SignInDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.SignInDate, objvCurrEduClsStuCond.SignInDate, strComparisonOpSignInDate);
}
if (objvCurrEduClsStuCond.IsUpdated(convCurrEduClsStu.SignInStateID) == true)
{
string strComparisonOpSignInStateID = objvCurrEduClsStuCond.dicFldComparisonOp[convCurrEduClsStu.SignInStateID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.SignInStateID, objvCurrEduClsStuCond.SignInStateID, strComparisonOpSignInStateID);
}
if (objvCurrEduClsStuCond.IsUpdated(convCurrEduClsStu.SignInUser) == true)
{
string strComparisonOpSignInUser = objvCurrEduClsStuCond.dicFldComparisonOp[convCurrEduClsStu.SignInUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.SignInUser, objvCurrEduClsStuCond.SignInUser, strComparisonOpSignInUser);
}
if (objvCurrEduClsStuCond.IsUpdated(convCurrEduClsStu.ModifyDate) == true)
{
string strComparisonOpModifyDate = objvCurrEduClsStuCond.dicFldComparisonOp[convCurrEduClsStu.ModifyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.ModifyDate, objvCurrEduClsStuCond.ModifyDate, strComparisonOpModifyDate);
}
if (objvCurrEduClsStuCond.IsUpdated(convCurrEduClsStu.ModifyUserId) == true)
{
string strComparisonOpModifyUserId = objvCurrEduClsStuCond.dicFldComparisonOp[convCurrEduClsStu.ModifyUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.ModifyUserId, objvCurrEduClsStuCond.ModifyUserId, strComparisonOpModifyUserId);
}
if (objvCurrEduClsStuCond.IsUpdated(convCurrEduClsStu.CollegeName4Stu) == true)
{
string strComparisonOpCollegeName4Stu = objvCurrEduClsStuCond.dicFldComparisonOp[convCurrEduClsStu.CollegeName4Stu];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.CollegeName4Stu, objvCurrEduClsStuCond.CollegeName4Stu, strComparisonOpCollegeName4Stu);
}
if (objvCurrEduClsStuCond.IsUpdated(convCurrEduClsStu.EduClsTypeName) == true)
{
string strComparisonOpEduClsTypeName = objvCurrEduClsStuCond.dicFldComparisonOp[convCurrEduClsStu.EduClsTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.EduClsTypeName, objvCurrEduClsStuCond.EduClsTypeName, strComparisonOpEduClsTypeName);
}
if (objvCurrEduClsStuCond.IsUpdated(convCurrEduClsStu.IsSynScore) == true)
{
if (objvCurrEduClsStuCond.IsSynScore == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduClsStu.IsSynScore);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduClsStu.IsSynScore);
}
}
if (objvCurrEduClsStuCond.IsUpdated(convCurrEduClsStu.EduClsTypeId) == true)
{
string strComparisonOpEduClsTypeId = objvCurrEduClsStuCond.dicFldComparisonOp[convCurrEduClsStu.EduClsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.EduClsTypeId, objvCurrEduClsStuCond.EduClsTypeId, strComparisonOpEduClsTypeId);
}
if (objvCurrEduClsStuCond.IsUpdated(convCurrEduClsStu.UserType) == true)
{
string strComparisonOpUserType = objvCurrEduClsStuCond.dicFldComparisonOp[convCurrEduClsStu.UserType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduClsStu.UserType, objvCurrEduClsStuCond.UserType, strComparisonOpUserType);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vCurrEduClsStu
{
public virtual bool UpdRelaTabDate(long lngIdEduClsStu, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v教学班与学生关系(vCurrEduClsStu)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvCurrEduClsStuBL
{
public static RelatedActions_vCurrEduClsStu relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvCurrEduClsStuDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvCurrEduClsStuDA vCurrEduClsStuDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvCurrEduClsStuDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvCurrEduClsStuBL()
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
if (string.IsNullOrEmpty(clsvCurrEduClsStuEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCurrEduClsStuEN._ConnectString);
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
public static DataTable GetDataTable_vCurrEduClsStu(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vCurrEduClsStuDA.GetDataTable_vCurrEduClsStu(strWhereCond);
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
objDT = vCurrEduClsStuDA.GetDataTable(strWhereCond);
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
objDT = vCurrEduClsStuDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vCurrEduClsStuDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vCurrEduClsStuDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vCurrEduClsStuDA.GetDataTable_Top(objTopPara);
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
objDT = vCurrEduClsStuDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vCurrEduClsStuDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vCurrEduClsStuDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdEduClsStuLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvCurrEduClsStuEN> GetObjLstByIdEduClsStuLst(List<long> arrIdEduClsStuLst)
{
List<clsvCurrEduClsStuEN> arrObjLst = new List<clsvCurrEduClsStuEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdEduClsStuLst);
 string strWhereCond = string.Format("IdEduClsStu in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduClsStuEN objvCurrEduClsStuEN = new clsvCurrEduClsStuEN();
try
{
objvCurrEduClsStuEN.IdEduClsStu = Int32.Parse(objRow[convCurrEduClsStu.IdEduClsStu].ToString().Trim()); //教学班学生流水号
objvCurrEduClsStuEN.IdCurrEduCls = objRow[convCurrEduClsStu.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduClsStuEN.CurrEduClsId = objRow[convCurrEduClsStu.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduClsStuEN.EduClsName = objRow[convCurrEduClsStu.EduClsName].ToString().Trim(); //教学班名
objvCurrEduClsStuEN.CourseId = objRow[convCurrEduClsStu.CourseId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseId].ToString().Trim(); //课程Id
objvCurrEduClsStuEN.CourseCode = objRow[convCurrEduClsStu.CourseCode] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseCode].ToString().Trim(); //课程代码
objvCurrEduClsStuEN.CourseName = objRow[convCurrEduClsStu.CourseName] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseName].ToString().Trim(); //课程名称
objvCurrEduClsStuEN.TeachingSolutionId = objRow[convCurrEduClsStu.TeachingSolutionId] == DBNull.Value ? null : objRow[convCurrEduClsStu.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduClsStuEN.TeachingSolutionName = objRow[convCurrEduClsStu.TeachingSolutionName] == DBNull.Value ? null : objRow[convCurrEduClsStu.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduClsStuEN.IdXzCollege = objRow[convCurrEduClsStu.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduClsStuEN.CollegeId = objRow[convCurrEduClsStu.CollegeId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CollegeId].ToString().Trim(); //学院ID
objvCurrEduClsStuEN.CollegeName = objRow[convCurrEduClsStu.CollegeName] == DBNull.Value ? null : objRow[convCurrEduClsStu.CollegeName].ToString().Trim(); //学院名称
objvCurrEduClsStuEN.LessonQtyPerWeek = objRow[convCurrEduClsStu.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsStu.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduClsStuEN.Mark = objRow[convCurrEduClsStu.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduClsStu.Mark].ToString().Trim()); //获得学分
objvCurrEduClsStuEN.IdUniZone = objRow[convCurrEduClsStu.IdUniZone] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduClsStuEN.GradeBaseName = objRow[convCurrEduClsStu.GradeBaseName] == DBNull.Value ? null : objRow[convCurrEduClsStu.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduClsStuEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsStu.IsEffective].ToString().Trim()); //是否有效
objvCurrEduClsStuEN.IdCourseType = objRow[convCurrEduClsStu.IdCourseType] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduClsStuEN.CourseTypeId = objRow[convCurrEduClsStu.CourseTypeId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduClsStuEN.CourseTypeName = objRow[convCurrEduClsStu.CourseTypeName] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduClsStuEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsStu.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduClsStuEN.CurrStuNum = objRow[convCurrEduClsStu.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsStu.CurrStuNum].ToString().Trim()); //当前学生数
objvCurrEduClsStuEN.IdStu = objRow[convCurrEduClsStu.IdStu] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdStu].ToString().Trim(); //学生流水号
objvCurrEduClsStuEN.StuId = objRow[convCurrEduClsStu.StuId] == DBNull.Value ? null : objRow[convCurrEduClsStu.StuId].ToString().Trim(); //学号
objvCurrEduClsStuEN.StuName = objRow[convCurrEduClsStu.StuName] == DBNull.Value ? null : objRow[convCurrEduClsStu.StuName].ToString().Trim(); //姓名
objvCurrEduClsStuEN.IdSex = objRow[convCurrEduClsStu.IdSex].ToString().Trim(); //性别流水号
objvCurrEduClsStuEN.SexDesc = objRow[convCurrEduClsStu.SexDesc] == DBNull.Value ? null : objRow[convCurrEduClsStu.SexDesc].ToString().Trim(); //性别名称
objvCurrEduClsStuEN.MajorID = objRow[convCurrEduClsStu.MajorID] == DBNull.Value ? null : objRow[convCurrEduClsStu.MajorID].ToString().Trim(); //专业ID
objvCurrEduClsStuEN.MajorName = objRow[convCurrEduClsStu.MajorName] == DBNull.Value ? null : objRow[convCurrEduClsStu.MajorName].ToString().Trim(); //专业名称
objvCurrEduClsStuEN.IdAdminCls = objRow[convCurrEduClsStu.IdAdminCls] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdAdminCls].ToString().Trim(); //行政班流水号
objvCurrEduClsStuEN.Birthday = objRow[convCurrEduClsStu.Birthday] == DBNull.Value ? null : objRow[convCurrEduClsStu.Birthday].ToString().Trim(); //出生日期
objvCurrEduClsStuEN.EduClsStuStateId = objRow[convCurrEduClsStu.EduClsStuStateId] == DBNull.Value ? null : objRow[convCurrEduClsStu.EduClsStuStateId].ToString().Trim(); //教学班学生状态编号
objvCurrEduClsStuEN.GetScoreTimes = objRow[convCurrEduClsStu.GetScoreTimes] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsStu.GetScoreTimes].ToString().Trim()); //获得成绩次数
objvCurrEduClsStuEN.Score = objRow[convCurrEduClsStu.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduClsStu.Score].ToString().Trim()); //得分
objvCurrEduClsStuEN.TotalScores = objRow[convCurrEduClsStu.TotalScores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduClsStu.TotalScores].ToString().Trim()); //总分值
objvCurrEduClsStuEN.Ranking = objRow[convCurrEduClsStu.Ranking] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsStu.Ranking].ToString().Trim()); //名次
objvCurrEduClsStuEN.Percentile = objRow[convCurrEduClsStu.Percentile] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduClsStu.Percentile].ToString().Trim()); //百分位
objvCurrEduClsStuEN.Confirmed = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsStu.Confirmed].ToString().Trim()); //是否确认
objvCurrEduClsStuEN.SchoolTerm = objRow[convCurrEduClsStu.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduClsStu.SchoolTerm].ToString().Trim(); //学期
objvCurrEduClsStuEN.SchoolYear = objRow[convCurrEduClsStu.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduClsStu.SchoolYear].ToString().Trim(); //学年
objvCurrEduClsStuEN.SignInDate = objRow[convCurrEduClsStu.SignInDate] == DBNull.Value ? null : objRow[convCurrEduClsStu.SignInDate].ToString().Trim(); //签入时间
objvCurrEduClsStuEN.SignInStateID = objRow[convCurrEduClsStu.SignInStateID] == DBNull.Value ? null : objRow[convCurrEduClsStu.SignInStateID].ToString().Trim(); //签入状态表流水号
objvCurrEduClsStuEN.SignInUser = objRow[convCurrEduClsStu.SignInUser] == DBNull.Value ? null : objRow[convCurrEduClsStu.SignInUser].ToString().Trim(); //签入人
objvCurrEduClsStuEN.ModifyDate = objRow[convCurrEduClsStu.ModifyDate] == DBNull.Value ? null : objRow[convCurrEduClsStu.ModifyDate].ToString().Trim(); //修改日期
objvCurrEduClsStuEN.ModifyUserId = objRow[convCurrEduClsStu.ModifyUserId] == DBNull.Value ? null : objRow[convCurrEduClsStu.ModifyUserId].ToString().Trim(); //修改人
objvCurrEduClsStuEN.CollegeName4Stu = objRow[convCurrEduClsStu.CollegeName4Stu] == DBNull.Value ? null : objRow[convCurrEduClsStu.CollegeName4Stu].ToString().Trim(); //CollegeName4Stu
objvCurrEduClsStuEN.EduClsTypeName = objRow[convCurrEduClsStu.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduClsStu.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduClsStuEN.IsSynScore = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsStu.IsSynScore].ToString().Trim()); //是否同步成绩
objvCurrEduClsStuEN.EduClsTypeId = objRow[convCurrEduClsStu.EduClsTypeId] == DBNull.Value ? null : objRow[convCurrEduClsStu.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduClsStuEN.UserType = objRow[convCurrEduClsStu.UserType] == DBNull.Value ? null : objRow[convCurrEduClsStu.UserType].ToString().Trim(); //用户类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCurrEduClsStuEN.IdEduClsStu, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCurrEduClsStuEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdEduClsStuLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvCurrEduClsStuEN> GetObjLstByIdEduClsStuLstCache(List<long> arrIdEduClsStuLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsvCurrEduClsStuEN._CurrTabName, strIdCurrEduCls);
List<clsvCurrEduClsStuEN> arrvCurrEduClsStuObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvCurrEduClsStuEN> arrvCurrEduClsStuObjLst_Sel =
arrvCurrEduClsStuObjLstCache
.Where(x => arrIdEduClsStuLst.Contains(x.IdEduClsStu));
return arrvCurrEduClsStuObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCurrEduClsStuEN> GetObjLst(string strWhereCond)
{
List<clsvCurrEduClsStuEN> arrObjLst = new List<clsvCurrEduClsStuEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduClsStuEN objvCurrEduClsStuEN = new clsvCurrEduClsStuEN();
try
{
objvCurrEduClsStuEN.IdEduClsStu = Int32.Parse(objRow[convCurrEduClsStu.IdEduClsStu].ToString().Trim()); //教学班学生流水号
objvCurrEduClsStuEN.IdCurrEduCls = objRow[convCurrEduClsStu.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduClsStuEN.CurrEduClsId = objRow[convCurrEduClsStu.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduClsStuEN.EduClsName = objRow[convCurrEduClsStu.EduClsName].ToString().Trim(); //教学班名
objvCurrEduClsStuEN.CourseId = objRow[convCurrEduClsStu.CourseId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseId].ToString().Trim(); //课程Id
objvCurrEduClsStuEN.CourseCode = objRow[convCurrEduClsStu.CourseCode] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseCode].ToString().Trim(); //课程代码
objvCurrEduClsStuEN.CourseName = objRow[convCurrEduClsStu.CourseName] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseName].ToString().Trim(); //课程名称
objvCurrEduClsStuEN.TeachingSolutionId = objRow[convCurrEduClsStu.TeachingSolutionId] == DBNull.Value ? null : objRow[convCurrEduClsStu.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduClsStuEN.TeachingSolutionName = objRow[convCurrEduClsStu.TeachingSolutionName] == DBNull.Value ? null : objRow[convCurrEduClsStu.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduClsStuEN.IdXzCollege = objRow[convCurrEduClsStu.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduClsStuEN.CollegeId = objRow[convCurrEduClsStu.CollegeId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CollegeId].ToString().Trim(); //学院ID
objvCurrEduClsStuEN.CollegeName = objRow[convCurrEduClsStu.CollegeName] == DBNull.Value ? null : objRow[convCurrEduClsStu.CollegeName].ToString().Trim(); //学院名称
objvCurrEduClsStuEN.LessonQtyPerWeek = objRow[convCurrEduClsStu.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsStu.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduClsStuEN.Mark = objRow[convCurrEduClsStu.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduClsStu.Mark].ToString().Trim()); //获得学分
objvCurrEduClsStuEN.IdUniZone = objRow[convCurrEduClsStu.IdUniZone] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduClsStuEN.GradeBaseName = objRow[convCurrEduClsStu.GradeBaseName] == DBNull.Value ? null : objRow[convCurrEduClsStu.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduClsStuEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsStu.IsEffective].ToString().Trim()); //是否有效
objvCurrEduClsStuEN.IdCourseType = objRow[convCurrEduClsStu.IdCourseType] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduClsStuEN.CourseTypeId = objRow[convCurrEduClsStu.CourseTypeId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduClsStuEN.CourseTypeName = objRow[convCurrEduClsStu.CourseTypeName] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduClsStuEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsStu.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduClsStuEN.CurrStuNum = objRow[convCurrEduClsStu.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsStu.CurrStuNum].ToString().Trim()); //当前学生数
objvCurrEduClsStuEN.IdStu = objRow[convCurrEduClsStu.IdStu] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdStu].ToString().Trim(); //学生流水号
objvCurrEduClsStuEN.StuId = objRow[convCurrEduClsStu.StuId] == DBNull.Value ? null : objRow[convCurrEduClsStu.StuId].ToString().Trim(); //学号
objvCurrEduClsStuEN.StuName = objRow[convCurrEduClsStu.StuName] == DBNull.Value ? null : objRow[convCurrEduClsStu.StuName].ToString().Trim(); //姓名
objvCurrEduClsStuEN.IdSex = objRow[convCurrEduClsStu.IdSex].ToString().Trim(); //性别流水号
objvCurrEduClsStuEN.SexDesc = objRow[convCurrEduClsStu.SexDesc] == DBNull.Value ? null : objRow[convCurrEduClsStu.SexDesc].ToString().Trim(); //性别名称
objvCurrEduClsStuEN.MajorID = objRow[convCurrEduClsStu.MajorID] == DBNull.Value ? null : objRow[convCurrEduClsStu.MajorID].ToString().Trim(); //专业ID
objvCurrEduClsStuEN.MajorName = objRow[convCurrEduClsStu.MajorName] == DBNull.Value ? null : objRow[convCurrEduClsStu.MajorName].ToString().Trim(); //专业名称
objvCurrEduClsStuEN.IdAdminCls = objRow[convCurrEduClsStu.IdAdminCls] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdAdminCls].ToString().Trim(); //行政班流水号
objvCurrEduClsStuEN.Birthday = objRow[convCurrEduClsStu.Birthday] == DBNull.Value ? null : objRow[convCurrEduClsStu.Birthday].ToString().Trim(); //出生日期
objvCurrEduClsStuEN.EduClsStuStateId = objRow[convCurrEduClsStu.EduClsStuStateId] == DBNull.Value ? null : objRow[convCurrEduClsStu.EduClsStuStateId].ToString().Trim(); //教学班学生状态编号
objvCurrEduClsStuEN.GetScoreTimes = objRow[convCurrEduClsStu.GetScoreTimes] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsStu.GetScoreTimes].ToString().Trim()); //获得成绩次数
objvCurrEduClsStuEN.Score = objRow[convCurrEduClsStu.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduClsStu.Score].ToString().Trim()); //得分
objvCurrEduClsStuEN.TotalScores = objRow[convCurrEduClsStu.TotalScores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduClsStu.TotalScores].ToString().Trim()); //总分值
objvCurrEduClsStuEN.Ranking = objRow[convCurrEduClsStu.Ranking] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsStu.Ranking].ToString().Trim()); //名次
objvCurrEduClsStuEN.Percentile = objRow[convCurrEduClsStu.Percentile] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduClsStu.Percentile].ToString().Trim()); //百分位
objvCurrEduClsStuEN.Confirmed = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsStu.Confirmed].ToString().Trim()); //是否确认
objvCurrEduClsStuEN.SchoolTerm = objRow[convCurrEduClsStu.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduClsStu.SchoolTerm].ToString().Trim(); //学期
objvCurrEduClsStuEN.SchoolYear = objRow[convCurrEduClsStu.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduClsStu.SchoolYear].ToString().Trim(); //学年
objvCurrEduClsStuEN.SignInDate = objRow[convCurrEduClsStu.SignInDate] == DBNull.Value ? null : objRow[convCurrEduClsStu.SignInDate].ToString().Trim(); //签入时间
objvCurrEduClsStuEN.SignInStateID = objRow[convCurrEduClsStu.SignInStateID] == DBNull.Value ? null : objRow[convCurrEduClsStu.SignInStateID].ToString().Trim(); //签入状态表流水号
objvCurrEduClsStuEN.SignInUser = objRow[convCurrEduClsStu.SignInUser] == DBNull.Value ? null : objRow[convCurrEduClsStu.SignInUser].ToString().Trim(); //签入人
objvCurrEduClsStuEN.ModifyDate = objRow[convCurrEduClsStu.ModifyDate] == DBNull.Value ? null : objRow[convCurrEduClsStu.ModifyDate].ToString().Trim(); //修改日期
objvCurrEduClsStuEN.ModifyUserId = objRow[convCurrEduClsStu.ModifyUserId] == DBNull.Value ? null : objRow[convCurrEduClsStu.ModifyUserId].ToString().Trim(); //修改人
objvCurrEduClsStuEN.CollegeName4Stu = objRow[convCurrEduClsStu.CollegeName4Stu] == DBNull.Value ? null : objRow[convCurrEduClsStu.CollegeName4Stu].ToString().Trim(); //CollegeName4Stu
objvCurrEduClsStuEN.EduClsTypeName = objRow[convCurrEduClsStu.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduClsStu.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduClsStuEN.IsSynScore = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsStu.IsSynScore].ToString().Trim()); //是否同步成绩
objvCurrEduClsStuEN.EduClsTypeId = objRow[convCurrEduClsStu.EduClsTypeId] == DBNull.Value ? null : objRow[convCurrEduClsStu.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduClsStuEN.UserType = objRow[convCurrEduClsStu.UserType] == DBNull.Value ? null : objRow[convCurrEduClsStu.UserType].ToString().Trim(); //用户类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCurrEduClsStuEN.IdEduClsStu, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCurrEduClsStuEN);
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
public static List<clsvCurrEduClsStuEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvCurrEduClsStuEN> arrObjLst = new List<clsvCurrEduClsStuEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduClsStuEN objvCurrEduClsStuEN = new clsvCurrEduClsStuEN();
try
{
objvCurrEduClsStuEN.IdEduClsStu = Int32.Parse(objRow[convCurrEduClsStu.IdEduClsStu].ToString().Trim()); //教学班学生流水号
objvCurrEduClsStuEN.IdCurrEduCls = objRow[convCurrEduClsStu.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduClsStuEN.CurrEduClsId = objRow[convCurrEduClsStu.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduClsStuEN.EduClsName = objRow[convCurrEduClsStu.EduClsName].ToString().Trim(); //教学班名
objvCurrEduClsStuEN.CourseId = objRow[convCurrEduClsStu.CourseId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseId].ToString().Trim(); //课程Id
objvCurrEduClsStuEN.CourseCode = objRow[convCurrEduClsStu.CourseCode] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseCode].ToString().Trim(); //课程代码
objvCurrEduClsStuEN.CourseName = objRow[convCurrEduClsStu.CourseName] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseName].ToString().Trim(); //课程名称
objvCurrEduClsStuEN.TeachingSolutionId = objRow[convCurrEduClsStu.TeachingSolutionId] == DBNull.Value ? null : objRow[convCurrEduClsStu.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduClsStuEN.TeachingSolutionName = objRow[convCurrEduClsStu.TeachingSolutionName] == DBNull.Value ? null : objRow[convCurrEduClsStu.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduClsStuEN.IdXzCollege = objRow[convCurrEduClsStu.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduClsStuEN.CollegeId = objRow[convCurrEduClsStu.CollegeId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CollegeId].ToString().Trim(); //学院ID
objvCurrEduClsStuEN.CollegeName = objRow[convCurrEduClsStu.CollegeName] == DBNull.Value ? null : objRow[convCurrEduClsStu.CollegeName].ToString().Trim(); //学院名称
objvCurrEduClsStuEN.LessonQtyPerWeek = objRow[convCurrEduClsStu.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsStu.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduClsStuEN.Mark = objRow[convCurrEduClsStu.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduClsStu.Mark].ToString().Trim()); //获得学分
objvCurrEduClsStuEN.IdUniZone = objRow[convCurrEduClsStu.IdUniZone] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduClsStuEN.GradeBaseName = objRow[convCurrEduClsStu.GradeBaseName] == DBNull.Value ? null : objRow[convCurrEduClsStu.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduClsStuEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsStu.IsEffective].ToString().Trim()); //是否有效
objvCurrEduClsStuEN.IdCourseType = objRow[convCurrEduClsStu.IdCourseType] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduClsStuEN.CourseTypeId = objRow[convCurrEduClsStu.CourseTypeId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduClsStuEN.CourseTypeName = objRow[convCurrEduClsStu.CourseTypeName] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduClsStuEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsStu.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduClsStuEN.CurrStuNum = objRow[convCurrEduClsStu.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsStu.CurrStuNum].ToString().Trim()); //当前学生数
objvCurrEduClsStuEN.IdStu = objRow[convCurrEduClsStu.IdStu] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdStu].ToString().Trim(); //学生流水号
objvCurrEduClsStuEN.StuId = objRow[convCurrEduClsStu.StuId] == DBNull.Value ? null : objRow[convCurrEduClsStu.StuId].ToString().Trim(); //学号
objvCurrEduClsStuEN.StuName = objRow[convCurrEduClsStu.StuName] == DBNull.Value ? null : objRow[convCurrEduClsStu.StuName].ToString().Trim(); //姓名
objvCurrEduClsStuEN.IdSex = objRow[convCurrEduClsStu.IdSex].ToString().Trim(); //性别流水号
objvCurrEduClsStuEN.SexDesc = objRow[convCurrEduClsStu.SexDesc] == DBNull.Value ? null : objRow[convCurrEduClsStu.SexDesc].ToString().Trim(); //性别名称
objvCurrEduClsStuEN.MajorID = objRow[convCurrEduClsStu.MajorID] == DBNull.Value ? null : objRow[convCurrEduClsStu.MajorID].ToString().Trim(); //专业ID
objvCurrEduClsStuEN.MajorName = objRow[convCurrEduClsStu.MajorName] == DBNull.Value ? null : objRow[convCurrEduClsStu.MajorName].ToString().Trim(); //专业名称
objvCurrEduClsStuEN.IdAdminCls = objRow[convCurrEduClsStu.IdAdminCls] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdAdminCls].ToString().Trim(); //行政班流水号
objvCurrEduClsStuEN.Birthday = objRow[convCurrEduClsStu.Birthday] == DBNull.Value ? null : objRow[convCurrEduClsStu.Birthday].ToString().Trim(); //出生日期
objvCurrEduClsStuEN.EduClsStuStateId = objRow[convCurrEduClsStu.EduClsStuStateId] == DBNull.Value ? null : objRow[convCurrEduClsStu.EduClsStuStateId].ToString().Trim(); //教学班学生状态编号
objvCurrEduClsStuEN.GetScoreTimes = objRow[convCurrEduClsStu.GetScoreTimes] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsStu.GetScoreTimes].ToString().Trim()); //获得成绩次数
objvCurrEduClsStuEN.Score = objRow[convCurrEduClsStu.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduClsStu.Score].ToString().Trim()); //得分
objvCurrEduClsStuEN.TotalScores = objRow[convCurrEduClsStu.TotalScores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduClsStu.TotalScores].ToString().Trim()); //总分值
objvCurrEduClsStuEN.Ranking = objRow[convCurrEduClsStu.Ranking] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsStu.Ranking].ToString().Trim()); //名次
objvCurrEduClsStuEN.Percentile = objRow[convCurrEduClsStu.Percentile] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduClsStu.Percentile].ToString().Trim()); //百分位
objvCurrEduClsStuEN.Confirmed = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsStu.Confirmed].ToString().Trim()); //是否确认
objvCurrEduClsStuEN.SchoolTerm = objRow[convCurrEduClsStu.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduClsStu.SchoolTerm].ToString().Trim(); //学期
objvCurrEduClsStuEN.SchoolYear = objRow[convCurrEduClsStu.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduClsStu.SchoolYear].ToString().Trim(); //学年
objvCurrEduClsStuEN.SignInDate = objRow[convCurrEduClsStu.SignInDate] == DBNull.Value ? null : objRow[convCurrEduClsStu.SignInDate].ToString().Trim(); //签入时间
objvCurrEduClsStuEN.SignInStateID = objRow[convCurrEduClsStu.SignInStateID] == DBNull.Value ? null : objRow[convCurrEduClsStu.SignInStateID].ToString().Trim(); //签入状态表流水号
objvCurrEduClsStuEN.SignInUser = objRow[convCurrEduClsStu.SignInUser] == DBNull.Value ? null : objRow[convCurrEduClsStu.SignInUser].ToString().Trim(); //签入人
objvCurrEduClsStuEN.ModifyDate = objRow[convCurrEduClsStu.ModifyDate] == DBNull.Value ? null : objRow[convCurrEduClsStu.ModifyDate].ToString().Trim(); //修改日期
objvCurrEduClsStuEN.ModifyUserId = objRow[convCurrEduClsStu.ModifyUserId] == DBNull.Value ? null : objRow[convCurrEduClsStu.ModifyUserId].ToString().Trim(); //修改人
objvCurrEduClsStuEN.CollegeName4Stu = objRow[convCurrEduClsStu.CollegeName4Stu] == DBNull.Value ? null : objRow[convCurrEduClsStu.CollegeName4Stu].ToString().Trim(); //CollegeName4Stu
objvCurrEduClsStuEN.EduClsTypeName = objRow[convCurrEduClsStu.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduClsStu.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduClsStuEN.IsSynScore = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsStu.IsSynScore].ToString().Trim()); //是否同步成绩
objvCurrEduClsStuEN.EduClsTypeId = objRow[convCurrEduClsStu.EduClsTypeId] == DBNull.Value ? null : objRow[convCurrEduClsStu.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduClsStuEN.UserType = objRow[convCurrEduClsStu.UserType] == DBNull.Value ? null : objRow[convCurrEduClsStu.UserType].ToString().Trim(); //用户类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCurrEduClsStuEN.IdEduClsStu, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCurrEduClsStuEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvCurrEduClsStuCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvCurrEduClsStuEN> GetSubObjLstCache(clsvCurrEduClsStuEN objvCurrEduClsStuCond)
{
 string strIdCurrEduCls = objvCurrEduClsStuCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvCurrEduClsStuBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvCurrEduClsStuEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvCurrEduClsStuEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCurrEduClsStu.AttributeName)
{
if (objvCurrEduClsStuCond.IsUpdated(strFldName) == false) continue;
if (objvCurrEduClsStuCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCurrEduClsStuCond[strFldName].ToString());
}
else
{
if (objvCurrEduClsStuCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCurrEduClsStuCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCurrEduClsStuCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCurrEduClsStuCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCurrEduClsStuCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCurrEduClsStuCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCurrEduClsStuCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCurrEduClsStuCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCurrEduClsStuCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCurrEduClsStuCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCurrEduClsStuCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCurrEduClsStuCond[strFldName]));
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
public static List<clsvCurrEduClsStuEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvCurrEduClsStuEN> arrObjLst = new List<clsvCurrEduClsStuEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduClsStuEN objvCurrEduClsStuEN = new clsvCurrEduClsStuEN();
try
{
objvCurrEduClsStuEN.IdEduClsStu = Int32.Parse(objRow[convCurrEduClsStu.IdEduClsStu].ToString().Trim()); //教学班学生流水号
objvCurrEduClsStuEN.IdCurrEduCls = objRow[convCurrEduClsStu.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduClsStuEN.CurrEduClsId = objRow[convCurrEduClsStu.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduClsStuEN.EduClsName = objRow[convCurrEduClsStu.EduClsName].ToString().Trim(); //教学班名
objvCurrEduClsStuEN.CourseId = objRow[convCurrEduClsStu.CourseId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseId].ToString().Trim(); //课程Id
objvCurrEduClsStuEN.CourseCode = objRow[convCurrEduClsStu.CourseCode] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseCode].ToString().Trim(); //课程代码
objvCurrEduClsStuEN.CourseName = objRow[convCurrEduClsStu.CourseName] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseName].ToString().Trim(); //课程名称
objvCurrEduClsStuEN.TeachingSolutionId = objRow[convCurrEduClsStu.TeachingSolutionId] == DBNull.Value ? null : objRow[convCurrEduClsStu.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduClsStuEN.TeachingSolutionName = objRow[convCurrEduClsStu.TeachingSolutionName] == DBNull.Value ? null : objRow[convCurrEduClsStu.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduClsStuEN.IdXzCollege = objRow[convCurrEduClsStu.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduClsStuEN.CollegeId = objRow[convCurrEduClsStu.CollegeId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CollegeId].ToString().Trim(); //学院ID
objvCurrEduClsStuEN.CollegeName = objRow[convCurrEduClsStu.CollegeName] == DBNull.Value ? null : objRow[convCurrEduClsStu.CollegeName].ToString().Trim(); //学院名称
objvCurrEduClsStuEN.LessonQtyPerWeek = objRow[convCurrEduClsStu.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsStu.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduClsStuEN.Mark = objRow[convCurrEduClsStu.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduClsStu.Mark].ToString().Trim()); //获得学分
objvCurrEduClsStuEN.IdUniZone = objRow[convCurrEduClsStu.IdUniZone] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduClsStuEN.GradeBaseName = objRow[convCurrEduClsStu.GradeBaseName] == DBNull.Value ? null : objRow[convCurrEduClsStu.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduClsStuEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsStu.IsEffective].ToString().Trim()); //是否有效
objvCurrEduClsStuEN.IdCourseType = objRow[convCurrEduClsStu.IdCourseType] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduClsStuEN.CourseTypeId = objRow[convCurrEduClsStu.CourseTypeId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduClsStuEN.CourseTypeName = objRow[convCurrEduClsStu.CourseTypeName] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduClsStuEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsStu.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduClsStuEN.CurrStuNum = objRow[convCurrEduClsStu.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsStu.CurrStuNum].ToString().Trim()); //当前学生数
objvCurrEduClsStuEN.IdStu = objRow[convCurrEduClsStu.IdStu] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdStu].ToString().Trim(); //学生流水号
objvCurrEduClsStuEN.StuId = objRow[convCurrEduClsStu.StuId] == DBNull.Value ? null : objRow[convCurrEduClsStu.StuId].ToString().Trim(); //学号
objvCurrEduClsStuEN.StuName = objRow[convCurrEduClsStu.StuName] == DBNull.Value ? null : objRow[convCurrEduClsStu.StuName].ToString().Trim(); //姓名
objvCurrEduClsStuEN.IdSex = objRow[convCurrEduClsStu.IdSex].ToString().Trim(); //性别流水号
objvCurrEduClsStuEN.SexDesc = objRow[convCurrEduClsStu.SexDesc] == DBNull.Value ? null : objRow[convCurrEduClsStu.SexDesc].ToString().Trim(); //性别名称
objvCurrEduClsStuEN.MajorID = objRow[convCurrEduClsStu.MajorID] == DBNull.Value ? null : objRow[convCurrEduClsStu.MajorID].ToString().Trim(); //专业ID
objvCurrEduClsStuEN.MajorName = objRow[convCurrEduClsStu.MajorName] == DBNull.Value ? null : objRow[convCurrEduClsStu.MajorName].ToString().Trim(); //专业名称
objvCurrEduClsStuEN.IdAdminCls = objRow[convCurrEduClsStu.IdAdminCls] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdAdminCls].ToString().Trim(); //行政班流水号
objvCurrEduClsStuEN.Birthday = objRow[convCurrEduClsStu.Birthday] == DBNull.Value ? null : objRow[convCurrEduClsStu.Birthday].ToString().Trim(); //出生日期
objvCurrEduClsStuEN.EduClsStuStateId = objRow[convCurrEduClsStu.EduClsStuStateId] == DBNull.Value ? null : objRow[convCurrEduClsStu.EduClsStuStateId].ToString().Trim(); //教学班学生状态编号
objvCurrEduClsStuEN.GetScoreTimes = objRow[convCurrEduClsStu.GetScoreTimes] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsStu.GetScoreTimes].ToString().Trim()); //获得成绩次数
objvCurrEduClsStuEN.Score = objRow[convCurrEduClsStu.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduClsStu.Score].ToString().Trim()); //得分
objvCurrEduClsStuEN.TotalScores = objRow[convCurrEduClsStu.TotalScores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduClsStu.TotalScores].ToString().Trim()); //总分值
objvCurrEduClsStuEN.Ranking = objRow[convCurrEduClsStu.Ranking] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsStu.Ranking].ToString().Trim()); //名次
objvCurrEduClsStuEN.Percentile = objRow[convCurrEduClsStu.Percentile] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduClsStu.Percentile].ToString().Trim()); //百分位
objvCurrEduClsStuEN.Confirmed = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsStu.Confirmed].ToString().Trim()); //是否确认
objvCurrEduClsStuEN.SchoolTerm = objRow[convCurrEduClsStu.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduClsStu.SchoolTerm].ToString().Trim(); //学期
objvCurrEduClsStuEN.SchoolYear = objRow[convCurrEduClsStu.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduClsStu.SchoolYear].ToString().Trim(); //学年
objvCurrEduClsStuEN.SignInDate = objRow[convCurrEduClsStu.SignInDate] == DBNull.Value ? null : objRow[convCurrEduClsStu.SignInDate].ToString().Trim(); //签入时间
objvCurrEduClsStuEN.SignInStateID = objRow[convCurrEduClsStu.SignInStateID] == DBNull.Value ? null : objRow[convCurrEduClsStu.SignInStateID].ToString().Trim(); //签入状态表流水号
objvCurrEduClsStuEN.SignInUser = objRow[convCurrEduClsStu.SignInUser] == DBNull.Value ? null : objRow[convCurrEduClsStu.SignInUser].ToString().Trim(); //签入人
objvCurrEduClsStuEN.ModifyDate = objRow[convCurrEduClsStu.ModifyDate] == DBNull.Value ? null : objRow[convCurrEduClsStu.ModifyDate].ToString().Trim(); //修改日期
objvCurrEduClsStuEN.ModifyUserId = objRow[convCurrEduClsStu.ModifyUserId] == DBNull.Value ? null : objRow[convCurrEduClsStu.ModifyUserId].ToString().Trim(); //修改人
objvCurrEduClsStuEN.CollegeName4Stu = objRow[convCurrEduClsStu.CollegeName4Stu] == DBNull.Value ? null : objRow[convCurrEduClsStu.CollegeName4Stu].ToString().Trim(); //CollegeName4Stu
objvCurrEduClsStuEN.EduClsTypeName = objRow[convCurrEduClsStu.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduClsStu.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduClsStuEN.IsSynScore = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsStu.IsSynScore].ToString().Trim()); //是否同步成绩
objvCurrEduClsStuEN.EduClsTypeId = objRow[convCurrEduClsStu.EduClsTypeId] == DBNull.Value ? null : objRow[convCurrEduClsStu.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduClsStuEN.UserType = objRow[convCurrEduClsStu.UserType] == DBNull.Value ? null : objRow[convCurrEduClsStu.UserType].ToString().Trim(); //用户类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCurrEduClsStuEN.IdEduClsStu, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCurrEduClsStuEN);
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
public static List<clsvCurrEduClsStuEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvCurrEduClsStuEN> arrObjLst = new List<clsvCurrEduClsStuEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduClsStuEN objvCurrEduClsStuEN = new clsvCurrEduClsStuEN();
try
{
objvCurrEduClsStuEN.IdEduClsStu = Int32.Parse(objRow[convCurrEduClsStu.IdEduClsStu].ToString().Trim()); //教学班学生流水号
objvCurrEduClsStuEN.IdCurrEduCls = objRow[convCurrEduClsStu.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduClsStuEN.CurrEduClsId = objRow[convCurrEduClsStu.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduClsStuEN.EduClsName = objRow[convCurrEduClsStu.EduClsName].ToString().Trim(); //教学班名
objvCurrEduClsStuEN.CourseId = objRow[convCurrEduClsStu.CourseId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseId].ToString().Trim(); //课程Id
objvCurrEduClsStuEN.CourseCode = objRow[convCurrEduClsStu.CourseCode] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseCode].ToString().Trim(); //课程代码
objvCurrEduClsStuEN.CourseName = objRow[convCurrEduClsStu.CourseName] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseName].ToString().Trim(); //课程名称
objvCurrEduClsStuEN.TeachingSolutionId = objRow[convCurrEduClsStu.TeachingSolutionId] == DBNull.Value ? null : objRow[convCurrEduClsStu.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduClsStuEN.TeachingSolutionName = objRow[convCurrEduClsStu.TeachingSolutionName] == DBNull.Value ? null : objRow[convCurrEduClsStu.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduClsStuEN.IdXzCollege = objRow[convCurrEduClsStu.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduClsStuEN.CollegeId = objRow[convCurrEduClsStu.CollegeId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CollegeId].ToString().Trim(); //学院ID
objvCurrEduClsStuEN.CollegeName = objRow[convCurrEduClsStu.CollegeName] == DBNull.Value ? null : objRow[convCurrEduClsStu.CollegeName].ToString().Trim(); //学院名称
objvCurrEduClsStuEN.LessonQtyPerWeek = objRow[convCurrEduClsStu.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsStu.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduClsStuEN.Mark = objRow[convCurrEduClsStu.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduClsStu.Mark].ToString().Trim()); //获得学分
objvCurrEduClsStuEN.IdUniZone = objRow[convCurrEduClsStu.IdUniZone] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduClsStuEN.GradeBaseName = objRow[convCurrEduClsStu.GradeBaseName] == DBNull.Value ? null : objRow[convCurrEduClsStu.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduClsStuEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsStu.IsEffective].ToString().Trim()); //是否有效
objvCurrEduClsStuEN.IdCourseType = objRow[convCurrEduClsStu.IdCourseType] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduClsStuEN.CourseTypeId = objRow[convCurrEduClsStu.CourseTypeId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduClsStuEN.CourseTypeName = objRow[convCurrEduClsStu.CourseTypeName] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduClsStuEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsStu.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduClsStuEN.CurrStuNum = objRow[convCurrEduClsStu.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsStu.CurrStuNum].ToString().Trim()); //当前学生数
objvCurrEduClsStuEN.IdStu = objRow[convCurrEduClsStu.IdStu] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdStu].ToString().Trim(); //学生流水号
objvCurrEduClsStuEN.StuId = objRow[convCurrEduClsStu.StuId] == DBNull.Value ? null : objRow[convCurrEduClsStu.StuId].ToString().Trim(); //学号
objvCurrEduClsStuEN.StuName = objRow[convCurrEduClsStu.StuName] == DBNull.Value ? null : objRow[convCurrEduClsStu.StuName].ToString().Trim(); //姓名
objvCurrEduClsStuEN.IdSex = objRow[convCurrEduClsStu.IdSex].ToString().Trim(); //性别流水号
objvCurrEduClsStuEN.SexDesc = objRow[convCurrEduClsStu.SexDesc] == DBNull.Value ? null : objRow[convCurrEduClsStu.SexDesc].ToString().Trim(); //性别名称
objvCurrEduClsStuEN.MajorID = objRow[convCurrEduClsStu.MajorID] == DBNull.Value ? null : objRow[convCurrEduClsStu.MajorID].ToString().Trim(); //专业ID
objvCurrEduClsStuEN.MajorName = objRow[convCurrEduClsStu.MajorName] == DBNull.Value ? null : objRow[convCurrEduClsStu.MajorName].ToString().Trim(); //专业名称
objvCurrEduClsStuEN.IdAdminCls = objRow[convCurrEduClsStu.IdAdminCls] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdAdminCls].ToString().Trim(); //行政班流水号
objvCurrEduClsStuEN.Birthday = objRow[convCurrEduClsStu.Birthday] == DBNull.Value ? null : objRow[convCurrEduClsStu.Birthday].ToString().Trim(); //出生日期
objvCurrEduClsStuEN.EduClsStuStateId = objRow[convCurrEduClsStu.EduClsStuStateId] == DBNull.Value ? null : objRow[convCurrEduClsStu.EduClsStuStateId].ToString().Trim(); //教学班学生状态编号
objvCurrEduClsStuEN.GetScoreTimes = objRow[convCurrEduClsStu.GetScoreTimes] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsStu.GetScoreTimes].ToString().Trim()); //获得成绩次数
objvCurrEduClsStuEN.Score = objRow[convCurrEduClsStu.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduClsStu.Score].ToString().Trim()); //得分
objvCurrEduClsStuEN.TotalScores = objRow[convCurrEduClsStu.TotalScores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduClsStu.TotalScores].ToString().Trim()); //总分值
objvCurrEduClsStuEN.Ranking = objRow[convCurrEduClsStu.Ranking] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsStu.Ranking].ToString().Trim()); //名次
objvCurrEduClsStuEN.Percentile = objRow[convCurrEduClsStu.Percentile] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduClsStu.Percentile].ToString().Trim()); //百分位
objvCurrEduClsStuEN.Confirmed = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsStu.Confirmed].ToString().Trim()); //是否确认
objvCurrEduClsStuEN.SchoolTerm = objRow[convCurrEduClsStu.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduClsStu.SchoolTerm].ToString().Trim(); //学期
objvCurrEduClsStuEN.SchoolYear = objRow[convCurrEduClsStu.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduClsStu.SchoolYear].ToString().Trim(); //学年
objvCurrEduClsStuEN.SignInDate = objRow[convCurrEduClsStu.SignInDate] == DBNull.Value ? null : objRow[convCurrEduClsStu.SignInDate].ToString().Trim(); //签入时间
objvCurrEduClsStuEN.SignInStateID = objRow[convCurrEduClsStu.SignInStateID] == DBNull.Value ? null : objRow[convCurrEduClsStu.SignInStateID].ToString().Trim(); //签入状态表流水号
objvCurrEduClsStuEN.SignInUser = objRow[convCurrEduClsStu.SignInUser] == DBNull.Value ? null : objRow[convCurrEduClsStu.SignInUser].ToString().Trim(); //签入人
objvCurrEduClsStuEN.ModifyDate = objRow[convCurrEduClsStu.ModifyDate] == DBNull.Value ? null : objRow[convCurrEduClsStu.ModifyDate].ToString().Trim(); //修改日期
objvCurrEduClsStuEN.ModifyUserId = objRow[convCurrEduClsStu.ModifyUserId] == DBNull.Value ? null : objRow[convCurrEduClsStu.ModifyUserId].ToString().Trim(); //修改人
objvCurrEduClsStuEN.CollegeName4Stu = objRow[convCurrEduClsStu.CollegeName4Stu] == DBNull.Value ? null : objRow[convCurrEduClsStu.CollegeName4Stu].ToString().Trim(); //CollegeName4Stu
objvCurrEduClsStuEN.EduClsTypeName = objRow[convCurrEduClsStu.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduClsStu.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduClsStuEN.IsSynScore = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsStu.IsSynScore].ToString().Trim()); //是否同步成绩
objvCurrEduClsStuEN.EduClsTypeId = objRow[convCurrEduClsStu.EduClsTypeId] == DBNull.Value ? null : objRow[convCurrEduClsStu.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduClsStuEN.UserType = objRow[convCurrEduClsStu.UserType] == DBNull.Value ? null : objRow[convCurrEduClsStu.UserType].ToString().Trim(); //用户类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCurrEduClsStuEN.IdEduClsStu, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCurrEduClsStuEN);
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
List<clsvCurrEduClsStuEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvCurrEduClsStuEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCurrEduClsStuEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvCurrEduClsStuEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvCurrEduClsStuEN> arrObjLst = new List<clsvCurrEduClsStuEN>(); 
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
	clsvCurrEduClsStuEN objvCurrEduClsStuEN = new clsvCurrEduClsStuEN();
try
{
objvCurrEduClsStuEN.IdEduClsStu = Int32.Parse(objRow[convCurrEduClsStu.IdEduClsStu].ToString().Trim()); //教学班学生流水号
objvCurrEduClsStuEN.IdCurrEduCls = objRow[convCurrEduClsStu.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduClsStuEN.CurrEduClsId = objRow[convCurrEduClsStu.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduClsStuEN.EduClsName = objRow[convCurrEduClsStu.EduClsName].ToString().Trim(); //教学班名
objvCurrEduClsStuEN.CourseId = objRow[convCurrEduClsStu.CourseId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseId].ToString().Trim(); //课程Id
objvCurrEduClsStuEN.CourseCode = objRow[convCurrEduClsStu.CourseCode] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseCode].ToString().Trim(); //课程代码
objvCurrEduClsStuEN.CourseName = objRow[convCurrEduClsStu.CourseName] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseName].ToString().Trim(); //课程名称
objvCurrEduClsStuEN.TeachingSolutionId = objRow[convCurrEduClsStu.TeachingSolutionId] == DBNull.Value ? null : objRow[convCurrEduClsStu.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduClsStuEN.TeachingSolutionName = objRow[convCurrEduClsStu.TeachingSolutionName] == DBNull.Value ? null : objRow[convCurrEduClsStu.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduClsStuEN.IdXzCollege = objRow[convCurrEduClsStu.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduClsStuEN.CollegeId = objRow[convCurrEduClsStu.CollegeId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CollegeId].ToString().Trim(); //学院ID
objvCurrEduClsStuEN.CollegeName = objRow[convCurrEduClsStu.CollegeName] == DBNull.Value ? null : objRow[convCurrEduClsStu.CollegeName].ToString().Trim(); //学院名称
objvCurrEduClsStuEN.LessonQtyPerWeek = objRow[convCurrEduClsStu.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsStu.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduClsStuEN.Mark = objRow[convCurrEduClsStu.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduClsStu.Mark].ToString().Trim()); //获得学分
objvCurrEduClsStuEN.IdUniZone = objRow[convCurrEduClsStu.IdUniZone] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduClsStuEN.GradeBaseName = objRow[convCurrEduClsStu.GradeBaseName] == DBNull.Value ? null : objRow[convCurrEduClsStu.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduClsStuEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsStu.IsEffective].ToString().Trim()); //是否有效
objvCurrEduClsStuEN.IdCourseType = objRow[convCurrEduClsStu.IdCourseType] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduClsStuEN.CourseTypeId = objRow[convCurrEduClsStu.CourseTypeId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduClsStuEN.CourseTypeName = objRow[convCurrEduClsStu.CourseTypeName] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduClsStuEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsStu.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduClsStuEN.CurrStuNum = objRow[convCurrEduClsStu.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsStu.CurrStuNum].ToString().Trim()); //当前学生数
objvCurrEduClsStuEN.IdStu = objRow[convCurrEduClsStu.IdStu] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdStu].ToString().Trim(); //学生流水号
objvCurrEduClsStuEN.StuId = objRow[convCurrEduClsStu.StuId] == DBNull.Value ? null : objRow[convCurrEduClsStu.StuId].ToString().Trim(); //学号
objvCurrEduClsStuEN.StuName = objRow[convCurrEduClsStu.StuName] == DBNull.Value ? null : objRow[convCurrEduClsStu.StuName].ToString().Trim(); //姓名
objvCurrEduClsStuEN.IdSex = objRow[convCurrEduClsStu.IdSex].ToString().Trim(); //性别流水号
objvCurrEduClsStuEN.SexDesc = objRow[convCurrEduClsStu.SexDesc] == DBNull.Value ? null : objRow[convCurrEduClsStu.SexDesc].ToString().Trim(); //性别名称
objvCurrEduClsStuEN.MajorID = objRow[convCurrEduClsStu.MajorID] == DBNull.Value ? null : objRow[convCurrEduClsStu.MajorID].ToString().Trim(); //专业ID
objvCurrEduClsStuEN.MajorName = objRow[convCurrEduClsStu.MajorName] == DBNull.Value ? null : objRow[convCurrEduClsStu.MajorName].ToString().Trim(); //专业名称
objvCurrEduClsStuEN.IdAdminCls = objRow[convCurrEduClsStu.IdAdminCls] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdAdminCls].ToString().Trim(); //行政班流水号
objvCurrEduClsStuEN.Birthday = objRow[convCurrEduClsStu.Birthday] == DBNull.Value ? null : objRow[convCurrEduClsStu.Birthday].ToString().Trim(); //出生日期
objvCurrEduClsStuEN.EduClsStuStateId = objRow[convCurrEduClsStu.EduClsStuStateId] == DBNull.Value ? null : objRow[convCurrEduClsStu.EduClsStuStateId].ToString().Trim(); //教学班学生状态编号
objvCurrEduClsStuEN.GetScoreTimes = objRow[convCurrEduClsStu.GetScoreTimes] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsStu.GetScoreTimes].ToString().Trim()); //获得成绩次数
objvCurrEduClsStuEN.Score = objRow[convCurrEduClsStu.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduClsStu.Score].ToString().Trim()); //得分
objvCurrEduClsStuEN.TotalScores = objRow[convCurrEduClsStu.TotalScores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduClsStu.TotalScores].ToString().Trim()); //总分值
objvCurrEduClsStuEN.Ranking = objRow[convCurrEduClsStu.Ranking] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsStu.Ranking].ToString().Trim()); //名次
objvCurrEduClsStuEN.Percentile = objRow[convCurrEduClsStu.Percentile] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduClsStu.Percentile].ToString().Trim()); //百分位
objvCurrEduClsStuEN.Confirmed = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsStu.Confirmed].ToString().Trim()); //是否确认
objvCurrEduClsStuEN.SchoolTerm = objRow[convCurrEduClsStu.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduClsStu.SchoolTerm].ToString().Trim(); //学期
objvCurrEduClsStuEN.SchoolYear = objRow[convCurrEduClsStu.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduClsStu.SchoolYear].ToString().Trim(); //学年
objvCurrEduClsStuEN.SignInDate = objRow[convCurrEduClsStu.SignInDate] == DBNull.Value ? null : objRow[convCurrEduClsStu.SignInDate].ToString().Trim(); //签入时间
objvCurrEduClsStuEN.SignInStateID = objRow[convCurrEduClsStu.SignInStateID] == DBNull.Value ? null : objRow[convCurrEduClsStu.SignInStateID].ToString().Trim(); //签入状态表流水号
objvCurrEduClsStuEN.SignInUser = objRow[convCurrEduClsStu.SignInUser] == DBNull.Value ? null : objRow[convCurrEduClsStu.SignInUser].ToString().Trim(); //签入人
objvCurrEduClsStuEN.ModifyDate = objRow[convCurrEduClsStu.ModifyDate] == DBNull.Value ? null : objRow[convCurrEduClsStu.ModifyDate].ToString().Trim(); //修改日期
objvCurrEduClsStuEN.ModifyUserId = objRow[convCurrEduClsStu.ModifyUserId] == DBNull.Value ? null : objRow[convCurrEduClsStu.ModifyUserId].ToString().Trim(); //修改人
objvCurrEduClsStuEN.CollegeName4Stu = objRow[convCurrEduClsStu.CollegeName4Stu] == DBNull.Value ? null : objRow[convCurrEduClsStu.CollegeName4Stu].ToString().Trim(); //CollegeName4Stu
objvCurrEduClsStuEN.EduClsTypeName = objRow[convCurrEduClsStu.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduClsStu.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduClsStuEN.IsSynScore = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsStu.IsSynScore].ToString().Trim()); //是否同步成绩
objvCurrEduClsStuEN.EduClsTypeId = objRow[convCurrEduClsStu.EduClsTypeId] == DBNull.Value ? null : objRow[convCurrEduClsStu.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduClsStuEN.UserType = objRow[convCurrEduClsStu.UserType] == DBNull.Value ? null : objRow[convCurrEduClsStu.UserType].ToString().Trim(); //用户类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCurrEduClsStuEN.IdEduClsStu, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCurrEduClsStuEN);
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
public static List<clsvCurrEduClsStuEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvCurrEduClsStuEN> arrObjLst = new List<clsvCurrEduClsStuEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduClsStuEN objvCurrEduClsStuEN = new clsvCurrEduClsStuEN();
try
{
objvCurrEduClsStuEN.IdEduClsStu = Int32.Parse(objRow[convCurrEduClsStu.IdEduClsStu].ToString().Trim()); //教学班学生流水号
objvCurrEduClsStuEN.IdCurrEduCls = objRow[convCurrEduClsStu.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduClsStuEN.CurrEduClsId = objRow[convCurrEduClsStu.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduClsStuEN.EduClsName = objRow[convCurrEduClsStu.EduClsName].ToString().Trim(); //教学班名
objvCurrEduClsStuEN.CourseId = objRow[convCurrEduClsStu.CourseId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseId].ToString().Trim(); //课程Id
objvCurrEduClsStuEN.CourseCode = objRow[convCurrEduClsStu.CourseCode] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseCode].ToString().Trim(); //课程代码
objvCurrEduClsStuEN.CourseName = objRow[convCurrEduClsStu.CourseName] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseName].ToString().Trim(); //课程名称
objvCurrEduClsStuEN.TeachingSolutionId = objRow[convCurrEduClsStu.TeachingSolutionId] == DBNull.Value ? null : objRow[convCurrEduClsStu.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduClsStuEN.TeachingSolutionName = objRow[convCurrEduClsStu.TeachingSolutionName] == DBNull.Value ? null : objRow[convCurrEduClsStu.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduClsStuEN.IdXzCollege = objRow[convCurrEduClsStu.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduClsStuEN.CollegeId = objRow[convCurrEduClsStu.CollegeId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CollegeId].ToString().Trim(); //学院ID
objvCurrEduClsStuEN.CollegeName = objRow[convCurrEduClsStu.CollegeName] == DBNull.Value ? null : objRow[convCurrEduClsStu.CollegeName].ToString().Trim(); //学院名称
objvCurrEduClsStuEN.LessonQtyPerWeek = objRow[convCurrEduClsStu.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsStu.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduClsStuEN.Mark = objRow[convCurrEduClsStu.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduClsStu.Mark].ToString().Trim()); //获得学分
objvCurrEduClsStuEN.IdUniZone = objRow[convCurrEduClsStu.IdUniZone] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduClsStuEN.GradeBaseName = objRow[convCurrEduClsStu.GradeBaseName] == DBNull.Value ? null : objRow[convCurrEduClsStu.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduClsStuEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsStu.IsEffective].ToString().Trim()); //是否有效
objvCurrEduClsStuEN.IdCourseType = objRow[convCurrEduClsStu.IdCourseType] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduClsStuEN.CourseTypeId = objRow[convCurrEduClsStu.CourseTypeId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduClsStuEN.CourseTypeName = objRow[convCurrEduClsStu.CourseTypeName] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduClsStuEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsStu.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduClsStuEN.CurrStuNum = objRow[convCurrEduClsStu.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsStu.CurrStuNum].ToString().Trim()); //当前学生数
objvCurrEduClsStuEN.IdStu = objRow[convCurrEduClsStu.IdStu] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdStu].ToString().Trim(); //学生流水号
objvCurrEduClsStuEN.StuId = objRow[convCurrEduClsStu.StuId] == DBNull.Value ? null : objRow[convCurrEduClsStu.StuId].ToString().Trim(); //学号
objvCurrEduClsStuEN.StuName = objRow[convCurrEduClsStu.StuName] == DBNull.Value ? null : objRow[convCurrEduClsStu.StuName].ToString().Trim(); //姓名
objvCurrEduClsStuEN.IdSex = objRow[convCurrEduClsStu.IdSex].ToString().Trim(); //性别流水号
objvCurrEduClsStuEN.SexDesc = objRow[convCurrEduClsStu.SexDesc] == DBNull.Value ? null : objRow[convCurrEduClsStu.SexDesc].ToString().Trim(); //性别名称
objvCurrEduClsStuEN.MajorID = objRow[convCurrEduClsStu.MajorID] == DBNull.Value ? null : objRow[convCurrEduClsStu.MajorID].ToString().Trim(); //专业ID
objvCurrEduClsStuEN.MajorName = objRow[convCurrEduClsStu.MajorName] == DBNull.Value ? null : objRow[convCurrEduClsStu.MajorName].ToString().Trim(); //专业名称
objvCurrEduClsStuEN.IdAdminCls = objRow[convCurrEduClsStu.IdAdminCls] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdAdminCls].ToString().Trim(); //行政班流水号
objvCurrEduClsStuEN.Birthday = objRow[convCurrEduClsStu.Birthday] == DBNull.Value ? null : objRow[convCurrEduClsStu.Birthday].ToString().Trim(); //出生日期
objvCurrEduClsStuEN.EduClsStuStateId = objRow[convCurrEduClsStu.EduClsStuStateId] == DBNull.Value ? null : objRow[convCurrEduClsStu.EduClsStuStateId].ToString().Trim(); //教学班学生状态编号
objvCurrEduClsStuEN.GetScoreTimes = objRow[convCurrEduClsStu.GetScoreTimes] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsStu.GetScoreTimes].ToString().Trim()); //获得成绩次数
objvCurrEduClsStuEN.Score = objRow[convCurrEduClsStu.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduClsStu.Score].ToString().Trim()); //得分
objvCurrEduClsStuEN.TotalScores = objRow[convCurrEduClsStu.TotalScores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduClsStu.TotalScores].ToString().Trim()); //总分值
objvCurrEduClsStuEN.Ranking = objRow[convCurrEduClsStu.Ranking] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsStu.Ranking].ToString().Trim()); //名次
objvCurrEduClsStuEN.Percentile = objRow[convCurrEduClsStu.Percentile] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduClsStu.Percentile].ToString().Trim()); //百分位
objvCurrEduClsStuEN.Confirmed = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsStu.Confirmed].ToString().Trim()); //是否确认
objvCurrEduClsStuEN.SchoolTerm = objRow[convCurrEduClsStu.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduClsStu.SchoolTerm].ToString().Trim(); //学期
objvCurrEduClsStuEN.SchoolYear = objRow[convCurrEduClsStu.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduClsStu.SchoolYear].ToString().Trim(); //学年
objvCurrEduClsStuEN.SignInDate = objRow[convCurrEduClsStu.SignInDate] == DBNull.Value ? null : objRow[convCurrEduClsStu.SignInDate].ToString().Trim(); //签入时间
objvCurrEduClsStuEN.SignInStateID = objRow[convCurrEduClsStu.SignInStateID] == DBNull.Value ? null : objRow[convCurrEduClsStu.SignInStateID].ToString().Trim(); //签入状态表流水号
objvCurrEduClsStuEN.SignInUser = objRow[convCurrEduClsStu.SignInUser] == DBNull.Value ? null : objRow[convCurrEduClsStu.SignInUser].ToString().Trim(); //签入人
objvCurrEduClsStuEN.ModifyDate = objRow[convCurrEduClsStu.ModifyDate] == DBNull.Value ? null : objRow[convCurrEduClsStu.ModifyDate].ToString().Trim(); //修改日期
objvCurrEduClsStuEN.ModifyUserId = objRow[convCurrEduClsStu.ModifyUserId] == DBNull.Value ? null : objRow[convCurrEduClsStu.ModifyUserId].ToString().Trim(); //修改人
objvCurrEduClsStuEN.CollegeName4Stu = objRow[convCurrEduClsStu.CollegeName4Stu] == DBNull.Value ? null : objRow[convCurrEduClsStu.CollegeName4Stu].ToString().Trim(); //CollegeName4Stu
objvCurrEduClsStuEN.EduClsTypeName = objRow[convCurrEduClsStu.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduClsStu.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduClsStuEN.IsSynScore = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsStu.IsSynScore].ToString().Trim()); //是否同步成绩
objvCurrEduClsStuEN.EduClsTypeId = objRow[convCurrEduClsStu.EduClsTypeId] == DBNull.Value ? null : objRow[convCurrEduClsStu.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduClsStuEN.UserType = objRow[convCurrEduClsStu.UserType] == DBNull.Value ? null : objRow[convCurrEduClsStu.UserType].ToString().Trim(); //用户类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCurrEduClsStuEN.IdEduClsStu, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCurrEduClsStuEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvCurrEduClsStuEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvCurrEduClsStuEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvCurrEduClsStuEN> arrObjLst = new List<clsvCurrEduClsStuEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduClsStuEN objvCurrEduClsStuEN = new clsvCurrEduClsStuEN();
try
{
objvCurrEduClsStuEN.IdEduClsStu = Int32.Parse(objRow[convCurrEduClsStu.IdEduClsStu].ToString().Trim()); //教学班学生流水号
objvCurrEduClsStuEN.IdCurrEduCls = objRow[convCurrEduClsStu.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduClsStuEN.CurrEduClsId = objRow[convCurrEduClsStu.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduClsStuEN.EduClsName = objRow[convCurrEduClsStu.EduClsName].ToString().Trim(); //教学班名
objvCurrEduClsStuEN.CourseId = objRow[convCurrEduClsStu.CourseId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseId].ToString().Trim(); //课程Id
objvCurrEduClsStuEN.CourseCode = objRow[convCurrEduClsStu.CourseCode] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseCode].ToString().Trim(); //课程代码
objvCurrEduClsStuEN.CourseName = objRow[convCurrEduClsStu.CourseName] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseName].ToString().Trim(); //课程名称
objvCurrEduClsStuEN.TeachingSolutionId = objRow[convCurrEduClsStu.TeachingSolutionId] == DBNull.Value ? null : objRow[convCurrEduClsStu.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduClsStuEN.TeachingSolutionName = objRow[convCurrEduClsStu.TeachingSolutionName] == DBNull.Value ? null : objRow[convCurrEduClsStu.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduClsStuEN.IdXzCollege = objRow[convCurrEduClsStu.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduClsStuEN.CollegeId = objRow[convCurrEduClsStu.CollegeId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CollegeId].ToString().Trim(); //学院ID
objvCurrEduClsStuEN.CollegeName = objRow[convCurrEduClsStu.CollegeName] == DBNull.Value ? null : objRow[convCurrEduClsStu.CollegeName].ToString().Trim(); //学院名称
objvCurrEduClsStuEN.LessonQtyPerWeek = objRow[convCurrEduClsStu.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsStu.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduClsStuEN.Mark = objRow[convCurrEduClsStu.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduClsStu.Mark].ToString().Trim()); //获得学分
objvCurrEduClsStuEN.IdUniZone = objRow[convCurrEduClsStu.IdUniZone] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduClsStuEN.GradeBaseName = objRow[convCurrEduClsStu.GradeBaseName] == DBNull.Value ? null : objRow[convCurrEduClsStu.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduClsStuEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsStu.IsEffective].ToString().Trim()); //是否有效
objvCurrEduClsStuEN.IdCourseType = objRow[convCurrEduClsStu.IdCourseType] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduClsStuEN.CourseTypeId = objRow[convCurrEduClsStu.CourseTypeId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduClsStuEN.CourseTypeName = objRow[convCurrEduClsStu.CourseTypeName] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduClsStuEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsStu.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduClsStuEN.CurrStuNum = objRow[convCurrEduClsStu.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsStu.CurrStuNum].ToString().Trim()); //当前学生数
objvCurrEduClsStuEN.IdStu = objRow[convCurrEduClsStu.IdStu] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdStu].ToString().Trim(); //学生流水号
objvCurrEduClsStuEN.StuId = objRow[convCurrEduClsStu.StuId] == DBNull.Value ? null : objRow[convCurrEduClsStu.StuId].ToString().Trim(); //学号
objvCurrEduClsStuEN.StuName = objRow[convCurrEduClsStu.StuName] == DBNull.Value ? null : objRow[convCurrEduClsStu.StuName].ToString().Trim(); //姓名
objvCurrEduClsStuEN.IdSex = objRow[convCurrEduClsStu.IdSex].ToString().Trim(); //性别流水号
objvCurrEduClsStuEN.SexDesc = objRow[convCurrEduClsStu.SexDesc] == DBNull.Value ? null : objRow[convCurrEduClsStu.SexDesc].ToString().Trim(); //性别名称
objvCurrEduClsStuEN.MajorID = objRow[convCurrEduClsStu.MajorID] == DBNull.Value ? null : objRow[convCurrEduClsStu.MajorID].ToString().Trim(); //专业ID
objvCurrEduClsStuEN.MajorName = objRow[convCurrEduClsStu.MajorName] == DBNull.Value ? null : objRow[convCurrEduClsStu.MajorName].ToString().Trim(); //专业名称
objvCurrEduClsStuEN.IdAdminCls = objRow[convCurrEduClsStu.IdAdminCls] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdAdminCls].ToString().Trim(); //行政班流水号
objvCurrEduClsStuEN.Birthday = objRow[convCurrEduClsStu.Birthday] == DBNull.Value ? null : objRow[convCurrEduClsStu.Birthday].ToString().Trim(); //出生日期
objvCurrEduClsStuEN.EduClsStuStateId = objRow[convCurrEduClsStu.EduClsStuStateId] == DBNull.Value ? null : objRow[convCurrEduClsStu.EduClsStuStateId].ToString().Trim(); //教学班学生状态编号
objvCurrEduClsStuEN.GetScoreTimes = objRow[convCurrEduClsStu.GetScoreTimes] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsStu.GetScoreTimes].ToString().Trim()); //获得成绩次数
objvCurrEduClsStuEN.Score = objRow[convCurrEduClsStu.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduClsStu.Score].ToString().Trim()); //得分
objvCurrEduClsStuEN.TotalScores = objRow[convCurrEduClsStu.TotalScores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduClsStu.TotalScores].ToString().Trim()); //总分值
objvCurrEduClsStuEN.Ranking = objRow[convCurrEduClsStu.Ranking] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsStu.Ranking].ToString().Trim()); //名次
objvCurrEduClsStuEN.Percentile = objRow[convCurrEduClsStu.Percentile] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduClsStu.Percentile].ToString().Trim()); //百分位
objvCurrEduClsStuEN.Confirmed = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsStu.Confirmed].ToString().Trim()); //是否确认
objvCurrEduClsStuEN.SchoolTerm = objRow[convCurrEduClsStu.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduClsStu.SchoolTerm].ToString().Trim(); //学期
objvCurrEduClsStuEN.SchoolYear = objRow[convCurrEduClsStu.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduClsStu.SchoolYear].ToString().Trim(); //学年
objvCurrEduClsStuEN.SignInDate = objRow[convCurrEduClsStu.SignInDate] == DBNull.Value ? null : objRow[convCurrEduClsStu.SignInDate].ToString().Trim(); //签入时间
objvCurrEduClsStuEN.SignInStateID = objRow[convCurrEduClsStu.SignInStateID] == DBNull.Value ? null : objRow[convCurrEduClsStu.SignInStateID].ToString().Trim(); //签入状态表流水号
objvCurrEduClsStuEN.SignInUser = objRow[convCurrEduClsStu.SignInUser] == DBNull.Value ? null : objRow[convCurrEduClsStu.SignInUser].ToString().Trim(); //签入人
objvCurrEduClsStuEN.ModifyDate = objRow[convCurrEduClsStu.ModifyDate] == DBNull.Value ? null : objRow[convCurrEduClsStu.ModifyDate].ToString().Trim(); //修改日期
objvCurrEduClsStuEN.ModifyUserId = objRow[convCurrEduClsStu.ModifyUserId] == DBNull.Value ? null : objRow[convCurrEduClsStu.ModifyUserId].ToString().Trim(); //修改人
objvCurrEduClsStuEN.CollegeName4Stu = objRow[convCurrEduClsStu.CollegeName4Stu] == DBNull.Value ? null : objRow[convCurrEduClsStu.CollegeName4Stu].ToString().Trim(); //CollegeName4Stu
objvCurrEduClsStuEN.EduClsTypeName = objRow[convCurrEduClsStu.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduClsStu.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduClsStuEN.IsSynScore = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsStu.IsSynScore].ToString().Trim()); //是否同步成绩
objvCurrEduClsStuEN.EduClsTypeId = objRow[convCurrEduClsStu.EduClsTypeId] == DBNull.Value ? null : objRow[convCurrEduClsStu.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduClsStuEN.UserType = objRow[convCurrEduClsStu.UserType] == DBNull.Value ? null : objRow[convCurrEduClsStu.UserType].ToString().Trim(); //用户类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCurrEduClsStuEN.IdEduClsStu, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCurrEduClsStuEN);
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
public static List<clsvCurrEduClsStuEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvCurrEduClsStuEN> arrObjLst = new List<clsvCurrEduClsStuEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduClsStuEN objvCurrEduClsStuEN = new clsvCurrEduClsStuEN();
try
{
objvCurrEduClsStuEN.IdEduClsStu = Int32.Parse(objRow[convCurrEduClsStu.IdEduClsStu].ToString().Trim()); //教学班学生流水号
objvCurrEduClsStuEN.IdCurrEduCls = objRow[convCurrEduClsStu.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduClsStuEN.CurrEduClsId = objRow[convCurrEduClsStu.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduClsStuEN.EduClsName = objRow[convCurrEduClsStu.EduClsName].ToString().Trim(); //教学班名
objvCurrEduClsStuEN.CourseId = objRow[convCurrEduClsStu.CourseId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseId].ToString().Trim(); //课程Id
objvCurrEduClsStuEN.CourseCode = objRow[convCurrEduClsStu.CourseCode] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseCode].ToString().Trim(); //课程代码
objvCurrEduClsStuEN.CourseName = objRow[convCurrEduClsStu.CourseName] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseName].ToString().Trim(); //课程名称
objvCurrEduClsStuEN.TeachingSolutionId = objRow[convCurrEduClsStu.TeachingSolutionId] == DBNull.Value ? null : objRow[convCurrEduClsStu.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduClsStuEN.TeachingSolutionName = objRow[convCurrEduClsStu.TeachingSolutionName] == DBNull.Value ? null : objRow[convCurrEduClsStu.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduClsStuEN.IdXzCollege = objRow[convCurrEduClsStu.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduClsStuEN.CollegeId = objRow[convCurrEduClsStu.CollegeId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CollegeId].ToString().Trim(); //学院ID
objvCurrEduClsStuEN.CollegeName = objRow[convCurrEduClsStu.CollegeName] == DBNull.Value ? null : objRow[convCurrEduClsStu.CollegeName].ToString().Trim(); //学院名称
objvCurrEduClsStuEN.LessonQtyPerWeek = objRow[convCurrEduClsStu.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsStu.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduClsStuEN.Mark = objRow[convCurrEduClsStu.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduClsStu.Mark].ToString().Trim()); //获得学分
objvCurrEduClsStuEN.IdUniZone = objRow[convCurrEduClsStu.IdUniZone] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduClsStuEN.GradeBaseName = objRow[convCurrEduClsStu.GradeBaseName] == DBNull.Value ? null : objRow[convCurrEduClsStu.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduClsStuEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsStu.IsEffective].ToString().Trim()); //是否有效
objvCurrEduClsStuEN.IdCourseType = objRow[convCurrEduClsStu.IdCourseType] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduClsStuEN.CourseTypeId = objRow[convCurrEduClsStu.CourseTypeId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduClsStuEN.CourseTypeName = objRow[convCurrEduClsStu.CourseTypeName] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduClsStuEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsStu.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduClsStuEN.CurrStuNum = objRow[convCurrEduClsStu.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsStu.CurrStuNum].ToString().Trim()); //当前学生数
objvCurrEduClsStuEN.IdStu = objRow[convCurrEduClsStu.IdStu] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdStu].ToString().Trim(); //学生流水号
objvCurrEduClsStuEN.StuId = objRow[convCurrEduClsStu.StuId] == DBNull.Value ? null : objRow[convCurrEduClsStu.StuId].ToString().Trim(); //学号
objvCurrEduClsStuEN.StuName = objRow[convCurrEduClsStu.StuName] == DBNull.Value ? null : objRow[convCurrEduClsStu.StuName].ToString().Trim(); //姓名
objvCurrEduClsStuEN.IdSex = objRow[convCurrEduClsStu.IdSex].ToString().Trim(); //性别流水号
objvCurrEduClsStuEN.SexDesc = objRow[convCurrEduClsStu.SexDesc] == DBNull.Value ? null : objRow[convCurrEduClsStu.SexDesc].ToString().Trim(); //性别名称
objvCurrEduClsStuEN.MajorID = objRow[convCurrEduClsStu.MajorID] == DBNull.Value ? null : objRow[convCurrEduClsStu.MajorID].ToString().Trim(); //专业ID
objvCurrEduClsStuEN.MajorName = objRow[convCurrEduClsStu.MajorName] == DBNull.Value ? null : objRow[convCurrEduClsStu.MajorName].ToString().Trim(); //专业名称
objvCurrEduClsStuEN.IdAdminCls = objRow[convCurrEduClsStu.IdAdminCls] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdAdminCls].ToString().Trim(); //行政班流水号
objvCurrEduClsStuEN.Birthday = objRow[convCurrEduClsStu.Birthday] == DBNull.Value ? null : objRow[convCurrEduClsStu.Birthday].ToString().Trim(); //出生日期
objvCurrEduClsStuEN.EduClsStuStateId = objRow[convCurrEduClsStu.EduClsStuStateId] == DBNull.Value ? null : objRow[convCurrEduClsStu.EduClsStuStateId].ToString().Trim(); //教学班学生状态编号
objvCurrEduClsStuEN.GetScoreTimes = objRow[convCurrEduClsStu.GetScoreTimes] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsStu.GetScoreTimes].ToString().Trim()); //获得成绩次数
objvCurrEduClsStuEN.Score = objRow[convCurrEduClsStu.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduClsStu.Score].ToString().Trim()); //得分
objvCurrEduClsStuEN.TotalScores = objRow[convCurrEduClsStu.TotalScores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduClsStu.TotalScores].ToString().Trim()); //总分值
objvCurrEduClsStuEN.Ranking = objRow[convCurrEduClsStu.Ranking] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsStu.Ranking].ToString().Trim()); //名次
objvCurrEduClsStuEN.Percentile = objRow[convCurrEduClsStu.Percentile] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduClsStu.Percentile].ToString().Trim()); //百分位
objvCurrEduClsStuEN.Confirmed = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsStu.Confirmed].ToString().Trim()); //是否确认
objvCurrEduClsStuEN.SchoolTerm = objRow[convCurrEduClsStu.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduClsStu.SchoolTerm].ToString().Trim(); //学期
objvCurrEduClsStuEN.SchoolYear = objRow[convCurrEduClsStu.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduClsStu.SchoolYear].ToString().Trim(); //学年
objvCurrEduClsStuEN.SignInDate = objRow[convCurrEduClsStu.SignInDate] == DBNull.Value ? null : objRow[convCurrEduClsStu.SignInDate].ToString().Trim(); //签入时间
objvCurrEduClsStuEN.SignInStateID = objRow[convCurrEduClsStu.SignInStateID] == DBNull.Value ? null : objRow[convCurrEduClsStu.SignInStateID].ToString().Trim(); //签入状态表流水号
objvCurrEduClsStuEN.SignInUser = objRow[convCurrEduClsStu.SignInUser] == DBNull.Value ? null : objRow[convCurrEduClsStu.SignInUser].ToString().Trim(); //签入人
objvCurrEduClsStuEN.ModifyDate = objRow[convCurrEduClsStu.ModifyDate] == DBNull.Value ? null : objRow[convCurrEduClsStu.ModifyDate].ToString().Trim(); //修改日期
objvCurrEduClsStuEN.ModifyUserId = objRow[convCurrEduClsStu.ModifyUserId] == DBNull.Value ? null : objRow[convCurrEduClsStu.ModifyUserId].ToString().Trim(); //修改人
objvCurrEduClsStuEN.CollegeName4Stu = objRow[convCurrEduClsStu.CollegeName4Stu] == DBNull.Value ? null : objRow[convCurrEduClsStu.CollegeName4Stu].ToString().Trim(); //CollegeName4Stu
objvCurrEduClsStuEN.EduClsTypeName = objRow[convCurrEduClsStu.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduClsStu.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduClsStuEN.IsSynScore = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsStu.IsSynScore].ToString().Trim()); //是否同步成绩
objvCurrEduClsStuEN.EduClsTypeId = objRow[convCurrEduClsStu.EduClsTypeId] == DBNull.Value ? null : objRow[convCurrEduClsStu.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduClsStuEN.UserType = objRow[convCurrEduClsStu.UserType] == DBNull.Value ? null : objRow[convCurrEduClsStu.UserType].ToString().Trim(); //用户类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCurrEduClsStuEN.IdEduClsStu, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCurrEduClsStuEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCurrEduClsStuEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvCurrEduClsStuEN> arrObjLst = new List<clsvCurrEduClsStuEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduClsStuEN objvCurrEduClsStuEN = new clsvCurrEduClsStuEN();
try
{
objvCurrEduClsStuEN.IdEduClsStu = Int32.Parse(objRow[convCurrEduClsStu.IdEduClsStu].ToString().Trim()); //教学班学生流水号
objvCurrEduClsStuEN.IdCurrEduCls = objRow[convCurrEduClsStu.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduClsStuEN.CurrEduClsId = objRow[convCurrEduClsStu.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduClsStuEN.EduClsName = objRow[convCurrEduClsStu.EduClsName].ToString().Trim(); //教学班名
objvCurrEduClsStuEN.CourseId = objRow[convCurrEduClsStu.CourseId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseId].ToString().Trim(); //课程Id
objvCurrEduClsStuEN.CourseCode = objRow[convCurrEduClsStu.CourseCode] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseCode].ToString().Trim(); //课程代码
objvCurrEduClsStuEN.CourseName = objRow[convCurrEduClsStu.CourseName] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseName].ToString().Trim(); //课程名称
objvCurrEduClsStuEN.TeachingSolutionId = objRow[convCurrEduClsStu.TeachingSolutionId] == DBNull.Value ? null : objRow[convCurrEduClsStu.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduClsStuEN.TeachingSolutionName = objRow[convCurrEduClsStu.TeachingSolutionName] == DBNull.Value ? null : objRow[convCurrEduClsStu.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduClsStuEN.IdXzCollege = objRow[convCurrEduClsStu.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduClsStuEN.CollegeId = objRow[convCurrEduClsStu.CollegeId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CollegeId].ToString().Trim(); //学院ID
objvCurrEduClsStuEN.CollegeName = objRow[convCurrEduClsStu.CollegeName] == DBNull.Value ? null : objRow[convCurrEduClsStu.CollegeName].ToString().Trim(); //学院名称
objvCurrEduClsStuEN.LessonQtyPerWeek = objRow[convCurrEduClsStu.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsStu.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduClsStuEN.Mark = objRow[convCurrEduClsStu.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduClsStu.Mark].ToString().Trim()); //获得学分
objvCurrEduClsStuEN.IdUniZone = objRow[convCurrEduClsStu.IdUniZone] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduClsStuEN.GradeBaseName = objRow[convCurrEduClsStu.GradeBaseName] == DBNull.Value ? null : objRow[convCurrEduClsStu.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduClsStuEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsStu.IsEffective].ToString().Trim()); //是否有效
objvCurrEduClsStuEN.IdCourseType = objRow[convCurrEduClsStu.IdCourseType] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduClsStuEN.CourseTypeId = objRow[convCurrEduClsStu.CourseTypeId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduClsStuEN.CourseTypeName = objRow[convCurrEduClsStu.CourseTypeName] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduClsStuEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsStu.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduClsStuEN.CurrStuNum = objRow[convCurrEduClsStu.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsStu.CurrStuNum].ToString().Trim()); //当前学生数
objvCurrEduClsStuEN.IdStu = objRow[convCurrEduClsStu.IdStu] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdStu].ToString().Trim(); //学生流水号
objvCurrEduClsStuEN.StuId = objRow[convCurrEduClsStu.StuId] == DBNull.Value ? null : objRow[convCurrEduClsStu.StuId].ToString().Trim(); //学号
objvCurrEduClsStuEN.StuName = objRow[convCurrEduClsStu.StuName] == DBNull.Value ? null : objRow[convCurrEduClsStu.StuName].ToString().Trim(); //姓名
objvCurrEduClsStuEN.IdSex = objRow[convCurrEduClsStu.IdSex].ToString().Trim(); //性别流水号
objvCurrEduClsStuEN.SexDesc = objRow[convCurrEduClsStu.SexDesc] == DBNull.Value ? null : objRow[convCurrEduClsStu.SexDesc].ToString().Trim(); //性别名称
objvCurrEduClsStuEN.MajorID = objRow[convCurrEduClsStu.MajorID] == DBNull.Value ? null : objRow[convCurrEduClsStu.MajorID].ToString().Trim(); //专业ID
objvCurrEduClsStuEN.MajorName = objRow[convCurrEduClsStu.MajorName] == DBNull.Value ? null : objRow[convCurrEduClsStu.MajorName].ToString().Trim(); //专业名称
objvCurrEduClsStuEN.IdAdminCls = objRow[convCurrEduClsStu.IdAdminCls] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdAdminCls].ToString().Trim(); //行政班流水号
objvCurrEduClsStuEN.Birthday = objRow[convCurrEduClsStu.Birthday] == DBNull.Value ? null : objRow[convCurrEduClsStu.Birthday].ToString().Trim(); //出生日期
objvCurrEduClsStuEN.EduClsStuStateId = objRow[convCurrEduClsStu.EduClsStuStateId] == DBNull.Value ? null : objRow[convCurrEduClsStu.EduClsStuStateId].ToString().Trim(); //教学班学生状态编号
objvCurrEduClsStuEN.GetScoreTimes = objRow[convCurrEduClsStu.GetScoreTimes] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsStu.GetScoreTimes].ToString().Trim()); //获得成绩次数
objvCurrEduClsStuEN.Score = objRow[convCurrEduClsStu.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduClsStu.Score].ToString().Trim()); //得分
objvCurrEduClsStuEN.TotalScores = objRow[convCurrEduClsStu.TotalScores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduClsStu.TotalScores].ToString().Trim()); //总分值
objvCurrEduClsStuEN.Ranking = objRow[convCurrEduClsStu.Ranking] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsStu.Ranking].ToString().Trim()); //名次
objvCurrEduClsStuEN.Percentile = objRow[convCurrEduClsStu.Percentile] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduClsStu.Percentile].ToString().Trim()); //百分位
objvCurrEduClsStuEN.Confirmed = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsStu.Confirmed].ToString().Trim()); //是否确认
objvCurrEduClsStuEN.SchoolTerm = objRow[convCurrEduClsStu.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduClsStu.SchoolTerm].ToString().Trim(); //学期
objvCurrEduClsStuEN.SchoolYear = objRow[convCurrEduClsStu.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduClsStu.SchoolYear].ToString().Trim(); //学年
objvCurrEduClsStuEN.SignInDate = objRow[convCurrEduClsStu.SignInDate] == DBNull.Value ? null : objRow[convCurrEduClsStu.SignInDate].ToString().Trim(); //签入时间
objvCurrEduClsStuEN.SignInStateID = objRow[convCurrEduClsStu.SignInStateID] == DBNull.Value ? null : objRow[convCurrEduClsStu.SignInStateID].ToString().Trim(); //签入状态表流水号
objvCurrEduClsStuEN.SignInUser = objRow[convCurrEduClsStu.SignInUser] == DBNull.Value ? null : objRow[convCurrEduClsStu.SignInUser].ToString().Trim(); //签入人
objvCurrEduClsStuEN.ModifyDate = objRow[convCurrEduClsStu.ModifyDate] == DBNull.Value ? null : objRow[convCurrEduClsStu.ModifyDate].ToString().Trim(); //修改日期
objvCurrEduClsStuEN.ModifyUserId = objRow[convCurrEduClsStu.ModifyUserId] == DBNull.Value ? null : objRow[convCurrEduClsStu.ModifyUserId].ToString().Trim(); //修改人
objvCurrEduClsStuEN.CollegeName4Stu = objRow[convCurrEduClsStu.CollegeName4Stu] == DBNull.Value ? null : objRow[convCurrEduClsStu.CollegeName4Stu].ToString().Trim(); //CollegeName4Stu
objvCurrEduClsStuEN.EduClsTypeName = objRow[convCurrEduClsStu.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduClsStu.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduClsStuEN.IsSynScore = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsStu.IsSynScore].ToString().Trim()); //是否同步成绩
objvCurrEduClsStuEN.EduClsTypeId = objRow[convCurrEduClsStu.EduClsTypeId] == DBNull.Value ? null : objRow[convCurrEduClsStu.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduClsStuEN.UserType = objRow[convCurrEduClsStu.UserType] == DBNull.Value ? null : objRow[convCurrEduClsStu.UserType].ToString().Trim(); //用户类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCurrEduClsStuEN.IdEduClsStu, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCurrEduClsStuEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvCurrEduClsStu(ref clsvCurrEduClsStuEN objvCurrEduClsStuEN)
{
bool bolResult = vCurrEduClsStuDA.GetvCurrEduClsStu(ref objvCurrEduClsStuEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdEduClsStu">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCurrEduClsStuEN GetObjByIdEduClsStu(long lngIdEduClsStu)
{
clsvCurrEduClsStuEN objvCurrEduClsStuEN = vCurrEduClsStuDA.GetObjByIdEduClsStu(lngIdEduClsStu);
return objvCurrEduClsStuEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvCurrEduClsStuEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvCurrEduClsStuEN objvCurrEduClsStuEN = vCurrEduClsStuDA.GetFirstObj(strWhereCond);
 return objvCurrEduClsStuEN;
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
public static clsvCurrEduClsStuEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvCurrEduClsStuEN objvCurrEduClsStuEN = vCurrEduClsStuDA.GetObjByDataRow(objRow);
 return objvCurrEduClsStuEN;
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
public static clsvCurrEduClsStuEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvCurrEduClsStuEN objvCurrEduClsStuEN = vCurrEduClsStuDA.GetObjByDataRow(objRow);
 return objvCurrEduClsStuEN;
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
 /// <param name = "lngIdEduClsStu">所给的关键字</param>
 /// <param name = "lstvCurrEduClsStuObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCurrEduClsStuEN GetObjByIdEduClsStuFromList(long lngIdEduClsStu, List<clsvCurrEduClsStuEN> lstvCurrEduClsStuObjLst)
{
foreach (clsvCurrEduClsStuEN objvCurrEduClsStuEN in lstvCurrEduClsStuObjLst)
{
if (objvCurrEduClsStuEN.IdEduClsStu == lngIdEduClsStu)
{
return objvCurrEduClsStuEN;
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
 long lngIdEduClsStu;
 try
 {
 lngIdEduClsStu = new clsvCurrEduClsStuDA().GetFirstID(strWhereCond);
 return lngIdEduClsStu;
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
 arrList = vCurrEduClsStuDA.GetID(strWhereCond);
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
bool bolIsExist = vCurrEduClsStuDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdEduClsStu">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdEduClsStu)
{
//检测记录是否存在
bool bolIsExist = vCurrEduClsStuDA.IsExist(lngIdEduClsStu);
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
 bolIsExist = clsvCurrEduClsStuDA.IsExistTable();
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
 bolIsExist = vCurrEduClsStuDA.IsExistTable(strTabName);
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
 /// <param name = "objvCurrEduClsStuENS">源对象</param>
 /// <param name = "objvCurrEduClsStuENT">目标对象</param>
 public static void CopyTo(clsvCurrEduClsStuEN objvCurrEduClsStuENS, clsvCurrEduClsStuEN objvCurrEduClsStuENT)
{
try
{
objvCurrEduClsStuENT.IdEduClsStu = objvCurrEduClsStuENS.IdEduClsStu; //教学班学生流水号
objvCurrEduClsStuENT.IdCurrEduCls = objvCurrEduClsStuENS.IdCurrEduCls; //教学班流水号
objvCurrEduClsStuENT.CurrEduClsId = objvCurrEduClsStuENS.CurrEduClsId; //教学班Id
objvCurrEduClsStuENT.EduClsName = objvCurrEduClsStuENS.EduClsName; //教学班名
objvCurrEduClsStuENT.CourseId = objvCurrEduClsStuENS.CourseId; //课程Id
objvCurrEduClsStuENT.CourseCode = objvCurrEduClsStuENS.CourseCode; //课程代码
objvCurrEduClsStuENT.CourseName = objvCurrEduClsStuENS.CourseName; //课程名称
objvCurrEduClsStuENT.TeachingSolutionId = objvCurrEduClsStuENS.TeachingSolutionId; //教学方案Id
objvCurrEduClsStuENT.TeachingSolutionName = objvCurrEduClsStuENS.TeachingSolutionName; //教学方案名称
objvCurrEduClsStuENT.IdXzCollege = objvCurrEduClsStuENS.IdXzCollege; //学院流水号
objvCurrEduClsStuENT.CollegeId = objvCurrEduClsStuENS.CollegeId; //学院ID
objvCurrEduClsStuENT.CollegeName = objvCurrEduClsStuENS.CollegeName; //学院名称
objvCurrEduClsStuENT.LessonQtyPerWeek = objvCurrEduClsStuENS.LessonQtyPerWeek; //周课时数
objvCurrEduClsStuENT.Mark = objvCurrEduClsStuENS.Mark; //获得学分
objvCurrEduClsStuENT.IdUniZone = objvCurrEduClsStuENS.IdUniZone; //校区流水号
objvCurrEduClsStuENT.GradeBaseName = objvCurrEduClsStuENS.GradeBaseName; //年级名称
objvCurrEduClsStuENT.IsEffective = objvCurrEduClsStuENS.IsEffective; //是否有效
objvCurrEduClsStuENT.IdCourseType = objvCurrEduClsStuENS.IdCourseType; //课程类型流水号
objvCurrEduClsStuENT.CourseTypeId = objvCurrEduClsStuENS.CourseTypeId; //课程类型ID
objvCurrEduClsStuENT.CourseTypeName = objvCurrEduClsStuENS.CourseTypeName; //课程类型名称
objvCurrEduClsStuENT.IsDegree = objvCurrEduClsStuENS.IsDegree; //是否学位课
objvCurrEduClsStuENT.CurrStuNum = objvCurrEduClsStuENS.CurrStuNum; //当前学生数
objvCurrEduClsStuENT.IdStu = objvCurrEduClsStuENS.IdStu; //学生流水号
objvCurrEduClsStuENT.StuId = objvCurrEduClsStuENS.StuId; //学号
objvCurrEduClsStuENT.StuName = objvCurrEduClsStuENS.StuName; //姓名
objvCurrEduClsStuENT.IdSex = objvCurrEduClsStuENS.IdSex; //性别流水号
objvCurrEduClsStuENT.SexDesc = objvCurrEduClsStuENS.SexDesc; //性别名称
objvCurrEduClsStuENT.MajorID = objvCurrEduClsStuENS.MajorID; //专业ID
objvCurrEduClsStuENT.MajorName = objvCurrEduClsStuENS.MajorName; //专业名称
objvCurrEduClsStuENT.IdAdminCls = objvCurrEduClsStuENS.IdAdminCls; //行政班流水号
objvCurrEduClsStuENT.Birthday = objvCurrEduClsStuENS.Birthday; //出生日期
objvCurrEduClsStuENT.EduClsStuStateId = objvCurrEduClsStuENS.EduClsStuStateId; //教学班学生状态编号
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
objvCurrEduClsStuENT.ModifyUserId = objvCurrEduClsStuENS.ModifyUserId; //修改人
objvCurrEduClsStuENT.CollegeName4Stu = objvCurrEduClsStuENS.CollegeName4Stu; //CollegeName4Stu
objvCurrEduClsStuENT.EduClsTypeName = objvCurrEduClsStuENS.EduClsTypeName; //教学班类型名称
objvCurrEduClsStuENT.IsSynScore = objvCurrEduClsStuENS.IsSynScore; //是否同步成绩
objvCurrEduClsStuENT.EduClsTypeId = objvCurrEduClsStuENS.EduClsTypeId; //教学班类型Id
objvCurrEduClsStuENT.UserType = objvCurrEduClsStuENS.UserType; //用户类型
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
 /// <param name = "objvCurrEduClsStuEN">源简化对象</param>
 public static void SetUpdFlag(clsvCurrEduClsStuEN objvCurrEduClsStuEN)
{
try
{
objvCurrEduClsStuEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvCurrEduClsStuEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convCurrEduClsStu.IdEduClsStu, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsStuEN.IdEduClsStu = objvCurrEduClsStuEN.IdEduClsStu; //教学班学生流水号
}
if (arrFldSet.Contains(convCurrEduClsStu.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsStuEN.IdCurrEduCls = objvCurrEduClsStuEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convCurrEduClsStu.CurrEduClsId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsStuEN.CurrEduClsId = objvCurrEduClsStuEN.CurrEduClsId == "[null]" ? null :  objvCurrEduClsStuEN.CurrEduClsId; //教学班Id
}
if (arrFldSet.Contains(convCurrEduClsStu.EduClsName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsStuEN.EduClsName = objvCurrEduClsStuEN.EduClsName; //教学班名
}
if (arrFldSet.Contains(convCurrEduClsStu.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsStuEN.CourseId = objvCurrEduClsStuEN.CourseId == "[null]" ? null :  objvCurrEduClsStuEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convCurrEduClsStu.CourseCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsStuEN.CourseCode = objvCurrEduClsStuEN.CourseCode == "[null]" ? null :  objvCurrEduClsStuEN.CourseCode; //课程代码
}
if (arrFldSet.Contains(convCurrEduClsStu.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsStuEN.CourseName = objvCurrEduClsStuEN.CourseName == "[null]" ? null :  objvCurrEduClsStuEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convCurrEduClsStu.TeachingSolutionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsStuEN.TeachingSolutionId = objvCurrEduClsStuEN.TeachingSolutionId == "[null]" ? null :  objvCurrEduClsStuEN.TeachingSolutionId; //教学方案Id
}
if (arrFldSet.Contains(convCurrEduClsStu.TeachingSolutionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsStuEN.TeachingSolutionName = objvCurrEduClsStuEN.TeachingSolutionName == "[null]" ? null :  objvCurrEduClsStuEN.TeachingSolutionName; //教学方案名称
}
if (arrFldSet.Contains(convCurrEduClsStu.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsStuEN.IdXzCollege = objvCurrEduClsStuEN.IdXzCollege == "[null]" ? null :  objvCurrEduClsStuEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convCurrEduClsStu.CollegeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsStuEN.CollegeId = objvCurrEduClsStuEN.CollegeId == "[null]" ? null :  objvCurrEduClsStuEN.CollegeId; //学院ID
}
if (arrFldSet.Contains(convCurrEduClsStu.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsStuEN.CollegeName = objvCurrEduClsStuEN.CollegeName == "[null]" ? null :  objvCurrEduClsStuEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convCurrEduClsStu.LessonQtyPerWeek, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsStuEN.LessonQtyPerWeek = objvCurrEduClsStuEN.LessonQtyPerWeek; //周课时数
}
if (arrFldSet.Contains(convCurrEduClsStu.Mark, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsStuEN.Mark = objvCurrEduClsStuEN.Mark; //获得学分
}
if (arrFldSet.Contains(convCurrEduClsStu.IdUniZone, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsStuEN.IdUniZone = objvCurrEduClsStuEN.IdUniZone == "[null]" ? null :  objvCurrEduClsStuEN.IdUniZone; //校区流水号
}
if (arrFldSet.Contains(convCurrEduClsStu.GradeBaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsStuEN.GradeBaseName = objvCurrEduClsStuEN.GradeBaseName == "[null]" ? null :  objvCurrEduClsStuEN.GradeBaseName; //年级名称
}
if (arrFldSet.Contains(convCurrEduClsStu.IsEffective, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsStuEN.IsEffective = objvCurrEduClsStuEN.IsEffective; //是否有效
}
if (arrFldSet.Contains(convCurrEduClsStu.IdCourseType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsStuEN.IdCourseType = objvCurrEduClsStuEN.IdCourseType == "[null]" ? null :  objvCurrEduClsStuEN.IdCourseType; //课程类型流水号
}
if (arrFldSet.Contains(convCurrEduClsStu.CourseTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsStuEN.CourseTypeId = objvCurrEduClsStuEN.CourseTypeId == "[null]" ? null :  objvCurrEduClsStuEN.CourseTypeId; //课程类型ID
}
if (arrFldSet.Contains(convCurrEduClsStu.CourseTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsStuEN.CourseTypeName = objvCurrEduClsStuEN.CourseTypeName == "[null]" ? null :  objvCurrEduClsStuEN.CourseTypeName; //课程类型名称
}
if (arrFldSet.Contains(convCurrEduClsStu.IsDegree, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsStuEN.IsDegree = objvCurrEduClsStuEN.IsDegree; //是否学位课
}
if (arrFldSet.Contains(convCurrEduClsStu.CurrStuNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsStuEN.CurrStuNum = objvCurrEduClsStuEN.CurrStuNum; //当前学生数
}
if (arrFldSet.Contains(convCurrEduClsStu.IdStu, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsStuEN.IdStu = objvCurrEduClsStuEN.IdStu == "[null]" ? null :  objvCurrEduClsStuEN.IdStu; //学生流水号
}
if (arrFldSet.Contains(convCurrEduClsStu.StuId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsStuEN.StuId = objvCurrEduClsStuEN.StuId == "[null]" ? null :  objvCurrEduClsStuEN.StuId; //学号
}
if (arrFldSet.Contains(convCurrEduClsStu.StuName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsStuEN.StuName = objvCurrEduClsStuEN.StuName == "[null]" ? null :  objvCurrEduClsStuEN.StuName; //姓名
}
if (arrFldSet.Contains(convCurrEduClsStu.IdSex, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsStuEN.IdSex = objvCurrEduClsStuEN.IdSex; //性别流水号
}
if (arrFldSet.Contains(convCurrEduClsStu.SexDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsStuEN.SexDesc = objvCurrEduClsStuEN.SexDesc == "[null]" ? null :  objvCurrEduClsStuEN.SexDesc; //性别名称
}
if (arrFldSet.Contains(convCurrEduClsStu.MajorID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsStuEN.MajorID = objvCurrEduClsStuEN.MajorID == "[null]" ? null :  objvCurrEduClsStuEN.MajorID; //专业ID
}
if (arrFldSet.Contains(convCurrEduClsStu.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsStuEN.MajorName = objvCurrEduClsStuEN.MajorName == "[null]" ? null :  objvCurrEduClsStuEN.MajorName; //专业名称
}
if (arrFldSet.Contains(convCurrEduClsStu.IdAdminCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsStuEN.IdAdminCls = objvCurrEduClsStuEN.IdAdminCls == "[null]" ? null :  objvCurrEduClsStuEN.IdAdminCls; //行政班流水号
}
if (arrFldSet.Contains(convCurrEduClsStu.Birthday, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsStuEN.Birthday = objvCurrEduClsStuEN.Birthday == "[null]" ? null :  objvCurrEduClsStuEN.Birthday; //出生日期
}
if (arrFldSet.Contains(convCurrEduClsStu.EduClsStuStateId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsStuEN.EduClsStuStateId = objvCurrEduClsStuEN.EduClsStuStateId == "[null]" ? null :  objvCurrEduClsStuEN.EduClsStuStateId; //教学班学生状态编号
}
if (arrFldSet.Contains(convCurrEduClsStu.GetScoreTimes, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsStuEN.GetScoreTimes = objvCurrEduClsStuEN.GetScoreTimes; //获得成绩次数
}
if (arrFldSet.Contains(convCurrEduClsStu.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsStuEN.Score = objvCurrEduClsStuEN.Score; //得分
}
if (arrFldSet.Contains(convCurrEduClsStu.TotalScores, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsStuEN.TotalScores = objvCurrEduClsStuEN.TotalScores; //总分值
}
if (arrFldSet.Contains(convCurrEduClsStu.Ranking, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsStuEN.Ranking = objvCurrEduClsStuEN.Ranking; //名次
}
if (arrFldSet.Contains(convCurrEduClsStu.Percentile, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsStuEN.Percentile = objvCurrEduClsStuEN.Percentile; //百分位
}
if (arrFldSet.Contains(convCurrEduClsStu.Confirmed, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsStuEN.Confirmed = objvCurrEduClsStuEN.Confirmed; //是否确认
}
if (arrFldSet.Contains(convCurrEduClsStu.SchoolTerm, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsStuEN.SchoolTerm = objvCurrEduClsStuEN.SchoolTerm == "[null]" ? null :  objvCurrEduClsStuEN.SchoolTerm; //学期
}
if (arrFldSet.Contains(convCurrEduClsStu.SchoolYear, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsStuEN.SchoolYear = objvCurrEduClsStuEN.SchoolYear == "[null]" ? null :  objvCurrEduClsStuEN.SchoolYear; //学年
}
if (arrFldSet.Contains(convCurrEduClsStu.SignInDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsStuEN.SignInDate = objvCurrEduClsStuEN.SignInDate == "[null]" ? null :  objvCurrEduClsStuEN.SignInDate; //签入时间
}
if (arrFldSet.Contains(convCurrEduClsStu.SignInStateID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsStuEN.SignInStateID = objvCurrEduClsStuEN.SignInStateID == "[null]" ? null :  objvCurrEduClsStuEN.SignInStateID; //签入状态表流水号
}
if (arrFldSet.Contains(convCurrEduClsStu.SignInUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsStuEN.SignInUser = objvCurrEduClsStuEN.SignInUser == "[null]" ? null :  objvCurrEduClsStuEN.SignInUser; //签入人
}
if (arrFldSet.Contains(convCurrEduClsStu.ModifyDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsStuEN.ModifyDate = objvCurrEduClsStuEN.ModifyDate == "[null]" ? null :  objvCurrEduClsStuEN.ModifyDate; //修改日期
}
if (arrFldSet.Contains(convCurrEduClsStu.ModifyUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsStuEN.ModifyUserId = objvCurrEduClsStuEN.ModifyUserId == "[null]" ? null :  objvCurrEduClsStuEN.ModifyUserId; //修改人
}
if (arrFldSet.Contains(convCurrEduClsStu.CollegeName4Stu, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsStuEN.CollegeName4Stu = objvCurrEduClsStuEN.CollegeName4Stu == "[null]" ? null :  objvCurrEduClsStuEN.CollegeName4Stu; //CollegeName4Stu
}
if (arrFldSet.Contains(convCurrEduClsStu.EduClsTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsStuEN.EduClsTypeName = objvCurrEduClsStuEN.EduClsTypeName == "[null]" ? null :  objvCurrEduClsStuEN.EduClsTypeName; //教学班类型名称
}
if (arrFldSet.Contains(convCurrEduClsStu.IsSynScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsStuEN.IsSynScore = objvCurrEduClsStuEN.IsSynScore; //是否同步成绩
}
if (arrFldSet.Contains(convCurrEduClsStu.EduClsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsStuEN.EduClsTypeId = objvCurrEduClsStuEN.EduClsTypeId == "[null]" ? null :  objvCurrEduClsStuEN.EduClsTypeId; //教学班类型Id
}
if (arrFldSet.Contains(convCurrEduClsStu.UserType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduClsStuEN.UserType = objvCurrEduClsStuEN.UserType == "[null]" ? null :  objvCurrEduClsStuEN.UserType; //用户类型
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
 /// <param name = "objvCurrEduClsStuEN">源简化对象</param>
 public static void AccessFldValueNull(clsvCurrEduClsStuEN objvCurrEduClsStuEN)
{
try
{
if (objvCurrEduClsStuEN.CurrEduClsId == "[null]") objvCurrEduClsStuEN.CurrEduClsId = null; //教学班Id
if (objvCurrEduClsStuEN.CourseId == "[null]") objvCurrEduClsStuEN.CourseId = null; //课程Id
if (objvCurrEduClsStuEN.CourseCode == "[null]") objvCurrEduClsStuEN.CourseCode = null; //课程代码
if (objvCurrEduClsStuEN.CourseName == "[null]") objvCurrEduClsStuEN.CourseName = null; //课程名称
if (objvCurrEduClsStuEN.TeachingSolutionId == "[null]") objvCurrEduClsStuEN.TeachingSolutionId = null; //教学方案Id
if (objvCurrEduClsStuEN.TeachingSolutionName == "[null]") objvCurrEduClsStuEN.TeachingSolutionName = null; //教学方案名称
if (objvCurrEduClsStuEN.IdXzCollege == "[null]") objvCurrEduClsStuEN.IdXzCollege = null; //学院流水号
if (objvCurrEduClsStuEN.CollegeId == "[null]") objvCurrEduClsStuEN.CollegeId = null; //学院ID
if (objvCurrEduClsStuEN.CollegeName == "[null]") objvCurrEduClsStuEN.CollegeName = null; //学院名称
if (objvCurrEduClsStuEN.IdUniZone == "[null]") objvCurrEduClsStuEN.IdUniZone = null; //校区流水号
if (objvCurrEduClsStuEN.GradeBaseName == "[null]") objvCurrEduClsStuEN.GradeBaseName = null; //年级名称
if (objvCurrEduClsStuEN.IdCourseType == "[null]") objvCurrEduClsStuEN.IdCourseType = null; //课程类型流水号
if (objvCurrEduClsStuEN.CourseTypeId == "[null]") objvCurrEduClsStuEN.CourseTypeId = null; //课程类型ID
if (objvCurrEduClsStuEN.CourseTypeName == "[null]") objvCurrEduClsStuEN.CourseTypeName = null; //课程类型名称
if (objvCurrEduClsStuEN.IdStu == "[null]") objvCurrEduClsStuEN.IdStu = null; //学生流水号
if (objvCurrEduClsStuEN.StuId == "[null]") objvCurrEduClsStuEN.StuId = null; //学号
if (objvCurrEduClsStuEN.StuName == "[null]") objvCurrEduClsStuEN.StuName = null; //姓名
if (objvCurrEduClsStuEN.SexDesc == "[null]") objvCurrEduClsStuEN.SexDesc = null; //性别名称
if (objvCurrEduClsStuEN.MajorID == "[null]") objvCurrEduClsStuEN.MajorID = null; //专业ID
if (objvCurrEduClsStuEN.MajorName == "[null]") objvCurrEduClsStuEN.MajorName = null; //专业名称
if (objvCurrEduClsStuEN.IdAdminCls == "[null]") objvCurrEduClsStuEN.IdAdminCls = null; //行政班流水号
if (objvCurrEduClsStuEN.Birthday == "[null]") objvCurrEduClsStuEN.Birthday = null; //出生日期
if (objvCurrEduClsStuEN.EduClsStuStateId == "[null]") objvCurrEduClsStuEN.EduClsStuStateId = null; //教学班学生状态编号
if (objvCurrEduClsStuEN.SchoolTerm == "[null]") objvCurrEduClsStuEN.SchoolTerm = null; //学期
if (objvCurrEduClsStuEN.SchoolYear == "[null]") objvCurrEduClsStuEN.SchoolYear = null; //学年
if (objvCurrEduClsStuEN.SignInDate == "[null]") objvCurrEduClsStuEN.SignInDate = null; //签入时间
if (objvCurrEduClsStuEN.SignInStateID == "[null]") objvCurrEduClsStuEN.SignInStateID = null; //签入状态表流水号
if (objvCurrEduClsStuEN.SignInUser == "[null]") objvCurrEduClsStuEN.SignInUser = null; //签入人
if (objvCurrEduClsStuEN.ModifyDate == "[null]") objvCurrEduClsStuEN.ModifyDate = null; //修改日期
if (objvCurrEduClsStuEN.ModifyUserId == "[null]") objvCurrEduClsStuEN.ModifyUserId = null; //修改人
if (objvCurrEduClsStuEN.CollegeName4Stu == "[null]") objvCurrEduClsStuEN.CollegeName4Stu = null; //CollegeName4Stu
if (objvCurrEduClsStuEN.EduClsTypeName == "[null]") objvCurrEduClsStuEN.EduClsTypeName = null; //教学班类型名称
if (objvCurrEduClsStuEN.EduClsTypeId == "[null]") objvCurrEduClsStuEN.EduClsTypeId = null; //教学班类型Id
if (objvCurrEduClsStuEN.UserType == "[null]") objvCurrEduClsStuEN.UserType = null; //用户类型
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
public static void CheckProperty4Condition(clsvCurrEduClsStuEN objvCurrEduClsStuEN)
{
 vCurrEduClsStuDA.CheckProperty4Condition(objvCurrEduClsStuEN);
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
if (clsCurrEduClsStuBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCurrEduClsStuBL没有刷新缓存机制(clsCurrEduClsStuBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseTypeBL没有刷新缓存机制(clscc_CourseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzClgBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgBL没有刷新缓存机制(clsXzClgBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorBL没有刷新缓存机制(clsXzMajorBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCurrEduClsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCurrEduClsBL没有刷新缓存机制(clsCurrEduClsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzGradeBaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGradeBaseBL没有刷新缓存机制(clsXzGradeBaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsgs_EduClsTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_EduClsTypeBL没有刷新缓存机制(clsgs_EduClsTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzUniZoneBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzUniZoneBL没有刷新缓存机制(clsXzUniZoneBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSexBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSexBL没有刷新缓存机制(clsSexBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsEthnicBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsEthnicBL没有刷新缓存机制(clsRsEthnicBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsPoliticsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsPoliticsBL没有刷新缓存机制(clsRsPoliticsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudentInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudentInfoBL没有刷新缓存机制(clsStudentInfoBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsStuTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsStuTypeBL没有刷新缓存机制(clsRsStuTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseBL没有刷新缓存机制(clscc_CourseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExcellentTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExcellentTypeBL没有刷新缓存机制(clscc_ExcellentTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ThemesBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ThemesBL没有刷新缓存机制(clscc_ThemesBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachingSolutionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachingSolutionBL没有刷新缓存机制(clsTeachingSolutionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzAdminClsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzAdminClsBL没有刷新缓存机制(clsXzAdminClsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzAdminClsTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzAdminClsTypeBL没有刷新缓存机制(clsXzAdminClsTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseIsLikeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeBL没有刷新缓存机制(clscc_CourseIsLikeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeacherInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeacherInfoBL没有刷新缓存机制(clsTeacherInfoBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsStaffTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsStaffTypeBL没有刷新缓存机制(clsRsStaffTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsProfGradeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsProfGradeBL没有刷新缓存机制(clsRsProfGradeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsDegreeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsDegreeBL没有刷新缓存机制(clsRsDegreeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsProvinceBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsProvinceBL没有刷新缓存机制(clsRsProvinceBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsReligionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsReligionBL没有刷新缓存机制(clsRsReligionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsQualifBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsQualifBL没有刷新缓存机制(clsRsQualifBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsAdminGradeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsAdminGradeBL没有刷新缓存机制(clsRsAdminGradeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudyLevelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelBL没有刷新缓存机制(clsStudyLevelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdEduClsStu");
//if (arrvCurrEduClsStuObjLstCache == null)
//{
//arrvCurrEduClsStuObjLstCache = vCurrEduClsStuDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdEduClsStu">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCurrEduClsStuEN GetObjByIdEduClsStuCache(long lngIdEduClsStu, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvCurrEduClsStuEN._CurrTabName, strIdCurrEduCls);
List<clsvCurrEduClsStuEN> arrvCurrEduClsStuObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvCurrEduClsStuEN> arrvCurrEduClsStuObjLst_Sel =
arrvCurrEduClsStuObjLstCache
.Where(x=> x.IdEduClsStu == lngIdEduClsStu 
);
if (arrvCurrEduClsStuObjLst_Sel.Count() == 0)
{
   clsvCurrEduClsStuEN obj = clsvCurrEduClsStuBL.GetObjByIdEduClsStu(lngIdEduClsStu);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngIdEduClsStu, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvCurrEduClsStuObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCurrEduClsStuEN> GetAllvCurrEduClsStuObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsvCurrEduClsStuEN> arrvCurrEduClsStuObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrvCurrEduClsStuObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCurrEduClsStuEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvCurrEduClsStuEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsvCurrEduClsStuEN> arrvCurrEduClsStuObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvCurrEduClsStuObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvCurrEduClsStuEN._CurrTabName, strIdCurrEduCls);
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
 /// 日期:2024-03-18
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngIdEduClsStu, string strIdCurrEduCls)
{
if (strInFldName != convCurrEduClsStu.IdEduClsStu)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convCurrEduClsStu.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convCurrEduClsStu.AttributeName));
throw new Exception(strMsg);
}
var objvCurrEduClsStu = clsvCurrEduClsStuBL.GetObjByIdEduClsStuCache(lngIdEduClsStu, strIdCurrEduCls);
if (objvCurrEduClsStu == null) return "";
return objvCurrEduClsStu[strOutFldName].ToString();
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
int intRecCount = clsvCurrEduClsStuDA.GetRecCount(strTabName);
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
int intRecCount = clsvCurrEduClsStuDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvCurrEduClsStuDA.GetRecCount();
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
int intRecCount = clsvCurrEduClsStuDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvCurrEduClsStuCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvCurrEduClsStuEN objvCurrEduClsStuCond)
{
 string strIdCurrEduCls = objvCurrEduClsStuCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvCurrEduClsStuBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvCurrEduClsStuEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvCurrEduClsStuEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCurrEduClsStu.AttributeName)
{
if (objvCurrEduClsStuCond.IsUpdated(strFldName) == false) continue;
if (objvCurrEduClsStuCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCurrEduClsStuCond[strFldName].ToString());
}
else
{
if (objvCurrEduClsStuCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCurrEduClsStuCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCurrEduClsStuCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCurrEduClsStuCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCurrEduClsStuCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCurrEduClsStuCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCurrEduClsStuCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCurrEduClsStuCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCurrEduClsStuCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCurrEduClsStuCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCurrEduClsStuCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCurrEduClsStuCond[strFldName]));
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
 List<string> arrList = clsvCurrEduClsStuDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vCurrEduClsStuDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vCurrEduClsStuDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}