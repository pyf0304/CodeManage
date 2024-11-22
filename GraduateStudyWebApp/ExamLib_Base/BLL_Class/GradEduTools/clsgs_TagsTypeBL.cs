﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_TagsTypeBL
 表名:gs_TagsType(01120715)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:16:30
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培设置(GradEduTools)
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
public static class  clsgs_TagsTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strTagsTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_TagsTypeEN GetObj(this K_TagsTypeId_gs_TagsType myKey)
{
clsgs_TagsTypeEN objgs_TagsTypeEN = clsgs_TagsTypeBL.gs_TagsTypeDA.GetObjByTagsTypeId(myKey.Value);
return objgs_TagsTypeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objgs_TagsTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsgs_TagsTypeEN objgs_TagsTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_TagsTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!标注类型ID = [{0}],标注类型名称 = [{1}]的数据已经存在!(in clsgs_TagsTypeBL.AddNewRecord)", objgs_TagsTypeEN.TagsTypeId,objgs_TagsTypeEN.TagsTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_TagsTypeEN.TagsTypeId) == true || clsgs_TagsTypeBL.IsExist(objgs_TagsTypeEN.TagsTypeId) == true)
 {
     objgs_TagsTypeEN.TagsTypeId = clsgs_TagsTypeBL.GetMaxStrId_S();
 }
bool bolResult = clsgs_TagsTypeBL.gs_TagsTypeDA.AddNewRecordBySQL2(objgs_TagsTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TagsTypeBL.ReFreshCache();

if (clsgs_TagsTypeBL.relatedActions != null)
{
clsgs_TagsTypeBL.relatedActions.UpdRelaTabDate(objgs_TagsTypeEN.TagsTypeId, "SetUpdDate");
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
public static bool AddRecordEx(this clsgs_TagsTypeEN objgs_TagsTypeEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsgs_TagsTypeBL.IsExist(objgs_TagsTypeEN.TagsTypeId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objgs_TagsTypeEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objgs_TagsTypeEN.CheckUniqueness() == false)
{
strMsg = string.Format("(标注类型ID(TagsTypeId)=[{0}],标注类型名称(TagsTypeName)=[{1}])已经存在,不能重复!", objgs_TagsTypeEN.TagsTypeId, objgs_TagsTypeEN.TagsTypeName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objgs_TagsTypeEN.TagsTypeId) == true || clsgs_TagsTypeBL.IsExist(objgs_TagsTypeEN.TagsTypeId) == true)
 {
     objgs_TagsTypeEN.TagsTypeId = clsgs_TagsTypeBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objgs_TagsTypeEN.AddNewRecord();
}
catch(Exception objException)
{
strMsg = "(errid:Busi000152)添加记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值。该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objgs_TagsTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsgs_TagsTypeEN objgs_TagsTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_TagsTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!标注类型ID = [{0}],标注类型名称 = [{1}]的数据已经存在!(in clsgs_TagsTypeBL.AddNewRecordWithMaxId)", objgs_TagsTypeEN.TagsTypeId,objgs_TagsTypeEN.TagsTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_TagsTypeEN.TagsTypeId) == true || clsgs_TagsTypeBL.IsExist(objgs_TagsTypeEN.TagsTypeId) == true)
 {
     objgs_TagsTypeEN.TagsTypeId = clsgs_TagsTypeBL.GetMaxStrId_S();
 }
string strTagsTypeId = clsgs_TagsTypeBL.gs_TagsTypeDA.AddNewRecordBySQL2WithReturnKey(objgs_TagsTypeEN);
     objgs_TagsTypeEN.TagsTypeId = strTagsTypeId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TagsTypeBL.ReFreshCache();

if (clsgs_TagsTypeBL.relatedActions != null)
{
clsgs_TagsTypeBL.relatedActions.UpdRelaTabDate(objgs_TagsTypeEN.TagsTypeId, "SetUpdDate");
}
return strTagsTypeId;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000096)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objgs_TagsTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsgs_TagsTypeEN objgs_TagsTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_TagsTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!标注类型ID = [{0}],标注类型名称 = [{1}]的数据已经存在!(in clsgs_TagsTypeBL.AddNewRecordWithReturnKey)", objgs_TagsTypeEN.TagsTypeId,objgs_TagsTypeEN.TagsTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_TagsTypeEN.TagsTypeId) == true || clsgs_TagsTypeBL.IsExist(objgs_TagsTypeEN.TagsTypeId) == true)
 {
     objgs_TagsTypeEN.TagsTypeId = clsgs_TagsTypeBL.GetMaxStrId_S();
 }
string strKey = clsgs_TagsTypeBL.gs_TagsTypeDA.AddNewRecordBySQL2WithReturnKey(objgs_TagsTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TagsTypeBL.ReFreshCache();

if (clsgs_TagsTypeBL.relatedActions != null)
{
clsgs_TagsTypeBL.relatedActions.UpdRelaTabDate(objgs_TagsTypeEN.TagsTypeId, "SetUpdDate");
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
 /// <param name = "objgs_TagsTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TagsTypeEN SetTagsTypeId(this clsgs_TagsTypeEN objgs_TagsTypeEN, string strTagsTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTagsTypeId, 2, congs_TagsType.TagsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTagsTypeId, 2, congs_TagsType.TagsTypeId);
}
objgs_TagsTypeEN.TagsTypeId = strTagsTypeId; //标注类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TagsTypeEN.dicFldComparisonOp.ContainsKey(congs_TagsType.TagsTypeId) == false)
{
objgs_TagsTypeEN.dicFldComparisonOp.Add(congs_TagsType.TagsTypeId, strComparisonOp);
}
else
{
objgs_TagsTypeEN.dicFldComparisonOp[congs_TagsType.TagsTypeId] = strComparisonOp;
}
}
return objgs_TagsTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_TagsTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TagsTypeEN SetTagsTypeName(this clsgs_TagsTypeEN objgs_TagsTypeEN, string strTagsTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTagsTypeName, 200, congs_TagsType.TagsTypeName);
}
objgs_TagsTypeEN.TagsTypeName = strTagsTypeName; //标注类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TagsTypeEN.dicFldComparisonOp.ContainsKey(congs_TagsType.TagsTypeName) == false)
{
objgs_TagsTypeEN.dicFldComparisonOp.Add(congs_TagsType.TagsTypeName, strComparisonOp);
}
else
{
objgs_TagsTypeEN.dicFldComparisonOp[congs_TagsType.TagsTypeName] = strComparisonOp;
}
}
return objgs_TagsTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_TagsTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TagsTypeEN SetMemo(this clsgs_TagsTypeEN objgs_TagsTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, congs_TagsType.Memo);
}
objgs_TagsTypeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TagsTypeEN.dicFldComparisonOp.ContainsKey(congs_TagsType.Memo) == false)
{
objgs_TagsTypeEN.dicFldComparisonOp.Add(congs_TagsType.Memo, strComparisonOp);
}
else
{
objgs_TagsTypeEN.dicFldComparisonOp[congs_TagsType.Memo] = strComparisonOp;
}
}
return objgs_TagsTypeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objgs_TagsTypeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsgs_TagsTypeEN objgs_TagsTypeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objgs_TagsTypeEN.CheckPropertyNew();
clsgs_TagsTypeEN objgs_TagsTypeCond = new clsgs_TagsTypeEN();
string strCondition = objgs_TagsTypeCond
.SetTagsTypeId(objgs_TagsTypeEN.TagsTypeId, "<>")
.SetTagsTypeId(objgs_TagsTypeEN.TagsTypeId, "=")
.SetTagsTypeName(objgs_TagsTypeEN.TagsTypeName, "=")
.GetCombineCondition();
objgs_TagsTypeEN._IsCheckProperty = true;
bool bolIsExist = clsgs_TagsTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(TagsTypeId_TagsTypeName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objgs_TagsTypeEN.Update();
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
 /// <param name = "objgs_TagsType">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsgs_TagsTypeEN objgs_TagsType)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsgs_TagsTypeEN objgs_TagsTypeCond = new clsgs_TagsTypeEN();
string strCondition = objgs_TagsTypeCond
.SetTagsTypeId(objgs_TagsType.TagsTypeId, "=")
.SetTagsTypeName(objgs_TagsType.TagsTypeName, "=")
.GetCombineCondition();
objgs_TagsType._IsCheckProperty = true;
bool bolIsExist = clsgs_TagsTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objgs_TagsType.TagsTypeId = clsgs_TagsTypeBL.GetFirstID_S(strCondition);
objgs_TagsType.UpdateWithCondition(strCondition);
}
else
{
objgs_TagsType.TagsTypeId = clsgs_TagsTypeBL.GetMaxStrId_S();
objgs_TagsType.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objgs_TagsTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_TagsTypeEN objgs_TagsTypeEN)
{
 if (string.IsNullOrEmpty(objgs_TagsTypeEN.TagsTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsgs_TagsTypeBL.gs_TagsTypeDA.UpdateBySql2(objgs_TagsTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TagsTypeBL.ReFreshCache();

if (clsgs_TagsTypeBL.relatedActions != null)
{
clsgs_TagsTypeBL.relatedActions.UpdRelaTabDate(objgs_TagsTypeEN.TagsTypeId, "SetUpdDate");
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
 /// <param name = "objgs_TagsTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_TagsTypeEN objgs_TagsTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objgs_TagsTypeEN.TagsTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsgs_TagsTypeBL.gs_TagsTypeDA.UpdateBySql2(objgs_TagsTypeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TagsTypeBL.ReFreshCache();

if (clsgs_TagsTypeBL.relatedActions != null)
{
clsgs_TagsTypeBL.relatedActions.UpdRelaTabDate(objgs_TagsTypeEN.TagsTypeId, "SetUpdDate");
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
 /// <param name = "objgs_TagsTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_TagsTypeEN objgs_TagsTypeEN, string strWhereCond)
{
try
{
bool bolResult = clsgs_TagsTypeBL.gs_TagsTypeDA.UpdateBySqlWithCondition(objgs_TagsTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TagsTypeBL.ReFreshCache();

if (clsgs_TagsTypeBL.relatedActions != null)
{
clsgs_TagsTypeBL.relatedActions.UpdRelaTabDate(objgs_TagsTypeEN.TagsTypeId, "SetUpdDate");
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
 /// <param name = "objgs_TagsTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_TagsTypeEN objgs_TagsTypeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsgs_TagsTypeBL.gs_TagsTypeDA.UpdateBySqlWithConditionTransaction(objgs_TagsTypeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TagsTypeBL.ReFreshCache();

if (clsgs_TagsTypeBL.relatedActions != null)
{
clsgs_TagsTypeBL.relatedActions.UpdRelaTabDate(objgs_TagsTypeEN.TagsTypeId, "SetUpdDate");
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
 /// <param name = "strTagsTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsgs_TagsTypeEN objgs_TagsTypeEN)
{
try
{
int intRecNum = clsgs_TagsTypeBL.gs_TagsTypeDA.DelRecord(objgs_TagsTypeEN.TagsTypeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TagsTypeBL.ReFreshCache();

if (clsgs_TagsTypeBL.relatedActions != null)
{
clsgs_TagsTypeBL.relatedActions.UpdRelaTabDate(objgs_TagsTypeEN.TagsTypeId, "SetUpdDate");
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
 /// <param name = "objgs_TagsTypeENS">源对象</param>
 /// <param name = "objgs_TagsTypeENT">目标对象</param>
 public static void CopyTo(this clsgs_TagsTypeEN objgs_TagsTypeENS, clsgs_TagsTypeEN objgs_TagsTypeENT)
{
try
{
objgs_TagsTypeENT.TagsTypeId = objgs_TagsTypeENS.TagsTypeId; //标注类型ID
objgs_TagsTypeENT.TagsTypeName = objgs_TagsTypeENS.TagsTypeName; //标注类型名称
objgs_TagsTypeENT.Memo = objgs_TagsTypeENS.Memo; //备注
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
 /// <param name = "objgs_TagsTypeENS">源对象</param>
 /// <returns>目标对象=>clsgs_TagsTypeEN:objgs_TagsTypeENT</returns>
 public static clsgs_TagsTypeEN CopyTo(this clsgs_TagsTypeEN objgs_TagsTypeENS)
{
try
{
 clsgs_TagsTypeEN objgs_TagsTypeENT = new clsgs_TagsTypeEN()
{
TagsTypeId = objgs_TagsTypeENS.TagsTypeId, //标注类型ID
TagsTypeName = objgs_TagsTypeENS.TagsTypeName, //标注类型名称
Memo = objgs_TagsTypeENS.Memo, //备注
};
 return objgs_TagsTypeENT;
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
public static void CheckPropertyNew(this clsgs_TagsTypeEN objgs_TagsTypeEN)
{
 clsgs_TagsTypeBL.gs_TagsTypeDA.CheckPropertyNew(objgs_TagsTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsgs_TagsTypeEN objgs_TagsTypeEN)
{
 clsgs_TagsTypeBL.gs_TagsTypeDA.CheckProperty4Condition(objgs_TagsTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsgs_TagsTypeEN objgs_TagsTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objgs_TagsTypeCond.IsUpdated(congs_TagsType.TagsTypeId) == true)
{
string strComparisonOpTagsTypeId = objgs_TagsTypeCond.dicFldComparisonOp[congs_TagsType.TagsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_TagsType.TagsTypeId, objgs_TagsTypeCond.TagsTypeId, strComparisonOpTagsTypeId);
}
if (objgs_TagsTypeCond.IsUpdated(congs_TagsType.TagsTypeName) == true)
{
string strComparisonOpTagsTypeName = objgs_TagsTypeCond.dicFldComparisonOp[congs_TagsType.TagsTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_TagsType.TagsTypeName, objgs_TagsTypeCond.TagsTypeName, strComparisonOpTagsTypeName);
}
if (objgs_TagsTypeCond.IsUpdated(congs_TagsType.Memo) == true)
{
string strComparisonOpMemo = objgs_TagsTypeCond.dicFldComparisonOp[congs_TagsType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_TagsType.Memo, objgs_TagsTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--gs_TagsType(标注类型), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:TagsTypeId_TagsTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objgs_TagsTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsgs_TagsTypeEN objgs_TagsTypeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objgs_TagsTypeEN == null) return true;
if (objgs_TagsTypeEN.TagsTypeId == null || objgs_TagsTypeEN.TagsTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TagsTypeId = '{0}'", objgs_TagsTypeEN.TagsTypeId);
 if (objgs_TagsTypeEN.TagsTypeName == null)
{
 sbCondition.AppendFormat(" and TagsTypeName is null", objgs_TagsTypeEN.TagsTypeName);
}
else
{
 sbCondition.AppendFormat(" and TagsTypeName = '{0}'", objgs_TagsTypeEN.TagsTypeName);
}
if (clsgs_TagsTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("TagsTypeId !=  '{0}'", objgs_TagsTypeEN.TagsTypeId);
 sbCondition.AppendFormat(" and TagsTypeId = '{0}'", objgs_TagsTypeEN.TagsTypeId);
 sbCondition.AppendFormat(" and TagsTypeName = '{0}'", objgs_TagsTypeEN.TagsTypeName);
if (clsgs_TagsTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--gs_TagsType(标注类型), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:TagsTypeId_TagsTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objgs_TagsTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsgs_TagsTypeEN objgs_TagsTypeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objgs_TagsTypeEN == null) return "";
if (objgs_TagsTypeEN.TagsTypeId == null || objgs_TagsTypeEN.TagsTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TagsTypeId = '{0}'", objgs_TagsTypeEN.TagsTypeId);
 if (objgs_TagsTypeEN.TagsTypeName == null)
{
 sbCondition.AppendFormat(" and TagsTypeName is null", objgs_TagsTypeEN.TagsTypeName);
}
else
{
 sbCondition.AppendFormat(" and TagsTypeName = '{0}'", objgs_TagsTypeEN.TagsTypeName);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("TagsTypeId !=  '{0}'", objgs_TagsTypeEN.TagsTypeId);
 sbCondition.AppendFormat(" and TagsTypeId = '{0}'", objgs_TagsTypeEN.TagsTypeId);
 sbCondition.AppendFormat(" and TagsTypeName = '{0}'", objgs_TagsTypeEN.TagsTypeName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_gs_TagsType
{
public virtual bool UpdRelaTabDate(string strTagsTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 标注类型(gs_TagsType)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsgs_TagsTypeBL
{
public static RelatedActions_gs_TagsType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsgs_TagsTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsgs_TagsTypeDA gs_TagsTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsgs_TagsTypeDA();
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
 public clsgs_TagsTypeBL()
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
if (string.IsNullOrEmpty(clsgs_TagsTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsgs_TagsTypeEN._ConnectString);
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
public static DataTable GetDataTable_gs_TagsType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = gs_TagsTypeDA.GetDataTable_gs_TagsType(strWhereCond);
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
objDT = gs_TagsTypeDA.GetDataTable(strWhereCond);
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
objDT = gs_TagsTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = gs_TagsTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = gs_TagsTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = gs_TagsTypeDA.GetDataTable_Top(objTopPara);
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
objDT = gs_TagsTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = gs_TagsTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = gs_TagsTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrTagsTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsgs_TagsTypeEN> GetObjLstByTagsTypeIdLst(List<string> arrTagsTypeIdLst)
{
List<clsgs_TagsTypeEN> arrObjLst = new List<clsgs_TagsTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrTagsTypeIdLst, true);
 string strWhereCond = string.Format("TagsTypeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_TagsTypeEN objgs_TagsTypeEN = new clsgs_TagsTypeEN();
try
{
objgs_TagsTypeEN.TagsTypeId = objRow[congs_TagsType.TagsTypeId].ToString().Trim(); //标注类型ID
objgs_TagsTypeEN.TagsTypeName = objRow[congs_TagsType.TagsTypeName] == DBNull.Value ? null : objRow[congs_TagsType.TagsTypeName].ToString().Trim(); //标注类型名称
objgs_TagsTypeEN.Memo = objRow[congs_TagsType.Memo] == DBNull.Value ? null : objRow[congs_TagsType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_TagsTypeEN.TagsTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_TagsTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrTagsTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsgs_TagsTypeEN> GetObjLstByTagsTypeIdLstCache(List<string> arrTagsTypeIdLst)
{
string strKey = string.Format("{0}", clsgs_TagsTypeEN._CurrTabName);
List<clsgs_TagsTypeEN> arrgs_TagsTypeObjLstCache = GetObjLstCache();
IEnumerable <clsgs_TagsTypeEN> arrgs_TagsTypeObjLst_Sel =
arrgs_TagsTypeObjLstCache
.Where(x => arrTagsTypeIdLst.Contains(x.TagsTypeId));
return arrgs_TagsTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_TagsTypeEN> GetObjLst(string strWhereCond)
{
List<clsgs_TagsTypeEN> arrObjLst = new List<clsgs_TagsTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_TagsTypeEN objgs_TagsTypeEN = new clsgs_TagsTypeEN();
try
{
objgs_TagsTypeEN.TagsTypeId = objRow[congs_TagsType.TagsTypeId].ToString().Trim(); //标注类型ID
objgs_TagsTypeEN.TagsTypeName = objRow[congs_TagsType.TagsTypeName] == DBNull.Value ? null : objRow[congs_TagsType.TagsTypeName].ToString().Trim(); //标注类型名称
objgs_TagsTypeEN.Memo = objRow[congs_TagsType.Memo] == DBNull.Value ? null : objRow[congs_TagsType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_TagsTypeEN.TagsTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_TagsTypeEN);
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
public static List<clsgs_TagsTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsgs_TagsTypeEN> arrObjLst = new List<clsgs_TagsTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_TagsTypeEN objgs_TagsTypeEN = new clsgs_TagsTypeEN();
try
{
objgs_TagsTypeEN.TagsTypeId = objRow[congs_TagsType.TagsTypeId].ToString().Trim(); //标注类型ID
objgs_TagsTypeEN.TagsTypeName = objRow[congs_TagsType.TagsTypeName] == DBNull.Value ? null : objRow[congs_TagsType.TagsTypeName].ToString().Trim(); //标注类型名称
objgs_TagsTypeEN.Memo = objRow[congs_TagsType.Memo] == DBNull.Value ? null : objRow[congs_TagsType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_TagsTypeEN.TagsTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_TagsTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objgs_TagsTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsgs_TagsTypeEN> GetSubObjLstCache(clsgs_TagsTypeEN objgs_TagsTypeCond)
{
List<clsgs_TagsTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsgs_TagsTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in congs_TagsType.AttributeName)
{
if (objgs_TagsTypeCond.IsUpdated(strFldName) == false) continue;
if (objgs_TagsTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_TagsTypeCond[strFldName].ToString());
}
else
{
if (objgs_TagsTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objgs_TagsTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_TagsTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objgs_TagsTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objgs_TagsTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objgs_TagsTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objgs_TagsTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objgs_TagsTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objgs_TagsTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objgs_TagsTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objgs_TagsTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objgs_TagsTypeCond[strFldName]));
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
public static List<clsgs_TagsTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsgs_TagsTypeEN> arrObjLst = new List<clsgs_TagsTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_TagsTypeEN objgs_TagsTypeEN = new clsgs_TagsTypeEN();
try
{
objgs_TagsTypeEN.TagsTypeId = objRow[congs_TagsType.TagsTypeId].ToString().Trim(); //标注类型ID
objgs_TagsTypeEN.TagsTypeName = objRow[congs_TagsType.TagsTypeName] == DBNull.Value ? null : objRow[congs_TagsType.TagsTypeName].ToString().Trim(); //标注类型名称
objgs_TagsTypeEN.Memo = objRow[congs_TagsType.Memo] == DBNull.Value ? null : objRow[congs_TagsType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_TagsTypeEN.TagsTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_TagsTypeEN);
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
public static List<clsgs_TagsTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsgs_TagsTypeEN> arrObjLst = new List<clsgs_TagsTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_TagsTypeEN objgs_TagsTypeEN = new clsgs_TagsTypeEN();
try
{
objgs_TagsTypeEN.TagsTypeId = objRow[congs_TagsType.TagsTypeId].ToString().Trim(); //标注类型ID
objgs_TagsTypeEN.TagsTypeName = objRow[congs_TagsType.TagsTypeName] == DBNull.Value ? null : objRow[congs_TagsType.TagsTypeName].ToString().Trim(); //标注类型名称
objgs_TagsTypeEN.Memo = objRow[congs_TagsType.Memo] == DBNull.Value ? null : objRow[congs_TagsType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_TagsTypeEN.TagsTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_TagsTypeEN);
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
List<clsgs_TagsTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsgs_TagsTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_TagsTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsgs_TagsTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsgs_TagsTypeEN> arrObjLst = new List<clsgs_TagsTypeEN>(); 
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
	clsgs_TagsTypeEN objgs_TagsTypeEN = new clsgs_TagsTypeEN();
try
{
objgs_TagsTypeEN.TagsTypeId = objRow[congs_TagsType.TagsTypeId].ToString().Trim(); //标注类型ID
objgs_TagsTypeEN.TagsTypeName = objRow[congs_TagsType.TagsTypeName] == DBNull.Value ? null : objRow[congs_TagsType.TagsTypeName].ToString().Trim(); //标注类型名称
objgs_TagsTypeEN.Memo = objRow[congs_TagsType.Memo] == DBNull.Value ? null : objRow[congs_TagsType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_TagsTypeEN.TagsTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_TagsTypeEN);
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
public static List<clsgs_TagsTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsgs_TagsTypeEN> arrObjLst = new List<clsgs_TagsTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_TagsTypeEN objgs_TagsTypeEN = new clsgs_TagsTypeEN();
try
{
objgs_TagsTypeEN.TagsTypeId = objRow[congs_TagsType.TagsTypeId].ToString().Trim(); //标注类型ID
objgs_TagsTypeEN.TagsTypeName = objRow[congs_TagsType.TagsTypeName] == DBNull.Value ? null : objRow[congs_TagsType.TagsTypeName].ToString().Trim(); //标注类型名称
objgs_TagsTypeEN.Memo = objRow[congs_TagsType.Memo] == DBNull.Value ? null : objRow[congs_TagsType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_TagsTypeEN.TagsTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_TagsTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsgs_TagsTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsgs_TagsTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsgs_TagsTypeEN> arrObjLst = new List<clsgs_TagsTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_TagsTypeEN objgs_TagsTypeEN = new clsgs_TagsTypeEN();
try
{
objgs_TagsTypeEN.TagsTypeId = objRow[congs_TagsType.TagsTypeId].ToString().Trim(); //标注类型ID
objgs_TagsTypeEN.TagsTypeName = objRow[congs_TagsType.TagsTypeName] == DBNull.Value ? null : objRow[congs_TagsType.TagsTypeName].ToString().Trim(); //标注类型名称
objgs_TagsTypeEN.Memo = objRow[congs_TagsType.Memo] == DBNull.Value ? null : objRow[congs_TagsType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_TagsTypeEN.TagsTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_TagsTypeEN);
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
public static List<clsgs_TagsTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsgs_TagsTypeEN> arrObjLst = new List<clsgs_TagsTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_TagsTypeEN objgs_TagsTypeEN = new clsgs_TagsTypeEN();
try
{
objgs_TagsTypeEN.TagsTypeId = objRow[congs_TagsType.TagsTypeId].ToString().Trim(); //标注类型ID
objgs_TagsTypeEN.TagsTypeName = objRow[congs_TagsType.TagsTypeName] == DBNull.Value ? null : objRow[congs_TagsType.TagsTypeName].ToString().Trim(); //标注类型名称
objgs_TagsTypeEN.Memo = objRow[congs_TagsType.Memo] == DBNull.Value ? null : objRow[congs_TagsType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_TagsTypeEN.TagsTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_TagsTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_TagsTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsgs_TagsTypeEN> arrObjLst = new List<clsgs_TagsTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_TagsTypeEN objgs_TagsTypeEN = new clsgs_TagsTypeEN();
try
{
objgs_TagsTypeEN.TagsTypeId = objRow[congs_TagsType.TagsTypeId].ToString().Trim(); //标注类型ID
objgs_TagsTypeEN.TagsTypeName = objRow[congs_TagsType.TagsTypeName] == DBNull.Value ? null : objRow[congs_TagsType.TagsTypeName].ToString().Trim(); //标注类型名称
objgs_TagsTypeEN.Memo = objRow[congs_TagsType.Memo] == DBNull.Value ? null : objRow[congs_TagsType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_TagsTypeEN.TagsTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_TagsTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objgs_TagsTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getgs_TagsType(ref clsgs_TagsTypeEN objgs_TagsTypeEN)
{
bool bolResult = gs_TagsTypeDA.Getgs_TagsType(ref objgs_TagsTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strTagsTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_TagsTypeEN GetObjByTagsTypeId(string strTagsTypeId)
{
if (strTagsTypeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strTagsTypeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strTagsTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strTagsTypeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsgs_TagsTypeEN objgs_TagsTypeEN = gs_TagsTypeDA.GetObjByTagsTypeId(strTagsTypeId);
return objgs_TagsTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsgs_TagsTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsgs_TagsTypeEN objgs_TagsTypeEN = gs_TagsTypeDA.GetFirstObj(strWhereCond);
 return objgs_TagsTypeEN;
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
public static clsgs_TagsTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsgs_TagsTypeEN objgs_TagsTypeEN = gs_TagsTypeDA.GetObjByDataRow(objRow);
 return objgs_TagsTypeEN;
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
public static clsgs_TagsTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsgs_TagsTypeEN objgs_TagsTypeEN = gs_TagsTypeDA.GetObjByDataRow(objRow);
 return objgs_TagsTypeEN;
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
 /// <param name = "strTagsTypeId">所给的关键字</param>
 /// <param name = "lstgs_TagsTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_TagsTypeEN GetObjByTagsTypeIdFromList(string strTagsTypeId, List<clsgs_TagsTypeEN> lstgs_TagsTypeObjLst)
{
foreach (clsgs_TagsTypeEN objgs_TagsTypeEN in lstgs_TagsTypeObjLst)
{
if (objgs_TagsTypeEN.TagsTypeId == strTagsTypeId)
{
return objgs_TagsTypeEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetMaxStrId_S)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId_S() 
{
 string strMaxTagsTypeId;
 try
 {
 strMaxTagsTypeId = clsgs_TagsTypeDA.GetMaxStrId();
 return strMaxTagsTypeId;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000024)获取最大关键字值出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond) 
{
 string strTagsTypeId;
 try
 {
 strTagsTypeId = new clsgs_TagsTypeDA().GetFirstID(strWhereCond);
 return strTagsTypeId;
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
 arrList = gs_TagsTypeDA.GetID(strWhereCond);
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
bool bolIsExist = gs_TagsTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strTagsTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strTagsTypeId)
{
if (string.IsNullOrEmpty(strTagsTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strTagsTypeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = gs_TagsTypeDA.IsExist(strTagsTypeId);
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
 bolIsExist = clsgs_TagsTypeDA.IsExistTable();
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
 bolIsExist = gs_TagsTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objgs_TagsTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsgs_TagsTypeEN objgs_TagsTypeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objgs_TagsTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!标注类型ID = [{0}],标注类型名称 = [{1}]的数据已经存在!(in clsgs_TagsTypeBL.AddNewRecordBySql2)", objgs_TagsTypeEN.TagsTypeId,objgs_TagsTypeEN.TagsTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_TagsTypeEN.TagsTypeId) == true || clsgs_TagsTypeBL.IsExist(objgs_TagsTypeEN.TagsTypeId) == true)
 {
     objgs_TagsTypeEN.TagsTypeId = clsgs_TagsTypeBL.GetMaxStrId_S();
 }
bool bolResult = gs_TagsTypeDA.AddNewRecordBySQL2(objgs_TagsTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TagsTypeBL.ReFreshCache();

if (clsgs_TagsTypeBL.relatedActions != null)
{
clsgs_TagsTypeBL.relatedActions.UpdRelaTabDate(objgs_TagsTypeEN.TagsTypeId, "SetUpdDate");
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
 /// <param name = "objgs_TagsTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsgs_TagsTypeEN objgs_TagsTypeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objgs_TagsTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!标注类型ID = [{0}],标注类型名称 = [{1}]的数据已经存在!(in clsgs_TagsTypeBL.AddNewRecordBySql2WithReturnKey)", objgs_TagsTypeEN.TagsTypeId,objgs_TagsTypeEN.TagsTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_TagsTypeEN.TagsTypeId) == true || clsgs_TagsTypeBL.IsExist(objgs_TagsTypeEN.TagsTypeId) == true)
 {
     objgs_TagsTypeEN.TagsTypeId = clsgs_TagsTypeBL.GetMaxStrId_S();
 }
string strKey = gs_TagsTypeDA.AddNewRecordBySQL2WithReturnKey(objgs_TagsTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TagsTypeBL.ReFreshCache();

if (clsgs_TagsTypeBL.relatedActions != null)
{
clsgs_TagsTypeBL.relatedActions.UpdRelaTabDate(objgs_TagsTypeEN.TagsTypeId, "SetUpdDate");
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
 /// <param name = "objgs_TagsTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsgs_TagsTypeEN objgs_TagsTypeEN)
{
try
{
bool bolResult = gs_TagsTypeDA.Update(objgs_TagsTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TagsTypeBL.ReFreshCache();

if (clsgs_TagsTypeBL.relatedActions != null)
{
clsgs_TagsTypeBL.relatedActions.UpdRelaTabDate(objgs_TagsTypeEN.TagsTypeId, "SetUpdDate");
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
 /// <param name = "objgs_TagsTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsgs_TagsTypeEN objgs_TagsTypeEN)
{
 if (string.IsNullOrEmpty(objgs_TagsTypeEN.TagsTypeId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = gs_TagsTypeDA.UpdateBySql2(objgs_TagsTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TagsTypeBL.ReFreshCache();

if (clsgs_TagsTypeBL.relatedActions != null)
{
clsgs_TagsTypeBL.relatedActions.UpdRelaTabDate(objgs_TagsTypeEN.TagsTypeId, "SetUpdDate");
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
 /// <param name = "strTagsTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strTagsTypeId)
{
try
{
 clsgs_TagsTypeEN objgs_TagsTypeEN = clsgs_TagsTypeBL.GetObjByTagsTypeId(strTagsTypeId);

if (clsgs_TagsTypeBL.relatedActions != null)
{
clsgs_TagsTypeBL.relatedActions.UpdRelaTabDate(objgs_TagsTypeEN.TagsTypeId, "SetUpdDate");
}
if (objgs_TagsTypeEN != null)
{
int intRecNum = gs_TagsTypeDA.DelRecord(strTagsTypeId);
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
/// <param name="strTagsTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strTagsTypeId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsgs_TagsTypeDA.GetSpecSQLObj();
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
//删除与表:[gs_TagsType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//congs_TagsType.TagsTypeId,
//strTagsTypeId);
//        clsgs_TagsTypeBL.Delgs_TagsTypesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsgs_TagsTypeBL.DelRecord(strTagsTypeId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsgs_TagsTypeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strTagsTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strTagsTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strTagsTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsgs_TagsTypeBL.relatedActions != null)
{
clsgs_TagsTypeBL.relatedActions.UpdRelaTabDate(strTagsTypeId, "UpdRelaTabDate");
}
bool bolResult = gs_TagsTypeDA.DelRecord(strTagsTypeId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrTagsTypeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delgs_TagsTypes(List<string> arrTagsTypeIdLst)
{
if (arrTagsTypeIdLst.Count == 0) return 0;
try
{
if (clsgs_TagsTypeBL.relatedActions != null)
{
foreach (var strTagsTypeId in arrTagsTypeIdLst)
{
clsgs_TagsTypeBL.relatedActions.UpdRelaTabDate(strTagsTypeId, "UpdRelaTabDate");
}
}
int intDelRecNum = gs_TagsTypeDA.Delgs_TagsType(arrTagsTypeIdLst);
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
public static int Delgs_TagsTypesByCond(string strWhereCond)
{
try
{
if (clsgs_TagsTypeBL.relatedActions != null)
{
List<string> arrTagsTypeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strTagsTypeId in arrTagsTypeId)
{
clsgs_TagsTypeBL.relatedActions.UpdRelaTabDate(strTagsTypeId, "UpdRelaTabDate");
}
}
int intRecNum = gs_TagsTypeDA.Delgs_TagsType(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[gs_TagsType]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strTagsTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strTagsTypeId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsgs_TagsTypeDA.GetSpecSQLObj();
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
//删除与表:[gs_TagsType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsgs_TagsTypeBL.DelRecord(strTagsTypeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsgs_TagsTypeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strTagsTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objgs_TagsTypeENS">源对象</param>
 /// <param name = "objgs_TagsTypeENT">目标对象</param>
 public static void CopyTo(clsgs_TagsTypeEN objgs_TagsTypeENS, clsgs_TagsTypeEN objgs_TagsTypeENT)
{
try
{
objgs_TagsTypeENT.TagsTypeId = objgs_TagsTypeENS.TagsTypeId; //标注类型ID
objgs_TagsTypeENT.TagsTypeName = objgs_TagsTypeENS.TagsTypeName; //标注类型名称
objgs_TagsTypeENT.Memo = objgs_TagsTypeENS.Memo; //备注
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
 /// <param name = "objgs_TagsTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsgs_TagsTypeEN objgs_TagsTypeEN)
{
try
{
objgs_TagsTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objgs_TagsTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(congs_TagsType.TagsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TagsTypeEN.TagsTypeId = objgs_TagsTypeEN.TagsTypeId; //标注类型ID
}
if (arrFldSet.Contains(congs_TagsType.TagsTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TagsTypeEN.TagsTypeName = objgs_TagsTypeEN.TagsTypeName == "[null]" ? null :  objgs_TagsTypeEN.TagsTypeName; //标注类型名称
}
if (arrFldSet.Contains(congs_TagsType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TagsTypeEN.Memo = objgs_TagsTypeEN.Memo == "[null]" ? null :  objgs_TagsTypeEN.Memo; //备注
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
 /// <param name = "objgs_TagsTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsgs_TagsTypeEN objgs_TagsTypeEN)
{
try
{
if (objgs_TagsTypeEN.TagsTypeName == "[null]") objgs_TagsTypeEN.TagsTypeName = null; //标注类型名称
if (objgs_TagsTypeEN.Memo == "[null]") objgs_TagsTypeEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsgs_TagsTypeEN objgs_TagsTypeEN)
{
 gs_TagsTypeDA.CheckPropertyNew(objgs_TagsTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsgs_TagsTypeEN objgs_TagsTypeEN)
{
 gs_TagsTypeDA.CheckProperty4Condition(objgs_TagsTypeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_TagsTypeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", congs_TagsType.TagsTypeId); 
List<clsgs_TagsTypeEN> arrObjLst = clsgs_TagsTypeBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsgs_TagsTypeEN objgs_TagsTypeEN = new clsgs_TagsTypeEN()
{
TagsTypeId = "0",
TagsTypeName = "选[标注类型]..."
};
arrObjLst.Insert(0, objgs_TagsTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = congs_TagsType.TagsTypeId;
objComboBox.DisplayMember = congs_TagsType.TagsTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_TagsTypeId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[标注类型]...","0");
string strCondition = string.Format("1 =1 Order By {0}", congs_TagsType.TagsTypeId); 
IEnumerable<clsgs_TagsTypeEN> arrObjLst = clsgs_TagsTypeBL.GetObjLst(strCondition);
objDDL.DataValueField = congs_TagsType.TagsTypeId;
objDDL.DataTextField = congs_TagsType.TagsTypeName;
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_TagsTypeIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[标注类型]...","0");
List<clsgs_TagsTypeEN> arrgs_TagsTypeObjLst = GetAllgs_TagsTypeObjLstCache(); 
objDDL.DataValueField = congs_TagsType.TagsTypeId;
objDDL.DataTextField = congs_TagsType.TagsTypeName;
objDDL.DataSource = arrgs_TagsTypeObjLst;
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
if (clsgs_TagsTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_TagsTypeBL没有刷新缓存机制(clsgs_TagsTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by TagsTypeId");
//if (arrgs_TagsTypeObjLstCache == null)
//{
//arrgs_TagsTypeObjLstCache = gs_TagsTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strTagsTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_TagsTypeEN GetObjByTagsTypeIdCache(string strTagsTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsgs_TagsTypeEN._CurrTabName);
List<clsgs_TagsTypeEN> arrgs_TagsTypeObjLstCache = GetObjLstCache();
IEnumerable <clsgs_TagsTypeEN> arrgs_TagsTypeObjLst_Sel =
arrgs_TagsTypeObjLstCache
.Where(x=> x.TagsTypeId == strTagsTypeId 
);
if (arrgs_TagsTypeObjLst_Sel.Count() == 0)
{
   clsgs_TagsTypeEN obj = clsgs_TagsTypeBL.GetObjByTagsTypeId(strTagsTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrgs_TagsTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strTagsTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetTagsTypeNameByTagsTypeIdCache(string strTagsTypeId)
{
if (string.IsNullOrEmpty(strTagsTypeId) == true) return "";
//获取缓存中的对象列表
clsgs_TagsTypeEN objgs_TagsType = GetObjByTagsTypeIdCache(strTagsTypeId);
if (objgs_TagsType == null) return "";
return objgs_TagsType.TagsTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strTagsTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByTagsTypeIdCache(string strTagsTypeId)
{
if (string.IsNullOrEmpty(strTagsTypeId) == true) return "";
//获取缓存中的对象列表
clsgs_TagsTypeEN objgs_TagsType = GetObjByTagsTypeIdCache(strTagsTypeId);
if (objgs_TagsType == null) return "";
return objgs_TagsType.TagsTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_TagsTypeEN> GetAllgs_TagsTypeObjLstCache()
{
//获取缓存中的对象列表
List<clsgs_TagsTypeEN> arrgs_TagsTypeObjLstCache = GetObjLstCache(); 
return arrgs_TagsTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_TagsTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsgs_TagsTypeEN._CurrTabName);
List<clsgs_TagsTypeEN> arrgs_TagsTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrgs_TagsTypeObjLstCache;
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
string strKey = string.Format("{0}", clsgs_TagsTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsgs_TagsTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsgs_TagsTypeEN._RefreshTimeLst.Count == 0) return "";
return clsgs_TagsTypeEN._RefreshTimeLst[clsgs_TagsTypeEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsgs_TagsTypeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsgs_TagsTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsgs_TagsTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsgs_TagsTypeBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--gs_TagsType(标注类型)
 /// 唯一性条件:TagsTypeId_TagsTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objgs_TagsTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsgs_TagsTypeEN objgs_TagsTypeEN)
{
//检测记录是否存在
string strResult = gs_TagsTypeDA.GetUniCondStr(objgs_TagsTypeEN);
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
public static string Func(string strInFldName, string strOutFldName, string strTagsTypeId)
{
if (strInFldName != congs_TagsType.TagsTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (congs_TagsType.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", congs_TagsType.AttributeName));
throw new Exception(strMsg);
}
var objgs_TagsType = clsgs_TagsTypeBL.GetObjByTagsTypeIdCache(strTagsTypeId);
if (objgs_TagsType == null) return "";
return objgs_TagsType[strOutFldName].ToString();
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
int intRecCount = clsgs_TagsTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsgs_TagsTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsgs_TagsTypeDA.GetRecCount();
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
int intRecCount = clsgs_TagsTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objgs_TagsTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsgs_TagsTypeEN objgs_TagsTypeCond)
{
List<clsgs_TagsTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsgs_TagsTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in congs_TagsType.AttributeName)
{
if (objgs_TagsTypeCond.IsUpdated(strFldName) == false) continue;
if (objgs_TagsTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_TagsTypeCond[strFldName].ToString());
}
else
{
if (objgs_TagsTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objgs_TagsTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_TagsTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objgs_TagsTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objgs_TagsTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objgs_TagsTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objgs_TagsTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objgs_TagsTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objgs_TagsTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objgs_TagsTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objgs_TagsTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objgs_TagsTypeCond[strFldName]));
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
 List<string> arrList = clsgs_TagsTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = gs_TagsTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = gs_TagsTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = gs_TagsTypeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsgs_TagsTypeDA.SetFldValue(clsgs_TagsTypeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = gs_TagsTypeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsgs_TagsTypeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsgs_TagsTypeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsgs_TagsTypeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[gs_TagsType] "); 
 strCreateTabCode.Append(" ( "); 
 // /**标注类型ID*/ 
 strCreateTabCode.Append(" TagsTypeId char(2) primary key, "); 
 // /**标注类型名称*/ 
 strCreateTabCode.Append(" TagsTypeName varchar(200) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 标注类型(gs_TagsType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4gs_TagsType : clsCommFun4BL
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
clsgs_TagsTypeBL.ReFreshThisCache();
}
}

}