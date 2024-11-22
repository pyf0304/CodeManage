
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCurrEduClsStu4SynchWApi
 表名:CurrEduClsStu4Synch(01120359)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:39:29
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:数据同步
 模块英文名:DataSynch
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
public static class clsCurrEduClsStu4SynchWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStu4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStu4SynchEN SetmId(this clsCurrEduClsStu4SynchEN objCurrEduClsStu4SynchEN, long lngmId, string strComparisonOp="")
	{
objCurrEduClsStu4SynchEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStu4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu4Synch.mId) == false)
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp.Add(conCurrEduClsStu4Synch.mId, strComparisonOp);
}
else
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp[conCurrEduClsStu4Synch.mId] = strComparisonOp;
}
}
return objCurrEduClsStu4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStu4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStu4SynchEN SetIpAddress(this clsCurrEduClsStu4SynchEN objCurrEduClsStu4SynchEN, string strIpAddress, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIpAddress, 50, conCurrEduClsStu4Synch.IpAddress);
objCurrEduClsStu4SynchEN.IpAddress = strIpAddress; //Ip地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStu4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu4Synch.IpAddress) == false)
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp.Add(conCurrEduClsStu4Synch.IpAddress, strComparisonOp);
}
else
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp[conCurrEduClsStu4Synch.IpAddress] = strComparisonOp;
}
}
return objCurrEduClsStu4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStu4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStu4SynchEN Setid_EduClsStu(this clsCurrEduClsStu4SynchEN objCurrEduClsStu4SynchEN, long lngid_EduClsStu, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngid_EduClsStu, conCurrEduClsStu4Synch.id_EduClsStu);
objCurrEduClsStu4SynchEN.id_EduClsStu = lngid_EduClsStu; //教学班学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStu4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu4Synch.id_EduClsStu) == false)
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp.Add(conCurrEduClsStu4Synch.id_EduClsStu, strComparisonOp);
}
else
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp[conCurrEduClsStu4Synch.id_EduClsStu] = strComparisonOp;
}
}
return objCurrEduClsStu4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStu4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStu4SynchEN Setid_CurrEduCls(this clsCurrEduClsStu4SynchEN objCurrEduClsStu4SynchEN, string strid_CurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_CurrEduCls, 8, conCurrEduClsStu4Synch.id_CurrEduCls);
clsCheckSql.CheckFieldForeignKey(strid_CurrEduCls, 8, conCurrEduClsStu4Synch.id_CurrEduCls);
objCurrEduClsStu4SynchEN.id_CurrEduCls = strid_CurrEduCls; //当前教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStu4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu4Synch.id_CurrEduCls) == false)
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp.Add(conCurrEduClsStu4Synch.id_CurrEduCls, strComparisonOp);
}
else
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp[conCurrEduClsStu4Synch.id_CurrEduCls] = strComparisonOp;
}
}
return objCurrEduClsStu4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStu4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStu4SynchEN Setid_Stu(this clsCurrEduClsStu4SynchEN objCurrEduClsStu4SynchEN, string strid_Stu, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Stu, 8, conCurrEduClsStu4Synch.id_Stu);
clsCheckSql.CheckFieldForeignKey(strid_Stu, 8, conCurrEduClsStu4Synch.id_Stu);
objCurrEduClsStu4SynchEN.id_Stu = strid_Stu; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStu4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu4Synch.id_Stu) == false)
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp.Add(conCurrEduClsStu4Synch.id_Stu, strComparisonOp);
}
else
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp[conCurrEduClsStu4Synch.id_Stu] = strComparisonOp;
}
}
return objCurrEduClsStu4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStu4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStu4SynchEN SetEduClsStuStateID(this clsCurrEduClsStu4SynchEN objCurrEduClsStu4SynchEN, string strEduClsStuStateID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduClsStuStateID, 2, conCurrEduClsStu4Synch.EduClsStuStateID);
clsCheckSql.CheckFieldForeignKey(strEduClsStuStateID, 2, conCurrEduClsStu4Synch.EduClsStuStateID);
objCurrEduClsStu4SynchEN.EduClsStuStateID = strEduClsStuStateID; //教学班学生状态编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStu4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu4Synch.EduClsStuStateID) == false)
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp.Add(conCurrEduClsStu4Synch.EduClsStuStateID, strComparisonOp);
}
else
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp[conCurrEduClsStu4Synch.EduClsStuStateID] = strComparisonOp;
}
}
return objCurrEduClsStu4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStu4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStu4SynchEN SetGetScoreTimes(this clsCurrEduClsStu4SynchEN objCurrEduClsStu4SynchEN, short shtGetScoreTimes, string strComparisonOp="")
	{
objCurrEduClsStu4SynchEN.GetScoreTimes = shtGetScoreTimes; //获得成绩次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStu4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu4Synch.GetScoreTimes) == false)
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp.Add(conCurrEduClsStu4Synch.GetScoreTimes, strComparisonOp);
}
else
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp[conCurrEduClsStu4Synch.GetScoreTimes] = strComparisonOp;
}
}
return objCurrEduClsStu4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStu4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStu4SynchEN SetScore(this clsCurrEduClsStu4SynchEN objCurrEduClsStu4SynchEN, double dblScore, string strComparisonOp="")
	{
objCurrEduClsStu4SynchEN.Score = dblScore; //得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStu4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu4Synch.Score) == false)
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp.Add(conCurrEduClsStu4Synch.Score, strComparisonOp);
}
else
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp[conCurrEduClsStu4Synch.Score] = strComparisonOp;
}
}
return objCurrEduClsStu4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStu4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStu4SynchEN SetTotalScores(this clsCurrEduClsStu4SynchEN objCurrEduClsStu4SynchEN, double dblTotalScores, string strComparisonOp="")
	{
objCurrEduClsStu4SynchEN.TotalScores = dblTotalScores; //总分值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStu4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu4Synch.TotalScores) == false)
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp.Add(conCurrEduClsStu4Synch.TotalScores, strComparisonOp);
}
else
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp[conCurrEduClsStu4Synch.TotalScores] = strComparisonOp;
}
}
return objCurrEduClsStu4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStu4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStu4SynchEN SetRanking(this clsCurrEduClsStu4SynchEN objCurrEduClsStu4SynchEN, int intRanking, string strComparisonOp="")
	{
objCurrEduClsStu4SynchEN.Ranking = intRanking; //名次
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStu4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu4Synch.Ranking) == false)
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp.Add(conCurrEduClsStu4Synch.Ranking, strComparisonOp);
}
else
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp[conCurrEduClsStu4Synch.Ranking] = strComparisonOp;
}
}
return objCurrEduClsStu4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStu4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStu4SynchEN SetPercentile(this clsCurrEduClsStu4SynchEN objCurrEduClsStu4SynchEN, double dblPercentile, string strComparisonOp="")
	{
objCurrEduClsStu4SynchEN.Percentile = dblPercentile; //百分位
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStu4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu4Synch.Percentile) == false)
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp.Add(conCurrEduClsStu4Synch.Percentile, strComparisonOp);
}
else
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp[conCurrEduClsStu4Synch.Percentile] = strComparisonOp;
}
}
return objCurrEduClsStu4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStu4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStu4SynchEN SetRanking2(this clsCurrEduClsStu4SynchEN objCurrEduClsStu4SynchEN, int intRanking2, string strComparisonOp="")
	{
objCurrEduClsStu4SynchEN.Ranking2 = intRanking2; //Ranking2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStu4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu4Synch.Ranking2) == false)
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp.Add(conCurrEduClsStu4Synch.Ranking2, strComparisonOp);
}
else
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp[conCurrEduClsStu4Synch.Ranking2] = strComparisonOp;
}
}
return objCurrEduClsStu4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStu4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStu4SynchEN SetPercentile2(this clsCurrEduClsStu4SynchEN objCurrEduClsStu4SynchEN, double dblPercentile2, string strComparisonOp="")
	{
objCurrEduClsStu4SynchEN.Percentile2 = dblPercentile2; //Percentile2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStu4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu4Synch.Percentile2) == false)
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp.Add(conCurrEduClsStu4Synch.Percentile2, strComparisonOp);
}
else
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp[conCurrEduClsStu4Synch.Percentile2] = strComparisonOp;
}
}
return objCurrEduClsStu4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStu4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStu4SynchEN SetRanking3(this clsCurrEduClsStu4SynchEN objCurrEduClsStu4SynchEN, int intRanking3, string strComparisonOp="")
	{
objCurrEduClsStu4SynchEN.Ranking3 = intRanking3; //Ranking3
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStu4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu4Synch.Ranking3) == false)
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp.Add(conCurrEduClsStu4Synch.Ranking3, strComparisonOp);
}
else
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp[conCurrEduClsStu4Synch.Ranking3] = strComparisonOp;
}
}
return objCurrEduClsStu4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStu4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStu4SynchEN SetPercentile3(this clsCurrEduClsStu4SynchEN objCurrEduClsStu4SynchEN, double dblPercentile3, string strComparisonOp="")
	{
objCurrEduClsStu4SynchEN.Percentile3 = dblPercentile3; //Percentile3
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStu4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu4Synch.Percentile3) == false)
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp.Add(conCurrEduClsStu4Synch.Percentile3, strComparisonOp);
}
else
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp[conCurrEduClsStu4Synch.Percentile3] = strComparisonOp;
}
}
return objCurrEduClsStu4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStu4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStu4SynchEN SetConfirmed(this clsCurrEduClsStu4SynchEN objCurrEduClsStu4SynchEN, bool bolConfirmed, string strComparisonOp="")
	{
objCurrEduClsStu4SynchEN.Confirmed = bolConfirmed; //是否确认
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStu4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu4Synch.Confirmed) == false)
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp.Add(conCurrEduClsStu4Synch.Confirmed, strComparisonOp);
}
else
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp[conCurrEduClsStu4Synch.Confirmed] = strComparisonOp;
}
}
return objCurrEduClsStu4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStu4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStu4SynchEN SetSchoolTerm(this clsCurrEduClsStu4SynchEN objCurrEduClsStu4SynchEN, string strSchoolTerm, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, conCurrEduClsStu4Synch.SchoolTerm);
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, conCurrEduClsStu4Synch.SchoolTerm);
objCurrEduClsStu4SynchEN.SchoolTerm = strSchoolTerm; //学期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStu4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu4Synch.SchoolTerm) == false)
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp.Add(conCurrEduClsStu4Synch.SchoolTerm, strComparisonOp);
}
else
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp[conCurrEduClsStu4Synch.SchoolTerm] = strComparisonOp;
}
}
return objCurrEduClsStu4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStu4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStu4SynchEN SetSchoolYear(this clsCurrEduClsStu4SynchEN objCurrEduClsStu4SynchEN, string strSchoolYear, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, conCurrEduClsStu4Synch.SchoolYear);
objCurrEduClsStu4SynchEN.SchoolYear = strSchoolYear; //学年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStu4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu4Synch.SchoolYear) == false)
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp.Add(conCurrEduClsStu4Synch.SchoolYear, strComparisonOp);
}
else
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp[conCurrEduClsStu4Synch.SchoolYear] = strComparisonOp;
}
}
return objCurrEduClsStu4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStu4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStu4SynchEN SetExportDate(this clsCurrEduClsStu4SynchEN objCurrEduClsStu4SynchEN, string strExportDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExportDate, 8, conCurrEduClsStu4Synch.ExportDate);
objCurrEduClsStu4SynchEN.ExportDate = strExportDate; //导出日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStu4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu4Synch.ExportDate) == false)
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp.Add(conCurrEduClsStu4Synch.ExportDate, strComparisonOp);
}
else
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp[conCurrEduClsStu4Synch.ExportDate] = strComparisonOp;
}
}
return objCurrEduClsStu4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStu4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStu4SynchEN SetSignInDate(this clsCurrEduClsStu4SynchEN objCurrEduClsStu4SynchEN, string strSignInDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSignInDate, 20, conCurrEduClsStu4Synch.SignInDate);
objCurrEduClsStu4SynchEN.SignInDate = strSignInDate; //签入时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStu4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu4Synch.SignInDate) == false)
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp.Add(conCurrEduClsStu4Synch.SignInDate, strComparisonOp);
}
else
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp[conCurrEduClsStu4Synch.SignInDate] = strComparisonOp;
}
}
return objCurrEduClsStu4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStu4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStu4SynchEN SetSignInStateID(this clsCurrEduClsStu4SynchEN objCurrEduClsStu4SynchEN, string strSignInStateID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSignInStateID, 2, conCurrEduClsStu4Synch.SignInStateID);
clsCheckSql.CheckFieldForeignKey(strSignInStateID, 2, conCurrEduClsStu4Synch.SignInStateID);
objCurrEduClsStu4SynchEN.SignInStateID = strSignInStateID; //签入状态表流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStu4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu4Synch.SignInStateID) == false)
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp.Add(conCurrEduClsStu4Synch.SignInStateID, strComparisonOp);
}
else
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp[conCurrEduClsStu4Synch.SignInStateID] = strComparisonOp;
}
}
return objCurrEduClsStu4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStu4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStu4SynchEN SetSignInUser(this clsCurrEduClsStu4SynchEN objCurrEduClsStu4SynchEN, string strSignInUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSignInUser, 18, conCurrEduClsStu4Synch.SignInUser);
objCurrEduClsStu4SynchEN.SignInUser = strSignInUser; //签入人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStu4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu4Synch.SignInUser) == false)
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp.Add(conCurrEduClsStu4Synch.SignInUser, strComparisonOp);
}
else
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp[conCurrEduClsStu4Synch.SignInUser] = strComparisonOp;
}
}
return objCurrEduClsStu4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStu4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStu4SynchEN SetIsOpByTeacher(this clsCurrEduClsStu4SynchEN objCurrEduClsStu4SynchEN, bool bolIsOpByTeacher, string strComparisonOp="")
	{
objCurrEduClsStu4SynchEN.IsOpByTeacher = bolIsOpByTeacher; //是否教师操作
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStu4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu4Synch.IsOpByTeacher) == false)
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp.Add(conCurrEduClsStu4Synch.IsOpByTeacher, strComparisonOp);
}
else
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp[conCurrEduClsStu4Synch.IsOpByTeacher] = strComparisonOp;
}
}
return objCurrEduClsStu4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStu4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStu4SynchEN SetIsSynScore(this clsCurrEduClsStu4SynchEN objCurrEduClsStu4SynchEN, bool bolIsSynScore, string strComparisonOp="")
	{
objCurrEduClsStu4SynchEN.IsSynScore = bolIsSynScore; //是否同步成绩
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStu4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu4Synch.IsSynScore) == false)
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp.Add(conCurrEduClsStu4Synch.IsSynScore, strComparisonOp);
}
else
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp[conCurrEduClsStu4Synch.IsSynScore] = strComparisonOp;
}
}
return objCurrEduClsStu4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStu4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStu4SynchEN SetIsAccessSynch(this clsCurrEduClsStu4SynchEN objCurrEduClsStu4SynchEN, bool bolIsAccessSynch, string strComparisonOp="")
	{
objCurrEduClsStu4SynchEN.IsAccessSynch = bolIsAccessSynch; //是否处理同步
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStu4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu4Synch.IsAccessSynch) == false)
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp.Add(conCurrEduClsStu4Synch.IsAccessSynch, strComparisonOp);
}
else
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp[conCurrEduClsStu4Synch.IsAccessSynch] = strComparisonOp;
}
}
return objCurrEduClsStu4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStu4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStu4SynchEN SetAccessSynchDate(this clsCurrEduClsStu4SynchEN objCurrEduClsStu4SynchEN, string strAccessSynchDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAccessSynchDate, 14, conCurrEduClsStu4Synch.AccessSynchDate);
objCurrEduClsStu4SynchEN.AccessSynchDate = strAccessSynchDate; //处理同步日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStu4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu4Synch.AccessSynchDate) == false)
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp.Add(conCurrEduClsStu4Synch.AccessSynchDate, strComparisonOp);
}
else
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp[conCurrEduClsStu4Synch.AccessSynchDate] = strComparisonOp;
}
}
return objCurrEduClsStu4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStu4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStu4SynchEN SetModifyDate(this clsCurrEduClsStu4SynchEN objCurrEduClsStu4SynchEN, string strModifyDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyDate, 20, conCurrEduClsStu4Synch.ModifyDate);
objCurrEduClsStu4SynchEN.ModifyDate = strModifyDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStu4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu4Synch.ModifyDate) == false)
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp.Add(conCurrEduClsStu4Synch.ModifyDate, strComparisonOp);
}
else
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp[conCurrEduClsStu4Synch.ModifyDate] = strComparisonOp;
}
}
return objCurrEduClsStu4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStu4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStu4SynchEN SetModifyUserID(this clsCurrEduClsStu4SynchEN objCurrEduClsStu4SynchEN, string strModifyUserID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyUserID, 18, conCurrEduClsStu4Synch.ModifyUserID);
objCurrEduClsStu4SynchEN.ModifyUserID = strModifyUserID; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStu4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu4Synch.ModifyUserID) == false)
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp.Add(conCurrEduClsStu4Synch.ModifyUserID, strComparisonOp);
}
else
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp[conCurrEduClsStu4Synch.ModifyUserID] = strComparisonOp;
}
}
return objCurrEduClsStu4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStu4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStu4SynchEN SetMemo(this clsCurrEduClsStu4SynchEN objCurrEduClsStu4SynchEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCurrEduClsStu4Synch.Memo);
objCurrEduClsStu4SynchEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStu4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu4Synch.Memo) == false)
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp.Add(conCurrEduClsStu4Synch.Memo, strComparisonOp);
}
else
{
objCurrEduClsStu4SynchEN.dicFldComparisonOp[conCurrEduClsStu4Synch.Memo] = strComparisonOp;
}
}
return objCurrEduClsStu4SynchEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCurrEduClsStu4SynchEN objCurrEduClsStu4Synch_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCurrEduClsStu4Synch_Cond.IsUpdated(conCurrEduClsStu4Synch.mId) == true)
{
string strComparisonOp_mId = objCurrEduClsStu4Synch_Cond.dicFldComparisonOp[conCurrEduClsStu4Synch.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduClsStu4Synch.mId, objCurrEduClsStu4Synch_Cond.mId, strComparisonOp_mId);
}
if (objCurrEduClsStu4Synch_Cond.IsUpdated(conCurrEduClsStu4Synch.IpAddress) == true)
{
string strComparisonOp_IpAddress = objCurrEduClsStu4Synch_Cond.dicFldComparisonOp[conCurrEduClsStu4Synch.IpAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu4Synch.IpAddress, objCurrEduClsStu4Synch_Cond.IpAddress, strComparisonOp_IpAddress);
}
if (objCurrEduClsStu4Synch_Cond.IsUpdated(conCurrEduClsStu4Synch.id_EduClsStu) == true)
{
string strComparisonOp_id_EduClsStu = objCurrEduClsStu4Synch_Cond.dicFldComparisonOp[conCurrEduClsStu4Synch.id_EduClsStu];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduClsStu4Synch.id_EduClsStu, objCurrEduClsStu4Synch_Cond.id_EduClsStu, strComparisonOp_id_EduClsStu);
}
if (objCurrEduClsStu4Synch_Cond.IsUpdated(conCurrEduClsStu4Synch.id_CurrEduCls) == true)
{
string strComparisonOp_id_CurrEduCls = objCurrEduClsStu4Synch_Cond.dicFldComparisonOp[conCurrEduClsStu4Synch.id_CurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu4Synch.id_CurrEduCls, objCurrEduClsStu4Synch_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (objCurrEduClsStu4Synch_Cond.IsUpdated(conCurrEduClsStu4Synch.id_Stu) == true)
{
string strComparisonOp_id_Stu = objCurrEduClsStu4Synch_Cond.dicFldComparisonOp[conCurrEduClsStu4Synch.id_Stu];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu4Synch.id_Stu, objCurrEduClsStu4Synch_Cond.id_Stu, strComparisonOp_id_Stu);
}
if (objCurrEduClsStu4Synch_Cond.IsUpdated(conCurrEduClsStu4Synch.EduClsStuStateID) == true)
{
string strComparisonOp_EduClsStuStateID = objCurrEduClsStu4Synch_Cond.dicFldComparisonOp[conCurrEduClsStu4Synch.EduClsStuStateID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu4Synch.EduClsStuStateID, objCurrEduClsStu4Synch_Cond.EduClsStuStateID, strComparisonOp_EduClsStuStateID);
}
//数据类型short(tinyint)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objCurrEduClsStu4Synch_Cond.IsUpdated(conCurrEduClsStu4Synch.Score) == true)
{
string strComparisonOp_Score = objCurrEduClsStu4Synch_Cond.dicFldComparisonOp[conCurrEduClsStu4Synch.Score];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduClsStu4Synch.Score, objCurrEduClsStu4Synch_Cond.Score, strComparisonOp_Score);
}
if (objCurrEduClsStu4Synch_Cond.IsUpdated(conCurrEduClsStu4Synch.TotalScores) == true)
{
string strComparisonOp_TotalScores = objCurrEduClsStu4Synch_Cond.dicFldComparisonOp[conCurrEduClsStu4Synch.TotalScores];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduClsStu4Synch.TotalScores, objCurrEduClsStu4Synch_Cond.TotalScores, strComparisonOp_TotalScores);
}
if (objCurrEduClsStu4Synch_Cond.IsUpdated(conCurrEduClsStu4Synch.Ranking) == true)
{
string strComparisonOp_Ranking = objCurrEduClsStu4Synch_Cond.dicFldComparisonOp[conCurrEduClsStu4Synch.Ranking];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduClsStu4Synch.Ranking, objCurrEduClsStu4Synch_Cond.Ranking, strComparisonOp_Ranking);
}
if (objCurrEduClsStu4Synch_Cond.IsUpdated(conCurrEduClsStu4Synch.Percentile) == true)
{
string strComparisonOp_Percentile = objCurrEduClsStu4Synch_Cond.dicFldComparisonOp[conCurrEduClsStu4Synch.Percentile];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduClsStu4Synch.Percentile, objCurrEduClsStu4Synch_Cond.Percentile, strComparisonOp_Percentile);
}
if (objCurrEduClsStu4Synch_Cond.IsUpdated(conCurrEduClsStu4Synch.Ranking2) == true)
{
string strComparisonOp_Ranking2 = objCurrEduClsStu4Synch_Cond.dicFldComparisonOp[conCurrEduClsStu4Synch.Ranking2];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduClsStu4Synch.Ranking2, objCurrEduClsStu4Synch_Cond.Ranking2, strComparisonOp_Ranking2);
}
if (objCurrEduClsStu4Synch_Cond.IsUpdated(conCurrEduClsStu4Synch.Percentile2) == true)
{
string strComparisonOp_Percentile2 = objCurrEduClsStu4Synch_Cond.dicFldComparisonOp[conCurrEduClsStu4Synch.Percentile2];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduClsStu4Synch.Percentile2, objCurrEduClsStu4Synch_Cond.Percentile2, strComparisonOp_Percentile2);
}
if (objCurrEduClsStu4Synch_Cond.IsUpdated(conCurrEduClsStu4Synch.Ranking3) == true)
{
string strComparisonOp_Ranking3 = objCurrEduClsStu4Synch_Cond.dicFldComparisonOp[conCurrEduClsStu4Synch.Ranking3];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduClsStu4Synch.Ranking3, objCurrEduClsStu4Synch_Cond.Ranking3, strComparisonOp_Ranking3);
}
if (objCurrEduClsStu4Synch_Cond.IsUpdated(conCurrEduClsStu4Synch.Percentile3) == true)
{
string strComparisonOp_Percentile3 = objCurrEduClsStu4Synch_Cond.dicFldComparisonOp[conCurrEduClsStu4Synch.Percentile3];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduClsStu4Synch.Percentile3, objCurrEduClsStu4Synch_Cond.Percentile3, strComparisonOp_Percentile3);
}
if (objCurrEduClsStu4Synch_Cond.IsUpdated(conCurrEduClsStu4Synch.Confirmed) == true)
{
if (objCurrEduClsStu4Synch_Cond.Confirmed == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduClsStu4Synch.Confirmed);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduClsStu4Synch.Confirmed);
}
}
if (objCurrEduClsStu4Synch_Cond.IsUpdated(conCurrEduClsStu4Synch.SchoolTerm) == true)
{
string strComparisonOp_SchoolTerm = objCurrEduClsStu4Synch_Cond.dicFldComparisonOp[conCurrEduClsStu4Synch.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu4Synch.SchoolTerm, objCurrEduClsStu4Synch_Cond.SchoolTerm, strComparisonOp_SchoolTerm);
}
if (objCurrEduClsStu4Synch_Cond.IsUpdated(conCurrEduClsStu4Synch.SchoolYear) == true)
{
string strComparisonOp_SchoolYear = objCurrEduClsStu4Synch_Cond.dicFldComparisonOp[conCurrEduClsStu4Synch.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu4Synch.SchoolYear, objCurrEduClsStu4Synch_Cond.SchoolYear, strComparisonOp_SchoolYear);
}
if (objCurrEduClsStu4Synch_Cond.IsUpdated(conCurrEduClsStu4Synch.ExportDate) == true)
{
string strComparisonOp_ExportDate = objCurrEduClsStu4Synch_Cond.dicFldComparisonOp[conCurrEduClsStu4Synch.ExportDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu4Synch.ExportDate, objCurrEduClsStu4Synch_Cond.ExportDate, strComparisonOp_ExportDate);
}
if (objCurrEduClsStu4Synch_Cond.IsUpdated(conCurrEduClsStu4Synch.SignInDate) == true)
{
string strComparisonOp_SignInDate = objCurrEduClsStu4Synch_Cond.dicFldComparisonOp[conCurrEduClsStu4Synch.SignInDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu4Synch.SignInDate, objCurrEduClsStu4Synch_Cond.SignInDate, strComparisonOp_SignInDate);
}
if (objCurrEduClsStu4Synch_Cond.IsUpdated(conCurrEduClsStu4Synch.SignInStateID) == true)
{
string strComparisonOp_SignInStateID = objCurrEduClsStu4Synch_Cond.dicFldComparisonOp[conCurrEduClsStu4Synch.SignInStateID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu4Synch.SignInStateID, objCurrEduClsStu4Synch_Cond.SignInStateID, strComparisonOp_SignInStateID);
}
if (objCurrEduClsStu4Synch_Cond.IsUpdated(conCurrEduClsStu4Synch.SignInUser) == true)
{
string strComparisonOp_SignInUser = objCurrEduClsStu4Synch_Cond.dicFldComparisonOp[conCurrEduClsStu4Synch.SignInUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu4Synch.SignInUser, objCurrEduClsStu4Synch_Cond.SignInUser, strComparisonOp_SignInUser);
}
if (objCurrEduClsStu4Synch_Cond.IsUpdated(conCurrEduClsStu4Synch.IsOpByTeacher) == true)
{
if (objCurrEduClsStu4Synch_Cond.IsOpByTeacher == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduClsStu4Synch.IsOpByTeacher);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduClsStu4Synch.IsOpByTeacher);
}
}
if (objCurrEduClsStu4Synch_Cond.IsUpdated(conCurrEduClsStu4Synch.IsSynScore) == true)
{
if (objCurrEduClsStu4Synch_Cond.IsSynScore == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduClsStu4Synch.IsSynScore);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduClsStu4Synch.IsSynScore);
}
}
if (objCurrEduClsStu4Synch_Cond.IsUpdated(conCurrEduClsStu4Synch.IsAccessSynch) == true)
{
if (objCurrEduClsStu4Synch_Cond.IsAccessSynch == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduClsStu4Synch.IsAccessSynch);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduClsStu4Synch.IsAccessSynch);
}
}
if (objCurrEduClsStu4Synch_Cond.IsUpdated(conCurrEduClsStu4Synch.AccessSynchDate) == true)
{
string strComparisonOp_AccessSynchDate = objCurrEduClsStu4Synch_Cond.dicFldComparisonOp[conCurrEduClsStu4Synch.AccessSynchDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu4Synch.AccessSynchDate, objCurrEduClsStu4Synch_Cond.AccessSynchDate, strComparisonOp_AccessSynchDate);
}
if (objCurrEduClsStu4Synch_Cond.IsUpdated(conCurrEduClsStu4Synch.ModifyDate) == true)
{
string strComparisonOp_ModifyDate = objCurrEduClsStu4Synch_Cond.dicFldComparisonOp[conCurrEduClsStu4Synch.ModifyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu4Synch.ModifyDate, objCurrEduClsStu4Synch_Cond.ModifyDate, strComparisonOp_ModifyDate);
}
if (objCurrEduClsStu4Synch_Cond.IsUpdated(conCurrEduClsStu4Synch.ModifyUserID) == true)
{
string strComparisonOp_ModifyUserID = objCurrEduClsStu4Synch_Cond.dicFldComparisonOp[conCurrEduClsStu4Synch.ModifyUserID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu4Synch.ModifyUserID, objCurrEduClsStu4Synch_Cond.ModifyUserID, strComparisonOp_ModifyUserID);
}
if (objCurrEduClsStu4Synch_Cond.IsUpdated(conCurrEduClsStu4Synch.Memo) == true)
{
string strComparisonOp_Memo = objCurrEduClsStu4Synch_Cond.dicFldComparisonOp[conCurrEduClsStu4Synch.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu4Synch.Memo, objCurrEduClsStu4Synch_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objCurrEduClsStu4SynchEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCurrEduClsStu4SynchEN objCurrEduClsStu4SynchEN)
{
 if (objCurrEduClsStu4SynchEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objCurrEduClsStu4SynchEN.sf_UpdFldSetStr = objCurrEduClsStu4SynchEN.getsf_UpdFldSetStr();
clsCurrEduClsStu4SynchWApi.CheckPropertyNew(objCurrEduClsStu4SynchEN); 
bool bolResult = clsCurrEduClsStu4SynchWApi.UpdateRecord(objCurrEduClsStu4SynchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsStu4SynchWApi.ReFreshCache();
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
 /// 检查唯一性(Uniqueness)--CurrEduClsStu4Synch(教学班与学生关系表_同步), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCurrEduClsStu4SynchEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_id_CurrEduCls_id_Stu_IpAddress(this clsCurrEduClsStu4SynchEN objCurrEduClsStu4SynchEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCurrEduClsStu4SynchEN == null) return "";
if (objCurrEduClsStu4SynchEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and id_CurrEduCls = '{0}'", objCurrEduClsStu4SynchEN.id_CurrEduCls);
 sbCondition.AppendFormat(" and id_Stu = '{0}'", objCurrEduClsStu4SynchEN.id_Stu);
 sbCondition.AppendFormat(" and IpAddress = '{0}'", objCurrEduClsStu4SynchEN.IpAddress);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objCurrEduClsStu4SynchEN.mId);
 sbCondition.AppendFormat(" and id_CurrEduCls = '{0}'", objCurrEduClsStu4SynchEN.id_CurrEduCls);
 sbCondition.AppendFormat(" and id_Stu = '{0}'", objCurrEduClsStu4SynchEN.id_Stu);
 sbCondition.AppendFormat(" and IpAddress = '{0}'", objCurrEduClsStu4SynchEN.IpAddress);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCurrEduClsStu4SynchEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCurrEduClsStu4SynchEN objCurrEduClsStu4SynchEN)
{
try
{
clsCurrEduClsStu4SynchWApi.CheckPropertyNew(objCurrEduClsStu4SynchEN); 
bool bolResult = clsCurrEduClsStu4SynchWApi.AddNewRecord(objCurrEduClsStu4SynchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsStu4SynchWApi.ReFreshCache();
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
 /// <param name = "objCurrEduClsStu4SynchEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCurrEduClsStu4SynchEN objCurrEduClsStu4SynchEN, string strWhereCond)
{
try
{
clsCurrEduClsStu4SynchWApi.CheckPropertyNew(objCurrEduClsStu4SynchEN); 
bool bolResult = clsCurrEduClsStu4SynchWApi.UpdateWithCondition(objCurrEduClsStu4SynchEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsStu4SynchWApi.ReFreshCache();
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
 /// 教学班与学生关系表_同步(CurrEduClsStu4Synch)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsCurrEduClsStu4SynchWApi
{
private static readonly string mstrApiControllerName = "CurrEduClsStu4SynchApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsCurrEduClsStu4SynchWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsCurrEduClsStu4SynchEN objCurrEduClsStu4SynchEN)
{
if (!Object.Equals(null, objCurrEduClsStu4SynchEN.IpAddress) && GetStrLen(objCurrEduClsStu4SynchEN.IpAddress) > 50)
{
 throw new Exception("字段[Ip地址]的长度不能超过50!");
}
if (!Object.Equals(null, objCurrEduClsStu4SynchEN.id_CurrEduCls) && GetStrLen(objCurrEduClsStu4SynchEN.id_CurrEduCls) > 8)
{
 throw new Exception("字段[当前教学班流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objCurrEduClsStu4SynchEN.id_Stu) && GetStrLen(objCurrEduClsStu4SynchEN.id_Stu) > 8)
{
 throw new Exception("字段[学生流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objCurrEduClsStu4SynchEN.EduClsStuStateID) && GetStrLen(objCurrEduClsStu4SynchEN.EduClsStuStateID) > 2)
{
 throw new Exception("字段[教学班学生状态编号]的长度不能超过2!");
}
if (!Object.Equals(null, objCurrEduClsStu4SynchEN.SchoolTerm) && GetStrLen(objCurrEduClsStu4SynchEN.SchoolTerm) > 1)
{
 throw new Exception("字段[学期]的长度不能超过1!");
}
if (!Object.Equals(null, objCurrEduClsStu4SynchEN.SchoolYear) && GetStrLen(objCurrEduClsStu4SynchEN.SchoolYear) > 10)
{
 throw new Exception("字段[学年]的长度不能超过10!");
}
if (!Object.Equals(null, objCurrEduClsStu4SynchEN.ExportDate) && GetStrLen(objCurrEduClsStu4SynchEN.ExportDate) > 8)
{
 throw new Exception("字段[导出日期]的长度不能超过8!");
}
if (!Object.Equals(null, objCurrEduClsStu4SynchEN.SignInDate) && GetStrLen(objCurrEduClsStu4SynchEN.SignInDate) > 20)
{
 throw new Exception("字段[签入时间]的长度不能超过20!");
}
if (!Object.Equals(null, objCurrEduClsStu4SynchEN.SignInStateID) && GetStrLen(objCurrEduClsStu4SynchEN.SignInStateID) > 2)
{
 throw new Exception("字段[签入状态表流水号]的长度不能超过2!");
}
if (!Object.Equals(null, objCurrEduClsStu4SynchEN.SignInUser) && GetStrLen(objCurrEduClsStu4SynchEN.SignInUser) > 18)
{
 throw new Exception("字段[签入人]的长度不能超过18!");
}
if (!Object.Equals(null, objCurrEduClsStu4SynchEN.AccessSynchDate) && GetStrLen(objCurrEduClsStu4SynchEN.AccessSynchDate) > 14)
{
 throw new Exception("字段[处理同步日期]的长度不能超过14!");
}
if (!Object.Equals(null, objCurrEduClsStu4SynchEN.ModifyDate) && GetStrLen(objCurrEduClsStu4SynchEN.ModifyDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objCurrEduClsStu4SynchEN.ModifyUserID) && GetStrLen(objCurrEduClsStu4SynchEN.ModifyUserID) > 18)
{
 throw new Exception("字段[修改人]的长度不能超过18!");
}
if (!Object.Equals(null, objCurrEduClsStu4SynchEN.Memo) && GetStrLen(objCurrEduClsStu4SynchEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objCurrEduClsStu4SynchEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCurrEduClsStu4SynchEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clsCurrEduClsStu4SynchEN objCurrEduClsStu4SynchEN = null;
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
objCurrEduClsStu4SynchEN = JsonConvert.DeserializeObject<clsCurrEduClsStu4SynchEN>((string)jobjReturn["ReturnObj"]);
return objCurrEduClsStu4SynchEN;
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
public static clsCurrEduClsStu4SynchEN GetObjBymId_WA_Cache(long lngmId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsCurrEduClsStu4SynchEN objCurrEduClsStu4SynchEN = null;
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
objCurrEduClsStu4SynchEN = JsonConvert.DeserializeObject<clsCurrEduClsStu4SynchEN>((string)jobjReturn["ReturnObj"]);
return objCurrEduClsStu4SynchEN;
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
public static clsCurrEduClsStu4SynchEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsCurrEduClsStu4SynchEN objCurrEduClsStu4SynchEN = null;
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
objCurrEduClsStu4SynchEN = JsonConvert.DeserializeObject<clsCurrEduClsStu4SynchEN>((string)jobjReturn["ReturnObj"]);
return objCurrEduClsStu4SynchEN;
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
public static clsCurrEduClsStu4SynchEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsCurrEduClsStu4SynchEN._CurrTabName_S);
List<clsCurrEduClsStu4SynchEN> arrCurrEduClsStu4SynchObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsCurrEduClsStu4SynchEN> arrCurrEduClsStu4SynchObjLst_Sel =
from objCurrEduClsStu4SynchEN in arrCurrEduClsStu4SynchObjLst_Cache
where objCurrEduClsStu4SynchEN.mId == lngmId
select objCurrEduClsStu4SynchEN;
if (arrCurrEduClsStu4SynchObjLst_Sel.Count() == 0)
{
   clsCurrEduClsStu4SynchEN obj = clsCurrEduClsStu4SynchWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrCurrEduClsStu4SynchObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCurrEduClsStu4SynchEN> GetObjLst(string strWhereCond)
{
 List<clsCurrEduClsStu4SynchEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCurrEduClsStu4SynchEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCurrEduClsStu4SynchEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsCurrEduClsStu4SynchEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCurrEduClsStu4SynchEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsCurrEduClsStu4SynchEN> GetObjLstByMIdLst_Cache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsCurrEduClsStu4SynchEN._CurrTabName_S);
List<clsCurrEduClsStu4SynchEN> arrCurrEduClsStu4SynchObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsCurrEduClsStu4SynchEN> arrCurrEduClsStu4SynchObjLst_Sel =
from objCurrEduClsStu4SynchEN in arrCurrEduClsStu4SynchObjLst_Cache
where arrMId.Contains(objCurrEduClsStu4SynchEN.mId)
select objCurrEduClsStu4SynchEN;
return arrCurrEduClsStu4SynchObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCurrEduClsStu4SynchEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId)
{
 List<clsCurrEduClsStu4SynchEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCurrEduClsStu4SynchEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCurrEduClsStu4SynchEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsCurrEduClsStu4SynchEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCurrEduClsStu4SynchEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCurrEduClsStu4SynchEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsCurrEduClsStu4SynchEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCurrEduClsStu4SynchEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCurrEduClsStu4SynchEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsCurrEduClsStu4SynchEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCurrEduClsStu4SynchEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCurrEduClsStu4SynchEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsCurrEduClsStu4SynchEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCurrEduClsStu4SynchEN>>((string)jobjReturn["ReturnObjLst"]);
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
 clsCurrEduClsStu4SynchEN objCurrEduClsStu4SynchEN = clsCurrEduClsStu4SynchWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsCurrEduClsStu4SynchWApi.ReFreshCache();
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
public static int DelCurrEduClsStu4Synchs(List<string> arrmId)
{
string strAction = "DelCurrEduClsStu4Synchs";
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
clsCurrEduClsStu4SynchWApi.ReFreshCache();
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
public static int DelCurrEduClsStu4SynchsByCond(string strWhereCond)
{
string strAction = "DelCurrEduClsStu4SynchsByCond";
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
public static bool AddNewRecord(clsCurrEduClsStu4SynchEN objCurrEduClsStu4SynchEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCurrEduClsStu4SynchEN>(objCurrEduClsStu4SynchEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsStu4SynchWApi.ReFreshCache();
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
 /// <param name = "objCurrEduClsStu4SynchEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsCurrEduClsStu4SynchEN objCurrEduClsStu4SynchEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCurrEduClsStu4SynchEN>(objCurrEduClsStu4SynchEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsStu4SynchWApi.ReFreshCache();
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
public static bool UpdateRecord(clsCurrEduClsStu4SynchEN objCurrEduClsStu4SynchEN)
{
if (string.IsNullOrEmpty(objCurrEduClsStu4SynchEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCurrEduClsStu4SynchEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCurrEduClsStu4SynchEN>(objCurrEduClsStu4SynchEN);
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
 /// <param name = "objCurrEduClsStu4SynchEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsCurrEduClsStu4SynchEN objCurrEduClsStu4SynchEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objCurrEduClsStu4SynchEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCurrEduClsStu4SynchEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCurrEduClsStu4SynchEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCurrEduClsStu4SynchEN>(objCurrEduClsStu4SynchEN);
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
 /// <param name = "objCurrEduClsStu4SynchENS">源对象</param>
 /// <param name = "objCurrEduClsStu4SynchENT">目标对象</param>
 public static void CopyTo(clsCurrEduClsStu4SynchEN objCurrEduClsStu4SynchENS, clsCurrEduClsStu4SynchEN objCurrEduClsStu4SynchENT)
{
try
{
objCurrEduClsStu4SynchENT.mId = objCurrEduClsStu4SynchENS.mId; //mId
objCurrEduClsStu4SynchENT.IpAddress = objCurrEduClsStu4SynchENS.IpAddress; //Ip地址
objCurrEduClsStu4SynchENT.id_EduClsStu = objCurrEduClsStu4SynchENS.id_EduClsStu; //教学班学生流水号
objCurrEduClsStu4SynchENT.id_CurrEduCls = objCurrEduClsStu4SynchENS.id_CurrEduCls; //当前教学班流水号
objCurrEduClsStu4SynchENT.id_Stu = objCurrEduClsStu4SynchENS.id_Stu; //学生流水号
objCurrEduClsStu4SynchENT.EduClsStuStateID = objCurrEduClsStu4SynchENS.EduClsStuStateID; //教学班学生状态编号
objCurrEduClsStu4SynchENT.GetScoreTimes = objCurrEduClsStu4SynchENS.GetScoreTimes; //获得成绩次数
objCurrEduClsStu4SynchENT.Score = objCurrEduClsStu4SynchENS.Score; //得分
objCurrEduClsStu4SynchENT.TotalScores = objCurrEduClsStu4SynchENS.TotalScores; //总分值
objCurrEduClsStu4SynchENT.Ranking = objCurrEduClsStu4SynchENS.Ranking; //名次
objCurrEduClsStu4SynchENT.Percentile = objCurrEduClsStu4SynchENS.Percentile; //百分位
objCurrEduClsStu4SynchENT.Ranking2 = objCurrEduClsStu4SynchENS.Ranking2; //Ranking2
objCurrEduClsStu4SynchENT.Percentile2 = objCurrEduClsStu4SynchENS.Percentile2; //Percentile2
objCurrEduClsStu4SynchENT.Ranking3 = objCurrEduClsStu4SynchENS.Ranking3; //Ranking3
objCurrEduClsStu4SynchENT.Percentile3 = objCurrEduClsStu4SynchENS.Percentile3; //Percentile3
objCurrEduClsStu4SynchENT.Confirmed = objCurrEduClsStu4SynchENS.Confirmed; //是否确认
objCurrEduClsStu4SynchENT.SchoolTerm = objCurrEduClsStu4SynchENS.SchoolTerm; //学期
objCurrEduClsStu4SynchENT.SchoolYear = objCurrEduClsStu4SynchENS.SchoolYear; //学年
objCurrEduClsStu4SynchENT.ExportDate = objCurrEduClsStu4SynchENS.ExportDate; //导出日期
objCurrEduClsStu4SynchENT.SignInDate = objCurrEduClsStu4SynchENS.SignInDate; //签入时间
objCurrEduClsStu4SynchENT.SignInStateID = objCurrEduClsStu4SynchENS.SignInStateID; //签入状态表流水号
objCurrEduClsStu4SynchENT.SignInUser = objCurrEduClsStu4SynchENS.SignInUser; //签入人
objCurrEduClsStu4SynchENT.IsOpByTeacher = objCurrEduClsStu4SynchENS.IsOpByTeacher; //是否教师操作
objCurrEduClsStu4SynchENT.IsSynScore = objCurrEduClsStu4SynchENS.IsSynScore; //是否同步成绩
objCurrEduClsStu4SynchENT.IsAccessSynch = objCurrEduClsStu4SynchENS.IsAccessSynch; //是否处理同步
objCurrEduClsStu4SynchENT.AccessSynchDate = objCurrEduClsStu4SynchENS.AccessSynchDate; //处理同步日期
objCurrEduClsStu4SynchENT.ModifyDate = objCurrEduClsStu4SynchENS.ModifyDate; //修改日期
objCurrEduClsStu4SynchENT.ModifyUserID = objCurrEduClsStu4SynchENS.ModifyUserID; //修改人
objCurrEduClsStu4SynchENT.Memo = objCurrEduClsStu4SynchENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsCurrEduClsStu4SynchEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsCurrEduClsStu4SynchEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsCurrEduClsStu4SynchEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsCurrEduClsStu4SynchEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsCurrEduClsStu4SynchEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsCurrEduClsStu4SynchEN.AttributeName)
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
if (clsCurrEduClsStu4SynchWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCurrEduClsStu4SynchWApi没有刷新缓存机制(clsCurrEduClsStu4SynchWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrCurrEduClsStu4SynchObjLst_Cache == null)
//{
//arrCurrEduClsStu4SynchObjLst_Cache = await clsCurrEduClsStu4SynchWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsCurrEduClsStu4SynchEN._CurrTabName_S);
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
if (clsCurrEduClsStu4SynchWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCurrEduClsStu4SynchEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsCurrEduClsStu4SynchWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCurrEduClsStu4SynchEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsCurrEduClsStu4SynchEN._CurrTabName_S);
List<clsCurrEduClsStu4SynchEN> arrCurrEduClsStu4SynchObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrCurrEduClsStu4SynchObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsCurrEduClsStu4SynchEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conCurrEduClsStu4Synch.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(conCurrEduClsStu4Synch.IpAddress, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduClsStu4Synch.id_EduClsStu, Type.GetType("System.Int64"));
objDT.Columns.Add(conCurrEduClsStu4Synch.id_CurrEduCls, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduClsStu4Synch.id_Stu, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduClsStu4Synch.EduClsStuStateID, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduClsStu4Synch.GetScoreTimes, Type.GetType("System.Int16"));
objDT.Columns.Add(conCurrEduClsStu4Synch.Score, Type.GetType("System.Decimal"));
objDT.Columns.Add(conCurrEduClsStu4Synch.TotalScores, Type.GetType("System.Decimal"));
objDT.Columns.Add(conCurrEduClsStu4Synch.Ranking, Type.GetType("System.Int32"));
objDT.Columns.Add(conCurrEduClsStu4Synch.Percentile, Type.GetType("System.Decimal"));
objDT.Columns.Add(conCurrEduClsStu4Synch.Ranking2, Type.GetType("System.Int32"));
objDT.Columns.Add(conCurrEduClsStu4Synch.Percentile2, Type.GetType("System.Decimal"));
objDT.Columns.Add(conCurrEduClsStu4Synch.Ranking3, Type.GetType("System.Int32"));
objDT.Columns.Add(conCurrEduClsStu4Synch.Percentile3, Type.GetType("System.Decimal"));
objDT.Columns.Add(conCurrEduClsStu4Synch.Confirmed, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCurrEduClsStu4Synch.SchoolTerm, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduClsStu4Synch.SchoolYear, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduClsStu4Synch.ExportDate, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduClsStu4Synch.SignInDate, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduClsStu4Synch.SignInStateID, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduClsStu4Synch.SignInUser, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduClsStu4Synch.IsOpByTeacher, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCurrEduClsStu4Synch.IsSynScore, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCurrEduClsStu4Synch.IsAccessSynch, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCurrEduClsStu4Synch.AccessSynchDate, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduClsStu4Synch.ModifyDate, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduClsStu4Synch.ModifyUserID, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduClsStu4Synch.Memo, Type.GetType("System.String"));
foreach (clsCurrEduClsStu4SynchEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conCurrEduClsStu4Synch.mId] = objInFor[conCurrEduClsStu4Synch.mId];
objDR[conCurrEduClsStu4Synch.IpAddress] = objInFor[conCurrEduClsStu4Synch.IpAddress];
objDR[conCurrEduClsStu4Synch.id_EduClsStu] = objInFor[conCurrEduClsStu4Synch.id_EduClsStu];
objDR[conCurrEduClsStu4Synch.id_CurrEduCls] = objInFor[conCurrEduClsStu4Synch.id_CurrEduCls];
objDR[conCurrEduClsStu4Synch.id_Stu] = objInFor[conCurrEduClsStu4Synch.id_Stu];
objDR[conCurrEduClsStu4Synch.EduClsStuStateID] = objInFor[conCurrEduClsStu4Synch.EduClsStuStateID];
objDR[conCurrEduClsStu4Synch.GetScoreTimes] = objInFor[conCurrEduClsStu4Synch.GetScoreTimes];
objDR[conCurrEduClsStu4Synch.Score] = objInFor[conCurrEduClsStu4Synch.Score];
objDR[conCurrEduClsStu4Synch.TotalScores] = objInFor[conCurrEduClsStu4Synch.TotalScores];
objDR[conCurrEduClsStu4Synch.Ranking] = objInFor[conCurrEduClsStu4Synch.Ranking];
objDR[conCurrEduClsStu4Synch.Percentile] = objInFor[conCurrEduClsStu4Synch.Percentile];
objDR[conCurrEduClsStu4Synch.Ranking2] = objInFor[conCurrEduClsStu4Synch.Ranking2];
objDR[conCurrEduClsStu4Synch.Percentile2] = objInFor[conCurrEduClsStu4Synch.Percentile2];
objDR[conCurrEduClsStu4Synch.Ranking3] = objInFor[conCurrEduClsStu4Synch.Ranking3];
objDR[conCurrEduClsStu4Synch.Percentile3] = objInFor[conCurrEduClsStu4Synch.Percentile3];
objDR[conCurrEduClsStu4Synch.Confirmed] = objInFor[conCurrEduClsStu4Synch.Confirmed];
objDR[conCurrEduClsStu4Synch.SchoolTerm] = objInFor[conCurrEduClsStu4Synch.SchoolTerm];
objDR[conCurrEduClsStu4Synch.SchoolYear] = objInFor[conCurrEduClsStu4Synch.SchoolYear];
objDR[conCurrEduClsStu4Synch.ExportDate] = objInFor[conCurrEduClsStu4Synch.ExportDate];
objDR[conCurrEduClsStu4Synch.SignInDate] = objInFor[conCurrEduClsStu4Synch.SignInDate];
objDR[conCurrEduClsStu4Synch.SignInStateID] = objInFor[conCurrEduClsStu4Synch.SignInStateID];
objDR[conCurrEduClsStu4Synch.SignInUser] = objInFor[conCurrEduClsStu4Synch.SignInUser];
objDR[conCurrEduClsStu4Synch.IsOpByTeacher] = objInFor[conCurrEduClsStu4Synch.IsOpByTeacher];
objDR[conCurrEduClsStu4Synch.IsSynScore] = objInFor[conCurrEduClsStu4Synch.IsSynScore];
objDR[conCurrEduClsStu4Synch.IsAccessSynch] = objInFor[conCurrEduClsStu4Synch.IsAccessSynch];
objDR[conCurrEduClsStu4Synch.AccessSynchDate] = objInFor[conCurrEduClsStu4Synch.AccessSynchDate];
objDR[conCurrEduClsStu4Synch.ModifyDate] = objInFor[conCurrEduClsStu4Synch.ModifyDate];
objDR[conCurrEduClsStu4Synch.ModifyUserID] = objInFor[conCurrEduClsStu4Synch.ModifyUserID];
objDR[conCurrEduClsStu4Synch.Memo] = objInFor[conCurrEduClsStu4Synch.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 教学班与学生关系表_同步(CurrEduClsStu4Synch)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4CurrEduClsStu4Synch : clsCommFun4BL
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
clsCurrEduClsStu4SynchWApi.ReFreshThisCache();
}
}

}