
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_CourseSchoolRelationBL
 表名:vcc_CourseSchoolRelation(01120334)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 14:55:53
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程管理(CourseManage)
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
public static class  clsvcc_CourseSchoolRelationBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_CourseSchoolRelationEN GetObj(this K_mId_vcc_CourseSchoolRelation myKey)
{
clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationEN = clsvcc_CourseSchoolRelationBL.vcc_CourseSchoolRelationDA.GetObjBymId(myKey.Value);
return objvcc_CourseSchoolRelationEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseSchoolRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseSchoolRelationEN SetmId(this clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationEN, long lngmId, string strComparisonOp="")
	{
objvcc_CourseSchoolRelationEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseSchoolRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseSchoolRelation.mId) == false)
{
objvcc_CourseSchoolRelationEN.dicFldComparisonOp.Add(convcc_CourseSchoolRelation.mId, strComparisonOp);
}
else
{
objvcc_CourseSchoolRelationEN.dicFldComparisonOp[convcc_CourseSchoolRelation.mId] = strComparisonOp;
}
}
return objvcc_CourseSchoolRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseSchoolRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseSchoolRelationEN SetIdSchool(this clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationEN, string strIdSchool, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSchool, 4, convcc_CourseSchoolRelation.IdSchool);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSchool, 4, convcc_CourseSchoolRelation.IdSchool);
}
objvcc_CourseSchoolRelationEN.IdSchool = strIdSchool; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseSchoolRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseSchoolRelation.IdSchool) == false)
{
objvcc_CourseSchoolRelationEN.dicFldComparisonOp.Add(convcc_CourseSchoolRelation.IdSchool, strComparisonOp);
}
else
{
objvcc_CourseSchoolRelationEN.dicFldComparisonOp[convcc_CourseSchoolRelation.IdSchool] = strComparisonOp;
}
}
return objvcc_CourseSchoolRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseSchoolRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseSchoolRelationEN SetSchoolId(this clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationEN, string strSchoolId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolId, 10, convcc_CourseSchoolRelation.SchoolId);
}
objvcc_CourseSchoolRelationEN.SchoolId = strSchoolId; //学校编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseSchoolRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseSchoolRelation.SchoolId) == false)
{
objvcc_CourseSchoolRelationEN.dicFldComparisonOp.Add(convcc_CourseSchoolRelation.SchoolId, strComparisonOp);
}
else
{
objvcc_CourseSchoolRelationEN.dicFldComparisonOp[convcc_CourseSchoolRelation.SchoolId] = strComparisonOp;
}
}
return objvcc_CourseSchoolRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseSchoolRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseSchoolRelationEN SetSchoolName(this clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationEN, string strSchoolName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolName, 50, convcc_CourseSchoolRelation.SchoolName);
}
objvcc_CourseSchoolRelationEN.SchoolName = strSchoolName; //学校名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseSchoolRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseSchoolRelation.SchoolName) == false)
{
objvcc_CourseSchoolRelationEN.dicFldComparisonOp.Add(convcc_CourseSchoolRelation.SchoolName, strComparisonOp);
}
else
{
objvcc_CourseSchoolRelationEN.dicFldComparisonOp[convcc_CourseSchoolRelation.SchoolName] = strComparisonOp;
}
}
return objvcc_CourseSchoolRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseSchoolRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseSchoolRelationEN SetSchoolNameA(this clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationEN, string strSchoolNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolNameA, 14, convcc_CourseSchoolRelation.SchoolNameA);
}
objvcc_CourseSchoolRelationEN.SchoolNameA = strSchoolNameA; //学校简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseSchoolRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseSchoolRelation.SchoolNameA) == false)
{
objvcc_CourseSchoolRelationEN.dicFldComparisonOp.Add(convcc_CourseSchoolRelation.SchoolNameA, strComparisonOp);
}
else
{
objvcc_CourseSchoolRelationEN.dicFldComparisonOp[convcc_CourseSchoolRelation.SchoolNameA] = strComparisonOp;
}
}
return objvcc_CourseSchoolRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseSchoolRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseSchoolRelationEN SetCourseId(this clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_CourseSchoolRelation.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_CourseSchoolRelation.CourseId);
}
objvcc_CourseSchoolRelationEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseSchoolRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseSchoolRelation.CourseId) == false)
{
objvcc_CourseSchoolRelationEN.dicFldComparisonOp.Add(convcc_CourseSchoolRelation.CourseId, strComparisonOp);
}
else
{
objvcc_CourseSchoolRelationEN.dicFldComparisonOp[convcc_CourseSchoolRelation.CourseId] = strComparisonOp;
}
}
return objvcc_CourseSchoolRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseSchoolRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseSchoolRelationEN SetCourseName(this clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_CourseSchoolRelation.CourseName);
}
objvcc_CourseSchoolRelationEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseSchoolRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseSchoolRelation.CourseName) == false)
{
objvcc_CourseSchoolRelationEN.dicFldComparisonOp.Add(convcc_CourseSchoolRelation.CourseName, strComparisonOp);
}
else
{
objvcc_CourseSchoolRelationEN.dicFldComparisonOp[convcc_CourseSchoolRelation.CourseName] = strComparisonOp;
}
}
return objvcc_CourseSchoolRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseSchoolRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseSchoolRelationEN SetOrderNum(this clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationEN, int? intOrderNum, string strComparisonOp="")
	{
objvcc_CourseSchoolRelationEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseSchoolRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseSchoolRelation.OrderNum) == false)
{
objvcc_CourseSchoolRelationEN.dicFldComparisonOp.Add(convcc_CourseSchoolRelation.OrderNum, strComparisonOp);
}
else
{
objvcc_CourseSchoolRelationEN.dicFldComparisonOp[convcc_CourseSchoolRelation.OrderNum] = strComparisonOp;
}
}
return objvcc_CourseSchoolRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseSchoolRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseSchoolRelationEN SetUpdDate(this clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convcc_CourseSchoolRelation.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_CourseSchoolRelation.UpdDate);
}
objvcc_CourseSchoolRelationEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseSchoolRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseSchoolRelation.UpdDate) == false)
{
objvcc_CourseSchoolRelationEN.dicFldComparisonOp.Add(convcc_CourseSchoolRelation.UpdDate, strComparisonOp);
}
else
{
objvcc_CourseSchoolRelationEN.dicFldComparisonOp[convcc_CourseSchoolRelation.UpdDate] = strComparisonOp;
}
}
return objvcc_CourseSchoolRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseSchoolRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseSchoolRelationEN SetUpdUser(this clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convcc_CourseSchoolRelation.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convcc_CourseSchoolRelation.UpdUser);
}
objvcc_CourseSchoolRelationEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseSchoolRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseSchoolRelation.UpdUser) == false)
{
objvcc_CourseSchoolRelationEN.dicFldComparisonOp.Add(convcc_CourseSchoolRelation.UpdUser, strComparisonOp);
}
else
{
objvcc_CourseSchoolRelationEN.dicFldComparisonOp[convcc_CourseSchoolRelation.UpdUser] = strComparisonOp;
}
}
return objvcc_CourseSchoolRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseSchoolRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseSchoolRelationEN SetMemo(this clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_CourseSchoolRelation.Memo);
}
objvcc_CourseSchoolRelationEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseSchoolRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseSchoolRelation.Memo) == false)
{
objvcc_CourseSchoolRelationEN.dicFldComparisonOp.Add(convcc_CourseSchoolRelation.Memo, strComparisonOp);
}
else
{
objvcc_CourseSchoolRelationEN.dicFldComparisonOp[convcc_CourseSchoolRelation.Memo] = strComparisonOp;
}
}
return objvcc_CourseSchoolRelationEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvcc_CourseSchoolRelationENS">源对象</param>
 /// <param name = "objvcc_CourseSchoolRelationENT">目标对象</param>
 public static void CopyTo(this clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationENS, clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationENT)
{
try
{
objvcc_CourseSchoolRelationENT.mId = objvcc_CourseSchoolRelationENS.mId; //mId
objvcc_CourseSchoolRelationENT.IdSchool = objvcc_CourseSchoolRelationENS.IdSchool; //学校流水号
objvcc_CourseSchoolRelationENT.SchoolId = objvcc_CourseSchoolRelationENS.SchoolId; //学校编号
objvcc_CourseSchoolRelationENT.SchoolName = objvcc_CourseSchoolRelationENS.SchoolName; //学校名称
objvcc_CourseSchoolRelationENT.SchoolNameA = objvcc_CourseSchoolRelationENS.SchoolNameA; //学校简称
objvcc_CourseSchoolRelationENT.CourseId = objvcc_CourseSchoolRelationENS.CourseId; //课程Id
objvcc_CourseSchoolRelationENT.CourseName = objvcc_CourseSchoolRelationENS.CourseName; //课程名称
objvcc_CourseSchoolRelationENT.OrderNum = objvcc_CourseSchoolRelationENS.OrderNum; //序号
objvcc_CourseSchoolRelationENT.UpdDate = objvcc_CourseSchoolRelationENS.UpdDate; //修改日期
objvcc_CourseSchoolRelationENT.UpdUser = objvcc_CourseSchoolRelationENS.UpdUser; //修改人
objvcc_CourseSchoolRelationENT.Memo = objvcc_CourseSchoolRelationENS.Memo; //备注
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
 /// <param name = "objvcc_CourseSchoolRelationENS">源对象</param>
 /// <returns>目标对象=>clsvcc_CourseSchoolRelationEN:objvcc_CourseSchoolRelationENT</returns>
 public static clsvcc_CourseSchoolRelationEN CopyTo(this clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationENS)
{
try
{
 clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationENT = new clsvcc_CourseSchoolRelationEN()
{
mId = objvcc_CourseSchoolRelationENS.mId, //mId
IdSchool = objvcc_CourseSchoolRelationENS.IdSchool, //学校流水号
SchoolId = objvcc_CourseSchoolRelationENS.SchoolId, //学校编号
SchoolName = objvcc_CourseSchoolRelationENS.SchoolName, //学校名称
SchoolNameA = objvcc_CourseSchoolRelationENS.SchoolNameA, //学校简称
CourseId = objvcc_CourseSchoolRelationENS.CourseId, //课程Id
CourseName = objvcc_CourseSchoolRelationENS.CourseName, //课程名称
OrderNum = objvcc_CourseSchoolRelationENS.OrderNum, //序号
UpdDate = objvcc_CourseSchoolRelationENS.UpdDate, //修改日期
UpdUser = objvcc_CourseSchoolRelationENS.UpdUser, //修改人
Memo = objvcc_CourseSchoolRelationENS.Memo, //备注
};
 return objvcc_CourseSchoolRelationENT;
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
public static void CheckProperty4Condition(this clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationEN)
{
 clsvcc_CourseSchoolRelationBL.vcc_CourseSchoolRelationDA.CheckProperty4Condition(objvcc_CourseSchoolRelationEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_CourseSchoolRelationCond.IsUpdated(convcc_CourseSchoolRelation.mId) == true)
{
string strComparisonOpmId = objvcc_CourseSchoolRelationCond.dicFldComparisonOp[convcc_CourseSchoolRelation.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseSchoolRelation.mId, objvcc_CourseSchoolRelationCond.mId, strComparisonOpmId);
}
if (objvcc_CourseSchoolRelationCond.IsUpdated(convcc_CourseSchoolRelation.IdSchool) == true)
{
string strComparisonOpIdSchool = objvcc_CourseSchoolRelationCond.dicFldComparisonOp[convcc_CourseSchoolRelation.IdSchool];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseSchoolRelation.IdSchool, objvcc_CourseSchoolRelationCond.IdSchool, strComparisonOpIdSchool);
}
if (objvcc_CourseSchoolRelationCond.IsUpdated(convcc_CourseSchoolRelation.SchoolId) == true)
{
string strComparisonOpSchoolId = objvcc_CourseSchoolRelationCond.dicFldComparisonOp[convcc_CourseSchoolRelation.SchoolId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseSchoolRelation.SchoolId, objvcc_CourseSchoolRelationCond.SchoolId, strComparisonOpSchoolId);
}
if (objvcc_CourseSchoolRelationCond.IsUpdated(convcc_CourseSchoolRelation.SchoolName) == true)
{
string strComparisonOpSchoolName = objvcc_CourseSchoolRelationCond.dicFldComparisonOp[convcc_CourseSchoolRelation.SchoolName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseSchoolRelation.SchoolName, objvcc_CourseSchoolRelationCond.SchoolName, strComparisonOpSchoolName);
}
if (objvcc_CourseSchoolRelationCond.IsUpdated(convcc_CourseSchoolRelation.SchoolNameA) == true)
{
string strComparisonOpSchoolNameA = objvcc_CourseSchoolRelationCond.dicFldComparisonOp[convcc_CourseSchoolRelation.SchoolNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseSchoolRelation.SchoolNameA, objvcc_CourseSchoolRelationCond.SchoolNameA, strComparisonOpSchoolNameA);
}
if (objvcc_CourseSchoolRelationCond.IsUpdated(convcc_CourseSchoolRelation.CourseId) == true)
{
string strComparisonOpCourseId = objvcc_CourseSchoolRelationCond.dicFldComparisonOp[convcc_CourseSchoolRelation.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseSchoolRelation.CourseId, objvcc_CourseSchoolRelationCond.CourseId, strComparisonOpCourseId);
}
if (objvcc_CourseSchoolRelationCond.IsUpdated(convcc_CourseSchoolRelation.CourseName) == true)
{
string strComparisonOpCourseName = objvcc_CourseSchoolRelationCond.dicFldComparisonOp[convcc_CourseSchoolRelation.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseSchoolRelation.CourseName, objvcc_CourseSchoolRelationCond.CourseName, strComparisonOpCourseName);
}
if (objvcc_CourseSchoolRelationCond.IsUpdated(convcc_CourseSchoolRelation.OrderNum) == true)
{
string strComparisonOpOrderNum = objvcc_CourseSchoolRelationCond.dicFldComparisonOp[convcc_CourseSchoolRelation.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseSchoolRelation.OrderNum, objvcc_CourseSchoolRelationCond.OrderNum, strComparisonOpOrderNum);
}
if (objvcc_CourseSchoolRelationCond.IsUpdated(convcc_CourseSchoolRelation.UpdDate) == true)
{
string strComparisonOpUpdDate = objvcc_CourseSchoolRelationCond.dicFldComparisonOp[convcc_CourseSchoolRelation.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseSchoolRelation.UpdDate, objvcc_CourseSchoolRelationCond.UpdDate, strComparisonOpUpdDate);
}
if (objvcc_CourseSchoolRelationCond.IsUpdated(convcc_CourseSchoolRelation.UpdUser) == true)
{
string strComparisonOpUpdUser = objvcc_CourseSchoolRelationCond.dicFldComparisonOp[convcc_CourseSchoolRelation.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseSchoolRelation.UpdUser, objvcc_CourseSchoolRelationCond.UpdUser, strComparisonOpUpdUser);
}
if (objvcc_CourseSchoolRelationCond.IsUpdated(convcc_CourseSchoolRelation.Memo) == true)
{
string strComparisonOpMemo = objvcc_CourseSchoolRelationCond.dicFldComparisonOp[convcc_CourseSchoolRelation.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseSchoolRelation.Memo, objvcc_CourseSchoolRelationCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vcc_CourseSchoolRelation
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v课程和学校关系(vcc_CourseSchoolRelation)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvcc_CourseSchoolRelationBL
{
public static RelatedActions_vcc_CourseSchoolRelation relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvcc_CourseSchoolRelationDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvcc_CourseSchoolRelationDA vcc_CourseSchoolRelationDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvcc_CourseSchoolRelationDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvcc_CourseSchoolRelationBL()
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
if (string.IsNullOrEmpty(clsvcc_CourseSchoolRelationEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvcc_CourseSchoolRelationEN._ConnectString);
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
public static DataTable GetDataTable_vcc_CourseSchoolRelation(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vcc_CourseSchoolRelationDA.GetDataTable_vcc_CourseSchoolRelation(strWhereCond);
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
objDT = vcc_CourseSchoolRelationDA.GetDataTable(strWhereCond);
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
objDT = vcc_CourseSchoolRelationDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vcc_CourseSchoolRelationDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vcc_CourseSchoolRelationDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vcc_CourseSchoolRelationDA.GetDataTable_Top(objTopPara);
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
objDT = vcc_CourseSchoolRelationDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vcc_CourseSchoolRelationDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vcc_CourseSchoolRelationDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvcc_CourseSchoolRelationEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvcc_CourseSchoolRelationEN> arrObjLst = new List<clsvcc_CourseSchoolRelationEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMIdLst);
 string strWhereCond = string.Format("mId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationEN = new clsvcc_CourseSchoolRelationEN();
try
{
objvcc_CourseSchoolRelationEN.mId = Int32.Parse(objRow[convcc_CourseSchoolRelation.mId].ToString().Trim()); //mId
objvcc_CourseSchoolRelationEN.IdSchool = objRow[convcc_CourseSchoolRelation.IdSchool] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.IdSchool].ToString().Trim(); //学校流水号
objvcc_CourseSchoolRelationEN.SchoolId = objRow[convcc_CourseSchoolRelation.SchoolId] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.SchoolId].ToString().Trim(); //学校编号
objvcc_CourseSchoolRelationEN.SchoolName = objRow[convcc_CourseSchoolRelation.SchoolName] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.SchoolName].ToString().Trim(); //学校名称
objvcc_CourseSchoolRelationEN.SchoolNameA = objRow[convcc_CourseSchoolRelation.SchoolNameA] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.SchoolNameA].ToString().Trim(); //学校简称
objvcc_CourseSchoolRelationEN.CourseId = objRow[convcc_CourseSchoolRelation.CourseId] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.CourseId].ToString().Trim(); //课程Id
objvcc_CourseSchoolRelationEN.CourseName = objRow[convcc_CourseSchoolRelation.CourseName] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.CourseName].ToString().Trim(); //课程名称
objvcc_CourseSchoolRelationEN.OrderNum = objRow[convcc_CourseSchoolRelation.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseSchoolRelation.OrderNum].ToString().Trim()); //序号
objvcc_CourseSchoolRelationEN.UpdDate = objRow[convcc_CourseSchoolRelation.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseSchoolRelationEN.UpdUser = objRow[convcc_CourseSchoolRelation.UpdUser].ToString().Trim(); //修改人
objvcc_CourseSchoolRelationEN.Memo = objRow[convcc_CourseSchoolRelation.Memo] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseSchoolRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseSchoolRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvcc_CourseSchoolRelationEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvcc_CourseSchoolRelationEN._CurrTabName);
List<clsvcc_CourseSchoolRelationEN> arrvcc_CourseSchoolRelationObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_CourseSchoolRelationEN> arrvcc_CourseSchoolRelationObjLst_Sel =
arrvcc_CourseSchoolRelationObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvcc_CourseSchoolRelationObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseSchoolRelationEN> GetObjLst(string strWhereCond)
{
List<clsvcc_CourseSchoolRelationEN> arrObjLst = new List<clsvcc_CourseSchoolRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationEN = new clsvcc_CourseSchoolRelationEN();
try
{
objvcc_CourseSchoolRelationEN.mId = Int32.Parse(objRow[convcc_CourseSchoolRelation.mId].ToString().Trim()); //mId
objvcc_CourseSchoolRelationEN.IdSchool = objRow[convcc_CourseSchoolRelation.IdSchool] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.IdSchool].ToString().Trim(); //学校流水号
objvcc_CourseSchoolRelationEN.SchoolId = objRow[convcc_CourseSchoolRelation.SchoolId] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.SchoolId].ToString().Trim(); //学校编号
objvcc_CourseSchoolRelationEN.SchoolName = objRow[convcc_CourseSchoolRelation.SchoolName] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.SchoolName].ToString().Trim(); //学校名称
objvcc_CourseSchoolRelationEN.SchoolNameA = objRow[convcc_CourseSchoolRelation.SchoolNameA] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.SchoolNameA].ToString().Trim(); //学校简称
objvcc_CourseSchoolRelationEN.CourseId = objRow[convcc_CourseSchoolRelation.CourseId] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.CourseId].ToString().Trim(); //课程Id
objvcc_CourseSchoolRelationEN.CourseName = objRow[convcc_CourseSchoolRelation.CourseName] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.CourseName].ToString().Trim(); //课程名称
objvcc_CourseSchoolRelationEN.OrderNum = objRow[convcc_CourseSchoolRelation.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseSchoolRelation.OrderNum].ToString().Trim()); //序号
objvcc_CourseSchoolRelationEN.UpdDate = objRow[convcc_CourseSchoolRelation.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseSchoolRelationEN.UpdUser = objRow[convcc_CourseSchoolRelation.UpdUser].ToString().Trim(); //修改人
objvcc_CourseSchoolRelationEN.Memo = objRow[convcc_CourseSchoolRelation.Memo] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseSchoolRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseSchoolRelationEN);
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
public static List<clsvcc_CourseSchoolRelationEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvcc_CourseSchoolRelationEN> arrObjLst = new List<clsvcc_CourseSchoolRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationEN = new clsvcc_CourseSchoolRelationEN();
try
{
objvcc_CourseSchoolRelationEN.mId = Int32.Parse(objRow[convcc_CourseSchoolRelation.mId].ToString().Trim()); //mId
objvcc_CourseSchoolRelationEN.IdSchool = objRow[convcc_CourseSchoolRelation.IdSchool] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.IdSchool].ToString().Trim(); //学校流水号
objvcc_CourseSchoolRelationEN.SchoolId = objRow[convcc_CourseSchoolRelation.SchoolId] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.SchoolId].ToString().Trim(); //学校编号
objvcc_CourseSchoolRelationEN.SchoolName = objRow[convcc_CourseSchoolRelation.SchoolName] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.SchoolName].ToString().Trim(); //学校名称
objvcc_CourseSchoolRelationEN.SchoolNameA = objRow[convcc_CourseSchoolRelation.SchoolNameA] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.SchoolNameA].ToString().Trim(); //学校简称
objvcc_CourseSchoolRelationEN.CourseId = objRow[convcc_CourseSchoolRelation.CourseId] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.CourseId].ToString().Trim(); //课程Id
objvcc_CourseSchoolRelationEN.CourseName = objRow[convcc_CourseSchoolRelation.CourseName] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.CourseName].ToString().Trim(); //课程名称
objvcc_CourseSchoolRelationEN.OrderNum = objRow[convcc_CourseSchoolRelation.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseSchoolRelation.OrderNum].ToString().Trim()); //序号
objvcc_CourseSchoolRelationEN.UpdDate = objRow[convcc_CourseSchoolRelation.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseSchoolRelationEN.UpdUser = objRow[convcc_CourseSchoolRelation.UpdUser].ToString().Trim(); //修改人
objvcc_CourseSchoolRelationEN.Memo = objRow[convcc_CourseSchoolRelation.Memo] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseSchoolRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseSchoolRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvcc_CourseSchoolRelationCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvcc_CourseSchoolRelationEN> GetSubObjLstCache(clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationCond)
{
List<clsvcc_CourseSchoolRelationEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_CourseSchoolRelationEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_CourseSchoolRelation.AttributeName)
{
if (objvcc_CourseSchoolRelationCond.IsUpdated(strFldName) == false) continue;
if (objvcc_CourseSchoolRelationCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseSchoolRelationCond[strFldName].ToString());
}
else
{
if (objvcc_CourseSchoolRelationCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_CourseSchoolRelationCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseSchoolRelationCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_CourseSchoolRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_CourseSchoolRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_CourseSchoolRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_CourseSchoolRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_CourseSchoolRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_CourseSchoolRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_CourseSchoolRelationCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_CourseSchoolRelationCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_CourseSchoolRelationCond[strFldName]));
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
public static List<clsvcc_CourseSchoolRelationEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvcc_CourseSchoolRelationEN> arrObjLst = new List<clsvcc_CourseSchoolRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationEN = new clsvcc_CourseSchoolRelationEN();
try
{
objvcc_CourseSchoolRelationEN.mId = Int32.Parse(objRow[convcc_CourseSchoolRelation.mId].ToString().Trim()); //mId
objvcc_CourseSchoolRelationEN.IdSchool = objRow[convcc_CourseSchoolRelation.IdSchool] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.IdSchool].ToString().Trim(); //学校流水号
objvcc_CourseSchoolRelationEN.SchoolId = objRow[convcc_CourseSchoolRelation.SchoolId] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.SchoolId].ToString().Trim(); //学校编号
objvcc_CourseSchoolRelationEN.SchoolName = objRow[convcc_CourseSchoolRelation.SchoolName] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.SchoolName].ToString().Trim(); //学校名称
objvcc_CourseSchoolRelationEN.SchoolNameA = objRow[convcc_CourseSchoolRelation.SchoolNameA] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.SchoolNameA].ToString().Trim(); //学校简称
objvcc_CourseSchoolRelationEN.CourseId = objRow[convcc_CourseSchoolRelation.CourseId] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.CourseId].ToString().Trim(); //课程Id
objvcc_CourseSchoolRelationEN.CourseName = objRow[convcc_CourseSchoolRelation.CourseName] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.CourseName].ToString().Trim(); //课程名称
objvcc_CourseSchoolRelationEN.OrderNum = objRow[convcc_CourseSchoolRelation.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseSchoolRelation.OrderNum].ToString().Trim()); //序号
objvcc_CourseSchoolRelationEN.UpdDate = objRow[convcc_CourseSchoolRelation.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseSchoolRelationEN.UpdUser = objRow[convcc_CourseSchoolRelation.UpdUser].ToString().Trim(); //修改人
objvcc_CourseSchoolRelationEN.Memo = objRow[convcc_CourseSchoolRelation.Memo] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseSchoolRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseSchoolRelationEN);
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
public static List<clsvcc_CourseSchoolRelationEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvcc_CourseSchoolRelationEN> arrObjLst = new List<clsvcc_CourseSchoolRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationEN = new clsvcc_CourseSchoolRelationEN();
try
{
objvcc_CourseSchoolRelationEN.mId = Int32.Parse(objRow[convcc_CourseSchoolRelation.mId].ToString().Trim()); //mId
objvcc_CourseSchoolRelationEN.IdSchool = objRow[convcc_CourseSchoolRelation.IdSchool] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.IdSchool].ToString().Trim(); //学校流水号
objvcc_CourseSchoolRelationEN.SchoolId = objRow[convcc_CourseSchoolRelation.SchoolId] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.SchoolId].ToString().Trim(); //学校编号
objvcc_CourseSchoolRelationEN.SchoolName = objRow[convcc_CourseSchoolRelation.SchoolName] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.SchoolName].ToString().Trim(); //学校名称
objvcc_CourseSchoolRelationEN.SchoolNameA = objRow[convcc_CourseSchoolRelation.SchoolNameA] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.SchoolNameA].ToString().Trim(); //学校简称
objvcc_CourseSchoolRelationEN.CourseId = objRow[convcc_CourseSchoolRelation.CourseId] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.CourseId].ToString().Trim(); //课程Id
objvcc_CourseSchoolRelationEN.CourseName = objRow[convcc_CourseSchoolRelation.CourseName] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.CourseName].ToString().Trim(); //课程名称
objvcc_CourseSchoolRelationEN.OrderNum = objRow[convcc_CourseSchoolRelation.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseSchoolRelation.OrderNum].ToString().Trim()); //序号
objvcc_CourseSchoolRelationEN.UpdDate = objRow[convcc_CourseSchoolRelation.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseSchoolRelationEN.UpdUser = objRow[convcc_CourseSchoolRelation.UpdUser].ToString().Trim(); //修改人
objvcc_CourseSchoolRelationEN.Memo = objRow[convcc_CourseSchoolRelation.Memo] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseSchoolRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseSchoolRelationEN);
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
List<clsvcc_CourseSchoolRelationEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvcc_CourseSchoolRelationEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseSchoolRelationEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvcc_CourseSchoolRelationEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_CourseSchoolRelationEN> arrObjLst = new List<clsvcc_CourseSchoolRelationEN>(); 
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
	clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationEN = new clsvcc_CourseSchoolRelationEN();
