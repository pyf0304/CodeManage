
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionType4CourseBL
 表名:vQuestionType4Course(01120340)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:12
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
public static class  clsvQuestionType4CourseBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strQuestionTypeId4Course">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQuestionType4CourseEN GetObj(this K_QuestionTypeId4Course_vQuestionType4Course myKey)
{
clsvQuestionType4CourseEN objvQuestionType4CourseEN = clsvQuestionType4CourseBL.vQuestionType4CourseDA.GetObjByQuestionTypeId4Course(myKey.Value);
return objvQuestionType4CourseEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionType4CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionType4CourseEN SetQuestionTypeId4Course(this clsvQuestionType4CourseEN objvQuestionType4CourseEN, string strQuestionTypeId4Course, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeId4Course, 8, convQuestionType4Course.QuestionTypeId4Course);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId4Course, 8, convQuestionType4Course.QuestionTypeId4Course);
}
objvQuestionType4CourseEN.QuestionTypeId4Course = strQuestionTypeId4Course; //题目类型Id4课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionType4CourseEN.dicFldComparisonOp.ContainsKey(convQuestionType4Course.QuestionTypeId4Course) == false)
{
objvQuestionType4CourseEN.dicFldComparisonOp.Add(convQuestionType4Course.QuestionTypeId4Course, strComparisonOp);
}
else
{
objvQuestionType4CourseEN.dicFldComparisonOp[convQuestionType4Course.QuestionTypeId4Course] = strComparisonOp;
}
}
return objvQuestionType4CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionType4CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionType4CourseEN SetQuestionTypeName4Course(this clsvQuestionType4CourseEN objvQuestionType4CourseEN, string strQuestionTypeName4Course, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionTypeName4Course, convQuestionType4Course.QuestionTypeName4Course);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeName4Course, 30, convQuestionType4Course.QuestionTypeName4Course);
}
objvQuestionType4CourseEN.QuestionTypeName4Course = strQuestionTypeName4Course; //题目类型名4课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionType4CourseEN.dicFldComparisonOp.ContainsKey(convQuestionType4Course.QuestionTypeName4Course) == false)
{
objvQuestionType4CourseEN.dicFldComparisonOp.Add(convQuestionType4Course.QuestionTypeName4Course, strComparisonOp);
}
else
{
objvQuestionType4CourseEN.dicFldComparisonOp[convQuestionType4Course.QuestionTypeName4Course] = strComparisonOp;
}
}
return objvQuestionType4CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionType4CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionType4CourseEN SetCourseId(this clsvQuestionType4CourseEN objvQuestionType4CourseEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convQuestionType4Course.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convQuestionType4Course.CourseId);
}
objvQuestionType4CourseEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionType4CourseEN.dicFldComparisonOp.ContainsKey(convQuestionType4Course.CourseId) == false)
{
objvQuestionType4CourseEN.dicFldComparisonOp.Add(convQuestionType4Course.CourseId, strComparisonOp);
}
else
{
objvQuestionType4CourseEN.dicFldComparisonOp[convQuestionType4Course.CourseId] = strComparisonOp;
}
}
return objvQuestionType4CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionType4CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionType4CourseEN SetCourseName(this clsvQuestionType4CourseEN objvQuestionType4CourseEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convQuestionType4Course.CourseName);
}
objvQuestionType4CourseEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionType4CourseEN.dicFldComparisonOp.ContainsKey(convQuestionType4Course.CourseName) == false)
{
objvQuestionType4CourseEN.dicFldComparisonOp.Add(convQuestionType4Course.CourseName, strComparisonOp);
}
else
{
objvQuestionType4CourseEN.dicFldComparisonOp[convQuestionType4Course.CourseName] = strComparisonOp;
}
}
return objvQuestionType4CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionType4CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionType4CourseEN SetOrderNum(this clsvQuestionType4CourseEN objvQuestionType4CourseEN, int? intOrderNum, string strComparisonOp="")
	{
objvQuestionType4CourseEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionType4CourseEN.dicFldComparisonOp.ContainsKey(convQuestionType4Course.OrderNum) == false)
{
objvQuestionType4CourseEN.dicFldComparisonOp.Add(convQuestionType4Course.OrderNum, strComparisonOp);
}
else
{
objvQuestionType4CourseEN.dicFldComparisonOp[convQuestionType4Course.OrderNum] = strComparisonOp;
}
}
return objvQuestionType4CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionType4CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionType4CourseEN SetIsUse(this clsvQuestionType4CourseEN objvQuestionType4CourseEN, bool bolIsUse, string strComparisonOp="")
	{
objvQuestionType4CourseEN.IsUse = bolIsUse; //是否使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionType4CourseEN.dicFldComparisonOp.ContainsKey(convQuestionType4Course.IsUse) == false)
{
objvQuestionType4CourseEN.dicFldComparisonOp.Add(convQuestionType4Course.IsUse, strComparisonOp);
}
else
{
objvQuestionType4CourseEN.dicFldComparisonOp[convQuestionType4Course.IsUse] = strComparisonOp;
}
}
return objvQuestionType4CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionType4CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionType4CourseEN SetUpdDate(this clsvQuestionType4CourseEN objvQuestionType4CourseEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convQuestionType4Course.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQuestionType4Course.UpdDate);
}
objvQuestionType4CourseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionType4CourseEN.dicFldComparisonOp.ContainsKey(convQuestionType4Course.UpdDate) == false)
{
objvQuestionType4CourseEN.dicFldComparisonOp.Add(convQuestionType4Course.UpdDate, strComparisonOp);
}
else
{
objvQuestionType4CourseEN.dicFldComparisonOp[convQuestionType4Course.UpdDate] = strComparisonOp;
}
}
return objvQuestionType4CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionType4CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionType4CourseEN SetUpdUser(this clsvQuestionType4CourseEN objvQuestionType4CourseEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convQuestionType4Course.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convQuestionType4Course.UpdUser);
}
objvQuestionType4CourseEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionType4CourseEN.dicFldComparisonOp.ContainsKey(convQuestionType4Course.UpdUser) == false)
{
objvQuestionType4CourseEN.dicFldComparisonOp.Add(convQuestionType4Course.UpdUser, strComparisonOp);
}
else
{
objvQuestionType4CourseEN.dicFldComparisonOp[convQuestionType4Course.UpdUser] = strComparisonOp;
}
}
return objvQuestionType4CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionType4CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionType4CourseEN SetMemo(this clsvQuestionType4CourseEN objvQuestionType4CourseEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQuestionType4Course.Memo);
}
objvQuestionType4CourseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionType4CourseEN.dicFldComparisonOp.ContainsKey(convQuestionType4Course.Memo) == false)
{
objvQuestionType4CourseEN.dicFldComparisonOp.Add(convQuestionType4Course.Memo, strComparisonOp);
}
else
{
objvQuestionType4CourseEN.dicFldComparisonOp[convQuestionType4Course.Memo] = strComparisonOp;
}
}
return objvQuestionType4CourseEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvQuestionType4CourseENS">源对象</param>
 /// <param name = "objvQuestionType4CourseENT">目标对象</param>
 public static void CopyTo(this clsvQuestionType4CourseEN objvQuestionType4CourseENS, clsvQuestionType4CourseEN objvQuestionType4CourseENT)
{
try
{
objvQuestionType4CourseENT.QuestionTypeId4Course = objvQuestionType4CourseENS.QuestionTypeId4Course; //题目类型Id4课程
objvQuestionType4CourseENT.QuestionTypeName4Course = objvQuestionType4CourseENS.QuestionTypeName4Course; //题目类型名4课程
objvQuestionType4CourseENT.CourseId = objvQuestionType4CourseENS.CourseId; //课程Id
objvQuestionType4CourseENT.CourseName = objvQuestionType4CourseENS.CourseName; //课程名称
objvQuestionType4CourseENT.OrderNum = objvQuestionType4CourseENS.OrderNum; //序号
objvQuestionType4CourseENT.IsUse = objvQuestionType4CourseENS.IsUse; //是否使用
objvQuestionType4CourseENT.UpdDate = objvQuestionType4CourseENS.UpdDate; //修改日期
objvQuestionType4CourseENT.UpdUser = objvQuestionType4CourseENS.UpdUser; //修改人
objvQuestionType4CourseENT.Memo = objvQuestionType4CourseENS.Memo; //备注
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
 /// <param name = "objvQuestionType4CourseENS">源对象</param>
 /// <returns>目标对象=>clsvQuestionType4CourseEN:objvQuestionType4CourseENT</returns>
 public static clsvQuestionType4CourseEN CopyTo(this clsvQuestionType4CourseEN objvQuestionType4CourseENS)
{
try
{
 clsvQuestionType4CourseEN objvQuestionType4CourseENT = new clsvQuestionType4CourseEN()
{
QuestionTypeId4Course = objvQuestionType4CourseENS.QuestionTypeId4Course, //题目类型Id4课程
QuestionTypeName4Course = objvQuestionType4CourseENS.QuestionTypeName4Course, //题目类型名4课程
CourseId = objvQuestionType4CourseENS.CourseId, //课程Id
CourseName = objvQuestionType4CourseENS.CourseName, //课程名称
OrderNum = objvQuestionType4CourseENS.OrderNum, //序号
IsUse = objvQuestionType4CourseENS.IsUse, //是否使用
UpdDate = objvQuestionType4CourseENS.UpdDate, //修改日期
UpdUser = objvQuestionType4CourseENS.UpdUser, //修改人
Memo = objvQuestionType4CourseENS.Memo, //备注
};
 return objvQuestionType4CourseENT;
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
public static void CheckProperty4Condition(this clsvQuestionType4CourseEN objvQuestionType4CourseEN)
{
 clsvQuestionType4CourseBL.vQuestionType4CourseDA.CheckProperty4Condition(objvQuestionType4CourseEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQuestionType4CourseEN objvQuestionType4CourseCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQuestionType4CourseCond.IsUpdated(convQuestionType4Course.QuestionTypeId4Course) == true)
{
string strComparisonOpQuestionTypeId4Course = objvQuestionType4CourseCond.dicFldComparisonOp[convQuestionType4Course.QuestionTypeId4Course];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionType4Course.QuestionTypeId4Course, objvQuestionType4CourseCond.QuestionTypeId4Course, strComparisonOpQuestionTypeId4Course);
}
if (objvQuestionType4CourseCond.IsUpdated(convQuestionType4Course.QuestionTypeName4Course) == true)
{
string strComparisonOpQuestionTypeName4Course = objvQuestionType4CourseCond.dicFldComparisonOp[convQuestionType4Course.QuestionTypeName4Course];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionType4Course.QuestionTypeName4Course, objvQuestionType4CourseCond.QuestionTypeName4Course, strComparisonOpQuestionTypeName4Course);
}
if (objvQuestionType4CourseCond.IsUpdated(convQuestionType4Course.CourseId) == true)
{
string strComparisonOpCourseId = objvQuestionType4CourseCond.dicFldComparisonOp[convQuestionType4Course.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionType4Course.CourseId, objvQuestionType4CourseCond.CourseId, strComparisonOpCourseId);
}
if (objvQuestionType4CourseCond.IsUpdated(convQuestionType4Course.CourseName) == true)
{
string strComparisonOpCourseName = objvQuestionType4CourseCond.dicFldComparisonOp[convQuestionType4Course.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionType4Course.CourseName, objvQuestionType4CourseCond.CourseName, strComparisonOpCourseName);
}
if (objvQuestionType4CourseCond.IsUpdated(convQuestionType4Course.OrderNum) == true)
{
string strComparisonOpOrderNum = objvQuestionType4CourseCond.dicFldComparisonOp[convQuestionType4Course.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionType4Course.OrderNum, objvQuestionType4CourseCond.OrderNum, strComparisonOpOrderNum);
}
if (objvQuestionType4CourseCond.IsUpdated(convQuestionType4Course.IsUse) == true)
{
if (objvQuestionType4CourseCond.IsUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQuestionType4Course.IsUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQuestionType4Course.IsUse);
}
}
if (objvQuestionType4CourseCond.IsUpdated(convQuestionType4Course.UpdDate) == true)
{
string strComparisonOpUpdDate = objvQuestionType4CourseCond.dicFldComparisonOp[convQuestionType4Course.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionType4Course.UpdDate, objvQuestionType4CourseCond.UpdDate, strComparisonOpUpdDate);
}
if (objvQuestionType4CourseCond.IsUpdated(convQuestionType4Course.UpdUser) == true)
{
string strComparisonOpUpdUser = objvQuestionType4CourseCond.dicFldComparisonOp[convQuestionType4Course.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionType4Course.UpdUser, objvQuestionType4CourseCond.UpdUser, strComparisonOpUpdUser);
}
if (objvQuestionType4CourseCond.IsUpdated(convQuestionType4Course.Memo) == true)
{
string strComparisonOpMemo = objvQuestionType4CourseCond.dicFldComparisonOp[convQuestionType4Course.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionType4Course.Memo, objvQuestionType4CourseCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vQuestionType4Course
{
public virtual bool UpdRelaTabDate(string strQuestionTypeId4Course, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v题目类型4课程(vQuestionType4Course)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvQuestionType4CourseBL
{
public static RelatedActions_vQuestionType4Course relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvQuestionType4CourseDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvQuestionType4CourseDA vQuestionType4CourseDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvQuestionType4CourseDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvQuestionType4CourseBL()
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
if (string.IsNullOrEmpty(clsvQuestionType4CourseEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQuestionType4CourseEN._ConnectString);
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
public static DataTable GetDataTable_vQuestionType4Course(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQuestionType4CourseDA.GetDataTable_vQuestionType4Course(strWhereCond);
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
objDT = vQuestionType4CourseDA.GetDataTable(strWhereCond);
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
objDT = vQuestionType4CourseDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vQuestionType4CourseDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vQuestionType4CourseDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vQuestionType4CourseDA.GetDataTable_Top(objTopPara);
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
objDT = vQuestionType4CourseDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vQuestionType4CourseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vQuestionType4CourseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrQuestionTypeId4CourseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvQuestionType4CourseEN> GetObjLstByQuestionTypeId4CourseLst(List<string> arrQuestionTypeId4CourseLst)
{
List<clsvQuestionType4CourseEN> arrObjLst = new List<clsvQuestionType4CourseEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrQuestionTypeId4CourseLst, true);
 string strWhereCond = string.Format("QuestionTypeId4Course in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionType4CourseEN objvQuestionType4CourseEN = new clsvQuestionType4CourseEN();
try
{
objvQuestionType4CourseEN.QuestionTypeId4Course = objRow[convQuestionType4Course.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvQuestionType4CourseEN.QuestionTypeName4Course = objRow[convQuestionType4Course.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objvQuestionType4CourseEN.CourseId = objRow[convQuestionType4Course.CourseId] == DBNull.Value ? null : objRow[convQuestionType4Course.CourseId].ToString().Trim(); //课程Id
objvQuestionType4CourseEN.CourseName = objRow[convQuestionType4Course.CourseName] == DBNull.Value ? null : objRow[convQuestionType4Course.CourseName].ToString().Trim(); //课程名称
objvQuestionType4CourseEN.OrderNum = objRow[convQuestionType4Course.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionType4Course.OrderNum].ToString().Trim()); //序号
objvQuestionType4CourseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convQuestionType4Course.IsUse].ToString().Trim()); //是否使用
objvQuestionType4CourseEN.UpdDate = objRow[convQuestionType4Course.UpdDate].ToString().Trim(); //修改日期
objvQuestionType4CourseEN.UpdUser = objRow[convQuestionType4Course.UpdUser].ToString().Trim(); //修改人
objvQuestionType4CourseEN.Memo = objRow[convQuestionType4Course.Memo] == DBNull.Value ? null : objRow[convQuestionType4Course.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionType4CourseEN.QuestionTypeId4Course, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionType4CourseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrQuestionTypeId4CourseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvQuestionType4CourseEN> GetObjLstByQuestionTypeId4CourseLstCache(List<string> arrQuestionTypeId4CourseLst)
{
string strKey = string.Format("{0}", clsvQuestionType4CourseEN._CurrTabName);
List<clsvQuestionType4CourseEN> arrvQuestionType4CourseObjLstCache = GetObjLstCache();
IEnumerable <clsvQuestionType4CourseEN> arrvQuestionType4CourseObjLst_Sel =
arrvQuestionType4CourseObjLstCache
.Where(x => arrQuestionTypeId4CourseLst.Contains(x.QuestionTypeId4Course));
return arrvQuestionType4CourseObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionType4CourseEN> GetObjLst(string strWhereCond)
{
List<clsvQuestionType4CourseEN> arrObjLst = new List<clsvQuestionType4CourseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionType4CourseEN objvQuestionType4CourseEN = new clsvQuestionType4CourseEN();
try
{
objvQuestionType4CourseEN.QuestionTypeId4Course = objRow[convQuestionType4Course.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvQuestionType4CourseEN.QuestionTypeName4Course = objRow[convQuestionType4Course.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objvQuestionType4CourseEN.CourseId = objRow[convQuestionType4Course.CourseId] == DBNull.Value ? null : objRow[convQuestionType4Course.CourseId].ToString().Trim(); //课程Id
objvQuestionType4CourseEN.CourseName = objRow[convQuestionType4Course.CourseName] == DBNull.Value ? null : objRow[convQuestionType4Course.CourseName].ToString().Trim(); //课程名称
objvQuestionType4CourseEN.OrderNum = objRow[convQuestionType4Course.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionType4Course.OrderNum].ToString().Trim()); //序号
objvQuestionType4CourseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convQuestionType4Course.IsUse].ToString().Trim()); //是否使用
objvQuestionType4CourseEN.UpdDate = objRow[convQuestionType4Course.UpdDate].ToString().Trim(); //修改日期
objvQuestionType4CourseEN.UpdUser = objRow[convQuestionType4Course.UpdUser].ToString().Trim(); //修改人
objvQuestionType4CourseEN.Memo = objRow[convQuestionType4Course.Memo] == DBNull.Value ? null : objRow[convQuestionType4Course.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionType4CourseEN.QuestionTypeId4Course, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionType4CourseEN);
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
public static List<clsvQuestionType4CourseEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQuestionType4CourseEN> arrObjLst = new List<clsvQuestionType4CourseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionType4CourseEN objvQuestionType4CourseEN = new clsvQuestionType4CourseEN();
try
{
objvQuestionType4CourseEN.QuestionTypeId4Course = objRow[convQuestionType4Course.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvQuestionType4CourseEN.QuestionTypeName4Course = objRow[convQuestionType4Course.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objvQuestionType4CourseEN.CourseId = objRow[convQuestionType4Course.CourseId] == DBNull.Value ? null : objRow[convQuestionType4Course.CourseId].ToString().Trim(); //课程Id
objvQuestionType4CourseEN.CourseName = objRow[convQuestionType4Course.CourseName] == DBNull.Value ? null : objRow[convQuestionType4Course.CourseName].ToString().Trim(); //课程名称
objvQuestionType4CourseEN.OrderNum = objRow[convQuestionType4Course.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionType4Course.OrderNum].ToString().Trim()); //序号
objvQuestionType4CourseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convQuestionType4Course.IsUse].ToString().Trim()); //是否使用
objvQuestionType4CourseEN.UpdDate = objRow[convQuestionType4Course.UpdDate].ToString().Trim(); //修改日期
objvQuestionType4CourseEN.UpdUser = objRow[convQuestionType4Course.UpdUser].ToString().Trim(); //修改人
objvQuestionType4CourseEN.Memo = objRow[convQuestionType4Course.Memo] == DBNull.Value ? null : objRow[convQuestionType4Course.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionType4CourseEN.QuestionTypeId4Course, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionType4CourseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvQuestionType4CourseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvQuestionType4CourseEN> GetSubObjLstCache(clsvQuestionType4CourseEN objvQuestionType4CourseCond)
{
List<clsvQuestionType4CourseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQuestionType4CourseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQuestionType4Course.AttributeName)
{
if (objvQuestionType4CourseCond.IsUpdated(strFldName) == false) continue;
if (objvQuestionType4CourseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionType4CourseCond[strFldName].ToString());
}
else
{
if (objvQuestionType4CourseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQuestionType4CourseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionType4CourseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQuestionType4CourseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQuestionType4CourseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQuestionType4CourseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQuestionType4CourseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQuestionType4CourseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQuestionType4CourseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQuestionType4CourseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQuestionType4CourseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQuestionType4CourseCond[strFldName]));
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
public static List<clsvQuestionType4CourseEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvQuestionType4CourseEN> arrObjLst = new List<clsvQuestionType4CourseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionType4CourseEN objvQuestionType4CourseEN = new clsvQuestionType4CourseEN();
try
{
objvQuestionType4CourseEN.QuestionTypeId4Course = objRow[convQuestionType4Course.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvQuestionType4CourseEN.QuestionTypeName4Course = objRow[convQuestionType4Course.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objvQuestionType4CourseEN.CourseId = objRow[convQuestionType4Course.CourseId] == DBNull.Value ? null : objRow[convQuestionType4Course.CourseId].ToString().Trim(); //课程Id
objvQuestionType4CourseEN.CourseName = objRow[convQuestionType4Course.CourseName] == DBNull.Value ? null : objRow[convQuestionType4Course.CourseName].ToString().Trim(); //课程名称
objvQuestionType4CourseEN.OrderNum = objRow[convQuestionType4Course.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionType4Course.OrderNum].ToString().Trim()); //序号
objvQuestionType4CourseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convQuestionType4Course.IsUse].ToString().Trim()); //是否使用
objvQuestionType4CourseEN.UpdDate = objRow[convQuestionType4Course.UpdDate].ToString().Trim(); //修改日期
objvQuestionType4CourseEN.UpdUser = objRow[convQuestionType4Course.UpdUser].ToString().Trim(); //修改人
objvQuestionType4CourseEN.Memo = objRow[convQuestionType4Course.Memo] == DBNull.Value ? null : objRow[convQuestionType4Course.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionType4CourseEN.QuestionTypeId4Course, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionType4CourseEN);
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
public static List<clsvQuestionType4CourseEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvQuestionType4CourseEN> arrObjLst = new List<clsvQuestionType4CourseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionType4CourseEN objvQuestionType4CourseEN = new clsvQuestionType4CourseEN();
try
{
objvQuestionType4CourseEN.QuestionTypeId4Course = objRow[convQuestionType4Course.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvQuestionType4CourseEN.QuestionTypeName4Course = objRow[convQuestionType4Course.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objvQuestionType4CourseEN.CourseId = objRow[convQuestionType4Course.CourseId] == DBNull.Value ? null : objRow[convQuestionType4Course.CourseId].ToString().Trim(); //课程Id
objvQuestionType4CourseEN.CourseName = objRow[convQuestionType4Course.CourseName] == DBNull.Value ? null : objRow[convQuestionType4Course.CourseName].ToString().Trim(); //课程名称
objvQuestionType4CourseEN.OrderNum = objRow[convQuestionType4Course.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionType4Course.OrderNum].ToString().Trim()); //序号
objvQuestionType4CourseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convQuestionType4Course.IsUse].ToString().Trim()); //是否使用
objvQuestionType4CourseEN.UpdDate = objRow[convQuestionType4Course.UpdDate].ToString().Trim(); //修改日期
objvQuestionType4CourseEN.UpdUser = objRow[convQuestionType4Course.UpdUser].ToString().Trim(); //修改人
objvQuestionType4CourseEN.Memo = objRow[convQuestionType4Course.Memo] == DBNull.Value ? null : objRow[convQuestionType4Course.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionType4CourseEN.QuestionTypeId4Course, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionType4CourseEN);
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
List<clsvQuestionType4CourseEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvQuestionType4CourseEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionType4CourseEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvQuestionType4CourseEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvQuestionType4CourseEN> arrObjLst = new List<clsvQuestionType4CourseEN>(); 
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
	clsvQuestionType4CourseEN objvQuestionType4CourseEN = new clsvQuestionType4CourseEN();
try
{
objvQuestionType4CourseEN.QuestionTypeId4Course = objRow[convQuestionType4Course.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvQuestionType4CourseEN.QuestionTypeName4Course = objRow[convQuestionType4Course.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objvQuestionType4CourseEN.CourseId = objRow[convQuestionType4Course.CourseId] == DBNull.Value ? null : objRow[convQuestionType4Course.CourseId].ToString().Trim(); //课程Id
objvQuestionType4CourseEN.CourseName = objRow[convQuestionType4Course.CourseName] == DBNull.Value ? null : objRow[convQuestionType4Course.CourseName].ToString().Trim(); //课程名称
objvQuestionType4CourseEN.OrderNum = objRow[convQuestionType4Course.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionType4Course.OrderNum].ToString().Trim()); //序号
objvQuestionType4CourseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convQuestionType4Course.IsUse].ToString().Trim()); //是否使用
objvQuestionType4CourseEN.UpdDate = objRow[convQuestionType4Course.UpdDate].ToString().Trim(); //修改日期
objvQuestionType4CourseEN.UpdUser = objRow[convQuestionType4Course.UpdUser].ToString().Trim(); //修改人
objvQuestionType4CourseEN.Memo = objRow[convQuestionType4Course.Memo] == DBNull.Value ? null : objRow[convQuestionType4Course.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionType4CourseEN.QuestionTypeId4Course, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionType4CourseEN);
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
public static List<clsvQuestionType4CourseEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvQuestionType4CourseEN> arrObjLst = new List<clsvQuestionType4CourseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionType4CourseEN objvQuestionType4CourseEN = new clsvQuestionType4CourseEN();
try
{
objvQuestionType4CourseEN.QuestionTypeId4Course = objRow[convQuestionType4Course.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvQuestionType4CourseEN.QuestionTypeName4Course = objRow[convQuestionType4Course.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objvQuestionType4CourseEN.CourseId = objRow[convQuestionType4Course.CourseId] == DBNull.Value ? null : objRow[convQuestionType4Course.CourseId].ToString().Trim(); //课程Id
objvQuestionType4CourseEN.CourseName = objRow[convQuestionType4Course.CourseName] == DBNull.Value ? null : objRow[convQuestionType4Course.CourseName].ToString().Trim(); //课程名称
objvQuestionType4CourseEN.OrderNum = objRow[convQuestionType4Course.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionType4Course.OrderNum].ToString().Trim()); //序号
objvQuestionType4CourseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convQuestionType4Course.IsUse].ToString().Trim()); //是否使用
objvQuestionType4CourseEN.UpdDate = objRow[convQuestionType4Course.UpdDate].ToString().Trim(); //修改日期
objvQuestionType4CourseEN.UpdUser = objRow[convQuestionType4Course.UpdUser].ToString().Trim(); //修改人
objvQuestionType4CourseEN.Memo = objRow[convQuestionType4Course.Memo] == DBNull.Value ? null : objRow[convQuestionType4Course.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionType4CourseEN.QuestionTypeId4Course, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionType4CourseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQuestionType4CourseEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvQuestionType4CourseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvQuestionType4CourseEN> arrObjLst = new List<clsvQuestionType4CourseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionType4CourseEN objvQuestionType4CourseEN = new clsvQuestionType4CourseEN();
try
{
objvQuestionType4CourseEN.QuestionTypeId4Course = objRow[convQuestionType4Course.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvQuestionType4CourseEN.QuestionTypeName4Course = objRow[convQuestionType4Course.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objvQuestionType4CourseEN.CourseId = objRow[convQuestionType4Course.CourseId] == DBNull.Value ? null : objRow[convQuestionType4Course.CourseId].ToString().Trim(); //课程Id
objvQuestionType4CourseEN.CourseName = objRow[convQuestionType4Course.CourseName] == DBNull.Value ? null : objRow[convQuestionType4Course.CourseName].ToString().Trim(); //课程名称
objvQuestionType4CourseEN.OrderNum = objRow[convQuestionType4Course.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionType4Course.OrderNum].ToString().Trim()); //序号
objvQuestionType4CourseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convQuestionType4Course.IsUse].ToString().Trim()); //是否使用
objvQuestionType4CourseEN.UpdDate = objRow[convQuestionType4Course.UpdDate].ToString().Trim(); //修改日期
objvQuestionType4CourseEN.UpdUser = objRow[convQuestionType4Course.UpdUser].ToString().Trim(); //修改人
objvQuestionType4CourseEN.Memo = objRow[convQuestionType4Course.Memo] == DBNull.Value ? null : objRow[convQuestionType4Course.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionType4CourseEN.QuestionTypeId4Course, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionType4CourseEN);
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
public static List<clsvQuestionType4CourseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvQuestionType4CourseEN> arrObjLst = new List<clsvQuestionType4CourseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionType4CourseEN objvQuestionType4CourseEN = new clsvQuestionType4CourseEN();
try
{
objvQuestionType4CourseEN.QuestionTypeId4Course = objRow[convQuestionType4Course.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvQuestionType4CourseEN.QuestionTypeName4Course = objRow[convQuestionType4Course.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objvQuestionType4CourseEN.CourseId = objRow[convQuestionType4Course.CourseId] == DBNull.Value ? null : objRow[convQuestionType4Course.CourseId].ToString().Trim(); //课程Id
objvQuestionType4CourseEN.CourseName = objRow[convQuestionType4Course.CourseName] == DBNull.Value ? null : objRow[convQuestionType4Course.CourseName].ToString().Trim(); //课程名称
objvQuestionType4CourseEN.OrderNum = objRow[convQuestionType4Course.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionType4Course.OrderNum].ToString().Trim()); //序号
objvQuestionType4CourseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convQuestionType4Course.IsUse].ToString().Trim()); //是否使用
objvQuestionType4CourseEN.UpdDate = objRow[convQuestionType4Course.UpdDate].ToString().Trim(); //修改日期
objvQuestionType4CourseEN.UpdUser = objRow[convQuestionType4Course.UpdUser].ToString().Trim(); //修改人
objvQuestionType4CourseEN.Memo = objRow[convQuestionType4Course.Memo] == DBNull.Value ? null : objRow[convQuestionType4Course.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionType4CourseEN.QuestionTypeId4Course, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionType4CourseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionType4CourseEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvQuestionType4CourseEN> arrObjLst = new List<clsvQuestionType4CourseEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionType4CourseEN objvQuestionType4CourseEN = new clsvQuestionType4CourseEN();
try
{
objvQuestionType4CourseEN.QuestionTypeId4Course = objRow[convQuestionType4Course.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvQuestionType4CourseEN.QuestionTypeName4Course = objRow[convQuestionType4Course.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objvQuestionType4CourseEN.CourseId = objRow[convQuestionType4Course.CourseId] == DBNull.Value ? null : objRow[convQuestionType4Course.CourseId].ToString().Trim(); //课程Id
objvQuestionType4CourseEN.CourseName = objRow[convQuestionType4Course.CourseName] == DBNull.Value ? null : objRow[convQuestionType4Course.CourseName].ToString().Trim(); //课程名称
objvQuestionType4CourseEN.OrderNum = objRow[convQuestionType4Course.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionType4Course.OrderNum].ToString().Trim()); //序号
objvQuestionType4CourseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convQuestionType4Course.IsUse].ToString().Trim()); //是否使用
objvQuestionType4CourseEN.UpdDate = objRow[convQuestionType4Course.UpdDate].ToString().Trim(); //修改日期
objvQuestionType4CourseEN.UpdUser = objRow[convQuestionType4Course.UpdUser].ToString().Trim(); //修改人
objvQuestionType4CourseEN.Memo = objRow[convQuestionType4Course.Memo] == DBNull.Value ? null : objRow[convQuestionType4Course.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionType4CourseEN.QuestionTypeId4Course, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionType4CourseEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvQuestionType4CourseEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQuestionType4Course(ref clsvQuestionType4CourseEN objvQuestionType4CourseEN)
{
bool bolResult = vQuestionType4CourseDA.GetvQuestionType4Course(ref objvQuestionType4CourseEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strQuestionTypeId4Course">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQuestionType4CourseEN GetObjByQuestionTypeId4Course(string strQuestionTypeId4Course)
{
if (strQuestionTypeId4Course.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strQuestionTypeId4Course]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strQuestionTypeId4Course) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strQuestionTypeId4Course]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvQuestionType4CourseEN objvQuestionType4CourseEN = vQuestionType4CourseDA.GetObjByQuestionTypeId4Course(strQuestionTypeId4Course);
return objvQuestionType4CourseEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvQuestionType4CourseEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvQuestionType4CourseEN objvQuestionType4CourseEN = vQuestionType4CourseDA.GetFirstObj(strWhereCond);
 return objvQuestionType4CourseEN;
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
public static clsvQuestionType4CourseEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvQuestionType4CourseEN objvQuestionType4CourseEN = vQuestionType4CourseDA.GetObjByDataRow(objRow);
 return objvQuestionType4CourseEN;
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
public static clsvQuestionType4CourseEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvQuestionType4CourseEN objvQuestionType4CourseEN = vQuestionType4CourseDA.GetObjByDataRow(objRow);
 return objvQuestionType4CourseEN;
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
 /// <param name = "strQuestionTypeId4Course">所给的关键字</param>
 /// <param name = "lstvQuestionType4CourseObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQuestionType4CourseEN GetObjByQuestionTypeId4CourseFromList(string strQuestionTypeId4Course, List<clsvQuestionType4CourseEN> lstvQuestionType4CourseObjLst)
{
foreach (clsvQuestionType4CourseEN objvQuestionType4CourseEN in lstvQuestionType4CourseObjLst)
{
if (objvQuestionType4CourseEN.QuestionTypeId4Course == strQuestionTypeId4Course)
{
return objvQuestionType4CourseEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetMaxStrId_S)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId_S() 
{
 string strMaxQuestionTypeId4Course;
 try
 {
 strMaxQuestionTypeId4Course = clsvQuestionType4CourseDA.GetMaxStrId();
 return strMaxQuestionTypeId4Course;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000024)获取最大关键字值出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond) 
{
 string strQuestionTypeId4Course;
 try
 {
 strQuestionTypeId4Course = new clsvQuestionType4CourseDA().GetFirstID(strWhereCond);
 return strQuestionTypeId4Course;
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
 arrList = vQuestionType4CourseDA.GetID(strWhereCond);
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
bool bolIsExist = vQuestionType4CourseDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strQuestionTypeId4Course">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strQuestionTypeId4Course)
{
if (string.IsNullOrEmpty(strQuestionTypeId4Course) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strQuestionTypeId4Course]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vQuestionType4CourseDA.IsExist(strQuestionTypeId4Course);
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
 bolIsExist = clsvQuestionType4CourseDA.IsExistTable();
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
 bolIsExist = vQuestionType4CourseDA.IsExistTable(strTabName);
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
 /// <param name = "objvQuestionType4CourseENS">源对象</param>
 /// <param name = "objvQuestionType4CourseENT">目标对象</param>
 public static void CopyTo(clsvQuestionType4CourseEN objvQuestionType4CourseENS, clsvQuestionType4CourseEN objvQuestionType4CourseENT)
{
try
{
objvQuestionType4CourseENT.QuestionTypeId4Course = objvQuestionType4CourseENS.QuestionTypeId4Course; //题目类型Id4课程
objvQuestionType4CourseENT.QuestionTypeName4Course = objvQuestionType4CourseENS.QuestionTypeName4Course; //题目类型名4课程
objvQuestionType4CourseENT.CourseId = objvQuestionType4CourseENS.CourseId; //课程Id
objvQuestionType4CourseENT.CourseName = objvQuestionType4CourseENS.CourseName; //课程名称
objvQuestionType4CourseENT.OrderNum = objvQuestionType4CourseENS.OrderNum; //序号
objvQuestionType4CourseENT.IsUse = objvQuestionType4CourseENS.IsUse; //是否使用
objvQuestionType4CourseENT.UpdDate = objvQuestionType4CourseENS.UpdDate; //修改日期
objvQuestionType4CourseENT.UpdUser = objvQuestionType4CourseENS.UpdUser; //修改人
objvQuestionType4CourseENT.Memo = objvQuestionType4CourseENS.Memo; //备注
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
 /// <param name = "objvQuestionType4CourseEN">源简化对象</param>
 public static void SetUpdFlag(clsvQuestionType4CourseEN objvQuestionType4CourseEN)
{
try
{
objvQuestionType4CourseEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvQuestionType4CourseEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convQuestionType4Course.QuestionTypeId4Course, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionType4CourseEN.QuestionTypeId4Course = objvQuestionType4CourseEN.QuestionTypeId4Course; //题目类型Id4课程
}
if (arrFldSet.Contains(convQuestionType4Course.QuestionTypeName4Course, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionType4CourseEN.QuestionTypeName4Course = objvQuestionType4CourseEN.QuestionTypeName4Course; //题目类型名4课程
}
if (arrFldSet.Contains(convQuestionType4Course.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionType4CourseEN.CourseId = objvQuestionType4CourseEN.CourseId == "[null]" ? null :  objvQuestionType4CourseEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convQuestionType4Course.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionType4CourseEN.CourseName = objvQuestionType4CourseEN.CourseName == "[null]" ? null :  objvQuestionType4CourseEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convQuestionType4Course.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionType4CourseEN.OrderNum = objvQuestionType4CourseEN.OrderNum; //序号
}
if (arrFldSet.Contains(convQuestionType4Course.IsUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionType4CourseEN.IsUse = objvQuestionType4CourseEN.IsUse; //是否使用
}
if (arrFldSet.Contains(convQuestionType4Course.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionType4CourseEN.UpdDate = objvQuestionType4CourseEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convQuestionType4Course.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionType4CourseEN.UpdUser = objvQuestionType4CourseEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convQuestionType4Course.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionType4CourseEN.Memo = objvQuestionType4CourseEN.Memo == "[null]" ? null :  objvQuestionType4CourseEN.Memo; //备注
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
 /// <param name = "objvQuestionType4CourseEN">源简化对象</param>
 public static void AccessFldValueNull(clsvQuestionType4CourseEN objvQuestionType4CourseEN)
{
try
{
if (objvQuestionType4CourseEN.CourseId == "[null]") objvQuestionType4CourseEN.CourseId = null; //课程Id
if (objvQuestionType4CourseEN.CourseName == "[null]") objvQuestionType4CourseEN.CourseName = null; //课程名称
if (objvQuestionType4CourseEN.Memo == "[null]") objvQuestionType4CourseEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvQuestionType4CourseEN objvQuestionType4CourseEN)
{
 vQuestionType4CourseDA.CheckProperty4Condition(objvQuestionType4CourseEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_QuestionTypeId4Course(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convQuestionType4Course.QuestionTypeId4Course); 
List<clsvQuestionType4CourseEN> arrObjLst = clsvQuestionType4CourseBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvQuestionType4CourseEN objvQuestionType4CourseEN = new clsvQuestionType4CourseEN()
{
QuestionTypeId4Course = "0",
QuestionTypeName4Course = "选[v题目类型4课程]..."
};
arrObjLst.Insert(0, objvQuestionType4CourseEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convQuestionType4Course.QuestionTypeId4Course;
objComboBox.DisplayMember = convQuestionType4Course.QuestionTypeName4Course;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_QuestionTypeId4Course(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v题目类型4课程]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convQuestionType4Course.QuestionTypeId4Course); 
IEnumerable<clsvQuestionType4CourseEN> arrObjLst = clsvQuestionType4CourseBL.GetObjLst(strCondition);
objDDL.DataValueField = convQuestionType4Course.QuestionTypeId4Course;
objDDL.DataTextField = convQuestionType4Course.QuestionTypeName4Course;
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
public static void BindDdl_QuestionTypeId4CourseCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v题目类型4课程]...","0");
List<clsvQuestionType4CourseEN> arrvQuestionType4CourseObjLst = GetAllvQuestionType4CourseObjLstCache(); 
objDDL.DataValueField = convQuestionType4Course.QuestionTypeId4Course;
objDDL.DataTextField = convQuestionType4Course.QuestionTypeName4Course;
objDDL.DataSource = arrvQuestionType4CourseObjLst;
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
if (clscc_CourseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseBL没有刷新缓存机制(clscc_CourseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionType4CourseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionType4CourseBL没有刷新缓存机制(clsQuestionType4CourseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by QuestionTypeId4Course");
//if (arrvQuestionType4CourseObjLstCache == null)
//{
//arrvQuestionType4CourseObjLstCache = vQuestionType4CourseDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strQuestionTypeId4Course">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQuestionType4CourseEN GetObjByQuestionTypeId4CourseCache(string strQuestionTypeId4Course)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvQuestionType4CourseEN._CurrTabName);
List<clsvQuestionType4CourseEN> arrvQuestionType4CourseObjLstCache = GetObjLstCache();
IEnumerable <clsvQuestionType4CourseEN> arrvQuestionType4CourseObjLst_Sel =
arrvQuestionType4CourseObjLstCache
.Where(x=> x.QuestionTypeId4Course == strQuestionTypeId4Course 
);
if (arrvQuestionType4CourseObjLst_Sel.Count() == 0)
{
   clsvQuestionType4CourseEN obj = clsvQuestionType4CourseBL.GetObjByQuestionTypeId4Course(strQuestionTypeId4Course);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvQuestionType4CourseObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strQuestionTypeId4Course">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetQuestionTypeName4CourseByQuestionTypeId4CourseCache(string strQuestionTypeId4Course)
{
if (string.IsNullOrEmpty(strQuestionTypeId4Course) == true) return "";
//获取缓存中的对象列表
clsvQuestionType4CourseEN objvQuestionType4Course = GetObjByQuestionTypeId4CourseCache(strQuestionTypeId4Course);
if (objvQuestionType4Course == null) return "";
return objvQuestionType4Course.QuestionTypeName4Course;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strQuestionTypeId4Course">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByQuestionTypeId4CourseCache(string strQuestionTypeId4Course)
{
if (string.IsNullOrEmpty(strQuestionTypeId4Course) == true) return "";
//获取缓存中的对象列表
clsvQuestionType4CourseEN objvQuestionType4Course = GetObjByQuestionTypeId4CourseCache(strQuestionTypeId4Course);
if (objvQuestionType4Course == null) return "";
return objvQuestionType4Course.QuestionTypeName4Course;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQuestionType4CourseEN> GetAllvQuestionType4CourseObjLstCache()
{
//获取缓存中的对象列表
List<clsvQuestionType4CourseEN> arrvQuestionType4CourseObjLstCache = GetObjLstCache(); 
return arrvQuestionType4CourseObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQuestionType4CourseEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvQuestionType4CourseEN._CurrTabName);
List<clsvQuestionType4CourseEN> arrvQuestionType4CourseObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQuestionType4CourseObjLstCache;
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
string strKey = string.Format("{0}", clsvQuestionType4CourseEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strQuestionTypeId4Course)
{
if (strInFldName != convQuestionType4Course.QuestionTypeId4Course)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convQuestionType4Course.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convQuestionType4Course.AttributeName));
throw new Exception(strMsg);
}
var objvQuestionType4Course = clsvQuestionType4CourseBL.GetObjByQuestionTypeId4CourseCache(strQuestionTypeId4Course);
if (objvQuestionType4Course == null) return "";
return objvQuestionType4Course[strOutFldName].ToString();
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
int intRecCount = clsvQuestionType4CourseDA.GetRecCount(strTabName);
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
int intRecCount = clsvQuestionType4CourseDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvQuestionType4CourseDA.GetRecCount();
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
int intRecCount = clsvQuestionType4CourseDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvQuestionType4CourseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvQuestionType4CourseEN objvQuestionType4CourseCond)
{
List<clsvQuestionType4CourseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQuestionType4CourseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQuestionType4Course.AttributeName)
{
if (objvQuestionType4CourseCond.IsUpdated(strFldName) == false) continue;
if (objvQuestionType4CourseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionType4CourseCond[strFldName].ToString());
}
else
{
if (objvQuestionType4CourseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQuestionType4CourseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionType4CourseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQuestionType4CourseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQuestionType4CourseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQuestionType4CourseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQuestionType4CourseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQuestionType4CourseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQuestionType4CourseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQuestionType4CourseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQuestionType4CourseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQuestionType4CourseCond[strFldName]));
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
 List<string> arrList = clsvQuestionType4CourseDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vQuestionType4CourseDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vQuestionType4CourseDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}