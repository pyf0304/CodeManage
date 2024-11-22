
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_WorkCorrectKeyWorkBL
 表名:cc_WorkCorrectKeyWork(01120190)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:08:20
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
 框架-层名:业务逻辑层(CS)(BusinessLogic)
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
public static class  clscc_WorkCorrectKeyWorkBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdWorkCorrectKeyWork">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_WorkCorrectKeyWorkEN GetObj(this K_IdWorkCorrectKeyWork_cc_WorkCorrectKeyWork myKey)
{
clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN = clscc_WorkCorrectKeyWorkBL.cc_WorkCorrectKeyWorkDA.GetObjByIdWorkCorrectKeyWork(myKey.Value);
return objcc_WorkCorrectKeyWorkEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcc_WorkCorrectKeyWorkEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN)
{
if (CheckUniqueness(objcc_WorkCorrectKeyWorkEN) == false)
{
var strMsg = string.Format("记录已经存在!题目ID = [{0}],批改关键词 = [{1}]的数据已经存在!(in clscc_WorkCorrectKeyWorkBL.AddNewRecord)", objcc_WorkCorrectKeyWorkEN.QuestionID,objcc_WorkCorrectKeyWorkEN.CorrectKeyWork);
throw new Exception(strMsg);
}
try
{
bool bolResult = clscc_WorkCorrectKeyWorkBL.cc_WorkCorrectKeyWorkDA.AddNewRecordBySQL2(objcc_WorkCorrectKeyWorkEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkCorrectKeyWorkBL.ReFreshCache();

if (clscc_WorkCorrectKeyWorkBL.relatedActions != null)
{
clscc_WorkCorrectKeyWorkBL.relatedActions.UpdRelaTabDate(objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork, objcc_WorkCorrectKeyWorkEN.UpdUser);
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
public static bool AddRecordEx(this clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN)
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
objcc_WorkCorrectKeyWorkEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objcc_WorkCorrectKeyWorkEN.CheckUniqueness() == false)
{
strMsg = string.Format("(题目ID(QuestionID)=[{0}],批改关键词(CorrectKeyWork)=[{1}])已经存在,不能重复!", objcc_WorkCorrectKeyWorkEN.QuestionID, objcc_WorkCorrectKeyWorkEN.CorrectKeyWork);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objcc_WorkCorrectKeyWorkEN.AddNewRecord();
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
 /// <param name = "objcc_WorkCorrectKeyWorkEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN)
{
if (CheckUniqueness(objcc_WorkCorrectKeyWorkEN) == false)
{
var strMsg = string.Format("记录已经存在!题目ID = [{0}],批改关键词 = [{1}]的数据已经存在!(in clscc_WorkCorrectKeyWorkBL.AddNewRecordWithReturnKey)", objcc_WorkCorrectKeyWorkEN.QuestionID,objcc_WorkCorrectKeyWorkEN.CorrectKeyWork);
throw new Exception(strMsg);
}
try
{
string strKey = clscc_WorkCorrectKeyWorkBL.cc_WorkCorrectKeyWorkDA.AddNewRecordBySQL2WithReturnKey(objcc_WorkCorrectKeyWorkEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkCorrectKeyWorkBL.ReFreshCache();

if (clscc_WorkCorrectKeyWorkBL.relatedActions != null)
{
clscc_WorkCorrectKeyWorkBL.relatedActions.UpdRelaTabDate(objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork, objcc_WorkCorrectKeyWorkEN.UpdUser);
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
 /// <param name = "objcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkCorrectKeyWorkEN SetIdWorkCorrectKeyWork(this clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN, long lngIdWorkCorrectKeyWork, string strComparisonOp="")
	{
objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork = lngIdWorkCorrectKeyWork; //作业批改关键词流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(concc_WorkCorrectKeyWork.IdWorkCorrectKeyWork) == false)
{
objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(concc_WorkCorrectKeyWork.IdWorkCorrectKeyWork, strComparisonOp);
}
else
{
objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[concc_WorkCorrectKeyWork.IdWorkCorrectKeyWork] = strComparisonOp;
}
}
return objcc_WorkCorrectKeyWorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkCorrectKeyWorkEN SetQuestionID(this clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN, string strQuestionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionID, concc_WorkCorrectKeyWork.QuestionID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionID, 8, concc_WorkCorrectKeyWork.QuestionID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionID, 8, concc_WorkCorrectKeyWork.QuestionID);
}
objcc_WorkCorrectKeyWorkEN.QuestionID = strQuestionID; //题目ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(concc_WorkCorrectKeyWork.QuestionID) == false)
{
objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(concc_WorkCorrectKeyWork.QuestionID, strComparisonOp);
}
else
{
objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[concc_WorkCorrectKeyWork.QuestionID] = strComparisonOp;
}
}
return objcc_WorkCorrectKeyWorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkCorrectKeyWorkEN SetKeyWorkIndex(this clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN, int? intKeyWorkIndex, string strComparisonOp="")
	{
objcc_WorkCorrectKeyWorkEN.KeyWorkIndex = intKeyWorkIndex; //关键字序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(concc_WorkCorrectKeyWork.KeyWorkIndex) == false)
{
objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(concc_WorkCorrectKeyWork.KeyWorkIndex, strComparisonOp);
}
else
{
objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[concc_WorkCorrectKeyWork.KeyWorkIndex] = strComparisonOp;
}
}
return objcc_WorkCorrectKeyWorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkCorrectKeyWorkEN SetCorrectKeyWork(this clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN, string strCorrectKeyWork, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCorrectKeyWork, concc_WorkCorrectKeyWork.CorrectKeyWork);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCorrectKeyWork, 200, concc_WorkCorrectKeyWork.CorrectKeyWork);
}
objcc_WorkCorrectKeyWorkEN.CorrectKeyWork = strCorrectKeyWork; //批改关键词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(concc_WorkCorrectKeyWork.CorrectKeyWork) == false)
{
objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(concc_WorkCorrectKeyWork.CorrectKeyWork, strComparisonOp);
}
else
{
objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[concc_WorkCorrectKeyWork.CorrectKeyWork] = strComparisonOp;
}
}
return objcc_WorkCorrectKeyWorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkCorrectKeyWorkEN SetIsUseFormatPara(this clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN, bool bolIsUseFormatPara, string strComparisonOp="")
	{
objcc_WorkCorrectKeyWorkEN.IsUseFormatPara = bolIsUseFormatPara; //是否使用格式化参数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(concc_WorkCorrectKeyWork.IsUseFormatPara) == false)
{
objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(concc_WorkCorrectKeyWork.IsUseFormatPara, strComparisonOp);
}
else
{
objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[concc_WorkCorrectKeyWork.IsUseFormatPara] = strComparisonOp;
}
}
return objcc_WorkCorrectKeyWorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkCorrectKeyWorkEN SetFormatPara(this clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN, string strFormatPara, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFormatPara, 100, concc_WorkCorrectKeyWork.FormatPara);
}
objcc_WorkCorrectKeyWorkEN.FormatPara = strFormatPara; //格式化参数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(concc_WorkCorrectKeyWork.FormatPara) == false)
{
objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(concc_WorkCorrectKeyWork.FormatPara, strComparisonOp);
}
else
{
objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[concc_WorkCorrectKeyWork.FormatPara] = strComparisonOp;
}
}
return objcc_WorkCorrectKeyWorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkCorrectKeyWorkEN SetInOutTypeId(this clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN, string strInOutTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strInOutTypeId, concc_WorkCorrectKeyWork.InOutTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strInOutTypeId, 2, concc_WorkCorrectKeyWork.InOutTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strInOutTypeId, 2, concc_WorkCorrectKeyWork.InOutTypeId);
}
objcc_WorkCorrectKeyWorkEN.InOutTypeId = strInOutTypeId; //InOut类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(concc_WorkCorrectKeyWork.InOutTypeId) == false)
{
objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(concc_WorkCorrectKeyWork.InOutTypeId, strComparisonOp);
}
else
{
objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[concc_WorkCorrectKeyWork.InOutTypeId] = strComparisonOp;
}
}
return objcc_WorkCorrectKeyWorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkCorrectKeyWorkEN SetCreator(this clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN, string strCreator, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreator, 18, concc_WorkCorrectKeyWork.Creator);
}
objcc_WorkCorrectKeyWorkEN.Creator = strCreator; //创建者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(concc_WorkCorrectKeyWork.Creator) == false)
{
objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(concc_WorkCorrectKeyWork.Creator, strComparisonOp);
}
else
{
objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[concc_WorkCorrectKeyWork.Creator] = strComparisonOp;
}
}
return objcc_WorkCorrectKeyWorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkCorrectKeyWorkEN SetCreateDate(this clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, concc_WorkCorrectKeyWork.CreateDate);
}
objcc_WorkCorrectKeyWorkEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(concc_WorkCorrectKeyWork.CreateDate) == false)
{
objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(concc_WorkCorrectKeyWork.CreateDate, strComparisonOp);
}
else
{
objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[concc_WorkCorrectKeyWork.CreateDate] = strComparisonOp;
}
}
return objcc_WorkCorrectKeyWorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkCorrectKeyWorkEN SetIsEnable(this clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN, bool bolIsEnable, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsEnable, concc_WorkCorrectKeyWork.IsEnable);
objcc_WorkCorrectKeyWorkEN.IsEnable = bolIsEnable; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(concc_WorkCorrectKeyWork.IsEnable) == false)
{
objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(concc_WorkCorrectKeyWork.IsEnable, strComparisonOp);
}
else
{
objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[concc_WorkCorrectKeyWork.IsEnable] = strComparisonOp;
}
}
return objcc_WorkCorrectKeyWorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkCorrectKeyWorkEN SetUpdDate(this clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, concc_WorkCorrectKeyWork.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, concc_WorkCorrectKeyWork.UpdDate);
}
objcc_WorkCorrectKeyWorkEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(concc_WorkCorrectKeyWork.UpdDate) == false)
{
objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(concc_WorkCorrectKeyWork.UpdDate, strComparisonOp);
}
else
{
objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[concc_WorkCorrectKeyWork.UpdDate] = strComparisonOp;
}
}
return objcc_WorkCorrectKeyWorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkCorrectKeyWorkEN SetUpdUser(this clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, concc_WorkCorrectKeyWork.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, concc_WorkCorrectKeyWork.UpdUser);
}
objcc_WorkCorrectKeyWorkEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(concc_WorkCorrectKeyWork.UpdUser) == false)
{
objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(concc_WorkCorrectKeyWork.UpdUser, strComparisonOp);
}
else
{
objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[concc_WorkCorrectKeyWork.UpdUser] = strComparisonOp;
}
}
return objcc_WorkCorrectKeyWorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkCorrectKeyWorkEN SetMemo(this clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, concc_WorkCorrectKeyWork.Memo);
}
objcc_WorkCorrectKeyWorkEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(concc_WorkCorrectKeyWork.Memo) == false)
{
objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(concc_WorkCorrectKeyWork.Memo, strComparisonOp);
}
else
{
objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[concc_WorkCorrectKeyWork.Memo] = strComparisonOp;
}
}
return objcc_WorkCorrectKeyWorkEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objcc_WorkCorrectKeyWorkEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objcc_WorkCorrectKeyWorkEN.CheckPropertyNew();
clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkCond = new clscc_WorkCorrectKeyWorkEN();
string strCondition = objcc_WorkCorrectKeyWorkCond
.SetIdWorkCorrectKeyWork(objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork, "<>")
.SetQuestionID(objcc_WorkCorrectKeyWorkEN.QuestionID, "=")
.SetCorrectKeyWork(objcc_WorkCorrectKeyWorkEN.CorrectKeyWork, "=")
.GetCombineCondition();
objcc_WorkCorrectKeyWorkEN._IsCheckProperty = true;
bool bolIsExist = clscc_WorkCorrectKeyWorkBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(QuestionID_CorrectKeyWork)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objcc_WorkCorrectKeyWorkEN.Update();
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
 /// <param name = "objcc_WorkCorrectKeyWork">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWork)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkCond = new clscc_WorkCorrectKeyWorkEN();
