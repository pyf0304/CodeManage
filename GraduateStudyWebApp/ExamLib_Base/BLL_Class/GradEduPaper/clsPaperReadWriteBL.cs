
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPaperReadWriteBL
 表名:PaperReadWrite(01120547)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:14:45
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
public static class  clsPaperReadWriteBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strPaperRWId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPaperReadWriteEN GetObj(this K_PaperRWId_PaperReadWrite myKey)
{
clsPaperReadWriteEN objPaperReadWriteEN = clsPaperReadWriteBL.PaperReadWriteDA.GetObjByPaperRWId(myKey.Value);
return objPaperReadWriteEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objPaperReadWriteEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsPaperReadWriteEN objPaperReadWriteEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objPaperReadWriteEN) == false)
{
var strMsg = string.Format("记录已经存在!阅读者Id = [{0}],论文Id = [{1}]的数据已经存在!(in clsPaperReadWriteBL.AddNewRecord)", objPaperReadWriteEN.ReaderId,objPaperReadWriteEN.PaperId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objPaperReadWriteEN.PaperRWId) == true || clsPaperReadWriteBL.IsExist(objPaperReadWriteEN.PaperRWId) == true)
 {
     objPaperReadWriteEN.PaperRWId = clsPaperReadWriteBL.GetMaxStrId_S();
 }
