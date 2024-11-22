
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsAqa_QuestionsExBL
 表名:Aqa_QuestionsEx(01120952)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:06:58
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
public static class  clsAqa_QuestionsExBL_Static
{

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objAqa_QuestionsExEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsAqa_QuestionsExEN objAqa_QuestionsExEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objAqa_QuestionsExEN.StuId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (string.IsNullOrEmpty(objAqa_QuestionsExEN.QuestionsId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsAqa_QuestionsExBL.IsExist(objAqa_QuestionsExEN.StuId,objAqa_QuestionsExEN.QuestionsId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objAqa_QuestionsExEN.StuId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsAqa_QuestionsExBL.Aqa_QuestionsExDA.AddNewRecordBySQL2(objAqa_QuestionsExEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAqa_QuestionsExBL.ReFreshCache();

if (clsAqa_QuestionsExBL.relatedActions != null)
{
clsAqa_QuestionsExBL.relatedActions.UpdRelaTabDate(objAqa_QuestionsExEN.StuId,objAqa_QuestionsExEN.QuestionsId, "SetUpdDate");
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
public static bool AddRecordEx(this clsAqa_QuestionsExEN objAqa_QuestionsExEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsAqa_QuestionsExBL.IsExist(objAqa_QuestionsExEN.StuId,objAqa_QuestionsExEN.QuestionsId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objAqa_QuestionsExEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objAqa_QuestionsExEN.AddNewRecord();
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
 /// <param name = "objAqa_QuestionsExEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsAqa_QuestionsExEN objAqa_QuestionsExEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objAqa_QuestionsExEN.StuId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsAqa_QuestionsExBL.IsExist(objAqa_QuestionsExEN.StuId,objAqa_QuestionsExEN.QuestionsId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objAqa_QuestionsExEN.StuId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsAqa_QuestionsExBL.Aqa_QuestionsExDA.AddNewRecordBySQL2WithReturnKey(objAqa_QuestionsExEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAqa_QuestionsExBL.ReFreshCache();

if (clsAqa_QuestionsExBL.relatedActions != null)
{
clsAqa_QuestionsExBL.relatedActions.UpdRelaTabDate(objAqa_QuestionsExEN.StuId,objAqa_QuestionsExEN.QuestionsId, "SetUpdDate");
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
 /// <param name = "objAqa_QuestionsExEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAqa_QuestionsExEN SetStuId(this clsAqa_QuestionsExEN objAqa_QuestionsExEN, string strStuId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuId, 20, conAqa_QuestionsEx.StuId);
}
objAqa_QuestionsExEN.StuId = strStuId; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAqa_QuestionsExEN.dicFldComparisonOp.ContainsKey(conAqa_QuestionsEx.StuId) == false)
{
objAqa_QuestionsExEN.dicFldComparisonOp.Add(conAqa_QuestionsEx.StuId, strComparisonOp);
}
else
{
objAqa_QuestionsExEN.dicFldComparisonOp[conAqa_QuestionsEx.StuId] = strComparisonOp;
}
}
return objAqa_QuestionsExEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAqa_QuestionsExEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAqa_QuestionsExEN SetQuestionsId(this clsAqa_QuestionsExEN objAqa_QuestionsExEN, string strQuestionsId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionsId, 8, conAqa_QuestionsEx.QuestionsId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionsId, 8, conAqa_QuestionsEx.QuestionsId);
}
objAqa_QuestionsExEN.QuestionsId = strQuestionsId; //提问Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAqa_QuestionsExEN.dicFldComparisonOp.ContainsKey(conAqa_QuestionsEx.QuestionsId) == false)
{
objAqa_QuestionsExEN.dicFldComparisonOp.Add(conAqa_QuestionsEx.QuestionsId, strComparisonOp);
}
else
{
objAqa_QuestionsExEN.dicFldComparisonOp[conAqa_QuestionsEx.QuestionsId] = strComparisonOp;
}
}
return objAqa_QuestionsExEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAqa_QuestionsExEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAqa_QuestionsExEN SetPaperId(this clsAqa_QuestionsExEN objAqa_QuestionsExEN, string strPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperId, 8, conAqa_QuestionsEx.PaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, conAqa_QuestionsEx.PaperId);
}
objAqa_QuestionsExEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAqa_QuestionsExEN.dicFldComparisonOp.ContainsKey(conAqa_QuestionsEx.PaperId) == false)
{
objAqa_QuestionsExEN.dicFldComparisonOp.Add(conAqa_QuestionsEx.PaperId, strComparisonOp);
}
else
{
objAqa_QuestionsExEN.dicFldComparisonOp[conAqa_QuestionsEx.PaperId] = strComparisonOp;
}
}
return objAqa_QuestionsExEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAqa_QuestionsExEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAqa_QuestionsExEN SetPaperTitle(this clsAqa_QuestionsExEN objAqa_QuestionsExEN, string strPaperTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTitle, 500, conAqa_QuestionsEx.PaperTitle);
}
objAqa_QuestionsExEN.PaperTitle = strPaperTitle; //论文标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAqa_QuestionsExEN.dicFldComparisonOp.ContainsKey(conAqa_QuestionsEx.PaperTitle) == false)
{
objAqa_QuestionsExEN.dicFldComparisonOp.Add(conAqa_QuestionsEx.PaperTitle, strComparisonOp);
}
else
{
objAqa_QuestionsExEN.dicFldComparisonOp[conAqa_QuestionsEx.PaperTitle] = strComparisonOp;
}
}
return objAqa_QuestionsExEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAqa_QuestionsExEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAqa_QuestionsExEN SetQuestionsContent(this clsAqa_QuestionsExEN objAqa_QuestionsExEN, string strQuestionsContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionsContent, 1000, conAqa_QuestionsEx.QuestionsContent);
}
objAqa_QuestionsExEN.QuestionsContent = strQuestionsContent; //提问内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAqa_QuestionsExEN.dicFldComparisonOp.ContainsKey(conAqa_QuestionsEx.QuestionsContent) == false)
{
objAqa_QuestionsExEN.dicFldComparisonOp.Add(conAqa_QuestionsEx.QuestionsContent, strComparisonOp);
}
else
{
objAqa_QuestionsExEN.dicFldComparisonOp[conAqa_QuestionsEx.QuestionsContent] = strComparisonOp;
}
}
return objAqa_QuestionsExEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAqa_QuestionsExEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAqa_QuestionsExEN SetQuestionsTypeId(this clsAqa_QuestionsExEN objAqa_QuestionsExEN, string strQuestionsTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionsTypeId, 2, conAqa_QuestionsEx.QuestionsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionsTypeId, 2, conAqa_QuestionsEx.QuestionsTypeId);
}
objAqa_QuestionsExEN.QuestionsTypeId = strQuestionsTypeId; //问题类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAqa_QuestionsExEN.dicFldComparisonOp.ContainsKey(conAqa_QuestionsEx.QuestionsTypeId) == false)
{
objAqa_QuestionsExEN.dicFldComparisonOp.Add(conAqa_QuestionsEx.QuestionsTypeId, strComparisonOp);
}
else
{
objAqa_QuestionsExEN.dicFldComparisonOp[conAqa_QuestionsEx.QuestionsTypeId] = strComparisonOp;
}
}
return objAqa_QuestionsExEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAqa_QuestionsExEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAqa_QuestionsExEN SetQuestionsTypeName(this clsAqa_QuestionsExEN objAqa_QuestionsExEN, string strQuestionsTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionsTypeName, 50, conAqa_QuestionsEx.QuestionsTypeName);
}
objAqa_QuestionsExEN.QuestionsTypeName = strQuestionsTypeName; //问题类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAqa_QuestionsExEN.dicFldComparisonOp.ContainsKey(conAqa_QuestionsEx.QuestionsTypeName) == false)
{
objAqa_QuestionsExEN.dicFldComparisonOp.Add(conAqa_QuestionsEx.QuestionsTypeName, strComparisonOp);
}
else
{
objAqa_QuestionsExEN.dicFldComparisonOp[conAqa_QuestionsEx.QuestionsTypeName] = strComparisonOp;
}
}
return objAqa_QuestionsExEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAqa_QuestionsExEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAqa_QuestionsExEN SetStuName(this clsAqa_QuestionsExEN objAqa_QuestionsExEN, string strStuName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuName, 50, conAqa_QuestionsEx.StuName);
}
objAqa_QuestionsExEN.StuName = strStuName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAqa_QuestionsExEN.dicFldComparisonOp.ContainsKey(conAqa_QuestionsEx.StuName) == false)
{
objAqa_QuestionsExEN.dicFldComparisonOp.Add(conAqa_QuestionsEx.StuName, strComparisonOp);
}
else
{
objAqa_QuestionsExEN.dicFldComparisonOp[conAqa_QuestionsEx.StuName] = strComparisonOp;
}
}
return objAqa_QuestionsExEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAqa_QuestionsExEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAqa_QuestionsExEN SetStuAnswer(this clsAqa_QuestionsExEN objAqa_QuestionsExEN, string strStuAnswer, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuAnswer, 500, conAqa_QuestionsEx.StuAnswer);
}
objAqa_QuestionsExEN.StuAnswer = strStuAnswer; //答案
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAqa_QuestionsExEN.dicFldComparisonOp.ContainsKey(conAqa_QuestionsEx.StuAnswer) == false)
{
objAqa_QuestionsExEN.dicFldComparisonOp.Add(conAqa_QuestionsEx.StuAnswer, strComparisonOp);
}
else
{
objAqa_QuestionsExEN.dicFldComparisonOp[conAqa_QuestionsEx.StuAnswer] = strComparisonOp;
}
}
return objAqa_QuestionsExEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objAqa_QuestionsExEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsAqa_QuestionsExEN objAqa_QuestionsExEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objAqa_QuestionsExEN.CheckPropertyNew();
clsAqa_QuestionsExEN objAqa_QuestionsExCond = new clsAqa_QuestionsExEN();
string strCondition = objAqa_QuestionsExCond
.SetStuId(objAqa_QuestionsExEN.StuId, "=")
.GetCombineCondition();
objAqa_QuestionsExEN._IsCheckProperty = true;
bool bolIsExist = clsAqa_QuestionsExBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objAqa_QuestionsExEN.Update();
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
 /// <param name = "objAqa_QuestionsExEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsAqa_QuestionsExEN objAqa_QuestionsExEN)
{
 if (string.IsNullOrEmpty(objAqa_QuestionsExEN.StuId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsAqa_QuestionsExBL.Aqa_QuestionsExDA.UpdateBySql2(objAqa_QuestionsExEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAqa_QuestionsExBL.ReFreshCache();

if (clsAqa_QuestionsExBL.relatedActions != null)
{
clsAqa_QuestionsExBL.relatedActions.UpdRelaTabDate(objAqa_QuestionsExEN.StuId,objAqa_QuestionsExEN.QuestionsId, "SetUpdDate");
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
 /// <param name = "objAqa_QuestionsExEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsAqa_QuestionsExEN objAqa_QuestionsExEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objAqa_QuestionsExEN.StuId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsAqa_QuestionsExBL.Aqa_QuestionsExDA.UpdateBySql2(objAqa_QuestionsExEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAqa_QuestionsExBL.ReFreshCache();

if (clsAqa_QuestionsExBL.relatedActions != null)
{
clsAqa_QuestionsExBL.relatedActions.UpdRelaTabDate(objAqa_QuestionsExEN.StuId,objAqa_QuestionsExEN.QuestionsId, "SetUpdDate");
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
 /// <param name = "objAqa_QuestionsExEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsAqa_QuestionsExEN objAqa_QuestionsExEN, string strWhereCond)
{
try
{
bool bolResult = clsAqa_QuestionsExBL.Aqa_QuestionsExDA.UpdateBySqlWithCondition(objAqa_QuestionsExEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAqa_QuestionsExBL.ReFreshCache();

if (clsAqa_QuestionsExBL.relatedActions != null)
{
clsAqa_QuestionsExBL.relatedActions.UpdRelaTabDate(objAqa_QuestionsExEN.StuId,objAqa_QuestionsExEN.QuestionsId, "SetUpdDate");
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
 /// <param name = "objAqa_QuestionsExEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsAqa_QuestionsExEN objAqa_QuestionsExEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsAqa_QuestionsExBL.Aqa_QuestionsExDA.UpdateBySqlWithConditionTransaction(objAqa_QuestionsExEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAqa_QuestionsExBL.ReFreshCache();

if (clsAqa_QuestionsExBL.relatedActions != null)
{
clsAqa_QuestionsExBL.relatedActions.UpdRelaTabDate(objAqa_QuestionsExEN.StuId,objAqa_QuestionsExEN.QuestionsId, "SetUpdDate");
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
 /// <param name = "strStuId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsAqa_QuestionsExEN objAqa_QuestionsExEN)
{
try
{
int intRecNum = clsAqa_QuestionsExBL.Aqa_QuestionsExDA.DelRecord(objAqa_QuestionsExEN.StuId,objAqa_QuestionsExEN.QuestionsId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAqa_QuestionsExBL.ReFreshCache();

if (clsAqa_QuestionsExBL.relatedActions != null)
{
clsAqa_QuestionsExBL.relatedActions.UpdRelaTabDate(objAqa_QuestionsExEN.StuId,objAqa_QuestionsExEN.QuestionsId, "SetUpdDate");
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
 /// <param name = "objAqa_QuestionsExENS">源对象</param>
 /// <param name = "objAqa_QuestionsExENT">目标对象</param>
 public static void CopyTo(this clsAqa_QuestionsExEN objAqa_QuestionsExENS, clsAqa_QuestionsExEN objAqa_QuestionsExENT)
{
try
{
objAqa_QuestionsExENT.StuId = objAqa_QuestionsExENS.StuId; //学号
objAqa_QuestionsExENT.QuestionsId = objAqa_QuestionsExENS.QuestionsId; //提问Id
objAqa_QuestionsExENT.PaperId = objAqa_QuestionsExENS.PaperId; //论文Id
objAqa_QuestionsExENT.PaperTitle = objAqa_QuestionsExENS.PaperTitle; //论文标题
objAqa_QuestionsExENT.QuestionsContent = objAqa_QuestionsExENS.QuestionsContent; //提问内容
objAqa_QuestionsExENT.QuestionsTypeId = objAqa_QuestionsExENS.QuestionsTypeId; //问题类型Id
objAqa_QuestionsExENT.QuestionsTypeName = objAqa_QuestionsExENS.QuestionsTypeName; //问题类型名称
objAqa_QuestionsExENT.StuName = objAqa_QuestionsExENS.StuName; //姓名
objAqa_QuestionsExENT.StuAnswer = objAqa_QuestionsExENS.StuAnswer; //答案
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
 /// <param name = "objAqa_QuestionsExENS">源对象</param>
 /// <returns>目标对象=>clsAqa_QuestionsExEN:objAqa_QuestionsExENT</returns>
 public static clsAqa_QuestionsExEN CopyTo(this clsAqa_QuestionsExEN objAqa_QuestionsExENS)
{
try
{
 clsAqa_QuestionsExEN objAqa_QuestionsExENT = new clsAqa_QuestionsExEN()
{
StuId = objAqa_QuestionsExENS.StuId, //学号
QuestionsId = objAqa_QuestionsExENS.QuestionsId, //提问Id
PaperId = objAqa_QuestionsExENS.PaperId, //论文Id
PaperTitle = objAqa_QuestionsExENS.PaperTitle, //论文标题
QuestionsContent = objAqa_QuestionsExENS.QuestionsContent, //提问内容
QuestionsTypeId = objAqa_QuestionsExENS.QuestionsTypeId, //问题类型Id
QuestionsTypeName = objAqa_QuestionsExENS.QuestionsTypeName, //问题类型名称
StuName = objAqa_QuestionsExENS.StuName, //姓名
StuAnswer = objAqa_QuestionsExENS.StuAnswer, //答案
};
 return objAqa_QuestionsExENT;
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
public static void CheckPropertyNew(this clsAqa_QuestionsExEN objAqa_QuestionsExEN)
{
 clsAqa_QuestionsExBL.Aqa_QuestionsExDA.CheckPropertyNew(objAqa_QuestionsExEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsAqa_QuestionsExEN objAqa_QuestionsExEN)
{
 clsAqa_QuestionsExBL.Aqa_QuestionsExDA.CheckProperty4Condition(objAqa_QuestionsExEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsAqa_QuestionsExEN objAqa_QuestionsExCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objAqa_QuestionsExCond.IsUpdated(conAqa_QuestionsEx.StuId) == true)
{
string strComparisonOpStuId = objAqa_QuestionsExCond.dicFldComparisonOp[conAqa_QuestionsEx.StuId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAqa_QuestionsEx.StuId, objAqa_QuestionsExCond.StuId, strComparisonOpStuId);
}
if (objAqa_QuestionsExCond.IsUpdated(conAqa_QuestionsEx.QuestionsId) == true)
{
string strComparisonOpQuestionsId = objAqa_QuestionsExCond.dicFldComparisonOp[conAqa_QuestionsEx.QuestionsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAqa_QuestionsEx.QuestionsId, objAqa_QuestionsExCond.QuestionsId, strComparisonOpQuestionsId);
}
if (objAqa_QuestionsExCond.IsUpdated(conAqa_QuestionsEx.PaperId) == true)
{
string strComparisonOpPaperId = objAqa_QuestionsExCond.dicFldComparisonOp[conAqa_QuestionsEx.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAqa_QuestionsEx.PaperId, objAqa_QuestionsExCond.PaperId, strComparisonOpPaperId);
}
if (objAqa_QuestionsExCond.IsUpdated(conAqa_QuestionsEx.PaperTitle) == true)
{
string strComparisonOpPaperTitle = objAqa_QuestionsExCond.dicFldComparisonOp[conAqa_QuestionsEx.PaperTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAqa_QuestionsEx.PaperTitle, objAqa_QuestionsExCond.PaperTitle, strComparisonOpPaperTitle);
}
if (objAqa_QuestionsExCond.IsUpdated(conAqa_QuestionsEx.QuestionsContent) == true)
{
string strComparisonOpQuestionsContent = objAqa_QuestionsExCond.dicFldComparisonOp[conAqa_QuestionsEx.QuestionsContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAqa_QuestionsEx.QuestionsContent, objAqa_QuestionsExCond.QuestionsContent, strComparisonOpQuestionsContent);
}
if (objAqa_QuestionsExCond.IsUpdated(conAqa_QuestionsEx.QuestionsTypeId) == true)
{
string strComparisonOpQuestionsTypeId = objAqa_QuestionsExCond.dicFldComparisonOp[conAqa_QuestionsEx.QuestionsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAqa_QuestionsEx.QuestionsTypeId, objAqa_QuestionsExCond.QuestionsTypeId, strComparisonOpQuestionsTypeId);
}
if (objAqa_QuestionsExCond.IsUpdated(conAqa_QuestionsEx.QuestionsTypeName) == true)
{
string strComparisonOpQuestionsTypeName = objAqa_QuestionsExCond.dicFldComparisonOp[conAqa_QuestionsEx.QuestionsTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAqa_QuestionsEx.QuestionsTypeName, objAqa_QuestionsExCond.QuestionsTypeName, strComparisonOpQuestionsTypeName);
}
if (objAqa_QuestionsExCond.IsUpdated(conAqa_QuestionsEx.StuName) == true)
{
string strComparisonOpStuName = objAqa_QuestionsExCond.dicFldComparisonOp[conAqa_QuestionsEx.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAqa_QuestionsEx.StuName, objAqa_QuestionsExCond.StuName, strComparisonOpStuName);
}
if (objAqa_QuestionsExCond.IsUpdated(conAqa_QuestionsEx.StuAnswer) == true)
{
string strComparisonOpStuAnswer = objAqa_QuestionsExCond.dicFldComparisonOp[conAqa_QuestionsEx.StuAnswer];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAqa_QuestionsEx.StuAnswer, objAqa_QuestionsExCond.StuAnswer, strComparisonOpStuAnswer);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_Aqa_QuestionsEx
{
public virtual bool UpdRelaTabDate(string strStuId,string strQuestionsId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// Aqa_QuestionsEx(Aqa_QuestionsEx)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsAqa_QuestionsExBL
{
public static RelatedActions_Aqa_QuestionsEx relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsAqa_QuestionsExDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsAqa_QuestionsExDA Aqa_QuestionsExDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsAqa_QuestionsExDA();
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
 public clsAqa_QuestionsExBL()
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
if (string.IsNullOrEmpty(clsAqa_QuestionsExEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsAqa_QuestionsExEN._ConnectString);
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
public static DataTable GetDataTable_Aqa_QuestionsEx(string strWhereCond)
{
DataTable objDT;
try
{
objDT = Aqa_QuestionsExDA.GetDataTable_Aqa_QuestionsEx(strWhereCond);
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
objDT = Aqa_QuestionsExDA.GetDataTable(strWhereCond);
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
objDT = Aqa_QuestionsExDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = Aqa_QuestionsExDA.GetDataTable(strWhereCond, strTabName);
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
objDT = Aqa_QuestionsExDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = Aqa_QuestionsExDA.GetDataTable_Top(objTopPara);
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
objDT = Aqa_QuestionsExDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = Aqa_QuestionsExDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = Aqa_QuestionsExDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
//该表没有使用Cache,不需要生成[GetObjLstByKeyLstsCache]函数;

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsAqa_QuestionsExEN> GetObjLst(string strWhereCond)
{
List<clsAqa_QuestionsExEN> arrObjLst = new List<clsAqa_QuestionsExEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAqa_QuestionsExEN objAqa_QuestionsExEN = new clsAqa_QuestionsExEN();
try
{
objAqa_QuestionsExEN.StuId = objRow[conAqa_QuestionsEx.StuId].ToString().Trim(); //学号
objAqa_QuestionsExEN.QuestionsId = objRow[conAqa_QuestionsEx.QuestionsId].ToString().Trim(); //提问Id
objAqa_QuestionsExEN.PaperId = objRow[conAqa_QuestionsEx.PaperId] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.PaperId].ToString().Trim(); //论文Id
objAqa_QuestionsExEN.PaperTitle = objRow[conAqa_QuestionsEx.PaperTitle] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.PaperTitle].ToString().Trim(); //论文标题
objAqa_QuestionsExEN.QuestionsContent = objRow[conAqa_QuestionsEx.QuestionsContent] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.QuestionsContent].ToString().Trim(); //提问内容
objAqa_QuestionsExEN.QuestionsTypeId = objRow[conAqa_QuestionsEx.QuestionsTypeId] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.QuestionsTypeId].ToString().Trim(); //问题类型Id
objAqa_QuestionsExEN.QuestionsTypeName = objRow[conAqa_QuestionsEx.QuestionsTypeName] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.QuestionsTypeName].ToString().Trim(); //问题类型名称
objAqa_QuestionsExEN.StuName = objRow[conAqa_QuestionsEx.StuName] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.StuName].ToString().Trim(); //姓名
objAqa_QuestionsExEN.StuAnswer = objRow[conAqa_QuestionsEx.StuAnswer] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.StuAnswer].ToString().Trim(); //答案
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAqa_QuestionsExEN.StuId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAqa_QuestionsExEN);
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
public static List<clsAqa_QuestionsExEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsAqa_QuestionsExEN> arrObjLst = new List<clsAqa_QuestionsExEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAqa_QuestionsExEN objAqa_QuestionsExEN = new clsAqa_QuestionsExEN();
try
{
objAqa_QuestionsExEN.StuId = objRow[conAqa_QuestionsEx.StuId].ToString().Trim(); //学号
objAqa_QuestionsExEN.QuestionsId = objRow[conAqa_QuestionsEx.QuestionsId].ToString().Trim(); //提问Id
objAqa_QuestionsExEN.PaperId = objRow[conAqa_QuestionsEx.PaperId] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.PaperId].ToString().Trim(); //论文Id
objAqa_QuestionsExEN.PaperTitle = objRow[conAqa_QuestionsEx.PaperTitle] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.PaperTitle].ToString().Trim(); //论文标题
objAqa_QuestionsExEN.QuestionsContent = objRow[conAqa_QuestionsEx.QuestionsContent] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.QuestionsContent].ToString().Trim(); //提问内容
objAqa_QuestionsExEN.QuestionsTypeId = objRow[conAqa_QuestionsEx.QuestionsTypeId] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.QuestionsTypeId].ToString().Trim(); //问题类型Id
objAqa_QuestionsExEN.QuestionsTypeName = objRow[conAqa_QuestionsEx.QuestionsTypeName] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.QuestionsTypeName].ToString().Trim(); //问题类型名称
objAqa_QuestionsExEN.StuName = objRow[conAqa_QuestionsEx.StuName] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.StuName].ToString().Trim(); //姓名
objAqa_QuestionsExEN.StuAnswer = objRow[conAqa_QuestionsEx.StuAnswer] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.StuAnswer].ToString().Trim(); //答案
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAqa_QuestionsExEN.StuId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAqa_QuestionsExEN);
	}
return arrObjLst;
}
//该表没有使用Cache,不需要生成[GetSubObjLstCache]函数;

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsAqa_QuestionsExEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsAqa_QuestionsExEN> arrObjLst = new List<clsAqa_QuestionsExEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAqa_QuestionsExEN objAqa_QuestionsExEN = new clsAqa_QuestionsExEN();
try
{
objAqa_QuestionsExEN.StuId = objRow[conAqa_QuestionsEx.StuId].ToString().Trim(); //学号
objAqa_QuestionsExEN.QuestionsId = objRow[conAqa_QuestionsEx.QuestionsId].ToString().Trim(); //提问Id
objAqa_QuestionsExEN.PaperId = objRow[conAqa_QuestionsEx.PaperId] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.PaperId].ToString().Trim(); //论文Id
objAqa_QuestionsExEN.PaperTitle = objRow[conAqa_QuestionsEx.PaperTitle] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.PaperTitle].ToString().Trim(); //论文标题
objAqa_QuestionsExEN.QuestionsContent = objRow[conAqa_QuestionsEx.QuestionsContent] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.QuestionsContent].ToString().Trim(); //提问内容
objAqa_QuestionsExEN.QuestionsTypeId = objRow[conAqa_QuestionsEx.QuestionsTypeId] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.QuestionsTypeId].ToString().Trim(); //问题类型Id
objAqa_QuestionsExEN.QuestionsTypeName = objRow[conAqa_QuestionsEx.QuestionsTypeName] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.QuestionsTypeName].ToString().Trim(); //问题类型名称
objAqa_QuestionsExEN.StuName = objRow[conAqa_QuestionsEx.StuName] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.StuName].ToString().Trim(); //姓名
objAqa_QuestionsExEN.StuAnswer = objRow[conAqa_QuestionsEx.StuAnswer] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.StuAnswer].ToString().Trim(); //答案
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAqa_QuestionsExEN.StuId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAqa_QuestionsExEN);
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
public static List<clsAqa_QuestionsExEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsAqa_QuestionsExEN> arrObjLst = new List<clsAqa_QuestionsExEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAqa_QuestionsExEN objAqa_QuestionsExEN = new clsAqa_QuestionsExEN();
try
{
objAqa_QuestionsExEN.StuId = objRow[conAqa_QuestionsEx.StuId].ToString().Trim(); //学号
objAqa_QuestionsExEN.QuestionsId = objRow[conAqa_QuestionsEx.QuestionsId].ToString().Trim(); //提问Id
objAqa_QuestionsExEN.PaperId = objRow[conAqa_QuestionsEx.PaperId] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.PaperId].ToString().Trim(); //论文Id
objAqa_QuestionsExEN.PaperTitle = objRow[conAqa_QuestionsEx.PaperTitle] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.PaperTitle].ToString().Trim(); //论文标题
objAqa_QuestionsExEN.QuestionsContent = objRow[conAqa_QuestionsEx.QuestionsContent] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.QuestionsContent].ToString().Trim(); //提问内容
objAqa_QuestionsExEN.QuestionsTypeId = objRow[conAqa_QuestionsEx.QuestionsTypeId] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.QuestionsTypeId].ToString().Trim(); //问题类型Id
objAqa_QuestionsExEN.QuestionsTypeName = objRow[conAqa_QuestionsEx.QuestionsTypeName] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.QuestionsTypeName].ToString().Trim(); //问题类型名称
objAqa_QuestionsExEN.StuName = objRow[conAqa_QuestionsEx.StuName] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.StuName].ToString().Trim(); //姓名
objAqa_QuestionsExEN.StuAnswer = objRow[conAqa_QuestionsEx.StuAnswer] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.StuAnswer].ToString().Trim(); //答案
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAqa_QuestionsExEN.StuId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAqa_QuestionsExEN);
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
List<clsAqa_QuestionsExEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsAqa_QuestionsExEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsAqa_QuestionsExEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsAqa_QuestionsExEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsAqa_QuestionsExEN> arrObjLst = new List<clsAqa_QuestionsExEN>(); 
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
	clsAqa_QuestionsExEN objAqa_QuestionsExEN = new clsAqa_QuestionsExEN();
