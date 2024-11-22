﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPaperSubViewpointAppraiseBL
 表名:PaperSubViewpointAppraise(01120561)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:05:38
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
public static class  clsPaperSubViewpointAppraiseBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngPaperSubViewpointAppraiseId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPaperSubViewpointAppraiseEN GetObj(this K_PaperSubViewpointAppraiseId_PaperSubViewpointAppraise myKey)
{
clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN = clsPaperSubViewpointAppraiseBL.PaperSubViewpointAppraiseDA.GetObjByPaperSubViewpointAppraiseId(myKey.Value);
return objPaperSubViewpointAppraiseEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objPaperSubViewpointAppraiseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objPaperSubViewpointAppraiseEN) == false)
{
var strMsg = string.Format("记录已经存在!子观点评价Id = [{0}]的数据已经存在!(in clsPaperSubViewpointAppraiseBL.AddNewRecord)", objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsPaperSubViewpointAppraiseBL.PaperSubViewpointAppraiseDA.AddNewRecordBySQL2(objPaperSubViewpointAppraiseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubViewpointAppraiseBL.ReFreshCache();

if (clsPaperSubViewpointAppraiseBL.relatedActions != null)
{
clsPaperSubViewpointAppraiseBL.relatedActions.UpdRelaTabDate(objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId, "SetUpdDate");
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
public static bool AddRecordEx(this clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN, bool bolIsNeedCheckUniqueness = true)
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
objPaperSubViewpointAppraiseEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objPaperSubViewpointAppraiseEN.CheckUniqueness() == false)
{
strMsg = string.Format("(子观点评价Id(PaperSubViewpointAppraiseId)=[{0}])已经存在,不能重复!", objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objPaperSubViewpointAppraiseEN.AddNewRecord();
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
 /// <param name = "objPaperSubViewpointAppraiseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objPaperSubViewpointAppraiseEN) == false)
{
var strMsg = string.Format("记录已经存在!子观点评价Id = [{0}]的数据已经存在!(in clsPaperSubViewpointAppraiseBL.AddNewRecordWithReturnKey)", objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId);
throw new Exception(strMsg);
}
try
{
string strKey = clsPaperSubViewpointAppraiseBL.PaperSubViewpointAppraiseDA.AddNewRecordBySQL2WithReturnKey(objPaperSubViewpointAppraiseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubViewpointAppraiseBL.ReFreshCache();

if (clsPaperSubViewpointAppraiseBL.relatedActions != null)
{
clsPaperSubViewpointAppraiseBL.relatedActions.UpdRelaTabDate(objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId, "SetUpdDate");
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
 /// <param name = "objPaperSubViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubViewpointAppraiseEN SetPaperSubViewpointAppraiseId(this clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN, long lngPaperSubViewpointAppraiseId, string strComparisonOp="")
	{
objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId = lngPaperSubViewpointAppraiseId; //子观点评价Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpointAppraise.PaperSubViewpointAppraiseId) == false)
{
objPaperSubViewpointAppraiseEN.dicFldComparisonOp.Add(conPaperSubViewpointAppraise.PaperSubViewpointAppraiseId, strComparisonOp);
}
else
{
objPaperSubViewpointAppraiseEN.dicFldComparisonOp[conPaperSubViewpointAppraise.PaperSubViewpointAppraiseId] = strComparisonOp;
}
}
return objPaperSubViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubViewpointAppraiseEN SetSubViewpointId(this clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN, long lngSubViewpointId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngSubViewpointId, conPaperSubViewpointAppraise.SubViewpointId);
objPaperSubViewpointAppraiseEN.SubViewpointId = lngSubViewpointId; //子观点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpointAppraise.SubViewpointId) == false)
{
objPaperSubViewpointAppraiseEN.dicFldComparisonOp.Add(conPaperSubViewpointAppraise.SubViewpointId, strComparisonOp);
}
else
{
objPaperSubViewpointAppraiseEN.dicFldComparisonOp[conPaperSubViewpointAppraise.SubViewpointId] = strComparisonOp;
}
}
return objPaperSubViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubViewpointAppraiseEN SetAppraiseScore(this clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN, float? fltAppraiseScore, string strComparisonOp="")
	{
objPaperSubViewpointAppraiseEN.AppraiseScore = fltAppraiseScore; //打分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpointAppraise.AppraiseScore) == false)
{
objPaperSubViewpointAppraiseEN.dicFldComparisonOp.Add(conPaperSubViewpointAppraise.AppraiseScore, strComparisonOp);
}
else
{
objPaperSubViewpointAppraiseEN.dicFldComparisonOp[conPaperSubViewpointAppraise.AppraiseScore] = strComparisonOp;
}
}
return objPaperSubViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubViewpointAppraiseEN SetAppraiseContent(this clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN, string strAppraiseContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAppraiseContent, 2000, conPaperSubViewpointAppraise.AppraiseContent);
}
objPaperSubViewpointAppraiseEN.AppraiseContent = strAppraiseContent; //评议内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpointAppraise.AppraiseContent) == false)
{
objPaperSubViewpointAppraiseEN.dicFldComparisonOp.Add(conPaperSubViewpointAppraise.AppraiseContent, strComparisonOp);
}
else
{
objPaperSubViewpointAppraiseEN.dicFldComparisonOp[conPaperSubViewpointAppraise.AppraiseContent] = strComparisonOp;
}
}
return objPaperSubViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubViewpointAppraiseEN SetUpdDate(this clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conPaperSubViewpointAppraise.UpdDate);
}
objPaperSubViewpointAppraiseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpointAppraise.UpdDate) == false)
{
objPaperSubViewpointAppraiseEN.dicFldComparisonOp.Add(conPaperSubViewpointAppraise.UpdDate, strComparisonOp);
}
else
{
objPaperSubViewpointAppraiseEN.dicFldComparisonOp[conPaperSubViewpointAppraise.UpdDate] = strComparisonOp;
}
}
return objPaperSubViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubViewpointAppraiseEN SetMeno(this clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN, string strMeno, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMeno, 2000, conPaperSubViewpointAppraise.Meno);
}
objPaperSubViewpointAppraiseEN.Meno = strMeno; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpointAppraise.Meno) == false)
{
objPaperSubViewpointAppraiseEN.dicFldComparisonOp.Add(conPaperSubViewpointAppraise.Meno, strComparisonOp);
}
else
{
objPaperSubViewpointAppraiseEN.dicFldComparisonOp[conPaperSubViewpointAppraise.Meno] = strComparisonOp;
}
}
return objPaperSubViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubViewpointAppraiseEN SetUpdUser(this clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conPaperSubViewpointAppraise.UpdUser);
}
objPaperSubViewpointAppraiseEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpointAppraise.UpdUser) == false)
{
objPaperSubViewpointAppraiseEN.dicFldComparisonOp.Add(conPaperSubViewpointAppraise.UpdUser, strComparisonOp);
}
else
{
objPaperSubViewpointAppraiseEN.dicFldComparisonOp[conPaperSubViewpointAppraise.UpdUser] = strComparisonOp;
}
}
return objPaperSubViewpointAppraiseEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objPaperSubViewpointAppraiseEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objPaperSubViewpointAppraiseEN.CheckPropertyNew();
clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseCond = new clsPaperSubViewpointAppraiseEN();
string strCondition = objPaperSubViewpointAppraiseCond
.SetPaperSubViewpointAppraiseId(objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId, "<>")
.SetPaperSubViewpointAppraiseId(objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId, "=")
.GetCombineCondition();
objPaperSubViewpointAppraiseEN._IsCheckProperty = true;
bool bolIsExist = clsPaperSubViewpointAppraiseBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(PaperSubViewpointAppraiseId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objPaperSubViewpointAppraiseEN.Update();
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
 /// <param name = "objPaperSubViewpointAppraise">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraise)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseCond = new clsPaperSubViewpointAppraiseEN();
string strCondition = objPaperSubViewpointAppraiseCond
.SetPaperSubViewpointAppraiseId(objPaperSubViewpointAppraise.PaperSubViewpointAppraiseId, "=")
.GetCombineCondition();
objPaperSubViewpointAppraise._IsCheckProperty = true;
bool bolIsExist = clsPaperSubViewpointAppraiseBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objPaperSubViewpointAppraise.PaperSubViewpointAppraiseId = clsPaperSubViewpointAppraiseBL.GetFirstID_S(strCondition);
objPaperSubViewpointAppraise.UpdateWithCondition(strCondition);
}
else
{
objPaperSubViewpointAppraise.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objPaperSubViewpointAppraiseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN)
{
 if (objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPaperSubViewpointAppraiseBL.PaperSubViewpointAppraiseDA.UpdateBySql2(objPaperSubViewpointAppraiseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubViewpointAppraiseBL.ReFreshCache();

if (clsPaperSubViewpointAppraiseBL.relatedActions != null)
{
clsPaperSubViewpointAppraiseBL.relatedActions.UpdRelaTabDate(objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId, "SetUpdDate");
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
 /// <param name = "objPaperSubViewpointAppraiseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPaperSubViewpointAppraiseBL.PaperSubViewpointAppraiseDA.UpdateBySql2(objPaperSubViewpointAppraiseEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubViewpointAppraiseBL.ReFreshCache();

if (clsPaperSubViewpointAppraiseBL.relatedActions != null)
{
clsPaperSubViewpointAppraiseBL.relatedActions.UpdRelaTabDate(objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId, "SetUpdDate");
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
 /// <param name = "objPaperSubViewpointAppraiseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN, string strWhereCond)
{
try
{
bool bolResult = clsPaperSubViewpointAppraiseBL.PaperSubViewpointAppraiseDA.UpdateBySqlWithCondition(objPaperSubViewpointAppraiseEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubViewpointAppraiseBL.ReFreshCache();

if (clsPaperSubViewpointAppraiseBL.relatedActions != null)
{
clsPaperSubViewpointAppraiseBL.relatedActions.UpdRelaTabDate(objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId, "SetUpdDate");
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
 /// <param name = "objPaperSubViewpointAppraiseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsPaperSubViewpointAppraiseBL.PaperSubViewpointAppraiseDA.UpdateBySqlWithConditionTransaction(objPaperSubViewpointAppraiseEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubViewpointAppraiseBL.ReFreshCache();

if (clsPaperSubViewpointAppraiseBL.relatedActions != null)
{
clsPaperSubViewpointAppraiseBL.relatedActions.UpdRelaTabDate(objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId, "SetUpdDate");
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
 /// <param name = "lngPaperSubViewpointAppraiseId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN)
{
try
{
int intRecNum = clsPaperSubViewpointAppraiseBL.PaperSubViewpointAppraiseDA.DelRecord(objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubViewpointAppraiseBL.ReFreshCache();

if (clsPaperSubViewpointAppraiseBL.relatedActions != null)
{
clsPaperSubViewpointAppraiseBL.relatedActions.UpdRelaTabDate(objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId, "SetUpdDate");
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
 /// <param name = "objPaperSubViewpointAppraiseENS">源对象</param>
 /// <param name = "objPaperSubViewpointAppraiseENT">目标对象</param>
 public static void CopyTo(this clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseENS, clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseENT)
{
try
{
objPaperSubViewpointAppraiseENT.PaperSubViewpointAppraiseId = objPaperSubViewpointAppraiseENS.PaperSubViewpointAppraiseId; //子观点评价Id
objPaperSubViewpointAppraiseENT.SubViewpointId = objPaperSubViewpointAppraiseENS.SubViewpointId; //子观点Id
objPaperSubViewpointAppraiseENT.AppraiseScore = objPaperSubViewpointAppraiseENS.AppraiseScore; //打分
objPaperSubViewpointAppraiseENT.AppraiseContent = objPaperSubViewpointAppraiseENS.AppraiseContent; //评议内容
objPaperSubViewpointAppraiseENT.UpdDate = objPaperSubViewpointAppraiseENS.UpdDate; //修改日期
objPaperSubViewpointAppraiseENT.Meno = objPaperSubViewpointAppraiseENS.Meno; //备注
objPaperSubViewpointAppraiseENT.UpdUser = objPaperSubViewpointAppraiseENS.UpdUser; //修改人
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
 /// <param name = "objPaperSubViewpointAppraiseENS">源对象</param>
 /// <returns>目标对象=>clsPaperSubViewpointAppraiseEN:objPaperSubViewpointAppraiseENT</returns>
 public static clsPaperSubViewpointAppraiseEN CopyTo(this clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseENS)
{
try
{
 clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseENT = new clsPaperSubViewpointAppraiseEN()
{
PaperSubViewpointAppraiseId = objPaperSubViewpointAppraiseENS.PaperSubViewpointAppraiseId, //子观点评价Id
SubViewpointId = objPaperSubViewpointAppraiseENS.SubViewpointId, //子观点Id
AppraiseScore = objPaperSubViewpointAppraiseENS.AppraiseScore, //打分
AppraiseContent = objPaperSubViewpointAppraiseENS.AppraiseContent, //评议内容
UpdDate = objPaperSubViewpointAppraiseENS.UpdDate, //修改日期
Meno = objPaperSubViewpointAppraiseENS.Meno, //备注
UpdUser = objPaperSubViewpointAppraiseENS.UpdUser, //修改人
};
 return objPaperSubViewpointAppraiseENT;
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
public static void CheckPropertyNew(this clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN)
{
 clsPaperSubViewpointAppraiseBL.PaperSubViewpointAppraiseDA.CheckPropertyNew(objPaperSubViewpointAppraiseEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN)
{
 clsPaperSubViewpointAppraiseBL.PaperSubViewpointAppraiseDA.CheckProperty4Condition(objPaperSubViewpointAppraiseEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objPaperSubViewpointAppraiseCond.IsUpdated(conPaperSubViewpointAppraise.PaperSubViewpointAppraiseId) == true)
{
string strComparisonOpPaperSubViewpointAppraiseId = objPaperSubViewpointAppraiseCond.dicFldComparisonOp[conPaperSubViewpointAppraise.PaperSubViewpointAppraiseId];
strWhereCond += string.Format(" And {0} {2} {1}", conPaperSubViewpointAppraise.PaperSubViewpointAppraiseId, objPaperSubViewpointAppraiseCond.PaperSubViewpointAppraiseId, strComparisonOpPaperSubViewpointAppraiseId);
}
if (objPaperSubViewpointAppraiseCond.IsUpdated(conPaperSubViewpointAppraise.SubViewpointId) == true)
{
string strComparisonOpSubViewpointId = objPaperSubViewpointAppraiseCond.dicFldComparisonOp[conPaperSubViewpointAppraise.SubViewpointId];
strWhereCond += string.Format(" And {0} {2} {1}", conPaperSubViewpointAppraise.SubViewpointId, objPaperSubViewpointAppraiseCond.SubViewpointId, strComparisonOpSubViewpointId);
}
if (objPaperSubViewpointAppraiseCond.IsUpdated(conPaperSubViewpointAppraise.AppraiseScore) == true)
{
string strComparisonOpAppraiseScore = objPaperSubViewpointAppraiseCond.dicFldComparisonOp[conPaperSubViewpointAppraise.AppraiseScore];
strWhereCond += string.Format(" And {0} {2} {1}", conPaperSubViewpointAppraise.AppraiseScore, objPaperSubViewpointAppraiseCond.AppraiseScore, strComparisonOpAppraiseScore);
}
if (objPaperSubViewpointAppraiseCond.IsUpdated(conPaperSubViewpointAppraise.AppraiseContent) == true)
{
string strComparisonOpAppraiseContent = objPaperSubViewpointAppraiseCond.dicFldComparisonOp[conPaperSubViewpointAppraise.AppraiseContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubViewpointAppraise.AppraiseContent, objPaperSubViewpointAppraiseCond.AppraiseContent, strComparisonOpAppraiseContent);
}
if (objPaperSubViewpointAppraiseCond.IsUpdated(conPaperSubViewpointAppraise.UpdDate) == true)
{
string strComparisonOpUpdDate = objPaperSubViewpointAppraiseCond.dicFldComparisonOp[conPaperSubViewpointAppraise.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubViewpointAppraise.UpdDate, objPaperSubViewpointAppraiseCond.UpdDate, strComparisonOpUpdDate);
}
if (objPaperSubViewpointAppraiseCond.IsUpdated(conPaperSubViewpointAppraise.Meno) == true)
{
string strComparisonOpMeno = objPaperSubViewpointAppraiseCond.dicFldComparisonOp[conPaperSubViewpointAppraise.Meno];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubViewpointAppraise.Meno, objPaperSubViewpointAppraiseCond.Meno, strComparisonOpMeno);
}
if (objPaperSubViewpointAppraiseCond.IsUpdated(conPaperSubViewpointAppraise.UpdUser) == true)
{
string strComparisonOpUpdUser = objPaperSubViewpointAppraiseCond.dicFldComparisonOp[conPaperSubViewpointAppraise.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubViewpointAppraise.UpdUser, objPaperSubViewpointAppraiseCond.UpdUser, strComparisonOpUpdUser);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--PaperSubViewpointAppraise(子观点评论表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:PaperSubViewpointAppraiseId_SuvViewpointId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objPaperSubViewpointAppraiseEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objPaperSubViewpointAppraiseEN == null) return true;
if (objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PaperSubViewpointAppraiseId = '{0}'", objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId);
if (clsPaperSubViewpointAppraiseBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("PaperSubViewpointAppraiseId !=  {0}", objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId);
 sbCondition.AppendFormat(" and PaperSubViewpointAppraiseId = '{0}'", objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId);
if (clsPaperSubViewpointAppraiseBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--PaperSubViewpointAppraise(子观点评论表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PaperSubViewpointAppraiseId_SuvViewpointId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objPaperSubViewpointAppraiseEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objPaperSubViewpointAppraiseEN == null) return "";
if (objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PaperSubViewpointAppraiseId = '{0}'", objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("PaperSubViewpointAppraiseId !=  {0}", objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId);
 sbCondition.AppendFormat(" and PaperSubViewpointAppraiseId = '{0}'", objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_PaperSubViewpointAppraise
{
public virtual bool UpdRelaTabDate(long lngPaperSubViewpointAppraiseId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 子观点评论表(PaperSubViewpointAppraise)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsPaperSubViewpointAppraiseBL
{
public static RelatedActions_PaperSubViewpointAppraise relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsPaperSubViewpointAppraiseDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsPaperSubViewpointAppraiseDA PaperSubViewpointAppraiseDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsPaperSubViewpointAppraiseDA();
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
 public clsPaperSubViewpointAppraiseBL()
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
if (string.IsNullOrEmpty(clsPaperSubViewpointAppraiseEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsPaperSubViewpointAppraiseEN._ConnectString);
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
public static DataTable GetDataTable_PaperSubViewpointAppraise(string strWhereCond)
{
DataTable objDT;
try
{
objDT = PaperSubViewpointAppraiseDA.GetDataTable_PaperSubViewpointAppraise(strWhereCond);
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
objDT = PaperSubViewpointAppraiseDA.GetDataTable(strWhereCond);
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
objDT = PaperSubViewpointAppraiseDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = PaperSubViewpointAppraiseDA.GetDataTable(strWhereCond, strTabName);
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
objDT = PaperSubViewpointAppraiseDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = PaperSubViewpointAppraiseDA.GetDataTable_Top(objTopPara);
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
objDT = PaperSubViewpointAppraiseDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = PaperSubViewpointAppraiseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = PaperSubViewpointAppraiseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrPaperSubViewpointAppraiseIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsPaperSubViewpointAppraiseEN> GetObjLstByPaperSubViewpointAppraiseIdLst(List<long> arrPaperSubViewpointAppraiseIdLst)
{
List<clsPaperSubViewpointAppraiseEN> arrObjLst = new List<clsPaperSubViewpointAppraiseEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrPaperSubViewpointAppraiseIdLst);
 string strWhereCond = string.Format("PaperSubViewpointAppraiseId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN = new clsPaperSubViewpointAppraiseEN();
try
{
objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId = Int32.Parse(objRow[conPaperSubViewpointAppraise.PaperSubViewpointAppraiseId].ToString().Trim()); //子观点评价Id
objPaperSubViewpointAppraiseEN.SubViewpointId = Int32.Parse(objRow[conPaperSubViewpointAppraise.SubViewpointId].ToString().Trim()); //子观点Id
objPaperSubViewpointAppraiseEN.AppraiseScore = objRow[conPaperSubViewpointAppraise.AppraiseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaperSubViewpointAppraise.AppraiseScore].ToString().Trim()); //打分
objPaperSubViewpointAppraiseEN.AppraiseContent = objRow[conPaperSubViewpointAppraise.AppraiseContent] == DBNull.Value ? null : objRow[conPaperSubViewpointAppraise.AppraiseContent].ToString().Trim(); //评议内容
objPaperSubViewpointAppraiseEN.UpdDate = objRow[conPaperSubViewpointAppraise.UpdDate] == DBNull.Value ? null : objRow[conPaperSubViewpointAppraise.UpdDate].ToString().Trim(); //修改日期
objPaperSubViewpointAppraiseEN.Meno = objRow[conPaperSubViewpointAppraise.Meno] == DBNull.Value ? null : objRow[conPaperSubViewpointAppraise.Meno].ToString().Trim(); //备注
objPaperSubViewpointAppraiseEN.UpdUser = objRow[conPaperSubViewpointAppraise.UpdUser] == DBNull.Value ? null : objRow[conPaperSubViewpointAppraise.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperSubViewpointAppraiseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPaperSubViewpointAppraiseIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsPaperSubViewpointAppraiseEN> GetObjLstByPaperSubViewpointAppraiseIdLstCache(List<long> arrPaperSubViewpointAppraiseIdLst)
{
string strKey = string.Format("{0}", clsPaperSubViewpointAppraiseEN._CurrTabName);
List<clsPaperSubViewpointAppraiseEN> arrPaperSubViewpointAppraiseObjLstCache = GetObjLstCache();
IEnumerable <clsPaperSubViewpointAppraiseEN> arrPaperSubViewpointAppraiseObjLst_Sel =
arrPaperSubViewpointAppraiseObjLstCache
.Where(x => arrPaperSubViewpointAppraiseIdLst.Contains(x.PaperSubViewpointAppraiseId));
return arrPaperSubViewpointAppraiseObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsPaperSubViewpointAppraiseEN> GetObjLst(string strWhereCond)
{
List<clsPaperSubViewpointAppraiseEN> arrObjLst = new List<clsPaperSubViewpointAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN = new clsPaperSubViewpointAppraiseEN();
try
{
objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId = Int32.Parse(objRow[conPaperSubViewpointAppraise.PaperSubViewpointAppraiseId].ToString().Trim()); //子观点评价Id
objPaperSubViewpointAppraiseEN.SubViewpointId = Int32.Parse(objRow[conPaperSubViewpointAppraise.SubViewpointId].ToString().Trim()); //子观点Id
objPaperSubViewpointAppraiseEN.AppraiseScore = objRow[conPaperSubViewpointAppraise.AppraiseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaperSubViewpointAppraise.AppraiseScore].ToString().Trim()); //打分
objPaperSubViewpointAppraiseEN.AppraiseContent = objRow[conPaperSubViewpointAppraise.AppraiseContent] == DBNull.Value ? null : objRow[conPaperSubViewpointAppraise.AppraiseContent].ToString().Trim(); //评议内容
objPaperSubViewpointAppraiseEN.UpdDate = objRow[conPaperSubViewpointAppraise.UpdDate] == DBNull.Value ? null : objRow[conPaperSubViewpointAppraise.UpdDate].ToString().Trim(); //修改日期
objPaperSubViewpointAppraiseEN.Meno = objRow[conPaperSubViewpointAppraise.Meno] == DBNull.Value ? null : objRow[conPaperSubViewpointAppraise.Meno].ToString().Trim(); //备注
objPaperSubViewpointAppraiseEN.UpdUser = objRow[conPaperSubViewpointAppraise.UpdUser] == DBNull.Value ? null : objRow[conPaperSubViewpointAppraise.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperSubViewpointAppraiseEN);
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
public static List<clsPaperSubViewpointAppraiseEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsPaperSubViewpointAppraiseEN> arrObjLst = new List<clsPaperSubViewpointAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN = new clsPaperSubViewpointAppraiseEN();
try
{
objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId = Int32.Parse(objRow[conPaperSubViewpointAppraise.PaperSubViewpointAppraiseId].ToString().Trim()); //子观点评价Id
objPaperSubViewpointAppraiseEN.SubViewpointId = Int32.Parse(objRow[conPaperSubViewpointAppraise.SubViewpointId].ToString().Trim()); //子观点Id
objPaperSubViewpointAppraiseEN.AppraiseScore = objRow[conPaperSubViewpointAppraise.AppraiseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaperSubViewpointAppraise.AppraiseScore].ToString().Trim()); //打分
objPaperSubViewpointAppraiseEN.AppraiseContent = objRow[conPaperSubViewpointAppraise.AppraiseContent] == DBNull.Value ? null : objRow[conPaperSubViewpointAppraise.AppraiseContent].ToString().Trim(); //评议内容
objPaperSubViewpointAppraiseEN.UpdDate = objRow[conPaperSubViewpointAppraise.UpdDate] == DBNull.Value ? null : objRow[conPaperSubViewpointAppraise.UpdDate].ToString().Trim(); //修改日期
objPaperSubViewpointAppraiseEN.Meno = objRow[conPaperSubViewpointAppraise.Meno] == DBNull.Value ? null : objRow[conPaperSubViewpointAppraise.Meno].ToString().Trim(); //备注
objPaperSubViewpointAppraiseEN.UpdUser = objRow[conPaperSubViewpointAppraise.UpdUser] == DBNull.Value ? null : objRow[conPaperSubViewpointAppraise.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperSubViewpointAppraiseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objPaperSubViewpointAppraiseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsPaperSubViewpointAppraiseEN> GetSubObjLstCache(clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseCond)
{
List<clsPaperSubViewpointAppraiseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsPaperSubViewpointAppraiseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPaperSubViewpointAppraise.AttributeName)
{
if (objPaperSubViewpointAppraiseCond.IsUpdated(strFldName) == false) continue;
if (objPaperSubViewpointAppraiseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPaperSubViewpointAppraiseCond[strFldName].ToString());
}
else
{
if (objPaperSubViewpointAppraiseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPaperSubViewpointAppraiseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPaperSubViewpointAppraiseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPaperSubViewpointAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPaperSubViewpointAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPaperSubViewpointAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPaperSubViewpointAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPaperSubViewpointAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPaperSubViewpointAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPaperSubViewpointAppraiseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPaperSubViewpointAppraiseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPaperSubViewpointAppraiseCond[strFldName]));
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
public static List<clsPaperSubViewpointAppraiseEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsPaperSubViewpointAppraiseEN> arrObjLst = new List<clsPaperSubViewpointAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN = new clsPaperSubViewpointAppraiseEN();
try
{
objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId = Int32.Parse(objRow[conPaperSubViewpointAppraise.PaperSubViewpointAppraiseId].ToString().Trim()); //子观点评价Id
objPaperSubViewpointAppraiseEN.SubViewpointId = Int32.Parse(objRow[conPaperSubViewpointAppraise.SubViewpointId].ToString().Trim()); //子观点Id
objPaperSubViewpointAppraiseEN.AppraiseScore = objRow[conPaperSubViewpointAppraise.AppraiseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaperSubViewpointAppraise.AppraiseScore].ToString().Trim()); //打分
objPaperSubViewpointAppraiseEN.AppraiseContent = objRow[conPaperSubViewpointAppraise.AppraiseContent] == DBNull.Value ? null : objRow[conPaperSubViewpointAppraise.AppraiseContent].ToString().Trim(); //评议内容
objPaperSubViewpointAppraiseEN.UpdDate = objRow[conPaperSubViewpointAppraise.UpdDate] == DBNull.Value ? null : objRow[conPaperSubViewpointAppraise.UpdDate].ToString().Trim(); //修改日期
objPaperSubViewpointAppraiseEN.Meno = objRow[conPaperSubViewpointAppraise.Meno] == DBNull.Value ? null : objRow[conPaperSubViewpointAppraise.Meno].ToString().Trim(); //备注
objPaperSubViewpointAppraiseEN.UpdUser = objRow[conPaperSubViewpointAppraise.UpdUser] == DBNull.Value ? null : objRow[conPaperSubViewpointAppraise.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperSubViewpointAppraiseEN);
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
public static List<clsPaperSubViewpointAppraiseEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsPaperSubViewpointAppraiseEN> arrObjLst = new List<clsPaperSubViewpointAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN = new clsPaperSubViewpointAppraiseEN();
try
{
objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId = Int32.Parse(objRow[conPaperSubViewpointAppraise.PaperSubViewpointAppraiseId].ToString().Trim()); //子观点评价Id
objPaperSubViewpointAppraiseEN.SubViewpointId = Int32.Parse(objRow[conPaperSubViewpointAppraise.SubViewpointId].ToString().Trim()); //子观点Id
objPaperSubViewpointAppraiseEN.AppraiseScore = objRow[conPaperSubViewpointAppraise.AppraiseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaperSubViewpointAppraise.AppraiseScore].ToString().Trim()); //打分
objPaperSubViewpointAppraiseEN.AppraiseContent = objRow[conPaperSubViewpointAppraise.AppraiseContent] == DBNull.Value ? null : objRow[conPaperSubViewpointAppraise.AppraiseContent].ToString().Trim(); //评议内容
objPaperSubViewpointAppraiseEN.UpdDate = objRow[conPaperSubViewpointAppraise.UpdDate] == DBNull.Value ? null : objRow[conPaperSubViewpointAppraise.UpdDate].ToString().Trim(); //修改日期
objPaperSubViewpointAppraiseEN.Meno = objRow[conPaperSubViewpointAppraise.Meno] == DBNull.Value ? null : objRow[conPaperSubViewpointAppraise.Meno].ToString().Trim(); //备注
objPaperSubViewpointAppraiseEN.UpdUser = objRow[conPaperSubViewpointAppraise.UpdUser] == DBNull.Value ? null : objRow[conPaperSubViewpointAppraise.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperSubViewpointAppraiseEN);
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
List<clsPaperSubViewpointAppraiseEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsPaperSubViewpointAppraiseEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsPaperSubViewpointAppraiseEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsPaperSubViewpointAppraiseEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsPaperSubViewpointAppraiseEN> arrObjLst = new List<clsPaperSubViewpointAppraiseEN>(); 
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
	clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN = new clsPaperSubViewpointAppraiseEN();
try
{
objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId = Int32.Parse(objRow[conPaperSubViewpointAppraise.PaperSubViewpointAppraiseId].ToString().Trim()); //子观点评价Id
objPaperSubViewpointAppraiseEN.SubViewpointId = Int32.Parse(objRow[conPaperSubViewpointAppraise.SubViewpointId].ToString().Trim()); //子观点Id
objPaperSubViewpointAppraiseEN.AppraiseScore = objRow[conPaperSubViewpointAppraise.AppraiseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaperSubViewpointAppraise.AppraiseScore].ToString().Trim()); //打分
objPaperSubViewpointAppraiseEN.AppraiseContent = objRow[conPaperSubViewpointAppraise.AppraiseContent] == DBNull.Value ? null : objRow[conPaperSubViewpointAppraise.AppraiseContent].ToString().Trim(); //评议内容
objPaperSubViewpointAppraiseEN.UpdDate = objRow[conPaperSubViewpointAppraise.UpdDate] == DBNull.Value ? null : objRow[conPaperSubViewpointAppraise.UpdDate].ToString().Trim(); //修改日期
objPaperSubViewpointAppraiseEN.Meno = objRow[conPaperSubViewpointAppraise.Meno] == DBNull.Value ? null : objRow[conPaperSubViewpointAppraise.Meno].ToString().Trim(); //备注
objPaperSubViewpointAppraiseEN.UpdUser = objRow[conPaperSubViewpointAppraise.UpdUser] == DBNull.Value ? null : objRow[conPaperSubViewpointAppraise.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperSubViewpointAppraiseEN);
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
public static List<clsPaperSubViewpointAppraiseEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsPaperSubViewpointAppraiseEN> arrObjLst = new List<clsPaperSubViewpointAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN = new clsPaperSubViewpointAppraiseEN();
try
{
objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId = Int32.Parse(objRow[conPaperSubViewpointAppraise.PaperSubViewpointAppraiseId].ToString().Trim()); //子观点评价Id
objPaperSubViewpointAppraiseEN.SubViewpointId = Int32.Parse(objRow[conPaperSubViewpointAppraise.SubViewpointId].ToString().Trim()); //子观点Id
objPaperSubViewpointAppraiseEN.AppraiseScore = objRow[conPaperSubViewpointAppraise.AppraiseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaperSubViewpointAppraise.AppraiseScore].ToString().Trim()); //打分
objPaperSubViewpointAppraiseEN.AppraiseContent = objRow[conPaperSubViewpointAppraise.AppraiseContent] == DBNull.Value ? null : objRow[conPaperSubViewpointAppraise.AppraiseContent].ToString().Trim(); //评议内容
objPaperSubViewpointAppraiseEN.UpdDate = objRow[conPaperSubViewpointAppraise.UpdDate] == DBNull.Value ? null : objRow[conPaperSubViewpointAppraise.UpdDate].ToString().Trim(); //修改日期
objPaperSubViewpointAppraiseEN.Meno = objRow[conPaperSubViewpointAppraise.Meno] == DBNull.Value ? null : objRow[conPaperSubViewpointAppraise.Meno].ToString().Trim(); //备注
objPaperSubViewpointAppraiseEN.UpdUser = objRow[conPaperSubViewpointAppraise.UpdUser] == DBNull.Value ? null : objRow[conPaperSubViewpointAppraise.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperSubViewpointAppraiseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsPaperSubViewpointAppraiseEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsPaperSubViewpointAppraiseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsPaperSubViewpointAppraiseEN> arrObjLst = new List<clsPaperSubViewpointAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN = new clsPaperSubViewpointAppraiseEN();
try
{
objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId = Int32.Parse(objRow[conPaperSubViewpointAppraise.PaperSubViewpointAppraiseId].ToString().Trim()); //子观点评价Id
objPaperSubViewpointAppraiseEN.SubViewpointId = Int32.Parse(objRow[conPaperSubViewpointAppraise.SubViewpointId].ToString().Trim()); //子观点Id
objPaperSubViewpointAppraiseEN.AppraiseScore = objRow[conPaperSubViewpointAppraise.AppraiseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaperSubViewpointAppraise.AppraiseScore].ToString().Trim()); //打分
objPaperSubViewpointAppraiseEN.AppraiseContent = objRow[conPaperSubViewpointAppraise.AppraiseContent] == DBNull.Value ? null : objRow[conPaperSubViewpointAppraise.AppraiseContent].ToString().Trim(); //评议内容
objPaperSubViewpointAppraiseEN.UpdDate = objRow[conPaperSubViewpointAppraise.UpdDate] == DBNull.Value ? null : objRow[conPaperSubViewpointAppraise.UpdDate].ToString().Trim(); //修改日期
objPaperSubViewpointAppraiseEN.Meno = objRow[conPaperSubViewpointAppraise.Meno] == DBNull.Value ? null : objRow[conPaperSubViewpointAppraise.Meno].ToString().Trim(); //备注
objPaperSubViewpointAppraiseEN.UpdUser = objRow[conPaperSubViewpointAppraise.UpdUser] == DBNull.Value ? null : objRow[conPaperSubViewpointAppraise.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperSubViewpointAppraiseEN);
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
public static List<clsPaperSubViewpointAppraiseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsPaperSubViewpointAppraiseEN> arrObjLst = new List<clsPaperSubViewpointAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN = new clsPaperSubViewpointAppraiseEN();
try
{
objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId = Int32.Parse(objRow[conPaperSubViewpointAppraise.PaperSubViewpointAppraiseId].ToString().Trim()); //子观点评价Id
objPaperSubViewpointAppraiseEN.SubViewpointId = Int32.Parse(objRow[conPaperSubViewpointAppraise.SubViewpointId].ToString().Trim()); //子观点Id
objPaperSubViewpointAppraiseEN.AppraiseScore = objRow[conPaperSubViewpointAppraise.AppraiseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaperSubViewpointAppraise.AppraiseScore].ToString().Trim()); //打分
objPaperSubViewpointAppraiseEN.AppraiseContent = objRow[conPaperSubViewpointAppraise.AppraiseContent] == DBNull.Value ? null : objRow[conPaperSubViewpointAppraise.AppraiseContent].ToString().Trim(); //评议内容
objPaperSubViewpointAppraiseEN.UpdDate = objRow[conPaperSubViewpointAppraise.UpdDate] == DBNull.Value ? null : objRow[conPaperSubViewpointAppraise.UpdDate].ToString().Trim(); //修改日期
objPaperSubViewpointAppraiseEN.Meno = objRow[conPaperSubViewpointAppraise.Meno] == DBNull.Value ? null : objRow[conPaperSubViewpointAppraise.Meno].ToString().Trim(); //备注
objPaperSubViewpointAppraiseEN.UpdUser = objRow[conPaperSubViewpointAppraise.UpdUser] == DBNull.Value ? null : objRow[conPaperSubViewpointAppraise.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperSubViewpointAppraiseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsPaperSubViewpointAppraiseEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsPaperSubViewpointAppraiseEN> arrObjLst = new List<clsPaperSubViewpointAppraiseEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN = new clsPaperSubViewpointAppraiseEN();
try
{
objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId = Int32.Parse(objRow[conPaperSubViewpointAppraise.PaperSubViewpointAppraiseId].ToString().Trim()); //子观点评价Id
objPaperSubViewpointAppraiseEN.SubViewpointId = Int32.Parse(objRow[conPaperSubViewpointAppraise.SubViewpointId].ToString().Trim()); //子观点Id
objPaperSubViewpointAppraiseEN.AppraiseScore = objRow[conPaperSubViewpointAppraise.AppraiseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaperSubViewpointAppraise.AppraiseScore].ToString().Trim()); //打分
objPaperSubViewpointAppraiseEN.AppraiseContent = objRow[conPaperSubViewpointAppraise.AppraiseContent] == DBNull.Value ? null : objRow[conPaperSubViewpointAppraise.AppraiseContent].ToString().Trim(); //评议内容
objPaperSubViewpointAppraiseEN.UpdDate = objRow[conPaperSubViewpointAppraise.UpdDate] == DBNull.Value ? null : objRow[conPaperSubViewpointAppraise.UpdDate].ToString().Trim(); //修改日期
objPaperSubViewpointAppraiseEN.Meno = objRow[conPaperSubViewpointAppraise.Meno] == DBNull.Value ? null : objRow[conPaperSubViewpointAppraise.Meno].ToString().Trim(); //备注
objPaperSubViewpointAppraiseEN.UpdUser = objRow[conPaperSubViewpointAppraise.UpdUser] == DBNull.Value ? null : objRow[conPaperSubViewpointAppraise.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperSubViewpointAppraiseEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objPaperSubViewpointAppraiseEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetPaperSubViewpointAppraise(ref clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN)
{
bool bolResult = PaperSubViewpointAppraiseDA.GetPaperSubViewpointAppraise(ref objPaperSubViewpointAppraiseEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngPaperSubViewpointAppraiseId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPaperSubViewpointAppraiseEN GetObjByPaperSubViewpointAppraiseId(long lngPaperSubViewpointAppraiseId)
{
clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN = PaperSubViewpointAppraiseDA.GetObjByPaperSubViewpointAppraiseId(lngPaperSubViewpointAppraiseId);
return objPaperSubViewpointAppraiseEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsPaperSubViewpointAppraiseEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN = PaperSubViewpointAppraiseDA.GetFirstObj(strWhereCond);
 return objPaperSubViewpointAppraiseEN;
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
public static clsPaperSubViewpointAppraiseEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN = PaperSubViewpointAppraiseDA.GetObjByDataRow(objRow);
 return objPaperSubViewpointAppraiseEN;
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
public static clsPaperSubViewpointAppraiseEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN = PaperSubViewpointAppraiseDA.GetObjByDataRow(objRow);
 return objPaperSubViewpointAppraiseEN;
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
 /// <param name = "lngPaperSubViewpointAppraiseId">所给的关键字</param>
 /// <param name = "lstPaperSubViewpointAppraiseObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPaperSubViewpointAppraiseEN GetObjByPaperSubViewpointAppraiseIdFromList(long lngPaperSubViewpointAppraiseId, List<clsPaperSubViewpointAppraiseEN> lstPaperSubViewpointAppraiseObjLst)
{
foreach (clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN in lstPaperSubViewpointAppraiseObjLst)
{
if (objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId == lngPaperSubViewpointAppraiseId)
{
return objPaperSubViewpointAppraiseEN;
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
 long lngPaperSubViewpointAppraiseId;
 try
 {
 lngPaperSubViewpointAppraiseId = new clsPaperSubViewpointAppraiseDA().GetFirstID(strWhereCond);
 return lngPaperSubViewpointAppraiseId;
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
 arrList = PaperSubViewpointAppraiseDA.GetID(strWhereCond);
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
bool bolIsExist = PaperSubViewpointAppraiseDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngPaperSubViewpointAppraiseId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngPaperSubViewpointAppraiseId)
{
//检测记录是否存在
bool bolIsExist = PaperSubViewpointAppraiseDA.IsExist(lngPaperSubViewpointAppraiseId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngPaperSubViewpointAppraiseId">子观点评价Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngPaperSubViewpointAppraiseId, string strOpUser)
{
clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN = clsPaperSubViewpointAppraiseBL.GetObjByPaperSubViewpointAppraiseId(lngPaperSubViewpointAppraiseId);
objPaperSubViewpointAppraiseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
return clsPaperSubViewpointAppraiseBL.UpdateBySql2(objPaperSubViewpointAppraiseEN);
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
 bolIsExist = clsPaperSubViewpointAppraiseDA.IsExistTable();
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
 bolIsExist = PaperSubViewpointAppraiseDA.IsExistTable(strTabName);
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
 /// <param name = "objPaperSubViewpointAppraiseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objPaperSubViewpointAppraiseEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!子观点评价Id = [{0}]的数据已经存在!(in clsPaperSubViewpointAppraiseBL.AddNewRecordBySql2)", objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId);
throw new Exception(strMsg);
}
try
{
bool bolResult = PaperSubViewpointAppraiseDA.AddNewRecordBySQL2(objPaperSubViewpointAppraiseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubViewpointAppraiseBL.ReFreshCache();

if (clsPaperSubViewpointAppraiseBL.relatedActions != null)
{
clsPaperSubViewpointAppraiseBL.relatedActions.UpdRelaTabDate(objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId, "SetUpdDate");
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
 /// <param name = "objPaperSubViewpointAppraiseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objPaperSubViewpointAppraiseEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!子观点评价Id = [{0}]的数据已经存在!(in clsPaperSubViewpointAppraiseBL.AddNewRecordBySql2WithReturnKey)", objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId);
throw new Exception(strMsg);
}
try
{
string strKey = PaperSubViewpointAppraiseDA.AddNewRecordBySQL2WithReturnKey(objPaperSubViewpointAppraiseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubViewpointAppraiseBL.ReFreshCache();

if (clsPaperSubViewpointAppraiseBL.relatedActions != null)
{
clsPaperSubViewpointAppraiseBL.relatedActions.UpdRelaTabDate(objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId, "SetUpdDate");
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
 /// <param name = "objPaperSubViewpointAppraiseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN)
{
try
{
bool bolResult = PaperSubViewpointAppraiseDA.Update(objPaperSubViewpointAppraiseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubViewpointAppraiseBL.ReFreshCache();

if (clsPaperSubViewpointAppraiseBL.relatedActions != null)
{
clsPaperSubViewpointAppraiseBL.relatedActions.UpdRelaTabDate(objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId, "SetUpdDate");
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
 /// <param name = "objPaperSubViewpointAppraiseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN)
{
 if (objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = PaperSubViewpointAppraiseDA.UpdateBySql2(objPaperSubViewpointAppraiseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubViewpointAppraiseBL.ReFreshCache();

if (clsPaperSubViewpointAppraiseBL.relatedActions != null)
{
clsPaperSubViewpointAppraiseBL.relatedActions.UpdRelaTabDate(objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId, "SetUpdDate");
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
 /// <param name = "lngPaperSubViewpointAppraiseId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngPaperSubViewpointAppraiseId)
{
try
{
 clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN = clsPaperSubViewpointAppraiseBL.GetObjByPaperSubViewpointAppraiseId(lngPaperSubViewpointAppraiseId);

if (clsPaperSubViewpointAppraiseBL.relatedActions != null)
{
clsPaperSubViewpointAppraiseBL.relatedActions.UpdRelaTabDate(objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId, "SetUpdDate");
}
if (objPaperSubViewpointAppraiseEN != null)
{
int intRecNum = PaperSubViewpointAppraiseDA.DelRecord(lngPaperSubViewpointAppraiseId);
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
/// <param name="lngPaperSubViewpointAppraiseId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngPaperSubViewpointAppraiseId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPaperSubViewpointAppraiseDA.GetSpecSQLObj();
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
//删除与表:[PaperSubViewpointAppraise]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conPaperSubViewpointAppraise.PaperSubViewpointAppraiseId,
//lngPaperSubViewpointAppraiseId);
//        clsPaperSubViewpointAppraiseBL.DelPaperSubViewpointAppraisesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPaperSubViewpointAppraiseBL.DelRecord(lngPaperSubViewpointAppraiseId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPaperSubViewpointAppraiseBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngPaperSubViewpointAppraiseId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngPaperSubViewpointAppraiseId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngPaperSubViewpointAppraiseId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsPaperSubViewpointAppraiseBL.relatedActions != null)
{
clsPaperSubViewpointAppraiseBL.relatedActions.UpdRelaTabDate(lngPaperSubViewpointAppraiseId, "UpdRelaTabDate");
}
bool bolResult = PaperSubViewpointAppraiseDA.DelRecord(lngPaperSubViewpointAppraiseId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrPaperSubViewpointAppraiseIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelPaperSubViewpointAppraises(List<string> arrPaperSubViewpointAppraiseIdLst)
{
if (arrPaperSubViewpointAppraiseIdLst.Count == 0) return 0;
try
{
if (clsPaperSubViewpointAppraiseBL.relatedActions != null)
{
foreach (var strPaperSubViewpointAppraiseId in arrPaperSubViewpointAppraiseIdLst)
{
long lngPaperSubViewpointAppraiseId = long.Parse(strPaperSubViewpointAppraiseId);
clsPaperSubViewpointAppraiseBL.relatedActions.UpdRelaTabDate(lngPaperSubViewpointAppraiseId, "UpdRelaTabDate");
}
}
int intDelRecNum = PaperSubViewpointAppraiseDA.DelPaperSubViewpointAppraise(arrPaperSubViewpointAppraiseIdLst);
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
public static int DelPaperSubViewpointAppraisesByCond(string strWhereCond)
{
try
{
if (clsPaperSubViewpointAppraiseBL.relatedActions != null)
{
List<string> arrPaperSubViewpointAppraiseId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strPaperSubViewpointAppraiseId in arrPaperSubViewpointAppraiseId)
{
long lngPaperSubViewpointAppraiseId = long.Parse(strPaperSubViewpointAppraiseId);
clsPaperSubViewpointAppraiseBL.relatedActions.UpdRelaTabDate(lngPaperSubViewpointAppraiseId, "UpdRelaTabDate");
}
}
int intRecNum = PaperSubViewpointAppraiseDA.DelPaperSubViewpointAppraise(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[PaperSubViewpointAppraise]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngPaperSubViewpointAppraiseId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngPaperSubViewpointAppraiseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPaperSubViewpointAppraiseDA.GetSpecSQLObj();
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
//删除与表:[PaperSubViewpointAppraise]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPaperSubViewpointAppraiseBL.DelRecord(lngPaperSubViewpointAppraiseId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPaperSubViewpointAppraiseBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngPaperSubViewpointAppraiseId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objPaperSubViewpointAppraiseENS">源对象</param>
 /// <param name = "objPaperSubViewpointAppraiseENT">目标对象</param>
 public static void CopyTo(clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseENS, clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseENT)
{
try
{
objPaperSubViewpointAppraiseENT.PaperSubViewpointAppraiseId = objPaperSubViewpointAppraiseENS.PaperSubViewpointAppraiseId; //子观点评价Id
objPaperSubViewpointAppraiseENT.SubViewpointId = objPaperSubViewpointAppraiseENS.SubViewpointId; //子观点Id
objPaperSubViewpointAppraiseENT.AppraiseScore = objPaperSubViewpointAppraiseENS.AppraiseScore; //打分
objPaperSubViewpointAppraiseENT.AppraiseContent = objPaperSubViewpointAppraiseENS.AppraiseContent; //评议内容
objPaperSubViewpointAppraiseENT.UpdDate = objPaperSubViewpointAppraiseENS.UpdDate; //修改日期
objPaperSubViewpointAppraiseENT.Meno = objPaperSubViewpointAppraiseENS.Meno; //备注
objPaperSubViewpointAppraiseENT.UpdUser = objPaperSubViewpointAppraiseENS.UpdUser; //修改人
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
 /// <param name = "objPaperSubViewpointAppraiseEN">源简化对象</param>
 public static void SetUpdFlag(clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN)
{
try
{
objPaperSubViewpointAppraiseEN.ClearUpdateState();
   string strsfUpdFldSetStr = objPaperSubViewpointAppraiseEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conPaperSubViewpointAppraise.PaperSubViewpointAppraiseId, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId = objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId; //子观点评价Id
}
if (arrFldSet.Contains(conPaperSubViewpointAppraise.SubViewpointId, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubViewpointAppraiseEN.SubViewpointId = objPaperSubViewpointAppraiseEN.SubViewpointId; //子观点Id
}
if (arrFldSet.Contains(conPaperSubViewpointAppraise.AppraiseScore, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubViewpointAppraiseEN.AppraiseScore = objPaperSubViewpointAppraiseEN.AppraiseScore; //打分
}
if (arrFldSet.Contains(conPaperSubViewpointAppraise.AppraiseContent, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubViewpointAppraiseEN.AppraiseContent = objPaperSubViewpointAppraiseEN.AppraiseContent == "[null]" ? null :  objPaperSubViewpointAppraiseEN.AppraiseContent; //评议内容
}
if (arrFldSet.Contains(conPaperSubViewpointAppraise.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubViewpointAppraiseEN.UpdDate = objPaperSubViewpointAppraiseEN.UpdDate == "[null]" ? null :  objPaperSubViewpointAppraiseEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conPaperSubViewpointAppraise.Meno, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubViewpointAppraiseEN.Meno = objPaperSubViewpointAppraiseEN.Meno == "[null]" ? null :  objPaperSubViewpointAppraiseEN.Meno; //备注
}
if (arrFldSet.Contains(conPaperSubViewpointAppraise.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubViewpointAppraiseEN.UpdUser = objPaperSubViewpointAppraiseEN.UpdUser == "[null]" ? null :  objPaperSubViewpointAppraiseEN.UpdUser; //修改人
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
 /// <param name = "objPaperSubViewpointAppraiseEN">源简化对象</param>
 public static void AccessFldValueNull(clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN)
{
try
{
if (objPaperSubViewpointAppraiseEN.AppraiseContent == "[null]") objPaperSubViewpointAppraiseEN.AppraiseContent = null; //评议内容
if (objPaperSubViewpointAppraiseEN.UpdDate == "[null]") objPaperSubViewpointAppraiseEN.UpdDate = null; //修改日期
if (objPaperSubViewpointAppraiseEN.Meno == "[null]") objPaperSubViewpointAppraiseEN.Meno = null; //备注
if (objPaperSubViewpointAppraiseEN.UpdUser == "[null]") objPaperSubViewpointAppraiseEN.UpdUser = null; //修改人
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
public static void CheckPropertyNew(clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN)
{
 PaperSubViewpointAppraiseDA.CheckPropertyNew(objPaperSubViewpointAppraiseEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN)
{
 PaperSubViewpointAppraiseDA.CheckProperty4Condition(objPaperSubViewpointAppraiseEN);
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
if (clsPaperSubViewpointAppraiseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperSubViewpointAppraiseBL没有刷新缓存机制(clsPaperSubViewpointAppraiseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PaperSubViewpointAppraiseId");
//if (arrPaperSubViewpointAppraiseObjLstCache == null)
//{
//arrPaperSubViewpointAppraiseObjLstCache = PaperSubViewpointAppraiseDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngPaperSubViewpointAppraiseId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPaperSubViewpointAppraiseEN GetObjByPaperSubViewpointAppraiseIdCache(long lngPaperSubViewpointAppraiseId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsPaperSubViewpointAppraiseEN._CurrTabName);
List<clsPaperSubViewpointAppraiseEN> arrPaperSubViewpointAppraiseObjLstCache = GetObjLstCache();
IEnumerable <clsPaperSubViewpointAppraiseEN> arrPaperSubViewpointAppraiseObjLst_Sel =
arrPaperSubViewpointAppraiseObjLstCache
.Where(x=> x.PaperSubViewpointAppraiseId == lngPaperSubViewpointAppraiseId 
);
if (arrPaperSubViewpointAppraiseObjLst_Sel.Count() == 0)
{
   clsPaperSubViewpointAppraiseEN obj = clsPaperSubViewpointAppraiseBL.GetObjByPaperSubViewpointAppraiseId(lngPaperSubViewpointAppraiseId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrPaperSubViewpointAppraiseObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPaperSubViewpointAppraiseEN> GetAllPaperSubViewpointAppraiseObjLstCache()
{
//获取缓存中的对象列表
List<clsPaperSubViewpointAppraiseEN> arrPaperSubViewpointAppraiseObjLstCache = GetObjLstCache(); 
return arrPaperSubViewpointAppraiseObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPaperSubViewpointAppraiseEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsPaperSubViewpointAppraiseEN._CurrTabName);
List<clsPaperSubViewpointAppraiseEN> arrPaperSubViewpointAppraiseObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrPaperSubViewpointAppraiseObjLstCache;
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
string strKey = string.Format("{0}", clsPaperSubViewpointAppraiseEN._CurrTabName);
CacheHelper.Remove(strKey);
clsPaperSubViewpointAppraiseEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsPaperSubViewpointAppraiseEN._RefreshTimeLst.Count == 0) return "";
return clsPaperSubViewpointAppraiseEN._RefreshTimeLst[clsPaperSubViewpointAppraiseEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsPaperSubViewpointAppraiseBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsPaperSubViewpointAppraiseEN._CurrTabName);
CacheHelper.Remove(strKey);
clsPaperSubViewpointAppraiseEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsPaperSubViewpointAppraiseBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--PaperSubViewpointAppraise(子观点评论表)
 /// 唯一性条件:PaperSubViewpointAppraiseId_SuvViewpointId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objPaperSubViewpointAppraiseEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN)
{
//检测记录是否存在
string strResult = PaperSubViewpointAppraiseDA.GetUniCondStr(objPaperSubViewpointAppraiseEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngPaperSubViewpointAppraiseId)
{
if (strInFldName != conPaperSubViewpointAppraise.PaperSubViewpointAppraiseId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conPaperSubViewpointAppraise.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conPaperSubViewpointAppraise.AttributeName));
throw new Exception(strMsg);
}
var objPaperSubViewpointAppraise = clsPaperSubViewpointAppraiseBL.GetObjByPaperSubViewpointAppraiseIdCache(lngPaperSubViewpointAppraiseId);
if (objPaperSubViewpointAppraise == null) return "";
return objPaperSubViewpointAppraise[strOutFldName].ToString();
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
int intRecCount = clsPaperSubViewpointAppraiseDA.GetRecCount(strTabName);
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
int intRecCount = clsPaperSubViewpointAppraiseDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsPaperSubViewpointAppraiseDA.GetRecCount();
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
int intRecCount = clsPaperSubViewpointAppraiseDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objPaperSubViewpointAppraiseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseCond)
{
List<clsPaperSubViewpointAppraiseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsPaperSubViewpointAppraiseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPaperSubViewpointAppraise.AttributeName)
{
if (objPaperSubViewpointAppraiseCond.IsUpdated(strFldName) == false) continue;
if (objPaperSubViewpointAppraiseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPaperSubViewpointAppraiseCond[strFldName].ToString());
}
else
{
if (objPaperSubViewpointAppraiseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPaperSubViewpointAppraiseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPaperSubViewpointAppraiseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPaperSubViewpointAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPaperSubViewpointAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPaperSubViewpointAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPaperSubViewpointAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPaperSubViewpointAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPaperSubViewpointAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPaperSubViewpointAppraiseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPaperSubViewpointAppraiseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPaperSubViewpointAppraiseCond[strFldName]));
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
 List<string> arrList = clsPaperSubViewpointAppraiseDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = PaperSubViewpointAppraiseDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = PaperSubViewpointAppraiseDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = PaperSubViewpointAppraiseDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsPaperSubViewpointAppraiseDA.SetFldValue(clsPaperSubViewpointAppraiseEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = PaperSubViewpointAppraiseDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsPaperSubViewpointAppraiseDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsPaperSubViewpointAppraiseDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsPaperSubViewpointAppraiseDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[PaperSubViewpointAppraise] "); 
 strCreateTabCode.Append(" ( "); 
 // /**子观点评价Id*/ 
 strCreateTabCode.Append(" PaperSubViewpointAppraiseId bigint primary key identity, "); 
 // /**子观点Id*/ 
 strCreateTabCode.Append(" SubViewpointId bigint not Null, "); 
 // /**打分*/ 
 strCreateTabCode.Append(" AppraiseScore float Null, "); 
 // /**评议内容*/ 
 strCreateTabCode.Append(" AppraiseContent varchar(2000) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Meno varchar(2000) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 子观点评论表(PaperSubViewpointAppraise)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4PaperSubViewpointAppraise : clsCommFun4BL
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
clsPaperSubViewpointAppraiseBL.ReFreshThisCache();
}
}

}