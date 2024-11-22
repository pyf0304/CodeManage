
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSysCountBL
 表名:SysCount(01120625)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:09:00
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培设置(GradEduTools)
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
public static class  clsSysCountBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strCountId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSysCountEN GetObj(this K_CountId_SysCount myKey)
{
clsSysCountEN objSysCountEN = clsSysCountBL.SysCountDA.GetObjByCountId(myKey.Value);
return objSysCountEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objSysCountEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsSysCountEN objSysCountEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objSysCountEN) == false)
{
var strMsg = string.Format("记录已经存在!CountTypeId = [{0}],表主键 = [{1}]的数据已经存在!(in clsSysCountBL.AddNewRecord)", objSysCountEN.CountTypeId,objSysCountEN.TableKey);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSysCountEN.CountId) == true || clsSysCountBL.IsExist(objSysCountEN.CountId) == true)
 {
     objSysCountEN.CountId = clsSysCountBL.GetMaxStrId_S();
 }
bool bolResult = clsSysCountBL.SysCountDA.AddNewRecordBySQL2(objSysCountEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysCountBL.ReFreshCache();

if (clsSysCountBL.relatedActions != null)
{
clsSysCountBL.relatedActions.UpdRelaTabDate(objSysCountEN.CountId, "SetUpdDate");
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
public static bool AddRecordEx(this clsSysCountEN objSysCountEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsSysCountBL.IsExist(objSysCountEN.CountId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objSysCountEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objSysCountEN.CheckUniqueness() == false)
{
strMsg = string.Format("(CountTypeId(CountTypeId)=[{0}],表主键(TableKey)=[{1}])已经存在,不能重复!", objSysCountEN.CountTypeId, objSysCountEN.TableKey);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objSysCountEN.CountId) == true || clsSysCountBL.IsExist(objSysCountEN.CountId) == true)
 {
     objSysCountEN.CountId = clsSysCountBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objSysCountEN.AddNewRecord();
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
 /// <param name = "objSysCountEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsSysCountEN objSysCountEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objSysCountEN) == false)
{
var strMsg = string.Format("记录已经存在!CountTypeId = [{0}],表主键 = [{1}]的数据已经存在!(in clsSysCountBL.AddNewRecordWithMaxId)", objSysCountEN.CountTypeId,objSysCountEN.TableKey);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSysCountEN.CountId) == true || clsSysCountBL.IsExist(objSysCountEN.CountId) == true)
 {
     objSysCountEN.CountId = clsSysCountBL.GetMaxStrId_S();
 }
string strCountId = clsSysCountBL.SysCountDA.AddNewRecordBySQL2WithReturnKey(objSysCountEN);
     objSysCountEN.CountId = strCountId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysCountBL.ReFreshCache();

if (clsSysCountBL.relatedActions != null)
{
clsSysCountBL.relatedActions.UpdRelaTabDate(objSysCountEN.CountId, "SetUpdDate");
}
return strCountId;
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
 /// <param name = "objSysCountEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsSysCountEN objSysCountEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objSysCountEN) == false)
{
var strMsg = string.Format("记录已经存在!CountTypeId = [{0}],表主键 = [{1}]的数据已经存在!(in clsSysCountBL.AddNewRecordWithReturnKey)", objSysCountEN.CountTypeId,objSysCountEN.TableKey);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSysCountEN.CountId) == true || clsSysCountBL.IsExist(objSysCountEN.CountId) == true)
 {
     objSysCountEN.CountId = clsSysCountBL.GetMaxStrId_S();
 }
string strKey = clsSysCountBL.SysCountDA.AddNewRecordBySQL2WithReturnKey(objSysCountEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysCountBL.ReFreshCache();

if (clsSysCountBL.relatedActions != null)
{
clsSysCountBL.relatedActions.UpdRelaTabDate(objSysCountEN.CountId, "SetUpdDate");
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
 /// <param name = "objSysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysCountEN SetCountId(this clsSysCountEN objSysCountEN, string strCountId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCountId, 10, conSysCount.CountId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCountId, 10, conSysCount.CountId);
}
objSysCountEN.CountId = strCountId; //CountId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysCountEN.dicFldComparisonOp.ContainsKey(conSysCount.CountId) == false)
{
objSysCountEN.dicFldComparisonOp.Add(conSysCount.CountId, strComparisonOp);
}
else
{
objSysCountEN.dicFldComparisonOp[conSysCount.CountId] = strComparisonOp;
}
}
return objSysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysCountEN SetCountTypeId(this clsSysCountEN objSysCountEN, string strCountTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCountTypeId, 2, conSysCount.CountTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCountTypeId, 2, conSysCount.CountTypeId);
}
objSysCountEN.CountTypeId = strCountTypeId; //CountTypeId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysCountEN.dicFldComparisonOp.ContainsKey(conSysCount.CountTypeId) == false)
{
objSysCountEN.dicFldComparisonOp.Add(conSysCount.CountTypeId, strComparisonOp);
}
else
{
objSysCountEN.dicFldComparisonOp[conSysCount.CountTypeId] = strComparisonOp;
}
}
return objSysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysCountEN SetPaperRWCount(this clsSysCountEN objSysCountEN, int? intPaperRWCount, string strComparisonOp="")
	{
objSysCountEN.PaperRWCount = intPaperRWCount; //PaperRWCount
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysCountEN.dicFldComparisonOp.ContainsKey(conSysCount.PaperRWCount) == false)
{
objSysCountEN.dicFldComparisonOp.Add(conSysCount.PaperRWCount, strComparisonOp);
}
else
{
objSysCountEN.dicFldComparisonOp[conSysCount.PaperRWCount] = strComparisonOp;
}
}
return objSysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysCountEN SetOkCount(this clsSysCountEN objSysCountEN, int? intOkCount, string strComparisonOp="")
	{
objSysCountEN.OkCount = intOkCount; //点赞统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysCountEN.dicFldComparisonOp.ContainsKey(conSysCount.OkCount) == false)
{
objSysCountEN.dicFldComparisonOp.Add(conSysCount.OkCount, strComparisonOp);
}
else
{
objSysCountEN.dicFldComparisonOp[conSysCount.OkCount] = strComparisonOp;
}
}
return objSysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysCountEN SetCollectionCount(this clsSysCountEN objSysCountEN, long? lngCollectionCount, string strComparisonOp="")
	{
objSysCountEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysCountEN.dicFldComparisonOp.ContainsKey(conSysCount.CollectionCount) == false)
{
objSysCountEN.dicFldComparisonOp.Add(conSysCount.CollectionCount, strComparisonOp);
}
else
{
objSysCountEN.dicFldComparisonOp[conSysCount.CollectionCount] = strComparisonOp;
}
}
return objSysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysCountEN SetDownloadCount(this clsSysCountEN objSysCountEN, int? intDownloadCount, string strComparisonOp="")
	{
objSysCountEN.DownloadCount = intDownloadCount; //下载数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysCountEN.dicFldComparisonOp.ContainsKey(conSysCount.DownloadCount) == false)
{
objSysCountEN.dicFldComparisonOp.Add(conSysCount.DownloadCount, strComparisonOp);
}
else
{
objSysCountEN.dicFldComparisonOp[conSysCount.DownloadCount] = strComparisonOp;
}
}
return objSysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysCountEN SetAttachmentCount(this clsSysCountEN objSysCountEN, int? intAttachmentCount, string strComparisonOp="")
	{
objSysCountEN.AttachmentCount = intAttachmentCount; //附件计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysCountEN.dicFldComparisonOp.ContainsKey(conSysCount.AttachmentCount) == false)
{
objSysCountEN.dicFldComparisonOp.Add(conSysCount.AttachmentCount, strComparisonOp);
}
else
{
objSysCountEN.dicFldComparisonOp[conSysCount.AttachmentCount] = strComparisonOp;
}
}
return objSysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysCountEN SetCommentCount(this clsSysCountEN objSysCountEN, int? intCommentCount, string strComparisonOp="")
	{
objSysCountEN.CommentCount = intCommentCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysCountEN.dicFldComparisonOp.ContainsKey(conSysCount.CommentCount) == false)
{
objSysCountEN.dicFldComparisonOp.Add(conSysCount.CommentCount, strComparisonOp);
}
else
{
objSysCountEN.dicFldComparisonOp[conSysCount.CommentCount] = strComparisonOp;
}
}
return objSysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysCountEN SetScore(this clsSysCountEN objSysCountEN, float? fltScore, string strComparisonOp="")
	{
objSysCountEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysCountEN.dicFldComparisonOp.ContainsKey(conSysCount.Score) == false)
{
objSysCountEN.dicFldComparisonOp.Add(conSysCount.Score, strComparisonOp);
}
else
{
objSysCountEN.dicFldComparisonOp[conSysCount.Score] = strComparisonOp;
}
}
return objSysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysCountEN SetStuScore(this clsSysCountEN objSysCountEN, float? fltStuScore, string strComparisonOp="")
	{
objSysCountEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysCountEN.dicFldComparisonOp.ContainsKey(conSysCount.StuScore) == false)
{
objSysCountEN.dicFldComparisonOp.Add(conSysCount.StuScore, strComparisonOp);
}
else
{
objSysCountEN.dicFldComparisonOp[conSysCount.StuScore] = strComparisonOp;
}
}
return objSysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysCountEN SetTeaScore(this clsSysCountEN objSysCountEN, float? fltTeaScore, string strComparisonOp="")
	{
objSysCountEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysCountEN.dicFldComparisonOp.ContainsKey(conSysCount.TeaScore) == false)
{
objSysCountEN.dicFldComparisonOp.Add(conSysCount.TeaScore, strComparisonOp);
}
else
{
objSysCountEN.dicFldComparisonOp[conSysCount.TeaScore] = strComparisonOp;
}
}
return objSysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysCountEN SetTableKey(this clsSysCountEN objSysCountEN, string strTableKey, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTableKey, 20, conSysCount.TableKey);
}
objSysCountEN.TableKey = strTableKey; //表主键
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysCountEN.dicFldComparisonOp.ContainsKey(conSysCount.TableKey) == false)
{
objSysCountEN.dicFldComparisonOp.Add(conSysCount.TableKey, strComparisonOp);
}
else
{
objSysCountEN.dicFldComparisonOp[conSysCount.TableKey] = strComparisonOp;
}
}
return objSysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysCountEN SetParentId(this clsSysCountEN objSysCountEN, string strParentId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentId, 20, conSysCount.ParentId);
}
objSysCountEN.ParentId = strParentId; //父Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysCountEN.dicFldComparisonOp.ContainsKey(conSysCount.ParentId) == false)
{
objSysCountEN.dicFldComparisonOp.Add(conSysCount.ParentId, strComparisonOp);
}
else
{
objSysCountEN.dicFldComparisonOp[conSysCount.ParentId] = strComparisonOp;
}
}
return objSysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysCountEN SetUpdUser(this clsSysCountEN objSysCountEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conSysCount.UpdUser);
}
objSysCountEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysCountEN.dicFldComparisonOp.ContainsKey(conSysCount.UpdUser) == false)
{
objSysCountEN.dicFldComparisonOp.Add(conSysCount.UpdUser, strComparisonOp);
}
else
{
objSysCountEN.dicFldComparisonOp[conSysCount.UpdUser] = strComparisonOp;
}
}
return objSysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysCountEN SetUpdDate(this clsSysCountEN objSysCountEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conSysCount.UpdDate);
}
objSysCountEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysCountEN.dicFldComparisonOp.ContainsKey(conSysCount.UpdDate) == false)
{
objSysCountEN.dicFldComparisonOp.Add(conSysCount.UpdDate, strComparisonOp);
}
else
{
objSysCountEN.dicFldComparisonOp[conSysCount.UpdDate] = strComparisonOp;
}
}
return objSysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysCountEN SetMemo(this clsSysCountEN objSysCountEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conSysCount.Memo);
}
objSysCountEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysCountEN.dicFldComparisonOp.ContainsKey(conSysCount.Memo) == false)
{
objSysCountEN.dicFldComparisonOp.Add(conSysCount.Memo, strComparisonOp);
}
else
{
objSysCountEN.dicFldComparisonOp[conSysCount.Memo] = strComparisonOp;
}
}
return objSysCountEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objSysCountEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsSysCountEN objSysCountEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objSysCountEN.CheckPropertyNew();
clsSysCountEN objSysCountCond = new clsSysCountEN();
string strCondition = objSysCountCond
.SetCountId(objSysCountEN.CountId, "<>")
.SetCountTypeId(objSysCountEN.CountTypeId, "=")
.SetTableKey(objSysCountEN.TableKey, "=")
.GetCombineCondition();
objSysCountEN._IsCheckProperty = true;
bool bolIsExist = clsSysCountBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(CountTypeId_TableKey)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objSysCountEN.Update();
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
 /// <param name = "objSysCount">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsSysCountEN objSysCount)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsSysCountEN objSysCountCond = new clsSysCountEN();
