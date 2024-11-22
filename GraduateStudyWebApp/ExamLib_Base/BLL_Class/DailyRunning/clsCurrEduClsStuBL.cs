
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCurrEduClsStuBL
 表名:CurrEduClsStu(01120125)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 05:59:39
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:日常运行(DailyRunning)
 框架-层名:业务逻辑层(CS)(BusinessLogic,0003)
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
public static class  clsCurrEduClsStuBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdEduClsStu">表关键字</param>
 /// <returns>表对象</returns>
public static clsCurrEduClsStuEN GetObj(this K_IdEduClsStu_CurrEduClsStu myKey)
{
clsCurrEduClsStuEN objCurrEduClsStuEN = clsCurrEduClsStuBL.CurrEduClsStuDA.GetObjByIdEduClsStu(myKey.Value);
return objCurrEduClsStuEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCurrEduClsStuEN objCurrEduClsStuEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCurrEduClsStuEN) == false)
{
var strMsg = string.Format("记录已经存在!教学班流水号 = [{0}],学生流水号 = [{1}]的数据已经存在!(in clsCurrEduClsStuBL.AddNewRecord)", objCurrEduClsStuEN.IdCurrEduCls,objCurrEduClsStuEN.IdStu);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsCurrEduClsStuBL.CurrEduClsStuDA.AddNewRecordBySQL2(objCurrEduClsStuEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsStuBL.ReFreshCache(objCurrEduClsStuEN.IdCurrEduCls);

if (clsCurrEduClsStuBL.relatedActions != null)
{
clsCurrEduClsStuBL.relatedActions.UpdRelaTabDate(objCurrEduClsStuEN.IdEduClsStu, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000082)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 插入记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddRecordEx)
 /// </summary>
 /// <returns>插入记录是否成功？</returns>
public static bool AddRecordEx(this clsCurrEduClsStuEN objCurrEduClsStuEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
try
{
 //2、检查传进去的对象属性是否合法
objCurrEduClsStuEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objCurrEduClsStuEN.CheckUniqueness() == false)
{
strMsg = string.Format("(教学班流水号(IdCurrEduCls)=[{0}],学生流水号(IdStu)=[{1}])已经存在,不能重复!", objCurrEduClsStuEN.IdCurrEduCls, objCurrEduClsStuEN.IdStu);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objCurrEduClsStuEN.AddNewRecord();
}
catch(Exception objException)
{
strMsg = "(errid:Busi000152)添加记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsCurrEduClsStuEN objCurrEduClsStuEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCurrEduClsStuEN) == false)
{
var strMsg = string.Format("记录已经存在!教学班流水号 = [{0}],学生流水号 = [{1}]的数据已经存在!(in clsCurrEduClsStuBL.AddNewRecordWithReturnKey)", objCurrEduClsStuEN.IdCurrEduCls,objCurrEduClsStuEN.IdStu);
throw new Exception(strMsg);
}
try
{
string strKey = clsCurrEduClsStuBL.CurrEduClsStuDA.AddNewRecordBySQL2WithReturnKey(objCurrEduClsStuEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsStuBL.ReFreshCache(objCurrEduClsStuEN.IdCurrEduCls);

if (clsCurrEduClsStuBL.relatedActions != null)
{
clsCurrEduClsStuBL.relatedActions.UpdRelaTabDate(objCurrEduClsStuEN.IdEduClsStu, "SetUpdDate");
}
return strKey;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000091)带返回值的添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsStuEN SetIdEduClsStu(this clsCurrEduClsStuEN objCurrEduClsStuEN, long lngIdEduClsStu, string strComparisonOp="")
	{
objCurrEduClsStuEN.IdEduClsStu = lngIdEduClsStu; //教学班学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu.IdEduClsStu) == false)
{
objCurrEduClsStuEN.dicFldComparisonOp.Add(conCurrEduClsStu.IdEduClsStu, strComparisonOp);
}
else
{
objCurrEduClsStuEN.dicFldComparisonOp[conCurrEduClsStu.IdEduClsStu] = strComparisonOp;
}
}
return objCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsStuEN SetIdCurrEduCls(this clsCurrEduClsStuEN objCurrEduClsStuEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conCurrEduClsStu.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conCurrEduClsStu.IdCurrEduCls);
}
objCurrEduClsStuEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu.IdCurrEduCls) == false)
{
objCurrEduClsStuEN.dicFldComparisonOp.Add(conCurrEduClsStu.IdCurrEduCls, strComparisonOp);
}
else
{
objCurrEduClsStuEN.dicFldComparisonOp[conCurrEduClsStu.IdCurrEduCls] = strComparisonOp;
}
}
return objCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsStuEN SetIdStu(this clsCurrEduClsStuEN objCurrEduClsStuEN, string strIdStu, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStu, 8, conCurrEduClsStu.IdStu);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStu, 8, conCurrEduClsStu.IdStu);
}
objCurrEduClsStuEN.IdStu = strIdStu; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu.IdStu) == false)
{
objCurrEduClsStuEN.dicFldComparisonOp.Add(conCurrEduClsStu.IdStu, strComparisonOp);
}
else
{
objCurrEduClsStuEN.dicFldComparisonOp[conCurrEduClsStu.IdStu] = strComparisonOp;
}
}
return objCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsStuEN SetEduClsStuStateId(this clsCurrEduClsStuEN objCurrEduClsStuEN, string strEduClsStuStateId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduClsStuStateId, 2, conCurrEduClsStu.EduClsStuStateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strEduClsStuStateId, 2, conCurrEduClsStu.EduClsStuStateId);
}
objCurrEduClsStuEN.EduClsStuStateId = strEduClsStuStateId; //教学班学生状态编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu.EduClsStuStateId) == false)
{
objCurrEduClsStuEN.dicFldComparisonOp.Add(conCurrEduClsStu.EduClsStuStateId, strComparisonOp);
}
else
{
objCurrEduClsStuEN.dicFldComparisonOp[conCurrEduClsStu.EduClsStuStateId] = strComparisonOp;
}
}
return objCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsStuEN SetGetScoreTimes(this clsCurrEduClsStuEN objCurrEduClsStuEN, short? shtGetScoreTimes, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsStuEN SetScore(this clsCurrEduClsStuEN objCurrEduClsStuEN, double? dblScore, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsStuEN SetTotalScores(this clsCurrEduClsStuEN objCurrEduClsStuEN, double? dblTotalScores, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsStuEN SetRanking(this clsCurrEduClsStuEN objCurrEduClsStuEN, int? intRanking, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsStuEN SetPercentile(this clsCurrEduClsStuEN objCurrEduClsStuEN, double? dblPercentile, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsStuEN SetRanking2(this clsCurrEduClsStuEN objCurrEduClsStuEN, int? intRanking2, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsStuEN SetPercentile2(this clsCurrEduClsStuEN objCurrEduClsStuEN, double? dblPercentile2, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsStuEN SetRanking3(this clsCurrEduClsStuEN objCurrEduClsStuEN, int? intRanking3, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsStuEN SetPercentile3(this clsCurrEduClsStuEN objCurrEduClsStuEN, double? dblPercentile3, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsStuEN SetSchoolTerm(this clsCurrEduClsStuEN objCurrEduClsStuEN, string strSchoolTerm, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, conCurrEduClsStu.SchoolTerm);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, conCurrEduClsStu.SchoolTerm);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsStuEN SetSchoolYear(this clsCurrEduClsStuEN objCurrEduClsStuEN, string strSchoolYear, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, conCurrEduClsStu.SchoolYear);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsStuEN SetExportDate(this clsCurrEduClsStuEN objCurrEduClsStuEN, string strExportDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExportDate, 8, conCurrEduClsStu.ExportDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsStuEN SetSignInDate(this clsCurrEduClsStuEN objCurrEduClsStuEN, string strSignInDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSignInDate, 20, conCurrEduClsStu.SignInDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsStuEN SetSignInStateID(this clsCurrEduClsStuEN objCurrEduClsStuEN, string strSignInStateID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSignInStateID, 2, conCurrEduClsStu.SignInStateID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSignInStateID, 2, conCurrEduClsStu.SignInStateID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsStuEN SetSignInUser(this clsCurrEduClsStuEN objCurrEduClsStuEN, string strSignInUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSignInUser, 18, conCurrEduClsStu.SignInUser);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsStuEN SetLastVisitedDate(this clsCurrEduClsStuEN objCurrEduClsStuEN, string strLastVisitedDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLastVisitedDate, 14, conCurrEduClsStu.LastVisitedDate);
}
objCurrEduClsStuEN.LastVisitedDate = strLastVisitedDate; //最后访问时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu.LastVisitedDate) == false)
{
objCurrEduClsStuEN.dicFldComparisonOp.Add(conCurrEduClsStu.LastVisitedDate, strComparisonOp);
}
else
{
objCurrEduClsStuEN.dicFldComparisonOp[conCurrEduClsStu.LastVisitedDate] = strComparisonOp;
}
}
return objCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsStuEN SetModifyDate(this clsCurrEduClsStuEN objCurrEduClsStuEN, string strModifyDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModifyDate, 20, conCurrEduClsStu.ModifyDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsStuEN SetModifyUserId(this clsCurrEduClsStuEN objCurrEduClsStuEN, string strModifyUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModifyUserId, 18, conCurrEduClsStu.ModifyUserId);
}
objCurrEduClsStuEN.ModifyUserId = strModifyUserId; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStuEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu.ModifyUserId) == false)
{
objCurrEduClsStuEN.dicFldComparisonOp.Add(conCurrEduClsStu.ModifyUserId, strComparisonOp);
}
else
{
objCurrEduClsStuEN.dicFldComparisonOp[conCurrEduClsStu.ModifyUserId] = strComparisonOp;
}
}
return objCurrEduClsStuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsStuEN SetMemo(this clsCurrEduClsStuEN objCurrEduClsStuEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCurrEduClsStu.Memo);
}
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
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsCurrEduClsStuEN objCurrEduClsStuEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objCurrEduClsStuEN.CheckPropertyNew();
clsCurrEduClsStuEN objCurrEduClsStuCond = new clsCurrEduClsStuEN();
string strCondition = objCurrEduClsStuCond
.SetIdEduClsStu(objCurrEduClsStuEN.IdEduClsStu, "<>")
.SetIdCurrEduCls(objCurrEduClsStuEN.IdCurrEduCls, "=")
.SetIdStu(objCurrEduClsStuEN.IdStu, "=")
.GetCombineCondition();
objCurrEduClsStuEN._IsCheckProperty = true;
bool bolIsExist = clsCurrEduClsStuBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(id_CurrEduCls_id_Stu)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objCurrEduClsStuEN.Update();
}
catch(Exception objException)
{
strMsg = "修改记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true; 
}

 /// <summary>
 /// 编辑记录存盘到数据表中。如果存在相关记录就修改,不存在就添加
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_EditRecordEx)
 /// </summary>
 /// <param name = "objCurrEduClsStu">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsCurrEduClsStuEN objCurrEduClsStu)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsCurrEduClsStuEN objCurrEduClsStuCond = new clsCurrEduClsStuEN();
string strCondition = objCurrEduClsStuCond
.SetIdCurrEduCls(objCurrEduClsStu.IdCurrEduCls, "=")
.SetIdStu(objCurrEduClsStu.IdStu, "=")
.GetCombineCondition();
objCurrEduClsStu._IsCheckProperty = true;
bool bolIsExist = clsCurrEduClsStuBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objCurrEduClsStu.IdEduClsStu = clsCurrEduClsStuBL.GetFirstID_S(strCondition);
objCurrEduClsStu.UpdateWithCondition(strCondition);
}
else
{
objCurrEduClsStu.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCurrEduClsStuEN objCurrEduClsStuEN)
{
 if (objCurrEduClsStuEN.IdEduClsStu == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCurrEduClsStuBL.CurrEduClsStuDA.UpdateBySql2(objCurrEduClsStuEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsStuBL.ReFreshCache(objCurrEduClsStuEN.IdCurrEduCls);

if (clsCurrEduClsStuBL.relatedActions != null)
{
clsCurrEduClsStuBL.relatedActions.UpdRelaTabDate(objCurrEduClsStuEN.IdEduClsStu, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000083)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式.(带事务处理)
 /// /// 优点:1、能够处理字段中的单撇问题；
 /// /// 2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库;
 /// /// 3、支持事务处理.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateWithTransaction)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCurrEduClsStuEN objCurrEduClsStuEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objCurrEduClsStuEN.IdEduClsStu == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCurrEduClsStuBL.CurrEduClsStuDA.UpdateBySql2(objCurrEduClsStuEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsStuBL.ReFreshCache(objCurrEduClsStuEN.IdCurrEduCls);

if (clsCurrEduClsStuBL.relatedActions != null)
{
clsCurrEduClsStuBL.relatedActions.UpdRelaTabDate(objCurrEduClsStuEN.IdEduClsStu, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000088)修改记录出错,{1}.(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCurrEduClsStuEN objCurrEduClsStuEN, string strWhereCond)
{
try
{
bool bolResult = clsCurrEduClsStuBL.CurrEduClsStuDA.UpdateBySqlWithCondition(objCurrEduClsStuEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsStuBL.ReFreshCache(objCurrEduClsStuEN.IdCurrEduCls);

if (clsCurrEduClsStuBL.relatedActions != null)
{
clsCurrEduClsStuBL.relatedActions.UpdRelaTabDate(objCurrEduClsStuEN.IdEduClsStu, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000089)根据条件修改记录出错, {1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录.(带事务处理)
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateWithConditionTransaction)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCurrEduClsStuEN objCurrEduClsStuEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsCurrEduClsStuBL.CurrEduClsStuDA.UpdateBySqlWithConditionTransaction(objCurrEduClsStuEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsStuBL.ReFreshCache(objCurrEduClsStuEN.IdCurrEduCls);

if (clsCurrEduClsStuBL.relatedActions != null)
{
clsCurrEduClsStuBL.relatedActions.UpdRelaTabDate(objCurrEduClsStuEN.IdEduClsStu, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000090)根据条件修改记录出错!(带事务处理),{1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Delete)
 /// </summary>
 /// <param name = "lngIdEduClsStu">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsCurrEduClsStuEN objCurrEduClsStuEN)
{
try
{
int intRecNum = clsCurrEduClsStuBL.CurrEduClsStuDA.DelRecord(objCurrEduClsStuEN.IdEduClsStu);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsStuBL.ReFreshCache(objCurrEduClsStuEN.IdCurrEduCls);

if (clsCurrEduClsStuBL.relatedActions != null)
{
clsCurrEduClsStuBL.relatedActions.UpdRelaTabDate(objCurrEduClsStuEN.IdEduClsStu, "SetUpdDate");
}
return intRecNum;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000084)根据关键字删除记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objCurrEduClsStuENS">源对象</param>
 /// <param name = "objCurrEduClsStuENT">目标对象</param>
 public static void CopyTo(this clsCurrEduClsStuEN objCurrEduClsStuENS, clsCurrEduClsStuEN objCurrEduClsStuENT)
{
try
{
objCurrEduClsStuENT.IdEduClsStu = objCurrEduClsStuENS.IdEduClsStu; //教学班学生流水号
objCurrEduClsStuENT.IdCurrEduCls = objCurrEduClsStuENS.IdCurrEduCls; //教学班流水号
objCurrEduClsStuENT.IdStu = objCurrEduClsStuENS.IdStu; //学生流水号
objCurrEduClsStuENT.EduClsStuStateId = objCurrEduClsStuENS.EduClsStuStateId; //教学班学生状态编号
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
objCurrEduClsStuENT.LastVisitedDate = objCurrEduClsStuENS.LastVisitedDate; //最后访问时间
objCurrEduClsStuENT.ModifyDate = objCurrEduClsStuENS.ModifyDate; //修改日期
objCurrEduClsStuENT.ModifyUserId = objCurrEduClsStuENS.ModifyUserId; //修改人
objCurrEduClsStuENT.Memo = objCurrEduClsStuENS.Memo; //备注
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
 /// <param name = "objCurrEduClsStuENS">源对象</param>
 /// <returns>目标对象=>clsCurrEduClsStuEN:objCurrEduClsStuENT</returns>
 public static clsCurrEduClsStuEN CopyTo(this clsCurrEduClsStuEN objCurrEduClsStuENS)
{
try
{
 clsCurrEduClsStuEN objCurrEduClsStuENT = new clsCurrEduClsStuEN()
{
IdEduClsStu = objCurrEduClsStuENS.IdEduClsStu, //教学班学生流水号
IdCurrEduCls = objCurrEduClsStuENS.IdCurrEduCls, //教学班流水号
IdStu = objCurrEduClsStuENS.IdStu, //学生流水号
EduClsStuStateId = objCurrEduClsStuENS.EduClsStuStateId, //教学班学生状态编号
GetScoreTimes = objCurrEduClsStuENS.GetScoreTimes, //获得成绩次数
Score = objCurrEduClsStuENS.Score, //得分
TotalScores = objCurrEduClsStuENS.TotalScores, //总分值
Ranking = objCurrEduClsStuENS.Ranking, //名次
Percentile = objCurrEduClsStuENS.Percentile, //百分位
Ranking2 = objCurrEduClsStuENS.Ranking2, //Ranking2
Percentile2 = objCurrEduClsStuENS.Percentile2, //Percentile2
Ranking3 = objCurrEduClsStuENS.Ranking3, //Ranking3
Percentile3 = objCurrEduClsStuENS.Percentile3, //Percentile3
Confirmed = objCurrEduClsStuENS.Confirmed, //是否确认
SchoolTerm = objCurrEduClsStuENS.SchoolTerm, //学期
SchoolYear = objCurrEduClsStuENS.SchoolYear, //学年
ExportDate = objCurrEduClsStuENS.ExportDate, //导出日期
SignInDate = objCurrEduClsStuENS.SignInDate, //签入时间
SignInStateID = objCurrEduClsStuENS.SignInStateID, //签入状态表流水号
SignInUser = objCurrEduClsStuENS.SignInUser, //签入人
IsOpByTeacher = objCurrEduClsStuENS.IsOpByTeacher, //是否教师操作
IsSynScore = objCurrEduClsStuENS.IsSynScore, //是否同步成绩
LastVisitedDate = objCurrEduClsStuENS.LastVisitedDate, //最后访问时间
ModifyDate = objCurrEduClsStuENS.ModifyDate, //修改日期
ModifyUserId = objCurrEduClsStuENS.ModifyUserId, //修改人
Memo = objCurrEduClsStuENS.Memo, //备注
};
 return objCurrEduClsStuENT;
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
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(this clsCurrEduClsStuEN objCurrEduClsStuEN)
{
 clsCurrEduClsStuBL.CurrEduClsStuDA.CheckPropertyNew(objCurrEduClsStuEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsCurrEduClsStuEN objCurrEduClsStuEN)
{
 clsCurrEduClsStuBL.CurrEduClsStuDA.CheckProperty4Condition(objCurrEduClsStuEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCurrEduClsStuEN objCurrEduClsStuCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCurrEduClsStuCond.IsUpdated(conCurrEduClsStu.IdEduClsStu) == true)
{
string strComparisonOpIdEduClsStu = objCurrEduClsStuCond.dicFldComparisonOp[conCurrEduClsStu.IdEduClsStu];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduClsStu.IdEduClsStu, objCurrEduClsStuCond.IdEduClsStu, strComparisonOpIdEduClsStu);
}
if (objCurrEduClsStuCond.IsUpdated(conCurrEduClsStu.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objCurrEduClsStuCond.dicFldComparisonOp[conCurrEduClsStu.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu.IdCurrEduCls, objCurrEduClsStuCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objCurrEduClsStuCond.IsUpdated(conCurrEduClsStu.IdStu) == true)
{
string strComparisonOpIdStu = objCurrEduClsStuCond.dicFldComparisonOp[conCurrEduClsStu.IdStu];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu.IdStu, objCurrEduClsStuCond.IdStu, strComparisonOpIdStu);
}
if (objCurrEduClsStuCond.IsUpdated(conCurrEduClsStu.EduClsStuStateId) == true)
{
string strComparisonOpEduClsStuStateId = objCurrEduClsStuCond.dicFldComparisonOp[conCurrEduClsStu.EduClsStuStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu.EduClsStuStateId, objCurrEduClsStuCond.EduClsStuStateId, strComparisonOpEduClsStuStateId);
}
//数据类型short(tinyint)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objCurrEduClsStuCond.IsUpdated(conCurrEduClsStu.Score) == true)
{
string strComparisonOpScore = objCurrEduClsStuCond.dicFldComparisonOp[conCurrEduClsStu.Score];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduClsStu.Score, objCurrEduClsStuCond.Score, strComparisonOpScore);
}
if (objCurrEduClsStuCond.IsUpdated(conCurrEduClsStu.TotalScores) == true)
{
string strComparisonOpTotalScores = objCurrEduClsStuCond.dicFldComparisonOp[conCurrEduClsStu.TotalScores];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduClsStu.TotalScores, objCurrEduClsStuCond.TotalScores, strComparisonOpTotalScores);
}
if (objCurrEduClsStuCond.IsUpdated(conCurrEduClsStu.Ranking) == true)
{
string strComparisonOpRanking = objCurrEduClsStuCond.dicFldComparisonOp[conCurrEduClsStu.Ranking];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduClsStu.Ranking, objCurrEduClsStuCond.Ranking, strComparisonOpRanking);
}
if (objCurrEduClsStuCond.IsUpdated(conCurrEduClsStu.Percentile) == true)
{
string strComparisonOpPercentile = objCurrEduClsStuCond.dicFldComparisonOp[conCurrEduClsStu.Percentile];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduClsStu.Percentile, objCurrEduClsStuCond.Percentile, strComparisonOpPercentile);
}
if (objCurrEduClsStuCond.IsUpdated(conCurrEduClsStu.Ranking2) == true)
{
string strComparisonOpRanking2 = objCurrEduClsStuCond.dicFldComparisonOp[conCurrEduClsStu.Ranking2];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduClsStu.Ranking2, objCurrEduClsStuCond.Ranking2, strComparisonOpRanking2);
}
if (objCurrEduClsStuCond.IsUpdated(conCurrEduClsStu.Percentile2) == true)
{
string strComparisonOpPercentile2 = objCurrEduClsStuCond.dicFldComparisonOp[conCurrEduClsStu.Percentile2];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduClsStu.Percentile2, objCurrEduClsStuCond.Percentile2, strComparisonOpPercentile2);
}
if (objCurrEduClsStuCond.IsUpdated(conCurrEduClsStu.Ranking3) == true)
{
string strComparisonOpRanking3 = objCurrEduClsStuCond.dicFldComparisonOp[conCurrEduClsStu.Ranking3];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduClsStu.Ranking3, objCurrEduClsStuCond.Ranking3, strComparisonOpRanking3);
}
if (objCurrEduClsStuCond.IsUpdated(conCurrEduClsStu.Percentile3) == true)
{
string strComparisonOpPercentile3 = objCurrEduClsStuCond.dicFldComparisonOp[conCurrEduClsStu.Percentile3];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduClsStu.Percentile3, objCurrEduClsStuCond.Percentile3, strComparisonOpPercentile3);
}
if (objCurrEduClsStuCond.IsUpdated(conCurrEduClsStu.Confirmed) == true)
{
if (objCurrEduClsStuCond.Confirmed == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduClsStu.Confirmed);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduClsStu.Confirmed);
}
}
if (objCurrEduClsStuCond.IsUpdated(conCurrEduClsStu.SchoolTerm) == true)
{
string strComparisonOpSchoolTerm = objCurrEduClsStuCond.dicFldComparisonOp[conCurrEduClsStu.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu.SchoolTerm, objCurrEduClsStuCond.SchoolTerm, strComparisonOpSchoolTerm);
}
if (objCurrEduClsStuCond.IsUpdated(conCurrEduClsStu.SchoolYear) == true)
{
string strComparisonOpSchoolYear = objCurrEduClsStuCond.dicFldComparisonOp[conCurrEduClsStu.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu.SchoolYear, objCurrEduClsStuCond.SchoolYear, strComparisonOpSchoolYear);
}
if (objCurrEduClsStuCond.IsUpdated(conCurrEduClsStu.ExportDate) == true)
{
string strComparisonOpExportDate = objCurrEduClsStuCond.dicFldComparisonOp[conCurrEduClsStu.ExportDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu.ExportDate, objCurrEduClsStuCond.ExportDate, strComparisonOpExportDate);
}
if (objCurrEduClsStuCond.IsUpdated(conCurrEduClsStu.SignInDate) == true)
{
string strComparisonOpSignInDate = objCurrEduClsStuCond.dicFldComparisonOp[conCurrEduClsStu.SignInDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu.SignInDate, objCurrEduClsStuCond.SignInDate, strComparisonOpSignInDate);
}
if (objCurrEduClsStuCond.IsUpdated(conCurrEduClsStu.SignInStateID) == true)
{
string strComparisonOpSignInStateID = objCurrEduClsStuCond.dicFldComparisonOp[conCurrEduClsStu.SignInStateID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu.SignInStateID, objCurrEduClsStuCond.SignInStateID, strComparisonOpSignInStateID);
}
if (objCurrEduClsStuCond.IsUpdated(conCurrEduClsStu.SignInUser) == true)
{
string strComparisonOpSignInUser = objCurrEduClsStuCond.dicFldComparisonOp[conCurrEduClsStu.SignInUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu.SignInUser, objCurrEduClsStuCond.SignInUser, strComparisonOpSignInUser);
}
if (objCurrEduClsStuCond.IsUpdated(conCurrEduClsStu.IsOpByTeacher) == true)
{
if (objCurrEduClsStuCond.IsOpByTeacher == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduClsStu.IsOpByTeacher);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduClsStu.IsOpByTeacher);
}
}
if (objCurrEduClsStuCond.IsUpdated(conCurrEduClsStu.IsSynScore) == true)
{
if (objCurrEduClsStuCond.IsSynScore == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduClsStu.IsSynScore);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduClsStu.IsSynScore);
}
}
if (objCurrEduClsStuCond.IsUpdated(conCurrEduClsStu.LastVisitedDate) == true)
{
string strComparisonOpLastVisitedDate = objCurrEduClsStuCond.dicFldComparisonOp[conCurrEduClsStu.LastVisitedDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu.LastVisitedDate, objCurrEduClsStuCond.LastVisitedDate, strComparisonOpLastVisitedDate);
}
if (objCurrEduClsStuCond.IsUpdated(conCurrEduClsStu.ModifyDate) == true)
{
string strComparisonOpModifyDate = objCurrEduClsStuCond.dicFldComparisonOp[conCurrEduClsStu.ModifyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu.ModifyDate, objCurrEduClsStuCond.ModifyDate, strComparisonOpModifyDate);
}
if (objCurrEduClsStuCond.IsUpdated(conCurrEduClsStu.ModifyUserId) == true)
{
string strComparisonOpModifyUserId = objCurrEduClsStuCond.dicFldComparisonOp[conCurrEduClsStu.ModifyUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu.ModifyUserId, objCurrEduClsStuCond.ModifyUserId, strComparisonOpModifyUserId);
}
if (objCurrEduClsStuCond.IsUpdated(conCurrEduClsStu.Memo) == true)
{
string strComparisonOpMemo = objCurrEduClsStuCond.dicFldComparisonOp[conCurrEduClsStu.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu.Memo, objCurrEduClsStuCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--CurrEduClsStu(教学班与学生关系), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:id_CurrEduCls_id_Stu
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsCurrEduClsStuEN objCurrEduClsStuEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objCurrEduClsStuEN == null) return true;
if (objCurrEduClsStuEN.IdEduClsStu == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objCurrEduClsStuEN.IdCurrEduCls == null)
{
 sbCondition.AppendFormat(" and IdCurrEduCls is null", objCurrEduClsStuEN.IdCurrEduCls);
}
else
{
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objCurrEduClsStuEN.IdCurrEduCls);
}
 if (objCurrEduClsStuEN.IdStu == null)
{
 sbCondition.AppendFormat(" and IdStu is null", objCurrEduClsStuEN.IdStu);
}
else
{
 sbCondition.AppendFormat(" and IdStu = '{0}'", objCurrEduClsStuEN.IdStu);
}
if (clsCurrEduClsStuBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("IdEduClsStu !=  {0}", objCurrEduClsStuEN.IdEduClsStu);
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objCurrEduClsStuEN.IdCurrEduCls);
 sbCondition.AppendFormat(" and IdStu = '{0}'", objCurrEduClsStuEN.IdStu);
if (clsCurrEduClsStuBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
return bolIsUniqueness;
}

 /// <summary>
 /// 获取唯一性条件串--CurrEduClsStu(教学班与学生关系), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:id_CurrEduCls_id_Stu
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsCurrEduClsStuEN objCurrEduClsStuEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCurrEduClsStuEN == null) return "";
if (objCurrEduClsStuEN.IdEduClsStu == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objCurrEduClsStuEN.IdCurrEduCls == null)
{
 sbCondition.AppendFormat(" and IdCurrEduCls is null", objCurrEduClsStuEN.IdCurrEduCls);
}
else
{
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objCurrEduClsStuEN.IdCurrEduCls);
}
 if (objCurrEduClsStuEN.IdStu == null)
{
 sbCondition.AppendFormat(" and IdStu is null", objCurrEduClsStuEN.IdStu);
}
else
{
 sbCondition.AppendFormat(" and IdStu = '{0}'", objCurrEduClsStuEN.IdStu);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("IdEduClsStu !=  {0}", objCurrEduClsStuEN.IdEduClsStu);
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objCurrEduClsStuEN.IdCurrEduCls);
 sbCondition.AppendFormat(" and IdStu = '{0}'", objCurrEduClsStuEN.IdStu);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_CurrEduClsStu
{
public virtual bool UpdRelaTabDate(long lngIdEduClsStu, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 教学班与学生关系(CurrEduClsStu)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsCurrEduClsStuBL
{
public static RelatedActions_CurrEduClsStu relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsCurrEduClsStuDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsCurrEduClsStuDA CurrEduClsStuDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsCurrEduClsStuDA();
}
return uniqueInstance;
}
}

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4BL = null;

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsCurrEduClsStuBL()
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
if (string.IsNullOrEmpty(clsCurrEduClsStuEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCurrEduClsStuEN._ConnectString);
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
public static DataTable GetDataTable_CurrEduClsStu(string strWhereCond)
{
DataTable objDT;
try
{
objDT = CurrEduClsStuDA.GetDataTable_CurrEduClsStu(strWhereCond);
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
objDT = CurrEduClsStuDA.GetDataTable(strWhereCond);
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
objDT = CurrEduClsStuDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = CurrEduClsStuDA.GetDataTable(strWhereCond, strTabName);
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
objDT = CurrEduClsStuDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = CurrEduClsStuDA.GetDataTable_Top(objTopPara);
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
objDT = CurrEduClsStuDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = CurrEduClsStuDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = CurrEduClsStuDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdEduClsStuLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsCurrEduClsStuEN> GetObjLstByIdEduClsStuLst(List<long> arrIdEduClsStuLst)
{
List<clsCurrEduClsStuEN> arrObjLst = new List<clsCurrEduClsStuEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdEduClsStuLst);
 string strWhereCond = string.Format("IdEduClsStu in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduClsStuEN objCurrEduClsStuEN = new clsCurrEduClsStuEN();
try
{
objCurrEduClsStuEN.IdEduClsStu = Int32.Parse(objRow[conCurrEduClsStu.IdEduClsStu].ToString().Trim()); //教学班学生流水号
objCurrEduClsStuEN.IdCurrEduCls = objRow[conCurrEduClsStu.IdCurrEduCls] == DBNull.Value ? null : objRow[conCurrEduClsStu.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsStuEN.IdStu = objRow[conCurrEduClsStu.IdStu] == DBNull.Value ? null : objRow[conCurrEduClsStu.IdStu].ToString().Trim(); //学生流水号
objCurrEduClsStuEN.EduClsStuStateId = objRow[conCurrEduClsStu.EduClsStuStateId] == DBNull.Value ? null : objRow[conCurrEduClsStu.EduClsStuStateId].ToString().Trim(); //教学班学生状态编号
objCurrEduClsStuEN.GetScoreTimes = objRow[conCurrEduClsStu.GetScoreTimes] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduClsStu.GetScoreTimes].ToString().Trim()); //获得成绩次数
objCurrEduClsStuEN.Score = objRow[conCurrEduClsStu.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.Score].ToString().Trim()); //得分
objCurrEduClsStuEN.TotalScores = objRow[conCurrEduClsStu.TotalScores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.TotalScores].ToString().Trim()); //总分值
objCurrEduClsStuEN.Ranking = objRow[conCurrEduClsStu.Ranking] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduClsStu.Ranking].ToString().Trim()); //名次
objCurrEduClsStuEN.Percentile = objRow[conCurrEduClsStu.Percentile] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.Percentile].ToString().Trim()); //百分位
objCurrEduClsStuEN.Ranking2 = objRow[conCurrEduClsStu.Ranking2] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduClsStu.Ranking2].ToString().Trim()); //Ranking2
objCurrEduClsStuEN.Percentile2 = objRow[conCurrEduClsStu.Percentile2] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.Percentile2].ToString().Trim()); //Percentile2
objCurrEduClsStuEN.Ranking3 = objRow[conCurrEduClsStu.Ranking3] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduClsStu.Ranking3].ToString().Trim()); //Ranking3
objCurrEduClsStuEN.Percentile3 = objRow[conCurrEduClsStu.Percentile3] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.Percentile3].ToString().Trim()); //Percentile3
objCurrEduClsStuEN.Confirmed = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduClsStu.Confirmed].ToString().Trim()); //是否确认
objCurrEduClsStuEN.SchoolTerm = objRow[conCurrEduClsStu.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduClsStu.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsStuEN.SchoolYear = objRow[conCurrEduClsStu.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduClsStu.SchoolYear].ToString().Trim(); //学年
objCurrEduClsStuEN.ExportDate = objRow[conCurrEduClsStu.ExportDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.ExportDate].ToString().Trim(); //导出日期
objCurrEduClsStuEN.SignInDate = objRow[conCurrEduClsStu.SignInDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.SignInDate].ToString().Trim(); //签入时间
objCurrEduClsStuEN.SignInStateID = objRow[conCurrEduClsStu.SignInStateID] == DBNull.Value ? null : objRow[conCurrEduClsStu.SignInStateID].ToString().Trim(); //签入状态表流水号
objCurrEduClsStuEN.SignInUser = objRow[conCurrEduClsStu.SignInUser] == DBNull.Value ? null : objRow[conCurrEduClsStu.SignInUser].ToString().Trim(); //签入人
objCurrEduClsStuEN.IsOpByTeacher = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduClsStu.IsOpByTeacher].ToString().Trim()); //是否教师操作
objCurrEduClsStuEN.IsSynScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduClsStu.IsSynScore].ToString().Trim()); //是否同步成绩
objCurrEduClsStuEN.LastVisitedDate = objRow[conCurrEduClsStu.LastVisitedDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.LastVisitedDate].ToString().Trim(); //最后访问时间
objCurrEduClsStuEN.ModifyDate = objRow[conCurrEduClsStu.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.ModifyDate].ToString().Trim(); //修改日期
objCurrEduClsStuEN.ModifyUserId = objRow[conCurrEduClsStu.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduClsStu.ModifyUserId].ToString().Trim(); //修改人
objCurrEduClsStuEN.Memo = objRow[conCurrEduClsStu.Memo] == DBNull.Value ? null : objRow[conCurrEduClsStu.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduClsStuEN.IdEduClsStu, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduClsStuEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdEduClsStuLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsCurrEduClsStuEN> GetObjLstByIdEduClsStuLstCache(List<long> arrIdEduClsStuLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsCurrEduClsStuEN._CurrTabName, strIdCurrEduCls);
List<clsCurrEduClsStuEN> arrCurrEduClsStuObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsCurrEduClsStuEN> arrCurrEduClsStuObjLst_Sel =
arrCurrEduClsStuObjLstCache
.Where(x => arrIdEduClsStuLst.Contains(x.IdEduClsStu));
return arrCurrEduClsStuObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCurrEduClsStuEN> GetObjLst(string strWhereCond)
{
List<clsCurrEduClsStuEN> arrObjLst = new List<clsCurrEduClsStuEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduClsStuEN objCurrEduClsStuEN = new clsCurrEduClsStuEN();
try
{
objCurrEduClsStuEN.IdEduClsStu = Int32.Parse(objRow[conCurrEduClsStu.IdEduClsStu].ToString().Trim()); //教学班学生流水号
objCurrEduClsStuEN.IdCurrEduCls = objRow[conCurrEduClsStu.IdCurrEduCls] == DBNull.Value ? null : objRow[conCurrEduClsStu.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsStuEN.IdStu = objRow[conCurrEduClsStu.IdStu] == DBNull.Value ? null : objRow[conCurrEduClsStu.IdStu].ToString().Trim(); //学生流水号
objCurrEduClsStuEN.EduClsStuStateId = objRow[conCurrEduClsStu.EduClsStuStateId] == DBNull.Value ? null : objRow[conCurrEduClsStu.EduClsStuStateId].ToString().Trim(); //教学班学生状态编号
objCurrEduClsStuEN.GetScoreTimes = objRow[conCurrEduClsStu.GetScoreTimes] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduClsStu.GetScoreTimes].ToString().Trim()); //获得成绩次数
objCurrEduClsStuEN.Score = objRow[conCurrEduClsStu.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.Score].ToString().Trim()); //得分
objCurrEduClsStuEN.TotalScores = objRow[conCurrEduClsStu.TotalScores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.TotalScores].ToString().Trim()); //总分值
objCurrEduClsStuEN.Ranking = objRow[conCurrEduClsStu.Ranking] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduClsStu.Ranking].ToString().Trim()); //名次
objCurrEduClsStuEN.Percentile = objRow[conCurrEduClsStu.Percentile] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.Percentile].ToString().Trim()); //百分位
objCurrEduClsStuEN.Ranking2 = objRow[conCurrEduClsStu.Ranking2] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduClsStu.Ranking2].ToString().Trim()); //Ranking2
objCurrEduClsStuEN.Percentile2 = objRow[conCurrEduClsStu.Percentile2] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.Percentile2].ToString().Trim()); //Percentile2
objCurrEduClsStuEN.Ranking3 = objRow[conCurrEduClsStu.Ranking3] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduClsStu.Ranking3].ToString().Trim()); //Ranking3
objCurrEduClsStuEN.Percentile3 = objRow[conCurrEduClsStu.Percentile3] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.Percentile3].ToString().Trim()); //Percentile3
objCurrEduClsStuEN.Confirmed = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduClsStu.Confirmed].ToString().Trim()); //是否确认
objCurrEduClsStuEN.SchoolTerm = objRow[conCurrEduClsStu.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduClsStu.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsStuEN.SchoolYear = objRow[conCurrEduClsStu.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduClsStu.SchoolYear].ToString().Trim(); //学年
objCurrEduClsStuEN.ExportDate = objRow[conCurrEduClsStu.ExportDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.ExportDate].ToString().Trim(); //导出日期
objCurrEduClsStuEN.SignInDate = objRow[conCurrEduClsStu.SignInDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.SignInDate].ToString().Trim(); //签入时间
objCurrEduClsStuEN.SignInStateID = objRow[conCurrEduClsStu.SignInStateID] == DBNull.Value ? null : objRow[conCurrEduClsStu.SignInStateID].ToString().Trim(); //签入状态表流水号
objCurrEduClsStuEN.SignInUser = objRow[conCurrEduClsStu.SignInUser] == DBNull.Value ? null : objRow[conCurrEduClsStu.SignInUser].ToString().Trim(); //签入人
objCurrEduClsStuEN.IsOpByTeacher = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduClsStu.IsOpByTeacher].ToString().Trim()); //是否教师操作
objCurrEduClsStuEN.IsSynScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduClsStu.IsSynScore].ToString().Trim()); //是否同步成绩
objCurrEduClsStuEN.LastVisitedDate = objRow[conCurrEduClsStu.LastVisitedDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.LastVisitedDate].ToString().Trim(); //最后访问时间
objCurrEduClsStuEN.ModifyDate = objRow[conCurrEduClsStu.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.ModifyDate].ToString().Trim(); //修改日期
objCurrEduClsStuEN.ModifyUserId = objRow[conCurrEduClsStu.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduClsStu.ModifyUserId].ToString().Trim(); //修改人
objCurrEduClsStuEN.Memo = objRow[conCurrEduClsStu.Memo] == DBNull.Value ? null : objRow[conCurrEduClsStu.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduClsStuEN.IdEduClsStu, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduClsStuEN);
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
public static List<clsCurrEduClsStuEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsCurrEduClsStuEN> arrObjLst = new List<clsCurrEduClsStuEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduClsStuEN objCurrEduClsStuEN = new clsCurrEduClsStuEN();
try
{
objCurrEduClsStuEN.IdEduClsStu = Int32.Parse(objRow[conCurrEduClsStu.IdEduClsStu].ToString().Trim()); //教学班学生流水号
objCurrEduClsStuEN.IdCurrEduCls = objRow[conCurrEduClsStu.IdCurrEduCls] == DBNull.Value ? null : objRow[conCurrEduClsStu.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsStuEN.IdStu = objRow[conCurrEduClsStu.IdStu] == DBNull.Value ? null : objRow[conCurrEduClsStu.IdStu].ToString().Trim(); //学生流水号
objCurrEduClsStuEN.EduClsStuStateId = objRow[conCurrEduClsStu.EduClsStuStateId] == DBNull.Value ? null : objRow[conCurrEduClsStu.EduClsStuStateId].ToString().Trim(); //教学班学生状态编号
objCurrEduClsStuEN.GetScoreTimes = objRow[conCurrEduClsStu.GetScoreTimes] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduClsStu.GetScoreTimes].ToString().Trim()); //获得成绩次数
objCurrEduClsStuEN.Score = objRow[conCurrEduClsStu.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.Score].ToString().Trim()); //得分
objCurrEduClsStuEN.TotalScores = objRow[conCurrEduClsStu.TotalScores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.TotalScores].ToString().Trim()); //总分值
objCurrEduClsStuEN.Ranking = objRow[conCurrEduClsStu.Ranking] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduClsStu.Ranking].ToString().Trim()); //名次
objCurrEduClsStuEN.Percentile = objRow[conCurrEduClsStu.Percentile] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.Percentile].ToString().Trim()); //百分位
objCurrEduClsStuEN.Ranking2 = objRow[conCurrEduClsStu.Ranking2] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduClsStu.Ranking2].ToString().Trim()); //Ranking2
objCurrEduClsStuEN.Percentile2 = objRow[conCurrEduClsStu.Percentile2] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.Percentile2].ToString().Trim()); //Percentile2
objCurrEduClsStuEN.Ranking3 = objRow[conCurrEduClsStu.Ranking3] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduClsStu.Ranking3].ToString().Trim()); //Ranking3
objCurrEduClsStuEN.Percentile3 = objRow[conCurrEduClsStu.Percentile3] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.Percentile3].ToString().Trim()); //Percentile3
objCurrEduClsStuEN.Confirmed = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduClsStu.Confirmed].ToString().Trim()); //是否确认
objCurrEduClsStuEN.SchoolTerm = objRow[conCurrEduClsStu.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduClsStu.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsStuEN.SchoolYear = objRow[conCurrEduClsStu.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduClsStu.SchoolYear].ToString().Trim(); //学年
objCurrEduClsStuEN.ExportDate = objRow[conCurrEduClsStu.ExportDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.ExportDate].ToString().Trim(); //导出日期
objCurrEduClsStuEN.SignInDate = objRow[conCurrEduClsStu.SignInDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.SignInDate].ToString().Trim(); //签入时间
objCurrEduClsStuEN.SignInStateID = objRow[conCurrEduClsStu.SignInStateID] == DBNull.Value ? null : objRow[conCurrEduClsStu.SignInStateID].ToString().Trim(); //签入状态表流水号
objCurrEduClsStuEN.SignInUser = objRow[conCurrEduClsStu.SignInUser] == DBNull.Value ? null : objRow[conCurrEduClsStu.SignInUser].ToString().Trim(); //签入人
objCurrEduClsStuEN.IsOpByTeacher = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduClsStu.IsOpByTeacher].ToString().Trim()); //是否教师操作
objCurrEduClsStuEN.IsSynScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduClsStu.IsSynScore].ToString().Trim()); //是否同步成绩
objCurrEduClsStuEN.LastVisitedDate = objRow[conCurrEduClsStu.LastVisitedDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.LastVisitedDate].ToString().Trim(); //最后访问时间
objCurrEduClsStuEN.ModifyDate = objRow[conCurrEduClsStu.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.ModifyDate].ToString().Trim(); //修改日期
objCurrEduClsStuEN.ModifyUserId = objRow[conCurrEduClsStu.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduClsStu.ModifyUserId].ToString().Trim(); //修改人
objCurrEduClsStuEN.Memo = objRow[conCurrEduClsStu.Memo] == DBNull.Value ? null : objRow[conCurrEduClsStu.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduClsStuEN.IdEduClsStu, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduClsStuEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objCurrEduClsStuCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsCurrEduClsStuEN> GetSubObjLstCache(clsCurrEduClsStuEN objCurrEduClsStuCond)
{
 string strIdCurrEduCls = objCurrEduClsStuCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsCurrEduClsStuBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsCurrEduClsStuEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsCurrEduClsStuEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCurrEduClsStu.AttributeName)
{
if (objCurrEduClsStuCond.IsUpdated(strFldName) == false) continue;
if (objCurrEduClsStuCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCurrEduClsStuCond[strFldName].ToString());
}
else
{
if (objCurrEduClsStuCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCurrEduClsStuCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCurrEduClsStuCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCurrEduClsStuCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCurrEduClsStuCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCurrEduClsStuCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCurrEduClsStuCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCurrEduClsStuCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCurrEduClsStuCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCurrEduClsStuCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCurrEduClsStuCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCurrEduClsStuCond[strFldName]));
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
public static List<clsCurrEduClsStuEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsCurrEduClsStuEN> arrObjLst = new List<clsCurrEduClsStuEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduClsStuEN objCurrEduClsStuEN = new clsCurrEduClsStuEN();
try
{
objCurrEduClsStuEN.IdEduClsStu = Int32.Parse(objRow[conCurrEduClsStu.IdEduClsStu].ToString().Trim()); //教学班学生流水号
objCurrEduClsStuEN.IdCurrEduCls = objRow[conCurrEduClsStu.IdCurrEduCls] == DBNull.Value ? null : objRow[conCurrEduClsStu.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsStuEN.IdStu = objRow[conCurrEduClsStu.IdStu] == DBNull.Value ? null : objRow[conCurrEduClsStu.IdStu].ToString().Trim(); //学生流水号
objCurrEduClsStuEN.EduClsStuStateId = objRow[conCurrEduClsStu.EduClsStuStateId] == DBNull.Value ? null : objRow[conCurrEduClsStu.EduClsStuStateId].ToString().Trim(); //教学班学生状态编号
objCurrEduClsStuEN.GetScoreTimes = objRow[conCurrEduClsStu.GetScoreTimes] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduClsStu.GetScoreTimes].ToString().Trim()); //获得成绩次数
objCurrEduClsStuEN.Score = objRow[conCurrEduClsStu.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.Score].ToString().Trim()); //得分
objCurrEduClsStuEN.TotalScores = objRow[conCurrEduClsStu.TotalScores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.TotalScores].ToString().Trim()); //总分值
objCurrEduClsStuEN.Ranking = objRow[conCurrEduClsStu.Ranking] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduClsStu.Ranking].ToString().Trim()); //名次
objCurrEduClsStuEN.Percentile = objRow[conCurrEduClsStu.Percentile] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.Percentile].ToString().Trim()); //百分位
objCurrEduClsStuEN.Ranking2 = objRow[conCurrEduClsStu.Ranking2] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduClsStu.Ranking2].ToString().Trim()); //Ranking2
objCurrEduClsStuEN.Percentile2 = objRow[conCurrEduClsStu.Percentile2] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.Percentile2].ToString().Trim()); //Percentile2
objCurrEduClsStuEN.Ranking3 = objRow[conCurrEduClsStu.Ranking3] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduClsStu.Ranking3].ToString().Trim()); //Ranking3
objCurrEduClsStuEN.Percentile3 = objRow[conCurrEduClsStu.Percentile3] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.Percentile3].ToString().Trim()); //Percentile3
objCurrEduClsStuEN.Confirmed = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduClsStu.Confirmed].ToString().Trim()); //是否确认
objCurrEduClsStuEN.SchoolTerm = objRow[conCurrEduClsStu.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduClsStu.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsStuEN.SchoolYear = objRow[conCurrEduClsStu.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduClsStu.SchoolYear].ToString().Trim(); //学年
objCurrEduClsStuEN.ExportDate = objRow[conCurrEduClsStu.ExportDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.ExportDate].ToString().Trim(); //导出日期
objCurrEduClsStuEN.SignInDate = objRow[conCurrEduClsStu.SignInDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.SignInDate].ToString().Trim(); //签入时间
objCurrEduClsStuEN.SignInStateID = objRow[conCurrEduClsStu.SignInStateID] == DBNull.Value ? null : objRow[conCurrEduClsStu.SignInStateID].ToString().Trim(); //签入状态表流水号
objCurrEduClsStuEN.SignInUser = objRow[conCurrEduClsStu.SignInUser] == DBNull.Value ? null : objRow[conCurrEduClsStu.SignInUser].ToString().Trim(); //签入人
objCurrEduClsStuEN.IsOpByTeacher = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduClsStu.IsOpByTeacher].ToString().Trim()); //是否教师操作
objCurrEduClsStuEN.IsSynScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduClsStu.IsSynScore].ToString().Trim()); //是否同步成绩
objCurrEduClsStuEN.LastVisitedDate = objRow[conCurrEduClsStu.LastVisitedDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.LastVisitedDate].ToString().Trim(); //最后访问时间
objCurrEduClsStuEN.ModifyDate = objRow[conCurrEduClsStu.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.ModifyDate].ToString().Trim(); //修改日期
objCurrEduClsStuEN.ModifyUserId = objRow[conCurrEduClsStu.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduClsStu.ModifyUserId].ToString().Trim(); //修改人
objCurrEduClsStuEN.Memo = objRow[conCurrEduClsStu.Memo] == DBNull.Value ? null : objRow[conCurrEduClsStu.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduClsStuEN.IdEduClsStu, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduClsStuEN);
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
public static List<clsCurrEduClsStuEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsCurrEduClsStuEN> arrObjLst = new List<clsCurrEduClsStuEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduClsStuEN objCurrEduClsStuEN = new clsCurrEduClsStuEN();
try
{
objCurrEduClsStuEN.IdEduClsStu = Int32.Parse(objRow[conCurrEduClsStu.IdEduClsStu].ToString().Trim()); //教学班学生流水号
objCurrEduClsStuEN.IdCurrEduCls = objRow[conCurrEduClsStu.IdCurrEduCls] == DBNull.Value ? null : objRow[conCurrEduClsStu.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsStuEN.IdStu = objRow[conCurrEduClsStu.IdStu] == DBNull.Value ? null : objRow[conCurrEduClsStu.IdStu].ToString().Trim(); //学生流水号
objCurrEduClsStuEN.EduClsStuStateId = objRow[conCurrEduClsStu.EduClsStuStateId] == DBNull.Value ? null : objRow[conCurrEduClsStu.EduClsStuStateId].ToString().Trim(); //教学班学生状态编号
objCurrEduClsStuEN.GetScoreTimes = objRow[conCurrEduClsStu.GetScoreTimes] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduClsStu.GetScoreTimes].ToString().Trim()); //获得成绩次数
objCurrEduClsStuEN.Score = objRow[conCurrEduClsStu.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.Score].ToString().Trim()); //得分
objCurrEduClsStuEN.TotalScores = objRow[conCurrEduClsStu.TotalScores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.TotalScores].ToString().Trim()); //总分值
objCurrEduClsStuEN.Ranking = objRow[conCurrEduClsStu.Ranking] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduClsStu.Ranking].ToString().Trim()); //名次
objCurrEduClsStuEN.Percentile = objRow[conCurrEduClsStu.Percentile] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.Percentile].ToString().Trim()); //百分位
objCurrEduClsStuEN.Ranking2 = objRow[conCurrEduClsStu.Ranking2] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduClsStu.Ranking2].ToString().Trim()); //Ranking2
objCurrEduClsStuEN.Percentile2 = objRow[conCurrEduClsStu.Percentile2] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.Percentile2].ToString().Trim()); //Percentile2
objCurrEduClsStuEN.Ranking3 = objRow[conCurrEduClsStu.Ranking3] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduClsStu.Ranking3].ToString().Trim()); //Ranking3
objCurrEduClsStuEN.Percentile3 = objRow[conCurrEduClsStu.Percentile3] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.Percentile3].ToString().Trim()); //Percentile3
objCurrEduClsStuEN.Confirmed = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduClsStu.Confirmed].ToString().Trim()); //是否确认
objCurrEduClsStuEN.SchoolTerm = objRow[conCurrEduClsStu.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduClsStu.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsStuEN.SchoolYear = objRow[conCurrEduClsStu.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduClsStu.SchoolYear].ToString().Trim(); //学年
objCurrEduClsStuEN.ExportDate = objRow[conCurrEduClsStu.ExportDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.ExportDate].ToString().Trim(); //导出日期
objCurrEduClsStuEN.SignInDate = objRow[conCurrEduClsStu.SignInDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.SignInDate].ToString().Trim(); //签入时间
objCurrEduClsStuEN.SignInStateID = objRow[conCurrEduClsStu.SignInStateID] == DBNull.Value ? null : objRow[conCurrEduClsStu.SignInStateID].ToString().Trim(); //签入状态表流水号
objCurrEduClsStuEN.SignInUser = objRow[conCurrEduClsStu.SignInUser] == DBNull.Value ? null : objRow[conCurrEduClsStu.SignInUser].ToString().Trim(); //签入人
objCurrEduClsStuEN.IsOpByTeacher = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduClsStu.IsOpByTeacher].ToString().Trim()); //是否教师操作
objCurrEduClsStuEN.IsSynScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduClsStu.IsSynScore].ToString().Trim()); //是否同步成绩
objCurrEduClsStuEN.LastVisitedDate = objRow[conCurrEduClsStu.LastVisitedDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.LastVisitedDate].ToString().Trim(); //最后访问时间
objCurrEduClsStuEN.ModifyDate = objRow[conCurrEduClsStu.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.ModifyDate].ToString().Trim(); //修改日期
objCurrEduClsStuEN.ModifyUserId = objRow[conCurrEduClsStu.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduClsStu.ModifyUserId].ToString().Trim(); //修改人
objCurrEduClsStuEN.Memo = objRow[conCurrEduClsStu.Memo] == DBNull.Value ? null : objRow[conCurrEduClsStu.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduClsStuEN.IdEduClsStu, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduClsStuEN);
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
List<clsCurrEduClsStuEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsCurrEduClsStuEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsCurrEduClsStuEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsCurrEduClsStuEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsCurrEduClsStuEN> arrObjLst = new List<clsCurrEduClsStuEN>(); 
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
	clsCurrEduClsStuEN objCurrEduClsStuEN = new clsCurrEduClsStuEN();
