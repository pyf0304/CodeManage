
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCjClsScoreTtlBL
 表名:CjClsScoreTtl(01120330)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:21:02
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:成绩管理(ScoreMan)
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
public static class  clsCjClsScoreTtlBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCjClsScoreTtlEN GetObj(this K_mId_CjClsScoreTtl myKey)
{
clsCjClsScoreTtlEN objCjClsScoreTtlEN = clsCjClsScoreTtlBL.CjClsScoreTtlDA.GetObjBymId(myKey.Value);
return objCjClsScoreTtlEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCjClsScoreTtlEN objCjClsScoreTtlEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCjClsScoreTtlEN) == false)
{
var strMsg = string.Format("记录已经存在!教学班流水号 = [{0}],考试批次ID = [{1}]的数据已经存在!(in clsCjClsScoreTtlBL.AddNewRecord)", objCjClsScoreTtlEN.IdEduCls,objCjClsScoreTtlEN.ExamBatchId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsCjClsScoreTtlBL.CjClsScoreTtlDA.AddNewRecordBySQL2(objCjClsScoreTtlEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCjClsScoreTtlBL.ReFreshCache();

if (clsCjClsScoreTtlBL.relatedActions != null)
{
clsCjClsScoreTtlBL.relatedActions.UpdRelaTabDate(objCjClsScoreTtlEN.mId, objCjClsScoreTtlEN.UpdUser);
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
public static bool AddRecordEx(this clsCjClsScoreTtlEN objCjClsScoreTtlEN, bool bolIsNeedCheckUniqueness = true)
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
objCjClsScoreTtlEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objCjClsScoreTtlEN.CheckUniqueness() == false)
{
strMsg = string.Format("(教学班流水号(IdEduCls)=[{0}],考试批次ID(ExamBatchId)=[{1}])已经存在,不能重复!", objCjClsScoreTtlEN.IdEduCls, objCjClsScoreTtlEN.ExamBatchId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objCjClsScoreTtlEN.AddNewRecord();
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
 /// <param name = "objCjClsScoreTtlEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsCjClsScoreTtlEN objCjClsScoreTtlEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCjClsScoreTtlEN) == false)
{
var strMsg = string.Format("记录已经存在!教学班流水号 = [{0}],考试批次ID = [{1}]的数据已经存在!(in clsCjClsScoreTtlBL.AddNewRecordWithReturnKey)", objCjClsScoreTtlEN.IdEduCls,objCjClsScoreTtlEN.ExamBatchId);
throw new Exception(strMsg);
}
try
{
string strKey = clsCjClsScoreTtlBL.CjClsScoreTtlDA.AddNewRecordBySQL2WithReturnKey(objCjClsScoreTtlEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCjClsScoreTtlBL.ReFreshCache();

if (clsCjClsScoreTtlBL.relatedActions != null)
{
clsCjClsScoreTtlBL.relatedActions.UpdRelaTabDate(objCjClsScoreTtlEN.mId, objCjClsScoreTtlEN.UpdUser);
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
 /// <param name = "objCjClsScoreTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCjClsScoreTtlEN SetExamBatchId(this clsCjClsScoreTtlEN objCjClsScoreTtlEN, string strExamBatchId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strExamBatchId, conCjClsScoreTtl.ExamBatchId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExamBatchId, 12, conCjClsScoreTtl.ExamBatchId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strExamBatchId, 12, conCjClsScoreTtl.ExamBatchId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCjClsScoreTtlEN SetIdCourse(this clsCjClsScoreTtlEN objCjClsScoreTtlEN, string strIdCourse, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdCourse, conCjClsScoreTtl.IdCourse);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCourse, 8, conCjClsScoreTtl.IdCourse);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCourse, 8, conCjClsScoreTtl.IdCourse);
}
objCjClsScoreTtlEN.IdCourse = strIdCourse; //课程流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCjClsScoreTtlEN.dicFldComparisonOp.ContainsKey(conCjClsScoreTtl.IdCourse) == false)
{
objCjClsScoreTtlEN.dicFldComparisonOp.Add(conCjClsScoreTtl.IdCourse, strComparisonOp);
}
else
{
objCjClsScoreTtlEN.dicFldComparisonOp[conCjClsScoreTtl.IdCourse] = strComparisonOp;
}
}
return objCjClsScoreTtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCjClsScoreTtlEN SetIdEduCls(this clsCjClsScoreTtlEN objCjClsScoreTtlEN, string strIdEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdEduCls, conCjClsScoreTtl.IdEduCls);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdEduCls, 8, conCjClsScoreTtl.IdEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdEduCls, 8, conCjClsScoreTtl.IdEduCls);
}
objCjClsScoreTtlEN.IdEduCls = strIdEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCjClsScoreTtlEN.dicFldComparisonOp.ContainsKey(conCjClsScoreTtl.IdEduCls) == false)
{
objCjClsScoreTtlEN.dicFldComparisonOp.Add(conCjClsScoreTtl.IdEduCls, strComparisonOp);
}
else
{
objCjClsScoreTtlEN.dicFldComparisonOp[conCjClsScoreTtl.IdEduCls] = strComparisonOp;
}
}
return objCjClsScoreTtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCjClsScoreTtlEN SetIdAdminCls(this clsCjClsScoreTtlEN objCjClsScoreTtlEN, string strIdAdminCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdAdminCls, 8, conCjClsScoreTtl.IdAdminCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdAdminCls, 8, conCjClsScoreTtl.IdAdminCls);
}
objCjClsScoreTtlEN.IdAdminCls = strIdAdminCls; //行政班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCjClsScoreTtlEN.dicFldComparisonOp.ContainsKey(conCjClsScoreTtl.IdAdminCls) == false)
{
objCjClsScoreTtlEN.dicFldComparisonOp.Add(conCjClsScoreTtl.IdAdminCls, strComparisonOp);
}
else
{
objCjClsScoreTtlEN.dicFldComparisonOp[conCjClsScoreTtl.IdAdminCls] = strComparisonOp;
}
}
return objCjClsScoreTtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCjClsScoreTtlEN SetStuNum(this clsCjClsScoreTtlEN objCjClsScoreTtlEN, int? intStuNum, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCjClsScoreTtlEN SetAvgScore(this clsCjClsScoreTtlEN objCjClsScoreTtlEN, double? dblAvgScore, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCjClsScoreTtlEN SetRanking(this clsCjClsScoreTtlEN objCjClsScoreTtlEN, int? intRanking, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCjClsScoreTtlEN SetPercentile(this clsCjClsScoreTtlEN objCjClsScoreTtlEN, double? dblPercentile, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCjClsScoreTtlEN SetExcellentRate(this clsCjClsScoreTtlEN objCjClsScoreTtlEN, double? dblExcellentRate, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCjClsScoreTtlEN SetExcellentGoodRate(this clsCjClsScoreTtlEN objCjClsScoreTtlEN, double? dblExcellentGoodRate, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCjClsScoreTtlEN SetPassingRate(this clsCjClsScoreTtlEN objCjClsScoreTtlEN, double? dblPassingRate, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCjClsScoreTtlEN SetExtremeRate(this clsCjClsScoreTtlEN objCjClsScoreTtlEN, double? dblExtremeRate, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCjClsScoreTtlEN SetStandardDeviation(this clsCjClsScoreTtlEN objCjClsScoreTtlEN, double? dblStandardDeviation, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCjClsScoreTtlEN SetFullScore(this clsCjClsScoreTtlEN objCjClsScoreTtlEN, int? intFullScore, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCjClsScoreTtlEN SetSchoolYear(this clsCjClsScoreTtlEN objCjClsScoreTtlEN, string strSchoolYear, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, conCjClsScoreTtl.SchoolYear);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCjClsScoreTtlEN SetSchoolTerm(this clsCjClsScoreTtlEN objCjClsScoreTtlEN, string strSchoolTerm, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, conCjClsScoreTtl.SchoolTerm);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, conCjClsScoreTtl.SchoolTerm);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCjClsScoreTtlEN SetUpdDate(this clsCjClsScoreTtlEN objCjClsScoreTtlEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conCjClsScoreTtl.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conCjClsScoreTtl.UpdDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCjClsScoreTtlEN SetUpdUser(this clsCjClsScoreTtlEN objCjClsScoreTtlEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conCjClsScoreTtl.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conCjClsScoreTtl.UpdUser);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCjClsScoreTtlEN SetMemo(this clsCjClsScoreTtlEN objCjClsScoreTtlEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCjClsScoreTtl.Memo);
}
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
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsCjClsScoreTtlEN objCjClsScoreTtlEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objCjClsScoreTtlEN.CheckPropertyNew();
clsCjClsScoreTtlEN objCjClsScoreTtlCond = new clsCjClsScoreTtlEN();
string strCondition = objCjClsScoreTtlCond
.SetmId(objCjClsScoreTtlEN.mId, "<>")
.SetIdEduCls(objCjClsScoreTtlEN.IdEduCls, "=")
.SetExamBatchId(objCjClsScoreTtlEN.ExamBatchId, "=")
.GetCombineCondition();
objCjClsScoreTtlEN._IsCheckProperty = true;
bool bolIsExist = clsCjClsScoreTtlBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(id_EduCls_ExamBatchId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objCjClsScoreTtlEN.Update();
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
 /// <param name = "objCjClsScoreTtl">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsCjClsScoreTtlEN objCjClsScoreTtl)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsCjClsScoreTtlEN objCjClsScoreTtlCond = new clsCjClsScoreTtlEN();
string strCondition = objCjClsScoreTtlCond
.SetIdEduCls(objCjClsScoreTtl.IdEduCls, "=")
.SetExamBatchId(objCjClsScoreTtl.ExamBatchId, "=")
.GetCombineCondition();
objCjClsScoreTtl._IsCheckProperty = true;
bool bolIsExist = clsCjClsScoreTtlBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objCjClsScoreTtl.mId = clsCjClsScoreTtlBL.GetFirstID_S(strCondition);
objCjClsScoreTtl.UpdateWithCondition(strCondition);
}
else
{
objCjClsScoreTtl.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCjClsScoreTtlEN objCjClsScoreTtlEN)
{
 if (objCjClsScoreTtlEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCjClsScoreTtlBL.CjClsScoreTtlDA.UpdateBySql2(objCjClsScoreTtlEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCjClsScoreTtlBL.ReFreshCache();

if (clsCjClsScoreTtlBL.relatedActions != null)
{
clsCjClsScoreTtlBL.relatedActions.UpdRelaTabDate(objCjClsScoreTtlEN.mId, objCjClsScoreTtlEN.UpdUser);
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
 /// <param name = "objCjClsScoreTtlEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCjClsScoreTtlEN objCjClsScoreTtlEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objCjClsScoreTtlEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCjClsScoreTtlBL.CjClsScoreTtlDA.UpdateBySql2(objCjClsScoreTtlEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCjClsScoreTtlBL.ReFreshCache();

if (clsCjClsScoreTtlBL.relatedActions != null)
{
clsCjClsScoreTtlBL.relatedActions.UpdRelaTabDate(objCjClsScoreTtlEN.mId, objCjClsScoreTtlEN.UpdUser);
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
 /// <param name = "objCjClsScoreTtlEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCjClsScoreTtlEN objCjClsScoreTtlEN, string strWhereCond)
{
try
{
bool bolResult = clsCjClsScoreTtlBL.CjClsScoreTtlDA.UpdateBySqlWithCondition(objCjClsScoreTtlEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCjClsScoreTtlBL.ReFreshCache();

if (clsCjClsScoreTtlBL.relatedActions != null)
{
clsCjClsScoreTtlBL.relatedActions.UpdRelaTabDate(objCjClsScoreTtlEN.mId, objCjClsScoreTtlEN.UpdUser);
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
 /// <param name = "objCjClsScoreTtlEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCjClsScoreTtlEN objCjClsScoreTtlEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsCjClsScoreTtlBL.CjClsScoreTtlDA.UpdateBySqlWithConditionTransaction(objCjClsScoreTtlEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCjClsScoreTtlBL.ReFreshCache();

if (clsCjClsScoreTtlBL.relatedActions != null)
{
clsCjClsScoreTtlBL.relatedActions.UpdRelaTabDate(objCjClsScoreTtlEN.mId, objCjClsScoreTtlEN.UpdUser);
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsCjClsScoreTtlEN objCjClsScoreTtlEN)
{
try
{
int intRecNum = clsCjClsScoreTtlBL.CjClsScoreTtlDA.DelRecord(objCjClsScoreTtlEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCjClsScoreTtlBL.ReFreshCache();

if (clsCjClsScoreTtlBL.relatedActions != null)
{
clsCjClsScoreTtlBL.relatedActions.UpdRelaTabDate(objCjClsScoreTtlEN.mId, objCjClsScoreTtlEN.UpdUser);
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
 /// <param name = "objCjClsScoreTtlENS">源对象</param>
 /// <param name = "objCjClsScoreTtlENT">目标对象</param>
 public static void CopyTo(this clsCjClsScoreTtlEN objCjClsScoreTtlENS, clsCjClsScoreTtlEN objCjClsScoreTtlENT)
{
try
{
objCjClsScoreTtlENT.mId = objCjClsScoreTtlENS.mId; //mId
objCjClsScoreTtlENT.ExamBatchId = objCjClsScoreTtlENS.ExamBatchId; //考试批次ID
objCjClsScoreTtlENT.IdCourse = objCjClsScoreTtlENS.IdCourse; //课程流水号
objCjClsScoreTtlENT.IdEduCls = objCjClsScoreTtlENS.IdEduCls; //教学班流水号
objCjClsScoreTtlENT.IdAdminCls = objCjClsScoreTtlENS.IdAdminCls; //行政班流水号
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
 /// <param name = "objCjClsScoreTtlENS">源对象</param>
 /// <returns>目标对象=>clsCjClsScoreTtlEN:objCjClsScoreTtlENT</returns>
 public static clsCjClsScoreTtlEN CopyTo(this clsCjClsScoreTtlEN objCjClsScoreTtlENS)
{
try
{
 clsCjClsScoreTtlEN objCjClsScoreTtlENT = new clsCjClsScoreTtlEN()
{
mId = objCjClsScoreTtlENS.mId, //mId
ExamBatchId = objCjClsScoreTtlENS.ExamBatchId, //考试批次ID
IdCourse = objCjClsScoreTtlENS.IdCourse, //课程流水号
IdEduCls = objCjClsScoreTtlENS.IdEduCls, //教学班流水号
IdAdminCls = objCjClsScoreTtlENS.IdAdminCls, //行政班流水号
StuNum = objCjClsScoreTtlENS.StuNum, //学生数
AvgScore = objCjClsScoreTtlENS.AvgScore, //平均分
Ranking = objCjClsScoreTtlENS.Ranking, //名次
Percentile = objCjClsScoreTtlENS.Percentile, //百分位
ExcellentRate = objCjClsScoreTtlENS.ExcellentRate, //优秀率
ExcellentGoodRate = objCjClsScoreTtlENS.ExcellentGoodRate, //优良率
PassingRate = objCjClsScoreTtlENS.PassingRate, //及格率
ExtremeRate = objCjClsScoreTtlENS.ExtremeRate, //极差率
StandardDeviation = objCjClsScoreTtlENS.StandardDeviation, //标准差
FullScore = objCjClsScoreTtlENS.FullScore, //满分
SchoolYear = objCjClsScoreTtlENS.SchoolYear, //学年
SchoolTerm = objCjClsScoreTtlENS.SchoolTerm, //学期
UpdDate = objCjClsScoreTtlENS.UpdDate, //修改日期
UpdUser = objCjClsScoreTtlENS.UpdUser, //修改人
Memo = objCjClsScoreTtlENS.Memo, //备注
};
 return objCjClsScoreTtlENT;
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
public static void CheckPropertyNew(this clsCjClsScoreTtlEN objCjClsScoreTtlEN)
{
 clsCjClsScoreTtlBL.CjClsScoreTtlDA.CheckPropertyNew(objCjClsScoreTtlEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsCjClsScoreTtlEN objCjClsScoreTtlEN)
{
 clsCjClsScoreTtlBL.CjClsScoreTtlDA.CheckProperty4Condition(objCjClsScoreTtlEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCjClsScoreTtlEN objCjClsScoreTtlCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCjClsScoreTtlCond.IsUpdated(conCjClsScoreTtl.mId) == true)
{
string strComparisonOpmId = objCjClsScoreTtlCond.dicFldComparisonOp[conCjClsScoreTtl.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conCjClsScoreTtl.mId, objCjClsScoreTtlCond.mId, strComparisonOpmId);
}
if (objCjClsScoreTtlCond.IsUpdated(conCjClsScoreTtl.ExamBatchId) == true)
{
string strComparisonOpExamBatchId = objCjClsScoreTtlCond.dicFldComparisonOp[conCjClsScoreTtl.ExamBatchId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCjClsScoreTtl.ExamBatchId, objCjClsScoreTtlCond.ExamBatchId, strComparisonOpExamBatchId);
}
if (objCjClsScoreTtlCond.IsUpdated(conCjClsScoreTtl.IdCourse) == true)
{
string strComparisonOpIdCourse = objCjClsScoreTtlCond.dicFldComparisonOp[conCjClsScoreTtl.IdCourse];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCjClsScoreTtl.IdCourse, objCjClsScoreTtlCond.IdCourse, strComparisonOpIdCourse);
}
if (objCjClsScoreTtlCond.IsUpdated(conCjClsScoreTtl.IdEduCls) == true)
{
string strComparisonOpIdEduCls = objCjClsScoreTtlCond.dicFldComparisonOp[conCjClsScoreTtl.IdEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCjClsScoreTtl.IdEduCls, objCjClsScoreTtlCond.IdEduCls, strComparisonOpIdEduCls);
}
if (objCjClsScoreTtlCond.IsUpdated(conCjClsScoreTtl.IdAdminCls) == true)
{
string strComparisonOpIdAdminCls = objCjClsScoreTtlCond.dicFldComparisonOp[conCjClsScoreTtl.IdAdminCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCjClsScoreTtl.IdAdminCls, objCjClsScoreTtlCond.IdAdminCls, strComparisonOpIdAdminCls);
}
if (objCjClsScoreTtlCond.IsUpdated(conCjClsScoreTtl.StuNum) == true)
{
string strComparisonOpStuNum = objCjClsScoreTtlCond.dicFldComparisonOp[conCjClsScoreTtl.StuNum];
strWhereCond += string.Format(" And {0} {2} {1}", conCjClsScoreTtl.StuNum, objCjClsScoreTtlCond.StuNum, strComparisonOpStuNum);
}
if (objCjClsScoreTtlCond.IsUpdated(conCjClsScoreTtl.AvgScore) == true)
{
string strComparisonOpAvgScore = objCjClsScoreTtlCond.dicFldComparisonOp[conCjClsScoreTtl.AvgScore];
strWhereCond += string.Format(" And {0} {2} {1}", conCjClsScoreTtl.AvgScore, objCjClsScoreTtlCond.AvgScore, strComparisonOpAvgScore);
}
if (objCjClsScoreTtlCond.IsUpdated(conCjClsScoreTtl.Ranking) == true)
{
string strComparisonOpRanking = objCjClsScoreTtlCond.dicFldComparisonOp[conCjClsScoreTtl.Ranking];
strWhereCond += string.Format(" And {0} {2} {1}", conCjClsScoreTtl.Ranking, objCjClsScoreTtlCond.Ranking, strComparisonOpRanking);
}
if (objCjClsScoreTtlCond.IsUpdated(conCjClsScoreTtl.Percentile) == true)
{
string strComparisonOpPercentile = objCjClsScoreTtlCond.dicFldComparisonOp[conCjClsScoreTtl.Percentile];
strWhereCond += string.Format(" And {0} {2} {1}", conCjClsScoreTtl.Percentile, objCjClsScoreTtlCond.Percentile, strComparisonOpPercentile);
}
if (objCjClsScoreTtlCond.IsUpdated(conCjClsScoreTtl.ExcellentRate) == true)
{
string strComparisonOpExcellentRate = objCjClsScoreTtlCond.dicFldComparisonOp[conCjClsScoreTtl.ExcellentRate];
strWhereCond += string.Format(" And {0} {2} {1}", conCjClsScoreTtl.ExcellentRate, objCjClsScoreTtlCond.ExcellentRate, strComparisonOpExcellentRate);
}
if (objCjClsScoreTtlCond.IsUpdated(conCjClsScoreTtl.ExcellentGoodRate) == true)
{
string strComparisonOpExcellentGoodRate = objCjClsScoreTtlCond.dicFldComparisonOp[conCjClsScoreTtl.ExcellentGoodRate];
strWhereCond += string.Format(" And {0} {2} {1}", conCjClsScoreTtl.ExcellentGoodRate, objCjClsScoreTtlCond.ExcellentGoodRate, strComparisonOpExcellentGoodRate);
}
if (objCjClsScoreTtlCond.IsUpdated(conCjClsScoreTtl.PassingRate) == true)
{
string strComparisonOpPassingRate = objCjClsScoreTtlCond.dicFldComparisonOp[conCjClsScoreTtl.PassingRate];
strWhereCond += string.Format(" And {0} {2} {1}", conCjClsScoreTtl.PassingRate, objCjClsScoreTtlCond.PassingRate, strComparisonOpPassingRate);
}
if (objCjClsScoreTtlCond.IsUpdated(conCjClsScoreTtl.ExtremeRate) == true)
{
string strComparisonOpExtremeRate = objCjClsScoreTtlCond.dicFldComparisonOp[conCjClsScoreTtl.ExtremeRate];
strWhereCond += string.Format(" And {0} {2} {1}", conCjClsScoreTtl.ExtremeRate, objCjClsScoreTtlCond.ExtremeRate, strComparisonOpExtremeRate);
}
if (objCjClsScoreTtlCond.IsUpdated(conCjClsScoreTtl.StandardDeviation) == true)
{
string strComparisonOpStandardDeviation = objCjClsScoreTtlCond.dicFldComparisonOp[conCjClsScoreTtl.StandardDeviation];
strWhereCond += string.Format(" And {0} {2} {1}", conCjClsScoreTtl.StandardDeviation, objCjClsScoreTtlCond.StandardDeviation, strComparisonOpStandardDeviation);
}
if (objCjClsScoreTtlCond.IsUpdated(conCjClsScoreTtl.FullScore) == true)
{
string strComparisonOpFullScore = objCjClsScoreTtlCond.dicFldComparisonOp[conCjClsScoreTtl.FullScore];
strWhereCond += string.Format(" And {0} {2} {1}", conCjClsScoreTtl.FullScore, objCjClsScoreTtlCond.FullScore, strComparisonOpFullScore);
}
if (objCjClsScoreTtlCond.IsUpdated(conCjClsScoreTtl.SchoolYear) == true)
{
string strComparisonOpSchoolYear = objCjClsScoreTtlCond.dicFldComparisonOp[conCjClsScoreTtl.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCjClsScoreTtl.SchoolYear, objCjClsScoreTtlCond.SchoolYear, strComparisonOpSchoolYear);
}
if (objCjClsScoreTtlCond.IsUpdated(conCjClsScoreTtl.SchoolTerm) == true)
{
string strComparisonOpSchoolTerm = objCjClsScoreTtlCond.dicFldComparisonOp[conCjClsScoreTtl.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCjClsScoreTtl.SchoolTerm, objCjClsScoreTtlCond.SchoolTerm, strComparisonOpSchoolTerm);
}
if (objCjClsScoreTtlCond.IsUpdated(conCjClsScoreTtl.UpdDate) == true)
{
string strComparisonOpUpdDate = objCjClsScoreTtlCond.dicFldComparisonOp[conCjClsScoreTtl.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCjClsScoreTtl.UpdDate, objCjClsScoreTtlCond.UpdDate, strComparisonOpUpdDate);
}
if (objCjClsScoreTtlCond.IsUpdated(conCjClsScoreTtl.UpdUser) == true)
{
string strComparisonOpUpdUser = objCjClsScoreTtlCond.dicFldComparisonOp[conCjClsScoreTtl.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCjClsScoreTtl.UpdUser, objCjClsScoreTtlCond.UpdUser, strComparisonOpUpdUser);
}
if (objCjClsScoreTtlCond.IsUpdated(conCjClsScoreTtl.Memo) == true)
{
string strComparisonOpMemo = objCjClsScoreTtlCond.dicFldComparisonOp[conCjClsScoreTtl.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCjClsScoreTtl.Memo, objCjClsScoreTtlCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--CjClsScoreTtl(班级成绩汇总), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:id_EduCls_ExamBatchId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsCjClsScoreTtlEN objCjClsScoreTtlEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objCjClsScoreTtlEN == null) return true;
if (objCjClsScoreTtlEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdEduCls = '{0}'", objCjClsScoreTtlEN.IdEduCls);
 sbCondition.AppendFormat(" and ExamBatchId = '{0}'", objCjClsScoreTtlEN.ExamBatchId);
if (clsCjClsScoreTtlBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objCjClsScoreTtlEN.mId);
 sbCondition.AppendFormat(" and IdEduCls = '{0}'", objCjClsScoreTtlEN.IdEduCls);
 sbCondition.AppendFormat(" and ExamBatchId = '{0}'", objCjClsScoreTtlEN.ExamBatchId);
if (clsCjClsScoreTtlBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--CjClsScoreTtl(班级成绩汇总), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:id_EduCls_ExamBatchId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsCjClsScoreTtlEN objCjClsScoreTtlEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCjClsScoreTtlEN == null) return "";
if (objCjClsScoreTtlEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdEduCls = '{0}'", objCjClsScoreTtlEN.IdEduCls);
 sbCondition.AppendFormat(" and ExamBatchId = '{0}'", objCjClsScoreTtlEN.ExamBatchId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objCjClsScoreTtlEN.mId);
 sbCondition.AppendFormat(" and IdEduCls = '{0}'", objCjClsScoreTtlEN.IdEduCls);
 sbCondition.AppendFormat(" and ExamBatchId = '{0}'", objCjClsScoreTtlEN.ExamBatchId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_CjClsScoreTtl
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 班级成绩汇总(CjClsScoreTtl)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsCjClsScoreTtlBL
{
public static RelatedActions_CjClsScoreTtl relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsCjClsScoreTtlDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsCjClsScoreTtlDA CjClsScoreTtlDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsCjClsScoreTtlDA();
}
return uniqueInstance;
}
}

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsCjClsScoreTtlBL()
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
if (string.IsNullOrEmpty(clsCjClsScoreTtlEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCjClsScoreTtlEN._ConnectString);
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
public static DataTable GetDataTable_CjClsScoreTtl(string strWhereCond)
{
DataTable objDT;
try
{
objDT = CjClsScoreTtlDA.GetDataTable_CjClsScoreTtl(strWhereCond);
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
objDT = CjClsScoreTtlDA.GetDataTable(strWhereCond);
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
objDT = CjClsScoreTtlDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = CjClsScoreTtlDA.GetDataTable(strWhereCond, strTabName);
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
objDT = CjClsScoreTtlDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = CjClsScoreTtlDA.GetDataTable_Top(objTopPara);
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
objDT = CjClsScoreTtlDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = CjClsScoreTtlDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = CjClsScoreTtlDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsCjClsScoreTtlEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsCjClsScoreTtlEN> arrObjLst = new List<clsCjClsScoreTtlEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMIdLst);
 string strWhereCond = string.Format("mId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCjClsScoreTtlEN objCjClsScoreTtlEN = new clsCjClsScoreTtlEN();
try
{
objCjClsScoreTtlEN.mId = Int32.Parse(objRow[conCjClsScoreTtl.mId].ToString().Trim()); //mId
objCjClsScoreTtlEN.ExamBatchId = objRow[conCjClsScoreTtl.ExamBatchId].ToString().Trim(); //考试批次ID
objCjClsScoreTtlEN.IdCourse = objRow[conCjClsScoreTtl.IdCourse].ToString().Trim(); //课程流水号
objCjClsScoreTtlEN.IdEduCls = objRow[conCjClsScoreTtl.IdEduCls].ToString().Trim(); //教学班流水号
objCjClsScoreTtlEN.IdAdminCls = objRow[conCjClsScoreTtl.IdAdminCls] == DBNull.Value ? null : objRow[conCjClsScoreTtl.IdAdminCls].ToString().Trim(); //行政班流水号
objCjClsScoreTtlEN.StuNum = objRow[conCjClsScoreTtl.StuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCjClsScoreTtl.StuNum].ToString().Trim()); //学生数
objCjClsScoreTtlEN.AvgScore = objRow[conCjClsScoreTtl.AvgScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.AvgScore].ToString().Trim()); //平均分
objCjClsScoreTtlEN.Ranking = objRow[conCjClsScoreTtl.Ranking] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCjClsScoreTtl.Ranking].ToString().Trim()); //名次
objCjClsScoreTtlEN.Percentile = objRow[conCjClsScoreTtl.Percentile] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.Percentile].ToString().Trim()); //百分位
objCjClsScoreTtlEN.ExcellentRate = objRow[conCjClsScoreTtl.ExcellentRate] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.ExcellentRate].ToString().Trim()); //优秀率
objCjClsScoreTtlEN.ExcellentGoodRate = objRow[conCjClsScoreTtl.ExcellentGoodRate] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.ExcellentGoodRate].ToString().Trim()); //优良率
objCjClsScoreTtlEN.PassingRate = objRow[conCjClsScoreTtl.PassingRate] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.PassingRate].ToString().Trim()); //及格率
objCjClsScoreTtlEN.ExtremeRate = objRow[conCjClsScoreTtl.ExtremeRate] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.ExtremeRate].ToString().Trim()); //极差率
objCjClsScoreTtlEN.StandardDeviation = objRow[conCjClsScoreTtl.StandardDeviation] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.StandardDeviation].ToString().Trim()); //标准差
objCjClsScoreTtlEN.FullScore = objRow[conCjClsScoreTtl.FullScore] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCjClsScoreTtl.FullScore].ToString().Trim()); //满分
objCjClsScoreTtlEN.SchoolYear = objRow[conCjClsScoreTtl.SchoolYear] == DBNull.Value ? null : objRow[conCjClsScoreTtl.SchoolYear].ToString().Trim(); //学年
objCjClsScoreTtlEN.SchoolTerm = objRow[conCjClsScoreTtl.SchoolTerm] == DBNull.Value ? null : objRow[conCjClsScoreTtl.SchoolTerm].ToString().Trim(); //学期
objCjClsScoreTtlEN.UpdDate = objRow[conCjClsScoreTtl.UpdDate].ToString().Trim(); //修改日期
objCjClsScoreTtlEN.UpdUser = objRow[conCjClsScoreTtl.UpdUser].ToString().Trim(); //修改人
objCjClsScoreTtlEN.Memo = objRow[conCjClsScoreTtl.Memo] == DBNull.Value ? null : objRow[conCjClsScoreTtl.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCjClsScoreTtlEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCjClsScoreTtlEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsCjClsScoreTtlEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsCjClsScoreTtlEN._CurrTabName);
List<clsCjClsScoreTtlEN> arrCjClsScoreTtlObjLstCache = GetObjLstCache();
IEnumerable <clsCjClsScoreTtlEN> arrCjClsScoreTtlObjLst_Sel =
arrCjClsScoreTtlObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrCjClsScoreTtlObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCjClsScoreTtlEN> GetObjLst(string strWhereCond)
{
List<clsCjClsScoreTtlEN> arrObjLst = new List<clsCjClsScoreTtlEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCjClsScoreTtlEN objCjClsScoreTtlEN = new clsCjClsScoreTtlEN();
try
{
objCjClsScoreTtlEN.mId = Int32.Parse(objRow[conCjClsScoreTtl.mId].ToString().Trim()); //mId
objCjClsScoreTtlEN.ExamBatchId = objRow[conCjClsScoreTtl.ExamBatchId].ToString().Trim(); //考试批次ID
objCjClsScoreTtlEN.IdCourse = objRow[conCjClsScoreTtl.IdCourse].ToString().Trim(); //课程流水号
objCjClsScoreTtlEN.IdEduCls = objRow[conCjClsScoreTtl.IdEduCls].ToString().Trim(); //教学班流水号
objCjClsScoreTtlEN.IdAdminCls = objRow[conCjClsScoreTtl.IdAdminCls] == DBNull.Value ? null : objRow[conCjClsScoreTtl.IdAdminCls].ToString().Trim(); //行政班流水号
objCjClsScoreTtlEN.StuNum = objRow[conCjClsScoreTtl.StuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCjClsScoreTtl.StuNum].ToString().Trim()); //学生数
objCjClsScoreTtlEN.AvgScore = objRow[conCjClsScoreTtl.AvgScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.AvgScore].ToString().Trim()); //平均分
objCjClsScoreTtlEN.Ranking = objRow[conCjClsScoreTtl.Ranking] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCjClsScoreTtl.Ranking].ToString().Trim()); //名次
objCjClsScoreTtlEN.Percentile = objRow[conCjClsScoreTtl.Percentile] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.Percentile].ToString().Trim()); //百分位
objCjClsScoreTtlEN.ExcellentRate = objRow[conCjClsScoreTtl.ExcellentRate] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.ExcellentRate].ToString().Trim()); //优秀率
objCjClsScoreTtlEN.ExcellentGoodRate = objRow[conCjClsScoreTtl.ExcellentGoodRate] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.ExcellentGoodRate].ToString().Trim()); //优良率
objCjClsScoreTtlEN.PassingRate = objRow[conCjClsScoreTtl.PassingRate] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.PassingRate].ToString().Trim()); //及格率
objCjClsScoreTtlEN.ExtremeRate = objRow[conCjClsScoreTtl.ExtremeRate] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.ExtremeRate].ToString().Trim()); //极差率
objCjClsScoreTtlEN.StandardDeviation = objRow[conCjClsScoreTtl.StandardDeviation] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.StandardDeviation].ToString().Trim()); //标准差
objCjClsScoreTtlEN.FullScore = objRow[conCjClsScoreTtl.FullScore] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCjClsScoreTtl.FullScore].ToString().Trim()); //满分
objCjClsScoreTtlEN.SchoolYear = objRow[conCjClsScoreTtl.SchoolYear] == DBNull.Value ? null : objRow[conCjClsScoreTtl.SchoolYear].ToString().Trim(); //学年
objCjClsScoreTtlEN.SchoolTerm = objRow[conCjClsScoreTtl.SchoolTerm] == DBNull.Value ? null : objRow[conCjClsScoreTtl.SchoolTerm].ToString().Trim(); //学期
objCjClsScoreTtlEN.UpdDate = objRow[conCjClsScoreTtl.UpdDate].ToString().Trim(); //修改日期
objCjClsScoreTtlEN.UpdUser = objRow[conCjClsScoreTtl.UpdUser].ToString().Trim(); //修改人
objCjClsScoreTtlEN.Memo = objRow[conCjClsScoreTtl.Memo] == DBNull.Value ? null : objRow[conCjClsScoreTtl.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCjClsScoreTtlEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCjClsScoreTtlEN);
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
public static List<clsCjClsScoreTtlEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsCjClsScoreTtlEN> arrObjLst = new List<clsCjClsScoreTtlEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCjClsScoreTtlEN objCjClsScoreTtlEN = new clsCjClsScoreTtlEN();
try
{
objCjClsScoreTtlEN.mId = Int32.Parse(objRow[conCjClsScoreTtl.mId].ToString().Trim()); //mId
objCjClsScoreTtlEN.ExamBatchId = objRow[conCjClsScoreTtl.ExamBatchId].ToString().Trim(); //考试批次ID
objCjClsScoreTtlEN.IdCourse = objRow[conCjClsScoreTtl.IdCourse].ToString().Trim(); //课程流水号
objCjClsScoreTtlEN.IdEduCls = objRow[conCjClsScoreTtl.IdEduCls].ToString().Trim(); //教学班流水号
objCjClsScoreTtlEN.IdAdminCls = objRow[conCjClsScoreTtl.IdAdminCls] == DBNull.Value ? null : objRow[conCjClsScoreTtl.IdAdminCls].ToString().Trim(); //行政班流水号
objCjClsScoreTtlEN.StuNum = objRow[conCjClsScoreTtl.StuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCjClsScoreTtl.StuNum].ToString().Trim()); //学生数
objCjClsScoreTtlEN.AvgScore = objRow[conCjClsScoreTtl.AvgScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.AvgScore].ToString().Trim()); //平均分
objCjClsScoreTtlEN.Ranking = objRow[conCjClsScoreTtl.Ranking] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCjClsScoreTtl.Ranking].ToString().Trim()); //名次
objCjClsScoreTtlEN.Percentile = objRow[conCjClsScoreTtl.Percentile] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.Percentile].ToString().Trim()); //百分位
objCjClsScoreTtlEN.ExcellentRate = objRow[conCjClsScoreTtl.ExcellentRate] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.ExcellentRate].ToString().Trim()); //优秀率
objCjClsScoreTtlEN.ExcellentGoodRate = objRow[conCjClsScoreTtl.ExcellentGoodRate] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.ExcellentGoodRate].ToString().Trim()); //优良率
objCjClsScoreTtlEN.PassingRate = objRow[conCjClsScoreTtl.PassingRate] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.PassingRate].ToString().Trim()); //及格率
objCjClsScoreTtlEN.ExtremeRate = objRow[conCjClsScoreTtl.ExtremeRate] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.ExtremeRate].ToString().Trim()); //极差率
objCjClsScoreTtlEN.StandardDeviation = objRow[conCjClsScoreTtl.StandardDeviation] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.StandardDeviation].ToString().Trim()); //标准差
objCjClsScoreTtlEN.FullScore = objRow[conCjClsScoreTtl.FullScore] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCjClsScoreTtl.FullScore].ToString().Trim()); //满分
objCjClsScoreTtlEN.SchoolYear = objRow[conCjClsScoreTtl.SchoolYear] == DBNull.Value ? null : objRow[conCjClsScoreTtl.SchoolYear].ToString().Trim(); //学年
objCjClsScoreTtlEN.SchoolTerm = objRow[conCjClsScoreTtl.SchoolTerm] == DBNull.Value ? null : objRow[conCjClsScoreTtl.SchoolTerm].ToString().Trim(); //学期
objCjClsScoreTtlEN.UpdDate = objRow[conCjClsScoreTtl.UpdDate].ToString().Trim(); //修改日期
objCjClsScoreTtlEN.UpdUser = objRow[conCjClsScoreTtl.UpdUser].ToString().Trim(); //修改人
objCjClsScoreTtlEN.Memo = objRow[conCjClsScoreTtl.Memo] == DBNull.Value ? null : objRow[conCjClsScoreTtl.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCjClsScoreTtlEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCjClsScoreTtlEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objCjClsScoreTtlCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsCjClsScoreTtlEN> GetSubObjLstCache(clsCjClsScoreTtlEN objCjClsScoreTtlCond)
{
List<clsCjClsScoreTtlEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsCjClsScoreTtlEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCjClsScoreTtl.AttributeName)
{
if (objCjClsScoreTtlCond.IsUpdated(strFldName) == false) continue;
if (objCjClsScoreTtlCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCjClsScoreTtlCond[strFldName].ToString());
}
else
{
if (objCjClsScoreTtlCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCjClsScoreTtlCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCjClsScoreTtlCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCjClsScoreTtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCjClsScoreTtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCjClsScoreTtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCjClsScoreTtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCjClsScoreTtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCjClsScoreTtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCjClsScoreTtlCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCjClsScoreTtlCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCjClsScoreTtlCond[strFldName]));
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
public static List<clsCjClsScoreTtlEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsCjClsScoreTtlEN> arrObjLst = new List<clsCjClsScoreTtlEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCjClsScoreTtlEN objCjClsScoreTtlEN = new clsCjClsScoreTtlEN();
try
{
objCjClsScoreTtlEN.mId = Int32.Parse(objRow[conCjClsScoreTtl.mId].ToString().Trim()); //mId
objCjClsScoreTtlEN.ExamBatchId = objRow[conCjClsScoreTtl.ExamBatchId].ToString().Trim(); //考试批次ID
objCjClsScoreTtlEN.IdCourse = objRow[conCjClsScoreTtl.IdCourse].ToString().Trim(); //课程流水号
objCjClsScoreTtlEN.IdEduCls = objRow[conCjClsScoreTtl.IdEduCls].ToString().Trim(); //教学班流水号
objCjClsScoreTtlEN.IdAdminCls = objRow[conCjClsScoreTtl.IdAdminCls] == DBNull.Value ? null : objRow[conCjClsScoreTtl.IdAdminCls].ToString().Trim(); //行政班流水号
objCjClsScoreTtlEN.StuNum = objRow[conCjClsScoreTtl.StuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCjClsScoreTtl.StuNum].ToString().Trim()); //学生数
objCjClsScoreTtlEN.AvgScore = objRow[conCjClsScoreTtl.AvgScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.AvgScore].ToString().Trim()); //平均分
objCjClsScoreTtlEN.Ranking = objRow[conCjClsScoreTtl.Ranking] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCjClsScoreTtl.Ranking].ToString().Trim()); //名次
objCjClsScoreTtlEN.Percentile = objRow[conCjClsScoreTtl.Percentile] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.Percentile].ToString().Trim()); //百分位
objCjClsScoreTtlEN.ExcellentRate = objRow[conCjClsScoreTtl.ExcellentRate] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.ExcellentRate].ToString().Trim()); //优秀率
objCjClsScoreTtlEN.ExcellentGoodRate = objRow[conCjClsScoreTtl.ExcellentGoodRate] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.ExcellentGoodRate].ToString().Trim()); //优良率
objCjClsScoreTtlEN.PassingRate = objRow[conCjClsScoreTtl.PassingRate] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.PassingRate].ToString().Trim()); //及格率
objCjClsScoreTtlEN.ExtremeRate = objRow[conCjClsScoreTtl.ExtremeRate] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.ExtremeRate].ToString().Trim()); //极差率
objCjClsScoreTtlEN.StandardDeviation = objRow[conCjClsScoreTtl.StandardDeviation] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.StandardDeviation].ToString().Trim()); //标准差
objCjClsScoreTtlEN.FullScore = objRow[conCjClsScoreTtl.FullScore] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCjClsScoreTtl.FullScore].ToString().Trim()); //满分
objCjClsScoreTtlEN.SchoolYear = objRow[conCjClsScoreTtl.SchoolYear] == DBNull.Value ? null : objRow[conCjClsScoreTtl.SchoolYear].ToString().Trim(); //学年
objCjClsScoreTtlEN.SchoolTerm = objRow[conCjClsScoreTtl.SchoolTerm] == DBNull.Value ? null : objRow[conCjClsScoreTtl.SchoolTerm].ToString().Trim(); //学期
objCjClsScoreTtlEN.UpdDate = objRow[conCjClsScoreTtl.UpdDate].ToString().Trim(); //修改日期
objCjClsScoreTtlEN.UpdUser = objRow[conCjClsScoreTtl.UpdUser].ToString().Trim(); //修改人
objCjClsScoreTtlEN.Memo = objRow[conCjClsScoreTtl.Memo] == DBNull.Value ? null : objRow[conCjClsScoreTtl.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCjClsScoreTtlEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCjClsScoreTtlEN);
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
public static List<clsCjClsScoreTtlEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsCjClsScoreTtlEN> arrObjLst = new List<clsCjClsScoreTtlEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCjClsScoreTtlEN objCjClsScoreTtlEN = new clsCjClsScoreTtlEN();
try
{
objCjClsScoreTtlEN.mId = Int32.Parse(objRow[conCjClsScoreTtl.mId].ToString().Trim()); //mId
objCjClsScoreTtlEN.ExamBatchId = objRow[conCjClsScoreTtl.ExamBatchId].ToString().Trim(); //考试批次ID
objCjClsScoreTtlEN.IdCourse = objRow[conCjClsScoreTtl.IdCourse].ToString().Trim(); //课程流水号
objCjClsScoreTtlEN.IdEduCls = objRow[conCjClsScoreTtl.IdEduCls].ToString().Trim(); //教学班流水号
objCjClsScoreTtlEN.IdAdminCls = objRow[conCjClsScoreTtl.IdAdminCls] == DBNull.Value ? null : objRow[conCjClsScoreTtl.IdAdminCls].ToString().Trim(); //行政班流水号
objCjClsScoreTtlEN.StuNum = objRow[conCjClsScoreTtl.StuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCjClsScoreTtl.StuNum].ToString().Trim()); //学生数
objCjClsScoreTtlEN.AvgScore = objRow[conCjClsScoreTtl.AvgScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.AvgScore].ToString().Trim()); //平均分
objCjClsScoreTtlEN.Ranking = objRow[conCjClsScoreTtl.Ranking] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCjClsScoreTtl.Ranking].ToString().Trim()); //名次
objCjClsScoreTtlEN.Percentile = objRow[conCjClsScoreTtl.Percentile] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.Percentile].ToString().Trim()); //百分位
objCjClsScoreTtlEN.ExcellentRate = objRow[conCjClsScoreTtl.ExcellentRate] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.ExcellentRate].ToString().Trim()); //优秀率
objCjClsScoreTtlEN.ExcellentGoodRate = objRow[conCjClsScoreTtl.ExcellentGoodRate] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.ExcellentGoodRate].ToString().Trim()); //优良率
objCjClsScoreTtlEN.PassingRate = objRow[conCjClsScoreTtl.PassingRate] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.PassingRate].ToString().Trim()); //及格率
objCjClsScoreTtlEN.ExtremeRate = objRow[conCjClsScoreTtl.ExtremeRate] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.ExtremeRate].ToString().Trim()); //极差率
objCjClsScoreTtlEN.StandardDeviation = objRow[conCjClsScoreTtl.StandardDeviation] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.StandardDeviation].ToString().Trim()); //标准差
objCjClsScoreTtlEN.FullScore = objRow[conCjClsScoreTtl.FullScore] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCjClsScoreTtl.FullScore].ToString().Trim()); //满分
objCjClsScoreTtlEN.SchoolYear = objRow[conCjClsScoreTtl.SchoolYear] == DBNull.Value ? null : objRow[conCjClsScoreTtl.SchoolYear].ToString().Trim(); //学年
objCjClsScoreTtlEN.SchoolTerm = objRow[conCjClsScoreTtl.SchoolTerm] == DBNull.Value ? null : objRow[conCjClsScoreTtl.SchoolTerm].ToString().Trim(); //学期
objCjClsScoreTtlEN.UpdDate = objRow[conCjClsScoreTtl.UpdDate].ToString().Trim(); //修改日期
objCjClsScoreTtlEN.UpdUser = objRow[conCjClsScoreTtl.UpdUser].ToString().Trim(); //修改人
objCjClsScoreTtlEN.Memo = objRow[conCjClsScoreTtl.Memo] == DBNull.Value ? null : objRow[conCjClsScoreTtl.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCjClsScoreTtlEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCjClsScoreTtlEN);
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
List<clsCjClsScoreTtlEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsCjClsScoreTtlEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsCjClsScoreTtlEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsCjClsScoreTtlEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsCjClsScoreTtlEN> arrObjLst = new List<clsCjClsScoreTtlEN>(); 
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
	clsCjClsScoreTtlEN objCjClsScoreTtlEN = new clsCjClsScoreTtlEN();