string strCondition = objcc_WorkCorrectKeyWorkCond
.SetQuestionID(objcc_WorkCorrectKeyWork.QuestionID, "=")
.SetCorrectKeyWork(objcc_WorkCorrectKeyWork.CorrectKeyWork, "=")
.GetCombineCondition();
objcc_WorkCorrectKeyWork._IsCheckProperty = true;
bool bolIsExist = clscc_WorkCorrectKeyWorkBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objcc_WorkCorrectKeyWork.IdWorkCorrectKeyWork = clscc_WorkCorrectKeyWorkBL.GetFirstID_S(strCondition);
objcc_WorkCorrectKeyWork.UpdateWithCondition(strCondition);
}
else
{
objcc_WorkCorrectKeyWork.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objcc_WorkCorrectKeyWorkEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN)
{
 if (objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscc_WorkCorrectKeyWorkBL.cc_WorkCorrectKeyWorkDA.UpdateBySql2(objcc_WorkCorrectKeyWorkEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkCorrectKeyWorkBL.ReFreshCache();

if (clscc_WorkCorrectKeyWorkBL.relatedActions != null)
{
clscc_WorkCorrectKeyWorkBL.relatedActions.UpdRelaTabDate(objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork, objcc_WorkCorrectKeyWorkEN.UpdUser);
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
 /// <param name = "objcc_WorkCorrectKeyWorkEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscc_WorkCorrectKeyWorkBL.cc_WorkCorrectKeyWorkDA.UpdateBySql2(objcc_WorkCorrectKeyWorkEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkCorrectKeyWorkBL.ReFreshCache();

if (clscc_WorkCorrectKeyWorkBL.relatedActions != null)
{
clscc_WorkCorrectKeyWorkBL.relatedActions.UpdRelaTabDate(objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork, objcc_WorkCorrectKeyWorkEN.UpdUser);
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
 /// <param name = "objcc_WorkCorrectKeyWorkEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN, string strWhereCond)
{
try
{
bool bolResult = clscc_WorkCorrectKeyWorkBL.cc_WorkCorrectKeyWorkDA.UpdateBySqlWithCondition(objcc_WorkCorrectKeyWorkEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkCorrectKeyWorkBL.ReFreshCache();

if (clscc_WorkCorrectKeyWorkBL.relatedActions != null)
{
clscc_WorkCorrectKeyWorkBL.relatedActions.UpdRelaTabDate(objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork, objcc_WorkCorrectKeyWorkEN.UpdUser);
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
 /// <param name = "objcc_WorkCorrectKeyWorkEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clscc_WorkCorrectKeyWorkBL.cc_WorkCorrectKeyWorkDA.UpdateBySqlWithConditionTransaction(objcc_WorkCorrectKeyWorkEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkCorrectKeyWorkBL.ReFreshCache();

if (clscc_WorkCorrectKeyWorkBL.relatedActions != null)
{
clscc_WorkCorrectKeyWorkBL.relatedActions.UpdRelaTabDate(objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork, objcc_WorkCorrectKeyWorkEN.UpdUser);
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
 /// <param name = "lngIdWorkCorrectKeyWork">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN)
{
try
{
int intRecNum = clscc_WorkCorrectKeyWorkBL.cc_WorkCorrectKeyWorkDA.DelRecord(objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkCorrectKeyWorkBL.ReFreshCache();

if (clscc_WorkCorrectKeyWorkBL.relatedActions != null)
{
clscc_WorkCorrectKeyWorkBL.relatedActions.UpdRelaTabDate(objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork, objcc_WorkCorrectKeyWorkEN.UpdUser);
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
 /// <param name = "objcc_WorkCorrectKeyWorkENS">源对象</param>
 /// <param name = "objcc_WorkCorrectKeyWorkENT">目标对象</param>
 public static void CopyTo(this clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkENS, clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkENT)
{
try
{
objcc_WorkCorrectKeyWorkENT.IdWorkCorrectKeyWork = objcc_WorkCorrectKeyWorkENS.IdWorkCorrectKeyWork; //作业批改关键词流水号
objcc_WorkCorrectKeyWorkENT.QuestionID = objcc_WorkCorrectKeyWorkENS.QuestionID; //题目ID
objcc_WorkCorrectKeyWorkENT.KeyWorkIndex = objcc_WorkCorrectKeyWorkENS.KeyWorkIndex; //关键字序号
objcc_WorkCorrectKeyWorkENT.CorrectKeyWork = objcc_WorkCorrectKeyWorkENS.CorrectKeyWork; //批改关键词
objcc_WorkCorrectKeyWorkENT.IsUseFormatPara = objcc_WorkCorrectKeyWorkENS.IsUseFormatPara; //是否使用格式化参数
objcc_WorkCorrectKeyWorkENT.FormatPara = objcc_WorkCorrectKeyWorkENS.FormatPara; //格式化参数
objcc_WorkCorrectKeyWorkENT.InOutTypeId = objcc_WorkCorrectKeyWorkENS.InOutTypeId; //InOut类型Id
objcc_WorkCorrectKeyWorkENT.Creator = objcc_WorkCorrectKeyWorkENS.Creator; //创建者
objcc_WorkCorrectKeyWorkENT.CreateDate = objcc_WorkCorrectKeyWorkENS.CreateDate; //建立日期
objcc_WorkCorrectKeyWorkENT.IsEnable = objcc_WorkCorrectKeyWorkENS.IsEnable; //是否启用
objcc_WorkCorrectKeyWorkENT.UpdDate = objcc_WorkCorrectKeyWorkENS.UpdDate; //修改日期
objcc_WorkCorrectKeyWorkENT.UpdUser = objcc_WorkCorrectKeyWorkENS.UpdUser; //修改人
objcc_WorkCorrectKeyWorkENT.Memo = objcc_WorkCorrectKeyWorkENS.Memo; //备注
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
 /// <param name = "objcc_WorkCorrectKeyWorkENS">源对象</param>
 /// <returns>目标对象=>clscc_WorkCorrectKeyWorkEN:objcc_WorkCorrectKeyWorkENT</returns>
 public static clscc_WorkCorrectKeyWorkEN CopyTo(this clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkENS)
{
try
{
 clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkENT = new clscc_WorkCorrectKeyWorkEN()
{
IdWorkCorrectKeyWork = objcc_WorkCorrectKeyWorkENS.IdWorkCorrectKeyWork, //作业批改关键词流水号
QuestionID = objcc_WorkCorrectKeyWorkENS.QuestionID, //题目ID
KeyWorkIndex = objcc_WorkCorrectKeyWorkENS.KeyWorkIndex, //关键字序号
CorrectKeyWork = objcc_WorkCorrectKeyWorkENS.CorrectKeyWork, //批改关键词
IsUseFormatPara = objcc_WorkCorrectKeyWorkENS.IsUseFormatPara, //是否使用格式化参数
FormatPara = objcc_WorkCorrectKeyWorkENS.FormatPara, //格式化参数
InOutTypeId = objcc_WorkCorrectKeyWorkENS.InOutTypeId, //InOut类型Id
Creator = objcc_WorkCorrectKeyWorkENS.Creator, //创建者
CreateDate = objcc_WorkCorrectKeyWorkENS.CreateDate, //建立日期
IsEnable = objcc_WorkCorrectKeyWorkENS.IsEnable, //是否启用
UpdDate = objcc_WorkCorrectKeyWorkENS.UpdDate, //修改日期
UpdUser = objcc_WorkCorrectKeyWorkENS.UpdUser, //修改人
Memo = objcc_WorkCorrectKeyWorkENS.Memo, //备注
};
 return objcc_WorkCorrectKeyWorkENT;
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
public static void CheckPropertyNew(this clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN)
{
 clscc_WorkCorrectKeyWorkBL.cc_WorkCorrectKeyWorkDA.CheckPropertyNew(objcc_WorkCorrectKeyWorkEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN)
{
 clscc_WorkCorrectKeyWorkBL.cc_WorkCorrectKeyWorkDA.CheckProperty4Condition(objcc_WorkCorrectKeyWorkEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcc_WorkCorrectKeyWorkCond.IsUpdated(concc_WorkCorrectKeyWork.IdWorkCorrectKeyWork) == true)
{
string strComparisonOpIdWorkCorrectKeyWork = objcc_WorkCorrectKeyWorkCond.dicFldComparisonOp[concc_WorkCorrectKeyWork.IdWorkCorrectKeyWork];
strWhereCond += string.Format(" And {0} {2} {1}", concc_WorkCorrectKeyWork.IdWorkCorrectKeyWork, objcc_WorkCorrectKeyWorkCond.IdWorkCorrectKeyWork, strComparisonOpIdWorkCorrectKeyWork);
}
if (objcc_WorkCorrectKeyWorkCond.IsUpdated(concc_WorkCorrectKeyWork.QuestionID) == true)
{
string strComparisonOpQuestionID = objcc_WorkCorrectKeyWorkCond.dicFldComparisonOp[concc_WorkCorrectKeyWork.QuestionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkCorrectKeyWork.QuestionID, objcc_WorkCorrectKeyWorkCond.QuestionID, strComparisonOpQuestionID);
}
if (objcc_WorkCorrectKeyWorkCond.IsUpdated(concc_WorkCorrectKeyWork.KeyWorkIndex) == true)
{
string strComparisonOpKeyWorkIndex = objcc_WorkCorrectKeyWorkCond.dicFldComparisonOp[concc_WorkCorrectKeyWork.KeyWorkIndex];
strWhereCond += string.Format(" And {0} {2} {1}", concc_WorkCorrectKeyWork.KeyWorkIndex, objcc_WorkCorrectKeyWorkCond.KeyWorkIndex, strComparisonOpKeyWorkIndex);
}
if (objcc_WorkCorrectKeyWorkCond.IsUpdated(concc_WorkCorrectKeyWork.CorrectKeyWork) == true)
{
string strComparisonOpCorrectKeyWork = objcc_WorkCorrectKeyWorkCond.dicFldComparisonOp[concc_WorkCorrectKeyWork.CorrectKeyWork];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkCorrectKeyWork.CorrectKeyWork, objcc_WorkCorrectKeyWorkCond.CorrectKeyWork, strComparisonOpCorrectKeyWork);
}
if (objcc_WorkCorrectKeyWorkCond.IsUpdated(concc_WorkCorrectKeyWork.IsUseFormatPara) == true)
{
if (objcc_WorkCorrectKeyWorkCond.IsUseFormatPara == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_WorkCorrectKeyWork.IsUseFormatPara);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_WorkCorrectKeyWork.IsUseFormatPara);
}
}
if (objcc_WorkCorrectKeyWorkCond.IsUpdated(concc_WorkCorrectKeyWork.FormatPara) == true)
{
string strComparisonOpFormatPara = objcc_WorkCorrectKeyWorkCond.dicFldComparisonOp[concc_WorkCorrectKeyWork.FormatPara];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkCorrectKeyWork.FormatPara, objcc_WorkCorrectKeyWorkCond.FormatPara, strComparisonOpFormatPara);
}
if (objcc_WorkCorrectKeyWorkCond.IsUpdated(concc_WorkCorrectKeyWork.InOutTypeId) == true)
{
string strComparisonOpInOutTypeId = objcc_WorkCorrectKeyWorkCond.dicFldComparisonOp[concc_WorkCorrectKeyWork.InOutTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkCorrectKeyWork.InOutTypeId, objcc_WorkCorrectKeyWorkCond.InOutTypeId, strComparisonOpInOutTypeId);
}
if (objcc_WorkCorrectKeyWorkCond.IsUpdated(concc_WorkCorrectKeyWork.Creator) == true)
{
string strComparisonOpCreator = objcc_WorkCorrectKeyWorkCond.dicFldComparisonOp[concc_WorkCorrectKeyWork.Creator];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkCorrectKeyWork.Creator, objcc_WorkCorrectKeyWorkCond.Creator, strComparisonOpCreator);
}
if (objcc_WorkCorrectKeyWorkCond.IsUpdated(concc_WorkCorrectKeyWork.CreateDate) == true)
{
string strComparisonOpCreateDate = objcc_WorkCorrectKeyWorkCond.dicFldComparisonOp[concc_WorkCorrectKeyWork.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkCorrectKeyWork.CreateDate, objcc_WorkCorrectKeyWorkCond.CreateDate, strComparisonOpCreateDate);
}
if (objcc_WorkCorrectKeyWorkCond.IsUpdated(concc_WorkCorrectKeyWork.IsEnable) == true)
{
if (objcc_WorkCorrectKeyWorkCond.IsEnable == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_WorkCorrectKeyWork.IsEnable);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_WorkCorrectKeyWork.IsEnable);
}
}
if (objcc_WorkCorrectKeyWorkCond.IsUpdated(concc_WorkCorrectKeyWork.UpdDate) == true)
{
string strComparisonOpUpdDate = objcc_WorkCorrectKeyWorkCond.dicFldComparisonOp[concc_WorkCorrectKeyWork.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkCorrectKeyWork.UpdDate, objcc_WorkCorrectKeyWorkCond.UpdDate, strComparisonOpUpdDate);
}
if (objcc_WorkCorrectKeyWorkCond.IsUpdated(concc_WorkCorrectKeyWork.UpdUser) == true)
{
string strComparisonOpUpdUser = objcc_WorkCorrectKeyWorkCond.dicFldComparisonOp[concc_WorkCorrectKeyWork.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkCorrectKeyWork.UpdUser, objcc_WorkCorrectKeyWorkCond.UpdUser, strComparisonOpUpdUser);
}
if (objcc_WorkCorrectKeyWorkCond.IsUpdated(concc_WorkCorrectKeyWork.Memo) == true)
{
string strComparisonOpMemo = objcc_WorkCorrectKeyWorkCond.dicFldComparisonOp[concc_WorkCorrectKeyWork.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkCorrectKeyWork.Memo, objcc_WorkCorrectKeyWorkCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--cc_WorkCorrectKeyWork(作业批改关键词), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:QuestionID_CorrectKeyWork
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objcc_WorkCorrectKeyWorkEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objcc_WorkCorrectKeyWorkEN == null) return true;
if (objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and QuestionID = '{0}'", objcc_WorkCorrectKeyWorkEN.QuestionID);
 sbCondition.AppendFormat(" and CorrectKeyWork = '{0}'", objcc_WorkCorrectKeyWorkEN.CorrectKeyWork);
if (clscc_WorkCorrectKeyWorkBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("IdWorkCorrectKeyWork !=  {0}", objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork);
 sbCondition.AppendFormat(" and QuestionID = '{0}'", objcc_WorkCorrectKeyWorkEN.QuestionID);
 sbCondition.AppendFormat(" and CorrectKeyWork = '{0}'", objcc_WorkCorrectKeyWorkEN.CorrectKeyWork);
if (clscc_WorkCorrectKeyWorkBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--cc_WorkCorrectKeyWork(作业批改关键词), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:QuestionID_CorrectKeyWork
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objcc_WorkCorrectKeyWorkEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objcc_WorkCorrectKeyWorkEN == null) return "";
if (objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and QuestionID = '{0}'", objcc_WorkCorrectKeyWorkEN.QuestionID);
 sbCondition.AppendFormat(" and CorrectKeyWork = '{0}'", objcc_WorkCorrectKeyWorkEN.CorrectKeyWork);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("IdWorkCorrectKeyWork !=  {0}", objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork);
 sbCondition.AppendFormat(" and QuestionID = '{0}'", objcc_WorkCorrectKeyWorkEN.QuestionID);
 sbCondition.AppendFormat(" and CorrectKeyWork = '{0}'", objcc_WorkCorrectKeyWorkEN.CorrectKeyWork);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_cc_WorkCorrectKeyWork
{
public virtual bool UpdRelaTabDate(long lngIdWorkCorrectKeyWork, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 作业批改关键词(cc_WorkCorrectKeyWork)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clscc_WorkCorrectKeyWorkBL
{
public static RelatedActions_cc_WorkCorrectKeyWork relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clscc_WorkCorrectKeyWorkDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clscc_WorkCorrectKeyWorkDA cc_WorkCorrectKeyWorkDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clscc_WorkCorrectKeyWorkDA();
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
 public clscc_WorkCorrectKeyWorkBL()
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
if (string.IsNullOrEmpty(clscc_WorkCorrectKeyWorkEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscc_WorkCorrectKeyWorkEN._ConnectString);
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
public static DataTable GetDataTable_cc_WorkCorrectKeyWork(string strWhereCond)
{
DataTable objDT;
try
{
objDT = cc_WorkCorrectKeyWorkDA.GetDataTable_cc_WorkCorrectKeyWork(strWhereCond);
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
objDT = cc_WorkCorrectKeyWorkDA.GetDataTable(strWhereCond);
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
objDT = cc_WorkCorrectKeyWorkDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = cc_WorkCorrectKeyWorkDA.GetDataTable(strWhereCond, strTabName);
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
objDT = cc_WorkCorrectKeyWorkDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = cc_WorkCorrectKeyWorkDA.GetDataTable_Top(objTopPara);
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
objDT = cc_WorkCorrectKeyWorkDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = cc_WorkCorrectKeyWorkDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = cc_WorkCorrectKeyWorkDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdWorkCorrectKeyWorkLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clscc_WorkCorrectKeyWorkEN> GetObjLstByIdWorkCorrectKeyWorkLst(List<long> arrIdWorkCorrectKeyWorkLst)
{
List<clscc_WorkCorrectKeyWorkEN> arrObjLst = new List<clscc_WorkCorrectKeyWorkEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdWorkCorrectKeyWorkLst);
 string strWhereCond = string.Format("IdWorkCorrectKeyWork in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN = new clscc_WorkCorrectKeyWorkEN();
try
{
objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork = Int32.Parse(objRow[concc_WorkCorrectKeyWork.IdWorkCorrectKeyWork].ToString().Trim()); //作业批改关键词流水号
objcc_WorkCorrectKeyWorkEN.QuestionID = objRow[concc_WorkCorrectKeyWork.QuestionID].ToString().Trim(); //题目ID
objcc_WorkCorrectKeyWorkEN.KeyWorkIndex = objRow[concc_WorkCorrectKeyWork.KeyWorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkCorrectKeyWork.KeyWorkIndex].ToString().Trim()); //关键字序号
objcc_WorkCorrectKeyWorkEN.CorrectKeyWork = objRow[concc_WorkCorrectKeyWork.CorrectKeyWork].ToString().Trim(); //批改关键词
objcc_WorkCorrectKeyWorkEN.IsUseFormatPara = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkCorrectKeyWork.IsUseFormatPara].ToString().Trim()); //是否使用格式化参数
objcc_WorkCorrectKeyWorkEN.FormatPara = objRow[concc_WorkCorrectKeyWork.FormatPara] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.FormatPara].ToString().Trim(); //格式化参数
objcc_WorkCorrectKeyWorkEN.InOutTypeId = objRow[concc_WorkCorrectKeyWork.InOutTypeId].ToString().Trim(); //InOut类型Id
objcc_WorkCorrectKeyWorkEN.Creator = objRow[concc_WorkCorrectKeyWork.Creator] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.Creator].ToString().Trim(); //创建者
objcc_WorkCorrectKeyWorkEN.CreateDate = objRow[concc_WorkCorrectKeyWork.CreateDate] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.CreateDate].ToString().Trim(); //建立日期
objcc_WorkCorrectKeyWorkEN.IsEnable = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkCorrectKeyWork.IsEnable].ToString().Trim()); //是否启用
objcc_WorkCorrectKeyWorkEN.UpdDate = objRow[concc_WorkCorrectKeyWork.UpdDate].ToString().Trim(); //修改日期
objcc_WorkCorrectKeyWorkEN.UpdUser = objRow[concc_WorkCorrectKeyWork.UpdUser].ToString().Trim(); //修改人
objcc_WorkCorrectKeyWorkEN.Memo = objRow[concc_WorkCorrectKeyWork.Memo] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_WorkCorrectKeyWorkEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdWorkCorrectKeyWorkLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clscc_WorkCorrectKeyWorkEN> GetObjLstByIdWorkCorrectKeyWorkLstCache(List<long> arrIdWorkCorrectKeyWorkLst)
{
string strKey = string.Format("{0}", clscc_WorkCorrectKeyWorkEN._CurrTabName);
List<clscc_WorkCorrectKeyWorkEN> arrcc_WorkCorrectKeyWorkObjLstCache = GetObjLstCache();
IEnumerable <clscc_WorkCorrectKeyWorkEN> arrcc_WorkCorrectKeyWorkObjLst_Sel =
arrcc_WorkCorrectKeyWorkObjLstCache
.Where(x => arrIdWorkCorrectKeyWorkLst.Contains(x.IdWorkCorrectKeyWork));
return arrcc_WorkCorrectKeyWorkObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_WorkCorrectKeyWorkEN> GetObjLst(string strWhereCond)
{
List<clscc_WorkCorrectKeyWorkEN> arrObjLst = new List<clscc_WorkCorrectKeyWorkEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN = new clscc_WorkCorrectKeyWorkEN();
try
{
objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork = Int32.Parse(objRow[concc_WorkCorrectKeyWork.IdWorkCorrectKeyWork].ToString().Trim()); //作业批改关键词流水号
objcc_WorkCorrectKeyWorkEN.QuestionID = objRow[concc_WorkCorrectKeyWork.QuestionID].ToString().Trim(); //题目ID
objcc_WorkCorrectKeyWorkEN.KeyWorkIndex = objRow[concc_WorkCorrectKeyWork.KeyWorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkCorrectKeyWork.KeyWorkIndex].ToString().Trim()); //关键字序号
objcc_WorkCorrectKeyWorkEN.CorrectKeyWork = objRow[concc_WorkCorrectKeyWork.CorrectKeyWork].ToString().Trim(); //批改关键词
objcc_WorkCorrectKeyWorkEN.IsUseFormatPara = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkCorrectKeyWork.IsUseFormatPara].ToString().Trim()); //是否使用格式化参数
objcc_WorkCorrectKeyWorkEN.FormatPara = objRow[concc_WorkCorrectKeyWork.FormatPara] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.FormatPara].ToString().Trim(); //格式化参数
objcc_WorkCorrectKeyWorkEN.InOutTypeId = objRow[concc_WorkCorrectKeyWork.InOutTypeId].ToString().Trim(); //InOut类型Id
objcc_WorkCorrectKeyWorkEN.Creator = objRow[concc_WorkCorrectKeyWork.Creator] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.Creator].ToString().Trim(); //创建者
objcc_WorkCorrectKeyWorkEN.CreateDate = objRow[concc_WorkCorrectKeyWork.CreateDate] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.CreateDate].ToString().Trim(); //建立日期
objcc_WorkCorrectKeyWorkEN.IsEnable = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkCorrectKeyWork.IsEnable].ToString().Trim()); //是否启用
objcc_WorkCorrectKeyWorkEN.UpdDate = objRow[concc_WorkCorrectKeyWork.UpdDate].ToString().Trim(); //修改日期
objcc_WorkCorrectKeyWorkEN.UpdUser = objRow[concc_WorkCorrectKeyWork.UpdUser].ToString().Trim(); //修改人
objcc_WorkCorrectKeyWorkEN.Memo = objRow[concc_WorkCorrectKeyWork.Memo] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_WorkCorrectKeyWorkEN);
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
public static List<clscc_WorkCorrectKeyWorkEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clscc_WorkCorrectKeyWorkEN> arrObjLst = new List<clscc_WorkCorrectKeyWorkEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN = new clscc_WorkCorrectKeyWorkEN();
try
{
objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork = Int32.Parse(objRow[concc_WorkCorrectKeyWork.IdWorkCorrectKeyWork].ToString().Trim()); //作业批改关键词流水号
objcc_WorkCorrectKeyWorkEN.QuestionID = objRow[concc_WorkCorrectKeyWork.QuestionID].ToString().Trim(); //题目ID
objcc_WorkCorrectKeyWorkEN.KeyWorkIndex = objRow[concc_WorkCorrectKeyWork.KeyWorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkCorrectKeyWork.KeyWorkIndex].ToString().Trim()); //关键字序号
objcc_WorkCorrectKeyWorkEN.CorrectKeyWork = objRow[concc_WorkCorrectKeyWork.CorrectKeyWork].ToString().Trim(); //批改关键词
objcc_WorkCorrectKeyWorkEN.IsUseFormatPara = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkCorrectKeyWork.IsUseFormatPara].ToString().Trim()); //是否使用格式化参数
objcc_WorkCorrectKeyWorkEN.FormatPara = objRow[concc_WorkCorrectKeyWork.FormatPara] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.FormatPara].ToString().Trim(); //格式化参数
objcc_WorkCorrectKeyWorkEN.InOutTypeId = objRow[concc_WorkCorrectKeyWork.InOutTypeId].ToString().Trim(); //InOut类型Id
objcc_WorkCorrectKeyWorkEN.Creator = objRow[concc_WorkCorrectKeyWork.Creator] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.Creator].ToString().Trim(); //创建者
objcc_WorkCorrectKeyWorkEN.CreateDate = objRow[concc_WorkCorrectKeyWork.CreateDate] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.CreateDate].ToString().Trim(); //建立日期
objcc_WorkCorrectKeyWorkEN.IsEnable = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkCorrectKeyWork.IsEnable].ToString().Trim()); //是否启用
objcc_WorkCorrectKeyWorkEN.UpdDate = objRow[concc_WorkCorrectKeyWork.UpdDate].ToString().Trim(); //修改日期
objcc_WorkCorrectKeyWorkEN.UpdUser = objRow[concc_WorkCorrectKeyWork.UpdUser].ToString().Trim(); //修改人
objcc_WorkCorrectKeyWorkEN.Memo = objRow[concc_WorkCorrectKeyWork.Memo] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_WorkCorrectKeyWorkEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objcc_WorkCorrectKeyWorkCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clscc_WorkCorrectKeyWorkEN> GetSubObjLstCache(clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkCond)
{
List<clscc_WorkCorrectKeyWorkEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clscc_WorkCorrectKeyWorkEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concc_WorkCorrectKeyWork.AttributeName)
{
if (objcc_WorkCorrectKeyWorkCond.IsUpdated(strFldName) == false) continue;
if (objcc_WorkCorrectKeyWorkCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_WorkCorrectKeyWorkCond[strFldName].ToString());
}
else
{
if (objcc_WorkCorrectKeyWorkCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcc_WorkCorrectKeyWorkCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_WorkCorrectKeyWorkCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcc_WorkCorrectKeyWorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcc_WorkCorrectKeyWorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcc_WorkCorrectKeyWorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcc_WorkCorrectKeyWorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcc_WorkCorrectKeyWorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcc_WorkCorrectKeyWorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcc_WorkCorrectKeyWorkCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcc_WorkCorrectKeyWorkCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcc_WorkCorrectKeyWorkCond[strFldName]));
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
public static List<clscc_WorkCorrectKeyWorkEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clscc_WorkCorrectKeyWorkEN> arrObjLst = new List<clscc_WorkCorrectKeyWorkEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN = new clscc_WorkCorrectKeyWorkEN();
try
{
objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork = Int32.Parse(objRow[concc_WorkCorrectKeyWork.IdWorkCorrectKeyWork].ToString().Trim()); //作业批改关键词流水号
objcc_WorkCorrectKeyWorkEN.QuestionID = objRow[concc_WorkCorrectKeyWork.QuestionID].ToString().Trim(); //题目ID
objcc_WorkCorrectKeyWorkEN.KeyWorkIndex = objRow[concc_WorkCorrectKeyWork.KeyWorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkCorrectKeyWork.KeyWorkIndex].ToString().Trim()); //关键字序号
objcc_WorkCorrectKeyWorkEN.CorrectKeyWork = objRow[concc_WorkCorrectKeyWork.CorrectKeyWork].ToString().Trim(); //批改关键词
objcc_WorkCorrectKeyWorkEN.IsUseFormatPara = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkCorrectKeyWork.IsUseFormatPara].ToString().Trim()); //是否使用格式化参数
objcc_WorkCorrectKeyWorkEN.FormatPara = objRow[concc_WorkCorrectKeyWork.FormatPara] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.FormatPara].ToString().Trim(); //格式化参数
objcc_WorkCorrectKeyWorkEN.InOutTypeId = objRow[concc_WorkCorrectKeyWork.InOutTypeId].ToString().Trim(); //InOut类型Id
objcc_WorkCorrectKeyWorkEN.Creator = objRow[concc_WorkCorrectKeyWork.Creator] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.Creator].ToString().Trim(); //创建者
objcc_WorkCorrectKeyWorkEN.CreateDate = objRow[concc_WorkCorrectKeyWork.CreateDate] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.CreateDate].ToString().Trim(); //建立日期
objcc_WorkCorrectKeyWorkEN.IsEnable = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkCorrectKeyWork.IsEnable].ToString().Trim()); //是否启用
objcc_WorkCorrectKeyWorkEN.UpdDate = objRow[concc_WorkCorrectKeyWork.UpdDate].ToString().Trim(); //修改日期
objcc_WorkCorrectKeyWorkEN.UpdUser = objRow[concc_WorkCorrectKeyWork.UpdUser].ToString().Trim(); //修改人
objcc_WorkCorrectKeyWorkEN.Memo = objRow[concc_WorkCorrectKeyWork.Memo] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_WorkCorrectKeyWorkEN);
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
public static List<clscc_WorkCorrectKeyWorkEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clscc_WorkCorrectKeyWorkEN> arrObjLst = new List<clscc_WorkCorrectKeyWorkEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN = new clscc_WorkCorrectKeyWorkEN();
try
{
objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork = Int32.Parse(objRow[concc_WorkCorrectKeyWork.IdWorkCorrectKeyWork].ToString().Trim()); //作业批改关键词流水号
objcc_WorkCorrectKeyWorkEN.QuestionID = objRow[concc_WorkCorrectKeyWork.QuestionID].ToString().Trim(); //题目ID
objcc_WorkCorrectKeyWorkEN.KeyWorkIndex = objRow[concc_WorkCorrectKeyWork.KeyWorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkCorrectKeyWork.KeyWorkIndex].ToString().Trim()); //关键字序号
objcc_WorkCorrectKeyWorkEN.CorrectKeyWork = objRow[concc_WorkCorrectKeyWork.CorrectKeyWork].ToString().Trim(); //批改关键词
objcc_WorkCorrectKeyWorkEN.IsUseFormatPara = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkCorrectKeyWork.IsUseFormatPara].ToString().Trim()); //是否使用格式化参数
objcc_WorkCorrectKeyWorkEN.FormatPara = objRow[concc_WorkCorrectKeyWork.FormatPara] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.FormatPara].ToString().Trim(); //格式化参数
objcc_WorkCorrectKeyWorkEN.InOutTypeId = objRow[concc_WorkCorrectKeyWork.InOutTypeId].ToString().Trim(); //InOut类型Id
objcc_WorkCorrectKeyWorkEN.Creator = objRow[concc_WorkCorrectKeyWork.Creator] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.Creator].ToString().Trim(); //创建者
objcc_WorkCorrectKeyWorkEN.CreateDate = objRow[concc_WorkCorrectKeyWork.CreateDate] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.CreateDate].ToString().Trim(); //建立日期
objcc_WorkCorrectKeyWorkEN.IsEnable = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkCorrectKeyWork.IsEnable].ToString().Trim()); //是否启用
objcc_WorkCorrectKeyWorkEN.UpdDate = objRow[concc_WorkCorrectKeyWork.UpdDate].ToString().Trim(); //修改日期
objcc_WorkCorrectKeyWorkEN.UpdUser = objRow[concc_WorkCorrectKeyWork.UpdUser].ToString().Trim(); //修改人
objcc_WorkCorrectKeyWorkEN.Memo = objRow[concc_WorkCorrectKeyWork.Memo] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_WorkCorrectKeyWorkEN);
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
List<clscc_WorkCorrectKeyWorkEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clscc_WorkCorrectKeyWorkEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_WorkCorrectKeyWorkEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clscc_WorkCorrectKeyWorkEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clscc_WorkCorrectKeyWorkEN> arrObjLst = new List<clscc_WorkCorrectKeyWorkEN>(); 
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
	clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN = new clscc_WorkCorrectKeyWorkEN();
