﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_PaperGroupBL
 表名:gs_PaperGroup(01120749)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:11:02
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
public static class  clsgs_PaperGroupBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strPaperGroupId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_PaperGroupEN GetObj(this K_PaperGroupId_gs_PaperGroup myKey)
{
clsgs_PaperGroupEN objgs_PaperGroupEN = clsgs_PaperGroupBL.gs_PaperGroupDA.GetObjByPaperGroupId(myKey.Value);
return objgs_PaperGroupEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objgs_PaperGroupEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsgs_PaperGroupEN objgs_PaperGroupEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_PaperGroupEN) == false)
{
var strMsg = string.Format("记录已经存在!组名 = [{0}],修改人 = [{1}]的数据已经存在!(in clsgs_PaperGroupBL.AddNewRecord)", objgs_PaperGroupEN.PaperGroupName,objgs_PaperGroupEN.UpdUser);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_PaperGroupEN.PaperGroupId) == true || clsgs_PaperGroupBL.IsExist(objgs_PaperGroupEN.PaperGroupId) == true)
 {
     objgs_PaperGroupEN.PaperGroupId = clsgs_PaperGroupBL.GetMaxStrId_S();
 }
bool bolResult = clsgs_PaperGroupBL.gs_PaperGroupDA.AddNewRecordBySQL2(objgs_PaperGroupEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperGroupBL.ReFreshCache(objgs_PaperGroupEN.UpdUser);

if (clsgs_PaperGroupBL.relatedActions != null)
{
clsgs_PaperGroupBL.relatedActions.UpdRelaTabDate(objgs_PaperGroupEN.PaperGroupId, objgs_PaperGroupEN.UpdUser);
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
public static bool AddRecordEx(this clsgs_PaperGroupEN objgs_PaperGroupEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsgs_PaperGroupBL.IsExist(objgs_PaperGroupEN.PaperGroupId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objgs_PaperGroupEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objgs_PaperGroupEN.CheckUniqueness() == false)
{
strMsg = string.Format("(组名(PaperGroupName)=[{0}],修改人(UpdUser)=[{1}])已经存在,不能重复!", objgs_PaperGroupEN.PaperGroupName, objgs_PaperGroupEN.UpdUser);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objgs_PaperGroupEN.PaperGroupId) == true || clsgs_PaperGroupBL.IsExist(objgs_PaperGroupEN.PaperGroupId) == true)
 {
     objgs_PaperGroupEN.PaperGroupId = clsgs_PaperGroupBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objgs_PaperGroupEN.AddNewRecord();
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
 /// <param name = "objgs_PaperGroupEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsgs_PaperGroupEN objgs_PaperGroupEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_PaperGroupEN) == false)
{
var strMsg = string.Format("记录已经存在!组名 = [{0}],修改人 = [{1}]的数据已经存在!(in clsgs_PaperGroupBL.AddNewRecordWithMaxId)", objgs_PaperGroupEN.PaperGroupName,objgs_PaperGroupEN.UpdUser);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_PaperGroupEN.PaperGroupId) == true || clsgs_PaperGroupBL.IsExist(objgs_PaperGroupEN.PaperGroupId) == true)
 {
     objgs_PaperGroupEN.PaperGroupId = clsgs_PaperGroupBL.GetMaxStrId_S();
 }
string strPaperGroupId = clsgs_PaperGroupBL.gs_PaperGroupDA.AddNewRecordBySQL2WithReturnKey(objgs_PaperGroupEN);
     objgs_PaperGroupEN.PaperGroupId = strPaperGroupId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperGroupBL.ReFreshCache(objgs_PaperGroupEN.UpdUser);

if (clsgs_PaperGroupBL.relatedActions != null)
{
clsgs_PaperGroupBL.relatedActions.UpdRelaTabDate(objgs_PaperGroupEN.PaperGroupId, objgs_PaperGroupEN.UpdUser);
}
return strPaperGroupId;
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
 /// <param name = "objgs_PaperGroupEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsgs_PaperGroupEN objgs_PaperGroupEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_PaperGroupEN) == false)
{
var strMsg = string.Format("记录已经存在!组名 = [{0}],修改人 = [{1}]的数据已经存在!(in clsgs_PaperGroupBL.AddNewRecordWithReturnKey)", objgs_PaperGroupEN.PaperGroupName,objgs_PaperGroupEN.UpdUser);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_PaperGroupEN.PaperGroupId) == true || clsgs_PaperGroupBL.IsExist(objgs_PaperGroupEN.PaperGroupId) == true)
 {
     objgs_PaperGroupEN.PaperGroupId = clsgs_PaperGroupBL.GetMaxStrId_S();
 }
string strKey = clsgs_PaperGroupBL.gs_PaperGroupDA.AddNewRecordBySQL2WithReturnKey(objgs_PaperGroupEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperGroupBL.ReFreshCache(objgs_PaperGroupEN.UpdUser);

if (clsgs_PaperGroupBL.relatedActions != null)
{
clsgs_PaperGroupBL.relatedActions.UpdRelaTabDate(objgs_PaperGroupEN.PaperGroupId, objgs_PaperGroupEN.UpdUser);
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
 /// <param name = "objgs_PaperGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperGroupEN SetPaperGroupId(this clsgs_PaperGroupEN objgs_PaperGroupEN, string strPaperGroupId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperGroupId, 8, congs_PaperGroup.PaperGroupId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperGroupId, 8, congs_PaperGroup.PaperGroupId);
}
objgs_PaperGroupEN.PaperGroupId = strPaperGroupId; //组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperGroupEN.dicFldComparisonOp.ContainsKey(congs_PaperGroup.PaperGroupId) == false)
{
objgs_PaperGroupEN.dicFldComparisonOp.Add(congs_PaperGroup.PaperGroupId, strComparisonOp);
}
else
{
objgs_PaperGroupEN.dicFldComparisonOp[congs_PaperGroup.PaperGroupId] = strComparisonOp;
}
}
return objgs_PaperGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperGroupEN SetPaperGroupName(this clsgs_PaperGroupEN objgs_PaperGroupEN, string strPaperGroupName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperGroupName, 50, congs_PaperGroup.PaperGroupName);
}
objgs_PaperGroupEN.PaperGroupName = strPaperGroupName; //组名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperGroupEN.dicFldComparisonOp.ContainsKey(congs_PaperGroup.PaperGroupName) == false)
{
objgs_PaperGroupEN.dicFldComparisonOp.Add(congs_PaperGroup.PaperGroupName, strComparisonOp);
}
else
{
objgs_PaperGroupEN.dicFldComparisonOp[congs_PaperGroup.PaperGroupName] = strComparisonOp;
}
}
return objgs_PaperGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperGroupEN SetUpdUser(this clsgs_PaperGroupEN objgs_PaperGroupEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, congs_PaperGroup.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, congs_PaperGroup.UpdUser);
}
objgs_PaperGroupEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperGroupEN.dicFldComparisonOp.ContainsKey(congs_PaperGroup.UpdUser) == false)
{
objgs_PaperGroupEN.dicFldComparisonOp.Add(congs_PaperGroup.UpdUser, strComparisonOp);
}
else
{
objgs_PaperGroupEN.dicFldComparisonOp[congs_PaperGroup.UpdUser] = strComparisonOp;
}
}
return objgs_PaperGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperGroupEN SetOrderNum(this clsgs_PaperGroupEN objgs_PaperGroupEN, int? intOrderNum, string strComparisonOp="")
	{
objgs_PaperGroupEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperGroupEN.dicFldComparisonOp.ContainsKey(congs_PaperGroup.OrderNum) == false)
{
objgs_PaperGroupEN.dicFldComparisonOp.Add(congs_PaperGroup.OrderNum, strComparisonOp);
}
else
{
objgs_PaperGroupEN.dicFldComparisonOp[congs_PaperGroup.OrderNum] = strComparisonOp;
}
}
return objgs_PaperGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperGroupEN SetUpdDate(this clsgs_PaperGroupEN objgs_PaperGroupEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, congs_PaperGroup.UpdDate);
}
objgs_PaperGroupEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperGroupEN.dicFldComparisonOp.ContainsKey(congs_PaperGroup.UpdDate) == false)
{
objgs_PaperGroupEN.dicFldComparisonOp.Add(congs_PaperGroup.UpdDate, strComparisonOp);
}
else
{
objgs_PaperGroupEN.dicFldComparisonOp[congs_PaperGroup.UpdDate] = strComparisonOp;
}
}
return objgs_PaperGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperGroupEN SetMeno(this clsgs_PaperGroupEN objgs_PaperGroupEN, string strMeno, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMeno, 2000, congs_PaperGroup.Meno);
}
objgs_PaperGroupEN.Meno = strMeno; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperGroupEN.dicFldComparisonOp.ContainsKey(congs_PaperGroup.Meno) == false)
{
objgs_PaperGroupEN.dicFldComparisonOp.Add(congs_PaperGroup.Meno, strComparisonOp);
}
else
{
objgs_PaperGroupEN.dicFldComparisonOp[congs_PaperGroup.Meno] = strComparisonOp;
}
}
return objgs_PaperGroupEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objgs_PaperGroupEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsgs_PaperGroupEN objgs_PaperGroupEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objgs_PaperGroupEN.CheckPropertyNew();
clsgs_PaperGroupEN objgs_PaperGroupCond = new clsgs_PaperGroupEN();
string strCondition = objgs_PaperGroupCond
.SetPaperGroupId(objgs_PaperGroupEN.PaperGroupId, "<>")
.SetPaperGroupName(objgs_PaperGroupEN.PaperGroupName, "=")
.SetUpdUser(objgs_PaperGroupEN.UpdUser, "=")
.GetCombineCondition();
objgs_PaperGroupEN._IsCheckProperty = true;
bool bolIsExist = clsgs_PaperGroupBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(PaperGroupName_UpdUser)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objgs_PaperGroupEN.Update();
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
 /// <param name = "objgs_PaperGroup">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsgs_PaperGroupEN objgs_PaperGroup)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsgs_PaperGroupEN objgs_PaperGroupCond = new clsgs_PaperGroupEN();
