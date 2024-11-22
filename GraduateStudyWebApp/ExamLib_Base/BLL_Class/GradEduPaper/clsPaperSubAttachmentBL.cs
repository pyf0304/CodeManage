
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPaperSubAttachmentBL
 表名:PaperSubAttachment(01120579)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:03:00
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
public static class  clsPaperSubAttachmentBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngPaperSubAttachmentId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPaperSubAttachmentEN GetObj(this K_PaperSubAttachmentId_PaperSubAttachment myKey)
{
clsPaperSubAttachmentEN objPaperSubAttachmentEN = clsPaperSubAttachmentBL.PaperSubAttachmentDA.GetObjByPaperSubAttachmentId(myKey.Value);
return objPaperSubAttachmentEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objPaperSubAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsPaperSubAttachmentEN objPaperSubAttachmentEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objPaperSubAttachmentEN) == false)
{
var strMsg = string.Format("记录已经存在!附件名称 = [{0}]的数据已经存在!(in clsPaperSubAttachmentBL.AddNewRecord)", objPaperSubAttachmentEN.PaperSubAttachmentName);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsPaperSubAttachmentBL.PaperSubAttachmentDA.AddNewRecordBySQL2(objPaperSubAttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubAttachmentBL.ReFreshCache();

if (clsPaperSubAttachmentBL.relatedActions != null)
{
clsPaperSubAttachmentBL.relatedActions.UpdRelaTabDate(objPaperSubAttachmentEN.PaperSubAttachmentId, objPaperSubAttachmentEN.UpdUserId);
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
public static bool AddRecordEx(this clsPaperSubAttachmentEN objPaperSubAttachmentEN, bool bolIsNeedCheckUniqueness = true)
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
objPaperSubAttachmentEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objPaperSubAttachmentEN.CheckUniqueness() == false)
{
strMsg = string.Format("(附件名称(PaperSubAttachmentName)=[{0}])已经存在,不能重复!", objPaperSubAttachmentEN.PaperSubAttachmentName);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objPaperSubAttachmentEN.AddNewRecord();
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
 /// <param name = "objPaperSubAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsPaperSubAttachmentEN objPaperSubAttachmentEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objPaperSubAttachmentEN) == false)
{
var strMsg = string.Format("记录已经存在!附件名称 = [{0}]的数据已经存在!(in clsPaperSubAttachmentBL.AddNewRecordWithReturnKey)", objPaperSubAttachmentEN.PaperSubAttachmentName);
throw new Exception(strMsg);
}
try
{
string strKey = clsPaperSubAttachmentBL.PaperSubAttachmentDA.AddNewRecordBySQL2WithReturnKey(objPaperSubAttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubAttachmentBL.ReFreshCache();

if (clsPaperSubAttachmentBL.relatedActions != null)
{
clsPaperSubAttachmentBL.relatedActions.UpdRelaTabDate(objPaperSubAttachmentEN.PaperSubAttachmentId, objPaperSubAttachmentEN.UpdUserId);
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
 /// <param name = "objPaperSubAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubAttachmentEN SetPaperSubAttachmentId(this clsPaperSubAttachmentEN objPaperSubAttachmentEN, long lngPaperSubAttachmentId, string strComparisonOp="")
	{
objPaperSubAttachmentEN.PaperSubAttachmentId = lngPaperSubAttachmentId; //子观点附件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubAttachmentEN.dicFldComparisonOp.ContainsKey(conPaperSubAttachment.PaperSubAttachmentId) == false)
{
objPaperSubAttachmentEN.dicFldComparisonOp.Add(conPaperSubAttachment.PaperSubAttachmentId, strComparisonOp);
}
else
{
objPaperSubAttachmentEN.dicFldComparisonOp[conPaperSubAttachment.PaperSubAttachmentId] = strComparisonOp;
}
}
return objPaperSubAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubAttachmentEN SetPaperSubAttachmentName(this clsPaperSubAttachmentEN objPaperSubAttachmentEN, string strPaperSubAttachmentName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperSubAttachmentName, 200, conPaperSubAttachment.PaperSubAttachmentName);
}
objPaperSubAttachmentEN.PaperSubAttachmentName = strPaperSubAttachmentName; //附件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubAttachmentEN.dicFldComparisonOp.ContainsKey(conPaperSubAttachment.PaperSubAttachmentName) == false)
{
objPaperSubAttachmentEN.dicFldComparisonOp.Add(conPaperSubAttachment.PaperSubAttachmentName, strComparisonOp);
}
else
{
objPaperSubAttachmentEN.dicFldComparisonOp[conPaperSubAttachment.PaperSubAttachmentName] = strComparisonOp;
}
}
return objPaperSubAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubAttachmentEN SetFilePath(this clsPaperSubAttachmentEN objPaperSubAttachmentEN, string strFilePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFilePath, conPaperSubAttachment.FilePath);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFilePath, 500, conPaperSubAttachment.FilePath);
}
objPaperSubAttachmentEN.FilePath = strFilePath; //文件路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubAttachmentEN.dicFldComparisonOp.ContainsKey(conPaperSubAttachment.FilePath) == false)
{
objPaperSubAttachmentEN.dicFldComparisonOp.Add(conPaperSubAttachment.FilePath, strComparisonOp);
}
else
{
objPaperSubAttachmentEN.dicFldComparisonOp[conPaperSubAttachment.FilePath] = strComparisonOp;
}
}
return objPaperSubAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubAttachmentEN SetIdCurrEduCls(this clsPaperSubAttachmentEN objPaperSubAttachmentEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conPaperSubAttachment.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conPaperSubAttachment.IdCurrEduCls);
}
objPaperSubAttachmentEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubAttachmentEN.dicFldComparisonOp.ContainsKey(conPaperSubAttachment.IdCurrEduCls) == false)
{
objPaperSubAttachmentEN.dicFldComparisonOp.Add(conPaperSubAttachment.IdCurrEduCls, strComparisonOp);
}
else
{
objPaperSubAttachmentEN.dicFldComparisonOp[conPaperSubAttachment.IdCurrEduCls] = strComparisonOp;
}
}
return objPaperSubAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubAttachmentEN SetPaperRWId(this clsPaperSubAttachmentEN objPaperSubAttachmentEN, string strPaperRWId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperRWId, 8, conPaperSubAttachment.PaperRWId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperRWId, 8, conPaperSubAttachment.PaperRWId);
}
objPaperSubAttachmentEN.PaperRWId = strPaperRWId; //课文阅读
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubAttachmentEN.dicFldComparisonOp.ContainsKey(conPaperSubAttachment.PaperRWId) == false)
{
objPaperSubAttachmentEN.dicFldComparisonOp.Add(conPaperSubAttachment.PaperRWId, strComparisonOp);
}
else
{
objPaperSubAttachmentEN.dicFldComparisonOp[conPaperSubAttachment.PaperRWId] = strComparisonOp;
}
}
return objPaperSubAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubAttachmentEN SetSubViewpointId(this clsPaperSubAttachmentEN objPaperSubAttachmentEN, long lngSubViewpointId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngSubViewpointId, conPaperSubAttachment.SubViewpointId);
objPaperSubAttachmentEN.SubViewpointId = lngSubViewpointId; //子观点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubAttachmentEN.dicFldComparisonOp.ContainsKey(conPaperSubAttachment.SubViewpointId) == false)
{
objPaperSubAttachmentEN.dicFldComparisonOp.Add(conPaperSubAttachment.SubViewpointId, strComparisonOp);
}
else
{
objPaperSubAttachmentEN.dicFldComparisonOp[conPaperSubAttachment.SubViewpointId] = strComparisonOp;
}
}
return objPaperSubAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubAttachmentEN SetUpdUserId(this clsPaperSubAttachmentEN objPaperSubAttachmentEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conPaperSubAttachment.UpdUserId);
}
objPaperSubAttachmentEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubAttachmentEN.dicFldComparisonOp.ContainsKey(conPaperSubAttachment.UpdUserId) == false)
{
objPaperSubAttachmentEN.dicFldComparisonOp.Add(conPaperSubAttachment.UpdUserId, strComparisonOp);
}
else
{
objPaperSubAttachmentEN.dicFldComparisonOp[conPaperSubAttachment.UpdUserId] = strComparisonOp;
}
}
return objPaperSubAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubAttachmentEN SetUpdDate(this clsPaperSubAttachmentEN objPaperSubAttachmentEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conPaperSubAttachment.UpdDate);
}
objPaperSubAttachmentEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubAttachmentEN.dicFldComparisonOp.ContainsKey(conPaperSubAttachment.UpdDate) == false)
{
objPaperSubAttachmentEN.dicFldComparisonOp.Add(conPaperSubAttachment.UpdDate, strComparisonOp);
}
else
{
objPaperSubAttachmentEN.dicFldComparisonOp[conPaperSubAttachment.UpdDate] = strComparisonOp;
}
}
return objPaperSubAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubAttachmentEN SetMemo(this clsPaperSubAttachmentEN objPaperSubAttachmentEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conPaperSubAttachment.Memo);
}
objPaperSubAttachmentEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubAttachmentEN.dicFldComparisonOp.ContainsKey(conPaperSubAttachment.Memo) == false)
{
objPaperSubAttachmentEN.dicFldComparisonOp.Add(conPaperSubAttachment.Memo, strComparisonOp);
}
else
{
objPaperSubAttachmentEN.dicFldComparisonOp[conPaperSubAttachment.Memo] = strComparisonOp;
}
}
return objPaperSubAttachmentEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objPaperSubAttachmentEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsPaperSubAttachmentEN objPaperSubAttachmentEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objPaperSubAttachmentEN.CheckPropertyNew();
clsPaperSubAttachmentEN objPaperSubAttachmentCond = new clsPaperSubAttachmentEN();
string strCondition = objPaperSubAttachmentCond
.SetPaperSubAttachmentId(objPaperSubAttachmentEN.PaperSubAttachmentId, "<>")
.SetPaperSubAttachmentName(objPaperSubAttachmentEN.PaperSubAttachmentName, "=")
.GetCombineCondition();
objPaperSubAttachmentEN._IsCheckProperty = true;
bool bolIsExist = clsPaperSubAttachmentBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(SubViewpointId_PaperSubAttachmentName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objPaperSubAttachmentEN.Update();
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
 /// <param name = "objPaperSubAttachment">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsPaperSubAttachmentEN objPaperSubAttachment)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsPaperSubAttachmentEN objPaperSubAttachmentCond = new clsPaperSubAttachmentEN();
string strCondition = objPaperSubAttachmentCond
.SetPaperSubAttachmentName(objPaperSubAttachment.PaperSubAttachmentName, "=")
.GetCombineCondition();
objPaperSubAttachment._IsCheckProperty = true;
bool bolIsExist = clsPaperSubAttachmentBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objPaperSubAttachment.PaperSubAttachmentId = clsPaperSubAttachmentBL.GetFirstID_S(strCondition);
objPaperSubAttachment.UpdateWithCondition(strCondition);
}
else
{
objPaperSubAttachment.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objPaperSubAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPaperSubAttachmentEN objPaperSubAttachmentEN)
{
 if (objPaperSubAttachmentEN.PaperSubAttachmentId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPaperSubAttachmentBL.PaperSubAttachmentDA.UpdateBySql2(objPaperSubAttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubAttachmentBL.ReFreshCache();

if (clsPaperSubAttachmentBL.relatedActions != null)
{
clsPaperSubAttachmentBL.relatedActions.UpdRelaTabDate(objPaperSubAttachmentEN.PaperSubAttachmentId, objPaperSubAttachmentEN.UpdUserId);
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
 /// <param name = "objPaperSubAttachmentEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPaperSubAttachmentEN objPaperSubAttachmentEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objPaperSubAttachmentEN.PaperSubAttachmentId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPaperSubAttachmentBL.PaperSubAttachmentDA.UpdateBySql2(objPaperSubAttachmentEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubAttachmentBL.ReFreshCache();

if (clsPaperSubAttachmentBL.relatedActions != null)
{
clsPaperSubAttachmentBL.relatedActions.UpdRelaTabDate(objPaperSubAttachmentEN.PaperSubAttachmentId, objPaperSubAttachmentEN.UpdUserId);
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
 /// <param name = "objPaperSubAttachmentEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPaperSubAttachmentEN objPaperSubAttachmentEN, string strWhereCond)
{
try
{
bool bolResult = clsPaperSubAttachmentBL.PaperSubAttachmentDA.UpdateBySqlWithCondition(objPaperSubAttachmentEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubAttachmentBL.ReFreshCache();

if (clsPaperSubAttachmentBL.relatedActions != null)
{
clsPaperSubAttachmentBL.relatedActions.UpdRelaTabDate(objPaperSubAttachmentEN.PaperSubAttachmentId, objPaperSubAttachmentEN.UpdUserId);
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
 /// <param name = "objPaperSubAttachmentEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPaperSubAttachmentEN objPaperSubAttachmentEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsPaperSubAttachmentBL.PaperSubAttachmentDA.UpdateBySqlWithConditionTransaction(objPaperSubAttachmentEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubAttachmentBL.ReFreshCache();

if (clsPaperSubAttachmentBL.relatedActions != null)
{
clsPaperSubAttachmentBL.relatedActions.UpdRelaTabDate(objPaperSubAttachmentEN.PaperSubAttachmentId, objPaperSubAttachmentEN.UpdUserId);
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
 /// <param name = "lngPaperSubAttachmentId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsPaperSubAttachmentEN objPaperSubAttachmentEN)
{
try
{
int intRecNum = clsPaperSubAttachmentBL.PaperSubAttachmentDA.DelRecord(objPaperSubAttachmentEN.PaperSubAttachmentId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubAttachmentBL.ReFreshCache();

if (clsPaperSubAttachmentBL.relatedActions != null)
{
clsPaperSubAttachmentBL.relatedActions.UpdRelaTabDate(objPaperSubAttachmentEN.PaperSubAttachmentId, objPaperSubAttachmentEN.UpdUserId);
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
 /// <param name = "objPaperSubAttachmentENS">源对象</param>
 /// <param name = "objPaperSubAttachmentENT">目标对象</param>
 public static void CopyTo(this clsPaperSubAttachmentEN objPaperSubAttachmentENS, clsPaperSubAttachmentEN objPaperSubAttachmentENT)
{
try
{
objPaperSubAttachmentENT.PaperSubAttachmentId = objPaperSubAttachmentENS.PaperSubAttachmentId; //子观点附件Id
objPaperSubAttachmentENT.PaperSubAttachmentName = objPaperSubAttachmentENS.PaperSubAttachmentName; //附件名称
objPaperSubAttachmentENT.FilePath = objPaperSubAttachmentENS.FilePath; //文件路径
objPaperSubAttachmentENT.IdCurrEduCls = objPaperSubAttachmentENS.IdCurrEduCls; //教学班流水号
objPaperSubAttachmentENT.PaperRWId = objPaperSubAttachmentENS.PaperRWId; //课文阅读
objPaperSubAttachmentENT.SubViewpointId = objPaperSubAttachmentENS.SubViewpointId; //子观点Id
objPaperSubAttachmentENT.UpdUserId = objPaperSubAttachmentENS.UpdUserId; //修改用户Id
objPaperSubAttachmentENT.UpdDate = objPaperSubAttachmentENS.UpdDate; //修改日期
objPaperSubAttachmentENT.Memo = objPaperSubAttachmentENS.Memo; //备注
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
 /// <param name = "objPaperSubAttachmentENS">源对象</param>
 /// <returns>目标对象=>clsPaperSubAttachmentEN:objPaperSubAttachmentENT</returns>
 public static clsPaperSubAttachmentEN CopyTo(this clsPaperSubAttachmentEN objPaperSubAttachmentENS)
{
try
{
 clsPaperSubAttachmentEN objPaperSubAttachmentENT = new clsPaperSubAttachmentEN()
{
PaperSubAttachmentId = objPaperSubAttachmentENS.PaperSubAttachmentId, //子观点附件Id
PaperSubAttachmentName = objPaperSubAttachmentENS.PaperSubAttachmentName, //附件名称
FilePath = objPaperSubAttachmentENS.FilePath, //文件路径
IdCurrEduCls = objPaperSubAttachmentENS.IdCurrEduCls, //教学班流水号
PaperRWId = objPaperSubAttachmentENS.PaperRWId, //课文阅读
SubViewpointId = objPaperSubAttachmentENS.SubViewpointId, //子观点Id
UpdUserId = objPaperSubAttachmentENS.UpdUserId, //修改用户Id
UpdDate = objPaperSubAttachmentENS.UpdDate, //修改日期
Memo = objPaperSubAttachmentENS.Memo, //备注
};
 return objPaperSubAttachmentENT;
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
public static void CheckPropertyNew(this clsPaperSubAttachmentEN objPaperSubAttachmentEN)
{
 clsPaperSubAttachmentBL.PaperSubAttachmentDA.CheckPropertyNew(objPaperSubAttachmentEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsPaperSubAttachmentEN objPaperSubAttachmentEN)
{
 clsPaperSubAttachmentBL.PaperSubAttachmentDA.CheckProperty4Condition(objPaperSubAttachmentEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsPaperSubAttachmentEN objPaperSubAttachmentCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objPaperSubAttachmentCond.IsUpdated(conPaperSubAttachment.PaperSubAttachmentId) == true)
{
string strComparisonOpPaperSubAttachmentId = objPaperSubAttachmentCond.dicFldComparisonOp[conPaperSubAttachment.PaperSubAttachmentId];
strWhereCond += string.Format(" And {0} {2} {1}", conPaperSubAttachment.PaperSubAttachmentId, objPaperSubAttachmentCond.PaperSubAttachmentId, strComparisonOpPaperSubAttachmentId);
}
if (objPaperSubAttachmentCond.IsUpdated(conPaperSubAttachment.PaperSubAttachmentName) == true)
{
string strComparisonOpPaperSubAttachmentName = objPaperSubAttachmentCond.dicFldComparisonOp[conPaperSubAttachment.PaperSubAttachmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubAttachment.PaperSubAttachmentName, objPaperSubAttachmentCond.PaperSubAttachmentName, strComparisonOpPaperSubAttachmentName);
}
if (objPaperSubAttachmentCond.IsUpdated(conPaperSubAttachment.FilePath) == true)
{
string strComparisonOpFilePath = objPaperSubAttachmentCond.dicFldComparisonOp[conPaperSubAttachment.FilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubAttachment.FilePath, objPaperSubAttachmentCond.FilePath, strComparisonOpFilePath);
}
if (objPaperSubAttachmentCond.IsUpdated(conPaperSubAttachment.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objPaperSubAttachmentCond.dicFldComparisonOp[conPaperSubAttachment.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubAttachment.IdCurrEduCls, objPaperSubAttachmentCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objPaperSubAttachmentCond.IsUpdated(conPaperSubAttachment.PaperRWId) == true)
{
string strComparisonOpPaperRWId = objPaperSubAttachmentCond.dicFldComparisonOp[conPaperSubAttachment.PaperRWId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubAttachment.PaperRWId, objPaperSubAttachmentCond.PaperRWId, strComparisonOpPaperRWId);
}
if (objPaperSubAttachmentCond.IsUpdated(conPaperSubAttachment.SubViewpointId) == true)
{
string strComparisonOpSubViewpointId = objPaperSubAttachmentCond.dicFldComparisonOp[conPaperSubAttachment.SubViewpointId];
strWhereCond += string.Format(" And {0} {2} {1}", conPaperSubAttachment.SubViewpointId, objPaperSubAttachmentCond.SubViewpointId, strComparisonOpSubViewpointId);
}
if (objPaperSubAttachmentCond.IsUpdated(conPaperSubAttachment.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objPaperSubAttachmentCond.dicFldComparisonOp[conPaperSubAttachment.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubAttachment.UpdUserId, objPaperSubAttachmentCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objPaperSubAttachmentCond.IsUpdated(conPaperSubAttachment.UpdDate) == true)
{
string strComparisonOpUpdDate = objPaperSubAttachmentCond.dicFldComparisonOp[conPaperSubAttachment.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubAttachment.UpdDate, objPaperSubAttachmentCond.UpdDate, strComparisonOpUpdDate);
}
if (objPaperSubAttachmentCond.IsUpdated(conPaperSubAttachment.Memo) == true)
{
string strComparisonOpMemo = objPaperSubAttachmentCond.dicFldComparisonOp[conPaperSubAttachment.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubAttachment.Memo, objPaperSubAttachmentCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--PaperSubAttachment(子观点附件), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:SubViewpointId_PaperSubAttachmentName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objPaperSubAttachmentEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsPaperSubAttachmentEN objPaperSubAttachmentEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objPaperSubAttachmentEN == null) return true;
if (objPaperSubAttachmentEN.PaperSubAttachmentId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objPaperSubAttachmentEN.PaperSubAttachmentName == null)
{
 sbCondition.AppendFormat(" and PaperSubAttachmentName is null", objPaperSubAttachmentEN.PaperSubAttachmentName);
}
else
{
 sbCondition.AppendFormat(" and PaperSubAttachmentName = '{0}'", objPaperSubAttachmentEN.PaperSubAttachmentName);
}
if (clsPaperSubAttachmentBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("PaperSubAttachmentId !=  {0}", objPaperSubAttachmentEN.PaperSubAttachmentId);
 sbCondition.AppendFormat(" and PaperSubAttachmentName = '{0}'", objPaperSubAttachmentEN.PaperSubAttachmentName);
if (clsPaperSubAttachmentBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--PaperSubAttachment(子观点附件), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:SubViewpointId_PaperSubAttachmentName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objPaperSubAttachmentEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsPaperSubAttachmentEN objPaperSubAttachmentEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objPaperSubAttachmentEN == null) return "";
if (objPaperSubAttachmentEN.PaperSubAttachmentId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objPaperSubAttachmentEN.PaperSubAttachmentName == null)
{
 sbCondition.AppendFormat(" and PaperSubAttachmentName is null", objPaperSubAttachmentEN.PaperSubAttachmentName);
}
else
{
 sbCondition.AppendFormat(" and PaperSubAttachmentName = '{0}'", objPaperSubAttachmentEN.PaperSubAttachmentName);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("PaperSubAttachmentId !=  {0}", objPaperSubAttachmentEN.PaperSubAttachmentId);
 sbCondition.AppendFormat(" and PaperSubAttachmentName = '{0}'", objPaperSubAttachmentEN.PaperSubAttachmentName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_PaperSubAttachment
{
public virtual bool UpdRelaTabDate(long lngPaperSubAttachmentId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 子观点附件(PaperSubAttachment)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsPaperSubAttachmentBL
{
public static RelatedActions_PaperSubAttachment relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsPaperSubAttachmentDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsPaperSubAttachmentDA PaperSubAttachmentDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsPaperSubAttachmentDA();
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
 public clsPaperSubAttachmentBL()
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
if (string.IsNullOrEmpty(clsPaperSubAttachmentEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsPaperSubAttachmentEN._ConnectString);
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
public static DataTable GetDataTable_PaperSubAttachment(string strWhereCond)
{
DataTable objDT;
try
{
objDT = PaperSubAttachmentDA.GetDataTable_PaperSubAttachment(strWhereCond);
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
objDT = PaperSubAttachmentDA.GetDataTable(strWhereCond);
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
objDT = PaperSubAttachmentDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = PaperSubAttachmentDA.GetDataTable(strWhereCond, strTabName);
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
objDT = PaperSubAttachmentDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = PaperSubAttachmentDA.GetDataTable_Top(objTopPara);
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
objDT = PaperSubAttachmentDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = PaperSubAttachmentDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = PaperSubAttachmentDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrPaperSubAttachmentIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsPaperSubAttachmentEN> GetObjLstByPaperSubAttachmentIdLst(List<long> arrPaperSubAttachmentIdLst)
{
List<clsPaperSubAttachmentEN> arrObjLst = new List<clsPaperSubAttachmentEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrPaperSubAttachmentIdLst);
 string strWhereCond = string.Format("PaperSubAttachmentId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperSubAttachmentEN objPaperSubAttachmentEN = new clsPaperSubAttachmentEN();
try
{
objPaperSubAttachmentEN.PaperSubAttachmentId = Int32.Parse(objRow[conPaperSubAttachment.PaperSubAttachmentId].ToString().Trim()); //子观点附件Id
objPaperSubAttachmentEN.PaperSubAttachmentName = objRow[conPaperSubAttachment.PaperSubAttachmentName] == DBNull.Value ? null : objRow[conPaperSubAttachment.PaperSubAttachmentName].ToString().Trim(); //附件名称
objPaperSubAttachmentEN.FilePath = objRow[conPaperSubAttachment.FilePath].ToString().Trim(); //文件路径
objPaperSubAttachmentEN.IdCurrEduCls = objRow[conPaperSubAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[conPaperSubAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperSubAttachmentEN.PaperRWId = objRow[conPaperSubAttachment.PaperRWId] == DBNull.Value ? null : objRow[conPaperSubAttachment.PaperRWId].ToString().Trim(); //课文阅读
objPaperSubAttachmentEN.SubViewpointId = Int32.Parse(objRow[conPaperSubAttachment.SubViewpointId].ToString().Trim()); //子观点Id
objPaperSubAttachmentEN.UpdUserId = objRow[conPaperSubAttachment.UpdUserId] == DBNull.Value ? null : objRow[conPaperSubAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objPaperSubAttachmentEN.UpdDate = objRow[conPaperSubAttachment.UpdDate] == DBNull.Value ? null : objRow[conPaperSubAttachment.UpdDate].ToString().Trim(); //修改日期
objPaperSubAttachmentEN.Memo = objRow[conPaperSubAttachment.Memo] == DBNull.Value ? null : objRow[conPaperSubAttachment.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperSubAttachmentEN.PaperSubAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperSubAttachmentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPaperSubAttachmentIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsPaperSubAttachmentEN> GetObjLstByPaperSubAttachmentIdLstCache(List<long> arrPaperSubAttachmentIdLst)
{
string strKey = string.Format("{0}", clsPaperSubAttachmentEN._CurrTabName);
List<clsPaperSubAttachmentEN> arrPaperSubAttachmentObjLstCache = GetObjLstCache();
IEnumerable <clsPaperSubAttachmentEN> arrPaperSubAttachmentObjLst_Sel =
arrPaperSubAttachmentObjLstCache
.Where(x => arrPaperSubAttachmentIdLst.Contains(x.PaperSubAttachmentId));
return arrPaperSubAttachmentObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsPaperSubAttachmentEN> GetObjLst(string strWhereCond)
{
List<clsPaperSubAttachmentEN> arrObjLst = new List<clsPaperSubAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperSubAttachmentEN objPaperSubAttachmentEN = new clsPaperSubAttachmentEN();
try
{
objPaperSubAttachmentEN.PaperSubAttachmentId = Int32.Parse(objRow[conPaperSubAttachment.PaperSubAttachmentId].ToString().Trim()); //子观点附件Id
objPaperSubAttachmentEN.PaperSubAttachmentName = objRow[conPaperSubAttachment.PaperSubAttachmentName] == DBNull.Value ? null : objRow[conPaperSubAttachment.PaperSubAttachmentName].ToString().Trim(); //附件名称
objPaperSubAttachmentEN.FilePath = objRow[conPaperSubAttachment.FilePath].ToString().Trim(); //文件路径
objPaperSubAttachmentEN.IdCurrEduCls = objRow[conPaperSubAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[conPaperSubAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperSubAttachmentEN.PaperRWId = objRow[conPaperSubAttachment.PaperRWId] == DBNull.Value ? null : objRow[conPaperSubAttachment.PaperRWId].ToString().Trim(); //课文阅读
objPaperSubAttachmentEN.SubViewpointId = Int32.Parse(objRow[conPaperSubAttachment.SubViewpointId].ToString().Trim()); //子观点Id
objPaperSubAttachmentEN.UpdUserId = objRow[conPaperSubAttachment.UpdUserId] == DBNull.Value ? null : objRow[conPaperSubAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objPaperSubAttachmentEN.UpdDate = objRow[conPaperSubAttachment.UpdDate] == DBNull.Value ? null : objRow[conPaperSubAttachment.UpdDate].ToString().Trim(); //修改日期
objPaperSubAttachmentEN.Memo = objRow[conPaperSubAttachment.Memo] == DBNull.Value ? null : objRow[conPaperSubAttachment.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperSubAttachmentEN.PaperSubAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperSubAttachmentEN);
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
public static List<clsPaperSubAttachmentEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsPaperSubAttachmentEN> arrObjLst = new List<clsPaperSubAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperSubAttachmentEN objPaperSubAttachmentEN = new clsPaperSubAttachmentEN();
try
{
objPaperSubAttachmentEN.PaperSubAttachmentId = Int32.Parse(objRow[conPaperSubAttachment.PaperSubAttachmentId].ToString().Trim()); //子观点附件Id
objPaperSubAttachmentEN.PaperSubAttachmentName = objRow[conPaperSubAttachment.PaperSubAttachmentName] == DBNull.Value ? null : objRow[conPaperSubAttachment.PaperSubAttachmentName].ToString().Trim(); //附件名称
objPaperSubAttachmentEN.FilePath = objRow[conPaperSubAttachment.FilePath].ToString().Trim(); //文件路径
objPaperSubAttachmentEN.IdCurrEduCls = objRow[conPaperSubAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[conPaperSubAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperSubAttachmentEN.PaperRWId = objRow[conPaperSubAttachment.PaperRWId] == DBNull.Value ? null : objRow[conPaperSubAttachment.PaperRWId].ToString().Trim(); //课文阅读
objPaperSubAttachmentEN.SubViewpointId = Int32.Parse(objRow[conPaperSubAttachment.SubViewpointId].ToString().Trim()); //子观点Id
objPaperSubAttachmentEN.UpdUserId = objRow[conPaperSubAttachment.UpdUserId] == DBNull.Value ? null : objRow[conPaperSubAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objPaperSubAttachmentEN.UpdDate = objRow[conPaperSubAttachment.UpdDate] == DBNull.Value ? null : objRow[conPaperSubAttachment.UpdDate].ToString().Trim(); //修改日期
objPaperSubAttachmentEN.Memo = objRow[conPaperSubAttachment.Memo] == DBNull.Value ? null : objRow[conPaperSubAttachment.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperSubAttachmentEN.PaperSubAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperSubAttachmentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objPaperSubAttachmentCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsPaperSubAttachmentEN> GetSubObjLstCache(clsPaperSubAttachmentEN objPaperSubAttachmentCond)
{
List<clsPaperSubAttachmentEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsPaperSubAttachmentEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPaperSubAttachment.AttributeName)
{
if (objPaperSubAttachmentCond.IsUpdated(strFldName) == false) continue;
if (objPaperSubAttachmentCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPaperSubAttachmentCond[strFldName].ToString());
}
else
{
if (objPaperSubAttachmentCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPaperSubAttachmentCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPaperSubAttachmentCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPaperSubAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPaperSubAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPaperSubAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPaperSubAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPaperSubAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPaperSubAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPaperSubAttachmentCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPaperSubAttachmentCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPaperSubAttachmentCond[strFldName]));
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
public static List<clsPaperSubAttachmentEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsPaperSubAttachmentEN> arrObjLst = new List<clsPaperSubAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperSubAttachmentEN objPaperSubAttachmentEN = new clsPaperSubAttachmentEN();
try
{
objPaperSubAttachmentEN.PaperSubAttachmentId = Int32.Parse(objRow[conPaperSubAttachment.PaperSubAttachmentId].ToString().Trim()); //子观点附件Id
objPaperSubAttachmentEN.PaperSubAttachmentName = objRow[conPaperSubAttachment.PaperSubAttachmentName] == DBNull.Value ? null : objRow[conPaperSubAttachment.PaperSubAttachmentName].ToString().Trim(); //附件名称
objPaperSubAttachmentEN.FilePath = objRow[conPaperSubAttachment.FilePath].ToString().Trim(); //文件路径
objPaperSubAttachmentEN.IdCurrEduCls = objRow[conPaperSubAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[conPaperSubAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperSubAttachmentEN.PaperRWId = objRow[conPaperSubAttachment.PaperRWId] == DBNull.Value ? null : objRow[conPaperSubAttachment.PaperRWId].ToString().Trim(); //课文阅读
objPaperSubAttachmentEN.SubViewpointId = Int32.Parse(objRow[conPaperSubAttachment.SubViewpointId].ToString().Trim()); //子观点Id
objPaperSubAttachmentEN.UpdUserId = objRow[conPaperSubAttachment.UpdUserId] == DBNull.Value ? null : objRow[conPaperSubAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objPaperSubAttachmentEN.UpdDate = objRow[conPaperSubAttachment.UpdDate] == DBNull.Value ? null : objRow[conPaperSubAttachment.UpdDate].ToString().Trim(); //修改日期
objPaperSubAttachmentEN.Memo = objRow[conPaperSubAttachment.Memo] == DBNull.Value ? null : objRow[conPaperSubAttachment.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperSubAttachmentEN.PaperSubAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperSubAttachmentEN);
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
public static List<clsPaperSubAttachmentEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsPaperSubAttachmentEN> arrObjLst = new List<clsPaperSubAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperSubAttachmentEN objPaperSubAttachmentEN = new clsPaperSubAttachmentEN();
try
{
objPaperSubAttachmentEN.PaperSubAttachmentId = Int32.Parse(objRow[conPaperSubAttachment.PaperSubAttachmentId].ToString().Trim()); //子观点附件Id
objPaperSubAttachmentEN.PaperSubAttachmentName = objRow[conPaperSubAttachment.PaperSubAttachmentName] == DBNull.Value ? null : objRow[conPaperSubAttachment.PaperSubAttachmentName].ToString().Trim(); //附件名称
objPaperSubAttachmentEN.FilePath = objRow[conPaperSubAttachment.FilePath].ToString().Trim(); //文件路径
objPaperSubAttachmentEN.IdCurrEduCls = objRow[conPaperSubAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[conPaperSubAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperSubAttachmentEN.PaperRWId = objRow[conPaperSubAttachment.PaperRWId] == DBNull.Value ? null : objRow[conPaperSubAttachment.PaperRWId].ToString().Trim(); //课文阅读
objPaperSubAttachmentEN.SubViewpointId = Int32.Parse(objRow[conPaperSubAttachment.SubViewpointId].ToString().Trim()); //子观点Id
objPaperSubAttachmentEN.UpdUserId = objRow[conPaperSubAttachment.UpdUserId] == DBNull.Value ? null : objRow[conPaperSubAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objPaperSubAttachmentEN.UpdDate = objRow[conPaperSubAttachment.UpdDate] == DBNull.Value ? null : objRow[conPaperSubAttachment.UpdDate].ToString().Trim(); //修改日期
objPaperSubAttachmentEN.Memo = objRow[conPaperSubAttachment.Memo] == DBNull.Value ? null : objRow[conPaperSubAttachment.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperSubAttachmentEN.PaperSubAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperSubAttachmentEN);
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
List<clsPaperSubAttachmentEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsPaperSubAttachmentEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsPaperSubAttachmentEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsPaperSubAttachmentEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsPaperSubAttachmentEN> arrObjLst = new List<clsPaperSubAttachmentEN>(); 
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
	clsPaperSubAttachmentEN objPaperSubAttachmentEN = new clsPaperSubAttachmentEN();
try
{
objPaperSubAttachmentEN.PaperSubAttachmentId = Int32.Parse(objRow[conPaperSubAttachment.PaperSubAttachmentId].ToString().Trim()); //子观点附件Id
objPaperSubAttachmentEN.PaperSubAttachmentName = objRow[conPaperSubAttachment.PaperSubAttachmentName] == DBNull.Value ? null : objRow[conPaperSubAttachment.PaperSubAttachmentName].ToString().Trim(); //附件名称
objPaperSubAttachmentEN.FilePath = objRow[conPaperSubAttachment.FilePath].ToString().Trim(); //文件路径
objPaperSubAttachmentEN.IdCurrEduCls = objRow[conPaperSubAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[conPaperSubAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperSubAttachmentEN.PaperRWId = objRow[conPaperSubAttachment.PaperRWId] == DBNull.Value ? null : objRow[conPaperSubAttachment.PaperRWId].ToString().Trim(); //课文阅读
objPaperSubAttachmentEN.SubViewpointId = Int32.Parse(objRow[conPaperSubAttachment.SubViewpointId].ToString().Trim()); //子观点Id
objPaperSubAttachmentEN.UpdUserId = objRow[conPaperSubAttachment.UpdUserId] == DBNull.Value ? null : objRow[conPaperSubAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objPaperSubAttachmentEN.UpdDate = objRow[conPaperSubAttachment.UpdDate] == DBNull.Value ? null : objRow[conPaperSubAttachment.UpdDate].ToString().Trim(); //修改日期
objPaperSubAttachmentEN.Memo = objRow[conPaperSubAttachment.Memo] == DBNull.Value ? null : objRow[conPaperSubAttachment.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperSubAttachmentEN.PaperSubAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperSubAttachmentEN);
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
public static List<clsPaperSubAttachmentEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsPaperSubAttachmentEN> arrObjLst = new List<clsPaperSubAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperSubAttachmentEN objPaperSubAttachmentEN = new clsPaperSubAttachmentEN();
try
{
objPaperSubAttachmentEN.PaperSubAttachmentId = Int32.Parse(objRow[conPaperSubAttachment.PaperSubAttachmentId].ToString().Trim()); //子观点附件Id
objPaperSubAttachmentEN.PaperSubAttachmentName = objRow[conPaperSubAttachment.PaperSubAttachmentName] == DBNull.Value ? null : objRow[conPaperSubAttachment.PaperSubAttachmentName].ToString().Trim(); //附件名称
objPaperSubAttachmentEN.FilePath = objRow[conPaperSubAttachment.FilePath].ToString().Trim(); //文件路径
objPaperSubAttachmentEN.IdCurrEduCls = objRow[conPaperSubAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[conPaperSubAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperSubAttachmentEN.PaperRWId = objRow[conPaperSubAttachment.PaperRWId] == DBNull.Value ? null : objRow[conPaperSubAttachment.PaperRWId].ToString().Trim(); //课文阅读
objPaperSubAttachmentEN.SubViewpointId = Int32.Parse(objRow[conPaperSubAttachment.SubViewpointId].ToString().Trim()); //子观点Id
objPaperSubAttachmentEN.UpdUserId = objRow[conPaperSubAttachment.UpdUserId] == DBNull.Value ? null : objRow[conPaperSubAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objPaperSubAttachmentEN.UpdDate = objRow[conPaperSubAttachment.UpdDate] == DBNull.Value ? null : objRow[conPaperSubAttachment.UpdDate].ToString().Trim(); //修改日期
objPaperSubAttachmentEN.Memo = objRow[conPaperSubAttachment.Memo] == DBNull.Value ? null : objRow[conPaperSubAttachment.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperSubAttachmentEN.PaperSubAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperSubAttachmentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsPaperSubAttachmentEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsPaperSubAttachmentEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsPaperSubAttachmentEN> arrObjLst = new List<clsPaperSubAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperSubAttachmentEN objPaperSubAttachmentEN = new clsPaperSubAttachmentEN();
try
{
objPaperSubAttachmentEN.PaperSubAttachmentId = Int32.Parse(objRow[conPaperSubAttachment.PaperSubAttachmentId].ToString().Trim()); //子观点附件Id
objPaperSubAttachmentEN.PaperSubAttachmentName = objRow[conPaperSubAttachment.PaperSubAttachmentName] == DBNull.Value ? null : objRow[conPaperSubAttachment.PaperSubAttachmentName].ToString().Trim(); //附件名称
objPaperSubAttachmentEN.FilePath = objRow[conPaperSubAttachment.FilePath].ToString().Trim(); //文件路径
objPaperSubAttachmentEN.IdCurrEduCls = objRow[conPaperSubAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[conPaperSubAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperSubAttachmentEN.PaperRWId = objRow[conPaperSubAttachment.PaperRWId] == DBNull.Value ? null : objRow[conPaperSubAttachment.PaperRWId].ToString().Trim(); //课文阅读
objPaperSubAttachmentEN.SubViewpointId = Int32.Parse(objRow[conPaperSubAttachment.SubViewpointId].ToString().Trim()); //子观点Id
objPaperSubAttachmentEN.UpdUserId = objRow[conPaperSubAttachment.UpdUserId] == DBNull.Value ? null : objRow[conPaperSubAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objPaperSubAttachmentEN.UpdDate = objRow[conPaperSubAttachment.UpdDate] == DBNull.Value ? null : objRow[conPaperSubAttachment.UpdDate].ToString().Trim(); //修改日期
objPaperSubAttachmentEN.Memo = objRow[conPaperSubAttachment.Memo] == DBNull.Value ? null : objRow[conPaperSubAttachment.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperSubAttachmentEN.PaperSubAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperSubAttachmentEN);
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
public static List<clsPaperSubAttachmentEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsPaperSubAttachmentEN> arrObjLst = new List<clsPaperSubAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperSubAttachmentEN objPaperSubAttachmentEN = new clsPaperSubAttachmentEN();
try
{
objPaperSubAttachmentEN.PaperSubAttachmentId = Int32.Parse(objRow[conPaperSubAttachment.PaperSubAttachmentId].ToString().Trim()); //子观点附件Id
objPaperSubAttachmentEN.PaperSubAttachmentName = objRow[conPaperSubAttachment.PaperSubAttachmentName] == DBNull.Value ? null : objRow[conPaperSubAttachment.PaperSubAttachmentName].ToString().Trim(); //附件名称
objPaperSubAttachmentEN.FilePath = objRow[conPaperSubAttachment.FilePath].ToString().Trim(); //文件路径
objPaperSubAttachmentEN.IdCurrEduCls = objRow[conPaperSubAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[conPaperSubAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperSubAttachmentEN.PaperRWId = objRow[conPaperSubAttachment.PaperRWId] == DBNull.Value ? null : objRow[conPaperSubAttachment.PaperRWId].ToString().Trim(); //课文阅读
objPaperSubAttachmentEN.SubViewpointId = Int32.Parse(objRow[conPaperSubAttachment.SubViewpointId].ToString().Trim()); //子观点Id
objPaperSubAttachmentEN.UpdUserId = objRow[conPaperSubAttachment.UpdUserId] == DBNull.Value ? null : objRow[conPaperSubAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objPaperSubAttachmentEN.UpdDate = objRow[conPaperSubAttachment.UpdDate] == DBNull.Value ? null : objRow[conPaperSubAttachment.UpdDate].ToString().Trim(); //修改日期
objPaperSubAttachmentEN.Memo = objRow[conPaperSubAttachment.Memo] == DBNull.Value ? null : objRow[conPaperSubAttachment.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperSubAttachmentEN.PaperSubAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperSubAttachmentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsPaperSubAttachmentEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsPaperSubAttachmentEN> arrObjLst = new List<clsPaperSubAttachmentEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperSubAttachmentEN objPaperSubAttachmentEN = new clsPaperSubAttachmentEN();
try
{
objPaperSubAttachmentEN.PaperSubAttachmentId = Int32.Parse(objRow[conPaperSubAttachment.PaperSubAttachmentId].ToString().Trim()); //子观点附件Id
objPaperSubAttachmentEN.PaperSubAttachmentName = objRow[conPaperSubAttachment.PaperSubAttachmentName] == DBNull.Value ? null : objRow[conPaperSubAttachment.PaperSubAttachmentName].ToString().Trim(); //附件名称
objPaperSubAttachmentEN.FilePath = objRow[conPaperSubAttachment.FilePath].ToString().Trim(); //文件路径
objPaperSubAttachmentEN.IdCurrEduCls = objRow[conPaperSubAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[conPaperSubAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperSubAttachmentEN.PaperRWId = objRow[conPaperSubAttachment.PaperRWId] == DBNull.Value ? null : objRow[conPaperSubAttachment.PaperRWId].ToString().Trim(); //课文阅读
objPaperSubAttachmentEN.SubViewpointId = Int32.Parse(objRow[conPaperSubAttachment.SubViewpointId].ToString().Trim()); //子观点Id
objPaperSubAttachmentEN.UpdUserId = objRow[conPaperSubAttachment.UpdUserId] == DBNull.Value ? null : objRow[conPaperSubAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objPaperSubAttachmentEN.UpdDate = objRow[conPaperSubAttachment.UpdDate] == DBNull.Value ? null : objRow[conPaperSubAttachment.UpdDate].ToString().Trim(); //修改日期
objPaperSubAttachmentEN.Memo = objRow[conPaperSubAttachment.Memo] == DBNull.Value ? null : objRow[conPaperSubAttachment.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperSubAttachmentEN.PaperSubAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperSubAttachmentEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objPaperSubAttachmentEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetPaperSubAttachment(ref clsPaperSubAttachmentEN objPaperSubAttachmentEN)
{
bool bolResult = PaperSubAttachmentDA.GetPaperSubAttachment(ref objPaperSubAttachmentEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngPaperSubAttachmentId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPaperSubAttachmentEN GetObjByPaperSubAttachmentId(long lngPaperSubAttachmentId)
{
clsPaperSubAttachmentEN objPaperSubAttachmentEN = PaperSubAttachmentDA.GetObjByPaperSubAttachmentId(lngPaperSubAttachmentId);
return objPaperSubAttachmentEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsPaperSubAttachmentEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsPaperSubAttachmentEN objPaperSubAttachmentEN = PaperSubAttachmentDA.GetFirstObj(strWhereCond);
 return objPaperSubAttachmentEN;
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
public static clsPaperSubAttachmentEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsPaperSubAttachmentEN objPaperSubAttachmentEN = PaperSubAttachmentDA.GetObjByDataRow(objRow);
 return objPaperSubAttachmentEN;
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
public static clsPaperSubAttachmentEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsPaperSubAttachmentEN objPaperSubAttachmentEN = PaperSubAttachmentDA.GetObjByDataRow(objRow);
 return objPaperSubAttachmentEN;
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
 /// <param name = "lngPaperSubAttachmentId">所给的关键字</param>
 /// <param name = "lstPaperSubAttachmentObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPaperSubAttachmentEN GetObjByPaperSubAttachmentIdFromList(long lngPaperSubAttachmentId, List<clsPaperSubAttachmentEN> lstPaperSubAttachmentObjLst)
{
foreach (clsPaperSubAttachmentEN objPaperSubAttachmentEN in lstPaperSubAttachmentObjLst)
{
if (objPaperSubAttachmentEN.PaperSubAttachmentId == lngPaperSubAttachmentId)
{
return objPaperSubAttachmentEN;
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
 long lngPaperSubAttachmentId;
 try
 {
 lngPaperSubAttachmentId = new clsPaperSubAttachmentDA().GetFirstID(strWhereCond);
 return lngPaperSubAttachmentId;
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
 arrList = PaperSubAttachmentDA.GetID(strWhereCond);
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
bool bolIsExist = PaperSubAttachmentDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngPaperSubAttachmentId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngPaperSubAttachmentId)
{
//检测记录是否存在
bool bolIsExist = PaperSubAttachmentDA.IsExist(lngPaperSubAttachmentId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngPaperSubAttachmentId">子观点附件Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngPaperSubAttachmentId, string strOpUser)
{
clsPaperSubAttachmentEN objPaperSubAttachmentEN = clsPaperSubAttachmentBL.GetObjByPaperSubAttachmentId(lngPaperSubAttachmentId);
objPaperSubAttachmentEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objPaperSubAttachmentEN.UpdUserId = strOpUser;
return clsPaperSubAttachmentBL.UpdateBySql2(objPaperSubAttachmentEN);
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
 bolIsExist = clsPaperSubAttachmentDA.IsExistTable();
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
 bolIsExist = PaperSubAttachmentDA.IsExistTable(strTabName);
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
 /// <param name = "objPaperSubAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsPaperSubAttachmentEN objPaperSubAttachmentEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objPaperSubAttachmentEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!附件名称 = [{0}]的数据已经存在!(in clsPaperSubAttachmentBL.AddNewRecordBySql2)", objPaperSubAttachmentEN.PaperSubAttachmentName);
throw new Exception(strMsg);
}
try
{
bool bolResult = PaperSubAttachmentDA.AddNewRecordBySQL2(objPaperSubAttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubAttachmentBL.ReFreshCache();

if (clsPaperSubAttachmentBL.relatedActions != null)
{
clsPaperSubAttachmentBL.relatedActions.UpdRelaTabDate(objPaperSubAttachmentEN.PaperSubAttachmentId, objPaperSubAttachmentEN.UpdUserId);
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
 /// <param name = "objPaperSubAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsPaperSubAttachmentEN objPaperSubAttachmentEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objPaperSubAttachmentEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!附件名称 = [{0}]的数据已经存在!(in clsPaperSubAttachmentBL.AddNewRecordBySql2WithReturnKey)", objPaperSubAttachmentEN.PaperSubAttachmentName);
throw new Exception(strMsg);
}
try
{
string strKey = PaperSubAttachmentDA.AddNewRecordBySQL2WithReturnKey(objPaperSubAttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubAttachmentBL.ReFreshCache();

if (clsPaperSubAttachmentBL.relatedActions != null)
{
clsPaperSubAttachmentBL.relatedActions.UpdRelaTabDate(objPaperSubAttachmentEN.PaperSubAttachmentId, objPaperSubAttachmentEN.UpdUserId);
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
 /// <param name = "objPaperSubAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsPaperSubAttachmentEN objPaperSubAttachmentEN)
{
try
{
bool bolResult = PaperSubAttachmentDA.Update(objPaperSubAttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubAttachmentBL.ReFreshCache();

if (clsPaperSubAttachmentBL.relatedActions != null)
{
clsPaperSubAttachmentBL.relatedActions.UpdRelaTabDate(objPaperSubAttachmentEN.PaperSubAttachmentId, objPaperSubAttachmentEN.UpdUserId);
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
 /// <param name = "objPaperSubAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsPaperSubAttachmentEN objPaperSubAttachmentEN)
{
 if (objPaperSubAttachmentEN.PaperSubAttachmentId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = PaperSubAttachmentDA.UpdateBySql2(objPaperSubAttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubAttachmentBL.ReFreshCache();

if (clsPaperSubAttachmentBL.relatedActions != null)
{
clsPaperSubAttachmentBL.relatedActions.UpdRelaTabDate(objPaperSubAttachmentEN.PaperSubAttachmentId, objPaperSubAttachmentEN.UpdUserId);
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
 /// <param name = "lngPaperSubAttachmentId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngPaperSubAttachmentId)
{
try
{
 clsPaperSubAttachmentEN objPaperSubAttachmentEN = clsPaperSubAttachmentBL.GetObjByPaperSubAttachmentId(lngPaperSubAttachmentId);

if (clsPaperSubAttachmentBL.relatedActions != null)
{
clsPaperSubAttachmentBL.relatedActions.UpdRelaTabDate(objPaperSubAttachmentEN.PaperSubAttachmentId, objPaperSubAttachmentEN.UpdUserId);
}
if (objPaperSubAttachmentEN != null)
{
int intRecNum = PaperSubAttachmentDA.DelRecord(lngPaperSubAttachmentId);
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
/// <param name="lngPaperSubAttachmentId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngPaperSubAttachmentId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPaperSubAttachmentDA.GetSpecSQLObj();
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
//删除与表:[PaperSubAttachment]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conPaperSubAttachment.PaperSubAttachmentId,
//lngPaperSubAttachmentId);
//        clsPaperSubAttachmentBL.DelPaperSubAttachmentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPaperSubAttachmentBL.DelRecord(lngPaperSubAttachmentId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPaperSubAttachmentBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngPaperSubAttachmentId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngPaperSubAttachmentId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngPaperSubAttachmentId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsPaperSubAttachmentBL.relatedActions != null)
{
clsPaperSubAttachmentBL.relatedActions.UpdRelaTabDate(lngPaperSubAttachmentId, "UpdRelaTabDate");
}
bool bolResult = PaperSubAttachmentDA.DelRecord(lngPaperSubAttachmentId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrPaperSubAttachmentIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelPaperSubAttachments(List<string> arrPaperSubAttachmentIdLst)
{
if (arrPaperSubAttachmentIdLst.Count == 0) return 0;
try
{
if (clsPaperSubAttachmentBL.relatedActions != null)
{
foreach (var strPaperSubAttachmentId in arrPaperSubAttachmentIdLst)
{
long lngPaperSubAttachmentId = long.Parse(strPaperSubAttachmentId);
clsPaperSubAttachmentBL.relatedActions.UpdRelaTabDate(lngPaperSubAttachmentId, "UpdRelaTabDate");
}
}
int intDelRecNum = PaperSubAttachmentDA.DelPaperSubAttachment(arrPaperSubAttachmentIdLst);
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
public static int DelPaperSubAttachmentsByCond(string strWhereCond)
{
try
{
if (clsPaperSubAttachmentBL.relatedActions != null)
{
List<string> arrPaperSubAttachmentId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strPaperSubAttachmentId in arrPaperSubAttachmentId)
{
long lngPaperSubAttachmentId = long.Parse(strPaperSubAttachmentId);
clsPaperSubAttachmentBL.relatedActions.UpdRelaTabDate(lngPaperSubAttachmentId, "UpdRelaTabDate");
}
}
int intRecNum = PaperSubAttachmentDA.DelPaperSubAttachment(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[PaperSubAttachment]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngPaperSubAttachmentId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngPaperSubAttachmentId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPaperSubAttachmentDA.GetSpecSQLObj();
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
//删除与表:[PaperSubAttachment]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPaperSubAttachmentBL.DelRecord(lngPaperSubAttachmentId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPaperSubAttachmentBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngPaperSubAttachmentId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objPaperSubAttachmentENS">源对象</param>
 /// <param name = "objPaperSubAttachmentENT">目标对象</param>
 public static void CopyTo(clsPaperSubAttachmentEN objPaperSubAttachmentENS, clsPaperSubAttachmentEN objPaperSubAttachmentENT)
{
try
{
objPaperSubAttachmentENT.PaperSubAttachmentId = objPaperSubAttachmentENS.PaperSubAttachmentId; //子观点附件Id
objPaperSubAttachmentENT.PaperSubAttachmentName = objPaperSubAttachmentENS.PaperSubAttachmentName; //附件名称
objPaperSubAttachmentENT.FilePath = objPaperSubAttachmentENS.FilePath; //文件路径
objPaperSubAttachmentENT.IdCurrEduCls = objPaperSubAttachmentENS.IdCurrEduCls; //教学班流水号
objPaperSubAttachmentENT.PaperRWId = objPaperSubAttachmentENS.PaperRWId; //课文阅读
objPaperSubAttachmentENT.SubViewpointId = objPaperSubAttachmentENS.SubViewpointId; //子观点Id
objPaperSubAttachmentENT.UpdUserId = objPaperSubAttachmentENS.UpdUserId; //修改用户Id
objPaperSubAttachmentENT.UpdDate = objPaperSubAttachmentENS.UpdDate; //修改日期
objPaperSubAttachmentENT.Memo = objPaperSubAttachmentENS.Memo; //备注
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
 /// <param name = "objPaperSubAttachmentEN">源简化对象</param>
 public static void SetUpdFlag(clsPaperSubAttachmentEN objPaperSubAttachmentEN)
{
try
{
objPaperSubAttachmentEN.ClearUpdateState();
   string strsfUpdFldSetStr = objPaperSubAttachmentEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conPaperSubAttachment.PaperSubAttachmentId, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubAttachmentEN.PaperSubAttachmentId = objPaperSubAttachmentEN.PaperSubAttachmentId; //子观点附件Id
}
if (arrFldSet.Contains(conPaperSubAttachment.PaperSubAttachmentName, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubAttachmentEN.PaperSubAttachmentName = objPaperSubAttachmentEN.PaperSubAttachmentName == "[null]" ? null :  objPaperSubAttachmentEN.PaperSubAttachmentName; //附件名称
}
if (arrFldSet.Contains(conPaperSubAttachment.FilePath, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubAttachmentEN.FilePath = objPaperSubAttachmentEN.FilePath; //文件路径
}
if (arrFldSet.Contains(conPaperSubAttachment.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubAttachmentEN.IdCurrEduCls = objPaperSubAttachmentEN.IdCurrEduCls == "[null]" ? null :  objPaperSubAttachmentEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conPaperSubAttachment.PaperRWId, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubAttachmentEN.PaperRWId = objPaperSubAttachmentEN.PaperRWId == "[null]" ? null :  objPaperSubAttachmentEN.PaperRWId; //课文阅读
}
if (arrFldSet.Contains(conPaperSubAttachment.SubViewpointId, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubAttachmentEN.SubViewpointId = objPaperSubAttachmentEN.SubViewpointId; //子观点Id
}
if (arrFldSet.Contains(conPaperSubAttachment.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubAttachmentEN.UpdUserId = objPaperSubAttachmentEN.UpdUserId == "[null]" ? null :  objPaperSubAttachmentEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conPaperSubAttachment.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubAttachmentEN.UpdDate = objPaperSubAttachmentEN.UpdDate == "[null]" ? null :  objPaperSubAttachmentEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conPaperSubAttachment.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubAttachmentEN.Memo = objPaperSubAttachmentEN.Memo == "[null]" ? null :  objPaperSubAttachmentEN.Memo; //备注
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
 /// <param name = "objPaperSubAttachmentEN">源简化对象</param>
 public static void AccessFldValueNull(clsPaperSubAttachmentEN objPaperSubAttachmentEN)
{
try
{
if (objPaperSubAttachmentEN.PaperSubAttachmentName == "[null]") objPaperSubAttachmentEN.PaperSubAttachmentName = null; //附件名称
if (objPaperSubAttachmentEN.IdCurrEduCls == "[null]") objPaperSubAttachmentEN.IdCurrEduCls = null; //教学班流水号
if (objPaperSubAttachmentEN.PaperRWId == "[null]") objPaperSubAttachmentEN.PaperRWId = null; //课文阅读
if (objPaperSubAttachmentEN.UpdUserId == "[null]") objPaperSubAttachmentEN.UpdUserId = null; //修改用户Id
if (objPaperSubAttachmentEN.UpdDate == "[null]") objPaperSubAttachmentEN.UpdDate = null; //修改日期
if (objPaperSubAttachmentEN.Memo == "[null]") objPaperSubAttachmentEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsPaperSubAttachmentEN objPaperSubAttachmentEN)
{
 PaperSubAttachmentDA.CheckPropertyNew(objPaperSubAttachmentEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsPaperSubAttachmentEN objPaperSubAttachmentEN)
{
 PaperSubAttachmentDA.CheckProperty4Condition(objPaperSubAttachmentEN);
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
if (clsPaperSubAttachmentBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperSubAttachmentBL没有刷新缓存机制(clsPaperSubAttachmentBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PaperSubAttachmentId");
//if (arrPaperSubAttachmentObjLstCache == null)
//{
//arrPaperSubAttachmentObjLstCache = PaperSubAttachmentDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngPaperSubAttachmentId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPaperSubAttachmentEN GetObjByPaperSubAttachmentIdCache(long lngPaperSubAttachmentId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsPaperSubAttachmentEN._CurrTabName);
List<clsPaperSubAttachmentEN> arrPaperSubAttachmentObjLstCache = GetObjLstCache();
IEnumerable <clsPaperSubAttachmentEN> arrPaperSubAttachmentObjLst_Sel =
arrPaperSubAttachmentObjLstCache
.Where(x=> x.PaperSubAttachmentId == lngPaperSubAttachmentId 
);
if (arrPaperSubAttachmentObjLst_Sel.Count() == 0)
{
   clsPaperSubAttachmentEN obj = clsPaperSubAttachmentBL.GetObjByPaperSubAttachmentId(lngPaperSubAttachmentId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrPaperSubAttachmentObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPaperSubAttachmentEN> GetAllPaperSubAttachmentObjLstCache()
{
//获取缓存中的对象列表
List<clsPaperSubAttachmentEN> arrPaperSubAttachmentObjLstCache = GetObjLstCache(); 
return arrPaperSubAttachmentObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPaperSubAttachmentEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsPaperSubAttachmentEN._CurrTabName);
List<clsPaperSubAttachmentEN> arrPaperSubAttachmentObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrPaperSubAttachmentObjLstCache;
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
string strKey = string.Format("{0}", clsPaperSubAttachmentEN._CurrTabName);
CacheHelper.Remove(strKey);
clsPaperSubAttachmentEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsPaperSubAttachmentEN._RefreshTimeLst.Count == 0) return "";
return clsPaperSubAttachmentEN._RefreshTimeLst[clsPaperSubAttachmentEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsPaperSubAttachmentBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsPaperSubAttachmentEN._CurrTabName);
CacheHelper.Remove(strKey);
clsPaperSubAttachmentEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsPaperSubAttachmentBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--PaperSubAttachment(子观点附件)
 /// 唯一性条件:SubViewpointId_PaperSubAttachmentName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objPaperSubAttachmentEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsPaperSubAttachmentEN objPaperSubAttachmentEN)
{
//检测记录是否存在
string strResult = PaperSubAttachmentDA.GetUniCondStr(objPaperSubAttachmentEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngPaperSubAttachmentId)
{
if (strInFldName != conPaperSubAttachment.PaperSubAttachmentId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conPaperSubAttachment.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conPaperSubAttachment.AttributeName));
throw new Exception(strMsg);
}
var objPaperSubAttachment = clsPaperSubAttachmentBL.GetObjByPaperSubAttachmentIdCache(lngPaperSubAttachmentId);
if (objPaperSubAttachment == null) return "";
return objPaperSubAttachment[strOutFldName].ToString();
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
int intRecCount = clsPaperSubAttachmentDA.GetRecCount(strTabName);
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
int intRecCount = clsPaperSubAttachmentDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsPaperSubAttachmentDA.GetRecCount();
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
int intRecCount = clsPaperSubAttachmentDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objPaperSubAttachmentCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsPaperSubAttachmentEN objPaperSubAttachmentCond)
{
List<clsPaperSubAttachmentEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsPaperSubAttachmentEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPaperSubAttachment.AttributeName)
{
if (objPaperSubAttachmentCond.IsUpdated(strFldName) == false) continue;
if (objPaperSubAttachmentCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPaperSubAttachmentCond[strFldName].ToString());
}
else
{
if (objPaperSubAttachmentCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPaperSubAttachmentCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPaperSubAttachmentCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPaperSubAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPaperSubAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPaperSubAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPaperSubAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPaperSubAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPaperSubAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPaperSubAttachmentCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPaperSubAttachmentCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPaperSubAttachmentCond[strFldName]));
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
 List<string> arrList = clsPaperSubAttachmentDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = PaperSubAttachmentDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = PaperSubAttachmentDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = PaperSubAttachmentDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsPaperSubAttachmentDA.SetFldValue(clsPaperSubAttachmentEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = PaperSubAttachmentDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsPaperSubAttachmentDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsPaperSubAttachmentDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsPaperSubAttachmentDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[PaperSubAttachment] "); 
 strCreateTabCode.Append(" ( "); 
 // /**子观点附件Id*/ 
 strCreateTabCode.Append(" PaperSubAttachmentId bigint primary key identity, "); 
 // /**附件名称*/ 
 strCreateTabCode.Append(" PaperSubAttachmentName varchar(200) Null, "); 
 // /**文件路径*/ 
 strCreateTabCode.Append(" FilePath varchar(500) not Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) Null, "); 
 // /**课文阅读*/ 
 strCreateTabCode.Append(" PaperRWId char(8) Null, "); 
 // /**子观点Id*/ 
 strCreateTabCode.Append(" SubViewpointId bigint not Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 子观点附件(PaperSubAttachment)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4PaperSubAttachment : clsCommFun4BL
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
clsPaperSubAttachmentBL.ReFreshThisCache();
}
}

}