try
{
objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork = Int32.Parse(objRow[concc_WorkCorrectKeyWork.IdWorkCorrectKeyWork].ToString().Trim()); //作业批改关键词流水号
objcc_WorkCorrectKeyWorkEN.QuestionID = objRow[concc_WorkCorrectKeyWork.QuestionID].ToString().Trim(); //题目ID
objcc_WorkCorrectKeyWorkEN.KeyWorkIndex = objRow[concc_WorkCorrectKeyWork.KeyWorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkCorrectKeyWork.KeyWorkIndex].ToString().Trim()); //关键字序号
objcc_WorkCorrectKeyWorkEN.CorrectKeyWork = objRow[concc_WorkCorrectKeyWork.CorrectKeyWork].ToString().Trim(); //批改关键词
objcc_WorkCorrectKeyWorkEN.IsUseFormatPara = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkCorrectKeyWork.IsUseFormatPara].ToString().Trim()); //是否使用格式化参数
objcc_WorkCorrectKeyWorkEN.FormatPara = objRow[concc_WorkCorrectKeyWork.FormatPara] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.FormatPara].ToString().Trim(); //格式化参数
objcc_WorkCorrectKeyWorkEN.InOutTypeId = objRow[concc_WorkCorrectKeyWork.InOutTypeId].ToString().Trim(); //InOut类型Id
objcc_WorkCorrectKeyWorkEN.Creator = objRow[concc_WorkCorrectKeyWork.Creator] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.Creator].ToString().Trim(); //创建者
objcc_WorkCorrectKeyWorkEN.CreateDate = objRow[concc_WorkCorrectKeyWork.CreateDate] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.CreateDate].ToString().Trim(); //建立日期
objcc_WorkCorrectKeyWorkEN.IsEnable = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkCorrectKeyWork.IsEnable].ToString().Trim()); //是否启用
objcc_WorkCorrectKeyWorkEN.UpdDate = objRow[concc_WorkCorrectKeyWork.UpdDate].ToString().Trim(); //修改日期
objcc_WorkCorrectKeyWorkEN.UpdUser = objRow[concc_WorkCorrectKeyWork.UpdUser].ToString().Trim(); //修改人
objcc_WorkCorrectKeyWorkEN.Memo = objRow[concc_WorkCorrectKeyWork.Memo] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_WorkCorrectKeyWorkEN);
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
public static List<clscc_WorkCorrectKeyWorkEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clscc_WorkCorrectKeyWorkEN> arrObjLst = new List<clscc_WorkCorrectKeyWorkEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN = new clscc_WorkCorrectKeyWorkEN();
try
{
objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork = Int32.Parse(objRow[concc_WorkCorrectKeyWork.IdWorkCorrectKeyWork].ToString().Trim()); //作业批改关键词流水号
objcc_WorkCorrectKeyWorkEN.QuestionID = objRow[concc_WorkCorrectKeyWork.QuestionID].ToString().Trim(); //题目ID
objcc_WorkCorrectKeyWorkEN.KeyWorkIndex = objRow[concc_WorkCorrectKeyWork.KeyWorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkCorrectKeyWork.KeyWorkIndex].ToString().Trim()); //关键字序号
objcc_WorkCorrectKeyWorkEN.CorrectKeyWork = objRow[concc_WorkCorrectKeyWork.CorrectKeyWork].ToString().Trim(); //批改关键词
objcc_WorkCorrectKeyWorkEN.IsUseFormatPara = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkCorrectKeyWork.IsUseFormatPara].ToString().Trim()); //是否使用格式化参数
objcc_WorkCorrectKeyWorkEN.FormatPara = objRow[concc_WorkCorrectKeyWork.FormatPara] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.FormatPara].ToString().Trim(); //格式化参数
objcc_WorkCorrectKeyWorkEN.InOutTypeId = objRow[concc_WorkCorrectKeyWork.InOutTypeId].ToString().Trim(); //InOut类型Id
objcc_WorkCorrectKeyWorkEN.Creator = objRow[concc_WorkCorrectKeyWork.Creator] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.Creator].ToString().Trim(); //创建者
objcc_WorkCorrectKeyWorkEN.CreateDate = objRow[concc_WorkCorrectKeyWork.CreateDate] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.CreateDate].ToString().Trim(); //建立日期
objcc_WorkCorrectKeyWorkEN.IsEnable = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkCorrectKeyWork.IsEnable].ToString().Trim()); //是否启用
objcc_WorkCorrectKeyWorkEN.UpdDate = objRow[concc_WorkCorrectKeyWork.UpdDate].ToString().Trim(); //修改日期
objcc_WorkCorrectKeyWorkEN.UpdUser = objRow[concc_WorkCorrectKeyWork.UpdUser].ToString().Trim(); //修改人
objcc_WorkCorrectKeyWorkEN.Memo = objRow[concc_WorkCorrectKeyWork.Memo] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_WorkCorrectKeyWorkEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clscc_WorkCorrectKeyWorkEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clscc_WorkCorrectKeyWorkEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clscc_WorkCorrectKeyWorkEN> arrObjLst = new List<clscc_WorkCorrectKeyWorkEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN = new clscc_WorkCorrectKeyWorkEN();
try
{
objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork = Int32.Parse(objRow[concc_WorkCorrectKeyWork.IdWorkCorrectKeyWork].ToString().Trim()); //作业批改关键词流水号
objcc_WorkCorrectKeyWorkEN.QuestionID = objRow[concc_WorkCorrectKeyWork.QuestionID].ToString().Trim(); //题目ID
objcc_WorkCorrectKeyWorkEN.KeyWorkIndex = objRow[concc_WorkCorrectKeyWork.KeyWorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkCorrectKeyWork.KeyWorkIndex].ToString().Trim()); //关键字序号
objcc_WorkCorrectKeyWorkEN.CorrectKeyWork = objRow[concc_WorkCorrectKeyWork.CorrectKeyWork].ToString().Trim(); //批改关键词
objcc_WorkCorrectKeyWorkEN.IsUseFormatPara = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkCorrectKeyWork.IsUseFormatPara].ToString().Trim()); //是否使用格式化参数
objcc_WorkCorrectKeyWorkEN.FormatPara = objRow[concc_WorkCorrectKeyWork.FormatPara] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.FormatPara].ToString().Trim(); //格式化参数
objcc_WorkCorrectKeyWorkEN.InOutTypeId = objRow[concc_WorkCorrectKeyWork.InOutTypeId].ToString().Trim(); //InOut类型Id
objcc_WorkCorrectKeyWorkEN.Creator = objRow[concc_WorkCorrectKeyWork.Creator] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.Creator].ToString().Trim(); //创建者
objcc_WorkCorrectKeyWorkEN.CreateDate = objRow[concc_WorkCorrectKeyWork.CreateDate] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.CreateDate].ToString().Trim(); //建立日期
objcc_WorkCorrectKeyWorkEN.IsEnable = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkCorrectKeyWork.IsEnable].ToString().Trim()); //是否启用
objcc_WorkCorrectKeyWorkEN.UpdDate = objRow[concc_WorkCorrectKeyWork.UpdDate].ToString().Trim(); //修改日期
objcc_WorkCorrectKeyWorkEN.UpdUser = objRow[concc_WorkCorrectKeyWork.UpdUser].ToString().Trim(); //修改人
objcc_WorkCorrectKeyWorkEN.Memo = objRow[concc_WorkCorrectKeyWork.Memo] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_WorkCorrectKeyWorkEN);
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
public static List<clscc_WorkCorrectKeyWorkEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clscc_WorkCorrectKeyWorkEN> arrObjLst = new List<clscc_WorkCorrectKeyWorkEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN = new clscc_WorkCorrectKeyWorkEN();
try
{
objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork = Int32.Parse(objRow[concc_WorkCorrectKeyWork.IdWorkCorrectKeyWork].ToString().Trim()); //作业批改关键词流水号
objcc_WorkCorrectKeyWorkEN.QuestionID = objRow[concc_WorkCorrectKeyWork.QuestionID].ToString().Trim(); //题目ID
objcc_WorkCorrectKeyWorkEN.KeyWorkIndex = objRow[concc_WorkCorrectKeyWork.KeyWorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkCorrectKeyWork.KeyWorkIndex].ToString().Trim()); //关键字序号
objcc_WorkCorrectKeyWorkEN.CorrectKeyWork = objRow[concc_WorkCorrectKeyWork.CorrectKeyWork].ToString().Trim(); //批改关键词
objcc_WorkCorrectKeyWorkEN.IsUseFormatPara = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkCorrectKeyWork.IsUseFormatPara].ToString().Trim()); //是否使用格式化参数
objcc_WorkCorrectKeyWorkEN.FormatPara = objRow[concc_WorkCorrectKeyWork.FormatPara] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.FormatPara].ToString().Trim(); //格式化参数
objcc_WorkCorrectKeyWorkEN.InOutTypeId = objRow[concc_WorkCorrectKeyWork.InOutTypeId].ToString().Trim(); //InOut类型Id
objcc_WorkCorrectKeyWorkEN.Creator = objRow[concc_WorkCorrectKeyWork.Creator] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.Creator].ToString().Trim(); //创建者
objcc_WorkCorrectKeyWorkEN.CreateDate = objRow[concc_WorkCorrectKeyWork.CreateDate] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.CreateDate].ToString().Trim(); //建立日期
objcc_WorkCorrectKeyWorkEN.IsEnable = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkCorrectKeyWork.IsEnable].ToString().Trim()); //是否启用
objcc_WorkCorrectKeyWorkEN.UpdDate = objRow[concc_WorkCorrectKeyWork.UpdDate].ToString().Trim(); //修改日期
objcc_WorkCorrectKeyWorkEN.UpdUser = objRow[concc_WorkCorrectKeyWork.UpdUser].ToString().Trim(); //修改人
objcc_WorkCorrectKeyWorkEN.Memo = objRow[concc_WorkCorrectKeyWork.Memo] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_WorkCorrectKeyWorkEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_WorkCorrectKeyWorkEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clscc_WorkCorrectKeyWorkEN> arrObjLst = new List<clscc_WorkCorrectKeyWorkEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN = new clscc_WorkCorrectKeyWorkEN();
try
{
objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork = Int32.Parse(objRow[concc_WorkCorrectKeyWork.IdWorkCorrectKeyWork].ToString().Trim()); //作业批改关键词流水号
objcc_WorkCorrectKeyWorkEN.QuestionID = objRow[concc_WorkCorrectKeyWork.QuestionID].ToString().Trim(); //题目ID
objcc_WorkCorrectKeyWorkEN.KeyWorkIndex = objRow[concc_WorkCorrectKeyWork.KeyWorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkCorrectKeyWork.KeyWorkIndex].ToString().Trim()); //关键字序号
objcc_WorkCorrectKeyWorkEN.CorrectKeyWork = objRow[concc_WorkCorrectKeyWork.CorrectKeyWork].ToString().Trim(); //批改关键词
objcc_WorkCorrectKeyWorkEN.IsUseFormatPara = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkCorrectKeyWork.IsUseFormatPara].ToString().Trim()); //是否使用格式化参数
objcc_WorkCorrectKeyWorkEN.FormatPara = objRow[concc_WorkCorrectKeyWork.FormatPara] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.FormatPara].ToString().Trim(); //格式化参数
objcc_WorkCorrectKeyWorkEN.InOutTypeId = objRow[concc_WorkCorrectKeyWork.InOutTypeId].ToString().Trim(); //InOut类型Id
objcc_WorkCorrectKeyWorkEN.Creator = objRow[concc_WorkCorrectKeyWork.Creator] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.Creator].ToString().Trim(); //创建者
objcc_WorkCorrectKeyWorkEN.CreateDate = objRow[concc_WorkCorrectKeyWork.CreateDate] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.CreateDate].ToString().Trim(); //建立日期
objcc_WorkCorrectKeyWorkEN.IsEnable = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkCorrectKeyWork.IsEnable].ToString().Trim()); //是否启用
objcc_WorkCorrectKeyWorkEN.UpdDate = objRow[concc_WorkCorrectKeyWork.UpdDate].ToString().Trim(); //修改日期
objcc_WorkCorrectKeyWorkEN.UpdUser = objRow[concc_WorkCorrectKeyWork.UpdUser].ToString().Trim(); //修改人
objcc_WorkCorrectKeyWorkEN.Memo = objRow[concc_WorkCorrectKeyWork.Memo] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_WorkCorrectKeyWorkEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objcc_WorkCorrectKeyWorkEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getcc_WorkCorrectKeyWork(ref clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN)
{
bool bolResult = cc_WorkCorrectKeyWorkDA.Getcc_WorkCorrectKeyWork(ref objcc_WorkCorrectKeyWorkEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdWorkCorrectKeyWork">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_WorkCorrectKeyWorkEN GetObjByIdWorkCorrectKeyWork(long lngIdWorkCorrectKeyWork)
{
clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN = cc_WorkCorrectKeyWorkDA.GetObjByIdWorkCorrectKeyWork(lngIdWorkCorrectKeyWork);
return objcc_WorkCorrectKeyWorkEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clscc_WorkCorrectKeyWorkEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN = cc_WorkCorrectKeyWorkDA.GetFirstObj(strWhereCond);
 return objcc_WorkCorrectKeyWorkEN;
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
public static clscc_WorkCorrectKeyWorkEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN = cc_WorkCorrectKeyWorkDA.GetObjByDataRow(objRow);
 return objcc_WorkCorrectKeyWorkEN;
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
public static clscc_WorkCorrectKeyWorkEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN = cc_WorkCorrectKeyWorkDA.GetObjByDataRow(objRow);
 return objcc_WorkCorrectKeyWorkEN;
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
 /// <param name = "lngIdWorkCorrectKeyWork">所给的关键字</param>
 /// <param name = "lstcc_WorkCorrectKeyWorkObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_WorkCorrectKeyWorkEN GetObjByIdWorkCorrectKeyWorkFromList(long lngIdWorkCorrectKeyWork, List<clscc_WorkCorrectKeyWorkEN> lstcc_WorkCorrectKeyWorkObjLst)
{
foreach (clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN in lstcc_WorkCorrectKeyWorkObjLst)
{
if (objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork == lngIdWorkCorrectKeyWork)
{
return objcc_WorkCorrectKeyWorkEN;
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
 long lngIdWorkCorrectKeyWork;
 try
 {
 lngIdWorkCorrectKeyWork = new clscc_WorkCorrectKeyWorkDA().GetFirstID(strWhereCond);
 return lngIdWorkCorrectKeyWork;
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
 arrList = cc_WorkCorrectKeyWorkDA.GetID(strWhereCond);
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
bool bolIsExist = cc_WorkCorrectKeyWorkDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdWorkCorrectKeyWork">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdWorkCorrectKeyWork)
{
//检测记录是否存在
bool bolIsExist = cc_WorkCorrectKeyWorkDA.IsExist(lngIdWorkCorrectKeyWork);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngIdWorkCorrectKeyWork">作业批改关键词流水号</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngIdWorkCorrectKeyWork, string strOpUser)
{
clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN = clscc_WorkCorrectKeyWorkBL.GetObjByIdWorkCorrectKeyWork(lngIdWorkCorrectKeyWork);
objcc_WorkCorrectKeyWorkEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objcc_WorkCorrectKeyWorkEN.UpdUser = strOpUser;
return clscc_WorkCorrectKeyWorkBL.UpdateBySql2(objcc_WorkCorrectKeyWorkEN);
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
 bolIsExist = clscc_WorkCorrectKeyWorkDA.IsExistTable();
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
 bolIsExist = cc_WorkCorrectKeyWorkDA.IsExistTable(strTabName);
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
 /// <param name = "objcc_WorkCorrectKeyWorkEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN)
{
if (objcc_WorkCorrectKeyWorkEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!题目ID = [{0}],批改关键词 = [{1}]的数据已经存在!(in clscc_WorkCorrectKeyWorkBL.AddNewRecordBySql2)", objcc_WorkCorrectKeyWorkEN.QuestionID,objcc_WorkCorrectKeyWorkEN.CorrectKeyWork);
throw new Exception(strMsg);
}
try
{
bool bolResult = cc_WorkCorrectKeyWorkDA.AddNewRecordBySQL2(objcc_WorkCorrectKeyWorkEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkCorrectKeyWorkBL.ReFreshCache();

if (clscc_WorkCorrectKeyWorkBL.relatedActions != null)
{
clscc_WorkCorrectKeyWorkBL.relatedActions.UpdRelaTabDate(objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork, objcc_WorkCorrectKeyWorkEN.UpdUser);
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
 /// <param name = "objcc_WorkCorrectKeyWorkEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN)
{
if (objcc_WorkCorrectKeyWorkEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!题目ID = [{0}],批改关键词 = [{1}]的数据已经存在!(in clscc_WorkCorrectKeyWorkBL.AddNewRecordBySql2WithReturnKey)", objcc_WorkCorrectKeyWorkEN.QuestionID,objcc_WorkCorrectKeyWorkEN.CorrectKeyWork);
throw new Exception(strMsg);
}
try
{
string strKey = cc_WorkCorrectKeyWorkDA.AddNewRecordBySQL2WithReturnKey(objcc_WorkCorrectKeyWorkEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkCorrectKeyWorkBL.ReFreshCache();

if (clscc_WorkCorrectKeyWorkBL.relatedActions != null)
{
clscc_WorkCorrectKeyWorkBL.relatedActions.UpdRelaTabDate(objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork, objcc_WorkCorrectKeyWorkEN.UpdUser);
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
 /// <param name = "objcc_WorkCorrectKeyWorkEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN)
{
try
{
bool bolResult = cc_WorkCorrectKeyWorkDA.Update(objcc_WorkCorrectKeyWorkEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkCorrectKeyWorkBL.ReFreshCache();

if (clscc_WorkCorrectKeyWorkBL.relatedActions != null)
{
clscc_WorkCorrectKeyWorkBL.relatedActions.UpdRelaTabDate(objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork, objcc_WorkCorrectKeyWorkEN.UpdUser);
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
 /// <param name = "objcc_WorkCorrectKeyWorkEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN)
{
 if (objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = cc_WorkCorrectKeyWorkDA.UpdateBySql2(objcc_WorkCorrectKeyWorkEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkCorrectKeyWorkBL.ReFreshCache();

if (clscc_WorkCorrectKeyWorkBL.relatedActions != null)
{
clscc_WorkCorrectKeyWorkBL.relatedActions.UpdRelaTabDate(objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork, objcc_WorkCorrectKeyWorkEN.UpdUser);
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
 /// <param name = "lngIdWorkCorrectKeyWork">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngIdWorkCorrectKeyWork)
{
try
{
 clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN = clscc_WorkCorrectKeyWorkBL.GetObjByIdWorkCorrectKeyWork(lngIdWorkCorrectKeyWork);

if (clscc_WorkCorrectKeyWorkBL.relatedActions != null)
{
clscc_WorkCorrectKeyWorkBL.relatedActions.UpdRelaTabDate(objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork, objcc_WorkCorrectKeyWorkEN.UpdUser);
}
if (objcc_WorkCorrectKeyWorkEN != null)
{
int intRecNum = cc_WorkCorrectKeyWorkDA.DelRecord(lngIdWorkCorrectKeyWork);
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
/// <param name="lngIdWorkCorrectKeyWork">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngIdWorkCorrectKeyWork )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
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
//删除与表:[cc_WorkCorrectKeyWork]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//concc_WorkCorrectKeyWork.IdWorkCorrectKeyWork,
//lngIdWorkCorrectKeyWork);
//        clscc_WorkCorrectKeyWorkBL.Delcc_WorkCorrectKeyWorksByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscc_WorkCorrectKeyWorkBL.DelRecord(lngIdWorkCorrectKeyWork, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscc_WorkCorrectKeyWorkBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngIdWorkCorrectKeyWork, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngIdWorkCorrectKeyWork">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngIdWorkCorrectKeyWork, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clscc_WorkCorrectKeyWorkBL.relatedActions != null)
{
clscc_WorkCorrectKeyWorkBL.relatedActions.UpdRelaTabDate(lngIdWorkCorrectKeyWork, "UpdRelaTabDate");
}
bool bolResult = cc_WorkCorrectKeyWorkDA.DelRecord(lngIdWorkCorrectKeyWork,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdWorkCorrectKeyWorkLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delcc_WorkCorrectKeyWorks(List<string> arrIdWorkCorrectKeyWorkLst)
{
if (arrIdWorkCorrectKeyWorkLst.Count == 0) return 0;
try
{
if (clscc_WorkCorrectKeyWorkBL.relatedActions != null)
{
foreach (var strIdWorkCorrectKeyWork in arrIdWorkCorrectKeyWorkLst)
{
long lngIdWorkCorrectKeyWork = long.Parse(strIdWorkCorrectKeyWork);
clscc_WorkCorrectKeyWorkBL.relatedActions.UpdRelaTabDate(lngIdWorkCorrectKeyWork, "UpdRelaTabDate");
}
}
int intDelRecNum = cc_WorkCorrectKeyWorkDA.Delcc_WorkCorrectKeyWork(arrIdWorkCorrectKeyWorkLst);
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
public static int Delcc_WorkCorrectKeyWorksByCond(string strWhereCond)
{
try
{
if (clscc_WorkCorrectKeyWorkBL.relatedActions != null)
{
List<string> arrIdWorkCorrectKeyWork = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdWorkCorrectKeyWork in arrIdWorkCorrectKeyWork)
{
long lngIdWorkCorrectKeyWork = long.Parse(strIdWorkCorrectKeyWork);
clscc_WorkCorrectKeyWorkBL.relatedActions.UpdRelaTabDate(lngIdWorkCorrectKeyWork, "UpdRelaTabDate");
}
}
int intRecNum = cc_WorkCorrectKeyWorkDA.Delcc_WorkCorrectKeyWork(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[cc_WorkCorrectKeyWork]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngIdWorkCorrectKeyWork">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngIdWorkCorrectKeyWork)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
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
//删除与表:[cc_WorkCorrectKeyWork]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscc_WorkCorrectKeyWorkBL.DelRecord(lngIdWorkCorrectKeyWork, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscc_WorkCorrectKeyWorkBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngIdWorkCorrectKeyWork, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objcc_WorkCorrectKeyWorkENS">源对象</param>
 /// <param name = "objcc_WorkCorrectKeyWorkENT">目标对象</param>
 public static void CopyTo(clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkENS, clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkENT)
{
try
{
objcc_WorkCorrectKeyWorkENT.IdWorkCorrectKeyWork = objcc_WorkCorrectKeyWorkENS.IdWorkCorrectKeyWork; //作业批改关键词流水号
objcc_WorkCorrectKeyWorkENT.QuestionID = objcc_WorkCorrectKeyWorkENS.QuestionID; //题目ID
objcc_WorkCorrectKeyWorkENT.KeyWorkIndex = objcc_WorkCorrectKeyWorkENS.KeyWorkIndex; //关键字序号
objcc_WorkCorrectKeyWorkENT.CorrectKeyWork = objcc_WorkCorrectKeyWorkENS.CorrectKeyWork; //批改关键词
objcc_WorkCorrectKeyWorkENT.IsUseFormatPara = objcc_WorkCorrectKeyWorkENS.IsUseFormatPara; //是否使用格式化参数
objcc_WorkCorrectKeyWorkENT.FormatPara = objcc_WorkCorrectKeyWorkENS.FormatPara; //格式化参数
objcc_WorkCorrectKeyWorkENT.InOutTypeId = objcc_WorkCorrectKeyWorkENS.InOutTypeId; //InOut类型Id
objcc_WorkCorrectKeyWorkENT.Creator = objcc_WorkCorrectKeyWorkENS.Creator; //创建者
objcc_WorkCorrectKeyWorkENT.CreateDate = objcc_WorkCorrectKeyWorkENS.CreateDate; //建立日期
objcc_WorkCorrectKeyWorkENT.IsEnable = objcc_WorkCorrectKeyWorkENS.IsEnable; //是否启用
objcc_WorkCorrectKeyWorkENT.UpdDate = objcc_WorkCorrectKeyWorkENS.UpdDate; //修改日期
objcc_WorkCorrectKeyWorkENT.UpdUser = objcc_WorkCorrectKeyWorkENS.UpdUser; //修改人
objcc_WorkCorrectKeyWorkENT.Memo = objcc_WorkCorrectKeyWorkENS.Memo; //备注
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
 /// <param name = "objcc_WorkCorrectKeyWorkEN">源简化对象</param>
 public static void SetUpdFlag(clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN)
{
try
{
objcc_WorkCorrectKeyWorkEN.ClearUpdateState();
   string strsfUpdFldSetStr = objcc_WorkCorrectKeyWorkEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(concc_WorkCorrectKeyWork.IdWorkCorrectKeyWork, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork = objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork; //作业批改关键词流水号
}
if (arrFldSet.Contains(concc_WorkCorrectKeyWork.QuestionID, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkCorrectKeyWorkEN.QuestionID = objcc_WorkCorrectKeyWorkEN.QuestionID; //题目ID
}
if (arrFldSet.Contains(concc_WorkCorrectKeyWork.KeyWorkIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkCorrectKeyWorkEN.KeyWorkIndex = objcc_WorkCorrectKeyWorkEN.KeyWorkIndex; //关键字序号
}
if (arrFldSet.Contains(concc_WorkCorrectKeyWork.CorrectKeyWork, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkCorrectKeyWorkEN.CorrectKeyWork = objcc_WorkCorrectKeyWorkEN.CorrectKeyWork; //批改关键词
}
if (arrFldSet.Contains(concc_WorkCorrectKeyWork.IsUseFormatPara, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkCorrectKeyWorkEN.IsUseFormatPara = objcc_WorkCorrectKeyWorkEN.IsUseFormatPara; //是否使用格式化参数
}
if (arrFldSet.Contains(concc_WorkCorrectKeyWork.FormatPara, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkCorrectKeyWorkEN.FormatPara = objcc_WorkCorrectKeyWorkEN.FormatPara == "[null]" ? null :  objcc_WorkCorrectKeyWorkEN.FormatPara; //格式化参数
}
if (arrFldSet.Contains(concc_WorkCorrectKeyWork.InOutTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkCorrectKeyWorkEN.InOutTypeId = objcc_WorkCorrectKeyWorkEN.InOutTypeId; //InOut类型Id
}
if (arrFldSet.Contains(concc_WorkCorrectKeyWork.Creator, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkCorrectKeyWorkEN.Creator = objcc_WorkCorrectKeyWorkEN.Creator == "[null]" ? null :  objcc_WorkCorrectKeyWorkEN.Creator; //创建者
}
if (arrFldSet.Contains(concc_WorkCorrectKeyWork.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkCorrectKeyWorkEN.CreateDate = objcc_WorkCorrectKeyWorkEN.CreateDate == "[null]" ? null :  objcc_WorkCorrectKeyWorkEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(concc_WorkCorrectKeyWork.IsEnable, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkCorrectKeyWorkEN.IsEnable = objcc_WorkCorrectKeyWorkEN.IsEnable; //是否启用
}
if (arrFldSet.Contains(concc_WorkCorrectKeyWork.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkCorrectKeyWorkEN.UpdDate = objcc_WorkCorrectKeyWorkEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(concc_WorkCorrectKeyWork.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkCorrectKeyWorkEN.UpdUser = objcc_WorkCorrectKeyWorkEN.UpdUser; //修改人
}
if (arrFldSet.Contains(concc_WorkCorrectKeyWork.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkCorrectKeyWorkEN.Memo = objcc_WorkCorrectKeyWorkEN.Memo == "[null]" ? null :  objcc_WorkCorrectKeyWorkEN.Memo; //备注
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
 /// <param name = "objcc_WorkCorrectKeyWorkEN">源简化对象</param>
 public static void AccessFldValueNull(clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN)
{
try
{
if (objcc_WorkCorrectKeyWorkEN.FormatPara == "[null]") objcc_WorkCorrectKeyWorkEN.FormatPara = null; //格式化参数
if (objcc_WorkCorrectKeyWorkEN.Creator == "[null]") objcc_WorkCorrectKeyWorkEN.Creator = null; //创建者
if (objcc_WorkCorrectKeyWorkEN.CreateDate == "[null]") objcc_WorkCorrectKeyWorkEN.CreateDate = null; //建立日期
if (objcc_WorkCorrectKeyWorkEN.Memo == "[null]") objcc_WorkCorrectKeyWorkEN.Memo = null; //备注
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
public static void CheckPropertyNew(clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN)
{
 cc_WorkCorrectKeyWorkDA.CheckPropertyNew(objcc_WorkCorrectKeyWorkEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN)
{
 cc_WorkCorrectKeyWorkDA.CheckProperty4Condition(objcc_WorkCorrectKeyWorkEN);
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
if (clscc_WorkCorrectKeyWorkBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_WorkCorrectKeyWorkBL没有刷新缓存机制(clscc_WorkCorrectKeyWorkBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdWorkCorrectKeyWork");
//if (arrcc_WorkCorrectKeyWorkObjLstCache == null)
//{
//arrcc_WorkCorrectKeyWorkObjLstCache = cc_WorkCorrectKeyWorkDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdWorkCorrectKeyWork">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_WorkCorrectKeyWorkEN GetObjByIdWorkCorrectKeyWorkCache(long lngIdWorkCorrectKeyWork)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clscc_WorkCorrectKeyWorkEN._CurrTabName);
List<clscc_WorkCorrectKeyWorkEN> arrcc_WorkCorrectKeyWorkObjLstCache = GetObjLstCache();
IEnumerable <clscc_WorkCorrectKeyWorkEN> arrcc_WorkCorrectKeyWorkObjLst_Sel =
arrcc_WorkCorrectKeyWorkObjLstCache
.Where(x=> x.IdWorkCorrectKeyWork == lngIdWorkCorrectKeyWork 
);
if (arrcc_WorkCorrectKeyWorkObjLst_Sel.Count() == 0)
{
   clscc_WorkCorrectKeyWorkEN obj = clscc_WorkCorrectKeyWorkBL.GetObjByIdWorkCorrectKeyWork(lngIdWorkCorrectKeyWork);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrcc_WorkCorrectKeyWorkObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_WorkCorrectKeyWorkEN> GetAllcc_WorkCorrectKeyWorkObjLstCache()
{
//获取缓存中的对象列表
List<clscc_WorkCorrectKeyWorkEN> arrcc_WorkCorrectKeyWorkObjLstCache = GetObjLstCache(); 
return arrcc_WorkCorrectKeyWorkObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_WorkCorrectKeyWorkEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clscc_WorkCorrectKeyWorkEN._CurrTabName);
List<clscc_WorkCorrectKeyWorkEN> arrcc_WorkCorrectKeyWorkObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrcc_WorkCorrectKeyWorkObjLstCache;
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
string strKey = string.Format("{0}", clscc_WorkCorrectKeyWorkEN._CurrTabName);
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clscc_WorkCorrectKeyWorkBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clscc_WorkCorrectKeyWorkEN._CurrTabName);
CacheHelper.Remove(strKey);
clscc_WorkCorrectKeyWorkBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--cc_WorkCorrectKeyWork(作业批改关键词)
 /// 唯一性条件:QuestionID_CorrectKeyWork
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objcc_WorkCorrectKeyWorkEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN)
{
//检测记录是否存在
string strResult = cc_WorkCorrectKeyWorkDA.GetUniCondStr(objcc_WorkCorrectKeyWorkEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-08-24
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngIdWorkCorrectKeyWork)
{
if (strInFldName != concc_WorkCorrectKeyWork.IdWorkCorrectKeyWork)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (concc_WorkCorrectKeyWork.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", concc_WorkCorrectKeyWork.AttributeName));
throw new Exception(strMsg);
}
var objcc_WorkCorrectKeyWork = clscc_WorkCorrectKeyWorkBL.GetObjByIdWorkCorrectKeyWorkCache(lngIdWorkCorrectKeyWork);
if (objcc_WorkCorrectKeyWork == null) return "";
return objcc_WorkCorrectKeyWork[strOutFldName].ToString();
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
int intRecCount = clscc_WorkCorrectKeyWorkDA.GetRecCount(strTabName);
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
int intRecCount = clscc_WorkCorrectKeyWorkDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clscc_WorkCorrectKeyWorkDA.GetRecCount();
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
int intRecCount = clscc_WorkCorrectKeyWorkDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objcc_WorkCorrectKeyWorkCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkCond)
{
List<clscc_WorkCorrectKeyWorkEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clscc_WorkCorrectKeyWorkEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concc_WorkCorrectKeyWork.AttributeName)
{
if (objcc_WorkCorrectKeyWorkCond.IsUpdated(strFldName) == false) continue;
if (objcc_WorkCorrectKeyWorkCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_WorkCorrectKeyWorkCond[strFldName].ToString());
}
else
{
if (objcc_WorkCorrectKeyWorkCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcc_WorkCorrectKeyWorkCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_WorkCorrectKeyWorkCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcc_WorkCorrectKeyWorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcc_WorkCorrectKeyWorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcc_WorkCorrectKeyWorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcc_WorkCorrectKeyWorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcc_WorkCorrectKeyWorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcc_WorkCorrectKeyWorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcc_WorkCorrectKeyWorkCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcc_WorkCorrectKeyWorkCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcc_WorkCorrectKeyWorkCond[strFldName]));
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
 List<string> arrList = clscc_WorkCorrectKeyWorkDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = cc_WorkCorrectKeyWorkDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = cc_WorkCorrectKeyWorkDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = cc_WorkCorrectKeyWorkDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clscc_WorkCorrectKeyWorkDA.SetFldValue(clscc_WorkCorrectKeyWorkEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = cc_WorkCorrectKeyWorkDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clscc_WorkCorrectKeyWorkDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clscc_WorkCorrectKeyWorkDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clscc_WorkCorrectKeyWorkDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[cc_WorkCorrectKeyWork] "); 
 strCreateTabCode.Append(" ( "); 
 // /**作业批改关键词流水号*/ 
 strCreateTabCode.Append(" IdWorkCorrectKeyWork bigint primary key identity, "); 
 // /**题目ID*/ 
 strCreateTabCode.Append(" QuestionID char(8) not Null, "); 
 // /**关键字序号*/ 
 strCreateTabCode.Append(" KeyWorkIndex int Null, "); 
 // /**批改关键词*/ 
 strCreateTabCode.Append(" CorrectKeyWork varchar(200) not Null, "); 
 // /**是否使用格式化参数*/ 
 strCreateTabCode.Append(" IsUseFormatPara bit Null, "); 
 // /**格式化参数*/ 
 strCreateTabCode.Append(" FormatPara varchar(100) Null, "); 
 // /**InOut类型Id*/ 
 strCreateTabCode.Append(" InOutTypeId char(2) not Null, "); 
 // /**创建者*/ 
 strCreateTabCode.Append(" Creator varchar(18) Null, "); 
 // /**建立日期*/ 
 strCreateTabCode.Append(" CreateDate varchar(20) Null, "); 
 // /**是否启用*/ 
 strCreateTabCode.Append(" IsEnable bit not Null, "); 
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
 /// 作业批改关键词(cc_WorkCorrectKeyWork)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4cc_WorkCorrectKeyWork : clsCommFun4BL
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
clscc_WorkCorrectKeyWorkBL.ReFreshThisCache();
}
}

}