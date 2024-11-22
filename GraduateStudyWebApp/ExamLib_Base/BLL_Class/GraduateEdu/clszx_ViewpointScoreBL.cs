
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_ViewpointScoreBL
 表名:zx_ViewpointScore(01120859)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:54:32
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研究生培养(GraduateEdu)
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
public static class  clszx_ViewpointScoreBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngViewpointScoreId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_ViewpointScoreEN GetObj(this K_ViewpointScoreId_zx_ViewpointScore myKey)
{
clszx_ViewpointScoreEN objzx_ViewpointScoreEN = clszx_ViewpointScoreBL.zx_ViewpointScoreDA.GetObjByViewpointScoreId(myKey.Value);
return objzx_ViewpointScoreEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objzx_ViewpointScoreEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clszx_ViewpointScoreEN objzx_ViewpointScoreEN)
{
if (CheckUniqueness(objzx_ViewpointScoreEN) == false)
{
var strMsg = string.Format("记录已经存在!评分Id = [{0}]的数据已经存在!(in clszx_ViewpointScoreBL.AddNewRecord)", objzx_ViewpointScoreEN.ViewpointScoreId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clszx_ViewpointScoreBL.zx_ViewpointScoreDA.AddNewRecordBySQL2(objzx_ViewpointScoreEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewpointScoreBL.ReFreshCache();

if (clszx_ViewpointScoreBL.relatedActions != null)
{
clszx_ViewpointScoreBL.relatedActions.UpdRelaTabDate(objzx_ViewpointScoreEN.ViewpointScoreId, "SetUpdDate");
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
public static bool AddRecordEx(this clszx_ViewpointScoreEN objzx_ViewpointScoreEN)
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
objzx_ViewpointScoreEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objzx_ViewpointScoreEN.CheckUniqueness() == false)
{
strMsg = string.Format("(评分Id(ViewpointScoreId)=[{0}])已经存在,不能重复!", objzx_ViewpointScoreEN.ViewpointScoreId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objzx_ViewpointScoreEN.AddNewRecord();
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
 /// <param name = "objzx_ViewpointScoreEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clszx_ViewpointScoreEN objzx_ViewpointScoreEN)
{
if (CheckUniqueness(objzx_ViewpointScoreEN) == false)
{
var strMsg = string.Format("记录已经存在!评分Id = [{0}]的数据已经存在!(in clszx_ViewpointScoreBL.AddNewRecordWithReturnKey)", objzx_ViewpointScoreEN.ViewpointScoreId);
throw new Exception(strMsg);
}
try
{
string strKey = clszx_ViewpointScoreBL.zx_ViewpointScoreDA.AddNewRecordBySQL2WithReturnKey(objzx_ViewpointScoreEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewpointScoreBL.ReFreshCache();

if (clszx_ViewpointScoreBL.relatedActions != null)
{
clszx_ViewpointScoreBL.relatedActions.UpdRelaTabDate(objzx_ViewpointScoreEN.ViewpointScoreId, "SetUpdDate");
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
 /// <param name = "objzx_ViewpointScoreEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointScoreEN SetViewpointScoreId(this clszx_ViewpointScoreEN objzx_ViewpointScoreEN, long lngViewpointScoreId, string strComparisonOp="")
	{
objzx_ViewpointScoreEN.ViewpointScoreId = lngViewpointScoreId; //评分Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointScoreEN.dicFldComparisonOp.ContainsKey(conzx_ViewpointScore.ViewpointScoreId) == false)
{
objzx_ViewpointScoreEN.dicFldComparisonOp.Add(conzx_ViewpointScore.ViewpointScoreId, strComparisonOp);
}
else
{
objzx_ViewpointScoreEN.dicFldComparisonOp[conzx_ViewpointScore.ViewpointScoreId] = strComparisonOp;
}
}
return objzx_ViewpointScoreEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointScoreEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointScoreEN SetViewpointScore(this clszx_ViewpointScoreEN objzx_ViewpointScoreEN, float? fltViewpointScore, string strComparisonOp="")
	{
objzx_ViewpointScoreEN.ViewpointScore = fltViewpointScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointScoreEN.dicFldComparisonOp.ContainsKey(conzx_ViewpointScore.ViewpointScore) == false)
{
objzx_ViewpointScoreEN.dicFldComparisonOp.Add(conzx_ViewpointScore.ViewpointScore, strComparisonOp);
}
else
{
objzx_ViewpointScoreEN.dicFldComparisonOp[conzx_ViewpointScore.ViewpointScore] = strComparisonOp;
}
}
return objzx_ViewpointScoreEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointScoreEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointScoreEN SetzxViewpointId(this clszx_ViewpointScoreEN objzx_ViewpointScoreEN, string strzxViewpointId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxViewpointId, 8, conzx_ViewpointScore.zxViewpointId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxViewpointId, 8, conzx_ViewpointScore.zxViewpointId);
}
objzx_ViewpointScoreEN.zxViewpointId = strzxViewpointId; //观点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointScoreEN.dicFldComparisonOp.ContainsKey(conzx_ViewpointScore.zxViewpointId) == false)
{
objzx_ViewpointScoreEN.dicFldComparisonOp.Add(conzx_ViewpointScore.zxViewpointId, strComparisonOp);
}
else
{
objzx_ViewpointScoreEN.dicFldComparisonOp[conzx_ViewpointScore.zxViewpointId] = strComparisonOp;
}
}
return objzx_ViewpointScoreEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointScoreEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointScoreEN SetUpdDate(this clszx_ViewpointScoreEN objzx_ViewpointScoreEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conzx_ViewpointScore.UpdDate);
}
objzx_ViewpointScoreEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointScoreEN.dicFldComparisonOp.ContainsKey(conzx_ViewpointScore.UpdDate) == false)
{
objzx_ViewpointScoreEN.dicFldComparisonOp.Add(conzx_ViewpointScore.UpdDate, strComparisonOp);
}
else
{
objzx_ViewpointScoreEN.dicFldComparisonOp[conzx_ViewpointScore.UpdDate] = strComparisonOp;
}
}
return objzx_ViewpointScoreEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointScoreEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointScoreEN SetUpdUserId(this clszx_ViewpointScoreEN objzx_ViewpointScoreEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conzx_ViewpointScore.UpdUserId);
}
objzx_ViewpointScoreEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointScoreEN.dicFldComparisonOp.ContainsKey(conzx_ViewpointScore.UpdUserId) == false)
{
objzx_ViewpointScoreEN.dicFldComparisonOp.Add(conzx_ViewpointScore.UpdUserId, strComparisonOp);
}
else
{
objzx_ViewpointScoreEN.dicFldComparisonOp[conzx_ViewpointScore.UpdUserId] = strComparisonOp;
}
}
return objzx_ViewpointScoreEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointScoreEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointScoreEN SetMemo(this clszx_ViewpointScoreEN objzx_ViewpointScoreEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conzx_ViewpointScore.Memo);
}
objzx_ViewpointScoreEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointScoreEN.dicFldComparisonOp.ContainsKey(conzx_ViewpointScore.Memo) == false)
{
objzx_ViewpointScoreEN.dicFldComparisonOp.Add(conzx_ViewpointScore.Memo, strComparisonOp);
}
else
{
objzx_ViewpointScoreEN.dicFldComparisonOp[conzx_ViewpointScore.Memo] = strComparisonOp;
}
}
return objzx_ViewpointScoreEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objzx_ViewpointScoreEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clszx_ViewpointScoreEN objzx_ViewpointScoreEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objzx_ViewpointScoreEN.CheckPropertyNew();
clszx_ViewpointScoreEN objzx_ViewpointScoreCond = new clszx_ViewpointScoreEN();
string strCondition = objzx_ViewpointScoreCond
.SetViewpointScoreId(objzx_ViewpointScoreEN.ViewpointScoreId, "<>")
.SetViewpointScoreId(objzx_ViewpointScoreEN.ViewpointScoreId, "=")
.GetCombineCondition();
objzx_ViewpointScoreEN._IsCheckProperty = true;
bool bolIsExist = clszx_ViewpointScoreBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(ViewpointScoreId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objzx_ViewpointScoreEN.Update();
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
 /// <param name = "objzx_ViewpointScore">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clszx_ViewpointScoreEN objzx_ViewpointScore)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clszx_ViewpointScoreEN objzx_ViewpointScoreCond = new clszx_ViewpointScoreEN();
string strCondition = objzx_ViewpointScoreCond
.SetViewpointScoreId(objzx_ViewpointScore.ViewpointScoreId, "=")
.GetCombineCondition();
objzx_ViewpointScore._IsCheckProperty = true;
bool bolIsExist = clszx_ViewpointScoreBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objzx_ViewpointScore.ViewpointScoreId = clszx_ViewpointScoreBL.GetFirstID_S(strCondition);
objzx_ViewpointScore.UpdateWithCondition(strCondition);
}
else
{
objzx_ViewpointScore.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objzx_ViewpointScoreEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_ViewpointScoreEN objzx_ViewpointScoreEN)
{
 if (objzx_ViewpointScoreEN.ViewpointScoreId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_ViewpointScoreBL.zx_ViewpointScoreDA.UpdateBySql2(objzx_ViewpointScoreEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewpointScoreBL.ReFreshCache();

if (clszx_ViewpointScoreBL.relatedActions != null)
{
clszx_ViewpointScoreBL.relatedActions.UpdRelaTabDate(objzx_ViewpointScoreEN.ViewpointScoreId, "SetUpdDate");
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
 /// <param name = "objzx_ViewpointScoreEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_ViewpointScoreEN objzx_ViewpointScoreEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_ViewpointScoreEN.ViewpointScoreId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_ViewpointScoreBL.zx_ViewpointScoreDA.UpdateBySql2(objzx_ViewpointScoreEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewpointScoreBL.ReFreshCache();

if (clszx_ViewpointScoreBL.relatedActions != null)
{
clszx_ViewpointScoreBL.relatedActions.UpdRelaTabDate(objzx_ViewpointScoreEN.ViewpointScoreId, "SetUpdDate");
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
 /// <param name = "objzx_ViewpointScoreEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_ViewpointScoreEN objzx_ViewpointScoreEN, string strWhereCond)
{
try
{
bool bolResult = clszx_ViewpointScoreBL.zx_ViewpointScoreDA.UpdateBySqlWithCondition(objzx_ViewpointScoreEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewpointScoreBL.ReFreshCache();

if (clszx_ViewpointScoreBL.relatedActions != null)
{
clszx_ViewpointScoreBL.relatedActions.UpdRelaTabDate(objzx_ViewpointScoreEN.ViewpointScoreId, "SetUpdDate");
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
 /// <param name = "objzx_ViewpointScoreEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_ViewpointScoreEN objzx_ViewpointScoreEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clszx_ViewpointScoreBL.zx_ViewpointScoreDA.UpdateBySqlWithConditionTransaction(objzx_ViewpointScoreEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewpointScoreBL.ReFreshCache();

if (clszx_ViewpointScoreBL.relatedActions != null)
{
clszx_ViewpointScoreBL.relatedActions.UpdRelaTabDate(objzx_ViewpointScoreEN.ViewpointScoreId, "SetUpdDate");
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
 /// <param name = "lngViewpointScoreId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clszx_ViewpointScoreEN objzx_ViewpointScoreEN)
{
try
{
int intRecNum = clszx_ViewpointScoreBL.zx_ViewpointScoreDA.DelRecord(objzx_ViewpointScoreEN.ViewpointScoreId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewpointScoreBL.ReFreshCache();

if (clszx_ViewpointScoreBL.relatedActions != null)
{
clszx_ViewpointScoreBL.relatedActions.UpdRelaTabDate(objzx_ViewpointScoreEN.ViewpointScoreId, "SetUpdDate");
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
 /// <param name = "objzx_ViewpointScoreENS">源对象</param>
 /// <param name = "objzx_ViewpointScoreENT">目标对象</param>
 public static void CopyTo(this clszx_ViewpointScoreEN objzx_ViewpointScoreENS, clszx_ViewpointScoreEN objzx_ViewpointScoreENT)
{
try
{
objzx_ViewpointScoreENT.ViewpointScoreId = objzx_ViewpointScoreENS.ViewpointScoreId; //评分Id
objzx_ViewpointScoreENT.ViewpointScore = objzx_ViewpointScoreENS.ViewpointScore; //评分
objzx_ViewpointScoreENT.zxViewpointId = objzx_ViewpointScoreENS.zxViewpointId; //观点Id
objzx_ViewpointScoreENT.UpdDate = objzx_ViewpointScoreENS.UpdDate; //修改日期
objzx_ViewpointScoreENT.UpdUserId = objzx_ViewpointScoreENS.UpdUserId; //修改用户Id
objzx_ViewpointScoreENT.Memo = objzx_ViewpointScoreENS.Memo; //备注
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
 /// <param name = "objzx_ViewpointScoreENS">源对象</param>
 /// <returns>目标对象=>clszx_ViewpointScoreEN:objzx_ViewpointScoreENT</returns>
 public static clszx_ViewpointScoreEN CopyTo(this clszx_ViewpointScoreEN objzx_ViewpointScoreENS)
{
try
{
 clszx_ViewpointScoreEN objzx_ViewpointScoreENT = new clszx_ViewpointScoreEN()
{
ViewpointScoreId = objzx_ViewpointScoreENS.ViewpointScoreId, //评分Id
ViewpointScore = objzx_ViewpointScoreENS.ViewpointScore, //评分
zxViewpointId = objzx_ViewpointScoreENS.zxViewpointId, //观点Id
UpdDate = objzx_ViewpointScoreENS.UpdDate, //修改日期
UpdUserId = objzx_ViewpointScoreENS.UpdUserId, //修改用户Id
Memo = objzx_ViewpointScoreENS.Memo, //备注
};
 return objzx_ViewpointScoreENT;
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
public static void CheckPropertyNew(this clszx_ViewpointScoreEN objzx_ViewpointScoreEN)
{
 clszx_ViewpointScoreBL.zx_ViewpointScoreDA.CheckPropertyNew(objzx_ViewpointScoreEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clszx_ViewpointScoreEN objzx_ViewpointScoreEN)
{
 clszx_ViewpointScoreBL.zx_ViewpointScoreDA.CheckProperty4Condition(objzx_ViewpointScoreEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clszx_ViewpointScoreEN objzx_ViewpointScoreCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objzx_ViewpointScoreCond.IsUpdated(conzx_ViewpointScore.ViewpointScoreId) == true)
{
string strComparisonOpViewpointScoreId = objzx_ViewpointScoreCond.dicFldComparisonOp[conzx_ViewpointScore.ViewpointScoreId];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_ViewpointScore.ViewpointScoreId, objzx_ViewpointScoreCond.ViewpointScoreId, strComparisonOpViewpointScoreId);
}
if (objzx_ViewpointScoreCond.IsUpdated(conzx_ViewpointScore.ViewpointScore) == true)
{
string strComparisonOpViewpointScore = objzx_ViewpointScoreCond.dicFldComparisonOp[conzx_ViewpointScore.ViewpointScore];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_ViewpointScore.ViewpointScore, objzx_ViewpointScoreCond.ViewpointScore, strComparisonOpViewpointScore);
}
if (objzx_ViewpointScoreCond.IsUpdated(conzx_ViewpointScore.zxViewpointId) == true)
{
string strComparisonOpzxViewpointId = objzx_ViewpointScoreCond.dicFldComparisonOp[conzx_ViewpointScore.zxViewpointId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ViewpointScore.zxViewpointId, objzx_ViewpointScoreCond.zxViewpointId, strComparisonOpzxViewpointId);
}
if (objzx_ViewpointScoreCond.IsUpdated(conzx_ViewpointScore.UpdDate) == true)
{
string strComparisonOpUpdDate = objzx_ViewpointScoreCond.dicFldComparisonOp[conzx_ViewpointScore.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ViewpointScore.UpdDate, objzx_ViewpointScoreCond.UpdDate, strComparisonOpUpdDate);
}
if (objzx_ViewpointScoreCond.IsUpdated(conzx_ViewpointScore.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objzx_ViewpointScoreCond.dicFldComparisonOp[conzx_ViewpointScore.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ViewpointScore.UpdUserId, objzx_ViewpointScoreCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objzx_ViewpointScoreCond.IsUpdated(conzx_ViewpointScore.Memo) == true)
{
string strComparisonOpMemo = objzx_ViewpointScoreCond.dicFldComparisonOp[conzx_ViewpointScore.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ViewpointScore.Memo, objzx_ViewpointScoreCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--zx_ViewpointScore(中学观点评分表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:ViewpointScoreId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objzx_ViewpointScoreEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clszx_ViewpointScoreEN objzx_ViewpointScoreEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objzx_ViewpointScoreEN == null) return true;
if (objzx_ViewpointScoreEN.ViewpointScoreId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ViewpointScoreId = '{0}'", objzx_ViewpointScoreEN.ViewpointScoreId);
if (clszx_ViewpointScoreBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("ViewpointScoreId !=  {0}", objzx_ViewpointScoreEN.ViewpointScoreId);
 sbCondition.AppendFormat(" and ViewpointScoreId = '{0}'", objzx_ViewpointScoreEN.ViewpointScoreId);
if (clszx_ViewpointScoreBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--zx_ViewpointScore(中学观点评分表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ViewpointScoreId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objzx_ViewpointScoreEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clszx_ViewpointScoreEN objzx_ViewpointScoreEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objzx_ViewpointScoreEN == null) return "";
if (objzx_ViewpointScoreEN.ViewpointScoreId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ViewpointScoreId = '{0}'", objzx_ViewpointScoreEN.ViewpointScoreId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ViewpointScoreId !=  {0}", objzx_ViewpointScoreEN.ViewpointScoreId);
 sbCondition.AppendFormat(" and ViewpointScoreId = '{0}'", objzx_ViewpointScoreEN.ViewpointScoreId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_zx_ViewpointScore
{
public virtual bool UpdRelaTabDate(long lngViewpointScoreId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 中学观点评分表(zx_ViewpointScore)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clszx_ViewpointScoreBL
{
public static RelatedActions_zx_ViewpointScore relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clszx_ViewpointScoreDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clszx_ViewpointScoreDA zx_ViewpointScoreDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clszx_ViewpointScoreDA();
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
 public clszx_ViewpointScoreBL()
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
if (string.IsNullOrEmpty(clszx_ViewpointScoreEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_ViewpointScoreEN._ConnectString);
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
public static DataTable GetDataTable_zx_ViewpointScore(string strWhereCond)
{
DataTable objDT;
try
{
objDT = zx_ViewpointScoreDA.GetDataTable_zx_ViewpointScore(strWhereCond);
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
objDT = zx_ViewpointScoreDA.GetDataTable(strWhereCond);
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
objDT = zx_ViewpointScoreDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = zx_ViewpointScoreDA.GetDataTable(strWhereCond, strTabName);
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
objDT = zx_ViewpointScoreDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = zx_ViewpointScoreDA.GetDataTable_Top(objTopPara);
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
objDT = zx_ViewpointScoreDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = zx_ViewpointScoreDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = zx_ViewpointScoreDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrViewpointScoreIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clszx_ViewpointScoreEN> GetObjLstByViewpointScoreIdLst(List<long> arrViewpointScoreIdLst)
{
List<clszx_ViewpointScoreEN> arrObjLst = new List<clszx_ViewpointScoreEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrViewpointScoreIdLst);
 string strWhereCond = string.Format("ViewpointScoreId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ViewpointScoreEN objzx_ViewpointScoreEN = new clszx_ViewpointScoreEN();
try
{
objzx_ViewpointScoreEN.ViewpointScoreId = Int32.Parse(objRow[conzx_ViewpointScore.ViewpointScoreId].ToString().Trim()); //评分Id
objzx_ViewpointScoreEN.ViewpointScore = objRow[conzx_ViewpointScore.ViewpointScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ViewpointScore.ViewpointScore].ToString().Trim()); //评分
objzx_ViewpointScoreEN.zxViewpointId = objRow[conzx_ViewpointScore.zxViewpointId] == DBNull.Value ? null : objRow[conzx_ViewpointScore.zxViewpointId].ToString().Trim(); //观点Id
objzx_ViewpointScoreEN.UpdDate = objRow[conzx_ViewpointScore.UpdDate] == DBNull.Value ? null : objRow[conzx_ViewpointScore.UpdDate].ToString().Trim(); //修改日期
objzx_ViewpointScoreEN.UpdUserId = objRow[conzx_ViewpointScore.UpdUserId] == DBNull.Value ? null : objRow[conzx_ViewpointScore.UpdUserId].ToString().Trim(); //修改用户Id
objzx_ViewpointScoreEN.Memo = objRow[conzx_ViewpointScore.Memo] == DBNull.Value ? null : objRow[conzx_ViewpointScore.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ViewpointScoreEN.ViewpointScoreId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ViewpointScoreEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrViewpointScoreIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clszx_ViewpointScoreEN> GetObjLstByViewpointScoreIdLstCache(List<long> arrViewpointScoreIdLst)
{
string strKey = string.Format("{0}", clszx_ViewpointScoreEN._CurrTabName);
List<clszx_ViewpointScoreEN> arrzx_ViewpointScoreObjLstCache = GetObjLstCache();
IEnumerable <clszx_ViewpointScoreEN> arrzx_ViewpointScoreObjLst_Sel =
arrzx_ViewpointScoreObjLstCache
.Where(x => arrViewpointScoreIdLst.Contains(x.ViewpointScoreId));
return arrzx_ViewpointScoreObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_ViewpointScoreEN> GetObjLst(string strWhereCond)
{
List<clszx_ViewpointScoreEN> arrObjLst = new List<clszx_ViewpointScoreEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ViewpointScoreEN objzx_ViewpointScoreEN = new clszx_ViewpointScoreEN();
try
{
objzx_ViewpointScoreEN.ViewpointScoreId = Int32.Parse(objRow[conzx_ViewpointScore.ViewpointScoreId].ToString().Trim()); //评分Id
objzx_ViewpointScoreEN.ViewpointScore = objRow[conzx_ViewpointScore.ViewpointScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ViewpointScore.ViewpointScore].ToString().Trim()); //评分
objzx_ViewpointScoreEN.zxViewpointId = objRow[conzx_ViewpointScore.zxViewpointId] == DBNull.Value ? null : objRow[conzx_ViewpointScore.zxViewpointId].ToString().Trim(); //观点Id
objzx_ViewpointScoreEN.UpdDate = objRow[conzx_ViewpointScore.UpdDate] == DBNull.Value ? null : objRow[conzx_ViewpointScore.UpdDate].ToString().Trim(); //修改日期
objzx_ViewpointScoreEN.UpdUserId = objRow[conzx_ViewpointScore.UpdUserId] == DBNull.Value ? null : objRow[conzx_ViewpointScore.UpdUserId].ToString().Trim(); //修改用户Id
objzx_ViewpointScoreEN.Memo = objRow[conzx_ViewpointScore.Memo] == DBNull.Value ? null : objRow[conzx_ViewpointScore.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ViewpointScoreEN.ViewpointScoreId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ViewpointScoreEN);
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
public static List<clszx_ViewpointScoreEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clszx_ViewpointScoreEN> arrObjLst = new List<clszx_ViewpointScoreEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ViewpointScoreEN objzx_ViewpointScoreEN = new clszx_ViewpointScoreEN();
try
{
objzx_ViewpointScoreEN.ViewpointScoreId = Int32.Parse(objRow[conzx_ViewpointScore.ViewpointScoreId].ToString().Trim()); //评分Id
objzx_ViewpointScoreEN.ViewpointScore = objRow[conzx_ViewpointScore.ViewpointScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ViewpointScore.ViewpointScore].ToString().Trim()); //评分
objzx_ViewpointScoreEN.zxViewpointId = objRow[conzx_ViewpointScore.zxViewpointId] == DBNull.Value ? null : objRow[conzx_ViewpointScore.zxViewpointId].ToString().Trim(); //观点Id
objzx_ViewpointScoreEN.UpdDate = objRow[conzx_ViewpointScore.UpdDate] == DBNull.Value ? null : objRow[conzx_ViewpointScore.UpdDate].ToString().Trim(); //修改日期
objzx_ViewpointScoreEN.UpdUserId = objRow[conzx_ViewpointScore.UpdUserId] == DBNull.Value ? null : objRow[conzx_ViewpointScore.UpdUserId].ToString().Trim(); //修改用户Id
objzx_ViewpointScoreEN.Memo = objRow[conzx_ViewpointScore.Memo] == DBNull.Value ? null : objRow[conzx_ViewpointScore.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ViewpointScoreEN.ViewpointScoreId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ViewpointScoreEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objzx_ViewpointScoreCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clszx_ViewpointScoreEN> GetSubObjLstCache(clszx_ViewpointScoreEN objzx_ViewpointScoreCond)
{
List<clszx_ViewpointScoreEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clszx_ViewpointScoreEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_ViewpointScore.AttributeName)
{
if (objzx_ViewpointScoreCond.IsUpdated(strFldName) == false) continue;
if (objzx_ViewpointScoreCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_ViewpointScoreCond[strFldName].ToString());
}
else
{
if (objzx_ViewpointScoreCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_ViewpointScoreCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_ViewpointScoreCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_ViewpointScoreCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_ViewpointScoreCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_ViewpointScoreCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_ViewpointScoreCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_ViewpointScoreCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_ViewpointScoreCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_ViewpointScoreCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_ViewpointScoreCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_ViewpointScoreCond[strFldName]));
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
public static List<clszx_ViewpointScoreEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clszx_ViewpointScoreEN> arrObjLst = new List<clszx_ViewpointScoreEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ViewpointScoreEN objzx_ViewpointScoreEN = new clszx_ViewpointScoreEN();
try
{
objzx_ViewpointScoreEN.ViewpointScoreId = Int32.Parse(objRow[conzx_ViewpointScore.ViewpointScoreId].ToString().Trim()); //评分Id
objzx_ViewpointScoreEN.ViewpointScore = objRow[conzx_ViewpointScore.ViewpointScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ViewpointScore.ViewpointScore].ToString().Trim()); //评分
objzx_ViewpointScoreEN.zxViewpointId = objRow[conzx_ViewpointScore.zxViewpointId] == DBNull.Value ? null : objRow[conzx_ViewpointScore.zxViewpointId].ToString().Trim(); //观点Id
objzx_ViewpointScoreEN.UpdDate = objRow[conzx_ViewpointScore.UpdDate] == DBNull.Value ? null : objRow[conzx_ViewpointScore.UpdDate].ToString().Trim(); //修改日期
objzx_ViewpointScoreEN.UpdUserId = objRow[conzx_ViewpointScore.UpdUserId] == DBNull.Value ? null : objRow[conzx_ViewpointScore.UpdUserId].ToString().Trim(); //修改用户Id
objzx_ViewpointScoreEN.Memo = objRow[conzx_ViewpointScore.Memo] == DBNull.Value ? null : objRow[conzx_ViewpointScore.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ViewpointScoreEN.ViewpointScoreId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ViewpointScoreEN);
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
public static List<clszx_ViewpointScoreEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clszx_ViewpointScoreEN> arrObjLst = new List<clszx_ViewpointScoreEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ViewpointScoreEN objzx_ViewpointScoreEN = new clszx_ViewpointScoreEN();
try
{
objzx_ViewpointScoreEN.ViewpointScoreId = Int32.Parse(objRow[conzx_ViewpointScore.ViewpointScoreId].ToString().Trim()); //评分Id
objzx_ViewpointScoreEN.ViewpointScore = objRow[conzx_ViewpointScore.ViewpointScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ViewpointScore.ViewpointScore].ToString().Trim()); //评分
objzx_ViewpointScoreEN.zxViewpointId = objRow[conzx_ViewpointScore.zxViewpointId] == DBNull.Value ? null : objRow[conzx_ViewpointScore.zxViewpointId].ToString().Trim(); //观点Id
objzx_ViewpointScoreEN.UpdDate = objRow[conzx_ViewpointScore.UpdDate] == DBNull.Value ? null : objRow[conzx_ViewpointScore.UpdDate].ToString().Trim(); //修改日期
objzx_ViewpointScoreEN.UpdUserId = objRow[conzx_ViewpointScore.UpdUserId] == DBNull.Value ? null : objRow[conzx_ViewpointScore.UpdUserId].ToString().Trim(); //修改用户Id
objzx_ViewpointScoreEN.Memo = objRow[conzx_ViewpointScore.Memo] == DBNull.Value ? null : objRow[conzx_ViewpointScore.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ViewpointScoreEN.ViewpointScoreId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ViewpointScoreEN);
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
List<clszx_ViewpointScoreEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clszx_ViewpointScoreEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_ViewpointScoreEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clszx_ViewpointScoreEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clszx_ViewpointScoreEN> arrObjLst = new List<clszx_ViewpointScoreEN>(); 
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
	clszx_ViewpointScoreEN objzx_ViewpointScoreEN = new clszx_ViewpointScoreEN();
try
{
objzx_ViewpointScoreEN.ViewpointScoreId = Int32.Parse(objRow[conzx_ViewpointScore.ViewpointScoreId].ToString().Trim()); //评分Id
objzx_ViewpointScoreEN.ViewpointScore = objRow[conzx_ViewpointScore.ViewpointScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ViewpointScore.ViewpointScore].ToString().Trim()); //评分
objzx_ViewpointScoreEN.zxViewpointId = objRow[conzx_ViewpointScore.zxViewpointId] == DBNull.Value ? null : objRow[conzx_ViewpointScore.zxViewpointId].ToString().Trim(); //观点Id
objzx_ViewpointScoreEN.UpdDate = objRow[conzx_ViewpointScore.UpdDate] == DBNull.Value ? null : objRow[conzx_ViewpointScore.UpdDate].ToString().Trim(); //修改日期
objzx_ViewpointScoreEN.UpdUserId = objRow[conzx_ViewpointScore.UpdUserId] == DBNull.Value ? null : objRow[conzx_ViewpointScore.UpdUserId].ToString().Trim(); //修改用户Id
objzx_ViewpointScoreEN.Memo = objRow[conzx_ViewpointScore.Memo] == DBNull.Value ? null : objRow[conzx_ViewpointScore.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ViewpointScoreEN.ViewpointScoreId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ViewpointScoreEN);
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
public static List<clszx_ViewpointScoreEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clszx_ViewpointScoreEN> arrObjLst = new List<clszx_ViewpointScoreEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ViewpointScoreEN objzx_ViewpointScoreEN = new clszx_ViewpointScoreEN();
try
{
objzx_ViewpointScoreEN.ViewpointScoreId = Int32.Parse(objRow[conzx_ViewpointScore.ViewpointScoreId].ToString().Trim()); //评分Id
objzx_ViewpointScoreEN.ViewpointScore = objRow[conzx_ViewpointScore.ViewpointScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ViewpointScore.ViewpointScore].ToString().Trim()); //评分
objzx_ViewpointScoreEN.zxViewpointId = objRow[conzx_ViewpointScore.zxViewpointId] == DBNull.Value ? null : objRow[conzx_ViewpointScore.zxViewpointId].ToString().Trim(); //观点Id
objzx_ViewpointScoreEN.UpdDate = objRow[conzx_ViewpointScore.UpdDate] == DBNull.Value ? null : objRow[conzx_ViewpointScore.UpdDate].ToString().Trim(); //修改日期
objzx_ViewpointScoreEN.UpdUserId = objRow[conzx_ViewpointScore.UpdUserId] == DBNull.Value ? null : objRow[conzx_ViewpointScore.UpdUserId].ToString().Trim(); //修改用户Id
objzx_ViewpointScoreEN.Memo = objRow[conzx_ViewpointScore.Memo] == DBNull.Value ? null : objRow[conzx_ViewpointScore.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ViewpointScoreEN.ViewpointScoreId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ViewpointScoreEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clszx_ViewpointScoreEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clszx_ViewpointScoreEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clszx_ViewpointScoreEN> arrObjLst = new List<clszx_ViewpointScoreEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ViewpointScoreEN objzx_ViewpointScoreEN = new clszx_ViewpointScoreEN();
try
{
objzx_ViewpointScoreEN.ViewpointScoreId = Int32.Parse(objRow[conzx_ViewpointScore.ViewpointScoreId].ToString().Trim()); //评分Id
objzx_ViewpointScoreEN.ViewpointScore = objRow[conzx_ViewpointScore.ViewpointScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ViewpointScore.ViewpointScore].ToString().Trim()); //评分
objzx_ViewpointScoreEN.zxViewpointId = objRow[conzx_ViewpointScore.zxViewpointId] == DBNull.Value ? null : objRow[conzx_ViewpointScore.zxViewpointId].ToString().Trim(); //观点Id
objzx_ViewpointScoreEN.UpdDate = objRow[conzx_ViewpointScore.UpdDate] == DBNull.Value ? null : objRow[conzx_ViewpointScore.UpdDate].ToString().Trim(); //修改日期
objzx_ViewpointScoreEN.UpdUserId = objRow[conzx_ViewpointScore.UpdUserId] == DBNull.Value ? null : objRow[conzx_ViewpointScore.UpdUserId].ToString().Trim(); //修改用户Id
objzx_ViewpointScoreEN.Memo = objRow[conzx_ViewpointScore.Memo] == DBNull.Value ? null : objRow[conzx_ViewpointScore.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ViewpointScoreEN.ViewpointScoreId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ViewpointScoreEN);
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
public static List<clszx_ViewpointScoreEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clszx_ViewpointScoreEN> arrObjLst = new List<clszx_ViewpointScoreEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ViewpointScoreEN objzx_ViewpointScoreEN = new clszx_ViewpointScoreEN();
try
{
objzx_ViewpointScoreEN.ViewpointScoreId = Int32.Parse(objRow[conzx_ViewpointScore.ViewpointScoreId].ToString().Trim()); //评分Id
objzx_ViewpointScoreEN.ViewpointScore = objRow[conzx_ViewpointScore.ViewpointScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ViewpointScore.ViewpointScore].ToString().Trim()); //评分
objzx_ViewpointScoreEN.zxViewpointId = objRow[conzx_ViewpointScore.zxViewpointId] == DBNull.Value ? null : objRow[conzx_ViewpointScore.zxViewpointId].ToString().Trim(); //观点Id
objzx_ViewpointScoreEN.UpdDate = objRow[conzx_ViewpointScore.UpdDate] == DBNull.Value ? null : objRow[conzx_ViewpointScore.UpdDate].ToString().Trim(); //修改日期
objzx_ViewpointScoreEN.UpdUserId = objRow[conzx_ViewpointScore.UpdUserId] == DBNull.Value ? null : objRow[conzx_ViewpointScore.UpdUserId].ToString().Trim(); //修改用户Id
objzx_ViewpointScoreEN.Memo = objRow[conzx_ViewpointScore.Memo] == DBNull.Value ? null : objRow[conzx_ViewpointScore.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ViewpointScoreEN.ViewpointScoreId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ViewpointScoreEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_ViewpointScoreEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clszx_ViewpointScoreEN> arrObjLst = new List<clszx_ViewpointScoreEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ViewpointScoreEN objzx_ViewpointScoreEN = new clszx_ViewpointScoreEN();
try
{
objzx_ViewpointScoreEN.ViewpointScoreId = Int32.Parse(objRow[conzx_ViewpointScore.ViewpointScoreId].ToString().Trim()); //评分Id
objzx_ViewpointScoreEN.ViewpointScore = objRow[conzx_ViewpointScore.ViewpointScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ViewpointScore.ViewpointScore].ToString().Trim()); //评分
objzx_ViewpointScoreEN.zxViewpointId = objRow[conzx_ViewpointScore.zxViewpointId] == DBNull.Value ? null : objRow[conzx_ViewpointScore.zxViewpointId].ToString().Trim(); //观点Id
objzx_ViewpointScoreEN.UpdDate = objRow[conzx_ViewpointScore.UpdDate] == DBNull.Value ? null : objRow[conzx_ViewpointScore.UpdDate].ToString().Trim(); //修改日期
objzx_ViewpointScoreEN.UpdUserId = objRow[conzx_ViewpointScore.UpdUserId] == DBNull.Value ? null : objRow[conzx_ViewpointScore.UpdUserId].ToString().Trim(); //修改用户Id
objzx_ViewpointScoreEN.Memo = objRow[conzx_ViewpointScore.Memo] == DBNull.Value ? null : objRow[conzx_ViewpointScore.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ViewpointScoreEN.ViewpointScoreId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ViewpointScoreEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objzx_ViewpointScoreEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getzx_ViewpointScore(ref clszx_ViewpointScoreEN objzx_ViewpointScoreEN)
{
bool bolResult = zx_ViewpointScoreDA.Getzx_ViewpointScore(ref objzx_ViewpointScoreEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngViewpointScoreId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_ViewpointScoreEN GetObjByViewpointScoreId(long lngViewpointScoreId)
{
clszx_ViewpointScoreEN objzx_ViewpointScoreEN = zx_ViewpointScoreDA.GetObjByViewpointScoreId(lngViewpointScoreId);
return objzx_ViewpointScoreEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clszx_ViewpointScoreEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clszx_ViewpointScoreEN objzx_ViewpointScoreEN = zx_ViewpointScoreDA.GetFirstObj(strWhereCond);
 return objzx_ViewpointScoreEN;
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
public static clszx_ViewpointScoreEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clszx_ViewpointScoreEN objzx_ViewpointScoreEN = zx_ViewpointScoreDA.GetObjByDataRow(objRow);
 return objzx_ViewpointScoreEN;
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
public static clszx_ViewpointScoreEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clszx_ViewpointScoreEN objzx_ViewpointScoreEN = zx_ViewpointScoreDA.GetObjByDataRow(objRow);
 return objzx_ViewpointScoreEN;
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
 /// <param name = "lngViewpointScoreId">所给的关键字</param>
 /// <param name = "lstzx_ViewpointScoreObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_ViewpointScoreEN GetObjByViewpointScoreIdFromList(long lngViewpointScoreId, List<clszx_ViewpointScoreEN> lstzx_ViewpointScoreObjLst)
{
foreach (clszx_ViewpointScoreEN objzx_ViewpointScoreEN in lstzx_ViewpointScoreObjLst)
{
if (objzx_ViewpointScoreEN.ViewpointScoreId == lngViewpointScoreId)
{
return objzx_ViewpointScoreEN;
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
 long lngViewpointScoreId;
 try
 {
 lngViewpointScoreId = new clszx_ViewpointScoreDA().GetFirstID(strWhereCond);
 return lngViewpointScoreId;
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
 arrList = zx_ViewpointScoreDA.GetID(strWhereCond);
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
bool bolIsExist = zx_ViewpointScoreDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngViewpointScoreId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngViewpointScoreId)
{
//检测记录是否存在
bool bolIsExist = zx_ViewpointScoreDA.IsExist(lngViewpointScoreId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngViewpointScoreId">评分Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngViewpointScoreId, string strOpUser)
{
clszx_ViewpointScoreEN objzx_ViewpointScoreEN = clszx_ViewpointScoreBL.GetObjByViewpointScoreId(lngViewpointScoreId);
objzx_ViewpointScoreEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
return clszx_ViewpointScoreBL.UpdateBySql2(objzx_ViewpointScoreEN);
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
 bolIsExist = clszx_ViewpointScoreDA.IsExistTable();
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
 bolIsExist = zx_ViewpointScoreDA.IsExistTable(strTabName);
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
 /// <param name = "objzx_ViewpointScoreEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clszx_ViewpointScoreEN objzx_ViewpointScoreEN)
{
if (objzx_ViewpointScoreEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!评分Id = [{0}]的数据已经存在!(in clszx_ViewpointScoreBL.AddNewRecordBySql2)", objzx_ViewpointScoreEN.ViewpointScoreId);
throw new Exception(strMsg);
}
try
{
bool bolResult = zx_ViewpointScoreDA.AddNewRecordBySQL2(objzx_ViewpointScoreEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewpointScoreBL.ReFreshCache();

if (clszx_ViewpointScoreBL.relatedActions != null)
{
clszx_ViewpointScoreBL.relatedActions.UpdRelaTabDate(objzx_ViewpointScoreEN.ViewpointScoreId, "SetUpdDate");
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
 /// <param name = "objzx_ViewpointScoreEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clszx_ViewpointScoreEN objzx_ViewpointScoreEN)
{
if (objzx_ViewpointScoreEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!评分Id = [{0}]的数据已经存在!(in clszx_ViewpointScoreBL.AddNewRecordBySql2WithReturnKey)", objzx_ViewpointScoreEN.ViewpointScoreId);
throw new Exception(strMsg);
}
try
{
string strKey = zx_ViewpointScoreDA.AddNewRecordBySQL2WithReturnKey(objzx_ViewpointScoreEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewpointScoreBL.ReFreshCache();

if (clszx_ViewpointScoreBL.relatedActions != null)
{
clszx_ViewpointScoreBL.relatedActions.UpdRelaTabDate(objzx_ViewpointScoreEN.ViewpointScoreId, "SetUpdDate");
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
 /// <param name = "objzx_ViewpointScoreEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clszx_ViewpointScoreEN objzx_ViewpointScoreEN)
{
try
{
bool bolResult = zx_ViewpointScoreDA.Update(objzx_ViewpointScoreEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewpointScoreBL.ReFreshCache();

if (clszx_ViewpointScoreBL.relatedActions != null)
{
clszx_ViewpointScoreBL.relatedActions.UpdRelaTabDate(objzx_ViewpointScoreEN.ViewpointScoreId, "SetUpdDate");
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
 /// <param name = "objzx_ViewpointScoreEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clszx_ViewpointScoreEN objzx_ViewpointScoreEN)
{
 if (objzx_ViewpointScoreEN.ViewpointScoreId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = zx_ViewpointScoreDA.UpdateBySql2(objzx_ViewpointScoreEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewpointScoreBL.ReFreshCache();

if (clszx_ViewpointScoreBL.relatedActions != null)
{
clszx_ViewpointScoreBL.relatedActions.UpdRelaTabDate(objzx_ViewpointScoreEN.ViewpointScoreId, "SetUpdDate");
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
 /// <param name = "lngViewpointScoreId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngViewpointScoreId)
{
try
{
 clszx_ViewpointScoreEN objzx_ViewpointScoreEN = clszx_ViewpointScoreBL.GetObjByViewpointScoreId(lngViewpointScoreId);

if (clszx_ViewpointScoreBL.relatedActions != null)
{
clszx_ViewpointScoreBL.relatedActions.UpdRelaTabDate(objzx_ViewpointScoreEN.ViewpointScoreId, "SetUpdDate");
}
if (objzx_ViewpointScoreEN != null)
{
int intRecNum = zx_ViewpointScoreDA.DelRecord(lngViewpointScoreId);
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
/// <param name="lngViewpointScoreId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngViewpointScoreId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_ViewpointScoreDA.GetSpecSQLObj();
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
//删除与表:[zx_ViewpointScore]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conzx_ViewpointScore.ViewpointScoreId,
//lngViewpointScoreId);
//        clszx_ViewpointScoreBL.Delzx_ViewpointScoresByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_ViewpointScoreBL.DelRecord(lngViewpointScoreId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_ViewpointScoreBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngViewpointScoreId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngViewpointScoreId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngViewpointScoreId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clszx_ViewpointScoreBL.relatedActions != null)
{
clszx_ViewpointScoreBL.relatedActions.UpdRelaTabDate(lngViewpointScoreId, "UpdRelaTabDate");
}
bool bolResult = zx_ViewpointScoreDA.DelRecord(lngViewpointScoreId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrViewpointScoreIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delzx_ViewpointScores(List<string> arrViewpointScoreIdLst)
{
if (arrViewpointScoreIdLst.Count == 0) return 0;
try
{
if (clszx_ViewpointScoreBL.relatedActions != null)
{
foreach (var strViewpointScoreId in arrViewpointScoreIdLst)
{
long lngViewpointScoreId = long.Parse(strViewpointScoreId);
clszx_ViewpointScoreBL.relatedActions.UpdRelaTabDate(lngViewpointScoreId, "UpdRelaTabDate");
}
}
int intDelRecNum = zx_ViewpointScoreDA.Delzx_ViewpointScore(arrViewpointScoreIdLst);
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
public static int Delzx_ViewpointScoresByCond(string strWhereCond)
{
try
{
if (clszx_ViewpointScoreBL.relatedActions != null)
{
List<string> arrViewpointScoreId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strViewpointScoreId in arrViewpointScoreId)
{
long lngViewpointScoreId = long.Parse(strViewpointScoreId);
clszx_ViewpointScoreBL.relatedActions.UpdRelaTabDate(lngViewpointScoreId, "UpdRelaTabDate");
}
}
int intRecNum = zx_ViewpointScoreDA.Delzx_ViewpointScore(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[zx_ViewpointScore]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngViewpointScoreId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngViewpointScoreId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_ViewpointScoreDA.GetSpecSQLObj();
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
//删除与表:[zx_ViewpointScore]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_ViewpointScoreBL.DelRecord(lngViewpointScoreId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_ViewpointScoreBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngViewpointScoreId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objzx_ViewpointScoreENS">源对象</param>
 /// <param name = "objzx_ViewpointScoreENT">目标对象</param>
 public static void CopyTo(clszx_ViewpointScoreEN objzx_ViewpointScoreENS, clszx_ViewpointScoreEN objzx_ViewpointScoreENT)
{
try
{
objzx_ViewpointScoreENT.ViewpointScoreId = objzx_ViewpointScoreENS.ViewpointScoreId; //评分Id
objzx_ViewpointScoreENT.ViewpointScore = objzx_ViewpointScoreENS.ViewpointScore; //评分
objzx_ViewpointScoreENT.zxViewpointId = objzx_ViewpointScoreENS.zxViewpointId; //观点Id
objzx_ViewpointScoreENT.UpdDate = objzx_ViewpointScoreENS.UpdDate; //修改日期
objzx_ViewpointScoreENT.UpdUserId = objzx_ViewpointScoreENS.UpdUserId; //修改用户Id
objzx_ViewpointScoreENT.Memo = objzx_ViewpointScoreENS.Memo; //备注
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
 /// <param name = "objzx_ViewpointScoreEN">源简化对象</param>
 public static void SetUpdFlag(clszx_ViewpointScoreEN objzx_ViewpointScoreEN)
{
try
{
objzx_ViewpointScoreEN.ClearUpdateState();
   string strsfUpdFldSetStr = objzx_ViewpointScoreEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conzx_ViewpointScore.ViewpointScoreId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointScoreEN.ViewpointScoreId = objzx_ViewpointScoreEN.ViewpointScoreId; //评分Id
}
if (arrFldSet.Contains(conzx_ViewpointScore.ViewpointScore, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointScoreEN.ViewpointScore = objzx_ViewpointScoreEN.ViewpointScore; //评分
}
if (arrFldSet.Contains(conzx_ViewpointScore.zxViewpointId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointScoreEN.zxViewpointId = objzx_ViewpointScoreEN.zxViewpointId == "[null]" ? null :  objzx_ViewpointScoreEN.zxViewpointId; //观点Id
}
if (arrFldSet.Contains(conzx_ViewpointScore.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointScoreEN.UpdDate = objzx_ViewpointScoreEN.UpdDate == "[null]" ? null :  objzx_ViewpointScoreEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conzx_ViewpointScore.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointScoreEN.UpdUserId = objzx_ViewpointScoreEN.UpdUserId == "[null]" ? null :  objzx_ViewpointScoreEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conzx_ViewpointScore.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointScoreEN.Memo = objzx_ViewpointScoreEN.Memo == "[null]" ? null :  objzx_ViewpointScoreEN.Memo; //备注
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
 /// <param name = "objzx_ViewpointScoreEN">源简化对象</param>
 public static void AccessFldValueNull(clszx_ViewpointScoreEN objzx_ViewpointScoreEN)
{
try
{
if (objzx_ViewpointScoreEN.zxViewpointId == "[null]") objzx_ViewpointScoreEN.zxViewpointId = null; //观点Id
if (objzx_ViewpointScoreEN.UpdDate == "[null]") objzx_ViewpointScoreEN.UpdDate = null; //修改日期
if (objzx_ViewpointScoreEN.UpdUserId == "[null]") objzx_ViewpointScoreEN.UpdUserId = null; //修改用户Id
if (objzx_ViewpointScoreEN.Memo == "[null]") objzx_ViewpointScoreEN.Memo = null; //备注
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
public static void CheckPropertyNew(clszx_ViewpointScoreEN objzx_ViewpointScoreEN)
{
 zx_ViewpointScoreDA.CheckPropertyNew(objzx_ViewpointScoreEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clszx_ViewpointScoreEN objzx_ViewpointScoreEN)
{
 zx_ViewpointScoreDA.CheckProperty4Condition(objzx_ViewpointScoreEN);
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
if (clszx_ViewpointScoreBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_ViewpointScoreBL没有刷新缓存机制(clszx_ViewpointScoreBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ViewpointScoreId");
//if (arrzx_ViewpointScoreObjLstCache == null)
//{
//arrzx_ViewpointScoreObjLstCache = zx_ViewpointScoreDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngViewpointScoreId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_ViewpointScoreEN GetObjByViewpointScoreIdCache(long lngViewpointScoreId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clszx_ViewpointScoreEN._CurrTabName);
List<clszx_ViewpointScoreEN> arrzx_ViewpointScoreObjLstCache = GetObjLstCache();
IEnumerable <clszx_ViewpointScoreEN> arrzx_ViewpointScoreObjLst_Sel =
arrzx_ViewpointScoreObjLstCache
.Where(x=> x.ViewpointScoreId == lngViewpointScoreId 
);
if (arrzx_ViewpointScoreObjLst_Sel.Count() == 0)
{
   clszx_ViewpointScoreEN obj = clszx_ViewpointScoreBL.GetObjByViewpointScoreId(lngViewpointScoreId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrzx_ViewpointScoreObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_ViewpointScoreEN> GetAllzx_ViewpointScoreObjLstCache()
{
//获取缓存中的对象列表
List<clszx_ViewpointScoreEN> arrzx_ViewpointScoreObjLstCache = GetObjLstCache(); 
return arrzx_ViewpointScoreObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_ViewpointScoreEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clszx_ViewpointScoreEN._CurrTabName);
List<clszx_ViewpointScoreEN> arrzx_ViewpointScoreObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrzx_ViewpointScoreObjLstCache;
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
string strKey = string.Format("{0}", clszx_ViewpointScoreEN._CurrTabName);
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
if (clszx_ViewpointScoreBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clszx_ViewpointScoreEN._CurrTabName);
CacheHelper.Remove(strKey);
clszx_ViewpointScoreBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--zx_ViewpointScore(中学观点评分表)
 /// 唯一性条件:ViewpointScoreId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_ViewpointScoreEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clszx_ViewpointScoreEN objzx_ViewpointScoreEN)
{
//检测记录是否存在
string strResult = zx_ViewpointScoreDA.GetUniCondStr(objzx_ViewpointScoreEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-11-15
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngViewpointScoreId)
{
if (strInFldName != conzx_ViewpointScore.ViewpointScoreId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conzx_ViewpointScore.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conzx_ViewpointScore.AttributeName));
throw new Exception(strMsg);
}
var objzx_ViewpointScore = clszx_ViewpointScoreBL.GetObjByViewpointScoreIdCache(lngViewpointScoreId);
if (objzx_ViewpointScore == null) return "";
return objzx_ViewpointScore[strOutFldName].ToString();
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
int intRecCount = clszx_ViewpointScoreDA.GetRecCount(strTabName);
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
int intRecCount = clszx_ViewpointScoreDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clszx_ViewpointScoreDA.GetRecCount();
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
int intRecCount = clszx_ViewpointScoreDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objzx_ViewpointScoreCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clszx_ViewpointScoreEN objzx_ViewpointScoreCond)
{
List<clszx_ViewpointScoreEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clszx_ViewpointScoreEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_ViewpointScore.AttributeName)
{
if (objzx_ViewpointScoreCond.IsUpdated(strFldName) == false) continue;
if (objzx_ViewpointScoreCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_ViewpointScoreCond[strFldName].ToString());
}
else
{
if (objzx_ViewpointScoreCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_ViewpointScoreCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_ViewpointScoreCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_ViewpointScoreCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_ViewpointScoreCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_ViewpointScoreCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_ViewpointScoreCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_ViewpointScoreCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_ViewpointScoreCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_ViewpointScoreCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_ViewpointScoreCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_ViewpointScoreCond[strFldName]));
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
 List<string> arrList = clszx_ViewpointScoreDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = zx_ViewpointScoreDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = zx_ViewpointScoreDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = zx_ViewpointScoreDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_ViewpointScoreDA.SetFldValue(clszx_ViewpointScoreEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = zx_ViewpointScoreDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_ViewpointScoreDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_ViewpointScoreDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_ViewpointScoreDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[zx_ViewpointScore] "); 
 strCreateTabCode.Append(" ( "); 
 // /**评分Id*/ 
 strCreateTabCode.Append(" ViewpointScoreId bigint primary key identity, "); 
 // /**评分*/ 
 strCreateTabCode.Append(" ViewpointScore float Null, "); 
 // /**观点Id*/ 
 strCreateTabCode.Append(" zxViewpointId char(8) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 中学观点评分表(zx_ViewpointScore)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4zx_ViewpointScore : clsCommFun4BL
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
clszx_ViewpointScoreBL.ReFreshThisCache();
}
}

}