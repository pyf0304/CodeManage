
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_TobeStudiedProblemVerBL
 表名:zx_TobeStudiedProblemVer(01120805)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 23:06:48
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
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
public static class  clszx_TobeStudiedProblemVerBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngProblemVId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_TobeStudiedProblemVerEN GetObj(this K_ProblemVId_zx_TobeStudiedProblemVer myKey)
{
clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN = clszx_TobeStudiedProblemVerBL.zx_TobeStudiedProblemVerDA.GetObjByProblemVId(myKey.Value);
return objzx_TobeStudiedProblemVerEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objzx_TobeStudiedProblemVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN)
{
if (CheckUniqueness(objzx_TobeStudiedProblemVerEN) == false)
{
var strMsg = string.Format("记录已经存在!ProblemVId = [{0}],问题Id = [{1}]的数据已经存在!(in clszx_TobeStudiedProblemVerBL.AddNewRecord)", objzx_TobeStudiedProblemVerEN.ProblemVId,objzx_TobeStudiedProblemVerEN.ProblemId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clszx_TobeStudiedProblemVerBL.zx_TobeStudiedProblemVerDA.AddNewRecordBySQL2(objzx_TobeStudiedProblemVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TobeStudiedProblemVerBL.ReFreshCache();

if (clszx_TobeStudiedProblemVerBL.relatedActions != null)
{
clszx_TobeStudiedProblemVerBL.relatedActions.UpdRelaTabDate(objzx_TobeStudiedProblemVerEN.ProblemVId, "SetUpdDate");
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
public static bool AddRecordEx(this clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN)
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
objzx_TobeStudiedProblemVerEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objzx_TobeStudiedProblemVerEN.CheckUniqueness() == false)
{
strMsg = string.Format("(ProblemVId(ProblemVId)=[{0}],问题Id(ProblemId)=[{1}])已经存在,不能重复!", objzx_TobeStudiedProblemVerEN.ProblemVId, objzx_TobeStudiedProblemVerEN.ProblemId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objzx_TobeStudiedProblemVerEN.AddNewRecord();
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
 /// <param name = "objzx_TobeStudiedProblemVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN)
{
if (CheckUniqueness(objzx_TobeStudiedProblemVerEN) == false)
{
var strMsg = string.Format("记录已经存在!ProblemVId = [{0}],问题Id = [{1}]的数据已经存在!(in clszx_TobeStudiedProblemVerBL.AddNewRecordWithReturnKey)", objzx_TobeStudiedProblemVerEN.ProblemVId,objzx_TobeStudiedProblemVerEN.ProblemId);
throw new Exception(strMsg);
}
try
{
string strKey = clszx_TobeStudiedProblemVerBL.zx_TobeStudiedProblemVerDA.AddNewRecordBySQL2WithReturnKey(objzx_TobeStudiedProblemVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TobeStudiedProblemVerBL.ReFreshCache();

if (clszx_TobeStudiedProblemVerBL.relatedActions != null)
{
clszx_TobeStudiedProblemVerBL.relatedActions.UpdRelaTabDate(objzx_TobeStudiedProblemVerEN.ProblemVId, "SetUpdDate");
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
 /// <param name = "objzx_TobeStudiedProblemVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TobeStudiedProblemVerEN SetProblemVId(this clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN, long lngProblemVId, string strComparisonOp="")
	{
objzx_TobeStudiedProblemVerEN.ProblemVId = lngProblemVId; //ProblemVId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TobeStudiedProblemVerEN.dicFldComparisonOp.ContainsKey(conzx_TobeStudiedProblemVer.ProblemVId) == false)
{
objzx_TobeStudiedProblemVerEN.dicFldComparisonOp.Add(conzx_TobeStudiedProblemVer.ProblemVId, strComparisonOp);
}
else
{
objzx_TobeStudiedProblemVerEN.dicFldComparisonOp[conzx_TobeStudiedProblemVer.ProblemVId] = strComparisonOp;
}
}
return objzx_TobeStudiedProblemVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TobeStudiedProblemVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TobeStudiedProblemVerEN SetProblemId(this clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN, string strProblemId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProblemId, conzx_TobeStudiedProblemVer.ProblemId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProblemId, 10, conzx_TobeStudiedProblemVer.ProblemId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strProblemId, 10, conzx_TobeStudiedProblemVer.ProblemId);
}
objzx_TobeStudiedProblemVerEN.ProblemId = strProblemId; //问题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TobeStudiedProblemVerEN.dicFldComparisonOp.ContainsKey(conzx_TobeStudiedProblemVer.ProblemId) == false)
{
objzx_TobeStudiedProblemVerEN.dicFldComparisonOp.Add(conzx_TobeStudiedProblemVer.ProblemId, strComparisonOp);
}
else
{
objzx_TobeStudiedProblemVerEN.dicFldComparisonOp[conzx_TobeStudiedProblemVer.ProblemId] = strComparisonOp;
}
}
return objzx_TobeStudiedProblemVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TobeStudiedProblemVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TobeStudiedProblemVerEN SetGroupTextId(this clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN, string strGroupTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupTextId, 8, conzx_TobeStudiedProblemVer.GroupTextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGroupTextId, 8, conzx_TobeStudiedProblemVer.GroupTextId);
}
objzx_TobeStudiedProblemVerEN.GroupTextId = strGroupTextId; //小组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TobeStudiedProblemVerEN.dicFldComparisonOp.ContainsKey(conzx_TobeStudiedProblemVer.GroupTextId) == false)
{
objzx_TobeStudiedProblemVerEN.dicFldComparisonOp.Add(conzx_TobeStudiedProblemVer.GroupTextId, strComparisonOp);
}
else
{
objzx_TobeStudiedProblemVerEN.dicFldComparisonOp[conzx_TobeStudiedProblemVer.GroupTextId] = strComparisonOp;
}
}
return objzx_TobeStudiedProblemVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TobeStudiedProblemVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TobeStudiedProblemVerEN SetIsSubmit(this clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN, bool bolIsSubmit, string strComparisonOp="")
	{
objzx_TobeStudiedProblemVerEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TobeStudiedProblemVerEN.dicFldComparisonOp.ContainsKey(conzx_TobeStudiedProblemVer.IsSubmit) == false)
{
objzx_TobeStudiedProblemVerEN.dicFldComparisonOp.Add(conzx_TobeStudiedProblemVer.IsSubmit, strComparisonOp);
}
else
{
objzx_TobeStudiedProblemVerEN.dicFldComparisonOp[conzx_TobeStudiedProblemVer.IsSubmit] = strComparisonOp;
}
}
return objzx_TobeStudiedProblemVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TobeStudiedProblemVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TobeStudiedProblemVerEN SetProblemContent(this clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN, string strProblemContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProblemContent, 5000, conzx_TobeStudiedProblemVer.ProblemContent);
}
objzx_TobeStudiedProblemVerEN.ProblemContent = strProblemContent; //问题内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TobeStudiedProblemVerEN.dicFldComparisonOp.ContainsKey(conzx_TobeStudiedProblemVer.ProblemContent) == false)
{
objzx_TobeStudiedProblemVerEN.dicFldComparisonOp.Add(conzx_TobeStudiedProblemVer.ProblemContent, strComparisonOp);
}
else
{
objzx_TobeStudiedProblemVerEN.dicFldComparisonOp[conzx_TobeStudiedProblemVer.ProblemContent] = strComparisonOp;
}
}
return objzx_TobeStudiedProblemVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TobeStudiedProblemVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TobeStudiedProblemVerEN SetProblemDate(this clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN, string strProblemDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProblemDate, 20, conzx_TobeStudiedProblemVer.ProblemDate);
}
objzx_TobeStudiedProblemVerEN.ProblemDate = strProblemDate; //问题日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TobeStudiedProblemVerEN.dicFldComparisonOp.ContainsKey(conzx_TobeStudiedProblemVer.ProblemDate) == false)
{
objzx_TobeStudiedProblemVerEN.dicFldComparisonOp.Add(conzx_TobeStudiedProblemVer.ProblemDate, strComparisonOp);
}
else
{
objzx_TobeStudiedProblemVerEN.dicFldComparisonOp[conzx_TobeStudiedProblemVer.ProblemDate] = strComparisonOp;
}
}
return objzx_TobeStudiedProblemVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TobeStudiedProblemVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TobeStudiedProblemVerEN SetParticipant(this clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN, string strParticipant, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParticipant, 500, conzx_TobeStudiedProblemVer.Participant);
}
objzx_TobeStudiedProblemVerEN.Participant = strParticipant; //参与者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TobeStudiedProblemVerEN.dicFldComparisonOp.ContainsKey(conzx_TobeStudiedProblemVer.Participant) == false)
{
objzx_TobeStudiedProblemVerEN.dicFldComparisonOp.Add(conzx_TobeStudiedProblemVer.Participant, strComparisonOp);
}
else
{
objzx_TobeStudiedProblemVerEN.dicFldComparisonOp[conzx_TobeStudiedProblemVer.Participant] = strComparisonOp;
}
}
return objzx_TobeStudiedProblemVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TobeStudiedProblemVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TobeStudiedProblemVerEN SetUpdDate(this clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conzx_TobeStudiedProblemVer.UpdDate);
}
objzx_TobeStudiedProblemVerEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TobeStudiedProblemVerEN.dicFldComparisonOp.ContainsKey(conzx_TobeStudiedProblemVer.UpdDate) == false)
{
objzx_TobeStudiedProblemVerEN.dicFldComparisonOp.Add(conzx_TobeStudiedProblemVer.UpdDate, strComparisonOp);
}
else
{
objzx_TobeStudiedProblemVerEN.dicFldComparisonOp[conzx_TobeStudiedProblemVer.UpdDate] = strComparisonOp;
}
}
return objzx_TobeStudiedProblemVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TobeStudiedProblemVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TobeStudiedProblemVerEN SetUpdUser(this clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conzx_TobeStudiedProblemVer.UpdUser);
}
objzx_TobeStudiedProblemVerEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TobeStudiedProblemVerEN.dicFldComparisonOp.ContainsKey(conzx_TobeStudiedProblemVer.UpdUser) == false)
{
objzx_TobeStudiedProblemVerEN.dicFldComparisonOp.Add(conzx_TobeStudiedProblemVer.UpdUser, strComparisonOp);
}
else
{
objzx_TobeStudiedProblemVerEN.dicFldComparisonOp[conzx_TobeStudiedProblemVer.UpdUser] = strComparisonOp;
}
}
return objzx_TobeStudiedProblemVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TobeStudiedProblemVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TobeStudiedProblemVerEN SetYear(this clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN, string strYear, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strYear, 4, conzx_TobeStudiedProblemVer.Year);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strYear, 4, conzx_TobeStudiedProblemVer.Year);
}
objzx_TobeStudiedProblemVerEN.Year = strYear; //年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TobeStudiedProblemVerEN.dicFldComparisonOp.ContainsKey(conzx_TobeStudiedProblemVer.Year) == false)
{
objzx_TobeStudiedProblemVerEN.dicFldComparisonOp.Add(conzx_TobeStudiedProblemVer.Year, strComparisonOp);
}
else
{
objzx_TobeStudiedProblemVerEN.dicFldComparisonOp[conzx_TobeStudiedProblemVer.Year] = strComparisonOp;
}
}
return objzx_TobeStudiedProblemVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TobeStudiedProblemVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TobeStudiedProblemVerEN SetMonth(this clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN, string strMonth, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMonth, 2, conzx_TobeStudiedProblemVer.Month);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMonth, 2, conzx_TobeStudiedProblemVer.Month);
}
objzx_TobeStudiedProblemVerEN.Month = strMonth; //月
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TobeStudiedProblemVerEN.dicFldComparisonOp.ContainsKey(conzx_TobeStudiedProblemVer.Month) == false)
{
objzx_TobeStudiedProblemVerEN.dicFldComparisonOp.Add(conzx_TobeStudiedProblemVer.Month, strComparisonOp);
}
else
{
objzx_TobeStudiedProblemVerEN.dicFldComparisonOp[conzx_TobeStudiedProblemVer.Month] = strComparisonOp;
}
}
return objzx_TobeStudiedProblemVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TobeStudiedProblemVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TobeStudiedProblemVerEN SetMemo(this clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conzx_TobeStudiedProblemVer.Memo);
}
objzx_TobeStudiedProblemVerEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TobeStudiedProblemVerEN.dicFldComparisonOp.ContainsKey(conzx_TobeStudiedProblemVer.Memo) == false)
{
objzx_TobeStudiedProblemVerEN.dicFldComparisonOp.Add(conzx_TobeStudiedProblemVer.Memo, strComparisonOp);
}
else
{
objzx_TobeStudiedProblemVerEN.dicFldComparisonOp[conzx_TobeStudiedProblemVer.Memo] = strComparisonOp;
}
}
return objzx_TobeStudiedProblemVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TobeStudiedProblemVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TobeStudiedProblemVerEN SetProblemTitle(this clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN, string strProblemTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProblemTitle, 1000, conzx_TobeStudiedProblemVer.ProblemTitle);
}
objzx_TobeStudiedProblemVerEN.ProblemTitle = strProblemTitle; //问题标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TobeStudiedProblemVerEN.dicFldComparisonOp.ContainsKey(conzx_TobeStudiedProblemVer.ProblemTitle) == false)
{
objzx_TobeStudiedProblemVerEN.dicFldComparisonOp.Add(conzx_TobeStudiedProblemVer.ProblemTitle, strComparisonOp);
}
else
{
objzx_TobeStudiedProblemVerEN.dicFldComparisonOp[conzx_TobeStudiedProblemVer.ProblemTitle] = strComparisonOp;
}
}
return objzx_TobeStudiedProblemVerEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objzx_TobeStudiedProblemVerEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objzx_TobeStudiedProblemVerEN.CheckPropertyNew();
clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerCond = new clszx_TobeStudiedProblemVerEN();
string strCondition = objzx_TobeStudiedProblemVerCond
.SetProblemVId(objzx_TobeStudiedProblemVerEN.ProblemVId, "<>")
.SetProblemVId(objzx_TobeStudiedProblemVerEN.ProblemVId, "=")
.SetProblemId(objzx_TobeStudiedProblemVerEN.ProblemId, "=")
.GetCombineCondition();
objzx_TobeStudiedProblemVerEN._IsCheckProperty = true;
bool bolIsExist = clszx_TobeStudiedProblemVerBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(ProblemVId_ProblemId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objzx_TobeStudiedProblemVerEN.Update();
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
 /// <param name = "objzx_TobeStudiedProblemVer">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVer)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerCond = new clszx_TobeStudiedProblemVerEN();
string strCondition = objzx_TobeStudiedProblemVerCond
.SetProblemVId(objzx_TobeStudiedProblemVer.ProblemVId, "=")
.SetProblemId(objzx_TobeStudiedProblemVer.ProblemId, "=")
.GetCombineCondition();
objzx_TobeStudiedProblemVer._IsCheckProperty = true;
bool bolIsExist = clszx_TobeStudiedProblemVerBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objzx_TobeStudiedProblemVer.ProblemVId = clszx_TobeStudiedProblemVerBL.GetFirstID_S(strCondition);
objzx_TobeStudiedProblemVer.UpdateWithCondition(strCondition);
}
else
{
objzx_TobeStudiedProblemVer.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objzx_TobeStudiedProblemVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN)
{
 if (objzx_TobeStudiedProblemVerEN.ProblemVId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_TobeStudiedProblemVerBL.zx_TobeStudiedProblemVerDA.UpdateBySql2(objzx_TobeStudiedProblemVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TobeStudiedProblemVerBL.ReFreshCache();

if (clszx_TobeStudiedProblemVerBL.relatedActions != null)
{
clszx_TobeStudiedProblemVerBL.relatedActions.UpdRelaTabDate(objzx_TobeStudiedProblemVerEN.ProblemVId, "SetUpdDate");
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
 /// <param name = "objzx_TobeStudiedProblemVerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_TobeStudiedProblemVerEN.ProblemVId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_TobeStudiedProblemVerBL.zx_TobeStudiedProblemVerDA.UpdateBySql2(objzx_TobeStudiedProblemVerEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TobeStudiedProblemVerBL.ReFreshCache();

if (clszx_TobeStudiedProblemVerBL.relatedActions != null)
{
clszx_TobeStudiedProblemVerBL.relatedActions.UpdRelaTabDate(objzx_TobeStudiedProblemVerEN.ProblemVId, "SetUpdDate");
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
 /// <param name = "objzx_TobeStudiedProblemVerEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN, string strWhereCond)
{
try
{
bool bolResult = clszx_TobeStudiedProblemVerBL.zx_TobeStudiedProblemVerDA.UpdateBySqlWithCondition(objzx_TobeStudiedProblemVerEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TobeStudiedProblemVerBL.ReFreshCache();

if (clszx_TobeStudiedProblemVerBL.relatedActions != null)
{
clszx_TobeStudiedProblemVerBL.relatedActions.UpdRelaTabDate(objzx_TobeStudiedProblemVerEN.ProblemVId, "SetUpdDate");
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
 /// <param name = "objzx_TobeStudiedProblemVerEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clszx_TobeStudiedProblemVerBL.zx_TobeStudiedProblemVerDA.UpdateBySqlWithConditionTransaction(objzx_TobeStudiedProblemVerEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TobeStudiedProblemVerBL.ReFreshCache();

if (clszx_TobeStudiedProblemVerBL.relatedActions != null)
{
clszx_TobeStudiedProblemVerBL.relatedActions.UpdRelaTabDate(objzx_TobeStudiedProblemVerEN.ProblemVId, "SetUpdDate");
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
 /// <param name = "lngProblemVId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN)
{
try
{
int intRecNum = clszx_TobeStudiedProblemVerBL.zx_TobeStudiedProblemVerDA.DelRecord(objzx_TobeStudiedProblemVerEN.ProblemVId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TobeStudiedProblemVerBL.ReFreshCache();

if (clszx_TobeStudiedProblemVerBL.relatedActions != null)
{
clszx_TobeStudiedProblemVerBL.relatedActions.UpdRelaTabDate(objzx_TobeStudiedProblemVerEN.ProblemVId, "SetUpdDate");
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
 /// <param name = "objzx_TobeStudiedProblemVerENS">源对象</param>
 /// <param name = "objzx_TobeStudiedProblemVerENT">目标对象</param>
 public static void CopyTo(this clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerENS, clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerENT)
{
try
{
objzx_TobeStudiedProblemVerENT.ProblemVId = objzx_TobeStudiedProblemVerENS.ProblemVId; //ProblemVId
objzx_TobeStudiedProblemVerENT.ProblemId = objzx_TobeStudiedProblemVerENS.ProblemId; //问题Id
objzx_TobeStudiedProblemVerENT.GroupTextId = objzx_TobeStudiedProblemVerENS.GroupTextId; //小组Id
objzx_TobeStudiedProblemVerENT.IsSubmit = objzx_TobeStudiedProblemVerENS.IsSubmit; //是否提交
objzx_TobeStudiedProblemVerENT.ProblemContent = objzx_TobeStudiedProblemVerENS.ProblemContent; //问题内容
objzx_TobeStudiedProblemVerENT.ProblemDate = objzx_TobeStudiedProblemVerENS.ProblemDate; //问题日期
objzx_TobeStudiedProblemVerENT.Participant = objzx_TobeStudiedProblemVerENS.Participant; //参与者
objzx_TobeStudiedProblemVerENT.UpdDate = objzx_TobeStudiedProblemVerENS.UpdDate; //修改日期
objzx_TobeStudiedProblemVerENT.UpdUser = objzx_TobeStudiedProblemVerENS.UpdUser; //修改人
objzx_TobeStudiedProblemVerENT.Year = objzx_TobeStudiedProblemVerENS.Year; //年
objzx_TobeStudiedProblemVerENT.Month = objzx_TobeStudiedProblemVerENS.Month; //月
objzx_TobeStudiedProblemVerENT.Memo = objzx_TobeStudiedProblemVerENS.Memo; //备注
objzx_TobeStudiedProblemVerENT.ProblemTitle = objzx_TobeStudiedProblemVerENS.ProblemTitle; //问题标题
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
 /// <param name = "objzx_TobeStudiedProblemVerENS">源对象</param>
 /// <returns>目标对象=>clszx_TobeStudiedProblemVerEN:objzx_TobeStudiedProblemVerENT</returns>
 public static clszx_TobeStudiedProblemVerEN CopyTo(this clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerENS)
{
try
{
 clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerENT = new clszx_TobeStudiedProblemVerEN()
{
ProblemVId = objzx_TobeStudiedProblemVerENS.ProblemVId, //ProblemVId
ProblemId = objzx_TobeStudiedProblemVerENS.ProblemId, //问题Id
GroupTextId = objzx_TobeStudiedProblemVerENS.GroupTextId, //小组Id
IsSubmit = objzx_TobeStudiedProblemVerENS.IsSubmit, //是否提交
ProblemContent = objzx_TobeStudiedProblemVerENS.ProblemContent, //问题内容
ProblemDate = objzx_TobeStudiedProblemVerENS.ProblemDate, //问题日期
Participant = objzx_TobeStudiedProblemVerENS.Participant, //参与者
UpdDate = objzx_TobeStudiedProblemVerENS.UpdDate, //修改日期
UpdUser = objzx_TobeStudiedProblemVerENS.UpdUser, //修改人
Year = objzx_TobeStudiedProblemVerENS.Year, //年
Month = objzx_TobeStudiedProblemVerENS.Month, //月
Memo = objzx_TobeStudiedProblemVerENS.Memo, //备注
ProblemTitle = objzx_TobeStudiedProblemVerENS.ProblemTitle, //问题标题
};
 return objzx_TobeStudiedProblemVerENT;
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
public static void CheckPropertyNew(this clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN)
{
 clszx_TobeStudiedProblemVerBL.zx_TobeStudiedProblemVerDA.CheckPropertyNew(objzx_TobeStudiedProblemVerEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN)
{
 clszx_TobeStudiedProblemVerBL.zx_TobeStudiedProblemVerDA.CheckProperty4Condition(objzx_TobeStudiedProblemVerEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objzx_TobeStudiedProblemVerCond.IsUpdated(conzx_TobeStudiedProblemVer.ProblemVId) == true)
{
string strComparisonOpProblemVId = objzx_TobeStudiedProblemVerCond.dicFldComparisonOp[conzx_TobeStudiedProblemVer.ProblemVId];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_TobeStudiedProblemVer.ProblemVId, objzx_TobeStudiedProblemVerCond.ProblemVId, strComparisonOpProblemVId);
}
if (objzx_TobeStudiedProblemVerCond.IsUpdated(conzx_TobeStudiedProblemVer.ProblemId) == true)
{
string strComparisonOpProblemId = objzx_TobeStudiedProblemVerCond.dicFldComparisonOp[conzx_TobeStudiedProblemVer.ProblemId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TobeStudiedProblemVer.ProblemId, objzx_TobeStudiedProblemVerCond.ProblemId, strComparisonOpProblemId);
}
if (objzx_TobeStudiedProblemVerCond.IsUpdated(conzx_TobeStudiedProblemVer.GroupTextId) == true)
{
string strComparisonOpGroupTextId = objzx_TobeStudiedProblemVerCond.dicFldComparisonOp[conzx_TobeStudiedProblemVer.GroupTextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TobeStudiedProblemVer.GroupTextId, objzx_TobeStudiedProblemVerCond.GroupTextId, strComparisonOpGroupTextId);
}
if (objzx_TobeStudiedProblemVerCond.IsUpdated(conzx_TobeStudiedProblemVer.IsSubmit) == true)
{
if (objzx_TobeStudiedProblemVerCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", conzx_TobeStudiedProblemVer.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conzx_TobeStudiedProblemVer.IsSubmit);
}
}
if (objzx_TobeStudiedProblemVerCond.IsUpdated(conzx_TobeStudiedProblemVer.ProblemContent) == true)
{
string strComparisonOpProblemContent = objzx_TobeStudiedProblemVerCond.dicFldComparisonOp[conzx_TobeStudiedProblemVer.ProblemContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TobeStudiedProblemVer.ProblemContent, objzx_TobeStudiedProblemVerCond.ProblemContent, strComparisonOpProblemContent);
}
if (objzx_TobeStudiedProblemVerCond.IsUpdated(conzx_TobeStudiedProblemVer.ProblemDate) == true)
{
string strComparisonOpProblemDate = objzx_TobeStudiedProblemVerCond.dicFldComparisonOp[conzx_TobeStudiedProblemVer.ProblemDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TobeStudiedProblemVer.ProblemDate, objzx_TobeStudiedProblemVerCond.ProblemDate, strComparisonOpProblemDate);
}
if (objzx_TobeStudiedProblemVerCond.IsUpdated(conzx_TobeStudiedProblemVer.Participant) == true)
{
string strComparisonOpParticipant = objzx_TobeStudiedProblemVerCond.dicFldComparisonOp[conzx_TobeStudiedProblemVer.Participant];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TobeStudiedProblemVer.Participant, objzx_TobeStudiedProblemVerCond.Participant, strComparisonOpParticipant);
}
if (objzx_TobeStudiedProblemVerCond.IsUpdated(conzx_TobeStudiedProblemVer.UpdDate) == true)
{
string strComparisonOpUpdDate = objzx_TobeStudiedProblemVerCond.dicFldComparisonOp[conzx_TobeStudiedProblemVer.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TobeStudiedProblemVer.UpdDate, objzx_TobeStudiedProblemVerCond.UpdDate, strComparisonOpUpdDate);
}
if (objzx_TobeStudiedProblemVerCond.IsUpdated(conzx_TobeStudiedProblemVer.UpdUser) == true)
{
string strComparisonOpUpdUser = objzx_TobeStudiedProblemVerCond.dicFldComparisonOp[conzx_TobeStudiedProblemVer.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TobeStudiedProblemVer.UpdUser, objzx_TobeStudiedProblemVerCond.UpdUser, strComparisonOpUpdUser);
}
if (objzx_TobeStudiedProblemVerCond.IsUpdated(conzx_TobeStudiedProblemVer.Year) == true)
{
string strComparisonOpYear = objzx_TobeStudiedProblemVerCond.dicFldComparisonOp[conzx_TobeStudiedProblemVer.Year];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TobeStudiedProblemVer.Year, objzx_TobeStudiedProblemVerCond.Year, strComparisonOpYear);
}
if (objzx_TobeStudiedProblemVerCond.IsUpdated(conzx_TobeStudiedProblemVer.Month) == true)
{
string strComparisonOpMonth = objzx_TobeStudiedProblemVerCond.dicFldComparisonOp[conzx_TobeStudiedProblemVer.Month];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TobeStudiedProblemVer.Month, objzx_TobeStudiedProblemVerCond.Month, strComparisonOpMonth);
}
if (objzx_TobeStudiedProblemVerCond.IsUpdated(conzx_TobeStudiedProblemVer.Memo) == true)
{
string strComparisonOpMemo = objzx_TobeStudiedProblemVerCond.dicFldComparisonOp[conzx_TobeStudiedProblemVer.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TobeStudiedProblemVer.Memo, objzx_TobeStudiedProblemVerCond.Memo, strComparisonOpMemo);
}
if (objzx_TobeStudiedProblemVerCond.IsUpdated(conzx_TobeStudiedProblemVer.ProblemTitle) == true)
{
string strComparisonOpProblemTitle = objzx_TobeStudiedProblemVerCond.dicFldComparisonOp[conzx_TobeStudiedProblemVer.ProblemTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TobeStudiedProblemVer.ProblemTitle, objzx_TobeStudiedProblemVerCond.ProblemTitle, strComparisonOpProblemTitle);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--zx_TobeStudiedProblemVer(中学待研究问题历史版本表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:ProblemVId_ProblemId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objzx_TobeStudiedProblemVerEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objzx_TobeStudiedProblemVerEN == null) return true;
if (objzx_TobeStudiedProblemVerEN.ProblemVId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ProblemVId = '{0}'", objzx_TobeStudiedProblemVerEN.ProblemVId);
 sbCondition.AppendFormat(" and ProblemId = '{0}'", objzx_TobeStudiedProblemVerEN.ProblemId);
if (clszx_TobeStudiedProblemVerBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("ProblemVId !=  {0}", objzx_TobeStudiedProblemVerEN.ProblemVId);
 sbCondition.AppendFormat(" and ProblemVId = '{0}'", objzx_TobeStudiedProblemVerEN.ProblemVId);
 sbCondition.AppendFormat(" and ProblemId = '{0}'", objzx_TobeStudiedProblemVerEN.ProblemId);
if (clszx_TobeStudiedProblemVerBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--zx_TobeStudiedProblemVer(中学待研究问题历史版本表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ProblemVId_ProblemId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objzx_TobeStudiedProblemVerEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objzx_TobeStudiedProblemVerEN == null) return "";
if (objzx_TobeStudiedProblemVerEN.ProblemVId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ProblemVId = '{0}'", objzx_TobeStudiedProblemVerEN.ProblemVId);
 sbCondition.AppendFormat(" and ProblemId = '{0}'", objzx_TobeStudiedProblemVerEN.ProblemId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ProblemVId !=  {0}", objzx_TobeStudiedProblemVerEN.ProblemVId);
 sbCondition.AppendFormat(" and ProblemVId = '{0}'", objzx_TobeStudiedProblemVerEN.ProblemVId);
 sbCondition.AppendFormat(" and ProblemId = '{0}'", objzx_TobeStudiedProblemVerEN.ProblemId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_zx_TobeStudiedProblemVer
{
public virtual bool UpdRelaTabDate(long lngProblemVId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 中学待研究问题历史版本表(zx_TobeStudiedProblemVer)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clszx_TobeStudiedProblemVerBL
{
public static RelatedActions_zx_TobeStudiedProblemVer relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clszx_TobeStudiedProblemVerDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clszx_TobeStudiedProblemVerDA zx_TobeStudiedProblemVerDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clszx_TobeStudiedProblemVerDA();
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
 public clszx_TobeStudiedProblemVerBL()
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
if (string.IsNullOrEmpty(clszx_TobeStudiedProblemVerEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_TobeStudiedProblemVerEN._ConnectString);
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
public static DataTable GetDataTable_zx_TobeStudiedProblemVer(string strWhereCond)
{
DataTable objDT;
try
{
objDT = zx_TobeStudiedProblemVerDA.GetDataTable_zx_TobeStudiedProblemVer(strWhereCond);
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
objDT = zx_TobeStudiedProblemVerDA.GetDataTable(strWhereCond);
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
objDT = zx_TobeStudiedProblemVerDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = zx_TobeStudiedProblemVerDA.GetDataTable(strWhereCond, strTabName);
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
objDT = zx_TobeStudiedProblemVerDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = zx_TobeStudiedProblemVerDA.GetDataTable_Top(objTopPara);
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
objDT = zx_TobeStudiedProblemVerDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = zx_TobeStudiedProblemVerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = zx_TobeStudiedProblemVerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrProblemVIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clszx_TobeStudiedProblemVerEN> GetObjLstByProblemVIdLst(List<long> arrProblemVIdLst)
{
List<clszx_TobeStudiedProblemVerEN> arrObjLst = new List<clszx_TobeStudiedProblemVerEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrProblemVIdLst);
 string strWhereCond = string.Format("ProblemVId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN = new clszx_TobeStudiedProblemVerEN();
try
{
objzx_TobeStudiedProblemVerEN.ProblemVId = Int32.Parse(objRow[conzx_TobeStudiedProblemVer.ProblemVId].ToString().Trim()); //ProblemVId
objzx_TobeStudiedProblemVerEN.ProblemId = objRow[conzx_TobeStudiedProblemVer.ProblemId].ToString().Trim(); //问题Id
objzx_TobeStudiedProblemVerEN.GroupTextId = objRow[conzx_TobeStudiedProblemVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.GroupTextId].ToString().Trim(); //小组Id
objzx_TobeStudiedProblemVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_TobeStudiedProblemVer.IsSubmit].ToString().Trim()); //是否提交
objzx_TobeStudiedProblemVerEN.ProblemContent = objRow[conzx_TobeStudiedProblemVer.ProblemContent] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.ProblemContent].ToString().Trim(); //问题内容
objzx_TobeStudiedProblemVerEN.ProblemDate = objRow[conzx_TobeStudiedProblemVer.ProblemDate] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.ProblemDate].ToString().Trim(); //问题日期
objzx_TobeStudiedProblemVerEN.Participant = objRow[conzx_TobeStudiedProblemVer.Participant] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Participant].ToString().Trim(); //参与者
objzx_TobeStudiedProblemVerEN.UpdDate = objRow[conzx_TobeStudiedProblemVer.UpdDate] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.UpdDate].ToString().Trim(); //修改日期
objzx_TobeStudiedProblemVerEN.UpdUser = objRow[conzx_TobeStudiedProblemVer.UpdUser] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.UpdUser].ToString().Trim(); //修改人
objzx_TobeStudiedProblemVerEN.Year = objRow[conzx_TobeStudiedProblemVer.Year] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Year].ToString().Trim(); //年
objzx_TobeStudiedProblemVerEN.Month = objRow[conzx_TobeStudiedProblemVer.Month] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Month].ToString().Trim(); //月
objzx_TobeStudiedProblemVerEN.Memo = objRow[conzx_TobeStudiedProblemVer.Memo] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Memo].ToString().Trim(); //备注
objzx_TobeStudiedProblemVerEN.ProblemTitle = objRow[conzx_TobeStudiedProblemVer.ProblemTitle] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.ProblemTitle].ToString().Trim(); //问题标题
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TobeStudiedProblemVerEN.ProblemVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TobeStudiedProblemVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrProblemVIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clszx_TobeStudiedProblemVerEN> GetObjLstByProblemVIdLstCache(List<long> arrProblemVIdLst)
{
string strKey = string.Format("{0}", clszx_TobeStudiedProblemVerEN._CurrTabName);
List<clszx_TobeStudiedProblemVerEN> arrzx_TobeStudiedProblemVerObjLstCache = GetObjLstCache();
IEnumerable <clszx_TobeStudiedProblemVerEN> arrzx_TobeStudiedProblemVerObjLst_Sel =
arrzx_TobeStudiedProblemVerObjLstCache
.Where(x => arrProblemVIdLst.Contains(x.ProblemVId));
return arrzx_TobeStudiedProblemVerObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_TobeStudiedProblemVerEN> GetObjLst(string strWhereCond)
{
List<clszx_TobeStudiedProblemVerEN> arrObjLst = new List<clszx_TobeStudiedProblemVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN = new clszx_TobeStudiedProblemVerEN();
try
{
objzx_TobeStudiedProblemVerEN.ProblemVId = Int32.Parse(objRow[conzx_TobeStudiedProblemVer.ProblemVId].ToString().Trim()); //ProblemVId
objzx_TobeStudiedProblemVerEN.ProblemId = objRow[conzx_TobeStudiedProblemVer.ProblemId].ToString().Trim(); //问题Id
objzx_TobeStudiedProblemVerEN.GroupTextId = objRow[conzx_TobeStudiedProblemVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.GroupTextId].ToString().Trim(); //小组Id
objzx_TobeStudiedProblemVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_TobeStudiedProblemVer.IsSubmit].ToString().Trim()); //是否提交
objzx_TobeStudiedProblemVerEN.ProblemContent = objRow[conzx_TobeStudiedProblemVer.ProblemContent] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.ProblemContent].ToString().Trim(); //问题内容
objzx_TobeStudiedProblemVerEN.ProblemDate = objRow[conzx_TobeStudiedProblemVer.ProblemDate] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.ProblemDate].ToString().Trim(); //问题日期
objzx_TobeStudiedProblemVerEN.Participant = objRow[conzx_TobeStudiedProblemVer.Participant] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Participant].ToString().Trim(); //参与者
objzx_TobeStudiedProblemVerEN.UpdDate = objRow[conzx_TobeStudiedProblemVer.UpdDate] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.UpdDate].ToString().Trim(); //修改日期
objzx_TobeStudiedProblemVerEN.UpdUser = objRow[conzx_TobeStudiedProblemVer.UpdUser] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.UpdUser].ToString().Trim(); //修改人
objzx_TobeStudiedProblemVerEN.Year = objRow[conzx_TobeStudiedProblemVer.Year] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Year].ToString().Trim(); //年
objzx_TobeStudiedProblemVerEN.Month = objRow[conzx_TobeStudiedProblemVer.Month] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Month].ToString().Trim(); //月
objzx_TobeStudiedProblemVerEN.Memo = objRow[conzx_TobeStudiedProblemVer.Memo] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Memo].ToString().Trim(); //备注
objzx_TobeStudiedProblemVerEN.ProblemTitle = objRow[conzx_TobeStudiedProblemVer.ProblemTitle] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.ProblemTitle].ToString().Trim(); //问题标题
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TobeStudiedProblemVerEN.ProblemVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TobeStudiedProblemVerEN);
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
public static List<clszx_TobeStudiedProblemVerEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clszx_TobeStudiedProblemVerEN> arrObjLst = new List<clszx_TobeStudiedProblemVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN = new clszx_TobeStudiedProblemVerEN();
try
{
objzx_TobeStudiedProblemVerEN.ProblemVId = Int32.Parse(objRow[conzx_TobeStudiedProblemVer.ProblemVId].ToString().Trim()); //ProblemVId
objzx_TobeStudiedProblemVerEN.ProblemId = objRow[conzx_TobeStudiedProblemVer.ProblemId].ToString().Trim(); //问题Id
objzx_TobeStudiedProblemVerEN.GroupTextId = objRow[conzx_TobeStudiedProblemVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.GroupTextId].ToString().Trim(); //小组Id
objzx_TobeStudiedProblemVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_TobeStudiedProblemVer.IsSubmit].ToString().Trim()); //是否提交
objzx_TobeStudiedProblemVerEN.ProblemContent = objRow[conzx_TobeStudiedProblemVer.ProblemContent] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.ProblemContent].ToString().Trim(); //问题内容
objzx_TobeStudiedProblemVerEN.ProblemDate = objRow[conzx_TobeStudiedProblemVer.ProblemDate] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.ProblemDate].ToString().Trim(); //问题日期
objzx_TobeStudiedProblemVerEN.Participant = objRow[conzx_TobeStudiedProblemVer.Participant] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Participant].ToString().Trim(); //参与者
objzx_TobeStudiedProblemVerEN.UpdDate = objRow[conzx_TobeStudiedProblemVer.UpdDate] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.UpdDate].ToString().Trim(); //修改日期
objzx_TobeStudiedProblemVerEN.UpdUser = objRow[conzx_TobeStudiedProblemVer.UpdUser] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.UpdUser].ToString().Trim(); //修改人
objzx_TobeStudiedProblemVerEN.Year = objRow[conzx_TobeStudiedProblemVer.Year] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Year].ToString().Trim(); //年
objzx_TobeStudiedProblemVerEN.Month = objRow[conzx_TobeStudiedProblemVer.Month] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Month].ToString().Trim(); //月
objzx_TobeStudiedProblemVerEN.Memo = objRow[conzx_TobeStudiedProblemVer.Memo] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Memo].ToString().Trim(); //备注
objzx_TobeStudiedProblemVerEN.ProblemTitle = objRow[conzx_TobeStudiedProblemVer.ProblemTitle] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.ProblemTitle].ToString().Trim(); //问题标题
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TobeStudiedProblemVerEN.ProblemVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TobeStudiedProblemVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objzx_TobeStudiedProblemVerCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clszx_TobeStudiedProblemVerEN> GetSubObjLstCache(clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerCond)
{
List<clszx_TobeStudiedProblemVerEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clszx_TobeStudiedProblemVerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_TobeStudiedProblemVer.AttributeName)
{
if (objzx_TobeStudiedProblemVerCond.IsUpdated(strFldName) == false) continue;
if (objzx_TobeStudiedProblemVerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_TobeStudiedProblemVerCond[strFldName].ToString());
}
else
{
if (objzx_TobeStudiedProblemVerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_TobeStudiedProblemVerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_TobeStudiedProblemVerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_TobeStudiedProblemVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_TobeStudiedProblemVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_TobeStudiedProblemVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_TobeStudiedProblemVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_TobeStudiedProblemVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_TobeStudiedProblemVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_TobeStudiedProblemVerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_TobeStudiedProblemVerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_TobeStudiedProblemVerCond[strFldName]));
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
public static List<clszx_TobeStudiedProblemVerEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clszx_TobeStudiedProblemVerEN> arrObjLst = new List<clszx_TobeStudiedProblemVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN = new clszx_TobeStudiedProblemVerEN();
try
{
objzx_TobeStudiedProblemVerEN.ProblemVId = Int32.Parse(objRow[conzx_TobeStudiedProblemVer.ProblemVId].ToString().Trim()); //ProblemVId
objzx_TobeStudiedProblemVerEN.ProblemId = objRow[conzx_TobeStudiedProblemVer.ProblemId].ToString().Trim(); //问题Id
objzx_TobeStudiedProblemVerEN.GroupTextId = objRow[conzx_TobeStudiedProblemVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.GroupTextId].ToString().Trim(); //小组Id
objzx_TobeStudiedProblemVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_TobeStudiedProblemVer.IsSubmit].ToString().Trim()); //是否提交
objzx_TobeStudiedProblemVerEN.ProblemContent = objRow[conzx_TobeStudiedProblemVer.ProblemContent] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.ProblemContent].ToString().Trim(); //问题内容
objzx_TobeStudiedProblemVerEN.ProblemDate = objRow[conzx_TobeStudiedProblemVer.ProblemDate] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.ProblemDate].ToString().Trim(); //问题日期
objzx_TobeStudiedProblemVerEN.Participant = objRow[conzx_TobeStudiedProblemVer.Participant] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Participant].ToString().Trim(); //参与者
objzx_TobeStudiedProblemVerEN.UpdDate = objRow[conzx_TobeStudiedProblemVer.UpdDate] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.UpdDate].ToString().Trim(); //修改日期
objzx_TobeStudiedProblemVerEN.UpdUser = objRow[conzx_TobeStudiedProblemVer.UpdUser] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.UpdUser].ToString().Trim(); //修改人
objzx_TobeStudiedProblemVerEN.Year = objRow[conzx_TobeStudiedProblemVer.Year] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Year].ToString().Trim(); //年
objzx_TobeStudiedProblemVerEN.Month = objRow[conzx_TobeStudiedProblemVer.Month] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Month].ToString().Trim(); //月
objzx_TobeStudiedProblemVerEN.Memo = objRow[conzx_TobeStudiedProblemVer.Memo] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Memo].ToString().Trim(); //备注
objzx_TobeStudiedProblemVerEN.ProblemTitle = objRow[conzx_TobeStudiedProblemVer.ProblemTitle] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.ProblemTitle].ToString().Trim(); //问题标题
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TobeStudiedProblemVerEN.ProblemVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TobeStudiedProblemVerEN);
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
public static List<clszx_TobeStudiedProblemVerEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clszx_TobeStudiedProblemVerEN> arrObjLst = new List<clszx_TobeStudiedProblemVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN = new clszx_TobeStudiedProblemVerEN();
try
{
objzx_TobeStudiedProblemVerEN.ProblemVId = Int32.Parse(objRow[conzx_TobeStudiedProblemVer.ProblemVId].ToString().Trim()); //ProblemVId
objzx_TobeStudiedProblemVerEN.ProblemId = objRow[conzx_TobeStudiedProblemVer.ProblemId].ToString().Trim(); //问题Id
objzx_TobeStudiedProblemVerEN.GroupTextId = objRow[conzx_TobeStudiedProblemVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.GroupTextId].ToString().Trim(); //小组Id
objzx_TobeStudiedProblemVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_TobeStudiedProblemVer.IsSubmit].ToString().Trim()); //是否提交
objzx_TobeStudiedProblemVerEN.ProblemContent = objRow[conzx_TobeStudiedProblemVer.ProblemContent] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.ProblemContent].ToString().Trim(); //问题内容
objzx_TobeStudiedProblemVerEN.ProblemDate = objRow[conzx_TobeStudiedProblemVer.ProblemDate] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.ProblemDate].ToString().Trim(); //问题日期
objzx_TobeStudiedProblemVerEN.Participant = objRow[conzx_TobeStudiedProblemVer.Participant] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Participant].ToString().Trim(); //参与者
objzx_TobeStudiedProblemVerEN.UpdDate = objRow[conzx_TobeStudiedProblemVer.UpdDate] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.UpdDate].ToString().Trim(); //修改日期
objzx_TobeStudiedProblemVerEN.UpdUser = objRow[conzx_TobeStudiedProblemVer.UpdUser] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.UpdUser].ToString().Trim(); //修改人
objzx_TobeStudiedProblemVerEN.Year = objRow[conzx_TobeStudiedProblemVer.Year] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Year].ToString().Trim(); //年
objzx_TobeStudiedProblemVerEN.Month = objRow[conzx_TobeStudiedProblemVer.Month] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Month].ToString().Trim(); //月
objzx_TobeStudiedProblemVerEN.Memo = objRow[conzx_TobeStudiedProblemVer.Memo] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Memo].ToString().Trim(); //备注
objzx_TobeStudiedProblemVerEN.ProblemTitle = objRow[conzx_TobeStudiedProblemVer.ProblemTitle] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.ProblemTitle].ToString().Trim(); //问题标题
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TobeStudiedProblemVerEN.ProblemVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TobeStudiedProblemVerEN);
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
List<clszx_TobeStudiedProblemVerEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clszx_TobeStudiedProblemVerEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_TobeStudiedProblemVerEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clszx_TobeStudiedProblemVerEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clszx_TobeStudiedProblemVerEN> arrObjLst = new List<clszx_TobeStudiedProblemVerEN>(); 
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
	clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN = new clszx_TobeStudiedProblemVerEN();
