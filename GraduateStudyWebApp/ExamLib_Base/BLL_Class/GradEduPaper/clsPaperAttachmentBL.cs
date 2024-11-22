
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPaperAttachmentBL
 表名:PaperAttachment(01120578)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:14:48
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
public static class  clsPaperAttachmentBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngPaperAttachmentId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPaperAttachmentEN GetObj(this K_PaperAttachmentId_PaperAttachment myKey)
{
clsPaperAttachmentEN objPaperAttachmentEN = clsPaperAttachmentBL.PaperAttachmentDA.GetObjByPaperAttachmentId(myKey.Value);
return objPaperAttachmentEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objPaperAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsPaperAttachmentEN objPaperAttachmentEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objPaperAttachmentEN) == false)
{
var strMsg = string.Format("记录已经存在!附件名称 = [{0}],论文Id = [{1}]的数据已经存在!(in clsPaperAttachmentBL.AddNewRecord)", objPaperAttachmentEN.PaperAttachmentName,objPaperAttachmentEN.PaperId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsPaperAttachmentBL.PaperAttachmentDA.AddNewRecordBySQL2(objPaperAttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperAttachmentBL.ReFreshCache(objPaperAttachmentEN.IdCurrEduCls);

if (clsPaperAttachmentBL.relatedActions != null)
{
clsPaperAttachmentBL.relatedActions.UpdRelaTabDate(objPaperAttachmentEN.PaperAttachmentId, objPaperAttachmentEN.UpdUserId);
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
public static bool AddRecordEx(this clsPaperAttachmentEN objPaperAttachmentEN, bool bolIsNeedCheckUniqueness = true)
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
objPaperAttachmentEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objPaperAttachmentEN.CheckUniqueness() == false)
{
strMsg = string.Format("(附件名称(PaperAttachmentName)=[{0}],论文Id(PaperId)=[{1}])已经存在,不能重复!", objPaperAttachmentEN.PaperAttachmentName, objPaperAttachmentEN.PaperId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objPaperAttachmentEN.AddNewRecord();
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
 /// <param name = "objPaperAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsPaperAttachmentEN objPaperAttachmentEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objPaperAttachmentEN) == false)
{
var strMsg = string.Format("记录已经存在!附件名称 = [{0}],论文Id = [{1}]的数据已经存在!(in clsPaperAttachmentBL.AddNewRecordWithReturnKey)", objPaperAttachmentEN.PaperAttachmentName,objPaperAttachmentEN.PaperId);
throw new Exception(strMsg);
}
try
{
string strKey = clsPaperAttachmentBL.PaperAttachmentDA.AddNewRecordBySQL2WithReturnKey(objPaperAttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperAttachmentBL.ReFreshCache(objPaperAttachmentEN.IdCurrEduCls);

if (clsPaperAttachmentBL.relatedActions != null)
{
clsPaperAttachmentBL.relatedActions.UpdRelaTabDate(objPaperAttachmentEN.PaperAttachmentId, objPaperAttachmentEN.UpdUserId);
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
 /// <param name = "objPaperAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperAttachmentEN SetPaperAttachmentId(this clsPaperAttachmentEN objPaperAttachmentEN, long lngPaperAttachmentId, string strComparisonOp="")
	{
objPaperAttachmentEN.PaperAttachmentId = lngPaperAttachmentId; //论文附件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperAttachmentEN.dicFldComparisonOp.ContainsKey(conPaperAttachment.PaperAttachmentId) == false)
{
objPaperAttachmentEN.dicFldComparisonOp.Add(conPaperAttachment.PaperAttachmentId, strComparisonOp);
}
else
{
objPaperAttachmentEN.dicFldComparisonOp[conPaperAttachment.PaperAttachmentId] = strComparisonOp;
}
}
return objPaperAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperAttachmentEN SetPaperAttachmentName(this clsPaperAttachmentEN objPaperAttachmentEN, string strPaperAttachmentName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperAttachmentName, 200, conPaperAttachment.PaperAttachmentName);
}
objPaperAttachmentEN.PaperAttachmentName = strPaperAttachmentName; //附件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperAttachmentEN.dicFldComparisonOp.ContainsKey(conPaperAttachment.PaperAttachmentName) == false)
{
objPaperAttachmentEN.dicFldComparisonOp.Add(conPaperAttachment.PaperAttachmentName, strComparisonOp);
}
else
{
objPaperAttachmentEN.dicFldComparisonOp[conPaperAttachment.PaperAttachmentName] = strComparisonOp;
}
}
return objPaperAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperAttachmentEN SetPaperId(this clsPaperAttachmentEN objPaperAttachmentEN, string strPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperId, 8, conPaperAttachment.PaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, conPaperAttachment.PaperId);
}
objPaperAttachmentEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperAttachmentEN.dicFldComparisonOp.ContainsKey(conPaperAttachment.PaperId) == false)
{
objPaperAttachmentEN.dicFldComparisonOp.Add(conPaperAttachment.PaperId, strComparisonOp);
}
else
{
objPaperAttachmentEN.dicFldComparisonOp[conPaperAttachment.PaperId] = strComparisonOp;
}
}
return objPaperAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperAttachmentEN SetFilePath(this clsPaperAttachmentEN objPaperAttachmentEN, string strFilePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFilePath, conPaperAttachment.FilePath);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFilePath, 500, conPaperAttachment.FilePath);
}
objPaperAttachmentEN.FilePath = strFilePath; //文件路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperAttachmentEN.dicFldComparisonOp.ContainsKey(conPaperAttachment.FilePath) == false)
{
objPaperAttachmentEN.dicFldComparisonOp.Add(conPaperAttachment.FilePath, strComparisonOp);
}
else
{
objPaperAttachmentEN.dicFldComparisonOp[conPaperAttachment.FilePath] = strComparisonOp;
}
}
return objPaperAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperAttachmentEN SetIdCurrEduCls(this clsPaperAttachmentEN objPaperAttachmentEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conPaperAttachment.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conPaperAttachment.IdCurrEduCls);
}
objPaperAttachmentEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperAttachmentEN.dicFldComparisonOp.ContainsKey(conPaperAttachment.IdCurrEduCls) == false)
{
objPaperAttachmentEN.dicFldComparisonOp.Add(conPaperAttachment.IdCurrEduCls, strComparisonOp);
}
else
{
objPaperAttachmentEN.dicFldComparisonOp[conPaperAttachment.IdCurrEduCls] = strComparisonOp;
}
}
return objPaperAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperAttachmentEN SetUpdUserId(this clsPaperAttachmentEN objPaperAttachmentEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conPaperAttachment.UpdUserId);
}
objPaperAttachmentEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperAttachmentEN.dicFldComparisonOp.ContainsKey(conPaperAttachment.UpdUserId) == false)
{
objPaperAttachmentEN.dicFldComparisonOp.Add(conPaperAttachment.UpdUserId, strComparisonOp);
}
else
{
objPaperAttachmentEN.dicFldComparisonOp[conPaperAttachment.UpdUserId] = strComparisonOp;
}
}
return objPaperAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperAttachmentEN SetUpdDate(this clsPaperAttachmentEN objPaperAttachmentEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conPaperAttachment.UpdDate);
}
objPaperAttachmentEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperAttachmentEN.dicFldComparisonOp.ContainsKey(conPaperAttachment.UpdDate) == false)
{
objPaperAttachmentEN.dicFldComparisonOp.Add(conPaperAttachment.UpdDate, strComparisonOp);
}
else
{
objPaperAttachmentEN.dicFldComparisonOp[conPaperAttachment.UpdDate] = strComparisonOp;
}
}
return objPaperAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperAttachmentEN SetMemo(this clsPaperAttachmentEN objPaperAttachmentEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conPaperAttachment.Memo);
}
objPaperAttachmentEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperAttachmentEN.dicFldComparisonOp.ContainsKey(conPaperAttachment.Memo) == false)
{
objPaperAttachmentEN.dicFldComparisonOp.Add(conPaperAttachment.Memo, strComparisonOp);
}
else
{
objPaperAttachmentEN.dicFldComparisonOp[conPaperAttachment.Memo] = strComparisonOp;
}
}
return objPaperAttachmentEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objPaperAttachmentEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsPaperAttachmentEN objPaperAttachmentEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objPaperAttachmentEN.CheckPropertyNew();
clsPaperAttachmentEN objPaperAttachmentCond = new clsPaperAttachmentEN();
string strCondition = objPaperAttachmentCond
.SetPaperAttachmentId(objPaperAttachmentEN.PaperAttachmentId, "<>")
.SetPaperAttachmentName(objPaperAttachmentEN.PaperAttachmentName, "=")
.SetPaperId(objPaperAttachmentEN.PaperId, "=")
.GetCombineCondition();
objPaperAttachmentEN._IsCheckProperty = true;
bool bolIsExist = clsPaperAttachmentBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(PaperAttachmentName_PaperId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objPaperAttachmentEN.Update();
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
 /// <param name = "objPaperAttachment">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsPaperAttachmentEN objPaperAttachment)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsPaperAttachmentEN objPaperAttachmentCond = new clsPaperAttachmentEN();
string strCondition = objPaperAttachmentCond
.SetPaperAttachmentName(objPaperAttachment.PaperAttachmentName, "=")
.SetPaperId(objPaperAttachment.PaperId, "=")
.GetCombineCondition();
objPaperAttachment._IsCheckProperty = true;
bool bolIsExist = clsPaperAttachmentBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objPaperAttachment.PaperAttachmentId = clsPaperAttachmentBL.GetFirstID_S(strCondition);
objPaperAttachment.UpdateWithCondition(strCondition);
}
else
{
objPaperAttachment.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objPaperAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPaperAttachmentEN objPaperAttachmentEN)
{
 if (objPaperAttachmentEN.PaperAttachmentId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPaperAttachmentBL.PaperAttachmentDA.UpdateBySql2(objPaperAttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperAttachmentBL.ReFreshCache(objPaperAttachmentEN.IdCurrEduCls);

if (clsPaperAttachmentBL.relatedActions != null)
{
clsPaperAttachmentBL.relatedActions.UpdRelaTabDate(objPaperAttachmentEN.PaperAttachmentId, objPaperAttachmentEN.UpdUserId);
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
 /// <param name = "objPaperAttachmentEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPaperAttachmentEN objPaperAttachmentEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objPaperAttachmentEN.PaperAttachmentId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPaperAttachmentBL.PaperAttachmentDA.UpdateBySql2(objPaperAttachmentEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperAttachmentBL.ReFreshCache(objPaperAttachmentEN.IdCurrEduCls);

if (clsPaperAttachmentBL.relatedActions != null)
{
clsPaperAttachmentBL.relatedActions.UpdRelaTabDate(objPaperAttachmentEN.PaperAttachmentId, objPaperAttachmentEN.UpdUserId);
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
 /// <param name = "objPaperAttachmentEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPaperAttachmentEN objPaperAttachmentEN, string strWhereCond)
{
try
{
bool bolResult = clsPaperAttachmentBL.PaperAttachmentDA.UpdateBySqlWithCondition(objPaperAttachmentEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperAttachmentBL.ReFreshCache(objPaperAttachmentEN.IdCurrEduCls);

if (clsPaperAttachmentBL.relatedActions != null)
{
clsPaperAttachmentBL.relatedActions.UpdRelaTabDate(objPaperAttachmentEN.PaperAttachmentId, objPaperAttachmentEN.UpdUserId);
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
 /// <param name = "objPaperAttachmentEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPaperAttachmentEN objPaperAttachmentEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsPaperAttachmentBL.PaperAttachmentDA.UpdateBySqlWithConditionTransaction(objPaperAttachmentEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperAttachmentBL.ReFreshCache(objPaperAttachmentEN.IdCurrEduCls);

if (clsPaperAttachmentBL.relatedActions != null)
{
clsPaperAttachmentBL.relatedActions.UpdRelaTabDate(objPaperAttachmentEN.PaperAttachmentId, objPaperAttachmentEN.UpdUserId);
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
 /// <param name = "lngPaperAttachmentId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsPaperAttachmentEN objPaperAttachmentEN)
{
try
{
int intRecNum = clsPaperAttachmentBL.PaperAttachmentDA.DelRecord(objPaperAttachmentEN.PaperAttachmentId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperAttachmentBL.ReFreshCache(objPaperAttachmentEN.IdCurrEduCls);

if (clsPaperAttachmentBL.relatedActions != null)
{
clsPaperAttachmentBL.relatedActions.UpdRelaTabDate(objPaperAttachmentEN.PaperAttachmentId, objPaperAttachmentEN.UpdUserId);
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
 /// <param name = "objPaperAttachmentENS">源对象</param>
 /// <param name = "objPaperAttachmentENT">目标对象</param>
 public static void CopyTo(this clsPaperAttachmentEN objPaperAttachmentENS, clsPaperAttachmentEN objPaperAttachmentENT)
{
try
{
objPaperAttachmentENT.PaperAttachmentId = objPaperAttachmentENS.PaperAttachmentId; //论文附件Id
objPaperAttachmentENT.PaperAttachmentName = objPaperAttachmentENS.PaperAttachmentName; //附件名称
objPaperAttachmentENT.PaperId = objPaperAttachmentENS.PaperId; //论文Id
objPaperAttachmentENT.FilePath = objPaperAttachmentENS.FilePath; //文件路径
objPaperAttachmentENT.IdCurrEduCls = objPaperAttachmentENS.IdCurrEduCls; //教学班流水号
objPaperAttachmentENT.UpdUserId = objPaperAttachmentENS.UpdUserId; //修改用户Id
objPaperAttachmentENT.UpdDate = objPaperAttachmentENS.UpdDate; //修改日期
objPaperAttachmentENT.Memo = objPaperAttachmentENS.Memo; //备注
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
 /// <param name = "objPaperAttachmentENS">源对象</param>
 /// <returns>目标对象=>clsPaperAttachmentEN:objPaperAttachmentENT</returns>
 public static clsPaperAttachmentEN CopyTo(this clsPaperAttachmentEN objPaperAttachmentENS)
{
try
{
 clsPaperAttachmentEN objPaperAttachmentENT = new clsPaperAttachmentEN()
{
PaperAttachmentId = objPaperAttachmentENS.PaperAttachmentId, //论文附件Id
PaperAttachmentName = objPaperAttachmentENS.PaperAttachmentName, //附件名称
PaperId = objPaperAttachmentENS.PaperId, //论文Id
FilePath = objPaperAttachmentENS.FilePath, //文件路径
IdCurrEduCls = objPaperAttachmentENS.IdCurrEduCls, //教学班流水号
UpdUserId = objPaperAttachmentENS.UpdUserId, //修改用户Id
UpdDate = objPaperAttachmentENS.UpdDate, //修改日期
Memo = objPaperAttachmentENS.Memo, //备注
};
 return objPaperAttachmentENT;
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
public static void CheckPropertyNew(this clsPaperAttachmentEN objPaperAttachmentEN)
{
 clsPaperAttachmentBL.PaperAttachmentDA.CheckPropertyNew(objPaperAttachmentEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsPaperAttachmentEN objPaperAttachmentEN)
{
 clsPaperAttachmentBL.PaperAttachmentDA.CheckProperty4Condition(objPaperAttachmentEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsPaperAttachmentEN objPaperAttachmentCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objPaperAttachmentCond.IsUpdated(conPaperAttachment.PaperAttachmentId) == true)
{
string strComparisonOpPaperAttachmentId = objPaperAttachmentCond.dicFldComparisonOp[conPaperAttachment.PaperAttachmentId];
strWhereCond += string.Format(" And {0} {2} {1}", conPaperAttachment.PaperAttachmentId, objPaperAttachmentCond.PaperAttachmentId, strComparisonOpPaperAttachmentId);
}
if (objPaperAttachmentCond.IsUpdated(conPaperAttachment.PaperAttachmentName) == true)
{
string strComparisonOpPaperAttachmentName = objPaperAttachmentCond.dicFldComparisonOp[conPaperAttachment.PaperAttachmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperAttachment.PaperAttachmentName, objPaperAttachmentCond.PaperAttachmentName, strComparisonOpPaperAttachmentName);
}
if (objPaperAttachmentCond.IsUpdated(conPaperAttachment.PaperId) == true)
{
string strComparisonOpPaperId = objPaperAttachmentCond.dicFldComparisonOp[conPaperAttachment.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperAttachment.PaperId, objPaperAttachmentCond.PaperId, strComparisonOpPaperId);
}
if (objPaperAttachmentCond.IsUpdated(conPaperAttachment.FilePath) == true)
{
string strComparisonOpFilePath = objPaperAttachmentCond.dicFldComparisonOp[conPaperAttachment.FilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperAttachment.FilePath, objPaperAttachmentCond.FilePath, strComparisonOpFilePath);
}
if (objPaperAttachmentCond.IsUpdated(conPaperAttachment.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objPaperAttachmentCond.dicFldComparisonOp[conPaperAttachment.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperAttachment.IdCurrEduCls, objPaperAttachmentCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objPaperAttachmentCond.IsUpdated(conPaperAttachment.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objPaperAttachmentCond.dicFldComparisonOp[conPaperAttachment.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperAttachment.UpdUserId, objPaperAttachmentCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objPaperAttachmentCond.IsUpdated(conPaperAttachment.UpdDate) == true)
{
string strComparisonOpUpdDate = objPaperAttachmentCond.dicFldComparisonOp[conPaperAttachment.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperAttachment.UpdDate, objPaperAttachmentCond.UpdDate, strComparisonOpUpdDate);
}
if (objPaperAttachmentCond.IsUpdated(conPaperAttachment.Memo) == true)
{
string strComparisonOpMemo = objPaperAttachmentCond.dicFldComparisonOp[conPaperAttachment.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperAttachment.Memo, objPaperAttachmentCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--PaperAttachment(论文附件), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:PaperAttachmentName_PaperId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objPaperAttachmentEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsPaperAttachmentEN objPaperAttachmentEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objPaperAttachmentEN == null) return true;
if (objPaperAttachmentEN.PaperAttachmentId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objPaperAttachmentEN.PaperAttachmentName == null)
{
 sbCondition.AppendFormat(" and PaperAttachmentName is null", objPaperAttachmentEN.PaperAttachmentName);
}
else
{
 sbCondition.AppendFormat(" and PaperAttachmentName = '{0}'", objPaperAttachmentEN.PaperAttachmentName);
}
 if (objPaperAttachmentEN.PaperId == null)
{
 sbCondition.AppendFormat(" and PaperId is null", objPaperAttachmentEN.PaperId);
}
else
{
 sbCondition.AppendFormat(" and PaperId = '{0}'", objPaperAttachmentEN.PaperId);
}
if (clsPaperAttachmentBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("PaperAttachmentId !=  {0}", objPaperAttachmentEN.PaperAttachmentId);
 sbCondition.AppendFormat(" and PaperAttachmentName = '{0}'", objPaperAttachmentEN.PaperAttachmentName);
 sbCondition.AppendFormat(" and PaperId = '{0}'", objPaperAttachmentEN.PaperId);
if (clsPaperAttachmentBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--PaperAttachment(论文附件), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PaperAttachmentName_PaperId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objPaperAttachmentEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsPaperAttachmentEN objPaperAttachmentEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objPaperAttachmentEN == null) return "";
if (objPaperAttachmentEN.PaperAttachmentId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objPaperAttachmentEN.PaperAttachmentName == null)
{
 sbCondition.AppendFormat(" and PaperAttachmentName is null", objPaperAttachmentEN.PaperAttachmentName);
}
else
{
 sbCondition.AppendFormat(" and PaperAttachmentName = '{0}'", objPaperAttachmentEN.PaperAttachmentName);
}
 if (objPaperAttachmentEN.PaperId == null)
{
 sbCondition.AppendFormat(" and PaperId is null", objPaperAttachmentEN.PaperId);
}
else
{
 sbCondition.AppendFormat(" and PaperId = '{0}'", objPaperAttachmentEN.PaperId);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("PaperAttachmentId !=  {0}", objPaperAttachmentEN.PaperAttachmentId);
 sbCondition.AppendFormat(" and PaperAttachmentName = '{0}'", objPaperAttachmentEN.PaperAttachmentName);
 sbCondition.AppendFormat(" and PaperId = '{0}'", objPaperAttachmentEN.PaperId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_PaperAttachment
{
public virtual bool UpdRelaTabDate(long lngPaperAttachmentId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 论文附件(PaperAttachment)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsPaperAttachmentBL
{
public static RelatedActions_PaperAttachment relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsPaperAttachmentDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsPaperAttachmentDA PaperAttachmentDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsPaperAttachmentDA();
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
 public clsPaperAttachmentBL()
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
if (string.IsNullOrEmpty(clsPaperAttachmentEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsPaperAttachmentEN._ConnectString);
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
public static DataTable GetDataTable_PaperAttachment(string strWhereCond)
{
DataTable objDT;
try
{
objDT = PaperAttachmentDA.GetDataTable_PaperAttachment(strWhereCond);
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
objDT = PaperAttachmentDA.GetDataTable(strWhereCond);
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
objDT = PaperAttachmentDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = PaperAttachmentDA.GetDataTable(strWhereCond, strTabName);
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
objDT = PaperAttachmentDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = PaperAttachmentDA.GetDataTable_Top(objTopPara);
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
objDT = PaperAttachmentDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = PaperAttachmentDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = PaperAttachmentDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrPaperAttachmentIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsPaperAttachmentEN> GetObjLstByPaperAttachmentIdLst(List<long> arrPaperAttachmentIdLst)
{
List<clsPaperAttachmentEN> arrObjLst = new List<clsPaperAttachmentEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrPaperAttachmentIdLst);
 string strWhereCond = string.Format("PaperAttachmentId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperAttachmentEN objPaperAttachmentEN = new clsPaperAttachmentEN();
try
{
objPaperAttachmentEN.PaperAttachmentId = Int32.Parse(objRow[conPaperAttachment.PaperAttachmentId].ToString().Trim()); //论文附件Id
objPaperAttachmentEN.PaperAttachmentName = objRow[conPaperAttachment.PaperAttachmentName] == DBNull.Value ? null : objRow[conPaperAttachment.PaperAttachmentName].ToString().Trim(); //附件名称
objPaperAttachmentEN.PaperId = objRow[conPaperAttachment.PaperId] == DBNull.Value ? null : objRow[conPaperAttachment.PaperId].ToString().Trim(); //论文Id
objPaperAttachmentEN.FilePath = objRow[conPaperAttachment.FilePath].ToString().Trim(); //文件路径
objPaperAttachmentEN.IdCurrEduCls = objRow[conPaperAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[conPaperAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperAttachmentEN.UpdUserId = objRow[conPaperAttachment.UpdUserId] == DBNull.Value ? null : objRow[conPaperAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objPaperAttachmentEN.UpdDate = objRow[conPaperAttachment.UpdDate] == DBNull.Value ? null : objRow[conPaperAttachment.UpdDate].ToString().Trim(); //修改日期
objPaperAttachmentEN.Memo = objRow[conPaperAttachment.Memo] == DBNull.Value ? null : objRow[conPaperAttachment.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperAttachmentEN.PaperAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperAttachmentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPaperAttachmentIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsPaperAttachmentEN> GetObjLstByPaperAttachmentIdLstCache(List<long> arrPaperAttachmentIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsPaperAttachmentEN._CurrTabName, strIdCurrEduCls);
List<clsPaperAttachmentEN> arrPaperAttachmentObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsPaperAttachmentEN> arrPaperAttachmentObjLst_Sel =
arrPaperAttachmentObjLstCache
.Where(x => arrPaperAttachmentIdLst.Contains(x.PaperAttachmentId));
return arrPaperAttachmentObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsPaperAttachmentEN> GetObjLst(string strWhereCond)
{
List<clsPaperAttachmentEN> arrObjLst = new List<clsPaperAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperAttachmentEN objPaperAttachmentEN = new clsPaperAttachmentEN();
try
{
objPaperAttachmentEN.PaperAttachmentId = Int32.Parse(objRow[conPaperAttachment.PaperAttachmentId].ToString().Trim()); //论文附件Id
objPaperAttachmentEN.PaperAttachmentName = objRow[conPaperAttachment.PaperAttachmentName] == DBNull.Value ? null : objRow[conPaperAttachment.PaperAttachmentName].ToString().Trim(); //附件名称
objPaperAttachmentEN.PaperId = objRow[conPaperAttachment.PaperId] == DBNull.Value ? null : objRow[conPaperAttachment.PaperId].ToString().Trim(); //论文Id
objPaperAttachmentEN.FilePath = objRow[conPaperAttachment.FilePath].ToString().Trim(); //文件路径
objPaperAttachmentEN.IdCurrEduCls = objRow[conPaperAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[conPaperAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperAttachmentEN.UpdUserId = objRow[conPaperAttachment.UpdUserId] == DBNull.Value ? null : objRow[conPaperAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objPaperAttachmentEN.UpdDate = objRow[conPaperAttachment.UpdDate] == DBNull.Value ? null : objRow[conPaperAttachment.UpdDate].ToString().Trim(); //修改日期
objPaperAttachmentEN.Memo = objRow[conPaperAttachment.Memo] == DBNull.Value ? null : objRow[conPaperAttachment.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperAttachmentEN.PaperAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperAttachmentEN);
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
public static List<clsPaperAttachmentEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsPaperAttachmentEN> arrObjLst = new List<clsPaperAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperAttachmentEN objPaperAttachmentEN = new clsPaperAttachmentEN();
try
{
objPaperAttachmentEN.PaperAttachmentId = Int32.Parse(objRow[conPaperAttachment.PaperAttachmentId].ToString().Trim()); //论文附件Id
objPaperAttachmentEN.PaperAttachmentName = objRow[conPaperAttachment.PaperAttachmentName] == DBNull.Value ? null : objRow[conPaperAttachment.PaperAttachmentName].ToString().Trim(); //附件名称
objPaperAttachmentEN.PaperId = objRow[conPaperAttachment.PaperId] == DBNull.Value ? null : objRow[conPaperAttachment.PaperId].ToString().Trim(); //论文Id
objPaperAttachmentEN.FilePath = objRow[conPaperAttachment.FilePath].ToString().Trim(); //文件路径
objPaperAttachmentEN.IdCurrEduCls = objRow[conPaperAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[conPaperAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperAttachmentEN.UpdUserId = objRow[conPaperAttachment.UpdUserId] == DBNull.Value ? null : objRow[conPaperAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objPaperAttachmentEN.UpdDate = objRow[conPaperAttachment.UpdDate] == DBNull.Value ? null : objRow[conPaperAttachment.UpdDate].ToString().Trim(); //修改日期
objPaperAttachmentEN.Memo = objRow[conPaperAttachment.Memo] == DBNull.Value ? null : objRow[conPaperAttachment.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperAttachmentEN.PaperAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperAttachmentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objPaperAttachmentCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsPaperAttachmentEN> GetSubObjLstCache(clsPaperAttachmentEN objPaperAttachmentCond)
{
 string strIdCurrEduCls = objPaperAttachmentCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsPaperAttachmentBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsPaperAttachmentEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsPaperAttachmentEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPaperAttachment.AttributeName)
{
if (objPaperAttachmentCond.IsUpdated(strFldName) == false) continue;
if (objPaperAttachmentCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPaperAttachmentCond[strFldName].ToString());
}
else
{
if (objPaperAttachmentCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPaperAttachmentCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPaperAttachmentCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPaperAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPaperAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPaperAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPaperAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPaperAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPaperAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPaperAttachmentCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPaperAttachmentCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPaperAttachmentCond[strFldName]));
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
public static List<clsPaperAttachmentEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsPaperAttachmentEN> arrObjLst = new List<clsPaperAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperAttachmentEN objPaperAttachmentEN = new clsPaperAttachmentEN();
try
{
objPaperAttachmentEN.PaperAttachmentId = Int32.Parse(objRow[conPaperAttachment.PaperAttachmentId].ToString().Trim()); //论文附件Id
objPaperAttachmentEN.PaperAttachmentName = objRow[conPaperAttachment.PaperAttachmentName] == DBNull.Value ? null : objRow[conPaperAttachment.PaperAttachmentName].ToString().Trim(); //附件名称
objPaperAttachmentEN.PaperId = objRow[conPaperAttachment.PaperId] == DBNull.Value ? null : objRow[conPaperAttachment.PaperId].ToString().Trim(); //论文Id
objPaperAttachmentEN.FilePath = objRow[conPaperAttachment.FilePath].ToString().Trim(); //文件路径
objPaperAttachmentEN.IdCurrEduCls = objRow[conPaperAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[conPaperAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperAttachmentEN.UpdUserId = objRow[conPaperAttachment.UpdUserId] == DBNull.Value ? null : objRow[conPaperAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objPaperAttachmentEN.UpdDate = objRow[conPaperAttachment.UpdDate] == DBNull.Value ? null : objRow[conPaperAttachment.UpdDate].ToString().Trim(); //修改日期
objPaperAttachmentEN.Memo = objRow[conPaperAttachment.Memo] == DBNull.Value ? null : objRow[conPaperAttachment.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperAttachmentEN.PaperAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperAttachmentEN);
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
public static List<clsPaperAttachmentEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsPaperAttachmentEN> arrObjLst = new List<clsPaperAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperAttachmentEN objPaperAttachmentEN = new clsPaperAttachmentEN();
try
{
objPaperAttachmentEN.PaperAttachmentId = Int32.Parse(objRow[conPaperAttachment.PaperAttachmentId].ToString().Trim()); //论文附件Id
objPaperAttachmentEN.PaperAttachmentName = objRow[conPaperAttachment.PaperAttachmentName] == DBNull.Value ? null : objRow[conPaperAttachment.PaperAttachmentName].ToString().Trim(); //附件名称
objPaperAttachmentEN.PaperId = objRow[conPaperAttachment.PaperId] == DBNull.Value ? null : objRow[conPaperAttachment.PaperId].ToString().Trim(); //论文Id
objPaperAttachmentEN.FilePath = objRow[conPaperAttachment.FilePath].ToString().Trim(); //文件路径
objPaperAttachmentEN.IdCurrEduCls = objRow[conPaperAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[conPaperAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperAttachmentEN.UpdUserId = objRow[conPaperAttachment.UpdUserId] == DBNull.Value ? null : objRow[conPaperAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objPaperAttachmentEN.UpdDate = objRow[conPaperAttachment.UpdDate] == DBNull.Value ? null : objRow[conPaperAttachment.UpdDate].ToString().Trim(); //修改日期
objPaperAttachmentEN.Memo = objRow[conPaperAttachment.Memo] == DBNull.Value ? null : objRow[conPaperAttachment.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperAttachmentEN.PaperAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperAttachmentEN);
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
List<clsPaperAttachmentEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsPaperAttachmentEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsPaperAttachmentEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsPaperAttachmentEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsPaperAttachmentEN> arrObjLst = new List<clsPaperAttachmentEN>(); 
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
	clsPaperAttachmentEN objPaperAttachmentEN = new clsPaperAttachmentEN();
try
{
objPaperAttachmentEN.PaperAttachmentId = Int32.Parse(objRow[conPaperAttachment.PaperAttachmentId].ToString().Trim()); //论文附件Id
objPaperAttachmentEN.PaperAttachmentName = objRow[conPaperAttachment.PaperAttachmentName] == DBNull.Value ? null : objRow[conPaperAttachment.PaperAttachmentName].ToString().Trim(); //附件名称
objPaperAttachmentEN.PaperId = objRow[conPaperAttachment.PaperId] == DBNull.Value ? null : objRow[conPaperAttachment.PaperId].ToString().Trim(); //论文Id
objPaperAttachmentEN.FilePath = objRow[conPaperAttachment.FilePath].ToString().Trim(); //文件路径
objPaperAttachmentEN.IdCurrEduCls = objRow[conPaperAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[conPaperAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperAttachmentEN.UpdUserId = objRow[conPaperAttachment.UpdUserId] == DBNull.Value ? null : objRow[conPaperAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objPaperAttachmentEN.UpdDate = objRow[conPaperAttachment.UpdDate] == DBNull.Value ? null : objRow[conPaperAttachment.UpdDate].ToString().Trim(); //修改日期
objPaperAttachmentEN.Memo = objRow[conPaperAttachment.Memo] == DBNull.Value ? null : objRow[conPaperAttachment.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperAttachmentEN.PaperAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperAttachmentEN);
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
public static List<clsPaperAttachmentEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsPaperAttachmentEN> arrObjLst = new List<clsPaperAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperAttachmentEN objPaperAttachmentEN = new clsPaperAttachmentEN();
try
{
objPaperAttachmentEN.PaperAttachmentId = Int32.Parse(objRow[conPaperAttachment.PaperAttachmentId].ToString().Trim()); //论文附件Id
objPaperAttachmentEN.PaperAttachmentName = objRow[conPaperAttachment.PaperAttachmentName] == DBNull.Value ? null : objRow[conPaperAttachment.PaperAttachmentName].ToString().Trim(); //附件名称
objPaperAttachmentEN.PaperId = objRow[conPaperAttachment.PaperId] == DBNull.Value ? null : objRow[conPaperAttachment.PaperId].ToString().Trim(); //论文Id
objPaperAttachmentEN.FilePath = objRow[conPaperAttachment.FilePath].ToString().Trim(); //文件路径
objPaperAttachmentEN.IdCurrEduCls = objRow[conPaperAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[conPaperAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperAttachmentEN.UpdUserId = objRow[conPaperAttachment.UpdUserId] == DBNull.Value ? null : objRow[conPaperAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objPaperAttachmentEN.UpdDate = objRow[conPaperAttachment.UpdDate] == DBNull.Value ? null : objRow[conPaperAttachment.UpdDate].ToString().Trim(); //修改日期
objPaperAttachmentEN.Memo = objRow[conPaperAttachment.Memo] == DBNull.Value ? null : objRow[conPaperAttachment.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperAttachmentEN.PaperAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperAttachmentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsPaperAttachmentEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsPaperAttachmentEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsPaperAttachmentEN> arrObjLst = new List<clsPaperAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperAttachmentEN objPaperAttachmentEN = new clsPaperAttachmentEN();
try
{
objPaperAttachmentEN.PaperAttachmentId = Int32.Parse(objRow[conPaperAttachment.PaperAttachmentId].ToString().Trim()); //论文附件Id
objPaperAttachmentEN.PaperAttachmentName = objRow[conPaperAttachment.PaperAttachmentName] == DBNull.Value ? null : objRow[conPaperAttachment.PaperAttachmentName].ToString().Trim(); //附件名称
objPaperAttachmentEN.PaperId = objRow[conPaperAttachment.PaperId] == DBNull.Value ? null : objRow[conPaperAttachment.PaperId].ToString().Trim(); //论文Id
objPaperAttachmentEN.FilePath = objRow[conPaperAttachment.FilePath].ToString().Trim(); //文件路径
objPaperAttachmentEN.IdCurrEduCls = objRow[conPaperAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[conPaperAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperAttachmentEN.UpdUserId = objRow[conPaperAttachment.UpdUserId] == DBNull.Value ? null : objRow[conPaperAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objPaperAttachmentEN.UpdDate = objRow[conPaperAttachment.UpdDate] == DBNull.Value ? null : objRow[conPaperAttachment.UpdDate].ToString().Trim(); //修改日期
objPaperAttachmentEN.Memo = objRow[conPaperAttachment.Memo] == DBNull.Value ? null : objRow[conPaperAttachment.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperAttachmentEN.PaperAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperAttachmentEN);
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
public static List<clsPaperAttachmentEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsPaperAttachmentEN> arrObjLst = new List<clsPaperAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperAttachmentEN objPaperAttachmentEN = new clsPaperAttachmentEN();
try
{
objPaperAttachmentEN.PaperAttachmentId = Int32.Parse(objRow[conPaperAttachment.PaperAttachmentId].ToString().Trim()); //论文附件Id
objPaperAttachmentEN.PaperAttachmentName = objRow[conPaperAttachment.PaperAttachmentName] == DBNull.Value ? null : objRow[conPaperAttachment.PaperAttachmentName].ToString().Trim(); //附件名称
objPaperAttachmentEN.PaperId = objRow[conPaperAttachment.PaperId] == DBNull.Value ? null : objRow[conPaperAttachment.PaperId].ToString().Trim(); //论文Id
objPaperAttachmentEN.FilePath = objRow[conPaperAttachment.FilePath].ToString().Trim(); //文件路径
objPaperAttachmentEN.IdCurrEduCls = objRow[conPaperAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[conPaperAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperAttachmentEN.UpdUserId = objRow[conPaperAttachment.UpdUserId] == DBNull.Value ? null : objRow[conPaperAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objPaperAttachmentEN.UpdDate = objRow[conPaperAttachment.UpdDate] == DBNull.Value ? null : objRow[conPaperAttachment.UpdDate].ToString().Trim(); //修改日期
objPaperAttachmentEN.Memo = objRow[conPaperAttachment.Memo] == DBNull.Value ? null : objRow[conPaperAttachment.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperAttachmentEN.PaperAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperAttachmentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsPaperAttachmentEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsPaperAttachmentEN> arrObjLst = new List<clsPaperAttachmentEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperAttachmentEN objPaperAttachmentEN = new clsPaperAttachmentEN();
try
{
objPaperAttachmentEN.PaperAttachmentId = Int32.Parse(objRow[conPaperAttachment.PaperAttachmentId].ToString().Trim()); //论文附件Id
objPaperAttachmentEN.PaperAttachmentName = objRow[conPaperAttachment.PaperAttachmentName] == DBNull.Value ? null : objRow[conPaperAttachment.PaperAttachmentName].ToString().Trim(); //附件名称
objPaperAttachmentEN.PaperId = objRow[conPaperAttachment.PaperId] == DBNull.Value ? null : objRow[conPaperAttachment.PaperId].ToString().Trim(); //论文Id
objPaperAttachmentEN.FilePath = objRow[conPaperAttachment.FilePath].ToString().Trim(); //文件路径
objPaperAttachmentEN.IdCurrEduCls = objRow[conPaperAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[conPaperAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperAttachmentEN.UpdUserId = objRow[conPaperAttachment.UpdUserId] == DBNull.Value ? null : objRow[conPaperAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objPaperAttachmentEN.UpdDate = objRow[conPaperAttachment.UpdDate] == DBNull.Value ? null : objRow[conPaperAttachment.UpdDate].ToString().Trim(); //修改日期
objPaperAttachmentEN.Memo = objRow[conPaperAttachment.Memo] == DBNull.Value ? null : objRow[conPaperAttachment.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperAttachmentEN.PaperAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperAttachmentEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objPaperAttachmentEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetPaperAttachment(ref clsPaperAttachmentEN objPaperAttachmentEN)
{
bool bolResult = PaperAttachmentDA.GetPaperAttachment(ref objPaperAttachmentEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngPaperAttachmentId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPaperAttachmentEN GetObjByPaperAttachmentId(long lngPaperAttachmentId)
{
clsPaperAttachmentEN objPaperAttachmentEN = PaperAttachmentDA.GetObjByPaperAttachmentId(lngPaperAttachmentId);
return objPaperAttachmentEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsPaperAttachmentEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsPaperAttachmentEN objPaperAttachmentEN = PaperAttachmentDA.GetFirstObj(strWhereCond);
 return objPaperAttachmentEN;
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
public static clsPaperAttachmentEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsPaperAttachmentEN objPaperAttachmentEN = PaperAttachmentDA.GetObjByDataRow(objRow);
 return objPaperAttachmentEN;
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
public static clsPaperAttachmentEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsPaperAttachmentEN objPaperAttachmentEN = PaperAttachmentDA.GetObjByDataRow(objRow);
 return objPaperAttachmentEN;
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
 /// <param name = "lngPaperAttachmentId">所给的关键字</param>
 /// <param name = "lstPaperAttachmentObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPaperAttachmentEN GetObjByPaperAttachmentIdFromList(long lngPaperAttachmentId, List<clsPaperAttachmentEN> lstPaperAttachmentObjLst)
{
foreach (clsPaperAttachmentEN objPaperAttachmentEN in lstPaperAttachmentObjLst)
{
if (objPaperAttachmentEN.PaperAttachmentId == lngPaperAttachmentId)
{
return objPaperAttachmentEN;
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
 long lngPaperAttachmentId;
 try
 {
 lngPaperAttachmentId = new clsPaperAttachmentDA().GetFirstID(strWhereCond);
 return lngPaperAttachmentId;
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
 arrList = PaperAttachmentDA.GetID(strWhereCond);
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
bool bolIsExist = PaperAttachmentDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngPaperAttachmentId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngPaperAttachmentId)
{
//检测记录是否存在
bool bolIsExist = PaperAttachmentDA.IsExist(lngPaperAttachmentId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngPaperAttachmentId">论文附件Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngPaperAttachmentId, string strOpUser)
{
clsPaperAttachmentEN objPaperAttachmentEN = clsPaperAttachmentBL.GetObjByPaperAttachmentId(lngPaperAttachmentId);
objPaperAttachmentEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objPaperAttachmentEN.UpdUserId = strOpUser;
return clsPaperAttachmentBL.UpdateBySql2(objPaperAttachmentEN);
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
 bolIsExist = clsPaperAttachmentDA.IsExistTable();
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
 bolIsExist = PaperAttachmentDA.IsExistTable(strTabName);
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
 /// <param name = "objPaperAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsPaperAttachmentEN objPaperAttachmentEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objPaperAttachmentEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!附件名称 = [{0}],论文Id = [{1}]的数据已经存在!(in clsPaperAttachmentBL.AddNewRecordBySql2)", objPaperAttachmentEN.PaperAttachmentName,objPaperAttachmentEN.PaperId);
throw new Exception(strMsg);
}
try
{
bool bolResult = PaperAttachmentDA.AddNewRecordBySQL2(objPaperAttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperAttachmentBL.ReFreshCache(objPaperAttachmentEN.IdCurrEduCls);

if (clsPaperAttachmentBL.relatedActions != null)
{
clsPaperAttachmentBL.relatedActions.UpdRelaTabDate(objPaperAttachmentEN.PaperAttachmentId, objPaperAttachmentEN.UpdUserId);
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
 /// <param name = "objPaperAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsPaperAttachmentEN objPaperAttachmentEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objPaperAttachmentEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!附件名称 = [{0}],论文Id = [{1}]的数据已经存在!(in clsPaperAttachmentBL.AddNewRecordBySql2WithReturnKey)", objPaperAttachmentEN.PaperAttachmentName,objPaperAttachmentEN.PaperId);
throw new Exception(strMsg);
}
try
{
string strKey = PaperAttachmentDA.AddNewRecordBySQL2WithReturnKey(objPaperAttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperAttachmentBL.ReFreshCache(objPaperAttachmentEN.IdCurrEduCls);

if (clsPaperAttachmentBL.relatedActions != null)
{
clsPaperAttachmentBL.relatedActions.UpdRelaTabDate(objPaperAttachmentEN.PaperAttachmentId, objPaperAttachmentEN.UpdUserId);
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
 /// <param name = "objPaperAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsPaperAttachmentEN objPaperAttachmentEN)
{
try
{
bool bolResult = PaperAttachmentDA.Update(objPaperAttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperAttachmentBL.ReFreshCache(objPaperAttachmentEN.IdCurrEduCls);

if (clsPaperAttachmentBL.relatedActions != null)
{
clsPaperAttachmentBL.relatedActions.UpdRelaTabDate(objPaperAttachmentEN.PaperAttachmentId, objPaperAttachmentEN.UpdUserId);
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
 /// <param name = "objPaperAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsPaperAttachmentEN objPaperAttachmentEN)
{
 if (objPaperAttachmentEN.PaperAttachmentId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = PaperAttachmentDA.UpdateBySql2(objPaperAttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperAttachmentBL.ReFreshCache(objPaperAttachmentEN.IdCurrEduCls);

if (clsPaperAttachmentBL.relatedActions != null)
{
clsPaperAttachmentBL.relatedActions.UpdRelaTabDate(objPaperAttachmentEN.PaperAttachmentId, objPaperAttachmentEN.UpdUserId);
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
 /// <param name = "lngPaperAttachmentId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngPaperAttachmentId)
{
try
{
 clsPaperAttachmentEN objPaperAttachmentEN = clsPaperAttachmentBL.GetObjByPaperAttachmentId(lngPaperAttachmentId);

if (clsPaperAttachmentBL.relatedActions != null)
{
clsPaperAttachmentBL.relatedActions.UpdRelaTabDate(objPaperAttachmentEN.PaperAttachmentId, objPaperAttachmentEN.UpdUserId);
}
if (objPaperAttachmentEN != null)
{
int intRecNum = PaperAttachmentDA.DelRecord(lngPaperAttachmentId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objPaperAttachmentEN.IdCurrEduCls);
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
/// <param name="lngPaperAttachmentId">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(long lngPaperAttachmentId , string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPaperAttachmentDA.GetSpecSQLObj();
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
//删除与表:[PaperAttachment]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conPaperAttachment.PaperAttachmentId,
//lngPaperAttachmentId);
//        clsPaperAttachmentBL.DelPaperAttachmentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPaperAttachmentBL.DelRecord(lngPaperAttachmentId, strIdCurrEduCls, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPaperAttachmentBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngPaperAttachmentId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngPaperAttachmentId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngPaperAttachmentId, string strIdCurrEduCls, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsPaperAttachmentBL.relatedActions != null)
{
clsPaperAttachmentBL.relatedActions.UpdRelaTabDate(lngPaperAttachmentId, "UpdRelaTabDate");
}
bool bolResult = PaperAttachmentDA.DelRecord(lngPaperAttachmentId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrPaperAttachmentIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelPaperAttachments(List<string> arrPaperAttachmentIdLst)
{
if (arrPaperAttachmentIdLst.Count == 0) return 0;
try
{
if (clsPaperAttachmentBL.relatedActions != null)
{
foreach (var strPaperAttachmentId in arrPaperAttachmentIdLst)
{
long lngPaperAttachmentId = long.Parse(strPaperAttachmentId);
clsPaperAttachmentBL.relatedActions.UpdRelaTabDate(lngPaperAttachmentId, "UpdRelaTabDate");
}
}
 clsPaperAttachmentEN objPaperAttachmentEN = clsPaperAttachmentBL.GetObjByPaperAttachmentId(long.Parse(arrPaperAttachmentIdLst[0]));
int intDelRecNum = PaperAttachmentDA.DelPaperAttachment(arrPaperAttachmentIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objPaperAttachmentEN.IdCurrEduCls);
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
public static int DelPaperAttachmentsByCond(string strWhereCond)
{
try
{
if (clsPaperAttachmentBL.relatedActions != null)
{
List<string> arrPaperAttachmentId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strPaperAttachmentId in arrPaperAttachmentId)
{
long lngPaperAttachmentId = long.Parse(strPaperAttachmentId);
clsPaperAttachmentBL.relatedActions.UpdRelaTabDate(lngPaperAttachmentId, "UpdRelaTabDate");
}
}
List<string> arrIdCurrEduCls = GetFldValue(conPaperAttachment.IdCurrEduCls, strWhereCond);
int intRecNum = PaperAttachmentDA.DelPaperAttachment(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[PaperAttachment]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngPaperAttachmentId">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngPaperAttachmentId, string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPaperAttachmentDA.GetSpecSQLObj();
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
//删除与表:[PaperAttachment]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPaperAttachmentBL.DelRecord(lngPaperAttachmentId, strIdCurrEduCls, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPaperAttachmentBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngPaperAttachmentId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objPaperAttachmentENS">源对象</param>
 /// <param name = "objPaperAttachmentENT">目标对象</param>
 public static void CopyTo(clsPaperAttachmentEN objPaperAttachmentENS, clsPaperAttachmentEN objPaperAttachmentENT)
{
try
{
objPaperAttachmentENT.PaperAttachmentId = objPaperAttachmentENS.PaperAttachmentId; //论文附件Id
objPaperAttachmentENT.PaperAttachmentName = objPaperAttachmentENS.PaperAttachmentName; //附件名称
objPaperAttachmentENT.PaperId = objPaperAttachmentENS.PaperId; //论文Id
objPaperAttachmentENT.FilePath = objPaperAttachmentENS.FilePath; //文件路径
objPaperAttachmentENT.IdCurrEduCls = objPaperAttachmentENS.IdCurrEduCls; //教学班流水号
objPaperAttachmentENT.UpdUserId = objPaperAttachmentENS.UpdUserId; //修改用户Id
objPaperAttachmentENT.UpdDate = objPaperAttachmentENS.UpdDate; //修改日期
objPaperAttachmentENT.Memo = objPaperAttachmentENS.Memo; //备注
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
 /// <param name = "objPaperAttachmentEN">源简化对象</param>
 public static void SetUpdFlag(clsPaperAttachmentEN objPaperAttachmentEN)
{
try
{
objPaperAttachmentEN.ClearUpdateState();
   string strsfUpdFldSetStr = objPaperAttachmentEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conPaperAttachment.PaperAttachmentId, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperAttachmentEN.PaperAttachmentId = objPaperAttachmentEN.PaperAttachmentId; //论文附件Id
}
if (arrFldSet.Contains(conPaperAttachment.PaperAttachmentName, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperAttachmentEN.PaperAttachmentName = objPaperAttachmentEN.PaperAttachmentName == "[null]" ? null :  objPaperAttachmentEN.PaperAttachmentName; //附件名称
}
if (arrFldSet.Contains(conPaperAttachment.PaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperAttachmentEN.PaperId = objPaperAttachmentEN.PaperId == "[null]" ? null :  objPaperAttachmentEN.PaperId; //论文Id
}
if (arrFldSet.Contains(conPaperAttachment.FilePath, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperAttachmentEN.FilePath = objPaperAttachmentEN.FilePath; //文件路径
}
if (arrFldSet.Contains(conPaperAttachment.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperAttachmentEN.IdCurrEduCls = objPaperAttachmentEN.IdCurrEduCls == "[null]" ? null :  objPaperAttachmentEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conPaperAttachment.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperAttachmentEN.UpdUserId = objPaperAttachmentEN.UpdUserId == "[null]" ? null :  objPaperAttachmentEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conPaperAttachment.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperAttachmentEN.UpdDate = objPaperAttachmentEN.UpdDate == "[null]" ? null :  objPaperAttachmentEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conPaperAttachment.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperAttachmentEN.Memo = objPaperAttachmentEN.Memo == "[null]" ? null :  objPaperAttachmentEN.Memo; //备注
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
 /// <param name = "objPaperAttachmentEN">源简化对象</param>
 public static void AccessFldValueNull(clsPaperAttachmentEN objPaperAttachmentEN)
{
try
{
if (objPaperAttachmentEN.PaperAttachmentName == "[null]") objPaperAttachmentEN.PaperAttachmentName = null; //附件名称
if (objPaperAttachmentEN.PaperId == "[null]") objPaperAttachmentEN.PaperId = null; //论文Id
if (objPaperAttachmentEN.IdCurrEduCls == "[null]") objPaperAttachmentEN.IdCurrEduCls = null; //教学班流水号
if (objPaperAttachmentEN.UpdUserId == "[null]") objPaperAttachmentEN.UpdUserId = null; //修改用户Id
if (objPaperAttachmentEN.UpdDate == "[null]") objPaperAttachmentEN.UpdDate = null; //修改日期
if (objPaperAttachmentEN.Memo == "[null]") objPaperAttachmentEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsPaperAttachmentEN objPaperAttachmentEN)
{
 PaperAttachmentDA.CheckPropertyNew(objPaperAttachmentEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsPaperAttachmentEN objPaperAttachmentEN)
{
 PaperAttachmentDA.CheckProperty4Condition(objPaperAttachmentEN);
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
if (clsPaperAttachmentBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperAttachmentBL没有刷新缓存机制(clsPaperAttachmentBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PaperAttachmentId");
//if (arrPaperAttachmentObjLstCache == null)
//{
//arrPaperAttachmentObjLstCache = PaperAttachmentDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngPaperAttachmentId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPaperAttachmentEN GetObjByPaperAttachmentIdCache(long lngPaperAttachmentId, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsPaperAttachmentEN._CurrTabName, strIdCurrEduCls);
List<clsPaperAttachmentEN> arrPaperAttachmentObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsPaperAttachmentEN> arrPaperAttachmentObjLst_Sel =
arrPaperAttachmentObjLstCache
.Where(x=> x.PaperAttachmentId == lngPaperAttachmentId 
);
if (arrPaperAttachmentObjLst_Sel.Count() == 0)
{
   clsPaperAttachmentEN obj = clsPaperAttachmentBL.GetObjByPaperAttachmentId(lngPaperAttachmentId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngPaperAttachmentId, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrPaperAttachmentObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPaperAttachmentEN> GetAllPaperAttachmentObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsPaperAttachmentEN> arrPaperAttachmentObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrPaperAttachmentObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPaperAttachmentEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsPaperAttachmentEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsPaperAttachmentEN> arrPaperAttachmentObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrPaperAttachmentObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsPaperAttachmentEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clsPaperAttachmentEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsPaperAttachmentEN._RefreshTimeLst.Count == 0) return "";
return clsPaperAttachmentEN._RefreshTimeLst[clsPaperAttachmentEN._RefreshTimeLst.Count - 1];
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
if (clsPaperAttachmentBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsPaperAttachmentEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clsPaperAttachmentEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsPaperAttachmentBL.objCommFun4BL.ReFreshCache(strIdCurrEduCls);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--PaperAttachment(论文附件)
 /// 唯一性条件:PaperAttachmentName_PaperId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objPaperAttachmentEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsPaperAttachmentEN objPaperAttachmentEN)
{
//检测记录是否存在
string strResult = PaperAttachmentDA.GetUniCondStr(objPaperAttachmentEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngPaperAttachmentId, string strIdCurrEduCls)
{
if (strInFldName != conPaperAttachment.PaperAttachmentId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conPaperAttachment.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conPaperAttachment.AttributeName));
throw new Exception(strMsg);
}
var objPaperAttachment = clsPaperAttachmentBL.GetObjByPaperAttachmentIdCache(lngPaperAttachmentId, strIdCurrEduCls);
if (objPaperAttachment == null) return "";
return objPaperAttachment[strOutFldName].ToString();
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
int intRecCount = clsPaperAttachmentDA.GetRecCount(strTabName);
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
int intRecCount = clsPaperAttachmentDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsPaperAttachmentDA.GetRecCount();
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
int intRecCount = clsPaperAttachmentDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objPaperAttachmentCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsPaperAttachmentEN objPaperAttachmentCond)
{
 string strIdCurrEduCls = objPaperAttachmentCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsPaperAttachmentBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsPaperAttachmentEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsPaperAttachmentEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPaperAttachment.AttributeName)
{
if (objPaperAttachmentCond.IsUpdated(strFldName) == false) continue;
if (objPaperAttachmentCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPaperAttachmentCond[strFldName].ToString());
}
else
{
if (objPaperAttachmentCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPaperAttachmentCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPaperAttachmentCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPaperAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPaperAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPaperAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPaperAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPaperAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPaperAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPaperAttachmentCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPaperAttachmentCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPaperAttachmentCond[strFldName]));
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
 List<string> arrList = clsPaperAttachmentDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = PaperAttachmentDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = PaperAttachmentDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = PaperAttachmentDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsPaperAttachmentDA.SetFldValue(clsPaperAttachmentEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = PaperAttachmentDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsPaperAttachmentDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsPaperAttachmentDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsPaperAttachmentDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[PaperAttachment] "); 
 strCreateTabCode.Append(" ( "); 
 // /**论文附件Id*/ 
 strCreateTabCode.Append(" PaperAttachmentId bigint primary key identity, "); 
 // /**附件名称*/ 
 strCreateTabCode.Append(" PaperAttachmentName varchar(200) Null, "); 
 // /**论文Id*/ 
 strCreateTabCode.Append(" PaperId char(8) Null, "); 
 // /**文件路径*/ 
 strCreateTabCode.Append(" FilePath varchar(500) not Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**论文标题作者*/ 
 strCreateTabCode.Append(" PaperTitleAuthor varchar(500) not Null, "); 
 // /**教学班名*/ 
 strCreateTabCode.Append(" EduClsName varchar(100) not Null, "); 
 // /**用户名*/ 
 strCreateTabCode.Append(" UserName varchar(30) not Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 论文附件(PaperAttachment)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4PaperAttachment : clsCommFun4BLV2
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
clsPaperAttachmentBL.ReFreshThisCache(strIdCurrEduCls);
}
}

}