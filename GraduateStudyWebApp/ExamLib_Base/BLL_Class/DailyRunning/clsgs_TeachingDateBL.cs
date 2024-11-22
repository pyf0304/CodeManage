
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_TeachingDateBL
 表名:gs_TeachingDate(01120684)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:07:57
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
public static class  clsgs_TeachingDateBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_TeachingDateEN GetObj(this K_mId_gs_TeachingDate myKey)
{
clsgs_TeachingDateEN objgs_TeachingDateEN = clsgs_TeachingDateBL.gs_TeachingDateDA.GetObjBymId(myKey.Value);
return objgs_TeachingDateEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objgs_TeachingDateEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsgs_TeachingDateEN objgs_TeachingDateEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_TeachingDateEN) == false)
{
var strMsg = string.Format("记录已经存在!mId = [{0}]的数据已经存在!(in clsgs_TeachingDateBL.AddNewRecord)", objgs_TeachingDateEN.mId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsgs_TeachingDateBL.gs_TeachingDateDA.AddNewRecordBySQL2(objgs_TeachingDateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TeachingDateBL.ReFreshCache(objgs_TeachingDateEN.IdCurrEduCls);

if (clsgs_TeachingDateBL.relatedActions != null)
{
clsgs_TeachingDateBL.relatedActions.UpdRelaTabDate(objgs_TeachingDateEN.mId, "SetUpdDate");
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
public static bool AddRecordEx(this clsgs_TeachingDateEN objgs_TeachingDateEN, bool bolIsNeedCheckUniqueness = true)
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
objgs_TeachingDateEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objgs_TeachingDateEN.CheckUniqueness() == false)
{
strMsg = string.Format("(mId(mId)=[{0}])已经存在,不能重复!", objgs_TeachingDateEN.mId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objgs_TeachingDateEN.AddNewRecord();
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
 /// <param name = "objgs_TeachingDateEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsgs_TeachingDateEN objgs_TeachingDateEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_TeachingDateEN) == false)
{
var strMsg = string.Format("记录已经存在!mId = [{0}]的数据已经存在!(in clsgs_TeachingDateBL.AddNewRecordWithReturnKey)", objgs_TeachingDateEN.mId);
throw new Exception(strMsg);
}
try
{
string strKey = clsgs_TeachingDateBL.gs_TeachingDateDA.AddNewRecordBySQL2WithReturnKey(objgs_TeachingDateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TeachingDateBL.ReFreshCache(objgs_TeachingDateEN.IdCurrEduCls);

if (clsgs_TeachingDateBL.relatedActions != null)
{
clsgs_TeachingDateBL.relatedActions.UpdRelaTabDate(objgs_TeachingDateEN.mId, "SetUpdDate");
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
 /// <param name = "objgs_TeachingDateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TeachingDateEN SetmId(this clsgs_TeachingDateEN objgs_TeachingDateEN, long lngmId, string strComparisonOp="")
	{
objgs_TeachingDateEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TeachingDateEN.dicFldComparisonOp.ContainsKey(congs_TeachingDate.mId) == false)
{
objgs_TeachingDateEN.dicFldComparisonOp.Add(congs_TeachingDate.mId, strComparisonOp);
}
else
{
objgs_TeachingDateEN.dicFldComparisonOp[congs_TeachingDate.mId] = strComparisonOp;
}
}
return objgs_TeachingDateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_TeachingDateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TeachingDateEN SetIdCurrEduCls(this clsgs_TeachingDateEN objgs_TeachingDateEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, congs_TeachingDate.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, congs_TeachingDate.IdCurrEduCls);
}
objgs_TeachingDateEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TeachingDateEN.dicFldComparisonOp.ContainsKey(congs_TeachingDate.IdCurrEduCls) == false)
{
objgs_TeachingDateEN.dicFldComparisonOp.Add(congs_TeachingDate.IdCurrEduCls, strComparisonOp);
}
else
{
objgs_TeachingDateEN.dicFldComparisonOp[congs_TeachingDate.IdCurrEduCls] = strComparisonOp;
}
}
return objgs_TeachingDateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_TeachingDateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TeachingDateEN SetStartDate(this clsgs_TeachingDateEN objgs_TeachingDateEN, string strStartDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStartDate, 20, congs_TeachingDate.StartDate);
}
objgs_TeachingDateEN.StartDate = strStartDate; //开始日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TeachingDateEN.dicFldComparisonOp.ContainsKey(congs_TeachingDate.StartDate) == false)
{
objgs_TeachingDateEN.dicFldComparisonOp.Add(congs_TeachingDate.StartDate, strComparisonOp);
}
else
{
objgs_TeachingDateEN.dicFldComparisonOp[congs_TeachingDate.StartDate] = strComparisonOp;
}
}
return objgs_TeachingDateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_TeachingDateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TeachingDateEN SetEndDate(this clsgs_TeachingDateEN objgs_TeachingDateEN, string strEndDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEndDate, 20, congs_TeachingDate.EndDate);
}
objgs_TeachingDateEN.EndDate = strEndDate; //截止日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TeachingDateEN.dicFldComparisonOp.ContainsKey(congs_TeachingDate.EndDate) == false)
{
objgs_TeachingDateEN.dicFldComparisonOp.Add(congs_TeachingDate.EndDate, strComparisonOp);
}
else
{
objgs_TeachingDateEN.dicFldComparisonOp[congs_TeachingDate.EndDate] = strComparisonOp;
}
}
return objgs_TeachingDateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_TeachingDateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TeachingDateEN SetUpdDate(this clsgs_TeachingDateEN objgs_TeachingDateEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, congs_TeachingDate.UpdDate);
}
objgs_TeachingDateEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TeachingDateEN.dicFldComparisonOp.ContainsKey(congs_TeachingDate.UpdDate) == false)
{
objgs_TeachingDateEN.dicFldComparisonOp.Add(congs_TeachingDate.UpdDate, strComparisonOp);
}
else
{
objgs_TeachingDateEN.dicFldComparisonOp[congs_TeachingDate.UpdDate] = strComparisonOp;
}
}
return objgs_TeachingDateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_TeachingDateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TeachingDateEN SetUpdUser(this clsgs_TeachingDateEN objgs_TeachingDateEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, congs_TeachingDate.UpdUser);
}
objgs_TeachingDateEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TeachingDateEN.dicFldComparisonOp.ContainsKey(congs_TeachingDate.UpdUser) == false)
{
objgs_TeachingDateEN.dicFldComparisonOp.Add(congs_TeachingDate.UpdUser, strComparisonOp);
}
else
{
objgs_TeachingDateEN.dicFldComparisonOp[congs_TeachingDate.UpdUser] = strComparisonOp;
}
}
return objgs_TeachingDateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_TeachingDateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TeachingDateEN SetMemo(this clsgs_TeachingDateEN objgs_TeachingDateEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, congs_TeachingDate.Memo);
}
objgs_TeachingDateEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TeachingDateEN.dicFldComparisonOp.ContainsKey(congs_TeachingDate.Memo) == false)
{
objgs_TeachingDateEN.dicFldComparisonOp.Add(congs_TeachingDate.Memo, strComparisonOp);
}
else
{
objgs_TeachingDateEN.dicFldComparisonOp[congs_TeachingDate.Memo] = strComparisonOp;
}
}
return objgs_TeachingDateEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objgs_TeachingDateEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsgs_TeachingDateEN objgs_TeachingDateEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objgs_TeachingDateEN.CheckPropertyNew();
clsgs_TeachingDateEN objgs_TeachingDateCond = new clsgs_TeachingDateEN();
string strCondition = objgs_TeachingDateCond
.SetmId(objgs_TeachingDateEN.mId, "<>")
.SetmId(objgs_TeachingDateEN.mId, "=")
.GetCombineCondition();
objgs_TeachingDateEN._IsCheckProperty = true;
bool bolIsExist = clsgs_TeachingDateBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(mId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objgs_TeachingDateEN.Update();
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
 /// <param name = "objgs_TeachingDate">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsgs_TeachingDateEN objgs_TeachingDate)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsgs_TeachingDateEN objgs_TeachingDateCond = new clsgs_TeachingDateEN();
string strCondition = objgs_TeachingDateCond
.SetmId(objgs_TeachingDate.mId, "=")
.GetCombineCondition();
objgs_TeachingDate._IsCheckProperty = true;
bool bolIsExist = clsgs_TeachingDateBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objgs_TeachingDate.mId = clsgs_TeachingDateBL.GetFirstID_S(strCondition);
objgs_TeachingDate.UpdateWithCondition(strCondition);
}
else
{
objgs_TeachingDate.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objgs_TeachingDateEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_TeachingDateEN objgs_TeachingDateEN)
{
 if (objgs_TeachingDateEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsgs_TeachingDateBL.gs_TeachingDateDA.UpdateBySql2(objgs_TeachingDateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TeachingDateBL.ReFreshCache(objgs_TeachingDateEN.IdCurrEduCls);

if (clsgs_TeachingDateBL.relatedActions != null)
{
clsgs_TeachingDateBL.relatedActions.UpdRelaTabDate(objgs_TeachingDateEN.mId, "SetUpdDate");
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
 /// <param name = "objgs_TeachingDateEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_TeachingDateEN objgs_TeachingDateEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objgs_TeachingDateEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsgs_TeachingDateBL.gs_TeachingDateDA.UpdateBySql2(objgs_TeachingDateEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TeachingDateBL.ReFreshCache(objgs_TeachingDateEN.IdCurrEduCls);

if (clsgs_TeachingDateBL.relatedActions != null)
{
clsgs_TeachingDateBL.relatedActions.UpdRelaTabDate(objgs_TeachingDateEN.mId, "SetUpdDate");
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
 /// <param name = "objgs_TeachingDateEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_TeachingDateEN objgs_TeachingDateEN, string strWhereCond)
{
try
{
bool bolResult = clsgs_TeachingDateBL.gs_TeachingDateDA.UpdateBySqlWithCondition(objgs_TeachingDateEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TeachingDateBL.ReFreshCache(objgs_TeachingDateEN.IdCurrEduCls);

if (clsgs_TeachingDateBL.relatedActions != null)
{
clsgs_TeachingDateBL.relatedActions.UpdRelaTabDate(objgs_TeachingDateEN.mId, "SetUpdDate");
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
 /// <param name = "objgs_TeachingDateEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_TeachingDateEN objgs_TeachingDateEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsgs_TeachingDateBL.gs_TeachingDateDA.UpdateBySqlWithConditionTransaction(objgs_TeachingDateEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TeachingDateBL.ReFreshCache(objgs_TeachingDateEN.IdCurrEduCls);

if (clsgs_TeachingDateBL.relatedActions != null)
{
clsgs_TeachingDateBL.relatedActions.UpdRelaTabDate(objgs_TeachingDateEN.mId, "SetUpdDate");
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
public static int Delete(this clsgs_TeachingDateEN objgs_TeachingDateEN)
{
try
{
int intRecNum = clsgs_TeachingDateBL.gs_TeachingDateDA.DelRecord(objgs_TeachingDateEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TeachingDateBL.ReFreshCache(objgs_TeachingDateEN.IdCurrEduCls);

if (clsgs_TeachingDateBL.relatedActions != null)
{
clsgs_TeachingDateBL.relatedActions.UpdRelaTabDate(objgs_TeachingDateEN.mId, "SetUpdDate");
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
 /// <param name = "objgs_TeachingDateENS">源对象</param>
 /// <param name = "objgs_TeachingDateENT">目标对象</param>
 public static void CopyTo(this clsgs_TeachingDateEN objgs_TeachingDateENS, clsgs_TeachingDateEN objgs_TeachingDateENT)
{
try
{
objgs_TeachingDateENT.mId = objgs_TeachingDateENS.mId; //mId
objgs_TeachingDateENT.IdCurrEduCls = objgs_TeachingDateENS.IdCurrEduCls; //教学班流水号
objgs_TeachingDateENT.StartDate = objgs_TeachingDateENS.StartDate; //开始日期
objgs_TeachingDateENT.EndDate = objgs_TeachingDateENS.EndDate; //截止日期
objgs_TeachingDateENT.UpdDate = objgs_TeachingDateENS.UpdDate; //修改日期
objgs_TeachingDateENT.UpdUser = objgs_TeachingDateENS.UpdUser; //修改人
objgs_TeachingDateENT.Memo = objgs_TeachingDateENS.Memo; //备注
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
 /// <param name = "objgs_TeachingDateENS">源对象</param>
 /// <returns>目标对象=>clsgs_TeachingDateEN:objgs_TeachingDateENT</returns>
 public static clsgs_TeachingDateEN CopyTo(this clsgs_TeachingDateEN objgs_TeachingDateENS)
{
try
{
 clsgs_TeachingDateEN objgs_TeachingDateENT = new clsgs_TeachingDateEN()
{
mId = objgs_TeachingDateENS.mId, //mId
IdCurrEduCls = objgs_TeachingDateENS.IdCurrEduCls, //教学班流水号
StartDate = objgs_TeachingDateENS.StartDate, //开始日期
EndDate = objgs_TeachingDateENS.EndDate, //截止日期
UpdDate = objgs_TeachingDateENS.UpdDate, //修改日期
UpdUser = objgs_TeachingDateENS.UpdUser, //修改人
Memo = objgs_TeachingDateENS.Memo, //备注
};
 return objgs_TeachingDateENT;
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
public static void CheckPropertyNew(this clsgs_TeachingDateEN objgs_TeachingDateEN)
{
 clsgs_TeachingDateBL.gs_TeachingDateDA.CheckPropertyNew(objgs_TeachingDateEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsgs_TeachingDateEN objgs_TeachingDateEN)
{
 clsgs_TeachingDateBL.gs_TeachingDateDA.CheckProperty4Condition(objgs_TeachingDateEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsgs_TeachingDateEN objgs_TeachingDateCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objgs_TeachingDateCond.IsUpdated(congs_TeachingDate.mId) == true)
{
string strComparisonOpmId = objgs_TeachingDateCond.dicFldComparisonOp[congs_TeachingDate.mId];
strWhereCond += string.Format(" And {0} {2} {1}", congs_TeachingDate.mId, objgs_TeachingDateCond.mId, strComparisonOpmId);
}
if (objgs_TeachingDateCond.IsUpdated(congs_TeachingDate.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objgs_TeachingDateCond.dicFldComparisonOp[congs_TeachingDate.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_TeachingDate.IdCurrEduCls, objgs_TeachingDateCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objgs_TeachingDateCond.IsUpdated(congs_TeachingDate.StartDate) == true)
{
string strComparisonOpStartDate = objgs_TeachingDateCond.dicFldComparisonOp[congs_TeachingDate.StartDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_TeachingDate.StartDate, objgs_TeachingDateCond.StartDate, strComparisonOpStartDate);
}
if (objgs_TeachingDateCond.IsUpdated(congs_TeachingDate.EndDate) == true)
{
string strComparisonOpEndDate = objgs_TeachingDateCond.dicFldComparisonOp[congs_TeachingDate.EndDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_TeachingDate.EndDate, objgs_TeachingDateCond.EndDate, strComparisonOpEndDate);
}
if (objgs_TeachingDateCond.IsUpdated(congs_TeachingDate.UpdDate) == true)
{
string strComparisonOpUpdDate = objgs_TeachingDateCond.dicFldComparisonOp[congs_TeachingDate.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_TeachingDate.UpdDate, objgs_TeachingDateCond.UpdDate, strComparisonOpUpdDate);
}
if (objgs_TeachingDateCond.IsUpdated(congs_TeachingDate.UpdUser) == true)
{
string strComparisonOpUpdUser = objgs_TeachingDateCond.dicFldComparisonOp[congs_TeachingDate.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_TeachingDate.UpdUser, objgs_TeachingDateCond.UpdUser, strComparisonOpUpdUser);
}
if (objgs_TeachingDateCond.IsUpdated(congs_TeachingDate.Memo) == true)
{
string strComparisonOpMemo = objgs_TeachingDateCond.dicFldComparisonOp[congs_TeachingDate.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_TeachingDate.Memo, objgs_TeachingDateCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--gs_TeachingDate(教学班日期范围), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:mId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objgs_TeachingDateEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsgs_TeachingDateEN objgs_TeachingDateEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objgs_TeachingDateEN == null) return true;
if (objgs_TeachingDateEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and mId = '{0}'", objgs_TeachingDateEN.mId);
if (clsgs_TeachingDateBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objgs_TeachingDateEN.mId);
 sbCondition.AppendFormat(" and mId = '{0}'", objgs_TeachingDateEN.mId);
if (clsgs_TeachingDateBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--gs_TeachingDate(教学班日期范围), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:mId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objgs_TeachingDateEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsgs_TeachingDateEN objgs_TeachingDateEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objgs_TeachingDateEN == null) return "";
if (objgs_TeachingDateEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and mId = '{0}'", objgs_TeachingDateEN.mId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objgs_TeachingDateEN.mId);
 sbCondition.AppendFormat(" and mId = '{0}'", objgs_TeachingDateEN.mId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_gs_TeachingDate
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 教学班日期范围(gs_TeachingDate)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsgs_TeachingDateBL
{
public static RelatedActions_gs_TeachingDate relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsgs_TeachingDateDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsgs_TeachingDateDA gs_TeachingDateDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsgs_TeachingDateDA();
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
 public clsgs_TeachingDateBL()
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
if (string.IsNullOrEmpty(clsgs_TeachingDateEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsgs_TeachingDateEN._ConnectString);
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
public static DataTable GetDataTable_gs_TeachingDate(string strWhereCond)
{
DataTable objDT;
try
{
objDT = gs_TeachingDateDA.GetDataTable_gs_TeachingDate(strWhereCond);
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
objDT = gs_TeachingDateDA.GetDataTable(strWhereCond);
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
objDT = gs_TeachingDateDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = gs_TeachingDateDA.GetDataTable(strWhereCond, strTabName);
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
objDT = gs_TeachingDateDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = gs_TeachingDateDA.GetDataTable_Top(objTopPara);
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
objDT = gs_TeachingDateDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = gs_TeachingDateDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = gs_TeachingDateDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsgs_TeachingDateEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsgs_TeachingDateEN> arrObjLst = new List<clsgs_TeachingDateEN>(); 
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
	clsgs_TeachingDateEN objgs_TeachingDateEN = new clsgs_TeachingDateEN();
try
{
objgs_TeachingDateEN.mId = Int32.Parse(objRow[congs_TeachingDate.mId].ToString().Trim()); //mId
objgs_TeachingDateEN.IdCurrEduCls = objRow[congs_TeachingDate.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_TeachingDate.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_TeachingDateEN.StartDate = objRow[congs_TeachingDate.StartDate] == DBNull.Value ? null : objRow[congs_TeachingDate.StartDate].ToString().Trim(); //开始日期
objgs_TeachingDateEN.EndDate = objRow[congs_TeachingDate.EndDate] == DBNull.Value ? null : objRow[congs_TeachingDate.EndDate].ToString().Trim(); //截止日期
objgs_TeachingDateEN.UpdDate = objRow[congs_TeachingDate.UpdDate] == DBNull.Value ? null : objRow[congs_TeachingDate.UpdDate].ToString().Trim(); //修改日期
objgs_TeachingDateEN.UpdUser = objRow[congs_TeachingDate.UpdUser] == DBNull.Value ? null : objRow[congs_TeachingDate.UpdUser].ToString().Trim(); //修改人
objgs_TeachingDateEN.Memo = objRow[congs_TeachingDate.Memo] == DBNull.Value ? null : objRow[congs_TeachingDate.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_TeachingDateEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_TeachingDateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsgs_TeachingDateEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsgs_TeachingDateEN._CurrTabName, strIdCurrEduCls);
List<clsgs_TeachingDateEN> arrgs_TeachingDateObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsgs_TeachingDateEN> arrgs_TeachingDateObjLst_Sel =
arrgs_TeachingDateObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrgs_TeachingDateObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_TeachingDateEN> GetObjLst(string strWhereCond)
{
List<clsgs_TeachingDateEN> arrObjLst = new List<clsgs_TeachingDateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_TeachingDateEN objgs_TeachingDateEN = new clsgs_TeachingDateEN();
try
{
objgs_TeachingDateEN.mId = Int32.Parse(objRow[congs_TeachingDate.mId].ToString().Trim()); //mId
objgs_TeachingDateEN.IdCurrEduCls = objRow[congs_TeachingDate.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_TeachingDate.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_TeachingDateEN.StartDate = objRow[congs_TeachingDate.StartDate] == DBNull.Value ? null : objRow[congs_TeachingDate.StartDate].ToString().Trim(); //开始日期
objgs_TeachingDateEN.EndDate = objRow[congs_TeachingDate.EndDate] == DBNull.Value ? null : objRow[congs_TeachingDate.EndDate].ToString().Trim(); //截止日期
objgs_TeachingDateEN.UpdDate = objRow[congs_TeachingDate.UpdDate] == DBNull.Value ? null : objRow[congs_TeachingDate.UpdDate].ToString().Trim(); //修改日期
objgs_TeachingDateEN.UpdUser = objRow[congs_TeachingDate.UpdUser] == DBNull.Value ? null : objRow[congs_TeachingDate.UpdUser].ToString().Trim(); //修改人
objgs_TeachingDateEN.Memo = objRow[congs_TeachingDate.Memo] == DBNull.Value ? null : objRow[congs_TeachingDate.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_TeachingDateEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_TeachingDateEN);
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
public static List<clsgs_TeachingDateEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsgs_TeachingDateEN> arrObjLst = new List<clsgs_TeachingDateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_TeachingDateEN objgs_TeachingDateEN = new clsgs_TeachingDateEN();
try
{
objgs_TeachingDateEN.mId = Int32.Parse(objRow[congs_TeachingDate.mId].ToString().Trim()); //mId
objgs_TeachingDateEN.IdCurrEduCls = objRow[congs_TeachingDate.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_TeachingDate.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_TeachingDateEN.StartDate = objRow[congs_TeachingDate.StartDate] == DBNull.Value ? null : objRow[congs_TeachingDate.StartDate].ToString().Trim(); //开始日期
objgs_TeachingDateEN.EndDate = objRow[congs_TeachingDate.EndDate] == DBNull.Value ? null : objRow[congs_TeachingDate.EndDate].ToString().Trim(); //截止日期
objgs_TeachingDateEN.UpdDate = objRow[congs_TeachingDate.UpdDate] == DBNull.Value ? null : objRow[congs_TeachingDate.UpdDate].ToString().Trim(); //修改日期
objgs_TeachingDateEN.UpdUser = objRow[congs_TeachingDate.UpdUser] == DBNull.Value ? null : objRow[congs_TeachingDate.UpdUser].ToString().Trim(); //修改人
objgs_TeachingDateEN.Memo = objRow[congs_TeachingDate.Memo] == DBNull.Value ? null : objRow[congs_TeachingDate.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_TeachingDateEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_TeachingDateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objgs_TeachingDateCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsgs_TeachingDateEN> GetSubObjLstCache(clsgs_TeachingDateEN objgs_TeachingDateCond)
{
 string strIdCurrEduCls = objgs_TeachingDateCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsgs_TeachingDateBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsgs_TeachingDateEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsgs_TeachingDateEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in congs_TeachingDate.AttributeName)
{
if (objgs_TeachingDateCond.IsUpdated(strFldName) == false) continue;
if (objgs_TeachingDateCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_TeachingDateCond[strFldName].ToString());
}
else
{
if (objgs_TeachingDateCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objgs_TeachingDateCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_TeachingDateCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objgs_TeachingDateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objgs_TeachingDateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objgs_TeachingDateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objgs_TeachingDateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objgs_TeachingDateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objgs_TeachingDateCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objgs_TeachingDateCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objgs_TeachingDateCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objgs_TeachingDateCond[strFldName]));
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
public static List<clsgs_TeachingDateEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsgs_TeachingDateEN> arrObjLst = new List<clsgs_TeachingDateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_TeachingDateEN objgs_TeachingDateEN = new clsgs_TeachingDateEN();
try
{
objgs_TeachingDateEN.mId = Int32.Parse(objRow[congs_TeachingDate.mId].ToString().Trim()); //mId
objgs_TeachingDateEN.IdCurrEduCls = objRow[congs_TeachingDate.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_TeachingDate.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_TeachingDateEN.StartDate = objRow[congs_TeachingDate.StartDate] == DBNull.Value ? null : objRow[congs_TeachingDate.StartDate].ToString().Trim(); //开始日期
objgs_TeachingDateEN.EndDate = objRow[congs_TeachingDate.EndDate] == DBNull.Value ? null : objRow[congs_TeachingDate.EndDate].ToString().Trim(); //截止日期
objgs_TeachingDateEN.UpdDate = objRow[congs_TeachingDate.UpdDate] == DBNull.Value ? null : objRow[congs_TeachingDate.UpdDate].ToString().Trim(); //修改日期
objgs_TeachingDateEN.UpdUser = objRow[congs_TeachingDate.UpdUser] == DBNull.Value ? null : objRow[congs_TeachingDate.UpdUser].ToString().Trim(); //修改人
objgs_TeachingDateEN.Memo = objRow[congs_TeachingDate.Memo] == DBNull.Value ? null : objRow[congs_TeachingDate.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_TeachingDateEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_TeachingDateEN);
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
public static List<clsgs_TeachingDateEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsgs_TeachingDateEN> arrObjLst = new List<clsgs_TeachingDateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_TeachingDateEN objgs_TeachingDateEN = new clsgs_TeachingDateEN();
try
{
objgs_TeachingDateEN.mId = Int32.Parse(objRow[congs_TeachingDate.mId].ToString().Trim()); //mId
objgs_TeachingDateEN.IdCurrEduCls = objRow[congs_TeachingDate.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_TeachingDate.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_TeachingDateEN.StartDate = objRow[congs_TeachingDate.StartDate] == DBNull.Value ? null : objRow[congs_TeachingDate.StartDate].ToString().Trim(); //开始日期
objgs_TeachingDateEN.EndDate = objRow[congs_TeachingDate.EndDate] == DBNull.Value ? null : objRow[congs_TeachingDate.EndDate].ToString().Trim(); //截止日期
objgs_TeachingDateEN.UpdDate = objRow[congs_TeachingDate.UpdDate] == DBNull.Value ? null : objRow[congs_TeachingDate.UpdDate].ToString().Trim(); //修改日期
objgs_TeachingDateEN.UpdUser = objRow[congs_TeachingDate.UpdUser] == DBNull.Value ? null : objRow[congs_TeachingDate.UpdUser].ToString().Trim(); //修改人
objgs_TeachingDateEN.Memo = objRow[congs_TeachingDate.Memo] == DBNull.Value ? null : objRow[congs_TeachingDate.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_TeachingDateEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_TeachingDateEN);
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
List<clsgs_TeachingDateEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsgs_TeachingDateEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_TeachingDateEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsgs_TeachingDateEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsgs_TeachingDateEN> arrObjLst = new List<clsgs_TeachingDateEN>(); 
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
	clsgs_TeachingDateEN objgs_TeachingDateEN = new clsgs_TeachingDateEN();
try
{
objgs_TeachingDateEN.mId = Int32.Parse(objRow[congs_TeachingDate.mId].ToString().Trim()); //mId
objgs_TeachingDateEN.IdCurrEduCls = objRow[congs_TeachingDate.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_TeachingDate.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_TeachingDateEN.StartDate = objRow[congs_TeachingDate.StartDate] == DBNull.Value ? null : objRow[congs_TeachingDate.StartDate].ToString().Trim(); //开始日期
objgs_TeachingDateEN.EndDate = objRow[congs_TeachingDate.EndDate] == DBNull.Value ? null : objRow[congs_TeachingDate.EndDate].ToString().Trim(); //截止日期
objgs_TeachingDateEN.UpdDate = objRow[congs_TeachingDate.UpdDate] == DBNull.Value ? null : objRow[congs_TeachingDate.UpdDate].ToString().Trim(); //修改日期
objgs_TeachingDateEN.UpdUser = objRow[congs_TeachingDate.UpdUser] == DBNull.Value ? null : objRow[congs_TeachingDate.UpdUser].ToString().Trim(); //修改人
objgs_TeachingDateEN.Memo = objRow[congs_TeachingDate.Memo] == DBNull.Value ? null : objRow[congs_TeachingDate.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_TeachingDateEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_TeachingDateEN);
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
public static List<clsgs_TeachingDateEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsgs_TeachingDateEN> arrObjLst = new List<clsgs_TeachingDateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_TeachingDateEN objgs_TeachingDateEN = new clsgs_TeachingDateEN();
try
{
objgs_TeachingDateEN.mId = Int32.Parse(objRow[congs_TeachingDate.mId].ToString().Trim()); //mId
objgs_TeachingDateEN.IdCurrEduCls = objRow[congs_TeachingDate.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_TeachingDate.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_TeachingDateEN.StartDate = objRow[congs_TeachingDate.StartDate] == DBNull.Value ? null : objRow[congs_TeachingDate.StartDate].ToString().Trim(); //开始日期
objgs_TeachingDateEN.EndDate = objRow[congs_TeachingDate.EndDate] == DBNull.Value ? null : objRow[congs_TeachingDate.EndDate].ToString().Trim(); //截止日期
objgs_TeachingDateEN.UpdDate = objRow[congs_TeachingDate.UpdDate] == DBNull.Value ? null : objRow[congs_TeachingDate.UpdDate].ToString().Trim(); //修改日期
objgs_TeachingDateEN.UpdUser = objRow[congs_TeachingDate.UpdUser] == DBNull.Value ? null : objRow[congs_TeachingDate.UpdUser].ToString().Trim(); //修改人
objgs_TeachingDateEN.Memo = objRow[congs_TeachingDate.Memo] == DBNull.Value ? null : objRow[congs_TeachingDate.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_TeachingDateEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_TeachingDateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsgs_TeachingDateEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsgs_TeachingDateEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsgs_TeachingDateEN> arrObjLst = new List<clsgs_TeachingDateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_TeachingDateEN objgs_TeachingDateEN = new clsgs_TeachingDateEN();
try
{
objgs_TeachingDateEN.mId = Int32.Parse(objRow[congs_TeachingDate.mId].ToString().Trim()); //mId
objgs_TeachingDateEN.IdCurrEduCls = objRow[congs_TeachingDate.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_TeachingDate.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_TeachingDateEN.StartDate = objRow[congs_TeachingDate.StartDate] == DBNull.Value ? null : objRow[congs_TeachingDate.StartDate].ToString().Trim(); //开始日期
objgs_TeachingDateEN.EndDate = objRow[congs_TeachingDate.EndDate] == DBNull.Value ? null : objRow[congs_TeachingDate.EndDate].ToString().Trim(); //截止日期
objgs_TeachingDateEN.UpdDate = objRow[congs_TeachingDate.UpdDate] == DBNull.Value ? null : objRow[congs_TeachingDate.UpdDate].ToString().Trim(); //修改日期
objgs_TeachingDateEN.UpdUser = objRow[congs_TeachingDate.UpdUser] == DBNull.Value ? null : objRow[congs_TeachingDate.UpdUser].ToString().Trim(); //修改人
objgs_TeachingDateEN.Memo = objRow[congs_TeachingDate.Memo] == DBNull.Value ? null : objRow[congs_TeachingDate.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_TeachingDateEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_TeachingDateEN);
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
public static List<clsgs_TeachingDateEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsgs_TeachingDateEN> arrObjLst = new List<clsgs_TeachingDateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_TeachingDateEN objgs_TeachingDateEN = new clsgs_TeachingDateEN();
try
{
objgs_TeachingDateEN.mId = Int32.Parse(objRow[congs_TeachingDate.mId].ToString().Trim()); //mId
objgs_TeachingDateEN.IdCurrEduCls = objRow[congs_TeachingDate.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_TeachingDate.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_TeachingDateEN.StartDate = objRow[congs_TeachingDate.StartDate] == DBNull.Value ? null : objRow[congs_TeachingDate.StartDate].ToString().Trim(); //开始日期
objgs_TeachingDateEN.EndDate = objRow[congs_TeachingDate.EndDate] == DBNull.Value ? null : objRow[congs_TeachingDate.EndDate].ToString().Trim(); //截止日期
objgs_TeachingDateEN.UpdDate = objRow[congs_TeachingDate.UpdDate] == DBNull.Value ? null : objRow[congs_TeachingDate.UpdDate].ToString().Trim(); //修改日期
objgs_TeachingDateEN.UpdUser = objRow[congs_TeachingDate.UpdUser] == DBNull.Value ? null : objRow[congs_TeachingDate.UpdUser].ToString().Trim(); //修改人
objgs_TeachingDateEN.Memo = objRow[congs_TeachingDate.Memo] == DBNull.Value ? null : objRow[congs_TeachingDate.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_TeachingDateEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_TeachingDateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_TeachingDateEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsgs_TeachingDateEN> arrObjLst = new List<clsgs_TeachingDateEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_TeachingDateEN objgs_TeachingDateEN = new clsgs_TeachingDateEN();
try
{
objgs_TeachingDateEN.mId = Int32.Parse(objRow[congs_TeachingDate.mId].ToString().Trim()); //mId
objgs_TeachingDateEN.IdCurrEduCls = objRow[congs_TeachingDate.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_TeachingDate.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_TeachingDateEN.StartDate = objRow[congs_TeachingDate.StartDate] == DBNull.Value ? null : objRow[congs_TeachingDate.StartDate].ToString().Trim(); //开始日期
objgs_TeachingDateEN.EndDate = objRow[congs_TeachingDate.EndDate] == DBNull.Value ? null : objRow[congs_TeachingDate.EndDate].ToString().Trim(); //截止日期
objgs_TeachingDateEN.UpdDate = objRow[congs_TeachingDate.UpdDate] == DBNull.Value ? null : objRow[congs_TeachingDate.UpdDate].ToString().Trim(); //修改日期
objgs_TeachingDateEN.UpdUser = objRow[congs_TeachingDate.UpdUser] == DBNull.Value ? null : objRow[congs_TeachingDate.UpdUser].ToString().Trim(); //修改人
objgs_TeachingDateEN.Memo = objRow[congs_TeachingDate.Memo] == DBNull.Value ? null : objRow[congs_TeachingDate.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_TeachingDateEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_TeachingDateEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objgs_TeachingDateEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getgs_TeachingDate(ref clsgs_TeachingDateEN objgs_TeachingDateEN)
{
bool bolResult = gs_TeachingDateDA.Getgs_TeachingDate(ref objgs_TeachingDateEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_TeachingDateEN GetObjBymId(long lngmId)
{
clsgs_TeachingDateEN objgs_TeachingDateEN = gs_TeachingDateDA.GetObjBymId(lngmId);
return objgs_TeachingDateEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsgs_TeachingDateEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsgs_TeachingDateEN objgs_TeachingDateEN = gs_TeachingDateDA.GetFirstObj(strWhereCond);
 return objgs_TeachingDateEN;
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
public static clsgs_TeachingDateEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsgs_TeachingDateEN objgs_TeachingDateEN = gs_TeachingDateDA.GetObjByDataRow(objRow);
 return objgs_TeachingDateEN;
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
public static clsgs_TeachingDateEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsgs_TeachingDateEN objgs_TeachingDateEN = gs_TeachingDateDA.GetObjByDataRow(objRow);
 return objgs_TeachingDateEN;
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
 /// <param name = "lstgs_TeachingDateObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_TeachingDateEN GetObjBymIdFromList(long lngmId, List<clsgs_TeachingDateEN> lstgs_TeachingDateObjLst)
{
foreach (clsgs_TeachingDateEN objgs_TeachingDateEN in lstgs_TeachingDateObjLst)
{
if (objgs_TeachingDateEN.mId == lngmId)
{
return objgs_TeachingDateEN;
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
 lngmId = new clsgs_TeachingDateDA().GetFirstID(strWhereCond);
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
 arrList = gs_TeachingDateDA.GetID(strWhereCond);
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
bool bolIsExist = gs_TeachingDateDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = gs_TeachingDateDA.IsExist(lngmId);
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
 bolIsExist = clsgs_TeachingDateDA.IsExistTable();
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
 bolIsExist = gs_TeachingDateDA.IsExistTable(strTabName);
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
 /// <param name = "objgs_TeachingDateEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsgs_TeachingDateEN objgs_TeachingDateEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objgs_TeachingDateEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!mId = [{0}]的数据已经存在!(in clsgs_TeachingDateBL.AddNewRecordBySql2)", objgs_TeachingDateEN.mId);
throw new Exception(strMsg);
}
try
{
bool bolResult = gs_TeachingDateDA.AddNewRecordBySQL2(objgs_TeachingDateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TeachingDateBL.ReFreshCache(objgs_TeachingDateEN.IdCurrEduCls);

if (clsgs_TeachingDateBL.relatedActions != null)
{
clsgs_TeachingDateBL.relatedActions.UpdRelaTabDate(objgs_TeachingDateEN.mId, "SetUpdDate");
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
 /// <param name = "objgs_TeachingDateEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsgs_TeachingDateEN objgs_TeachingDateEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objgs_TeachingDateEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!mId = [{0}]的数据已经存在!(in clsgs_TeachingDateBL.AddNewRecordBySql2WithReturnKey)", objgs_TeachingDateEN.mId);
throw new Exception(strMsg);
}
try
{
string strKey = gs_TeachingDateDA.AddNewRecordBySQL2WithReturnKey(objgs_TeachingDateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TeachingDateBL.ReFreshCache(objgs_TeachingDateEN.IdCurrEduCls);

if (clsgs_TeachingDateBL.relatedActions != null)
{
clsgs_TeachingDateBL.relatedActions.UpdRelaTabDate(objgs_TeachingDateEN.mId, "SetUpdDate");
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
 /// <param name = "objgs_TeachingDateEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsgs_TeachingDateEN objgs_TeachingDateEN)
{
try
{
bool bolResult = gs_TeachingDateDA.Update(objgs_TeachingDateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TeachingDateBL.ReFreshCache(objgs_TeachingDateEN.IdCurrEduCls);

if (clsgs_TeachingDateBL.relatedActions != null)
{
clsgs_TeachingDateBL.relatedActions.UpdRelaTabDate(objgs_TeachingDateEN.mId, "SetUpdDate");
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
 /// <param name = "objgs_TeachingDateEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsgs_TeachingDateEN objgs_TeachingDateEN)
{
 if (objgs_TeachingDateEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = gs_TeachingDateDA.UpdateBySql2(objgs_TeachingDateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TeachingDateBL.ReFreshCache(objgs_TeachingDateEN.IdCurrEduCls);

if (clsgs_TeachingDateBL.relatedActions != null)
{
clsgs_TeachingDateBL.relatedActions.UpdRelaTabDate(objgs_TeachingDateEN.mId, "SetUpdDate");
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
 clsgs_TeachingDateEN objgs_TeachingDateEN = clsgs_TeachingDateBL.GetObjBymId(lngmId);

if (clsgs_TeachingDateBL.relatedActions != null)
{
clsgs_TeachingDateBL.relatedActions.UpdRelaTabDate(objgs_TeachingDateEN.mId, "SetUpdDate");
}
if (objgs_TeachingDateEN != null)
{
int intRecNum = gs_TeachingDateDA.DelRecord(lngmId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objgs_TeachingDateEN.IdCurrEduCls);
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
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(long lngmId , string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsgs_TeachingDateDA.GetSpecSQLObj();
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
//删除与表:[gs_TeachingDate]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//congs_TeachingDate.mId,
//lngmId);
//        clsgs_TeachingDateBL.Delgs_TeachingDatesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsgs_TeachingDateBL.DelRecord(lngmId, strIdCurrEduCls, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsgs_TeachingDateBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
public static bool DelRecord(long lngmId, string strIdCurrEduCls, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsgs_TeachingDateBL.relatedActions != null)
{
clsgs_TeachingDateBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = gs_TeachingDateDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrmIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delgs_TeachingDates(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsgs_TeachingDateBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsgs_TeachingDateBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
 clsgs_TeachingDateEN objgs_TeachingDateEN = clsgs_TeachingDateBL.GetObjBymId(long.Parse(arrmIdLst[0]));
int intDelRecNum = gs_TeachingDateDA.Delgs_TeachingDate(arrmIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objgs_TeachingDateEN.IdCurrEduCls);
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
public static int Delgs_TeachingDatesByCond(string strWhereCond)
{
try
{
if (clsgs_TeachingDateBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsgs_TeachingDateBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
List<string> arrIdCurrEduCls = GetFldValue(congs_TeachingDate.IdCurrEduCls, strWhereCond);
int intRecNum = gs_TeachingDateDA.Delgs_TeachingDate(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[gs_TeachingDate]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId, string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsgs_TeachingDateDA.GetSpecSQLObj();
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
//删除与表:[gs_TeachingDate]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsgs_TeachingDateBL.DelRecord(lngmId, strIdCurrEduCls, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsgs_TeachingDateBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objgs_TeachingDateENS">源对象</param>
 /// <param name = "objgs_TeachingDateENT">目标对象</param>
 public static void CopyTo(clsgs_TeachingDateEN objgs_TeachingDateENS, clsgs_TeachingDateEN objgs_TeachingDateENT)
{
try
{
objgs_TeachingDateENT.mId = objgs_TeachingDateENS.mId; //mId
objgs_TeachingDateENT.IdCurrEduCls = objgs_TeachingDateENS.IdCurrEduCls; //教学班流水号
objgs_TeachingDateENT.StartDate = objgs_TeachingDateENS.StartDate; //开始日期
objgs_TeachingDateENT.EndDate = objgs_TeachingDateENS.EndDate; //截止日期
objgs_TeachingDateENT.UpdDate = objgs_TeachingDateENS.UpdDate; //修改日期
objgs_TeachingDateENT.UpdUser = objgs_TeachingDateENS.UpdUser; //修改人
objgs_TeachingDateENT.Memo = objgs_TeachingDateENS.Memo; //备注
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
 /// <param name = "objgs_TeachingDateEN">源简化对象</param>
 public static void SetUpdFlag(clsgs_TeachingDateEN objgs_TeachingDateEN)
{
try
{
objgs_TeachingDateEN.ClearUpdateState();
   string strsfUpdFldSetStr = objgs_TeachingDateEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(congs_TeachingDate.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TeachingDateEN.mId = objgs_TeachingDateEN.mId; //mId
}
if (arrFldSet.Contains(congs_TeachingDate.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TeachingDateEN.IdCurrEduCls = objgs_TeachingDateEN.IdCurrEduCls == "[null]" ? null :  objgs_TeachingDateEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(congs_TeachingDate.StartDate, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TeachingDateEN.StartDate = objgs_TeachingDateEN.StartDate == "[null]" ? null :  objgs_TeachingDateEN.StartDate; //开始日期
}
if (arrFldSet.Contains(congs_TeachingDate.EndDate, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TeachingDateEN.EndDate = objgs_TeachingDateEN.EndDate == "[null]" ? null :  objgs_TeachingDateEN.EndDate; //截止日期
}
if (arrFldSet.Contains(congs_TeachingDate.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TeachingDateEN.UpdDate = objgs_TeachingDateEN.UpdDate == "[null]" ? null :  objgs_TeachingDateEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(congs_TeachingDate.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TeachingDateEN.UpdUser = objgs_TeachingDateEN.UpdUser == "[null]" ? null :  objgs_TeachingDateEN.UpdUser; //修改人
}
if (arrFldSet.Contains(congs_TeachingDate.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TeachingDateEN.Memo = objgs_TeachingDateEN.Memo == "[null]" ? null :  objgs_TeachingDateEN.Memo; //备注
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
 /// <param name = "objgs_TeachingDateEN">源简化对象</param>
 public static void AccessFldValueNull(clsgs_TeachingDateEN objgs_TeachingDateEN)
{
try
{
if (objgs_TeachingDateEN.IdCurrEduCls == "[null]") objgs_TeachingDateEN.IdCurrEduCls = null; //教学班流水号
if (objgs_TeachingDateEN.StartDate == "[null]") objgs_TeachingDateEN.StartDate = null; //开始日期
if (objgs_TeachingDateEN.EndDate == "[null]") objgs_TeachingDateEN.EndDate = null; //截止日期
if (objgs_TeachingDateEN.UpdDate == "[null]") objgs_TeachingDateEN.UpdDate = null; //修改日期
if (objgs_TeachingDateEN.UpdUser == "[null]") objgs_TeachingDateEN.UpdUser = null; //修改人
if (objgs_TeachingDateEN.Memo == "[null]") objgs_TeachingDateEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsgs_TeachingDateEN objgs_TeachingDateEN)
{
 gs_TeachingDateDA.CheckPropertyNew(objgs_TeachingDateEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsgs_TeachingDateEN objgs_TeachingDateEN)
{
 gs_TeachingDateDA.CheckProperty4Condition(objgs_TeachingDateEN);
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
if (clsgs_TeachingDateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_TeachingDateBL没有刷新缓存机制(clsgs_TeachingDateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrgs_TeachingDateObjLstCache == null)
//{
//arrgs_TeachingDateObjLstCache = gs_TeachingDateDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_TeachingDateEN GetObjBymIdCache(long lngmId, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsgs_TeachingDateEN._CurrTabName, strIdCurrEduCls);
List<clsgs_TeachingDateEN> arrgs_TeachingDateObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsgs_TeachingDateEN> arrgs_TeachingDateObjLst_Sel =
arrgs_TeachingDateObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrgs_TeachingDateObjLst_Sel.Count() == 0)
{
   clsgs_TeachingDateEN obj = clsgs_TeachingDateBL.GetObjBymId(lngmId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngmId, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrgs_TeachingDateObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_TeachingDateEN> GetAllgs_TeachingDateObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsgs_TeachingDateEN> arrgs_TeachingDateObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrgs_TeachingDateObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_TeachingDateEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsgs_TeachingDateEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsgs_TeachingDateEN> arrgs_TeachingDateObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrgs_TeachingDateObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsgs_TeachingDateEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clsgs_TeachingDateEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsgs_TeachingDateEN._RefreshTimeLst.Count == 0) return "";
return clsgs_TeachingDateEN._RefreshTimeLst[clsgs_TeachingDateEN._RefreshTimeLst.Count - 1];
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
if (clsgs_TeachingDateBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsgs_TeachingDateEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clsgs_TeachingDateEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsgs_TeachingDateBL.objCommFun4BL.ReFreshCache(strIdCurrEduCls);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--gs_TeachingDate(教学班日期范围)
 /// 唯一性条件:mId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objgs_TeachingDateEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsgs_TeachingDateEN objgs_TeachingDateEN)
{
//检测记录是否存在
string strResult = gs_TeachingDateDA.GetUniCondStr(objgs_TeachingDateEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strIdCurrEduCls)
{
if (strInFldName != congs_TeachingDate.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (congs_TeachingDate.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", congs_TeachingDate.AttributeName));
throw new Exception(strMsg);
}
var objgs_TeachingDate = clsgs_TeachingDateBL.GetObjBymIdCache(lngmId, strIdCurrEduCls);
if (objgs_TeachingDate == null) return "";
return objgs_TeachingDate[strOutFldName].ToString();
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
int intRecCount = clsgs_TeachingDateDA.GetRecCount(strTabName);
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
int intRecCount = clsgs_TeachingDateDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsgs_TeachingDateDA.GetRecCount();
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
int intRecCount = clsgs_TeachingDateDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objgs_TeachingDateCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsgs_TeachingDateEN objgs_TeachingDateCond)
{
 string strIdCurrEduCls = objgs_TeachingDateCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsgs_TeachingDateBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsgs_TeachingDateEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsgs_TeachingDateEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in congs_TeachingDate.AttributeName)
{
if (objgs_TeachingDateCond.IsUpdated(strFldName) == false) continue;
if (objgs_TeachingDateCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_TeachingDateCond[strFldName].ToString());
}
else
{
if (objgs_TeachingDateCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objgs_TeachingDateCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_TeachingDateCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objgs_TeachingDateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objgs_TeachingDateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objgs_TeachingDateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objgs_TeachingDateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objgs_TeachingDateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objgs_TeachingDateCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objgs_TeachingDateCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objgs_TeachingDateCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objgs_TeachingDateCond[strFldName]));
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
 List<string> arrList = clsgs_TeachingDateDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = gs_TeachingDateDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = gs_TeachingDateDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = gs_TeachingDateDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsgs_TeachingDateDA.SetFldValue(clsgs_TeachingDateEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = gs_TeachingDateDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsgs_TeachingDateDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsgs_TeachingDateDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsgs_TeachingDateDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[gs_TeachingDate] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) Null, "); 
 // /**开始日期*/ 
 strCreateTabCode.Append(" StartDate varchar(20) Null, "); 
 // /**截止日期*/ 
 strCreateTabCode.Append(" EndDate varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 教学班日期范围(gs_TeachingDate)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4gs_TeachingDate : clsCommFun4BLV2
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
clsgs_TeachingDateBL.ReFreshThisCache(strIdCurrEduCls);
}
}

}