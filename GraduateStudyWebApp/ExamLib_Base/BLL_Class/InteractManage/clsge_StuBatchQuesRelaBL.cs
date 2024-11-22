
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_StuBatchQuesRelaBL
 表名:ge_StuBatchQuesRela(01120885)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:00:34
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
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
public static class  clsge_StuBatchQuesRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdStuBatchQuesRela">表关键字</param>
 /// <returns>表对象</returns>
public static clsge_StuBatchQuesRelaEN GetObj(this K_IdStuBatchQuesRela_ge_StuBatchQuesRela myKey)
{
clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN = clsge_StuBatchQuesRelaBL.ge_StuBatchQuesRelaDA.GetObjByIdStuBatchQuesRela(myKey.Value);
return objge_StuBatchQuesRelaEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objge_StuBatchQuesRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!学生批次号 = [{0}],用户ID = [{1}],题目Id = [{2}]的数据已经存在!(in clsge_StuBatchQuesRelaBL.AddNewRecord)", objge_StuBatchQuesRelaEN.ExamBatchNo,objge_StuBatchQuesRelaEN.UserId,objge_StuBatchQuesRelaEN.QuestionId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsge_StuBatchQuesRelaBL.ge_StuBatchQuesRelaDA.AddNewRecordBySQL2(objge_StuBatchQuesRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StuBatchQuesRelaBL.ReFreshCache(objge_StuBatchQuesRelaEN.IdCurrEduCls);

if (clsge_StuBatchQuesRelaBL.relatedActions != null)
{
clsge_StuBatchQuesRelaBL.relatedActions.UpdRelaTabDate(objge_StuBatchQuesRelaEN.IdStuBatchQuesRela, objge_StuBatchQuesRelaEN.UpdUserId);
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
public static bool AddRecordEx(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, bool bolIsNeedCheckUniqueness = true)
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
objge_StuBatchQuesRelaEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objge_StuBatchQuesRelaEN.CheckUniqueness() == false)
{
strMsg = string.Format("(学生批次号(ExamBatchNo)=[{0}],用户ID(UserId)=[{1}],题目Id(QuestionId)=[{2}])已经存在,不能重复!", objge_StuBatchQuesRelaEN.ExamBatchNo, objge_StuBatchQuesRelaEN.UserId, objge_StuBatchQuesRelaEN.QuestionId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objge_StuBatchQuesRelaEN.AddNewRecord();
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
 /// <param name = "objge_StuBatchQuesRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objge_StuBatchQuesRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!学生批次号 = [{0}],用户ID = [{1}],题目Id = [{2}]的数据已经存在!(in clsge_StuBatchQuesRelaBL.AddNewRecordWithReturnKey)", objge_StuBatchQuesRelaEN.ExamBatchNo,objge_StuBatchQuesRelaEN.UserId,objge_StuBatchQuesRelaEN.QuestionId);
throw new Exception(strMsg);
}
try
{
string strKey = clsge_StuBatchQuesRelaBL.ge_StuBatchQuesRelaDA.AddNewRecordBySQL2WithReturnKey(objge_StuBatchQuesRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StuBatchQuesRelaBL.ReFreshCache(objge_StuBatchQuesRelaEN.IdCurrEduCls);

if (clsge_StuBatchQuesRelaBL.relatedActions != null)
{
clsge_StuBatchQuesRelaBL.relatedActions.UpdRelaTabDate(objge_StuBatchQuesRelaEN.IdStuBatchQuesRela, objge_StuBatchQuesRelaEN.UpdUserId);
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
 /// <param name = "objge_StuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuBatchQuesRelaEN SetIdStuBatchQuesRela(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, long lngIdStuBatchQuesRela, string strComparisonOp="")
	{
objge_StuBatchQuesRelaEN.IdStuBatchQuesRela = lngIdStuBatchQuesRela; //学生批次题目关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(conge_StuBatchQuesRela.IdStuBatchQuesRela) == false)
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp.Add(conge_StuBatchQuesRela.IdStuBatchQuesRela, strComparisonOp);
}
else
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp[conge_StuBatchQuesRela.IdStuBatchQuesRela] = strComparisonOp;
}
}
return objge_StuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuBatchQuesRelaEN SetExamBatchNo(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, string strExamBatchNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strExamBatchNo, conge_StuBatchQuesRela.ExamBatchNo);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExamBatchNo, 20, conge_StuBatchQuesRela.ExamBatchNo);
}
objge_StuBatchQuesRelaEN.ExamBatchNo = strExamBatchNo; //学生批次号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(conge_StuBatchQuesRela.ExamBatchNo) == false)
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp.Add(conge_StuBatchQuesRela.ExamBatchNo, strComparisonOp);
}
else
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp[conge_StuBatchQuesRela.ExamBatchNo] = strComparisonOp;
}
}
return objge_StuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuBatchQuesRelaEN SetLevelNo(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, int? intLevelNo, string strComparisonOp="")
	{
objge_StuBatchQuesRelaEN.LevelNo = intLevelNo; //学习关号2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(conge_StuBatchQuesRela.LevelNo) == false)
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp.Add(conge_StuBatchQuesRela.LevelNo, strComparisonOp);
}
else
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp[conge_StuBatchQuesRela.LevelNo] = strComparisonOp;
}
}
return objge_StuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuBatchQuesRelaEN SetQuestionId(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, long lngQuestionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngQuestionId, conge_StuBatchQuesRela.QuestionId);
objge_StuBatchQuesRelaEN.QuestionId = lngQuestionId; //题目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(conge_StuBatchQuesRela.QuestionId) == false)
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp.Add(conge_StuBatchQuesRela.QuestionId, strComparisonOp);
}
else
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp[conge_StuBatchQuesRela.QuestionId] = strComparisonOp;
}
}
return objge_StuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuBatchQuesRelaEN SetUserId(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, conge_StuBatchQuesRela.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conge_StuBatchQuesRela.UserId);
}
objge_StuBatchQuesRelaEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(conge_StuBatchQuesRela.UserId) == false)
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp.Add(conge_StuBatchQuesRela.UserId, strComparisonOp);
}
else
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp[conge_StuBatchQuesRela.UserId] = strComparisonOp;
}
}
return objge_StuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuBatchQuesRelaEN SetIdCurrEduCls(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, string strIdCurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdCurrEduCls, conge_StuBatchQuesRela.IdCurrEduCls);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conge_StuBatchQuesRela.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conge_StuBatchQuesRela.IdCurrEduCls);
}
objge_StuBatchQuesRelaEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(conge_StuBatchQuesRela.IdCurrEduCls) == false)
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp.Add(conge_StuBatchQuesRela.IdCurrEduCls, strComparisonOp);
}
else
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp[conge_StuBatchQuesRela.IdCurrEduCls] = strComparisonOp;
}
}
return objge_StuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuBatchQuesRelaEN SetQuestionIndex4Batch(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, int? intQuestionIndex4Batch, string strComparisonOp="")
	{
objge_StuBatchQuesRelaEN.QuestionIndex4Batch = intQuestionIndex4Batch; //题序号4批次
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(conge_StuBatchQuesRela.QuestionIndex4Batch) == false)
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp.Add(conge_StuBatchQuesRela.QuestionIndex4Batch, strComparisonOp);
}
else
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp[conge_StuBatchQuesRela.QuestionIndex4Batch] = strComparisonOp;
}
}
return objge_StuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuBatchQuesRelaEN SetGameLevelId(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, string strGameLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGameLevelId, 8, conge_StuBatchQuesRela.GameLevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGameLevelId, 8, conge_StuBatchQuesRela.GameLevelId);
}
objge_StuBatchQuesRelaEN.GameLevelId = strGameLevelId; //游戏关卡Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(conge_StuBatchQuesRela.GameLevelId) == false)
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp.Add(conge_StuBatchQuesRela.GameLevelId, strComparisonOp);
}
else
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp[conge_StuBatchQuesRela.GameLevelId] = strComparisonOp;
}
}
return objge_StuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuBatchQuesRelaEN SetScores(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, double? dblScores, string strComparisonOp="")
	{
objge_StuBatchQuesRelaEN.Scores = dblScores; //分值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(conge_StuBatchQuesRela.Scores) == false)
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp.Add(conge_StuBatchQuesRela.Scores, strComparisonOp);
}
else
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp[conge_StuBatchQuesRela.Scores] = strComparisonOp;
}
}
return objge_StuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuBatchQuesRelaEN SetScore(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, double? dblScore, string strComparisonOp="")
	{
objge_StuBatchQuesRelaEN.Score = dblScore; //得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(conge_StuBatchQuesRela.Score) == false)
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp.Add(conge_StuBatchQuesRela.Score, strComparisonOp);
}
else
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp[conge_StuBatchQuesRela.Score] = strComparisonOp;
}
}
return objge_StuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuBatchQuesRelaEN SetStuAnswerText(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, string strStuAnswerText, string strComparisonOp="")
	{
objge_StuBatchQuesRelaEN.StuAnswerText = strStuAnswerText; //学生回答文本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(conge_StuBatchQuesRela.StuAnswerText) == false)
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp.Add(conge_StuBatchQuesRela.StuAnswerText, strComparisonOp);
}
else
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp[conge_StuBatchQuesRela.StuAnswerText] = strComparisonOp;
}
}
return objge_StuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuBatchQuesRelaEN SetAnswerDate(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, string strAnswerDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerDate, 8, conge_StuBatchQuesRela.AnswerDate);
}
objge_StuBatchQuesRelaEN.AnswerDate = strAnswerDate; //回答日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(conge_StuBatchQuesRela.AnswerDate) == false)
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp.Add(conge_StuBatchQuesRela.AnswerDate, strComparisonOp);
}
else
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp[conge_StuBatchQuesRela.AnswerDate] = strComparisonOp;
}
}
return objge_StuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuBatchQuesRelaEN SetAnswerIP(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, string strAnswerIP, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerIP, 30, conge_StuBatchQuesRela.AnswerIP);
}
objge_StuBatchQuesRelaEN.AnswerIP = strAnswerIP; //回答IP
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(conge_StuBatchQuesRela.AnswerIP) == false)
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp.Add(conge_StuBatchQuesRela.AnswerIP, strComparisonOp);
}
else
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp[conge_StuBatchQuesRela.AnswerIP] = strComparisonOp;
}
}
return objge_StuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuBatchQuesRelaEN SetAnswerModeId(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, string strAnswerModeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerModeId, 4, conge_StuBatchQuesRela.AnswerModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerModeId, 4, conge_StuBatchQuesRela.AnswerModeId);
}
objge_StuBatchQuesRelaEN.AnswerModeId = strAnswerModeId; //答案模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(conge_StuBatchQuesRela.AnswerModeId) == false)
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp.Add(conge_StuBatchQuesRela.AnswerModeId, strComparisonOp);
}
else
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp[conge_StuBatchQuesRela.AnswerModeId] = strComparisonOp;
}
}
return objge_StuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuBatchQuesRelaEN SetAnswerMultiOptions(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, string strAnswerMultiOptions, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerMultiOptions, 300, conge_StuBatchQuesRela.AnswerMultiOptions);
}
objge_StuBatchQuesRelaEN.AnswerMultiOptions = strAnswerMultiOptions; //多选项答案
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(conge_StuBatchQuesRela.AnswerMultiOptions) == false)
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp.Add(conge_StuBatchQuesRela.AnswerMultiOptions, strComparisonOp);
}
else
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp[conge_StuBatchQuesRela.AnswerMultiOptions] = strComparisonOp;
}
}
return objge_StuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuBatchQuesRelaEN SetAnswerOptionId(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, string strAnswerOptionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerOptionId, 8, conge_StuBatchQuesRela.AnswerOptionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerOptionId, 8, conge_StuBatchQuesRela.AnswerOptionId);
}
objge_StuBatchQuesRelaEN.AnswerOptionId = strAnswerOptionId; //回答选项Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(conge_StuBatchQuesRela.AnswerOptionId) == false)
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp.Add(conge_StuBatchQuesRela.AnswerOptionId, strComparisonOp);
}
else
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp[conge_StuBatchQuesRela.AnswerOptionId] = strComparisonOp;
}
}
return objge_StuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuBatchQuesRelaEN SetAnswerTime(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, string strAnswerTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerTime, 10, conge_StuBatchQuesRela.AnswerTime);
}
objge_StuBatchQuesRelaEN.AnswerTime = strAnswerTime; //回答时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(conge_StuBatchQuesRela.AnswerTime) == false)
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp.Add(conge_StuBatchQuesRela.AnswerTime, strComparisonOp);
}
else
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp[conge_StuBatchQuesRela.AnswerTime] = strComparisonOp;
}
}
return objge_StuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuBatchQuesRelaEN SetApplySendBackDate(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, string strApplySendBackDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strApplySendBackDate, 14, conge_StuBatchQuesRela.ApplySendBackDate);
}
objge_StuBatchQuesRelaEN.ApplySendBackDate = strApplySendBackDate; //申请退回日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(conge_StuBatchQuesRela.ApplySendBackDate) == false)
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp.Add(conge_StuBatchQuesRela.ApplySendBackDate, strComparisonOp);
}
else
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp[conge_StuBatchQuesRela.ApplySendBackDate] = strComparisonOp;
}
}
return objge_StuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuBatchQuesRelaEN SetComment(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, string strComment, string strComparisonOp="")
	{
objge_StuBatchQuesRelaEN.Comment = strComment; //批注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(conge_StuBatchQuesRela.Comment) == false)
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp.Add(conge_StuBatchQuesRela.Comment, strComparisonOp);
}
else
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp[conge_StuBatchQuesRela.Comment] = strComparisonOp;
}
}
return objge_StuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuBatchQuesRelaEN SetIsAccessKnowledge(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, bool bolIsAccessKnowledge, string strComparisonOp="")
	{
objge_StuBatchQuesRelaEN.IsAccessKnowledge = bolIsAccessKnowledge; //是否处理知识点
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(conge_StuBatchQuesRela.IsAccessKnowledge) == false)
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp.Add(conge_StuBatchQuesRela.IsAccessKnowledge, strComparisonOp);
}
else
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp[conge_StuBatchQuesRela.IsAccessKnowledge] = strComparisonOp;
}
}
return objge_StuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuBatchQuesRelaEN SetIsApplySendBack(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, bool bolIsApplySendBack, string strComparisonOp="")
	{
objge_StuBatchQuesRelaEN.IsApplySendBack = bolIsApplySendBack; //是否申请退回
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(conge_StuBatchQuesRela.IsApplySendBack) == false)
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp.Add(conge_StuBatchQuesRela.IsApplySendBack, strComparisonOp);
}
else
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp[conge_StuBatchQuesRela.IsApplySendBack] = strComparisonOp;
}
}
return objge_StuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuBatchQuesRelaEN SetIsInErrorQuestion(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, bool bolIsInErrorQuestion, string strComparisonOp="")
	{
objge_StuBatchQuesRelaEN.IsInErrorQuestion = bolIsInErrorQuestion; //是否进入错题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(conge_StuBatchQuesRela.IsInErrorQuestion) == false)
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp.Add(conge_StuBatchQuesRela.IsInErrorQuestion, strComparisonOp);
}
else
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp[conge_StuBatchQuesRela.IsInErrorQuestion] = strComparisonOp;
}
}
return objge_StuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuBatchQuesRelaEN SetIsLook(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, bool bolIsLook, string strComparisonOp="")
	{
objge_StuBatchQuesRelaEN.IsLook = bolIsLook; //是否查看
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(conge_StuBatchQuesRela.IsLook) == false)
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp.Add(conge_StuBatchQuesRela.IsLook, strComparisonOp);
}
else
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp[conge_StuBatchQuesRela.IsLook] = strComparisonOp;
}
}
return objge_StuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuBatchQuesRelaEN SetIsMarking(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, bool bolIsMarking, string strComparisonOp="")
	{
objge_StuBatchQuesRelaEN.IsMarking = bolIsMarking; //是否批阅
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(conge_StuBatchQuesRela.IsMarking) == false)
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp.Add(conge_StuBatchQuesRela.IsMarking, strComparisonOp);
}
else
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp[conge_StuBatchQuesRela.IsMarking] = strComparisonOp;
}
}
return objge_StuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuBatchQuesRelaEN SetIsNotProcessTimeout(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, bool bolIsNotProcessTimeout, string strComparisonOp="")
	{
objge_StuBatchQuesRelaEN.IsNotProcessTimeout = bolIsNotProcessTimeout; //是否不处理超时
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(conge_StuBatchQuesRela.IsNotProcessTimeout) == false)
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp.Add(conge_StuBatchQuesRela.IsNotProcessTimeout, strComparisonOp);
}
else
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp[conge_StuBatchQuesRela.IsNotProcessTimeout] = strComparisonOp;
}
}
return objge_StuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuBatchQuesRelaEN SetIsHasAnswer(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, bool bolIsHasAnswer, string strComparisonOp="")
	{
objge_StuBatchQuesRelaEN.IsHasAnswer = bolIsHasAnswer; //是否有答案
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(conge_StuBatchQuesRela.IsHasAnswer) == false)
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp.Add(conge_StuBatchQuesRela.IsHasAnswer, strComparisonOp);
}
else
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp[conge_StuBatchQuesRela.IsHasAnswer] = strComparisonOp;
}
}
return objge_StuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuBatchQuesRelaEN SetIsPublish(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, bool bolIsPublish, string strComparisonOp="")
	{
objge_StuBatchQuesRelaEN.IsPublish = bolIsPublish; //是否发布
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(conge_StuBatchQuesRela.IsPublish) == false)
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp.Add(conge_StuBatchQuesRela.IsPublish, strComparisonOp);
}
else
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp[conge_StuBatchQuesRela.IsPublish] = strComparisonOp;
}
}
return objge_StuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuBatchQuesRelaEN SetIsRight(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, bool bolIsRight, string strComparisonOp="")
	{
objge_StuBatchQuesRelaEN.IsRight = bolIsRight; //是否正确
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(conge_StuBatchQuesRela.IsRight) == false)
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp.Add(conge_StuBatchQuesRela.IsRight, strComparisonOp);
}
else
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp[conge_StuBatchQuesRela.IsRight] = strComparisonOp;
}
}
return objge_StuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuBatchQuesRelaEN SetIsSave(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, bool bolIsSave, string strComparisonOp="")
	{
objge_StuBatchQuesRelaEN.IsSave = bolIsSave; //是否保存
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(conge_StuBatchQuesRela.IsSave) == false)
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp.Add(conge_StuBatchQuesRela.IsSave, strComparisonOp);
}
else
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp[conge_StuBatchQuesRela.IsSave] = strComparisonOp;
}
}
return objge_StuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuBatchQuesRelaEN SetIsSendBack(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, bool bolIsSendBack, string strComparisonOp="")
	{
objge_StuBatchQuesRelaEN.IsSendBack = bolIsSendBack; //是否退回
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(conge_StuBatchQuesRela.IsSendBack) == false)
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp.Add(conge_StuBatchQuesRela.IsSendBack, strComparisonOp);
}
else
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp[conge_StuBatchQuesRela.IsSendBack] = strComparisonOp;
}
}
return objge_StuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuBatchQuesRelaEN SetIsSubmit(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, bool bolIsSubmit, string strComparisonOp="")
	{
objge_StuBatchQuesRelaEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(conge_StuBatchQuesRela.IsSubmit) == false)
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp.Add(conge_StuBatchQuesRela.IsSubmit, strComparisonOp);
}
else
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp[conge_StuBatchQuesRela.IsSubmit] = strComparisonOp;
}
}
return objge_StuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuBatchQuesRelaEN SetMarkDate(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, string strMarkDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMarkDate, 14, conge_StuBatchQuesRela.MarkDate);
}
objge_StuBatchQuesRelaEN.MarkDate = strMarkDate; //打分日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(conge_StuBatchQuesRela.MarkDate) == false)
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp.Add(conge_StuBatchQuesRela.MarkDate, strComparisonOp);
}
else
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp[conge_StuBatchQuesRela.MarkDate] = strComparisonOp;
}
}
return objge_StuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuBatchQuesRelaEN SetMarkerId(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, string strMarkerId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMarkerId, 20, conge_StuBatchQuesRela.MarkerId);
}
objge_StuBatchQuesRelaEN.MarkerId = strMarkerId; //打分者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(conge_StuBatchQuesRela.MarkerId) == false)
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp.Add(conge_StuBatchQuesRela.MarkerId, strComparisonOp);
}
else
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp[conge_StuBatchQuesRela.MarkerId] = strComparisonOp;
}
}
return objge_StuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuBatchQuesRelaEN SetOperateTime(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, string strOperateTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOperateTime, 14, conge_StuBatchQuesRela.OperateTime);
}
objge_StuBatchQuesRelaEN.OperateTime = strOperateTime; //操作时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(conge_StuBatchQuesRela.OperateTime) == false)
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp.Add(conge_StuBatchQuesRela.OperateTime, strComparisonOp);
}
else
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp[conge_StuBatchQuesRela.OperateTime] = strComparisonOp;
}
}
return objge_StuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuBatchQuesRelaEN SetRealFinishDate(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, string strRealFinishDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRealFinishDate, 14, conge_StuBatchQuesRela.RealFinishDate);
}
objge_StuBatchQuesRelaEN.RealFinishDate = strRealFinishDate; //实际完成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(conge_StuBatchQuesRela.RealFinishDate) == false)
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp.Add(conge_StuBatchQuesRela.RealFinishDate, strComparisonOp);
}
else
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp[conge_StuBatchQuesRela.RealFinishDate] = strComparisonOp;
}
}
return objge_StuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuBatchQuesRelaEN SetWorkTypeId(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, string strWorkTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWorkTypeId, 2, conge_StuBatchQuesRela.WorkTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strWorkTypeId, 2, conge_StuBatchQuesRela.WorkTypeId);
}
objge_StuBatchQuesRelaEN.WorkTypeId = strWorkTypeId; //作业类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(conge_StuBatchQuesRela.WorkTypeId) == false)
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp.Add(conge_StuBatchQuesRela.WorkTypeId, strComparisonOp);
}
else
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp[conge_StuBatchQuesRela.WorkTypeId] = strComparisonOp;
}
}
return objge_StuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuBatchQuesRelaEN SetSchoolYear(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, string strSchoolYear, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, conge_StuBatchQuesRela.SchoolYear);
}
objge_StuBatchQuesRelaEN.SchoolYear = strSchoolYear; //学年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(conge_StuBatchQuesRela.SchoolYear) == false)
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp.Add(conge_StuBatchQuesRela.SchoolYear, strComparisonOp);
}
else
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp[conge_StuBatchQuesRela.SchoolYear] = strComparisonOp;
}
}
return objge_StuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuBatchQuesRelaEN SetSchoolTerm(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, string strSchoolTerm, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, conge_StuBatchQuesRela.SchoolTerm);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, conge_StuBatchQuesRela.SchoolTerm);
}
objge_StuBatchQuesRelaEN.SchoolTerm = strSchoolTerm; //学期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(conge_StuBatchQuesRela.SchoolTerm) == false)
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp.Add(conge_StuBatchQuesRela.SchoolTerm, strComparisonOp);
}
else
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp[conge_StuBatchQuesRela.SchoolTerm] = strComparisonOp;
}
}
return objge_StuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuBatchQuesRelaEN SetErrMsg(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, string strErrMsg, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strErrMsg, 200, conge_StuBatchQuesRela.ErrMsg);
}
objge_StuBatchQuesRelaEN.ErrMsg = strErrMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(conge_StuBatchQuesRela.ErrMsg) == false)
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp.Add(conge_StuBatchQuesRela.ErrMsg, strComparisonOp);
}
else
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp[conge_StuBatchQuesRela.ErrMsg] = strComparisonOp;
}
}
return objge_StuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuBatchQuesRelaEN SetIsRecommend(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, bool bolIsRecommend, string strComparisonOp="")
	{
objge_StuBatchQuesRelaEN.IsRecommend = bolIsRecommend; //是否推荐
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(conge_StuBatchQuesRela.IsRecommend) == false)
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp.Add(conge_StuBatchQuesRela.IsRecommend, strComparisonOp);
}
else
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp[conge_StuBatchQuesRela.IsRecommend] = strComparisonOp;
}
}
return objge_StuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuBatchQuesRelaEN SetCourseId(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, conge_StuBatchQuesRela.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, conge_StuBatchQuesRela.CourseId);
}
objge_StuBatchQuesRelaEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(conge_StuBatchQuesRela.CourseId) == false)
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp.Add(conge_StuBatchQuesRela.CourseId, strComparisonOp);
}
else
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp[conge_StuBatchQuesRela.CourseId] = strComparisonOp;
}
}
return objge_StuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuBatchQuesRelaEN SetUpdDate(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conge_StuBatchQuesRela.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conge_StuBatchQuesRela.UpdDate);
}
objge_StuBatchQuesRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(conge_StuBatchQuesRela.UpdDate) == false)
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp.Add(conge_StuBatchQuesRela.UpdDate, strComparisonOp);
}
else
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp[conge_StuBatchQuesRela.UpdDate] = strComparisonOp;
}
}
return objge_StuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuBatchQuesRelaEN SetUpdUserId(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conge_StuBatchQuesRela.UpdUserId);
}
objge_StuBatchQuesRelaEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(conge_StuBatchQuesRela.UpdUserId) == false)
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp.Add(conge_StuBatchQuesRela.UpdUserId, strComparisonOp);
}
else
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp[conge_StuBatchQuesRela.UpdUserId] = strComparisonOp;
}
}
return objge_StuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuBatchQuesRelaEN SetMemo(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conge_StuBatchQuesRela.Memo);
}
objge_StuBatchQuesRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(conge_StuBatchQuesRela.Memo) == false)
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp.Add(conge_StuBatchQuesRela.Memo, strComparisonOp);
}
else
{
objge_StuBatchQuesRelaEN.dicFldComparisonOp[conge_StuBatchQuesRela.Memo] = strComparisonOp;
}
}
return objge_StuBatchQuesRelaEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objge_StuBatchQuesRelaEN.CheckPropertyNew();
clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaCond = new clsge_StuBatchQuesRelaEN();
string strCondition = objge_StuBatchQuesRelaCond
.SetIdStuBatchQuesRela(objge_StuBatchQuesRelaEN.IdStuBatchQuesRela, "<>")
.SetExamBatchNo(objge_StuBatchQuesRelaEN.ExamBatchNo, "=")
.SetUserId(objge_StuBatchQuesRelaEN.UserId, "=")
.SetQuestionId(objge_StuBatchQuesRelaEN.QuestionId, "=")
.GetCombineCondition();
objge_StuBatchQuesRelaEN._IsCheckProperty = true;
bool bolIsExist = clsge_StuBatchQuesRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(ExamBatchNo_UserId_QuestionID)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objge_StuBatchQuesRelaEN.Update();
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
 /// <param name = "objge_StuBatchQuesRela">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRela)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaCond = new clsge_StuBatchQuesRelaEN();
