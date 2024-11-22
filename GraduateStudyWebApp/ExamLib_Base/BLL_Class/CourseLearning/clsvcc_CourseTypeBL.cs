
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_CourseTypeBL
 表名:vcc_CourseType(01120059)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:26:05
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习(CourseLearning)
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
public static class  clsvcc_CourseTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strCourseTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_CourseTypeEN GetObj(this K_CourseTypeId_vcc_CourseType myKey)
{
clsvcc_CourseTypeEN objvcc_CourseTypeEN = clsvcc_CourseTypeBL.vcc_CourseTypeDA.GetObjByCourseTypeId(myKey.Value);
return objvcc_CourseTypeEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTypeEN SetCourseTypeId(this clsvcc_CourseTypeEN objvcc_CourseTypeEN, string strCourseTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseTypeId, 4, convcc_CourseType.CourseTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseTypeId, 4, convcc_CourseType.CourseTypeId);
}
objvcc_CourseTypeEN.CourseTypeId = strCourseTypeId; //课程类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTypeEN.dicFldComparisonOp.ContainsKey(convcc_CourseType.CourseTypeId) == false)
{
objvcc_CourseTypeEN.dicFldComparisonOp.Add(convcc_CourseType.CourseTypeId, strComparisonOp);
}
else
{
objvcc_CourseTypeEN.dicFldComparisonOp[convcc_CourseType.CourseTypeId] = strComparisonOp;
}
}
return objvcc_CourseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTypeEN SetCourseTypeName(this clsvcc_CourseTypeEN objvcc_CourseTypeEN, string strCourseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseTypeName, convcc_CourseType.CourseTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseTypeName, 30, convcc_CourseType.CourseTypeName);
}
objvcc_CourseTypeEN.CourseTypeName = strCourseTypeName; //课程类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTypeEN.dicFldComparisonOp.ContainsKey(convcc_CourseType.CourseTypeName) == false)
{
objvcc_CourseTypeEN.dicFldComparisonOp.Add(convcc_CourseType.CourseTypeName, strComparisonOp);
}
else
{
objvcc_CourseTypeEN.dicFldComparisonOp[convcc_CourseType.CourseTypeName] = strComparisonOp;
}
}
return objvcc_CourseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTypeEN SetIdSchool(this clsvcc_CourseTypeEN objvcc_CourseTypeEN, string strIdSchool, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSchool, 4, convcc_CourseType.IdSchool);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSchool, 4, convcc_CourseType.IdSchool);
}
objvcc_CourseTypeEN.IdSchool = strIdSchool; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTypeEN.dicFldComparisonOp.ContainsKey(convcc_CourseType.IdSchool) == false)
{
objvcc_CourseTypeEN.dicFldComparisonOp.Add(convcc_CourseType.IdSchool, strComparisonOp);
}
else
{
objvcc_CourseTypeEN.dicFldComparisonOp[convcc_CourseType.IdSchool] = strComparisonOp;
}
}
return objvcc_CourseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTypeEN SetSchoolId(this clsvcc_CourseTypeEN objvcc_CourseTypeEN, string strSchoolId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolId, convcc_CourseType.SchoolId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolId, 10, convcc_CourseType.SchoolId);
}
objvcc_CourseTypeEN.SchoolId = strSchoolId; //学校编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTypeEN.dicFldComparisonOp.ContainsKey(convcc_CourseType.SchoolId) == false)
{
objvcc_CourseTypeEN.dicFldComparisonOp.Add(convcc_CourseType.SchoolId, strComparisonOp);
}
else
{
objvcc_CourseTypeEN.dicFldComparisonOp[convcc_CourseType.SchoolId] = strComparisonOp;
}
}
return objvcc_CourseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTypeEN SetSchoolName(this clsvcc_CourseTypeEN objvcc_CourseTypeEN, string strSchoolName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolName, convcc_CourseType.SchoolName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolName, 50, convcc_CourseType.SchoolName);
}
objvcc_CourseTypeEN.SchoolName = strSchoolName; //学校名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTypeEN.dicFldComparisonOp.ContainsKey(convcc_CourseType.SchoolName) == false)
{
objvcc_CourseTypeEN.dicFldComparisonOp.Add(convcc_CourseType.SchoolName, strComparisonOp);
}
else
{
objvcc_CourseTypeEN.dicFldComparisonOp[convcc_CourseType.SchoolName] = strComparisonOp;
}
}
return objvcc_CourseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTypeEN SetIsUse(this clsvcc_CourseTypeEN objvcc_CourseTypeEN, bool bolIsUse, string strComparisonOp="")
	{
objvcc_CourseTypeEN.IsUse = bolIsUse; //是否使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTypeEN.dicFldComparisonOp.ContainsKey(convcc_CourseType.IsUse) == false)
{
objvcc_CourseTypeEN.dicFldComparisonOp.Add(convcc_CourseType.IsUse, strComparisonOp);
}
else
{
objvcc_CourseTypeEN.dicFldComparisonOp[convcc_CourseType.IsUse] = strComparisonOp;
}
}
return objvcc_CourseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTypeEN SetUpdDate(this clsvcc_CourseTypeEN objvcc_CourseTypeEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_CourseType.UpdDate);
}
objvcc_CourseTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTypeEN.dicFldComparisonOp.ContainsKey(convcc_CourseType.UpdDate) == false)
{
objvcc_CourseTypeEN.dicFldComparisonOp.Add(convcc_CourseType.UpdDate, strComparisonOp);
}
else
{
objvcc_CourseTypeEN.dicFldComparisonOp[convcc_CourseType.UpdDate] = strComparisonOp;
}
}
return objvcc_CourseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTypeEN SetUpdUserId(this clsvcc_CourseTypeEN objvcc_CourseTypeEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convcc_CourseType.UpdUserId);
}
objvcc_CourseTypeEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTypeEN.dicFldComparisonOp.ContainsKey(convcc_CourseType.UpdUserId) == false)
{
objvcc_CourseTypeEN.dicFldComparisonOp.Add(convcc_CourseType.UpdUserId, strComparisonOp);
}
else
{
objvcc_CourseTypeEN.dicFldComparisonOp[convcc_CourseType.UpdUserId] = strComparisonOp;
}
}
return objvcc_CourseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTypeEN SetMemo(this clsvcc_CourseTypeEN objvcc_CourseTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_CourseType.Memo);
}
objvcc_CourseTypeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTypeEN.dicFldComparisonOp.ContainsKey(convcc_CourseType.Memo) == false)
{
objvcc_CourseTypeEN.dicFldComparisonOp.Add(convcc_CourseType.Memo, strComparisonOp);
}
else
{
objvcc_CourseTypeEN.dicFldComparisonOp[convcc_CourseType.Memo] = strComparisonOp;
}
}
return objvcc_CourseTypeEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvcc_CourseTypeENS">源对象</param>
 /// <param name = "objvcc_CourseTypeENT">目标对象</param>
 public static void CopyTo(this clsvcc_CourseTypeEN objvcc_CourseTypeENS, clsvcc_CourseTypeEN objvcc_CourseTypeENT)
{
try
{
objvcc_CourseTypeENT.CourseTypeId = objvcc_CourseTypeENS.CourseTypeId; //课程类型ID
objvcc_CourseTypeENT.CourseTypeName = objvcc_CourseTypeENS.CourseTypeName; //课程类型名称
objvcc_CourseTypeENT.IdSchool = objvcc_CourseTypeENS.IdSchool; //学校流水号
objvcc_CourseTypeENT.SchoolId = objvcc_CourseTypeENS.SchoolId; //学校编号
objvcc_CourseTypeENT.SchoolName = objvcc_CourseTypeENS.SchoolName; //学校名称
objvcc_CourseTypeENT.IsUse = objvcc_CourseTypeENS.IsUse; //是否使用
objvcc_CourseTypeENT.UpdDate = objvcc_CourseTypeENS.UpdDate; //修改日期
objvcc_CourseTypeENT.UpdUserId = objvcc_CourseTypeENS.UpdUserId; //修改用户Id
objvcc_CourseTypeENT.Memo = objvcc_CourseTypeENS.Memo; //备注
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
 /// <param name = "objvcc_CourseTypeENS">源对象</param>
 /// <returns>目标对象=>clsvcc_CourseTypeEN:objvcc_CourseTypeENT</returns>
 public static clsvcc_CourseTypeEN CopyTo(this clsvcc_CourseTypeEN objvcc_CourseTypeENS)
{
try
{
 clsvcc_CourseTypeEN objvcc_CourseTypeENT = new clsvcc_CourseTypeEN()
{
CourseTypeId = objvcc_CourseTypeENS.CourseTypeId, //课程类型ID
CourseTypeName = objvcc_CourseTypeENS.CourseTypeName, //课程类型名称
IdSchool = objvcc_CourseTypeENS.IdSchool, //学校流水号
SchoolId = objvcc_CourseTypeENS.SchoolId, //学校编号
SchoolName = objvcc_CourseTypeENS.SchoolName, //学校名称
IsUse = objvcc_CourseTypeENS.IsUse, //是否使用
UpdDate = objvcc_CourseTypeENS.UpdDate, //修改日期
UpdUserId = objvcc_CourseTypeENS.UpdUserId, //修改用户Id
Memo = objvcc_CourseTypeENS.Memo, //备注
};
 return objvcc_CourseTypeENT;
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
public static void CheckProperty4Condition(this clsvcc_CourseTypeEN objvcc_CourseTypeEN)
{
 clsvcc_CourseTypeBL.vcc_CourseTypeDA.CheckProperty4Condition(objvcc_CourseTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_CourseTypeEN objvcc_CourseTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_CourseTypeCond.IsUpdated(convcc_CourseType.CourseTypeId) == true)
{
string strComparisonOpCourseTypeId = objvcc_CourseTypeCond.dicFldComparisonOp[convcc_CourseType.CourseTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseType.CourseTypeId, objvcc_CourseTypeCond.CourseTypeId, strComparisonOpCourseTypeId);
}
if (objvcc_CourseTypeCond.IsUpdated(convcc_CourseType.CourseTypeName) == true)
{
string strComparisonOpCourseTypeName = objvcc_CourseTypeCond.dicFldComparisonOp[convcc_CourseType.CourseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseType.CourseTypeName, objvcc_CourseTypeCond.CourseTypeName, strComparisonOpCourseTypeName);
}
if (objvcc_CourseTypeCond.IsUpdated(convcc_CourseType.IdSchool) == true)
{
string strComparisonOpIdSchool = objvcc_CourseTypeCond.dicFldComparisonOp[convcc_CourseType.IdSchool];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseType.IdSchool, objvcc_CourseTypeCond.IdSchool, strComparisonOpIdSchool);
}
if (objvcc_CourseTypeCond.IsUpdated(convcc_CourseType.SchoolId) == true)
{
string strComparisonOpSchoolId = objvcc_CourseTypeCond.dicFldComparisonOp[convcc_CourseType.SchoolId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseType.SchoolId, objvcc_CourseTypeCond.SchoolId, strComparisonOpSchoolId);
}
if (objvcc_CourseTypeCond.IsUpdated(convcc_CourseType.SchoolName) == true)
{
string strComparisonOpSchoolName = objvcc_CourseTypeCond.dicFldComparisonOp[convcc_CourseType.SchoolName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseType.SchoolName, objvcc_CourseTypeCond.SchoolName, strComparisonOpSchoolName);
}
if (objvcc_CourseTypeCond.IsUpdated(convcc_CourseType.IsUse) == true)
{
if (objvcc_CourseTypeCond.IsUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseType.IsUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseType.IsUse);
}
}
if (objvcc_CourseTypeCond.IsUpdated(convcc_CourseType.UpdDate) == true)
{
string strComparisonOpUpdDate = objvcc_CourseTypeCond.dicFldComparisonOp[convcc_CourseType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseType.UpdDate, objvcc_CourseTypeCond.UpdDate, strComparisonOpUpdDate);
}
if (objvcc_CourseTypeCond.IsUpdated(convcc_CourseType.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvcc_CourseTypeCond.dicFldComparisonOp[convcc_CourseType.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseType.UpdUserId, objvcc_CourseTypeCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvcc_CourseTypeCond.IsUpdated(convcc_CourseType.Memo) == true)
{
string strComparisonOpMemo = objvcc_CourseTypeCond.dicFldComparisonOp[convcc_CourseType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseType.Memo, objvcc_CourseTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vcc_CourseType
{
public virtual bool UpdRelaTabDate(string strCourseTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v课程类型(vcc_CourseType)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvcc_CourseTypeBL
{
public static RelatedActions_vcc_CourseType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvcc_CourseTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvcc_CourseTypeDA vcc_CourseTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvcc_CourseTypeDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvcc_CourseTypeBL()
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
if (string.IsNullOrEmpty(clsvcc_CourseTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvcc_CourseTypeEN._ConnectString);
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
public static DataTable GetDataTable_vcc_CourseType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vcc_CourseTypeDA.GetDataTable_vcc_CourseType(strWhereCond);
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
objDT = vcc_CourseTypeDA.GetDataTable(strWhereCond);
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
objDT = vcc_CourseTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vcc_CourseTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vcc_CourseTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vcc_CourseTypeDA.GetDataTable_Top(objTopPara);
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
objDT = vcc_CourseTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vcc_CourseTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vcc_CourseTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrCourseTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvcc_CourseTypeEN> GetObjLstByCourseTypeIdLst(List<string> arrCourseTypeIdLst)
{
List<clsvcc_CourseTypeEN> arrObjLst = new List<clsvcc_CourseTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrCourseTypeIdLst, true);
 string strWhereCond = string.Format("CourseTypeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseTypeEN objvcc_CourseTypeEN = new clsvcc_CourseTypeEN();
try
{
objvcc_CourseTypeEN.CourseTypeId = objRow[convcc_CourseType.CourseTypeId].ToString().Trim(); //课程类型ID
objvcc_CourseTypeEN.CourseTypeName = objRow[convcc_CourseType.CourseTypeName].ToString().Trim(); //课程类型名称
objvcc_CourseTypeEN.IdSchool = objRow[convcc_CourseType.IdSchool] == DBNull.Value ? null : objRow[convcc_CourseType.IdSchool].ToString().Trim(); //学校流水号
objvcc_CourseTypeEN.SchoolId = objRow[convcc_CourseType.SchoolId].ToString().Trim(); //学校编号
objvcc_CourseTypeEN.SchoolName = objRow[convcc_CourseType.SchoolName].ToString().Trim(); //学校名称
objvcc_CourseTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseType.IsUse].ToString().Trim()); //是否使用
objvcc_CourseTypeEN.UpdDate = objRow[convcc_CourseType.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseType.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseTypeEN.UpdUserId = objRow[convcc_CourseType.UpdUserId] == DBNull.Value ? null : objRow[convcc_CourseType.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_CourseTypeEN.Memo = objRow[convcc_CourseType.Memo] == DBNull.Value ? null : objRow[convcc_CourseType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseTypeEN.CourseTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrCourseTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvcc_CourseTypeEN> GetObjLstByCourseTypeIdLstCache(List<string> arrCourseTypeIdLst)
{
string strKey = string.Format("{0}", clsvcc_CourseTypeEN._CurrTabName);
List<clsvcc_CourseTypeEN> arrvcc_CourseTypeObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_CourseTypeEN> arrvcc_CourseTypeObjLst_Sel =
arrvcc_CourseTypeObjLstCache
.Where(x => arrCourseTypeIdLst.Contains(x.CourseTypeId));
return arrvcc_CourseTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseTypeEN> GetObjLst(string strWhereCond)
{
List<clsvcc_CourseTypeEN> arrObjLst = new List<clsvcc_CourseTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseTypeEN objvcc_CourseTypeEN = new clsvcc_CourseTypeEN();
try
{
objvcc_CourseTypeEN.CourseTypeId = objRow[convcc_CourseType.CourseTypeId].ToString().Trim(); //课程类型ID
objvcc_CourseTypeEN.CourseTypeName = objRow[convcc_CourseType.CourseTypeName].ToString().Trim(); //课程类型名称
objvcc_CourseTypeEN.IdSchool = objRow[convcc_CourseType.IdSchool] == DBNull.Value ? null : objRow[convcc_CourseType.IdSchool].ToString().Trim(); //学校流水号
objvcc_CourseTypeEN.SchoolId = objRow[convcc_CourseType.SchoolId].ToString().Trim(); //学校编号
objvcc_CourseTypeEN.SchoolName = objRow[convcc_CourseType.SchoolName].ToString().Trim(); //学校名称
objvcc_CourseTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseType.IsUse].ToString().Trim()); //是否使用
objvcc_CourseTypeEN.UpdDate = objRow[convcc_CourseType.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseType.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseTypeEN.UpdUserId = objRow[convcc_CourseType.UpdUserId] == DBNull.Value ? null : objRow[convcc_CourseType.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_CourseTypeEN.Memo = objRow[convcc_CourseType.Memo] == DBNull.Value ? null : objRow[convcc_CourseType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseTypeEN.CourseTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseTypeEN);
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
public static List<clsvcc_CourseTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvcc_CourseTypeEN> arrObjLst = new List<clsvcc_CourseTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseTypeEN objvcc_CourseTypeEN = new clsvcc_CourseTypeEN();
try
{
objvcc_CourseTypeEN.CourseTypeId = objRow[convcc_CourseType.CourseTypeId].ToString().Trim(); //课程类型ID
objvcc_CourseTypeEN.CourseTypeName = objRow[convcc_CourseType.CourseTypeName].ToString().Trim(); //课程类型名称
objvcc_CourseTypeEN.IdSchool = objRow[convcc_CourseType.IdSchool] == DBNull.Value ? null : objRow[convcc_CourseType.IdSchool].ToString().Trim(); //学校流水号
objvcc_CourseTypeEN.SchoolId = objRow[convcc_CourseType.SchoolId].ToString().Trim(); //学校编号
objvcc_CourseTypeEN.SchoolName = objRow[convcc_CourseType.SchoolName].ToString().Trim(); //学校名称
objvcc_CourseTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseType.IsUse].ToString().Trim()); //是否使用
objvcc_CourseTypeEN.UpdDate = objRow[convcc_CourseType.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseType.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseTypeEN.UpdUserId = objRow[convcc_CourseType.UpdUserId] == DBNull.Value ? null : objRow[convcc_CourseType.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_CourseTypeEN.Memo = objRow[convcc_CourseType.Memo] == DBNull.Value ? null : objRow[convcc_CourseType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseTypeEN.CourseTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvcc_CourseTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvcc_CourseTypeEN> GetSubObjLstCache(clsvcc_CourseTypeEN objvcc_CourseTypeCond)
{
List<clsvcc_CourseTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_CourseTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_CourseType.AttributeName)
{
if (objvcc_CourseTypeCond.IsUpdated(strFldName) == false) continue;
if (objvcc_CourseTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseTypeCond[strFldName].ToString());
}
else
{
if (objvcc_CourseTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_CourseTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_CourseTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_CourseTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_CourseTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_CourseTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_CourseTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_CourseTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_CourseTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_CourseTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_CourseTypeCond[strFldName]));
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
public static List<clsvcc_CourseTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvcc_CourseTypeEN> arrObjLst = new List<clsvcc_CourseTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseTypeEN objvcc_CourseTypeEN = new clsvcc_CourseTypeEN();
try
{
objvcc_CourseTypeEN.CourseTypeId = objRow[convcc_CourseType.CourseTypeId].ToString().Trim(); //课程类型ID
objvcc_CourseTypeEN.CourseTypeName = objRow[convcc_CourseType.CourseTypeName].ToString().Trim(); //课程类型名称
objvcc_CourseTypeEN.IdSchool = objRow[convcc_CourseType.IdSchool] == DBNull.Value ? null : objRow[convcc_CourseType.IdSchool].ToString().Trim(); //学校流水号
objvcc_CourseTypeEN.SchoolId = objRow[convcc_CourseType.SchoolId].ToString().Trim(); //学校编号
objvcc_CourseTypeEN.SchoolName = objRow[convcc_CourseType.SchoolName].ToString().Trim(); //学校名称
objvcc_CourseTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseType.IsUse].ToString().Trim()); //是否使用
objvcc_CourseTypeEN.UpdDate = objRow[convcc_CourseType.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseType.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseTypeEN.UpdUserId = objRow[convcc_CourseType.UpdUserId] == DBNull.Value ? null : objRow[convcc_CourseType.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_CourseTypeEN.Memo = objRow[convcc_CourseType.Memo] == DBNull.Value ? null : objRow[convcc_CourseType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseTypeEN.CourseTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseTypeEN);
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
public static List<clsvcc_CourseTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvcc_CourseTypeEN> arrObjLst = new List<clsvcc_CourseTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseTypeEN objvcc_CourseTypeEN = new clsvcc_CourseTypeEN();
try
{
objvcc_CourseTypeEN.CourseTypeId = objRow[convcc_CourseType.CourseTypeId].ToString().Trim(); //课程类型ID
objvcc_CourseTypeEN.CourseTypeName = objRow[convcc_CourseType.CourseTypeName].ToString().Trim(); //课程类型名称
objvcc_CourseTypeEN.IdSchool = objRow[convcc_CourseType.IdSchool] == DBNull.Value ? null : objRow[convcc_CourseType.IdSchool].ToString().Trim(); //学校流水号
objvcc_CourseTypeEN.SchoolId = objRow[convcc_CourseType.SchoolId].ToString().Trim(); //学校编号
objvcc_CourseTypeEN.SchoolName = objRow[convcc_CourseType.SchoolName].ToString().Trim(); //学校名称
objvcc_CourseTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseType.IsUse].ToString().Trim()); //是否使用
objvcc_CourseTypeEN.UpdDate = objRow[convcc_CourseType.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseType.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseTypeEN.UpdUserId = objRow[convcc_CourseType.UpdUserId] == DBNull.Value ? null : objRow[convcc_CourseType.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_CourseTypeEN.Memo = objRow[convcc_CourseType.Memo] == DBNull.Value ? null : objRow[convcc_CourseType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseTypeEN.CourseTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseTypeEN);
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
List<clsvcc_CourseTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvcc_CourseTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvcc_CourseTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_CourseTypeEN> arrObjLst = new List<clsvcc_CourseTypeEN>(); 
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
	clsvcc_CourseTypeEN objvcc_CourseTypeEN = new clsvcc_CourseTypeEN();
try
{
objvcc_CourseTypeEN.CourseTypeId = objRow[convcc_CourseType.CourseTypeId].ToString().Trim(); //课程类型ID
objvcc_CourseTypeEN.CourseTypeName = objRow[convcc_CourseType.CourseTypeName].ToString().Trim(); //课程类型名称
objvcc_CourseTypeEN.IdSchool = objRow[convcc_CourseType.IdSchool] == DBNull.Value ? null : objRow[convcc_CourseType.IdSchool].ToString().Trim(); //学校流水号
objvcc_CourseTypeEN.SchoolId = objRow[convcc_CourseType.SchoolId].ToString().Trim(); //学校编号
objvcc_CourseTypeEN.SchoolName = objRow[convcc_CourseType.SchoolName].ToString().Trim(); //学校名称
objvcc_CourseTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseType.IsUse].ToString().Trim()); //是否使用
objvcc_CourseTypeEN.UpdDate = objRow[convcc_CourseType.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseType.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseTypeEN.UpdUserId = objRow[convcc_CourseType.UpdUserId] == DBNull.Value ? null : objRow[convcc_CourseType.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_CourseTypeEN.Memo = objRow[convcc_CourseType.Memo] == DBNull.Value ? null : objRow[convcc_CourseType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseTypeEN.CourseTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseTypeEN);
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
public static List<clsvcc_CourseTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvcc_CourseTypeEN> arrObjLst = new List<clsvcc_CourseTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseTypeEN objvcc_CourseTypeEN = new clsvcc_CourseTypeEN();
try
{
objvcc_CourseTypeEN.CourseTypeId = objRow[convcc_CourseType.CourseTypeId].ToString().Trim(); //课程类型ID
objvcc_CourseTypeEN.CourseTypeName = objRow[convcc_CourseType.CourseTypeName].ToString().Trim(); //课程类型名称
objvcc_CourseTypeEN.IdSchool = objRow[convcc_CourseType.IdSchool] == DBNull.Value ? null : objRow[convcc_CourseType.IdSchool].ToString().Trim(); //学校流水号
objvcc_CourseTypeEN.SchoolId = objRow[convcc_CourseType.SchoolId].ToString().Trim(); //学校编号
objvcc_CourseTypeEN.SchoolName = objRow[convcc_CourseType.SchoolName].ToString().Trim(); //学校名称
objvcc_CourseTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseType.IsUse].ToString().Trim()); //是否使用
objvcc_CourseTypeEN.UpdDate = objRow[convcc_CourseType.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseType.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseTypeEN.UpdUserId = objRow[convcc_CourseType.UpdUserId] == DBNull.Value ? null : objRow[convcc_CourseType.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_CourseTypeEN.Memo = objRow[convcc_CourseType.Memo] == DBNull.Value ? null : objRow[convcc_CourseType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseTypeEN.CourseTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvcc_CourseTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvcc_CourseTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_CourseTypeEN> arrObjLst = new List<clsvcc_CourseTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseTypeEN objvcc_CourseTypeEN = new clsvcc_CourseTypeEN();
try
{
objvcc_CourseTypeEN.CourseTypeId = objRow[convcc_CourseType.CourseTypeId].ToString().Trim(); //课程类型ID
objvcc_CourseTypeEN.CourseTypeName = objRow[convcc_CourseType.CourseTypeName].ToString().Trim(); //课程类型名称
objvcc_CourseTypeEN.IdSchool = objRow[convcc_CourseType.IdSchool] == DBNull.Value ? null : objRow[convcc_CourseType.IdSchool].ToString().Trim(); //学校流水号
objvcc_CourseTypeEN.SchoolId = objRow[convcc_CourseType.SchoolId].ToString().Trim(); //学校编号
objvcc_CourseTypeEN.SchoolName = objRow[convcc_CourseType.SchoolName].ToString().Trim(); //学校名称
objvcc_CourseTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseType.IsUse].ToString().Trim()); //是否使用
objvcc_CourseTypeEN.UpdDate = objRow[convcc_CourseType.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseType.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseTypeEN.UpdUserId = objRow[convcc_CourseType.UpdUserId] == DBNull.Value ? null : objRow[convcc_CourseType.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_CourseTypeEN.Memo = objRow[convcc_CourseType.Memo] == DBNull.Value ? null : objRow[convcc_CourseType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseTypeEN.CourseTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseTypeEN);
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
public static List<clsvcc_CourseTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvcc_CourseTypeEN> arrObjLst = new List<clsvcc_CourseTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseTypeEN objvcc_CourseTypeEN = new clsvcc_CourseTypeEN();
try
{
objvcc_CourseTypeEN.CourseTypeId = objRow[convcc_CourseType.CourseTypeId].ToString().Trim(); //课程类型ID
objvcc_CourseTypeEN.CourseTypeName = objRow[convcc_CourseType.CourseTypeName].ToString().Trim(); //课程类型名称
objvcc_CourseTypeEN.IdSchool = objRow[convcc_CourseType.IdSchool] == DBNull.Value ? null : objRow[convcc_CourseType.IdSchool].ToString().Trim(); //学校流水号
objvcc_CourseTypeEN.SchoolId = objRow[convcc_CourseType.SchoolId].ToString().Trim(); //学校编号
objvcc_CourseTypeEN.SchoolName = objRow[convcc_CourseType.SchoolName].ToString().Trim(); //学校名称
objvcc_CourseTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseType.IsUse].ToString().Trim()); //是否使用
objvcc_CourseTypeEN.UpdDate = objRow[convcc_CourseType.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseType.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseTypeEN.UpdUserId = objRow[convcc_CourseType.UpdUserId] == DBNull.Value ? null : objRow[convcc_CourseType.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_CourseTypeEN.Memo = objRow[convcc_CourseType.Memo] == DBNull.Value ? null : objRow[convcc_CourseType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseTypeEN.CourseTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvcc_CourseTypeEN> arrObjLst = new List<clsvcc_CourseTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseTypeEN objvcc_CourseTypeEN = new clsvcc_CourseTypeEN();
try
{
objvcc_CourseTypeEN.CourseTypeId = objRow[convcc_CourseType.CourseTypeId].ToString().Trim(); //课程类型ID
objvcc_CourseTypeEN.CourseTypeName = objRow[convcc_CourseType.CourseTypeName].ToString().Trim(); //课程类型名称
objvcc_CourseTypeEN.IdSchool = objRow[convcc_CourseType.IdSchool] == DBNull.Value ? null : objRow[convcc_CourseType.IdSchool].ToString().Trim(); //学校流水号
objvcc_CourseTypeEN.SchoolId = objRow[convcc_CourseType.SchoolId].ToString().Trim(); //学校编号
objvcc_CourseTypeEN.SchoolName = objRow[convcc_CourseType.SchoolName].ToString().Trim(); //学校名称
objvcc_CourseTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseType.IsUse].ToString().Trim()); //是否使用
objvcc_CourseTypeEN.UpdDate = objRow[convcc_CourseType.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseType.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseTypeEN.UpdUserId = objRow[convcc_CourseType.UpdUserId] == DBNull.Value ? null : objRow[convcc_CourseType.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_CourseTypeEN.Memo = objRow[convcc_CourseType.Memo] == DBNull.Value ? null : objRow[convcc_CourseType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseTypeEN.CourseTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvcc_CourseTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvcc_CourseType(ref clsvcc_CourseTypeEN objvcc_CourseTypeEN)
{
bool bolResult = vcc_CourseTypeDA.Getvcc_CourseType(ref objvcc_CourseTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strCourseTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_CourseTypeEN GetObjByCourseTypeId(string strCourseTypeId)
{
if (strCourseTypeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strCourseTypeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strCourseTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strCourseTypeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvcc_CourseTypeEN objvcc_CourseTypeEN = vcc_CourseTypeDA.GetObjByCourseTypeId(strCourseTypeId);
return objvcc_CourseTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvcc_CourseTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvcc_CourseTypeEN objvcc_CourseTypeEN = vcc_CourseTypeDA.GetFirstObj(strWhereCond);
 return objvcc_CourseTypeEN;
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
public static clsvcc_CourseTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvcc_CourseTypeEN objvcc_CourseTypeEN = vcc_CourseTypeDA.GetObjByDataRow(objRow);
 return objvcc_CourseTypeEN;
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
public static clsvcc_CourseTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvcc_CourseTypeEN objvcc_CourseTypeEN = vcc_CourseTypeDA.GetObjByDataRow(objRow);
 return objvcc_CourseTypeEN;
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
 /// <param name = "strCourseTypeId">所给的关键字</param>
 /// <param name = "lstvcc_CourseTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_CourseTypeEN GetObjByCourseTypeIdFromList(string strCourseTypeId, List<clsvcc_CourseTypeEN> lstvcc_CourseTypeObjLst)
{
foreach (clsvcc_CourseTypeEN objvcc_CourseTypeEN in lstvcc_CourseTypeObjLst)
{
if (objvcc_CourseTypeEN.CourseTypeId == strCourseTypeId)
{
return objvcc_CourseTypeEN;
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
 string strCourseTypeId;
 try
 {
 strCourseTypeId = new clsvcc_CourseTypeDA().GetFirstID(strWhereCond);
 return strCourseTypeId;
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
 arrList = vcc_CourseTypeDA.GetID(strWhereCond);
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
bool bolIsExist = vcc_CourseTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strCourseTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strCourseTypeId)
{
if (string.IsNullOrEmpty(strCourseTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strCourseTypeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vcc_CourseTypeDA.IsExist(strCourseTypeId);
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
 bolIsExist = clsvcc_CourseTypeDA.IsExistTable();
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
 bolIsExist = vcc_CourseTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objvcc_CourseTypeENS">源对象</param>
 /// <param name = "objvcc_CourseTypeENT">目标对象</param>
 public static void CopyTo(clsvcc_CourseTypeEN objvcc_CourseTypeENS, clsvcc_CourseTypeEN objvcc_CourseTypeENT)
{
try
{
objvcc_CourseTypeENT.CourseTypeId = objvcc_CourseTypeENS.CourseTypeId; //课程类型ID
objvcc_CourseTypeENT.CourseTypeName = objvcc_CourseTypeENS.CourseTypeName; //课程类型名称
objvcc_CourseTypeENT.IdSchool = objvcc_CourseTypeENS.IdSchool; //学校流水号
objvcc_CourseTypeENT.SchoolId = objvcc_CourseTypeENS.SchoolId; //学校编号
objvcc_CourseTypeENT.SchoolName = objvcc_CourseTypeENS.SchoolName; //学校名称
objvcc_CourseTypeENT.IsUse = objvcc_CourseTypeENS.IsUse; //是否使用
objvcc_CourseTypeENT.UpdDate = objvcc_CourseTypeENS.UpdDate; //修改日期
objvcc_CourseTypeENT.UpdUserId = objvcc_CourseTypeENS.UpdUserId; //修改用户Id
objvcc_CourseTypeENT.Memo = objvcc_CourseTypeENS.Memo; //备注
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
 /// <param name = "objvcc_CourseTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsvcc_CourseTypeEN objvcc_CourseTypeEN)
{
try
{
objvcc_CourseTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvcc_CourseTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convcc_CourseType.CourseTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTypeEN.CourseTypeId = objvcc_CourseTypeEN.CourseTypeId; //课程类型ID
}
if (arrFldSet.Contains(convcc_CourseType.CourseTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTypeEN.CourseTypeName = objvcc_CourseTypeEN.CourseTypeName; //课程类型名称
}
if (arrFldSet.Contains(convcc_CourseType.IdSchool, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTypeEN.IdSchool = objvcc_CourseTypeEN.IdSchool == "[null]" ? null :  objvcc_CourseTypeEN.IdSchool; //学校流水号
}
if (arrFldSet.Contains(convcc_CourseType.SchoolId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTypeEN.SchoolId = objvcc_CourseTypeEN.SchoolId; //学校编号
}
if (arrFldSet.Contains(convcc_CourseType.SchoolName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTypeEN.SchoolName = objvcc_CourseTypeEN.SchoolName; //学校名称
}
if (arrFldSet.Contains(convcc_CourseType.IsUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTypeEN.IsUse = objvcc_CourseTypeEN.IsUse; //是否使用
}
if (arrFldSet.Contains(convcc_CourseType.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTypeEN.UpdDate = objvcc_CourseTypeEN.UpdDate == "[null]" ? null :  objvcc_CourseTypeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convcc_CourseType.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTypeEN.UpdUserId = objvcc_CourseTypeEN.UpdUserId == "[null]" ? null :  objvcc_CourseTypeEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convcc_CourseType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTypeEN.Memo = objvcc_CourseTypeEN.Memo == "[null]" ? null :  objvcc_CourseTypeEN.Memo; //备注
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
 /// <param name = "objvcc_CourseTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsvcc_CourseTypeEN objvcc_CourseTypeEN)
{
try
{
if (objvcc_CourseTypeEN.IdSchool == "[null]") objvcc_CourseTypeEN.IdSchool = null; //学校流水号
if (objvcc_CourseTypeEN.UpdDate == "[null]") objvcc_CourseTypeEN.UpdDate = null; //修改日期
if (objvcc_CourseTypeEN.UpdUserId == "[null]") objvcc_CourseTypeEN.UpdUserId = null; //修改用户Id
if (objvcc_CourseTypeEN.Memo == "[null]") objvcc_CourseTypeEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvcc_CourseTypeEN objvcc_CourseTypeEN)
{
 vcc_CourseTypeDA.CheckProperty4Condition(objvcc_CourseTypeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_CourseTypeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convcc_CourseType.CourseTypeId); 
List<clsvcc_CourseTypeEN> arrObjLst = clsvcc_CourseTypeBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvcc_CourseTypeEN objvcc_CourseTypeEN = new clsvcc_CourseTypeEN()
{
CourseTypeId = "0",
CourseTypeName = "选[v课程类型]..."
};
arrObjLst.Insert(0, objvcc_CourseTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convcc_CourseType.CourseTypeId;
objComboBox.DisplayMember = convcc_CourseType.CourseTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_CourseTypeId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v课程类型]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convcc_CourseType.CourseTypeId); 
IEnumerable<clsvcc_CourseTypeEN> arrObjLst = clsvcc_CourseTypeBL.GetObjLst(strCondition);
objDDL.DataValueField = convcc_CourseType.CourseTypeId;
objDDL.DataTextField = convcc_CourseType.CourseTypeName;
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
public static void BindDdl_CourseTypeIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v课程类型]...","0");
List<clsvcc_CourseTypeEN> arrvcc_CourseTypeObjLst = GetAllvcc_CourseTypeObjLstCache(); 
objDDL.DataValueField = convcc_CourseType.CourseTypeId;
objDDL.DataTextField = convcc_CourseType.CourseTypeName;
objDDL.DataSource = arrvcc_CourseTypeObjLst;
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
if (clscc_CourseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseTypeBL没有刷新缓存机制(clscc_CourseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by CourseTypeId");
//if (arrvcc_CourseTypeObjLstCache == null)
//{
//arrvcc_CourseTypeObjLstCache = vcc_CourseTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strCourseTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_CourseTypeEN GetObjByCourseTypeIdCache(string strCourseTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvcc_CourseTypeEN._CurrTabName);
List<clsvcc_CourseTypeEN> arrvcc_CourseTypeObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_CourseTypeEN> arrvcc_CourseTypeObjLst_Sel =
arrvcc_CourseTypeObjLstCache
.Where(x=> x.CourseTypeId == strCourseTypeId 
);
if (arrvcc_CourseTypeObjLst_Sel.Count() == 0)
{
   clsvcc_CourseTypeEN obj = clsvcc_CourseTypeBL.GetObjByCourseTypeId(strCourseTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvcc_CourseTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCourseTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetCourseTypeNameByCourseTypeIdCache(string strCourseTypeId)
{
if (string.IsNullOrEmpty(strCourseTypeId) == true) return "";
//获取缓存中的对象列表
clsvcc_CourseTypeEN objvcc_CourseType = GetObjByCourseTypeIdCache(strCourseTypeId);
if (objvcc_CourseType == null) return "";
return objvcc_CourseType.CourseTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCourseTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByCourseTypeIdCache(string strCourseTypeId)
{
if (string.IsNullOrEmpty(strCourseTypeId) == true) return "";
//获取缓存中的对象列表
clsvcc_CourseTypeEN objvcc_CourseType = GetObjByCourseTypeIdCache(strCourseTypeId);
if (objvcc_CourseType == null) return "";
return objvcc_CourseType.CourseTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_CourseTypeEN> GetAllvcc_CourseTypeObjLstCache()
{
//获取缓存中的对象列表
List<clsvcc_CourseTypeEN> arrvcc_CourseTypeObjLstCache = GetObjLstCache(); 
return arrvcc_CourseTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_CourseTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvcc_CourseTypeEN._CurrTabName);
List<clsvcc_CourseTypeEN> arrvcc_CourseTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvcc_CourseTypeObjLstCache;
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
string strKey = string.Format("{0}", clsvcc_CourseTypeEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strCourseTypeId)
{
if (strInFldName != convcc_CourseType.CourseTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convcc_CourseType.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convcc_CourseType.AttributeName));
throw new Exception(strMsg);
}
var objvcc_CourseType = clsvcc_CourseTypeBL.GetObjByCourseTypeIdCache(strCourseTypeId);
if (objvcc_CourseType == null) return "";
return objvcc_CourseType[strOutFldName].ToString();
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
int intRecCount = clsvcc_CourseTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsvcc_CourseTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvcc_CourseTypeDA.GetRecCount();
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
int intRecCount = clsvcc_CourseTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvcc_CourseTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvcc_CourseTypeEN objvcc_CourseTypeCond)
{
List<clsvcc_CourseTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_CourseTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_CourseType.AttributeName)
{
if (objvcc_CourseTypeCond.IsUpdated(strFldName) == false) continue;
if (objvcc_CourseTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseTypeCond[strFldName].ToString());
}
else
{
if (objvcc_CourseTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_CourseTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_CourseTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_CourseTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_CourseTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_CourseTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_CourseTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_CourseTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_CourseTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_CourseTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_CourseTypeCond[strFldName]));
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
 List<string> arrList = clsvcc_CourseTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vcc_CourseTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vcc_CourseTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}