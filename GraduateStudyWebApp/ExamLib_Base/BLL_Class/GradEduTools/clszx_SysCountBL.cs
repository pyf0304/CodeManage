
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_SysCountBL
 表名:zx_SysCount(01120797)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:53:24
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培设置(GradEduTools)
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
public static class  clszx_SysCountBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strzxCountId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_SysCountEN GetObj(this K_zxCountId_zx_SysCount myKey)
{
clszx_SysCountEN objzx_SysCountEN = clszx_SysCountBL.zx_SysCountDA.GetObjByzxCountId(myKey.Value);
return objzx_SysCountEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objzx_SysCountEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clszx_SysCountEN objzx_SysCountEN)
{
 if (string.IsNullOrEmpty(objzx_SysCountEN.zxCountId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clszx_SysCountBL.IsExist(objzx_SysCountEN.zxCountId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objzx_SysCountEN.zxCountId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clszx_SysCountBL.zx_SysCountDA.AddNewRecordBySQL2(objzx_SysCountEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SysCountBL.ReFreshCache();

if (clszx_SysCountBL.relatedActions != null)
{
clszx_SysCountBL.relatedActions.UpdRelaTabDate(objzx_SysCountEN.zxCountId, "SetUpdDate");
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
public static bool AddRecordEx(this clszx_SysCountEN objzx_SysCountEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clszx_SysCountBL.IsExist(objzx_SysCountEN.zxCountId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objzx_SysCountEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objzx_SysCountEN.AddNewRecord();
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
 /// <param name = "objzx_SysCountEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clszx_SysCountEN objzx_SysCountEN)
{
 if (string.IsNullOrEmpty(objzx_SysCountEN.zxCountId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clszx_SysCountBL.IsExist(objzx_SysCountEN.zxCountId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objzx_SysCountEN.zxCountId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clszx_SysCountBL.zx_SysCountDA.AddNewRecordBySQL2WithReturnKey(objzx_SysCountEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SysCountBL.ReFreshCache();

if (clszx_SysCountBL.relatedActions != null)
{
clszx_SysCountBL.relatedActions.UpdRelaTabDate(objzx_SysCountEN.zxCountId, "SetUpdDate");
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
 /// <param name = "objzx_SysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SysCountEN SetzxCountId(this clszx_SysCountEN objzx_SysCountEN, string strzxCountId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxCountId, 10, conzx_SysCount.zxCountId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxCountId, 10, conzx_SysCount.zxCountId);
}
objzx_SysCountEN.zxCountId = strzxCountId; //CountId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SysCountEN.dicFldComparisonOp.ContainsKey(conzx_SysCount.zxCountId) == false)
{
objzx_SysCountEN.dicFldComparisonOp.Add(conzx_SysCount.zxCountId, strComparisonOp);
}
else
{
objzx_SysCountEN.dicFldComparisonOp[conzx_SysCount.zxCountId] = strComparisonOp;
}
}
return objzx_SysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SysCountEN SetCountTypeId(this clszx_SysCountEN objzx_SysCountEN, string strCountTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCountTypeId, 2, conzx_SysCount.CountTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCountTypeId, 2, conzx_SysCount.CountTypeId);
}
objzx_SysCountEN.CountTypeId = strCountTypeId; //CountTypeId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SysCountEN.dicFldComparisonOp.ContainsKey(conzx_SysCount.CountTypeId) == false)
{
objzx_SysCountEN.dicFldComparisonOp.Add(conzx_SysCount.CountTypeId, strComparisonOp);
}
else
{
objzx_SysCountEN.dicFldComparisonOp[conzx_SysCount.CountTypeId] = strComparisonOp;
}
}
return objzx_SysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SysCountEN SetPaperRWCount(this clszx_SysCountEN objzx_SysCountEN, int? intPaperRWCount, string strComparisonOp="")
	{
objzx_SysCountEN.PaperRWCount = intPaperRWCount; //PaperRWCount
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SysCountEN.dicFldComparisonOp.ContainsKey(conzx_SysCount.PaperRWCount) == false)
{
objzx_SysCountEN.dicFldComparisonOp.Add(conzx_SysCount.PaperRWCount, strComparisonOp);
}
else
{
objzx_SysCountEN.dicFldComparisonOp[conzx_SysCount.PaperRWCount] = strComparisonOp;
}
}
return objzx_SysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SysCountEN SetOkCount(this clszx_SysCountEN objzx_SysCountEN, int? intOkCount, string strComparisonOp="")
	{
objzx_SysCountEN.OkCount = intOkCount; //点赞统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SysCountEN.dicFldComparisonOp.ContainsKey(conzx_SysCount.OkCount) == false)
{
objzx_SysCountEN.dicFldComparisonOp.Add(conzx_SysCount.OkCount, strComparisonOp);
}
else
{
objzx_SysCountEN.dicFldComparisonOp[conzx_SysCount.OkCount] = strComparisonOp;
}
}
return objzx_SysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SysCountEN SetCollectionCount(this clszx_SysCountEN objzx_SysCountEN, long? lngCollectionCount, string strComparisonOp="")
	{
objzx_SysCountEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SysCountEN.dicFldComparisonOp.ContainsKey(conzx_SysCount.CollectionCount) == false)
{
objzx_SysCountEN.dicFldComparisonOp.Add(conzx_SysCount.CollectionCount, strComparisonOp);
}
else
{
objzx_SysCountEN.dicFldComparisonOp[conzx_SysCount.CollectionCount] = strComparisonOp;
}
}
return objzx_SysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SysCountEN SetDownloadCount(this clszx_SysCountEN objzx_SysCountEN, int? intDownloadCount, string strComparisonOp="")
	{
objzx_SysCountEN.DownloadCount = intDownloadCount; //下载数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SysCountEN.dicFldComparisonOp.ContainsKey(conzx_SysCount.DownloadCount) == false)
{
objzx_SysCountEN.dicFldComparisonOp.Add(conzx_SysCount.DownloadCount, strComparisonOp);
}
else
{
objzx_SysCountEN.dicFldComparisonOp[conzx_SysCount.DownloadCount] = strComparisonOp;
}
}
return objzx_SysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SysCountEN SetAttachmentCount(this clszx_SysCountEN objzx_SysCountEN, int? intAttachmentCount, string strComparisonOp="")
	{
objzx_SysCountEN.AttachmentCount = intAttachmentCount; //附件计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SysCountEN.dicFldComparisonOp.ContainsKey(conzx_SysCount.AttachmentCount) == false)
{
objzx_SysCountEN.dicFldComparisonOp.Add(conzx_SysCount.AttachmentCount, strComparisonOp);
}
else
{
objzx_SysCountEN.dicFldComparisonOp[conzx_SysCount.AttachmentCount] = strComparisonOp;
}
}
return objzx_SysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SysCountEN SetCommentCount(this clszx_SysCountEN objzx_SysCountEN, int? intCommentCount, string strComparisonOp="")
	{
objzx_SysCountEN.CommentCount = intCommentCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SysCountEN.dicFldComparisonOp.ContainsKey(conzx_SysCount.CommentCount) == false)
{
objzx_SysCountEN.dicFldComparisonOp.Add(conzx_SysCount.CommentCount, strComparisonOp);
}
else
{
objzx_SysCountEN.dicFldComparisonOp[conzx_SysCount.CommentCount] = strComparisonOp;
}
}
return objzx_SysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SysCountEN SetScore(this clszx_SysCountEN objzx_SysCountEN, float? fltScore, string strComparisonOp="")
	{
objzx_SysCountEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SysCountEN.dicFldComparisonOp.ContainsKey(conzx_SysCount.Score) == false)
{
objzx_SysCountEN.dicFldComparisonOp.Add(conzx_SysCount.Score, strComparisonOp);
}
else
{
objzx_SysCountEN.dicFldComparisonOp[conzx_SysCount.Score] = strComparisonOp;
}
}
return objzx_SysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SysCountEN SetStuScore(this clszx_SysCountEN objzx_SysCountEN, float? fltStuScore, string strComparisonOp="")
	{
objzx_SysCountEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SysCountEN.dicFldComparisonOp.ContainsKey(conzx_SysCount.StuScore) == false)
{
objzx_SysCountEN.dicFldComparisonOp.Add(conzx_SysCount.StuScore, strComparisonOp);
}
else
{
objzx_SysCountEN.dicFldComparisonOp[conzx_SysCount.StuScore] = strComparisonOp;
}
}
return objzx_SysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SysCountEN SetTeaScore(this clszx_SysCountEN objzx_SysCountEN, float? fltTeaScore, string strComparisonOp="")
	{
objzx_SysCountEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SysCountEN.dicFldComparisonOp.ContainsKey(conzx_SysCount.TeaScore) == false)
{
objzx_SysCountEN.dicFldComparisonOp.Add(conzx_SysCount.TeaScore, strComparisonOp);
}
else
{
objzx_SysCountEN.dicFldComparisonOp[conzx_SysCount.TeaScore] = strComparisonOp;
}
}
return objzx_SysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SysCountEN SetTableKey(this clszx_SysCountEN objzx_SysCountEN, string strTableKey, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTableKey, 20, conzx_SysCount.TableKey);
}
objzx_SysCountEN.TableKey = strTableKey; //表主键
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SysCountEN.dicFldComparisonOp.ContainsKey(conzx_SysCount.TableKey) == false)
{
objzx_SysCountEN.dicFldComparisonOp.Add(conzx_SysCount.TableKey, strComparisonOp);
}
else
{
objzx_SysCountEN.dicFldComparisonOp[conzx_SysCount.TableKey] = strComparisonOp;
}
}
return objzx_SysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SysCountEN SetParentId(this clszx_SysCountEN objzx_SysCountEN, string strParentId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentId, 20, conzx_SysCount.ParentId);
}
objzx_SysCountEN.ParentId = strParentId; //父Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SysCountEN.dicFldComparisonOp.ContainsKey(conzx_SysCount.ParentId) == false)
{
objzx_SysCountEN.dicFldComparisonOp.Add(conzx_SysCount.ParentId, strComparisonOp);
}
else
{
objzx_SysCountEN.dicFldComparisonOp[conzx_SysCount.ParentId] = strComparisonOp;
}
}
return objzx_SysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SysCountEN SetUpdUser(this clszx_SysCountEN objzx_SysCountEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conzx_SysCount.UpdUser);
}
objzx_SysCountEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SysCountEN.dicFldComparisonOp.ContainsKey(conzx_SysCount.UpdUser) == false)
{
objzx_SysCountEN.dicFldComparisonOp.Add(conzx_SysCount.UpdUser, strComparisonOp);
}
else
{
objzx_SysCountEN.dicFldComparisonOp[conzx_SysCount.UpdUser] = strComparisonOp;
}
}
return objzx_SysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SysCountEN SetUpdDate(this clszx_SysCountEN objzx_SysCountEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conzx_SysCount.UpdDate);
}
objzx_SysCountEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SysCountEN.dicFldComparisonOp.ContainsKey(conzx_SysCount.UpdDate) == false)
{
objzx_SysCountEN.dicFldComparisonOp.Add(conzx_SysCount.UpdDate, strComparisonOp);
}
else
{
objzx_SysCountEN.dicFldComparisonOp[conzx_SysCount.UpdDate] = strComparisonOp;
}
}
return objzx_SysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SysCountEN SetMemo(this clszx_SysCountEN objzx_SysCountEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conzx_SysCount.Memo);
}
objzx_SysCountEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SysCountEN.dicFldComparisonOp.ContainsKey(conzx_SysCount.Memo) == false)
{
objzx_SysCountEN.dicFldComparisonOp.Add(conzx_SysCount.Memo, strComparisonOp);
}
else
{
objzx_SysCountEN.dicFldComparisonOp[conzx_SysCount.Memo] = strComparisonOp;
}
}
return objzx_SysCountEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objzx_SysCountEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clszx_SysCountEN objzx_SysCountEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objzx_SysCountEN.CheckPropertyNew();
clszx_SysCountEN objzx_SysCountCond = new clszx_SysCountEN();
string strCondition = objzx_SysCountCond
.SetzxCountId(objzx_SysCountEN.zxCountId, "=")
.GetCombineCondition();
objzx_SysCountEN._IsCheckProperty = true;
bool bolIsExist = clszx_SysCountBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objzx_SysCountEN.Update();
}
catch(Exception objException)
{
strMsg = "修改记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objzx_SysCountEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_SysCountEN objzx_SysCountEN)
{
 if (string.IsNullOrEmpty(objzx_SysCountEN.zxCountId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_SysCountBL.zx_SysCountDA.UpdateBySql2(objzx_SysCountEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SysCountBL.ReFreshCache();

if (clszx_SysCountBL.relatedActions != null)
{
clszx_SysCountBL.relatedActions.UpdRelaTabDate(objzx_SysCountEN.zxCountId, "SetUpdDate");
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
 /// <param name = "objzx_SysCountEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_SysCountEN objzx_SysCountEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objzx_SysCountEN.zxCountId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_SysCountBL.zx_SysCountDA.UpdateBySql2(objzx_SysCountEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SysCountBL.ReFreshCache();

if (clszx_SysCountBL.relatedActions != null)
{
clszx_SysCountBL.relatedActions.UpdRelaTabDate(objzx_SysCountEN.zxCountId, "SetUpdDate");
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
 /// <param name = "objzx_SysCountEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_SysCountEN objzx_SysCountEN, string strWhereCond)
{
try
{
bool bolResult = clszx_SysCountBL.zx_SysCountDA.UpdateBySqlWithCondition(objzx_SysCountEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SysCountBL.ReFreshCache();

if (clszx_SysCountBL.relatedActions != null)
{
clszx_SysCountBL.relatedActions.UpdRelaTabDate(objzx_SysCountEN.zxCountId, "SetUpdDate");
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
 /// <param name = "objzx_SysCountEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_SysCountEN objzx_SysCountEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clszx_SysCountBL.zx_SysCountDA.UpdateBySqlWithConditionTransaction(objzx_SysCountEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SysCountBL.ReFreshCache();

if (clszx_SysCountBL.relatedActions != null)
{
clszx_SysCountBL.relatedActions.UpdRelaTabDate(objzx_SysCountEN.zxCountId, "SetUpdDate");
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
 /// <param name = "strzxCountId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clszx_SysCountEN objzx_SysCountEN)
{
try
{
int intRecNum = clszx_SysCountBL.zx_SysCountDA.DelRecord(objzx_SysCountEN.zxCountId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SysCountBL.ReFreshCache();

if (clszx_SysCountBL.relatedActions != null)
{
clszx_SysCountBL.relatedActions.UpdRelaTabDate(objzx_SysCountEN.zxCountId, "SetUpdDate");
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
 /// <param name = "objzx_SysCountENS">源对象</param>
 /// <param name = "objzx_SysCountENT">目标对象</param>
 public static void CopyTo(this clszx_SysCountEN objzx_SysCountENS, clszx_SysCountEN objzx_SysCountENT)
{
try
{
objzx_SysCountENT.zxCountId = objzx_SysCountENS.zxCountId; //CountId
objzx_SysCountENT.CountTypeId = objzx_SysCountENS.CountTypeId; //CountTypeId
objzx_SysCountENT.PaperRWCount = objzx_SysCountENS.PaperRWCount; //PaperRWCount
objzx_SysCountENT.OkCount = objzx_SysCountENS.OkCount; //点赞统计
objzx_SysCountENT.CollectionCount = objzx_SysCountENS.CollectionCount; //收藏数量
objzx_SysCountENT.DownloadCount = objzx_SysCountENS.DownloadCount; //下载数
objzx_SysCountENT.AttachmentCount = objzx_SysCountENS.AttachmentCount; //附件计数
objzx_SysCountENT.CommentCount = objzx_SysCountENS.CommentCount; //评论数
objzx_SysCountENT.Score = objzx_SysCountENS.Score; //评分
objzx_SysCountENT.StuScore = objzx_SysCountENS.StuScore; //学生平均分
objzx_SysCountENT.TeaScore = objzx_SysCountENS.TeaScore; //教师评分
objzx_SysCountENT.TableKey = objzx_SysCountENS.TableKey; //表主键
objzx_SysCountENT.ParentId = objzx_SysCountENS.ParentId; //父Id
objzx_SysCountENT.UpdUser = objzx_SysCountENS.UpdUser; //修改人
objzx_SysCountENT.UpdDate = objzx_SysCountENS.UpdDate; //修改日期
objzx_SysCountENT.Memo = objzx_SysCountENS.Memo; //备注
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
 /// <param name = "objzx_SysCountENS">源对象</param>
 /// <returns>目标对象=>clszx_SysCountEN:objzx_SysCountENT</returns>
 public static clszx_SysCountEN CopyTo(this clszx_SysCountEN objzx_SysCountENS)
{
try
{
 clszx_SysCountEN objzx_SysCountENT = new clszx_SysCountEN()
{
zxCountId = objzx_SysCountENS.zxCountId, //CountId
CountTypeId = objzx_SysCountENS.CountTypeId, //CountTypeId
PaperRWCount = objzx_SysCountENS.PaperRWCount, //PaperRWCount
OkCount = objzx_SysCountENS.OkCount, //点赞统计
CollectionCount = objzx_SysCountENS.CollectionCount, //收藏数量
DownloadCount = objzx_SysCountENS.DownloadCount, //下载数
AttachmentCount = objzx_SysCountENS.AttachmentCount, //附件计数
CommentCount = objzx_SysCountENS.CommentCount, //评论数
Score = objzx_SysCountENS.Score, //评分
StuScore = objzx_SysCountENS.StuScore, //学生平均分
TeaScore = objzx_SysCountENS.TeaScore, //教师评分
TableKey = objzx_SysCountENS.TableKey, //表主键
ParentId = objzx_SysCountENS.ParentId, //父Id
UpdUser = objzx_SysCountENS.UpdUser, //修改人
UpdDate = objzx_SysCountENS.UpdDate, //修改日期
Memo = objzx_SysCountENS.Memo, //备注
};
 return objzx_SysCountENT;
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
public static void CheckPropertyNew(this clszx_SysCountEN objzx_SysCountEN)
{
 clszx_SysCountBL.zx_SysCountDA.CheckPropertyNew(objzx_SysCountEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clszx_SysCountEN objzx_SysCountEN)
{
 clszx_SysCountBL.zx_SysCountDA.CheckProperty4Condition(objzx_SysCountEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clszx_SysCountEN objzx_SysCountCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objzx_SysCountCond.IsUpdated(conzx_SysCount.zxCountId) == true)
{
string strComparisonOpzxCountId = objzx_SysCountCond.dicFldComparisonOp[conzx_SysCount.zxCountId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SysCount.zxCountId, objzx_SysCountCond.zxCountId, strComparisonOpzxCountId);
}
if (objzx_SysCountCond.IsUpdated(conzx_SysCount.CountTypeId) == true)
{
string strComparisonOpCountTypeId = objzx_SysCountCond.dicFldComparisonOp[conzx_SysCount.CountTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SysCount.CountTypeId, objzx_SysCountCond.CountTypeId, strComparisonOpCountTypeId);
}
if (objzx_SysCountCond.IsUpdated(conzx_SysCount.PaperRWCount) == true)
{
string strComparisonOpPaperRWCount = objzx_SysCountCond.dicFldComparisonOp[conzx_SysCount.PaperRWCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_SysCount.PaperRWCount, objzx_SysCountCond.PaperRWCount, strComparisonOpPaperRWCount);
}
if (objzx_SysCountCond.IsUpdated(conzx_SysCount.OkCount) == true)
{
string strComparisonOpOkCount = objzx_SysCountCond.dicFldComparisonOp[conzx_SysCount.OkCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_SysCount.OkCount, objzx_SysCountCond.OkCount, strComparisonOpOkCount);
}
if (objzx_SysCountCond.IsUpdated(conzx_SysCount.CollectionCount) == true)
{
string strComparisonOpCollectionCount = objzx_SysCountCond.dicFldComparisonOp[conzx_SysCount.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_SysCount.CollectionCount, objzx_SysCountCond.CollectionCount, strComparisonOpCollectionCount);
}
if (objzx_SysCountCond.IsUpdated(conzx_SysCount.DownloadCount) == true)
{
string strComparisonOpDownloadCount = objzx_SysCountCond.dicFldComparisonOp[conzx_SysCount.DownloadCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_SysCount.DownloadCount, objzx_SysCountCond.DownloadCount, strComparisonOpDownloadCount);
}
if (objzx_SysCountCond.IsUpdated(conzx_SysCount.AttachmentCount) == true)
{
string strComparisonOpAttachmentCount = objzx_SysCountCond.dicFldComparisonOp[conzx_SysCount.AttachmentCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_SysCount.AttachmentCount, objzx_SysCountCond.AttachmentCount, strComparisonOpAttachmentCount);
}
if (objzx_SysCountCond.IsUpdated(conzx_SysCount.CommentCount) == true)
{
string strComparisonOpCommentCount = objzx_SysCountCond.dicFldComparisonOp[conzx_SysCount.CommentCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_SysCount.CommentCount, objzx_SysCountCond.CommentCount, strComparisonOpCommentCount);
}
if (objzx_SysCountCond.IsUpdated(conzx_SysCount.Score) == true)
{
string strComparisonOpScore = objzx_SysCountCond.dicFldComparisonOp[conzx_SysCount.Score];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_SysCount.Score, objzx_SysCountCond.Score, strComparisonOpScore);
}
if (objzx_SysCountCond.IsUpdated(conzx_SysCount.StuScore) == true)
{
string strComparisonOpStuScore = objzx_SysCountCond.dicFldComparisonOp[conzx_SysCount.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_SysCount.StuScore, objzx_SysCountCond.StuScore, strComparisonOpStuScore);
}
if (objzx_SysCountCond.IsUpdated(conzx_SysCount.TeaScore) == true)
{
string strComparisonOpTeaScore = objzx_SysCountCond.dicFldComparisonOp[conzx_SysCount.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_SysCount.TeaScore, objzx_SysCountCond.TeaScore, strComparisonOpTeaScore);
}
if (objzx_SysCountCond.IsUpdated(conzx_SysCount.TableKey) == true)
{
string strComparisonOpTableKey = objzx_SysCountCond.dicFldComparisonOp[conzx_SysCount.TableKey];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SysCount.TableKey, objzx_SysCountCond.TableKey, strComparisonOpTableKey);
}
if (objzx_SysCountCond.IsUpdated(conzx_SysCount.ParentId) == true)
{
string strComparisonOpParentId = objzx_SysCountCond.dicFldComparisonOp[conzx_SysCount.ParentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SysCount.ParentId, objzx_SysCountCond.ParentId, strComparisonOpParentId);
}
if (objzx_SysCountCond.IsUpdated(conzx_SysCount.UpdUser) == true)
{
string strComparisonOpUpdUser = objzx_SysCountCond.dicFldComparisonOp[conzx_SysCount.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SysCount.UpdUser, objzx_SysCountCond.UpdUser, strComparisonOpUpdUser);
}
if (objzx_SysCountCond.IsUpdated(conzx_SysCount.UpdDate) == true)
{
string strComparisonOpUpdDate = objzx_SysCountCond.dicFldComparisonOp[conzx_SysCount.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SysCount.UpdDate, objzx_SysCountCond.UpdDate, strComparisonOpUpdDate);
}
if (objzx_SysCountCond.IsUpdated(conzx_SysCount.Memo) == true)
{
string strComparisonOpMemo = objzx_SysCountCond.dicFldComparisonOp[conzx_SysCount.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SysCount.Memo, objzx_SysCountCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_zx_SysCount
{
public virtual bool UpdRelaTabDate(string strzxCountId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 中学统计数据(zx_SysCount)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clszx_SysCountBL
{
public static RelatedActions_zx_SysCount relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clszx_SysCountDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clszx_SysCountDA zx_SysCountDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clszx_SysCountDA();
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
 public clszx_SysCountBL()
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
if (string.IsNullOrEmpty(clszx_SysCountEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_SysCountEN._ConnectString);
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
public static DataTable GetDataTable_zx_SysCount(string strWhereCond)
{
DataTable objDT;
try
{
objDT = zx_SysCountDA.GetDataTable_zx_SysCount(strWhereCond);
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
objDT = zx_SysCountDA.GetDataTable(strWhereCond);
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
objDT = zx_SysCountDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = zx_SysCountDA.GetDataTable(strWhereCond, strTabName);
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
objDT = zx_SysCountDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = zx_SysCountDA.GetDataTable_Top(objTopPara);
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
objDT = zx_SysCountDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = zx_SysCountDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = zx_SysCountDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrZxCountIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clszx_SysCountEN> GetObjLstByZxCountIdLst(List<string> arrZxCountIdLst)
{
List<clszx_SysCountEN> arrObjLst = new List<clszx_SysCountEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrZxCountIdLst, true);
 string strWhereCond = string.Format("zxCountId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SysCountEN objzx_SysCountEN = new clszx_SysCountEN();
try
{
objzx_SysCountEN.zxCountId = objRow[conzx_SysCount.zxCountId].ToString().Trim(); //CountId
objzx_SysCountEN.CountTypeId = objRow[conzx_SysCount.CountTypeId] == DBNull.Value ? null : objRow[conzx_SysCount.CountTypeId].ToString().Trim(); //CountTypeId
objzx_SysCountEN.PaperRWCount = objRow[conzx_SysCount.PaperRWCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
objzx_SysCountEN.OkCount = objRow[conzx_SysCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.OkCount].ToString().Trim()); //点赞统计
objzx_SysCountEN.CollectionCount = objRow[conzx_SysCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.CollectionCount].ToString().Trim()); //收藏数量
objzx_SysCountEN.DownloadCount = objRow[conzx_SysCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.DownloadCount].ToString().Trim()); //下载数
objzx_SysCountEN.AttachmentCount = objRow[conzx_SysCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.AttachmentCount].ToString().Trim()); //附件计数
objzx_SysCountEN.CommentCount = objRow[conzx_SysCount.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.CommentCount].ToString().Trim()); //评论数
objzx_SysCountEN.Score = objRow[conzx_SysCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SysCount.Score].ToString().Trim()); //评分
objzx_SysCountEN.StuScore = objRow[conzx_SysCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SysCount.StuScore].ToString().Trim()); //学生平均分
objzx_SysCountEN.TeaScore = objRow[conzx_SysCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SysCount.TeaScore].ToString().Trim()); //教师评分
objzx_SysCountEN.TableKey = objRow[conzx_SysCount.TableKey] == DBNull.Value ? null : objRow[conzx_SysCount.TableKey].ToString().Trim(); //表主键
objzx_SysCountEN.ParentId = objRow[conzx_SysCount.ParentId] == DBNull.Value ? null : objRow[conzx_SysCount.ParentId].ToString().Trim(); //父Id
objzx_SysCountEN.UpdUser = objRow[conzx_SysCount.UpdUser] == DBNull.Value ? null : objRow[conzx_SysCount.UpdUser].ToString().Trim(); //修改人
objzx_SysCountEN.UpdDate = objRow[conzx_SysCount.UpdDate] == DBNull.Value ? null : objRow[conzx_SysCount.UpdDate].ToString().Trim(); //修改日期
objzx_SysCountEN.Memo = objRow[conzx_SysCount.Memo] == DBNull.Value ? null : objRow[conzx_SysCount.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SysCountEN.zxCountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SysCountEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrZxCountIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clszx_SysCountEN> GetObjLstByZxCountIdLstCache(List<string> arrZxCountIdLst)
{
string strKey = string.Format("{0}", clszx_SysCountEN._CurrTabName);
List<clszx_SysCountEN> arrzx_SysCountObjLstCache = GetObjLstCache();
IEnumerable <clszx_SysCountEN> arrzx_SysCountObjLst_Sel =
arrzx_SysCountObjLstCache
.Where(x => arrZxCountIdLst.Contains(x.zxCountId));
return arrzx_SysCountObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_SysCountEN> GetObjLst(string strWhereCond)
{
List<clszx_SysCountEN> arrObjLst = new List<clszx_SysCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SysCountEN objzx_SysCountEN = new clszx_SysCountEN();
try
{
objzx_SysCountEN.zxCountId = objRow[conzx_SysCount.zxCountId].ToString().Trim(); //CountId
objzx_SysCountEN.CountTypeId = objRow[conzx_SysCount.CountTypeId] == DBNull.Value ? null : objRow[conzx_SysCount.CountTypeId].ToString().Trim(); //CountTypeId
objzx_SysCountEN.PaperRWCount = objRow[conzx_SysCount.PaperRWCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
objzx_SysCountEN.OkCount = objRow[conzx_SysCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.OkCount].ToString().Trim()); //点赞统计
objzx_SysCountEN.CollectionCount = objRow[conzx_SysCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.CollectionCount].ToString().Trim()); //收藏数量
objzx_SysCountEN.DownloadCount = objRow[conzx_SysCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.DownloadCount].ToString().Trim()); //下载数
objzx_SysCountEN.AttachmentCount = objRow[conzx_SysCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.AttachmentCount].ToString().Trim()); //附件计数
objzx_SysCountEN.CommentCount = objRow[conzx_SysCount.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.CommentCount].ToString().Trim()); //评论数
objzx_SysCountEN.Score = objRow[conzx_SysCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SysCount.Score].ToString().Trim()); //评分
objzx_SysCountEN.StuScore = objRow[conzx_SysCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SysCount.StuScore].ToString().Trim()); //学生平均分
objzx_SysCountEN.TeaScore = objRow[conzx_SysCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SysCount.TeaScore].ToString().Trim()); //教师评分
objzx_SysCountEN.TableKey = objRow[conzx_SysCount.TableKey] == DBNull.Value ? null : objRow[conzx_SysCount.TableKey].ToString().Trim(); //表主键
objzx_SysCountEN.ParentId = objRow[conzx_SysCount.ParentId] == DBNull.Value ? null : objRow[conzx_SysCount.ParentId].ToString().Trim(); //父Id
objzx_SysCountEN.UpdUser = objRow[conzx_SysCount.UpdUser] == DBNull.Value ? null : objRow[conzx_SysCount.UpdUser].ToString().Trim(); //修改人
objzx_SysCountEN.UpdDate = objRow[conzx_SysCount.UpdDate] == DBNull.Value ? null : objRow[conzx_SysCount.UpdDate].ToString().Trim(); //修改日期
objzx_SysCountEN.Memo = objRow[conzx_SysCount.Memo] == DBNull.Value ? null : objRow[conzx_SysCount.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SysCountEN.zxCountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SysCountEN);
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
public static List<clszx_SysCountEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clszx_SysCountEN> arrObjLst = new List<clszx_SysCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SysCountEN objzx_SysCountEN = new clszx_SysCountEN();
try
{
objzx_SysCountEN.zxCountId = objRow[conzx_SysCount.zxCountId].ToString().Trim(); //CountId
objzx_SysCountEN.CountTypeId = objRow[conzx_SysCount.CountTypeId] == DBNull.Value ? null : objRow[conzx_SysCount.CountTypeId].ToString().Trim(); //CountTypeId
objzx_SysCountEN.PaperRWCount = objRow[conzx_SysCount.PaperRWCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
objzx_SysCountEN.OkCount = objRow[conzx_SysCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.OkCount].ToString().Trim()); //点赞统计
objzx_SysCountEN.CollectionCount = objRow[conzx_SysCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.CollectionCount].ToString().Trim()); //收藏数量
objzx_SysCountEN.DownloadCount = objRow[conzx_SysCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.DownloadCount].ToString().Trim()); //下载数
objzx_SysCountEN.AttachmentCount = objRow[conzx_SysCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.AttachmentCount].ToString().Trim()); //附件计数
objzx_SysCountEN.CommentCount = objRow[conzx_SysCount.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.CommentCount].ToString().Trim()); //评论数
objzx_SysCountEN.Score = objRow[conzx_SysCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SysCount.Score].ToString().Trim()); //评分
objzx_SysCountEN.StuScore = objRow[conzx_SysCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SysCount.StuScore].ToString().Trim()); //学生平均分
objzx_SysCountEN.TeaScore = objRow[conzx_SysCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SysCount.TeaScore].ToString().Trim()); //教师评分
objzx_SysCountEN.TableKey = objRow[conzx_SysCount.TableKey] == DBNull.Value ? null : objRow[conzx_SysCount.TableKey].ToString().Trim(); //表主键
objzx_SysCountEN.ParentId = objRow[conzx_SysCount.ParentId] == DBNull.Value ? null : objRow[conzx_SysCount.ParentId].ToString().Trim(); //父Id
objzx_SysCountEN.UpdUser = objRow[conzx_SysCount.UpdUser] == DBNull.Value ? null : objRow[conzx_SysCount.UpdUser].ToString().Trim(); //修改人
objzx_SysCountEN.UpdDate = objRow[conzx_SysCount.UpdDate] == DBNull.Value ? null : objRow[conzx_SysCount.UpdDate].ToString().Trim(); //修改日期
objzx_SysCountEN.Memo = objRow[conzx_SysCount.Memo] == DBNull.Value ? null : objRow[conzx_SysCount.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SysCountEN.zxCountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SysCountEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objzx_SysCountCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clszx_SysCountEN> GetSubObjLstCache(clszx_SysCountEN objzx_SysCountCond)
{
List<clszx_SysCountEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clszx_SysCountEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_SysCount.AttributeName)
{
if (objzx_SysCountCond.IsUpdated(strFldName) == false) continue;
if (objzx_SysCountCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_SysCountCond[strFldName].ToString());
}
else
{
if (objzx_SysCountCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_SysCountCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_SysCountCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_SysCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_SysCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_SysCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_SysCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_SysCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_SysCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_SysCountCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_SysCountCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_SysCountCond[strFldName]));
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
public static List<clszx_SysCountEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clszx_SysCountEN> arrObjLst = new List<clszx_SysCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SysCountEN objzx_SysCountEN = new clszx_SysCountEN();
try
{
objzx_SysCountEN.zxCountId = objRow[conzx_SysCount.zxCountId].ToString().Trim(); //CountId
objzx_SysCountEN.CountTypeId = objRow[conzx_SysCount.CountTypeId] == DBNull.Value ? null : objRow[conzx_SysCount.CountTypeId].ToString().Trim(); //CountTypeId
objzx_SysCountEN.PaperRWCount = objRow[conzx_SysCount.PaperRWCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
objzx_SysCountEN.OkCount = objRow[conzx_SysCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.OkCount].ToString().Trim()); //点赞统计
objzx_SysCountEN.CollectionCount = objRow[conzx_SysCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.CollectionCount].ToString().Trim()); //收藏数量
objzx_SysCountEN.DownloadCount = objRow[conzx_SysCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.DownloadCount].ToString().Trim()); //下载数
objzx_SysCountEN.AttachmentCount = objRow[conzx_SysCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.AttachmentCount].ToString().Trim()); //附件计数
objzx_SysCountEN.CommentCount = objRow[conzx_SysCount.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.CommentCount].ToString().Trim()); //评论数
objzx_SysCountEN.Score = objRow[conzx_SysCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SysCount.Score].ToString().Trim()); //评分
objzx_SysCountEN.StuScore = objRow[conzx_SysCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SysCount.StuScore].ToString().Trim()); //学生平均分
objzx_SysCountEN.TeaScore = objRow[conzx_SysCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SysCount.TeaScore].ToString().Trim()); //教师评分
objzx_SysCountEN.TableKey = objRow[conzx_SysCount.TableKey] == DBNull.Value ? null : objRow[conzx_SysCount.TableKey].ToString().Trim(); //表主键
objzx_SysCountEN.ParentId = objRow[conzx_SysCount.ParentId] == DBNull.Value ? null : objRow[conzx_SysCount.ParentId].ToString().Trim(); //父Id
objzx_SysCountEN.UpdUser = objRow[conzx_SysCount.UpdUser] == DBNull.Value ? null : objRow[conzx_SysCount.UpdUser].ToString().Trim(); //修改人
objzx_SysCountEN.UpdDate = objRow[conzx_SysCount.UpdDate] == DBNull.Value ? null : objRow[conzx_SysCount.UpdDate].ToString().Trim(); //修改日期
objzx_SysCountEN.Memo = objRow[conzx_SysCount.Memo] == DBNull.Value ? null : objRow[conzx_SysCount.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SysCountEN.zxCountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SysCountEN);
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
public static List<clszx_SysCountEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clszx_SysCountEN> arrObjLst = new List<clszx_SysCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SysCountEN objzx_SysCountEN = new clszx_SysCountEN();
try
{
objzx_SysCountEN.zxCountId = objRow[conzx_SysCount.zxCountId].ToString().Trim(); //CountId
objzx_SysCountEN.CountTypeId = objRow[conzx_SysCount.CountTypeId] == DBNull.Value ? null : objRow[conzx_SysCount.CountTypeId].ToString().Trim(); //CountTypeId
objzx_SysCountEN.PaperRWCount = objRow[conzx_SysCount.PaperRWCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
objzx_SysCountEN.OkCount = objRow[conzx_SysCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.OkCount].ToString().Trim()); //点赞统计
objzx_SysCountEN.CollectionCount = objRow[conzx_SysCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.CollectionCount].ToString().Trim()); //收藏数量
objzx_SysCountEN.DownloadCount = objRow[conzx_SysCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.DownloadCount].ToString().Trim()); //下载数
objzx_SysCountEN.AttachmentCount = objRow[conzx_SysCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.AttachmentCount].ToString().Trim()); //附件计数
objzx_SysCountEN.CommentCount = objRow[conzx_SysCount.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.CommentCount].ToString().Trim()); //评论数
objzx_SysCountEN.Score = objRow[conzx_SysCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SysCount.Score].ToString().Trim()); //评分
objzx_SysCountEN.StuScore = objRow[conzx_SysCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SysCount.StuScore].ToString().Trim()); //学生平均分
objzx_SysCountEN.TeaScore = objRow[conzx_SysCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SysCount.TeaScore].ToString().Trim()); //教师评分
objzx_SysCountEN.TableKey = objRow[conzx_SysCount.TableKey] == DBNull.Value ? null : objRow[conzx_SysCount.TableKey].ToString().Trim(); //表主键
objzx_SysCountEN.ParentId = objRow[conzx_SysCount.ParentId] == DBNull.Value ? null : objRow[conzx_SysCount.ParentId].ToString().Trim(); //父Id
objzx_SysCountEN.UpdUser = objRow[conzx_SysCount.UpdUser] == DBNull.Value ? null : objRow[conzx_SysCount.UpdUser].ToString().Trim(); //修改人
objzx_SysCountEN.UpdDate = objRow[conzx_SysCount.UpdDate] == DBNull.Value ? null : objRow[conzx_SysCount.UpdDate].ToString().Trim(); //修改日期
objzx_SysCountEN.Memo = objRow[conzx_SysCount.Memo] == DBNull.Value ? null : objRow[conzx_SysCount.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SysCountEN.zxCountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SysCountEN);
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
List<clszx_SysCountEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clszx_SysCountEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_SysCountEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clszx_SysCountEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clszx_SysCountEN> arrObjLst = new List<clszx_SysCountEN>(); 
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
	clszx_SysCountEN objzx_SysCountEN = new clszx_SysCountEN();
try
{
objzx_SysCountEN.zxCountId = objRow[conzx_SysCount.zxCountId].ToString().Trim(); //CountId
objzx_SysCountEN.CountTypeId = objRow[conzx_SysCount.CountTypeId] == DBNull.Value ? null : objRow[conzx_SysCount.CountTypeId].ToString().Trim(); //CountTypeId
objzx_SysCountEN.PaperRWCount = objRow[conzx_SysCount.PaperRWCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
objzx_SysCountEN.OkCount = objRow[conzx_SysCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.OkCount].ToString().Trim()); //点赞统计
objzx_SysCountEN.CollectionCount = objRow[conzx_SysCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.CollectionCount].ToString().Trim()); //收藏数量
objzx_SysCountEN.DownloadCount = objRow[conzx_SysCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.DownloadCount].ToString().Trim()); //下载数
objzx_SysCountEN.AttachmentCount = objRow[conzx_SysCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.AttachmentCount].ToString().Trim()); //附件计数
objzx_SysCountEN.CommentCount = objRow[conzx_SysCount.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.CommentCount].ToString().Trim()); //评论数
objzx_SysCountEN.Score = objRow[conzx_SysCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SysCount.Score].ToString().Trim()); //评分
objzx_SysCountEN.StuScore = objRow[conzx_SysCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SysCount.StuScore].ToString().Trim()); //学生平均分
objzx_SysCountEN.TeaScore = objRow[conzx_SysCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SysCount.TeaScore].ToString().Trim()); //教师评分
objzx_SysCountEN.TableKey = objRow[conzx_SysCount.TableKey] == DBNull.Value ? null : objRow[conzx_SysCount.TableKey].ToString().Trim(); //表主键
objzx_SysCountEN.ParentId = objRow[conzx_SysCount.ParentId] == DBNull.Value ? null : objRow[conzx_SysCount.ParentId].ToString().Trim(); //父Id
objzx_SysCountEN.UpdUser = objRow[conzx_SysCount.UpdUser] == DBNull.Value ? null : objRow[conzx_SysCount.UpdUser].ToString().Trim(); //修改人
objzx_SysCountEN.UpdDate = objRow[conzx_SysCount.UpdDate] == DBNull.Value ? null : objRow[conzx_SysCount.UpdDate].ToString().Trim(); //修改日期
objzx_SysCountEN.Memo = objRow[conzx_SysCount.Memo] == DBNull.Value ? null : objRow[conzx_SysCount.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SysCountEN.zxCountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SysCountEN);
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
public static List<clszx_SysCountEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clszx_SysCountEN> arrObjLst = new List<clszx_SysCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SysCountEN objzx_SysCountEN = new clszx_SysCountEN();
try
{
objzx_SysCountEN.zxCountId = objRow[conzx_SysCount.zxCountId].ToString().Trim(); //CountId
objzx_SysCountEN.CountTypeId = objRow[conzx_SysCount.CountTypeId] == DBNull.Value ? null : objRow[conzx_SysCount.CountTypeId].ToString().Trim(); //CountTypeId
objzx_SysCountEN.PaperRWCount = objRow[conzx_SysCount.PaperRWCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
objzx_SysCountEN.OkCount = objRow[conzx_SysCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.OkCount].ToString().Trim()); //点赞统计
objzx_SysCountEN.CollectionCount = objRow[conzx_SysCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.CollectionCount].ToString().Trim()); //收藏数量
objzx_SysCountEN.DownloadCount = objRow[conzx_SysCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.DownloadCount].ToString().Trim()); //下载数
objzx_SysCountEN.AttachmentCount = objRow[conzx_SysCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.AttachmentCount].ToString().Trim()); //附件计数
objzx_SysCountEN.CommentCount = objRow[conzx_SysCount.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.CommentCount].ToString().Trim()); //评论数
objzx_SysCountEN.Score = objRow[conzx_SysCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SysCount.Score].ToString().Trim()); //评分
objzx_SysCountEN.StuScore = objRow[conzx_SysCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SysCount.StuScore].ToString().Trim()); //学生平均分
objzx_SysCountEN.TeaScore = objRow[conzx_SysCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SysCount.TeaScore].ToString().Trim()); //教师评分
objzx_SysCountEN.TableKey = objRow[conzx_SysCount.TableKey] == DBNull.Value ? null : objRow[conzx_SysCount.TableKey].ToString().Trim(); //表主键
objzx_SysCountEN.ParentId = objRow[conzx_SysCount.ParentId] == DBNull.Value ? null : objRow[conzx_SysCount.ParentId].ToString().Trim(); //父Id
objzx_SysCountEN.UpdUser = objRow[conzx_SysCount.UpdUser] == DBNull.Value ? null : objRow[conzx_SysCount.UpdUser].ToString().Trim(); //修改人
objzx_SysCountEN.UpdDate = objRow[conzx_SysCount.UpdDate] == DBNull.Value ? null : objRow[conzx_SysCount.UpdDate].ToString().Trim(); //修改日期
objzx_SysCountEN.Memo = objRow[conzx_SysCount.Memo] == DBNull.Value ? null : objRow[conzx_SysCount.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SysCountEN.zxCountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SysCountEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clszx_SysCountEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clszx_SysCountEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clszx_SysCountEN> arrObjLst = new List<clszx_SysCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SysCountEN objzx_SysCountEN = new clszx_SysCountEN();
try
{
objzx_SysCountEN.zxCountId = objRow[conzx_SysCount.zxCountId].ToString().Trim(); //CountId
objzx_SysCountEN.CountTypeId = objRow[conzx_SysCount.CountTypeId] == DBNull.Value ? null : objRow[conzx_SysCount.CountTypeId].ToString().Trim(); //CountTypeId
objzx_SysCountEN.PaperRWCount = objRow[conzx_SysCount.PaperRWCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
objzx_SysCountEN.OkCount = objRow[conzx_SysCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.OkCount].ToString().Trim()); //点赞统计
objzx_SysCountEN.CollectionCount = objRow[conzx_SysCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.CollectionCount].ToString().Trim()); //收藏数量
objzx_SysCountEN.DownloadCount = objRow[conzx_SysCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.DownloadCount].ToString().Trim()); //下载数
objzx_SysCountEN.AttachmentCount = objRow[conzx_SysCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.AttachmentCount].ToString().Trim()); //附件计数
objzx_SysCountEN.CommentCount = objRow[conzx_SysCount.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.CommentCount].ToString().Trim()); //评论数
objzx_SysCountEN.Score = objRow[conzx_SysCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SysCount.Score].ToString().Trim()); //评分
objzx_SysCountEN.StuScore = objRow[conzx_SysCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SysCount.StuScore].ToString().Trim()); //学生平均分
objzx_SysCountEN.TeaScore = objRow[conzx_SysCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SysCount.TeaScore].ToString().Trim()); //教师评分
objzx_SysCountEN.TableKey = objRow[conzx_SysCount.TableKey] == DBNull.Value ? null : objRow[conzx_SysCount.TableKey].ToString().Trim(); //表主键
objzx_SysCountEN.ParentId = objRow[conzx_SysCount.ParentId] == DBNull.Value ? null : objRow[conzx_SysCount.ParentId].ToString().Trim(); //父Id
objzx_SysCountEN.UpdUser = objRow[conzx_SysCount.UpdUser] == DBNull.Value ? null : objRow[conzx_SysCount.UpdUser].ToString().Trim(); //修改人
objzx_SysCountEN.UpdDate = objRow[conzx_SysCount.UpdDate] == DBNull.Value ? null : objRow[conzx_SysCount.UpdDate].ToString().Trim(); //修改日期
objzx_SysCountEN.Memo = objRow[conzx_SysCount.Memo] == DBNull.Value ? null : objRow[conzx_SysCount.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SysCountEN.zxCountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SysCountEN);
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
public static List<clszx_SysCountEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clszx_SysCountEN> arrObjLst = new List<clszx_SysCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SysCountEN objzx_SysCountEN = new clszx_SysCountEN();
try
{
objzx_SysCountEN.zxCountId = objRow[conzx_SysCount.zxCountId].ToString().Trim(); //CountId
objzx_SysCountEN.CountTypeId = objRow[conzx_SysCount.CountTypeId] == DBNull.Value ? null : objRow[conzx_SysCount.CountTypeId].ToString().Trim(); //CountTypeId
objzx_SysCountEN.PaperRWCount = objRow[conzx_SysCount.PaperRWCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
objzx_SysCountEN.OkCount = objRow[conzx_SysCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.OkCount].ToString().Trim()); //点赞统计
objzx_SysCountEN.CollectionCount = objRow[conzx_SysCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.CollectionCount].ToString().Trim()); //收藏数量
objzx_SysCountEN.DownloadCount = objRow[conzx_SysCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.DownloadCount].ToString().Trim()); //下载数
objzx_SysCountEN.AttachmentCount = objRow[conzx_SysCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.AttachmentCount].ToString().Trim()); //附件计数
objzx_SysCountEN.CommentCount = objRow[conzx_SysCount.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.CommentCount].ToString().Trim()); //评论数
objzx_SysCountEN.Score = objRow[conzx_SysCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SysCount.Score].ToString().Trim()); //评分
objzx_SysCountEN.StuScore = objRow[conzx_SysCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SysCount.StuScore].ToString().Trim()); //学生平均分
objzx_SysCountEN.TeaScore = objRow[conzx_SysCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SysCount.TeaScore].ToString().Trim()); //教师评分
objzx_SysCountEN.TableKey = objRow[conzx_SysCount.TableKey] == DBNull.Value ? null : objRow[conzx_SysCount.TableKey].ToString().Trim(); //表主键
objzx_SysCountEN.ParentId = objRow[conzx_SysCount.ParentId] == DBNull.Value ? null : objRow[conzx_SysCount.ParentId].ToString().Trim(); //父Id
objzx_SysCountEN.UpdUser = objRow[conzx_SysCount.UpdUser] == DBNull.Value ? null : objRow[conzx_SysCount.UpdUser].ToString().Trim(); //修改人
objzx_SysCountEN.UpdDate = objRow[conzx_SysCount.UpdDate] == DBNull.Value ? null : objRow[conzx_SysCount.UpdDate].ToString().Trim(); //修改日期
objzx_SysCountEN.Memo = objRow[conzx_SysCount.Memo] == DBNull.Value ? null : objRow[conzx_SysCount.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SysCountEN.zxCountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SysCountEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_SysCountEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clszx_SysCountEN> arrObjLst = new List<clszx_SysCountEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SysCountEN objzx_SysCountEN = new clszx_SysCountEN();
try
{
objzx_SysCountEN.zxCountId = objRow[conzx_SysCount.zxCountId].ToString().Trim(); //CountId
objzx_SysCountEN.CountTypeId = objRow[conzx_SysCount.CountTypeId] == DBNull.Value ? null : objRow[conzx_SysCount.CountTypeId].ToString().Trim(); //CountTypeId
objzx_SysCountEN.PaperRWCount = objRow[conzx_SysCount.PaperRWCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
objzx_SysCountEN.OkCount = objRow[conzx_SysCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.OkCount].ToString().Trim()); //点赞统计
objzx_SysCountEN.CollectionCount = objRow[conzx_SysCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.CollectionCount].ToString().Trim()); //收藏数量
objzx_SysCountEN.DownloadCount = objRow[conzx_SysCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.DownloadCount].ToString().Trim()); //下载数
objzx_SysCountEN.AttachmentCount = objRow[conzx_SysCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.AttachmentCount].ToString().Trim()); //附件计数
objzx_SysCountEN.CommentCount = objRow[conzx_SysCount.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SysCount.CommentCount].ToString().Trim()); //评论数
objzx_SysCountEN.Score = objRow[conzx_SysCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SysCount.Score].ToString().Trim()); //评分
objzx_SysCountEN.StuScore = objRow[conzx_SysCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SysCount.StuScore].ToString().Trim()); //学生平均分
objzx_SysCountEN.TeaScore = objRow[conzx_SysCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SysCount.TeaScore].ToString().Trim()); //教师评分
objzx_SysCountEN.TableKey = objRow[conzx_SysCount.TableKey] == DBNull.Value ? null : objRow[conzx_SysCount.TableKey].ToString().Trim(); //表主键
objzx_SysCountEN.ParentId = objRow[conzx_SysCount.ParentId] == DBNull.Value ? null : objRow[conzx_SysCount.ParentId].ToString().Trim(); //父Id
objzx_SysCountEN.UpdUser = objRow[conzx_SysCount.UpdUser] == DBNull.Value ? null : objRow[conzx_SysCount.UpdUser].ToString().Trim(); //修改人
objzx_SysCountEN.UpdDate = objRow[conzx_SysCount.UpdDate] == DBNull.Value ? null : objRow[conzx_SysCount.UpdDate].ToString().Trim(); //修改日期
objzx_SysCountEN.Memo = objRow[conzx_SysCount.Memo] == DBNull.Value ? null : objRow[conzx_SysCount.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SysCountEN.zxCountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SysCountEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objzx_SysCountEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getzx_SysCount(ref clszx_SysCountEN objzx_SysCountEN)
{
bool bolResult = zx_SysCountDA.Getzx_SysCount(ref objzx_SysCountEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strzxCountId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_SysCountEN GetObjByzxCountId(string strzxCountId)
{
if (strzxCountId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strzxCountId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strzxCountId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strzxCountId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clszx_SysCountEN objzx_SysCountEN = zx_SysCountDA.GetObjByzxCountId(strzxCountId);
return objzx_SysCountEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clszx_SysCountEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clszx_SysCountEN objzx_SysCountEN = zx_SysCountDA.GetFirstObj(strWhereCond);
 return objzx_SysCountEN;
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
public static clszx_SysCountEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clszx_SysCountEN objzx_SysCountEN = zx_SysCountDA.GetObjByDataRow(objRow);
 return objzx_SysCountEN;
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
public static clszx_SysCountEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clszx_SysCountEN objzx_SysCountEN = zx_SysCountDA.GetObjByDataRow(objRow);
 return objzx_SysCountEN;
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
 /// <param name = "strzxCountId">所给的关键字</param>
 /// <param name = "lstzx_SysCountObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_SysCountEN GetObjByzxCountIdFromList(string strzxCountId, List<clszx_SysCountEN> lstzx_SysCountObjLst)
{
foreach (clszx_SysCountEN objzx_SysCountEN in lstzx_SysCountObjLst)
{
if (objzx_SysCountEN.zxCountId == strzxCountId)
{
return objzx_SysCountEN;
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
public static string GetFirstID_S(string strWhereCond) 
{
 string strzxCountId;
 try
 {
 strzxCountId = new clszx_SysCountDA().GetFirstID(strWhereCond);
 return strzxCountId;
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
 arrList = zx_SysCountDA.GetID(strWhereCond);
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
bool bolIsExist = zx_SysCountDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strzxCountId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strzxCountId)
{
if (string.IsNullOrEmpty(strzxCountId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strzxCountId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = zx_SysCountDA.IsExist(strzxCountId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strzxCountId">CountId</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strzxCountId, string strOpUser)
{
clszx_SysCountEN objzx_SysCountEN = clszx_SysCountBL.GetObjByzxCountId(strzxCountId);
objzx_SysCountEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
return clszx_SysCountBL.UpdateBySql2(objzx_SysCountEN);
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
 bolIsExist = clszx_SysCountDA.IsExistTable();
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
 bolIsExist = zx_SysCountDA.IsExistTable(strTabName);
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
 /// <param name = "objzx_SysCountEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clszx_SysCountEN objzx_SysCountEN)
{
 if (string.IsNullOrEmpty(objzx_SysCountEN.zxCountId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clszx_SysCountBL.IsExist(objzx_SysCountEN.zxCountId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objzx_SysCountEN.zxCountId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = zx_SysCountDA.AddNewRecordBySQL2(objzx_SysCountEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SysCountBL.ReFreshCache();

if (clszx_SysCountBL.relatedActions != null)
{
clszx_SysCountBL.relatedActions.UpdRelaTabDate(objzx_SysCountEN.zxCountId, "SetUpdDate");
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
 /// <param name = "objzx_SysCountEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clszx_SysCountEN objzx_SysCountEN)
{
 if (string.IsNullOrEmpty(objzx_SysCountEN.zxCountId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clszx_SysCountBL.IsExist(objzx_SysCountEN.zxCountId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objzx_SysCountEN.zxCountId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = zx_SysCountDA.AddNewRecordBySQL2WithReturnKey(objzx_SysCountEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SysCountBL.ReFreshCache();

if (clszx_SysCountBL.relatedActions != null)
{
clszx_SysCountBL.relatedActions.UpdRelaTabDate(objzx_SysCountEN.zxCountId, "SetUpdDate");
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
 /// <param name = "objzx_SysCountEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clszx_SysCountEN objzx_SysCountEN)
{
try
{
bool bolResult = zx_SysCountDA.Update(objzx_SysCountEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SysCountBL.ReFreshCache();

if (clszx_SysCountBL.relatedActions != null)
{
clszx_SysCountBL.relatedActions.UpdRelaTabDate(objzx_SysCountEN.zxCountId, "SetUpdDate");
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
 /// <param name = "objzx_SysCountEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clszx_SysCountEN objzx_SysCountEN)
{
 if (string.IsNullOrEmpty(objzx_SysCountEN.zxCountId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = zx_SysCountDA.UpdateBySql2(objzx_SysCountEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SysCountBL.ReFreshCache();

if (clszx_SysCountBL.relatedActions != null)
{
clszx_SysCountBL.relatedActions.UpdRelaTabDate(objzx_SysCountEN.zxCountId, "SetUpdDate");
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
 /// <param name = "strzxCountId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strzxCountId)
{
try
{
 clszx_SysCountEN objzx_SysCountEN = clszx_SysCountBL.GetObjByzxCountId(strzxCountId);

if (clszx_SysCountBL.relatedActions != null)
{
clszx_SysCountBL.relatedActions.UpdRelaTabDate(objzx_SysCountEN.zxCountId, "SetUpdDate");
}
if (objzx_SysCountEN != null)
{
int intRecNum = zx_SysCountDA.DelRecord(strzxCountId);
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
/// <param name="strzxCountId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strzxCountId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_SysCountDA.GetSpecSQLObj();
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
//删除与表:[zx_SysCount]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conzx_SysCount.zxCountId,
//strzxCountId);
//        clszx_SysCountBL.Delzx_SysCountsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_SysCountBL.DelRecord(strzxCountId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_SysCountBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strzxCountId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strzxCountId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strzxCountId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clszx_SysCountBL.relatedActions != null)
{
clszx_SysCountBL.relatedActions.UpdRelaTabDate(strzxCountId, "UpdRelaTabDate");
}
bool bolResult = zx_SysCountDA.DelRecord(strzxCountId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrzxCountIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delzx_SysCounts(List<string> arrzxCountIdLst)
{
if (arrzxCountIdLst.Count == 0) return 0;
try
{
if (clszx_SysCountBL.relatedActions != null)
{
foreach (var strzxCountId in arrzxCountIdLst)
{
clszx_SysCountBL.relatedActions.UpdRelaTabDate(strzxCountId, "UpdRelaTabDate");
}
}
int intDelRecNum = zx_SysCountDA.Delzx_SysCount(arrzxCountIdLst);
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
public static int Delzx_SysCountsByCond(string strWhereCond)
{
try
{
if (clszx_SysCountBL.relatedActions != null)
{
List<string> arrzxCountId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strzxCountId in arrzxCountId)
{
clszx_SysCountBL.relatedActions.UpdRelaTabDate(strzxCountId, "UpdRelaTabDate");
}
}
int intRecNum = zx_SysCountDA.Delzx_SysCount(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[zx_SysCount]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strzxCountId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strzxCountId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_SysCountDA.GetSpecSQLObj();
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
//删除与表:[zx_SysCount]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_SysCountBL.DelRecord(strzxCountId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_SysCountBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strzxCountId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objzx_SysCountENS">源对象</param>
 /// <param name = "objzx_SysCountENT">目标对象</param>
 public static void CopyTo(clszx_SysCountEN objzx_SysCountENS, clszx_SysCountEN objzx_SysCountENT)
{
try
{
objzx_SysCountENT.zxCountId = objzx_SysCountENS.zxCountId; //CountId
objzx_SysCountENT.CountTypeId = objzx_SysCountENS.CountTypeId; //CountTypeId
objzx_SysCountENT.PaperRWCount = objzx_SysCountENS.PaperRWCount; //PaperRWCount
objzx_SysCountENT.OkCount = objzx_SysCountENS.OkCount; //点赞统计
objzx_SysCountENT.CollectionCount = objzx_SysCountENS.CollectionCount; //收藏数量
objzx_SysCountENT.DownloadCount = objzx_SysCountENS.DownloadCount; //下载数
objzx_SysCountENT.AttachmentCount = objzx_SysCountENS.AttachmentCount; //附件计数
objzx_SysCountENT.CommentCount = objzx_SysCountENS.CommentCount; //评论数
objzx_SysCountENT.Score = objzx_SysCountENS.Score; //评分
objzx_SysCountENT.StuScore = objzx_SysCountENS.StuScore; //学生平均分
objzx_SysCountENT.TeaScore = objzx_SysCountENS.TeaScore; //教师评分
objzx_SysCountENT.TableKey = objzx_SysCountENS.TableKey; //表主键
objzx_SysCountENT.ParentId = objzx_SysCountENS.ParentId; //父Id
objzx_SysCountENT.UpdUser = objzx_SysCountENS.UpdUser; //修改人
objzx_SysCountENT.UpdDate = objzx_SysCountENS.UpdDate; //修改日期
objzx_SysCountENT.Memo = objzx_SysCountENS.Memo; //备注
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
 /// <param name = "objzx_SysCountEN">源简化对象</param>
 public static void SetUpdFlag(clszx_SysCountEN objzx_SysCountEN)
{
try
{
objzx_SysCountEN.ClearUpdateState();
   string strsfUpdFldSetStr = objzx_SysCountEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conzx_SysCount.zxCountId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SysCountEN.zxCountId = objzx_SysCountEN.zxCountId; //CountId
}
if (arrFldSet.Contains(conzx_SysCount.CountTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SysCountEN.CountTypeId = objzx_SysCountEN.CountTypeId == "[null]" ? null :  objzx_SysCountEN.CountTypeId; //CountTypeId
}
if (arrFldSet.Contains(conzx_SysCount.PaperRWCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SysCountEN.PaperRWCount = objzx_SysCountEN.PaperRWCount; //PaperRWCount
}
if (arrFldSet.Contains(conzx_SysCount.OkCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SysCountEN.OkCount = objzx_SysCountEN.OkCount; //点赞统计
}
if (arrFldSet.Contains(conzx_SysCount.CollectionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SysCountEN.CollectionCount = objzx_SysCountEN.CollectionCount; //收藏数量
}
if (arrFldSet.Contains(conzx_SysCount.DownloadCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SysCountEN.DownloadCount = objzx_SysCountEN.DownloadCount; //下载数
}
if (arrFldSet.Contains(conzx_SysCount.AttachmentCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SysCountEN.AttachmentCount = objzx_SysCountEN.AttachmentCount; //附件计数
}
if (arrFldSet.Contains(conzx_SysCount.CommentCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SysCountEN.CommentCount = objzx_SysCountEN.CommentCount; //评论数
}
if (arrFldSet.Contains(conzx_SysCount.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SysCountEN.Score = objzx_SysCountEN.Score; //评分
}
if (arrFldSet.Contains(conzx_SysCount.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SysCountEN.StuScore = objzx_SysCountEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(conzx_SysCount.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SysCountEN.TeaScore = objzx_SysCountEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(conzx_SysCount.TableKey, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SysCountEN.TableKey = objzx_SysCountEN.TableKey == "[null]" ? null :  objzx_SysCountEN.TableKey; //表主键
}
if (arrFldSet.Contains(conzx_SysCount.ParentId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SysCountEN.ParentId = objzx_SysCountEN.ParentId == "[null]" ? null :  objzx_SysCountEN.ParentId; //父Id
}
if (arrFldSet.Contains(conzx_SysCount.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SysCountEN.UpdUser = objzx_SysCountEN.UpdUser == "[null]" ? null :  objzx_SysCountEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conzx_SysCount.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SysCountEN.UpdDate = objzx_SysCountEN.UpdDate == "[null]" ? null :  objzx_SysCountEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conzx_SysCount.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SysCountEN.Memo = objzx_SysCountEN.Memo == "[null]" ? null :  objzx_SysCountEN.Memo; //备注
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
 /// <param name = "objzx_SysCountEN">源简化对象</param>
 public static void AccessFldValueNull(clszx_SysCountEN objzx_SysCountEN)
{
try
{
if (objzx_SysCountEN.CountTypeId == "[null]") objzx_SysCountEN.CountTypeId = null; //CountTypeId
if (objzx_SysCountEN.TableKey == "[null]") objzx_SysCountEN.TableKey = null; //表主键
if (objzx_SysCountEN.ParentId == "[null]") objzx_SysCountEN.ParentId = null; //父Id
if (objzx_SysCountEN.UpdUser == "[null]") objzx_SysCountEN.UpdUser = null; //修改人
if (objzx_SysCountEN.UpdDate == "[null]") objzx_SysCountEN.UpdDate = null; //修改日期
if (objzx_SysCountEN.Memo == "[null]") objzx_SysCountEN.Memo = null; //备注
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
public static void CheckPropertyNew(clszx_SysCountEN objzx_SysCountEN)
{
 zx_SysCountDA.CheckPropertyNew(objzx_SysCountEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clszx_SysCountEN objzx_SysCountEN)
{
 zx_SysCountDA.CheckProperty4Condition(objzx_SysCountEN);
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
if (clszx_SysCountBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_SysCountBL没有刷新缓存机制(clszx_SysCountBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by zxCountId");
//if (arrzx_SysCountObjLstCache == null)
//{
//arrzx_SysCountObjLstCache = zx_SysCountDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strzxCountId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_SysCountEN GetObjByzxCountIdCache(string strzxCountId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clszx_SysCountEN._CurrTabName);
List<clszx_SysCountEN> arrzx_SysCountObjLstCache = GetObjLstCache();
IEnumerable <clszx_SysCountEN> arrzx_SysCountObjLst_Sel =
arrzx_SysCountObjLstCache
.Where(x=> x.zxCountId == strzxCountId 
);
if (arrzx_SysCountObjLst_Sel.Count() == 0)
{
   clszx_SysCountEN obj = clszx_SysCountBL.GetObjByzxCountId(strzxCountId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrzx_SysCountObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_SysCountEN> GetAllzx_SysCountObjLstCache()
{
//获取缓存中的对象列表
List<clszx_SysCountEN> arrzx_SysCountObjLstCache = GetObjLstCache(); 
return arrzx_SysCountObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_SysCountEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clszx_SysCountEN._CurrTabName);
List<clszx_SysCountEN> arrzx_SysCountObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrzx_SysCountObjLstCache;
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
string strKey = string.Format("{0}", clszx_SysCountEN._CurrTabName);
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
if (clszx_SysCountBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clszx_SysCountEN._CurrTabName);
CacheHelper.Remove(strKey);
clszx_SysCountBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性


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
public static string Func(string strInFldName, string strOutFldName, string strzxCountId)
{
if (strInFldName != conzx_SysCount.zxCountId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conzx_SysCount.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conzx_SysCount.AttributeName));
throw new Exception(strMsg);
}
var objzx_SysCount = clszx_SysCountBL.GetObjByzxCountIdCache(strzxCountId);
if (objzx_SysCount == null) return "";
return objzx_SysCount[strOutFldName].ToString();
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
int intRecCount = clszx_SysCountDA.GetRecCount(strTabName);
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
int intRecCount = clszx_SysCountDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clszx_SysCountDA.GetRecCount();
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
int intRecCount = clszx_SysCountDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objzx_SysCountCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clszx_SysCountEN objzx_SysCountCond)
{
List<clszx_SysCountEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clszx_SysCountEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_SysCount.AttributeName)
{
if (objzx_SysCountCond.IsUpdated(strFldName) == false) continue;
if (objzx_SysCountCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_SysCountCond[strFldName].ToString());
}
else
{
if (objzx_SysCountCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_SysCountCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_SysCountCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_SysCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_SysCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_SysCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_SysCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_SysCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_SysCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_SysCountCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_SysCountCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_SysCountCond[strFldName]));
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
 List<string> arrList = clszx_SysCountDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = zx_SysCountDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = zx_SysCountDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = zx_SysCountDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_SysCountDA.SetFldValue(clszx_SysCountEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = zx_SysCountDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_SysCountDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_SysCountDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_SysCountDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[zx_SysCount] "); 
 strCreateTabCode.Append(" ( "); 
 // /**CountId*/ 
 strCreateTabCode.Append(" zxCountId char(10) primary key, "); 
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
 /// 中学统计数据(zx_SysCount)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4zx_SysCount : clsCommFun4BL
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
clszx_SysCountBL.ReFreshThisCache();
}
}

}