
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPaperDownloadLogBL
 表名:PaperDownloadLog(01120571)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:10:49
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
public static class  clsPaperDownloadLogBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngPaperDownloadId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPaperDownloadLogEN GetObj(this K_PaperDownloadId_PaperDownloadLog myKey)
{
clsPaperDownloadLogEN objPaperDownloadLogEN = clsPaperDownloadLogBL.PaperDownloadLogDA.GetObjByPaperDownloadId(myKey.Value);
return objPaperDownloadLogEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objPaperDownloadLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsPaperDownloadLogEN objPaperDownloadLogEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objPaperDownloadLogEN) == false)
{
var strMsg = string.Format("记录已经存在!PaperDownloadId = [{0}]的数据已经存在!(in clsPaperDownloadLogBL.AddNewRecord)", objPaperDownloadLogEN.PaperDownloadId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsPaperDownloadLogBL.PaperDownloadLogDA.AddNewRecordBySQL2(objPaperDownloadLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperDownloadLogBL.ReFreshCache();

if (clsPaperDownloadLogBL.relatedActions != null)
{
clsPaperDownloadLogBL.relatedActions.UpdRelaTabDate(objPaperDownloadLogEN.PaperDownloadId, objPaperDownloadLogEN.UpdUser);
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
public static bool AddRecordEx(this clsPaperDownloadLogEN objPaperDownloadLogEN, bool bolIsNeedCheckUniqueness = true)
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
objPaperDownloadLogEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objPaperDownloadLogEN.CheckUniqueness() == false)
{
strMsg = string.Format("(PaperDownloadId(PaperDownloadId)=[{0}])已经存在,不能重复!", objPaperDownloadLogEN.PaperDownloadId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objPaperDownloadLogEN.AddNewRecord();
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
 /// <param name = "objPaperDownloadLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsPaperDownloadLogEN objPaperDownloadLogEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objPaperDownloadLogEN) == false)
{
var strMsg = string.Format("记录已经存在!PaperDownloadId = [{0}]的数据已经存在!(in clsPaperDownloadLogBL.AddNewRecordWithReturnKey)", objPaperDownloadLogEN.PaperDownloadId);
throw new Exception(strMsg);
}
try
{
string strKey = clsPaperDownloadLogBL.PaperDownloadLogDA.AddNewRecordBySQL2WithReturnKey(objPaperDownloadLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperDownloadLogBL.ReFreshCache();

if (clsPaperDownloadLogBL.relatedActions != null)
{
clsPaperDownloadLogBL.relatedActions.UpdRelaTabDate(objPaperDownloadLogEN.PaperDownloadId, objPaperDownloadLogEN.UpdUser);
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
 /// <param name = "objPaperDownloadLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperDownloadLogEN SetPaperDownloadId(this clsPaperDownloadLogEN objPaperDownloadLogEN, long lngPaperDownloadId, string strComparisonOp="")
	{
objPaperDownloadLogEN.PaperDownloadId = lngPaperDownloadId; //PaperDownloadId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperDownloadLogEN.dicFldComparisonOp.ContainsKey(conPaperDownloadLog.PaperDownloadId) == false)
{
objPaperDownloadLogEN.dicFldComparisonOp.Add(conPaperDownloadLog.PaperDownloadId, strComparisonOp);
}
else
{
objPaperDownloadLogEN.dicFldComparisonOp[conPaperDownloadLog.PaperDownloadId] = strComparisonOp;
}
}
return objPaperDownloadLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperDownloadLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperDownloadLogEN SetDownloadFile(this clsPaperDownloadLogEN objPaperDownloadLogEN, string strDownloadFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDownloadFile, 500, conPaperDownloadLog.DownloadFile);
}
objPaperDownloadLogEN.DownloadFile = strDownloadFile; //DownloadFile
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperDownloadLogEN.dicFldComparisonOp.ContainsKey(conPaperDownloadLog.DownloadFile) == false)
{
objPaperDownloadLogEN.dicFldComparisonOp.Add(conPaperDownloadLog.DownloadFile, strComparisonOp);
}
else
{
objPaperDownloadLogEN.dicFldComparisonOp[conPaperDownloadLog.DownloadFile] = strComparisonOp;
}
}
return objPaperDownloadLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperDownloadLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperDownloadLogEN SetDownloadLink(this clsPaperDownloadLogEN objPaperDownloadLogEN, string strDownloadLink, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDownloadLink, 500, conPaperDownloadLog.DownloadLink);
}
objPaperDownloadLogEN.DownloadLink = strDownloadLink; //DownloadLink
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperDownloadLogEN.dicFldComparisonOp.ContainsKey(conPaperDownloadLog.DownloadLink) == false)
{
objPaperDownloadLogEN.dicFldComparisonOp.Add(conPaperDownloadLog.DownloadLink, strComparisonOp);
}
else
{
objPaperDownloadLogEN.dicFldComparisonOp[conPaperDownloadLog.DownloadLink] = strComparisonOp;
}
}
return objPaperDownloadLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperDownloadLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperDownloadLogEN SetPaperId(this clsPaperDownloadLogEN objPaperDownloadLogEN, string strPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperId, 8, conPaperDownloadLog.PaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, conPaperDownloadLog.PaperId);
}
objPaperDownloadLogEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperDownloadLogEN.dicFldComparisonOp.ContainsKey(conPaperDownloadLog.PaperId) == false)
{
objPaperDownloadLogEN.dicFldComparisonOp.Add(conPaperDownloadLog.PaperId, strComparisonOp);
}
else
{
objPaperDownloadLogEN.dicFldComparisonOp[conPaperDownloadLog.PaperId] = strComparisonOp;
}
}
return objPaperDownloadLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperDownloadLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperDownloadLogEN SetUpdUser(this clsPaperDownloadLogEN objPaperDownloadLogEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conPaperDownloadLog.UpdUser);
}
objPaperDownloadLogEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperDownloadLogEN.dicFldComparisonOp.ContainsKey(conPaperDownloadLog.UpdUser) == false)
{
objPaperDownloadLogEN.dicFldComparisonOp.Add(conPaperDownloadLog.UpdUser, strComparisonOp);
}
else
{
objPaperDownloadLogEN.dicFldComparisonOp[conPaperDownloadLog.UpdUser] = strComparisonOp;
}
}
return objPaperDownloadLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperDownloadLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperDownloadLogEN SetUpdDate(this clsPaperDownloadLogEN objPaperDownloadLogEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conPaperDownloadLog.UpdDate);
}
objPaperDownloadLogEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperDownloadLogEN.dicFldComparisonOp.ContainsKey(conPaperDownloadLog.UpdDate) == false)
{
objPaperDownloadLogEN.dicFldComparisonOp.Add(conPaperDownloadLog.UpdDate, strComparisonOp);
}
else
{
objPaperDownloadLogEN.dicFldComparisonOp[conPaperDownloadLog.UpdDate] = strComparisonOp;
}
}
return objPaperDownloadLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperDownloadLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperDownloadLogEN SetMemo(this clsPaperDownloadLogEN objPaperDownloadLogEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conPaperDownloadLog.Memo);
}
objPaperDownloadLogEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperDownloadLogEN.dicFldComparisonOp.ContainsKey(conPaperDownloadLog.Memo) == false)
{
objPaperDownloadLogEN.dicFldComparisonOp.Add(conPaperDownloadLog.Memo, strComparisonOp);
}
else
{
objPaperDownloadLogEN.dicFldComparisonOp[conPaperDownloadLog.Memo] = strComparisonOp;
}
}
return objPaperDownloadLogEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objPaperDownloadLogEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsPaperDownloadLogEN objPaperDownloadLogEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objPaperDownloadLogEN.CheckPropertyNew();
clsPaperDownloadLogEN objPaperDownloadLogCond = new clsPaperDownloadLogEN();
string strCondition = objPaperDownloadLogCond
.SetPaperDownloadId(objPaperDownloadLogEN.PaperDownloadId, "<>")
.SetPaperDownloadId(objPaperDownloadLogEN.PaperDownloadId, "=")
.GetCombineCondition();
objPaperDownloadLogEN._IsCheckProperty = true;
bool bolIsExist = clsPaperDownloadLogBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(PaperDownloadId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objPaperDownloadLogEN.Update();
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
 /// <param name = "objPaperDownloadLog">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsPaperDownloadLogEN objPaperDownloadLog)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsPaperDownloadLogEN objPaperDownloadLogCond = new clsPaperDownloadLogEN();
string strCondition = objPaperDownloadLogCond
.SetPaperDownloadId(objPaperDownloadLog.PaperDownloadId, "=")
.GetCombineCondition();
objPaperDownloadLog._IsCheckProperty = true;
bool bolIsExist = clsPaperDownloadLogBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objPaperDownloadLog.PaperDownloadId = clsPaperDownloadLogBL.GetFirstID_S(strCondition);
objPaperDownloadLog.UpdateWithCondition(strCondition);
}
else
{
objPaperDownloadLog.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objPaperDownloadLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPaperDownloadLogEN objPaperDownloadLogEN)
{
 if (objPaperDownloadLogEN.PaperDownloadId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPaperDownloadLogBL.PaperDownloadLogDA.UpdateBySql2(objPaperDownloadLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperDownloadLogBL.ReFreshCache();

if (clsPaperDownloadLogBL.relatedActions != null)
{
clsPaperDownloadLogBL.relatedActions.UpdRelaTabDate(objPaperDownloadLogEN.PaperDownloadId, objPaperDownloadLogEN.UpdUser);
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
 /// <param name = "objPaperDownloadLogEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPaperDownloadLogEN objPaperDownloadLogEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objPaperDownloadLogEN.PaperDownloadId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPaperDownloadLogBL.PaperDownloadLogDA.UpdateBySql2(objPaperDownloadLogEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperDownloadLogBL.ReFreshCache();

if (clsPaperDownloadLogBL.relatedActions != null)
{
clsPaperDownloadLogBL.relatedActions.UpdRelaTabDate(objPaperDownloadLogEN.PaperDownloadId, objPaperDownloadLogEN.UpdUser);
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
 /// <param name = "objPaperDownloadLogEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPaperDownloadLogEN objPaperDownloadLogEN, string strWhereCond)
{
try
{
bool bolResult = clsPaperDownloadLogBL.PaperDownloadLogDA.UpdateBySqlWithCondition(objPaperDownloadLogEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperDownloadLogBL.ReFreshCache();

if (clsPaperDownloadLogBL.relatedActions != null)
{
clsPaperDownloadLogBL.relatedActions.UpdRelaTabDate(objPaperDownloadLogEN.PaperDownloadId, objPaperDownloadLogEN.UpdUser);
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
 /// <param name = "objPaperDownloadLogEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPaperDownloadLogEN objPaperDownloadLogEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsPaperDownloadLogBL.PaperDownloadLogDA.UpdateBySqlWithConditionTransaction(objPaperDownloadLogEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperDownloadLogBL.ReFreshCache();

if (clsPaperDownloadLogBL.relatedActions != null)
{
clsPaperDownloadLogBL.relatedActions.UpdRelaTabDate(objPaperDownloadLogEN.PaperDownloadId, objPaperDownloadLogEN.UpdUser);
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
 /// <param name = "lngPaperDownloadId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsPaperDownloadLogEN objPaperDownloadLogEN)
{
try
{
int intRecNum = clsPaperDownloadLogBL.PaperDownloadLogDA.DelRecord(objPaperDownloadLogEN.PaperDownloadId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperDownloadLogBL.ReFreshCache();

if (clsPaperDownloadLogBL.relatedActions != null)
{
clsPaperDownloadLogBL.relatedActions.UpdRelaTabDate(objPaperDownloadLogEN.PaperDownloadId, objPaperDownloadLogEN.UpdUser);
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
 /// <param name = "objPaperDownloadLogENS">源对象</param>
 /// <param name = "objPaperDownloadLogENT">目标对象</param>
 public static void CopyTo(this clsPaperDownloadLogEN objPaperDownloadLogENS, clsPaperDownloadLogEN objPaperDownloadLogENT)
{
try
{
objPaperDownloadLogENT.PaperDownloadId = objPaperDownloadLogENS.PaperDownloadId; //PaperDownloadId
objPaperDownloadLogENT.DownloadFile = objPaperDownloadLogENS.DownloadFile; //DownloadFile
objPaperDownloadLogENT.DownloadLink = objPaperDownloadLogENS.DownloadLink; //DownloadLink
objPaperDownloadLogENT.PaperId = objPaperDownloadLogENS.PaperId; //论文Id
objPaperDownloadLogENT.UpdUser = objPaperDownloadLogENS.UpdUser; //修改人
objPaperDownloadLogENT.UpdDate = objPaperDownloadLogENS.UpdDate; //修改日期
objPaperDownloadLogENT.Memo = objPaperDownloadLogENS.Memo; //备注
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
 /// <param name = "objPaperDownloadLogENS">源对象</param>
 /// <returns>目标对象=>clsPaperDownloadLogEN:objPaperDownloadLogENT</returns>
 public static clsPaperDownloadLogEN CopyTo(this clsPaperDownloadLogEN objPaperDownloadLogENS)
{
try
{
 clsPaperDownloadLogEN objPaperDownloadLogENT = new clsPaperDownloadLogEN()
{
PaperDownloadId = objPaperDownloadLogENS.PaperDownloadId, //PaperDownloadId
DownloadFile = objPaperDownloadLogENS.DownloadFile, //DownloadFile
DownloadLink = objPaperDownloadLogENS.DownloadLink, //DownloadLink
PaperId = objPaperDownloadLogENS.PaperId, //论文Id
UpdUser = objPaperDownloadLogENS.UpdUser, //修改人
UpdDate = objPaperDownloadLogENS.UpdDate, //修改日期
Memo = objPaperDownloadLogENS.Memo, //备注
};
 return objPaperDownloadLogENT;
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
public static void CheckPropertyNew(this clsPaperDownloadLogEN objPaperDownloadLogEN)
{
 clsPaperDownloadLogBL.PaperDownloadLogDA.CheckPropertyNew(objPaperDownloadLogEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsPaperDownloadLogEN objPaperDownloadLogEN)
{
 clsPaperDownloadLogBL.PaperDownloadLogDA.CheckProperty4Condition(objPaperDownloadLogEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsPaperDownloadLogEN objPaperDownloadLogCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objPaperDownloadLogCond.IsUpdated(conPaperDownloadLog.PaperDownloadId) == true)
{
string strComparisonOpPaperDownloadId = objPaperDownloadLogCond.dicFldComparisonOp[conPaperDownloadLog.PaperDownloadId];
strWhereCond += string.Format(" And {0} {2} {1}", conPaperDownloadLog.PaperDownloadId, objPaperDownloadLogCond.PaperDownloadId, strComparisonOpPaperDownloadId);
}
if (objPaperDownloadLogCond.IsUpdated(conPaperDownloadLog.DownloadFile) == true)
{
string strComparisonOpDownloadFile = objPaperDownloadLogCond.dicFldComparisonOp[conPaperDownloadLog.DownloadFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperDownloadLog.DownloadFile, objPaperDownloadLogCond.DownloadFile, strComparisonOpDownloadFile);
}
if (objPaperDownloadLogCond.IsUpdated(conPaperDownloadLog.DownloadLink) == true)
{
string strComparisonOpDownloadLink = objPaperDownloadLogCond.dicFldComparisonOp[conPaperDownloadLog.DownloadLink];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperDownloadLog.DownloadLink, objPaperDownloadLogCond.DownloadLink, strComparisonOpDownloadLink);
}
if (objPaperDownloadLogCond.IsUpdated(conPaperDownloadLog.PaperId) == true)
{
string strComparisonOpPaperId = objPaperDownloadLogCond.dicFldComparisonOp[conPaperDownloadLog.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperDownloadLog.PaperId, objPaperDownloadLogCond.PaperId, strComparisonOpPaperId);
}
if (objPaperDownloadLogCond.IsUpdated(conPaperDownloadLog.UpdUser) == true)
{
string strComparisonOpUpdUser = objPaperDownloadLogCond.dicFldComparisonOp[conPaperDownloadLog.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperDownloadLog.UpdUser, objPaperDownloadLogCond.UpdUser, strComparisonOpUpdUser);
}
if (objPaperDownloadLogCond.IsUpdated(conPaperDownloadLog.UpdDate) == true)
{
string strComparisonOpUpdDate = objPaperDownloadLogCond.dicFldComparisonOp[conPaperDownloadLog.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperDownloadLog.UpdDate, objPaperDownloadLogCond.UpdDate, strComparisonOpUpdDate);
}
if (objPaperDownloadLogCond.IsUpdated(conPaperDownloadLog.Memo) == true)
{
string strComparisonOpMemo = objPaperDownloadLogCond.dicFldComparisonOp[conPaperDownloadLog.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperDownloadLog.Memo, objPaperDownloadLogCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--PaperDownloadLog(论文下载记录), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:PaperDownloadId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objPaperDownloadLogEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsPaperDownloadLogEN objPaperDownloadLogEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objPaperDownloadLogEN == null) return true;
if (objPaperDownloadLogEN.PaperDownloadId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PaperDownloadId = '{0}'", objPaperDownloadLogEN.PaperDownloadId);
if (clsPaperDownloadLogBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("PaperDownloadId !=  {0}", objPaperDownloadLogEN.PaperDownloadId);
 sbCondition.AppendFormat(" and PaperDownloadId = '{0}'", objPaperDownloadLogEN.PaperDownloadId);
if (clsPaperDownloadLogBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--PaperDownloadLog(论文下载记录), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PaperDownloadId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objPaperDownloadLogEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsPaperDownloadLogEN objPaperDownloadLogEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objPaperDownloadLogEN == null) return "";
if (objPaperDownloadLogEN.PaperDownloadId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PaperDownloadId = '{0}'", objPaperDownloadLogEN.PaperDownloadId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("PaperDownloadId !=  {0}", objPaperDownloadLogEN.PaperDownloadId);
 sbCondition.AppendFormat(" and PaperDownloadId = '{0}'", objPaperDownloadLogEN.PaperDownloadId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_PaperDownloadLog
{
public virtual bool UpdRelaTabDate(long lngPaperDownloadId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 论文下载记录(PaperDownloadLog)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsPaperDownloadLogBL
{
public static RelatedActions_PaperDownloadLog relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsPaperDownloadLogDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsPaperDownloadLogDA PaperDownloadLogDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsPaperDownloadLogDA();
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
 public clsPaperDownloadLogBL()
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
if (string.IsNullOrEmpty(clsPaperDownloadLogEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsPaperDownloadLogEN._ConnectString);
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
public static DataTable GetDataTable_PaperDownloadLog(string strWhereCond)
{
DataTable objDT;
try
{
objDT = PaperDownloadLogDA.GetDataTable_PaperDownloadLog(strWhereCond);
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
objDT = PaperDownloadLogDA.GetDataTable(strWhereCond);
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
objDT = PaperDownloadLogDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = PaperDownloadLogDA.GetDataTable(strWhereCond, strTabName);
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
objDT = PaperDownloadLogDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = PaperDownloadLogDA.GetDataTable_Top(objTopPara);
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
objDT = PaperDownloadLogDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = PaperDownloadLogDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = PaperDownloadLogDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrPaperDownloadIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsPaperDownloadLogEN> GetObjLstByPaperDownloadIdLst(List<long> arrPaperDownloadIdLst)
{
List<clsPaperDownloadLogEN> arrObjLst = new List<clsPaperDownloadLogEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrPaperDownloadIdLst);
 string strWhereCond = string.Format("PaperDownloadId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperDownloadLogEN objPaperDownloadLogEN = new clsPaperDownloadLogEN();
try
{
objPaperDownloadLogEN.PaperDownloadId = Int32.Parse(objRow[conPaperDownloadLog.PaperDownloadId].ToString().Trim()); //PaperDownloadId
objPaperDownloadLogEN.DownloadFile = objRow[conPaperDownloadLog.DownloadFile] == DBNull.Value ? null : objRow[conPaperDownloadLog.DownloadFile].ToString().Trim(); //DownloadFile
objPaperDownloadLogEN.DownloadLink = objRow[conPaperDownloadLog.DownloadLink] == DBNull.Value ? null : objRow[conPaperDownloadLog.DownloadLink].ToString().Trim(); //DownloadLink
objPaperDownloadLogEN.PaperId = objRow[conPaperDownloadLog.PaperId] == DBNull.Value ? null : objRow[conPaperDownloadLog.PaperId].ToString().Trim(); //论文Id
objPaperDownloadLogEN.UpdUser = objRow[conPaperDownloadLog.UpdUser] == DBNull.Value ? null : objRow[conPaperDownloadLog.UpdUser].ToString().Trim(); //修改人
objPaperDownloadLogEN.UpdDate = objRow[conPaperDownloadLog.UpdDate] == DBNull.Value ? null : objRow[conPaperDownloadLog.UpdDate].ToString().Trim(); //修改日期
objPaperDownloadLogEN.Memo = objRow[conPaperDownloadLog.Memo] == DBNull.Value ? null : objRow[conPaperDownloadLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperDownloadLogEN.PaperDownloadId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperDownloadLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPaperDownloadIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsPaperDownloadLogEN> GetObjLstByPaperDownloadIdLstCache(List<long> arrPaperDownloadIdLst)
{
string strKey = string.Format("{0}", clsPaperDownloadLogEN._CurrTabName);
List<clsPaperDownloadLogEN> arrPaperDownloadLogObjLstCache = GetObjLstCache();
IEnumerable <clsPaperDownloadLogEN> arrPaperDownloadLogObjLst_Sel =
arrPaperDownloadLogObjLstCache
.Where(x => arrPaperDownloadIdLst.Contains(x.PaperDownloadId));
return arrPaperDownloadLogObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsPaperDownloadLogEN> GetObjLst(string strWhereCond)
{
List<clsPaperDownloadLogEN> arrObjLst = new List<clsPaperDownloadLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperDownloadLogEN objPaperDownloadLogEN = new clsPaperDownloadLogEN();
try
{
objPaperDownloadLogEN.PaperDownloadId = Int32.Parse(objRow[conPaperDownloadLog.PaperDownloadId].ToString().Trim()); //PaperDownloadId
objPaperDownloadLogEN.DownloadFile = objRow[conPaperDownloadLog.DownloadFile] == DBNull.Value ? null : objRow[conPaperDownloadLog.DownloadFile].ToString().Trim(); //DownloadFile
objPaperDownloadLogEN.DownloadLink = objRow[conPaperDownloadLog.DownloadLink] == DBNull.Value ? null : objRow[conPaperDownloadLog.DownloadLink].ToString().Trim(); //DownloadLink
objPaperDownloadLogEN.PaperId = objRow[conPaperDownloadLog.PaperId] == DBNull.Value ? null : objRow[conPaperDownloadLog.PaperId].ToString().Trim(); //论文Id
objPaperDownloadLogEN.UpdUser = objRow[conPaperDownloadLog.UpdUser] == DBNull.Value ? null : objRow[conPaperDownloadLog.UpdUser].ToString().Trim(); //修改人
objPaperDownloadLogEN.UpdDate = objRow[conPaperDownloadLog.UpdDate] == DBNull.Value ? null : objRow[conPaperDownloadLog.UpdDate].ToString().Trim(); //修改日期
objPaperDownloadLogEN.Memo = objRow[conPaperDownloadLog.Memo] == DBNull.Value ? null : objRow[conPaperDownloadLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperDownloadLogEN.PaperDownloadId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperDownloadLogEN);
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
public static List<clsPaperDownloadLogEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsPaperDownloadLogEN> arrObjLst = new List<clsPaperDownloadLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperDownloadLogEN objPaperDownloadLogEN = new clsPaperDownloadLogEN();
try
{
objPaperDownloadLogEN.PaperDownloadId = Int32.Parse(objRow[conPaperDownloadLog.PaperDownloadId].ToString().Trim()); //PaperDownloadId
objPaperDownloadLogEN.DownloadFile = objRow[conPaperDownloadLog.DownloadFile] == DBNull.Value ? null : objRow[conPaperDownloadLog.DownloadFile].ToString().Trim(); //DownloadFile
objPaperDownloadLogEN.DownloadLink = objRow[conPaperDownloadLog.DownloadLink] == DBNull.Value ? null : objRow[conPaperDownloadLog.DownloadLink].ToString().Trim(); //DownloadLink
objPaperDownloadLogEN.PaperId = objRow[conPaperDownloadLog.PaperId] == DBNull.Value ? null : objRow[conPaperDownloadLog.PaperId].ToString().Trim(); //论文Id
objPaperDownloadLogEN.UpdUser = objRow[conPaperDownloadLog.UpdUser] == DBNull.Value ? null : objRow[conPaperDownloadLog.UpdUser].ToString().Trim(); //修改人
objPaperDownloadLogEN.UpdDate = objRow[conPaperDownloadLog.UpdDate] == DBNull.Value ? null : objRow[conPaperDownloadLog.UpdDate].ToString().Trim(); //修改日期
objPaperDownloadLogEN.Memo = objRow[conPaperDownloadLog.Memo] == DBNull.Value ? null : objRow[conPaperDownloadLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperDownloadLogEN.PaperDownloadId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperDownloadLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objPaperDownloadLogCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsPaperDownloadLogEN> GetSubObjLstCache(clsPaperDownloadLogEN objPaperDownloadLogCond)
{
List<clsPaperDownloadLogEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsPaperDownloadLogEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPaperDownloadLog.AttributeName)
{
if (objPaperDownloadLogCond.IsUpdated(strFldName) == false) continue;
if (objPaperDownloadLogCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPaperDownloadLogCond[strFldName].ToString());
}
else
{
if (objPaperDownloadLogCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPaperDownloadLogCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPaperDownloadLogCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPaperDownloadLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPaperDownloadLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPaperDownloadLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPaperDownloadLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPaperDownloadLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPaperDownloadLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPaperDownloadLogCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPaperDownloadLogCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPaperDownloadLogCond[strFldName]));
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
public static List<clsPaperDownloadLogEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsPaperDownloadLogEN> arrObjLst = new List<clsPaperDownloadLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperDownloadLogEN objPaperDownloadLogEN = new clsPaperDownloadLogEN();
try
{
objPaperDownloadLogEN.PaperDownloadId = Int32.Parse(objRow[conPaperDownloadLog.PaperDownloadId].ToString().Trim()); //PaperDownloadId
objPaperDownloadLogEN.DownloadFile = objRow[conPaperDownloadLog.DownloadFile] == DBNull.Value ? null : objRow[conPaperDownloadLog.DownloadFile].ToString().Trim(); //DownloadFile
objPaperDownloadLogEN.DownloadLink = objRow[conPaperDownloadLog.DownloadLink] == DBNull.Value ? null : objRow[conPaperDownloadLog.DownloadLink].ToString().Trim(); //DownloadLink
objPaperDownloadLogEN.PaperId = objRow[conPaperDownloadLog.PaperId] == DBNull.Value ? null : objRow[conPaperDownloadLog.PaperId].ToString().Trim(); //论文Id
objPaperDownloadLogEN.UpdUser = objRow[conPaperDownloadLog.UpdUser] == DBNull.Value ? null : objRow[conPaperDownloadLog.UpdUser].ToString().Trim(); //修改人
objPaperDownloadLogEN.UpdDate = objRow[conPaperDownloadLog.UpdDate] == DBNull.Value ? null : objRow[conPaperDownloadLog.UpdDate].ToString().Trim(); //修改日期
objPaperDownloadLogEN.Memo = objRow[conPaperDownloadLog.Memo] == DBNull.Value ? null : objRow[conPaperDownloadLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperDownloadLogEN.PaperDownloadId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperDownloadLogEN);
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
public static List<clsPaperDownloadLogEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsPaperDownloadLogEN> arrObjLst = new List<clsPaperDownloadLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperDownloadLogEN objPaperDownloadLogEN = new clsPaperDownloadLogEN();
try
{
objPaperDownloadLogEN.PaperDownloadId = Int32.Parse(objRow[conPaperDownloadLog.PaperDownloadId].ToString().Trim()); //PaperDownloadId
objPaperDownloadLogEN.DownloadFile = objRow[conPaperDownloadLog.DownloadFile] == DBNull.Value ? null : objRow[conPaperDownloadLog.DownloadFile].ToString().Trim(); //DownloadFile
objPaperDownloadLogEN.DownloadLink = objRow[conPaperDownloadLog.DownloadLink] == DBNull.Value ? null : objRow[conPaperDownloadLog.DownloadLink].ToString().Trim(); //DownloadLink
objPaperDownloadLogEN.PaperId = objRow[conPaperDownloadLog.PaperId] == DBNull.Value ? null : objRow[conPaperDownloadLog.PaperId].ToString().Trim(); //论文Id
objPaperDownloadLogEN.UpdUser = objRow[conPaperDownloadLog.UpdUser] == DBNull.Value ? null : objRow[conPaperDownloadLog.UpdUser].ToString().Trim(); //修改人
objPaperDownloadLogEN.UpdDate = objRow[conPaperDownloadLog.UpdDate] == DBNull.Value ? null : objRow[conPaperDownloadLog.UpdDate].ToString().Trim(); //修改日期
objPaperDownloadLogEN.Memo = objRow[conPaperDownloadLog.Memo] == DBNull.Value ? null : objRow[conPaperDownloadLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperDownloadLogEN.PaperDownloadId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperDownloadLogEN);
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
List<clsPaperDownloadLogEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsPaperDownloadLogEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsPaperDownloadLogEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsPaperDownloadLogEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsPaperDownloadLogEN> arrObjLst = new List<clsPaperDownloadLogEN>(); 
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
	clsPaperDownloadLogEN objPaperDownloadLogEN = new clsPaperDownloadLogEN();
try
{
objPaperDownloadLogEN.PaperDownloadId = Int32.Parse(objRow[conPaperDownloadLog.PaperDownloadId].ToString().Trim()); //PaperDownloadId
objPaperDownloadLogEN.DownloadFile = objRow[conPaperDownloadLog.DownloadFile] == DBNull.Value ? null : objRow[conPaperDownloadLog.DownloadFile].ToString().Trim(); //DownloadFile
objPaperDownloadLogEN.DownloadLink = objRow[conPaperDownloadLog.DownloadLink] == DBNull.Value ? null : objRow[conPaperDownloadLog.DownloadLink].ToString().Trim(); //DownloadLink
objPaperDownloadLogEN.PaperId = objRow[conPaperDownloadLog.PaperId] == DBNull.Value ? null : objRow[conPaperDownloadLog.PaperId].ToString().Trim(); //论文Id
objPaperDownloadLogEN.UpdUser = objRow[conPaperDownloadLog.UpdUser] == DBNull.Value ? null : objRow[conPaperDownloadLog.UpdUser].ToString().Trim(); //修改人
objPaperDownloadLogEN.UpdDate = objRow[conPaperDownloadLog.UpdDate] == DBNull.Value ? null : objRow[conPaperDownloadLog.UpdDate].ToString().Trim(); //修改日期
objPaperDownloadLogEN.Memo = objRow[conPaperDownloadLog.Memo] == DBNull.Value ? null : objRow[conPaperDownloadLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperDownloadLogEN.PaperDownloadId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperDownloadLogEN);
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
public static List<clsPaperDownloadLogEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsPaperDownloadLogEN> arrObjLst = new List<clsPaperDownloadLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperDownloadLogEN objPaperDownloadLogEN = new clsPaperDownloadLogEN();
try
{
objPaperDownloadLogEN.PaperDownloadId = Int32.Parse(objRow[conPaperDownloadLog.PaperDownloadId].ToString().Trim()); //PaperDownloadId
objPaperDownloadLogEN.DownloadFile = objRow[conPaperDownloadLog.DownloadFile] == DBNull.Value ? null : objRow[conPaperDownloadLog.DownloadFile].ToString().Trim(); //DownloadFile
objPaperDownloadLogEN.DownloadLink = objRow[conPaperDownloadLog.DownloadLink] == DBNull.Value ? null : objRow[conPaperDownloadLog.DownloadLink].ToString().Trim(); //DownloadLink
objPaperDownloadLogEN.PaperId = objRow[conPaperDownloadLog.PaperId] == DBNull.Value ? null : objRow[conPaperDownloadLog.PaperId].ToString().Trim(); //论文Id
objPaperDownloadLogEN.UpdUser = objRow[conPaperDownloadLog.UpdUser] == DBNull.Value ? null : objRow[conPaperDownloadLog.UpdUser].ToString().Trim(); //修改人
objPaperDownloadLogEN.UpdDate = objRow[conPaperDownloadLog.UpdDate] == DBNull.Value ? null : objRow[conPaperDownloadLog.UpdDate].ToString().Trim(); //修改日期
objPaperDownloadLogEN.Memo = objRow[conPaperDownloadLog.Memo] == DBNull.Value ? null : objRow[conPaperDownloadLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperDownloadLogEN.PaperDownloadId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperDownloadLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsPaperDownloadLogEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsPaperDownloadLogEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsPaperDownloadLogEN> arrObjLst = new List<clsPaperDownloadLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperDownloadLogEN objPaperDownloadLogEN = new clsPaperDownloadLogEN();
try
{
objPaperDownloadLogEN.PaperDownloadId = Int32.Parse(objRow[conPaperDownloadLog.PaperDownloadId].ToString().Trim()); //PaperDownloadId
objPaperDownloadLogEN.DownloadFile = objRow[conPaperDownloadLog.DownloadFile] == DBNull.Value ? null : objRow[conPaperDownloadLog.DownloadFile].ToString().Trim(); //DownloadFile
objPaperDownloadLogEN.DownloadLink = objRow[conPaperDownloadLog.DownloadLink] == DBNull.Value ? null : objRow[conPaperDownloadLog.DownloadLink].ToString().Trim(); //DownloadLink
objPaperDownloadLogEN.PaperId = objRow[conPaperDownloadLog.PaperId] == DBNull.Value ? null : objRow[conPaperDownloadLog.PaperId].ToString().Trim(); //论文Id
objPaperDownloadLogEN.UpdUser = objRow[conPaperDownloadLog.UpdUser] == DBNull.Value ? null : objRow[conPaperDownloadLog.UpdUser].ToString().Trim(); //修改人
objPaperDownloadLogEN.UpdDate = objRow[conPaperDownloadLog.UpdDate] == DBNull.Value ? null : objRow[conPaperDownloadLog.UpdDate].ToString().Trim(); //修改日期
objPaperDownloadLogEN.Memo = objRow[conPaperDownloadLog.Memo] == DBNull.Value ? null : objRow[conPaperDownloadLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperDownloadLogEN.PaperDownloadId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperDownloadLogEN);
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
public static List<clsPaperDownloadLogEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsPaperDownloadLogEN> arrObjLst = new List<clsPaperDownloadLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperDownloadLogEN objPaperDownloadLogEN = new clsPaperDownloadLogEN();
try
{
objPaperDownloadLogEN.PaperDownloadId = Int32.Parse(objRow[conPaperDownloadLog.PaperDownloadId].ToString().Trim()); //PaperDownloadId
objPaperDownloadLogEN.DownloadFile = objRow[conPaperDownloadLog.DownloadFile] == DBNull.Value ? null : objRow[conPaperDownloadLog.DownloadFile].ToString().Trim(); //DownloadFile
objPaperDownloadLogEN.DownloadLink = objRow[conPaperDownloadLog.DownloadLink] == DBNull.Value ? null : objRow[conPaperDownloadLog.DownloadLink].ToString().Trim(); //DownloadLink
objPaperDownloadLogEN.PaperId = objRow[conPaperDownloadLog.PaperId] == DBNull.Value ? null : objRow[conPaperDownloadLog.PaperId].ToString().Trim(); //论文Id
objPaperDownloadLogEN.UpdUser = objRow[conPaperDownloadLog.UpdUser] == DBNull.Value ? null : objRow[conPaperDownloadLog.UpdUser].ToString().Trim(); //修改人
objPaperDownloadLogEN.UpdDate = objRow[conPaperDownloadLog.UpdDate] == DBNull.Value ? null : objRow[conPaperDownloadLog.UpdDate].ToString().Trim(); //修改日期
objPaperDownloadLogEN.Memo = objRow[conPaperDownloadLog.Memo] == DBNull.Value ? null : objRow[conPaperDownloadLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperDownloadLogEN.PaperDownloadId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperDownloadLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsPaperDownloadLogEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsPaperDownloadLogEN> arrObjLst = new List<clsPaperDownloadLogEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperDownloadLogEN objPaperDownloadLogEN = new clsPaperDownloadLogEN();
try
{
objPaperDownloadLogEN.PaperDownloadId = Int32.Parse(objRow[conPaperDownloadLog.PaperDownloadId].ToString().Trim()); //PaperDownloadId
objPaperDownloadLogEN.DownloadFile = objRow[conPaperDownloadLog.DownloadFile] == DBNull.Value ? null : objRow[conPaperDownloadLog.DownloadFile].ToString().Trim(); //DownloadFile
objPaperDownloadLogEN.DownloadLink = objRow[conPaperDownloadLog.DownloadLink] == DBNull.Value ? null : objRow[conPaperDownloadLog.DownloadLink].ToString().Trim(); //DownloadLink
objPaperDownloadLogEN.PaperId = objRow[conPaperDownloadLog.PaperId] == DBNull.Value ? null : objRow[conPaperDownloadLog.PaperId].ToString().Trim(); //论文Id
objPaperDownloadLogEN.UpdUser = objRow[conPaperDownloadLog.UpdUser] == DBNull.Value ? null : objRow[conPaperDownloadLog.UpdUser].ToString().Trim(); //修改人
objPaperDownloadLogEN.UpdDate = objRow[conPaperDownloadLog.UpdDate] == DBNull.Value ? null : objRow[conPaperDownloadLog.UpdDate].ToString().Trim(); //修改日期
objPaperDownloadLogEN.Memo = objRow[conPaperDownloadLog.Memo] == DBNull.Value ? null : objRow[conPaperDownloadLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperDownloadLogEN.PaperDownloadId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperDownloadLogEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objPaperDownloadLogEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetPaperDownloadLog(ref clsPaperDownloadLogEN objPaperDownloadLogEN)
{
bool bolResult = PaperDownloadLogDA.GetPaperDownloadLog(ref objPaperDownloadLogEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngPaperDownloadId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPaperDownloadLogEN GetObjByPaperDownloadId(long lngPaperDownloadId)
{
clsPaperDownloadLogEN objPaperDownloadLogEN = PaperDownloadLogDA.GetObjByPaperDownloadId(lngPaperDownloadId);
return objPaperDownloadLogEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsPaperDownloadLogEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsPaperDownloadLogEN objPaperDownloadLogEN = PaperDownloadLogDA.GetFirstObj(strWhereCond);
 return objPaperDownloadLogEN;
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
public static clsPaperDownloadLogEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsPaperDownloadLogEN objPaperDownloadLogEN = PaperDownloadLogDA.GetObjByDataRow(objRow);
 return objPaperDownloadLogEN;
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
public static clsPaperDownloadLogEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsPaperDownloadLogEN objPaperDownloadLogEN = PaperDownloadLogDA.GetObjByDataRow(objRow);
 return objPaperDownloadLogEN;
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
 /// <param name = "lngPaperDownloadId">所给的关键字</param>
 /// <param name = "lstPaperDownloadLogObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPaperDownloadLogEN GetObjByPaperDownloadIdFromList(long lngPaperDownloadId, List<clsPaperDownloadLogEN> lstPaperDownloadLogObjLst)
{
foreach (clsPaperDownloadLogEN objPaperDownloadLogEN in lstPaperDownloadLogObjLst)
{
if (objPaperDownloadLogEN.PaperDownloadId == lngPaperDownloadId)
{
return objPaperDownloadLogEN;
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
 long lngPaperDownloadId;
 try
 {
 lngPaperDownloadId = new clsPaperDownloadLogDA().GetFirstID(strWhereCond);
 return lngPaperDownloadId;
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
 arrList = PaperDownloadLogDA.GetID(strWhereCond);
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
bool bolIsExist = PaperDownloadLogDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngPaperDownloadId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngPaperDownloadId)
{
//检测记录是否存在
bool bolIsExist = PaperDownloadLogDA.IsExist(lngPaperDownloadId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngPaperDownloadId">PaperDownloadId</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngPaperDownloadId, string strOpUser)
{
clsPaperDownloadLogEN objPaperDownloadLogEN = clsPaperDownloadLogBL.GetObjByPaperDownloadId(lngPaperDownloadId);
objPaperDownloadLogEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objPaperDownloadLogEN.UpdUser = strOpUser;
return clsPaperDownloadLogBL.UpdateBySql2(objPaperDownloadLogEN);
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
 bolIsExist = clsPaperDownloadLogDA.IsExistTable();
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
 bolIsExist = PaperDownloadLogDA.IsExistTable(strTabName);
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
 /// <param name = "objPaperDownloadLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsPaperDownloadLogEN objPaperDownloadLogEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objPaperDownloadLogEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!PaperDownloadId = [{0}]的数据已经存在!(in clsPaperDownloadLogBL.AddNewRecordBySql2)", objPaperDownloadLogEN.PaperDownloadId);
throw new Exception(strMsg);
}
try
{
bool bolResult = PaperDownloadLogDA.AddNewRecordBySQL2(objPaperDownloadLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperDownloadLogBL.ReFreshCache();

if (clsPaperDownloadLogBL.relatedActions != null)
{
clsPaperDownloadLogBL.relatedActions.UpdRelaTabDate(objPaperDownloadLogEN.PaperDownloadId, objPaperDownloadLogEN.UpdUser);
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
 /// <param name = "objPaperDownloadLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsPaperDownloadLogEN objPaperDownloadLogEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objPaperDownloadLogEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!PaperDownloadId = [{0}]的数据已经存在!(in clsPaperDownloadLogBL.AddNewRecordBySql2WithReturnKey)", objPaperDownloadLogEN.PaperDownloadId);
throw new Exception(strMsg);
}
try
{
string strKey = PaperDownloadLogDA.AddNewRecordBySQL2WithReturnKey(objPaperDownloadLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperDownloadLogBL.ReFreshCache();

if (clsPaperDownloadLogBL.relatedActions != null)
{
clsPaperDownloadLogBL.relatedActions.UpdRelaTabDate(objPaperDownloadLogEN.PaperDownloadId, objPaperDownloadLogEN.UpdUser);
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
 /// <param name = "objPaperDownloadLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsPaperDownloadLogEN objPaperDownloadLogEN)
{
try
{
bool bolResult = PaperDownloadLogDA.Update(objPaperDownloadLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperDownloadLogBL.ReFreshCache();

if (clsPaperDownloadLogBL.relatedActions != null)
{
clsPaperDownloadLogBL.relatedActions.UpdRelaTabDate(objPaperDownloadLogEN.PaperDownloadId, objPaperDownloadLogEN.UpdUser);
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
 /// <param name = "objPaperDownloadLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsPaperDownloadLogEN objPaperDownloadLogEN)
{
 if (objPaperDownloadLogEN.PaperDownloadId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = PaperDownloadLogDA.UpdateBySql2(objPaperDownloadLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperDownloadLogBL.ReFreshCache();

if (clsPaperDownloadLogBL.relatedActions != null)
{
clsPaperDownloadLogBL.relatedActions.UpdRelaTabDate(objPaperDownloadLogEN.PaperDownloadId, objPaperDownloadLogEN.UpdUser);
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
 /// <param name = "lngPaperDownloadId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngPaperDownloadId)
{
try
{
 clsPaperDownloadLogEN objPaperDownloadLogEN = clsPaperDownloadLogBL.GetObjByPaperDownloadId(lngPaperDownloadId);

if (clsPaperDownloadLogBL.relatedActions != null)
{
clsPaperDownloadLogBL.relatedActions.UpdRelaTabDate(objPaperDownloadLogEN.PaperDownloadId, objPaperDownloadLogEN.UpdUser);
}
if (objPaperDownloadLogEN != null)
{
int intRecNum = PaperDownloadLogDA.DelRecord(lngPaperDownloadId);
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
/// <param name="lngPaperDownloadId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngPaperDownloadId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPaperDownloadLogDA.GetSpecSQLObj();
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
//删除与表:[PaperDownloadLog]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conPaperDownloadLog.PaperDownloadId,
//lngPaperDownloadId);
//        clsPaperDownloadLogBL.DelPaperDownloadLogsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPaperDownloadLogBL.DelRecord(lngPaperDownloadId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPaperDownloadLogBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngPaperDownloadId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngPaperDownloadId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngPaperDownloadId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsPaperDownloadLogBL.relatedActions != null)
{
clsPaperDownloadLogBL.relatedActions.UpdRelaTabDate(lngPaperDownloadId, "UpdRelaTabDate");
}
bool bolResult = PaperDownloadLogDA.DelRecord(lngPaperDownloadId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrPaperDownloadIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelPaperDownloadLogs(List<string> arrPaperDownloadIdLst)
{
if (arrPaperDownloadIdLst.Count == 0) return 0;
try
{
if (clsPaperDownloadLogBL.relatedActions != null)
{
foreach (var strPaperDownloadId in arrPaperDownloadIdLst)
{
long lngPaperDownloadId = long.Parse(strPaperDownloadId);
clsPaperDownloadLogBL.relatedActions.UpdRelaTabDate(lngPaperDownloadId, "UpdRelaTabDate");
}
}
int intDelRecNum = PaperDownloadLogDA.DelPaperDownloadLog(arrPaperDownloadIdLst);
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
public static int DelPaperDownloadLogsByCond(string strWhereCond)
{
try
{
if (clsPaperDownloadLogBL.relatedActions != null)
{
List<string> arrPaperDownloadId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strPaperDownloadId in arrPaperDownloadId)
{
long lngPaperDownloadId = long.Parse(strPaperDownloadId);
clsPaperDownloadLogBL.relatedActions.UpdRelaTabDate(lngPaperDownloadId, "UpdRelaTabDate");
}
}
int intRecNum = PaperDownloadLogDA.DelPaperDownloadLog(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[PaperDownloadLog]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngPaperDownloadId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngPaperDownloadId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPaperDownloadLogDA.GetSpecSQLObj();
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
//删除与表:[PaperDownloadLog]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPaperDownloadLogBL.DelRecord(lngPaperDownloadId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPaperDownloadLogBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngPaperDownloadId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objPaperDownloadLogENS">源对象</param>
 /// <param name = "objPaperDownloadLogENT">目标对象</param>
 public static void CopyTo(clsPaperDownloadLogEN objPaperDownloadLogENS, clsPaperDownloadLogEN objPaperDownloadLogENT)
{
try
{
objPaperDownloadLogENT.PaperDownloadId = objPaperDownloadLogENS.PaperDownloadId; //PaperDownloadId
objPaperDownloadLogENT.DownloadFile = objPaperDownloadLogENS.DownloadFile; //DownloadFile
objPaperDownloadLogENT.DownloadLink = objPaperDownloadLogENS.DownloadLink; //DownloadLink
objPaperDownloadLogENT.PaperId = objPaperDownloadLogENS.PaperId; //论文Id
objPaperDownloadLogENT.UpdUser = objPaperDownloadLogENS.UpdUser; //修改人
objPaperDownloadLogENT.UpdDate = objPaperDownloadLogENS.UpdDate; //修改日期
objPaperDownloadLogENT.Memo = objPaperDownloadLogENS.Memo; //备注
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
 /// <param name = "objPaperDownloadLogEN">源简化对象</param>
 public static void SetUpdFlag(clsPaperDownloadLogEN objPaperDownloadLogEN)
{
try
{
objPaperDownloadLogEN.ClearUpdateState();
   string strsfUpdFldSetStr = objPaperDownloadLogEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conPaperDownloadLog.PaperDownloadId, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperDownloadLogEN.PaperDownloadId = objPaperDownloadLogEN.PaperDownloadId; //PaperDownloadId
}
if (arrFldSet.Contains(conPaperDownloadLog.DownloadFile, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperDownloadLogEN.DownloadFile = objPaperDownloadLogEN.DownloadFile == "[null]" ? null :  objPaperDownloadLogEN.DownloadFile; //DownloadFile
}
if (arrFldSet.Contains(conPaperDownloadLog.DownloadLink, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperDownloadLogEN.DownloadLink = objPaperDownloadLogEN.DownloadLink == "[null]" ? null :  objPaperDownloadLogEN.DownloadLink; //DownloadLink
}
if (arrFldSet.Contains(conPaperDownloadLog.PaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperDownloadLogEN.PaperId = objPaperDownloadLogEN.PaperId == "[null]" ? null :  objPaperDownloadLogEN.PaperId; //论文Id
}
if (arrFldSet.Contains(conPaperDownloadLog.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperDownloadLogEN.UpdUser = objPaperDownloadLogEN.UpdUser == "[null]" ? null :  objPaperDownloadLogEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conPaperDownloadLog.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperDownloadLogEN.UpdDate = objPaperDownloadLogEN.UpdDate == "[null]" ? null :  objPaperDownloadLogEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conPaperDownloadLog.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperDownloadLogEN.Memo = objPaperDownloadLogEN.Memo == "[null]" ? null :  objPaperDownloadLogEN.Memo; //备注
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
 /// <param name = "objPaperDownloadLogEN">源简化对象</param>
 public static void AccessFldValueNull(clsPaperDownloadLogEN objPaperDownloadLogEN)
{
try
{
if (objPaperDownloadLogEN.DownloadFile == "[null]") objPaperDownloadLogEN.DownloadFile = null; //DownloadFile
if (objPaperDownloadLogEN.DownloadLink == "[null]") objPaperDownloadLogEN.DownloadLink = null; //DownloadLink
if (objPaperDownloadLogEN.PaperId == "[null]") objPaperDownloadLogEN.PaperId = null; //论文Id
if (objPaperDownloadLogEN.UpdUser == "[null]") objPaperDownloadLogEN.UpdUser = null; //修改人
if (objPaperDownloadLogEN.UpdDate == "[null]") objPaperDownloadLogEN.UpdDate = null; //修改日期
if (objPaperDownloadLogEN.Memo == "[null]") objPaperDownloadLogEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsPaperDownloadLogEN objPaperDownloadLogEN)
{
 PaperDownloadLogDA.CheckPropertyNew(objPaperDownloadLogEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsPaperDownloadLogEN objPaperDownloadLogEN)
{
 PaperDownloadLogDA.CheckProperty4Condition(objPaperDownloadLogEN);
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
if (clsPaperDownloadLogBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperDownloadLogBL没有刷新缓存机制(clsPaperDownloadLogBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PaperDownloadId");
//if (arrPaperDownloadLogObjLstCache == null)
//{
//arrPaperDownloadLogObjLstCache = PaperDownloadLogDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngPaperDownloadId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPaperDownloadLogEN GetObjByPaperDownloadIdCache(long lngPaperDownloadId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsPaperDownloadLogEN._CurrTabName);
List<clsPaperDownloadLogEN> arrPaperDownloadLogObjLstCache = GetObjLstCache();
IEnumerable <clsPaperDownloadLogEN> arrPaperDownloadLogObjLst_Sel =
arrPaperDownloadLogObjLstCache
.Where(x=> x.PaperDownloadId == lngPaperDownloadId 
);
if (arrPaperDownloadLogObjLst_Sel.Count() == 0)
{
   clsPaperDownloadLogEN obj = clsPaperDownloadLogBL.GetObjByPaperDownloadId(lngPaperDownloadId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrPaperDownloadLogObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPaperDownloadLogEN> GetAllPaperDownloadLogObjLstCache()
{
//获取缓存中的对象列表
List<clsPaperDownloadLogEN> arrPaperDownloadLogObjLstCache = GetObjLstCache(); 
return arrPaperDownloadLogObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPaperDownloadLogEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsPaperDownloadLogEN._CurrTabName);
List<clsPaperDownloadLogEN> arrPaperDownloadLogObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrPaperDownloadLogObjLstCache;
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
string strKey = string.Format("{0}", clsPaperDownloadLogEN._CurrTabName);
CacheHelper.Remove(strKey);
clsPaperDownloadLogEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsPaperDownloadLogEN._RefreshTimeLst.Count == 0) return "";
return clsPaperDownloadLogEN._RefreshTimeLst[clsPaperDownloadLogEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsPaperDownloadLogBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsPaperDownloadLogEN._CurrTabName);
CacheHelper.Remove(strKey);
clsPaperDownloadLogEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsPaperDownloadLogBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--PaperDownloadLog(论文下载记录)
 /// 唯一性条件:PaperDownloadId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objPaperDownloadLogEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsPaperDownloadLogEN objPaperDownloadLogEN)
{
//检测记录是否存在
string strResult = PaperDownloadLogDA.GetUniCondStr(objPaperDownloadLogEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngPaperDownloadId)
{
if (strInFldName != conPaperDownloadLog.PaperDownloadId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conPaperDownloadLog.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conPaperDownloadLog.AttributeName));
throw new Exception(strMsg);
}
var objPaperDownloadLog = clsPaperDownloadLogBL.GetObjByPaperDownloadIdCache(lngPaperDownloadId);
if (objPaperDownloadLog == null) return "";
return objPaperDownloadLog[strOutFldName].ToString();
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
int intRecCount = clsPaperDownloadLogDA.GetRecCount(strTabName);
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
int intRecCount = clsPaperDownloadLogDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsPaperDownloadLogDA.GetRecCount();
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
int intRecCount = clsPaperDownloadLogDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objPaperDownloadLogCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsPaperDownloadLogEN objPaperDownloadLogCond)
{
List<clsPaperDownloadLogEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsPaperDownloadLogEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPaperDownloadLog.AttributeName)
{
if (objPaperDownloadLogCond.IsUpdated(strFldName) == false) continue;
if (objPaperDownloadLogCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPaperDownloadLogCond[strFldName].ToString());
}
else
{
if (objPaperDownloadLogCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPaperDownloadLogCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPaperDownloadLogCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPaperDownloadLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPaperDownloadLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPaperDownloadLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPaperDownloadLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPaperDownloadLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPaperDownloadLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPaperDownloadLogCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPaperDownloadLogCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPaperDownloadLogCond[strFldName]));
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
 List<string> arrList = clsPaperDownloadLogDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = PaperDownloadLogDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = PaperDownloadLogDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = PaperDownloadLogDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsPaperDownloadLogDA.SetFldValue(clsPaperDownloadLogEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = PaperDownloadLogDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsPaperDownloadLogDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsPaperDownloadLogDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsPaperDownloadLogDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[PaperDownloadLog] "); 
 strCreateTabCode.Append(" ( "); 
 // /**PaperDownloadId*/ 
 strCreateTabCode.Append(" PaperDownloadId bigint primary key identity, "); 
 // /**DownloadFile*/ 
 strCreateTabCode.Append(" DownloadFile varchar(500) Null, "); 
 // /**DownloadLink*/ 
 strCreateTabCode.Append(" DownloadLink varchar(500) Null, "); 
 // /**论文Id*/ 
 strCreateTabCode.Append(" PaperId char(8) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 论文下载记录(PaperDownloadLog)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4PaperDownloadLog : clsCommFun4BL
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
clsPaperDownloadLogBL.ReFreshThisCache();
}
}

}