string strCondition = objSysCountCond
.SetCountTypeId(objSysCount.CountTypeId, "=")
.SetTableKey(objSysCount.TableKey, "=")
.GetCombineCondition();
objSysCount._IsCheckProperty = true;
bool bolIsExist = clsSysCountBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objSysCount.CountId = clsSysCountBL.GetFirstID_S(strCondition);
objSysCount.UpdateWithCondition(strCondition);
}
else
{
objSysCount.CountId = clsSysCountBL.GetMaxStrId_S();
objSysCount.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objSysCountEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSysCountEN objSysCountEN)
{
 if (string.IsNullOrEmpty(objSysCountEN.CountId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSysCountBL.SysCountDA.UpdateBySql2(objSysCountEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysCountBL.ReFreshCache();

if (clsSysCountBL.relatedActions != null)
{
clsSysCountBL.relatedActions.UpdRelaTabDate(objSysCountEN.CountId, "SetUpdDate");
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
 /// <param name = "objSysCountEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSysCountEN objSysCountEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objSysCountEN.CountId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSysCountBL.SysCountDA.UpdateBySql2(objSysCountEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysCountBL.ReFreshCache();

if (clsSysCountBL.relatedActions != null)
{
clsSysCountBL.relatedActions.UpdRelaTabDate(objSysCountEN.CountId, "SetUpdDate");
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
 /// <param name = "objSysCountEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSysCountEN objSysCountEN, string strWhereCond)
{
try
{
bool bolResult = clsSysCountBL.SysCountDA.UpdateBySqlWithCondition(objSysCountEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysCountBL.ReFreshCache();

if (clsSysCountBL.relatedActions != null)
{
clsSysCountBL.relatedActions.UpdRelaTabDate(objSysCountEN.CountId, "SetUpdDate");
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
 /// <param name = "objSysCountEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSysCountEN objSysCountEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsSysCountBL.SysCountDA.UpdateBySqlWithConditionTransaction(objSysCountEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysCountBL.ReFreshCache();

if (clsSysCountBL.relatedActions != null)
{
clsSysCountBL.relatedActions.UpdRelaTabDate(objSysCountEN.CountId, "SetUpdDate");
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
 /// <param name = "strCountId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsSysCountEN objSysCountEN)
{
try
{
int intRecNum = clsSysCountBL.SysCountDA.DelRecord(objSysCountEN.CountId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysCountBL.ReFreshCache();

if (clsSysCountBL.relatedActions != null)
{
clsSysCountBL.relatedActions.UpdRelaTabDate(objSysCountEN.CountId, "SetUpdDate");
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
 /// <param name = "objSysCountENS">源对象</param>
 /// <param name = "objSysCountENT">目标对象</param>
 public static void CopyTo(this clsSysCountEN objSysCountENS, clsSysCountEN objSysCountENT)
{
try
{
objSysCountENT.CountId = objSysCountENS.CountId; //CountId
objSysCountENT.CountTypeId = objSysCountENS.CountTypeId; //CountTypeId
objSysCountENT.PaperRWCount = objSysCountENS.PaperRWCount; //PaperRWCount
objSysCountENT.OkCount = objSysCountENS.OkCount; //点赞统计
objSysCountENT.CollectionCount = objSysCountENS.CollectionCount; //收藏数量
objSysCountENT.DownloadCount = objSysCountENS.DownloadCount; //下载数
objSysCountENT.AttachmentCount = objSysCountENS.AttachmentCount; //附件计数
objSysCountENT.CommentCount = objSysCountENS.CommentCount; //评论数
objSysCountENT.Score = objSysCountENS.Score; //评分
objSysCountENT.StuScore = objSysCountENS.StuScore; //学生平均分
objSysCountENT.TeaScore = objSysCountENS.TeaScore; //教师评分
objSysCountENT.TableKey = objSysCountENS.TableKey; //表主键
objSysCountENT.ParentId = objSysCountENS.ParentId; //父Id
objSysCountENT.UpdUser = objSysCountENS.UpdUser; //修改人
objSysCountENT.UpdDate = objSysCountENS.UpdDate; //修改日期
objSysCountENT.Memo = objSysCountENS.Memo; //备注
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
 /// <param name = "objSysCountENS">源对象</param>
 /// <returns>目标对象=>clsSysCountEN:objSysCountENT</returns>
 public static clsSysCountEN CopyTo(this clsSysCountEN objSysCountENS)
{
try
{
 clsSysCountEN objSysCountENT = new clsSysCountEN()
{
CountId = objSysCountENS.CountId, //CountId
CountTypeId = objSysCountENS.CountTypeId, //CountTypeId
PaperRWCount = objSysCountENS.PaperRWCount, //PaperRWCount
OkCount = objSysCountENS.OkCount, //点赞统计
CollectionCount = objSysCountENS.CollectionCount, //收藏数量
DownloadCount = objSysCountENS.DownloadCount, //下载数
AttachmentCount = objSysCountENS.AttachmentCount, //附件计数
CommentCount = objSysCountENS.CommentCount, //评论数
Score = objSysCountENS.Score, //评分
StuScore = objSysCountENS.StuScore, //学生平均分
TeaScore = objSysCountENS.TeaScore, //教师评分
TableKey = objSysCountENS.TableKey, //表主键
ParentId = objSysCountENS.ParentId, //父Id
UpdUser = objSysCountENS.UpdUser, //修改人
UpdDate = objSysCountENS.UpdDate, //修改日期
Memo = objSysCountENS.Memo, //备注
};
 return objSysCountENT;
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
public static void CheckPropertyNew(this clsSysCountEN objSysCountEN)
{
 clsSysCountBL.SysCountDA.CheckPropertyNew(objSysCountEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsSysCountEN objSysCountEN)
{
 clsSysCountBL.SysCountDA.CheckProperty4Condition(objSysCountEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsSysCountEN objSysCountCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objSysCountCond.IsUpdated(conSysCount.CountId) == true)
{
string strComparisonOpCountId = objSysCountCond.dicFldComparisonOp[conSysCount.CountId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysCount.CountId, objSysCountCond.CountId, strComparisonOpCountId);
}
if (objSysCountCond.IsUpdated(conSysCount.CountTypeId) == true)
{
string strComparisonOpCountTypeId = objSysCountCond.dicFldComparisonOp[conSysCount.CountTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysCount.CountTypeId, objSysCountCond.CountTypeId, strComparisonOpCountTypeId);
}
if (objSysCountCond.IsUpdated(conSysCount.PaperRWCount) == true)
{
string strComparisonOpPaperRWCount = objSysCountCond.dicFldComparisonOp[conSysCount.PaperRWCount];
strWhereCond += string.Format(" And {0} {2} {1}", conSysCount.PaperRWCount, objSysCountCond.PaperRWCount, strComparisonOpPaperRWCount);
}
if (objSysCountCond.IsUpdated(conSysCount.OkCount) == true)
{
string strComparisonOpOkCount = objSysCountCond.dicFldComparisonOp[conSysCount.OkCount];
strWhereCond += string.Format(" And {0} {2} {1}", conSysCount.OkCount, objSysCountCond.OkCount, strComparisonOpOkCount);
}
if (objSysCountCond.IsUpdated(conSysCount.CollectionCount) == true)
{
string strComparisonOpCollectionCount = objSysCountCond.dicFldComparisonOp[conSysCount.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", conSysCount.CollectionCount, objSysCountCond.CollectionCount, strComparisonOpCollectionCount);
}
if (objSysCountCond.IsUpdated(conSysCount.DownloadCount) == true)
{
string strComparisonOpDownloadCount = objSysCountCond.dicFldComparisonOp[conSysCount.DownloadCount];
strWhereCond += string.Format(" And {0} {2} {1}", conSysCount.DownloadCount, objSysCountCond.DownloadCount, strComparisonOpDownloadCount);
}
if (objSysCountCond.IsUpdated(conSysCount.AttachmentCount) == true)
{
string strComparisonOpAttachmentCount = objSysCountCond.dicFldComparisonOp[conSysCount.AttachmentCount];
strWhereCond += string.Format(" And {0} {2} {1}", conSysCount.AttachmentCount, objSysCountCond.AttachmentCount, strComparisonOpAttachmentCount);
}
if (objSysCountCond.IsUpdated(conSysCount.CommentCount) == true)
{
string strComparisonOpCommentCount = objSysCountCond.dicFldComparisonOp[conSysCount.CommentCount];
strWhereCond += string.Format(" And {0} {2} {1}", conSysCount.CommentCount, objSysCountCond.CommentCount, strComparisonOpCommentCount);
}
if (objSysCountCond.IsUpdated(conSysCount.Score) == true)
{
string strComparisonOpScore = objSysCountCond.dicFldComparisonOp[conSysCount.Score];
strWhereCond += string.Format(" And {0} {2} {1}", conSysCount.Score, objSysCountCond.Score, strComparisonOpScore);
}
if (objSysCountCond.IsUpdated(conSysCount.StuScore) == true)
{
string strComparisonOpStuScore = objSysCountCond.dicFldComparisonOp[conSysCount.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", conSysCount.StuScore, objSysCountCond.StuScore, strComparisonOpStuScore);
}
if (objSysCountCond.IsUpdated(conSysCount.TeaScore) == true)
{
string strComparisonOpTeaScore = objSysCountCond.dicFldComparisonOp[conSysCount.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", conSysCount.TeaScore, objSysCountCond.TeaScore, strComparisonOpTeaScore);
}
if (objSysCountCond.IsUpdated(conSysCount.TableKey) == true)
{
string strComparisonOpTableKey = objSysCountCond.dicFldComparisonOp[conSysCount.TableKey];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysCount.TableKey, objSysCountCond.TableKey, strComparisonOpTableKey);
}
if (objSysCountCond.IsUpdated(conSysCount.ParentId) == true)
{
string strComparisonOpParentId = objSysCountCond.dicFldComparisonOp[conSysCount.ParentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysCount.ParentId, objSysCountCond.ParentId, strComparisonOpParentId);
}
if (objSysCountCond.IsUpdated(conSysCount.UpdUser) == true)
{
string strComparisonOpUpdUser = objSysCountCond.dicFldComparisonOp[conSysCount.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysCount.UpdUser, objSysCountCond.UpdUser, strComparisonOpUpdUser);
}
if (objSysCountCond.IsUpdated(conSysCount.UpdDate) == true)
{
string strComparisonOpUpdDate = objSysCountCond.dicFldComparisonOp[conSysCount.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysCount.UpdDate, objSysCountCond.UpdDate, strComparisonOpUpdDate);
}
if (objSysCountCond.IsUpdated(conSysCount.Memo) == true)
{
string strComparisonOpMemo = objSysCountCond.dicFldComparisonOp[conSysCount.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysCount.Memo, objSysCountCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--SysCount(统计数据), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:CountTypeId_TableKey
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objSysCountEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsSysCountEN objSysCountEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objSysCountEN == null) return true;
if (objSysCountEN.CountId == null || objSysCountEN.CountId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objSysCountEN.CountTypeId == null)
{
 sbCondition.AppendFormat(" and CountTypeId is null", objSysCountEN.CountTypeId);
}
else
{
 sbCondition.AppendFormat(" and CountTypeId = '{0}'", objSysCountEN.CountTypeId);
}
 if (objSysCountEN.TableKey == null)
{
 sbCondition.AppendFormat(" and TableKey is null", objSysCountEN.TableKey);
}
else
{
 sbCondition.AppendFormat(" and TableKey = '{0}'", objSysCountEN.TableKey);
}
if (clsSysCountBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("CountId !=  '{0}'", objSysCountEN.CountId);
 sbCondition.AppendFormat(" and CountTypeId = '{0}'", objSysCountEN.CountTypeId);
 sbCondition.AppendFormat(" and TableKey = '{0}'", objSysCountEN.TableKey);
if (clsSysCountBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--SysCount(统计数据), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:CountTypeId_TableKey
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objSysCountEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsSysCountEN objSysCountEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objSysCountEN == null) return "";
if (objSysCountEN.CountId == null || objSysCountEN.CountId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objSysCountEN.CountTypeId == null)
{
 sbCondition.AppendFormat(" and CountTypeId is null", objSysCountEN.CountTypeId);
}
else
{
 sbCondition.AppendFormat(" and CountTypeId = '{0}'", objSysCountEN.CountTypeId);
}
 if (objSysCountEN.TableKey == null)
{
 sbCondition.AppendFormat(" and TableKey is null", objSysCountEN.TableKey);
}
else
{
 sbCondition.AppendFormat(" and TableKey = '{0}'", objSysCountEN.TableKey);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("CountId !=  '{0}'", objSysCountEN.CountId);
 sbCondition.AppendFormat(" and CountTypeId = '{0}'", objSysCountEN.CountTypeId);
 sbCondition.AppendFormat(" and TableKey = '{0}'", objSysCountEN.TableKey);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_SysCount
{
public virtual bool UpdRelaTabDate(string strCountId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 统计数据(SysCount)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsSysCountBL
{
public static RelatedActions_SysCount relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsSysCountDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsSysCountDA SysCountDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsSysCountDA();
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
 public clsSysCountBL()
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
if (string.IsNullOrEmpty(clsSysCountEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsSysCountEN._ConnectString);
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
public static DataTable GetDataTable_SysCount(string strWhereCond)
{
DataTable objDT;
try
{
objDT = SysCountDA.GetDataTable_SysCount(strWhereCond);
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
objDT = SysCountDA.GetDataTable(strWhereCond);
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
objDT = SysCountDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = SysCountDA.GetDataTable(strWhereCond, strTabName);
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
objDT = SysCountDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = SysCountDA.GetDataTable_Top(objTopPara);
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
objDT = SysCountDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = SysCountDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = SysCountDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrCountIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsSysCountEN> GetObjLstByCountIdLst(List<string> arrCountIdLst)
{
List<clsSysCountEN> arrObjLst = new List<clsSysCountEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrCountIdLst, true);
 string strWhereCond = string.Format("CountId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysCountEN objSysCountEN = new clsSysCountEN();
try
{
objSysCountEN.CountId = objRow[conSysCount.CountId].ToString().Trim(); //CountId
objSysCountEN.CountTypeId = objRow[conSysCount.CountTypeId] == DBNull.Value ? null : objRow[conSysCount.CountTypeId].ToString().Trim(); //CountTypeId
objSysCountEN.PaperRWCount = objRow[conSysCount.PaperRWCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
objSysCountEN.OkCount = objRow[conSysCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.OkCount].ToString().Trim()); //点赞统计
objSysCountEN.CollectionCount = objRow[conSysCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.CollectionCount].ToString().Trim()); //收藏数量
objSysCountEN.DownloadCount = objRow[conSysCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.DownloadCount].ToString().Trim()); //下载数
objSysCountEN.AttachmentCount = objRow[conSysCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.AttachmentCount].ToString().Trim()); //附件计数
objSysCountEN.CommentCount = objRow[conSysCount.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.CommentCount].ToString().Trim()); //评论数
objSysCountEN.Score = objRow[conSysCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysCount.Score].ToString().Trim()); //评分
objSysCountEN.StuScore = objRow[conSysCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysCount.StuScore].ToString().Trim()); //学生平均分
objSysCountEN.TeaScore = objRow[conSysCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysCount.TeaScore].ToString().Trim()); //教师评分
objSysCountEN.TableKey = objRow[conSysCount.TableKey] == DBNull.Value ? null : objRow[conSysCount.TableKey].ToString().Trim(); //表主键
objSysCountEN.ParentId = objRow[conSysCount.ParentId] == DBNull.Value ? null : objRow[conSysCount.ParentId].ToString().Trim(); //父Id
objSysCountEN.UpdUser = objRow[conSysCount.UpdUser] == DBNull.Value ? null : objRow[conSysCount.UpdUser].ToString().Trim(); //修改人
objSysCountEN.UpdDate = objRow[conSysCount.UpdDate] == DBNull.Value ? null : objRow[conSysCount.UpdDate].ToString().Trim(); //修改日期
objSysCountEN.Memo = objRow[conSysCount.Memo] == DBNull.Value ? null : objRow[conSysCount.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysCountEN.CountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysCountEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrCountIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsSysCountEN> GetObjLstByCountIdLstCache(List<string> arrCountIdLst)
{
string strKey = string.Format("{0}", clsSysCountEN._CurrTabName);
List<clsSysCountEN> arrSysCountObjLstCache = GetObjLstCache();
IEnumerable <clsSysCountEN> arrSysCountObjLst_Sel =
arrSysCountObjLstCache
.Where(x => arrCountIdLst.Contains(x.CountId));
return arrSysCountObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsSysCountEN> GetObjLst(string strWhereCond)
{
List<clsSysCountEN> arrObjLst = new List<clsSysCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysCountEN objSysCountEN = new clsSysCountEN();
try
{
objSysCountEN.CountId = objRow[conSysCount.CountId].ToString().Trim(); //CountId
objSysCountEN.CountTypeId = objRow[conSysCount.CountTypeId] == DBNull.Value ? null : objRow[conSysCount.CountTypeId].ToString().Trim(); //CountTypeId
objSysCountEN.PaperRWCount = objRow[conSysCount.PaperRWCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
objSysCountEN.OkCount = objRow[conSysCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.OkCount].ToString().Trim()); //点赞统计
objSysCountEN.CollectionCount = objRow[conSysCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.CollectionCount].ToString().Trim()); //收藏数量
objSysCountEN.DownloadCount = objRow[conSysCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.DownloadCount].ToString().Trim()); //下载数
objSysCountEN.AttachmentCount = objRow[conSysCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.AttachmentCount].ToString().Trim()); //附件计数
objSysCountEN.CommentCount = objRow[conSysCount.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.CommentCount].ToString().Trim()); //评论数
objSysCountEN.Score = objRow[conSysCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysCount.Score].ToString().Trim()); //评分
objSysCountEN.StuScore = objRow[conSysCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysCount.StuScore].ToString().Trim()); //学生平均分
objSysCountEN.TeaScore = objRow[conSysCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysCount.TeaScore].ToString().Trim()); //教师评分
objSysCountEN.TableKey = objRow[conSysCount.TableKey] == DBNull.Value ? null : objRow[conSysCount.TableKey].ToString().Trim(); //表主键
objSysCountEN.ParentId = objRow[conSysCount.ParentId] == DBNull.Value ? null : objRow[conSysCount.ParentId].ToString().Trim(); //父Id
objSysCountEN.UpdUser = objRow[conSysCount.UpdUser] == DBNull.Value ? null : objRow[conSysCount.UpdUser].ToString().Trim(); //修改人
objSysCountEN.UpdDate = objRow[conSysCount.UpdDate] == DBNull.Value ? null : objRow[conSysCount.UpdDate].ToString().Trim(); //修改日期
objSysCountEN.Memo = objRow[conSysCount.Memo] == DBNull.Value ? null : objRow[conSysCount.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysCountEN.CountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysCountEN);
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
public static List<clsSysCountEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsSysCountEN> arrObjLst = new List<clsSysCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysCountEN objSysCountEN = new clsSysCountEN();
try
{
objSysCountEN.CountId = objRow[conSysCount.CountId].ToString().Trim(); //CountId
objSysCountEN.CountTypeId = objRow[conSysCount.CountTypeId] == DBNull.Value ? null : objRow[conSysCount.CountTypeId].ToString().Trim(); //CountTypeId
objSysCountEN.PaperRWCount = objRow[conSysCount.PaperRWCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
objSysCountEN.OkCount = objRow[conSysCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.OkCount].ToString().Trim()); //点赞统计
objSysCountEN.CollectionCount = objRow[conSysCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.CollectionCount].ToString().Trim()); //收藏数量
objSysCountEN.DownloadCount = objRow[conSysCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.DownloadCount].ToString().Trim()); //下载数
objSysCountEN.AttachmentCount = objRow[conSysCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.AttachmentCount].ToString().Trim()); //附件计数
objSysCountEN.CommentCount = objRow[conSysCount.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.CommentCount].ToString().Trim()); //评论数
objSysCountEN.Score = objRow[conSysCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysCount.Score].ToString().Trim()); //评分
objSysCountEN.StuScore = objRow[conSysCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysCount.StuScore].ToString().Trim()); //学生平均分
objSysCountEN.TeaScore = objRow[conSysCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysCount.TeaScore].ToString().Trim()); //教师评分
objSysCountEN.TableKey = objRow[conSysCount.TableKey] == DBNull.Value ? null : objRow[conSysCount.TableKey].ToString().Trim(); //表主键
objSysCountEN.ParentId = objRow[conSysCount.ParentId] == DBNull.Value ? null : objRow[conSysCount.ParentId].ToString().Trim(); //父Id
objSysCountEN.UpdUser = objRow[conSysCount.UpdUser] == DBNull.Value ? null : objRow[conSysCount.UpdUser].ToString().Trim(); //修改人
objSysCountEN.UpdDate = objRow[conSysCount.UpdDate] == DBNull.Value ? null : objRow[conSysCount.UpdDate].ToString().Trim(); //修改日期
objSysCountEN.Memo = objRow[conSysCount.Memo] == DBNull.Value ? null : objRow[conSysCount.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysCountEN.CountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysCountEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objSysCountCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsSysCountEN> GetSubObjLstCache(clsSysCountEN objSysCountCond)
{
List<clsSysCountEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsSysCountEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSysCount.AttributeName)
{
if (objSysCountCond.IsUpdated(strFldName) == false) continue;
if (objSysCountCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSysCountCond[strFldName].ToString());
}
else
{
if (objSysCountCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSysCountCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSysCountCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSysCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSysCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSysCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSysCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSysCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSysCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSysCountCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSysCountCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSysCountCond[strFldName]));
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
public static List<clsSysCountEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsSysCountEN> arrObjLst = new List<clsSysCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysCountEN objSysCountEN = new clsSysCountEN();
try
{
objSysCountEN.CountId = objRow[conSysCount.CountId].ToString().Trim(); //CountId
objSysCountEN.CountTypeId = objRow[conSysCount.CountTypeId] == DBNull.Value ? null : objRow[conSysCount.CountTypeId].ToString().Trim(); //CountTypeId
objSysCountEN.PaperRWCount = objRow[conSysCount.PaperRWCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
objSysCountEN.OkCount = objRow[conSysCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.OkCount].ToString().Trim()); //点赞统计
objSysCountEN.CollectionCount = objRow[conSysCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.CollectionCount].ToString().Trim()); //收藏数量
objSysCountEN.DownloadCount = objRow[conSysCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.DownloadCount].ToString().Trim()); //下载数
objSysCountEN.AttachmentCount = objRow[conSysCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.AttachmentCount].ToString().Trim()); //附件计数
objSysCountEN.CommentCount = objRow[conSysCount.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.CommentCount].ToString().Trim()); //评论数
objSysCountEN.Score = objRow[conSysCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysCount.Score].ToString().Trim()); //评分
objSysCountEN.StuScore = objRow[conSysCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysCount.StuScore].ToString().Trim()); //学生平均分
objSysCountEN.TeaScore = objRow[conSysCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysCount.TeaScore].ToString().Trim()); //教师评分
objSysCountEN.TableKey = objRow[conSysCount.TableKey] == DBNull.Value ? null : objRow[conSysCount.TableKey].ToString().Trim(); //表主键
objSysCountEN.ParentId = objRow[conSysCount.ParentId] == DBNull.Value ? null : objRow[conSysCount.ParentId].ToString().Trim(); //父Id
objSysCountEN.UpdUser = objRow[conSysCount.UpdUser] == DBNull.Value ? null : objRow[conSysCount.UpdUser].ToString().Trim(); //修改人
objSysCountEN.UpdDate = objRow[conSysCount.UpdDate] == DBNull.Value ? null : objRow[conSysCount.UpdDate].ToString().Trim(); //修改日期
objSysCountEN.Memo = objRow[conSysCount.Memo] == DBNull.Value ? null : objRow[conSysCount.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysCountEN.CountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysCountEN);
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
public static List<clsSysCountEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsSysCountEN> arrObjLst = new List<clsSysCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysCountEN objSysCountEN = new clsSysCountEN();
try
{
objSysCountEN.CountId = objRow[conSysCount.CountId].ToString().Trim(); //CountId
objSysCountEN.CountTypeId = objRow[conSysCount.CountTypeId] == DBNull.Value ? null : objRow[conSysCount.CountTypeId].ToString().Trim(); //CountTypeId
objSysCountEN.PaperRWCount = objRow[conSysCount.PaperRWCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
objSysCountEN.OkCount = objRow[conSysCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.OkCount].ToString().Trim()); //点赞统计
objSysCountEN.CollectionCount = objRow[conSysCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.CollectionCount].ToString().Trim()); //收藏数量
objSysCountEN.DownloadCount = objRow[conSysCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.DownloadCount].ToString().Trim()); //下载数
objSysCountEN.AttachmentCount = objRow[conSysCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.AttachmentCount].ToString().Trim()); //附件计数
objSysCountEN.CommentCount = objRow[conSysCount.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.CommentCount].ToString().Trim()); //评论数
objSysCountEN.Score = objRow[conSysCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysCount.Score].ToString().Trim()); //评分
objSysCountEN.StuScore = objRow[conSysCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysCount.StuScore].ToString().Trim()); //学生平均分
objSysCountEN.TeaScore = objRow[conSysCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysCount.TeaScore].ToString().Trim()); //教师评分
objSysCountEN.TableKey = objRow[conSysCount.TableKey] == DBNull.Value ? null : objRow[conSysCount.TableKey].ToString().Trim(); //表主键
objSysCountEN.ParentId = objRow[conSysCount.ParentId] == DBNull.Value ? null : objRow[conSysCount.ParentId].ToString().Trim(); //父Id
objSysCountEN.UpdUser = objRow[conSysCount.UpdUser] == DBNull.Value ? null : objRow[conSysCount.UpdUser].ToString().Trim(); //修改人
objSysCountEN.UpdDate = objRow[conSysCount.UpdDate] == DBNull.Value ? null : objRow[conSysCount.UpdDate].ToString().Trim(); //修改日期
objSysCountEN.Memo = objRow[conSysCount.Memo] == DBNull.Value ? null : objRow[conSysCount.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysCountEN.CountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysCountEN);
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
List<clsSysCountEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsSysCountEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsSysCountEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsSysCountEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsSysCountEN> arrObjLst = new List<clsSysCountEN>(); 
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
	clsSysCountEN objSysCountEN = new clsSysCountEN();
try
{
objSysCountEN.CountId = objRow[conSysCount.CountId].ToString().Trim(); //CountId
objSysCountEN.CountTypeId = objRow[conSysCount.CountTypeId] == DBNull.Value ? null : objRow[conSysCount.CountTypeId].ToString().Trim(); //CountTypeId
objSysCountEN.PaperRWCount = objRow[conSysCount.PaperRWCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
objSysCountEN.OkCount = objRow[conSysCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.OkCount].ToString().Trim()); //点赞统计
objSysCountEN.CollectionCount = objRow[conSysCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.CollectionCount].ToString().Trim()); //收藏数量
objSysCountEN.DownloadCount = objRow[conSysCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.DownloadCount].ToString().Trim()); //下载数
objSysCountEN.AttachmentCount = objRow[conSysCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.AttachmentCount].ToString().Trim()); //附件计数
objSysCountEN.CommentCount = objRow[conSysCount.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.CommentCount].ToString().Trim()); //评论数
objSysCountEN.Score = objRow[conSysCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysCount.Score].ToString().Trim()); //评分
objSysCountEN.StuScore = objRow[conSysCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysCount.StuScore].ToString().Trim()); //学生平均分
objSysCountEN.TeaScore = objRow[conSysCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysCount.TeaScore].ToString().Trim()); //教师评分
objSysCountEN.TableKey = objRow[conSysCount.TableKey] == DBNull.Value ? null : objRow[conSysCount.TableKey].ToString().Trim(); //表主键
objSysCountEN.ParentId = objRow[conSysCount.ParentId] == DBNull.Value ? null : objRow[conSysCount.ParentId].ToString().Trim(); //父Id
objSysCountEN.UpdUser = objRow[conSysCount.UpdUser] == DBNull.Value ? null : objRow[conSysCount.UpdUser].ToString().Trim(); //修改人
objSysCountEN.UpdDate = objRow[conSysCount.UpdDate] == DBNull.Value ? null : objRow[conSysCount.UpdDate].ToString().Trim(); //修改日期
objSysCountEN.Memo = objRow[conSysCount.Memo] == DBNull.Value ? null : objRow[conSysCount.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysCountEN.CountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysCountEN);
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
public static List<clsSysCountEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsSysCountEN> arrObjLst = new List<clsSysCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysCountEN objSysCountEN = new clsSysCountEN();
try
{
objSysCountEN.CountId = objRow[conSysCount.CountId].ToString().Trim(); //CountId
objSysCountEN.CountTypeId = objRow[conSysCount.CountTypeId] == DBNull.Value ? null : objRow[conSysCount.CountTypeId].ToString().Trim(); //CountTypeId
objSysCountEN.PaperRWCount = objRow[conSysCount.PaperRWCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
objSysCountEN.OkCount = objRow[conSysCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.OkCount].ToString().Trim()); //点赞统计
objSysCountEN.CollectionCount = objRow[conSysCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.CollectionCount].ToString().Trim()); //收藏数量
objSysCountEN.DownloadCount = objRow[conSysCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.DownloadCount].ToString().Trim()); //下载数
objSysCountEN.AttachmentCount = objRow[conSysCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.AttachmentCount].ToString().Trim()); //附件计数
objSysCountEN.CommentCount = objRow[conSysCount.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.CommentCount].ToString().Trim()); //评论数
objSysCountEN.Score = objRow[conSysCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysCount.Score].ToString().Trim()); //评分
objSysCountEN.StuScore = objRow[conSysCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysCount.StuScore].ToString().Trim()); //学生平均分
objSysCountEN.TeaScore = objRow[conSysCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysCount.TeaScore].ToString().Trim()); //教师评分
objSysCountEN.TableKey = objRow[conSysCount.TableKey] == DBNull.Value ? null : objRow[conSysCount.TableKey].ToString().Trim(); //表主键
objSysCountEN.ParentId = objRow[conSysCount.ParentId] == DBNull.Value ? null : objRow[conSysCount.ParentId].ToString().Trim(); //父Id
objSysCountEN.UpdUser = objRow[conSysCount.UpdUser] == DBNull.Value ? null : objRow[conSysCount.UpdUser].ToString().Trim(); //修改人
objSysCountEN.UpdDate = objRow[conSysCount.UpdDate] == DBNull.Value ? null : objRow[conSysCount.UpdDate].ToString().Trim(); //修改日期
objSysCountEN.Memo = objRow[conSysCount.Memo] == DBNull.Value ? null : objRow[conSysCount.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysCountEN.CountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysCountEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsSysCountEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsSysCountEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsSysCountEN> arrObjLst = new List<clsSysCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysCountEN objSysCountEN = new clsSysCountEN();
try
{
objSysCountEN.CountId = objRow[conSysCount.CountId].ToString().Trim(); //CountId
objSysCountEN.CountTypeId = objRow[conSysCount.CountTypeId] == DBNull.Value ? null : objRow[conSysCount.CountTypeId].ToString().Trim(); //CountTypeId
objSysCountEN.PaperRWCount = objRow[conSysCount.PaperRWCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
objSysCountEN.OkCount = objRow[conSysCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.OkCount].ToString().Trim()); //点赞统计
objSysCountEN.CollectionCount = objRow[conSysCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.CollectionCount].ToString().Trim()); //收藏数量
objSysCountEN.DownloadCount = objRow[conSysCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.DownloadCount].ToString().Trim()); //下载数
objSysCountEN.AttachmentCount = objRow[conSysCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.AttachmentCount].ToString().Trim()); //附件计数
objSysCountEN.CommentCount = objRow[conSysCount.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.CommentCount].ToString().Trim()); //评论数
objSysCountEN.Score = objRow[conSysCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysCount.Score].ToString().Trim()); //评分
objSysCountEN.StuScore = objRow[conSysCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysCount.StuScore].ToString().Trim()); //学生平均分
objSysCountEN.TeaScore = objRow[conSysCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysCount.TeaScore].ToString().Trim()); //教师评分
objSysCountEN.TableKey = objRow[conSysCount.TableKey] == DBNull.Value ? null : objRow[conSysCount.TableKey].ToString().Trim(); //表主键
objSysCountEN.ParentId = objRow[conSysCount.ParentId] == DBNull.Value ? null : objRow[conSysCount.ParentId].ToString().Trim(); //父Id
objSysCountEN.UpdUser = objRow[conSysCount.UpdUser] == DBNull.Value ? null : objRow[conSysCount.UpdUser].ToString().Trim(); //修改人
objSysCountEN.UpdDate = objRow[conSysCount.UpdDate] == DBNull.Value ? null : objRow[conSysCount.UpdDate].ToString().Trim(); //修改日期
objSysCountEN.Memo = objRow[conSysCount.Memo] == DBNull.Value ? null : objRow[conSysCount.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysCountEN.CountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysCountEN);
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
public static List<clsSysCountEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsSysCountEN> arrObjLst = new List<clsSysCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysCountEN objSysCountEN = new clsSysCountEN();
try
{
objSysCountEN.CountId = objRow[conSysCount.CountId].ToString().Trim(); //CountId
objSysCountEN.CountTypeId = objRow[conSysCount.CountTypeId] == DBNull.Value ? null : objRow[conSysCount.CountTypeId].ToString().Trim(); //CountTypeId
objSysCountEN.PaperRWCount = objRow[conSysCount.PaperRWCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
objSysCountEN.OkCount = objRow[conSysCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.OkCount].ToString().Trim()); //点赞统计
objSysCountEN.CollectionCount = objRow[conSysCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.CollectionCount].ToString().Trim()); //收藏数量
objSysCountEN.DownloadCount = objRow[conSysCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.DownloadCount].ToString().Trim()); //下载数
objSysCountEN.AttachmentCount = objRow[conSysCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.AttachmentCount].ToString().Trim()); //附件计数
objSysCountEN.CommentCount = objRow[conSysCount.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.CommentCount].ToString().Trim()); //评论数
objSysCountEN.Score = objRow[conSysCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysCount.Score].ToString().Trim()); //评分
objSysCountEN.StuScore = objRow[conSysCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysCount.StuScore].ToString().Trim()); //学生平均分
objSysCountEN.TeaScore = objRow[conSysCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysCount.TeaScore].ToString().Trim()); //教师评分
objSysCountEN.TableKey = objRow[conSysCount.TableKey] == DBNull.Value ? null : objRow[conSysCount.TableKey].ToString().Trim(); //表主键
objSysCountEN.ParentId = objRow[conSysCount.ParentId] == DBNull.Value ? null : objRow[conSysCount.ParentId].ToString().Trim(); //父Id
objSysCountEN.UpdUser = objRow[conSysCount.UpdUser] == DBNull.Value ? null : objRow[conSysCount.UpdUser].ToString().Trim(); //修改人
objSysCountEN.UpdDate = objRow[conSysCount.UpdDate] == DBNull.Value ? null : objRow[conSysCount.UpdDate].ToString().Trim(); //修改日期
objSysCountEN.Memo = objRow[conSysCount.Memo] == DBNull.Value ? null : objRow[conSysCount.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysCountEN.CountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysCountEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsSysCountEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsSysCountEN> arrObjLst = new List<clsSysCountEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysCountEN objSysCountEN = new clsSysCountEN();
try
{
objSysCountEN.CountId = objRow[conSysCount.CountId].ToString().Trim(); //CountId
objSysCountEN.CountTypeId = objRow[conSysCount.CountTypeId] == DBNull.Value ? null : objRow[conSysCount.CountTypeId].ToString().Trim(); //CountTypeId
objSysCountEN.PaperRWCount = objRow[conSysCount.PaperRWCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
objSysCountEN.OkCount = objRow[conSysCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.OkCount].ToString().Trim()); //点赞统计
objSysCountEN.CollectionCount = objRow[conSysCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.CollectionCount].ToString().Trim()); //收藏数量
objSysCountEN.DownloadCount = objRow[conSysCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.DownloadCount].ToString().Trim()); //下载数
objSysCountEN.AttachmentCount = objRow[conSysCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.AttachmentCount].ToString().Trim()); //附件计数
objSysCountEN.CommentCount = objRow[conSysCount.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysCount.CommentCount].ToString().Trim()); //评论数
objSysCountEN.Score = objRow[conSysCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysCount.Score].ToString().Trim()); //评分
objSysCountEN.StuScore = objRow[conSysCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysCount.StuScore].ToString().Trim()); //学生平均分
objSysCountEN.TeaScore = objRow[conSysCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysCount.TeaScore].ToString().Trim()); //教师评分
objSysCountEN.TableKey = objRow[conSysCount.TableKey] == DBNull.Value ? null : objRow[conSysCount.TableKey].ToString().Trim(); //表主键
objSysCountEN.ParentId = objRow[conSysCount.ParentId] == DBNull.Value ? null : objRow[conSysCount.ParentId].ToString().Trim(); //父Id
objSysCountEN.UpdUser = objRow[conSysCount.UpdUser] == DBNull.Value ? null : objRow[conSysCount.UpdUser].ToString().Trim(); //修改人
objSysCountEN.UpdDate = objRow[conSysCount.UpdDate] == DBNull.Value ? null : objRow[conSysCount.UpdDate].ToString().Trim(); //修改日期
objSysCountEN.Memo = objRow[conSysCount.Memo] == DBNull.Value ? null : objRow[conSysCount.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysCountEN.CountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysCountEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objSysCountEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetSysCount(ref clsSysCountEN objSysCountEN)
{
bool bolResult = SysCountDA.GetSysCount(ref objSysCountEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strCountId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSysCountEN GetObjByCountId(string strCountId)
{
if (strCountId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strCountId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strCountId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strCountId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsSysCountEN objSysCountEN = SysCountDA.GetObjByCountId(strCountId);
return objSysCountEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsSysCountEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsSysCountEN objSysCountEN = SysCountDA.GetFirstObj(strWhereCond);
 return objSysCountEN;
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
public static clsSysCountEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsSysCountEN objSysCountEN = SysCountDA.GetObjByDataRow(objRow);
 return objSysCountEN;
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
public static clsSysCountEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsSysCountEN objSysCountEN = SysCountDA.GetObjByDataRow(objRow);
 return objSysCountEN;
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
 /// <param name = "strCountId">所给的关键字</param>
 /// <param name = "lstSysCountObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSysCountEN GetObjByCountIdFromList(string strCountId, List<clsSysCountEN> lstSysCountObjLst)
{
foreach (clsSysCountEN objSysCountEN in lstSysCountObjLst)
{
if (objSysCountEN.CountId == strCountId)
{
return objSysCountEN;
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
 string strMaxCountId;
 try
 {
 strMaxCountId = clsSysCountDA.GetMaxStrId();
 return strMaxCountId;
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
 string strCountId;
 try
 {
 strCountId = new clsSysCountDA().GetFirstID(strWhereCond);
 return strCountId;
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
 arrList = SysCountDA.GetID(strWhereCond);
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
bool bolIsExist = SysCountDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strCountId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strCountId)
{
if (string.IsNullOrEmpty(strCountId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strCountId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = SysCountDA.IsExist(strCountId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strCountId">CountId</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strCountId, string strOpUser)
{
clsSysCountEN objSysCountEN = clsSysCountBL.GetObjByCountId(strCountId);
objSysCountEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
return clsSysCountBL.UpdateBySql2(objSysCountEN);
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
 bolIsExist = clsSysCountDA.IsExistTable();
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
 bolIsExist = SysCountDA.IsExistTable(strTabName);
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
 /// <param name = "objSysCountEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsSysCountEN objSysCountEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objSysCountEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!CountTypeId = [{0}],表主键 = [{1}]的数据已经存在!(in clsSysCountBL.AddNewRecordBySql2)", objSysCountEN.CountTypeId,objSysCountEN.TableKey);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSysCountEN.CountId) == true || clsSysCountBL.IsExist(objSysCountEN.CountId) == true)
 {
     objSysCountEN.CountId = clsSysCountBL.GetMaxStrId_S();
 }
bool bolResult = SysCountDA.AddNewRecordBySQL2(objSysCountEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysCountBL.ReFreshCache();

if (clsSysCountBL.relatedActions != null)
{
clsSysCountBL.relatedActions.UpdRelaTabDate(objSysCountEN.CountId, "SetUpdDate");
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
 /// <param name = "objSysCountEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsSysCountEN objSysCountEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objSysCountEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!CountTypeId = [{0}],表主键 = [{1}]的数据已经存在!(in clsSysCountBL.AddNewRecordBySql2WithReturnKey)", objSysCountEN.CountTypeId,objSysCountEN.TableKey);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSysCountEN.CountId) == true || clsSysCountBL.IsExist(objSysCountEN.CountId) == true)
 {
     objSysCountEN.CountId = clsSysCountBL.GetMaxStrId_S();
 }
string strKey = SysCountDA.AddNewRecordBySQL2WithReturnKey(objSysCountEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysCountBL.ReFreshCache();

if (clsSysCountBL.relatedActions != null)
{
clsSysCountBL.relatedActions.UpdRelaTabDate(objSysCountEN.CountId, "SetUpdDate");
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
 /// <param name = "objSysCountEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsSysCountEN objSysCountEN)
{
try
{
bool bolResult = SysCountDA.Update(objSysCountEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysCountBL.ReFreshCache();

if (clsSysCountBL.relatedActions != null)
{
clsSysCountBL.relatedActions.UpdRelaTabDate(objSysCountEN.CountId, "SetUpdDate");
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
 /// <param name = "objSysCountEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsSysCountEN objSysCountEN)
{
 if (string.IsNullOrEmpty(objSysCountEN.CountId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = SysCountDA.UpdateBySql2(objSysCountEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysCountBL.ReFreshCache();

if (clsSysCountBL.relatedActions != null)
{
clsSysCountBL.relatedActions.UpdRelaTabDate(objSysCountEN.CountId, "SetUpdDate");
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
 /// <param name = "strCountId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strCountId)
{
try
{
 clsSysCountEN objSysCountEN = clsSysCountBL.GetObjByCountId(strCountId);

if (clsSysCountBL.relatedActions != null)
{
clsSysCountBL.relatedActions.UpdRelaTabDate(objSysCountEN.CountId, "SetUpdDate");
}
if (objSysCountEN != null)
{
int intRecNum = SysCountDA.DelRecord(strCountId);
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
/// <param name="strCountId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strCountId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSysCountDA.GetSpecSQLObj();
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
//删除与表:[SysCount]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conSysCount.CountId,
//strCountId);
//        clsSysCountBL.DelSysCountsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSysCountBL.DelRecord(strCountId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSysCountBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strCountId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strCountId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strCountId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsSysCountBL.relatedActions != null)
{
clsSysCountBL.relatedActions.UpdRelaTabDate(strCountId, "UpdRelaTabDate");
}
bool bolResult = SysCountDA.DelRecord(strCountId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrCountIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelSysCounts(List<string> arrCountIdLst)
{
if (arrCountIdLst.Count == 0) return 0;
try
{
if (clsSysCountBL.relatedActions != null)
{
foreach (var strCountId in arrCountIdLst)
{
clsSysCountBL.relatedActions.UpdRelaTabDate(strCountId, "UpdRelaTabDate");
}
}
int intDelRecNum = SysCountDA.DelSysCount(arrCountIdLst);
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
public static int DelSysCountsByCond(string strWhereCond)
{
try
{
if (clsSysCountBL.relatedActions != null)
{
List<string> arrCountId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strCountId in arrCountId)
{
clsSysCountBL.relatedActions.UpdRelaTabDate(strCountId, "UpdRelaTabDate");
}
}
int intRecNum = SysCountDA.DelSysCount(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[SysCount]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strCountId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strCountId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSysCountDA.GetSpecSQLObj();
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
//删除与表:[SysCount]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSysCountBL.DelRecord(strCountId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSysCountBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strCountId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objSysCountENS">源对象</param>
 /// <param name = "objSysCountENT">目标对象</param>
 public static void CopyTo(clsSysCountEN objSysCountENS, clsSysCountEN objSysCountENT)
{
try
{
objSysCountENT.CountId = objSysCountENS.CountId; //CountId
objSysCountENT.CountTypeId = objSysCountENS.CountTypeId; //CountTypeId
objSysCountENT.PaperRWCount = objSysCountENS.PaperRWCount; //PaperRWCount
objSysCountENT.OkCount = objSysCountENS.OkCount; //点赞统计
objSysCountENT.CollectionCount = objSysCountENS.CollectionCount; //收藏数量
objSysCountENT.DownloadCount = objSysCountENS.DownloadCount; //下载数
objSysCountENT.AttachmentCount = objSysCountENS.AttachmentCount; //附件计数
objSysCountENT.CommentCount = objSysCountENS.CommentCount; //评论数
objSysCountENT.Score = objSysCountENS.Score; //评分
objSysCountENT.StuScore = objSysCountENS.StuScore; //学生平均分
objSysCountENT.TeaScore = objSysCountENS.TeaScore; //教师评分
objSysCountENT.TableKey = objSysCountENS.TableKey; //表主键
objSysCountENT.ParentId = objSysCountENS.ParentId; //父Id
objSysCountENT.UpdUser = objSysCountENS.UpdUser; //修改人
objSysCountENT.UpdDate = objSysCountENS.UpdDate; //修改日期
objSysCountENT.Memo = objSysCountENS.Memo; //备注
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
 /// <param name = "objSysCountEN">源简化对象</param>
 public static void SetUpdFlag(clsSysCountEN objSysCountEN)
{
try
{
objSysCountEN.ClearUpdateState();
   string strsfUpdFldSetStr = objSysCountEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conSysCount.CountId, new clsStrCompareIgnoreCase())  ==  true)
{
objSysCountEN.CountId = objSysCountEN.CountId; //CountId
}
if (arrFldSet.Contains(conSysCount.CountTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objSysCountEN.CountTypeId = objSysCountEN.CountTypeId == "[null]" ? null :  objSysCountEN.CountTypeId; //CountTypeId
}
if (arrFldSet.Contains(conSysCount.PaperRWCount, new clsStrCompareIgnoreCase())  ==  true)
{
objSysCountEN.PaperRWCount = objSysCountEN.PaperRWCount; //PaperRWCount
}
if (arrFldSet.Contains(conSysCount.OkCount, new clsStrCompareIgnoreCase())  ==  true)
{
objSysCountEN.OkCount = objSysCountEN.OkCount; //点赞统计
}
if (arrFldSet.Contains(conSysCount.CollectionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objSysCountEN.CollectionCount = objSysCountEN.CollectionCount; //收藏数量
}
if (arrFldSet.Contains(conSysCount.DownloadCount, new clsStrCompareIgnoreCase())  ==  true)
{
objSysCountEN.DownloadCount = objSysCountEN.DownloadCount; //下载数
}
if (arrFldSet.Contains(conSysCount.AttachmentCount, new clsStrCompareIgnoreCase())  ==  true)
{
objSysCountEN.AttachmentCount = objSysCountEN.AttachmentCount; //附件计数
}
if (arrFldSet.Contains(conSysCount.CommentCount, new clsStrCompareIgnoreCase())  ==  true)
{
objSysCountEN.CommentCount = objSysCountEN.CommentCount; //评论数
}
if (arrFldSet.Contains(conSysCount.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objSysCountEN.Score = objSysCountEN.Score; //评分
}
if (arrFldSet.Contains(conSysCount.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objSysCountEN.StuScore = objSysCountEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(conSysCount.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objSysCountEN.TeaScore = objSysCountEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(conSysCount.TableKey, new clsStrCompareIgnoreCase())  ==  true)
{
objSysCountEN.TableKey = objSysCountEN.TableKey == "[null]" ? null :  objSysCountEN.TableKey; //表主键
}
if (arrFldSet.Contains(conSysCount.ParentId, new clsStrCompareIgnoreCase())  ==  true)
{
objSysCountEN.ParentId = objSysCountEN.ParentId == "[null]" ? null :  objSysCountEN.ParentId; //父Id
}
if (arrFldSet.Contains(conSysCount.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objSysCountEN.UpdUser = objSysCountEN.UpdUser == "[null]" ? null :  objSysCountEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conSysCount.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objSysCountEN.UpdDate = objSysCountEN.UpdDate == "[null]" ? null :  objSysCountEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conSysCount.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objSysCountEN.Memo = objSysCountEN.Memo == "[null]" ? null :  objSysCountEN.Memo; //备注
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
 /// <param name = "objSysCountEN">源简化对象</param>
 public static void AccessFldValueNull(clsSysCountEN objSysCountEN)
{
try
{
if (objSysCountEN.CountTypeId == "[null]") objSysCountEN.CountTypeId = null; //CountTypeId
if (objSysCountEN.TableKey == "[null]") objSysCountEN.TableKey = null; //表主键
if (objSysCountEN.ParentId == "[null]") objSysCountEN.ParentId = null; //父Id
if (objSysCountEN.UpdUser == "[null]") objSysCountEN.UpdUser = null; //修改人
if (objSysCountEN.UpdDate == "[null]") objSysCountEN.UpdDate = null; //修改日期
if (objSysCountEN.Memo == "[null]") objSysCountEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsSysCountEN objSysCountEN)
{
 SysCountDA.CheckPropertyNew(objSysCountEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsSysCountEN objSysCountEN)
{
 SysCountDA.CheckProperty4Condition(objSysCountEN);
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
if (clsSysCountBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSysCountBL没有刷新缓存机制(clsSysCountBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by CountId");
//if (arrSysCountObjLstCache == null)
//{
//arrSysCountObjLstCache = SysCountDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strCountId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSysCountEN GetObjByCountIdCache(string strCountId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsSysCountEN._CurrTabName);
List<clsSysCountEN> arrSysCountObjLstCache = GetObjLstCache();
IEnumerable <clsSysCountEN> arrSysCountObjLst_Sel =
arrSysCountObjLstCache
.Where(x=> x.CountId == strCountId 
);
if (arrSysCountObjLst_Sel.Count() == 0)
{
   clsSysCountEN obj = clsSysCountBL.GetObjByCountId(strCountId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrSysCountObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSysCountEN> GetAllSysCountObjLstCache()
{
//获取缓存中的对象列表
List<clsSysCountEN> arrSysCountObjLstCache = GetObjLstCache(); 
return arrSysCountObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSysCountEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsSysCountEN._CurrTabName);
List<clsSysCountEN> arrSysCountObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrSysCountObjLstCache;
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
string strKey = string.Format("{0}", clsSysCountEN._CurrTabName);
CacheHelper.Remove(strKey);
clsSysCountEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsSysCountEN._RefreshTimeLst.Count == 0) return "";
return clsSysCountEN._RefreshTimeLst[clsSysCountEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsSysCountBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsSysCountEN._CurrTabName);
CacheHelper.Remove(strKey);
clsSysCountEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsSysCountBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--SysCount(统计数据)
 /// 唯一性条件:CountTypeId_TableKey
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objSysCountEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsSysCountEN objSysCountEN)
{
//检测记录是否存在
string strResult = SysCountDA.GetUniCondStr(objSysCountEN);
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
public static string Func(string strInFldName, string strOutFldName, string strCountId)
{
if (strInFldName != conSysCount.CountId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conSysCount.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conSysCount.AttributeName));
throw new Exception(strMsg);
}
var objSysCount = clsSysCountBL.GetObjByCountIdCache(strCountId);
if (objSysCount == null) return "";
return objSysCount[strOutFldName].ToString();
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
int intRecCount = clsSysCountDA.GetRecCount(strTabName);
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
int intRecCount = clsSysCountDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsSysCountDA.GetRecCount();
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
int intRecCount = clsSysCountDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objSysCountCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsSysCountEN objSysCountCond)
{
List<clsSysCountEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsSysCountEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSysCount.AttributeName)
{
if (objSysCountCond.IsUpdated(strFldName) == false) continue;
if (objSysCountCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSysCountCond[strFldName].ToString());
}
else
{
if (objSysCountCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSysCountCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSysCountCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSysCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSysCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSysCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSysCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSysCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSysCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSysCountCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSysCountCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSysCountCond[strFldName]));
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
 List<string> arrList = clsSysCountDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = SysCountDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = SysCountDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = SysCountDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsSysCountDA.SetFldValue(clsSysCountEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = SysCountDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsSysCountDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsSysCountDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsSysCountDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[SysCount] "); 
 strCreateTabCode.Append(" ( "); 
 // /**CountId*/ 
 strCreateTabCode.Append(" CountId char(10) primary key, "); 
 // /**CountTypeId*/ 
 strCreateTabCode.Append(" CountTypeId char(2) Null, "); 
 // /**PaperRWCount*/ 
 strCreateTabCode.Append(" PaperRWCount int Null, "); 
 // /**点赞统计*/ 
 strCreateTabCode.Append(" OkCount int Null, "); 
 // /**收藏数量*/ 
 strCreateTabCode.Append(" CollectionCount bigint Null, "); 
 // /**下载数*/ 
 strCreateTabCode.Append(" DownloadCount int Null, "); 
 // /**附件计数*/ 
 strCreateTabCode.Append(" AttachmentCount int Null, "); 
 // /**评论数*/ 
 strCreateTabCode.Append(" CommentCount int Null, "); 
 // /**评分*/ 
 strCreateTabCode.Append(" Score float Null, "); 
 // /**学生平均分*/ 
 strCreateTabCode.Append(" StuScore float Null, "); 
 // /**教师评分*/ 
 strCreateTabCode.Append(" TeaScore float Null, "); 
 // /**表主键*/ 
 strCreateTabCode.Append(" TableKey varchar(20) Null, "); 
 // /**父Id*/ 
 strCreateTabCode.Append(" ParentId varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
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
 /// 统计数据(SysCount)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4SysCount : clsCommFun4BL
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
clsSysCountBL.ReFreshThisCache();
}
}

}