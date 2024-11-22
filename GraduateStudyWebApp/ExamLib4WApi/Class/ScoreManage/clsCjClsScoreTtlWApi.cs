
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCjClsScoreTtlWApi
 表名:CjClsScoreTtl(01120330)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:42:20
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:成绩管理
 模块英文名:ScoreManage
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
public static class clsCjClsScoreTtlWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCjClsScoreTtlEN SetmId(this clsCjClsScoreTtlEN objCjClsScoreTtlEN, long lngmId, string strComparisonOp="")
	{
objCjClsScoreTtlEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCjClsScoreTtlEN.dicFldComparisonOp.ContainsKey(conCjClsScoreTtl.mId) == false)
{
objCjClsScoreTtlEN.dicFldComparisonOp.Add(conCjClsScoreTtl.mId, strComparisonOp);
}
else
{
objCjClsScoreTtlEN.dicFldComparisonOp[conCjClsScoreTtl.mId] = strComparisonOp;
}
}
return objCjClsScoreTtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCjClsScoreTtlEN SetExamBatchId(this clsCjClsScoreTtlEN objCjClsScoreTtlEN, string strExamBatchId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strExamBatchId, conCjClsScoreTtl.ExamBatchId);
clsCheckSql.CheckFieldLen(strExamBatchId, 12, conCjClsScoreTtl.ExamBatchId);
clsCheckSql.CheckFieldForeignKey(strExamBatchId, 12, conCjClsScoreTtl.ExamBatchId);
objCjClsScoreTtlEN.ExamBatchId = strExamBatchId; //考试批次ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCjClsScoreTtlEN.dicFldComparisonOp.ContainsKey(conCjClsScoreTtl.ExamBatchId) == false)
{
objCjClsScoreTtlEN.dicFldComparisonOp.Add(conCjClsScoreTtl.ExamBatchId, strComparisonOp);
}
else
{
objCjClsScoreTtlEN.dicFldComparisonOp[conCjClsScoreTtl.ExamBatchId] = strComparisonOp;
}
}
return objCjClsScoreTtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCjClsScoreTtlEN Setid_Course(this clsCjClsScoreTtlEN objCjClsScoreTtlEN, string strid_Course, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Course, conCjClsScoreTtl.id_Course);
clsCheckSql.CheckFieldLen(strid_Course, 8, conCjClsScoreTtl.id_Course);
clsCheckSql.CheckFieldForeignKey(strid_Course, 8, conCjClsScoreTtl.id_Course);
objCjClsScoreTtlEN.id_Course = strid_Course; //课程流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCjClsScoreTtlEN.dicFldComparisonOp.ContainsKey(conCjClsScoreTtl.id_Course) == false)
{
objCjClsScoreTtlEN.dicFldComparisonOp.Add(conCjClsScoreTtl.id_Course, strComparisonOp);
}
else
{
objCjClsScoreTtlEN.dicFldComparisonOp[conCjClsScoreTtl.id_Course] = strComparisonOp;
}
}
return objCjClsScoreTtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCjClsScoreTtlEN Setid_EduCls(this clsCjClsScoreTtlEN objCjClsScoreTtlEN, string strid_EduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_EduCls, conCjClsScoreTtl.id_EduCls);
clsCheckSql.CheckFieldLen(strid_EduCls, 8, conCjClsScoreTtl.id_EduCls);
clsCheckSql.CheckFieldForeignKey(strid_EduCls, 8, conCjClsScoreTtl.id_EduCls);
objCjClsScoreTtlEN.id_EduCls = strid_EduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCjClsScoreTtlEN.dicFldComparisonOp.ContainsKey(conCjClsScoreTtl.id_EduCls) == false)
{
objCjClsScoreTtlEN.dicFldComparisonOp.Add(conCjClsScoreTtl.id_EduCls, strComparisonOp);
}
else
{
objCjClsScoreTtlEN.dicFldComparisonOp[conCjClsScoreTtl.id_EduCls] = strComparisonOp;
}
}
return objCjClsScoreTtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCjClsScoreTtlEN Setid_AdminCls(this clsCjClsScoreTtlEN objCjClsScoreTtlEN, string strid_AdminCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_AdminCls, 8, conCjClsScoreTtl.id_AdminCls);
clsCheckSql.CheckFieldForeignKey(strid_AdminCls, 8, conCjClsScoreTtl.id_AdminCls);
objCjClsScoreTtlEN.id_AdminCls = strid_AdminCls; //行政班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCjClsScoreTtlEN.dicFldComparisonOp.ContainsKey(conCjClsScoreTtl.id_AdminCls) == false)
{
objCjClsScoreTtlEN.dicFldComparisonOp.Add(conCjClsScoreTtl.id_AdminCls, strComparisonOp);
}
else
{
objCjClsScoreTtlEN.dicFldComparisonOp[conCjClsScoreTtl.id_AdminCls] = strComparisonOp;
}
}
return objCjClsScoreTtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCjClsScoreTtlEN SetStuNum(this clsCjClsScoreTtlEN objCjClsScoreTtlEN, int intStuNum, string strComparisonOp="")
	{
objCjClsScoreTtlEN.StuNum = intStuNum; //学生数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCjClsScoreTtlEN.dicFldComparisonOp.ContainsKey(conCjClsScoreTtl.StuNum) == false)
{
objCjClsScoreTtlEN.dicFldComparisonOp.Add(conCjClsScoreTtl.StuNum, strComparisonOp);
}
else
{
objCjClsScoreTtlEN.dicFldComparisonOp[conCjClsScoreTtl.StuNum] = strComparisonOp;
}
}
return objCjClsScoreTtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCjClsScoreTtlEN SetAvgScore(this clsCjClsScoreTtlEN objCjClsScoreTtlEN, double dblAvgScore, string strComparisonOp="")
	{
objCjClsScoreTtlEN.AvgScore = dblAvgScore; //平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCjClsScoreTtlEN.dicFldComparisonOp.ContainsKey(conCjClsScoreTtl.AvgScore) == false)
{
objCjClsScoreTtlEN.dicFldComparisonOp.Add(conCjClsScoreTtl.AvgScore, strComparisonOp);
}
else
{
objCjClsScoreTtlEN.dicFldComparisonOp[conCjClsScoreTtl.AvgScore] = strComparisonOp;
}
}
return objCjClsScoreTtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCjClsScoreTtlEN SetRanking(this clsCjClsScoreTtlEN objCjClsScoreTtlEN, int intRanking, string strComparisonOp="")
	{
objCjClsScoreTtlEN.Ranking = intRanking; //名次
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCjClsScoreTtlEN.dicFldComparisonOp.ContainsKey(conCjClsScoreTtl.Ranking) == false)
{
objCjClsScoreTtlEN.dicFldComparisonOp.Add(conCjClsScoreTtl.Ranking, strComparisonOp);
}
else
{
objCjClsScoreTtlEN.dicFldComparisonOp[conCjClsScoreTtl.Ranking] = strComparisonOp;
}
}
return objCjClsScoreTtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCjClsScoreTtlEN SetPercentile(this clsCjClsScoreTtlEN objCjClsScoreTtlEN, double dblPercentile, string strComparisonOp="")
	{
objCjClsScoreTtlEN.Percentile = dblPercentile; //百分位
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCjClsScoreTtlEN.dicFldComparisonOp.ContainsKey(conCjClsScoreTtl.Percentile) == false)
{
objCjClsScoreTtlEN.dicFldComparisonOp.Add(conCjClsScoreTtl.Percentile, strComparisonOp);
}
else
{
objCjClsScoreTtlEN.dicFldComparisonOp[conCjClsScoreTtl.Percentile] = strComparisonOp;
}
}
return objCjClsScoreTtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCjClsScoreTtlEN SetExcellentRate(this clsCjClsScoreTtlEN objCjClsScoreTtlEN, double dblExcellentRate, string strComparisonOp="")
	{
objCjClsScoreTtlEN.ExcellentRate = dblExcellentRate; //优秀率
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCjClsScoreTtlEN.dicFldComparisonOp.ContainsKey(conCjClsScoreTtl.ExcellentRate) == false)
{
objCjClsScoreTtlEN.dicFldComparisonOp.Add(conCjClsScoreTtl.ExcellentRate, strComparisonOp);
}
else
{
objCjClsScoreTtlEN.dicFldComparisonOp[conCjClsScoreTtl.ExcellentRate] = strComparisonOp;
}
}
return objCjClsScoreTtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCjClsScoreTtlEN SetExcellentGoodRate(this clsCjClsScoreTtlEN objCjClsScoreTtlEN, double dblExcellentGoodRate, string strComparisonOp="")
	{
objCjClsScoreTtlEN.ExcellentGoodRate = dblExcellentGoodRate; //优良率
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCjClsScoreTtlEN.dicFldComparisonOp.ContainsKey(conCjClsScoreTtl.ExcellentGoodRate) == false)
{
objCjClsScoreTtlEN.dicFldComparisonOp.Add(conCjClsScoreTtl.ExcellentGoodRate, strComparisonOp);
}
else
{
objCjClsScoreTtlEN.dicFldComparisonOp[conCjClsScoreTtl.ExcellentGoodRate] = strComparisonOp;
}
}
return objCjClsScoreTtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCjClsScoreTtlEN SetPassingRate(this clsCjClsScoreTtlEN objCjClsScoreTtlEN, double dblPassingRate, string strComparisonOp="")
	{
objCjClsScoreTtlEN.PassingRate = dblPassingRate; //及格率
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCjClsScoreTtlEN.dicFldComparisonOp.ContainsKey(conCjClsScoreTtl.PassingRate) == false)
{
objCjClsScoreTtlEN.dicFldComparisonOp.Add(conCjClsScoreTtl.PassingRate, strComparisonOp);
}
else
{
objCjClsScoreTtlEN.dicFldComparisonOp[conCjClsScoreTtl.PassingRate] = strComparisonOp;
}
}
return objCjClsScoreTtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCjClsScoreTtlEN SetExtremeRate(this clsCjClsScoreTtlEN objCjClsScoreTtlEN, double dblExtremeRate, string strComparisonOp="")
	{
objCjClsScoreTtlEN.ExtremeRate = dblExtremeRate; //极差率
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCjClsScoreTtlEN.dicFldComparisonOp.ContainsKey(conCjClsScoreTtl.ExtremeRate) == false)
{
objCjClsScoreTtlEN.dicFldComparisonOp.Add(conCjClsScoreTtl.ExtremeRate, strComparisonOp);
}
else
{
objCjClsScoreTtlEN.dicFldComparisonOp[conCjClsScoreTtl.ExtremeRate] = strComparisonOp;
}
}
return objCjClsScoreTtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCjClsScoreTtlEN SetStandardDeviation(this clsCjClsScoreTtlEN objCjClsScoreTtlEN, double dblStandardDeviation, string strComparisonOp="")
	{
objCjClsScoreTtlEN.StandardDeviation = dblStandardDeviation; //标准差
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCjClsScoreTtlEN.dicFldComparisonOp.ContainsKey(conCjClsScoreTtl.StandardDeviation) == false)
{
objCjClsScoreTtlEN.dicFldComparisonOp.Add(conCjClsScoreTtl.StandardDeviation, strComparisonOp);
}
else
{
objCjClsScoreTtlEN.dicFldComparisonOp[conCjClsScoreTtl.StandardDeviation] = strComparisonOp;
}
}
return objCjClsScoreTtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCjClsScoreTtlEN SetFullScore(this clsCjClsScoreTtlEN objCjClsScoreTtlEN, int intFullScore, string strComparisonOp="")
	{
objCjClsScoreTtlEN.FullScore = intFullScore; //满分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCjClsScoreTtlEN.dicFldComparisonOp.ContainsKey(conCjClsScoreTtl.FullScore) == false)
{
objCjClsScoreTtlEN.dicFldComparisonOp.Add(conCjClsScoreTtl.FullScore, strComparisonOp);
}
else
{
objCjClsScoreTtlEN.dicFldComparisonOp[conCjClsScoreTtl.FullScore] = strComparisonOp;
}
}
return objCjClsScoreTtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCjClsScoreTtlEN SetSchoolYear(this clsCjClsScoreTtlEN objCjClsScoreTtlEN, string strSchoolYear, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, conCjClsScoreTtl.SchoolYear);
objCjClsScoreTtlEN.SchoolYear = strSchoolYear; //学年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCjClsScoreTtlEN.dicFldComparisonOp.ContainsKey(conCjClsScoreTtl.SchoolYear) == false)
{
objCjClsScoreTtlEN.dicFldComparisonOp.Add(conCjClsScoreTtl.SchoolYear, strComparisonOp);
}
else
{
objCjClsScoreTtlEN.dicFldComparisonOp[conCjClsScoreTtl.SchoolYear] = strComparisonOp;
}
}
return objCjClsScoreTtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCjClsScoreTtlEN SetSchoolTerm(this clsCjClsScoreTtlEN objCjClsScoreTtlEN, string strSchoolTerm, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, conCjClsScoreTtl.SchoolTerm);
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, conCjClsScoreTtl.SchoolTerm);
objCjClsScoreTtlEN.SchoolTerm = strSchoolTerm; //学期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCjClsScoreTtlEN.dicFldComparisonOp.ContainsKey(conCjClsScoreTtl.SchoolTerm) == false)
{
objCjClsScoreTtlEN.dicFldComparisonOp.Add(conCjClsScoreTtl.SchoolTerm, strComparisonOp);
}
else
{
objCjClsScoreTtlEN.dicFldComparisonOp[conCjClsScoreTtl.SchoolTerm] = strComparisonOp;
}
}
return objCjClsScoreTtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCjClsScoreTtlEN SetUpdDate(this clsCjClsScoreTtlEN objCjClsScoreTtlEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conCjClsScoreTtl.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, conCjClsScoreTtl.UpdDate);
objCjClsScoreTtlEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCjClsScoreTtlEN.dicFldComparisonOp.ContainsKey(conCjClsScoreTtl.UpdDate) == false)
{
objCjClsScoreTtlEN.dicFldComparisonOp.Add(conCjClsScoreTtl.UpdDate, strComparisonOp);
}
else
{
objCjClsScoreTtlEN.dicFldComparisonOp[conCjClsScoreTtl.UpdDate] = strComparisonOp;
}
}
return objCjClsScoreTtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCjClsScoreTtlEN SetUpdUser(this clsCjClsScoreTtlEN objCjClsScoreTtlEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conCjClsScoreTtl.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, conCjClsScoreTtl.UpdUser);
objCjClsScoreTtlEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCjClsScoreTtlEN.dicFldComparisonOp.ContainsKey(conCjClsScoreTtl.UpdUser) == false)
{
objCjClsScoreTtlEN.dicFldComparisonOp.Add(conCjClsScoreTtl.UpdUser, strComparisonOp);
}
else
{
objCjClsScoreTtlEN.dicFldComparisonOp[conCjClsScoreTtl.UpdUser] = strComparisonOp;
}
}
return objCjClsScoreTtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCjClsScoreTtlEN SetMemo(this clsCjClsScoreTtlEN objCjClsScoreTtlEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCjClsScoreTtl.Memo);
objCjClsScoreTtlEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCjClsScoreTtlEN.dicFldComparisonOp.ContainsKey(conCjClsScoreTtl.Memo) == false)
{
objCjClsScoreTtlEN.dicFldComparisonOp.Add(conCjClsScoreTtl.Memo, strComparisonOp);
}
else
{
objCjClsScoreTtlEN.dicFldComparisonOp[conCjClsScoreTtl.Memo] = strComparisonOp;
}
}
return objCjClsScoreTtlEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCjClsScoreTtlEN objCjClsScoreTtl_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCjClsScoreTtl_Cond.IsUpdated(conCjClsScoreTtl.mId) == true)
{
string strComparisonOp_mId = objCjClsScoreTtl_Cond.dicFldComparisonOp[conCjClsScoreTtl.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conCjClsScoreTtl.mId, objCjClsScoreTtl_Cond.mId, strComparisonOp_mId);
}
if (objCjClsScoreTtl_Cond.IsUpdated(conCjClsScoreTtl.ExamBatchId) == true)
{
string strComparisonOp_ExamBatchId = objCjClsScoreTtl_Cond.dicFldComparisonOp[conCjClsScoreTtl.ExamBatchId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCjClsScoreTtl.ExamBatchId, objCjClsScoreTtl_Cond.ExamBatchId, strComparisonOp_ExamBatchId);
}
if (objCjClsScoreTtl_Cond.IsUpdated(conCjClsScoreTtl.id_Course) == true)
{
string strComparisonOp_id_Course = objCjClsScoreTtl_Cond.dicFldComparisonOp[conCjClsScoreTtl.id_Course];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCjClsScoreTtl.id_Course, objCjClsScoreTtl_Cond.id_Course, strComparisonOp_id_Course);
}
if (objCjClsScoreTtl_Cond.IsUpdated(conCjClsScoreTtl.id_EduCls) == true)
{
string strComparisonOp_id_EduCls = objCjClsScoreTtl_Cond.dicFldComparisonOp[conCjClsScoreTtl.id_EduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCjClsScoreTtl.id_EduCls, objCjClsScoreTtl_Cond.id_EduCls, strComparisonOp_id_EduCls);
}
if (objCjClsScoreTtl_Cond.IsUpdated(conCjClsScoreTtl.id_AdminCls) == true)
{
string strComparisonOp_id_AdminCls = objCjClsScoreTtl_Cond.dicFldComparisonOp[conCjClsScoreTtl.id_AdminCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCjClsScoreTtl.id_AdminCls, objCjClsScoreTtl_Cond.id_AdminCls, strComparisonOp_id_AdminCls);
}
if (objCjClsScoreTtl_Cond.IsUpdated(conCjClsScoreTtl.StuNum) == true)
{
string strComparisonOp_StuNum = objCjClsScoreTtl_Cond.dicFldComparisonOp[conCjClsScoreTtl.StuNum];
strWhereCond += string.Format(" And {0} {2} {1}", conCjClsScoreTtl.StuNum, objCjClsScoreTtl_Cond.StuNum, strComparisonOp_StuNum);
}
if (objCjClsScoreTtl_Cond.IsUpdated(conCjClsScoreTtl.AvgScore) == true)
{
string strComparisonOp_AvgScore = objCjClsScoreTtl_Cond.dicFldComparisonOp[conCjClsScoreTtl.AvgScore];
strWhereCond += string.Format(" And {0} {2} {1}", conCjClsScoreTtl.AvgScore, objCjClsScoreTtl_Cond.AvgScore, strComparisonOp_AvgScore);
}
if (objCjClsScoreTtl_Cond.IsUpdated(conCjClsScoreTtl.Ranking) == true)
{
string strComparisonOp_Ranking = objCjClsScoreTtl_Cond.dicFldComparisonOp[conCjClsScoreTtl.Ranking];
strWhereCond += string.Format(" And {0} {2} {1}", conCjClsScoreTtl.Ranking, objCjClsScoreTtl_Cond.Ranking, strComparisonOp_Ranking);
}
if (objCjClsScoreTtl_Cond.IsUpdated(conCjClsScoreTtl.Percentile) == true)
{
string strComparisonOp_Percentile = objCjClsScoreTtl_Cond.dicFldComparisonOp[conCjClsScoreTtl.Percentile];
strWhereCond += string.Format(" And {0} {2} {1}", conCjClsScoreTtl.Percentile, objCjClsScoreTtl_Cond.Percentile, strComparisonOp_Percentile);
}
if (objCjClsScoreTtl_Cond.IsUpdated(conCjClsScoreTtl.ExcellentRate) == true)
{
string strComparisonOp_ExcellentRate = objCjClsScoreTtl_Cond.dicFldComparisonOp[conCjClsScoreTtl.ExcellentRate];
strWhereCond += string.Format(" And {0} {2} {1}", conCjClsScoreTtl.ExcellentRate, objCjClsScoreTtl_Cond.ExcellentRate, strComparisonOp_ExcellentRate);
}
if (objCjClsScoreTtl_Cond.IsUpdated(conCjClsScoreTtl.ExcellentGoodRate) == true)
{
string strComparisonOp_ExcellentGoodRate = objCjClsScoreTtl_Cond.dicFldComparisonOp[conCjClsScoreTtl.ExcellentGoodRate];
strWhereCond += string.Format(" And {0} {2} {1}", conCjClsScoreTtl.ExcellentGoodRate, objCjClsScoreTtl_Cond.ExcellentGoodRate, strComparisonOp_ExcellentGoodRate);
}
if (objCjClsScoreTtl_Cond.IsUpdated(conCjClsScoreTtl.PassingRate) == true)
{
string strComparisonOp_PassingRate = objCjClsScoreTtl_Cond.dicFldComparisonOp[conCjClsScoreTtl.PassingRate];
strWhereCond += string.Format(" And {0} {2} {1}", conCjClsScoreTtl.PassingRate, objCjClsScoreTtl_Cond.PassingRate, strComparisonOp_PassingRate);
}
if (objCjClsScoreTtl_Cond.IsUpdated(conCjClsScoreTtl.ExtremeRate) == true)
{
string strComparisonOp_ExtremeRate = objCjClsScoreTtl_Cond.dicFldComparisonOp[conCjClsScoreTtl.ExtremeRate];
strWhereCond += string.Format(" And {0} {2} {1}", conCjClsScoreTtl.ExtremeRate, objCjClsScoreTtl_Cond.ExtremeRate, strComparisonOp_ExtremeRate);
}
if (objCjClsScoreTtl_Cond.IsUpdated(conCjClsScoreTtl.StandardDeviation) == true)
{
string strComparisonOp_StandardDeviation = objCjClsScoreTtl_Cond.dicFldComparisonOp[conCjClsScoreTtl.StandardDeviation];
strWhereCond += string.Format(" And {0} {2} {1}", conCjClsScoreTtl.StandardDeviation, objCjClsScoreTtl_Cond.StandardDeviation, strComparisonOp_StandardDeviation);
}
if (objCjClsScoreTtl_Cond.IsUpdated(conCjClsScoreTtl.FullScore) == true)
{
string strComparisonOp_FullScore = objCjClsScoreTtl_Cond.dicFldComparisonOp[conCjClsScoreTtl.FullScore];
strWhereCond += string.Format(" And {0} {2} {1}", conCjClsScoreTtl.FullScore, objCjClsScoreTtl_Cond.FullScore, strComparisonOp_FullScore);
}
if (objCjClsScoreTtl_Cond.IsUpdated(conCjClsScoreTtl.SchoolYear) == true)
{
string strComparisonOp_SchoolYear = objCjClsScoreTtl_Cond.dicFldComparisonOp[conCjClsScoreTtl.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCjClsScoreTtl.SchoolYear, objCjClsScoreTtl_Cond.SchoolYear, strComparisonOp_SchoolYear);
}
if (objCjClsScoreTtl_Cond.IsUpdated(conCjClsScoreTtl.SchoolTerm) == true)
{
string strComparisonOp_SchoolTerm = objCjClsScoreTtl_Cond.dicFldComparisonOp[conCjClsScoreTtl.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCjClsScoreTtl.SchoolTerm, objCjClsScoreTtl_Cond.SchoolTerm, strComparisonOp_SchoolTerm);
}
if (objCjClsScoreTtl_Cond.IsUpdated(conCjClsScoreTtl.UpdDate) == true)
{
string strComparisonOp_UpdDate = objCjClsScoreTtl_Cond.dicFldComparisonOp[conCjClsScoreTtl.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCjClsScoreTtl.UpdDate, objCjClsScoreTtl_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objCjClsScoreTtl_Cond.IsUpdated(conCjClsScoreTtl.UpdUser) == true)
{
string strComparisonOp_UpdUser = objCjClsScoreTtl_Cond.dicFldComparisonOp[conCjClsScoreTtl.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCjClsScoreTtl.UpdUser, objCjClsScoreTtl_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objCjClsScoreTtl_Cond.IsUpdated(conCjClsScoreTtl.Memo) == true)
{
string strComparisonOp_Memo = objCjClsScoreTtl_Cond.dicFldComparisonOp[conCjClsScoreTtl.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCjClsScoreTtl.Memo, objCjClsScoreTtl_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCjClsScoreTtlEN objCjClsScoreTtlEN)
{
 if (objCjClsScoreTtlEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objCjClsScoreTtlEN.sf_UpdFldSetStr = objCjClsScoreTtlEN.getsf_UpdFldSetStr();
clsCjClsScoreTtlWApi.CheckPropertyNew(objCjClsScoreTtlEN); 
bool bolResult = clsCjClsScoreTtlWApi.UpdateRecord(objCjClsScoreTtlEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCjClsScoreTtlWApi.ReFreshCache();
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
 /// 检查唯一性(Uniqueness)--CjClsScoreTtl(班级成绩汇总), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_id_EduCls_ExamBatchId(this clsCjClsScoreTtlEN objCjClsScoreTtlEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCjClsScoreTtlEN == null) return "";
if (objCjClsScoreTtlEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and id_EduCls = '{0}'", objCjClsScoreTtlEN.id_EduCls);
 sbCondition.AppendFormat(" and ExamBatchId = '{0}'", objCjClsScoreTtlEN.ExamBatchId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objCjClsScoreTtlEN.mId);
 sbCondition.AppendFormat(" and id_EduCls = '{0}'", objCjClsScoreTtlEN.id_EduCls);
 sbCondition.AppendFormat(" and ExamBatchId = '{0}'", objCjClsScoreTtlEN.ExamBatchId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCjClsScoreTtlEN objCjClsScoreTtlEN)
{
try
{
clsCjClsScoreTtlWApi.CheckPropertyNew(objCjClsScoreTtlEN); 
bool bolResult = clsCjClsScoreTtlWApi.AddNewRecord(objCjClsScoreTtlEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCjClsScoreTtlWApi.ReFreshCache();
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
 /// <param name = "objCjClsScoreTtlEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCjClsScoreTtlEN objCjClsScoreTtlEN, string strWhereCond)
{
try
{
clsCjClsScoreTtlWApi.CheckPropertyNew(objCjClsScoreTtlEN); 
bool bolResult = clsCjClsScoreTtlWApi.UpdateWithCondition(objCjClsScoreTtlEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCjClsScoreTtlWApi.ReFreshCache();
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
 /// 班级成绩汇总(CjClsScoreTtl)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsCjClsScoreTtlWApi
{
private static readonly string mstrApiControllerName = "CjClsScoreTtlApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsCjClsScoreTtlWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsCjClsScoreTtlEN objCjClsScoreTtlEN)
{
if (!Object.Equals(null, objCjClsScoreTtlEN.ExamBatchId) && GetStrLen(objCjClsScoreTtlEN.ExamBatchId) > 12)
{
 throw new Exception("字段[考试批次ID]的长度不能超过12!");
}
if (!Object.Equals(null, objCjClsScoreTtlEN.id_Course) && GetStrLen(objCjClsScoreTtlEN.id_Course) > 8)
{
 throw new Exception("字段[课程流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objCjClsScoreTtlEN.id_EduCls) && GetStrLen(objCjClsScoreTtlEN.id_EduCls) > 8)
{
 throw new Exception("字段[教学班流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objCjClsScoreTtlEN.id_AdminCls) && GetStrLen(objCjClsScoreTtlEN.id_AdminCls) > 8)
{
 throw new Exception("字段[行政班流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objCjClsScoreTtlEN.SchoolYear) && GetStrLen(objCjClsScoreTtlEN.SchoolYear) > 10)
{
 throw new Exception("字段[学年]的长度不能超过10!");
}
if (!Object.Equals(null, objCjClsScoreTtlEN.SchoolTerm) && GetStrLen(objCjClsScoreTtlEN.SchoolTerm) > 1)
{
 throw new Exception("字段[学期]的长度不能超过1!");
}
if (!Object.Equals(null, objCjClsScoreTtlEN.UpdDate) && GetStrLen(objCjClsScoreTtlEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objCjClsScoreTtlEN.UpdUser) && GetStrLen(objCjClsScoreTtlEN.UpdUser) > 20)
{
 throw new Exception("字段[修改人]的长度不能超过20!");
}
if (!Object.Equals(null, objCjClsScoreTtlEN.Memo) && GetStrLen(objCjClsScoreTtlEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objCjClsScoreTtlEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCjClsScoreTtlEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clsCjClsScoreTtlEN objCjClsScoreTtlEN = null;
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
objCjClsScoreTtlEN = JsonConvert.DeserializeObject<clsCjClsScoreTtlEN>((string)jobjReturn["ReturnObj"]);
return objCjClsScoreTtlEN;
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
public static clsCjClsScoreTtlEN GetObjBymId_WA_Cache(long lngmId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsCjClsScoreTtlEN objCjClsScoreTtlEN = null;
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
objCjClsScoreTtlEN = JsonConvert.DeserializeObject<clsCjClsScoreTtlEN>((string)jobjReturn["ReturnObj"]);
return objCjClsScoreTtlEN;
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
public static clsCjClsScoreTtlEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsCjClsScoreTtlEN objCjClsScoreTtlEN = null;
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
objCjClsScoreTtlEN = JsonConvert.DeserializeObject<clsCjClsScoreTtlEN>((string)jobjReturn["ReturnObj"]);
return objCjClsScoreTtlEN;
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
public static clsCjClsScoreTtlEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsCjClsScoreTtlEN._CurrTabName_S);
List<clsCjClsScoreTtlEN> arrCjClsScoreTtlObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsCjClsScoreTtlEN> arrCjClsScoreTtlObjLst_Sel =
from objCjClsScoreTtlEN in arrCjClsScoreTtlObjLst_Cache
where objCjClsScoreTtlEN.mId == lngmId
select objCjClsScoreTtlEN;
if (arrCjClsScoreTtlObjLst_Sel.Count() == 0)
{
   clsCjClsScoreTtlEN obj = clsCjClsScoreTtlWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrCjClsScoreTtlObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCjClsScoreTtlEN> GetObjLst(string strWhereCond)
{
 List<clsCjClsScoreTtlEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCjClsScoreTtlEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCjClsScoreTtlEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsCjClsScoreTtlEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCjClsScoreTtlEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsCjClsScoreTtlEN> GetObjLstByMIdLst_Cache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsCjClsScoreTtlEN._CurrTabName_S);
List<clsCjClsScoreTtlEN> arrCjClsScoreTtlObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsCjClsScoreTtlEN> arrCjClsScoreTtlObjLst_Sel =
from objCjClsScoreTtlEN in arrCjClsScoreTtlObjLst_Cache
where arrMId.Contains(objCjClsScoreTtlEN.mId)
select objCjClsScoreTtlEN;
return arrCjClsScoreTtlObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCjClsScoreTtlEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId)
{
 List<clsCjClsScoreTtlEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCjClsScoreTtlEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCjClsScoreTtlEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsCjClsScoreTtlEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCjClsScoreTtlEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCjClsScoreTtlEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsCjClsScoreTtlEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCjClsScoreTtlEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCjClsScoreTtlEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsCjClsScoreTtlEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCjClsScoreTtlEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCjClsScoreTtlEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsCjClsScoreTtlEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCjClsScoreTtlEN>>((string)jobjReturn["ReturnObjLst"]);
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
 clsCjClsScoreTtlEN objCjClsScoreTtlEN = clsCjClsScoreTtlWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsCjClsScoreTtlWApi.ReFreshCache();
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
public static int DelCjClsScoreTtls(List<string> arrmId)
{
string strAction = "DelCjClsScoreTtls";
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
clsCjClsScoreTtlWApi.ReFreshCache();
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
public static int DelCjClsScoreTtlsByCond(string strWhereCond)
{
string strAction = "DelCjClsScoreTtlsByCond";
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
public static bool AddNewRecord(clsCjClsScoreTtlEN objCjClsScoreTtlEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCjClsScoreTtlEN>(objCjClsScoreTtlEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCjClsScoreTtlWApi.ReFreshCache();
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
 /// <param name = "objCjClsScoreTtlEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsCjClsScoreTtlEN objCjClsScoreTtlEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCjClsScoreTtlEN>(objCjClsScoreTtlEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCjClsScoreTtlWApi.ReFreshCache();
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
public static bool UpdateRecord(clsCjClsScoreTtlEN objCjClsScoreTtlEN)
{
if (string.IsNullOrEmpty(objCjClsScoreTtlEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCjClsScoreTtlEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCjClsScoreTtlEN>(objCjClsScoreTtlEN);
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
 /// <param name = "objCjClsScoreTtlEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsCjClsScoreTtlEN objCjClsScoreTtlEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objCjClsScoreTtlEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCjClsScoreTtlEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCjClsScoreTtlEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCjClsScoreTtlEN>(objCjClsScoreTtlEN);
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
 /// <param name = "objCjClsScoreTtlENS">源对象</param>
 /// <param name = "objCjClsScoreTtlENT">目标对象</param>
 public static void CopyTo(clsCjClsScoreTtlEN objCjClsScoreTtlENS, clsCjClsScoreTtlEN objCjClsScoreTtlENT)
{
try
{
objCjClsScoreTtlENT.mId = objCjClsScoreTtlENS.mId; //mId
objCjClsScoreTtlENT.ExamBatchId = objCjClsScoreTtlENS.ExamBatchId; //考试批次ID
objCjClsScoreTtlENT.id_Course = objCjClsScoreTtlENS.id_Course; //课程流水号
objCjClsScoreTtlENT.id_EduCls = objCjClsScoreTtlENS.id_EduCls; //教学班流水号
objCjClsScoreTtlENT.id_AdminCls = objCjClsScoreTtlENS.id_AdminCls; //行政班流水号
objCjClsScoreTtlENT.StuNum = objCjClsScoreTtlENS.StuNum; //学生数
objCjClsScoreTtlENT.AvgScore = objCjClsScoreTtlENS.AvgScore; //平均分
objCjClsScoreTtlENT.Ranking = objCjClsScoreTtlENS.Ranking; //名次
objCjClsScoreTtlENT.Percentile = objCjClsScoreTtlENS.Percentile; //百分位
objCjClsScoreTtlENT.ExcellentRate = objCjClsScoreTtlENS.ExcellentRate; //优秀率
objCjClsScoreTtlENT.ExcellentGoodRate = objCjClsScoreTtlENS.ExcellentGoodRate; //优良率
objCjClsScoreTtlENT.PassingRate = objCjClsScoreTtlENS.PassingRate; //及格率
objCjClsScoreTtlENT.ExtremeRate = objCjClsScoreTtlENS.ExtremeRate; //极差率
objCjClsScoreTtlENT.StandardDeviation = objCjClsScoreTtlENS.StandardDeviation; //标准差
objCjClsScoreTtlENT.FullScore = objCjClsScoreTtlENS.FullScore; //满分
objCjClsScoreTtlENT.SchoolYear = objCjClsScoreTtlENS.SchoolYear; //学年
objCjClsScoreTtlENT.SchoolTerm = objCjClsScoreTtlENS.SchoolTerm; //学期
objCjClsScoreTtlENT.UpdDate = objCjClsScoreTtlENS.UpdDate; //修改日期
objCjClsScoreTtlENT.UpdUser = objCjClsScoreTtlENS.UpdUser; //修改人
objCjClsScoreTtlENT.Memo = objCjClsScoreTtlENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsCjClsScoreTtlEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsCjClsScoreTtlEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsCjClsScoreTtlEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsCjClsScoreTtlEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsCjClsScoreTtlEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsCjClsScoreTtlEN.AttributeName)
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
if (clsCjClsScoreTtlWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCjClsScoreTtlWApi没有刷新缓存机制(clsCjClsScoreTtlWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrCjClsScoreTtlObjLst_Cache == null)
//{
//arrCjClsScoreTtlObjLst_Cache = await clsCjClsScoreTtlWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsCjClsScoreTtlEN._CurrTabName_S);
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
if (clsCjClsScoreTtlWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCjClsScoreTtlEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsCjClsScoreTtlWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCjClsScoreTtlEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsCjClsScoreTtlEN._CurrTabName_S);
List<clsCjClsScoreTtlEN> arrCjClsScoreTtlObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrCjClsScoreTtlObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsCjClsScoreTtlEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conCjClsScoreTtl.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(conCjClsScoreTtl.ExamBatchId, Type.GetType("System.String"));
objDT.Columns.Add(conCjClsScoreTtl.id_Course, Type.GetType("System.String"));
objDT.Columns.Add(conCjClsScoreTtl.id_EduCls, Type.GetType("System.String"));
objDT.Columns.Add(conCjClsScoreTtl.id_AdminCls, Type.GetType("System.String"));
objDT.Columns.Add(conCjClsScoreTtl.StuNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conCjClsScoreTtl.AvgScore, Type.GetType("System.Decimal"));
objDT.Columns.Add(conCjClsScoreTtl.Ranking, Type.GetType("System.Int32"));
objDT.Columns.Add(conCjClsScoreTtl.Percentile, Type.GetType("System.Decimal"));
objDT.Columns.Add(conCjClsScoreTtl.ExcellentRate, Type.GetType("System.Decimal"));
objDT.Columns.Add(conCjClsScoreTtl.ExcellentGoodRate, Type.GetType("System.Decimal"));
objDT.Columns.Add(conCjClsScoreTtl.PassingRate, Type.GetType("System.Decimal"));
objDT.Columns.Add(conCjClsScoreTtl.ExtremeRate, Type.GetType("System.Decimal"));
objDT.Columns.Add(conCjClsScoreTtl.StandardDeviation, Type.GetType("System.Decimal"));
objDT.Columns.Add(conCjClsScoreTtl.FullScore, Type.GetType("System.Int32"));
objDT.Columns.Add(conCjClsScoreTtl.SchoolYear, Type.GetType("System.String"));
objDT.Columns.Add(conCjClsScoreTtl.SchoolTerm, Type.GetType("System.String"));
objDT.Columns.Add(conCjClsScoreTtl.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conCjClsScoreTtl.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conCjClsScoreTtl.Memo, Type.GetType("System.String"));
foreach (clsCjClsScoreTtlEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conCjClsScoreTtl.mId] = objInFor[conCjClsScoreTtl.mId];
objDR[conCjClsScoreTtl.ExamBatchId] = objInFor[conCjClsScoreTtl.ExamBatchId];
objDR[conCjClsScoreTtl.id_Course] = objInFor[conCjClsScoreTtl.id_Course];
objDR[conCjClsScoreTtl.id_EduCls] = objInFor[conCjClsScoreTtl.id_EduCls];
objDR[conCjClsScoreTtl.id_AdminCls] = objInFor[conCjClsScoreTtl.id_AdminCls];
objDR[conCjClsScoreTtl.StuNum] = objInFor[conCjClsScoreTtl.StuNum];
objDR[conCjClsScoreTtl.AvgScore] = objInFor[conCjClsScoreTtl.AvgScore];
objDR[conCjClsScoreTtl.Ranking] = objInFor[conCjClsScoreTtl.Ranking];
objDR[conCjClsScoreTtl.Percentile] = objInFor[conCjClsScoreTtl.Percentile];
objDR[conCjClsScoreTtl.ExcellentRate] = objInFor[conCjClsScoreTtl.ExcellentRate];
objDR[conCjClsScoreTtl.ExcellentGoodRate] = objInFor[conCjClsScoreTtl.ExcellentGoodRate];
objDR[conCjClsScoreTtl.PassingRate] = objInFor[conCjClsScoreTtl.PassingRate];
objDR[conCjClsScoreTtl.ExtremeRate] = objInFor[conCjClsScoreTtl.ExtremeRate];
objDR[conCjClsScoreTtl.StandardDeviation] = objInFor[conCjClsScoreTtl.StandardDeviation];
objDR[conCjClsScoreTtl.FullScore] = objInFor[conCjClsScoreTtl.FullScore];
objDR[conCjClsScoreTtl.SchoolYear] = objInFor[conCjClsScoreTtl.SchoolYear];
objDR[conCjClsScoreTtl.SchoolTerm] = objInFor[conCjClsScoreTtl.SchoolTerm];
objDR[conCjClsScoreTtl.UpdDate] = objInFor[conCjClsScoreTtl.UpdDate];
objDR[conCjClsScoreTtl.UpdUser] = objInFor[conCjClsScoreTtl.UpdUser];
objDR[conCjClsScoreTtl.Memo] = objInFor[conCjClsScoreTtl.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 班级成绩汇总(CjClsScoreTtl)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4CjClsScoreTtl : clsCommFun4BL
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
clsCjClsScoreTtlWApi.ReFreshThisCache();
}
}

}