bool bolResult = clsPaperReadWriteBL.PaperReadWriteDA.AddNewRecordBySQL2(objPaperReadWriteEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperReadWriteBL.ReFreshCache(objPaperReadWriteEN.IdCurrEduCls);

if (clsPaperReadWriteBL.relatedActions != null)
{
clsPaperReadWriteBL.relatedActions.UpdRelaTabDate(objPaperReadWriteEN.PaperRWId, "SetUpdDate");
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
public static bool AddRecordEx(this clsPaperReadWriteEN objPaperReadWriteEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsPaperReadWriteBL.IsExist(objPaperReadWriteEN.PaperRWId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objPaperReadWriteEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objPaperReadWriteEN.CheckUniqueness() == false)
{
strMsg = string.Format("(阅读者Id(ReaderId)=[{0}],论文Id(PaperId)=[{1}])已经存在,不能重复!", objPaperReadWriteEN.ReaderId, objPaperReadWriteEN.PaperId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objPaperReadWriteEN.PaperRWId) == true || clsPaperReadWriteBL.IsExist(objPaperReadWriteEN.PaperRWId) == true)
 {
     objPaperReadWriteEN.PaperRWId = clsPaperReadWriteBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objPaperReadWriteEN.AddNewRecord();
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
 /// <param name = "objPaperReadWriteEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsPaperReadWriteEN objPaperReadWriteEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objPaperReadWriteEN) == false)
{
var strMsg = string.Format("记录已经存在!阅读者Id = [{0}],论文Id = [{1}]的数据已经存在!(in clsPaperReadWriteBL.AddNewRecordWithMaxId)", objPaperReadWriteEN.ReaderId,objPaperReadWriteEN.PaperId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objPaperReadWriteEN.PaperRWId) == true || clsPaperReadWriteBL.IsExist(objPaperReadWriteEN.PaperRWId) == true)
 {
     objPaperReadWriteEN.PaperRWId = clsPaperReadWriteBL.GetMaxStrId_S();
 }
string strPaperRWId = clsPaperReadWriteBL.PaperReadWriteDA.AddNewRecordBySQL2WithReturnKey(objPaperReadWriteEN);
     objPaperReadWriteEN.PaperRWId = strPaperRWId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperReadWriteBL.ReFreshCache(objPaperReadWriteEN.IdCurrEduCls);

if (clsPaperReadWriteBL.relatedActions != null)
{
clsPaperReadWriteBL.relatedActions.UpdRelaTabDate(objPaperReadWriteEN.PaperRWId, "SetUpdDate");
}
return strPaperRWId;
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
 /// <param name = "objPaperReadWriteEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsPaperReadWriteEN objPaperReadWriteEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objPaperReadWriteEN) == false)
{
var strMsg = string.Format("记录已经存在!阅读者Id = [{0}],论文Id = [{1}]的数据已经存在!(in clsPaperReadWriteBL.AddNewRecordWithReturnKey)", objPaperReadWriteEN.ReaderId,objPaperReadWriteEN.PaperId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objPaperReadWriteEN.PaperRWId) == true || clsPaperReadWriteBL.IsExist(objPaperReadWriteEN.PaperRWId) == true)
 {
     objPaperReadWriteEN.PaperRWId = clsPaperReadWriteBL.GetMaxStrId_S();
 }
string strKey = clsPaperReadWriteBL.PaperReadWriteDA.AddNewRecordBySQL2WithReturnKey(objPaperReadWriteEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperReadWriteBL.ReFreshCache(objPaperReadWriteEN.IdCurrEduCls);

if (clsPaperReadWriteBL.relatedActions != null)
{
clsPaperReadWriteBL.relatedActions.UpdRelaTabDate(objPaperReadWriteEN.PaperRWId, "SetUpdDate");
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
 /// <param name = "objPaperReadWriteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperReadWriteEN SetPaperRWId(this clsPaperReadWriteEN objPaperReadWriteEN, string strPaperRWId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperRWId, 8, conPaperReadWrite.PaperRWId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperRWId, 8, conPaperReadWrite.PaperRWId);
}
objPaperReadWriteEN.PaperRWId = strPaperRWId; //课文阅读
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperReadWriteEN.dicFldComparisonOp.ContainsKey(conPaperReadWrite.PaperRWId) == false)
{
objPaperReadWriteEN.dicFldComparisonOp.Add(conPaperReadWrite.PaperRWId, strComparisonOp);
}
else
{
objPaperReadWriteEN.dicFldComparisonOp[conPaperReadWrite.PaperRWId] = strComparisonOp;
}
}
return objPaperReadWriteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperReadWriteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperReadWriteEN SetReaderId(this clsPaperReadWriteEN objPaperReadWriteEN, string strReaderId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReaderId, 20, conPaperReadWrite.ReaderId);
}
objPaperReadWriteEN.ReaderId = strReaderId; //阅读者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperReadWriteEN.dicFldComparisonOp.ContainsKey(conPaperReadWrite.ReaderId) == false)
{
objPaperReadWriteEN.dicFldComparisonOp.Add(conPaperReadWrite.ReaderId, strComparisonOp);
}
else
{
objPaperReadWriteEN.dicFldComparisonOp[conPaperReadWrite.ReaderId] = strComparisonOp;
}
}
return objPaperReadWriteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperReadWriteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperReadWriteEN SetPaperId(this clsPaperReadWriteEN objPaperReadWriteEN, string strPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperId, 8, conPaperReadWrite.PaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, conPaperReadWrite.PaperId);
}
objPaperReadWriteEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperReadWriteEN.dicFldComparisonOp.ContainsKey(conPaperReadWrite.PaperId) == false)
{
objPaperReadWriteEN.dicFldComparisonOp.Add(conPaperReadWrite.PaperId, strComparisonOp);
}
else
{
objPaperReadWriteEN.dicFldComparisonOp[conPaperReadWrite.PaperId] = strComparisonOp;
}
}
return objPaperReadWriteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperReadWriteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperReadWriteEN SetResearchQuestion(this clsPaperReadWriteEN objPaperReadWriteEN, string strResearchQuestion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResearchQuestion, 2000, conPaperReadWrite.ResearchQuestion);
}
objPaperReadWriteEN.ResearchQuestion = strResearchQuestion; //研究问题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperReadWriteEN.dicFldComparisonOp.ContainsKey(conPaperReadWrite.ResearchQuestion) == false)
{
objPaperReadWriteEN.dicFldComparisonOp.Add(conPaperReadWrite.ResearchQuestion, strComparisonOp);
}
else
{
objPaperReadWriteEN.dicFldComparisonOp[conPaperReadWrite.ResearchQuestion] = strComparisonOp;
}
}
return objPaperReadWriteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperReadWriteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperReadWriteEN SetOperationTypeId(this clsPaperReadWriteEN objPaperReadWriteEN, string strOperationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOperationTypeId, conPaperReadWrite.OperationTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOperationTypeId, 4, conPaperReadWrite.OperationTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strOperationTypeId, 4, conPaperReadWrite.OperationTypeId);
}
objPaperReadWriteEN.OperationTypeId = strOperationTypeId; //操作类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperReadWriteEN.dicFldComparisonOp.ContainsKey(conPaperReadWrite.OperationTypeId) == false)
{
objPaperReadWriteEN.dicFldComparisonOp.Add(conPaperReadWrite.OperationTypeId, strComparisonOp);
}
else
{
objPaperReadWriteEN.dicFldComparisonOp[conPaperReadWrite.OperationTypeId] = strComparisonOp;
}
}
return objPaperReadWriteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperReadWriteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperReadWriteEN SetUpdDate(this clsPaperReadWriteEN objPaperReadWriteEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conPaperReadWrite.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conPaperReadWrite.UpdDate);
}
objPaperReadWriteEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperReadWriteEN.dicFldComparisonOp.ContainsKey(conPaperReadWrite.UpdDate) == false)
{
objPaperReadWriteEN.dicFldComparisonOp.Add(conPaperReadWrite.UpdDate, strComparisonOp);
}
else
{
objPaperReadWriteEN.dicFldComparisonOp[conPaperReadWrite.UpdDate] = strComparisonOp;
}
}
return objPaperReadWriteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperReadWriteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperReadWriteEN SetMemo(this clsPaperReadWriteEN objPaperReadWriteEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conPaperReadWrite.Memo);
}
objPaperReadWriteEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperReadWriteEN.dicFldComparisonOp.ContainsKey(conPaperReadWrite.Memo) == false)
{
objPaperReadWriteEN.dicFldComparisonOp.Add(conPaperReadWrite.Memo, strComparisonOp);
}
else
{
objPaperReadWriteEN.dicFldComparisonOp[conPaperReadWrite.Memo] = strComparisonOp;
}
}
return objPaperReadWriteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperReadWriteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperReadWriteEN SetIsSubmit(this clsPaperReadWriteEN objPaperReadWriteEN, bool bolIsSubmit, string strComparisonOp="")
	{
objPaperReadWriteEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperReadWriteEN.dicFldComparisonOp.ContainsKey(conPaperReadWrite.IsSubmit) == false)
{
objPaperReadWriteEN.dicFldComparisonOp.Add(conPaperReadWrite.IsSubmit, strComparisonOp);
}
else
{
objPaperReadWriteEN.dicFldComparisonOp[conPaperReadWrite.IsSubmit] = strComparisonOp;
}
}
return objPaperReadWriteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperReadWriteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperReadWriteEN SetIsPublic(this clsPaperReadWriteEN objPaperReadWriteEN, bool bolIsPublic, string strComparisonOp="")
	{
objPaperReadWriteEN.IsPublic = bolIsPublic; //是否公开
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperReadWriteEN.dicFldComparisonOp.ContainsKey(conPaperReadWrite.IsPublic) == false)
{
objPaperReadWriteEN.dicFldComparisonOp.Add(conPaperReadWrite.IsPublic, strComparisonOp);
}
else
{
objPaperReadWriteEN.dicFldComparisonOp[conPaperReadWrite.IsPublic] = strComparisonOp;
}
}
return objPaperReadWriteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperReadWriteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperReadWriteEN SetSubmitter(this clsPaperReadWriteEN objPaperReadWriteEN, string strSubmitter, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSubmitter, 50, conPaperReadWrite.Submitter);
}
objPaperReadWriteEN.Submitter = strSubmitter; //提交人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperReadWriteEN.dicFldComparisonOp.ContainsKey(conPaperReadWrite.Submitter) == false)
{
objPaperReadWriteEN.dicFldComparisonOp.Add(conPaperReadWrite.Submitter, strComparisonOp);
}
else
{
objPaperReadWriteEN.dicFldComparisonOp[conPaperReadWrite.Submitter] = strComparisonOp;
}
}
return objPaperReadWriteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperReadWriteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperReadWriteEN SetIdCurrEduCls(this clsPaperReadWriteEN objPaperReadWriteEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conPaperReadWrite.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conPaperReadWrite.IdCurrEduCls);
}
objPaperReadWriteEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperReadWriteEN.dicFldComparisonOp.ContainsKey(conPaperReadWrite.IdCurrEduCls) == false)
{
objPaperReadWriteEN.dicFldComparisonOp.Add(conPaperReadWrite.IdCurrEduCls, strComparisonOp);
}
else
{
objPaperReadWriteEN.dicFldComparisonOp[conPaperReadWrite.IdCurrEduCls] = strComparisonOp;
}
}
return objPaperReadWriteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperReadWriteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperReadWriteEN SetSubVCount(this clsPaperReadWriteEN objPaperReadWriteEN, int? intSubVCount, string strComparisonOp="")
	{
objPaperReadWriteEN.SubVCount = intSubVCount; //论文子观点数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperReadWriteEN.dicFldComparisonOp.ContainsKey(conPaperReadWrite.SubVCount) == false)
{
objPaperReadWriteEN.dicFldComparisonOp.Add(conPaperReadWrite.SubVCount, strComparisonOp);
}
else
{
objPaperReadWriteEN.dicFldComparisonOp[conPaperReadWrite.SubVCount] = strComparisonOp;
}
}
return objPaperReadWriteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperReadWriteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperReadWriteEN SetTeaCount(this clsPaperReadWriteEN objPaperReadWriteEN, int? intTeaCount, string strComparisonOp="")
	{
objPaperReadWriteEN.TeaCount = intTeaCount; //TeaCount
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperReadWriteEN.dicFldComparisonOp.ContainsKey(conPaperReadWrite.TeaCount) == false)
{
objPaperReadWriteEN.dicFldComparisonOp.Add(conPaperReadWrite.TeaCount, strComparisonOp);
}
else
{
objPaperReadWriteEN.dicFldComparisonOp[conPaperReadWrite.TeaCount] = strComparisonOp;
}
}
return objPaperReadWriteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperReadWriteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperReadWriteEN SetCreateDate(this clsPaperReadWriteEN objPaperReadWriteEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, conPaperReadWrite.CreateDate);
}
objPaperReadWriteEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperReadWriteEN.dicFldComparisonOp.ContainsKey(conPaperReadWrite.CreateDate) == false)
{
objPaperReadWriteEN.dicFldComparisonOp.Add(conPaperReadWrite.CreateDate, strComparisonOp);
}
else
{
objPaperReadWriteEN.dicFldComparisonOp[conPaperReadWrite.CreateDate] = strComparisonOp;
}
}
return objPaperReadWriteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperReadWriteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperReadWriteEN SetShareId(this clsPaperReadWriteEN objPaperReadWriteEN, string strShareId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strShareId, 2, conPaperReadWrite.ShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strShareId, 2, conPaperReadWrite.ShareId);
}
objPaperReadWriteEN.ShareId = strShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperReadWriteEN.dicFldComparisonOp.ContainsKey(conPaperReadWrite.ShareId) == false)
{
objPaperReadWriteEN.dicFldComparisonOp.Add(conPaperReadWrite.ShareId, strComparisonOp);
}
else
{
objPaperReadWriteEN.dicFldComparisonOp[conPaperReadWrite.ShareId] = strComparisonOp;
}
}
return objPaperReadWriteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperReadWriteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperReadWriteEN SetUpdUser(this clsPaperReadWriteEN objPaperReadWriteEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conPaperReadWrite.UpdUser);
}
objPaperReadWriteEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperReadWriteEN.dicFldComparisonOp.ContainsKey(conPaperReadWrite.UpdUser) == false)
{
objPaperReadWriteEN.dicFldComparisonOp.Add(conPaperReadWrite.UpdUser, strComparisonOp);
}
else
{
objPaperReadWriteEN.dicFldComparisonOp[conPaperReadWrite.UpdUser] = strComparisonOp;
}
}
return objPaperReadWriteEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objPaperReadWriteEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsPaperReadWriteEN objPaperReadWriteEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objPaperReadWriteEN.CheckPropertyNew();
clsPaperReadWriteEN objPaperReadWriteCond = new clsPaperReadWriteEN();
string strCondition = objPaperReadWriteCond
.SetPaperRWId(objPaperReadWriteEN.PaperRWId, "<>")
.SetReaderId(objPaperReadWriteEN.ReaderId, "=")
.SetPaperId(objPaperReadWriteEN.PaperId, "=")
.GetCombineCondition();
objPaperReadWriteEN._IsCheckProperty = true;
bool bolIsExist = clsPaperReadWriteBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(ReaderId_PaperId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objPaperReadWriteEN.Update();
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
 /// <param name = "objPaperReadWrite">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsPaperReadWriteEN objPaperReadWrite)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsPaperReadWriteEN objPaperReadWriteCond = new clsPaperReadWriteEN();
string strCondition = objPaperReadWriteCond
.SetReaderId(objPaperReadWrite.ReaderId, "=")
.SetPaperId(objPaperReadWrite.PaperId, "=")
.GetCombineCondition();
objPaperReadWrite._IsCheckProperty = true;
bool bolIsExist = clsPaperReadWriteBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objPaperReadWrite.PaperRWId = clsPaperReadWriteBL.GetFirstID_S(strCondition);
objPaperReadWrite.UpdateWithCondition(strCondition);
}
else
{
objPaperReadWrite.PaperRWId = clsPaperReadWriteBL.GetMaxStrId_S();
objPaperReadWrite.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objPaperReadWriteEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPaperReadWriteEN objPaperReadWriteEN)
{
 if (string.IsNullOrEmpty(objPaperReadWriteEN.PaperRWId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPaperReadWriteBL.PaperReadWriteDA.UpdateBySql2(objPaperReadWriteEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperReadWriteBL.ReFreshCache(objPaperReadWriteEN.IdCurrEduCls);

if (clsPaperReadWriteBL.relatedActions != null)
{
clsPaperReadWriteBL.relatedActions.UpdRelaTabDate(objPaperReadWriteEN.PaperRWId, "SetUpdDate");
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
 /// <param name = "objPaperReadWriteEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPaperReadWriteEN objPaperReadWriteEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objPaperReadWriteEN.PaperRWId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPaperReadWriteBL.PaperReadWriteDA.UpdateBySql2(objPaperReadWriteEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperReadWriteBL.ReFreshCache(objPaperReadWriteEN.IdCurrEduCls);

if (clsPaperReadWriteBL.relatedActions != null)
{
clsPaperReadWriteBL.relatedActions.UpdRelaTabDate(objPaperReadWriteEN.PaperRWId, "SetUpdDate");
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
 /// <param name = "objPaperReadWriteEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPaperReadWriteEN objPaperReadWriteEN, string strWhereCond)
{
try
{
bool bolResult = clsPaperReadWriteBL.PaperReadWriteDA.UpdateBySqlWithCondition(objPaperReadWriteEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperReadWriteBL.ReFreshCache(objPaperReadWriteEN.IdCurrEduCls);

if (clsPaperReadWriteBL.relatedActions != null)
{
clsPaperReadWriteBL.relatedActions.UpdRelaTabDate(objPaperReadWriteEN.PaperRWId, "SetUpdDate");
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
 /// <param name = "objPaperReadWriteEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPaperReadWriteEN objPaperReadWriteEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsPaperReadWriteBL.PaperReadWriteDA.UpdateBySqlWithConditionTransaction(objPaperReadWriteEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperReadWriteBL.ReFreshCache(objPaperReadWriteEN.IdCurrEduCls);

if (clsPaperReadWriteBL.relatedActions != null)
{
clsPaperReadWriteBL.relatedActions.UpdRelaTabDate(objPaperReadWriteEN.PaperRWId, "SetUpdDate");
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
 /// <param name = "strPaperRWId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsPaperReadWriteEN objPaperReadWriteEN)
{
try
{
int intRecNum = clsPaperReadWriteBL.PaperReadWriteDA.DelRecord(objPaperReadWriteEN.PaperRWId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperReadWriteBL.ReFreshCache(objPaperReadWriteEN.IdCurrEduCls);

if (clsPaperReadWriteBL.relatedActions != null)
{
clsPaperReadWriteBL.relatedActions.UpdRelaTabDate(objPaperReadWriteEN.PaperRWId, "SetUpdDate");
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
 /// <param name = "objPaperReadWriteENS">源对象</param>
 /// <param name = "objPaperReadWriteENT">目标对象</param>
 public static void CopyTo(this clsPaperReadWriteEN objPaperReadWriteENS, clsPaperReadWriteEN objPaperReadWriteENT)
{
try
{
objPaperReadWriteENT.PaperRWId = objPaperReadWriteENS.PaperRWId; //课文阅读
objPaperReadWriteENT.ReaderId = objPaperReadWriteENS.ReaderId; //阅读者Id
objPaperReadWriteENT.PaperId = objPaperReadWriteENS.PaperId; //论文Id
objPaperReadWriteENT.ResearchQuestion = objPaperReadWriteENS.ResearchQuestion; //研究问题
objPaperReadWriteENT.OperationTypeId = objPaperReadWriteENS.OperationTypeId; //操作类型ID
objPaperReadWriteENT.UpdDate = objPaperReadWriteENS.UpdDate; //修改日期
objPaperReadWriteENT.Memo = objPaperReadWriteENS.Memo; //备注
objPaperReadWriteENT.IsSubmit = objPaperReadWriteENS.IsSubmit; //是否提交
objPaperReadWriteENT.IsPublic = objPaperReadWriteENS.IsPublic; //是否公开
objPaperReadWriteENT.Submitter = objPaperReadWriteENS.Submitter; //提交人
objPaperReadWriteENT.IdCurrEduCls = objPaperReadWriteENS.IdCurrEduCls; //教学班流水号
objPaperReadWriteENT.SubVCount = objPaperReadWriteENS.SubVCount; //论文子观点数
objPaperReadWriteENT.TeaCount = objPaperReadWriteENS.TeaCount; //TeaCount
objPaperReadWriteENT.CreateDate = objPaperReadWriteENS.CreateDate; //建立日期
objPaperReadWriteENT.ShareId = objPaperReadWriteENS.ShareId; //分享Id
objPaperReadWriteENT.UpdUser = objPaperReadWriteENS.UpdUser; //修改人
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
 /// <param name = "objPaperReadWriteENS">源对象</param>
 /// <returns>目标对象=>clsPaperReadWriteEN:objPaperReadWriteENT</returns>
 public static clsPaperReadWriteEN CopyTo(this clsPaperReadWriteEN objPaperReadWriteENS)
{
try
{
 clsPaperReadWriteEN objPaperReadWriteENT = new clsPaperReadWriteEN()
{
PaperRWId = objPaperReadWriteENS.PaperRWId, //课文阅读
ReaderId = objPaperReadWriteENS.ReaderId, //阅读者Id
PaperId = objPaperReadWriteENS.PaperId, //论文Id
ResearchQuestion = objPaperReadWriteENS.ResearchQuestion, //研究问题
OperationTypeId = objPaperReadWriteENS.OperationTypeId, //操作类型ID
UpdDate = objPaperReadWriteENS.UpdDate, //修改日期
Memo = objPaperReadWriteENS.Memo, //备注
IsSubmit = objPaperReadWriteENS.IsSubmit, //是否提交
IsPublic = objPaperReadWriteENS.IsPublic, //是否公开
Submitter = objPaperReadWriteENS.Submitter, //提交人
IdCurrEduCls = objPaperReadWriteENS.IdCurrEduCls, //教学班流水号
SubVCount = objPaperReadWriteENS.SubVCount, //论文子观点数
TeaCount = objPaperReadWriteENS.TeaCount, //TeaCount
CreateDate = objPaperReadWriteENS.CreateDate, //建立日期
ShareId = objPaperReadWriteENS.ShareId, //分享Id
UpdUser = objPaperReadWriteENS.UpdUser, //修改人
};
 return objPaperReadWriteENT;
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
public static void CheckPropertyNew(this clsPaperReadWriteEN objPaperReadWriteEN)
{
 clsPaperReadWriteBL.PaperReadWriteDA.CheckPropertyNew(objPaperReadWriteEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsPaperReadWriteEN objPaperReadWriteEN)
{
 clsPaperReadWriteBL.PaperReadWriteDA.CheckProperty4Condition(objPaperReadWriteEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsPaperReadWriteEN objPaperReadWriteCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objPaperReadWriteCond.IsUpdated(conPaperReadWrite.PaperRWId) == true)
{
string strComparisonOpPaperRWId = objPaperReadWriteCond.dicFldComparisonOp[conPaperReadWrite.PaperRWId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperReadWrite.PaperRWId, objPaperReadWriteCond.PaperRWId, strComparisonOpPaperRWId);
}
if (objPaperReadWriteCond.IsUpdated(conPaperReadWrite.ReaderId) == true)
{
string strComparisonOpReaderId = objPaperReadWriteCond.dicFldComparisonOp[conPaperReadWrite.ReaderId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperReadWrite.ReaderId, objPaperReadWriteCond.ReaderId, strComparisonOpReaderId);
}
if (objPaperReadWriteCond.IsUpdated(conPaperReadWrite.PaperId) == true)
{
string strComparisonOpPaperId = objPaperReadWriteCond.dicFldComparisonOp[conPaperReadWrite.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperReadWrite.PaperId, objPaperReadWriteCond.PaperId, strComparisonOpPaperId);
}
if (objPaperReadWriteCond.IsUpdated(conPaperReadWrite.ResearchQuestion) == true)
{
string strComparisonOpResearchQuestion = objPaperReadWriteCond.dicFldComparisonOp[conPaperReadWrite.ResearchQuestion];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperReadWrite.ResearchQuestion, objPaperReadWriteCond.ResearchQuestion, strComparisonOpResearchQuestion);
}
if (objPaperReadWriteCond.IsUpdated(conPaperReadWrite.OperationTypeId) == true)
{
string strComparisonOpOperationTypeId = objPaperReadWriteCond.dicFldComparisonOp[conPaperReadWrite.OperationTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperReadWrite.OperationTypeId, objPaperReadWriteCond.OperationTypeId, strComparisonOpOperationTypeId);
}
if (objPaperReadWriteCond.IsUpdated(conPaperReadWrite.UpdDate) == true)
{
string strComparisonOpUpdDate = objPaperReadWriteCond.dicFldComparisonOp[conPaperReadWrite.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperReadWrite.UpdDate, objPaperReadWriteCond.UpdDate, strComparisonOpUpdDate);
}
if (objPaperReadWriteCond.IsUpdated(conPaperReadWrite.Memo) == true)
{
string strComparisonOpMemo = objPaperReadWriteCond.dicFldComparisonOp[conPaperReadWrite.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperReadWrite.Memo, objPaperReadWriteCond.Memo, strComparisonOpMemo);
}
if (objPaperReadWriteCond.IsUpdated(conPaperReadWrite.IsSubmit) == true)
{
if (objPaperReadWriteCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPaperReadWrite.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPaperReadWrite.IsSubmit);
}
}
if (objPaperReadWriteCond.IsUpdated(conPaperReadWrite.IsPublic) == true)
{
if (objPaperReadWriteCond.IsPublic == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPaperReadWrite.IsPublic);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPaperReadWrite.IsPublic);
}
}
if (objPaperReadWriteCond.IsUpdated(conPaperReadWrite.Submitter) == true)
{
string strComparisonOpSubmitter = objPaperReadWriteCond.dicFldComparisonOp[conPaperReadWrite.Submitter];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperReadWrite.Submitter, objPaperReadWriteCond.Submitter, strComparisonOpSubmitter);
}
if (objPaperReadWriteCond.IsUpdated(conPaperReadWrite.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objPaperReadWriteCond.dicFldComparisonOp[conPaperReadWrite.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperReadWrite.IdCurrEduCls, objPaperReadWriteCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objPaperReadWriteCond.IsUpdated(conPaperReadWrite.SubVCount) == true)
{
string strComparisonOpSubVCount = objPaperReadWriteCond.dicFldComparisonOp[conPaperReadWrite.SubVCount];
strWhereCond += string.Format(" And {0} {2} {1}", conPaperReadWrite.SubVCount, objPaperReadWriteCond.SubVCount, strComparisonOpSubVCount);
}
if (objPaperReadWriteCond.IsUpdated(conPaperReadWrite.TeaCount) == true)
{
string strComparisonOpTeaCount = objPaperReadWriteCond.dicFldComparisonOp[conPaperReadWrite.TeaCount];
strWhereCond += string.Format(" And {0} {2} {1}", conPaperReadWrite.TeaCount, objPaperReadWriteCond.TeaCount, strComparisonOpTeaCount);
}
if (objPaperReadWriteCond.IsUpdated(conPaperReadWrite.CreateDate) == true)
{
string strComparisonOpCreateDate = objPaperReadWriteCond.dicFldComparisonOp[conPaperReadWrite.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperReadWrite.CreateDate, objPaperReadWriteCond.CreateDate, strComparisonOpCreateDate);
}
if (objPaperReadWriteCond.IsUpdated(conPaperReadWrite.ShareId) == true)
{
string strComparisonOpShareId = objPaperReadWriteCond.dicFldComparisonOp[conPaperReadWrite.ShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperReadWrite.ShareId, objPaperReadWriteCond.ShareId, strComparisonOpShareId);
}
if (objPaperReadWriteCond.IsUpdated(conPaperReadWrite.UpdUser) == true)
{
string strComparisonOpUpdUser = objPaperReadWriteCond.dicFldComparisonOp[conPaperReadWrite.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperReadWrite.UpdUser, objPaperReadWriteCond.UpdUser, strComparisonOpUpdUser);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--PaperReadWrite(论文读写表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:ReaderId_PaperId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objPaperReadWriteEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsPaperReadWriteEN objPaperReadWriteEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objPaperReadWriteEN == null) return true;
if (objPaperReadWriteEN.PaperRWId == null || objPaperReadWriteEN.PaperRWId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objPaperReadWriteEN.ReaderId == null)
{
 sbCondition.AppendFormat(" and ReaderId is null", objPaperReadWriteEN.ReaderId);
}
else
{
 sbCondition.AppendFormat(" and ReaderId = '{0}'", objPaperReadWriteEN.ReaderId);
}
 if (objPaperReadWriteEN.PaperId == null)
{
 sbCondition.AppendFormat(" and PaperId is null", objPaperReadWriteEN.PaperId);
}
else
{
 sbCondition.AppendFormat(" and PaperId = '{0}'", objPaperReadWriteEN.PaperId);
}
if (clsPaperReadWriteBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("PaperRWId !=  '{0}'", objPaperReadWriteEN.PaperRWId);
 sbCondition.AppendFormat(" and ReaderId = '{0}'", objPaperReadWriteEN.ReaderId);
 sbCondition.AppendFormat(" and PaperId = '{0}'", objPaperReadWriteEN.PaperId);
if (clsPaperReadWriteBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--PaperReadWrite(论文读写表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ReaderId_PaperId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objPaperReadWriteEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsPaperReadWriteEN objPaperReadWriteEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objPaperReadWriteEN == null) return "";
if (objPaperReadWriteEN.PaperRWId == null || objPaperReadWriteEN.PaperRWId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objPaperReadWriteEN.ReaderId == null)
{
 sbCondition.AppendFormat(" and ReaderId is null", objPaperReadWriteEN.ReaderId);
}
else
{
 sbCondition.AppendFormat(" and ReaderId = '{0}'", objPaperReadWriteEN.ReaderId);
}
 if (objPaperReadWriteEN.PaperId == null)
{
 sbCondition.AppendFormat(" and PaperId is null", objPaperReadWriteEN.PaperId);
}
else
{
 sbCondition.AppendFormat(" and PaperId = '{0}'", objPaperReadWriteEN.PaperId);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("PaperRWId !=  '{0}'", objPaperReadWriteEN.PaperRWId);
 sbCondition.AppendFormat(" and ReaderId = '{0}'", objPaperReadWriteEN.ReaderId);
 sbCondition.AppendFormat(" and PaperId = '{0}'", objPaperReadWriteEN.PaperId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_PaperReadWrite
{
public virtual bool UpdRelaTabDate(string strPaperRWId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 论文读写表(PaperReadWrite)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsPaperReadWriteBL
{
public static RelatedActions_PaperReadWrite relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsPaperReadWriteDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsPaperReadWriteDA PaperReadWriteDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsPaperReadWriteDA();
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
 public clsPaperReadWriteBL()
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
if (string.IsNullOrEmpty(clsPaperReadWriteEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsPaperReadWriteEN._ConnectString);
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
public static DataTable GetDataTable_PaperReadWrite(string strWhereCond)
{
DataTable objDT;
try
{
objDT = PaperReadWriteDA.GetDataTable_PaperReadWrite(strWhereCond);
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
objDT = PaperReadWriteDA.GetDataTable(strWhereCond);
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
objDT = PaperReadWriteDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = PaperReadWriteDA.GetDataTable(strWhereCond, strTabName);
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
objDT = PaperReadWriteDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = PaperReadWriteDA.GetDataTable_Top(objTopPara);
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
objDT = PaperReadWriteDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = PaperReadWriteDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = PaperReadWriteDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrPaperRWIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsPaperReadWriteEN> GetObjLstByPaperRWIdLst(List<string> arrPaperRWIdLst)
{
List<clsPaperReadWriteEN> arrObjLst = new List<clsPaperReadWriteEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrPaperRWIdLst, true);
 string strWhereCond = string.Format("PaperRWId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperReadWriteEN objPaperReadWriteEN = new clsPaperReadWriteEN();
try
{
objPaperReadWriteEN.PaperRWId = objRow[conPaperReadWrite.PaperRWId].ToString().Trim(); //课文阅读
objPaperReadWriteEN.ReaderId = objRow[conPaperReadWrite.ReaderId] == DBNull.Value ? null : objRow[conPaperReadWrite.ReaderId].ToString().Trim(); //阅读者Id
objPaperReadWriteEN.PaperId = objRow[conPaperReadWrite.PaperId] == DBNull.Value ? null : objRow[conPaperReadWrite.PaperId].ToString().Trim(); //论文Id
objPaperReadWriteEN.ResearchQuestion = objRow[conPaperReadWrite.ResearchQuestion] == DBNull.Value ? null : objRow[conPaperReadWrite.ResearchQuestion].ToString().Trim(); //研究问题
objPaperReadWriteEN.OperationTypeId = objRow[conPaperReadWrite.OperationTypeId].ToString().Trim(); //操作类型ID
objPaperReadWriteEN.UpdDate = objRow[conPaperReadWrite.UpdDate].ToString().Trim(); //修改日期
objPaperReadWriteEN.Memo = objRow[conPaperReadWrite.Memo] == DBNull.Value ? null : objRow[conPaperReadWrite.Memo].ToString().Trim(); //备注
objPaperReadWriteEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conPaperReadWrite.IsSubmit].ToString().Trim()); //是否提交
objPaperReadWriteEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conPaperReadWrite.IsPublic].ToString().Trim()); //是否公开
objPaperReadWriteEN.Submitter = objRow[conPaperReadWrite.Submitter] == DBNull.Value ? null : objRow[conPaperReadWrite.Submitter].ToString().Trim(); //提交人
objPaperReadWriteEN.IdCurrEduCls = objRow[conPaperReadWrite.IdCurrEduCls] == DBNull.Value ? null : objRow[conPaperReadWrite.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperReadWriteEN.SubVCount = objRow[conPaperReadWrite.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperReadWrite.SubVCount].ToString().Trim()); //论文子观点数
objPaperReadWriteEN.TeaCount = objRow[conPaperReadWrite.TeaCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperReadWrite.TeaCount].ToString().Trim()); //TeaCount
objPaperReadWriteEN.CreateDate = objRow[conPaperReadWrite.CreateDate] == DBNull.Value ? null : objRow[conPaperReadWrite.CreateDate].ToString().Trim(); //建立日期
objPaperReadWriteEN.ShareId = objRow[conPaperReadWrite.ShareId] == DBNull.Value ? null : objRow[conPaperReadWrite.ShareId].ToString().Trim(); //分享Id
objPaperReadWriteEN.UpdUser = objRow[conPaperReadWrite.UpdUser] == DBNull.Value ? null : objRow[conPaperReadWrite.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperReadWriteEN.PaperRWId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperReadWriteEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPaperRWIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsPaperReadWriteEN> GetObjLstByPaperRWIdLstCache(List<string> arrPaperRWIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsPaperReadWriteEN._CurrTabName, strIdCurrEduCls);
List<clsPaperReadWriteEN> arrPaperReadWriteObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsPaperReadWriteEN> arrPaperReadWriteObjLst_Sel =
arrPaperReadWriteObjLstCache
.Where(x => arrPaperRWIdLst.Contains(x.PaperRWId));
return arrPaperReadWriteObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsPaperReadWriteEN> GetObjLst(string strWhereCond)
{
List<clsPaperReadWriteEN> arrObjLst = new List<clsPaperReadWriteEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperReadWriteEN objPaperReadWriteEN = new clsPaperReadWriteEN();
try
{
objPaperReadWriteEN.PaperRWId = objRow[conPaperReadWrite.PaperRWId].ToString().Trim(); //课文阅读
objPaperReadWriteEN.ReaderId = objRow[conPaperReadWrite.ReaderId] == DBNull.Value ? null : objRow[conPaperReadWrite.ReaderId].ToString().Trim(); //阅读者Id
objPaperReadWriteEN.PaperId = objRow[conPaperReadWrite.PaperId] == DBNull.Value ? null : objRow[conPaperReadWrite.PaperId].ToString().Trim(); //论文Id
objPaperReadWriteEN.ResearchQuestion = objRow[conPaperReadWrite.ResearchQuestion] == DBNull.Value ? null : objRow[conPaperReadWrite.ResearchQuestion].ToString().Trim(); //研究问题
objPaperReadWriteEN.OperationTypeId = objRow[conPaperReadWrite.OperationTypeId].ToString().Trim(); //操作类型ID
objPaperReadWriteEN.UpdDate = objRow[conPaperReadWrite.UpdDate].ToString().Trim(); //修改日期
objPaperReadWriteEN.Memo = objRow[conPaperReadWrite.Memo] == DBNull.Value ? null : objRow[conPaperReadWrite.Memo].ToString().Trim(); //备注
objPaperReadWriteEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conPaperReadWrite.IsSubmit].ToString().Trim()); //是否提交
objPaperReadWriteEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conPaperReadWrite.IsPublic].ToString().Trim()); //是否公开
objPaperReadWriteEN.Submitter = objRow[conPaperReadWrite.Submitter] == DBNull.Value ? null : objRow[conPaperReadWrite.Submitter].ToString().Trim(); //提交人
objPaperReadWriteEN.IdCurrEduCls = objRow[conPaperReadWrite.IdCurrEduCls] == DBNull.Value ? null : objRow[conPaperReadWrite.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperReadWriteEN.SubVCount = objRow[conPaperReadWrite.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperReadWrite.SubVCount].ToString().Trim()); //论文子观点数
objPaperReadWriteEN.TeaCount = objRow[conPaperReadWrite.TeaCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperReadWrite.TeaCount].ToString().Trim()); //TeaCount
objPaperReadWriteEN.CreateDate = objRow[conPaperReadWrite.CreateDate] == DBNull.Value ? null : objRow[conPaperReadWrite.CreateDate].ToString().Trim(); //建立日期
objPaperReadWriteEN.ShareId = objRow[conPaperReadWrite.ShareId] == DBNull.Value ? null : objRow[conPaperReadWrite.ShareId].ToString().Trim(); //分享Id
objPaperReadWriteEN.UpdUser = objRow[conPaperReadWrite.UpdUser] == DBNull.Value ? null : objRow[conPaperReadWrite.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperReadWriteEN.PaperRWId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperReadWriteEN);
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
public static List<clsPaperReadWriteEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsPaperReadWriteEN> arrObjLst = new List<clsPaperReadWriteEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperReadWriteEN objPaperReadWriteEN = new clsPaperReadWriteEN();
try
{
objPaperReadWriteEN.PaperRWId = objRow[conPaperReadWrite.PaperRWId].ToString().Trim(); //课文阅读
objPaperReadWriteEN.ReaderId = objRow[conPaperReadWrite.ReaderId] == DBNull.Value ? null : objRow[conPaperReadWrite.ReaderId].ToString().Trim(); //阅读者Id
objPaperReadWriteEN.PaperId = objRow[conPaperReadWrite.PaperId] == DBNull.Value ? null : objRow[conPaperReadWrite.PaperId].ToString().Trim(); //论文Id
objPaperReadWriteEN.ResearchQuestion = objRow[conPaperReadWrite.ResearchQuestion] == DBNull.Value ? null : objRow[conPaperReadWrite.ResearchQuestion].ToString().Trim(); //研究问题
objPaperReadWriteEN.OperationTypeId = objRow[conPaperReadWrite.OperationTypeId].ToString().Trim(); //操作类型ID
objPaperReadWriteEN.UpdDate = objRow[conPaperReadWrite.UpdDate].ToString().Trim(); //修改日期
objPaperReadWriteEN.Memo = objRow[conPaperReadWrite.Memo] == DBNull.Value ? null : objRow[conPaperReadWrite.Memo].ToString().Trim(); //备注
objPaperReadWriteEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conPaperReadWrite.IsSubmit].ToString().Trim()); //是否提交
objPaperReadWriteEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conPaperReadWrite.IsPublic].ToString().Trim()); //是否公开
objPaperReadWriteEN.Submitter = objRow[conPaperReadWrite.Submitter] == DBNull.Value ? null : objRow[conPaperReadWrite.Submitter].ToString().Trim(); //提交人
objPaperReadWriteEN.IdCurrEduCls = objRow[conPaperReadWrite.IdCurrEduCls] == DBNull.Value ? null : objRow[conPaperReadWrite.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperReadWriteEN.SubVCount = objRow[conPaperReadWrite.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperReadWrite.SubVCount].ToString().Trim()); //论文子观点数
objPaperReadWriteEN.TeaCount = objRow[conPaperReadWrite.TeaCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperReadWrite.TeaCount].ToString().Trim()); //TeaCount
objPaperReadWriteEN.CreateDate = objRow[conPaperReadWrite.CreateDate] == DBNull.Value ? null : objRow[conPaperReadWrite.CreateDate].ToString().Trim(); //建立日期
objPaperReadWriteEN.ShareId = objRow[conPaperReadWrite.ShareId] == DBNull.Value ? null : objRow[conPaperReadWrite.ShareId].ToString().Trim(); //分享Id
objPaperReadWriteEN.UpdUser = objRow[conPaperReadWrite.UpdUser] == DBNull.Value ? null : objRow[conPaperReadWrite.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperReadWriteEN.PaperRWId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperReadWriteEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objPaperReadWriteCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsPaperReadWriteEN> GetSubObjLstCache(clsPaperReadWriteEN objPaperReadWriteCond)
{
 string strIdCurrEduCls = objPaperReadWriteCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsPaperReadWriteBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsPaperReadWriteEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsPaperReadWriteEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPaperReadWrite.AttributeName)
{
if (objPaperReadWriteCond.IsUpdated(strFldName) == false) continue;
if (objPaperReadWriteCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPaperReadWriteCond[strFldName].ToString());
}
else
{
if (objPaperReadWriteCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPaperReadWriteCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPaperReadWriteCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPaperReadWriteCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPaperReadWriteCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPaperReadWriteCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPaperReadWriteCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPaperReadWriteCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPaperReadWriteCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPaperReadWriteCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPaperReadWriteCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPaperReadWriteCond[strFldName]));
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
public static List<clsPaperReadWriteEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsPaperReadWriteEN> arrObjLst = new List<clsPaperReadWriteEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperReadWriteEN objPaperReadWriteEN = new clsPaperReadWriteEN();
try
{
objPaperReadWriteEN.PaperRWId = objRow[conPaperReadWrite.PaperRWId].ToString().Trim(); //课文阅读
objPaperReadWriteEN.ReaderId = objRow[conPaperReadWrite.ReaderId] == DBNull.Value ? null : objRow[conPaperReadWrite.ReaderId].ToString().Trim(); //阅读者Id
objPaperReadWriteEN.PaperId = objRow[conPaperReadWrite.PaperId] == DBNull.Value ? null : objRow[conPaperReadWrite.PaperId].ToString().Trim(); //论文Id
objPaperReadWriteEN.ResearchQuestion = objRow[conPaperReadWrite.ResearchQuestion] == DBNull.Value ? null : objRow[conPaperReadWrite.ResearchQuestion].ToString().Trim(); //研究问题
objPaperReadWriteEN.OperationTypeId = objRow[conPaperReadWrite.OperationTypeId].ToString().Trim(); //操作类型ID
objPaperReadWriteEN.UpdDate = objRow[conPaperReadWrite.UpdDate].ToString().Trim(); //修改日期
objPaperReadWriteEN.Memo = objRow[conPaperReadWrite.Memo] == DBNull.Value ? null : objRow[conPaperReadWrite.Memo].ToString().Trim(); //备注
objPaperReadWriteEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conPaperReadWrite.IsSubmit].ToString().Trim()); //是否提交
objPaperReadWriteEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conPaperReadWrite.IsPublic].ToString().Trim()); //是否公开
objPaperReadWriteEN.Submitter = objRow[conPaperReadWrite.Submitter] == DBNull.Value ? null : objRow[conPaperReadWrite.Submitter].ToString().Trim(); //提交人
objPaperReadWriteEN.IdCurrEduCls = objRow[conPaperReadWrite.IdCurrEduCls] == DBNull.Value ? null : objRow[conPaperReadWrite.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperReadWriteEN.SubVCount = objRow[conPaperReadWrite.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperReadWrite.SubVCount].ToString().Trim()); //论文子观点数
objPaperReadWriteEN.TeaCount = objRow[conPaperReadWrite.TeaCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperReadWrite.TeaCount].ToString().Trim()); //TeaCount
objPaperReadWriteEN.CreateDate = objRow[conPaperReadWrite.CreateDate] == DBNull.Value ? null : objRow[conPaperReadWrite.CreateDate].ToString().Trim(); //建立日期
objPaperReadWriteEN.ShareId = objRow[conPaperReadWrite.ShareId] == DBNull.Value ? null : objRow[conPaperReadWrite.ShareId].ToString().Trim(); //分享Id
objPaperReadWriteEN.UpdUser = objRow[conPaperReadWrite.UpdUser] == DBNull.Value ? null : objRow[conPaperReadWrite.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperReadWriteEN.PaperRWId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperReadWriteEN);
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
public static List<clsPaperReadWriteEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsPaperReadWriteEN> arrObjLst = new List<clsPaperReadWriteEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperReadWriteEN objPaperReadWriteEN = new clsPaperReadWriteEN();
try
{
objPaperReadWriteEN.PaperRWId = objRow[conPaperReadWrite.PaperRWId].ToString().Trim(); //课文阅读
objPaperReadWriteEN.ReaderId = objRow[conPaperReadWrite.ReaderId] == DBNull.Value ? null : objRow[conPaperReadWrite.ReaderId].ToString().Trim(); //阅读者Id
objPaperReadWriteEN.PaperId = objRow[conPaperReadWrite.PaperId] == DBNull.Value ? null : objRow[conPaperReadWrite.PaperId].ToString().Trim(); //论文Id
objPaperReadWriteEN.ResearchQuestion = objRow[conPaperReadWrite.ResearchQuestion] == DBNull.Value ? null : objRow[conPaperReadWrite.ResearchQuestion].ToString().Trim(); //研究问题
objPaperReadWriteEN.OperationTypeId = objRow[conPaperReadWrite.OperationTypeId].ToString().Trim(); //操作类型ID
objPaperReadWriteEN.UpdDate = objRow[conPaperReadWrite.UpdDate].ToString().Trim(); //修改日期
objPaperReadWriteEN.Memo = objRow[conPaperReadWrite.Memo] == DBNull.Value ? null : objRow[conPaperReadWrite.Memo].ToString().Trim(); //备注
objPaperReadWriteEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conPaperReadWrite.IsSubmit].ToString().Trim()); //是否提交
objPaperReadWriteEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conPaperReadWrite.IsPublic].ToString().Trim()); //是否公开
objPaperReadWriteEN.Submitter = objRow[conPaperReadWrite.Submitter] == DBNull.Value ? null : objRow[conPaperReadWrite.Submitter].ToString().Trim(); //提交人
objPaperReadWriteEN.IdCurrEduCls = objRow[conPaperReadWrite.IdCurrEduCls] == DBNull.Value ? null : objRow[conPaperReadWrite.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperReadWriteEN.SubVCount = objRow[conPaperReadWrite.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperReadWrite.SubVCount].ToString().Trim()); //论文子观点数
objPaperReadWriteEN.TeaCount = objRow[conPaperReadWrite.TeaCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperReadWrite.TeaCount].ToString().Trim()); //TeaCount
objPaperReadWriteEN.CreateDate = objRow[conPaperReadWrite.CreateDate] == DBNull.Value ? null : objRow[conPaperReadWrite.CreateDate].ToString().Trim(); //建立日期
objPaperReadWriteEN.ShareId = objRow[conPaperReadWrite.ShareId] == DBNull.Value ? null : objRow[conPaperReadWrite.ShareId].ToString().Trim(); //分享Id
objPaperReadWriteEN.UpdUser = objRow[conPaperReadWrite.UpdUser] == DBNull.Value ? null : objRow[conPaperReadWrite.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperReadWriteEN.PaperRWId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperReadWriteEN);
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
List<clsPaperReadWriteEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsPaperReadWriteEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsPaperReadWriteEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsPaperReadWriteEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsPaperReadWriteEN> arrObjLst = new List<clsPaperReadWriteEN>(); 
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
	clsPaperReadWriteEN objPaperReadWriteEN = new clsPaperReadWriteEN();
try
{
objPaperReadWriteEN.PaperRWId = objRow[conPaperReadWrite.PaperRWId].ToString().Trim(); //课文阅读
objPaperReadWriteEN.ReaderId = objRow[conPaperReadWrite.ReaderId] == DBNull.Value ? null : objRow[conPaperReadWrite.ReaderId].ToString().Trim(); //阅读者Id
objPaperReadWriteEN.PaperId = objRow[conPaperReadWrite.PaperId] == DBNull.Value ? null : objRow[conPaperReadWrite.PaperId].ToString().Trim(); //论文Id
objPaperReadWriteEN.ResearchQuestion = objRow[conPaperReadWrite.ResearchQuestion] == DBNull.Value ? null : objRow[conPaperReadWrite.ResearchQuestion].ToString().Trim(); //研究问题
objPaperReadWriteEN.OperationTypeId = objRow[conPaperReadWrite.OperationTypeId].ToString().Trim(); //操作类型ID
objPaperReadWriteEN.UpdDate = objRow[conPaperReadWrite.UpdDate].ToString().Trim(); //修改日期
objPaperReadWriteEN.Memo = objRow[conPaperReadWrite.Memo] == DBNull.Value ? null : objRow[conPaperReadWrite.Memo].ToString().Trim(); //备注
objPaperReadWriteEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conPaperReadWrite.IsSubmit].ToString().Trim()); //是否提交
objPaperReadWriteEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conPaperReadWrite.IsPublic].ToString().Trim()); //是否公开
objPaperReadWriteEN.Submitter = objRow[conPaperReadWrite.Submitter] == DBNull.Value ? null : objRow[conPaperReadWrite.Submitter].ToString().Trim(); //提交人
objPaperReadWriteEN.IdCurrEduCls = objRow[conPaperReadWrite.IdCurrEduCls] == DBNull.Value ? null : objRow[conPaperReadWrite.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperReadWriteEN.SubVCount = objRow[conPaperReadWrite.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperReadWrite.SubVCount].ToString().Trim()); //论文子观点数
objPaperReadWriteEN.TeaCount = objRow[conPaperReadWrite.TeaCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperReadWrite.TeaCount].ToString().Trim()); //TeaCount
objPaperReadWriteEN.CreateDate = objRow[conPaperReadWrite.CreateDate] == DBNull.Value ? null : objRow[conPaperReadWrite.CreateDate].ToString().Trim(); //建立日期
objPaperReadWriteEN.ShareId = objRow[conPaperReadWrite.ShareId] == DBNull.Value ? null : objRow[conPaperReadWrite.ShareId].ToString().Trim(); //分享Id
objPaperReadWriteEN.UpdUser = objRow[conPaperReadWrite.UpdUser] == DBNull.Value ? null : objRow[conPaperReadWrite.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperReadWriteEN.PaperRWId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperReadWriteEN);
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
public static List<clsPaperReadWriteEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsPaperReadWriteEN> arrObjLst = new List<clsPaperReadWriteEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperReadWriteEN objPaperReadWriteEN = new clsPaperReadWriteEN();
try
{
objPaperReadWriteEN.PaperRWId = objRow[conPaperReadWrite.PaperRWId].ToString().Trim(); //课文阅读
objPaperReadWriteEN.ReaderId = objRow[conPaperReadWrite.ReaderId] == DBNull.Value ? null : objRow[conPaperReadWrite.ReaderId].ToString().Trim(); //阅读者Id
objPaperReadWriteEN.PaperId = objRow[conPaperReadWrite.PaperId] == DBNull.Value ? null : objRow[conPaperReadWrite.PaperId].ToString().Trim(); //论文Id
objPaperReadWriteEN.ResearchQuestion = objRow[conPaperReadWrite.ResearchQuestion] == DBNull.Value ? null : objRow[conPaperReadWrite.ResearchQuestion].ToString().Trim(); //研究问题
objPaperReadWriteEN.OperationTypeId = objRow[conPaperReadWrite.OperationTypeId].ToString().Trim(); //操作类型ID
objPaperReadWriteEN.UpdDate = objRow[conPaperReadWrite.UpdDate].ToString().Trim(); //修改日期
objPaperReadWriteEN.Memo = objRow[conPaperReadWrite.Memo] == DBNull.Value ? null : objRow[conPaperReadWrite.Memo].ToString().Trim(); //备注
objPaperReadWriteEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conPaperReadWrite.IsSubmit].ToString().Trim()); //是否提交
objPaperReadWriteEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conPaperReadWrite.IsPublic].ToString().Trim()); //是否公开
objPaperReadWriteEN.Submitter = objRow[conPaperReadWrite.Submitter] == DBNull.Value ? null : objRow[conPaperReadWrite.Submitter].ToString().Trim(); //提交人
objPaperReadWriteEN.IdCurrEduCls = objRow[conPaperReadWrite.IdCurrEduCls] == DBNull.Value ? null : objRow[conPaperReadWrite.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperReadWriteEN.SubVCount = objRow[conPaperReadWrite.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperReadWrite.SubVCount].ToString().Trim()); //论文子观点数
objPaperReadWriteEN.TeaCount = objRow[conPaperReadWrite.TeaCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperReadWrite.TeaCount].ToString().Trim()); //TeaCount
objPaperReadWriteEN.CreateDate = objRow[conPaperReadWrite.CreateDate] == DBNull.Value ? null : objRow[conPaperReadWrite.CreateDate].ToString().Trim(); //建立日期
objPaperReadWriteEN.ShareId = objRow[conPaperReadWrite.ShareId] == DBNull.Value ? null : objRow[conPaperReadWrite.ShareId].ToString().Trim(); //分享Id
objPaperReadWriteEN.UpdUser = objRow[conPaperReadWrite.UpdUser] == DBNull.Value ? null : objRow[conPaperReadWrite.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperReadWriteEN.PaperRWId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperReadWriteEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsPaperReadWriteEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsPaperReadWriteEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsPaperReadWriteEN> arrObjLst = new List<clsPaperReadWriteEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperReadWriteEN objPaperReadWriteEN = new clsPaperReadWriteEN();
try
{
objPaperReadWriteEN.PaperRWId = objRow[conPaperReadWrite.PaperRWId].ToString().Trim(); //课文阅读
objPaperReadWriteEN.ReaderId = objRow[conPaperReadWrite.ReaderId] == DBNull.Value ? null : objRow[conPaperReadWrite.ReaderId].ToString().Trim(); //阅读者Id
objPaperReadWriteEN.PaperId = objRow[conPaperReadWrite.PaperId] == DBNull.Value ? null : objRow[conPaperReadWrite.PaperId].ToString().Trim(); //论文Id
objPaperReadWriteEN.ResearchQuestion = objRow[conPaperReadWrite.ResearchQuestion] == DBNull.Value ? null : objRow[conPaperReadWrite.ResearchQuestion].ToString().Trim(); //研究问题
objPaperReadWriteEN.OperationTypeId = objRow[conPaperReadWrite.OperationTypeId].ToString().Trim(); //操作类型ID
objPaperReadWriteEN.UpdDate = objRow[conPaperReadWrite.UpdDate].ToString().Trim(); //修改日期
objPaperReadWriteEN.Memo = objRow[conPaperReadWrite.Memo] == DBNull.Value ? null : objRow[conPaperReadWrite.Memo].ToString().Trim(); //备注
objPaperReadWriteEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conPaperReadWrite.IsSubmit].ToString().Trim()); //是否提交
objPaperReadWriteEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conPaperReadWrite.IsPublic].ToString().Trim()); //是否公开
objPaperReadWriteEN.Submitter = objRow[conPaperReadWrite.Submitter] == DBNull.Value ? null : objRow[conPaperReadWrite.Submitter].ToString().Trim(); //提交人
objPaperReadWriteEN.IdCurrEduCls = objRow[conPaperReadWrite.IdCurrEduCls] == DBNull.Value ? null : objRow[conPaperReadWrite.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperReadWriteEN.SubVCount = objRow[conPaperReadWrite.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperReadWrite.SubVCount].ToString().Trim()); //论文子观点数
objPaperReadWriteEN.TeaCount = objRow[conPaperReadWrite.TeaCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperReadWrite.TeaCount].ToString().Trim()); //TeaCount
objPaperReadWriteEN.CreateDate = objRow[conPaperReadWrite.CreateDate] == DBNull.Value ? null : objRow[conPaperReadWrite.CreateDate].ToString().Trim(); //建立日期
objPaperReadWriteEN.ShareId = objRow[conPaperReadWrite.ShareId] == DBNull.Value ? null : objRow[conPaperReadWrite.ShareId].ToString().Trim(); //分享Id
objPaperReadWriteEN.UpdUser = objRow[conPaperReadWrite.UpdUser] == DBNull.Value ? null : objRow[conPaperReadWrite.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperReadWriteEN.PaperRWId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperReadWriteEN);
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
public static List<clsPaperReadWriteEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsPaperReadWriteEN> arrObjLst = new List<clsPaperReadWriteEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperReadWriteEN objPaperReadWriteEN = new clsPaperReadWriteEN();
try
{
objPaperReadWriteEN.PaperRWId = objRow[conPaperReadWrite.PaperRWId].ToString().Trim(); //课文阅读
objPaperReadWriteEN.ReaderId = objRow[conPaperReadWrite.ReaderId] == DBNull.Value ? null : objRow[conPaperReadWrite.ReaderId].ToString().Trim(); //阅读者Id
objPaperReadWriteEN.PaperId = objRow[conPaperReadWrite.PaperId] == DBNull.Value ? null : objRow[conPaperReadWrite.PaperId].ToString().Trim(); //论文Id
objPaperReadWriteEN.ResearchQuestion = objRow[conPaperReadWrite.ResearchQuestion] == DBNull.Value ? null : objRow[conPaperReadWrite.ResearchQuestion].ToString().Trim(); //研究问题
objPaperReadWriteEN.OperationTypeId = objRow[conPaperReadWrite.OperationTypeId].ToString().Trim(); //操作类型ID
objPaperReadWriteEN.UpdDate = objRow[conPaperReadWrite.UpdDate].ToString().Trim(); //修改日期
objPaperReadWriteEN.Memo = objRow[conPaperReadWrite.Memo] == DBNull.Value ? null : objRow[conPaperReadWrite.Memo].ToString().Trim(); //备注
objPaperReadWriteEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conPaperReadWrite.IsSubmit].ToString().Trim()); //是否提交
objPaperReadWriteEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conPaperReadWrite.IsPublic].ToString().Trim()); //是否公开
objPaperReadWriteEN.Submitter = objRow[conPaperReadWrite.Submitter] == DBNull.Value ? null : objRow[conPaperReadWrite.Submitter].ToString().Trim(); //提交人
objPaperReadWriteEN.IdCurrEduCls = objRow[conPaperReadWrite.IdCurrEduCls] == DBNull.Value ? null : objRow[conPaperReadWrite.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperReadWriteEN.SubVCount = objRow[conPaperReadWrite.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperReadWrite.SubVCount].ToString().Trim()); //论文子观点数
objPaperReadWriteEN.TeaCount = objRow[conPaperReadWrite.TeaCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperReadWrite.TeaCount].ToString().Trim()); //TeaCount
objPaperReadWriteEN.CreateDate = objRow[conPaperReadWrite.CreateDate] == DBNull.Value ? null : objRow[conPaperReadWrite.CreateDate].ToString().Trim(); //建立日期
objPaperReadWriteEN.ShareId = objRow[conPaperReadWrite.ShareId] == DBNull.Value ? null : objRow[conPaperReadWrite.ShareId].ToString().Trim(); //分享Id
objPaperReadWriteEN.UpdUser = objRow[conPaperReadWrite.UpdUser] == DBNull.Value ? null : objRow[conPaperReadWrite.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperReadWriteEN.PaperRWId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperReadWriteEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsPaperReadWriteEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsPaperReadWriteEN> arrObjLst = new List<clsPaperReadWriteEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperReadWriteEN objPaperReadWriteEN = new clsPaperReadWriteEN();
try
{
objPaperReadWriteEN.PaperRWId = objRow[conPaperReadWrite.PaperRWId].ToString().Trim(); //课文阅读
objPaperReadWriteEN.ReaderId = objRow[conPaperReadWrite.ReaderId] == DBNull.Value ? null : objRow[conPaperReadWrite.ReaderId].ToString().Trim(); //阅读者Id
objPaperReadWriteEN.PaperId = objRow[conPaperReadWrite.PaperId] == DBNull.Value ? null : objRow[conPaperReadWrite.PaperId].ToString().Trim(); //论文Id
objPaperReadWriteEN.ResearchQuestion = objRow[conPaperReadWrite.ResearchQuestion] == DBNull.Value ? null : objRow[conPaperReadWrite.ResearchQuestion].ToString().Trim(); //研究问题
objPaperReadWriteEN.OperationTypeId = objRow[conPaperReadWrite.OperationTypeId].ToString().Trim(); //操作类型ID
objPaperReadWriteEN.UpdDate = objRow[conPaperReadWrite.UpdDate].ToString().Trim(); //修改日期
objPaperReadWriteEN.Memo = objRow[conPaperReadWrite.Memo] == DBNull.Value ? null : objRow[conPaperReadWrite.Memo].ToString().Trim(); //备注
objPaperReadWriteEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conPaperReadWrite.IsSubmit].ToString().Trim()); //是否提交
objPaperReadWriteEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conPaperReadWrite.IsPublic].ToString().Trim()); //是否公开
objPaperReadWriteEN.Submitter = objRow[conPaperReadWrite.Submitter] == DBNull.Value ? null : objRow[conPaperReadWrite.Submitter].ToString().Trim(); //提交人
objPaperReadWriteEN.IdCurrEduCls = objRow[conPaperReadWrite.IdCurrEduCls] == DBNull.Value ? null : objRow[conPaperReadWrite.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperReadWriteEN.SubVCount = objRow[conPaperReadWrite.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperReadWrite.SubVCount].ToString().Trim()); //论文子观点数
objPaperReadWriteEN.TeaCount = objRow[conPaperReadWrite.TeaCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperReadWrite.TeaCount].ToString().Trim()); //TeaCount
objPaperReadWriteEN.CreateDate = objRow[conPaperReadWrite.CreateDate] == DBNull.Value ? null : objRow[conPaperReadWrite.CreateDate].ToString().Trim(); //建立日期
objPaperReadWriteEN.ShareId = objRow[conPaperReadWrite.ShareId] == DBNull.Value ? null : objRow[conPaperReadWrite.ShareId].ToString().Trim(); //分享Id
objPaperReadWriteEN.UpdUser = objRow[conPaperReadWrite.UpdUser] == DBNull.Value ? null : objRow[conPaperReadWrite.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperReadWriteEN.PaperRWId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperReadWriteEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objPaperReadWriteEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetPaperReadWrite(ref clsPaperReadWriteEN objPaperReadWriteEN)
{
bool bolResult = PaperReadWriteDA.GetPaperReadWrite(ref objPaperReadWriteEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strPaperRWId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPaperReadWriteEN GetObjByPaperRWId(string strPaperRWId)
{
if (strPaperRWId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strPaperRWId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strPaperRWId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strPaperRWId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsPaperReadWriteEN objPaperReadWriteEN = PaperReadWriteDA.GetObjByPaperRWId(strPaperRWId);
return objPaperReadWriteEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsPaperReadWriteEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsPaperReadWriteEN objPaperReadWriteEN = PaperReadWriteDA.GetFirstObj(strWhereCond);
 return objPaperReadWriteEN;
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
public static clsPaperReadWriteEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsPaperReadWriteEN objPaperReadWriteEN = PaperReadWriteDA.GetObjByDataRow(objRow);
 return objPaperReadWriteEN;
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
public static clsPaperReadWriteEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsPaperReadWriteEN objPaperReadWriteEN = PaperReadWriteDA.GetObjByDataRow(objRow);
 return objPaperReadWriteEN;
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
 /// <param name = "strPaperRWId">所给的关键字</param>
 /// <param name = "lstPaperReadWriteObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPaperReadWriteEN GetObjByPaperRWIdFromList(string strPaperRWId, List<clsPaperReadWriteEN> lstPaperReadWriteObjLst)
{
foreach (clsPaperReadWriteEN objPaperReadWriteEN in lstPaperReadWriteObjLst)
{
if (objPaperReadWriteEN.PaperRWId == strPaperRWId)
{
return objPaperReadWriteEN;
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
 string strMaxPaperRWId;
 try
 {
 strMaxPaperRWId = clsPaperReadWriteDA.GetMaxStrId();
 return strMaxPaperRWId;
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
 string strPaperRWId;
 try
 {
 strPaperRWId = new clsPaperReadWriteDA().GetFirstID(strWhereCond);
 return strPaperRWId;
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
 arrList = PaperReadWriteDA.GetID(strWhereCond);
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
bool bolIsExist = PaperReadWriteDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strPaperRWId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strPaperRWId)
{
if (string.IsNullOrEmpty(strPaperRWId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strPaperRWId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = PaperReadWriteDA.IsExist(strPaperRWId);
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
 bolIsExist = clsPaperReadWriteDA.IsExistTable();
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
 bolIsExist = PaperReadWriteDA.IsExistTable(strTabName);
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
 /// <param name = "objPaperReadWriteEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsPaperReadWriteEN objPaperReadWriteEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objPaperReadWriteEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!阅读者Id = [{0}],论文Id = [{1}]的数据已经存在!(in clsPaperReadWriteBL.AddNewRecordBySql2)", objPaperReadWriteEN.ReaderId,objPaperReadWriteEN.PaperId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objPaperReadWriteEN.PaperRWId) == true || clsPaperReadWriteBL.IsExist(objPaperReadWriteEN.PaperRWId) == true)
 {
     objPaperReadWriteEN.PaperRWId = clsPaperReadWriteBL.GetMaxStrId_S();
 }
bool bolResult = PaperReadWriteDA.AddNewRecordBySQL2(objPaperReadWriteEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperReadWriteBL.ReFreshCache(objPaperReadWriteEN.IdCurrEduCls);

if (clsPaperReadWriteBL.relatedActions != null)
{
clsPaperReadWriteBL.relatedActions.UpdRelaTabDate(objPaperReadWriteEN.PaperRWId, "SetUpdDate");
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
 /// <param name = "objPaperReadWriteEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsPaperReadWriteEN objPaperReadWriteEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objPaperReadWriteEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!阅读者Id = [{0}],论文Id = [{1}]的数据已经存在!(in clsPaperReadWriteBL.AddNewRecordBySql2WithReturnKey)", objPaperReadWriteEN.ReaderId,objPaperReadWriteEN.PaperId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objPaperReadWriteEN.PaperRWId) == true || clsPaperReadWriteBL.IsExist(objPaperReadWriteEN.PaperRWId) == true)
 {
     objPaperReadWriteEN.PaperRWId = clsPaperReadWriteBL.GetMaxStrId_S();
 }
string strKey = PaperReadWriteDA.AddNewRecordBySQL2WithReturnKey(objPaperReadWriteEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperReadWriteBL.ReFreshCache(objPaperReadWriteEN.IdCurrEduCls);

if (clsPaperReadWriteBL.relatedActions != null)
{
clsPaperReadWriteBL.relatedActions.UpdRelaTabDate(objPaperReadWriteEN.PaperRWId, "SetUpdDate");
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
 /// <param name = "objPaperReadWriteEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsPaperReadWriteEN objPaperReadWriteEN)
{
try
{
bool bolResult = PaperReadWriteDA.Update(objPaperReadWriteEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperReadWriteBL.ReFreshCache(objPaperReadWriteEN.IdCurrEduCls);

if (clsPaperReadWriteBL.relatedActions != null)
{
clsPaperReadWriteBL.relatedActions.UpdRelaTabDate(objPaperReadWriteEN.PaperRWId, "SetUpdDate");
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
 /// <param name = "objPaperReadWriteEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsPaperReadWriteEN objPaperReadWriteEN)
{
 if (string.IsNullOrEmpty(objPaperReadWriteEN.PaperRWId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = PaperReadWriteDA.UpdateBySql2(objPaperReadWriteEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperReadWriteBL.ReFreshCache(objPaperReadWriteEN.IdCurrEduCls);

if (clsPaperReadWriteBL.relatedActions != null)
{
clsPaperReadWriteBL.relatedActions.UpdRelaTabDate(objPaperReadWriteEN.PaperRWId, "SetUpdDate");
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
 /// <param name = "strPaperRWId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strPaperRWId)
{
try
{
 clsPaperReadWriteEN objPaperReadWriteEN = clsPaperReadWriteBL.GetObjByPaperRWId(strPaperRWId);

if (clsPaperReadWriteBL.relatedActions != null)
{
clsPaperReadWriteBL.relatedActions.UpdRelaTabDate(objPaperReadWriteEN.PaperRWId, "SetUpdDate");
}
if (objPaperReadWriteEN != null)
{
int intRecNum = PaperReadWriteDA.DelRecord(strPaperRWId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objPaperReadWriteEN.IdCurrEduCls);
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
/// <param name="strPaperRWId">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strPaperRWId , string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPaperReadWriteDA.GetSpecSQLObj();
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
//删除与表:[PaperReadWrite]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conPaperReadWrite.PaperRWId,
//strPaperRWId);
//        clsPaperReadWriteBL.DelPaperReadWritesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPaperReadWriteBL.DelRecord(strPaperRWId, strIdCurrEduCls, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPaperReadWriteBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strPaperRWId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strPaperRWId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strPaperRWId, string strIdCurrEduCls, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsPaperReadWriteBL.relatedActions != null)
{
clsPaperReadWriteBL.relatedActions.UpdRelaTabDate(strPaperRWId, "UpdRelaTabDate");
}
bool bolResult = PaperReadWriteDA.DelRecord(strPaperRWId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrPaperRWIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelPaperReadWrites(List<string> arrPaperRWIdLst)
{
if (arrPaperRWIdLst.Count == 0) return 0;
try
{
if (clsPaperReadWriteBL.relatedActions != null)
{
foreach (var strPaperRWId in arrPaperRWIdLst)
{
clsPaperReadWriteBL.relatedActions.UpdRelaTabDate(strPaperRWId, "UpdRelaTabDate");
}
}
 clsPaperReadWriteEN objPaperReadWriteEN = clsPaperReadWriteBL.GetObjByPaperRWId(arrPaperRWIdLst[0]);
int intDelRecNum = PaperReadWriteDA.DelPaperReadWrite(arrPaperRWIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objPaperReadWriteEN.IdCurrEduCls);
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
public static int DelPaperReadWritesByCond(string strWhereCond)
{
try
{
if (clsPaperReadWriteBL.relatedActions != null)
{
List<string> arrPaperRWId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strPaperRWId in arrPaperRWId)
{
clsPaperReadWriteBL.relatedActions.UpdRelaTabDate(strPaperRWId, "UpdRelaTabDate");
}
}
List<string> arrIdCurrEduCls = GetFldValue(conPaperReadWrite.IdCurrEduCls, strWhereCond);
int intRecNum = PaperReadWriteDA.DelPaperReadWrite(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[PaperReadWrite]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strPaperRWId">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strPaperRWId, string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPaperReadWriteDA.GetSpecSQLObj();
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
//删除与表:[PaperReadWrite]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPaperReadWriteBL.DelRecord(strPaperRWId, strIdCurrEduCls, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPaperReadWriteBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strPaperRWId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objPaperReadWriteENS">源对象</param>
 /// <param name = "objPaperReadWriteENT">目标对象</param>
 public static void CopyTo(clsPaperReadWriteEN objPaperReadWriteENS, clsPaperReadWriteEN objPaperReadWriteENT)
{
try
{
objPaperReadWriteENT.PaperRWId = objPaperReadWriteENS.PaperRWId; //课文阅读
objPaperReadWriteENT.ReaderId = objPaperReadWriteENS.ReaderId; //阅读者Id
objPaperReadWriteENT.PaperId = objPaperReadWriteENS.PaperId; //论文Id
objPaperReadWriteENT.ResearchQuestion = objPaperReadWriteENS.ResearchQuestion; //研究问题
objPaperReadWriteENT.OperationTypeId = objPaperReadWriteENS.OperationTypeId; //操作类型ID
objPaperReadWriteENT.UpdDate = objPaperReadWriteENS.UpdDate; //修改日期
objPaperReadWriteENT.Memo = objPaperReadWriteENS.Memo; //备注
objPaperReadWriteENT.IsSubmit = objPaperReadWriteENS.IsSubmit; //是否提交
objPaperReadWriteENT.IsPublic = objPaperReadWriteENS.IsPublic; //是否公开
objPaperReadWriteENT.Submitter = objPaperReadWriteENS.Submitter; //提交人
objPaperReadWriteENT.IdCurrEduCls = objPaperReadWriteENS.IdCurrEduCls; //教学班流水号
objPaperReadWriteENT.SubVCount = objPaperReadWriteENS.SubVCount; //论文子观点数
objPaperReadWriteENT.TeaCount = objPaperReadWriteENS.TeaCount; //TeaCount
objPaperReadWriteENT.CreateDate = objPaperReadWriteENS.CreateDate; //建立日期
objPaperReadWriteENT.ShareId = objPaperReadWriteENS.ShareId; //分享Id
objPaperReadWriteENT.UpdUser = objPaperReadWriteENS.UpdUser; //修改人
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
 /// <param name = "objPaperReadWriteEN">源简化对象</param>
 public static void SetUpdFlag(clsPaperReadWriteEN objPaperReadWriteEN)
{
try
{
objPaperReadWriteEN.ClearUpdateState();
   string strsfUpdFldSetStr = objPaperReadWriteEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conPaperReadWrite.PaperRWId, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperReadWriteEN.PaperRWId = objPaperReadWriteEN.PaperRWId; //课文阅读
}
if (arrFldSet.Contains(conPaperReadWrite.ReaderId, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperReadWriteEN.ReaderId = objPaperReadWriteEN.ReaderId == "[null]" ? null :  objPaperReadWriteEN.ReaderId; //阅读者Id
}
if (arrFldSet.Contains(conPaperReadWrite.PaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperReadWriteEN.PaperId = objPaperReadWriteEN.PaperId == "[null]" ? null :  objPaperReadWriteEN.PaperId; //论文Id
}
if (arrFldSet.Contains(conPaperReadWrite.ResearchQuestion, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperReadWriteEN.ResearchQuestion = objPaperReadWriteEN.ResearchQuestion == "[null]" ? null :  objPaperReadWriteEN.ResearchQuestion; //研究问题
}
if (arrFldSet.Contains(conPaperReadWrite.OperationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperReadWriteEN.OperationTypeId = objPaperReadWriteEN.OperationTypeId; //操作类型ID
}
if (arrFldSet.Contains(conPaperReadWrite.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperReadWriteEN.UpdDate = objPaperReadWriteEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conPaperReadWrite.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperReadWriteEN.Memo = objPaperReadWriteEN.Memo == "[null]" ? null :  objPaperReadWriteEN.Memo; //备注
}
if (arrFldSet.Contains(conPaperReadWrite.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperReadWriteEN.IsSubmit = objPaperReadWriteEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(conPaperReadWrite.IsPublic, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperReadWriteEN.IsPublic = objPaperReadWriteEN.IsPublic; //是否公开
}
if (arrFldSet.Contains(conPaperReadWrite.Submitter, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperReadWriteEN.Submitter = objPaperReadWriteEN.Submitter == "[null]" ? null :  objPaperReadWriteEN.Submitter; //提交人
}
if (arrFldSet.Contains(conPaperReadWrite.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperReadWriteEN.IdCurrEduCls = objPaperReadWriteEN.IdCurrEduCls == "[null]" ? null :  objPaperReadWriteEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conPaperReadWrite.SubVCount, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperReadWriteEN.SubVCount = objPaperReadWriteEN.SubVCount; //论文子观点数
}
if (arrFldSet.Contains(conPaperReadWrite.TeaCount, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperReadWriteEN.TeaCount = objPaperReadWriteEN.TeaCount; //TeaCount
}
if (arrFldSet.Contains(conPaperReadWrite.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperReadWriteEN.CreateDate = objPaperReadWriteEN.CreateDate == "[null]" ? null :  objPaperReadWriteEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(conPaperReadWrite.ShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperReadWriteEN.ShareId = objPaperReadWriteEN.ShareId == "[null]" ? null :  objPaperReadWriteEN.ShareId; //分享Id
}
if (arrFldSet.Contains(conPaperReadWrite.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperReadWriteEN.UpdUser = objPaperReadWriteEN.UpdUser == "[null]" ? null :  objPaperReadWriteEN.UpdUser; //修改人
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
 /// <param name = "objPaperReadWriteEN">源简化对象</param>
 public static void AccessFldValueNull(clsPaperReadWriteEN objPaperReadWriteEN)
{
try
{
if (objPaperReadWriteEN.ReaderId == "[null]") objPaperReadWriteEN.ReaderId = null; //阅读者Id
if (objPaperReadWriteEN.PaperId == "[null]") objPaperReadWriteEN.PaperId = null; //论文Id
if (objPaperReadWriteEN.ResearchQuestion == "[null]") objPaperReadWriteEN.ResearchQuestion = null; //研究问题
if (objPaperReadWriteEN.Memo == "[null]") objPaperReadWriteEN.Memo = null; //备注
if (objPaperReadWriteEN.Submitter == "[null]") objPaperReadWriteEN.Submitter = null; //提交人
if (objPaperReadWriteEN.IdCurrEduCls == "[null]") objPaperReadWriteEN.IdCurrEduCls = null; //教学班流水号
if (objPaperReadWriteEN.CreateDate == "[null]") objPaperReadWriteEN.CreateDate = null; //建立日期
if (objPaperReadWriteEN.ShareId == "[null]") objPaperReadWriteEN.ShareId = null; //分享Id
if (objPaperReadWriteEN.UpdUser == "[null]") objPaperReadWriteEN.UpdUser = null; //修改人
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
public static void CheckPropertyNew(clsPaperReadWriteEN objPaperReadWriteEN)
{
 PaperReadWriteDA.CheckPropertyNew(objPaperReadWriteEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsPaperReadWriteEN objPaperReadWriteEN)
{
 PaperReadWriteDA.CheckProperty4Condition(objPaperReadWriteEN);
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
if (clsPaperReadWriteBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperReadWriteBL没有刷新缓存机制(clsPaperReadWriteBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PaperRWId");
//if (arrPaperReadWriteObjLstCache == null)
//{
//arrPaperReadWriteObjLstCache = PaperReadWriteDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strPaperRWId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPaperReadWriteEN GetObjByPaperRWIdCache(string strPaperRWId, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsPaperReadWriteEN._CurrTabName, strIdCurrEduCls);
List<clsPaperReadWriteEN> arrPaperReadWriteObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsPaperReadWriteEN> arrPaperReadWriteObjLst_Sel =
arrPaperReadWriteObjLstCache
.Where(x=> x.PaperRWId == strPaperRWId 
);
if (arrPaperReadWriteObjLst_Sel.Count() == 0)
{
   clsPaperReadWriteEN obj = clsPaperReadWriteBL.GetObjByPaperRWId(strPaperRWId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strPaperRWId, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrPaperReadWriteObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPaperReadWriteEN> GetAllPaperReadWriteObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsPaperReadWriteEN> arrPaperReadWriteObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrPaperReadWriteObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPaperReadWriteEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsPaperReadWriteEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsPaperReadWriteEN> arrPaperReadWriteObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrPaperReadWriteObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsPaperReadWriteEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clsPaperReadWriteEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsPaperReadWriteEN._RefreshTimeLst.Count == 0) return "";
return clsPaperReadWriteEN._RefreshTimeLst[clsPaperReadWriteEN._RefreshTimeLst.Count - 1];
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
if (clsPaperReadWriteBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsPaperReadWriteEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clsPaperReadWriteEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsPaperReadWriteBL.objCommFun4BL.ReFreshCache(strIdCurrEduCls);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--PaperReadWrite(论文读写表)
 /// 唯一性条件:ReaderId_PaperId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objPaperReadWriteEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsPaperReadWriteEN objPaperReadWriteEN)
{
//检测记录是否存在
string strResult = PaperReadWriteDA.GetUniCondStr(objPaperReadWriteEN);
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
public static string Func(string strInFldName, string strOutFldName, string strPaperRWId, string strIdCurrEduCls)
{
if (strInFldName != conPaperReadWrite.PaperRWId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conPaperReadWrite.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conPaperReadWrite.AttributeName));
throw new Exception(strMsg);
}
var objPaperReadWrite = clsPaperReadWriteBL.GetObjByPaperRWIdCache(strPaperRWId, strIdCurrEduCls);
if (objPaperReadWrite == null) return "";
return objPaperReadWrite[strOutFldName].ToString();
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
int intRecCount = clsPaperReadWriteDA.GetRecCount(strTabName);
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
int intRecCount = clsPaperReadWriteDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsPaperReadWriteDA.GetRecCount();
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
int intRecCount = clsPaperReadWriteDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objPaperReadWriteCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsPaperReadWriteEN objPaperReadWriteCond)
{
 string strIdCurrEduCls = objPaperReadWriteCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsPaperReadWriteBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsPaperReadWriteEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsPaperReadWriteEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPaperReadWrite.AttributeName)
{
if (objPaperReadWriteCond.IsUpdated(strFldName) == false) continue;
if (objPaperReadWriteCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPaperReadWriteCond[strFldName].ToString());
}
else
{
if (objPaperReadWriteCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPaperReadWriteCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPaperReadWriteCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPaperReadWriteCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPaperReadWriteCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPaperReadWriteCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPaperReadWriteCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPaperReadWriteCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPaperReadWriteCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPaperReadWriteCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPaperReadWriteCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPaperReadWriteCond[strFldName]));
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
 List<string> arrList = clsPaperReadWriteDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = PaperReadWriteDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = PaperReadWriteDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = PaperReadWriteDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsPaperReadWriteDA.SetFldValue(clsPaperReadWriteEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = PaperReadWriteDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsPaperReadWriteDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsPaperReadWriteDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsPaperReadWriteDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[PaperReadWrite] "); 
 strCreateTabCode.Append(" ( "); 
 // /**课文阅读*/ 
 strCreateTabCode.Append(" PaperRWId char(8) primary key, "); 
 // /**阅读者Id*/ 
 strCreateTabCode.Append(" ReaderId varchar(20) Null, "); 
 // /**论文Id*/ 
 strCreateTabCode.Append(" PaperId char(8) Null, "); 
 // /**研究问题*/ 
 strCreateTabCode.Append(" ResearchQuestion varchar(2000) Null, "); 
 // /**操作类型ID*/ 
 strCreateTabCode.Append(" OperationTypeId char(4) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) not Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**是否提交*/ 
 strCreateTabCode.Append(" IsSubmit bit Null, "); 
 // /**是否公开*/ 
 strCreateTabCode.Append(" IsPublic bit Null, "); 
 // /**提交人*/ 
 strCreateTabCode.Append(" Submitter varchar(50) Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) Null, "); 
 // /**论文子观点数*/ 
 strCreateTabCode.Append(" SubVCount int Null, "); 
 // /**TeaCount*/ 
 strCreateTabCode.Append(" TeaCount int Null, "); 
 // /**建立日期*/ 
 strCreateTabCode.Append(" CreateDate varchar(20) Null, "); 
 // /**分享Id*/ 
 strCreateTabCode.Append(" ShareId char(2) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 论文读写表(PaperReadWrite)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4PaperReadWrite : clsCommFun4BLV2
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
clsPaperReadWriteBL.ReFreshThisCache(strIdCurrEduCls);
}
}

}