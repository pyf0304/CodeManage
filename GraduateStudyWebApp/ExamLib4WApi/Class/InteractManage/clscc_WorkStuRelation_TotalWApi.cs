
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_WorkStuRelation_TotalWApi
 表名:cc_WorkStuRelation_Total(01120167)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:44:45
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
public static class clscc_WorkStuRelation_TotalWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelation_TotalEN SetId_WorkStuRelation_Total(this clscc_WorkStuRelation_TotalEN objcc_WorkStuRelation_TotalEN, long lngId_WorkStuRelation_Total, string strComparisonOp="")
	{
objcc_WorkStuRelation_TotalEN.Id_WorkStuRelation_Total = lngId_WorkStuRelation_Total; //流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation_Total.Id_WorkStuRelation_Total) == false)
{
objcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(concc_WorkStuRelation_Total.Id_WorkStuRelation_Total, strComparisonOp);
}
else
{
objcc_WorkStuRelation_TotalEN.dicFldComparisonOp[concc_WorkStuRelation_Total.Id_WorkStuRelation_Total] = strComparisonOp;
}
}
return objcc_WorkStuRelation_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelation_TotalEN Setid_CurrEduCls(this clscc_WorkStuRelation_TotalEN objcc_WorkStuRelation_TotalEN, string strid_CurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_CurrEduCls, concc_WorkStuRelation_Total.id_CurrEduCls);
clsCheckSql.CheckFieldLen(strid_CurrEduCls, 8, concc_WorkStuRelation_Total.id_CurrEduCls);
clsCheckSql.CheckFieldForeignKey(strid_CurrEduCls, 8, concc_WorkStuRelation_Total.id_CurrEduCls);
objcc_WorkStuRelation_TotalEN.id_CurrEduCls = strid_CurrEduCls; //当前教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation_Total.id_CurrEduCls) == false)
{
objcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(concc_WorkStuRelation_Total.id_CurrEduCls, strComparisonOp);
}
else
{
objcc_WorkStuRelation_TotalEN.dicFldComparisonOp[concc_WorkStuRelation_Total.id_CurrEduCls] = strComparisonOp;
}
}
return objcc_WorkStuRelation_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelation_TotalEN Setid_StudentInfo(this clscc_WorkStuRelation_TotalEN objcc_WorkStuRelation_TotalEN, string strid_StudentInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_StudentInfo, concc_WorkStuRelation_Total.id_StudentInfo);
clsCheckSql.CheckFieldLen(strid_StudentInfo, 8, concc_WorkStuRelation_Total.id_StudentInfo);
clsCheckSql.CheckFieldForeignKey(strid_StudentInfo, 8, concc_WorkStuRelation_Total.id_StudentInfo);
objcc_WorkStuRelation_TotalEN.id_StudentInfo = strid_StudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation_Total.id_StudentInfo) == false)
{
objcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(concc_WorkStuRelation_Total.id_StudentInfo, strComparisonOp);
}
else
{
objcc_WorkStuRelation_TotalEN.dicFldComparisonOp[concc_WorkStuRelation_Total.id_StudentInfo] = strComparisonOp;
}
}
return objcc_WorkStuRelation_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelation_TotalEN SetWorkNum(this clscc_WorkStuRelation_TotalEN objcc_WorkStuRelation_TotalEN, int intWorkNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intWorkNum, concc_WorkStuRelation_Total.WorkNum);
objcc_WorkStuRelation_TotalEN.WorkNum = intWorkNum; //作业数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation_Total.WorkNum) == false)
{
objcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(concc_WorkStuRelation_Total.WorkNum, strComparisonOp);
}
else
{
objcc_WorkStuRelation_TotalEN.dicFldComparisonOp[concc_WorkStuRelation_Total.WorkNum] = strComparisonOp;
}
}
return objcc_WorkStuRelation_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelation_TotalEN SetWorkNum_Submit(this clscc_WorkStuRelation_TotalEN objcc_WorkStuRelation_TotalEN, int intWorkNum_Submit, string strComparisonOp="")
	{
objcc_WorkStuRelation_TotalEN.WorkNum_Submit = intWorkNum_Submit; //提交作业数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation_Total.WorkNum_Submit) == false)
{
objcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(concc_WorkStuRelation_Total.WorkNum_Submit, strComparisonOp);
}
else
{
objcc_WorkStuRelation_TotalEN.dicFldComparisonOp[concc_WorkStuRelation_Total.WorkNum_Submit] = strComparisonOp;
}
}
return objcc_WorkStuRelation_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelation_TotalEN SetWorkNum_Save(this clscc_WorkStuRelation_TotalEN objcc_WorkStuRelation_TotalEN, int intWorkNum_Save, string strComparisonOp="")
	{
objcc_WorkStuRelation_TotalEN.WorkNum_Save = intWorkNum_Save; //保存作业数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation_Total.WorkNum_Save) == false)
{
objcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(concc_WorkStuRelation_Total.WorkNum_Save, strComparisonOp);
}
else
{
objcc_WorkStuRelation_TotalEN.dicFldComparisonOp[concc_WorkStuRelation_Total.WorkNum_Save] = strComparisonOp;
}
}
return objcc_WorkStuRelation_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelation_TotalEN SetWorkNum_NoFinish(this clscc_WorkStuRelation_TotalEN objcc_WorkStuRelation_TotalEN, int intWorkNum_NoFinish, string strComparisonOp="")
	{
objcc_WorkStuRelation_TotalEN.WorkNum_NoFinish = intWorkNum_NoFinish; //未完成作业数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation_Total.WorkNum_NoFinish) == false)
{
objcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(concc_WorkStuRelation_Total.WorkNum_NoFinish, strComparisonOp);
}
else
{
objcc_WorkStuRelation_TotalEN.dicFldComparisonOp[concc_WorkStuRelation_Total.WorkNum_NoFinish] = strComparisonOp;
}
}
return objcc_WorkStuRelation_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelation_TotalEN SetWorkNum_SendBack(this clscc_WorkStuRelation_TotalEN objcc_WorkStuRelation_TotalEN, int intWorkNum_SendBack, string strComparisonOp="")
	{
objcc_WorkStuRelation_TotalEN.WorkNum_SendBack = intWorkNum_SendBack; //退回作业数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation_Total.WorkNum_SendBack) == false)
{
objcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(concc_WorkStuRelation_Total.WorkNum_SendBack, strComparisonOp);
}
else
{
objcc_WorkStuRelation_TotalEN.dicFldComparisonOp[concc_WorkStuRelation_Total.WorkNum_SendBack] = strComparisonOp;
}
}
return objcc_WorkStuRelation_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelation_TotalEN SetWorkNum_Mark(this clscc_WorkStuRelation_TotalEN objcc_WorkStuRelation_TotalEN, int intWorkNum_Mark, string strComparisonOp="")
	{
objcc_WorkStuRelation_TotalEN.WorkNum_Mark = intWorkNum_Mark; //批改作业数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation_Total.WorkNum_Mark) == false)
{
objcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(concc_WorkStuRelation_Total.WorkNum_Mark, strComparisonOp);
}
else
{
objcc_WorkStuRelation_TotalEN.dicFldComparisonOp[concc_WorkStuRelation_Total.WorkNum_Mark] = strComparisonOp;
}
}
return objcc_WorkStuRelation_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelation_TotalEN SetWorkNum_Look(this clscc_WorkStuRelation_TotalEN objcc_WorkStuRelation_TotalEN, int intWorkNum_Look, string strComparisonOp="")
	{
objcc_WorkStuRelation_TotalEN.WorkNum_Look = intWorkNum_Look; //查看作业数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation_Total.WorkNum_Look) == false)
{
objcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(concc_WorkStuRelation_Total.WorkNum_Look, strComparisonOp);
}
else
{
objcc_WorkStuRelation_TotalEN.dicFldComparisonOp[concc_WorkStuRelation_Total.WorkNum_Look] = strComparisonOp;
}
}
return objcc_WorkStuRelation_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelation_TotalEN SetWorkNum_Overdue(this clscc_WorkStuRelation_TotalEN objcc_WorkStuRelation_TotalEN, int intWorkNum_Overdue, string strComparisonOp="")
	{
objcc_WorkStuRelation_TotalEN.WorkNum_Overdue = intWorkNum_Overdue; //逾期作业数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation_Total.WorkNum_Overdue) == false)
{
objcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(concc_WorkStuRelation_Total.WorkNum_Overdue, strComparisonOp);
}
else
{
objcc_WorkStuRelation_TotalEN.dicFldComparisonOp[concc_WorkStuRelation_Total.WorkNum_Overdue] = strComparisonOp;
}
}
return objcc_WorkStuRelation_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelation_TotalEN SetTotalScore(this clscc_WorkStuRelation_TotalEN objcc_WorkStuRelation_TotalEN, double dblTotalScore, string strComparisonOp="")
	{
objcc_WorkStuRelation_TotalEN.TotalScore = dblTotalScore; //总得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation_Total.TotalScore) == false)
{
objcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(concc_WorkStuRelation_Total.TotalScore, strComparisonOp);
}
else
{
objcc_WorkStuRelation_TotalEN.dicFldComparisonOp[concc_WorkStuRelation_Total.TotalScore] = strComparisonOp;
}
}
return objcc_WorkStuRelation_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelation_TotalEN SetTotalScores(this clscc_WorkStuRelation_TotalEN objcc_WorkStuRelation_TotalEN, double dblTotalScores, string strComparisonOp="")
	{
objcc_WorkStuRelation_TotalEN.TotalScores = dblTotalScores; //总分值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation_Total.TotalScores) == false)
{
objcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(concc_WorkStuRelation_Total.TotalScores, strComparisonOp);
}
else
{
objcc_WorkStuRelation_TotalEN.dicFldComparisonOp[concc_WorkStuRelation_Total.TotalScores] = strComparisonOp;
}
}
return objcc_WorkStuRelation_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelation_TotalEN SetSchoolYear(this clscc_WorkStuRelation_TotalEN objcc_WorkStuRelation_TotalEN, string strSchoolYear, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, concc_WorkStuRelation_Total.SchoolYear);
objcc_WorkStuRelation_TotalEN.SchoolYear = strSchoolYear; //学年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation_Total.SchoolYear) == false)
{
objcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(concc_WorkStuRelation_Total.SchoolYear, strComparisonOp);
}
else
{
objcc_WorkStuRelation_TotalEN.dicFldComparisonOp[concc_WorkStuRelation_Total.SchoolYear] = strComparisonOp;
}
}
return objcc_WorkStuRelation_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelation_TotalEN SetSchoolTerm(this clscc_WorkStuRelation_TotalEN objcc_WorkStuRelation_TotalEN, string strSchoolTerm, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, concc_WorkStuRelation_Total.SchoolTerm);
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, concc_WorkStuRelation_Total.SchoolTerm);
objcc_WorkStuRelation_TotalEN.SchoolTerm = strSchoolTerm; //学期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation_Total.SchoolTerm) == false)
{
objcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(concc_WorkStuRelation_Total.SchoolTerm, strComparisonOp);
}
else
{
objcc_WorkStuRelation_TotalEN.dicFldComparisonOp[concc_WorkStuRelation_Total.SchoolTerm] = strComparisonOp;
}
}
return objcc_WorkStuRelation_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelation_TotalEN SetUpdDate(this clscc_WorkStuRelation_TotalEN objcc_WorkStuRelation_TotalEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, concc_WorkStuRelation_Total.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, concc_WorkStuRelation_Total.UpdDate);
objcc_WorkStuRelation_TotalEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation_Total.UpdDate) == false)
{
objcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(concc_WorkStuRelation_Total.UpdDate, strComparisonOp);
}
else
{
objcc_WorkStuRelation_TotalEN.dicFldComparisonOp[concc_WorkStuRelation_Total.UpdDate] = strComparisonOp;
}
}
return objcc_WorkStuRelation_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelation_TotalEN SetUpdUserId(this clscc_WorkStuRelation_TotalEN objcc_WorkStuRelation_TotalEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, concc_WorkStuRelation_Total.UpdUserId);
objcc_WorkStuRelation_TotalEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation_Total.UpdUserId) == false)
{
objcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(concc_WorkStuRelation_Total.UpdUserId, strComparisonOp);
}
else
{
objcc_WorkStuRelation_TotalEN.dicFldComparisonOp[concc_WorkStuRelation_Total.UpdUserId] = strComparisonOp;
}
}
return objcc_WorkStuRelation_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelation_TotalEN SetMemo(this clscc_WorkStuRelation_TotalEN objcc_WorkStuRelation_TotalEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, concc_WorkStuRelation_Total.Memo);
objcc_WorkStuRelation_TotalEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation_TotalEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation_Total.Memo) == false)
{
objcc_WorkStuRelation_TotalEN.dicFldComparisonOp.Add(concc_WorkStuRelation_Total.Memo, strComparisonOp);
}
else
{
objcc_WorkStuRelation_TotalEN.dicFldComparisonOp[concc_WorkStuRelation_Total.Memo] = strComparisonOp;
}
}
return objcc_WorkStuRelation_TotalEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscc_WorkStuRelation_TotalEN objcc_WorkStuRelation_Total_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcc_WorkStuRelation_Total_Cond.IsUpdated(concc_WorkStuRelation_Total.Id_WorkStuRelation_Total) == true)
{
string strComparisonOp_Id_WorkStuRelation_Total = objcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[concc_WorkStuRelation_Total.Id_WorkStuRelation_Total];
strWhereCond += string.Format(" And {0} {2} {1}", concc_WorkStuRelation_Total.Id_WorkStuRelation_Total, objcc_WorkStuRelation_Total_Cond.Id_WorkStuRelation_Total, strComparisonOp_Id_WorkStuRelation_Total);
}
if (objcc_WorkStuRelation_Total_Cond.IsUpdated(concc_WorkStuRelation_Total.id_CurrEduCls) == true)
{
string strComparisonOp_id_CurrEduCls = objcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[concc_WorkStuRelation_Total.id_CurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation_Total.id_CurrEduCls, objcc_WorkStuRelation_Total_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (objcc_WorkStuRelation_Total_Cond.IsUpdated(concc_WorkStuRelation_Total.id_StudentInfo) == true)
{
string strComparisonOp_id_StudentInfo = objcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[concc_WorkStuRelation_Total.id_StudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation_Total.id_StudentInfo, objcc_WorkStuRelation_Total_Cond.id_StudentInfo, strComparisonOp_id_StudentInfo);
}
if (objcc_WorkStuRelation_Total_Cond.IsUpdated(concc_WorkStuRelation_Total.WorkNum) == true)
{
string strComparisonOp_WorkNum = objcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[concc_WorkStuRelation_Total.WorkNum];
strWhereCond += string.Format(" And {0} {2} {1}", concc_WorkStuRelation_Total.WorkNum, objcc_WorkStuRelation_Total_Cond.WorkNum, strComparisonOp_WorkNum);
}
if (objcc_WorkStuRelation_Total_Cond.IsUpdated(concc_WorkStuRelation_Total.WorkNum_Submit) == true)
{
string strComparisonOp_WorkNum_Submit = objcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[concc_WorkStuRelation_Total.WorkNum_Submit];
strWhereCond += string.Format(" And {0} {2} {1}", concc_WorkStuRelation_Total.WorkNum_Submit, objcc_WorkStuRelation_Total_Cond.WorkNum_Submit, strComparisonOp_WorkNum_Submit);
}
if (objcc_WorkStuRelation_Total_Cond.IsUpdated(concc_WorkStuRelation_Total.WorkNum_Save) == true)
{
string strComparisonOp_WorkNum_Save = objcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[concc_WorkStuRelation_Total.WorkNum_Save];
strWhereCond += string.Format(" And {0} {2} {1}", concc_WorkStuRelation_Total.WorkNum_Save, objcc_WorkStuRelation_Total_Cond.WorkNum_Save, strComparisonOp_WorkNum_Save);
}
if (objcc_WorkStuRelation_Total_Cond.IsUpdated(concc_WorkStuRelation_Total.WorkNum_NoFinish) == true)
{
string strComparisonOp_WorkNum_NoFinish = objcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[concc_WorkStuRelation_Total.WorkNum_NoFinish];
strWhereCond += string.Format(" And {0} {2} {1}", concc_WorkStuRelation_Total.WorkNum_NoFinish, objcc_WorkStuRelation_Total_Cond.WorkNum_NoFinish, strComparisonOp_WorkNum_NoFinish);
}
if (objcc_WorkStuRelation_Total_Cond.IsUpdated(concc_WorkStuRelation_Total.WorkNum_SendBack) == true)
{
string strComparisonOp_WorkNum_SendBack = objcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[concc_WorkStuRelation_Total.WorkNum_SendBack];
strWhereCond += string.Format(" And {0} {2} {1}", concc_WorkStuRelation_Total.WorkNum_SendBack, objcc_WorkStuRelation_Total_Cond.WorkNum_SendBack, strComparisonOp_WorkNum_SendBack);
}
if (objcc_WorkStuRelation_Total_Cond.IsUpdated(concc_WorkStuRelation_Total.WorkNum_Mark) == true)
{
string strComparisonOp_WorkNum_Mark = objcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[concc_WorkStuRelation_Total.WorkNum_Mark];
strWhereCond += string.Format(" And {0} {2} {1}", concc_WorkStuRelation_Total.WorkNum_Mark, objcc_WorkStuRelation_Total_Cond.WorkNum_Mark, strComparisonOp_WorkNum_Mark);
}
if (objcc_WorkStuRelation_Total_Cond.IsUpdated(concc_WorkStuRelation_Total.WorkNum_Look) == true)
{
string strComparisonOp_WorkNum_Look = objcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[concc_WorkStuRelation_Total.WorkNum_Look];
strWhereCond += string.Format(" And {0} {2} {1}", concc_WorkStuRelation_Total.WorkNum_Look, objcc_WorkStuRelation_Total_Cond.WorkNum_Look, strComparisonOp_WorkNum_Look);
}
if (objcc_WorkStuRelation_Total_Cond.IsUpdated(concc_WorkStuRelation_Total.WorkNum_Overdue) == true)
{
string strComparisonOp_WorkNum_Overdue = objcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[concc_WorkStuRelation_Total.WorkNum_Overdue];
strWhereCond += string.Format(" And {0} {2} {1}", concc_WorkStuRelation_Total.WorkNum_Overdue, objcc_WorkStuRelation_Total_Cond.WorkNum_Overdue, strComparisonOp_WorkNum_Overdue);
}
if (objcc_WorkStuRelation_Total_Cond.IsUpdated(concc_WorkStuRelation_Total.TotalScore) == true)
{
string strComparisonOp_TotalScore = objcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[concc_WorkStuRelation_Total.TotalScore];
strWhereCond += string.Format(" And {0} {2} {1}", concc_WorkStuRelation_Total.TotalScore, objcc_WorkStuRelation_Total_Cond.TotalScore, strComparisonOp_TotalScore);
}
if (objcc_WorkStuRelation_Total_Cond.IsUpdated(concc_WorkStuRelation_Total.TotalScores) == true)
{
string strComparisonOp_TotalScores = objcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[concc_WorkStuRelation_Total.TotalScores];
strWhereCond += string.Format(" And {0} {2} {1}", concc_WorkStuRelation_Total.TotalScores, objcc_WorkStuRelation_Total_Cond.TotalScores, strComparisonOp_TotalScores);
}
if (objcc_WorkStuRelation_Total_Cond.IsUpdated(concc_WorkStuRelation_Total.SchoolYear) == true)
{
string strComparisonOp_SchoolYear = objcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[concc_WorkStuRelation_Total.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation_Total.SchoolYear, objcc_WorkStuRelation_Total_Cond.SchoolYear, strComparisonOp_SchoolYear);
}
if (objcc_WorkStuRelation_Total_Cond.IsUpdated(concc_WorkStuRelation_Total.SchoolTerm) == true)
{
string strComparisonOp_SchoolTerm = objcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[concc_WorkStuRelation_Total.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation_Total.SchoolTerm, objcc_WorkStuRelation_Total_Cond.SchoolTerm, strComparisonOp_SchoolTerm);
}
if (objcc_WorkStuRelation_Total_Cond.IsUpdated(concc_WorkStuRelation_Total.UpdDate) == true)
{
string strComparisonOp_UpdDate = objcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[concc_WorkStuRelation_Total.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation_Total.UpdDate, objcc_WorkStuRelation_Total_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objcc_WorkStuRelation_Total_Cond.IsUpdated(concc_WorkStuRelation_Total.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[concc_WorkStuRelation_Total.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation_Total.UpdUserId, objcc_WorkStuRelation_Total_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objcc_WorkStuRelation_Total_Cond.IsUpdated(concc_WorkStuRelation_Total.Memo) == true)
{
string strComparisonOp_Memo = objcc_WorkStuRelation_Total_Cond.dicFldComparisonOp[concc_WorkStuRelation_Total.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation_Total.Memo, objcc_WorkStuRelation_Total_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation_TotalEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_WorkStuRelation_TotalEN objcc_WorkStuRelation_TotalEN)
{
 if (objcc_WorkStuRelation_TotalEN.Id_WorkStuRelation_Total == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objcc_WorkStuRelation_TotalEN.sf_UpdFldSetStr = objcc_WorkStuRelation_TotalEN.getsf_UpdFldSetStr();
clscc_WorkStuRelation_TotalWApi.CheckPropertyNew(objcc_WorkStuRelation_TotalEN); 
bool bolResult = clscc_WorkStuRelation_TotalWApi.UpdateRecord(objcc_WorkStuRelation_TotalEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelation_TotalWApi.ReFreshCache();
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
 /// 检查唯一性(Uniqueness)--cc_WorkStuRelation_Total(学生作业完成情况汇总), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation_TotalEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_id_CurrEduCls_id_StudentInfo(this clscc_WorkStuRelation_TotalEN objcc_WorkStuRelation_TotalEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objcc_WorkStuRelation_TotalEN == null) return "";
if (objcc_WorkStuRelation_TotalEN.Id_WorkStuRelation_Total == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and id_CurrEduCls = '{0}'", objcc_WorkStuRelation_TotalEN.id_CurrEduCls);
 sbCondition.AppendFormat(" and id_StudentInfo = '{0}'", objcc_WorkStuRelation_TotalEN.id_StudentInfo);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("Id_WorkStuRelation_Total !=  {0}", objcc_WorkStuRelation_TotalEN.Id_WorkStuRelation_Total);
 sbCondition.AppendFormat(" and id_CurrEduCls = '{0}'", objcc_WorkStuRelation_TotalEN.id_CurrEduCls);
 sbCondition.AppendFormat(" and id_StudentInfo = '{0}'", objcc_WorkStuRelation_TotalEN.id_StudentInfo);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation_TotalEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscc_WorkStuRelation_TotalEN objcc_WorkStuRelation_TotalEN)
{
try
{
clscc_WorkStuRelation_TotalWApi.CheckPropertyNew(objcc_WorkStuRelation_TotalEN); 
bool bolResult = clscc_WorkStuRelation_TotalWApi.AddNewRecord(objcc_WorkStuRelation_TotalEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelation_TotalWApi.ReFreshCache();
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
 /// <param name = "objcc_WorkStuRelation_TotalEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_WorkStuRelation_TotalEN objcc_WorkStuRelation_TotalEN, string strWhereCond)
{
try
{
clscc_WorkStuRelation_TotalWApi.CheckPropertyNew(objcc_WorkStuRelation_TotalEN); 
bool bolResult = clscc_WorkStuRelation_TotalWApi.UpdateWithCondition(objcc_WorkStuRelation_TotalEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelation_TotalWApi.ReFreshCache();
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
 /// 学生作业完成情况汇总(cc_WorkStuRelation_Total)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clscc_WorkStuRelation_TotalWApi
{
private static readonly string mstrApiControllerName = "cc_WorkStuRelation_TotalApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clscc_WorkStuRelation_TotalWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clscc_WorkStuRelation_TotalEN objcc_WorkStuRelation_TotalEN)
{
if (!Object.Equals(null, objcc_WorkStuRelation_TotalEN.id_CurrEduCls) && GetStrLen(objcc_WorkStuRelation_TotalEN.id_CurrEduCls) > 8)
{
 throw new Exception("字段[当前教学班流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_WorkStuRelation_TotalEN.id_StudentInfo) && GetStrLen(objcc_WorkStuRelation_TotalEN.id_StudentInfo) > 8)
{
 throw new Exception("字段[学生流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_WorkStuRelation_TotalEN.SchoolYear) && GetStrLen(objcc_WorkStuRelation_TotalEN.SchoolYear) > 10)
{
 throw new Exception("字段[学年]的长度不能超过10!");
}
if (!Object.Equals(null, objcc_WorkStuRelation_TotalEN.SchoolTerm) && GetStrLen(objcc_WorkStuRelation_TotalEN.SchoolTerm) > 1)
{
 throw new Exception("字段[学期]的长度不能超过1!");
}
if (!Object.Equals(null, objcc_WorkStuRelation_TotalEN.UpdDate) && GetStrLen(objcc_WorkStuRelation_TotalEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_WorkStuRelation_TotalEN.UpdUserId) && GetStrLen(objcc_WorkStuRelation_TotalEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_WorkStuRelation_TotalEN.Memo) && GetStrLen(objcc_WorkStuRelation_TotalEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objcc_WorkStuRelation_TotalEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngId_WorkStuRelation_Total">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_WorkStuRelation_TotalEN GetObjById_WorkStuRelation_Total(long lngId_WorkStuRelation_Total)
{
string strAction = "GetObjById_WorkStuRelation_Total";
string strErrMsg = string.Empty;
string strResult = "";
clscc_WorkStuRelation_TotalEN objcc_WorkStuRelation_TotalEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_WorkStuRelation_Total"] = lngId_WorkStuRelation_Total.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objcc_WorkStuRelation_TotalEN = JsonConvert.DeserializeObject<clscc_WorkStuRelation_TotalEN>((string)jobjReturn["ReturnObj"]);
return objcc_WorkStuRelation_TotalEN;
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
 /// <param name = "lngId_WorkStuRelation_Total">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_WorkStuRelation_TotalEN GetObjById_WorkStuRelation_Total_WA_Cache(long lngId_WorkStuRelation_Total)
{
string strAction = "GetObjById_WorkStuRelation_Total_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clscc_WorkStuRelation_TotalEN objcc_WorkStuRelation_TotalEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_WorkStuRelation_Total"] = lngId_WorkStuRelation_Total.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objcc_WorkStuRelation_TotalEN = JsonConvert.DeserializeObject<clscc_WorkStuRelation_TotalEN>((string)jobjReturn["ReturnObj"]);
return objcc_WorkStuRelation_TotalEN;
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
public static clscc_WorkStuRelation_TotalEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clscc_WorkStuRelation_TotalEN objcc_WorkStuRelation_TotalEN = null;
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
objcc_WorkStuRelation_TotalEN = JsonConvert.DeserializeObject<clscc_WorkStuRelation_TotalEN>((string)jobjReturn["ReturnObj"]);
return objcc_WorkStuRelation_TotalEN;
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
 /// <param name = "lngId_WorkStuRelation_Total">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_WorkStuRelation_TotalEN GetObjById_WorkStuRelation_Total_Cache(long lngId_WorkStuRelation_Total)
{
//初始化列表缓存
string strKey = string.Format("{0}", clscc_WorkStuRelation_TotalEN._CurrTabName_S);
List<clscc_WorkStuRelation_TotalEN> arrcc_WorkStuRelation_TotalObjLst_Cache = GetObjLst_Cache();
IEnumerable <clscc_WorkStuRelation_TotalEN> arrcc_WorkStuRelation_TotalObjLst_Sel =
from objcc_WorkStuRelation_TotalEN in arrcc_WorkStuRelation_TotalObjLst_Cache
where objcc_WorkStuRelation_TotalEN.Id_WorkStuRelation_Total == lngId_WorkStuRelation_Total
select objcc_WorkStuRelation_TotalEN;
if (arrcc_WorkStuRelation_TotalObjLst_Sel.Count() == 0)
{
   clscc_WorkStuRelation_TotalEN obj = clscc_WorkStuRelation_TotalWApi.GetObjById_WorkStuRelation_Total(lngId_WorkStuRelation_Total);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrcc_WorkStuRelation_TotalObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_WorkStuRelation_TotalEN> GetObjLst(string strWhereCond)
{
 List<clscc_WorkStuRelation_TotalEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_WorkStuRelation_TotalEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_WorkStuRelation_TotalEN> GetObjLstById_WorkStuRelation_TotalLst(List<long> arrId_WorkStuRelation_Total)
{
 List<clscc_WorkStuRelation_TotalEN> arrObjLst = null; 
string strAction = "GetObjLstById_WorkStuRelation_TotalLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_WorkStuRelation_Total);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clscc_WorkStuRelation_TotalEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngId_WorkStuRelation_Total">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clscc_WorkStuRelation_TotalEN> GetObjLstById_WorkStuRelation_TotalLst_Cache(List<long> arrId_WorkStuRelation_Total)
{
//初始化列表缓存
string strKey = string.Format("{0}", clscc_WorkStuRelation_TotalEN._CurrTabName_S);
List<clscc_WorkStuRelation_TotalEN> arrcc_WorkStuRelation_TotalObjLst_Cache = GetObjLst_Cache();
IEnumerable <clscc_WorkStuRelation_TotalEN> arrcc_WorkStuRelation_TotalObjLst_Sel =
from objcc_WorkStuRelation_TotalEN in arrcc_WorkStuRelation_TotalObjLst_Cache
where arrId_WorkStuRelation_Total.Contains(objcc_WorkStuRelation_TotalEN.Id_WorkStuRelation_Total)
select objcc_WorkStuRelation_TotalEN;
return arrcc_WorkStuRelation_TotalObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_WorkStuRelation_TotalEN> GetObjLstById_WorkStuRelation_TotalLst_WA_Cache(List<long> arrId_WorkStuRelation_Total)
{
 List<clscc_WorkStuRelation_TotalEN> arrObjLst = null; 
string strAction = "GetObjLstById_WorkStuRelation_TotalLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_WorkStuRelation_Total);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clscc_WorkStuRelation_TotalEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_WorkStuRelation_TotalEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clscc_WorkStuRelation_TotalEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_WorkStuRelation_TotalEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_WorkStuRelation_TotalEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clscc_WorkStuRelation_TotalEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_WorkStuRelation_TotalEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_WorkStuRelation_TotalEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clscc_WorkStuRelation_TotalEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_WorkStuRelation_TotalEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_WorkStuRelation_TotalEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clscc_WorkStuRelation_TotalEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_WorkStuRelation_TotalEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(long lngId_WorkStuRelation_Total)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clscc_WorkStuRelation_TotalEN objcc_WorkStuRelation_TotalEN = clscc_WorkStuRelation_TotalWApi.GetObjById_WorkStuRelation_Total(lngId_WorkStuRelation_Total);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngId_WorkStuRelation_Total.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clscc_WorkStuRelation_TotalWApi.ReFreshCache();
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
public static int Delcc_WorkStuRelation_Totals(List<string> arrId_WorkStuRelation_Total)
{
string strAction = "Delcc_WorkStuRelation_Totals";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_WorkStuRelation_Total);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clscc_WorkStuRelation_TotalWApi.ReFreshCache();
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
public static int Delcc_WorkStuRelation_TotalsByCond(string strWhereCond)
{
string strAction = "Delcc_WorkStuRelation_TotalsByCond";
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
public static bool AddNewRecord(clscc_WorkStuRelation_TotalEN objcc_WorkStuRelation_TotalEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_WorkStuRelation_TotalEN>(objcc_WorkStuRelation_TotalEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelation_TotalWApi.ReFreshCache();
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
 /// <param name = "objcc_WorkStuRelation_TotalEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clscc_WorkStuRelation_TotalEN objcc_WorkStuRelation_TotalEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_WorkStuRelation_TotalEN>(objcc_WorkStuRelation_TotalEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelation_TotalWApi.ReFreshCache();
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
public static bool UpdateRecord(clscc_WorkStuRelation_TotalEN objcc_WorkStuRelation_TotalEN)
{
if (string.IsNullOrEmpty(objcc_WorkStuRelation_TotalEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_WorkStuRelation_TotalEN.Id_WorkStuRelation_Total, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_WorkStuRelation_TotalEN>(objcc_WorkStuRelation_TotalEN);
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
 /// <param name = "objcc_WorkStuRelation_TotalEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clscc_WorkStuRelation_TotalEN objcc_WorkStuRelation_TotalEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objcc_WorkStuRelation_TotalEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_WorkStuRelation_TotalEN.Id_WorkStuRelation_Total, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_WorkStuRelation_TotalEN.Id_WorkStuRelation_Total, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_WorkStuRelation_TotalEN>(objcc_WorkStuRelation_TotalEN);
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
public static bool IsExist(long lngId_WorkStuRelation_Total)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_WorkStuRelation_Total"] = lngId_WorkStuRelation_Total.ToString()
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
 /// <param name = "objcc_WorkStuRelation_TotalENS">源对象</param>
 /// <param name = "objcc_WorkStuRelation_TotalENT">目标对象</param>
 public static void CopyTo(clscc_WorkStuRelation_TotalEN objcc_WorkStuRelation_TotalENS, clscc_WorkStuRelation_TotalEN objcc_WorkStuRelation_TotalENT)
{
try
{
objcc_WorkStuRelation_TotalENT.Id_WorkStuRelation_Total = objcc_WorkStuRelation_TotalENS.Id_WorkStuRelation_Total; //流水号
objcc_WorkStuRelation_TotalENT.id_CurrEduCls = objcc_WorkStuRelation_TotalENS.id_CurrEduCls; //当前教学班流水号
objcc_WorkStuRelation_TotalENT.id_StudentInfo = objcc_WorkStuRelation_TotalENS.id_StudentInfo; //学生流水号
objcc_WorkStuRelation_TotalENT.WorkNum = objcc_WorkStuRelation_TotalENS.WorkNum; //作业数
objcc_WorkStuRelation_TotalENT.WorkNum_Submit = objcc_WorkStuRelation_TotalENS.WorkNum_Submit; //提交作业数
objcc_WorkStuRelation_TotalENT.WorkNum_Save = objcc_WorkStuRelation_TotalENS.WorkNum_Save; //保存作业数
objcc_WorkStuRelation_TotalENT.WorkNum_NoFinish = objcc_WorkStuRelation_TotalENS.WorkNum_NoFinish; //未完成作业数
objcc_WorkStuRelation_TotalENT.WorkNum_SendBack = objcc_WorkStuRelation_TotalENS.WorkNum_SendBack; //退回作业数
objcc_WorkStuRelation_TotalENT.WorkNum_Mark = objcc_WorkStuRelation_TotalENS.WorkNum_Mark; //批改作业数
objcc_WorkStuRelation_TotalENT.WorkNum_Look = objcc_WorkStuRelation_TotalENS.WorkNum_Look; //查看作业数
objcc_WorkStuRelation_TotalENT.WorkNum_Overdue = objcc_WorkStuRelation_TotalENS.WorkNum_Overdue; //逾期作业数
objcc_WorkStuRelation_TotalENT.TotalScore = objcc_WorkStuRelation_TotalENS.TotalScore; //总得分
objcc_WorkStuRelation_TotalENT.TotalScores = objcc_WorkStuRelation_TotalENS.TotalScores; //总分值
objcc_WorkStuRelation_TotalENT.SchoolYear = objcc_WorkStuRelation_TotalENS.SchoolYear; //学年
objcc_WorkStuRelation_TotalENT.SchoolTerm = objcc_WorkStuRelation_TotalENS.SchoolTerm; //学期
objcc_WorkStuRelation_TotalENT.UpdDate = objcc_WorkStuRelation_TotalENS.UpdDate; //修改日期
objcc_WorkStuRelation_TotalENT.UpdUserId = objcc_WorkStuRelation_TotalENS.UpdUserId; //修改用户Id
objcc_WorkStuRelation_TotalENT.Memo = objcc_WorkStuRelation_TotalENS.Memo; //备注
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
public static DataTable ToDataTable(List<clscc_WorkStuRelation_TotalEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clscc_WorkStuRelation_TotalEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clscc_WorkStuRelation_TotalEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clscc_WorkStuRelation_TotalEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clscc_WorkStuRelation_TotalEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clscc_WorkStuRelation_TotalEN.AttributeName)
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
if (clscc_WorkStuRelation_TotalWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_WorkStuRelation_TotalWApi没有刷新缓存机制(clscc_WorkStuRelation_TotalWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by Id_WorkStuRelation_Total");
//if (arrcc_WorkStuRelation_TotalObjLst_Cache == null)
//{
//arrcc_WorkStuRelation_TotalObjLst_Cache = await clscc_WorkStuRelation_TotalWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clscc_WorkStuRelation_TotalEN._CurrTabName_S);
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
if (clscc_WorkStuRelation_TotalWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clscc_WorkStuRelation_TotalEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clscc_WorkStuRelation_TotalWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_WorkStuRelation_TotalEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clscc_WorkStuRelation_TotalEN._CurrTabName_S);
List<clscc_WorkStuRelation_TotalEN> arrcc_WorkStuRelation_TotalObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrcc_WorkStuRelation_TotalObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clscc_WorkStuRelation_TotalEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(concc_WorkStuRelation_Total.Id_WorkStuRelation_Total, Type.GetType("System.Int64"));
objDT.Columns.Add(concc_WorkStuRelation_Total.id_CurrEduCls, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkStuRelation_Total.id_StudentInfo, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkStuRelation_Total.WorkNum, Type.GetType("System.Int32"));
objDT.Columns.Add(concc_WorkStuRelation_Total.WorkNum_Submit, Type.GetType("System.Int32"));
objDT.Columns.Add(concc_WorkStuRelation_Total.WorkNum_Save, Type.GetType("System.Int32"));
objDT.Columns.Add(concc_WorkStuRelation_Total.WorkNum_NoFinish, Type.GetType("System.Int32"));
objDT.Columns.Add(concc_WorkStuRelation_Total.WorkNum_SendBack, Type.GetType("System.Int32"));
objDT.Columns.Add(concc_WorkStuRelation_Total.WorkNum_Mark, Type.GetType("System.Int32"));
objDT.Columns.Add(concc_WorkStuRelation_Total.WorkNum_Look, Type.GetType("System.Int32"));
objDT.Columns.Add(concc_WorkStuRelation_Total.WorkNum_Overdue, Type.GetType("System.Int32"));
objDT.Columns.Add(concc_WorkStuRelation_Total.TotalScore, Type.GetType("System.Decimal"));
objDT.Columns.Add(concc_WorkStuRelation_Total.TotalScores, Type.GetType("System.Decimal"));
objDT.Columns.Add(concc_WorkStuRelation_Total.SchoolYear, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkStuRelation_Total.SchoolTerm, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkStuRelation_Total.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkStuRelation_Total.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkStuRelation_Total.Memo, Type.GetType("System.String"));
foreach (clscc_WorkStuRelation_TotalEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[concc_WorkStuRelation_Total.Id_WorkStuRelation_Total] = objInFor[concc_WorkStuRelation_Total.Id_WorkStuRelation_Total];
objDR[concc_WorkStuRelation_Total.id_CurrEduCls] = objInFor[concc_WorkStuRelation_Total.id_CurrEduCls];
objDR[concc_WorkStuRelation_Total.id_StudentInfo] = objInFor[concc_WorkStuRelation_Total.id_StudentInfo];
objDR[concc_WorkStuRelation_Total.WorkNum] = objInFor[concc_WorkStuRelation_Total.WorkNum];
objDR[concc_WorkStuRelation_Total.WorkNum_Submit] = objInFor[concc_WorkStuRelation_Total.WorkNum_Submit];
objDR[concc_WorkStuRelation_Total.WorkNum_Save] = objInFor[concc_WorkStuRelation_Total.WorkNum_Save];
objDR[concc_WorkStuRelation_Total.WorkNum_NoFinish] = objInFor[concc_WorkStuRelation_Total.WorkNum_NoFinish];
objDR[concc_WorkStuRelation_Total.WorkNum_SendBack] = objInFor[concc_WorkStuRelation_Total.WorkNum_SendBack];
objDR[concc_WorkStuRelation_Total.WorkNum_Mark] = objInFor[concc_WorkStuRelation_Total.WorkNum_Mark];
objDR[concc_WorkStuRelation_Total.WorkNum_Look] = objInFor[concc_WorkStuRelation_Total.WorkNum_Look];
objDR[concc_WorkStuRelation_Total.WorkNum_Overdue] = objInFor[concc_WorkStuRelation_Total.WorkNum_Overdue];
objDR[concc_WorkStuRelation_Total.TotalScore] = objInFor[concc_WorkStuRelation_Total.TotalScore];
objDR[concc_WorkStuRelation_Total.TotalScores] = objInFor[concc_WorkStuRelation_Total.TotalScores];
objDR[concc_WorkStuRelation_Total.SchoolYear] = objInFor[concc_WorkStuRelation_Total.SchoolYear];
objDR[concc_WorkStuRelation_Total.SchoolTerm] = objInFor[concc_WorkStuRelation_Total.SchoolTerm];
objDR[concc_WorkStuRelation_Total.UpdDate] = objInFor[concc_WorkStuRelation_Total.UpdDate];
objDR[concc_WorkStuRelation_Total.UpdUserId] = objInFor[concc_WorkStuRelation_Total.UpdUserId];
objDR[concc_WorkStuRelation_Total.Memo] = objInFor[concc_WorkStuRelation_Total.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 学生作业完成情况汇总(cc_WorkStuRelation_Total)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4cc_WorkStuRelation_Total : clsCommFun4BL
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
clscc_WorkStuRelation_TotalWApi.ReFreshThisCache();
clsvcc_WorkStuRelation_TotalWApi.ReFreshThisCache();
}
}

}