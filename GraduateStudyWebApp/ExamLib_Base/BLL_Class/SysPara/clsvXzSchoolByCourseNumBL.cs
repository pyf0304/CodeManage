
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvXzSchoolByCourseNumBL
 表名:vXzSchoolByCourseNum(01120335)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:51:21
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数(SysPara)
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
public static class  clsvXzSchoolByCourseNumBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdSchool">表关键字</param>
 /// <returns>表对象</returns>
public static clsvXzSchoolByCourseNumEN GetObj(this K_IdSchool_vXzSchoolByCourseNum myKey)
{
clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN = clsvXzSchoolByCourseNumBL.vXzSchoolByCourseNumDA.GetObjByIdSchool(myKey.Value);
return objvXzSchoolByCourseNumEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzSchoolByCourseNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzSchoolByCourseNumEN SetIdSchool(this clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN, string strIdSchool, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSchool, 4, convXzSchoolByCourseNum.IdSchool);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSchool, 4, convXzSchoolByCourseNum.IdSchool);
}
objvXzSchoolByCourseNumEN.IdSchool = strIdSchool; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzSchoolByCourseNumEN.dicFldComparisonOp.ContainsKey(convXzSchoolByCourseNum.IdSchool) == false)
{
objvXzSchoolByCourseNumEN.dicFldComparisonOp.Add(convXzSchoolByCourseNum.IdSchool, strComparisonOp);
}
else
{
objvXzSchoolByCourseNumEN.dicFldComparisonOp[convXzSchoolByCourseNum.IdSchool] = strComparisonOp;
}
}
return objvXzSchoolByCourseNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzSchoolByCourseNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzSchoolByCourseNumEN SetSchoolId(this clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN, string strSchoolId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolId, convXzSchoolByCourseNum.SchoolId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolId, 10, convXzSchoolByCourseNum.SchoolId);
}
objvXzSchoolByCourseNumEN.SchoolId = strSchoolId; //学校编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzSchoolByCourseNumEN.dicFldComparisonOp.ContainsKey(convXzSchoolByCourseNum.SchoolId) == false)
{
objvXzSchoolByCourseNumEN.dicFldComparisonOp.Add(convXzSchoolByCourseNum.SchoolId, strComparisonOp);
}
else
{
objvXzSchoolByCourseNumEN.dicFldComparisonOp[convXzSchoolByCourseNum.SchoolId] = strComparisonOp;
}
}
return objvXzSchoolByCourseNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzSchoolByCourseNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzSchoolByCourseNumEN SetSchoolName(this clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN, string strSchoolName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolName, convXzSchoolByCourseNum.SchoolName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolName, 50, convXzSchoolByCourseNum.SchoolName);
}
objvXzSchoolByCourseNumEN.SchoolName = strSchoolName; //学校名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzSchoolByCourseNumEN.dicFldComparisonOp.ContainsKey(convXzSchoolByCourseNum.SchoolName) == false)
{
objvXzSchoolByCourseNumEN.dicFldComparisonOp.Add(convXzSchoolByCourseNum.SchoolName, strComparisonOp);
}
else
{
objvXzSchoolByCourseNumEN.dicFldComparisonOp[convXzSchoolByCourseNum.SchoolName] = strComparisonOp;
}
}
return objvXzSchoolByCourseNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzSchoolByCourseNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzSchoolByCourseNumEN SetSchoolNameA(this clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN, string strSchoolNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolNameA, 14, convXzSchoolByCourseNum.SchoolNameA);
}
objvXzSchoolByCourseNumEN.SchoolNameA = strSchoolNameA; //学校简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzSchoolByCourseNumEN.dicFldComparisonOp.ContainsKey(convXzSchoolByCourseNum.SchoolNameA) == false)
{
objvXzSchoolByCourseNumEN.dicFldComparisonOp.Add(convXzSchoolByCourseNum.SchoolNameA, strComparisonOp);
}
else
{
objvXzSchoolByCourseNumEN.dicFldComparisonOp[convXzSchoolByCourseNum.SchoolNameA] = strComparisonOp;
}
}
return objvXzSchoolByCourseNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzSchoolByCourseNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzSchoolByCourseNumEN SetSchoolTypeId(this clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN, string strSchoolTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolTypeId, 2, convXzSchoolByCourseNum.SchoolTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSchoolTypeId, 2, convXzSchoolByCourseNum.SchoolTypeId);
}
objvXzSchoolByCourseNumEN.SchoolTypeId = strSchoolTypeId; //学校类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzSchoolByCourseNumEN.dicFldComparisonOp.ContainsKey(convXzSchoolByCourseNum.SchoolTypeId) == false)
{
objvXzSchoolByCourseNumEN.dicFldComparisonOp.Add(convXzSchoolByCourseNum.SchoolTypeId, strComparisonOp);
}
else
{
objvXzSchoolByCourseNumEN.dicFldComparisonOp[convXzSchoolByCourseNum.SchoolTypeId] = strComparisonOp;
}
}
return objvXzSchoolByCourseNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzSchoolByCourseNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzSchoolByCourseNumEN SetSchoolTypeName(this clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN, string strSchoolTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolTypeName, 30, convXzSchoolByCourseNum.SchoolTypeName);
}
objvXzSchoolByCourseNumEN.SchoolTypeName = strSchoolTypeName; //学校类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzSchoolByCourseNumEN.dicFldComparisonOp.ContainsKey(convXzSchoolByCourseNum.SchoolTypeName) == false)
{
objvXzSchoolByCourseNumEN.dicFldComparisonOp.Add(convXzSchoolByCourseNum.SchoolTypeName, strComparisonOp);
}
else
{
objvXzSchoolByCourseNumEN.dicFldComparisonOp[convXzSchoolByCourseNum.SchoolTypeName] = strComparisonOp;
}
}
return objvXzSchoolByCourseNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzSchoolByCourseNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzSchoolByCourseNumEN SetIsCurrentUse(this clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN, bool bolIsCurrentUse, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsCurrentUse, convXzSchoolByCourseNum.IsCurrentUse);
objvXzSchoolByCourseNumEN.IsCurrentUse = bolIsCurrentUse; //是否当前使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzSchoolByCourseNumEN.dicFldComparisonOp.ContainsKey(convXzSchoolByCourseNum.IsCurrentUse) == false)
{
objvXzSchoolByCourseNumEN.dicFldComparisonOp.Add(convXzSchoolByCourseNum.IsCurrentUse, strComparisonOp);
}
else
{
objvXzSchoolByCourseNumEN.dicFldComparisonOp[convXzSchoolByCourseNum.IsCurrentUse] = strComparisonOp;
}
}
return objvXzSchoolByCourseNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzSchoolByCourseNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzSchoolByCourseNumEN SetUpdDate(this clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convXzSchoolByCourseNum.UpdDate);
}
objvXzSchoolByCourseNumEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzSchoolByCourseNumEN.dicFldComparisonOp.ContainsKey(convXzSchoolByCourseNum.UpdDate) == false)
{
objvXzSchoolByCourseNumEN.dicFldComparisonOp.Add(convXzSchoolByCourseNum.UpdDate, strComparisonOp);
}
else
{
objvXzSchoolByCourseNumEN.dicFldComparisonOp[convXzSchoolByCourseNum.UpdDate] = strComparisonOp;
}
}
return objvXzSchoolByCourseNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzSchoolByCourseNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzSchoolByCourseNumEN SetUpdUserId(this clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convXzSchoolByCourseNum.UpdUserId);
}
objvXzSchoolByCourseNumEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzSchoolByCourseNumEN.dicFldComparisonOp.ContainsKey(convXzSchoolByCourseNum.UpdUserId) == false)
{
objvXzSchoolByCourseNumEN.dicFldComparisonOp.Add(convXzSchoolByCourseNum.UpdUserId, strComparisonOp);
}
else
{
objvXzSchoolByCourseNumEN.dicFldComparisonOp[convXzSchoolByCourseNum.UpdUserId] = strComparisonOp;
}
}
return objvXzSchoolByCourseNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzSchoolByCourseNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzSchoolByCourseNumEN SetMemo(this clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convXzSchoolByCourseNum.Memo);
}
objvXzSchoolByCourseNumEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzSchoolByCourseNumEN.dicFldComparisonOp.ContainsKey(convXzSchoolByCourseNum.Memo) == false)
{
objvXzSchoolByCourseNumEN.dicFldComparisonOp.Add(convXzSchoolByCourseNum.Memo, strComparisonOp);
}
else
{
objvXzSchoolByCourseNumEN.dicFldComparisonOp[convXzSchoolByCourseNum.Memo] = strComparisonOp;
}
}
return objvXzSchoolByCourseNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzSchoolByCourseNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzSchoolByCourseNumEN SetCourseNum(this clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN, int? intCourseNum, string strComparisonOp="")
	{
objvXzSchoolByCourseNumEN.CourseNum = intCourseNum; //CourseNum
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzSchoolByCourseNumEN.dicFldComparisonOp.ContainsKey(convXzSchoolByCourseNum.CourseNum) == false)
{
objvXzSchoolByCourseNumEN.dicFldComparisonOp.Add(convXzSchoolByCourseNum.CourseNum, strComparisonOp);
}
else
{
objvXzSchoolByCourseNumEN.dicFldComparisonOp[convXzSchoolByCourseNum.CourseNum] = strComparisonOp;
}
}
return objvXzSchoolByCourseNumEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvXzSchoolByCourseNumENS">源对象</param>
 /// <param name = "objvXzSchoolByCourseNumENT">目标对象</param>
 public static void CopyTo(this clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumENS, clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumENT)
{
try
{
objvXzSchoolByCourseNumENT.IdSchool = objvXzSchoolByCourseNumENS.IdSchool; //学校流水号
objvXzSchoolByCourseNumENT.SchoolId = objvXzSchoolByCourseNumENS.SchoolId; //学校编号
objvXzSchoolByCourseNumENT.SchoolName = objvXzSchoolByCourseNumENS.SchoolName; //学校名称
objvXzSchoolByCourseNumENT.SchoolNameA = objvXzSchoolByCourseNumENS.SchoolNameA; //学校简称
objvXzSchoolByCourseNumENT.SchoolTypeId = objvXzSchoolByCourseNumENS.SchoolTypeId; //学校类型Id
objvXzSchoolByCourseNumENT.SchoolTypeName = objvXzSchoolByCourseNumENS.SchoolTypeName; //学校类型名
objvXzSchoolByCourseNumENT.IsCurrentUse = objvXzSchoolByCourseNumENS.IsCurrentUse; //是否当前使用
objvXzSchoolByCourseNumENT.UpdDate = objvXzSchoolByCourseNumENS.UpdDate; //修改日期
objvXzSchoolByCourseNumENT.UpdUserId = objvXzSchoolByCourseNumENS.UpdUserId; //修改用户Id
objvXzSchoolByCourseNumENT.Memo = objvXzSchoolByCourseNumENS.Memo; //备注
objvXzSchoolByCourseNumENT.CourseNum = objvXzSchoolByCourseNumENS.CourseNum; //CourseNum
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
 /// <param name = "objvXzSchoolByCourseNumENS">源对象</param>
 /// <returns>目标对象=>clsvXzSchoolByCourseNumEN:objvXzSchoolByCourseNumENT</returns>
 public static clsvXzSchoolByCourseNumEN CopyTo(this clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumENS)
{
try
{
 clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumENT = new clsvXzSchoolByCourseNumEN()
{
IdSchool = objvXzSchoolByCourseNumENS.IdSchool, //学校流水号
SchoolId = objvXzSchoolByCourseNumENS.SchoolId, //学校编号
SchoolName = objvXzSchoolByCourseNumENS.SchoolName, //学校名称
SchoolNameA = objvXzSchoolByCourseNumENS.SchoolNameA, //学校简称
SchoolTypeId = objvXzSchoolByCourseNumENS.SchoolTypeId, //学校类型Id
SchoolTypeName = objvXzSchoolByCourseNumENS.SchoolTypeName, //学校类型名
IsCurrentUse = objvXzSchoolByCourseNumENS.IsCurrentUse, //是否当前使用
UpdDate = objvXzSchoolByCourseNumENS.UpdDate, //修改日期
UpdUserId = objvXzSchoolByCourseNumENS.UpdUserId, //修改用户Id
Memo = objvXzSchoolByCourseNumENS.Memo, //备注
CourseNum = objvXzSchoolByCourseNumENS.CourseNum, //CourseNum
};
 return objvXzSchoolByCourseNumENT;
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
public static void CheckProperty4Condition(this clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN)
{
 clsvXzSchoolByCourseNumBL.vXzSchoolByCourseNumDA.CheckProperty4Condition(objvXzSchoolByCourseNumEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvXzSchoolByCourseNumCond.IsUpdated(convXzSchoolByCourseNum.IdSchool) == true)
{
string strComparisonOpIdSchool = objvXzSchoolByCourseNumCond.dicFldComparisonOp[convXzSchoolByCourseNum.IdSchool];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzSchoolByCourseNum.IdSchool, objvXzSchoolByCourseNumCond.IdSchool, strComparisonOpIdSchool);
}
if (objvXzSchoolByCourseNumCond.IsUpdated(convXzSchoolByCourseNum.SchoolId) == true)
{
string strComparisonOpSchoolId = objvXzSchoolByCourseNumCond.dicFldComparisonOp[convXzSchoolByCourseNum.SchoolId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzSchoolByCourseNum.SchoolId, objvXzSchoolByCourseNumCond.SchoolId, strComparisonOpSchoolId);
}
if (objvXzSchoolByCourseNumCond.IsUpdated(convXzSchoolByCourseNum.SchoolName) == true)
{
string strComparisonOpSchoolName = objvXzSchoolByCourseNumCond.dicFldComparisonOp[convXzSchoolByCourseNum.SchoolName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzSchoolByCourseNum.SchoolName, objvXzSchoolByCourseNumCond.SchoolName, strComparisonOpSchoolName);
}
if (objvXzSchoolByCourseNumCond.IsUpdated(convXzSchoolByCourseNum.SchoolNameA) == true)
{
string strComparisonOpSchoolNameA = objvXzSchoolByCourseNumCond.dicFldComparisonOp[convXzSchoolByCourseNum.SchoolNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzSchoolByCourseNum.SchoolNameA, objvXzSchoolByCourseNumCond.SchoolNameA, strComparisonOpSchoolNameA);
}
if (objvXzSchoolByCourseNumCond.IsUpdated(convXzSchoolByCourseNum.SchoolTypeId) == true)
{
string strComparisonOpSchoolTypeId = objvXzSchoolByCourseNumCond.dicFldComparisonOp[convXzSchoolByCourseNum.SchoolTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzSchoolByCourseNum.SchoolTypeId, objvXzSchoolByCourseNumCond.SchoolTypeId, strComparisonOpSchoolTypeId);
}
if (objvXzSchoolByCourseNumCond.IsUpdated(convXzSchoolByCourseNum.SchoolTypeName) == true)
{
string strComparisonOpSchoolTypeName = objvXzSchoolByCourseNumCond.dicFldComparisonOp[convXzSchoolByCourseNum.SchoolTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzSchoolByCourseNum.SchoolTypeName, objvXzSchoolByCourseNumCond.SchoolTypeName, strComparisonOpSchoolTypeName);
}
if (objvXzSchoolByCourseNumCond.IsUpdated(convXzSchoolByCourseNum.IsCurrentUse) == true)
{
if (objvXzSchoolByCourseNumCond.IsCurrentUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convXzSchoolByCourseNum.IsCurrentUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convXzSchoolByCourseNum.IsCurrentUse);
}
}
if (objvXzSchoolByCourseNumCond.IsUpdated(convXzSchoolByCourseNum.UpdDate) == true)
{
string strComparisonOpUpdDate = objvXzSchoolByCourseNumCond.dicFldComparisonOp[convXzSchoolByCourseNum.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzSchoolByCourseNum.UpdDate, objvXzSchoolByCourseNumCond.UpdDate, strComparisonOpUpdDate);
}
if (objvXzSchoolByCourseNumCond.IsUpdated(convXzSchoolByCourseNum.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvXzSchoolByCourseNumCond.dicFldComparisonOp[convXzSchoolByCourseNum.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzSchoolByCourseNum.UpdUserId, objvXzSchoolByCourseNumCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvXzSchoolByCourseNumCond.IsUpdated(convXzSchoolByCourseNum.Memo) == true)
{
string strComparisonOpMemo = objvXzSchoolByCourseNumCond.dicFldComparisonOp[convXzSchoolByCourseNum.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzSchoolByCourseNum.Memo, objvXzSchoolByCourseNumCond.Memo, strComparisonOpMemo);
}
if (objvXzSchoolByCourseNumCond.IsUpdated(convXzSchoolByCourseNum.CourseNum) == true)
{
string strComparisonOpCourseNum = objvXzSchoolByCourseNumCond.dicFldComparisonOp[convXzSchoolByCourseNum.CourseNum];
strWhereCond += string.Format(" And {0} {2} {1}", convXzSchoolByCourseNum.CourseNum, objvXzSchoolByCourseNumCond.CourseNum, strComparisonOpCourseNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vXzSchoolByCourseNum
{
public virtual bool UpdRelaTabDate(string strIdSchool, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vXzSchoolByCourseNum(vXzSchoolByCourseNum)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvXzSchoolByCourseNumBL
{
public static RelatedActions_vXzSchoolByCourseNum relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvXzSchoolByCourseNumDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvXzSchoolByCourseNumDA vXzSchoolByCourseNumDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvXzSchoolByCourseNumDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvXzSchoolByCourseNumBL()
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
if (string.IsNullOrEmpty(clsvXzSchoolByCourseNumEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvXzSchoolByCourseNumEN._ConnectString);
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
public static DataTable GetDataTable_vXzSchoolByCourseNum(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vXzSchoolByCourseNumDA.GetDataTable_vXzSchoolByCourseNum(strWhereCond);
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
objDT = vXzSchoolByCourseNumDA.GetDataTable(strWhereCond);
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
objDT = vXzSchoolByCourseNumDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vXzSchoolByCourseNumDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vXzSchoolByCourseNumDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vXzSchoolByCourseNumDA.GetDataTable_Top(objTopPara);
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
objDT = vXzSchoolByCourseNumDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vXzSchoolByCourseNumDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vXzSchoolByCourseNumDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdSchoolLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvXzSchoolByCourseNumEN> GetObjLstByIdSchoolLst(List<string> arrIdSchoolLst)
{
List<clsvXzSchoolByCourseNumEN> arrObjLst = new List<clsvXzSchoolByCourseNumEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdSchoolLst, true);
 string strWhereCond = string.Format("IdSchool in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN = new clsvXzSchoolByCourseNumEN();
try
{
objvXzSchoolByCourseNumEN.IdSchool = objRow[convXzSchoolByCourseNum.IdSchool].ToString().Trim(); //学校流水号
objvXzSchoolByCourseNumEN.SchoolId = objRow[convXzSchoolByCourseNum.SchoolId].ToString().Trim(); //学校编号
objvXzSchoolByCourseNumEN.SchoolName = objRow[convXzSchoolByCourseNum.SchoolName].ToString().Trim(); //学校名称
objvXzSchoolByCourseNumEN.SchoolNameA = objRow[convXzSchoolByCourseNum.SchoolNameA] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.SchoolNameA].ToString().Trim(); //学校简称
objvXzSchoolByCourseNumEN.SchoolTypeId = objRow[convXzSchoolByCourseNum.SchoolTypeId] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.SchoolTypeId].ToString().Trim(); //学校类型Id
objvXzSchoolByCourseNumEN.SchoolTypeName = objRow[convXzSchoolByCourseNum.SchoolTypeName] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.SchoolTypeName].ToString().Trim(); //学校类型名
objvXzSchoolByCourseNumEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[convXzSchoolByCourseNum.IsCurrentUse].ToString().Trim()); //是否当前使用
objvXzSchoolByCourseNumEN.UpdDate = objRow[convXzSchoolByCourseNum.UpdDate] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.UpdDate].ToString().Trim(); //修改日期
objvXzSchoolByCourseNumEN.UpdUserId = objRow[convXzSchoolByCourseNum.UpdUserId] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.UpdUserId].ToString().Trim(); //修改用户Id
objvXzSchoolByCourseNumEN.Memo = objRow[convXzSchoolByCourseNum.Memo] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.Memo].ToString().Trim(); //备注
objvXzSchoolByCourseNumEN.CourseNum = objRow[convXzSchoolByCourseNum.CourseNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzSchoolByCourseNum.CourseNum].ToString().Trim()); //CourseNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzSchoolByCourseNumEN.IdSchool, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzSchoolByCourseNumEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdSchoolLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvXzSchoolByCourseNumEN> GetObjLstByIdSchoolLstCache(List<string> arrIdSchoolLst)
{
string strKey = string.Format("{0}", clsvXzSchoolByCourseNumEN._CurrTabName);
List<clsvXzSchoolByCourseNumEN> arrvXzSchoolByCourseNumObjLstCache = GetObjLstCache();
IEnumerable <clsvXzSchoolByCourseNumEN> arrvXzSchoolByCourseNumObjLst_Sel =
arrvXzSchoolByCourseNumObjLstCache
.Where(x => arrIdSchoolLst.Contains(x.IdSchool));
return arrvXzSchoolByCourseNumObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzSchoolByCourseNumEN> GetObjLst(string strWhereCond)
{
List<clsvXzSchoolByCourseNumEN> arrObjLst = new List<clsvXzSchoolByCourseNumEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN = new clsvXzSchoolByCourseNumEN();
try
{
objvXzSchoolByCourseNumEN.IdSchool = objRow[convXzSchoolByCourseNum.IdSchool].ToString().Trim(); //学校流水号
objvXzSchoolByCourseNumEN.SchoolId = objRow[convXzSchoolByCourseNum.SchoolId].ToString().Trim(); //学校编号
objvXzSchoolByCourseNumEN.SchoolName = objRow[convXzSchoolByCourseNum.SchoolName].ToString().Trim(); //学校名称
objvXzSchoolByCourseNumEN.SchoolNameA = objRow[convXzSchoolByCourseNum.SchoolNameA] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.SchoolNameA].ToString().Trim(); //学校简称
objvXzSchoolByCourseNumEN.SchoolTypeId = objRow[convXzSchoolByCourseNum.SchoolTypeId] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.SchoolTypeId].ToString().Trim(); //学校类型Id
objvXzSchoolByCourseNumEN.SchoolTypeName = objRow[convXzSchoolByCourseNum.SchoolTypeName] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.SchoolTypeName].ToString().Trim(); //学校类型名
objvXzSchoolByCourseNumEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[convXzSchoolByCourseNum.IsCurrentUse].ToString().Trim()); //是否当前使用
objvXzSchoolByCourseNumEN.UpdDate = objRow[convXzSchoolByCourseNum.UpdDate] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.UpdDate].ToString().Trim(); //修改日期
objvXzSchoolByCourseNumEN.UpdUserId = objRow[convXzSchoolByCourseNum.UpdUserId] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.UpdUserId].ToString().Trim(); //修改用户Id
objvXzSchoolByCourseNumEN.Memo = objRow[convXzSchoolByCourseNum.Memo] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.Memo].ToString().Trim(); //备注
objvXzSchoolByCourseNumEN.CourseNum = objRow[convXzSchoolByCourseNum.CourseNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzSchoolByCourseNum.CourseNum].ToString().Trim()); //CourseNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzSchoolByCourseNumEN.IdSchool, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzSchoolByCourseNumEN);
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
public static List<clsvXzSchoolByCourseNumEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvXzSchoolByCourseNumEN> arrObjLst = new List<clsvXzSchoolByCourseNumEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN = new clsvXzSchoolByCourseNumEN();
try
{
objvXzSchoolByCourseNumEN.IdSchool = objRow[convXzSchoolByCourseNum.IdSchool].ToString().Trim(); //学校流水号
objvXzSchoolByCourseNumEN.SchoolId = objRow[convXzSchoolByCourseNum.SchoolId].ToString().Trim(); //学校编号
objvXzSchoolByCourseNumEN.SchoolName = objRow[convXzSchoolByCourseNum.SchoolName].ToString().Trim(); //学校名称
objvXzSchoolByCourseNumEN.SchoolNameA = objRow[convXzSchoolByCourseNum.SchoolNameA] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.SchoolNameA].ToString().Trim(); //学校简称
objvXzSchoolByCourseNumEN.SchoolTypeId = objRow[convXzSchoolByCourseNum.SchoolTypeId] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.SchoolTypeId].ToString().Trim(); //学校类型Id
objvXzSchoolByCourseNumEN.SchoolTypeName = objRow[convXzSchoolByCourseNum.SchoolTypeName] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.SchoolTypeName].ToString().Trim(); //学校类型名
objvXzSchoolByCourseNumEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[convXzSchoolByCourseNum.IsCurrentUse].ToString().Trim()); //是否当前使用
objvXzSchoolByCourseNumEN.UpdDate = objRow[convXzSchoolByCourseNum.UpdDate] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.UpdDate].ToString().Trim(); //修改日期
objvXzSchoolByCourseNumEN.UpdUserId = objRow[convXzSchoolByCourseNum.UpdUserId] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.UpdUserId].ToString().Trim(); //修改用户Id
objvXzSchoolByCourseNumEN.Memo = objRow[convXzSchoolByCourseNum.Memo] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.Memo].ToString().Trim(); //备注
objvXzSchoolByCourseNumEN.CourseNum = objRow[convXzSchoolByCourseNum.CourseNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzSchoolByCourseNum.CourseNum].ToString().Trim()); //CourseNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzSchoolByCourseNumEN.IdSchool, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzSchoolByCourseNumEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvXzSchoolByCourseNumCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvXzSchoolByCourseNumEN> GetSubObjLstCache(clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumCond)
{
List<clsvXzSchoolByCourseNumEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvXzSchoolByCourseNumEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convXzSchoolByCourseNum.AttributeName)
{
if (objvXzSchoolByCourseNumCond.IsUpdated(strFldName) == false) continue;
if (objvXzSchoolByCourseNumCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvXzSchoolByCourseNumCond[strFldName].ToString());
}
else
{
if (objvXzSchoolByCourseNumCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvXzSchoolByCourseNumCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvXzSchoolByCourseNumCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvXzSchoolByCourseNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvXzSchoolByCourseNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvXzSchoolByCourseNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvXzSchoolByCourseNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvXzSchoolByCourseNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvXzSchoolByCourseNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvXzSchoolByCourseNumCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvXzSchoolByCourseNumCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvXzSchoolByCourseNumCond[strFldName]));
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
public static List<clsvXzSchoolByCourseNumEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvXzSchoolByCourseNumEN> arrObjLst = new List<clsvXzSchoolByCourseNumEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN = new clsvXzSchoolByCourseNumEN();
try
{
objvXzSchoolByCourseNumEN.IdSchool = objRow[convXzSchoolByCourseNum.IdSchool].ToString().Trim(); //学校流水号
objvXzSchoolByCourseNumEN.SchoolId = objRow[convXzSchoolByCourseNum.SchoolId].ToString().Trim(); //学校编号
objvXzSchoolByCourseNumEN.SchoolName = objRow[convXzSchoolByCourseNum.SchoolName].ToString().Trim(); //学校名称
objvXzSchoolByCourseNumEN.SchoolNameA = objRow[convXzSchoolByCourseNum.SchoolNameA] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.SchoolNameA].ToString().Trim(); //学校简称
objvXzSchoolByCourseNumEN.SchoolTypeId = objRow[convXzSchoolByCourseNum.SchoolTypeId] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.SchoolTypeId].ToString().Trim(); //学校类型Id
objvXzSchoolByCourseNumEN.SchoolTypeName = objRow[convXzSchoolByCourseNum.SchoolTypeName] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.SchoolTypeName].ToString().Trim(); //学校类型名
objvXzSchoolByCourseNumEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[convXzSchoolByCourseNum.IsCurrentUse].ToString().Trim()); //是否当前使用
objvXzSchoolByCourseNumEN.UpdDate = objRow[convXzSchoolByCourseNum.UpdDate] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.UpdDate].ToString().Trim(); //修改日期
objvXzSchoolByCourseNumEN.UpdUserId = objRow[convXzSchoolByCourseNum.UpdUserId] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.UpdUserId].ToString().Trim(); //修改用户Id
objvXzSchoolByCourseNumEN.Memo = objRow[convXzSchoolByCourseNum.Memo] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.Memo].ToString().Trim(); //备注
objvXzSchoolByCourseNumEN.CourseNum = objRow[convXzSchoolByCourseNum.CourseNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzSchoolByCourseNum.CourseNum].ToString().Trim()); //CourseNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzSchoolByCourseNumEN.IdSchool, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzSchoolByCourseNumEN);
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
public static List<clsvXzSchoolByCourseNumEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvXzSchoolByCourseNumEN> arrObjLst = new List<clsvXzSchoolByCourseNumEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN = new clsvXzSchoolByCourseNumEN();
try
{
objvXzSchoolByCourseNumEN.IdSchool = objRow[convXzSchoolByCourseNum.IdSchool].ToString().Trim(); //学校流水号
objvXzSchoolByCourseNumEN.SchoolId = objRow[convXzSchoolByCourseNum.SchoolId].ToString().Trim(); //学校编号
objvXzSchoolByCourseNumEN.SchoolName = objRow[convXzSchoolByCourseNum.SchoolName].ToString().Trim(); //学校名称
objvXzSchoolByCourseNumEN.SchoolNameA = objRow[convXzSchoolByCourseNum.SchoolNameA] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.SchoolNameA].ToString().Trim(); //学校简称
objvXzSchoolByCourseNumEN.SchoolTypeId = objRow[convXzSchoolByCourseNum.SchoolTypeId] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.SchoolTypeId].ToString().Trim(); //学校类型Id
objvXzSchoolByCourseNumEN.SchoolTypeName = objRow[convXzSchoolByCourseNum.SchoolTypeName] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.SchoolTypeName].ToString().Trim(); //学校类型名
objvXzSchoolByCourseNumEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[convXzSchoolByCourseNum.IsCurrentUse].ToString().Trim()); //是否当前使用
objvXzSchoolByCourseNumEN.UpdDate = objRow[convXzSchoolByCourseNum.UpdDate] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.UpdDate].ToString().Trim(); //修改日期
objvXzSchoolByCourseNumEN.UpdUserId = objRow[convXzSchoolByCourseNum.UpdUserId] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.UpdUserId].ToString().Trim(); //修改用户Id
objvXzSchoolByCourseNumEN.Memo = objRow[convXzSchoolByCourseNum.Memo] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.Memo].ToString().Trim(); //备注
objvXzSchoolByCourseNumEN.CourseNum = objRow[convXzSchoolByCourseNum.CourseNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzSchoolByCourseNum.CourseNum].ToString().Trim()); //CourseNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzSchoolByCourseNumEN.IdSchool, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzSchoolByCourseNumEN);
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
List<clsvXzSchoolByCourseNumEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvXzSchoolByCourseNumEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzSchoolByCourseNumEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvXzSchoolByCourseNumEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvXzSchoolByCourseNumEN> arrObjLst = new List<clsvXzSchoolByCourseNumEN>(); 
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
	clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN = new clsvXzSchoolByCourseNumEN();