try
{
objCjClsScoreTtlEN.mId = Int32.Parse(objRow[conCjClsScoreTtl.mId].ToString().Trim()); //mId
objCjClsScoreTtlEN.ExamBatchId = objRow[conCjClsScoreTtl.ExamBatchId].ToString().Trim(); //考试批次ID
objCjClsScoreTtlEN.IdCourse = objRow[conCjClsScoreTtl.IdCourse].ToString().Trim(); //课程流水号
objCjClsScoreTtlEN.IdEduCls = objRow[conCjClsScoreTtl.IdEduCls].ToString().Trim(); //教学班流水号
objCjClsScoreTtlEN.IdAdminCls = objRow[conCjClsScoreTtl.IdAdminCls] == DBNull.Value ? null : objRow[conCjClsScoreTtl.IdAdminCls].ToString().Trim(); //行政班流水号
objCjClsScoreTtlEN.StuNum = objRow[conCjClsScoreTtl.StuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCjClsScoreTtl.StuNum].ToString().Trim()); //学生数
objCjClsScoreTtlEN.AvgScore = objRow[conCjClsScoreTtl.AvgScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.AvgScore].ToString().Trim()); //平均分
objCjClsScoreTtlEN.Ranking = objRow[conCjClsScoreTtl.Ranking] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCjClsScoreTtl.Ranking].ToString().Trim()); //名次
objCjClsScoreTtlEN.Percentile = objRow[conCjClsScoreTtl.Percentile] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.Percentile].ToString().Trim()); //百分位
objCjClsScoreTtlEN.ExcellentRate = objRow[conCjClsScoreTtl.ExcellentRate] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.ExcellentRate].ToString().Trim()); //优秀率
objCjClsScoreTtlEN.ExcellentGoodRate = objRow[conCjClsScoreTtl.ExcellentGoodRate] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.ExcellentGoodRate].ToString().Trim()); //优良率
objCjClsScoreTtlEN.PassingRate = objRow[conCjClsScoreTtl.PassingRate] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.PassingRate].ToString().Trim()); //及格率
objCjClsScoreTtlEN.ExtremeRate = objRow[conCjClsScoreTtl.ExtremeRate] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.ExtremeRate].ToString().Trim()); //极差率
objCjClsScoreTtlEN.StandardDeviation = objRow[conCjClsScoreTtl.StandardDeviation] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.StandardDeviation].ToString().Trim()); //标准差
objCjClsScoreTtlEN.FullScore = objRow[conCjClsScoreTtl.FullScore] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCjClsScoreTtl.FullScore].ToString().Trim()); //满分
objCjClsScoreTtlEN.SchoolYear = objRow[conCjClsScoreTtl.SchoolYear] == DBNull.Value ? null : objRow[conCjClsScoreTtl.SchoolYear].ToString().Trim(); //学年
objCjClsScoreTtlEN.SchoolTerm = objRow[conCjClsScoreTtl.SchoolTerm] == DBNull.Value ? null : objRow[conCjClsScoreTtl.SchoolTerm].ToString().Trim(); //学期
objCjClsScoreTtlEN.UpdDate = objRow[conCjClsScoreTtl.UpdDate].ToString().Trim(); //修改日期
objCjClsScoreTtlEN.UpdUser = objRow[conCjClsScoreTtl.UpdUser].ToString().Trim(); //修改人
objCjClsScoreTtlEN.Memo = objRow[conCjClsScoreTtl.Memo] == DBNull.Value ? null : objRow[conCjClsScoreTtl.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCjClsScoreTtlEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCjClsScoreTtlEN);
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
public static List<clsCjClsScoreTtlEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsCjClsScoreTtlEN> arrObjLst = new List<clsCjClsScoreTtlEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCjClsScoreTtlEN objCjClsScoreTtlEN = new clsCjClsScoreTtlEN();
try
{
objCjClsScoreTtlEN.mId = Int32.Parse(objRow[conCjClsScoreTtl.mId].ToString().Trim()); //mId
objCjClsScoreTtlEN.ExamBatchId = objRow[conCjClsScoreTtl.ExamBatchId].ToString().Trim(); //考试批次ID
objCjClsScoreTtlEN.IdCourse = objRow[conCjClsScoreTtl.IdCourse].ToString().Trim(); //课程流水号
objCjClsScoreTtlEN.IdEduCls = objRow[conCjClsScoreTtl.IdEduCls].ToString().Trim(); //教学班流水号
objCjClsScoreTtlEN.IdAdminCls = objRow[conCjClsScoreTtl.IdAdminCls] == DBNull.Value ? null : objRow[conCjClsScoreTtl.IdAdminCls].ToString().Trim(); //行政班流水号
objCjClsScoreTtlEN.StuNum = objRow[conCjClsScoreTtl.StuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCjClsScoreTtl.StuNum].ToString().Trim()); //学生数
objCjClsScoreTtlEN.AvgScore = objRow[conCjClsScoreTtl.AvgScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.AvgScore].ToString().Trim()); //平均分
objCjClsScoreTtlEN.Ranking = objRow[conCjClsScoreTtl.Ranking] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCjClsScoreTtl.Ranking].ToString().Trim()); //名次
objCjClsScoreTtlEN.Percentile = objRow[conCjClsScoreTtl.Percentile] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.Percentile].ToString().Trim()); //百分位
objCjClsScoreTtlEN.ExcellentRate = objRow[conCjClsScoreTtl.ExcellentRate] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.ExcellentRate].ToString().Trim()); //优秀率
objCjClsScoreTtlEN.ExcellentGoodRate = objRow[conCjClsScoreTtl.ExcellentGoodRate] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.ExcellentGoodRate].ToString().Trim()); //优良率
objCjClsScoreTtlEN.PassingRate = objRow[conCjClsScoreTtl.PassingRate] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.PassingRate].ToString().Trim()); //及格率
objCjClsScoreTtlEN.ExtremeRate = objRow[conCjClsScoreTtl.ExtremeRate] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.ExtremeRate].ToString().Trim()); //极差率
objCjClsScoreTtlEN.StandardDeviation = objRow[conCjClsScoreTtl.StandardDeviation] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.StandardDeviation].ToString().Trim()); //标准差
objCjClsScoreTtlEN.FullScore = objRow[conCjClsScoreTtl.FullScore] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCjClsScoreTtl.FullScore].ToString().Trim()); //满分
objCjClsScoreTtlEN.SchoolYear = objRow[conCjClsScoreTtl.SchoolYear] == DBNull.Value ? null : objRow[conCjClsScoreTtl.SchoolYear].ToString().Trim(); //学年
objCjClsScoreTtlEN.SchoolTerm = objRow[conCjClsScoreTtl.SchoolTerm] == DBNull.Value ? null : objRow[conCjClsScoreTtl.SchoolTerm].ToString().Trim(); //学期
objCjClsScoreTtlEN.UpdDate = objRow[conCjClsScoreTtl.UpdDate].ToString().Trim(); //修改日期
objCjClsScoreTtlEN.UpdUser = objRow[conCjClsScoreTtl.UpdUser].ToString().Trim(); //修改人
objCjClsScoreTtlEN.Memo = objRow[conCjClsScoreTtl.Memo] == DBNull.Value ? null : objRow[conCjClsScoreTtl.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCjClsScoreTtlEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCjClsScoreTtlEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsCjClsScoreTtlEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsCjClsScoreTtlEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsCjClsScoreTtlEN> arrObjLst = new List<clsCjClsScoreTtlEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCjClsScoreTtlEN objCjClsScoreTtlEN = new clsCjClsScoreTtlEN();
try
{
objCjClsScoreTtlEN.mId = Int32.Parse(objRow[conCjClsScoreTtl.mId].ToString().Trim()); //mId
objCjClsScoreTtlEN.ExamBatchId = objRow[conCjClsScoreTtl.ExamBatchId].ToString().Trim(); //考试批次ID
objCjClsScoreTtlEN.IdCourse = objRow[conCjClsScoreTtl.IdCourse].ToString().Trim(); //课程流水号
objCjClsScoreTtlEN.IdEduCls = objRow[conCjClsScoreTtl.IdEduCls].ToString().Trim(); //教学班流水号
objCjClsScoreTtlEN.IdAdminCls = objRow[conCjClsScoreTtl.IdAdminCls] == DBNull.Value ? null : objRow[conCjClsScoreTtl.IdAdminCls].ToString().Trim(); //行政班流水号
objCjClsScoreTtlEN.StuNum = objRow[conCjClsScoreTtl.StuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCjClsScoreTtl.StuNum].ToString().Trim()); //学生数
objCjClsScoreTtlEN.AvgScore = objRow[conCjClsScoreTtl.AvgScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.AvgScore].ToString().Trim()); //平均分
objCjClsScoreTtlEN.Ranking = objRow[conCjClsScoreTtl.Ranking] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCjClsScoreTtl.Ranking].ToString().Trim()); //名次
objCjClsScoreTtlEN.Percentile = objRow[conCjClsScoreTtl.Percentile] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.Percentile].ToString().Trim()); //百分位
objCjClsScoreTtlEN.ExcellentRate = objRow[conCjClsScoreTtl.ExcellentRate] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.ExcellentRate].ToString().Trim()); //优秀率
objCjClsScoreTtlEN.ExcellentGoodRate = objRow[conCjClsScoreTtl.ExcellentGoodRate] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.ExcellentGoodRate].ToString().Trim()); //优良率
objCjClsScoreTtlEN.PassingRate = objRow[conCjClsScoreTtl.PassingRate] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.PassingRate].ToString().Trim()); //及格率
objCjClsScoreTtlEN.ExtremeRate = objRow[conCjClsScoreTtl.ExtremeRate] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.ExtremeRate].ToString().Trim()); //极差率
objCjClsScoreTtlEN.StandardDeviation = objRow[conCjClsScoreTtl.StandardDeviation] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.StandardDeviation].ToString().Trim()); //标准差
objCjClsScoreTtlEN.FullScore = objRow[conCjClsScoreTtl.FullScore] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCjClsScoreTtl.FullScore].ToString().Trim()); //满分
objCjClsScoreTtlEN.SchoolYear = objRow[conCjClsScoreTtl.SchoolYear] == DBNull.Value ? null : objRow[conCjClsScoreTtl.SchoolYear].ToString().Trim(); //学年
objCjClsScoreTtlEN.SchoolTerm = objRow[conCjClsScoreTtl.SchoolTerm] == DBNull.Value ? null : objRow[conCjClsScoreTtl.SchoolTerm].ToString().Trim(); //学期
objCjClsScoreTtlEN.UpdDate = objRow[conCjClsScoreTtl.UpdDate].ToString().Trim(); //修改日期
objCjClsScoreTtlEN.UpdUser = objRow[conCjClsScoreTtl.UpdUser].ToString().Trim(); //修改人
objCjClsScoreTtlEN.Memo = objRow[conCjClsScoreTtl.Memo] == DBNull.Value ? null : objRow[conCjClsScoreTtl.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCjClsScoreTtlEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCjClsScoreTtlEN);
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
public static List<clsCjClsScoreTtlEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsCjClsScoreTtlEN> arrObjLst = new List<clsCjClsScoreTtlEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCjClsScoreTtlEN objCjClsScoreTtlEN = new clsCjClsScoreTtlEN();
try
{
objCjClsScoreTtlEN.mId = Int32.Parse(objRow[conCjClsScoreTtl.mId].ToString().Trim()); //mId
objCjClsScoreTtlEN.ExamBatchId = objRow[conCjClsScoreTtl.ExamBatchId].ToString().Trim(); //考试批次ID
objCjClsScoreTtlEN.IdCourse = objRow[conCjClsScoreTtl.IdCourse].ToString().Trim(); //课程流水号
objCjClsScoreTtlEN.IdEduCls = objRow[conCjClsScoreTtl.IdEduCls].ToString().Trim(); //教学班流水号
objCjClsScoreTtlEN.IdAdminCls = objRow[conCjClsScoreTtl.IdAdminCls] == DBNull.Value ? null : objRow[conCjClsScoreTtl.IdAdminCls].ToString().Trim(); //行政班流水号
objCjClsScoreTtlEN.StuNum = objRow[conCjClsScoreTtl.StuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCjClsScoreTtl.StuNum].ToString().Trim()); //学生数
objCjClsScoreTtlEN.AvgScore = objRow[conCjClsScoreTtl.AvgScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.AvgScore].ToString().Trim()); //平均分
objCjClsScoreTtlEN.Ranking = objRow[conCjClsScoreTtl.Ranking] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCjClsScoreTtl.Ranking].ToString().Trim()); //名次
objCjClsScoreTtlEN.Percentile = objRow[conCjClsScoreTtl.Percentile] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.Percentile].ToString().Trim()); //百分位
objCjClsScoreTtlEN.ExcellentRate = objRow[conCjClsScoreTtl.ExcellentRate] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.ExcellentRate].ToString().Trim()); //优秀率
objCjClsScoreTtlEN.ExcellentGoodRate = objRow[conCjClsScoreTtl.ExcellentGoodRate] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.ExcellentGoodRate].ToString().Trim()); //优良率
objCjClsScoreTtlEN.PassingRate = objRow[conCjClsScoreTtl.PassingRate] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.PassingRate].ToString().Trim()); //及格率
objCjClsScoreTtlEN.ExtremeRate = objRow[conCjClsScoreTtl.ExtremeRate] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.ExtremeRate].ToString().Trim()); //极差率
objCjClsScoreTtlEN.StandardDeviation = objRow[conCjClsScoreTtl.StandardDeviation] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.StandardDeviation].ToString().Trim()); //标准差
objCjClsScoreTtlEN.FullScore = objRow[conCjClsScoreTtl.FullScore] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCjClsScoreTtl.FullScore].ToString().Trim()); //满分
objCjClsScoreTtlEN.SchoolYear = objRow[conCjClsScoreTtl.SchoolYear] == DBNull.Value ? null : objRow[conCjClsScoreTtl.SchoolYear].ToString().Trim(); //学年
objCjClsScoreTtlEN.SchoolTerm = objRow[conCjClsScoreTtl.SchoolTerm] == DBNull.Value ? null : objRow[conCjClsScoreTtl.SchoolTerm].ToString().Trim(); //学期
objCjClsScoreTtlEN.UpdDate = objRow[conCjClsScoreTtl.UpdDate].ToString().Trim(); //修改日期
objCjClsScoreTtlEN.UpdUser = objRow[conCjClsScoreTtl.UpdUser].ToString().Trim(); //修改人
objCjClsScoreTtlEN.Memo = objRow[conCjClsScoreTtl.Memo] == DBNull.Value ? null : objRow[conCjClsScoreTtl.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCjClsScoreTtlEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCjClsScoreTtlEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsCjClsScoreTtlEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsCjClsScoreTtlEN> arrObjLst = new List<clsCjClsScoreTtlEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCjClsScoreTtlEN objCjClsScoreTtlEN = new clsCjClsScoreTtlEN();
try
{
objCjClsScoreTtlEN.mId = Int32.Parse(objRow[conCjClsScoreTtl.mId].ToString().Trim()); //mId
objCjClsScoreTtlEN.ExamBatchId = objRow[conCjClsScoreTtl.ExamBatchId].ToString().Trim(); //考试批次ID
objCjClsScoreTtlEN.IdCourse = objRow[conCjClsScoreTtl.IdCourse].ToString().Trim(); //课程流水号
objCjClsScoreTtlEN.IdEduCls = objRow[conCjClsScoreTtl.IdEduCls].ToString().Trim(); //教学班流水号
objCjClsScoreTtlEN.IdAdminCls = objRow[conCjClsScoreTtl.IdAdminCls] == DBNull.Value ? null : objRow[conCjClsScoreTtl.IdAdminCls].ToString().Trim(); //行政班流水号
objCjClsScoreTtlEN.StuNum = objRow[conCjClsScoreTtl.StuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCjClsScoreTtl.StuNum].ToString().Trim()); //学生数
objCjClsScoreTtlEN.AvgScore = objRow[conCjClsScoreTtl.AvgScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.AvgScore].ToString().Trim()); //平均分
objCjClsScoreTtlEN.Ranking = objRow[conCjClsScoreTtl.Ranking] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCjClsScoreTtl.Ranking].ToString().Trim()); //名次
objCjClsScoreTtlEN.Percentile = objRow[conCjClsScoreTtl.Percentile] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.Percentile].ToString().Trim()); //百分位
objCjClsScoreTtlEN.ExcellentRate = objRow[conCjClsScoreTtl.ExcellentRate] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.ExcellentRate].ToString().Trim()); //优秀率
objCjClsScoreTtlEN.ExcellentGoodRate = objRow[conCjClsScoreTtl.ExcellentGoodRate] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.ExcellentGoodRate].ToString().Trim()); //优良率
objCjClsScoreTtlEN.PassingRate = objRow[conCjClsScoreTtl.PassingRate] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.PassingRate].ToString().Trim()); //及格率
objCjClsScoreTtlEN.ExtremeRate = objRow[conCjClsScoreTtl.ExtremeRate] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.ExtremeRate].ToString().Trim()); //极差率
objCjClsScoreTtlEN.StandardDeviation = objRow[conCjClsScoreTtl.StandardDeviation] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.StandardDeviation].ToString().Trim()); //标准差
objCjClsScoreTtlEN.FullScore = objRow[conCjClsScoreTtl.FullScore] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCjClsScoreTtl.FullScore].ToString().Trim()); //满分
objCjClsScoreTtlEN.SchoolYear = objRow[conCjClsScoreTtl.SchoolYear] == DBNull.Value ? null : objRow[conCjClsScoreTtl.SchoolYear].ToString().Trim(); //学年
objCjClsScoreTtlEN.SchoolTerm = objRow[conCjClsScoreTtl.SchoolTerm] == DBNull.Value ? null : objRow[conCjClsScoreTtl.SchoolTerm].ToString().Trim(); //学期
objCjClsScoreTtlEN.UpdDate = objRow[conCjClsScoreTtl.UpdDate].ToString().Trim(); //修改日期
objCjClsScoreTtlEN.UpdUser = objRow[conCjClsScoreTtl.UpdUser].ToString().Trim(); //修改人
objCjClsScoreTtlEN.Memo = objRow[conCjClsScoreTtl.Memo] == DBNull.Value ? null : objRow[conCjClsScoreTtl.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCjClsScoreTtlEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCjClsScoreTtlEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetCjClsScoreTtl(ref clsCjClsScoreTtlEN objCjClsScoreTtlEN)
{
bool bolResult = CjClsScoreTtlDA.GetCjClsScoreTtl(ref objCjClsScoreTtlEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCjClsScoreTtlEN GetObjBymId(long lngmId)
{
clsCjClsScoreTtlEN objCjClsScoreTtlEN = CjClsScoreTtlDA.GetObjBymId(lngmId);
return objCjClsScoreTtlEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsCjClsScoreTtlEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsCjClsScoreTtlEN objCjClsScoreTtlEN = CjClsScoreTtlDA.GetFirstObj(strWhereCond);
 return objCjClsScoreTtlEN;
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
public static clsCjClsScoreTtlEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsCjClsScoreTtlEN objCjClsScoreTtlEN = CjClsScoreTtlDA.GetObjByDataRow(objRow);
 return objCjClsScoreTtlEN;
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
public static clsCjClsScoreTtlEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsCjClsScoreTtlEN objCjClsScoreTtlEN = CjClsScoreTtlDA.GetObjByDataRow(objRow);
 return objCjClsScoreTtlEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "lstCjClsScoreTtlObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCjClsScoreTtlEN GetObjBymIdFromList(long lngmId, List<clsCjClsScoreTtlEN> lstCjClsScoreTtlObjLst)
{
foreach (clsCjClsScoreTtlEN objCjClsScoreTtlEN in lstCjClsScoreTtlObjLst)
{
if (objCjClsScoreTtlEN.mId == lngmId)
{
return objCjClsScoreTtlEN;
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
 long lngmId;
 try
 {
 lngmId = new clsCjClsScoreTtlDA().GetFirstID(strWhereCond);
 return lngmId;
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
 arrList = CjClsScoreTtlDA.GetID(strWhereCond);
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
bool bolIsExist = CjClsScoreTtlDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
bool bolIsExist = CjClsScoreTtlDA.IsExist(lngmId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngmId">mId</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngmId, string strOpUser)
{
clsCjClsScoreTtlEN objCjClsScoreTtlEN = clsCjClsScoreTtlBL.GetObjBymId(lngmId);
objCjClsScoreTtlEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objCjClsScoreTtlEN.UpdUser = strOpUser;
return clsCjClsScoreTtlBL.UpdateBySql2(objCjClsScoreTtlEN);
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
 bolIsExist = clsCjClsScoreTtlDA.IsExistTable();
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
 bolIsExist = CjClsScoreTtlDA.IsExistTable(strTabName);
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
 /// <param name = "objCjClsScoreTtlEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsCjClsScoreTtlEN objCjClsScoreTtlEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objCjClsScoreTtlEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!教学班流水号 = [{0}],考试批次ID = [{1}]的数据已经存在!(in clsCjClsScoreTtlBL.AddNewRecordBySql2)", objCjClsScoreTtlEN.IdEduCls,objCjClsScoreTtlEN.ExamBatchId);
throw new Exception(strMsg);
}
try
{
bool bolResult = CjClsScoreTtlDA.AddNewRecordBySQL2(objCjClsScoreTtlEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCjClsScoreTtlBL.ReFreshCache();

if (clsCjClsScoreTtlBL.relatedActions != null)
{
clsCjClsScoreTtlBL.relatedActions.UpdRelaTabDate(objCjClsScoreTtlEN.mId, objCjClsScoreTtlEN.UpdUser);
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
 /// <param name = "objCjClsScoreTtlEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsCjClsScoreTtlEN objCjClsScoreTtlEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objCjClsScoreTtlEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!教学班流水号 = [{0}],考试批次ID = [{1}]的数据已经存在!(in clsCjClsScoreTtlBL.AddNewRecordBySql2WithReturnKey)", objCjClsScoreTtlEN.IdEduCls,objCjClsScoreTtlEN.ExamBatchId);
throw new Exception(strMsg);
}
try
{
string strKey = CjClsScoreTtlDA.AddNewRecordBySQL2WithReturnKey(objCjClsScoreTtlEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCjClsScoreTtlBL.ReFreshCache();

if (clsCjClsScoreTtlBL.relatedActions != null)
{
clsCjClsScoreTtlBL.relatedActions.UpdRelaTabDate(objCjClsScoreTtlEN.mId, objCjClsScoreTtlEN.UpdUser);
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
 /// <param name = "objCjClsScoreTtlEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsCjClsScoreTtlEN objCjClsScoreTtlEN)
{
try
{
bool bolResult = CjClsScoreTtlDA.Update(objCjClsScoreTtlEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCjClsScoreTtlBL.ReFreshCache();

if (clsCjClsScoreTtlBL.relatedActions != null)
{
clsCjClsScoreTtlBL.relatedActions.UpdRelaTabDate(objCjClsScoreTtlEN.mId, objCjClsScoreTtlEN.UpdUser);
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
 /// <param name = "objCjClsScoreTtlEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsCjClsScoreTtlEN objCjClsScoreTtlEN)
{
 if (objCjClsScoreTtlEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = CjClsScoreTtlDA.UpdateBySql2(objCjClsScoreTtlEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCjClsScoreTtlBL.ReFreshCache();

if (clsCjClsScoreTtlBL.relatedActions != null)
{
clsCjClsScoreTtlBL.relatedActions.UpdRelaTabDate(objCjClsScoreTtlEN.mId, objCjClsScoreTtlEN.UpdUser);
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngmId)
{
try
{
 clsCjClsScoreTtlEN objCjClsScoreTtlEN = clsCjClsScoreTtlBL.GetObjBymId(lngmId);

if (clsCjClsScoreTtlBL.relatedActions != null)
{
clsCjClsScoreTtlBL.relatedActions.UpdRelaTabDate(objCjClsScoreTtlEN.mId, objCjClsScoreTtlEN.UpdUser);
}
if (objCjClsScoreTtlEN != null)
{
int intRecNum = CjClsScoreTtlDA.DelRecord(lngmId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
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
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngmId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCjClsScoreTtlDA.GetSpecSQLObj();
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
//删除与表:[CjClsScoreTtl]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conCjClsScoreTtl.mId,
//lngmId);
//        clsCjClsScoreTtlBL.DelCjClsScoreTtlsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCjClsScoreTtlBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCjClsScoreTtlBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngmId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngmId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsCjClsScoreTtlBL.relatedActions != null)
{
clsCjClsScoreTtlBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = CjClsScoreTtlDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
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
 /// <param name = "arrmIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelCjClsScoreTtls(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsCjClsScoreTtlBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsCjClsScoreTtlBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = CjClsScoreTtlDA.DelCjClsScoreTtl(arrmIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
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
public static int DelCjClsScoreTtlsByCond(string strWhereCond)
{
try
{
if (clsCjClsScoreTtlBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsCjClsScoreTtlBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = CjClsScoreTtlDA.DelCjClsScoreTtl(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[CjClsScoreTtl]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCjClsScoreTtlDA.GetSpecSQLObj();
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
//删除与表:[CjClsScoreTtl]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCjClsScoreTtlBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCjClsScoreTtlBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngmId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objCjClsScoreTtlENS">源对象</param>
 /// <param name = "objCjClsScoreTtlENT">目标对象</param>
 public static void CopyTo(clsCjClsScoreTtlEN objCjClsScoreTtlENS, clsCjClsScoreTtlEN objCjClsScoreTtlENT)
{
try
{
objCjClsScoreTtlENT.mId = objCjClsScoreTtlENS.mId; //mId
objCjClsScoreTtlENT.ExamBatchId = objCjClsScoreTtlENS.ExamBatchId; //考试批次ID
objCjClsScoreTtlENT.IdCourse = objCjClsScoreTtlENS.IdCourse; //课程流水号
objCjClsScoreTtlENT.IdEduCls = objCjClsScoreTtlENS.IdEduCls; //教学班流水号
objCjClsScoreTtlENT.IdAdminCls = objCjClsScoreTtlENS.IdAdminCls; //行政班流水号
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
 /// <param name = "objCjClsScoreTtlEN">源简化对象</param>
 public static void SetUpdFlag(clsCjClsScoreTtlEN objCjClsScoreTtlEN)
{
try
{
objCjClsScoreTtlEN.ClearUpdateState();
   string strsfUpdFldSetStr = objCjClsScoreTtlEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conCjClsScoreTtl.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objCjClsScoreTtlEN.mId = objCjClsScoreTtlEN.mId; //mId
}
if (arrFldSet.Contains(conCjClsScoreTtl.ExamBatchId, new clsStrCompareIgnoreCase())  ==  true)
{
objCjClsScoreTtlEN.ExamBatchId = objCjClsScoreTtlEN.ExamBatchId; //考试批次ID
}
if (arrFldSet.Contains(conCjClsScoreTtl.IdCourse, new clsStrCompareIgnoreCase())  ==  true)
{
objCjClsScoreTtlEN.IdCourse = objCjClsScoreTtlEN.IdCourse; //课程流水号
}
if (arrFldSet.Contains(conCjClsScoreTtl.IdEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objCjClsScoreTtlEN.IdEduCls = objCjClsScoreTtlEN.IdEduCls; //教学班流水号
}
if (arrFldSet.Contains(conCjClsScoreTtl.IdAdminCls, new clsStrCompareIgnoreCase())  ==  true)
{
objCjClsScoreTtlEN.IdAdminCls = objCjClsScoreTtlEN.IdAdminCls == "[null]" ? null :  objCjClsScoreTtlEN.IdAdminCls; //行政班流水号
}
if (arrFldSet.Contains(conCjClsScoreTtl.StuNum, new clsStrCompareIgnoreCase())  ==  true)
{
objCjClsScoreTtlEN.StuNum = objCjClsScoreTtlEN.StuNum; //学生数
}
if (arrFldSet.Contains(conCjClsScoreTtl.AvgScore, new clsStrCompareIgnoreCase())  ==  true)
{
objCjClsScoreTtlEN.AvgScore = objCjClsScoreTtlEN.AvgScore; //平均分
}
if (arrFldSet.Contains(conCjClsScoreTtl.Ranking, new clsStrCompareIgnoreCase())  ==  true)
{
objCjClsScoreTtlEN.Ranking = objCjClsScoreTtlEN.Ranking; //名次
}
if (arrFldSet.Contains(conCjClsScoreTtl.Percentile, new clsStrCompareIgnoreCase())  ==  true)
{
objCjClsScoreTtlEN.Percentile = objCjClsScoreTtlEN.Percentile; //百分位
}
if (arrFldSet.Contains(conCjClsScoreTtl.ExcellentRate, new clsStrCompareIgnoreCase())  ==  true)
{
objCjClsScoreTtlEN.ExcellentRate = objCjClsScoreTtlEN.ExcellentRate; //优秀率
}
if (arrFldSet.Contains(conCjClsScoreTtl.ExcellentGoodRate, new clsStrCompareIgnoreCase())  ==  true)
{
objCjClsScoreTtlEN.ExcellentGoodRate = objCjClsScoreTtlEN.ExcellentGoodRate; //优良率
}
if (arrFldSet.Contains(conCjClsScoreTtl.PassingRate, new clsStrCompareIgnoreCase())  ==  true)
{
objCjClsScoreTtlEN.PassingRate = objCjClsScoreTtlEN.PassingRate; //及格率
}
if (arrFldSet.Contains(conCjClsScoreTtl.ExtremeRate, new clsStrCompareIgnoreCase())  ==  true)
{
objCjClsScoreTtlEN.ExtremeRate = objCjClsScoreTtlEN.ExtremeRate; //极差率
}
if (arrFldSet.Contains(conCjClsScoreTtl.StandardDeviation, new clsStrCompareIgnoreCase())  ==  true)
{
objCjClsScoreTtlEN.StandardDeviation = objCjClsScoreTtlEN.StandardDeviation; //标准差
}
if (arrFldSet.Contains(conCjClsScoreTtl.FullScore, new clsStrCompareIgnoreCase())  ==  true)
{
objCjClsScoreTtlEN.FullScore = objCjClsScoreTtlEN.FullScore; //满分
}
if (arrFldSet.Contains(conCjClsScoreTtl.SchoolYear, new clsStrCompareIgnoreCase())  ==  true)
{
objCjClsScoreTtlEN.SchoolYear = objCjClsScoreTtlEN.SchoolYear == "[null]" ? null :  objCjClsScoreTtlEN.SchoolYear; //学年
}
if (arrFldSet.Contains(conCjClsScoreTtl.SchoolTerm, new clsStrCompareIgnoreCase())  ==  true)
{
objCjClsScoreTtlEN.SchoolTerm = objCjClsScoreTtlEN.SchoolTerm == "[null]" ? null :  objCjClsScoreTtlEN.SchoolTerm; //学期
}
if (arrFldSet.Contains(conCjClsScoreTtl.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCjClsScoreTtlEN.UpdDate = objCjClsScoreTtlEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conCjClsScoreTtl.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objCjClsScoreTtlEN.UpdUser = objCjClsScoreTtlEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conCjClsScoreTtl.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objCjClsScoreTtlEN.Memo = objCjClsScoreTtlEN.Memo == "[null]" ? null :  objCjClsScoreTtlEN.Memo; //备注
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
 /// <param name = "objCjClsScoreTtlEN">源简化对象</param>
 public static void AccessFldValueNull(clsCjClsScoreTtlEN objCjClsScoreTtlEN)
{
try
{
if (objCjClsScoreTtlEN.IdAdminCls == "[null]") objCjClsScoreTtlEN.IdAdminCls = null; //行政班流水号
if (objCjClsScoreTtlEN.SchoolYear == "[null]") objCjClsScoreTtlEN.SchoolYear = null; //学年
if (objCjClsScoreTtlEN.SchoolTerm == "[null]") objCjClsScoreTtlEN.SchoolTerm = null; //学期
if (objCjClsScoreTtlEN.Memo == "[null]") objCjClsScoreTtlEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsCjClsScoreTtlEN objCjClsScoreTtlEN)
{
 CjClsScoreTtlDA.CheckPropertyNew(objCjClsScoreTtlEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsCjClsScoreTtlEN objCjClsScoreTtlEN)
{
 CjClsScoreTtlDA.CheckProperty4Condition(objCjClsScoreTtlEN);
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
if (clsCjClsScoreTtlBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCjClsScoreTtlBL没有刷新缓存机制(clsCjClsScoreTtlBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrCjClsScoreTtlObjLstCache == null)
//{
//arrCjClsScoreTtlObjLstCache = CjClsScoreTtlDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCjClsScoreTtlEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsCjClsScoreTtlEN._CurrTabName);
List<clsCjClsScoreTtlEN> arrCjClsScoreTtlObjLstCache = GetObjLstCache();
IEnumerable <clsCjClsScoreTtlEN> arrCjClsScoreTtlObjLst_Sel =
arrCjClsScoreTtlObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrCjClsScoreTtlObjLst_Sel.Count() == 0)
{
   clsCjClsScoreTtlEN obj = clsCjClsScoreTtlBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrCjClsScoreTtlObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCjClsScoreTtlEN> GetAllCjClsScoreTtlObjLstCache()
{
//获取缓存中的对象列表
List<clsCjClsScoreTtlEN> arrCjClsScoreTtlObjLstCache = GetObjLstCache(); 
return arrCjClsScoreTtlObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCjClsScoreTtlEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsCjClsScoreTtlEN._CurrTabName);
List<clsCjClsScoreTtlEN> arrCjClsScoreTtlObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrCjClsScoreTtlObjLstCache;
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
string strKey = string.Format("{0}", clsCjClsScoreTtlEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCjClsScoreTtlEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsCjClsScoreTtlEN._RefreshTimeLst.Count == 0) return "";
return clsCjClsScoreTtlEN._RefreshTimeLst[clsCjClsScoreTtlEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsCjClsScoreTtlBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCjClsScoreTtlEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCjClsScoreTtlEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsCjClsScoreTtlBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--CjClsScoreTtl(班级成绩汇总)
 /// 唯一性条件:id_EduCls_ExamBatchId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsCjClsScoreTtlEN objCjClsScoreTtlEN)
{
//检测记录是否存在
string strResult = CjClsScoreTtlDA.GetUniCondStr(objCjClsScoreTtlEN);
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
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != conCjClsScoreTtl.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conCjClsScoreTtl.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conCjClsScoreTtl.AttributeName));
throw new Exception(strMsg);
}
var objCjClsScoreTtl = clsCjClsScoreTtlBL.GetObjBymIdCache(lngmId);
if (objCjClsScoreTtl == null) return "";
return objCjClsScoreTtl[strOutFldName].ToString();
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
int intRecCount = clsCjClsScoreTtlDA.GetRecCount(strTabName);
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
int intRecCount = clsCjClsScoreTtlDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsCjClsScoreTtlDA.GetRecCount();
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
int intRecCount = clsCjClsScoreTtlDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objCjClsScoreTtlCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsCjClsScoreTtlEN objCjClsScoreTtlCond)
{
List<clsCjClsScoreTtlEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsCjClsScoreTtlEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCjClsScoreTtl.AttributeName)
{
if (objCjClsScoreTtlCond.IsUpdated(strFldName) == false) continue;
if (objCjClsScoreTtlCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCjClsScoreTtlCond[strFldName].ToString());
}
else
{
if (objCjClsScoreTtlCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCjClsScoreTtlCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCjClsScoreTtlCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCjClsScoreTtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCjClsScoreTtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCjClsScoreTtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCjClsScoreTtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCjClsScoreTtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCjClsScoreTtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCjClsScoreTtlCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCjClsScoreTtlCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCjClsScoreTtlCond[strFldName]));
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
 List<string> arrList = clsCjClsScoreTtlDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = CjClsScoreTtlDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = CjClsScoreTtlDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = CjClsScoreTtlDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsCjClsScoreTtlDA.SetFldValue(clsCjClsScoreTtlEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = CjClsScoreTtlDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsCjClsScoreTtlDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsCjClsScoreTtlDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsCjClsScoreTtlDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[CjClsScoreTtl] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**考试批次ID*/ 
 strCreateTabCode.Append(" ExamBatchId char(12) not Null, "); 
 // /**课程流水号*/ 
 strCreateTabCode.Append(" IdCourse char(8) not Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdEduCls char(8) not Null, "); 
 // /**行政班流水号*/ 
 strCreateTabCode.Append(" IdAdminCls char(8) Null, "); 
 // /**学生数*/ 
 strCreateTabCode.Append(" StuNum int Null, "); 
 // /**平均分*/ 
 strCreateTabCode.Append(" AvgScore decimal(20,2) Null, "); 
 // /**名次*/ 
 strCreateTabCode.Append(" Ranking int Null, "); 
 // /**百分位*/ 
 strCreateTabCode.Append(" Percentile decimal(8,2) Null, "); 
 // /**优秀率*/ 
 strCreateTabCode.Append(" ExcellentRate decimal(8,2) Null, "); 
 // /**优良率*/ 
 strCreateTabCode.Append(" ExcellentGoodRate decimal(8,2) Null, "); 
 // /**及格率*/ 
 strCreateTabCode.Append(" PassingRate decimal(8,2) Null, "); 
 // /**极差率*/ 
 strCreateTabCode.Append(" ExtremeRate decimal(8,2) Null, "); 
 // /**标准差*/ 
 strCreateTabCode.Append(" StandardDeviation decimal(8,2) Null, "); 
 // /**满分*/ 
 strCreateTabCode.Append(" FullScore int Null, "); 
 // /**学年*/ 
 strCreateTabCode.Append(" SchoolYear varchar(10) Null, "); 
 // /**学期*/ 
 strCreateTabCode.Append(" SchoolTerm char(1) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) not Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) not Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 班级成绩汇总(CjClsScoreTtl)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4CjClsScoreTtl : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
 /// </summary>
public override void ReFreshCache()
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
clsCjClsScoreTtlBL.ReFreshThisCache();
}
}

}