string strCondition = objgs_PaperGroupCond
.SetPaperGroupName(objgs_PaperGroup.PaperGroupName, "=")
.SetUpdUser(objgs_PaperGroup.UpdUser, "=")
.GetCombineCondition();
objgs_PaperGroup._IsCheckProperty = true;
bool bolIsExist = clsgs_PaperGroupBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objgs_PaperGroup.PaperGroupId = clsgs_PaperGroupBL.GetFirstID_S(strCondition);
objgs_PaperGroup.UpdateWithCondition(strCondition);
}
else
{
objgs_PaperGroup.PaperGroupId = clsgs_PaperGroupBL.GetMaxStrId_S();
objgs_PaperGroup.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objgs_PaperGroupEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_PaperGroupEN objgs_PaperGroupEN)
{
 if (string.IsNullOrEmpty(objgs_PaperGroupEN.PaperGroupId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsgs_PaperGroupBL.gs_PaperGroupDA.UpdateBySql2(objgs_PaperGroupEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperGroupBL.ReFreshCache(objgs_PaperGroupEN.UpdUser);

if (clsgs_PaperGroupBL.relatedActions != null)
{
clsgs_PaperGroupBL.relatedActions.UpdRelaTabDate(objgs_PaperGroupEN.PaperGroupId, objgs_PaperGroupEN.UpdUser);
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
 /// <param name = "objgs_PaperGroupEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_PaperGroupEN objgs_PaperGroupEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objgs_PaperGroupEN.PaperGroupId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsgs_PaperGroupBL.gs_PaperGroupDA.UpdateBySql2(objgs_PaperGroupEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperGroupBL.ReFreshCache(objgs_PaperGroupEN.UpdUser);

if (clsgs_PaperGroupBL.relatedActions != null)
{
clsgs_PaperGroupBL.relatedActions.UpdRelaTabDate(objgs_PaperGroupEN.PaperGroupId, objgs_PaperGroupEN.UpdUser);
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
 /// <param name = "objgs_PaperGroupEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_PaperGroupEN objgs_PaperGroupEN, string strWhereCond)
{
try
{
bool bolResult = clsgs_PaperGroupBL.gs_PaperGroupDA.UpdateBySqlWithCondition(objgs_PaperGroupEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperGroupBL.ReFreshCache(objgs_PaperGroupEN.UpdUser);

if (clsgs_PaperGroupBL.relatedActions != null)
{
clsgs_PaperGroupBL.relatedActions.UpdRelaTabDate(objgs_PaperGroupEN.PaperGroupId, objgs_PaperGroupEN.UpdUser);
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
 /// <param name = "objgs_PaperGroupEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_PaperGroupEN objgs_PaperGroupEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsgs_PaperGroupBL.gs_PaperGroupDA.UpdateBySqlWithConditionTransaction(objgs_PaperGroupEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperGroupBL.ReFreshCache(objgs_PaperGroupEN.UpdUser);

if (clsgs_PaperGroupBL.relatedActions != null)
{
clsgs_PaperGroupBL.relatedActions.UpdRelaTabDate(objgs_PaperGroupEN.PaperGroupId, objgs_PaperGroupEN.UpdUser);
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
 /// <param name = "strPaperGroupId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsgs_PaperGroupEN objgs_PaperGroupEN)
{
try
{
int intRecNum = clsgs_PaperGroupBL.gs_PaperGroupDA.DelRecord(objgs_PaperGroupEN.PaperGroupId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperGroupBL.ReFreshCache(objgs_PaperGroupEN.UpdUser);

if (clsgs_PaperGroupBL.relatedActions != null)
{
clsgs_PaperGroupBL.relatedActions.UpdRelaTabDate(objgs_PaperGroupEN.PaperGroupId, objgs_PaperGroupEN.UpdUser);
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
 /// <param name = "objgs_PaperGroupENS">源对象</param>
 /// <param name = "objgs_PaperGroupENT">目标对象</param>
 public static void CopyTo(this clsgs_PaperGroupEN objgs_PaperGroupENS, clsgs_PaperGroupEN objgs_PaperGroupENT)
{
try
{
objgs_PaperGroupENT.PaperGroupId = objgs_PaperGroupENS.PaperGroupId; //组Id
objgs_PaperGroupENT.PaperGroupName = objgs_PaperGroupENS.PaperGroupName; //组名
objgs_PaperGroupENT.UpdUser = objgs_PaperGroupENS.UpdUser; //修改人
objgs_PaperGroupENT.OrderNum = objgs_PaperGroupENS.OrderNum; //序号
objgs_PaperGroupENT.UpdDate = objgs_PaperGroupENS.UpdDate; //修改日期
objgs_PaperGroupENT.Meno = objgs_PaperGroupENS.Meno; //备注
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
 /// <param name = "objgs_PaperGroupENS">源对象</param>
 /// <returns>目标对象=>clsgs_PaperGroupEN:objgs_PaperGroupENT</returns>
 public static clsgs_PaperGroupEN CopyTo(this clsgs_PaperGroupEN objgs_PaperGroupENS)
{
try
{
 clsgs_PaperGroupEN objgs_PaperGroupENT = new clsgs_PaperGroupEN()
{
PaperGroupId = objgs_PaperGroupENS.PaperGroupId, //组Id
PaperGroupName = objgs_PaperGroupENS.PaperGroupName, //组名
UpdUser = objgs_PaperGroupENS.UpdUser, //修改人
OrderNum = objgs_PaperGroupENS.OrderNum, //序号
UpdDate = objgs_PaperGroupENS.UpdDate, //修改日期
Meno = objgs_PaperGroupENS.Meno, //备注
};
 return objgs_PaperGroupENT;
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
public static void CheckPropertyNew(this clsgs_PaperGroupEN objgs_PaperGroupEN)
{
 clsgs_PaperGroupBL.gs_PaperGroupDA.CheckPropertyNew(objgs_PaperGroupEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsgs_PaperGroupEN objgs_PaperGroupEN)
{
 clsgs_PaperGroupBL.gs_PaperGroupDA.CheckProperty4Condition(objgs_PaperGroupEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsgs_PaperGroupEN objgs_PaperGroupCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objgs_PaperGroupCond.IsUpdated(congs_PaperGroup.PaperGroupId) == true)
{
string strComparisonOpPaperGroupId = objgs_PaperGroupCond.dicFldComparisonOp[congs_PaperGroup.PaperGroupId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperGroup.PaperGroupId, objgs_PaperGroupCond.PaperGroupId, strComparisonOpPaperGroupId);
}
if (objgs_PaperGroupCond.IsUpdated(congs_PaperGroup.PaperGroupName) == true)
{
string strComparisonOpPaperGroupName = objgs_PaperGroupCond.dicFldComparisonOp[congs_PaperGroup.PaperGroupName];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperGroup.PaperGroupName, objgs_PaperGroupCond.PaperGroupName, strComparisonOpPaperGroupName);
}
if (objgs_PaperGroupCond.IsUpdated(congs_PaperGroup.UpdUser) == true)
{
string strComparisonOpUpdUser = objgs_PaperGroupCond.dicFldComparisonOp[congs_PaperGroup.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperGroup.UpdUser, objgs_PaperGroupCond.UpdUser, strComparisonOpUpdUser);
}
if (objgs_PaperGroupCond.IsUpdated(congs_PaperGroup.OrderNum) == true)
{
string strComparisonOpOrderNum = objgs_PaperGroupCond.dicFldComparisonOp[congs_PaperGroup.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", congs_PaperGroup.OrderNum, objgs_PaperGroupCond.OrderNum, strComparisonOpOrderNum);
}
if (objgs_PaperGroupCond.IsUpdated(congs_PaperGroup.UpdDate) == true)
{
string strComparisonOpUpdDate = objgs_PaperGroupCond.dicFldComparisonOp[congs_PaperGroup.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperGroup.UpdDate, objgs_PaperGroupCond.UpdDate, strComparisonOpUpdDate);
}
if (objgs_PaperGroupCond.IsUpdated(congs_PaperGroup.Meno) == true)
{
string strComparisonOpMeno = objgs_PaperGroupCond.dicFldComparisonOp[congs_PaperGroup.Meno];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperGroup.Meno, objgs_PaperGroupCond.Meno, strComparisonOpMeno);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--gs_PaperGroup(论文分组), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:PaperGroupName_UpdUser
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objgs_PaperGroupEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsgs_PaperGroupEN objgs_PaperGroupEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objgs_PaperGroupEN == null) return true;
if (objgs_PaperGroupEN.PaperGroupId == null || objgs_PaperGroupEN.PaperGroupId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objgs_PaperGroupEN.PaperGroupName == null)
{
 sbCondition.AppendFormat(" and PaperGroupName is null", objgs_PaperGroupEN.PaperGroupName);
}
else
{
 sbCondition.AppendFormat(" and PaperGroupName = '{0}'", objgs_PaperGroupEN.PaperGroupName);
}
 sbCondition.AppendFormat(" and UpdUser = '{0}'", objgs_PaperGroupEN.UpdUser);
if (clsgs_PaperGroupBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("PaperGroupId !=  '{0}'", objgs_PaperGroupEN.PaperGroupId);
 sbCondition.AppendFormat(" and PaperGroupName = '{0}'", objgs_PaperGroupEN.PaperGroupName);
 sbCondition.AppendFormat(" and UpdUser = '{0}'", objgs_PaperGroupEN.UpdUser);
if (clsgs_PaperGroupBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--gs_PaperGroup(论文分组), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PaperGroupName_UpdUser
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objgs_PaperGroupEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsgs_PaperGroupEN objgs_PaperGroupEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objgs_PaperGroupEN == null) return "";
if (objgs_PaperGroupEN.PaperGroupId == null || objgs_PaperGroupEN.PaperGroupId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objgs_PaperGroupEN.PaperGroupName == null)
{
 sbCondition.AppendFormat(" and PaperGroupName is null", objgs_PaperGroupEN.PaperGroupName);
}
else
{
 sbCondition.AppendFormat(" and PaperGroupName = '{0}'", objgs_PaperGroupEN.PaperGroupName);
}
 sbCondition.AppendFormat(" and UpdUser = '{0}'", objgs_PaperGroupEN.UpdUser);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("PaperGroupId !=  '{0}'", objgs_PaperGroupEN.PaperGroupId);
 sbCondition.AppendFormat(" and PaperGroupName = '{0}'", objgs_PaperGroupEN.PaperGroupName);
 sbCondition.AppendFormat(" and UpdUser = '{0}'", objgs_PaperGroupEN.UpdUser);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_gs_PaperGroup
{
public virtual bool UpdRelaTabDate(string strPaperGroupId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 论文分组(gs_PaperGroup)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsgs_PaperGroupBL
{
public static RelatedActions_gs_PaperGroup relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsgs_PaperGroupDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsgs_PaperGroupDA gs_PaperGroupDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsgs_PaperGroupDA();
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
 public clsgs_PaperGroupBL()
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
if (string.IsNullOrEmpty(clsgs_PaperGroupEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsgs_PaperGroupEN._ConnectString);
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
public static DataTable GetDataTable_gs_PaperGroup(string strWhereCond)
{
DataTable objDT;
try
{
objDT = gs_PaperGroupDA.GetDataTable_gs_PaperGroup(strWhereCond);
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
objDT = gs_PaperGroupDA.GetDataTable(strWhereCond);
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
objDT = gs_PaperGroupDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = gs_PaperGroupDA.GetDataTable(strWhereCond, strTabName);
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
objDT = gs_PaperGroupDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = gs_PaperGroupDA.GetDataTable_Top(objTopPara);
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
objDT = gs_PaperGroupDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = gs_PaperGroupDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = gs_PaperGroupDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrPaperGroupIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsgs_PaperGroupEN> GetObjLstByPaperGroupIdLst(List<string> arrPaperGroupIdLst)
{
List<clsgs_PaperGroupEN> arrObjLst = new List<clsgs_PaperGroupEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrPaperGroupIdLst, true);
 string strWhereCond = string.Format("PaperGroupId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_PaperGroupEN objgs_PaperGroupEN = new clsgs_PaperGroupEN();
try
{
objgs_PaperGroupEN.PaperGroupId = objRow[congs_PaperGroup.PaperGroupId].ToString().Trim(); //组Id
objgs_PaperGroupEN.PaperGroupName = objRow[congs_PaperGroup.PaperGroupName] == DBNull.Value ? null : objRow[congs_PaperGroup.PaperGroupName].ToString().Trim(); //组名
objgs_PaperGroupEN.UpdUser = objRow[congs_PaperGroup.UpdUser].ToString().Trim(); //修改人
objgs_PaperGroupEN.OrderNum = objRow[congs_PaperGroup.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperGroup.OrderNum].ToString().Trim()); //序号
objgs_PaperGroupEN.UpdDate = objRow[congs_PaperGroup.UpdDate] == DBNull.Value ? null : objRow[congs_PaperGroup.UpdDate].ToString().Trim(); //修改日期
objgs_PaperGroupEN.Meno = objRow[congs_PaperGroup.Meno] == DBNull.Value ? null : objRow[congs_PaperGroup.Meno].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_PaperGroupEN.PaperGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_PaperGroupEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPaperGroupIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsgs_PaperGroupEN> GetObjLstByPaperGroupIdLstCache(List<string> arrPaperGroupIdLst, string strUpdUser)
{
string strKey = string.Format("{0}_{1}", clsgs_PaperGroupEN._CurrTabName, strUpdUser);
List<clsgs_PaperGroupEN> arrgs_PaperGroupObjLstCache = GetObjLstCache(strUpdUser);
IEnumerable <clsgs_PaperGroupEN> arrgs_PaperGroupObjLst_Sel =
arrgs_PaperGroupObjLstCache
.Where(x => arrPaperGroupIdLst.Contains(x.PaperGroupId));
return arrgs_PaperGroupObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_PaperGroupEN> GetObjLst(string strWhereCond)
{
List<clsgs_PaperGroupEN> arrObjLst = new List<clsgs_PaperGroupEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_PaperGroupEN objgs_PaperGroupEN = new clsgs_PaperGroupEN();
try
{
objgs_PaperGroupEN.PaperGroupId = objRow[congs_PaperGroup.PaperGroupId].ToString().Trim(); //组Id
objgs_PaperGroupEN.PaperGroupName = objRow[congs_PaperGroup.PaperGroupName] == DBNull.Value ? null : objRow[congs_PaperGroup.PaperGroupName].ToString().Trim(); //组名
objgs_PaperGroupEN.UpdUser = objRow[congs_PaperGroup.UpdUser].ToString().Trim(); //修改人
objgs_PaperGroupEN.OrderNum = objRow[congs_PaperGroup.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperGroup.OrderNum].ToString().Trim()); //序号
objgs_PaperGroupEN.UpdDate = objRow[congs_PaperGroup.UpdDate] == DBNull.Value ? null : objRow[congs_PaperGroup.UpdDate].ToString().Trim(); //修改日期
objgs_PaperGroupEN.Meno = objRow[congs_PaperGroup.Meno] == DBNull.Value ? null : objRow[congs_PaperGroup.Meno].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_PaperGroupEN.PaperGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_PaperGroupEN);
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
public static List<clsgs_PaperGroupEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsgs_PaperGroupEN> arrObjLst = new List<clsgs_PaperGroupEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_PaperGroupEN objgs_PaperGroupEN = new clsgs_PaperGroupEN();
try
{
objgs_PaperGroupEN.PaperGroupId = objRow[congs_PaperGroup.PaperGroupId].ToString().Trim(); //组Id
objgs_PaperGroupEN.PaperGroupName = objRow[congs_PaperGroup.PaperGroupName] == DBNull.Value ? null : objRow[congs_PaperGroup.PaperGroupName].ToString().Trim(); //组名
objgs_PaperGroupEN.UpdUser = objRow[congs_PaperGroup.UpdUser].ToString().Trim(); //修改人
objgs_PaperGroupEN.OrderNum = objRow[congs_PaperGroup.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperGroup.OrderNum].ToString().Trim()); //序号
objgs_PaperGroupEN.UpdDate = objRow[congs_PaperGroup.UpdDate] == DBNull.Value ? null : objRow[congs_PaperGroup.UpdDate].ToString().Trim(); //修改日期
objgs_PaperGroupEN.Meno = objRow[congs_PaperGroup.Meno] == DBNull.Value ? null : objRow[congs_PaperGroup.Meno].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_PaperGroupEN.PaperGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_PaperGroupEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objgs_PaperGroupCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsgs_PaperGroupEN> GetSubObjLstCache(clsgs_PaperGroupEN objgs_PaperGroupCond)
{
 string strUpdUser = objgs_PaperGroupCond.UpdUser;
 if (string.IsNullOrEmpty(strUpdUser) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsgs_PaperGroupBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsgs_PaperGroupEN> arrObjLstCache = GetObjLstCache(strUpdUser);
IEnumerable <clsgs_PaperGroupEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in congs_PaperGroup.AttributeName)
{
if (objgs_PaperGroupCond.IsUpdated(strFldName) == false) continue;
if (objgs_PaperGroupCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_PaperGroupCond[strFldName].ToString());
}
else
{
if (objgs_PaperGroupCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objgs_PaperGroupCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_PaperGroupCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objgs_PaperGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objgs_PaperGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objgs_PaperGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objgs_PaperGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objgs_PaperGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objgs_PaperGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objgs_PaperGroupCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objgs_PaperGroupCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objgs_PaperGroupCond[strFldName]));
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
public static List<clsgs_PaperGroupEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsgs_PaperGroupEN> arrObjLst = new List<clsgs_PaperGroupEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_PaperGroupEN objgs_PaperGroupEN = new clsgs_PaperGroupEN();
try
{
objgs_PaperGroupEN.PaperGroupId = objRow[congs_PaperGroup.PaperGroupId].ToString().Trim(); //组Id
objgs_PaperGroupEN.PaperGroupName = objRow[congs_PaperGroup.PaperGroupName] == DBNull.Value ? null : objRow[congs_PaperGroup.PaperGroupName].ToString().Trim(); //组名
objgs_PaperGroupEN.UpdUser = objRow[congs_PaperGroup.UpdUser].ToString().Trim(); //修改人
objgs_PaperGroupEN.OrderNum = objRow[congs_PaperGroup.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperGroup.OrderNum].ToString().Trim()); //序号
objgs_PaperGroupEN.UpdDate = objRow[congs_PaperGroup.UpdDate] == DBNull.Value ? null : objRow[congs_PaperGroup.UpdDate].ToString().Trim(); //修改日期
objgs_PaperGroupEN.Meno = objRow[congs_PaperGroup.Meno] == DBNull.Value ? null : objRow[congs_PaperGroup.Meno].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_PaperGroupEN.PaperGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_PaperGroupEN);
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
public static List<clsgs_PaperGroupEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsgs_PaperGroupEN> arrObjLst = new List<clsgs_PaperGroupEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_PaperGroupEN objgs_PaperGroupEN = new clsgs_PaperGroupEN();
try
{
objgs_PaperGroupEN.PaperGroupId = objRow[congs_PaperGroup.PaperGroupId].ToString().Trim(); //组Id
objgs_PaperGroupEN.PaperGroupName = objRow[congs_PaperGroup.PaperGroupName] == DBNull.Value ? null : objRow[congs_PaperGroup.PaperGroupName].ToString().Trim(); //组名
objgs_PaperGroupEN.UpdUser = objRow[congs_PaperGroup.UpdUser].ToString().Trim(); //修改人
objgs_PaperGroupEN.OrderNum = objRow[congs_PaperGroup.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperGroup.OrderNum].ToString().Trim()); //序号
objgs_PaperGroupEN.UpdDate = objRow[congs_PaperGroup.UpdDate] == DBNull.Value ? null : objRow[congs_PaperGroup.UpdDate].ToString().Trim(); //修改日期
objgs_PaperGroupEN.Meno = objRow[congs_PaperGroup.Meno] == DBNull.Value ? null : objRow[congs_PaperGroup.Meno].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_PaperGroupEN.PaperGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_PaperGroupEN);
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
List<clsgs_PaperGroupEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsgs_PaperGroupEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_PaperGroupEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsgs_PaperGroupEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsgs_PaperGroupEN> arrObjLst = new List<clsgs_PaperGroupEN>(); 
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
	clsgs_PaperGroupEN objgs_PaperGroupEN = new clsgs_PaperGroupEN();
try
{
objgs_PaperGroupEN.PaperGroupId = objRow[congs_PaperGroup.PaperGroupId].ToString().Trim(); //组Id
objgs_PaperGroupEN.PaperGroupName = objRow[congs_PaperGroup.PaperGroupName] == DBNull.Value ? null : objRow[congs_PaperGroup.PaperGroupName].ToString().Trim(); //组名
objgs_PaperGroupEN.UpdUser = objRow[congs_PaperGroup.UpdUser].ToString().Trim(); //修改人
objgs_PaperGroupEN.OrderNum = objRow[congs_PaperGroup.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperGroup.OrderNum].ToString().Trim()); //序号
objgs_PaperGroupEN.UpdDate = objRow[congs_PaperGroup.UpdDate] == DBNull.Value ? null : objRow[congs_PaperGroup.UpdDate].ToString().Trim(); //修改日期
objgs_PaperGroupEN.Meno = objRow[congs_PaperGroup.Meno] == DBNull.Value ? null : objRow[congs_PaperGroup.Meno].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_PaperGroupEN.PaperGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_PaperGroupEN);
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
public static List<clsgs_PaperGroupEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsgs_PaperGroupEN> arrObjLst = new List<clsgs_PaperGroupEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_PaperGroupEN objgs_PaperGroupEN = new clsgs_PaperGroupEN();
try
{
objgs_PaperGroupEN.PaperGroupId = objRow[congs_PaperGroup.PaperGroupId].ToString().Trim(); //组Id
objgs_PaperGroupEN.PaperGroupName = objRow[congs_PaperGroup.PaperGroupName] == DBNull.Value ? null : objRow[congs_PaperGroup.PaperGroupName].ToString().Trim(); //组名
objgs_PaperGroupEN.UpdUser = objRow[congs_PaperGroup.UpdUser].ToString().Trim(); //修改人
objgs_PaperGroupEN.OrderNum = objRow[congs_PaperGroup.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperGroup.OrderNum].ToString().Trim()); //序号
objgs_PaperGroupEN.UpdDate = objRow[congs_PaperGroup.UpdDate] == DBNull.Value ? null : objRow[congs_PaperGroup.UpdDate].ToString().Trim(); //修改日期
objgs_PaperGroupEN.Meno = objRow[congs_PaperGroup.Meno] == DBNull.Value ? null : objRow[congs_PaperGroup.Meno].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_PaperGroupEN.PaperGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_PaperGroupEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsgs_PaperGroupEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsgs_PaperGroupEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsgs_PaperGroupEN> arrObjLst = new List<clsgs_PaperGroupEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_PaperGroupEN objgs_PaperGroupEN = new clsgs_PaperGroupEN();
try
{
objgs_PaperGroupEN.PaperGroupId = objRow[congs_PaperGroup.PaperGroupId].ToString().Trim(); //组Id
objgs_PaperGroupEN.PaperGroupName = objRow[congs_PaperGroup.PaperGroupName] == DBNull.Value ? null : objRow[congs_PaperGroup.PaperGroupName].ToString().Trim(); //组名
objgs_PaperGroupEN.UpdUser = objRow[congs_PaperGroup.UpdUser].ToString().Trim(); //修改人
objgs_PaperGroupEN.OrderNum = objRow[congs_PaperGroup.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperGroup.OrderNum].ToString().Trim()); //序号
objgs_PaperGroupEN.UpdDate = objRow[congs_PaperGroup.UpdDate] == DBNull.Value ? null : objRow[congs_PaperGroup.UpdDate].ToString().Trim(); //修改日期
objgs_PaperGroupEN.Meno = objRow[congs_PaperGroup.Meno] == DBNull.Value ? null : objRow[congs_PaperGroup.Meno].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_PaperGroupEN.PaperGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_PaperGroupEN);
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
public static List<clsgs_PaperGroupEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsgs_PaperGroupEN> arrObjLst = new List<clsgs_PaperGroupEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_PaperGroupEN objgs_PaperGroupEN = new clsgs_PaperGroupEN();
try
{
objgs_PaperGroupEN.PaperGroupId = objRow[congs_PaperGroup.PaperGroupId].ToString().Trim(); //组Id
objgs_PaperGroupEN.PaperGroupName = objRow[congs_PaperGroup.PaperGroupName] == DBNull.Value ? null : objRow[congs_PaperGroup.PaperGroupName].ToString().Trim(); //组名
objgs_PaperGroupEN.UpdUser = objRow[congs_PaperGroup.UpdUser].ToString().Trim(); //修改人
objgs_PaperGroupEN.OrderNum = objRow[congs_PaperGroup.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperGroup.OrderNum].ToString().Trim()); //序号
objgs_PaperGroupEN.UpdDate = objRow[congs_PaperGroup.UpdDate] == DBNull.Value ? null : objRow[congs_PaperGroup.UpdDate].ToString().Trim(); //修改日期
objgs_PaperGroupEN.Meno = objRow[congs_PaperGroup.Meno] == DBNull.Value ? null : objRow[congs_PaperGroup.Meno].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_PaperGroupEN.PaperGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_PaperGroupEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_PaperGroupEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsgs_PaperGroupEN> arrObjLst = new List<clsgs_PaperGroupEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_PaperGroupEN objgs_PaperGroupEN = new clsgs_PaperGroupEN();
try
{
objgs_PaperGroupEN.PaperGroupId = objRow[congs_PaperGroup.PaperGroupId].ToString().Trim(); //组Id
objgs_PaperGroupEN.PaperGroupName = objRow[congs_PaperGroup.PaperGroupName] == DBNull.Value ? null : objRow[congs_PaperGroup.PaperGroupName].ToString().Trim(); //组名
objgs_PaperGroupEN.UpdUser = objRow[congs_PaperGroup.UpdUser].ToString().Trim(); //修改人
objgs_PaperGroupEN.OrderNum = objRow[congs_PaperGroup.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperGroup.OrderNum].ToString().Trim()); //序号
objgs_PaperGroupEN.UpdDate = objRow[congs_PaperGroup.UpdDate] == DBNull.Value ? null : objRow[congs_PaperGroup.UpdDate].ToString().Trim(); //修改日期
objgs_PaperGroupEN.Meno = objRow[congs_PaperGroup.Meno] == DBNull.Value ? null : objRow[congs_PaperGroup.Meno].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_PaperGroupEN.PaperGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_PaperGroupEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objgs_PaperGroupEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getgs_PaperGroup(ref clsgs_PaperGroupEN objgs_PaperGroupEN)
{
bool bolResult = gs_PaperGroupDA.Getgs_PaperGroup(ref objgs_PaperGroupEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strPaperGroupId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_PaperGroupEN GetObjByPaperGroupId(string strPaperGroupId)
{
if (strPaperGroupId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strPaperGroupId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strPaperGroupId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strPaperGroupId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsgs_PaperGroupEN objgs_PaperGroupEN = gs_PaperGroupDA.GetObjByPaperGroupId(strPaperGroupId);
return objgs_PaperGroupEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsgs_PaperGroupEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsgs_PaperGroupEN objgs_PaperGroupEN = gs_PaperGroupDA.GetFirstObj(strWhereCond);
 return objgs_PaperGroupEN;
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
public static clsgs_PaperGroupEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsgs_PaperGroupEN objgs_PaperGroupEN = gs_PaperGroupDA.GetObjByDataRow(objRow);
 return objgs_PaperGroupEN;
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
public static clsgs_PaperGroupEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsgs_PaperGroupEN objgs_PaperGroupEN = gs_PaperGroupDA.GetObjByDataRow(objRow);
 return objgs_PaperGroupEN;
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
 /// <param name = "strPaperGroupId">所给的关键字</param>
 /// <param name = "lstgs_PaperGroupObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_PaperGroupEN GetObjByPaperGroupIdFromList(string strPaperGroupId, List<clsgs_PaperGroupEN> lstgs_PaperGroupObjLst)
{
foreach (clsgs_PaperGroupEN objgs_PaperGroupEN in lstgs_PaperGroupObjLst)
{
if (objgs_PaperGroupEN.PaperGroupId == strPaperGroupId)
{
return objgs_PaperGroupEN;
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
 string strMaxPaperGroupId;
 try
 {
 strMaxPaperGroupId = clsgs_PaperGroupDA.GetMaxStrId();
 return strMaxPaperGroupId;
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
 string strPaperGroupId;
 try
 {
 strPaperGroupId = new clsgs_PaperGroupDA().GetFirstID(strWhereCond);
 return strPaperGroupId;
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
 arrList = gs_PaperGroupDA.GetID(strWhereCond);
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
bool bolIsExist = gs_PaperGroupDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strPaperGroupId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strPaperGroupId)
{
if (string.IsNullOrEmpty(strPaperGroupId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strPaperGroupId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = gs_PaperGroupDA.IsExist(strPaperGroupId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strPaperGroupId">组Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strPaperGroupId, string strOpUser)
{
clsgs_PaperGroupEN objgs_PaperGroupEN = clsgs_PaperGroupBL.GetObjByPaperGroupId(strPaperGroupId);
objgs_PaperGroupEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objgs_PaperGroupEN.UpdUser = strOpUser;
return clsgs_PaperGroupBL.UpdateBySql2(objgs_PaperGroupEN);
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
 bolIsExist = clsgs_PaperGroupDA.IsExistTable();
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
 bolIsExist = gs_PaperGroupDA.IsExistTable(strTabName);
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
 /// <param name = "objgs_PaperGroupEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsgs_PaperGroupEN objgs_PaperGroupEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objgs_PaperGroupEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!组名 = [{0}],修改人 = [{1}]的数据已经存在!(in clsgs_PaperGroupBL.AddNewRecordBySql2)", objgs_PaperGroupEN.PaperGroupName,objgs_PaperGroupEN.UpdUser);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_PaperGroupEN.PaperGroupId) == true || clsgs_PaperGroupBL.IsExist(objgs_PaperGroupEN.PaperGroupId) == true)
 {
     objgs_PaperGroupEN.PaperGroupId = clsgs_PaperGroupBL.GetMaxStrId_S();
 }
bool bolResult = gs_PaperGroupDA.AddNewRecordBySQL2(objgs_PaperGroupEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperGroupBL.ReFreshCache(objgs_PaperGroupEN.UpdUser);

if (clsgs_PaperGroupBL.relatedActions != null)
{
clsgs_PaperGroupBL.relatedActions.UpdRelaTabDate(objgs_PaperGroupEN.PaperGroupId, objgs_PaperGroupEN.UpdUser);
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
 /// <param name = "objgs_PaperGroupEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsgs_PaperGroupEN objgs_PaperGroupEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objgs_PaperGroupEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!组名 = [{0}],修改人 = [{1}]的数据已经存在!(in clsgs_PaperGroupBL.AddNewRecordBySql2WithReturnKey)", objgs_PaperGroupEN.PaperGroupName,objgs_PaperGroupEN.UpdUser);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_PaperGroupEN.PaperGroupId) == true || clsgs_PaperGroupBL.IsExist(objgs_PaperGroupEN.PaperGroupId) == true)
 {
     objgs_PaperGroupEN.PaperGroupId = clsgs_PaperGroupBL.GetMaxStrId_S();
 }
string strKey = gs_PaperGroupDA.AddNewRecordBySQL2WithReturnKey(objgs_PaperGroupEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperGroupBL.ReFreshCache(objgs_PaperGroupEN.UpdUser);

if (clsgs_PaperGroupBL.relatedActions != null)
{
clsgs_PaperGroupBL.relatedActions.UpdRelaTabDate(objgs_PaperGroupEN.PaperGroupId, objgs_PaperGroupEN.UpdUser);
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
 /// <param name = "objgs_PaperGroupEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsgs_PaperGroupEN objgs_PaperGroupEN)
{
try
{
bool bolResult = gs_PaperGroupDA.Update(objgs_PaperGroupEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperGroupBL.ReFreshCache(objgs_PaperGroupEN.UpdUser);

if (clsgs_PaperGroupBL.relatedActions != null)
{
clsgs_PaperGroupBL.relatedActions.UpdRelaTabDate(objgs_PaperGroupEN.PaperGroupId, objgs_PaperGroupEN.UpdUser);
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
 /// <param name = "objgs_PaperGroupEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsgs_PaperGroupEN objgs_PaperGroupEN)
{
 if (string.IsNullOrEmpty(objgs_PaperGroupEN.PaperGroupId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = gs_PaperGroupDA.UpdateBySql2(objgs_PaperGroupEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperGroupBL.ReFreshCache(objgs_PaperGroupEN.UpdUser);

if (clsgs_PaperGroupBL.relatedActions != null)
{
clsgs_PaperGroupBL.relatedActions.UpdRelaTabDate(objgs_PaperGroupEN.PaperGroupId, objgs_PaperGroupEN.UpdUser);
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
 /// <param name = "strPaperGroupId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strPaperGroupId)
{
try
{
 clsgs_PaperGroupEN objgs_PaperGroupEN = clsgs_PaperGroupBL.GetObjByPaperGroupId(strPaperGroupId);

if (clsgs_PaperGroupBL.relatedActions != null)
{
clsgs_PaperGroupBL.relatedActions.UpdRelaTabDate(objgs_PaperGroupEN.PaperGroupId, objgs_PaperGroupEN.UpdUser);
}
if (objgs_PaperGroupEN != null)
{
int intRecNum = gs_PaperGroupDA.DelRecord(strPaperGroupId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objgs_PaperGroupEN.UpdUser);
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
/// <param name="strPaperGroupId">表关键字</param>
 /// <param name = "strUpdUser">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strPaperGroupId , string strUpdUser)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsgs_PaperGroupDA.GetSpecSQLObj();
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
//删除与表:[gs_PaperGroup]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//congs_PaperGroup.PaperGroupId,
//strPaperGroupId);
//        clsgs_PaperGroupBL.Delgs_PaperGroupsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsgs_PaperGroupBL.DelRecord(strPaperGroupId, strUpdUser, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsgs_PaperGroupBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strPaperGroupId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strPaperGroupId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strPaperGroupId, string strUpdUser, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsgs_PaperGroupBL.relatedActions != null)
{
clsgs_PaperGroupBL.relatedActions.UpdRelaTabDate(strPaperGroupId, "UpdRelaTabDate");
}
bool bolResult = gs_PaperGroupDA.DelRecord(strPaperGroupId,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(strUpdUser);
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
 /// <param name = "arrPaperGroupIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delgs_PaperGroups(List<string> arrPaperGroupIdLst)
{
if (arrPaperGroupIdLst.Count == 0) return 0;
try
{
if (clsgs_PaperGroupBL.relatedActions != null)
{
foreach (var strPaperGroupId in arrPaperGroupIdLst)
{
clsgs_PaperGroupBL.relatedActions.UpdRelaTabDate(strPaperGroupId, "UpdRelaTabDate");
}
}
 clsgs_PaperGroupEN objgs_PaperGroupEN = clsgs_PaperGroupBL.GetObjByPaperGroupId(arrPaperGroupIdLst[0]);
int intDelRecNum = gs_PaperGroupDA.Delgs_PaperGroup(arrPaperGroupIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objgs_PaperGroupEN.UpdUser);
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
public static int Delgs_PaperGroupsByCond(string strWhereCond)
{
try
{
if (clsgs_PaperGroupBL.relatedActions != null)
{
List<string> arrPaperGroupId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strPaperGroupId in arrPaperGroupId)
{
clsgs_PaperGroupBL.relatedActions.UpdRelaTabDate(strPaperGroupId, "UpdRelaTabDate");
}
}
List<string> arrUpdUser = GetFldValue(congs_PaperGroup.UpdUser, strWhereCond);
int intRecNum = gs_PaperGroupDA.Delgs_PaperGroup(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
arrUpdUser.ForEach(x => ReFreshCache(x));
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[gs_PaperGroup]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strPaperGroupId">表关键字</param>
 /// <param name = "strUpdUser">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strPaperGroupId, string strUpdUser)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsgs_PaperGroupDA.GetSpecSQLObj();
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
//删除与表:[gs_PaperGroup]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsgs_PaperGroupBL.DelRecord(strPaperGroupId, strUpdUser, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsgs_PaperGroupBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strPaperGroupId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objgs_PaperGroupENS">源对象</param>
 /// <param name = "objgs_PaperGroupENT">目标对象</param>
 public static void CopyTo(clsgs_PaperGroupEN objgs_PaperGroupENS, clsgs_PaperGroupEN objgs_PaperGroupENT)
{
try
{
objgs_PaperGroupENT.PaperGroupId = objgs_PaperGroupENS.PaperGroupId; //组Id
objgs_PaperGroupENT.PaperGroupName = objgs_PaperGroupENS.PaperGroupName; //组名
objgs_PaperGroupENT.UpdUser = objgs_PaperGroupENS.UpdUser; //修改人
objgs_PaperGroupENT.OrderNum = objgs_PaperGroupENS.OrderNum; //序号
objgs_PaperGroupENT.UpdDate = objgs_PaperGroupENS.UpdDate; //修改日期
objgs_PaperGroupENT.Meno = objgs_PaperGroupENS.Meno; //备注
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
 /// <param name = "objgs_PaperGroupEN">源简化对象</param>
 public static void SetUpdFlag(clsgs_PaperGroupEN objgs_PaperGroupEN)
{
try
{
objgs_PaperGroupEN.ClearUpdateState();
   string strsfUpdFldSetStr = objgs_PaperGroupEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(congs_PaperGroup.PaperGroupId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperGroupEN.PaperGroupId = objgs_PaperGroupEN.PaperGroupId; //组Id
}
if (arrFldSet.Contains(congs_PaperGroup.PaperGroupName, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperGroupEN.PaperGroupName = objgs_PaperGroupEN.PaperGroupName == "[null]" ? null :  objgs_PaperGroupEN.PaperGroupName; //组名
}
if (arrFldSet.Contains(congs_PaperGroup.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperGroupEN.UpdUser = objgs_PaperGroupEN.UpdUser; //修改人
}
if (arrFldSet.Contains(congs_PaperGroup.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperGroupEN.OrderNum = objgs_PaperGroupEN.OrderNum; //序号
}
if (arrFldSet.Contains(congs_PaperGroup.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperGroupEN.UpdDate = objgs_PaperGroupEN.UpdDate == "[null]" ? null :  objgs_PaperGroupEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(congs_PaperGroup.Meno, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperGroupEN.Meno = objgs_PaperGroupEN.Meno == "[null]" ? null :  objgs_PaperGroupEN.Meno; //备注
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
 /// <param name = "objgs_PaperGroupEN">源简化对象</param>
 public static void AccessFldValueNull(clsgs_PaperGroupEN objgs_PaperGroupEN)
{
try
{
if (objgs_PaperGroupEN.PaperGroupName == "[null]") objgs_PaperGroupEN.PaperGroupName = null; //组名
if (objgs_PaperGroupEN.UpdDate == "[null]") objgs_PaperGroupEN.UpdDate = null; //修改日期
if (objgs_PaperGroupEN.Meno == "[null]") objgs_PaperGroupEN.Meno = null; //备注
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
public static void CheckPropertyNew(clsgs_PaperGroupEN objgs_PaperGroupEN)
{
 gs_PaperGroupDA.CheckPropertyNew(objgs_PaperGroupEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsgs_PaperGroupEN objgs_PaperGroupEN)
{
 gs_PaperGroupDA.CheckProperty4Condition(objgs_PaperGroupEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_PaperGroupIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strUpdUser)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[论文分组]...","0");
List<clsgs_PaperGroupEN> arrgs_PaperGroupObjLst = GetAllgs_PaperGroupObjLstCache(strUpdUser); 
arrgs_PaperGroupObjLst = arrgs_PaperGroupObjLst.OrderBy(x=>x.OrderNum).ToList(); 
objDDL.DataValueField = congs_PaperGroup.PaperGroupId;
objDDL.DataTextField = congs_PaperGroup.PaperGroupName;
objDDL.DataSource = arrgs_PaperGroupObjLst;
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
if (clsgs_PaperGroupBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_PaperGroupBL没有刷新缓存机制(clsgs_PaperGroupBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PaperGroupId");
//if (arrgs_PaperGroupObjLstCache == null)
//{
//arrgs_PaperGroupObjLstCache = gs_PaperGroupDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strPaperGroupId">所给的关键字</param>
 /// <param name = "strUpdUser">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_PaperGroupEN GetObjByPaperGroupIdCache(string strPaperGroupId, string strUpdUser)
{

if (string.IsNullOrEmpty(strUpdUser) == true)
{
  var strMsg = string.Format("参数:[strUpdUser]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsgs_PaperGroupEN._CurrTabName, strUpdUser);
List<clsgs_PaperGroupEN> arrgs_PaperGroupObjLstCache = GetObjLstCache(strUpdUser);
IEnumerable <clsgs_PaperGroupEN> arrgs_PaperGroupObjLst_Sel =
arrgs_PaperGroupObjLstCache
.Where(x=> x.PaperGroupId == strPaperGroupId 
);
if (arrgs_PaperGroupObjLst_Sel.Count() == 0)
{
   clsgs_PaperGroupEN obj = clsgs_PaperGroupBL.GetObjByPaperGroupId(strPaperGroupId);
   if (obj != null)
 {
if (obj.UpdUser == strUpdUser)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strPaperGroupId, strUpdUser, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrgs_PaperGroupObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strPaperGroupId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetPaperGroupNameByPaperGroupIdCache(string strPaperGroupId, string strUpdUser)
{
if (string.IsNullOrEmpty(strPaperGroupId) == true) return "";
//获取缓存中的对象列表
clsgs_PaperGroupEN objgs_PaperGroup = GetObjByPaperGroupIdCache(strPaperGroupId, strUpdUser);
if (objgs_PaperGroup == null) return "";
return objgs_PaperGroup.PaperGroupName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strPaperGroupId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByPaperGroupIdCache(string strPaperGroupId, string strUpdUser)
{
if (string.IsNullOrEmpty(strPaperGroupId) == true) return "";
//获取缓存中的对象列表
clsgs_PaperGroupEN objgs_PaperGroup = GetObjByPaperGroupIdCache(strPaperGroupId, strUpdUser);
if (objgs_PaperGroup == null) return "";
return objgs_PaperGroup.PaperGroupName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_PaperGroupEN> GetAllgs_PaperGroupObjLstCache(string strUpdUser)
{
//获取缓存中的对象列表
List<clsgs_PaperGroupEN> arrgs_PaperGroupObjLstCache = GetObjLstCache(strUpdUser); 
return arrgs_PaperGroupObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_PaperGroupEN> GetObjLstCache(string strUpdUser)
{

if (string.IsNullOrEmpty(strUpdUser) == true)
{
  var strMsg = string.Format("参数:[strUpdUser]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsgs_PaperGroupEN._CurrTabName, strUpdUser);
string strCondition = string.Format("UpdUser='{0}'", strUpdUser);
List<clsgs_PaperGroupEN> arrgs_PaperGroupObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrgs_PaperGroupObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strUpdUser = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsgs_PaperGroupEN._CurrTabName, strUpdUser);
CacheHelper.Remove(strKey);
clsgs_PaperGroupEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsgs_PaperGroupEN._RefreshTimeLst.Count == 0) return "";
return clsgs_PaperGroupEN._RefreshTimeLst[clsgs_PaperGroupEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strUpdUser)
{
if (string.IsNullOrEmpty(strUpdUser) == true)
{
string strMsg = string.Format("缓存分类字段:[UpdUser]不能为空!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsgs_PaperGroupBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsgs_PaperGroupEN._CurrTabName, strUpdUser);
CacheHelper.Remove(strKey);
clsgs_PaperGroupEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsgs_PaperGroupBL.objCommFun4BL.ReFreshCache(strUpdUser);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--gs_PaperGroup(论文分组)
 /// 唯一性条件:PaperGroupName_UpdUser
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objgs_PaperGroupEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsgs_PaperGroupEN objgs_PaperGroupEN)
{
//检测记录是否存在
string strResult = gs_PaperGroupDA.GetUniCondStr(objgs_PaperGroupEN);
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
 /// <param name = "strUpdUser">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strPaperGroupId, string strUpdUser)
{
if (strInFldName != congs_PaperGroup.PaperGroupId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (congs_PaperGroup.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", congs_PaperGroup.AttributeName));
throw new Exception(strMsg);
}
var objgs_PaperGroup = clsgs_PaperGroupBL.GetObjByPaperGroupIdCache(strPaperGroupId, strUpdUser);
if (objgs_PaperGroup == null) return "";
return objgs_PaperGroup[strOutFldName].ToString();
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
int intRecCount = clsgs_PaperGroupDA.GetRecCount(strTabName);
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
int intRecCount = clsgs_PaperGroupDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsgs_PaperGroupDA.GetRecCount();
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
int intRecCount = clsgs_PaperGroupDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objgs_PaperGroupCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsgs_PaperGroupEN objgs_PaperGroupCond)
{
 string strUpdUser = objgs_PaperGroupCond.UpdUser;
 if (string.IsNullOrEmpty(strUpdUser) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsgs_PaperGroupBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsgs_PaperGroupEN> arrObjLstCache = GetObjLstCache(strUpdUser);
IEnumerable <clsgs_PaperGroupEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in congs_PaperGroup.AttributeName)
{
if (objgs_PaperGroupCond.IsUpdated(strFldName) == false) continue;
if (objgs_PaperGroupCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_PaperGroupCond[strFldName].ToString());
}
else
{
if (objgs_PaperGroupCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objgs_PaperGroupCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_PaperGroupCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objgs_PaperGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objgs_PaperGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objgs_PaperGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objgs_PaperGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objgs_PaperGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objgs_PaperGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objgs_PaperGroupCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objgs_PaperGroupCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objgs_PaperGroupCond[strFldName]));
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
 List<string> arrList = clsgs_PaperGroupDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = gs_PaperGroupDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = gs_PaperGroupDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = gs_PaperGroupDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsgs_PaperGroupDA.SetFldValue(clsgs_PaperGroupEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = gs_PaperGroupDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsgs_PaperGroupDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsgs_PaperGroupDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsgs_PaperGroupDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[gs_PaperGroup] "); 
 strCreateTabCode.Append(" ( "); 
 // /**组Id*/ 
 strCreateTabCode.Append(" PaperGroupId char(8) primary key, "); 
 // /**组名*/ 
 strCreateTabCode.Append(" PaperGroupName varchar(50) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) not Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Meno varchar(2000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 排序相关函数

/// <summary>
/// 重新排序。根据分类字段：UpdUser单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ReOrder)
/// </summary>
/// <param name="strUpdUser">分类字段</param>
/// <returns></returns>
public static bool ReOrder(string strUpdUser)
{
try
{
string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", congs_PaperGroup.UpdUser, strUpdUser);
 strCondition += string.Format(" order by OrderNum ");
List<clsgs_PaperGroupEN> arrgs_PaperGroupObjList = new clsgs_PaperGroupDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsgs_PaperGroupEN objgs_PaperGroup in arrgs_PaperGroupObjList)
{
objgs_PaperGroup.OrderNum = intIndex;
UpdateBySql2(objgs_PaperGroup);
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
/// 调整所给关键字记录的序号。根据分类字段：UpdUser单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_AdjustOrderNum)
/// </summary>
/// <param name="strDirect">方向：用"Up","Down"表示</param>
/// <param name="strPaperGroupId">所给的关键字</param>
/// <param name="strUpdUser">分类字段</param>
/// <returns>是否成功?</returns>
public static bool AdjustOrderNum(string strDirect, string strPaperGroupId ,string strUpdUser)
{
try
{
//操作步骤：
//1、根据所给定的关键字[PaperGroupId],获取相应的序号[OrderNum]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//   3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字PaperGroupId
//5、把当前关键字PaperGroupId所对应记录的序号加(减)1
//6、把下(上)一个序号关键字PaperGroupId所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
string strPrevPaperGroupId = "";    //上一条序号的关键字PaperGroupId
string strNextPaperGroupId = "";    //下一条序号的关键字PaperGroupId
int intTabRecNum;       //当前表中字段的记录数
StringBuilder sbCondition = new StringBuilder();
//1、根据所给定的关键字[PaperGroupId],获取相应的序号[OrderNum]。

clsgs_PaperGroupEN objgs_PaperGroup = clsgs_PaperGroupBL.GetObjByPaperGroupId(strPaperGroupId);

intOrderNum = objgs_PaperGroup.OrderNum ?? 0;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", congs_PaperGroup.UpdUser, strUpdUser);
intTabRecNum = clsgs_PaperGroupBL.GetRecCountByCond(clsgs_PaperGroupEN._CurrTabName, strCondition);    //获取当前表的记录数
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
sbCondition.AppendFormat(" {0} = {1} ", congs_PaperGroup.OrderNum, intOrderNum - 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", congs_PaperGroup.UpdUser, strUpdUser);
//4、获取上一个序号字段的关键字PaperGroupId
strPrevPaperGroupId = clsgs_PaperGroupBL.GetFirstID_S(sbCondition.ToString());
if (string.IsNullOrEmpty(strPrevPaperGroupId) == true)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字PaperGroupId所对应记录的序号减1
//6、把下(上)一个序号关键字PaperGroupId所对应的记录序号加1
clsgs_PaperGroupBL.SetFldValue(clsgs_PaperGroupEN._CurrTabName, congs_PaperGroup.OrderNum,
 	 	intOrderNum - 1,
  	 	string.Format("{0} = '{1}'", congs_PaperGroup.PaperGroupId, strPaperGroupId));
clsgs_PaperGroupBL.SetFldValue(clsgs_PaperGroupEN._CurrTabName, congs_PaperGroup.OrderNum,
 	 	intPrevOrderNum + 1,
 	 	string.Format("{0} = '{1}'", congs_PaperGroup.PaperGroupId, strPrevPaperGroupId));
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

//4、获取下一个序号字段的关键字PaperGroupId
sbCondition.AppendFormat(" {0} = {1} ", congs_PaperGroup.OrderNum, intOrderNum + 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", congs_PaperGroup.UpdUser, strUpdUser);

strNextPaperGroupId = clsgs_PaperGroupBL.GetFirstID_S(sbCondition.ToString());
if (string.IsNullOrEmpty(strNextPaperGroupId) == true)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字PaperGroupId所对应记录的序号加1
//6、把下(上)一个序号关键字PaperGroupId所对应的记录序号减1
clsgs_PaperGroupBL.SetFldValue(clsgs_PaperGroupEN._CurrTabName, congs_PaperGroup.OrderNum,
 	 	intOrderNum + 1,
 	 	string.Format("{0} = '{1}'", congs_PaperGroup.PaperGroupId, strPaperGroupId));
clsgs_PaperGroupBL.SetFldValue(clsgs_PaperGroupEN._CurrTabName, congs_PaperGroup.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", congs_PaperGroup.PaperGroupId, strNextPaperGroupId));
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
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：UpdUser单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoBottom)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoBottom(List<string> arrKeyId ,string strUpdUser)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", congs_PaperGroup.PaperGroupId, strKeyList);
List<clsgs_PaperGroupEN> arrgs_PaperGroupLst = GetObjLst(strCondition);
foreach (clsgs_PaperGroupEN objgs_PaperGroup in arrgs_PaperGroupLst)
{
objgs_PaperGroup.OrderNum = objgs_PaperGroup.OrderNum + 10000;
UpdateBySql2(objgs_PaperGroup);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", congs_PaperGroup.UpdUser, strUpdUser);
 strCondition += string.Format(" order by OrderNum ");
List<clsgs_PaperGroupEN> arrgs_PaperGroupObjList = new clsgs_PaperGroupDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsgs_PaperGroupEN objgs_PaperGroup in arrgs_PaperGroupObjList)
{
objgs_PaperGroup.OrderNum = intIndex;
UpdateBySql2(objgs_PaperGroup);
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
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：UpdUser单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoTop)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <param name="strUpdUser">分类字段</param>
/// <returns></returns>
public static bool GoTop(List<string> arrKeyId ,string strUpdUser)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", congs_PaperGroup.PaperGroupId, strKeyList);
List<clsgs_PaperGroupEN> arrgs_PaperGroupLst = GetObjLst(strCondition);
foreach (clsgs_PaperGroupEN objgs_PaperGroup in arrgs_PaperGroupLst)
{
objgs_PaperGroup.OrderNum = objgs_PaperGroup.OrderNum - 10000;
UpdateBySql2(objgs_PaperGroup);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", congs_PaperGroup.UpdUser, strUpdUser);
 strCondition += string.Format(" order by OrderNum ");
List<clsgs_PaperGroupEN> arrgs_PaperGroupObjList = new clsgs_PaperGroupDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsgs_PaperGroupEN objgs_PaperGroup in arrgs_PaperGroupObjList)
{
objgs_PaperGroup.OrderNum = intIndex;
UpdateBySql2(objgs_PaperGroup);
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
 /// 论文分组(gs_PaperGroup)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4gs_PaperGroup : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strUpdUser)
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
clsgs_PaperGroupBL.ReFreshThisCache(strUpdUser);
}
}

}