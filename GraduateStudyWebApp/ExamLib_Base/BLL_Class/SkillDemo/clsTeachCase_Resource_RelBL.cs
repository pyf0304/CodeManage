﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTeachCase_Resource_RelBL
 表名:TeachCase_Resource_Rel(01120511)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:43:41
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:技能示范(SkillDemo)
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
public static class  clsTeachCase_Resource_RelBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdTeachCaseResourceRel">表关键字</param>
 /// <returns>表对象</returns>
public static clsTeachCase_Resource_RelEN GetObj(this K_IdTeachCaseResourceRel_TeachCase_Resource_Rel myKey)
{
clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN = clsTeachCase_Resource_RelBL.TeachCase_Resource_RelDA.GetObjByIdTeachCaseResourceRel(myKey.Value);
return objTeachCase_Resource_RelEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objTeachCase_Resource_RelEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN)
{
if (CheckUniqueness(objTeachCase_Resource_RelEN) == false)
{
var strMsg = string.Format("记录已经存在!案例流水号 = [{0}],资源流水号 = [{1}]的数据已经存在!(in clsTeachCase_Resource_RelBL.AddNewRecord)", objTeachCase_Resource_RelEN.IdTeachCase,objTeachCase_Resource_RelEN.IdResource);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsTeachCase_Resource_RelBL.TeachCase_Resource_RelDA.AddNewRecordBySQL2(objTeachCase_Resource_RelEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachCase_Resource_RelBL.ReFreshCache();

if (clsTeachCase_Resource_RelBL.relatedActions != null)
{
clsTeachCase_Resource_RelBL.relatedActions.UpdRelaTabDate(objTeachCase_Resource_RelEN.IdTeachCaseResourceRel, "SetUpdDate");
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
public static bool AddRecordEx(this clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN)
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
objTeachCase_Resource_RelEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objTeachCase_Resource_RelEN.CheckUniqueness() == false)
{
strMsg = string.Format("(案例流水号(IdTeachCase)=[{0}],资源流水号(IdResource)=[{1}])已经存在,不能重复!", objTeachCase_Resource_RelEN.IdTeachCase, objTeachCase_Resource_RelEN.IdResource);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objTeachCase_Resource_RelEN.AddNewRecord();
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
 /// <param name = "objTeachCase_Resource_RelEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN)
{
if (CheckUniqueness(objTeachCase_Resource_RelEN) == false)
{
var strMsg = string.Format("记录已经存在!案例流水号 = [{0}],资源流水号 = [{1}]的数据已经存在!(in clsTeachCase_Resource_RelBL.AddNewRecordWithReturnKey)", objTeachCase_Resource_RelEN.IdTeachCase,objTeachCase_Resource_RelEN.IdResource);
throw new Exception(strMsg);
}
try
{
string strKey = clsTeachCase_Resource_RelBL.TeachCase_Resource_RelDA.AddNewRecordBySQL2WithReturnKey(objTeachCase_Resource_RelEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachCase_Resource_RelBL.ReFreshCache();

if (clsTeachCase_Resource_RelBL.relatedActions != null)
{
clsTeachCase_Resource_RelBL.relatedActions.UpdRelaTabDate(objTeachCase_Resource_RelEN.IdTeachCaseResourceRel, "SetUpdDate");
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
 /// <param name = "objTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachCase_Resource_RelEN SetIdTeachCaseResourceRel(this clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN, long lngIdTeachCaseResourceRel, string strComparisonOp="")
	{
objTeachCase_Resource_RelEN.IdTeachCaseResourceRel = lngIdTeachCaseResourceRel; //案例与资源表系表流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(conTeachCase_Resource_Rel.IdTeachCaseResourceRel) == false)
{
objTeachCase_Resource_RelEN.dicFldComparisonOp.Add(conTeachCase_Resource_Rel.IdTeachCaseResourceRel, strComparisonOp);
}
else
{
objTeachCase_Resource_RelEN.dicFldComparisonOp[conTeachCase_Resource_Rel.IdTeachCaseResourceRel] = strComparisonOp;
}
}
return objTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachCase_Resource_RelEN SetIdTeachCase(this clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN, string strIdTeachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdTeachCase, conTeachCase_Resource_Rel.IdTeachCase);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachCase, 8, conTeachCase_Resource_Rel.IdTeachCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachCase, 8, conTeachCase_Resource_Rel.IdTeachCase);
}
objTeachCase_Resource_RelEN.IdTeachCase = strIdTeachCase; //案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(conTeachCase_Resource_Rel.IdTeachCase) == false)
{
objTeachCase_Resource_RelEN.dicFldComparisonOp.Add(conTeachCase_Resource_Rel.IdTeachCase, strComparisonOp);
}
else
{
objTeachCase_Resource_RelEN.dicFldComparisonOp[conTeachCase_Resource_Rel.IdTeachCase] = strComparisonOp;
}
}
return objTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachCase_Resource_RelEN SetIdResource(this clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN, string strIdResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdResource, conTeachCase_Resource_Rel.IdResource);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdResource, 8, conTeachCase_Resource_Rel.IdResource);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdResource, 8, conTeachCase_Resource_Rel.IdResource);
}
objTeachCase_Resource_RelEN.IdResource = strIdResource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(conTeachCase_Resource_Rel.IdResource) == false)
{
objTeachCase_Resource_RelEN.dicFldComparisonOp.Add(conTeachCase_Resource_Rel.IdResource, strComparisonOp);
}
else
{
objTeachCase_Resource_RelEN.dicFldComparisonOp[conTeachCase_Resource_Rel.IdResource] = strComparisonOp;
}
}
return objTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachCase_Resource_RelEN SetIsMain(this clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN, bool bolIsMain, string strComparisonOp="")
	{
objTeachCase_Resource_RelEN.IsMain = bolIsMain; //是否主资源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(conTeachCase_Resource_Rel.IsMain) == false)
{
objTeachCase_Resource_RelEN.dicFldComparisonOp.Add(conTeachCase_Resource_Rel.IsMain, strComparisonOp);
}
else
{
objTeachCase_Resource_RelEN.dicFldComparisonOp[conTeachCase_Resource_Rel.IsMain] = strComparisonOp;
}
}
return objTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachCase_Resource_RelEN SetMemo(this clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conTeachCase_Resource_Rel.Memo);
}
objTeachCase_Resource_RelEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(conTeachCase_Resource_Rel.Memo) == false)
{
objTeachCase_Resource_RelEN.dicFldComparisonOp.Add(conTeachCase_Resource_Rel.Memo, strComparisonOp);
}
else
{
objTeachCase_Resource_RelEN.dicFldComparisonOp[conTeachCase_Resource_Rel.Memo] = strComparisonOp;
}
}
return objTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachCase_Resource_RelEN SetIndexNO(this clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN, int? intIndexNO, string strComparisonOp="")
	{
objTeachCase_Resource_RelEN.IndexNO = intIndexNO; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(conTeachCase_Resource_Rel.IndexNO) == false)
{
objTeachCase_Resource_RelEN.dicFldComparisonOp.Add(conTeachCase_Resource_Rel.IndexNO, strComparisonOp);
}
else
{
objTeachCase_Resource_RelEN.dicFldComparisonOp[conTeachCase_Resource_Rel.IndexNO] = strComparisonOp;
}
}
return objTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachCase_Resource_RelEN SetIsVisible(this clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN, bool bolIsVisible, string strComparisonOp="")
	{
objTeachCase_Resource_RelEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(conTeachCase_Resource_Rel.IsVisible) == false)
{
objTeachCase_Resource_RelEN.dicFldComparisonOp.Add(conTeachCase_Resource_Rel.IsVisible, strComparisonOp);
}
else
{
objTeachCase_Resource_RelEN.dicFldComparisonOp[conTeachCase_Resource_Rel.IsVisible] = strComparisonOp;
}
}
return objTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachCase_Resource_RelEN SetBrowseCount(this clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN, int? intBrowseCount, string strComparisonOp="")
	{
objTeachCase_Resource_RelEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(conTeachCase_Resource_Rel.BrowseCount) == false)
{
objTeachCase_Resource_RelEN.dicFldComparisonOp.Add(conTeachCase_Resource_Rel.BrowseCount, strComparisonOp);
}
else
{
objTeachCase_Resource_RelEN.dicFldComparisonOp[conTeachCase_Resource_Rel.BrowseCount] = strComparisonOp;
}
}
return objTeachCase_Resource_RelEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objTeachCase_Resource_RelEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objTeachCase_Resource_RelEN.CheckPropertyNew();
clsTeachCase_Resource_RelEN objTeachCase_Resource_RelCond = new clsTeachCase_Resource_RelEN();
string strCondition = objTeachCase_Resource_RelCond
.SetIdTeachCaseResourceRel(objTeachCase_Resource_RelEN.IdTeachCaseResourceRel, "<>")
.SetIdTeachCase(objTeachCase_Resource_RelEN.IdTeachCase, "=")
.SetIdResource(objTeachCase_Resource_RelEN.IdResource, "=")
.GetCombineCondition();
objTeachCase_Resource_RelEN._IsCheckProperty = true;
bool bolIsExist = clsTeachCase_Resource_RelBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(id_TeachCase_id_Resource)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objTeachCase_Resource_RelEN.Update();
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
 /// <param name = "objTeachCase_Resource_Rel">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsTeachCase_Resource_RelEN objTeachCase_Resource_Rel)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsTeachCase_Resource_RelEN objTeachCase_Resource_RelCond = new clsTeachCase_Resource_RelEN();
