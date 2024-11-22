
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQuestionMarkStatusBL
 表名:QuestionMarkStatus(01120215)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:12:04
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:查询统计(QueryStatistics)
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
public static class  clsQuestionMarkStatusBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdCurrEduCls">表关键字</param>
 /// <returns>表对象</returns>
public static clsQuestionMarkStatusEN GetObj(this K_IdCurrEduCls_QuestionMarkStatus myKey)
{
clsQuestionMarkStatusEN objQuestionMarkStatusEN = clsQuestionMarkStatusBL.QuestionMarkStatusDA.GetObjByIdCurrEduCls(myKey.Value);
return objQuestionMarkStatusEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQuestionMarkStatusEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQuestionMarkStatusEN objQuestionMarkStatusEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objQuestionMarkStatusEN.IdCurrEduCls) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQuestionMarkStatusBL.IsExist(objQuestionMarkStatusEN.IdCurrEduCls) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQuestionMarkStatusEN.IdCurrEduCls, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsQuestionMarkStatusBL.QuestionMarkStatusDA.AddNewRecordBySQL2(objQuestionMarkStatusEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionMarkStatusBL.ReFreshCache();

if (clsQuestionMarkStatusBL.relatedActions != null)
{
clsQuestionMarkStatusBL.relatedActions.UpdRelaTabDate(objQuestionMarkStatusEN.IdCurrEduCls, "SetUpdDate");
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
public static bool AddRecordEx(this clsQuestionMarkStatusEN objQuestionMarkStatusEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsQuestionMarkStatusBL.IsExist(objQuestionMarkStatusEN.IdCurrEduCls))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objQuestionMarkStatusEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objQuestionMarkStatusEN.AddNewRecord();
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
 /// <param name = "objQuestionMarkStatusEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsQuestionMarkStatusEN objQuestionMarkStatusEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objQuestionMarkStatusEN.IdCurrEduCls) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQuestionMarkStatusBL.IsExist(objQuestionMarkStatusEN.IdCurrEduCls) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQuestionMarkStatusEN.IdCurrEduCls, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsQuestionMarkStatusBL.QuestionMarkStatusDA.AddNewRecordBySQL2WithReturnKey(objQuestionMarkStatusEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionMarkStatusBL.ReFreshCache();

if (clsQuestionMarkStatusBL.relatedActions != null)
{
clsQuestionMarkStatusBL.relatedActions.UpdRelaTabDate(objQuestionMarkStatusEN.IdCurrEduCls, "SetUpdDate");
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
 /// <param name = "objQuestionMarkStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionMarkStatusEN SetIdCurrEduCls(this clsQuestionMarkStatusEN objQuestionMarkStatusEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conQuestionMarkStatus.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conQuestionMarkStatus.IdCurrEduCls);
}
objQuestionMarkStatusEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionMarkStatusEN.dicFldComparisonOp.ContainsKey(conQuestionMarkStatus.IdCurrEduCls) == false)
{
objQuestionMarkStatusEN.dicFldComparisonOp.Add(conQuestionMarkStatus.IdCurrEduCls, strComparisonOp);
}
else
{
objQuestionMarkStatusEN.dicFldComparisonOp[conQuestionMarkStatus.IdCurrEduCls] = strComparisonOp;
}
}
return objQuestionMarkStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionMarkStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionMarkStatusEN SetSubmitedNum(this clsQuestionMarkStatusEN objQuestionMarkStatusEN, int intSubmitedNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intSubmitedNum, conQuestionMarkStatus.SubmitedNum);
objQuestionMarkStatusEN.SubmitedNum = intSubmitedNum; //提交作业数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionMarkStatusEN.dicFldComparisonOp.ContainsKey(conQuestionMarkStatus.SubmitedNum) == false)
{
objQuestionMarkStatusEN.dicFldComparisonOp.Add(conQuestionMarkStatus.SubmitedNum, strComparisonOp);
}
else
{
objQuestionMarkStatusEN.dicFldComparisonOp[conQuestionMarkStatus.SubmitedNum] = strComparisonOp;
}
}
return objQuestionMarkStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionMarkStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionMarkStatusEN SetAllQuestionNum(this clsQuestionMarkStatusEN objQuestionMarkStatusEN, int? intAllQuestionNum, string strComparisonOp="")
	{
objQuestionMarkStatusEN.AllQuestionNum = intAllQuestionNum; //所有题目数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionMarkStatusEN.dicFldComparisonOp.ContainsKey(conQuestionMarkStatus.AllQuestionNum) == false)
{
objQuestionMarkStatusEN.dicFldComparisonOp.Add(conQuestionMarkStatus.AllQuestionNum, strComparisonOp);
}
else
{
objQuestionMarkStatusEN.dicFldComparisonOp[conQuestionMarkStatus.AllQuestionNum] = strComparisonOp;
}
}
return objQuestionMarkStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionMarkStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionMarkStatusEN SetAllStuQuestionNum(this clsQuestionMarkStatusEN objQuestionMarkStatusEN, int? intAllStuQuestionNum, string strComparisonOp="")
	{
objQuestionMarkStatusEN.AllStuQuestionNum = intAllStuQuestionNum; //所有学生作业数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionMarkStatusEN.dicFldComparisonOp.ContainsKey(conQuestionMarkStatus.AllStuQuestionNum) == false)
{
objQuestionMarkStatusEN.dicFldComparisonOp.Add(conQuestionMarkStatus.AllStuQuestionNum, strComparisonOp);
}
else
{
objQuestionMarkStatusEN.dicFldComparisonOp[conQuestionMarkStatus.AllStuQuestionNum] = strComparisonOp;
}
}
return objQuestionMarkStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionMarkStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionMarkStatusEN SetMarkedNum(this clsQuestionMarkStatusEN objQuestionMarkStatusEN, int? intMarkedNum, string strComparisonOp="")
	{
objQuestionMarkStatusEN.MarkedNum = intMarkedNum; //已批改数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionMarkStatusEN.dicFldComparisonOp.ContainsKey(conQuestionMarkStatus.MarkedNum) == false)
{
objQuestionMarkStatusEN.dicFldComparisonOp.Add(conQuestionMarkStatus.MarkedNum, strComparisonOp);
}
else
{
objQuestionMarkStatusEN.dicFldComparisonOp[conQuestionMarkStatus.MarkedNum] = strComparisonOp;
}
}
return objQuestionMarkStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionMarkStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionMarkStatusEN SetNoMarkNum(this clsQuestionMarkStatusEN objQuestionMarkStatusEN, int? intNoMarkNum, string strComparisonOp="")
	{
objQuestionMarkStatusEN.NoMarkNum = intNoMarkNum; //未批改数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionMarkStatusEN.dicFldComparisonOp.ContainsKey(conQuestionMarkStatus.NoMarkNum) == false)
{
objQuestionMarkStatusEN.dicFldComparisonOp.Add(conQuestionMarkStatus.NoMarkNum, strComparisonOp);
}
else
{
objQuestionMarkStatusEN.dicFldComparisonOp[conQuestionMarkStatus.NoMarkNum] = strComparisonOp;
}
}
return objQuestionMarkStatusEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objQuestionMarkStatusEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsQuestionMarkStatusEN objQuestionMarkStatusEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objQuestionMarkStatusEN.CheckPropertyNew();
clsQuestionMarkStatusEN objQuestionMarkStatusCond = new clsQuestionMarkStatusEN();
string strCondition = objQuestionMarkStatusCond
.SetIdCurrEduCls(objQuestionMarkStatusEN.IdCurrEduCls, "=")
.GetCombineCondition();
objQuestionMarkStatusEN._IsCheckProperty = true;
bool bolIsExist = clsQuestionMarkStatusBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objQuestionMarkStatusEN.Update();
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
 /// <param name = "objQuestionMarkStatusEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQuestionMarkStatusEN objQuestionMarkStatusEN)
{
 if (string.IsNullOrEmpty(objQuestionMarkStatusEN.IdCurrEduCls) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQuestionMarkStatusBL.QuestionMarkStatusDA.UpdateBySql2(objQuestionMarkStatusEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionMarkStatusBL.ReFreshCache();

if (clsQuestionMarkStatusBL.relatedActions != null)
{
clsQuestionMarkStatusBL.relatedActions.UpdRelaTabDate(objQuestionMarkStatusEN.IdCurrEduCls, "SetUpdDate");
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
 /// <param name = "objQuestionMarkStatusEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQuestionMarkStatusEN objQuestionMarkStatusEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objQuestionMarkStatusEN.IdCurrEduCls) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQuestionMarkStatusBL.QuestionMarkStatusDA.UpdateBySql2(objQuestionMarkStatusEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionMarkStatusBL.ReFreshCache();

if (clsQuestionMarkStatusBL.relatedActions != null)
{
clsQuestionMarkStatusBL.relatedActions.UpdRelaTabDate(objQuestionMarkStatusEN.IdCurrEduCls, "SetUpdDate");
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
 /// <param name = "objQuestionMarkStatusEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQuestionMarkStatusEN objQuestionMarkStatusEN, string strWhereCond)
{
try
{
bool bolResult = clsQuestionMarkStatusBL.QuestionMarkStatusDA.UpdateBySqlWithCondition(objQuestionMarkStatusEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionMarkStatusBL.ReFreshCache();

if (clsQuestionMarkStatusBL.relatedActions != null)
{
clsQuestionMarkStatusBL.relatedActions.UpdRelaTabDate(objQuestionMarkStatusEN.IdCurrEduCls, "SetUpdDate");
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
 /// <param name = "objQuestionMarkStatusEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQuestionMarkStatusEN objQuestionMarkStatusEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsQuestionMarkStatusBL.QuestionMarkStatusDA.UpdateBySqlWithConditionTransaction(objQuestionMarkStatusEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionMarkStatusBL.ReFreshCache();

if (clsQuestionMarkStatusBL.relatedActions != null)
{
clsQuestionMarkStatusBL.relatedActions.UpdRelaTabDate(objQuestionMarkStatusEN.IdCurrEduCls, "SetUpdDate");
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
 /// <param name = "strIdCurrEduCls">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsQuestionMarkStatusEN objQuestionMarkStatusEN)
{
try
{
int intRecNum = clsQuestionMarkStatusBL.QuestionMarkStatusDA.DelRecord(objQuestionMarkStatusEN.IdCurrEduCls);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionMarkStatusBL.ReFreshCache();

if (clsQuestionMarkStatusBL.relatedActions != null)
{
clsQuestionMarkStatusBL.relatedActions.UpdRelaTabDate(objQuestionMarkStatusEN.IdCurrEduCls, "SetUpdDate");
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
 /// <param name = "objQuestionMarkStatusENS">源对象</param>
 /// <param name = "objQuestionMarkStatusENT">目标对象</param>
 public static void CopyTo(this clsQuestionMarkStatusEN objQuestionMarkStatusENS, clsQuestionMarkStatusEN objQuestionMarkStatusENT)
{
try
{
objQuestionMarkStatusENT.IdCurrEduCls = objQuestionMarkStatusENS.IdCurrEduCls; //教学班流水号
objQuestionMarkStatusENT.SubmitedNum = objQuestionMarkStatusENS.SubmitedNum; //提交作业数
objQuestionMarkStatusENT.AllQuestionNum = objQuestionMarkStatusENS.AllQuestionNum; //所有题目数
objQuestionMarkStatusENT.AllStuQuestionNum = objQuestionMarkStatusENS.AllStuQuestionNum; //所有学生作业数
objQuestionMarkStatusENT.MarkedNum = objQuestionMarkStatusENS.MarkedNum; //已批改数
objQuestionMarkStatusENT.NoMarkNum = objQuestionMarkStatusENS.NoMarkNum; //未批改数
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
 /// <param name = "objQuestionMarkStatusENS">源对象</param>
 /// <returns>目标对象=>clsQuestionMarkStatusEN:objQuestionMarkStatusENT</returns>
 public static clsQuestionMarkStatusEN CopyTo(this clsQuestionMarkStatusEN objQuestionMarkStatusENS)
{
try
{
 clsQuestionMarkStatusEN objQuestionMarkStatusENT = new clsQuestionMarkStatusEN()
{
IdCurrEduCls = objQuestionMarkStatusENS.IdCurrEduCls, //教学班流水号
SubmitedNum = objQuestionMarkStatusENS.SubmitedNum, //提交作业数
AllQuestionNum = objQuestionMarkStatusENS.AllQuestionNum, //所有题目数
AllStuQuestionNum = objQuestionMarkStatusENS.AllStuQuestionNum, //所有学生作业数
MarkedNum = objQuestionMarkStatusENS.MarkedNum, //已批改数
NoMarkNum = objQuestionMarkStatusENS.NoMarkNum, //未批改数
};
 return objQuestionMarkStatusENT;
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
public static void CheckPropertyNew(this clsQuestionMarkStatusEN objQuestionMarkStatusEN)
{
 clsQuestionMarkStatusBL.QuestionMarkStatusDA.CheckPropertyNew(objQuestionMarkStatusEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsQuestionMarkStatusEN objQuestionMarkStatusEN)
{
 clsQuestionMarkStatusBL.QuestionMarkStatusDA.CheckProperty4Condition(objQuestionMarkStatusEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQuestionMarkStatusEN objQuestionMarkStatusCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQuestionMarkStatusCond.IsUpdated(conQuestionMarkStatus.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objQuestionMarkStatusCond.dicFldComparisonOp[conQuestionMarkStatus.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionMarkStatus.IdCurrEduCls, objQuestionMarkStatusCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objQuestionMarkStatusCond.IsUpdated(conQuestionMarkStatus.SubmitedNum) == true)
{
string strComparisonOpSubmitedNum = objQuestionMarkStatusCond.dicFldComparisonOp[conQuestionMarkStatus.SubmitedNum];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionMarkStatus.SubmitedNum, objQuestionMarkStatusCond.SubmitedNum, strComparisonOpSubmitedNum);
}
if (objQuestionMarkStatusCond.IsUpdated(conQuestionMarkStatus.AllQuestionNum) == true)
{
string strComparisonOpAllQuestionNum = objQuestionMarkStatusCond.dicFldComparisonOp[conQuestionMarkStatus.AllQuestionNum];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionMarkStatus.AllQuestionNum, objQuestionMarkStatusCond.AllQuestionNum, strComparisonOpAllQuestionNum);
}
if (objQuestionMarkStatusCond.IsUpdated(conQuestionMarkStatus.AllStuQuestionNum) == true)
{
string strComparisonOpAllStuQuestionNum = objQuestionMarkStatusCond.dicFldComparisonOp[conQuestionMarkStatus.AllStuQuestionNum];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionMarkStatus.AllStuQuestionNum, objQuestionMarkStatusCond.AllStuQuestionNum, strComparisonOpAllStuQuestionNum);
}
if (objQuestionMarkStatusCond.IsUpdated(conQuestionMarkStatus.MarkedNum) == true)
{
string strComparisonOpMarkedNum = objQuestionMarkStatusCond.dicFldComparisonOp[conQuestionMarkStatus.MarkedNum];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionMarkStatus.MarkedNum, objQuestionMarkStatusCond.MarkedNum, strComparisonOpMarkedNum);
}
if (objQuestionMarkStatusCond.IsUpdated(conQuestionMarkStatus.NoMarkNum) == true)
{
string strComparisonOpNoMarkNum = objQuestionMarkStatusCond.dicFldComparisonOp[conQuestionMarkStatus.NoMarkNum];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionMarkStatus.NoMarkNum, objQuestionMarkStatusCond.NoMarkNum, strComparisonOpNoMarkNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_QuestionMarkStatus
{
public virtual bool UpdRelaTabDate(string strIdCurrEduCls, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 题目打分状态(QuestionMarkStatus)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsQuestionMarkStatusBL
{
public static RelatedActions_QuestionMarkStatus relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsQuestionMarkStatusDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsQuestionMarkStatusDA QuestionMarkStatusDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsQuestionMarkStatusDA();
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
 public clsQuestionMarkStatusBL()
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
if (string.IsNullOrEmpty(clsQuestionMarkStatusEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQuestionMarkStatusEN._ConnectString);
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
public static DataTable GetDataTable_QuestionMarkStatus(string strWhereCond)
{
DataTable objDT;
try
{
objDT = QuestionMarkStatusDA.GetDataTable_QuestionMarkStatus(strWhereCond);
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
objDT = QuestionMarkStatusDA.GetDataTable(strWhereCond);
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
objDT = QuestionMarkStatusDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = QuestionMarkStatusDA.GetDataTable(strWhereCond, strTabName);
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
objDT = QuestionMarkStatusDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = QuestionMarkStatusDA.GetDataTable_Top(objTopPara);
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
objDT = QuestionMarkStatusDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = QuestionMarkStatusDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = QuestionMarkStatusDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdCurrEduClsLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsQuestionMarkStatusEN> GetObjLstByIdCurrEduClsLst(List<string> arrIdCurrEduClsLst)
{
List<clsQuestionMarkStatusEN> arrObjLst = new List<clsQuestionMarkStatusEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdCurrEduClsLst, true);
 string strWhereCond = string.Format("IdCurrEduCls in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionMarkStatusEN objQuestionMarkStatusEN = new clsQuestionMarkStatusEN();
try
{
objQuestionMarkStatusEN.IdCurrEduCls = objRow[conQuestionMarkStatus.IdCurrEduCls].ToString().Trim(); //教学班流水号
objQuestionMarkStatusEN.SubmitedNum = Int32.Parse(objRow[conQuestionMarkStatus.SubmitedNum].ToString().Trim()); //提交作业数
objQuestionMarkStatusEN.AllQuestionNum = objRow[conQuestionMarkStatus.AllQuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionMarkStatus.AllQuestionNum].ToString().Trim()); //所有题目数
objQuestionMarkStatusEN.AllStuQuestionNum = objRow[conQuestionMarkStatus.AllStuQuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionMarkStatus.AllStuQuestionNum].ToString().Trim()); //所有学生作业数
objQuestionMarkStatusEN.MarkedNum = objRow[conQuestionMarkStatus.MarkedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionMarkStatus.MarkedNum].ToString().Trim()); //已批改数
objQuestionMarkStatusEN.NoMarkNum = objRow[conQuestionMarkStatus.NoMarkNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionMarkStatus.NoMarkNum].ToString().Trim()); //未批改数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionMarkStatusEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionMarkStatusEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdCurrEduClsLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsQuestionMarkStatusEN> GetObjLstByIdCurrEduClsLstCache(List<string> arrIdCurrEduClsLst)
{
string strKey = string.Format("{0}", clsQuestionMarkStatusEN._CurrTabName);
List<clsQuestionMarkStatusEN> arrQuestionMarkStatusObjLstCache = GetObjLstCache();
IEnumerable <clsQuestionMarkStatusEN> arrQuestionMarkStatusObjLst_Sel =
arrQuestionMarkStatusObjLstCache
.Where(x => arrIdCurrEduClsLst.Contains(x.IdCurrEduCls));
return arrQuestionMarkStatusObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQuestionMarkStatusEN> GetObjLst(string strWhereCond)
{
List<clsQuestionMarkStatusEN> arrObjLst = new List<clsQuestionMarkStatusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionMarkStatusEN objQuestionMarkStatusEN = new clsQuestionMarkStatusEN();
try
{
objQuestionMarkStatusEN.IdCurrEduCls = objRow[conQuestionMarkStatus.IdCurrEduCls].ToString().Trim(); //教学班流水号
objQuestionMarkStatusEN.SubmitedNum = Int32.Parse(objRow[conQuestionMarkStatus.SubmitedNum].ToString().Trim()); //提交作业数
objQuestionMarkStatusEN.AllQuestionNum = objRow[conQuestionMarkStatus.AllQuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionMarkStatus.AllQuestionNum].ToString().Trim()); //所有题目数
objQuestionMarkStatusEN.AllStuQuestionNum = objRow[conQuestionMarkStatus.AllStuQuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionMarkStatus.AllStuQuestionNum].ToString().Trim()); //所有学生作业数
objQuestionMarkStatusEN.MarkedNum = objRow[conQuestionMarkStatus.MarkedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionMarkStatus.MarkedNum].ToString().Trim()); //已批改数
objQuestionMarkStatusEN.NoMarkNum = objRow[conQuestionMarkStatus.NoMarkNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionMarkStatus.NoMarkNum].ToString().Trim()); //未批改数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionMarkStatusEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionMarkStatusEN);
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
public static List<clsQuestionMarkStatusEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsQuestionMarkStatusEN> arrObjLst = new List<clsQuestionMarkStatusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionMarkStatusEN objQuestionMarkStatusEN = new clsQuestionMarkStatusEN();
try
{
objQuestionMarkStatusEN.IdCurrEduCls = objRow[conQuestionMarkStatus.IdCurrEduCls].ToString().Trim(); //教学班流水号
objQuestionMarkStatusEN.SubmitedNum = Int32.Parse(objRow[conQuestionMarkStatus.SubmitedNum].ToString().Trim()); //提交作业数
objQuestionMarkStatusEN.AllQuestionNum = objRow[conQuestionMarkStatus.AllQuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionMarkStatus.AllQuestionNum].ToString().Trim()); //所有题目数
objQuestionMarkStatusEN.AllStuQuestionNum = objRow[conQuestionMarkStatus.AllStuQuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionMarkStatus.AllStuQuestionNum].ToString().Trim()); //所有学生作业数
objQuestionMarkStatusEN.MarkedNum = objRow[conQuestionMarkStatus.MarkedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionMarkStatus.MarkedNum].ToString().Trim()); //已批改数
objQuestionMarkStatusEN.NoMarkNum = objRow[conQuestionMarkStatus.NoMarkNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionMarkStatus.NoMarkNum].ToString().Trim()); //未批改数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionMarkStatusEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionMarkStatusEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objQuestionMarkStatusCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsQuestionMarkStatusEN> GetSubObjLstCache(clsQuestionMarkStatusEN objQuestionMarkStatusCond)
{
List<clsQuestionMarkStatusEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQuestionMarkStatusEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQuestionMarkStatus.AttributeName)
{
if (objQuestionMarkStatusCond.IsUpdated(strFldName) == false) continue;
if (objQuestionMarkStatusCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQuestionMarkStatusCond[strFldName].ToString());
}
else
{
if (objQuestionMarkStatusCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQuestionMarkStatusCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQuestionMarkStatusCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQuestionMarkStatusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQuestionMarkStatusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQuestionMarkStatusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQuestionMarkStatusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQuestionMarkStatusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQuestionMarkStatusCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQuestionMarkStatusCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQuestionMarkStatusCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQuestionMarkStatusCond[strFldName]));
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
public static List<clsQuestionMarkStatusEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsQuestionMarkStatusEN> arrObjLst = new List<clsQuestionMarkStatusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionMarkStatusEN objQuestionMarkStatusEN = new clsQuestionMarkStatusEN();
try
{
objQuestionMarkStatusEN.IdCurrEduCls = objRow[conQuestionMarkStatus.IdCurrEduCls].ToString().Trim(); //教学班流水号
objQuestionMarkStatusEN.SubmitedNum = Int32.Parse(objRow[conQuestionMarkStatus.SubmitedNum].ToString().Trim()); //提交作业数
objQuestionMarkStatusEN.AllQuestionNum = objRow[conQuestionMarkStatus.AllQuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionMarkStatus.AllQuestionNum].ToString().Trim()); //所有题目数
objQuestionMarkStatusEN.AllStuQuestionNum = objRow[conQuestionMarkStatus.AllStuQuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionMarkStatus.AllStuQuestionNum].ToString().Trim()); //所有学生作业数
objQuestionMarkStatusEN.MarkedNum = objRow[conQuestionMarkStatus.MarkedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionMarkStatus.MarkedNum].ToString().Trim()); //已批改数
objQuestionMarkStatusEN.NoMarkNum = objRow[conQuestionMarkStatus.NoMarkNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionMarkStatus.NoMarkNum].ToString().Trim()); //未批改数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionMarkStatusEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionMarkStatusEN);
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
public static List<clsQuestionMarkStatusEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsQuestionMarkStatusEN> arrObjLst = new List<clsQuestionMarkStatusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionMarkStatusEN objQuestionMarkStatusEN = new clsQuestionMarkStatusEN();
try
{
objQuestionMarkStatusEN.IdCurrEduCls = objRow[conQuestionMarkStatus.IdCurrEduCls].ToString().Trim(); //教学班流水号
objQuestionMarkStatusEN.SubmitedNum = Int32.Parse(objRow[conQuestionMarkStatus.SubmitedNum].ToString().Trim()); //提交作业数
objQuestionMarkStatusEN.AllQuestionNum = objRow[conQuestionMarkStatus.AllQuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionMarkStatus.AllQuestionNum].ToString().Trim()); //所有题目数
objQuestionMarkStatusEN.AllStuQuestionNum = objRow[conQuestionMarkStatus.AllStuQuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionMarkStatus.AllStuQuestionNum].ToString().Trim()); //所有学生作业数
objQuestionMarkStatusEN.MarkedNum = objRow[conQuestionMarkStatus.MarkedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionMarkStatus.MarkedNum].ToString().Trim()); //已批改数
objQuestionMarkStatusEN.NoMarkNum = objRow[conQuestionMarkStatus.NoMarkNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionMarkStatus.NoMarkNum].ToString().Trim()); //未批改数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionMarkStatusEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionMarkStatusEN);
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
List<clsQuestionMarkStatusEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsQuestionMarkStatusEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQuestionMarkStatusEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsQuestionMarkStatusEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsQuestionMarkStatusEN> arrObjLst = new List<clsQuestionMarkStatusEN>(); 
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
	clsQuestionMarkStatusEN objQuestionMarkStatusEN = new clsQuestionMarkStatusEN();
try
{
objQuestionMarkStatusEN.IdCurrEduCls = objRow[conQuestionMarkStatus.IdCurrEduCls].ToString().Trim(); //教学班流水号
objQuestionMarkStatusEN.SubmitedNum = Int32.Parse(objRow[conQuestionMarkStatus.SubmitedNum].ToString().Trim()); //提交作业数
objQuestionMarkStatusEN.AllQuestionNum = objRow[conQuestionMarkStatus.AllQuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionMarkStatus.AllQuestionNum].ToString().Trim()); //所有题目数
objQuestionMarkStatusEN.AllStuQuestionNum = objRow[conQuestionMarkStatus.AllStuQuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionMarkStatus.AllStuQuestionNum].ToString().Trim()); //所有学生作业数
objQuestionMarkStatusEN.MarkedNum = objRow[conQuestionMarkStatus.MarkedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionMarkStatus.MarkedNum].ToString().Trim()); //已批改数
objQuestionMarkStatusEN.NoMarkNum = objRow[conQuestionMarkStatus.NoMarkNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionMarkStatus.NoMarkNum].ToString().Trim()); //未批改数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionMarkStatusEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionMarkStatusEN);
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
public static List<clsQuestionMarkStatusEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsQuestionMarkStatusEN> arrObjLst = new List<clsQuestionMarkStatusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionMarkStatusEN objQuestionMarkStatusEN = new clsQuestionMarkStatusEN();
try
{
objQuestionMarkStatusEN.IdCurrEduCls = objRow[conQuestionMarkStatus.IdCurrEduCls].ToString().Trim(); //教学班流水号
objQuestionMarkStatusEN.SubmitedNum = Int32.Parse(objRow[conQuestionMarkStatus.SubmitedNum].ToString().Trim()); //提交作业数
objQuestionMarkStatusEN.AllQuestionNum = objRow[conQuestionMarkStatus.AllQuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionMarkStatus.AllQuestionNum].ToString().Trim()); //所有题目数
objQuestionMarkStatusEN.AllStuQuestionNum = objRow[conQuestionMarkStatus.AllStuQuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionMarkStatus.AllStuQuestionNum].ToString().Trim()); //所有学生作业数
objQuestionMarkStatusEN.MarkedNum = objRow[conQuestionMarkStatus.MarkedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionMarkStatus.MarkedNum].ToString().Trim()); //已批改数
objQuestionMarkStatusEN.NoMarkNum = objRow[conQuestionMarkStatus.NoMarkNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionMarkStatus.NoMarkNum].ToString().Trim()); //未批改数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionMarkStatusEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionMarkStatusEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsQuestionMarkStatusEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsQuestionMarkStatusEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsQuestionMarkStatusEN> arrObjLst = new List<clsQuestionMarkStatusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionMarkStatusEN objQuestionMarkStatusEN = new clsQuestionMarkStatusEN();
try
{
objQuestionMarkStatusEN.IdCurrEduCls = objRow[conQuestionMarkStatus.IdCurrEduCls].ToString().Trim(); //教学班流水号
objQuestionMarkStatusEN.SubmitedNum = Int32.Parse(objRow[conQuestionMarkStatus.SubmitedNum].ToString().Trim()); //提交作业数
objQuestionMarkStatusEN.AllQuestionNum = objRow[conQuestionMarkStatus.AllQuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionMarkStatus.AllQuestionNum].ToString().Trim()); //所有题目数
objQuestionMarkStatusEN.AllStuQuestionNum = objRow[conQuestionMarkStatus.AllStuQuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionMarkStatus.AllStuQuestionNum].ToString().Trim()); //所有学生作业数
objQuestionMarkStatusEN.MarkedNum = objRow[conQuestionMarkStatus.MarkedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionMarkStatus.MarkedNum].ToString().Trim()); //已批改数
objQuestionMarkStatusEN.NoMarkNum = objRow[conQuestionMarkStatus.NoMarkNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionMarkStatus.NoMarkNum].ToString().Trim()); //未批改数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionMarkStatusEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionMarkStatusEN);
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
public static List<clsQuestionMarkStatusEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsQuestionMarkStatusEN> arrObjLst = new List<clsQuestionMarkStatusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionMarkStatusEN objQuestionMarkStatusEN = new clsQuestionMarkStatusEN();
try
{
objQuestionMarkStatusEN.IdCurrEduCls = objRow[conQuestionMarkStatus.IdCurrEduCls].ToString().Trim(); //教学班流水号
objQuestionMarkStatusEN.SubmitedNum = Int32.Parse(objRow[conQuestionMarkStatus.SubmitedNum].ToString().Trim()); //提交作业数
objQuestionMarkStatusEN.AllQuestionNum = objRow[conQuestionMarkStatus.AllQuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionMarkStatus.AllQuestionNum].ToString().Trim()); //所有题目数
objQuestionMarkStatusEN.AllStuQuestionNum = objRow[conQuestionMarkStatus.AllStuQuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionMarkStatus.AllStuQuestionNum].ToString().Trim()); //所有学生作业数
objQuestionMarkStatusEN.MarkedNum = objRow[conQuestionMarkStatus.MarkedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionMarkStatus.MarkedNum].ToString().Trim()); //已批改数
objQuestionMarkStatusEN.NoMarkNum = objRow[conQuestionMarkStatus.NoMarkNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionMarkStatus.NoMarkNum].ToString().Trim()); //未批改数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionMarkStatusEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionMarkStatusEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsQuestionMarkStatusEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsQuestionMarkStatusEN> arrObjLst = new List<clsQuestionMarkStatusEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionMarkStatusEN objQuestionMarkStatusEN = new clsQuestionMarkStatusEN();
try
{
objQuestionMarkStatusEN.IdCurrEduCls = objRow[conQuestionMarkStatus.IdCurrEduCls].ToString().Trim(); //教学班流水号
objQuestionMarkStatusEN.SubmitedNum = Int32.Parse(objRow[conQuestionMarkStatus.SubmitedNum].ToString().Trim()); //提交作业数
objQuestionMarkStatusEN.AllQuestionNum = objRow[conQuestionMarkStatus.AllQuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionMarkStatus.AllQuestionNum].ToString().Trim()); //所有题目数
objQuestionMarkStatusEN.AllStuQuestionNum = objRow[conQuestionMarkStatus.AllStuQuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionMarkStatus.AllStuQuestionNum].ToString().Trim()); //所有学生作业数
objQuestionMarkStatusEN.MarkedNum = objRow[conQuestionMarkStatus.MarkedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionMarkStatus.MarkedNum].ToString().Trim()); //已批改数
objQuestionMarkStatusEN.NoMarkNum = objRow[conQuestionMarkStatus.NoMarkNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionMarkStatus.NoMarkNum].ToString().Trim()); //未批改数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionMarkStatusEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionMarkStatusEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objQuestionMarkStatusEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQuestionMarkStatus(ref clsQuestionMarkStatusEN objQuestionMarkStatusEN)
{
bool bolResult = QuestionMarkStatusDA.GetQuestionMarkStatus(ref objQuestionMarkStatusEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdCurrEduCls">表关键字</param>
 /// <returns>表对象</returns>
public static clsQuestionMarkStatusEN GetObjByIdCurrEduCls(string strIdCurrEduCls)
{
if (strIdCurrEduCls.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdCurrEduCls]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdCurrEduCls]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsQuestionMarkStatusEN objQuestionMarkStatusEN = QuestionMarkStatusDA.GetObjByIdCurrEduCls(strIdCurrEduCls);
return objQuestionMarkStatusEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsQuestionMarkStatusEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsQuestionMarkStatusEN objQuestionMarkStatusEN = QuestionMarkStatusDA.GetFirstObj(strWhereCond);
 return objQuestionMarkStatusEN;
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
public static clsQuestionMarkStatusEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsQuestionMarkStatusEN objQuestionMarkStatusEN = QuestionMarkStatusDA.GetObjByDataRow(objRow);
 return objQuestionMarkStatusEN;
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
public static clsQuestionMarkStatusEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsQuestionMarkStatusEN objQuestionMarkStatusEN = QuestionMarkStatusDA.GetObjByDataRow(objRow);
 return objQuestionMarkStatusEN;
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
 /// <param name = "strIdCurrEduCls">所给的关键字</param>
 /// <param name = "lstQuestionMarkStatusObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQuestionMarkStatusEN GetObjByIdCurrEduClsFromList(string strIdCurrEduCls, List<clsQuestionMarkStatusEN> lstQuestionMarkStatusObjLst)
{
foreach (clsQuestionMarkStatusEN objQuestionMarkStatusEN in lstQuestionMarkStatusObjLst)
{
if (objQuestionMarkStatusEN.IdCurrEduCls == strIdCurrEduCls)
{
return objQuestionMarkStatusEN;
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
 string strIdCurrEduCls;
 try
 {
 strIdCurrEduCls = new clsQuestionMarkStatusDA().GetFirstID(strWhereCond);
 return strIdCurrEduCls;
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
 arrList = QuestionMarkStatusDA.GetID(strWhereCond);
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
bool bolIsExist = QuestionMarkStatusDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdCurrEduCls">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdCurrEduCls)
{
if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdCurrEduCls]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = QuestionMarkStatusDA.IsExist(strIdCurrEduCls);
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
 bolIsExist = clsQuestionMarkStatusDA.IsExistTable();
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
 bolIsExist = QuestionMarkStatusDA.IsExistTable(strTabName);
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
 /// <param name = "objQuestionMarkStatusEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsQuestionMarkStatusEN objQuestionMarkStatusEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objQuestionMarkStatusEN.IdCurrEduCls) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQuestionMarkStatusBL.IsExist(objQuestionMarkStatusEN.IdCurrEduCls) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQuestionMarkStatusEN.IdCurrEduCls, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = QuestionMarkStatusDA.AddNewRecordBySQL2(objQuestionMarkStatusEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionMarkStatusBL.ReFreshCache();

if (clsQuestionMarkStatusBL.relatedActions != null)
{
clsQuestionMarkStatusBL.relatedActions.UpdRelaTabDate(objQuestionMarkStatusEN.IdCurrEduCls, "SetUpdDate");
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
 /// <param name = "objQuestionMarkStatusEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsQuestionMarkStatusEN objQuestionMarkStatusEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objQuestionMarkStatusEN.IdCurrEduCls) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQuestionMarkStatusBL.IsExist(objQuestionMarkStatusEN.IdCurrEduCls) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQuestionMarkStatusEN.IdCurrEduCls, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = QuestionMarkStatusDA.AddNewRecordBySQL2WithReturnKey(objQuestionMarkStatusEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionMarkStatusBL.ReFreshCache();

if (clsQuestionMarkStatusBL.relatedActions != null)
{
clsQuestionMarkStatusBL.relatedActions.UpdRelaTabDate(objQuestionMarkStatusEN.IdCurrEduCls, "SetUpdDate");
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
 /// <param name = "objQuestionMarkStatusEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsQuestionMarkStatusEN objQuestionMarkStatusEN)
{
try
{
bool bolResult = QuestionMarkStatusDA.Update(objQuestionMarkStatusEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionMarkStatusBL.ReFreshCache();

if (clsQuestionMarkStatusBL.relatedActions != null)
{
clsQuestionMarkStatusBL.relatedActions.UpdRelaTabDate(objQuestionMarkStatusEN.IdCurrEduCls, "SetUpdDate");
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
 /// <param name = "objQuestionMarkStatusEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsQuestionMarkStatusEN objQuestionMarkStatusEN)
{
 if (string.IsNullOrEmpty(objQuestionMarkStatusEN.IdCurrEduCls) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = QuestionMarkStatusDA.UpdateBySql2(objQuestionMarkStatusEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionMarkStatusBL.ReFreshCache();

if (clsQuestionMarkStatusBL.relatedActions != null)
{
clsQuestionMarkStatusBL.relatedActions.UpdRelaTabDate(objQuestionMarkStatusEN.IdCurrEduCls, "SetUpdDate");
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
 /// <param name = "strIdCurrEduCls">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strIdCurrEduCls)
{
try
{
 clsQuestionMarkStatusEN objQuestionMarkStatusEN = clsQuestionMarkStatusBL.GetObjByIdCurrEduCls(strIdCurrEduCls);

if (clsQuestionMarkStatusBL.relatedActions != null)
{
clsQuestionMarkStatusBL.relatedActions.UpdRelaTabDate(objQuestionMarkStatusEN.IdCurrEduCls, "SetUpdDate");
}
if (objQuestionMarkStatusEN != null)
{
int intRecNum = QuestionMarkStatusDA.DelRecord(strIdCurrEduCls);
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
/// <param name="strIdCurrEduCls">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strIdCurrEduCls )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQuestionMarkStatusDA.GetSpecSQLObj();
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
//删除与表:[QuestionMarkStatus]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conQuestionMarkStatus.IdCurrEduCls,
//strIdCurrEduCls);
//        clsQuestionMarkStatusBL.DelQuestionMarkStatussByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQuestionMarkStatusBL.DelRecord(strIdCurrEduCls, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQuestionMarkStatusBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strIdCurrEduCls">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strIdCurrEduCls, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsQuestionMarkStatusBL.relatedActions != null)
{
clsQuestionMarkStatusBL.relatedActions.UpdRelaTabDate(strIdCurrEduCls, "UpdRelaTabDate");
}
bool bolResult = QuestionMarkStatusDA.DelRecord(strIdCurrEduCls,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdCurrEduClsLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelQuestionMarkStatuss(List<string> arrIdCurrEduClsLst)
{
if (arrIdCurrEduClsLst.Count == 0) return 0;
try
{
if (clsQuestionMarkStatusBL.relatedActions != null)
{
foreach (var strIdCurrEduCls in arrIdCurrEduClsLst)
{
clsQuestionMarkStatusBL.relatedActions.UpdRelaTabDate(strIdCurrEduCls, "UpdRelaTabDate");
}
}
int intDelRecNum = QuestionMarkStatusDA.DelQuestionMarkStatus(arrIdCurrEduClsLst);
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
public static int DelQuestionMarkStatussByCond(string strWhereCond)
{
try
{
if (clsQuestionMarkStatusBL.relatedActions != null)
{
List<string> arrIdCurrEduCls = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdCurrEduCls in arrIdCurrEduCls)
{
clsQuestionMarkStatusBL.relatedActions.UpdRelaTabDate(strIdCurrEduCls, "UpdRelaTabDate");
}
}
int intRecNum = QuestionMarkStatusDA.DelQuestionMarkStatus(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[QuestionMarkStatus]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strIdCurrEduCls">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQuestionMarkStatusDA.GetSpecSQLObj();
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
//删除与表:[QuestionMarkStatus]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQuestionMarkStatusBL.DelRecord(strIdCurrEduCls, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQuestionMarkStatusBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objQuestionMarkStatusENS">源对象</param>
 /// <param name = "objQuestionMarkStatusENT">目标对象</param>
 public static void CopyTo(clsQuestionMarkStatusEN objQuestionMarkStatusENS, clsQuestionMarkStatusEN objQuestionMarkStatusENT)
{
try
{
objQuestionMarkStatusENT.IdCurrEduCls = objQuestionMarkStatusENS.IdCurrEduCls; //教学班流水号
objQuestionMarkStatusENT.SubmitedNum = objQuestionMarkStatusENS.SubmitedNum; //提交作业数
objQuestionMarkStatusENT.AllQuestionNum = objQuestionMarkStatusENS.AllQuestionNum; //所有题目数
objQuestionMarkStatusENT.AllStuQuestionNum = objQuestionMarkStatusENS.AllStuQuestionNum; //所有学生作业数
objQuestionMarkStatusENT.MarkedNum = objQuestionMarkStatusENS.MarkedNum; //已批改数
objQuestionMarkStatusENT.NoMarkNum = objQuestionMarkStatusENS.NoMarkNum; //未批改数
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
 /// <param name = "objQuestionMarkStatusEN">源简化对象</param>
 public static void SetUpdFlag(clsQuestionMarkStatusEN objQuestionMarkStatusEN)
{
try
{
objQuestionMarkStatusEN.ClearUpdateState();
   string strsfUpdFldSetStr = objQuestionMarkStatusEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conQuestionMarkStatus.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionMarkStatusEN.IdCurrEduCls = objQuestionMarkStatusEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conQuestionMarkStatus.SubmitedNum, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionMarkStatusEN.SubmitedNum = objQuestionMarkStatusEN.SubmitedNum; //提交作业数
}
if (arrFldSet.Contains(conQuestionMarkStatus.AllQuestionNum, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionMarkStatusEN.AllQuestionNum = objQuestionMarkStatusEN.AllQuestionNum; //所有题目数
}
if (arrFldSet.Contains(conQuestionMarkStatus.AllStuQuestionNum, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionMarkStatusEN.AllStuQuestionNum = objQuestionMarkStatusEN.AllStuQuestionNum; //所有学生作业数
}
if (arrFldSet.Contains(conQuestionMarkStatus.MarkedNum, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionMarkStatusEN.MarkedNum = objQuestionMarkStatusEN.MarkedNum; //已批改数
}
if (arrFldSet.Contains(conQuestionMarkStatus.NoMarkNum, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionMarkStatusEN.NoMarkNum = objQuestionMarkStatusEN.NoMarkNum; //未批改数
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
 /// <param name = "objQuestionMarkStatusEN">源简化对象</param>
 public static void AccessFldValueNull(clsQuestionMarkStatusEN objQuestionMarkStatusEN)
{
try
{
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
public static void CheckPropertyNew(clsQuestionMarkStatusEN objQuestionMarkStatusEN)
{
 QuestionMarkStatusDA.CheckPropertyNew(objQuestionMarkStatusEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsQuestionMarkStatusEN objQuestionMarkStatusEN)
{
 QuestionMarkStatusDA.CheckProperty4Condition(objQuestionMarkStatusEN);
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
if (clsQuestionMarkStatusBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionMarkStatusBL没有刷新缓存机制(clsQuestionMarkStatusBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdCurrEduCls");
//if (arrQuestionMarkStatusObjLstCache == null)
//{
//arrQuestionMarkStatusObjLstCache = QuestionMarkStatusDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdCurrEduCls">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQuestionMarkStatusEN GetObjByIdCurrEduClsCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsQuestionMarkStatusEN._CurrTabName);
List<clsQuestionMarkStatusEN> arrQuestionMarkStatusObjLstCache = GetObjLstCache();
IEnumerable <clsQuestionMarkStatusEN> arrQuestionMarkStatusObjLst_Sel =
arrQuestionMarkStatusObjLstCache
.Where(x=> x.IdCurrEduCls == strIdCurrEduCls 
);
if (arrQuestionMarkStatusObjLst_Sel.Count() == 0)
{
   clsQuestionMarkStatusEN obj = clsQuestionMarkStatusBL.GetObjByIdCurrEduCls(strIdCurrEduCls);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrQuestionMarkStatusObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQuestionMarkStatusEN> GetAllQuestionMarkStatusObjLstCache()
{
//获取缓存中的对象列表
List<clsQuestionMarkStatusEN> arrQuestionMarkStatusObjLstCache = GetObjLstCache(); 
return arrQuestionMarkStatusObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQuestionMarkStatusEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsQuestionMarkStatusEN._CurrTabName);
List<clsQuestionMarkStatusEN> arrQuestionMarkStatusObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrQuestionMarkStatusObjLstCache;
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
string strKey = string.Format("{0}", clsQuestionMarkStatusEN._CurrTabName);
CacheHelper.Remove(strKey);
clsQuestionMarkStatusEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsQuestionMarkStatusEN._RefreshTimeLst.Count == 0) return "";
return clsQuestionMarkStatusEN._RefreshTimeLst[clsQuestionMarkStatusEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsQuestionMarkStatusBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQuestionMarkStatusEN._CurrTabName);
CacheHelper.Remove(strKey);
clsQuestionMarkStatusEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsQuestionMarkStatusBL.objCommFun4BL.ReFreshCache();
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
public static string Func(string strInFldName, string strOutFldName, string strIdCurrEduCls)
{
if (strInFldName != conQuestionMarkStatus.IdCurrEduCls)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conQuestionMarkStatus.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conQuestionMarkStatus.AttributeName));
throw new Exception(strMsg);
}
var objQuestionMarkStatus = clsQuestionMarkStatusBL.GetObjByIdCurrEduClsCache(strIdCurrEduCls);
if (objQuestionMarkStatus == null) return "";
return objQuestionMarkStatus[strOutFldName].ToString();
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
int intRecCount = clsQuestionMarkStatusDA.GetRecCount(strTabName);
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
int intRecCount = clsQuestionMarkStatusDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsQuestionMarkStatusDA.GetRecCount();
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
int intRecCount = clsQuestionMarkStatusDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objQuestionMarkStatusCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsQuestionMarkStatusEN objQuestionMarkStatusCond)
{
List<clsQuestionMarkStatusEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQuestionMarkStatusEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQuestionMarkStatus.AttributeName)
{
if (objQuestionMarkStatusCond.IsUpdated(strFldName) == false) continue;
if (objQuestionMarkStatusCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQuestionMarkStatusCond[strFldName].ToString());
}
else
{
if (objQuestionMarkStatusCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQuestionMarkStatusCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQuestionMarkStatusCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQuestionMarkStatusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQuestionMarkStatusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQuestionMarkStatusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQuestionMarkStatusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQuestionMarkStatusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQuestionMarkStatusCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQuestionMarkStatusCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQuestionMarkStatusCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQuestionMarkStatusCond[strFldName]));
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
 List<string> arrList = clsQuestionMarkStatusDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = QuestionMarkStatusDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = QuestionMarkStatusDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = QuestionMarkStatusDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsQuestionMarkStatusDA.SetFldValue(clsQuestionMarkStatusEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = QuestionMarkStatusDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsQuestionMarkStatusDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsQuestionMarkStatusDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsQuestionMarkStatusDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[QuestionMarkStatus] "); 
 strCreateTabCode.Append(" ( "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) primary key, "); 
 // /**提交作业数*/ 
 strCreateTabCode.Append(" SubmitedNum int not Null, "); 
 // /**所有题目数*/ 
 strCreateTabCode.Append(" AllQuestionNum int Null, "); 
 // /**所有学生作业数*/ 
 strCreateTabCode.Append(" AllStuQuestionNum int Null, "); 
 // /**已批改数*/ 
 strCreateTabCode.Append(" MarkedNum int Null, "); 
 // /**未批改数*/ 
 strCreateTabCode.Append(" NoMarkNum int Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 题目打分状态(QuestionMarkStatus)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4QuestionMarkStatus : clsCommFun4BL
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
clsQuestionMarkStatusBL.ReFreshThisCache();
}
}

}