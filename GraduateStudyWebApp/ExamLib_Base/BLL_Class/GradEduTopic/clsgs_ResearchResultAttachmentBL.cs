
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_ResearchResultAttachmentBL
 表名:gs_ResearchResultAttachment(01120779)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:16:05
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
public static class  clsgs_ResearchResultAttachmentBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_ResearchResultAttachmentEN GetObj(this K_mId_gs_ResearchResultAttachment myKey)
{
clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentEN = clsgs_ResearchResultAttachmentBL.gs_ResearchResultAttachmentDA.GetObjBymId(myKey.Value);
return objgs_ResearchResultAttachmentEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objgs_ResearchResultAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_ResearchResultAttachmentEN) == false)
{
var strMsg = string.Format("记录已经存在!mId = [{0}]的数据已经存在!(in clsgs_ResearchResultAttachmentBL.AddNewRecord)", objgs_ResearchResultAttachmentEN.mId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsgs_ResearchResultAttachmentBL.gs_ResearchResultAttachmentDA.AddNewRecordBySQL2(objgs_ResearchResultAttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_ResearchResultAttachmentBL.ReFreshCache();

if (clsgs_ResearchResultAttachmentBL.relatedActions != null)
{
clsgs_ResearchResultAttachmentBL.relatedActions.UpdRelaTabDate(objgs_ResearchResultAttachmentEN.mId, "SetUpdDate");
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
public static bool AddRecordEx(this clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentEN, bool bolIsNeedCheckUniqueness = true)
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
objgs_ResearchResultAttachmentEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objgs_ResearchResultAttachmentEN.CheckUniqueness() == false)
{
strMsg = string.Format("(mId(mId)=[{0}])已经存在,不能重复!", objgs_ResearchResultAttachmentEN.mId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objgs_ResearchResultAttachmentEN.AddNewRecord();
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
 /// <param name = "objgs_ResearchResultAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_ResearchResultAttachmentEN) == false)
{
var strMsg = string.Format("记录已经存在!mId = [{0}]的数据已经存在!(in clsgs_ResearchResultAttachmentBL.AddNewRecordWithReturnKey)", objgs_ResearchResultAttachmentEN.mId);
throw new Exception(strMsg);
}
try
{
string strKey = clsgs_ResearchResultAttachmentBL.gs_ResearchResultAttachmentDA.AddNewRecordBySQL2WithReturnKey(objgs_ResearchResultAttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_ResearchResultAttachmentBL.ReFreshCache();

if (clsgs_ResearchResultAttachmentBL.relatedActions != null)
{
clsgs_ResearchResultAttachmentBL.relatedActions.UpdRelaTabDate(objgs_ResearchResultAttachmentEN.mId, "SetUpdDate");
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
 /// <param name = "objgs_ResearchResultAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_ResearchResultAttachmentEN SetmId(this clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentEN, long lngmId, string strComparisonOp="")
	{
objgs_ResearchResultAttachmentEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_ResearchResultAttachmentEN.dicFldComparisonOp.ContainsKey(congs_ResearchResultAttachment.mId) == false)
{
objgs_ResearchResultAttachmentEN.dicFldComparisonOp.Add(congs_ResearchResultAttachment.mId, strComparisonOp);
}
else
{
objgs_ResearchResultAttachmentEN.dicFldComparisonOp[congs_ResearchResultAttachment.mId] = strComparisonOp;
}
}
return objgs_ResearchResultAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_ResearchResultAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_ResearchResultAttachmentEN SetResultId(this clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentEN, string strResultId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResultId, congs_ResearchResultAttachment.ResultId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResultId, 10, congs_ResearchResultAttachment.ResultId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strResultId, 10, congs_ResearchResultAttachment.ResultId);
}
objgs_ResearchResultAttachmentEN.ResultId = strResultId; //成果Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_ResearchResultAttachmentEN.dicFldComparisonOp.ContainsKey(congs_ResearchResultAttachment.ResultId) == false)
{
objgs_ResearchResultAttachmentEN.dicFldComparisonOp.Add(congs_ResearchResultAttachment.ResultId, strComparisonOp);
}
else
{
objgs_ResearchResultAttachmentEN.dicFldComparisonOp[congs_ResearchResultAttachment.ResultId] = strComparisonOp;
}
}
return objgs_ResearchResultAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_ResearchResultAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_ResearchResultAttachmentEN SetTopicId(this clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentEN, string strTopicId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicId, 8, congs_ResearchResultAttachment.TopicId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTopicId, 8, congs_ResearchResultAttachment.TopicId);
}
objgs_ResearchResultAttachmentEN.TopicId = strTopicId; //主题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_ResearchResultAttachmentEN.dicFldComparisonOp.ContainsKey(congs_ResearchResultAttachment.TopicId) == false)
{
objgs_ResearchResultAttachmentEN.dicFldComparisonOp.Add(congs_ResearchResultAttachment.TopicId, strComparisonOp);
}
else
{
objgs_ResearchResultAttachmentEN.dicFldComparisonOp[congs_ResearchResultAttachment.TopicId] = strComparisonOp;
}
}
return objgs_ResearchResultAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_ResearchResultAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_ResearchResultAttachmentEN SetFileName(this clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentEN, string strFileName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileName, 500, congs_ResearchResultAttachment.FileName);
}
objgs_ResearchResultAttachmentEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_ResearchResultAttachmentEN.dicFldComparisonOp.ContainsKey(congs_ResearchResultAttachment.FileName) == false)
{
objgs_ResearchResultAttachmentEN.dicFldComparisonOp.Add(congs_ResearchResultAttachment.FileName, strComparisonOp);
}
else
{
objgs_ResearchResultAttachmentEN.dicFldComparisonOp[congs_ResearchResultAttachment.FileName] = strComparisonOp;
}
}
return objgs_ResearchResultAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_ResearchResultAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_ResearchResultAttachmentEN SetFilePath(this clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentEN, string strFilePath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFilePath, 500, congs_ResearchResultAttachment.FilePath);
}
objgs_ResearchResultAttachmentEN.FilePath = strFilePath; //文件路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_ResearchResultAttachmentEN.dicFldComparisonOp.ContainsKey(congs_ResearchResultAttachment.FilePath) == false)
{
objgs_ResearchResultAttachmentEN.dicFldComparisonOp.Add(congs_ResearchResultAttachment.FilePath, strComparisonOp);
}
else
{
objgs_ResearchResultAttachmentEN.dicFldComparisonOp[congs_ResearchResultAttachment.FilePath] = strComparisonOp;
}
}
return objgs_ResearchResultAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_ResearchResultAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_ResearchResultAttachmentEN SetUpdDate(this clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, congs_ResearchResultAttachment.UpdDate);
}
objgs_ResearchResultAttachmentEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_ResearchResultAttachmentEN.dicFldComparisonOp.ContainsKey(congs_ResearchResultAttachment.UpdDate) == false)
{
objgs_ResearchResultAttachmentEN.dicFldComparisonOp.Add(congs_ResearchResultAttachment.UpdDate, strComparisonOp);
}
else
{
objgs_ResearchResultAttachmentEN.dicFldComparisonOp[congs_ResearchResultAttachment.UpdDate] = strComparisonOp;
}
}
return objgs_ResearchResultAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_ResearchResultAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_ResearchResultAttachmentEN SetUpdUser(this clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, congs_ResearchResultAttachment.UpdUser);
}
objgs_ResearchResultAttachmentEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_ResearchResultAttachmentEN.dicFldComparisonOp.ContainsKey(congs_ResearchResultAttachment.UpdUser) == false)
{
objgs_ResearchResultAttachmentEN.dicFldComparisonOp.Add(congs_ResearchResultAttachment.UpdUser, strComparisonOp);
}
else
{
objgs_ResearchResultAttachmentEN.dicFldComparisonOp[congs_ResearchResultAttachment.UpdUser] = strComparisonOp;
}
}
return objgs_ResearchResultAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_ResearchResultAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_ResearchResultAttachmentEN SetMemo(this clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, congs_ResearchResultAttachment.Memo);
}
objgs_ResearchResultAttachmentEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_ResearchResultAttachmentEN.dicFldComparisonOp.ContainsKey(congs_ResearchResultAttachment.Memo) == false)
{
objgs_ResearchResultAttachmentEN.dicFldComparisonOp.Add(congs_ResearchResultAttachment.Memo, strComparisonOp);
}
else
{
objgs_ResearchResultAttachmentEN.dicFldComparisonOp[congs_ResearchResultAttachment.Memo] = strComparisonOp;
}
}
return objgs_ResearchResultAttachmentEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objgs_ResearchResultAttachmentEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objgs_ResearchResultAttachmentEN.CheckPropertyNew();
clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentCond = new clsgs_ResearchResultAttachmentEN();
string strCondition = objgs_ResearchResultAttachmentCond
.SetmId(objgs_ResearchResultAttachmentEN.mId, "<>")
.SetmId(objgs_ResearchResultAttachmentEN.mId, "=")
.GetCombineCondition();
objgs_ResearchResultAttachmentEN._IsCheckProperty = true;
bool bolIsExist = clsgs_ResearchResultAttachmentBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(mId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objgs_ResearchResultAttachmentEN.Update();
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
 /// <param name = "objgs_ResearchResultAttachment">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachment)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentCond = new clsgs_ResearchResultAttachmentEN();
string strCondition = objgs_ResearchResultAttachmentCond
.SetmId(objgs_ResearchResultAttachment.mId, "=")
.GetCombineCondition();
objgs_ResearchResultAttachment._IsCheckProperty = true;
bool bolIsExist = clsgs_ResearchResultAttachmentBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objgs_ResearchResultAttachment.mId = clsgs_ResearchResultAttachmentBL.GetFirstID_S(strCondition);
objgs_ResearchResultAttachment.UpdateWithCondition(strCondition);
}
else
{
objgs_ResearchResultAttachment.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objgs_ResearchResultAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentEN)
{
 if (objgs_ResearchResultAttachmentEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsgs_ResearchResultAttachmentBL.gs_ResearchResultAttachmentDA.UpdateBySql2(objgs_ResearchResultAttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_ResearchResultAttachmentBL.ReFreshCache();

if (clsgs_ResearchResultAttachmentBL.relatedActions != null)
{
clsgs_ResearchResultAttachmentBL.relatedActions.UpdRelaTabDate(objgs_ResearchResultAttachmentEN.mId, "SetUpdDate");
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
 /// <param name = "objgs_ResearchResultAttachmentEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objgs_ResearchResultAttachmentEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsgs_ResearchResultAttachmentBL.gs_ResearchResultAttachmentDA.UpdateBySql2(objgs_ResearchResultAttachmentEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_ResearchResultAttachmentBL.ReFreshCache();

if (clsgs_ResearchResultAttachmentBL.relatedActions != null)
{
clsgs_ResearchResultAttachmentBL.relatedActions.UpdRelaTabDate(objgs_ResearchResultAttachmentEN.mId, "SetUpdDate");
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
 /// <param name = "objgs_ResearchResultAttachmentEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentEN, string strWhereCond)
{
try
{
bool bolResult = clsgs_ResearchResultAttachmentBL.gs_ResearchResultAttachmentDA.UpdateBySqlWithCondition(objgs_ResearchResultAttachmentEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_ResearchResultAttachmentBL.ReFreshCache();

if (clsgs_ResearchResultAttachmentBL.relatedActions != null)
{
clsgs_ResearchResultAttachmentBL.relatedActions.UpdRelaTabDate(objgs_ResearchResultAttachmentEN.mId, "SetUpdDate");
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
 /// <param name = "objgs_ResearchResultAttachmentEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsgs_ResearchResultAttachmentBL.gs_ResearchResultAttachmentDA.UpdateBySqlWithConditionTransaction(objgs_ResearchResultAttachmentEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_ResearchResultAttachmentBL.ReFreshCache();

if (clsgs_ResearchResultAttachmentBL.relatedActions != null)
{
clsgs_ResearchResultAttachmentBL.relatedActions.UpdRelaTabDate(objgs_ResearchResultAttachmentEN.mId, "SetUpdDate");
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentEN)
{
try
{
int intRecNum = clsgs_ResearchResultAttachmentBL.gs_ResearchResultAttachmentDA.DelRecord(objgs_ResearchResultAttachmentEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_ResearchResultAttachmentBL.ReFreshCache();

if (clsgs_ResearchResultAttachmentBL.relatedActions != null)
{
clsgs_ResearchResultAttachmentBL.relatedActions.UpdRelaTabDate(objgs_ResearchResultAttachmentEN.mId, "SetUpdDate");
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
 /// <param name = "objgs_ResearchResultAttachmentENS">源对象</param>
 /// <param name = "objgs_ResearchResultAttachmentENT">目标对象</param>
 public static void CopyTo(this clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentENS, clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentENT)
{
try
{
objgs_ResearchResultAttachmentENT.mId = objgs_ResearchResultAttachmentENS.mId; //mId
objgs_ResearchResultAttachmentENT.ResultId = objgs_ResearchResultAttachmentENS.ResultId; //成果Id
objgs_ResearchResultAttachmentENT.TopicId = objgs_ResearchResultAttachmentENS.TopicId; //主题Id
objgs_ResearchResultAttachmentENT.FileName = objgs_ResearchResultAttachmentENS.FileName; //文件名称
objgs_ResearchResultAttachmentENT.FilePath = objgs_ResearchResultAttachmentENS.FilePath; //文件路径
objgs_ResearchResultAttachmentENT.UpdDate = objgs_ResearchResultAttachmentENS.UpdDate; //修改日期
objgs_ResearchResultAttachmentENT.UpdUser = objgs_ResearchResultAttachmentENS.UpdUser; //修改人
objgs_ResearchResultAttachmentENT.Memo = objgs_ResearchResultAttachmentENS.Memo; //备注
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
 /// <param name = "objgs_ResearchResultAttachmentENS">源对象</param>
 /// <returns>目标对象=>clsgs_ResearchResultAttachmentEN:objgs_ResearchResultAttachmentENT</returns>
 public static clsgs_ResearchResultAttachmentEN CopyTo(this clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentENS)
{
try
{
 clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentENT = new clsgs_ResearchResultAttachmentEN()
{
mId = objgs_ResearchResultAttachmentENS.mId, //mId
ResultId = objgs_ResearchResultAttachmentENS.ResultId, //成果Id
TopicId = objgs_ResearchResultAttachmentENS.TopicId, //主题Id
FileName = objgs_ResearchResultAttachmentENS.FileName, //文件名称
FilePath = objgs_ResearchResultAttachmentENS.FilePath, //文件路径
UpdDate = objgs_ResearchResultAttachmentENS.UpdDate, //修改日期
UpdUser = objgs_ResearchResultAttachmentENS.UpdUser, //修改人
Memo = objgs_ResearchResultAttachmentENS.Memo, //备注
};
 return objgs_ResearchResultAttachmentENT;
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
public static void CheckPropertyNew(this clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentEN)
{
 clsgs_ResearchResultAttachmentBL.gs_ResearchResultAttachmentDA.CheckPropertyNew(objgs_ResearchResultAttachmentEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentEN)
{
 clsgs_ResearchResultAttachmentBL.gs_ResearchResultAttachmentDA.CheckProperty4Condition(objgs_ResearchResultAttachmentEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objgs_ResearchResultAttachmentCond.IsUpdated(congs_ResearchResultAttachment.mId) == true)
{
string strComparisonOpmId = objgs_ResearchResultAttachmentCond.dicFldComparisonOp[congs_ResearchResultAttachment.mId];
strWhereCond += string.Format(" And {0} {2} {1}", congs_ResearchResultAttachment.mId, objgs_ResearchResultAttachmentCond.mId, strComparisonOpmId);
}
if (objgs_ResearchResultAttachmentCond.IsUpdated(congs_ResearchResultAttachment.ResultId) == true)
{
string strComparisonOpResultId = objgs_ResearchResultAttachmentCond.dicFldComparisonOp[congs_ResearchResultAttachment.ResultId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_ResearchResultAttachment.ResultId, objgs_ResearchResultAttachmentCond.ResultId, strComparisonOpResultId);
}
if (objgs_ResearchResultAttachmentCond.IsUpdated(congs_ResearchResultAttachment.TopicId) == true)
{
string strComparisonOpTopicId = objgs_ResearchResultAttachmentCond.dicFldComparisonOp[congs_ResearchResultAttachment.TopicId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_ResearchResultAttachment.TopicId, objgs_ResearchResultAttachmentCond.TopicId, strComparisonOpTopicId);
}
if (objgs_ResearchResultAttachmentCond.IsUpdated(congs_ResearchResultAttachment.FileName) == true)
{
string strComparisonOpFileName = objgs_ResearchResultAttachmentCond.dicFldComparisonOp[congs_ResearchResultAttachment.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_ResearchResultAttachment.FileName, objgs_ResearchResultAttachmentCond.FileName, strComparisonOpFileName);
}
if (objgs_ResearchResultAttachmentCond.IsUpdated(congs_ResearchResultAttachment.FilePath) == true)
{
string strComparisonOpFilePath = objgs_ResearchResultAttachmentCond.dicFldComparisonOp[congs_ResearchResultAttachment.FilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_ResearchResultAttachment.FilePath, objgs_ResearchResultAttachmentCond.FilePath, strComparisonOpFilePath);
}
if (objgs_ResearchResultAttachmentCond.IsUpdated(congs_ResearchResultAttachment.UpdDate) == true)
{
string strComparisonOpUpdDate = objgs_ResearchResultAttachmentCond.dicFldComparisonOp[congs_ResearchResultAttachment.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_ResearchResultAttachment.UpdDate, objgs_ResearchResultAttachmentCond.UpdDate, strComparisonOpUpdDate);
}
if (objgs_ResearchResultAttachmentCond.IsUpdated(congs_ResearchResultAttachment.UpdUser) == true)
{
string strComparisonOpUpdUser = objgs_ResearchResultAttachmentCond.dicFldComparisonOp[congs_ResearchResultAttachment.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_ResearchResultAttachment.UpdUser, objgs_ResearchResultAttachmentCond.UpdUser, strComparisonOpUpdUser);
}
if (objgs_ResearchResultAttachmentCond.IsUpdated(congs_ResearchResultAttachment.Memo) == true)
{
string strComparisonOpMemo = objgs_ResearchResultAttachmentCond.dicFldComparisonOp[congs_ResearchResultAttachment.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_ResearchResultAttachment.Memo, objgs_ResearchResultAttachmentCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--gs_ResearchResultAttachment(研究成果附件表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:mId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objgs_ResearchResultAttachmentEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objgs_ResearchResultAttachmentEN == null) return true;
if (objgs_ResearchResultAttachmentEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and mId = '{0}'", objgs_ResearchResultAttachmentEN.mId);
if (clsgs_ResearchResultAttachmentBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objgs_ResearchResultAttachmentEN.mId);
 sbCondition.AppendFormat(" and mId = '{0}'", objgs_ResearchResultAttachmentEN.mId);
if (clsgs_ResearchResultAttachmentBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--gs_ResearchResultAttachment(研究成果附件表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:mId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objgs_ResearchResultAttachmentEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objgs_ResearchResultAttachmentEN == null) return "";
if (objgs_ResearchResultAttachmentEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and mId = '{0}'", objgs_ResearchResultAttachmentEN.mId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objgs_ResearchResultAttachmentEN.mId);
 sbCondition.AppendFormat(" and mId = '{0}'", objgs_ResearchResultAttachmentEN.mId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_gs_ResearchResultAttachment
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 研究成果附件表(gs_ResearchResultAttachment)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsgs_ResearchResultAttachmentBL
{
public static RelatedActions_gs_ResearchResultAttachment relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsgs_ResearchResultAttachmentDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsgs_ResearchResultAttachmentDA gs_ResearchResultAttachmentDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsgs_ResearchResultAttachmentDA();
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
 public clsgs_ResearchResultAttachmentBL()
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
if (string.IsNullOrEmpty(clsgs_ResearchResultAttachmentEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsgs_ResearchResultAttachmentEN._ConnectString);
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
public static DataTable GetDataTable_gs_ResearchResultAttachment(string strWhereCond)
{
DataTable objDT;
try
{
objDT = gs_ResearchResultAttachmentDA.GetDataTable_gs_ResearchResultAttachment(strWhereCond);
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
objDT = gs_ResearchResultAttachmentDA.GetDataTable(strWhereCond);
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
objDT = gs_ResearchResultAttachmentDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = gs_ResearchResultAttachmentDA.GetDataTable(strWhereCond, strTabName);
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
objDT = gs_ResearchResultAttachmentDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = gs_ResearchResultAttachmentDA.GetDataTable_Top(objTopPara);
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
objDT = gs_ResearchResultAttachmentDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = gs_ResearchResultAttachmentDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = gs_ResearchResultAttachmentDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsgs_ResearchResultAttachmentEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsgs_ResearchResultAttachmentEN> arrObjLst = new List<clsgs_ResearchResultAttachmentEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMIdLst);
 string strWhereCond = string.Format("mId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentEN = new clsgs_ResearchResultAttachmentEN();
try
{
objgs_ResearchResultAttachmentEN.mId = Int32.Parse(objRow[congs_ResearchResultAttachment.mId].ToString().Trim()); //mId
objgs_ResearchResultAttachmentEN.ResultId = objRow[congs_ResearchResultAttachment.ResultId].ToString().Trim(); //成果Id
objgs_ResearchResultAttachmentEN.TopicId = objRow[congs_ResearchResultAttachment.TopicId] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.TopicId].ToString().Trim(); //主题Id
objgs_ResearchResultAttachmentEN.FileName = objRow[congs_ResearchResultAttachment.FileName] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.FileName].ToString().Trim(); //文件名称
objgs_ResearchResultAttachmentEN.FilePath = objRow[congs_ResearchResultAttachment.FilePath] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.FilePath].ToString().Trim(); //文件路径
objgs_ResearchResultAttachmentEN.UpdDate = objRow[congs_ResearchResultAttachment.UpdDate] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.UpdDate].ToString().Trim(); //修改日期
objgs_ResearchResultAttachmentEN.UpdUser = objRow[congs_ResearchResultAttachment.UpdUser] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.UpdUser].ToString().Trim(); //修改人
objgs_ResearchResultAttachmentEN.Memo = objRow[congs_ResearchResultAttachment.Memo] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_ResearchResultAttachmentEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_ResearchResultAttachmentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsgs_ResearchResultAttachmentEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsgs_ResearchResultAttachmentEN._CurrTabName);
List<clsgs_ResearchResultAttachmentEN> arrgs_ResearchResultAttachmentObjLstCache = GetObjLstCache();
IEnumerable <clsgs_ResearchResultAttachmentEN> arrgs_ResearchResultAttachmentObjLst_Sel =
arrgs_ResearchResultAttachmentObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrgs_ResearchResultAttachmentObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_ResearchResultAttachmentEN> GetObjLst(string strWhereCond)
{
List<clsgs_ResearchResultAttachmentEN> arrObjLst = new List<clsgs_ResearchResultAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentEN = new clsgs_ResearchResultAttachmentEN();
try
{
objgs_ResearchResultAttachmentEN.mId = Int32.Parse(objRow[congs_ResearchResultAttachment.mId].ToString().Trim()); //mId
objgs_ResearchResultAttachmentEN.ResultId = objRow[congs_ResearchResultAttachment.ResultId].ToString().Trim(); //成果Id
objgs_ResearchResultAttachmentEN.TopicId = objRow[congs_ResearchResultAttachment.TopicId] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.TopicId].ToString().Trim(); //主题Id
objgs_ResearchResultAttachmentEN.FileName = objRow[congs_ResearchResultAttachment.FileName] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.FileName].ToString().Trim(); //文件名称
objgs_ResearchResultAttachmentEN.FilePath = objRow[congs_ResearchResultAttachment.FilePath] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.FilePath].ToString().Trim(); //文件路径
objgs_ResearchResultAttachmentEN.UpdDate = objRow[congs_ResearchResultAttachment.UpdDate] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.UpdDate].ToString().Trim(); //修改日期
objgs_ResearchResultAttachmentEN.UpdUser = objRow[congs_ResearchResultAttachment.UpdUser] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.UpdUser].ToString().Trim(); //修改人
objgs_ResearchResultAttachmentEN.Memo = objRow[congs_ResearchResultAttachment.Memo] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_ResearchResultAttachmentEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_ResearchResultAttachmentEN);
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
public static List<clsgs_ResearchResultAttachmentEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsgs_ResearchResultAttachmentEN> arrObjLst = new List<clsgs_ResearchResultAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentEN = new clsgs_ResearchResultAttachmentEN();
try
{
objgs_ResearchResultAttachmentEN.mId = Int32.Parse(objRow[congs_ResearchResultAttachment.mId].ToString().Trim()); //mId
objgs_ResearchResultAttachmentEN.ResultId = objRow[congs_ResearchResultAttachment.ResultId].ToString().Trim(); //成果Id
objgs_ResearchResultAttachmentEN.TopicId = objRow[congs_ResearchResultAttachment.TopicId] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.TopicId].ToString().Trim(); //主题Id
objgs_ResearchResultAttachmentEN.FileName = objRow[congs_ResearchResultAttachment.FileName] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.FileName].ToString().Trim(); //文件名称
objgs_ResearchResultAttachmentEN.FilePath = objRow[congs_ResearchResultAttachment.FilePath] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.FilePath].ToString().Trim(); //文件路径
objgs_ResearchResultAttachmentEN.UpdDate = objRow[congs_ResearchResultAttachment.UpdDate] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.UpdDate].ToString().Trim(); //修改日期
objgs_ResearchResultAttachmentEN.UpdUser = objRow[congs_ResearchResultAttachment.UpdUser] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.UpdUser].ToString().Trim(); //修改人
objgs_ResearchResultAttachmentEN.Memo = objRow[congs_ResearchResultAttachment.Memo] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_ResearchResultAttachmentEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_ResearchResultAttachmentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objgs_ResearchResultAttachmentCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsgs_ResearchResultAttachmentEN> GetSubObjLstCache(clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentCond)
{
List<clsgs_ResearchResultAttachmentEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsgs_ResearchResultAttachmentEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in congs_ResearchResultAttachment.AttributeName)
{
if (objgs_ResearchResultAttachmentCond.IsUpdated(strFldName) == false) continue;
if (objgs_ResearchResultAttachmentCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_ResearchResultAttachmentCond[strFldName].ToString());
}
else
{
if (objgs_ResearchResultAttachmentCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objgs_ResearchResultAttachmentCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_ResearchResultAttachmentCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objgs_ResearchResultAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objgs_ResearchResultAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objgs_ResearchResultAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objgs_ResearchResultAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objgs_ResearchResultAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objgs_ResearchResultAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objgs_ResearchResultAttachmentCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objgs_ResearchResultAttachmentCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objgs_ResearchResultAttachmentCond[strFldName]));
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
public static List<clsgs_ResearchResultAttachmentEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsgs_ResearchResultAttachmentEN> arrObjLst = new List<clsgs_ResearchResultAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentEN = new clsgs_ResearchResultAttachmentEN();
try
{
objgs_ResearchResultAttachmentEN.mId = Int32.Parse(objRow[congs_ResearchResultAttachment.mId].ToString().Trim()); //mId
objgs_ResearchResultAttachmentEN.ResultId = objRow[congs_ResearchResultAttachment.ResultId].ToString().Trim(); //成果Id
objgs_ResearchResultAttachmentEN.TopicId = objRow[congs_ResearchResultAttachment.TopicId] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.TopicId].ToString().Trim(); //主题Id
objgs_ResearchResultAttachmentEN.FileName = objRow[congs_ResearchResultAttachment.FileName] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.FileName].ToString().Trim(); //文件名称
objgs_ResearchResultAttachmentEN.FilePath = objRow[congs_ResearchResultAttachment.FilePath] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.FilePath].ToString().Trim(); //文件路径
objgs_ResearchResultAttachmentEN.UpdDate = objRow[congs_ResearchResultAttachment.UpdDate] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.UpdDate].ToString().Trim(); //修改日期
objgs_ResearchResultAttachmentEN.UpdUser = objRow[congs_ResearchResultAttachment.UpdUser] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.UpdUser].ToString().Trim(); //修改人
objgs_ResearchResultAttachmentEN.Memo = objRow[congs_ResearchResultAttachment.Memo] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_ResearchResultAttachmentEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_ResearchResultAttachmentEN);
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
public static List<clsgs_ResearchResultAttachmentEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsgs_ResearchResultAttachmentEN> arrObjLst = new List<clsgs_ResearchResultAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentEN = new clsgs_ResearchResultAttachmentEN();
try
{
objgs_ResearchResultAttachmentEN.mId = Int32.Parse(objRow[congs_ResearchResultAttachment.mId].ToString().Trim()); //mId
objgs_ResearchResultAttachmentEN.ResultId = objRow[congs_ResearchResultAttachment.ResultId].ToString().Trim(); //成果Id
objgs_ResearchResultAttachmentEN.TopicId = objRow[congs_ResearchResultAttachment.TopicId] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.TopicId].ToString().Trim(); //主题Id
objgs_ResearchResultAttachmentEN.FileName = objRow[congs_ResearchResultAttachment.FileName] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.FileName].ToString().Trim(); //文件名称
objgs_ResearchResultAttachmentEN.FilePath = objRow[congs_ResearchResultAttachment.FilePath] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.FilePath].ToString().Trim(); //文件路径
objgs_ResearchResultAttachmentEN.UpdDate = objRow[congs_ResearchResultAttachment.UpdDate] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.UpdDate].ToString().Trim(); //修改日期
objgs_ResearchResultAttachmentEN.UpdUser = objRow[congs_ResearchResultAttachment.UpdUser] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.UpdUser].ToString().Trim(); //修改人
objgs_ResearchResultAttachmentEN.Memo = objRow[congs_ResearchResultAttachment.Memo] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_ResearchResultAttachmentEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_ResearchResultAttachmentEN);
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
List<clsgs_ResearchResultAttachmentEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsgs_ResearchResultAttachmentEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_ResearchResultAttachmentEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsgs_ResearchResultAttachmentEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsgs_ResearchResultAttachmentEN> arrObjLst = new List<clsgs_ResearchResultAttachmentEN>(); 
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
	clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentEN = new clsgs_ResearchResultAttachmentEN();
try
{
objgs_ResearchResultAttachmentEN.mId = Int32.Parse(objRow[congs_ResearchResultAttachment.mId].ToString().Trim()); //mId
objgs_ResearchResultAttachmentEN.ResultId = objRow[congs_ResearchResultAttachment.ResultId].ToString().Trim(); //成果Id
objgs_ResearchResultAttachmentEN.TopicId = objRow[congs_ResearchResultAttachment.TopicId] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.TopicId].ToString().Trim(); //主题Id
objgs_ResearchResultAttachmentEN.FileName = objRow[congs_ResearchResultAttachment.FileName] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.FileName].ToString().Trim(); //文件名称
objgs_ResearchResultAttachmentEN.FilePath = objRow[congs_ResearchResultAttachment.FilePath] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.FilePath].ToString().Trim(); //文件路径
objgs_ResearchResultAttachmentEN.UpdDate = objRow[congs_ResearchResultAttachment.UpdDate] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.UpdDate].ToString().Trim(); //修改日期
objgs_ResearchResultAttachmentEN.UpdUser = objRow[congs_ResearchResultAttachment.UpdUser] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.UpdUser].ToString().Trim(); //修改人
objgs_ResearchResultAttachmentEN.Memo = objRow[congs_ResearchResultAttachment.Memo] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_ResearchResultAttachmentEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_ResearchResultAttachmentEN);
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
public static List<clsgs_ResearchResultAttachmentEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsgs_ResearchResultAttachmentEN> arrObjLst = new List<clsgs_ResearchResultAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentEN = new clsgs_ResearchResultAttachmentEN();
try
{
objgs_ResearchResultAttachmentEN.mId = Int32.Parse(objRow[congs_ResearchResultAttachment.mId].ToString().Trim()); //mId
objgs_ResearchResultAttachmentEN.ResultId = objRow[congs_ResearchResultAttachment.ResultId].ToString().Trim(); //成果Id
objgs_ResearchResultAttachmentEN.TopicId = objRow[congs_ResearchResultAttachment.TopicId] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.TopicId].ToString().Trim(); //主题Id
objgs_ResearchResultAttachmentEN.FileName = objRow[congs_ResearchResultAttachment.FileName] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.FileName].ToString().Trim(); //文件名称
objgs_ResearchResultAttachmentEN.FilePath = objRow[congs_ResearchResultAttachment.FilePath] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.FilePath].ToString().Trim(); //文件路径
objgs_ResearchResultAttachmentEN.UpdDate = objRow[congs_ResearchResultAttachment.UpdDate] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.UpdDate].ToString().Trim(); //修改日期
objgs_ResearchResultAttachmentEN.UpdUser = objRow[congs_ResearchResultAttachment.UpdUser] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.UpdUser].ToString().Trim(); //修改人
objgs_ResearchResultAttachmentEN.Memo = objRow[congs_ResearchResultAttachment.Memo] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_ResearchResultAttachmentEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_ResearchResultAttachmentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsgs_ResearchResultAttachmentEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsgs_ResearchResultAttachmentEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsgs_ResearchResultAttachmentEN> arrObjLst = new List<clsgs_ResearchResultAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentEN = new clsgs_ResearchResultAttachmentEN();
try
{
objgs_ResearchResultAttachmentEN.mId = Int32.Parse(objRow[congs_ResearchResultAttachment.mId].ToString().Trim()); //mId
objgs_ResearchResultAttachmentEN.ResultId = objRow[congs_ResearchResultAttachment.ResultId].ToString().Trim(); //成果Id
objgs_ResearchResultAttachmentEN.TopicId = objRow[congs_ResearchResultAttachment.TopicId] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.TopicId].ToString().Trim(); //主题Id
objgs_ResearchResultAttachmentEN.FileName = objRow[congs_ResearchResultAttachment.FileName] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.FileName].ToString().Trim(); //文件名称
objgs_ResearchResultAttachmentEN.FilePath = objRow[congs_ResearchResultAttachment.FilePath] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.FilePath].ToString().Trim(); //文件路径
objgs_ResearchResultAttachmentEN.UpdDate = objRow[congs_ResearchResultAttachment.UpdDate] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.UpdDate].ToString().Trim(); //修改日期
objgs_ResearchResultAttachmentEN.UpdUser = objRow[congs_ResearchResultAttachment.UpdUser] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.UpdUser].ToString().Trim(); //修改人
objgs_ResearchResultAttachmentEN.Memo = objRow[congs_ResearchResultAttachment.Memo] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_ResearchResultAttachmentEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_ResearchResultAttachmentEN);
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
public static List<clsgs_ResearchResultAttachmentEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsgs_ResearchResultAttachmentEN> arrObjLst = new List<clsgs_ResearchResultAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentEN = new clsgs_ResearchResultAttachmentEN();
try
{
objgs_ResearchResultAttachmentEN.mId = Int32.Parse(objRow[congs_ResearchResultAttachment.mId].ToString().Trim()); //mId
objgs_ResearchResultAttachmentEN.ResultId = objRow[congs_ResearchResultAttachment.ResultId].ToString().Trim(); //成果Id
objgs_ResearchResultAttachmentEN.TopicId = objRow[congs_ResearchResultAttachment.TopicId] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.TopicId].ToString().Trim(); //主题Id
objgs_ResearchResultAttachmentEN.FileName = objRow[congs_ResearchResultAttachment.FileName] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.FileName].ToString().Trim(); //文件名称
objgs_ResearchResultAttachmentEN.FilePath = objRow[congs_ResearchResultAttachment.FilePath] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.FilePath].ToString().Trim(); //文件路径
objgs_ResearchResultAttachmentEN.UpdDate = objRow[congs_ResearchResultAttachment.UpdDate] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.UpdDate].ToString().Trim(); //修改日期
objgs_ResearchResultAttachmentEN.UpdUser = objRow[congs_ResearchResultAttachment.UpdUser] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.UpdUser].ToString().Trim(); //修改人
objgs_ResearchResultAttachmentEN.Memo = objRow[congs_ResearchResultAttachment.Memo] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_ResearchResultAttachmentEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_ResearchResultAttachmentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_ResearchResultAttachmentEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsgs_ResearchResultAttachmentEN> arrObjLst = new List<clsgs_ResearchResultAttachmentEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentEN = new clsgs_ResearchResultAttachmentEN();
try
{
objgs_ResearchResultAttachmentEN.mId = Int32.Parse(objRow[congs_ResearchResultAttachment.mId].ToString().Trim()); //mId
objgs_ResearchResultAttachmentEN.ResultId = objRow[congs_ResearchResultAttachment.ResultId].ToString().Trim(); //成果Id
objgs_ResearchResultAttachmentEN.TopicId = objRow[congs_ResearchResultAttachment.TopicId] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.TopicId].ToString().Trim(); //主题Id
objgs_ResearchResultAttachmentEN.FileName = objRow[congs_ResearchResultAttachment.FileName] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.FileName].ToString().Trim(); //文件名称
objgs_ResearchResultAttachmentEN.FilePath = objRow[congs_ResearchResultAttachment.FilePath] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.FilePath].ToString().Trim(); //文件路径
objgs_ResearchResultAttachmentEN.UpdDate = objRow[congs_ResearchResultAttachment.UpdDate] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.UpdDate].ToString().Trim(); //修改日期
objgs_ResearchResultAttachmentEN.UpdUser = objRow[congs_ResearchResultAttachment.UpdUser] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.UpdUser].ToString().Trim(); //修改人
objgs_ResearchResultAttachmentEN.Memo = objRow[congs_ResearchResultAttachment.Memo] == DBNull.Value ? null : objRow[congs_ResearchResultAttachment.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_ResearchResultAttachmentEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_ResearchResultAttachmentEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objgs_ResearchResultAttachmentEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getgs_ResearchResultAttachment(ref clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentEN)
{
bool bolResult = gs_ResearchResultAttachmentDA.Getgs_ResearchResultAttachment(ref objgs_ResearchResultAttachmentEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_ResearchResultAttachmentEN GetObjBymId(long lngmId)
{
clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentEN = gs_ResearchResultAttachmentDA.GetObjBymId(lngmId);
return objgs_ResearchResultAttachmentEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsgs_ResearchResultAttachmentEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentEN = gs_ResearchResultAttachmentDA.GetFirstObj(strWhereCond);
 return objgs_ResearchResultAttachmentEN;
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
public static clsgs_ResearchResultAttachmentEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentEN = gs_ResearchResultAttachmentDA.GetObjByDataRow(objRow);
 return objgs_ResearchResultAttachmentEN;
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
public static clsgs_ResearchResultAttachmentEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentEN = gs_ResearchResultAttachmentDA.GetObjByDataRow(objRow);
 return objgs_ResearchResultAttachmentEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "lstgs_ResearchResultAttachmentObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_ResearchResultAttachmentEN GetObjBymIdFromList(long lngmId, List<clsgs_ResearchResultAttachmentEN> lstgs_ResearchResultAttachmentObjLst)
{
foreach (clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentEN in lstgs_ResearchResultAttachmentObjLst)
{
if (objgs_ResearchResultAttachmentEN.mId == lngmId)
{
return objgs_ResearchResultAttachmentEN;
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
 long lngmId;
 try
 {
 lngmId = new clsgs_ResearchResultAttachmentDA().GetFirstID(strWhereCond);
 return lngmId;
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
 arrList = gs_ResearchResultAttachmentDA.GetID(strWhereCond);
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
bool bolIsExist = gs_ResearchResultAttachmentDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
bool bolIsExist = gs_ResearchResultAttachmentDA.IsExist(lngmId);
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
 bolIsExist = clsgs_ResearchResultAttachmentDA.IsExistTable();
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
 bolIsExist = gs_ResearchResultAttachmentDA.IsExistTable(strTabName);
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
 /// <param name = "objgs_ResearchResultAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objgs_ResearchResultAttachmentEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!mId = [{0}]的数据已经存在!(in clsgs_ResearchResultAttachmentBL.AddNewRecordBySql2)", objgs_ResearchResultAttachmentEN.mId);
throw new Exception(strMsg);
}
try
{
bool bolResult = gs_ResearchResultAttachmentDA.AddNewRecordBySQL2(objgs_ResearchResultAttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_ResearchResultAttachmentBL.ReFreshCache();

if (clsgs_ResearchResultAttachmentBL.relatedActions != null)
{
clsgs_ResearchResultAttachmentBL.relatedActions.UpdRelaTabDate(objgs_ResearchResultAttachmentEN.mId, "SetUpdDate");
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
 /// <param name = "objgs_ResearchResultAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objgs_ResearchResultAttachmentEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!mId = [{0}]的数据已经存在!(in clsgs_ResearchResultAttachmentBL.AddNewRecordBySql2WithReturnKey)", objgs_ResearchResultAttachmentEN.mId);
throw new Exception(strMsg);
}
try
{
string strKey = gs_ResearchResultAttachmentDA.AddNewRecordBySQL2WithReturnKey(objgs_ResearchResultAttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_ResearchResultAttachmentBL.ReFreshCache();

if (clsgs_ResearchResultAttachmentBL.relatedActions != null)
{
clsgs_ResearchResultAttachmentBL.relatedActions.UpdRelaTabDate(objgs_ResearchResultAttachmentEN.mId, "SetUpdDate");
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
 /// <param name = "objgs_ResearchResultAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentEN)
{
try
{
bool bolResult = gs_ResearchResultAttachmentDA.Update(objgs_ResearchResultAttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_ResearchResultAttachmentBL.ReFreshCache();

if (clsgs_ResearchResultAttachmentBL.relatedActions != null)
{
clsgs_ResearchResultAttachmentBL.relatedActions.UpdRelaTabDate(objgs_ResearchResultAttachmentEN.mId, "SetUpdDate");
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
 /// <param name = "objgs_ResearchResultAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentEN)
{
 if (objgs_ResearchResultAttachmentEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = gs_ResearchResultAttachmentDA.UpdateBySql2(objgs_ResearchResultAttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_ResearchResultAttachmentBL.ReFreshCache();

if (clsgs_ResearchResultAttachmentBL.relatedActions != null)
{
clsgs_ResearchResultAttachmentBL.relatedActions.UpdRelaTabDate(objgs_ResearchResultAttachmentEN.mId, "SetUpdDate");
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngmId)
{
try
{
 clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentEN = clsgs_ResearchResultAttachmentBL.GetObjBymId(lngmId);

if (clsgs_ResearchResultAttachmentBL.relatedActions != null)
{
clsgs_ResearchResultAttachmentBL.relatedActions.UpdRelaTabDate(objgs_ResearchResultAttachmentEN.mId, "SetUpdDate");
}
if (objgs_ResearchResultAttachmentEN != null)
{
int intRecNum = gs_ResearchResultAttachmentDA.DelRecord(lngmId);
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
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngmId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsgs_ResearchResultAttachmentDA.GetSpecSQLObj();
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
//删除与表:[gs_ResearchResultAttachment]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//congs_ResearchResultAttachment.mId,
//lngmId);
//        clsgs_ResearchResultAttachmentBL.Delgs_ResearchResultAttachmentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsgs_ResearchResultAttachmentBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsgs_ResearchResultAttachmentBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngmId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngmId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsgs_ResearchResultAttachmentBL.relatedActions != null)
{
clsgs_ResearchResultAttachmentBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = gs_ResearchResultAttachmentDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrmIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delgs_ResearchResultAttachments(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsgs_ResearchResultAttachmentBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsgs_ResearchResultAttachmentBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = gs_ResearchResultAttachmentDA.Delgs_ResearchResultAttachment(arrmIdLst);
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
public static int Delgs_ResearchResultAttachmentsByCond(string strWhereCond)
{
try
{
if (clsgs_ResearchResultAttachmentBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsgs_ResearchResultAttachmentBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = gs_ResearchResultAttachmentDA.Delgs_ResearchResultAttachment(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[gs_ResearchResultAttachment]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsgs_ResearchResultAttachmentDA.GetSpecSQLObj();
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
//删除与表:[gs_ResearchResultAttachment]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsgs_ResearchResultAttachmentBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsgs_ResearchResultAttachmentBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngmId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objgs_ResearchResultAttachmentENS">源对象</param>
 /// <param name = "objgs_ResearchResultAttachmentENT">目标对象</param>
 public static void CopyTo(clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentENS, clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentENT)
{
try
{
objgs_ResearchResultAttachmentENT.mId = objgs_ResearchResultAttachmentENS.mId; //mId
objgs_ResearchResultAttachmentENT.ResultId = objgs_ResearchResultAttachmentENS.ResultId; //成果Id
objgs_ResearchResultAttachmentENT.TopicId = objgs_ResearchResultAttachmentENS.TopicId; //主题Id
objgs_ResearchResultAttachmentENT.FileName = objgs_ResearchResultAttachmentENS.FileName; //文件名称
objgs_ResearchResultAttachmentENT.FilePath = objgs_ResearchResultAttachmentENS.FilePath; //文件路径
objgs_ResearchResultAttachmentENT.UpdDate = objgs_ResearchResultAttachmentENS.UpdDate; //修改日期
objgs_ResearchResultAttachmentENT.UpdUser = objgs_ResearchResultAttachmentENS.UpdUser; //修改人
objgs_ResearchResultAttachmentENT.Memo = objgs_ResearchResultAttachmentENS.Memo; //备注
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
 /// <param name = "objgs_ResearchResultAttachmentEN">源简化对象</param>
 public static void SetUpdFlag(clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentEN)
{
try
{
objgs_ResearchResultAttachmentEN.ClearUpdateState();
   string strsfUpdFldSetStr = objgs_ResearchResultAttachmentEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(congs_ResearchResultAttachment.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_ResearchResultAttachmentEN.mId = objgs_ResearchResultAttachmentEN.mId; //mId
}
if (arrFldSet.Contains(congs_ResearchResultAttachment.ResultId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_ResearchResultAttachmentEN.ResultId = objgs_ResearchResultAttachmentEN.ResultId; //成果Id
}
if (arrFldSet.Contains(congs_ResearchResultAttachment.TopicId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_ResearchResultAttachmentEN.TopicId = objgs_ResearchResultAttachmentEN.TopicId == "[null]" ? null :  objgs_ResearchResultAttachmentEN.TopicId; //主题Id
}
if (arrFldSet.Contains(congs_ResearchResultAttachment.FileName, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_ResearchResultAttachmentEN.FileName = objgs_ResearchResultAttachmentEN.FileName == "[null]" ? null :  objgs_ResearchResultAttachmentEN.FileName; //文件名称
}
if (arrFldSet.Contains(congs_ResearchResultAttachment.FilePath, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_ResearchResultAttachmentEN.FilePath = objgs_ResearchResultAttachmentEN.FilePath == "[null]" ? null :  objgs_ResearchResultAttachmentEN.FilePath; //文件路径
}
if (arrFldSet.Contains(congs_ResearchResultAttachment.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_ResearchResultAttachmentEN.UpdDate = objgs_ResearchResultAttachmentEN.UpdDate == "[null]" ? null :  objgs_ResearchResultAttachmentEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(congs_ResearchResultAttachment.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_ResearchResultAttachmentEN.UpdUser = objgs_ResearchResultAttachmentEN.UpdUser == "[null]" ? null :  objgs_ResearchResultAttachmentEN.UpdUser; //修改人
}
if (arrFldSet.Contains(congs_ResearchResultAttachment.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_ResearchResultAttachmentEN.Memo = objgs_ResearchResultAttachmentEN.Memo == "[null]" ? null :  objgs_ResearchResultAttachmentEN.Memo; //备注
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
 /// <param name = "objgs_ResearchResultAttachmentEN">源简化对象</param>
 public static void AccessFldValueNull(clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentEN)
{
try
{
if (objgs_ResearchResultAttachmentEN.TopicId == "[null]") objgs_ResearchResultAttachmentEN.TopicId = null; //主题Id
if (objgs_ResearchResultAttachmentEN.FileName == "[null]") objgs_ResearchResultAttachmentEN.FileName = null; //文件名称
if (objgs_ResearchResultAttachmentEN.FilePath == "[null]") objgs_ResearchResultAttachmentEN.FilePath = null; //文件路径
if (objgs_ResearchResultAttachmentEN.UpdDate == "[null]") objgs_ResearchResultAttachmentEN.UpdDate = null; //修改日期
if (objgs_ResearchResultAttachmentEN.UpdUser == "[null]") objgs_ResearchResultAttachmentEN.UpdUser = null; //修改人
if (objgs_ResearchResultAttachmentEN.Memo == "[null]") objgs_ResearchResultAttachmentEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentEN)
{
 gs_ResearchResultAttachmentDA.CheckPropertyNew(objgs_ResearchResultAttachmentEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentEN)
{
 gs_ResearchResultAttachmentDA.CheckProperty4Condition(objgs_ResearchResultAttachmentEN);
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
if (clsgs_ResearchResultAttachmentBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_ResearchResultAttachmentBL没有刷新缓存机制(clsgs_ResearchResultAttachmentBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrgs_ResearchResultAttachmentObjLstCache == null)
//{
//arrgs_ResearchResultAttachmentObjLstCache = gs_ResearchResultAttachmentDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_ResearchResultAttachmentEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsgs_ResearchResultAttachmentEN._CurrTabName);
List<clsgs_ResearchResultAttachmentEN> arrgs_ResearchResultAttachmentObjLstCache = GetObjLstCache();
IEnumerable <clsgs_ResearchResultAttachmentEN> arrgs_ResearchResultAttachmentObjLst_Sel =
arrgs_ResearchResultAttachmentObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrgs_ResearchResultAttachmentObjLst_Sel.Count() == 0)
{
   clsgs_ResearchResultAttachmentEN obj = clsgs_ResearchResultAttachmentBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrgs_ResearchResultAttachmentObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_ResearchResultAttachmentEN> GetAllgs_ResearchResultAttachmentObjLstCache()
{
//获取缓存中的对象列表
List<clsgs_ResearchResultAttachmentEN> arrgs_ResearchResultAttachmentObjLstCache = GetObjLstCache(); 
return arrgs_ResearchResultAttachmentObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_ResearchResultAttachmentEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsgs_ResearchResultAttachmentEN._CurrTabName);
List<clsgs_ResearchResultAttachmentEN> arrgs_ResearchResultAttachmentObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrgs_ResearchResultAttachmentObjLstCache;
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
string strKey = string.Format("{0}", clsgs_ResearchResultAttachmentEN._CurrTabName);
CacheHelper.Remove(strKey);
clsgs_ResearchResultAttachmentEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsgs_ResearchResultAttachmentEN._RefreshTimeLst.Count == 0) return "";
return clsgs_ResearchResultAttachmentEN._RefreshTimeLst[clsgs_ResearchResultAttachmentEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsgs_ResearchResultAttachmentBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsgs_ResearchResultAttachmentEN._CurrTabName);
CacheHelper.Remove(strKey);
clsgs_ResearchResultAttachmentEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsgs_ResearchResultAttachmentBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--gs_ResearchResultAttachment(研究成果附件表)
 /// 唯一性条件:mId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objgs_ResearchResultAttachmentEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentEN)
{
//检测记录是否存在
string strResult = gs_ResearchResultAttachmentDA.GetUniCondStr(objgs_ResearchResultAttachmentEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != congs_ResearchResultAttachment.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (congs_ResearchResultAttachment.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", congs_ResearchResultAttachment.AttributeName));
throw new Exception(strMsg);
}
var objgs_ResearchResultAttachment = clsgs_ResearchResultAttachmentBL.GetObjBymIdCache(lngmId);
if (objgs_ResearchResultAttachment == null) return "";
return objgs_ResearchResultAttachment[strOutFldName].ToString();
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
int intRecCount = clsgs_ResearchResultAttachmentDA.GetRecCount(strTabName);
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
int intRecCount = clsgs_ResearchResultAttachmentDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsgs_ResearchResultAttachmentDA.GetRecCount();
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
int intRecCount = clsgs_ResearchResultAttachmentDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objgs_ResearchResultAttachmentCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsgs_ResearchResultAttachmentEN objgs_ResearchResultAttachmentCond)
{
List<clsgs_ResearchResultAttachmentEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsgs_ResearchResultAttachmentEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in congs_ResearchResultAttachment.AttributeName)
{
if (objgs_ResearchResultAttachmentCond.IsUpdated(strFldName) == false) continue;
if (objgs_ResearchResultAttachmentCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_ResearchResultAttachmentCond[strFldName].ToString());
}
else
{
if (objgs_ResearchResultAttachmentCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objgs_ResearchResultAttachmentCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_ResearchResultAttachmentCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objgs_ResearchResultAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objgs_ResearchResultAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objgs_ResearchResultAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objgs_ResearchResultAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objgs_ResearchResultAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objgs_ResearchResultAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objgs_ResearchResultAttachmentCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objgs_ResearchResultAttachmentCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objgs_ResearchResultAttachmentCond[strFldName]));
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
 List<string> arrList = clsgs_ResearchResultAttachmentDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = gs_ResearchResultAttachmentDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = gs_ResearchResultAttachmentDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = gs_ResearchResultAttachmentDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsgs_ResearchResultAttachmentDA.SetFldValue(clsgs_ResearchResultAttachmentEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = gs_ResearchResultAttachmentDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsgs_ResearchResultAttachmentDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsgs_ResearchResultAttachmentDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsgs_ResearchResultAttachmentDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[gs_ResearchResultAttachment] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**成果Id*/ 
 strCreateTabCode.Append(" ResultId char(10) not Null, "); 
 // /**主题Id*/ 
 strCreateTabCode.Append(" TopicId char(8) Null, "); 
 // /**文件名称*/ 
 strCreateTabCode.Append(" FileName varchar(500) Null, "); 
 // /**文件路径*/ 
 strCreateTabCode.Append(" FilePath varchar(500) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 研究成果附件表(gs_ResearchResultAttachment)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4gs_ResearchResultAttachment : clsCommFun4BL
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
clsgs_ResearchResultAttachmentBL.ReFreshThisCache();
}
}

}