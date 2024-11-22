
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsConceptAttachmentBL
 表名:ConceptAttachment(01120603)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:15:47
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
public static class  clsConceptAttachmentBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngConceptAttachmentId">表关键字</param>
 /// <returns>表对象</returns>
public static clsConceptAttachmentEN GetObj(this K_ConceptAttachmentId_ConceptAttachment myKey)
{
clsConceptAttachmentEN objConceptAttachmentEN = clsConceptAttachmentBL.ConceptAttachmentDA.GetObjByConceptAttachmentId(myKey.Value);
return objConceptAttachmentEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objConceptAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsConceptAttachmentEN objConceptAttachmentEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objConceptAttachmentEN) == false)
{
var strMsg = string.Format("记录已经存在!概念附件Id = [{0}],概念Id = [{1}]的数据已经存在!(in clsConceptAttachmentBL.AddNewRecord)", objConceptAttachmentEN.ConceptAttachmentId,objConceptAttachmentEN.ConceptId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsConceptAttachmentBL.ConceptAttachmentDA.AddNewRecordBySQL2(objConceptAttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConceptAttachmentBL.ReFreshCache(objConceptAttachmentEN.IdCurrEduCls);

if (clsConceptAttachmentBL.relatedActions != null)
{
clsConceptAttachmentBL.relatedActions.UpdRelaTabDate(objConceptAttachmentEN.ConceptAttachmentId, "SetUpdDate");
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
public static bool AddRecordEx(this clsConceptAttachmentEN objConceptAttachmentEN, bool bolIsNeedCheckUniqueness = true)
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
objConceptAttachmentEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objConceptAttachmentEN.CheckUniqueness() == false)
{
strMsg = string.Format("(概念附件Id(ConceptAttachmentId)=[{0}],概念Id(ConceptId)=[{1}])已经存在,不能重复!", objConceptAttachmentEN.ConceptAttachmentId, objConceptAttachmentEN.ConceptId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objConceptAttachmentEN.AddNewRecord();
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
 /// <param name = "objConceptAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsConceptAttachmentEN objConceptAttachmentEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objConceptAttachmentEN) == false)
{
var strMsg = string.Format("记录已经存在!概念附件Id = [{0}],概念Id = [{1}]的数据已经存在!(in clsConceptAttachmentBL.AddNewRecordWithReturnKey)", objConceptAttachmentEN.ConceptAttachmentId,objConceptAttachmentEN.ConceptId);
throw new Exception(strMsg);
}
try
{
string strKey = clsConceptAttachmentBL.ConceptAttachmentDA.AddNewRecordBySQL2WithReturnKey(objConceptAttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConceptAttachmentBL.ReFreshCache(objConceptAttachmentEN.IdCurrEduCls);

if (clsConceptAttachmentBL.relatedActions != null)
{
clsConceptAttachmentBL.relatedActions.UpdRelaTabDate(objConceptAttachmentEN.ConceptAttachmentId, "SetUpdDate");
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
 /// <param name = "objConceptAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConceptAttachmentEN SetConceptAttachmentId(this clsConceptAttachmentEN objConceptAttachmentEN, long lngConceptAttachmentId, string strComparisonOp="")
	{
objConceptAttachmentEN.ConceptAttachmentId = lngConceptAttachmentId; //概念附件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConceptAttachmentEN.dicFldComparisonOp.ContainsKey(conConceptAttachment.ConceptAttachmentId) == false)
{
objConceptAttachmentEN.dicFldComparisonOp.Add(conConceptAttachment.ConceptAttachmentId, strComparisonOp);
}
else
{
objConceptAttachmentEN.dicFldComparisonOp[conConceptAttachment.ConceptAttachmentId] = strComparisonOp;
}
}
return objConceptAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConceptAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConceptAttachmentEN SetConceptAttachmentName(this clsConceptAttachmentEN objConceptAttachmentEN, string strConceptAttachmentName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConceptAttachmentName, 200, conConceptAttachment.ConceptAttachmentName);
}
objConceptAttachmentEN.ConceptAttachmentName = strConceptAttachmentName; //附件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConceptAttachmentEN.dicFldComparisonOp.ContainsKey(conConceptAttachment.ConceptAttachmentName) == false)
{
objConceptAttachmentEN.dicFldComparisonOp.Add(conConceptAttachment.ConceptAttachmentName, strComparisonOp);
}
else
{
objConceptAttachmentEN.dicFldComparisonOp[conConceptAttachment.ConceptAttachmentName] = strComparisonOp;
}
}
return objConceptAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConceptAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConceptAttachmentEN SetConceptId(this clsConceptAttachmentEN objConceptAttachmentEN, string strConceptId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strConceptId, conConceptAttachment.ConceptId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConceptId, 8, conConceptAttachment.ConceptId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strConceptId, 8, conConceptAttachment.ConceptId);
}
objConceptAttachmentEN.ConceptId = strConceptId; //概念Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConceptAttachmentEN.dicFldComparisonOp.ContainsKey(conConceptAttachment.ConceptId) == false)
{
objConceptAttachmentEN.dicFldComparisonOp.Add(conConceptAttachment.ConceptId, strComparisonOp);
}
else
{
objConceptAttachmentEN.dicFldComparisonOp[conConceptAttachment.ConceptId] = strComparisonOp;
}
}
return objConceptAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConceptAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConceptAttachmentEN SetFilePath(this clsConceptAttachmentEN objConceptAttachmentEN, string strFilePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFilePath, conConceptAttachment.FilePath);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFilePath, 500, conConceptAttachment.FilePath);
}
objConceptAttachmentEN.FilePath = strFilePath; //文件路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConceptAttachmentEN.dicFldComparisonOp.ContainsKey(conConceptAttachment.FilePath) == false)
{
objConceptAttachmentEN.dicFldComparisonOp.Add(conConceptAttachment.FilePath, strComparisonOp);
}
else
{
objConceptAttachmentEN.dicFldComparisonOp[conConceptAttachment.FilePath] = strComparisonOp;
}
}
return objConceptAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConceptAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConceptAttachmentEN SetUpdDate(this clsConceptAttachmentEN objConceptAttachmentEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conConceptAttachment.UpdDate);
}
objConceptAttachmentEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConceptAttachmentEN.dicFldComparisonOp.ContainsKey(conConceptAttachment.UpdDate) == false)
{
objConceptAttachmentEN.dicFldComparisonOp.Add(conConceptAttachment.UpdDate, strComparisonOp);
}
else
{
objConceptAttachmentEN.dicFldComparisonOp[conConceptAttachment.UpdDate] = strComparisonOp;
}
}
return objConceptAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConceptAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConceptAttachmentEN SetUpdUserId(this clsConceptAttachmentEN objConceptAttachmentEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conConceptAttachment.UpdUserId);
}
objConceptAttachmentEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConceptAttachmentEN.dicFldComparisonOp.ContainsKey(conConceptAttachment.UpdUserId) == false)
{
objConceptAttachmentEN.dicFldComparisonOp.Add(conConceptAttachment.UpdUserId, strComparisonOp);
}
else
{
objConceptAttachmentEN.dicFldComparisonOp[conConceptAttachment.UpdUserId] = strComparisonOp;
}
}
return objConceptAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConceptAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConceptAttachmentEN SetMemo(this clsConceptAttachmentEN objConceptAttachmentEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conConceptAttachment.Memo);
}
objConceptAttachmentEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConceptAttachmentEN.dicFldComparisonOp.ContainsKey(conConceptAttachment.Memo) == false)
{
objConceptAttachmentEN.dicFldComparisonOp.Add(conConceptAttachment.Memo, strComparisonOp);
}
else
{
objConceptAttachmentEN.dicFldComparisonOp[conConceptAttachment.Memo] = strComparisonOp;
}
}
return objConceptAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConceptAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConceptAttachmentEN SetIdCurrEduCls(this clsConceptAttachmentEN objConceptAttachmentEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conConceptAttachment.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conConceptAttachment.IdCurrEduCls);
}
objConceptAttachmentEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConceptAttachmentEN.dicFldComparisonOp.ContainsKey(conConceptAttachment.IdCurrEduCls) == false)
{
objConceptAttachmentEN.dicFldComparisonOp.Add(conConceptAttachment.IdCurrEduCls, strComparisonOp);
}
else
{
objConceptAttachmentEN.dicFldComparisonOp[conConceptAttachment.IdCurrEduCls] = strComparisonOp;
}
}
return objConceptAttachmentEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objConceptAttachmentEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsConceptAttachmentEN objConceptAttachmentEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objConceptAttachmentEN.CheckPropertyNew();
clsConceptAttachmentEN objConceptAttachmentCond = new clsConceptAttachmentEN();
string strCondition = objConceptAttachmentCond
.SetConceptAttachmentId(objConceptAttachmentEN.ConceptAttachmentId, "<>")
.SetConceptAttachmentId(objConceptAttachmentEN.ConceptAttachmentId, "=")
.SetConceptId(objConceptAttachmentEN.ConceptId, "=")
.GetCombineCondition();
objConceptAttachmentEN._IsCheckProperty = true;
bool bolIsExist = clsConceptAttachmentBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(ConceptAttachmentId_ConceptId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objConceptAttachmentEN.Update();
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
 /// <param name = "objConceptAttachment">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsConceptAttachmentEN objConceptAttachment)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsConceptAttachmentEN objConceptAttachmentCond = new clsConceptAttachmentEN();
string strCondition = objConceptAttachmentCond
.SetConceptAttachmentId(objConceptAttachment.ConceptAttachmentId, "=")
.SetConceptId(objConceptAttachment.ConceptId, "=")
.GetCombineCondition();
objConceptAttachment._IsCheckProperty = true;
bool bolIsExist = clsConceptAttachmentBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objConceptAttachment.ConceptAttachmentId = clsConceptAttachmentBL.GetFirstID_S(strCondition);
objConceptAttachment.UpdateWithCondition(strCondition);
}
else
{
objConceptAttachment.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objConceptAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsConceptAttachmentEN objConceptAttachmentEN)
{
 if (objConceptAttachmentEN.ConceptAttachmentId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsConceptAttachmentBL.ConceptAttachmentDA.UpdateBySql2(objConceptAttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConceptAttachmentBL.ReFreshCache(objConceptAttachmentEN.IdCurrEduCls);

if (clsConceptAttachmentBL.relatedActions != null)
{
clsConceptAttachmentBL.relatedActions.UpdRelaTabDate(objConceptAttachmentEN.ConceptAttachmentId, "SetUpdDate");
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
 /// <param name = "objConceptAttachmentEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsConceptAttachmentEN objConceptAttachmentEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objConceptAttachmentEN.ConceptAttachmentId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsConceptAttachmentBL.ConceptAttachmentDA.UpdateBySql2(objConceptAttachmentEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConceptAttachmentBL.ReFreshCache(objConceptAttachmentEN.IdCurrEduCls);

if (clsConceptAttachmentBL.relatedActions != null)
{
clsConceptAttachmentBL.relatedActions.UpdRelaTabDate(objConceptAttachmentEN.ConceptAttachmentId, "SetUpdDate");
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
 /// <param name = "objConceptAttachmentEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsConceptAttachmentEN objConceptAttachmentEN, string strWhereCond)
{
try
{
bool bolResult = clsConceptAttachmentBL.ConceptAttachmentDA.UpdateBySqlWithCondition(objConceptAttachmentEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConceptAttachmentBL.ReFreshCache(objConceptAttachmentEN.IdCurrEduCls);

if (clsConceptAttachmentBL.relatedActions != null)
{
clsConceptAttachmentBL.relatedActions.UpdRelaTabDate(objConceptAttachmentEN.ConceptAttachmentId, "SetUpdDate");
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
 /// <param name = "objConceptAttachmentEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsConceptAttachmentEN objConceptAttachmentEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsConceptAttachmentBL.ConceptAttachmentDA.UpdateBySqlWithConditionTransaction(objConceptAttachmentEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConceptAttachmentBL.ReFreshCache(objConceptAttachmentEN.IdCurrEduCls);

if (clsConceptAttachmentBL.relatedActions != null)
{
clsConceptAttachmentBL.relatedActions.UpdRelaTabDate(objConceptAttachmentEN.ConceptAttachmentId, "SetUpdDate");
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
 /// <param name = "lngConceptAttachmentId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsConceptAttachmentEN objConceptAttachmentEN)
{
try
{
int intRecNum = clsConceptAttachmentBL.ConceptAttachmentDA.DelRecord(objConceptAttachmentEN.ConceptAttachmentId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConceptAttachmentBL.ReFreshCache(objConceptAttachmentEN.IdCurrEduCls);

if (clsConceptAttachmentBL.relatedActions != null)
{
clsConceptAttachmentBL.relatedActions.UpdRelaTabDate(objConceptAttachmentEN.ConceptAttachmentId, "SetUpdDate");
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
 /// <param name = "objConceptAttachmentENS">源对象</param>
 /// <param name = "objConceptAttachmentENT">目标对象</param>
 public static void CopyTo(this clsConceptAttachmentEN objConceptAttachmentENS, clsConceptAttachmentEN objConceptAttachmentENT)
{
try
{
objConceptAttachmentENT.ConceptAttachmentId = objConceptAttachmentENS.ConceptAttachmentId; //概念附件Id
objConceptAttachmentENT.ConceptAttachmentName = objConceptAttachmentENS.ConceptAttachmentName; //附件名称
objConceptAttachmentENT.ConceptId = objConceptAttachmentENS.ConceptId; //概念Id
objConceptAttachmentENT.FilePath = objConceptAttachmentENS.FilePath; //文件路径
objConceptAttachmentENT.UpdDate = objConceptAttachmentENS.UpdDate; //修改日期
objConceptAttachmentENT.UpdUserId = objConceptAttachmentENS.UpdUserId; //修改用户Id
objConceptAttachmentENT.Memo = objConceptAttachmentENS.Memo; //备注
objConceptAttachmentENT.IdCurrEduCls = objConceptAttachmentENS.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objConceptAttachmentENS">源对象</param>
 /// <returns>目标对象=>clsConceptAttachmentEN:objConceptAttachmentENT</returns>
 public static clsConceptAttachmentEN CopyTo(this clsConceptAttachmentEN objConceptAttachmentENS)
{
try
{
 clsConceptAttachmentEN objConceptAttachmentENT = new clsConceptAttachmentEN()
{
ConceptAttachmentId = objConceptAttachmentENS.ConceptAttachmentId, //概念附件Id
ConceptAttachmentName = objConceptAttachmentENS.ConceptAttachmentName, //附件名称
ConceptId = objConceptAttachmentENS.ConceptId, //概念Id
FilePath = objConceptAttachmentENS.FilePath, //文件路径
UpdDate = objConceptAttachmentENS.UpdDate, //修改日期
UpdUserId = objConceptAttachmentENS.UpdUserId, //修改用户Id
Memo = objConceptAttachmentENS.Memo, //备注
IdCurrEduCls = objConceptAttachmentENS.IdCurrEduCls, //教学班流水号
};
 return objConceptAttachmentENT;
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
public static void CheckPropertyNew(this clsConceptAttachmentEN objConceptAttachmentEN)
{
 clsConceptAttachmentBL.ConceptAttachmentDA.CheckPropertyNew(objConceptAttachmentEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsConceptAttachmentEN objConceptAttachmentEN)
{
 clsConceptAttachmentBL.ConceptAttachmentDA.CheckProperty4Condition(objConceptAttachmentEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsConceptAttachmentEN objConceptAttachmentCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objConceptAttachmentCond.IsUpdated(conConceptAttachment.ConceptAttachmentId) == true)
{
string strComparisonOpConceptAttachmentId = objConceptAttachmentCond.dicFldComparisonOp[conConceptAttachment.ConceptAttachmentId];
strWhereCond += string.Format(" And {0} {2} {1}", conConceptAttachment.ConceptAttachmentId, objConceptAttachmentCond.ConceptAttachmentId, strComparisonOpConceptAttachmentId);
}
if (objConceptAttachmentCond.IsUpdated(conConceptAttachment.ConceptAttachmentName) == true)
{
string strComparisonOpConceptAttachmentName = objConceptAttachmentCond.dicFldComparisonOp[conConceptAttachment.ConceptAttachmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conConceptAttachment.ConceptAttachmentName, objConceptAttachmentCond.ConceptAttachmentName, strComparisonOpConceptAttachmentName);
}
if (objConceptAttachmentCond.IsUpdated(conConceptAttachment.ConceptId) == true)
{
string strComparisonOpConceptId = objConceptAttachmentCond.dicFldComparisonOp[conConceptAttachment.ConceptId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conConceptAttachment.ConceptId, objConceptAttachmentCond.ConceptId, strComparisonOpConceptId);
}
if (objConceptAttachmentCond.IsUpdated(conConceptAttachment.FilePath) == true)
{
string strComparisonOpFilePath = objConceptAttachmentCond.dicFldComparisonOp[conConceptAttachment.FilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conConceptAttachment.FilePath, objConceptAttachmentCond.FilePath, strComparisonOpFilePath);
}
if (objConceptAttachmentCond.IsUpdated(conConceptAttachment.UpdDate) == true)
{
string strComparisonOpUpdDate = objConceptAttachmentCond.dicFldComparisonOp[conConceptAttachment.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conConceptAttachment.UpdDate, objConceptAttachmentCond.UpdDate, strComparisonOpUpdDate);
}
if (objConceptAttachmentCond.IsUpdated(conConceptAttachment.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objConceptAttachmentCond.dicFldComparisonOp[conConceptAttachment.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conConceptAttachment.UpdUserId, objConceptAttachmentCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objConceptAttachmentCond.IsUpdated(conConceptAttachment.Memo) == true)
{
string strComparisonOpMemo = objConceptAttachmentCond.dicFldComparisonOp[conConceptAttachment.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conConceptAttachment.Memo, objConceptAttachmentCond.Memo, strComparisonOpMemo);
}
if (objConceptAttachmentCond.IsUpdated(conConceptAttachment.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objConceptAttachmentCond.dicFldComparisonOp[conConceptAttachment.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conConceptAttachment.IdCurrEduCls, objConceptAttachmentCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--ConceptAttachment(概念附件), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:ConceptAttachmentId_ConceptId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objConceptAttachmentEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsConceptAttachmentEN objConceptAttachmentEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objConceptAttachmentEN == null) return true;
if (objConceptAttachmentEN.ConceptAttachmentId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ConceptAttachmentId = '{0}'", objConceptAttachmentEN.ConceptAttachmentId);
 sbCondition.AppendFormat(" and ConceptId = '{0}'", objConceptAttachmentEN.ConceptId);
if (clsConceptAttachmentBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("ConceptAttachmentId !=  {0}", objConceptAttachmentEN.ConceptAttachmentId);
 sbCondition.AppendFormat(" and ConceptAttachmentId = '{0}'", objConceptAttachmentEN.ConceptAttachmentId);
 sbCondition.AppendFormat(" and ConceptId = '{0}'", objConceptAttachmentEN.ConceptId);
if (clsConceptAttachmentBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--ConceptAttachment(概念附件), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ConceptAttachmentId_ConceptId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objConceptAttachmentEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsConceptAttachmentEN objConceptAttachmentEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objConceptAttachmentEN == null) return "";
if (objConceptAttachmentEN.ConceptAttachmentId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ConceptAttachmentId = '{0}'", objConceptAttachmentEN.ConceptAttachmentId);
 sbCondition.AppendFormat(" and ConceptId = '{0}'", objConceptAttachmentEN.ConceptId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ConceptAttachmentId !=  {0}", objConceptAttachmentEN.ConceptAttachmentId);
 sbCondition.AppendFormat(" and ConceptAttachmentId = '{0}'", objConceptAttachmentEN.ConceptAttachmentId);
 sbCondition.AppendFormat(" and ConceptId = '{0}'", objConceptAttachmentEN.ConceptId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ConceptAttachment
{
public virtual bool UpdRelaTabDate(long lngConceptAttachmentId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 概念附件(ConceptAttachment)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsConceptAttachmentBL
{
public static RelatedActions_ConceptAttachment relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsConceptAttachmentDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsConceptAttachmentDA ConceptAttachmentDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsConceptAttachmentDA();
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
 public clsConceptAttachmentBL()
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
if (string.IsNullOrEmpty(clsConceptAttachmentEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsConceptAttachmentEN._ConnectString);
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
public static DataTable GetDataTable_ConceptAttachment(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ConceptAttachmentDA.GetDataTable_ConceptAttachment(strWhereCond);
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
objDT = ConceptAttachmentDA.GetDataTable(strWhereCond);
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
objDT = ConceptAttachmentDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ConceptAttachmentDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ConceptAttachmentDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ConceptAttachmentDA.GetDataTable_Top(objTopPara);
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
objDT = ConceptAttachmentDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ConceptAttachmentDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ConceptAttachmentDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrConceptAttachmentIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsConceptAttachmentEN> GetObjLstByConceptAttachmentIdLst(List<long> arrConceptAttachmentIdLst)
{
List<clsConceptAttachmentEN> arrObjLst = new List<clsConceptAttachmentEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrConceptAttachmentIdLst);
 string strWhereCond = string.Format("ConceptAttachmentId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsConceptAttachmentEN objConceptAttachmentEN = new clsConceptAttachmentEN();
try
{
objConceptAttachmentEN.ConceptAttachmentId = Int32.Parse(objRow[conConceptAttachment.ConceptAttachmentId].ToString().Trim()); //概念附件Id
objConceptAttachmentEN.ConceptAttachmentName = objRow[conConceptAttachment.ConceptAttachmentName] == DBNull.Value ? null : objRow[conConceptAttachment.ConceptAttachmentName].ToString().Trim(); //附件名称
objConceptAttachmentEN.ConceptId = objRow[conConceptAttachment.ConceptId].ToString().Trim(); //概念Id
objConceptAttachmentEN.FilePath = objRow[conConceptAttachment.FilePath].ToString().Trim(); //文件路径
objConceptAttachmentEN.UpdDate = objRow[conConceptAttachment.UpdDate] == DBNull.Value ? null : objRow[conConceptAttachment.UpdDate].ToString().Trim(); //修改日期
objConceptAttachmentEN.UpdUserId = objRow[conConceptAttachment.UpdUserId] == DBNull.Value ? null : objRow[conConceptAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objConceptAttachmentEN.Memo = objRow[conConceptAttachment.Memo] == DBNull.Value ? null : objRow[conConceptAttachment.Memo].ToString().Trim(); //备注
objConceptAttachmentEN.IdCurrEduCls = objRow[conConceptAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[conConceptAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objConceptAttachmentEN.ConceptAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objConceptAttachmentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrConceptAttachmentIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsConceptAttachmentEN> GetObjLstByConceptAttachmentIdLstCache(List<long> arrConceptAttachmentIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsConceptAttachmentEN._CurrTabName, strIdCurrEduCls);
List<clsConceptAttachmentEN> arrConceptAttachmentObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsConceptAttachmentEN> arrConceptAttachmentObjLst_Sel =
arrConceptAttachmentObjLstCache
.Where(x => arrConceptAttachmentIdLst.Contains(x.ConceptAttachmentId));
return arrConceptAttachmentObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsConceptAttachmentEN> GetObjLst(string strWhereCond)
{
List<clsConceptAttachmentEN> arrObjLst = new List<clsConceptAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsConceptAttachmentEN objConceptAttachmentEN = new clsConceptAttachmentEN();
try
{
objConceptAttachmentEN.ConceptAttachmentId = Int32.Parse(objRow[conConceptAttachment.ConceptAttachmentId].ToString().Trim()); //概念附件Id
objConceptAttachmentEN.ConceptAttachmentName = objRow[conConceptAttachment.ConceptAttachmentName] == DBNull.Value ? null : objRow[conConceptAttachment.ConceptAttachmentName].ToString().Trim(); //附件名称
objConceptAttachmentEN.ConceptId = objRow[conConceptAttachment.ConceptId].ToString().Trim(); //概念Id
objConceptAttachmentEN.FilePath = objRow[conConceptAttachment.FilePath].ToString().Trim(); //文件路径
objConceptAttachmentEN.UpdDate = objRow[conConceptAttachment.UpdDate] == DBNull.Value ? null : objRow[conConceptAttachment.UpdDate].ToString().Trim(); //修改日期
objConceptAttachmentEN.UpdUserId = objRow[conConceptAttachment.UpdUserId] == DBNull.Value ? null : objRow[conConceptAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objConceptAttachmentEN.Memo = objRow[conConceptAttachment.Memo] == DBNull.Value ? null : objRow[conConceptAttachment.Memo].ToString().Trim(); //备注
objConceptAttachmentEN.IdCurrEduCls = objRow[conConceptAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[conConceptAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objConceptAttachmentEN.ConceptAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objConceptAttachmentEN);
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
public static List<clsConceptAttachmentEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsConceptAttachmentEN> arrObjLst = new List<clsConceptAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsConceptAttachmentEN objConceptAttachmentEN = new clsConceptAttachmentEN();
try
{
objConceptAttachmentEN.ConceptAttachmentId = Int32.Parse(objRow[conConceptAttachment.ConceptAttachmentId].ToString().Trim()); //概念附件Id
objConceptAttachmentEN.ConceptAttachmentName = objRow[conConceptAttachment.ConceptAttachmentName] == DBNull.Value ? null : objRow[conConceptAttachment.ConceptAttachmentName].ToString().Trim(); //附件名称
objConceptAttachmentEN.ConceptId = objRow[conConceptAttachment.ConceptId].ToString().Trim(); //概念Id
objConceptAttachmentEN.FilePath = objRow[conConceptAttachment.FilePath].ToString().Trim(); //文件路径
objConceptAttachmentEN.UpdDate = objRow[conConceptAttachment.UpdDate] == DBNull.Value ? null : objRow[conConceptAttachment.UpdDate].ToString().Trim(); //修改日期
objConceptAttachmentEN.UpdUserId = objRow[conConceptAttachment.UpdUserId] == DBNull.Value ? null : objRow[conConceptAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objConceptAttachmentEN.Memo = objRow[conConceptAttachment.Memo] == DBNull.Value ? null : objRow[conConceptAttachment.Memo].ToString().Trim(); //备注
objConceptAttachmentEN.IdCurrEduCls = objRow[conConceptAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[conConceptAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objConceptAttachmentEN.ConceptAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objConceptAttachmentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objConceptAttachmentCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsConceptAttachmentEN> GetSubObjLstCache(clsConceptAttachmentEN objConceptAttachmentCond)
{
 string strIdCurrEduCls = objConceptAttachmentCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsConceptAttachmentBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsConceptAttachmentEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsConceptAttachmentEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conConceptAttachment.AttributeName)
{
if (objConceptAttachmentCond.IsUpdated(strFldName) == false) continue;
if (objConceptAttachmentCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objConceptAttachmentCond[strFldName].ToString());
}
else
{
if (objConceptAttachmentCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objConceptAttachmentCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objConceptAttachmentCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objConceptAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objConceptAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objConceptAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objConceptAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objConceptAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objConceptAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objConceptAttachmentCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objConceptAttachmentCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objConceptAttachmentCond[strFldName]));
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
public static List<clsConceptAttachmentEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsConceptAttachmentEN> arrObjLst = new List<clsConceptAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsConceptAttachmentEN objConceptAttachmentEN = new clsConceptAttachmentEN();
try
{
objConceptAttachmentEN.ConceptAttachmentId = Int32.Parse(objRow[conConceptAttachment.ConceptAttachmentId].ToString().Trim()); //概念附件Id
objConceptAttachmentEN.ConceptAttachmentName = objRow[conConceptAttachment.ConceptAttachmentName] == DBNull.Value ? null : objRow[conConceptAttachment.ConceptAttachmentName].ToString().Trim(); //附件名称
objConceptAttachmentEN.ConceptId = objRow[conConceptAttachment.ConceptId].ToString().Trim(); //概念Id
objConceptAttachmentEN.FilePath = objRow[conConceptAttachment.FilePath].ToString().Trim(); //文件路径
objConceptAttachmentEN.UpdDate = objRow[conConceptAttachment.UpdDate] == DBNull.Value ? null : objRow[conConceptAttachment.UpdDate].ToString().Trim(); //修改日期
objConceptAttachmentEN.UpdUserId = objRow[conConceptAttachment.UpdUserId] == DBNull.Value ? null : objRow[conConceptAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objConceptAttachmentEN.Memo = objRow[conConceptAttachment.Memo] == DBNull.Value ? null : objRow[conConceptAttachment.Memo].ToString().Trim(); //备注
objConceptAttachmentEN.IdCurrEduCls = objRow[conConceptAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[conConceptAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objConceptAttachmentEN.ConceptAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objConceptAttachmentEN);
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
public static List<clsConceptAttachmentEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsConceptAttachmentEN> arrObjLst = new List<clsConceptAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsConceptAttachmentEN objConceptAttachmentEN = new clsConceptAttachmentEN();
try
{
objConceptAttachmentEN.ConceptAttachmentId = Int32.Parse(objRow[conConceptAttachment.ConceptAttachmentId].ToString().Trim()); //概念附件Id
objConceptAttachmentEN.ConceptAttachmentName = objRow[conConceptAttachment.ConceptAttachmentName] == DBNull.Value ? null : objRow[conConceptAttachment.ConceptAttachmentName].ToString().Trim(); //附件名称
objConceptAttachmentEN.ConceptId = objRow[conConceptAttachment.ConceptId].ToString().Trim(); //概念Id
objConceptAttachmentEN.FilePath = objRow[conConceptAttachment.FilePath].ToString().Trim(); //文件路径
objConceptAttachmentEN.UpdDate = objRow[conConceptAttachment.UpdDate] == DBNull.Value ? null : objRow[conConceptAttachment.UpdDate].ToString().Trim(); //修改日期
objConceptAttachmentEN.UpdUserId = objRow[conConceptAttachment.UpdUserId] == DBNull.Value ? null : objRow[conConceptAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objConceptAttachmentEN.Memo = objRow[conConceptAttachment.Memo] == DBNull.Value ? null : objRow[conConceptAttachment.Memo].ToString().Trim(); //备注
objConceptAttachmentEN.IdCurrEduCls = objRow[conConceptAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[conConceptAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objConceptAttachmentEN.ConceptAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objConceptAttachmentEN);
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
List<clsConceptAttachmentEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsConceptAttachmentEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsConceptAttachmentEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsConceptAttachmentEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsConceptAttachmentEN> arrObjLst = new List<clsConceptAttachmentEN>(); 
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
	clsConceptAttachmentEN objConceptAttachmentEN = new clsConceptAttachmentEN();
try
{
objConceptAttachmentEN.ConceptAttachmentId = Int32.Parse(objRow[conConceptAttachment.ConceptAttachmentId].ToString().Trim()); //概念附件Id
objConceptAttachmentEN.ConceptAttachmentName = objRow[conConceptAttachment.ConceptAttachmentName] == DBNull.Value ? null : objRow[conConceptAttachment.ConceptAttachmentName].ToString().Trim(); //附件名称
objConceptAttachmentEN.ConceptId = objRow[conConceptAttachment.ConceptId].ToString().Trim(); //概念Id
objConceptAttachmentEN.FilePath = objRow[conConceptAttachment.FilePath].ToString().Trim(); //文件路径
objConceptAttachmentEN.UpdDate = objRow[conConceptAttachment.UpdDate] == DBNull.Value ? null : objRow[conConceptAttachment.UpdDate].ToString().Trim(); //修改日期
objConceptAttachmentEN.UpdUserId = objRow[conConceptAttachment.UpdUserId] == DBNull.Value ? null : objRow[conConceptAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objConceptAttachmentEN.Memo = objRow[conConceptAttachment.Memo] == DBNull.Value ? null : objRow[conConceptAttachment.Memo].ToString().Trim(); //备注
objConceptAttachmentEN.IdCurrEduCls = objRow[conConceptAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[conConceptAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objConceptAttachmentEN.ConceptAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objConceptAttachmentEN);
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
public static List<clsConceptAttachmentEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsConceptAttachmentEN> arrObjLst = new List<clsConceptAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsConceptAttachmentEN objConceptAttachmentEN = new clsConceptAttachmentEN();
try
{
objConceptAttachmentEN.ConceptAttachmentId = Int32.Parse(objRow[conConceptAttachment.ConceptAttachmentId].ToString().Trim()); //概念附件Id
objConceptAttachmentEN.ConceptAttachmentName = objRow[conConceptAttachment.ConceptAttachmentName] == DBNull.Value ? null : objRow[conConceptAttachment.ConceptAttachmentName].ToString().Trim(); //附件名称
objConceptAttachmentEN.ConceptId = objRow[conConceptAttachment.ConceptId].ToString().Trim(); //概念Id
objConceptAttachmentEN.FilePath = objRow[conConceptAttachment.FilePath].ToString().Trim(); //文件路径
objConceptAttachmentEN.UpdDate = objRow[conConceptAttachment.UpdDate] == DBNull.Value ? null : objRow[conConceptAttachment.UpdDate].ToString().Trim(); //修改日期
objConceptAttachmentEN.UpdUserId = objRow[conConceptAttachment.UpdUserId] == DBNull.Value ? null : objRow[conConceptAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objConceptAttachmentEN.Memo = objRow[conConceptAttachment.Memo] == DBNull.Value ? null : objRow[conConceptAttachment.Memo].ToString().Trim(); //备注
objConceptAttachmentEN.IdCurrEduCls = objRow[conConceptAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[conConceptAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objConceptAttachmentEN.ConceptAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objConceptAttachmentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsConceptAttachmentEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsConceptAttachmentEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsConceptAttachmentEN> arrObjLst = new List<clsConceptAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsConceptAttachmentEN objConceptAttachmentEN = new clsConceptAttachmentEN();
try
{
objConceptAttachmentEN.ConceptAttachmentId = Int32.Parse(objRow[conConceptAttachment.ConceptAttachmentId].ToString().Trim()); //概念附件Id
objConceptAttachmentEN.ConceptAttachmentName = objRow[conConceptAttachment.ConceptAttachmentName] == DBNull.Value ? null : objRow[conConceptAttachment.ConceptAttachmentName].ToString().Trim(); //附件名称
objConceptAttachmentEN.ConceptId = objRow[conConceptAttachment.ConceptId].ToString().Trim(); //概念Id
objConceptAttachmentEN.FilePath = objRow[conConceptAttachment.FilePath].ToString().Trim(); //文件路径
objConceptAttachmentEN.UpdDate = objRow[conConceptAttachment.UpdDate] == DBNull.Value ? null : objRow[conConceptAttachment.UpdDate].ToString().Trim(); //修改日期
objConceptAttachmentEN.UpdUserId = objRow[conConceptAttachment.UpdUserId] == DBNull.Value ? null : objRow[conConceptAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objConceptAttachmentEN.Memo = objRow[conConceptAttachment.Memo] == DBNull.Value ? null : objRow[conConceptAttachment.Memo].ToString().Trim(); //备注
objConceptAttachmentEN.IdCurrEduCls = objRow[conConceptAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[conConceptAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objConceptAttachmentEN.ConceptAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objConceptAttachmentEN);
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
public static List<clsConceptAttachmentEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsConceptAttachmentEN> arrObjLst = new List<clsConceptAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsConceptAttachmentEN objConceptAttachmentEN = new clsConceptAttachmentEN();
try
{
objConceptAttachmentEN.ConceptAttachmentId = Int32.Parse(objRow[conConceptAttachment.ConceptAttachmentId].ToString().Trim()); //概念附件Id
objConceptAttachmentEN.ConceptAttachmentName = objRow[conConceptAttachment.ConceptAttachmentName] == DBNull.Value ? null : objRow[conConceptAttachment.ConceptAttachmentName].ToString().Trim(); //附件名称
objConceptAttachmentEN.ConceptId = objRow[conConceptAttachment.ConceptId].ToString().Trim(); //概念Id
objConceptAttachmentEN.FilePath = objRow[conConceptAttachment.FilePath].ToString().Trim(); //文件路径
objConceptAttachmentEN.UpdDate = objRow[conConceptAttachment.UpdDate] == DBNull.Value ? null : objRow[conConceptAttachment.UpdDate].ToString().Trim(); //修改日期
objConceptAttachmentEN.UpdUserId = objRow[conConceptAttachment.UpdUserId] == DBNull.Value ? null : objRow[conConceptAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objConceptAttachmentEN.Memo = objRow[conConceptAttachment.Memo] == DBNull.Value ? null : objRow[conConceptAttachment.Memo].ToString().Trim(); //备注
objConceptAttachmentEN.IdCurrEduCls = objRow[conConceptAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[conConceptAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objConceptAttachmentEN.ConceptAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objConceptAttachmentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsConceptAttachmentEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsConceptAttachmentEN> arrObjLst = new List<clsConceptAttachmentEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsConceptAttachmentEN objConceptAttachmentEN = new clsConceptAttachmentEN();
try
{
objConceptAttachmentEN.ConceptAttachmentId = Int32.Parse(objRow[conConceptAttachment.ConceptAttachmentId].ToString().Trim()); //概念附件Id
objConceptAttachmentEN.ConceptAttachmentName = objRow[conConceptAttachment.ConceptAttachmentName] == DBNull.Value ? null : objRow[conConceptAttachment.ConceptAttachmentName].ToString().Trim(); //附件名称
objConceptAttachmentEN.ConceptId = objRow[conConceptAttachment.ConceptId].ToString().Trim(); //概念Id
objConceptAttachmentEN.FilePath = objRow[conConceptAttachment.FilePath].ToString().Trim(); //文件路径
objConceptAttachmentEN.UpdDate = objRow[conConceptAttachment.UpdDate] == DBNull.Value ? null : objRow[conConceptAttachment.UpdDate].ToString().Trim(); //修改日期
objConceptAttachmentEN.UpdUserId = objRow[conConceptAttachment.UpdUserId] == DBNull.Value ? null : objRow[conConceptAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objConceptAttachmentEN.Memo = objRow[conConceptAttachment.Memo] == DBNull.Value ? null : objRow[conConceptAttachment.Memo].ToString().Trim(); //备注
objConceptAttachmentEN.IdCurrEduCls = objRow[conConceptAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[conConceptAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objConceptAttachmentEN.ConceptAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objConceptAttachmentEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objConceptAttachmentEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetConceptAttachment(ref clsConceptAttachmentEN objConceptAttachmentEN)
{
bool bolResult = ConceptAttachmentDA.GetConceptAttachment(ref objConceptAttachmentEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngConceptAttachmentId">表关键字</param>
 /// <returns>表对象</returns>
public static clsConceptAttachmentEN GetObjByConceptAttachmentId(long lngConceptAttachmentId)
{
clsConceptAttachmentEN objConceptAttachmentEN = ConceptAttachmentDA.GetObjByConceptAttachmentId(lngConceptAttachmentId);
return objConceptAttachmentEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsConceptAttachmentEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsConceptAttachmentEN objConceptAttachmentEN = ConceptAttachmentDA.GetFirstObj(strWhereCond);
 return objConceptAttachmentEN;
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
public static clsConceptAttachmentEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsConceptAttachmentEN objConceptAttachmentEN = ConceptAttachmentDA.GetObjByDataRow(objRow);
 return objConceptAttachmentEN;
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
public static clsConceptAttachmentEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsConceptAttachmentEN objConceptAttachmentEN = ConceptAttachmentDA.GetObjByDataRow(objRow);
 return objConceptAttachmentEN;
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
 /// <param name = "lngConceptAttachmentId">所给的关键字</param>
 /// <param name = "lstConceptAttachmentObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsConceptAttachmentEN GetObjByConceptAttachmentIdFromList(long lngConceptAttachmentId, List<clsConceptAttachmentEN> lstConceptAttachmentObjLst)
{
foreach (clsConceptAttachmentEN objConceptAttachmentEN in lstConceptAttachmentObjLst)
{
if (objConceptAttachmentEN.ConceptAttachmentId == lngConceptAttachmentId)
{
return objConceptAttachmentEN;
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
 long lngConceptAttachmentId;
 try
 {
 lngConceptAttachmentId = new clsConceptAttachmentDA().GetFirstID(strWhereCond);
 return lngConceptAttachmentId;
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
 arrList = ConceptAttachmentDA.GetID(strWhereCond);
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
bool bolIsExist = ConceptAttachmentDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngConceptAttachmentId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngConceptAttachmentId)
{
//检测记录是否存在
bool bolIsExist = ConceptAttachmentDA.IsExist(lngConceptAttachmentId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngConceptAttachmentId">概念附件Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngConceptAttachmentId, string strOpUser)
{
clsConceptAttachmentEN objConceptAttachmentEN = clsConceptAttachmentBL.GetObjByConceptAttachmentId(lngConceptAttachmentId);
objConceptAttachmentEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
return clsConceptAttachmentBL.UpdateBySql2(objConceptAttachmentEN);
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
 bolIsExist = clsConceptAttachmentDA.IsExistTable();
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
 bolIsExist = ConceptAttachmentDA.IsExistTable(strTabName);
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
 /// <param name = "objConceptAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsConceptAttachmentEN objConceptAttachmentEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objConceptAttachmentEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!概念附件Id = [{0}],概念Id = [{1}]的数据已经存在!(in clsConceptAttachmentBL.AddNewRecordBySql2)", objConceptAttachmentEN.ConceptAttachmentId,objConceptAttachmentEN.ConceptId);
throw new Exception(strMsg);
}
try
{
bool bolResult = ConceptAttachmentDA.AddNewRecordBySQL2(objConceptAttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConceptAttachmentBL.ReFreshCache(objConceptAttachmentEN.IdCurrEduCls);

if (clsConceptAttachmentBL.relatedActions != null)
{
clsConceptAttachmentBL.relatedActions.UpdRelaTabDate(objConceptAttachmentEN.ConceptAttachmentId, "SetUpdDate");
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
 /// <param name = "objConceptAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsConceptAttachmentEN objConceptAttachmentEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objConceptAttachmentEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!概念附件Id = [{0}],概念Id = [{1}]的数据已经存在!(in clsConceptAttachmentBL.AddNewRecordBySql2WithReturnKey)", objConceptAttachmentEN.ConceptAttachmentId,objConceptAttachmentEN.ConceptId);
throw new Exception(strMsg);
}
try
{
string strKey = ConceptAttachmentDA.AddNewRecordBySQL2WithReturnKey(objConceptAttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConceptAttachmentBL.ReFreshCache(objConceptAttachmentEN.IdCurrEduCls);

if (clsConceptAttachmentBL.relatedActions != null)
{
clsConceptAttachmentBL.relatedActions.UpdRelaTabDate(objConceptAttachmentEN.ConceptAttachmentId, "SetUpdDate");
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
 /// <param name = "objConceptAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsConceptAttachmentEN objConceptAttachmentEN)
{
try
{
bool bolResult = ConceptAttachmentDA.Update(objConceptAttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConceptAttachmentBL.ReFreshCache(objConceptAttachmentEN.IdCurrEduCls);

if (clsConceptAttachmentBL.relatedActions != null)
{
clsConceptAttachmentBL.relatedActions.UpdRelaTabDate(objConceptAttachmentEN.ConceptAttachmentId, "SetUpdDate");
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
 /// <param name = "objConceptAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsConceptAttachmentEN objConceptAttachmentEN)
{
 if (objConceptAttachmentEN.ConceptAttachmentId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ConceptAttachmentDA.UpdateBySql2(objConceptAttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConceptAttachmentBL.ReFreshCache(objConceptAttachmentEN.IdCurrEduCls);

if (clsConceptAttachmentBL.relatedActions != null)
{
clsConceptAttachmentBL.relatedActions.UpdRelaTabDate(objConceptAttachmentEN.ConceptAttachmentId, "SetUpdDate");
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
 /// <param name = "lngConceptAttachmentId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngConceptAttachmentId)
{
try
{
 clsConceptAttachmentEN objConceptAttachmentEN = clsConceptAttachmentBL.GetObjByConceptAttachmentId(lngConceptAttachmentId);

if (clsConceptAttachmentBL.relatedActions != null)
{
clsConceptAttachmentBL.relatedActions.UpdRelaTabDate(objConceptAttachmentEN.ConceptAttachmentId, "SetUpdDate");
}
if (objConceptAttachmentEN != null)
{
int intRecNum = ConceptAttachmentDA.DelRecord(lngConceptAttachmentId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objConceptAttachmentEN.IdCurrEduCls);
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
/// <param name="lngConceptAttachmentId">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(long lngConceptAttachmentId , string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsConceptAttachmentDA.GetSpecSQLObj();
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
//删除与表:[ConceptAttachment]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conConceptAttachment.ConceptAttachmentId,
//lngConceptAttachmentId);
//        clsConceptAttachmentBL.DelConceptAttachmentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsConceptAttachmentBL.DelRecord(lngConceptAttachmentId, strIdCurrEduCls, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsConceptAttachmentBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngConceptAttachmentId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngConceptAttachmentId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngConceptAttachmentId, string strIdCurrEduCls, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsConceptAttachmentBL.relatedActions != null)
{
clsConceptAttachmentBL.relatedActions.UpdRelaTabDate(lngConceptAttachmentId, "UpdRelaTabDate");
}
bool bolResult = ConceptAttachmentDA.DelRecord(lngConceptAttachmentId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrConceptAttachmentIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelConceptAttachments(List<string> arrConceptAttachmentIdLst)
{
if (arrConceptAttachmentIdLst.Count == 0) return 0;
try
{
if (clsConceptAttachmentBL.relatedActions != null)
{
foreach (var strConceptAttachmentId in arrConceptAttachmentIdLst)
{
long lngConceptAttachmentId = long.Parse(strConceptAttachmentId);
clsConceptAttachmentBL.relatedActions.UpdRelaTabDate(lngConceptAttachmentId, "UpdRelaTabDate");
}
}
 clsConceptAttachmentEN objConceptAttachmentEN = clsConceptAttachmentBL.GetObjByConceptAttachmentId(long.Parse(arrConceptAttachmentIdLst[0]));
int intDelRecNum = ConceptAttachmentDA.DelConceptAttachment(arrConceptAttachmentIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objConceptAttachmentEN.IdCurrEduCls);
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
public static int DelConceptAttachmentsByCond(string strWhereCond)
{
try
{
if (clsConceptAttachmentBL.relatedActions != null)
{
List<string> arrConceptAttachmentId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strConceptAttachmentId in arrConceptAttachmentId)
{
long lngConceptAttachmentId = long.Parse(strConceptAttachmentId);
clsConceptAttachmentBL.relatedActions.UpdRelaTabDate(lngConceptAttachmentId, "UpdRelaTabDate");
}
}
List<string> arrIdCurrEduCls = GetFldValue(conConceptAttachment.IdCurrEduCls, strWhereCond);
int intRecNum = ConceptAttachmentDA.DelConceptAttachment(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[ConceptAttachment]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngConceptAttachmentId">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngConceptAttachmentId, string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsConceptAttachmentDA.GetSpecSQLObj();
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
//删除与表:[ConceptAttachment]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsConceptAttachmentBL.DelRecord(lngConceptAttachmentId, strIdCurrEduCls, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsConceptAttachmentBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngConceptAttachmentId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objConceptAttachmentENS">源对象</param>
 /// <param name = "objConceptAttachmentENT">目标对象</param>
 public static void CopyTo(clsConceptAttachmentEN objConceptAttachmentENS, clsConceptAttachmentEN objConceptAttachmentENT)
{
try
{
objConceptAttachmentENT.ConceptAttachmentId = objConceptAttachmentENS.ConceptAttachmentId; //概念附件Id
objConceptAttachmentENT.ConceptAttachmentName = objConceptAttachmentENS.ConceptAttachmentName; //附件名称
objConceptAttachmentENT.ConceptId = objConceptAttachmentENS.ConceptId; //概念Id
objConceptAttachmentENT.FilePath = objConceptAttachmentENS.FilePath; //文件路径
objConceptAttachmentENT.UpdDate = objConceptAttachmentENS.UpdDate; //修改日期
objConceptAttachmentENT.UpdUserId = objConceptAttachmentENS.UpdUserId; //修改用户Id
objConceptAttachmentENT.Memo = objConceptAttachmentENS.Memo; //备注
objConceptAttachmentENT.IdCurrEduCls = objConceptAttachmentENS.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objConceptAttachmentEN">源简化对象</param>
 public static void SetUpdFlag(clsConceptAttachmentEN objConceptAttachmentEN)
{
try
{
objConceptAttachmentEN.ClearUpdateState();
   string strsfUpdFldSetStr = objConceptAttachmentEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conConceptAttachment.ConceptAttachmentId, new clsStrCompareIgnoreCase())  ==  true)
{
objConceptAttachmentEN.ConceptAttachmentId = objConceptAttachmentEN.ConceptAttachmentId; //概念附件Id
}
if (arrFldSet.Contains(conConceptAttachment.ConceptAttachmentName, new clsStrCompareIgnoreCase())  ==  true)
{
objConceptAttachmentEN.ConceptAttachmentName = objConceptAttachmentEN.ConceptAttachmentName == "[null]" ? null :  objConceptAttachmentEN.ConceptAttachmentName; //附件名称
}
if (arrFldSet.Contains(conConceptAttachment.ConceptId, new clsStrCompareIgnoreCase())  ==  true)
{
objConceptAttachmentEN.ConceptId = objConceptAttachmentEN.ConceptId; //概念Id
}
if (arrFldSet.Contains(conConceptAttachment.FilePath, new clsStrCompareIgnoreCase())  ==  true)
{
objConceptAttachmentEN.FilePath = objConceptAttachmentEN.FilePath; //文件路径
}
if (arrFldSet.Contains(conConceptAttachment.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objConceptAttachmentEN.UpdDate = objConceptAttachmentEN.UpdDate == "[null]" ? null :  objConceptAttachmentEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conConceptAttachment.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objConceptAttachmentEN.UpdUserId = objConceptAttachmentEN.UpdUserId == "[null]" ? null :  objConceptAttachmentEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conConceptAttachment.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objConceptAttachmentEN.Memo = objConceptAttachmentEN.Memo == "[null]" ? null :  objConceptAttachmentEN.Memo; //备注
}
if (arrFldSet.Contains(conConceptAttachment.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objConceptAttachmentEN.IdCurrEduCls = objConceptAttachmentEN.IdCurrEduCls == "[null]" ? null :  objConceptAttachmentEN.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objConceptAttachmentEN">源简化对象</param>
 public static void AccessFldValueNull(clsConceptAttachmentEN objConceptAttachmentEN)
{
try
{
if (objConceptAttachmentEN.ConceptAttachmentName == "[null]") objConceptAttachmentEN.ConceptAttachmentName = null; //附件名称
if (objConceptAttachmentEN.UpdDate == "[null]") objConceptAttachmentEN.UpdDate = null; //修改日期
if (objConceptAttachmentEN.UpdUserId == "[null]") objConceptAttachmentEN.UpdUserId = null; //修改用户Id
if (objConceptAttachmentEN.Memo == "[null]") objConceptAttachmentEN.Memo = null; //备注
if (objConceptAttachmentEN.IdCurrEduCls == "[null]") objConceptAttachmentEN.IdCurrEduCls = null; //教学班流水号
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
public static void CheckPropertyNew(clsConceptAttachmentEN objConceptAttachmentEN)
{
 ConceptAttachmentDA.CheckPropertyNew(objConceptAttachmentEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsConceptAttachmentEN objConceptAttachmentEN)
{
 ConceptAttachmentDA.CheckProperty4Condition(objConceptAttachmentEN);
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
if (clsConceptAttachmentBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsConceptAttachmentBL没有刷新缓存机制(clsConceptAttachmentBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ConceptAttachmentId");
//if (arrConceptAttachmentObjLstCache == null)
//{
//arrConceptAttachmentObjLstCache = ConceptAttachmentDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngConceptAttachmentId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsConceptAttachmentEN GetObjByConceptAttachmentIdCache(long lngConceptAttachmentId, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsConceptAttachmentEN._CurrTabName, strIdCurrEduCls);
List<clsConceptAttachmentEN> arrConceptAttachmentObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsConceptAttachmentEN> arrConceptAttachmentObjLst_Sel =
arrConceptAttachmentObjLstCache
.Where(x=> x.ConceptAttachmentId == lngConceptAttachmentId 
);
if (arrConceptAttachmentObjLst_Sel.Count() == 0)
{
   clsConceptAttachmentEN obj = clsConceptAttachmentBL.GetObjByConceptAttachmentId(lngConceptAttachmentId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngConceptAttachmentId, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrConceptAttachmentObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsConceptAttachmentEN> GetAllConceptAttachmentObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsConceptAttachmentEN> arrConceptAttachmentObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrConceptAttachmentObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsConceptAttachmentEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsConceptAttachmentEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsConceptAttachmentEN> arrConceptAttachmentObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrConceptAttachmentObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsConceptAttachmentEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clsConceptAttachmentEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsConceptAttachmentEN._RefreshTimeLst.Count == 0) return "";
return clsConceptAttachmentEN._RefreshTimeLst[clsConceptAttachmentEN._RefreshTimeLst.Count - 1];
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
if (clsConceptAttachmentBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsConceptAttachmentEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clsConceptAttachmentEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsConceptAttachmentBL.objCommFun4BL.ReFreshCache(strIdCurrEduCls);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--ConceptAttachment(概念附件)
 /// 唯一性条件:ConceptAttachmentId_ConceptId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objConceptAttachmentEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsConceptAttachmentEN objConceptAttachmentEN)
{
//检测记录是否存在
string strResult = ConceptAttachmentDA.GetUniCondStr(objConceptAttachmentEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngConceptAttachmentId, string strIdCurrEduCls)
{
if (strInFldName != conConceptAttachment.ConceptAttachmentId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conConceptAttachment.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conConceptAttachment.AttributeName));
throw new Exception(strMsg);
}
var objConceptAttachment = clsConceptAttachmentBL.GetObjByConceptAttachmentIdCache(lngConceptAttachmentId, strIdCurrEduCls);
if (objConceptAttachment == null) return "";
return objConceptAttachment[strOutFldName].ToString();
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
int intRecCount = clsConceptAttachmentDA.GetRecCount(strTabName);
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
int intRecCount = clsConceptAttachmentDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsConceptAttachmentDA.GetRecCount();
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
int intRecCount = clsConceptAttachmentDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objConceptAttachmentCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsConceptAttachmentEN objConceptAttachmentCond)
{
 string strIdCurrEduCls = objConceptAttachmentCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsConceptAttachmentBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsConceptAttachmentEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsConceptAttachmentEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conConceptAttachment.AttributeName)
{
if (objConceptAttachmentCond.IsUpdated(strFldName) == false) continue;
if (objConceptAttachmentCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objConceptAttachmentCond[strFldName].ToString());
}
else
{
if (objConceptAttachmentCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objConceptAttachmentCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objConceptAttachmentCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objConceptAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objConceptAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objConceptAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objConceptAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objConceptAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objConceptAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objConceptAttachmentCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objConceptAttachmentCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objConceptAttachmentCond[strFldName]));
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
 List<string> arrList = clsConceptAttachmentDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ConceptAttachmentDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ConceptAttachmentDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ConceptAttachmentDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsConceptAttachmentDA.SetFldValue(clsConceptAttachmentEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ConceptAttachmentDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsConceptAttachmentDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsConceptAttachmentDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsConceptAttachmentDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ConceptAttachment] "); 
 strCreateTabCode.Append(" ( "); 
 // /**概念附件Id*/ 
 strCreateTabCode.Append(" ConceptAttachmentId bigint primary key identity, "); 
 // /**附件名称*/ 
 strCreateTabCode.Append(" ConceptAttachmentName varchar(200) Null, "); 
 // /**概念Id*/ 
 strCreateTabCode.Append(" ConceptId char(8) not Null, "); 
 // /**文件路径*/ 
 strCreateTabCode.Append(" FilePath varchar(500) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 概念附件(ConceptAttachment)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4ConceptAttachment : clsCommFun4BLV2
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
clsConceptAttachmentBL.ReFreshThisCache(strIdCurrEduCls);
}
}

}