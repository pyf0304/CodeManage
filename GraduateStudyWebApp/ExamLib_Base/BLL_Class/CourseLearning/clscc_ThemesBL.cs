
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_ThemesBL
 表名:cc_Themes(01120069)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:10:02
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习(CourseLearning)
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
public static class  clscc_ThemesBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strThemeId">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_ThemesEN GetObj(this K_ThemeId_cc_Themes myKey)
{
clscc_ThemesEN objcc_ThemesEN = clscc_ThemesBL.cc_ThemesDA.GetObjByThemeId(myKey.Value);
return objcc_ThemesEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcc_ThemesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscc_ThemesEN objcc_ThemesEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objcc_ThemesEN.ThemeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clscc_ThemesBL.IsExist(objcc_ThemesEN.ThemeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objcc_ThemesEN.ThemeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clscc_ThemesBL.cc_ThemesDA.AddNewRecordBySQL2(objcc_ThemesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ThemesBL.ReFreshCache();

if (clscc_ThemesBL.relatedActions != null)
{
clscc_ThemesBL.relatedActions.UpdRelaTabDate(objcc_ThemesEN.ThemeId, objcc_ThemesEN.UpdUserId);
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
public static bool AddRecordEx(this clscc_ThemesEN objcc_ThemesEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clscc_ThemesBL.IsExist(objcc_ThemesEN.ThemeId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objcc_ThemesEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objcc_ThemesEN.AddNewRecord();
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
 /// <param name = "objcc_ThemesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clscc_ThemesEN objcc_ThemesEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objcc_ThemesEN.ThemeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clscc_ThemesBL.IsExist(objcc_ThemesEN.ThemeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objcc_ThemesEN.ThemeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clscc_ThemesBL.cc_ThemesDA.AddNewRecordBySQL2WithReturnKey(objcc_ThemesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ThemesBL.ReFreshCache();

if (clscc_ThemesBL.relatedActions != null)
{
clscc_ThemesBL.relatedActions.UpdRelaTabDate(objcc_ThemesEN.ThemeId, objcc_ThemesEN.UpdUserId);
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
 /// <param name = "objcc_ThemesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ThemesEN SetThemeId(this clscc_ThemesEN objcc_ThemesEN, string strThemeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strThemeId, 4, concc_Themes.ThemeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strThemeId, 4, concc_Themes.ThemeId);
}
objcc_ThemesEN.ThemeId = strThemeId; //主题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ThemesEN.dicFldComparisonOp.ContainsKey(concc_Themes.ThemeId) == false)
{
objcc_ThemesEN.dicFldComparisonOp.Add(concc_Themes.ThemeId, strComparisonOp);
}
else
{
objcc_ThemesEN.dicFldComparisonOp[concc_Themes.ThemeId] = strComparisonOp;
}
}
return objcc_ThemesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ThemesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ThemesEN SetThemeName(this clscc_ThemesEN objcc_ThemesEN, string strThemeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strThemeName, concc_Themes.ThemeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strThemeName, 200, concc_Themes.ThemeName);
}
objcc_ThemesEN.ThemeName = strThemeName; //主题名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ThemesEN.dicFldComparisonOp.ContainsKey(concc_Themes.ThemeName) == false)
{
objcc_ThemesEN.dicFldComparisonOp.Add(concc_Themes.ThemeName, strComparisonOp);
}
else
{
objcc_ThemesEN.dicFldComparisonOp[concc_Themes.ThemeName] = strComparisonOp;
}
}
return objcc_ThemesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ThemesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ThemesEN SetThemeDesc(this clscc_ThemesEN objcc_ThemesEN, string strThemeDesc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strThemeDesc, 500, concc_Themes.ThemeDesc);
}
objcc_ThemesEN.ThemeDesc = strThemeDesc; //主题描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ThemesEN.dicFldComparisonOp.ContainsKey(concc_Themes.ThemeDesc) == false)
{
objcc_ThemesEN.dicFldComparisonOp.Add(concc_Themes.ThemeDesc, strComparisonOp);
}
else
{
objcc_ThemesEN.dicFldComparisonOp[concc_Themes.ThemeDesc] = strComparisonOp;
}
}
return objcc_ThemesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ThemesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ThemesEN SetPageName(this clscc_ThemesEN objcc_ThemesEN, string strPageName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPageName, 100, concc_Themes.PageName);
}
objcc_ThemesEN.PageName = strPageName; //页面名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ThemesEN.dicFldComparisonOp.ContainsKey(concc_Themes.PageName) == false)
{
objcc_ThemesEN.dicFldComparisonOp.Add(concc_Themes.PageName, strComparisonOp);
}
else
{
objcc_ThemesEN.dicFldComparisonOp[concc_Themes.PageName] = strComparisonOp;
}
}
return objcc_ThemesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ThemesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ThemesEN SetExampleImgPath(this clscc_ThemesEN objcc_ThemesEN, string strExampleImgPath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExampleImgPath, 300, concc_Themes.ExampleImgPath);
}
objcc_ThemesEN.ExampleImgPath = strExampleImgPath; //示例图路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ThemesEN.dicFldComparisonOp.ContainsKey(concc_Themes.ExampleImgPath) == false)
{
objcc_ThemesEN.dicFldComparisonOp.Add(concc_Themes.ExampleImgPath, strComparisonOp);
}
else
{
objcc_ThemesEN.dicFldComparisonOp[concc_Themes.ExampleImgPath] = strComparisonOp;
}
}
return objcc_ThemesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ThemesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ThemesEN SetOrderNum(this clscc_ThemesEN objcc_ThemesEN, int? intOrderNum, string strComparisonOp="")
	{
objcc_ThemesEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ThemesEN.dicFldComparisonOp.ContainsKey(concc_Themes.OrderNum) == false)
{
objcc_ThemesEN.dicFldComparisonOp.Add(concc_Themes.OrderNum, strComparisonOp);
}
else
{
objcc_ThemesEN.dicFldComparisonOp[concc_Themes.OrderNum] = strComparisonOp;
}
}
return objcc_ThemesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ThemesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ThemesEN SetIsUse(this clscc_ThemesEN objcc_ThemesEN, bool bolIsUse, string strComparisonOp="")
	{
objcc_ThemesEN.IsUse = bolIsUse; //是否使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ThemesEN.dicFldComparisonOp.ContainsKey(concc_Themes.IsUse) == false)
{
objcc_ThemesEN.dicFldComparisonOp.Add(concc_Themes.IsUse, strComparisonOp);
}
else
{
objcc_ThemesEN.dicFldComparisonOp[concc_Themes.IsUse] = strComparisonOp;
}
}
return objcc_ThemesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ThemesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ThemesEN SetUpdDate(this clscc_ThemesEN objcc_ThemesEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, concc_Themes.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, concc_Themes.UpdDate);
}
objcc_ThemesEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ThemesEN.dicFldComparisonOp.ContainsKey(concc_Themes.UpdDate) == false)
{
objcc_ThemesEN.dicFldComparisonOp.Add(concc_Themes.UpdDate, strComparisonOp);
}
else
{
objcc_ThemesEN.dicFldComparisonOp[concc_Themes.UpdDate] = strComparisonOp;
}
}
return objcc_ThemesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ThemesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ThemesEN SetUpdUserId(this clscc_ThemesEN objcc_ThemesEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, concc_Themes.UpdUserId);
}
objcc_ThemesEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ThemesEN.dicFldComparisonOp.ContainsKey(concc_Themes.UpdUserId) == false)
{
objcc_ThemesEN.dicFldComparisonOp.Add(concc_Themes.UpdUserId, strComparisonOp);
}
else
{
objcc_ThemesEN.dicFldComparisonOp[concc_Themes.UpdUserId] = strComparisonOp;
}
}
return objcc_ThemesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ThemesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ThemesEN SetMemo(this clscc_ThemesEN objcc_ThemesEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, concc_Themes.Memo);
}
objcc_ThemesEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ThemesEN.dicFldComparisonOp.ContainsKey(concc_Themes.Memo) == false)
{
objcc_ThemesEN.dicFldComparisonOp.Add(concc_Themes.Memo, strComparisonOp);
}
else
{
objcc_ThemesEN.dicFldComparisonOp[concc_Themes.Memo] = strComparisonOp;
}
}
return objcc_ThemesEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objcc_ThemesEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clscc_ThemesEN objcc_ThemesEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objcc_ThemesEN.CheckPropertyNew();
clscc_ThemesEN objcc_ThemesCond = new clscc_ThemesEN();
string strCondition = objcc_ThemesCond
.SetThemeId(objcc_ThemesEN.ThemeId, "=")
.GetCombineCondition();
objcc_ThemesEN._IsCheckProperty = true;
bool bolIsExist = clscc_ThemesBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objcc_ThemesEN.Update();
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
 /// <param name = "objcc_ThemesEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_ThemesEN objcc_ThemesEN)
{
 if (string.IsNullOrEmpty(objcc_ThemesEN.ThemeId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscc_ThemesBL.cc_ThemesDA.UpdateBySql2(objcc_ThemesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ThemesBL.ReFreshCache();

if (clscc_ThemesBL.relatedActions != null)
{
clscc_ThemesBL.relatedActions.UpdRelaTabDate(objcc_ThemesEN.ThemeId, objcc_ThemesEN.UpdUserId);
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
 /// <param name = "objcc_ThemesEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_ThemesEN objcc_ThemesEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objcc_ThemesEN.ThemeId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscc_ThemesBL.cc_ThemesDA.UpdateBySql2(objcc_ThemesEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ThemesBL.ReFreshCache();

if (clscc_ThemesBL.relatedActions != null)
{
clscc_ThemesBL.relatedActions.UpdRelaTabDate(objcc_ThemesEN.ThemeId, objcc_ThemesEN.UpdUserId);
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
 /// <param name = "objcc_ThemesEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_ThemesEN objcc_ThemesEN, string strWhereCond)
{
try
{
bool bolResult = clscc_ThemesBL.cc_ThemesDA.UpdateBySqlWithCondition(objcc_ThemesEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ThemesBL.ReFreshCache();

if (clscc_ThemesBL.relatedActions != null)
{
clscc_ThemesBL.relatedActions.UpdRelaTabDate(objcc_ThemesEN.ThemeId, objcc_ThemesEN.UpdUserId);
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
 /// <param name = "objcc_ThemesEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_ThemesEN objcc_ThemesEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clscc_ThemesBL.cc_ThemesDA.UpdateBySqlWithConditionTransaction(objcc_ThemesEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ThemesBL.ReFreshCache();

if (clscc_ThemesBL.relatedActions != null)
{
clscc_ThemesBL.relatedActions.UpdRelaTabDate(objcc_ThemesEN.ThemeId, objcc_ThemesEN.UpdUserId);
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
 /// <param name = "strThemeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clscc_ThemesEN objcc_ThemesEN)
{
try
{
int intRecNum = clscc_ThemesBL.cc_ThemesDA.DelRecord(objcc_ThemesEN.ThemeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ThemesBL.ReFreshCache();

if (clscc_ThemesBL.relatedActions != null)
{
clscc_ThemesBL.relatedActions.UpdRelaTabDate(objcc_ThemesEN.ThemeId, objcc_ThemesEN.UpdUserId);
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
 /// <param name = "objcc_ThemesENS">源对象</param>
 /// <param name = "objcc_ThemesENT">目标对象</param>
 public static void CopyTo(this clscc_ThemesEN objcc_ThemesENS, clscc_ThemesEN objcc_ThemesENT)
{
try
{
objcc_ThemesENT.ThemeId = objcc_ThemesENS.ThemeId; //主题Id
objcc_ThemesENT.ThemeName = objcc_ThemesENS.ThemeName; //主题名
objcc_ThemesENT.ThemeDesc = objcc_ThemesENS.ThemeDesc; //主题描述
objcc_ThemesENT.PageName = objcc_ThemesENS.PageName; //页面名称
objcc_ThemesENT.ExampleImgPath = objcc_ThemesENS.ExampleImgPath; //示例图路径
objcc_ThemesENT.OrderNum = objcc_ThemesENS.OrderNum; //序号
objcc_ThemesENT.IsUse = objcc_ThemesENS.IsUse; //是否使用
objcc_ThemesENT.UpdDate = objcc_ThemesENS.UpdDate; //修改日期
objcc_ThemesENT.UpdUserId = objcc_ThemesENS.UpdUserId; //修改用户Id
objcc_ThemesENT.Memo = objcc_ThemesENS.Memo; //备注
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
 /// <param name = "objcc_ThemesENS">源对象</param>
 /// <returns>目标对象=>clscc_ThemesEN:objcc_ThemesENT</returns>
 public static clscc_ThemesEN CopyTo(this clscc_ThemesEN objcc_ThemesENS)
{
try
{
 clscc_ThemesEN objcc_ThemesENT = new clscc_ThemesEN()
{
ThemeId = objcc_ThemesENS.ThemeId, //主题Id
ThemeName = objcc_ThemesENS.ThemeName, //主题名
ThemeDesc = objcc_ThemesENS.ThemeDesc, //主题描述
PageName = objcc_ThemesENS.PageName, //页面名称
ExampleImgPath = objcc_ThemesENS.ExampleImgPath, //示例图路径
OrderNum = objcc_ThemesENS.OrderNum, //序号
IsUse = objcc_ThemesENS.IsUse, //是否使用
UpdDate = objcc_ThemesENS.UpdDate, //修改日期
UpdUserId = objcc_ThemesENS.UpdUserId, //修改用户Id
Memo = objcc_ThemesENS.Memo, //备注
};
 return objcc_ThemesENT;
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
public static void CheckPropertyNew(this clscc_ThemesEN objcc_ThemesEN)
{
 clscc_ThemesBL.cc_ThemesDA.CheckPropertyNew(objcc_ThemesEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clscc_ThemesEN objcc_ThemesEN)
{
 clscc_ThemesBL.cc_ThemesDA.CheckProperty4Condition(objcc_ThemesEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscc_ThemesEN objcc_ThemesCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcc_ThemesCond.IsUpdated(concc_Themes.ThemeId) == true)
{
string strComparisonOpThemeId = objcc_ThemesCond.dicFldComparisonOp[concc_Themes.ThemeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Themes.ThemeId, objcc_ThemesCond.ThemeId, strComparisonOpThemeId);
}
if (objcc_ThemesCond.IsUpdated(concc_Themes.ThemeName) == true)
{
string strComparisonOpThemeName = objcc_ThemesCond.dicFldComparisonOp[concc_Themes.ThemeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Themes.ThemeName, objcc_ThemesCond.ThemeName, strComparisonOpThemeName);
}
if (objcc_ThemesCond.IsUpdated(concc_Themes.ThemeDesc) == true)
{
string strComparisonOpThemeDesc = objcc_ThemesCond.dicFldComparisonOp[concc_Themes.ThemeDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Themes.ThemeDesc, objcc_ThemesCond.ThemeDesc, strComparisonOpThemeDesc);
}
if (objcc_ThemesCond.IsUpdated(concc_Themes.PageName) == true)
{
string strComparisonOpPageName = objcc_ThemesCond.dicFldComparisonOp[concc_Themes.PageName];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Themes.PageName, objcc_ThemesCond.PageName, strComparisonOpPageName);
}
if (objcc_ThemesCond.IsUpdated(concc_Themes.ExampleImgPath) == true)
{
string strComparisonOpExampleImgPath = objcc_ThemesCond.dicFldComparisonOp[concc_Themes.ExampleImgPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Themes.ExampleImgPath, objcc_ThemesCond.ExampleImgPath, strComparisonOpExampleImgPath);
}
if (objcc_ThemesCond.IsUpdated(concc_Themes.OrderNum) == true)
{
string strComparisonOpOrderNum = objcc_ThemesCond.dicFldComparisonOp[concc_Themes.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", concc_Themes.OrderNum, objcc_ThemesCond.OrderNum, strComparisonOpOrderNum);
}
if (objcc_ThemesCond.IsUpdated(concc_Themes.IsUse) == true)
{
if (objcc_ThemesCond.IsUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_Themes.IsUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_Themes.IsUse);
}
}
if (objcc_ThemesCond.IsUpdated(concc_Themes.UpdDate) == true)
{
string strComparisonOpUpdDate = objcc_ThemesCond.dicFldComparisonOp[concc_Themes.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Themes.UpdDate, objcc_ThemesCond.UpdDate, strComparisonOpUpdDate);
}
if (objcc_ThemesCond.IsUpdated(concc_Themes.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objcc_ThemesCond.dicFldComparisonOp[concc_Themes.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Themes.UpdUserId, objcc_ThemesCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objcc_ThemesCond.IsUpdated(concc_Themes.Memo) == true)
{
string strComparisonOpMemo = objcc_ThemesCond.dicFldComparisonOp[concc_Themes.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Themes.Memo, objcc_ThemesCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_cc_Themes
{
public virtual bool UpdRelaTabDate(string strThemeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 课程主题(cc_Themes)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clscc_ThemesBL
{
public static RelatedActions_cc_Themes relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clscc_ThemesDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clscc_ThemesDA cc_ThemesDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clscc_ThemesDA();
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
 public clscc_ThemesBL()
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
if (string.IsNullOrEmpty(clscc_ThemesEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscc_ThemesEN._ConnectString);
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
public static DataTable GetDataTable_cc_Themes(string strWhereCond)
{
DataTable objDT;
try
{
objDT = cc_ThemesDA.GetDataTable_cc_Themes(strWhereCond);
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
objDT = cc_ThemesDA.GetDataTable(strWhereCond);
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
objDT = cc_ThemesDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = cc_ThemesDA.GetDataTable(strWhereCond, strTabName);
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
objDT = cc_ThemesDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = cc_ThemesDA.GetDataTable_Top(objTopPara);
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
objDT = cc_ThemesDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = cc_ThemesDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = cc_ThemesDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrThemeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clscc_ThemesEN> GetObjLstByThemeIdLst(List<string> arrThemeIdLst)
{
List<clscc_ThemesEN> arrObjLst = new List<clscc_ThemesEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrThemeIdLst, true);
 string strWhereCond = string.Format("ThemeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_ThemesEN objcc_ThemesEN = new clscc_ThemesEN();
try
{
objcc_ThemesEN.ThemeId = objRow[concc_Themes.ThemeId].ToString().Trim(); //主题Id
objcc_ThemesEN.ThemeName = objRow[concc_Themes.ThemeName].ToString().Trim(); //主题名
objcc_ThemesEN.ThemeDesc = objRow[concc_Themes.ThemeDesc] == DBNull.Value ? null : objRow[concc_Themes.ThemeDesc].ToString().Trim(); //主题描述
objcc_ThemesEN.PageName = objRow[concc_Themes.PageName] == DBNull.Value ? null : objRow[concc_Themes.PageName].ToString().Trim(); //页面名称
objcc_ThemesEN.ExampleImgPath = objRow[concc_Themes.ExampleImgPath] == DBNull.Value ? null : objRow[concc_Themes.ExampleImgPath].ToString().Trim(); //示例图路径
objcc_ThemesEN.OrderNum = objRow[concc_Themes.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Themes.OrderNum].ToString().Trim()); //序号
objcc_ThemesEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[concc_Themes.IsUse].ToString().Trim()); //是否使用
objcc_ThemesEN.UpdDate = objRow[concc_Themes.UpdDate].ToString().Trim(); //修改日期
objcc_ThemesEN.UpdUserId = objRow[concc_Themes.UpdUserId] == DBNull.Value ? null : objRow[concc_Themes.UpdUserId].ToString().Trim(); //修改用户Id
objcc_ThemesEN.Memo = objRow[concc_Themes.Memo] == DBNull.Value ? null : objRow[concc_Themes.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_ThemesEN.ThemeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_ThemesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrThemeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clscc_ThemesEN> GetObjLstByThemeIdLstCache(List<string> arrThemeIdLst)
{
string strKey = string.Format("{0}", clscc_ThemesEN._CurrTabName);
List<clscc_ThemesEN> arrcc_ThemesObjLstCache = GetObjLstCache();
IEnumerable <clscc_ThemesEN> arrcc_ThemesObjLst_Sel =
arrcc_ThemesObjLstCache
.Where(x => arrThemeIdLst.Contains(x.ThemeId));
return arrcc_ThemesObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_ThemesEN> GetObjLst(string strWhereCond)
{
List<clscc_ThemesEN> arrObjLst = new List<clscc_ThemesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_ThemesEN objcc_ThemesEN = new clscc_ThemesEN();
try
{
objcc_ThemesEN.ThemeId = objRow[concc_Themes.ThemeId].ToString().Trim(); //主题Id
objcc_ThemesEN.ThemeName = objRow[concc_Themes.ThemeName].ToString().Trim(); //主题名
objcc_ThemesEN.ThemeDesc = objRow[concc_Themes.ThemeDesc] == DBNull.Value ? null : objRow[concc_Themes.ThemeDesc].ToString().Trim(); //主题描述
objcc_ThemesEN.PageName = objRow[concc_Themes.PageName] == DBNull.Value ? null : objRow[concc_Themes.PageName].ToString().Trim(); //页面名称
objcc_ThemesEN.ExampleImgPath = objRow[concc_Themes.ExampleImgPath] == DBNull.Value ? null : objRow[concc_Themes.ExampleImgPath].ToString().Trim(); //示例图路径
objcc_ThemesEN.OrderNum = objRow[concc_Themes.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Themes.OrderNum].ToString().Trim()); //序号
objcc_ThemesEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[concc_Themes.IsUse].ToString().Trim()); //是否使用
objcc_ThemesEN.UpdDate = objRow[concc_Themes.UpdDate].ToString().Trim(); //修改日期
objcc_ThemesEN.UpdUserId = objRow[concc_Themes.UpdUserId] == DBNull.Value ? null : objRow[concc_Themes.UpdUserId].ToString().Trim(); //修改用户Id
objcc_ThemesEN.Memo = objRow[concc_Themes.Memo] == DBNull.Value ? null : objRow[concc_Themes.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_ThemesEN.ThemeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_ThemesEN);
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
public static List<clscc_ThemesEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clscc_ThemesEN> arrObjLst = new List<clscc_ThemesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_ThemesEN objcc_ThemesEN = new clscc_ThemesEN();
try
{
objcc_ThemesEN.ThemeId = objRow[concc_Themes.ThemeId].ToString().Trim(); //主题Id
objcc_ThemesEN.ThemeName = objRow[concc_Themes.ThemeName].ToString().Trim(); //主题名
objcc_ThemesEN.ThemeDesc = objRow[concc_Themes.ThemeDesc] == DBNull.Value ? null : objRow[concc_Themes.ThemeDesc].ToString().Trim(); //主题描述
objcc_ThemesEN.PageName = objRow[concc_Themes.PageName] == DBNull.Value ? null : objRow[concc_Themes.PageName].ToString().Trim(); //页面名称
objcc_ThemesEN.ExampleImgPath = objRow[concc_Themes.ExampleImgPath] == DBNull.Value ? null : objRow[concc_Themes.ExampleImgPath].ToString().Trim(); //示例图路径
objcc_ThemesEN.OrderNum = objRow[concc_Themes.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Themes.OrderNum].ToString().Trim()); //序号
objcc_ThemesEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[concc_Themes.IsUse].ToString().Trim()); //是否使用
objcc_ThemesEN.UpdDate = objRow[concc_Themes.UpdDate].ToString().Trim(); //修改日期
objcc_ThemesEN.UpdUserId = objRow[concc_Themes.UpdUserId] == DBNull.Value ? null : objRow[concc_Themes.UpdUserId].ToString().Trim(); //修改用户Id
objcc_ThemesEN.Memo = objRow[concc_Themes.Memo] == DBNull.Value ? null : objRow[concc_Themes.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_ThemesEN.ThemeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_ThemesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objcc_ThemesCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clscc_ThemesEN> GetSubObjLstCache(clscc_ThemesEN objcc_ThemesCond)
{
List<clscc_ThemesEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clscc_ThemesEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concc_Themes.AttributeName)
{
if (objcc_ThemesCond.IsUpdated(strFldName) == false) continue;
if (objcc_ThemesCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_ThemesCond[strFldName].ToString());
}
else
{
if (objcc_ThemesCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcc_ThemesCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_ThemesCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcc_ThemesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcc_ThemesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcc_ThemesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcc_ThemesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcc_ThemesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcc_ThemesCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcc_ThemesCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcc_ThemesCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcc_ThemesCond[strFldName]));
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
public static List<clscc_ThemesEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clscc_ThemesEN> arrObjLst = new List<clscc_ThemesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_ThemesEN objcc_ThemesEN = new clscc_ThemesEN();
try
{
objcc_ThemesEN.ThemeId = objRow[concc_Themes.ThemeId].ToString().Trim(); //主题Id
objcc_ThemesEN.ThemeName = objRow[concc_Themes.ThemeName].ToString().Trim(); //主题名
objcc_ThemesEN.ThemeDesc = objRow[concc_Themes.ThemeDesc] == DBNull.Value ? null : objRow[concc_Themes.ThemeDesc].ToString().Trim(); //主题描述
objcc_ThemesEN.PageName = objRow[concc_Themes.PageName] == DBNull.Value ? null : objRow[concc_Themes.PageName].ToString().Trim(); //页面名称
objcc_ThemesEN.ExampleImgPath = objRow[concc_Themes.ExampleImgPath] == DBNull.Value ? null : objRow[concc_Themes.ExampleImgPath].ToString().Trim(); //示例图路径
objcc_ThemesEN.OrderNum = objRow[concc_Themes.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Themes.OrderNum].ToString().Trim()); //序号
objcc_ThemesEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[concc_Themes.IsUse].ToString().Trim()); //是否使用
objcc_ThemesEN.UpdDate = objRow[concc_Themes.UpdDate].ToString().Trim(); //修改日期
objcc_ThemesEN.UpdUserId = objRow[concc_Themes.UpdUserId] == DBNull.Value ? null : objRow[concc_Themes.UpdUserId].ToString().Trim(); //修改用户Id
objcc_ThemesEN.Memo = objRow[concc_Themes.Memo] == DBNull.Value ? null : objRow[concc_Themes.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_ThemesEN.ThemeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_ThemesEN);
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
public static List<clscc_ThemesEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clscc_ThemesEN> arrObjLst = new List<clscc_ThemesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_ThemesEN objcc_ThemesEN = new clscc_ThemesEN();
try
{
objcc_ThemesEN.ThemeId = objRow[concc_Themes.ThemeId].ToString().Trim(); //主题Id
objcc_ThemesEN.ThemeName = objRow[concc_Themes.ThemeName].ToString().Trim(); //主题名
objcc_ThemesEN.ThemeDesc = objRow[concc_Themes.ThemeDesc] == DBNull.Value ? null : objRow[concc_Themes.ThemeDesc].ToString().Trim(); //主题描述
objcc_ThemesEN.PageName = objRow[concc_Themes.PageName] == DBNull.Value ? null : objRow[concc_Themes.PageName].ToString().Trim(); //页面名称
objcc_ThemesEN.ExampleImgPath = objRow[concc_Themes.ExampleImgPath] == DBNull.Value ? null : objRow[concc_Themes.ExampleImgPath].ToString().Trim(); //示例图路径
objcc_ThemesEN.OrderNum = objRow[concc_Themes.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Themes.OrderNum].ToString().Trim()); //序号
objcc_ThemesEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[concc_Themes.IsUse].ToString().Trim()); //是否使用
objcc_ThemesEN.UpdDate = objRow[concc_Themes.UpdDate].ToString().Trim(); //修改日期
objcc_ThemesEN.UpdUserId = objRow[concc_Themes.UpdUserId] == DBNull.Value ? null : objRow[concc_Themes.UpdUserId].ToString().Trim(); //修改用户Id
objcc_ThemesEN.Memo = objRow[concc_Themes.Memo] == DBNull.Value ? null : objRow[concc_Themes.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_ThemesEN.ThemeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_ThemesEN);
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
List<clscc_ThemesEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clscc_ThemesEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_ThemesEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clscc_ThemesEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clscc_ThemesEN> arrObjLst = new List<clscc_ThemesEN>(); 
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
	clscc_ThemesEN objcc_ThemesEN = new clscc_ThemesEN();
try
{
objcc_ThemesEN.ThemeId = objRow[concc_Themes.ThemeId].ToString().Trim(); //主题Id
objcc_ThemesEN.ThemeName = objRow[concc_Themes.ThemeName].ToString().Trim(); //主题名
objcc_ThemesEN.ThemeDesc = objRow[concc_Themes.ThemeDesc] == DBNull.Value ? null : objRow[concc_Themes.ThemeDesc].ToString().Trim(); //主题描述
objcc_ThemesEN.PageName = objRow[concc_Themes.PageName] == DBNull.Value ? null : objRow[concc_Themes.PageName].ToString().Trim(); //页面名称
objcc_ThemesEN.ExampleImgPath = objRow[concc_Themes.ExampleImgPath] == DBNull.Value ? null : objRow[concc_Themes.ExampleImgPath].ToString().Trim(); //示例图路径
objcc_ThemesEN.OrderNum = objRow[concc_Themes.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Themes.OrderNum].ToString().Trim()); //序号
objcc_ThemesEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[concc_Themes.IsUse].ToString().Trim()); //是否使用
objcc_ThemesEN.UpdDate = objRow[concc_Themes.UpdDate].ToString().Trim(); //修改日期
objcc_ThemesEN.UpdUserId = objRow[concc_Themes.UpdUserId] == DBNull.Value ? null : objRow[concc_Themes.UpdUserId].ToString().Trim(); //修改用户Id
objcc_ThemesEN.Memo = objRow[concc_Themes.Memo] == DBNull.Value ? null : objRow[concc_Themes.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_ThemesEN.ThemeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_ThemesEN);
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
public static List<clscc_ThemesEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clscc_ThemesEN> arrObjLst = new List<clscc_ThemesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_ThemesEN objcc_ThemesEN = new clscc_ThemesEN();
try
{
objcc_ThemesEN.ThemeId = objRow[concc_Themes.ThemeId].ToString().Trim(); //主题Id
objcc_ThemesEN.ThemeName = objRow[concc_Themes.ThemeName].ToString().Trim(); //主题名
objcc_ThemesEN.ThemeDesc = objRow[concc_Themes.ThemeDesc] == DBNull.Value ? null : objRow[concc_Themes.ThemeDesc].ToString().Trim(); //主题描述
objcc_ThemesEN.PageName = objRow[concc_Themes.PageName] == DBNull.Value ? null : objRow[concc_Themes.PageName].ToString().Trim(); //页面名称
objcc_ThemesEN.ExampleImgPath = objRow[concc_Themes.ExampleImgPath] == DBNull.Value ? null : objRow[concc_Themes.ExampleImgPath].ToString().Trim(); //示例图路径
objcc_ThemesEN.OrderNum = objRow[concc_Themes.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Themes.OrderNum].ToString().Trim()); //序号
objcc_ThemesEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[concc_Themes.IsUse].ToString().Trim()); //是否使用
objcc_ThemesEN.UpdDate = objRow[concc_Themes.UpdDate].ToString().Trim(); //修改日期
objcc_ThemesEN.UpdUserId = objRow[concc_Themes.UpdUserId] == DBNull.Value ? null : objRow[concc_Themes.UpdUserId].ToString().Trim(); //修改用户Id
objcc_ThemesEN.Memo = objRow[concc_Themes.Memo] == DBNull.Value ? null : objRow[concc_Themes.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_ThemesEN.ThemeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_ThemesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clscc_ThemesEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clscc_ThemesEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clscc_ThemesEN> arrObjLst = new List<clscc_ThemesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_ThemesEN objcc_ThemesEN = new clscc_ThemesEN();
try
{
objcc_ThemesEN.ThemeId = objRow[concc_Themes.ThemeId].ToString().Trim(); //主题Id
objcc_ThemesEN.ThemeName = objRow[concc_Themes.ThemeName].ToString().Trim(); //主题名
objcc_ThemesEN.ThemeDesc = objRow[concc_Themes.ThemeDesc] == DBNull.Value ? null : objRow[concc_Themes.ThemeDesc].ToString().Trim(); //主题描述
objcc_ThemesEN.PageName = objRow[concc_Themes.PageName] == DBNull.Value ? null : objRow[concc_Themes.PageName].ToString().Trim(); //页面名称
objcc_ThemesEN.ExampleImgPath = objRow[concc_Themes.ExampleImgPath] == DBNull.Value ? null : objRow[concc_Themes.ExampleImgPath].ToString().Trim(); //示例图路径
objcc_ThemesEN.OrderNum = objRow[concc_Themes.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Themes.OrderNum].ToString().Trim()); //序号
objcc_ThemesEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[concc_Themes.IsUse].ToString().Trim()); //是否使用
objcc_ThemesEN.UpdDate = objRow[concc_Themes.UpdDate].ToString().Trim(); //修改日期
objcc_ThemesEN.UpdUserId = objRow[concc_Themes.UpdUserId] == DBNull.Value ? null : objRow[concc_Themes.UpdUserId].ToString().Trim(); //修改用户Id
objcc_ThemesEN.Memo = objRow[concc_Themes.Memo] == DBNull.Value ? null : objRow[concc_Themes.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_ThemesEN.ThemeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_ThemesEN);
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
public static List<clscc_ThemesEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clscc_ThemesEN> arrObjLst = new List<clscc_ThemesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_ThemesEN objcc_ThemesEN = new clscc_ThemesEN();
try
{
objcc_ThemesEN.ThemeId = objRow[concc_Themes.ThemeId].ToString().Trim(); //主题Id
objcc_ThemesEN.ThemeName = objRow[concc_Themes.ThemeName].ToString().Trim(); //主题名
objcc_ThemesEN.ThemeDesc = objRow[concc_Themes.ThemeDesc] == DBNull.Value ? null : objRow[concc_Themes.ThemeDesc].ToString().Trim(); //主题描述
objcc_ThemesEN.PageName = objRow[concc_Themes.PageName] == DBNull.Value ? null : objRow[concc_Themes.PageName].ToString().Trim(); //页面名称
objcc_ThemesEN.ExampleImgPath = objRow[concc_Themes.ExampleImgPath] == DBNull.Value ? null : objRow[concc_Themes.ExampleImgPath].ToString().Trim(); //示例图路径
objcc_ThemesEN.OrderNum = objRow[concc_Themes.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Themes.OrderNum].ToString().Trim()); //序号
objcc_ThemesEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[concc_Themes.IsUse].ToString().Trim()); //是否使用
objcc_ThemesEN.UpdDate = objRow[concc_Themes.UpdDate].ToString().Trim(); //修改日期
objcc_ThemesEN.UpdUserId = objRow[concc_Themes.UpdUserId] == DBNull.Value ? null : objRow[concc_Themes.UpdUserId].ToString().Trim(); //修改用户Id
objcc_ThemesEN.Memo = objRow[concc_Themes.Memo] == DBNull.Value ? null : objRow[concc_Themes.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_ThemesEN.ThemeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_ThemesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_ThemesEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clscc_ThemesEN> arrObjLst = new List<clscc_ThemesEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_ThemesEN objcc_ThemesEN = new clscc_ThemesEN();
try
{
objcc_ThemesEN.ThemeId = objRow[concc_Themes.ThemeId].ToString().Trim(); //主题Id
objcc_ThemesEN.ThemeName = objRow[concc_Themes.ThemeName].ToString().Trim(); //主题名
objcc_ThemesEN.ThemeDesc = objRow[concc_Themes.ThemeDesc] == DBNull.Value ? null : objRow[concc_Themes.ThemeDesc].ToString().Trim(); //主题描述
objcc_ThemesEN.PageName = objRow[concc_Themes.PageName] == DBNull.Value ? null : objRow[concc_Themes.PageName].ToString().Trim(); //页面名称
objcc_ThemesEN.ExampleImgPath = objRow[concc_Themes.ExampleImgPath] == DBNull.Value ? null : objRow[concc_Themes.ExampleImgPath].ToString().Trim(); //示例图路径
objcc_ThemesEN.OrderNum = objRow[concc_Themes.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Themes.OrderNum].ToString().Trim()); //序号
objcc_ThemesEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[concc_Themes.IsUse].ToString().Trim()); //是否使用
objcc_ThemesEN.UpdDate = objRow[concc_Themes.UpdDate].ToString().Trim(); //修改日期
objcc_ThemesEN.UpdUserId = objRow[concc_Themes.UpdUserId] == DBNull.Value ? null : objRow[concc_Themes.UpdUserId].ToString().Trim(); //修改用户Id
objcc_ThemesEN.Memo = objRow[concc_Themes.Memo] == DBNull.Value ? null : objRow[concc_Themes.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_ThemesEN.ThemeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_ThemesEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objcc_ThemesEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getcc_Themes(ref clscc_ThemesEN objcc_ThemesEN)
{
bool bolResult = cc_ThemesDA.Getcc_Themes(ref objcc_ThemesEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strThemeId">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_ThemesEN GetObjByThemeId(string strThemeId)
{
if (strThemeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strThemeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strThemeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strThemeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clscc_ThemesEN objcc_ThemesEN = cc_ThemesDA.GetObjByThemeId(strThemeId);
return objcc_ThemesEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clscc_ThemesEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clscc_ThemesEN objcc_ThemesEN = cc_ThemesDA.GetFirstObj(strWhereCond);
 return objcc_ThemesEN;
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
public static clscc_ThemesEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clscc_ThemesEN objcc_ThemesEN = cc_ThemesDA.GetObjByDataRow(objRow);
 return objcc_ThemesEN;
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
public static clscc_ThemesEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clscc_ThemesEN objcc_ThemesEN = cc_ThemesDA.GetObjByDataRow(objRow);
 return objcc_ThemesEN;
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
 /// <param name = "strThemeId">所给的关键字</param>
 /// <param name = "lstcc_ThemesObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_ThemesEN GetObjByThemeIdFromList(string strThemeId, List<clscc_ThemesEN> lstcc_ThemesObjLst)
{
foreach (clscc_ThemesEN objcc_ThemesEN in lstcc_ThemesObjLst)
{
if (objcc_ThemesEN.ThemeId == strThemeId)
{
return objcc_ThemesEN;
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
 string strThemeId;
 try
 {
 strThemeId = new clscc_ThemesDA().GetFirstID(strWhereCond);
 return strThemeId;
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
 arrList = cc_ThemesDA.GetID(strWhereCond);
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
bool bolIsExist = cc_ThemesDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strThemeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strThemeId)
{
if (string.IsNullOrEmpty(strThemeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strThemeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = cc_ThemesDA.IsExist(strThemeId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strThemeId">主题Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strThemeId, string strOpUser)
{
clscc_ThemesEN objcc_ThemesEN = clscc_ThemesBL.GetObjByThemeId(strThemeId);
objcc_ThemesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objcc_ThemesEN.UpdUserId = strOpUser;
return clscc_ThemesBL.UpdateBySql2(objcc_ThemesEN);
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
 bolIsExist = clscc_ThemesDA.IsExistTable();
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
 bolIsExist = cc_ThemesDA.IsExistTable(strTabName);
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
 /// <param name = "objcc_ThemesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clscc_ThemesEN objcc_ThemesEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objcc_ThemesEN.ThemeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clscc_ThemesBL.IsExist(objcc_ThemesEN.ThemeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objcc_ThemesEN.ThemeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = cc_ThemesDA.AddNewRecordBySQL2(objcc_ThemesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ThemesBL.ReFreshCache();

if (clscc_ThemesBL.relatedActions != null)
{
clscc_ThemesBL.relatedActions.UpdRelaTabDate(objcc_ThemesEN.ThemeId, objcc_ThemesEN.UpdUserId);
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
 /// <param name = "objcc_ThemesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clscc_ThemesEN objcc_ThemesEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objcc_ThemesEN.ThemeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clscc_ThemesBL.IsExist(objcc_ThemesEN.ThemeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objcc_ThemesEN.ThemeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = cc_ThemesDA.AddNewRecordBySQL2WithReturnKey(objcc_ThemesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ThemesBL.ReFreshCache();

if (clscc_ThemesBL.relatedActions != null)
{
clscc_ThemesBL.relatedActions.UpdRelaTabDate(objcc_ThemesEN.ThemeId, objcc_ThemesEN.UpdUserId);
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
 /// <param name = "objcc_ThemesEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clscc_ThemesEN objcc_ThemesEN)
{
try
{
bool bolResult = cc_ThemesDA.Update(objcc_ThemesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ThemesBL.ReFreshCache();

if (clscc_ThemesBL.relatedActions != null)
{
clscc_ThemesBL.relatedActions.UpdRelaTabDate(objcc_ThemesEN.ThemeId, objcc_ThemesEN.UpdUserId);
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
 /// <param name = "objcc_ThemesEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clscc_ThemesEN objcc_ThemesEN)
{
 if (string.IsNullOrEmpty(objcc_ThemesEN.ThemeId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = cc_ThemesDA.UpdateBySql2(objcc_ThemesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ThemesBL.ReFreshCache();

if (clscc_ThemesBL.relatedActions != null)
{
clscc_ThemesBL.relatedActions.UpdRelaTabDate(objcc_ThemesEN.ThemeId, objcc_ThemesEN.UpdUserId);
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
 /// <param name = "strThemeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strThemeId)
{
try
{
 clscc_ThemesEN objcc_ThemesEN = clscc_ThemesBL.GetObjByThemeId(strThemeId);

if (clscc_ThemesBL.relatedActions != null)
{
clscc_ThemesBL.relatedActions.UpdRelaTabDate(objcc_ThemesEN.ThemeId, objcc_ThemesEN.UpdUserId);
}
if (objcc_ThemesEN != null)
{
int intRecNum = cc_ThemesDA.DelRecord(strThemeId);
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
/// <param name="strThemeId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strThemeId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscc_ThemesDA.GetSpecSQLObj();
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
//删除与表:[cc_Themes]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//concc_Themes.ThemeId,
//strThemeId);
//        clscc_ThemesBL.Delcc_ThemessByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscc_ThemesBL.DelRecord(strThemeId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscc_ThemesBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strThemeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strThemeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strThemeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clscc_ThemesBL.relatedActions != null)
{
clscc_ThemesBL.relatedActions.UpdRelaTabDate(strThemeId, "UpdRelaTabDate");
}
bool bolResult = cc_ThemesDA.DelRecord(strThemeId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrThemeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delcc_Themess(List<string> arrThemeIdLst)
{
if (arrThemeIdLst.Count == 0) return 0;
try
{
if (clscc_ThemesBL.relatedActions != null)
{
foreach (var strThemeId in arrThemeIdLst)
{
clscc_ThemesBL.relatedActions.UpdRelaTabDate(strThemeId, "UpdRelaTabDate");
}
}
int intDelRecNum = cc_ThemesDA.Delcc_Themes(arrThemeIdLst);
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
public static int Delcc_ThemessByCond(string strWhereCond)
{
try
{
if (clscc_ThemesBL.relatedActions != null)
{
List<string> arrThemeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strThemeId in arrThemeId)
{
clscc_ThemesBL.relatedActions.UpdRelaTabDate(strThemeId, "UpdRelaTabDate");
}
}
int intRecNum = cc_ThemesDA.Delcc_Themes(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[cc_Themes]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strThemeId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strThemeId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscc_ThemesDA.GetSpecSQLObj();
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
//删除与表:[cc_Themes]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscc_ThemesBL.DelRecord(strThemeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscc_ThemesBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strThemeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objcc_ThemesENS">源对象</param>
 /// <param name = "objcc_ThemesENT">目标对象</param>
 public static void CopyTo(clscc_ThemesEN objcc_ThemesENS, clscc_ThemesEN objcc_ThemesENT)
{
try
{
objcc_ThemesENT.ThemeId = objcc_ThemesENS.ThemeId; //主题Id
objcc_ThemesENT.ThemeName = objcc_ThemesENS.ThemeName; //主题名
objcc_ThemesENT.ThemeDesc = objcc_ThemesENS.ThemeDesc; //主题描述
objcc_ThemesENT.PageName = objcc_ThemesENS.PageName; //页面名称
objcc_ThemesENT.ExampleImgPath = objcc_ThemesENS.ExampleImgPath; //示例图路径
objcc_ThemesENT.OrderNum = objcc_ThemesENS.OrderNum; //序号
objcc_ThemesENT.IsUse = objcc_ThemesENS.IsUse; //是否使用
objcc_ThemesENT.UpdDate = objcc_ThemesENS.UpdDate; //修改日期
objcc_ThemesENT.UpdUserId = objcc_ThemesENS.UpdUserId; //修改用户Id
objcc_ThemesENT.Memo = objcc_ThemesENS.Memo; //备注
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
 /// <param name = "objcc_ThemesEN">源简化对象</param>
 public static void SetUpdFlag(clscc_ThemesEN objcc_ThemesEN)
{
try
{
objcc_ThemesEN.ClearUpdateState();
   string strsfUpdFldSetStr = objcc_ThemesEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(concc_Themes.ThemeId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ThemesEN.ThemeId = objcc_ThemesEN.ThemeId; //主题Id
}
if (arrFldSet.Contains(concc_Themes.ThemeName, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ThemesEN.ThemeName = objcc_ThemesEN.ThemeName; //主题名
}
if (arrFldSet.Contains(concc_Themes.ThemeDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ThemesEN.ThemeDesc = objcc_ThemesEN.ThemeDesc == "[null]" ? null :  objcc_ThemesEN.ThemeDesc; //主题描述
}
if (arrFldSet.Contains(concc_Themes.PageName, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ThemesEN.PageName = objcc_ThemesEN.PageName == "[null]" ? null :  objcc_ThemesEN.PageName; //页面名称
}
if (arrFldSet.Contains(concc_Themes.ExampleImgPath, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ThemesEN.ExampleImgPath = objcc_ThemesEN.ExampleImgPath == "[null]" ? null :  objcc_ThemesEN.ExampleImgPath; //示例图路径
}
if (arrFldSet.Contains(concc_Themes.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ThemesEN.OrderNum = objcc_ThemesEN.OrderNum; //序号
}
if (arrFldSet.Contains(concc_Themes.IsUse, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ThemesEN.IsUse = objcc_ThemesEN.IsUse; //是否使用
}
if (arrFldSet.Contains(concc_Themes.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ThemesEN.UpdDate = objcc_ThemesEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(concc_Themes.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ThemesEN.UpdUserId = objcc_ThemesEN.UpdUserId == "[null]" ? null :  objcc_ThemesEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(concc_Themes.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ThemesEN.Memo = objcc_ThemesEN.Memo == "[null]" ? null :  objcc_ThemesEN.Memo; //备注
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
 /// <param name = "objcc_ThemesEN">源简化对象</param>
 public static void AccessFldValueNull(clscc_ThemesEN objcc_ThemesEN)
{
try
{
if (objcc_ThemesEN.ThemeDesc == "[null]") objcc_ThemesEN.ThemeDesc = null; //主题描述
if (objcc_ThemesEN.PageName == "[null]") objcc_ThemesEN.PageName = null; //页面名称
if (objcc_ThemesEN.ExampleImgPath == "[null]") objcc_ThemesEN.ExampleImgPath = null; //示例图路径
if (objcc_ThemesEN.UpdUserId == "[null]") objcc_ThemesEN.UpdUserId = null; //修改用户Id
if (objcc_ThemesEN.Memo == "[null]") objcc_ThemesEN.Memo = null; //备注
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
public static void CheckPropertyNew(clscc_ThemesEN objcc_ThemesEN)
{
 cc_ThemesDA.CheckPropertyNew(objcc_ThemesEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clscc_ThemesEN objcc_ThemesEN)
{
 cc_ThemesDA.CheckProperty4Condition(objcc_ThemesEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_ThemeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", concc_Themes.ThemeId); 
List<clscc_ThemesEN> arrObjLst = clscc_ThemesBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clscc_ThemesEN objcc_ThemesEN = new clscc_ThemesEN()
{
ThemeId = "0",
ThemeName = "选[课程主题]..."
};
arrObjLst.Insert(0, objcc_ThemesEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = concc_Themes.ThemeId;
objComboBox.DisplayMember = concc_Themes.ThemeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_ThemeId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[课程主题]...","0");
string strCondition = string.Format("1 =1 Order By {0}", concc_Themes.ThemeId); 
IEnumerable<clscc_ThemesEN> arrObjLst = clscc_ThemesBL.GetObjLst(strCondition);
objDDL.DataValueField = concc_Themes.ThemeId;
objDDL.DataTextField = concc_Themes.ThemeName;
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
public static void BindDdl_ThemeIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[课程主题]...","0");
List<clscc_ThemesEN> arrcc_ThemesObjLst = GetAllcc_ThemesObjLstCache(); 
objDDL.DataValueField = concc_Themes.ThemeId;
objDDL.DataTextField = concc_Themes.ThemeName;
objDDL.DataSource = arrcc_ThemesObjLst;
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
if (clscc_ThemesBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ThemesBL没有刷新缓存机制(clscc_ThemesBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ThemeId");
//if (arrcc_ThemesObjLstCache == null)
//{
//arrcc_ThemesObjLstCache = cc_ThemesDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strThemeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_ThemesEN GetObjByThemeIdCache(string strThemeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clscc_ThemesEN._CurrTabName);
List<clscc_ThemesEN> arrcc_ThemesObjLstCache = GetObjLstCache();
IEnumerable <clscc_ThemesEN> arrcc_ThemesObjLst_Sel =
arrcc_ThemesObjLstCache
.Where(x=> x.ThemeId == strThemeId 
);
if (arrcc_ThemesObjLst_Sel.Count() == 0)
{
   clscc_ThemesEN obj = clscc_ThemesBL.GetObjByThemeId(strThemeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrcc_ThemesObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strThemeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetThemeNameByThemeIdCache(string strThemeId)
{
if (string.IsNullOrEmpty(strThemeId) == true) return "";
//获取缓存中的对象列表
clscc_ThemesEN objcc_Themes = GetObjByThemeIdCache(strThemeId);
if (objcc_Themes == null) return "";
return objcc_Themes.ThemeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strThemeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByThemeIdCache(string strThemeId)
{
if (string.IsNullOrEmpty(strThemeId) == true) return "";
//获取缓存中的对象列表
clscc_ThemesEN objcc_Themes = GetObjByThemeIdCache(strThemeId);
if (objcc_Themes == null) return "";
return objcc_Themes.ThemeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_ThemesEN> GetAllcc_ThemesObjLstCache()
{
//获取缓存中的对象列表
List<clscc_ThemesEN> arrcc_ThemesObjLstCache = GetObjLstCache(); 
return arrcc_ThemesObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_ThemesEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clscc_ThemesEN._CurrTabName);
List<clscc_ThemesEN> arrcc_ThemesObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrcc_ThemesObjLstCache;
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
string strKey = string.Format("{0}", clscc_ThemesEN._CurrTabName);
CacheHelper.Remove(strKey);
clscc_ThemesEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clscc_ThemesEN._RefreshTimeLst.Count == 0) return "";
return clscc_ThemesEN._RefreshTimeLst[clscc_ThemesEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clscc_ThemesBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clscc_ThemesEN._CurrTabName);
CacheHelper.Remove(strKey);
clscc_ThemesEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clscc_ThemesBL.objCommFun4BL.ReFreshCache();
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
public static string Func(string strInFldName, string strOutFldName, string strThemeId)
{
if (strInFldName != concc_Themes.ThemeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (concc_Themes.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", concc_Themes.AttributeName));
throw new Exception(strMsg);
}
var objcc_Themes = clscc_ThemesBL.GetObjByThemeIdCache(strThemeId);
if (objcc_Themes == null) return "";
return objcc_Themes[strOutFldName].ToString();
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
int intRecCount = clscc_ThemesDA.GetRecCount(strTabName);
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
int intRecCount = clscc_ThemesDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clscc_ThemesDA.GetRecCount();
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
int intRecCount = clscc_ThemesDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objcc_ThemesCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clscc_ThemesEN objcc_ThemesCond)
{
List<clscc_ThemesEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clscc_ThemesEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concc_Themes.AttributeName)
{
if (objcc_ThemesCond.IsUpdated(strFldName) == false) continue;
if (objcc_ThemesCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_ThemesCond[strFldName].ToString());
}
else
{
if (objcc_ThemesCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcc_ThemesCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_ThemesCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcc_ThemesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcc_ThemesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcc_ThemesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcc_ThemesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcc_ThemesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcc_ThemesCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcc_ThemesCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcc_ThemesCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcc_ThemesCond[strFldName]));
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
 List<string> arrList = clscc_ThemesDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = cc_ThemesDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = cc_ThemesDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = cc_ThemesDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clscc_ThemesDA.SetFldValue(clscc_ThemesEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = cc_ThemesDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clscc_ThemesDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clscc_ThemesDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clscc_ThemesDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[cc_Themes] "); 
 strCreateTabCode.Append(" ( "); 
 // /**主题Id*/ 
 strCreateTabCode.Append(" ThemeId char(4) primary key, "); 
 // /**主题名*/ 
 strCreateTabCode.Append(" ThemeName varchar(200) not Null, "); 
 // /**主题描述*/ 
 strCreateTabCode.Append(" ThemeDesc varchar(500) Null, "); 
 // /**页面名称*/ 
 strCreateTabCode.Append(" PageName varchar(100) Null, "); 
 // /**示例图路径*/ 
 strCreateTabCode.Append(" ExampleImgPath varchar(300) Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**是否使用*/ 
 strCreateTabCode.Append(" IsUse bit Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) not Null, "); 
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
 /// 课程主题(cc_Themes)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4cc_Themes : clsCommFun4BL
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
clscc_ThemesBL.ReFreshThisCache();
}
}

}