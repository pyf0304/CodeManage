
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCurrEduClsStuWApi
 表名:CurrEduClsStu(01120125)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:47:57
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:日常运行
 模块英文名:DailyRunning
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
public static class clsCurrEduClsStuWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStuEN Setid_EduClsStu(this clsCurrEduClsStuEN objCurrEduClsStuEN, long lngid_EduClsStu, string strComparisonOp="")
	{
objCurrEduClsStuEN.id_EduClsStu = lngid_EduClsStu; //教学班学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu.id_EduClsStu) == false)
{
objCurrEduClsStuEN.dicFldComparisonOp.Add(conCurrEduClsStu.id_EduClsStu, strComparisonOp);
}
else
{
objCurrEduClsStuEN.dicFldComparisonOp[conCurrEduClsStu.id_EduClsStu] = strComparisonOp;
}
}
return objCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStuEN Setid_CurrEduCls(this clsCurrEduClsStuEN objCurrEduClsStuEN, string strid_CurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_CurrEduCls, 8, conCurrEduClsStu.id_CurrEduCls);
clsCheckSql.CheckFieldForeignKey(strid_CurrEduCls, 8, conCurrEduClsStu.id_CurrEduCls);
objCurrEduClsStuEN.id_CurrEduCls = strid_CurrEduCls; //当前教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu.id_CurrEduCls) == false)
{
objCurrEduClsStuEN.dicFldComparisonOp.Add(conCurrEduClsStu.id_CurrEduCls, strComparisonOp);
}
else
{
objCurrEduClsStuEN.dicFldComparisonOp[conCurrEduClsStu.id_CurrEduCls] = strComparisonOp;
}
}
return objCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStuEN Setid_Stu(this clsCurrEduClsStuEN objCurrEduClsStuEN, string strid_Stu, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Stu, 8, conCurrEduClsStu.id_Stu);
clsCheckSql.CheckFieldForeignKey(strid_Stu, 8, conCurrEduClsStu.id_Stu);
objCurrEduClsStuEN.id_Stu = strid_Stu; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu.id_Stu) == false)
{
objCurrEduClsStuEN.dicFldComparisonOp.Add(conCurrEduClsStu.id_Stu, strComparisonOp);
}
else
{
objCurrEduClsStuEN.dicFldComparisonOp[conCurrEduClsStu.id_Stu] = strComparisonOp;
}
}
return objCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStuEN SetEduClsStuStateID(this clsCurrEduClsStuEN objCurrEduClsStuEN, string strEduClsStuStateID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduClsStuStateID, 2, conCurrEduClsStu.EduClsStuStateID);
clsCheckSql.CheckFieldForeignKey(strEduClsStuStateID, 2, conCurrEduClsStu.EduClsStuStateID);
objCurrEduClsStuEN.EduClsStuStateID = strEduClsStuStateID; //教学班学生状态编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu.EduClsStuStateID) == false)
{
objCurrEduClsStuEN.dicFldComparisonOp.Add(conCurrEduClsStu.EduClsStuStateID, strComparisonOp);
}
else
{
objCurrEduClsStuEN.dicFldComparisonOp[conCurrEduClsStu.EduClsStuStateID] = strComparisonOp;
}
}
return objCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStuEN SetGetScoreTimes(this clsCurrEduClsStuEN objCurrEduClsStuEN, short shtGetScoreTimes, string strComparisonOp="")
	{
objCurrEduClsStuEN.GetScoreTimes = shtGetScoreTimes; //获得成绩次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu.GetScoreTimes) == false)
{
objCurrEduClsStuEN.dicFldComparisonOp.Add(conCurrEduClsStu.GetScoreTimes, strComparisonOp);
}
else
{
objCurrEduClsStuEN.dicFldComparisonOp[conCurrEduClsStu.GetScoreTimes] = strComparisonOp;
}
}
return objCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStuEN SetScore(this clsCurrEduClsStuEN objCurrEduClsStuEN, double dblScore, string strComparisonOp="")
	{
objCurrEduClsStuEN.Score = dblScore; //得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu.Score) == false)
{
objCurrEduClsStuEN.dicFldComparisonOp.Add(conCurrEduClsStu.Score, strComparisonOp);
}
else
{
objCurrEduClsStuEN.dicFldComparisonOp[conCurrEduClsStu.Score] = strComparisonOp;
}
}
return objCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStuEN SetTotalScores(this clsCurrEduClsStuEN objCurrEduClsStuEN, double dblTotalScores, string strComparisonOp="")
	{
objCurrEduClsStuEN.TotalScores = dblTotalScores; //总分值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu.TotalScores) == false)
{
objCurrEduClsStuEN.dicFldComparisonOp.Add(conCurrEduClsStu.TotalScores, strComparisonOp);
}
else
{
objCurrEduClsStuEN.dicFldComparisonOp[conCurrEduClsStu.TotalScores] = strComparisonOp;
}
}
return objCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStuEN SetRanking(this clsCurrEduClsStuEN objCurrEduClsStuEN, int intRanking, string strComparisonOp="")
	{
objCurrEduClsStuEN.Ranking = intRanking; //名次
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu.Ranking) == false)
{
objCurrEduClsStuEN.dicFldComparisonOp.Add(conCurrEduClsStu.Ranking, strComparisonOp);
}
else
{
objCurrEduClsStuEN.dicFldComparisonOp[conCurrEduClsStu.Ranking] = strComparisonOp;
}
}
return objCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStuEN SetPercentile(this clsCurrEduClsStuEN objCurrEduClsStuEN, double dblPercentile, string strComparisonOp="")
	{
objCurrEduClsStuEN.Percentile = dblPercentile; //百分位
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu.Percentile) == false)
{
objCurrEduClsStuEN.dicFldComparisonOp.Add(conCurrEduClsStu.Percentile, strComparisonOp);
}
else
{
objCurrEduClsStuEN.dicFldComparisonOp[conCurrEduClsStu.Percentile] = strComparisonOp;
}
}
return objCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStuEN SetRanking2(this clsCurrEduClsStuEN objCurrEduClsStuEN, int intRanking2, string strComparisonOp="")
	{
objCurrEduClsStuEN.Ranking2 = intRanking2; //Ranking2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu.Ranking2) == false)
{
objCurrEduClsStuEN.dicFldComparisonOp.Add(conCurrEduClsStu.Ranking2, strComparisonOp);
}
else
{
objCurrEduClsStuEN.dicFldComparisonOp[conCurrEduClsStu.Ranking2] = strComparisonOp;
}
}
return objCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStuEN SetPercentile2(this clsCurrEduClsStuEN objCurrEduClsStuEN, double dblPercentile2, string strComparisonOp="")
	{
objCurrEduClsStuEN.Percentile2 = dblPercentile2; //Percentile2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu.Percentile2) == false)
{
objCurrEduClsStuEN.dicFldComparisonOp.Add(conCurrEduClsStu.Percentile2, strComparisonOp);
}
else
{
objCurrEduClsStuEN.dicFldComparisonOp[conCurrEduClsStu.Percentile2] = strComparisonOp;
}
}
return objCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStuEN SetRanking3(this clsCurrEduClsStuEN objCurrEduClsStuEN, int intRanking3, string strComparisonOp="")
	{
objCurrEduClsStuEN.Ranking3 = intRanking3; //Ranking3
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu.Ranking3) == false)
{
objCurrEduClsStuEN.dicFldComparisonOp.Add(conCurrEduClsStu.Ranking3, strComparisonOp);
}
else
{
objCurrEduClsStuEN.dicFldComparisonOp[conCurrEduClsStu.Ranking3] = strComparisonOp;
}
}
return objCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStuEN SetPercentile3(this clsCurrEduClsStuEN objCurrEduClsStuEN, double dblPercentile3, string strComparisonOp="")
	{
objCurrEduClsStuEN.Percentile3 = dblPercentile3; //Percentile3
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu.Percentile3) == false)
{
objCurrEduClsStuEN.dicFldComparisonOp.Add(conCurrEduClsStu.Percentile3, strComparisonOp);
}
else
{
objCurrEduClsStuEN.dicFldComparisonOp[conCurrEduClsStu.Percentile3] = strComparisonOp;
}
}
return objCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStuEN SetConfirmed(this clsCurrEduClsStuEN objCurrEduClsStuEN, bool bolConfirmed, string strComparisonOp="")
	{
objCurrEduClsStuEN.Confirmed = bolConfirmed; //是否确认
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu.Confirmed) == false)
{
objCurrEduClsStuEN.dicFldComparisonOp.Add(conCurrEduClsStu.Confirmed, strComparisonOp);
}
else
{
objCurrEduClsStuEN.dicFldComparisonOp[conCurrEduClsStu.Confirmed] = strComparisonOp;
}
}
return objCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStuEN SetSchoolTerm(this clsCurrEduClsStuEN objCurrEduClsStuEN, string strSchoolTerm, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, conCurrEduClsStu.SchoolTerm);
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, conCurrEduClsStu.SchoolTerm);
objCurrEduClsStuEN.SchoolTerm = strSchoolTerm; //学期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu.SchoolTerm) == false)
{
objCurrEduClsStuEN.dicFldComparisonOp.Add(conCurrEduClsStu.SchoolTerm, strComparisonOp);
}
else
{
objCurrEduClsStuEN.dicFldComparisonOp[conCurrEduClsStu.SchoolTerm] = strComparisonOp;
}
}
return objCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStuEN SetSchoolYear(this clsCurrEduClsStuEN objCurrEduClsStuEN, string strSchoolYear, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, conCurrEduClsStu.SchoolYear);
objCurrEduClsStuEN.SchoolYear = strSchoolYear; //学年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu.SchoolYear) == false)
{
objCurrEduClsStuEN.dicFldComparisonOp.Add(conCurrEduClsStu.SchoolYear, strComparisonOp);
}
else
{
objCurrEduClsStuEN.dicFldComparisonOp[conCurrEduClsStu.SchoolYear] = strComparisonOp;
}
}
return objCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStuEN SetExportDate(this clsCurrEduClsStuEN objCurrEduClsStuEN, string strExportDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExportDate, 8, conCurrEduClsStu.ExportDate);
objCurrEduClsStuEN.ExportDate = strExportDate; //导出日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu.ExportDate) == false)
{
objCurrEduClsStuEN.dicFldComparisonOp.Add(conCurrEduClsStu.ExportDate, strComparisonOp);
}
else
{
objCurrEduClsStuEN.dicFldComparisonOp[conCurrEduClsStu.ExportDate] = strComparisonOp;
}
}
return objCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStuEN SetSignInDate(this clsCurrEduClsStuEN objCurrEduClsStuEN, string strSignInDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSignInDate, 20, conCurrEduClsStu.SignInDate);
objCurrEduClsStuEN.SignInDate = strSignInDate; //签入时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu.SignInDate) == false)
{
objCurrEduClsStuEN.dicFldComparisonOp.Add(conCurrEduClsStu.SignInDate, strComparisonOp);
}
else
{
objCurrEduClsStuEN.dicFldComparisonOp[conCurrEduClsStu.SignInDate] = strComparisonOp;
}
}
return objCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStuEN SetSignInStateID(this clsCurrEduClsStuEN objCurrEduClsStuEN, string strSignInStateID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSignInStateID, 2, conCurrEduClsStu.SignInStateID);
clsCheckSql.CheckFieldForeignKey(strSignInStateID, 2, conCurrEduClsStu.SignInStateID);
objCurrEduClsStuEN.SignInStateID = strSignInStateID; //签入状态表流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu.SignInStateID) == false)
{
objCurrEduClsStuEN.dicFldComparisonOp.Add(conCurrEduClsStu.SignInStateID, strComparisonOp);
}
else
{
objCurrEduClsStuEN.dicFldComparisonOp[conCurrEduClsStu.SignInStateID] = strComparisonOp;
}
}
return objCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStuEN SetSignInUser(this clsCurrEduClsStuEN objCurrEduClsStuEN, string strSignInUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSignInUser, 18, conCurrEduClsStu.SignInUser);
objCurrEduClsStuEN.SignInUser = strSignInUser; //签入人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu.SignInUser) == false)
{
objCurrEduClsStuEN.dicFldComparisonOp.Add(conCurrEduClsStu.SignInUser, strComparisonOp);
}
else
{
objCurrEduClsStuEN.dicFldComparisonOp[conCurrEduClsStu.SignInUser] = strComparisonOp;
}
}
return objCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStuEN SetIsOpByTeacher(this clsCurrEduClsStuEN objCurrEduClsStuEN, bool bolIsOpByTeacher, string strComparisonOp="")
	{
objCurrEduClsStuEN.IsOpByTeacher = bolIsOpByTeacher; //是否教师操作
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu.IsOpByTeacher) == false)
{
objCurrEduClsStuEN.dicFldComparisonOp.Add(conCurrEduClsStu.IsOpByTeacher, strComparisonOp);
}
else
{
objCurrEduClsStuEN.dicFldComparisonOp[conCurrEduClsStu.IsOpByTeacher] = strComparisonOp;
}
}
return objCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStuEN SetIsSynScore(this clsCurrEduClsStuEN objCurrEduClsStuEN, bool bolIsSynScore, string strComparisonOp="")
	{
objCurrEduClsStuEN.IsSynScore = bolIsSynScore; //是否同步成绩
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu.IsSynScore) == false)
{
objCurrEduClsStuEN.dicFldComparisonOp.Add(conCurrEduClsStu.IsSynScore, strComparisonOp);
}
else
{
objCurrEduClsStuEN.dicFldComparisonOp[conCurrEduClsStu.IsSynScore] = strComparisonOp;
}
}
return objCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStuEN SetModifyDate(this clsCurrEduClsStuEN objCurrEduClsStuEN, string strModifyDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyDate, 20, conCurrEduClsStu.ModifyDate);
objCurrEduClsStuEN.ModifyDate = strModifyDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu.ModifyDate) == false)
{
objCurrEduClsStuEN.dicFldComparisonOp.Add(conCurrEduClsStu.ModifyDate, strComparisonOp);
}
else
{
objCurrEduClsStuEN.dicFldComparisonOp[conCurrEduClsStu.ModifyDate] = strComparisonOp;
}
}
return objCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStuEN SetModifyUserID(this clsCurrEduClsStuEN objCurrEduClsStuEN, string strModifyUserID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyUserID, 18, conCurrEduClsStu.ModifyUserID);
objCurrEduClsStuEN.ModifyUserID = strModifyUserID; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu.ModifyUserID) == false)
{
objCurrEduClsStuEN.dicFldComparisonOp.Add(conCurrEduClsStu.ModifyUserID, strComparisonOp);
}
else
{
objCurrEduClsStuEN.dicFldComparisonOp[conCurrEduClsStu.ModifyUserID] = strComparisonOp;
}
}
return objCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStuEN SetMemo(this clsCurrEduClsStuEN objCurrEduClsStuEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCurrEduClsStu.Memo);
objCurrEduClsStuEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu.Memo) == false)
{
objCurrEduClsStuEN.dicFldComparisonOp.Add(conCurrEduClsStu.Memo, strComparisonOp);
}
else
{
objCurrEduClsStuEN.dicFldComparisonOp[conCurrEduClsStu.Memo] = strComparisonOp;
}
}
return objCurrEduClsStuEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCurrEduClsStuEN objCurrEduClsStu_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCurrEduClsStu_Cond.IsUpdated(conCurrEduClsStu.id_EduClsStu) == true)
{
string strComparisonOp_id_EduClsStu = objCurrEduClsStu_Cond.dicFldComparisonOp[conCurrEduClsStu.id_EduClsStu];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduClsStu.id_EduClsStu, objCurrEduClsStu_Cond.id_EduClsStu, strComparisonOp_id_EduClsStu);
}
if (objCurrEduClsStu_Cond.IsUpdated(conCurrEduClsStu.id_CurrEduCls) == true)
{
string strComparisonOp_id_CurrEduCls = objCurrEduClsStu_Cond.dicFldComparisonOp[conCurrEduClsStu.id_CurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu.id_CurrEduCls, objCurrEduClsStu_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (objCurrEduClsStu_Cond.IsUpdated(conCurrEduClsStu.id_Stu) == true)
{
string strComparisonOp_id_Stu = objCurrEduClsStu_Cond.dicFldComparisonOp[conCurrEduClsStu.id_Stu];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu.id_Stu, objCurrEduClsStu_Cond.id_Stu, strComparisonOp_id_Stu);
}
if (objCurrEduClsStu_Cond.IsUpdated(conCurrEduClsStu.EduClsStuStateID) == true)
{
string strComparisonOp_EduClsStuStateID = objCurrEduClsStu_Cond.dicFldComparisonOp[conCurrEduClsStu.EduClsStuStateID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu.EduClsStuStateID, objCurrEduClsStu_Cond.EduClsStuStateID, strComparisonOp_EduClsStuStateID);
}
//数据类型short(tinyint)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objCurrEduClsStu_Cond.IsUpdated(conCurrEduClsStu.Score) == true)
{
string strComparisonOp_Score = objCurrEduClsStu_Cond.dicFldComparisonOp[conCurrEduClsStu.Score];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduClsStu.Score, objCurrEduClsStu_Cond.Score, strComparisonOp_Score);
}
if (objCurrEduClsStu_Cond.IsUpdated(conCurrEduClsStu.TotalScores) == true)
{
string strComparisonOp_TotalScores = objCurrEduClsStu_Cond.dicFldComparisonOp[conCurrEduClsStu.TotalScores];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduClsStu.TotalScores, objCurrEduClsStu_Cond.TotalScores, strComparisonOp_TotalScores);
}
if (objCurrEduClsStu_Cond.IsUpdated(conCurrEduClsStu.Ranking) == true)
{
string strComparisonOp_Ranking = objCurrEduClsStu_Cond.dicFldComparisonOp[conCurrEduClsStu.Ranking];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduClsStu.Ranking, objCurrEduClsStu_Cond.Ranking, strComparisonOp_Ranking);
}
if (objCurrEduClsStu_Cond.IsUpdated(conCurrEduClsStu.Percentile) == true)
{
string strComparisonOp_Percentile = objCurrEduClsStu_Cond.dicFldComparisonOp[conCurrEduClsStu.Percentile];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduClsStu.Percentile, objCurrEduClsStu_Cond.Percentile, strComparisonOp_Percentile);
}
if (objCurrEduClsStu_Cond.IsUpdated(conCurrEduClsStu.Ranking2) == true)
{
string strComparisonOp_Ranking2 = objCurrEduClsStu_Cond.dicFldComparisonOp[conCurrEduClsStu.Ranking2];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduClsStu.Ranking2, objCurrEduClsStu_Cond.Ranking2, strComparisonOp_Ranking2);
}
if (objCurrEduClsStu_Cond.IsUpdated(conCurrEduClsStu.Percentile2) == true)
{
string strComparisonOp_Percentile2 = objCurrEduClsStu_Cond.dicFldComparisonOp[conCurrEduClsStu.Percentile2];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduClsStu.Percentile2, objCurrEduClsStu_Cond.Percentile2, strComparisonOp_Percentile2);
}
if (objCurrEduClsStu_Cond.IsUpdated(conCurrEduClsStu.Ranking3) == true)
{
string strComparisonOp_Ranking3 = objCurrEduClsStu_Cond.dicFldComparisonOp[conCurrEduClsStu.Ranking3];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduClsStu.Ranking3, objCurrEduClsStu_Cond.Ranking3, strComparisonOp_Ranking3);
}
if (objCurrEduClsStu_Cond.IsUpdated(conCurrEduClsStu.Percentile3) == true)
{
string strComparisonOp_Percentile3 = objCurrEduClsStu_Cond.dicFldComparisonOp[conCurrEduClsStu.Percentile3];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduClsStu.Percentile3, objCurrEduClsStu_Cond.Percentile3, strComparisonOp_Percentile3);
}
if (objCurrEduClsStu_Cond.IsUpdated(conCurrEduClsStu.Confirmed) == true)
{
if (objCurrEduClsStu_Cond.Confirmed == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduClsStu.Confirmed);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduClsStu.Confirmed);
}
}
if (objCurrEduClsStu_Cond.IsUpdated(conCurrEduClsStu.SchoolTerm) == true)
{
string strComparisonOp_SchoolTerm = objCurrEduClsStu_Cond.dicFldComparisonOp[conCurrEduClsStu.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu.SchoolTerm, objCurrEduClsStu_Cond.SchoolTerm, strComparisonOp_SchoolTerm);
}
if (objCurrEduClsStu_Cond.IsUpdated(conCurrEduClsStu.SchoolYear) == true)
{
string strComparisonOp_SchoolYear = objCurrEduClsStu_Cond.dicFldComparisonOp[conCurrEduClsStu.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu.SchoolYear, objCurrEduClsStu_Cond.SchoolYear, strComparisonOp_SchoolYear);
}
if (objCurrEduClsStu_Cond.IsUpdated(conCurrEduClsStu.ExportDate) == true)
{
string strComparisonOp_ExportDate = objCurrEduClsStu_Cond.dicFldComparisonOp[conCurrEduClsStu.ExportDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu.ExportDate, objCurrEduClsStu_Cond.ExportDate, strComparisonOp_ExportDate);
}
if (objCurrEduClsStu_Cond.IsUpdated(conCurrEduClsStu.SignInDate) == true)
{
string strComparisonOp_SignInDate = objCurrEduClsStu_Cond.dicFldComparisonOp[conCurrEduClsStu.SignInDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu.SignInDate, objCurrEduClsStu_Cond.SignInDate, strComparisonOp_SignInDate);
}
if (objCurrEduClsStu_Cond.IsUpdated(conCurrEduClsStu.SignInStateID) == true)
{
string strComparisonOp_SignInStateID = objCurrEduClsStu_Cond.dicFldComparisonOp[conCurrEduClsStu.SignInStateID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu.SignInStateID, objCurrEduClsStu_Cond.SignInStateID, strComparisonOp_SignInStateID);
}
if (objCurrEduClsStu_Cond.IsUpdated(conCurrEduClsStu.SignInUser) == true)
{
string strComparisonOp_SignInUser = objCurrEduClsStu_Cond.dicFldComparisonOp[conCurrEduClsStu.SignInUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu.SignInUser, objCurrEduClsStu_Cond.SignInUser, strComparisonOp_SignInUser);
}
if (objCurrEduClsStu_Cond.IsUpdated(conCurrEduClsStu.IsOpByTeacher) == true)
{
if (objCurrEduClsStu_Cond.IsOpByTeacher == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduClsStu.IsOpByTeacher);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduClsStu.IsOpByTeacher);
}
}
if (objCurrEduClsStu_Cond.IsUpdated(conCurrEduClsStu.IsSynScore) == true)
{
if (objCurrEduClsStu_Cond.IsSynScore == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduClsStu.IsSynScore);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduClsStu.IsSynScore);
}
}
if (objCurrEduClsStu_Cond.IsUpdated(conCurrEduClsStu.ModifyDate) == true)
{
string strComparisonOp_ModifyDate = objCurrEduClsStu_Cond.dicFldComparisonOp[conCurrEduClsStu.ModifyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu.ModifyDate, objCurrEduClsStu_Cond.ModifyDate, strComparisonOp_ModifyDate);
}
if (objCurrEduClsStu_Cond.IsUpdated(conCurrEduClsStu.ModifyUserID) == true)
{
string strComparisonOp_ModifyUserID = objCurrEduClsStu_Cond.dicFldComparisonOp[conCurrEduClsStu.ModifyUserID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu.ModifyUserID, objCurrEduClsStu_Cond.ModifyUserID, strComparisonOp_ModifyUserID);
}
if (objCurrEduClsStu_Cond.IsUpdated(conCurrEduClsStu.Memo) == true)
{
string strComparisonOp_Memo = objCurrEduClsStu_Cond.dicFldComparisonOp[conCurrEduClsStu.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu.Memo, objCurrEduClsStu_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCurrEduClsStuEN objCurrEduClsStuEN)
{
 if (objCurrEduClsStuEN.id_EduClsStu == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objCurrEduClsStuEN.sf_UpdFldSetStr = objCurrEduClsStuEN.getsf_UpdFldSetStr();
clsCurrEduClsStuWApi.CheckPropertyNew(objCurrEduClsStuEN); 
bool bolResult = clsCurrEduClsStuWApi.UpdateRecord(objCurrEduClsStuEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsStuWApi.ReFreshCache(objCurrEduClsStuEN.id_CurrEduCls);
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
 /// 检查唯一性(Uniqueness)--CurrEduClsStu(教学班与学生关系), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_id_CurrEduCls_id_Stu(this clsCurrEduClsStuEN objCurrEduClsStuEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCurrEduClsStuEN == null) return "";
if (objCurrEduClsStuEN.id_EduClsStu == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and id_CurrEduCls = '{0}'", objCurrEduClsStuEN.id_CurrEduCls);
 sbCondition.AppendFormat(" and id_Stu = '{0}'", objCurrEduClsStuEN.id_Stu);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("id_EduClsStu !=  {0}", objCurrEduClsStuEN.id_EduClsStu);
 sbCondition.AppendFormat(" and id_CurrEduCls = '{0}'", objCurrEduClsStuEN.id_CurrEduCls);
 sbCondition.AppendFormat(" and id_Stu = '{0}'", objCurrEduClsStuEN.id_Stu);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCurrEduClsStuEN objCurrEduClsStuEN)
{
try
{
clsCurrEduClsStuWApi.CheckPropertyNew(objCurrEduClsStuEN); 
bool bolResult = clsCurrEduClsStuWApi.AddNewRecord(objCurrEduClsStuEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsStuWApi.ReFreshCache(objCurrEduClsStuEN.id_CurrEduCls);
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
 /// <param name = "objCurrEduClsStuEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCurrEduClsStuEN objCurrEduClsStuEN, string strWhereCond)
{
try
{
clsCurrEduClsStuWApi.CheckPropertyNew(objCurrEduClsStuEN); 
bool bolResult = clsCurrEduClsStuWApi.UpdateWithCondition(objCurrEduClsStuEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsStuWApi.ReFreshCache(objCurrEduClsStuEN.id_CurrEduCls);
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
 /// 教学班与学生关系(CurrEduClsStu)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsCurrEduClsStuWApi
{
private static readonly string mstrApiControllerName = "CurrEduClsStuApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4BL = null;

 public clsCurrEduClsStuWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsCurrEduClsStuEN objCurrEduClsStuEN)
{
if (!Object.Equals(null, objCurrEduClsStuEN.id_CurrEduCls) && GetStrLen(objCurrEduClsStuEN.id_CurrEduCls) > 8)
{
 throw new Exception("字段[当前教学班流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objCurrEduClsStuEN.id_Stu) && GetStrLen(objCurrEduClsStuEN.id_Stu) > 8)
{
 throw new Exception("字段[学生流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objCurrEduClsStuEN.EduClsStuStateID) && GetStrLen(objCurrEduClsStuEN.EduClsStuStateID) > 2)
{
 throw new Exception("字段[教学班学生状态编号]的长度不能超过2!");
}
if (!Object.Equals(null, objCurrEduClsStuEN.SchoolTerm) && GetStrLen(objCurrEduClsStuEN.SchoolTerm) > 1)
{
 throw new Exception("字段[学期]的长度不能超过1!");
}
if (!Object.Equals(null, objCurrEduClsStuEN.SchoolYear) && GetStrLen(objCurrEduClsStuEN.SchoolYear) > 10)
{
 throw new Exception("字段[学年]的长度不能超过10!");
}
if (!Object.Equals(null, objCurrEduClsStuEN.ExportDate) && GetStrLen(objCurrEduClsStuEN.ExportDate) > 8)
{
 throw new Exception("字段[导出日期]的长度不能超过8!");
}
if (!Object.Equals(null, objCurrEduClsStuEN.SignInDate) && GetStrLen(objCurrEduClsStuEN.SignInDate) > 20)
{
 throw new Exception("字段[签入时间]的长度不能超过20!");
}
if (!Object.Equals(null, objCurrEduClsStuEN.SignInStateID) && GetStrLen(objCurrEduClsStuEN.SignInStateID) > 2)
{
 throw new Exception("字段[签入状态表流水号]的长度不能超过2!");
}
if (!Object.Equals(null, objCurrEduClsStuEN.SignInUser) && GetStrLen(objCurrEduClsStuEN.SignInUser) > 18)
{
 throw new Exception("字段[签入人]的长度不能超过18!");
}
if (!Object.Equals(null, objCurrEduClsStuEN.ModifyDate) && GetStrLen(objCurrEduClsStuEN.ModifyDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objCurrEduClsStuEN.ModifyUserID) && GetStrLen(objCurrEduClsStuEN.ModifyUserID) > 18)
{
 throw new Exception("字段[修改人]的长度不能超过18!");
}
if (!Object.Equals(null, objCurrEduClsStuEN.Memo) && GetStrLen(objCurrEduClsStuEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objCurrEduClsStuEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_EduClsStu">表关键字</param>
 /// <returns>表对象</returns>
public static clsCurrEduClsStuEN GetObjByid_EduClsStu(long lngid_EduClsStu)
{
string strAction = "GetObjByid_EduClsStu";
string strErrMsg = string.Empty;
string strResult = "";
clsCurrEduClsStuEN objCurrEduClsStuEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_EduClsStu"] = lngid_EduClsStu.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objCurrEduClsStuEN = JsonConvert.DeserializeObject<clsCurrEduClsStuEN>((string)jobjReturn["ReturnObj"]);
return objCurrEduClsStuEN;
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
 /// <param name = "lngid_EduClsStu">表关键字</param>
 /// <returns>表对象</returns>
public static clsCurrEduClsStuEN GetObjByid_EduClsStu_WA_Cache(long lngid_EduClsStu, string strid_CurrEduCls)
{
string strAction = "GetObjByid_EduClsStu_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsCurrEduClsStuEN objCurrEduClsStuEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_EduClsStu"] = lngid_EduClsStu.ToString(),
["id_CurrEduCls"] = strid_CurrEduCls
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objCurrEduClsStuEN = JsonConvert.DeserializeObject<clsCurrEduClsStuEN>((string)jobjReturn["ReturnObj"]);
return objCurrEduClsStuEN;
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
public static clsCurrEduClsStuEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsCurrEduClsStuEN objCurrEduClsStuEN = null;
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
objCurrEduClsStuEN = JsonConvert.DeserializeObject<clsCurrEduClsStuEN>((string)jobjReturn["ReturnObj"]);
return objCurrEduClsStuEN;
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
 /// <param name = "lngid_EduClsStu">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCurrEduClsStuEN GetObjByid_EduClsStu_Cache(long lngid_EduClsStu, string strid_CurrEduCls)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsCurrEduClsStuEN._CurrTabName_S, strid_CurrEduCls);
List<clsCurrEduClsStuEN> arrCurrEduClsStuObjLst_Cache = GetObjLst_Cache(strid_CurrEduCls);
IEnumerable <clsCurrEduClsStuEN> arrCurrEduClsStuObjLst_Sel =
from objCurrEduClsStuEN in arrCurrEduClsStuObjLst_Cache
where objCurrEduClsStuEN.id_EduClsStu == lngid_EduClsStu
select objCurrEduClsStuEN;
if (arrCurrEduClsStuObjLst_Sel.Count() == 0)
{
   clsCurrEduClsStuEN obj = clsCurrEduClsStuWApi.GetObjByid_EduClsStu(lngid_EduClsStu);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrCurrEduClsStuObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCurrEduClsStuEN> GetObjLst(string strWhereCond)
{
 List<clsCurrEduClsStuEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCurrEduClsStuEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCurrEduClsStuEN> GetObjLstById_EduClsStuLst(List<long> arrId_EduClsStu)
{
 List<clsCurrEduClsStuEN> arrObjLst = null; 
string strAction = "GetObjLstById_EduClsStuLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_EduClsStu);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsCurrEduClsStuEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngid_EduClsStu">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsCurrEduClsStuEN> GetObjLstById_EduClsStuLst_Cache(List<long> arrId_EduClsStu, string strid_CurrEduCls)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsCurrEduClsStuEN._CurrTabName_S, strid_CurrEduCls);
List<clsCurrEduClsStuEN> arrCurrEduClsStuObjLst_Cache = GetObjLst_Cache(strid_CurrEduCls);
IEnumerable <clsCurrEduClsStuEN> arrCurrEduClsStuObjLst_Sel =
from objCurrEduClsStuEN in arrCurrEduClsStuObjLst_Cache
where arrId_EduClsStu.Contains(objCurrEduClsStuEN.id_EduClsStu)
select objCurrEduClsStuEN;
return arrCurrEduClsStuObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCurrEduClsStuEN> GetObjLstById_EduClsStuLst_WA_Cache(List<long> arrId_EduClsStu, string strid_CurrEduCls)
{
 List<clsCurrEduClsStuEN> arrObjLst = null; 
string strAction = "GetObjLstById_EduClsStuLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CurrEduCls"] = strid_CurrEduCls
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_EduClsStu);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsCurrEduClsStuEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCurrEduClsStuEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsCurrEduClsStuEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCurrEduClsStuEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCurrEduClsStuEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsCurrEduClsStuEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCurrEduClsStuEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCurrEduClsStuEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsCurrEduClsStuEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCurrEduClsStuEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCurrEduClsStuEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsCurrEduClsStuEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCurrEduClsStuEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(long lngid_EduClsStu)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsCurrEduClsStuEN objCurrEduClsStuEN = clsCurrEduClsStuWApi.GetObjByid_EduClsStu(lngid_EduClsStu);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngid_EduClsStu.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsCurrEduClsStuWApi.ReFreshCache(objCurrEduClsStuEN.id_CurrEduCls);
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
public static int DelCurrEduClsStus(List<string> arrid_EduClsStu)
{
string strAction = "DelCurrEduClsStus";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrid_EduClsStu);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
 clsCurrEduClsStuEN objCurrEduClsStuEN = clsCurrEduClsStuWApi.GetObjByid_EduClsStu(long.Parse(arrid_EduClsStu[0]));
clsCurrEduClsStuWApi.ReFreshCache(objCurrEduClsStuEN.id_CurrEduCls);
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
public static int DelCurrEduClsStusByCond(string strWhereCond)
{
string strAction = "DelCurrEduClsStusByCond";
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
public static bool AddNewRecord(clsCurrEduClsStuEN objCurrEduClsStuEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCurrEduClsStuEN>(objCurrEduClsStuEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsStuWApi.ReFreshCache(objCurrEduClsStuEN.id_CurrEduCls);
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
 /// <param name = "objCurrEduClsStuEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsCurrEduClsStuEN objCurrEduClsStuEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCurrEduClsStuEN>(objCurrEduClsStuEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsStuWApi.ReFreshCache(objCurrEduClsStuEN.id_CurrEduCls);
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
public static bool UpdateRecord(clsCurrEduClsStuEN objCurrEduClsStuEN)
{
if (string.IsNullOrEmpty(objCurrEduClsStuEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCurrEduClsStuEN.id_EduClsStu, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCurrEduClsStuEN>(objCurrEduClsStuEN);
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
 /// <param name = "objCurrEduClsStuEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsCurrEduClsStuEN objCurrEduClsStuEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objCurrEduClsStuEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCurrEduClsStuEN.id_EduClsStu, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCurrEduClsStuEN.id_EduClsStu, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCurrEduClsStuEN>(objCurrEduClsStuEN);
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
public static bool IsExist(long lngid_EduClsStu)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_EduClsStu"] = lngid_EduClsStu.ToString()
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
 /// <param name = "objCurrEduClsStuENS">源对象</param>
 /// <param name = "objCurrEduClsStuENT">目标对象</param>
 public static void CopyTo(clsCurrEduClsStuEN objCurrEduClsStuENS, clsCurrEduClsStuEN objCurrEduClsStuENT)
{
try
{
objCurrEduClsStuENT.id_EduClsStu = objCurrEduClsStuENS.id_EduClsStu; //教学班学生流水号
objCurrEduClsStuENT.id_CurrEduCls = objCurrEduClsStuENS.id_CurrEduCls; //当前教学班流水号
objCurrEduClsStuENT.id_Stu = objCurrEduClsStuENS.id_Stu; //学生流水号
objCurrEduClsStuENT.EduClsStuStateID = objCurrEduClsStuENS.EduClsStuStateID; //教学班学生状态编号
objCurrEduClsStuENT.GetScoreTimes = objCurrEduClsStuENS.GetScoreTimes; //获得成绩次数
objCurrEduClsStuENT.Score = objCurrEduClsStuENS.Score; //得分
objCurrEduClsStuENT.TotalScores = objCurrEduClsStuENS.TotalScores; //总分值
objCurrEduClsStuENT.Ranking = objCurrEduClsStuENS.Ranking; //名次
objCurrEduClsStuENT.Percentile = objCurrEduClsStuENS.Percentile; //百分位
objCurrEduClsStuENT.Ranking2 = objCurrEduClsStuENS.Ranking2; //Ranking2
objCurrEduClsStuENT.Percentile2 = objCurrEduClsStuENS.Percentile2; //Percentile2
objCurrEduClsStuENT.Ranking3 = objCurrEduClsStuENS.Ranking3; //Ranking3
objCurrEduClsStuENT.Percentile3 = objCurrEduClsStuENS.Percentile3; //Percentile3
objCurrEduClsStuENT.Confirmed = objCurrEduClsStuENS.Confirmed; //是否确认
objCurrEduClsStuENT.SchoolTerm = objCurrEduClsStuENS.SchoolTerm; //学期
objCurrEduClsStuENT.SchoolYear = objCurrEduClsStuENS.SchoolYear; //学年
objCurrEduClsStuENT.ExportDate = objCurrEduClsStuENS.ExportDate; //导出日期
objCurrEduClsStuENT.SignInDate = objCurrEduClsStuENS.SignInDate; //签入时间
objCurrEduClsStuENT.SignInStateID = objCurrEduClsStuENS.SignInStateID; //签入状态表流水号
objCurrEduClsStuENT.SignInUser = objCurrEduClsStuENS.SignInUser; //签入人
objCurrEduClsStuENT.IsOpByTeacher = objCurrEduClsStuENS.IsOpByTeacher; //是否教师操作
objCurrEduClsStuENT.IsSynScore = objCurrEduClsStuENS.IsSynScore; //是否同步成绩
objCurrEduClsStuENT.ModifyDate = objCurrEduClsStuENS.ModifyDate; //修改日期
objCurrEduClsStuENT.ModifyUserID = objCurrEduClsStuENS.ModifyUserID; //修改人
objCurrEduClsStuENT.Memo = objCurrEduClsStuENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsCurrEduClsStuEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsCurrEduClsStuEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsCurrEduClsStuEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsCurrEduClsStuEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsCurrEduClsStuEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsCurrEduClsStuEN.AttributeName)
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
if (clsCurrEduClsStuWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCurrEduClsStuWApi没有刷新缓存机制(clsCurrEduClsStuWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_EduClsStu");
//if (arrCurrEduClsStuObjLst_Cache == null)
//{
//arrCurrEduClsStuObjLst_Cache = await clsCurrEduClsStuWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}_{1}", clsCurrEduClsStuEN._CurrTabName_S, strid_CurrEduCls);
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
if (clsCurrEduClsStuWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsCurrEduClsStuEN._CurrTabName_S, strid_CurrEduCls);
CacheHelper.Remove(strKey);
clsCurrEduClsStuWApi.objCommFun4BL.ReFreshCache(strid_CurrEduCls);
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCurrEduClsStuEN> GetObjLst_Cache(string strid_CurrEduCls)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsCurrEduClsStuEN._CurrTabName_S, strid_CurrEduCls);
List<clsCurrEduClsStuEN> arrCurrEduClsStuObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("id_CurrEduCls='{0}'", strid_CurrEduCls)); });
return arrCurrEduClsStuObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsCurrEduClsStuEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conCurrEduClsStu.id_EduClsStu, Type.GetType("System.Int64"));
objDT.Columns.Add(conCurrEduClsStu.id_CurrEduCls, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduClsStu.id_Stu, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduClsStu.EduClsStuStateID, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduClsStu.GetScoreTimes, Type.GetType("System.Int16"));
objDT.Columns.Add(conCurrEduClsStu.Score, Type.GetType("System.Decimal"));
objDT.Columns.Add(conCurrEduClsStu.TotalScores, Type.GetType("System.Decimal"));
objDT.Columns.Add(conCurrEduClsStu.Ranking, Type.GetType("System.Int32"));
objDT.Columns.Add(conCurrEduClsStu.Percentile, Type.GetType("System.Decimal"));
objDT.Columns.Add(conCurrEduClsStu.Ranking2, Type.GetType("System.Int32"));
objDT.Columns.Add(conCurrEduClsStu.Percentile2, Type.GetType("System.Decimal"));
objDT.Columns.Add(conCurrEduClsStu.Ranking3, Type.GetType("System.Int32"));
objDT.Columns.Add(conCurrEduClsStu.Percentile3, Type.GetType("System.Decimal"));
objDT.Columns.Add(conCurrEduClsStu.Confirmed, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCurrEduClsStu.SchoolTerm, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduClsStu.SchoolYear, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduClsStu.ExportDate, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduClsStu.SignInDate, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduClsStu.SignInStateID, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduClsStu.SignInUser, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduClsStu.IsOpByTeacher, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCurrEduClsStu.IsSynScore, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCurrEduClsStu.ModifyDate, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduClsStu.ModifyUserID, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduClsStu.Memo, Type.GetType("System.String"));
foreach (clsCurrEduClsStuEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conCurrEduClsStu.id_EduClsStu] = objInFor[conCurrEduClsStu.id_EduClsStu];
objDR[conCurrEduClsStu.id_CurrEduCls] = objInFor[conCurrEduClsStu.id_CurrEduCls];
objDR[conCurrEduClsStu.id_Stu] = objInFor[conCurrEduClsStu.id_Stu];
objDR[conCurrEduClsStu.EduClsStuStateID] = objInFor[conCurrEduClsStu.EduClsStuStateID];
objDR[conCurrEduClsStu.GetScoreTimes] = objInFor[conCurrEduClsStu.GetScoreTimes];
objDR[conCurrEduClsStu.Score] = objInFor[conCurrEduClsStu.Score];
objDR[conCurrEduClsStu.TotalScores] = objInFor[conCurrEduClsStu.TotalScores];
objDR[conCurrEduClsStu.Ranking] = objInFor[conCurrEduClsStu.Ranking];
objDR[conCurrEduClsStu.Percentile] = objInFor[conCurrEduClsStu.Percentile];
objDR[conCurrEduClsStu.Ranking2] = objInFor[conCurrEduClsStu.Ranking2];
objDR[conCurrEduClsStu.Percentile2] = objInFor[conCurrEduClsStu.Percentile2];
objDR[conCurrEduClsStu.Ranking3] = objInFor[conCurrEduClsStu.Ranking3];
objDR[conCurrEduClsStu.Percentile3] = objInFor[conCurrEduClsStu.Percentile3];
objDR[conCurrEduClsStu.Confirmed] = objInFor[conCurrEduClsStu.Confirmed];
objDR[conCurrEduClsStu.SchoolTerm] = objInFor[conCurrEduClsStu.SchoolTerm];
objDR[conCurrEduClsStu.SchoolYear] = objInFor[conCurrEduClsStu.SchoolYear];
objDR[conCurrEduClsStu.ExportDate] = objInFor[conCurrEduClsStu.ExportDate];
objDR[conCurrEduClsStu.SignInDate] = objInFor[conCurrEduClsStu.SignInDate];
objDR[conCurrEduClsStu.SignInStateID] = objInFor[conCurrEduClsStu.SignInStateID];
objDR[conCurrEduClsStu.SignInUser] = objInFor[conCurrEduClsStu.SignInUser];
objDR[conCurrEduClsStu.IsOpByTeacher] = objInFor[conCurrEduClsStu.IsOpByTeacher];
objDR[conCurrEduClsStu.IsSynScore] = objInFor[conCurrEduClsStu.IsSynScore];
objDR[conCurrEduClsStu.ModifyDate] = objInFor[conCurrEduClsStu.ModifyDate];
objDR[conCurrEduClsStu.ModifyUserID] = objInFor[conCurrEduClsStu.ModifyUserID];
objDR[conCurrEduClsStu.Memo] = objInFor[conCurrEduClsStu.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 教学班与学生关系(CurrEduClsStu)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4CurrEduClsStu : clsCommFun4BLV2
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
clsCurrEduClsStuWApi.ReFreshThisCache(strid_CurrEduCls);
clsvCurrEduClsStuWApi.ReFreshThisCache(strid_CurrEduCls);
}
}

}