try
{
objvcc_CourseSchoolRelationEN.mId = Int32.Parse(objRow[convcc_CourseSchoolRelation.mId].ToString().Trim()); //mId
objvcc_CourseSchoolRelationEN.IdSchool = objRow[convcc_CourseSchoolRelation.IdSchool] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.IdSchool].ToString().Trim(); //学校流水号
objvcc_CourseSchoolRelationEN.SchoolId = objRow[convcc_CourseSchoolRelation.SchoolId] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.SchoolId].ToString().Trim(); //学校编号
objvcc_CourseSchoolRelationEN.SchoolName = objRow[convcc_CourseSchoolRelation.SchoolName] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.SchoolName].ToString().Trim(); //学校名称
objvcc_CourseSchoolRelationEN.SchoolNameA = objRow[convcc_CourseSchoolRelation.SchoolNameA] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.SchoolNameA].ToString().Trim(); //学校简称
objvcc_CourseSchoolRelationEN.CourseId = objRow[convcc_CourseSchoolRelation.CourseId] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.CourseId].ToString().Trim(); //课程Id
objvcc_CourseSchoolRelationEN.CourseName = objRow[convcc_CourseSchoolRelation.CourseName] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.CourseName].ToString().Trim(); //课程名称
objvcc_CourseSchoolRelationEN.OrderNum = objRow[convcc_CourseSchoolRelation.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseSchoolRelation.OrderNum].ToString().Trim()); //序号
objvcc_CourseSchoolRelationEN.UpdDate = objRow[convcc_CourseSchoolRelation.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseSchoolRelationEN.UpdUser = objRow[convcc_CourseSchoolRelation.UpdUser].ToString().Trim(); //修改人
objvcc_CourseSchoolRelationEN.Memo = objRow[convcc_CourseSchoolRelation.Memo] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseSchoolRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseSchoolRelationEN);
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
public static List<clsvcc_CourseSchoolRelationEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvcc_CourseSchoolRelationEN> arrObjLst = new List<clsvcc_CourseSchoolRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationEN = new clsvcc_CourseSchoolRelationEN();
try
{
objvcc_CourseSchoolRelationEN.mId = Int32.Parse(objRow[convcc_CourseSchoolRelation.mId].ToString().Trim()); //mId
objvcc_CourseSchoolRelationEN.IdSchool = objRow[convcc_CourseSchoolRelation.IdSchool] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.IdSchool].ToString().Trim(); //学校流水号
objvcc_CourseSchoolRelationEN.SchoolId = objRow[convcc_CourseSchoolRelation.SchoolId] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.SchoolId].ToString().Trim(); //学校编号
objvcc_CourseSchoolRelationEN.SchoolName = objRow[convcc_CourseSchoolRelation.SchoolName] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.SchoolName].ToString().Trim(); //学校名称
objvcc_CourseSchoolRelationEN.SchoolNameA = objRow[convcc_CourseSchoolRelation.SchoolNameA] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.SchoolNameA].ToString().Trim(); //学校简称
objvcc_CourseSchoolRelationEN.CourseId = objRow[convcc_CourseSchoolRelation.CourseId] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.CourseId].ToString().Trim(); //课程Id
objvcc_CourseSchoolRelationEN.CourseName = objRow[convcc_CourseSchoolRelation.CourseName] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.CourseName].ToString().Trim(); //课程名称
objvcc_CourseSchoolRelationEN.OrderNum = objRow[convcc_CourseSchoolRelation.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseSchoolRelation.OrderNum].ToString().Trim()); //序号
objvcc_CourseSchoolRelationEN.UpdDate = objRow[convcc_CourseSchoolRelation.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseSchoolRelationEN.UpdUser = objRow[convcc_CourseSchoolRelation.UpdUser].ToString().Trim(); //修改人
objvcc_CourseSchoolRelationEN.Memo = objRow[convcc_CourseSchoolRelation.Memo] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseSchoolRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseSchoolRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvcc_CourseSchoolRelationEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvcc_CourseSchoolRelationEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_CourseSchoolRelationEN> arrObjLst = new List<clsvcc_CourseSchoolRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationEN = new clsvcc_CourseSchoolRelationEN();
try
{
objvcc_CourseSchoolRelationEN.mId = Int32.Parse(objRow[convcc_CourseSchoolRelation.mId].ToString().Trim()); //mId
objvcc_CourseSchoolRelationEN.IdSchool = objRow[convcc_CourseSchoolRelation.IdSchool] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.IdSchool].ToString().Trim(); //学校流水号
objvcc_CourseSchoolRelationEN.SchoolId = objRow[convcc_CourseSchoolRelation.SchoolId] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.SchoolId].ToString().Trim(); //学校编号
objvcc_CourseSchoolRelationEN.SchoolName = objRow[convcc_CourseSchoolRelation.SchoolName] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.SchoolName].ToString().Trim(); //学校名称
objvcc_CourseSchoolRelationEN.SchoolNameA = objRow[convcc_CourseSchoolRelation.SchoolNameA] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.SchoolNameA].ToString().Trim(); //学校简称
objvcc_CourseSchoolRelationEN.CourseId = objRow[convcc_CourseSchoolRelation.CourseId] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.CourseId].ToString().Trim(); //课程Id
objvcc_CourseSchoolRelationEN.CourseName = objRow[convcc_CourseSchoolRelation.CourseName] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.CourseName].ToString().Trim(); //课程名称
objvcc_CourseSchoolRelationEN.OrderNum = objRow[convcc_CourseSchoolRelation.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseSchoolRelation.OrderNum].ToString().Trim()); //序号
objvcc_CourseSchoolRelationEN.UpdDate = objRow[convcc_CourseSchoolRelation.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseSchoolRelationEN.UpdUser = objRow[convcc_CourseSchoolRelation.UpdUser].ToString().Trim(); //修改人
objvcc_CourseSchoolRelationEN.Memo = objRow[convcc_CourseSchoolRelation.Memo] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseSchoolRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseSchoolRelationEN);
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
public static List<clsvcc_CourseSchoolRelationEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvcc_CourseSchoolRelationEN> arrObjLst = new List<clsvcc_CourseSchoolRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationEN = new clsvcc_CourseSchoolRelationEN();
try
{
objvcc_CourseSchoolRelationEN.mId = Int32.Parse(objRow[convcc_CourseSchoolRelation.mId].ToString().Trim()); //mId
objvcc_CourseSchoolRelationEN.IdSchool = objRow[convcc_CourseSchoolRelation.IdSchool] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.IdSchool].ToString().Trim(); //学校流水号
objvcc_CourseSchoolRelationEN.SchoolId = objRow[convcc_CourseSchoolRelation.SchoolId] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.SchoolId].ToString().Trim(); //学校编号
objvcc_CourseSchoolRelationEN.SchoolName = objRow[convcc_CourseSchoolRelation.SchoolName] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.SchoolName].ToString().Trim(); //学校名称
objvcc_CourseSchoolRelationEN.SchoolNameA = objRow[convcc_CourseSchoolRelation.SchoolNameA] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.SchoolNameA].ToString().Trim(); //学校简称
objvcc_CourseSchoolRelationEN.CourseId = objRow[convcc_CourseSchoolRelation.CourseId] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.CourseId].ToString().Trim(); //课程Id
objvcc_CourseSchoolRelationEN.CourseName = objRow[convcc_CourseSchoolRelation.CourseName] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.CourseName].ToString().Trim(); //课程名称
objvcc_CourseSchoolRelationEN.OrderNum = objRow[convcc_CourseSchoolRelation.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseSchoolRelation.OrderNum].ToString().Trim()); //序号
objvcc_CourseSchoolRelationEN.UpdDate = objRow[convcc_CourseSchoolRelation.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseSchoolRelationEN.UpdUser = objRow[convcc_CourseSchoolRelation.UpdUser].ToString().Trim(); //修改人
objvcc_CourseSchoolRelationEN.Memo = objRow[convcc_CourseSchoolRelation.Memo] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseSchoolRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseSchoolRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseSchoolRelationEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvcc_CourseSchoolRelationEN> arrObjLst = new List<clsvcc_CourseSchoolRelationEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationEN = new clsvcc_CourseSchoolRelationEN();
try
{
objvcc_CourseSchoolRelationEN.mId = Int32.Parse(objRow[convcc_CourseSchoolRelation.mId].ToString().Trim()); //mId
objvcc_CourseSchoolRelationEN.IdSchool = objRow[convcc_CourseSchoolRelation.IdSchool] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.IdSchool].ToString().Trim(); //学校流水号
objvcc_CourseSchoolRelationEN.SchoolId = objRow[convcc_CourseSchoolRelation.SchoolId] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.SchoolId].ToString().Trim(); //学校编号
objvcc_CourseSchoolRelationEN.SchoolName = objRow[convcc_CourseSchoolRelation.SchoolName] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.SchoolName].ToString().Trim(); //学校名称
objvcc_CourseSchoolRelationEN.SchoolNameA = objRow[convcc_CourseSchoolRelation.SchoolNameA] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.SchoolNameA].ToString().Trim(); //学校简称
objvcc_CourseSchoolRelationEN.CourseId = objRow[convcc_CourseSchoolRelation.CourseId] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.CourseId].ToString().Trim(); //课程Id
objvcc_CourseSchoolRelationEN.CourseName = objRow[convcc_CourseSchoolRelation.CourseName] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.CourseName].ToString().Trim(); //课程名称
objvcc_CourseSchoolRelationEN.OrderNum = objRow[convcc_CourseSchoolRelation.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseSchoolRelation.OrderNum].ToString().Trim()); //序号
objvcc_CourseSchoolRelationEN.UpdDate = objRow[convcc_CourseSchoolRelation.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseSchoolRelationEN.UpdUser = objRow[convcc_CourseSchoolRelation.UpdUser].ToString().Trim(); //修改人
objvcc_CourseSchoolRelationEN.Memo = objRow[convcc_CourseSchoolRelation.Memo] == DBNull.Value ? null : objRow[convcc_CourseSchoolRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseSchoolRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseSchoolRelationEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvcc_CourseSchoolRelationEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvcc_CourseSchoolRelation(ref clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationEN)
{
bool bolResult = vcc_CourseSchoolRelationDA.Getvcc_CourseSchoolRelation(ref objvcc_CourseSchoolRelationEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_CourseSchoolRelationEN GetObjBymId(long lngmId)
{
clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationEN = vcc_CourseSchoolRelationDA.GetObjBymId(lngmId);
return objvcc_CourseSchoolRelationEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvcc_CourseSchoolRelationEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationEN = vcc_CourseSchoolRelationDA.GetFirstObj(strWhereCond);
 return objvcc_CourseSchoolRelationEN;
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
public static clsvcc_CourseSchoolRelationEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationEN = vcc_CourseSchoolRelationDA.GetObjByDataRow(objRow);
 return objvcc_CourseSchoolRelationEN;
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
public static clsvcc_CourseSchoolRelationEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationEN = vcc_CourseSchoolRelationDA.GetObjByDataRow(objRow);
 return objvcc_CourseSchoolRelationEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "lstvcc_CourseSchoolRelationObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_CourseSchoolRelationEN GetObjBymIdFromList(long lngmId, List<clsvcc_CourseSchoolRelationEN> lstvcc_CourseSchoolRelationObjLst)
{
foreach (clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationEN in lstvcc_CourseSchoolRelationObjLst)
{
if (objvcc_CourseSchoolRelationEN.mId == lngmId)
{
return objvcc_CourseSchoolRelationEN;
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
 long lngmId;
 try
 {
 lngmId = new clsvcc_CourseSchoolRelationDA().GetFirstID(strWhereCond);
 return lngmId;
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
 arrList = vcc_CourseSchoolRelationDA.GetID(strWhereCond);
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
bool bolIsExist = vcc_CourseSchoolRelationDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
bool bolIsExist = vcc_CourseSchoolRelationDA.IsExist(lngmId);
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
 bolIsExist = clsvcc_CourseSchoolRelationDA.IsExistTable();
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
 bolIsExist = vcc_CourseSchoolRelationDA.IsExistTable(strTabName);
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
 /// <param name = "objvcc_CourseSchoolRelationENS">源对象</param>
 /// <param name = "objvcc_CourseSchoolRelationENT">目标对象</param>
 public static void CopyTo(clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationENS, clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationENT)
{
try
{
objvcc_CourseSchoolRelationENT.mId = objvcc_CourseSchoolRelationENS.mId; //mId
objvcc_CourseSchoolRelationENT.IdSchool = objvcc_CourseSchoolRelationENS.IdSchool; //学校流水号
objvcc_CourseSchoolRelationENT.SchoolId = objvcc_CourseSchoolRelationENS.SchoolId; //学校编号
objvcc_CourseSchoolRelationENT.SchoolName = objvcc_CourseSchoolRelationENS.SchoolName; //学校名称
objvcc_CourseSchoolRelationENT.SchoolNameA = objvcc_CourseSchoolRelationENS.SchoolNameA; //学校简称
objvcc_CourseSchoolRelationENT.CourseId = objvcc_CourseSchoolRelationENS.CourseId; //课程Id
objvcc_CourseSchoolRelationENT.CourseName = objvcc_CourseSchoolRelationENS.CourseName; //课程名称
objvcc_CourseSchoolRelationENT.OrderNum = objvcc_CourseSchoolRelationENS.OrderNum; //序号
objvcc_CourseSchoolRelationENT.UpdDate = objvcc_CourseSchoolRelationENS.UpdDate; //修改日期
objvcc_CourseSchoolRelationENT.UpdUser = objvcc_CourseSchoolRelationENS.UpdUser; //修改人
objvcc_CourseSchoolRelationENT.Memo = objvcc_CourseSchoolRelationENS.Memo; //备注
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
 /// <param name = "objvcc_CourseSchoolRelationEN">源简化对象</param>
 public static void SetUpdFlag(clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationEN)
{
try
{
objvcc_CourseSchoolRelationEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvcc_CourseSchoolRelationEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convcc_CourseSchoolRelation.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseSchoolRelationEN.mId = objvcc_CourseSchoolRelationEN.mId; //mId
}
if (arrFldSet.Contains(convcc_CourseSchoolRelation.IdSchool, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseSchoolRelationEN.IdSchool = objvcc_CourseSchoolRelationEN.IdSchool == "[null]" ? null :  objvcc_CourseSchoolRelationEN.IdSchool; //学校流水号
}
if (arrFldSet.Contains(convcc_CourseSchoolRelation.SchoolId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseSchoolRelationEN.SchoolId = objvcc_CourseSchoolRelationEN.SchoolId == "[null]" ? null :  objvcc_CourseSchoolRelationEN.SchoolId; //学校编号
}
if (arrFldSet.Contains(convcc_CourseSchoolRelation.SchoolName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseSchoolRelationEN.SchoolName = objvcc_CourseSchoolRelationEN.SchoolName == "[null]" ? null :  objvcc_CourseSchoolRelationEN.SchoolName; //学校名称
}
if (arrFldSet.Contains(convcc_CourseSchoolRelation.SchoolNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseSchoolRelationEN.SchoolNameA = objvcc_CourseSchoolRelationEN.SchoolNameA == "[null]" ? null :  objvcc_CourseSchoolRelationEN.SchoolNameA; //学校简称
}
if (arrFldSet.Contains(convcc_CourseSchoolRelation.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseSchoolRelationEN.CourseId = objvcc_CourseSchoolRelationEN.CourseId == "[null]" ? null :  objvcc_CourseSchoolRelationEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convcc_CourseSchoolRelation.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseSchoolRelationEN.CourseName = objvcc_CourseSchoolRelationEN.CourseName == "[null]" ? null :  objvcc_CourseSchoolRelationEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convcc_CourseSchoolRelation.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseSchoolRelationEN.OrderNum = objvcc_CourseSchoolRelationEN.OrderNum; //序号
}
if (arrFldSet.Contains(convcc_CourseSchoolRelation.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseSchoolRelationEN.UpdDate = objvcc_CourseSchoolRelationEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convcc_CourseSchoolRelation.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseSchoolRelationEN.UpdUser = objvcc_CourseSchoolRelationEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convcc_CourseSchoolRelation.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseSchoolRelationEN.Memo = objvcc_CourseSchoolRelationEN.Memo == "[null]" ? null :  objvcc_CourseSchoolRelationEN.Memo; //备注
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
 /// <param name = "objvcc_CourseSchoolRelationEN">源简化对象</param>
 public static void AccessFldValueNull(clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationEN)
{
try
{
if (objvcc_CourseSchoolRelationEN.IdSchool == "[null]") objvcc_CourseSchoolRelationEN.IdSchool = null; //学校流水号
if (objvcc_CourseSchoolRelationEN.SchoolId == "[null]") objvcc_CourseSchoolRelationEN.SchoolId = null; //学校编号
if (objvcc_CourseSchoolRelationEN.SchoolName == "[null]") objvcc_CourseSchoolRelationEN.SchoolName = null; //学校名称
if (objvcc_CourseSchoolRelationEN.SchoolNameA == "[null]") objvcc_CourseSchoolRelationEN.SchoolNameA = null; //学校简称
if (objvcc_CourseSchoolRelationEN.CourseId == "[null]") objvcc_CourseSchoolRelationEN.CourseId = null; //课程Id
if (objvcc_CourseSchoolRelationEN.CourseName == "[null]") objvcc_CourseSchoolRelationEN.CourseName = null; //课程名称
if (objvcc_CourseSchoolRelationEN.Memo == "[null]") objvcc_CourseSchoolRelationEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationEN)
{
 vcc_CourseSchoolRelationDA.CheckProperty4Condition(objvcc_CourseSchoolRelationEN);
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
if (clsXzSchoolBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzSchoolBL没有刷新缓存机制(clsXzSchoolBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseBL没有刷新缓存机制(clscc_CourseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseSchoolRelationBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseSchoolRelationBL没有刷新缓存机制(clscc_CourseSchoolRelationBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvcc_CourseSchoolRelationObjLstCache == null)
//{
//arrvcc_CourseSchoolRelationObjLstCache = vcc_CourseSchoolRelationDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_CourseSchoolRelationEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvcc_CourseSchoolRelationEN._CurrTabName);
List<clsvcc_CourseSchoolRelationEN> arrvcc_CourseSchoolRelationObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_CourseSchoolRelationEN> arrvcc_CourseSchoolRelationObjLst_Sel =
arrvcc_CourseSchoolRelationObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvcc_CourseSchoolRelationObjLst_Sel.Count() == 0)
{
   clsvcc_CourseSchoolRelationEN obj = clsvcc_CourseSchoolRelationBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvcc_CourseSchoolRelationObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_CourseSchoolRelationEN> GetAllvcc_CourseSchoolRelationObjLstCache()
{
//获取缓存中的对象列表
List<clsvcc_CourseSchoolRelationEN> arrvcc_CourseSchoolRelationObjLstCache = GetObjLstCache(); 
return arrvcc_CourseSchoolRelationObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_CourseSchoolRelationEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvcc_CourseSchoolRelationEN._CurrTabName);
List<clsvcc_CourseSchoolRelationEN> arrvcc_CourseSchoolRelationObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvcc_CourseSchoolRelationObjLstCache;
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
string strKey = string.Format("{0}", clsvcc_CourseSchoolRelationEN._CurrTabName);
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
 /// 日期:2024-02-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != convcc_CourseSchoolRelation.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convcc_CourseSchoolRelation.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convcc_CourseSchoolRelation.AttributeName));
throw new Exception(strMsg);
}
var objvcc_CourseSchoolRelation = clsvcc_CourseSchoolRelationBL.GetObjBymIdCache(lngmId);
if (objvcc_CourseSchoolRelation == null) return "";
return objvcc_CourseSchoolRelation[strOutFldName].ToString();
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
int intRecCount = clsvcc_CourseSchoolRelationDA.GetRecCount(strTabName);
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
int intRecCount = clsvcc_CourseSchoolRelationDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvcc_CourseSchoolRelationDA.GetRecCount();
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
int intRecCount = clsvcc_CourseSchoolRelationDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvcc_CourseSchoolRelationCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationCond)
{
List<clsvcc_CourseSchoolRelationEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_CourseSchoolRelationEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_CourseSchoolRelation.AttributeName)
{
if (objvcc_CourseSchoolRelationCond.IsUpdated(strFldName) == false) continue;
if (objvcc_CourseSchoolRelationCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseSchoolRelationCond[strFldName].ToString());
}
else
{
if (objvcc_CourseSchoolRelationCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_CourseSchoolRelationCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseSchoolRelationCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_CourseSchoolRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_CourseSchoolRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_CourseSchoolRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_CourseSchoolRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_CourseSchoolRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_CourseSchoolRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_CourseSchoolRelationCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_CourseSchoolRelationCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_CourseSchoolRelationCond[strFldName]));
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
 List<string> arrList = clsvcc_CourseSchoolRelationDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vcc_CourseSchoolRelationDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vcc_CourseSchoolRelationDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}