
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_ExamPaperStuBatchRelaWApi
 表名:cc_ExamPaperStuBatchRela(01120239)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:51:47
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
public static class clscc_ExamPaperStuBatchRelaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuBatchRelaEN SetId_PaperStuBatch(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, string strId_PaperStuBatch, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_PaperStuBatch, 10, concc_ExamPaperStuBatchRela.Id_PaperStuBatch);
clsCheckSql.CheckFieldForeignKey(strId_PaperStuBatch, 10, concc_ExamPaperStuBatchRela.Id_PaperStuBatch);
objcc_ExamPaperStuBatchRelaEN.Id_PaperStuBatch = strId_PaperStuBatch; //学生试卷批次流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuBatchRela.Id_PaperStuBatch) == false)
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(concc_ExamPaperStuBatchRela.Id_PaperStuBatch, strComparisonOp);
}
else
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[concc_ExamPaperStuBatchRela.Id_PaperStuBatch] = strComparisonOp;
}
}
return objcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuBatchRelaEN SetCourseExamPaperId(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, string strCourseExamPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseExamPaperId, 8, concc_ExamPaperStuBatchRela.CourseExamPaperId);
clsCheckSql.CheckFieldForeignKey(strCourseExamPaperId, 8, concc_ExamPaperStuBatchRela.CourseExamPaperId);
objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId = strCourseExamPaperId; //考卷流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuBatchRela.CourseExamPaperId) == false)
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(concc_ExamPaperStuBatchRela.CourseExamPaperId, strComparisonOp);
}
else
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[concc_ExamPaperStuBatchRela.CourseExamPaperId] = strComparisonOp;
}
}
return objcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuBatchRelaEN Setid_StudentInfo(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, string strid_StudentInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_StudentInfo, concc_ExamPaperStuBatchRela.id_StudentInfo);
clsCheckSql.CheckFieldLen(strid_StudentInfo, 8, concc_ExamPaperStuBatchRela.id_StudentInfo);
clsCheckSql.CheckFieldForeignKey(strid_StudentInfo, 8, concc_ExamPaperStuBatchRela.id_StudentInfo);
objcc_ExamPaperStuBatchRelaEN.id_StudentInfo = strid_StudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuBatchRela.id_StudentInfo) == false)
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(concc_ExamPaperStuBatchRela.id_StudentInfo, strComparisonOp);
}
else
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[concc_ExamPaperStuBatchRela.id_StudentInfo] = strComparisonOp;
}
}
return objcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuBatchRelaEN SetBatchTime(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, string strBatchTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strBatchTime, 14, concc_ExamPaperStuBatchRela.BatchTime);
objcc_ExamPaperStuBatchRelaEN.BatchTime = strBatchTime; //批次
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuBatchRela.BatchTime) == false)
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(concc_ExamPaperStuBatchRela.BatchTime, strComparisonOp);
}
else
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[concc_ExamPaperStuBatchRela.BatchTime] = strComparisonOp;
}
}
return objcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuBatchRelaEN Setid_CurrEduCls(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, string strid_CurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_CurrEduCls, concc_ExamPaperStuBatchRela.id_CurrEduCls);
clsCheckSql.CheckFieldLen(strid_CurrEduCls, 8, concc_ExamPaperStuBatchRela.id_CurrEduCls);
clsCheckSql.CheckFieldForeignKey(strid_CurrEduCls, 8, concc_ExamPaperStuBatchRela.id_CurrEduCls);
objcc_ExamPaperStuBatchRelaEN.id_CurrEduCls = strid_CurrEduCls; //当前教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuBatchRela.id_CurrEduCls) == false)
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(concc_ExamPaperStuBatchRela.id_CurrEduCls, strComparisonOp);
}
else
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[concc_ExamPaperStuBatchRela.id_CurrEduCls] = strComparisonOp;
}
}
return objcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuBatchRelaEN SetScores(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, double dblScores, string strComparisonOp="")
	{
objcc_ExamPaperStuBatchRelaEN.Scores = dblScores; //分值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuBatchRela.Scores) == false)
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(concc_ExamPaperStuBatchRela.Scores, strComparisonOp);
}
else
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[concc_ExamPaperStuBatchRela.Scores] = strComparisonOp;
}
}
return objcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuBatchRelaEN SetIsSave(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, bool bolIsSave, string strComparisonOp="")
	{
objcc_ExamPaperStuBatchRelaEN.IsSave = bolIsSave; //是否保存
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuBatchRela.IsSave) == false)
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(concc_ExamPaperStuBatchRela.IsSave, strComparisonOp);
}
else
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[concc_ExamPaperStuBatchRela.IsSave] = strComparisonOp;
}
}
return objcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuBatchRelaEN SetIsSubmit(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, bool bolIsSubmit, string strComparisonOp="")
	{
objcc_ExamPaperStuBatchRelaEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuBatchRela.IsSubmit) == false)
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(concc_ExamPaperStuBatchRela.IsSubmit, strComparisonOp);
}
else
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[concc_ExamPaperStuBatchRela.IsSubmit] = strComparisonOp;
}
}
return objcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuBatchRelaEN SetRealFinishDate(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, string strRealFinishDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRealFinishDate, 14, concc_ExamPaperStuBatchRela.RealFinishDate);
objcc_ExamPaperStuBatchRelaEN.RealFinishDate = strRealFinishDate; //实际完成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuBatchRela.RealFinishDate) == false)
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(concc_ExamPaperStuBatchRela.RealFinishDate, strComparisonOp);
}
else
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[concc_ExamPaperStuBatchRela.RealFinishDate] = strComparisonOp;
}
}
return objcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuBatchRelaEN SetOperateTime(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, string strOperateTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOperateTime, 14, concc_ExamPaperStuBatchRela.OperateTime);
objcc_ExamPaperStuBatchRelaEN.OperateTime = strOperateTime; //操作时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuBatchRela.OperateTime) == false)
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(concc_ExamPaperStuBatchRela.OperateTime, strComparisonOp);
}
else
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[concc_ExamPaperStuBatchRela.OperateTime] = strComparisonOp;
}
}
return objcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuBatchRelaEN SetIsMarking(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, bool bolIsMarking, string strComparisonOp="")
	{
objcc_ExamPaperStuBatchRelaEN.IsMarking = bolIsMarking; //是否批阅
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuBatchRela.IsMarking) == false)
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(concc_ExamPaperStuBatchRela.IsMarking, strComparisonOp);
}
else
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[concc_ExamPaperStuBatchRela.IsMarking] = strComparisonOp;
}
}
return objcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuBatchRelaEN SetMarkerId(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, string strMarkerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMarkerId, 20, concc_ExamPaperStuBatchRela.MarkerId);
objcc_ExamPaperStuBatchRelaEN.MarkerId = strMarkerId; //打分者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuBatchRela.MarkerId) == false)
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(concc_ExamPaperStuBatchRela.MarkerId, strComparisonOp);
}
else
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[concc_ExamPaperStuBatchRela.MarkerId] = strComparisonOp;
}
}
return objcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuBatchRelaEN SetMarkDate(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, string strMarkDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMarkDate, 14, concc_ExamPaperStuBatchRela.MarkDate);
objcc_ExamPaperStuBatchRelaEN.MarkDate = strMarkDate; //打分日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuBatchRela.MarkDate) == false)
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(concc_ExamPaperStuBatchRela.MarkDate, strComparisonOp);
}
else
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[concc_ExamPaperStuBatchRela.MarkDate] = strComparisonOp;
}
}
return objcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuBatchRelaEN SetAnswerIP(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, string strAnswerIP, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerIP, 30, concc_ExamPaperStuBatchRela.AnswerIP);
objcc_ExamPaperStuBatchRelaEN.AnswerIP = strAnswerIP; //回答IP
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuBatchRela.AnswerIP) == false)
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(concc_ExamPaperStuBatchRela.AnswerIP, strComparisonOp);
}
else
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[concc_ExamPaperStuBatchRela.AnswerIP] = strComparisonOp;
}
}
return objcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuBatchRelaEN SetAnswerDate(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, string strAnswerDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerDate, 8, concc_ExamPaperStuBatchRela.AnswerDate);
objcc_ExamPaperStuBatchRelaEN.AnswerDate = strAnswerDate; //回答日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuBatchRela.AnswerDate) == false)
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(concc_ExamPaperStuBatchRela.AnswerDate, strComparisonOp);
}
else
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[concc_ExamPaperStuBatchRela.AnswerDate] = strComparisonOp;
}
}
return objcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuBatchRelaEN SetAnswerTime(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, string strAnswerTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerTime, 10, concc_ExamPaperStuBatchRela.AnswerTime);
objcc_ExamPaperStuBatchRelaEN.AnswerTime = strAnswerTime; //回答时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuBatchRela.AnswerTime) == false)
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(concc_ExamPaperStuBatchRela.AnswerTime, strComparisonOp);
}
else
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[concc_ExamPaperStuBatchRela.AnswerTime] = strComparisonOp;
}
}
return objcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuBatchRelaEN SetTotalGetScore(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, double dblTotalGetScore, string strComparisonOp="")
	{
objcc_ExamPaperStuBatchRelaEN.TotalGetScore = dblTotalGetScore; //考生获取总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuBatchRela.TotalGetScore) == false)
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(concc_ExamPaperStuBatchRela.TotalGetScore, strComparisonOp);
}
else
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[concc_ExamPaperStuBatchRela.TotalGetScore] = strComparisonOp;
}
}
return objcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuBatchRelaEN SetUpdDate(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, concc_ExamPaperStuBatchRela.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, concc_ExamPaperStuBatchRela.UpdDate);
objcc_ExamPaperStuBatchRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuBatchRela.UpdDate) == false)
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(concc_ExamPaperStuBatchRela.UpdDate, strComparisonOp);
}
else
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[concc_ExamPaperStuBatchRela.UpdDate] = strComparisonOp;
}
}
return objcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuBatchRelaEN SetUpdUserId(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, concc_ExamPaperStuBatchRela.UpdUserId);
objcc_ExamPaperStuBatchRelaEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuBatchRela.UpdUserId) == false)
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(concc_ExamPaperStuBatchRela.UpdUserId, strComparisonOp);
}
else
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[concc_ExamPaperStuBatchRela.UpdUserId] = strComparisonOp;
}
}
return objcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperStuBatchRelaEN SetMemo(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, concc_ExamPaperStuBatchRela.Memo);
objcc_ExamPaperStuBatchRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuBatchRela.Memo) == false)
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(concc_ExamPaperStuBatchRela.Memo, strComparisonOp);
}
else
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[concc_ExamPaperStuBatchRela.Memo] = strComparisonOp;
}
}
return objcc_ExamPaperStuBatchRelaEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRela_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcc_ExamPaperStuBatchRela_Cond.IsUpdated(concc_ExamPaperStuBatchRela.Id_PaperStuBatch) == true)
{
string strComparisonOp_Id_PaperStuBatch = objcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[concc_ExamPaperStuBatchRela.Id_PaperStuBatch];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuBatchRela.Id_PaperStuBatch, objcc_ExamPaperStuBatchRela_Cond.Id_PaperStuBatch, strComparisonOp_Id_PaperStuBatch);
}
if (objcc_ExamPaperStuBatchRela_Cond.IsUpdated(concc_ExamPaperStuBatchRela.CourseExamPaperId) == true)
{
string strComparisonOp_CourseExamPaperId = objcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[concc_ExamPaperStuBatchRela.CourseExamPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuBatchRela.CourseExamPaperId, objcc_ExamPaperStuBatchRela_Cond.CourseExamPaperId, strComparisonOp_CourseExamPaperId);
}
if (objcc_ExamPaperStuBatchRela_Cond.IsUpdated(concc_ExamPaperStuBatchRela.id_StudentInfo) == true)
{
string strComparisonOp_id_StudentInfo = objcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[concc_ExamPaperStuBatchRela.id_StudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuBatchRela.id_StudentInfo, objcc_ExamPaperStuBatchRela_Cond.id_StudentInfo, strComparisonOp_id_StudentInfo);
}
if (objcc_ExamPaperStuBatchRela_Cond.IsUpdated(concc_ExamPaperStuBatchRela.BatchTime) == true)
{
string strComparisonOp_BatchTime = objcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[concc_ExamPaperStuBatchRela.BatchTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuBatchRela.BatchTime, objcc_ExamPaperStuBatchRela_Cond.BatchTime, strComparisonOp_BatchTime);
}
if (objcc_ExamPaperStuBatchRela_Cond.IsUpdated(concc_ExamPaperStuBatchRela.id_CurrEduCls) == true)
{
string strComparisonOp_id_CurrEduCls = objcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[concc_ExamPaperStuBatchRela.id_CurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuBatchRela.id_CurrEduCls, objcc_ExamPaperStuBatchRela_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (objcc_ExamPaperStuBatchRela_Cond.IsUpdated(concc_ExamPaperStuBatchRela.Scores) == true)
{
string strComparisonOp_Scores = objcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[concc_ExamPaperStuBatchRela.Scores];
strWhereCond += string.Format(" And {0} {2} {1}", concc_ExamPaperStuBatchRela.Scores, objcc_ExamPaperStuBatchRela_Cond.Scores, strComparisonOp_Scores);
}
if (objcc_ExamPaperStuBatchRela_Cond.IsUpdated(concc_ExamPaperStuBatchRela.IsSave) == true)
{
if (objcc_ExamPaperStuBatchRela_Cond.IsSave == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_ExamPaperStuBatchRela.IsSave);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_ExamPaperStuBatchRela.IsSave);
}
}
if (objcc_ExamPaperStuBatchRela_Cond.IsUpdated(concc_ExamPaperStuBatchRela.IsSubmit) == true)
{
if (objcc_ExamPaperStuBatchRela_Cond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_ExamPaperStuBatchRela.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_ExamPaperStuBatchRela.IsSubmit);
}
}
if (objcc_ExamPaperStuBatchRela_Cond.IsUpdated(concc_ExamPaperStuBatchRela.RealFinishDate) == true)
{
string strComparisonOp_RealFinishDate = objcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[concc_ExamPaperStuBatchRela.RealFinishDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuBatchRela.RealFinishDate, objcc_ExamPaperStuBatchRela_Cond.RealFinishDate, strComparisonOp_RealFinishDate);
}
if (objcc_ExamPaperStuBatchRela_Cond.IsUpdated(concc_ExamPaperStuBatchRela.OperateTime) == true)
{
string strComparisonOp_OperateTime = objcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[concc_ExamPaperStuBatchRela.OperateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuBatchRela.OperateTime, objcc_ExamPaperStuBatchRela_Cond.OperateTime, strComparisonOp_OperateTime);
}
if (objcc_ExamPaperStuBatchRela_Cond.IsUpdated(concc_ExamPaperStuBatchRela.IsMarking) == true)
{
if (objcc_ExamPaperStuBatchRela_Cond.IsMarking == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_ExamPaperStuBatchRela.IsMarking);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_ExamPaperStuBatchRela.IsMarking);
}
}
if (objcc_ExamPaperStuBatchRela_Cond.IsUpdated(concc_ExamPaperStuBatchRela.MarkerId) == true)
{
string strComparisonOp_MarkerId = objcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[concc_ExamPaperStuBatchRela.MarkerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuBatchRela.MarkerId, objcc_ExamPaperStuBatchRela_Cond.MarkerId, strComparisonOp_MarkerId);
}
if (objcc_ExamPaperStuBatchRela_Cond.IsUpdated(concc_ExamPaperStuBatchRela.MarkDate) == true)
{
string strComparisonOp_MarkDate = objcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[concc_ExamPaperStuBatchRela.MarkDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuBatchRela.MarkDate, objcc_ExamPaperStuBatchRela_Cond.MarkDate, strComparisonOp_MarkDate);
}
if (objcc_ExamPaperStuBatchRela_Cond.IsUpdated(concc_ExamPaperStuBatchRela.AnswerIP) == true)
{
string strComparisonOp_AnswerIP = objcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[concc_ExamPaperStuBatchRela.AnswerIP];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuBatchRela.AnswerIP, objcc_ExamPaperStuBatchRela_Cond.AnswerIP, strComparisonOp_AnswerIP);
}
if (objcc_ExamPaperStuBatchRela_Cond.IsUpdated(concc_ExamPaperStuBatchRela.AnswerDate) == true)
{
string strComparisonOp_AnswerDate = objcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[concc_ExamPaperStuBatchRela.AnswerDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuBatchRela.AnswerDate, objcc_ExamPaperStuBatchRela_Cond.AnswerDate, strComparisonOp_AnswerDate);
}
if (objcc_ExamPaperStuBatchRela_Cond.IsUpdated(concc_ExamPaperStuBatchRela.AnswerTime) == true)
{
string strComparisonOp_AnswerTime = objcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[concc_ExamPaperStuBatchRela.AnswerTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuBatchRela.AnswerTime, objcc_ExamPaperStuBatchRela_Cond.AnswerTime, strComparisonOp_AnswerTime);
}
if (objcc_ExamPaperStuBatchRela_Cond.IsUpdated(concc_ExamPaperStuBatchRela.TotalGetScore) == true)
{
string strComparisonOp_TotalGetScore = objcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[concc_ExamPaperStuBatchRela.TotalGetScore];
strWhereCond += string.Format(" And {0} {2} {1}", concc_ExamPaperStuBatchRela.TotalGetScore, objcc_ExamPaperStuBatchRela_Cond.TotalGetScore, strComparisonOp_TotalGetScore);
}
if (objcc_ExamPaperStuBatchRela_Cond.IsUpdated(concc_ExamPaperStuBatchRela.UpdDate) == true)
{
string strComparisonOp_UpdDate = objcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[concc_ExamPaperStuBatchRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuBatchRela.UpdDate, objcc_ExamPaperStuBatchRela_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objcc_ExamPaperStuBatchRela_Cond.IsUpdated(concc_ExamPaperStuBatchRela.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[concc_ExamPaperStuBatchRela.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuBatchRela.UpdUserId, objcc_ExamPaperStuBatchRela_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objcc_ExamPaperStuBatchRela_Cond.IsUpdated(concc_ExamPaperStuBatchRela.Memo) == true)
{
string strComparisonOp_Memo = objcc_ExamPaperStuBatchRela_Cond.dicFldComparisonOp[concc_ExamPaperStuBatchRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuBatchRela.Memo, objcc_ExamPaperStuBatchRela_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN)
{
 if (string.IsNullOrEmpty(objcc_ExamPaperStuBatchRelaEN.Id_PaperStuBatch) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objcc_ExamPaperStuBatchRelaEN.sf_UpdFldSetStr = objcc_ExamPaperStuBatchRelaEN.getsf_UpdFldSetStr();
clscc_ExamPaperStuBatchRelaWApi.CheckPropertyNew(objcc_ExamPaperStuBatchRelaEN); 
bool bolResult = clscc_ExamPaperStuBatchRelaWApi.UpdateRecord(objcc_ExamPaperStuBatchRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperStuBatchRelaWApi.ReFreshCache(objcc_ExamPaperStuBatchRelaEN.id_CurrEduCls);
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
 /// 检查唯一性(Uniqueness)--cc_ExamPaperStuBatchRela(考卷与学生批次关系), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_CourseExamPaperId_id_StudentInfo(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objcc_ExamPaperStuBatchRelaEN == null) return "";
if (objcc_ExamPaperStuBatchRelaEN.Id_PaperStuBatch == null || objcc_ExamPaperStuBatchRelaEN.Id_PaperStuBatch == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CourseExamPaperId = '{0}'", objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId);
 sbCondition.AppendFormat(" and id_StudentInfo = '{0}'", objcc_ExamPaperStuBatchRelaEN.id_StudentInfo);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("Id_PaperStuBatch !=  '{0}'", objcc_ExamPaperStuBatchRelaEN.Id_PaperStuBatch);
 sbCondition.AppendFormat(" and CourseExamPaperId = '{0}'", objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId);
 sbCondition.AppendFormat(" and id_StudentInfo = '{0}'", objcc_ExamPaperStuBatchRelaEN.id_StudentInfo);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN)
{
 if (string.IsNullOrEmpty(objcc_ExamPaperStuBatchRelaEN.Id_PaperStuBatch) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clscc_ExamPaperStuBatchRelaWApi.IsExist(objcc_ExamPaperStuBatchRelaEN.Id_PaperStuBatch) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objcc_ExamPaperStuBatchRelaEN.Id_PaperStuBatch, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clscc_ExamPaperStuBatchRelaWApi.CheckPropertyNew(objcc_ExamPaperStuBatchRelaEN); 
bool bolResult = clscc_ExamPaperStuBatchRelaWApi.AddNewRecord(objcc_ExamPaperStuBatchRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperStuBatchRelaWApi.ReFreshCache(objcc_ExamPaperStuBatchRelaEN.id_CurrEduCls);
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
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值. 该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN)
{
try
{
clscc_ExamPaperStuBatchRelaWApi.CheckPropertyNew(objcc_ExamPaperStuBatchRelaEN); 
string strId_PaperStuBatch = clscc_ExamPaperStuBatchRelaWApi.AddNewRecordWithMaxId(objcc_ExamPaperStuBatchRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperStuBatchRelaWApi.ReFreshCache(objcc_ExamPaperStuBatchRelaEN.id_CurrEduCls);
return strId_PaperStuBatch;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000009)添加记录出错, {1}.(from {0})",
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
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, string strWhereCond)
{
try
{
clscc_ExamPaperStuBatchRelaWApi.CheckPropertyNew(objcc_ExamPaperStuBatchRelaEN); 
bool bolResult = clscc_ExamPaperStuBatchRelaWApi.UpdateWithCondition(objcc_ExamPaperStuBatchRelaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperStuBatchRelaWApi.ReFreshCache(objcc_ExamPaperStuBatchRelaEN.id_CurrEduCls);
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
 /// 考卷与学生批次关系(cc_ExamPaperStuBatchRela)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clscc_ExamPaperStuBatchRelaWApi
{
private static readonly string mstrApiControllerName = "cc_ExamPaperStuBatchRelaApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4BL = null;

 public clscc_ExamPaperStuBatchRelaWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN)
{
if (!Object.Equals(null, objcc_ExamPaperStuBatchRelaEN.Id_PaperStuBatch) && GetStrLen(objcc_ExamPaperStuBatchRelaEN.Id_PaperStuBatch) > 10)
{
 throw new Exception("字段[学生试卷批次流水号]的长度不能超过10!");
}
if (!Object.Equals(null, objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId) && GetStrLen(objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId) > 8)
{
 throw new Exception("字段[考卷流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_ExamPaperStuBatchRelaEN.id_StudentInfo) && GetStrLen(objcc_ExamPaperStuBatchRelaEN.id_StudentInfo) > 8)
{
 throw new Exception("字段[学生流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_ExamPaperStuBatchRelaEN.BatchTime) && GetStrLen(objcc_ExamPaperStuBatchRelaEN.BatchTime) > 14)
{
 throw new Exception("字段[批次]的长度不能超过14!");
}
if (!Object.Equals(null, objcc_ExamPaperStuBatchRelaEN.id_CurrEduCls) && GetStrLen(objcc_ExamPaperStuBatchRelaEN.id_CurrEduCls) > 8)
{
 throw new Exception("字段[当前教学班流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_ExamPaperStuBatchRelaEN.RealFinishDate) && GetStrLen(objcc_ExamPaperStuBatchRelaEN.RealFinishDate) > 14)
{
 throw new Exception("字段[实际完成日期]的长度不能超过14!");
}
if (!Object.Equals(null, objcc_ExamPaperStuBatchRelaEN.OperateTime) && GetStrLen(objcc_ExamPaperStuBatchRelaEN.OperateTime) > 14)
{
 throw new Exception("字段[操作时间]的长度不能超过14!");
}
if (!Object.Equals(null, objcc_ExamPaperStuBatchRelaEN.MarkerId) && GetStrLen(objcc_ExamPaperStuBatchRelaEN.MarkerId) > 20)
{
 throw new Exception("字段[打分者]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_ExamPaperStuBatchRelaEN.MarkDate) && GetStrLen(objcc_ExamPaperStuBatchRelaEN.MarkDate) > 14)
{
 throw new Exception("字段[打分日期]的长度不能超过14!");
}
if (!Object.Equals(null, objcc_ExamPaperStuBatchRelaEN.AnswerIP) && GetStrLen(objcc_ExamPaperStuBatchRelaEN.AnswerIP) > 30)
{
 throw new Exception("字段[回答IP]的长度不能超过30!");
}
if (!Object.Equals(null, objcc_ExamPaperStuBatchRelaEN.AnswerDate) && GetStrLen(objcc_ExamPaperStuBatchRelaEN.AnswerDate) > 8)
{
 throw new Exception("字段[回答日期]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_ExamPaperStuBatchRelaEN.AnswerTime) && GetStrLen(objcc_ExamPaperStuBatchRelaEN.AnswerTime) > 10)
{
 throw new Exception("字段[回答时间]的长度不能超过10!");
}
if (!Object.Equals(null, objcc_ExamPaperStuBatchRelaEN.UpdDate) && GetStrLen(objcc_ExamPaperStuBatchRelaEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_ExamPaperStuBatchRelaEN.UpdUserId) && GetStrLen(objcc_ExamPaperStuBatchRelaEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_ExamPaperStuBatchRelaEN.Memo) && GetStrLen(objcc_ExamPaperStuBatchRelaEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objcc_ExamPaperStuBatchRelaEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strId_PaperStuBatch">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_ExamPaperStuBatchRelaEN GetObjById_PaperStuBatch(string strId_PaperStuBatch)
{
string strAction = "GetObjById_PaperStuBatch";
string strErrMsg = string.Empty;
string strResult = "";
clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_PaperStuBatch"] = strId_PaperStuBatch
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objcc_ExamPaperStuBatchRelaEN = JsonConvert.DeserializeObject<clscc_ExamPaperStuBatchRelaEN>((string)jobjReturn["ReturnObj"]);
return objcc_ExamPaperStuBatchRelaEN;
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
 /// <param name = "strId_PaperStuBatch">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_ExamPaperStuBatchRelaEN GetObjById_PaperStuBatch_WA_Cache(string strId_PaperStuBatch, string strid_CurrEduCls)
{
string strAction = "GetObjById_PaperStuBatch_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_PaperStuBatch"] = strId_PaperStuBatch,
["id_CurrEduCls"] = strid_CurrEduCls
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objcc_ExamPaperStuBatchRelaEN = JsonConvert.DeserializeObject<clscc_ExamPaperStuBatchRelaEN>((string)jobjReturn["ReturnObj"]);
return objcc_ExamPaperStuBatchRelaEN;
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
public static string GetFirstID(string strWhereCond)
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
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clscc_ExamPaperStuBatchRelaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN = null;
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
objcc_ExamPaperStuBatchRelaEN = JsonConvert.DeserializeObject<clscc_ExamPaperStuBatchRelaEN>((string)jobjReturn["ReturnObj"]);
return objcc_ExamPaperStuBatchRelaEN;
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
 /// <param name = "strId_PaperStuBatch">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_ExamPaperStuBatchRelaEN GetObjById_PaperStuBatch_Cache(string strId_PaperStuBatch, string strid_CurrEduCls)
{
if (string.IsNullOrEmpty(strId_PaperStuBatch) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clscc_ExamPaperStuBatchRelaEN._CurrTabName_S, strid_CurrEduCls);
List<clscc_ExamPaperStuBatchRelaEN> arrcc_ExamPaperStuBatchRelaObjLst_Cache = GetObjLst_Cache(strid_CurrEduCls);
IEnumerable <clscc_ExamPaperStuBatchRelaEN> arrcc_ExamPaperStuBatchRelaObjLst_Sel =
from objcc_ExamPaperStuBatchRelaEN in arrcc_ExamPaperStuBatchRelaObjLst_Cache
where objcc_ExamPaperStuBatchRelaEN.Id_PaperStuBatch == strId_PaperStuBatch
select objcc_ExamPaperStuBatchRelaEN;
if (arrcc_ExamPaperStuBatchRelaObjLst_Sel.Count() == 0)
{
   clscc_ExamPaperStuBatchRelaEN obj = clscc_ExamPaperStuBatchRelaWApi.GetObjById_PaperStuBatch(strId_PaperStuBatch);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrcc_ExamPaperStuBatchRelaObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_ExamPaperStuBatchRelaEN> GetObjLst(string strWhereCond)
{
 List<clscc_ExamPaperStuBatchRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_ExamPaperStuBatchRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_ExamPaperStuBatchRelaEN> GetObjLstById_PaperStuBatchLst(List<string> arrId_PaperStuBatch)
{
 List<clscc_ExamPaperStuBatchRelaEN> arrObjLst = null; 
string strAction = "GetObjLstById_PaperStuBatchLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_PaperStuBatch);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clscc_ExamPaperStuBatchRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strId_PaperStuBatch">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clscc_ExamPaperStuBatchRelaEN> GetObjLstById_PaperStuBatchLst_Cache(List<string> arrId_PaperStuBatch, string strid_CurrEduCls)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clscc_ExamPaperStuBatchRelaEN._CurrTabName_S, strid_CurrEduCls);
List<clscc_ExamPaperStuBatchRelaEN> arrcc_ExamPaperStuBatchRelaObjLst_Cache = GetObjLst_Cache(strid_CurrEduCls);
IEnumerable <clscc_ExamPaperStuBatchRelaEN> arrcc_ExamPaperStuBatchRelaObjLst_Sel =
from objcc_ExamPaperStuBatchRelaEN in arrcc_ExamPaperStuBatchRelaObjLst_Cache
where arrId_PaperStuBatch.Contains(objcc_ExamPaperStuBatchRelaEN.Id_PaperStuBatch)
select objcc_ExamPaperStuBatchRelaEN;
return arrcc_ExamPaperStuBatchRelaObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_ExamPaperStuBatchRelaEN> GetObjLstById_PaperStuBatchLst_WA_Cache(List<string> arrId_PaperStuBatch, string strid_CurrEduCls)
{
 List<clscc_ExamPaperStuBatchRelaEN> arrObjLst = null; 
string strAction = "GetObjLstById_PaperStuBatchLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CurrEduCls"] = strid_CurrEduCls
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_PaperStuBatch);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clscc_ExamPaperStuBatchRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_ExamPaperStuBatchRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clscc_ExamPaperStuBatchRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_ExamPaperStuBatchRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_ExamPaperStuBatchRelaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clscc_ExamPaperStuBatchRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_ExamPaperStuBatchRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_ExamPaperStuBatchRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clscc_ExamPaperStuBatchRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_ExamPaperStuBatchRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_ExamPaperStuBatchRelaEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clscc_ExamPaperStuBatchRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_ExamPaperStuBatchRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(string strId_PaperStuBatch)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN = clscc_ExamPaperStuBatchRelaWApi.GetObjById_PaperStuBatch(strId_PaperStuBatch);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strId_PaperStuBatch.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clscc_ExamPaperStuBatchRelaWApi.ReFreshCache(objcc_ExamPaperStuBatchRelaEN.id_CurrEduCls);
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
public static int Delcc_ExamPaperStuBatchRelas(List<string> arrId_PaperStuBatch)
{
string strAction = "Delcc_ExamPaperStuBatchRelas";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_PaperStuBatch);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
 clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN = clscc_ExamPaperStuBatchRelaWApi.GetObjById_PaperStuBatch(arrId_PaperStuBatch[0]);
clscc_ExamPaperStuBatchRelaWApi.ReFreshCache(objcc_ExamPaperStuBatchRelaEN.id_CurrEduCls);
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
public static int Delcc_ExamPaperStuBatchRelasByCond(string strWhereCond)
{
string strAction = "Delcc_ExamPaperStuBatchRelasByCond";
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
public static bool AddNewRecord(clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_ExamPaperStuBatchRelaEN>(objcc_ExamPaperStuBatchRelaEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperStuBatchRelaWApi.ReFreshCache(objcc_ExamPaperStuBatchRelaEN.id_CurrEduCls);
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
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithMaxId)
 /// </summary>
 /// <returns>是否成功?</returns>
public static string AddNewRecordWithMaxId(clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_ExamPaperStuBatchRelaEN>(objcc_ExamPaperStuBatchRelaEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperStuBatchRelaWApi.ReFreshCache(objcc_ExamPaperStuBatchRelaEN.id_CurrEduCls);
var strId_PaperStuBatch = (string)jobjReturn["ReturnStr"];
return strId_PaperStuBatch;
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
public static bool UpdateRecord(clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN)
{
if (string.IsNullOrEmpty(objcc_ExamPaperStuBatchRelaEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_ExamPaperStuBatchRelaEN.Id_PaperStuBatch, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_ExamPaperStuBatchRelaEN>(objcc_ExamPaperStuBatchRelaEN);
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
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objcc_ExamPaperStuBatchRelaEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_ExamPaperStuBatchRelaEN.Id_PaperStuBatch, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_ExamPaperStuBatchRelaEN.Id_PaperStuBatch, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_ExamPaperStuBatchRelaEN>(objcc_ExamPaperStuBatchRelaEN);
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
public static bool IsExist(string strId_PaperStuBatch)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_PaperStuBatch"] = strId_PaperStuBatch
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
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId()
{
string strAction = "GetMaxStrId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
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
string strMsg = string.Format("获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix(string strPrefix)
{
//检测记录是否存在
string strAction = "GetMaxStrIdByPrefix";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strPrefix", strPrefix);
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
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
string strMsg = string.Format("根据前缀获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objcc_ExamPaperStuBatchRelaENS">源对象</param>
 /// <param name = "objcc_ExamPaperStuBatchRelaENT">目标对象</param>
 public static void CopyTo(clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaENS, clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaENT)
{
try
{
objcc_ExamPaperStuBatchRelaENT.Id_PaperStuBatch = objcc_ExamPaperStuBatchRelaENS.Id_PaperStuBatch; //学生试卷批次流水号
objcc_ExamPaperStuBatchRelaENT.CourseExamPaperId = objcc_ExamPaperStuBatchRelaENS.CourseExamPaperId; //考卷流水号
objcc_ExamPaperStuBatchRelaENT.id_StudentInfo = objcc_ExamPaperStuBatchRelaENS.id_StudentInfo; //学生流水号
objcc_ExamPaperStuBatchRelaENT.BatchTime = objcc_ExamPaperStuBatchRelaENS.BatchTime; //批次
objcc_ExamPaperStuBatchRelaENT.id_CurrEduCls = objcc_ExamPaperStuBatchRelaENS.id_CurrEduCls; //当前教学班流水号
objcc_ExamPaperStuBatchRelaENT.Scores = objcc_ExamPaperStuBatchRelaENS.Scores; //分值
objcc_ExamPaperStuBatchRelaENT.IsSave = objcc_ExamPaperStuBatchRelaENS.IsSave; //是否保存
objcc_ExamPaperStuBatchRelaENT.IsSubmit = objcc_ExamPaperStuBatchRelaENS.IsSubmit; //是否提交
objcc_ExamPaperStuBatchRelaENT.RealFinishDate = objcc_ExamPaperStuBatchRelaENS.RealFinishDate; //实际完成日期
objcc_ExamPaperStuBatchRelaENT.OperateTime = objcc_ExamPaperStuBatchRelaENS.OperateTime; //操作时间
objcc_ExamPaperStuBatchRelaENT.IsMarking = objcc_ExamPaperStuBatchRelaENS.IsMarking; //是否批阅
objcc_ExamPaperStuBatchRelaENT.MarkerId = objcc_ExamPaperStuBatchRelaENS.MarkerId; //打分者
objcc_ExamPaperStuBatchRelaENT.MarkDate = objcc_ExamPaperStuBatchRelaENS.MarkDate; //打分日期
objcc_ExamPaperStuBatchRelaENT.AnswerIP = objcc_ExamPaperStuBatchRelaENS.AnswerIP; //回答IP
objcc_ExamPaperStuBatchRelaENT.AnswerDate = objcc_ExamPaperStuBatchRelaENS.AnswerDate; //回答日期
objcc_ExamPaperStuBatchRelaENT.AnswerTime = objcc_ExamPaperStuBatchRelaENS.AnswerTime; //回答时间
objcc_ExamPaperStuBatchRelaENT.TotalGetScore = objcc_ExamPaperStuBatchRelaENS.TotalGetScore; //考生获取总分
objcc_ExamPaperStuBatchRelaENT.UpdDate = objcc_ExamPaperStuBatchRelaENS.UpdDate; //修改日期
objcc_ExamPaperStuBatchRelaENT.UpdUserId = objcc_ExamPaperStuBatchRelaENS.UpdUserId; //修改用户Id
objcc_ExamPaperStuBatchRelaENT.Memo = objcc_ExamPaperStuBatchRelaENS.Memo; //备注
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
public static DataTable ToDataTable(List<clscc_ExamPaperStuBatchRelaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clscc_ExamPaperStuBatchRelaEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clscc_ExamPaperStuBatchRelaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clscc_ExamPaperStuBatchRelaEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clscc_ExamPaperStuBatchRelaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clscc_ExamPaperStuBatchRelaEN.AttributeName)
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
if (clscc_ExamPaperStuBatchRelaWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExamPaperStuBatchRelaWApi没有刷新缓存机制(clscc_ExamPaperStuBatchRelaWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by Id_PaperStuBatch");
//if (arrcc_ExamPaperStuBatchRelaObjLst_Cache == null)
//{
//arrcc_ExamPaperStuBatchRelaObjLst_Cache = await clscc_ExamPaperStuBatchRelaWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}_{1}", clscc_ExamPaperStuBatchRelaEN._CurrTabName_S, strid_CurrEduCls);
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
public static void ReFreshCache(string strid_CurrEduCls)
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clscc_ExamPaperStuBatchRelaWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clscc_ExamPaperStuBatchRelaEN._CurrTabName_S, strid_CurrEduCls);
CacheHelper.Remove(strKey);
clscc_ExamPaperStuBatchRelaWApi.objCommFun4BL.ReFreshCache(strid_CurrEduCls);
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_ExamPaperStuBatchRelaEN> GetObjLst_Cache(string strid_CurrEduCls)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clscc_ExamPaperStuBatchRelaEN._CurrTabName_S, strid_CurrEduCls);
List<clscc_ExamPaperStuBatchRelaEN> arrcc_ExamPaperStuBatchRelaObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("id_CurrEduCls='{0}'", strid_CurrEduCls)); });
return arrcc_ExamPaperStuBatchRelaObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clscc_ExamPaperStuBatchRelaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(concc_ExamPaperStuBatchRela.Id_PaperStuBatch, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExamPaperStuBatchRela.CourseExamPaperId, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExamPaperStuBatchRela.id_StudentInfo, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExamPaperStuBatchRela.BatchTime, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExamPaperStuBatchRela.id_CurrEduCls, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExamPaperStuBatchRela.Scores, Type.GetType("System.Decimal"));
objDT.Columns.Add(concc_ExamPaperStuBatchRela.IsSave, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_ExamPaperStuBatchRela.IsSubmit, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_ExamPaperStuBatchRela.RealFinishDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExamPaperStuBatchRela.OperateTime, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExamPaperStuBatchRela.IsMarking, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_ExamPaperStuBatchRela.MarkerId, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExamPaperStuBatchRela.MarkDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExamPaperStuBatchRela.AnswerIP, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExamPaperStuBatchRela.AnswerDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExamPaperStuBatchRela.AnswerTime, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExamPaperStuBatchRela.TotalGetScore, Type.GetType("System.Decimal"));
objDT.Columns.Add(concc_ExamPaperStuBatchRela.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExamPaperStuBatchRela.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExamPaperStuBatchRela.Memo, Type.GetType("System.String"));
foreach (clscc_ExamPaperStuBatchRelaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[concc_ExamPaperStuBatchRela.Id_PaperStuBatch] = objInFor[concc_ExamPaperStuBatchRela.Id_PaperStuBatch];
objDR[concc_ExamPaperStuBatchRela.CourseExamPaperId] = objInFor[concc_ExamPaperStuBatchRela.CourseExamPaperId];
objDR[concc_ExamPaperStuBatchRela.id_StudentInfo] = objInFor[concc_ExamPaperStuBatchRela.id_StudentInfo];
objDR[concc_ExamPaperStuBatchRela.BatchTime] = objInFor[concc_ExamPaperStuBatchRela.BatchTime];
objDR[concc_ExamPaperStuBatchRela.id_CurrEduCls] = objInFor[concc_ExamPaperStuBatchRela.id_CurrEduCls];
objDR[concc_ExamPaperStuBatchRela.Scores] = objInFor[concc_ExamPaperStuBatchRela.Scores];
objDR[concc_ExamPaperStuBatchRela.IsSave] = objInFor[concc_ExamPaperStuBatchRela.IsSave];
objDR[concc_ExamPaperStuBatchRela.IsSubmit] = objInFor[concc_ExamPaperStuBatchRela.IsSubmit];
objDR[concc_ExamPaperStuBatchRela.RealFinishDate] = objInFor[concc_ExamPaperStuBatchRela.RealFinishDate];
objDR[concc_ExamPaperStuBatchRela.OperateTime] = objInFor[concc_ExamPaperStuBatchRela.OperateTime];
objDR[concc_ExamPaperStuBatchRela.IsMarking] = objInFor[concc_ExamPaperStuBatchRela.IsMarking];
objDR[concc_ExamPaperStuBatchRela.MarkerId] = objInFor[concc_ExamPaperStuBatchRela.MarkerId];
objDR[concc_ExamPaperStuBatchRela.MarkDate] = objInFor[concc_ExamPaperStuBatchRela.MarkDate];
objDR[concc_ExamPaperStuBatchRela.AnswerIP] = objInFor[concc_ExamPaperStuBatchRela.AnswerIP];
objDR[concc_ExamPaperStuBatchRela.AnswerDate] = objInFor[concc_ExamPaperStuBatchRela.AnswerDate];
objDR[concc_ExamPaperStuBatchRela.AnswerTime] = objInFor[concc_ExamPaperStuBatchRela.AnswerTime];
objDR[concc_ExamPaperStuBatchRela.TotalGetScore] = objInFor[concc_ExamPaperStuBatchRela.TotalGetScore];
objDR[concc_ExamPaperStuBatchRela.UpdDate] = objInFor[concc_ExamPaperStuBatchRela.UpdDate];
objDR[concc_ExamPaperStuBatchRela.UpdUserId] = objInFor[concc_ExamPaperStuBatchRela.UpdUserId];
objDR[concc_ExamPaperStuBatchRela.Memo] = objInFor[concc_ExamPaperStuBatchRela.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 考卷与学生批次关系(cc_ExamPaperStuBatchRela)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4cc_ExamPaperStuBatchRela : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strid_CurrEduCls)
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
clscc_ExamPaperStuBatchRelaWApi.ReFreshThisCache(strid_CurrEduCls);
clsvcc_ExamPaperStuBatchRelaWApi.ReFreshThisCache(strid_CurrEduCls);
clsvcc_ExamPaperStuBatchRela_JTWApi.ReFreshThisCache(strid_CurrEduCls);
}
}

}