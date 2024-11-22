
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_WorkStuRelation4ErrorLibWApi
 表名:cc_WorkStuRelation4ErrorLib(01120184)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:47:48
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理
 模块英文名:InteractManage
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
public static class clscc_WorkStuRelation4ErrorLibWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelation4ErrorLibEN SetmId(this clscc_WorkStuRelation4ErrorLibEN objcc_WorkStuRelation4ErrorLibEN, long lngmId, string strComparisonOp="")
	{
objcc_WorkStuRelation4ErrorLibEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation4ErrorLib.mId) == false)
{
objcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(concc_WorkStuRelation4ErrorLib.mId, strComparisonOp);
}
else
{
objcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[concc_WorkStuRelation4ErrorLib.mId] = strComparisonOp;
}
}
return objcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelation4ErrorLibEN SetCourseId(this clscc_WorkStuRelation4ErrorLibEN objcc_WorkStuRelation4ErrorLibEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, concc_WorkStuRelation4ErrorLib.CourseId);
clsCheckSql.CheckFieldLen(strCourseId, 8, concc_WorkStuRelation4ErrorLib.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, concc_WorkStuRelation4ErrorLib.CourseId);
objcc_WorkStuRelation4ErrorLibEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation4ErrorLib.CourseId) == false)
{
objcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(concc_WorkStuRelation4ErrorLib.CourseId, strComparisonOp);
}
else
{
objcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[concc_WorkStuRelation4ErrorLib.CourseId] = strComparisonOp;
}
}
return objcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelation4ErrorLibEN Setid_StudentInfo(this clscc_WorkStuRelation4ErrorLibEN objcc_WorkStuRelation4ErrorLibEN, string strid_StudentInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_StudentInfo, concc_WorkStuRelation4ErrorLib.id_StudentInfo);
clsCheckSql.CheckFieldLen(strid_StudentInfo, 8, concc_WorkStuRelation4ErrorLib.id_StudentInfo);
clsCheckSql.CheckFieldForeignKey(strid_StudentInfo, 8, concc_WorkStuRelation4ErrorLib.id_StudentInfo);
objcc_WorkStuRelation4ErrorLibEN.id_StudentInfo = strid_StudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation4ErrorLib.id_StudentInfo) == false)
{
objcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(concc_WorkStuRelation4ErrorLib.id_StudentInfo, strComparisonOp);
}
else
{
objcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[concc_WorkStuRelation4ErrorLib.id_StudentInfo] = strComparisonOp;
}
}
return objcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelation4ErrorLibEN SetQuestionID(this clscc_WorkStuRelation4ErrorLibEN objcc_WorkStuRelation4ErrorLibEN, string strQuestionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionID, concc_WorkStuRelation4ErrorLib.QuestionID);
clsCheckSql.CheckFieldLen(strQuestionID, 8, concc_WorkStuRelation4ErrorLib.QuestionID);
clsCheckSql.CheckFieldForeignKey(strQuestionID, 8, concc_WorkStuRelation4ErrorLib.QuestionID);
objcc_WorkStuRelation4ErrorLibEN.QuestionID = strQuestionID; //题目ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation4ErrorLib.QuestionID) == false)
{
objcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(concc_WorkStuRelation4ErrorLib.QuestionID, strComparisonOp);
}
else
{
objcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[concc_WorkStuRelation4ErrorLib.QuestionID] = strComparisonOp;
}
}
return objcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelation4ErrorLibEN SetCreator(this clscc_WorkStuRelation4ErrorLibEN objcc_WorkStuRelation4ErrorLibEN, string strCreator, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCreator, 18, concc_WorkStuRelation4ErrorLib.Creator);
objcc_WorkStuRelation4ErrorLibEN.Creator = strCreator; //创建者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation4ErrorLib.Creator) == false)
{
objcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(concc_WorkStuRelation4ErrorLib.Creator, strComparisonOp);
}
else
{
objcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[concc_WorkStuRelation4ErrorLib.Creator] = strComparisonOp;
}
}
return objcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelation4ErrorLibEN SetCreateDate(this clscc_WorkStuRelation4ErrorLibEN objcc_WorkStuRelation4ErrorLibEN, string strCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCreateDate, 20, concc_WorkStuRelation4ErrorLib.CreateDate);
objcc_WorkStuRelation4ErrorLibEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation4ErrorLib.CreateDate) == false)
{
objcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(concc_WorkStuRelation4ErrorLib.CreateDate, strComparisonOp);
}
else
{
objcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[concc_WorkStuRelation4ErrorLib.CreateDate] = strComparisonOp;
}
}
return objcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelation4ErrorLibEN SetSourceTypeId(this clscc_WorkStuRelation4ErrorLibEN objcc_WorkStuRelation4ErrorLibEN, string strSourceTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSourceTypeId, concc_WorkStuRelation4ErrorLib.SourceTypeId);
clsCheckSql.CheckFieldLen(strSourceTypeId, 2, concc_WorkStuRelation4ErrorLib.SourceTypeId);
clsCheckSql.CheckFieldForeignKey(strSourceTypeId, 2, concc_WorkStuRelation4ErrorLib.SourceTypeId);
objcc_WorkStuRelation4ErrorLibEN.SourceTypeId = strSourceTypeId; //来源类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation4ErrorLib.SourceTypeId) == false)
{
objcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(concc_WorkStuRelation4ErrorLib.SourceTypeId, strComparisonOp);
}
else
{
objcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[concc_WorkStuRelation4ErrorLib.SourceTypeId] = strComparisonOp;
}
}
return objcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelation4ErrorLibEN SetIsRedo(this clscc_WorkStuRelation4ErrorLibEN objcc_WorkStuRelation4ErrorLibEN, bool bolIsRedo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsRedo, concc_WorkStuRelation4ErrorLib.IsRedo);
objcc_WorkStuRelation4ErrorLibEN.IsRedo = bolIsRedo; //是否重做
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation4ErrorLib.IsRedo) == false)
{
objcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(concc_WorkStuRelation4ErrorLib.IsRedo, strComparisonOp);
}
else
{
objcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[concc_WorkStuRelation4ErrorLib.IsRedo] = strComparisonOp;
}
}
return objcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelation4ErrorLibEN SetRedoDate(this clscc_WorkStuRelation4ErrorLibEN objcc_WorkStuRelation4ErrorLibEN, string strRedoDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRedoDate, 8, concc_WorkStuRelation4ErrorLib.RedoDate);
objcc_WorkStuRelation4ErrorLibEN.RedoDate = strRedoDate; //重做日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation4ErrorLib.RedoDate) == false)
{
objcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(concc_WorkStuRelation4ErrorLib.RedoDate, strComparisonOp);
}
else
{
objcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[concc_WorkStuRelation4ErrorLib.RedoDate] = strComparisonOp;
}
}
return objcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelation4ErrorLibEN SetIsPassed(this clscc_WorkStuRelation4ErrorLibEN objcc_WorkStuRelation4ErrorLibEN, bool bolIsPassed, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsPassed, concc_WorkStuRelation4ErrorLib.IsPassed);
objcc_WorkStuRelation4ErrorLibEN.IsPassed = bolIsPassed; //是否通过
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation4ErrorLib.IsPassed) == false)
{
objcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(concc_WorkStuRelation4ErrorLib.IsPassed, strComparisonOp);
}
else
{
objcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[concc_WorkStuRelation4ErrorLib.IsPassed] = strComparisonOp;
}
}
return objcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelation4ErrorLibEN SetUpdDate(this clscc_WorkStuRelation4ErrorLibEN objcc_WorkStuRelation4ErrorLibEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, concc_WorkStuRelation4ErrorLib.UpdDate);
objcc_WorkStuRelation4ErrorLibEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation4ErrorLib.UpdDate) == false)
{
objcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(concc_WorkStuRelation4ErrorLib.UpdDate, strComparisonOp);
}
else
{
objcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[concc_WorkStuRelation4ErrorLib.UpdDate] = strComparisonOp;
}
}
return objcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelation4ErrorLibEN SetUpdUser(this clscc_WorkStuRelation4ErrorLibEN objcc_WorkStuRelation4ErrorLibEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, concc_WorkStuRelation4ErrorLib.UpdUser);
objcc_WorkStuRelation4ErrorLibEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation4ErrorLib.UpdUser) == false)
{
objcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(concc_WorkStuRelation4ErrorLib.UpdUser, strComparisonOp);
}
else
{
objcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[concc_WorkStuRelation4ErrorLib.UpdUser] = strComparisonOp;
}
}
return objcc_WorkStuRelation4ErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4ErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelation4ErrorLibEN SetMemo(this clscc_WorkStuRelation4ErrorLibEN objcc_WorkStuRelation4ErrorLibEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, concc_WorkStuRelation4ErrorLib.Memo);
objcc_WorkStuRelation4ErrorLibEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation4ErrorLib.Memo) == false)
{
objcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp.Add(concc_WorkStuRelation4ErrorLib.Memo, strComparisonOp);
}
else
{
objcc_WorkStuRelation4ErrorLibEN.dicFldComparisonOp[concc_WorkStuRelation4ErrorLib.Memo] = strComparisonOp;
}
}
return objcc_WorkStuRelation4ErrorLibEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscc_WorkStuRelation4ErrorLibEN objcc_WorkStuRelation4ErrorLib_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(concc_WorkStuRelation4ErrorLib.mId) == true)
{
string strComparisonOp_mId = objcc_WorkStuRelation4ErrorLib_Cond.dicFldComparisonOp[concc_WorkStuRelation4ErrorLib.mId];
strWhereCond += string.Format(" And {0} {2} {1}", concc_WorkStuRelation4ErrorLib.mId, objcc_WorkStuRelation4ErrorLib_Cond.mId, strComparisonOp_mId);
}
if (objcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(concc_WorkStuRelation4ErrorLib.CourseId) == true)
{
string strComparisonOp_CourseId = objcc_WorkStuRelation4ErrorLib_Cond.dicFldComparisonOp[concc_WorkStuRelation4ErrorLib.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation4ErrorLib.CourseId, objcc_WorkStuRelation4ErrorLib_Cond.CourseId, strComparisonOp_CourseId);
}
if (objcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(concc_WorkStuRelation4ErrorLib.id_StudentInfo) == true)
{
string strComparisonOp_id_StudentInfo = objcc_WorkStuRelation4ErrorLib_Cond.dicFldComparisonOp[concc_WorkStuRelation4ErrorLib.id_StudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation4ErrorLib.id_StudentInfo, objcc_WorkStuRelation4ErrorLib_Cond.id_StudentInfo, strComparisonOp_id_StudentInfo);
}
if (objcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(concc_WorkStuRelation4ErrorLib.QuestionID) == true)
{
string strComparisonOp_QuestionID = objcc_WorkStuRelation4ErrorLib_Cond.dicFldComparisonOp[concc_WorkStuRelation4ErrorLib.QuestionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation4ErrorLib.QuestionID, objcc_WorkStuRelation4ErrorLib_Cond.QuestionID, strComparisonOp_QuestionID);
}
if (objcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(concc_WorkStuRelation4ErrorLib.Creator) == true)
{
string strComparisonOp_Creator = objcc_WorkStuRelation4ErrorLib_Cond.dicFldComparisonOp[concc_WorkStuRelation4ErrorLib.Creator];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation4ErrorLib.Creator, objcc_WorkStuRelation4ErrorLib_Cond.Creator, strComparisonOp_Creator);
}
if (objcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(concc_WorkStuRelation4ErrorLib.CreateDate) == true)
{
string strComparisonOp_CreateDate = objcc_WorkStuRelation4ErrorLib_Cond.dicFldComparisonOp[concc_WorkStuRelation4ErrorLib.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation4ErrorLib.CreateDate, objcc_WorkStuRelation4ErrorLib_Cond.CreateDate, strComparisonOp_CreateDate);
}
if (objcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(concc_WorkStuRelation4ErrorLib.SourceTypeId) == true)
{
string strComparisonOp_SourceTypeId = objcc_WorkStuRelation4ErrorLib_Cond.dicFldComparisonOp[concc_WorkStuRelation4ErrorLib.SourceTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation4ErrorLib.SourceTypeId, objcc_WorkStuRelation4ErrorLib_Cond.SourceTypeId, strComparisonOp_SourceTypeId);
}
if (objcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(concc_WorkStuRelation4ErrorLib.IsRedo) == true)
{
if (objcc_WorkStuRelation4ErrorLib_Cond.IsRedo == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_WorkStuRelation4ErrorLib.IsRedo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_WorkStuRelation4ErrorLib.IsRedo);
}
}
if (objcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(concc_WorkStuRelation4ErrorLib.RedoDate) == true)
{
string strComparisonOp_RedoDate = objcc_WorkStuRelation4ErrorLib_Cond.dicFldComparisonOp[concc_WorkStuRelation4ErrorLib.RedoDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation4ErrorLib.RedoDate, objcc_WorkStuRelation4ErrorLib_Cond.RedoDate, strComparisonOp_RedoDate);
}
if (objcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(concc_WorkStuRelation4ErrorLib.IsPassed) == true)
{
if (objcc_WorkStuRelation4ErrorLib_Cond.IsPassed == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_WorkStuRelation4ErrorLib.IsPassed);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_WorkStuRelation4ErrorLib.IsPassed);
}
}
if (objcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(concc_WorkStuRelation4ErrorLib.UpdDate) == true)
{
string strComparisonOp_UpdDate = objcc_WorkStuRelation4ErrorLib_Cond.dicFldComparisonOp[concc_WorkStuRelation4ErrorLib.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation4ErrorLib.UpdDate, objcc_WorkStuRelation4ErrorLib_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(concc_WorkStuRelation4ErrorLib.UpdUser) == true)
{
string strComparisonOp_UpdUser = objcc_WorkStuRelation4ErrorLib_Cond.dicFldComparisonOp[concc_WorkStuRelation4ErrorLib.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation4ErrorLib.UpdUser, objcc_WorkStuRelation4ErrorLib_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objcc_WorkStuRelation4ErrorLib_Cond.IsUpdated(concc_WorkStuRelation4ErrorLib.Memo) == true)
{
string strComparisonOp_Memo = objcc_WorkStuRelation4ErrorLib_Cond.dicFldComparisonOp[concc_WorkStuRelation4ErrorLib.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation4ErrorLib.Memo, objcc_WorkStuRelation4ErrorLib_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4ErrorLibEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_WorkStuRelation4ErrorLibEN objcc_WorkStuRelation4ErrorLibEN)
{
 if (objcc_WorkStuRelation4ErrorLibEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objcc_WorkStuRelation4ErrorLibEN.sf_UpdFldSetStr = objcc_WorkStuRelation4ErrorLibEN.getsf_UpdFldSetStr();
clscc_WorkStuRelation4ErrorLibWApi.CheckPropertyNew(objcc_WorkStuRelation4ErrorLibEN); 
bool bolResult = clscc_WorkStuRelation4ErrorLibWApi.UpdateRecord(objcc_WorkStuRelation4ErrorLibEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelation4ErrorLibWApi.ReFreshCache();
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
 /// 检查唯一性(Uniqueness)--cc_WorkStuRelation4ErrorLib(学生错误作业集), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4ErrorLibEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_id_StudentInfo_QuestionID(this clscc_WorkStuRelation4ErrorLibEN objcc_WorkStuRelation4ErrorLibEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objcc_WorkStuRelation4ErrorLibEN == null) return "";
if (objcc_WorkStuRelation4ErrorLibEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and id_StudentInfo = '{0}'", objcc_WorkStuRelation4ErrorLibEN.id_StudentInfo);
 sbCondition.AppendFormat(" and QuestionID = '{0}'", objcc_WorkStuRelation4ErrorLibEN.QuestionID);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objcc_WorkStuRelation4ErrorLibEN.mId);
 sbCondition.AppendFormat(" and id_StudentInfo = '{0}'", objcc_WorkStuRelation4ErrorLibEN.id_StudentInfo);
 sbCondition.AppendFormat(" and QuestionID = '{0}'", objcc_WorkStuRelation4ErrorLibEN.QuestionID);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4ErrorLibEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscc_WorkStuRelation4ErrorLibEN objcc_WorkStuRelation4ErrorLibEN)
{
try
{
clscc_WorkStuRelation4ErrorLibWApi.CheckPropertyNew(objcc_WorkStuRelation4ErrorLibEN); 
bool bolResult = clscc_WorkStuRelation4ErrorLibWApi.AddNewRecord(objcc_WorkStuRelation4ErrorLibEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelation4ErrorLibWApi.ReFreshCache();
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
 /// <param name = "objcc_WorkStuRelation4ErrorLibEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_WorkStuRelation4ErrorLibEN objcc_WorkStuRelation4ErrorLibEN, string strWhereCond)
{
try
{
clscc_WorkStuRelation4ErrorLibWApi.CheckPropertyNew(objcc_WorkStuRelation4ErrorLibEN); 
bool bolResult = clscc_WorkStuRelation4ErrorLibWApi.UpdateWithCondition(objcc_WorkStuRelation4ErrorLibEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelation4ErrorLibWApi.ReFreshCache();
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
 /// 学生错误作业集(cc_WorkStuRelation4ErrorLib)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clscc_WorkStuRelation4ErrorLibWApi
{
private static readonly string mstrApiControllerName = "cc_WorkStuRelation4ErrorLibApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clscc_WorkStuRelation4ErrorLibWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clscc_WorkStuRelation4ErrorLibEN objcc_WorkStuRelation4ErrorLibEN)
{
if (!Object.Equals(null, objcc_WorkStuRelation4ErrorLibEN.CourseId) && GetStrLen(objcc_WorkStuRelation4ErrorLibEN.CourseId) > 8)
{
 throw new Exception("字段[课程Id]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_WorkStuRelation4ErrorLibEN.id_StudentInfo) && GetStrLen(objcc_WorkStuRelation4ErrorLibEN.id_StudentInfo) > 8)
{
 throw new Exception("字段[学生流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_WorkStuRelation4ErrorLibEN.QuestionID) && GetStrLen(objcc_WorkStuRelation4ErrorLibEN.QuestionID) > 8)
{
 throw new Exception("字段[题目ID]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_WorkStuRelation4ErrorLibEN.Creator) && GetStrLen(objcc_WorkStuRelation4ErrorLibEN.Creator) > 18)
{
 throw new Exception("字段[创建者]的长度不能超过18!");
}
if (!Object.Equals(null, objcc_WorkStuRelation4ErrorLibEN.CreateDate) && GetStrLen(objcc_WorkStuRelation4ErrorLibEN.CreateDate) > 20)
{
 throw new Exception("字段[建立日期]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_WorkStuRelation4ErrorLibEN.SourceTypeId) && GetStrLen(objcc_WorkStuRelation4ErrorLibEN.SourceTypeId) > 2)
{
 throw new Exception("字段[来源类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objcc_WorkStuRelation4ErrorLibEN.RedoDate) && GetStrLen(objcc_WorkStuRelation4ErrorLibEN.RedoDate) > 8)
{
 throw new Exception("字段[重做日期]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_WorkStuRelation4ErrorLibEN.UpdDate) && GetStrLen(objcc_WorkStuRelation4ErrorLibEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_WorkStuRelation4ErrorLibEN.UpdUser) && GetStrLen(objcc_WorkStuRelation4ErrorLibEN.UpdUser) > 20)
{
 throw new Exception("字段[修改人]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_WorkStuRelation4ErrorLibEN.Memo) && GetStrLen(objcc_WorkStuRelation4ErrorLibEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objcc_WorkStuRelation4ErrorLibEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_WorkStuRelation4ErrorLibEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clscc_WorkStuRelation4ErrorLibEN objcc_WorkStuRelation4ErrorLibEN = null;
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
objcc_WorkStuRelation4ErrorLibEN = JsonConvert.DeserializeObject<clscc_WorkStuRelation4ErrorLibEN>((string)jobjReturn["ReturnObj"]);
return objcc_WorkStuRelation4ErrorLibEN;
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
public static clscc_WorkStuRelation4ErrorLibEN GetObjBymId_WA_Cache(long lngmId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clscc_WorkStuRelation4ErrorLibEN objcc_WorkStuRelation4ErrorLibEN = null;
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
objcc_WorkStuRelation4ErrorLibEN = JsonConvert.DeserializeObject<clscc_WorkStuRelation4ErrorLibEN>((string)jobjReturn["ReturnObj"]);
return objcc_WorkStuRelation4ErrorLibEN;
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
public static clscc_WorkStuRelation4ErrorLibEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clscc_WorkStuRelation4ErrorLibEN objcc_WorkStuRelation4ErrorLibEN = null;
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
objcc_WorkStuRelation4ErrorLibEN = JsonConvert.DeserializeObject<clscc_WorkStuRelation4ErrorLibEN>((string)jobjReturn["ReturnObj"]);
return objcc_WorkStuRelation4ErrorLibEN;
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
public static clscc_WorkStuRelation4ErrorLibEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clscc_WorkStuRelation4ErrorLibEN._CurrTabName_S);
List<clscc_WorkStuRelation4ErrorLibEN> arrcc_WorkStuRelation4ErrorLibObjLst_Cache = GetObjLst_Cache();
IEnumerable <clscc_WorkStuRelation4ErrorLibEN> arrcc_WorkStuRelation4ErrorLibObjLst_Sel =
from objcc_WorkStuRelation4ErrorLibEN in arrcc_WorkStuRelation4ErrorLibObjLst_Cache
where objcc_WorkStuRelation4ErrorLibEN.mId == lngmId
select objcc_WorkStuRelation4ErrorLibEN;
if (arrcc_WorkStuRelation4ErrorLibObjLst_Sel.Count() == 0)
{
   clscc_WorkStuRelation4ErrorLibEN obj = clscc_WorkStuRelation4ErrorLibWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrcc_WorkStuRelation4ErrorLibObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_WorkStuRelation4ErrorLibEN> GetObjLst(string strWhereCond)
{
 List<clscc_WorkStuRelation4ErrorLibEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_WorkStuRelation4ErrorLibEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_WorkStuRelation4ErrorLibEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clscc_WorkStuRelation4ErrorLibEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_WorkStuRelation4ErrorLibEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clscc_WorkStuRelation4ErrorLibEN> GetObjLstByMIdLst_Cache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clscc_WorkStuRelation4ErrorLibEN._CurrTabName_S);
List<clscc_WorkStuRelation4ErrorLibEN> arrcc_WorkStuRelation4ErrorLibObjLst_Cache = GetObjLst_Cache();
IEnumerable <clscc_WorkStuRelation4ErrorLibEN> arrcc_WorkStuRelation4ErrorLibObjLst_Sel =
from objcc_WorkStuRelation4ErrorLibEN in arrcc_WorkStuRelation4ErrorLibObjLst_Cache
where arrMId.Contains(objcc_WorkStuRelation4ErrorLibEN.mId)
select objcc_WorkStuRelation4ErrorLibEN;
return arrcc_WorkStuRelation4ErrorLibObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_WorkStuRelation4ErrorLibEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId)
{
 List<clscc_WorkStuRelation4ErrorLibEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_WorkStuRelation4ErrorLibEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_WorkStuRelation4ErrorLibEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clscc_WorkStuRelation4ErrorLibEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_WorkStuRelation4ErrorLibEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_WorkStuRelation4ErrorLibEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clscc_WorkStuRelation4ErrorLibEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_WorkStuRelation4ErrorLibEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_WorkStuRelation4ErrorLibEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clscc_WorkStuRelation4ErrorLibEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_WorkStuRelation4ErrorLibEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_WorkStuRelation4ErrorLibEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clscc_WorkStuRelation4ErrorLibEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_WorkStuRelation4ErrorLibEN>>((string)jobjReturn["ReturnObjLst"]);
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
 clscc_WorkStuRelation4ErrorLibEN objcc_WorkStuRelation4ErrorLibEN = clscc_WorkStuRelation4ErrorLibWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clscc_WorkStuRelation4ErrorLibWApi.ReFreshCache();
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
public static int Delcc_WorkStuRelation4ErrorLibs(List<string> arrmId)
{
string strAction = "Delcc_WorkStuRelation4ErrorLibs";
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
clscc_WorkStuRelation4ErrorLibWApi.ReFreshCache();
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
public static int Delcc_WorkStuRelation4ErrorLibsByCond(string strWhereCond)
{
string strAction = "Delcc_WorkStuRelation4ErrorLibsByCond";
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
public static bool AddNewRecord(clscc_WorkStuRelation4ErrorLibEN objcc_WorkStuRelation4ErrorLibEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_WorkStuRelation4ErrorLibEN>(objcc_WorkStuRelation4ErrorLibEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelation4ErrorLibWApi.ReFreshCache();
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
 /// <param name = "objcc_WorkStuRelation4ErrorLibEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clscc_WorkStuRelation4ErrorLibEN objcc_WorkStuRelation4ErrorLibEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_WorkStuRelation4ErrorLibEN>(objcc_WorkStuRelation4ErrorLibEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelation4ErrorLibWApi.ReFreshCache();
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
public static bool UpdateRecord(clscc_WorkStuRelation4ErrorLibEN objcc_WorkStuRelation4ErrorLibEN)
{
if (string.IsNullOrEmpty(objcc_WorkStuRelation4ErrorLibEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_WorkStuRelation4ErrorLibEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_WorkStuRelation4ErrorLibEN>(objcc_WorkStuRelation4ErrorLibEN);
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
 /// <param name = "objcc_WorkStuRelation4ErrorLibEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clscc_WorkStuRelation4ErrorLibEN objcc_WorkStuRelation4ErrorLibEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objcc_WorkStuRelation4ErrorLibEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_WorkStuRelation4ErrorLibEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_WorkStuRelation4ErrorLibEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_WorkStuRelation4ErrorLibEN>(objcc_WorkStuRelation4ErrorLibEN);
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
 /// <param name = "objcc_WorkStuRelation4ErrorLibENS">源对象</param>
 /// <param name = "objcc_WorkStuRelation4ErrorLibENT">目标对象</param>
 public static void CopyTo(clscc_WorkStuRelation4ErrorLibEN objcc_WorkStuRelation4ErrorLibENS, clscc_WorkStuRelation4ErrorLibEN objcc_WorkStuRelation4ErrorLibENT)
{
try
{
objcc_WorkStuRelation4ErrorLibENT.mId = objcc_WorkStuRelation4ErrorLibENS.mId; //mId
objcc_WorkStuRelation4ErrorLibENT.CourseId = objcc_WorkStuRelation4ErrorLibENS.CourseId; //课程Id
objcc_WorkStuRelation4ErrorLibENT.id_StudentInfo = objcc_WorkStuRelation4ErrorLibENS.id_StudentInfo; //学生流水号
objcc_WorkStuRelation4ErrorLibENT.QuestionID = objcc_WorkStuRelation4ErrorLibENS.QuestionID; //题目ID
objcc_WorkStuRelation4ErrorLibENT.Creator = objcc_WorkStuRelation4ErrorLibENS.Creator; //创建者
objcc_WorkStuRelation4ErrorLibENT.CreateDate = objcc_WorkStuRelation4ErrorLibENS.CreateDate; //建立日期
objcc_WorkStuRelation4ErrorLibENT.SourceTypeId = objcc_WorkStuRelation4ErrorLibENS.SourceTypeId; //来源类型Id
objcc_WorkStuRelation4ErrorLibENT.IsRedo = objcc_WorkStuRelation4ErrorLibENS.IsRedo; //是否重做
objcc_WorkStuRelation4ErrorLibENT.RedoDate = objcc_WorkStuRelation4ErrorLibENS.RedoDate; //重做日期
objcc_WorkStuRelation4ErrorLibENT.IsPassed = objcc_WorkStuRelation4ErrorLibENS.IsPassed; //是否通过
objcc_WorkStuRelation4ErrorLibENT.UpdDate = objcc_WorkStuRelation4ErrorLibENS.UpdDate; //修改日期
objcc_WorkStuRelation4ErrorLibENT.UpdUser = objcc_WorkStuRelation4ErrorLibENS.UpdUser; //修改人
objcc_WorkStuRelation4ErrorLibENT.Memo = objcc_WorkStuRelation4ErrorLibENS.Memo; //备注
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
public static DataTable ToDataTable(List<clscc_WorkStuRelation4ErrorLibEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clscc_WorkStuRelation4ErrorLibEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clscc_WorkStuRelation4ErrorLibEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clscc_WorkStuRelation4ErrorLibEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clscc_WorkStuRelation4ErrorLibEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clscc_WorkStuRelation4ErrorLibEN.AttributeName)
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
if (clscc_WorkStuRelation4ErrorLibWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_WorkStuRelation4ErrorLibWApi没有刷新缓存机制(clscc_WorkStuRelation4ErrorLibWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrcc_WorkStuRelation4ErrorLibObjLst_Cache == null)
//{
//arrcc_WorkStuRelation4ErrorLibObjLst_Cache = await clscc_WorkStuRelation4ErrorLibWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clscc_WorkStuRelation4ErrorLibEN._CurrTabName_S);
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
if (clscc_WorkStuRelation4ErrorLibWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clscc_WorkStuRelation4ErrorLibEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clscc_WorkStuRelation4ErrorLibWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_WorkStuRelation4ErrorLibEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clscc_WorkStuRelation4ErrorLibEN._CurrTabName_S);
List<clscc_WorkStuRelation4ErrorLibEN> arrcc_WorkStuRelation4ErrorLibObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrcc_WorkStuRelation4ErrorLibObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clscc_WorkStuRelation4ErrorLibEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(concc_WorkStuRelation4ErrorLib.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(concc_WorkStuRelation4ErrorLib.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkStuRelation4ErrorLib.id_StudentInfo, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkStuRelation4ErrorLib.QuestionID, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkStuRelation4ErrorLib.Creator, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkStuRelation4ErrorLib.CreateDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkStuRelation4ErrorLib.SourceTypeId, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkStuRelation4ErrorLib.IsRedo, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_WorkStuRelation4ErrorLib.RedoDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkStuRelation4ErrorLib.IsPassed, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_WorkStuRelation4ErrorLib.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkStuRelation4ErrorLib.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkStuRelation4ErrorLib.Memo, Type.GetType("System.String"));
foreach (clscc_WorkStuRelation4ErrorLibEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[concc_WorkStuRelation4ErrorLib.mId] = objInFor[concc_WorkStuRelation4ErrorLib.mId];
objDR[concc_WorkStuRelation4ErrorLib.CourseId] = objInFor[concc_WorkStuRelation4ErrorLib.CourseId];
objDR[concc_WorkStuRelation4ErrorLib.id_StudentInfo] = objInFor[concc_WorkStuRelation4ErrorLib.id_StudentInfo];
objDR[concc_WorkStuRelation4ErrorLib.QuestionID] = objInFor[concc_WorkStuRelation4ErrorLib.QuestionID];
objDR[concc_WorkStuRelation4ErrorLib.Creator] = objInFor[concc_WorkStuRelation4ErrorLib.Creator];
objDR[concc_WorkStuRelation4ErrorLib.CreateDate] = objInFor[concc_WorkStuRelation4ErrorLib.CreateDate];
objDR[concc_WorkStuRelation4ErrorLib.SourceTypeId] = objInFor[concc_WorkStuRelation4ErrorLib.SourceTypeId];
objDR[concc_WorkStuRelation4ErrorLib.IsRedo] = objInFor[concc_WorkStuRelation4ErrorLib.IsRedo];
objDR[concc_WorkStuRelation4ErrorLib.RedoDate] = objInFor[concc_WorkStuRelation4ErrorLib.RedoDate];
objDR[concc_WorkStuRelation4ErrorLib.IsPassed] = objInFor[concc_WorkStuRelation4ErrorLib.IsPassed];
objDR[concc_WorkStuRelation4ErrorLib.UpdDate] = objInFor[concc_WorkStuRelation4ErrorLib.UpdDate];
objDR[concc_WorkStuRelation4ErrorLib.UpdUser] = objInFor[concc_WorkStuRelation4ErrorLib.UpdUser];
objDR[concc_WorkStuRelation4ErrorLib.Memo] = objInFor[concc_WorkStuRelation4ErrorLib.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 学生错误作业集(cc_WorkStuRelation4ErrorLib)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4cc_WorkStuRelation4ErrorLib : clsCommFun4BL
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
clscc_WorkStuRelation4ErrorLibWApi.ReFreshThisCache();
clsvcc_WorkStuRelation4ErrorLibWApi.ReFreshThisCache();
}
}

}