try
{
objCurrEduClsStuEN.IdEduClsStu = Int32.Parse(objRow[conCurrEduClsStu.IdEduClsStu].ToString().Trim()); //教学班学生流水号
objCurrEduClsStuEN.IdCurrEduCls = objRow[conCurrEduClsStu.IdCurrEduCls] == DBNull.Value ? null : objRow[conCurrEduClsStu.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsStuEN.IdStu = objRow[conCurrEduClsStu.IdStu] == DBNull.Value ? null : objRow[conCurrEduClsStu.IdStu].ToString().Trim(); //学生流水号
objCurrEduClsStuEN.EduClsStuStateId = objRow[conCurrEduClsStu.EduClsStuStateId] == DBNull.Value ? null : objRow[conCurrEduClsStu.EduClsStuStateId].ToString().Trim(); //教学班学生状态编号
objCurrEduClsStuEN.GetScoreTimes = objRow[conCurrEduClsStu.GetScoreTimes] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduClsStu.GetScoreTimes].ToString().Trim()); //获得成绩次数
objCurrEduClsStuEN.Score = objRow[conCurrEduClsStu.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.Score].ToString().Trim()); //得分
objCurrEduClsStuEN.TotalScores = objRow[conCurrEduClsStu.TotalScores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.TotalScores].ToString().Trim()); //总分值
objCurrEduClsStuEN.Ranking = objRow[conCurrEduClsStu.Ranking] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduClsStu.Ranking].ToString().Trim()); //名次
objCurrEduClsStuEN.Percentile = objRow[conCurrEduClsStu.Percentile] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.Percentile].ToString().Trim()); //百分位
objCurrEduClsStuEN.Ranking2 = objRow[conCurrEduClsStu.Ranking2] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduClsStu.Ranking2].ToString().Trim()); //Ranking2
objCurrEduClsStuEN.Percentile2 = objRow[conCurrEduClsStu.Percentile2] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.Percentile2].ToString().Trim()); //Percentile2
objCurrEduClsStuEN.Ranking3 = objRow[conCurrEduClsStu.Ranking3] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduClsStu.Ranking3].ToString().Trim()); //Ranking3
objCurrEduClsStuEN.Percentile3 = objRow[conCurrEduClsStu.Percentile3] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.Percentile3].ToString().Trim()); //Percentile3
objCurrEduClsStuEN.Confirmed = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduClsStu.Confirmed].ToString().Trim()); //是否确认
objCurrEduClsStuEN.SchoolTerm = objRow[conCurrEduClsStu.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduClsStu.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsStuEN.SchoolYear = objRow[conCurrEduClsStu.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduClsStu.SchoolYear].ToString().Trim(); //学年
objCurrEduClsStuEN.ExportDate = objRow[conCurrEduClsStu.ExportDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.ExportDate].ToString().Trim(); //导出日期
objCurrEduClsStuEN.SignInDate = objRow[conCurrEduClsStu.SignInDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.SignInDate].ToString().Trim(); //签入时间
objCurrEduClsStuEN.SignInStateID = objRow[conCurrEduClsStu.SignInStateID] == DBNull.Value ? null : objRow[conCurrEduClsStu.SignInStateID].ToString().Trim(); //签入状态表流水号
objCurrEduClsStuEN.SignInUser = objRow[conCurrEduClsStu.SignInUser] == DBNull.Value ? null : objRow[conCurrEduClsStu.SignInUser].ToString().Trim(); //签入人
objCurrEduClsStuEN.IsOpByTeacher = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduClsStu.IsOpByTeacher].ToString().Trim()); //是否教师操作
objCurrEduClsStuEN.IsSynScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduClsStu.IsSynScore].ToString().Trim()); //是否同步成绩
objCurrEduClsStuEN.LastVisitedDate = objRow[conCurrEduClsStu.LastVisitedDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.LastVisitedDate].ToString().Trim(); //最后访问时间
objCurrEduClsStuEN.ModifyDate = objRow[conCurrEduClsStu.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.ModifyDate].ToString().Trim(); //修改日期
objCurrEduClsStuEN.ModifyUserId = objRow[conCurrEduClsStu.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduClsStu.ModifyUserId].ToString().Trim(); //修改人
objCurrEduClsStuEN.Memo = objRow[conCurrEduClsStu.Memo] == DBNull.Value ? null : objRow[conCurrEduClsStu.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduClsStuEN.IdEduClsStu, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduClsStuEN);
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
public static List<clsCurrEduClsStuEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsCurrEduClsStuEN> arrObjLst = new List<clsCurrEduClsStuEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduClsStuEN objCurrEduClsStuEN = new clsCurrEduClsStuEN();
try
{
objCurrEduClsStuEN.IdEduClsStu = Int32.Parse(objRow[conCurrEduClsStu.IdEduClsStu].ToString().Trim()); //教学班学生流水号
objCurrEduClsStuEN.IdCurrEduCls = objRow[conCurrEduClsStu.IdCurrEduCls] == DBNull.Value ? null : objRow[conCurrEduClsStu.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsStuEN.IdStu = objRow[conCurrEduClsStu.IdStu] == DBNull.Value ? null : objRow[conCurrEduClsStu.IdStu].ToString().Trim(); //学生流水号
objCurrEduClsStuEN.EduClsStuStateId = objRow[conCurrEduClsStu.EduClsStuStateId] == DBNull.Value ? null : objRow[conCurrEduClsStu.EduClsStuStateId].ToString().Trim(); //教学班学生状态编号
objCurrEduClsStuEN.GetScoreTimes = objRow[conCurrEduClsStu.GetScoreTimes] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduClsStu.GetScoreTimes].ToString().Trim()); //获得成绩次数
objCurrEduClsStuEN.Score = objRow[conCurrEduClsStu.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.Score].ToString().Trim()); //得分
objCurrEduClsStuEN.TotalScores = objRow[conCurrEduClsStu.TotalScores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.TotalScores].ToString().Trim()); //总分值
objCurrEduClsStuEN.Ranking = objRow[conCurrEduClsStu.Ranking] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduClsStu.Ranking].ToString().Trim()); //名次
objCurrEduClsStuEN.Percentile = objRow[conCurrEduClsStu.Percentile] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.Percentile].ToString().Trim()); //百分位
objCurrEduClsStuEN.Ranking2 = objRow[conCurrEduClsStu.Ranking2] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduClsStu.Ranking2].ToString().Trim()); //Ranking2
objCurrEduClsStuEN.Percentile2 = objRow[conCurrEduClsStu.Percentile2] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.Percentile2].ToString().Trim()); //Percentile2
objCurrEduClsStuEN.Ranking3 = objRow[conCurrEduClsStu.Ranking3] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduClsStu.Ranking3].ToString().Trim()); //Ranking3
objCurrEduClsStuEN.Percentile3 = objRow[conCurrEduClsStu.Percentile3] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.Percentile3].ToString().Trim()); //Percentile3
objCurrEduClsStuEN.Confirmed = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduClsStu.Confirmed].ToString().Trim()); //是否确认
objCurrEduClsStuEN.SchoolTerm = objRow[conCurrEduClsStu.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduClsStu.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsStuEN.SchoolYear = objRow[conCurrEduClsStu.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduClsStu.SchoolYear].ToString().Trim(); //学年
objCurrEduClsStuEN.ExportDate = objRow[conCurrEduClsStu.ExportDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.ExportDate].ToString().Trim(); //导出日期
objCurrEduClsStuEN.SignInDate = objRow[conCurrEduClsStu.SignInDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.SignInDate].ToString().Trim(); //签入时间
objCurrEduClsStuEN.SignInStateID = objRow[conCurrEduClsStu.SignInStateID] == DBNull.Value ? null : objRow[conCurrEduClsStu.SignInStateID].ToString().Trim(); //签入状态表流水号
objCurrEduClsStuEN.SignInUser = objRow[conCurrEduClsStu.SignInUser] == DBNull.Value ? null : objRow[conCurrEduClsStu.SignInUser].ToString().Trim(); //签入人
objCurrEduClsStuEN.IsOpByTeacher = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduClsStu.IsOpByTeacher].ToString().Trim()); //是否教师操作
objCurrEduClsStuEN.IsSynScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduClsStu.IsSynScore].ToString().Trim()); //是否同步成绩
objCurrEduClsStuEN.LastVisitedDate = objRow[conCurrEduClsStu.LastVisitedDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.LastVisitedDate].ToString().Trim(); //最后访问时间
objCurrEduClsStuEN.ModifyDate = objRow[conCurrEduClsStu.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.ModifyDate].ToString().Trim(); //修改日期
objCurrEduClsStuEN.ModifyUserId = objRow[conCurrEduClsStu.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduClsStu.ModifyUserId].ToString().Trim(); //修改人
objCurrEduClsStuEN.Memo = objRow[conCurrEduClsStu.Memo] == DBNull.Value ? null : objRow[conCurrEduClsStu.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduClsStuEN.IdEduClsStu, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduClsStuEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsCurrEduClsStuEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsCurrEduClsStuEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsCurrEduClsStuEN> arrObjLst = new List<clsCurrEduClsStuEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduClsStuEN objCurrEduClsStuEN = new clsCurrEduClsStuEN();
try
{
objCurrEduClsStuEN.IdEduClsStu = Int32.Parse(objRow[conCurrEduClsStu.IdEduClsStu].ToString().Trim()); //教学班学生流水号
objCurrEduClsStuEN.IdCurrEduCls = objRow[conCurrEduClsStu.IdCurrEduCls] == DBNull.Value ? null : objRow[conCurrEduClsStu.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsStuEN.IdStu = objRow[conCurrEduClsStu.IdStu] == DBNull.Value ? null : objRow[conCurrEduClsStu.IdStu].ToString().Trim(); //学生流水号
objCurrEduClsStuEN.EduClsStuStateId = objRow[conCurrEduClsStu.EduClsStuStateId] == DBNull.Value ? null : objRow[conCurrEduClsStu.EduClsStuStateId].ToString().Trim(); //教学班学生状态编号
objCurrEduClsStuEN.GetScoreTimes = objRow[conCurrEduClsStu.GetScoreTimes] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduClsStu.GetScoreTimes].ToString().Trim()); //获得成绩次数
objCurrEduClsStuEN.Score = objRow[conCurrEduClsStu.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.Score].ToString().Trim()); //得分
objCurrEduClsStuEN.TotalScores = objRow[conCurrEduClsStu.TotalScores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.TotalScores].ToString().Trim()); //总分值
objCurrEduClsStuEN.Ranking = objRow[conCurrEduClsStu.Ranking] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduClsStu.Ranking].ToString().Trim()); //名次
objCurrEduClsStuEN.Percentile = objRow[conCurrEduClsStu.Percentile] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.Percentile].ToString().Trim()); //百分位
objCurrEduClsStuEN.Ranking2 = objRow[conCurrEduClsStu.Ranking2] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduClsStu.Ranking2].ToString().Trim()); //Ranking2
objCurrEduClsStuEN.Percentile2 = objRow[conCurrEduClsStu.Percentile2] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.Percentile2].ToString().Trim()); //Percentile2
objCurrEduClsStuEN.Ranking3 = objRow[conCurrEduClsStu.Ranking3] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduClsStu.Ranking3].ToString().Trim()); //Ranking3
objCurrEduClsStuEN.Percentile3 = objRow[conCurrEduClsStu.Percentile3] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.Percentile3].ToString().Trim()); //Percentile3
objCurrEduClsStuEN.Confirmed = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduClsStu.Confirmed].ToString().Trim()); //是否确认
objCurrEduClsStuEN.SchoolTerm = objRow[conCurrEduClsStu.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduClsStu.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsStuEN.SchoolYear = objRow[conCurrEduClsStu.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduClsStu.SchoolYear].ToString().Trim(); //学年
objCurrEduClsStuEN.ExportDate = objRow[conCurrEduClsStu.ExportDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.ExportDate].ToString().Trim(); //导出日期
objCurrEduClsStuEN.SignInDate = objRow[conCurrEduClsStu.SignInDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.SignInDate].ToString().Trim(); //签入时间
objCurrEduClsStuEN.SignInStateID = objRow[conCurrEduClsStu.SignInStateID] == DBNull.Value ? null : objRow[conCurrEduClsStu.SignInStateID].ToString().Trim(); //签入状态表流水号
objCurrEduClsStuEN.SignInUser = objRow[conCurrEduClsStu.SignInUser] == DBNull.Value ? null : objRow[conCurrEduClsStu.SignInUser].ToString().Trim(); //签入人
objCurrEduClsStuEN.IsOpByTeacher = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduClsStu.IsOpByTeacher].ToString().Trim()); //是否教师操作
objCurrEduClsStuEN.IsSynScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduClsStu.IsSynScore].ToString().Trim()); //是否同步成绩
objCurrEduClsStuEN.LastVisitedDate = objRow[conCurrEduClsStu.LastVisitedDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.LastVisitedDate].ToString().Trim(); //最后访问时间
objCurrEduClsStuEN.ModifyDate = objRow[conCurrEduClsStu.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.ModifyDate].ToString().Trim(); //修改日期
objCurrEduClsStuEN.ModifyUserId = objRow[conCurrEduClsStu.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduClsStu.ModifyUserId].ToString().Trim(); //修改人
objCurrEduClsStuEN.Memo = objRow[conCurrEduClsStu.Memo] == DBNull.Value ? null : objRow[conCurrEduClsStu.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduClsStuEN.IdEduClsStu, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduClsStuEN);
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
public static List<clsCurrEduClsStuEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsCurrEduClsStuEN> arrObjLst = new List<clsCurrEduClsStuEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduClsStuEN objCurrEduClsStuEN = new clsCurrEduClsStuEN();
try
{
objCurrEduClsStuEN.IdEduClsStu = Int32.Parse(objRow[conCurrEduClsStu.IdEduClsStu].ToString().Trim()); //教学班学生流水号
objCurrEduClsStuEN.IdCurrEduCls = objRow[conCurrEduClsStu.IdCurrEduCls] == DBNull.Value ? null : objRow[conCurrEduClsStu.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsStuEN.IdStu = objRow[conCurrEduClsStu.IdStu] == DBNull.Value ? null : objRow[conCurrEduClsStu.IdStu].ToString().Trim(); //学生流水号
objCurrEduClsStuEN.EduClsStuStateId = objRow[conCurrEduClsStu.EduClsStuStateId] == DBNull.Value ? null : objRow[conCurrEduClsStu.EduClsStuStateId].ToString().Trim(); //教学班学生状态编号
objCurrEduClsStuEN.GetScoreTimes = objRow[conCurrEduClsStu.GetScoreTimes] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduClsStu.GetScoreTimes].ToString().Trim()); //获得成绩次数
objCurrEduClsStuEN.Score = objRow[conCurrEduClsStu.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.Score].ToString().Trim()); //得分
objCurrEduClsStuEN.TotalScores = objRow[conCurrEduClsStu.TotalScores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.TotalScores].ToString().Trim()); //总分值
objCurrEduClsStuEN.Ranking = objRow[conCurrEduClsStu.Ranking] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduClsStu.Ranking].ToString().Trim()); //名次
objCurrEduClsStuEN.Percentile = objRow[conCurrEduClsStu.Percentile] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.Percentile].ToString().Trim()); //百分位
objCurrEduClsStuEN.Ranking2 = objRow[conCurrEduClsStu.Ranking2] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduClsStu.Ranking2].ToString().Trim()); //Ranking2
objCurrEduClsStuEN.Percentile2 = objRow[conCurrEduClsStu.Percentile2] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.Percentile2].ToString().Trim()); //Percentile2
objCurrEduClsStuEN.Ranking3 = objRow[conCurrEduClsStu.Ranking3] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduClsStu.Ranking3].ToString().Trim()); //Ranking3
objCurrEduClsStuEN.Percentile3 = objRow[conCurrEduClsStu.Percentile3] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.Percentile3].ToString().Trim()); //Percentile3
objCurrEduClsStuEN.Confirmed = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduClsStu.Confirmed].ToString().Trim()); //是否确认
objCurrEduClsStuEN.SchoolTerm = objRow[conCurrEduClsStu.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduClsStu.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsStuEN.SchoolYear = objRow[conCurrEduClsStu.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduClsStu.SchoolYear].ToString().Trim(); //学年
objCurrEduClsStuEN.ExportDate = objRow[conCurrEduClsStu.ExportDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.ExportDate].ToString().Trim(); //导出日期
objCurrEduClsStuEN.SignInDate = objRow[conCurrEduClsStu.SignInDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.SignInDate].ToString().Trim(); //签入时间
objCurrEduClsStuEN.SignInStateID = objRow[conCurrEduClsStu.SignInStateID] == DBNull.Value ? null : objRow[conCurrEduClsStu.SignInStateID].ToString().Trim(); //签入状态表流水号
objCurrEduClsStuEN.SignInUser = objRow[conCurrEduClsStu.SignInUser] == DBNull.Value ? null : objRow[conCurrEduClsStu.SignInUser].ToString().Trim(); //签入人
objCurrEduClsStuEN.IsOpByTeacher = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduClsStu.IsOpByTeacher].ToString().Trim()); //是否教师操作
objCurrEduClsStuEN.IsSynScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduClsStu.IsSynScore].ToString().Trim()); //是否同步成绩
objCurrEduClsStuEN.LastVisitedDate = objRow[conCurrEduClsStu.LastVisitedDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.LastVisitedDate].ToString().Trim(); //最后访问时间
objCurrEduClsStuEN.ModifyDate = objRow[conCurrEduClsStu.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.ModifyDate].ToString().Trim(); //修改日期
objCurrEduClsStuEN.ModifyUserId = objRow[conCurrEduClsStu.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduClsStu.ModifyUserId].ToString().Trim(); //修改人
objCurrEduClsStuEN.Memo = objRow[conCurrEduClsStu.Memo] == DBNull.Value ? null : objRow[conCurrEduClsStu.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduClsStuEN.IdEduClsStu, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduClsStuEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsCurrEduClsStuEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsCurrEduClsStuEN> arrObjLst = new List<clsCurrEduClsStuEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduClsStuEN objCurrEduClsStuEN = new clsCurrEduClsStuEN();
try
{
objCurrEduClsStuEN.IdEduClsStu = Int32.Parse(objRow[conCurrEduClsStu.IdEduClsStu].ToString().Trim()); //教学班学生流水号
objCurrEduClsStuEN.IdCurrEduCls = objRow[conCurrEduClsStu.IdCurrEduCls] == DBNull.Value ? null : objRow[conCurrEduClsStu.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsStuEN.IdStu = objRow[conCurrEduClsStu.IdStu] == DBNull.Value ? null : objRow[conCurrEduClsStu.IdStu].ToString().Trim(); //学生流水号
objCurrEduClsStuEN.EduClsStuStateId = objRow[conCurrEduClsStu.EduClsStuStateId] == DBNull.Value ? null : objRow[conCurrEduClsStu.EduClsStuStateId].ToString().Trim(); //教学班学生状态编号
objCurrEduClsStuEN.GetScoreTimes = objRow[conCurrEduClsStu.GetScoreTimes] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduClsStu.GetScoreTimes].ToString().Trim()); //获得成绩次数
objCurrEduClsStuEN.Score = objRow[conCurrEduClsStu.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.Score].ToString().Trim()); //得分
objCurrEduClsStuEN.TotalScores = objRow[conCurrEduClsStu.TotalScores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.TotalScores].ToString().Trim()); //总分值
objCurrEduClsStuEN.Ranking = objRow[conCurrEduClsStu.Ranking] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduClsStu.Ranking].ToString().Trim()); //名次
objCurrEduClsStuEN.Percentile = objRow[conCurrEduClsStu.Percentile] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.Percentile].ToString().Trim()); //百分位
objCurrEduClsStuEN.Ranking2 = objRow[conCurrEduClsStu.Ranking2] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduClsStu.Ranking2].ToString().Trim()); //Ranking2
objCurrEduClsStuEN.Percentile2 = objRow[conCurrEduClsStu.Percentile2] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.Percentile2].ToString().Trim()); //Percentile2
objCurrEduClsStuEN.Ranking3 = objRow[conCurrEduClsStu.Ranking3] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduClsStu.Ranking3].ToString().Trim()); //Ranking3
objCurrEduClsStuEN.Percentile3 = objRow[conCurrEduClsStu.Percentile3] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.Percentile3].ToString().Trim()); //Percentile3
objCurrEduClsStuEN.Confirmed = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduClsStu.Confirmed].ToString().Trim()); //是否确认
objCurrEduClsStuEN.SchoolTerm = objRow[conCurrEduClsStu.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduClsStu.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsStuEN.SchoolYear = objRow[conCurrEduClsStu.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduClsStu.SchoolYear].ToString().Trim(); //学年
objCurrEduClsStuEN.ExportDate = objRow[conCurrEduClsStu.ExportDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.ExportDate].ToString().Trim(); //导出日期
objCurrEduClsStuEN.SignInDate = objRow[conCurrEduClsStu.SignInDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.SignInDate].ToString().Trim(); //签入时间
objCurrEduClsStuEN.SignInStateID = objRow[conCurrEduClsStu.SignInStateID] == DBNull.Value ? null : objRow[conCurrEduClsStu.SignInStateID].ToString().Trim(); //签入状态表流水号
objCurrEduClsStuEN.SignInUser = objRow[conCurrEduClsStu.SignInUser] == DBNull.Value ? null : objRow[conCurrEduClsStu.SignInUser].ToString().Trim(); //签入人
objCurrEduClsStuEN.IsOpByTeacher = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduClsStu.IsOpByTeacher].ToString().Trim()); //是否教师操作
objCurrEduClsStuEN.IsSynScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduClsStu.IsSynScore].ToString().Trim()); //是否同步成绩
objCurrEduClsStuEN.LastVisitedDate = objRow[conCurrEduClsStu.LastVisitedDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.LastVisitedDate].ToString().Trim(); //最后访问时间
objCurrEduClsStuEN.ModifyDate = objRow[conCurrEduClsStu.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.ModifyDate].ToString().Trim(); //修改日期
objCurrEduClsStuEN.ModifyUserId = objRow[conCurrEduClsStu.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduClsStu.ModifyUserId].ToString().Trim(); //修改人
objCurrEduClsStuEN.Memo = objRow[conCurrEduClsStu.Memo] == DBNull.Value ? null : objRow[conCurrEduClsStu.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduClsStuEN.IdEduClsStu, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduClsStuEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetCurrEduClsStu(ref clsCurrEduClsStuEN objCurrEduClsStuEN)
{
bool bolResult = CurrEduClsStuDA.GetCurrEduClsStu(ref objCurrEduClsStuEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdEduClsStu">表关键字</param>
 /// <returns>表对象</returns>
public static clsCurrEduClsStuEN GetObjByIdEduClsStu(long lngIdEduClsStu)
{
clsCurrEduClsStuEN objCurrEduClsStuEN = CurrEduClsStuDA.GetObjByIdEduClsStu(lngIdEduClsStu);
return objCurrEduClsStuEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsCurrEduClsStuEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsCurrEduClsStuEN objCurrEduClsStuEN = CurrEduClsStuDA.GetFirstObj(strWhereCond);
 return objCurrEduClsStuEN;
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
public static clsCurrEduClsStuEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsCurrEduClsStuEN objCurrEduClsStuEN = CurrEduClsStuDA.GetObjByDataRow(objRow);
 return objCurrEduClsStuEN;
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
public static clsCurrEduClsStuEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsCurrEduClsStuEN objCurrEduClsStuEN = CurrEduClsStuDA.GetObjByDataRow(objRow);
 return objCurrEduClsStuEN;
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
 /// <param name = "lngIdEduClsStu">所给的关键字</param>
 /// <param name = "lstCurrEduClsStuObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCurrEduClsStuEN GetObjByIdEduClsStuFromList(long lngIdEduClsStu, List<clsCurrEduClsStuEN> lstCurrEduClsStuObjLst)
{
foreach (clsCurrEduClsStuEN objCurrEduClsStuEN in lstCurrEduClsStuObjLst)
{
if (objCurrEduClsStuEN.IdEduClsStu == lngIdEduClsStu)
{
return objCurrEduClsStuEN;
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
 long lngIdEduClsStu;
 try
 {
 lngIdEduClsStu = new clsCurrEduClsStuDA().GetFirstID(strWhereCond);
 return lngIdEduClsStu;
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
 arrList = CurrEduClsStuDA.GetID(strWhereCond);
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
bool bolIsExist = CurrEduClsStuDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdEduClsStu">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdEduClsStu)
{
//检测记录是否存在
bool bolIsExist = CurrEduClsStuDA.IsExist(lngIdEduClsStu);
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
 bolIsExist = clsCurrEduClsStuDA.IsExistTable();
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
 bolIsExist = CurrEduClsStuDA.IsExistTable(strTabName);
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


 #region 添加记录

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AddNewRecordBySql2)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsCurrEduClsStuEN objCurrEduClsStuEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objCurrEduClsStuEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!教学班流水号 = [{0}],学生流水号 = [{1}]的数据已经存在!(in clsCurrEduClsStuBL.AddNewRecordBySql2)", objCurrEduClsStuEN.IdCurrEduCls,objCurrEduClsStuEN.IdStu);
throw new Exception(strMsg);
}
try
{
bool bolResult = CurrEduClsStuDA.AddNewRecordBySQL2(objCurrEduClsStuEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsStuBL.ReFreshCache(objCurrEduClsStuEN.IdCurrEduCls);

if (clsCurrEduClsStuBL.relatedActions != null)
{
clsCurrEduClsStuBL.relatedActions.UpdRelaTabDate(objCurrEduClsStuEN.IdEduClsStu, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000030)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AddNewRecordBySql2WithReturnKey)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsCurrEduClsStuEN objCurrEduClsStuEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objCurrEduClsStuEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!教学班流水号 = [{0}],学生流水号 = [{1}]的数据已经存在!(in clsCurrEduClsStuBL.AddNewRecordBySql2WithReturnKey)", objCurrEduClsStuEN.IdCurrEduCls,objCurrEduClsStuEN.IdStu);
throw new Exception(strMsg);
}
try
{
string strKey = CurrEduClsStuDA.AddNewRecordBySQL2WithReturnKey(objCurrEduClsStuEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsStuBL.ReFreshCache(objCurrEduClsStuEN.IdCurrEduCls);

if (clsCurrEduClsStuBL.relatedActions != null)
{
clsCurrEduClsStuBL.relatedActions.UpdRelaTabDate(objCurrEduClsStuEN.IdEduClsStu, "SetUpdDate");
}
return strKey;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000049)带返回值的添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 添加记录


 #region 修改记录

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Update)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsCurrEduClsStuEN objCurrEduClsStuEN)
{
try
{
bool bolResult = CurrEduClsStuDA.Update(objCurrEduClsStuEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsStuBL.ReFreshCache(objCurrEduClsStuEN.IdCurrEduCls);

if (clsCurrEduClsStuBL.relatedActions != null)
{
clsCurrEduClsStuBL.relatedActions.UpdRelaTabDate(objCurrEduClsStuEN.IdEduClsStu, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000033)修改记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_UpdateBySql2)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsCurrEduClsStuEN objCurrEduClsStuEN)
{
 if (objCurrEduClsStuEN.IdEduClsStu == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = CurrEduClsStuDA.UpdateBySql2(objCurrEduClsStuEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsStuBL.ReFreshCache(objCurrEduClsStuEN.IdCurrEduCls);

if (clsCurrEduClsStuBL.relatedActions != null)
{
clsCurrEduClsStuBL.relatedActions.UpdRelaTabDate(objCurrEduClsStuEN.IdEduClsStu, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000034)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 修改记录


 #region 删除记录

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord)
 /// </summary>
 /// <param name = "lngIdEduClsStu">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngIdEduClsStu)
{
try
{
 clsCurrEduClsStuEN objCurrEduClsStuEN = clsCurrEduClsStuBL.GetObjByIdEduClsStu(lngIdEduClsStu);

if (clsCurrEduClsStuBL.relatedActions != null)
{
clsCurrEduClsStuBL.relatedActions.UpdRelaTabDate(objCurrEduClsStuEN.IdEduClsStu, "SetUpdDate");
}
if (objCurrEduClsStuEN != null)
{
int intRecNum = CurrEduClsStuDA.DelRecord(lngIdEduClsStu);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objCurrEduClsStuEN.IdCurrEduCls);
return intRecNum;
}
            else
{
return 0;
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000039)根据关键字删除记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
/// 扩展删除记录,即同时删除多个表的记录,需要基于原子性的事务处理
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordEx)
/// </summary>
/// <param name="lngIdEduClsStu">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(long lngIdEduClsStu , string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCurrEduClsStuDA.GetSpecSQLObj();
//删除TeacherInfo本表中与当前对象有关的记录
SqlConnection objConnection = null;
SqlTransaction objSqlTransaction = null;
  try
{
//获取连接对象
objConnection = objSQL.getConnectObj(objSQL.ConnectionString);
//获取该连接对象中的事务
objSqlTransaction = objConnection.BeginTransaction();
//
//删除与表:[CurrEduClsStu]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conCurrEduClsStu.IdEduClsStu,
//lngIdEduClsStu);
//        clsCurrEduClsStuBL.DelCurrEduClsStusByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCurrEduClsStuBL.DelRecord(lngIdEduClsStu, strIdCurrEduCls, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCurrEduClsStuBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngIdEduClsStu, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);
if (objSqlTransaction != null)
{
objSqlTransaction.Rollback();
}
throw new Exception(strMsg);
        }
finally
{
objConnection.Close();
}
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordWithTransaction_S)
 /// </summary>
 /// <param name = "lngIdEduClsStu">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngIdEduClsStu, string strIdCurrEduCls, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsCurrEduClsStuBL.relatedActions != null)
{
clsCurrEduClsStuBL.relatedActions.UpdRelaTabDate(lngIdEduClsStu, "UpdRelaTabDate");
}
bool bolResult = CurrEduClsStuDA.DelRecord(lngIdEduClsStu,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(strIdCurrEduCls);
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000040)根据关键字删除记录出错!(使用事务),{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelMultiRecord)
 /// </summary>
 /// <param name = "arrIdEduClsStuLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelCurrEduClsStus(List<string> arrIdEduClsStuLst)
{
if (arrIdEduClsStuLst.Count == 0) return 0;
try
{
if (clsCurrEduClsStuBL.relatedActions != null)
{
foreach (var strIdEduClsStu in arrIdEduClsStuLst)
{
long lngIdEduClsStu = long.Parse(strIdEduClsStu);
clsCurrEduClsStuBL.relatedActions.UpdRelaTabDate(lngIdEduClsStu, "UpdRelaTabDate");
}
}
 clsCurrEduClsStuEN objCurrEduClsStuEN = clsCurrEduClsStuBL.GetObjByIdEduClsStu(long.Parse(arrIdEduClsStuLst[0]));
int intDelRecNum = CurrEduClsStuDA.DelCurrEduClsStu(arrIdEduClsStuLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objCurrEduClsStuEN.IdCurrEduCls);
return intDelRecNum;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000042)删除多关键字记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelMultiRecordByCond)
 /// </summary>
 /// <param name = "strWhereCond">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public static int DelCurrEduClsStusByCond(string strWhereCond)
{
try
{
if (clsCurrEduClsStuBL.relatedActions != null)
{
List<string> arrIdEduClsStu = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdEduClsStu in arrIdEduClsStu)
{
long lngIdEduClsStu = long.Parse(strIdEduClsStu);
clsCurrEduClsStuBL.relatedActions.UpdRelaTabDate(lngIdEduClsStu, "UpdRelaTabDate");
}
}
List<string> arrIdCurrEduCls = GetFldValue(conCurrEduClsStu.IdCurrEduCls, strWhereCond);
int intRecNum = CurrEduClsStuDA.DelCurrEduClsStu(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
arrIdCurrEduCls.ForEach(x => ReFreshCache(x));
return intRecNum;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000043)删除带条件表记录出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
/// 扩展删除记录,即同时删除多个表的记录,需要基于原子性的事务处理
/// 这里仅仅是演示函数,使用时请复制到扩展类:[CurrEduClsStu]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngIdEduClsStu">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngIdEduClsStu, string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCurrEduClsStuDA.GetSpecSQLObj();
//删除TeacherInfo本表中与当前对象有关的记录
SqlConnection objConnection = null;
SqlTransaction objSqlTransaction = null;
  try
{
//获取连接对象
objConnection = objSQL.getConnectObj(objSQL.ConnectionString);
//获取该连接对象中的事务
objSqlTransaction = objConnection.BeginTransaction();
//
//删除与表:[CurrEduClsStu]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCurrEduClsStuBL.DelRecord(lngIdEduClsStu, strIdCurrEduCls, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCurrEduClsStuBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngIdEduClsStu, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);
if (objSqlTransaction != null)
{
objSqlTransaction.Rollback();
}
throw new Exception(strMsg);
        }
finally
{
objConnection.Close();
}
}


 #endregion 删除记录


 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CopyObj_S)
 /// </summary>
 /// <param name = "objCurrEduClsStuENS">源对象</param>
 /// <param name = "objCurrEduClsStuENT">目标对象</param>
 public static void CopyTo(clsCurrEduClsStuEN objCurrEduClsStuENS, clsCurrEduClsStuEN objCurrEduClsStuENT)
{
try
{
objCurrEduClsStuENT.IdEduClsStu = objCurrEduClsStuENS.IdEduClsStu; //教学班学生流水号
objCurrEduClsStuENT.IdCurrEduCls = objCurrEduClsStuENS.IdCurrEduCls; //教学班流水号
objCurrEduClsStuENT.IdStu = objCurrEduClsStuENS.IdStu; //学生流水号
objCurrEduClsStuENT.EduClsStuStateId = objCurrEduClsStuENS.EduClsStuStateId; //教学班学生状态编号
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
objCurrEduClsStuENT.LastVisitedDate = objCurrEduClsStuENS.LastVisitedDate; //最后访问时间
objCurrEduClsStuENT.ModifyDate = objCurrEduClsStuENS.ModifyDate; //修改日期
objCurrEduClsStuENT.ModifyUserId = objCurrEduClsStuENS.ModifyUserId; //修改人
objCurrEduClsStuENT.Memo = objCurrEduClsStuENS.Memo; //备注
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
 /// <param name = "objCurrEduClsStuEN">源简化对象</param>
 public static void SetUpdFlag(clsCurrEduClsStuEN objCurrEduClsStuEN)
{
try
{
objCurrEduClsStuEN.ClearUpdateState();
   string strsfUpdFldSetStr = objCurrEduClsStuEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conCurrEduClsStu.IdEduClsStu, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsStuEN.IdEduClsStu = objCurrEduClsStuEN.IdEduClsStu; //教学班学生流水号
}
if (arrFldSet.Contains(conCurrEduClsStu.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsStuEN.IdCurrEduCls = objCurrEduClsStuEN.IdCurrEduCls == "[null]" ? null :  objCurrEduClsStuEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conCurrEduClsStu.IdStu, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsStuEN.IdStu = objCurrEduClsStuEN.IdStu == "[null]" ? null :  objCurrEduClsStuEN.IdStu; //学生流水号
}
if (arrFldSet.Contains(conCurrEduClsStu.EduClsStuStateId, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsStuEN.EduClsStuStateId = objCurrEduClsStuEN.EduClsStuStateId == "[null]" ? null :  objCurrEduClsStuEN.EduClsStuStateId; //教学班学生状态编号
}
if (arrFldSet.Contains(conCurrEduClsStu.GetScoreTimes, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsStuEN.GetScoreTimes = objCurrEduClsStuEN.GetScoreTimes; //获得成绩次数
}
if (arrFldSet.Contains(conCurrEduClsStu.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsStuEN.Score = objCurrEduClsStuEN.Score; //得分
}
if (arrFldSet.Contains(conCurrEduClsStu.TotalScores, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsStuEN.TotalScores = objCurrEduClsStuEN.TotalScores; //总分值
}
if (arrFldSet.Contains(conCurrEduClsStu.Ranking, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsStuEN.Ranking = objCurrEduClsStuEN.Ranking; //名次
}
if (arrFldSet.Contains(conCurrEduClsStu.Percentile, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsStuEN.Percentile = objCurrEduClsStuEN.Percentile; //百分位
}
if (arrFldSet.Contains(conCurrEduClsStu.Ranking2, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsStuEN.Ranking2 = objCurrEduClsStuEN.Ranking2; //Ranking2
}
if (arrFldSet.Contains(conCurrEduClsStu.Percentile2, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsStuEN.Percentile2 = objCurrEduClsStuEN.Percentile2; //Percentile2
}
if (arrFldSet.Contains(conCurrEduClsStu.Ranking3, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsStuEN.Ranking3 = objCurrEduClsStuEN.Ranking3; //Ranking3
}
if (arrFldSet.Contains(conCurrEduClsStu.Percentile3, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsStuEN.Percentile3 = objCurrEduClsStuEN.Percentile3; //Percentile3
}
if (arrFldSet.Contains(conCurrEduClsStu.Confirmed, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsStuEN.Confirmed = objCurrEduClsStuEN.Confirmed; //是否确认
}
if (arrFldSet.Contains(conCurrEduClsStu.SchoolTerm, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsStuEN.SchoolTerm = objCurrEduClsStuEN.SchoolTerm == "[null]" ? null :  objCurrEduClsStuEN.SchoolTerm; //学期
}
if (arrFldSet.Contains(conCurrEduClsStu.SchoolYear, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsStuEN.SchoolYear = objCurrEduClsStuEN.SchoolYear == "[null]" ? null :  objCurrEduClsStuEN.SchoolYear; //学年
}
if (arrFldSet.Contains(conCurrEduClsStu.ExportDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsStuEN.ExportDate = objCurrEduClsStuEN.ExportDate == "[null]" ? null :  objCurrEduClsStuEN.ExportDate; //导出日期
}
if (arrFldSet.Contains(conCurrEduClsStu.SignInDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsStuEN.SignInDate = objCurrEduClsStuEN.SignInDate == "[null]" ? null :  objCurrEduClsStuEN.SignInDate; //签入时间
}
if (arrFldSet.Contains(conCurrEduClsStu.SignInStateID, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsStuEN.SignInStateID = objCurrEduClsStuEN.SignInStateID == "[null]" ? null :  objCurrEduClsStuEN.SignInStateID; //签入状态表流水号
}
if (arrFldSet.Contains(conCurrEduClsStu.SignInUser, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsStuEN.SignInUser = objCurrEduClsStuEN.SignInUser == "[null]" ? null :  objCurrEduClsStuEN.SignInUser; //签入人
}
if (arrFldSet.Contains(conCurrEduClsStu.IsOpByTeacher, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsStuEN.IsOpByTeacher = objCurrEduClsStuEN.IsOpByTeacher; //是否教师操作
}
if (arrFldSet.Contains(conCurrEduClsStu.IsSynScore, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsStuEN.IsSynScore = objCurrEduClsStuEN.IsSynScore; //是否同步成绩
}
if (arrFldSet.Contains(conCurrEduClsStu.LastVisitedDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsStuEN.LastVisitedDate = objCurrEduClsStuEN.LastVisitedDate == "[null]" ? null :  objCurrEduClsStuEN.LastVisitedDate; //最后访问时间
}
if (arrFldSet.Contains(conCurrEduClsStu.ModifyDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsStuEN.ModifyDate = objCurrEduClsStuEN.ModifyDate == "[null]" ? null :  objCurrEduClsStuEN.ModifyDate; //修改日期
}
if (arrFldSet.Contains(conCurrEduClsStu.ModifyUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsStuEN.ModifyUserId = objCurrEduClsStuEN.ModifyUserId == "[null]" ? null :  objCurrEduClsStuEN.ModifyUserId; //修改人
}
if (arrFldSet.Contains(conCurrEduClsStu.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsStuEN.Memo = objCurrEduClsStuEN.Memo == "[null]" ? null :  objCurrEduClsStuEN.Memo; //备注
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
 /// <param name = "objCurrEduClsStuEN">源简化对象</param>
 public static void AccessFldValueNull(clsCurrEduClsStuEN objCurrEduClsStuEN)
{
try
{
if (objCurrEduClsStuEN.IdCurrEduCls == "[null]") objCurrEduClsStuEN.IdCurrEduCls = null; //教学班流水号
if (objCurrEduClsStuEN.IdStu == "[null]") objCurrEduClsStuEN.IdStu = null; //学生流水号
if (objCurrEduClsStuEN.EduClsStuStateId == "[null]") objCurrEduClsStuEN.EduClsStuStateId = null; //教学班学生状态编号
if (objCurrEduClsStuEN.SchoolTerm == "[null]") objCurrEduClsStuEN.SchoolTerm = null; //学期
if (objCurrEduClsStuEN.SchoolYear == "[null]") objCurrEduClsStuEN.SchoolYear = null; //学年
if (objCurrEduClsStuEN.ExportDate == "[null]") objCurrEduClsStuEN.ExportDate = null; //导出日期
if (objCurrEduClsStuEN.SignInDate == "[null]") objCurrEduClsStuEN.SignInDate = null; //签入时间
if (objCurrEduClsStuEN.SignInStateID == "[null]") objCurrEduClsStuEN.SignInStateID = null; //签入状态表流水号
if (objCurrEduClsStuEN.SignInUser == "[null]") objCurrEduClsStuEN.SignInUser = null; //签入人
if (objCurrEduClsStuEN.LastVisitedDate == "[null]") objCurrEduClsStuEN.LastVisitedDate = null; //最后访问时间
if (objCurrEduClsStuEN.ModifyDate == "[null]") objCurrEduClsStuEN.ModifyDate = null; //修改日期
if (objCurrEduClsStuEN.ModifyUserId == "[null]") objCurrEduClsStuEN.ModifyUserId = null; //修改人
if (objCurrEduClsStuEN.Memo == "[null]") objCurrEduClsStuEN.Memo = null; //备注
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
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsCurrEduClsStuEN objCurrEduClsStuEN)
{
 CurrEduClsStuDA.CheckPropertyNew(objCurrEduClsStuEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsCurrEduClsStuEN objCurrEduClsStuEN)
{
 CurrEduClsStuDA.CheckProperty4Condition(objCurrEduClsStuEN);
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
if (clsCurrEduClsStuBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCurrEduClsStuBL没有刷新缓存机制(clsCurrEduClsStuBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdEduClsStu");
//if (arrCurrEduClsStuObjLstCache == null)
//{
//arrCurrEduClsStuObjLstCache = CurrEduClsStuDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdEduClsStu">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCurrEduClsStuEN GetObjByIdEduClsStuCache(long lngIdEduClsStu, string strIdCurrEduCls)
{

if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
  var strMsg = string.Format("参数:[strIdCurrEduCls]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strIdCurrEduCls.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strIdCurrEduCls]的长度:[{0}]不正确!(In {1})", strIdCurrEduCls.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsCurrEduClsStuEN._CurrTabName, strIdCurrEduCls);
List<clsCurrEduClsStuEN> arrCurrEduClsStuObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsCurrEduClsStuEN> arrCurrEduClsStuObjLst_Sel =
arrCurrEduClsStuObjLstCache
.Where(x=> x.IdEduClsStu == lngIdEduClsStu 
);
if (arrCurrEduClsStuObjLst_Sel.Count() == 0)
{
   clsCurrEduClsStuEN obj = clsCurrEduClsStuBL.GetObjByIdEduClsStu(lngIdEduClsStu);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngIdEduClsStu, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrCurrEduClsStuObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCurrEduClsStuEN> GetAllCurrEduClsStuObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsCurrEduClsStuEN> arrCurrEduClsStuObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrCurrEduClsStuObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCurrEduClsStuEN> GetObjLstCache(string strIdCurrEduCls)
{

if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
  var strMsg = string.Format("参数:[strIdCurrEduCls]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strIdCurrEduCls.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strIdCurrEduCls]的长度:[{0}]不正确!(In {1})", strIdCurrEduCls.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsCurrEduClsStuEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsCurrEduClsStuEN> arrCurrEduClsStuObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrCurrEduClsStuObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strIdCurrEduCls = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsCurrEduClsStuEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clsCurrEduClsStuEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
/// 获取最新的缓存刷新时间
/// </summary>
/// <returns>最新的缓存刷新时间，字符串型</returns>
public static string GetLastRefreshTime()
{
if (clsCurrEduClsStuEN._RefreshTimeLst.Count == 0) return "";
return clsCurrEduClsStuEN._RefreshTimeLst[clsCurrEduClsStuEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strIdCurrEduCls)
{
if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("缓存分类字段:[IdCurrEduCls]不能为空!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCurrEduClsStuBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsCurrEduClsStuEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clsCurrEduClsStuEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsCurrEduClsStuBL.objCommFun4BL.ReFreshCache(strIdCurrEduCls);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--CurrEduClsStu(教学班与学生关系)
 /// 唯一性条件:id_CurrEduCls_id_Stu
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsCurrEduClsStuEN objCurrEduClsStuEN)
{
//检测记录是否存在
string strResult = CurrEduClsStuDA.GetUniCondStr(objCurrEduClsStuEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2024-11-13
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngIdEduClsStu, string strIdCurrEduCls)
{
if (strInFldName != conCurrEduClsStu.IdEduClsStu)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conCurrEduClsStu.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conCurrEduClsStu.AttributeName));
throw new Exception(strMsg);
}
var objCurrEduClsStu = clsCurrEduClsStuBL.GetObjByIdEduClsStuCache(lngIdEduClsStu, strIdCurrEduCls);
if (objCurrEduClsStu == null) return "";
return objCurrEduClsStu[strOutFldName].ToString();
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
int intRecCount = clsCurrEduClsStuDA.GetRecCount(strTabName);
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
int intRecCount = clsCurrEduClsStuDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsCurrEduClsStuDA.GetRecCount();
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
int intRecCount = clsCurrEduClsStuDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objCurrEduClsStuCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsCurrEduClsStuEN objCurrEduClsStuCond)
{
 string strIdCurrEduCls = objCurrEduClsStuCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsCurrEduClsStuBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsCurrEduClsStuEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsCurrEduClsStuEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCurrEduClsStu.AttributeName)
{
if (objCurrEduClsStuCond.IsUpdated(strFldName) == false) continue;
if (objCurrEduClsStuCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCurrEduClsStuCond[strFldName].ToString());
}
else
{
if (objCurrEduClsStuCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCurrEduClsStuCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCurrEduClsStuCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCurrEduClsStuCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCurrEduClsStuCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCurrEduClsStuCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCurrEduClsStuCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCurrEduClsStuCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCurrEduClsStuCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCurrEduClsStuCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCurrEduClsStuCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCurrEduClsStuCond[strFldName]));
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
 List<string> arrList = clsCurrEduClsStuDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = CurrEduClsStuDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = CurrEduClsStuDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 /// <summary>
 /// 功能:设置当前表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4String)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public int SetFldValue(string strFldName, string strValue, string strWhereCond) 
{
int intRecCount = CurrEduClsStuDA.SetFldValue(strFldName, strValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}


 /// <summary>
 /// 功能:设置当前表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Float)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "fltValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public int SetFldValue(string strFldName, float fltValue, string strWhereCond) 
{
int intRecCount = clsCurrEduClsStuDA.SetFldValue(clsCurrEduClsStuEN._CurrTabName, strFldName, fltValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置当前表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Int)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "intValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public int SetFldValue(string strFldName, int intValue, string strWhereCond) 
{
int intRecCount = CurrEduClsStuDA.SetFldValue( strFldName, intValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4String_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue(string strTabName, string strFldName, string strValue, string strWhereCond) 
{
int intRecCount = clsCurrEduClsStuDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Int_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue(string strTabName, string strFldName, int intValue, string strWhereCond) 
{
int intRecCount = clsCurrEduClsStuDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Float_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue(string strTabName, string strFldName, float fltValue, string strWhereCond) 
{
int intRecCount = clsCurrEduClsStuDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}



 #endregion 表操作常用函数


 #region 表操作

 /// <summary>
 /// 功能:获取建立表的代码
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GenSQLCode4CreateTab)
 /// </summary>
 /// <returns>建立表的代码</returns>
public static string GetCode4CreateTable() 
{
 StringBuilder strCreateTabCode = new StringBuilder();
  strCreateTabCode.Append("CREATE table [dbo].[CurrEduClsStu] "); 
 strCreateTabCode.Append(" ( "); 
 // /**教学班学生流水号*/ 
 strCreateTabCode.Append(" IdEduClsStu bigint primary key identity, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) Null, "); 
 // /**学生流水号*/ 
 strCreateTabCode.Append(" IdStu char(8) Null, "); 
 // /**教学班学生状态编号*/ 
 strCreateTabCode.Append(" EduClsStuStateId char(2) Null, "); 
 // /**获得成绩次数*/ 
 strCreateTabCode.Append(" GetScoreTimes tinyint Null, "); 
 // /**得分*/ 
 strCreateTabCode.Append(" Score decimal(6,1) Null, "); 
 // /**总分值*/ 
 strCreateTabCode.Append(" TotalScores decimal(10,2) Null, "); 
 // /**名次*/ 
 strCreateTabCode.Append(" Ranking int Null, "); 
 // /**百分位*/ 
 strCreateTabCode.Append(" Percentile decimal(8,2) Null, "); 
 // /**Ranking2*/ 
 strCreateTabCode.Append(" Ranking2 int Null, "); 
 // /**Percentile2*/ 
 strCreateTabCode.Append(" Percentile2 decimal(10,2) Null, "); 
 // /**Ranking3*/ 
 strCreateTabCode.Append(" Ranking3 int Null, "); 
 // /**Percentile3*/ 
 strCreateTabCode.Append(" Percentile3 decimal(10,2) Null, "); 
 // /**是否确认*/ 
 strCreateTabCode.Append(" Confirmed bit Null, "); 
 // /**学期*/ 
 strCreateTabCode.Append(" SchoolTerm char(1) Null, "); 
 // /**学年*/ 
 strCreateTabCode.Append(" SchoolYear varchar(10) Null, "); 
 // /**导出日期*/ 
 strCreateTabCode.Append(" ExportDate varchar(8) Null, "); 
 // /**签入时间*/ 
 strCreateTabCode.Append(" SignInDate varchar(20) Null, "); 
 // /**签入状态表流水号*/ 
 strCreateTabCode.Append(" SignInStateID char(2) Null, "); 
 // /**签入人*/ 
 strCreateTabCode.Append(" SignInUser varchar(18) Null, "); 
 // /**是否教师操作*/ 
 strCreateTabCode.Append(" IsOpByTeacher bit Null, "); 
 // /**是否同步成绩*/ 
 strCreateTabCode.Append(" IsSynScore bit Null, "); 
 // /**最后访问时间*/ 
 strCreateTabCode.Append(" LastVisitedDate varchar(14) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" ModifyDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" ModifyUserId varchar(18) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**姓名*/ 
 strCreateTabCode.Append(" StuName varchar(50) Null, "); 
 // /**教学班名*/ 
 strCreateTabCode.Append(" EduClsName varchar(100) Null, "); 
 // /**课程类型名称*/ 
 strCreateTabCode.Append(" CourseTypeName varchar(30) Null, "); 
 // /**课程名称*/ 
 strCreateTabCode.Append(" CourseName varchar(100) Null, "); 
 // /**课程代码*/ 
 strCreateTabCode.Append(" CourseCode varchar(20) Null, "); 
 // /**专业名称*/ 
 strCreateTabCode.Append(" MajorName varchar(100) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 教学班与学生关系(CurrEduClsStu)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4CurrEduClsStu : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strIdCurrEduCls)
{
string strMsg;
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
clsCurrEduClsStuBL.ReFreshThisCache(strIdCurrEduCls);
}
}

}