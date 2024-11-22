
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewpointAppraiseBL
 表名:ViewpointAppraise(01120599)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:15:09
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文(GradEduPaper)
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
public static class  clsViewpointAppraiseBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngViewpointAppraiseId">表关键字</param>
 /// <returns>表对象</returns>
public static clsViewpointAppraiseEN GetObj(this K_ViewpointAppraiseId_ViewpointAppraise myKey)
{
clsViewpointAppraiseEN objViewpointAppraiseEN = clsViewpointAppraiseBL.ViewpointAppraiseDA.GetObjByViewpointAppraiseId(myKey.Value);
return objViewpointAppraiseEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objViewpointAppraiseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsViewpointAppraiseEN objViewpointAppraiseEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objViewpointAppraiseEN) == false)
{
var strMsg = string.Format("记录已经存在!观点评论Id = [{0}],观点Id = [{1}]的数据已经存在!(in clsViewpointAppraiseBL.AddNewRecord)", objViewpointAppraiseEN.ViewpointAppraiseId,objViewpointAppraiseEN.ViewpointId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsViewpointAppraiseBL.ViewpointAppraiseDA.AddNewRecordBySQL2(objViewpointAppraiseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewpointAppraiseBL.ReFreshCache();

if (clsViewpointAppraiseBL.relatedActions != null)
{
clsViewpointAppraiseBL.relatedActions.UpdRelaTabDate(objViewpointAppraiseEN.ViewpointAppraiseId, "SetUpdDate");
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
public static bool AddRecordEx(this clsViewpointAppraiseEN objViewpointAppraiseEN, bool bolIsNeedCheckUniqueness = true)
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
objViewpointAppraiseEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objViewpointAppraiseEN.CheckUniqueness() == false)
{
strMsg = string.Format("(观点评论Id(ViewpointAppraiseId)=[{0}],观点Id(ViewpointId)=[{1}])已经存在,不能重复!", objViewpointAppraiseEN.ViewpointAppraiseId, objViewpointAppraiseEN.ViewpointId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objViewpointAppraiseEN.AddNewRecord();
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
 /// <param name = "objViewpointAppraiseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsViewpointAppraiseEN objViewpointAppraiseEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objViewpointAppraiseEN) == false)
{
var strMsg = string.Format("记录已经存在!观点评论Id = [{0}],观点Id = [{1}]的数据已经存在!(in clsViewpointAppraiseBL.AddNewRecordWithReturnKey)", objViewpointAppraiseEN.ViewpointAppraiseId,objViewpointAppraiseEN.ViewpointId);
throw new Exception(strMsg);
}
try
{
string strKey = clsViewpointAppraiseBL.ViewpointAppraiseDA.AddNewRecordBySQL2WithReturnKey(objViewpointAppraiseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewpointAppraiseBL.ReFreshCache();

if (clsViewpointAppraiseBL.relatedActions != null)
{
clsViewpointAppraiseBL.relatedActions.UpdRelaTabDate(objViewpointAppraiseEN.ViewpointAppraiseId, "SetUpdDate");
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
 /// <param name = "objViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewpointAppraiseEN SetViewpointAppraiseId(this clsViewpointAppraiseEN objViewpointAppraiseEN, long lngViewpointAppraiseId, string strComparisonOp="")
	{
objViewpointAppraiseEN.ViewpointAppraiseId = lngViewpointAppraiseId; //观点评论Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(conViewpointAppraise.ViewpointAppraiseId) == false)
{
objViewpointAppraiseEN.dicFldComparisonOp.Add(conViewpointAppraise.ViewpointAppraiseId, strComparisonOp);
}
else
{
objViewpointAppraiseEN.dicFldComparisonOp[conViewpointAppraise.ViewpointAppraiseId] = strComparisonOp;
}
}
return objViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewpointAppraiseEN SetViewpointId(this clsViewpointAppraiseEN objViewpointAppraiseEN, string strViewpointId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewpointId, 8, conViewpointAppraise.ViewpointId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewpointId, 8, conViewpointAppraise.ViewpointId);
}
objViewpointAppraiseEN.ViewpointId = strViewpointId; //观点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(conViewpointAppraise.ViewpointId) == false)
{
objViewpointAppraiseEN.dicFldComparisonOp.Add(conViewpointAppraise.ViewpointId, strComparisonOp);
}
else
{
objViewpointAppraiseEN.dicFldComparisonOp[conViewpointAppraise.ViewpointId] = strComparisonOp;
}
}
return objViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewpointAppraiseEN SetAppraiseContent(this clsViewpointAppraiseEN objViewpointAppraiseEN, string strAppraiseContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAppraiseContent, 2000, conViewpointAppraise.AppraiseContent);
}
objViewpointAppraiseEN.AppraiseContent = strAppraiseContent; //评议内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(conViewpointAppraise.AppraiseContent) == false)
{
objViewpointAppraiseEN.dicFldComparisonOp.Add(conViewpointAppraise.AppraiseContent, strComparisonOp);
}
else
{
objViewpointAppraiseEN.dicFldComparisonOp[conViewpointAppraise.AppraiseContent] = strComparisonOp;
}
}
return objViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewpointAppraiseEN SetUpdDate(this clsViewpointAppraiseEN objViewpointAppraiseEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conViewpointAppraise.UpdDate);
}
objViewpointAppraiseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(conViewpointAppraise.UpdDate) == false)
{
objViewpointAppraiseEN.dicFldComparisonOp.Add(conViewpointAppraise.UpdDate, strComparisonOp);
}
else
{
objViewpointAppraiseEN.dicFldComparisonOp[conViewpointAppraise.UpdDate] = strComparisonOp;
}
}
return objViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewpointAppraiseEN SetMemo(this clsViewpointAppraiseEN objViewpointAppraiseEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conViewpointAppraise.Memo);
}
objViewpointAppraiseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(conViewpointAppraise.Memo) == false)
{
objViewpointAppraiseEN.dicFldComparisonOp.Add(conViewpointAppraise.Memo, strComparisonOp);
}
else
{
objViewpointAppraiseEN.dicFldComparisonOp[conViewpointAppraise.Memo] = strComparisonOp;
}
}
return objViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewpointAppraiseEN SetUpdUser(this clsViewpointAppraiseEN objViewpointAppraiseEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conViewpointAppraise.UpdUser);
}
objViewpointAppraiseEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(conViewpointAppraise.UpdUser) == false)
{
objViewpointAppraiseEN.dicFldComparisonOp.Add(conViewpointAppraise.UpdUser, strComparisonOp);
}
else
{
objViewpointAppraiseEN.dicFldComparisonOp[conViewpointAppraise.UpdUser] = strComparisonOp;
}
}
return objViewpointAppraiseEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objViewpointAppraiseEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsViewpointAppraiseEN objViewpointAppraiseEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objViewpointAppraiseEN.CheckPropertyNew();
clsViewpointAppraiseEN objViewpointAppraiseCond = new clsViewpointAppraiseEN();
string strCondition = objViewpointAppraiseCond
.SetViewpointAppraiseId(objViewpointAppraiseEN.ViewpointAppraiseId, "<>")
.SetViewpointAppraiseId(objViewpointAppraiseEN.ViewpointAppraiseId, "=")
.SetViewpointId(objViewpointAppraiseEN.ViewpointId, "=")
.GetCombineCondition();
objViewpointAppraiseEN._IsCheckProperty = true;
bool bolIsExist = clsViewpointAppraiseBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(ViewpointAppraiseId_ViewpointId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objViewpointAppraiseEN.Update();
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
 /// <param name = "objViewpointAppraise">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsViewpointAppraiseEN objViewpointAppraise)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsViewpointAppraiseEN objViewpointAppraiseCond = new clsViewpointAppraiseEN();
string strCondition = objViewpointAppraiseCond
.SetViewpointAppraiseId(objViewpointAppraise.ViewpointAppraiseId, "=")
.SetViewpointId(objViewpointAppraise.ViewpointId, "=")
.GetCombineCondition();
objViewpointAppraise._IsCheckProperty = true;
bool bolIsExist = clsViewpointAppraiseBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objViewpointAppraise.ViewpointAppraiseId = clsViewpointAppraiseBL.GetFirstID_S(strCondition);
objViewpointAppraise.UpdateWithCondition(strCondition);
}
else
{
objViewpointAppraise.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objViewpointAppraiseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsViewpointAppraiseEN objViewpointAppraiseEN)
{
 if (objViewpointAppraiseEN.ViewpointAppraiseId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsViewpointAppraiseBL.ViewpointAppraiseDA.UpdateBySql2(objViewpointAppraiseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewpointAppraiseBL.ReFreshCache();

if (clsViewpointAppraiseBL.relatedActions != null)
{
clsViewpointAppraiseBL.relatedActions.UpdRelaTabDate(objViewpointAppraiseEN.ViewpointAppraiseId, "SetUpdDate");
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
 /// <param name = "objViewpointAppraiseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsViewpointAppraiseEN objViewpointAppraiseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objViewpointAppraiseEN.ViewpointAppraiseId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsViewpointAppraiseBL.ViewpointAppraiseDA.UpdateBySql2(objViewpointAppraiseEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewpointAppraiseBL.ReFreshCache();

if (clsViewpointAppraiseBL.relatedActions != null)
{
clsViewpointAppraiseBL.relatedActions.UpdRelaTabDate(objViewpointAppraiseEN.ViewpointAppraiseId, "SetUpdDate");
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
 /// <param name = "objViewpointAppraiseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsViewpointAppraiseEN objViewpointAppraiseEN, string strWhereCond)
{
try
{
bool bolResult = clsViewpointAppraiseBL.ViewpointAppraiseDA.UpdateBySqlWithCondition(objViewpointAppraiseEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewpointAppraiseBL.ReFreshCache();

if (clsViewpointAppraiseBL.relatedActions != null)
{
clsViewpointAppraiseBL.relatedActions.UpdRelaTabDate(objViewpointAppraiseEN.ViewpointAppraiseId, "SetUpdDate");
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
 /// <param name = "objViewpointAppraiseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsViewpointAppraiseEN objViewpointAppraiseEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsViewpointAppraiseBL.ViewpointAppraiseDA.UpdateBySqlWithConditionTransaction(objViewpointAppraiseEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewpointAppraiseBL.ReFreshCache();

if (clsViewpointAppraiseBL.relatedActions != null)
{
clsViewpointAppraiseBL.relatedActions.UpdRelaTabDate(objViewpointAppraiseEN.ViewpointAppraiseId, "SetUpdDate");
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
 /// <param name = "lngViewpointAppraiseId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsViewpointAppraiseEN objViewpointAppraiseEN)
{
try
{
int intRecNum = clsViewpointAppraiseBL.ViewpointAppraiseDA.DelRecord(objViewpointAppraiseEN.ViewpointAppraiseId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewpointAppraiseBL.ReFreshCache();

if (clsViewpointAppraiseBL.relatedActions != null)
{
clsViewpointAppraiseBL.relatedActions.UpdRelaTabDate(objViewpointAppraiseEN.ViewpointAppraiseId, "SetUpdDate");
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
 /// <param name = "objViewpointAppraiseENS">源对象</param>
 /// <param name = "objViewpointAppraiseENT">目标对象</param>
 public static void CopyTo(this clsViewpointAppraiseEN objViewpointAppraiseENS, clsViewpointAppraiseEN objViewpointAppraiseENT)
{
try
{
objViewpointAppraiseENT.ViewpointAppraiseId = objViewpointAppraiseENS.ViewpointAppraiseId; //观点评论Id
objViewpointAppraiseENT.ViewpointId = objViewpointAppraiseENS.ViewpointId; //观点Id
objViewpointAppraiseENT.AppraiseContent = objViewpointAppraiseENS.AppraiseContent; //评议内容
objViewpointAppraiseENT.UpdDate = objViewpointAppraiseENS.UpdDate; //修改日期
objViewpointAppraiseENT.Memo = objViewpointAppraiseENS.Memo; //备注
objViewpointAppraiseENT.UpdUser = objViewpointAppraiseENS.UpdUser; //修改人
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
 /// <param name = "objViewpointAppraiseENS">源对象</param>
 /// <returns>目标对象=>clsViewpointAppraiseEN:objViewpointAppraiseENT</returns>
 public static clsViewpointAppraiseEN CopyTo(this clsViewpointAppraiseEN objViewpointAppraiseENS)
{
try
{
 clsViewpointAppraiseEN objViewpointAppraiseENT = new clsViewpointAppraiseEN()
{
ViewpointAppraiseId = objViewpointAppraiseENS.ViewpointAppraiseId, //观点评论Id
ViewpointId = objViewpointAppraiseENS.ViewpointId, //观点Id
AppraiseContent = objViewpointAppraiseENS.AppraiseContent, //评议内容
UpdDate = objViewpointAppraiseENS.UpdDate, //修改日期
Memo = objViewpointAppraiseENS.Memo, //备注
UpdUser = objViewpointAppraiseENS.UpdUser, //修改人
};
 return objViewpointAppraiseENT;
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
public static void CheckPropertyNew(this clsViewpointAppraiseEN objViewpointAppraiseEN)
{
 clsViewpointAppraiseBL.ViewpointAppraiseDA.CheckPropertyNew(objViewpointAppraiseEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsViewpointAppraiseEN objViewpointAppraiseEN)
{
 clsViewpointAppraiseBL.ViewpointAppraiseDA.CheckProperty4Condition(objViewpointAppraiseEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsViewpointAppraiseEN objViewpointAppraiseCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objViewpointAppraiseCond.IsUpdated(conViewpointAppraise.ViewpointAppraiseId) == true)
{
string strComparisonOpViewpointAppraiseId = objViewpointAppraiseCond.dicFldComparisonOp[conViewpointAppraise.ViewpointAppraiseId];
strWhereCond += string.Format(" And {0} {2} {1}", conViewpointAppraise.ViewpointAppraiseId, objViewpointAppraiseCond.ViewpointAppraiseId, strComparisonOpViewpointAppraiseId);
}
if (objViewpointAppraiseCond.IsUpdated(conViewpointAppraise.ViewpointId) == true)
{
string strComparisonOpViewpointId = objViewpointAppraiseCond.dicFldComparisonOp[conViewpointAppraise.ViewpointId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewpointAppraise.ViewpointId, objViewpointAppraiseCond.ViewpointId, strComparisonOpViewpointId);
}
if (objViewpointAppraiseCond.IsUpdated(conViewpointAppraise.AppraiseContent) == true)
{
string strComparisonOpAppraiseContent = objViewpointAppraiseCond.dicFldComparisonOp[conViewpointAppraise.AppraiseContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewpointAppraise.AppraiseContent, objViewpointAppraiseCond.AppraiseContent, strComparisonOpAppraiseContent);
}
if (objViewpointAppraiseCond.IsUpdated(conViewpointAppraise.UpdDate) == true)
{
string strComparisonOpUpdDate = objViewpointAppraiseCond.dicFldComparisonOp[conViewpointAppraise.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewpointAppraise.UpdDate, objViewpointAppraiseCond.UpdDate, strComparisonOpUpdDate);
}
if (objViewpointAppraiseCond.IsUpdated(conViewpointAppraise.Memo) == true)
{
string strComparisonOpMemo = objViewpointAppraiseCond.dicFldComparisonOp[conViewpointAppraise.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewpointAppraise.Memo, objViewpointAppraiseCond.Memo, strComparisonOpMemo);
}
if (objViewpointAppraiseCond.IsUpdated(conViewpointAppraise.UpdUser) == true)
{
string strComparisonOpUpdUser = objViewpointAppraiseCond.dicFldComparisonOp[conViewpointAppraise.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewpointAppraise.UpdUser, objViewpointAppraiseCond.UpdUser, strComparisonOpUpdUser);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--ViewpointAppraise(观点评论表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:ViewpointAppraiseId_ViewpointId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objViewpointAppraiseEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsViewpointAppraiseEN objViewpointAppraiseEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objViewpointAppraiseEN == null) return true;
if (objViewpointAppraiseEN.ViewpointAppraiseId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ViewpointAppraiseId = '{0}'", objViewpointAppraiseEN.ViewpointAppraiseId);
 if (objViewpointAppraiseEN.ViewpointId == null)
{
 sbCondition.AppendFormat(" and ViewpointId is null", objViewpointAppraiseEN.ViewpointId);
}
else
{
 sbCondition.AppendFormat(" and ViewpointId = '{0}'", objViewpointAppraiseEN.ViewpointId);
}
if (clsViewpointAppraiseBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("ViewpointAppraiseId !=  {0}", objViewpointAppraiseEN.ViewpointAppraiseId);
 sbCondition.AppendFormat(" and ViewpointAppraiseId = '{0}'", objViewpointAppraiseEN.ViewpointAppraiseId);
 sbCondition.AppendFormat(" and ViewpointId = '{0}'", objViewpointAppraiseEN.ViewpointId);
if (clsViewpointAppraiseBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--ViewpointAppraise(观点评论表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ViewpointAppraiseId_ViewpointId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objViewpointAppraiseEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsViewpointAppraiseEN objViewpointAppraiseEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objViewpointAppraiseEN == null) return "";
if (objViewpointAppraiseEN.ViewpointAppraiseId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ViewpointAppraiseId = '{0}'", objViewpointAppraiseEN.ViewpointAppraiseId);
 if (objViewpointAppraiseEN.ViewpointId == null)
{
 sbCondition.AppendFormat(" and ViewpointId is null", objViewpointAppraiseEN.ViewpointId);
}
else
{
 sbCondition.AppendFormat(" and ViewpointId = '{0}'", objViewpointAppraiseEN.ViewpointId);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ViewpointAppraiseId !=  {0}", objViewpointAppraiseEN.ViewpointAppraiseId);
 sbCondition.AppendFormat(" and ViewpointAppraiseId = '{0}'", objViewpointAppraiseEN.ViewpointAppraiseId);
 sbCondition.AppendFormat(" and ViewpointId = '{0}'", objViewpointAppraiseEN.ViewpointId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ViewpointAppraise
{
public virtual bool UpdRelaTabDate(long lngViewpointAppraiseId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 观点评论表(ViewpointAppraise)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsViewpointAppraiseBL
{
public static RelatedActions_ViewpointAppraise relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsViewpointAppraiseDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsViewpointAppraiseDA ViewpointAppraiseDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsViewpointAppraiseDA();
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
 public clsViewpointAppraiseBL()
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
if (string.IsNullOrEmpty(clsViewpointAppraiseEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsViewpointAppraiseEN._ConnectString);
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
public static DataTable GetDataTable_ViewpointAppraise(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ViewpointAppraiseDA.GetDataTable_ViewpointAppraise(strWhereCond);
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
objDT = ViewpointAppraiseDA.GetDataTable(strWhereCond);
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
objDT = ViewpointAppraiseDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ViewpointAppraiseDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ViewpointAppraiseDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ViewpointAppraiseDA.GetDataTable_Top(objTopPara);
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
objDT = ViewpointAppraiseDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ViewpointAppraiseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ViewpointAppraiseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrViewpointAppraiseIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsViewpointAppraiseEN> GetObjLstByViewpointAppraiseIdLst(List<long> arrViewpointAppraiseIdLst)
{
List<clsViewpointAppraiseEN> arrObjLst = new List<clsViewpointAppraiseEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrViewpointAppraiseIdLst);
 string strWhereCond = string.Format("ViewpointAppraiseId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewpointAppraiseEN objViewpointAppraiseEN = new clsViewpointAppraiseEN();
try
{
objViewpointAppraiseEN.ViewpointAppraiseId = Int32.Parse(objRow[conViewpointAppraise.ViewpointAppraiseId].ToString().Trim()); //观点评论Id
objViewpointAppraiseEN.ViewpointId = objRow[conViewpointAppraise.ViewpointId] == DBNull.Value ? null : objRow[conViewpointAppraise.ViewpointId].ToString().Trim(); //观点Id
objViewpointAppraiseEN.AppraiseContent = objRow[conViewpointAppraise.AppraiseContent] == DBNull.Value ? null : objRow[conViewpointAppraise.AppraiseContent].ToString().Trim(); //评议内容
objViewpointAppraiseEN.UpdDate = objRow[conViewpointAppraise.UpdDate] == DBNull.Value ? null : objRow[conViewpointAppraise.UpdDate].ToString().Trim(); //修改日期
objViewpointAppraiseEN.Memo = objRow[conViewpointAppraise.Memo] == DBNull.Value ? null : objRow[conViewpointAppraise.Memo].ToString().Trim(); //备注
objViewpointAppraiseEN.UpdUser = objRow[conViewpointAppraise.UpdUser] == DBNull.Value ? null : objRow[conViewpointAppraise.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewpointAppraiseEN.ViewpointAppraiseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewpointAppraiseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrViewpointAppraiseIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsViewpointAppraiseEN> GetObjLstByViewpointAppraiseIdLstCache(List<long> arrViewpointAppraiseIdLst)
{
string strKey = string.Format("{0}", clsViewpointAppraiseEN._CurrTabName);
List<clsViewpointAppraiseEN> arrViewpointAppraiseObjLstCache = GetObjLstCache();
IEnumerable <clsViewpointAppraiseEN> arrViewpointAppraiseObjLst_Sel =
arrViewpointAppraiseObjLstCache
.Where(x => arrViewpointAppraiseIdLst.Contains(x.ViewpointAppraiseId));
return arrViewpointAppraiseObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewpointAppraiseEN> GetObjLst(string strWhereCond)
{
List<clsViewpointAppraiseEN> arrObjLst = new List<clsViewpointAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewpointAppraiseEN objViewpointAppraiseEN = new clsViewpointAppraiseEN();
try
{
objViewpointAppraiseEN.ViewpointAppraiseId = Int32.Parse(objRow[conViewpointAppraise.ViewpointAppraiseId].ToString().Trim()); //观点评论Id
objViewpointAppraiseEN.ViewpointId = objRow[conViewpointAppraise.ViewpointId] == DBNull.Value ? null : objRow[conViewpointAppraise.ViewpointId].ToString().Trim(); //观点Id
objViewpointAppraiseEN.AppraiseContent = objRow[conViewpointAppraise.AppraiseContent] == DBNull.Value ? null : objRow[conViewpointAppraise.AppraiseContent].ToString().Trim(); //评议内容
objViewpointAppraiseEN.UpdDate = objRow[conViewpointAppraise.UpdDate] == DBNull.Value ? null : objRow[conViewpointAppraise.UpdDate].ToString().Trim(); //修改日期
objViewpointAppraiseEN.Memo = objRow[conViewpointAppraise.Memo] == DBNull.Value ? null : objRow[conViewpointAppraise.Memo].ToString().Trim(); //备注
objViewpointAppraiseEN.UpdUser = objRow[conViewpointAppraise.UpdUser] == DBNull.Value ? null : objRow[conViewpointAppraise.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewpointAppraiseEN.ViewpointAppraiseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewpointAppraiseEN);
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
public static List<clsViewpointAppraiseEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsViewpointAppraiseEN> arrObjLst = new List<clsViewpointAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewpointAppraiseEN objViewpointAppraiseEN = new clsViewpointAppraiseEN();
try
{
objViewpointAppraiseEN.ViewpointAppraiseId = Int32.Parse(objRow[conViewpointAppraise.ViewpointAppraiseId].ToString().Trim()); //观点评论Id
objViewpointAppraiseEN.ViewpointId = objRow[conViewpointAppraise.ViewpointId] == DBNull.Value ? null : objRow[conViewpointAppraise.ViewpointId].ToString().Trim(); //观点Id
objViewpointAppraiseEN.AppraiseContent = objRow[conViewpointAppraise.AppraiseContent] == DBNull.Value ? null : objRow[conViewpointAppraise.AppraiseContent].ToString().Trim(); //评议内容
objViewpointAppraiseEN.UpdDate = objRow[conViewpointAppraise.UpdDate] == DBNull.Value ? null : objRow[conViewpointAppraise.UpdDate].ToString().Trim(); //修改日期
objViewpointAppraiseEN.Memo = objRow[conViewpointAppraise.Memo] == DBNull.Value ? null : objRow[conViewpointAppraise.Memo].ToString().Trim(); //备注
objViewpointAppraiseEN.UpdUser = objRow[conViewpointAppraise.UpdUser] == DBNull.Value ? null : objRow[conViewpointAppraise.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewpointAppraiseEN.ViewpointAppraiseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewpointAppraiseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objViewpointAppraiseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsViewpointAppraiseEN> GetSubObjLstCache(clsViewpointAppraiseEN objViewpointAppraiseCond)
{
List<clsViewpointAppraiseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsViewpointAppraiseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conViewpointAppraise.AttributeName)
{
if (objViewpointAppraiseCond.IsUpdated(strFldName) == false) continue;
if (objViewpointAppraiseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewpointAppraiseCond[strFldName].ToString());
}
else
{
if (objViewpointAppraiseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objViewpointAppraiseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewpointAppraiseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objViewpointAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objViewpointAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objViewpointAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objViewpointAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objViewpointAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objViewpointAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objViewpointAppraiseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objViewpointAppraiseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objViewpointAppraiseCond[strFldName]));
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
public static List<clsViewpointAppraiseEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsViewpointAppraiseEN> arrObjLst = new List<clsViewpointAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewpointAppraiseEN objViewpointAppraiseEN = new clsViewpointAppraiseEN();
try
{
objViewpointAppraiseEN.ViewpointAppraiseId = Int32.Parse(objRow[conViewpointAppraise.ViewpointAppraiseId].ToString().Trim()); //观点评论Id
objViewpointAppraiseEN.ViewpointId = objRow[conViewpointAppraise.ViewpointId] == DBNull.Value ? null : objRow[conViewpointAppraise.ViewpointId].ToString().Trim(); //观点Id
objViewpointAppraiseEN.AppraiseContent = objRow[conViewpointAppraise.AppraiseContent] == DBNull.Value ? null : objRow[conViewpointAppraise.AppraiseContent].ToString().Trim(); //评议内容
objViewpointAppraiseEN.UpdDate = objRow[conViewpointAppraise.UpdDate] == DBNull.Value ? null : objRow[conViewpointAppraise.UpdDate].ToString().Trim(); //修改日期
objViewpointAppraiseEN.Memo = objRow[conViewpointAppraise.Memo] == DBNull.Value ? null : objRow[conViewpointAppraise.Memo].ToString().Trim(); //备注
objViewpointAppraiseEN.UpdUser = objRow[conViewpointAppraise.UpdUser] == DBNull.Value ? null : objRow[conViewpointAppraise.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewpointAppraiseEN.ViewpointAppraiseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewpointAppraiseEN);
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
public static List<clsViewpointAppraiseEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsViewpointAppraiseEN> arrObjLst = new List<clsViewpointAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewpointAppraiseEN objViewpointAppraiseEN = new clsViewpointAppraiseEN();
try
{
objViewpointAppraiseEN.ViewpointAppraiseId = Int32.Parse(objRow[conViewpointAppraise.ViewpointAppraiseId].ToString().Trim()); //观点评论Id
objViewpointAppraiseEN.ViewpointId = objRow[conViewpointAppraise.ViewpointId] == DBNull.Value ? null : objRow[conViewpointAppraise.ViewpointId].ToString().Trim(); //观点Id
objViewpointAppraiseEN.AppraiseContent = objRow[conViewpointAppraise.AppraiseContent] == DBNull.Value ? null : objRow[conViewpointAppraise.AppraiseContent].ToString().Trim(); //评议内容
objViewpointAppraiseEN.UpdDate = objRow[conViewpointAppraise.UpdDate] == DBNull.Value ? null : objRow[conViewpointAppraise.UpdDate].ToString().Trim(); //修改日期
objViewpointAppraiseEN.Memo = objRow[conViewpointAppraise.Memo] == DBNull.Value ? null : objRow[conViewpointAppraise.Memo].ToString().Trim(); //备注
objViewpointAppraiseEN.UpdUser = objRow[conViewpointAppraise.UpdUser] == DBNull.Value ? null : objRow[conViewpointAppraise.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewpointAppraiseEN.ViewpointAppraiseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewpointAppraiseEN);
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
List<clsViewpointAppraiseEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsViewpointAppraiseEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewpointAppraiseEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsViewpointAppraiseEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsViewpointAppraiseEN> arrObjLst = new List<clsViewpointAppraiseEN>(); 
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
	clsViewpointAppraiseEN objViewpointAppraiseEN = new clsViewpointAppraiseEN();
try
{
objViewpointAppraiseEN.ViewpointAppraiseId = Int32.Parse(objRow[conViewpointAppraise.ViewpointAppraiseId].ToString().Trim()); //观点评论Id
objViewpointAppraiseEN.ViewpointId = objRow[conViewpointAppraise.ViewpointId] == DBNull.Value ? null : objRow[conViewpointAppraise.ViewpointId].ToString().Trim(); //观点Id
objViewpointAppraiseEN.AppraiseContent = objRow[conViewpointAppraise.AppraiseContent] == DBNull.Value ? null : objRow[conViewpointAppraise.AppraiseContent].ToString().Trim(); //评议内容
objViewpointAppraiseEN.UpdDate = objRow[conViewpointAppraise.UpdDate] == DBNull.Value ? null : objRow[conViewpointAppraise.UpdDate].ToString().Trim(); //修改日期
objViewpointAppraiseEN.Memo = objRow[conViewpointAppraise.Memo] == DBNull.Value ? null : objRow[conViewpointAppraise.Memo].ToString().Trim(); //备注
objViewpointAppraiseEN.UpdUser = objRow[conViewpointAppraise.UpdUser] == DBNull.Value ? null : objRow[conViewpointAppraise.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewpointAppraiseEN.ViewpointAppraiseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewpointAppraiseEN);
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
public static List<clsViewpointAppraiseEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsViewpointAppraiseEN> arrObjLst = new List<clsViewpointAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewpointAppraiseEN objViewpointAppraiseEN = new clsViewpointAppraiseEN();
try
{
objViewpointAppraiseEN.ViewpointAppraiseId = Int32.Parse(objRow[conViewpointAppraise.ViewpointAppraiseId].ToString().Trim()); //观点评论Id
objViewpointAppraiseEN.ViewpointId = objRow[conViewpointAppraise.ViewpointId] == DBNull.Value ? null : objRow[conViewpointAppraise.ViewpointId].ToString().Trim(); //观点Id
objViewpointAppraiseEN.AppraiseContent = objRow[conViewpointAppraise.AppraiseContent] == DBNull.Value ? null : objRow[conViewpointAppraise.AppraiseContent].ToString().Trim(); //评议内容
objViewpointAppraiseEN.UpdDate = objRow[conViewpointAppraise.UpdDate] == DBNull.Value ? null : objRow[conViewpointAppraise.UpdDate].ToString().Trim(); //修改日期
objViewpointAppraiseEN.Memo = objRow[conViewpointAppraise.Memo] == DBNull.Value ? null : objRow[conViewpointAppraise.Memo].ToString().Trim(); //备注
objViewpointAppraiseEN.UpdUser = objRow[conViewpointAppraise.UpdUser] == DBNull.Value ? null : objRow[conViewpointAppraise.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewpointAppraiseEN.ViewpointAppraiseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewpointAppraiseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsViewpointAppraiseEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsViewpointAppraiseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsViewpointAppraiseEN> arrObjLst = new List<clsViewpointAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewpointAppraiseEN objViewpointAppraiseEN = new clsViewpointAppraiseEN();
try
{
objViewpointAppraiseEN.ViewpointAppraiseId = Int32.Parse(objRow[conViewpointAppraise.ViewpointAppraiseId].ToString().Trim()); //观点评论Id
objViewpointAppraiseEN.ViewpointId = objRow[conViewpointAppraise.ViewpointId] == DBNull.Value ? null : objRow[conViewpointAppraise.ViewpointId].ToString().Trim(); //观点Id
objViewpointAppraiseEN.AppraiseContent = objRow[conViewpointAppraise.AppraiseContent] == DBNull.Value ? null : objRow[conViewpointAppraise.AppraiseContent].ToString().Trim(); //评议内容
objViewpointAppraiseEN.UpdDate = objRow[conViewpointAppraise.UpdDate] == DBNull.Value ? null : objRow[conViewpointAppraise.UpdDate].ToString().Trim(); //修改日期
objViewpointAppraiseEN.Memo = objRow[conViewpointAppraise.Memo] == DBNull.Value ? null : objRow[conViewpointAppraise.Memo].ToString().Trim(); //备注
objViewpointAppraiseEN.UpdUser = objRow[conViewpointAppraise.UpdUser] == DBNull.Value ? null : objRow[conViewpointAppraise.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewpointAppraiseEN.ViewpointAppraiseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewpointAppraiseEN);
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
public static List<clsViewpointAppraiseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsViewpointAppraiseEN> arrObjLst = new List<clsViewpointAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewpointAppraiseEN objViewpointAppraiseEN = new clsViewpointAppraiseEN();
try
{
objViewpointAppraiseEN.ViewpointAppraiseId = Int32.Parse(objRow[conViewpointAppraise.ViewpointAppraiseId].ToString().Trim()); //观点评论Id
objViewpointAppraiseEN.ViewpointId = objRow[conViewpointAppraise.ViewpointId] == DBNull.Value ? null : objRow[conViewpointAppraise.ViewpointId].ToString().Trim(); //观点Id
objViewpointAppraiseEN.AppraiseContent = objRow[conViewpointAppraise.AppraiseContent] == DBNull.Value ? null : objRow[conViewpointAppraise.AppraiseContent].ToString().Trim(); //评议内容
objViewpointAppraiseEN.UpdDate = objRow[conViewpointAppraise.UpdDate] == DBNull.Value ? null : objRow[conViewpointAppraise.UpdDate].ToString().Trim(); //修改日期
objViewpointAppraiseEN.Memo = objRow[conViewpointAppraise.Memo] == DBNull.Value ? null : objRow[conViewpointAppraise.Memo].ToString().Trim(); //备注
objViewpointAppraiseEN.UpdUser = objRow[conViewpointAppraise.UpdUser] == DBNull.Value ? null : objRow[conViewpointAppraise.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewpointAppraiseEN.ViewpointAppraiseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewpointAppraiseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewpointAppraiseEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsViewpointAppraiseEN> arrObjLst = new List<clsViewpointAppraiseEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewpointAppraiseEN objViewpointAppraiseEN = new clsViewpointAppraiseEN();
try
{
objViewpointAppraiseEN.ViewpointAppraiseId = Int32.Parse(objRow[conViewpointAppraise.ViewpointAppraiseId].ToString().Trim()); //观点评论Id
objViewpointAppraiseEN.ViewpointId = objRow[conViewpointAppraise.ViewpointId] == DBNull.Value ? null : objRow[conViewpointAppraise.ViewpointId].ToString().Trim(); //观点Id
objViewpointAppraiseEN.AppraiseContent = objRow[conViewpointAppraise.AppraiseContent] == DBNull.Value ? null : objRow[conViewpointAppraise.AppraiseContent].ToString().Trim(); //评议内容
objViewpointAppraiseEN.UpdDate = objRow[conViewpointAppraise.UpdDate] == DBNull.Value ? null : objRow[conViewpointAppraise.UpdDate].ToString().Trim(); //修改日期
objViewpointAppraiseEN.Memo = objRow[conViewpointAppraise.Memo] == DBNull.Value ? null : objRow[conViewpointAppraise.Memo].ToString().Trim(); //备注
objViewpointAppraiseEN.UpdUser = objRow[conViewpointAppraise.UpdUser] == DBNull.Value ? null : objRow[conViewpointAppraise.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewpointAppraiseEN.ViewpointAppraiseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewpointAppraiseEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objViewpointAppraiseEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetViewpointAppraise(ref clsViewpointAppraiseEN objViewpointAppraiseEN)
{
bool bolResult = ViewpointAppraiseDA.GetViewpointAppraise(ref objViewpointAppraiseEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngViewpointAppraiseId">表关键字</param>
 /// <returns>表对象</returns>
public static clsViewpointAppraiseEN GetObjByViewpointAppraiseId(long lngViewpointAppraiseId)
{
clsViewpointAppraiseEN objViewpointAppraiseEN = ViewpointAppraiseDA.GetObjByViewpointAppraiseId(lngViewpointAppraiseId);
return objViewpointAppraiseEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsViewpointAppraiseEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsViewpointAppraiseEN objViewpointAppraiseEN = ViewpointAppraiseDA.GetFirstObj(strWhereCond);
 return objViewpointAppraiseEN;
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
public static clsViewpointAppraiseEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsViewpointAppraiseEN objViewpointAppraiseEN = ViewpointAppraiseDA.GetObjByDataRow(objRow);
 return objViewpointAppraiseEN;
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
public static clsViewpointAppraiseEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsViewpointAppraiseEN objViewpointAppraiseEN = ViewpointAppraiseDA.GetObjByDataRow(objRow);
 return objViewpointAppraiseEN;
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
 /// <param name = "lngViewpointAppraiseId">所给的关键字</param>
 /// <param name = "lstViewpointAppraiseObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsViewpointAppraiseEN GetObjByViewpointAppraiseIdFromList(long lngViewpointAppraiseId, List<clsViewpointAppraiseEN> lstViewpointAppraiseObjLst)
{
foreach (clsViewpointAppraiseEN objViewpointAppraiseEN in lstViewpointAppraiseObjLst)
{
if (objViewpointAppraiseEN.ViewpointAppraiseId == lngViewpointAppraiseId)
{
return objViewpointAppraiseEN;
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
 long lngViewpointAppraiseId;
 try
 {
 lngViewpointAppraiseId = new clsViewpointAppraiseDA().GetFirstID(strWhereCond);
 return lngViewpointAppraiseId;
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
 arrList = ViewpointAppraiseDA.GetID(strWhereCond);
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
bool bolIsExist = ViewpointAppraiseDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngViewpointAppraiseId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngViewpointAppraiseId)
{
//检测记录是否存在
bool bolIsExist = ViewpointAppraiseDA.IsExist(lngViewpointAppraiseId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngViewpointAppraiseId">观点评论Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngViewpointAppraiseId, string strOpUser)
{
clsViewpointAppraiseEN objViewpointAppraiseEN = clsViewpointAppraiseBL.GetObjByViewpointAppraiseId(lngViewpointAppraiseId);
objViewpointAppraiseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
return clsViewpointAppraiseBL.UpdateBySql2(objViewpointAppraiseEN);
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
 bolIsExist = clsViewpointAppraiseDA.IsExistTable();
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
 bolIsExist = ViewpointAppraiseDA.IsExistTable(strTabName);
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
 /// <param name = "objViewpointAppraiseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsViewpointAppraiseEN objViewpointAppraiseEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objViewpointAppraiseEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!观点评论Id = [{0}],观点Id = [{1}]的数据已经存在!(in clsViewpointAppraiseBL.AddNewRecordBySql2)", objViewpointAppraiseEN.ViewpointAppraiseId,objViewpointAppraiseEN.ViewpointId);
throw new Exception(strMsg);
}
try
{
bool bolResult = ViewpointAppraiseDA.AddNewRecordBySQL2(objViewpointAppraiseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewpointAppraiseBL.ReFreshCache();

if (clsViewpointAppraiseBL.relatedActions != null)
{
clsViewpointAppraiseBL.relatedActions.UpdRelaTabDate(objViewpointAppraiseEN.ViewpointAppraiseId, "SetUpdDate");
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
 /// <param name = "objViewpointAppraiseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsViewpointAppraiseEN objViewpointAppraiseEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objViewpointAppraiseEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!观点评论Id = [{0}],观点Id = [{1}]的数据已经存在!(in clsViewpointAppraiseBL.AddNewRecordBySql2WithReturnKey)", objViewpointAppraiseEN.ViewpointAppraiseId,objViewpointAppraiseEN.ViewpointId);
throw new Exception(strMsg);
}
try
{
string strKey = ViewpointAppraiseDA.AddNewRecordBySQL2WithReturnKey(objViewpointAppraiseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewpointAppraiseBL.ReFreshCache();

if (clsViewpointAppraiseBL.relatedActions != null)
{
clsViewpointAppraiseBL.relatedActions.UpdRelaTabDate(objViewpointAppraiseEN.ViewpointAppraiseId, "SetUpdDate");
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
 /// <param name = "objViewpointAppraiseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsViewpointAppraiseEN objViewpointAppraiseEN)
{
try
{
bool bolResult = ViewpointAppraiseDA.Update(objViewpointAppraiseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewpointAppraiseBL.ReFreshCache();

if (clsViewpointAppraiseBL.relatedActions != null)
{
clsViewpointAppraiseBL.relatedActions.UpdRelaTabDate(objViewpointAppraiseEN.ViewpointAppraiseId, "SetUpdDate");
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
 /// <param name = "objViewpointAppraiseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsViewpointAppraiseEN objViewpointAppraiseEN)
{
 if (objViewpointAppraiseEN.ViewpointAppraiseId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ViewpointAppraiseDA.UpdateBySql2(objViewpointAppraiseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewpointAppraiseBL.ReFreshCache();

if (clsViewpointAppraiseBL.relatedActions != null)
{
clsViewpointAppraiseBL.relatedActions.UpdRelaTabDate(objViewpointAppraiseEN.ViewpointAppraiseId, "SetUpdDate");
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
 /// <param name = "lngViewpointAppraiseId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngViewpointAppraiseId)
{
try
{
 clsViewpointAppraiseEN objViewpointAppraiseEN = clsViewpointAppraiseBL.GetObjByViewpointAppraiseId(lngViewpointAppraiseId);

if (clsViewpointAppraiseBL.relatedActions != null)
{
clsViewpointAppraiseBL.relatedActions.UpdRelaTabDate(objViewpointAppraiseEN.ViewpointAppraiseId, "SetUpdDate");
}
if (objViewpointAppraiseEN != null)
{
int intRecNum = ViewpointAppraiseDA.DelRecord(lngViewpointAppraiseId);
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
/// <param name="lngViewpointAppraiseId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngViewpointAppraiseId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsViewpointAppraiseDA.GetSpecSQLObj();
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
//删除与表:[ViewpointAppraise]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conViewpointAppraise.ViewpointAppraiseId,
//lngViewpointAppraiseId);
//        clsViewpointAppraiseBL.DelViewpointAppraisesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsViewpointAppraiseBL.DelRecord(lngViewpointAppraiseId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsViewpointAppraiseBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngViewpointAppraiseId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngViewpointAppraiseId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngViewpointAppraiseId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsViewpointAppraiseBL.relatedActions != null)
{
clsViewpointAppraiseBL.relatedActions.UpdRelaTabDate(lngViewpointAppraiseId, "UpdRelaTabDate");
}
bool bolResult = ViewpointAppraiseDA.DelRecord(lngViewpointAppraiseId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrViewpointAppraiseIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelViewpointAppraises(List<string> arrViewpointAppraiseIdLst)
{
if (arrViewpointAppraiseIdLst.Count == 0) return 0;
try
{
if (clsViewpointAppraiseBL.relatedActions != null)
{
foreach (var strViewpointAppraiseId in arrViewpointAppraiseIdLst)
{
long lngViewpointAppraiseId = long.Parse(strViewpointAppraiseId);
clsViewpointAppraiseBL.relatedActions.UpdRelaTabDate(lngViewpointAppraiseId, "UpdRelaTabDate");
}
}
int intDelRecNum = ViewpointAppraiseDA.DelViewpointAppraise(arrViewpointAppraiseIdLst);
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
public static int DelViewpointAppraisesByCond(string strWhereCond)
{
try
{
if (clsViewpointAppraiseBL.relatedActions != null)
{
List<string> arrViewpointAppraiseId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strViewpointAppraiseId in arrViewpointAppraiseId)
{
long lngViewpointAppraiseId = long.Parse(strViewpointAppraiseId);
clsViewpointAppraiseBL.relatedActions.UpdRelaTabDate(lngViewpointAppraiseId, "UpdRelaTabDate");
}
}
int intRecNum = ViewpointAppraiseDA.DelViewpointAppraise(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[ViewpointAppraise]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngViewpointAppraiseId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngViewpointAppraiseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsViewpointAppraiseDA.GetSpecSQLObj();
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
//删除与表:[ViewpointAppraise]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsViewpointAppraiseBL.DelRecord(lngViewpointAppraiseId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsViewpointAppraiseBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngViewpointAppraiseId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objViewpointAppraiseENS">源对象</param>
 /// <param name = "objViewpointAppraiseENT">目标对象</param>
 public static void CopyTo(clsViewpointAppraiseEN objViewpointAppraiseENS, clsViewpointAppraiseEN objViewpointAppraiseENT)
{
try
{
objViewpointAppraiseENT.ViewpointAppraiseId = objViewpointAppraiseENS.ViewpointAppraiseId; //观点评论Id
objViewpointAppraiseENT.ViewpointId = objViewpointAppraiseENS.ViewpointId; //观点Id
objViewpointAppraiseENT.AppraiseContent = objViewpointAppraiseENS.AppraiseContent; //评议内容
objViewpointAppraiseENT.UpdDate = objViewpointAppraiseENS.UpdDate; //修改日期
objViewpointAppraiseENT.Memo = objViewpointAppraiseENS.Memo; //备注
objViewpointAppraiseENT.UpdUser = objViewpointAppraiseENS.UpdUser; //修改人
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
 /// <param name = "objViewpointAppraiseEN">源简化对象</param>
 public static void SetUpdFlag(clsViewpointAppraiseEN objViewpointAppraiseEN)
{
try
{
objViewpointAppraiseEN.ClearUpdateState();
   string strsfUpdFldSetStr = objViewpointAppraiseEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conViewpointAppraise.ViewpointAppraiseId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewpointAppraiseEN.ViewpointAppraiseId = objViewpointAppraiseEN.ViewpointAppraiseId; //观点评论Id
}
if (arrFldSet.Contains(conViewpointAppraise.ViewpointId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewpointAppraiseEN.ViewpointId = objViewpointAppraiseEN.ViewpointId == "[null]" ? null :  objViewpointAppraiseEN.ViewpointId; //观点Id
}
if (arrFldSet.Contains(conViewpointAppraise.AppraiseContent, new clsStrCompareIgnoreCase())  ==  true)
{
objViewpointAppraiseEN.AppraiseContent = objViewpointAppraiseEN.AppraiseContent == "[null]" ? null :  objViewpointAppraiseEN.AppraiseContent; //评议内容
}
if (arrFldSet.Contains(conViewpointAppraise.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objViewpointAppraiseEN.UpdDate = objViewpointAppraiseEN.UpdDate == "[null]" ? null :  objViewpointAppraiseEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conViewpointAppraise.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objViewpointAppraiseEN.Memo = objViewpointAppraiseEN.Memo == "[null]" ? null :  objViewpointAppraiseEN.Memo; //备注
}
if (arrFldSet.Contains(conViewpointAppraise.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objViewpointAppraiseEN.UpdUser = objViewpointAppraiseEN.UpdUser == "[null]" ? null :  objViewpointAppraiseEN.UpdUser; //修改人
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
 /// <param name = "objViewpointAppraiseEN">源简化对象</param>
 public static void AccessFldValueNull(clsViewpointAppraiseEN objViewpointAppraiseEN)
{
try
{
if (objViewpointAppraiseEN.ViewpointId == "[null]") objViewpointAppraiseEN.ViewpointId = null; //观点Id
if (objViewpointAppraiseEN.AppraiseContent == "[null]") objViewpointAppraiseEN.AppraiseContent = null; //评议内容
if (objViewpointAppraiseEN.UpdDate == "[null]") objViewpointAppraiseEN.UpdDate = null; //修改日期
if (objViewpointAppraiseEN.Memo == "[null]") objViewpointAppraiseEN.Memo = null; //备注
if (objViewpointAppraiseEN.UpdUser == "[null]") objViewpointAppraiseEN.UpdUser = null; //修改人
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
public static void CheckPropertyNew(clsViewpointAppraiseEN objViewpointAppraiseEN)
{
 ViewpointAppraiseDA.CheckPropertyNew(objViewpointAppraiseEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsViewpointAppraiseEN objViewpointAppraiseEN)
{
 ViewpointAppraiseDA.CheckProperty4Condition(objViewpointAppraiseEN);
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
if (clsViewpointAppraiseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewpointAppraiseBL没有刷新缓存机制(clsViewpointAppraiseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ViewpointAppraiseId");
//if (arrViewpointAppraiseObjLstCache == null)
//{
//arrViewpointAppraiseObjLstCache = ViewpointAppraiseDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngViewpointAppraiseId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsViewpointAppraiseEN GetObjByViewpointAppraiseIdCache(long lngViewpointAppraiseId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsViewpointAppraiseEN._CurrTabName);
List<clsViewpointAppraiseEN> arrViewpointAppraiseObjLstCache = GetObjLstCache();
IEnumerable <clsViewpointAppraiseEN> arrViewpointAppraiseObjLst_Sel =
arrViewpointAppraiseObjLstCache
.Where(x=> x.ViewpointAppraiseId == lngViewpointAppraiseId 
);
if (arrViewpointAppraiseObjLst_Sel.Count() == 0)
{
   clsViewpointAppraiseEN obj = clsViewpointAppraiseBL.GetObjByViewpointAppraiseId(lngViewpointAppraiseId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrViewpointAppraiseObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsViewpointAppraiseEN> GetAllViewpointAppraiseObjLstCache()
{
//获取缓存中的对象列表
List<clsViewpointAppraiseEN> arrViewpointAppraiseObjLstCache = GetObjLstCache(); 
return arrViewpointAppraiseObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsViewpointAppraiseEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsViewpointAppraiseEN._CurrTabName);
List<clsViewpointAppraiseEN> arrViewpointAppraiseObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrViewpointAppraiseObjLstCache;
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
string strKey = string.Format("{0}", clsViewpointAppraiseEN._CurrTabName);
CacheHelper.Remove(strKey);
clsViewpointAppraiseEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsViewpointAppraiseEN._RefreshTimeLst.Count == 0) return "";
return clsViewpointAppraiseEN._RefreshTimeLst[clsViewpointAppraiseEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsViewpointAppraiseBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsViewpointAppraiseEN._CurrTabName);
CacheHelper.Remove(strKey);
clsViewpointAppraiseEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsViewpointAppraiseBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--ViewpointAppraise(观点评论表)
 /// 唯一性条件:ViewpointAppraiseId_ViewpointId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objViewpointAppraiseEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsViewpointAppraiseEN objViewpointAppraiseEN)
{
//检测记录是否存在
string strResult = ViewpointAppraiseDA.GetUniCondStr(objViewpointAppraiseEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngViewpointAppraiseId)
{
if (strInFldName != conViewpointAppraise.ViewpointAppraiseId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conViewpointAppraise.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conViewpointAppraise.AttributeName));
throw new Exception(strMsg);
}
var objViewpointAppraise = clsViewpointAppraiseBL.GetObjByViewpointAppraiseIdCache(lngViewpointAppraiseId);
if (objViewpointAppraise == null) return "";
return objViewpointAppraise[strOutFldName].ToString();
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
int intRecCount = clsViewpointAppraiseDA.GetRecCount(strTabName);
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
int intRecCount = clsViewpointAppraiseDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsViewpointAppraiseDA.GetRecCount();
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
int intRecCount = clsViewpointAppraiseDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objViewpointAppraiseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsViewpointAppraiseEN objViewpointAppraiseCond)
{
List<clsViewpointAppraiseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsViewpointAppraiseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conViewpointAppraise.AttributeName)
{
if (objViewpointAppraiseCond.IsUpdated(strFldName) == false) continue;
if (objViewpointAppraiseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewpointAppraiseCond[strFldName].ToString());
}
else
{
if (objViewpointAppraiseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objViewpointAppraiseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewpointAppraiseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objViewpointAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objViewpointAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objViewpointAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objViewpointAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objViewpointAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objViewpointAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objViewpointAppraiseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objViewpointAppraiseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objViewpointAppraiseCond[strFldName]));
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
 List<string> arrList = clsViewpointAppraiseDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ViewpointAppraiseDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ViewpointAppraiseDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ViewpointAppraiseDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsViewpointAppraiseDA.SetFldValue(clsViewpointAppraiseEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ViewpointAppraiseDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsViewpointAppraiseDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsViewpointAppraiseDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsViewpointAppraiseDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ViewpointAppraise] "); 
 strCreateTabCode.Append(" ( "); 
 // /**观点评论Id*/ 
 strCreateTabCode.Append(" ViewpointAppraiseId bigint primary key identity, "); 
 // /**观点Id*/ 
 strCreateTabCode.Append(" ViewpointId char(8) Null, "); 
 // /**评议内容*/ 
 strCreateTabCode.Append(" AppraiseContent varchar(2000) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 观点评论表(ViewpointAppraise)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4ViewpointAppraise : clsCommFun4BL
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
clsViewpointAppraiseBL.ReFreshThisCache();
}
}

}