try
{
objzx_TobeStudiedProblemVerEN.ProblemVId = Int32.Parse(objRow[conzx_TobeStudiedProblemVer.ProblemVId].ToString().Trim()); //ProblemVId
objzx_TobeStudiedProblemVerEN.ProblemId = objRow[conzx_TobeStudiedProblemVer.ProblemId].ToString().Trim(); //问题Id
objzx_TobeStudiedProblemVerEN.GroupTextId = objRow[conzx_TobeStudiedProblemVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.GroupTextId].ToString().Trim(); //小组Id
objzx_TobeStudiedProblemVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_TobeStudiedProblemVer.IsSubmit].ToString().Trim()); //是否提交
objzx_TobeStudiedProblemVerEN.ProblemContent = objRow[conzx_TobeStudiedProblemVer.ProblemContent] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.ProblemContent].ToString().Trim(); //问题内容
objzx_TobeStudiedProblemVerEN.ProblemDate = objRow[conzx_TobeStudiedProblemVer.ProblemDate] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.ProblemDate].ToString().Trim(); //问题日期
objzx_TobeStudiedProblemVerEN.Participant = objRow[conzx_TobeStudiedProblemVer.Participant] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Participant].ToString().Trim(); //参与者
objzx_TobeStudiedProblemVerEN.UpdDate = objRow[conzx_TobeStudiedProblemVer.UpdDate] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.UpdDate].ToString().Trim(); //修改日期
objzx_TobeStudiedProblemVerEN.UpdUser = objRow[conzx_TobeStudiedProblemVer.UpdUser] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.UpdUser].ToString().Trim(); //修改人
objzx_TobeStudiedProblemVerEN.Year = objRow[conzx_TobeStudiedProblemVer.Year] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Year].ToString().Trim(); //年
objzx_TobeStudiedProblemVerEN.Month = objRow[conzx_TobeStudiedProblemVer.Month] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Month].ToString().Trim(); //月
objzx_TobeStudiedProblemVerEN.Memo = objRow[conzx_TobeStudiedProblemVer.Memo] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Memo].ToString().Trim(); //备注
objzx_TobeStudiedProblemVerEN.ProblemTitle = objRow[conzx_TobeStudiedProblemVer.ProblemTitle] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.ProblemTitle].ToString().Trim(); //问题标题
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TobeStudiedProblemVerEN.ProblemVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TobeStudiedProblemVerEN);
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
public static List<clszx_TobeStudiedProblemVerEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clszx_TobeStudiedProblemVerEN> arrObjLst = new List<clszx_TobeStudiedProblemVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN = new clszx_TobeStudiedProblemVerEN();
try
{
objzx_TobeStudiedProblemVerEN.ProblemVId = Int32.Parse(objRow[conzx_TobeStudiedProblemVer.ProblemVId].ToString().Trim()); //ProblemVId
objzx_TobeStudiedProblemVerEN.ProblemId = objRow[conzx_TobeStudiedProblemVer.ProblemId].ToString().Trim(); //问题Id
objzx_TobeStudiedProblemVerEN.GroupTextId = objRow[conzx_TobeStudiedProblemVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.GroupTextId].ToString().Trim(); //小组Id
objzx_TobeStudiedProblemVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_TobeStudiedProblemVer.IsSubmit].ToString().Trim()); //是否提交
objzx_TobeStudiedProblemVerEN.ProblemContent = objRow[conzx_TobeStudiedProblemVer.ProblemContent] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.ProblemContent].ToString().Trim(); //问题内容
objzx_TobeStudiedProblemVerEN.ProblemDate = objRow[conzx_TobeStudiedProblemVer.ProblemDate] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.ProblemDate].ToString().Trim(); //问题日期
objzx_TobeStudiedProblemVerEN.Participant = objRow[conzx_TobeStudiedProblemVer.Participant] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Participant].ToString().Trim(); //参与者
objzx_TobeStudiedProblemVerEN.UpdDate = objRow[conzx_TobeStudiedProblemVer.UpdDate] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.UpdDate].ToString().Trim(); //修改日期
objzx_TobeStudiedProblemVerEN.UpdUser = objRow[conzx_TobeStudiedProblemVer.UpdUser] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.UpdUser].ToString().Trim(); //修改人
objzx_TobeStudiedProblemVerEN.Year = objRow[conzx_TobeStudiedProblemVer.Year] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Year].ToString().Trim(); //年
objzx_TobeStudiedProblemVerEN.Month = objRow[conzx_TobeStudiedProblemVer.Month] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Month].ToString().Trim(); //月
objzx_TobeStudiedProblemVerEN.Memo = objRow[conzx_TobeStudiedProblemVer.Memo] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Memo].ToString().Trim(); //备注
objzx_TobeStudiedProblemVerEN.ProblemTitle = objRow[conzx_TobeStudiedProblemVer.ProblemTitle] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.ProblemTitle].ToString().Trim(); //问题标题
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TobeStudiedProblemVerEN.ProblemVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TobeStudiedProblemVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clszx_TobeStudiedProblemVerEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clszx_TobeStudiedProblemVerEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clszx_TobeStudiedProblemVerEN> arrObjLst = new List<clszx_TobeStudiedProblemVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN = new clszx_TobeStudiedProblemVerEN();
try
{
objzx_TobeStudiedProblemVerEN.ProblemVId = Int32.Parse(objRow[conzx_TobeStudiedProblemVer.ProblemVId].ToString().Trim()); //ProblemVId
objzx_TobeStudiedProblemVerEN.ProblemId = objRow[conzx_TobeStudiedProblemVer.ProblemId].ToString().Trim(); //问题Id
objzx_TobeStudiedProblemVerEN.GroupTextId = objRow[conzx_TobeStudiedProblemVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.GroupTextId].ToString().Trim(); //小组Id
objzx_TobeStudiedProblemVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_TobeStudiedProblemVer.IsSubmit].ToString().Trim()); //是否提交
objzx_TobeStudiedProblemVerEN.ProblemContent = objRow[conzx_TobeStudiedProblemVer.ProblemContent] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.ProblemContent].ToString().Trim(); //问题内容
objzx_TobeStudiedProblemVerEN.ProblemDate = objRow[conzx_TobeStudiedProblemVer.ProblemDate] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.ProblemDate].ToString().Trim(); //问题日期
objzx_TobeStudiedProblemVerEN.Participant = objRow[conzx_TobeStudiedProblemVer.Participant] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Participant].ToString().Trim(); //参与者
objzx_TobeStudiedProblemVerEN.UpdDate = objRow[conzx_TobeStudiedProblemVer.UpdDate] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.UpdDate].ToString().Trim(); //修改日期
objzx_TobeStudiedProblemVerEN.UpdUser = objRow[conzx_TobeStudiedProblemVer.UpdUser] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.UpdUser].ToString().Trim(); //修改人
objzx_TobeStudiedProblemVerEN.Year = objRow[conzx_TobeStudiedProblemVer.Year] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Year].ToString().Trim(); //年
objzx_TobeStudiedProblemVerEN.Month = objRow[conzx_TobeStudiedProblemVer.Month] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Month].ToString().Trim(); //月
objzx_TobeStudiedProblemVerEN.Memo = objRow[conzx_TobeStudiedProblemVer.Memo] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Memo].ToString().Trim(); //备注
objzx_TobeStudiedProblemVerEN.ProblemTitle = objRow[conzx_TobeStudiedProblemVer.ProblemTitle] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.ProblemTitle].ToString().Trim(); //问题标题
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TobeStudiedProblemVerEN.ProblemVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TobeStudiedProblemVerEN);
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
public static List<clszx_TobeStudiedProblemVerEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clszx_TobeStudiedProblemVerEN> arrObjLst = new List<clszx_TobeStudiedProblemVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN = new clszx_TobeStudiedProblemVerEN();
try
{
objzx_TobeStudiedProblemVerEN.ProblemVId = Int32.Parse(objRow[conzx_TobeStudiedProblemVer.ProblemVId].ToString().Trim()); //ProblemVId
objzx_TobeStudiedProblemVerEN.ProblemId = objRow[conzx_TobeStudiedProblemVer.ProblemId].ToString().Trim(); //问题Id
objzx_TobeStudiedProblemVerEN.GroupTextId = objRow[conzx_TobeStudiedProblemVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.GroupTextId].ToString().Trim(); //小组Id
objzx_TobeStudiedProblemVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_TobeStudiedProblemVer.IsSubmit].ToString().Trim()); //是否提交
objzx_TobeStudiedProblemVerEN.ProblemContent = objRow[conzx_TobeStudiedProblemVer.ProblemContent] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.ProblemContent].ToString().Trim(); //问题内容
objzx_TobeStudiedProblemVerEN.ProblemDate = objRow[conzx_TobeStudiedProblemVer.ProblemDate] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.ProblemDate].ToString().Trim(); //问题日期
objzx_TobeStudiedProblemVerEN.Participant = objRow[conzx_TobeStudiedProblemVer.Participant] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Participant].ToString().Trim(); //参与者
objzx_TobeStudiedProblemVerEN.UpdDate = objRow[conzx_TobeStudiedProblemVer.UpdDate] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.UpdDate].ToString().Trim(); //修改日期
objzx_TobeStudiedProblemVerEN.UpdUser = objRow[conzx_TobeStudiedProblemVer.UpdUser] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.UpdUser].ToString().Trim(); //修改人
objzx_TobeStudiedProblemVerEN.Year = objRow[conzx_TobeStudiedProblemVer.Year] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Year].ToString().Trim(); //年
objzx_TobeStudiedProblemVerEN.Month = objRow[conzx_TobeStudiedProblemVer.Month] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Month].ToString().Trim(); //月
objzx_TobeStudiedProblemVerEN.Memo = objRow[conzx_TobeStudiedProblemVer.Memo] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Memo].ToString().Trim(); //备注
objzx_TobeStudiedProblemVerEN.ProblemTitle = objRow[conzx_TobeStudiedProblemVer.ProblemTitle] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.ProblemTitle].ToString().Trim(); //问题标题
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TobeStudiedProblemVerEN.ProblemVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TobeStudiedProblemVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_TobeStudiedProblemVerEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clszx_TobeStudiedProblemVerEN> arrObjLst = new List<clszx_TobeStudiedProblemVerEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN = new clszx_TobeStudiedProblemVerEN();
try
{
objzx_TobeStudiedProblemVerEN.ProblemVId = Int32.Parse(objRow[conzx_TobeStudiedProblemVer.ProblemVId].ToString().Trim()); //ProblemVId
objzx_TobeStudiedProblemVerEN.ProblemId = objRow[conzx_TobeStudiedProblemVer.ProblemId].ToString().Trim(); //问题Id
objzx_TobeStudiedProblemVerEN.GroupTextId = objRow[conzx_TobeStudiedProblemVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.GroupTextId].ToString().Trim(); //小组Id
objzx_TobeStudiedProblemVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_TobeStudiedProblemVer.IsSubmit].ToString().Trim()); //是否提交
objzx_TobeStudiedProblemVerEN.ProblemContent = objRow[conzx_TobeStudiedProblemVer.ProblemContent] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.ProblemContent].ToString().Trim(); //问题内容
objzx_TobeStudiedProblemVerEN.ProblemDate = objRow[conzx_TobeStudiedProblemVer.ProblemDate] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.ProblemDate].ToString().Trim(); //问题日期
objzx_TobeStudiedProblemVerEN.Participant = objRow[conzx_TobeStudiedProblemVer.Participant] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Participant].ToString().Trim(); //参与者
objzx_TobeStudiedProblemVerEN.UpdDate = objRow[conzx_TobeStudiedProblemVer.UpdDate] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.UpdDate].ToString().Trim(); //修改日期
objzx_TobeStudiedProblemVerEN.UpdUser = objRow[conzx_TobeStudiedProblemVer.UpdUser] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.UpdUser].ToString().Trim(); //修改人
objzx_TobeStudiedProblemVerEN.Year = objRow[conzx_TobeStudiedProblemVer.Year] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Year].ToString().Trim(); //年
objzx_TobeStudiedProblemVerEN.Month = objRow[conzx_TobeStudiedProblemVer.Month] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Month].ToString().Trim(); //月
objzx_TobeStudiedProblemVerEN.Memo = objRow[conzx_TobeStudiedProblemVer.Memo] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Memo].ToString().Trim(); //备注
objzx_TobeStudiedProblemVerEN.ProblemTitle = objRow[conzx_TobeStudiedProblemVer.ProblemTitle] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.ProblemTitle].ToString().Trim(); //问题标题
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TobeStudiedProblemVerEN.ProblemVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TobeStudiedProblemVerEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objzx_TobeStudiedProblemVerEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getzx_TobeStudiedProblemVer(ref clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN)
{
bool bolResult = zx_TobeStudiedProblemVerDA.Getzx_TobeStudiedProblemVer(ref objzx_TobeStudiedProblemVerEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngProblemVId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_TobeStudiedProblemVerEN GetObjByProblemVId(long lngProblemVId)
{
clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN = zx_TobeStudiedProblemVerDA.GetObjByProblemVId(lngProblemVId);
return objzx_TobeStudiedProblemVerEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clszx_TobeStudiedProblemVerEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN = zx_TobeStudiedProblemVerDA.GetFirstObj(strWhereCond);
 return objzx_TobeStudiedProblemVerEN;
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
public static clszx_TobeStudiedProblemVerEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN = zx_TobeStudiedProblemVerDA.GetObjByDataRow(objRow);
 return objzx_TobeStudiedProblemVerEN;
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
public static clszx_TobeStudiedProblemVerEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN = zx_TobeStudiedProblemVerDA.GetObjByDataRow(objRow);
 return objzx_TobeStudiedProblemVerEN;
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
 /// <param name = "lngProblemVId">所给的关键字</param>
 /// <param name = "lstzx_TobeStudiedProblemVerObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_TobeStudiedProblemVerEN GetObjByProblemVIdFromList(long lngProblemVId, List<clszx_TobeStudiedProblemVerEN> lstzx_TobeStudiedProblemVerObjLst)
{
foreach (clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN in lstzx_TobeStudiedProblemVerObjLst)
{
if (objzx_TobeStudiedProblemVerEN.ProblemVId == lngProblemVId)
{
return objzx_TobeStudiedProblemVerEN;
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
 long lngProblemVId;
 try
 {
 lngProblemVId = new clszx_TobeStudiedProblemVerDA().GetFirstID(strWhereCond);
 return lngProblemVId;
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
 arrList = zx_TobeStudiedProblemVerDA.GetID(strWhereCond);
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
bool bolIsExist = zx_TobeStudiedProblemVerDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngProblemVId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngProblemVId)
{
//检测记录是否存在
bool bolIsExist = zx_TobeStudiedProblemVerDA.IsExist(lngProblemVId);
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
 bolIsExist = clszx_TobeStudiedProblemVerDA.IsExistTable();
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
 bolIsExist = zx_TobeStudiedProblemVerDA.IsExistTable(strTabName);
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
 /// <param name = "objzx_TobeStudiedProblemVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN)
{
if (objzx_TobeStudiedProblemVerEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!ProblemVId = [{0}],问题Id = [{1}]的数据已经存在!(in clszx_TobeStudiedProblemVerBL.AddNewRecordBySql2)", objzx_TobeStudiedProblemVerEN.ProblemVId,objzx_TobeStudiedProblemVerEN.ProblemId);
throw new Exception(strMsg);
}
try
{
bool bolResult = zx_TobeStudiedProblemVerDA.AddNewRecordBySQL2(objzx_TobeStudiedProblemVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TobeStudiedProblemVerBL.ReFreshCache();

if (clszx_TobeStudiedProblemVerBL.relatedActions != null)
{
clszx_TobeStudiedProblemVerBL.relatedActions.UpdRelaTabDate(objzx_TobeStudiedProblemVerEN.ProblemVId, "SetUpdDate");
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
 /// <param name = "objzx_TobeStudiedProblemVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN)
{
if (objzx_TobeStudiedProblemVerEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!ProblemVId = [{0}],问题Id = [{1}]的数据已经存在!(in clszx_TobeStudiedProblemVerBL.AddNewRecordBySql2WithReturnKey)", objzx_TobeStudiedProblemVerEN.ProblemVId,objzx_TobeStudiedProblemVerEN.ProblemId);
throw new Exception(strMsg);
}
try
{
string strKey = zx_TobeStudiedProblemVerDA.AddNewRecordBySQL2WithReturnKey(objzx_TobeStudiedProblemVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TobeStudiedProblemVerBL.ReFreshCache();

if (clszx_TobeStudiedProblemVerBL.relatedActions != null)
{
clszx_TobeStudiedProblemVerBL.relatedActions.UpdRelaTabDate(objzx_TobeStudiedProblemVerEN.ProblemVId, "SetUpdDate");
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
 /// <param name = "objzx_TobeStudiedProblemVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN)
{
try
{
bool bolResult = zx_TobeStudiedProblemVerDA.Update(objzx_TobeStudiedProblemVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TobeStudiedProblemVerBL.ReFreshCache();

if (clszx_TobeStudiedProblemVerBL.relatedActions != null)
{
clszx_TobeStudiedProblemVerBL.relatedActions.UpdRelaTabDate(objzx_TobeStudiedProblemVerEN.ProblemVId, "SetUpdDate");
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
 /// <param name = "objzx_TobeStudiedProblemVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN)
{
 if (objzx_TobeStudiedProblemVerEN.ProblemVId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = zx_TobeStudiedProblemVerDA.UpdateBySql2(objzx_TobeStudiedProblemVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TobeStudiedProblemVerBL.ReFreshCache();

if (clszx_TobeStudiedProblemVerBL.relatedActions != null)
{
clszx_TobeStudiedProblemVerBL.relatedActions.UpdRelaTabDate(objzx_TobeStudiedProblemVerEN.ProblemVId, "SetUpdDate");
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
 /// <param name = "lngProblemVId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngProblemVId)
{
try
{
 clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN = clszx_TobeStudiedProblemVerBL.GetObjByProblemVId(lngProblemVId);

if (clszx_TobeStudiedProblemVerBL.relatedActions != null)
{
clszx_TobeStudiedProblemVerBL.relatedActions.UpdRelaTabDate(objzx_TobeStudiedProblemVerEN.ProblemVId, "SetUpdDate");
}
if (objzx_TobeStudiedProblemVerEN != null)
{
int intRecNum = zx_TobeStudiedProblemVerDA.DelRecord(lngProblemVId);
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
/// <param name="lngProblemVId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngProblemVId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_TobeStudiedProblemVerDA.GetSpecSQLObj();
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
//删除与表:[zx_TobeStudiedProblemVer]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conzx_TobeStudiedProblemVer.ProblemVId,
//lngProblemVId);
//        clszx_TobeStudiedProblemVerBL.Delzx_TobeStudiedProblemVersByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_TobeStudiedProblemVerBL.DelRecord(lngProblemVId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_TobeStudiedProblemVerBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngProblemVId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngProblemVId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngProblemVId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clszx_TobeStudiedProblemVerBL.relatedActions != null)
{
clszx_TobeStudiedProblemVerBL.relatedActions.UpdRelaTabDate(lngProblemVId, "UpdRelaTabDate");
}
bool bolResult = zx_TobeStudiedProblemVerDA.DelRecord(lngProblemVId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrProblemVIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delzx_TobeStudiedProblemVers(List<string> arrProblemVIdLst)
{
if (arrProblemVIdLst.Count == 0) return 0;
try
{
if (clszx_TobeStudiedProblemVerBL.relatedActions != null)
{
foreach (var strProblemVId in arrProblemVIdLst)
{
long lngProblemVId = long.Parse(strProblemVId);
clszx_TobeStudiedProblemVerBL.relatedActions.UpdRelaTabDate(lngProblemVId, "UpdRelaTabDate");
}
}
int intDelRecNum = zx_TobeStudiedProblemVerDA.Delzx_TobeStudiedProblemVer(arrProblemVIdLst);
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
public static int Delzx_TobeStudiedProblemVersByCond(string strWhereCond)
{
try
{
if (clszx_TobeStudiedProblemVerBL.relatedActions != null)
{
List<string> arrProblemVId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strProblemVId in arrProblemVId)
{
long lngProblemVId = long.Parse(strProblemVId);
clszx_TobeStudiedProblemVerBL.relatedActions.UpdRelaTabDate(lngProblemVId, "UpdRelaTabDate");
}
}
int intRecNum = zx_TobeStudiedProblemVerDA.Delzx_TobeStudiedProblemVer(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[zx_TobeStudiedProblemVer]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngProblemVId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngProblemVId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_TobeStudiedProblemVerDA.GetSpecSQLObj();
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
//删除与表:[zx_TobeStudiedProblemVer]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_TobeStudiedProblemVerBL.DelRecord(lngProblemVId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_TobeStudiedProblemVerBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngProblemVId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objzx_TobeStudiedProblemVerENS">源对象</param>
 /// <param name = "objzx_TobeStudiedProblemVerENT">目标对象</param>
 public static void CopyTo(clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerENS, clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerENT)
{
try
{
objzx_TobeStudiedProblemVerENT.ProblemVId = objzx_TobeStudiedProblemVerENS.ProblemVId; //ProblemVId
objzx_TobeStudiedProblemVerENT.ProblemId = objzx_TobeStudiedProblemVerENS.ProblemId; //问题Id
objzx_TobeStudiedProblemVerENT.GroupTextId = objzx_TobeStudiedProblemVerENS.GroupTextId; //小组Id
objzx_TobeStudiedProblemVerENT.IsSubmit = objzx_TobeStudiedProblemVerENS.IsSubmit; //是否提交
objzx_TobeStudiedProblemVerENT.ProblemContent = objzx_TobeStudiedProblemVerENS.ProblemContent; //问题内容
objzx_TobeStudiedProblemVerENT.ProblemDate = objzx_TobeStudiedProblemVerENS.ProblemDate; //问题日期
objzx_TobeStudiedProblemVerENT.Participant = objzx_TobeStudiedProblemVerENS.Participant; //参与者
objzx_TobeStudiedProblemVerENT.UpdDate = objzx_TobeStudiedProblemVerENS.UpdDate; //修改日期
objzx_TobeStudiedProblemVerENT.UpdUser = objzx_TobeStudiedProblemVerENS.UpdUser; //修改人
objzx_TobeStudiedProblemVerENT.Year = objzx_TobeStudiedProblemVerENS.Year; //年
objzx_TobeStudiedProblemVerENT.Month = objzx_TobeStudiedProblemVerENS.Month; //月
objzx_TobeStudiedProblemVerENT.Memo = objzx_TobeStudiedProblemVerENS.Memo; //备注
objzx_TobeStudiedProblemVerENT.ProblemTitle = objzx_TobeStudiedProblemVerENS.ProblemTitle; //问题标题
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
 /// <param name = "objzx_TobeStudiedProblemVerEN">源简化对象</param>
 public static void SetUpdFlag(clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN)
{
try
{
objzx_TobeStudiedProblemVerEN.ClearUpdateState();
   string strsfUpdFldSetStr = objzx_TobeStudiedProblemVerEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conzx_TobeStudiedProblemVer.ProblemVId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TobeStudiedProblemVerEN.ProblemVId = objzx_TobeStudiedProblemVerEN.ProblemVId; //ProblemVId
}
if (arrFldSet.Contains(conzx_TobeStudiedProblemVer.ProblemId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TobeStudiedProblemVerEN.ProblemId = objzx_TobeStudiedProblemVerEN.ProblemId; //问题Id
}
if (arrFldSet.Contains(conzx_TobeStudiedProblemVer.GroupTextId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TobeStudiedProblemVerEN.GroupTextId = objzx_TobeStudiedProblemVerEN.GroupTextId == "[null]" ? null :  objzx_TobeStudiedProblemVerEN.GroupTextId; //小组Id
}
if (arrFldSet.Contains(conzx_TobeStudiedProblemVer.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TobeStudiedProblemVerEN.IsSubmit = objzx_TobeStudiedProblemVerEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(conzx_TobeStudiedProblemVer.ProblemContent, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TobeStudiedProblemVerEN.ProblemContent = objzx_TobeStudiedProblemVerEN.ProblemContent == "[null]" ? null :  objzx_TobeStudiedProblemVerEN.ProblemContent; //问题内容
}
if (arrFldSet.Contains(conzx_TobeStudiedProblemVer.ProblemDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TobeStudiedProblemVerEN.ProblemDate = objzx_TobeStudiedProblemVerEN.ProblemDate == "[null]" ? null :  objzx_TobeStudiedProblemVerEN.ProblemDate; //问题日期
}
if (arrFldSet.Contains(conzx_TobeStudiedProblemVer.Participant, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TobeStudiedProblemVerEN.Participant = objzx_TobeStudiedProblemVerEN.Participant == "[null]" ? null :  objzx_TobeStudiedProblemVerEN.Participant; //参与者
}
if (arrFldSet.Contains(conzx_TobeStudiedProblemVer.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TobeStudiedProblemVerEN.UpdDate = objzx_TobeStudiedProblemVerEN.UpdDate == "[null]" ? null :  objzx_TobeStudiedProblemVerEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conzx_TobeStudiedProblemVer.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TobeStudiedProblemVerEN.UpdUser = objzx_TobeStudiedProblemVerEN.UpdUser == "[null]" ? null :  objzx_TobeStudiedProblemVerEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conzx_TobeStudiedProblemVer.Year, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TobeStudiedProblemVerEN.Year = objzx_TobeStudiedProblemVerEN.Year == "[null]" ? null :  objzx_TobeStudiedProblemVerEN.Year; //年
}
if (arrFldSet.Contains(conzx_TobeStudiedProblemVer.Month, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TobeStudiedProblemVerEN.Month = objzx_TobeStudiedProblemVerEN.Month == "[null]" ? null :  objzx_TobeStudiedProblemVerEN.Month; //月
}
if (arrFldSet.Contains(conzx_TobeStudiedProblemVer.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TobeStudiedProblemVerEN.Memo = objzx_TobeStudiedProblemVerEN.Memo == "[null]" ? null :  objzx_TobeStudiedProblemVerEN.Memo; //备注
}
if (arrFldSet.Contains(conzx_TobeStudiedProblemVer.ProblemTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TobeStudiedProblemVerEN.ProblemTitle = objzx_TobeStudiedProblemVerEN.ProblemTitle == "[null]" ? null :  objzx_TobeStudiedProblemVerEN.ProblemTitle; //问题标题
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
 /// <param name = "objzx_TobeStudiedProblemVerEN">源简化对象</param>
 public static void AccessFldValueNull(clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN)
{
try
{
if (objzx_TobeStudiedProblemVerEN.GroupTextId == "[null]") objzx_TobeStudiedProblemVerEN.GroupTextId = null; //小组Id
if (objzx_TobeStudiedProblemVerEN.ProblemContent == "[null]") objzx_TobeStudiedProblemVerEN.ProblemContent = null; //问题内容
if (objzx_TobeStudiedProblemVerEN.ProblemDate == "[null]") objzx_TobeStudiedProblemVerEN.ProblemDate = null; //问题日期
if (objzx_TobeStudiedProblemVerEN.Participant == "[null]") objzx_TobeStudiedProblemVerEN.Participant = null; //参与者
if (objzx_TobeStudiedProblemVerEN.UpdDate == "[null]") objzx_TobeStudiedProblemVerEN.UpdDate = null; //修改日期
if (objzx_TobeStudiedProblemVerEN.UpdUser == "[null]") objzx_TobeStudiedProblemVerEN.UpdUser = null; //修改人
if (objzx_TobeStudiedProblemVerEN.Year == "[null]") objzx_TobeStudiedProblemVerEN.Year = null; //年
if (objzx_TobeStudiedProblemVerEN.Month == "[null]") objzx_TobeStudiedProblemVerEN.Month = null; //月
if (objzx_TobeStudiedProblemVerEN.Memo == "[null]") objzx_TobeStudiedProblemVerEN.Memo = null; //备注
if (objzx_TobeStudiedProblemVerEN.ProblemTitle == "[null]") objzx_TobeStudiedProblemVerEN.ProblemTitle = null; //问题标题
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
public static void CheckPropertyNew(clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN)
{
 zx_TobeStudiedProblemVerDA.CheckPropertyNew(objzx_TobeStudiedProblemVerEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN)
{
 zx_TobeStudiedProblemVerDA.CheckProperty4Condition(objzx_TobeStudiedProblemVerEN);
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
if (clszx_TobeStudiedProblemVerBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_TobeStudiedProblemVerBL没有刷新缓存机制(clszx_TobeStudiedProblemVerBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ProblemVId");
//if (arrzx_TobeStudiedProblemVerObjLstCache == null)
//{
//arrzx_TobeStudiedProblemVerObjLstCache = zx_TobeStudiedProblemVerDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngProblemVId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_TobeStudiedProblemVerEN GetObjByProblemVIdCache(long lngProblemVId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clszx_TobeStudiedProblemVerEN._CurrTabName);
List<clszx_TobeStudiedProblemVerEN> arrzx_TobeStudiedProblemVerObjLstCache = GetObjLstCache();
IEnumerable <clszx_TobeStudiedProblemVerEN> arrzx_TobeStudiedProblemVerObjLst_Sel =
arrzx_TobeStudiedProblemVerObjLstCache
.Where(x=> x.ProblemVId == lngProblemVId 
);
if (arrzx_TobeStudiedProblemVerObjLst_Sel.Count() == 0)
{
   clszx_TobeStudiedProblemVerEN obj = clszx_TobeStudiedProblemVerBL.GetObjByProblemVId(lngProblemVId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrzx_TobeStudiedProblemVerObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_TobeStudiedProblemVerEN> GetAllzx_TobeStudiedProblemVerObjLstCache()
{
//获取缓存中的对象列表
List<clszx_TobeStudiedProblemVerEN> arrzx_TobeStudiedProblemVerObjLstCache = GetObjLstCache(); 
return arrzx_TobeStudiedProblemVerObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_TobeStudiedProblemVerEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clszx_TobeStudiedProblemVerEN._CurrTabName);
List<clszx_TobeStudiedProblemVerEN> arrzx_TobeStudiedProblemVerObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrzx_TobeStudiedProblemVerObjLstCache;
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
string strKey = string.Format("{0}", clszx_TobeStudiedProblemVerEN._CurrTabName);
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
if (clszx_TobeStudiedProblemVerBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clszx_TobeStudiedProblemVerEN._CurrTabName);
CacheHelper.Remove(strKey);
clszx_TobeStudiedProblemVerBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--zx_TobeStudiedProblemVer(中学待研究问题历史版本表)
 /// 唯一性条件:ProblemVId_ProblemId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_TobeStudiedProblemVerEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN)
{
//检测记录是否存在
string strResult = zx_TobeStudiedProblemVerDA.GetUniCondStr(objzx_TobeStudiedProblemVerEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngProblemVId)
{
if (strInFldName != conzx_TobeStudiedProblemVer.ProblemVId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conzx_TobeStudiedProblemVer.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conzx_TobeStudiedProblemVer.AttributeName));
throw new Exception(strMsg);
}
var objzx_TobeStudiedProblemVer = clszx_TobeStudiedProblemVerBL.GetObjByProblemVIdCache(lngProblemVId);
if (objzx_TobeStudiedProblemVer == null) return "";
return objzx_TobeStudiedProblemVer[strOutFldName].ToString();
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
int intRecCount = clszx_TobeStudiedProblemVerDA.GetRecCount(strTabName);
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
int intRecCount = clszx_TobeStudiedProblemVerDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clszx_TobeStudiedProblemVerDA.GetRecCount();
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
int intRecCount = clszx_TobeStudiedProblemVerDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objzx_TobeStudiedProblemVerCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerCond)
{
List<clszx_TobeStudiedProblemVerEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clszx_TobeStudiedProblemVerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_TobeStudiedProblemVer.AttributeName)
{
if (objzx_TobeStudiedProblemVerCond.IsUpdated(strFldName) == false) continue;
if (objzx_TobeStudiedProblemVerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_TobeStudiedProblemVerCond[strFldName].ToString());
}
else
{
if (objzx_TobeStudiedProblemVerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_TobeStudiedProblemVerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_TobeStudiedProblemVerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_TobeStudiedProblemVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_TobeStudiedProblemVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_TobeStudiedProblemVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_TobeStudiedProblemVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_TobeStudiedProblemVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_TobeStudiedProblemVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_TobeStudiedProblemVerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_TobeStudiedProblemVerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_TobeStudiedProblemVerCond[strFldName]));
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
 List<string> arrList = clszx_TobeStudiedProblemVerDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = zx_TobeStudiedProblemVerDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = zx_TobeStudiedProblemVerDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = zx_TobeStudiedProblemVerDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_TobeStudiedProblemVerDA.SetFldValue(clszx_TobeStudiedProblemVerEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = zx_TobeStudiedProblemVerDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_TobeStudiedProblemVerDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_TobeStudiedProblemVerDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_TobeStudiedProblemVerDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[zx_TobeStudiedProblemVer] "); 
 strCreateTabCode.Append(" ( "); 
 // /**ProblemVId*/ 
 strCreateTabCode.Append(" ProblemVId bigint primary key identity, "); 
 // /**问题Id*/ 
 strCreateTabCode.Append(" ProblemId char(10) not Null, "); 
 // /**小组Id*/ 
 strCreateTabCode.Append(" GroupTextId char(8) Null, "); 
 // /**是否提交*/ 
 strCreateTabCode.Append(" IsSubmit bit Null, "); 
 // /**问题内容*/ 
 strCreateTabCode.Append(" ProblemContent varchar(5000) Null, "); 
 // /**问题日期*/ 
 strCreateTabCode.Append(" ProblemDate varchar(20) Null, "); 
 // /**参与者*/ 
 strCreateTabCode.Append(" Participant varchar(500) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**年*/ 
 strCreateTabCode.Append(" Year char(4) Null, "); 
 // /**月*/ 
 strCreateTabCode.Append(" Month char(2) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**问题标题*/ 
 strCreateTabCode.Append(" ProblemTitle varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 中学待研究问题历史版本表(zx_TobeStudiedProblemVer)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4zx_TobeStudiedProblemVer : clsCommFun4BL
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
clszx_TobeStudiedProblemVerBL.ReFreshThisCache();
}
}

}