string strCondition = objTeachCase_Resource_RelCond
.SetIdTeachCase(objTeachCase_Resource_Rel.IdTeachCase, "=")
.SetIdResource(objTeachCase_Resource_Rel.IdResource, "=")
.GetCombineCondition();
objTeachCase_Resource_Rel._IsCheckProperty = true;
bool bolIsExist = clsTeachCase_Resource_RelBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objTeachCase_Resource_Rel.IdTeachCaseResourceRel = clsTeachCase_Resource_RelBL.GetFirstID_S(strCondition);
objTeachCase_Resource_Rel.UpdateWithCondition(strCondition);
}
else
{
objTeachCase_Resource_Rel.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objTeachCase_Resource_RelEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN)
{
 if (objTeachCase_Resource_RelEN.IdTeachCaseResourceRel == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsTeachCase_Resource_RelBL.TeachCase_Resource_RelDA.UpdateBySql2(objTeachCase_Resource_RelEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachCase_Resource_RelBL.ReFreshCache();

if (clsTeachCase_Resource_RelBL.relatedActions != null)
{
clsTeachCase_Resource_RelBL.relatedActions.UpdRelaTabDate(objTeachCase_Resource_RelEN.IdTeachCaseResourceRel, "SetUpdDate");
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
 /// <param name = "objTeachCase_Resource_RelEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objTeachCase_Resource_RelEN.IdTeachCaseResourceRel == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsTeachCase_Resource_RelBL.TeachCase_Resource_RelDA.UpdateBySql2(objTeachCase_Resource_RelEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachCase_Resource_RelBL.ReFreshCache();

if (clsTeachCase_Resource_RelBL.relatedActions != null)
{
clsTeachCase_Resource_RelBL.relatedActions.UpdRelaTabDate(objTeachCase_Resource_RelEN.IdTeachCaseResourceRel, "SetUpdDate");
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
 /// <param name = "objTeachCase_Resource_RelEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN, string strWhereCond)
{
try
{
bool bolResult = clsTeachCase_Resource_RelBL.TeachCase_Resource_RelDA.UpdateBySqlWithCondition(objTeachCase_Resource_RelEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachCase_Resource_RelBL.ReFreshCache();

if (clsTeachCase_Resource_RelBL.relatedActions != null)
{
clsTeachCase_Resource_RelBL.relatedActions.UpdRelaTabDate(objTeachCase_Resource_RelEN.IdTeachCaseResourceRel, "SetUpdDate");
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
 /// <param name = "objTeachCase_Resource_RelEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsTeachCase_Resource_RelBL.TeachCase_Resource_RelDA.UpdateBySqlWithConditionTransaction(objTeachCase_Resource_RelEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachCase_Resource_RelBL.ReFreshCache();

if (clsTeachCase_Resource_RelBL.relatedActions != null)
{
clsTeachCase_Resource_RelBL.relatedActions.UpdRelaTabDate(objTeachCase_Resource_RelEN.IdTeachCaseResourceRel, "SetUpdDate");
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
 /// <param name = "lngIdTeachCaseResourceRel">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN)
{
try
{
int intRecNum = clsTeachCase_Resource_RelBL.TeachCase_Resource_RelDA.DelRecord(objTeachCase_Resource_RelEN.IdTeachCaseResourceRel);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachCase_Resource_RelBL.ReFreshCache();

if (clsTeachCase_Resource_RelBL.relatedActions != null)
{
clsTeachCase_Resource_RelBL.relatedActions.UpdRelaTabDate(objTeachCase_Resource_RelEN.IdTeachCaseResourceRel, "SetUpdDate");
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
 /// <param name = "objTeachCase_Resource_RelENS">源对象</param>
 /// <param name = "objTeachCase_Resource_RelENT">目标对象</param>
 public static void CopyTo(this clsTeachCase_Resource_RelEN objTeachCase_Resource_RelENS, clsTeachCase_Resource_RelEN objTeachCase_Resource_RelENT)
{
try
{
objTeachCase_Resource_RelENT.IdTeachCaseResourceRel = objTeachCase_Resource_RelENS.IdTeachCaseResourceRel; //案例与资源表系表流水号
objTeachCase_Resource_RelENT.IdTeachCase = objTeachCase_Resource_RelENS.IdTeachCase; //案例流水号
objTeachCase_Resource_RelENT.IdResource = objTeachCase_Resource_RelENS.IdResource; //资源流水号
objTeachCase_Resource_RelENT.IsMain = objTeachCase_Resource_RelENS.IsMain; //是否主资源
objTeachCase_Resource_RelENT.Memo = objTeachCase_Resource_RelENS.Memo; //备注
objTeachCase_Resource_RelENT.IndexNO = objTeachCase_Resource_RelENS.IndexNO; //序号
objTeachCase_Resource_RelENT.IsVisible = objTeachCase_Resource_RelENS.IsVisible; //是否显示
objTeachCase_Resource_RelENT.BrowseCount = objTeachCase_Resource_RelENS.BrowseCount; //浏览次数
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
 /// <param name = "objTeachCase_Resource_RelENS">源对象</param>
 /// <returns>目标对象=>clsTeachCase_Resource_RelEN:objTeachCase_Resource_RelENT</returns>
 public static clsTeachCase_Resource_RelEN CopyTo(this clsTeachCase_Resource_RelEN objTeachCase_Resource_RelENS)
{
try
{
 clsTeachCase_Resource_RelEN objTeachCase_Resource_RelENT = new clsTeachCase_Resource_RelEN()
{
IdTeachCaseResourceRel = objTeachCase_Resource_RelENS.IdTeachCaseResourceRel, //案例与资源表系表流水号
IdTeachCase = objTeachCase_Resource_RelENS.IdTeachCase, //案例流水号
IdResource = objTeachCase_Resource_RelENS.IdResource, //资源流水号
IsMain = objTeachCase_Resource_RelENS.IsMain, //是否主资源
Memo = objTeachCase_Resource_RelENS.Memo, //备注
IndexNO = objTeachCase_Resource_RelENS.IndexNO, //序号
IsVisible = objTeachCase_Resource_RelENS.IsVisible, //是否显示
BrowseCount = objTeachCase_Resource_RelENS.BrowseCount, //浏览次数
};
 return objTeachCase_Resource_RelENT;
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
public static void CheckPropertyNew(this clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN)
{
 clsTeachCase_Resource_RelBL.TeachCase_Resource_RelDA.CheckPropertyNew(objTeachCase_Resource_RelEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN)
{
 clsTeachCase_Resource_RelBL.TeachCase_Resource_RelDA.CheckProperty4Condition(objTeachCase_Resource_RelEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsTeachCase_Resource_RelEN objTeachCase_Resource_RelCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objTeachCase_Resource_RelCond.IsUpdated(conTeachCase_Resource_Rel.IdTeachCaseResourceRel) == true)
{
string strComparisonOpIdTeachCaseResourceRel = objTeachCase_Resource_RelCond.dicFldComparisonOp[conTeachCase_Resource_Rel.IdTeachCaseResourceRel];
strWhereCond += string.Format(" And {0} {2} {1}", conTeachCase_Resource_Rel.IdTeachCaseResourceRel, objTeachCase_Resource_RelCond.IdTeachCaseResourceRel, strComparisonOpIdTeachCaseResourceRel);
}
if (objTeachCase_Resource_RelCond.IsUpdated(conTeachCase_Resource_Rel.IdTeachCase) == true)
{
string strComparisonOpIdTeachCase = objTeachCase_Resource_RelCond.dicFldComparisonOp[conTeachCase_Resource_Rel.IdTeachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachCase_Resource_Rel.IdTeachCase, objTeachCase_Resource_RelCond.IdTeachCase, strComparisonOpIdTeachCase);
}
if (objTeachCase_Resource_RelCond.IsUpdated(conTeachCase_Resource_Rel.IdResource) == true)
{
string strComparisonOpIdResource = objTeachCase_Resource_RelCond.dicFldComparisonOp[conTeachCase_Resource_Rel.IdResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachCase_Resource_Rel.IdResource, objTeachCase_Resource_RelCond.IdResource, strComparisonOpIdResource);
}
if (objTeachCase_Resource_RelCond.IsUpdated(conTeachCase_Resource_Rel.IsMain) == true)
{
if (objTeachCase_Resource_RelCond.IsMain == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTeachCase_Resource_Rel.IsMain);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTeachCase_Resource_Rel.IsMain);
}
}
if (objTeachCase_Resource_RelCond.IsUpdated(conTeachCase_Resource_Rel.Memo) == true)
{
string strComparisonOpMemo = objTeachCase_Resource_RelCond.dicFldComparisonOp[conTeachCase_Resource_Rel.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachCase_Resource_Rel.Memo, objTeachCase_Resource_RelCond.Memo, strComparisonOpMemo);
}
if (objTeachCase_Resource_RelCond.IsUpdated(conTeachCase_Resource_Rel.IndexNO) == true)
{
string strComparisonOpIndexNO = objTeachCase_Resource_RelCond.dicFldComparisonOp[conTeachCase_Resource_Rel.IndexNO];
strWhereCond += string.Format(" And {0} {2} {1}", conTeachCase_Resource_Rel.IndexNO, objTeachCase_Resource_RelCond.IndexNO, strComparisonOpIndexNO);
}
if (objTeachCase_Resource_RelCond.IsUpdated(conTeachCase_Resource_Rel.IsVisible) == true)
{
if (objTeachCase_Resource_RelCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTeachCase_Resource_Rel.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTeachCase_Resource_Rel.IsVisible);
}
}
if (objTeachCase_Resource_RelCond.IsUpdated(conTeachCase_Resource_Rel.BrowseCount) == true)
{
string strComparisonOpBrowseCount = objTeachCase_Resource_RelCond.dicFldComparisonOp[conTeachCase_Resource_Rel.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conTeachCase_Resource_Rel.BrowseCount, objTeachCase_Resource_RelCond.BrowseCount, strComparisonOpBrowseCount);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--TeachCase_Resource_Rel(案例与资源表系), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:id_TeachCase_id_Resource
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objTeachCase_Resource_RelEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objTeachCase_Resource_RelEN == null) return true;
if (objTeachCase_Resource_RelEN.IdTeachCaseResourceRel == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdTeachCase = '{0}'", objTeachCase_Resource_RelEN.IdTeachCase);
 sbCondition.AppendFormat(" and IdResource = '{0}'", objTeachCase_Resource_RelEN.IdResource);
if (clsTeachCase_Resource_RelBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("IdTeachCaseResourceRel !=  {0}", objTeachCase_Resource_RelEN.IdTeachCaseResourceRel);
 sbCondition.AppendFormat(" and IdTeachCase = '{0}'", objTeachCase_Resource_RelEN.IdTeachCase);
 sbCondition.AppendFormat(" and IdResource = '{0}'", objTeachCase_Resource_RelEN.IdResource);
if (clsTeachCase_Resource_RelBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--TeachCase_Resource_Rel(案例与资源表系), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:id_TeachCase_id_Resource
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objTeachCase_Resource_RelEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objTeachCase_Resource_RelEN == null) return "";
if (objTeachCase_Resource_RelEN.IdTeachCaseResourceRel == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdTeachCase = '{0}'", objTeachCase_Resource_RelEN.IdTeachCase);
 sbCondition.AppendFormat(" and IdResource = '{0}'", objTeachCase_Resource_RelEN.IdResource);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("IdTeachCaseResourceRel !=  {0}", objTeachCase_Resource_RelEN.IdTeachCaseResourceRel);
 sbCondition.AppendFormat(" and IdTeachCase = '{0}'", objTeachCase_Resource_RelEN.IdTeachCase);
 sbCondition.AppendFormat(" and IdResource = '{0}'", objTeachCase_Resource_RelEN.IdResource);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_TeachCase_Resource_Rel
{
public virtual bool UpdRelaTabDate(long lngIdTeachCaseResourceRel, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 案例与资源表系(TeachCase_Resource_Rel)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsTeachCase_Resource_RelBL
{
public static RelatedActions_TeachCase_Resource_Rel relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsTeachCase_Resource_RelDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsTeachCase_Resource_RelDA TeachCase_Resource_RelDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsTeachCase_Resource_RelDA();
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
 public clsTeachCase_Resource_RelBL()
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
if (string.IsNullOrEmpty(clsTeachCase_Resource_RelEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsTeachCase_Resource_RelEN._ConnectString);
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
public static DataTable GetDataTable_TeachCase_Resource_Rel(string strWhereCond)
{
DataTable objDT;
try
{
objDT = TeachCase_Resource_RelDA.GetDataTable_TeachCase_Resource_Rel(strWhereCond);
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
objDT = TeachCase_Resource_RelDA.GetDataTable(strWhereCond);
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
objDT = TeachCase_Resource_RelDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = TeachCase_Resource_RelDA.GetDataTable(strWhereCond, strTabName);
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
objDT = TeachCase_Resource_RelDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = TeachCase_Resource_RelDA.GetDataTable_Top(objTopPara);
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
objDT = TeachCase_Resource_RelDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = TeachCase_Resource_RelDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = TeachCase_Resource_RelDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdTeachCaseResourceRelLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsTeachCase_Resource_RelEN> GetObjLstByIdTeachCaseResourceRelLst(List<long> arrIdTeachCaseResourceRelLst)
{
List<clsTeachCase_Resource_RelEN> arrObjLst = new List<clsTeachCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdTeachCaseResourceRelLst);
 string strWhereCond = string.Format("IdTeachCaseResourceRel in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN = new clsTeachCase_Resource_RelEN();
try
{
objTeachCase_Resource_RelEN.IdTeachCaseResourceRel = Int32.Parse(objRow[conTeachCase_Resource_Rel.IdTeachCaseResourceRel].ToString().Trim()); //案例与资源表系表流水号
objTeachCase_Resource_RelEN.IdTeachCase = objRow[conTeachCase_Resource_Rel.IdTeachCase].ToString().Trim(); //案例流水号
objTeachCase_Resource_RelEN.IdResource = objRow[conTeachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objTeachCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[conTeachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objTeachCase_Resource_RelEN.Memo = objRow[conTeachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[conTeachCase_Resource_Rel.Memo].ToString().Trim(); //备注
objTeachCase_Resource_RelEN.IndexNO = objRow[conTeachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objTeachCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conTeachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objTeachCase_Resource_RelEN.BrowseCount = objRow[conTeachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTeachCase_Resource_RelEN.IdTeachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTeachCase_Resource_RelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdTeachCaseResourceRelLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsTeachCase_Resource_RelEN> GetObjLstByIdTeachCaseResourceRelLstCache(List<long> arrIdTeachCaseResourceRelLst)
{
string strKey = string.Format("{0}", clsTeachCase_Resource_RelEN._CurrTabName);
List<clsTeachCase_Resource_RelEN> arrTeachCase_Resource_RelObjLstCache = GetObjLstCache();
IEnumerable <clsTeachCase_Resource_RelEN> arrTeachCase_Resource_RelObjLst_Sel =
arrTeachCase_Resource_RelObjLstCache
.Where(x => arrIdTeachCaseResourceRelLst.Contains(x.IdTeachCaseResourceRel));
return arrTeachCase_Resource_RelObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsTeachCase_Resource_RelEN> GetObjLst(string strWhereCond)
{
List<clsTeachCase_Resource_RelEN> arrObjLst = new List<clsTeachCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN = new clsTeachCase_Resource_RelEN();
try
{
objTeachCase_Resource_RelEN.IdTeachCaseResourceRel = Int32.Parse(objRow[conTeachCase_Resource_Rel.IdTeachCaseResourceRel].ToString().Trim()); //案例与资源表系表流水号
objTeachCase_Resource_RelEN.IdTeachCase = objRow[conTeachCase_Resource_Rel.IdTeachCase].ToString().Trim(); //案例流水号
objTeachCase_Resource_RelEN.IdResource = objRow[conTeachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objTeachCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[conTeachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objTeachCase_Resource_RelEN.Memo = objRow[conTeachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[conTeachCase_Resource_Rel.Memo].ToString().Trim(); //备注
objTeachCase_Resource_RelEN.IndexNO = objRow[conTeachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objTeachCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conTeachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objTeachCase_Resource_RelEN.BrowseCount = objRow[conTeachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTeachCase_Resource_RelEN.IdTeachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTeachCase_Resource_RelEN);
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
public static List<clsTeachCase_Resource_RelEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsTeachCase_Resource_RelEN> arrObjLst = new List<clsTeachCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN = new clsTeachCase_Resource_RelEN();
try
{
objTeachCase_Resource_RelEN.IdTeachCaseResourceRel = Int32.Parse(objRow[conTeachCase_Resource_Rel.IdTeachCaseResourceRel].ToString().Trim()); //案例与资源表系表流水号
objTeachCase_Resource_RelEN.IdTeachCase = objRow[conTeachCase_Resource_Rel.IdTeachCase].ToString().Trim(); //案例流水号
objTeachCase_Resource_RelEN.IdResource = objRow[conTeachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objTeachCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[conTeachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objTeachCase_Resource_RelEN.Memo = objRow[conTeachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[conTeachCase_Resource_Rel.Memo].ToString().Trim(); //备注
objTeachCase_Resource_RelEN.IndexNO = objRow[conTeachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objTeachCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conTeachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objTeachCase_Resource_RelEN.BrowseCount = objRow[conTeachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTeachCase_Resource_RelEN.IdTeachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTeachCase_Resource_RelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objTeachCase_Resource_RelCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsTeachCase_Resource_RelEN> GetSubObjLstCache(clsTeachCase_Resource_RelEN objTeachCase_Resource_RelCond)
{
List<clsTeachCase_Resource_RelEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsTeachCase_Resource_RelEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conTeachCase_Resource_Rel.AttributeName)
{
if (objTeachCase_Resource_RelCond.IsUpdated(strFldName) == false) continue;
if (objTeachCase_Resource_RelCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTeachCase_Resource_RelCond[strFldName].ToString());
}
else
{
if (objTeachCase_Resource_RelCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objTeachCase_Resource_RelCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTeachCase_Resource_RelCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objTeachCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objTeachCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objTeachCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objTeachCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objTeachCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objTeachCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objTeachCase_Resource_RelCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objTeachCase_Resource_RelCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objTeachCase_Resource_RelCond[strFldName]));
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
public static List<clsTeachCase_Resource_RelEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsTeachCase_Resource_RelEN> arrObjLst = new List<clsTeachCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN = new clsTeachCase_Resource_RelEN();
try
{
objTeachCase_Resource_RelEN.IdTeachCaseResourceRel = Int32.Parse(objRow[conTeachCase_Resource_Rel.IdTeachCaseResourceRel].ToString().Trim()); //案例与资源表系表流水号
objTeachCase_Resource_RelEN.IdTeachCase = objRow[conTeachCase_Resource_Rel.IdTeachCase].ToString().Trim(); //案例流水号
objTeachCase_Resource_RelEN.IdResource = objRow[conTeachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objTeachCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[conTeachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objTeachCase_Resource_RelEN.Memo = objRow[conTeachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[conTeachCase_Resource_Rel.Memo].ToString().Trim(); //备注
objTeachCase_Resource_RelEN.IndexNO = objRow[conTeachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objTeachCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conTeachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objTeachCase_Resource_RelEN.BrowseCount = objRow[conTeachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTeachCase_Resource_RelEN.IdTeachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTeachCase_Resource_RelEN);
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
public static List<clsTeachCase_Resource_RelEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsTeachCase_Resource_RelEN> arrObjLst = new List<clsTeachCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN = new clsTeachCase_Resource_RelEN();
try
{
objTeachCase_Resource_RelEN.IdTeachCaseResourceRel = Int32.Parse(objRow[conTeachCase_Resource_Rel.IdTeachCaseResourceRel].ToString().Trim()); //案例与资源表系表流水号
objTeachCase_Resource_RelEN.IdTeachCase = objRow[conTeachCase_Resource_Rel.IdTeachCase].ToString().Trim(); //案例流水号
objTeachCase_Resource_RelEN.IdResource = objRow[conTeachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objTeachCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[conTeachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objTeachCase_Resource_RelEN.Memo = objRow[conTeachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[conTeachCase_Resource_Rel.Memo].ToString().Trim(); //备注
objTeachCase_Resource_RelEN.IndexNO = objRow[conTeachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objTeachCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conTeachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objTeachCase_Resource_RelEN.BrowseCount = objRow[conTeachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTeachCase_Resource_RelEN.IdTeachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTeachCase_Resource_RelEN);
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
List<clsTeachCase_Resource_RelEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsTeachCase_Resource_RelEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsTeachCase_Resource_RelEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsTeachCase_Resource_RelEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsTeachCase_Resource_RelEN> arrObjLst = new List<clsTeachCase_Resource_RelEN>(); 
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
	clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN = new clsTeachCase_Resource_RelEN();
try
{
objTeachCase_Resource_RelEN.IdTeachCaseResourceRel = Int32.Parse(objRow[conTeachCase_Resource_Rel.IdTeachCaseResourceRel].ToString().Trim()); //案例与资源表系表流水号
objTeachCase_Resource_RelEN.IdTeachCase = objRow[conTeachCase_Resource_Rel.IdTeachCase].ToString().Trim(); //案例流水号
objTeachCase_Resource_RelEN.IdResource = objRow[conTeachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objTeachCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[conTeachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objTeachCase_Resource_RelEN.Memo = objRow[conTeachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[conTeachCase_Resource_Rel.Memo].ToString().Trim(); //备注
objTeachCase_Resource_RelEN.IndexNO = objRow[conTeachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objTeachCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conTeachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objTeachCase_Resource_RelEN.BrowseCount = objRow[conTeachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTeachCase_Resource_RelEN.IdTeachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTeachCase_Resource_RelEN);
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
public static List<clsTeachCase_Resource_RelEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsTeachCase_Resource_RelEN> arrObjLst = new List<clsTeachCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN = new clsTeachCase_Resource_RelEN();
try
{
objTeachCase_Resource_RelEN.IdTeachCaseResourceRel = Int32.Parse(objRow[conTeachCase_Resource_Rel.IdTeachCaseResourceRel].ToString().Trim()); //案例与资源表系表流水号
objTeachCase_Resource_RelEN.IdTeachCase = objRow[conTeachCase_Resource_Rel.IdTeachCase].ToString().Trim(); //案例流水号
objTeachCase_Resource_RelEN.IdResource = objRow[conTeachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objTeachCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[conTeachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objTeachCase_Resource_RelEN.Memo = objRow[conTeachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[conTeachCase_Resource_Rel.Memo].ToString().Trim(); //备注
objTeachCase_Resource_RelEN.IndexNO = objRow[conTeachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objTeachCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conTeachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objTeachCase_Resource_RelEN.BrowseCount = objRow[conTeachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTeachCase_Resource_RelEN.IdTeachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTeachCase_Resource_RelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsTeachCase_Resource_RelEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsTeachCase_Resource_RelEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsTeachCase_Resource_RelEN> arrObjLst = new List<clsTeachCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN = new clsTeachCase_Resource_RelEN();
try
{
objTeachCase_Resource_RelEN.IdTeachCaseResourceRel = Int32.Parse(objRow[conTeachCase_Resource_Rel.IdTeachCaseResourceRel].ToString().Trim()); //案例与资源表系表流水号
objTeachCase_Resource_RelEN.IdTeachCase = objRow[conTeachCase_Resource_Rel.IdTeachCase].ToString().Trim(); //案例流水号
objTeachCase_Resource_RelEN.IdResource = objRow[conTeachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objTeachCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[conTeachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objTeachCase_Resource_RelEN.Memo = objRow[conTeachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[conTeachCase_Resource_Rel.Memo].ToString().Trim(); //备注
objTeachCase_Resource_RelEN.IndexNO = objRow[conTeachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objTeachCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conTeachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objTeachCase_Resource_RelEN.BrowseCount = objRow[conTeachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTeachCase_Resource_RelEN.IdTeachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTeachCase_Resource_RelEN);
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
public static List<clsTeachCase_Resource_RelEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsTeachCase_Resource_RelEN> arrObjLst = new List<clsTeachCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN = new clsTeachCase_Resource_RelEN();
try
{
objTeachCase_Resource_RelEN.IdTeachCaseResourceRel = Int32.Parse(objRow[conTeachCase_Resource_Rel.IdTeachCaseResourceRel].ToString().Trim()); //案例与资源表系表流水号
objTeachCase_Resource_RelEN.IdTeachCase = objRow[conTeachCase_Resource_Rel.IdTeachCase].ToString().Trim(); //案例流水号
objTeachCase_Resource_RelEN.IdResource = objRow[conTeachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objTeachCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[conTeachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objTeachCase_Resource_RelEN.Memo = objRow[conTeachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[conTeachCase_Resource_Rel.Memo].ToString().Trim(); //备注
objTeachCase_Resource_RelEN.IndexNO = objRow[conTeachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objTeachCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conTeachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objTeachCase_Resource_RelEN.BrowseCount = objRow[conTeachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTeachCase_Resource_RelEN.IdTeachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTeachCase_Resource_RelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsTeachCase_Resource_RelEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsTeachCase_Resource_RelEN> arrObjLst = new List<clsTeachCase_Resource_RelEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN = new clsTeachCase_Resource_RelEN();
try
{
objTeachCase_Resource_RelEN.IdTeachCaseResourceRel = Int32.Parse(objRow[conTeachCase_Resource_Rel.IdTeachCaseResourceRel].ToString().Trim()); //案例与资源表系表流水号
objTeachCase_Resource_RelEN.IdTeachCase = objRow[conTeachCase_Resource_Rel.IdTeachCase].ToString().Trim(); //案例流水号
objTeachCase_Resource_RelEN.IdResource = objRow[conTeachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objTeachCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[conTeachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objTeachCase_Resource_RelEN.Memo = objRow[conTeachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[conTeachCase_Resource_Rel.Memo].ToString().Trim(); //备注
objTeachCase_Resource_RelEN.IndexNO = objRow[conTeachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objTeachCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conTeachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objTeachCase_Resource_RelEN.BrowseCount = objRow[conTeachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTeachCase_Resource_RelEN.IdTeachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTeachCase_Resource_RelEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objTeachCase_Resource_RelEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetTeachCase_Resource_Rel(ref clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN)
{
bool bolResult = TeachCase_Resource_RelDA.GetTeachCase_Resource_Rel(ref objTeachCase_Resource_RelEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdTeachCaseResourceRel">表关键字</param>
 /// <returns>表对象</returns>
public static clsTeachCase_Resource_RelEN GetObjByIdTeachCaseResourceRel(long lngIdTeachCaseResourceRel)
{
clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN = TeachCase_Resource_RelDA.GetObjByIdTeachCaseResourceRel(lngIdTeachCaseResourceRel);
return objTeachCase_Resource_RelEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsTeachCase_Resource_RelEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN = TeachCase_Resource_RelDA.GetFirstObj(strWhereCond);
 return objTeachCase_Resource_RelEN;
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
public static clsTeachCase_Resource_RelEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN = TeachCase_Resource_RelDA.GetObjByDataRow(objRow);
 return objTeachCase_Resource_RelEN;
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
public static clsTeachCase_Resource_RelEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN = TeachCase_Resource_RelDA.GetObjByDataRow(objRow);
 return objTeachCase_Resource_RelEN;
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
 /// <param name = "lngIdTeachCaseResourceRel">所给的关键字</param>
 /// <param name = "lstTeachCase_Resource_RelObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsTeachCase_Resource_RelEN GetObjByIdTeachCaseResourceRelFromList(long lngIdTeachCaseResourceRel, List<clsTeachCase_Resource_RelEN> lstTeachCase_Resource_RelObjLst)
{
foreach (clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN in lstTeachCase_Resource_RelObjLst)
{
if (objTeachCase_Resource_RelEN.IdTeachCaseResourceRel == lngIdTeachCaseResourceRel)
{
return objTeachCase_Resource_RelEN;
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
 long lngIdTeachCaseResourceRel;
 try
 {
 lngIdTeachCaseResourceRel = new clsTeachCase_Resource_RelDA().GetFirstID(strWhereCond);
 return lngIdTeachCaseResourceRel;
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
 arrList = TeachCase_Resource_RelDA.GetID(strWhereCond);
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
bool bolIsExist = TeachCase_Resource_RelDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdTeachCaseResourceRel">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdTeachCaseResourceRel)
{
//检测记录是否存在
bool bolIsExist = TeachCase_Resource_RelDA.IsExist(lngIdTeachCaseResourceRel);
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
 bolIsExist = clsTeachCase_Resource_RelDA.IsExistTable();
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
 bolIsExist = TeachCase_Resource_RelDA.IsExistTable(strTabName);
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
 /// <param name = "objTeachCase_Resource_RelEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN)
{
if (objTeachCase_Resource_RelEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!案例流水号 = [{0}],资源流水号 = [{1}]的数据已经存在!(in clsTeachCase_Resource_RelBL.AddNewRecordBySql2)", objTeachCase_Resource_RelEN.IdTeachCase,objTeachCase_Resource_RelEN.IdResource);
throw new Exception(strMsg);
}
try
{
bool bolResult = TeachCase_Resource_RelDA.AddNewRecordBySQL2(objTeachCase_Resource_RelEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachCase_Resource_RelBL.ReFreshCache();

if (clsTeachCase_Resource_RelBL.relatedActions != null)
{
clsTeachCase_Resource_RelBL.relatedActions.UpdRelaTabDate(objTeachCase_Resource_RelEN.IdTeachCaseResourceRel, "SetUpdDate");
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
 /// <param name = "objTeachCase_Resource_RelEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN)
{
if (objTeachCase_Resource_RelEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!案例流水号 = [{0}],资源流水号 = [{1}]的数据已经存在!(in clsTeachCase_Resource_RelBL.AddNewRecordBySql2WithReturnKey)", objTeachCase_Resource_RelEN.IdTeachCase,objTeachCase_Resource_RelEN.IdResource);
throw new Exception(strMsg);
}
try
{
string strKey = TeachCase_Resource_RelDA.AddNewRecordBySQL2WithReturnKey(objTeachCase_Resource_RelEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachCase_Resource_RelBL.ReFreshCache();

if (clsTeachCase_Resource_RelBL.relatedActions != null)
{
clsTeachCase_Resource_RelBL.relatedActions.UpdRelaTabDate(objTeachCase_Resource_RelEN.IdTeachCaseResourceRel, "SetUpdDate");
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
 /// <param name = "objTeachCase_Resource_RelEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN)
{
try
{
bool bolResult = TeachCase_Resource_RelDA.Update(objTeachCase_Resource_RelEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachCase_Resource_RelBL.ReFreshCache();

if (clsTeachCase_Resource_RelBL.relatedActions != null)
{
clsTeachCase_Resource_RelBL.relatedActions.UpdRelaTabDate(objTeachCase_Resource_RelEN.IdTeachCaseResourceRel, "SetUpdDate");
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
 /// <param name = "objTeachCase_Resource_RelEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN)
{
 if (objTeachCase_Resource_RelEN.IdTeachCaseResourceRel == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = TeachCase_Resource_RelDA.UpdateBySql2(objTeachCase_Resource_RelEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachCase_Resource_RelBL.ReFreshCache();

if (clsTeachCase_Resource_RelBL.relatedActions != null)
{
clsTeachCase_Resource_RelBL.relatedActions.UpdRelaTabDate(objTeachCase_Resource_RelEN.IdTeachCaseResourceRel, "SetUpdDate");
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
 /// <param name = "lngIdTeachCaseResourceRel">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngIdTeachCaseResourceRel)
{
try
{
 clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN = clsTeachCase_Resource_RelBL.GetObjByIdTeachCaseResourceRel(lngIdTeachCaseResourceRel);

if (clsTeachCase_Resource_RelBL.relatedActions != null)
{
clsTeachCase_Resource_RelBL.relatedActions.UpdRelaTabDate(objTeachCase_Resource_RelEN.IdTeachCaseResourceRel, "SetUpdDate");
}
if (objTeachCase_Resource_RelEN != null)
{
int intRecNum = TeachCase_Resource_RelDA.DelRecord(lngIdTeachCaseResourceRel);
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
/// <param name="lngIdTeachCaseResourceRel">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngIdTeachCaseResourceRel )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsTeachCase_Resource_RelDA.GetSpecSQLObj();
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
//删除与表:[TeachCase_Resource_Rel]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conTeachCase_Resource_Rel.IdTeachCaseResourceRel,
//lngIdTeachCaseResourceRel);
//        clsTeachCase_Resource_RelBL.DelTeachCase_Resource_RelsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsTeachCase_Resource_RelBL.DelRecord(lngIdTeachCaseResourceRel, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsTeachCase_Resource_RelBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngIdTeachCaseResourceRel, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngIdTeachCaseResourceRel">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngIdTeachCaseResourceRel, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsTeachCase_Resource_RelBL.relatedActions != null)
{
clsTeachCase_Resource_RelBL.relatedActions.UpdRelaTabDate(lngIdTeachCaseResourceRel, "UpdRelaTabDate");
}
bool bolResult = TeachCase_Resource_RelDA.DelRecord(lngIdTeachCaseResourceRel,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdTeachCaseResourceRelLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelTeachCase_Resource_Rels(List<string> arrIdTeachCaseResourceRelLst)
{
if (arrIdTeachCaseResourceRelLst.Count == 0) return 0;
try
{
if (clsTeachCase_Resource_RelBL.relatedActions != null)
{
foreach (var strIdTeachCaseResourceRel in arrIdTeachCaseResourceRelLst)
{
long lngIdTeachCaseResourceRel = long.Parse(strIdTeachCaseResourceRel);
clsTeachCase_Resource_RelBL.relatedActions.UpdRelaTabDate(lngIdTeachCaseResourceRel, "UpdRelaTabDate");
}
}
int intDelRecNum = TeachCase_Resource_RelDA.DelTeachCase_Resource_Rel(arrIdTeachCaseResourceRelLst);
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
public static int DelTeachCase_Resource_RelsByCond(string strWhereCond)
{
try
{
if (clsTeachCase_Resource_RelBL.relatedActions != null)
{
List<string> arrIdTeachCaseResourceRel = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdTeachCaseResourceRel in arrIdTeachCaseResourceRel)
{
long lngIdTeachCaseResourceRel = long.Parse(strIdTeachCaseResourceRel);
clsTeachCase_Resource_RelBL.relatedActions.UpdRelaTabDate(lngIdTeachCaseResourceRel, "UpdRelaTabDate");
}
}
int intRecNum = TeachCase_Resource_RelDA.DelTeachCase_Resource_Rel(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[TeachCase_Resource_Rel]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngIdTeachCaseResourceRel">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngIdTeachCaseResourceRel)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsTeachCase_Resource_RelDA.GetSpecSQLObj();
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
//删除与表:[TeachCase_Resource_Rel]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsTeachCase_Resource_RelBL.DelRecord(lngIdTeachCaseResourceRel, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsTeachCase_Resource_RelBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngIdTeachCaseResourceRel, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objTeachCase_Resource_RelENS">源对象</param>
 /// <param name = "objTeachCase_Resource_RelENT">目标对象</param>
 public static void CopyTo(clsTeachCase_Resource_RelEN objTeachCase_Resource_RelENS, clsTeachCase_Resource_RelEN objTeachCase_Resource_RelENT)
{
try
{
objTeachCase_Resource_RelENT.IdTeachCaseResourceRel = objTeachCase_Resource_RelENS.IdTeachCaseResourceRel; //案例与资源表系表流水号
objTeachCase_Resource_RelENT.IdTeachCase = objTeachCase_Resource_RelENS.IdTeachCase; //案例流水号
objTeachCase_Resource_RelENT.IdResource = objTeachCase_Resource_RelENS.IdResource; //资源流水号
objTeachCase_Resource_RelENT.IsMain = objTeachCase_Resource_RelENS.IsMain; //是否主资源
objTeachCase_Resource_RelENT.Memo = objTeachCase_Resource_RelENS.Memo; //备注
objTeachCase_Resource_RelENT.IndexNO = objTeachCase_Resource_RelENS.IndexNO; //序号
objTeachCase_Resource_RelENT.IsVisible = objTeachCase_Resource_RelENS.IsVisible; //是否显示
objTeachCase_Resource_RelENT.BrowseCount = objTeachCase_Resource_RelENS.BrowseCount; //浏览次数
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
 /// <param name = "objTeachCase_Resource_RelEN">源简化对象</param>
 public static void SetUpdFlag(clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN)
{
try
{
objTeachCase_Resource_RelEN.ClearUpdateState();
   string strsfUpdFldSetStr = objTeachCase_Resource_RelEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conTeachCase_Resource_Rel.IdTeachCaseResourceRel, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachCase_Resource_RelEN.IdTeachCaseResourceRel = objTeachCase_Resource_RelEN.IdTeachCaseResourceRel; //案例与资源表系表流水号
}
if (arrFldSet.Contains(conTeachCase_Resource_Rel.IdTeachCase, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachCase_Resource_RelEN.IdTeachCase = objTeachCase_Resource_RelEN.IdTeachCase; //案例流水号
}
if (arrFldSet.Contains(conTeachCase_Resource_Rel.IdResource, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachCase_Resource_RelEN.IdResource = objTeachCase_Resource_RelEN.IdResource; //资源流水号
}
if (arrFldSet.Contains(conTeachCase_Resource_Rel.IsMain, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachCase_Resource_RelEN.IsMain = objTeachCase_Resource_RelEN.IsMain; //是否主资源
}
if (arrFldSet.Contains(conTeachCase_Resource_Rel.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachCase_Resource_RelEN.Memo = objTeachCase_Resource_RelEN.Memo == "[null]" ? null :  objTeachCase_Resource_RelEN.Memo; //备注
}
if (arrFldSet.Contains(conTeachCase_Resource_Rel.IndexNO, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachCase_Resource_RelEN.IndexNO = objTeachCase_Resource_RelEN.IndexNO; //序号
}
if (arrFldSet.Contains(conTeachCase_Resource_Rel.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachCase_Resource_RelEN.IsVisible = objTeachCase_Resource_RelEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(conTeachCase_Resource_Rel.BrowseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachCase_Resource_RelEN.BrowseCount = objTeachCase_Resource_RelEN.BrowseCount; //浏览次数
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
 /// <param name = "objTeachCase_Resource_RelEN">源简化对象</param>
 public static void AccessFldValueNull(clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN)
{
try
{
if (objTeachCase_Resource_RelEN.Memo == "[null]") objTeachCase_Resource_RelEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN)
{
 TeachCase_Resource_RelDA.CheckPropertyNew(objTeachCase_Resource_RelEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN)
{
 TeachCase_Resource_RelDA.CheckProperty4Condition(objTeachCase_Resource_RelEN);
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
if (clsTeachCase_Resource_RelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachCase_Resource_RelBL没有刷新缓存机制(clsTeachCase_Resource_RelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdTeachCaseResourceRel");
//if (arrTeachCase_Resource_RelObjLstCache == null)
//{
//arrTeachCase_Resource_RelObjLstCache = TeachCase_Resource_RelDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdTeachCaseResourceRel">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsTeachCase_Resource_RelEN GetObjByIdTeachCaseResourceRelCache(long lngIdTeachCaseResourceRel)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsTeachCase_Resource_RelEN._CurrTabName);
List<clsTeachCase_Resource_RelEN> arrTeachCase_Resource_RelObjLstCache = GetObjLstCache();
IEnumerable <clsTeachCase_Resource_RelEN> arrTeachCase_Resource_RelObjLst_Sel =
arrTeachCase_Resource_RelObjLstCache
.Where(x=> x.IdTeachCaseResourceRel == lngIdTeachCaseResourceRel 
);
if (arrTeachCase_Resource_RelObjLst_Sel.Count() == 0)
{
   clsTeachCase_Resource_RelEN obj = clsTeachCase_Resource_RelBL.GetObjByIdTeachCaseResourceRel(lngIdTeachCaseResourceRel);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrTeachCase_Resource_RelObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsTeachCase_Resource_RelEN> GetAllTeachCase_Resource_RelObjLstCache()
{
//获取缓存中的对象列表
List<clsTeachCase_Resource_RelEN> arrTeachCase_Resource_RelObjLstCache = GetObjLstCache(); 
return arrTeachCase_Resource_RelObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsTeachCase_Resource_RelEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsTeachCase_Resource_RelEN._CurrTabName);
List<clsTeachCase_Resource_RelEN> arrTeachCase_Resource_RelObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrTeachCase_Resource_RelObjLstCache;
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
string strKey = string.Format("{0}", clsTeachCase_Resource_RelEN._CurrTabName);
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
if (clsTeachCase_Resource_RelBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsTeachCase_Resource_RelEN._CurrTabName);
CacheHelper.Remove(strKey);
clsTeachCase_Resource_RelBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--TeachCase_Resource_Rel(案例与资源表系)
 /// 唯一性条件:id_TeachCase_id_Resource
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objTeachCase_Resource_RelEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN)
{
//检测记录是否存在
string strResult = TeachCase_Resource_RelDA.GetUniCondStr(objTeachCase_Resource_RelEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngIdTeachCaseResourceRel)
{
if (strInFldName != conTeachCase_Resource_Rel.IdTeachCaseResourceRel)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conTeachCase_Resource_Rel.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conTeachCase_Resource_Rel.AttributeName));
throw new Exception(strMsg);
}
var objTeachCase_Resource_Rel = clsTeachCase_Resource_RelBL.GetObjByIdTeachCaseResourceRelCache(lngIdTeachCaseResourceRel);
if (objTeachCase_Resource_Rel == null) return "";
return objTeachCase_Resource_Rel[strOutFldName].ToString();
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
int intRecCount = clsTeachCase_Resource_RelDA.GetRecCount(strTabName);
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
int intRecCount = clsTeachCase_Resource_RelDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsTeachCase_Resource_RelDA.GetRecCount();
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
int intRecCount = clsTeachCase_Resource_RelDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objTeachCase_Resource_RelCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsTeachCase_Resource_RelEN objTeachCase_Resource_RelCond)
{
List<clsTeachCase_Resource_RelEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsTeachCase_Resource_RelEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conTeachCase_Resource_Rel.AttributeName)
{
if (objTeachCase_Resource_RelCond.IsUpdated(strFldName) == false) continue;
if (objTeachCase_Resource_RelCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTeachCase_Resource_RelCond[strFldName].ToString());
}
else
{
if (objTeachCase_Resource_RelCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objTeachCase_Resource_RelCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTeachCase_Resource_RelCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objTeachCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objTeachCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objTeachCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objTeachCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objTeachCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objTeachCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objTeachCase_Resource_RelCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objTeachCase_Resource_RelCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objTeachCase_Resource_RelCond[strFldName]));
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
 List<string> arrList = clsTeachCase_Resource_RelDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = TeachCase_Resource_RelDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = TeachCase_Resource_RelDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = TeachCase_Resource_RelDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsTeachCase_Resource_RelDA.SetFldValue(clsTeachCase_Resource_RelEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = TeachCase_Resource_RelDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsTeachCase_Resource_RelDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsTeachCase_Resource_RelDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsTeachCase_Resource_RelDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[TeachCase_Resource_Rel] "); 
 strCreateTabCode.Append(" ( "); 
 // /**案例与资源表系表流水号*/ 
 strCreateTabCode.Append(" IdTeachCaseResourceRel bigint primary key identity, "); 
 // /**案例流水号*/ 
 strCreateTabCode.Append(" IdTeachCase char(8) not Null, "); 
 // /**资源流水号*/ 
 strCreateTabCode.Append(" IdResource char(8) not Null, "); 
 // /**是否主资源*/ 
 strCreateTabCode.Append(" IsMain bit Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" IndexNO int Null, "); 
 // /**是否显示*/ 
 strCreateTabCode.Append(" IsVisible bit Null, "); 
 // /**浏览次数*/ 
 strCreateTabCode.Append(" BrowseCount int Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 案例与资源表系(TeachCase_Resource_Rel)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4TeachCase_Resource_Rel : clsCommFun4BL
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
clsTeachCase_Resource_RelBL.ReFreshThisCache();
}
}

}