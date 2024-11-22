
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_TopicRoleBL
 表名:gs_TopicRole(01120869)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:11:21
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
public static class  clsgs_TopicRoleBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strTopicRoleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_TopicRoleEN GetObj(this K_TopicRoleId_gs_TopicRole myKey)
{
clsgs_TopicRoleEN objgs_TopicRoleEN = clsgs_TopicRoleBL.gs_TopicRoleDA.GetObjByTopicRoleId(myKey.Value);
return objgs_TopicRoleEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objgs_TopicRoleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsgs_TopicRoleEN objgs_TopicRoleEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_TopicRoleEN) == false)
{
var strMsg = string.Format("记录已经存在!主题权限Id = [{0}]的数据已经存在!(in clsgs_TopicRoleBL.AddNewRecord)", objgs_TopicRoleEN.TopicRoleId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_TopicRoleEN.TopicRoleId) == true || clsgs_TopicRoleBL.IsExist(objgs_TopicRoleEN.TopicRoleId) == true)
 {
     objgs_TopicRoleEN.TopicRoleId = clsgs_TopicRoleBL.GetMaxStrId_S();
 }
bool bolResult = clsgs_TopicRoleBL.gs_TopicRoleDA.AddNewRecordBySQL2(objgs_TopicRoleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TopicRoleBL.ReFreshCache();

if (clsgs_TopicRoleBL.relatedActions != null)
{
clsgs_TopicRoleBL.relatedActions.UpdRelaTabDate(objgs_TopicRoleEN.TopicRoleId, "SetUpdDate");
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
public static bool AddRecordEx(this clsgs_TopicRoleEN objgs_TopicRoleEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsgs_TopicRoleBL.IsExist(objgs_TopicRoleEN.TopicRoleId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objgs_TopicRoleEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objgs_TopicRoleEN.CheckUniqueness() == false)
{
strMsg = string.Format("(主题权限Id(TopicRoleId)=[{0}])已经存在,不能重复!", objgs_TopicRoleEN.TopicRoleId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objgs_TopicRoleEN.TopicRoleId) == true || clsgs_TopicRoleBL.IsExist(objgs_TopicRoleEN.TopicRoleId) == true)
 {
     objgs_TopicRoleEN.TopicRoleId = clsgs_TopicRoleBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objgs_TopicRoleEN.AddNewRecord();
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
 /// <param name = "objgs_TopicRoleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsgs_TopicRoleEN objgs_TopicRoleEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_TopicRoleEN) == false)
{
var strMsg = string.Format("记录已经存在!主题权限Id = [{0}]的数据已经存在!(in clsgs_TopicRoleBL.AddNewRecordWithMaxId)", objgs_TopicRoleEN.TopicRoleId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_TopicRoleEN.TopicRoleId) == true || clsgs_TopicRoleBL.IsExist(objgs_TopicRoleEN.TopicRoleId) == true)
 {
     objgs_TopicRoleEN.TopicRoleId = clsgs_TopicRoleBL.GetMaxStrId_S();
 }
string strTopicRoleId = clsgs_TopicRoleBL.gs_TopicRoleDA.AddNewRecordBySQL2WithReturnKey(objgs_TopicRoleEN);
     objgs_TopicRoleEN.TopicRoleId = strTopicRoleId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TopicRoleBL.ReFreshCache();

if (clsgs_TopicRoleBL.relatedActions != null)
{
clsgs_TopicRoleBL.relatedActions.UpdRelaTabDate(objgs_TopicRoleEN.TopicRoleId, "SetUpdDate");
}
return strTopicRoleId;
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
 /// <param name = "objgs_TopicRoleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsgs_TopicRoleEN objgs_TopicRoleEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_TopicRoleEN) == false)
{
var strMsg = string.Format("记录已经存在!主题权限Id = [{0}]的数据已经存在!(in clsgs_TopicRoleBL.AddNewRecordWithReturnKey)", objgs_TopicRoleEN.TopicRoleId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_TopicRoleEN.TopicRoleId) == true || clsgs_TopicRoleBL.IsExist(objgs_TopicRoleEN.TopicRoleId) == true)
 {
     objgs_TopicRoleEN.TopicRoleId = clsgs_TopicRoleBL.GetMaxStrId_S();
 }
string strKey = clsgs_TopicRoleBL.gs_TopicRoleDA.AddNewRecordBySQL2WithReturnKey(objgs_TopicRoleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TopicRoleBL.ReFreshCache();

if (clsgs_TopicRoleBL.relatedActions != null)
{
clsgs_TopicRoleBL.relatedActions.UpdRelaTabDate(objgs_TopicRoleEN.TopicRoleId, "SetUpdDate");
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
 /// <param name = "objgs_TopicRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TopicRoleEN SetTopicRoleId(this clsgs_TopicRoleEN objgs_TopicRoleEN, string strTopicRoleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicRoleId, 10, congs_TopicRole.TopicRoleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTopicRoleId, 10, congs_TopicRole.TopicRoleId);
}
objgs_TopicRoleEN.TopicRoleId = strTopicRoleId; //主题权限Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TopicRoleEN.dicFldComparisonOp.ContainsKey(congs_TopicRole.TopicRoleId) == false)
{
objgs_TopicRoleEN.dicFldComparisonOp.Add(congs_TopicRole.TopicRoleId, strComparisonOp);
}
else
{
objgs_TopicRoleEN.dicFldComparisonOp[congs_TopicRole.TopicRoleId] = strComparisonOp;
}
}
return objgs_TopicRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_TopicRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TopicRoleEN SetTopicId(this clsgs_TopicRoleEN objgs_TopicRoleEN, string strTopicId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicId, 8, congs_TopicRole.TopicId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTopicId, 8, congs_TopicRole.TopicId);
}
objgs_TopicRoleEN.TopicId = strTopicId; //主题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TopicRoleEN.dicFldComparisonOp.ContainsKey(congs_TopicRole.TopicId) == false)
{
objgs_TopicRoleEN.dicFldComparisonOp.Add(congs_TopicRole.TopicId, strComparisonOp);
}
else
{
objgs_TopicRoleEN.dicFldComparisonOp[congs_TopicRole.TopicId] = strComparisonOp;
}
}
return objgs_TopicRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_TopicRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TopicRoleEN SetMenuNum(this clsgs_TopicRoleEN objgs_TopicRoleEN, string strMenuNum, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuNum, 10, congs_TopicRole.MenuNum);
}
objgs_TopicRoleEN.MenuNum = strMenuNum; //菜单编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TopicRoleEN.dicFldComparisonOp.ContainsKey(congs_TopicRole.MenuNum) == false)
{
objgs_TopicRoleEN.dicFldComparisonOp.Add(congs_TopicRole.MenuNum, strComparisonOp);
}
else
{
objgs_TopicRoleEN.dicFldComparisonOp[congs_TopicRole.MenuNum] = strComparisonOp;
}
}
return objgs_TopicRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_TopicRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TopicRoleEN SetMenuName(this clsgs_TopicRoleEN objgs_TopicRoleEN, string strMenuName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuName, 100, congs_TopicRole.MenuName);
}
objgs_TopicRoleEN.MenuName = strMenuName; //菜单名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TopicRoleEN.dicFldComparisonOp.ContainsKey(congs_TopicRole.MenuName) == false)
{
objgs_TopicRoleEN.dicFldComparisonOp.Add(congs_TopicRole.MenuName, strComparisonOp);
}
else
{
objgs_TopicRoleEN.dicFldComparisonOp[congs_TopicRole.MenuName] = strComparisonOp;
}
}
return objgs_TopicRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_TopicRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TopicRoleEN SetMenuIsHide(this clsgs_TopicRoleEN objgs_TopicRoleEN, bool bolMenuIsHide, string strComparisonOp="")
	{
objgs_TopicRoleEN.MenuIsHide = bolMenuIsHide; //菜单是否隐藏
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TopicRoleEN.dicFldComparisonOp.ContainsKey(congs_TopicRole.MenuIsHide) == false)
{
objgs_TopicRoleEN.dicFldComparisonOp.Add(congs_TopicRole.MenuIsHide, strComparisonOp);
}
else
{
objgs_TopicRoleEN.dicFldComparisonOp[congs_TopicRole.MenuIsHide] = strComparisonOp;
}
}
return objgs_TopicRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_TopicRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TopicRoleEN SetUpdDate(this clsgs_TopicRoleEN objgs_TopicRoleEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, congs_TopicRole.UpdDate);
}
objgs_TopicRoleEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TopicRoleEN.dicFldComparisonOp.ContainsKey(congs_TopicRole.UpdDate) == false)
{
objgs_TopicRoleEN.dicFldComparisonOp.Add(congs_TopicRole.UpdDate, strComparisonOp);
}
else
{
objgs_TopicRoleEN.dicFldComparisonOp[congs_TopicRole.UpdDate] = strComparisonOp;
}
}
return objgs_TopicRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_TopicRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TopicRoleEN SetUpdUser(this clsgs_TopicRoleEN objgs_TopicRoleEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, congs_TopicRole.UpdUser);
}
objgs_TopicRoleEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TopicRoleEN.dicFldComparisonOp.ContainsKey(congs_TopicRole.UpdUser) == false)
{
objgs_TopicRoleEN.dicFldComparisonOp.Add(congs_TopicRole.UpdUser, strComparisonOp);
}
else
{
objgs_TopicRoleEN.dicFldComparisonOp[congs_TopicRole.UpdUser] = strComparisonOp;
}
}
return objgs_TopicRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_TopicRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TopicRoleEN SetMemo(this clsgs_TopicRoleEN objgs_TopicRoleEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, congs_TopicRole.Memo);
}
objgs_TopicRoleEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TopicRoleEN.dicFldComparisonOp.ContainsKey(congs_TopicRole.Memo) == false)
{
objgs_TopicRoleEN.dicFldComparisonOp.Add(congs_TopicRole.Memo, strComparisonOp);
}
else
{
objgs_TopicRoleEN.dicFldComparisonOp[congs_TopicRole.Memo] = strComparisonOp;
}
}
return objgs_TopicRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_TopicRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TopicRoleEN SetIsDefault(this clsgs_TopicRoleEN objgs_TopicRoleEN, bool bolIsDefault, string strComparisonOp="")
	{
objgs_TopicRoleEN.IsDefault = bolIsDefault; //是否默认
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TopicRoleEN.dicFldComparisonOp.ContainsKey(congs_TopicRole.IsDefault) == false)
{
objgs_TopicRoleEN.dicFldComparisonOp.Add(congs_TopicRole.IsDefault, strComparisonOp);
}
else
{
objgs_TopicRoleEN.dicFldComparisonOp[congs_TopicRole.IsDefault] = strComparisonOp;
}
}
return objgs_TopicRoleEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objgs_TopicRoleEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsgs_TopicRoleEN objgs_TopicRoleEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objgs_TopicRoleEN.CheckPropertyNew();
clsgs_TopicRoleEN objgs_TopicRoleCond = new clsgs_TopicRoleEN();
string strCondition = objgs_TopicRoleCond
.SetTopicRoleId(objgs_TopicRoleEN.TopicRoleId, "<>")
.SetTopicRoleId(objgs_TopicRoleEN.TopicRoleId, "=")
.GetCombineCondition();
objgs_TopicRoleEN._IsCheckProperty = true;
bool bolIsExist = clsgs_TopicRoleBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(TopicRoleId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objgs_TopicRoleEN.Update();
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
 /// <param name = "objgs_TopicRole">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsgs_TopicRoleEN objgs_TopicRole)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsgs_TopicRoleEN objgs_TopicRoleCond = new clsgs_TopicRoleEN();
string strCondition = objgs_TopicRoleCond
.SetTopicRoleId(objgs_TopicRole.TopicRoleId, "=")
.GetCombineCondition();
objgs_TopicRole._IsCheckProperty = true;
bool bolIsExist = clsgs_TopicRoleBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objgs_TopicRole.TopicRoleId = clsgs_TopicRoleBL.GetFirstID_S(strCondition);
objgs_TopicRole.UpdateWithCondition(strCondition);
}
else
{
objgs_TopicRole.TopicRoleId = clsgs_TopicRoleBL.GetMaxStrId_S();
objgs_TopicRole.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objgs_TopicRoleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_TopicRoleEN objgs_TopicRoleEN)
{
 if (string.IsNullOrEmpty(objgs_TopicRoleEN.TopicRoleId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsgs_TopicRoleBL.gs_TopicRoleDA.UpdateBySql2(objgs_TopicRoleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TopicRoleBL.ReFreshCache();

if (clsgs_TopicRoleBL.relatedActions != null)
{
clsgs_TopicRoleBL.relatedActions.UpdRelaTabDate(objgs_TopicRoleEN.TopicRoleId, "SetUpdDate");
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
 /// <param name = "objgs_TopicRoleEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_TopicRoleEN objgs_TopicRoleEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objgs_TopicRoleEN.TopicRoleId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsgs_TopicRoleBL.gs_TopicRoleDA.UpdateBySql2(objgs_TopicRoleEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TopicRoleBL.ReFreshCache();

if (clsgs_TopicRoleBL.relatedActions != null)
{
clsgs_TopicRoleBL.relatedActions.UpdRelaTabDate(objgs_TopicRoleEN.TopicRoleId, "SetUpdDate");
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
 /// <param name = "objgs_TopicRoleEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_TopicRoleEN objgs_TopicRoleEN, string strWhereCond)
{
try
{
bool bolResult = clsgs_TopicRoleBL.gs_TopicRoleDA.UpdateBySqlWithCondition(objgs_TopicRoleEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TopicRoleBL.ReFreshCache();

if (clsgs_TopicRoleBL.relatedActions != null)
{
clsgs_TopicRoleBL.relatedActions.UpdRelaTabDate(objgs_TopicRoleEN.TopicRoleId, "SetUpdDate");
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
 /// <param name = "objgs_TopicRoleEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_TopicRoleEN objgs_TopicRoleEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsgs_TopicRoleBL.gs_TopicRoleDA.UpdateBySqlWithConditionTransaction(objgs_TopicRoleEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TopicRoleBL.ReFreshCache();

if (clsgs_TopicRoleBL.relatedActions != null)
{
clsgs_TopicRoleBL.relatedActions.UpdRelaTabDate(objgs_TopicRoleEN.TopicRoleId, "SetUpdDate");
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
 /// <param name = "strTopicRoleId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsgs_TopicRoleEN objgs_TopicRoleEN)
{
try
{
int intRecNum = clsgs_TopicRoleBL.gs_TopicRoleDA.DelRecord(objgs_TopicRoleEN.TopicRoleId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TopicRoleBL.ReFreshCache();

if (clsgs_TopicRoleBL.relatedActions != null)
{
clsgs_TopicRoleBL.relatedActions.UpdRelaTabDate(objgs_TopicRoleEN.TopicRoleId, "SetUpdDate");
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
 /// <param name = "objgs_TopicRoleENS">源对象</param>
 /// <param name = "objgs_TopicRoleENT">目标对象</param>
 public static void CopyTo(this clsgs_TopicRoleEN objgs_TopicRoleENS, clsgs_TopicRoleEN objgs_TopicRoleENT)
{
try
{
objgs_TopicRoleENT.TopicRoleId = objgs_TopicRoleENS.TopicRoleId; //主题权限Id
objgs_TopicRoleENT.TopicId = objgs_TopicRoleENS.TopicId; //主题Id
objgs_TopicRoleENT.MenuNum = objgs_TopicRoleENS.MenuNum; //菜单编号
objgs_TopicRoleENT.MenuName = objgs_TopicRoleENS.MenuName; //菜单名称
objgs_TopicRoleENT.MenuIsHide = objgs_TopicRoleENS.MenuIsHide; //菜单是否隐藏
objgs_TopicRoleENT.UpdDate = objgs_TopicRoleENS.UpdDate; //修改日期
objgs_TopicRoleENT.UpdUser = objgs_TopicRoleENS.UpdUser; //修改人
objgs_TopicRoleENT.Memo = objgs_TopicRoleENS.Memo; //备注
objgs_TopicRoleENT.IsDefault = objgs_TopicRoleENS.IsDefault; //是否默认
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
 /// <param name = "objgs_TopicRoleENS">源对象</param>
 /// <returns>目标对象=>clsgs_TopicRoleEN:objgs_TopicRoleENT</returns>
 public static clsgs_TopicRoleEN CopyTo(this clsgs_TopicRoleEN objgs_TopicRoleENS)
{
try
{
 clsgs_TopicRoleEN objgs_TopicRoleENT = new clsgs_TopicRoleEN()
{
TopicRoleId = objgs_TopicRoleENS.TopicRoleId, //主题权限Id
TopicId = objgs_TopicRoleENS.TopicId, //主题Id
MenuNum = objgs_TopicRoleENS.MenuNum, //菜单编号
MenuName = objgs_TopicRoleENS.MenuName, //菜单名称
MenuIsHide = objgs_TopicRoleENS.MenuIsHide, //菜单是否隐藏
UpdDate = objgs_TopicRoleENS.UpdDate, //修改日期
UpdUser = objgs_TopicRoleENS.UpdUser, //修改人
Memo = objgs_TopicRoleENS.Memo, //备注
IsDefault = objgs_TopicRoleENS.IsDefault, //是否默认
};
 return objgs_TopicRoleENT;
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
public static void CheckPropertyNew(this clsgs_TopicRoleEN objgs_TopicRoleEN)
{
 clsgs_TopicRoleBL.gs_TopicRoleDA.CheckPropertyNew(objgs_TopicRoleEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsgs_TopicRoleEN objgs_TopicRoleEN)
{
 clsgs_TopicRoleBL.gs_TopicRoleDA.CheckProperty4Condition(objgs_TopicRoleEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsgs_TopicRoleEN objgs_TopicRoleCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objgs_TopicRoleCond.IsUpdated(congs_TopicRole.TopicRoleId) == true)
{
string strComparisonOpTopicRoleId = objgs_TopicRoleCond.dicFldComparisonOp[congs_TopicRole.TopicRoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_TopicRole.TopicRoleId, objgs_TopicRoleCond.TopicRoleId, strComparisonOpTopicRoleId);
}
if (objgs_TopicRoleCond.IsUpdated(congs_TopicRole.TopicId) == true)
{
string strComparisonOpTopicId = objgs_TopicRoleCond.dicFldComparisonOp[congs_TopicRole.TopicId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_TopicRole.TopicId, objgs_TopicRoleCond.TopicId, strComparisonOpTopicId);
}
if (objgs_TopicRoleCond.IsUpdated(congs_TopicRole.MenuNum) == true)
{
string strComparisonOpMenuNum = objgs_TopicRoleCond.dicFldComparisonOp[congs_TopicRole.MenuNum];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_TopicRole.MenuNum, objgs_TopicRoleCond.MenuNum, strComparisonOpMenuNum);
}
if (objgs_TopicRoleCond.IsUpdated(congs_TopicRole.MenuName) == true)
{
string strComparisonOpMenuName = objgs_TopicRoleCond.dicFldComparisonOp[congs_TopicRole.MenuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_TopicRole.MenuName, objgs_TopicRoleCond.MenuName, strComparisonOpMenuName);
}
if (objgs_TopicRoleCond.IsUpdated(congs_TopicRole.MenuIsHide) == true)
{
if (objgs_TopicRoleCond.MenuIsHide == true)
{
strWhereCond += string.Format(" And {0} = '1'", congs_TopicRole.MenuIsHide);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", congs_TopicRole.MenuIsHide);
}
}
if (objgs_TopicRoleCond.IsUpdated(congs_TopicRole.UpdDate) == true)
{
string strComparisonOpUpdDate = objgs_TopicRoleCond.dicFldComparisonOp[congs_TopicRole.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_TopicRole.UpdDate, objgs_TopicRoleCond.UpdDate, strComparisonOpUpdDate);
}
if (objgs_TopicRoleCond.IsUpdated(congs_TopicRole.UpdUser) == true)
{
string strComparisonOpUpdUser = objgs_TopicRoleCond.dicFldComparisonOp[congs_TopicRole.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_TopicRole.UpdUser, objgs_TopicRoleCond.UpdUser, strComparisonOpUpdUser);
}
if (objgs_TopicRoleCond.IsUpdated(congs_TopicRole.Memo) == true)
{
string strComparisonOpMemo = objgs_TopicRoleCond.dicFldComparisonOp[congs_TopicRole.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_TopicRole.Memo, objgs_TopicRoleCond.Memo, strComparisonOpMemo);
}
if (objgs_TopicRoleCond.IsUpdated(congs_TopicRole.IsDefault) == true)
{
if (objgs_TopicRoleCond.IsDefault == true)
{
strWhereCond += string.Format(" And {0} = '1'", congs_TopicRole.IsDefault);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", congs_TopicRole.IsDefault);
}
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--gs_TopicRole(主题权限表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:TopicRoleId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objgs_TopicRoleEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsgs_TopicRoleEN objgs_TopicRoleEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objgs_TopicRoleEN == null) return true;
if (objgs_TopicRoleEN.TopicRoleId == null || objgs_TopicRoleEN.TopicRoleId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TopicRoleId = '{0}'", objgs_TopicRoleEN.TopicRoleId);
if (clsgs_TopicRoleBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("TopicRoleId !=  '{0}'", objgs_TopicRoleEN.TopicRoleId);
 sbCondition.AppendFormat(" and TopicRoleId = '{0}'", objgs_TopicRoleEN.TopicRoleId);
if (clsgs_TopicRoleBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--gs_TopicRole(主题权限表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:TopicRoleId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objgs_TopicRoleEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsgs_TopicRoleEN objgs_TopicRoleEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objgs_TopicRoleEN == null) return "";
if (objgs_TopicRoleEN.TopicRoleId == null || objgs_TopicRoleEN.TopicRoleId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TopicRoleId = '{0}'", objgs_TopicRoleEN.TopicRoleId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("TopicRoleId !=  '{0}'", objgs_TopicRoleEN.TopicRoleId);
 sbCondition.AppendFormat(" and TopicRoleId = '{0}'", objgs_TopicRoleEN.TopicRoleId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_gs_TopicRole
{
public virtual bool UpdRelaTabDate(string strTopicRoleId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 主题权限表(gs_TopicRole)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsgs_TopicRoleBL
{
public static RelatedActions_gs_TopicRole relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsgs_TopicRoleDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsgs_TopicRoleDA gs_TopicRoleDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsgs_TopicRoleDA();
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
 public clsgs_TopicRoleBL()
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
if (string.IsNullOrEmpty(clsgs_TopicRoleEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsgs_TopicRoleEN._ConnectString);
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
public static DataTable GetDataTable_gs_TopicRole(string strWhereCond)
{
DataTable objDT;
try
{
objDT = gs_TopicRoleDA.GetDataTable_gs_TopicRole(strWhereCond);
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
objDT = gs_TopicRoleDA.GetDataTable(strWhereCond);
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
objDT = gs_TopicRoleDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = gs_TopicRoleDA.GetDataTable(strWhereCond, strTabName);
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
objDT = gs_TopicRoleDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = gs_TopicRoleDA.GetDataTable_Top(objTopPara);
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
objDT = gs_TopicRoleDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = gs_TopicRoleDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = gs_TopicRoleDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrTopicRoleIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsgs_TopicRoleEN> GetObjLstByTopicRoleIdLst(List<string> arrTopicRoleIdLst)
{
List<clsgs_TopicRoleEN> arrObjLst = new List<clsgs_TopicRoleEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrTopicRoleIdLst, true);
 string strWhereCond = string.Format("TopicRoleId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_TopicRoleEN objgs_TopicRoleEN = new clsgs_TopicRoleEN();
try
{
objgs_TopicRoleEN.TopicRoleId = objRow[congs_TopicRole.TopicRoleId].ToString().Trim(); //主题权限Id
objgs_TopicRoleEN.TopicId = objRow[congs_TopicRole.TopicId] == DBNull.Value ? null : objRow[congs_TopicRole.TopicId].ToString().Trim(); //主题Id
objgs_TopicRoleEN.MenuNum = objRow[congs_TopicRole.MenuNum] == DBNull.Value ? null : objRow[congs_TopicRole.MenuNum].ToString().Trim(); //菜单编号
objgs_TopicRoleEN.MenuName = objRow[congs_TopicRole.MenuName] == DBNull.Value ? null : objRow[congs_TopicRole.MenuName].ToString().Trim(); //菜单名称
objgs_TopicRoleEN.MenuIsHide = clsEntityBase2.TransNullToBool_S(objRow[congs_TopicRole.MenuIsHide].ToString().Trim()); //菜单是否隐藏
objgs_TopicRoleEN.UpdDate = objRow[congs_TopicRole.UpdDate] == DBNull.Value ? null : objRow[congs_TopicRole.UpdDate].ToString().Trim(); //修改日期
objgs_TopicRoleEN.UpdUser = objRow[congs_TopicRole.UpdUser] == DBNull.Value ? null : objRow[congs_TopicRole.UpdUser].ToString().Trim(); //修改人
objgs_TopicRoleEN.Memo = objRow[congs_TopicRole.Memo] == DBNull.Value ? null : objRow[congs_TopicRole.Memo].ToString().Trim(); //备注
objgs_TopicRoleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[congs_TopicRole.IsDefault].ToString().Trim()); //是否默认
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_TopicRoleEN.TopicRoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_TopicRoleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrTopicRoleIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsgs_TopicRoleEN> GetObjLstByTopicRoleIdLstCache(List<string> arrTopicRoleIdLst)
{
string strKey = string.Format("{0}", clsgs_TopicRoleEN._CurrTabName);
List<clsgs_TopicRoleEN> arrgs_TopicRoleObjLstCache = GetObjLstCache();
IEnumerable <clsgs_TopicRoleEN> arrgs_TopicRoleObjLst_Sel =
arrgs_TopicRoleObjLstCache
.Where(x => arrTopicRoleIdLst.Contains(x.TopicRoleId));
return arrgs_TopicRoleObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_TopicRoleEN> GetObjLst(string strWhereCond)
{
List<clsgs_TopicRoleEN> arrObjLst = new List<clsgs_TopicRoleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_TopicRoleEN objgs_TopicRoleEN = new clsgs_TopicRoleEN();
try
{
objgs_TopicRoleEN.TopicRoleId = objRow[congs_TopicRole.TopicRoleId].ToString().Trim(); //主题权限Id
objgs_TopicRoleEN.TopicId = objRow[congs_TopicRole.TopicId] == DBNull.Value ? null : objRow[congs_TopicRole.TopicId].ToString().Trim(); //主题Id
objgs_TopicRoleEN.MenuNum = objRow[congs_TopicRole.MenuNum] == DBNull.Value ? null : objRow[congs_TopicRole.MenuNum].ToString().Trim(); //菜单编号
objgs_TopicRoleEN.MenuName = objRow[congs_TopicRole.MenuName] == DBNull.Value ? null : objRow[congs_TopicRole.MenuName].ToString().Trim(); //菜单名称
objgs_TopicRoleEN.MenuIsHide = clsEntityBase2.TransNullToBool_S(objRow[congs_TopicRole.MenuIsHide].ToString().Trim()); //菜单是否隐藏
objgs_TopicRoleEN.UpdDate = objRow[congs_TopicRole.UpdDate] == DBNull.Value ? null : objRow[congs_TopicRole.UpdDate].ToString().Trim(); //修改日期
objgs_TopicRoleEN.UpdUser = objRow[congs_TopicRole.UpdUser] == DBNull.Value ? null : objRow[congs_TopicRole.UpdUser].ToString().Trim(); //修改人
objgs_TopicRoleEN.Memo = objRow[congs_TopicRole.Memo] == DBNull.Value ? null : objRow[congs_TopicRole.Memo].ToString().Trim(); //备注
objgs_TopicRoleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[congs_TopicRole.IsDefault].ToString().Trim()); //是否默认
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_TopicRoleEN.TopicRoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_TopicRoleEN);
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
public static List<clsgs_TopicRoleEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsgs_TopicRoleEN> arrObjLst = new List<clsgs_TopicRoleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_TopicRoleEN objgs_TopicRoleEN = new clsgs_TopicRoleEN();
try
{
objgs_TopicRoleEN.TopicRoleId = objRow[congs_TopicRole.TopicRoleId].ToString().Trim(); //主题权限Id
objgs_TopicRoleEN.TopicId = objRow[congs_TopicRole.TopicId] == DBNull.Value ? null : objRow[congs_TopicRole.TopicId].ToString().Trim(); //主题Id
objgs_TopicRoleEN.MenuNum = objRow[congs_TopicRole.MenuNum] == DBNull.Value ? null : objRow[congs_TopicRole.MenuNum].ToString().Trim(); //菜单编号
objgs_TopicRoleEN.MenuName = objRow[congs_TopicRole.MenuName] == DBNull.Value ? null : objRow[congs_TopicRole.MenuName].ToString().Trim(); //菜单名称
objgs_TopicRoleEN.MenuIsHide = clsEntityBase2.TransNullToBool_S(objRow[congs_TopicRole.MenuIsHide].ToString().Trim()); //菜单是否隐藏
objgs_TopicRoleEN.UpdDate = objRow[congs_TopicRole.UpdDate] == DBNull.Value ? null : objRow[congs_TopicRole.UpdDate].ToString().Trim(); //修改日期
objgs_TopicRoleEN.UpdUser = objRow[congs_TopicRole.UpdUser] == DBNull.Value ? null : objRow[congs_TopicRole.UpdUser].ToString().Trim(); //修改人
objgs_TopicRoleEN.Memo = objRow[congs_TopicRole.Memo] == DBNull.Value ? null : objRow[congs_TopicRole.Memo].ToString().Trim(); //备注
objgs_TopicRoleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[congs_TopicRole.IsDefault].ToString().Trim()); //是否默认
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_TopicRoleEN.TopicRoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_TopicRoleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objgs_TopicRoleCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsgs_TopicRoleEN> GetSubObjLstCache(clsgs_TopicRoleEN objgs_TopicRoleCond)
{
List<clsgs_TopicRoleEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsgs_TopicRoleEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in congs_TopicRole.AttributeName)
{
if (objgs_TopicRoleCond.IsUpdated(strFldName) == false) continue;
if (objgs_TopicRoleCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_TopicRoleCond[strFldName].ToString());
}
else
{
if (objgs_TopicRoleCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objgs_TopicRoleCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_TopicRoleCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objgs_TopicRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objgs_TopicRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objgs_TopicRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objgs_TopicRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objgs_TopicRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objgs_TopicRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objgs_TopicRoleCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objgs_TopicRoleCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objgs_TopicRoleCond[strFldName]));
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
public static List<clsgs_TopicRoleEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsgs_TopicRoleEN> arrObjLst = new List<clsgs_TopicRoleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_TopicRoleEN objgs_TopicRoleEN = new clsgs_TopicRoleEN();
try
{
objgs_TopicRoleEN.TopicRoleId = objRow[congs_TopicRole.TopicRoleId].ToString().Trim(); //主题权限Id
objgs_TopicRoleEN.TopicId = objRow[congs_TopicRole.TopicId] == DBNull.Value ? null : objRow[congs_TopicRole.TopicId].ToString().Trim(); //主题Id
objgs_TopicRoleEN.MenuNum = objRow[congs_TopicRole.MenuNum] == DBNull.Value ? null : objRow[congs_TopicRole.MenuNum].ToString().Trim(); //菜单编号
objgs_TopicRoleEN.MenuName = objRow[congs_TopicRole.MenuName] == DBNull.Value ? null : objRow[congs_TopicRole.MenuName].ToString().Trim(); //菜单名称
objgs_TopicRoleEN.MenuIsHide = clsEntityBase2.TransNullToBool_S(objRow[congs_TopicRole.MenuIsHide].ToString().Trim()); //菜单是否隐藏
objgs_TopicRoleEN.UpdDate = objRow[congs_TopicRole.UpdDate] == DBNull.Value ? null : objRow[congs_TopicRole.UpdDate].ToString().Trim(); //修改日期
objgs_TopicRoleEN.UpdUser = objRow[congs_TopicRole.UpdUser] == DBNull.Value ? null : objRow[congs_TopicRole.UpdUser].ToString().Trim(); //修改人
objgs_TopicRoleEN.Memo = objRow[congs_TopicRole.Memo] == DBNull.Value ? null : objRow[congs_TopicRole.Memo].ToString().Trim(); //备注
objgs_TopicRoleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[congs_TopicRole.IsDefault].ToString().Trim()); //是否默认
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_TopicRoleEN.TopicRoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_TopicRoleEN);
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
public static List<clsgs_TopicRoleEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsgs_TopicRoleEN> arrObjLst = new List<clsgs_TopicRoleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_TopicRoleEN objgs_TopicRoleEN = new clsgs_TopicRoleEN();
try
{
objgs_TopicRoleEN.TopicRoleId = objRow[congs_TopicRole.TopicRoleId].ToString().Trim(); //主题权限Id
objgs_TopicRoleEN.TopicId = objRow[congs_TopicRole.TopicId] == DBNull.Value ? null : objRow[congs_TopicRole.TopicId].ToString().Trim(); //主题Id
objgs_TopicRoleEN.MenuNum = objRow[congs_TopicRole.MenuNum] == DBNull.Value ? null : objRow[congs_TopicRole.MenuNum].ToString().Trim(); //菜单编号
objgs_TopicRoleEN.MenuName = objRow[congs_TopicRole.MenuName] == DBNull.Value ? null : objRow[congs_TopicRole.MenuName].ToString().Trim(); //菜单名称
objgs_TopicRoleEN.MenuIsHide = clsEntityBase2.TransNullToBool_S(objRow[congs_TopicRole.MenuIsHide].ToString().Trim()); //菜单是否隐藏
objgs_TopicRoleEN.UpdDate = objRow[congs_TopicRole.UpdDate] == DBNull.Value ? null : objRow[congs_TopicRole.UpdDate].ToString().Trim(); //修改日期
objgs_TopicRoleEN.UpdUser = objRow[congs_TopicRole.UpdUser] == DBNull.Value ? null : objRow[congs_TopicRole.UpdUser].ToString().Trim(); //修改人
objgs_TopicRoleEN.Memo = objRow[congs_TopicRole.Memo] == DBNull.Value ? null : objRow[congs_TopicRole.Memo].ToString().Trim(); //备注
objgs_TopicRoleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[congs_TopicRole.IsDefault].ToString().Trim()); //是否默认
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_TopicRoleEN.TopicRoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_TopicRoleEN);
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
List<clsgs_TopicRoleEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsgs_TopicRoleEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_TopicRoleEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsgs_TopicRoleEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsgs_TopicRoleEN> arrObjLst = new List<clsgs_TopicRoleEN>(); 
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
	clsgs_TopicRoleEN objgs_TopicRoleEN = new clsgs_TopicRoleEN();
try
{
objgs_TopicRoleEN.TopicRoleId = objRow[congs_TopicRole.TopicRoleId].ToString().Trim(); //主题权限Id
objgs_TopicRoleEN.TopicId = objRow[congs_TopicRole.TopicId] == DBNull.Value ? null : objRow[congs_TopicRole.TopicId].ToString().Trim(); //主题Id
objgs_TopicRoleEN.MenuNum = objRow[congs_TopicRole.MenuNum] == DBNull.Value ? null : objRow[congs_TopicRole.MenuNum].ToString().Trim(); //菜单编号
objgs_TopicRoleEN.MenuName = objRow[congs_TopicRole.MenuName] == DBNull.Value ? null : objRow[congs_TopicRole.MenuName].ToString().Trim(); //菜单名称
objgs_TopicRoleEN.MenuIsHide = clsEntityBase2.TransNullToBool_S(objRow[congs_TopicRole.MenuIsHide].ToString().Trim()); //菜单是否隐藏
objgs_TopicRoleEN.UpdDate = objRow[congs_TopicRole.UpdDate] == DBNull.Value ? null : objRow[congs_TopicRole.UpdDate].ToString().Trim(); //修改日期
objgs_TopicRoleEN.UpdUser = objRow[congs_TopicRole.UpdUser] == DBNull.Value ? null : objRow[congs_TopicRole.UpdUser].ToString().Trim(); //修改人
objgs_TopicRoleEN.Memo = objRow[congs_TopicRole.Memo] == DBNull.Value ? null : objRow[congs_TopicRole.Memo].ToString().Trim(); //备注
objgs_TopicRoleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[congs_TopicRole.IsDefault].ToString().Trim()); //是否默认
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_TopicRoleEN.TopicRoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_TopicRoleEN);
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
public static List<clsgs_TopicRoleEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsgs_TopicRoleEN> arrObjLst = new List<clsgs_TopicRoleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_TopicRoleEN objgs_TopicRoleEN = new clsgs_TopicRoleEN();
try
{
objgs_TopicRoleEN.TopicRoleId = objRow[congs_TopicRole.TopicRoleId].ToString().Trim(); //主题权限Id
objgs_TopicRoleEN.TopicId = objRow[congs_TopicRole.TopicId] == DBNull.Value ? null : objRow[congs_TopicRole.TopicId].ToString().Trim(); //主题Id
objgs_TopicRoleEN.MenuNum = objRow[congs_TopicRole.MenuNum] == DBNull.Value ? null : objRow[congs_TopicRole.MenuNum].ToString().Trim(); //菜单编号
objgs_TopicRoleEN.MenuName = objRow[congs_TopicRole.MenuName] == DBNull.Value ? null : objRow[congs_TopicRole.MenuName].ToString().Trim(); //菜单名称
objgs_TopicRoleEN.MenuIsHide = clsEntityBase2.TransNullToBool_S(objRow[congs_TopicRole.MenuIsHide].ToString().Trim()); //菜单是否隐藏
objgs_TopicRoleEN.UpdDate = objRow[congs_TopicRole.UpdDate] == DBNull.Value ? null : objRow[congs_TopicRole.UpdDate].ToString().Trim(); //修改日期
objgs_TopicRoleEN.UpdUser = objRow[congs_TopicRole.UpdUser] == DBNull.Value ? null : objRow[congs_TopicRole.UpdUser].ToString().Trim(); //修改人
objgs_TopicRoleEN.Memo = objRow[congs_TopicRole.Memo] == DBNull.Value ? null : objRow[congs_TopicRole.Memo].ToString().Trim(); //备注
objgs_TopicRoleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[congs_TopicRole.IsDefault].ToString().Trim()); //是否默认
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_TopicRoleEN.TopicRoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_TopicRoleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsgs_TopicRoleEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsgs_TopicRoleEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsgs_TopicRoleEN> arrObjLst = new List<clsgs_TopicRoleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_TopicRoleEN objgs_TopicRoleEN = new clsgs_TopicRoleEN();
try
{
objgs_TopicRoleEN.TopicRoleId = objRow[congs_TopicRole.TopicRoleId].ToString().Trim(); //主题权限Id
objgs_TopicRoleEN.TopicId = objRow[congs_TopicRole.TopicId] == DBNull.Value ? null : objRow[congs_TopicRole.TopicId].ToString().Trim(); //主题Id
objgs_TopicRoleEN.MenuNum = objRow[congs_TopicRole.MenuNum] == DBNull.Value ? null : objRow[congs_TopicRole.MenuNum].ToString().Trim(); //菜单编号
objgs_TopicRoleEN.MenuName = objRow[congs_TopicRole.MenuName] == DBNull.Value ? null : objRow[congs_TopicRole.MenuName].ToString().Trim(); //菜单名称
objgs_TopicRoleEN.MenuIsHide = clsEntityBase2.TransNullToBool_S(objRow[congs_TopicRole.MenuIsHide].ToString().Trim()); //菜单是否隐藏
objgs_TopicRoleEN.UpdDate = objRow[congs_TopicRole.UpdDate] == DBNull.Value ? null : objRow[congs_TopicRole.UpdDate].ToString().Trim(); //修改日期
objgs_TopicRoleEN.UpdUser = objRow[congs_TopicRole.UpdUser] == DBNull.Value ? null : objRow[congs_TopicRole.UpdUser].ToString().Trim(); //修改人
objgs_TopicRoleEN.Memo = objRow[congs_TopicRole.Memo] == DBNull.Value ? null : objRow[congs_TopicRole.Memo].ToString().Trim(); //备注
objgs_TopicRoleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[congs_TopicRole.IsDefault].ToString().Trim()); //是否默认
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_TopicRoleEN.TopicRoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_TopicRoleEN);
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
public static List<clsgs_TopicRoleEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsgs_TopicRoleEN> arrObjLst = new List<clsgs_TopicRoleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_TopicRoleEN objgs_TopicRoleEN = new clsgs_TopicRoleEN();
try
{
objgs_TopicRoleEN.TopicRoleId = objRow[congs_TopicRole.TopicRoleId].ToString().Trim(); //主题权限Id
objgs_TopicRoleEN.TopicId = objRow[congs_TopicRole.TopicId] == DBNull.Value ? null : objRow[congs_TopicRole.TopicId].ToString().Trim(); //主题Id
objgs_TopicRoleEN.MenuNum = objRow[congs_TopicRole.MenuNum] == DBNull.Value ? null : objRow[congs_TopicRole.MenuNum].ToString().Trim(); //菜单编号
objgs_TopicRoleEN.MenuName = objRow[congs_TopicRole.MenuName] == DBNull.Value ? null : objRow[congs_TopicRole.MenuName].ToString().Trim(); //菜单名称
objgs_TopicRoleEN.MenuIsHide = clsEntityBase2.TransNullToBool_S(objRow[congs_TopicRole.MenuIsHide].ToString().Trim()); //菜单是否隐藏
objgs_TopicRoleEN.UpdDate = objRow[congs_TopicRole.UpdDate] == DBNull.Value ? null : objRow[congs_TopicRole.UpdDate].ToString().Trim(); //修改日期
objgs_TopicRoleEN.UpdUser = objRow[congs_TopicRole.UpdUser] == DBNull.Value ? null : objRow[congs_TopicRole.UpdUser].ToString().Trim(); //修改人
objgs_TopicRoleEN.Memo = objRow[congs_TopicRole.Memo] == DBNull.Value ? null : objRow[congs_TopicRole.Memo].ToString().Trim(); //备注
objgs_TopicRoleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[congs_TopicRole.IsDefault].ToString().Trim()); //是否默认
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_TopicRoleEN.TopicRoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_TopicRoleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_TopicRoleEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsgs_TopicRoleEN> arrObjLst = new List<clsgs_TopicRoleEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_TopicRoleEN objgs_TopicRoleEN = new clsgs_TopicRoleEN();
try
{
objgs_TopicRoleEN.TopicRoleId = objRow[congs_TopicRole.TopicRoleId].ToString().Trim(); //主题权限Id
objgs_TopicRoleEN.TopicId = objRow[congs_TopicRole.TopicId] == DBNull.Value ? null : objRow[congs_TopicRole.TopicId].ToString().Trim(); //主题Id
objgs_TopicRoleEN.MenuNum = objRow[congs_TopicRole.MenuNum] == DBNull.Value ? null : objRow[congs_TopicRole.MenuNum].ToString().Trim(); //菜单编号
objgs_TopicRoleEN.MenuName = objRow[congs_TopicRole.MenuName] == DBNull.Value ? null : objRow[congs_TopicRole.MenuName].ToString().Trim(); //菜单名称
objgs_TopicRoleEN.MenuIsHide = clsEntityBase2.TransNullToBool_S(objRow[congs_TopicRole.MenuIsHide].ToString().Trim()); //菜单是否隐藏
objgs_TopicRoleEN.UpdDate = objRow[congs_TopicRole.UpdDate] == DBNull.Value ? null : objRow[congs_TopicRole.UpdDate].ToString().Trim(); //修改日期
objgs_TopicRoleEN.UpdUser = objRow[congs_TopicRole.UpdUser] == DBNull.Value ? null : objRow[congs_TopicRole.UpdUser].ToString().Trim(); //修改人
objgs_TopicRoleEN.Memo = objRow[congs_TopicRole.Memo] == DBNull.Value ? null : objRow[congs_TopicRole.Memo].ToString().Trim(); //备注
objgs_TopicRoleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[congs_TopicRole.IsDefault].ToString().Trim()); //是否默认
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_TopicRoleEN.TopicRoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_TopicRoleEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objgs_TopicRoleEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getgs_TopicRole(ref clsgs_TopicRoleEN objgs_TopicRoleEN)
{
bool bolResult = gs_TopicRoleDA.Getgs_TopicRole(ref objgs_TopicRoleEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strTopicRoleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_TopicRoleEN GetObjByTopicRoleId(string strTopicRoleId)
{
if (strTopicRoleId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strTopicRoleId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strTopicRoleId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strTopicRoleId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsgs_TopicRoleEN objgs_TopicRoleEN = gs_TopicRoleDA.GetObjByTopicRoleId(strTopicRoleId);
return objgs_TopicRoleEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsgs_TopicRoleEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsgs_TopicRoleEN objgs_TopicRoleEN = gs_TopicRoleDA.GetFirstObj(strWhereCond);
 return objgs_TopicRoleEN;
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
public static clsgs_TopicRoleEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsgs_TopicRoleEN objgs_TopicRoleEN = gs_TopicRoleDA.GetObjByDataRow(objRow);
 return objgs_TopicRoleEN;
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
public static clsgs_TopicRoleEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsgs_TopicRoleEN objgs_TopicRoleEN = gs_TopicRoleDA.GetObjByDataRow(objRow);
 return objgs_TopicRoleEN;
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
 /// <param name = "strTopicRoleId">所给的关键字</param>
 /// <param name = "lstgs_TopicRoleObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_TopicRoleEN GetObjByTopicRoleIdFromList(string strTopicRoleId, List<clsgs_TopicRoleEN> lstgs_TopicRoleObjLst)
{
foreach (clsgs_TopicRoleEN objgs_TopicRoleEN in lstgs_TopicRoleObjLst)
{
if (objgs_TopicRoleEN.TopicRoleId == strTopicRoleId)
{
return objgs_TopicRoleEN;
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
 string strMaxTopicRoleId;
 try
 {
 strMaxTopicRoleId = clsgs_TopicRoleDA.GetMaxStrId();
 return strMaxTopicRoleId;
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
 string strTopicRoleId;
 try
 {
 strTopicRoleId = new clsgs_TopicRoleDA().GetFirstID(strWhereCond);
 return strTopicRoleId;
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
 arrList = gs_TopicRoleDA.GetID(strWhereCond);
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
bool bolIsExist = gs_TopicRoleDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strTopicRoleId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strTopicRoleId)
{
if (string.IsNullOrEmpty(strTopicRoleId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strTopicRoleId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = gs_TopicRoleDA.IsExist(strTopicRoleId);
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
 bolIsExist = clsgs_TopicRoleDA.IsExistTable();
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
 bolIsExist = gs_TopicRoleDA.IsExistTable(strTabName);
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
 /// <param name = "objgs_TopicRoleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsgs_TopicRoleEN objgs_TopicRoleEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objgs_TopicRoleEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!主题权限Id = [{0}]的数据已经存在!(in clsgs_TopicRoleBL.AddNewRecordBySql2)", objgs_TopicRoleEN.TopicRoleId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_TopicRoleEN.TopicRoleId) == true || clsgs_TopicRoleBL.IsExist(objgs_TopicRoleEN.TopicRoleId) == true)
 {
     objgs_TopicRoleEN.TopicRoleId = clsgs_TopicRoleBL.GetMaxStrId_S();
 }
bool bolResult = gs_TopicRoleDA.AddNewRecordBySQL2(objgs_TopicRoleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TopicRoleBL.ReFreshCache();

if (clsgs_TopicRoleBL.relatedActions != null)
{
clsgs_TopicRoleBL.relatedActions.UpdRelaTabDate(objgs_TopicRoleEN.TopicRoleId, "SetUpdDate");
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
 /// <param name = "objgs_TopicRoleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsgs_TopicRoleEN objgs_TopicRoleEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objgs_TopicRoleEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!主题权限Id = [{0}]的数据已经存在!(in clsgs_TopicRoleBL.AddNewRecordBySql2WithReturnKey)", objgs_TopicRoleEN.TopicRoleId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_TopicRoleEN.TopicRoleId) == true || clsgs_TopicRoleBL.IsExist(objgs_TopicRoleEN.TopicRoleId) == true)
 {
     objgs_TopicRoleEN.TopicRoleId = clsgs_TopicRoleBL.GetMaxStrId_S();
 }
string strKey = gs_TopicRoleDA.AddNewRecordBySQL2WithReturnKey(objgs_TopicRoleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TopicRoleBL.ReFreshCache();

if (clsgs_TopicRoleBL.relatedActions != null)
{
clsgs_TopicRoleBL.relatedActions.UpdRelaTabDate(objgs_TopicRoleEN.TopicRoleId, "SetUpdDate");
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
 /// <param name = "objgs_TopicRoleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsgs_TopicRoleEN objgs_TopicRoleEN)
{
try
{
bool bolResult = gs_TopicRoleDA.Update(objgs_TopicRoleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TopicRoleBL.ReFreshCache();

if (clsgs_TopicRoleBL.relatedActions != null)
{
clsgs_TopicRoleBL.relatedActions.UpdRelaTabDate(objgs_TopicRoleEN.TopicRoleId, "SetUpdDate");
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
 /// <param name = "objgs_TopicRoleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsgs_TopicRoleEN objgs_TopicRoleEN)
{
 if (string.IsNullOrEmpty(objgs_TopicRoleEN.TopicRoleId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = gs_TopicRoleDA.UpdateBySql2(objgs_TopicRoleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TopicRoleBL.ReFreshCache();

if (clsgs_TopicRoleBL.relatedActions != null)
{
clsgs_TopicRoleBL.relatedActions.UpdRelaTabDate(objgs_TopicRoleEN.TopicRoleId, "SetUpdDate");
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
 /// <param name = "strTopicRoleId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strTopicRoleId)
{
try
{
 clsgs_TopicRoleEN objgs_TopicRoleEN = clsgs_TopicRoleBL.GetObjByTopicRoleId(strTopicRoleId);

if (clsgs_TopicRoleBL.relatedActions != null)
{
clsgs_TopicRoleBL.relatedActions.UpdRelaTabDate(objgs_TopicRoleEN.TopicRoleId, "SetUpdDate");
}
if (objgs_TopicRoleEN != null)
{
int intRecNum = gs_TopicRoleDA.DelRecord(strTopicRoleId);
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
/// <param name="strTopicRoleId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strTopicRoleId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsgs_TopicRoleDA.GetSpecSQLObj();
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
//删除与表:[gs_TopicRole]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//congs_TopicRole.TopicRoleId,
//strTopicRoleId);
//        clsgs_TopicRoleBL.Delgs_TopicRolesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsgs_TopicRoleBL.DelRecord(strTopicRoleId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsgs_TopicRoleBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strTopicRoleId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strTopicRoleId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strTopicRoleId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsgs_TopicRoleBL.relatedActions != null)
{
clsgs_TopicRoleBL.relatedActions.UpdRelaTabDate(strTopicRoleId, "UpdRelaTabDate");
}
bool bolResult = gs_TopicRoleDA.DelRecord(strTopicRoleId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrTopicRoleIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delgs_TopicRoles(List<string> arrTopicRoleIdLst)
{
if (arrTopicRoleIdLst.Count == 0) return 0;
try
{
if (clsgs_TopicRoleBL.relatedActions != null)
{
foreach (var strTopicRoleId in arrTopicRoleIdLst)
{
clsgs_TopicRoleBL.relatedActions.UpdRelaTabDate(strTopicRoleId, "UpdRelaTabDate");
}
}
int intDelRecNum = gs_TopicRoleDA.Delgs_TopicRole(arrTopicRoleIdLst);
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
public static int Delgs_TopicRolesByCond(string strWhereCond)
{
try
{
if (clsgs_TopicRoleBL.relatedActions != null)
{
List<string> arrTopicRoleId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strTopicRoleId in arrTopicRoleId)
{
clsgs_TopicRoleBL.relatedActions.UpdRelaTabDate(strTopicRoleId, "UpdRelaTabDate");
}
}
int intRecNum = gs_TopicRoleDA.Delgs_TopicRole(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[gs_TopicRole]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strTopicRoleId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strTopicRoleId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsgs_TopicRoleDA.GetSpecSQLObj();
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
//删除与表:[gs_TopicRole]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsgs_TopicRoleBL.DelRecord(strTopicRoleId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsgs_TopicRoleBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strTopicRoleId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objgs_TopicRoleENS">源对象</param>
 /// <param name = "objgs_TopicRoleENT">目标对象</param>
 public static void CopyTo(clsgs_TopicRoleEN objgs_TopicRoleENS, clsgs_TopicRoleEN objgs_TopicRoleENT)
{
try
{
objgs_TopicRoleENT.TopicRoleId = objgs_TopicRoleENS.TopicRoleId; //主题权限Id
objgs_TopicRoleENT.TopicId = objgs_TopicRoleENS.TopicId; //主题Id
objgs_TopicRoleENT.MenuNum = objgs_TopicRoleENS.MenuNum; //菜单编号
objgs_TopicRoleENT.MenuName = objgs_TopicRoleENS.MenuName; //菜单名称
objgs_TopicRoleENT.MenuIsHide = objgs_TopicRoleENS.MenuIsHide; //菜单是否隐藏
objgs_TopicRoleENT.UpdDate = objgs_TopicRoleENS.UpdDate; //修改日期
objgs_TopicRoleENT.UpdUser = objgs_TopicRoleENS.UpdUser; //修改人
objgs_TopicRoleENT.Memo = objgs_TopicRoleENS.Memo; //备注
objgs_TopicRoleENT.IsDefault = objgs_TopicRoleENS.IsDefault; //是否默认
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
 /// <param name = "objgs_TopicRoleEN">源简化对象</param>
 public static void SetUpdFlag(clsgs_TopicRoleEN objgs_TopicRoleEN)
{
try
{
objgs_TopicRoleEN.ClearUpdateState();
   string strsfUpdFldSetStr = objgs_TopicRoleEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(congs_TopicRole.TopicRoleId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TopicRoleEN.TopicRoleId = objgs_TopicRoleEN.TopicRoleId; //主题权限Id
}
if (arrFldSet.Contains(congs_TopicRole.TopicId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TopicRoleEN.TopicId = objgs_TopicRoleEN.TopicId == "[null]" ? null :  objgs_TopicRoleEN.TopicId; //主题Id
}
if (arrFldSet.Contains(congs_TopicRole.MenuNum, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TopicRoleEN.MenuNum = objgs_TopicRoleEN.MenuNum == "[null]" ? null :  objgs_TopicRoleEN.MenuNum; //菜单编号
}
if (arrFldSet.Contains(congs_TopicRole.MenuName, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TopicRoleEN.MenuName = objgs_TopicRoleEN.MenuName == "[null]" ? null :  objgs_TopicRoleEN.MenuName; //菜单名称
}
if (arrFldSet.Contains(congs_TopicRole.MenuIsHide, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TopicRoleEN.MenuIsHide = objgs_TopicRoleEN.MenuIsHide; //菜单是否隐藏
}
if (arrFldSet.Contains(congs_TopicRole.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TopicRoleEN.UpdDate = objgs_TopicRoleEN.UpdDate == "[null]" ? null :  objgs_TopicRoleEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(congs_TopicRole.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TopicRoleEN.UpdUser = objgs_TopicRoleEN.UpdUser == "[null]" ? null :  objgs_TopicRoleEN.UpdUser; //修改人
}
if (arrFldSet.Contains(congs_TopicRole.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TopicRoleEN.Memo = objgs_TopicRoleEN.Memo == "[null]" ? null :  objgs_TopicRoleEN.Memo; //备注
}
if (arrFldSet.Contains(congs_TopicRole.IsDefault, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TopicRoleEN.IsDefault = objgs_TopicRoleEN.IsDefault; //是否默认
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
 /// <param name = "objgs_TopicRoleEN">源简化对象</param>
 public static void AccessFldValueNull(clsgs_TopicRoleEN objgs_TopicRoleEN)
{
try
{
if (objgs_TopicRoleEN.TopicId == "[null]") objgs_TopicRoleEN.TopicId = null; //主题Id
if (objgs_TopicRoleEN.MenuNum == "[null]") objgs_TopicRoleEN.MenuNum = null; //菜单编号
if (objgs_TopicRoleEN.MenuName == "[null]") objgs_TopicRoleEN.MenuName = null; //菜单名称
if (objgs_TopicRoleEN.UpdDate == "[null]") objgs_TopicRoleEN.UpdDate = null; //修改日期
if (objgs_TopicRoleEN.UpdUser == "[null]") objgs_TopicRoleEN.UpdUser = null; //修改人
if (objgs_TopicRoleEN.Memo == "[null]") objgs_TopicRoleEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsgs_TopicRoleEN objgs_TopicRoleEN)
{
 gs_TopicRoleDA.CheckPropertyNew(objgs_TopicRoleEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsgs_TopicRoleEN objgs_TopicRoleEN)
{
 gs_TopicRoleDA.CheckProperty4Condition(objgs_TopicRoleEN);
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
if (clsgs_TopicRoleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_TopicRoleBL没有刷新缓存机制(clsgs_TopicRoleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by TopicRoleId");
//if (arrgs_TopicRoleObjLstCache == null)
//{
//arrgs_TopicRoleObjLstCache = gs_TopicRoleDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strTopicRoleId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_TopicRoleEN GetObjByTopicRoleIdCache(string strTopicRoleId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsgs_TopicRoleEN._CurrTabName);
List<clsgs_TopicRoleEN> arrgs_TopicRoleObjLstCache = GetObjLstCache();
IEnumerable <clsgs_TopicRoleEN> arrgs_TopicRoleObjLst_Sel =
arrgs_TopicRoleObjLstCache
.Where(x=> x.TopicRoleId == strTopicRoleId 
);
if (arrgs_TopicRoleObjLst_Sel.Count() == 0)
{
   clsgs_TopicRoleEN obj = clsgs_TopicRoleBL.GetObjByTopicRoleId(strTopicRoleId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrgs_TopicRoleObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_TopicRoleEN> GetAllgs_TopicRoleObjLstCache()
{
//获取缓存中的对象列表
List<clsgs_TopicRoleEN> arrgs_TopicRoleObjLstCache = GetObjLstCache(); 
return arrgs_TopicRoleObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_TopicRoleEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsgs_TopicRoleEN._CurrTabName);
List<clsgs_TopicRoleEN> arrgs_TopicRoleObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrgs_TopicRoleObjLstCache;
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
string strKey = string.Format("{0}", clsgs_TopicRoleEN._CurrTabName);
CacheHelper.Remove(strKey);
clsgs_TopicRoleEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsgs_TopicRoleEN._RefreshTimeLst.Count == 0) return "";
return clsgs_TopicRoleEN._RefreshTimeLst[clsgs_TopicRoleEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsgs_TopicRoleBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsgs_TopicRoleEN._CurrTabName);
CacheHelper.Remove(strKey);
clsgs_TopicRoleEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsgs_TopicRoleBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--gs_TopicRole(主题权限表)
 /// 唯一性条件:TopicRoleId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objgs_TopicRoleEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsgs_TopicRoleEN objgs_TopicRoleEN)
{
//检测记录是否存在
string strResult = gs_TopicRoleDA.GetUniCondStr(objgs_TopicRoleEN);
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
public static string Func(string strInFldName, string strOutFldName, string strTopicRoleId)
{
if (strInFldName != congs_TopicRole.TopicRoleId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (congs_TopicRole.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", congs_TopicRole.AttributeName));
throw new Exception(strMsg);
}
var objgs_TopicRole = clsgs_TopicRoleBL.GetObjByTopicRoleIdCache(strTopicRoleId);
if (objgs_TopicRole == null) return "";
return objgs_TopicRole[strOutFldName].ToString();
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
int intRecCount = clsgs_TopicRoleDA.GetRecCount(strTabName);
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
int intRecCount = clsgs_TopicRoleDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsgs_TopicRoleDA.GetRecCount();
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
int intRecCount = clsgs_TopicRoleDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objgs_TopicRoleCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsgs_TopicRoleEN objgs_TopicRoleCond)
{
List<clsgs_TopicRoleEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsgs_TopicRoleEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in congs_TopicRole.AttributeName)
{
if (objgs_TopicRoleCond.IsUpdated(strFldName) == false) continue;
if (objgs_TopicRoleCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_TopicRoleCond[strFldName].ToString());
}
else
{
if (objgs_TopicRoleCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objgs_TopicRoleCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_TopicRoleCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objgs_TopicRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objgs_TopicRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objgs_TopicRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objgs_TopicRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objgs_TopicRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objgs_TopicRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objgs_TopicRoleCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objgs_TopicRoleCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objgs_TopicRoleCond[strFldName]));
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
 List<string> arrList = clsgs_TopicRoleDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = gs_TopicRoleDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = gs_TopicRoleDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = gs_TopicRoleDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsgs_TopicRoleDA.SetFldValue(clsgs_TopicRoleEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = gs_TopicRoleDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsgs_TopicRoleDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsgs_TopicRoleDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsgs_TopicRoleDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[gs_TopicRole] "); 
 strCreateTabCode.Append(" ( "); 
 // /**主题权限Id*/ 
 strCreateTabCode.Append(" TopicRoleId char(10) primary key, "); 
 // /**主题Id*/ 
 strCreateTabCode.Append(" TopicId char(8) Null, "); 
 // /**菜单编号*/ 
 strCreateTabCode.Append(" MenuNum varchar(10) Null, "); 
 // /**菜单名称*/ 
 strCreateTabCode.Append(" MenuName varchar(100) Null, "); 
 // /**菜单是否隐藏*/ 
 strCreateTabCode.Append(" MenuIsHide bit Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**是否默认*/ 
 strCreateTabCode.Append(" IsDefault bit Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 主题权限表(gs_TopicRole)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4gs_TopicRole : clsCommFun4BL
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
clsgs_TopicRoleBL.ReFreshThisCache();
}
}

}