try
{
objAqa_QuestionsExEN.StuId = objRow[conAqa_QuestionsEx.StuId].ToString().Trim(); //学号
objAqa_QuestionsExEN.QuestionsId = objRow[conAqa_QuestionsEx.QuestionsId].ToString().Trim(); //提问Id
objAqa_QuestionsExEN.PaperId = objRow[conAqa_QuestionsEx.PaperId] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.PaperId].ToString().Trim(); //论文Id
objAqa_QuestionsExEN.PaperTitle = objRow[conAqa_QuestionsEx.PaperTitle] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.PaperTitle].ToString().Trim(); //论文标题
objAqa_QuestionsExEN.QuestionsContent = objRow[conAqa_QuestionsEx.QuestionsContent] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.QuestionsContent].ToString().Trim(); //提问内容
objAqa_QuestionsExEN.QuestionsTypeId = objRow[conAqa_QuestionsEx.QuestionsTypeId] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.QuestionsTypeId].ToString().Trim(); //问题类型Id
objAqa_QuestionsExEN.QuestionsTypeName = objRow[conAqa_QuestionsEx.QuestionsTypeName] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.QuestionsTypeName].ToString().Trim(); //问题类型名称
objAqa_QuestionsExEN.StuName = objRow[conAqa_QuestionsEx.StuName] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.StuName].ToString().Trim(); //姓名
objAqa_QuestionsExEN.StuAnswer = objRow[conAqa_QuestionsEx.StuAnswer] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.StuAnswer].ToString().Trim(); //答案
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAqa_QuestionsExEN.StuId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAqa_QuestionsExEN);
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
public static List<clsAqa_QuestionsExEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsAqa_QuestionsExEN> arrObjLst = new List<clsAqa_QuestionsExEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAqa_QuestionsExEN objAqa_QuestionsExEN = new clsAqa_QuestionsExEN();
try
{
objAqa_QuestionsExEN.StuId = objRow[conAqa_QuestionsEx.StuId].ToString().Trim(); //学号
objAqa_QuestionsExEN.QuestionsId = objRow[conAqa_QuestionsEx.QuestionsId].ToString().Trim(); //提问Id
objAqa_QuestionsExEN.PaperId = objRow[conAqa_QuestionsEx.PaperId] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.PaperId].ToString().Trim(); //论文Id
objAqa_QuestionsExEN.PaperTitle = objRow[conAqa_QuestionsEx.PaperTitle] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.PaperTitle].ToString().Trim(); //论文标题
objAqa_QuestionsExEN.QuestionsContent = objRow[conAqa_QuestionsEx.QuestionsContent] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.QuestionsContent].ToString().Trim(); //提问内容
objAqa_QuestionsExEN.QuestionsTypeId = objRow[conAqa_QuestionsEx.QuestionsTypeId] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.QuestionsTypeId].ToString().Trim(); //问题类型Id
objAqa_QuestionsExEN.QuestionsTypeName = objRow[conAqa_QuestionsEx.QuestionsTypeName] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.QuestionsTypeName].ToString().Trim(); //问题类型名称
objAqa_QuestionsExEN.StuName = objRow[conAqa_QuestionsEx.StuName] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.StuName].ToString().Trim(); //姓名
objAqa_QuestionsExEN.StuAnswer = objRow[conAqa_QuestionsEx.StuAnswer] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.StuAnswer].ToString().Trim(); //答案
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAqa_QuestionsExEN.StuId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAqa_QuestionsExEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsAqa_QuestionsExEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsAqa_QuestionsExEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsAqa_QuestionsExEN> arrObjLst = new List<clsAqa_QuestionsExEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAqa_QuestionsExEN objAqa_QuestionsExEN = new clsAqa_QuestionsExEN();
try
{
objAqa_QuestionsExEN.StuId = objRow[conAqa_QuestionsEx.StuId].ToString().Trim(); //学号
objAqa_QuestionsExEN.QuestionsId = objRow[conAqa_QuestionsEx.QuestionsId].ToString().Trim(); //提问Id
objAqa_QuestionsExEN.PaperId = objRow[conAqa_QuestionsEx.PaperId] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.PaperId].ToString().Trim(); //论文Id
objAqa_QuestionsExEN.PaperTitle = objRow[conAqa_QuestionsEx.PaperTitle] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.PaperTitle].ToString().Trim(); //论文标题
objAqa_QuestionsExEN.QuestionsContent = objRow[conAqa_QuestionsEx.QuestionsContent] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.QuestionsContent].ToString().Trim(); //提问内容
objAqa_QuestionsExEN.QuestionsTypeId = objRow[conAqa_QuestionsEx.QuestionsTypeId] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.QuestionsTypeId].ToString().Trim(); //问题类型Id
objAqa_QuestionsExEN.QuestionsTypeName = objRow[conAqa_QuestionsEx.QuestionsTypeName] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.QuestionsTypeName].ToString().Trim(); //问题类型名称
objAqa_QuestionsExEN.StuName = objRow[conAqa_QuestionsEx.StuName] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.StuName].ToString().Trim(); //姓名
objAqa_QuestionsExEN.StuAnswer = objRow[conAqa_QuestionsEx.StuAnswer] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.StuAnswer].ToString().Trim(); //答案
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAqa_QuestionsExEN.StuId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAqa_QuestionsExEN);
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
public static List<clsAqa_QuestionsExEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsAqa_QuestionsExEN> arrObjLst = new List<clsAqa_QuestionsExEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAqa_QuestionsExEN objAqa_QuestionsExEN = new clsAqa_QuestionsExEN();
try
{
objAqa_QuestionsExEN.StuId = objRow[conAqa_QuestionsEx.StuId].ToString().Trim(); //学号
objAqa_QuestionsExEN.QuestionsId = objRow[conAqa_QuestionsEx.QuestionsId].ToString().Trim(); //提问Id
objAqa_QuestionsExEN.PaperId = objRow[conAqa_QuestionsEx.PaperId] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.PaperId].ToString().Trim(); //论文Id
objAqa_QuestionsExEN.PaperTitle = objRow[conAqa_QuestionsEx.PaperTitle] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.PaperTitle].ToString().Trim(); //论文标题
objAqa_QuestionsExEN.QuestionsContent = objRow[conAqa_QuestionsEx.QuestionsContent] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.QuestionsContent].ToString().Trim(); //提问内容
objAqa_QuestionsExEN.QuestionsTypeId = objRow[conAqa_QuestionsEx.QuestionsTypeId] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.QuestionsTypeId].ToString().Trim(); //问题类型Id
objAqa_QuestionsExEN.QuestionsTypeName = objRow[conAqa_QuestionsEx.QuestionsTypeName] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.QuestionsTypeName].ToString().Trim(); //问题类型名称
objAqa_QuestionsExEN.StuName = objRow[conAqa_QuestionsEx.StuName] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.StuName].ToString().Trim(); //姓名
objAqa_QuestionsExEN.StuAnswer = objRow[conAqa_QuestionsEx.StuAnswer] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.StuAnswer].ToString().Trim(); //答案
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAqa_QuestionsExEN.StuId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAqa_QuestionsExEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsAqa_QuestionsExEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsAqa_QuestionsExEN> arrObjLst = new List<clsAqa_QuestionsExEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAqa_QuestionsExEN objAqa_QuestionsExEN = new clsAqa_QuestionsExEN();
try
{
objAqa_QuestionsExEN.StuId = objRow[conAqa_QuestionsEx.StuId].ToString().Trim(); //学号
objAqa_QuestionsExEN.QuestionsId = objRow[conAqa_QuestionsEx.QuestionsId].ToString().Trim(); //提问Id
objAqa_QuestionsExEN.PaperId = objRow[conAqa_QuestionsEx.PaperId] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.PaperId].ToString().Trim(); //论文Id
objAqa_QuestionsExEN.PaperTitle = objRow[conAqa_QuestionsEx.PaperTitle] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.PaperTitle].ToString().Trim(); //论文标题
objAqa_QuestionsExEN.QuestionsContent = objRow[conAqa_QuestionsEx.QuestionsContent] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.QuestionsContent].ToString().Trim(); //提问内容
objAqa_QuestionsExEN.QuestionsTypeId = objRow[conAqa_QuestionsEx.QuestionsTypeId] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.QuestionsTypeId].ToString().Trim(); //问题类型Id
objAqa_QuestionsExEN.QuestionsTypeName = objRow[conAqa_QuestionsEx.QuestionsTypeName] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.QuestionsTypeName].ToString().Trim(); //问题类型名称
objAqa_QuestionsExEN.StuName = objRow[conAqa_QuestionsEx.StuName] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.StuName].ToString().Trim(); //姓名
objAqa_QuestionsExEN.StuAnswer = objRow[conAqa_QuestionsEx.StuAnswer] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.StuAnswer].ToString().Trim(); //答案
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAqa_QuestionsExEN.StuId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAqa_QuestionsExEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objAqa_QuestionsExEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetAqa_QuestionsEx(ref clsAqa_QuestionsExEN objAqa_QuestionsExEN)
{
bool bolResult = Aqa_QuestionsExDA.GetAqa_QuestionsEx(ref objAqa_QuestionsExEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strStuId">表关键字</param>
 /// <param name = "strQuestionsId">表关键字</param>
 /// <returns>表对象</returns>
public static clsAqa_QuestionsExEN GetObjByKeyLst(string strStuId,string strQuestionsId)
{
if (strStuId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000168)在表中,关键字[strStuId,strQuestionsId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (strQuestionsId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000168)在表中,关键字[strStuId,strQuestionsId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strStuId) == true)
{
var strMsg = string.Format("(errid:Busi000169)在表中,关键字[strStuId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strQuestionsId) == true)
{
var strMsg = string.Format("(errid:Busi000169)在表中,关键字[strQuestionsId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsAqa_QuestionsExEN objAqa_QuestionsExEN = Aqa_QuestionsExDA.GetObjByKeyLst(strStuId,strQuestionsId);
return objAqa_QuestionsExEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsAqa_QuestionsExEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsAqa_QuestionsExEN objAqa_QuestionsExEN = Aqa_QuestionsExDA.GetFirstObj(strWhereCond);
 return objAqa_QuestionsExEN;
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
public static clsAqa_QuestionsExEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsAqa_QuestionsExEN objAqa_QuestionsExEN = Aqa_QuestionsExDA.GetObjByDataRow(objRow);
 return objAqa_QuestionsExEN;
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
public static clsAqa_QuestionsExEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsAqa_QuestionsExEN objAqa_QuestionsExEN = Aqa_QuestionsExDA.GetObjByDataRow(objRow);
 return objAqa_QuestionsExEN;
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
 /// <param name = "strStuId">表关键字</param>
 /// <param name = "strQuestionsId">表关键字</param>
 /// <param name = "lstAqa_QuestionsExObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsAqa_QuestionsExEN GetObjByKeyLstFromList(string strStuId,string strQuestionsId, List<clsAqa_QuestionsExEN> lstAqa_QuestionsExObjLst)
{
foreach (clsAqa_QuestionsExEN objAqa_QuestionsExEN in lstAqa_QuestionsExObjLst)
{
if (objAqa_QuestionsExEN.StuId == strStuId 
 && objAqa_QuestionsExEN.QuestionsId == strQuestionsId 
)
{
return objAqa_QuestionsExEN;
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
 string strStuId;
 try
 {
 strStuId = new clsAqa_QuestionsExDA().GetFirstID(strWhereCond);
 return strStuId;
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
 arrList = Aqa_QuestionsExDA.GetID(strWhereCond);
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
bool bolIsExist = Aqa_QuestionsExDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strStuId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strStuId,string strQuestionsId)
{
//检测记录是否存在
bool bolIsExist = Aqa_QuestionsExDA.IsExist(strStuId,strQuestionsId);
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
 bolIsExist = clsAqa_QuestionsExDA.IsExistTable();
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
 bolIsExist = Aqa_QuestionsExDA.IsExistTable(strTabName);
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
 /// <param name = "objAqa_QuestionsExEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsAqa_QuestionsExEN objAqa_QuestionsExEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objAqa_QuestionsExEN.StuId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsAqa_QuestionsExBL.IsExist(objAqa_QuestionsExEN.StuId,objAqa_QuestionsExEN.QuestionsId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objAqa_QuestionsExEN.StuId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = Aqa_QuestionsExDA.AddNewRecordBySQL2(objAqa_QuestionsExEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAqa_QuestionsExBL.ReFreshCache();

if (clsAqa_QuestionsExBL.relatedActions != null)
{
clsAqa_QuestionsExBL.relatedActions.UpdRelaTabDate(objAqa_QuestionsExEN.StuId,objAqa_QuestionsExEN.QuestionsId, "SetUpdDate");
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
 /// <param name = "objAqa_QuestionsExEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsAqa_QuestionsExEN objAqa_QuestionsExEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objAqa_QuestionsExEN.StuId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsAqa_QuestionsExBL.IsExist(objAqa_QuestionsExEN.StuId,objAqa_QuestionsExEN.QuestionsId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objAqa_QuestionsExEN.StuId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = Aqa_QuestionsExDA.AddNewRecordBySQL2WithReturnKey(objAqa_QuestionsExEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAqa_QuestionsExBL.ReFreshCache();

if (clsAqa_QuestionsExBL.relatedActions != null)
{
clsAqa_QuestionsExBL.relatedActions.UpdRelaTabDate(objAqa_QuestionsExEN.StuId,objAqa_QuestionsExEN.QuestionsId, "SetUpdDate");
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
 /// <param name = "objAqa_QuestionsExEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsAqa_QuestionsExEN objAqa_QuestionsExEN)
{
try
{
bool bolResult = Aqa_QuestionsExDA.Update(objAqa_QuestionsExEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAqa_QuestionsExBL.ReFreshCache();

if (clsAqa_QuestionsExBL.relatedActions != null)
{
clsAqa_QuestionsExBL.relatedActions.UpdRelaTabDate(objAqa_QuestionsExEN.StuId,objAqa_QuestionsExEN.QuestionsId, "SetUpdDate");
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
 /// <param name = "objAqa_QuestionsExEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsAqa_QuestionsExEN objAqa_QuestionsExEN)
{
 if (string.IsNullOrEmpty(objAqa_QuestionsExEN.StuId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = Aqa_QuestionsExDA.UpdateBySql2(objAqa_QuestionsExEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAqa_QuestionsExBL.ReFreshCache();

if (clsAqa_QuestionsExBL.relatedActions != null)
{
clsAqa_QuestionsExBL.relatedActions.UpdRelaTabDate(objAqa_QuestionsExEN.StuId,objAqa_QuestionsExEN.QuestionsId, "SetUpdDate");
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
 /// <param name = "strStuId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strStuId,string strQuestionsId)
{
try
{
 clsAqa_QuestionsExEN objAqa_QuestionsExEN = clsAqa_QuestionsExBL.GetObjByKeyLst(strStuId,strQuestionsId);

if (clsAqa_QuestionsExBL.relatedActions != null)
{
clsAqa_QuestionsExBL.relatedActions.UpdRelaTabDate(objAqa_QuestionsExEN.StuId,objAqa_QuestionsExEN.QuestionsId, "SetUpdDate");
}
if (objAqa_QuestionsExEN != null)
{
int intRecNum = Aqa_QuestionsExDA.DelRecord(strStuId,strQuestionsId);
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
/// <param name="strStuId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strStuId,string strQuestionsId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsAqa_QuestionsExDA.GetSpecSQLObj();
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
//删除与表:[Aqa_QuestionsEx]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conAqa_QuestionsEx.StuId,
//strStuId);
//        clsAqa_QuestionsExBL.DelAqa_QuestionsExsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsAqa_QuestionsExBL.DelRecord(strStuId,strQuestionsId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsAqa_QuestionsExBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strStuId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strStuId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strStuId,string strQuestionsId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsAqa_QuestionsExBL.relatedActions != null)
{
clsAqa_QuestionsExBL.relatedActions.UpdRelaTabDate(strStuId,strQuestionsId, "UpdRelaTabDate");
}
bool bolResult = Aqa_QuestionsExDA.DelRecord(strStuId,strQuestionsId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrStuIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecKeyLsts(List<string> arrKeyLsts)
{
if (arrKeyLsts.Count == 0) return 0;
try
{
string[] sstrKey;
string strStuId;
string strQuestionsId;
if (clsAqa_QuestionsExBL.relatedActions != null)
{
foreach (var strKeyLst in arrKeyLsts)
{
sstrKey = strKeyLst.Split('|');
strStuId = sstrKey[0];
strQuestionsId = sstrKey[1];
clsAqa_QuestionsExBL.relatedActions.UpdRelaTabDate(strStuId,strQuestionsId, "UpdRelaTabDate");
}
}
sstrKey = arrKeyLsts[0].Split('|');
strStuId = sstrKey[0];
strQuestionsId = sstrKey[1];
int intDelRecNum = Aqa_QuestionsExDA.DelRecKeyLsts(arrKeyLsts);
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
public static int DelAqa_QuestionsExsByCond(string strWhereCond)
{
try
{
int intRecNum = Aqa_QuestionsExDA.DelAqa_QuestionsEx(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[Aqa_QuestionsEx]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strStuId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strStuId,string strQuestionsId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsAqa_QuestionsExDA.GetSpecSQLObj();
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
//删除与表:[Aqa_QuestionsEx]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsAqa_QuestionsExBL.DelRecord(strStuId,strQuestionsId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsAqa_QuestionsExBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strStuId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objAqa_QuestionsExENS">源对象</param>
 /// <param name = "objAqa_QuestionsExENT">目标对象</param>
 public static void CopyTo(clsAqa_QuestionsExEN objAqa_QuestionsExENS, clsAqa_QuestionsExEN objAqa_QuestionsExENT)
{
try
{
objAqa_QuestionsExENT.StuId = objAqa_QuestionsExENS.StuId; //学号
objAqa_QuestionsExENT.QuestionsId = objAqa_QuestionsExENS.QuestionsId; //提问Id
objAqa_QuestionsExENT.PaperId = objAqa_QuestionsExENS.PaperId; //论文Id
objAqa_QuestionsExENT.PaperTitle = objAqa_QuestionsExENS.PaperTitle; //论文标题
objAqa_QuestionsExENT.QuestionsContent = objAqa_QuestionsExENS.QuestionsContent; //提问内容
objAqa_QuestionsExENT.QuestionsTypeId = objAqa_QuestionsExENS.QuestionsTypeId; //问题类型Id
objAqa_QuestionsExENT.QuestionsTypeName = objAqa_QuestionsExENS.QuestionsTypeName; //问题类型名称
objAqa_QuestionsExENT.StuName = objAqa_QuestionsExENS.StuName; //姓名
objAqa_QuestionsExENT.StuAnswer = objAqa_QuestionsExENS.StuAnswer; //答案
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
 /// <param name = "objAqa_QuestionsExEN">源简化对象</param>
 public static void SetUpdFlag(clsAqa_QuestionsExEN objAqa_QuestionsExEN)
{
try
{
objAqa_QuestionsExEN.ClearUpdateState();
   string strsfUpdFldSetStr = objAqa_QuestionsExEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conAqa_QuestionsEx.StuId, new clsStrCompareIgnoreCase())  ==  true)
{
objAqa_QuestionsExEN.StuId = objAqa_QuestionsExEN.StuId; //学号
}
if (arrFldSet.Contains(conAqa_QuestionsEx.QuestionsId, new clsStrCompareIgnoreCase())  ==  true)
{
objAqa_QuestionsExEN.QuestionsId = objAqa_QuestionsExEN.QuestionsId; //提问Id
}
if (arrFldSet.Contains(conAqa_QuestionsEx.PaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objAqa_QuestionsExEN.PaperId = objAqa_QuestionsExEN.PaperId == "[null]" ? null :  objAqa_QuestionsExEN.PaperId; //论文Id
}
if (arrFldSet.Contains(conAqa_QuestionsEx.PaperTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objAqa_QuestionsExEN.PaperTitle = objAqa_QuestionsExEN.PaperTitle == "[null]" ? null :  objAqa_QuestionsExEN.PaperTitle; //论文标题
}
if (arrFldSet.Contains(conAqa_QuestionsEx.QuestionsContent, new clsStrCompareIgnoreCase())  ==  true)
{
objAqa_QuestionsExEN.QuestionsContent = objAqa_QuestionsExEN.QuestionsContent == "[null]" ? null :  objAqa_QuestionsExEN.QuestionsContent; //提问内容
}
if (arrFldSet.Contains(conAqa_QuestionsEx.QuestionsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objAqa_QuestionsExEN.QuestionsTypeId = objAqa_QuestionsExEN.QuestionsTypeId == "[null]" ? null :  objAqa_QuestionsExEN.QuestionsTypeId; //问题类型Id
}
if (arrFldSet.Contains(conAqa_QuestionsEx.QuestionsTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objAqa_QuestionsExEN.QuestionsTypeName = objAqa_QuestionsExEN.QuestionsTypeName == "[null]" ? null :  objAqa_QuestionsExEN.QuestionsTypeName; //问题类型名称
}
if (arrFldSet.Contains(conAqa_QuestionsEx.StuName, new clsStrCompareIgnoreCase())  ==  true)
{
objAqa_QuestionsExEN.StuName = objAqa_QuestionsExEN.StuName == "[null]" ? null :  objAqa_QuestionsExEN.StuName; //姓名
}
if (arrFldSet.Contains(conAqa_QuestionsEx.StuAnswer, new clsStrCompareIgnoreCase())  ==  true)
{
objAqa_QuestionsExEN.StuAnswer = objAqa_QuestionsExEN.StuAnswer == "[null]" ? null :  objAqa_QuestionsExEN.StuAnswer; //答案
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
 /// <param name = "objAqa_QuestionsExEN">源简化对象</param>
 public static void AccessFldValueNull(clsAqa_QuestionsExEN objAqa_QuestionsExEN)
{
try
{
if (objAqa_QuestionsExEN.PaperId == "[null]") objAqa_QuestionsExEN.PaperId = null; //论文Id
if (objAqa_QuestionsExEN.PaperTitle == "[null]") objAqa_QuestionsExEN.PaperTitle = null; //论文标题
if (objAqa_QuestionsExEN.QuestionsContent == "[null]") objAqa_QuestionsExEN.QuestionsContent = null; //提问内容
if (objAqa_QuestionsExEN.QuestionsTypeId == "[null]") objAqa_QuestionsExEN.QuestionsTypeId = null; //问题类型Id
if (objAqa_QuestionsExEN.QuestionsTypeName == "[null]") objAqa_QuestionsExEN.QuestionsTypeName = null; //问题类型名称
if (objAqa_QuestionsExEN.StuName == "[null]") objAqa_QuestionsExEN.StuName = null; //姓名
if (objAqa_QuestionsExEN.StuAnswer == "[null]") objAqa_QuestionsExEN.StuAnswer = null; //答案
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
public static void CheckPropertyNew(clsAqa_QuestionsExEN objAqa_QuestionsExEN)
{
 Aqa_QuestionsExDA.CheckPropertyNew(objAqa_QuestionsExEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsAqa_QuestionsExEN objAqa_QuestionsExEN)
{
 Aqa_QuestionsExDA.CheckProperty4Condition(objAqa_QuestionsExEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框


 #endregion 绑定下拉框


 #region 缓存操作
//该表没有使用Cache,不需要生成[InitListCache]函数;
//该表没有使用Cache,不需要生成[GetObjByKeyLstCache]函数;
//该表没有使用Cache,不需要生成[GetAllAqa_QuestionsExObjLstCache]函数;
//该表没有使用Cache,不需要生成[GetObjLstCache]函数;

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsAqa_QuestionsExEN._CurrTabName);
CacheHelper.Remove(strKey);
clsAqa_QuestionsExEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsAqa_QuestionsExEN._RefreshTimeLst.Count == 0) return "";
return clsAqa_QuestionsExEN._RefreshTimeLst[clsAqa_QuestionsExEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsAqa_QuestionsExBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsAqa_QuestionsExEN._CurrTabName);
CacheHelper.Remove(strKey);
clsAqa_QuestionsExEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsAqa_QuestionsExBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

// /// <summary>
// /// 映射函数。根据表映射把输入字段值,映射成输出字段值
// /// 作者:pyf
// /// 日期:2024-11-13
// /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
// /// </summary>
// /// <param name = "strInFldName">输入字段名</param>
// /// <param name = "strOutFldName">输出字段名</param>
// /// <param name = "strInValue">输入字段值</param>
// /// <returns>返回一个输出字段值</returns>
//public static string Func(string strInFldName, string strOutFldName, string strStuId,string strQuestionsId)
//{
//if (strInFldName != conAqa_QuestionsEx.StuId)
//{
//string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
//throw new Exception(strMsg);
//}
//if (conAqa_QuestionsEx.AttributeName.Contains(strOutFldName) == false)
//{
//string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
//strInFldName, string.Join(", ", conAqa_QuestionsEx.AttributeName));
//throw new Exception(strMsg);
//}
//var objAqa_QuestionsEx = clsAqa_QuestionsExBL.GetObjByKeyLstCache(strStuId,strQuestionsId);
//if (objAqa_QuestionsEx == null) return "";
//return objAqa_QuestionsEx[strOutFldName].ToString();
//}


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
int intRecCount = clsAqa_QuestionsExDA.GetRecCount(strTabName);
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
int intRecCount = clsAqa_QuestionsExDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsAqa_QuestionsExDA.GetRecCount();
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
int intRecCount = clsAqa_QuestionsExDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}

//该表没有使用Cache,不需要生成[GetRecCountByCondCache]函数;

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
 List<string> arrList = clsAqa_QuestionsExDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = Aqa_QuestionsExDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = Aqa_QuestionsExDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = Aqa_QuestionsExDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsAqa_QuestionsExDA.SetFldValue(clsAqa_QuestionsExEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = Aqa_QuestionsExDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsAqa_QuestionsExDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsAqa_QuestionsExDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsAqa_QuestionsExDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[Aqa_QuestionsEx] "); 
 strCreateTabCode.Append(" ( "); 
 // /**学号*/ 
 strCreateTabCode.Append(" StuId varchar(20) primary key, "); 
 // /**提问Id*/ 
 strCreateTabCode.Append(" QuestionsId char(8) primary key, "); 
 // /**论文Id*/ 
 strCreateTabCode.Append(" PaperId char(8) Null, "); 
 // /**论文标题*/ 
 strCreateTabCode.Append(" PaperTitle varchar(500) Null, "); 
 // /**提问内容*/ 
 strCreateTabCode.Append(" QuestionsContent varchar(1000) Null, "); 
 // /**问题类型Id*/ 
 strCreateTabCode.Append(" QuestionsTypeId char(2) Null, "); 
 // /**问题类型名称*/ 
 strCreateTabCode.Append(" QuestionsTypeName varchar(50) Null, "); 
 // /**姓名*/ 
 strCreateTabCode.Append(" StuName varchar(50) Null, "); 
 // /**答案*/ 
 strCreateTabCode.Append(" StuAnswer varchar(500) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// Aqa_QuestionsEx(Aqa_QuestionsEx)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4Aqa_QuestionsEx : clsCommFun4BL
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
clsAqa_QuestionsExBL.ReFreshThisCache();
}
}

}