
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_VpClassificationBL
 表名:gs_VpClassification(01120958)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:04:18
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
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
public static class  clsgs_VpClassificationBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngClassificationId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_VpClassificationEN GetObj(this K_ClassificationId_gs_VpClassification myKey)
{
clsgs_VpClassificationEN objgs_VpClassificationEN = clsgs_VpClassificationBL.gs_VpClassificationDA.GetObjByClassificationId(myKey.Value);
return objgs_VpClassificationEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objgs_VpClassificationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsgs_VpClassificationEN objgs_VpClassificationEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_VpClassificationEN) == false)
{
var strMsg = string.Format("记录已经存在!分类名称 = [{0}]的数据已经存在!(in clsgs_VpClassificationBL.AddNewRecord)", objgs_VpClassificationEN.ClassificationName);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsgs_VpClassificationBL.gs_VpClassificationDA.AddNewRecordBySQL2(objgs_VpClassificationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_VpClassificationBL.ReFreshCache();

if (clsgs_VpClassificationBL.relatedActions != null)
{
clsgs_VpClassificationBL.relatedActions.UpdRelaTabDate(objgs_VpClassificationEN.ClassificationId, objgs_VpClassificationEN.UpdUser);
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
public static bool AddRecordEx(this clsgs_VpClassificationEN objgs_VpClassificationEN, bool bolIsNeedCheckUniqueness = true)
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
objgs_VpClassificationEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objgs_VpClassificationEN.CheckUniqueness() == false)
{
strMsg = string.Format("(分类名称(ClassificationName)=[{0}])已经存在,不能重复!", objgs_VpClassificationEN.ClassificationName);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objgs_VpClassificationEN.AddNewRecord();
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
 /// <param name = "objgs_VpClassificationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsgs_VpClassificationEN objgs_VpClassificationEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_VpClassificationEN) == false)
{
var strMsg = string.Format("记录已经存在!分类名称 = [{0}]的数据已经存在!(in clsgs_VpClassificationBL.AddNewRecordWithReturnKey)", objgs_VpClassificationEN.ClassificationName);
throw new Exception(strMsg);
}
try
{
string strKey = clsgs_VpClassificationBL.gs_VpClassificationDA.AddNewRecordBySQL2WithReturnKey(objgs_VpClassificationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_VpClassificationBL.ReFreshCache();

if (clsgs_VpClassificationBL.relatedActions != null)
{
clsgs_VpClassificationBL.relatedActions.UpdRelaTabDate(objgs_VpClassificationEN.ClassificationId, objgs_VpClassificationEN.UpdUser);
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
 /// <param name = "objgs_VpClassificationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_VpClassificationEN SetClassificationId(this clsgs_VpClassificationEN objgs_VpClassificationEN, long lngClassificationId, string strComparisonOp="")
	{
objgs_VpClassificationEN.ClassificationId = lngClassificationId; //分类Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_VpClassificationEN.dicFldComparisonOp.ContainsKey(congs_VpClassification.ClassificationId) == false)
{
objgs_VpClassificationEN.dicFldComparisonOp.Add(congs_VpClassification.ClassificationId, strComparisonOp);
}
else
{
objgs_VpClassificationEN.dicFldComparisonOp[congs_VpClassification.ClassificationId] = strComparisonOp;
}
}
return objgs_VpClassificationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_VpClassificationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_VpClassificationEN SetClassificationName(this clsgs_VpClassificationEN objgs_VpClassificationEN, string strClassificationName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strClassificationName, congs_VpClassification.ClassificationName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClassificationName, 200, congs_VpClassification.ClassificationName);
}
objgs_VpClassificationEN.ClassificationName = strClassificationName; //分类名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_VpClassificationEN.dicFldComparisonOp.ContainsKey(congs_VpClassification.ClassificationName) == false)
{
objgs_VpClassificationEN.dicFldComparisonOp.Add(congs_VpClassification.ClassificationName, strComparisonOp);
}
else
{
objgs_VpClassificationEN.dicFldComparisonOp[congs_VpClassification.ClassificationName] = strComparisonOp;
}
}
return objgs_VpClassificationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_VpClassificationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_VpClassificationEN SetOrderNum(this clsgs_VpClassificationEN objgs_VpClassificationEN, int? intOrderNum, string strComparisonOp="")
	{
objgs_VpClassificationEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_VpClassificationEN.dicFldComparisonOp.ContainsKey(congs_VpClassification.OrderNum) == false)
{
objgs_VpClassificationEN.dicFldComparisonOp.Add(congs_VpClassification.OrderNum, strComparisonOp);
}
else
{
objgs_VpClassificationEN.dicFldComparisonOp[congs_VpClassification.OrderNum] = strComparisonOp;
}
}
return objgs_VpClassificationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_VpClassificationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_VpClassificationEN SetInUse(this clsgs_VpClassificationEN objgs_VpClassificationEN, bool bolInUse, string strComparisonOp="")
	{
objgs_VpClassificationEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_VpClassificationEN.dicFldComparisonOp.ContainsKey(congs_VpClassification.InUse) == false)
{
objgs_VpClassificationEN.dicFldComparisonOp.Add(congs_VpClassification.InUse, strComparisonOp);
}
else
{
objgs_VpClassificationEN.dicFldComparisonOp[congs_VpClassification.InUse] = strComparisonOp;
}
}
return objgs_VpClassificationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_VpClassificationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_VpClassificationEN SetUpdDate(this clsgs_VpClassificationEN objgs_VpClassificationEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, congs_VpClassification.UpdDate);
}
objgs_VpClassificationEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_VpClassificationEN.dicFldComparisonOp.ContainsKey(congs_VpClassification.UpdDate) == false)
{
objgs_VpClassificationEN.dicFldComparisonOp.Add(congs_VpClassification.UpdDate, strComparisonOp);
}
else
{
objgs_VpClassificationEN.dicFldComparisonOp[congs_VpClassification.UpdDate] = strComparisonOp;
}
}
return objgs_VpClassificationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_VpClassificationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_VpClassificationEN SetUpdUser(this clsgs_VpClassificationEN objgs_VpClassificationEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, congs_VpClassification.UpdUser);
}
objgs_VpClassificationEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_VpClassificationEN.dicFldComparisonOp.ContainsKey(congs_VpClassification.UpdUser) == false)
{
objgs_VpClassificationEN.dicFldComparisonOp.Add(congs_VpClassification.UpdUser, strComparisonOp);
}
else
{
objgs_VpClassificationEN.dicFldComparisonOp[congs_VpClassification.UpdUser] = strComparisonOp;
}
}
return objgs_VpClassificationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_VpClassificationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_VpClassificationEN SetMemo(this clsgs_VpClassificationEN objgs_VpClassificationEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, congs_VpClassification.Memo);
}
objgs_VpClassificationEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_VpClassificationEN.dicFldComparisonOp.ContainsKey(congs_VpClassification.Memo) == false)
{
objgs_VpClassificationEN.dicFldComparisonOp.Add(congs_VpClassification.Memo, strComparisonOp);
}
else
{
objgs_VpClassificationEN.dicFldComparisonOp[congs_VpClassification.Memo] = strComparisonOp;
}
}
return objgs_VpClassificationEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objgs_VpClassificationEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsgs_VpClassificationEN objgs_VpClassificationEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objgs_VpClassificationEN.CheckPropertyNew();
clsgs_VpClassificationEN objgs_VpClassificationCond = new clsgs_VpClassificationEN();
string strCondition = objgs_VpClassificationCond
.SetClassificationId(objgs_VpClassificationEN.ClassificationId, "<>")
.SetClassificationName(objgs_VpClassificationEN.ClassificationName, "=")
.GetCombineCondition();
objgs_VpClassificationEN._IsCheckProperty = true;
bool bolIsExist = clsgs_VpClassificationBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(ClassificationName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objgs_VpClassificationEN.Update();
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
 /// <param name = "objgs_VpClassification">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsgs_VpClassificationEN objgs_VpClassification)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsgs_VpClassificationEN objgs_VpClassificationCond = new clsgs_VpClassificationEN();
string strCondition = objgs_VpClassificationCond
.SetClassificationName(objgs_VpClassification.ClassificationName, "=")
.GetCombineCondition();
objgs_VpClassification._IsCheckProperty = true;
bool bolIsExist = clsgs_VpClassificationBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objgs_VpClassification.ClassificationId = clsgs_VpClassificationBL.GetFirstID_S(strCondition);
objgs_VpClassification.UpdateWithCondition(strCondition);
}
else
{
objgs_VpClassification.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objgs_VpClassificationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_VpClassificationEN objgs_VpClassificationEN)
{
 if (objgs_VpClassificationEN.ClassificationId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsgs_VpClassificationBL.gs_VpClassificationDA.UpdateBySql2(objgs_VpClassificationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_VpClassificationBL.ReFreshCache();

if (clsgs_VpClassificationBL.relatedActions != null)
{
clsgs_VpClassificationBL.relatedActions.UpdRelaTabDate(objgs_VpClassificationEN.ClassificationId, objgs_VpClassificationEN.UpdUser);
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
 /// <param name = "objgs_VpClassificationEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_VpClassificationEN objgs_VpClassificationEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objgs_VpClassificationEN.ClassificationId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsgs_VpClassificationBL.gs_VpClassificationDA.UpdateBySql2(objgs_VpClassificationEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_VpClassificationBL.ReFreshCache();

if (clsgs_VpClassificationBL.relatedActions != null)
{
clsgs_VpClassificationBL.relatedActions.UpdRelaTabDate(objgs_VpClassificationEN.ClassificationId, objgs_VpClassificationEN.UpdUser);
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
 /// <param name = "objgs_VpClassificationEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_VpClassificationEN objgs_VpClassificationEN, string strWhereCond)
{
try
{
bool bolResult = clsgs_VpClassificationBL.gs_VpClassificationDA.UpdateBySqlWithCondition(objgs_VpClassificationEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_VpClassificationBL.ReFreshCache();

if (clsgs_VpClassificationBL.relatedActions != null)
{
clsgs_VpClassificationBL.relatedActions.UpdRelaTabDate(objgs_VpClassificationEN.ClassificationId, objgs_VpClassificationEN.UpdUser);
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
 /// <param name = "objgs_VpClassificationEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_VpClassificationEN objgs_VpClassificationEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsgs_VpClassificationBL.gs_VpClassificationDA.UpdateBySqlWithConditionTransaction(objgs_VpClassificationEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_VpClassificationBL.ReFreshCache();

if (clsgs_VpClassificationBL.relatedActions != null)
{
clsgs_VpClassificationBL.relatedActions.UpdRelaTabDate(objgs_VpClassificationEN.ClassificationId, objgs_VpClassificationEN.UpdUser);
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
 /// <param name = "lngClassificationId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsgs_VpClassificationEN objgs_VpClassificationEN)
{
try
{
int intRecNum = clsgs_VpClassificationBL.gs_VpClassificationDA.DelRecord(objgs_VpClassificationEN.ClassificationId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_VpClassificationBL.ReFreshCache();

if (clsgs_VpClassificationBL.relatedActions != null)
{
clsgs_VpClassificationBL.relatedActions.UpdRelaTabDate(objgs_VpClassificationEN.ClassificationId, objgs_VpClassificationEN.UpdUser);
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
 /// <param name = "objgs_VpClassificationENS">源对象</param>
 /// <param name = "objgs_VpClassificationENT">目标对象</param>
 public static void CopyTo(this clsgs_VpClassificationEN objgs_VpClassificationENS, clsgs_VpClassificationEN objgs_VpClassificationENT)
{
try
{
objgs_VpClassificationENT.ClassificationId = objgs_VpClassificationENS.ClassificationId; //分类Id
objgs_VpClassificationENT.ClassificationName = objgs_VpClassificationENS.ClassificationName; //分类名称
objgs_VpClassificationENT.OrderNum = objgs_VpClassificationENS.OrderNum; //序号
objgs_VpClassificationENT.InUse = objgs_VpClassificationENS.InUse; //是否在用
objgs_VpClassificationENT.UpdDate = objgs_VpClassificationENS.UpdDate; //修改日期
objgs_VpClassificationENT.UpdUser = objgs_VpClassificationENS.UpdUser; //修改人
objgs_VpClassificationENT.Memo = objgs_VpClassificationENS.Memo; //备注
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
 /// <param name = "objgs_VpClassificationENS">源对象</param>
 /// <returns>目标对象=>clsgs_VpClassificationEN:objgs_VpClassificationENT</returns>
 public static clsgs_VpClassificationEN CopyTo(this clsgs_VpClassificationEN objgs_VpClassificationENS)
{
try
{
 clsgs_VpClassificationEN objgs_VpClassificationENT = new clsgs_VpClassificationEN()
{
ClassificationId = objgs_VpClassificationENS.ClassificationId, //分类Id
ClassificationName = objgs_VpClassificationENS.ClassificationName, //分类名称
OrderNum = objgs_VpClassificationENS.OrderNum, //序号
InUse = objgs_VpClassificationENS.InUse, //是否在用
UpdDate = objgs_VpClassificationENS.UpdDate, //修改日期
UpdUser = objgs_VpClassificationENS.UpdUser, //修改人
Memo = objgs_VpClassificationENS.Memo, //备注
};
 return objgs_VpClassificationENT;
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
public static void CheckPropertyNew(this clsgs_VpClassificationEN objgs_VpClassificationEN)
{
 clsgs_VpClassificationBL.gs_VpClassificationDA.CheckPropertyNew(objgs_VpClassificationEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsgs_VpClassificationEN objgs_VpClassificationEN)
{
 clsgs_VpClassificationBL.gs_VpClassificationDA.CheckProperty4Condition(objgs_VpClassificationEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsgs_VpClassificationEN objgs_VpClassificationCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objgs_VpClassificationCond.IsUpdated(congs_VpClassification.ClassificationId) == true)
{
string strComparisonOpClassificationId = objgs_VpClassificationCond.dicFldComparisonOp[congs_VpClassification.ClassificationId];
strWhereCond += string.Format(" And {0} {2} {1}", congs_VpClassification.ClassificationId, objgs_VpClassificationCond.ClassificationId, strComparisonOpClassificationId);
}
if (objgs_VpClassificationCond.IsUpdated(congs_VpClassification.ClassificationName) == true)
{
string strComparisonOpClassificationName = objgs_VpClassificationCond.dicFldComparisonOp[congs_VpClassification.ClassificationName];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_VpClassification.ClassificationName, objgs_VpClassificationCond.ClassificationName, strComparisonOpClassificationName);
}
if (objgs_VpClassificationCond.IsUpdated(congs_VpClassification.OrderNum) == true)
{
string strComparisonOpOrderNum = objgs_VpClassificationCond.dicFldComparisonOp[congs_VpClassification.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", congs_VpClassification.OrderNum, objgs_VpClassificationCond.OrderNum, strComparisonOpOrderNum);
}
if (objgs_VpClassificationCond.IsUpdated(congs_VpClassification.InUse) == true)
{
if (objgs_VpClassificationCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", congs_VpClassification.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", congs_VpClassification.InUse);
}
}
if (objgs_VpClassificationCond.IsUpdated(congs_VpClassification.UpdDate) == true)
{
string strComparisonOpUpdDate = objgs_VpClassificationCond.dicFldComparisonOp[congs_VpClassification.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_VpClassification.UpdDate, objgs_VpClassificationCond.UpdDate, strComparisonOpUpdDate);
}
if (objgs_VpClassificationCond.IsUpdated(congs_VpClassification.UpdUser) == true)
{
string strComparisonOpUpdUser = objgs_VpClassificationCond.dicFldComparisonOp[congs_VpClassification.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_VpClassification.UpdUser, objgs_VpClassificationCond.UpdUser, strComparisonOpUpdUser);
}
if (objgs_VpClassificationCond.IsUpdated(congs_VpClassification.Memo) == true)
{
string strComparisonOpMemo = objgs_VpClassificationCond.dicFldComparisonOp[congs_VpClassification.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_VpClassification.Memo, objgs_VpClassificationCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--gs_VpClassification(各观点分类表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:ClassificationName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objgs_VpClassificationEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsgs_VpClassificationEN objgs_VpClassificationEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objgs_VpClassificationEN == null) return true;
if (objgs_VpClassificationEN.ClassificationId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ClassificationName = '{0}'", objgs_VpClassificationEN.ClassificationName);
if (clsgs_VpClassificationBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("ClassificationId !=  {0}", objgs_VpClassificationEN.ClassificationId);
 sbCondition.AppendFormat(" and ClassificationName = '{0}'", objgs_VpClassificationEN.ClassificationName);
if (clsgs_VpClassificationBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--gs_VpClassification(各观点分类表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ClassificationName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objgs_VpClassificationEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsgs_VpClassificationEN objgs_VpClassificationEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objgs_VpClassificationEN == null) return "";
if (objgs_VpClassificationEN.ClassificationId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ClassificationName = '{0}'", objgs_VpClassificationEN.ClassificationName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ClassificationId !=  {0}", objgs_VpClassificationEN.ClassificationId);
 sbCondition.AppendFormat(" and ClassificationName = '{0}'", objgs_VpClassificationEN.ClassificationName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_gs_VpClassification
{
public virtual bool UpdRelaTabDate(long lngClassificationId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 各观点分类表(gs_VpClassification)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsgs_VpClassificationBL
{
public static RelatedActions_gs_VpClassification relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsgs_VpClassificationDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsgs_VpClassificationDA gs_VpClassificationDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsgs_VpClassificationDA();
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
 public clsgs_VpClassificationBL()
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
if (string.IsNullOrEmpty(clsgs_VpClassificationEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsgs_VpClassificationEN._ConnectString);
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
public static DataTable GetDataTable_gs_VpClassification(string strWhereCond)
{
DataTable objDT;
try
{
objDT = gs_VpClassificationDA.GetDataTable_gs_VpClassification(strWhereCond);
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
objDT = gs_VpClassificationDA.GetDataTable(strWhereCond);
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
objDT = gs_VpClassificationDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = gs_VpClassificationDA.GetDataTable(strWhereCond, strTabName);
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
objDT = gs_VpClassificationDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = gs_VpClassificationDA.GetDataTable_Top(objTopPara);
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
objDT = gs_VpClassificationDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = gs_VpClassificationDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = gs_VpClassificationDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrClassificationIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsgs_VpClassificationEN> GetObjLstByClassificationIdLst(List<long> arrClassificationIdLst)
{
List<clsgs_VpClassificationEN> arrObjLst = new List<clsgs_VpClassificationEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrClassificationIdLst);
 string strWhereCond = string.Format("ClassificationId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_VpClassificationEN objgs_VpClassificationEN = new clsgs_VpClassificationEN();
try
{
objgs_VpClassificationEN.ClassificationId = Int32.Parse(objRow[congs_VpClassification.ClassificationId].ToString().Trim()); //分类Id
objgs_VpClassificationEN.ClassificationName = objRow[congs_VpClassification.ClassificationName].ToString().Trim(); //分类名称
objgs_VpClassificationEN.OrderNum = objRow[congs_VpClassification.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_VpClassification.OrderNum].ToString().Trim()); //序号
objgs_VpClassificationEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[congs_VpClassification.InUse].ToString().Trim()); //是否在用
objgs_VpClassificationEN.UpdDate = objRow[congs_VpClassification.UpdDate] == DBNull.Value ? null : objRow[congs_VpClassification.UpdDate].ToString().Trim(); //修改日期
objgs_VpClassificationEN.UpdUser = objRow[congs_VpClassification.UpdUser] == DBNull.Value ? null : objRow[congs_VpClassification.UpdUser].ToString().Trim(); //修改人
objgs_VpClassificationEN.Memo = objRow[congs_VpClassification.Memo] == DBNull.Value ? null : objRow[congs_VpClassification.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_VpClassificationEN.ClassificationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_VpClassificationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrClassificationIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsgs_VpClassificationEN> GetObjLstByClassificationIdLstCache(List<long> arrClassificationIdLst)
{
string strKey = string.Format("{0}", clsgs_VpClassificationEN._CurrTabName);
List<clsgs_VpClassificationEN> arrgs_VpClassificationObjLstCache = GetObjLstCache();
IEnumerable <clsgs_VpClassificationEN> arrgs_VpClassificationObjLst_Sel =
arrgs_VpClassificationObjLstCache
.Where(x => arrClassificationIdLst.Contains(x.ClassificationId));
return arrgs_VpClassificationObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_VpClassificationEN> GetObjLst(string strWhereCond)
{
List<clsgs_VpClassificationEN> arrObjLst = new List<clsgs_VpClassificationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_VpClassificationEN objgs_VpClassificationEN = new clsgs_VpClassificationEN();
try
{
objgs_VpClassificationEN.ClassificationId = Int32.Parse(objRow[congs_VpClassification.ClassificationId].ToString().Trim()); //分类Id
objgs_VpClassificationEN.ClassificationName = objRow[congs_VpClassification.ClassificationName].ToString().Trim(); //分类名称
objgs_VpClassificationEN.OrderNum = objRow[congs_VpClassification.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_VpClassification.OrderNum].ToString().Trim()); //序号
objgs_VpClassificationEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[congs_VpClassification.InUse].ToString().Trim()); //是否在用
objgs_VpClassificationEN.UpdDate = objRow[congs_VpClassification.UpdDate] == DBNull.Value ? null : objRow[congs_VpClassification.UpdDate].ToString().Trim(); //修改日期
objgs_VpClassificationEN.UpdUser = objRow[congs_VpClassification.UpdUser] == DBNull.Value ? null : objRow[congs_VpClassification.UpdUser].ToString().Trim(); //修改人
objgs_VpClassificationEN.Memo = objRow[congs_VpClassification.Memo] == DBNull.Value ? null : objRow[congs_VpClassification.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_VpClassificationEN.ClassificationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_VpClassificationEN);
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
public static List<clsgs_VpClassificationEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsgs_VpClassificationEN> arrObjLst = new List<clsgs_VpClassificationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_VpClassificationEN objgs_VpClassificationEN = new clsgs_VpClassificationEN();
try
{
objgs_VpClassificationEN.ClassificationId = Int32.Parse(objRow[congs_VpClassification.ClassificationId].ToString().Trim()); //分类Id
objgs_VpClassificationEN.ClassificationName = objRow[congs_VpClassification.ClassificationName].ToString().Trim(); //分类名称
objgs_VpClassificationEN.OrderNum = objRow[congs_VpClassification.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_VpClassification.OrderNum].ToString().Trim()); //序号
objgs_VpClassificationEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[congs_VpClassification.InUse].ToString().Trim()); //是否在用
objgs_VpClassificationEN.UpdDate = objRow[congs_VpClassification.UpdDate] == DBNull.Value ? null : objRow[congs_VpClassification.UpdDate].ToString().Trim(); //修改日期
objgs_VpClassificationEN.UpdUser = objRow[congs_VpClassification.UpdUser] == DBNull.Value ? null : objRow[congs_VpClassification.UpdUser].ToString().Trim(); //修改人
objgs_VpClassificationEN.Memo = objRow[congs_VpClassification.Memo] == DBNull.Value ? null : objRow[congs_VpClassification.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_VpClassificationEN.ClassificationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_VpClassificationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objgs_VpClassificationCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsgs_VpClassificationEN> GetSubObjLstCache(clsgs_VpClassificationEN objgs_VpClassificationCond)
{
List<clsgs_VpClassificationEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsgs_VpClassificationEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in congs_VpClassification.AttributeName)
{
if (objgs_VpClassificationCond.IsUpdated(strFldName) == false) continue;
if (objgs_VpClassificationCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_VpClassificationCond[strFldName].ToString());
}
else
{
if (objgs_VpClassificationCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objgs_VpClassificationCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_VpClassificationCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objgs_VpClassificationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objgs_VpClassificationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objgs_VpClassificationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objgs_VpClassificationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objgs_VpClassificationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objgs_VpClassificationCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objgs_VpClassificationCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objgs_VpClassificationCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objgs_VpClassificationCond[strFldName]));
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
public static List<clsgs_VpClassificationEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsgs_VpClassificationEN> arrObjLst = new List<clsgs_VpClassificationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_VpClassificationEN objgs_VpClassificationEN = new clsgs_VpClassificationEN();
try
{
objgs_VpClassificationEN.ClassificationId = Int32.Parse(objRow[congs_VpClassification.ClassificationId].ToString().Trim()); //分类Id
objgs_VpClassificationEN.ClassificationName = objRow[congs_VpClassification.ClassificationName].ToString().Trim(); //分类名称
objgs_VpClassificationEN.OrderNum = objRow[congs_VpClassification.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_VpClassification.OrderNum].ToString().Trim()); //序号
objgs_VpClassificationEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[congs_VpClassification.InUse].ToString().Trim()); //是否在用
objgs_VpClassificationEN.UpdDate = objRow[congs_VpClassification.UpdDate] == DBNull.Value ? null : objRow[congs_VpClassification.UpdDate].ToString().Trim(); //修改日期
objgs_VpClassificationEN.UpdUser = objRow[congs_VpClassification.UpdUser] == DBNull.Value ? null : objRow[congs_VpClassification.UpdUser].ToString().Trim(); //修改人
objgs_VpClassificationEN.Memo = objRow[congs_VpClassification.Memo] == DBNull.Value ? null : objRow[congs_VpClassification.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_VpClassificationEN.ClassificationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_VpClassificationEN);
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
public static List<clsgs_VpClassificationEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsgs_VpClassificationEN> arrObjLst = new List<clsgs_VpClassificationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_VpClassificationEN objgs_VpClassificationEN = new clsgs_VpClassificationEN();
try
{
objgs_VpClassificationEN.ClassificationId = Int32.Parse(objRow[congs_VpClassification.ClassificationId].ToString().Trim()); //分类Id
objgs_VpClassificationEN.ClassificationName = objRow[congs_VpClassification.ClassificationName].ToString().Trim(); //分类名称
objgs_VpClassificationEN.OrderNum = objRow[congs_VpClassification.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_VpClassification.OrderNum].ToString().Trim()); //序号
objgs_VpClassificationEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[congs_VpClassification.InUse].ToString().Trim()); //是否在用
objgs_VpClassificationEN.UpdDate = objRow[congs_VpClassification.UpdDate] == DBNull.Value ? null : objRow[congs_VpClassification.UpdDate].ToString().Trim(); //修改日期
objgs_VpClassificationEN.UpdUser = objRow[congs_VpClassification.UpdUser] == DBNull.Value ? null : objRow[congs_VpClassification.UpdUser].ToString().Trim(); //修改人
objgs_VpClassificationEN.Memo = objRow[congs_VpClassification.Memo] == DBNull.Value ? null : objRow[congs_VpClassification.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_VpClassificationEN.ClassificationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_VpClassificationEN);
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
List<clsgs_VpClassificationEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsgs_VpClassificationEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_VpClassificationEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsgs_VpClassificationEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsgs_VpClassificationEN> arrObjLst = new List<clsgs_VpClassificationEN>(); 
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
	clsgs_VpClassificationEN objgs_VpClassificationEN = new clsgs_VpClassificationEN();
try
{
objgs_VpClassificationEN.ClassificationId = Int32.Parse(objRow[congs_VpClassification.ClassificationId].ToString().Trim()); //分类Id
objgs_VpClassificationEN.ClassificationName = objRow[congs_VpClassification.ClassificationName].ToString().Trim(); //分类名称
objgs_VpClassificationEN.OrderNum = objRow[congs_VpClassification.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_VpClassification.OrderNum].ToString().Trim()); //序号
objgs_VpClassificationEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[congs_VpClassification.InUse].ToString().Trim()); //是否在用
objgs_VpClassificationEN.UpdDate = objRow[congs_VpClassification.UpdDate] == DBNull.Value ? null : objRow[congs_VpClassification.UpdDate].ToString().Trim(); //修改日期
objgs_VpClassificationEN.UpdUser = objRow[congs_VpClassification.UpdUser] == DBNull.Value ? null : objRow[congs_VpClassification.UpdUser].ToString().Trim(); //修改人
objgs_VpClassificationEN.Memo = objRow[congs_VpClassification.Memo] == DBNull.Value ? null : objRow[congs_VpClassification.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_VpClassificationEN.ClassificationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_VpClassificationEN);
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
public static List<clsgs_VpClassificationEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsgs_VpClassificationEN> arrObjLst = new List<clsgs_VpClassificationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_VpClassificationEN objgs_VpClassificationEN = new clsgs_VpClassificationEN();
try
{
objgs_VpClassificationEN.ClassificationId = Int32.Parse(objRow[congs_VpClassification.ClassificationId].ToString().Trim()); //分类Id
objgs_VpClassificationEN.ClassificationName = objRow[congs_VpClassification.ClassificationName].ToString().Trim(); //分类名称
objgs_VpClassificationEN.OrderNum = objRow[congs_VpClassification.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_VpClassification.OrderNum].ToString().Trim()); //序号
objgs_VpClassificationEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[congs_VpClassification.InUse].ToString().Trim()); //是否在用
objgs_VpClassificationEN.UpdDate = objRow[congs_VpClassification.UpdDate] == DBNull.Value ? null : objRow[congs_VpClassification.UpdDate].ToString().Trim(); //修改日期
objgs_VpClassificationEN.UpdUser = objRow[congs_VpClassification.UpdUser] == DBNull.Value ? null : objRow[congs_VpClassification.UpdUser].ToString().Trim(); //修改人
objgs_VpClassificationEN.Memo = objRow[congs_VpClassification.Memo] == DBNull.Value ? null : objRow[congs_VpClassification.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_VpClassificationEN.ClassificationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_VpClassificationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsgs_VpClassificationEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsgs_VpClassificationEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsgs_VpClassificationEN> arrObjLst = new List<clsgs_VpClassificationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_VpClassificationEN objgs_VpClassificationEN = new clsgs_VpClassificationEN();
try
{
objgs_VpClassificationEN.ClassificationId = Int32.Parse(objRow[congs_VpClassification.ClassificationId].ToString().Trim()); //分类Id
objgs_VpClassificationEN.ClassificationName = objRow[congs_VpClassification.ClassificationName].ToString().Trim(); //分类名称
objgs_VpClassificationEN.OrderNum = objRow[congs_VpClassification.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_VpClassification.OrderNum].ToString().Trim()); //序号
objgs_VpClassificationEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[congs_VpClassification.InUse].ToString().Trim()); //是否在用
objgs_VpClassificationEN.UpdDate = objRow[congs_VpClassification.UpdDate] == DBNull.Value ? null : objRow[congs_VpClassification.UpdDate].ToString().Trim(); //修改日期
objgs_VpClassificationEN.UpdUser = objRow[congs_VpClassification.UpdUser] == DBNull.Value ? null : objRow[congs_VpClassification.UpdUser].ToString().Trim(); //修改人
objgs_VpClassificationEN.Memo = objRow[congs_VpClassification.Memo] == DBNull.Value ? null : objRow[congs_VpClassification.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_VpClassificationEN.ClassificationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_VpClassificationEN);
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
public static List<clsgs_VpClassificationEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsgs_VpClassificationEN> arrObjLst = new List<clsgs_VpClassificationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_VpClassificationEN objgs_VpClassificationEN = new clsgs_VpClassificationEN();
try
{
objgs_VpClassificationEN.ClassificationId = Int32.Parse(objRow[congs_VpClassification.ClassificationId].ToString().Trim()); //分类Id
objgs_VpClassificationEN.ClassificationName = objRow[congs_VpClassification.ClassificationName].ToString().Trim(); //分类名称
objgs_VpClassificationEN.OrderNum = objRow[congs_VpClassification.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_VpClassification.OrderNum].ToString().Trim()); //序号
objgs_VpClassificationEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[congs_VpClassification.InUse].ToString().Trim()); //是否在用
objgs_VpClassificationEN.UpdDate = objRow[congs_VpClassification.UpdDate] == DBNull.Value ? null : objRow[congs_VpClassification.UpdDate].ToString().Trim(); //修改日期
objgs_VpClassificationEN.UpdUser = objRow[congs_VpClassification.UpdUser] == DBNull.Value ? null : objRow[congs_VpClassification.UpdUser].ToString().Trim(); //修改人
objgs_VpClassificationEN.Memo = objRow[congs_VpClassification.Memo] == DBNull.Value ? null : objRow[congs_VpClassification.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_VpClassificationEN.ClassificationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_VpClassificationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_VpClassificationEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsgs_VpClassificationEN> arrObjLst = new List<clsgs_VpClassificationEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_VpClassificationEN objgs_VpClassificationEN = new clsgs_VpClassificationEN();
try
{
objgs_VpClassificationEN.ClassificationId = Int32.Parse(objRow[congs_VpClassification.ClassificationId].ToString().Trim()); //分类Id
objgs_VpClassificationEN.ClassificationName = objRow[congs_VpClassification.ClassificationName].ToString().Trim(); //分类名称
objgs_VpClassificationEN.OrderNum = objRow[congs_VpClassification.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_VpClassification.OrderNum].ToString().Trim()); //序号
objgs_VpClassificationEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[congs_VpClassification.InUse].ToString().Trim()); //是否在用
objgs_VpClassificationEN.UpdDate = objRow[congs_VpClassification.UpdDate] == DBNull.Value ? null : objRow[congs_VpClassification.UpdDate].ToString().Trim(); //修改日期
objgs_VpClassificationEN.UpdUser = objRow[congs_VpClassification.UpdUser] == DBNull.Value ? null : objRow[congs_VpClassification.UpdUser].ToString().Trim(); //修改人
objgs_VpClassificationEN.Memo = objRow[congs_VpClassification.Memo] == DBNull.Value ? null : objRow[congs_VpClassification.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_VpClassificationEN.ClassificationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_VpClassificationEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objgs_VpClassificationEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getgs_VpClassification(ref clsgs_VpClassificationEN objgs_VpClassificationEN)
{
bool bolResult = gs_VpClassificationDA.Getgs_VpClassification(ref objgs_VpClassificationEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngClassificationId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_VpClassificationEN GetObjByClassificationId(long lngClassificationId)
{
clsgs_VpClassificationEN objgs_VpClassificationEN = gs_VpClassificationDA.GetObjByClassificationId(lngClassificationId);
return objgs_VpClassificationEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsgs_VpClassificationEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsgs_VpClassificationEN objgs_VpClassificationEN = gs_VpClassificationDA.GetFirstObj(strWhereCond);
 return objgs_VpClassificationEN;
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
public static clsgs_VpClassificationEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsgs_VpClassificationEN objgs_VpClassificationEN = gs_VpClassificationDA.GetObjByDataRow(objRow);
 return objgs_VpClassificationEN;
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
public static clsgs_VpClassificationEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsgs_VpClassificationEN objgs_VpClassificationEN = gs_VpClassificationDA.GetObjByDataRow(objRow);
 return objgs_VpClassificationEN;
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
 /// <param name = "lngClassificationId">所给的关键字</param>
 /// <param name = "lstgs_VpClassificationObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_VpClassificationEN GetObjByClassificationIdFromList(long lngClassificationId, List<clsgs_VpClassificationEN> lstgs_VpClassificationObjLst)
{
foreach (clsgs_VpClassificationEN objgs_VpClassificationEN in lstgs_VpClassificationObjLst)
{
if (objgs_VpClassificationEN.ClassificationId == lngClassificationId)
{
return objgs_VpClassificationEN;
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
 long lngClassificationId;
 try
 {
 lngClassificationId = new clsgs_VpClassificationDA().GetFirstID(strWhereCond);
 return lngClassificationId;
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
 arrList = gs_VpClassificationDA.GetID(strWhereCond);
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
bool bolIsExist = gs_VpClassificationDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngClassificationId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngClassificationId)
{
//检测记录是否存在
bool bolIsExist = gs_VpClassificationDA.IsExist(lngClassificationId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngClassificationId">分类Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngClassificationId, string strOpUser)
{
clsgs_VpClassificationEN objgs_VpClassificationEN = clsgs_VpClassificationBL.GetObjByClassificationId(lngClassificationId);
objgs_VpClassificationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objgs_VpClassificationEN.UpdUser = strOpUser;
return clsgs_VpClassificationBL.UpdateBySql2(objgs_VpClassificationEN);
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
 bolIsExist = clsgs_VpClassificationDA.IsExistTable();
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
 bolIsExist = gs_VpClassificationDA.IsExistTable(strTabName);
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
 /// <param name = "objgs_VpClassificationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsgs_VpClassificationEN objgs_VpClassificationEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objgs_VpClassificationEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!分类名称 = [{0}]的数据已经存在!(in clsgs_VpClassificationBL.AddNewRecordBySql2)", objgs_VpClassificationEN.ClassificationName);
throw new Exception(strMsg);
}
try
{
bool bolResult = gs_VpClassificationDA.AddNewRecordBySQL2(objgs_VpClassificationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_VpClassificationBL.ReFreshCache();

if (clsgs_VpClassificationBL.relatedActions != null)
{
clsgs_VpClassificationBL.relatedActions.UpdRelaTabDate(objgs_VpClassificationEN.ClassificationId, objgs_VpClassificationEN.UpdUser);
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
 /// <param name = "objgs_VpClassificationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsgs_VpClassificationEN objgs_VpClassificationEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objgs_VpClassificationEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!分类名称 = [{0}]的数据已经存在!(in clsgs_VpClassificationBL.AddNewRecordBySql2WithReturnKey)", objgs_VpClassificationEN.ClassificationName);
throw new Exception(strMsg);
}
try
{
string strKey = gs_VpClassificationDA.AddNewRecordBySQL2WithReturnKey(objgs_VpClassificationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_VpClassificationBL.ReFreshCache();

if (clsgs_VpClassificationBL.relatedActions != null)
{
clsgs_VpClassificationBL.relatedActions.UpdRelaTabDate(objgs_VpClassificationEN.ClassificationId, objgs_VpClassificationEN.UpdUser);
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
 /// <param name = "objgs_VpClassificationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsgs_VpClassificationEN objgs_VpClassificationEN)
{
try
{
bool bolResult = gs_VpClassificationDA.Update(objgs_VpClassificationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_VpClassificationBL.ReFreshCache();

if (clsgs_VpClassificationBL.relatedActions != null)
{
clsgs_VpClassificationBL.relatedActions.UpdRelaTabDate(objgs_VpClassificationEN.ClassificationId, objgs_VpClassificationEN.UpdUser);
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
 /// <param name = "objgs_VpClassificationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsgs_VpClassificationEN objgs_VpClassificationEN)
{
 if (objgs_VpClassificationEN.ClassificationId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = gs_VpClassificationDA.UpdateBySql2(objgs_VpClassificationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_VpClassificationBL.ReFreshCache();

if (clsgs_VpClassificationBL.relatedActions != null)
{
clsgs_VpClassificationBL.relatedActions.UpdRelaTabDate(objgs_VpClassificationEN.ClassificationId, objgs_VpClassificationEN.UpdUser);
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
 /// <param name = "lngClassificationId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngClassificationId)
{
try
{
 clsgs_VpClassificationEN objgs_VpClassificationEN = clsgs_VpClassificationBL.GetObjByClassificationId(lngClassificationId);

if (clsgs_VpClassificationBL.relatedActions != null)
{
clsgs_VpClassificationBL.relatedActions.UpdRelaTabDate(objgs_VpClassificationEN.ClassificationId, objgs_VpClassificationEN.UpdUser);
}
if (objgs_VpClassificationEN != null)
{
int intRecNum = gs_VpClassificationDA.DelRecord(lngClassificationId);
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
/// <param name="lngClassificationId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngClassificationId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsgs_VpClassificationDA.GetSpecSQLObj();
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
//删除与表:[gs_VpClassification]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//congs_VpClassification.ClassificationId,
//lngClassificationId);
//        clsgs_VpClassificationBL.Delgs_VpClassificationsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsgs_VpClassificationBL.DelRecord(lngClassificationId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsgs_VpClassificationBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngClassificationId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngClassificationId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngClassificationId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsgs_VpClassificationBL.relatedActions != null)
{
clsgs_VpClassificationBL.relatedActions.UpdRelaTabDate(lngClassificationId, "UpdRelaTabDate");
}
bool bolResult = gs_VpClassificationDA.DelRecord(lngClassificationId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrClassificationIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delgs_VpClassifications(List<string> arrClassificationIdLst)
{
if (arrClassificationIdLst.Count == 0) return 0;
try
{
if (clsgs_VpClassificationBL.relatedActions != null)
{
foreach (var strClassificationId in arrClassificationIdLst)
{
long lngClassificationId = long.Parse(strClassificationId);
clsgs_VpClassificationBL.relatedActions.UpdRelaTabDate(lngClassificationId, "UpdRelaTabDate");
}
}
int intDelRecNum = gs_VpClassificationDA.Delgs_VpClassification(arrClassificationIdLst);
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
public static int Delgs_VpClassificationsByCond(string strWhereCond)
{
try
{
if (clsgs_VpClassificationBL.relatedActions != null)
{
List<string> arrClassificationId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strClassificationId in arrClassificationId)
{
long lngClassificationId = long.Parse(strClassificationId);
clsgs_VpClassificationBL.relatedActions.UpdRelaTabDate(lngClassificationId, "UpdRelaTabDate");
}
}
int intRecNum = gs_VpClassificationDA.Delgs_VpClassification(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[gs_VpClassification]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngClassificationId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngClassificationId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsgs_VpClassificationDA.GetSpecSQLObj();
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
//删除与表:[gs_VpClassification]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsgs_VpClassificationBL.DelRecord(lngClassificationId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsgs_VpClassificationBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngClassificationId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objgs_VpClassificationENS">源对象</param>
 /// <param name = "objgs_VpClassificationENT">目标对象</param>
 public static void CopyTo(clsgs_VpClassificationEN objgs_VpClassificationENS, clsgs_VpClassificationEN objgs_VpClassificationENT)
{
try
{
objgs_VpClassificationENT.ClassificationId = objgs_VpClassificationENS.ClassificationId; //分类Id
objgs_VpClassificationENT.ClassificationName = objgs_VpClassificationENS.ClassificationName; //分类名称
objgs_VpClassificationENT.OrderNum = objgs_VpClassificationENS.OrderNum; //序号
objgs_VpClassificationENT.InUse = objgs_VpClassificationENS.InUse; //是否在用
objgs_VpClassificationENT.UpdDate = objgs_VpClassificationENS.UpdDate; //修改日期
objgs_VpClassificationENT.UpdUser = objgs_VpClassificationENS.UpdUser; //修改人
objgs_VpClassificationENT.Memo = objgs_VpClassificationENS.Memo; //备注
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
 /// <param name = "objgs_VpClassificationEN">源简化对象</param>
 public static void SetUpdFlag(clsgs_VpClassificationEN objgs_VpClassificationEN)
{
try
{
objgs_VpClassificationEN.ClearUpdateState();
   string strsfUpdFldSetStr = objgs_VpClassificationEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(congs_VpClassification.ClassificationId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_VpClassificationEN.ClassificationId = objgs_VpClassificationEN.ClassificationId; //分类Id
}
if (arrFldSet.Contains(congs_VpClassification.ClassificationName, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_VpClassificationEN.ClassificationName = objgs_VpClassificationEN.ClassificationName; //分类名称
}
if (arrFldSet.Contains(congs_VpClassification.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_VpClassificationEN.OrderNum = objgs_VpClassificationEN.OrderNum; //序号
}
if (arrFldSet.Contains(congs_VpClassification.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_VpClassificationEN.InUse = objgs_VpClassificationEN.InUse; //是否在用
}
if (arrFldSet.Contains(congs_VpClassification.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_VpClassificationEN.UpdDate = objgs_VpClassificationEN.UpdDate == "[null]" ? null :  objgs_VpClassificationEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(congs_VpClassification.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_VpClassificationEN.UpdUser = objgs_VpClassificationEN.UpdUser == "[null]" ? null :  objgs_VpClassificationEN.UpdUser; //修改人
}
if (arrFldSet.Contains(congs_VpClassification.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_VpClassificationEN.Memo = objgs_VpClassificationEN.Memo == "[null]" ? null :  objgs_VpClassificationEN.Memo; //备注
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
 /// <param name = "objgs_VpClassificationEN">源简化对象</param>
 public static void AccessFldValueNull(clsgs_VpClassificationEN objgs_VpClassificationEN)
{
try
{
if (objgs_VpClassificationEN.UpdDate == "[null]") objgs_VpClassificationEN.UpdDate = null; //修改日期
if (objgs_VpClassificationEN.UpdUser == "[null]") objgs_VpClassificationEN.UpdUser = null; //修改人
if (objgs_VpClassificationEN.Memo == "[null]") objgs_VpClassificationEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsgs_VpClassificationEN objgs_VpClassificationEN)
{
 gs_VpClassificationDA.CheckPropertyNew(objgs_VpClassificationEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsgs_VpClassificationEN objgs_VpClassificationEN)
{
 gs_VpClassificationDA.CheckProperty4Condition(objgs_VpClassificationEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_ClassificationIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[各观点分类表]...","0");
List<clsgs_VpClassificationEN> arrgs_VpClassificationObjLst = GetAllgs_VpClassificationObjLstCache(); 
arrgs_VpClassificationObjLst = arrgs_VpClassificationObjLst.OrderBy(x=>x.OrderNum).ToList(); 
objDDL.DataValueField = congs_VpClassification.ClassificationId;
objDDL.DataTextField = congs_VpClassification.ClassificationName;
objDDL.DataSource = arrgs_VpClassificationObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}


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
if (clsgs_VpClassificationBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_VpClassificationBL没有刷新缓存机制(clsgs_VpClassificationBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ClassificationId");
//if (arrgs_VpClassificationObjLstCache == null)
//{
//arrgs_VpClassificationObjLstCache = gs_VpClassificationDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngClassificationId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_VpClassificationEN GetObjByClassificationIdCache(long lngClassificationId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsgs_VpClassificationEN._CurrTabName);
List<clsgs_VpClassificationEN> arrgs_VpClassificationObjLstCache = GetObjLstCache();
IEnumerable <clsgs_VpClassificationEN> arrgs_VpClassificationObjLst_Sel =
arrgs_VpClassificationObjLstCache
.Where(x=> x.ClassificationId == lngClassificationId 
);
if (arrgs_VpClassificationObjLst_Sel.Count() == 0)
{
   clsgs_VpClassificationEN obj = clsgs_VpClassificationBL.GetObjByClassificationId(lngClassificationId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrgs_VpClassificationObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "lngClassificationId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetClassificationNameByClassificationIdCache(long lngClassificationId)
{
//获取缓存中的对象列表
clsgs_VpClassificationEN objgs_VpClassification = GetObjByClassificationIdCache(lngClassificationId);
if (objgs_VpClassification == null) return "";
return objgs_VpClassification.ClassificationName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "lngClassificationId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByClassificationIdCache(long lngClassificationId)
{
//获取缓存中的对象列表
clsgs_VpClassificationEN objgs_VpClassification = GetObjByClassificationIdCache(lngClassificationId);
if (objgs_VpClassification == null) return "";
return objgs_VpClassification.ClassificationName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_VpClassificationEN> GetAllgs_VpClassificationObjLstCache()
{
//获取缓存中的对象列表
List<clsgs_VpClassificationEN> arrgs_VpClassificationObjLstCache = GetObjLstCache(); 
return arrgs_VpClassificationObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_VpClassificationEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsgs_VpClassificationEN._CurrTabName);
List<clsgs_VpClassificationEN> arrgs_VpClassificationObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrgs_VpClassificationObjLstCache;
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
string strKey = string.Format("{0}", clsgs_VpClassificationEN._CurrTabName);
CacheHelper.Remove(strKey);
clsgs_VpClassificationEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsgs_VpClassificationEN._RefreshTimeLst.Count == 0) return "";
return clsgs_VpClassificationEN._RefreshTimeLst[clsgs_VpClassificationEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsgs_VpClassificationBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsgs_VpClassificationEN._CurrTabName);
CacheHelper.Remove(strKey);
clsgs_VpClassificationEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsgs_VpClassificationBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--gs_VpClassification(各观点分类表)
 /// 唯一性条件:ClassificationName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objgs_VpClassificationEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsgs_VpClassificationEN objgs_VpClassificationEN)
{
//检测记录是否存在
string strResult = gs_VpClassificationDA.GetUniCondStr(objgs_VpClassificationEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngClassificationId)
{
if (strInFldName != congs_VpClassification.ClassificationId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (congs_VpClassification.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", congs_VpClassification.AttributeName));
throw new Exception(strMsg);
}
var objgs_VpClassification = clsgs_VpClassificationBL.GetObjByClassificationIdCache(lngClassificationId);
if (objgs_VpClassification == null) return "";
return objgs_VpClassification[strOutFldName].ToString();
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
int intRecCount = clsgs_VpClassificationDA.GetRecCount(strTabName);
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
int intRecCount = clsgs_VpClassificationDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsgs_VpClassificationDA.GetRecCount();
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
int intRecCount = clsgs_VpClassificationDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objgs_VpClassificationCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsgs_VpClassificationEN objgs_VpClassificationCond)
{
List<clsgs_VpClassificationEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsgs_VpClassificationEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in congs_VpClassification.AttributeName)
{
if (objgs_VpClassificationCond.IsUpdated(strFldName) == false) continue;
if (objgs_VpClassificationCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_VpClassificationCond[strFldName].ToString());
}
else
{
if (objgs_VpClassificationCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objgs_VpClassificationCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_VpClassificationCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objgs_VpClassificationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objgs_VpClassificationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objgs_VpClassificationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objgs_VpClassificationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objgs_VpClassificationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objgs_VpClassificationCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objgs_VpClassificationCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objgs_VpClassificationCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objgs_VpClassificationCond[strFldName]));
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
 List<string> arrList = clsgs_VpClassificationDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = gs_VpClassificationDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = gs_VpClassificationDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = gs_VpClassificationDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsgs_VpClassificationDA.SetFldValue(clsgs_VpClassificationEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = gs_VpClassificationDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsgs_VpClassificationDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsgs_VpClassificationDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsgs_VpClassificationDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[gs_VpClassification] "); 
 strCreateTabCode.Append(" ( "); 
 // /**分类Id*/ 
 strCreateTabCode.Append(" ClassificationId bigint primary key identity, "); 
 // /**分类名称*/ 
 strCreateTabCode.Append(" ClassificationName varchar(200) not Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**是否在用*/ 
 strCreateTabCode.Append(" InUse bit Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**研究主题s*/ 
 strCreateTabCode.Append(" TopicNames varchar(1000) Null, "); 
 // /**简化日期时间*/ 
 strCreateTabCode.Append(" DateTimeSim varchar(20) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 排序相关函数

/// <summary>
/// 重新排序。根据分类字段：单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ReOrder)
/// </summary>
/// <returns></returns>
public static bool ReOrder( )
{
try
{
string strCondition = " 1=1 ";
 strCondition += string.Format(" order by OrderNum ");
List<clsgs_VpClassificationEN> arrgs_VpClassificationObjList = new clsgs_VpClassificationDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsgs_VpClassificationEN objgs_VpClassification in arrgs_VpClassificationObjList)
{
objgs_VpClassification.OrderNum = intIndex;
UpdateBySql2(objgs_VpClassification);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("重序出错, {0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 调整所给关键字记录的序号。根据分类字段：单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_AdjustOrderNum)
/// </summary>
/// <param name="strDirect">方向：用"Up","Down"表示</param>
/// <param name="lngClassificationId">所给的关键字</param>
/// <returns>是否成功?</returns>
public static bool AdjustOrderNum(string strDirect, long lngClassificationId  )
{
try
{
//操作步骤：
//1、根据所给定的关键字[ClassificationId],获取相应的序号[OrderNum]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//   3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字ClassificationId
//5、把当前关键字ClassificationId所对应记录的序号加(减)1
//6、把下(上)一个序号关键字ClassificationId所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
long lngPrevClassificationId = 0;    //上一条序号的关键字ClassificationId
long lngNextClassificationId = 0;    //下一条序号的关键字ClassificationId
int intTabRecNum;       //当前表中字段的记录数
StringBuilder sbCondition = new StringBuilder();
//1、根据所给定的关键字[ClassificationId],获取相应的序号[OrderNum]。

clsgs_VpClassificationEN objgs_VpClassification = clsgs_VpClassificationBL.GetObjByClassificationId(lngClassificationId);

intOrderNum = objgs_VpClassification.OrderNum ?? 0;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

string strCondition = " 1=1 ";
intTabRecNum = clsgs_VpClassificationBL.GetRecCountByCond(clsgs_VpClassificationEN._CurrTabName, strCondition);    //获取当前表的记录数
switch (strDirect)
{
case "UP":
case "Up":
case "up":
//3、如果是末端序号,就退出；
//  3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	     即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
if (intOrderNum <= 1)
{
strMsg = string.Format("已经是第一条记录,不能再上移.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//		3.2 如果不是,即如果是向下移动,就判断当前序号是否“小于”当前表中的字段数,
//		    即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//		    如果是向上移动,就判断当前序号是否“大于”1,
//		    即不是最开始一个记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
sbCondition.AppendFormat(" {0} = {1} ", congs_VpClassification.OrderNum, intOrderNum - 1);
//4、获取上一个序号字段的关键字ClassificationId
lngPrevClassificationId = clsgs_VpClassificationBL.GetFirstID_S(sbCondition.ToString());
if (lngPrevClassificationId == 0)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字ClassificationId所对应记录的序号减1
//6、把下(上)一个序号关键字ClassificationId所对应的记录序号加1
clsgs_VpClassificationBL.SetFldValue(clsgs_VpClassificationEN._CurrTabName, congs_VpClassification.OrderNum,
 	 	intOrderNum - 1,
  	 	string.Format("{0} = '{1}'", congs_VpClassification.ClassificationId, lngClassificationId));
clsgs_VpClassificationBL.SetFldValue(clsgs_VpClassificationEN._CurrTabName, congs_VpClassification.OrderNum,
 	 	intPrevOrderNum + 1,
 	 	string.Format("{0} = '{1}'", congs_VpClassification.ClassificationId, lngPrevClassificationId));
break;
case "DOWN":
case "Down":
case "down":
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
if (intOrderNum >= intTabRecNum)    //如果当前序号大于表记录数
{
strMsg = string.Format("已经是最后一条记录,不能再下移.(from {0})", clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
}

//4、获取下一个序号字段的关键字ClassificationId
sbCondition.AppendFormat(" {0} = {1} ", congs_VpClassification.OrderNum, intOrderNum + 1);

lngNextClassificationId = clsgs_VpClassificationBL.GetFirstID_S(sbCondition.ToString());
if (lngNextClassificationId == 0)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字ClassificationId所对应记录的序号加1
//6、把下(上)一个序号关键字ClassificationId所对应的记录序号减1
clsgs_VpClassificationBL.SetFldValue(clsgs_VpClassificationEN._CurrTabName, congs_VpClassification.OrderNum,
 	 	intOrderNum + 1,
 	 	string.Format("{0} = '{1}'", congs_VpClassification.ClassificationId, lngClassificationId));
clsgs_VpClassificationBL.SetFldValue(clsgs_VpClassificationEN._CurrTabName, congs_VpClassification.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", congs_VpClassification.ClassificationId, lngNextClassificationId));
break;
default:
strMsg = string.Format("方向参数出错!strDirect=[{0}]({1})",
 	 	strDirect,
 	 	clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
return true;
}
catch (Exception objException)
{
string strMsg = string.Format("调整记录次序出错!错误:[{0}]({1})",
 	 	objException.Message,
 	 	clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoBottom)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoBottom(List<long> arrKeyId  )
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId);
string strCondition = string.Format("{0} in ({1})", congs_VpClassification.ClassificationId, strKeyList);
List<clsgs_VpClassificationEN> arrgs_VpClassificationLst = GetObjLst(strCondition);
foreach (clsgs_VpClassificationEN objgs_VpClassification in arrgs_VpClassificationLst)
{
objgs_VpClassification.OrderNum = objgs_VpClassification.OrderNum + 10000;
UpdateBySql2(objgs_VpClassification);
}
strCondition = " 1=1 ";
 strCondition += string.Format(" order by OrderNum ");
List<clsgs_VpClassificationEN> arrgs_VpClassificationObjList = new clsgs_VpClassificationDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsgs_VpClassificationEN objgs_VpClassification in arrgs_VpClassificationObjList)
{
objgs_VpClassification.OrderNum = intIndex;
UpdateBySql2(objgs_VpClassification);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错, {0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoTop)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoTop(List<long> arrKeyId  )
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId);
string strCondition = string.Format("{0} in ({1})", congs_VpClassification.ClassificationId, strKeyList);
List<clsgs_VpClassificationEN> arrgs_VpClassificationLst = GetObjLst(strCondition);
foreach (clsgs_VpClassificationEN objgs_VpClassification in arrgs_VpClassificationLst)
{
objgs_VpClassification.OrderNum = objgs_VpClassification.OrderNum - 10000;
UpdateBySql2(objgs_VpClassification);
}
strCondition = " 1=1 ";
 strCondition += string.Format(" order by OrderNum ");
List<clsgs_VpClassificationEN> arrgs_VpClassificationObjList = new clsgs_VpClassificationDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsgs_VpClassificationEN objgs_VpClassification in arrgs_VpClassificationObjList)
{
objgs_VpClassification.OrderNum = intIndex;
UpdateBySql2(objgs_VpClassification);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错,{0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}


 #endregion 排序相关函数
}
 /// <summary>
 /// 各观点分类表(gs_VpClassification)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4gs_VpClassification : clsCommFun4BL
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
clsgs_VpClassificationBL.ReFreshThisCache();
}
}

}