
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsqa_PaperBL
 表名:qa_Paper(01120643)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:13:29
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
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
public static class  clsqa_PaperBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strQaPaperId">表关键字</param>
 /// <returns>表对象</returns>
public static clsqa_PaperEN GetObj(this K_QaPaperId_qa_Paper myKey)
{
clsqa_PaperEN objqa_PaperEN = clsqa_PaperBL.qa_PaperDA.GetObjByQaPaperId(myKey.Value);
return objqa_PaperEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objqa_PaperEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsqa_PaperEN objqa_PaperEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objqa_PaperEN) == false)
{
var strMsg = string.Format("记录已经存在!论文答疑Id = [{0}]的数据已经存在!(in clsqa_PaperBL.AddNewRecord)", objqa_PaperEN.QaPaperId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objqa_PaperEN.QaPaperId) == true || clsqa_PaperBL.IsExist(objqa_PaperEN.QaPaperId) == true)
 {
     objqa_PaperEN.QaPaperId = clsqa_PaperBL.GetMaxStrId_S();
 }
bool bolResult = clsqa_PaperBL.qa_PaperDA.AddNewRecordBySQL2(objqa_PaperEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_PaperBL.ReFreshCache(objqa_PaperEN.IdCurrEduCls);

if (clsqa_PaperBL.relatedActions != null)
{
clsqa_PaperBL.relatedActions.UpdRelaTabDate(objqa_PaperEN.QaPaperId, "SetUpdDate");
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
public static bool AddRecordEx(this clsqa_PaperEN objqa_PaperEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsqa_PaperBL.IsExist(objqa_PaperEN.QaPaperId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objqa_PaperEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objqa_PaperEN.CheckUniqueness() == false)
{
strMsg = string.Format("(论文答疑Id(QaPaperId)=[{0}])已经存在,不能重复!", objqa_PaperEN.QaPaperId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objqa_PaperEN.QaPaperId) == true || clsqa_PaperBL.IsExist(objqa_PaperEN.QaPaperId) == true)
 {
     objqa_PaperEN.QaPaperId = clsqa_PaperBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objqa_PaperEN.AddNewRecord();
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
 /// <param name = "objqa_PaperEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsqa_PaperEN objqa_PaperEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objqa_PaperEN) == false)
{
var strMsg = string.Format("记录已经存在!论文答疑Id = [{0}]的数据已经存在!(in clsqa_PaperBL.AddNewRecordWithMaxId)", objqa_PaperEN.QaPaperId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objqa_PaperEN.QaPaperId) == true || clsqa_PaperBL.IsExist(objqa_PaperEN.QaPaperId) == true)
 {
     objqa_PaperEN.QaPaperId = clsqa_PaperBL.GetMaxStrId_S();
 }
string strQaPaperId = clsqa_PaperBL.qa_PaperDA.AddNewRecordBySQL2WithReturnKey(objqa_PaperEN);
     objqa_PaperEN.QaPaperId = strQaPaperId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_PaperBL.ReFreshCache(objqa_PaperEN.IdCurrEduCls);

if (clsqa_PaperBL.relatedActions != null)
{
clsqa_PaperBL.relatedActions.UpdRelaTabDate(objqa_PaperEN.QaPaperId, "SetUpdDate");
}
return strQaPaperId;
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
 /// <param name = "objqa_PaperEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsqa_PaperEN objqa_PaperEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objqa_PaperEN) == false)
{
var strMsg = string.Format("记录已经存在!论文答疑Id = [{0}]的数据已经存在!(in clsqa_PaperBL.AddNewRecordWithReturnKey)", objqa_PaperEN.QaPaperId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objqa_PaperEN.QaPaperId) == true || clsqa_PaperBL.IsExist(objqa_PaperEN.QaPaperId) == true)
 {
     objqa_PaperEN.QaPaperId = clsqa_PaperBL.GetMaxStrId_S();
 }
string strKey = clsqa_PaperBL.qa_PaperDA.AddNewRecordBySQL2WithReturnKey(objqa_PaperEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_PaperBL.ReFreshCache(objqa_PaperEN.IdCurrEduCls);

if (clsqa_PaperBL.relatedActions != null)
{
clsqa_PaperBL.relatedActions.UpdRelaTabDate(objqa_PaperEN.QaPaperId, "SetUpdDate");
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
 /// <param name = "objqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_PaperEN SetQaPaperId(this clsqa_PaperEN objqa_PaperEN, string strQaPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQaPaperId, 8, conqa_Paper.QaPaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQaPaperId, 8, conqa_Paper.QaPaperId);
}
objqa_PaperEN.QaPaperId = strQaPaperId; //论文答疑Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_PaperEN.dicFldComparisonOp.ContainsKey(conqa_Paper.QaPaperId) == false)
{
objqa_PaperEN.dicFldComparisonOp.Add(conqa_Paper.QaPaperId, strComparisonOp);
}
else
{
objqa_PaperEN.dicFldComparisonOp[conqa_Paper.QaPaperId] = strComparisonOp;
}
}
return objqa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_PaperEN SetPaperId(this clsqa_PaperEN objqa_PaperEN, string strPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperId, 8, conqa_Paper.PaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, conqa_Paper.PaperId);
}
objqa_PaperEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_PaperEN.dicFldComparisonOp.ContainsKey(conqa_Paper.PaperId) == false)
{
objqa_PaperEN.dicFldComparisonOp.Add(conqa_Paper.PaperId, strComparisonOp);
}
else
{
objqa_PaperEN.dicFldComparisonOp[conqa_Paper.PaperId] = strComparisonOp;
}
}
return objqa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_PaperEN SetQuestionsCount(this clsqa_PaperEN objqa_PaperEN, int? intQuestionsCount, string strComparisonOp="")
	{
objqa_PaperEN.QuestionsCount = intQuestionsCount; //提问计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_PaperEN.dicFldComparisonOp.ContainsKey(conqa_Paper.QuestionsCount) == false)
{
objqa_PaperEN.dicFldComparisonOp.Add(conqa_Paper.QuestionsCount, strComparisonOp);
}
else
{
objqa_PaperEN.dicFldComparisonOp[conqa_Paper.QuestionsCount] = strComparisonOp;
}
}
return objqa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_PaperEN SetIsDelete(this clsqa_PaperEN objqa_PaperEN, bool bolIsDelete, string strComparisonOp="")
	{
objqa_PaperEN.IsDelete = bolIsDelete; //是否删除
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_PaperEN.dicFldComparisonOp.ContainsKey(conqa_Paper.IsDelete) == false)
{
objqa_PaperEN.dicFldComparisonOp.Add(conqa_Paper.IsDelete, strComparisonOp);
}
else
{
objqa_PaperEN.dicFldComparisonOp[conqa_Paper.IsDelete] = strComparisonOp;
}
}
return objqa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_PaperEN SetIsPublic(this clsqa_PaperEN objqa_PaperEN, bool bolIsPublic, string strComparisonOp="")
	{
objqa_PaperEN.IsPublic = bolIsPublic; //是否公开
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_PaperEN.dicFldComparisonOp.ContainsKey(conqa_Paper.IsPublic) == false)
{
objqa_PaperEN.dicFldComparisonOp.Add(conqa_Paper.IsPublic, strComparisonOp);
}
else
{
objqa_PaperEN.dicFldComparisonOp[conqa_Paper.IsPublic] = strComparisonOp;
}
}
return objqa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_PaperEN SetIsSubmit(this clsqa_PaperEN objqa_PaperEN, bool bolIsSubmit, string strComparisonOp="")
	{
objqa_PaperEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_PaperEN.dicFldComparisonOp.ContainsKey(conqa_Paper.IsSubmit) == false)
{
objqa_PaperEN.dicFldComparisonOp.Add(conqa_Paper.IsSubmit, strComparisonOp);
}
else
{
objqa_PaperEN.dicFldComparisonOp[conqa_Paper.IsSubmit] = strComparisonOp;
}
}
return objqa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_PaperEN SetUpdUser(this clsqa_PaperEN objqa_PaperEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conqa_Paper.UpdUser);
}
objqa_PaperEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_PaperEN.dicFldComparisonOp.ContainsKey(conqa_Paper.UpdUser) == false)
{
objqa_PaperEN.dicFldComparisonOp.Add(conqa_Paper.UpdUser, strComparisonOp);
}
else
{
objqa_PaperEN.dicFldComparisonOp[conqa_Paper.UpdUser] = strComparisonOp;
}
}
return objqa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_PaperEN SetUpdDate(this clsqa_PaperEN objqa_PaperEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conqa_Paper.UpdDate);
}
objqa_PaperEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_PaperEN.dicFldComparisonOp.ContainsKey(conqa_Paper.UpdDate) == false)
{
objqa_PaperEN.dicFldComparisonOp.Add(conqa_Paper.UpdDate, strComparisonOp);
}
else
{
objqa_PaperEN.dicFldComparisonOp[conqa_Paper.UpdDate] = strComparisonOp;
}
}
return objqa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_PaperEN SetMemo(this clsqa_PaperEN objqa_PaperEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conqa_Paper.Memo);
}
objqa_PaperEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_PaperEN.dicFldComparisonOp.ContainsKey(conqa_Paper.Memo) == false)
{
objqa_PaperEN.dicFldComparisonOp.Add(conqa_Paper.Memo, strComparisonOp);
}
else
{
objqa_PaperEN.dicFldComparisonOp[conqa_Paper.Memo] = strComparisonOp;
}
}
return objqa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_PaperEN SetIdCurrEduCls(this clsqa_PaperEN objqa_PaperEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conqa_Paper.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conqa_Paper.IdCurrEduCls);
}
objqa_PaperEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_PaperEN.dicFldComparisonOp.ContainsKey(conqa_Paper.IdCurrEduCls) == false)
{
objqa_PaperEN.dicFldComparisonOp.Add(conqa_Paper.IdCurrEduCls, strComparisonOp);
}
else
{
objqa_PaperEN.dicFldComparisonOp[conqa_Paper.IdCurrEduCls] = strComparisonOp;
}
}
return objqa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_PaperEN SetAnswerCount(this clsqa_PaperEN objqa_PaperEN, int? intAnswerCount, string strComparisonOp="")
	{
objqa_PaperEN.AnswerCount = intAnswerCount; //回答计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_PaperEN.dicFldComparisonOp.ContainsKey(conqa_Paper.AnswerCount) == false)
{
objqa_PaperEN.dicFldComparisonOp.Add(conqa_Paper.AnswerCount, strComparisonOp);
}
else
{
objqa_PaperEN.dicFldComparisonOp[conqa_Paper.AnswerCount] = strComparisonOp;
}
}
return objqa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_PaperEN SetShareId(this clsqa_PaperEN objqa_PaperEN, string strShareId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strShareId, 2, conqa_Paper.ShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strShareId, 2, conqa_Paper.ShareId);
}
objqa_PaperEN.ShareId = strShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_PaperEN.dicFldComparisonOp.ContainsKey(conqa_Paper.ShareId) == false)
{
objqa_PaperEN.dicFldComparisonOp.Add(conqa_Paper.ShareId, strComparisonOp);
}
else
{
objqa_PaperEN.dicFldComparisonOp[conqa_Paper.ShareId] = strComparisonOp;
}
}
return objqa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_PaperEN SetTagsCount(this clsqa_PaperEN objqa_PaperEN, int? intTagsCount, string strComparisonOp="")
	{
objqa_PaperEN.TagsCount = intTagsCount; //论文标注数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_PaperEN.dicFldComparisonOp.ContainsKey(conqa_Paper.TagsCount) == false)
{
objqa_PaperEN.dicFldComparisonOp.Add(conqa_Paper.TagsCount, strComparisonOp);
}
else
{
objqa_PaperEN.dicFldComparisonOp[conqa_Paper.TagsCount] = strComparisonOp;
}
}
return objqa_PaperEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objqa_PaperEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsqa_PaperEN objqa_PaperEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objqa_PaperEN.CheckPropertyNew();
clsqa_PaperEN objqa_PaperCond = new clsqa_PaperEN();
string strCondition = objqa_PaperCond
.SetQaPaperId(objqa_PaperEN.QaPaperId, "<>")
.SetQaPaperId(objqa_PaperEN.QaPaperId, "=")
.GetCombineCondition();
objqa_PaperEN._IsCheckProperty = true;
bool bolIsExist = clsqa_PaperBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(qa_PaperId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objqa_PaperEN.Update();
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
 /// <param name = "objqa_Paper">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsqa_PaperEN objqa_Paper)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsqa_PaperEN objqa_PaperCond = new clsqa_PaperEN();
string strCondition = objqa_PaperCond
.SetQaPaperId(objqa_Paper.QaPaperId, "=")
.GetCombineCondition();
objqa_Paper._IsCheckProperty = true;
bool bolIsExist = clsqa_PaperBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objqa_Paper.QaPaperId = clsqa_PaperBL.GetFirstID_S(strCondition);
objqa_Paper.UpdateWithCondition(strCondition);
}
else
{
objqa_Paper.QaPaperId = clsqa_PaperBL.GetMaxStrId_S();
objqa_Paper.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objqa_PaperEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsqa_PaperEN objqa_PaperEN)
{
 if (string.IsNullOrEmpty(objqa_PaperEN.QaPaperId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsqa_PaperBL.qa_PaperDA.UpdateBySql2(objqa_PaperEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_PaperBL.ReFreshCache(objqa_PaperEN.IdCurrEduCls);

if (clsqa_PaperBL.relatedActions != null)
{
clsqa_PaperBL.relatedActions.UpdRelaTabDate(objqa_PaperEN.QaPaperId, "SetUpdDate");
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
 /// <param name = "objqa_PaperEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsqa_PaperEN objqa_PaperEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objqa_PaperEN.QaPaperId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsqa_PaperBL.qa_PaperDA.UpdateBySql2(objqa_PaperEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_PaperBL.ReFreshCache(objqa_PaperEN.IdCurrEduCls);

if (clsqa_PaperBL.relatedActions != null)
{
clsqa_PaperBL.relatedActions.UpdRelaTabDate(objqa_PaperEN.QaPaperId, "SetUpdDate");
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
 /// <param name = "objqa_PaperEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsqa_PaperEN objqa_PaperEN, string strWhereCond)
{
try
{
bool bolResult = clsqa_PaperBL.qa_PaperDA.UpdateBySqlWithCondition(objqa_PaperEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_PaperBL.ReFreshCache(objqa_PaperEN.IdCurrEduCls);

if (clsqa_PaperBL.relatedActions != null)
{
clsqa_PaperBL.relatedActions.UpdRelaTabDate(objqa_PaperEN.QaPaperId, "SetUpdDate");
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
 /// <param name = "objqa_PaperEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsqa_PaperEN objqa_PaperEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsqa_PaperBL.qa_PaperDA.UpdateBySqlWithConditionTransaction(objqa_PaperEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_PaperBL.ReFreshCache(objqa_PaperEN.IdCurrEduCls);

if (clsqa_PaperBL.relatedActions != null)
{
clsqa_PaperBL.relatedActions.UpdRelaTabDate(objqa_PaperEN.QaPaperId, "SetUpdDate");
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
 /// <param name = "strQaPaperId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsqa_PaperEN objqa_PaperEN)
{
try
{
int intRecNum = clsqa_PaperBL.qa_PaperDA.DelRecord(objqa_PaperEN.QaPaperId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_PaperBL.ReFreshCache(objqa_PaperEN.IdCurrEduCls);

if (clsqa_PaperBL.relatedActions != null)
{
clsqa_PaperBL.relatedActions.UpdRelaTabDate(objqa_PaperEN.QaPaperId, "SetUpdDate");
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
 /// <param name = "objqa_PaperENS">源对象</param>
 /// <param name = "objqa_PaperENT">目标对象</param>
 public static void CopyTo(this clsqa_PaperEN objqa_PaperENS, clsqa_PaperEN objqa_PaperENT)
{
try
{
objqa_PaperENT.QaPaperId = objqa_PaperENS.QaPaperId; //论文答疑Id
objqa_PaperENT.PaperId = objqa_PaperENS.PaperId; //论文Id
objqa_PaperENT.QuestionsCount = objqa_PaperENS.QuestionsCount; //提问计数
objqa_PaperENT.IsDelete = objqa_PaperENS.IsDelete; //是否删除
objqa_PaperENT.IsPublic = objqa_PaperENS.IsPublic; //是否公开
objqa_PaperENT.IsSubmit = objqa_PaperENS.IsSubmit; //是否提交
objqa_PaperENT.UpdUser = objqa_PaperENS.UpdUser; //修改人
objqa_PaperENT.UpdDate = objqa_PaperENS.UpdDate; //修改日期
objqa_PaperENT.Memo = objqa_PaperENS.Memo; //备注
objqa_PaperENT.IdCurrEduCls = objqa_PaperENS.IdCurrEduCls; //教学班流水号
objqa_PaperENT.AnswerCount = objqa_PaperENS.AnswerCount; //回答计数
objqa_PaperENT.ShareId = objqa_PaperENS.ShareId; //分享Id
objqa_PaperENT.TagsCount = objqa_PaperENS.TagsCount; //论文标注数
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
 /// <param name = "objqa_PaperENS">源对象</param>
 /// <returns>目标对象=>clsqa_PaperEN:objqa_PaperENT</returns>
 public static clsqa_PaperEN CopyTo(this clsqa_PaperEN objqa_PaperENS)
{
try
{
 clsqa_PaperEN objqa_PaperENT = new clsqa_PaperEN()
{
QaPaperId = objqa_PaperENS.QaPaperId, //论文答疑Id
PaperId = objqa_PaperENS.PaperId, //论文Id
QuestionsCount = objqa_PaperENS.QuestionsCount, //提问计数
IsDelete = objqa_PaperENS.IsDelete, //是否删除
IsPublic = objqa_PaperENS.IsPublic, //是否公开
IsSubmit = objqa_PaperENS.IsSubmit, //是否提交
UpdUser = objqa_PaperENS.UpdUser, //修改人
UpdDate = objqa_PaperENS.UpdDate, //修改日期
Memo = objqa_PaperENS.Memo, //备注
IdCurrEduCls = objqa_PaperENS.IdCurrEduCls, //教学班流水号
AnswerCount = objqa_PaperENS.AnswerCount, //回答计数
ShareId = objqa_PaperENS.ShareId, //分享Id
TagsCount = objqa_PaperENS.TagsCount, //论文标注数
};
 return objqa_PaperENT;
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
public static void CheckPropertyNew(this clsqa_PaperEN objqa_PaperEN)
{
 clsqa_PaperBL.qa_PaperDA.CheckPropertyNew(objqa_PaperEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsqa_PaperEN objqa_PaperEN)
{
 clsqa_PaperBL.qa_PaperDA.CheckProperty4Condition(objqa_PaperEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsqa_PaperEN objqa_PaperCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objqa_PaperCond.IsUpdated(conqa_Paper.QaPaperId) == true)
{
string strComparisonOpQaPaperId = objqa_PaperCond.dicFldComparisonOp[conqa_Paper.QaPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Paper.QaPaperId, objqa_PaperCond.QaPaperId, strComparisonOpQaPaperId);
}
if (objqa_PaperCond.IsUpdated(conqa_Paper.PaperId) == true)
{
string strComparisonOpPaperId = objqa_PaperCond.dicFldComparisonOp[conqa_Paper.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Paper.PaperId, objqa_PaperCond.PaperId, strComparisonOpPaperId);
}
if (objqa_PaperCond.IsUpdated(conqa_Paper.QuestionsCount) == true)
{
string strComparisonOpQuestionsCount = objqa_PaperCond.dicFldComparisonOp[conqa_Paper.QuestionsCount];
strWhereCond += string.Format(" And {0} {2} {1}", conqa_Paper.QuestionsCount, objqa_PaperCond.QuestionsCount, strComparisonOpQuestionsCount);
}
if (objqa_PaperCond.IsUpdated(conqa_Paper.IsDelete) == true)
{
if (objqa_PaperCond.IsDelete == true)
{
strWhereCond += string.Format(" And {0} = '1'", conqa_Paper.IsDelete);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conqa_Paper.IsDelete);
}
}
if (objqa_PaperCond.IsUpdated(conqa_Paper.IsPublic) == true)
{
if (objqa_PaperCond.IsPublic == true)
{
strWhereCond += string.Format(" And {0} = '1'", conqa_Paper.IsPublic);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conqa_Paper.IsPublic);
}
}
if (objqa_PaperCond.IsUpdated(conqa_Paper.IsSubmit) == true)
{
if (objqa_PaperCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", conqa_Paper.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conqa_Paper.IsSubmit);
}
}
if (objqa_PaperCond.IsUpdated(conqa_Paper.UpdUser) == true)
{
string strComparisonOpUpdUser = objqa_PaperCond.dicFldComparisonOp[conqa_Paper.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Paper.UpdUser, objqa_PaperCond.UpdUser, strComparisonOpUpdUser);
}
if (objqa_PaperCond.IsUpdated(conqa_Paper.UpdDate) == true)
{
string strComparisonOpUpdDate = objqa_PaperCond.dicFldComparisonOp[conqa_Paper.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Paper.UpdDate, objqa_PaperCond.UpdDate, strComparisonOpUpdDate);
}
if (objqa_PaperCond.IsUpdated(conqa_Paper.Memo) == true)
{
string strComparisonOpMemo = objqa_PaperCond.dicFldComparisonOp[conqa_Paper.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Paper.Memo, objqa_PaperCond.Memo, strComparisonOpMemo);
}
if (objqa_PaperCond.IsUpdated(conqa_Paper.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objqa_PaperCond.dicFldComparisonOp[conqa_Paper.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Paper.IdCurrEduCls, objqa_PaperCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objqa_PaperCond.IsUpdated(conqa_Paper.AnswerCount) == true)
{
string strComparisonOpAnswerCount = objqa_PaperCond.dicFldComparisonOp[conqa_Paper.AnswerCount];
strWhereCond += string.Format(" And {0} {2} {1}", conqa_Paper.AnswerCount, objqa_PaperCond.AnswerCount, strComparisonOpAnswerCount);
}
if (objqa_PaperCond.IsUpdated(conqa_Paper.ShareId) == true)
{
string strComparisonOpShareId = objqa_PaperCond.dicFldComparisonOp[conqa_Paper.ShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Paper.ShareId, objqa_PaperCond.ShareId, strComparisonOpShareId);
}
if (objqa_PaperCond.IsUpdated(conqa_Paper.TagsCount) == true)
{
string strComparisonOpTagsCount = objqa_PaperCond.dicFldComparisonOp[conqa_Paper.TagsCount];
strWhereCond += string.Format(" And {0} {2} {1}", conqa_Paper.TagsCount, objqa_PaperCond.TagsCount, strComparisonOpTagsCount);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--qa_Paper(论文答疑表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:qa_PaperId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objqa_PaperEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsqa_PaperEN objqa_PaperEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objqa_PaperEN == null) return true;
if (objqa_PaperEN.QaPaperId == null || objqa_PaperEN.QaPaperId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and QaPaperId = '{0}'", objqa_PaperEN.QaPaperId);
if (clsqa_PaperBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("QaPaperId !=  '{0}'", objqa_PaperEN.QaPaperId);
 sbCondition.AppendFormat(" and QaPaperId = '{0}'", objqa_PaperEN.QaPaperId);
if (clsqa_PaperBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--qa_Paper(论文答疑表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:qa_PaperId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objqa_PaperEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsqa_PaperEN objqa_PaperEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objqa_PaperEN == null) return "";
if (objqa_PaperEN.QaPaperId == null || objqa_PaperEN.QaPaperId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and QaPaperId = '{0}'", objqa_PaperEN.QaPaperId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("QaPaperId !=  '{0}'", objqa_PaperEN.QaPaperId);
 sbCondition.AppendFormat(" and QaPaperId = '{0}'", objqa_PaperEN.QaPaperId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_qa_Paper
{
public virtual bool UpdRelaTabDate(string strQaPaperId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 论文答疑表(qa_Paper)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsqa_PaperBL
{
public static RelatedActions_qa_Paper relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsqa_PaperDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsqa_PaperDA qa_PaperDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsqa_PaperDA();
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
 public clsqa_PaperBL()
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
if (string.IsNullOrEmpty(clsqa_PaperEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsqa_PaperEN._ConnectString);
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
public static DataTable GetDataTable_qa_Paper(string strWhereCond)
{
DataTable objDT;
try
{
objDT = qa_PaperDA.GetDataTable_qa_Paper(strWhereCond);
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
objDT = qa_PaperDA.GetDataTable(strWhereCond);
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
objDT = qa_PaperDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = qa_PaperDA.GetDataTable(strWhereCond, strTabName);
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
objDT = qa_PaperDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = qa_PaperDA.GetDataTable_Top(objTopPara);
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
objDT = qa_PaperDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = qa_PaperDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = qa_PaperDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrQaPaperIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsqa_PaperEN> GetObjLstByQaPaperIdLst(List<string> arrQaPaperIdLst)
{
List<clsqa_PaperEN> arrObjLst = new List<clsqa_PaperEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrQaPaperIdLst, true);
 string strWhereCond = string.Format("QaPaperId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsqa_PaperEN objqa_PaperEN = new clsqa_PaperEN();
try
{
objqa_PaperEN.QaPaperId = objRow[conqa_Paper.QaPaperId].ToString().Trim(); //论文答疑Id
objqa_PaperEN.PaperId = objRow[conqa_Paper.PaperId] == DBNull.Value ? null : objRow[conqa_Paper.PaperId].ToString().Trim(); //论文Id
objqa_PaperEN.QuestionsCount = objRow[conqa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objqa_PaperEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[conqa_Paper.IsDelete].ToString().Trim()); //是否删除
objqa_PaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conqa_Paper.IsPublic].ToString().Trim()); //是否公开
objqa_PaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conqa_Paper.IsSubmit].ToString().Trim()); //是否提交
objqa_PaperEN.UpdUser = objRow[conqa_Paper.UpdUser] == DBNull.Value ? null : objRow[conqa_Paper.UpdUser].ToString().Trim(); //修改人
objqa_PaperEN.UpdDate = objRow[conqa_Paper.UpdDate] == DBNull.Value ? null : objRow[conqa_Paper.UpdDate].ToString().Trim(); //修改日期
objqa_PaperEN.Memo = objRow[conqa_Paper.Memo] == DBNull.Value ? null : objRow[conqa_Paper.Memo].ToString().Trim(); //备注
objqa_PaperEN.IdCurrEduCls = objRow[conqa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[conqa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objqa_PaperEN.AnswerCount = objRow[conqa_Paper.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Paper.AnswerCount].ToString().Trim()); //回答计数
objqa_PaperEN.ShareId = objRow[conqa_Paper.ShareId] == DBNull.Value ? null : objRow[conqa_Paper.ShareId].ToString().Trim(); //分享Id
objqa_PaperEN.TagsCount = objRow[conqa_Paper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objqa_PaperEN.QaPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objqa_PaperEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrQaPaperIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsqa_PaperEN> GetObjLstByQaPaperIdLstCache(List<string> arrQaPaperIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsqa_PaperEN._CurrTabName, strIdCurrEduCls);
List<clsqa_PaperEN> arrqa_PaperObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsqa_PaperEN> arrqa_PaperObjLst_Sel =
arrqa_PaperObjLstCache
.Where(x => arrQaPaperIdLst.Contains(x.QaPaperId));
return arrqa_PaperObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsqa_PaperEN> GetObjLst(string strWhereCond)
{
List<clsqa_PaperEN> arrObjLst = new List<clsqa_PaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsqa_PaperEN objqa_PaperEN = new clsqa_PaperEN();
try
{
objqa_PaperEN.QaPaperId = objRow[conqa_Paper.QaPaperId].ToString().Trim(); //论文答疑Id
objqa_PaperEN.PaperId = objRow[conqa_Paper.PaperId] == DBNull.Value ? null : objRow[conqa_Paper.PaperId].ToString().Trim(); //论文Id
objqa_PaperEN.QuestionsCount = objRow[conqa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objqa_PaperEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[conqa_Paper.IsDelete].ToString().Trim()); //是否删除
objqa_PaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conqa_Paper.IsPublic].ToString().Trim()); //是否公开
objqa_PaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conqa_Paper.IsSubmit].ToString().Trim()); //是否提交
objqa_PaperEN.UpdUser = objRow[conqa_Paper.UpdUser] == DBNull.Value ? null : objRow[conqa_Paper.UpdUser].ToString().Trim(); //修改人
objqa_PaperEN.UpdDate = objRow[conqa_Paper.UpdDate] == DBNull.Value ? null : objRow[conqa_Paper.UpdDate].ToString().Trim(); //修改日期
objqa_PaperEN.Memo = objRow[conqa_Paper.Memo] == DBNull.Value ? null : objRow[conqa_Paper.Memo].ToString().Trim(); //备注
objqa_PaperEN.IdCurrEduCls = objRow[conqa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[conqa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objqa_PaperEN.AnswerCount = objRow[conqa_Paper.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Paper.AnswerCount].ToString().Trim()); //回答计数
objqa_PaperEN.ShareId = objRow[conqa_Paper.ShareId] == DBNull.Value ? null : objRow[conqa_Paper.ShareId].ToString().Trim(); //分享Id
objqa_PaperEN.TagsCount = objRow[conqa_Paper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objqa_PaperEN.QaPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objqa_PaperEN);
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
public static List<clsqa_PaperEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsqa_PaperEN> arrObjLst = new List<clsqa_PaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsqa_PaperEN objqa_PaperEN = new clsqa_PaperEN();
try
{
objqa_PaperEN.QaPaperId = objRow[conqa_Paper.QaPaperId].ToString().Trim(); //论文答疑Id
objqa_PaperEN.PaperId = objRow[conqa_Paper.PaperId] == DBNull.Value ? null : objRow[conqa_Paper.PaperId].ToString().Trim(); //论文Id
objqa_PaperEN.QuestionsCount = objRow[conqa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objqa_PaperEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[conqa_Paper.IsDelete].ToString().Trim()); //是否删除
objqa_PaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conqa_Paper.IsPublic].ToString().Trim()); //是否公开
objqa_PaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conqa_Paper.IsSubmit].ToString().Trim()); //是否提交
objqa_PaperEN.UpdUser = objRow[conqa_Paper.UpdUser] == DBNull.Value ? null : objRow[conqa_Paper.UpdUser].ToString().Trim(); //修改人
objqa_PaperEN.UpdDate = objRow[conqa_Paper.UpdDate] == DBNull.Value ? null : objRow[conqa_Paper.UpdDate].ToString().Trim(); //修改日期
objqa_PaperEN.Memo = objRow[conqa_Paper.Memo] == DBNull.Value ? null : objRow[conqa_Paper.Memo].ToString().Trim(); //备注
objqa_PaperEN.IdCurrEduCls = objRow[conqa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[conqa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objqa_PaperEN.AnswerCount = objRow[conqa_Paper.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Paper.AnswerCount].ToString().Trim()); //回答计数
objqa_PaperEN.ShareId = objRow[conqa_Paper.ShareId] == DBNull.Value ? null : objRow[conqa_Paper.ShareId].ToString().Trim(); //分享Id
objqa_PaperEN.TagsCount = objRow[conqa_Paper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objqa_PaperEN.QaPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objqa_PaperEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objqa_PaperCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsqa_PaperEN> GetSubObjLstCache(clsqa_PaperEN objqa_PaperCond)
{
 string strIdCurrEduCls = objqa_PaperCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsqa_PaperBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsqa_PaperEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsqa_PaperEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conqa_Paper.AttributeName)
{
if (objqa_PaperCond.IsUpdated(strFldName) == false) continue;
if (objqa_PaperCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objqa_PaperCond[strFldName].ToString());
}
else
{
if (objqa_PaperCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objqa_PaperCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objqa_PaperCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objqa_PaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objqa_PaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objqa_PaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objqa_PaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objqa_PaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objqa_PaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objqa_PaperCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objqa_PaperCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objqa_PaperCond[strFldName]));
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
public static List<clsqa_PaperEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsqa_PaperEN> arrObjLst = new List<clsqa_PaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsqa_PaperEN objqa_PaperEN = new clsqa_PaperEN();
try
{
objqa_PaperEN.QaPaperId = objRow[conqa_Paper.QaPaperId].ToString().Trim(); //论文答疑Id
objqa_PaperEN.PaperId = objRow[conqa_Paper.PaperId] == DBNull.Value ? null : objRow[conqa_Paper.PaperId].ToString().Trim(); //论文Id
objqa_PaperEN.QuestionsCount = objRow[conqa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objqa_PaperEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[conqa_Paper.IsDelete].ToString().Trim()); //是否删除
objqa_PaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conqa_Paper.IsPublic].ToString().Trim()); //是否公开
objqa_PaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conqa_Paper.IsSubmit].ToString().Trim()); //是否提交
objqa_PaperEN.UpdUser = objRow[conqa_Paper.UpdUser] == DBNull.Value ? null : objRow[conqa_Paper.UpdUser].ToString().Trim(); //修改人
objqa_PaperEN.UpdDate = objRow[conqa_Paper.UpdDate] == DBNull.Value ? null : objRow[conqa_Paper.UpdDate].ToString().Trim(); //修改日期
objqa_PaperEN.Memo = objRow[conqa_Paper.Memo] == DBNull.Value ? null : objRow[conqa_Paper.Memo].ToString().Trim(); //备注
objqa_PaperEN.IdCurrEduCls = objRow[conqa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[conqa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objqa_PaperEN.AnswerCount = objRow[conqa_Paper.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Paper.AnswerCount].ToString().Trim()); //回答计数
objqa_PaperEN.ShareId = objRow[conqa_Paper.ShareId] == DBNull.Value ? null : objRow[conqa_Paper.ShareId].ToString().Trim(); //分享Id
objqa_PaperEN.TagsCount = objRow[conqa_Paper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objqa_PaperEN.QaPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objqa_PaperEN);
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
public static List<clsqa_PaperEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsqa_PaperEN> arrObjLst = new List<clsqa_PaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsqa_PaperEN objqa_PaperEN = new clsqa_PaperEN();
try
{
objqa_PaperEN.QaPaperId = objRow[conqa_Paper.QaPaperId].ToString().Trim(); //论文答疑Id
objqa_PaperEN.PaperId = objRow[conqa_Paper.PaperId] == DBNull.Value ? null : objRow[conqa_Paper.PaperId].ToString().Trim(); //论文Id
objqa_PaperEN.QuestionsCount = objRow[conqa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objqa_PaperEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[conqa_Paper.IsDelete].ToString().Trim()); //是否删除
objqa_PaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conqa_Paper.IsPublic].ToString().Trim()); //是否公开
objqa_PaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conqa_Paper.IsSubmit].ToString().Trim()); //是否提交
objqa_PaperEN.UpdUser = objRow[conqa_Paper.UpdUser] == DBNull.Value ? null : objRow[conqa_Paper.UpdUser].ToString().Trim(); //修改人
objqa_PaperEN.UpdDate = objRow[conqa_Paper.UpdDate] == DBNull.Value ? null : objRow[conqa_Paper.UpdDate].ToString().Trim(); //修改日期
objqa_PaperEN.Memo = objRow[conqa_Paper.Memo] == DBNull.Value ? null : objRow[conqa_Paper.Memo].ToString().Trim(); //备注
objqa_PaperEN.IdCurrEduCls = objRow[conqa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[conqa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objqa_PaperEN.AnswerCount = objRow[conqa_Paper.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Paper.AnswerCount].ToString().Trim()); //回答计数
objqa_PaperEN.ShareId = objRow[conqa_Paper.ShareId] == DBNull.Value ? null : objRow[conqa_Paper.ShareId].ToString().Trim(); //分享Id
objqa_PaperEN.TagsCount = objRow[conqa_Paper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objqa_PaperEN.QaPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objqa_PaperEN);
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
List<clsqa_PaperEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsqa_PaperEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsqa_PaperEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsqa_PaperEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsqa_PaperEN> arrObjLst = new List<clsqa_PaperEN>(); 
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
	clsqa_PaperEN objqa_PaperEN = new clsqa_PaperEN();
try
{
objqa_PaperEN.QaPaperId = objRow[conqa_Paper.QaPaperId].ToString().Trim(); //论文答疑Id
objqa_PaperEN.PaperId = objRow[conqa_Paper.PaperId] == DBNull.Value ? null : objRow[conqa_Paper.PaperId].ToString().Trim(); //论文Id
objqa_PaperEN.QuestionsCount = objRow[conqa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objqa_PaperEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[conqa_Paper.IsDelete].ToString().Trim()); //是否删除
objqa_PaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conqa_Paper.IsPublic].ToString().Trim()); //是否公开
objqa_PaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conqa_Paper.IsSubmit].ToString().Trim()); //是否提交
objqa_PaperEN.UpdUser = objRow[conqa_Paper.UpdUser] == DBNull.Value ? null : objRow[conqa_Paper.UpdUser].ToString().Trim(); //修改人
objqa_PaperEN.UpdDate = objRow[conqa_Paper.UpdDate] == DBNull.Value ? null : objRow[conqa_Paper.UpdDate].ToString().Trim(); //修改日期
objqa_PaperEN.Memo = objRow[conqa_Paper.Memo] == DBNull.Value ? null : objRow[conqa_Paper.Memo].ToString().Trim(); //备注
objqa_PaperEN.IdCurrEduCls = objRow[conqa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[conqa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objqa_PaperEN.AnswerCount = objRow[conqa_Paper.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Paper.AnswerCount].ToString().Trim()); //回答计数
objqa_PaperEN.ShareId = objRow[conqa_Paper.ShareId] == DBNull.Value ? null : objRow[conqa_Paper.ShareId].ToString().Trim(); //分享Id
objqa_PaperEN.TagsCount = objRow[conqa_Paper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objqa_PaperEN.QaPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objqa_PaperEN);
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
public static List<clsqa_PaperEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsqa_PaperEN> arrObjLst = new List<clsqa_PaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsqa_PaperEN objqa_PaperEN = new clsqa_PaperEN();
try
{
objqa_PaperEN.QaPaperId = objRow[conqa_Paper.QaPaperId].ToString().Trim(); //论文答疑Id
objqa_PaperEN.PaperId = objRow[conqa_Paper.PaperId] == DBNull.Value ? null : objRow[conqa_Paper.PaperId].ToString().Trim(); //论文Id
objqa_PaperEN.QuestionsCount = objRow[conqa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objqa_PaperEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[conqa_Paper.IsDelete].ToString().Trim()); //是否删除
objqa_PaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conqa_Paper.IsPublic].ToString().Trim()); //是否公开
objqa_PaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conqa_Paper.IsSubmit].ToString().Trim()); //是否提交
objqa_PaperEN.UpdUser = objRow[conqa_Paper.UpdUser] == DBNull.Value ? null : objRow[conqa_Paper.UpdUser].ToString().Trim(); //修改人
objqa_PaperEN.UpdDate = objRow[conqa_Paper.UpdDate] == DBNull.Value ? null : objRow[conqa_Paper.UpdDate].ToString().Trim(); //修改日期
objqa_PaperEN.Memo = objRow[conqa_Paper.Memo] == DBNull.Value ? null : objRow[conqa_Paper.Memo].ToString().Trim(); //备注
objqa_PaperEN.IdCurrEduCls = objRow[conqa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[conqa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objqa_PaperEN.AnswerCount = objRow[conqa_Paper.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Paper.AnswerCount].ToString().Trim()); //回答计数
objqa_PaperEN.ShareId = objRow[conqa_Paper.ShareId] == DBNull.Value ? null : objRow[conqa_Paper.ShareId].ToString().Trim(); //分享Id
objqa_PaperEN.TagsCount = objRow[conqa_Paper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objqa_PaperEN.QaPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objqa_PaperEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsqa_PaperEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsqa_PaperEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsqa_PaperEN> arrObjLst = new List<clsqa_PaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsqa_PaperEN objqa_PaperEN = new clsqa_PaperEN();
try
{
objqa_PaperEN.QaPaperId = objRow[conqa_Paper.QaPaperId].ToString().Trim(); //论文答疑Id
objqa_PaperEN.PaperId = objRow[conqa_Paper.PaperId] == DBNull.Value ? null : objRow[conqa_Paper.PaperId].ToString().Trim(); //论文Id
objqa_PaperEN.QuestionsCount = objRow[conqa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objqa_PaperEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[conqa_Paper.IsDelete].ToString().Trim()); //是否删除
objqa_PaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conqa_Paper.IsPublic].ToString().Trim()); //是否公开
objqa_PaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conqa_Paper.IsSubmit].ToString().Trim()); //是否提交
objqa_PaperEN.UpdUser = objRow[conqa_Paper.UpdUser] == DBNull.Value ? null : objRow[conqa_Paper.UpdUser].ToString().Trim(); //修改人
objqa_PaperEN.UpdDate = objRow[conqa_Paper.UpdDate] == DBNull.Value ? null : objRow[conqa_Paper.UpdDate].ToString().Trim(); //修改日期
objqa_PaperEN.Memo = objRow[conqa_Paper.Memo] == DBNull.Value ? null : objRow[conqa_Paper.Memo].ToString().Trim(); //备注
objqa_PaperEN.IdCurrEduCls = objRow[conqa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[conqa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objqa_PaperEN.AnswerCount = objRow[conqa_Paper.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Paper.AnswerCount].ToString().Trim()); //回答计数
objqa_PaperEN.ShareId = objRow[conqa_Paper.ShareId] == DBNull.Value ? null : objRow[conqa_Paper.ShareId].ToString().Trim(); //分享Id
objqa_PaperEN.TagsCount = objRow[conqa_Paper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objqa_PaperEN.QaPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objqa_PaperEN);
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
public static List<clsqa_PaperEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsqa_PaperEN> arrObjLst = new List<clsqa_PaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsqa_PaperEN objqa_PaperEN = new clsqa_PaperEN();
try
{
objqa_PaperEN.QaPaperId = objRow[conqa_Paper.QaPaperId].ToString().Trim(); //论文答疑Id
objqa_PaperEN.PaperId = objRow[conqa_Paper.PaperId] == DBNull.Value ? null : objRow[conqa_Paper.PaperId].ToString().Trim(); //论文Id
objqa_PaperEN.QuestionsCount = objRow[conqa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objqa_PaperEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[conqa_Paper.IsDelete].ToString().Trim()); //是否删除
objqa_PaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conqa_Paper.IsPublic].ToString().Trim()); //是否公开
objqa_PaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conqa_Paper.IsSubmit].ToString().Trim()); //是否提交
objqa_PaperEN.UpdUser = objRow[conqa_Paper.UpdUser] == DBNull.Value ? null : objRow[conqa_Paper.UpdUser].ToString().Trim(); //修改人
objqa_PaperEN.UpdDate = objRow[conqa_Paper.UpdDate] == DBNull.Value ? null : objRow[conqa_Paper.UpdDate].ToString().Trim(); //修改日期
objqa_PaperEN.Memo = objRow[conqa_Paper.Memo] == DBNull.Value ? null : objRow[conqa_Paper.Memo].ToString().Trim(); //备注
objqa_PaperEN.IdCurrEduCls = objRow[conqa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[conqa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objqa_PaperEN.AnswerCount = objRow[conqa_Paper.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Paper.AnswerCount].ToString().Trim()); //回答计数
objqa_PaperEN.ShareId = objRow[conqa_Paper.ShareId] == DBNull.Value ? null : objRow[conqa_Paper.ShareId].ToString().Trim(); //分享Id
objqa_PaperEN.TagsCount = objRow[conqa_Paper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objqa_PaperEN.QaPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objqa_PaperEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsqa_PaperEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsqa_PaperEN> arrObjLst = new List<clsqa_PaperEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsqa_PaperEN objqa_PaperEN = new clsqa_PaperEN();
try
{
objqa_PaperEN.QaPaperId = objRow[conqa_Paper.QaPaperId].ToString().Trim(); //论文答疑Id
objqa_PaperEN.PaperId = objRow[conqa_Paper.PaperId] == DBNull.Value ? null : objRow[conqa_Paper.PaperId].ToString().Trim(); //论文Id
objqa_PaperEN.QuestionsCount = objRow[conqa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objqa_PaperEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[conqa_Paper.IsDelete].ToString().Trim()); //是否删除
objqa_PaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conqa_Paper.IsPublic].ToString().Trim()); //是否公开
objqa_PaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conqa_Paper.IsSubmit].ToString().Trim()); //是否提交
objqa_PaperEN.UpdUser = objRow[conqa_Paper.UpdUser] == DBNull.Value ? null : objRow[conqa_Paper.UpdUser].ToString().Trim(); //修改人
objqa_PaperEN.UpdDate = objRow[conqa_Paper.UpdDate] == DBNull.Value ? null : objRow[conqa_Paper.UpdDate].ToString().Trim(); //修改日期
objqa_PaperEN.Memo = objRow[conqa_Paper.Memo] == DBNull.Value ? null : objRow[conqa_Paper.Memo].ToString().Trim(); //备注
objqa_PaperEN.IdCurrEduCls = objRow[conqa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[conqa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objqa_PaperEN.AnswerCount = objRow[conqa_Paper.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Paper.AnswerCount].ToString().Trim()); //回答计数
objqa_PaperEN.ShareId = objRow[conqa_Paper.ShareId] == DBNull.Value ? null : objRow[conqa_Paper.ShareId].ToString().Trim(); //分享Id
objqa_PaperEN.TagsCount = objRow[conqa_Paper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objqa_PaperEN.QaPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objqa_PaperEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objqa_PaperEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getqa_Paper(ref clsqa_PaperEN objqa_PaperEN)
{
bool bolResult = qa_PaperDA.Getqa_Paper(ref objqa_PaperEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strQaPaperId">表关键字</param>
 /// <returns>表对象</returns>
public static clsqa_PaperEN GetObjByQaPaperId(string strQaPaperId)
{
if (strQaPaperId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strQaPaperId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strQaPaperId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strQaPaperId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsqa_PaperEN objqa_PaperEN = qa_PaperDA.GetObjByQaPaperId(strQaPaperId);
return objqa_PaperEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsqa_PaperEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsqa_PaperEN objqa_PaperEN = qa_PaperDA.GetFirstObj(strWhereCond);
 return objqa_PaperEN;
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
public static clsqa_PaperEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsqa_PaperEN objqa_PaperEN = qa_PaperDA.GetObjByDataRow(objRow);
 return objqa_PaperEN;
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
public static clsqa_PaperEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsqa_PaperEN objqa_PaperEN = qa_PaperDA.GetObjByDataRow(objRow);
 return objqa_PaperEN;
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
 /// <param name = "strQaPaperId">所给的关键字</param>
 /// <param name = "lstqa_PaperObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsqa_PaperEN GetObjByQaPaperIdFromList(string strQaPaperId, List<clsqa_PaperEN> lstqa_PaperObjLst)
{
foreach (clsqa_PaperEN objqa_PaperEN in lstqa_PaperObjLst)
{
if (objqa_PaperEN.QaPaperId == strQaPaperId)
{
return objqa_PaperEN;
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
 string strMaxQaPaperId;
 try
 {
 strMaxQaPaperId = clsqa_PaperDA.GetMaxStrId();
 return strMaxQaPaperId;
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
 string strQaPaperId;
 try
 {
 strQaPaperId = new clsqa_PaperDA().GetFirstID(strWhereCond);
 return strQaPaperId;
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
 arrList = qa_PaperDA.GetID(strWhereCond);
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
bool bolIsExist = qa_PaperDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strQaPaperId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strQaPaperId)
{
if (string.IsNullOrEmpty(strQaPaperId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strQaPaperId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = qa_PaperDA.IsExist(strQaPaperId);
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
 bolIsExist = clsqa_PaperDA.IsExistTable();
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
 bolIsExist = qa_PaperDA.IsExistTable(strTabName);
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
 /// <param name = "objqa_PaperEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsqa_PaperEN objqa_PaperEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objqa_PaperEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!论文答疑Id = [{0}]的数据已经存在!(in clsqa_PaperBL.AddNewRecordBySql2)", objqa_PaperEN.QaPaperId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objqa_PaperEN.QaPaperId) == true || clsqa_PaperBL.IsExist(objqa_PaperEN.QaPaperId) == true)
 {
     objqa_PaperEN.QaPaperId = clsqa_PaperBL.GetMaxStrId_S();
 }
bool bolResult = qa_PaperDA.AddNewRecordBySQL2(objqa_PaperEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_PaperBL.ReFreshCache(objqa_PaperEN.IdCurrEduCls);

if (clsqa_PaperBL.relatedActions != null)
{
clsqa_PaperBL.relatedActions.UpdRelaTabDate(objqa_PaperEN.QaPaperId, "SetUpdDate");
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
 /// <param name = "objqa_PaperEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsqa_PaperEN objqa_PaperEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objqa_PaperEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!论文答疑Id = [{0}]的数据已经存在!(in clsqa_PaperBL.AddNewRecordBySql2WithReturnKey)", objqa_PaperEN.QaPaperId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objqa_PaperEN.QaPaperId) == true || clsqa_PaperBL.IsExist(objqa_PaperEN.QaPaperId) == true)
 {
     objqa_PaperEN.QaPaperId = clsqa_PaperBL.GetMaxStrId_S();
 }
string strKey = qa_PaperDA.AddNewRecordBySQL2WithReturnKey(objqa_PaperEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_PaperBL.ReFreshCache(objqa_PaperEN.IdCurrEduCls);

if (clsqa_PaperBL.relatedActions != null)
{
clsqa_PaperBL.relatedActions.UpdRelaTabDate(objqa_PaperEN.QaPaperId, "SetUpdDate");
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
 /// <param name = "objqa_PaperEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsqa_PaperEN objqa_PaperEN)
{
try
{
bool bolResult = qa_PaperDA.Update(objqa_PaperEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_PaperBL.ReFreshCache(objqa_PaperEN.IdCurrEduCls);

if (clsqa_PaperBL.relatedActions != null)
{
clsqa_PaperBL.relatedActions.UpdRelaTabDate(objqa_PaperEN.QaPaperId, "SetUpdDate");
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
 /// <param name = "objqa_PaperEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsqa_PaperEN objqa_PaperEN)
{
 if (string.IsNullOrEmpty(objqa_PaperEN.QaPaperId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = qa_PaperDA.UpdateBySql2(objqa_PaperEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_PaperBL.ReFreshCache(objqa_PaperEN.IdCurrEduCls);

if (clsqa_PaperBL.relatedActions != null)
{
clsqa_PaperBL.relatedActions.UpdRelaTabDate(objqa_PaperEN.QaPaperId, "SetUpdDate");
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
 /// <param name = "strQaPaperId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strQaPaperId)
{
try
{
 clsqa_PaperEN objqa_PaperEN = clsqa_PaperBL.GetObjByQaPaperId(strQaPaperId);

if (clsqa_PaperBL.relatedActions != null)
{
clsqa_PaperBL.relatedActions.UpdRelaTabDate(objqa_PaperEN.QaPaperId, "SetUpdDate");
}
if (objqa_PaperEN != null)
{
int intRecNum = qa_PaperDA.DelRecord(strQaPaperId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objqa_PaperEN.IdCurrEduCls);
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
/// <param name="strQaPaperId">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strQaPaperId , string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsqa_PaperDA.GetSpecSQLObj();
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
//删除与表:[qa_Paper]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conqa_Paper.QaPaperId,
//strQaPaperId);
//        clsqa_PaperBL.Delqa_PapersByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsqa_PaperBL.DelRecord(strQaPaperId, strIdCurrEduCls, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsqa_PaperBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strQaPaperId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strQaPaperId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strQaPaperId, string strIdCurrEduCls, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsqa_PaperBL.relatedActions != null)
{
clsqa_PaperBL.relatedActions.UpdRelaTabDate(strQaPaperId, "UpdRelaTabDate");
}
bool bolResult = qa_PaperDA.DelRecord(strQaPaperId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrQaPaperIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delqa_Papers(List<string> arrQaPaperIdLst)
{
if (arrQaPaperIdLst.Count == 0) return 0;
try
{
if (clsqa_PaperBL.relatedActions != null)
{
foreach (var strQaPaperId in arrQaPaperIdLst)
{
clsqa_PaperBL.relatedActions.UpdRelaTabDate(strQaPaperId, "UpdRelaTabDate");
}
}
 clsqa_PaperEN objqa_PaperEN = clsqa_PaperBL.GetObjByQaPaperId(arrQaPaperIdLst[0]);
int intDelRecNum = qa_PaperDA.Delqa_Paper(arrQaPaperIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objqa_PaperEN.IdCurrEduCls);
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
public static int Delqa_PapersByCond(string strWhereCond)
{
try
{
if (clsqa_PaperBL.relatedActions != null)
{
List<string> arrQaPaperId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strQaPaperId in arrQaPaperId)
{
clsqa_PaperBL.relatedActions.UpdRelaTabDate(strQaPaperId, "UpdRelaTabDate");
}
}
List<string> arrIdCurrEduCls = GetFldValue(conqa_Paper.IdCurrEduCls, strWhereCond);
int intRecNum = qa_PaperDA.Delqa_Paper(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[qa_Paper]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strQaPaperId">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strQaPaperId, string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsqa_PaperDA.GetSpecSQLObj();
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
//删除与表:[qa_Paper]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsqa_PaperBL.DelRecord(strQaPaperId, strIdCurrEduCls, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsqa_PaperBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strQaPaperId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objqa_PaperENS">源对象</param>
 /// <param name = "objqa_PaperENT">目标对象</param>
 public static void CopyTo(clsqa_PaperEN objqa_PaperENS, clsqa_PaperEN objqa_PaperENT)
{
try
{
objqa_PaperENT.QaPaperId = objqa_PaperENS.QaPaperId; //论文答疑Id
objqa_PaperENT.PaperId = objqa_PaperENS.PaperId; //论文Id
objqa_PaperENT.QuestionsCount = objqa_PaperENS.QuestionsCount; //提问计数
objqa_PaperENT.IsDelete = objqa_PaperENS.IsDelete; //是否删除
objqa_PaperENT.IsPublic = objqa_PaperENS.IsPublic; //是否公开
objqa_PaperENT.IsSubmit = objqa_PaperENS.IsSubmit; //是否提交
objqa_PaperENT.UpdUser = objqa_PaperENS.UpdUser; //修改人
objqa_PaperENT.UpdDate = objqa_PaperENS.UpdDate; //修改日期
objqa_PaperENT.Memo = objqa_PaperENS.Memo; //备注
objqa_PaperENT.IdCurrEduCls = objqa_PaperENS.IdCurrEduCls; //教学班流水号
objqa_PaperENT.AnswerCount = objqa_PaperENS.AnswerCount; //回答计数
objqa_PaperENT.ShareId = objqa_PaperENS.ShareId; //分享Id
objqa_PaperENT.TagsCount = objqa_PaperENS.TagsCount; //论文标注数
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
 /// <param name = "objqa_PaperEN">源简化对象</param>
 public static void SetUpdFlag(clsqa_PaperEN objqa_PaperEN)
{
try
{
objqa_PaperEN.ClearUpdateState();
   string strsfUpdFldSetStr = objqa_PaperEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conqa_Paper.QaPaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_PaperEN.QaPaperId = objqa_PaperEN.QaPaperId; //论文答疑Id
}
if (arrFldSet.Contains(conqa_Paper.PaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_PaperEN.PaperId = objqa_PaperEN.PaperId == "[null]" ? null :  objqa_PaperEN.PaperId; //论文Id
}
if (arrFldSet.Contains(conqa_Paper.QuestionsCount, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_PaperEN.QuestionsCount = objqa_PaperEN.QuestionsCount; //提问计数
}
if (arrFldSet.Contains(conqa_Paper.IsDelete, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_PaperEN.IsDelete = objqa_PaperEN.IsDelete; //是否删除
}
if (arrFldSet.Contains(conqa_Paper.IsPublic, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_PaperEN.IsPublic = objqa_PaperEN.IsPublic; //是否公开
}
if (arrFldSet.Contains(conqa_Paper.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_PaperEN.IsSubmit = objqa_PaperEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(conqa_Paper.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_PaperEN.UpdUser = objqa_PaperEN.UpdUser == "[null]" ? null :  objqa_PaperEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conqa_Paper.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_PaperEN.UpdDate = objqa_PaperEN.UpdDate == "[null]" ? null :  objqa_PaperEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conqa_Paper.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_PaperEN.Memo = objqa_PaperEN.Memo == "[null]" ? null :  objqa_PaperEN.Memo; //备注
}
if (arrFldSet.Contains(conqa_Paper.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_PaperEN.IdCurrEduCls = objqa_PaperEN.IdCurrEduCls == "[null]" ? null :  objqa_PaperEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conqa_Paper.AnswerCount, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_PaperEN.AnswerCount = objqa_PaperEN.AnswerCount; //回答计数
}
if (arrFldSet.Contains(conqa_Paper.ShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_PaperEN.ShareId = objqa_PaperEN.ShareId == "[null]" ? null :  objqa_PaperEN.ShareId; //分享Id
}
if (arrFldSet.Contains(conqa_Paper.TagsCount, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_PaperEN.TagsCount = objqa_PaperEN.TagsCount; //论文标注数
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
 /// <param name = "objqa_PaperEN">源简化对象</param>
 public static void AccessFldValueNull(clsqa_PaperEN objqa_PaperEN)
{
try
{
if (objqa_PaperEN.PaperId == "[null]") objqa_PaperEN.PaperId = null; //论文Id
if (objqa_PaperEN.UpdUser == "[null]") objqa_PaperEN.UpdUser = null; //修改人
if (objqa_PaperEN.UpdDate == "[null]") objqa_PaperEN.UpdDate = null; //修改日期
if (objqa_PaperEN.Memo == "[null]") objqa_PaperEN.Memo = null; //备注
if (objqa_PaperEN.IdCurrEduCls == "[null]") objqa_PaperEN.IdCurrEduCls = null; //教学班流水号
if (objqa_PaperEN.ShareId == "[null]") objqa_PaperEN.ShareId = null; //分享Id
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
public static void CheckPropertyNew(clsqa_PaperEN objqa_PaperEN)
{
 qa_PaperDA.CheckPropertyNew(objqa_PaperEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsqa_PaperEN objqa_PaperEN)
{
 qa_PaperDA.CheckProperty4Condition(objqa_PaperEN);
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
if (clsqa_PaperBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsqa_PaperBL没有刷新缓存机制(clsqa_PaperBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by QaPaperId");
//if (arrqa_PaperObjLstCache == null)
//{
//arrqa_PaperObjLstCache = qa_PaperDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strQaPaperId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsqa_PaperEN GetObjByQaPaperIdCache(string strQaPaperId, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsqa_PaperEN._CurrTabName, strIdCurrEduCls);
List<clsqa_PaperEN> arrqa_PaperObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsqa_PaperEN> arrqa_PaperObjLst_Sel =
arrqa_PaperObjLstCache
.Where(x=> x.QaPaperId == strQaPaperId 
);
if (arrqa_PaperObjLst_Sel.Count() == 0)
{
   clsqa_PaperEN obj = clsqa_PaperBL.GetObjByQaPaperId(strQaPaperId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strQaPaperId, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrqa_PaperObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsqa_PaperEN> GetAllqa_PaperObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsqa_PaperEN> arrqa_PaperObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrqa_PaperObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsqa_PaperEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsqa_PaperEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsqa_PaperEN> arrqa_PaperObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrqa_PaperObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsqa_PaperEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clsqa_PaperEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsqa_PaperEN._RefreshTimeLst.Count == 0) return "";
return clsqa_PaperEN._RefreshTimeLst[clsqa_PaperEN._RefreshTimeLst.Count - 1];
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
if (clsqa_PaperBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsqa_PaperEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clsqa_PaperEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsqa_PaperBL.objCommFun4BL.ReFreshCache(strIdCurrEduCls);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--qa_Paper(论文答疑表)
 /// 唯一性条件:qa_PaperId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objqa_PaperEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsqa_PaperEN objqa_PaperEN)
{
//检测记录是否存在
string strResult = qa_PaperDA.GetUniCondStr(objqa_PaperEN);
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
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strQaPaperId, string strIdCurrEduCls)
{
if (strInFldName != conqa_Paper.QaPaperId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conqa_Paper.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conqa_Paper.AttributeName));
throw new Exception(strMsg);
}
var objqa_Paper = clsqa_PaperBL.GetObjByQaPaperIdCache(strQaPaperId, strIdCurrEduCls);
if (objqa_Paper == null) return "";
return objqa_Paper[strOutFldName].ToString();
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
int intRecCount = clsqa_PaperDA.GetRecCount(strTabName);
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
int intRecCount = clsqa_PaperDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsqa_PaperDA.GetRecCount();
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
int intRecCount = clsqa_PaperDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objqa_PaperCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsqa_PaperEN objqa_PaperCond)
{
 string strIdCurrEduCls = objqa_PaperCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsqa_PaperBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsqa_PaperEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsqa_PaperEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conqa_Paper.AttributeName)
{
if (objqa_PaperCond.IsUpdated(strFldName) == false) continue;
if (objqa_PaperCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objqa_PaperCond[strFldName].ToString());
}
else
{
if (objqa_PaperCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objqa_PaperCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objqa_PaperCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objqa_PaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objqa_PaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objqa_PaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objqa_PaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objqa_PaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objqa_PaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objqa_PaperCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objqa_PaperCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objqa_PaperCond[strFldName]));
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
 List<string> arrList = clsqa_PaperDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = qa_PaperDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = qa_PaperDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = qa_PaperDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsqa_PaperDA.SetFldValue(clsqa_PaperEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = qa_PaperDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsqa_PaperDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsqa_PaperDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsqa_PaperDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[qa_Paper] "); 
 strCreateTabCode.Append(" ( "); 
 // /**论文答疑Id*/ 
 strCreateTabCode.Append(" QaPaperId char(8) primary key, "); 
 // /**论文Id*/ 
 strCreateTabCode.Append(" PaperId char(8) Null, "); 
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
 strCreateTabCode.Append(" ShareId char(2) Null, "); 
 // /**论文标注数*/ 
 strCreateTabCode.Append(" TagsCount int Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 论文答疑表(qa_Paper)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4qa_Paper : clsCommFun4BLV2
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
clsqa_PaperBL.ReFreshThisCache(strIdCurrEduCls);
}
}

}