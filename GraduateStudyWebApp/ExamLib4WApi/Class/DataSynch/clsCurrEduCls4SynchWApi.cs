
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCurrEduCls4SynchWApi
 表名:CurrEduCls4Synch(01120358)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:53:41
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:数据同步
 模块英文名:DataSynch
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
public static class clsCurrEduCls4SynchWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetIpAddress(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strIpAddress, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIpAddress, 50, conCurrEduCls4Synch.IpAddress);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls4SynchEN Setid_CurrEduCls(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strid_CurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_CurrEduCls, conCurrEduCls4Synch.id_CurrEduCls);
clsCheckSql.CheckFieldLen(strid_CurrEduCls, 8, conCurrEduCls4Synch.id_CurrEduCls);
clsCheckSql.CheckFieldForeignKey(strid_CurrEduCls, 8, conCurrEduCls4Synch.id_CurrEduCls);
objCurrEduCls4SynchEN.id_CurrEduCls = strid_CurrEduCls; //当前教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.id_CurrEduCls) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.id_CurrEduCls, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.id_CurrEduCls] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetCurrEduClsId(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strCurrEduClsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCurrEduClsId, conCurrEduCls4Synch.CurrEduClsId);
clsCheckSql.CheckFieldLen(strCurrEduClsId, 15, conCurrEduCls4Synch.CurrEduClsId);
objCurrEduCls4SynchEN.CurrEduClsId = strCurrEduClsId; //当前教学班Id
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetEduClsName(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strEduClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduClsName, 100, conCurrEduCls4Synch.EduClsName);
objCurrEduCls4SynchEN.EduClsName = strEduClsName; //教学班名称
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetEduClsTypeId(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strEduClsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduClsTypeId, 4, conCurrEduCls4Synch.EduClsTypeId);
clsCheckSql.CheckFieldForeignKey(strEduClsTypeId, 4, conCurrEduCls4Synch.EduClsTypeId);
objCurrEduCls4SynchEN.EduClsTypeId = strEduClsTypeId; //教学班类型代号
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetCourseId(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, conCurrEduCls4Synch.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, conCurrEduCls4Synch.CourseId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetTeachingSolutionId(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strTeachingSolutionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingSolutionId, 8, conCurrEduCls4Synch.TeachingSolutionId);
clsCheckSql.CheckFieldForeignKey(strTeachingSolutionId, 8, conCurrEduCls4Synch.TeachingSolutionId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls4SynchEN Setid_XzCollege(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, conCurrEduCls4Synch.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, conCurrEduCls4Synch.id_XzCollege);
objCurrEduCls4SynchEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.id_XzCollege) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.id_XzCollege, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.id_XzCollege] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls4SynchEN Setid_EduWay(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strid_EduWay, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_EduWay, 4, conCurrEduCls4Synch.id_EduWay);
clsCheckSql.CheckFieldForeignKey(strid_EduWay, 4, conCurrEduCls4Synch.id_EduWay);
objCurrEduCls4SynchEN.id_EduWay = strid_EduWay; //教学方式流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.id_EduWay) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.id_EduWay, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.id_EduWay] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls4SynchEN Setid_ClassRoomType(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strid_ClassRoomType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_ClassRoomType, 4, conCurrEduCls4Synch.id_ClassRoomType);
clsCheckSql.CheckFieldForeignKey(strid_ClassRoomType, 4, conCurrEduCls4Synch.id_ClassRoomType);
objCurrEduCls4SynchEN.id_ClassRoomType = strid_ClassRoomType; //教室类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.id_ClassRoomType) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.id_ClassRoomType, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.id_ClassRoomType] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetTotalLessonQty(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, int intTotalLessonQty, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetMaxStuQty(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, int intMaxStuQty, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetCurrentStuQty(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, int intCurrentStuQty, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetWeekQty(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, int intWeekQty, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetScheUnitPW(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, short shtScheUnitPW, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetWeekStatusID(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strWeekStatusID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWeekStatusID, 2, conCurrEduCls4Synch.WeekStatusID);
clsCheckSql.CheckFieldForeignKey(strWeekStatusID, 2, conCurrEduCls4Synch.WeekStatusID);
objCurrEduCls4SynchEN.WeekStatusID = strWeekStatusID; //周状态编号(单,双,全周)
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.WeekStatusID) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.WeekStatusID, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.WeekStatusID] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetCustomerWeek(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strCustomerWeek, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCustomerWeek, 50, conCurrEduCls4Synch.CustomerWeek);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls4SynchEN Setid_ExecPlan(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strid_ExecPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_ExecPlan, 8, conCurrEduCls4Synch.id_ExecPlan);
clsCheckSql.CheckFieldForeignKey(strid_ExecPlan, 8, conCurrEduCls4Synch.id_ExecPlan);
objCurrEduCls4SynchEN.id_ExecPlan = strid_ExecPlan; //执行计划流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.id_ExecPlan) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.id_ExecPlan, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.id_ExecPlan] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetLessonQtyPerWeek(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, short shtLessonQtyPerWeek, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetMark(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, double dblMark, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetCheckClassRoom(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strCheckClassRoom, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCheckClassRoom, 2000, conCurrEduCls4Synch.CheckClassRoom);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetCheckAdminCls(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strCheckAdminCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCheckAdminCls, 2000, conCurrEduCls4Synch.CheckAdminCls);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetCheckTeacher(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strCheckTeacher, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCheckTeacher, 2000, conCurrEduCls4Synch.CheckTeacher);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls4SynchEN Setid_UniZone(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strid_UniZone, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_UniZone, 4, conCurrEduCls4Synch.id_UniZone);
clsCheckSql.CheckFieldForeignKey(strid_UniZone, 4, conCurrEduCls4Synch.id_UniZone);
objCurrEduCls4SynchEN.id_UniZone = strid_UniZone; //校区流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.id_UniZone) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.id_UniZone, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.id_UniZone] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls4SynchEN Setid_GradeBase(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strid_GradeBase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_GradeBase, 4, conCurrEduCls4Synch.id_GradeBase);
clsCheckSql.CheckFieldForeignKey(strid_GradeBase, 4, conCurrEduCls4Synch.id_GradeBase);
objCurrEduCls4SynchEN.id_GradeBase = strid_GradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.id_GradeBase) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.id_GradeBase, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.id_GradeBase] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetSchoolYear(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strSchoolYear, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, conCurrEduCls4Synch.SchoolYear);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetSchoolTerm(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strSchoolTerm, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, conCurrEduCls4Synch.SchoolTerm);
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, conCurrEduCls4Synch.SchoolTerm);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetArrangeCourseMemo(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strArrangeCourseMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strArrangeCourseMemo, 50, conCurrEduCls4Synch.ArrangeCourseMemo);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls4SynchEN Setid_CourseType(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strid_CourseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_CourseType, 4, conCurrEduCls4Synch.id_CourseType);
clsCheckSql.CheckFieldForeignKey(strid_CourseType, 4, conCurrEduCls4Synch.id_CourseType);
objCurrEduCls4SynchEN.id_CourseType = strid_CourseType; //课程类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.id_CourseType) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.id_CourseType, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.id_CourseType] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetExportDate(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strExportDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExportDate, 8, conCurrEduCls4Synch.ExportDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls4SynchEN Setid_ScoreType(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strid_ScoreType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_ScoreType, 4, conCurrEduCls4Synch.id_ScoreType);
clsCheckSql.CheckFieldForeignKey(strid_ScoreType, 4, conCurrEduCls4Synch.id_ScoreType);
objCurrEduCls4SynchEN.id_ScoreType = strid_ScoreType; //成绩类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.id_ScoreType) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.id_ScoreType, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.id_ScoreType] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetGetScoreWayId(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strGetScoreWayId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGetScoreWayId, 2, conCurrEduCls4Synch.GetScoreWayId);
clsCheckSql.CheckFieldForeignKey(strGetScoreWayId, 2, conCurrEduCls4Synch.GetScoreWayId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetSynchToWebDate(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strSynchToWebDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSynchToWebDate, 20, conCurrEduCls4Synch.SynchToWebDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetSynchToWebUser(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strSynchToWebUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSynchToWebUser, 18, conCurrEduCls4Synch.SynchToWebUser);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetSignInDate(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strSignInDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSignInDate, 20, conCurrEduCls4Synch.SignInDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetSignInStateID(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strSignInStateID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSignInStateID, 2, conCurrEduCls4Synch.SignInStateID);
clsCheckSql.CheckFieldForeignKey(strSignInStateID, 2, conCurrEduCls4Synch.SignInStateID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetSignInUser(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strSignInUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSignInUser, 18, conCurrEduCls4Synch.SignInUser);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls4SynchEN Setid_ExamType(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strid_ExamType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_ExamType, 4, conCurrEduCls4Synch.id_ExamType);
clsCheckSql.CheckFieldForeignKey(strid_ExamType, 4, conCurrEduCls4Synch.id_ExamType);
objCurrEduCls4SynchEN.id_ExamType = strid_ExamType; //考试方式流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.id_ExamType) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.id_ExamType, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.id_ExamType] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetExamPortion(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, short shtExamPortion, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetMidExamScorePortion(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, short shtMidExamScorePortion, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetGeneratePwdDate(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strGeneratePwdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGeneratePwdDate, 20, conCurrEduCls4Synch.GeneratePwdDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetExamTime(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strExamTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamTime, 8, conCurrEduCls4Synch.ExamTime);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetCheckDate(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strCheckDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCheckDate, 20, conCurrEduCls4Synch.CheckDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls4SynchEN Setid_EduClassInPk(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strid_EduClassInPk, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_EduClassInPk, 8, conCurrEduCls4Synch.id_EduClassInPk);
clsCheckSql.CheckFieldForeignKey(strid_EduClassInPk, 8, conCurrEduCls4Synch.id_EduClassInPk);
objCurrEduCls4SynchEN.id_EduClassInPk = strid_EduClassInPk; //id_EduClassInPk
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.id_EduClassInPk) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.id_EduClassInPk, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.id_EduClassInPk] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetPkWeekTime(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strPkWeekTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPkWeekTime, 2000, conCurrEduCls4Synch.PkWeekTime);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetPkClassRooms(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strPkClassRooms, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPkClassRooms, 150, conCurrEduCls4Synch.PkClassRooms);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetBeginWeek(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, short shtBeginWeek, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetTeacherNames(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strTeacherNames, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeacherNames, 100, conCurrEduCls4Synch.TeacherNames);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetAccessSynchDate(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strAccessSynchDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAccessSynchDate, 14, conCurrEduCls4Synch.AccessSynchDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetModifyDate(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strModifyDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyDate, 20, conCurrEduCls4Synch.ModifyDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetModifyUserID(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strModifyUserID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyUserID, 18, conCurrEduCls4Synch.ModifyUserID);
objCurrEduCls4SynchEN.ModifyUserID = strModifyUserID; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduCls4Synch.ModifyUserID) == false)
{
objCurrEduCls4SynchEN.dicFldComparisonOp.Add(conCurrEduCls4Synch.ModifyUserID, strComparisonOp);
}
else
{
objCurrEduCls4SynchEN.dicFldComparisonOp[conCurrEduCls4Synch.ModifyUserID] = strComparisonOp;
}
}
return objCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduCls4SynchEN SetMemo(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCurrEduCls4Synch.Memo);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCurrEduCls4SynchEN objCurrEduCls4Synch_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.mId) == true)
{
string strComparisonOp_mId = objCurrEduCls4Synch_Cond.dicFldComparisonOp[conCurrEduCls4Synch.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduCls4Synch.mId, objCurrEduCls4Synch_Cond.mId, strComparisonOp_mId);
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.IpAddress) == true)
{
string strComparisonOp_IpAddress = objCurrEduCls4Synch_Cond.dicFldComparisonOp[conCurrEduCls4Synch.IpAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.IpAddress, objCurrEduCls4Synch_Cond.IpAddress, strComparisonOp_IpAddress);
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.id_CurrEduCls) == true)
{
string strComparisonOp_id_CurrEduCls = objCurrEduCls4Synch_Cond.dicFldComparisonOp[conCurrEduCls4Synch.id_CurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.id_CurrEduCls, objCurrEduCls4Synch_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.CurrEduClsId) == true)
{
string strComparisonOp_CurrEduClsId = objCurrEduCls4Synch_Cond.dicFldComparisonOp[conCurrEduCls4Synch.CurrEduClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.CurrEduClsId, objCurrEduCls4Synch_Cond.CurrEduClsId, strComparisonOp_CurrEduClsId);
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.EduClsName) == true)
{
string strComparisonOp_EduClsName = objCurrEduCls4Synch_Cond.dicFldComparisonOp[conCurrEduCls4Synch.EduClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.EduClsName, objCurrEduCls4Synch_Cond.EduClsName, strComparisonOp_EduClsName);
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.EduClsTypeId) == true)
{
string strComparisonOp_EduClsTypeId = objCurrEduCls4Synch_Cond.dicFldComparisonOp[conCurrEduCls4Synch.EduClsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.EduClsTypeId, objCurrEduCls4Synch_Cond.EduClsTypeId, strComparisonOp_EduClsTypeId);
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.CourseId) == true)
{
string strComparisonOp_CourseId = objCurrEduCls4Synch_Cond.dicFldComparisonOp[conCurrEduCls4Synch.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.CourseId, objCurrEduCls4Synch_Cond.CourseId, strComparisonOp_CourseId);
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.TeachingSolutionId) == true)
{
string strComparisonOp_TeachingSolutionId = objCurrEduCls4Synch_Cond.dicFldComparisonOp[conCurrEduCls4Synch.TeachingSolutionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.TeachingSolutionId, objCurrEduCls4Synch_Cond.TeachingSolutionId, strComparisonOp_TeachingSolutionId);
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objCurrEduCls4Synch_Cond.dicFldComparisonOp[conCurrEduCls4Synch.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.id_XzCollege, objCurrEduCls4Synch_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.id_EduWay) == true)
{
string strComparisonOp_id_EduWay = objCurrEduCls4Synch_Cond.dicFldComparisonOp[conCurrEduCls4Synch.id_EduWay];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.id_EduWay, objCurrEduCls4Synch_Cond.id_EduWay, strComparisonOp_id_EduWay);
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.id_ClassRoomType) == true)
{
string strComparisonOp_id_ClassRoomType = objCurrEduCls4Synch_Cond.dicFldComparisonOp[conCurrEduCls4Synch.id_ClassRoomType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.id_ClassRoomType, objCurrEduCls4Synch_Cond.id_ClassRoomType, strComparisonOp_id_ClassRoomType);
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.TotalLessonQty) == true)
{
string strComparisonOp_TotalLessonQty = objCurrEduCls4Synch_Cond.dicFldComparisonOp[conCurrEduCls4Synch.TotalLessonQty];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduCls4Synch.TotalLessonQty, objCurrEduCls4Synch_Cond.TotalLessonQty, strComparisonOp_TotalLessonQty);
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.MaxStuQty) == true)
{
string strComparisonOp_MaxStuQty = objCurrEduCls4Synch_Cond.dicFldComparisonOp[conCurrEduCls4Synch.MaxStuQty];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduCls4Synch.MaxStuQty, objCurrEduCls4Synch_Cond.MaxStuQty, strComparisonOp_MaxStuQty);
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.CurrentStuQty) == true)
{
string strComparisonOp_CurrentStuQty = objCurrEduCls4Synch_Cond.dicFldComparisonOp[conCurrEduCls4Synch.CurrentStuQty];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduCls4Synch.CurrentStuQty, objCurrEduCls4Synch_Cond.CurrentStuQty, strComparisonOp_CurrentStuQty);
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.WeekQty) == true)
{
string strComparisonOp_WeekQty = objCurrEduCls4Synch_Cond.dicFldComparisonOp[conCurrEduCls4Synch.WeekQty];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduCls4Synch.WeekQty, objCurrEduCls4Synch_Cond.WeekQty, strComparisonOp_WeekQty);
}
//数据类型short(smallint)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.WeekStatusID) == true)
{
string strComparisonOp_WeekStatusID = objCurrEduCls4Synch_Cond.dicFldComparisonOp[conCurrEduCls4Synch.WeekStatusID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.WeekStatusID, objCurrEduCls4Synch_Cond.WeekStatusID, strComparisonOp_WeekStatusID);
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.CustomerWeek) == true)
{
string strComparisonOp_CustomerWeek = objCurrEduCls4Synch_Cond.dicFldComparisonOp[conCurrEduCls4Synch.CustomerWeek];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.CustomerWeek, objCurrEduCls4Synch_Cond.CustomerWeek, strComparisonOp_CustomerWeek);
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.IsCompleteScore) == true)
{
if (objCurrEduCls4Synch_Cond.IsCompleteScore == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls4Synch.IsCompleteScore);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls4Synch.IsCompleteScore);
}
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.id_ExecPlan) == true)
{
string strComparisonOp_id_ExecPlan = objCurrEduCls4Synch_Cond.dicFldComparisonOp[conCurrEduCls4Synch.id_ExecPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.id_ExecPlan, objCurrEduCls4Synch_Cond.id_ExecPlan, strComparisonOp_id_ExecPlan);
}
//数据类型short(smallint)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.Mark) == true)
{
string strComparisonOp_Mark = objCurrEduCls4Synch_Cond.dicFldComparisonOp[conCurrEduCls4Synch.Mark];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduCls4Synch.Mark, objCurrEduCls4Synch_Cond.Mark, strComparisonOp_Mark);
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.CheckClassRoom) == true)
{
string strComparisonOp_CheckClassRoom = objCurrEduCls4Synch_Cond.dicFldComparisonOp[conCurrEduCls4Synch.CheckClassRoom];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.CheckClassRoom, objCurrEduCls4Synch_Cond.CheckClassRoom, strComparisonOp_CheckClassRoom);
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.CheckAdminCls) == true)
{
string strComparisonOp_CheckAdminCls = objCurrEduCls4Synch_Cond.dicFldComparisonOp[conCurrEduCls4Synch.CheckAdminCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.CheckAdminCls, objCurrEduCls4Synch_Cond.CheckAdminCls, strComparisonOp_CheckAdminCls);
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.CheckTeacher) == true)
{
string strComparisonOp_CheckTeacher = objCurrEduCls4Synch_Cond.dicFldComparisonOp[conCurrEduCls4Synch.CheckTeacher];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.CheckTeacher, objCurrEduCls4Synch_Cond.CheckTeacher, strComparisonOp_CheckTeacher);
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.EditLocked) == true)
{
if (objCurrEduCls4Synch_Cond.EditLocked == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls4Synch.EditLocked);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls4Synch.EditLocked);
}
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.Sched) == true)
{
if (objCurrEduCls4Synch_Cond.Sched == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls4Synch.Sched);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls4Synch.Sched);
}
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.id_UniZone) == true)
{
string strComparisonOp_id_UniZone = objCurrEduCls4Synch_Cond.dicFldComparisonOp[conCurrEduCls4Synch.id_UniZone];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.id_UniZone, objCurrEduCls4Synch_Cond.id_UniZone, strComparisonOp_id_UniZone);
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.Locked) == true)
{
if (objCurrEduCls4Synch_Cond.Locked == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls4Synch.Locked);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls4Synch.Locked);
}
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.id_GradeBase) == true)
{
string strComparisonOp_id_GradeBase = objCurrEduCls4Synch_Cond.dicFldComparisonOp[conCurrEduCls4Synch.id_GradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.id_GradeBase, objCurrEduCls4Synch_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.IsEffective) == true)
{
if (objCurrEduCls4Synch_Cond.IsEffective == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls4Synch.IsEffective);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls4Synch.IsEffective);
}
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.IsUnDeterminedClsRm) == true)
{
if (objCurrEduCls4Synch_Cond.IsUnDeterminedClsRm == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls4Synch.IsUnDeterminedClsRm);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls4Synch.IsUnDeterminedClsRm);
}
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.SchoolYear) == true)
{
string strComparisonOp_SchoolYear = objCurrEduCls4Synch_Cond.dicFldComparisonOp[conCurrEduCls4Synch.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.SchoolYear, objCurrEduCls4Synch_Cond.SchoolYear, strComparisonOp_SchoolYear);
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.SchoolTerm) == true)
{
string strComparisonOp_SchoolTerm = objCurrEduCls4Synch_Cond.dicFldComparisonOp[conCurrEduCls4Synch.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.SchoolTerm, objCurrEduCls4Synch_Cond.SchoolTerm, strComparisonOp_SchoolTerm);
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.ArrangeCourseMemo) == true)
{
string strComparisonOp_ArrangeCourseMemo = objCurrEduCls4Synch_Cond.dicFldComparisonOp[conCurrEduCls4Synch.ArrangeCourseMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.ArrangeCourseMemo, objCurrEduCls4Synch_Cond.ArrangeCourseMemo, strComparisonOp_ArrangeCourseMemo);
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.id_CourseType) == true)
{
string strComparisonOp_id_CourseType = objCurrEduCls4Synch_Cond.dicFldComparisonOp[conCurrEduCls4Synch.id_CourseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.id_CourseType, objCurrEduCls4Synch_Cond.id_CourseType, strComparisonOp_id_CourseType);
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.ExportDate) == true)
{
string strComparisonOp_ExportDate = objCurrEduCls4Synch_Cond.dicFldComparisonOp[conCurrEduCls4Synch.ExportDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.ExportDate, objCurrEduCls4Synch_Cond.ExportDate, strComparisonOp_ExportDate);
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.IsDegree) == true)
{
if (objCurrEduCls4Synch_Cond.IsDegree == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls4Synch.IsDegree);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls4Synch.IsDegree);
}
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.id_ScoreType) == true)
{
string strComparisonOp_id_ScoreType = objCurrEduCls4Synch_Cond.dicFldComparisonOp[conCurrEduCls4Synch.id_ScoreType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.id_ScoreType, objCurrEduCls4Synch_Cond.id_ScoreType, strComparisonOp_id_ScoreType);
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.GetScoreWayId) == true)
{
string strComparisonOp_GetScoreWayId = objCurrEduCls4Synch_Cond.dicFldComparisonOp[conCurrEduCls4Synch.GetScoreWayId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.GetScoreWayId, objCurrEduCls4Synch_Cond.GetScoreWayId, strComparisonOp_GetScoreWayId);
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.IsProportionalCtrl) == true)
{
if (objCurrEduCls4Synch_Cond.IsProportionalCtrl == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls4Synch.IsProportionalCtrl);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls4Synch.IsProportionalCtrl);
}
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.IsSynchToWeb) == true)
{
if (objCurrEduCls4Synch_Cond.IsSynchToWeb == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls4Synch.IsSynchToWeb);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls4Synch.IsSynchToWeb);
}
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.SynchToWebDate) == true)
{
string strComparisonOp_SynchToWebDate = objCurrEduCls4Synch_Cond.dicFldComparisonOp[conCurrEduCls4Synch.SynchToWebDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.SynchToWebDate, objCurrEduCls4Synch_Cond.SynchToWebDate, strComparisonOp_SynchToWebDate);
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.SynchToWebUser) == true)
{
string strComparisonOp_SynchToWebUser = objCurrEduCls4Synch_Cond.dicFldComparisonOp[conCurrEduCls4Synch.SynchToWebUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.SynchToWebUser, objCurrEduCls4Synch_Cond.SynchToWebUser, strComparisonOp_SynchToWebUser);
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.SignInDate) == true)
{
string strComparisonOp_SignInDate = objCurrEduCls4Synch_Cond.dicFldComparisonOp[conCurrEduCls4Synch.SignInDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.SignInDate, objCurrEduCls4Synch_Cond.SignInDate, strComparisonOp_SignInDate);
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.SignInStateID) == true)
{
string strComparisonOp_SignInStateID = objCurrEduCls4Synch_Cond.dicFldComparisonOp[conCurrEduCls4Synch.SignInStateID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.SignInStateID, objCurrEduCls4Synch_Cond.SignInStateID, strComparisonOp_SignInStateID);
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.SignInUser) == true)
{
string strComparisonOp_SignInUser = objCurrEduCls4Synch_Cond.dicFldComparisonOp[conCurrEduCls4Synch.SignInUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.SignInUser, objCurrEduCls4Synch_Cond.SignInUser, strComparisonOp_SignInUser);
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.id_ExamType) == true)
{
string strComparisonOp_id_ExamType = objCurrEduCls4Synch_Cond.dicFldComparisonOp[conCurrEduCls4Synch.id_ExamType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.id_ExamType, objCurrEduCls4Synch_Cond.id_ExamType, strComparisonOp_id_ExamType);
}
//数据类型short(smallint)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
//数据类型short(smallint)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.IsClearScore) == true)
{
if (objCurrEduCls4Synch_Cond.IsClearScore == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls4Synch.IsClearScore);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls4Synch.IsClearScore);
}
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.IsGeneratePwd) == true)
{
if (objCurrEduCls4Synch_Cond.IsGeneratePwd == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls4Synch.IsGeneratePwd);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls4Synch.IsGeneratePwd);
}
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.GeneratePwdDate) == true)
{
string strComparisonOp_GeneratePwdDate = objCurrEduCls4Synch_Cond.dicFldComparisonOp[conCurrEduCls4Synch.GeneratePwdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.GeneratePwdDate, objCurrEduCls4Synch_Cond.GeneratePwdDate, strComparisonOp_GeneratePwdDate);
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.IsExportToGP) == true)
{
if (objCurrEduCls4Synch_Cond.IsExportToGP == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls4Synch.IsExportToGP);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls4Synch.IsExportToGP);
}
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.IsExportToGPWeb) == true)
{
if (objCurrEduCls4Synch_Cond.IsExportToGPWeb == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls4Synch.IsExportToGPWeb);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls4Synch.IsExportToGPWeb);
}
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.IsReservedDecimal) == true)
{
if (objCurrEduCls4Synch_Cond.IsReservedDecimal == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls4Synch.IsReservedDecimal);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls4Synch.IsReservedDecimal);
}
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.ExamTime) == true)
{
string strComparisonOp_ExamTime = objCurrEduCls4Synch_Cond.dicFldComparisonOp[conCurrEduCls4Synch.ExamTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.ExamTime, objCurrEduCls4Synch_Cond.ExamTime, strComparisonOp_ExamTime);
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.CheckState) == true)
{
if (objCurrEduCls4Synch_Cond.CheckState == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls4Synch.CheckState);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls4Synch.CheckState);
}
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.CheckDate) == true)
{
string strComparisonOp_CheckDate = objCurrEduCls4Synch_Cond.dicFldComparisonOp[conCurrEduCls4Synch.CheckDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.CheckDate, objCurrEduCls4Synch_Cond.CheckDate, strComparisonOp_CheckDate);
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.id_EduClassInPk) == true)
{
string strComparisonOp_id_EduClassInPk = objCurrEduCls4Synch_Cond.dicFldComparisonOp[conCurrEduCls4Synch.id_EduClassInPk];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.id_EduClassInPk, objCurrEduCls4Synch_Cond.id_EduClassInPk, strComparisonOp_id_EduClassInPk);
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.PkWeekTime) == true)
{
string strComparisonOp_PkWeekTime = objCurrEduCls4Synch_Cond.dicFldComparisonOp[conCurrEduCls4Synch.PkWeekTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.PkWeekTime, objCurrEduCls4Synch_Cond.PkWeekTime, strComparisonOp_PkWeekTime);
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.PkClassRooms) == true)
{
string strComparisonOp_PkClassRooms = objCurrEduCls4Synch_Cond.dicFldComparisonOp[conCurrEduCls4Synch.PkClassRooms];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.PkClassRooms, objCurrEduCls4Synch_Cond.PkClassRooms, strComparisonOp_PkClassRooms);
}
//数据类型short(smallint)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.TeacherNames) == true)
{
string strComparisonOp_TeacherNames = objCurrEduCls4Synch_Cond.dicFldComparisonOp[conCurrEduCls4Synch.TeacherNames];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.TeacherNames, objCurrEduCls4Synch_Cond.TeacherNames, strComparisonOp_TeacherNames);
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.IsAccessSynch) == true)
{
if (objCurrEduCls4Synch_Cond.IsAccessSynch == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls4Synch.IsAccessSynch);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls4Synch.IsAccessSynch);
}
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.AccessSynchDate) == true)
{
string strComparisonOp_AccessSynchDate = objCurrEduCls4Synch_Cond.dicFldComparisonOp[conCurrEduCls4Synch.AccessSynchDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.AccessSynchDate, objCurrEduCls4Synch_Cond.AccessSynchDate, strComparisonOp_AccessSynchDate);
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.IsExistEduClsInCurr) == true)
{
if (objCurrEduCls4Synch_Cond.IsExistEduClsInCurr == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls4Synch.IsExistEduClsInCurr);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls4Synch.IsExistEduClsInCurr);
}
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.ModifyDate) == true)
{
string strComparisonOp_ModifyDate = objCurrEduCls4Synch_Cond.dicFldComparisonOp[conCurrEduCls4Synch.ModifyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.ModifyDate, objCurrEduCls4Synch_Cond.ModifyDate, strComparisonOp_ModifyDate);
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.ModifyUserID) == true)
{
string strComparisonOp_ModifyUserID = objCurrEduCls4Synch_Cond.dicFldComparisonOp[conCurrEduCls4Synch.ModifyUserID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.ModifyUserID, objCurrEduCls4Synch_Cond.ModifyUserID, strComparisonOp_ModifyUserID);
}
if (objCurrEduCls4Synch_Cond.IsUpdated(conCurrEduCls4Synch.Memo) == true)
{
string strComparisonOp_Memo = objCurrEduCls4Synch_Cond.dicFldComparisonOp[conCurrEduCls4Synch.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls4Synch.Memo, objCurrEduCls4Synch_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN)
{
 if (objCurrEduCls4SynchEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objCurrEduCls4SynchEN.sf_UpdFldSetStr = objCurrEduCls4SynchEN.getsf_UpdFldSetStr();
clsCurrEduCls4SynchWApi.CheckPropertyNew(objCurrEduCls4SynchEN); 
bool bolResult = clsCurrEduCls4SynchWApi.UpdateRecord(objCurrEduCls4SynchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduCls4SynchWApi.ReFreshCache();
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
 /// 检查唯一性(Uniqueness)--CurrEduCls4Synch(当前教学班_同步), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_id_CurrEduCls_IpAddress(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCurrEduCls4SynchEN == null) return "";
if (objCurrEduCls4SynchEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and id_CurrEduCls = '{0}'", objCurrEduCls4SynchEN.id_CurrEduCls);
 sbCondition.AppendFormat(" and IpAddress = '{0}'", objCurrEduCls4SynchEN.IpAddress);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objCurrEduCls4SynchEN.mId);
 sbCondition.AppendFormat(" and id_CurrEduCls = '{0}'", objCurrEduCls4SynchEN.id_CurrEduCls);
 sbCondition.AppendFormat(" and IpAddress = '{0}'", objCurrEduCls4SynchEN.IpAddress);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCurrEduCls4SynchEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN)
{
try
{
clsCurrEduCls4SynchWApi.CheckPropertyNew(objCurrEduCls4SynchEN); 
bool bolResult = clsCurrEduCls4SynchWApi.AddNewRecord(objCurrEduCls4SynchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduCls4SynchWApi.ReFreshCache();
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
 /// <param name = "objCurrEduCls4SynchEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strWhereCond)
{
try
{
clsCurrEduCls4SynchWApi.CheckPropertyNew(objCurrEduCls4SynchEN); 
bool bolResult = clsCurrEduCls4SynchWApi.UpdateWithCondition(objCurrEduCls4SynchEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduCls4SynchWApi.ReFreshCache();
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
 /// 当前教学班_同步(CurrEduCls4Synch)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsCurrEduCls4SynchWApi
{
private static readonly string mstrApiControllerName = "CurrEduCls4SynchApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsCurrEduCls4SynchWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_mId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[当前教学班_同步]...","0");
List<clsCurrEduCls4SynchEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="mId";
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
public static void BindCbo_mId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conCurrEduCls4Synch.mId); 
List<clsCurrEduCls4SynchEN> arrObjLst = clsCurrEduCls4SynchWApi.GetObjLst(strCondition);
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
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsCurrEduCls4SynchEN objCurrEduCls4SynchEN)
{
if (!Object.Equals(null, objCurrEduCls4SynchEN.IpAddress) && GetStrLen(objCurrEduCls4SynchEN.IpAddress) > 50)
{
 throw new Exception("字段[Ip地址]的长度不能超过50!");
}
if (!Object.Equals(null, objCurrEduCls4SynchEN.id_CurrEduCls) && GetStrLen(objCurrEduCls4SynchEN.id_CurrEduCls) > 8)
{
 throw new Exception("字段[当前教学班流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objCurrEduCls4SynchEN.CurrEduClsId) && GetStrLen(objCurrEduCls4SynchEN.CurrEduClsId) > 15)
{
 throw new Exception("字段[当前教学班Id]的长度不能超过15!");
}
if (!Object.Equals(null, objCurrEduCls4SynchEN.EduClsName) && GetStrLen(objCurrEduCls4SynchEN.EduClsName) > 100)
{
 throw new Exception("字段[教学班名称]的长度不能超过100!");
}
if (!Object.Equals(null, objCurrEduCls4SynchEN.EduClsTypeId) && GetStrLen(objCurrEduCls4SynchEN.EduClsTypeId) > 4)
{
 throw new Exception("字段[教学班类型代号]的长度不能超过4!");
}
if (!Object.Equals(null, objCurrEduCls4SynchEN.CourseId) && GetStrLen(objCurrEduCls4SynchEN.CourseId) > 8)
{
 throw new Exception("字段[课程Id]的长度不能超过8!");
}
if (!Object.Equals(null, objCurrEduCls4SynchEN.TeachingSolutionId) && GetStrLen(objCurrEduCls4SynchEN.TeachingSolutionId) > 8)
{
 throw new Exception("字段[教学方案Id]的长度不能超过8!");
}
if (!Object.Equals(null, objCurrEduCls4SynchEN.id_XzCollege) && GetStrLen(objCurrEduCls4SynchEN.id_XzCollege) > 4)
{
 throw new Exception("字段[学院流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objCurrEduCls4SynchEN.id_EduWay) && GetStrLen(objCurrEduCls4SynchEN.id_EduWay) > 4)
{
 throw new Exception("字段[教学方式流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objCurrEduCls4SynchEN.id_ClassRoomType) && GetStrLen(objCurrEduCls4SynchEN.id_ClassRoomType) > 4)
{
 throw new Exception("字段[教室类型流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objCurrEduCls4SynchEN.WeekStatusID) && GetStrLen(objCurrEduCls4SynchEN.WeekStatusID) > 2)
{
 throw new Exception("字段[周状态编号(单,双,全周)]的长度不能超过2!");
}
if (!Object.Equals(null, objCurrEduCls4SynchEN.CustomerWeek) && GetStrLen(objCurrEduCls4SynchEN.CustomerWeek) > 50)
{
 throw new Exception("字段[自定义上课周]的长度不能超过50!");
}
if (!Object.Equals(null, objCurrEduCls4SynchEN.id_ExecPlan) && GetStrLen(objCurrEduCls4SynchEN.id_ExecPlan) > 8)
{
 throw new Exception("字段[执行计划流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objCurrEduCls4SynchEN.CheckClassRoom) && GetStrLen(objCurrEduCls4SynchEN.CheckClassRoom) > 2000)
{
 throw new Exception("字段[检查教室结果]的长度不能超过2000!");
}
if (!Object.Equals(null, objCurrEduCls4SynchEN.CheckAdminCls) && GetStrLen(objCurrEduCls4SynchEN.CheckAdminCls) > 2000)
{
 throw new Exception("字段[检查行政班结果]的长度不能超过2000!");
}
if (!Object.Equals(null, objCurrEduCls4SynchEN.CheckTeacher) && GetStrLen(objCurrEduCls4SynchEN.CheckTeacher) > 2000)
{
 throw new Exception("字段[检查教师结果]的长度不能超过2000!");
}
if (!Object.Equals(null, objCurrEduCls4SynchEN.id_UniZone) && GetStrLen(objCurrEduCls4SynchEN.id_UniZone) > 4)
{
 throw new Exception("字段[校区流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objCurrEduCls4SynchEN.id_GradeBase) && GetStrLen(objCurrEduCls4SynchEN.id_GradeBase) > 4)
{
 throw new Exception("字段[年级流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objCurrEduCls4SynchEN.SchoolYear) && GetStrLen(objCurrEduCls4SynchEN.SchoolYear) > 10)
{
 throw new Exception("字段[学年]的长度不能超过10!");
}
if (!Object.Equals(null, objCurrEduCls4SynchEN.SchoolTerm) && GetStrLen(objCurrEduCls4SynchEN.SchoolTerm) > 1)
{
 throw new Exception("字段[学期]的长度不能超过1!");
}
if (!Object.Equals(null, objCurrEduCls4SynchEN.ArrangeCourseMemo) && GetStrLen(objCurrEduCls4SynchEN.ArrangeCourseMemo) > 50)
{
 throw new Exception("字段[排课备注]的长度不能超过50!");
}
if (!Object.Equals(null, objCurrEduCls4SynchEN.id_CourseType) && GetStrLen(objCurrEduCls4SynchEN.id_CourseType) > 4)
{
 throw new Exception("字段[课程类型流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objCurrEduCls4SynchEN.ExportDate) && GetStrLen(objCurrEduCls4SynchEN.ExportDate) > 8)
{
 throw new Exception("字段[导出日期]的长度不能超过8!");
}
if (!Object.Equals(null, objCurrEduCls4SynchEN.id_ScoreType) && GetStrLen(objCurrEduCls4SynchEN.id_ScoreType) > 4)
{
 throw new Exception("字段[成绩类型流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objCurrEduCls4SynchEN.GetScoreWayId) && GetStrLen(objCurrEduCls4SynchEN.GetScoreWayId) > 2)
{
 throw new Exception("字段[获得成绩方式Id]的长度不能超过2!");
}
if (!Object.Equals(null, objCurrEduCls4SynchEN.SynchToWebDate) && GetStrLen(objCurrEduCls4SynchEN.SynchToWebDate) > 20)
{
 throw new Exception("字段[同步Web日期]的长度不能超过20!");
}
if (!Object.Equals(null, objCurrEduCls4SynchEN.SynchToWebUser) && GetStrLen(objCurrEduCls4SynchEN.SynchToWebUser) > 18)
{
 throw new Exception("字段[同步Web用户]的长度不能超过18!");
}
if (!Object.Equals(null, objCurrEduCls4SynchEN.SignInDate) && GetStrLen(objCurrEduCls4SynchEN.SignInDate) > 20)
{
 throw new Exception("字段[签入时间]的长度不能超过20!");
}
if (!Object.Equals(null, objCurrEduCls4SynchEN.SignInStateID) && GetStrLen(objCurrEduCls4SynchEN.SignInStateID) > 2)
{
 throw new Exception("字段[签入状态表流水号]的长度不能超过2!");
}
if (!Object.Equals(null, objCurrEduCls4SynchEN.SignInUser) && GetStrLen(objCurrEduCls4SynchEN.SignInUser) > 18)
{
 throw new Exception("字段[签入人]的长度不能超过18!");
}
if (!Object.Equals(null, objCurrEduCls4SynchEN.id_ExamType) && GetStrLen(objCurrEduCls4SynchEN.id_ExamType) > 4)
{
 throw new Exception("字段[考试方式流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objCurrEduCls4SynchEN.GeneratePwdDate) && GetStrLen(objCurrEduCls4SynchEN.GeneratePwdDate) > 20)
{
 throw new Exception("字段[生成口令时间]的长度不能超过20!");
}
if (!Object.Equals(null, objCurrEduCls4SynchEN.ExamTime) && GetStrLen(objCurrEduCls4SynchEN.ExamTime) > 8)
{
 throw new Exception("字段[考试时间]的长度不能超过8!");
}
if (!Object.Equals(null, objCurrEduCls4SynchEN.CheckDate) && GetStrLen(objCurrEduCls4SynchEN.CheckDate) > 20)
{
 throw new Exception("字段[检查日期]的长度不能超过20!");
}
if (!Object.Equals(null, objCurrEduCls4SynchEN.id_EduClassInPk) && GetStrLen(objCurrEduCls4SynchEN.id_EduClassInPk) > 8)
{
 throw new Exception("字段[id_EduClassInPk]的长度不能超过8!");
}
if (!Object.Equals(null, objCurrEduCls4SynchEN.PkWeekTime) && GetStrLen(objCurrEduCls4SynchEN.PkWeekTime) > 2000)
{
 throw new Exception("字段[排课时间]的长度不能超过2000!");
}
if (!Object.Equals(null, objCurrEduCls4SynchEN.PkClassRooms) && GetStrLen(objCurrEduCls4SynchEN.PkClassRooms) > 150)
{
 throw new Exception("字段[排课教室]的长度不能超过150!");
}
if (!Object.Equals(null, objCurrEduCls4SynchEN.TeacherNames) && GetStrLen(objCurrEduCls4SynchEN.TeacherNames) > 100)
{
 throw new Exception("字段[教师姓名]的长度不能超过100!");
}
if (!Object.Equals(null, objCurrEduCls4SynchEN.AccessSynchDate) && GetStrLen(objCurrEduCls4SynchEN.AccessSynchDate) > 14)
{
 throw new Exception("字段[处理同步日期]的长度不能超过14!");
}
if (!Object.Equals(null, objCurrEduCls4SynchEN.ModifyDate) && GetStrLen(objCurrEduCls4SynchEN.ModifyDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objCurrEduCls4SynchEN.ModifyUserID) && GetStrLen(objCurrEduCls4SynchEN.ModifyUserID) > 18)
{
 throw new Exception("字段[修改人]的长度不能超过18!");
}
if (!Object.Equals(null, objCurrEduCls4SynchEN.Memo) && GetStrLen(objCurrEduCls4SynchEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objCurrEduCls4SynchEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCurrEduCls4SynchEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clsCurrEduCls4SynchEN objCurrEduCls4SynchEN = null;
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
objCurrEduCls4SynchEN = JsonConvert.DeserializeObject<clsCurrEduCls4SynchEN>((string)jobjReturn["ReturnObj"]);
return objCurrEduCls4SynchEN;
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
public static clsCurrEduCls4SynchEN GetObjBymId_WA_Cache(long lngmId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsCurrEduCls4SynchEN objCurrEduCls4SynchEN = null;
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
objCurrEduCls4SynchEN = JsonConvert.DeserializeObject<clsCurrEduCls4SynchEN>((string)jobjReturn["ReturnObj"]);
return objCurrEduCls4SynchEN;
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
public static clsCurrEduCls4SynchEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsCurrEduCls4SynchEN objCurrEduCls4SynchEN = null;
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
objCurrEduCls4SynchEN = JsonConvert.DeserializeObject<clsCurrEduCls4SynchEN>((string)jobjReturn["ReturnObj"]);
return objCurrEduCls4SynchEN;
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
public static clsCurrEduCls4SynchEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsCurrEduCls4SynchEN._CurrTabName_S);
List<clsCurrEduCls4SynchEN> arrCurrEduCls4SynchObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsCurrEduCls4SynchEN> arrCurrEduCls4SynchObjLst_Sel =
from objCurrEduCls4SynchEN in arrCurrEduCls4SynchObjLst_Cache
where objCurrEduCls4SynchEN.mId == lngmId
select objCurrEduCls4SynchEN;
if (arrCurrEduCls4SynchObjLst_Sel.Count() == 0)
{
   clsCurrEduCls4SynchEN obj = clsCurrEduCls4SynchWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrCurrEduCls4SynchObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetEduClsNameBymId_Cache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsCurrEduCls4SynchEN._CurrTabName_S);
List<clsCurrEduCls4SynchEN> arrCurrEduCls4SynchObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsCurrEduCls4SynchEN> arrCurrEduCls4SynchObjLst_Sel1 =
from objCurrEduCls4SynchEN in arrCurrEduCls4SynchObjLst_Cache
where objCurrEduCls4SynchEN.mId == lngmId
select objCurrEduCls4SynchEN;
List <clsCurrEduCls4SynchEN> arrCurrEduCls4SynchObjLst_Sel = new List<clsCurrEduCls4SynchEN>();
foreach (clsCurrEduCls4SynchEN obj in arrCurrEduCls4SynchObjLst_Sel1)
{
arrCurrEduCls4SynchObjLst_Sel.Add(obj);
}
if (arrCurrEduCls4SynchObjLst_Sel.Count > 0)
{
return arrCurrEduCls4SynchObjLst_Sel[0].EduClsName;
}
string strErrMsgForGetObjById = string.Format("在CurrEduCls4Synch对象缓存列表中,找不到记录[mId = {0}](函数:{1})", lngmId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsCurrEduCls4SynchBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameBymId_Cache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsCurrEduCls4SynchEN._CurrTabName_S);
List<clsCurrEduCls4SynchEN> arrCurrEduCls4SynchObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsCurrEduCls4SynchEN> arrCurrEduCls4SynchObjLst_Sel1 =
from objCurrEduCls4SynchEN in arrCurrEduCls4SynchObjLst_Cache
where objCurrEduCls4SynchEN.mId == lngmId
select objCurrEduCls4SynchEN;
List <clsCurrEduCls4SynchEN> arrCurrEduCls4SynchObjLst_Sel = new List<clsCurrEduCls4SynchEN>();
foreach (clsCurrEduCls4SynchEN obj in arrCurrEduCls4SynchObjLst_Sel1)
{
arrCurrEduCls4SynchObjLst_Sel.Add(obj);
}
if (arrCurrEduCls4SynchObjLst_Sel.Count > 0)
{
return arrCurrEduCls4SynchObjLst_Sel[0].EduClsName;
}
string strErrMsgForGetObjById = string.Format("在CurrEduCls4Synch对象缓存列表中,找不到记录的相关名称[mId = {0}](函数:{1})", lngmId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsCurrEduCls4SynchBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCurrEduCls4SynchEN> GetObjLst(string strWhereCond)
{
 List<clsCurrEduCls4SynchEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCurrEduCls4SynchEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCurrEduCls4SynchEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsCurrEduCls4SynchEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCurrEduCls4SynchEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsCurrEduCls4SynchEN> GetObjLstByMIdLst_Cache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsCurrEduCls4SynchEN._CurrTabName_S);
List<clsCurrEduCls4SynchEN> arrCurrEduCls4SynchObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsCurrEduCls4SynchEN> arrCurrEduCls4SynchObjLst_Sel =
from objCurrEduCls4SynchEN in arrCurrEduCls4SynchObjLst_Cache
where arrMId.Contains(objCurrEduCls4SynchEN.mId)
select objCurrEduCls4SynchEN;
return arrCurrEduCls4SynchObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCurrEduCls4SynchEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId)
{
 List<clsCurrEduCls4SynchEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCurrEduCls4SynchEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCurrEduCls4SynchEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsCurrEduCls4SynchEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCurrEduCls4SynchEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCurrEduCls4SynchEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsCurrEduCls4SynchEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCurrEduCls4SynchEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCurrEduCls4SynchEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsCurrEduCls4SynchEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCurrEduCls4SynchEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCurrEduCls4SynchEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsCurrEduCls4SynchEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCurrEduCls4SynchEN>>((string)jobjReturn["ReturnObjLst"]);
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
 clsCurrEduCls4SynchEN objCurrEduCls4SynchEN = clsCurrEduCls4SynchWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsCurrEduCls4SynchWApi.ReFreshCache();
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
public static int DelCurrEduCls4Synchs(List<string> arrmId)
{
string strAction = "DelCurrEduCls4Synchs";
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
clsCurrEduCls4SynchWApi.ReFreshCache();
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
public static int DelCurrEduCls4SynchsByCond(string strWhereCond)
{
string strAction = "DelCurrEduCls4SynchsByCond";
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
public static bool AddNewRecord(clsCurrEduCls4SynchEN objCurrEduCls4SynchEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCurrEduCls4SynchEN>(objCurrEduCls4SynchEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduCls4SynchWApi.ReFreshCache();
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
 /// <param name = "objCurrEduCls4SynchEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsCurrEduCls4SynchEN objCurrEduCls4SynchEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCurrEduCls4SynchEN>(objCurrEduCls4SynchEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduCls4SynchWApi.ReFreshCache();
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
public static bool UpdateRecord(clsCurrEduCls4SynchEN objCurrEduCls4SynchEN)
{
if (string.IsNullOrEmpty(objCurrEduCls4SynchEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCurrEduCls4SynchEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCurrEduCls4SynchEN>(objCurrEduCls4SynchEN);
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
 /// <param name = "objCurrEduCls4SynchEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsCurrEduCls4SynchEN objCurrEduCls4SynchEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objCurrEduCls4SynchEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCurrEduCls4SynchEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCurrEduCls4SynchEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCurrEduCls4SynchEN>(objCurrEduCls4SynchEN);
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
 /// <param name = "objCurrEduCls4SynchENS">源对象</param>
 /// <param name = "objCurrEduCls4SynchENT">目标对象</param>
 public static void CopyTo(clsCurrEduCls4SynchEN objCurrEduCls4SynchENS, clsCurrEduCls4SynchEN objCurrEduCls4SynchENT)
{
try
{
objCurrEduCls4SynchENT.mId = objCurrEduCls4SynchENS.mId; //mId
objCurrEduCls4SynchENT.IpAddress = objCurrEduCls4SynchENS.IpAddress; //Ip地址
objCurrEduCls4SynchENT.id_CurrEduCls = objCurrEduCls4SynchENS.id_CurrEduCls; //当前教学班流水号
objCurrEduCls4SynchENT.CurrEduClsId = objCurrEduCls4SynchENS.CurrEduClsId; //当前教学班Id
objCurrEduCls4SynchENT.EduClsName = objCurrEduCls4SynchENS.EduClsName; //教学班名称
objCurrEduCls4SynchENT.EduClsTypeId = objCurrEduCls4SynchENS.EduClsTypeId; //教学班类型代号
objCurrEduCls4SynchENT.CourseId = objCurrEduCls4SynchENS.CourseId; //课程Id
objCurrEduCls4SynchENT.TeachingSolutionId = objCurrEduCls4SynchENS.TeachingSolutionId; //教学方案Id
objCurrEduCls4SynchENT.id_XzCollege = objCurrEduCls4SynchENS.id_XzCollege; //学院流水号
objCurrEduCls4SynchENT.id_EduWay = objCurrEduCls4SynchENS.id_EduWay; //教学方式流水号
objCurrEduCls4SynchENT.id_ClassRoomType = objCurrEduCls4SynchENS.id_ClassRoomType; //教室类型流水号
objCurrEduCls4SynchENT.TotalLessonQty = objCurrEduCls4SynchENS.TotalLessonQty; //总课时数
objCurrEduCls4SynchENT.MaxStuQty = objCurrEduCls4SynchENS.MaxStuQty; //最大学生数
objCurrEduCls4SynchENT.CurrentStuQty = objCurrEduCls4SynchENS.CurrentStuQty; //当前学生数
objCurrEduCls4SynchENT.WeekQty = objCurrEduCls4SynchENS.WeekQty; //总周数
objCurrEduCls4SynchENT.ScheUnitPW = objCurrEduCls4SynchENS.ScheUnitPW; //周排课次数
objCurrEduCls4SynchENT.WeekStatusID = objCurrEduCls4SynchENS.WeekStatusID; //周状态编号(单,双,全周)
objCurrEduCls4SynchENT.CustomerWeek = objCurrEduCls4SynchENS.CustomerWeek; //自定义上课周
objCurrEduCls4SynchENT.IsCompleteScore = objCurrEduCls4SynchENS.IsCompleteScore; //是否成绩齐全
objCurrEduCls4SynchENT.id_ExecPlan = objCurrEduCls4SynchENS.id_ExecPlan; //执行计划流水号
objCurrEduCls4SynchENT.LessonQtyPerWeek = objCurrEduCls4SynchENS.LessonQtyPerWeek; //周课时数
objCurrEduCls4SynchENT.Mark = objCurrEduCls4SynchENS.Mark; //获得学分
objCurrEduCls4SynchENT.CheckClassRoom = objCurrEduCls4SynchENS.CheckClassRoom; //检查教室结果
objCurrEduCls4SynchENT.CheckAdminCls = objCurrEduCls4SynchENS.CheckAdminCls; //检查行政班结果
objCurrEduCls4SynchENT.CheckTeacher = objCurrEduCls4SynchENS.CheckTeacher; //检查教师结果
objCurrEduCls4SynchENT.EditLocked = objCurrEduCls4SynchENS.EditLocked; //编辑锁定
objCurrEduCls4SynchENT.Sched = objCurrEduCls4SynchENS.Sched; //是否排课
objCurrEduCls4SynchENT.id_UniZone = objCurrEduCls4SynchENS.id_UniZone; //校区流水号
objCurrEduCls4SynchENT.Locked = objCurrEduCls4SynchENS.Locked; //锁定状态
objCurrEduCls4SynchENT.id_GradeBase = objCurrEduCls4SynchENS.id_GradeBase; //年级流水号
objCurrEduCls4SynchENT.IsEffective = objCurrEduCls4SynchENS.IsEffective; //是否有效
objCurrEduCls4SynchENT.IsUnDeterminedClsRm = objCurrEduCls4SynchENS.IsUnDeterminedClsRm; //是否待定教室
objCurrEduCls4SynchENT.SchoolYear = objCurrEduCls4SynchENS.SchoolYear; //学年
objCurrEduCls4SynchENT.SchoolTerm = objCurrEduCls4SynchENS.SchoolTerm; //学期
objCurrEduCls4SynchENT.ArrangeCourseMemo = objCurrEduCls4SynchENS.ArrangeCourseMemo; //排课备注
objCurrEduCls4SynchENT.id_CourseType = objCurrEduCls4SynchENS.id_CourseType; //课程类型流水号
objCurrEduCls4SynchENT.ExportDate = objCurrEduCls4SynchENS.ExportDate; //导出日期
objCurrEduCls4SynchENT.IsDegree = objCurrEduCls4SynchENS.IsDegree; //是否学位课
objCurrEduCls4SynchENT.id_ScoreType = objCurrEduCls4SynchENS.id_ScoreType; //成绩类型流水号
objCurrEduCls4SynchENT.GetScoreWayId = objCurrEduCls4SynchENS.GetScoreWayId; //获得成绩方式Id
objCurrEduCls4SynchENT.IsProportionalCtrl = objCurrEduCls4SynchENS.IsProportionalCtrl; //是否比例控制
objCurrEduCls4SynchENT.IsSynchToWeb = objCurrEduCls4SynchENS.IsSynchToWeb; //是否同步Web
objCurrEduCls4SynchENT.SynchToWebDate = objCurrEduCls4SynchENS.SynchToWebDate; //同步Web日期
objCurrEduCls4SynchENT.SynchToWebUser = objCurrEduCls4SynchENS.SynchToWebUser; //同步Web用户
objCurrEduCls4SynchENT.SignInDate = objCurrEduCls4SynchENS.SignInDate; //签入时间
objCurrEduCls4SynchENT.SignInStateID = objCurrEduCls4SynchENS.SignInStateID; //签入状态表流水号
objCurrEduCls4SynchENT.SignInUser = objCurrEduCls4SynchENS.SignInUser; //签入人
objCurrEduCls4SynchENT.id_ExamType = objCurrEduCls4SynchENS.id_ExamType; //考试方式流水号
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
objCurrEduCls4SynchENT.id_EduClassInPk = objCurrEduCls4SynchENS.id_EduClassInPk; //id_EduClassInPk
objCurrEduCls4SynchENT.PkWeekTime = objCurrEduCls4SynchENS.PkWeekTime; //排课时间
objCurrEduCls4SynchENT.PkClassRooms = objCurrEduCls4SynchENS.PkClassRooms; //排课教室
objCurrEduCls4SynchENT.BeginWeek = objCurrEduCls4SynchENS.BeginWeek; //开始周
objCurrEduCls4SynchENT.TeacherNames = objCurrEduCls4SynchENS.TeacherNames; //教师姓名
objCurrEduCls4SynchENT.IsAccessSynch = objCurrEduCls4SynchENS.IsAccessSynch; //是否处理同步
objCurrEduCls4SynchENT.AccessSynchDate = objCurrEduCls4SynchENS.AccessSynchDate; //处理同步日期
objCurrEduCls4SynchENT.IsExistEduClsInCurr = objCurrEduCls4SynchENS.IsExistEduClsInCurr; //当前是否存在教学班
objCurrEduCls4SynchENT.ModifyDate = objCurrEduCls4SynchENS.ModifyDate; //修改日期
objCurrEduCls4SynchENT.ModifyUserID = objCurrEduCls4SynchENS.ModifyUserID; //修改人
objCurrEduCls4SynchENT.Memo = objCurrEduCls4SynchENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsCurrEduCls4SynchEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsCurrEduCls4SynchEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsCurrEduCls4SynchEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsCurrEduCls4SynchEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsCurrEduCls4SynchEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsCurrEduCls4SynchEN.AttributeName)
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
if (clsCurrEduCls4SynchWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCurrEduCls4SynchWApi没有刷新缓存机制(clsCurrEduCls4SynchWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrCurrEduCls4SynchObjLst_Cache == null)
//{
//arrCurrEduCls4SynchObjLst_Cache = await clsCurrEduCls4SynchWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsCurrEduCls4SynchEN._CurrTabName_S);
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
if (clsCurrEduCls4SynchWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCurrEduCls4SynchEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsCurrEduCls4SynchWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCurrEduCls4SynchEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsCurrEduCls4SynchEN._CurrTabName_S);
List<clsCurrEduCls4SynchEN> arrCurrEduCls4SynchObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrCurrEduCls4SynchObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsCurrEduCls4SynchEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conCurrEduCls4Synch.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(conCurrEduCls4Synch.IpAddress, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls4Synch.id_CurrEduCls, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls4Synch.CurrEduClsId, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls4Synch.EduClsName, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls4Synch.EduClsTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls4Synch.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls4Synch.TeachingSolutionId, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls4Synch.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls4Synch.id_EduWay, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls4Synch.id_ClassRoomType, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls4Synch.TotalLessonQty, Type.GetType("System.Int32"));
objDT.Columns.Add(conCurrEduCls4Synch.MaxStuQty, Type.GetType("System.Int32"));
objDT.Columns.Add(conCurrEduCls4Synch.CurrentStuQty, Type.GetType("System.Int32"));
objDT.Columns.Add(conCurrEduCls4Synch.WeekQty, Type.GetType("System.Int32"));
objDT.Columns.Add(conCurrEduCls4Synch.ScheUnitPW, Type.GetType("System.Int16"));
objDT.Columns.Add(conCurrEduCls4Synch.WeekStatusID, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls4Synch.CustomerWeek, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls4Synch.IsCompleteScore, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCurrEduCls4Synch.id_ExecPlan, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls4Synch.LessonQtyPerWeek, Type.GetType("System.Int16"));
objDT.Columns.Add(conCurrEduCls4Synch.Mark, Type.GetType("System.Decimal"));
objDT.Columns.Add(conCurrEduCls4Synch.CheckClassRoom, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls4Synch.CheckAdminCls, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls4Synch.CheckTeacher, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls4Synch.EditLocked, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCurrEduCls4Synch.Sched, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCurrEduCls4Synch.id_UniZone, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls4Synch.Locked, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCurrEduCls4Synch.id_GradeBase, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls4Synch.IsEffective, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCurrEduCls4Synch.IsUnDeterminedClsRm, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCurrEduCls4Synch.SchoolYear, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls4Synch.SchoolTerm, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls4Synch.ArrangeCourseMemo, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls4Synch.id_CourseType, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls4Synch.ExportDate, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls4Synch.IsDegree, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCurrEduCls4Synch.id_ScoreType, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls4Synch.GetScoreWayId, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls4Synch.IsProportionalCtrl, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCurrEduCls4Synch.IsSynchToWeb, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCurrEduCls4Synch.SynchToWebDate, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls4Synch.SynchToWebUser, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls4Synch.SignInDate, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls4Synch.SignInStateID, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls4Synch.SignInUser, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls4Synch.id_ExamType, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls4Synch.ExamPortion, Type.GetType("System.Int16"));
objDT.Columns.Add(conCurrEduCls4Synch.MidExamScorePortion, Type.GetType("System.Int16"));
objDT.Columns.Add(conCurrEduCls4Synch.IsClearScore, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCurrEduCls4Synch.IsGeneratePwd, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCurrEduCls4Synch.GeneratePwdDate, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls4Synch.IsExportToGP, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCurrEduCls4Synch.IsExportToGPWeb, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCurrEduCls4Synch.IsReservedDecimal, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCurrEduCls4Synch.ExamTime, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls4Synch.CheckState, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCurrEduCls4Synch.CheckDate, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls4Synch.id_EduClassInPk, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls4Synch.PkWeekTime, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls4Synch.PkClassRooms, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls4Synch.BeginWeek, Type.GetType("System.Int16"));
objDT.Columns.Add(conCurrEduCls4Synch.TeacherNames, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls4Synch.IsAccessSynch, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCurrEduCls4Synch.AccessSynchDate, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls4Synch.IsExistEduClsInCurr, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCurrEduCls4Synch.ModifyDate, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls4Synch.ModifyUserID, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduCls4Synch.Memo, Type.GetType("System.String"));
foreach (clsCurrEduCls4SynchEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conCurrEduCls4Synch.mId] = objInFor[conCurrEduCls4Synch.mId];
objDR[conCurrEduCls4Synch.IpAddress] = objInFor[conCurrEduCls4Synch.IpAddress];
objDR[conCurrEduCls4Synch.id_CurrEduCls] = objInFor[conCurrEduCls4Synch.id_CurrEduCls];
objDR[conCurrEduCls4Synch.CurrEduClsId] = objInFor[conCurrEduCls4Synch.CurrEduClsId];
objDR[conCurrEduCls4Synch.EduClsName] = objInFor[conCurrEduCls4Synch.EduClsName];
objDR[conCurrEduCls4Synch.EduClsTypeId] = objInFor[conCurrEduCls4Synch.EduClsTypeId];
objDR[conCurrEduCls4Synch.CourseId] = objInFor[conCurrEduCls4Synch.CourseId];
objDR[conCurrEduCls4Synch.TeachingSolutionId] = objInFor[conCurrEduCls4Synch.TeachingSolutionId];
objDR[conCurrEduCls4Synch.id_XzCollege] = objInFor[conCurrEduCls4Synch.id_XzCollege];
objDR[conCurrEduCls4Synch.id_EduWay] = objInFor[conCurrEduCls4Synch.id_EduWay];
objDR[conCurrEduCls4Synch.id_ClassRoomType] = objInFor[conCurrEduCls4Synch.id_ClassRoomType];
objDR[conCurrEduCls4Synch.TotalLessonQty] = objInFor[conCurrEduCls4Synch.TotalLessonQty];
objDR[conCurrEduCls4Synch.MaxStuQty] = objInFor[conCurrEduCls4Synch.MaxStuQty];
objDR[conCurrEduCls4Synch.CurrentStuQty] = objInFor[conCurrEduCls4Synch.CurrentStuQty];
objDR[conCurrEduCls4Synch.WeekQty] = objInFor[conCurrEduCls4Synch.WeekQty];
objDR[conCurrEduCls4Synch.ScheUnitPW] = objInFor[conCurrEduCls4Synch.ScheUnitPW];
objDR[conCurrEduCls4Synch.WeekStatusID] = objInFor[conCurrEduCls4Synch.WeekStatusID];
objDR[conCurrEduCls4Synch.CustomerWeek] = objInFor[conCurrEduCls4Synch.CustomerWeek];
objDR[conCurrEduCls4Synch.IsCompleteScore] = objInFor[conCurrEduCls4Synch.IsCompleteScore];
objDR[conCurrEduCls4Synch.id_ExecPlan] = objInFor[conCurrEduCls4Synch.id_ExecPlan];
objDR[conCurrEduCls4Synch.LessonQtyPerWeek] = objInFor[conCurrEduCls4Synch.LessonQtyPerWeek];
objDR[conCurrEduCls4Synch.Mark] = objInFor[conCurrEduCls4Synch.Mark];
objDR[conCurrEduCls4Synch.CheckClassRoom] = objInFor[conCurrEduCls4Synch.CheckClassRoom];
objDR[conCurrEduCls4Synch.CheckAdminCls] = objInFor[conCurrEduCls4Synch.CheckAdminCls];
objDR[conCurrEduCls4Synch.CheckTeacher] = objInFor[conCurrEduCls4Synch.CheckTeacher];
objDR[conCurrEduCls4Synch.EditLocked] = objInFor[conCurrEduCls4Synch.EditLocked];
objDR[conCurrEduCls4Synch.Sched] = objInFor[conCurrEduCls4Synch.Sched];
objDR[conCurrEduCls4Synch.id_UniZone] = objInFor[conCurrEduCls4Synch.id_UniZone];
objDR[conCurrEduCls4Synch.Locked] = objInFor[conCurrEduCls4Synch.Locked];
objDR[conCurrEduCls4Synch.id_GradeBase] = objInFor[conCurrEduCls4Synch.id_GradeBase];
objDR[conCurrEduCls4Synch.IsEffective] = objInFor[conCurrEduCls4Synch.IsEffective];
objDR[conCurrEduCls4Synch.IsUnDeterminedClsRm] = objInFor[conCurrEduCls4Synch.IsUnDeterminedClsRm];
objDR[conCurrEduCls4Synch.SchoolYear] = objInFor[conCurrEduCls4Synch.SchoolYear];
objDR[conCurrEduCls4Synch.SchoolTerm] = objInFor[conCurrEduCls4Synch.SchoolTerm];
objDR[conCurrEduCls4Synch.ArrangeCourseMemo] = objInFor[conCurrEduCls4Synch.ArrangeCourseMemo];
objDR[conCurrEduCls4Synch.id_CourseType] = objInFor[conCurrEduCls4Synch.id_CourseType];
objDR[conCurrEduCls4Synch.ExportDate] = objInFor[conCurrEduCls4Synch.ExportDate];
objDR[conCurrEduCls4Synch.IsDegree] = objInFor[conCurrEduCls4Synch.IsDegree];
objDR[conCurrEduCls4Synch.id_ScoreType] = objInFor[conCurrEduCls4Synch.id_ScoreType];
objDR[conCurrEduCls4Synch.GetScoreWayId] = objInFor[conCurrEduCls4Synch.GetScoreWayId];
objDR[conCurrEduCls4Synch.IsProportionalCtrl] = objInFor[conCurrEduCls4Synch.IsProportionalCtrl];
objDR[conCurrEduCls4Synch.IsSynchToWeb] = objInFor[conCurrEduCls4Synch.IsSynchToWeb];
objDR[conCurrEduCls4Synch.SynchToWebDate] = objInFor[conCurrEduCls4Synch.SynchToWebDate];
objDR[conCurrEduCls4Synch.SynchToWebUser] = objInFor[conCurrEduCls4Synch.SynchToWebUser];
objDR[conCurrEduCls4Synch.SignInDate] = objInFor[conCurrEduCls4Synch.SignInDate];
objDR[conCurrEduCls4Synch.SignInStateID] = objInFor[conCurrEduCls4Synch.SignInStateID];
objDR[conCurrEduCls4Synch.SignInUser] = objInFor[conCurrEduCls4Synch.SignInUser];
objDR[conCurrEduCls4Synch.id_ExamType] = objInFor[conCurrEduCls4Synch.id_ExamType];
objDR[conCurrEduCls4Synch.ExamPortion] = objInFor[conCurrEduCls4Synch.ExamPortion];
objDR[conCurrEduCls4Synch.MidExamScorePortion] = objInFor[conCurrEduCls4Synch.MidExamScorePortion];
objDR[conCurrEduCls4Synch.IsClearScore] = objInFor[conCurrEduCls4Synch.IsClearScore];
objDR[conCurrEduCls4Synch.IsGeneratePwd] = objInFor[conCurrEduCls4Synch.IsGeneratePwd];
objDR[conCurrEduCls4Synch.GeneratePwdDate] = objInFor[conCurrEduCls4Synch.GeneratePwdDate];
objDR[conCurrEduCls4Synch.IsExportToGP] = objInFor[conCurrEduCls4Synch.IsExportToGP];
objDR[conCurrEduCls4Synch.IsExportToGPWeb] = objInFor[conCurrEduCls4Synch.IsExportToGPWeb];
objDR[conCurrEduCls4Synch.IsReservedDecimal] = objInFor[conCurrEduCls4Synch.IsReservedDecimal];
objDR[conCurrEduCls4Synch.ExamTime] = objInFor[conCurrEduCls4Synch.ExamTime];
objDR[conCurrEduCls4Synch.CheckState] = objInFor[conCurrEduCls4Synch.CheckState];
objDR[conCurrEduCls4Synch.CheckDate] = objInFor[conCurrEduCls4Synch.CheckDate];
objDR[conCurrEduCls4Synch.id_EduClassInPk] = objInFor[conCurrEduCls4Synch.id_EduClassInPk];
objDR[conCurrEduCls4Synch.PkWeekTime] = objInFor[conCurrEduCls4Synch.PkWeekTime];
objDR[conCurrEduCls4Synch.PkClassRooms] = objInFor[conCurrEduCls4Synch.PkClassRooms];
objDR[conCurrEduCls4Synch.BeginWeek] = objInFor[conCurrEduCls4Synch.BeginWeek];
objDR[conCurrEduCls4Synch.TeacherNames] = objInFor[conCurrEduCls4Synch.TeacherNames];
objDR[conCurrEduCls4Synch.IsAccessSynch] = objInFor[conCurrEduCls4Synch.IsAccessSynch];
objDR[conCurrEduCls4Synch.AccessSynchDate] = objInFor[conCurrEduCls4Synch.AccessSynchDate];
objDR[conCurrEduCls4Synch.IsExistEduClsInCurr] = objInFor[conCurrEduCls4Synch.IsExistEduClsInCurr];
objDR[conCurrEduCls4Synch.ModifyDate] = objInFor[conCurrEduCls4Synch.ModifyDate];
objDR[conCurrEduCls4Synch.ModifyUserID] = objInFor[conCurrEduCls4Synch.ModifyUserID];
objDR[conCurrEduCls4Synch.Memo] = objInFor[conCurrEduCls4Synch.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 当前教学班_同步(CurrEduCls4Synch)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4CurrEduCls4Synch : clsCommFun4BL
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
clsCurrEduCls4SynchWApi.ReFreshThisCache();
clsvCurrEduCls4SynchWApi.ReFreshThisCache();
}
}

}