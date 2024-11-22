
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_ViewpointBL
 表名:zx_Viewpoint(01120705)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:56:13
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学生课件管理(ZXCourseware)
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
public static class  clszx_ViewpointBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strzxViewpointId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_ViewpointEN GetObj(this K_zxViewpointId_zx_Viewpoint myKey)
{
clszx_ViewpointEN objzx_ViewpointEN = clszx_ViewpointBL.zx_ViewpointDA.GetObjByzxViewpointId(myKey.Value);
return objzx_ViewpointEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objzx_ViewpointEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clszx_ViewpointEN objzx_ViewpointEN)
{
if (CheckUniqueness(objzx_ViewpointEN) == false)
{
var strMsg = string.Format("记录已经存在!观点Id = [{0}],课件Id = [{1}]的数据已经存在!(in clszx_ViewpointBL.AddNewRecord)", objzx_ViewpointEN.zxViewpointId,objzx_ViewpointEN.TextId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_ViewpointEN.zxViewpointId) == true || clszx_ViewpointBL.IsExist(objzx_ViewpointEN.zxViewpointId) == true)
 {
     objzx_ViewpointEN.zxViewpointId = clszx_ViewpointBL.GetMaxStrId_S();
 }
bool bolResult = clszx_ViewpointBL.zx_ViewpointDA.AddNewRecordBySQL2(objzx_ViewpointEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewpointBL.ReFreshCache(objzx_ViewpointEN.IdCurrEduCls);

if (clszx_ViewpointBL.relatedActions != null)
{
clszx_ViewpointBL.relatedActions.UpdRelaTabDate(objzx_ViewpointEN.zxViewpointId, "SetUpdDate");
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
public static bool AddRecordEx(this clszx_ViewpointEN objzx_ViewpointEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clszx_ViewpointBL.IsExist(objzx_ViewpointEN.zxViewpointId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objzx_ViewpointEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objzx_ViewpointEN.CheckUniqueness() == false)
{
strMsg = string.Format("(观点Id(zxViewpointId)=[{0}],课件Id(TextId)=[{1}])已经存在,不能重复!", objzx_ViewpointEN.zxViewpointId, objzx_ViewpointEN.TextId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objzx_ViewpointEN.zxViewpointId) == true || clszx_ViewpointBL.IsExist(objzx_ViewpointEN.zxViewpointId) == true)
 {
     objzx_ViewpointEN.zxViewpointId = clszx_ViewpointBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objzx_ViewpointEN.AddNewRecord();
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
 /// <param name = "objzx_ViewpointEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clszx_ViewpointEN objzx_ViewpointEN)
{
if (CheckUniqueness(objzx_ViewpointEN) == false)
{
var strMsg = string.Format("记录已经存在!观点Id = [{0}],课件Id = [{1}]的数据已经存在!(in clszx_ViewpointBL.AddNewRecordWithMaxId)", objzx_ViewpointEN.zxViewpointId,objzx_ViewpointEN.TextId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_ViewpointEN.zxViewpointId) == true || clszx_ViewpointBL.IsExist(objzx_ViewpointEN.zxViewpointId) == true)
 {
     objzx_ViewpointEN.zxViewpointId = clszx_ViewpointBL.GetMaxStrId_S();
 }
string strzxViewpointId = clszx_ViewpointBL.zx_ViewpointDA.AddNewRecordBySQL2WithReturnKey(objzx_ViewpointEN);
     objzx_ViewpointEN.zxViewpointId = strzxViewpointId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewpointBL.ReFreshCache(objzx_ViewpointEN.IdCurrEduCls);

if (clszx_ViewpointBL.relatedActions != null)
{
clszx_ViewpointBL.relatedActions.UpdRelaTabDate(objzx_ViewpointEN.zxViewpointId, "SetUpdDate");
}
return strzxViewpointId;
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
 /// <param name = "objzx_ViewpointEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clszx_ViewpointEN objzx_ViewpointEN)
{
if (CheckUniqueness(objzx_ViewpointEN) == false)
{
var strMsg = string.Format("记录已经存在!观点Id = [{0}],课件Id = [{1}]的数据已经存在!(in clszx_ViewpointBL.AddNewRecordWithReturnKey)", objzx_ViewpointEN.zxViewpointId,objzx_ViewpointEN.TextId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_ViewpointEN.zxViewpointId) == true || clszx_ViewpointBL.IsExist(objzx_ViewpointEN.zxViewpointId) == true)
 {
     objzx_ViewpointEN.zxViewpointId = clszx_ViewpointBL.GetMaxStrId_S();
 }
string strKey = clszx_ViewpointBL.zx_ViewpointDA.AddNewRecordBySQL2WithReturnKey(objzx_ViewpointEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewpointBL.ReFreshCache(objzx_ViewpointEN.IdCurrEduCls);

if (clszx_ViewpointBL.relatedActions != null)
{
clszx_ViewpointBL.relatedActions.UpdRelaTabDate(objzx_ViewpointEN.zxViewpointId, "SetUpdDate");
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
 /// <param name = "objzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointEN SetzxViewpointId(this clszx_ViewpointEN objzx_ViewpointEN, string strzxViewpointId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxViewpointId, 8, conzx_Viewpoint.zxViewpointId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxViewpointId, 8, conzx_Viewpoint.zxViewpointId);
}
objzx_ViewpointEN.zxViewpointId = strzxViewpointId; //观点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointEN.dicFldComparisonOp.ContainsKey(conzx_Viewpoint.zxViewpointId) == false)
{
objzx_ViewpointEN.dicFldComparisonOp.Add(conzx_Viewpoint.zxViewpointId, strComparisonOp);
}
else
{
objzx_ViewpointEN.dicFldComparisonOp[conzx_Viewpoint.zxViewpointId] = strComparisonOp;
}
}
return objzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointEN SetViewpointName(this clszx_ViewpointEN objzx_ViewpointEN, string strViewpointName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewpointName, 500, conzx_Viewpoint.ViewpointName);
}
objzx_ViewpointEN.ViewpointName = strViewpointName; //观点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointEN.dicFldComparisonOp.ContainsKey(conzx_Viewpoint.ViewpointName) == false)
{
objzx_ViewpointEN.dicFldComparisonOp.Add(conzx_Viewpoint.ViewpointName, strComparisonOp);
}
else
{
objzx_ViewpointEN.dicFldComparisonOp[conzx_Viewpoint.ViewpointName] = strComparisonOp;
}
}
return objzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointEN SetViewpointContent(this clszx_ViewpointEN objzx_ViewpointEN, string strViewpointContent, string strComparisonOp="")
	{
objzx_ViewpointEN.ViewpointContent = strViewpointContent; //观点内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointEN.dicFldComparisonOp.ContainsKey(conzx_Viewpoint.ViewpointContent) == false)
{
objzx_ViewpointEN.dicFldComparisonOp.Add(conzx_Viewpoint.ViewpointContent, strComparisonOp);
}
else
{
objzx_ViewpointEN.dicFldComparisonOp[conzx_Viewpoint.ViewpointContent] = strComparisonOp;
}
}
return objzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointEN SetzxViewpointTypeId(this clszx_ViewpointEN objzx_ViewpointEN, string strzxViewpointTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxViewpointTypeId, 4, conzx_Viewpoint.zxViewpointTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxViewpointTypeId, 4, conzx_Viewpoint.zxViewpointTypeId);
}
objzx_ViewpointEN.zxViewpointTypeId = strzxViewpointTypeId; //观点类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointEN.dicFldComparisonOp.ContainsKey(conzx_Viewpoint.zxViewpointTypeId) == false)
{
objzx_ViewpointEN.dicFldComparisonOp.Add(conzx_Viewpoint.zxViewpointTypeId, strComparisonOp);
}
else
{
objzx_ViewpointEN.dicFldComparisonOp[conzx_Viewpoint.zxViewpointTypeId] = strComparisonOp;
}
}
return objzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointEN SetReason(this clszx_ViewpointEN objzx_ViewpointEN, string strReason, string strComparisonOp="")
	{
objzx_ViewpointEN.Reason = strReason; //理由
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointEN.dicFldComparisonOp.ContainsKey(conzx_Viewpoint.Reason) == false)
{
objzx_ViewpointEN.dicFldComparisonOp.Add(conzx_Viewpoint.Reason, strComparisonOp);
}
else
{
objzx_ViewpointEN.dicFldComparisonOp[conzx_Viewpoint.Reason] = strComparisonOp;
}
}
return objzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointEN SetSource(this clszx_ViewpointEN objzx_ViewpointEN, string strSource, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSource, 500, conzx_Viewpoint.Source);
}
objzx_ViewpointEN.Source = strSource; //来源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointEN.dicFldComparisonOp.ContainsKey(conzx_Viewpoint.Source) == false)
{
objzx_ViewpointEN.dicFldComparisonOp.Add(conzx_Viewpoint.Source, strComparisonOp);
}
else
{
objzx_ViewpointEN.dicFldComparisonOp[conzx_Viewpoint.Source] = strComparisonOp;
}
}
return objzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointEN SetVPProposePeople(this clszx_ViewpointEN objzx_ViewpointEN, string strVPProposePeople, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVPProposePeople, 50, conzx_Viewpoint.VPProposePeople);
}
objzx_ViewpointEN.VPProposePeople = strVPProposePeople; //观点提出人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointEN.dicFldComparisonOp.ContainsKey(conzx_Viewpoint.VPProposePeople) == false)
{
objzx_ViewpointEN.dicFldComparisonOp.Add(conzx_Viewpoint.VPProposePeople, strComparisonOp);
}
else
{
objzx_ViewpointEN.dicFldComparisonOp[conzx_Viewpoint.VPProposePeople] = strComparisonOp;
}
}
return objzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointEN SetIsSubmit(this clszx_ViewpointEN objzx_ViewpointEN, bool bolIsSubmit, string strComparisonOp="")
	{
objzx_ViewpointEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointEN.dicFldComparisonOp.ContainsKey(conzx_Viewpoint.IsSubmit) == false)
{
objzx_ViewpointEN.dicFldComparisonOp.Add(conzx_Viewpoint.IsSubmit, strComparisonOp);
}
else
{
objzx_ViewpointEN.dicFldComparisonOp[conzx_Viewpoint.IsSubmit] = strComparisonOp;
}
}
return objzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointEN SetUserTypeId(this clszx_ViewpointEN objzx_ViewpointEN, string strUserTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, conzx_Viewpoint.UserTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, conzx_Viewpoint.UserTypeId);
}
objzx_ViewpointEN.UserTypeId = strUserTypeId; //用户类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointEN.dicFldComparisonOp.ContainsKey(conzx_Viewpoint.UserTypeId) == false)
{
objzx_ViewpointEN.dicFldComparisonOp.Add(conzx_Viewpoint.UserTypeId, strComparisonOp);
}
else
{
objzx_ViewpointEN.dicFldComparisonOp[conzx_Viewpoint.UserTypeId] = strComparisonOp;
}
}
return objzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointEN SetTextId(this clszx_ViewpointEN objzx_ViewpointEN, string strTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextId, 8, conzx_Viewpoint.TextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextId, 8, conzx_Viewpoint.TextId);
}
objzx_ViewpointEN.TextId = strTextId; //课件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointEN.dicFldComparisonOp.ContainsKey(conzx_Viewpoint.TextId) == false)
{
objzx_ViewpointEN.dicFldComparisonOp.Add(conzx_Viewpoint.TextId, strComparisonOp);
}
else
{
objzx_ViewpointEN.dicFldComparisonOp[conzx_Viewpoint.TextId] = strComparisonOp;
}
}
return objzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointEN SetVoteCount(this clszx_ViewpointEN objzx_ViewpointEN, int? intVoteCount, string strComparisonOp="")
	{
objzx_ViewpointEN.VoteCount = intVoteCount; //点赞计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointEN.dicFldComparisonOp.ContainsKey(conzx_Viewpoint.VoteCount) == false)
{
objzx_ViewpointEN.dicFldComparisonOp.Add(conzx_Viewpoint.VoteCount, strComparisonOp);
}
else
{
objzx_ViewpointEN.dicFldComparisonOp[conzx_Viewpoint.VoteCount] = strComparisonOp;
}
}
return objzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointEN SetAppraiseCount(this clszx_ViewpointEN objzx_ViewpointEN, int? intAppraiseCount, string strComparisonOp="")
	{
objzx_ViewpointEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointEN.dicFldComparisonOp.ContainsKey(conzx_Viewpoint.AppraiseCount) == false)
{
objzx_ViewpointEN.dicFldComparisonOp.Add(conzx_Viewpoint.AppraiseCount, strComparisonOp);
}
else
{
objzx_ViewpointEN.dicFldComparisonOp[conzx_Viewpoint.AppraiseCount] = strComparisonOp;
}
}
return objzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointEN SetScore(this clszx_ViewpointEN objzx_ViewpointEN, float? fltScore, string strComparisonOp="")
	{
objzx_ViewpointEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointEN.dicFldComparisonOp.ContainsKey(conzx_Viewpoint.Score) == false)
{
objzx_ViewpointEN.dicFldComparisonOp.Add(conzx_Viewpoint.Score, strComparisonOp);
}
else
{
objzx_ViewpointEN.dicFldComparisonOp[conzx_Viewpoint.Score] = strComparisonOp;
}
}
return objzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointEN SetStuScore(this clszx_ViewpointEN objzx_ViewpointEN, float? fltStuScore, string strComparisonOp="")
	{
objzx_ViewpointEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointEN.dicFldComparisonOp.ContainsKey(conzx_Viewpoint.StuScore) == false)
{
objzx_ViewpointEN.dicFldComparisonOp.Add(conzx_Viewpoint.StuScore, strComparisonOp);
}
else
{
objzx_ViewpointEN.dicFldComparisonOp[conzx_Viewpoint.StuScore] = strComparisonOp;
}
}
return objzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointEN SetTeaScore(this clszx_ViewpointEN objzx_ViewpointEN, float? fltTeaScore, string strComparisonOp="")
	{
objzx_ViewpointEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointEN.dicFldComparisonOp.ContainsKey(conzx_Viewpoint.TeaScore) == false)
{
objzx_ViewpointEN.dicFldComparisonOp.Add(conzx_Viewpoint.TeaScore, strComparisonOp);
}
else
{
objzx_ViewpointEN.dicFldComparisonOp[conzx_Viewpoint.TeaScore] = strComparisonOp;
}
}
return objzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointEN SetIdCurrEduCls(this clszx_ViewpointEN objzx_ViewpointEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conzx_Viewpoint.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conzx_Viewpoint.IdCurrEduCls);
}
objzx_ViewpointEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointEN.dicFldComparisonOp.ContainsKey(conzx_Viewpoint.IdCurrEduCls) == false)
{
objzx_ViewpointEN.dicFldComparisonOp.Add(conzx_Viewpoint.IdCurrEduCls, strComparisonOp);
}
else
{
objzx_ViewpointEN.dicFldComparisonOp[conzx_Viewpoint.IdCurrEduCls] = strComparisonOp;
}
}
return objzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointEN SetPdfContent(this clszx_ViewpointEN objzx_ViewpointEN, string strPdfContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfContent, 2000, conzx_Viewpoint.PdfContent);
}
objzx_ViewpointEN.PdfContent = strPdfContent; //Pdf内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointEN.dicFldComparisonOp.ContainsKey(conzx_Viewpoint.PdfContent) == false)
{
objzx_ViewpointEN.dicFldComparisonOp.Add(conzx_Viewpoint.PdfContent, strComparisonOp);
}
else
{
objzx_ViewpointEN.dicFldComparisonOp[conzx_Viewpoint.PdfContent] = strComparisonOp;
}
}
return objzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointEN SetPdfPageNum(this clszx_ViewpointEN objzx_ViewpointEN, int? intPdfPageNum, string strComparisonOp="")
	{
objzx_ViewpointEN.PdfPageNum = intPdfPageNum; //Pdf页码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointEN.dicFldComparisonOp.ContainsKey(conzx_Viewpoint.PdfPageNum) == false)
{
objzx_ViewpointEN.dicFldComparisonOp.Add(conzx_Viewpoint.PdfPageNum, strComparisonOp);
}
else
{
objzx_ViewpointEN.dicFldComparisonOp[conzx_Viewpoint.PdfPageNum] = strComparisonOp;
}
}
return objzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointEN SetCitationCount(this clszx_ViewpointEN objzx_ViewpointEN, int? intCitationCount, string strComparisonOp="")
	{
objzx_ViewpointEN.CitationCount = intCitationCount; //引用统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointEN.dicFldComparisonOp.ContainsKey(conzx_Viewpoint.CitationCount) == false)
{
objzx_ViewpointEN.dicFldComparisonOp.Add(conzx_Viewpoint.CitationCount, strComparisonOp);
}
else
{
objzx_ViewpointEN.dicFldComparisonOp[conzx_Viewpoint.CitationCount] = strComparisonOp;
}
}
return objzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointEN SetVersionCount(this clszx_ViewpointEN objzx_ViewpointEN, int? intVersionCount, string strComparisonOp="")
	{
objzx_ViewpointEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointEN.dicFldComparisonOp.ContainsKey(conzx_Viewpoint.VersionCount) == false)
{
objzx_ViewpointEN.dicFldComparisonOp.Add(conzx_Viewpoint.VersionCount, strComparisonOp);
}
else
{
objzx_ViewpointEN.dicFldComparisonOp[conzx_Viewpoint.VersionCount] = strComparisonOp;
}
}
return objzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointEN SetzxShareId(this clszx_ViewpointEN objzx_ViewpointEN, string strzxShareId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxShareId, 2, conzx_Viewpoint.zxShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxShareId, 2, conzx_Viewpoint.zxShareId);
}
objzx_ViewpointEN.zxShareId = strzxShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointEN.dicFldComparisonOp.ContainsKey(conzx_Viewpoint.zxShareId) == false)
{
objzx_ViewpointEN.dicFldComparisonOp.Add(conzx_Viewpoint.zxShareId, strComparisonOp);
}
else
{
objzx_ViewpointEN.dicFldComparisonOp[conzx_Viewpoint.zxShareId] = strComparisonOp;
}
}
return objzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointEN SetCreateDate(this clszx_ViewpointEN objzx_ViewpointEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, conzx_Viewpoint.CreateDate);
}
objzx_ViewpointEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointEN.dicFldComparisonOp.ContainsKey(conzx_Viewpoint.CreateDate) == false)
{
objzx_ViewpointEN.dicFldComparisonOp.Add(conzx_Viewpoint.CreateDate, strComparisonOp);
}
else
{
objzx_ViewpointEN.dicFldComparisonOp[conzx_Viewpoint.CreateDate] = strComparisonOp;
}
}
return objzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointEN SetUpdDate(this clszx_ViewpointEN objzx_ViewpointEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conzx_Viewpoint.UpdDate);
}
objzx_ViewpointEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointEN.dicFldComparisonOp.ContainsKey(conzx_Viewpoint.UpdDate) == false)
{
objzx_ViewpointEN.dicFldComparisonOp.Add(conzx_Viewpoint.UpdDate, strComparisonOp);
}
else
{
objzx_ViewpointEN.dicFldComparisonOp[conzx_Viewpoint.UpdDate] = strComparisonOp;
}
}
return objzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointEN SetUpdUser(this clszx_ViewpointEN objzx_ViewpointEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conzx_Viewpoint.UpdUser);
}
objzx_ViewpointEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointEN.dicFldComparisonOp.ContainsKey(conzx_Viewpoint.UpdUser) == false)
{
objzx_ViewpointEN.dicFldComparisonOp.Add(conzx_Viewpoint.UpdUser, strComparisonOp);
}
else
{
objzx_ViewpointEN.dicFldComparisonOp[conzx_Viewpoint.UpdUser] = strComparisonOp;
}
}
return objzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointEN SetMemo(this clszx_ViewpointEN objzx_ViewpointEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conzx_Viewpoint.Memo);
}
objzx_ViewpointEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointEN.dicFldComparisonOp.ContainsKey(conzx_Viewpoint.Memo) == false)
{
objzx_ViewpointEN.dicFldComparisonOp.Add(conzx_Viewpoint.Memo, strComparisonOp);
}
else
{
objzx_ViewpointEN.dicFldComparisonOp[conzx_Viewpoint.Memo] = strComparisonOp;
}
}
return objzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointEN SetTeammenberId(this clszx_ViewpointEN objzx_ViewpointEN, string strTeammenberId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeammenberId, 8, conzx_Viewpoint.TeammenberId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeammenberId, 8, conzx_Viewpoint.TeammenberId);
}
objzx_ViewpointEN.TeammenberId = strTeammenberId; //主键
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointEN.dicFldComparisonOp.ContainsKey(conzx_Viewpoint.TeammenberId) == false)
{
objzx_ViewpointEN.dicFldComparisonOp.Add(conzx_Viewpoint.TeammenberId, strComparisonOp);
}
else
{
objzx_ViewpointEN.dicFldComparisonOp[conzx_Viewpoint.TeammenberId] = strComparisonOp;
}
}
return objzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointEN SetPdfDivLet(this clszx_ViewpointEN objzx_ViewpointEN, string strPdfDivLet, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfDivLet, 50, conzx_Viewpoint.PdfDivLet);
}
objzx_ViewpointEN.PdfDivLet = strPdfDivLet; //PdfDivLet
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointEN.dicFldComparisonOp.ContainsKey(conzx_Viewpoint.PdfDivLet) == false)
{
objzx_ViewpointEN.dicFldComparisonOp.Add(conzx_Viewpoint.PdfDivLet, strComparisonOp);
}
else
{
objzx_ViewpointEN.dicFldComparisonOp[conzx_Viewpoint.PdfDivLet] = strComparisonOp;
}
}
return objzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointEN SetPdfDivTop(this clszx_ViewpointEN objzx_ViewpointEN, string strPdfDivTop, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfDivTop, 50, conzx_Viewpoint.PdfDivTop);
}
objzx_ViewpointEN.PdfDivTop = strPdfDivTop; //PdfDivTop
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointEN.dicFldComparisonOp.ContainsKey(conzx_Viewpoint.PdfDivTop) == false)
{
objzx_ViewpointEN.dicFldComparisonOp.Add(conzx_Viewpoint.PdfDivTop, strComparisonOp);
}
else
{
objzx_ViewpointEN.dicFldComparisonOp[conzx_Viewpoint.PdfDivTop] = strComparisonOp;
}
}
return objzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointEN SetPdfPageNumIn(this clszx_ViewpointEN objzx_ViewpointEN, string strPdfPageNumIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfPageNumIn, 50, conzx_Viewpoint.PdfPageNumIn);
}
objzx_ViewpointEN.PdfPageNumIn = strPdfPageNumIn; //PdfPageNumIn
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointEN.dicFldComparisonOp.ContainsKey(conzx_Viewpoint.PdfPageNumIn) == false)
{
objzx_ViewpointEN.dicFldComparisonOp.Add(conzx_Viewpoint.PdfPageNumIn, strComparisonOp);
}
else
{
objzx_ViewpointEN.dicFldComparisonOp[conzx_Viewpoint.PdfPageNumIn] = strComparisonOp;
}
}
return objzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointEN SetPdfPageTop(this clszx_ViewpointEN objzx_ViewpointEN, int? intPdfPageTop, string strComparisonOp="")
	{
objzx_ViewpointEN.PdfPageTop = intPdfPageTop; //pdf页面顶部位置
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointEN.dicFldComparisonOp.ContainsKey(conzx_Viewpoint.PdfPageTop) == false)
{
objzx_ViewpointEN.dicFldComparisonOp.Add(conzx_Viewpoint.PdfPageTop, strComparisonOp);
}
else
{
objzx_ViewpointEN.dicFldComparisonOp[conzx_Viewpoint.PdfPageTop] = strComparisonOp;
}
}
return objzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointEN SetPdfZoom(this clszx_ViewpointEN objzx_ViewpointEN, string strPdfZoom, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfZoom, 50, conzx_Viewpoint.PdfZoom);
}
objzx_ViewpointEN.PdfZoom = strPdfZoom; //PdfZoom
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointEN.dicFldComparisonOp.ContainsKey(conzx_Viewpoint.PdfZoom) == false)
{
objzx_ViewpointEN.dicFldComparisonOp.Add(conzx_Viewpoint.PdfZoom, strComparisonOp);
}
else
{
objzx_ViewpointEN.dicFldComparisonOp[conzx_Viewpoint.PdfZoom] = strComparisonOp;
}
}
return objzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointEN SetGroupTextId(this clszx_ViewpointEN objzx_ViewpointEN, string strGroupTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupTextId, 8, conzx_Viewpoint.GroupTextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGroupTextId, 8, conzx_Viewpoint.GroupTextId);
}
objzx_ViewpointEN.GroupTextId = strGroupTextId; //小组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointEN.dicFldComparisonOp.ContainsKey(conzx_Viewpoint.GroupTextId) == false)
{
objzx_ViewpointEN.dicFldComparisonOp.Add(conzx_Viewpoint.GroupTextId, strComparisonOp);
}
else
{
objzx_ViewpointEN.dicFldComparisonOp[conzx_Viewpoint.GroupTextId] = strComparisonOp;
}
}
return objzx_ViewpointEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objzx_ViewpointEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clszx_ViewpointEN objzx_ViewpointEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objzx_ViewpointEN.CheckPropertyNew();
clszx_ViewpointEN objzx_ViewpointCond = new clszx_ViewpointEN();
string strCondition = objzx_ViewpointCond
.SetzxViewpointId(objzx_ViewpointEN.zxViewpointId, "<>")
.SetzxViewpointId(objzx_ViewpointEN.zxViewpointId, "=")
.SetTextId(objzx_ViewpointEN.TextId, "=")
.GetCombineCondition();
objzx_ViewpointEN._IsCheckProperty = true;
bool bolIsExist = clszx_ViewpointBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(zxViewpointId_TextId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objzx_ViewpointEN.Update();
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
 /// <param name = "objzx_Viewpoint">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clszx_ViewpointEN objzx_Viewpoint)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clszx_ViewpointEN objzx_ViewpointCond = new clszx_ViewpointEN();
string strCondition = objzx_ViewpointCond
.SetzxViewpointId(objzx_Viewpoint.zxViewpointId, "=")
.SetTextId(objzx_Viewpoint.TextId, "=")
.GetCombineCondition();
objzx_Viewpoint._IsCheckProperty = true;
bool bolIsExist = clszx_ViewpointBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objzx_Viewpoint.zxViewpointId = clszx_ViewpointBL.GetFirstID_S(strCondition);
objzx_Viewpoint.UpdateWithCondition(strCondition);
}
else
{
objzx_Viewpoint.zxViewpointId = clszx_ViewpointBL.GetMaxStrId_S();
objzx_Viewpoint.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objzx_ViewpointEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_ViewpointEN objzx_ViewpointEN)
{
 if (string.IsNullOrEmpty(objzx_ViewpointEN.zxViewpointId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_ViewpointBL.zx_ViewpointDA.UpdateBySql2(objzx_ViewpointEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewpointBL.ReFreshCache(objzx_ViewpointEN.IdCurrEduCls);

if (clszx_ViewpointBL.relatedActions != null)
{
clszx_ViewpointBL.relatedActions.UpdRelaTabDate(objzx_ViewpointEN.zxViewpointId, "SetUpdDate");
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
 /// <param name = "objzx_ViewpointEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_ViewpointEN objzx_ViewpointEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objzx_ViewpointEN.zxViewpointId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_ViewpointBL.zx_ViewpointDA.UpdateBySql2(objzx_ViewpointEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewpointBL.ReFreshCache(objzx_ViewpointEN.IdCurrEduCls);

if (clszx_ViewpointBL.relatedActions != null)
{
clszx_ViewpointBL.relatedActions.UpdRelaTabDate(objzx_ViewpointEN.zxViewpointId, "SetUpdDate");
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
 /// <param name = "objzx_ViewpointEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_ViewpointEN objzx_ViewpointEN, string strWhereCond)
{
try
{
bool bolResult = clszx_ViewpointBL.zx_ViewpointDA.UpdateBySqlWithCondition(objzx_ViewpointEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewpointBL.ReFreshCache(objzx_ViewpointEN.IdCurrEduCls);

if (clszx_ViewpointBL.relatedActions != null)
{
clszx_ViewpointBL.relatedActions.UpdRelaTabDate(objzx_ViewpointEN.zxViewpointId, "SetUpdDate");
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
 /// <param name = "objzx_ViewpointEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_ViewpointEN objzx_ViewpointEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clszx_ViewpointBL.zx_ViewpointDA.UpdateBySqlWithConditionTransaction(objzx_ViewpointEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewpointBL.ReFreshCache(objzx_ViewpointEN.IdCurrEduCls);

if (clszx_ViewpointBL.relatedActions != null)
{
clszx_ViewpointBL.relatedActions.UpdRelaTabDate(objzx_ViewpointEN.zxViewpointId, "SetUpdDate");
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
 /// <param name = "strzxViewpointId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clszx_ViewpointEN objzx_ViewpointEN)
{
try
{
int intRecNum = clszx_ViewpointBL.zx_ViewpointDA.DelRecord(objzx_ViewpointEN.zxViewpointId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewpointBL.ReFreshCache(objzx_ViewpointEN.IdCurrEduCls);

if (clszx_ViewpointBL.relatedActions != null)
{
clszx_ViewpointBL.relatedActions.UpdRelaTabDate(objzx_ViewpointEN.zxViewpointId, "SetUpdDate");
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
 /// <param name = "objzx_ViewpointENS">源对象</param>
 /// <param name = "objzx_ViewpointENT">目标对象</param>
 public static void CopyTo(this clszx_ViewpointEN objzx_ViewpointENS, clszx_ViewpointEN objzx_ViewpointENT)
{
try
{
objzx_ViewpointENT.zxViewpointId = objzx_ViewpointENS.zxViewpointId; //观点Id
objzx_ViewpointENT.ViewpointName = objzx_ViewpointENS.ViewpointName; //观点名称
objzx_ViewpointENT.ViewpointContent = objzx_ViewpointENS.ViewpointContent; //观点内容
objzx_ViewpointENT.zxViewpointTypeId = objzx_ViewpointENS.zxViewpointTypeId; //观点类型Id
objzx_ViewpointENT.Reason = objzx_ViewpointENS.Reason; //理由
objzx_ViewpointENT.Source = objzx_ViewpointENS.Source; //来源
objzx_ViewpointENT.VPProposePeople = objzx_ViewpointENS.VPProposePeople; //观点提出人
objzx_ViewpointENT.IsSubmit = objzx_ViewpointENS.IsSubmit; //是否提交
objzx_ViewpointENT.UserTypeId = objzx_ViewpointENS.UserTypeId; //用户类型Id
objzx_ViewpointENT.TextId = objzx_ViewpointENS.TextId; //课件Id
objzx_ViewpointENT.VoteCount = objzx_ViewpointENS.VoteCount; //点赞计数
objzx_ViewpointENT.AppraiseCount = objzx_ViewpointENS.AppraiseCount; //评论数
objzx_ViewpointENT.Score = objzx_ViewpointENS.Score; //评分
objzx_ViewpointENT.StuScore = objzx_ViewpointENS.StuScore; //学生平均分
objzx_ViewpointENT.TeaScore = objzx_ViewpointENS.TeaScore; //教师评分
objzx_ViewpointENT.IdCurrEduCls = objzx_ViewpointENS.IdCurrEduCls; //教学班流水号
objzx_ViewpointENT.PdfContent = objzx_ViewpointENS.PdfContent; //Pdf内容
objzx_ViewpointENT.PdfPageNum = objzx_ViewpointENS.PdfPageNum; //Pdf页码
objzx_ViewpointENT.CitationCount = objzx_ViewpointENS.CitationCount; //引用统计
objzx_ViewpointENT.VersionCount = objzx_ViewpointENS.VersionCount; //版本统计
objzx_ViewpointENT.zxShareId = objzx_ViewpointENS.zxShareId; //分享Id
objzx_ViewpointENT.CreateDate = objzx_ViewpointENS.CreateDate; //建立日期
objzx_ViewpointENT.UpdDate = objzx_ViewpointENS.UpdDate; //修改日期
objzx_ViewpointENT.UpdUser = objzx_ViewpointENS.UpdUser; //修改人
objzx_ViewpointENT.Memo = objzx_ViewpointENS.Memo; //备注
objzx_ViewpointENT.TeammenberId = objzx_ViewpointENS.TeammenberId; //主键
objzx_ViewpointENT.PdfDivLet = objzx_ViewpointENS.PdfDivLet; //PdfDivLet
objzx_ViewpointENT.PdfDivTop = objzx_ViewpointENS.PdfDivTop; //PdfDivTop
objzx_ViewpointENT.PdfPageNumIn = objzx_ViewpointENS.PdfPageNumIn; //PdfPageNumIn
objzx_ViewpointENT.PdfPageTop = objzx_ViewpointENS.PdfPageTop; //pdf页面顶部位置
objzx_ViewpointENT.PdfZoom = objzx_ViewpointENS.PdfZoom; //PdfZoom
objzx_ViewpointENT.GroupTextId = objzx_ViewpointENS.GroupTextId; //小组Id
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
 /// <param name = "objzx_ViewpointENS">源对象</param>
 /// <returns>目标对象=>clszx_ViewpointEN:objzx_ViewpointENT</returns>
 public static clszx_ViewpointEN CopyTo(this clszx_ViewpointEN objzx_ViewpointENS)
{
try
{
 clszx_ViewpointEN objzx_ViewpointENT = new clszx_ViewpointEN()
{
zxViewpointId = objzx_ViewpointENS.zxViewpointId, //观点Id
ViewpointName = objzx_ViewpointENS.ViewpointName, //观点名称
ViewpointContent = objzx_ViewpointENS.ViewpointContent, //观点内容
zxViewpointTypeId = objzx_ViewpointENS.zxViewpointTypeId, //观点类型Id
Reason = objzx_ViewpointENS.Reason, //理由
Source = objzx_ViewpointENS.Source, //来源
VPProposePeople = objzx_ViewpointENS.VPProposePeople, //观点提出人
IsSubmit = objzx_ViewpointENS.IsSubmit, //是否提交
UserTypeId = objzx_ViewpointENS.UserTypeId, //用户类型Id
TextId = objzx_ViewpointENS.TextId, //课件Id
VoteCount = objzx_ViewpointENS.VoteCount, //点赞计数
AppraiseCount = objzx_ViewpointENS.AppraiseCount, //评论数
Score = objzx_ViewpointENS.Score, //评分
StuScore = objzx_ViewpointENS.StuScore, //学生平均分
TeaScore = objzx_ViewpointENS.TeaScore, //教师评分
IdCurrEduCls = objzx_ViewpointENS.IdCurrEduCls, //教学班流水号
PdfContent = objzx_ViewpointENS.PdfContent, //Pdf内容
PdfPageNum = objzx_ViewpointENS.PdfPageNum, //Pdf页码
CitationCount = objzx_ViewpointENS.CitationCount, //引用统计
VersionCount = objzx_ViewpointENS.VersionCount, //版本统计
zxShareId = objzx_ViewpointENS.zxShareId, //分享Id
CreateDate = objzx_ViewpointENS.CreateDate, //建立日期
UpdDate = objzx_ViewpointENS.UpdDate, //修改日期
UpdUser = objzx_ViewpointENS.UpdUser, //修改人
Memo = objzx_ViewpointENS.Memo, //备注
TeammenberId = objzx_ViewpointENS.TeammenberId, //主键
PdfDivLet = objzx_ViewpointENS.PdfDivLet, //PdfDivLet
PdfDivTop = objzx_ViewpointENS.PdfDivTop, //PdfDivTop
PdfPageNumIn = objzx_ViewpointENS.PdfPageNumIn, //PdfPageNumIn
PdfPageTop = objzx_ViewpointENS.PdfPageTop, //pdf页面顶部位置
PdfZoom = objzx_ViewpointENS.PdfZoom, //PdfZoom
GroupTextId = objzx_ViewpointENS.GroupTextId, //小组Id
};
 return objzx_ViewpointENT;
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
public static void CheckPropertyNew(this clszx_ViewpointEN objzx_ViewpointEN)
{
 clszx_ViewpointBL.zx_ViewpointDA.CheckPropertyNew(objzx_ViewpointEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clszx_ViewpointEN objzx_ViewpointEN)
{
 clszx_ViewpointBL.zx_ViewpointDA.CheckProperty4Condition(objzx_ViewpointEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clszx_ViewpointEN objzx_ViewpointCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objzx_ViewpointCond.IsUpdated(conzx_Viewpoint.zxViewpointId) == true)
{
string strComparisonOpzxViewpointId = objzx_ViewpointCond.dicFldComparisonOp[conzx_Viewpoint.zxViewpointId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Viewpoint.zxViewpointId, objzx_ViewpointCond.zxViewpointId, strComparisonOpzxViewpointId);
}
if (objzx_ViewpointCond.IsUpdated(conzx_Viewpoint.ViewpointName) == true)
{
string strComparisonOpViewpointName = objzx_ViewpointCond.dicFldComparisonOp[conzx_Viewpoint.ViewpointName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Viewpoint.ViewpointName, objzx_ViewpointCond.ViewpointName, strComparisonOpViewpointName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objzx_ViewpointCond.IsUpdated(conzx_Viewpoint.zxViewpointTypeId) == true)
{
string strComparisonOpzxViewpointTypeId = objzx_ViewpointCond.dicFldComparisonOp[conzx_Viewpoint.zxViewpointTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Viewpoint.zxViewpointTypeId, objzx_ViewpointCond.zxViewpointTypeId, strComparisonOpzxViewpointTypeId);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objzx_ViewpointCond.IsUpdated(conzx_Viewpoint.Source) == true)
{
string strComparisonOpSource = objzx_ViewpointCond.dicFldComparisonOp[conzx_Viewpoint.Source];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Viewpoint.Source, objzx_ViewpointCond.Source, strComparisonOpSource);
}
if (objzx_ViewpointCond.IsUpdated(conzx_Viewpoint.VPProposePeople) == true)
{
string strComparisonOpVPProposePeople = objzx_ViewpointCond.dicFldComparisonOp[conzx_Viewpoint.VPProposePeople];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Viewpoint.VPProposePeople, objzx_ViewpointCond.VPProposePeople, strComparisonOpVPProposePeople);
}
if (objzx_ViewpointCond.IsUpdated(conzx_Viewpoint.IsSubmit) == true)
{
if (objzx_ViewpointCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", conzx_Viewpoint.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conzx_Viewpoint.IsSubmit);
}
}
if (objzx_ViewpointCond.IsUpdated(conzx_Viewpoint.UserTypeId) == true)
{
string strComparisonOpUserTypeId = objzx_ViewpointCond.dicFldComparisonOp[conzx_Viewpoint.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Viewpoint.UserTypeId, objzx_ViewpointCond.UserTypeId, strComparisonOpUserTypeId);
}
if (objzx_ViewpointCond.IsUpdated(conzx_Viewpoint.TextId) == true)
{
string strComparisonOpTextId = objzx_ViewpointCond.dicFldComparisonOp[conzx_Viewpoint.TextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Viewpoint.TextId, objzx_ViewpointCond.TextId, strComparisonOpTextId);
}
if (objzx_ViewpointCond.IsUpdated(conzx_Viewpoint.VoteCount) == true)
{
string strComparisonOpVoteCount = objzx_ViewpointCond.dicFldComparisonOp[conzx_Viewpoint.VoteCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Viewpoint.VoteCount, objzx_ViewpointCond.VoteCount, strComparisonOpVoteCount);
}
if (objzx_ViewpointCond.IsUpdated(conzx_Viewpoint.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objzx_ViewpointCond.dicFldComparisonOp[conzx_Viewpoint.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Viewpoint.AppraiseCount, objzx_ViewpointCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objzx_ViewpointCond.IsUpdated(conzx_Viewpoint.Score) == true)
{
string strComparisonOpScore = objzx_ViewpointCond.dicFldComparisonOp[conzx_Viewpoint.Score];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Viewpoint.Score, objzx_ViewpointCond.Score, strComparisonOpScore);
}
if (objzx_ViewpointCond.IsUpdated(conzx_Viewpoint.StuScore) == true)
{
string strComparisonOpStuScore = objzx_ViewpointCond.dicFldComparisonOp[conzx_Viewpoint.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Viewpoint.StuScore, objzx_ViewpointCond.StuScore, strComparisonOpStuScore);
}
if (objzx_ViewpointCond.IsUpdated(conzx_Viewpoint.TeaScore) == true)
{
string strComparisonOpTeaScore = objzx_ViewpointCond.dicFldComparisonOp[conzx_Viewpoint.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Viewpoint.TeaScore, objzx_ViewpointCond.TeaScore, strComparisonOpTeaScore);
}
if (objzx_ViewpointCond.IsUpdated(conzx_Viewpoint.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objzx_ViewpointCond.dicFldComparisonOp[conzx_Viewpoint.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Viewpoint.IdCurrEduCls, objzx_ViewpointCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objzx_ViewpointCond.IsUpdated(conzx_Viewpoint.PdfContent) == true)
{
string strComparisonOpPdfContent = objzx_ViewpointCond.dicFldComparisonOp[conzx_Viewpoint.PdfContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Viewpoint.PdfContent, objzx_ViewpointCond.PdfContent, strComparisonOpPdfContent);
}
if (objzx_ViewpointCond.IsUpdated(conzx_Viewpoint.PdfPageNum) == true)
{
string strComparisonOpPdfPageNum = objzx_ViewpointCond.dicFldComparisonOp[conzx_Viewpoint.PdfPageNum];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Viewpoint.PdfPageNum, objzx_ViewpointCond.PdfPageNum, strComparisonOpPdfPageNum);
}
if (objzx_ViewpointCond.IsUpdated(conzx_Viewpoint.CitationCount) == true)
{
string strComparisonOpCitationCount = objzx_ViewpointCond.dicFldComparisonOp[conzx_Viewpoint.CitationCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Viewpoint.CitationCount, objzx_ViewpointCond.CitationCount, strComparisonOpCitationCount);
}
if (objzx_ViewpointCond.IsUpdated(conzx_Viewpoint.VersionCount) == true)
{
string strComparisonOpVersionCount = objzx_ViewpointCond.dicFldComparisonOp[conzx_Viewpoint.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Viewpoint.VersionCount, objzx_ViewpointCond.VersionCount, strComparisonOpVersionCount);
}
if (objzx_ViewpointCond.IsUpdated(conzx_Viewpoint.zxShareId) == true)
{
string strComparisonOpzxShareId = objzx_ViewpointCond.dicFldComparisonOp[conzx_Viewpoint.zxShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Viewpoint.zxShareId, objzx_ViewpointCond.zxShareId, strComparisonOpzxShareId);
}
if (objzx_ViewpointCond.IsUpdated(conzx_Viewpoint.CreateDate) == true)
{
string strComparisonOpCreateDate = objzx_ViewpointCond.dicFldComparisonOp[conzx_Viewpoint.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Viewpoint.CreateDate, objzx_ViewpointCond.CreateDate, strComparisonOpCreateDate);
}
if (objzx_ViewpointCond.IsUpdated(conzx_Viewpoint.UpdDate) == true)
{
string strComparisonOpUpdDate = objzx_ViewpointCond.dicFldComparisonOp[conzx_Viewpoint.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Viewpoint.UpdDate, objzx_ViewpointCond.UpdDate, strComparisonOpUpdDate);
}
if (objzx_ViewpointCond.IsUpdated(conzx_Viewpoint.UpdUser) == true)
{
string strComparisonOpUpdUser = objzx_ViewpointCond.dicFldComparisonOp[conzx_Viewpoint.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Viewpoint.UpdUser, objzx_ViewpointCond.UpdUser, strComparisonOpUpdUser);
}
if (objzx_ViewpointCond.IsUpdated(conzx_Viewpoint.Memo) == true)
{
string strComparisonOpMemo = objzx_ViewpointCond.dicFldComparisonOp[conzx_Viewpoint.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Viewpoint.Memo, objzx_ViewpointCond.Memo, strComparisonOpMemo);
}
if (objzx_ViewpointCond.IsUpdated(conzx_Viewpoint.TeammenberId) == true)
{
string strComparisonOpTeammenberId = objzx_ViewpointCond.dicFldComparisonOp[conzx_Viewpoint.TeammenberId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Viewpoint.TeammenberId, objzx_ViewpointCond.TeammenberId, strComparisonOpTeammenberId);
}
if (objzx_ViewpointCond.IsUpdated(conzx_Viewpoint.PdfDivLet) == true)
{
string strComparisonOpPdfDivLet = objzx_ViewpointCond.dicFldComparisonOp[conzx_Viewpoint.PdfDivLet];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Viewpoint.PdfDivLet, objzx_ViewpointCond.PdfDivLet, strComparisonOpPdfDivLet);
}
if (objzx_ViewpointCond.IsUpdated(conzx_Viewpoint.PdfDivTop) == true)
{
string strComparisonOpPdfDivTop = objzx_ViewpointCond.dicFldComparisonOp[conzx_Viewpoint.PdfDivTop];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Viewpoint.PdfDivTop, objzx_ViewpointCond.PdfDivTop, strComparisonOpPdfDivTop);
}
if (objzx_ViewpointCond.IsUpdated(conzx_Viewpoint.PdfPageNumIn) == true)
{
string strComparisonOpPdfPageNumIn = objzx_ViewpointCond.dicFldComparisonOp[conzx_Viewpoint.PdfPageNumIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Viewpoint.PdfPageNumIn, objzx_ViewpointCond.PdfPageNumIn, strComparisonOpPdfPageNumIn);
}
if (objzx_ViewpointCond.IsUpdated(conzx_Viewpoint.PdfPageTop) == true)
{
string strComparisonOpPdfPageTop = objzx_ViewpointCond.dicFldComparisonOp[conzx_Viewpoint.PdfPageTop];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Viewpoint.PdfPageTop, objzx_ViewpointCond.PdfPageTop, strComparisonOpPdfPageTop);
}
if (objzx_ViewpointCond.IsUpdated(conzx_Viewpoint.PdfZoom) == true)
{
string strComparisonOpPdfZoom = objzx_ViewpointCond.dicFldComparisonOp[conzx_Viewpoint.PdfZoom];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Viewpoint.PdfZoom, objzx_ViewpointCond.PdfZoom, strComparisonOpPdfZoom);
}
if (objzx_ViewpointCond.IsUpdated(conzx_Viewpoint.GroupTextId) == true)
{
string strComparisonOpGroupTextId = objzx_ViewpointCond.dicFldComparisonOp[conzx_Viewpoint.GroupTextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Viewpoint.GroupTextId, objzx_ViewpointCond.GroupTextId, strComparisonOpGroupTextId);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--zx_Viewpoint(中学观点表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:zxViewpointId_TextId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objzx_ViewpointEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clszx_ViewpointEN objzx_ViewpointEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objzx_ViewpointEN == null) return true;
if (objzx_ViewpointEN.zxViewpointId == null || objzx_ViewpointEN.zxViewpointId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and zxViewpointId = '{0}'", objzx_ViewpointEN.zxViewpointId);
 if (objzx_ViewpointEN.TextId == null)
{
 sbCondition.AppendFormat(" and TextId is null", objzx_ViewpointEN.TextId);
}
else
{
 sbCondition.AppendFormat(" and TextId = '{0}'", objzx_ViewpointEN.TextId);
}
if (clszx_ViewpointBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("zxViewpointId !=  '{0}'", objzx_ViewpointEN.zxViewpointId);
 sbCondition.AppendFormat(" and zxViewpointId = '{0}'", objzx_ViewpointEN.zxViewpointId);
 sbCondition.AppendFormat(" and TextId = '{0}'", objzx_ViewpointEN.TextId);
if (clszx_ViewpointBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--zx_Viewpoint(中学观点表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:zxViewpointId_TextId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objzx_ViewpointEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clszx_ViewpointEN objzx_ViewpointEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objzx_ViewpointEN == null) return "";
if (objzx_ViewpointEN.zxViewpointId == null || objzx_ViewpointEN.zxViewpointId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and zxViewpointId = '{0}'", objzx_ViewpointEN.zxViewpointId);
 if (objzx_ViewpointEN.TextId == null)
{
 sbCondition.AppendFormat(" and TextId is null", objzx_ViewpointEN.TextId);
}
else
{
 sbCondition.AppendFormat(" and TextId = '{0}'", objzx_ViewpointEN.TextId);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("zxViewpointId !=  '{0}'", objzx_ViewpointEN.zxViewpointId);
 sbCondition.AppendFormat(" and zxViewpointId = '{0}'", objzx_ViewpointEN.zxViewpointId);
 sbCondition.AppendFormat(" and TextId = '{0}'", objzx_ViewpointEN.TextId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_zx_Viewpoint
{
public virtual bool UpdRelaTabDate(string strzxViewpointId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 中学观点表(zx_Viewpoint)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clszx_ViewpointBL
{
public static RelatedActions_zx_Viewpoint relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clszx_ViewpointDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clszx_ViewpointDA zx_ViewpointDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clszx_ViewpointDA();
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
 public clszx_ViewpointBL()
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
if (string.IsNullOrEmpty(clszx_ViewpointEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_ViewpointEN._ConnectString);
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
public static DataTable GetDataTable_zx_Viewpoint(string strWhereCond)
{
DataTable objDT;
try
{
objDT = zx_ViewpointDA.GetDataTable_zx_Viewpoint(strWhereCond);
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
objDT = zx_ViewpointDA.GetDataTable(strWhereCond);
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
objDT = zx_ViewpointDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = zx_ViewpointDA.GetDataTable(strWhereCond, strTabName);
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
objDT = zx_ViewpointDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = zx_ViewpointDA.GetDataTable_Top(objTopPara);
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
objDT = zx_ViewpointDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = zx_ViewpointDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = zx_ViewpointDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrZxViewpointIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clszx_ViewpointEN> GetObjLstByZxViewpointIdLst(List<string> arrZxViewpointIdLst)
{
List<clszx_ViewpointEN> arrObjLst = new List<clszx_ViewpointEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrZxViewpointIdLst, true);
 string strWhereCond = string.Format("zxViewpointId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ViewpointEN objzx_ViewpointEN = new clszx_ViewpointEN();
try
{
objzx_ViewpointEN.zxViewpointId = objRow[conzx_Viewpoint.zxViewpointId].ToString().Trim(); //观点Id
objzx_ViewpointEN.ViewpointName = objRow[conzx_Viewpoint.ViewpointName] == DBNull.Value ? null : objRow[conzx_Viewpoint.ViewpointName].ToString().Trim(); //观点名称
objzx_ViewpointEN.ViewpointContent = objRow[conzx_Viewpoint.ViewpointContent] == DBNull.Value ? null : objRow[conzx_Viewpoint.ViewpointContent].ToString().Trim(); //观点内容
objzx_ViewpointEN.zxViewpointTypeId = objRow[conzx_Viewpoint.zxViewpointTypeId] == DBNull.Value ? null : objRow[conzx_Viewpoint.zxViewpointTypeId].ToString().Trim(); //观点类型Id
objzx_ViewpointEN.Reason = objRow[conzx_Viewpoint.Reason] == DBNull.Value ? null : objRow[conzx_Viewpoint.Reason].ToString().Trim(); //理由
objzx_ViewpointEN.Source = objRow[conzx_Viewpoint.Source] == DBNull.Value ? null : objRow[conzx_Viewpoint.Source].ToString().Trim(); //来源
objzx_ViewpointEN.VPProposePeople = objRow[conzx_Viewpoint.VPProposePeople] == DBNull.Value ? null : objRow[conzx_Viewpoint.VPProposePeople].ToString().Trim(); //观点提出人
objzx_ViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Viewpoint.IsSubmit].ToString().Trim()); //是否提交
objzx_ViewpointEN.UserTypeId = objRow[conzx_Viewpoint.UserTypeId] == DBNull.Value ? null : objRow[conzx_Viewpoint.UserTypeId].ToString().Trim(); //用户类型Id
objzx_ViewpointEN.TextId = objRow[conzx_Viewpoint.TextId] == DBNull.Value ? null : objRow[conzx_Viewpoint.TextId].ToString().Trim(); //课件Id
objzx_ViewpointEN.VoteCount = objRow[conzx_Viewpoint.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.VoteCount].ToString().Trim()); //点赞计数
objzx_ViewpointEN.AppraiseCount = objRow[conzx_Viewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.AppraiseCount].ToString().Trim()); //评论数
objzx_ViewpointEN.Score = objRow[conzx_Viewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Viewpoint.Score].ToString().Trim()); //评分
objzx_ViewpointEN.StuScore = objRow[conzx_Viewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Viewpoint.StuScore].ToString().Trim()); //学生平均分
objzx_ViewpointEN.TeaScore = objRow[conzx_Viewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Viewpoint.TeaScore].ToString().Trim()); //教师评分
objzx_ViewpointEN.IdCurrEduCls = objRow[conzx_Viewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Viewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ViewpointEN.PdfContent = objRow[conzx_Viewpoint.PdfContent] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfContent].ToString().Trim(); //Pdf内容
objzx_ViewpointEN.PdfPageNum = objRow[conzx_Viewpoint.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ViewpointEN.CitationCount = objRow[conzx_Viewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.CitationCount].ToString().Trim()); //引用统计
objzx_ViewpointEN.VersionCount = objRow[conzx_Viewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.VersionCount].ToString().Trim()); //版本统计
objzx_ViewpointEN.zxShareId = objRow[conzx_Viewpoint.zxShareId] == DBNull.Value ? null : objRow[conzx_Viewpoint.zxShareId].ToString().Trim(); //分享Id
objzx_ViewpointEN.CreateDate = objRow[conzx_Viewpoint.CreateDate] == DBNull.Value ? null : objRow[conzx_Viewpoint.CreateDate].ToString().Trim(); //建立日期
objzx_ViewpointEN.UpdDate = objRow[conzx_Viewpoint.UpdDate] == DBNull.Value ? null : objRow[conzx_Viewpoint.UpdDate].ToString().Trim(); //修改日期
objzx_ViewpointEN.UpdUser = objRow[conzx_Viewpoint.UpdUser] == DBNull.Value ? null : objRow[conzx_Viewpoint.UpdUser].ToString().Trim(); //修改人
objzx_ViewpointEN.Memo = objRow[conzx_Viewpoint.Memo] == DBNull.Value ? null : objRow[conzx_Viewpoint.Memo].ToString().Trim(); //备注
objzx_ViewpointEN.TeammenberId = objRow[conzx_Viewpoint.TeammenberId] == DBNull.Value ? null : objRow[conzx_Viewpoint.TeammenberId].ToString().Trim(); //主键
objzx_ViewpointEN.PdfDivLet = objRow[conzx_Viewpoint.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ViewpointEN.PdfDivTop = objRow[conzx_Viewpoint.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ViewpointEN.PdfPageNumIn = objRow[conzx_Viewpoint.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ViewpointEN.PdfPageTop = objRow[conzx_Viewpoint.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ViewpointEN.PdfZoom = objRow[conzx_Viewpoint.PdfZoom] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ViewpointEN.GroupTextId = objRow[conzx_Viewpoint.GroupTextId] == DBNull.Value ? null : objRow[conzx_Viewpoint.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ViewpointEN.zxViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ViewpointEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrZxViewpointIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clszx_ViewpointEN> GetObjLstByZxViewpointIdLstCache(List<string> arrZxViewpointIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clszx_ViewpointEN._CurrTabName, strIdCurrEduCls);
List<clszx_ViewpointEN> arrzx_ViewpointObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clszx_ViewpointEN> arrzx_ViewpointObjLst_Sel =
arrzx_ViewpointObjLstCache
.Where(x => arrZxViewpointIdLst.Contains(x.zxViewpointId));
return arrzx_ViewpointObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_ViewpointEN> GetObjLst(string strWhereCond)
{
List<clszx_ViewpointEN> arrObjLst = new List<clszx_ViewpointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ViewpointEN objzx_ViewpointEN = new clszx_ViewpointEN();
try
{
objzx_ViewpointEN.zxViewpointId = objRow[conzx_Viewpoint.zxViewpointId].ToString().Trim(); //观点Id
objzx_ViewpointEN.ViewpointName = objRow[conzx_Viewpoint.ViewpointName] == DBNull.Value ? null : objRow[conzx_Viewpoint.ViewpointName].ToString().Trim(); //观点名称
objzx_ViewpointEN.ViewpointContent = objRow[conzx_Viewpoint.ViewpointContent] == DBNull.Value ? null : objRow[conzx_Viewpoint.ViewpointContent].ToString().Trim(); //观点内容
objzx_ViewpointEN.zxViewpointTypeId = objRow[conzx_Viewpoint.zxViewpointTypeId] == DBNull.Value ? null : objRow[conzx_Viewpoint.zxViewpointTypeId].ToString().Trim(); //观点类型Id
objzx_ViewpointEN.Reason = objRow[conzx_Viewpoint.Reason] == DBNull.Value ? null : objRow[conzx_Viewpoint.Reason].ToString().Trim(); //理由
objzx_ViewpointEN.Source = objRow[conzx_Viewpoint.Source] == DBNull.Value ? null : objRow[conzx_Viewpoint.Source].ToString().Trim(); //来源
objzx_ViewpointEN.VPProposePeople = objRow[conzx_Viewpoint.VPProposePeople] == DBNull.Value ? null : objRow[conzx_Viewpoint.VPProposePeople].ToString().Trim(); //观点提出人
objzx_ViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Viewpoint.IsSubmit].ToString().Trim()); //是否提交
objzx_ViewpointEN.UserTypeId = objRow[conzx_Viewpoint.UserTypeId] == DBNull.Value ? null : objRow[conzx_Viewpoint.UserTypeId].ToString().Trim(); //用户类型Id
objzx_ViewpointEN.TextId = objRow[conzx_Viewpoint.TextId] == DBNull.Value ? null : objRow[conzx_Viewpoint.TextId].ToString().Trim(); //课件Id
objzx_ViewpointEN.VoteCount = objRow[conzx_Viewpoint.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.VoteCount].ToString().Trim()); //点赞计数
objzx_ViewpointEN.AppraiseCount = objRow[conzx_Viewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.AppraiseCount].ToString().Trim()); //评论数
objzx_ViewpointEN.Score = objRow[conzx_Viewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Viewpoint.Score].ToString().Trim()); //评分
objzx_ViewpointEN.StuScore = objRow[conzx_Viewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Viewpoint.StuScore].ToString().Trim()); //学生平均分
objzx_ViewpointEN.TeaScore = objRow[conzx_Viewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Viewpoint.TeaScore].ToString().Trim()); //教师评分
objzx_ViewpointEN.IdCurrEduCls = objRow[conzx_Viewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Viewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ViewpointEN.PdfContent = objRow[conzx_Viewpoint.PdfContent] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfContent].ToString().Trim(); //Pdf内容
objzx_ViewpointEN.PdfPageNum = objRow[conzx_Viewpoint.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ViewpointEN.CitationCount = objRow[conzx_Viewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.CitationCount].ToString().Trim()); //引用统计
objzx_ViewpointEN.VersionCount = objRow[conzx_Viewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.VersionCount].ToString().Trim()); //版本统计
objzx_ViewpointEN.zxShareId = objRow[conzx_Viewpoint.zxShareId] == DBNull.Value ? null : objRow[conzx_Viewpoint.zxShareId].ToString().Trim(); //分享Id
objzx_ViewpointEN.CreateDate = objRow[conzx_Viewpoint.CreateDate] == DBNull.Value ? null : objRow[conzx_Viewpoint.CreateDate].ToString().Trim(); //建立日期
objzx_ViewpointEN.UpdDate = objRow[conzx_Viewpoint.UpdDate] == DBNull.Value ? null : objRow[conzx_Viewpoint.UpdDate].ToString().Trim(); //修改日期
objzx_ViewpointEN.UpdUser = objRow[conzx_Viewpoint.UpdUser] == DBNull.Value ? null : objRow[conzx_Viewpoint.UpdUser].ToString().Trim(); //修改人
objzx_ViewpointEN.Memo = objRow[conzx_Viewpoint.Memo] == DBNull.Value ? null : objRow[conzx_Viewpoint.Memo].ToString().Trim(); //备注
objzx_ViewpointEN.TeammenberId = objRow[conzx_Viewpoint.TeammenberId] == DBNull.Value ? null : objRow[conzx_Viewpoint.TeammenberId].ToString().Trim(); //主键
objzx_ViewpointEN.PdfDivLet = objRow[conzx_Viewpoint.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ViewpointEN.PdfDivTop = objRow[conzx_Viewpoint.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ViewpointEN.PdfPageNumIn = objRow[conzx_Viewpoint.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ViewpointEN.PdfPageTop = objRow[conzx_Viewpoint.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ViewpointEN.PdfZoom = objRow[conzx_Viewpoint.PdfZoom] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ViewpointEN.GroupTextId = objRow[conzx_Viewpoint.GroupTextId] == DBNull.Value ? null : objRow[conzx_Viewpoint.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ViewpointEN.zxViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ViewpointEN);
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
public static List<clszx_ViewpointEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clszx_ViewpointEN> arrObjLst = new List<clszx_ViewpointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ViewpointEN objzx_ViewpointEN = new clszx_ViewpointEN();
try
{
objzx_ViewpointEN.zxViewpointId = objRow[conzx_Viewpoint.zxViewpointId].ToString().Trim(); //观点Id
objzx_ViewpointEN.ViewpointName = objRow[conzx_Viewpoint.ViewpointName] == DBNull.Value ? null : objRow[conzx_Viewpoint.ViewpointName].ToString().Trim(); //观点名称
objzx_ViewpointEN.ViewpointContent = objRow[conzx_Viewpoint.ViewpointContent] == DBNull.Value ? null : objRow[conzx_Viewpoint.ViewpointContent].ToString().Trim(); //观点内容
objzx_ViewpointEN.zxViewpointTypeId = objRow[conzx_Viewpoint.zxViewpointTypeId] == DBNull.Value ? null : objRow[conzx_Viewpoint.zxViewpointTypeId].ToString().Trim(); //观点类型Id
objzx_ViewpointEN.Reason = objRow[conzx_Viewpoint.Reason] == DBNull.Value ? null : objRow[conzx_Viewpoint.Reason].ToString().Trim(); //理由
objzx_ViewpointEN.Source = objRow[conzx_Viewpoint.Source] == DBNull.Value ? null : objRow[conzx_Viewpoint.Source].ToString().Trim(); //来源
objzx_ViewpointEN.VPProposePeople = objRow[conzx_Viewpoint.VPProposePeople] == DBNull.Value ? null : objRow[conzx_Viewpoint.VPProposePeople].ToString().Trim(); //观点提出人
objzx_ViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Viewpoint.IsSubmit].ToString().Trim()); //是否提交
objzx_ViewpointEN.UserTypeId = objRow[conzx_Viewpoint.UserTypeId] == DBNull.Value ? null : objRow[conzx_Viewpoint.UserTypeId].ToString().Trim(); //用户类型Id
objzx_ViewpointEN.TextId = objRow[conzx_Viewpoint.TextId] == DBNull.Value ? null : objRow[conzx_Viewpoint.TextId].ToString().Trim(); //课件Id
objzx_ViewpointEN.VoteCount = objRow[conzx_Viewpoint.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.VoteCount].ToString().Trim()); //点赞计数
objzx_ViewpointEN.AppraiseCount = objRow[conzx_Viewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.AppraiseCount].ToString().Trim()); //评论数
objzx_ViewpointEN.Score = objRow[conzx_Viewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Viewpoint.Score].ToString().Trim()); //评分
objzx_ViewpointEN.StuScore = objRow[conzx_Viewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Viewpoint.StuScore].ToString().Trim()); //学生平均分
objzx_ViewpointEN.TeaScore = objRow[conzx_Viewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Viewpoint.TeaScore].ToString().Trim()); //教师评分
objzx_ViewpointEN.IdCurrEduCls = objRow[conzx_Viewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Viewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ViewpointEN.PdfContent = objRow[conzx_Viewpoint.PdfContent] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfContent].ToString().Trim(); //Pdf内容
objzx_ViewpointEN.PdfPageNum = objRow[conzx_Viewpoint.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ViewpointEN.CitationCount = objRow[conzx_Viewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.CitationCount].ToString().Trim()); //引用统计
objzx_ViewpointEN.VersionCount = objRow[conzx_Viewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.VersionCount].ToString().Trim()); //版本统计
objzx_ViewpointEN.zxShareId = objRow[conzx_Viewpoint.zxShareId] == DBNull.Value ? null : objRow[conzx_Viewpoint.zxShareId].ToString().Trim(); //分享Id
objzx_ViewpointEN.CreateDate = objRow[conzx_Viewpoint.CreateDate] == DBNull.Value ? null : objRow[conzx_Viewpoint.CreateDate].ToString().Trim(); //建立日期
objzx_ViewpointEN.UpdDate = objRow[conzx_Viewpoint.UpdDate] == DBNull.Value ? null : objRow[conzx_Viewpoint.UpdDate].ToString().Trim(); //修改日期
objzx_ViewpointEN.UpdUser = objRow[conzx_Viewpoint.UpdUser] == DBNull.Value ? null : objRow[conzx_Viewpoint.UpdUser].ToString().Trim(); //修改人
objzx_ViewpointEN.Memo = objRow[conzx_Viewpoint.Memo] == DBNull.Value ? null : objRow[conzx_Viewpoint.Memo].ToString().Trim(); //备注
objzx_ViewpointEN.TeammenberId = objRow[conzx_Viewpoint.TeammenberId] == DBNull.Value ? null : objRow[conzx_Viewpoint.TeammenberId].ToString().Trim(); //主键
objzx_ViewpointEN.PdfDivLet = objRow[conzx_Viewpoint.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ViewpointEN.PdfDivTop = objRow[conzx_Viewpoint.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ViewpointEN.PdfPageNumIn = objRow[conzx_Viewpoint.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ViewpointEN.PdfPageTop = objRow[conzx_Viewpoint.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ViewpointEN.PdfZoom = objRow[conzx_Viewpoint.PdfZoom] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ViewpointEN.GroupTextId = objRow[conzx_Viewpoint.GroupTextId] == DBNull.Value ? null : objRow[conzx_Viewpoint.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ViewpointEN.zxViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ViewpointEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objzx_ViewpointCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clszx_ViewpointEN> GetSubObjLstCache(clszx_ViewpointEN objzx_ViewpointCond)
{
 string strIdCurrEduCls = objzx_ViewpointCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clszx_ViewpointBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clszx_ViewpointEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clszx_ViewpointEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_Viewpoint.AttributeName)
{
if (objzx_ViewpointCond.IsUpdated(strFldName) == false) continue;
if (objzx_ViewpointCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_ViewpointCond[strFldName].ToString());
}
else
{
if (objzx_ViewpointCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_ViewpointCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_ViewpointCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_ViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_ViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_ViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_ViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_ViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_ViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_ViewpointCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_ViewpointCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_ViewpointCond[strFldName]));
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
public static List<clszx_ViewpointEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clszx_ViewpointEN> arrObjLst = new List<clszx_ViewpointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ViewpointEN objzx_ViewpointEN = new clszx_ViewpointEN();
try
{
objzx_ViewpointEN.zxViewpointId = objRow[conzx_Viewpoint.zxViewpointId].ToString().Trim(); //观点Id
objzx_ViewpointEN.ViewpointName = objRow[conzx_Viewpoint.ViewpointName] == DBNull.Value ? null : objRow[conzx_Viewpoint.ViewpointName].ToString().Trim(); //观点名称
objzx_ViewpointEN.ViewpointContent = objRow[conzx_Viewpoint.ViewpointContent] == DBNull.Value ? null : objRow[conzx_Viewpoint.ViewpointContent].ToString().Trim(); //观点内容
objzx_ViewpointEN.zxViewpointTypeId = objRow[conzx_Viewpoint.zxViewpointTypeId] == DBNull.Value ? null : objRow[conzx_Viewpoint.zxViewpointTypeId].ToString().Trim(); //观点类型Id
objzx_ViewpointEN.Reason = objRow[conzx_Viewpoint.Reason] == DBNull.Value ? null : objRow[conzx_Viewpoint.Reason].ToString().Trim(); //理由
objzx_ViewpointEN.Source = objRow[conzx_Viewpoint.Source] == DBNull.Value ? null : objRow[conzx_Viewpoint.Source].ToString().Trim(); //来源
objzx_ViewpointEN.VPProposePeople = objRow[conzx_Viewpoint.VPProposePeople] == DBNull.Value ? null : objRow[conzx_Viewpoint.VPProposePeople].ToString().Trim(); //观点提出人
objzx_ViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Viewpoint.IsSubmit].ToString().Trim()); //是否提交
objzx_ViewpointEN.UserTypeId = objRow[conzx_Viewpoint.UserTypeId] == DBNull.Value ? null : objRow[conzx_Viewpoint.UserTypeId].ToString().Trim(); //用户类型Id
objzx_ViewpointEN.TextId = objRow[conzx_Viewpoint.TextId] == DBNull.Value ? null : objRow[conzx_Viewpoint.TextId].ToString().Trim(); //课件Id
objzx_ViewpointEN.VoteCount = objRow[conzx_Viewpoint.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.VoteCount].ToString().Trim()); //点赞计数
objzx_ViewpointEN.AppraiseCount = objRow[conzx_Viewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.AppraiseCount].ToString().Trim()); //评论数
objzx_ViewpointEN.Score = objRow[conzx_Viewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Viewpoint.Score].ToString().Trim()); //评分
objzx_ViewpointEN.StuScore = objRow[conzx_Viewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Viewpoint.StuScore].ToString().Trim()); //学生平均分
objzx_ViewpointEN.TeaScore = objRow[conzx_Viewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Viewpoint.TeaScore].ToString().Trim()); //教师评分
objzx_ViewpointEN.IdCurrEduCls = objRow[conzx_Viewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Viewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ViewpointEN.PdfContent = objRow[conzx_Viewpoint.PdfContent] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfContent].ToString().Trim(); //Pdf内容
objzx_ViewpointEN.PdfPageNum = objRow[conzx_Viewpoint.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ViewpointEN.CitationCount = objRow[conzx_Viewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.CitationCount].ToString().Trim()); //引用统计
objzx_ViewpointEN.VersionCount = objRow[conzx_Viewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.VersionCount].ToString().Trim()); //版本统计
objzx_ViewpointEN.zxShareId = objRow[conzx_Viewpoint.zxShareId] == DBNull.Value ? null : objRow[conzx_Viewpoint.zxShareId].ToString().Trim(); //分享Id
objzx_ViewpointEN.CreateDate = objRow[conzx_Viewpoint.CreateDate] == DBNull.Value ? null : objRow[conzx_Viewpoint.CreateDate].ToString().Trim(); //建立日期
objzx_ViewpointEN.UpdDate = objRow[conzx_Viewpoint.UpdDate] == DBNull.Value ? null : objRow[conzx_Viewpoint.UpdDate].ToString().Trim(); //修改日期
objzx_ViewpointEN.UpdUser = objRow[conzx_Viewpoint.UpdUser] == DBNull.Value ? null : objRow[conzx_Viewpoint.UpdUser].ToString().Trim(); //修改人
objzx_ViewpointEN.Memo = objRow[conzx_Viewpoint.Memo] == DBNull.Value ? null : objRow[conzx_Viewpoint.Memo].ToString().Trim(); //备注
objzx_ViewpointEN.TeammenberId = objRow[conzx_Viewpoint.TeammenberId] == DBNull.Value ? null : objRow[conzx_Viewpoint.TeammenberId].ToString().Trim(); //主键
objzx_ViewpointEN.PdfDivLet = objRow[conzx_Viewpoint.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ViewpointEN.PdfDivTop = objRow[conzx_Viewpoint.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ViewpointEN.PdfPageNumIn = objRow[conzx_Viewpoint.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ViewpointEN.PdfPageTop = objRow[conzx_Viewpoint.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ViewpointEN.PdfZoom = objRow[conzx_Viewpoint.PdfZoom] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ViewpointEN.GroupTextId = objRow[conzx_Viewpoint.GroupTextId] == DBNull.Value ? null : objRow[conzx_Viewpoint.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ViewpointEN.zxViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ViewpointEN);
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
public static List<clszx_ViewpointEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clszx_ViewpointEN> arrObjLst = new List<clszx_ViewpointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ViewpointEN objzx_ViewpointEN = new clszx_ViewpointEN();
try
{
objzx_ViewpointEN.zxViewpointId = objRow[conzx_Viewpoint.zxViewpointId].ToString().Trim(); //观点Id
objzx_ViewpointEN.ViewpointName = objRow[conzx_Viewpoint.ViewpointName] == DBNull.Value ? null : objRow[conzx_Viewpoint.ViewpointName].ToString().Trim(); //观点名称
objzx_ViewpointEN.ViewpointContent = objRow[conzx_Viewpoint.ViewpointContent] == DBNull.Value ? null : objRow[conzx_Viewpoint.ViewpointContent].ToString().Trim(); //观点内容
objzx_ViewpointEN.zxViewpointTypeId = objRow[conzx_Viewpoint.zxViewpointTypeId] == DBNull.Value ? null : objRow[conzx_Viewpoint.zxViewpointTypeId].ToString().Trim(); //观点类型Id
objzx_ViewpointEN.Reason = objRow[conzx_Viewpoint.Reason] == DBNull.Value ? null : objRow[conzx_Viewpoint.Reason].ToString().Trim(); //理由
objzx_ViewpointEN.Source = objRow[conzx_Viewpoint.Source] == DBNull.Value ? null : objRow[conzx_Viewpoint.Source].ToString().Trim(); //来源
objzx_ViewpointEN.VPProposePeople = objRow[conzx_Viewpoint.VPProposePeople] == DBNull.Value ? null : objRow[conzx_Viewpoint.VPProposePeople].ToString().Trim(); //观点提出人
objzx_ViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Viewpoint.IsSubmit].ToString().Trim()); //是否提交
objzx_ViewpointEN.UserTypeId = objRow[conzx_Viewpoint.UserTypeId] == DBNull.Value ? null : objRow[conzx_Viewpoint.UserTypeId].ToString().Trim(); //用户类型Id
objzx_ViewpointEN.TextId = objRow[conzx_Viewpoint.TextId] == DBNull.Value ? null : objRow[conzx_Viewpoint.TextId].ToString().Trim(); //课件Id
objzx_ViewpointEN.VoteCount = objRow[conzx_Viewpoint.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.VoteCount].ToString().Trim()); //点赞计数
objzx_ViewpointEN.AppraiseCount = objRow[conzx_Viewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.AppraiseCount].ToString().Trim()); //评论数
objzx_ViewpointEN.Score = objRow[conzx_Viewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Viewpoint.Score].ToString().Trim()); //评分
objzx_ViewpointEN.StuScore = objRow[conzx_Viewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Viewpoint.StuScore].ToString().Trim()); //学生平均分
objzx_ViewpointEN.TeaScore = objRow[conzx_Viewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Viewpoint.TeaScore].ToString().Trim()); //教师评分
objzx_ViewpointEN.IdCurrEduCls = objRow[conzx_Viewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Viewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ViewpointEN.PdfContent = objRow[conzx_Viewpoint.PdfContent] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfContent].ToString().Trim(); //Pdf内容
objzx_ViewpointEN.PdfPageNum = objRow[conzx_Viewpoint.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ViewpointEN.CitationCount = objRow[conzx_Viewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.CitationCount].ToString().Trim()); //引用统计
objzx_ViewpointEN.VersionCount = objRow[conzx_Viewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.VersionCount].ToString().Trim()); //版本统计
objzx_ViewpointEN.zxShareId = objRow[conzx_Viewpoint.zxShareId] == DBNull.Value ? null : objRow[conzx_Viewpoint.zxShareId].ToString().Trim(); //分享Id
objzx_ViewpointEN.CreateDate = objRow[conzx_Viewpoint.CreateDate] == DBNull.Value ? null : objRow[conzx_Viewpoint.CreateDate].ToString().Trim(); //建立日期
objzx_ViewpointEN.UpdDate = objRow[conzx_Viewpoint.UpdDate] == DBNull.Value ? null : objRow[conzx_Viewpoint.UpdDate].ToString().Trim(); //修改日期
objzx_ViewpointEN.UpdUser = objRow[conzx_Viewpoint.UpdUser] == DBNull.Value ? null : objRow[conzx_Viewpoint.UpdUser].ToString().Trim(); //修改人
objzx_ViewpointEN.Memo = objRow[conzx_Viewpoint.Memo] == DBNull.Value ? null : objRow[conzx_Viewpoint.Memo].ToString().Trim(); //备注
objzx_ViewpointEN.TeammenberId = objRow[conzx_Viewpoint.TeammenberId] == DBNull.Value ? null : objRow[conzx_Viewpoint.TeammenberId].ToString().Trim(); //主键
objzx_ViewpointEN.PdfDivLet = objRow[conzx_Viewpoint.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ViewpointEN.PdfDivTop = objRow[conzx_Viewpoint.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ViewpointEN.PdfPageNumIn = objRow[conzx_Viewpoint.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ViewpointEN.PdfPageTop = objRow[conzx_Viewpoint.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ViewpointEN.PdfZoom = objRow[conzx_Viewpoint.PdfZoom] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ViewpointEN.GroupTextId = objRow[conzx_Viewpoint.GroupTextId] == DBNull.Value ? null : objRow[conzx_Viewpoint.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ViewpointEN.zxViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ViewpointEN);
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
List<clszx_ViewpointEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clszx_ViewpointEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_ViewpointEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clszx_ViewpointEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clszx_ViewpointEN> arrObjLst = new List<clszx_ViewpointEN>(); 
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
	clszx_ViewpointEN objzx_ViewpointEN = new clszx_ViewpointEN();
try
{
objzx_ViewpointEN.zxViewpointId = objRow[conzx_Viewpoint.zxViewpointId].ToString().Trim(); //观点Id
objzx_ViewpointEN.ViewpointName = objRow[conzx_Viewpoint.ViewpointName] == DBNull.Value ? null : objRow[conzx_Viewpoint.ViewpointName].ToString().Trim(); //观点名称
objzx_ViewpointEN.ViewpointContent = objRow[conzx_Viewpoint.ViewpointContent] == DBNull.Value ? null : objRow[conzx_Viewpoint.ViewpointContent].ToString().Trim(); //观点内容
objzx_ViewpointEN.zxViewpointTypeId = objRow[conzx_Viewpoint.zxViewpointTypeId] == DBNull.Value ? null : objRow[conzx_Viewpoint.zxViewpointTypeId].ToString().Trim(); //观点类型Id
objzx_ViewpointEN.Reason = objRow[conzx_Viewpoint.Reason] == DBNull.Value ? null : objRow[conzx_Viewpoint.Reason].ToString().Trim(); //理由
objzx_ViewpointEN.Source = objRow[conzx_Viewpoint.Source] == DBNull.Value ? null : objRow[conzx_Viewpoint.Source].ToString().Trim(); //来源
objzx_ViewpointEN.VPProposePeople = objRow[conzx_Viewpoint.VPProposePeople] == DBNull.Value ? null : objRow[conzx_Viewpoint.VPProposePeople].ToString().Trim(); //观点提出人
objzx_ViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Viewpoint.IsSubmit].ToString().Trim()); //是否提交
objzx_ViewpointEN.UserTypeId = objRow[conzx_Viewpoint.UserTypeId] == DBNull.Value ? null : objRow[conzx_Viewpoint.UserTypeId].ToString().Trim(); //用户类型Id
objzx_ViewpointEN.TextId = objRow[conzx_Viewpoint.TextId] == DBNull.Value ? null : objRow[conzx_Viewpoint.TextId].ToString().Trim(); //课件Id
objzx_ViewpointEN.VoteCount = objRow[conzx_Viewpoint.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.VoteCount].ToString().Trim()); //点赞计数
objzx_ViewpointEN.AppraiseCount = objRow[conzx_Viewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.AppraiseCount].ToString().Trim()); //评论数
objzx_ViewpointEN.Score = objRow[conzx_Viewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Viewpoint.Score].ToString().Trim()); //评分
objzx_ViewpointEN.StuScore = objRow[conzx_Viewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Viewpoint.StuScore].ToString().Trim()); //学生平均分
objzx_ViewpointEN.TeaScore = objRow[conzx_Viewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Viewpoint.TeaScore].ToString().Trim()); //教师评分
objzx_ViewpointEN.IdCurrEduCls = objRow[conzx_Viewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Viewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ViewpointEN.PdfContent = objRow[conzx_Viewpoint.PdfContent] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfContent].ToString().Trim(); //Pdf内容
objzx_ViewpointEN.PdfPageNum = objRow[conzx_Viewpoint.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ViewpointEN.CitationCount = objRow[conzx_Viewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.CitationCount].ToString().Trim()); //引用统计
objzx_ViewpointEN.VersionCount = objRow[conzx_Viewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.VersionCount].ToString().Trim()); //版本统计
objzx_ViewpointEN.zxShareId = objRow[conzx_Viewpoint.zxShareId] == DBNull.Value ? null : objRow[conzx_Viewpoint.zxShareId].ToString().Trim(); //分享Id
objzx_ViewpointEN.CreateDate = objRow[conzx_Viewpoint.CreateDate] == DBNull.Value ? null : objRow[conzx_Viewpoint.CreateDate].ToString().Trim(); //建立日期
objzx_ViewpointEN.UpdDate = objRow[conzx_Viewpoint.UpdDate] == DBNull.Value ? null : objRow[conzx_Viewpoint.UpdDate].ToString().Trim(); //修改日期
objzx_ViewpointEN.UpdUser = objRow[conzx_Viewpoint.UpdUser] == DBNull.Value ? null : objRow[conzx_Viewpoint.UpdUser].ToString().Trim(); //修改人
objzx_ViewpointEN.Memo = objRow[conzx_Viewpoint.Memo] == DBNull.Value ? null : objRow[conzx_Viewpoint.Memo].ToString().Trim(); //备注
objzx_ViewpointEN.TeammenberId = objRow[conzx_Viewpoint.TeammenberId] == DBNull.Value ? null : objRow[conzx_Viewpoint.TeammenberId].ToString().Trim(); //主键
objzx_ViewpointEN.PdfDivLet = objRow[conzx_Viewpoint.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ViewpointEN.PdfDivTop = objRow[conzx_Viewpoint.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ViewpointEN.PdfPageNumIn = objRow[conzx_Viewpoint.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ViewpointEN.PdfPageTop = objRow[conzx_Viewpoint.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ViewpointEN.PdfZoom = objRow[conzx_Viewpoint.PdfZoom] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ViewpointEN.GroupTextId = objRow[conzx_Viewpoint.GroupTextId] == DBNull.Value ? null : objRow[conzx_Viewpoint.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ViewpointEN.zxViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ViewpointEN);
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
public static List<clszx_ViewpointEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clszx_ViewpointEN> arrObjLst = new List<clszx_ViewpointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ViewpointEN objzx_ViewpointEN = new clszx_ViewpointEN();
try
{
objzx_ViewpointEN.zxViewpointId = objRow[conzx_Viewpoint.zxViewpointId].ToString().Trim(); //观点Id
objzx_ViewpointEN.ViewpointName = objRow[conzx_Viewpoint.ViewpointName] == DBNull.Value ? null : objRow[conzx_Viewpoint.ViewpointName].ToString().Trim(); //观点名称
objzx_ViewpointEN.ViewpointContent = objRow[conzx_Viewpoint.ViewpointContent] == DBNull.Value ? null : objRow[conzx_Viewpoint.ViewpointContent].ToString().Trim(); //观点内容
objzx_ViewpointEN.zxViewpointTypeId = objRow[conzx_Viewpoint.zxViewpointTypeId] == DBNull.Value ? null : objRow[conzx_Viewpoint.zxViewpointTypeId].ToString().Trim(); //观点类型Id
objzx_ViewpointEN.Reason = objRow[conzx_Viewpoint.Reason] == DBNull.Value ? null : objRow[conzx_Viewpoint.Reason].ToString().Trim(); //理由
objzx_ViewpointEN.Source = objRow[conzx_Viewpoint.Source] == DBNull.Value ? null : objRow[conzx_Viewpoint.Source].ToString().Trim(); //来源
objzx_ViewpointEN.VPProposePeople = objRow[conzx_Viewpoint.VPProposePeople] == DBNull.Value ? null : objRow[conzx_Viewpoint.VPProposePeople].ToString().Trim(); //观点提出人
objzx_ViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Viewpoint.IsSubmit].ToString().Trim()); //是否提交
objzx_ViewpointEN.UserTypeId = objRow[conzx_Viewpoint.UserTypeId] == DBNull.Value ? null : objRow[conzx_Viewpoint.UserTypeId].ToString().Trim(); //用户类型Id
objzx_ViewpointEN.TextId = objRow[conzx_Viewpoint.TextId] == DBNull.Value ? null : objRow[conzx_Viewpoint.TextId].ToString().Trim(); //课件Id
objzx_ViewpointEN.VoteCount = objRow[conzx_Viewpoint.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.VoteCount].ToString().Trim()); //点赞计数
objzx_ViewpointEN.AppraiseCount = objRow[conzx_Viewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.AppraiseCount].ToString().Trim()); //评论数
objzx_ViewpointEN.Score = objRow[conzx_Viewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Viewpoint.Score].ToString().Trim()); //评分
objzx_ViewpointEN.StuScore = objRow[conzx_Viewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Viewpoint.StuScore].ToString().Trim()); //学生平均分
objzx_ViewpointEN.TeaScore = objRow[conzx_Viewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Viewpoint.TeaScore].ToString().Trim()); //教师评分
objzx_ViewpointEN.IdCurrEduCls = objRow[conzx_Viewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Viewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ViewpointEN.PdfContent = objRow[conzx_Viewpoint.PdfContent] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfContent].ToString().Trim(); //Pdf内容
objzx_ViewpointEN.PdfPageNum = objRow[conzx_Viewpoint.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ViewpointEN.CitationCount = objRow[conzx_Viewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.CitationCount].ToString().Trim()); //引用统计
objzx_ViewpointEN.VersionCount = objRow[conzx_Viewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.VersionCount].ToString().Trim()); //版本统计
objzx_ViewpointEN.zxShareId = objRow[conzx_Viewpoint.zxShareId] == DBNull.Value ? null : objRow[conzx_Viewpoint.zxShareId].ToString().Trim(); //分享Id
objzx_ViewpointEN.CreateDate = objRow[conzx_Viewpoint.CreateDate] == DBNull.Value ? null : objRow[conzx_Viewpoint.CreateDate].ToString().Trim(); //建立日期
objzx_ViewpointEN.UpdDate = objRow[conzx_Viewpoint.UpdDate] == DBNull.Value ? null : objRow[conzx_Viewpoint.UpdDate].ToString().Trim(); //修改日期
objzx_ViewpointEN.UpdUser = objRow[conzx_Viewpoint.UpdUser] == DBNull.Value ? null : objRow[conzx_Viewpoint.UpdUser].ToString().Trim(); //修改人
objzx_ViewpointEN.Memo = objRow[conzx_Viewpoint.Memo] == DBNull.Value ? null : objRow[conzx_Viewpoint.Memo].ToString().Trim(); //备注
objzx_ViewpointEN.TeammenberId = objRow[conzx_Viewpoint.TeammenberId] == DBNull.Value ? null : objRow[conzx_Viewpoint.TeammenberId].ToString().Trim(); //主键
objzx_ViewpointEN.PdfDivLet = objRow[conzx_Viewpoint.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ViewpointEN.PdfDivTop = objRow[conzx_Viewpoint.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ViewpointEN.PdfPageNumIn = objRow[conzx_Viewpoint.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ViewpointEN.PdfPageTop = objRow[conzx_Viewpoint.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ViewpointEN.PdfZoom = objRow[conzx_Viewpoint.PdfZoom] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ViewpointEN.GroupTextId = objRow[conzx_Viewpoint.GroupTextId] == DBNull.Value ? null : objRow[conzx_Viewpoint.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ViewpointEN.zxViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ViewpointEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clszx_ViewpointEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clszx_ViewpointEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clszx_ViewpointEN> arrObjLst = new List<clszx_ViewpointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ViewpointEN objzx_ViewpointEN = new clszx_ViewpointEN();
try
{
objzx_ViewpointEN.zxViewpointId = objRow[conzx_Viewpoint.zxViewpointId].ToString().Trim(); //观点Id
objzx_ViewpointEN.ViewpointName = objRow[conzx_Viewpoint.ViewpointName] == DBNull.Value ? null : objRow[conzx_Viewpoint.ViewpointName].ToString().Trim(); //观点名称
objzx_ViewpointEN.ViewpointContent = objRow[conzx_Viewpoint.ViewpointContent] == DBNull.Value ? null : objRow[conzx_Viewpoint.ViewpointContent].ToString().Trim(); //观点内容
objzx_ViewpointEN.zxViewpointTypeId = objRow[conzx_Viewpoint.zxViewpointTypeId] == DBNull.Value ? null : objRow[conzx_Viewpoint.zxViewpointTypeId].ToString().Trim(); //观点类型Id
objzx_ViewpointEN.Reason = objRow[conzx_Viewpoint.Reason] == DBNull.Value ? null : objRow[conzx_Viewpoint.Reason].ToString().Trim(); //理由
objzx_ViewpointEN.Source = objRow[conzx_Viewpoint.Source] == DBNull.Value ? null : objRow[conzx_Viewpoint.Source].ToString().Trim(); //来源
objzx_ViewpointEN.VPProposePeople = objRow[conzx_Viewpoint.VPProposePeople] == DBNull.Value ? null : objRow[conzx_Viewpoint.VPProposePeople].ToString().Trim(); //观点提出人
objzx_ViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Viewpoint.IsSubmit].ToString().Trim()); //是否提交
objzx_ViewpointEN.UserTypeId = objRow[conzx_Viewpoint.UserTypeId] == DBNull.Value ? null : objRow[conzx_Viewpoint.UserTypeId].ToString().Trim(); //用户类型Id
objzx_ViewpointEN.TextId = objRow[conzx_Viewpoint.TextId] == DBNull.Value ? null : objRow[conzx_Viewpoint.TextId].ToString().Trim(); //课件Id
objzx_ViewpointEN.VoteCount = objRow[conzx_Viewpoint.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.VoteCount].ToString().Trim()); //点赞计数
objzx_ViewpointEN.AppraiseCount = objRow[conzx_Viewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.AppraiseCount].ToString().Trim()); //评论数
objzx_ViewpointEN.Score = objRow[conzx_Viewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Viewpoint.Score].ToString().Trim()); //评分
objzx_ViewpointEN.StuScore = objRow[conzx_Viewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Viewpoint.StuScore].ToString().Trim()); //学生平均分
objzx_ViewpointEN.TeaScore = objRow[conzx_Viewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Viewpoint.TeaScore].ToString().Trim()); //教师评分
objzx_ViewpointEN.IdCurrEduCls = objRow[conzx_Viewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Viewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ViewpointEN.PdfContent = objRow[conzx_Viewpoint.PdfContent] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfContent].ToString().Trim(); //Pdf内容
objzx_ViewpointEN.PdfPageNum = objRow[conzx_Viewpoint.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ViewpointEN.CitationCount = objRow[conzx_Viewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.CitationCount].ToString().Trim()); //引用统计
objzx_ViewpointEN.VersionCount = objRow[conzx_Viewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.VersionCount].ToString().Trim()); //版本统计
objzx_ViewpointEN.zxShareId = objRow[conzx_Viewpoint.zxShareId] == DBNull.Value ? null : objRow[conzx_Viewpoint.zxShareId].ToString().Trim(); //分享Id
objzx_ViewpointEN.CreateDate = objRow[conzx_Viewpoint.CreateDate] == DBNull.Value ? null : objRow[conzx_Viewpoint.CreateDate].ToString().Trim(); //建立日期
objzx_ViewpointEN.UpdDate = objRow[conzx_Viewpoint.UpdDate] == DBNull.Value ? null : objRow[conzx_Viewpoint.UpdDate].ToString().Trim(); //修改日期
objzx_ViewpointEN.UpdUser = objRow[conzx_Viewpoint.UpdUser] == DBNull.Value ? null : objRow[conzx_Viewpoint.UpdUser].ToString().Trim(); //修改人
objzx_ViewpointEN.Memo = objRow[conzx_Viewpoint.Memo] == DBNull.Value ? null : objRow[conzx_Viewpoint.Memo].ToString().Trim(); //备注
objzx_ViewpointEN.TeammenberId = objRow[conzx_Viewpoint.TeammenberId] == DBNull.Value ? null : objRow[conzx_Viewpoint.TeammenberId].ToString().Trim(); //主键
objzx_ViewpointEN.PdfDivLet = objRow[conzx_Viewpoint.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ViewpointEN.PdfDivTop = objRow[conzx_Viewpoint.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ViewpointEN.PdfPageNumIn = objRow[conzx_Viewpoint.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ViewpointEN.PdfPageTop = objRow[conzx_Viewpoint.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ViewpointEN.PdfZoom = objRow[conzx_Viewpoint.PdfZoom] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ViewpointEN.GroupTextId = objRow[conzx_Viewpoint.GroupTextId] == DBNull.Value ? null : objRow[conzx_Viewpoint.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ViewpointEN.zxViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ViewpointEN);
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
public static List<clszx_ViewpointEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clszx_ViewpointEN> arrObjLst = new List<clszx_ViewpointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ViewpointEN objzx_ViewpointEN = new clszx_ViewpointEN();
try
{
objzx_ViewpointEN.zxViewpointId = objRow[conzx_Viewpoint.zxViewpointId].ToString().Trim(); //观点Id
objzx_ViewpointEN.ViewpointName = objRow[conzx_Viewpoint.ViewpointName] == DBNull.Value ? null : objRow[conzx_Viewpoint.ViewpointName].ToString().Trim(); //观点名称
objzx_ViewpointEN.ViewpointContent = objRow[conzx_Viewpoint.ViewpointContent] == DBNull.Value ? null : objRow[conzx_Viewpoint.ViewpointContent].ToString().Trim(); //观点内容
objzx_ViewpointEN.zxViewpointTypeId = objRow[conzx_Viewpoint.zxViewpointTypeId] == DBNull.Value ? null : objRow[conzx_Viewpoint.zxViewpointTypeId].ToString().Trim(); //观点类型Id
objzx_ViewpointEN.Reason = objRow[conzx_Viewpoint.Reason] == DBNull.Value ? null : objRow[conzx_Viewpoint.Reason].ToString().Trim(); //理由
objzx_ViewpointEN.Source = objRow[conzx_Viewpoint.Source] == DBNull.Value ? null : objRow[conzx_Viewpoint.Source].ToString().Trim(); //来源
objzx_ViewpointEN.VPProposePeople = objRow[conzx_Viewpoint.VPProposePeople] == DBNull.Value ? null : objRow[conzx_Viewpoint.VPProposePeople].ToString().Trim(); //观点提出人
objzx_ViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Viewpoint.IsSubmit].ToString().Trim()); //是否提交
objzx_ViewpointEN.UserTypeId = objRow[conzx_Viewpoint.UserTypeId] == DBNull.Value ? null : objRow[conzx_Viewpoint.UserTypeId].ToString().Trim(); //用户类型Id
objzx_ViewpointEN.TextId = objRow[conzx_Viewpoint.TextId] == DBNull.Value ? null : objRow[conzx_Viewpoint.TextId].ToString().Trim(); //课件Id
objzx_ViewpointEN.VoteCount = objRow[conzx_Viewpoint.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.VoteCount].ToString().Trim()); //点赞计数
objzx_ViewpointEN.AppraiseCount = objRow[conzx_Viewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.AppraiseCount].ToString().Trim()); //评论数
objzx_ViewpointEN.Score = objRow[conzx_Viewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Viewpoint.Score].ToString().Trim()); //评分
objzx_ViewpointEN.StuScore = objRow[conzx_Viewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Viewpoint.StuScore].ToString().Trim()); //学生平均分
objzx_ViewpointEN.TeaScore = objRow[conzx_Viewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Viewpoint.TeaScore].ToString().Trim()); //教师评分
objzx_ViewpointEN.IdCurrEduCls = objRow[conzx_Viewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Viewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ViewpointEN.PdfContent = objRow[conzx_Viewpoint.PdfContent] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfContent].ToString().Trim(); //Pdf内容
objzx_ViewpointEN.PdfPageNum = objRow[conzx_Viewpoint.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ViewpointEN.CitationCount = objRow[conzx_Viewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.CitationCount].ToString().Trim()); //引用统计
objzx_ViewpointEN.VersionCount = objRow[conzx_Viewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.VersionCount].ToString().Trim()); //版本统计
objzx_ViewpointEN.zxShareId = objRow[conzx_Viewpoint.zxShareId] == DBNull.Value ? null : objRow[conzx_Viewpoint.zxShareId].ToString().Trim(); //分享Id
objzx_ViewpointEN.CreateDate = objRow[conzx_Viewpoint.CreateDate] == DBNull.Value ? null : objRow[conzx_Viewpoint.CreateDate].ToString().Trim(); //建立日期
objzx_ViewpointEN.UpdDate = objRow[conzx_Viewpoint.UpdDate] == DBNull.Value ? null : objRow[conzx_Viewpoint.UpdDate].ToString().Trim(); //修改日期
objzx_ViewpointEN.UpdUser = objRow[conzx_Viewpoint.UpdUser] == DBNull.Value ? null : objRow[conzx_Viewpoint.UpdUser].ToString().Trim(); //修改人
objzx_ViewpointEN.Memo = objRow[conzx_Viewpoint.Memo] == DBNull.Value ? null : objRow[conzx_Viewpoint.Memo].ToString().Trim(); //备注
objzx_ViewpointEN.TeammenberId = objRow[conzx_Viewpoint.TeammenberId] == DBNull.Value ? null : objRow[conzx_Viewpoint.TeammenberId].ToString().Trim(); //主键
objzx_ViewpointEN.PdfDivLet = objRow[conzx_Viewpoint.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ViewpointEN.PdfDivTop = objRow[conzx_Viewpoint.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ViewpointEN.PdfPageNumIn = objRow[conzx_Viewpoint.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ViewpointEN.PdfPageTop = objRow[conzx_Viewpoint.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ViewpointEN.PdfZoom = objRow[conzx_Viewpoint.PdfZoom] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ViewpointEN.GroupTextId = objRow[conzx_Viewpoint.GroupTextId] == DBNull.Value ? null : objRow[conzx_Viewpoint.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ViewpointEN.zxViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ViewpointEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_ViewpointEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clszx_ViewpointEN> arrObjLst = new List<clszx_ViewpointEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ViewpointEN objzx_ViewpointEN = new clszx_ViewpointEN();
try
{
objzx_ViewpointEN.zxViewpointId = objRow[conzx_Viewpoint.zxViewpointId].ToString().Trim(); //观点Id
objzx_ViewpointEN.ViewpointName = objRow[conzx_Viewpoint.ViewpointName] == DBNull.Value ? null : objRow[conzx_Viewpoint.ViewpointName].ToString().Trim(); //观点名称
objzx_ViewpointEN.ViewpointContent = objRow[conzx_Viewpoint.ViewpointContent] == DBNull.Value ? null : objRow[conzx_Viewpoint.ViewpointContent].ToString().Trim(); //观点内容
objzx_ViewpointEN.zxViewpointTypeId = objRow[conzx_Viewpoint.zxViewpointTypeId] == DBNull.Value ? null : objRow[conzx_Viewpoint.zxViewpointTypeId].ToString().Trim(); //观点类型Id
objzx_ViewpointEN.Reason = objRow[conzx_Viewpoint.Reason] == DBNull.Value ? null : objRow[conzx_Viewpoint.Reason].ToString().Trim(); //理由
objzx_ViewpointEN.Source = objRow[conzx_Viewpoint.Source] == DBNull.Value ? null : objRow[conzx_Viewpoint.Source].ToString().Trim(); //来源
objzx_ViewpointEN.VPProposePeople = objRow[conzx_Viewpoint.VPProposePeople] == DBNull.Value ? null : objRow[conzx_Viewpoint.VPProposePeople].ToString().Trim(); //观点提出人
objzx_ViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Viewpoint.IsSubmit].ToString().Trim()); //是否提交
objzx_ViewpointEN.UserTypeId = objRow[conzx_Viewpoint.UserTypeId] == DBNull.Value ? null : objRow[conzx_Viewpoint.UserTypeId].ToString().Trim(); //用户类型Id
objzx_ViewpointEN.TextId = objRow[conzx_Viewpoint.TextId] == DBNull.Value ? null : objRow[conzx_Viewpoint.TextId].ToString().Trim(); //课件Id
objzx_ViewpointEN.VoteCount = objRow[conzx_Viewpoint.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.VoteCount].ToString().Trim()); //点赞计数
objzx_ViewpointEN.AppraiseCount = objRow[conzx_Viewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.AppraiseCount].ToString().Trim()); //评论数
objzx_ViewpointEN.Score = objRow[conzx_Viewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Viewpoint.Score].ToString().Trim()); //评分
objzx_ViewpointEN.StuScore = objRow[conzx_Viewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Viewpoint.StuScore].ToString().Trim()); //学生平均分
objzx_ViewpointEN.TeaScore = objRow[conzx_Viewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Viewpoint.TeaScore].ToString().Trim()); //教师评分
objzx_ViewpointEN.IdCurrEduCls = objRow[conzx_Viewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Viewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ViewpointEN.PdfContent = objRow[conzx_Viewpoint.PdfContent] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfContent].ToString().Trim(); //Pdf内容
objzx_ViewpointEN.PdfPageNum = objRow[conzx_Viewpoint.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ViewpointEN.CitationCount = objRow[conzx_Viewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.CitationCount].ToString().Trim()); //引用统计
objzx_ViewpointEN.VersionCount = objRow[conzx_Viewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.VersionCount].ToString().Trim()); //版本统计
objzx_ViewpointEN.zxShareId = objRow[conzx_Viewpoint.zxShareId] == DBNull.Value ? null : objRow[conzx_Viewpoint.zxShareId].ToString().Trim(); //分享Id
objzx_ViewpointEN.CreateDate = objRow[conzx_Viewpoint.CreateDate] == DBNull.Value ? null : objRow[conzx_Viewpoint.CreateDate].ToString().Trim(); //建立日期
objzx_ViewpointEN.UpdDate = objRow[conzx_Viewpoint.UpdDate] == DBNull.Value ? null : objRow[conzx_Viewpoint.UpdDate].ToString().Trim(); //修改日期
objzx_ViewpointEN.UpdUser = objRow[conzx_Viewpoint.UpdUser] == DBNull.Value ? null : objRow[conzx_Viewpoint.UpdUser].ToString().Trim(); //修改人
objzx_ViewpointEN.Memo = objRow[conzx_Viewpoint.Memo] == DBNull.Value ? null : objRow[conzx_Viewpoint.Memo].ToString().Trim(); //备注
objzx_ViewpointEN.TeammenberId = objRow[conzx_Viewpoint.TeammenberId] == DBNull.Value ? null : objRow[conzx_Viewpoint.TeammenberId].ToString().Trim(); //主键
objzx_ViewpointEN.PdfDivLet = objRow[conzx_Viewpoint.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ViewpointEN.PdfDivTop = objRow[conzx_Viewpoint.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ViewpointEN.PdfPageNumIn = objRow[conzx_Viewpoint.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ViewpointEN.PdfPageTop = objRow[conzx_Viewpoint.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ViewpointEN.PdfZoom = objRow[conzx_Viewpoint.PdfZoom] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ViewpointEN.GroupTextId = objRow[conzx_Viewpoint.GroupTextId] == DBNull.Value ? null : objRow[conzx_Viewpoint.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ViewpointEN.zxViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ViewpointEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objzx_ViewpointEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getzx_Viewpoint(ref clszx_ViewpointEN objzx_ViewpointEN)
{
bool bolResult = zx_ViewpointDA.Getzx_Viewpoint(ref objzx_ViewpointEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strzxViewpointId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_ViewpointEN GetObjByzxViewpointId(string strzxViewpointId)
{
if (strzxViewpointId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strzxViewpointId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strzxViewpointId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strzxViewpointId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clszx_ViewpointEN objzx_ViewpointEN = zx_ViewpointDA.GetObjByzxViewpointId(strzxViewpointId);
return objzx_ViewpointEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clszx_ViewpointEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clszx_ViewpointEN objzx_ViewpointEN = zx_ViewpointDA.GetFirstObj(strWhereCond);
 return objzx_ViewpointEN;
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
public static clszx_ViewpointEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clszx_ViewpointEN objzx_ViewpointEN = zx_ViewpointDA.GetObjByDataRow(objRow);
 return objzx_ViewpointEN;
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
public static clszx_ViewpointEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clszx_ViewpointEN objzx_ViewpointEN = zx_ViewpointDA.GetObjByDataRow(objRow);
 return objzx_ViewpointEN;
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
 /// <param name = "strzxViewpointId">所给的关键字</param>
 /// <param name = "lstzx_ViewpointObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_ViewpointEN GetObjByzxViewpointIdFromList(string strzxViewpointId, List<clszx_ViewpointEN> lstzx_ViewpointObjLst)
{
foreach (clszx_ViewpointEN objzx_ViewpointEN in lstzx_ViewpointObjLst)
{
if (objzx_ViewpointEN.zxViewpointId == strzxViewpointId)
{
return objzx_ViewpointEN;
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
 string strMaxZxViewpointId;
 try
 {
 strMaxZxViewpointId = clszx_ViewpointDA.GetMaxStrId();
 return strMaxZxViewpointId;
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
 string strzxViewpointId;
 try
 {
 strzxViewpointId = new clszx_ViewpointDA().GetFirstID(strWhereCond);
 return strzxViewpointId;
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
 arrList = zx_ViewpointDA.GetID(strWhereCond);
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
bool bolIsExist = zx_ViewpointDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strzxViewpointId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strzxViewpointId)
{
if (string.IsNullOrEmpty(strzxViewpointId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strzxViewpointId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = zx_ViewpointDA.IsExist(strzxViewpointId);
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
 bolIsExist = clszx_ViewpointDA.IsExistTable();
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
 bolIsExist = zx_ViewpointDA.IsExistTable(strTabName);
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
 /// <param name = "objzx_ViewpointEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clszx_ViewpointEN objzx_ViewpointEN)
{
if (objzx_ViewpointEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!观点Id = [{0}],课件Id = [{1}]的数据已经存在!(in clszx_ViewpointBL.AddNewRecordBySql2)", objzx_ViewpointEN.zxViewpointId,objzx_ViewpointEN.TextId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_ViewpointEN.zxViewpointId) == true || clszx_ViewpointBL.IsExist(objzx_ViewpointEN.zxViewpointId) == true)
 {
     objzx_ViewpointEN.zxViewpointId = clszx_ViewpointBL.GetMaxStrId_S();
 }
bool bolResult = zx_ViewpointDA.AddNewRecordBySQL2(objzx_ViewpointEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewpointBL.ReFreshCache(objzx_ViewpointEN.IdCurrEduCls);

if (clszx_ViewpointBL.relatedActions != null)
{
clszx_ViewpointBL.relatedActions.UpdRelaTabDate(objzx_ViewpointEN.zxViewpointId, "SetUpdDate");
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
 /// <param name = "objzx_ViewpointEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clszx_ViewpointEN objzx_ViewpointEN)
{
if (objzx_ViewpointEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!观点Id = [{0}],课件Id = [{1}]的数据已经存在!(in clszx_ViewpointBL.AddNewRecordBySql2WithReturnKey)", objzx_ViewpointEN.zxViewpointId,objzx_ViewpointEN.TextId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_ViewpointEN.zxViewpointId) == true || clszx_ViewpointBL.IsExist(objzx_ViewpointEN.zxViewpointId) == true)
 {
     objzx_ViewpointEN.zxViewpointId = clszx_ViewpointBL.GetMaxStrId_S();
 }
string strKey = zx_ViewpointDA.AddNewRecordBySQL2WithReturnKey(objzx_ViewpointEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewpointBL.ReFreshCache(objzx_ViewpointEN.IdCurrEduCls);

if (clszx_ViewpointBL.relatedActions != null)
{
clszx_ViewpointBL.relatedActions.UpdRelaTabDate(objzx_ViewpointEN.zxViewpointId, "SetUpdDate");
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
 /// <param name = "objzx_ViewpointEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clszx_ViewpointEN objzx_ViewpointEN)
{
try
{
bool bolResult = zx_ViewpointDA.Update(objzx_ViewpointEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewpointBL.ReFreshCache(objzx_ViewpointEN.IdCurrEduCls);

if (clszx_ViewpointBL.relatedActions != null)
{
clszx_ViewpointBL.relatedActions.UpdRelaTabDate(objzx_ViewpointEN.zxViewpointId, "SetUpdDate");
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
 /// <param name = "objzx_ViewpointEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clszx_ViewpointEN objzx_ViewpointEN)
{
 if (string.IsNullOrEmpty(objzx_ViewpointEN.zxViewpointId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = zx_ViewpointDA.UpdateBySql2(objzx_ViewpointEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewpointBL.ReFreshCache(objzx_ViewpointEN.IdCurrEduCls);

if (clszx_ViewpointBL.relatedActions != null)
{
clszx_ViewpointBL.relatedActions.UpdRelaTabDate(objzx_ViewpointEN.zxViewpointId, "SetUpdDate");
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
 /// <param name = "strzxViewpointId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strzxViewpointId)
{
try
{
 clszx_ViewpointEN objzx_ViewpointEN = clszx_ViewpointBL.GetObjByzxViewpointId(strzxViewpointId);

if (clszx_ViewpointBL.relatedActions != null)
{
clszx_ViewpointBL.relatedActions.UpdRelaTabDate(objzx_ViewpointEN.zxViewpointId, "SetUpdDate");
}
if (objzx_ViewpointEN != null)
{
int intRecNum = zx_ViewpointDA.DelRecord(strzxViewpointId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objzx_ViewpointEN.IdCurrEduCls);
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
/// <param name="strzxViewpointId">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strzxViewpointId , string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_ViewpointDA.GetSpecSQLObj();
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
//删除与表:[zx_Viewpoint]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conzx_Viewpoint.zxViewpointId,
//strzxViewpointId);
//        clszx_ViewpointBL.Delzx_ViewpointsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_ViewpointBL.DelRecord(strzxViewpointId, strIdCurrEduCls, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_ViewpointBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strzxViewpointId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strzxViewpointId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strzxViewpointId, string strIdCurrEduCls, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clszx_ViewpointBL.relatedActions != null)
{
clszx_ViewpointBL.relatedActions.UpdRelaTabDate(strzxViewpointId, "UpdRelaTabDate");
}
bool bolResult = zx_ViewpointDA.DelRecord(strzxViewpointId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrzxViewpointIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delzx_Viewpoints(List<string> arrzxViewpointIdLst)
{
if (arrzxViewpointIdLst.Count == 0) return 0;
try
{
if (clszx_ViewpointBL.relatedActions != null)
{
foreach (var strzxViewpointId in arrzxViewpointIdLst)
{
clszx_ViewpointBL.relatedActions.UpdRelaTabDate(strzxViewpointId, "UpdRelaTabDate");
}
}
 clszx_ViewpointEN objzx_ViewpointEN = clszx_ViewpointBL.GetObjByzxViewpointId(arrzxViewpointIdLst[0]);
int intDelRecNum = zx_ViewpointDA.Delzx_Viewpoint(arrzxViewpointIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objzx_ViewpointEN.IdCurrEduCls);
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
public static int Delzx_ViewpointsByCond(string strWhereCond)
{
try
{
if (clszx_ViewpointBL.relatedActions != null)
{
List<string> arrzxViewpointId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strzxViewpointId in arrzxViewpointId)
{
clszx_ViewpointBL.relatedActions.UpdRelaTabDate(strzxViewpointId, "UpdRelaTabDate");
}
}
List<string> arrIdCurrEduCls = GetFldValue(conzx_Viewpoint.IdCurrEduCls, strWhereCond);
int intRecNum = zx_ViewpointDA.Delzx_Viewpoint(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[zx_Viewpoint]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strzxViewpointId">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strzxViewpointId, string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_ViewpointDA.GetSpecSQLObj();
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
//删除与表:[zx_Viewpoint]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_ViewpointBL.DelRecord(strzxViewpointId, strIdCurrEduCls, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_ViewpointBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strzxViewpointId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objzx_ViewpointENS">源对象</param>
 /// <param name = "objzx_ViewpointENT">目标对象</param>
 public static void CopyTo(clszx_ViewpointEN objzx_ViewpointENS, clszx_ViewpointEN objzx_ViewpointENT)
{
try
{
objzx_ViewpointENT.zxViewpointId = objzx_ViewpointENS.zxViewpointId; //观点Id
objzx_ViewpointENT.ViewpointName = objzx_ViewpointENS.ViewpointName; //观点名称
objzx_ViewpointENT.ViewpointContent = objzx_ViewpointENS.ViewpointContent; //观点内容
objzx_ViewpointENT.zxViewpointTypeId = objzx_ViewpointENS.zxViewpointTypeId; //观点类型Id
objzx_ViewpointENT.Reason = objzx_ViewpointENS.Reason; //理由
objzx_ViewpointENT.Source = objzx_ViewpointENS.Source; //来源
objzx_ViewpointENT.VPProposePeople = objzx_ViewpointENS.VPProposePeople; //观点提出人
objzx_ViewpointENT.IsSubmit = objzx_ViewpointENS.IsSubmit; //是否提交
objzx_ViewpointENT.UserTypeId = objzx_ViewpointENS.UserTypeId; //用户类型Id
objzx_ViewpointENT.TextId = objzx_ViewpointENS.TextId; //课件Id
objzx_ViewpointENT.VoteCount = objzx_ViewpointENS.VoteCount; //点赞计数
objzx_ViewpointENT.AppraiseCount = objzx_ViewpointENS.AppraiseCount; //评论数
objzx_ViewpointENT.Score = objzx_ViewpointENS.Score; //评分
objzx_ViewpointENT.StuScore = objzx_ViewpointENS.StuScore; //学生平均分
objzx_ViewpointENT.TeaScore = objzx_ViewpointENS.TeaScore; //教师评分
objzx_ViewpointENT.IdCurrEduCls = objzx_ViewpointENS.IdCurrEduCls; //教学班流水号
objzx_ViewpointENT.PdfContent = objzx_ViewpointENS.PdfContent; //Pdf内容
objzx_ViewpointENT.PdfPageNum = objzx_ViewpointENS.PdfPageNum; //Pdf页码
objzx_ViewpointENT.CitationCount = objzx_ViewpointENS.CitationCount; //引用统计
objzx_ViewpointENT.VersionCount = objzx_ViewpointENS.VersionCount; //版本统计
objzx_ViewpointENT.zxShareId = objzx_ViewpointENS.zxShareId; //分享Id
objzx_ViewpointENT.CreateDate = objzx_ViewpointENS.CreateDate; //建立日期
objzx_ViewpointENT.UpdDate = objzx_ViewpointENS.UpdDate; //修改日期
objzx_ViewpointENT.UpdUser = objzx_ViewpointENS.UpdUser; //修改人
objzx_ViewpointENT.Memo = objzx_ViewpointENS.Memo; //备注
objzx_ViewpointENT.TeammenberId = objzx_ViewpointENS.TeammenberId; //主键
objzx_ViewpointENT.PdfDivLet = objzx_ViewpointENS.PdfDivLet; //PdfDivLet
objzx_ViewpointENT.PdfDivTop = objzx_ViewpointENS.PdfDivTop; //PdfDivTop
objzx_ViewpointENT.PdfPageNumIn = objzx_ViewpointENS.PdfPageNumIn; //PdfPageNumIn
objzx_ViewpointENT.PdfPageTop = objzx_ViewpointENS.PdfPageTop; //pdf页面顶部位置
objzx_ViewpointENT.PdfZoom = objzx_ViewpointENS.PdfZoom; //PdfZoom
objzx_ViewpointENT.GroupTextId = objzx_ViewpointENS.GroupTextId; //小组Id
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
 /// <param name = "objzx_ViewpointEN">源简化对象</param>
 public static void SetUpdFlag(clszx_ViewpointEN objzx_ViewpointEN)
{
try
{
objzx_ViewpointEN.ClearUpdateState();
   string strsfUpdFldSetStr = objzx_ViewpointEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conzx_Viewpoint.zxViewpointId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointEN.zxViewpointId = objzx_ViewpointEN.zxViewpointId; //观点Id
}
if (arrFldSet.Contains(conzx_Viewpoint.ViewpointName, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointEN.ViewpointName = objzx_ViewpointEN.ViewpointName == "[null]" ? null :  objzx_ViewpointEN.ViewpointName; //观点名称
}
if (arrFldSet.Contains(conzx_Viewpoint.ViewpointContent, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointEN.ViewpointContent = objzx_ViewpointEN.ViewpointContent == "[null]" ? null :  objzx_ViewpointEN.ViewpointContent; //观点内容
}
if (arrFldSet.Contains(conzx_Viewpoint.zxViewpointTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointEN.zxViewpointTypeId = objzx_ViewpointEN.zxViewpointTypeId == "[null]" ? null :  objzx_ViewpointEN.zxViewpointTypeId; //观点类型Id
}
if (arrFldSet.Contains(conzx_Viewpoint.Reason, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointEN.Reason = objzx_ViewpointEN.Reason == "[null]" ? null :  objzx_ViewpointEN.Reason; //理由
}
if (arrFldSet.Contains(conzx_Viewpoint.Source, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointEN.Source = objzx_ViewpointEN.Source == "[null]" ? null :  objzx_ViewpointEN.Source; //来源
}
if (arrFldSet.Contains(conzx_Viewpoint.VPProposePeople, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointEN.VPProposePeople = objzx_ViewpointEN.VPProposePeople == "[null]" ? null :  objzx_ViewpointEN.VPProposePeople; //观点提出人
}
if (arrFldSet.Contains(conzx_Viewpoint.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointEN.IsSubmit = objzx_ViewpointEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(conzx_Viewpoint.UserTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointEN.UserTypeId = objzx_ViewpointEN.UserTypeId == "[null]" ? null :  objzx_ViewpointEN.UserTypeId; //用户类型Id
}
if (arrFldSet.Contains(conzx_Viewpoint.TextId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointEN.TextId = objzx_ViewpointEN.TextId == "[null]" ? null :  objzx_ViewpointEN.TextId; //课件Id
}
if (arrFldSet.Contains(conzx_Viewpoint.VoteCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointEN.VoteCount = objzx_ViewpointEN.VoteCount; //点赞计数
}
if (arrFldSet.Contains(conzx_Viewpoint.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointEN.AppraiseCount = objzx_ViewpointEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(conzx_Viewpoint.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointEN.Score = objzx_ViewpointEN.Score; //评分
}
if (arrFldSet.Contains(conzx_Viewpoint.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointEN.StuScore = objzx_ViewpointEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(conzx_Viewpoint.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointEN.TeaScore = objzx_ViewpointEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(conzx_Viewpoint.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointEN.IdCurrEduCls = objzx_ViewpointEN.IdCurrEduCls == "[null]" ? null :  objzx_ViewpointEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conzx_Viewpoint.PdfContent, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointEN.PdfContent = objzx_ViewpointEN.PdfContent == "[null]" ? null :  objzx_ViewpointEN.PdfContent; //Pdf内容
}
if (arrFldSet.Contains(conzx_Viewpoint.PdfPageNum, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointEN.PdfPageNum = objzx_ViewpointEN.PdfPageNum; //Pdf页码
}
if (arrFldSet.Contains(conzx_Viewpoint.CitationCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointEN.CitationCount = objzx_ViewpointEN.CitationCount; //引用统计
}
if (arrFldSet.Contains(conzx_Viewpoint.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointEN.VersionCount = objzx_ViewpointEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(conzx_Viewpoint.zxShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointEN.zxShareId = objzx_ViewpointEN.zxShareId == "[null]" ? null :  objzx_ViewpointEN.zxShareId; //分享Id
}
if (arrFldSet.Contains(conzx_Viewpoint.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointEN.CreateDate = objzx_ViewpointEN.CreateDate == "[null]" ? null :  objzx_ViewpointEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(conzx_Viewpoint.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointEN.UpdDate = objzx_ViewpointEN.UpdDate == "[null]" ? null :  objzx_ViewpointEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conzx_Viewpoint.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointEN.UpdUser = objzx_ViewpointEN.UpdUser == "[null]" ? null :  objzx_ViewpointEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conzx_Viewpoint.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointEN.Memo = objzx_ViewpointEN.Memo == "[null]" ? null :  objzx_ViewpointEN.Memo; //备注
}
if (arrFldSet.Contains(conzx_Viewpoint.TeammenberId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointEN.TeammenberId = objzx_ViewpointEN.TeammenberId == "[null]" ? null :  objzx_ViewpointEN.TeammenberId; //主键
}
if (arrFldSet.Contains(conzx_Viewpoint.PdfDivLet, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointEN.PdfDivLet = objzx_ViewpointEN.PdfDivLet == "[null]" ? null :  objzx_ViewpointEN.PdfDivLet; //PdfDivLet
}
if (arrFldSet.Contains(conzx_Viewpoint.PdfDivTop, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointEN.PdfDivTop = objzx_ViewpointEN.PdfDivTop == "[null]" ? null :  objzx_ViewpointEN.PdfDivTop; //PdfDivTop
}
if (arrFldSet.Contains(conzx_Viewpoint.PdfPageNumIn, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointEN.PdfPageNumIn = objzx_ViewpointEN.PdfPageNumIn == "[null]" ? null :  objzx_ViewpointEN.PdfPageNumIn; //PdfPageNumIn
}
if (arrFldSet.Contains(conzx_Viewpoint.PdfPageTop, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointEN.PdfPageTop = objzx_ViewpointEN.PdfPageTop; //pdf页面顶部位置
}
if (arrFldSet.Contains(conzx_Viewpoint.PdfZoom, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointEN.PdfZoom = objzx_ViewpointEN.PdfZoom == "[null]" ? null :  objzx_ViewpointEN.PdfZoom; //PdfZoom
}
if (arrFldSet.Contains(conzx_Viewpoint.GroupTextId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointEN.GroupTextId = objzx_ViewpointEN.GroupTextId == "[null]" ? null :  objzx_ViewpointEN.GroupTextId; //小组Id
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
 /// <param name = "objzx_ViewpointEN">源简化对象</param>
 public static void AccessFldValueNull(clszx_ViewpointEN objzx_ViewpointEN)
{
try
{
if (objzx_ViewpointEN.ViewpointName == "[null]") objzx_ViewpointEN.ViewpointName = null; //观点名称
if (objzx_ViewpointEN.ViewpointContent == "[null]") objzx_ViewpointEN.ViewpointContent = null; //观点内容
if (objzx_ViewpointEN.zxViewpointTypeId == "[null]") objzx_ViewpointEN.zxViewpointTypeId = null; //观点类型Id
if (objzx_ViewpointEN.Reason == "[null]") objzx_ViewpointEN.Reason = null; //理由
if (objzx_ViewpointEN.Source == "[null]") objzx_ViewpointEN.Source = null; //来源
if (objzx_ViewpointEN.VPProposePeople == "[null]") objzx_ViewpointEN.VPProposePeople = null; //观点提出人
if (objzx_ViewpointEN.UserTypeId == "[null]") objzx_ViewpointEN.UserTypeId = null; //用户类型Id
if (objzx_ViewpointEN.TextId == "[null]") objzx_ViewpointEN.TextId = null; //课件Id
if (objzx_ViewpointEN.IdCurrEduCls == "[null]") objzx_ViewpointEN.IdCurrEduCls = null; //教学班流水号
if (objzx_ViewpointEN.PdfContent == "[null]") objzx_ViewpointEN.PdfContent = null; //Pdf内容
if (objzx_ViewpointEN.zxShareId == "[null]") objzx_ViewpointEN.zxShareId = null; //分享Id
if (objzx_ViewpointEN.CreateDate == "[null]") objzx_ViewpointEN.CreateDate = null; //建立日期
if (objzx_ViewpointEN.UpdDate == "[null]") objzx_ViewpointEN.UpdDate = null; //修改日期
if (objzx_ViewpointEN.UpdUser == "[null]") objzx_ViewpointEN.UpdUser = null; //修改人
if (objzx_ViewpointEN.Memo == "[null]") objzx_ViewpointEN.Memo = null; //备注
if (objzx_ViewpointEN.TeammenberId == "[null]") objzx_ViewpointEN.TeammenberId = null; //主键
if (objzx_ViewpointEN.PdfDivLet == "[null]") objzx_ViewpointEN.PdfDivLet = null; //PdfDivLet
if (objzx_ViewpointEN.PdfDivTop == "[null]") objzx_ViewpointEN.PdfDivTop = null; //PdfDivTop
if (objzx_ViewpointEN.PdfPageNumIn == "[null]") objzx_ViewpointEN.PdfPageNumIn = null; //PdfPageNumIn
if (objzx_ViewpointEN.PdfZoom == "[null]") objzx_ViewpointEN.PdfZoom = null; //PdfZoom
if (objzx_ViewpointEN.GroupTextId == "[null]") objzx_ViewpointEN.GroupTextId = null; //小组Id
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
public static void CheckPropertyNew(clszx_ViewpointEN objzx_ViewpointEN)
{
 zx_ViewpointDA.CheckPropertyNew(objzx_ViewpointEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clszx_ViewpointEN objzx_ViewpointEN)
{
 zx_ViewpointDA.CheckProperty4Condition(objzx_ViewpointEN);
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
if (clszx_ViewpointBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_ViewpointBL没有刷新缓存机制(clszx_ViewpointBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by zxViewpointId");
//if (arrzx_ViewpointObjLstCache == null)
//{
//arrzx_ViewpointObjLstCache = zx_ViewpointDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strzxViewpointId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_ViewpointEN GetObjByzxViewpointIdCache(string strzxViewpointId, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clszx_ViewpointEN._CurrTabName, strIdCurrEduCls);
List<clszx_ViewpointEN> arrzx_ViewpointObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clszx_ViewpointEN> arrzx_ViewpointObjLst_Sel =
arrzx_ViewpointObjLstCache
.Where(x=> x.zxViewpointId == strzxViewpointId 
);
if (arrzx_ViewpointObjLst_Sel.Count() == 0)
{
   clszx_ViewpointEN obj = clszx_ViewpointBL.GetObjByzxViewpointId(strzxViewpointId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strzxViewpointId, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrzx_ViewpointObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_ViewpointEN> GetAllzx_ViewpointObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clszx_ViewpointEN> arrzx_ViewpointObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrzx_ViewpointObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_ViewpointEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clszx_ViewpointEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clszx_ViewpointEN> arrzx_ViewpointObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrzx_ViewpointObjLstCache;
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
string strKey = string.Format("{0}_{1}", clszx_ViewpointEN._CurrTabName, strIdCurrEduCls);
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
public static void ReFreshCache(string strIdCurrEduCls)
{
if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("缓存分类字段:[IdCurrEduCls]不能为空!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clszx_ViewpointBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clszx_ViewpointEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clszx_ViewpointBL.objCommFun4BL.ReFreshCache(strIdCurrEduCls);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--zx_Viewpoint(中学观点表)
 /// 唯一性条件:zxViewpointId_TextId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_ViewpointEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clszx_ViewpointEN objzx_ViewpointEN)
{
//检测记录是否存在
string strResult = zx_ViewpointDA.GetUniCondStr(objzx_ViewpointEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-11-15
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strzxViewpointId, string strIdCurrEduCls)
{
if (strInFldName != conzx_Viewpoint.zxViewpointId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conzx_Viewpoint.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conzx_Viewpoint.AttributeName));
throw new Exception(strMsg);
}
var objzx_Viewpoint = clszx_ViewpointBL.GetObjByzxViewpointIdCache(strzxViewpointId, strIdCurrEduCls);
if (objzx_Viewpoint == null) return "";
return objzx_Viewpoint[strOutFldName].ToString();
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
int intRecCount = clszx_ViewpointDA.GetRecCount(strTabName);
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
int intRecCount = clszx_ViewpointDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clszx_ViewpointDA.GetRecCount();
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
int intRecCount = clszx_ViewpointDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objzx_ViewpointCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clszx_ViewpointEN objzx_ViewpointCond)
{
 string strIdCurrEduCls = objzx_ViewpointCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clszx_ViewpointBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clszx_ViewpointEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clszx_ViewpointEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_Viewpoint.AttributeName)
{
if (objzx_ViewpointCond.IsUpdated(strFldName) == false) continue;
if (objzx_ViewpointCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_ViewpointCond[strFldName].ToString());
}
else
{
if (objzx_ViewpointCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_ViewpointCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_ViewpointCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_ViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_ViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_ViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_ViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_ViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_ViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_ViewpointCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_ViewpointCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_ViewpointCond[strFldName]));
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
 List<string> arrList = clszx_ViewpointDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = zx_ViewpointDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = zx_ViewpointDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = zx_ViewpointDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_ViewpointDA.SetFldValue(clszx_ViewpointEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = zx_ViewpointDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_ViewpointDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_ViewpointDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_ViewpointDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[zx_Viewpoint] "); 
 strCreateTabCode.Append(" ( "); 
 // /**观点Id*/ 
 strCreateTabCode.Append(" zxViewpointId char(8) primary key, "); 
 // /**观点名称*/ 
 strCreateTabCode.Append(" ViewpointName varchar(500) Null, "); 
 // /**观点内容*/ 
 strCreateTabCode.Append(" ViewpointContent text Null, "); 
 // /**观点类型Id*/ 
 strCreateTabCode.Append(" zxViewpointTypeId char(4) Null, "); 
 // /**理由*/ 
 strCreateTabCode.Append(" Reason text Null, "); 
 // /**来源*/ 
 strCreateTabCode.Append(" Source varchar(500) Null, "); 
 // /**观点提出人*/ 
 strCreateTabCode.Append(" VPProposePeople varchar(50) Null, "); 
 // /**是否提交*/ 
 strCreateTabCode.Append(" IsSubmit bit Null, "); 
 // /**用户类型Id*/ 
 strCreateTabCode.Append(" UserTypeId char(2) Null, "); 
 // /**课件Id*/ 
 strCreateTabCode.Append(" TextId char(8) Null, "); 
 // /**点赞计数*/ 
 strCreateTabCode.Append(" VoteCount int Null, "); 
 // /**评论数*/ 
 strCreateTabCode.Append(" AppraiseCount int Null, "); 
 // /**评分*/ 
 strCreateTabCode.Append(" Score float Null, "); 
 // /**学生平均分*/ 
 strCreateTabCode.Append(" StuScore float Null, "); 
 // /**教师评分*/ 
 strCreateTabCode.Append(" TeaScore float Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) Null, "); 
 // /**Pdf内容*/ 
 strCreateTabCode.Append(" PdfContent varchar(2000) Null, "); 
 // /**Pdf页码*/ 
 strCreateTabCode.Append(" PdfPageNum int Null, "); 
 // /**引用统计*/ 
 strCreateTabCode.Append(" CitationCount int Null, "); 
 // /**版本统计*/ 
 strCreateTabCode.Append(" VersionCount int Null, "); 
 // /**分享Id*/ 
 strCreateTabCode.Append(" zxShareId char(2) Null, "); 
 // /**建立日期*/ 
 strCreateTabCode.Append(" CreateDate varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**主键*/ 
 strCreateTabCode.Append(" TeammenberId char(8) Null, "); 
 // /**PdfDivLet*/ 
 strCreateTabCode.Append(" PdfDivLet varchar(50) Null, "); 
 // /**PdfDivTop*/ 
 strCreateTabCode.Append(" PdfDivTop varchar(50) Null, "); 
 // /**PdfPageNumIn*/ 
 strCreateTabCode.Append(" PdfPageNumIn varchar(50) Null, "); 
 // /**pdf页面顶部位置*/ 
 strCreateTabCode.Append(" PdfPageTop int Null, "); 
 // /**PdfZoom*/ 
 strCreateTabCode.Append(" PdfZoom varchar(50) Null, "); 
 // /**小组Id*/ 
 strCreateTabCode.Append(" GroupTextId char(8) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 中学观点表(zx_Viewpoint)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4zx_Viewpoint : clsCommFun4BLV2
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
clszx_ViewpointBL.ReFreshThisCache(strIdCurrEduCls);
}
}

}