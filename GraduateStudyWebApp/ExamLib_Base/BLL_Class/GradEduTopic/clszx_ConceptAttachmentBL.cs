
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_ConceptAttachmentBL
 表名:zx_ConceptAttachment(01120864)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 23:05:34
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
public static class  clszx_ConceptAttachmentBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngzxConceptAttachmentId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_ConceptAttachmentEN GetObj(this K_zxConceptAttachmentId_zx_ConceptAttachment myKey)
{
clszx_ConceptAttachmentEN objzx_ConceptAttachmentEN = clszx_ConceptAttachmentBL.zx_ConceptAttachmentDA.GetObjByzxConceptAttachmentId(myKey.Value);
return objzx_ConceptAttachmentEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objzx_ConceptAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clszx_ConceptAttachmentEN objzx_ConceptAttachmentEN)
{
if (CheckUniqueness(objzx_ConceptAttachmentEN) == false)
{
var strMsg = string.Format("记录已经存在!概念Id = [{0}]的数据已经存在!(in clszx_ConceptAttachmentBL.AddNewRecord)", objzx_ConceptAttachmentEN.zxConceptId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clszx_ConceptAttachmentBL.zx_ConceptAttachmentDA.AddNewRecordBySQL2(objzx_ConceptAttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ConceptAttachmentBL.ReFreshCache();

if (clszx_ConceptAttachmentBL.relatedActions != null)
{
clszx_ConceptAttachmentBL.relatedActions.UpdRelaTabDate(objzx_ConceptAttachmentEN.zxConceptAttachmentId, "SetUpdDate");
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
public static bool AddRecordEx(this clszx_ConceptAttachmentEN objzx_ConceptAttachmentEN)
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
objzx_ConceptAttachmentEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objzx_ConceptAttachmentEN.CheckUniqueness() == false)
{
strMsg = string.Format("(概念Id(zxConceptId)=[{0}])已经存在,不能重复!", objzx_ConceptAttachmentEN.zxConceptId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objzx_ConceptAttachmentEN.AddNewRecord();
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
 /// <param name = "objzx_ConceptAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clszx_ConceptAttachmentEN objzx_ConceptAttachmentEN)
{
if (CheckUniqueness(objzx_ConceptAttachmentEN) == false)
{
var strMsg = string.Format("记录已经存在!概念Id = [{0}]的数据已经存在!(in clszx_ConceptAttachmentBL.AddNewRecordWithReturnKey)", objzx_ConceptAttachmentEN.zxConceptId);
throw new Exception(strMsg);
}
try
{
string strKey = clszx_ConceptAttachmentBL.zx_ConceptAttachmentDA.AddNewRecordBySQL2WithReturnKey(objzx_ConceptAttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ConceptAttachmentBL.ReFreshCache();

if (clszx_ConceptAttachmentBL.relatedActions != null)
{
clszx_ConceptAttachmentBL.relatedActions.UpdRelaTabDate(objzx_ConceptAttachmentEN.zxConceptAttachmentId, "SetUpdDate");
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
 /// <param name = "objzx_ConceptAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptAttachmentEN SetzxConceptAttachmentId(this clszx_ConceptAttachmentEN objzx_ConceptAttachmentEN, long lngzxConceptAttachmentId, string strComparisonOp="")
	{
objzx_ConceptAttachmentEN.zxConceptAttachmentId = lngzxConceptAttachmentId; //概念附件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptAttachmentEN.dicFldComparisonOp.ContainsKey(conzx_ConceptAttachment.zxConceptAttachmentId) == false)
{
objzx_ConceptAttachmentEN.dicFldComparisonOp.Add(conzx_ConceptAttachment.zxConceptAttachmentId, strComparisonOp);
}
else
{
objzx_ConceptAttachmentEN.dicFldComparisonOp[conzx_ConceptAttachment.zxConceptAttachmentId] = strComparisonOp;
}
}
return objzx_ConceptAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptAttachmentEN SetConceptAttachmentName(this clszx_ConceptAttachmentEN objzx_ConceptAttachmentEN, string strConceptAttachmentName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConceptAttachmentName, 200, conzx_ConceptAttachment.ConceptAttachmentName);
}
objzx_ConceptAttachmentEN.ConceptAttachmentName = strConceptAttachmentName; //附件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptAttachmentEN.dicFldComparisonOp.ContainsKey(conzx_ConceptAttachment.ConceptAttachmentName) == false)
{
objzx_ConceptAttachmentEN.dicFldComparisonOp.Add(conzx_ConceptAttachment.ConceptAttachmentName, strComparisonOp);
}
else
{
objzx_ConceptAttachmentEN.dicFldComparisonOp[conzx_ConceptAttachment.ConceptAttachmentName] = strComparisonOp;
}
}
return objzx_ConceptAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptAttachmentEN SetzxConceptId(this clszx_ConceptAttachmentEN objzx_ConceptAttachmentEN, string strzxConceptId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strzxConceptId, conzx_ConceptAttachment.zxConceptId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxConceptId, 8, conzx_ConceptAttachment.zxConceptId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxConceptId, 8, conzx_ConceptAttachment.zxConceptId);
}
objzx_ConceptAttachmentEN.zxConceptId = strzxConceptId; //概念Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptAttachmentEN.dicFldComparisonOp.ContainsKey(conzx_ConceptAttachment.zxConceptId) == false)
{
objzx_ConceptAttachmentEN.dicFldComparisonOp.Add(conzx_ConceptAttachment.zxConceptId, strComparisonOp);
}
else
{
objzx_ConceptAttachmentEN.dicFldComparisonOp[conzx_ConceptAttachment.zxConceptId] = strComparisonOp;
}
}
return objzx_ConceptAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptAttachmentEN SetFilePath(this clszx_ConceptAttachmentEN objzx_ConceptAttachmentEN, string strFilePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFilePath, conzx_ConceptAttachment.FilePath);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFilePath, 500, conzx_ConceptAttachment.FilePath);
}
objzx_ConceptAttachmentEN.FilePath = strFilePath; //文件路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptAttachmentEN.dicFldComparisonOp.ContainsKey(conzx_ConceptAttachment.FilePath) == false)
{
objzx_ConceptAttachmentEN.dicFldComparisonOp.Add(conzx_ConceptAttachment.FilePath, strComparisonOp);
}
else
{
objzx_ConceptAttachmentEN.dicFldComparisonOp[conzx_ConceptAttachment.FilePath] = strComparisonOp;
}
}
return objzx_ConceptAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptAttachmentEN SetUpdDate(this clszx_ConceptAttachmentEN objzx_ConceptAttachmentEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conzx_ConceptAttachment.UpdDate);
}
objzx_ConceptAttachmentEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptAttachmentEN.dicFldComparisonOp.ContainsKey(conzx_ConceptAttachment.UpdDate) == false)
{
objzx_ConceptAttachmentEN.dicFldComparisonOp.Add(conzx_ConceptAttachment.UpdDate, strComparisonOp);
}
else
{
objzx_ConceptAttachmentEN.dicFldComparisonOp[conzx_ConceptAttachment.UpdDate] = strComparisonOp;
}
}
return objzx_ConceptAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptAttachmentEN SetUpdUserId(this clszx_ConceptAttachmentEN objzx_ConceptAttachmentEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conzx_ConceptAttachment.UpdUserId);
}
objzx_ConceptAttachmentEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptAttachmentEN.dicFldComparisonOp.ContainsKey(conzx_ConceptAttachment.UpdUserId) == false)
{
objzx_ConceptAttachmentEN.dicFldComparisonOp.Add(conzx_ConceptAttachment.UpdUserId, strComparisonOp);
}
else
{
objzx_ConceptAttachmentEN.dicFldComparisonOp[conzx_ConceptAttachment.UpdUserId] = strComparisonOp;
}
}
return objzx_ConceptAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptAttachmentEN SetMemo(this clszx_ConceptAttachmentEN objzx_ConceptAttachmentEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conzx_ConceptAttachment.Memo);
}
objzx_ConceptAttachmentEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptAttachmentEN.dicFldComparisonOp.ContainsKey(conzx_ConceptAttachment.Memo) == false)
{
objzx_ConceptAttachmentEN.dicFldComparisonOp.Add(conzx_ConceptAttachment.Memo, strComparisonOp);
}
else
{
objzx_ConceptAttachmentEN.dicFldComparisonOp[conzx_ConceptAttachment.Memo] = strComparisonOp;
}
}
return objzx_ConceptAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptAttachmentEN SetIdCurrEduCls(this clszx_ConceptAttachmentEN objzx_ConceptAttachmentEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conzx_ConceptAttachment.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conzx_ConceptAttachment.IdCurrEduCls);
}
objzx_ConceptAttachmentEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptAttachmentEN.dicFldComparisonOp.ContainsKey(conzx_ConceptAttachment.IdCurrEduCls) == false)
{
objzx_ConceptAttachmentEN.dicFldComparisonOp.Add(conzx_ConceptAttachment.IdCurrEduCls, strComparisonOp);
}
else
{
objzx_ConceptAttachmentEN.dicFldComparisonOp[conzx_ConceptAttachment.IdCurrEduCls] = strComparisonOp;
}
}
return objzx_ConceptAttachmentEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objzx_ConceptAttachmentEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clszx_ConceptAttachmentEN objzx_ConceptAttachmentEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objzx_ConceptAttachmentEN.CheckPropertyNew();
clszx_ConceptAttachmentEN objzx_ConceptAttachmentCond = new clszx_ConceptAttachmentEN();
string strCondition = objzx_ConceptAttachmentCond
.SetzxConceptAttachmentId(objzx_ConceptAttachmentEN.zxConceptAttachmentId, "<>")
.SetzxConceptId(objzx_ConceptAttachmentEN.zxConceptId, "=")
.GetCombineCondition();
objzx_ConceptAttachmentEN._IsCheckProperty = true;
bool bolIsExist = clszx_ConceptAttachmentBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(zxConceptId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objzx_ConceptAttachmentEN.Update();
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
 /// <param name = "objzx_ConceptAttachment">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clszx_ConceptAttachmentEN objzx_ConceptAttachment)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clszx_ConceptAttachmentEN objzx_ConceptAttachmentCond = new clszx_ConceptAttachmentEN();
string strCondition = objzx_ConceptAttachmentCond
.SetzxConceptId(objzx_ConceptAttachment.zxConceptId, "=")
.GetCombineCondition();
objzx_ConceptAttachment._IsCheckProperty = true;
bool bolIsExist = clszx_ConceptAttachmentBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objzx_ConceptAttachment.zxConceptAttachmentId = clszx_ConceptAttachmentBL.GetFirstID_S(strCondition);
objzx_ConceptAttachment.UpdateWithCondition(strCondition);
}
else
{
objzx_ConceptAttachment.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objzx_ConceptAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_ConceptAttachmentEN objzx_ConceptAttachmentEN)
{
 if (objzx_ConceptAttachmentEN.zxConceptAttachmentId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_ConceptAttachmentBL.zx_ConceptAttachmentDA.UpdateBySql2(objzx_ConceptAttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ConceptAttachmentBL.ReFreshCache();

if (clszx_ConceptAttachmentBL.relatedActions != null)
{
clszx_ConceptAttachmentBL.relatedActions.UpdRelaTabDate(objzx_ConceptAttachmentEN.zxConceptAttachmentId, "SetUpdDate");
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
 /// <param name = "objzx_ConceptAttachmentEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_ConceptAttachmentEN objzx_ConceptAttachmentEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_ConceptAttachmentEN.zxConceptAttachmentId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_ConceptAttachmentBL.zx_ConceptAttachmentDA.UpdateBySql2(objzx_ConceptAttachmentEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ConceptAttachmentBL.ReFreshCache();

if (clszx_ConceptAttachmentBL.relatedActions != null)
{
clszx_ConceptAttachmentBL.relatedActions.UpdRelaTabDate(objzx_ConceptAttachmentEN.zxConceptAttachmentId, "SetUpdDate");
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
 /// <param name = "objzx_ConceptAttachmentEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_ConceptAttachmentEN objzx_ConceptAttachmentEN, string strWhereCond)
{
try
{
bool bolResult = clszx_ConceptAttachmentBL.zx_ConceptAttachmentDA.UpdateBySqlWithCondition(objzx_ConceptAttachmentEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ConceptAttachmentBL.ReFreshCache();

if (clszx_ConceptAttachmentBL.relatedActions != null)
{
clszx_ConceptAttachmentBL.relatedActions.UpdRelaTabDate(objzx_ConceptAttachmentEN.zxConceptAttachmentId, "SetUpdDate");
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
 /// <param name = "objzx_ConceptAttachmentEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_ConceptAttachmentEN objzx_ConceptAttachmentEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clszx_ConceptAttachmentBL.zx_ConceptAttachmentDA.UpdateBySqlWithConditionTransaction(objzx_ConceptAttachmentEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ConceptAttachmentBL.ReFreshCache();

if (clszx_ConceptAttachmentBL.relatedActions != null)
{
clszx_ConceptAttachmentBL.relatedActions.UpdRelaTabDate(objzx_ConceptAttachmentEN.zxConceptAttachmentId, "SetUpdDate");
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
 /// <param name = "lngzxConceptAttachmentId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clszx_ConceptAttachmentEN objzx_ConceptAttachmentEN)
{
try
{
int intRecNum = clszx_ConceptAttachmentBL.zx_ConceptAttachmentDA.DelRecord(objzx_ConceptAttachmentEN.zxConceptAttachmentId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ConceptAttachmentBL.ReFreshCache();

if (clszx_ConceptAttachmentBL.relatedActions != null)
{
clszx_ConceptAttachmentBL.relatedActions.UpdRelaTabDate(objzx_ConceptAttachmentEN.zxConceptAttachmentId, "SetUpdDate");
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
 /// <param name = "objzx_ConceptAttachmentENS">源对象</param>
 /// <param name = "objzx_ConceptAttachmentENT">目标对象</param>
 public static void CopyTo(this clszx_ConceptAttachmentEN objzx_ConceptAttachmentENS, clszx_ConceptAttachmentEN objzx_ConceptAttachmentENT)
{
try
{
objzx_ConceptAttachmentENT.zxConceptAttachmentId = objzx_ConceptAttachmentENS.zxConceptAttachmentId; //概念附件Id
objzx_ConceptAttachmentENT.ConceptAttachmentName = objzx_ConceptAttachmentENS.ConceptAttachmentName; //附件名称
objzx_ConceptAttachmentENT.zxConceptId = objzx_ConceptAttachmentENS.zxConceptId; //概念Id
objzx_ConceptAttachmentENT.FilePath = objzx_ConceptAttachmentENS.FilePath; //文件路径
objzx_ConceptAttachmentENT.UpdDate = objzx_ConceptAttachmentENS.UpdDate; //修改日期
objzx_ConceptAttachmentENT.UpdUserId = objzx_ConceptAttachmentENS.UpdUserId; //修改用户Id
objzx_ConceptAttachmentENT.Memo = objzx_ConceptAttachmentENS.Memo; //备注
objzx_ConceptAttachmentENT.IdCurrEduCls = objzx_ConceptAttachmentENS.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objzx_ConceptAttachmentENS">源对象</param>
 /// <returns>目标对象=>clszx_ConceptAttachmentEN:objzx_ConceptAttachmentENT</returns>
 public static clszx_ConceptAttachmentEN CopyTo(this clszx_ConceptAttachmentEN objzx_ConceptAttachmentENS)
{
try
{
 clszx_ConceptAttachmentEN objzx_ConceptAttachmentENT = new clszx_ConceptAttachmentEN()
{
zxConceptAttachmentId = objzx_ConceptAttachmentENS.zxConceptAttachmentId, //概念附件Id
ConceptAttachmentName = objzx_ConceptAttachmentENS.ConceptAttachmentName, //附件名称
zxConceptId = objzx_ConceptAttachmentENS.zxConceptId, //概念Id
FilePath = objzx_ConceptAttachmentENS.FilePath, //文件路径
UpdDate = objzx_ConceptAttachmentENS.UpdDate, //修改日期
UpdUserId = objzx_ConceptAttachmentENS.UpdUserId, //修改用户Id
Memo = objzx_ConceptAttachmentENS.Memo, //备注
IdCurrEduCls = objzx_ConceptAttachmentENS.IdCurrEduCls, //教学班流水号
};
 return objzx_ConceptAttachmentENT;
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
public static void CheckPropertyNew(this clszx_ConceptAttachmentEN objzx_ConceptAttachmentEN)
{
 clszx_ConceptAttachmentBL.zx_ConceptAttachmentDA.CheckPropertyNew(objzx_ConceptAttachmentEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clszx_ConceptAttachmentEN objzx_ConceptAttachmentEN)
{
 clszx_ConceptAttachmentBL.zx_ConceptAttachmentDA.CheckProperty4Condition(objzx_ConceptAttachmentEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clszx_ConceptAttachmentEN objzx_ConceptAttachmentCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objzx_ConceptAttachmentCond.IsUpdated(conzx_ConceptAttachment.zxConceptAttachmentId) == true)
{
string strComparisonOpzxConceptAttachmentId = objzx_ConceptAttachmentCond.dicFldComparisonOp[conzx_ConceptAttachment.zxConceptAttachmentId];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_ConceptAttachment.zxConceptAttachmentId, objzx_ConceptAttachmentCond.zxConceptAttachmentId, strComparisonOpzxConceptAttachmentId);
}
if (objzx_ConceptAttachmentCond.IsUpdated(conzx_ConceptAttachment.ConceptAttachmentName) == true)
{
string strComparisonOpConceptAttachmentName = objzx_ConceptAttachmentCond.dicFldComparisonOp[conzx_ConceptAttachment.ConceptAttachmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ConceptAttachment.ConceptAttachmentName, objzx_ConceptAttachmentCond.ConceptAttachmentName, strComparisonOpConceptAttachmentName);
}
if (objzx_ConceptAttachmentCond.IsUpdated(conzx_ConceptAttachment.zxConceptId) == true)
{
string strComparisonOpzxConceptId = objzx_ConceptAttachmentCond.dicFldComparisonOp[conzx_ConceptAttachment.zxConceptId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ConceptAttachment.zxConceptId, objzx_ConceptAttachmentCond.zxConceptId, strComparisonOpzxConceptId);
}
if (objzx_ConceptAttachmentCond.IsUpdated(conzx_ConceptAttachment.FilePath) == true)
{
string strComparisonOpFilePath = objzx_ConceptAttachmentCond.dicFldComparisonOp[conzx_ConceptAttachment.FilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ConceptAttachment.FilePath, objzx_ConceptAttachmentCond.FilePath, strComparisonOpFilePath);
}
if (objzx_ConceptAttachmentCond.IsUpdated(conzx_ConceptAttachment.UpdDate) == true)
{
string strComparisonOpUpdDate = objzx_ConceptAttachmentCond.dicFldComparisonOp[conzx_ConceptAttachment.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ConceptAttachment.UpdDate, objzx_ConceptAttachmentCond.UpdDate, strComparisonOpUpdDate);
}
if (objzx_ConceptAttachmentCond.IsUpdated(conzx_ConceptAttachment.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objzx_ConceptAttachmentCond.dicFldComparisonOp[conzx_ConceptAttachment.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ConceptAttachment.UpdUserId, objzx_ConceptAttachmentCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objzx_ConceptAttachmentCond.IsUpdated(conzx_ConceptAttachment.Memo) == true)
{
string strComparisonOpMemo = objzx_ConceptAttachmentCond.dicFldComparisonOp[conzx_ConceptAttachment.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ConceptAttachment.Memo, objzx_ConceptAttachmentCond.Memo, strComparisonOpMemo);
}
if (objzx_ConceptAttachmentCond.IsUpdated(conzx_ConceptAttachment.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objzx_ConceptAttachmentCond.dicFldComparisonOp[conzx_ConceptAttachment.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ConceptAttachment.IdCurrEduCls, objzx_ConceptAttachmentCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--zx_ConceptAttachment(中学概念附件), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:zxConceptId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objzx_ConceptAttachmentEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clszx_ConceptAttachmentEN objzx_ConceptAttachmentEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objzx_ConceptAttachmentEN == null) return true;
if (objzx_ConceptAttachmentEN.zxConceptAttachmentId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and zxConceptId = '{0}'", objzx_ConceptAttachmentEN.zxConceptId);
if (clszx_ConceptAttachmentBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("zxConceptAttachmentId !=  {0}", objzx_ConceptAttachmentEN.zxConceptAttachmentId);
 sbCondition.AppendFormat(" and zxConceptId = '{0}'", objzx_ConceptAttachmentEN.zxConceptId);
if (clszx_ConceptAttachmentBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--zx_ConceptAttachment(中学概念附件), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:zxConceptId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objzx_ConceptAttachmentEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clszx_ConceptAttachmentEN objzx_ConceptAttachmentEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objzx_ConceptAttachmentEN == null) return "";
if (objzx_ConceptAttachmentEN.zxConceptAttachmentId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and zxConceptId = '{0}'", objzx_ConceptAttachmentEN.zxConceptId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("zxConceptAttachmentId !=  {0}", objzx_ConceptAttachmentEN.zxConceptAttachmentId);
 sbCondition.AppendFormat(" and zxConceptId = '{0}'", objzx_ConceptAttachmentEN.zxConceptId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_zx_ConceptAttachment
{
public virtual bool UpdRelaTabDate(long lngzxConceptAttachmentId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 中学概念附件(zx_ConceptAttachment)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clszx_ConceptAttachmentBL
{
public static RelatedActions_zx_ConceptAttachment relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clszx_ConceptAttachmentDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clszx_ConceptAttachmentDA zx_ConceptAttachmentDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clszx_ConceptAttachmentDA();
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
 public clszx_ConceptAttachmentBL()
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
if (string.IsNullOrEmpty(clszx_ConceptAttachmentEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_ConceptAttachmentEN._ConnectString);
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
public static DataTable GetDataTable_zx_ConceptAttachment(string strWhereCond)
{
DataTable objDT;
try
{
objDT = zx_ConceptAttachmentDA.GetDataTable_zx_ConceptAttachment(strWhereCond);
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
objDT = zx_ConceptAttachmentDA.GetDataTable(strWhereCond);
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
objDT = zx_ConceptAttachmentDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = zx_ConceptAttachmentDA.GetDataTable(strWhereCond, strTabName);
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
objDT = zx_ConceptAttachmentDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = zx_ConceptAttachmentDA.GetDataTable_Top(objTopPara);
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
objDT = zx_ConceptAttachmentDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = zx_ConceptAttachmentDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = zx_ConceptAttachmentDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrZxConceptAttachmentIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clszx_ConceptAttachmentEN> GetObjLstByZxConceptAttachmentIdLst(List<long> arrZxConceptAttachmentIdLst)
{
List<clszx_ConceptAttachmentEN> arrObjLst = new List<clszx_ConceptAttachmentEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrZxConceptAttachmentIdLst);
 string strWhereCond = string.Format("zxConceptAttachmentId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ConceptAttachmentEN objzx_ConceptAttachmentEN = new clszx_ConceptAttachmentEN();
try
{
objzx_ConceptAttachmentEN.zxConceptAttachmentId = Int32.Parse(objRow[conzx_ConceptAttachment.zxConceptAttachmentId].ToString().Trim()); //概念附件Id
objzx_ConceptAttachmentEN.ConceptAttachmentName = objRow[conzx_ConceptAttachment.ConceptAttachmentName] == DBNull.Value ? null : objRow[conzx_ConceptAttachment.ConceptAttachmentName].ToString().Trim(); //附件名称
objzx_ConceptAttachmentEN.zxConceptId = objRow[conzx_ConceptAttachment.zxConceptId].ToString().Trim(); //概念Id
objzx_ConceptAttachmentEN.FilePath = objRow[conzx_ConceptAttachment.FilePath].ToString().Trim(); //文件路径
objzx_ConceptAttachmentEN.UpdDate = objRow[conzx_ConceptAttachment.UpdDate] == DBNull.Value ? null : objRow[conzx_ConceptAttachment.UpdDate].ToString().Trim(); //修改日期
objzx_ConceptAttachmentEN.UpdUserId = objRow[conzx_ConceptAttachment.UpdUserId] == DBNull.Value ? null : objRow[conzx_ConceptAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objzx_ConceptAttachmentEN.Memo = objRow[conzx_ConceptAttachment.Memo] == DBNull.Value ? null : objRow[conzx_ConceptAttachment.Memo].ToString().Trim(); //备注
objzx_ConceptAttachmentEN.IdCurrEduCls = objRow[conzx_ConceptAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_ConceptAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ConceptAttachmentEN.zxConceptAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ConceptAttachmentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrZxConceptAttachmentIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clszx_ConceptAttachmentEN> GetObjLstByZxConceptAttachmentIdLstCache(List<long> arrZxConceptAttachmentIdLst)
{
string strKey = string.Format("{0}", clszx_ConceptAttachmentEN._CurrTabName);
List<clszx_ConceptAttachmentEN> arrzx_ConceptAttachmentObjLstCache = GetObjLstCache();
IEnumerable <clszx_ConceptAttachmentEN> arrzx_ConceptAttachmentObjLst_Sel =
arrzx_ConceptAttachmentObjLstCache
.Where(x => arrZxConceptAttachmentIdLst.Contains(x.zxConceptAttachmentId));
return arrzx_ConceptAttachmentObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_ConceptAttachmentEN> GetObjLst(string strWhereCond)
{
List<clszx_ConceptAttachmentEN> arrObjLst = new List<clszx_ConceptAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ConceptAttachmentEN objzx_ConceptAttachmentEN = new clszx_ConceptAttachmentEN();
try
{
objzx_ConceptAttachmentEN.zxConceptAttachmentId = Int32.Parse(objRow[conzx_ConceptAttachment.zxConceptAttachmentId].ToString().Trim()); //概念附件Id
objzx_ConceptAttachmentEN.ConceptAttachmentName = objRow[conzx_ConceptAttachment.ConceptAttachmentName] == DBNull.Value ? null : objRow[conzx_ConceptAttachment.ConceptAttachmentName].ToString().Trim(); //附件名称
objzx_ConceptAttachmentEN.zxConceptId = objRow[conzx_ConceptAttachment.zxConceptId].ToString().Trim(); //概念Id
objzx_ConceptAttachmentEN.FilePath = objRow[conzx_ConceptAttachment.FilePath].ToString().Trim(); //文件路径
objzx_ConceptAttachmentEN.UpdDate = objRow[conzx_ConceptAttachment.UpdDate] == DBNull.Value ? null : objRow[conzx_ConceptAttachment.UpdDate].ToString().Trim(); //修改日期
objzx_ConceptAttachmentEN.UpdUserId = objRow[conzx_ConceptAttachment.UpdUserId] == DBNull.Value ? null : objRow[conzx_ConceptAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objzx_ConceptAttachmentEN.Memo = objRow[conzx_ConceptAttachment.Memo] == DBNull.Value ? null : objRow[conzx_ConceptAttachment.Memo].ToString().Trim(); //备注
objzx_ConceptAttachmentEN.IdCurrEduCls = objRow[conzx_ConceptAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_ConceptAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ConceptAttachmentEN.zxConceptAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ConceptAttachmentEN);
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
public static List<clszx_ConceptAttachmentEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clszx_ConceptAttachmentEN> arrObjLst = new List<clszx_ConceptAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ConceptAttachmentEN objzx_ConceptAttachmentEN = new clszx_ConceptAttachmentEN();
try
{
objzx_ConceptAttachmentEN.zxConceptAttachmentId = Int32.Parse(objRow[conzx_ConceptAttachment.zxConceptAttachmentId].ToString().Trim()); //概念附件Id
objzx_ConceptAttachmentEN.ConceptAttachmentName = objRow[conzx_ConceptAttachment.ConceptAttachmentName] == DBNull.Value ? null : objRow[conzx_ConceptAttachment.ConceptAttachmentName].ToString().Trim(); //附件名称
objzx_ConceptAttachmentEN.zxConceptId = objRow[conzx_ConceptAttachment.zxConceptId].ToString().Trim(); //概念Id
objzx_ConceptAttachmentEN.FilePath = objRow[conzx_ConceptAttachment.FilePath].ToString().Trim(); //文件路径
objzx_ConceptAttachmentEN.UpdDate = objRow[conzx_ConceptAttachment.UpdDate] == DBNull.Value ? null : objRow[conzx_ConceptAttachment.UpdDate].ToString().Trim(); //修改日期
objzx_ConceptAttachmentEN.UpdUserId = objRow[conzx_ConceptAttachment.UpdUserId] == DBNull.Value ? null : objRow[conzx_ConceptAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objzx_ConceptAttachmentEN.Memo = objRow[conzx_ConceptAttachment.Memo] == DBNull.Value ? null : objRow[conzx_ConceptAttachment.Memo].ToString().Trim(); //备注
objzx_ConceptAttachmentEN.IdCurrEduCls = objRow[conzx_ConceptAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_ConceptAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ConceptAttachmentEN.zxConceptAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ConceptAttachmentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objzx_ConceptAttachmentCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clszx_ConceptAttachmentEN> GetSubObjLstCache(clszx_ConceptAttachmentEN objzx_ConceptAttachmentCond)
{
List<clszx_ConceptAttachmentEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clszx_ConceptAttachmentEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_ConceptAttachment.AttributeName)
{
if (objzx_ConceptAttachmentCond.IsUpdated(strFldName) == false) continue;
if (objzx_ConceptAttachmentCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_ConceptAttachmentCond[strFldName].ToString());
}
else
{
if (objzx_ConceptAttachmentCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_ConceptAttachmentCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_ConceptAttachmentCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_ConceptAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_ConceptAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_ConceptAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_ConceptAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_ConceptAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_ConceptAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_ConceptAttachmentCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_ConceptAttachmentCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_ConceptAttachmentCond[strFldName]));
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
public static List<clszx_ConceptAttachmentEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clszx_ConceptAttachmentEN> arrObjLst = new List<clszx_ConceptAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ConceptAttachmentEN objzx_ConceptAttachmentEN = new clszx_ConceptAttachmentEN();
try
{
objzx_ConceptAttachmentEN.zxConceptAttachmentId = Int32.Parse(objRow[conzx_ConceptAttachment.zxConceptAttachmentId].ToString().Trim()); //概念附件Id
objzx_ConceptAttachmentEN.ConceptAttachmentName = objRow[conzx_ConceptAttachment.ConceptAttachmentName] == DBNull.Value ? null : objRow[conzx_ConceptAttachment.ConceptAttachmentName].ToString().Trim(); //附件名称
objzx_ConceptAttachmentEN.zxConceptId = objRow[conzx_ConceptAttachment.zxConceptId].ToString().Trim(); //概念Id
objzx_ConceptAttachmentEN.FilePath = objRow[conzx_ConceptAttachment.FilePath].ToString().Trim(); //文件路径
objzx_ConceptAttachmentEN.UpdDate = objRow[conzx_ConceptAttachment.UpdDate] == DBNull.Value ? null : objRow[conzx_ConceptAttachment.UpdDate].ToString().Trim(); //修改日期
objzx_ConceptAttachmentEN.UpdUserId = objRow[conzx_ConceptAttachment.UpdUserId] == DBNull.Value ? null : objRow[conzx_ConceptAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objzx_ConceptAttachmentEN.Memo = objRow[conzx_ConceptAttachment.Memo] == DBNull.Value ? null : objRow[conzx_ConceptAttachment.Memo].ToString().Trim(); //备注
objzx_ConceptAttachmentEN.IdCurrEduCls = objRow[conzx_ConceptAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_ConceptAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ConceptAttachmentEN.zxConceptAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ConceptAttachmentEN);
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
public static List<clszx_ConceptAttachmentEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clszx_ConceptAttachmentEN> arrObjLst = new List<clszx_ConceptAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ConceptAttachmentEN objzx_ConceptAttachmentEN = new clszx_ConceptAttachmentEN();
try
{
objzx_ConceptAttachmentEN.zxConceptAttachmentId = Int32.Parse(objRow[conzx_ConceptAttachment.zxConceptAttachmentId].ToString().Trim()); //概念附件Id
objzx_ConceptAttachmentEN.ConceptAttachmentName = objRow[conzx_ConceptAttachment.ConceptAttachmentName] == DBNull.Value ? null : objRow[conzx_ConceptAttachment.ConceptAttachmentName].ToString().Trim(); //附件名称
objzx_ConceptAttachmentEN.zxConceptId = objRow[conzx_ConceptAttachment.zxConceptId].ToString().Trim(); //概念Id
objzx_ConceptAttachmentEN.FilePath = objRow[conzx_ConceptAttachment.FilePath].ToString().Trim(); //文件路径
objzx_ConceptAttachmentEN.UpdDate = objRow[conzx_ConceptAttachment.UpdDate] == DBNull.Value ? null : objRow[conzx_ConceptAttachment.UpdDate].ToString().Trim(); //修改日期
objzx_ConceptAttachmentEN.UpdUserId = objRow[conzx_ConceptAttachment.UpdUserId] == DBNull.Value ? null : objRow[conzx_ConceptAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objzx_ConceptAttachmentEN.Memo = objRow[conzx_ConceptAttachment.Memo] == DBNull.Value ? null : objRow[conzx_ConceptAttachment.Memo].ToString().Trim(); //备注
objzx_ConceptAttachmentEN.IdCurrEduCls = objRow[conzx_ConceptAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_ConceptAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ConceptAttachmentEN.zxConceptAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ConceptAttachmentEN);
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
List<clszx_ConceptAttachmentEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clszx_ConceptAttachmentEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_ConceptAttachmentEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clszx_ConceptAttachmentEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clszx_ConceptAttachmentEN> arrObjLst = new List<clszx_ConceptAttachmentEN>(); 
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
	clszx_ConceptAttachmentEN objzx_ConceptAttachmentEN = new clszx_ConceptAttachmentEN();
try
{
objzx_ConceptAttachmentEN.zxConceptAttachmentId = Int32.Parse(objRow[conzx_ConceptAttachment.zxConceptAttachmentId].ToString().Trim()); //概念附件Id
objzx_ConceptAttachmentEN.ConceptAttachmentName = objRow[conzx_ConceptAttachment.ConceptAttachmentName] == DBNull.Value ? null : objRow[conzx_ConceptAttachment.ConceptAttachmentName].ToString().Trim(); //附件名称
objzx_ConceptAttachmentEN.zxConceptId = objRow[conzx_ConceptAttachment.zxConceptId].ToString().Trim(); //概念Id
objzx_ConceptAttachmentEN.FilePath = objRow[conzx_ConceptAttachment.FilePath].ToString().Trim(); //文件路径
objzx_ConceptAttachmentEN.UpdDate = objRow[conzx_ConceptAttachment.UpdDate] == DBNull.Value ? null : objRow[conzx_ConceptAttachment.UpdDate].ToString().Trim(); //修改日期
objzx_ConceptAttachmentEN.UpdUserId = objRow[conzx_ConceptAttachment.UpdUserId] == DBNull.Value ? null : objRow[conzx_ConceptAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objzx_ConceptAttachmentEN.Memo = objRow[conzx_ConceptAttachment.Memo] == DBNull.Value ? null : objRow[conzx_ConceptAttachment.Memo].ToString().Trim(); //备注
objzx_ConceptAttachmentEN.IdCurrEduCls = objRow[conzx_ConceptAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_ConceptAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ConceptAttachmentEN.zxConceptAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ConceptAttachmentEN);
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
public static List<clszx_ConceptAttachmentEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clszx_ConceptAttachmentEN> arrObjLst = new List<clszx_ConceptAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ConceptAttachmentEN objzx_ConceptAttachmentEN = new clszx_ConceptAttachmentEN();
try
{
objzx_ConceptAttachmentEN.zxConceptAttachmentId = Int32.Parse(objRow[conzx_ConceptAttachment.zxConceptAttachmentId].ToString().Trim()); //概念附件Id
objzx_ConceptAttachmentEN.ConceptAttachmentName = objRow[conzx_ConceptAttachment.ConceptAttachmentName] == DBNull.Value ? null : objRow[conzx_ConceptAttachment.ConceptAttachmentName].ToString().Trim(); //附件名称
objzx_ConceptAttachmentEN.zxConceptId = objRow[conzx_ConceptAttachment.zxConceptId].ToString().Trim(); //概念Id
objzx_ConceptAttachmentEN.FilePath = objRow[conzx_ConceptAttachment.FilePath].ToString().Trim(); //文件路径
objzx_ConceptAttachmentEN.UpdDate = objRow[conzx_ConceptAttachment.UpdDate] == DBNull.Value ? null : objRow[conzx_ConceptAttachment.UpdDate].ToString().Trim(); //修改日期
objzx_ConceptAttachmentEN.UpdUserId = objRow[conzx_ConceptAttachment.UpdUserId] == DBNull.Value ? null : objRow[conzx_ConceptAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objzx_ConceptAttachmentEN.Memo = objRow[conzx_ConceptAttachment.Memo] == DBNull.Value ? null : objRow[conzx_ConceptAttachment.Memo].ToString().Trim(); //备注
objzx_ConceptAttachmentEN.IdCurrEduCls = objRow[conzx_ConceptAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_ConceptAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ConceptAttachmentEN.zxConceptAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ConceptAttachmentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clszx_ConceptAttachmentEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clszx_ConceptAttachmentEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clszx_ConceptAttachmentEN> arrObjLst = new List<clszx_ConceptAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ConceptAttachmentEN objzx_ConceptAttachmentEN = new clszx_ConceptAttachmentEN();
try
{
objzx_ConceptAttachmentEN.zxConceptAttachmentId = Int32.Parse(objRow[conzx_ConceptAttachment.zxConceptAttachmentId].ToString().Trim()); //概念附件Id
objzx_ConceptAttachmentEN.ConceptAttachmentName = objRow[conzx_ConceptAttachment.ConceptAttachmentName] == DBNull.Value ? null : objRow[conzx_ConceptAttachment.ConceptAttachmentName].ToString().Trim(); //附件名称
objzx_ConceptAttachmentEN.zxConceptId = objRow[conzx_ConceptAttachment.zxConceptId].ToString().Trim(); //概念Id
objzx_ConceptAttachmentEN.FilePath = objRow[conzx_ConceptAttachment.FilePath].ToString().Trim(); //文件路径
objzx_ConceptAttachmentEN.UpdDate = objRow[conzx_ConceptAttachment.UpdDate] == DBNull.Value ? null : objRow[conzx_ConceptAttachment.UpdDate].ToString().Trim(); //修改日期
objzx_ConceptAttachmentEN.UpdUserId = objRow[conzx_ConceptAttachment.UpdUserId] == DBNull.Value ? null : objRow[conzx_ConceptAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objzx_ConceptAttachmentEN.Memo = objRow[conzx_ConceptAttachment.Memo] == DBNull.Value ? null : objRow[conzx_ConceptAttachment.Memo].ToString().Trim(); //备注
objzx_ConceptAttachmentEN.IdCurrEduCls = objRow[conzx_ConceptAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_ConceptAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ConceptAttachmentEN.zxConceptAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ConceptAttachmentEN);
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
public static List<clszx_ConceptAttachmentEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clszx_ConceptAttachmentEN> arrObjLst = new List<clszx_ConceptAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ConceptAttachmentEN objzx_ConceptAttachmentEN = new clszx_ConceptAttachmentEN();
try
{
objzx_ConceptAttachmentEN.zxConceptAttachmentId = Int32.Parse(objRow[conzx_ConceptAttachment.zxConceptAttachmentId].ToString().Trim()); //概念附件Id
objzx_ConceptAttachmentEN.ConceptAttachmentName = objRow[conzx_ConceptAttachment.ConceptAttachmentName] == DBNull.Value ? null : objRow[conzx_ConceptAttachment.ConceptAttachmentName].ToString().Trim(); //附件名称
objzx_ConceptAttachmentEN.zxConceptId = objRow[conzx_ConceptAttachment.zxConceptId].ToString().Trim(); //概念Id
objzx_ConceptAttachmentEN.FilePath = objRow[conzx_ConceptAttachment.FilePath].ToString().Trim(); //文件路径
objzx_ConceptAttachmentEN.UpdDate = objRow[conzx_ConceptAttachment.UpdDate] == DBNull.Value ? null : objRow[conzx_ConceptAttachment.UpdDate].ToString().Trim(); //修改日期
objzx_ConceptAttachmentEN.UpdUserId = objRow[conzx_ConceptAttachment.UpdUserId] == DBNull.Value ? null : objRow[conzx_ConceptAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objzx_ConceptAttachmentEN.Memo = objRow[conzx_ConceptAttachment.Memo] == DBNull.Value ? null : objRow[conzx_ConceptAttachment.Memo].ToString().Trim(); //备注
objzx_ConceptAttachmentEN.IdCurrEduCls = objRow[conzx_ConceptAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_ConceptAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ConceptAttachmentEN.zxConceptAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ConceptAttachmentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_ConceptAttachmentEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clszx_ConceptAttachmentEN> arrObjLst = new List<clszx_ConceptAttachmentEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ConceptAttachmentEN objzx_ConceptAttachmentEN = new clszx_ConceptAttachmentEN();
try
{
objzx_ConceptAttachmentEN.zxConceptAttachmentId = Int32.Parse(objRow[conzx_ConceptAttachment.zxConceptAttachmentId].ToString().Trim()); //概念附件Id
objzx_ConceptAttachmentEN.ConceptAttachmentName = objRow[conzx_ConceptAttachment.ConceptAttachmentName] == DBNull.Value ? null : objRow[conzx_ConceptAttachment.ConceptAttachmentName].ToString().Trim(); //附件名称
objzx_ConceptAttachmentEN.zxConceptId = objRow[conzx_ConceptAttachment.zxConceptId].ToString().Trim(); //概念Id
objzx_ConceptAttachmentEN.FilePath = objRow[conzx_ConceptAttachment.FilePath].ToString().Trim(); //文件路径
objzx_ConceptAttachmentEN.UpdDate = objRow[conzx_ConceptAttachment.UpdDate] == DBNull.Value ? null : objRow[conzx_ConceptAttachment.UpdDate].ToString().Trim(); //修改日期
objzx_ConceptAttachmentEN.UpdUserId = objRow[conzx_ConceptAttachment.UpdUserId] == DBNull.Value ? null : objRow[conzx_ConceptAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objzx_ConceptAttachmentEN.Memo = objRow[conzx_ConceptAttachment.Memo] == DBNull.Value ? null : objRow[conzx_ConceptAttachment.Memo].ToString().Trim(); //备注
objzx_ConceptAttachmentEN.IdCurrEduCls = objRow[conzx_ConceptAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_ConceptAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ConceptAttachmentEN.zxConceptAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ConceptAttachmentEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objzx_ConceptAttachmentEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getzx_ConceptAttachment(ref clszx_ConceptAttachmentEN objzx_ConceptAttachmentEN)
{
bool bolResult = zx_ConceptAttachmentDA.Getzx_ConceptAttachment(ref objzx_ConceptAttachmentEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngzxConceptAttachmentId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_ConceptAttachmentEN GetObjByzxConceptAttachmentId(long lngzxConceptAttachmentId)
{
clszx_ConceptAttachmentEN objzx_ConceptAttachmentEN = zx_ConceptAttachmentDA.GetObjByzxConceptAttachmentId(lngzxConceptAttachmentId);
return objzx_ConceptAttachmentEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clszx_ConceptAttachmentEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clszx_ConceptAttachmentEN objzx_ConceptAttachmentEN = zx_ConceptAttachmentDA.GetFirstObj(strWhereCond);
 return objzx_ConceptAttachmentEN;
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
public static clszx_ConceptAttachmentEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clszx_ConceptAttachmentEN objzx_ConceptAttachmentEN = zx_ConceptAttachmentDA.GetObjByDataRow(objRow);
 return objzx_ConceptAttachmentEN;
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
public static clszx_ConceptAttachmentEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clszx_ConceptAttachmentEN objzx_ConceptAttachmentEN = zx_ConceptAttachmentDA.GetObjByDataRow(objRow);
 return objzx_ConceptAttachmentEN;
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
 /// <param name = "lngzxConceptAttachmentId">所给的关键字</param>
 /// <param name = "lstzx_ConceptAttachmentObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_ConceptAttachmentEN GetObjByzxConceptAttachmentIdFromList(long lngzxConceptAttachmentId, List<clszx_ConceptAttachmentEN> lstzx_ConceptAttachmentObjLst)
{
foreach (clszx_ConceptAttachmentEN objzx_ConceptAttachmentEN in lstzx_ConceptAttachmentObjLst)
{
if (objzx_ConceptAttachmentEN.zxConceptAttachmentId == lngzxConceptAttachmentId)
{
return objzx_ConceptAttachmentEN;
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
 long lngzxConceptAttachmentId;
 try
 {
 lngzxConceptAttachmentId = new clszx_ConceptAttachmentDA().GetFirstID(strWhereCond);
 return lngzxConceptAttachmentId;
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
 arrList = zx_ConceptAttachmentDA.GetID(strWhereCond);
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
bool bolIsExist = zx_ConceptAttachmentDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngzxConceptAttachmentId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngzxConceptAttachmentId)
{
//检测记录是否存在
bool bolIsExist = zx_ConceptAttachmentDA.IsExist(lngzxConceptAttachmentId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngzxConceptAttachmentId">概念附件Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngzxConceptAttachmentId, string strOpUser)
{
clszx_ConceptAttachmentEN objzx_ConceptAttachmentEN = clszx_ConceptAttachmentBL.GetObjByzxConceptAttachmentId(lngzxConceptAttachmentId);
objzx_ConceptAttachmentEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
return clszx_ConceptAttachmentBL.UpdateBySql2(objzx_ConceptAttachmentEN);
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
 bolIsExist = clszx_ConceptAttachmentDA.IsExistTable();
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
 bolIsExist = zx_ConceptAttachmentDA.IsExistTable(strTabName);
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
 /// <param name = "objzx_ConceptAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clszx_ConceptAttachmentEN objzx_ConceptAttachmentEN)
{
if (objzx_ConceptAttachmentEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!概念Id = [{0}]的数据已经存在!(in clszx_ConceptAttachmentBL.AddNewRecordBySql2)", objzx_ConceptAttachmentEN.zxConceptId);
throw new Exception(strMsg);
}
try
{
bool bolResult = zx_ConceptAttachmentDA.AddNewRecordBySQL2(objzx_ConceptAttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ConceptAttachmentBL.ReFreshCache();

if (clszx_ConceptAttachmentBL.relatedActions != null)
{
clszx_ConceptAttachmentBL.relatedActions.UpdRelaTabDate(objzx_ConceptAttachmentEN.zxConceptAttachmentId, "SetUpdDate");
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
 /// <param name = "objzx_ConceptAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clszx_ConceptAttachmentEN objzx_ConceptAttachmentEN)
{
if (objzx_ConceptAttachmentEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!概念Id = [{0}]的数据已经存在!(in clszx_ConceptAttachmentBL.AddNewRecordBySql2WithReturnKey)", objzx_ConceptAttachmentEN.zxConceptId);
throw new Exception(strMsg);
}
try
{
string strKey = zx_ConceptAttachmentDA.AddNewRecordBySQL2WithReturnKey(objzx_ConceptAttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ConceptAttachmentBL.ReFreshCache();

if (clszx_ConceptAttachmentBL.relatedActions != null)
{
clszx_ConceptAttachmentBL.relatedActions.UpdRelaTabDate(objzx_ConceptAttachmentEN.zxConceptAttachmentId, "SetUpdDate");
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
 /// <param name = "objzx_ConceptAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clszx_ConceptAttachmentEN objzx_ConceptAttachmentEN)
{
try
{
bool bolResult = zx_ConceptAttachmentDA.Update(objzx_ConceptAttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ConceptAttachmentBL.ReFreshCache();

if (clszx_ConceptAttachmentBL.relatedActions != null)
{
clszx_ConceptAttachmentBL.relatedActions.UpdRelaTabDate(objzx_ConceptAttachmentEN.zxConceptAttachmentId, "SetUpdDate");
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
 /// <param name = "objzx_ConceptAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clszx_ConceptAttachmentEN objzx_ConceptAttachmentEN)
{
 if (objzx_ConceptAttachmentEN.zxConceptAttachmentId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = zx_ConceptAttachmentDA.UpdateBySql2(objzx_ConceptAttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ConceptAttachmentBL.ReFreshCache();

if (clszx_ConceptAttachmentBL.relatedActions != null)
{
clszx_ConceptAttachmentBL.relatedActions.UpdRelaTabDate(objzx_ConceptAttachmentEN.zxConceptAttachmentId, "SetUpdDate");
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
 /// <param name = "lngzxConceptAttachmentId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngzxConceptAttachmentId)
{
try
{
 clszx_ConceptAttachmentEN objzx_ConceptAttachmentEN = clszx_ConceptAttachmentBL.GetObjByzxConceptAttachmentId(lngzxConceptAttachmentId);

if (clszx_ConceptAttachmentBL.relatedActions != null)
{
clszx_ConceptAttachmentBL.relatedActions.UpdRelaTabDate(objzx_ConceptAttachmentEN.zxConceptAttachmentId, "SetUpdDate");
}
if (objzx_ConceptAttachmentEN != null)
{
int intRecNum = zx_ConceptAttachmentDA.DelRecord(lngzxConceptAttachmentId);
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
/// <param name="lngzxConceptAttachmentId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngzxConceptAttachmentId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_ConceptAttachmentDA.GetSpecSQLObj();
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
//删除与表:[zx_ConceptAttachment]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conzx_ConceptAttachment.zxConceptAttachmentId,
//lngzxConceptAttachmentId);
//        clszx_ConceptAttachmentBL.Delzx_ConceptAttachmentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_ConceptAttachmentBL.DelRecord(lngzxConceptAttachmentId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_ConceptAttachmentBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngzxConceptAttachmentId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngzxConceptAttachmentId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngzxConceptAttachmentId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clszx_ConceptAttachmentBL.relatedActions != null)
{
clszx_ConceptAttachmentBL.relatedActions.UpdRelaTabDate(lngzxConceptAttachmentId, "UpdRelaTabDate");
}
bool bolResult = zx_ConceptAttachmentDA.DelRecord(lngzxConceptAttachmentId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrzxConceptAttachmentIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delzx_ConceptAttachments(List<string> arrzxConceptAttachmentIdLst)
{
if (arrzxConceptAttachmentIdLst.Count == 0) return 0;
try
{
if (clszx_ConceptAttachmentBL.relatedActions != null)
{
foreach (var strzxConceptAttachmentId in arrzxConceptAttachmentIdLst)
{
long lngzxConceptAttachmentId = long.Parse(strzxConceptAttachmentId);
clszx_ConceptAttachmentBL.relatedActions.UpdRelaTabDate(lngzxConceptAttachmentId, "UpdRelaTabDate");
}
}
int intDelRecNum = zx_ConceptAttachmentDA.Delzx_ConceptAttachment(arrzxConceptAttachmentIdLst);
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
public static int Delzx_ConceptAttachmentsByCond(string strWhereCond)
{
try
{
if (clszx_ConceptAttachmentBL.relatedActions != null)
{
List<string> arrzxConceptAttachmentId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strzxConceptAttachmentId in arrzxConceptAttachmentId)
{
long lngzxConceptAttachmentId = long.Parse(strzxConceptAttachmentId);
clszx_ConceptAttachmentBL.relatedActions.UpdRelaTabDate(lngzxConceptAttachmentId, "UpdRelaTabDate");
}
}
int intRecNum = zx_ConceptAttachmentDA.Delzx_ConceptAttachment(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[zx_ConceptAttachment]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngzxConceptAttachmentId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngzxConceptAttachmentId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_ConceptAttachmentDA.GetSpecSQLObj();
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
//删除与表:[zx_ConceptAttachment]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_ConceptAttachmentBL.DelRecord(lngzxConceptAttachmentId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_ConceptAttachmentBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngzxConceptAttachmentId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objzx_ConceptAttachmentENS">源对象</param>
 /// <param name = "objzx_ConceptAttachmentENT">目标对象</param>
 public static void CopyTo(clszx_ConceptAttachmentEN objzx_ConceptAttachmentENS, clszx_ConceptAttachmentEN objzx_ConceptAttachmentENT)
{
try
{
objzx_ConceptAttachmentENT.zxConceptAttachmentId = objzx_ConceptAttachmentENS.zxConceptAttachmentId; //概念附件Id
objzx_ConceptAttachmentENT.ConceptAttachmentName = objzx_ConceptAttachmentENS.ConceptAttachmentName; //附件名称
objzx_ConceptAttachmentENT.zxConceptId = objzx_ConceptAttachmentENS.zxConceptId; //概念Id
objzx_ConceptAttachmentENT.FilePath = objzx_ConceptAttachmentENS.FilePath; //文件路径
objzx_ConceptAttachmentENT.UpdDate = objzx_ConceptAttachmentENS.UpdDate; //修改日期
objzx_ConceptAttachmentENT.UpdUserId = objzx_ConceptAttachmentENS.UpdUserId; //修改用户Id
objzx_ConceptAttachmentENT.Memo = objzx_ConceptAttachmentENS.Memo; //备注
objzx_ConceptAttachmentENT.IdCurrEduCls = objzx_ConceptAttachmentENS.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objzx_ConceptAttachmentEN">源简化对象</param>
 public static void SetUpdFlag(clszx_ConceptAttachmentEN objzx_ConceptAttachmentEN)
{
try
{
objzx_ConceptAttachmentEN.ClearUpdateState();
   string strsfUpdFldSetStr = objzx_ConceptAttachmentEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conzx_ConceptAttachment.zxConceptAttachmentId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptAttachmentEN.zxConceptAttachmentId = objzx_ConceptAttachmentEN.zxConceptAttachmentId; //概念附件Id
}
if (arrFldSet.Contains(conzx_ConceptAttachment.ConceptAttachmentName, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptAttachmentEN.ConceptAttachmentName = objzx_ConceptAttachmentEN.ConceptAttachmentName == "[null]" ? null :  objzx_ConceptAttachmentEN.ConceptAttachmentName; //附件名称
}
if (arrFldSet.Contains(conzx_ConceptAttachment.zxConceptId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptAttachmentEN.zxConceptId = objzx_ConceptAttachmentEN.zxConceptId; //概念Id
}
if (arrFldSet.Contains(conzx_ConceptAttachment.FilePath, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptAttachmentEN.FilePath = objzx_ConceptAttachmentEN.FilePath; //文件路径
}
if (arrFldSet.Contains(conzx_ConceptAttachment.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptAttachmentEN.UpdDate = objzx_ConceptAttachmentEN.UpdDate == "[null]" ? null :  objzx_ConceptAttachmentEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conzx_ConceptAttachment.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptAttachmentEN.UpdUserId = objzx_ConceptAttachmentEN.UpdUserId == "[null]" ? null :  objzx_ConceptAttachmentEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conzx_ConceptAttachment.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptAttachmentEN.Memo = objzx_ConceptAttachmentEN.Memo == "[null]" ? null :  objzx_ConceptAttachmentEN.Memo; //备注
}
if (arrFldSet.Contains(conzx_ConceptAttachment.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptAttachmentEN.IdCurrEduCls = objzx_ConceptAttachmentEN.IdCurrEduCls == "[null]" ? null :  objzx_ConceptAttachmentEN.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objzx_ConceptAttachmentEN">源简化对象</param>
 public static void AccessFldValueNull(clszx_ConceptAttachmentEN objzx_ConceptAttachmentEN)
{
try
{
if (objzx_ConceptAttachmentEN.ConceptAttachmentName == "[null]") objzx_ConceptAttachmentEN.ConceptAttachmentName = null; //附件名称
if (objzx_ConceptAttachmentEN.UpdDate == "[null]") objzx_ConceptAttachmentEN.UpdDate = null; //修改日期
if (objzx_ConceptAttachmentEN.UpdUserId == "[null]") objzx_ConceptAttachmentEN.UpdUserId = null; //修改用户Id
if (objzx_ConceptAttachmentEN.Memo == "[null]") objzx_ConceptAttachmentEN.Memo = null; //备注
if (objzx_ConceptAttachmentEN.IdCurrEduCls == "[null]") objzx_ConceptAttachmentEN.IdCurrEduCls = null; //教学班流水号
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
public static void CheckPropertyNew(clszx_ConceptAttachmentEN objzx_ConceptAttachmentEN)
{
 zx_ConceptAttachmentDA.CheckPropertyNew(objzx_ConceptAttachmentEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clszx_ConceptAttachmentEN objzx_ConceptAttachmentEN)
{
 zx_ConceptAttachmentDA.CheckProperty4Condition(objzx_ConceptAttachmentEN);
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
if (clszx_ConceptAttachmentBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_ConceptAttachmentBL没有刷新缓存机制(clszx_ConceptAttachmentBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by zxConceptAttachmentId");
//if (arrzx_ConceptAttachmentObjLstCache == null)
//{
//arrzx_ConceptAttachmentObjLstCache = zx_ConceptAttachmentDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngzxConceptAttachmentId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_ConceptAttachmentEN GetObjByzxConceptAttachmentIdCache(long lngzxConceptAttachmentId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clszx_ConceptAttachmentEN._CurrTabName);
List<clszx_ConceptAttachmentEN> arrzx_ConceptAttachmentObjLstCache = GetObjLstCache();
IEnumerable <clszx_ConceptAttachmentEN> arrzx_ConceptAttachmentObjLst_Sel =
arrzx_ConceptAttachmentObjLstCache
.Where(x=> x.zxConceptAttachmentId == lngzxConceptAttachmentId 
);
if (arrzx_ConceptAttachmentObjLst_Sel.Count() == 0)
{
   clszx_ConceptAttachmentEN obj = clszx_ConceptAttachmentBL.GetObjByzxConceptAttachmentId(lngzxConceptAttachmentId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrzx_ConceptAttachmentObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_ConceptAttachmentEN> GetAllzx_ConceptAttachmentObjLstCache()
{
//获取缓存中的对象列表
List<clszx_ConceptAttachmentEN> arrzx_ConceptAttachmentObjLstCache = GetObjLstCache(); 
return arrzx_ConceptAttachmentObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_ConceptAttachmentEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clszx_ConceptAttachmentEN._CurrTabName);
List<clszx_ConceptAttachmentEN> arrzx_ConceptAttachmentObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrzx_ConceptAttachmentObjLstCache;
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
string strKey = string.Format("{0}", clszx_ConceptAttachmentEN._CurrTabName);
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
if (clszx_ConceptAttachmentBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clszx_ConceptAttachmentEN._CurrTabName);
CacheHelper.Remove(strKey);
clszx_ConceptAttachmentBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--zx_ConceptAttachment(中学概念附件)
 /// 唯一性条件:zxConceptId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_ConceptAttachmentEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clszx_ConceptAttachmentEN objzx_ConceptAttachmentEN)
{
//检测记录是否存在
string strResult = zx_ConceptAttachmentDA.GetUniCondStr(objzx_ConceptAttachmentEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngzxConceptAttachmentId)
{
if (strInFldName != conzx_ConceptAttachment.zxConceptAttachmentId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conzx_ConceptAttachment.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conzx_ConceptAttachment.AttributeName));
throw new Exception(strMsg);
}
var objzx_ConceptAttachment = clszx_ConceptAttachmentBL.GetObjByzxConceptAttachmentIdCache(lngzxConceptAttachmentId);
if (objzx_ConceptAttachment == null) return "";
return objzx_ConceptAttachment[strOutFldName].ToString();
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
int intRecCount = clszx_ConceptAttachmentDA.GetRecCount(strTabName);
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
int intRecCount = clszx_ConceptAttachmentDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clszx_ConceptAttachmentDA.GetRecCount();
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
int intRecCount = clszx_ConceptAttachmentDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objzx_ConceptAttachmentCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clszx_ConceptAttachmentEN objzx_ConceptAttachmentCond)
{
List<clszx_ConceptAttachmentEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clszx_ConceptAttachmentEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_ConceptAttachment.AttributeName)
{
if (objzx_ConceptAttachmentCond.IsUpdated(strFldName) == false) continue;
if (objzx_ConceptAttachmentCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_ConceptAttachmentCond[strFldName].ToString());
}
else
{
if (objzx_ConceptAttachmentCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_ConceptAttachmentCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_ConceptAttachmentCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_ConceptAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_ConceptAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_ConceptAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_ConceptAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_ConceptAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_ConceptAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_ConceptAttachmentCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_ConceptAttachmentCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_ConceptAttachmentCond[strFldName]));
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
 List<string> arrList = clszx_ConceptAttachmentDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = zx_ConceptAttachmentDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = zx_ConceptAttachmentDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = zx_ConceptAttachmentDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_ConceptAttachmentDA.SetFldValue(clszx_ConceptAttachmentEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = zx_ConceptAttachmentDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_ConceptAttachmentDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_ConceptAttachmentDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_ConceptAttachmentDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[zx_ConceptAttachment] "); 
 strCreateTabCode.Append(" ( "); 
 // /**概念附件Id*/ 
 strCreateTabCode.Append(" zxConceptAttachmentId bigint primary key identity, "); 
 // /**附件名称*/ 
 strCreateTabCode.Append(" ConceptAttachmentName varchar(200) Null, "); 
 // /**概念Id*/ 
 strCreateTabCode.Append(" zxConceptId char(8) not Null, "); 
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
 /// 中学概念附件(zx_ConceptAttachment)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4zx_ConceptAttachment : clsCommFun4BL
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
clszx_ConceptAttachmentBL.ReFreshThisCache();
}
}

}