string strCondition = objge_StuBatchQuesRelaCond
.SetExamBatchNo(objge_StuBatchQuesRela.ExamBatchNo, "=")
.SetUserId(objge_StuBatchQuesRela.UserId, "=")
.SetQuestionId(objge_StuBatchQuesRela.QuestionId, "=")
.GetCombineCondition();
objge_StuBatchQuesRela._IsCheckProperty = true;
bool bolIsExist = clsge_StuBatchQuesRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objge_StuBatchQuesRela.IdStuBatchQuesRela = clsge_StuBatchQuesRelaBL.GetFirstID_S(strCondition);
objge_StuBatchQuesRela.UpdateWithCondition(strCondition);
}
else
{
objge_StuBatchQuesRela.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN)
{
 if (objge_StuBatchQuesRelaEN.IdStuBatchQuesRela == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsge_StuBatchQuesRelaBL.ge_StuBatchQuesRelaDA.UpdateBySql2(objge_StuBatchQuesRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StuBatchQuesRelaBL.ReFreshCache(objge_StuBatchQuesRelaEN.IdCurrEduCls);

if (clsge_StuBatchQuesRelaBL.relatedActions != null)
{
clsge_StuBatchQuesRelaBL.relatedActions.UpdRelaTabDate(objge_StuBatchQuesRelaEN.IdStuBatchQuesRela, objge_StuBatchQuesRelaEN.UpdUserId);
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
 /// <param name = "objge_StuBatchQuesRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objge_StuBatchQuesRelaEN.IdStuBatchQuesRela == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsge_StuBatchQuesRelaBL.ge_StuBatchQuesRelaDA.UpdateBySql2(objge_StuBatchQuesRelaEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StuBatchQuesRelaBL.ReFreshCache(objge_StuBatchQuesRelaEN.IdCurrEduCls);

if (clsge_StuBatchQuesRelaBL.relatedActions != null)
{
clsge_StuBatchQuesRelaBL.relatedActions.UpdRelaTabDate(objge_StuBatchQuesRelaEN.IdStuBatchQuesRela, objge_StuBatchQuesRelaEN.UpdUserId);
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
 /// <param name = "objge_StuBatchQuesRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, string strWhereCond)
{
try
{
bool bolResult = clsge_StuBatchQuesRelaBL.ge_StuBatchQuesRelaDA.UpdateBySqlWithCondition(objge_StuBatchQuesRelaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StuBatchQuesRelaBL.ReFreshCache(objge_StuBatchQuesRelaEN.IdCurrEduCls);

if (clsge_StuBatchQuesRelaBL.relatedActions != null)
{
clsge_StuBatchQuesRelaBL.relatedActions.UpdRelaTabDate(objge_StuBatchQuesRelaEN.IdStuBatchQuesRela, objge_StuBatchQuesRelaEN.UpdUserId);
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
 /// <param name = "objge_StuBatchQuesRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsge_StuBatchQuesRelaBL.ge_StuBatchQuesRelaDA.UpdateBySqlWithConditionTransaction(objge_StuBatchQuesRelaEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StuBatchQuesRelaBL.ReFreshCache(objge_StuBatchQuesRelaEN.IdCurrEduCls);

if (clsge_StuBatchQuesRelaBL.relatedActions != null)
{
clsge_StuBatchQuesRelaBL.relatedActions.UpdRelaTabDate(objge_StuBatchQuesRelaEN.IdStuBatchQuesRela, objge_StuBatchQuesRelaEN.UpdUserId);
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
 /// <param name = "lngIdStuBatchQuesRela">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN)
{
try
{
int intRecNum = clsge_StuBatchQuesRelaBL.ge_StuBatchQuesRelaDA.DelRecord(objge_StuBatchQuesRelaEN.IdStuBatchQuesRela);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StuBatchQuesRelaBL.ReFreshCache(objge_StuBatchQuesRelaEN.IdCurrEduCls);

if (clsge_StuBatchQuesRelaBL.relatedActions != null)
{
clsge_StuBatchQuesRelaBL.relatedActions.UpdRelaTabDate(objge_StuBatchQuesRelaEN.IdStuBatchQuesRela, objge_StuBatchQuesRelaEN.UpdUserId);
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
 /// <param name = "objge_StuBatchQuesRelaENS">源对象</param>
 /// <param name = "objge_StuBatchQuesRelaENT">目标对象</param>
 public static void CopyTo(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaENS, clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaENT)
{
try
{
objge_StuBatchQuesRelaENT.IdStuBatchQuesRela = objge_StuBatchQuesRelaENS.IdStuBatchQuesRela; //学生批次题目关系流水号
objge_StuBatchQuesRelaENT.ExamBatchNo = objge_StuBatchQuesRelaENS.ExamBatchNo; //学生批次号
objge_StuBatchQuesRelaENT.LevelNo = objge_StuBatchQuesRelaENS.LevelNo; //学习关号2
objge_StuBatchQuesRelaENT.QuestionId = objge_StuBatchQuesRelaENS.QuestionId; //题目Id
objge_StuBatchQuesRelaENT.UserId = objge_StuBatchQuesRelaENS.UserId; //用户ID
objge_StuBatchQuesRelaENT.IdCurrEduCls = objge_StuBatchQuesRelaENS.IdCurrEduCls; //教学班流水号
objge_StuBatchQuesRelaENT.QuestionIndex4Batch = objge_StuBatchQuesRelaENS.QuestionIndex4Batch; //题序号4批次
objge_StuBatchQuesRelaENT.GameLevelId = objge_StuBatchQuesRelaENS.GameLevelId; //游戏关卡Id
objge_StuBatchQuesRelaENT.Scores = objge_StuBatchQuesRelaENS.Scores; //分值
objge_StuBatchQuesRelaENT.Score = objge_StuBatchQuesRelaENS.Score; //得分
objge_StuBatchQuesRelaENT.StuAnswerText = objge_StuBatchQuesRelaENS.StuAnswerText; //学生回答文本
objge_StuBatchQuesRelaENT.AnswerDate = objge_StuBatchQuesRelaENS.AnswerDate; //回答日期
objge_StuBatchQuesRelaENT.AnswerIP = objge_StuBatchQuesRelaENS.AnswerIP; //回答IP
objge_StuBatchQuesRelaENT.AnswerModeId = objge_StuBatchQuesRelaENS.AnswerModeId; //答案模式Id
objge_StuBatchQuesRelaENT.AnswerMultiOptions = objge_StuBatchQuesRelaENS.AnswerMultiOptions; //多选项答案
objge_StuBatchQuesRelaENT.AnswerOptionId = objge_StuBatchQuesRelaENS.AnswerOptionId; //回答选项Id
objge_StuBatchQuesRelaENT.AnswerTime = objge_StuBatchQuesRelaENS.AnswerTime; //回答时间
objge_StuBatchQuesRelaENT.ApplySendBackDate = objge_StuBatchQuesRelaENS.ApplySendBackDate; //申请退回日期
objge_StuBatchQuesRelaENT.Comment = objge_StuBatchQuesRelaENS.Comment; //批注
objge_StuBatchQuesRelaENT.IsAccessKnowledge = objge_StuBatchQuesRelaENS.IsAccessKnowledge; //是否处理知识点
objge_StuBatchQuesRelaENT.IsApplySendBack = objge_StuBatchQuesRelaENS.IsApplySendBack; //是否申请退回
objge_StuBatchQuesRelaENT.IsInErrorQuestion = objge_StuBatchQuesRelaENS.IsInErrorQuestion; //是否进入错题
objge_StuBatchQuesRelaENT.IsLook = objge_StuBatchQuesRelaENS.IsLook; //是否查看
objge_StuBatchQuesRelaENT.IsMarking = objge_StuBatchQuesRelaENS.IsMarking; //是否批阅
objge_StuBatchQuesRelaENT.IsNotProcessTimeout = objge_StuBatchQuesRelaENS.IsNotProcessTimeout; //是否不处理超时
objge_StuBatchQuesRelaENT.IsHasAnswer = objge_StuBatchQuesRelaENS.IsHasAnswer; //是否有答案
objge_StuBatchQuesRelaENT.IsPublish = objge_StuBatchQuesRelaENS.IsPublish; //是否发布
objge_StuBatchQuesRelaENT.IsRight = objge_StuBatchQuesRelaENS.IsRight; //是否正确
objge_StuBatchQuesRelaENT.IsSave = objge_StuBatchQuesRelaENS.IsSave; //是否保存
objge_StuBatchQuesRelaENT.IsSendBack = objge_StuBatchQuesRelaENS.IsSendBack; //是否退回
objge_StuBatchQuesRelaENT.IsSubmit = objge_StuBatchQuesRelaENS.IsSubmit; //是否提交
objge_StuBatchQuesRelaENT.MarkDate = objge_StuBatchQuesRelaENS.MarkDate; //打分日期
objge_StuBatchQuesRelaENT.MarkerId = objge_StuBatchQuesRelaENS.MarkerId; //打分者
objge_StuBatchQuesRelaENT.OperateTime = objge_StuBatchQuesRelaENS.OperateTime; //操作时间
objge_StuBatchQuesRelaENT.RealFinishDate = objge_StuBatchQuesRelaENS.RealFinishDate; //实际完成日期
objge_StuBatchQuesRelaENT.WorkTypeId = objge_StuBatchQuesRelaENS.WorkTypeId; //作业类型Id
objge_StuBatchQuesRelaENT.SchoolYear = objge_StuBatchQuesRelaENS.SchoolYear; //学年
objge_StuBatchQuesRelaENT.SchoolTerm = objge_StuBatchQuesRelaENS.SchoolTerm; //学期
objge_StuBatchQuesRelaENT.ErrMsg = objge_StuBatchQuesRelaENS.ErrMsg; //错误信息
objge_StuBatchQuesRelaENT.IsRecommend = objge_StuBatchQuesRelaENS.IsRecommend; //是否推荐
objge_StuBatchQuesRelaENT.CourseId = objge_StuBatchQuesRelaENS.CourseId; //课程Id
objge_StuBatchQuesRelaENT.UpdDate = objge_StuBatchQuesRelaENS.UpdDate; //修改日期
objge_StuBatchQuesRelaENT.UpdUserId = objge_StuBatchQuesRelaENS.UpdUserId; //修改用户Id
objge_StuBatchQuesRelaENT.Memo = objge_StuBatchQuesRelaENS.Memo; //备注
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
 /// <param name = "objge_StuBatchQuesRelaENS">源对象</param>
 /// <returns>目标对象=>clsge_StuBatchQuesRelaEN:objge_StuBatchQuesRelaENT</returns>
 public static clsge_StuBatchQuesRelaEN CopyTo(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaENS)
{
try
{
 clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaENT = new clsge_StuBatchQuesRelaEN()
{
IdStuBatchQuesRela = objge_StuBatchQuesRelaENS.IdStuBatchQuesRela, //学生批次题目关系流水号
ExamBatchNo = objge_StuBatchQuesRelaENS.ExamBatchNo, //学生批次号
LevelNo = objge_StuBatchQuesRelaENS.LevelNo, //学习关号2
QuestionId = objge_StuBatchQuesRelaENS.QuestionId, //题目Id
UserId = objge_StuBatchQuesRelaENS.UserId, //用户ID
IdCurrEduCls = objge_StuBatchQuesRelaENS.IdCurrEduCls, //教学班流水号
QuestionIndex4Batch = objge_StuBatchQuesRelaENS.QuestionIndex4Batch, //题序号4批次
GameLevelId = objge_StuBatchQuesRelaENS.GameLevelId, //游戏关卡Id
Scores = objge_StuBatchQuesRelaENS.Scores, //分值
Score = objge_StuBatchQuesRelaENS.Score, //得分
StuAnswerText = objge_StuBatchQuesRelaENS.StuAnswerText, //学生回答文本
AnswerDate = objge_StuBatchQuesRelaENS.AnswerDate, //回答日期
AnswerIP = objge_StuBatchQuesRelaENS.AnswerIP, //回答IP
AnswerModeId = objge_StuBatchQuesRelaENS.AnswerModeId, //答案模式Id
AnswerMultiOptions = objge_StuBatchQuesRelaENS.AnswerMultiOptions, //多选项答案
AnswerOptionId = objge_StuBatchQuesRelaENS.AnswerOptionId, //回答选项Id
AnswerTime = objge_StuBatchQuesRelaENS.AnswerTime, //回答时间
ApplySendBackDate = objge_StuBatchQuesRelaENS.ApplySendBackDate, //申请退回日期
Comment = objge_StuBatchQuesRelaENS.Comment, //批注
IsAccessKnowledge = objge_StuBatchQuesRelaENS.IsAccessKnowledge, //是否处理知识点
IsApplySendBack = objge_StuBatchQuesRelaENS.IsApplySendBack, //是否申请退回
IsInErrorQuestion = objge_StuBatchQuesRelaENS.IsInErrorQuestion, //是否进入错题
IsLook = objge_StuBatchQuesRelaENS.IsLook, //是否查看
IsMarking = objge_StuBatchQuesRelaENS.IsMarking, //是否批阅
IsNotProcessTimeout = objge_StuBatchQuesRelaENS.IsNotProcessTimeout, //是否不处理超时
IsHasAnswer = objge_StuBatchQuesRelaENS.IsHasAnswer, //是否有答案
IsPublish = objge_StuBatchQuesRelaENS.IsPublish, //是否发布
IsRight = objge_StuBatchQuesRelaENS.IsRight, //是否正确
IsSave = objge_StuBatchQuesRelaENS.IsSave, //是否保存
IsSendBack = objge_StuBatchQuesRelaENS.IsSendBack, //是否退回
IsSubmit = objge_StuBatchQuesRelaENS.IsSubmit, //是否提交
MarkDate = objge_StuBatchQuesRelaENS.MarkDate, //打分日期
MarkerId = objge_StuBatchQuesRelaENS.MarkerId, //打分者
OperateTime = objge_StuBatchQuesRelaENS.OperateTime, //操作时间
RealFinishDate = objge_StuBatchQuesRelaENS.RealFinishDate, //实际完成日期
WorkTypeId = objge_StuBatchQuesRelaENS.WorkTypeId, //作业类型Id
SchoolYear = objge_StuBatchQuesRelaENS.SchoolYear, //学年
SchoolTerm = objge_StuBatchQuesRelaENS.SchoolTerm, //学期
ErrMsg = objge_StuBatchQuesRelaENS.ErrMsg, //错误信息
IsRecommend = objge_StuBatchQuesRelaENS.IsRecommend, //是否推荐
CourseId = objge_StuBatchQuesRelaENS.CourseId, //课程Id
UpdDate = objge_StuBatchQuesRelaENS.UpdDate, //修改日期
UpdUserId = objge_StuBatchQuesRelaENS.UpdUserId, //修改用户Id
Memo = objge_StuBatchQuesRelaENS.Memo, //备注
};
 return objge_StuBatchQuesRelaENT;
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
public static void CheckPropertyNew(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN)
{
 clsge_StuBatchQuesRelaBL.ge_StuBatchQuesRelaDA.CheckPropertyNew(objge_StuBatchQuesRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN)
{
 clsge_StuBatchQuesRelaBL.ge_StuBatchQuesRelaDA.CheckProperty4Condition(objge_StuBatchQuesRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objge_StuBatchQuesRelaCond.IsUpdated(conge_StuBatchQuesRela.IdStuBatchQuesRela) == true)
{
string strComparisonOpIdStuBatchQuesRela = objge_StuBatchQuesRelaCond.dicFldComparisonOp[conge_StuBatchQuesRela.IdStuBatchQuesRela];
strWhereCond += string.Format(" And {0} {2} {1}", conge_StuBatchQuesRela.IdStuBatchQuesRela, objge_StuBatchQuesRelaCond.IdStuBatchQuesRela, strComparisonOpIdStuBatchQuesRela);
}
if (objge_StuBatchQuesRelaCond.IsUpdated(conge_StuBatchQuesRela.ExamBatchNo) == true)
{
string strComparisonOpExamBatchNo = objge_StuBatchQuesRelaCond.dicFldComparisonOp[conge_StuBatchQuesRela.ExamBatchNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StuBatchQuesRela.ExamBatchNo, objge_StuBatchQuesRelaCond.ExamBatchNo, strComparisonOpExamBatchNo);
}
if (objge_StuBatchQuesRelaCond.IsUpdated(conge_StuBatchQuesRela.LevelNo) == true)
{
string strComparisonOpLevelNo = objge_StuBatchQuesRelaCond.dicFldComparisonOp[conge_StuBatchQuesRela.LevelNo];
strWhereCond += string.Format(" And {0} {2} {1}", conge_StuBatchQuesRela.LevelNo, objge_StuBatchQuesRelaCond.LevelNo, strComparisonOpLevelNo);
}
if (objge_StuBatchQuesRelaCond.IsUpdated(conge_StuBatchQuesRela.QuestionId) == true)
{
string strComparisonOpQuestionId = objge_StuBatchQuesRelaCond.dicFldComparisonOp[conge_StuBatchQuesRela.QuestionId];
strWhereCond += string.Format(" And {0} {2} {1}", conge_StuBatchQuesRela.QuestionId, objge_StuBatchQuesRelaCond.QuestionId, strComparisonOpQuestionId);
}
if (objge_StuBatchQuesRelaCond.IsUpdated(conge_StuBatchQuesRela.UserId) == true)
{
string strComparisonOpUserId = objge_StuBatchQuesRelaCond.dicFldComparisonOp[conge_StuBatchQuesRela.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StuBatchQuesRela.UserId, objge_StuBatchQuesRelaCond.UserId, strComparisonOpUserId);
}
if (objge_StuBatchQuesRelaCond.IsUpdated(conge_StuBatchQuesRela.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objge_StuBatchQuesRelaCond.dicFldComparisonOp[conge_StuBatchQuesRela.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StuBatchQuesRela.IdCurrEduCls, objge_StuBatchQuesRelaCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objge_StuBatchQuesRelaCond.IsUpdated(conge_StuBatchQuesRela.QuestionIndex4Batch) == true)
{
string strComparisonOpQuestionIndex4Batch = objge_StuBatchQuesRelaCond.dicFldComparisonOp[conge_StuBatchQuesRela.QuestionIndex4Batch];
strWhereCond += string.Format(" And {0} {2} {1}", conge_StuBatchQuesRela.QuestionIndex4Batch, objge_StuBatchQuesRelaCond.QuestionIndex4Batch, strComparisonOpQuestionIndex4Batch);
}
if (objge_StuBatchQuesRelaCond.IsUpdated(conge_StuBatchQuesRela.GameLevelId) == true)
{
string strComparisonOpGameLevelId = objge_StuBatchQuesRelaCond.dicFldComparisonOp[conge_StuBatchQuesRela.GameLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StuBatchQuesRela.GameLevelId, objge_StuBatchQuesRelaCond.GameLevelId, strComparisonOpGameLevelId);
}
if (objge_StuBatchQuesRelaCond.IsUpdated(conge_StuBatchQuesRela.Scores) == true)
{
string strComparisonOpScores = objge_StuBatchQuesRelaCond.dicFldComparisonOp[conge_StuBatchQuesRela.Scores];
strWhereCond += string.Format(" And {0} {2} {1}", conge_StuBatchQuesRela.Scores, objge_StuBatchQuesRelaCond.Scores, strComparisonOpScores);
}
if (objge_StuBatchQuesRelaCond.IsUpdated(conge_StuBatchQuesRela.Score) == true)
{
string strComparisonOpScore = objge_StuBatchQuesRelaCond.dicFldComparisonOp[conge_StuBatchQuesRela.Score];
strWhereCond += string.Format(" And {0} {2} {1}", conge_StuBatchQuesRela.Score, objge_StuBatchQuesRelaCond.Score, strComparisonOpScore);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objge_StuBatchQuesRelaCond.IsUpdated(conge_StuBatchQuesRela.AnswerDate) == true)
{
string strComparisonOpAnswerDate = objge_StuBatchQuesRelaCond.dicFldComparisonOp[conge_StuBatchQuesRela.AnswerDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StuBatchQuesRela.AnswerDate, objge_StuBatchQuesRelaCond.AnswerDate, strComparisonOpAnswerDate);
}
if (objge_StuBatchQuesRelaCond.IsUpdated(conge_StuBatchQuesRela.AnswerIP) == true)
{
string strComparisonOpAnswerIP = objge_StuBatchQuesRelaCond.dicFldComparisonOp[conge_StuBatchQuesRela.AnswerIP];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StuBatchQuesRela.AnswerIP, objge_StuBatchQuesRelaCond.AnswerIP, strComparisonOpAnswerIP);
}
if (objge_StuBatchQuesRelaCond.IsUpdated(conge_StuBatchQuesRela.AnswerModeId) == true)
{
string strComparisonOpAnswerModeId = objge_StuBatchQuesRelaCond.dicFldComparisonOp[conge_StuBatchQuesRela.AnswerModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StuBatchQuesRela.AnswerModeId, objge_StuBatchQuesRelaCond.AnswerModeId, strComparisonOpAnswerModeId);
}
if (objge_StuBatchQuesRelaCond.IsUpdated(conge_StuBatchQuesRela.AnswerMultiOptions) == true)
{
string strComparisonOpAnswerMultiOptions = objge_StuBatchQuesRelaCond.dicFldComparisonOp[conge_StuBatchQuesRela.AnswerMultiOptions];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StuBatchQuesRela.AnswerMultiOptions, objge_StuBatchQuesRelaCond.AnswerMultiOptions, strComparisonOpAnswerMultiOptions);
}
if (objge_StuBatchQuesRelaCond.IsUpdated(conge_StuBatchQuesRela.AnswerOptionId) == true)
{
string strComparisonOpAnswerOptionId = objge_StuBatchQuesRelaCond.dicFldComparisonOp[conge_StuBatchQuesRela.AnswerOptionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StuBatchQuesRela.AnswerOptionId, objge_StuBatchQuesRelaCond.AnswerOptionId, strComparisonOpAnswerOptionId);
}
if (objge_StuBatchQuesRelaCond.IsUpdated(conge_StuBatchQuesRela.AnswerTime) == true)
{
string strComparisonOpAnswerTime = objge_StuBatchQuesRelaCond.dicFldComparisonOp[conge_StuBatchQuesRela.AnswerTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StuBatchQuesRela.AnswerTime, objge_StuBatchQuesRelaCond.AnswerTime, strComparisonOpAnswerTime);
}
if (objge_StuBatchQuesRelaCond.IsUpdated(conge_StuBatchQuesRela.ApplySendBackDate) == true)
{
string strComparisonOpApplySendBackDate = objge_StuBatchQuesRelaCond.dicFldComparisonOp[conge_StuBatchQuesRela.ApplySendBackDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StuBatchQuesRela.ApplySendBackDate, objge_StuBatchQuesRelaCond.ApplySendBackDate, strComparisonOpApplySendBackDate);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objge_StuBatchQuesRelaCond.IsUpdated(conge_StuBatchQuesRela.IsAccessKnowledge) == true)
{
if (objge_StuBatchQuesRelaCond.IsAccessKnowledge == true)
{
strWhereCond += string.Format(" And {0} = '1'", conge_StuBatchQuesRela.IsAccessKnowledge);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conge_StuBatchQuesRela.IsAccessKnowledge);
}
}
if (objge_StuBatchQuesRelaCond.IsUpdated(conge_StuBatchQuesRela.IsApplySendBack) == true)
{
if (objge_StuBatchQuesRelaCond.IsApplySendBack == true)
{
strWhereCond += string.Format(" And {0} = '1'", conge_StuBatchQuesRela.IsApplySendBack);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conge_StuBatchQuesRela.IsApplySendBack);
}
}
if (objge_StuBatchQuesRelaCond.IsUpdated(conge_StuBatchQuesRela.IsInErrorQuestion) == true)
{
if (objge_StuBatchQuesRelaCond.IsInErrorQuestion == true)
{
strWhereCond += string.Format(" And {0} = '1'", conge_StuBatchQuesRela.IsInErrorQuestion);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conge_StuBatchQuesRela.IsInErrorQuestion);
}
}
if (objge_StuBatchQuesRelaCond.IsUpdated(conge_StuBatchQuesRela.IsLook) == true)
{
if (objge_StuBatchQuesRelaCond.IsLook == true)
{
strWhereCond += string.Format(" And {0} = '1'", conge_StuBatchQuesRela.IsLook);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conge_StuBatchQuesRela.IsLook);
}
}
if (objge_StuBatchQuesRelaCond.IsUpdated(conge_StuBatchQuesRela.IsMarking) == true)
{
if (objge_StuBatchQuesRelaCond.IsMarking == true)
{
strWhereCond += string.Format(" And {0} = '1'", conge_StuBatchQuesRela.IsMarking);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conge_StuBatchQuesRela.IsMarking);
}
}
if (objge_StuBatchQuesRelaCond.IsUpdated(conge_StuBatchQuesRela.IsNotProcessTimeout) == true)
{
if (objge_StuBatchQuesRelaCond.IsNotProcessTimeout == true)
{
strWhereCond += string.Format(" And {0} = '1'", conge_StuBatchQuesRela.IsNotProcessTimeout);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conge_StuBatchQuesRela.IsNotProcessTimeout);
}
}
if (objge_StuBatchQuesRelaCond.IsUpdated(conge_StuBatchQuesRela.IsHasAnswer) == true)
{
if (objge_StuBatchQuesRelaCond.IsHasAnswer == true)
{
strWhereCond += string.Format(" And {0} = '1'", conge_StuBatchQuesRela.IsHasAnswer);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conge_StuBatchQuesRela.IsHasAnswer);
}
}
if (objge_StuBatchQuesRelaCond.IsUpdated(conge_StuBatchQuesRela.IsPublish) == true)
{
if (objge_StuBatchQuesRelaCond.IsPublish == true)
{
strWhereCond += string.Format(" And {0} = '1'", conge_StuBatchQuesRela.IsPublish);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conge_StuBatchQuesRela.IsPublish);
}
}
if (objge_StuBatchQuesRelaCond.IsUpdated(conge_StuBatchQuesRela.IsRight) == true)
{
if (objge_StuBatchQuesRelaCond.IsRight == true)
{
strWhereCond += string.Format(" And {0} = '1'", conge_StuBatchQuesRela.IsRight);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conge_StuBatchQuesRela.IsRight);
}
}
if (objge_StuBatchQuesRelaCond.IsUpdated(conge_StuBatchQuesRela.IsSave) == true)
{
if (objge_StuBatchQuesRelaCond.IsSave == true)
{
strWhereCond += string.Format(" And {0} = '1'", conge_StuBatchQuesRela.IsSave);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conge_StuBatchQuesRela.IsSave);
}
}
if (objge_StuBatchQuesRelaCond.IsUpdated(conge_StuBatchQuesRela.IsSendBack) == true)
{
if (objge_StuBatchQuesRelaCond.IsSendBack == true)
{
strWhereCond += string.Format(" And {0} = '1'", conge_StuBatchQuesRela.IsSendBack);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conge_StuBatchQuesRela.IsSendBack);
}
}
if (objge_StuBatchQuesRelaCond.IsUpdated(conge_StuBatchQuesRela.IsSubmit) == true)
{
if (objge_StuBatchQuesRelaCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", conge_StuBatchQuesRela.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conge_StuBatchQuesRela.IsSubmit);
}
}
if (objge_StuBatchQuesRelaCond.IsUpdated(conge_StuBatchQuesRela.MarkDate) == true)
{
string strComparisonOpMarkDate = objge_StuBatchQuesRelaCond.dicFldComparisonOp[conge_StuBatchQuesRela.MarkDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StuBatchQuesRela.MarkDate, objge_StuBatchQuesRelaCond.MarkDate, strComparisonOpMarkDate);
}
if (objge_StuBatchQuesRelaCond.IsUpdated(conge_StuBatchQuesRela.MarkerId) == true)
{
string strComparisonOpMarkerId = objge_StuBatchQuesRelaCond.dicFldComparisonOp[conge_StuBatchQuesRela.MarkerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StuBatchQuesRela.MarkerId, objge_StuBatchQuesRelaCond.MarkerId, strComparisonOpMarkerId);
}
if (objge_StuBatchQuesRelaCond.IsUpdated(conge_StuBatchQuesRela.OperateTime) == true)
{
string strComparisonOpOperateTime = objge_StuBatchQuesRelaCond.dicFldComparisonOp[conge_StuBatchQuesRela.OperateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StuBatchQuesRela.OperateTime, objge_StuBatchQuesRelaCond.OperateTime, strComparisonOpOperateTime);
}
if (objge_StuBatchQuesRelaCond.IsUpdated(conge_StuBatchQuesRela.RealFinishDate) == true)
{
string strComparisonOpRealFinishDate = objge_StuBatchQuesRelaCond.dicFldComparisonOp[conge_StuBatchQuesRela.RealFinishDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StuBatchQuesRela.RealFinishDate, objge_StuBatchQuesRelaCond.RealFinishDate, strComparisonOpRealFinishDate);
}
if (objge_StuBatchQuesRelaCond.IsUpdated(conge_StuBatchQuesRela.WorkTypeId) == true)
{
string strComparisonOpWorkTypeId = objge_StuBatchQuesRelaCond.dicFldComparisonOp[conge_StuBatchQuesRela.WorkTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StuBatchQuesRela.WorkTypeId, objge_StuBatchQuesRelaCond.WorkTypeId, strComparisonOpWorkTypeId);
}
if (objge_StuBatchQuesRelaCond.IsUpdated(conge_StuBatchQuesRela.SchoolYear) == true)
{
string strComparisonOpSchoolYear = objge_StuBatchQuesRelaCond.dicFldComparisonOp[conge_StuBatchQuesRela.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StuBatchQuesRela.SchoolYear, objge_StuBatchQuesRelaCond.SchoolYear, strComparisonOpSchoolYear);
}
if (objge_StuBatchQuesRelaCond.IsUpdated(conge_StuBatchQuesRela.SchoolTerm) == true)
{
string strComparisonOpSchoolTerm = objge_StuBatchQuesRelaCond.dicFldComparisonOp[conge_StuBatchQuesRela.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StuBatchQuesRela.SchoolTerm, objge_StuBatchQuesRelaCond.SchoolTerm, strComparisonOpSchoolTerm);
}
if (objge_StuBatchQuesRelaCond.IsUpdated(conge_StuBatchQuesRela.ErrMsg) == true)
{
string strComparisonOpErrMsg = objge_StuBatchQuesRelaCond.dicFldComparisonOp[conge_StuBatchQuesRela.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StuBatchQuesRela.ErrMsg, objge_StuBatchQuesRelaCond.ErrMsg, strComparisonOpErrMsg);
}
if (objge_StuBatchQuesRelaCond.IsUpdated(conge_StuBatchQuesRela.IsRecommend) == true)
{
if (objge_StuBatchQuesRelaCond.IsRecommend == true)
{
strWhereCond += string.Format(" And {0} = '1'", conge_StuBatchQuesRela.IsRecommend);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conge_StuBatchQuesRela.IsRecommend);
}
}
if (objge_StuBatchQuesRelaCond.IsUpdated(conge_StuBatchQuesRela.CourseId) == true)
{
string strComparisonOpCourseId = objge_StuBatchQuesRelaCond.dicFldComparisonOp[conge_StuBatchQuesRela.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StuBatchQuesRela.CourseId, objge_StuBatchQuesRelaCond.CourseId, strComparisonOpCourseId);
}
if (objge_StuBatchQuesRelaCond.IsUpdated(conge_StuBatchQuesRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objge_StuBatchQuesRelaCond.dicFldComparisonOp[conge_StuBatchQuesRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StuBatchQuesRela.UpdDate, objge_StuBatchQuesRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objge_StuBatchQuesRelaCond.IsUpdated(conge_StuBatchQuesRela.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objge_StuBatchQuesRelaCond.dicFldComparisonOp[conge_StuBatchQuesRela.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StuBatchQuesRela.UpdUserId, objge_StuBatchQuesRelaCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objge_StuBatchQuesRelaCond.IsUpdated(conge_StuBatchQuesRela.Memo) == true)
{
string strComparisonOpMemo = objge_StuBatchQuesRelaCond.dicFldComparisonOp[conge_StuBatchQuesRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StuBatchQuesRela.Memo, objge_StuBatchQuesRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--ge_StuBatchQuesRela(学生批次题目关系), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:ExamBatchNo_UserId_QuestionID
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objge_StuBatchQuesRelaEN == null) return true;
if (objge_StuBatchQuesRelaEN.IdStuBatchQuesRela == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ExamBatchNo = '{0}'", objge_StuBatchQuesRelaEN.ExamBatchNo);
 sbCondition.AppendFormat(" and UserId = '{0}'", objge_StuBatchQuesRelaEN.UserId);
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objge_StuBatchQuesRelaEN.QuestionId);
if (clsge_StuBatchQuesRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("IdStuBatchQuesRela !=  {0}", objge_StuBatchQuesRelaEN.IdStuBatchQuesRela);
 sbCondition.AppendFormat(" and ExamBatchNo = '{0}'", objge_StuBatchQuesRelaEN.ExamBatchNo);
 sbCondition.AppendFormat(" and UserId = '{0}'", objge_StuBatchQuesRelaEN.UserId);
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objge_StuBatchQuesRelaEN.QuestionId);
if (clsge_StuBatchQuesRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--ge_StuBatchQuesRela(学生批次题目关系), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ExamBatchNo_UserId_QuestionID
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objge_StuBatchQuesRelaEN == null) return "";
if (objge_StuBatchQuesRelaEN.IdStuBatchQuesRela == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ExamBatchNo = '{0}'", objge_StuBatchQuesRelaEN.ExamBatchNo);
 sbCondition.AppendFormat(" and UserId = '{0}'", objge_StuBatchQuesRelaEN.UserId);
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objge_StuBatchQuesRelaEN.QuestionId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("IdStuBatchQuesRela !=  {0}", objge_StuBatchQuesRelaEN.IdStuBatchQuesRela);
 sbCondition.AppendFormat(" and ExamBatchNo = '{0}'", objge_StuBatchQuesRelaEN.ExamBatchNo);
 sbCondition.AppendFormat(" and UserId = '{0}'", objge_StuBatchQuesRelaEN.UserId);
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objge_StuBatchQuesRelaEN.QuestionId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ge_StuBatchQuesRela
{
public virtual bool UpdRelaTabDate(long lngIdStuBatchQuesRela, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 学生批次题目关系(ge_StuBatchQuesRela)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsge_StuBatchQuesRelaBL
{
public static RelatedActions_ge_StuBatchQuesRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsge_StuBatchQuesRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsge_StuBatchQuesRelaDA ge_StuBatchQuesRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsge_StuBatchQuesRelaDA();
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
 public clsge_StuBatchQuesRelaBL()
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
if (string.IsNullOrEmpty(clsge_StuBatchQuesRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsge_StuBatchQuesRelaEN._ConnectString);
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
public static DataTable GetDataTable_ge_StuBatchQuesRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ge_StuBatchQuesRelaDA.GetDataTable_ge_StuBatchQuesRela(strWhereCond);
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
objDT = ge_StuBatchQuesRelaDA.GetDataTable(strWhereCond);
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
objDT = ge_StuBatchQuesRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ge_StuBatchQuesRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ge_StuBatchQuesRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ge_StuBatchQuesRelaDA.GetDataTable_Top(objTopPara);
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
objDT = ge_StuBatchQuesRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ge_StuBatchQuesRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ge_StuBatchQuesRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdStuBatchQuesRelaLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsge_StuBatchQuesRelaEN> GetObjLstByIdStuBatchQuesRelaLst(List<long> arrIdStuBatchQuesRelaLst)
{
List<clsge_StuBatchQuesRelaEN> arrObjLst = new List<clsge_StuBatchQuesRelaEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdStuBatchQuesRelaLst);
 string strWhereCond = string.Format("IdStuBatchQuesRela in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN = new clsge_StuBatchQuesRelaEN();
try
{
objge_StuBatchQuesRelaEN.IdStuBatchQuesRela = Int32.Parse(objRow[conge_StuBatchQuesRela.IdStuBatchQuesRela].ToString().Trim()); //学生批次题目关系流水号
objge_StuBatchQuesRelaEN.ExamBatchNo = objRow[conge_StuBatchQuesRela.ExamBatchNo].ToString().Trim(); //学生批次号
objge_StuBatchQuesRelaEN.LevelNo = objRow[conge_StuBatchQuesRela.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StuBatchQuesRela.LevelNo].ToString().Trim()); //学习关号2
objge_StuBatchQuesRelaEN.QuestionId = Int32.Parse(objRow[conge_StuBatchQuesRela.QuestionId].ToString().Trim()); //题目Id
objge_StuBatchQuesRelaEN.UserId = objRow[conge_StuBatchQuesRela.UserId].ToString().Trim(); //用户ID
objge_StuBatchQuesRelaEN.IdCurrEduCls = objRow[conge_StuBatchQuesRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_StuBatchQuesRelaEN.QuestionIndex4Batch = objRow[conge_StuBatchQuesRela.QuestionIndex4Batch] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StuBatchQuesRela.QuestionIndex4Batch].ToString().Trim()); //题序号4批次
objge_StuBatchQuesRelaEN.GameLevelId = objRow[conge_StuBatchQuesRela.GameLevelId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.GameLevelId].ToString().Trim(); //游戏关卡Id
objge_StuBatchQuesRelaEN.Scores = objRow[conge_StuBatchQuesRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_StuBatchQuesRela.Scores].ToString().Trim()); //分值
objge_StuBatchQuesRelaEN.Score = objRow[conge_StuBatchQuesRela.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_StuBatchQuesRela.Score].ToString().Trim()); //得分
objge_StuBatchQuesRelaEN.StuAnswerText = objRow[conge_StuBatchQuesRela.StuAnswerText] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.StuAnswerText].ToString().Trim(); //学生回答文本
objge_StuBatchQuesRelaEN.AnswerDate = objRow[conge_StuBatchQuesRela.AnswerDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerDate].ToString().Trim(); //回答日期
objge_StuBatchQuesRelaEN.AnswerIP = objRow[conge_StuBatchQuesRela.AnswerIP] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerIP].ToString().Trim(); //回答IP
objge_StuBatchQuesRelaEN.AnswerModeId = objRow[conge_StuBatchQuesRela.AnswerModeId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerModeId].ToString().Trim(); //答案模式Id
objge_StuBatchQuesRelaEN.AnswerMultiOptions = objRow[conge_StuBatchQuesRela.AnswerMultiOptions] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerMultiOptions].ToString().Trim(); //多选项答案
objge_StuBatchQuesRelaEN.AnswerOptionId = objRow[conge_StuBatchQuesRela.AnswerOptionId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerOptionId].ToString().Trim(); //回答选项Id
objge_StuBatchQuesRelaEN.AnswerTime = objRow[conge_StuBatchQuesRela.AnswerTime] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerTime].ToString().Trim(); //回答时间
objge_StuBatchQuesRelaEN.ApplySendBackDate = objRow[conge_StuBatchQuesRela.ApplySendBackDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.ApplySendBackDate].ToString().Trim(); //申请退回日期
objge_StuBatchQuesRelaEN.Comment = objRow[conge_StuBatchQuesRela.Comment] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.Comment].ToString().Trim(); //批注
objge_StuBatchQuesRelaEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objge_StuBatchQuesRelaEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsApplySendBack].ToString().Trim()); //是否申请退回
objge_StuBatchQuesRelaEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objge_StuBatchQuesRelaEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsLook].ToString().Trim()); //是否查看
objge_StuBatchQuesRelaEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsMarking].ToString().Trim()); //是否批阅
objge_StuBatchQuesRelaEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objge_StuBatchQuesRelaEN.IsHasAnswer = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsHasAnswer].ToString().Trim()); //是否有答案
objge_StuBatchQuesRelaEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsPublish].ToString().Trim()); //是否发布
objge_StuBatchQuesRelaEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsRight].ToString().Trim()); //是否正确
objge_StuBatchQuesRelaEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsSave].ToString().Trim()); //是否保存
objge_StuBatchQuesRelaEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsSendBack].ToString().Trim()); //是否退回
objge_StuBatchQuesRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsSubmit].ToString().Trim()); //是否提交
objge_StuBatchQuesRelaEN.MarkDate = objRow[conge_StuBatchQuesRela.MarkDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.MarkDate].ToString().Trim(); //打分日期
objge_StuBatchQuesRelaEN.MarkerId = objRow[conge_StuBatchQuesRela.MarkerId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.MarkerId].ToString().Trim(); //打分者
objge_StuBatchQuesRelaEN.OperateTime = objRow[conge_StuBatchQuesRela.OperateTime] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.OperateTime].ToString().Trim(); //操作时间
objge_StuBatchQuesRelaEN.RealFinishDate = objRow[conge_StuBatchQuesRela.RealFinishDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.RealFinishDate].ToString().Trim(); //实际完成日期
objge_StuBatchQuesRelaEN.WorkTypeId = objRow[conge_StuBatchQuesRela.WorkTypeId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.WorkTypeId].ToString().Trim(); //作业类型Id
objge_StuBatchQuesRelaEN.SchoolYear = objRow[conge_StuBatchQuesRela.SchoolYear] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.SchoolYear].ToString().Trim(); //学年
objge_StuBatchQuesRelaEN.SchoolTerm = objRow[conge_StuBatchQuesRela.SchoolTerm] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.SchoolTerm].ToString().Trim(); //学期
objge_StuBatchQuesRelaEN.ErrMsg = objRow[conge_StuBatchQuesRela.ErrMsg] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.ErrMsg].ToString().Trim(); //错误信息
objge_StuBatchQuesRelaEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsRecommend].ToString().Trim()); //是否推荐
objge_StuBatchQuesRelaEN.CourseId = objRow[conge_StuBatchQuesRela.CourseId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.CourseId].ToString().Trim(); //课程Id
objge_StuBatchQuesRelaEN.UpdDate = objRow[conge_StuBatchQuesRela.UpdDate].ToString().Trim(); //修改日期
objge_StuBatchQuesRelaEN.UpdUserId = objRow[conge_StuBatchQuesRela.UpdUserId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.UpdUserId].ToString().Trim(); //修改用户Id
objge_StuBatchQuesRelaEN.Memo = objRow[conge_StuBatchQuesRela.Memo] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StuBatchQuesRelaEN.IdStuBatchQuesRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StuBatchQuesRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdStuBatchQuesRelaLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsge_StuBatchQuesRelaEN> GetObjLstByIdStuBatchQuesRelaLstCache(List<long> arrIdStuBatchQuesRelaLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsge_StuBatchQuesRelaEN._CurrTabName, strIdCurrEduCls);
List<clsge_StuBatchQuesRelaEN> arrge_StuBatchQuesRelaObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsge_StuBatchQuesRelaEN> arrge_StuBatchQuesRelaObjLst_Sel =
arrge_StuBatchQuesRelaObjLstCache
.Where(x => arrIdStuBatchQuesRelaLst.Contains(x.IdStuBatchQuesRela));
return arrge_StuBatchQuesRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_StuBatchQuesRelaEN> GetObjLst(string strWhereCond)
{
List<clsge_StuBatchQuesRelaEN> arrObjLst = new List<clsge_StuBatchQuesRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN = new clsge_StuBatchQuesRelaEN();
try
{
objge_StuBatchQuesRelaEN.IdStuBatchQuesRela = Int32.Parse(objRow[conge_StuBatchQuesRela.IdStuBatchQuesRela].ToString().Trim()); //学生批次题目关系流水号
objge_StuBatchQuesRelaEN.ExamBatchNo = objRow[conge_StuBatchQuesRela.ExamBatchNo].ToString().Trim(); //学生批次号
objge_StuBatchQuesRelaEN.LevelNo = objRow[conge_StuBatchQuesRela.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StuBatchQuesRela.LevelNo].ToString().Trim()); //学习关号2
objge_StuBatchQuesRelaEN.QuestionId = Int32.Parse(objRow[conge_StuBatchQuesRela.QuestionId].ToString().Trim()); //题目Id
objge_StuBatchQuesRelaEN.UserId = objRow[conge_StuBatchQuesRela.UserId].ToString().Trim(); //用户ID
objge_StuBatchQuesRelaEN.IdCurrEduCls = objRow[conge_StuBatchQuesRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_StuBatchQuesRelaEN.QuestionIndex4Batch = objRow[conge_StuBatchQuesRela.QuestionIndex4Batch] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StuBatchQuesRela.QuestionIndex4Batch].ToString().Trim()); //题序号4批次
objge_StuBatchQuesRelaEN.GameLevelId = objRow[conge_StuBatchQuesRela.GameLevelId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.GameLevelId].ToString().Trim(); //游戏关卡Id
objge_StuBatchQuesRelaEN.Scores = objRow[conge_StuBatchQuesRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_StuBatchQuesRela.Scores].ToString().Trim()); //分值
objge_StuBatchQuesRelaEN.Score = objRow[conge_StuBatchQuesRela.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_StuBatchQuesRela.Score].ToString().Trim()); //得分
objge_StuBatchQuesRelaEN.StuAnswerText = objRow[conge_StuBatchQuesRela.StuAnswerText] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.StuAnswerText].ToString().Trim(); //学生回答文本
objge_StuBatchQuesRelaEN.AnswerDate = objRow[conge_StuBatchQuesRela.AnswerDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerDate].ToString().Trim(); //回答日期
objge_StuBatchQuesRelaEN.AnswerIP = objRow[conge_StuBatchQuesRela.AnswerIP] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerIP].ToString().Trim(); //回答IP
objge_StuBatchQuesRelaEN.AnswerModeId = objRow[conge_StuBatchQuesRela.AnswerModeId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerModeId].ToString().Trim(); //答案模式Id
objge_StuBatchQuesRelaEN.AnswerMultiOptions = objRow[conge_StuBatchQuesRela.AnswerMultiOptions] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerMultiOptions].ToString().Trim(); //多选项答案
objge_StuBatchQuesRelaEN.AnswerOptionId = objRow[conge_StuBatchQuesRela.AnswerOptionId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerOptionId].ToString().Trim(); //回答选项Id
objge_StuBatchQuesRelaEN.AnswerTime = objRow[conge_StuBatchQuesRela.AnswerTime] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerTime].ToString().Trim(); //回答时间
objge_StuBatchQuesRelaEN.ApplySendBackDate = objRow[conge_StuBatchQuesRela.ApplySendBackDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.ApplySendBackDate].ToString().Trim(); //申请退回日期
objge_StuBatchQuesRelaEN.Comment = objRow[conge_StuBatchQuesRela.Comment] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.Comment].ToString().Trim(); //批注
objge_StuBatchQuesRelaEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objge_StuBatchQuesRelaEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsApplySendBack].ToString().Trim()); //是否申请退回
objge_StuBatchQuesRelaEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objge_StuBatchQuesRelaEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsLook].ToString().Trim()); //是否查看
objge_StuBatchQuesRelaEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsMarking].ToString().Trim()); //是否批阅
objge_StuBatchQuesRelaEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objge_StuBatchQuesRelaEN.IsHasAnswer = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsHasAnswer].ToString().Trim()); //是否有答案
objge_StuBatchQuesRelaEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsPublish].ToString().Trim()); //是否发布
objge_StuBatchQuesRelaEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsRight].ToString().Trim()); //是否正确
objge_StuBatchQuesRelaEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsSave].ToString().Trim()); //是否保存
objge_StuBatchQuesRelaEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsSendBack].ToString().Trim()); //是否退回
objge_StuBatchQuesRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsSubmit].ToString().Trim()); //是否提交
objge_StuBatchQuesRelaEN.MarkDate = objRow[conge_StuBatchQuesRela.MarkDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.MarkDate].ToString().Trim(); //打分日期
objge_StuBatchQuesRelaEN.MarkerId = objRow[conge_StuBatchQuesRela.MarkerId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.MarkerId].ToString().Trim(); //打分者
objge_StuBatchQuesRelaEN.OperateTime = objRow[conge_StuBatchQuesRela.OperateTime] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.OperateTime].ToString().Trim(); //操作时间
objge_StuBatchQuesRelaEN.RealFinishDate = objRow[conge_StuBatchQuesRela.RealFinishDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.RealFinishDate].ToString().Trim(); //实际完成日期
objge_StuBatchQuesRelaEN.WorkTypeId = objRow[conge_StuBatchQuesRela.WorkTypeId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.WorkTypeId].ToString().Trim(); //作业类型Id
objge_StuBatchQuesRelaEN.SchoolYear = objRow[conge_StuBatchQuesRela.SchoolYear] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.SchoolYear].ToString().Trim(); //学年
objge_StuBatchQuesRelaEN.SchoolTerm = objRow[conge_StuBatchQuesRela.SchoolTerm] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.SchoolTerm].ToString().Trim(); //学期
objge_StuBatchQuesRelaEN.ErrMsg = objRow[conge_StuBatchQuesRela.ErrMsg] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.ErrMsg].ToString().Trim(); //错误信息
objge_StuBatchQuesRelaEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsRecommend].ToString().Trim()); //是否推荐
objge_StuBatchQuesRelaEN.CourseId = objRow[conge_StuBatchQuesRela.CourseId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.CourseId].ToString().Trim(); //课程Id
objge_StuBatchQuesRelaEN.UpdDate = objRow[conge_StuBatchQuesRela.UpdDate].ToString().Trim(); //修改日期
objge_StuBatchQuesRelaEN.UpdUserId = objRow[conge_StuBatchQuesRela.UpdUserId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.UpdUserId].ToString().Trim(); //修改用户Id
objge_StuBatchQuesRelaEN.Memo = objRow[conge_StuBatchQuesRela.Memo] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StuBatchQuesRelaEN.IdStuBatchQuesRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StuBatchQuesRelaEN);
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
public static List<clsge_StuBatchQuesRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsge_StuBatchQuesRelaEN> arrObjLst = new List<clsge_StuBatchQuesRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN = new clsge_StuBatchQuesRelaEN();
try
{
objge_StuBatchQuesRelaEN.IdStuBatchQuesRela = Int32.Parse(objRow[conge_StuBatchQuesRela.IdStuBatchQuesRela].ToString().Trim()); //学生批次题目关系流水号
objge_StuBatchQuesRelaEN.ExamBatchNo = objRow[conge_StuBatchQuesRela.ExamBatchNo].ToString().Trim(); //学生批次号
objge_StuBatchQuesRelaEN.LevelNo = objRow[conge_StuBatchQuesRela.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StuBatchQuesRela.LevelNo].ToString().Trim()); //学习关号2
objge_StuBatchQuesRelaEN.QuestionId = Int32.Parse(objRow[conge_StuBatchQuesRela.QuestionId].ToString().Trim()); //题目Id
objge_StuBatchQuesRelaEN.UserId = objRow[conge_StuBatchQuesRela.UserId].ToString().Trim(); //用户ID
objge_StuBatchQuesRelaEN.IdCurrEduCls = objRow[conge_StuBatchQuesRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_StuBatchQuesRelaEN.QuestionIndex4Batch = objRow[conge_StuBatchQuesRela.QuestionIndex4Batch] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StuBatchQuesRela.QuestionIndex4Batch].ToString().Trim()); //题序号4批次
objge_StuBatchQuesRelaEN.GameLevelId = objRow[conge_StuBatchQuesRela.GameLevelId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.GameLevelId].ToString().Trim(); //游戏关卡Id
objge_StuBatchQuesRelaEN.Scores = objRow[conge_StuBatchQuesRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_StuBatchQuesRela.Scores].ToString().Trim()); //分值
objge_StuBatchQuesRelaEN.Score = objRow[conge_StuBatchQuesRela.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_StuBatchQuesRela.Score].ToString().Trim()); //得分
objge_StuBatchQuesRelaEN.StuAnswerText = objRow[conge_StuBatchQuesRela.StuAnswerText] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.StuAnswerText].ToString().Trim(); //学生回答文本
objge_StuBatchQuesRelaEN.AnswerDate = objRow[conge_StuBatchQuesRela.AnswerDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerDate].ToString().Trim(); //回答日期
objge_StuBatchQuesRelaEN.AnswerIP = objRow[conge_StuBatchQuesRela.AnswerIP] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerIP].ToString().Trim(); //回答IP
objge_StuBatchQuesRelaEN.AnswerModeId = objRow[conge_StuBatchQuesRela.AnswerModeId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerModeId].ToString().Trim(); //答案模式Id
objge_StuBatchQuesRelaEN.AnswerMultiOptions = objRow[conge_StuBatchQuesRela.AnswerMultiOptions] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerMultiOptions].ToString().Trim(); //多选项答案
objge_StuBatchQuesRelaEN.AnswerOptionId = objRow[conge_StuBatchQuesRela.AnswerOptionId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerOptionId].ToString().Trim(); //回答选项Id
objge_StuBatchQuesRelaEN.AnswerTime = objRow[conge_StuBatchQuesRela.AnswerTime] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerTime].ToString().Trim(); //回答时间
objge_StuBatchQuesRelaEN.ApplySendBackDate = objRow[conge_StuBatchQuesRela.ApplySendBackDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.ApplySendBackDate].ToString().Trim(); //申请退回日期
objge_StuBatchQuesRelaEN.Comment = objRow[conge_StuBatchQuesRela.Comment] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.Comment].ToString().Trim(); //批注
objge_StuBatchQuesRelaEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objge_StuBatchQuesRelaEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsApplySendBack].ToString().Trim()); //是否申请退回
objge_StuBatchQuesRelaEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objge_StuBatchQuesRelaEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsLook].ToString().Trim()); //是否查看
objge_StuBatchQuesRelaEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsMarking].ToString().Trim()); //是否批阅
objge_StuBatchQuesRelaEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objge_StuBatchQuesRelaEN.IsHasAnswer = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsHasAnswer].ToString().Trim()); //是否有答案
objge_StuBatchQuesRelaEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsPublish].ToString().Trim()); //是否发布
objge_StuBatchQuesRelaEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsRight].ToString().Trim()); //是否正确
objge_StuBatchQuesRelaEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsSave].ToString().Trim()); //是否保存
objge_StuBatchQuesRelaEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsSendBack].ToString().Trim()); //是否退回
objge_StuBatchQuesRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsSubmit].ToString().Trim()); //是否提交
objge_StuBatchQuesRelaEN.MarkDate = objRow[conge_StuBatchQuesRela.MarkDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.MarkDate].ToString().Trim(); //打分日期
objge_StuBatchQuesRelaEN.MarkerId = objRow[conge_StuBatchQuesRela.MarkerId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.MarkerId].ToString().Trim(); //打分者
objge_StuBatchQuesRelaEN.OperateTime = objRow[conge_StuBatchQuesRela.OperateTime] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.OperateTime].ToString().Trim(); //操作时间
objge_StuBatchQuesRelaEN.RealFinishDate = objRow[conge_StuBatchQuesRela.RealFinishDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.RealFinishDate].ToString().Trim(); //实际完成日期
objge_StuBatchQuesRelaEN.WorkTypeId = objRow[conge_StuBatchQuesRela.WorkTypeId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.WorkTypeId].ToString().Trim(); //作业类型Id
objge_StuBatchQuesRelaEN.SchoolYear = objRow[conge_StuBatchQuesRela.SchoolYear] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.SchoolYear].ToString().Trim(); //学年
objge_StuBatchQuesRelaEN.SchoolTerm = objRow[conge_StuBatchQuesRela.SchoolTerm] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.SchoolTerm].ToString().Trim(); //学期
objge_StuBatchQuesRelaEN.ErrMsg = objRow[conge_StuBatchQuesRela.ErrMsg] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.ErrMsg].ToString().Trim(); //错误信息
objge_StuBatchQuesRelaEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsRecommend].ToString().Trim()); //是否推荐
objge_StuBatchQuesRelaEN.CourseId = objRow[conge_StuBatchQuesRela.CourseId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.CourseId].ToString().Trim(); //课程Id
objge_StuBatchQuesRelaEN.UpdDate = objRow[conge_StuBatchQuesRela.UpdDate].ToString().Trim(); //修改日期
objge_StuBatchQuesRelaEN.UpdUserId = objRow[conge_StuBatchQuesRela.UpdUserId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.UpdUserId].ToString().Trim(); //修改用户Id
objge_StuBatchQuesRelaEN.Memo = objRow[conge_StuBatchQuesRela.Memo] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StuBatchQuesRelaEN.IdStuBatchQuesRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StuBatchQuesRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsge_StuBatchQuesRelaEN> GetSubObjLstCache(clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaCond)
{
 string strIdCurrEduCls = objge_StuBatchQuesRelaCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsge_StuBatchQuesRelaBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsge_StuBatchQuesRelaEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsge_StuBatchQuesRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conge_StuBatchQuesRela.AttributeName)
{
if (objge_StuBatchQuesRelaCond.IsUpdated(strFldName) == false) continue;
if (objge_StuBatchQuesRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_StuBatchQuesRelaCond[strFldName].ToString());
}
else
{
if (objge_StuBatchQuesRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objge_StuBatchQuesRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_StuBatchQuesRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objge_StuBatchQuesRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objge_StuBatchQuesRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objge_StuBatchQuesRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objge_StuBatchQuesRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objge_StuBatchQuesRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objge_StuBatchQuesRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objge_StuBatchQuesRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objge_StuBatchQuesRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objge_StuBatchQuesRelaCond[strFldName]));
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
public static List<clsge_StuBatchQuesRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsge_StuBatchQuesRelaEN> arrObjLst = new List<clsge_StuBatchQuesRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN = new clsge_StuBatchQuesRelaEN();
try
{
objge_StuBatchQuesRelaEN.IdStuBatchQuesRela = Int32.Parse(objRow[conge_StuBatchQuesRela.IdStuBatchQuesRela].ToString().Trim()); //学生批次题目关系流水号
objge_StuBatchQuesRelaEN.ExamBatchNo = objRow[conge_StuBatchQuesRela.ExamBatchNo].ToString().Trim(); //学生批次号
objge_StuBatchQuesRelaEN.LevelNo = objRow[conge_StuBatchQuesRela.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StuBatchQuesRela.LevelNo].ToString().Trim()); //学习关号2
objge_StuBatchQuesRelaEN.QuestionId = Int32.Parse(objRow[conge_StuBatchQuesRela.QuestionId].ToString().Trim()); //题目Id
objge_StuBatchQuesRelaEN.UserId = objRow[conge_StuBatchQuesRela.UserId].ToString().Trim(); //用户ID
objge_StuBatchQuesRelaEN.IdCurrEduCls = objRow[conge_StuBatchQuesRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_StuBatchQuesRelaEN.QuestionIndex4Batch = objRow[conge_StuBatchQuesRela.QuestionIndex4Batch] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StuBatchQuesRela.QuestionIndex4Batch].ToString().Trim()); //题序号4批次
objge_StuBatchQuesRelaEN.GameLevelId = objRow[conge_StuBatchQuesRela.GameLevelId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.GameLevelId].ToString().Trim(); //游戏关卡Id
objge_StuBatchQuesRelaEN.Scores = objRow[conge_StuBatchQuesRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_StuBatchQuesRela.Scores].ToString().Trim()); //分值
objge_StuBatchQuesRelaEN.Score = objRow[conge_StuBatchQuesRela.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_StuBatchQuesRela.Score].ToString().Trim()); //得分
objge_StuBatchQuesRelaEN.StuAnswerText = objRow[conge_StuBatchQuesRela.StuAnswerText] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.StuAnswerText].ToString().Trim(); //学生回答文本
objge_StuBatchQuesRelaEN.AnswerDate = objRow[conge_StuBatchQuesRela.AnswerDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerDate].ToString().Trim(); //回答日期
objge_StuBatchQuesRelaEN.AnswerIP = objRow[conge_StuBatchQuesRela.AnswerIP] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerIP].ToString().Trim(); //回答IP
objge_StuBatchQuesRelaEN.AnswerModeId = objRow[conge_StuBatchQuesRela.AnswerModeId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerModeId].ToString().Trim(); //答案模式Id
objge_StuBatchQuesRelaEN.AnswerMultiOptions = objRow[conge_StuBatchQuesRela.AnswerMultiOptions] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerMultiOptions].ToString().Trim(); //多选项答案
objge_StuBatchQuesRelaEN.AnswerOptionId = objRow[conge_StuBatchQuesRela.AnswerOptionId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerOptionId].ToString().Trim(); //回答选项Id
objge_StuBatchQuesRelaEN.AnswerTime = objRow[conge_StuBatchQuesRela.AnswerTime] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerTime].ToString().Trim(); //回答时间
objge_StuBatchQuesRelaEN.ApplySendBackDate = objRow[conge_StuBatchQuesRela.ApplySendBackDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.ApplySendBackDate].ToString().Trim(); //申请退回日期
objge_StuBatchQuesRelaEN.Comment = objRow[conge_StuBatchQuesRela.Comment] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.Comment].ToString().Trim(); //批注
objge_StuBatchQuesRelaEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objge_StuBatchQuesRelaEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsApplySendBack].ToString().Trim()); //是否申请退回
objge_StuBatchQuesRelaEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objge_StuBatchQuesRelaEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsLook].ToString().Trim()); //是否查看
objge_StuBatchQuesRelaEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsMarking].ToString().Trim()); //是否批阅
objge_StuBatchQuesRelaEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objge_StuBatchQuesRelaEN.IsHasAnswer = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsHasAnswer].ToString().Trim()); //是否有答案
objge_StuBatchQuesRelaEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsPublish].ToString().Trim()); //是否发布
objge_StuBatchQuesRelaEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsRight].ToString().Trim()); //是否正确
objge_StuBatchQuesRelaEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsSave].ToString().Trim()); //是否保存
objge_StuBatchQuesRelaEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsSendBack].ToString().Trim()); //是否退回
objge_StuBatchQuesRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsSubmit].ToString().Trim()); //是否提交
objge_StuBatchQuesRelaEN.MarkDate = objRow[conge_StuBatchQuesRela.MarkDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.MarkDate].ToString().Trim(); //打分日期
objge_StuBatchQuesRelaEN.MarkerId = objRow[conge_StuBatchQuesRela.MarkerId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.MarkerId].ToString().Trim(); //打分者
objge_StuBatchQuesRelaEN.OperateTime = objRow[conge_StuBatchQuesRela.OperateTime] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.OperateTime].ToString().Trim(); //操作时间
objge_StuBatchQuesRelaEN.RealFinishDate = objRow[conge_StuBatchQuesRela.RealFinishDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.RealFinishDate].ToString().Trim(); //实际完成日期
objge_StuBatchQuesRelaEN.WorkTypeId = objRow[conge_StuBatchQuesRela.WorkTypeId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.WorkTypeId].ToString().Trim(); //作业类型Id
objge_StuBatchQuesRelaEN.SchoolYear = objRow[conge_StuBatchQuesRela.SchoolYear] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.SchoolYear].ToString().Trim(); //学年
objge_StuBatchQuesRelaEN.SchoolTerm = objRow[conge_StuBatchQuesRela.SchoolTerm] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.SchoolTerm].ToString().Trim(); //学期
objge_StuBatchQuesRelaEN.ErrMsg = objRow[conge_StuBatchQuesRela.ErrMsg] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.ErrMsg].ToString().Trim(); //错误信息
objge_StuBatchQuesRelaEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsRecommend].ToString().Trim()); //是否推荐
objge_StuBatchQuesRelaEN.CourseId = objRow[conge_StuBatchQuesRela.CourseId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.CourseId].ToString().Trim(); //课程Id
objge_StuBatchQuesRelaEN.UpdDate = objRow[conge_StuBatchQuesRela.UpdDate].ToString().Trim(); //修改日期
objge_StuBatchQuesRelaEN.UpdUserId = objRow[conge_StuBatchQuesRela.UpdUserId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.UpdUserId].ToString().Trim(); //修改用户Id
objge_StuBatchQuesRelaEN.Memo = objRow[conge_StuBatchQuesRela.Memo] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StuBatchQuesRelaEN.IdStuBatchQuesRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StuBatchQuesRelaEN);
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
public static List<clsge_StuBatchQuesRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsge_StuBatchQuesRelaEN> arrObjLst = new List<clsge_StuBatchQuesRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN = new clsge_StuBatchQuesRelaEN();
try
{
objge_StuBatchQuesRelaEN.IdStuBatchQuesRela = Int32.Parse(objRow[conge_StuBatchQuesRela.IdStuBatchQuesRela].ToString().Trim()); //学生批次题目关系流水号
objge_StuBatchQuesRelaEN.ExamBatchNo = objRow[conge_StuBatchQuesRela.ExamBatchNo].ToString().Trim(); //学生批次号
objge_StuBatchQuesRelaEN.LevelNo = objRow[conge_StuBatchQuesRela.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StuBatchQuesRela.LevelNo].ToString().Trim()); //学习关号2
objge_StuBatchQuesRelaEN.QuestionId = Int32.Parse(objRow[conge_StuBatchQuesRela.QuestionId].ToString().Trim()); //题目Id
objge_StuBatchQuesRelaEN.UserId = objRow[conge_StuBatchQuesRela.UserId].ToString().Trim(); //用户ID
objge_StuBatchQuesRelaEN.IdCurrEduCls = objRow[conge_StuBatchQuesRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_StuBatchQuesRelaEN.QuestionIndex4Batch = objRow[conge_StuBatchQuesRela.QuestionIndex4Batch] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StuBatchQuesRela.QuestionIndex4Batch].ToString().Trim()); //题序号4批次
objge_StuBatchQuesRelaEN.GameLevelId = objRow[conge_StuBatchQuesRela.GameLevelId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.GameLevelId].ToString().Trim(); //游戏关卡Id
objge_StuBatchQuesRelaEN.Scores = objRow[conge_StuBatchQuesRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_StuBatchQuesRela.Scores].ToString().Trim()); //分值
objge_StuBatchQuesRelaEN.Score = objRow[conge_StuBatchQuesRela.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_StuBatchQuesRela.Score].ToString().Trim()); //得分
objge_StuBatchQuesRelaEN.StuAnswerText = objRow[conge_StuBatchQuesRela.StuAnswerText] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.StuAnswerText].ToString().Trim(); //学生回答文本
objge_StuBatchQuesRelaEN.AnswerDate = objRow[conge_StuBatchQuesRela.AnswerDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerDate].ToString().Trim(); //回答日期
objge_StuBatchQuesRelaEN.AnswerIP = objRow[conge_StuBatchQuesRela.AnswerIP] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerIP].ToString().Trim(); //回答IP
objge_StuBatchQuesRelaEN.AnswerModeId = objRow[conge_StuBatchQuesRela.AnswerModeId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerModeId].ToString().Trim(); //答案模式Id
objge_StuBatchQuesRelaEN.AnswerMultiOptions = objRow[conge_StuBatchQuesRela.AnswerMultiOptions] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerMultiOptions].ToString().Trim(); //多选项答案
objge_StuBatchQuesRelaEN.AnswerOptionId = objRow[conge_StuBatchQuesRela.AnswerOptionId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerOptionId].ToString().Trim(); //回答选项Id
objge_StuBatchQuesRelaEN.AnswerTime = objRow[conge_StuBatchQuesRela.AnswerTime] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerTime].ToString().Trim(); //回答时间
objge_StuBatchQuesRelaEN.ApplySendBackDate = objRow[conge_StuBatchQuesRela.ApplySendBackDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.ApplySendBackDate].ToString().Trim(); //申请退回日期
objge_StuBatchQuesRelaEN.Comment = objRow[conge_StuBatchQuesRela.Comment] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.Comment].ToString().Trim(); //批注
objge_StuBatchQuesRelaEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objge_StuBatchQuesRelaEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsApplySendBack].ToString().Trim()); //是否申请退回
objge_StuBatchQuesRelaEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objge_StuBatchQuesRelaEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsLook].ToString().Trim()); //是否查看
objge_StuBatchQuesRelaEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsMarking].ToString().Trim()); //是否批阅
objge_StuBatchQuesRelaEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objge_StuBatchQuesRelaEN.IsHasAnswer = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsHasAnswer].ToString().Trim()); //是否有答案
objge_StuBatchQuesRelaEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsPublish].ToString().Trim()); //是否发布
objge_StuBatchQuesRelaEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsRight].ToString().Trim()); //是否正确
objge_StuBatchQuesRelaEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsSave].ToString().Trim()); //是否保存
objge_StuBatchQuesRelaEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsSendBack].ToString().Trim()); //是否退回
objge_StuBatchQuesRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsSubmit].ToString().Trim()); //是否提交
objge_StuBatchQuesRelaEN.MarkDate = objRow[conge_StuBatchQuesRela.MarkDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.MarkDate].ToString().Trim(); //打分日期
objge_StuBatchQuesRelaEN.MarkerId = objRow[conge_StuBatchQuesRela.MarkerId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.MarkerId].ToString().Trim(); //打分者
objge_StuBatchQuesRelaEN.OperateTime = objRow[conge_StuBatchQuesRela.OperateTime] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.OperateTime].ToString().Trim(); //操作时间
objge_StuBatchQuesRelaEN.RealFinishDate = objRow[conge_StuBatchQuesRela.RealFinishDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.RealFinishDate].ToString().Trim(); //实际完成日期
objge_StuBatchQuesRelaEN.WorkTypeId = objRow[conge_StuBatchQuesRela.WorkTypeId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.WorkTypeId].ToString().Trim(); //作业类型Id
objge_StuBatchQuesRelaEN.SchoolYear = objRow[conge_StuBatchQuesRela.SchoolYear] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.SchoolYear].ToString().Trim(); //学年
objge_StuBatchQuesRelaEN.SchoolTerm = objRow[conge_StuBatchQuesRela.SchoolTerm] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.SchoolTerm].ToString().Trim(); //学期
objge_StuBatchQuesRelaEN.ErrMsg = objRow[conge_StuBatchQuesRela.ErrMsg] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.ErrMsg].ToString().Trim(); //错误信息
objge_StuBatchQuesRelaEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsRecommend].ToString().Trim()); //是否推荐
objge_StuBatchQuesRelaEN.CourseId = objRow[conge_StuBatchQuesRela.CourseId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.CourseId].ToString().Trim(); //课程Id
objge_StuBatchQuesRelaEN.UpdDate = objRow[conge_StuBatchQuesRela.UpdDate].ToString().Trim(); //修改日期
objge_StuBatchQuesRelaEN.UpdUserId = objRow[conge_StuBatchQuesRela.UpdUserId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.UpdUserId].ToString().Trim(); //修改用户Id
objge_StuBatchQuesRelaEN.Memo = objRow[conge_StuBatchQuesRela.Memo] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StuBatchQuesRelaEN.IdStuBatchQuesRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StuBatchQuesRelaEN);
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
List<clsge_StuBatchQuesRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsge_StuBatchQuesRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_StuBatchQuesRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsge_StuBatchQuesRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsge_StuBatchQuesRelaEN> arrObjLst = new List<clsge_StuBatchQuesRelaEN>(); 
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
	clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN = new clsge_StuBatchQuesRelaEN();
