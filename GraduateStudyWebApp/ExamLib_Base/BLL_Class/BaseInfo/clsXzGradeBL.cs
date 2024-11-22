
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsXzGradeBL
 表名:XzGrade(01120349)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 05:59:24
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:基本信息维护(BaseInfo)
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
public static class  clsXzGradeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdGrade">表关键字</param>
 /// <returns>表对象</returns>
public static clsXzGradeEN GetObj(this K_IdGrade_XzGrade myKey)
{
clsXzGradeEN objXzGradeEN = clsXzGradeBL.XzGradeDA.GetObjByIdGrade(myKey.Value);
return objXzGradeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objXzGradeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsXzGradeEN objXzGradeEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objXzGradeEN.IdGrade) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsXzGradeBL.IsExist(objXzGradeEN.IdGrade) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objXzGradeEN.IdGrade, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsXzGradeBL.XzGradeDA.AddNewRecordBySQL2(objXzGradeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzGradeBL.ReFreshCache();

if (clsXzGradeBL.relatedActions != null)
{
clsXzGradeBL.relatedActions.UpdRelaTabDate(objXzGradeEN.IdGrade, "SetUpdDate");
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
public static bool AddRecordEx(this clsXzGradeEN objXzGradeEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsXzGradeBL.IsExist(objXzGradeEN.IdGrade))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objXzGradeEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objXzGradeEN.AddNewRecord();
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
 /// <param name = "objXzGradeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsXzGradeEN objXzGradeEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objXzGradeEN.IdGrade) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsXzGradeBL.IsExist(objXzGradeEN.IdGrade) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objXzGradeEN.IdGrade, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsXzGradeBL.XzGradeDA.AddNewRecordBySQL2WithReturnKey(objXzGradeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzGradeBL.ReFreshCache();

if (clsXzGradeBL.relatedActions != null)
{
clsXzGradeBL.relatedActions.UpdRelaTabDate(objXzGradeEN.IdGrade, "SetUpdDate");
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
 /// <param name = "objXzGradeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzGradeEN SetIdGrade(this clsXzGradeEN objXzGradeEN, string strIdGrade, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdGrade, 4, conXzGrade.IdGrade);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdGrade, 4, conXzGrade.IdGrade);
}
objXzGradeEN.IdGrade = strIdGrade; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzGradeEN.dicFldComparisonOp.ContainsKey(conXzGrade.IdGrade) == false)
{
objXzGradeEN.dicFldComparisonOp.Add(conXzGrade.IdGrade, strComparisonOp);
}
else
{
objXzGradeEN.dicFldComparisonOp[conXzGrade.IdGrade] = strComparisonOp;
}
}
return objXzGradeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzGradeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzGradeEN SetGradeName(this clsXzGradeEN objXzGradeEN, string strGradeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGradeName, conXzGrade.GradeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGradeName, 50, conXzGrade.GradeName);
}
objXzGradeEN.GradeName = strGradeName; //年级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzGradeEN.dicFldComparisonOp.ContainsKey(conXzGrade.GradeName) == false)
{
objXzGradeEN.dicFldComparisonOp.Add(conXzGrade.GradeName, strComparisonOp);
}
else
{
objXzGradeEN.dicFldComparisonOp[conXzGrade.GradeName] = strComparisonOp;
}
}
return objXzGradeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzGradeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzGradeEN SetIdStudyLevel(this clsXzGradeEN objXzGradeEN, string strIdStudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdStudyLevel, conXzGrade.IdStudyLevel);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudyLevel, 4, conXzGrade.IdStudyLevel);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudyLevel, 4, conXzGrade.IdStudyLevel);
}
objXzGradeEN.IdStudyLevel = strIdStudyLevel; //学段流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzGradeEN.dicFldComparisonOp.ContainsKey(conXzGrade.IdStudyLevel) == false)
{
objXzGradeEN.dicFldComparisonOp.Add(conXzGrade.IdStudyLevel, strComparisonOp);
}
else
{
objXzGradeEN.dicFldComparisonOp[conXzGrade.IdStudyLevel] = strComparisonOp;
}
}
return objXzGradeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzGradeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzGradeEN SetGradeLeaderId(this clsXzGradeEN objXzGradeEN, string strGradeLeaderId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGradeLeaderId, 8, conXzGrade.GradeLeaderId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGradeLeaderId, 8, conXzGrade.GradeLeaderId);
}
objXzGradeEN.GradeLeaderId = strGradeLeaderId; //年级组长Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzGradeEN.dicFldComparisonOp.ContainsKey(conXzGrade.GradeLeaderId) == false)
{
objXzGradeEN.dicFldComparisonOp.Add(conXzGrade.GradeLeaderId, strComparisonOp);
}
else
{
objXzGradeEN.dicFldComparisonOp[conXzGrade.GradeLeaderId] = strComparisonOp;
}
}
return objXzGradeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzGradeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzGradeEN SetGradeIndex(this clsXzGradeEN objXzGradeEN, int? intGradeIndex, string strComparisonOp="")
	{
objXzGradeEN.GradeIndex = intGradeIndex; //年级序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzGradeEN.dicFldComparisonOp.ContainsKey(conXzGrade.GradeIndex) == false)
{
objXzGradeEN.dicFldComparisonOp.Add(conXzGrade.GradeIndex, strComparisonOp);
}
else
{
objXzGradeEN.dicFldComparisonOp[conXzGrade.GradeIndex] = strComparisonOp;
}
}
return objXzGradeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzGradeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzGradeEN SetModifyUserId(this clsXzGradeEN objXzGradeEN, string strModifyUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModifyUserId, 18, conXzGrade.ModifyUserId);
}
objXzGradeEN.ModifyUserId = strModifyUserId; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzGradeEN.dicFldComparisonOp.ContainsKey(conXzGrade.ModifyUserId) == false)
{
objXzGradeEN.dicFldComparisonOp.Add(conXzGrade.ModifyUserId, strComparisonOp);
}
else
{
objXzGradeEN.dicFldComparisonOp[conXzGrade.ModifyUserId] = strComparisonOp;
}
}
return objXzGradeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzGradeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzGradeEN SetModifyDate(this clsXzGradeEN objXzGradeEN, string strModifyDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModifyDate, 20, conXzGrade.ModifyDate);
}
objXzGradeEN.ModifyDate = strModifyDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzGradeEN.dicFldComparisonOp.ContainsKey(conXzGrade.ModifyDate) == false)
{
objXzGradeEN.dicFldComparisonOp.Add(conXzGrade.ModifyDate, strComparisonOp);
}
else
{
objXzGradeEN.dicFldComparisonOp[conXzGrade.ModifyDate] = strComparisonOp;
}
}
return objXzGradeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzGradeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzGradeEN SetMemo(this clsXzGradeEN objXzGradeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conXzGrade.Memo);
}
objXzGradeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzGradeEN.dicFldComparisonOp.ContainsKey(conXzGrade.Memo) == false)
{
objXzGradeEN.dicFldComparisonOp.Add(conXzGrade.Memo, strComparisonOp);
}
else
{
objXzGradeEN.dicFldComparisonOp[conXzGrade.Memo] = strComparisonOp;
}
}
return objXzGradeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objXzGradeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsXzGradeEN objXzGradeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objXzGradeEN.CheckPropertyNew();
clsXzGradeEN objXzGradeCond = new clsXzGradeEN();
string strCondition = objXzGradeCond
.SetIdGrade(objXzGradeEN.IdGrade, "=")
.GetCombineCondition();
objXzGradeEN._IsCheckProperty = true;
bool bolIsExist = clsXzGradeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objXzGradeEN.Update();
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
 /// <param name = "objXzGradeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsXzGradeEN objXzGradeEN)
{
 if (string.IsNullOrEmpty(objXzGradeEN.IdGrade) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsXzGradeBL.XzGradeDA.UpdateBySql2(objXzGradeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzGradeBL.ReFreshCache();

if (clsXzGradeBL.relatedActions != null)
{
clsXzGradeBL.relatedActions.UpdRelaTabDate(objXzGradeEN.IdGrade, "SetUpdDate");
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
 /// <param name = "objXzGradeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsXzGradeEN objXzGradeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objXzGradeEN.IdGrade) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsXzGradeBL.XzGradeDA.UpdateBySql2(objXzGradeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzGradeBL.ReFreshCache();

if (clsXzGradeBL.relatedActions != null)
{
clsXzGradeBL.relatedActions.UpdRelaTabDate(objXzGradeEN.IdGrade, "SetUpdDate");
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
 /// <param name = "objXzGradeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsXzGradeEN objXzGradeEN, string strWhereCond)
{
try
{
bool bolResult = clsXzGradeBL.XzGradeDA.UpdateBySqlWithCondition(objXzGradeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzGradeBL.ReFreshCache();

if (clsXzGradeBL.relatedActions != null)
{
clsXzGradeBL.relatedActions.UpdRelaTabDate(objXzGradeEN.IdGrade, "SetUpdDate");
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
 /// <param name = "objXzGradeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsXzGradeEN objXzGradeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsXzGradeBL.XzGradeDA.UpdateBySqlWithConditionTransaction(objXzGradeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzGradeBL.ReFreshCache();

if (clsXzGradeBL.relatedActions != null)
{
clsXzGradeBL.relatedActions.UpdRelaTabDate(objXzGradeEN.IdGrade, "SetUpdDate");
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
 /// <param name = "strIdGrade">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsXzGradeEN objXzGradeEN)
{
try
{
int intRecNum = clsXzGradeBL.XzGradeDA.DelRecord(objXzGradeEN.IdGrade);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzGradeBL.ReFreshCache();

if (clsXzGradeBL.relatedActions != null)
{
clsXzGradeBL.relatedActions.UpdRelaTabDate(objXzGradeEN.IdGrade, "SetUpdDate");
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
 /// <param name = "objXzGradeENS">源对象</param>
 /// <param name = "objXzGradeENT">目标对象</param>
 public static void CopyTo(this clsXzGradeEN objXzGradeENS, clsXzGradeEN objXzGradeENT)
{
try
{
objXzGradeENT.IdGrade = objXzGradeENS.IdGrade; //年级流水号
objXzGradeENT.GradeName = objXzGradeENS.GradeName; //年级名称
objXzGradeENT.IdStudyLevel = objXzGradeENS.IdStudyLevel; //学段流水号
objXzGradeENT.GradeLeaderId = objXzGradeENS.GradeLeaderId; //年级组长Id
objXzGradeENT.GradeIndex = objXzGradeENS.GradeIndex; //年级序号
objXzGradeENT.ModifyUserId = objXzGradeENS.ModifyUserId; //修改人
objXzGradeENT.ModifyDate = objXzGradeENS.ModifyDate; //修改日期
objXzGradeENT.Memo = objXzGradeENS.Memo; //备注
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
 /// <param name = "objXzGradeENS">源对象</param>
 /// <returns>目标对象=>clsXzGradeEN:objXzGradeENT</returns>
 public static clsXzGradeEN CopyTo(this clsXzGradeEN objXzGradeENS)
{
try
{
 clsXzGradeEN objXzGradeENT = new clsXzGradeEN()
{
IdGrade = objXzGradeENS.IdGrade, //年级流水号
GradeName = objXzGradeENS.GradeName, //年级名称
IdStudyLevel = objXzGradeENS.IdStudyLevel, //学段流水号
GradeLeaderId = objXzGradeENS.GradeLeaderId, //年级组长Id
GradeIndex = objXzGradeENS.GradeIndex, //年级序号
ModifyUserId = objXzGradeENS.ModifyUserId, //修改人
ModifyDate = objXzGradeENS.ModifyDate, //修改日期
Memo = objXzGradeENS.Memo, //备注
};
 return objXzGradeENT;
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
public static void CheckPropertyNew(this clsXzGradeEN objXzGradeEN)
{
 clsXzGradeBL.XzGradeDA.CheckPropertyNew(objXzGradeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsXzGradeEN objXzGradeEN)
{
 clsXzGradeBL.XzGradeDA.CheckProperty4Condition(objXzGradeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsXzGradeEN objXzGradeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objXzGradeCond.IsUpdated(conXzGrade.IdGrade) == true)
{
string strComparisonOpIdGrade = objXzGradeCond.dicFldComparisonOp[conXzGrade.IdGrade];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzGrade.IdGrade, objXzGradeCond.IdGrade, strComparisonOpIdGrade);
}
if (objXzGradeCond.IsUpdated(conXzGrade.GradeName) == true)
{
string strComparisonOpGradeName = objXzGradeCond.dicFldComparisonOp[conXzGrade.GradeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzGrade.GradeName, objXzGradeCond.GradeName, strComparisonOpGradeName);
}
if (objXzGradeCond.IsUpdated(conXzGrade.IdStudyLevel) == true)
{
string strComparisonOpIdStudyLevel = objXzGradeCond.dicFldComparisonOp[conXzGrade.IdStudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzGrade.IdStudyLevel, objXzGradeCond.IdStudyLevel, strComparisonOpIdStudyLevel);
}
if (objXzGradeCond.IsUpdated(conXzGrade.GradeLeaderId) == true)
{
string strComparisonOpGradeLeaderId = objXzGradeCond.dicFldComparisonOp[conXzGrade.GradeLeaderId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzGrade.GradeLeaderId, objXzGradeCond.GradeLeaderId, strComparisonOpGradeLeaderId);
}
if (objXzGradeCond.IsUpdated(conXzGrade.GradeIndex) == true)
{
string strComparisonOpGradeIndex = objXzGradeCond.dicFldComparisonOp[conXzGrade.GradeIndex];
strWhereCond += string.Format(" And {0} {2} {1}", conXzGrade.GradeIndex, objXzGradeCond.GradeIndex, strComparisonOpGradeIndex);
}
if (objXzGradeCond.IsUpdated(conXzGrade.ModifyUserId) == true)
{
string strComparisonOpModifyUserId = objXzGradeCond.dicFldComparisonOp[conXzGrade.ModifyUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzGrade.ModifyUserId, objXzGradeCond.ModifyUserId, strComparisonOpModifyUserId);
}
if (objXzGradeCond.IsUpdated(conXzGrade.ModifyDate) == true)
{
string strComparisonOpModifyDate = objXzGradeCond.dicFldComparisonOp[conXzGrade.ModifyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzGrade.ModifyDate, objXzGradeCond.ModifyDate, strComparisonOpModifyDate);
}
if (objXzGradeCond.IsUpdated(conXzGrade.Memo) == true)
{
string strComparisonOpMemo = objXzGradeCond.dicFldComparisonOp[conXzGrade.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzGrade.Memo, objXzGradeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_XzGrade
{
public virtual bool UpdRelaTabDate(string strIdGrade, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 年级(XzGrade)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsXzGradeBL
{
public static RelatedActions_XzGrade relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsXzGradeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsXzGradeDA XzGradeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsXzGradeDA();
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
 public clsXzGradeBL()
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
if (string.IsNullOrEmpty(clsXzGradeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsXzGradeEN._ConnectString);
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
public static DataTable GetDataTable_XzGrade(string strWhereCond)
{
DataTable objDT;
try
{
objDT = XzGradeDA.GetDataTable_XzGrade(strWhereCond);
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
objDT = XzGradeDA.GetDataTable(strWhereCond);
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
objDT = XzGradeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = XzGradeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = XzGradeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = XzGradeDA.GetDataTable_Top(objTopPara);
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
objDT = XzGradeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = XzGradeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = XzGradeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdGradeLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsXzGradeEN> GetObjLstByIdGradeLst(List<string> arrIdGradeLst)
{
List<clsXzGradeEN> arrObjLst = new List<clsXzGradeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdGradeLst, true);
 string strWhereCond = string.Format("IdGrade in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzGradeEN objXzGradeEN = new clsXzGradeEN();
try
{
objXzGradeEN.IdGrade = objRow[conXzGrade.IdGrade].ToString().Trim(); //年级流水号
objXzGradeEN.GradeName = objRow[conXzGrade.GradeName].ToString().Trim(); //年级名称
objXzGradeEN.IdStudyLevel = objRow[conXzGrade.IdStudyLevel].ToString().Trim(); //学段流水号
objXzGradeEN.GradeLeaderId = objRow[conXzGrade.GradeLeaderId] == DBNull.Value ? null : objRow[conXzGrade.GradeLeaderId].ToString().Trim(); //年级组长Id
objXzGradeEN.GradeIndex = objRow[conXzGrade.GradeIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzGrade.GradeIndex].ToString().Trim()); //年级序号
objXzGradeEN.ModifyUserId = objRow[conXzGrade.ModifyUserId] == DBNull.Value ? null : objRow[conXzGrade.ModifyUserId].ToString().Trim(); //修改人
objXzGradeEN.ModifyDate = objRow[conXzGrade.ModifyDate] == DBNull.Value ? null : objRow[conXzGrade.ModifyDate].ToString().Trim(); //修改日期
objXzGradeEN.Memo = objRow[conXzGrade.Memo] == DBNull.Value ? null : objRow[conXzGrade.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzGradeEN.IdGrade, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzGradeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdGradeLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsXzGradeEN> GetObjLstByIdGradeLstCache(List<string> arrIdGradeLst)
{
string strKey = string.Format("{0}", clsXzGradeEN._CurrTabName);
List<clsXzGradeEN> arrXzGradeObjLstCache = GetObjLstCache();
IEnumerable <clsXzGradeEN> arrXzGradeObjLst_Sel =
arrXzGradeObjLstCache
.Where(x => arrIdGradeLst.Contains(x.IdGrade));
return arrXzGradeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzGradeEN> GetObjLst(string strWhereCond)
{
List<clsXzGradeEN> arrObjLst = new List<clsXzGradeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzGradeEN objXzGradeEN = new clsXzGradeEN();
try
{
objXzGradeEN.IdGrade = objRow[conXzGrade.IdGrade].ToString().Trim(); //年级流水号
objXzGradeEN.GradeName = objRow[conXzGrade.GradeName].ToString().Trim(); //年级名称
objXzGradeEN.IdStudyLevel = objRow[conXzGrade.IdStudyLevel].ToString().Trim(); //学段流水号
objXzGradeEN.GradeLeaderId = objRow[conXzGrade.GradeLeaderId] == DBNull.Value ? null : objRow[conXzGrade.GradeLeaderId].ToString().Trim(); //年级组长Id
objXzGradeEN.GradeIndex = objRow[conXzGrade.GradeIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzGrade.GradeIndex].ToString().Trim()); //年级序号
objXzGradeEN.ModifyUserId = objRow[conXzGrade.ModifyUserId] == DBNull.Value ? null : objRow[conXzGrade.ModifyUserId].ToString().Trim(); //修改人
objXzGradeEN.ModifyDate = objRow[conXzGrade.ModifyDate] == DBNull.Value ? null : objRow[conXzGrade.ModifyDate].ToString().Trim(); //修改日期
objXzGradeEN.Memo = objRow[conXzGrade.Memo] == DBNull.Value ? null : objRow[conXzGrade.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzGradeEN.IdGrade, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzGradeEN);
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
public static List<clsXzGradeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsXzGradeEN> arrObjLst = new List<clsXzGradeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzGradeEN objXzGradeEN = new clsXzGradeEN();
try
{
objXzGradeEN.IdGrade = objRow[conXzGrade.IdGrade].ToString().Trim(); //年级流水号
objXzGradeEN.GradeName = objRow[conXzGrade.GradeName].ToString().Trim(); //年级名称
objXzGradeEN.IdStudyLevel = objRow[conXzGrade.IdStudyLevel].ToString().Trim(); //学段流水号
objXzGradeEN.GradeLeaderId = objRow[conXzGrade.GradeLeaderId] == DBNull.Value ? null : objRow[conXzGrade.GradeLeaderId].ToString().Trim(); //年级组长Id
objXzGradeEN.GradeIndex = objRow[conXzGrade.GradeIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzGrade.GradeIndex].ToString().Trim()); //年级序号
objXzGradeEN.ModifyUserId = objRow[conXzGrade.ModifyUserId] == DBNull.Value ? null : objRow[conXzGrade.ModifyUserId].ToString().Trim(); //修改人
objXzGradeEN.ModifyDate = objRow[conXzGrade.ModifyDate] == DBNull.Value ? null : objRow[conXzGrade.ModifyDate].ToString().Trim(); //修改日期
objXzGradeEN.Memo = objRow[conXzGrade.Memo] == DBNull.Value ? null : objRow[conXzGrade.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzGradeEN.IdGrade, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzGradeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objXzGradeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsXzGradeEN> GetSubObjLstCache(clsXzGradeEN objXzGradeCond)
{
List<clsXzGradeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsXzGradeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conXzGrade.AttributeName)
{
if (objXzGradeCond.IsUpdated(strFldName) == false) continue;
if (objXzGradeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objXzGradeCond[strFldName].ToString());
}
else
{
if (objXzGradeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objXzGradeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objXzGradeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objXzGradeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objXzGradeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objXzGradeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objXzGradeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objXzGradeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objXzGradeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objXzGradeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objXzGradeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objXzGradeCond[strFldName]));
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
public static List<clsXzGradeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsXzGradeEN> arrObjLst = new List<clsXzGradeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzGradeEN objXzGradeEN = new clsXzGradeEN();
try
{
objXzGradeEN.IdGrade = objRow[conXzGrade.IdGrade].ToString().Trim(); //年级流水号
objXzGradeEN.GradeName = objRow[conXzGrade.GradeName].ToString().Trim(); //年级名称
objXzGradeEN.IdStudyLevel = objRow[conXzGrade.IdStudyLevel].ToString().Trim(); //学段流水号
objXzGradeEN.GradeLeaderId = objRow[conXzGrade.GradeLeaderId] == DBNull.Value ? null : objRow[conXzGrade.GradeLeaderId].ToString().Trim(); //年级组长Id
objXzGradeEN.GradeIndex = objRow[conXzGrade.GradeIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzGrade.GradeIndex].ToString().Trim()); //年级序号
objXzGradeEN.ModifyUserId = objRow[conXzGrade.ModifyUserId] == DBNull.Value ? null : objRow[conXzGrade.ModifyUserId].ToString().Trim(); //修改人
objXzGradeEN.ModifyDate = objRow[conXzGrade.ModifyDate] == DBNull.Value ? null : objRow[conXzGrade.ModifyDate].ToString().Trim(); //修改日期
objXzGradeEN.Memo = objRow[conXzGrade.Memo] == DBNull.Value ? null : objRow[conXzGrade.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzGradeEN.IdGrade, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzGradeEN);
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
public static List<clsXzGradeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsXzGradeEN> arrObjLst = new List<clsXzGradeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzGradeEN objXzGradeEN = new clsXzGradeEN();
try
{
objXzGradeEN.IdGrade = objRow[conXzGrade.IdGrade].ToString().Trim(); //年级流水号
objXzGradeEN.GradeName = objRow[conXzGrade.GradeName].ToString().Trim(); //年级名称
objXzGradeEN.IdStudyLevel = objRow[conXzGrade.IdStudyLevel].ToString().Trim(); //学段流水号
objXzGradeEN.GradeLeaderId = objRow[conXzGrade.GradeLeaderId] == DBNull.Value ? null : objRow[conXzGrade.GradeLeaderId].ToString().Trim(); //年级组长Id
objXzGradeEN.GradeIndex = objRow[conXzGrade.GradeIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzGrade.GradeIndex].ToString().Trim()); //年级序号
objXzGradeEN.ModifyUserId = objRow[conXzGrade.ModifyUserId] == DBNull.Value ? null : objRow[conXzGrade.ModifyUserId].ToString().Trim(); //修改人
objXzGradeEN.ModifyDate = objRow[conXzGrade.ModifyDate] == DBNull.Value ? null : objRow[conXzGrade.ModifyDate].ToString().Trim(); //修改日期
objXzGradeEN.Memo = objRow[conXzGrade.Memo] == DBNull.Value ? null : objRow[conXzGrade.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzGradeEN.IdGrade, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzGradeEN);
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
List<clsXzGradeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsXzGradeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzGradeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsXzGradeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsXzGradeEN> arrObjLst = new List<clsXzGradeEN>(); 
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
	clsXzGradeEN objXzGradeEN = new clsXzGradeEN();
try
{
objXzGradeEN.IdGrade = objRow[conXzGrade.IdGrade].ToString().Trim(); //年级流水号
objXzGradeEN.GradeName = objRow[conXzGrade.GradeName].ToString().Trim(); //年级名称
objXzGradeEN.IdStudyLevel = objRow[conXzGrade.IdStudyLevel].ToString().Trim(); //学段流水号
objXzGradeEN.GradeLeaderId = objRow[conXzGrade.GradeLeaderId] == DBNull.Value ? null : objRow[conXzGrade.GradeLeaderId].ToString().Trim(); //年级组长Id
objXzGradeEN.GradeIndex = objRow[conXzGrade.GradeIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzGrade.GradeIndex].ToString().Trim()); //年级序号
objXzGradeEN.ModifyUserId = objRow[conXzGrade.ModifyUserId] == DBNull.Value ? null : objRow[conXzGrade.ModifyUserId].ToString().Trim(); //修改人
objXzGradeEN.ModifyDate = objRow[conXzGrade.ModifyDate] == DBNull.Value ? null : objRow[conXzGrade.ModifyDate].ToString().Trim(); //修改日期
objXzGradeEN.Memo = objRow[conXzGrade.Memo] == DBNull.Value ? null : objRow[conXzGrade.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzGradeEN.IdGrade, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzGradeEN);
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
public static List<clsXzGradeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsXzGradeEN> arrObjLst = new List<clsXzGradeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzGradeEN objXzGradeEN = new clsXzGradeEN();
try
{
objXzGradeEN.IdGrade = objRow[conXzGrade.IdGrade].ToString().Trim(); //年级流水号
objXzGradeEN.GradeName = objRow[conXzGrade.GradeName].ToString().Trim(); //年级名称
objXzGradeEN.IdStudyLevel = objRow[conXzGrade.IdStudyLevel].ToString().Trim(); //学段流水号
objXzGradeEN.GradeLeaderId = objRow[conXzGrade.GradeLeaderId] == DBNull.Value ? null : objRow[conXzGrade.GradeLeaderId].ToString().Trim(); //年级组长Id
objXzGradeEN.GradeIndex = objRow[conXzGrade.GradeIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzGrade.GradeIndex].ToString().Trim()); //年级序号
objXzGradeEN.ModifyUserId = objRow[conXzGrade.ModifyUserId] == DBNull.Value ? null : objRow[conXzGrade.ModifyUserId].ToString().Trim(); //修改人
objXzGradeEN.ModifyDate = objRow[conXzGrade.ModifyDate] == DBNull.Value ? null : objRow[conXzGrade.ModifyDate].ToString().Trim(); //修改日期
objXzGradeEN.Memo = objRow[conXzGrade.Memo] == DBNull.Value ? null : objRow[conXzGrade.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzGradeEN.IdGrade, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzGradeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsXzGradeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsXzGradeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsXzGradeEN> arrObjLst = new List<clsXzGradeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzGradeEN objXzGradeEN = new clsXzGradeEN();
try
{
objXzGradeEN.IdGrade = objRow[conXzGrade.IdGrade].ToString().Trim(); //年级流水号
objXzGradeEN.GradeName = objRow[conXzGrade.GradeName].ToString().Trim(); //年级名称
objXzGradeEN.IdStudyLevel = objRow[conXzGrade.IdStudyLevel].ToString().Trim(); //学段流水号
objXzGradeEN.GradeLeaderId = objRow[conXzGrade.GradeLeaderId] == DBNull.Value ? null : objRow[conXzGrade.GradeLeaderId].ToString().Trim(); //年级组长Id
objXzGradeEN.GradeIndex = objRow[conXzGrade.GradeIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzGrade.GradeIndex].ToString().Trim()); //年级序号
objXzGradeEN.ModifyUserId = objRow[conXzGrade.ModifyUserId] == DBNull.Value ? null : objRow[conXzGrade.ModifyUserId].ToString().Trim(); //修改人
objXzGradeEN.ModifyDate = objRow[conXzGrade.ModifyDate] == DBNull.Value ? null : objRow[conXzGrade.ModifyDate].ToString().Trim(); //修改日期
objXzGradeEN.Memo = objRow[conXzGrade.Memo] == DBNull.Value ? null : objRow[conXzGrade.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzGradeEN.IdGrade, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzGradeEN);
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
public static List<clsXzGradeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsXzGradeEN> arrObjLst = new List<clsXzGradeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzGradeEN objXzGradeEN = new clsXzGradeEN();
try
{
objXzGradeEN.IdGrade = objRow[conXzGrade.IdGrade].ToString().Trim(); //年级流水号
objXzGradeEN.GradeName = objRow[conXzGrade.GradeName].ToString().Trim(); //年级名称
objXzGradeEN.IdStudyLevel = objRow[conXzGrade.IdStudyLevel].ToString().Trim(); //学段流水号
objXzGradeEN.GradeLeaderId = objRow[conXzGrade.GradeLeaderId] == DBNull.Value ? null : objRow[conXzGrade.GradeLeaderId].ToString().Trim(); //年级组长Id
objXzGradeEN.GradeIndex = objRow[conXzGrade.GradeIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzGrade.GradeIndex].ToString().Trim()); //年级序号
objXzGradeEN.ModifyUserId = objRow[conXzGrade.ModifyUserId] == DBNull.Value ? null : objRow[conXzGrade.ModifyUserId].ToString().Trim(); //修改人
objXzGradeEN.ModifyDate = objRow[conXzGrade.ModifyDate] == DBNull.Value ? null : objRow[conXzGrade.ModifyDate].ToString().Trim(); //修改日期
objXzGradeEN.Memo = objRow[conXzGrade.Memo] == DBNull.Value ? null : objRow[conXzGrade.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzGradeEN.IdGrade, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzGradeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzGradeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsXzGradeEN> arrObjLst = new List<clsXzGradeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzGradeEN objXzGradeEN = new clsXzGradeEN();
try
{
objXzGradeEN.IdGrade = objRow[conXzGrade.IdGrade].ToString().Trim(); //年级流水号
objXzGradeEN.GradeName = objRow[conXzGrade.GradeName].ToString().Trim(); //年级名称
objXzGradeEN.IdStudyLevel = objRow[conXzGrade.IdStudyLevel].ToString().Trim(); //学段流水号
objXzGradeEN.GradeLeaderId = objRow[conXzGrade.GradeLeaderId] == DBNull.Value ? null : objRow[conXzGrade.GradeLeaderId].ToString().Trim(); //年级组长Id
objXzGradeEN.GradeIndex = objRow[conXzGrade.GradeIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzGrade.GradeIndex].ToString().Trim()); //年级序号
objXzGradeEN.ModifyUserId = objRow[conXzGrade.ModifyUserId] == DBNull.Value ? null : objRow[conXzGrade.ModifyUserId].ToString().Trim(); //修改人
objXzGradeEN.ModifyDate = objRow[conXzGrade.ModifyDate] == DBNull.Value ? null : objRow[conXzGrade.ModifyDate].ToString().Trim(); //修改日期
objXzGradeEN.Memo = objRow[conXzGrade.Memo] == DBNull.Value ? null : objRow[conXzGrade.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzGradeEN.IdGrade, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzGradeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objXzGradeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetXzGrade(ref clsXzGradeEN objXzGradeEN)
{
bool bolResult = XzGradeDA.GetXzGrade(ref objXzGradeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdGrade">表关键字</param>
 /// <returns>表对象</returns>
public static clsXzGradeEN GetObjByIdGrade(string strIdGrade)
{
if (strIdGrade.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdGrade]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdGrade) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdGrade]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsXzGradeEN objXzGradeEN = XzGradeDA.GetObjByIdGrade(strIdGrade);
return objXzGradeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsXzGradeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsXzGradeEN objXzGradeEN = XzGradeDA.GetFirstObj(strWhereCond);
 return objXzGradeEN;
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
public static clsXzGradeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsXzGradeEN objXzGradeEN = XzGradeDA.GetObjByDataRow(objRow);
 return objXzGradeEN;
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
public static clsXzGradeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsXzGradeEN objXzGradeEN = XzGradeDA.GetObjByDataRow(objRow);
 return objXzGradeEN;
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
 /// <param name = "strIdGrade">所给的关键字</param>
 /// <param name = "lstXzGradeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsXzGradeEN GetObjByIdGradeFromList(string strIdGrade, List<clsXzGradeEN> lstXzGradeObjLst)
{
foreach (clsXzGradeEN objXzGradeEN in lstXzGradeObjLst)
{
if (objXzGradeEN.IdGrade == strIdGrade)
{
return objXzGradeEN;
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
 string strIdGrade;
 try
 {
 strIdGrade = new clsXzGradeDA().GetFirstID(strWhereCond);
 return strIdGrade;
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
 arrList = XzGradeDA.GetID(strWhereCond);
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
bool bolIsExist = XzGradeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdGrade">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdGrade)
{
if (string.IsNullOrEmpty(strIdGrade) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdGrade]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = XzGradeDA.IsExist(strIdGrade);
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
 bolIsExist = clsXzGradeDA.IsExistTable();
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
 bolIsExist = XzGradeDA.IsExistTable(strTabName);
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
 /// <param name = "objXzGradeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsXzGradeEN objXzGradeEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objXzGradeEN.IdGrade) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsXzGradeBL.IsExist(objXzGradeEN.IdGrade) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objXzGradeEN.IdGrade, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = XzGradeDA.AddNewRecordBySQL2(objXzGradeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzGradeBL.ReFreshCache();

if (clsXzGradeBL.relatedActions != null)
{
clsXzGradeBL.relatedActions.UpdRelaTabDate(objXzGradeEN.IdGrade, "SetUpdDate");
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
 /// <param name = "objXzGradeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsXzGradeEN objXzGradeEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objXzGradeEN.IdGrade) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsXzGradeBL.IsExist(objXzGradeEN.IdGrade) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objXzGradeEN.IdGrade, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = XzGradeDA.AddNewRecordBySQL2WithReturnKey(objXzGradeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzGradeBL.ReFreshCache();

if (clsXzGradeBL.relatedActions != null)
{
clsXzGradeBL.relatedActions.UpdRelaTabDate(objXzGradeEN.IdGrade, "SetUpdDate");
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
 /// <param name = "objXzGradeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsXzGradeEN objXzGradeEN)
{
try
{
bool bolResult = XzGradeDA.Update(objXzGradeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzGradeBL.ReFreshCache();

if (clsXzGradeBL.relatedActions != null)
{
clsXzGradeBL.relatedActions.UpdRelaTabDate(objXzGradeEN.IdGrade, "SetUpdDate");
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
 /// <param name = "objXzGradeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsXzGradeEN objXzGradeEN)
{
 if (string.IsNullOrEmpty(objXzGradeEN.IdGrade) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = XzGradeDA.UpdateBySql2(objXzGradeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzGradeBL.ReFreshCache();

if (clsXzGradeBL.relatedActions != null)
{
clsXzGradeBL.relatedActions.UpdRelaTabDate(objXzGradeEN.IdGrade, "SetUpdDate");
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
 /// <param name = "strIdGrade">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strIdGrade)
{
try
{
 clsXzGradeEN objXzGradeEN = clsXzGradeBL.GetObjByIdGrade(strIdGrade);

if (clsXzGradeBL.relatedActions != null)
{
clsXzGradeBL.relatedActions.UpdRelaTabDate(objXzGradeEN.IdGrade, "SetUpdDate");
}
if (objXzGradeEN != null)
{
int intRecNum = XzGradeDA.DelRecord(strIdGrade);
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
/// <param name="strIdGrade">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strIdGrade )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsXzGradeDA.GetSpecSQLObj();
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
//删除与表:[XzGrade]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conXzGrade.IdGrade,
//strIdGrade);
//        clsXzGradeBL.DelXzGradesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsXzGradeBL.DelRecord(strIdGrade, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsXzGradeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdGrade, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strIdGrade">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strIdGrade, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsXzGradeBL.relatedActions != null)
{
clsXzGradeBL.relatedActions.UpdRelaTabDate(strIdGrade, "UpdRelaTabDate");
}
bool bolResult = XzGradeDA.DelRecord(strIdGrade,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdGradeLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelXzGrades(List<string> arrIdGradeLst)
{
if (arrIdGradeLst.Count == 0) return 0;
try
{
if (clsXzGradeBL.relatedActions != null)
{
foreach (var strIdGrade in arrIdGradeLst)
{
clsXzGradeBL.relatedActions.UpdRelaTabDate(strIdGrade, "UpdRelaTabDate");
}
}
int intDelRecNum = XzGradeDA.DelXzGrade(arrIdGradeLst);
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
public static int DelXzGradesByCond(string strWhereCond)
{
try
{
if (clsXzGradeBL.relatedActions != null)
{
List<string> arrIdGrade = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdGrade in arrIdGrade)
{
clsXzGradeBL.relatedActions.UpdRelaTabDate(strIdGrade, "UpdRelaTabDate");
}
}
int intRecNum = XzGradeDA.DelXzGrade(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[XzGrade]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strIdGrade">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strIdGrade)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsXzGradeDA.GetSpecSQLObj();
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
//删除与表:[XzGrade]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsXzGradeBL.DelRecord(strIdGrade, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsXzGradeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdGrade, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objXzGradeENS">源对象</param>
 /// <param name = "objXzGradeENT">目标对象</param>
 public static void CopyTo(clsXzGradeEN objXzGradeENS, clsXzGradeEN objXzGradeENT)
{
try
{
objXzGradeENT.IdGrade = objXzGradeENS.IdGrade; //年级流水号
objXzGradeENT.GradeName = objXzGradeENS.GradeName; //年级名称
objXzGradeENT.IdStudyLevel = objXzGradeENS.IdStudyLevel; //学段流水号
objXzGradeENT.GradeLeaderId = objXzGradeENS.GradeLeaderId; //年级组长Id
objXzGradeENT.GradeIndex = objXzGradeENS.GradeIndex; //年级序号
objXzGradeENT.ModifyUserId = objXzGradeENS.ModifyUserId; //修改人
objXzGradeENT.ModifyDate = objXzGradeENS.ModifyDate; //修改日期
objXzGradeENT.Memo = objXzGradeENS.Memo; //备注
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
 /// <param name = "objXzGradeEN">源简化对象</param>
 public static void SetUpdFlag(clsXzGradeEN objXzGradeEN)
{
try
{
objXzGradeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objXzGradeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conXzGrade.IdGrade, new clsStrCompareIgnoreCase())  ==  true)
{
objXzGradeEN.IdGrade = objXzGradeEN.IdGrade; //年级流水号
}
if (arrFldSet.Contains(conXzGrade.GradeName, new clsStrCompareIgnoreCase())  ==  true)
{
objXzGradeEN.GradeName = objXzGradeEN.GradeName; //年级名称
}
if (arrFldSet.Contains(conXzGrade.IdStudyLevel, new clsStrCompareIgnoreCase())  ==  true)
{
objXzGradeEN.IdStudyLevel = objXzGradeEN.IdStudyLevel; //学段流水号
}
if (arrFldSet.Contains(conXzGrade.GradeLeaderId, new clsStrCompareIgnoreCase())  ==  true)
{
objXzGradeEN.GradeLeaderId = objXzGradeEN.GradeLeaderId == "[null]" ? null :  objXzGradeEN.GradeLeaderId; //年级组长Id
}
if (arrFldSet.Contains(conXzGrade.GradeIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objXzGradeEN.GradeIndex = objXzGradeEN.GradeIndex; //年级序号
}
if (arrFldSet.Contains(conXzGrade.ModifyUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objXzGradeEN.ModifyUserId = objXzGradeEN.ModifyUserId == "[null]" ? null :  objXzGradeEN.ModifyUserId; //修改人
}
if (arrFldSet.Contains(conXzGrade.ModifyDate, new clsStrCompareIgnoreCase())  ==  true)
{
objXzGradeEN.ModifyDate = objXzGradeEN.ModifyDate == "[null]" ? null :  objXzGradeEN.ModifyDate; //修改日期
}
if (arrFldSet.Contains(conXzGrade.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objXzGradeEN.Memo = objXzGradeEN.Memo == "[null]" ? null :  objXzGradeEN.Memo; //备注
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
 /// <param name = "objXzGradeEN">源简化对象</param>
 public static void AccessFldValueNull(clsXzGradeEN objXzGradeEN)
{
try
{
if (objXzGradeEN.GradeLeaderId == "[null]") objXzGradeEN.GradeLeaderId = null; //年级组长Id
if (objXzGradeEN.ModifyUserId == "[null]") objXzGradeEN.ModifyUserId = null; //修改人
if (objXzGradeEN.ModifyDate == "[null]") objXzGradeEN.ModifyDate = null; //修改日期
if (objXzGradeEN.Memo == "[null]") objXzGradeEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsXzGradeEN objXzGradeEN)
{
 XzGradeDA.CheckPropertyNew(objXzGradeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsXzGradeEN objXzGradeEN)
{
 XzGradeDA.CheckProperty4Condition(objXzGradeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_IdGradeCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[年级]...","0");
List<clsXzGradeEN> arrXzGradeObjLst = GetAllXzGradeObjLstCache(); 
objDDL.DataValueField = conXzGrade.IdGrade;
objDDL.DataTextField = conXzGrade.GradeName;
objDDL.DataSource = arrXzGradeObjLst;
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
if (clsXzGradeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGradeBL没有刷新缓存机制(clsXzGradeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdGrade");
//if (arrXzGradeObjLstCache == null)
//{
//arrXzGradeObjLstCache = XzGradeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdGrade">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsXzGradeEN GetObjByIdGradeCache(string strIdGrade)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsXzGradeEN._CurrTabName);
List<clsXzGradeEN> arrXzGradeObjLstCache = GetObjLstCache();
IEnumerable <clsXzGradeEN> arrXzGradeObjLst_Sel =
arrXzGradeObjLstCache
.Where(x=> x.IdGrade == strIdGrade 
);
if (arrXzGradeObjLst_Sel.Count() == 0)
{
   clsXzGradeEN obj = clsXzGradeBL.GetObjByIdGrade(strIdGrade);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrXzGradeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdGrade">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetGradeNameByIdGradeCache(string strIdGrade)
{
if (string.IsNullOrEmpty(strIdGrade) == true) return "";
//获取缓存中的对象列表
clsXzGradeEN objXzGrade = GetObjByIdGradeCache(strIdGrade);
if (objXzGrade == null) return "";
return objXzGrade.GradeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdGrade">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByIdGradeCache(string strIdGrade)
{
if (string.IsNullOrEmpty(strIdGrade) == true) return "";
//获取缓存中的对象列表
clsXzGradeEN objXzGrade = GetObjByIdGradeCache(strIdGrade);
if (objXzGrade == null) return "";
return objXzGrade.GradeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsXzGradeEN> GetAllXzGradeObjLstCache()
{
//获取缓存中的对象列表
List<clsXzGradeEN> arrXzGradeObjLstCache = GetObjLstCache(); 
return arrXzGradeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsXzGradeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsXzGradeEN._CurrTabName);
List<clsXzGradeEN> arrXzGradeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrXzGradeObjLstCache;
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
string strKey = string.Format("{0}", clsXzGradeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsXzGradeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsXzGradeEN._RefreshTimeLst.Count == 0) return "";
return clsXzGradeEN._RefreshTimeLst[clsXzGradeEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsXzGradeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsXzGradeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsXzGradeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsXzGradeBL.objCommFun4BL.ReFreshCache();
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
public static string Func(string strInFldName, string strOutFldName, string strIdGrade)
{
if (strInFldName != conXzGrade.IdGrade)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conXzGrade.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conXzGrade.AttributeName));
throw new Exception(strMsg);
}
var objXzGrade = clsXzGradeBL.GetObjByIdGradeCache(strIdGrade);
if (objXzGrade == null) return "";
return objXzGrade[strOutFldName].ToString();
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
int intRecCount = clsXzGradeDA.GetRecCount(strTabName);
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
int intRecCount = clsXzGradeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsXzGradeDA.GetRecCount();
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
int intRecCount = clsXzGradeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objXzGradeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsXzGradeEN objXzGradeCond)
{
List<clsXzGradeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsXzGradeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conXzGrade.AttributeName)
{
if (objXzGradeCond.IsUpdated(strFldName) == false) continue;
if (objXzGradeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objXzGradeCond[strFldName].ToString());
}
else
{
if (objXzGradeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objXzGradeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objXzGradeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objXzGradeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objXzGradeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objXzGradeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objXzGradeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objXzGradeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objXzGradeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objXzGradeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objXzGradeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objXzGradeCond[strFldName]));
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
 List<string> arrList = clsXzGradeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = XzGradeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = XzGradeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = XzGradeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsXzGradeDA.SetFldValue(clsXzGradeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = XzGradeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsXzGradeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsXzGradeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsXzGradeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[XzGrade] "); 
 strCreateTabCode.Append(" ( "); 
 // /**年级流水号*/ 
 strCreateTabCode.Append(" IdGrade char(4) primary key, "); 
 // /**年级名称*/ 
 strCreateTabCode.Append(" GradeName varchar(50) not Null, "); 
 // /**学段流水号*/ 
 strCreateTabCode.Append(" IdStudyLevel char(4) not Null, "); 
 // /**年级组长Id*/ 
 strCreateTabCode.Append(" GradeLeaderId char(8) Null, "); 
 // /**年级序号*/ 
 strCreateTabCode.Append(" GradeIndex int Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" ModifyUserId varchar(18) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" ModifyDate varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 年级(XzGrade)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4XzGrade : clsCommFun4BL
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
clsXzGradeBL.ReFreshThisCache();
}
}

}