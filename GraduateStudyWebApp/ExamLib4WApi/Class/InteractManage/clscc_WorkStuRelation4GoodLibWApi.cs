
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_WorkStuRelation4GoodLibWApi
 表名:cc_WorkStuRelation4GoodLib(01120223)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:39:22
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
public static class clscc_WorkStuRelation4GoodLibWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelation4GoodLibEN SetmId(this clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLibEN, long lngmId, string strComparisonOp="")
	{
objcc_WorkStuRelation4GoodLibEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation4GoodLib.mId) == false)
{
objcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(concc_WorkStuRelation4GoodLib.mId, strComparisonOp);
}
else
{
objcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[concc_WorkStuRelation4GoodLib.mId] = strComparisonOp;
}
}
return objcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelation4GoodLibEN SetCourseId(this clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLibEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, concc_WorkStuRelation4GoodLib.CourseId);
clsCheckSql.CheckFieldLen(strCourseId, 8, concc_WorkStuRelation4GoodLib.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, concc_WorkStuRelation4GoodLib.CourseId);
objcc_WorkStuRelation4GoodLibEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation4GoodLib.CourseId) == false)
{
objcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(concc_WorkStuRelation4GoodLib.CourseId, strComparisonOp);
}
else
{
objcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[concc_WorkStuRelation4GoodLib.CourseId] = strComparisonOp;
}
}
return objcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelation4GoodLibEN Setid_StudentInfo(this clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLibEN, string strid_StudentInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_StudentInfo, concc_WorkStuRelation4GoodLib.id_StudentInfo);
clsCheckSql.CheckFieldLen(strid_StudentInfo, 8, concc_WorkStuRelation4GoodLib.id_StudentInfo);
clsCheckSql.CheckFieldForeignKey(strid_StudentInfo, 8, concc_WorkStuRelation4GoodLib.id_StudentInfo);
objcc_WorkStuRelation4GoodLibEN.id_StudentInfo = strid_StudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation4GoodLib.id_StudentInfo) == false)
{
objcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(concc_WorkStuRelation4GoodLib.id_StudentInfo, strComparisonOp);
}
else
{
objcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[concc_WorkStuRelation4GoodLib.id_StudentInfo] = strComparisonOp;
}
}
return objcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelation4GoodLibEN SetQuestionID(this clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLibEN, string strQuestionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionID, concc_WorkStuRelation4GoodLib.QuestionID);
clsCheckSql.CheckFieldLen(strQuestionID, 8, concc_WorkStuRelation4GoodLib.QuestionID);
clsCheckSql.CheckFieldForeignKey(strQuestionID, 8, concc_WorkStuRelation4GoodLib.QuestionID);
objcc_WorkStuRelation4GoodLibEN.QuestionID = strQuestionID; //题目ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation4GoodLib.QuestionID) == false)
{
objcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(concc_WorkStuRelation4GoodLib.QuestionID, strComparisonOp);
}
else
{
objcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[concc_WorkStuRelation4GoodLib.QuestionID] = strComparisonOp;
}
}
return objcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelation4GoodLibEN SetCreator(this clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLibEN, string strCreator, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCreator, 18, concc_WorkStuRelation4GoodLib.Creator);
objcc_WorkStuRelation4GoodLibEN.Creator = strCreator; //创建者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation4GoodLib.Creator) == false)
{
objcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(concc_WorkStuRelation4GoodLib.Creator, strComparisonOp);
}
else
{
objcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[concc_WorkStuRelation4GoodLib.Creator] = strComparisonOp;
}
}
return objcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelation4GoodLibEN SetCreateDate(this clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLibEN, string strCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCreateDate, 20, concc_WorkStuRelation4GoodLib.CreateDate);
objcc_WorkStuRelation4GoodLibEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation4GoodLib.CreateDate) == false)
{
objcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(concc_WorkStuRelation4GoodLib.CreateDate, strComparisonOp);
}
else
{
objcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[concc_WorkStuRelation4GoodLib.CreateDate] = strComparisonOp;
}
}
return objcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelation4GoodLibEN SetSourceTypeId(this clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLibEN, string strSourceTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSourceTypeId, concc_WorkStuRelation4GoodLib.SourceTypeId);
clsCheckSql.CheckFieldLen(strSourceTypeId, 2, concc_WorkStuRelation4GoodLib.SourceTypeId);
clsCheckSql.CheckFieldForeignKey(strSourceTypeId, 2, concc_WorkStuRelation4GoodLib.SourceTypeId);
objcc_WorkStuRelation4GoodLibEN.SourceTypeId = strSourceTypeId; //来源类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation4GoodLib.SourceTypeId) == false)
{
objcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(concc_WorkStuRelation4GoodLib.SourceTypeId, strComparisonOp);
}
else
{
objcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[concc_WorkStuRelation4GoodLib.SourceTypeId] = strComparisonOp;
}
}
return objcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelation4GoodLibEN SetIsRedo(this clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLibEN, bool bolIsRedo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsRedo, concc_WorkStuRelation4GoodLib.IsRedo);
objcc_WorkStuRelation4GoodLibEN.IsRedo = bolIsRedo; //是否重做
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation4GoodLib.IsRedo) == false)
{
objcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(concc_WorkStuRelation4GoodLib.IsRedo, strComparisonOp);
}
else
{
objcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[concc_WorkStuRelation4GoodLib.IsRedo] = strComparisonOp;
}
}
return objcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelation4GoodLibEN SetRedoDate(this clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLibEN, string strRedoDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRedoDate, 8, concc_WorkStuRelation4GoodLib.RedoDate);
objcc_WorkStuRelation4GoodLibEN.RedoDate = strRedoDate; //重做日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation4GoodLib.RedoDate) == false)
{
objcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(concc_WorkStuRelation4GoodLib.RedoDate, strComparisonOp);
}
else
{
objcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[concc_WorkStuRelation4GoodLib.RedoDate] = strComparisonOp;
}
}
return objcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelation4GoodLibEN SetIsPassed(this clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLibEN, bool bolIsPassed, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsPassed, concc_WorkStuRelation4GoodLib.IsPassed);
objcc_WorkStuRelation4GoodLibEN.IsPassed = bolIsPassed; //是否通过
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation4GoodLib.IsPassed) == false)
{
objcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(concc_WorkStuRelation4GoodLib.IsPassed, strComparisonOp);
}
else
{
objcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[concc_WorkStuRelation4GoodLib.IsPassed] = strComparisonOp;
}
}
return objcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelation4GoodLibEN SetUpdDate(this clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLibEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, concc_WorkStuRelation4GoodLib.UpdDate);
objcc_WorkStuRelation4GoodLibEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation4GoodLib.UpdDate) == false)
{
objcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(concc_WorkStuRelation4GoodLib.UpdDate, strComparisonOp);
}
else
{
objcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[concc_WorkStuRelation4GoodLib.UpdDate] = strComparisonOp;
}
}
return objcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelation4GoodLibEN SetUpdUser(this clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLibEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, concc_WorkStuRelation4GoodLib.UpdUser);
objcc_WorkStuRelation4GoodLibEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation4GoodLib.UpdUser) == false)
{
objcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(concc_WorkStuRelation4GoodLib.UpdUser, strComparisonOp);
}
else
{
objcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[concc_WorkStuRelation4GoodLib.UpdUser] = strComparisonOp;
}
}
return objcc_WorkStuRelation4GoodLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4GoodLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelation4GoodLibEN SetMemo(this clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLibEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, concc_WorkStuRelation4GoodLib.Memo);
objcc_WorkStuRelation4GoodLibEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation4GoodLib.Memo) == false)
{
objcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp.Add(concc_WorkStuRelation4GoodLib.Memo, strComparisonOp);
}
else
{
objcc_WorkStuRelation4GoodLibEN.dicFldComparisonOp[concc_WorkStuRelation4GoodLib.Memo] = strComparisonOp;
}
}
return objcc_WorkStuRelation4GoodLibEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLib_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcc_WorkStuRelation4GoodLib_Cond.IsUpdated(concc_WorkStuRelation4GoodLib.mId) == true)
{
string strComparisonOp_mId = objcc_WorkStuRelation4GoodLib_Cond.dicFldComparisonOp[concc_WorkStuRelation4GoodLib.mId];
strWhereCond += string.Format(" And {0} {2} {1}", concc_WorkStuRelation4GoodLib.mId, objcc_WorkStuRelation4GoodLib_Cond.mId, strComparisonOp_mId);
}
if (objcc_WorkStuRelation4GoodLib_Cond.IsUpdated(concc_WorkStuRelation4GoodLib.CourseId) == true)
{
string strComparisonOp_CourseId = objcc_WorkStuRelation4GoodLib_Cond.dicFldComparisonOp[concc_WorkStuRelation4GoodLib.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation4GoodLib.CourseId, objcc_WorkStuRelation4GoodLib_Cond.CourseId, strComparisonOp_CourseId);
}
if (objcc_WorkStuRelation4GoodLib_Cond.IsUpdated(concc_WorkStuRelation4GoodLib.id_StudentInfo) == true)
{
string strComparisonOp_id_StudentInfo = objcc_WorkStuRelation4GoodLib_Cond.dicFldComparisonOp[concc_WorkStuRelation4GoodLib.id_StudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation4GoodLib.id_StudentInfo, objcc_WorkStuRelation4GoodLib_Cond.id_StudentInfo, strComparisonOp_id_StudentInfo);
}
if (objcc_WorkStuRelation4GoodLib_Cond.IsUpdated(concc_WorkStuRelation4GoodLib.QuestionID) == true)
{
string strComparisonOp_QuestionID = objcc_WorkStuRelation4GoodLib_Cond.dicFldComparisonOp[concc_WorkStuRelation4GoodLib.QuestionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation4GoodLib.QuestionID, objcc_WorkStuRelation4GoodLib_Cond.QuestionID, strComparisonOp_QuestionID);
}
if (objcc_WorkStuRelation4GoodLib_Cond.IsUpdated(concc_WorkStuRelation4GoodLib.Creator) == true)
{
string strComparisonOp_Creator = objcc_WorkStuRelation4GoodLib_Cond.dicFldComparisonOp[concc_WorkStuRelation4GoodLib.Creator];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation4GoodLib.Creator, objcc_WorkStuRelation4GoodLib_Cond.Creator, strComparisonOp_Creator);
}
if (objcc_WorkStuRelation4GoodLib_Cond.IsUpdated(concc_WorkStuRelation4GoodLib.CreateDate) == true)
{
string strComparisonOp_CreateDate = objcc_WorkStuRelation4GoodLib_Cond.dicFldComparisonOp[concc_WorkStuRelation4GoodLib.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation4GoodLib.CreateDate, objcc_WorkStuRelation4GoodLib_Cond.CreateDate, strComparisonOp_CreateDate);
}
if (objcc_WorkStuRelation4GoodLib_Cond.IsUpdated(concc_WorkStuRelation4GoodLib.SourceTypeId) == true)
{
string strComparisonOp_SourceTypeId = objcc_WorkStuRelation4GoodLib_Cond.dicFldComparisonOp[concc_WorkStuRelation4GoodLib.SourceTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation4GoodLib.SourceTypeId, objcc_WorkStuRelation4GoodLib_Cond.SourceTypeId, strComparisonOp_SourceTypeId);
}
if (objcc_WorkStuRelation4GoodLib_Cond.IsUpdated(concc_WorkStuRelation4GoodLib.IsRedo) == true)
{
if (objcc_WorkStuRelation4GoodLib_Cond.IsRedo == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_WorkStuRelation4GoodLib.IsRedo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_WorkStuRelation4GoodLib.IsRedo);
}
}
if (objcc_WorkStuRelation4GoodLib_Cond.IsUpdated(concc_WorkStuRelation4GoodLib.RedoDate) == true)
{
string strComparisonOp_RedoDate = objcc_WorkStuRelation4GoodLib_Cond.dicFldComparisonOp[concc_WorkStuRelation4GoodLib.RedoDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation4GoodLib.RedoDate, objcc_WorkStuRelation4GoodLib_Cond.RedoDate, strComparisonOp_RedoDate);
}
if (objcc_WorkStuRelation4GoodLib_Cond.IsUpdated(concc_WorkStuRelation4GoodLib.IsPassed) == true)
{
if (objcc_WorkStuRelation4GoodLib_Cond.IsPassed == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_WorkStuRelation4GoodLib.IsPassed);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_WorkStuRelation4GoodLib.IsPassed);
}
}
if (objcc_WorkStuRelation4GoodLib_Cond.IsUpdated(concc_WorkStuRelation4GoodLib.UpdDate) == true)
{
string strComparisonOp_UpdDate = objcc_WorkStuRelation4GoodLib_Cond.dicFldComparisonOp[concc_WorkStuRelation4GoodLib.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation4GoodLib.UpdDate, objcc_WorkStuRelation4GoodLib_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objcc_WorkStuRelation4GoodLib_Cond.IsUpdated(concc_WorkStuRelation4GoodLib.UpdUser) == true)
{
string strComparisonOp_UpdUser = objcc_WorkStuRelation4GoodLib_Cond.dicFldComparisonOp[concc_WorkStuRelation4GoodLib.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation4GoodLib.UpdUser, objcc_WorkStuRelation4GoodLib_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objcc_WorkStuRelation4GoodLib_Cond.IsUpdated(concc_WorkStuRelation4GoodLib.Memo) == true)
{
string strComparisonOp_Memo = objcc_WorkStuRelation4GoodLib_Cond.dicFldComparisonOp[concc_WorkStuRelation4GoodLib.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation4GoodLib.Memo, objcc_WorkStuRelation4GoodLib_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4GoodLibEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLibEN)
{
 if (objcc_WorkStuRelation4GoodLibEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objcc_WorkStuRelation4GoodLibEN.sf_UpdFldSetStr = objcc_WorkStuRelation4GoodLibEN.getsf_UpdFldSetStr();
clscc_WorkStuRelation4GoodLibWApi.CheckPropertyNew(objcc_WorkStuRelation4GoodLibEN); 
bool bolResult = clscc_WorkStuRelation4GoodLibWApi.UpdateRecord(objcc_WorkStuRelation4GoodLibEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelation4GoodLibWApi.ReFreshCache(objcc_WorkStuRelation4GoodLibEN.CourseId);
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
 /// 检查唯一性(Uniqueness)--cc_WorkStuRelation4GoodLib(学生好题集), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4GoodLibEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_QuestionID_id_StudentInfo(this clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLibEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objcc_WorkStuRelation4GoodLibEN == null) return "";
if (objcc_WorkStuRelation4GoodLibEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and QuestionID = '{0}'", objcc_WorkStuRelation4GoodLibEN.QuestionID);
 sbCondition.AppendFormat(" and id_StudentInfo = '{0}'", objcc_WorkStuRelation4GoodLibEN.id_StudentInfo);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objcc_WorkStuRelation4GoodLibEN.mId);
 sbCondition.AppendFormat(" and QuestionID = '{0}'", objcc_WorkStuRelation4GoodLibEN.QuestionID);
 sbCondition.AppendFormat(" and id_StudentInfo = '{0}'", objcc_WorkStuRelation4GoodLibEN.id_StudentInfo);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4GoodLibEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLibEN)
{
try
{
clscc_WorkStuRelation4GoodLibWApi.CheckPropertyNew(objcc_WorkStuRelation4GoodLibEN); 
bool bolResult = clscc_WorkStuRelation4GoodLibWApi.AddNewRecord(objcc_WorkStuRelation4GoodLibEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelation4GoodLibWApi.ReFreshCache(objcc_WorkStuRelation4GoodLibEN.CourseId);
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
 /// <param name = "objcc_WorkStuRelation4GoodLibEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLibEN, string strWhereCond)
{
try
{
clscc_WorkStuRelation4GoodLibWApi.CheckPropertyNew(objcc_WorkStuRelation4GoodLibEN); 
bool bolResult = clscc_WorkStuRelation4GoodLibWApi.UpdateWithCondition(objcc_WorkStuRelation4GoodLibEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelation4GoodLibWApi.ReFreshCache(objcc_WorkStuRelation4GoodLibEN.CourseId);
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
 /// 学生好题集(cc_WorkStuRelation4GoodLib)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clscc_WorkStuRelation4GoodLibWApi
{
private static readonly string mstrApiControllerName = "cc_WorkStuRelation4GoodLibApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4BL = null;

 public clscc_WorkStuRelation4GoodLibWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLibEN)
{
if (!Object.Equals(null, objcc_WorkStuRelation4GoodLibEN.CourseId) && GetStrLen(objcc_WorkStuRelation4GoodLibEN.CourseId) > 8)
{
 throw new Exception("字段[课程Id]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_WorkStuRelation4GoodLibEN.id_StudentInfo) && GetStrLen(objcc_WorkStuRelation4GoodLibEN.id_StudentInfo) > 8)
{
 throw new Exception("字段[学生流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_WorkStuRelation4GoodLibEN.QuestionID) && GetStrLen(objcc_WorkStuRelation4GoodLibEN.QuestionID) > 8)
{
 throw new Exception("字段[题目ID]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_WorkStuRelation4GoodLibEN.Creator) && GetStrLen(objcc_WorkStuRelation4GoodLibEN.Creator) > 18)
{
 throw new Exception("字段[创建者]的长度不能超过18!");
}
if (!Object.Equals(null, objcc_WorkStuRelation4GoodLibEN.CreateDate) && GetStrLen(objcc_WorkStuRelation4GoodLibEN.CreateDate) > 20)
{
 throw new Exception("字段[建立日期]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_WorkStuRelation4GoodLibEN.SourceTypeId) && GetStrLen(objcc_WorkStuRelation4GoodLibEN.SourceTypeId) > 2)
{
 throw new Exception("字段[来源类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objcc_WorkStuRelation4GoodLibEN.RedoDate) && GetStrLen(objcc_WorkStuRelation4GoodLibEN.RedoDate) > 8)
{
 throw new Exception("字段[重做日期]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_WorkStuRelation4GoodLibEN.UpdDate) && GetStrLen(objcc_WorkStuRelation4GoodLibEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_WorkStuRelation4GoodLibEN.UpdUser) && GetStrLen(objcc_WorkStuRelation4GoodLibEN.UpdUser) > 20)
{
 throw new Exception("字段[修改人]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_WorkStuRelation4GoodLibEN.Memo) && GetStrLen(objcc_WorkStuRelation4GoodLibEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objcc_WorkStuRelation4GoodLibEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_WorkStuRelation4GoodLibEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLibEN = null;
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
objcc_WorkStuRelation4GoodLibEN = JsonConvert.DeserializeObject<clscc_WorkStuRelation4GoodLibEN>((string)jobjReturn["ReturnObj"]);
return objcc_WorkStuRelation4GoodLibEN;
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
public static clscc_WorkStuRelation4GoodLibEN GetObjBymId_WA_Cache(long lngmId, string strCourseId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLibEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString(),
["CourseId"] = strCourseId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objcc_WorkStuRelation4GoodLibEN = JsonConvert.DeserializeObject<clscc_WorkStuRelation4GoodLibEN>((string)jobjReturn["ReturnObj"]);
return objcc_WorkStuRelation4GoodLibEN;
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
public static clscc_WorkStuRelation4GoodLibEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLibEN = null;
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
objcc_WorkStuRelation4GoodLibEN = JsonConvert.DeserializeObject<clscc_WorkStuRelation4GoodLibEN>((string)jobjReturn["ReturnObj"]);
return objcc_WorkStuRelation4GoodLibEN;
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
public static clscc_WorkStuRelation4GoodLibEN GetObjBymId_Cache(long lngmId, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clscc_WorkStuRelation4GoodLibEN._CurrTabName_S, strCourseId);
List<clscc_WorkStuRelation4GoodLibEN> arrcc_WorkStuRelation4GoodLibObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clscc_WorkStuRelation4GoodLibEN> arrcc_WorkStuRelation4GoodLibObjLst_Sel =
from objcc_WorkStuRelation4GoodLibEN in arrcc_WorkStuRelation4GoodLibObjLst_Cache
where objcc_WorkStuRelation4GoodLibEN.mId == lngmId
select objcc_WorkStuRelation4GoodLibEN;
if (arrcc_WorkStuRelation4GoodLibObjLst_Sel.Count() == 0)
{
   clscc_WorkStuRelation4GoodLibEN obj = clscc_WorkStuRelation4GoodLibWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrcc_WorkStuRelation4GoodLibObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_WorkStuRelation4GoodLibEN> GetObjLst(string strWhereCond)
{
 List<clscc_WorkStuRelation4GoodLibEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_WorkStuRelation4GoodLibEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_WorkStuRelation4GoodLibEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clscc_WorkStuRelation4GoodLibEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_WorkStuRelation4GoodLibEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clscc_WorkStuRelation4GoodLibEN> GetObjLstByMIdLst_Cache(List<long> arrMId, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clscc_WorkStuRelation4GoodLibEN._CurrTabName_S, strCourseId);
List<clscc_WorkStuRelation4GoodLibEN> arrcc_WorkStuRelation4GoodLibObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clscc_WorkStuRelation4GoodLibEN> arrcc_WorkStuRelation4GoodLibObjLst_Sel =
from objcc_WorkStuRelation4GoodLibEN in arrcc_WorkStuRelation4GoodLibObjLst_Cache
where arrMId.Contains(objcc_WorkStuRelation4GoodLibEN.mId)
select objcc_WorkStuRelation4GoodLibEN;
return arrcc_WorkStuRelation4GoodLibObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_WorkStuRelation4GoodLibEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId, string strCourseId)
{
 List<clscc_WorkStuRelation4GoodLibEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseId"] = strCourseId
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clscc_WorkStuRelation4GoodLibEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_WorkStuRelation4GoodLibEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clscc_WorkStuRelation4GoodLibEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_WorkStuRelation4GoodLibEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_WorkStuRelation4GoodLibEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clscc_WorkStuRelation4GoodLibEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_WorkStuRelation4GoodLibEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_WorkStuRelation4GoodLibEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clscc_WorkStuRelation4GoodLibEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_WorkStuRelation4GoodLibEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_WorkStuRelation4GoodLibEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clscc_WorkStuRelation4GoodLibEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_WorkStuRelation4GoodLibEN>>((string)jobjReturn["ReturnObjLst"]);
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
 clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLibEN = clscc_WorkStuRelation4GoodLibWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clscc_WorkStuRelation4GoodLibWApi.ReFreshCache(objcc_WorkStuRelation4GoodLibEN.CourseId);
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
public static int Delcc_WorkStuRelation4GoodLibs(List<string> arrmId)
{
string strAction = "Delcc_WorkStuRelation4GoodLibs";
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
 clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLibEN = clscc_WorkStuRelation4GoodLibWApi.GetObjBymId(long.Parse(arrmId[0]));
clscc_WorkStuRelation4GoodLibWApi.ReFreshCache(objcc_WorkStuRelation4GoodLibEN.CourseId);
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
public static int Delcc_WorkStuRelation4GoodLibsByCond(string strWhereCond)
{
string strAction = "Delcc_WorkStuRelation4GoodLibsByCond";
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
public static bool AddNewRecord(clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLibEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_WorkStuRelation4GoodLibEN>(objcc_WorkStuRelation4GoodLibEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelation4GoodLibWApi.ReFreshCache(objcc_WorkStuRelation4GoodLibEN.CourseId);
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
 /// <param name = "objcc_WorkStuRelation4GoodLibEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLibEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_WorkStuRelation4GoodLibEN>(objcc_WorkStuRelation4GoodLibEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelation4GoodLibWApi.ReFreshCache(objcc_WorkStuRelation4GoodLibEN.CourseId);
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
public static bool UpdateRecord(clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLibEN)
{
if (string.IsNullOrEmpty(objcc_WorkStuRelation4GoodLibEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_WorkStuRelation4GoodLibEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_WorkStuRelation4GoodLibEN>(objcc_WorkStuRelation4GoodLibEN);
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
 /// <param name = "objcc_WorkStuRelation4GoodLibEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLibEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objcc_WorkStuRelation4GoodLibEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_WorkStuRelation4GoodLibEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_WorkStuRelation4GoodLibEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_WorkStuRelation4GoodLibEN>(objcc_WorkStuRelation4GoodLibEN);
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
 /// <param name = "objcc_WorkStuRelation4GoodLibENS">源对象</param>
 /// <param name = "objcc_WorkStuRelation4GoodLibENT">目标对象</param>
 public static void CopyTo(clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLibENS, clscc_WorkStuRelation4GoodLibEN objcc_WorkStuRelation4GoodLibENT)
{
try
{
objcc_WorkStuRelation4GoodLibENT.mId = objcc_WorkStuRelation4GoodLibENS.mId; //mId
objcc_WorkStuRelation4GoodLibENT.CourseId = objcc_WorkStuRelation4GoodLibENS.CourseId; //课程Id
objcc_WorkStuRelation4GoodLibENT.id_StudentInfo = objcc_WorkStuRelation4GoodLibENS.id_StudentInfo; //学生流水号
objcc_WorkStuRelation4GoodLibENT.QuestionID = objcc_WorkStuRelation4GoodLibENS.QuestionID; //题目ID
objcc_WorkStuRelation4GoodLibENT.Creator = objcc_WorkStuRelation4GoodLibENS.Creator; //创建者
objcc_WorkStuRelation4GoodLibENT.CreateDate = objcc_WorkStuRelation4GoodLibENS.CreateDate; //建立日期
objcc_WorkStuRelation4GoodLibENT.SourceTypeId = objcc_WorkStuRelation4GoodLibENS.SourceTypeId; //来源类型Id
objcc_WorkStuRelation4GoodLibENT.IsRedo = objcc_WorkStuRelation4GoodLibENS.IsRedo; //是否重做
objcc_WorkStuRelation4GoodLibENT.RedoDate = objcc_WorkStuRelation4GoodLibENS.RedoDate; //重做日期
objcc_WorkStuRelation4GoodLibENT.IsPassed = objcc_WorkStuRelation4GoodLibENS.IsPassed; //是否通过
objcc_WorkStuRelation4GoodLibENT.UpdDate = objcc_WorkStuRelation4GoodLibENS.UpdDate; //修改日期
objcc_WorkStuRelation4GoodLibENT.UpdUser = objcc_WorkStuRelation4GoodLibENS.UpdUser; //修改人
objcc_WorkStuRelation4GoodLibENT.Memo = objcc_WorkStuRelation4GoodLibENS.Memo; //备注
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
public static DataTable ToDataTable(List<clscc_WorkStuRelation4GoodLibEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clscc_WorkStuRelation4GoodLibEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clscc_WorkStuRelation4GoodLibEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clscc_WorkStuRelation4GoodLibEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clscc_WorkStuRelation4GoodLibEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clscc_WorkStuRelation4GoodLibEN.AttributeName)
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
if (clscc_WorkStuRelation4GoodLibWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_WorkStuRelation4GoodLibWApi没有刷新缓存机制(clscc_WorkStuRelation4GoodLibWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrcc_WorkStuRelation4GoodLibObjLst_Cache == null)
//{
//arrcc_WorkStuRelation4GoodLibObjLst_Cache = await clscc_WorkStuRelation4GoodLibWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strCourseId = "")
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clscc_WorkStuRelation4GoodLibEN._CurrTabName_S, strCourseId);
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
public static void ReFreshCache(string strCourseId)
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clscc_WorkStuRelation4GoodLibWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clscc_WorkStuRelation4GoodLibEN._CurrTabName_S, strCourseId);
CacheHelper.Remove(strKey);
clscc_WorkStuRelation4GoodLibWApi.objCommFun4BL.ReFreshCache(strCourseId);
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_WorkStuRelation4GoodLibEN> GetObjLst_Cache(string strCourseId)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clscc_WorkStuRelation4GoodLibEN._CurrTabName_S, strCourseId);
List<clscc_WorkStuRelation4GoodLibEN> arrcc_WorkStuRelation4GoodLibObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("CourseId='{0}'", strCourseId)); });
return arrcc_WorkStuRelation4GoodLibObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clscc_WorkStuRelation4GoodLibEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(concc_WorkStuRelation4GoodLib.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(concc_WorkStuRelation4GoodLib.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkStuRelation4GoodLib.id_StudentInfo, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkStuRelation4GoodLib.QuestionID, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkStuRelation4GoodLib.Creator, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkStuRelation4GoodLib.CreateDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkStuRelation4GoodLib.SourceTypeId, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkStuRelation4GoodLib.IsRedo, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_WorkStuRelation4GoodLib.RedoDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkStuRelation4GoodLib.IsPassed, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_WorkStuRelation4GoodLib.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkStuRelation4GoodLib.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkStuRelation4GoodLib.Memo, Type.GetType("System.String"));
foreach (clscc_WorkStuRelation4GoodLibEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[concc_WorkStuRelation4GoodLib.mId] = objInFor[concc_WorkStuRelation4GoodLib.mId];
objDR[concc_WorkStuRelation4GoodLib.CourseId] = objInFor[concc_WorkStuRelation4GoodLib.CourseId];
objDR[concc_WorkStuRelation4GoodLib.id_StudentInfo] = objInFor[concc_WorkStuRelation4GoodLib.id_StudentInfo];
objDR[concc_WorkStuRelation4GoodLib.QuestionID] = objInFor[concc_WorkStuRelation4GoodLib.QuestionID];
objDR[concc_WorkStuRelation4GoodLib.Creator] = objInFor[concc_WorkStuRelation4GoodLib.Creator];
objDR[concc_WorkStuRelation4GoodLib.CreateDate] = objInFor[concc_WorkStuRelation4GoodLib.CreateDate];
objDR[concc_WorkStuRelation4GoodLib.SourceTypeId] = objInFor[concc_WorkStuRelation4GoodLib.SourceTypeId];
objDR[concc_WorkStuRelation4GoodLib.IsRedo] = objInFor[concc_WorkStuRelation4GoodLib.IsRedo];
objDR[concc_WorkStuRelation4GoodLib.RedoDate] = objInFor[concc_WorkStuRelation4GoodLib.RedoDate];
objDR[concc_WorkStuRelation4GoodLib.IsPassed] = objInFor[concc_WorkStuRelation4GoodLib.IsPassed];
objDR[concc_WorkStuRelation4GoodLib.UpdDate] = objInFor[concc_WorkStuRelation4GoodLib.UpdDate];
objDR[concc_WorkStuRelation4GoodLib.UpdUser] = objInFor[concc_WorkStuRelation4GoodLib.UpdUser];
objDR[concc_WorkStuRelation4GoodLib.Memo] = objInFor[concc_WorkStuRelation4GoodLib.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 学生好题集(cc_WorkStuRelation4GoodLib)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4cc_WorkStuRelation4GoodLib : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strCourseId)
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
clscc_WorkStuRelation4GoodLibWApi.ReFreshThisCache(strCourseId);
clsvcc_WorkStuRelation4GoodLibWApi.ReFreshThisCache(strCourseId);
}
}

}