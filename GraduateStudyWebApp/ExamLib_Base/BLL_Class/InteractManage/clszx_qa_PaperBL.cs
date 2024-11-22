
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_qa_PaperBL
 表名:zx_qa_Paper(01120810)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 23:02:43
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
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
public static class  clszx_qa_PaperBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strZxqaPaperId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_qa_PaperEN GetObj(this K_ZxqaPaperId_zx_qa_Paper myKey)
{
clszx_qa_PaperEN objzx_qa_PaperEN = clszx_qa_PaperBL.zx_qa_PaperDA.GetObjByZxqaPaperId(myKey.Value);
return objzx_qa_PaperEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objzx_qa_PaperEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clszx_qa_PaperEN objzx_qa_PaperEN)
{
if (CheckUniqueness(objzx_qa_PaperEN) == false)
{
var strMsg = string.Format("记录已经存在!论文答疑Id = [{0}]的数据已经存在!(in clszx_qa_PaperBL.AddNewRecord)", objzx_qa_PaperEN.ZxqaPaperId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_qa_PaperEN.ZxqaPaperId) == true || clszx_qa_PaperBL.IsExist(objzx_qa_PaperEN.ZxqaPaperId) == true)
 {
     objzx_qa_PaperEN.ZxqaPaperId = clszx_qa_PaperBL.GetMaxStrId_S();
 }
bool bolResult = clszx_qa_PaperBL.zx_qa_PaperDA.AddNewRecordBySQL2(objzx_qa_PaperEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_qa_PaperBL.ReFreshCache();

if (clszx_qa_PaperBL.relatedActions != null)
{
clszx_qa_PaperBL.relatedActions.UpdRelaTabDate(objzx_qa_PaperEN.ZxqaPaperId, "SetUpdDate");
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
public static bool AddRecordEx(this clszx_qa_PaperEN objzx_qa_PaperEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clszx_qa_PaperBL.IsExist(objzx_qa_PaperEN.ZxqaPaperId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objzx_qa_PaperEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objzx_qa_PaperEN.CheckUniqueness() == false)
{
strMsg = string.Format("(论文答疑Id(ZxqaPaperId)=[{0}])已经存在,不能重复!", objzx_qa_PaperEN.ZxqaPaperId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objzx_qa_PaperEN.ZxqaPaperId) == true || clszx_qa_PaperBL.IsExist(objzx_qa_PaperEN.ZxqaPaperId) == true)
 {
     objzx_qa_PaperEN.ZxqaPaperId = clszx_qa_PaperBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objzx_qa_PaperEN.AddNewRecord();
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
 /// <param name = "objzx_qa_PaperEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clszx_qa_PaperEN objzx_qa_PaperEN)
{
if (CheckUniqueness(objzx_qa_PaperEN) == false)
{
var strMsg = string.Format("记录已经存在!论文答疑Id = [{0}]的数据已经存在!(in clszx_qa_PaperBL.AddNewRecordWithMaxId)", objzx_qa_PaperEN.ZxqaPaperId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_qa_PaperEN.ZxqaPaperId) == true || clszx_qa_PaperBL.IsExist(objzx_qa_PaperEN.ZxqaPaperId) == true)
 {
     objzx_qa_PaperEN.ZxqaPaperId = clszx_qa_PaperBL.GetMaxStrId_S();
 }
string strZxqaPaperId = clszx_qa_PaperBL.zx_qa_PaperDA.AddNewRecordBySQL2WithReturnKey(objzx_qa_PaperEN);
     objzx_qa_PaperEN.ZxqaPaperId = strZxqaPaperId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_qa_PaperBL.ReFreshCache();

if (clszx_qa_PaperBL.relatedActions != null)
{
clszx_qa_PaperBL.relatedActions.UpdRelaTabDate(objzx_qa_PaperEN.ZxqaPaperId, "SetUpdDate");
}
return strZxqaPaperId;
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
 /// <param name = "objzx_qa_PaperEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clszx_qa_PaperEN objzx_qa_PaperEN)
{
if (CheckUniqueness(objzx_qa_PaperEN) == false)
{
var strMsg = string.Format("记录已经存在!论文答疑Id = [{0}]的数据已经存在!(in clszx_qa_PaperBL.AddNewRecordWithReturnKey)", objzx_qa_PaperEN.ZxqaPaperId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_qa_PaperEN.ZxqaPaperId) == true || clszx_qa_PaperBL.IsExist(objzx_qa_PaperEN.ZxqaPaperId) == true)
 {
     objzx_qa_PaperEN.ZxqaPaperId = clszx_qa_PaperBL.GetMaxStrId_S();
 }
string strKey = clszx_qa_PaperBL.zx_qa_PaperDA.AddNewRecordBySQL2WithReturnKey(objzx_qa_PaperEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_qa_PaperBL.ReFreshCache();

if (clszx_qa_PaperBL.relatedActions != null)
{
clszx_qa_PaperBL.relatedActions.UpdRelaTabDate(objzx_qa_PaperEN.ZxqaPaperId, "SetUpdDate");
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
 /// <param name = "objzx_qa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_qa_PaperEN SetZxqaPaperId(this clszx_qa_PaperEN objzx_qa_PaperEN, string strZxqaPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strZxqaPaperId, 8, conzx_qa_Paper.ZxqaPaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strZxqaPaperId, 8, conzx_qa_Paper.ZxqaPaperId);
}
objzx_qa_PaperEN.ZxqaPaperId = strZxqaPaperId; //论文答疑Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_qa_PaperEN.dicFldComparisonOp.ContainsKey(conzx_qa_Paper.ZxqaPaperId) == false)
{
objzx_qa_PaperEN.dicFldComparisonOp.Add(conzx_qa_Paper.ZxqaPaperId, strComparisonOp);
}
else
{
objzx_qa_PaperEN.dicFldComparisonOp[conzx_qa_Paper.ZxqaPaperId] = strComparisonOp;
}
}
return objzx_qa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_qa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_qa_PaperEN SetTextId(this clszx_qa_PaperEN objzx_qa_PaperEN, string strTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextId, 8, conzx_qa_Paper.TextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextId, 8, conzx_qa_Paper.TextId);
}
objzx_qa_PaperEN.TextId = strTextId; //课件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_qa_PaperEN.dicFldComparisonOp.ContainsKey(conzx_qa_Paper.TextId) == false)
{
objzx_qa_PaperEN.dicFldComparisonOp.Add(conzx_qa_Paper.TextId, strComparisonOp);
}
else
{
objzx_qa_PaperEN.dicFldComparisonOp[conzx_qa_Paper.TextId] = strComparisonOp;
}
}
return objzx_qa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_qa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_qa_PaperEN SetQuestionsCount(this clszx_qa_PaperEN objzx_qa_PaperEN, int? intQuestionsCount, string strComparisonOp="")
	{
objzx_qa_PaperEN.QuestionsCount = intQuestionsCount; //提问计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_qa_PaperEN.dicFldComparisonOp.ContainsKey(conzx_qa_Paper.QuestionsCount) == false)
{
objzx_qa_PaperEN.dicFldComparisonOp.Add(conzx_qa_Paper.QuestionsCount, strComparisonOp);
}
else
{
objzx_qa_PaperEN.dicFldComparisonOp[conzx_qa_Paper.QuestionsCount] = strComparisonOp;
}
}
return objzx_qa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_qa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_qa_PaperEN SetIsDelete(this clszx_qa_PaperEN objzx_qa_PaperEN, bool bolIsDelete, string strComparisonOp="")
	{
objzx_qa_PaperEN.IsDelete = bolIsDelete; //是否删除
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_qa_PaperEN.dicFldComparisonOp.ContainsKey(conzx_qa_Paper.IsDelete) == false)
{
objzx_qa_PaperEN.dicFldComparisonOp.Add(conzx_qa_Paper.IsDelete, strComparisonOp);
}
else
{
objzx_qa_PaperEN.dicFldComparisonOp[conzx_qa_Paper.IsDelete] = strComparisonOp;
}
}
return objzx_qa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_qa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_qa_PaperEN SetIsPublic(this clszx_qa_PaperEN objzx_qa_PaperEN, bool bolIsPublic, string strComparisonOp="")
	{
objzx_qa_PaperEN.IsPublic = bolIsPublic; //是否公开
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_qa_PaperEN.dicFldComparisonOp.ContainsKey(conzx_qa_Paper.IsPublic) == false)
{
objzx_qa_PaperEN.dicFldComparisonOp.Add(conzx_qa_Paper.IsPublic, strComparisonOp);
}
else
{
objzx_qa_PaperEN.dicFldComparisonOp[conzx_qa_Paper.IsPublic] = strComparisonOp;
}
}
return objzx_qa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_qa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_qa_PaperEN SetIsSubmit(this clszx_qa_PaperEN objzx_qa_PaperEN, bool bolIsSubmit, string strComparisonOp="")
	{
objzx_qa_PaperEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_qa_PaperEN.dicFldComparisonOp.ContainsKey(conzx_qa_Paper.IsSubmit) == false)
{
objzx_qa_PaperEN.dicFldComparisonOp.Add(conzx_qa_Paper.IsSubmit, strComparisonOp);
}
else
{
objzx_qa_PaperEN.dicFldComparisonOp[conzx_qa_Paper.IsSubmit] = strComparisonOp;
}
}
return objzx_qa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_qa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_qa_PaperEN SetUpdUser(this clszx_qa_PaperEN objzx_qa_PaperEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conzx_qa_Paper.UpdUser);
}
objzx_qa_PaperEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_qa_PaperEN.dicFldComparisonOp.ContainsKey(conzx_qa_Paper.UpdUser) == false)
{
objzx_qa_PaperEN.dicFldComparisonOp.Add(conzx_qa_Paper.UpdUser, strComparisonOp);
}
else
{
objzx_qa_PaperEN.dicFldComparisonOp[conzx_qa_Paper.UpdUser] = strComparisonOp;
}
}
return objzx_qa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_qa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_qa_PaperEN SetUpdDate(this clszx_qa_PaperEN objzx_qa_PaperEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conzx_qa_Paper.UpdDate);
}
objzx_qa_PaperEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_qa_PaperEN.dicFldComparisonOp.ContainsKey(conzx_qa_Paper.UpdDate) == false)
{
objzx_qa_PaperEN.dicFldComparisonOp.Add(conzx_qa_Paper.UpdDate, strComparisonOp);
}
else
{
objzx_qa_PaperEN.dicFldComparisonOp[conzx_qa_Paper.UpdDate] = strComparisonOp;
}
}
return objzx_qa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_qa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_qa_PaperEN SetMemo(this clszx_qa_PaperEN objzx_qa_PaperEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conzx_qa_Paper.Memo);
}
objzx_qa_PaperEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_qa_PaperEN.dicFldComparisonOp.ContainsKey(conzx_qa_Paper.Memo) == false)
{
objzx_qa_PaperEN.dicFldComparisonOp.Add(conzx_qa_Paper.Memo, strComparisonOp);
}
else
{
objzx_qa_PaperEN.dicFldComparisonOp[conzx_qa_Paper.Memo] = strComparisonOp;
}
}
return objzx_qa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_qa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_qa_PaperEN SetIdCurrEduCls(this clszx_qa_PaperEN objzx_qa_PaperEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conzx_qa_Paper.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conzx_qa_Paper.IdCurrEduCls);
}
objzx_qa_PaperEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_qa_PaperEN.dicFldComparisonOp.ContainsKey(conzx_qa_Paper.IdCurrEduCls) == false)
{
objzx_qa_PaperEN.dicFldComparisonOp.Add(conzx_qa_Paper.IdCurrEduCls, strComparisonOp);
}
else
{
objzx_qa_PaperEN.dicFldComparisonOp[conzx_qa_Paper.IdCurrEduCls] = strComparisonOp;
}
}
return objzx_qa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_qa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_qa_PaperEN SetAnswerCount(this clszx_qa_PaperEN objzx_qa_PaperEN, int? intAnswerCount, string strComparisonOp="")
	{
objzx_qa_PaperEN.AnswerCount = intAnswerCount; //回答计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_qa_PaperEN.dicFldComparisonOp.ContainsKey(conzx_qa_Paper.AnswerCount) == false)
{
objzx_qa_PaperEN.dicFldComparisonOp.Add(conzx_qa_Paper.AnswerCount, strComparisonOp);
}
else
{
objzx_qa_PaperEN.dicFldComparisonOp[conzx_qa_Paper.AnswerCount] = strComparisonOp;
}
}
return objzx_qa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_qa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_qa_PaperEN SetzxShareId(this clszx_qa_PaperEN objzx_qa_PaperEN, string strzxShareId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxShareId, 2, conzx_qa_Paper.zxShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxShareId, 2, conzx_qa_Paper.zxShareId);
}
objzx_qa_PaperEN.zxShareId = strzxShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_qa_PaperEN.dicFldComparisonOp.ContainsKey(conzx_qa_Paper.zxShareId) == false)
{
objzx_qa_PaperEN.dicFldComparisonOp.Add(conzx_qa_Paper.zxShareId, strComparisonOp);
}
else
{
objzx_qa_PaperEN.dicFldComparisonOp[conzx_qa_Paper.zxShareId] = strComparisonOp;
}
}
return objzx_qa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_qa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_qa_PaperEN SetTagsCount(this clszx_qa_PaperEN objzx_qa_PaperEN, int? intTagsCount, string strComparisonOp="")
	{
objzx_qa_PaperEN.TagsCount = intTagsCount; //论文标注数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_qa_PaperEN.dicFldComparisonOp.ContainsKey(conzx_qa_Paper.TagsCount) == false)
{
objzx_qa_PaperEN.dicFldComparisonOp.Add(conzx_qa_Paper.TagsCount, strComparisonOp);
}
else
{
objzx_qa_PaperEN.dicFldComparisonOp[conzx_qa_Paper.TagsCount] = strComparisonOp;
}
}
return objzx_qa_PaperEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objzx_qa_PaperEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clszx_qa_PaperEN objzx_qa_PaperEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objzx_qa_PaperEN.CheckPropertyNew();
clszx_qa_PaperEN objzx_qa_PaperCond = new clszx_qa_PaperEN();
string strCondition = objzx_qa_PaperCond
.SetZxqaPaperId(objzx_qa_PaperEN.ZxqaPaperId, "<>")
.SetZxqaPaperId(objzx_qa_PaperEN.ZxqaPaperId, "=")
.GetCombineCondition();
objzx_qa_PaperEN._IsCheckProperty = true;
bool bolIsExist = clszx_qa_PaperBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(zxqa_PaperId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objzx_qa_PaperEN.Update();
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
 /// <param name = "objzx_qa_Paper">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clszx_qa_PaperEN objzx_qa_Paper)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clszx_qa_PaperEN objzx_qa_PaperCond = new clszx_qa_PaperEN();
string strCondition = objzx_qa_PaperCond
.SetZxqaPaperId(objzx_qa_Paper.ZxqaPaperId, "=")
.GetCombineCondition();
objzx_qa_Paper._IsCheckProperty = true;
bool bolIsExist = clszx_qa_PaperBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objzx_qa_Paper.ZxqaPaperId = clszx_qa_PaperBL.GetFirstID_S(strCondition);
objzx_qa_Paper.UpdateWithCondition(strCondition);
}
else
{
objzx_qa_Paper.ZxqaPaperId = clszx_qa_PaperBL.GetMaxStrId_S();
objzx_qa_Paper.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objzx_qa_PaperEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_qa_PaperEN objzx_qa_PaperEN)
{
 if (string.IsNullOrEmpty(objzx_qa_PaperEN.ZxqaPaperId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_qa_PaperBL.zx_qa_PaperDA.UpdateBySql2(objzx_qa_PaperEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_qa_PaperBL.ReFreshCache();

if (clszx_qa_PaperBL.relatedActions != null)
{
clszx_qa_PaperBL.relatedActions.UpdRelaTabDate(objzx_qa_PaperEN.ZxqaPaperId, "SetUpdDate");
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
 /// <param name = "objzx_qa_PaperEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_qa_PaperEN objzx_qa_PaperEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objzx_qa_PaperEN.ZxqaPaperId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_qa_PaperBL.zx_qa_PaperDA.UpdateBySql2(objzx_qa_PaperEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_qa_PaperBL.ReFreshCache();

if (clszx_qa_PaperBL.relatedActions != null)
{
clszx_qa_PaperBL.relatedActions.UpdRelaTabDate(objzx_qa_PaperEN.ZxqaPaperId, "SetUpdDate");
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
 /// <param name = "objzx_qa_PaperEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_qa_PaperEN objzx_qa_PaperEN, string strWhereCond)
{
try
{
bool bolResult = clszx_qa_PaperBL.zx_qa_PaperDA.UpdateBySqlWithCondition(objzx_qa_PaperEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_qa_PaperBL.ReFreshCache();

if (clszx_qa_PaperBL.relatedActions != null)
{
clszx_qa_PaperBL.relatedActions.UpdRelaTabDate(objzx_qa_PaperEN.ZxqaPaperId, "SetUpdDate");
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
 /// <param name = "objzx_qa_PaperEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_qa_PaperEN objzx_qa_PaperEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clszx_qa_PaperBL.zx_qa_PaperDA.UpdateBySqlWithConditionTransaction(objzx_qa_PaperEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_qa_PaperBL.ReFreshCache();

if (clszx_qa_PaperBL.relatedActions != null)
{
clszx_qa_PaperBL.relatedActions.UpdRelaTabDate(objzx_qa_PaperEN.ZxqaPaperId, "SetUpdDate");
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
 /// <param name = "strZxqaPaperId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clszx_qa_PaperEN objzx_qa_PaperEN)
{
try
{
int intRecNum = clszx_qa_PaperBL.zx_qa_PaperDA.DelRecord(objzx_qa_PaperEN.ZxqaPaperId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_qa_PaperBL.ReFreshCache();

if (clszx_qa_PaperBL.relatedActions != null)
{
clszx_qa_PaperBL.relatedActions.UpdRelaTabDate(objzx_qa_PaperEN.ZxqaPaperId, "SetUpdDate");
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
 /// <param name = "objzx_qa_PaperENS">源对象</param>
 /// <param name = "objzx_qa_PaperENT">目标对象</param>
 public static void CopyTo(this clszx_qa_PaperEN objzx_qa_PaperENS, clszx_qa_PaperEN objzx_qa_PaperENT)
{
try
{
objzx_qa_PaperENT.ZxqaPaperId = objzx_qa_PaperENS.ZxqaPaperId; //论文答疑Id
objzx_qa_PaperENT.TextId = objzx_qa_PaperENS.TextId; //课件Id
objzx_qa_PaperENT.QuestionsCount = objzx_qa_PaperENS.QuestionsCount; //提问计数
objzx_qa_PaperENT.IsDelete = objzx_qa_PaperENS.IsDelete; //是否删除
objzx_qa_PaperENT.IsPublic = objzx_qa_PaperENS.IsPublic; //是否公开
objzx_qa_PaperENT.IsSubmit = objzx_qa_PaperENS.IsSubmit; //是否提交
objzx_qa_PaperENT.UpdUser = objzx_qa_PaperENS.UpdUser; //修改人
objzx_qa_PaperENT.UpdDate = objzx_qa_PaperENS.UpdDate; //修改日期
objzx_qa_PaperENT.Memo = objzx_qa_PaperENS.Memo; //备注
objzx_qa_PaperENT.IdCurrEduCls = objzx_qa_PaperENS.IdCurrEduCls; //教学班流水号
objzx_qa_PaperENT.AnswerCount = objzx_qa_PaperENS.AnswerCount; //回答计数
objzx_qa_PaperENT.zxShareId = objzx_qa_PaperENS.zxShareId; //分享Id
objzx_qa_PaperENT.TagsCount = objzx_qa_PaperENS.TagsCount; //论文标注数
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
 /// <param name = "objzx_qa_PaperENS">源对象</param>
 /// <returns>目标对象=>clszx_qa_PaperEN:objzx_qa_PaperENT</returns>
 public static clszx_qa_PaperEN CopyTo(this clszx_qa_PaperEN objzx_qa_PaperENS)
{
try
{
 clszx_qa_PaperEN objzx_qa_PaperENT = new clszx_qa_PaperEN()
{
ZxqaPaperId = objzx_qa_PaperENS.ZxqaPaperId, //论文答疑Id
TextId = objzx_qa_PaperENS.TextId, //课件Id
QuestionsCount = objzx_qa_PaperENS.QuestionsCount, //提问计数
IsDelete = objzx_qa_PaperENS.IsDelete, //是否删除
IsPublic = objzx_qa_PaperENS.IsPublic, //是否公开
IsSubmit = objzx_qa_PaperENS.IsSubmit, //是否提交
UpdUser = objzx_qa_PaperENS.UpdUser, //修改人
UpdDate = objzx_qa_PaperENS.UpdDate, //修改日期
Memo = objzx_qa_PaperENS.Memo, //备注
IdCurrEduCls = objzx_qa_PaperENS.IdCurrEduCls, //教学班流水号
AnswerCount = objzx_qa_PaperENS.AnswerCount, //回答计数
zxShareId = objzx_qa_PaperENS.zxShareId, //分享Id
TagsCount = objzx_qa_PaperENS.TagsCount, //论文标注数
};
 return objzx_qa_PaperENT;
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
public static void CheckPropertyNew(this clszx_qa_PaperEN objzx_qa_PaperEN)
{
 clszx_qa_PaperBL.zx_qa_PaperDA.CheckPropertyNew(objzx_qa_PaperEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clszx_qa_PaperEN objzx_qa_PaperEN)
{
 clszx_qa_PaperBL.zx_qa_PaperDA.CheckProperty4Condition(objzx_qa_PaperEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clszx_qa_PaperEN objzx_qa_PaperCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objzx_qa_PaperCond.IsUpdated(conzx_qa_Paper.ZxqaPaperId) == true)
{
string strComparisonOpZxqaPaperId = objzx_qa_PaperCond.dicFldComparisonOp[conzx_qa_Paper.ZxqaPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_qa_Paper.ZxqaPaperId, objzx_qa_PaperCond.ZxqaPaperId, strComparisonOpZxqaPaperId);
}
if (objzx_qa_PaperCond.IsUpdated(conzx_qa_Paper.TextId) == true)
{
string strComparisonOpTextId = objzx_qa_PaperCond.dicFldComparisonOp[conzx_qa_Paper.TextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_qa_Paper.TextId, objzx_qa_PaperCond.TextId, strComparisonOpTextId);
}
if (objzx_qa_PaperCond.IsUpdated(conzx_qa_Paper.QuestionsCount) == true)
{
string strComparisonOpQuestionsCount = objzx_qa_PaperCond.dicFldComparisonOp[conzx_qa_Paper.QuestionsCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_qa_Paper.QuestionsCount, objzx_qa_PaperCond.QuestionsCount, strComparisonOpQuestionsCount);
}
if (objzx_qa_PaperCond.IsUpdated(conzx_qa_Paper.IsDelete) == true)
{
if (objzx_qa_PaperCond.IsDelete == true)
{
strWhereCond += string.Format(" And {0} = '1'", conzx_qa_Paper.IsDelete);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conzx_qa_Paper.IsDelete);
}
}
if (objzx_qa_PaperCond.IsUpdated(conzx_qa_Paper.IsPublic) == true)
{
if (objzx_qa_PaperCond.IsPublic == true)
{
strWhereCond += string.Format(" And {0} = '1'", conzx_qa_Paper.IsPublic);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conzx_qa_Paper.IsPublic);
}
}
if (objzx_qa_PaperCond.IsUpdated(conzx_qa_Paper.IsSubmit) == true)
{
if (objzx_qa_PaperCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", conzx_qa_Paper.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conzx_qa_Paper.IsSubmit);
}
}
if (objzx_qa_PaperCond.IsUpdated(conzx_qa_Paper.UpdUser) == true)
{
string strComparisonOpUpdUser = objzx_qa_PaperCond.dicFldComparisonOp[conzx_qa_Paper.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_qa_Paper.UpdUser, objzx_qa_PaperCond.UpdUser, strComparisonOpUpdUser);
}
if (objzx_qa_PaperCond.IsUpdated(conzx_qa_Paper.UpdDate) == true)
{
string strComparisonOpUpdDate = objzx_qa_PaperCond.dicFldComparisonOp[conzx_qa_Paper.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_qa_Paper.UpdDate, objzx_qa_PaperCond.UpdDate, strComparisonOpUpdDate);
}
if (objzx_qa_PaperCond.IsUpdated(conzx_qa_Paper.Memo) == true)
{
string strComparisonOpMemo = objzx_qa_PaperCond.dicFldComparisonOp[conzx_qa_Paper.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_qa_Paper.Memo, objzx_qa_PaperCond.Memo, strComparisonOpMemo);
}
if (objzx_qa_PaperCond.IsUpdated(conzx_qa_Paper.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objzx_qa_PaperCond.dicFldComparisonOp[conzx_qa_Paper.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_qa_Paper.IdCurrEduCls, objzx_qa_PaperCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objzx_qa_PaperCond.IsUpdated(conzx_qa_Paper.AnswerCount) == true)
{
string strComparisonOpAnswerCount = objzx_qa_PaperCond.dicFldComparisonOp[conzx_qa_Paper.AnswerCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_qa_Paper.AnswerCount, objzx_qa_PaperCond.AnswerCount, strComparisonOpAnswerCount);
}
if (objzx_qa_PaperCond.IsUpdated(conzx_qa_Paper.zxShareId) == true)
{
string strComparisonOpzxShareId = objzx_qa_PaperCond.dicFldComparisonOp[conzx_qa_Paper.zxShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_qa_Paper.zxShareId, objzx_qa_PaperCond.zxShareId, strComparisonOpzxShareId);
}
if (objzx_qa_PaperCond.IsUpdated(conzx_qa_Paper.TagsCount) == true)
{
string strComparisonOpTagsCount = objzx_qa_PaperCond.dicFldComparisonOp[conzx_qa_Paper.TagsCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_qa_Paper.TagsCount, objzx_qa_PaperCond.TagsCount, strComparisonOpTagsCount);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--zx_qa_Paper(中学论文答疑表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:zxqa_PaperId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objzx_qa_PaperEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clszx_qa_PaperEN objzx_qa_PaperEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objzx_qa_PaperEN == null) return true;
if (objzx_qa_PaperEN.ZxqaPaperId == null || objzx_qa_PaperEN.ZxqaPaperId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ZxqaPaperId = '{0}'", objzx_qa_PaperEN.ZxqaPaperId);
if (clszx_qa_PaperBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("ZxqaPaperId !=  '{0}'", objzx_qa_PaperEN.ZxqaPaperId);
 sbCondition.AppendFormat(" and ZxqaPaperId = '{0}'", objzx_qa_PaperEN.ZxqaPaperId);
if (clszx_qa_PaperBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--zx_qa_Paper(中学论文答疑表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:zxqa_PaperId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objzx_qa_PaperEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clszx_qa_PaperEN objzx_qa_PaperEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objzx_qa_PaperEN == null) return "";
if (objzx_qa_PaperEN.ZxqaPaperId == null || objzx_qa_PaperEN.ZxqaPaperId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ZxqaPaperId = '{0}'", objzx_qa_PaperEN.ZxqaPaperId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ZxqaPaperId !=  '{0}'", objzx_qa_PaperEN.ZxqaPaperId);
 sbCondition.AppendFormat(" and ZxqaPaperId = '{0}'", objzx_qa_PaperEN.ZxqaPaperId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_zx_qa_Paper
{
public virtual bool UpdRelaTabDate(string strZxqaPaperId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 中学论文答疑表(zx_qa_Paper)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clszx_qa_PaperBL
{
public static RelatedActions_zx_qa_Paper relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clszx_qa_PaperDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clszx_qa_PaperDA zx_qa_PaperDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clszx_qa_PaperDA();
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
 public clszx_qa_PaperBL()
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
if (string.IsNullOrEmpty(clszx_qa_PaperEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_qa_PaperEN._ConnectString);
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
public static DataTable GetDataTable_zx_qa_Paper(string strWhereCond)
{
DataTable objDT;
try
{
objDT = zx_qa_PaperDA.GetDataTable_zx_qa_Paper(strWhereCond);
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
objDT = zx_qa_PaperDA.GetDataTable(strWhereCond);
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
objDT = zx_qa_PaperDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = zx_qa_PaperDA.GetDataTable(strWhereCond, strTabName);
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
objDT = zx_qa_PaperDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = zx_qa_PaperDA.GetDataTable_Top(objTopPara);
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
objDT = zx_qa_PaperDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = zx_qa_PaperDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = zx_qa_PaperDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrZxqaPaperIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clszx_qa_PaperEN> GetObjLstByZxqaPaperIdLst(List<string> arrZxqaPaperIdLst)
{
List<clszx_qa_PaperEN> arrObjLst = new List<clszx_qa_PaperEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrZxqaPaperIdLst, true);
 string strWhereCond = string.Format("ZxqaPaperId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_qa_PaperEN objzx_qa_PaperEN = new clszx_qa_PaperEN();
try
{
objzx_qa_PaperEN.ZxqaPaperId = objRow[conzx_qa_Paper.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objzx_qa_PaperEN.TextId = objRow[conzx_qa_Paper.TextId] == DBNull.Value ? null : objRow[conzx_qa_Paper.TextId].ToString().Trim(); //课件Id
objzx_qa_PaperEN.QuestionsCount = objRow[conzx_qa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_qa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objzx_qa_PaperEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[conzx_qa_Paper.IsDelete].ToString().Trim()); //是否删除
objzx_qa_PaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_qa_Paper.IsPublic].ToString().Trim()); //是否公开
objzx_qa_PaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_qa_Paper.IsSubmit].ToString().Trim()); //是否提交
objzx_qa_PaperEN.UpdUser = objRow[conzx_qa_Paper.UpdUser] == DBNull.Value ? null : objRow[conzx_qa_Paper.UpdUser].ToString().Trim(); //修改人
objzx_qa_PaperEN.UpdDate = objRow[conzx_qa_Paper.UpdDate] == DBNull.Value ? null : objRow[conzx_qa_Paper.UpdDate].ToString().Trim(); //修改日期
objzx_qa_PaperEN.Memo = objRow[conzx_qa_Paper.Memo] == DBNull.Value ? null : objRow[conzx_qa_Paper.Memo].ToString().Trim(); //备注
objzx_qa_PaperEN.IdCurrEduCls = objRow[conzx_qa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_qa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_qa_PaperEN.AnswerCount = objRow[conzx_qa_Paper.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_qa_Paper.AnswerCount].ToString().Trim()); //回答计数
objzx_qa_PaperEN.zxShareId = objRow[conzx_qa_Paper.zxShareId] == DBNull.Value ? null : objRow[conzx_qa_Paper.zxShareId].ToString().Trim(); //分享Id
objzx_qa_PaperEN.TagsCount = objRow[conzx_qa_Paper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_qa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_qa_PaperEN.ZxqaPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_qa_PaperEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrZxqaPaperIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clszx_qa_PaperEN> GetObjLstByZxqaPaperIdLstCache(List<string> arrZxqaPaperIdLst)
{
string strKey = string.Format("{0}", clszx_qa_PaperEN._CurrTabName);
List<clszx_qa_PaperEN> arrzx_qa_PaperObjLstCache = GetObjLstCache();
IEnumerable <clszx_qa_PaperEN> arrzx_qa_PaperObjLst_Sel =
arrzx_qa_PaperObjLstCache
.Where(x => arrZxqaPaperIdLst.Contains(x.ZxqaPaperId));
return arrzx_qa_PaperObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_qa_PaperEN> GetObjLst(string strWhereCond)
{
List<clszx_qa_PaperEN> arrObjLst = new List<clszx_qa_PaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_qa_PaperEN objzx_qa_PaperEN = new clszx_qa_PaperEN();
try
{
objzx_qa_PaperEN.ZxqaPaperId = objRow[conzx_qa_Paper.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objzx_qa_PaperEN.TextId = objRow[conzx_qa_Paper.TextId] == DBNull.Value ? null : objRow[conzx_qa_Paper.TextId].ToString().Trim(); //课件Id
objzx_qa_PaperEN.QuestionsCount = objRow[conzx_qa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_qa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objzx_qa_PaperEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[conzx_qa_Paper.IsDelete].ToString().Trim()); //是否删除
objzx_qa_PaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_qa_Paper.IsPublic].ToString().Trim()); //是否公开
objzx_qa_PaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_qa_Paper.IsSubmit].ToString().Trim()); //是否提交
objzx_qa_PaperEN.UpdUser = objRow[conzx_qa_Paper.UpdUser] == DBNull.Value ? null : objRow[conzx_qa_Paper.UpdUser].ToString().Trim(); //修改人
objzx_qa_PaperEN.UpdDate = objRow[conzx_qa_Paper.UpdDate] == DBNull.Value ? null : objRow[conzx_qa_Paper.UpdDate].ToString().Trim(); //修改日期
objzx_qa_PaperEN.Memo = objRow[conzx_qa_Paper.Memo] == DBNull.Value ? null : objRow[conzx_qa_Paper.Memo].ToString().Trim(); //备注
objzx_qa_PaperEN.IdCurrEduCls = objRow[conzx_qa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_qa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_qa_PaperEN.AnswerCount = objRow[conzx_qa_Paper.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_qa_Paper.AnswerCount].ToString().Trim()); //回答计数
objzx_qa_PaperEN.zxShareId = objRow[conzx_qa_Paper.zxShareId] == DBNull.Value ? null : objRow[conzx_qa_Paper.zxShareId].ToString().Trim(); //分享Id
objzx_qa_PaperEN.TagsCount = objRow[conzx_qa_Paper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_qa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_qa_PaperEN.ZxqaPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_qa_PaperEN);
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
public static List<clszx_qa_PaperEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clszx_qa_PaperEN> arrObjLst = new List<clszx_qa_PaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_qa_PaperEN objzx_qa_PaperEN = new clszx_qa_PaperEN();
try
{
objzx_qa_PaperEN.ZxqaPaperId = objRow[conzx_qa_Paper.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objzx_qa_PaperEN.TextId = objRow[conzx_qa_Paper.TextId] == DBNull.Value ? null : objRow[conzx_qa_Paper.TextId].ToString().Trim(); //课件Id
objzx_qa_PaperEN.QuestionsCount = objRow[conzx_qa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_qa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objzx_qa_PaperEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[conzx_qa_Paper.IsDelete].ToString().Trim()); //是否删除
objzx_qa_PaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_qa_Paper.IsPublic].ToString().Trim()); //是否公开
objzx_qa_PaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_qa_Paper.IsSubmit].ToString().Trim()); //是否提交
objzx_qa_PaperEN.UpdUser = objRow[conzx_qa_Paper.UpdUser] == DBNull.Value ? null : objRow[conzx_qa_Paper.UpdUser].ToString().Trim(); //修改人
objzx_qa_PaperEN.UpdDate = objRow[conzx_qa_Paper.UpdDate] == DBNull.Value ? null : objRow[conzx_qa_Paper.UpdDate].ToString().Trim(); //修改日期
objzx_qa_PaperEN.Memo = objRow[conzx_qa_Paper.Memo] == DBNull.Value ? null : objRow[conzx_qa_Paper.Memo].ToString().Trim(); //备注
objzx_qa_PaperEN.IdCurrEduCls = objRow[conzx_qa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_qa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_qa_PaperEN.AnswerCount = objRow[conzx_qa_Paper.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_qa_Paper.AnswerCount].ToString().Trim()); //回答计数
objzx_qa_PaperEN.zxShareId = objRow[conzx_qa_Paper.zxShareId] == DBNull.Value ? null : objRow[conzx_qa_Paper.zxShareId].ToString().Trim(); //分享Id
objzx_qa_PaperEN.TagsCount = objRow[conzx_qa_Paper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_qa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_qa_PaperEN.ZxqaPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_qa_PaperEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objzx_qa_PaperCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clszx_qa_PaperEN> GetSubObjLstCache(clszx_qa_PaperEN objzx_qa_PaperCond)
{
List<clszx_qa_PaperEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clszx_qa_PaperEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_qa_Paper.AttributeName)
{
if (objzx_qa_PaperCond.IsUpdated(strFldName) == false) continue;
if (objzx_qa_PaperCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_qa_PaperCond[strFldName].ToString());
}
else
{
if (objzx_qa_PaperCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_qa_PaperCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_qa_PaperCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_qa_PaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_qa_PaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_qa_PaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_qa_PaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_qa_PaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_qa_PaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_qa_PaperCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_qa_PaperCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_qa_PaperCond[strFldName]));
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
public static List<clszx_qa_PaperEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clszx_qa_PaperEN> arrObjLst = new List<clszx_qa_PaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_qa_PaperEN objzx_qa_PaperEN = new clszx_qa_PaperEN();
try
{
objzx_qa_PaperEN.ZxqaPaperId = objRow[conzx_qa_Paper.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objzx_qa_PaperEN.TextId = objRow[conzx_qa_Paper.TextId] == DBNull.Value ? null : objRow[conzx_qa_Paper.TextId].ToString().Trim(); //课件Id
objzx_qa_PaperEN.QuestionsCount = objRow[conzx_qa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_qa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objzx_qa_PaperEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[conzx_qa_Paper.IsDelete].ToString().Trim()); //是否删除
objzx_qa_PaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_qa_Paper.IsPublic].ToString().Trim()); //是否公开
objzx_qa_PaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_qa_Paper.IsSubmit].ToString().Trim()); //是否提交
objzx_qa_PaperEN.UpdUser = objRow[conzx_qa_Paper.UpdUser] == DBNull.Value ? null : objRow[conzx_qa_Paper.UpdUser].ToString().Trim(); //修改人
objzx_qa_PaperEN.UpdDate = objRow[conzx_qa_Paper.UpdDate] == DBNull.Value ? null : objRow[conzx_qa_Paper.UpdDate].ToString().Trim(); //修改日期
objzx_qa_PaperEN.Memo = objRow[conzx_qa_Paper.Memo] == DBNull.Value ? null : objRow[conzx_qa_Paper.Memo].ToString().Trim(); //备注
objzx_qa_PaperEN.IdCurrEduCls = objRow[conzx_qa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_qa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_qa_PaperEN.AnswerCount = objRow[conzx_qa_Paper.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_qa_Paper.AnswerCount].ToString().Trim()); //回答计数
objzx_qa_PaperEN.zxShareId = objRow[conzx_qa_Paper.zxShareId] == DBNull.Value ? null : objRow[conzx_qa_Paper.zxShareId].ToString().Trim(); //分享Id
objzx_qa_PaperEN.TagsCount = objRow[conzx_qa_Paper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_qa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_qa_PaperEN.ZxqaPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_qa_PaperEN);
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
public static List<clszx_qa_PaperEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clszx_qa_PaperEN> arrObjLst = new List<clszx_qa_PaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_qa_PaperEN objzx_qa_PaperEN = new clszx_qa_PaperEN();
try
{
objzx_qa_PaperEN.ZxqaPaperId = objRow[conzx_qa_Paper.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objzx_qa_PaperEN.TextId = objRow[conzx_qa_Paper.TextId] == DBNull.Value ? null : objRow[conzx_qa_Paper.TextId].ToString().Trim(); //课件Id
objzx_qa_PaperEN.QuestionsCount = objRow[conzx_qa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_qa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objzx_qa_PaperEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[conzx_qa_Paper.IsDelete].ToString().Trim()); //是否删除
objzx_qa_PaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_qa_Paper.IsPublic].ToString().Trim()); //是否公开
objzx_qa_PaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_qa_Paper.IsSubmit].ToString().Trim()); //是否提交
objzx_qa_PaperEN.UpdUser = objRow[conzx_qa_Paper.UpdUser] == DBNull.Value ? null : objRow[conzx_qa_Paper.UpdUser].ToString().Trim(); //修改人
objzx_qa_PaperEN.UpdDate = objRow[conzx_qa_Paper.UpdDate] == DBNull.Value ? null : objRow[conzx_qa_Paper.UpdDate].ToString().Trim(); //修改日期
objzx_qa_PaperEN.Memo = objRow[conzx_qa_Paper.Memo] == DBNull.Value ? null : objRow[conzx_qa_Paper.Memo].ToString().Trim(); //备注
objzx_qa_PaperEN.IdCurrEduCls = objRow[conzx_qa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_qa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_qa_PaperEN.AnswerCount = objRow[conzx_qa_Paper.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_qa_Paper.AnswerCount].ToString().Trim()); //回答计数
objzx_qa_PaperEN.zxShareId = objRow[conzx_qa_Paper.zxShareId] == DBNull.Value ? null : objRow[conzx_qa_Paper.zxShareId].ToString().Trim(); //分享Id
objzx_qa_PaperEN.TagsCount = objRow[conzx_qa_Paper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_qa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_qa_PaperEN.ZxqaPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_qa_PaperEN);
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
List<clszx_qa_PaperEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clszx_qa_PaperEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_qa_PaperEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clszx_qa_PaperEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clszx_qa_PaperEN> arrObjLst = new List<clszx_qa_PaperEN>(); 
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
	clszx_qa_PaperEN objzx_qa_PaperEN = new clszx_qa_PaperEN();
try
{
objzx_qa_PaperEN.ZxqaPaperId = objRow[conzx_qa_Paper.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objzx_qa_PaperEN.TextId = objRow[conzx_qa_Paper.TextId] == DBNull.Value ? null : objRow[conzx_qa_Paper.TextId].ToString().Trim(); //课件Id
objzx_qa_PaperEN.QuestionsCount = objRow[conzx_qa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_qa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objzx_qa_PaperEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[conzx_qa_Paper.IsDelete].ToString().Trim()); //是否删除
objzx_qa_PaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_qa_Paper.IsPublic].ToString().Trim()); //是否公开
objzx_qa_PaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_qa_Paper.IsSubmit].ToString().Trim()); //是否提交
objzx_qa_PaperEN.UpdUser = objRow[conzx_qa_Paper.UpdUser] == DBNull.Value ? null : objRow[conzx_qa_Paper.UpdUser].ToString().Trim(); //修改人
objzx_qa_PaperEN.UpdDate = objRow[conzx_qa_Paper.UpdDate] == DBNull.Value ? null : objRow[conzx_qa_Paper.UpdDate].ToString().Trim(); //修改日期
objzx_qa_PaperEN.Memo = objRow[conzx_qa_Paper.Memo] == DBNull.Value ? null : objRow[conzx_qa_Paper.Memo].ToString().Trim(); //备注
objzx_qa_PaperEN.IdCurrEduCls = objRow[conzx_qa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_qa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_qa_PaperEN.AnswerCount = objRow[conzx_qa_Paper.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_qa_Paper.AnswerCount].ToString().Trim()); //回答计数
objzx_qa_PaperEN.zxShareId = objRow[conzx_qa_Paper.zxShareId] == DBNull.Value ? null : objRow[conzx_qa_Paper.zxShareId].ToString().Trim(); //分享Id
objzx_qa_PaperEN.TagsCount = objRow[conzx_qa_Paper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_qa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_qa_PaperEN.ZxqaPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_qa_PaperEN);
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
public static List<clszx_qa_PaperEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clszx_qa_PaperEN> arrObjLst = new List<clszx_qa_PaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_qa_PaperEN objzx_qa_PaperEN = new clszx_qa_PaperEN();
try
{
objzx_qa_PaperEN.ZxqaPaperId = objRow[conzx_qa_Paper.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objzx_qa_PaperEN.TextId = objRow[conzx_qa_Paper.TextId] == DBNull.Value ? null : objRow[conzx_qa_Paper.TextId].ToString().Trim(); //课件Id
objzx_qa_PaperEN.QuestionsCount = objRow[conzx_qa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_qa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objzx_qa_PaperEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[conzx_qa_Paper.IsDelete].ToString().Trim()); //是否删除
objzx_qa_PaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_qa_Paper.IsPublic].ToString().Trim()); //是否公开
objzx_qa_PaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_qa_Paper.IsSubmit].ToString().Trim()); //是否提交
objzx_qa_PaperEN.UpdUser = objRow[conzx_qa_Paper.UpdUser] == DBNull.Value ? null : objRow[conzx_qa_Paper.UpdUser].ToString().Trim(); //修改人
objzx_qa_PaperEN.UpdDate = objRow[conzx_qa_Paper.UpdDate] == DBNull.Value ? null : objRow[conzx_qa_Paper.UpdDate].ToString().Trim(); //修改日期
objzx_qa_PaperEN.Memo = objRow[conzx_qa_Paper.Memo] == DBNull.Value ? null : objRow[conzx_qa_Paper.Memo].ToString().Trim(); //备注
objzx_qa_PaperEN.IdCurrEduCls = objRow[conzx_qa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_qa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_qa_PaperEN.AnswerCount = objRow[conzx_qa_Paper.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_qa_Paper.AnswerCount].ToString().Trim()); //回答计数
objzx_qa_PaperEN.zxShareId = objRow[conzx_qa_Paper.zxShareId] == DBNull.Value ? null : objRow[conzx_qa_Paper.zxShareId].ToString().Trim(); //分享Id
objzx_qa_PaperEN.TagsCount = objRow[conzx_qa_Paper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_qa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_qa_PaperEN.ZxqaPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_qa_PaperEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clszx_qa_PaperEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clszx_qa_PaperEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clszx_qa_PaperEN> arrObjLst = new List<clszx_qa_PaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_qa_PaperEN objzx_qa_PaperEN = new clszx_qa_PaperEN();
try
{
objzx_qa_PaperEN.ZxqaPaperId = objRow[conzx_qa_Paper.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objzx_qa_PaperEN.TextId = objRow[conzx_qa_Paper.TextId] == DBNull.Value ? null : objRow[conzx_qa_Paper.TextId].ToString().Trim(); //课件Id
objzx_qa_PaperEN.QuestionsCount = objRow[conzx_qa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_qa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objzx_qa_PaperEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[conzx_qa_Paper.IsDelete].ToString().Trim()); //是否删除
objzx_qa_PaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_qa_Paper.IsPublic].ToString().Trim()); //是否公开
objzx_qa_PaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_qa_Paper.IsSubmit].ToString().Trim()); //是否提交
objzx_qa_PaperEN.UpdUser = objRow[conzx_qa_Paper.UpdUser] == DBNull.Value ? null : objRow[conzx_qa_Paper.UpdUser].ToString().Trim(); //修改人
objzx_qa_PaperEN.UpdDate = objRow[conzx_qa_Paper.UpdDate] == DBNull.Value ? null : objRow[conzx_qa_Paper.UpdDate].ToString().Trim(); //修改日期
objzx_qa_PaperEN.Memo = objRow[conzx_qa_Paper.Memo] == DBNull.Value ? null : objRow[conzx_qa_Paper.Memo].ToString().Trim(); //备注
objzx_qa_PaperEN.IdCurrEduCls = objRow[conzx_qa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_qa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_qa_PaperEN.AnswerCount = objRow[conzx_qa_Paper.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_qa_Paper.AnswerCount].ToString().Trim()); //回答计数
objzx_qa_PaperEN.zxShareId = objRow[conzx_qa_Paper.zxShareId] == DBNull.Value ? null : objRow[conzx_qa_Paper.zxShareId].ToString().Trim(); //分享Id
objzx_qa_PaperEN.TagsCount = objRow[conzx_qa_Paper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_qa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_qa_PaperEN.ZxqaPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_qa_PaperEN);
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
public static List<clszx_qa_PaperEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clszx_qa_PaperEN> arrObjLst = new List<clszx_qa_PaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_qa_PaperEN objzx_qa_PaperEN = new clszx_qa_PaperEN();
try
{
objzx_qa_PaperEN.ZxqaPaperId = objRow[conzx_qa_Paper.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objzx_qa_PaperEN.TextId = objRow[conzx_qa_Paper.TextId] == DBNull.Value ? null : objRow[conzx_qa_Paper.TextId].ToString().Trim(); //课件Id
objzx_qa_PaperEN.QuestionsCount = objRow[conzx_qa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_qa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objzx_qa_PaperEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[conzx_qa_Paper.IsDelete].ToString().Trim()); //是否删除
objzx_qa_PaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_qa_Paper.IsPublic].ToString().Trim()); //是否公开
objzx_qa_PaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_qa_Paper.IsSubmit].ToString().Trim()); //是否提交
objzx_qa_PaperEN.UpdUser = objRow[conzx_qa_Paper.UpdUser] == DBNull.Value ? null : objRow[conzx_qa_Paper.UpdUser].ToString().Trim(); //修改人
objzx_qa_PaperEN.UpdDate = objRow[conzx_qa_Paper.UpdDate] == DBNull.Value ? null : objRow[conzx_qa_Paper.UpdDate].ToString().Trim(); //修改日期
objzx_qa_PaperEN.Memo = objRow[conzx_qa_Paper.Memo] == DBNull.Value ? null : objRow[conzx_qa_Paper.Memo].ToString().Trim(); //备注
objzx_qa_PaperEN.IdCurrEduCls = objRow[conzx_qa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_qa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_qa_PaperEN.AnswerCount = objRow[conzx_qa_Paper.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_qa_Paper.AnswerCount].ToString().Trim()); //回答计数
objzx_qa_PaperEN.zxShareId = objRow[conzx_qa_Paper.zxShareId] == DBNull.Value ? null : objRow[conzx_qa_Paper.zxShareId].ToString().Trim(); //分享Id
objzx_qa_PaperEN.TagsCount = objRow[conzx_qa_Paper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_qa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_qa_PaperEN.ZxqaPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_qa_PaperEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_qa_PaperEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clszx_qa_PaperEN> arrObjLst = new List<clszx_qa_PaperEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_qa_PaperEN objzx_qa_PaperEN = new clszx_qa_PaperEN();
try
{
objzx_qa_PaperEN.ZxqaPaperId = objRow[conzx_qa_Paper.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objzx_qa_PaperEN.TextId = objRow[conzx_qa_Paper.TextId] == DBNull.Value ? null : objRow[conzx_qa_Paper.TextId].ToString().Trim(); //课件Id
objzx_qa_PaperEN.QuestionsCount = objRow[conzx_qa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_qa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objzx_qa_PaperEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[conzx_qa_Paper.IsDelete].ToString().Trim()); //是否删除
objzx_qa_PaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_qa_Paper.IsPublic].ToString().Trim()); //是否公开
objzx_qa_PaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_qa_Paper.IsSubmit].ToString().Trim()); //是否提交
objzx_qa_PaperEN.UpdUser = objRow[conzx_qa_Paper.UpdUser] == DBNull.Value ? null : objRow[conzx_qa_Paper.UpdUser].ToString().Trim(); //修改人
objzx_qa_PaperEN.UpdDate = objRow[conzx_qa_Paper.UpdDate] == DBNull.Value ? null : objRow[conzx_qa_Paper.UpdDate].ToString().Trim(); //修改日期
objzx_qa_PaperEN.Memo = objRow[conzx_qa_Paper.Memo] == DBNull.Value ? null : objRow[conzx_qa_Paper.Memo].ToString().Trim(); //备注
objzx_qa_PaperEN.IdCurrEduCls = objRow[conzx_qa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_qa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_qa_PaperEN.AnswerCount = objRow[conzx_qa_Paper.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_qa_Paper.AnswerCount].ToString().Trim()); //回答计数
objzx_qa_PaperEN.zxShareId = objRow[conzx_qa_Paper.zxShareId] == DBNull.Value ? null : objRow[conzx_qa_Paper.zxShareId].ToString().Trim(); //分享Id
objzx_qa_PaperEN.TagsCount = objRow[conzx_qa_Paper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_qa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_qa_PaperEN.ZxqaPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_qa_PaperEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objzx_qa_PaperEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getzx_qa_Paper(ref clszx_qa_PaperEN objzx_qa_PaperEN)
{
bool bolResult = zx_qa_PaperDA.Getzx_qa_Paper(ref objzx_qa_PaperEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strZxqaPaperId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_qa_PaperEN GetObjByZxqaPaperId(string strZxqaPaperId)
{
if (strZxqaPaperId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strZxqaPaperId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strZxqaPaperId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strZxqaPaperId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clszx_qa_PaperEN objzx_qa_PaperEN = zx_qa_PaperDA.GetObjByZxqaPaperId(strZxqaPaperId);
return objzx_qa_PaperEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clszx_qa_PaperEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clszx_qa_PaperEN objzx_qa_PaperEN = zx_qa_PaperDA.GetFirstObj(strWhereCond);
 return objzx_qa_PaperEN;
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
public static clszx_qa_PaperEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clszx_qa_PaperEN objzx_qa_PaperEN = zx_qa_PaperDA.GetObjByDataRow(objRow);
 return objzx_qa_PaperEN;
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
public static clszx_qa_PaperEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clszx_qa_PaperEN objzx_qa_PaperEN = zx_qa_PaperDA.GetObjByDataRow(objRow);
 return objzx_qa_PaperEN;
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
 /// <param name = "strZxqaPaperId">所给的关键字</param>
 /// <param name = "lstzx_qa_PaperObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_qa_PaperEN GetObjByZxqaPaperIdFromList(string strZxqaPaperId, List<clszx_qa_PaperEN> lstzx_qa_PaperObjLst)
{
foreach (clszx_qa_PaperEN objzx_qa_PaperEN in lstzx_qa_PaperObjLst)
{
if (objzx_qa_PaperEN.ZxqaPaperId == strZxqaPaperId)
{
return objzx_qa_PaperEN;
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
 string strMaxZxqaPaperId;
 try
 {
 strMaxZxqaPaperId = clszx_qa_PaperDA.GetMaxStrId();
 return strMaxZxqaPaperId;
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
 string strZxqaPaperId;
 try
 {
 strZxqaPaperId = new clszx_qa_PaperDA().GetFirstID(strWhereCond);
 return strZxqaPaperId;
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
 arrList = zx_qa_PaperDA.GetID(strWhereCond);
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
bool bolIsExist = zx_qa_PaperDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strZxqaPaperId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strZxqaPaperId)
{
if (string.IsNullOrEmpty(strZxqaPaperId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strZxqaPaperId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = zx_qa_PaperDA.IsExist(strZxqaPaperId);
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
 bolIsExist = clszx_qa_PaperDA.IsExistTable();
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
 bolIsExist = zx_qa_PaperDA.IsExistTable(strTabName);
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
 /// <param name = "objzx_qa_PaperEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clszx_qa_PaperEN objzx_qa_PaperEN)
{
if (objzx_qa_PaperEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!论文答疑Id = [{0}]的数据已经存在!(in clszx_qa_PaperBL.AddNewRecordBySql2)", objzx_qa_PaperEN.ZxqaPaperId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_qa_PaperEN.ZxqaPaperId) == true || clszx_qa_PaperBL.IsExist(objzx_qa_PaperEN.ZxqaPaperId) == true)
 {
     objzx_qa_PaperEN.ZxqaPaperId = clszx_qa_PaperBL.GetMaxStrId_S();
 }
bool bolResult = zx_qa_PaperDA.AddNewRecordBySQL2(objzx_qa_PaperEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_qa_PaperBL.ReFreshCache();

if (clszx_qa_PaperBL.relatedActions != null)
{
clszx_qa_PaperBL.relatedActions.UpdRelaTabDate(objzx_qa_PaperEN.ZxqaPaperId, "SetUpdDate");
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
 /// <param name = "objzx_qa_PaperEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clszx_qa_PaperEN objzx_qa_PaperEN)
{
if (objzx_qa_PaperEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!论文答疑Id = [{0}]的数据已经存在!(in clszx_qa_PaperBL.AddNewRecordBySql2WithReturnKey)", objzx_qa_PaperEN.ZxqaPaperId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_qa_PaperEN.ZxqaPaperId) == true || clszx_qa_PaperBL.IsExist(objzx_qa_PaperEN.ZxqaPaperId) == true)
 {
     objzx_qa_PaperEN.ZxqaPaperId = clszx_qa_PaperBL.GetMaxStrId_S();
 }
string strKey = zx_qa_PaperDA.AddNewRecordBySQL2WithReturnKey(objzx_qa_PaperEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_qa_PaperBL.ReFreshCache();

if (clszx_qa_PaperBL.relatedActions != null)
{
clszx_qa_PaperBL.relatedActions.UpdRelaTabDate(objzx_qa_PaperEN.ZxqaPaperId, "SetUpdDate");
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
 /// <param name = "objzx_qa_PaperEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clszx_qa_PaperEN objzx_qa_PaperEN)
{
try
{
bool bolResult = zx_qa_PaperDA.Update(objzx_qa_PaperEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_qa_PaperBL.ReFreshCache();

if (clszx_qa_PaperBL.relatedActions != null)
{
clszx_qa_PaperBL.relatedActions.UpdRelaTabDate(objzx_qa_PaperEN.ZxqaPaperId, "SetUpdDate");
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
 /// <param name = "objzx_qa_PaperEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clszx_qa_PaperEN objzx_qa_PaperEN)
{
 if (string.IsNullOrEmpty(objzx_qa_PaperEN.ZxqaPaperId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = zx_qa_PaperDA.UpdateBySql2(objzx_qa_PaperEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_qa_PaperBL.ReFreshCache();

if (clszx_qa_PaperBL.relatedActions != null)
{
clszx_qa_PaperBL.relatedActions.UpdRelaTabDate(objzx_qa_PaperEN.ZxqaPaperId, "SetUpdDate");
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
 /// <param name = "strZxqaPaperId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strZxqaPaperId)
{
try
{
 clszx_qa_PaperEN objzx_qa_PaperEN = clszx_qa_PaperBL.GetObjByZxqaPaperId(strZxqaPaperId);

if (clszx_qa_PaperBL.relatedActions != null)
{
clszx_qa_PaperBL.relatedActions.UpdRelaTabDate(objzx_qa_PaperEN.ZxqaPaperId, "SetUpdDate");
}
if (objzx_qa_PaperEN != null)
{
int intRecNum = zx_qa_PaperDA.DelRecord(strZxqaPaperId);
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
/// <param name="strZxqaPaperId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strZxqaPaperId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_qa_PaperDA.GetSpecSQLObj();
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
//删除与表:[zx_qa_Paper]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conzx_qa_Paper.ZxqaPaperId,
//strZxqaPaperId);
//        clszx_qa_PaperBL.Delzx_qa_PapersByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_qa_PaperBL.DelRecord(strZxqaPaperId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_qa_PaperBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strZxqaPaperId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strZxqaPaperId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strZxqaPaperId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clszx_qa_PaperBL.relatedActions != null)
{
clszx_qa_PaperBL.relatedActions.UpdRelaTabDate(strZxqaPaperId, "UpdRelaTabDate");
}
bool bolResult = zx_qa_PaperDA.DelRecord(strZxqaPaperId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrZxqaPaperIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delzx_qa_Papers(List<string> arrZxqaPaperIdLst)
{
if (arrZxqaPaperIdLst.Count == 0) return 0;
try
{
if (clszx_qa_PaperBL.relatedActions != null)
{
foreach (var strZxqaPaperId in arrZxqaPaperIdLst)
{
clszx_qa_PaperBL.relatedActions.UpdRelaTabDate(strZxqaPaperId, "UpdRelaTabDate");
}
}
int intDelRecNum = zx_qa_PaperDA.Delzx_qa_Paper(arrZxqaPaperIdLst);
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
public static int Delzx_qa_PapersByCond(string strWhereCond)
{
try
{
if (clszx_qa_PaperBL.relatedActions != null)
{
List<string> arrZxqaPaperId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strZxqaPaperId in arrZxqaPaperId)
{
clszx_qa_PaperBL.relatedActions.UpdRelaTabDate(strZxqaPaperId, "UpdRelaTabDate");
}
}
int intRecNum = zx_qa_PaperDA.Delzx_qa_Paper(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[zx_qa_Paper]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strZxqaPaperId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strZxqaPaperId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_qa_PaperDA.GetSpecSQLObj();
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
//删除与表:[zx_qa_Paper]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_qa_PaperBL.DelRecord(strZxqaPaperId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_qa_PaperBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strZxqaPaperId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objzx_qa_PaperENS">源对象</param>
 /// <param name = "objzx_qa_PaperENT">目标对象</param>
 public static void CopyTo(clszx_qa_PaperEN objzx_qa_PaperENS, clszx_qa_PaperEN objzx_qa_PaperENT)
{
try
{
objzx_qa_PaperENT.ZxqaPaperId = objzx_qa_PaperENS.ZxqaPaperId; //论文答疑Id
objzx_qa_PaperENT.TextId = objzx_qa_PaperENS.TextId; //课件Id
objzx_qa_PaperENT.QuestionsCount = objzx_qa_PaperENS.QuestionsCount; //提问计数
objzx_qa_PaperENT.IsDelete = objzx_qa_PaperENS.IsDelete; //是否删除
objzx_qa_PaperENT.IsPublic = objzx_qa_PaperENS.IsPublic; //是否公开
objzx_qa_PaperENT.IsSubmit = objzx_qa_PaperENS.IsSubmit; //是否提交
objzx_qa_PaperENT.UpdUser = objzx_qa_PaperENS.UpdUser; //修改人
objzx_qa_PaperENT.UpdDate = objzx_qa_PaperENS.UpdDate; //修改日期
objzx_qa_PaperENT.Memo = objzx_qa_PaperENS.Memo; //备注
objzx_qa_PaperENT.IdCurrEduCls = objzx_qa_PaperENS.IdCurrEduCls; //教学班流水号
objzx_qa_PaperENT.AnswerCount = objzx_qa_PaperENS.AnswerCount; //回答计数
objzx_qa_PaperENT.zxShareId = objzx_qa_PaperENS.zxShareId; //分享Id
objzx_qa_PaperENT.TagsCount = objzx_qa_PaperENS.TagsCount; //论文标注数
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
 /// <param name = "objzx_qa_PaperEN">源简化对象</param>
 public static void SetUpdFlag(clszx_qa_PaperEN objzx_qa_PaperEN)
{
try
{
objzx_qa_PaperEN.ClearUpdateState();
   string strsfUpdFldSetStr = objzx_qa_PaperEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conzx_qa_Paper.ZxqaPaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_qa_PaperEN.ZxqaPaperId = objzx_qa_PaperEN.ZxqaPaperId; //论文答疑Id
}
if (arrFldSet.Contains(conzx_qa_Paper.TextId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_qa_PaperEN.TextId = objzx_qa_PaperEN.TextId == "[null]" ? null :  objzx_qa_PaperEN.TextId; //课件Id
}
if (arrFldSet.Contains(conzx_qa_Paper.QuestionsCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_qa_PaperEN.QuestionsCount = objzx_qa_PaperEN.QuestionsCount; //提问计数
}
if (arrFldSet.Contains(conzx_qa_Paper.IsDelete, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_qa_PaperEN.IsDelete = objzx_qa_PaperEN.IsDelete; //是否删除
}
if (arrFldSet.Contains(conzx_qa_Paper.IsPublic, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_qa_PaperEN.IsPublic = objzx_qa_PaperEN.IsPublic; //是否公开
}
if (arrFldSet.Contains(conzx_qa_Paper.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_qa_PaperEN.IsSubmit = objzx_qa_PaperEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(conzx_qa_Paper.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_qa_PaperEN.UpdUser = objzx_qa_PaperEN.UpdUser == "[null]" ? null :  objzx_qa_PaperEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conzx_qa_Paper.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_qa_PaperEN.UpdDate = objzx_qa_PaperEN.UpdDate == "[null]" ? null :  objzx_qa_PaperEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conzx_qa_Paper.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_qa_PaperEN.Memo = objzx_qa_PaperEN.Memo == "[null]" ? null :  objzx_qa_PaperEN.Memo; //备注
}
if (arrFldSet.Contains(conzx_qa_Paper.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_qa_PaperEN.IdCurrEduCls = objzx_qa_PaperEN.IdCurrEduCls == "[null]" ? null :  objzx_qa_PaperEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conzx_qa_Paper.AnswerCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_qa_PaperEN.AnswerCount = objzx_qa_PaperEN.AnswerCount; //回答计数
}
if (arrFldSet.Contains(conzx_qa_Paper.zxShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_qa_PaperEN.zxShareId = objzx_qa_PaperEN.zxShareId == "[null]" ? null :  objzx_qa_PaperEN.zxShareId; //分享Id
}
if (arrFldSet.Contains(conzx_qa_Paper.TagsCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_qa_PaperEN.TagsCount = objzx_qa_PaperEN.TagsCount; //论文标注数
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
 /// <param name = "objzx_qa_PaperEN">源简化对象</param>
 public static void AccessFldValueNull(clszx_qa_PaperEN objzx_qa_PaperEN)
{
try
{
if (objzx_qa_PaperEN.TextId == "[null]") objzx_qa_PaperEN.TextId = null; //课件Id
if (objzx_qa_PaperEN.UpdUser == "[null]") objzx_qa_PaperEN.UpdUser = null; //修改人
if (objzx_qa_PaperEN.UpdDate == "[null]") objzx_qa_PaperEN.UpdDate = null; //修改日期
if (objzx_qa_PaperEN.Memo == "[null]") objzx_qa_PaperEN.Memo = null; //备注
if (objzx_qa_PaperEN.IdCurrEduCls == "[null]") objzx_qa_PaperEN.IdCurrEduCls = null; //教学班流水号
if (objzx_qa_PaperEN.zxShareId == "[null]") objzx_qa_PaperEN.zxShareId = null; //分享Id
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
public static void CheckPropertyNew(clszx_qa_PaperEN objzx_qa_PaperEN)
{
 zx_qa_PaperDA.CheckPropertyNew(objzx_qa_PaperEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clszx_qa_PaperEN objzx_qa_PaperEN)
{
 zx_qa_PaperDA.CheckProperty4Condition(objzx_qa_PaperEN);
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
if (clszx_qa_PaperBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_qa_PaperBL没有刷新缓存机制(clszx_qa_PaperBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ZxqaPaperId");
//if (arrzx_qa_PaperObjLstCache == null)
//{
//arrzx_qa_PaperObjLstCache = zx_qa_PaperDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strZxqaPaperId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_qa_PaperEN GetObjByZxqaPaperIdCache(string strZxqaPaperId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clszx_qa_PaperEN._CurrTabName);
List<clszx_qa_PaperEN> arrzx_qa_PaperObjLstCache = GetObjLstCache();
IEnumerable <clszx_qa_PaperEN> arrzx_qa_PaperObjLst_Sel =
arrzx_qa_PaperObjLstCache
.Where(x=> x.ZxqaPaperId == strZxqaPaperId 
);
if (arrzx_qa_PaperObjLst_Sel.Count() == 0)
{
   clszx_qa_PaperEN obj = clszx_qa_PaperBL.GetObjByZxqaPaperId(strZxqaPaperId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrzx_qa_PaperObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_qa_PaperEN> GetAllzx_qa_PaperObjLstCache()
{
//获取缓存中的对象列表
List<clszx_qa_PaperEN> arrzx_qa_PaperObjLstCache = GetObjLstCache(); 
return arrzx_qa_PaperObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_qa_PaperEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clszx_qa_PaperEN._CurrTabName);
List<clszx_qa_PaperEN> arrzx_qa_PaperObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrzx_qa_PaperObjLstCache;
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
string strKey = string.Format("{0}", clszx_qa_PaperEN._CurrTabName);
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
if (clszx_qa_PaperBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clszx_qa_PaperEN._CurrTabName);
CacheHelper.Remove(strKey);
clszx_qa_PaperBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--zx_qa_Paper(中学论文答疑表)
 /// 唯一性条件:zxqa_PaperId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_qa_PaperEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clszx_qa_PaperEN objzx_qa_PaperEN)
{
//检测记录是否存在
string strResult = zx_qa_PaperDA.GetUniCondStr(objzx_qa_PaperEN);
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
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strZxqaPaperId)
{
if (strInFldName != conzx_qa_Paper.ZxqaPaperId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conzx_qa_Paper.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conzx_qa_Paper.AttributeName));
throw new Exception(strMsg);
}
var objzx_qa_Paper = clszx_qa_PaperBL.GetObjByZxqaPaperIdCache(strZxqaPaperId);
if (objzx_qa_Paper == null) return "";
return objzx_qa_Paper[strOutFldName].ToString();
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
int intRecCount = clszx_qa_PaperDA.GetRecCount(strTabName);
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
int intRecCount = clszx_qa_PaperDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clszx_qa_PaperDA.GetRecCount();
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
int intRecCount = clszx_qa_PaperDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objzx_qa_PaperCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clszx_qa_PaperEN objzx_qa_PaperCond)
{
List<clszx_qa_PaperEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clszx_qa_PaperEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_qa_Paper.AttributeName)
{
if (objzx_qa_PaperCond.IsUpdated(strFldName) == false) continue;
if (objzx_qa_PaperCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_qa_PaperCond[strFldName].ToString());
}
else
{
if (objzx_qa_PaperCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_qa_PaperCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_qa_PaperCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_qa_PaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_qa_PaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_qa_PaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_qa_PaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_qa_PaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_qa_PaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_qa_PaperCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_qa_PaperCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_qa_PaperCond[strFldName]));
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
 List<string> arrList = clszx_qa_PaperDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = zx_qa_PaperDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = zx_qa_PaperDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = zx_qa_PaperDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_qa_PaperDA.SetFldValue(clszx_qa_PaperEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = zx_qa_PaperDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_qa_PaperDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_qa_PaperDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_qa_PaperDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[zx_qa_Paper] "); 
 strCreateTabCode.Append(" ( "); 
 // /**论文答疑Id*/ 
 strCreateTabCode.Append(" ZxqaPaperId char(8) primary key, "); 
 // /**课件Id*/ 
 strCreateTabCode.Append(" TextId char(8) Null, "); 
 // /**提问计数*/ 
 strCreateTabCode.Append(" QuestionsCount int Null, "); 
 // /**是否删除*/ 
 strCreateTabCode.Append(" IsDelete bit Null, "); 
 // /**是否公开*/ 
 strCreateTabCode.Append(" IsPublic bit Null, "); 
 // /**是否提交*/ 
 strCreateTabCode.Append(" IsSubmit bit Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) Null, "); 
 // /**回答计数*/ 
 strCreateTabCode.Append(" AnswerCount int Null, "); 
 // /**分享Id*/ 
 strCreateTabCode.Append(" zxShareId char(2) Null, "); 
 // /**论文标注数*/ 
 strCreateTabCode.Append(" TagsCount int Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 中学论文答疑表(zx_qa_Paper)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4zx_qa_Paper : clsCommFun4BL
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
clszx_qa_PaperBL.ReFreshThisCache();
}
}

}