try
{
objge_StuBatchQuesRelaEN.IdStuBatchQuesRela = Int32.Parse(objRow[conge_StuBatchQuesRela.IdStuBatchQuesRela].ToString().Trim()); //学生批次题目关系流水号
objge_StuBatchQuesRelaEN.ExamBatchNo = objRow[conge_StuBatchQuesRela.ExamBatchNo].ToString().Trim(); //学生批次号
objge_StuBatchQuesRelaEN.LevelNo = objRow[conge_StuBatchQuesRela.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StuBatchQuesRela.LevelNo].ToString().Trim()); //学习关号2
objge_StuBatchQuesRelaEN.QuestionId = Int32.Parse(objRow[conge_StuBatchQuesRela.QuestionId].ToString().Trim()); //题目Id
objge_StuBatchQuesRelaEN.UserId = objRow[conge_StuBatchQuesRela.UserId].ToString().Trim(); //用户ID
objge_StuBatchQuesRelaEN.IdCurrEduCls = objRow[conge_StuBatchQuesRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_StuBatchQuesRelaEN.QuestionIndex4Batch = objRow[conge_StuBatchQuesRela.QuestionIndex4Batch] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StuBatchQuesRela.QuestionIndex4Batch].ToString().Trim()); //题序号4批次
objge_StuBatchQuesRelaEN.GameLevelId = objRow[conge_StuBatchQuesRela.GameLevelId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.GameLevelId].ToString().Trim(); //游戏关卡Id
objge_StuBatchQuesRelaEN.Scores = objRow[conge_StuBatchQuesRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_StuBatchQuesRela.Scores].ToString().Trim()); //分值
objge_StuBatchQuesRelaEN.Score = objRow[conge_StuBatchQuesRela.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_StuBatchQuesRela.Score].ToString().Trim()); //得分
objge_StuBatchQuesRelaEN.StuAnswerText = objRow[conge_StuBatchQuesRela.StuAnswerText] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.StuAnswerText].ToString().Trim(); //学生回答文本
objge_StuBatchQuesRelaEN.AnswerDate = objRow[conge_StuBatchQuesRela.AnswerDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerDate].ToString().Trim(); //回答日期
objge_StuBatchQuesRelaEN.AnswerIP = objRow[conge_StuBatchQuesRela.AnswerIP] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerIP].ToString().Trim(); //回答IP
objge_StuBatchQuesRelaEN.AnswerModeId = objRow[conge_StuBatchQuesRela.AnswerModeId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerModeId].ToString().Trim(); //答案模式Id
objge_StuBatchQuesRelaEN.AnswerMultiOptions = objRow[conge_StuBatchQuesRela.AnswerMultiOptions] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerMultiOptions].ToString().Trim(); //多选项答案
objge_StuBatchQuesRelaEN.AnswerOptionId = objRow[conge_StuBatchQuesRela.AnswerOptionId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerOptionId].ToString().Trim(); //回答选项Id
objge_StuBatchQuesRelaEN.AnswerTime = objRow[conge_StuBatchQuesRela.AnswerTime] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerTime].ToString().Trim(); //回答时间
objge_StuBatchQuesRelaEN.ApplySendBackDate = objRow[conge_StuBatchQuesRela.ApplySendBackDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.ApplySendBackDate].ToString().Trim(); //申请退回日期
objge_StuBatchQuesRelaEN.Comment = objRow[conge_StuBatchQuesRela.Comment] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.Comment].ToString().Trim(); //批注
objge_StuBatchQuesRelaEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objge_StuBatchQuesRelaEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsApplySendBack].ToString().Trim()); //是否申请退回
objge_StuBatchQuesRelaEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objge_StuBatchQuesRelaEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsLook].ToString().Trim()); //是否查看
objge_StuBatchQuesRelaEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsMarking].ToString().Trim()); //是否批阅
objge_StuBatchQuesRelaEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objge_StuBatchQuesRelaEN.IsHasAnswer = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsHasAnswer].ToString().Trim()); //是否有答案
objge_StuBatchQuesRelaEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsPublish].ToString().Trim()); //是否发布
objge_StuBatchQuesRelaEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsRight].ToString().Trim()); //是否正确
objge_StuBatchQuesRelaEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsSave].ToString().Trim()); //是否保存
objge_StuBatchQuesRelaEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsSendBack].ToString().Trim()); //是否退回
objge_StuBatchQuesRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsSubmit].ToString().Trim()); //是否提交
objge_StuBatchQuesRelaEN.MarkDate = objRow[conge_StuBatchQuesRela.MarkDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.MarkDate].ToString().Trim(); //打分日期
objge_StuBatchQuesRelaEN.MarkerId = objRow[conge_StuBatchQuesRela.MarkerId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.MarkerId].ToString().Trim(); //打分者
objge_StuBatchQuesRelaEN.OperateTime = objRow[conge_StuBatchQuesRela.OperateTime] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.OperateTime].ToString().Trim(); //操作时间
objge_StuBatchQuesRelaEN.RealFinishDate = objRow[conge_StuBatchQuesRela.RealFinishDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.RealFinishDate].ToString().Trim(); //实际完成日期
objge_StuBatchQuesRelaEN.WorkTypeId = objRow[conge_StuBatchQuesRela.WorkTypeId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.WorkTypeId].ToString().Trim(); //作业类型Id
objge_StuBatchQuesRelaEN.SchoolYear = objRow[conge_StuBatchQuesRela.SchoolYear] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.SchoolYear].ToString().Trim(); //学年
objge_StuBatchQuesRelaEN.SchoolTerm = objRow[conge_StuBatchQuesRela.SchoolTerm] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.SchoolTerm].ToString().Trim(); //学期
objge_StuBatchQuesRelaEN.ErrMsg = objRow[conge_StuBatchQuesRela.ErrMsg] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.ErrMsg].ToString().Trim(); //错误信息
objge_StuBatchQuesRelaEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsRecommend].ToString().Trim()); //是否推荐
objge_StuBatchQuesRelaEN.CourseId = objRow[conge_StuBatchQuesRela.CourseId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.CourseId].ToString().Trim(); //课程Id
objge_StuBatchQuesRelaEN.UpdDate = objRow[conge_StuBatchQuesRela.UpdDate].ToString().Trim(); //修改日期
objge_StuBatchQuesRelaEN.UpdUserId = objRow[conge_StuBatchQuesRela.UpdUserId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.UpdUserId].ToString().Trim(); //修改用户Id
objge_StuBatchQuesRelaEN.Memo = objRow[conge_StuBatchQuesRela.Memo] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StuBatchQuesRelaEN.IdStuBatchQuesRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StuBatchQuesRelaEN);
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
public static List<clsge_StuBatchQuesRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsge_StuBatchQuesRelaEN> arrObjLst = new List<clsge_StuBatchQuesRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN = new clsge_StuBatchQuesRelaEN();
try
{
objge_StuBatchQuesRelaEN.IdStuBatchQuesRela = Int32.Parse(objRow[conge_StuBatchQuesRela.IdStuBatchQuesRela].ToString().Trim()); //学生批次题目关系流水号
objge_StuBatchQuesRelaEN.ExamBatchNo = objRow[conge_StuBatchQuesRela.ExamBatchNo].ToString().Trim(); //学生批次号
objge_StuBatchQuesRelaEN.LevelNo = objRow[conge_StuBatchQuesRela.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StuBatchQuesRela.LevelNo].ToString().Trim()); //学习关号2
objge_StuBatchQuesRelaEN.QuestionId = Int32.Parse(objRow[conge_StuBatchQuesRela.QuestionId].ToString().Trim()); //题目Id
objge_StuBatchQuesRelaEN.UserId = objRow[conge_StuBatchQuesRela.UserId].ToString().Trim(); //用户ID
objge_StuBatchQuesRelaEN.IdCurrEduCls = objRow[conge_StuBatchQuesRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_StuBatchQuesRelaEN.QuestionIndex4Batch = objRow[conge_StuBatchQuesRela.QuestionIndex4Batch] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StuBatchQuesRela.QuestionIndex4Batch].ToString().Trim()); //题序号4批次
objge_StuBatchQuesRelaEN.GameLevelId = objRow[conge_StuBatchQuesRela.GameLevelId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.GameLevelId].ToString().Trim(); //游戏关卡Id
objge_StuBatchQuesRelaEN.Scores = objRow[conge_StuBatchQuesRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_StuBatchQuesRela.Scores].ToString().Trim()); //分值
objge_StuBatchQuesRelaEN.Score = objRow[conge_StuBatchQuesRela.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_StuBatchQuesRela.Score].ToString().Trim()); //得分
objge_StuBatchQuesRelaEN.StuAnswerText = objRow[conge_StuBatchQuesRela.StuAnswerText] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.StuAnswerText].ToString().Trim(); //学生回答文本
objge_StuBatchQuesRelaEN.AnswerDate = objRow[conge_StuBatchQuesRela.AnswerDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerDate].ToString().Trim(); //回答日期
objge_StuBatchQuesRelaEN.AnswerIP = objRow[conge_StuBatchQuesRela.AnswerIP] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerIP].ToString().Trim(); //回答IP
objge_StuBatchQuesRelaEN.AnswerModeId = objRow[conge_StuBatchQuesRela.AnswerModeId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerModeId].ToString().Trim(); //答案模式Id
objge_StuBatchQuesRelaEN.AnswerMultiOptions = objRow[conge_StuBatchQuesRela.AnswerMultiOptions] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerMultiOptions].ToString().Trim(); //多选项答案
objge_StuBatchQuesRelaEN.AnswerOptionId = objRow[conge_StuBatchQuesRela.AnswerOptionId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerOptionId].ToString().Trim(); //回答选项Id
objge_StuBatchQuesRelaEN.AnswerTime = objRow[conge_StuBatchQuesRela.AnswerTime] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerTime].ToString().Trim(); //回答时间
objge_StuBatchQuesRelaEN.ApplySendBackDate = objRow[conge_StuBatchQuesRela.ApplySendBackDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.ApplySendBackDate].ToString().Trim(); //申请退回日期
objge_StuBatchQuesRelaEN.Comment = objRow[conge_StuBatchQuesRela.Comment] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.Comment].ToString().Trim(); //批注
objge_StuBatchQuesRelaEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objge_StuBatchQuesRelaEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsApplySendBack].ToString().Trim()); //是否申请退回
objge_StuBatchQuesRelaEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objge_StuBatchQuesRelaEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsLook].ToString().Trim()); //是否查看
objge_StuBatchQuesRelaEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsMarking].ToString().Trim()); //是否批阅
objge_StuBatchQuesRelaEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objge_StuBatchQuesRelaEN.IsHasAnswer = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsHasAnswer].ToString().Trim()); //是否有答案
objge_StuBatchQuesRelaEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsPublish].ToString().Trim()); //是否发布
objge_StuBatchQuesRelaEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsRight].ToString().Trim()); //是否正确
objge_StuBatchQuesRelaEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsSave].ToString().Trim()); //是否保存
objge_StuBatchQuesRelaEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsSendBack].ToString().Trim()); //是否退回
objge_StuBatchQuesRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsSubmit].ToString().Trim()); //是否提交
objge_StuBatchQuesRelaEN.MarkDate = objRow[conge_StuBatchQuesRela.MarkDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.MarkDate].ToString().Trim(); //打分日期
objge_StuBatchQuesRelaEN.MarkerId = objRow[conge_StuBatchQuesRela.MarkerId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.MarkerId].ToString().Trim(); //打分者
objge_StuBatchQuesRelaEN.OperateTime = objRow[conge_StuBatchQuesRela.OperateTime] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.OperateTime].ToString().Trim(); //操作时间
objge_StuBatchQuesRelaEN.RealFinishDate = objRow[conge_StuBatchQuesRela.RealFinishDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.RealFinishDate].ToString().Trim(); //实际完成日期
objge_StuBatchQuesRelaEN.WorkTypeId = objRow[conge_StuBatchQuesRela.WorkTypeId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.WorkTypeId].ToString().Trim(); //作业类型Id
objge_StuBatchQuesRelaEN.SchoolYear = objRow[conge_StuBatchQuesRela.SchoolYear] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.SchoolYear].ToString().Trim(); //学年
objge_StuBatchQuesRelaEN.SchoolTerm = objRow[conge_StuBatchQuesRela.SchoolTerm] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.SchoolTerm].ToString().Trim(); //学期
objge_StuBatchQuesRelaEN.ErrMsg = objRow[conge_StuBatchQuesRela.ErrMsg] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.ErrMsg].ToString().Trim(); //错误信息
objge_StuBatchQuesRelaEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsRecommend].ToString().Trim()); //是否推荐
objge_StuBatchQuesRelaEN.CourseId = objRow[conge_StuBatchQuesRela.CourseId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.CourseId].ToString().Trim(); //课程Id
objge_StuBatchQuesRelaEN.UpdDate = objRow[conge_StuBatchQuesRela.UpdDate].ToString().Trim(); //修改日期
objge_StuBatchQuesRelaEN.UpdUserId = objRow[conge_StuBatchQuesRela.UpdUserId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.UpdUserId].ToString().Trim(); //修改用户Id
objge_StuBatchQuesRelaEN.Memo = objRow[conge_StuBatchQuesRela.Memo] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StuBatchQuesRelaEN.IdStuBatchQuesRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StuBatchQuesRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsge_StuBatchQuesRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsge_StuBatchQuesRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsge_StuBatchQuesRelaEN> arrObjLst = new List<clsge_StuBatchQuesRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN = new clsge_StuBatchQuesRelaEN();
try
{
objge_StuBatchQuesRelaEN.IdStuBatchQuesRela = Int32.Parse(objRow[conge_StuBatchQuesRela.IdStuBatchQuesRela].ToString().Trim()); //学生批次题目关系流水号
objge_StuBatchQuesRelaEN.ExamBatchNo = objRow[conge_StuBatchQuesRela.ExamBatchNo].ToString().Trim(); //学生批次号
objge_StuBatchQuesRelaEN.LevelNo = objRow[conge_StuBatchQuesRela.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StuBatchQuesRela.LevelNo].ToString().Trim()); //学习关号2
objge_StuBatchQuesRelaEN.QuestionId = Int32.Parse(objRow[conge_StuBatchQuesRela.QuestionId].ToString().Trim()); //题目Id
objge_StuBatchQuesRelaEN.UserId = objRow[conge_StuBatchQuesRela.UserId].ToString().Trim(); //用户ID
objge_StuBatchQuesRelaEN.IdCurrEduCls = objRow[conge_StuBatchQuesRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_StuBatchQuesRelaEN.QuestionIndex4Batch = objRow[conge_StuBatchQuesRela.QuestionIndex4Batch] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StuBatchQuesRela.QuestionIndex4Batch].ToString().Trim()); //题序号4批次
objge_StuBatchQuesRelaEN.GameLevelId = objRow[conge_StuBatchQuesRela.GameLevelId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.GameLevelId].ToString().Trim(); //游戏关卡Id
objge_StuBatchQuesRelaEN.Scores = objRow[conge_StuBatchQuesRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_StuBatchQuesRela.Scores].ToString().Trim()); //分值
objge_StuBatchQuesRelaEN.Score = objRow[conge_StuBatchQuesRela.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_StuBatchQuesRela.Score].ToString().Trim()); //得分
objge_StuBatchQuesRelaEN.StuAnswerText = objRow[conge_StuBatchQuesRela.StuAnswerText] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.StuAnswerText].ToString().Trim(); //学生回答文本
objge_StuBatchQuesRelaEN.AnswerDate = objRow[conge_StuBatchQuesRela.AnswerDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerDate].ToString().Trim(); //回答日期
objge_StuBatchQuesRelaEN.AnswerIP = objRow[conge_StuBatchQuesRela.AnswerIP] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerIP].ToString().Trim(); //回答IP
objge_StuBatchQuesRelaEN.AnswerModeId = objRow[conge_StuBatchQuesRela.AnswerModeId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerModeId].ToString().Trim(); //答案模式Id
objge_StuBatchQuesRelaEN.AnswerMultiOptions = objRow[conge_StuBatchQuesRela.AnswerMultiOptions] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerMultiOptions].ToString().Trim(); //多选项答案
objge_StuBatchQuesRelaEN.AnswerOptionId = objRow[conge_StuBatchQuesRela.AnswerOptionId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerOptionId].ToString().Trim(); //回答选项Id
objge_StuBatchQuesRelaEN.AnswerTime = objRow[conge_StuBatchQuesRela.AnswerTime] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerTime].ToString().Trim(); //回答时间
objge_StuBatchQuesRelaEN.ApplySendBackDate = objRow[conge_StuBatchQuesRela.ApplySendBackDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.ApplySendBackDate].ToString().Trim(); //申请退回日期
objge_StuBatchQuesRelaEN.Comment = objRow[conge_StuBatchQuesRela.Comment] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.Comment].ToString().Trim(); //批注
objge_StuBatchQuesRelaEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objge_StuBatchQuesRelaEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsApplySendBack].ToString().Trim()); //是否申请退回
objge_StuBatchQuesRelaEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objge_StuBatchQuesRelaEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsLook].ToString().Trim()); //是否查看
objge_StuBatchQuesRelaEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsMarking].ToString().Trim()); //是否批阅
objge_StuBatchQuesRelaEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objge_StuBatchQuesRelaEN.IsHasAnswer = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsHasAnswer].ToString().Trim()); //是否有答案
objge_StuBatchQuesRelaEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsPublish].ToString().Trim()); //是否发布
objge_StuBatchQuesRelaEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsRight].ToString().Trim()); //是否正确
objge_StuBatchQuesRelaEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsSave].ToString().Trim()); //是否保存
objge_StuBatchQuesRelaEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsSendBack].ToString().Trim()); //是否退回
objge_StuBatchQuesRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsSubmit].ToString().Trim()); //是否提交
objge_StuBatchQuesRelaEN.MarkDate = objRow[conge_StuBatchQuesRela.MarkDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.MarkDate].ToString().Trim(); //打分日期
objge_StuBatchQuesRelaEN.MarkerId = objRow[conge_StuBatchQuesRela.MarkerId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.MarkerId].ToString().Trim(); //打分者
objge_StuBatchQuesRelaEN.OperateTime = objRow[conge_StuBatchQuesRela.OperateTime] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.OperateTime].ToString().Trim(); //操作时间
objge_StuBatchQuesRelaEN.RealFinishDate = objRow[conge_StuBatchQuesRela.RealFinishDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.RealFinishDate].ToString().Trim(); //实际完成日期
objge_StuBatchQuesRelaEN.WorkTypeId = objRow[conge_StuBatchQuesRela.WorkTypeId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.WorkTypeId].ToString().Trim(); //作业类型Id
objge_StuBatchQuesRelaEN.SchoolYear = objRow[conge_StuBatchQuesRela.SchoolYear] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.SchoolYear].ToString().Trim(); //学年
objge_StuBatchQuesRelaEN.SchoolTerm = objRow[conge_StuBatchQuesRela.SchoolTerm] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.SchoolTerm].ToString().Trim(); //学期
objge_StuBatchQuesRelaEN.ErrMsg = objRow[conge_StuBatchQuesRela.ErrMsg] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.ErrMsg].ToString().Trim(); //错误信息
objge_StuBatchQuesRelaEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsRecommend].ToString().Trim()); //是否推荐
objge_StuBatchQuesRelaEN.CourseId = objRow[conge_StuBatchQuesRela.CourseId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.CourseId].ToString().Trim(); //课程Id
objge_StuBatchQuesRelaEN.UpdDate = objRow[conge_StuBatchQuesRela.UpdDate].ToString().Trim(); //修改日期
objge_StuBatchQuesRelaEN.UpdUserId = objRow[conge_StuBatchQuesRela.UpdUserId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.UpdUserId].ToString().Trim(); //修改用户Id
objge_StuBatchQuesRelaEN.Memo = objRow[conge_StuBatchQuesRela.Memo] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StuBatchQuesRelaEN.IdStuBatchQuesRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StuBatchQuesRelaEN);
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
public static List<clsge_StuBatchQuesRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsge_StuBatchQuesRelaEN> arrObjLst = new List<clsge_StuBatchQuesRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN = new clsge_StuBatchQuesRelaEN();
try
{
objge_StuBatchQuesRelaEN.IdStuBatchQuesRela = Int32.Parse(objRow[conge_StuBatchQuesRela.IdStuBatchQuesRela].ToString().Trim()); //学生批次题目关系流水号
objge_StuBatchQuesRelaEN.ExamBatchNo = objRow[conge_StuBatchQuesRela.ExamBatchNo].ToString().Trim(); //学生批次号
objge_StuBatchQuesRelaEN.LevelNo = objRow[conge_StuBatchQuesRela.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StuBatchQuesRela.LevelNo].ToString().Trim()); //学习关号2
objge_StuBatchQuesRelaEN.QuestionId = Int32.Parse(objRow[conge_StuBatchQuesRela.QuestionId].ToString().Trim()); //题目Id
objge_StuBatchQuesRelaEN.UserId = objRow[conge_StuBatchQuesRela.UserId].ToString().Trim(); //用户ID
objge_StuBatchQuesRelaEN.IdCurrEduCls = objRow[conge_StuBatchQuesRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_StuBatchQuesRelaEN.QuestionIndex4Batch = objRow[conge_StuBatchQuesRela.QuestionIndex4Batch] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StuBatchQuesRela.QuestionIndex4Batch].ToString().Trim()); //题序号4批次
objge_StuBatchQuesRelaEN.GameLevelId = objRow[conge_StuBatchQuesRela.GameLevelId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.GameLevelId].ToString().Trim(); //游戏关卡Id
objge_StuBatchQuesRelaEN.Scores = objRow[conge_StuBatchQuesRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_StuBatchQuesRela.Scores].ToString().Trim()); //分值
objge_StuBatchQuesRelaEN.Score = objRow[conge_StuBatchQuesRela.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_StuBatchQuesRela.Score].ToString().Trim()); //得分
objge_StuBatchQuesRelaEN.StuAnswerText = objRow[conge_StuBatchQuesRela.StuAnswerText] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.StuAnswerText].ToString().Trim(); //学生回答文本
objge_StuBatchQuesRelaEN.AnswerDate = objRow[conge_StuBatchQuesRela.AnswerDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerDate].ToString().Trim(); //回答日期
objge_StuBatchQuesRelaEN.AnswerIP = objRow[conge_StuBatchQuesRela.AnswerIP] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerIP].ToString().Trim(); //回答IP
objge_StuBatchQuesRelaEN.AnswerModeId = objRow[conge_StuBatchQuesRela.AnswerModeId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerModeId].ToString().Trim(); //答案模式Id
objge_StuBatchQuesRelaEN.AnswerMultiOptions = objRow[conge_StuBatchQuesRela.AnswerMultiOptions] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerMultiOptions].ToString().Trim(); //多选项答案
objge_StuBatchQuesRelaEN.AnswerOptionId = objRow[conge_StuBatchQuesRela.AnswerOptionId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerOptionId].ToString().Trim(); //回答选项Id
objge_StuBatchQuesRelaEN.AnswerTime = objRow[conge_StuBatchQuesRela.AnswerTime] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerTime].ToString().Trim(); //回答时间
objge_StuBatchQuesRelaEN.ApplySendBackDate = objRow[conge_StuBatchQuesRela.ApplySendBackDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.ApplySendBackDate].ToString().Trim(); //申请退回日期
objge_StuBatchQuesRelaEN.Comment = objRow[conge_StuBatchQuesRela.Comment] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.Comment].ToString().Trim(); //批注
objge_StuBatchQuesRelaEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objge_StuBatchQuesRelaEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsApplySendBack].ToString().Trim()); //是否申请退回
objge_StuBatchQuesRelaEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objge_StuBatchQuesRelaEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsLook].ToString().Trim()); //是否查看
objge_StuBatchQuesRelaEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsMarking].ToString().Trim()); //是否批阅
objge_StuBatchQuesRelaEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objge_StuBatchQuesRelaEN.IsHasAnswer = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsHasAnswer].ToString().Trim()); //是否有答案
objge_StuBatchQuesRelaEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsPublish].ToString().Trim()); //是否发布
objge_StuBatchQuesRelaEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsRight].ToString().Trim()); //是否正确
objge_StuBatchQuesRelaEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsSave].ToString().Trim()); //是否保存
objge_StuBatchQuesRelaEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsSendBack].ToString().Trim()); //是否退回
objge_StuBatchQuesRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsSubmit].ToString().Trim()); //是否提交
objge_StuBatchQuesRelaEN.MarkDate = objRow[conge_StuBatchQuesRela.MarkDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.MarkDate].ToString().Trim(); //打分日期
objge_StuBatchQuesRelaEN.MarkerId = objRow[conge_StuBatchQuesRela.MarkerId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.MarkerId].ToString().Trim(); //打分者
objge_StuBatchQuesRelaEN.OperateTime = objRow[conge_StuBatchQuesRela.OperateTime] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.OperateTime].ToString().Trim(); //操作时间
objge_StuBatchQuesRelaEN.RealFinishDate = objRow[conge_StuBatchQuesRela.RealFinishDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.RealFinishDate].ToString().Trim(); //实际完成日期
objge_StuBatchQuesRelaEN.WorkTypeId = objRow[conge_StuBatchQuesRela.WorkTypeId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.WorkTypeId].ToString().Trim(); //作业类型Id
objge_StuBatchQuesRelaEN.SchoolYear = objRow[conge_StuBatchQuesRela.SchoolYear] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.SchoolYear].ToString().Trim(); //学年
objge_StuBatchQuesRelaEN.SchoolTerm = objRow[conge_StuBatchQuesRela.SchoolTerm] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.SchoolTerm].ToString().Trim(); //学期
objge_StuBatchQuesRelaEN.ErrMsg = objRow[conge_StuBatchQuesRela.ErrMsg] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.ErrMsg].ToString().Trim(); //错误信息
objge_StuBatchQuesRelaEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsRecommend].ToString().Trim()); //是否推荐
objge_StuBatchQuesRelaEN.CourseId = objRow[conge_StuBatchQuesRela.CourseId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.CourseId].ToString().Trim(); //课程Id
objge_StuBatchQuesRelaEN.UpdDate = objRow[conge_StuBatchQuesRela.UpdDate].ToString().Trim(); //修改日期
objge_StuBatchQuesRelaEN.UpdUserId = objRow[conge_StuBatchQuesRela.UpdUserId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.UpdUserId].ToString().Trim(); //修改用户Id
objge_StuBatchQuesRelaEN.Memo = objRow[conge_StuBatchQuesRela.Memo] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StuBatchQuesRelaEN.IdStuBatchQuesRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StuBatchQuesRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_StuBatchQuesRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsge_StuBatchQuesRelaEN> arrObjLst = new List<clsge_StuBatchQuesRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN = new clsge_StuBatchQuesRelaEN();
try
{
objge_StuBatchQuesRelaEN.IdStuBatchQuesRela = Int32.Parse(objRow[conge_StuBatchQuesRela.IdStuBatchQuesRela].ToString().Trim()); //学生批次题目关系流水号
objge_StuBatchQuesRelaEN.ExamBatchNo = objRow[conge_StuBatchQuesRela.ExamBatchNo].ToString().Trim(); //学生批次号
objge_StuBatchQuesRelaEN.LevelNo = objRow[conge_StuBatchQuesRela.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StuBatchQuesRela.LevelNo].ToString().Trim()); //学习关号2
objge_StuBatchQuesRelaEN.QuestionId = Int32.Parse(objRow[conge_StuBatchQuesRela.QuestionId].ToString().Trim()); //题目Id
objge_StuBatchQuesRelaEN.UserId = objRow[conge_StuBatchQuesRela.UserId].ToString().Trim(); //用户ID
objge_StuBatchQuesRelaEN.IdCurrEduCls = objRow[conge_StuBatchQuesRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_StuBatchQuesRelaEN.QuestionIndex4Batch = objRow[conge_StuBatchQuesRela.QuestionIndex4Batch] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StuBatchQuesRela.QuestionIndex4Batch].ToString().Trim()); //题序号4批次
objge_StuBatchQuesRelaEN.GameLevelId = objRow[conge_StuBatchQuesRela.GameLevelId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.GameLevelId].ToString().Trim(); //游戏关卡Id
objge_StuBatchQuesRelaEN.Scores = objRow[conge_StuBatchQuesRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_StuBatchQuesRela.Scores].ToString().Trim()); //分值
objge_StuBatchQuesRelaEN.Score = objRow[conge_StuBatchQuesRela.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_StuBatchQuesRela.Score].ToString().Trim()); //得分
objge_StuBatchQuesRelaEN.StuAnswerText = objRow[conge_StuBatchQuesRela.StuAnswerText] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.StuAnswerText].ToString().Trim(); //学生回答文本
objge_StuBatchQuesRelaEN.AnswerDate = objRow[conge_StuBatchQuesRela.AnswerDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerDate].ToString().Trim(); //回答日期
objge_StuBatchQuesRelaEN.AnswerIP = objRow[conge_StuBatchQuesRela.AnswerIP] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerIP].ToString().Trim(); //回答IP
objge_StuBatchQuesRelaEN.AnswerModeId = objRow[conge_StuBatchQuesRela.AnswerModeId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerModeId].ToString().Trim(); //答案模式Id
objge_StuBatchQuesRelaEN.AnswerMultiOptions = objRow[conge_StuBatchQuesRela.AnswerMultiOptions] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerMultiOptions].ToString().Trim(); //多选项答案
objge_StuBatchQuesRelaEN.AnswerOptionId = objRow[conge_StuBatchQuesRela.AnswerOptionId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerOptionId].ToString().Trim(); //回答选项Id
objge_StuBatchQuesRelaEN.AnswerTime = objRow[conge_StuBatchQuesRela.AnswerTime] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.AnswerTime].ToString().Trim(); //回答时间
objge_StuBatchQuesRelaEN.ApplySendBackDate = objRow[conge_StuBatchQuesRela.ApplySendBackDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.ApplySendBackDate].ToString().Trim(); //申请退回日期
objge_StuBatchQuesRelaEN.Comment = objRow[conge_StuBatchQuesRela.Comment] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.Comment].ToString().Trim(); //批注
objge_StuBatchQuesRelaEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objge_StuBatchQuesRelaEN.IsApplySendBack = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsApplySendBack].ToString().Trim()); //是否申请退回
objge_StuBatchQuesRelaEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objge_StuBatchQuesRelaEN.IsLook = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsLook].ToString().Trim()); //是否查看
objge_StuBatchQuesRelaEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsMarking].ToString().Trim()); //是否批阅
objge_StuBatchQuesRelaEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objge_StuBatchQuesRelaEN.IsHasAnswer = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsHasAnswer].ToString().Trim()); //是否有答案
objge_StuBatchQuesRelaEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsPublish].ToString().Trim()); //是否发布
objge_StuBatchQuesRelaEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsRight].ToString().Trim()); //是否正确
objge_StuBatchQuesRelaEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsSave].ToString().Trim()); //是否保存
objge_StuBatchQuesRelaEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsSendBack].ToString().Trim()); //是否退回
objge_StuBatchQuesRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsSubmit].ToString().Trim()); //是否提交
objge_StuBatchQuesRelaEN.MarkDate = objRow[conge_StuBatchQuesRela.MarkDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.MarkDate].ToString().Trim(); //打分日期
objge_StuBatchQuesRelaEN.MarkerId = objRow[conge_StuBatchQuesRela.MarkerId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.MarkerId].ToString().Trim(); //打分者
objge_StuBatchQuesRelaEN.OperateTime = objRow[conge_StuBatchQuesRela.OperateTime] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.OperateTime].ToString().Trim(); //操作时间
objge_StuBatchQuesRelaEN.RealFinishDate = objRow[conge_StuBatchQuesRela.RealFinishDate] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.RealFinishDate].ToString().Trim(); //实际完成日期
objge_StuBatchQuesRelaEN.WorkTypeId = objRow[conge_StuBatchQuesRela.WorkTypeId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.WorkTypeId].ToString().Trim(); //作业类型Id
objge_StuBatchQuesRelaEN.SchoolYear = objRow[conge_StuBatchQuesRela.SchoolYear] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.SchoolYear].ToString().Trim(); //学年
objge_StuBatchQuesRelaEN.SchoolTerm = objRow[conge_StuBatchQuesRela.SchoolTerm] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.SchoolTerm].ToString().Trim(); //学期
objge_StuBatchQuesRelaEN.ErrMsg = objRow[conge_StuBatchQuesRela.ErrMsg] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.ErrMsg].ToString().Trim(); //错误信息
objge_StuBatchQuesRelaEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conge_StuBatchQuesRela.IsRecommend].ToString().Trim()); //是否推荐
objge_StuBatchQuesRelaEN.CourseId = objRow[conge_StuBatchQuesRela.CourseId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.CourseId].ToString().Trim(); //课程Id
objge_StuBatchQuesRelaEN.UpdDate = objRow[conge_StuBatchQuesRela.UpdDate].ToString().Trim(); //修改日期
objge_StuBatchQuesRelaEN.UpdUserId = objRow[conge_StuBatchQuesRela.UpdUserId] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.UpdUserId].ToString().Trim(); //修改用户Id
objge_StuBatchQuesRelaEN.Memo = objRow[conge_StuBatchQuesRela.Memo] == DBNull.Value ? null : objRow[conge_StuBatchQuesRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StuBatchQuesRelaEN.IdStuBatchQuesRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StuBatchQuesRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getge_StuBatchQuesRela(ref clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN)
{
bool bolResult = ge_StuBatchQuesRelaDA.Getge_StuBatchQuesRela(ref objge_StuBatchQuesRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdStuBatchQuesRela">表关键字</param>
 /// <returns>表对象</returns>
public static clsge_StuBatchQuesRelaEN GetObjByIdStuBatchQuesRela(long lngIdStuBatchQuesRela)
{
clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN = ge_StuBatchQuesRelaDA.GetObjByIdStuBatchQuesRela(lngIdStuBatchQuesRela);
return objge_StuBatchQuesRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsge_StuBatchQuesRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN = ge_StuBatchQuesRelaDA.GetFirstObj(strWhereCond);
 return objge_StuBatchQuesRelaEN;
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
public static clsge_StuBatchQuesRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN = ge_StuBatchQuesRelaDA.GetObjByDataRow(objRow);
 return objge_StuBatchQuesRelaEN;
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
public static clsge_StuBatchQuesRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN = ge_StuBatchQuesRelaDA.GetObjByDataRow(objRow);
 return objge_StuBatchQuesRelaEN;
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
 /// <param name = "lngIdStuBatchQuesRela">所给的关键字</param>
 /// <param name = "lstge_StuBatchQuesRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsge_StuBatchQuesRelaEN GetObjByIdStuBatchQuesRelaFromList(long lngIdStuBatchQuesRela, List<clsge_StuBatchQuesRelaEN> lstge_StuBatchQuesRelaObjLst)
{
foreach (clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN in lstge_StuBatchQuesRelaObjLst)
{
if (objge_StuBatchQuesRelaEN.IdStuBatchQuesRela == lngIdStuBatchQuesRela)
{
return objge_StuBatchQuesRelaEN;
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
 long lngIdStuBatchQuesRela;
 try
 {
 lngIdStuBatchQuesRela = new clsge_StuBatchQuesRelaDA().GetFirstID(strWhereCond);
 return lngIdStuBatchQuesRela;
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
 arrList = ge_StuBatchQuesRelaDA.GetID(strWhereCond);
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
bool bolIsExist = ge_StuBatchQuesRelaDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdStuBatchQuesRela">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdStuBatchQuesRela)
{
//检测记录是否存在
bool bolIsExist = ge_StuBatchQuesRelaDA.IsExist(lngIdStuBatchQuesRela);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngIdStuBatchQuesRela">学生批次题目关系流水号</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngIdStuBatchQuesRela, string strOpUser)
{
clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN = clsge_StuBatchQuesRelaBL.GetObjByIdStuBatchQuesRela(lngIdStuBatchQuesRela);
objge_StuBatchQuesRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objge_StuBatchQuesRelaEN.UpdUserId = strOpUser;
return clsge_StuBatchQuesRelaBL.UpdateBySql2(objge_StuBatchQuesRelaEN);
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
 bolIsExist = clsge_StuBatchQuesRelaDA.IsExistTable();
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
 bolIsExist = ge_StuBatchQuesRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objge_StuBatchQuesRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objge_StuBatchQuesRelaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!学生批次号 = [{0}],用户ID = [{1}],题目Id = [{2}]的数据已经存在!(in clsge_StuBatchQuesRelaBL.AddNewRecordBySql2)", objge_StuBatchQuesRelaEN.ExamBatchNo,objge_StuBatchQuesRelaEN.UserId,objge_StuBatchQuesRelaEN.QuestionId);
throw new Exception(strMsg);
}
try
{
bool bolResult = ge_StuBatchQuesRelaDA.AddNewRecordBySQL2(objge_StuBatchQuesRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StuBatchQuesRelaBL.ReFreshCache(objge_StuBatchQuesRelaEN.IdCurrEduCls);

if (clsge_StuBatchQuesRelaBL.relatedActions != null)
{
clsge_StuBatchQuesRelaBL.relatedActions.UpdRelaTabDate(objge_StuBatchQuesRelaEN.IdStuBatchQuesRela, objge_StuBatchQuesRelaEN.UpdUserId);
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
 /// <param name = "objge_StuBatchQuesRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objge_StuBatchQuesRelaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!学生批次号 = [{0}],用户ID = [{1}],题目Id = [{2}]的数据已经存在!(in clsge_StuBatchQuesRelaBL.AddNewRecordBySql2WithReturnKey)", objge_StuBatchQuesRelaEN.ExamBatchNo,objge_StuBatchQuesRelaEN.UserId,objge_StuBatchQuesRelaEN.QuestionId);
throw new Exception(strMsg);
}
try
{
string strKey = ge_StuBatchQuesRelaDA.AddNewRecordBySQL2WithReturnKey(objge_StuBatchQuesRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StuBatchQuesRelaBL.ReFreshCache(objge_StuBatchQuesRelaEN.IdCurrEduCls);

if (clsge_StuBatchQuesRelaBL.relatedActions != null)
{
clsge_StuBatchQuesRelaBL.relatedActions.UpdRelaTabDate(objge_StuBatchQuesRelaEN.IdStuBatchQuesRela, objge_StuBatchQuesRelaEN.UpdUserId);
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
 /// <param name = "objge_StuBatchQuesRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN)
{
try
{
bool bolResult = ge_StuBatchQuesRelaDA.Update(objge_StuBatchQuesRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StuBatchQuesRelaBL.ReFreshCache(objge_StuBatchQuesRelaEN.IdCurrEduCls);

if (clsge_StuBatchQuesRelaBL.relatedActions != null)
{
clsge_StuBatchQuesRelaBL.relatedActions.UpdRelaTabDate(objge_StuBatchQuesRelaEN.IdStuBatchQuesRela, objge_StuBatchQuesRelaEN.UpdUserId);
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
 /// <param name = "objge_StuBatchQuesRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN)
{
 if (objge_StuBatchQuesRelaEN.IdStuBatchQuesRela == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ge_StuBatchQuesRelaDA.UpdateBySql2(objge_StuBatchQuesRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StuBatchQuesRelaBL.ReFreshCache(objge_StuBatchQuesRelaEN.IdCurrEduCls);

if (clsge_StuBatchQuesRelaBL.relatedActions != null)
{
clsge_StuBatchQuesRelaBL.relatedActions.UpdRelaTabDate(objge_StuBatchQuesRelaEN.IdStuBatchQuesRela, objge_StuBatchQuesRelaEN.UpdUserId);
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
 /// <param name = "lngIdStuBatchQuesRela">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngIdStuBatchQuesRela)
{
try
{
 clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN = clsge_StuBatchQuesRelaBL.GetObjByIdStuBatchQuesRela(lngIdStuBatchQuesRela);

if (clsge_StuBatchQuesRelaBL.relatedActions != null)
{
clsge_StuBatchQuesRelaBL.relatedActions.UpdRelaTabDate(objge_StuBatchQuesRelaEN.IdStuBatchQuesRela, objge_StuBatchQuesRelaEN.UpdUserId);
}
if (objge_StuBatchQuesRelaEN != null)
{
int intRecNum = ge_StuBatchQuesRelaDA.DelRecord(lngIdStuBatchQuesRela);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objge_StuBatchQuesRelaEN.IdCurrEduCls);
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
/// <param name="lngIdStuBatchQuesRela">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(long lngIdStuBatchQuesRela , string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsge_StuBatchQuesRelaDA.GetSpecSQLObj();
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
//删除与表:[ge_StuBatchQuesRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conge_StuBatchQuesRela.IdStuBatchQuesRela,
//lngIdStuBatchQuesRela);
//        clsge_StuBatchQuesRelaBL.Delge_StuBatchQuesRelasByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsge_StuBatchQuesRelaBL.DelRecord(lngIdStuBatchQuesRela, strIdCurrEduCls, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsge_StuBatchQuesRelaBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngIdStuBatchQuesRela, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngIdStuBatchQuesRela">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngIdStuBatchQuesRela, string strIdCurrEduCls, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsge_StuBatchQuesRelaBL.relatedActions != null)
{
clsge_StuBatchQuesRelaBL.relatedActions.UpdRelaTabDate(lngIdStuBatchQuesRela, "UpdRelaTabDate");
}
bool bolResult = ge_StuBatchQuesRelaDA.DelRecord(lngIdStuBatchQuesRela,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdStuBatchQuesRelaLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delge_StuBatchQuesRelas(List<string> arrIdStuBatchQuesRelaLst)
{
if (arrIdStuBatchQuesRelaLst.Count == 0) return 0;
try
{
if (clsge_StuBatchQuesRelaBL.relatedActions != null)
{
foreach (var strIdStuBatchQuesRela in arrIdStuBatchQuesRelaLst)
{
long lngIdStuBatchQuesRela = long.Parse(strIdStuBatchQuesRela);
clsge_StuBatchQuesRelaBL.relatedActions.UpdRelaTabDate(lngIdStuBatchQuesRela, "UpdRelaTabDate");
}
}
 clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN = clsge_StuBatchQuesRelaBL.GetObjByIdStuBatchQuesRela(long.Parse(arrIdStuBatchQuesRelaLst[0]));
int intDelRecNum = ge_StuBatchQuesRelaDA.Delge_StuBatchQuesRela(arrIdStuBatchQuesRelaLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objge_StuBatchQuesRelaEN.IdCurrEduCls);
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
public static int Delge_StuBatchQuesRelasByCond(string strWhereCond)
{
try
{
if (clsge_StuBatchQuesRelaBL.relatedActions != null)
{
List<string> arrIdStuBatchQuesRela = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdStuBatchQuesRela in arrIdStuBatchQuesRela)
{
long lngIdStuBatchQuesRela = long.Parse(strIdStuBatchQuesRela);
clsge_StuBatchQuesRelaBL.relatedActions.UpdRelaTabDate(lngIdStuBatchQuesRela, "UpdRelaTabDate");
}
}
List<string> arrIdCurrEduCls = GetFldValue(conge_StuBatchQuesRela.IdCurrEduCls, strWhereCond);
int intRecNum = ge_StuBatchQuesRelaDA.Delge_StuBatchQuesRela(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[ge_StuBatchQuesRela]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngIdStuBatchQuesRela">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngIdStuBatchQuesRela, string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsge_StuBatchQuesRelaDA.GetSpecSQLObj();
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
//删除与表:[ge_StuBatchQuesRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsge_StuBatchQuesRelaBL.DelRecord(lngIdStuBatchQuesRela, strIdCurrEduCls, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsge_StuBatchQuesRelaBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngIdStuBatchQuesRela, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objge_StuBatchQuesRelaENS">源对象</param>
 /// <param name = "objge_StuBatchQuesRelaENT">目标对象</param>
 public static void CopyTo(clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaENS, clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaENT)
{
try
{
objge_StuBatchQuesRelaENT.IdStuBatchQuesRela = objge_StuBatchQuesRelaENS.IdStuBatchQuesRela; //学生批次题目关系流水号
objge_StuBatchQuesRelaENT.ExamBatchNo = objge_StuBatchQuesRelaENS.ExamBatchNo; //学生批次号
objge_StuBatchQuesRelaENT.LevelNo = objge_StuBatchQuesRelaENS.LevelNo; //学习关号2
objge_StuBatchQuesRelaENT.QuestionId = objge_StuBatchQuesRelaENS.QuestionId; //题目Id
objge_StuBatchQuesRelaENT.UserId = objge_StuBatchQuesRelaENS.UserId; //用户ID
objge_StuBatchQuesRelaENT.IdCurrEduCls = objge_StuBatchQuesRelaENS.IdCurrEduCls; //教学班流水号
objge_StuBatchQuesRelaENT.QuestionIndex4Batch = objge_StuBatchQuesRelaENS.QuestionIndex4Batch; //题序号4批次
objge_StuBatchQuesRelaENT.GameLevelId = objge_StuBatchQuesRelaENS.GameLevelId; //游戏关卡Id
objge_StuBatchQuesRelaENT.Scores = objge_StuBatchQuesRelaENS.Scores; //分值
objge_StuBatchQuesRelaENT.Score = objge_StuBatchQuesRelaENS.Score; //得分
objge_StuBatchQuesRelaENT.StuAnswerText = objge_StuBatchQuesRelaENS.StuAnswerText; //学生回答文本
objge_StuBatchQuesRelaENT.AnswerDate = objge_StuBatchQuesRelaENS.AnswerDate; //回答日期
objge_StuBatchQuesRelaENT.AnswerIP = objge_StuBatchQuesRelaENS.AnswerIP; //回答IP
objge_StuBatchQuesRelaENT.AnswerModeId = objge_StuBatchQuesRelaENS.AnswerModeId; //答案模式Id
objge_StuBatchQuesRelaENT.AnswerMultiOptions = objge_StuBatchQuesRelaENS.AnswerMultiOptions; //多选项答案
objge_StuBatchQuesRelaENT.AnswerOptionId = objge_StuBatchQuesRelaENS.AnswerOptionId; //回答选项Id
objge_StuBatchQuesRelaENT.AnswerTime = objge_StuBatchQuesRelaENS.AnswerTime; //回答时间
objge_StuBatchQuesRelaENT.ApplySendBackDate = objge_StuBatchQuesRelaENS.ApplySendBackDate; //申请退回日期
objge_StuBatchQuesRelaENT.Comment = objge_StuBatchQuesRelaENS.Comment; //批注
objge_StuBatchQuesRelaENT.IsAccessKnowledge = objge_StuBatchQuesRelaENS.IsAccessKnowledge; //是否处理知识点
objge_StuBatchQuesRelaENT.IsApplySendBack = objge_StuBatchQuesRelaENS.IsApplySendBack; //是否申请退回
objge_StuBatchQuesRelaENT.IsInErrorQuestion = objge_StuBatchQuesRelaENS.IsInErrorQuestion; //是否进入错题
objge_StuBatchQuesRelaENT.IsLook = objge_StuBatchQuesRelaENS.IsLook; //是否查看
objge_StuBatchQuesRelaENT.IsMarking = objge_StuBatchQuesRelaENS.IsMarking; //是否批阅
objge_StuBatchQuesRelaENT.IsNotProcessTimeout = objge_StuBatchQuesRelaENS.IsNotProcessTimeout; //是否不处理超时
objge_StuBatchQuesRelaENT.IsHasAnswer = objge_StuBatchQuesRelaENS.IsHasAnswer; //是否有答案
objge_StuBatchQuesRelaENT.IsPublish = objge_StuBatchQuesRelaENS.IsPublish; //是否发布
objge_StuBatchQuesRelaENT.IsRight = objge_StuBatchQuesRelaENS.IsRight; //是否正确
objge_StuBatchQuesRelaENT.IsSave = objge_StuBatchQuesRelaENS.IsSave; //是否保存
objge_StuBatchQuesRelaENT.IsSendBack = objge_StuBatchQuesRelaENS.IsSendBack; //是否退回
objge_StuBatchQuesRelaENT.IsSubmit = objge_StuBatchQuesRelaENS.IsSubmit; //是否提交
objge_StuBatchQuesRelaENT.MarkDate = objge_StuBatchQuesRelaENS.MarkDate; //打分日期
objge_StuBatchQuesRelaENT.MarkerId = objge_StuBatchQuesRelaENS.MarkerId; //打分者
objge_StuBatchQuesRelaENT.OperateTime = objge_StuBatchQuesRelaENS.OperateTime; //操作时间
objge_StuBatchQuesRelaENT.RealFinishDate = objge_StuBatchQuesRelaENS.RealFinishDate; //实际完成日期
objge_StuBatchQuesRelaENT.WorkTypeId = objge_StuBatchQuesRelaENS.WorkTypeId; //作业类型Id
objge_StuBatchQuesRelaENT.SchoolYear = objge_StuBatchQuesRelaENS.SchoolYear; //学年
objge_StuBatchQuesRelaENT.SchoolTerm = objge_StuBatchQuesRelaENS.SchoolTerm; //学期
objge_StuBatchQuesRelaENT.ErrMsg = objge_StuBatchQuesRelaENS.ErrMsg; //错误信息
objge_StuBatchQuesRelaENT.IsRecommend = objge_StuBatchQuesRelaENS.IsRecommend; //是否推荐
objge_StuBatchQuesRelaENT.CourseId = objge_StuBatchQuesRelaENS.CourseId; //课程Id
objge_StuBatchQuesRelaENT.UpdDate = objge_StuBatchQuesRelaENS.UpdDate; //修改日期
objge_StuBatchQuesRelaENT.UpdUserId = objge_StuBatchQuesRelaENS.UpdUserId; //修改用户Id
objge_StuBatchQuesRelaENT.Memo = objge_StuBatchQuesRelaENS.Memo; //备注
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
 /// <param name = "objge_StuBatchQuesRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN)
{
try
{
objge_StuBatchQuesRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objge_StuBatchQuesRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conge_StuBatchQuesRela.IdStuBatchQuesRela, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuBatchQuesRelaEN.IdStuBatchQuesRela = objge_StuBatchQuesRelaEN.IdStuBatchQuesRela; //学生批次题目关系流水号
}
if (arrFldSet.Contains(conge_StuBatchQuesRela.ExamBatchNo, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuBatchQuesRelaEN.ExamBatchNo = objge_StuBatchQuesRelaEN.ExamBatchNo; //学生批次号
}
if (arrFldSet.Contains(conge_StuBatchQuesRela.LevelNo, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuBatchQuesRelaEN.LevelNo = objge_StuBatchQuesRelaEN.LevelNo; //学习关号2
}
if (arrFldSet.Contains(conge_StuBatchQuesRela.QuestionId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuBatchQuesRelaEN.QuestionId = objge_StuBatchQuesRelaEN.QuestionId; //题目Id
}
if (arrFldSet.Contains(conge_StuBatchQuesRela.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuBatchQuesRelaEN.UserId = objge_StuBatchQuesRelaEN.UserId; //用户ID
}
if (arrFldSet.Contains(conge_StuBatchQuesRela.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuBatchQuesRelaEN.IdCurrEduCls = objge_StuBatchQuesRelaEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conge_StuBatchQuesRela.QuestionIndex4Batch, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuBatchQuesRelaEN.QuestionIndex4Batch = objge_StuBatchQuesRelaEN.QuestionIndex4Batch; //题序号4批次
}
if (arrFldSet.Contains(conge_StuBatchQuesRela.GameLevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuBatchQuesRelaEN.GameLevelId = objge_StuBatchQuesRelaEN.GameLevelId == "[null]" ? null :  objge_StuBatchQuesRelaEN.GameLevelId; //游戏关卡Id
}
if (arrFldSet.Contains(conge_StuBatchQuesRela.Scores, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuBatchQuesRelaEN.Scores = objge_StuBatchQuesRelaEN.Scores; //分值
}
if (arrFldSet.Contains(conge_StuBatchQuesRela.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuBatchQuesRelaEN.Score = objge_StuBatchQuesRelaEN.Score; //得分
}
if (arrFldSet.Contains(conge_StuBatchQuesRela.StuAnswerText, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuBatchQuesRelaEN.StuAnswerText = objge_StuBatchQuesRelaEN.StuAnswerText == "[null]" ? null :  objge_StuBatchQuesRelaEN.StuAnswerText; //学生回答文本
}
if (arrFldSet.Contains(conge_StuBatchQuesRela.AnswerDate, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuBatchQuesRelaEN.AnswerDate = objge_StuBatchQuesRelaEN.AnswerDate == "[null]" ? null :  objge_StuBatchQuesRelaEN.AnswerDate; //回答日期
}
if (arrFldSet.Contains(conge_StuBatchQuesRela.AnswerIP, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuBatchQuesRelaEN.AnswerIP = objge_StuBatchQuesRelaEN.AnswerIP == "[null]" ? null :  objge_StuBatchQuesRelaEN.AnswerIP; //回答IP
}
if (arrFldSet.Contains(conge_StuBatchQuesRela.AnswerModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuBatchQuesRelaEN.AnswerModeId = objge_StuBatchQuesRelaEN.AnswerModeId == "[null]" ? null :  objge_StuBatchQuesRelaEN.AnswerModeId; //答案模式Id
}
if (arrFldSet.Contains(conge_StuBatchQuesRela.AnswerMultiOptions, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuBatchQuesRelaEN.AnswerMultiOptions = objge_StuBatchQuesRelaEN.AnswerMultiOptions == "[null]" ? null :  objge_StuBatchQuesRelaEN.AnswerMultiOptions; //多选项答案
}
if (arrFldSet.Contains(conge_StuBatchQuesRela.AnswerOptionId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuBatchQuesRelaEN.AnswerOptionId = objge_StuBatchQuesRelaEN.AnswerOptionId == "[null]" ? null :  objge_StuBatchQuesRelaEN.AnswerOptionId; //回答选项Id
}
if (arrFldSet.Contains(conge_StuBatchQuesRela.AnswerTime, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuBatchQuesRelaEN.AnswerTime = objge_StuBatchQuesRelaEN.AnswerTime == "[null]" ? null :  objge_StuBatchQuesRelaEN.AnswerTime; //回答时间
}
if (arrFldSet.Contains(conge_StuBatchQuesRela.ApplySendBackDate, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuBatchQuesRelaEN.ApplySendBackDate = objge_StuBatchQuesRelaEN.ApplySendBackDate == "[null]" ? null :  objge_StuBatchQuesRelaEN.ApplySendBackDate; //申请退回日期
}
if (arrFldSet.Contains(conge_StuBatchQuesRela.Comment, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuBatchQuesRelaEN.Comment = objge_StuBatchQuesRelaEN.Comment == "[null]" ? null :  objge_StuBatchQuesRelaEN.Comment; //批注
}
if (arrFldSet.Contains(conge_StuBatchQuesRela.IsAccessKnowledge, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuBatchQuesRelaEN.IsAccessKnowledge = objge_StuBatchQuesRelaEN.IsAccessKnowledge; //是否处理知识点
}
if (arrFldSet.Contains(conge_StuBatchQuesRela.IsApplySendBack, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuBatchQuesRelaEN.IsApplySendBack = objge_StuBatchQuesRelaEN.IsApplySendBack; //是否申请退回
}
if (arrFldSet.Contains(conge_StuBatchQuesRela.IsInErrorQuestion, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuBatchQuesRelaEN.IsInErrorQuestion = objge_StuBatchQuesRelaEN.IsInErrorQuestion; //是否进入错题
}
if (arrFldSet.Contains(conge_StuBatchQuesRela.IsLook, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuBatchQuesRelaEN.IsLook = objge_StuBatchQuesRelaEN.IsLook; //是否查看
}
if (arrFldSet.Contains(conge_StuBatchQuesRela.IsMarking, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuBatchQuesRelaEN.IsMarking = objge_StuBatchQuesRelaEN.IsMarking; //是否批阅
}
if (arrFldSet.Contains(conge_StuBatchQuesRela.IsNotProcessTimeout, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuBatchQuesRelaEN.IsNotProcessTimeout = objge_StuBatchQuesRelaEN.IsNotProcessTimeout; //是否不处理超时
}
if (arrFldSet.Contains(conge_StuBatchQuesRela.IsHasAnswer, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuBatchQuesRelaEN.IsHasAnswer = objge_StuBatchQuesRelaEN.IsHasAnswer; //是否有答案
}
if (arrFldSet.Contains(conge_StuBatchQuesRela.IsPublish, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuBatchQuesRelaEN.IsPublish = objge_StuBatchQuesRelaEN.IsPublish; //是否发布
}
if (arrFldSet.Contains(conge_StuBatchQuesRela.IsRight, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuBatchQuesRelaEN.IsRight = objge_StuBatchQuesRelaEN.IsRight; //是否正确
}
if (arrFldSet.Contains(conge_StuBatchQuesRela.IsSave, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuBatchQuesRelaEN.IsSave = objge_StuBatchQuesRelaEN.IsSave; //是否保存
}
if (arrFldSet.Contains(conge_StuBatchQuesRela.IsSendBack, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuBatchQuesRelaEN.IsSendBack = objge_StuBatchQuesRelaEN.IsSendBack; //是否退回
}
if (arrFldSet.Contains(conge_StuBatchQuesRela.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuBatchQuesRelaEN.IsSubmit = objge_StuBatchQuesRelaEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(conge_StuBatchQuesRela.MarkDate, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuBatchQuesRelaEN.MarkDate = objge_StuBatchQuesRelaEN.MarkDate == "[null]" ? null :  objge_StuBatchQuesRelaEN.MarkDate; //打分日期
}
if (arrFldSet.Contains(conge_StuBatchQuesRela.MarkerId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuBatchQuesRelaEN.MarkerId = objge_StuBatchQuesRelaEN.MarkerId == "[null]" ? null :  objge_StuBatchQuesRelaEN.MarkerId; //打分者
}
if (arrFldSet.Contains(conge_StuBatchQuesRela.OperateTime, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuBatchQuesRelaEN.OperateTime = objge_StuBatchQuesRelaEN.OperateTime == "[null]" ? null :  objge_StuBatchQuesRelaEN.OperateTime; //操作时间
}
if (arrFldSet.Contains(conge_StuBatchQuesRela.RealFinishDate, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuBatchQuesRelaEN.RealFinishDate = objge_StuBatchQuesRelaEN.RealFinishDate == "[null]" ? null :  objge_StuBatchQuesRelaEN.RealFinishDate; //实际完成日期
}
if (arrFldSet.Contains(conge_StuBatchQuesRela.WorkTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuBatchQuesRelaEN.WorkTypeId = objge_StuBatchQuesRelaEN.WorkTypeId == "[null]" ? null :  objge_StuBatchQuesRelaEN.WorkTypeId; //作业类型Id
}
if (arrFldSet.Contains(conge_StuBatchQuesRela.SchoolYear, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuBatchQuesRelaEN.SchoolYear = objge_StuBatchQuesRelaEN.SchoolYear == "[null]" ? null :  objge_StuBatchQuesRelaEN.SchoolYear; //学年
}
if (arrFldSet.Contains(conge_StuBatchQuesRela.SchoolTerm, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuBatchQuesRelaEN.SchoolTerm = objge_StuBatchQuesRelaEN.SchoolTerm == "[null]" ? null :  objge_StuBatchQuesRelaEN.SchoolTerm; //学期
}
if (arrFldSet.Contains(conge_StuBatchQuesRela.ErrMsg, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuBatchQuesRelaEN.ErrMsg = objge_StuBatchQuesRelaEN.ErrMsg == "[null]" ? null :  objge_StuBatchQuesRelaEN.ErrMsg; //错误信息
}
if (arrFldSet.Contains(conge_StuBatchQuesRela.IsRecommend, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuBatchQuesRelaEN.IsRecommend = objge_StuBatchQuesRelaEN.IsRecommend; //是否推荐
}
if (arrFldSet.Contains(conge_StuBatchQuesRela.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuBatchQuesRelaEN.CourseId = objge_StuBatchQuesRelaEN.CourseId == "[null]" ? null :  objge_StuBatchQuesRelaEN.CourseId; //课程Id
}
if (arrFldSet.Contains(conge_StuBatchQuesRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuBatchQuesRelaEN.UpdDate = objge_StuBatchQuesRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conge_StuBatchQuesRela.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuBatchQuesRelaEN.UpdUserId = objge_StuBatchQuesRelaEN.UpdUserId == "[null]" ? null :  objge_StuBatchQuesRelaEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conge_StuBatchQuesRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuBatchQuesRelaEN.Memo = objge_StuBatchQuesRelaEN.Memo == "[null]" ? null :  objge_StuBatchQuesRelaEN.Memo; //备注
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
 /// <param name = "objge_StuBatchQuesRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN)
{
try
{
if (objge_StuBatchQuesRelaEN.GameLevelId == "[null]") objge_StuBatchQuesRelaEN.GameLevelId = null; //游戏关卡Id
if (objge_StuBatchQuesRelaEN.StuAnswerText == "[null]") objge_StuBatchQuesRelaEN.StuAnswerText = null; //学生回答文本
if (objge_StuBatchQuesRelaEN.AnswerDate == "[null]") objge_StuBatchQuesRelaEN.AnswerDate = null; //回答日期
if (objge_StuBatchQuesRelaEN.AnswerIP == "[null]") objge_StuBatchQuesRelaEN.AnswerIP = null; //回答IP
if (objge_StuBatchQuesRelaEN.AnswerModeId == "[null]") objge_StuBatchQuesRelaEN.AnswerModeId = null; //答案模式Id
if (objge_StuBatchQuesRelaEN.AnswerMultiOptions == "[null]") objge_StuBatchQuesRelaEN.AnswerMultiOptions = null; //多选项答案
if (objge_StuBatchQuesRelaEN.AnswerOptionId == "[null]") objge_StuBatchQuesRelaEN.AnswerOptionId = null; //回答选项Id
if (objge_StuBatchQuesRelaEN.AnswerTime == "[null]") objge_StuBatchQuesRelaEN.AnswerTime = null; //回答时间
if (objge_StuBatchQuesRelaEN.ApplySendBackDate == "[null]") objge_StuBatchQuesRelaEN.ApplySendBackDate = null; //申请退回日期
if (objge_StuBatchQuesRelaEN.Comment == "[null]") objge_StuBatchQuesRelaEN.Comment = null; //批注
if (objge_StuBatchQuesRelaEN.MarkDate == "[null]") objge_StuBatchQuesRelaEN.MarkDate = null; //打分日期
if (objge_StuBatchQuesRelaEN.MarkerId == "[null]") objge_StuBatchQuesRelaEN.MarkerId = null; //打分者
if (objge_StuBatchQuesRelaEN.OperateTime == "[null]") objge_StuBatchQuesRelaEN.OperateTime = null; //操作时间
if (objge_StuBatchQuesRelaEN.RealFinishDate == "[null]") objge_StuBatchQuesRelaEN.RealFinishDate = null; //实际完成日期
if (objge_StuBatchQuesRelaEN.WorkTypeId == "[null]") objge_StuBatchQuesRelaEN.WorkTypeId = null; //作业类型Id
if (objge_StuBatchQuesRelaEN.SchoolYear == "[null]") objge_StuBatchQuesRelaEN.SchoolYear = null; //学年
if (objge_StuBatchQuesRelaEN.SchoolTerm == "[null]") objge_StuBatchQuesRelaEN.SchoolTerm = null; //学期
if (objge_StuBatchQuesRelaEN.ErrMsg == "[null]") objge_StuBatchQuesRelaEN.ErrMsg = null; //错误信息
if (objge_StuBatchQuesRelaEN.CourseId == "[null]") objge_StuBatchQuesRelaEN.CourseId = null; //课程Id
if (objge_StuBatchQuesRelaEN.UpdUserId == "[null]") objge_StuBatchQuesRelaEN.UpdUserId = null; //修改用户Id
if (objge_StuBatchQuesRelaEN.Memo == "[null]") objge_StuBatchQuesRelaEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN)
{
 ge_StuBatchQuesRelaDA.CheckPropertyNew(objge_StuBatchQuesRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN)
{
 ge_StuBatchQuesRelaDA.CheckProperty4Condition(objge_StuBatchQuesRelaEN);
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
if (clsge_StuBatchQuesRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsge_StuBatchQuesRelaBL没有刷新缓存机制(clsge_StuBatchQuesRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdStuBatchQuesRela");
//if (arrge_StuBatchQuesRelaObjLstCache == null)
//{
//arrge_StuBatchQuesRelaObjLstCache = ge_StuBatchQuesRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdStuBatchQuesRela">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsge_StuBatchQuesRelaEN GetObjByIdStuBatchQuesRelaCache(long lngIdStuBatchQuesRela, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsge_StuBatchQuesRelaEN._CurrTabName, strIdCurrEduCls);
List<clsge_StuBatchQuesRelaEN> arrge_StuBatchQuesRelaObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsge_StuBatchQuesRelaEN> arrge_StuBatchQuesRelaObjLst_Sel =
arrge_StuBatchQuesRelaObjLstCache
.Where(x=> x.IdStuBatchQuesRela == lngIdStuBatchQuesRela 
);
if (arrge_StuBatchQuesRelaObjLst_Sel.Count() == 0)
{
   clsge_StuBatchQuesRelaEN obj = clsge_StuBatchQuesRelaBL.GetObjByIdStuBatchQuesRela(lngIdStuBatchQuesRela);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngIdStuBatchQuesRela, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrge_StuBatchQuesRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsge_StuBatchQuesRelaEN> GetAllge_StuBatchQuesRelaObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsge_StuBatchQuesRelaEN> arrge_StuBatchQuesRelaObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrge_StuBatchQuesRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsge_StuBatchQuesRelaEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsge_StuBatchQuesRelaEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsge_StuBatchQuesRelaEN> arrge_StuBatchQuesRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrge_StuBatchQuesRelaObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsge_StuBatchQuesRelaEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clsge_StuBatchQuesRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsge_StuBatchQuesRelaEN._RefreshTimeLst.Count == 0) return "";
return clsge_StuBatchQuesRelaEN._RefreshTimeLst[clsge_StuBatchQuesRelaEN._RefreshTimeLst.Count - 1];
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
if (clsge_StuBatchQuesRelaBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsge_StuBatchQuesRelaEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clsge_StuBatchQuesRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsge_StuBatchQuesRelaBL.objCommFun4BL.ReFreshCache(strIdCurrEduCls);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--ge_StuBatchQuesRela(学生批次题目关系)
 /// 唯一性条件:ExamBatchNo_UserId_QuestionID
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN)
{
//检测记录是否存在
string strResult = ge_StuBatchQuesRelaDA.GetUniCondStr(objge_StuBatchQuesRelaEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngIdStuBatchQuesRela, string strIdCurrEduCls)
{
if (strInFldName != conge_StuBatchQuesRela.IdStuBatchQuesRela)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conge_StuBatchQuesRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conge_StuBatchQuesRela.AttributeName));
throw new Exception(strMsg);
}
var objge_StuBatchQuesRela = clsge_StuBatchQuesRelaBL.GetObjByIdStuBatchQuesRelaCache(lngIdStuBatchQuesRela, strIdCurrEduCls);
if (objge_StuBatchQuesRela == null) return "";
return objge_StuBatchQuesRela[strOutFldName].ToString();
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
int intRecCount = clsge_StuBatchQuesRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsge_StuBatchQuesRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsge_StuBatchQuesRelaDA.GetRecCount();
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
int intRecCount = clsge_StuBatchQuesRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objge_StuBatchQuesRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaCond)
{
 string strIdCurrEduCls = objge_StuBatchQuesRelaCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsge_StuBatchQuesRelaBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsge_StuBatchQuesRelaEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsge_StuBatchQuesRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conge_StuBatchQuesRela.AttributeName)
{
if (objge_StuBatchQuesRelaCond.IsUpdated(strFldName) == false) continue;
if (objge_StuBatchQuesRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_StuBatchQuesRelaCond[strFldName].ToString());
}
else
{
if (objge_StuBatchQuesRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objge_StuBatchQuesRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_StuBatchQuesRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objge_StuBatchQuesRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objge_StuBatchQuesRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objge_StuBatchQuesRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objge_StuBatchQuesRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objge_StuBatchQuesRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objge_StuBatchQuesRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objge_StuBatchQuesRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objge_StuBatchQuesRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objge_StuBatchQuesRelaCond[strFldName]));
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
 List<string> arrList = clsge_StuBatchQuesRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ge_StuBatchQuesRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ge_StuBatchQuesRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ge_StuBatchQuesRelaDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsge_StuBatchQuesRelaDA.SetFldValue(clsge_StuBatchQuesRelaEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ge_StuBatchQuesRelaDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsge_StuBatchQuesRelaDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsge_StuBatchQuesRelaDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsge_StuBatchQuesRelaDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ge_StuBatchQuesRela] "); 
 strCreateTabCode.Append(" ( "); 
 // /**学生批次题目关系流水号*/ 
 strCreateTabCode.Append(" IdStuBatchQuesRela bigint primary key identity, "); 
 // /**学生批次号*/ 
 strCreateTabCode.Append(" ExamBatchNo varchar(20) not Null, "); 
 // /**学习关号2*/ 
 strCreateTabCode.Append(" LevelNo int Null, "); 
 // /**题目Id*/ 
 strCreateTabCode.Append(" QuestionId bigint not Null, "); 
 // /**用户ID*/ 
 strCreateTabCode.Append(" UserId varchar(18) not Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) not Null, "); 
 // /**题序号4批次*/ 
 strCreateTabCode.Append(" QuestionIndex4Batch int Null, "); 
 // /**游戏关卡Id*/ 
 strCreateTabCode.Append(" GameLevelId char(8) Null, "); 
 // /**分值*/ 
 strCreateTabCode.Append(" Scores decimal(8,2) Null, "); 
 // /**得分*/ 
 strCreateTabCode.Append(" Score decimal(6,1) Null, "); 
 // /**学生回答文本*/ 
 strCreateTabCode.Append(" StuAnswerText text Null, "); 
 // /**回答日期*/ 
 strCreateTabCode.Append(" AnswerDate varchar(8) Null, "); 
 // /**回答IP*/ 
 strCreateTabCode.Append(" AnswerIP varchar(30) Null, "); 
 // /**答案模式Id*/ 
 strCreateTabCode.Append(" AnswerModeId char(4) Null, "); 
 // /**多选项答案*/ 
 strCreateTabCode.Append(" AnswerMultiOptions varchar(300) Null, "); 
 // /**回答选项Id*/ 
 strCreateTabCode.Append(" AnswerOptionId char(8) Null, "); 
 // /**回答时间*/ 
 strCreateTabCode.Append(" AnswerTime varchar(10) Null, "); 
 // /**申请退回日期*/ 
 strCreateTabCode.Append(" ApplySendBackDate varchar(14) Null, "); 
 // /**批注*/ 
 strCreateTabCode.Append(" Comment text Null, "); 
 // /**是否处理知识点*/ 
 strCreateTabCode.Append(" IsAccessKnowledge bit Null, "); 
 // /**是否申请退回*/ 
 strCreateTabCode.Append(" IsApplySendBack bit Null, "); 
 // /**是否进入错题*/ 
 strCreateTabCode.Append(" IsInErrorQuestion bit Null, "); 
 // /**是否查看*/ 
 strCreateTabCode.Append(" IsLook bit Null, "); 
 // /**是否批阅*/ 
 strCreateTabCode.Append(" IsMarking bit Null, "); 
 // /**是否不处理超时*/ 
 strCreateTabCode.Append(" IsNotProcessTimeout bit Null, "); 
 // /**是否有答案*/ 
 strCreateTabCode.Append(" IsHasAnswer bit Null, "); 
 // /**是否发布*/ 
 strCreateTabCode.Append(" IsPublish bit Null, "); 
 // /**是否正确*/ 
 strCreateTabCode.Append(" IsRight bit Null, "); 
 // /**是否保存*/ 
 strCreateTabCode.Append(" IsSave bit Null, "); 
 // /**是否退回*/ 
 strCreateTabCode.Append(" IsSendBack bit Null, "); 
 // /**是否提交*/ 
 strCreateTabCode.Append(" IsSubmit bit Null, "); 
 // /**打分日期*/ 
 strCreateTabCode.Append(" MarkDate varchar(14) Null, "); 
 // /**打分者*/ 
 strCreateTabCode.Append(" MarkerId varchar(20) Null, "); 
 // /**操作时间*/ 
 strCreateTabCode.Append(" OperateTime varchar(14) Null, "); 
 // /**实际完成日期*/ 
 strCreateTabCode.Append(" RealFinishDate varchar(14) Null, "); 
 // /**作业类型Id*/ 
 strCreateTabCode.Append(" WorkTypeId char(2) Null, "); 
 // /**学年*/ 
 strCreateTabCode.Append(" SchoolYear varchar(10) Null, "); 
 // /**学期*/ 
 strCreateTabCode.Append(" SchoolTerm char(1) Null, "); 
 // /**错误信息*/ 
 strCreateTabCode.Append(" ErrMsg varchar(200) Null, "); 
 // /**是否推荐*/ 
 strCreateTabCode.Append(" IsRecommend bit Null, "); 
 // /**课程Id*/ 
 strCreateTabCode.Append(" CourseId char(8) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) not Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**答案模式名称*/ 
 strCreateTabCode.Append(" AnswerModeName varchar(30) Null, "); 
 // /**题目类型名*/ 
 strCreateTabCode.Append(" QuestionTypeName varchar(20) Null, "); 
 // /**题目名称*/ 
 strCreateTabCode.Append(" QuestionName varchar(500) Null, "); 
 // /**选项名称*/ 
 strCreateTabCode.Append(" OptionName varchar(4000) Null, "); 
 // /**课程章节ID*/ 
 strCreateTabCode.Append(" CourseChapterId char(8) not Null, "); 
 // /**课程章节名称*/ 
 strCreateTabCode.Append(" CourseChapterName varchar(100) not Null, "); 
 // /**用户名*/ 
 strCreateTabCode.Append(" UserName varchar(30) Null, "); 
 // /**章名简称*/ 
 strCreateTabCode.Append(" ChapterNameSim varchar(10) Null, "); 
 // /**题目类型Id*/ 
 strCreateTabCode.Append(" QuestionTypeId char(2) Null, "); 
 // /**游戏关卡名称*/ 
 strCreateTabCode.Append(" GameLevelName varchar(100) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 学生批次题目关系(ge_StuBatchQuesRela)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4ge_StuBatchQuesRela : clsCommFun4BLV2
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
clsge_StuBatchQuesRelaBL.ReFreshThisCache(strIdCurrEduCls);
}
}

}