try
{
objvXzSchoolByCourseNumEN.IdSchool = objRow[convXzSchoolByCourseNum.IdSchool].ToString().Trim(); //学校流水号
objvXzSchoolByCourseNumEN.SchoolId = objRow[convXzSchoolByCourseNum.SchoolId].ToString().Trim(); //学校编号
objvXzSchoolByCourseNumEN.SchoolName = objRow[convXzSchoolByCourseNum.SchoolName].ToString().Trim(); //学校名称
objvXzSchoolByCourseNumEN.SchoolNameA = objRow[convXzSchoolByCourseNum.SchoolNameA] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.SchoolNameA].ToString().Trim(); //学校简称
objvXzSchoolByCourseNumEN.SchoolTypeId = objRow[convXzSchoolByCourseNum.SchoolTypeId] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.SchoolTypeId].ToString().Trim(); //学校类型Id
objvXzSchoolByCourseNumEN.SchoolTypeName = objRow[convXzSchoolByCourseNum.SchoolTypeName] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.SchoolTypeName].ToString().Trim(); //学校类型名
objvXzSchoolByCourseNumEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[convXzSchoolByCourseNum.IsCurrentUse].ToString().Trim()); //是否当前使用
objvXzSchoolByCourseNumEN.UpdDate = objRow[convXzSchoolByCourseNum.UpdDate] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.UpdDate].ToString().Trim(); //修改日期
objvXzSchoolByCourseNumEN.UpdUserId = objRow[convXzSchoolByCourseNum.UpdUserId] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.UpdUserId].ToString().Trim(); //修改用户Id
objvXzSchoolByCourseNumEN.Memo = objRow[convXzSchoolByCourseNum.Memo] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.Memo].ToString().Trim(); //备注
objvXzSchoolByCourseNumEN.CourseNum = objRow[convXzSchoolByCourseNum.CourseNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzSchoolByCourseNum.CourseNum].ToString().Trim()); //CourseNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzSchoolByCourseNumEN.IdSchool, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzSchoolByCourseNumEN);
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
public static List<clsvXzSchoolByCourseNumEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvXzSchoolByCourseNumEN> arrObjLst = new List<clsvXzSchoolByCourseNumEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN = new clsvXzSchoolByCourseNumEN();
try
{
objvXzSchoolByCourseNumEN.IdSchool = objRow[convXzSchoolByCourseNum.IdSchool].ToString().Trim(); //学校流水号
objvXzSchoolByCourseNumEN.SchoolId = objRow[convXzSchoolByCourseNum.SchoolId].ToString().Trim(); //学校编号
objvXzSchoolByCourseNumEN.SchoolName = objRow[convXzSchoolByCourseNum.SchoolName].ToString().Trim(); //学校名称
objvXzSchoolByCourseNumEN.SchoolNameA = objRow[convXzSchoolByCourseNum.SchoolNameA] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.SchoolNameA].ToString().Trim(); //学校简称
objvXzSchoolByCourseNumEN.SchoolTypeId = objRow[convXzSchoolByCourseNum.SchoolTypeId] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.SchoolTypeId].ToString().Trim(); //学校类型Id
objvXzSchoolByCourseNumEN.SchoolTypeName = objRow[convXzSchoolByCourseNum.SchoolTypeName] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.SchoolTypeName].ToString().Trim(); //学校类型名
objvXzSchoolByCourseNumEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[convXzSchoolByCourseNum.IsCurrentUse].ToString().Trim()); //是否当前使用
objvXzSchoolByCourseNumEN.UpdDate = objRow[convXzSchoolByCourseNum.UpdDate] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.UpdDate].ToString().Trim(); //修改日期
objvXzSchoolByCourseNumEN.UpdUserId = objRow[convXzSchoolByCourseNum.UpdUserId] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.UpdUserId].ToString().Trim(); //修改用户Id
objvXzSchoolByCourseNumEN.Memo = objRow[convXzSchoolByCourseNum.Memo] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.Memo].ToString().Trim(); //备注
objvXzSchoolByCourseNumEN.CourseNum = objRow[convXzSchoolByCourseNum.CourseNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzSchoolByCourseNum.CourseNum].ToString().Trim()); //CourseNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzSchoolByCourseNumEN.IdSchool, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzSchoolByCourseNumEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvXzSchoolByCourseNumEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvXzSchoolByCourseNumEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvXzSchoolByCourseNumEN> arrObjLst = new List<clsvXzSchoolByCourseNumEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN = new clsvXzSchoolByCourseNumEN();
try
{
objvXzSchoolByCourseNumEN.IdSchool = objRow[convXzSchoolByCourseNum.IdSchool].ToString().Trim(); //学校流水号
objvXzSchoolByCourseNumEN.SchoolId = objRow[convXzSchoolByCourseNum.SchoolId].ToString().Trim(); //学校编号
objvXzSchoolByCourseNumEN.SchoolName = objRow[convXzSchoolByCourseNum.SchoolName].ToString().Trim(); //学校名称
objvXzSchoolByCourseNumEN.SchoolNameA = objRow[convXzSchoolByCourseNum.SchoolNameA] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.SchoolNameA].ToString().Trim(); //学校简称
objvXzSchoolByCourseNumEN.SchoolTypeId = objRow[convXzSchoolByCourseNum.SchoolTypeId] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.SchoolTypeId].ToString().Trim(); //学校类型Id
objvXzSchoolByCourseNumEN.SchoolTypeName = objRow[convXzSchoolByCourseNum.SchoolTypeName] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.SchoolTypeName].ToString().Trim(); //学校类型名
objvXzSchoolByCourseNumEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[convXzSchoolByCourseNum.IsCurrentUse].ToString().Trim()); //是否当前使用
objvXzSchoolByCourseNumEN.UpdDate = objRow[convXzSchoolByCourseNum.UpdDate] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.UpdDate].ToString().Trim(); //修改日期
objvXzSchoolByCourseNumEN.UpdUserId = objRow[convXzSchoolByCourseNum.UpdUserId] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.UpdUserId].ToString().Trim(); //修改用户Id
objvXzSchoolByCourseNumEN.Memo = objRow[convXzSchoolByCourseNum.Memo] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.Memo].ToString().Trim(); //备注
objvXzSchoolByCourseNumEN.CourseNum = objRow[convXzSchoolByCourseNum.CourseNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzSchoolByCourseNum.CourseNum].ToString().Trim()); //CourseNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzSchoolByCourseNumEN.IdSchool, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzSchoolByCourseNumEN);
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
public static List<clsvXzSchoolByCourseNumEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvXzSchoolByCourseNumEN> arrObjLst = new List<clsvXzSchoolByCourseNumEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN = new clsvXzSchoolByCourseNumEN();
try
{
objvXzSchoolByCourseNumEN.IdSchool = objRow[convXzSchoolByCourseNum.IdSchool].ToString().Trim(); //学校流水号
objvXzSchoolByCourseNumEN.SchoolId = objRow[convXzSchoolByCourseNum.SchoolId].ToString().Trim(); //学校编号
objvXzSchoolByCourseNumEN.SchoolName = objRow[convXzSchoolByCourseNum.SchoolName].ToString().Trim(); //学校名称
objvXzSchoolByCourseNumEN.SchoolNameA = objRow[convXzSchoolByCourseNum.SchoolNameA] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.SchoolNameA].ToString().Trim(); //学校简称
objvXzSchoolByCourseNumEN.SchoolTypeId = objRow[convXzSchoolByCourseNum.SchoolTypeId] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.SchoolTypeId].ToString().Trim(); //学校类型Id
objvXzSchoolByCourseNumEN.SchoolTypeName = objRow[convXzSchoolByCourseNum.SchoolTypeName] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.SchoolTypeName].ToString().Trim(); //学校类型名
objvXzSchoolByCourseNumEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[convXzSchoolByCourseNum.IsCurrentUse].ToString().Trim()); //是否当前使用
objvXzSchoolByCourseNumEN.UpdDate = objRow[convXzSchoolByCourseNum.UpdDate] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.UpdDate].ToString().Trim(); //修改日期
objvXzSchoolByCourseNumEN.UpdUserId = objRow[convXzSchoolByCourseNum.UpdUserId] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.UpdUserId].ToString().Trim(); //修改用户Id
objvXzSchoolByCourseNumEN.Memo = objRow[convXzSchoolByCourseNum.Memo] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.Memo].ToString().Trim(); //备注
objvXzSchoolByCourseNumEN.CourseNum = objRow[convXzSchoolByCourseNum.CourseNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzSchoolByCourseNum.CourseNum].ToString().Trim()); //CourseNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzSchoolByCourseNumEN.IdSchool, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzSchoolByCourseNumEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzSchoolByCourseNumEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvXzSchoolByCourseNumEN> arrObjLst = new List<clsvXzSchoolByCourseNumEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN = new clsvXzSchoolByCourseNumEN();
try
{
objvXzSchoolByCourseNumEN.IdSchool = objRow[convXzSchoolByCourseNum.IdSchool].ToString().Trim(); //学校流水号
objvXzSchoolByCourseNumEN.SchoolId = objRow[convXzSchoolByCourseNum.SchoolId].ToString().Trim(); //学校编号
objvXzSchoolByCourseNumEN.SchoolName = objRow[convXzSchoolByCourseNum.SchoolName].ToString().Trim(); //学校名称
objvXzSchoolByCourseNumEN.SchoolNameA = objRow[convXzSchoolByCourseNum.SchoolNameA] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.SchoolNameA].ToString().Trim(); //学校简称
objvXzSchoolByCourseNumEN.SchoolTypeId = objRow[convXzSchoolByCourseNum.SchoolTypeId] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.SchoolTypeId].ToString().Trim(); //学校类型Id
objvXzSchoolByCourseNumEN.SchoolTypeName = objRow[convXzSchoolByCourseNum.SchoolTypeName] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.SchoolTypeName].ToString().Trim(); //学校类型名
objvXzSchoolByCourseNumEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[convXzSchoolByCourseNum.IsCurrentUse].ToString().Trim()); //是否当前使用
objvXzSchoolByCourseNumEN.UpdDate = objRow[convXzSchoolByCourseNum.UpdDate] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.UpdDate].ToString().Trim(); //修改日期
objvXzSchoolByCourseNumEN.UpdUserId = objRow[convXzSchoolByCourseNum.UpdUserId] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.UpdUserId].ToString().Trim(); //修改用户Id
objvXzSchoolByCourseNumEN.Memo = objRow[convXzSchoolByCourseNum.Memo] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.Memo].ToString().Trim(); //备注
objvXzSchoolByCourseNumEN.CourseNum = objRow[convXzSchoolByCourseNum.CourseNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzSchoolByCourseNum.CourseNum].ToString().Trim()); //CourseNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzSchoolByCourseNumEN.IdSchool, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzSchoolByCourseNumEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvXzSchoolByCourseNumEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvXzSchoolByCourseNum(ref clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN)
{
bool bolResult = vXzSchoolByCourseNumDA.GetvXzSchoolByCourseNum(ref objvXzSchoolByCourseNumEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdSchool">表关键字</param>
 /// <returns>表对象</returns>
public static clsvXzSchoolByCourseNumEN GetObjByIdSchool(string strIdSchool)
{
if (strIdSchool.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdSchool]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdSchool) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdSchool]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN = vXzSchoolByCourseNumDA.GetObjByIdSchool(strIdSchool);
return objvXzSchoolByCourseNumEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvXzSchoolByCourseNumEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN = vXzSchoolByCourseNumDA.GetFirstObj(strWhereCond);
 return objvXzSchoolByCourseNumEN;
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
public static clsvXzSchoolByCourseNumEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN = vXzSchoolByCourseNumDA.GetObjByDataRow(objRow);
 return objvXzSchoolByCourseNumEN;
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
public static clsvXzSchoolByCourseNumEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN = vXzSchoolByCourseNumDA.GetObjByDataRow(objRow);
 return objvXzSchoolByCourseNumEN;
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
 /// <param name = "strIdSchool">所给的关键字</param>
 /// <param name = "lstvXzSchoolByCourseNumObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvXzSchoolByCourseNumEN GetObjByIdSchoolFromList(string strIdSchool, List<clsvXzSchoolByCourseNumEN> lstvXzSchoolByCourseNumObjLst)
{
foreach (clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN in lstvXzSchoolByCourseNumObjLst)
{
if (objvXzSchoolByCourseNumEN.IdSchool == strIdSchool)
{
return objvXzSchoolByCourseNumEN;
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
 string strIdSchool;
 try
 {
 strIdSchool = new clsvXzSchoolByCourseNumDA().GetFirstID(strWhereCond);
 return strIdSchool;
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
 arrList = vXzSchoolByCourseNumDA.GetID(strWhereCond);
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
bool bolIsExist = vXzSchoolByCourseNumDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdSchool">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdSchool)
{
if (string.IsNullOrEmpty(strIdSchool) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdSchool]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vXzSchoolByCourseNumDA.IsExist(strIdSchool);
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
 bolIsExist = clsvXzSchoolByCourseNumDA.IsExistTable();
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
 bolIsExist = vXzSchoolByCourseNumDA.IsExistTable(strTabName);
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
 /// <param name = "objvXzSchoolByCourseNumENS">源对象</param>
 /// <param name = "objvXzSchoolByCourseNumENT">目标对象</param>
 public static void CopyTo(clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumENS, clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumENT)
{
try
{
objvXzSchoolByCourseNumENT.IdSchool = objvXzSchoolByCourseNumENS.IdSchool; //学校流水号
objvXzSchoolByCourseNumENT.SchoolId = objvXzSchoolByCourseNumENS.SchoolId; //学校编号
objvXzSchoolByCourseNumENT.SchoolName = objvXzSchoolByCourseNumENS.SchoolName; //学校名称
objvXzSchoolByCourseNumENT.SchoolNameA = objvXzSchoolByCourseNumENS.SchoolNameA; //学校简称
objvXzSchoolByCourseNumENT.SchoolTypeId = objvXzSchoolByCourseNumENS.SchoolTypeId; //学校类型Id
objvXzSchoolByCourseNumENT.SchoolTypeName = objvXzSchoolByCourseNumENS.SchoolTypeName; //学校类型名
objvXzSchoolByCourseNumENT.IsCurrentUse = objvXzSchoolByCourseNumENS.IsCurrentUse; //是否当前使用
objvXzSchoolByCourseNumENT.UpdDate = objvXzSchoolByCourseNumENS.UpdDate; //修改日期
objvXzSchoolByCourseNumENT.UpdUserId = objvXzSchoolByCourseNumENS.UpdUserId; //修改用户Id
objvXzSchoolByCourseNumENT.Memo = objvXzSchoolByCourseNumENS.Memo; //备注
objvXzSchoolByCourseNumENT.CourseNum = objvXzSchoolByCourseNumENS.CourseNum; //CourseNum
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
 /// <param name = "objvXzSchoolByCourseNumEN">源简化对象</param>
 public static void SetUpdFlag(clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN)
{
try
{
objvXzSchoolByCourseNumEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvXzSchoolByCourseNumEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convXzSchoolByCourseNum.IdSchool, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzSchoolByCourseNumEN.IdSchool = objvXzSchoolByCourseNumEN.IdSchool; //学校流水号
}
if (arrFldSet.Contains(convXzSchoolByCourseNum.SchoolId, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzSchoolByCourseNumEN.SchoolId = objvXzSchoolByCourseNumEN.SchoolId; //学校编号
}
if (arrFldSet.Contains(convXzSchoolByCourseNum.SchoolName, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzSchoolByCourseNumEN.SchoolName = objvXzSchoolByCourseNumEN.SchoolName; //学校名称
}
if (arrFldSet.Contains(convXzSchoolByCourseNum.SchoolNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzSchoolByCourseNumEN.SchoolNameA = objvXzSchoolByCourseNumEN.SchoolNameA == "[null]" ? null :  objvXzSchoolByCourseNumEN.SchoolNameA; //学校简称
}
if (arrFldSet.Contains(convXzSchoolByCourseNum.SchoolTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzSchoolByCourseNumEN.SchoolTypeId = objvXzSchoolByCourseNumEN.SchoolTypeId == "[null]" ? null :  objvXzSchoolByCourseNumEN.SchoolTypeId; //学校类型Id
}
if (arrFldSet.Contains(convXzSchoolByCourseNum.SchoolTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzSchoolByCourseNumEN.SchoolTypeName = objvXzSchoolByCourseNumEN.SchoolTypeName == "[null]" ? null :  objvXzSchoolByCourseNumEN.SchoolTypeName; //学校类型名
}
if (arrFldSet.Contains(convXzSchoolByCourseNum.IsCurrentUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzSchoolByCourseNumEN.IsCurrentUse = objvXzSchoolByCourseNumEN.IsCurrentUse; //是否当前使用
}
if (arrFldSet.Contains(convXzSchoolByCourseNum.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzSchoolByCourseNumEN.UpdDate = objvXzSchoolByCourseNumEN.UpdDate == "[null]" ? null :  objvXzSchoolByCourseNumEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convXzSchoolByCourseNum.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzSchoolByCourseNumEN.UpdUserId = objvXzSchoolByCourseNumEN.UpdUserId == "[null]" ? null :  objvXzSchoolByCourseNumEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convXzSchoolByCourseNum.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzSchoolByCourseNumEN.Memo = objvXzSchoolByCourseNumEN.Memo == "[null]" ? null :  objvXzSchoolByCourseNumEN.Memo; //备注
}
if (arrFldSet.Contains(convXzSchoolByCourseNum.CourseNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzSchoolByCourseNumEN.CourseNum = objvXzSchoolByCourseNumEN.CourseNum; //CourseNum
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
 /// <param name = "objvXzSchoolByCourseNumEN">源简化对象</param>
 public static void AccessFldValueNull(clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN)
{
try
{
if (objvXzSchoolByCourseNumEN.SchoolNameA == "[null]") objvXzSchoolByCourseNumEN.SchoolNameA = null; //学校简称
if (objvXzSchoolByCourseNumEN.SchoolTypeId == "[null]") objvXzSchoolByCourseNumEN.SchoolTypeId = null; //学校类型Id
if (objvXzSchoolByCourseNumEN.SchoolTypeName == "[null]") objvXzSchoolByCourseNumEN.SchoolTypeName = null; //学校类型名
if (objvXzSchoolByCourseNumEN.UpdDate == "[null]") objvXzSchoolByCourseNumEN.UpdDate = null; //修改日期
if (objvXzSchoolByCourseNumEN.UpdUserId == "[null]") objvXzSchoolByCourseNumEN.UpdUserId = null; //修改用户Id
if (objvXzSchoolByCourseNumEN.Memo == "[null]") objvXzSchoolByCourseNumEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN)
{
 vXzSchoolByCourseNumDA.CheckProperty4Condition(objvXzSchoolByCourseNumEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_IdSchool(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convXzSchoolByCourseNum.IdSchool); 
List<clsvXzSchoolByCourseNumEN> arrObjLst = clsvXzSchoolByCourseNumBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN = new clsvXzSchoolByCourseNumEN()
{
IdSchool = "0",
SchoolName = "选[vXzSchoolByCourseNum]..."
};
arrObjLst.Insert(0, objvXzSchoolByCourseNumEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convXzSchoolByCourseNum.IdSchool;
objComboBox.DisplayMember = convXzSchoolByCourseNum.SchoolName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_IdSchool(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vXzSchoolByCourseNum]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convXzSchoolByCourseNum.IdSchool); 
IEnumerable<clsvXzSchoolByCourseNumEN> arrObjLst = clsvXzSchoolByCourseNumBL.GetObjLst(strCondition);
objDDL.DataValueField = convXzSchoolByCourseNum.IdSchool;
objDDL.DataTextField = convXzSchoolByCourseNum.SchoolName;
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
public static void BindDdl_IdSchoolCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vXzSchoolByCourseNum]...","0");
List<clsvXzSchoolByCourseNumEN> arrvXzSchoolByCourseNumObjLst = GetAllvXzSchoolByCourseNumObjLstCache(); 
objDDL.DataValueField = convXzSchoolByCourseNum.IdSchool;
objDDL.DataTextField = convXzSchoolByCourseNum.SchoolName;
objDDL.DataSource = arrvXzSchoolByCourseNumObjLst;
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
if (clsXzSchoolBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzSchoolBL没有刷新缓存机制(clsXzSchoolBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSchoolTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSchoolTypeBL没有刷新缓存机制(clsSchoolTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdSchool");
//if (arrvXzSchoolByCourseNumObjLstCache == null)
//{
//arrvXzSchoolByCourseNumObjLstCache = vXzSchoolByCourseNumDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdSchool">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvXzSchoolByCourseNumEN GetObjByIdSchoolCache(string strIdSchool)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvXzSchoolByCourseNumEN._CurrTabName);
List<clsvXzSchoolByCourseNumEN> arrvXzSchoolByCourseNumObjLstCache = GetObjLstCache();
IEnumerable <clsvXzSchoolByCourseNumEN> arrvXzSchoolByCourseNumObjLst_Sel =
arrvXzSchoolByCourseNumObjLstCache
.Where(x=> x.IdSchool == strIdSchool 
);
if (arrvXzSchoolByCourseNumObjLst_Sel.Count() == 0)
{
   clsvXzSchoolByCourseNumEN obj = clsvXzSchoolByCourseNumBL.GetObjByIdSchool(strIdSchool);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvXzSchoolByCourseNumObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdSchool">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetSchoolNameByIdSchoolCache(string strIdSchool)
{
if (string.IsNullOrEmpty(strIdSchool) == true) return "";
//获取缓存中的对象列表
clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNum = GetObjByIdSchoolCache(strIdSchool);
if (objvXzSchoolByCourseNum == null) return "";
return objvXzSchoolByCourseNum.SchoolName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdSchool">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByIdSchoolCache(string strIdSchool)
{
if (string.IsNullOrEmpty(strIdSchool) == true) return "";
//获取缓存中的对象列表
clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNum = GetObjByIdSchoolCache(strIdSchool);
if (objvXzSchoolByCourseNum == null) return "";
return objvXzSchoolByCourseNum.SchoolName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvXzSchoolByCourseNumEN> GetAllvXzSchoolByCourseNumObjLstCache()
{
//获取缓存中的对象列表
List<clsvXzSchoolByCourseNumEN> arrvXzSchoolByCourseNumObjLstCache = GetObjLstCache(); 
return arrvXzSchoolByCourseNumObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvXzSchoolByCourseNumEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvXzSchoolByCourseNumEN._CurrTabName);
List<clsvXzSchoolByCourseNumEN> arrvXzSchoolByCourseNumObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvXzSchoolByCourseNumObjLstCache;
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
string strKey = string.Format("{0}", clsvXzSchoolByCourseNumEN._CurrTabName);
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
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strIdSchool)
{
if (strInFldName != convXzSchoolByCourseNum.IdSchool)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convXzSchoolByCourseNum.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convXzSchoolByCourseNum.AttributeName));
throw new Exception(strMsg);
}
var objvXzSchoolByCourseNum = clsvXzSchoolByCourseNumBL.GetObjByIdSchoolCache(strIdSchool);
if (objvXzSchoolByCourseNum == null) return "";
return objvXzSchoolByCourseNum[strOutFldName].ToString();
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
int intRecCount = clsvXzSchoolByCourseNumDA.GetRecCount(strTabName);
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
int intRecCount = clsvXzSchoolByCourseNumDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvXzSchoolByCourseNumDA.GetRecCount();
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
int intRecCount = clsvXzSchoolByCourseNumDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvXzSchoolByCourseNumCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumCond)
{
List<clsvXzSchoolByCourseNumEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvXzSchoolByCourseNumEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convXzSchoolByCourseNum.AttributeName)
{
if (objvXzSchoolByCourseNumCond.IsUpdated(strFldName) == false) continue;
if (objvXzSchoolByCourseNumCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvXzSchoolByCourseNumCond[strFldName].ToString());
}
else
{
if (objvXzSchoolByCourseNumCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvXzSchoolByCourseNumCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvXzSchoolByCourseNumCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvXzSchoolByCourseNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvXzSchoolByCourseNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvXzSchoolByCourseNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvXzSchoolByCourseNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvXzSchoolByCourseNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvXzSchoolByCourseNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvXzSchoolByCourseNumCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvXzSchoolByCourseNumCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvXzSchoolByCourseNumCond[strFldName]));
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
 List<string> arrList = clsvXzSchoolByCourseNumDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vXzSchoolByCourseNumDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vXzSchoolByCourseNumDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}