
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsAnswer4WorkBL
 表名:Answer4Work(01120200)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:19:39
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
public static class  clsAnswer4WorkBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdAnswer4Work">表关键字</param>
 /// <returns>表对象</returns>
public static clsAnswer4WorkEN GetObj(this K_IdAnswer4Work_Answer4Work myKey)
{
clsAnswer4WorkEN objAnswer4WorkEN = clsAnswer4WorkBL.Answer4WorkDA.GetObjByIdAnswer4Work(myKey.Value);
return objAnswer4WorkEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objAnswer4WorkEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsAnswer4WorkEN objAnswer4WorkEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objAnswer4WorkEN.IdAnswer4Work) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsAnswer4WorkBL.IsExist(objAnswer4WorkEN.IdAnswer4Work) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objAnswer4WorkEN.IdAnswer4Work, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsAnswer4WorkBL.Answer4WorkDA.AddNewRecordBySQL2(objAnswer4WorkEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAnswer4WorkBL.ReFreshCache();

if (clsAnswer4WorkBL.relatedActions != null)
{
clsAnswer4WorkBL.relatedActions.UpdRelaTabDate(objAnswer4WorkEN.IdAnswer4Work, objAnswer4WorkEN.UpdUser);
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
public static bool AddRecordEx(this clsAnswer4WorkEN objAnswer4WorkEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsAnswer4WorkBL.IsExist(objAnswer4WorkEN.IdAnswer4Work))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objAnswer4WorkEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objAnswer4WorkEN.AddNewRecord();
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
 /// <param name = "objAnswer4WorkEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsAnswer4WorkEN objAnswer4WorkEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objAnswer4WorkEN.IdAnswer4Work) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsAnswer4WorkBL.IsExist(objAnswer4WorkEN.IdAnswer4Work) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objAnswer4WorkEN.IdAnswer4Work, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsAnswer4WorkBL.Answer4WorkDA.AddNewRecordBySQL2WithReturnKey(objAnswer4WorkEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAnswer4WorkBL.ReFreshCache();

if (clsAnswer4WorkBL.relatedActions != null)
{
clsAnswer4WorkBL.relatedActions.UpdRelaTabDate(objAnswer4WorkEN.IdAnswer4Work, objAnswer4WorkEN.UpdUser);
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
 /// <param name = "objAnswer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAnswer4WorkEN SetIdAnswer4Work(this clsAnswer4WorkEN objAnswer4WorkEN, string strIdAnswer4Work, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdAnswer4Work, 8, conAnswer4Work.IdAnswer4Work);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdAnswer4Work, 8, conAnswer4Work.IdAnswer4Work);
}
objAnswer4WorkEN.IdAnswer4Work = strIdAnswer4Work; //作业答案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswer4WorkEN.dicFldComparisonOp.ContainsKey(conAnswer4Work.IdAnswer4Work) == false)
{
objAnswer4WorkEN.dicFldComparisonOp.Add(conAnswer4Work.IdAnswer4Work, strComparisonOp);
}
else
{
objAnswer4WorkEN.dicFldComparisonOp[conAnswer4Work.IdAnswer4Work] = strComparisonOp;
}
}
return objAnswer4WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAnswer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAnswer4WorkEN SetAnswerIndex(this clsAnswer4WorkEN objAnswer4WorkEN, int? intAnswerIndex, string strComparisonOp="")
	{
objAnswer4WorkEN.AnswerIndex = intAnswerIndex; //问答序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswer4WorkEN.dicFldComparisonOp.ContainsKey(conAnswer4Work.AnswerIndex) == false)
{
objAnswer4WorkEN.dicFldComparisonOp.Add(conAnswer4Work.AnswerIndex, strComparisonOp);
}
else
{
objAnswer4WorkEN.dicFldComparisonOp[conAnswer4Work.AnswerIndex] = strComparisonOp;
}
}
return objAnswer4WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAnswer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAnswer4WorkEN SetAnswerName(this clsAnswer4WorkEN objAnswer4WorkEN, string strAnswerName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerName, 100, conAnswer4Work.AnswerName);
}
objAnswer4WorkEN.AnswerName = strAnswerName; //问答名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswer4WorkEN.dicFldComparisonOp.ContainsKey(conAnswer4Work.AnswerName) == false)
{
objAnswer4WorkEN.dicFldComparisonOp.Add(conAnswer4Work.AnswerName, strComparisonOp);
}
else
{
objAnswer4WorkEN.dicFldComparisonOp[conAnswer4Work.AnswerName] = strComparisonOp;
}
}
return objAnswer4WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAnswer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAnswer4WorkEN SetIsShow(this clsAnswer4WorkEN objAnswer4WorkEN, bool bolIsShow, string strComparisonOp="")
	{
objAnswer4WorkEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswer4WorkEN.dicFldComparisonOp.ContainsKey(conAnswer4Work.IsShow) == false)
{
objAnswer4WorkEN.dicFldComparisonOp.Add(conAnswer4Work.IsShow, strComparisonOp);
}
else
{
objAnswer4WorkEN.dicFldComparisonOp[conAnswer4Work.IsShow] = strComparisonOp;
}
}
return objAnswer4WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAnswer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAnswer4WorkEN SetAnswerContent(this clsAnswer4WorkEN objAnswer4WorkEN, string strAnswerContent, string strComparisonOp="")
	{
objAnswer4WorkEN.AnswerContent = strAnswerContent; //答案内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswer4WorkEN.dicFldComparisonOp.ContainsKey(conAnswer4Work.AnswerContent) == false)
{
objAnswer4WorkEN.dicFldComparisonOp.Add(conAnswer4Work.AnswerContent, strComparisonOp);
}
else
{
objAnswer4WorkEN.dicFldComparisonOp[conAnswer4Work.AnswerContent] = strComparisonOp;
}
}
return objAnswer4WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAnswer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAnswer4WorkEN SetIsCorrect(this clsAnswer4WorkEN objAnswer4WorkEN, bool bolIsCorrect, string strComparisonOp="")
	{
objAnswer4WorkEN.IsCorrect = bolIsCorrect; //是否正确
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswer4WorkEN.dicFldComparisonOp.ContainsKey(conAnswer4Work.IsCorrect) == false)
{
objAnswer4WorkEN.dicFldComparisonOp.Add(conAnswer4Work.IsCorrect, strComparisonOp);
}
else
{
objAnswer4WorkEN.dicFldComparisonOp[conAnswer4Work.IsCorrect] = strComparisonOp;
}
}
return objAnswer4WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAnswer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAnswer4WorkEN SetIdWork(this clsAnswer4WorkEN objAnswer4WorkEN, string strIdWork, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdWork, conAnswer4Work.IdWork);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdWork, 8, conAnswer4Work.IdWork);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdWork, 8, conAnswer4Work.IdWork);
}
objAnswer4WorkEN.IdWork = strIdWork; //作业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswer4WorkEN.dicFldComparisonOp.ContainsKey(conAnswer4Work.IdWork) == false)
{
objAnswer4WorkEN.dicFldComparisonOp.Add(conAnswer4Work.IdWork, strComparisonOp);
}
else
{
objAnswer4WorkEN.dicFldComparisonOp[conAnswer4Work.IdWork] = strComparisonOp;
}
}
return objAnswer4WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAnswer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAnswer4WorkEN SetQuestionResolve(this clsAnswer4WorkEN objAnswer4WorkEN, string strQuestionResolve, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionResolve, 8000, conAnswer4Work.QuestionResolve);
}
objAnswer4WorkEN.QuestionResolve = strQuestionResolve; //题目解析
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswer4WorkEN.dicFldComparisonOp.ContainsKey(conAnswer4Work.QuestionResolve) == false)
{
objAnswer4WorkEN.dicFldComparisonOp.Add(conAnswer4Work.QuestionResolve, strComparisonOp);
}
else
{
objAnswer4WorkEN.dicFldComparisonOp[conAnswer4Work.QuestionResolve] = strComparisonOp;
}
}
return objAnswer4WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAnswer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAnswer4WorkEN SetUpdUser(this clsAnswer4WorkEN objAnswer4WorkEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conAnswer4Work.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conAnswer4Work.UpdUser);
}
objAnswer4WorkEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswer4WorkEN.dicFldComparisonOp.ContainsKey(conAnswer4Work.UpdUser) == false)
{
objAnswer4WorkEN.dicFldComparisonOp.Add(conAnswer4Work.UpdUser, strComparisonOp);
}
else
{
objAnswer4WorkEN.dicFldComparisonOp[conAnswer4Work.UpdUser] = strComparisonOp;
}
}
return objAnswer4WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAnswer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAnswer4WorkEN SetUpdDate(this clsAnswer4WorkEN objAnswer4WorkEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conAnswer4Work.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conAnswer4Work.UpdDate);
}
objAnswer4WorkEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswer4WorkEN.dicFldComparisonOp.ContainsKey(conAnswer4Work.UpdDate) == false)
{
objAnswer4WorkEN.dicFldComparisonOp.Add(conAnswer4Work.UpdDate, strComparisonOp);
}
else
{
objAnswer4WorkEN.dicFldComparisonOp[conAnswer4Work.UpdDate] = strComparisonOp;
}
}
return objAnswer4WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAnswer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAnswer4WorkEN SetMemo(this clsAnswer4WorkEN objAnswer4WorkEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conAnswer4Work.Memo);
}
objAnswer4WorkEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswer4WorkEN.dicFldComparisonOp.ContainsKey(conAnswer4Work.Memo) == false)
{
objAnswer4WorkEN.dicFldComparisonOp.Add(conAnswer4Work.Memo, strComparisonOp);
}
else
{
objAnswer4WorkEN.dicFldComparisonOp[conAnswer4Work.Memo] = strComparisonOp;
}
}
return objAnswer4WorkEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objAnswer4WorkEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsAnswer4WorkEN objAnswer4WorkEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objAnswer4WorkEN.CheckPropertyNew();
clsAnswer4WorkEN objAnswer4WorkCond = new clsAnswer4WorkEN();
string strCondition = objAnswer4WorkCond
.SetIdAnswer4Work(objAnswer4WorkEN.IdAnswer4Work, "=")
.GetCombineCondition();
objAnswer4WorkEN._IsCheckProperty = true;
bool bolIsExist = clsAnswer4WorkBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objAnswer4WorkEN.Update();
}
catch(Exception objException)
{
strMsg = "修改记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objAnswer4WorkEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsAnswer4WorkEN objAnswer4WorkEN)
{
 if (string.IsNullOrEmpty(objAnswer4WorkEN.IdAnswer4Work) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsAnswer4WorkBL.Answer4WorkDA.UpdateBySql2(objAnswer4WorkEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAnswer4WorkBL.ReFreshCache();

if (clsAnswer4WorkBL.relatedActions != null)
{
clsAnswer4WorkBL.relatedActions.UpdRelaTabDate(objAnswer4WorkEN.IdAnswer4Work, objAnswer4WorkEN.UpdUser);
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
 /// <param name = "objAnswer4WorkEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsAnswer4WorkEN objAnswer4WorkEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objAnswer4WorkEN.IdAnswer4Work) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsAnswer4WorkBL.Answer4WorkDA.UpdateBySql2(objAnswer4WorkEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAnswer4WorkBL.ReFreshCache();

if (clsAnswer4WorkBL.relatedActions != null)
{
clsAnswer4WorkBL.relatedActions.UpdRelaTabDate(objAnswer4WorkEN.IdAnswer4Work, objAnswer4WorkEN.UpdUser);
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
 /// <param name = "objAnswer4WorkEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsAnswer4WorkEN objAnswer4WorkEN, string strWhereCond)
{
try
{
bool bolResult = clsAnswer4WorkBL.Answer4WorkDA.UpdateBySqlWithCondition(objAnswer4WorkEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAnswer4WorkBL.ReFreshCache();

if (clsAnswer4WorkBL.relatedActions != null)
{
clsAnswer4WorkBL.relatedActions.UpdRelaTabDate(objAnswer4WorkEN.IdAnswer4Work, objAnswer4WorkEN.UpdUser);
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
 /// <param name = "objAnswer4WorkEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsAnswer4WorkEN objAnswer4WorkEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsAnswer4WorkBL.Answer4WorkDA.UpdateBySqlWithConditionTransaction(objAnswer4WorkEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAnswer4WorkBL.ReFreshCache();

if (clsAnswer4WorkBL.relatedActions != null)
{
clsAnswer4WorkBL.relatedActions.UpdRelaTabDate(objAnswer4WorkEN.IdAnswer4Work, objAnswer4WorkEN.UpdUser);
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
 /// <param name = "strIdAnswer4Work">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsAnswer4WorkEN objAnswer4WorkEN)
{
try
{
int intRecNum = clsAnswer4WorkBL.Answer4WorkDA.DelRecord(objAnswer4WorkEN.IdAnswer4Work);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAnswer4WorkBL.ReFreshCache();

if (clsAnswer4WorkBL.relatedActions != null)
{
clsAnswer4WorkBL.relatedActions.UpdRelaTabDate(objAnswer4WorkEN.IdAnswer4Work, objAnswer4WorkEN.UpdUser);
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
 /// <param name = "objAnswer4WorkENS">源对象</param>
 /// <param name = "objAnswer4WorkENT">目标对象</param>
 public static void CopyTo(this clsAnswer4WorkEN objAnswer4WorkENS, clsAnswer4WorkEN objAnswer4WorkENT)
{
try
{
objAnswer4WorkENT.IdAnswer4Work = objAnswer4WorkENS.IdAnswer4Work; //作业答案流水号
objAnswer4WorkENT.AnswerIndex = objAnswer4WorkENS.AnswerIndex; //问答序号
objAnswer4WorkENT.AnswerName = objAnswer4WorkENS.AnswerName; //问答名称
objAnswer4WorkENT.IsShow = objAnswer4WorkENS.IsShow; //是否启用
objAnswer4WorkENT.AnswerContent = objAnswer4WorkENS.AnswerContent; //答案内容
objAnswer4WorkENT.IsCorrect = objAnswer4WorkENS.IsCorrect; //是否正确
objAnswer4WorkENT.IdWork = objAnswer4WorkENS.IdWork; //作业流水号
objAnswer4WorkENT.QuestionResolve = objAnswer4WorkENS.QuestionResolve; //题目解析
objAnswer4WorkENT.UpdUser = objAnswer4WorkENS.UpdUser; //修改人
objAnswer4WorkENT.UpdDate = objAnswer4WorkENS.UpdDate; //修改日期
objAnswer4WorkENT.Memo = objAnswer4WorkENS.Memo; //备注
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
 /// <param name = "objAnswer4WorkENS">源对象</param>
 /// <returns>目标对象=>clsAnswer4WorkEN:objAnswer4WorkENT</returns>
 public static clsAnswer4WorkEN CopyTo(this clsAnswer4WorkEN objAnswer4WorkENS)
{
try
{
 clsAnswer4WorkEN objAnswer4WorkENT = new clsAnswer4WorkEN()
{
IdAnswer4Work = objAnswer4WorkENS.IdAnswer4Work, //作业答案流水号
AnswerIndex = objAnswer4WorkENS.AnswerIndex, //问答序号
AnswerName = objAnswer4WorkENS.AnswerName, //问答名称
IsShow = objAnswer4WorkENS.IsShow, //是否启用
AnswerContent = objAnswer4WorkENS.AnswerContent, //答案内容
IsCorrect = objAnswer4WorkENS.IsCorrect, //是否正确
IdWork = objAnswer4WorkENS.IdWork, //作业流水号
QuestionResolve = objAnswer4WorkENS.QuestionResolve, //题目解析
UpdUser = objAnswer4WorkENS.UpdUser, //修改人
UpdDate = objAnswer4WorkENS.UpdDate, //修改日期
Memo = objAnswer4WorkENS.Memo, //备注
};
 return objAnswer4WorkENT;
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
public static void CheckPropertyNew(this clsAnswer4WorkEN objAnswer4WorkEN)
{
 clsAnswer4WorkBL.Answer4WorkDA.CheckPropertyNew(objAnswer4WorkEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsAnswer4WorkEN objAnswer4WorkEN)
{
 clsAnswer4WorkBL.Answer4WorkDA.CheckProperty4Condition(objAnswer4WorkEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsAnswer4WorkEN objAnswer4WorkCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objAnswer4WorkCond.IsUpdated(conAnswer4Work.IdAnswer4Work) == true)
{
string strComparisonOpIdAnswer4Work = objAnswer4WorkCond.dicFldComparisonOp[conAnswer4Work.IdAnswer4Work];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAnswer4Work.IdAnswer4Work, objAnswer4WorkCond.IdAnswer4Work, strComparisonOpIdAnswer4Work);
}
if (objAnswer4WorkCond.IsUpdated(conAnswer4Work.AnswerIndex) == true)
{
string strComparisonOpAnswerIndex = objAnswer4WorkCond.dicFldComparisonOp[conAnswer4Work.AnswerIndex];
strWhereCond += string.Format(" And {0} {2} {1}", conAnswer4Work.AnswerIndex, objAnswer4WorkCond.AnswerIndex, strComparisonOpAnswerIndex);
}
if (objAnswer4WorkCond.IsUpdated(conAnswer4Work.AnswerName) == true)
{
string strComparisonOpAnswerName = objAnswer4WorkCond.dicFldComparisonOp[conAnswer4Work.AnswerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAnswer4Work.AnswerName, objAnswer4WorkCond.AnswerName, strComparisonOpAnswerName);
}
if (objAnswer4WorkCond.IsUpdated(conAnswer4Work.IsShow) == true)
{
if (objAnswer4WorkCond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", conAnswer4Work.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conAnswer4Work.IsShow);
}
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objAnswer4WorkCond.IsUpdated(conAnswer4Work.IsCorrect) == true)
{
if (objAnswer4WorkCond.IsCorrect == true)
{
strWhereCond += string.Format(" And {0} = '1'", conAnswer4Work.IsCorrect);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conAnswer4Work.IsCorrect);
}
}
if (objAnswer4WorkCond.IsUpdated(conAnswer4Work.IdWork) == true)
{
string strComparisonOpIdWork = objAnswer4WorkCond.dicFldComparisonOp[conAnswer4Work.IdWork];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAnswer4Work.IdWork, objAnswer4WorkCond.IdWork, strComparisonOpIdWork);
}
if (objAnswer4WorkCond.IsUpdated(conAnswer4Work.QuestionResolve) == true)
{
string strComparisonOpQuestionResolve = objAnswer4WorkCond.dicFldComparisonOp[conAnswer4Work.QuestionResolve];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAnswer4Work.QuestionResolve, objAnswer4WorkCond.QuestionResolve, strComparisonOpQuestionResolve);
}
if (objAnswer4WorkCond.IsUpdated(conAnswer4Work.UpdUser) == true)
{
string strComparisonOpUpdUser = objAnswer4WorkCond.dicFldComparisonOp[conAnswer4Work.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAnswer4Work.UpdUser, objAnswer4WorkCond.UpdUser, strComparisonOpUpdUser);
}
if (objAnswer4WorkCond.IsUpdated(conAnswer4Work.UpdDate) == true)
{
string strComparisonOpUpdDate = objAnswer4WorkCond.dicFldComparisonOp[conAnswer4Work.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAnswer4Work.UpdDate, objAnswer4WorkCond.UpdDate, strComparisonOpUpdDate);
}
if (objAnswer4WorkCond.IsUpdated(conAnswer4Work.Memo) == true)
{
string strComparisonOpMemo = objAnswer4WorkCond.dicFldComparisonOp[conAnswer4Work.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAnswer4Work.Memo, objAnswer4WorkCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_Answer4Work
{
public virtual bool UpdRelaTabDate(string strIdAnswer4Work, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 作业答案(Answer4Work)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsAnswer4WorkBL
{
public static RelatedActions_Answer4Work relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsAnswer4WorkDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsAnswer4WorkDA Answer4WorkDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsAnswer4WorkDA();
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
 public clsAnswer4WorkBL()
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
if (string.IsNullOrEmpty(clsAnswer4WorkEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsAnswer4WorkEN._ConnectString);
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
public static DataTable GetDataTable_Answer4Work(string strWhereCond)
{
DataTable objDT;
try
{
objDT = Answer4WorkDA.GetDataTable_Answer4Work(strWhereCond);
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
objDT = Answer4WorkDA.GetDataTable(strWhereCond);
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
objDT = Answer4WorkDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = Answer4WorkDA.GetDataTable(strWhereCond, strTabName);
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
objDT = Answer4WorkDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = Answer4WorkDA.GetDataTable_Top(objTopPara);
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
objDT = Answer4WorkDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = Answer4WorkDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = Answer4WorkDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdAnswer4WorkLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsAnswer4WorkEN> GetObjLstByIdAnswer4WorkLst(List<string> arrIdAnswer4WorkLst)
{
List<clsAnswer4WorkEN> arrObjLst = new List<clsAnswer4WorkEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdAnswer4WorkLst, true);
 string strWhereCond = string.Format("IdAnswer4Work in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAnswer4WorkEN objAnswer4WorkEN = new clsAnswer4WorkEN();
try
{
objAnswer4WorkEN.IdAnswer4Work = objRow[conAnswer4Work.IdAnswer4Work].ToString().Trim(); //作业答案流水号
objAnswer4WorkEN.AnswerIndex = objRow[conAnswer4Work.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conAnswer4Work.AnswerIndex].ToString().Trim()); //问答序号
objAnswer4WorkEN.AnswerName = objRow[conAnswer4Work.AnswerName] == DBNull.Value ? null : objRow[conAnswer4Work.AnswerName].ToString().Trim(); //问答名称
objAnswer4WorkEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conAnswer4Work.IsShow].ToString().Trim()); //是否启用
objAnswer4WorkEN.AnswerContent = objRow[conAnswer4Work.AnswerContent] == DBNull.Value ? null : objRow[conAnswer4Work.AnswerContent].ToString().Trim(); //答案内容
objAnswer4WorkEN.IsCorrect = clsEntityBase2.TransNullToBool_S(objRow[conAnswer4Work.IsCorrect].ToString().Trim()); //是否正确
objAnswer4WorkEN.IdWork = objRow[conAnswer4Work.IdWork].ToString().Trim(); //作业流水号
objAnswer4WorkEN.QuestionResolve = objRow[conAnswer4Work.QuestionResolve] == DBNull.Value ? null : objRow[conAnswer4Work.QuestionResolve].ToString().Trim(); //题目解析
objAnswer4WorkEN.UpdUser = objRow[conAnswer4Work.UpdUser].ToString().Trim(); //修改人
objAnswer4WorkEN.UpdDate = objRow[conAnswer4Work.UpdDate].ToString().Trim(); //修改日期
objAnswer4WorkEN.Memo = objRow[conAnswer4Work.Memo] == DBNull.Value ? null : objRow[conAnswer4Work.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAnswer4WorkEN.IdAnswer4Work, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAnswer4WorkEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdAnswer4WorkLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsAnswer4WorkEN> GetObjLstByIdAnswer4WorkLstCache(List<string> arrIdAnswer4WorkLst)
{
string strKey = string.Format("{0}", clsAnswer4WorkEN._CurrTabName);
List<clsAnswer4WorkEN> arrAnswer4WorkObjLstCache = GetObjLstCache();
IEnumerable <clsAnswer4WorkEN> arrAnswer4WorkObjLst_Sel =
arrAnswer4WorkObjLstCache
.Where(x => arrIdAnswer4WorkLst.Contains(x.IdAnswer4Work));
return arrAnswer4WorkObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsAnswer4WorkEN> GetObjLst(string strWhereCond)
{
List<clsAnswer4WorkEN> arrObjLst = new List<clsAnswer4WorkEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAnswer4WorkEN objAnswer4WorkEN = new clsAnswer4WorkEN();
try
{
objAnswer4WorkEN.IdAnswer4Work = objRow[conAnswer4Work.IdAnswer4Work].ToString().Trim(); //作业答案流水号
objAnswer4WorkEN.AnswerIndex = objRow[conAnswer4Work.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conAnswer4Work.AnswerIndex].ToString().Trim()); //问答序号
objAnswer4WorkEN.AnswerName = objRow[conAnswer4Work.AnswerName] == DBNull.Value ? null : objRow[conAnswer4Work.AnswerName].ToString().Trim(); //问答名称
objAnswer4WorkEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conAnswer4Work.IsShow].ToString().Trim()); //是否启用
objAnswer4WorkEN.AnswerContent = objRow[conAnswer4Work.AnswerContent] == DBNull.Value ? null : objRow[conAnswer4Work.AnswerContent].ToString().Trim(); //答案内容
objAnswer4WorkEN.IsCorrect = clsEntityBase2.TransNullToBool_S(objRow[conAnswer4Work.IsCorrect].ToString().Trim()); //是否正确
objAnswer4WorkEN.IdWork = objRow[conAnswer4Work.IdWork].ToString().Trim(); //作业流水号
objAnswer4WorkEN.QuestionResolve = objRow[conAnswer4Work.QuestionResolve] == DBNull.Value ? null : objRow[conAnswer4Work.QuestionResolve].ToString().Trim(); //题目解析
objAnswer4WorkEN.UpdUser = objRow[conAnswer4Work.UpdUser].ToString().Trim(); //修改人
objAnswer4WorkEN.UpdDate = objRow[conAnswer4Work.UpdDate].ToString().Trim(); //修改日期
objAnswer4WorkEN.Memo = objRow[conAnswer4Work.Memo] == DBNull.Value ? null : objRow[conAnswer4Work.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAnswer4WorkEN.IdAnswer4Work, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAnswer4WorkEN);
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
public static List<clsAnswer4WorkEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsAnswer4WorkEN> arrObjLst = new List<clsAnswer4WorkEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAnswer4WorkEN objAnswer4WorkEN = new clsAnswer4WorkEN();
try
{
objAnswer4WorkEN.IdAnswer4Work = objRow[conAnswer4Work.IdAnswer4Work].ToString().Trim(); //作业答案流水号
objAnswer4WorkEN.AnswerIndex = objRow[conAnswer4Work.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conAnswer4Work.AnswerIndex].ToString().Trim()); //问答序号
objAnswer4WorkEN.AnswerName = objRow[conAnswer4Work.AnswerName] == DBNull.Value ? null : objRow[conAnswer4Work.AnswerName].ToString().Trim(); //问答名称
objAnswer4WorkEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conAnswer4Work.IsShow].ToString().Trim()); //是否启用
objAnswer4WorkEN.AnswerContent = objRow[conAnswer4Work.AnswerContent] == DBNull.Value ? null : objRow[conAnswer4Work.AnswerContent].ToString().Trim(); //答案内容
objAnswer4WorkEN.IsCorrect = clsEntityBase2.TransNullToBool_S(objRow[conAnswer4Work.IsCorrect].ToString().Trim()); //是否正确
objAnswer4WorkEN.IdWork = objRow[conAnswer4Work.IdWork].ToString().Trim(); //作业流水号
objAnswer4WorkEN.QuestionResolve = objRow[conAnswer4Work.QuestionResolve] == DBNull.Value ? null : objRow[conAnswer4Work.QuestionResolve].ToString().Trim(); //题目解析
objAnswer4WorkEN.UpdUser = objRow[conAnswer4Work.UpdUser].ToString().Trim(); //修改人
objAnswer4WorkEN.UpdDate = objRow[conAnswer4Work.UpdDate].ToString().Trim(); //修改日期
objAnswer4WorkEN.Memo = objRow[conAnswer4Work.Memo] == DBNull.Value ? null : objRow[conAnswer4Work.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAnswer4WorkEN.IdAnswer4Work, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAnswer4WorkEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objAnswer4WorkCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsAnswer4WorkEN> GetSubObjLstCache(clsAnswer4WorkEN objAnswer4WorkCond)
{
List<clsAnswer4WorkEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsAnswer4WorkEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conAnswer4Work.AttributeName)
{
if (objAnswer4WorkCond.IsUpdated(strFldName) == false) continue;
if (objAnswer4WorkCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objAnswer4WorkCond[strFldName].ToString());
}
else
{
if (objAnswer4WorkCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objAnswer4WorkCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objAnswer4WorkCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objAnswer4WorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objAnswer4WorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objAnswer4WorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objAnswer4WorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objAnswer4WorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objAnswer4WorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objAnswer4WorkCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objAnswer4WorkCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objAnswer4WorkCond[strFldName]));
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
public static List<clsAnswer4WorkEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsAnswer4WorkEN> arrObjLst = new List<clsAnswer4WorkEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAnswer4WorkEN objAnswer4WorkEN = new clsAnswer4WorkEN();
try
{
objAnswer4WorkEN.IdAnswer4Work = objRow[conAnswer4Work.IdAnswer4Work].ToString().Trim(); //作业答案流水号
objAnswer4WorkEN.AnswerIndex = objRow[conAnswer4Work.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conAnswer4Work.AnswerIndex].ToString().Trim()); //问答序号
objAnswer4WorkEN.AnswerName = objRow[conAnswer4Work.AnswerName] == DBNull.Value ? null : objRow[conAnswer4Work.AnswerName].ToString().Trim(); //问答名称
objAnswer4WorkEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conAnswer4Work.IsShow].ToString().Trim()); //是否启用
objAnswer4WorkEN.AnswerContent = objRow[conAnswer4Work.AnswerContent] == DBNull.Value ? null : objRow[conAnswer4Work.AnswerContent].ToString().Trim(); //答案内容
objAnswer4WorkEN.IsCorrect = clsEntityBase2.TransNullToBool_S(objRow[conAnswer4Work.IsCorrect].ToString().Trim()); //是否正确
objAnswer4WorkEN.IdWork = objRow[conAnswer4Work.IdWork].ToString().Trim(); //作业流水号
objAnswer4WorkEN.QuestionResolve = objRow[conAnswer4Work.QuestionResolve] == DBNull.Value ? null : objRow[conAnswer4Work.QuestionResolve].ToString().Trim(); //题目解析
objAnswer4WorkEN.UpdUser = objRow[conAnswer4Work.UpdUser].ToString().Trim(); //修改人
objAnswer4WorkEN.UpdDate = objRow[conAnswer4Work.UpdDate].ToString().Trim(); //修改日期
objAnswer4WorkEN.Memo = objRow[conAnswer4Work.Memo] == DBNull.Value ? null : objRow[conAnswer4Work.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAnswer4WorkEN.IdAnswer4Work, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAnswer4WorkEN);
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
public static List<clsAnswer4WorkEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsAnswer4WorkEN> arrObjLst = new List<clsAnswer4WorkEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAnswer4WorkEN objAnswer4WorkEN = new clsAnswer4WorkEN();
try
{
objAnswer4WorkEN.IdAnswer4Work = objRow[conAnswer4Work.IdAnswer4Work].ToString().Trim(); //作业答案流水号
objAnswer4WorkEN.AnswerIndex = objRow[conAnswer4Work.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conAnswer4Work.AnswerIndex].ToString().Trim()); //问答序号
objAnswer4WorkEN.AnswerName = objRow[conAnswer4Work.AnswerName] == DBNull.Value ? null : objRow[conAnswer4Work.AnswerName].ToString().Trim(); //问答名称
objAnswer4WorkEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conAnswer4Work.IsShow].ToString().Trim()); //是否启用
objAnswer4WorkEN.AnswerContent = objRow[conAnswer4Work.AnswerContent] == DBNull.Value ? null : objRow[conAnswer4Work.AnswerContent].ToString().Trim(); //答案内容
objAnswer4WorkEN.IsCorrect = clsEntityBase2.TransNullToBool_S(objRow[conAnswer4Work.IsCorrect].ToString().Trim()); //是否正确
objAnswer4WorkEN.IdWork = objRow[conAnswer4Work.IdWork].ToString().Trim(); //作业流水号
objAnswer4WorkEN.QuestionResolve = objRow[conAnswer4Work.QuestionResolve] == DBNull.Value ? null : objRow[conAnswer4Work.QuestionResolve].ToString().Trim(); //题目解析
objAnswer4WorkEN.UpdUser = objRow[conAnswer4Work.UpdUser].ToString().Trim(); //修改人
objAnswer4WorkEN.UpdDate = objRow[conAnswer4Work.UpdDate].ToString().Trim(); //修改日期
objAnswer4WorkEN.Memo = objRow[conAnswer4Work.Memo] == DBNull.Value ? null : objRow[conAnswer4Work.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAnswer4WorkEN.IdAnswer4Work, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAnswer4WorkEN);
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
List<clsAnswer4WorkEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsAnswer4WorkEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsAnswer4WorkEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsAnswer4WorkEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsAnswer4WorkEN> arrObjLst = new List<clsAnswer4WorkEN>(); 
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
	clsAnswer4WorkEN objAnswer4WorkEN = new clsAnswer4WorkEN();
try
{
objAnswer4WorkEN.IdAnswer4Work = objRow[conAnswer4Work.IdAnswer4Work].ToString().Trim(); //作业答案流水号
objAnswer4WorkEN.AnswerIndex = objRow[conAnswer4Work.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conAnswer4Work.AnswerIndex].ToString().Trim()); //问答序号
objAnswer4WorkEN.AnswerName = objRow[conAnswer4Work.AnswerName] == DBNull.Value ? null : objRow[conAnswer4Work.AnswerName].ToString().Trim(); //问答名称
objAnswer4WorkEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conAnswer4Work.IsShow].ToString().Trim()); //是否启用
objAnswer4WorkEN.AnswerContent = objRow[conAnswer4Work.AnswerContent] == DBNull.Value ? null : objRow[conAnswer4Work.AnswerContent].ToString().Trim(); //答案内容
objAnswer4WorkEN.IsCorrect = clsEntityBase2.TransNullToBool_S(objRow[conAnswer4Work.IsCorrect].ToString().Trim()); //是否正确
objAnswer4WorkEN.IdWork = objRow[conAnswer4Work.IdWork].ToString().Trim(); //作业流水号
objAnswer4WorkEN.QuestionResolve = objRow[conAnswer4Work.QuestionResolve] == DBNull.Value ? null : objRow[conAnswer4Work.QuestionResolve].ToString().Trim(); //题目解析
objAnswer4WorkEN.UpdUser = objRow[conAnswer4Work.UpdUser].ToString().Trim(); //修改人
objAnswer4WorkEN.UpdDate = objRow[conAnswer4Work.UpdDate].ToString().Trim(); //修改日期
objAnswer4WorkEN.Memo = objRow[conAnswer4Work.Memo] == DBNull.Value ? null : objRow[conAnswer4Work.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAnswer4WorkEN.IdAnswer4Work, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAnswer4WorkEN);
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
public static List<clsAnswer4WorkEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsAnswer4WorkEN> arrObjLst = new List<clsAnswer4WorkEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAnswer4WorkEN objAnswer4WorkEN = new clsAnswer4WorkEN();
try
{
objAnswer4WorkEN.IdAnswer4Work = objRow[conAnswer4Work.IdAnswer4Work].ToString().Trim(); //作业答案流水号
objAnswer4WorkEN.AnswerIndex = objRow[conAnswer4Work.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conAnswer4Work.AnswerIndex].ToString().Trim()); //问答序号
objAnswer4WorkEN.AnswerName = objRow[conAnswer4Work.AnswerName] == DBNull.Value ? null : objRow[conAnswer4Work.AnswerName].ToString().Trim(); //问答名称
objAnswer4WorkEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conAnswer4Work.IsShow].ToString().Trim()); //是否启用
objAnswer4WorkEN.AnswerContent = objRow[conAnswer4Work.AnswerContent] == DBNull.Value ? null : objRow[conAnswer4Work.AnswerContent].ToString().Trim(); //答案内容
objAnswer4WorkEN.IsCorrect = clsEntityBase2.TransNullToBool_S(objRow[conAnswer4Work.IsCorrect].ToString().Trim()); //是否正确
objAnswer4WorkEN.IdWork = objRow[conAnswer4Work.IdWork].ToString().Trim(); //作业流水号
objAnswer4WorkEN.QuestionResolve = objRow[conAnswer4Work.QuestionResolve] == DBNull.Value ? null : objRow[conAnswer4Work.QuestionResolve].ToString().Trim(); //题目解析
objAnswer4WorkEN.UpdUser = objRow[conAnswer4Work.UpdUser].ToString().Trim(); //修改人
objAnswer4WorkEN.UpdDate = objRow[conAnswer4Work.UpdDate].ToString().Trim(); //修改日期
objAnswer4WorkEN.Memo = objRow[conAnswer4Work.Memo] == DBNull.Value ? null : objRow[conAnswer4Work.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAnswer4WorkEN.IdAnswer4Work, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAnswer4WorkEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsAnswer4WorkEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsAnswer4WorkEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsAnswer4WorkEN> arrObjLst = new List<clsAnswer4WorkEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAnswer4WorkEN objAnswer4WorkEN = new clsAnswer4WorkEN();
try
{
objAnswer4WorkEN.IdAnswer4Work = objRow[conAnswer4Work.IdAnswer4Work].ToString().Trim(); //作业答案流水号
objAnswer4WorkEN.AnswerIndex = objRow[conAnswer4Work.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conAnswer4Work.AnswerIndex].ToString().Trim()); //问答序号
objAnswer4WorkEN.AnswerName = objRow[conAnswer4Work.AnswerName] == DBNull.Value ? null : objRow[conAnswer4Work.AnswerName].ToString().Trim(); //问答名称
objAnswer4WorkEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conAnswer4Work.IsShow].ToString().Trim()); //是否启用
objAnswer4WorkEN.AnswerContent = objRow[conAnswer4Work.AnswerContent] == DBNull.Value ? null : objRow[conAnswer4Work.AnswerContent].ToString().Trim(); //答案内容
objAnswer4WorkEN.IsCorrect = clsEntityBase2.TransNullToBool_S(objRow[conAnswer4Work.IsCorrect].ToString().Trim()); //是否正确
objAnswer4WorkEN.IdWork = objRow[conAnswer4Work.IdWork].ToString().Trim(); //作业流水号
objAnswer4WorkEN.QuestionResolve = objRow[conAnswer4Work.QuestionResolve] == DBNull.Value ? null : objRow[conAnswer4Work.QuestionResolve].ToString().Trim(); //题目解析
objAnswer4WorkEN.UpdUser = objRow[conAnswer4Work.UpdUser].ToString().Trim(); //修改人
objAnswer4WorkEN.UpdDate = objRow[conAnswer4Work.UpdDate].ToString().Trim(); //修改日期
objAnswer4WorkEN.Memo = objRow[conAnswer4Work.Memo] == DBNull.Value ? null : objRow[conAnswer4Work.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAnswer4WorkEN.IdAnswer4Work, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAnswer4WorkEN);
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
public static List<clsAnswer4WorkEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsAnswer4WorkEN> arrObjLst = new List<clsAnswer4WorkEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAnswer4WorkEN objAnswer4WorkEN = new clsAnswer4WorkEN();
try
{
objAnswer4WorkEN.IdAnswer4Work = objRow[conAnswer4Work.IdAnswer4Work].ToString().Trim(); //作业答案流水号
objAnswer4WorkEN.AnswerIndex = objRow[conAnswer4Work.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conAnswer4Work.AnswerIndex].ToString().Trim()); //问答序号
objAnswer4WorkEN.AnswerName = objRow[conAnswer4Work.AnswerName] == DBNull.Value ? null : objRow[conAnswer4Work.AnswerName].ToString().Trim(); //问答名称
objAnswer4WorkEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conAnswer4Work.IsShow].ToString().Trim()); //是否启用
objAnswer4WorkEN.AnswerContent = objRow[conAnswer4Work.AnswerContent] == DBNull.Value ? null : objRow[conAnswer4Work.AnswerContent].ToString().Trim(); //答案内容
objAnswer4WorkEN.IsCorrect = clsEntityBase2.TransNullToBool_S(objRow[conAnswer4Work.IsCorrect].ToString().Trim()); //是否正确
objAnswer4WorkEN.IdWork = objRow[conAnswer4Work.IdWork].ToString().Trim(); //作业流水号
objAnswer4WorkEN.QuestionResolve = objRow[conAnswer4Work.QuestionResolve] == DBNull.Value ? null : objRow[conAnswer4Work.QuestionResolve].ToString().Trim(); //题目解析
objAnswer4WorkEN.UpdUser = objRow[conAnswer4Work.UpdUser].ToString().Trim(); //修改人
objAnswer4WorkEN.UpdDate = objRow[conAnswer4Work.UpdDate].ToString().Trim(); //修改日期
objAnswer4WorkEN.Memo = objRow[conAnswer4Work.Memo] == DBNull.Value ? null : objRow[conAnswer4Work.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAnswer4WorkEN.IdAnswer4Work, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAnswer4WorkEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsAnswer4WorkEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsAnswer4WorkEN> arrObjLst = new List<clsAnswer4WorkEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAnswer4WorkEN objAnswer4WorkEN = new clsAnswer4WorkEN();
try
{
objAnswer4WorkEN.IdAnswer4Work = objRow[conAnswer4Work.IdAnswer4Work].ToString().Trim(); //作业答案流水号
objAnswer4WorkEN.AnswerIndex = objRow[conAnswer4Work.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conAnswer4Work.AnswerIndex].ToString().Trim()); //问答序号
objAnswer4WorkEN.AnswerName = objRow[conAnswer4Work.AnswerName] == DBNull.Value ? null : objRow[conAnswer4Work.AnswerName].ToString().Trim(); //问答名称
objAnswer4WorkEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conAnswer4Work.IsShow].ToString().Trim()); //是否启用
objAnswer4WorkEN.AnswerContent = objRow[conAnswer4Work.AnswerContent] == DBNull.Value ? null : objRow[conAnswer4Work.AnswerContent].ToString().Trim(); //答案内容
objAnswer4WorkEN.IsCorrect = clsEntityBase2.TransNullToBool_S(objRow[conAnswer4Work.IsCorrect].ToString().Trim()); //是否正确
objAnswer4WorkEN.IdWork = objRow[conAnswer4Work.IdWork].ToString().Trim(); //作业流水号
objAnswer4WorkEN.QuestionResolve = objRow[conAnswer4Work.QuestionResolve] == DBNull.Value ? null : objRow[conAnswer4Work.QuestionResolve].ToString().Trim(); //题目解析
objAnswer4WorkEN.UpdUser = objRow[conAnswer4Work.UpdUser].ToString().Trim(); //修改人
objAnswer4WorkEN.UpdDate = objRow[conAnswer4Work.UpdDate].ToString().Trim(); //修改日期
objAnswer4WorkEN.Memo = objRow[conAnswer4Work.Memo] == DBNull.Value ? null : objRow[conAnswer4Work.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAnswer4WorkEN.IdAnswer4Work, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAnswer4WorkEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objAnswer4WorkEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetAnswer4Work(ref clsAnswer4WorkEN objAnswer4WorkEN)
{
bool bolResult = Answer4WorkDA.GetAnswer4Work(ref objAnswer4WorkEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdAnswer4Work">表关键字</param>
 /// <returns>表对象</returns>
public static clsAnswer4WorkEN GetObjByIdAnswer4Work(string strIdAnswer4Work)
{
if (strIdAnswer4Work.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdAnswer4Work]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdAnswer4Work) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdAnswer4Work]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsAnswer4WorkEN objAnswer4WorkEN = Answer4WorkDA.GetObjByIdAnswer4Work(strIdAnswer4Work);
return objAnswer4WorkEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsAnswer4WorkEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsAnswer4WorkEN objAnswer4WorkEN = Answer4WorkDA.GetFirstObj(strWhereCond);
 return objAnswer4WorkEN;
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
public static clsAnswer4WorkEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsAnswer4WorkEN objAnswer4WorkEN = Answer4WorkDA.GetObjByDataRow(objRow);
 return objAnswer4WorkEN;
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
public static clsAnswer4WorkEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsAnswer4WorkEN objAnswer4WorkEN = Answer4WorkDA.GetObjByDataRow(objRow);
 return objAnswer4WorkEN;
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
 /// <param name = "strIdAnswer4Work">所给的关键字</param>
 /// <param name = "lstAnswer4WorkObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsAnswer4WorkEN GetObjByIdAnswer4WorkFromList(string strIdAnswer4Work, List<clsAnswer4WorkEN> lstAnswer4WorkObjLst)
{
foreach (clsAnswer4WorkEN objAnswer4WorkEN in lstAnswer4WorkObjLst)
{
if (objAnswer4WorkEN.IdAnswer4Work == strIdAnswer4Work)
{
return objAnswer4WorkEN;
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
public static string GetFirstID_S(string strWhereCond) 
{
 string strIdAnswer4Work;
 try
 {
 strIdAnswer4Work = new clsAnswer4WorkDA().GetFirstID(strWhereCond);
 return strIdAnswer4Work;
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
 arrList = Answer4WorkDA.GetID(strWhereCond);
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
bool bolIsExist = Answer4WorkDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdAnswer4Work">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdAnswer4Work)
{
if (string.IsNullOrEmpty(strIdAnswer4Work) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdAnswer4Work]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = Answer4WorkDA.IsExist(strIdAnswer4Work);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strIdAnswer4Work">作业答案流水号</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strIdAnswer4Work, string strOpUser)
{
clsAnswer4WorkEN objAnswer4WorkEN = clsAnswer4WorkBL.GetObjByIdAnswer4Work(strIdAnswer4Work);
objAnswer4WorkEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objAnswer4WorkEN.UpdUser = strOpUser;
return clsAnswer4WorkBL.UpdateBySql2(objAnswer4WorkEN);
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
 bolIsExist = clsAnswer4WorkDA.IsExistTable();
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
 bolIsExist = Answer4WorkDA.IsExistTable(strTabName);
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
 /// <param name = "objAnswer4WorkEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsAnswer4WorkEN objAnswer4WorkEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objAnswer4WorkEN.IdAnswer4Work) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsAnswer4WorkBL.IsExist(objAnswer4WorkEN.IdAnswer4Work) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objAnswer4WorkEN.IdAnswer4Work, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = Answer4WorkDA.AddNewRecordBySQL2(objAnswer4WorkEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAnswer4WorkBL.ReFreshCache();

if (clsAnswer4WorkBL.relatedActions != null)
{
clsAnswer4WorkBL.relatedActions.UpdRelaTabDate(objAnswer4WorkEN.IdAnswer4Work, objAnswer4WorkEN.UpdUser);
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
 /// <param name = "objAnswer4WorkEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsAnswer4WorkEN objAnswer4WorkEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objAnswer4WorkEN.IdAnswer4Work) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsAnswer4WorkBL.IsExist(objAnswer4WorkEN.IdAnswer4Work) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objAnswer4WorkEN.IdAnswer4Work, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = Answer4WorkDA.AddNewRecordBySQL2WithReturnKey(objAnswer4WorkEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAnswer4WorkBL.ReFreshCache();

if (clsAnswer4WorkBL.relatedActions != null)
{
clsAnswer4WorkBL.relatedActions.UpdRelaTabDate(objAnswer4WorkEN.IdAnswer4Work, objAnswer4WorkEN.UpdUser);
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
 /// <param name = "objAnswer4WorkEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsAnswer4WorkEN objAnswer4WorkEN)
{
try
{
bool bolResult = Answer4WorkDA.Update(objAnswer4WorkEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAnswer4WorkBL.ReFreshCache();

if (clsAnswer4WorkBL.relatedActions != null)
{
clsAnswer4WorkBL.relatedActions.UpdRelaTabDate(objAnswer4WorkEN.IdAnswer4Work, objAnswer4WorkEN.UpdUser);
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
 /// <param name = "objAnswer4WorkEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsAnswer4WorkEN objAnswer4WorkEN)
{
 if (string.IsNullOrEmpty(objAnswer4WorkEN.IdAnswer4Work) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = Answer4WorkDA.UpdateBySql2(objAnswer4WorkEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAnswer4WorkBL.ReFreshCache();

if (clsAnswer4WorkBL.relatedActions != null)
{
clsAnswer4WorkBL.relatedActions.UpdRelaTabDate(objAnswer4WorkEN.IdAnswer4Work, objAnswer4WorkEN.UpdUser);
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
 /// <param name = "strIdAnswer4Work">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strIdAnswer4Work)
{
try
{
 clsAnswer4WorkEN objAnswer4WorkEN = clsAnswer4WorkBL.GetObjByIdAnswer4Work(strIdAnswer4Work);

if (clsAnswer4WorkBL.relatedActions != null)
{
clsAnswer4WorkBL.relatedActions.UpdRelaTabDate(objAnswer4WorkEN.IdAnswer4Work, objAnswer4WorkEN.UpdUser);
}
if (objAnswer4WorkEN != null)
{
int intRecNum = Answer4WorkDA.DelRecord(strIdAnswer4Work);
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
/// <param name="strIdAnswer4Work">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strIdAnswer4Work )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsAnswer4WorkDA.GetSpecSQLObj();
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
//删除与表:[Answer4Work]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conAnswer4Work.IdAnswer4Work,
//strIdAnswer4Work);
//        clsAnswer4WorkBL.DelAnswer4WorksByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsAnswer4WorkBL.DelRecord(strIdAnswer4Work, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsAnswer4WorkBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdAnswer4Work, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strIdAnswer4Work">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strIdAnswer4Work, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsAnswer4WorkBL.relatedActions != null)
{
clsAnswer4WorkBL.relatedActions.UpdRelaTabDate(strIdAnswer4Work, "UpdRelaTabDate");
}
bool bolResult = Answer4WorkDA.DelRecord(strIdAnswer4Work,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdAnswer4WorkLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelAnswer4Works(List<string> arrIdAnswer4WorkLst)
{
if (arrIdAnswer4WorkLst.Count == 0) return 0;
try
{
if (clsAnswer4WorkBL.relatedActions != null)
{
foreach (var strIdAnswer4Work in arrIdAnswer4WorkLst)
{
clsAnswer4WorkBL.relatedActions.UpdRelaTabDate(strIdAnswer4Work, "UpdRelaTabDate");
}
}
int intDelRecNum = Answer4WorkDA.DelAnswer4Work(arrIdAnswer4WorkLst);
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
public static int DelAnswer4WorksByCond(string strWhereCond)
{
try
{
if (clsAnswer4WorkBL.relatedActions != null)
{
List<string> arrIdAnswer4Work = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdAnswer4Work in arrIdAnswer4Work)
{
clsAnswer4WorkBL.relatedActions.UpdRelaTabDate(strIdAnswer4Work, "UpdRelaTabDate");
}
}
int intRecNum = Answer4WorkDA.DelAnswer4Work(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[Answer4Work]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strIdAnswer4Work">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strIdAnswer4Work)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsAnswer4WorkDA.GetSpecSQLObj();
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
//删除与表:[Answer4Work]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsAnswer4WorkBL.DelRecord(strIdAnswer4Work, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsAnswer4WorkBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdAnswer4Work, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objAnswer4WorkENS">源对象</param>
 /// <param name = "objAnswer4WorkENT">目标对象</param>
 public static void CopyTo(clsAnswer4WorkEN objAnswer4WorkENS, clsAnswer4WorkEN objAnswer4WorkENT)
{
try
{
objAnswer4WorkENT.IdAnswer4Work = objAnswer4WorkENS.IdAnswer4Work; //作业答案流水号
objAnswer4WorkENT.AnswerIndex = objAnswer4WorkENS.AnswerIndex; //问答序号
objAnswer4WorkENT.AnswerName = objAnswer4WorkENS.AnswerName; //问答名称
objAnswer4WorkENT.IsShow = objAnswer4WorkENS.IsShow; //是否启用
objAnswer4WorkENT.AnswerContent = objAnswer4WorkENS.AnswerContent; //答案内容
objAnswer4WorkENT.IsCorrect = objAnswer4WorkENS.IsCorrect; //是否正确
objAnswer4WorkENT.IdWork = objAnswer4WorkENS.IdWork; //作业流水号
objAnswer4WorkENT.QuestionResolve = objAnswer4WorkENS.QuestionResolve; //题目解析
objAnswer4WorkENT.UpdUser = objAnswer4WorkENS.UpdUser; //修改人
objAnswer4WorkENT.UpdDate = objAnswer4WorkENS.UpdDate; //修改日期
objAnswer4WorkENT.Memo = objAnswer4WorkENS.Memo; //备注
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
 /// <param name = "objAnswer4WorkEN">源简化对象</param>
 public static void SetUpdFlag(clsAnswer4WorkEN objAnswer4WorkEN)
{
try
{
objAnswer4WorkEN.ClearUpdateState();
   string strsfUpdFldSetStr = objAnswer4WorkEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conAnswer4Work.IdAnswer4Work, new clsStrCompareIgnoreCase())  ==  true)
{
objAnswer4WorkEN.IdAnswer4Work = objAnswer4WorkEN.IdAnswer4Work; //作业答案流水号
}
if (arrFldSet.Contains(conAnswer4Work.AnswerIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objAnswer4WorkEN.AnswerIndex = objAnswer4WorkEN.AnswerIndex; //问答序号
}
if (arrFldSet.Contains(conAnswer4Work.AnswerName, new clsStrCompareIgnoreCase())  ==  true)
{
objAnswer4WorkEN.AnswerName = objAnswer4WorkEN.AnswerName == "[null]" ? null :  objAnswer4WorkEN.AnswerName; //问答名称
}
if (arrFldSet.Contains(conAnswer4Work.IsShow, new clsStrCompareIgnoreCase())  ==  true)
{
objAnswer4WorkEN.IsShow = objAnswer4WorkEN.IsShow; //是否启用
}
if (arrFldSet.Contains(conAnswer4Work.AnswerContent, new clsStrCompareIgnoreCase())  ==  true)
{
objAnswer4WorkEN.AnswerContent = objAnswer4WorkEN.AnswerContent == "[null]" ? null :  objAnswer4WorkEN.AnswerContent; //答案内容
}
if (arrFldSet.Contains(conAnswer4Work.IsCorrect, new clsStrCompareIgnoreCase())  ==  true)
{
objAnswer4WorkEN.IsCorrect = objAnswer4WorkEN.IsCorrect; //是否正确
}
if (arrFldSet.Contains(conAnswer4Work.IdWork, new clsStrCompareIgnoreCase())  ==  true)
{
objAnswer4WorkEN.IdWork = objAnswer4WorkEN.IdWork; //作业流水号
}
if (arrFldSet.Contains(conAnswer4Work.QuestionResolve, new clsStrCompareIgnoreCase())  ==  true)
{
objAnswer4WorkEN.QuestionResolve = objAnswer4WorkEN.QuestionResolve == "[null]" ? null :  objAnswer4WorkEN.QuestionResolve; //题目解析
}
if (arrFldSet.Contains(conAnswer4Work.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objAnswer4WorkEN.UpdUser = objAnswer4WorkEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conAnswer4Work.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objAnswer4WorkEN.UpdDate = objAnswer4WorkEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conAnswer4Work.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objAnswer4WorkEN.Memo = objAnswer4WorkEN.Memo == "[null]" ? null :  objAnswer4WorkEN.Memo; //备注
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
 /// <param name = "objAnswer4WorkEN">源简化对象</param>
 public static void AccessFldValueNull(clsAnswer4WorkEN objAnswer4WorkEN)
{
try
{
if (objAnswer4WorkEN.AnswerName == "[null]") objAnswer4WorkEN.AnswerName = null; //问答名称
if (objAnswer4WorkEN.AnswerContent == "[null]") objAnswer4WorkEN.AnswerContent = null; //答案内容
if (objAnswer4WorkEN.QuestionResolve == "[null]") objAnswer4WorkEN.QuestionResolve = null; //题目解析
if (objAnswer4WorkEN.Memo == "[null]") objAnswer4WorkEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsAnswer4WorkEN objAnswer4WorkEN)
{
 Answer4WorkDA.CheckPropertyNew(objAnswer4WorkEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsAnswer4WorkEN objAnswer4WorkEN)
{
 Answer4WorkDA.CheckProperty4Condition(objAnswer4WorkEN);
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
if (clsAnswer4WorkBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsAnswer4WorkBL没有刷新缓存机制(clsAnswer4WorkBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdAnswer4Work");
//if (arrAnswer4WorkObjLstCache == null)
//{
//arrAnswer4WorkObjLstCache = Answer4WorkDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdAnswer4Work">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsAnswer4WorkEN GetObjByIdAnswer4WorkCache(string strIdAnswer4Work)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsAnswer4WorkEN._CurrTabName);
List<clsAnswer4WorkEN> arrAnswer4WorkObjLstCache = GetObjLstCache();
IEnumerable <clsAnswer4WorkEN> arrAnswer4WorkObjLst_Sel =
arrAnswer4WorkObjLstCache
.Where(x=> x.IdAnswer4Work == strIdAnswer4Work 
);
if (arrAnswer4WorkObjLst_Sel.Count() == 0)
{
   clsAnswer4WorkEN obj = clsAnswer4WorkBL.GetObjByIdAnswer4Work(strIdAnswer4Work);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrAnswer4WorkObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsAnswer4WorkEN> GetAllAnswer4WorkObjLstCache()
{
//获取缓存中的对象列表
List<clsAnswer4WorkEN> arrAnswer4WorkObjLstCache = GetObjLstCache(); 
return arrAnswer4WorkObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsAnswer4WorkEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsAnswer4WorkEN._CurrTabName);
List<clsAnswer4WorkEN> arrAnswer4WorkObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrAnswer4WorkObjLstCache;
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
string strKey = string.Format("{0}", clsAnswer4WorkEN._CurrTabName);
CacheHelper.Remove(strKey);
clsAnswer4WorkEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsAnswer4WorkEN._RefreshTimeLst.Count == 0) return "";
return clsAnswer4WorkEN._RefreshTimeLst[clsAnswer4WorkEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsAnswer4WorkBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsAnswer4WorkEN._CurrTabName);
CacheHelper.Remove(strKey);
clsAnswer4WorkEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsAnswer4WorkBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性


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
public static string Func(string strInFldName, string strOutFldName, string strIdAnswer4Work)
{
if (strInFldName != conAnswer4Work.IdAnswer4Work)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conAnswer4Work.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conAnswer4Work.AttributeName));
throw new Exception(strMsg);
}
var objAnswer4Work = clsAnswer4WorkBL.GetObjByIdAnswer4WorkCache(strIdAnswer4Work);
if (objAnswer4Work == null) return "";
return objAnswer4Work[strOutFldName].ToString();
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
int intRecCount = clsAnswer4WorkDA.GetRecCount(strTabName);
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
int intRecCount = clsAnswer4WorkDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsAnswer4WorkDA.GetRecCount();
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
int intRecCount = clsAnswer4WorkDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objAnswer4WorkCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsAnswer4WorkEN objAnswer4WorkCond)
{
List<clsAnswer4WorkEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsAnswer4WorkEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conAnswer4Work.AttributeName)
{
if (objAnswer4WorkCond.IsUpdated(strFldName) == false) continue;
if (objAnswer4WorkCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objAnswer4WorkCond[strFldName].ToString());
}
else
{
if (objAnswer4WorkCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objAnswer4WorkCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objAnswer4WorkCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objAnswer4WorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objAnswer4WorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objAnswer4WorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objAnswer4WorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objAnswer4WorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objAnswer4WorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objAnswer4WorkCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objAnswer4WorkCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objAnswer4WorkCond[strFldName]));
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
 List<string> arrList = clsAnswer4WorkDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = Answer4WorkDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = Answer4WorkDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = Answer4WorkDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsAnswer4WorkDA.SetFldValue(clsAnswer4WorkEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = Answer4WorkDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsAnswer4WorkDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsAnswer4WorkDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsAnswer4WorkDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[Answer4Work] "); 
 strCreateTabCode.Append(" ( "); 
 // /**作业答案流水号*/ 
 strCreateTabCode.Append(" IdAnswer4Work char(8) primary key, "); 
 // /**问答序号*/ 
 strCreateTabCode.Append(" AnswerIndex int Null, "); 
 // /**问答名称*/ 
 strCreateTabCode.Append(" AnswerName varchar(100) Null, "); 
 // /**是否启用*/ 
 strCreateTabCode.Append(" IsShow bit Null, "); 
 // /**答案内容*/ 
 strCreateTabCode.Append(" AnswerContent text Null, "); 
 // /**是否正确*/ 
 strCreateTabCode.Append(" IsCorrect bit Null, "); 
 // /**作业流水号*/ 
 strCreateTabCode.Append(" IdWork char(8) not Null, "); 
 // /**题目解析*/ 
 strCreateTabCode.Append(" QuestionResolve varchar(8000) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) not Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 作业答案(Answer4Work)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4Answer4Work : clsCommFun4BL
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
clsAnswer4WorkBL.ReFreshThisCache();
}
}

}