
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDiscussionSubContentBL
 表名:DiscussionSubContent(01120587)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:09:11
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
public static class  clsDiscussionSubContentBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strSubContentId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDiscussionSubContentEN GetObj(this K_SubContentId_DiscussionSubContent myKey)
{
clsDiscussionSubContentEN objDiscussionSubContentEN = clsDiscussionSubContentBL.DiscussionSubContentDA.GetObjBySubContentId(myKey.Value);
return objDiscussionSubContentEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objDiscussionSubContentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsDiscussionSubContentEN objDiscussionSubContentEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objDiscussionSubContentEN) == false)
{
var strMsg = string.Format("记录已经存在!子内容 = [{0}],主题Id = [{1}]的数据已经存在!(in clsDiscussionSubContentBL.AddNewRecord)", objDiscussionSubContentEN.SubContent,objDiscussionSubContentEN.TopicsId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objDiscussionSubContentEN.SubContentId) == true || clsDiscussionSubContentBL.IsExist(objDiscussionSubContentEN.SubContentId) == true)
 {
     objDiscussionSubContentEN.SubContentId = clsDiscussionSubContentBL.GetMaxStrId_S();
 }
bool bolResult = clsDiscussionSubContentBL.DiscussionSubContentDA.AddNewRecordBySQL2(objDiscussionSubContentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDiscussionSubContentBL.ReFreshCache();

if (clsDiscussionSubContentBL.relatedActions != null)
{
clsDiscussionSubContentBL.relatedActions.UpdRelaTabDate(objDiscussionSubContentEN.SubContentId, objDiscussionSubContentEN.UpdUser);
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
public static bool AddRecordEx(this clsDiscussionSubContentEN objDiscussionSubContentEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsDiscussionSubContentBL.IsExist(objDiscussionSubContentEN.SubContentId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objDiscussionSubContentEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objDiscussionSubContentEN.CheckUniqueness() == false)
{
strMsg = string.Format("(子内容(SubContent)=[{0}],主题Id(TopicsId)=[{1}])已经存在,不能重复!", objDiscussionSubContentEN.SubContent, objDiscussionSubContentEN.TopicsId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objDiscussionSubContentEN.SubContentId) == true || clsDiscussionSubContentBL.IsExist(objDiscussionSubContentEN.SubContentId) == true)
 {
     objDiscussionSubContentEN.SubContentId = clsDiscussionSubContentBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objDiscussionSubContentEN.AddNewRecord();
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
 /// <param name = "objDiscussionSubContentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsDiscussionSubContentEN objDiscussionSubContentEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objDiscussionSubContentEN) == false)
{
var strMsg = string.Format("记录已经存在!子内容 = [{0}],主题Id = [{1}]的数据已经存在!(in clsDiscussionSubContentBL.AddNewRecordWithMaxId)", objDiscussionSubContentEN.SubContent,objDiscussionSubContentEN.TopicsId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objDiscussionSubContentEN.SubContentId) == true || clsDiscussionSubContentBL.IsExist(objDiscussionSubContentEN.SubContentId) == true)
 {
     objDiscussionSubContentEN.SubContentId = clsDiscussionSubContentBL.GetMaxStrId_S();
 }
string strSubContentId = clsDiscussionSubContentBL.DiscussionSubContentDA.AddNewRecordBySQL2WithReturnKey(objDiscussionSubContentEN);
     objDiscussionSubContentEN.SubContentId = strSubContentId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDiscussionSubContentBL.ReFreshCache();

if (clsDiscussionSubContentBL.relatedActions != null)
{
clsDiscussionSubContentBL.relatedActions.UpdRelaTabDate(objDiscussionSubContentEN.SubContentId, objDiscussionSubContentEN.UpdUser);
}
return strSubContentId;
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
 /// <param name = "objDiscussionSubContentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsDiscussionSubContentEN objDiscussionSubContentEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objDiscussionSubContentEN) == false)
{
var strMsg = string.Format("记录已经存在!子内容 = [{0}],主题Id = [{1}]的数据已经存在!(in clsDiscussionSubContentBL.AddNewRecordWithReturnKey)", objDiscussionSubContentEN.SubContent,objDiscussionSubContentEN.TopicsId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objDiscussionSubContentEN.SubContentId) == true || clsDiscussionSubContentBL.IsExist(objDiscussionSubContentEN.SubContentId) == true)
 {
     objDiscussionSubContentEN.SubContentId = clsDiscussionSubContentBL.GetMaxStrId_S();
 }
string strKey = clsDiscussionSubContentBL.DiscussionSubContentDA.AddNewRecordBySQL2WithReturnKey(objDiscussionSubContentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDiscussionSubContentBL.ReFreshCache();

if (clsDiscussionSubContentBL.relatedActions != null)
{
clsDiscussionSubContentBL.relatedActions.UpdRelaTabDate(objDiscussionSubContentEN.SubContentId, objDiscussionSubContentEN.UpdUser);
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
 /// <param name = "objDiscussionSubContentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDiscussionSubContentEN SetSubContentId(this clsDiscussionSubContentEN objDiscussionSubContentEN, string strSubContentId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSubContentId, 10, conDiscussionSubContent.SubContentId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSubContentId, 10, conDiscussionSubContent.SubContentId);
}
objDiscussionSubContentEN.SubContentId = strSubContentId; //子内容Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDiscussionSubContentEN.dicFldComparisonOp.ContainsKey(conDiscussionSubContent.SubContentId) == false)
{
objDiscussionSubContentEN.dicFldComparisonOp.Add(conDiscussionSubContent.SubContentId, strComparisonOp);
}
else
{
objDiscussionSubContentEN.dicFldComparisonOp[conDiscussionSubContent.SubContentId] = strComparisonOp;
}
}
return objDiscussionSubContentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDiscussionSubContentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDiscussionSubContentEN SetSubContent(this clsDiscussionSubContentEN objDiscussionSubContentEN, string strSubContent, string strComparisonOp="")
	{
objDiscussionSubContentEN.SubContent = strSubContent; //子内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDiscussionSubContentEN.dicFldComparisonOp.ContainsKey(conDiscussionSubContent.SubContent) == false)
{
objDiscussionSubContentEN.dicFldComparisonOp.Add(conDiscussionSubContent.SubContent, strComparisonOp);
}
else
{
objDiscussionSubContentEN.dicFldComparisonOp[conDiscussionSubContent.SubContent] = strComparisonOp;
}
}
return objDiscussionSubContentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDiscussionSubContentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDiscussionSubContentEN SetTopicsId(this clsDiscussionSubContentEN objDiscussionSubContentEN, string strTopicsId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicsId, 8, conDiscussionSubContent.TopicsId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTopicsId, 8, conDiscussionSubContent.TopicsId);
}
objDiscussionSubContentEN.TopicsId = strTopicsId; //主题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDiscussionSubContentEN.dicFldComparisonOp.ContainsKey(conDiscussionSubContent.TopicsId) == false)
{
objDiscussionSubContentEN.dicFldComparisonOp.Add(conDiscussionSubContent.TopicsId, strComparisonOp);
}
else
{
objDiscussionSubContentEN.dicFldComparisonOp[conDiscussionSubContent.TopicsId] = strComparisonOp;
}
}
return objDiscussionSubContentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDiscussionSubContentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDiscussionSubContentEN SetIsTop(this clsDiscussionSubContentEN objDiscussionSubContentEN, bool bolIsTop, string strComparisonOp="")
	{
objDiscussionSubContentEN.IsTop = bolIsTop; //是否置顶
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDiscussionSubContentEN.dicFldComparisonOp.ContainsKey(conDiscussionSubContent.IsTop) == false)
{
objDiscussionSubContentEN.dicFldComparisonOp.Add(conDiscussionSubContent.IsTop, strComparisonOp);
}
else
{
objDiscussionSubContentEN.dicFldComparisonOp[conDiscussionSubContent.IsTop] = strComparisonOp;
}
}
return objDiscussionSubContentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDiscussionSubContentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDiscussionSubContentEN SetUpdDate(this clsDiscussionSubContentEN objDiscussionSubContentEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conDiscussionSubContent.UpdDate);
}
objDiscussionSubContentEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDiscussionSubContentEN.dicFldComparisonOp.ContainsKey(conDiscussionSubContent.UpdDate) == false)
{
objDiscussionSubContentEN.dicFldComparisonOp.Add(conDiscussionSubContent.UpdDate, strComparisonOp);
}
else
{
objDiscussionSubContentEN.dicFldComparisonOp[conDiscussionSubContent.UpdDate] = strComparisonOp;
}
}
return objDiscussionSubContentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDiscussionSubContentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDiscussionSubContentEN SetUpdUser(this clsDiscussionSubContentEN objDiscussionSubContentEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conDiscussionSubContent.UpdUser);
}
objDiscussionSubContentEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDiscussionSubContentEN.dicFldComparisonOp.ContainsKey(conDiscussionSubContent.UpdUser) == false)
{
objDiscussionSubContentEN.dicFldComparisonOp.Add(conDiscussionSubContent.UpdUser, strComparisonOp);
}
else
{
objDiscussionSubContentEN.dicFldComparisonOp[conDiscussionSubContent.UpdUser] = strComparisonOp;
}
}
return objDiscussionSubContentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDiscussionSubContentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDiscussionSubContentEN SetMemo(this clsDiscussionSubContentEN objDiscussionSubContentEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conDiscussionSubContent.Memo);
}
objDiscussionSubContentEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDiscussionSubContentEN.dicFldComparisonOp.ContainsKey(conDiscussionSubContent.Memo) == false)
{
objDiscussionSubContentEN.dicFldComparisonOp.Add(conDiscussionSubContent.Memo, strComparisonOp);
}
else
{
objDiscussionSubContentEN.dicFldComparisonOp[conDiscussionSubContent.Memo] = strComparisonOp;
}
}
return objDiscussionSubContentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDiscussionSubContentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDiscussionSubContentEN SetParentId(this clsDiscussionSubContentEN objDiscussionSubContentEN, string strParentId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentId, 10, conDiscussionSubContent.ParentId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strParentId, 10, conDiscussionSubContent.ParentId);
}
objDiscussionSubContentEN.ParentId = strParentId; //父节点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDiscussionSubContentEN.dicFldComparisonOp.ContainsKey(conDiscussionSubContent.ParentId) == false)
{
objDiscussionSubContentEN.dicFldComparisonOp.Add(conDiscussionSubContent.ParentId, strComparisonOp);
}
else
{
objDiscussionSubContentEN.dicFldComparisonOp[conDiscussionSubContent.ParentId] = strComparisonOp;
}
}
return objDiscussionSubContentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDiscussionSubContentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDiscussionSubContentEN SetUserId(this clsDiscussionSubContentEN objDiscussionSubContentEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conDiscussionSubContent.UserId);
}
objDiscussionSubContentEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDiscussionSubContentEN.dicFldComparisonOp.ContainsKey(conDiscussionSubContent.UserId) == false)
{
objDiscussionSubContentEN.dicFldComparisonOp.Add(conDiscussionSubContent.UserId, strComparisonOp);
}
else
{
objDiscussionSubContentEN.dicFldComparisonOp[conDiscussionSubContent.UserId] = strComparisonOp;
}
}
return objDiscussionSubContentEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objDiscussionSubContentEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsDiscussionSubContentEN objDiscussionSubContentEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objDiscussionSubContentEN.CheckPropertyNew();
clsDiscussionSubContentEN objDiscussionSubContentCond = new clsDiscussionSubContentEN();
string strCondition = objDiscussionSubContentCond
.SetSubContentId(objDiscussionSubContentEN.SubContentId, "<>")
.SetSubContent(objDiscussionSubContentEN.SubContent, "=")
.SetTopicsId(objDiscussionSubContentEN.TopicsId, "=")
.GetCombineCondition();
objDiscussionSubContentEN._IsCheckProperty = true;
bool bolIsExist = clsDiscussionSubContentBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(SubContent_TopicsId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objDiscussionSubContentEN.Update();
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
 /// <param name = "objDiscussionSubContent">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsDiscussionSubContentEN objDiscussionSubContent)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsDiscussionSubContentEN objDiscussionSubContentCond = new clsDiscussionSubContentEN();
string strCondition = objDiscussionSubContentCond
.SetSubContent(objDiscussionSubContent.SubContent, "=")
.SetTopicsId(objDiscussionSubContent.TopicsId, "=")
.GetCombineCondition();
objDiscussionSubContent._IsCheckProperty = true;
bool bolIsExist = clsDiscussionSubContentBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objDiscussionSubContent.SubContentId = clsDiscussionSubContentBL.GetFirstID_S(strCondition);
objDiscussionSubContent.UpdateWithCondition(strCondition);
}
else
{
objDiscussionSubContent.SubContentId = clsDiscussionSubContentBL.GetMaxStrId_S();
objDiscussionSubContent.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objDiscussionSubContentEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDiscussionSubContentEN objDiscussionSubContentEN)
{
 if (string.IsNullOrEmpty(objDiscussionSubContentEN.SubContentId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsDiscussionSubContentBL.DiscussionSubContentDA.UpdateBySql2(objDiscussionSubContentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDiscussionSubContentBL.ReFreshCache();

if (clsDiscussionSubContentBL.relatedActions != null)
{
clsDiscussionSubContentBL.relatedActions.UpdRelaTabDate(objDiscussionSubContentEN.SubContentId, objDiscussionSubContentEN.UpdUser);
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
 /// <param name = "objDiscussionSubContentEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDiscussionSubContentEN objDiscussionSubContentEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objDiscussionSubContentEN.SubContentId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsDiscussionSubContentBL.DiscussionSubContentDA.UpdateBySql2(objDiscussionSubContentEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDiscussionSubContentBL.ReFreshCache();

if (clsDiscussionSubContentBL.relatedActions != null)
{
clsDiscussionSubContentBL.relatedActions.UpdRelaTabDate(objDiscussionSubContentEN.SubContentId, objDiscussionSubContentEN.UpdUser);
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
 /// <param name = "objDiscussionSubContentEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDiscussionSubContentEN objDiscussionSubContentEN, string strWhereCond)
{
try
{
bool bolResult = clsDiscussionSubContentBL.DiscussionSubContentDA.UpdateBySqlWithCondition(objDiscussionSubContentEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDiscussionSubContentBL.ReFreshCache();

if (clsDiscussionSubContentBL.relatedActions != null)
{
clsDiscussionSubContentBL.relatedActions.UpdRelaTabDate(objDiscussionSubContentEN.SubContentId, objDiscussionSubContentEN.UpdUser);
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
 /// <param name = "objDiscussionSubContentEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDiscussionSubContentEN objDiscussionSubContentEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsDiscussionSubContentBL.DiscussionSubContentDA.UpdateBySqlWithConditionTransaction(objDiscussionSubContentEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDiscussionSubContentBL.ReFreshCache();

if (clsDiscussionSubContentBL.relatedActions != null)
{
clsDiscussionSubContentBL.relatedActions.UpdRelaTabDate(objDiscussionSubContentEN.SubContentId, objDiscussionSubContentEN.UpdUser);
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
 /// <param name = "strSubContentId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsDiscussionSubContentEN objDiscussionSubContentEN)
{
try
{
int intRecNum = clsDiscussionSubContentBL.DiscussionSubContentDA.DelRecord(objDiscussionSubContentEN.SubContentId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDiscussionSubContentBL.ReFreshCache();

if (clsDiscussionSubContentBL.relatedActions != null)
{
clsDiscussionSubContentBL.relatedActions.UpdRelaTabDate(objDiscussionSubContentEN.SubContentId, objDiscussionSubContentEN.UpdUser);
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
 /// <param name = "objDiscussionSubContentENS">源对象</param>
 /// <param name = "objDiscussionSubContentENT">目标对象</param>
 public static void CopyTo(this clsDiscussionSubContentEN objDiscussionSubContentENS, clsDiscussionSubContentEN objDiscussionSubContentENT)
{
try
{
objDiscussionSubContentENT.SubContentId = objDiscussionSubContentENS.SubContentId; //子内容Id
objDiscussionSubContentENT.SubContent = objDiscussionSubContentENS.SubContent; //子内容
objDiscussionSubContentENT.TopicsId = objDiscussionSubContentENS.TopicsId; //主题Id
objDiscussionSubContentENT.IsTop = objDiscussionSubContentENS.IsTop; //是否置顶
objDiscussionSubContentENT.UpdDate = objDiscussionSubContentENS.UpdDate; //修改日期
objDiscussionSubContentENT.UpdUser = objDiscussionSubContentENS.UpdUser; //修改人
objDiscussionSubContentENT.Memo = objDiscussionSubContentENS.Memo; //备注
objDiscussionSubContentENT.ParentId = objDiscussionSubContentENS.ParentId; //父节点Id
objDiscussionSubContentENT.UserId = objDiscussionSubContentENS.UserId; //用户ID
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
 /// <param name = "objDiscussionSubContentENS">源对象</param>
 /// <returns>目标对象=>clsDiscussionSubContentEN:objDiscussionSubContentENT</returns>
 public static clsDiscussionSubContentEN CopyTo(this clsDiscussionSubContentEN objDiscussionSubContentENS)
{
try
{
 clsDiscussionSubContentEN objDiscussionSubContentENT = new clsDiscussionSubContentEN()
{
SubContentId = objDiscussionSubContentENS.SubContentId, //子内容Id
SubContent = objDiscussionSubContentENS.SubContent, //子内容
TopicsId = objDiscussionSubContentENS.TopicsId, //主题Id
IsTop = objDiscussionSubContentENS.IsTop, //是否置顶
UpdDate = objDiscussionSubContentENS.UpdDate, //修改日期
UpdUser = objDiscussionSubContentENS.UpdUser, //修改人
Memo = objDiscussionSubContentENS.Memo, //备注
ParentId = objDiscussionSubContentENS.ParentId, //父节点Id
UserId = objDiscussionSubContentENS.UserId, //用户ID
};
 return objDiscussionSubContentENT;
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
public static void CheckPropertyNew(this clsDiscussionSubContentEN objDiscussionSubContentEN)
{
 clsDiscussionSubContentBL.DiscussionSubContentDA.CheckPropertyNew(objDiscussionSubContentEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsDiscussionSubContentEN objDiscussionSubContentEN)
{
 clsDiscussionSubContentBL.DiscussionSubContentDA.CheckProperty4Condition(objDiscussionSubContentEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsDiscussionSubContentEN objDiscussionSubContentCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objDiscussionSubContentCond.IsUpdated(conDiscussionSubContent.SubContentId) == true)
{
string strComparisonOpSubContentId = objDiscussionSubContentCond.dicFldComparisonOp[conDiscussionSubContent.SubContentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDiscussionSubContent.SubContentId, objDiscussionSubContentCond.SubContentId, strComparisonOpSubContentId);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objDiscussionSubContentCond.IsUpdated(conDiscussionSubContent.TopicsId) == true)
{
string strComparisonOpTopicsId = objDiscussionSubContentCond.dicFldComparisonOp[conDiscussionSubContent.TopicsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDiscussionSubContent.TopicsId, objDiscussionSubContentCond.TopicsId, strComparisonOpTopicsId);
}
if (objDiscussionSubContentCond.IsUpdated(conDiscussionSubContent.IsTop) == true)
{
if (objDiscussionSubContentCond.IsTop == true)
{
strWhereCond += string.Format(" And {0} = '1'", conDiscussionSubContent.IsTop);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conDiscussionSubContent.IsTop);
}
}
if (objDiscussionSubContentCond.IsUpdated(conDiscussionSubContent.UpdDate) == true)
{
string strComparisonOpUpdDate = objDiscussionSubContentCond.dicFldComparisonOp[conDiscussionSubContent.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDiscussionSubContent.UpdDate, objDiscussionSubContentCond.UpdDate, strComparisonOpUpdDate);
}
if (objDiscussionSubContentCond.IsUpdated(conDiscussionSubContent.UpdUser) == true)
{
string strComparisonOpUpdUser = objDiscussionSubContentCond.dicFldComparisonOp[conDiscussionSubContent.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDiscussionSubContent.UpdUser, objDiscussionSubContentCond.UpdUser, strComparisonOpUpdUser);
}
if (objDiscussionSubContentCond.IsUpdated(conDiscussionSubContent.Memo) == true)
{
string strComparisonOpMemo = objDiscussionSubContentCond.dicFldComparisonOp[conDiscussionSubContent.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDiscussionSubContent.Memo, objDiscussionSubContentCond.Memo, strComparisonOpMemo);
}
if (objDiscussionSubContentCond.IsUpdated(conDiscussionSubContent.ParentId) == true)
{
string strComparisonOpParentId = objDiscussionSubContentCond.dicFldComparisonOp[conDiscussionSubContent.ParentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDiscussionSubContent.ParentId, objDiscussionSubContentCond.ParentId, strComparisonOpParentId);
}
if (objDiscussionSubContentCond.IsUpdated(conDiscussionSubContent.UserId) == true)
{
string strComparisonOpUserId = objDiscussionSubContentCond.dicFldComparisonOp[conDiscussionSubContent.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDiscussionSubContent.UserId, objDiscussionSubContentCond.UserId, strComparisonOpUserId);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--DiscussionSubContent(讨论子内容), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:SubContent_TopicsId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objDiscussionSubContentEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsDiscussionSubContentEN objDiscussionSubContentEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objDiscussionSubContentEN == null) return true;
if (objDiscussionSubContentEN.SubContentId == null || objDiscussionSubContentEN.SubContentId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objDiscussionSubContentEN.SubContent == null)
{
 sbCondition.AppendFormat(" and SubContent is null", objDiscussionSubContentEN.SubContent);
}
else
{
 sbCondition.AppendFormat(" and SubContent = '{0}'", objDiscussionSubContentEN.SubContent);
}
 if (objDiscussionSubContentEN.TopicsId == null)
{
 sbCondition.AppendFormat(" and TopicsId is null", objDiscussionSubContentEN.TopicsId);
}
else
{
 sbCondition.AppendFormat(" and TopicsId = '{0}'", objDiscussionSubContentEN.TopicsId);
}
if (clsDiscussionSubContentBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("SubContentId !=  '{0}'", objDiscussionSubContentEN.SubContentId);
 sbCondition.AppendFormat(" and SubContent = '{0}'", objDiscussionSubContentEN.SubContent);
 sbCondition.AppendFormat(" and TopicsId = '{0}'", objDiscussionSubContentEN.TopicsId);
if (clsDiscussionSubContentBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--DiscussionSubContent(讨论子内容), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:SubContent_TopicsId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objDiscussionSubContentEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsDiscussionSubContentEN objDiscussionSubContentEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objDiscussionSubContentEN == null) return "";
if (objDiscussionSubContentEN.SubContentId == null || objDiscussionSubContentEN.SubContentId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objDiscussionSubContentEN.SubContent == null)
{
 sbCondition.AppendFormat(" and SubContent is null", objDiscussionSubContentEN.SubContent);
}
else
{
 sbCondition.AppendFormat(" and SubContent = '{0}'", objDiscussionSubContentEN.SubContent);
}
 if (objDiscussionSubContentEN.TopicsId == null)
{
 sbCondition.AppendFormat(" and TopicsId is null", objDiscussionSubContentEN.TopicsId);
}
else
{
 sbCondition.AppendFormat(" and TopicsId = '{0}'", objDiscussionSubContentEN.TopicsId);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("SubContentId !=  '{0}'", objDiscussionSubContentEN.SubContentId);
 sbCondition.AppendFormat(" and SubContent = '{0}'", objDiscussionSubContentEN.SubContent);
 sbCondition.AppendFormat(" and TopicsId = '{0}'", objDiscussionSubContentEN.TopicsId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_DiscussionSubContent
{
public virtual bool UpdRelaTabDate(string strSubContentId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 讨论子内容(DiscussionSubContent)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsDiscussionSubContentBL
{
public static RelatedActions_DiscussionSubContent relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsDiscussionSubContentDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsDiscussionSubContentDA DiscussionSubContentDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsDiscussionSubContentDA();
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
 public clsDiscussionSubContentBL()
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
if (string.IsNullOrEmpty(clsDiscussionSubContentEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsDiscussionSubContentEN._ConnectString);
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
public static DataTable GetDataTable_DiscussionSubContent(string strWhereCond)
{
DataTable objDT;
try
{
objDT = DiscussionSubContentDA.GetDataTable_DiscussionSubContent(strWhereCond);
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
objDT = DiscussionSubContentDA.GetDataTable(strWhereCond);
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
objDT = DiscussionSubContentDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = DiscussionSubContentDA.GetDataTable(strWhereCond, strTabName);
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
objDT = DiscussionSubContentDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = DiscussionSubContentDA.GetDataTable_Top(objTopPara);
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
objDT = DiscussionSubContentDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = DiscussionSubContentDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = DiscussionSubContentDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrSubContentIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsDiscussionSubContentEN> GetObjLstBySubContentIdLst(List<string> arrSubContentIdLst)
{
List<clsDiscussionSubContentEN> arrObjLst = new List<clsDiscussionSubContentEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrSubContentIdLst, true);
 string strWhereCond = string.Format("SubContentId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDiscussionSubContentEN objDiscussionSubContentEN = new clsDiscussionSubContentEN();
try
{
objDiscussionSubContentEN.SubContentId = objRow[conDiscussionSubContent.SubContentId].ToString().Trim(); //子内容Id
objDiscussionSubContentEN.SubContent = objRow[conDiscussionSubContent.SubContent] == DBNull.Value ? null : objRow[conDiscussionSubContent.SubContent].ToString().Trim(); //子内容
objDiscussionSubContentEN.TopicsId = objRow[conDiscussionSubContent.TopicsId] == DBNull.Value ? null : objRow[conDiscussionSubContent.TopicsId].ToString().Trim(); //主题Id
objDiscussionSubContentEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[conDiscussionSubContent.IsTop].ToString().Trim()); //是否置顶
objDiscussionSubContentEN.UpdDate = objRow[conDiscussionSubContent.UpdDate] == DBNull.Value ? null : objRow[conDiscussionSubContent.UpdDate].ToString().Trim(); //修改日期
objDiscussionSubContentEN.UpdUser = objRow[conDiscussionSubContent.UpdUser] == DBNull.Value ? null : objRow[conDiscussionSubContent.UpdUser].ToString().Trim(); //修改人
objDiscussionSubContentEN.Memo = objRow[conDiscussionSubContent.Memo] == DBNull.Value ? null : objRow[conDiscussionSubContent.Memo].ToString().Trim(); //备注
objDiscussionSubContentEN.ParentId = objRow[conDiscussionSubContent.ParentId] == DBNull.Value ? null : objRow[conDiscussionSubContent.ParentId].ToString().Trim(); //父节点Id
objDiscussionSubContentEN.UserId = objRow[conDiscussionSubContent.UserId] == DBNull.Value ? null : objRow[conDiscussionSubContent.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDiscussionSubContentEN.SubContentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDiscussionSubContentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrSubContentIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsDiscussionSubContentEN> GetObjLstBySubContentIdLstCache(List<string> arrSubContentIdLst)
{
string strKey = string.Format("{0}", clsDiscussionSubContentEN._CurrTabName);
List<clsDiscussionSubContentEN> arrDiscussionSubContentObjLstCache = GetObjLstCache();
IEnumerable <clsDiscussionSubContentEN> arrDiscussionSubContentObjLst_Sel =
arrDiscussionSubContentObjLstCache
.Where(x => arrSubContentIdLst.Contains(x.SubContentId));
return arrDiscussionSubContentObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsDiscussionSubContentEN> GetObjLst(string strWhereCond)
{
List<clsDiscussionSubContentEN> arrObjLst = new List<clsDiscussionSubContentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDiscussionSubContentEN objDiscussionSubContentEN = new clsDiscussionSubContentEN();
try
{
objDiscussionSubContentEN.SubContentId = objRow[conDiscussionSubContent.SubContentId].ToString().Trim(); //子内容Id
objDiscussionSubContentEN.SubContent = objRow[conDiscussionSubContent.SubContent] == DBNull.Value ? null : objRow[conDiscussionSubContent.SubContent].ToString().Trim(); //子内容
objDiscussionSubContentEN.TopicsId = objRow[conDiscussionSubContent.TopicsId] == DBNull.Value ? null : objRow[conDiscussionSubContent.TopicsId].ToString().Trim(); //主题Id
objDiscussionSubContentEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[conDiscussionSubContent.IsTop].ToString().Trim()); //是否置顶
objDiscussionSubContentEN.UpdDate = objRow[conDiscussionSubContent.UpdDate] == DBNull.Value ? null : objRow[conDiscussionSubContent.UpdDate].ToString().Trim(); //修改日期
objDiscussionSubContentEN.UpdUser = objRow[conDiscussionSubContent.UpdUser] == DBNull.Value ? null : objRow[conDiscussionSubContent.UpdUser].ToString().Trim(); //修改人
objDiscussionSubContentEN.Memo = objRow[conDiscussionSubContent.Memo] == DBNull.Value ? null : objRow[conDiscussionSubContent.Memo].ToString().Trim(); //备注
objDiscussionSubContentEN.ParentId = objRow[conDiscussionSubContent.ParentId] == DBNull.Value ? null : objRow[conDiscussionSubContent.ParentId].ToString().Trim(); //父节点Id
objDiscussionSubContentEN.UserId = objRow[conDiscussionSubContent.UserId] == DBNull.Value ? null : objRow[conDiscussionSubContent.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDiscussionSubContentEN.SubContentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDiscussionSubContentEN);
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
public static List<clsDiscussionSubContentEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsDiscussionSubContentEN> arrObjLst = new List<clsDiscussionSubContentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDiscussionSubContentEN objDiscussionSubContentEN = new clsDiscussionSubContentEN();
try
{
objDiscussionSubContentEN.SubContentId = objRow[conDiscussionSubContent.SubContentId].ToString().Trim(); //子内容Id
objDiscussionSubContentEN.SubContent = objRow[conDiscussionSubContent.SubContent] == DBNull.Value ? null : objRow[conDiscussionSubContent.SubContent].ToString().Trim(); //子内容
objDiscussionSubContentEN.TopicsId = objRow[conDiscussionSubContent.TopicsId] == DBNull.Value ? null : objRow[conDiscussionSubContent.TopicsId].ToString().Trim(); //主题Id
objDiscussionSubContentEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[conDiscussionSubContent.IsTop].ToString().Trim()); //是否置顶
objDiscussionSubContentEN.UpdDate = objRow[conDiscussionSubContent.UpdDate] == DBNull.Value ? null : objRow[conDiscussionSubContent.UpdDate].ToString().Trim(); //修改日期
objDiscussionSubContentEN.UpdUser = objRow[conDiscussionSubContent.UpdUser] == DBNull.Value ? null : objRow[conDiscussionSubContent.UpdUser].ToString().Trim(); //修改人
objDiscussionSubContentEN.Memo = objRow[conDiscussionSubContent.Memo] == DBNull.Value ? null : objRow[conDiscussionSubContent.Memo].ToString().Trim(); //备注
objDiscussionSubContentEN.ParentId = objRow[conDiscussionSubContent.ParentId] == DBNull.Value ? null : objRow[conDiscussionSubContent.ParentId].ToString().Trim(); //父节点Id
objDiscussionSubContentEN.UserId = objRow[conDiscussionSubContent.UserId] == DBNull.Value ? null : objRow[conDiscussionSubContent.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDiscussionSubContentEN.SubContentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDiscussionSubContentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objDiscussionSubContentCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsDiscussionSubContentEN> GetSubObjLstCache(clsDiscussionSubContentEN objDiscussionSubContentCond)
{
List<clsDiscussionSubContentEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsDiscussionSubContentEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conDiscussionSubContent.AttributeName)
{
if (objDiscussionSubContentCond.IsUpdated(strFldName) == false) continue;
if (objDiscussionSubContentCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDiscussionSubContentCond[strFldName].ToString());
}
else
{
if (objDiscussionSubContentCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objDiscussionSubContentCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDiscussionSubContentCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objDiscussionSubContentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objDiscussionSubContentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objDiscussionSubContentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objDiscussionSubContentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objDiscussionSubContentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objDiscussionSubContentCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objDiscussionSubContentCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objDiscussionSubContentCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objDiscussionSubContentCond[strFldName]));
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
public static List<clsDiscussionSubContentEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsDiscussionSubContentEN> arrObjLst = new List<clsDiscussionSubContentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDiscussionSubContentEN objDiscussionSubContentEN = new clsDiscussionSubContentEN();
try
{
objDiscussionSubContentEN.SubContentId = objRow[conDiscussionSubContent.SubContentId].ToString().Trim(); //子内容Id
objDiscussionSubContentEN.SubContent = objRow[conDiscussionSubContent.SubContent] == DBNull.Value ? null : objRow[conDiscussionSubContent.SubContent].ToString().Trim(); //子内容
objDiscussionSubContentEN.TopicsId = objRow[conDiscussionSubContent.TopicsId] == DBNull.Value ? null : objRow[conDiscussionSubContent.TopicsId].ToString().Trim(); //主题Id
objDiscussionSubContentEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[conDiscussionSubContent.IsTop].ToString().Trim()); //是否置顶
objDiscussionSubContentEN.UpdDate = objRow[conDiscussionSubContent.UpdDate] == DBNull.Value ? null : objRow[conDiscussionSubContent.UpdDate].ToString().Trim(); //修改日期
objDiscussionSubContentEN.UpdUser = objRow[conDiscussionSubContent.UpdUser] == DBNull.Value ? null : objRow[conDiscussionSubContent.UpdUser].ToString().Trim(); //修改人
objDiscussionSubContentEN.Memo = objRow[conDiscussionSubContent.Memo] == DBNull.Value ? null : objRow[conDiscussionSubContent.Memo].ToString().Trim(); //备注
objDiscussionSubContentEN.ParentId = objRow[conDiscussionSubContent.ParentId] == DBNull.Value ? null : objRow[conDiscussionSubContent.ParentId].ToString().Trim(); //父节点Id
objDiscussionSubContentEN.UserId = objRow[conDiscussionSubContent.UserId] == DBNull.Value ? null : objRow[conDiscussionSubContent.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDiscussionSubContentEN.SubContentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDiscussionSubContentEN);
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
public static List<clsDiscussionSubContentEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsDiscussionSubContentEN> arrObjLst = new List<clsDiscussionSubContentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDiscussionSubContentEN objDiscussionSubContentEN = new clsDiscussionSubContentEN();
try
{
objDiscussionSubContentEN.SubContentId = objRow[conDiscussionSubContent.SubContentId].ToString().Trim(); //子内容Id
objDiscussionSubContentEN.SubContent = objRow[conDiscussionSubContent.SubContent] == DBNull.Value ? null : objRow[conDiscussionSubContent.SubContent].ToString().Trim(); //子内容
objDiscussionSubContentEN.TopicsId = objRow[conDiscussionSubContent.TopicsId] == DBNull.Value ? null : objRow[conDiscussionSubContent.TopicsId].ToString().Trim(); //主题Id
objDiscussionSubContentEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[conDiscussionSubContent.IsTop].ToString().Trim()); //是否置顶
objDiscussionSubContentEN.UpdDate = objRow[conDiscussionSubContent.UpdDate] == DBNull.Value ? null : objRow[conDiscussionSubContent.UpdDate].ToString().Trim(); //修改日期
objDiscussionSubContentEN.UpdUser = objRow[conDiscussionSubContent.UpdUser] == DBNull.Value ? null : objRow[conDiscussionSubContent.UpdUser].ToString().Trim(); //修改人
objDiscussionSubContentEN.Memo = objRow[conDiscussionSubContent.Memo] == DBNull.Value ? null : objRow[conDiscussionSubContent.Memo].ToString().Trim(); //备注
objDiscussionSubContentEN.ParentId = objRow[conDiscussionSubContent.ParentId] == DBNull.Value ? null : objRow[conDiscussionSubContent.ParentId].ToString().Trim(); //父节点Id
objDiscussionSubContentEN.UserId = objRow[conDiscussionSubContent.UserId] == DBNull.Value ? null : objRow[conDiscussionSubContent.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDiscussionSubContentEN.SubContentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDiscussionSubContentEN);
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
List<clsDiscussionSubContentEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsDiscussionSubContentEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsDiscussionSubContentEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsDiscussionSubContentEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsDiscussionSubContentEN> arrObjLst = new List<clsDiscussionSubContentEN>(); 
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
	clsDiscussionSubContentEN objDiscussionSubContentEN = new clsDiscussionSubContentEN();
try
{
objDiscussionSubContentEN.SubContentId = objRow[conDiscussionSubContent.SubContentId].ToString().Trim(); //子内容Id
objDiscussionSubContentEN.SubContent = objRow[conDiscussionSubContent.SubContent] == DBNull.Value ? null : objRow[conDiscussionSubContent.SubContent].ToString().Trim(); //子内容
objDiscussionSubContentEN.TopicsId = objRow[conDiscussionSubContent.TopicsId] == DBNull.Value ? null : objRow[conDiscussionSubContent.TopicsId].ToString().Trim(); //主题Id
objDiscussionSubContentEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[conDiscussionSubContent.IsTop].ToString().Trim()); //是否置顶
objDiscussionSubContentEN.UpdDate = objRow[conDiscussionSubContent.UpdDate] == DBNull.Value ? null : objRow[conDiscussionSubContent.UpdDate].ToString().Trim(); //修改日期
objDiscussionSubContentEN.UpdUser = objRow[conDiscussionSubContent.UpdUser] == DBNull.Value ? null : objRow[conDiscussionSubContent.UpdUser].ToString().Trim(); //修改人
objDiscussionSubContentEN.Memo = objRow[conDiscussionSubContent.Memo] == DBNull.Value ? null : objRow[conDiscussionSubContent.Memo].ToString().Trim(); //备注
objDiscussionSubContentEN.ParentId = objRow[conDiscussionSubContent.ParentId] == DBNull.Value ? null : objRow[conDiscussionSubContent.ParentId].ToString().Trim(); //父节点Id
objDiscussionSubContentEN.UserId = objRow[conDiscussionSubContent.UserId] == DBNull.Value ? null : objRow[conDiscussionSubContent.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDiscussionSubContentEN.SubContentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDiscussionSubContentEN);
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
public static List<clsDiscussionSubContentEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsDiscussionSubContentEN> arrObjLst = new List<clsDiscussionSubContentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDiscussionSubContentEN objDiscussionSubContentEN = new clsDiscussionSubContentEN();
try
{
objDiscussionSubContentEN.SubContentId = objRow[conDiscussionSubContent.SubContentId].ToString().Trim(); //子内容Id
objDiscussionSubContentEN.SubContent = objRow[conDiscussionSubContent.SubContent] == DBNull.Value ? null : objRow[conDiscussionSubContent.SubContent].ToString().Trim(); //子内容
objDiscussionSubContentEN.TopicsId = objRow[conDiscussionSubContent.TopicsId] == DBNull.Value ? null : objRow[conDiscussionSubContent.TopicsId].ToString().Trim(); //主题Id
objDiscussionSubContentEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[conDiscussionSubContent.IsTop].ToString().Trim()); //是否置顶
objDiscussionSubContentEN.UpdDate = objRow[conDiscussionSubContent.UpdDate] == DBNull.Value ? null : objRow[conDiscussionSubContent.UpdDate].ToString().Trim(); //修改日期
objDiscussionSubContentEN.UpdUser = objRow[conDiscussionSubContent.UpdUser] == DBNull.Value ? null : objRow[conDiscussionSubContent.UpdUser].ToString().Trim(); //修改人
objDiscussionSubContentEN.Memo = objRow[conDiscussionSubContent.Memo] == DBNull.Value ? null : objRow[conDiscussionSubContent.Memo].ToString().Trim(); //备注
objDiscussionSubContentEN.ParentId = objRow[conDiscussionSubContent.ParentId] == DBNull.Value ? null : objRow[conDiscussionSubContent.ParentId].ToString().Trim(); //父节点Id
objDiscussionSubContentEN.UserId = objRow[conDiscussionSubContent.UserId] == DBNull.Value ? null : objRow[conDiscussionSubContent.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDiscussionSubContentEN.SubContentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDiscussionSubContentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsDiscussionSubContentEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsDiscussionSubContentEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsDiscussionSubContentEN> arrObjLst = new List<clsDiscussionSubContentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDiscussionSubContentEN objDiscussionSubContentEN = new clsDiscussionSubContentEN();
try
{
objDiscussionSubContentEN.SubContentId = objRow[conDiscussionSubContent.SubContentId].ToString().Trim(); //子内容Id
objDiscussionSubContentEN.SubContent = objRow[conDiscussionSubContent.SubContent] == DBNull.Value ? null : objRow[conDiscussionSubContent.SubContent].ToString().Trim(); //子内容
objDiscussionSubContentEN.TopicsId = objRow[conDiscussionSubContent.TopicsId] == DBNull.Value ? null : objRow[conDiscussionSubContent.TopicsId].ToString().Trim(); //主题Id
objDiscussionSubContentEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[conDiscussionSubContent.IsTop].ToString().Trim()); //是否置顶
objDiscussionSubContentEN.UpdDate = objRow[conDiscussionSubContent.UpdDate] == DBNull.Value ? null : objRow[conDiscussionSubContent.UpdDate].ToString().Trim(); //修改日期
objDiscussionSubContentEN.UpdUser = objRow[conDiscussionSubContent.UpdUser] == DBNull.Value ? null : objRow[conDiscussionSubContent.UpdUser].ToString().Trim(); //修改人
objDiscussionSubContentEN.Memo = objRow[conDiscussionSubContent.Memo] == DBNull.Value ? null : objRow[conDiscussionSubContent.Memo].ToString().Trim(); //备注
objDiscussionSubContentEN.ParentId = objRow[conDiscussionSubContent.ParentId] == DBNull.Value ? null : objRow[conDiscussionSubContent.ParentId].ToString().Trim(); //父节点Id
objDiscussionSubContentEN.UserId = objRow[conDiscussionSubContent.UserId] == DBNull.Value ? null : objRow[conDiscussionSubContent.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDiscussionSubContentEN.SubContentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDiscussionSubContentEN);
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
public static List<clsDiscussionSubContentEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsDiscussionSubContentEN> arrObjLst = new List<clsDiscussionSubContentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDiscussionSubContentEN objDiscussionSubContentEN = new clsDiscussionSubContentEN();
try
{
objDiscussionSubContentEN.SubContentId = objRow[conDiscussionSubContent.SubContentId].ToString().Trim(); //子内容Id
objDiscussionSubContentEN.SubContent = objRow[conDiscussionSubContent.SubContent] == DBNull.Value ? null : objRow[conDiscussionSubContent.SubContent].ToString().Trim(); //子内容
objDiscussionSubContentEN.TopicsId = objRow[conDiscussionSubContent.TopicsId] == DBNull.Value ? null : objRow[conDiscussionSubContent.TopicsId].ToString().Trim(); //主题Id
objDiscussionSubContentEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[conDiscussionSubContent.IsTop].ToString().Trim()); //是否置顶
objDiscussionSubContentEN.UpdDate = objRow[conDiscussionSubContent.UpdDate] == DBNull.Value ? null : objRow[conDiscussionSubContent.UpdDate].ToString().Trim(); //修改日期
objDiscussionSubContentEN.UpdUser = objRow[conDiscussionSubContent.UpdUser] == DBNull.Value ? null : objRow[conDiscussionSubContent.UpdUser].ToString().Trim(); //修改人
objDiscussionSubContentEN.Memo = objRow[conDiscussionSubContent.Memo] == DBNull.Value ? null : objRow[conDiscussionSubContent.Memo].ToString().Trim(); //备注
objDiscussionSubContentEN.ParentId = objRow[conDiscussionSubContent.ParentId] == DBNull.Value ? null : objRow[conDiscussionSubContent.ParentId].ToString().Trim(); //父节点Id
objDiscussionSubContentEN.UserId = objRow[conDiscussionSubContent.UserId] == DBNull.Value ? null : objRow[conDiscussionSubContent.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDiscussionSubContentEN.SubContentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDiscussionSubContentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsDiscussionSubContentEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsDiscussionSubContentEN> arrObjLst = new List<clsDiscussionSubContentEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDiscussionSubContentEN objDiscussionSubContentEN = new clsDiscussionSubContentEN();
try
{
objDiscussionSubContentEN.SubContentId = objRow[conDiscussionSubContent.SubContentId].ToString().Trim(); //子内容Id
objDiscussionSubContentEN.SubContent = objRow[conDiscussionSubContent.SubContent] == DBNull.Value ? null : objRow[conDiscussionSubContent.SubContent].ToString().Trim(); //子内容
objDiscussionSubContentEN.TopicsId = objRow[conDiscussionSubContent.TopicsId] == DBNull.Value ? null : objRow[conDiscussionSubContent.TopicsId].ToString().Trim(); //主题Id
objDiscussionSubContentEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[conDiscussionSubContent.IsTop].ToString().Trim()); //是否置顶
objDiscussionSubContentEN.UpdDate = objRow[conDiscussionSubContent.UpdDate] == DBNull.Value ? null : objRow[conDiscussionSubContent.UpdDate].ToString().Trim(); //修改日期
objDiscussionSubContentEN.UpdUser = objRow[conDiscussionSubContent.UpdUser] == DBNull.Value ? null : objRow[conDiscussionSubContent.UpdUser].ToString().Trim(); //修改人
objDiscussionSubContentEN.Memo = objRow[conDiscussionSubContent.Memo] == DBNull.Value ? null : objRow[conDiscussionSubContent.Memo].ToString().Trim(); //备注
objDiscussionSubContentEN.ParentId = objRow[conDiscussionSubContent.ParentId] == DBNull.Value ? null : objRow[conDiscussionSubContent.ParentId].ToString().Trim(); //父节点Id
objDiscussionSubContentEN.UserId = objRow[conDiscussionSubContent.UserId] == DBNull.Value ? null : objRow[conDiscussionSubContent.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDiscussionSubContentEN.SubContentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDiscussionSubContentEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objDiscussionSubContentEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetDiscussionSubContent(ref clsDiscussionSubContentEN objDiscussionSubContentEN)
{
bool bolResult = DiscussionSubContentDA.GetDiscussionSubContent(ref objDiscussionSubContentEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strSubContentId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDiscussionSubContentEN GetObjBySubContentId(string strSubContentId)
{
if (strSubContentId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strSubContentId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strSubContentId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strSubContentId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsDiscussionSubContentEN objDiscussionSubContentEN = DiscussionSubContentDA.GetObjBySubContentId(strSubContentId);
return objDiscussionSubContentEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsDiscussionSubContentEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsDiscussionSubContentEN objDiscussionSubContentEN = DiscussionSubContentDA.GetFirstObj(strWhereCond);
 return objDiscussionSubContentEN;
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
public static clsDiscussionSubContentEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsDiscussionSubContentEN objDiscussionSubContentEN = DiscussionSubContentDA.GetObjByDataRow(objRow);
 return objDiscussionSubContentEN;
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
public static clsDiscussionSubContentEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsDiscussionSubContentEN objDiscussionSubContentEN = DiscussionSubContentDA.GetObjByDataRow(objRow);
 return objDiscussionSubContentEN;
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
 /// <param name = "strSubContentId">所给的关键字</param>
 /// <param name = "lstDiscussionSubContentObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDiscussionSubContentEN GetObjBySubContentIdFromList(string strSubContentId, List<clsDiscussionSubContentEN> lstDiscussionSubContentObjLst)
{
foreach (clsDiscussionSubContentEN objDiscussionSubContentEN in lstDiscussionSubContentObjLst)
{
if (objDiscussionSubContentEN.SubContentId == strSubContentId)
{
return objDiscussionSubContentEN;
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
 string strMaxSubContentId;
 try
 {
 strMaxSubContentId = clsDiscussionSubContentDA.GetMaxStrId();
 return strMaxSubContentId;
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
 string strSubContentId;
 try
 {
 strSubContentId = new clsDiscussionSubContentDA().GetFirstID(strWhereCond);
 return strSubContentId;
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
 arrList = DiscussionSubContentDA.GetID(strWhereCond);
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
bool bolIsExist = DiscussionSubContentDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strSubContentId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strSubContentId)
{
if (string.IsNullOrEmpty(strSubContentId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strSubContentId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = DiscussionSubContentDA.IsExist(strSubContentId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strSubContentId">子内容Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strSubContentId, string strOpUser)
{
clsDiscussionSubContentEN objDiscussionSubContentEN = clsDiscussionSubContentBL.GetObjBySubContentId(strSubContentId);
objDiscussionSubContentEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objDiscussionSubContentEN.UpdUser = strOpUser;
return clsDiscussionSubContentBL.UpdateBySql2(objDiscussionSubContentEN);
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
 bolIsExist = clsDiscussionSubContentDA.IsExistTable();
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
 bolIsExist = DiscussionSubContentDA.IsExistTable(strTabName);
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
 /// <param name = "objDiscussionSubContentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsDiscussionSubContentEN objDiscussionSubContentEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objDiscussionSubContentEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!子内容 = [{0}],主题Id = [{1}]的数据已经存在!(in clsDiscussionSubContentBL.AddNewRecordBySql2)", objDiscussionSubContentEN.SubContent,objDiscussionSubContentEN.TopicsId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objDiscussionSubContentEN.SubContentId) == true || clsDiscussionSubContentBL.IsExist(objDiscussionSubContentEN.SubContentId) == true)
 {
     objDiscussionSubContentEN.SubContentId = clsDiscussionSubContentBL.GetMaxStrId_S();
 }
bool bolResult = DiscussionSubContentDA.AddNewRecordBySQL2(objDiscussionSubContentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDiscussionSubContentBL.ReFreshCache();

if (clsDiscussionSubContentBL.relatedActions != null)
{
clsDiscussionSubContentBL.relatedActions.UpdRelaTabDate(objDiscussionSubContentEN.SubContentId, objDiscussionSubContentEN.UpdUser);
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
 /// <param name = "objDiscussionSubContentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsDiscussionSubContentEN objDiscussionSubContentEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objDiscussionSubContentEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!子内容 = [{0}],主题Id = [{1}]的数据已经存在!(in clsDiscussionSubContentBL.AddNewRecordBySql2WithReturnKey)", objDiscussionSubContentEN.SubContent,objDiscussionSubContentEN.TopicsId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objDiscussionSubContentEN.SubContentId) == true || clsDiscussionSubContentBL.IsExist(objDiscussionSubContentEN.SubContentId) == true)
 {
     objDiscussionSubContentEN.SubContentId = clsDiscussionSubContentBL.GetMaxStrId_S();
 }
string strKey = DiscussionSubContentDA.AddNewRecordBySQL2WithReturnKey(objDiscussionSubContentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDiscussionSubContentBL.ReFreshCache();

if (clsDiscussionSubContentBL.relatedActions != null)
{
clsDiscussionSubContentBL.relatedActions.UpdRelaTabDate(objDiscussionSubContentEN.SubContentId, objDiscussionSubContentEN.UpdUser);
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
 /// <param name = "objDiscussionSubContentEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsDiscussionSubContentEN objDiscussionSubContentEN)
{
try
{
bool bolResult = DiscussionSubContentDA.Update(objDiscussionSubContentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDiscussionSubContentBL.ReFreshCache();

if (clsDiscussionSubContentBL.relatedActions != null)
{
clsDiscussionSubContentBL.relatedActions.UpdRelaTabDate(objDiscussionSubContentEN.SubContentId, objDiscussionSubContentEN.UpdUser);
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
 /// <param name = "objDiscussionSubContentEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsDiscussionSubContentEN objDiscussionSubContentEN)
{
 if (string.IsNullOrEmpty(objDiscussionSubContentEN.SubContentId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = DiscussionSubContentDA.UpdateBySql2(objDiscussionSubContentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDiscussionSubContentBL.ReFreshCache();

if (clsDiscussionSubContentBL.relatedActions != null)
{
clsDiscussionSubContentBL.relatedActions.UpdRelaTabDate(objDiscussionSubContentEN.SubContentId, objDiscussionSubContentEN.UpdUser);
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
 /// <param name = "strSubContentId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strSubContentId)
{
try
{
 clsDiscussionSubContentEN objDiscussionSubContentEN = clsDiscussionSubContentBL.GetObjBySubContentId(strSubContentId);

if (clsDiscussionSubContentBL.relatedActions != null)
{
clsDiscussionSubContentBL.relatedActions.UpdRelaTabDate(objDiscussionSubContentEN.SubContentId, objDiscussionSubContentEN.UpdUser);
}
if (objDiscussionSubContentEN != null)
{
int intRecNum = DiscussionSubContentDA.DelRecord(strSubContentId);
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
/// <param name="strSubContentId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strSubContentId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsDiscussionSubContentDA.GetSpecSQLObj();
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
//删除与表:[DiscussionSubContent]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conDiscussionSubContent.SubContentId,
//strSubContentId);
//        clsDiscussionSubContentBL.DelDiscussionSubContentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsDiscussionSubContentBL.DelRecord(strSubContentId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsDiscussionSubContentBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strSubContentId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strSubContentId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strSubContentId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsDiscussionSubContentBL.relatedActions != null)
{
clsDiscussionSubContentBL.relatedActions.UpdRelaTabDate(strSubContentId, "UpdRelaTabDate");
}
bool bolResult = DiscussionSubContentDA.DelRecord(strSubContentId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrSubContentIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelDiscussionSubContents(List<string> arrSubContentIdLst)
{
if (arrSubContentIdLst.Count == 0) return 0;
try
{
if (clsDiscussionSubContentBL.relatedActions != null)
{
foreach (var strSubContentId in arrSubContentIdLst)
{
clsDiscussionSubContentBL.relatedActions.UpdRelaTabDate(strSubContentId, "UpdRelaTabDate");
}
}
int intDelRecNum = DiscussionSubContentDA.DelDiscussionSubContent(arrSubContentIdLst);
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
public static int DelDiscussionSubContentsByCond(string strWhereCond)
{
try
{
if (clsDiscussionSubContentBL.relatedActions != null)
{
List<string> arrSubContentId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strSubContentId in arrSubContentId)
{
clsDiscussionSubContentBL.relatedActions.UpdRelaTabDate(strSubContentId, "UpdRelaTabDate");
}
}
int intRecNum = DiscussionSubContentDA.DelDiscussionSubContent(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[DiscussionSubContent]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strSubContentId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strSubContentId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsDiscussionSubContentDA.GetSpecSQLObj();
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
//删除与表:[DiscussionSubContent]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsDiscussionSubContentBL.DelRecord(strSubContentId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsDiscussionSubContentBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strSubContentId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objDiscussionSubContentENS">源对象</param>
 /// <param name = "objDiscussionSubContentENT">目标对象</param>
 public static void CopyTo(clsDiscussionSubContentEN objDiscussionSubContentENS, clsDiscussionSubContentEN objDiscussionSubContentENT)
{
try
{
objDiscussionSubContentENT.SubContentId = objDiscussionSubContentENS.SubContentId; //子内容Id
objDiscussionSubContentENT.SubContent = objDiscussionSubContentENS.SubContent; //子内容
objDiscussionSubContentENT.TopicsId = objDiscussionSubContentENS.TopicsId; //主题Id
objDiscussionSubContentENT.IsTop = objDiscussionSubContentENS.IsTop; //是否置顶
objDiscussionSubContentENT.UpdDate = objDiscussionSubContentENS.UpdDate; //修改日期
objDiscussionSubContentENT.UpdUser = objDiscussionSubContentENS.UpdUser; //修改人
objDiscussionSubContentENT.Memo = objDiscussionSubContentENS.Memo; //备注
objDiscussionSubContentENT.ParentId = objDiscussionSubContentENS.ParentId; //父节点Id
objDiscussionSubContentENT.UserId = objDiscussionSubContentENS.UserId; //用户ID
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
 /// <param name = "objDiscussionSubContentEN">源简化对象</param>
 public static void SetUpdFlag(clsDiscussionSubContentEN objDiscussionSubContentEN)
{
try
{
objDiscussionSubContentEN.ClearUpdateState();
   string strsfUpdFldSetStr = objDiscussionSubContentEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conDiscussionSubContent.SubContentId, new clsStrCompareIgnoreCase())  ==  true)
{
objDiscussionSubContentEN.SubContentId = objDiscussionSubContentEN.SubContentId; //子内容Id
}
if (arrFldSet.Contains(conDiscussionSubContent.SubContent, new clsStrCompareIgnoreCase())  ==  true)
{
objDiscussionSubContentEN.SubContent = objDiscussionSubContentEN.SubContent == "[null]" ? null :  objDiscussionSubContentEN.SubContent; //子内容
}
if (arrFldSet.Contains(conDiscussionSubContent.TopicsId, new clsStrCompareIgnoreCase())  ==  true)
{
objDiscussionSubContentEN.TopicsId = objDiscussionSubContentEN.TopicsId == "[null]" ? null :  objDiscussionSubContentEN.TopicsId; //主题Id
}
if (arrFldSet.Contains(conDiscussionSubContent.IsTop, new clsStrCompareIgnoreCase())  ==  true)
{
objDiscussionSubContentEN.IsTop = objDiscussionSubContentEN.IsTop; //是否置顶
}
if (arrFldSet.Contains(conDiscussionSubContent.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objDiscussionSubContentEN.UpdDate = objDiscussionSubContentEN.UpdDate == "[null]" ? null :  objDiscussionSubContentEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conDiscussionSubContent.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objDiscussionSubContentEN.UpdUser = objDiscussionSubContentEN.UpdUser == "[null]" ? null :  objDiscussionSubContentEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conDiscussionSubContent.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objDiscussionSubContentEN.Memo = objDiscussionSubContentEN.Memo == "[null]" ? null :  objDiscussionSubContentEN.Memo; //备注
}
if (arrFldSet.Contains(conDiscussionSubContent.ParentId, new clsStrCompareIgnoreCase())  ==  true)
{
objDiscussionSubContentEN.ParentId = objDiscussionSubContentEN.ParentId == "[null]" ? null :  objDiscussionSubContentEN.ParentId; //父节点Id
}
if (arrFldSet.Contains(conDiscussionSubContent.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objDiscussionSubContentEN.UserId = objDiscussionSubContentEN.UserId == "[null]" ? null :  objDiscussionSubContentEN.UserId; //用户ID
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
 /// <param name = "objDiscussionSubContentEN">源简化对象</param>
 public static void AccessFldValueNull(clsDiscussionSubContentEN objDiscussionSubContentEN)
{
try
{
if (objDiscussionSubContentEN.SubContent == "[null]") objDiscussionSubContentEN.SubContent = null; //子内容
if (objDiscussionSubContentEN.TopicsId == "[null]") objDiscussionSubContentEN.TopicsId = null; //主题Id
if (objDiscussionSubContentEN.UpdDate == "[null]") objDiscussionSubContentEN.UpdDate = null; //修改日期
if (objDiscussionSubContentEN.UpdUser == "[null]") objDiscussionSubContentEN.UpdUser = null; //修改人
if (objDiscussionSubContentEN.Memo == "[null]") objDiscussionSubContentEN.Memo = null; //备注
if (objDiscussionSubContentEN.ParentId == "[null]") objDiscussionSubContentEN.ParentId = null; //父节点Id
if (objDiscussionSubContentEN.UserId == "[null]") objDiscussionSubContentEN.UserId = null; //用户ID
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
public static void CheckPropertyNew(clsDiscussionSubContentEN objDiscussionSubContentEN)
{
 DiscussionSubContentDA.CheckPropertyNew(objDiscussionSubContentEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsDiscussionSubContentEN objDiscussionSubContentEN)
{
 DiscussionSubContentDA.CheckProperty4Condition(objDiscussionSubContentEN);
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
if (clsDiscussionSubContentBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDiscussionSubContentBL没有刷新缓存机制(clsDiscussionSubContentBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by SubContentId");
//if (arrDiscussionSubContentObjLstCache == null)
//{
//arrDiscussionSubContentObjLstCache = DiscussionSubContentDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strSubContentId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDiscussionSubContentEN GetObjBySubContentIdCache(string strSubContentId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsDiscussionSubContentEN._CurrTabName);
List<clsDiscussionSubContentEN> arrDiscussionSubContentObjLstCache = GetObjLstCache();
IEnumerable <clsDiscussionSubContentEN> arrDiscussionSubContentObjLst_Sel =
arrDiscussionSubContentObjLstCache
.Where(x=> x.SubContentId == strSubContentId 
);
if (arrDiscussionSubContentObjLst_Sel.Count() == 0)
{
   clsDiscussionSubContentEN obj = clsDiscussionSubContentBL.GetObjBySubContentId(strSubContentId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrDiscussionSubContentObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDiscussionSubContentEN> GetAllDiscussionSubContentObjLstCache()
{
//获取缓存中的对象列表
List<clsDiscussionSubContentEN> arrDiscussionSubContentObjLstCache = GetObjLstCache(); 
return arrDiscussionSubContentObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDiscussionSubContentEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsDiscussionSubContentEN._CurrTabName);
List<clsDiscussionSubContentEN> arrDiscussionSubContentObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrDiscussionSubContentObjLstCache;
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
string strKey = string.Format("{0}", clsDiscussionSubContentEN._CurrTabName);
CacheHelper.Remove(strKey);
clsDiscussionSubContentEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsDiscussionSubContentEN._RefreshTimeLst.Count == 0) return "";
return clsDiscussionSubContentEN._RefreshTimeLst[clsDiscussionSubContentEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsDiscussionSubContentBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsDiscussionSubContentEN._CurrTabName);
CacheHelper.Remove(strKey);
clsDiscussionSubContentEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsDiscussionSubContentBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--DiscussionSubContent(讨论子内容)
 /// 唯一性条件:SubContent_TopicsId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objDiscussionSubContentEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsDiscussionSubContentEN objDiscussionSubContentEN)
{
//检测记录是否存在
string strResult = DiscussionSubContentDA.GetUniCondStr(objDiscussionSubContentEN);
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
public static string Func(string strInFldName, string strOutFldName, string strSubContentId)
{
if (strInFldName != conDiscussionSubContent.SubContentId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conDiscussionSubContent.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conDiscussionSubContent.AttributeName));
throw new Exception(strMsg);
}
var objDiscussionSubContent = clsDiscussionSubContentBL.GetObjBySubContentIdCache(strSubContentId);
if (objDiscussionSubContent == null) return "";
return objDiscussionSubContent[strOutFldName].ToString();
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
int intRecCount = clsDiscussionSubContentDA.GetRecCount(strTabName);
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
int intRecCount = clsDiscussionSubContentDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsDiscussionSubContentDA.GetRecCount();
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
int intRecCount = clsDiscussionSubContentDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objDiscussionSubContentCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsDiscussionSubContentEN objDiscussionSubContentCond)
{
List<clsDiscussionSubContentEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsDiscussionSubContentEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conDiscussionSubContent.AttributeName)
{
if (objDiscussionSubContentCond.IsUpdated(strFldName) == false) continue;
if (objDiscussionSubContentCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDiscussionSubContentCond[strFldName].ToString());
}
else
{
if (objDiscussionSubContentCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objDiscussionSubContentCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDiscussionSubContentCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objDiscussionSubContentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objDiscussionSubContentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objDiscussionSubContentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objDiscussionSubContentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objDiscussionSubContentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objDiscussionSubContentCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objDiscussionSubContentCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objDiscussionSubContentCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objDiscussionSubContentCond[strFldName]));
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
 List<string> arrList = clsDiscussionSubContentDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = DiscussionSubContentDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = DiscussionSubContentDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = DiscussionSubContentDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsDiscussionSubContentDA.SetFldValue(clsDiscussionSubContentEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = DiscussionSubContentDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsDiscussionSubContentDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsDiscussionSubContentDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsDiscussionSubContentDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[DiscussionSubContent] "); 
 strCreateTabCode.Append(" ( "); 
 // /**子内容Id*/ 
 strCreateTabCode.Append(" SubContentId char(10) primary key, "); 
 // /**子内容*/ 
 strCreateTabCode.Append(" SubContent text Null, "); 
 // /**主题Id*/ 
 strCreateTabCode.Append(" TopicsId char(8) Null, "); 
 // /**是否置顶*/ 
 strCreateTabCode.Append(" IsTop bit Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**父节点Id*/ 
 strCreateTabCode.Append(" ParentId char(10) Null, "); 
 // /**用户ID*/ 
 strCreateTabCode.Append(" UserId varchar(18) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 讨论子内容(DiscussionSubContent)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4DiscussionSubContent : clsCommFun4BL
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
clsDiscussionSubContentBL.ReFreshThisCache();
}
}

}