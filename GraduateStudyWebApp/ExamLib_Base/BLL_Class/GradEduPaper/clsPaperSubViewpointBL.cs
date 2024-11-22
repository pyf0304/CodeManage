
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPaperSubViewpointBL
 表名:PaperSubViewpoint(01120534)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:03:39
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
public static class  clsPaperSubViewpointBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngSubViewpointId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPaperSubViewpointEN GetObj(this K_SubViewpointId_PaperSubViewpoint myKey)
{
clsPaperSubViewpointEN objPaperSubViewpointEN = clsPaperSubViewpointBL.PaperSubViewpointDA.GetObjBySubViewpointId(myKey.Value);
return objPaperSubViewpointEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsPaperSubViewpointEN objPaperSubViewpointEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objPaperSubViewpointEN) == false)
{
var strMsg = string.Format("记录已经存在!论文Id = [{0}],类型Id = [{1}],用户ID = [{2}],详情内容 = [{3}]的数据已经存在!(in clsPaperSubViewpointBL.AddNewRecord)", objPaperSubViewpointEN.PaperId,objPaperSubViewpointEN.SubViewpointTypeId,objPaperSubViewpointEN.UserId,objPaperSubViewpointEN.SubViewpointContent);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsPaperSubViewpointBL.PaperSubViewpointDA.AddNewRecordBySQL2(objPaperSubViewpointEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubViewpointBL.ReFreshCache(objPaperSubViewpointEN.IdCurrEduCls);

if (clsPaperSubViewpointBL.relatedActions != null)
{
clsPaperSubViewpointBL.relatedActions.UpdRelaTabDate(objPaperSubViewpointEN.SubViewpointId, "SetUpdDate");
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
public static bool AddRecordEx(this clsPaperSubViewpointEN objPaperSubViewpointEN, bool bolIsNeedCheckUniqueness = true)
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
objPaperSubViewpointEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objPaperSubViewpointEN.CheckUniqueness() == false)
{
strMsg = string.Format("(论文Id(PaperId)=[{0}],类型Id(SubViewpointTypeId)=[{1}],用户ID(UserId)=[{2}],详情内容(SubViewpointContent)=[{3}])已经存在,不能重复!", objPaperSubViewpointEN.PaperId, objPaperSubViewpointEN.SubViewpointTypeId, objPaperSubViewpointEN.UserId, objPaperSubViewpointEN.SubViewpointContent);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objPaperSubViewpointEN.AddNewRecord();
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
 /// <param name = "objPaperSubViewpointEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsPaperSubViewpointEN objPaperSubViewpointEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objPaperSubViewpointEN) == false)
{
var strMsg = string.Format("记录已经存在!论文Id = [{0}],类型Id = [{1}],用户ID = [{2}],详情内容 = [{3}]的数据已经存在!(in clsPaperSubViewpointBL.AddNewRecordWithReturnKey)", objPaperSubViewpointEN.PaperId,objPaperSubViewpointEN.SubViewpointTypeId,objPaperSubViewpointEN.UserId,objPaperSubViewpointEN.SubViewpointContent);
throw new Exception(strMsg);
}
try
{
string strKey = clsPaperSubViewpointBL.PaperSubViewpointDA.AddNewRecordBySQL2WithReturnKey(objPaperSubViewpointEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubViewpointBL.ReFreshCache(objPaperSubViewpointEN.IdCurrEduCls);

if (clsPaperSubViewpointBL.relatedActions != null)
{
clsPaperSubViewpointBL.relatedActions.UpdRelaTabDate(objPaperSubViewpointEN.SubViewpointId, "SetUpdDate");
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
 /// <param name = "objPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubViewpointEN SetSubViewpointId(this clsPaperSubViewpointEN objPaperSubViewpointEN, long lngSubViewpointId, string strComparisonOp="")
	{
objPaperSubViewpointEN.SubViewpointId = lngSubViewpointId; //子观点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpoint.SubViewpointId) == false)
{
objPaperSubViewpointEN.dicFldComparisonOp.Add(conPaperSubViewpoint.SubViewpointId, strComparisonOp);
}
else
{
objPaperSubViewpointEN.dicFldComparisonOp[conPaperSubViewpoint.SubViewpointId] = strComparisonOp;
}
}
return objPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubViewpointEN SetSubViewpointContent(this clsPaperSubViewpointEN objPaperSubViewpointEN, string strSubViewpointContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSubViewpointContent, 500, conPaperSubViewpoint.SubViewpointContent);
}
objPaperSubViewpointEN.SubViewpointContent = strSubViewpointContent; //详情内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpoint.SubViewpointContent) == false)
{
objPaperSubViewpointEN.dicFldComparisonOp.Add(conPaperSubViewpoint.SubViewpointContent, strComparisonOp);
}
else
{
objPaperSubViewpointEN.dicFldComparisonOp[conPaperSubViewpoint.SubViewpointContent] = strComparisonOp;
}
}
return objPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubViewpointEN SetPaperRWId(this clsPaperSubViewpointEN objPaperSubViewpointEN, string strPaperRWId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperRWId, 8, conPaperSubViewpoint.PaperRWId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperRWId, 8, conPaperSubViewpoint.PaperRWId);
}
objPaperSubViewpointEN.PaperRWId = strPaperRWId; //课文阅读
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpoint.PaperRWId) == false)
{
objPaperSubViewpointEN.dicFldComparisonOp.Add(conPaperSubViewpoint.PaperRWId, strComparisonOp);
}
else
{
objPaperSubViewpointEN.dicFldComparisonOp[conPaperSubViewpoint.PaperRWId] = strComparisonOp;
}
}
return objPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubViewpointEN SetPaperId(this clsPaperSubViewpointEN objPaperSubViewpointEN, string strPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPaperId, conPaperSubViewpoint.PaperId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperId, 8, conPaperSubViewpoint.PaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, conPaperSubViewpoint.PaperId);
}
objPaperSubViewpointEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpoint.PaperId) == false)
{
objPaperSubViewpointEN.dicFldComparisonOp.Add(conPaperSubViewpoint.PaperId, strComparisonOp);
}
else
{
objPaperSubViewpointEN.dicFldComparisonOp[conPaperSubViewpoint.PaperId] = strComparisonOp;
}
}
return objPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubViewpointEN SetIdCurrEduCls(this clsPaperSubViewpointEN objPaperSubViewpointEN, string strIdCurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdCurrEduCls, conPaperSubViewpoint.IdCurrEduCls);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conPaperSubViewpoint.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conPaperSubViewpoint.IdCurrEduCls);
}
objPaperSubViewpointEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpoint.IdCurrEduCls) == false)
{
objPaperSubViewpointEN.dicFldComparisonOp.Add(conPaperSubViewpoint.IdCurrEduCls, strComparisonOp);
}
else
{
objPaperSubViewpointEN.dicFldComparisonOp[conPaperSubViewpoint.IdCurrEduCls] = strComparisonOp;
}
}
return objPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubViewpointEN SetUserId(this clsPaperSubViewpointEN objPaperSubViewpointEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, conPaperSubViewpoint.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conPaperSubViewpoint.UserId);
}
objPaperSubViewpointEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpoint.UserId) == false)
{
objPaperSubViewpointEN.dicFldComparisonOp.Add(conPaperSubViewpoint.UserId, strComparisonOp);
}
else
{
objPaperSubViewpointEN.dicFldComparisonOp[conPaperSubViewpoint.UserId] = strComparisonOp;
}
}
return objPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubViewpointEN SetSectionId(this clsPaperSubViewpointEN objPaperSubViewpointEN, string strSectionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionId, 8, conPaperSubViewpoint.SectionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSectionId, 8, conPaperSubViewpoint.SectionId);
}
objPaperSubViewpointEN.SectionId = strSectionId; //节Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpoint.SectionId) == false)
{
objPaperSubViewpointEN.dicFldComparisonOp.Add(conPaperSubViewpoint.SectionId, strComparisonOp);
}
else
{
objPaperSubViewpointEN.dicFldComparisonOp[conPaperSubViewpoint.SectionId] = strComparisonOp;
}
}
return objPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubViewpointEN SetSubViewpointTypeId(this clsPaperSubViewpointEN objPaperSubViewpointEN, string strSubViewpointTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSubViewpointTypeId, conPaperSubViewpoint.SubViewpointTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSubViewpointTypeId, 8, conPaperSubViewpoint.SubViewpointTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSubViewpointTypeId, 8, conPaperSubViewpoint.SubViewpointTypeId);
}
objPaperSubViewpointEN.SubViewpointTypeId = strSubViewpointTypeId; //类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpoint.SubViewpointTypeId) == false)
{
objPaperSubViewpointEN.dicFldComparisonOp.Add(conPaperSubViewpoint.SubViewpointTypeId, strComparisonOp);
}
else
{
objPaperSubViewpointEN.dicFldComparisonOp[conPaperSubViewpoint.SubViewpointTypeId] = strComparisonOp;
}
}
return objPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubViewpointEN SetgsKnowledgeTypeId(this clsPaperSubViewpointEN objPaperSubViewpointEN, string strgsKnowledgeTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strgsKnowledgeTypeId, conPaperSubViewpoint.gsKnowledgeTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strgsKnowledgeTypeId, 2, conPaperSubViewpoint.gsKnowledgeTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strgsKnowledgeTypeId, 2, conPaperSubViewpoint.gsKnowledgeTypeId);
}
objPaperSubViewpointEN.gsKnowledgeTypeId = strgsKnowledgeTypeId; //知识类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpoint.gsKnowledgeTypeId) == false)
{
objPaperSubViewpointEN.dicFldComparisonOp.Add(conPaperSubViewpoint.gsKnowledgeTypeId, strComparisonOp);
}
else
{
objPaperSubViewpointEN.dicFldComparisonOp[conPaperSubViewpoint.gsKnowledgeTypeId] = strComparisonOp;
}
}
return objPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubViewpointEN SetRWTitle(this clsPaperSubViewpointEN objPaperSubViewpointEN, string strRWTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRWTitle, 50, conPaperSubViewpoint.RWTitle);
}
objPaperSubViewpointEN.RWTitle = strRWTitle; //读写标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpoint.RWTitle) == false)
{
objPaperSubViewpointEN.dicFldComparisonOp.Add(conPaperSubViewpoint.RWTitle, strComparisonOp);
}
else
{
objPaperSubViewpointEN.dicFldComparisonOp[conPaperSubViewpoint.RWTitle] = strComparisonOp;
}
}
return objPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubViewpointEN SetExplainTypeId(this clsPaperSubViewpointEN objPaperSubViewpointEN, string strExplainTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExplainTypeId, 2, conPaperSubViewpoint.ExplainTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strExplainTypeId, 2, conPaperSubViewpoint.ExplainTypeId);
}
objPaperSubViewpointEN.ExplainTypeId = strExplainTypeId; //说明类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpoint.ExplainTypeId) == false)
{
objPaperSubViewpointEN.dicFldComparisonOp.Add(conPaperSubViewpoint.ExplainTypeId, strComparisonOp);
}
else
{
objPaperSubViewpointEN.dicFldComparisonOp[conPaperSubViewpoint.ExplainTypeId] = strComparisonOp;
}
}
return objPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubViewpointEN SetExplainContent(this clsPaperSubViewpointEN objPaperSubViewpointEN, string strExplainContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExplainContent, 5000, conPaperSubViewpoint.ExplainContent);
}
objPaperSubViewpointEN.ExplainContent = strExplainContent; //说明内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpoint.ExplainContent) == false)
{
objPaperSubViewpointEN.dicFldComparisonOp.Add(conPaperSubViewpoint.ExplainContent, strComparisonOp);
}
else
{
objPaperSubViewpointEN.dicFldComparisonOp[conPaperSubViewpoint.ExplainContent] = strComparisonOp;
}
}
return objPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubViewpointEN SetIsPublic(this clsPaperSubViewpointEN objPaperSubViewpointEN, bool bolIsPublic, string strComparisonOp="")
	{
objPaperSubViewpointEN.IsPublic = bolIsPublic; //是否公开
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpoint.IsPublic) == false)
{
objPaperSubViewpointEN.dicFldComparisonOp.Add(conPaperSubViewpoint.IsPublic, strComparisonOp);
}
else
{
objPaperSubViewpointEN.dicFldComparisonOp[conPaperSubViewpoint.IsPublic] = strComparisonOp;
}
}
return objPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubViewpointEN SetLiteratureSourcesId(this clsPaperSubViewpointEN objPaperSubViewpointEN, string strLiteratureSourcesId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLiteratureSourcesId, 8, conPaperSubViewpoint.LiteratureSourcesId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strLiteratureSourcesId, 8, conPaperSubViewpoint.LiteratureSourcesId);
}
objPaperSubViewpointEN.LiteratureSourcesId = strLiteratureSourcesId; //文献来源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpoint.LiteratureSourcesId) == false)
{
objPaperSubViewpointEN.dicFldComparisonOp.Add(conPaperSubViewpoint.LiteratureSourcesId, strComparisonOp);
}
else
{
objPaperSubViewpointEN.dicFldComparisonOp[conPaperSubViewpoint.LiteratureSourcesId] = strComparisonOp;
}
}
return objPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubViewpointEN SetOperationTypeId(this clsPaperSubViewpointEN objPaperSubViewpointEN, string strOperationTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOperationTypeId, 4, conPaperSubViewpoint.OperationTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strOperationTypeId, 4, conPaperSubViewpoint.OperationTypeId);
}
objPaperSubViewpointEN.OperationTypeId = strOperationTypeId; //操作类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpoint.OperationTypeId) == false)
{
objPaperSubViewpointEN.dicFldComparisonOp.Add(conPaperSubViewpoint.OperationTypeId, strComparisonOp);
}
else
{
objPaperSubViewpointEN.dicFldComparisonOp[conPaperSubViewpoint.OperationTypeId] = strComparisonOp;
}
}
return objPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubViewpointEN SetLevelId(this clsPaperSubViewpointEN objPaperSubViewpointEN, string strLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLevelId, 2, conPaperSubViewpoint.LevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strLevelId, 2, conPaperSubViewpoint.LevelId);
}
objPaperSubViewpointEN.LevelId = strLevelId; //级别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpoint.LevelId) == false)
{
objPaperSubViewpointEN.dicFldComparisonOp.Add(conPaperSubViewpoint.LevelId, strComparisonOp);
}
else
{
objPaperSubViewpointEN.dicFldComparisonOp[conPaperSubViewpoint.LevelId] = strComparisonOp;
}
}
return objPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubViewpointEN SetConclusion(this clsPaperSubViewpointEN objPaperSubViewpointEN, string strConclusion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConclusion, 5000, conPaperSubViewpoint.Conclusion);
}
objPaperSubViewpointEN.Conclusion = strConclusion; //结论
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpoint.Conclusion) == false)
{
objPaperSubViewpointEN.dicFldComparisonOp.Add(conPaperSubViewpoint.Conclusion, strComparisonOp);
}
else
{
objPaperSubViewpointEN.dicFldComparisonOp[conPaperSubViewpoint.Conclusion] = strComparisonOp;
}
}
return objPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubViewpointEN SetNationality(this clsPaperSubViewpointEN objPaperSubViewpointEN, string strNationality, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strNationality, 50, conPaperSubViewpoint.Nationality);
}
objPaperSubViewpointEN.Nationality = strNationality; //国籍
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpoint.Nationality) == false)
{
objPaperSubViewpointEN.dicFldComparisonOp.Add(conPaperSubViewpoint.Nationality, strComparisonOp);
}
else
{
objPaperSubViewpointEN.dicFldComparisonOp[conPaperSubViewpoint.Nationality] = strComparisonOp;
}
}
return objPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubViewpointEN SetAchievement(this clsPaperSubViewpointEN objPaperSubViewpointEN, string strAchievement, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAchievement, 5000, conPaperSubViewpoint.Achievement);
}
objPaperSubViewpointEN.Achievement = strAchievement; //成就
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpoint.Achievement) == false)
{
objPaperSubViewpointEN.dicFldComparisonOp.Add(conPaperSubViewpoint.Achievement, strComparisonOp);
}
else
{
objPaperSubViewpointEN.dicFldComparisonOp[conPaperSubViewpoint.Achievement] = strComparisonOp;
}
}
return objPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubViewpointEN SetMajor(this clsPaperSubViewpointEN objPaperSubViewpointEN, string strMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajor, 50, conPaperSubViewpoint.Major);
}
objPaperSubViewpointEN.Major = strMajor; //专业
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpoint.Major) == false)
{
objPaperSubViewpointEN.dicFldComparisonOp.Add(conPaperSubViewpoint.Major, strComparisonOp);
}
else
{
objPaperSubViewpointEN.dicFldComparisonOp[conPaperSubViewpoint.Major] = strComparisonOp;
}
}
return objPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubViewpointEN SetWorkUnit(this clsPaperSubViewpointEN objPaperSubViewpointEN, string strWorkUnit, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWorkUnit, 100, conPaperSubViewpoint.WorkUnit);
}
objPaperSubViewpointEN.WorkUnit = strWorkUnit; //工作单位
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpoint.WorkUnit) == false)
{
objPaperSubViewpointEN.dicFldComparisonOp.Add(conPaperSubViewpoint.WorkUnit, strComparisonOp);
}
else
{
objPaperSubViewpointEN.dicFldComparisonOp[conPaperSubViewpoint.WorkUnit] = strComparisonOp;
}
}
return objPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubViewpointEN SetPageNumber(this clsPaperSubViewpointEN objPaperSubViewpointEN, int? intPageNumber, string strComparisonOp="")
	{
objPaperSubViewpointEN.PageNumber = intPageNumber; //页码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpoint.PageNumber) == false)
{
objPaperSubViewpointEN.dicFldComparisonOp.Add(conPaperSubViewpoint.PageNumber, strComparisonOp);
}
else
{
objPaperSubViewpointEN.dicFldComparisonOp[conPaperSubViewpoint.PageNumber] = strComparisonOp;
}
}
return objPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubViewpointEN SetOrderNum(this clsPaperSubViewpointEN objPaperSubViewpointEN, int? intOrderNum, string strComparisonOp="")
	{
objPaperSubViewpointEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpoint.OrderNum) == false)
{
objPaperSubViewpointEN.dicFldComparisonOp.Add(conPaperSubViewpoint.OrderNum, strComparisonOp);
}
else
{
objPaperSubViewpointEN.dicFldComparisonOp[conPaperSubViewpoint.OrderNum] = strComparisonOp;
}
}
return objPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubViewpointEN SetPdfContent(this clsPaperSubViewpointEN objPaperSubViewpointEN, string strPdfContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfContent, 2000, conPaperSubViewpoint.PdfContent);
}
objPaperSubViewpointEN.PdfContent = strPdfContent; //Pdf内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpoint.PdfContent) == false)
{
objPaperSubViewpointEN.dicFldComparisonOp.Add(conPaperSubViewpoint.PdfContent, strComparisonOp);
}
else
{
objPaperSubViewpointEN.dicFldComparisonOp[conPaperSubViewpoint.PdfContent] = strComparisonOp;
}
}
return objPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubViewpointEN SetselectSpanRange(this clsPaperSubViewpointEN objPaperSubViewpointEN, string strselectSpanRange, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strselectSpanRange, 50, conPaperSubViewpoint.selectSpanRange);
}
objPaperSubViewpointEN.selectSpanRange = strselectSpanRange; //选择Span范围
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpoint.selectSpanRange) == false)
{
objPaperSubViewpointEN.dicFldComparisonOp.Add(conPaperSubViewpoint.selectSpanRange, strComparisonOp);
}
else
{
objPaperSubViewpointEN.dicFldComparisonOp[conPaperSubViewpoint.selectSpanRange] = strComparisonOp;
}
}
return objPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubViewpointEN SetPaperLineNum(this clsPaperSubViewpointEN objPaperSubViewpointEN, int? intPaperLineNum, string strComparisonOp="")
	{
objPaperSubViewpointEN.PaperLineNum = intPaperLineNum; //论文行号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpoint.PaperLineNum) == false)
{
objPaperSubViewpointEN.dicFldComparisonOp.Add(conPaperSubViewpoint.PaperLineNum, strComparisonOp);
}
else
{
objPaperSubViewpointEN.dicFldComparisonOp[conPaperSubViewpoint.PaperLineNum] = strComparisonOp;
}
}
return objPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubViewpointEN SetPaperPageNum(this clsPaperSubViewpointEN objPaperSubViewpointEN, int? intPaperPageNum, string strComparisonOp="")
	{
objPaperSubViewpointEN.PaperPageNum = intPaperPageNum; //论文页码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpoint.PaperPageNum) == false)
{
objPaperSubViewpointEN.dicFldComparisonOp.Add(conPaperSubViewpoint.PaperPageNum, strComparisonOp);
}
else
{
objPaperSubViewpointEN.dicFldComparisonOp[conPaperSubViewpoint.PaperPageNum] = strComparisonOp;
}
}
return objPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubViewpointEN SetAppraiseCount(this clsPaperSubViewpointEN objPaperSubViewpointEN, int? intAppraiseCount, string strComparisonOp="")
	{
objPaperSubViewpointEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpoint.AppraiseCount) == false)
{
objPaperSubViewpointEN.dicFldComparisonOp.Add(conPaperSubViewpoint.AppraiseCount, strComparisonOp);
}
else
{
objPaperSubViewpointEN.dicFldComparisonOp[conPaperSubViewpoint.AppraiseCount] = strComparisonOp;
}
}
return objPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubViewpointEN SetOkCount(this clsPaperSubViewpointEN objPaperSubViewpointEN, int? intOkCount, string strComparisonOp="")
	{
objPaperSubViewpointEN.OkCount = intOkCount; //点赞统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpoint.OkCount) == false)
{
objPaperSubViewpointEN.dicFldComparisonOp.Add(conPaperSubViewpoint.OkCount, strComparisonOp);
}
else
{
objPaperSubViewpointEN.dicFldComparisonOp[conPaperSubViewpoint.OkCount] = strComparisonOp;
}
}
return objPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubViewpointEN SetScore(this clsPaperSubViewpointEN objPaperSubViewpointEN, float? fltScore, string strComparisonOp="")
	{
objPaperSubViewpointEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpoint.Score) == false)
{
objPaperSubViewpointEN.dicFldComparisonOp.Add(conPaperSubViewpoint.Score, strComparisonOp);
}
else
{
objPaperSubViewpointEN.dicFldComparisonOp[conPaperSubViewpoint.Score] = strComparisonOp;
}
}
return objPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubViewpointEN SetStuScore(this clsPaperSubViewpointEN objPaperSubViewpointEN, float? fltStuScore, string strComparisonOp="")
	{
objPaperSubViewpointEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpoint.StuScore) == false)
{
objPaperSubViewpointEN.dicFldComparisonOp.Add(conPaperSubViewpoint.StuScore, strComparisonOp);
}
else
{
objPaperSubViewpointEN.dicFldComparisonOp[conPaperSubViewpoint.StuScore] = strComparisonOp;
}
}
return objPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubViewpointEN SetTeaScore(this clsPaperSubViewpointEN objPaperSubViewpointEN, float? fltTeaScore, string strComparisonOp="")
	{
objPaperSubViewpointEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpoint.TeaScore) == false)
{
objPaperSubViewpointEN.dicFldComparisonOp.Add(conPaperSubViewpoint.TeaScore, strComparisonOp);
}
else
{
objPaperSubViewpointEN.dicFldComparisonOp[conPaperSubViewpoint.TeaScore] = strComparisonOp;
}
}
return objPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubViewpointEN SetCreateDate(this clsPaperSubViewpointEN objPaperSubViewpointEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, conPaperSubViewpoint.CreateDate);
}
objPaperSubViewpointEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpoint.CreateDate) == false)
{
objPaperSubViewpointEN.dicFldComparisonOp.Add(conPaperSubViewpoint.CreateDate, strComparisonOp);
}
else
{
objPaperSubViewpointEN.dicFldComparisonOp[conPaperSubViewpoint.CreateDate] = strComparisonOp;
}
}
return objPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubViewpointEN SetShareId(this clsPaperSubViewpointEN objPaperSubViewpointEN, string strShareId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strShareId, conPaperSubViewpoint.ShareId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strShareId, 2, conPaperSubViewpoint.ShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strShareId, 2, conPaperSubViewpoint.ShareId);
}
objPaperSubViewpointEN.ShareId = strShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpoint.ShareId) == false)
{
objPaperSubViewpointEN.dicFldComparisonOp.Add(conPaperSubViewpoint.ShareId, strComparisonOp);
}
else
{
objPaperSubViewpointEN.dicFldComparisonOp[conPaperSubViewpoint.ShareId] = strComparisonOp;
}
}
return objPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubViewpointEN SetTopicId(this clsPaperSubViewpointEN objPaperSubViewpointEN, string strTopicId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicId, 8, conPaperSubViewpoint.TopicId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTopicId, 8, conPaperSubViewpoint.TopicId);
}
objPaperSubViewpointEN.TopicId = strTopicId; //主题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpoint.TopicId) == false)
{
objPaperSubViewpointEN.dicFldComparisonOp.Add(conPaperSubViewpoint.TopicId, strComparisonOp);
}
else
{
objPaperSubViewpointEN.dicFldComparisonOp[conPaperSubViewpoint.TopicId] = strComparisonOp;
}
}
return objPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubViewpointEN SetAttitudesId(this clsPaperSubViewpointEN objPaperSubViewpointEN, string strAttitudesId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAttitudesId, 2, conPaperSubViewpoint.AttitudesId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAttitudesId, 2, conPaperSubViewpoint.AttitudesId);
}
objPaperSubViewpointEN.AttitudesId = strAttitudesId; //态度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpoint.AttitudesId) == false)
{
objPaperSubViewpointEN.dicFldComparisonOp.Add(conPaperSubViewpoint.AttitudesId, strComparisonOp);
}
else
{
objPaperSubViewpointEN.dicFldComparisonOp[conPaperSubViewpoint.AttitudesId] = strComparisonOp;
}
}
return objPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubViewpointEN SetVersionCount(this clsPaperSubViewpointEN objPaperSubViewpointEN, int? intVersionCount, string strComparisonOp="")
	{
objPaperSubViewpointEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpoint.VersionCount) == false)
{
objPaperSubViewpointEN.dicFldComparisonOp.Add(conPaperSubViewpoint.VersionCount, strComparisonOp);
}
else
{
objPaperSubViewpointEN.dicFldComparisonOp[conPaperSubViewpoint.VersionCount] = strComparisonOp;
}
}
return objPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubViewpointEN SetCitationCount(this clsPaperSubViewpointEN objPaperSubViewpointEN, int? intCitationCount, string strComparisonOp="")
	{
objPaperSubViewpointEN.CitationCount = intCitationCount; //引用统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpoint.CitationCount) == false)
{
objPaperSubViewpointEN.dicFldComparisonOp.Add(conPaperSubViewpoint.CitationCount, strComparisonOp);
}
else
{
objPaperSubViewpointEN.dicFldComparisonOp[conPaperSubViewpoint.CitationCount] = strComparisonOp;
}
}
return objPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubViewpointEN SetCourseId(this clsPaperSubViewpointEN objPaperSubViewpointEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, conPaperSubViewpoint.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, conPaperSubViewpoint.CourseId);
}
objPaperSubViewpointEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpoint.CourseId) == false)
{
objPaperSubViewpointEN.dicFldComparisonOp.Add(conPaperSubViewpoint.CourseId, strComparisonOp);
}
else
{
objPaperSubViewpointEN.dicFldComparisonOp[conPaperSubViewpoint.CourseId] = strComparisonOp;
}
}
return objPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubViewpointEN SetIsRecommend(this clsPaperSubViewpointEN objPaperSubViewpointEN, bool bolIsRecommend, string strComparisonOp="")
	{
objPaperSubViewpointEN.IsRecommend = bolIsRecommend; //是否推荐
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpoint.IsRecommend) == false)
{
objPaperSubViewpointEN.dicFldComparisonOp.Add(conPaperSubViewpoint.IsRecommend, strComparisonOp);
}
else
{
objPaperSubViewpointEN.dicFldComparisonOp[conPaperSubViewpoint.IsRecommend] = strComparisonOp;
}
}
return objPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubViewpointEN SetUpdDate(this clsPaperSubViewpointEN objPaperSubViewpointEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conPaperSubViewpoint.UpdDate);
}
objPaperSubViewpointEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpoint.UpdDate) == false)
{
objPaperSubViewpointEN.dicFldComparisonOp.Add(conPaperSubViewpoint.UpdDate, strComparisonOp);
}
else
{
objPaperSubViewpointEN.dicFldComparisonOp[conPaperSubViewpoint.UpdDate] = strComparisonOp;
}
}
return objPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubViewpointEN SetUpdUser(this clsPaperSubViewpointEN objPaperSubViewpointEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conPaperSubViewpoint.UpdUser);
}
objPaperSubViewpointEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpoint.UpdUser) == false)
{
objPaperSubViewpointEN.dicFldComparisonOp.Add(conPaperSubViewpoint.UpdUser, strComparisonOp);
}
else
{
objPaperSubViewpointEN.dicFldComparisonOp[conPaperSubViewpoint.UpdUser] = strComparisonOp;
}
}
return objPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubViewpointEN SetMemo(this clsPaperSubViewpointEN objPaperSubViewpointEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conPaperSubViewpoint.Memo);
}
objPaperSubViewpointEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpoint.Memo) == false)
{
objPaperSubViewpointEN.dicFldComparisonOp.Add(conPaperSubViewpoint.Memo, strComparisonOp);
}
else
{
objPaperSubViewpointEN.dicFldComparisonOp[conPaperSubViewpoint.Memo] = strComparisonOp;
}
}
return objPaperSubViewpointEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsPaperSubViewpointEN objPaperSubViewpointEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objPaperSubViewpointEN.CheckPropertyNew();
clsPaperSubViewpointEN objPaperSubViewpointCond = new clsPaperSubViewpointEN();
string strCondition = objPaperSubViewpointCond
.SetSubViewpointId(objPaperSubViewpointEN.SubViewpointId, "<>")
.SetPaperId(objPaperSubViewpointEN.PaperId, "=")
.SetSubViewpointTypeId(objPaperSubViewpointEN.SubViewpointTypeId, "=")
.SetUserId(objPaperSubViewpointEN.UserId, "=")
.SetSubViewpointContent(objPaperSubViewpointEN.SubViewpointContent, "=")
.GetCombineCondition();
objPaperSubViewpointEN._IsCheckProperty = true;
bool bolIsExist = clsPaperSubViewpointBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(PaperId_SubViewpointTypeId_UserId_SubViewpointContent)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objPaperSubViewpointEN.Update();
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
 /// <param name = "objPaperSubViewpoint">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsPaperSubViewpointEN objPaperSubViewpoint)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsPaperSubViewpointEN objPaperSubViewpointCond = new clsPaperSubViewpointEN();
string strCondition = objPaperSubViewpointCond
.SetPaperId(objPaperSubViewpoint.PaperId, "=")
.SetSubViewpointTypeId(objPaperSubViewpoint.SubViewpointTypeId, "=")
.SetUserId(objPaperSubViewpoint.UserId, "=")
.SetSubViewpointContent(objPaperSubViewpoint.SubViewpointContent, "=")
.GetCombineCondition();
objPaperSubViewpoint._IsCheckProperty = true;
bool bolIsExist = clsPaperSubViewpointBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objPaperSubViewpoint.SubViewpointId = clsPaperSubViewpointBL.GetFirstID_S(strCondition);
objPaperSubViewpoint.UpdateWithCondition(strCondition);
}
else
{
objPaperSubViewpoint.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPaperSubViewpointEN objPaperSubViewpointEN)
{
 if (objPaperSubViewpointEN.SubViewpointId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPaperSubViewpointBL.PaperSubViewpointDA.UpdateBySql2(objPaperSubViewpointEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubViewpointBL.ReFreshCache(objPaperSubViewpointEN.IdCurrEduCls);

if (clsPaperSubViewpointBL.relatedActions != null)
{
clsPaperSubViewpointBL.relatedActions.UpdRelaTabDate(objPaperSubViewpointEN.SubViewpointId, "SetUpdDate");
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
 /// <param name = "objPaperSubViewpointEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPaperSubViewpointEN objPaperSubViewpointEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objPaperSubViewpointEN.SubViewpointId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPaperSubViewpointBL.PaperSubViewpointDA.UpdateBySql2(objPaperSubViewpointEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubViewpointBL.ReFreshCache(objPaperSubViewpointEN.IdCurrEduCls);

if (clsPaperSubViewpointBL.relatedActions != null)
{
clsPaperSubViewpointBL.relatedActions.UpdRelaTabDate(objPaperSubViewpointEN.SubViewpointId, "SetUpdDate");
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
 /// <param name = "objPaperSubViewpointEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPaperSubViewpointEN objPaperSubViewpointEN, string strWhereCond)
{
try
{
bool bolResult = clsPaperSubViewpointBL.PaperSubViewpointDA.UpdateBySqlWithCondition(objPaperSubViewpointEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubViewpointBL.ReFreshCache(objPaperSubViewpointEN.IdCurrEduCls);

if (clsPaperSubViewpointBL.relatedActions != null)
{
clsPaperSubViewpointBL.relatedActions.UpdRelaTabDate(objPaperSubViewpointEN.SubViewpointId, "SetUpdDate");
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
 /// <param name = "objPaperSubViewpointEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPaperSubViewpointEN objPaperSubViewpointEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsPaperSubViewpointBL.PaperSubViewpointDA.UpdateBySqlWithConditionTransaction(objPaperSubViewpointEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubViewpointBL.ReFreshCache(objPaperSubViewpointEN.IdCurrEduCls);

if (clsPaperSubViewpointBL.relatedActions != null)
{
clsPaperSubViewpointBL.relatedActions.UpdRelaTabDate(objPaperSubViewpointEN.SubViewpointId, "SetUpdDate");
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
 /// <param name = "lngSubViewpointId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsPaperSubViewpointEN objPaperSubViewpointEN)
{
try
{
int intRecNum = clsPaperSubViewpointBL.PaperSubViewpointDA.DelRecord(objPaperSubViewpointEN.SubViewpointId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubViewpointBL.ReFreshCache(objPaperSubViewpointEN.IdCurrEduCls);

if (clsPaperSubViewpointBL.relatedActions != null)
{
clsPaperSubViewpointBL.relatedActions.UpdRelaTabDate(objPaperSubViewpointEN.SubViewpointId, "SetUpdDate");
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
 /// <param name = "objPaperSubViewpointENS">源对象</param>
 /// <param name = "objPaperSubViewpointENT">目标对象</param>
 public static void CopyTo(this clsPaperSubViewpointEN objPaperSubViewpointENS, clsPaperSubViewpointEN objPaperSubViewpointENT)
{
try
{
objPaperSubViewpointENT.SubViewpointId = objPaperSubViewpointENS.SubViewpointId; //子观点Id
objPaperSubViewpointENT.SubViewpointContent = objPaperSubViewpointENS.SubViewpointContent; //详情内容
objPaperSubViewpointENT.PaperRWId = objPaperSubViewpointENS.PaperRWId; //课文阅读
objPaperSubViewpointENT.PaperId = objPaperSubViewpointENS.PaperId; //论文Id
objPaperSubViewpointENT.IdCurrEduCls = objPaperSubViewpointENS.IdCurrEduCls; //教学班流水号
objPaperSubViewpointENT.UserId = objPaperSubViewpointENS.UserId; //用户ID
objPaperSubViewpointENT.SectionId = objPaperSubViewpointENS.SectionId; //节Id
objPaperSubViewpointENT.SubViewpointTypeId = objPaperSubViewpointENS.SubViewpointTypeId; //类型Id
objPaperSubViewpointENT.gsKnowledgeTypeId = objPaperSubViewpointENS.gsKnowledgeTypeId; //知识类型Id
objPaperSubViewpointENT.RWTitle = objPaperSubViewpointENS.RWTitle; //读写标题
objPaperSubViewpointENT.ExplainTypeId = objPaperSubViewpointENS.ExplainTypeId; //说明类型Id
objPaperSubViewpointENT.ExplainContent = objPaperSubViewpointENS.ExplainContent; //说明内容
objPaperSubViewpointENT.IsPublic = objPaperSubViewpointENS.IsPublic; //是否公开
objPaperSubViewpointENT.LiteratureSourcesId = objPaperSubViewpointENS.LiteratureSourcesId; //文献来源
objPaperSubViewpointENT.OperationTypeId = objPaperSubViewpointENS.OperationTypeId; //操作类型ID
objPaperSubViewpointENT.LevelId = objPaperSubViewpointENS.LevelId; //级别Id
objPaperSubViewpointENT.Conclusion = objPaperSubViewpointENS.Conclusion; //结论
objPaperSubViewpointENT.Nationality = objPaperSubViewpointENS.Nationality; //国籍
objPaperSubViewpointENT.Achievement = objPaperSubViewpointENS.Achievement; //成就
objPaperSubViewpointENT.Major = objPaperSubViewpointENS.Major; //专业
objPaperSubViewpointENT.WorkUnit = objPaperSubViewpointENS.WorkUnit; //工作单位
objPaperSubViewpointENT.PageNumber = objPaperSubViewpointENS.PageNumber; //页码
objPaperSubViewpointENT.OrderNum = objPaperSubViewpointENS.OrderNum; //序号
objPaperSubViewpointENT.PdfContent = objPaperSubViewpointENS.PdfContent; //Pdf内容
objPaperSubViewpointENT.selectSpanRange = objPaperSubViewpointENS.selectSpanRange; //选择Span范围
objPaperSubViewpointENT.PaperLineNum = objPaperSubViewpointENS.PaperLineNum; //论文行号
objPaperSubViewpointENT.PaperPageNum = objPaperSubViewpointENS.PaperPageNum; //论文页码
objPaperSubViewpointENT.AppraiseCount = objPaperSubViewpointENS.AppraiseCount; //评论数
objPaperSubViewpointENT.OkCount = objPaperSubViewpointENS.OkCount; //点赞统计
objPaperSubViewpointENT.Score = objPaperSubViewpointENS.Score; //评分
objPaperSubViewpointENT.StuScore = objPaperSubViewpointENS.StuScore; //学生平均分
objPaperSubViewpointENT.TeaScore = objPaperSubViewpointENS.TeaScore; //教师评分
objPaperSubViewpointENT.CreateDate = objPaperSubViewpointENS.CreateDate; //建立日期
objPaperSubViewpointENT.ShareId = objPaperSubViewpointENS.ShareId; //分享Id
objPaperSubViewpointENT.TopicId = objPaperSubViewpointENS.TopicId; //主题Id
objPaperSubViewpointENT.AttitudesId = objPaperSubViewpointENS.AttitudesId; //态度Id
objPaperSubViewpointENT.VersionCount = objPaperSubViewpointENS.VersionCount; //版本统计
objPaperSubViewpointENT.CitationCount = objPaperSubViewpointENS.CitationCount; //引用统计
objPaperSubViewpointENT.CourseId = objPaperSubViewpointENS.CourseId; //课程Id
objPaperSubViewpointENT.IsRecommend = objPaperSubViewpointENS.IsRecommend; //是否推荐
objPaperSubViewpointENT.UpdDate = objPaperSubViewpointENS.UpdDate; //修改日期
objPaperSubViewpointENT.UpdUser = objPaperSubViewpointENS.UpdUser; //修改人
objPaperSubViewpointENT.Memo = objPaperSubViewpointENS.Memo; //备注
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
 /// <param name = "objPaperSubViewpointENS">源对象</param>
 /// <returns>目标对象=>clsPaperSubViewpointEN:objPaperSubViewpointENT</returns>
 public static clsPaperSubViewpointEN CopyTo(this clsPaperSubViewpointEN objPaperSubViewpointENS)
{
try
{
 clsPaperSubViewpointEN objPaperSubViewpointENT = new clsPaperSubViewpointEN()
{
SubViewpointId = objPaperSubViewpointENS.SubViewpointId, //子观点Id
SubViewpointContent = objPaperSubViewpointENS.SubViewpointContent, //详情内容
PaperRWId = objPaperSubViewpointENS.PaperRWId, //课文阅读
PaperId = objPaperSubViewpointENS.PaperId, //论文Id
IdCurrEduCls = objPaperSubViewpointENS.IdCurrEduCls, //教学班流水号
UserId = objPaperSubViewpointENS.UserId, //用户ID
SectionId = objPaperSubViewpointENS.SectionId, //节Id
SubViewpointTypeId = objPaperSubViewpointENS.SubViewpointTypeId, //类型Id
gsKnowledgeTypeId = objPaperSubViewpointENS.gsKnowledgeTypeId, //知识类型Id
RWTitle = objPaperSubViewpointENS.RWTitle, //读写标题
ExplainTypeId = objPaperSubViewpointENS.ExplainTypeId, //说明类型Id
ExplainContent = objPaperSubViewpointENS.ExplainContent, //说明内容
IsPublic = objPaperSubViewpointENS.IsPublic, //是否公开
LiteratureSourcesId = objPaperSubViewpointENS.LiteratureSourcesId, //文献来源
OperationTypeId = objPaperSubViewpointENS.OperationTypeId, //操作类型ID
LevelId = objPaperSubViewpointENS.LevelId, //级别Id
Conclusion = objPaperSubViewpointENS.Conclusion, //结论
Nationality = objPaperSubViewpointENS.Nationality, //国籍
Achievement = objPaperSubViewpointENS.Achievement, //成就
Major = objPaperSubViewpointENS.Major, //专业
WorkUnit = objPaperSubViewpointENS.WorkUnit, //工作单位
PageNumber = objPaperSubViewpointENS.PageNumber, //页码
OrderNum = objPaperSubViewpointENS.OrderNum, //序号
PdfContent = objPaperSubViewpointENS.PdfContent, //Pdf内容
selectSpanRange = objPaperSubViewpointENS.selectSpanRange, //选择Span范围
PaperLineNum = objPaperSubViewpointENS.PaperLineNum, //论文行号
PaperPageNum = objPaperSubViewpointENS.PaperPageNum, //论文页码
AppraiseCount = objPaperSubViewpointENS.AppraiseCount, //评论数
OkCount = objPaperSubViewpointENS.OkCount, //点赞统计
Score = objPaperSubViewpointENS.Score, //评分
StuScore = objPaperSubViewpointENS.StuScore, //学生平均分
TeaScore = objPaperSubViewpointENS.TeaScore, //教师评分
CreateDate = objPaperSubViewpointENS.CreateDate, //建立日期
ShareId = objPaperSubViewpointENS.ShareId, //分享Id
TopicId = objPaperSubViewpointENS.TopicId, //主题Id
AttitudesId = objPaperSubViewpointENS.AttitudesId, //态度Id
VersionCount = objPaperSubViewpointENS.VersionCount, //版本统计
CitationCount = objPaperSubViewpointENS.CitationCount, //引用统计
CourseId = objPaperSubViewpointENS.CourseId, //课程Id
IsRecommend = objPaperSubViewpointENS.IsRecommend, //是否推荐
UpdDate = objPaperSubViewpointENS.UpdDate, //修改日期
UpdUser = objPaperSubViewpointENS.UpdUser, //修改人
Memo = objPaperSubViewpointENS.Memo, //备注
};
 return objPaperSubViewpointENT;
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
public static void CheckPropertyNew(this clsPaperSubViewpointEN objPaperSubViewpointEN)
{
 clsPaperSubViewpointBL.PaperSubViewpointDA.CheckPropertyNew(objPaperSubViewpointEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsPaperSubViewpointEN objPaperSubViewpointEN)
{
 clsPaperSubViewpointBL.PaperSubViewpointDA.CheckProperty4Condition(objPaperSubViewpointEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsPaperSubViewpointEN objPaperSubViewpointCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objPaperSubViewpointCond.IsUpdated(conPaperSubViewpoint.SubViewpointId) == true)
{
string strComparisonOpSubViewpointId = objPaperSubViewpointCond.dicFldComparisonOp[conPaperSubViewpoint.SubViewpointId];
strWhereCond += string.Format(" And {0} {2} {1}", conPaperSubViewpoint.SubViewpointId, objPaperSubViewpointCond.SubViewpointId, strComparisonOpSubViewpointId);
}
if (objPaperSubViewpointCond.IsUpdated(conPaperSubViewpoint.SubViewpointContent) == true)
{
string strComparisonOpSubViewpointContent = objPaperSubViewpointCond.dicFldComparisonOp[conPaperSubViewpoint.SubViewpointContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubViewpoint.SubViewpointContent, objPaperSubViewpointCond.SubViewpointContent, strComparisonOpSubViewpointContent);
}
if (objPaperSubViewpointCond.IsUpdated(conPaperSubViewpoint.PaperRWId) == true)
{
string strComparisonOpPaperRWId = objPaperSubViewpointCond.dicFldComparisonOp[conPaperSubViewpoint.PaperRWId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubViewpoint.PaperRWId, objPaperSubViewpointCond.PaperRWId, strComparisonOpPaperRWId);
}
if (objPaperSubViewpointCond.IsUpdated(conPaperSubViewpoint.PaperId) == true)
{
string strComparisonOpPaperId = objPaperSubViewpointCond.dicFldComparisonOp[conPaperSubViewpoint.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubViewpoint.PaperId, objPaperSubViewpointCond.PaperId, strComparisonOpPaperId);
}
if (objPaperSubViewpointCond.IsUpdated(conPaperSubViewpoint.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objPaperSubViewpointCond.dicFldComparisonOp[conPaperSubViewpoint.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubViewpoint.IdCurrEduCls, objPaperSubViewpointCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objPaperSubViewpointCond.IsUpdated(conPaperSubViewpoint.UserId) == true)
{
string strComparisonOpUserId = objPaperSubViewpointCond.dicFldComparisonOp[conPaperSubViewpoint.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubViewpoint.UserId, objPaperSubViewpointCond.UserId, strComparisonOpUserId);
}
if (objPaperSubViewpointCond.IsUpdated(conPaperSubViewpoint.SectionId) == true)
{
string strComparisonOpSectionId = objPaperSubViewpointCond.dicFldComparisonOp[conPaperSubViewpoint.SectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubViewpoint.SectionId, objPaperSubViewpointCond.SectionId, strComparisonOpSectionId);
}
if (objPaperSubViewpointCond.IsUpdated(conPaperSubViewpoint.SubViewpointTypeId) == true)
{
string strComparisonOpSubViewpointTypeId = objPaperSubViewpointCond.dicFldComparisonOp[conPaperSubViewpoint.SubViewpointTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubViewpoint.SubViewpointTypeId, objPaperSubViewpointCond.SubViewpointTypeId, strComparisonOpSubViewpointTypeId);
}
if (objPaperSubViewpointCond.IsUpdated(conPaperSubViewpoint.gsKnowledgeTypeId) == true)
{
string strComparisonOpgsKnowledgeTypeId = objPaperSubViewpointCond.dicFldComparisonOp[conPaperSubViewpoint.gsKnowledgeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubViewpoint.gsKnowledgeTypeId, objPaperSubViewpointCond.gsKnowledgeTypeId, strComparisonOpgsKnowledgeTypeId);
}
if (objPaperSubViewpointCond.IsUpdated(conPaperSubViewpoint.RWTitle) == true)
{
string strComparisonOpRWTitle = objPaperSubViewpointCond.dicFldComparisonOp[conPaperSubViewpoint.RWTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubViewpoint.RWTitle, objPaperSubViewpointCond.RWTitle, strComparisonOpRWTitle);
}
if (objPaperSubViewpointCond.IsUpdated(conPaperSubViewpoint.ExplainTypeId) == true)
{
string strComparisonOpExplainTypeId = objPaperSubViewpointCond.dicFldComparisonOp[conPaperSubViewpoint.ExplainTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubViewpoint.ExplainTypeId, objPaperSubViewpointCond.ExplainTypeId, strComparisonOpExplainTypeId);
}
if (objPaperSubViewpointCond.IsUpdated(conPaperSubViewpoint.ExplainContent) == true)
{
string strComparisonOpExplainContent = objPaperSubViewpointCond.dicFldComparisonOp[conPaperSubViewpoint.ExplainContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubViewpoint.ExplainContent, objPaperSubViewpointCond.ExplainContent, strComparisonOpExplainContent);
}
if (objPaperSubViewpointCond.IsUpdated(conPaperSubViewpoint.IsPublic) == true)
{
if (objPaperSubViewpointCond.IsPublic == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPaperSubViewpoint.IsPublic);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPaperSubViewpoint.IsPublic);
}
}
if (objPaperSubViewpointCond.IsUpdated(conPaperSubViewpoint.LiteratureSourcesId) == true)
{
string strComparisonOpLiteratureSourcesId = objPaperSubViewpointCond.dicFldComparisonOp[conPaperSubViewpoint.LiteratureSourcesId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubViewpoint.LiteratureSourcesId, objPaperSubViewpointCond.LiteratureSourcesId, strComparisonOpLiteratureSourcesId);
}
if (objPaperSubViewpointCond.IsUpdated(conPaperSubViewpoint.OperationTypeId) == true)
{
string strComparisonOpOperationTypeId = objPaperSubViewpointCond.dicFldComparisonOp[conPaperSubViewpoint.OperationTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubViewpoint.OperationTypeId, objPaperSubViewpointCond.OperationTypeId, strComparisonOpOperationTypeId);
}
if (objPaperSubViewpointCond.IsUpdated(conPaperSubViewpoint.LevelId) == true)
{
string strComparisonOpLevelId = objPaperSubViewpointCond.dicFldComparisonOp[conPaperSubViewpoint.LevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubViewpoint.LevelId, objPaperSubViewpointCond.LevelId, strComparisonOpLevelId);
}
if (objPaperSubViewpointCond.IsUpdated(conPaperSubViewpoint.Conclusion) == true)
{
string strComparisonOpConclusion = objPaperSubViewpointCond.dicFldComparisonOp[conPaperSubViewpoint.Conclusion];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubViewpoint.Conclusion, objPaperSubViewpointCond.Conclusion, strComparisonOpConclusion);
}
if (objPaperSubViewpointCond.IsUpdated(conPaperSubViewpoint.Nationality) == true)
{
string strComparisonOpNationality = objPaperSubViewpointCond.dicFldComparisonOp[conPaperSubViewpoint.Nationality];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubViewpoint.Nationality, objPaperSubViewpointCond.Nationality, strComparisonOpNationality);
}
if (objPaperSubViewpointCond.IsUpdated(conPaperSubViewpoint.Achievement) == true)
{
string strComparisonOpAchievement = objPaperSubViewpointCond.dicFldComparisonOp[conPaperSubViewpoint.Achievement];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubViewpoint.Achievement, objPaperSubViewpointCond.Achievement, strComparisonOpAchievement);
}
if (objPaperSubViewpointCond.IsUpdated(conPaperSubViewpoint.Major) == true)
{
string strComparisonOpMajor = objPaperSubViewpointCond.dicFldComparisonOp[conPaperSubViewpoint.Major];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubViewpoint.Major, objPaperSubViewpointCond.Major, strComparisonOpMajor);
}
if (objPaperSubViewpointCond.IsUpdated(conPaperSubViewpoint.WorkUnit) == true)
{
string strComparisonOpWorkUnit = objPaperSubViewpointCond.dicFldComparisonOp[conPaperSubViewpoint.WorkUnit];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubViewpoint.WorkUnit, objPaperSubViewpointCond.WorkUnit, strComparisonOpWorkUnit);
}
if (objPaperSubViewpointCond.IsUpdated(conPaperSubViewpoint.PageNumber) == true)
{
string strComparisonOpPageNumber = objPaperSubViewpointCond.dicFldComparisonOp[conPaperSubViewpoint.PageNumber];
strWhereCond += string.Format(" And {0} {2} {1}", conPaperSubViewpoint.PageNumber, objPaperSubViewpointCond.PageNumber, strComparisonOpPageNumber);
}
if (objPaperSubViewpointCond.IsUpdated(conPaperSubViewpoint.OrderNum) == true)
{
string strComparisonOpOrderNum = objPaperSubViewpointCond.dicFldComparisonOp[conPaperSubViewpoint.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conPaperSubViewpoint.OrderNum, objPaperSubViewpointCond.OrderNum, strComparisonOpOrderNum);
}
if (objPaperSubViewpointCond.IsUpdated(conPaperSubViewpoint.PdfContent) == true)
{
string strComparisonOpPdfContent = objPaperSubViewpointCond.dicFldComparisonOp[conPaperSubViewpoint.PdfContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubViewpoint.PdfContent, objPaperSubViewpointCond.PdfContent, strComparisonOpPdfContent);
}
if (objPaperSubViewpointCond.IsUpdated(conPaperSubViewpoint.selectSpanRange) == true)
{
string strComparisonOpselectSpanRange = objPaperSubViewpointCond.dicFldComparisonOp[conPaperSubViewpoint.selectSpanRange];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubViewpoint.selectSpanRange, objPaperSubViewpointCond.selectSpanRange, strComparisonOpselectSpanRange);
}
if (objPaperSubViewpointCond.IsUpdated(conPaperSubViewpoint.PaperLineNum) == true)
{
string strComparisonOpPaperLineNum = objPaperSubViewpointCond.dicFldComparisonOp[conPaperSubViewpoint.PaperLineNum];
strWhereCond += string.Format(" And {0} {2} {1}", conPaperSubViewpoint.PaperLineNum, objPaperSubViewpointCond.PaperLineNum, strComparisonOpPaperLineNum);
}
if (objPaperSubViewpointCond.IsUpdated(conPaperSubViewpoint.PaperPageNum) == true)
{
string strComparisonOpPaperPageNum = objPaperSubViewpointCond.dicFldComparisonOp[conPaperSubViewpoint.PaperPageNum];
strWhereCond += string.Format(" And {0} {2} {1}", conPaperSubViewpoint.PaperPageNum, objPaperSubViewpointCond.PaperPageNum, strComparisonOpPaperPageNum);
}
if (objPaperSubViewpointCond.IsUpdated(conPaperSubViewpoint.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objPaperSubViewpointCond.dicFldComparisonOp[conPaperSubViewpoint.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conPaperSubViewpoint.AppraiseCount, objPaperSubViewpointCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objPaperSubViewpointCond.IsUpdated(conPaperSubViewpoint.OkCount) == true)
{
string strComparisonOpOkCount = objPaperSubViewpointCond.dicFldComparisonOp[conPaperSubViewpoint.OkCount];
strWhereCond += string.Format(" And {0} {2} {1}", conPaperSubViewpoint.OkCount, objPaperSubViewpointCond.OkCount, strComparisonOpOkCount);
}
if (objPaperSubViewpointCond.IsUpdated(conPaperSubViewpoint.Score) == true)
{
string strComparisonOpScore = objPaperSubViewpointCond.dicFldComparisonOp[conPaperSubViewpoint.Score];
strWhereCond += string.Format(" And {0} {2} {1}", conPaperSubViewpoint.Score, objPaperSubViewpointCond.Score, strComparisonOpScore);
}
if (objPaperSubViewpointCond.IsUpdated(conPaperSubViewpoint.StuScore) == true)
{
string strComparisonOpStuScore = objPaperSubViewpointCond.dicFldComparisonOp[conPaperSubViewpoint.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", conPaperSubViewpoint.StuScore, objPaperSubViewpointCond.StuScore, strComparisonOpStuScore);
}
if (objPaperSubViewpointCond.IsUpdated(conPaperSubViewpoint.TeaScore) == true)
{
string strComparisonOpTeaScore = objPaperSubViewpointCond.dicFldComparisonOp[conPaperSubViewpoint.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", conPaperSubViewpoint.TeaScore, objPaperSubViewpointCond.TeaScore, strComparisonOpTeaScore);
}
if (objPaperSubViewpointCond.IsUpdated(conPaperSubViewpoint.CreateDate) == true)
{
string strComparisonOpCreateDate = objPaperSubViewpointCond.dicFldComparisonOp[conPaperSubViewpoint.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubViewpoint.CreateDate, objPaperSubViewpointCond.CreateDate, strComparisonOpCreateDate);
}
if (objPaperSubViewpointCond.IsUpdated(conPaperSubViewpoint.ShareId) == true)
{
string strComparisonOpShareId = objPaperSubViewpointCond.dicFldComparisonOp[conPaperSubViewpoint.ShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubViewpoint.ShareId, objPaperSubViewpointCond.ShareId, strComparisonOpShareId);
}
if (objPaperSubViewpointCond.IsUpdated(conPaperSubViewpoint.TopicId) == true)
{
string strComparisonOpTopicId = objPaperSubViewpointCond.dicFldComparisonOp[conPaperSubViewpoint.TopicId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubViewpoint.TopicId, objPaperSubViewpointCond.TopicId, strComparisonOpTopicId);
}
if (objPaperSubViewpointCond.IsUpdated(conPaperSubViewpoint.AttitudesId) == true)
{
string strComparisonOpAttitudesId = objPaperSubViewpointCond.dicFldComparisonOp[conPaperSubViewpoint.AttitudesId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubViewpoint.AttitudesId, objPaperSubViewpointCond.AttitudesId, strComparisonOpAttitudesId);
}
if (objPaperSubViewpointCond.IsUpdated(conPaperSubViewpoint.VersionCount) == true)
{
string strComparisonOpVersionCount = objPaperSubViewpointCond.dicFldComparisonOp[conPaperSubViewpoint.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", conPaperSubViewpoint.VersionCount, objPaperSubViewpointCond.VersionCount, strComparisonOpVersionCount);
}
if (objPaperSubViewpointCond.IsUpdated(conPaperSubViewpoint.CitationCount) == true)
{
string strComparisonOpCitationCount = objPaperSubViewpointCond.dicFldComparisonOp[conPaperSubViewpoint.CitationCount];
strWhereCond += string.Format(" And {0} {2} {1}", conPaperSubViewpoint.CitationCount, objPaperSubViewpointCond.CitationCount, strComparisonOpCitationCount);
}
if (objPaperSubViewpointCond.IsUpdated(conPaperSubViewpoint.CourseId) == true)
{
string strComparisonOpCourseId = objPaperSubViewpointCond.dicFldComparisonOp[conPaperSubViewpoint.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubViewpoint.CourseId, objPaperSubViewpointCond.CourseId, strComparisonOpCourseId);
}
if (objPaperSubViewpointCond.IsUpdated(conPaperSubViewpoint.IsRecommend) == true)
{
if (objPaperSubViewpointCond.IsRecommend == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPaperSubViewpoint.IsRecommend);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPaperSubViewpoint.IsRecommend);
}
}
if (objPaperSubViewpointCond.IsUpdated(conPaperSubViewpoint.UpdDate) == true)
{
string strComparisonOpUpdDate = objPaperSubViewpointCond.dicFldComparisonOp[conPaperSubViewpoint.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubViewpoint.UpdDate, objPaperSubViewpointCond.UpdDate, strComparisonOpUpdDate);
}
if (objPaperSubViewpointCond.IsUpdated(conPaperSubViewpoint.UpdUser) == true)
{
string strComparisonOpUpdUser = objPaperSubViewpointCond.dicFldComparisonOp[conPaperSubViewpoint.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubViewpoint.UpdUser, objPaperSubViewpointCond.UpdUser, strComparisonOpUpdUser);
}
if (objPaperSubViewpointCond.IsUpdated(conPaperSubViewpoint.Memo) == true)
{
string strComparisonOpMemo = objPaperSubViewpointCond.dicFldComparisonOp[conPaperSubViewpoint.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubViewpoint.Memo, objPaperSubViewpointCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--PaperSubViewpoint(子观点表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:PaperId_SubViewpointTypeId_UserId_SubViewpointContent
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsPaperSubViewpointEN objPaperSubViewpointEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objPaperSubViewpointEN == null) return true;
if (objPaperSubViewpointEN.SubViewpointId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PaperId = '{0}'", objPaperSubViewpointEN.PaperId);
 sbCondition.AppendFormat(" and SubViewpointTypeId = '{0}'", objPaperSubViewpointEN.SubViewpointTypeId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objPaperSubViewpointEN.UserId);
 if (objPaperSubViewpointEN.SubViewpointContent == null)
{
 sbCondition.AppendFormat(" and SubViewpointContent is null", objPaperSubViewpointEN.SubViewpointContent);
}
else
{
 sbCondition.AppendFormat(" and SubViewpointContent = '{0}'", objPaperSubViewpointEN.SubViewpointContent);
}
if (clsPaperSubViewpointBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("SubViewpointId !=  {0}", objPaperSubViewpointEN.SubViewpointId);
 sbCondition.AppendFormat(" and PaperId = '{0}'", objPaperSubViewpointEN.PaperId);
 sbCondition.AppendFormat(" and SubViewpointTypeId = '{0}'", objPaperSubViewpointEN.SubViewpointTypeId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objPaperSubViewpointEN.UserId);
 sbCondition.AppendFormat(" and SubViewpointContent = '{0}'", objPaperSubViewpointEN.SubViewpointContent);
if (clsPaperSubViewpointBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--PaperSubViewpoint(子观点表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PaperId_SubViewpointTypeId_UserId_SubViewpointContent
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsPaperSubViewpointEN objPaperSubViewpointEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objPaperSubViewpointEN == null) return "";
if (objPaperSubViewpointEN.SubViewpointId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PaperId = '{0}'", objPaperSubViewpointEN.PaperId);
 sbCondition.AppendFormat(" and SubViewpointTypeId = '{0}'", objPaperSubViewpointEN.SubViewpointTypeId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objPaperSubViewpointEN.UserId);
 if (objPaperSubViewpointEN.SubViewpointContent == null)
{
 sbCondition.AppendFormat(" and SubViewpointContent is null", objPaperSubViewpointEN.SubViewpointContent);
}
else
{
 sbCondition.AppendFormat(" and SubViewpointContent = '{0}'", objPaperSubViewpointEN.SubViewpointContent);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("SubViewpointId !=  {0}", objPaperSubViewpointEN.SubViewpointId);
 sbCondition.AppendFormat(" and PaperId = '{0}'", objPaperSubViewpointEN.PaperId);
 sbCondition.AppendFormat(" and SubViewpointTypeId = '{0}'", objPaperSubViewpointEN.SubViewpointTypeId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objPaperSubViewpointEN.UserId);
 sbCondition.AppendFormat(" and SubViewpointContent = '{0}'", objPaperSubViewpointEN.SubViewpointContent);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_PaperSubViewpoint
{
public virtual bool UpdRelaTabDate(long lngSubViewpointId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 子观点表(PaperSubViewpoint)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsPaperSubViewpointBL
{
public static RelatedActions_PaperSubViewpoint relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsPaperSubViewpointDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsPaperSubViewpointDA PaperSubViewpointDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsPaperSubViewpointDA();
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
 public clsPaperSubViewpointBL()
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
if (string.IsNullOrEmpty(clsPaperSubViewpointEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsPaperSubViewpointEN._ConnectString);
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
public static DataTable GetDataTable_PaperSubViewpoint(string strWhereCond)
{
DataTable objDT;
try
{
objDT = PaperSubViewpointDA.GetDataTable_PaperSubViewpoint(strWhereCond);
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
objDT = PaperSubViewpointDA.GetDataTable(strWhereCond);
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
objDT = PaperSubViewpointDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = PaperSubViewpointDA.GetDataTable(strWhereCond, strTabName);
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
objDT = PaperSubViewpointDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = PaperSubViewpointDA.GetDataTable_Top(objTopPara);
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
objDT = PaperSubViewpointDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = PaperSubViewpointDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = PaperSubViewpointDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrSubViewpointIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsPaperSubViewpointEN> GetObjLstBySubViewpointIdLst(List<long> arrSubViewpointIdLst)
{
List<clsPaperSubViewpointEN> arrObjLst = new List<clsPaperSubViewpointEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrSubViewpointIdLst);
 string strWhereCond = string.Format("SubViewpointId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperSubViewpointEN objPaperSubViewpointEN = new clsPaperSubViewpointEN();
try
{
objPaperSubViewpointEN.SubViewpointId = Int32.Parse(objRow[conPaperSubViewpoint.SubViewpointId].ToString().Trim()); //子观点Id
objPaperSubViewpointEN.SubViewpointContent = objRow[conPaperSubViewpoint.SubViewpointContent] == DBNull.Value ? null : objRow[conPaperSubViewpoint.SubViewpointContent].ToString().Trim(); //详情内容
objPaperSubViewpointEN.PaperRWId = objRow[conPaperSubViewpoint.PaperRWId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.PaperRWId].ToString().Trim(); //课文阅读
objPaperSubViewpointEN.PaperId = objRow[conPaperSubViewpoint.PaperId].ToString().Trim(); //论文Id
objPaperSubViewpointEN.IdCurrEduCls = objRow[conPaperSubViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperSubViewpointEN.UserId = objRow[conPaperSubViewpoint.UserId].ToString().Trim(); //用户ID
objPaperSubViewpointEN.SectionId = objRow[conPaperSubViewpoint.SectionId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.SectionId].ToString().Trim(); //节Id
objPaperSubViewpointEN.SubViewpointTypeId = objRow[conPaperSubViewpoint.SubViewpointTypeId].ToString().Trim(); //类型Id
objPaperSubViewpointEN.gsKnowledgeTypeId = objRow[conPaperSubViewpoint.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id
objPaperSubViewpointEN.RWTitle = objRow[conPaperSubViewpoint.RWTitle] == DBNull.Value ? null : objRow[conPaperSubViewpoint.RWTitle].ToString().Trim(); //读写标题
objPaperSubViewpointEN.ExplainTypeId = objRow[conPaperSubViewpoint.ExplainTypeId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.ExplainTypeId].ToString().Trim(); //说明类型Id
objPaperSubViewpointEN.ExplainContent = objRow[conPaperSubViewpoint.ExplainContent] == DBNull.Value ? null : objRow[conPaperSubViewpoint.ExplainContent].ToString().Trim(); //说明内容
objPaperSubViewpointEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conPaperSubViewpoint.IsPublic].ToString().Trim()); //是否公开
objPaperSubViewpointEN.LiteratureSourcesId = objRow[conPaperSubViewpoint.LiteratureSourcesId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.LiteratureSourcesId].ToString().Trim(); //文献来源
objPaperSubViewpointEN.OperationTypeId = objRow[conPaperSubViewpoint.OperationTypeId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.OperationTypeId].ToString().Trim(); //操作类型ID
objPaperSubViewpointEN.LevelId = objRow[conPaperSubViewpoint.LevelId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.LevelId].ToString().Trim(); //级别Id
objPaperSubViewpointEN.Conclusion = objRow[conPaperSubViewpoint.Conclusion] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Conclusion].ToString().Trim(); //结论
objPaperSubViewpointEN.Nationality = objRow[conPaperSubViewpoint.Nationality] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Nationality].ToString().Trim(); //国籍
objPaperSubViewpointEN.Achievement = objRow[conPaperSubViewpoint.Achievement] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Achievement].ToString().Trim(); //成就
objPaperSubViewpointEN.Major = objRow[conPaperSubViewpoint.Major] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Major].ToString().Trim(); //专业
objPaperSubViewpointEN.WorkUnit = objRow[conPaperSubViewpoint.WorkUnit] == DBNull.Value ? null : objRow[conPaperSubViewpoint.WorkUnit].ToString().Trim(); //工作单位
objPaperSubViewpointEN.PageNumber = objRow[conPaperSubViewpoint.PageNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.PageNumber].ToString().Trim()); //页码
objPaperSubViewpointEN.OrderNum = objRow[conPaperSubViewpoint.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.OrderNum].ToString().Trim()); //序号
objPaperSubViewpointEN.PdfContent = objRow[conPaperSubViewpoint.PdfContent] == DBNull.Value ? null : objRow[conPaperSubViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objPaperSubViewpointEN.selectSpanRange = objRow[conPaperSubViewpoint.selectSpanRange] == DBNull.Value ? null : objRow[conPaperSubViewpoint.selectSpanRange].ToString().Trim(); //选择Span范围
objPaperSubViewpointEN.PaperLineNum = objRow[conPaperSubViewpoint.PaperLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.PaperLineNum].ToString().Trim()); //论文行号
objPaperSubViewpointEN.PaperPageNum = objRow[conPaperSubViewpoint.PaperPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.PaperPageNum].ToString().Trim()); //论文页码
objPaperSubViewpointEN.AppraiseCount = objRow[conPaperSubViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.AppraiseCount].ToString().Trim()); //评论数
objPaperSubViewpointEN.OkCount = objRow[conPaperSubViewpoint.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.OkCount].ToString().Trim()); //点赞统计
objPaperSubViewpointEN.Score = objRow[conPaperSubViewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaperSubViewpoint.Score].ToString().Trim()); //评分
objPaperSubViewpointEN.StuScore = objRow[conPaperSubViewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaperSubViewpoint.StuScore].ToString().Trim()); //学生平均分
objPaperSubViewpointEN.TeaScore = objRow[conPaperSubViewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaperSubViewpoint.TeaScore].ToString().Trim()); //教师评分
objPaperSubViewpointEN.CreateDate = objRow[conPaperSubViewpoint.CreateDate] == DBNull.Value ? null : objRow[conPaperSubViewpoint.CreateDate].ToString().Trim(); //建立日期
objPaperSubViewpointEN.ShareId = objRow[conPaperSubViewpoint.ShareId].ToString().Trim(); //分享Id
objPaperSubViewpointEN.TopicId = objRow[conPaperSubViewpoint.TopicId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.TopicId].ToString().Trim(); //主题Id
objPaperSubViewpointEN.AttitudesId = objRow[conPaperSubViewpoint.AttitudesId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.AttitudesId].ToString().Trim(); //态度Id
objPaperSubViewpointEN.VersionCount = objRow[conPaperSubViewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.VersionCount].ToString().Trim()); //版本统计
objPaperSubViewpointEN.CitationCount = objRow[conPaperSubViewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.CitationCount].ToString().Trim()); //引用统计
objPaperSubViewpointEN.CourseId = objRow[conPaperSubViewpoint.CourseId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.CourseId].ToString().Trim(); //课程Id
objPaperSubViewpointEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conPaperSubViewpoint.IsRecommend].ToString().Trim()); //是否推荐
objPaperSubViewpointEN.UpdDate = objRow[conPaperSubViewpoint.UpdDate] == DBNull.Value ? null : objRow[conPaperSubViewpoint.UpdDate].ToString().Trim(); //修改日期
objPaperSubViewpointEN.UpdUser = objRow[conPaperSubViewpoint.UpdUser] == DBNull.Value ? null : objRow[conPaperSubViewpoint.UpdUser].ToString().Trim(); //修改人
objPaperSubViewpointEN.Memo = objRow[conPaperSubViewpoint.Memo] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperSubViewpointEN.SubViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperSubViewpointEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrSubViewpointIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsPaperSubViewpointEN> GetObjLstBySubViewpointIdLstCache(List<long> arrSubViewpointIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsPaperSubViewpointEN._CurrTabName, strIdCurrEduCls);
List<clsPaperSubViewpointEN> arrPaperSubViewpointObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsPaperSubViewpointEN> arrPaperSubViewpointObjLst_Sel =
arrPaperSubViewpointObjLstCache
.Where(x => arrSubViewpointIdLst.Contains(x.SubViewpointId));
return arrPaperSubViewpointObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsPaperSubViewpointEN> GetObjLst(string strWhereCond)
{
List<clsPaperSubViewpointEN> arrObjLst = new List<clsPaperSubViewpointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperSubViewpointEN objPaperSubViewpointEN = new clsPaperSubViewpointEN();
try
{
objPaperSubViewpointEN.SubViewpointId = Int32.Parse(objRow[conPaperSubViewpoint.SubViewpointId].ToString().Trim()); //子观点Id
objPaperSubViewpointEN.SubViewpointContent = objRow[conPaperSubViewpoint.SubViewpointContent] == DBNull.Value ? null : objRow[conPaperSubViewpoint.SubViewpointContent].ToString().Trim(); //详情内容
objPaperSubViewpointEN.PaperRWId = objRow[conPaperSubViewpoint.PaperRWId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.PaperRWId].ToString().Trim(); //课文阅读
objPaperSubViewpointEN.PaperId = objRow[conPaperSubViewpoint.PaperId].ToString().Trim(); //论文Id
objPaperSubViewpointEN.IdCurrEduCls = objRow[conPaperSubViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperSubViewpointEN.UserId = objRow[conPaperSubViewpoint.UserId].ToString().Trim(); //用户ID
objPaperSubViewpointEN.SectionId = objRow[conPaperSubViewpoint.SectionId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.SectionId].ToString().Trim(); //节Id
objPaperSubViewpointEN.SubViewpointTypeId = objRow[conPaperSubViewpoint.SubViewpointTypeId].ToString().Trim(); //类型Id
objPaperSubViewpointEN.gsKnowledgeTypeId = objRow[conPaperSubViewpoint.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id
objPaperSubViewpointEN.RWTitle = objRow[conPaperSubViewpoint.RWTitle] == DBNull.Value ? null : objRow[conPaperSubViewpoint.RWTitle].ToString().Trim(); //读写标题
objPaperSubViewpointEN.ExplainTypeId = objRow[conPaperSubViewpoint.ExplainTypeId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.ExplainTypeId].ToString().Trim(); //说明类型Id
objPaperSubViewpointEN.ExplainContent = objRow[conPaperSubViewpoint.ExplainContent] == DBNull.Value ? null : objRow[conPaperSubViewpoint.ExplainContent].ToString().Trim(); //说明内容
objPaperSubViewpointEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conPaperSubViewpoint.IsPublic].ToString().Trim()); //是否公开
objPaperSubViewpointEN.LiteratureSourcesId = objRow[conPaperSubViewpoint.LiteratureSourcesId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.LiteratureSourcesId].ToString().Trim(); //文献来源
objPaperSubViewpointEN.OperationTypeId = objRow[conPaperSubViewpoint.OperationTypeId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.OperationTypeId].ToString().Trim(); //操作类型ID
objPaperSubViewpointEN.LevelId = objRow[conPaperSubViewpoint.LevelId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.LevelId].ToString().Trim(); //级别Id
objPaperSubViewpointEN.Conclusion = objRow[conPaperSubViewpoint.Conclusion] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Conclusion].ToString().Trim(); //结论
objPaperSubViewpointEN.Nationality = objRow[conPaperSubViewpoint.Nationality] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Nationality].ToString().Trim(); //国籍
objPaperSubViewpointEN.Achievement = objRow[conPaperSubViewpoint.Achievement] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Achievement].ToString().Trim(); //成就
objPaperSubViewpointEN.Major = objRow[conPaperSubViewpoint.Major] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Major].ToString().Trim(); //专业
objPaperSubViewpointEN.WorkUnit = objRow[conPaperSubViewpoint.WorkUnit] == DBNull.Value ? null : objRow[conPaperSubViewpoint.WorkUnit].ToString().Trim(); //工作单位
objPaperSubViewpointEN.PageNumber = objRow[conPaperSubViewpoint.PageNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.PageNumber].ToString().Trim()); //页码
objPaperSubViewpointEN.OrderNum = objRow[conPaperSubViewpoint.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.OrderNum].ToString().Trim()); //序号
objPaperSubViewpointEN.PdfContent = objRow[conPaperSubViewpoint.PdfContent] == DBNull.Value ? null : objRow[conPaperSubViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objPaperSubViewpointEN.selectSpanRange = objRow[conPaperSubViewpoint.selectSpanRange] == DBNull.Value ? null : objRow[conPaperSubViewpoint.selectSpanRange].ToString().Trim(); //选择Span范围
objPaperSubViewpointEN.PaperLineNum = objRow[conPaperSubViewpoint.PaperLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.PaperLineNum].ToString().Trim()); //论文行号
objPaperSubViewpointEN.PaperPageNum = objRow[conPaperSubViewpoint.PaperPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.PaperPageNum].ToString().Trim()); //论文页码
objPaperSubViewpointEN.AppraiseCount = objRow[conPaperSubViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.AppraiseCount].ToString().Trim()); //评论数
objPaperSubViewpointEN.OkCount = objRow[conPaperSubViewpoint.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.OkCount].ToString().Trim()); //点赞统计
objPaperSubViewpointEN.Score = objRow[conPaperSubViewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaperSubViewpoint.Score].ToString().Trim()); //评分
objPaperSubViewpointEN.StuScore = objRow[conPaperSubViewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaperSubViewpoint.StuScore].ToString().Trim()); //学生平均分
objPaperSubViewpointEN.TeaScore = objRow[conPaperSubViewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaperSubViewpoint.TeaScore].ToString().Trim()); //教师评分
objPaperSubViewpointEN.CreateDate = objRow[conPaperSubViewpoint.CreateDate] == DBNull.Value ? null : objRow[conPaperSubViewpoint.CreateDate].ToString().Trim(); //建立日期
objPaperSubViewpointEN.ShareId = objRow[conPaperSubViewpoint.ShareId].ToString().Trim(); //分享Id
objPaperSubViewpointEN.TopicId = objRow[conPaperSubViewpoint.TopicId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.TopicId].ToString().Trim(); //主题Id
objPaperSubViewpointEN.AttitudesId = objRow[conPaperSubViewpoint.AttitudesId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.AttitudesId].ToString().Trim(); //态度Id
objPaperSubViewpointEN.VersionCount = objRow[conPaperSubViewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.VersionCount].ToString().Trim()); //版本统计
objPaperSubViewpointEN.CitationCount = objRow[conPaperSubViewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.CitationCount].ToString().Trim()); //引用统计
objPaperSubViewpointEN.CourseId = objRow[conPaperSubViewpoint.CourseId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.CourseId].ToString().Trim(); //课程Id
objPaperSubViewpointEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conPaperSubViewpoint.IsRecommend].ToString().Trim()); //是否推荐
objPaperSubViewpointEN.UpdDate = objRow[conPaperSubViewpoint.UpdDate] == DBNull.Value ? null : objRow[conPaperSubViewpoint.UpdDate].ToString().Trim(); //修改日期
objPaperSubViewpointEN.UpdUser = objRow[conPaperSubViewpoint.UpdUser] == DBNull.Value ? null : objRow[conPaperSubViewpoint.UpdUser].ToString().Trim(); //修改人
objPaperSubViewpointEN.Memo = objRow[conPaperSubViewpoint.Memo] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperSubViewpointEN.SubViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperSubViewpointEN);
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
public static List<clsPaperSubViewpointEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsPaperSubViewpointEN> arrObjLst = new List<clsPaperSubViewpointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperSubViewpointEN objPaperSubViewpointEN = new clsPaperSubViewpointEN();
try
{
objPaperSubViewpointEN.SubViewpointId = Int32.Parse(objRow[conPaperSubViewpoint.SubViewpointId].ToString().Trim()); //子观点Id
objPaperSubViewpointEN.SubViewpointContent = objRow[conPaperSubViewpoint.SubViewpointContent] == DBNull.Value ? null : objRow[conPaperSubViewpoint.SubViewpointContent].ToString().Trim(); //详情内容
objPaperSubViewpointEN.PaperRWId = objRow[conPaperSubViewpoint.PaperRWId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.PaperRWId].ToString().Trim(); //课文阅读
objPaperSubViewpointEN.PaperId = objRow[conPaperSubViewpoint.PaperId].ToString().Trim(); //论文Id
objPaperSubViewpointEN.IdCurrEduCls = objRow[conPaperSubViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperSubViewpointEN.UserId = objRow[conPaperSubViewpoint.UserId].ToString().Trim(); //用户ID
objPaperSubViewpointEN.SectionId = objRow[conPaperSubViewpoint.SectionId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.SectionId].ToString().Trim(); //节Id
objPaperSubViewpointEN.SubViewpointTypeId = objRow[conPaperSubViewpoint.SubViewpointTypeId].ToString().Trim(); //类型Id
objPaperSubViewpointEN.gsKnowledgeTypeId = objRow[conPaperSubViewpoint.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id
objPaperSubViewpointEN.RWTitle = objRow[conPaperSubViewpoint.RWTitle] == DBNull.Value ? null : objRow[conPaperSubViewpoint.RWTitle].ToString().Trim(); //读写标题
objPaperSubViewpointEN.ExplainTypeId = objRow[conPaperSubViewpoint.ExplainTypeId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.ExplainTypeId].ToString().Trim(); //说明类型Id
objPaperSubViewpointEN.ExplainContent = objRow[conPaperSubViewpoint.ExplainContent] == DBNull.Value ? null : objRow[conPaperSubViewpoint.ExplainContent].ToString().Trim(); //说明内容
objPaperSubViewpointEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conPaperSubViewpoint.IsPublic].ToString().Trim()); //是否公开
objPaperSubViewpointEN.LiteratureSourcesId = objRow[conPaperSubViewpoint.LiteratureSourcesId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.LiteratureSourcesId].ToString().Trim(); //文献来源
objPaperSubViewpointEN.OperationTypeId = objRow[conPaperSubViewpoint.OperationTypeId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.OperationTypeId].ToString().Trim(); //操作类型ID
objPaperSubViewpointEN.LevelId = objRow[conPaperSubViewpoint.LevelId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.LevelId].ToString().Trim(); //级别Id
objPaperSubViewpointEN.Conclusion = objRow[conPaperSubViewpoint.Conclusion] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Conclusion].ToString().Trim(); //结论
objPaperSubViewpointEN.Nationality = objRow[conPaperSubViewpoint.Nationality] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Nationality].ToString().Trim(); //国籍
objPaperSubViewpointEN.Achievement = objRow[conPaperSubViewpoint.Achievement] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Achievement].ToString().Trim(); //成就
objPaperSubViewpointEN.Major = objRow[conPaperSubViewpoint.Major] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Major].ToString().Trim(); //专业
objPaperSubViewpointEN.WorkUnit = objRow[conPaperSubViewpoint.WorkUnit] == DBNull.Value ? null : objRow[conPaperSubViewpoint.WorkUnit].ToString().Trim(); //工作单位
objPaperSubViewpointEN.PageNumber = objRow[conPaperSubViewpoint.PageNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.PageNumber].ToString().Trim()); //页码
objPaperSubViewpointEN.OrderNum = objRow[conPaperSubViewpoint.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.OrderNum].ToString().Trim()); //序号
objPaperSubViewpointEN.PdfContent = objRow[conPaperSubViewpoint.PdfContent] == DBNull.Value ? null : objRow[conPaperSubViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objPaperSubViewpointEN.selectSpanRange = objRow[conPaperSubViewpoint.selectSpanRange] == DBNull.Value ? null : objRow[conPaperSubViewpoint.selectSpanRange].ToString().Trim(); //选择Span范围
objPaperSubViewpointEN.PaperLineNum = objRow[conPaperSubViewpoint.PaperLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.PaperLineNum].ToString().Trim()); //论文行号
objPaperSubViewpointEN.PaperPageNum = objRow[conPaperSubViewpoint.PaperPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.PaperPageNum].ToString().Trim()); //论文页码
objPaperSubViewpointEN.AppraiseCount = objRow[conPaperSubViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.AppraiseCount].ToString().Trim()); //评论数
objPaperSubViewpointEN.OkCount = objRow[conPaperSubViewpoint.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.OkCount].ToString().Trim()); //点赞统计
objPaperSubViewpointEN.Score = objRow[conPaperSubViewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaperSubViewpoint.Score].ToString().Trim()); //评分
objPaperSubViewpointEN.StuScore = objRow[conPaperSubViewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaperSubViewpoint.StuScore].ToString().Trim()); //学生平均分
objPaperSubViewpointEN.TeaScore = objRow[conPaperSubViewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaperSubViewpoint.TeaScore].ToString().Trim()); //教师评分
objPaperSubViewpointEN.CreateDate = objRow[conPaperSubViewpoint.CreateDate] == DBNull.Value ? null : objRow[conPaperSubViewpoint.CreateDate].ToString().Trim(); //建立日期
objPaperSubViewpointEN.ShareId = objRow[conPaperSubViewpoint.ShareId].ToString().Trim(); //分享Id
objPaperSubViewpointEN.TopicId = objRow[conPaperSubViewpoint.TopicId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.TopicId].ToString().Trim(); //主题Id
objPaperSubViewpointEN.AttitudesId = objRow[conPaperSubViewpoint.AttitudesId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.AttitudesId].ToString().Trim(); //态度Id
objPaperSubViewpointEN.VersionCount = objRow[conPaperSubViewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.VersionCount].ToString().Trim()); //版本统计
objPaperSubViewpointEN.CitationCount = objRow[conPaperSubViewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.CitationCount].ToString().Trim()); //引用统计
objPaperSubViewpointEN.CourseId = objRow[conPaperSubViewpoint.CourseId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.CourseId].ToString().Trim(); //课程Id
objPaperSubViewpointEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conPaperSubViewpoint.IsRecommend].ToString().Trim()); //是否推荐
objPaperSubViewpointEN.UpdDate = objRow[conPaperSubViewpoint.UpdDate] == DBNull.Value ? null : objRow[conPaperSubViewpoint.UpdDate].ToString().Trim(); //修改日期
objPaperSubViewpointEN.UpdUser = objRow[conPaperSubViewpoint.UpdUser] == DBNull.Value ? null : objRow[conPaperSubViewpoint.UpdUser].ToString().Trim(); //修改人
objPaperSubViewpointEN.Memo = objRow[conPaperSubViewpoint.Memo] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperSubViewpointEN.SubViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperSubViewpointEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objPaperSubViewpointCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsPaperSubViewpointEN> GetSubObjLstCache(clsPaperSubViewpointEN objPaperSubViewpointCond)
{
 string strIdCurrEduCls = objPaperSubViewpointCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsPaperSubViewpointBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsPaperSubViewpointEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsPaperSubViewpointEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPaperSubViewpoint.AttributeName)
{
if (objPaperSubViewpointCond.IsUpdated(strFldName) == false) continue;
if (objPaperSubViewpointCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPaperSubViewpointCond[strFldName].ToString());
}
else
{
if (objPaperSubViewpointCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPaperSubViewpointCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPaperSubViewpointCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPaperSubViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPaperSubViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPaperSubViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPaperSubViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPaperSubViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPaperSubViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPaperSubViewpointCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPaperSubViewpointCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPaperSubViewpointCond[strFldName]));
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
public static List<clsPaperSubViewpointEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsPaperSubViewpointEN> arrObjLst = new List<clsPaperSubViewpointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperSubViewpointEN objPaperSubViewpointEN = new clsPaperSubViewpointEN();
try
{
objPaperSubViewpointEN.SubViewpointId = Int32.Parse(objRow[conPaperSubViewpoint.SubViewpointId].ToString().Trim()); //子观点Id
objPaperSubViewpointEN.SubViewpointContent = objRow[conPaperSubViewpoint.SubViewpointContent] == DBNull.Value ? null : objRow[conPaperSubViewpoint.SubViewpointContent].ToString().Trim(); //详情内容
objPaperSubViewpointEN.PaperRWId = objRow[conPaperSubViewpoint.PaperRWId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.PaperRWId].ToString().Trim(); //课文阅读
objPaperSubViewpointEN.PaperId = objRow[conPaperSubViewpoint.PaperId].ToString().Trim(); //论文Id
objPaperSubViewpointEN.IdCurrEduCls = objRow[conPaperSubViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperSubViewpointEN.UserId = objRow[conPaperSubViewpoint.UserId].ToString().Trim(); //用户ID
objPaperSubViewpointEN.SectionId = objRow[conPaperSubViewpoint.SectionId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.SectionId].ToString().Trim(); //节Id
objPaperSubViewpointEN.SubViewpointTypeId = objRow[conPaperSubViewpoint.SubViewpointTypeId].ToString().Trim(); //类型Id
objPaperSubViewpointEN.gsKnowledgeTypeId = objRow[conPaperSubViewpoint.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id
objPaperSubViewpointEN.RWTitle = objRow[conPaperSubViewpoint.RWTitle] == DBNull.Value ? null : objRow[conPaperSubViewpoint.RWTitle].ToString().Trim(); //读写标题
objPaperSubViewpointEN.ExplainTypeId = objRow[conPaperSubViewpoint.ExplainTypeId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.ExplainTypeId].ToString().Trim(); //说明类型Id
objPaperSubViewpointEN.ExplainContent = objRow[conPaperSubViewpoint.ExplainContent] == DBNull.Value ? null : objRow[conPaperSubViewpoint.ExplainContent].ToString().Trim(); //说明内容
objPaperSubViewpointEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conPaperSubViewpoint.IsPublic].ToString().Trim()); //是否公开
objPaperSubViewpointEN.LiteratureSourcesId = objRow[conPaperSubViewpoint.LiteratureSourcesId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.LiteratureSourcesId].ToString().Trim(); //文献来源
objPaperSubViewpointEN.OperationTypeId = objRow[conPaperSubViewpoint.OperationTypeId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.OperationTypeId].ToString().Trim(); //操作类型ID
objPaperSubViewpointEN.LevelId = objRow[conPaperSubViewpoint.LevelId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.LevelId].ToString().Trim(); //级别Id
objPaperSubViewpointEN.Conclusion = objRow[conPaperSubViewpoint.Conclusion] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Conclusion].ToString().Trim(); //结论
objPaperSubViewpointEN.Nationality = objRow[conPaperSubViewpoint.Nationality] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Nationality].ToString().Trim(); //国籍
objPaperSubViewpointEN.Achievement = objRow[conPaperSubViewpoint.Achievement] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Achievement].ToString().Trim(); //成就
objPaperSubViewpointEN.Major = objRow[conPaperSubViewpoint.Major] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Major].ToString().Trim(); //专业
objPaperSubViewpointEN.WorkUnit = objRow[conPaperSubViewpoint.WorkUnit] == DBNull.Value ? null : objRow[conPaperSubViewpoint.WorkUnit].ToString().Trim(); //工作单位
objPaperSubViewpointEN.PageNumber = objRow[conPaperSubViewpoint.PageNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.PageNumber].ToString().Trim()); //页码
objPaperSubViewpointEN.OrderNum = objRow[conPaperSubViewpoint.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.OrderNum].ToString().Trim()); //序号
objPaperSubViewpointEN.PdfContent = objRow[conPaperSubViewpoint.PdfContent] == DBNull.Value ? null : objRow[conPaperSubViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objPaperSubViewpointEN.selectSpanRange = objRow[conPaperSubViewpoint.selectSpanRange] == DBNull.Value ? null : objRow[conPaperSubViewpoint.selectSpanRange].ToString().Trim(); //选择Span范围
objPaperSubViewpointEN.PaperLineNum = objRow[conPaperSubViewpoint.PaperLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.PaperLineNum].ToString().Trim()); //论文行号
objPaperSubViewpointEN.PaperPageNum = objRow[conPaperSubViewpoint.PaperPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.PaperPageNum].ToString().Trim()); //论文页码
objPaperSubViewpointEN.AppraiseCount = objRow[conPaperSubViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.AppraiseCount].ToString().Trim()); //评论数
objPaperSubViewpointEN.OkCount = objRow[conPaperSubViewpoint.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.OkCount].ToString().Trim()); //点赞统计
objPaperSubViewpointEN.Score = objRow[conPaperSubViewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaperSubViewpoint.Score].ToString().Trim()); //评分
objPaperSubViewpointEN.StuScore = objRow[conPaperSubViewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaperSubViewpoint.StuScore].ToString().Trim()); //学生平均分
objPaperSubViewpointEN.TeaScore = objRow[conPaperSubViewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaperSubViewpoint.TeaScore].ToString().Trim()); //教师评分
objPaperSubViewpointEN.CreateDate = objRow[conPaperSubViewpoint.CreateDate] == DBNull.Value ? null : objRow[conPaperSubViewpoint.CreateDate].ToString().Trim(); //建立日期
objPaperSubViewpointEN.ShareId = objRow[conPaperSubViewpoint.ShareId].ToString().Trim(); //分享Id
objPaperSubViewpointEN.TopicId = objRow[conPaperSubViewpoint.TopicId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.TopicId].ToString().Trim(); //主题Id
objPaperSubViewpointEN.AttitudesId = objRow[conPaperSubViewpoint.AttitudesId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.AttitudesId].ToString().Trim(); //态度Id
objPaperSubViewpointEN.VersionCount = objRow[conPaperSubViewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.VersionCount].ToString().Trim()); //版本统计
objPaperSubViewpointEN.CitationCount = objRow[conPaperSubViewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.CitationCount].ToString().Trim()); //引用统计
objPaperSubViewpointEN.CourseId = objRow[conPaperSubViewpoint.CourseId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.CourseId].ToString().Trim(); //课程Id
objPaperSubViewpointEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conPaperSubViewpoint.IsRecommend].ToString().Trim()); //是否推荐
objPaperSubViewpointEN.UpdDate = objRow[conPaperSubViewpoint.UpdDate] == DBNull.Value ? null : objRow[conPaperSubViewpoint.UpdDate].ToString().Trim(); //修改日期
objPaperSubViewpointEN.UpdUser = objRow[conPaperSubViewpoint.UpdUser] == DBNull.Value ? null : objRow[conPaperSubViewpoint.UpdUser].ToString().Trim(); //修改人
objPaperSubViewpointEN.Memo = objRow[conPaperSubViewpoint.Memo] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperSubViewpointEN.SubViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperSubViewpointEN);
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
public static List<clsPaperSubViewpointEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsPaperSubViewpointEN> arrObjLst = new List<clsPaperSubViewpointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperSubViewpointEN objPaperSubViewpointEN = new clsPaperSubViewpointEN();
try
{
objPaperSubViewpointEN.SubViewpointId = Int32.Parse(objRow[conPaperSubViewpoint.SubViewpointId].ToString().Trim()); //子观点Id
objPaperSubViewpointEN.SubViewpointContent = objRow[conPaperSubViewpoint.SubViewpointContent] == DBNull.Value ? null : objRow[conPaperSubViewpoint.SubViewpointContent].ToString().Trim(); //详情内容
objPaperSubViewpointEN.PaperRWId = objRow[conPaperSubViewpoint.PaperRWId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.PaperRWId].ToString().Trim(); //课文阅读
objPaperSubViewpointEN.PaperId = objRow[conPaperSubViewpoint.PaperId].ToString().Trim(); //论文Id
objPaperSubViewpointEN.IdCurrEduCls = objRow[conPaperSubViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperSubViewpointEN.UserId = objRow[conPaperSubViewpoint.UserId].ToString().Trim(); //用户ID
objPaperSubViewpointEN.SectionId = objRow[conPaperSubViewpoint.SectionId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.SectionId].ToString().Trim(); //节Id
objPaperSubViewpointEN.SubViewpointTypeId = objRow[conPaperSubViewpoint.SubViewpointTypeId].ToString().Trim(); //类型Id
objPaperSubViewpointEN.gsKnowledgeTypeId = objRow[conPaperSubViewpoint.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id
objPaperSubViewpointEN.RWTitle = objRow[conPaperSubViewpoint.RWTitle] == DBNull.Value ? null : objRow[conPaperSubViewpoint.RWTitle].ToString().Trim(); //读写标题
objPaperSubViewpointEN.ExplainTypeId = objRow[conPaperSubViewpoint.ExplainTypeId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.ExplainTypeId].ToString().Trim(); //说明类型Id
objPaperSubViewpointEN.ExplainContent = objRow[conPaperSubViewpoint.ExplainContent] == DBNull.Value ? null : objRow[conPaperSubViewpoint.ExplainContent].ToString().Trim(); //说明内容
objPaperSubViewpointEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conPaperSubViewpoint.IsPublic].ToString().Trim()); //是否公开
objPaperSubViewpointEN.LiteratureSourcesId = objRow[conPaperSubViewpoint.LiteratureSourcesId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.LiteratureSourcesId].ToString().Trim(); //文献来源
objPaperSubViewpointEN.OperationTypeId = objRow[conPaperSubViewpoint.OperationTypeId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.OperationTypeId].ToString().Trim(); //操作类型ID
objPaperSubViewpointEN.LevelId = objRow[conPaperSubViewpoint.LevelId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.LevelId].ToString().Trim(); //级别Id
objPaperSubViewpointEN.Conclusion = objRow[conPaperSubViewpoint.Conclusion] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Conclusion].ToString().Trim(); //结论
objPaperSubViewpointEN.Nationality = objRow[conPaperSubViewpoint.Nationality] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Nationality].ToString().Trim(); //国籍
objPaperSubViewpointEN.Achievement = objRow[conPaperSubViewpoint.Achievement] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Achievement].ToString().Trim(); //成就
objPaperSubViewpointEN.Major = objRow[conPaperSubViewpoint.Major] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Major].ToString().Trim(); //专业
objPaperSubViewpointEN.WorkUnit = objRow[conPaperSubViewpoint.WorkUnit] == DBNull.Value ? null : objRow[conPaperSubViewpoint.WorkUnit].ToString().Trim(); //工作单位
objPaperSubViewpointEN.PageNumber = objRow[conPaperSubViewpoint.PageNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.PageNumber].ToString().Trim()); //页码
objPaperSubViewpointEN.OrderNum = objRow[conPaperSubViewpoint.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.OrderNum].ToString().Trim()); //序号
objPaperSubViewpointEN.PdfContent = objRow[conPaperSubViewpoint.PdfContent] == DBNull.Value ? null : objRow[conPaperSubViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objPaperSubViewpointEN.selectSpanRange = objRow[conPaperSubViewpoint.selectSpanRange] == DBNull.Value ? null : objRow[conPaperSubViewpoint.selectSpanRange].ToString().Trim(); //选择Span范围
objPaperSubViewpointEN.PaperLineNum = objRow[conPaperSubViewpoint.PaperLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.PaperLineNum].ToString().Trim()); //论文行号
objPaperSubViewpointEN.PaperPageNum = objRow[conPaperSubViewpoint.PaperPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.PaperPageNum].ToString().Trim()); //论文页码
objPaperSubViewpointEN.AppraiseCount = objRow[conPaperSubViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.AppraiseCount].ToString().Trim()); //评论数
objPaperSubViewpointEN.OkCount = objRow[conPaperSubViewpoint.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.OkCount].ToString().Trim()); //点赞统计
objPaperSubViewpointEN.Score = objRow[conPaperSubViewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaperSubViewpoint.Score].ToString().Trim()); //评分
objPaperSubViewpointEN.StuScore = objRow[conPaperSubViewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaperSubViewpoint.StuScore].ToString().Trim()); //学生平均分
objPaperSubViewpointEN.TeaScore = objRow[conPaperSubViewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaperSubViewpoint.TeaScore].ToString().Trim()); //教师评分
objPaperSubViewpointEN.CreateDate = objRow[conPaperSubViewpoint.CreateDate] == DBNull.Value ? null : objRow[conPaperSubViewpoint.CreateDate].ToString().Trim(); //建立日期
objPaperSubViewpointEN.ShareId = objRow[conPaperSubViewpoint.ShareId].ToString().Trim(); //分享Id
objPaperSubViewpointEN.TopicId = objRow[conPaperSubViewpoint.TopicId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.TopicId].ToString().Trim(); //主题Id
objPaperSubViewpointEN.AttitudesId = objRow[conPaperSubViewpoint.AttitudesId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.AttitudesId].ToString().Trim(); //态度Id
objPaperSubViewpointEN.VersionCount = objRow[conPaperSubViewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.VersionCount].ToString().Trim()); //版本统计
objPaperSubViewpointEN.CitationCount = objRow[conPaperSubViewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.CitationCount].ToString().Trim()); //引用统计
objPaperSubViewpointEN.CourseId = objRow[conPaperSubViewpoint.CourseId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.CourseId].ToString().Trim(); //课程Id
objPaperSubViewpointEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conPaperSubViewpoint.IsRecommend].ToString().Trim()); //是否推荐
objPaperSubViewpointEN.UpdDate = objRow[conPaperSubViewpoint.UpdDate] == DBNull.Value ? null : objRow[conPaperSubViewpoint.UpdDate].ToString().Trim(); //修改日期
objPaperSubViewpointEN.UpdUser = objRow[conPaperSubViewpoint.UpdUser] == DBNull.Value ? null : objRow[conPaperSubViewpoint.UpdUser].ToString().Trim(); //修改人
objPaperSubViewpointEN.Memo = objRow[conPaperSubViewpoint.Memo] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperSubViewpointEN.SubViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperSubViewpointEN);
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
List<clsPaperSubViewpointEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsPaperSubViewpointEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsPaperSubViewpointEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsPaperSubViewpointEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsPaperSubViewpointEN> arrObjLst = new List<clsPaperSubViewpointEN>(); 
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
	clsPaperSubViewpointEN objPaperSubViewpointEN = new clsPaperSubViewpointEN();
try
{
objPaperSubViewpointEN.SubViewpointId = Int32.Parse(objRow[conPaperSubViewpoint.SubViewpointId].ToString().Trim()); //子观点Id
objPaperSubViewpointEN.SubViewpointContent = objRow[conPaperSubViewpoint.SubViewpointContent] == DBNull.Value ? null : objRow[conPaperSubViewpoint.SubViewpointContent].ToString().Trim(); //详情内容
objPaperSubViewpointEN.PaperRWId = objRow[conPaperSubViewpoint.PaperRWId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.PaperRWId].ToString().Trim(); //课文阅读
objPaperSubViewpointEN.PaperId = objRow[conPaperSubViewpoint.PaperId].ToString().Trim(); //论文Id
objPaperSubViewpointEN.IdCurrEduCls = objRow[conPaperSubViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperSubViewpointEN.UserId = objRow[conPaperSubViewpoint.UserId].ToString().Trim(); //用户ID
objPaperSubViewpointEN.SectionId = objRow[conPaperSubViewpoint.SectionId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.SectionId].ToString().Trim(); //节Id
objPaperSubViewpointEN.SubViewpointTypeId = objRow[conPaperSubViewpoint.SubViewpointTypeId].ToString().Trim(); //类型Id
objPaperSubViewpointEN.gsKnowledgeTypeId = objRow[conPaperSubViewpoint.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id
objPaperSubViewpointEN.RWTitle = objRow[conPaperSubViewpoint.RWTitle] == DBNull.Value ? null : objRow[conPaperSubViewpoint.RWTitle].ToString().Trim(); //读写标题
objPaperSubViewpointEN.ExplainTypeId = objRow[conPaperSubViewpoint.ExplainTypeId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.ExplainTypeId].ToString().Trim(); //说明类型Id
objPaperSubViewpointEN.ExplainContent = objRow[conPaperSubViewpoint.ExplainContent] == DBNull.Value ? null : objRow[conPaperSubViewpoint.ExplainContent].ToString().Trim(); //说明内容
objPaperSubViewpointEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conPaperSubViewpoint.IsPublic].ToString().Trim()); //是否公开
objPaperSubViewpointEN.LiteratureSourcesId = objRow[conPaperSubViewpoint.LiteratureSourcesId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.LiteratureSourcesId].ToString().Trim(); //文献来源
objPaperSubViewpointEN.OperationTypeId = objRow[conPaperSubViewpoint.OperationTypeId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.OperationTypeId].ToString().Trim(); //操作类型ID
objPaperSubViewpointEN.LevelId = objRow[conPaperSubViewpoint.LevelId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.LevelId].ToString().Trim(); //级别Id
objPaperSubViewpointEN.Conclusion = objRow[conPaperSubViewpoint.Conclusion] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Conclusion].ToString().Trim(); //结论
objPaperSubViewpointEN.Nationality = objRow[conPaperSubViewpoint.Nationality] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Nationality].ToString().Trim(); //国籍
objPaperSubViewpointEN.Achievement = objRow[conPaperSubViewpoint.Achievement] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Achievement].ToString().Trim(); //成就
objPaperSubViewpointEN.Major = objRow[conPaperSubViewpoint.Major] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Major].ToString().Trim(); //专业
objPaperSubViewpointEN.WorkUnit = objRow[conPaperSubViewpoint.WorkUnit] == DBNull.Value ? null : objRow[conPaperSubViewpoint.WorkUnit].ToString().Trim(); //工作单位
objPaperSubViewpointEN.PageNumber = objRow[conPaperSubViewpoint.PageNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.PageNumber].ToString().Trim()); //页码
objPaperSubViewpointEN.OrderNum = objRow[conPaperSubViewpoint.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.OrderNum].ToString().Trim()); //序号
objPaperSubViewpointEN.PdfContent = objRow[conPaperSubViewpoint.PdfContent] == DBNull.Value ? null : objRow[conPaperSubViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objPaperSubViewpointEN.selectSpanRange = objRow[conPaperSubViewpoint.selectSpanRange] == DBNull.Value ? null : objRow[conPaperSubViewpoint.selectSpanRange].ToString().Trim(); //选择Span范围
objPaperSubViewpointEN.PaperLineNum = objRow[conPaperSubViewpoint.PaperLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.PaperLineNum].ToString().Trim()); //论文行号
objPaperSubViewpointEN.PaperPageNum = objRow[conPaperSubViewpoint.PaperPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.PaperPageNum].ToString().Trim()); //论文页码
objPaperSubViewpointEN.AppraiseCount = objRow[conPaperSubViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.AppraiseCount].ToString().Trim()); //评论数
objPaperSubViewpointEN.OkCount = objRow[conPaperSubViewpoint.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.OkCount].ToString().Trim()); //点赞统计
objPaperSubViewpointEN.Score = objRow[conPaperSubViewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaperSubViewpoint.Score].ToString().Trim()); //评分
objPaperSubViewpointEN.StuScore = objRow[conPaperSubViewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaperSubViewpoint.StuScore].ToString().Trim()); //学生平均分
objPaperSubViewpointEN.TeaScore = objRow[conPaperSubViewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaperSubViewpoint.TeaScore].ToString().Trim()); //教师评分
objPaperSubViewpointEN.CreateDate = objRow[conPaperSubViewpoint.CreateDate] == DBNull.Value ? null : objRow[conPaperSubViewpoint.CreateDate].ToString().Trim(); //建立日期
objPaperSubViewpointEN.ShareId = objRow[conPaperSubViewpoint.ShareId].ToString().Trim(); //分享Id
objPaperSubViewpointEN.TopicId = objRow[conPaperSubViewpoint.TopicId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.TopicId].ToString().Trim(); //主题Id
objPaperSubViewpointEN.AttitudesId = objRow[conPaperSubViewpoint.AttitudesId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.AttitudesId].ToString().Trim(); //态度Id
objPaperSubViewpointEN.VersionCount = objRow[conPaperSubViewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.VersionCount].ToString().Trim()); //版本统计
objPaperSubViewpointEN.CitationCount = objRow[conPaperSubViewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.CitationCount].ToString().Trim()); //引用统计
objPaperSubViewpointEN.CourseId = objRow[conPaperSubViewpoint.CourseId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.CourseId].ToString().Trim(); //课程Id
objPaperSubViewpointEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conPaperSubViewpoint.IsRecommend].ToString().Trim()); //是否推荐
objPaperSubViewpointEN.UpdDate = objRow[conPaperSubViewpoint.UpdDate] == DBNull.Value ? null : objRow[conPaperSubViewpoint.UpdDate].ToString().Trim(); //修改日期
objPaperSubViewpointEN.UpdUser = objRow[conPaperSubViewpoint.UpdUser] == DBNull.Value ? null : objRow[conPaperSubViewpoint.UpdUser].ToString().Trim(); //修改人
objPaperSubViewpointEN.Memo = objRow[conPaperSubViewpoint.Memo] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperSubViewpointEN.SubViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperSubViewpointEN);
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
public static List<clsPaperSubViewpointEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsPaperSubViewpointEN> arrObjLst = new List<clsPaperSubViewpointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperSubViewpointEN objPaperSubViewpointEN = new clsPaperSubViewpointEN();
try
{
objPaperSubViewpointEN.SubViewpointId = Int32.Parse(objRow[conPaperSubViewpoint.SubViewpointId].ToString().Trim()); //子观点Id
objPaperSubViewpointEN.SubViewpointContent = objRow[conPaperSubViewpoint.SubViewpointContent] == DBNull.Value ? null : objRow[conPaperSubViewpoint.SubViewpointContent].ToString().Trim(); //详情内容
objPaperSubViewpointEN.PaperRWId = objRow[conPaperSubViewpoint.PaperRWId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.PaperRWId].ToString().Trim(); //课文阅读
objPaperSubViewpointEN.PaperId = objRow[conPaperSubViewpoint.PaperId].ToString().Trim(); //论文Id
objPaperSubViewpointEN.IdCurrEduCls = objRow[conPaperSubViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperSubViewpointEN.UserId = objRow[conPaperSubViewpoint.UserId].ToString().Trim(); //用户ID
objPaperSubViewpointEN.SectionId = objRow[conPaperSubViewpoint.SectionId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.SectionId].ToString().Trim(); //节Id
objPaperSubViewpointEN.SubViewpointTypeId = objRow[conPaperSubViewpoint.SubViewpointTypeId].ToString().Trim(); //类型Id
objPaperSubViewpointEN.gsKnowledgeTypeId = objRow[conPaperSubViewpoint.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id
objPaperSubViewpointEN.RWTitle = objRow[conPaperSubViewpoint.RWTitle] == DBNull.Value ? null : objRow[conPaperSubViewpoint.RWTitle].ToString().Trim(); //读写标题
objPaperSubViewpointEN.ExplainTypeId = objRow[conPaperSubViewpoint.ExplainTypeId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.ExplainTypeId].ToString().Trim(); //说明类型Id
objPaperSubViewpointEN.ExplainContent = objRow[conPaperSubViewpoint.ExplainContent] == DBNull.Value ? null : objRow[conPaperSubViewpoint.ExplainContent].ToString().Trim(); //说明内容
objPaperSubViewpointEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conPaperSubViewpoint.IsPublic].ToString().Trim()); //是否公开
objPaperSubViewpointEN.LiteratureSourcesId = objRow[conPaperSubViewpoint.LiteratureSourcesId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.LiteratureSourcesId].ToString().Trim(); //文献来源
objPaperSubViewpointEN.OperationTypeId = objRow[conPaperSubViewpoint.OperationTypeId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.OperationTypeId].ToString().Trim(); //操作类型ID
objPaperSubViewpointEN.LevelId = objRow[conPaperSubViewpoint.LevelId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.LevelId].ToString().Trim(); //级别Id
objPaperSubViewpointEN.Conclusion = objRow[conPaperSubViewpoint.Conclusion] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Conclusion].ToString().Trim(); //结论
objPaperSubViewpointEN.Nationality = objRow[conPaperSubViewpoint.Nationality] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Nationality].ToString().Trim(); //国籍
objPaperSubViewpointEN.Achievement = objRow[conPaperSubViewpoint.Achievement] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Achievement].ToString().Trim(); //成就
objPaperSubViewpointEN.Major = objRow[conPaperSubViewpoint.Major] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Major].ToString().Trim(); //专业
objPaperSubViewpointEN.WorkUnit = objRow[conPaperSubViewpoint.WorkUnit] == DBNull.Value ? null : objRow[conPaperSubViewpoint.WorkUnit].ToString().Trim(); //工作单位
objPaperSubViewpointEN.PageNumber = objRow[conPaperSubViewpoint.PageNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.PageNumber].ToString().Trim()); //页码
objPaperSubViewpointEN.OrderNum = objRow[conPaperSubViewpoint.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.OrderNum].ToString().Trim()); //序号
objPaperSubViewpointEN.PdfContent = objRow[conPaperSubViewpoint.PdfContent] == DBNull.Value ? null : objRow[conPaperSubViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objPaperSubViewpointEN.selectSpanRange = objRow[conPaperSubViewpoint.selectSpanRange] == DBNull.Value ? null : objRow[conPaperSubViewpoint.selectSpanRange].ToString().Trim(); //选择Span范围
objPaperSubViewpointEN.PaperLineNum = objRow[conPaperSubViewpoint.PaperLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.PaperLineNum].ToString().Trim()); //论文行号
objPaperSubViewpointEN.PaperPageNum = objRow[conPaperSubViewpoint.PaperPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.PaperPageNum].ToString().Trim()); //论文页码
objPaperSubViewpointEN.AppraiseCount = objRow[conPaperSubViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.AppraiseCount].ToString().Trim()); //评论数
objPaperSubViewpointEN.OkCount = objRow[conPaperSubViewpoint.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.OkCount].ToString().Trim()); //点赞统计
objPaperSubViewpointEN.Score = objRow[conPaperSubViewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaperSubViewpoint.Score].ToString().Trim()); //评分
objPaperSubViewpointEN.StuScore = objRow[conPaperSubViewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaperSubViewpoint.StuScore].ToString().Trim()); //学生平均分
objPaperSubViewpointEN.TeaScore = objRow[conPaperSubViewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaperSubViewpoint.TeaScore].ToString().Trim()); //教师评分
objPaperSubViewpointEN.CreateDate = objRow[conPaperSubViewpoint.CreateDate] == DBNull.Value ? null : objRow[conPaperSubViewpoint.CreateDate].ToString().Trim(); //建立日期
objPaperSubViewpointEN.ShareId = objRow[conPaperSubViewpoint.ShareId].ToString().Trim(); //分享Id
objPaperSubViewpointEN.TopicId = objRow[conPaperSubViewpoint.TopicId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.TopicId].ToString().Trim(); //主题Id
objPaperSubViewpointEN.AttitudesId = objRow[conPaperSubViewpoint.AttitudesId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.AttitudesId].ToString().Trim(); //态度Id
objPaperSubViewpointEN.VersionCount = objRow[conPaperSubViewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.VersionCount].ToString().Trim()); //版本统计
objPaperSubViewpointEN.CitationCount = objRow[conPaperSubViewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.CitationCount].ToString().Trim()); //引用统计
objPaperSubViewpointEN.CourseId = objRow[conPaperSubViewpoint.CourseId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.CourseId].ToString().Trim(); //课程Id
objPaperSubViewpointEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conPaperSubViewpoint.IsRecommend].ToString().Trim()); //是否推荐
objPaperSubViewpointEN.UpdDate = objRow[conPaperSubViewpoint.UpdDate] == DBNull.Value ? null : objRow[conPaperSubViewpoint.UpdDate].ToString().Trim(); //修改日期
objPaperSubViewpointEN.UpdUser = objRow[conPaperSubViewpoint.UpdUser] == DBNull.Value ? null : objRow[conPaperSubViewpoint.UpdUser].ToString().Trim(); //修改人
objPaperSubViewpointEN.Memo = objRow[conPaperSubViewpoint.Memo] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperSubViewpointEN.SubViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperSubViewpointEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsPaperSubViewpointEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsPaperSubViewpointEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsPaperSubViewpointEN> arrObjLst = new List<clsPaperSubViewpointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperSubViewpointEN objPaperSubViewpointEN = new clsPaperSubViewpointEN();
try
{
objPaperSubViewpointEN.SubViewpointId = Int32.Parse(objRow[conPaperSubViewpoint.SubViewpointId].ToString().Trim()); //子观点Id
objPaperSubViewpointEN.SubViewpointContent = objRow[conPaperSubViewpoint.SubViewpointContent] == DBNull.Value ? null : objRow[conPaperSubViewpoint.SubViewpointContent].ToString().Trim(); //详情内容
objPaperSubViewpointEN.PaperRWId = objRow[conPaperSubViewpoint.PaperRWId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.PaperRWId].ToString().Trim(); //课文阅读
objPaperSubViewpointEN.PaperId = objRow[conPaperSubViewpoint.PaperId].ToString().Trim(); //论文Id
objPaperSubViewpointEN.IdCurrEduCls = objRow[conPaperSubViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperSubViewpointEN.UserId = objRow[conPaperSubViewpoint.UserId].ToString().Trim(); //用户ID
objPaperSubViewpointEN.SectionId = objRow[conPaperSubViewpoint.SectionId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.SectionId].ToString().Trim(); //节Id
objPaperSubViewpointEN.SubViewpointTypeId = objRow[conPaperSubViewpoint.SubViewpointTypeId].ToString().Trim(); //类型Id
objPaperSubViewpointEN.gsKnowledgeTypeId = objRow[conPaperSubViewpoint.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id
objPaperSubViewpointEN.RWTitle = objRow[conPaperSubViewpoint.RWTitle] == DBNull.Value ? null : objRow[conPaperSubViewpoint.RWTitle].ToString().Trim(); //读写标题
objPaperSubViewpointEN.ExplainTypeId = objRow[conPaperSubViewpoint.ExplainTypeId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.ExplainTypeId].ToString().Trim(); //说明类型Id
objPaperSubViewpointEN.ExplainContent = objRow[conPaperSubViewpoint.ExplainContent] == DBNull.Value ? null : objRow[conPaperSubViewpoint.ExplainContent].ToString().Trim(); //说明内容
objPaperSubViewpointEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conPaperSubViewpoint.IsPublic].ToString().Trim()); //是否公开
objPaperSubViewpointEN.LiteratureSourcesId = objRow[conPaperSubViewpoint.LiteratureSourcesId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.LiteratureSourcesId].ToString().Trim(); //文献来源
objPaperSubViewpointEN.OperationTypeId = objRow[conPaperSubViewpoint.OperationTypeId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.OperationTypeId].ToString().Trim(); //操作类型ID
objPaperSubViewpointEN.LevelId = objRow[conPaperSubViewpoint.LevelId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.LevelId].ToString().Trim(); //级别Id
objPaperSubViewpointEN.Conclusion = objRow[conPaperSubViewpoint.Conclusion] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Conclusion].ToString().Trim(); //结论
objPaperSubViewpointEN.Nationality = objRow[conPaperSubViewpoint.Nationality] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Nationality].ToString().Trim(); //国籍
objPaperSubViewpointEN.Achievement = objRow[conPaperSubViewpoint.Achievement] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Achievement].ToString().Trim(); //成就
objPaperSubViewpointEN.Major = objRow[conPaperSubViewpoint.Major] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Major].ToString().Trim(); //专业
objPaperSubViewpointEN.WorkUnit = objRow[conPaperSubViewpoint.WorkUnit] == DBNull.Value ? null : objRow[conPaperSubViewpoint.WorkUnit].ToString().Trim(); //工作单位
objPaperSubViewpointEN.PageNumber = objRow[conPaperSubViewpoint.PageNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.PageNumber].ToString().Trim()); //页码
objPaperSubViewpointEN.OrderNum = objRow[conPaperSubViewpoint.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.OrderNum].ToString().Trim()); //序号
objPaperSubViewpointEN.PdfContent = objRow[conPaperSubViewpoint.PdfContent] == DBNull.Value ? null : objRow[conPaperSubViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objPaperSubViewpointEN.selectSpanRange = objRow[conPaperSubViewpoint.selectSpanRange] == DBNull.Value ? null : objRow[conPaperSubViewpoint.selectSpanRange].ToString().Trim(); //选择Span范围
objPaperSubViewpointEN.PaperLineNum = objRow[conPaperSubViewpoint.PaperLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.PaperLineNum].ToString().Trim()); //论文行号
objPaperSubViewpointEN.PaperPageNum = objRow[conPaperSubViewpoint.PaperPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.PaperPageNum].ToString().Trim()); //论文页码
objPaperSubViewpointEN.AppraiseCount = objRow[conPaperSubViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.AppraiseCount].ToString().Trim()); //评论数
objPaperSubViewpointEN.OkCount = objRow[conPaperSubViewpoint.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.OkCount].ToString().Trim()); //点赞统计
objPaperSubViewpointEN.Score = objRow[conPaperSubViewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaperSubViewpoint.Score].ToString().Trim()); //评分
objPaperSubViewpointEN.StuScore = objRow[conPaperSubViewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaperSubViewpoint.StuScore].ToString().Trim()); //学生平均分
objPaperSubViewpointEN.TeaScore = objRow[conPaperSubViewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaperSubViewpoint.TeaScore].ToString().Trim()); //教师评分
objPaperSubViewpointEN.CreateDate = objRow[conPaperSubViewpoint.CreateDate] == DBNull.Value ? null : objRow[conPaperSubViewpoint.CreateDate].ToString().Trim(); //建立日期
objPaperSubViewpointEN.ShareId = objRow[conPaperSubViewpoint.ShareId].ToString().Trim(); //分享Id
objPaperSubViewpointEN.TopicId = objRow[conPaperSubViewpoint.TopicId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.TopicId].ToString().Trim(); //主题Id
objPaperSubViewpointEN.AttitudesId = objRow[conPaperSubViewpoint.AttitudesId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.AttitudesId].ToString().Trim(); //态度Id
objPaperSubViewpointEN.VersionCount = objRow[conPaperSubViewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.VersionCount].ToString().Trim()); //版本统计
objPaperSubViewpointEN.CitationCount = objRow[conPaperSubViewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.CitationCount].ToString().Trim()); //引用统计
objPaperSubViewpointEN.CourseId = objRow[conPaperSubViewpoint.CourseId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.CourseId].ToString().Trim(); //课程Id
objPaperSubViewpointEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conPaperSubViewpoint.IsRecommend].ToString().Trim()); //是否推荐
objPaperSubViewpointEN.UpdDate = objRow[conPaperSubViewpoint.UpdDate] == DBNull.Value ? null : objRow[conPaperSubViewpoint.UpdDate].ToString().Trim(); //修改日期
objPaperSubViewpointEN.UpdUser = objRow[conPaperSubViewpoint.UpdUser] == DBNull.Value ? null : objRow[conPaperSubViewpoint.UpdUser].ToString().Trim(); //修改人
objPaperSubViewpointEN.Memo = objRow[conPaperSubViewpoint.Memo] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperSubViewpointEN.SubViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperSubViewpointEN);
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
public static List<clsPaperSubViewpointEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsPaperSubViewpointEN> arrObjLst = new List<clsPaperSubViewpointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperSubViewpointEN objPaperSubViewpointEN = new clsPaperSubViewpointEN();
try
{
objPaperSubViewpointEN.SubViewpointId = Int32.Parse(objRow[conPaperSubViewpoint.SubViewpointId].ToString().Trim()); //子观点Id
objPaperSubViewpointEN.SubViewpointContent = objRow[conPaperSubViewpoint.SubViewpointContent] == DBNull.Value ? null : objRow[conPaperSubViewpoint.SubViewpointContent].ToString().Trim(); //详情内容
objPaperSubViewpointEN.PaperRWId = objRow[conPaperSubViewpoint.PaperRWId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.PaperRWId].ToString().Trim(); //课文阅读
objPaperSubViewpointEN.PaperId = objRow[conPaperSubViewpoint.PaperId].ToString().Trim(); //论文Id
objPaperSubViewpointEN.IdCurrEduCls = objRow[conPaperSubViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperSubViewpointEN.UserId = objRow[conPaperSubViewpoint.UserId].ToString().Trim(); //用户ID
objPaperSubViewpointEN.SectionId = objRow[conPaperSubViewpoint.SectionId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.SectionId].ToString().Trim(); //节Id
objPaperSubViewpointEN.SubViewpointTypeId = objRow[conPaperSubViewpoint.SubViewpointTypeId].ToString().Trim(); //类型Id
objPaperSubViewpointEN.gsKnowledgeTypeId = objRow[conPaperSubViewpoint.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id
objPaperSubViewpointEN.RWTitle = objRow[conPaperSubViewpoint.RWTitle] == DBNull.Value ? null : objRow[conPaperSubViewpoint.RWTitle].ToString().Trim(); //读写标题
objPaperSubViewpointEN.ExplainTypeId = objRow[conPaperSubViewpoint.ExplainTypeId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.ExplainTypeId].ToString().Trim(); //说明类型Id
objPaperSubViewpointEN.ExplainContent = objRow[conPaperSubViewpoint.ExplainContent] == DBNull.Value ? null : objRow[conPaperSubViewpoint.ExplainContent].ToString().Trim(); //说明内容
objPaperSubViewpointEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conPaperSubViewpoint.IsPublic].ToString().Trim()); //是否公开
objPaperSubViewpointEN.LiteratureSourcesId = objRow[conPaperSubViewpoint.LiteratureSourcesId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.LiteratureSourcesId].ToString().Trim(); //文献来源
objPaperSubViewpointEN.OperationTypeId = objRow[conPaperSubViewpoint.OperationTypeId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.OperationTypeId].ToString().Trim(); //操作类型ID
objPaperSubViewpointEN.LevelId = objRow[conPaperSubViewpoint.LevelId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.LevelId].ToString().Trim(); //级别Id
objPaperSubViewpointEN.Conclusion = objRow[conPaperSubViewpoint.Conclusion] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Conclusion].ToString().Trim(); //结论
objPaperSubViewpointEN.Nationality = objRow[conPaperSubViewpoint.Nationality] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Nationality].ToString().Trim(); //国籍
objPaperSubViewpointEN.Achievement = objRow[conPaperSubViewpoint.Achievement] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Achievement].ToString().Trim(); //成就
objPaperSubViewpointEN.Major = objRow[conPaperSubViewpoint.Major] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Major].ToString().Trim(); //专业
objPaperSubViewpointEN.WorkUnit = objRow[conPaperSubViewpoint.WorkUnit] == DBNull.Value ? null : objRow[conPaperSubViewpoint.WorkUnit].ToString().Trim(); //工作单位
objPaperSubViewpointEN.PageNumber = objRow[conPaperSubViewpoint.PageNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.PageNumber].ToString().Trim()); //页码
objPaperSubViewpointEN.OrderNum = objRow[conPaperSubViewpoint.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.OrderNum].ToString().Trim()); //序号
objPaperSubViewpointEN.PdfContent = objRow[conPaperSubViewpoint.PdfContent] == DBNull.Value ? null : objRow[conPaperSubViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objPaperSubViewpointEN.selectSpanRange = objRow[conPaperSubViewpoint.selectSpanRange] == DBNull.Value ? null : objRow[conPaperSubViewpoint.selectSpanRange].ToString().Trim(); //选择Span范围
objPaperSubViewpointEN.PaperLineNum = objRow[conPaperSubViewpoint.PaperLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.PaperLineNum].ToString().Trim()); //论文行号
objPaperSubViewpointEN.PaperPageNum = objRow[conPaperSubViewpoint.PaperPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.PaperPageNum].ToString().Trim()); //论文页码
objPaperSubViewpointEN.AppraiseCount = objRow[conPaperSubViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.AppraiseCount].ToString().Trim()); //评论数
objPaperSubViewpointEN.OkCount = objRow[conPaperSubViewpoint.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.OkCount].ToString().Trim()); //点赞统计
objPaperSubViewpointEN.Score = objRow[conPaperSubViewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaperSubViewpoint.Score].ToString().Trim()); //评分
objPaperSubViewpointEN.StuScore = objRow[conPaperSubViewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaperSubViewpoint.StuScore].ToString().Trim()); //学生平均分
objPaperSubViewpointEN.TeaScore = objRow[conPaperSubViewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaperSubViewpoint.TeaScore].ToString().Trim()); //教师评分
objPaperSubViewpointEN.CreateDate = objRow[conPaperSubViewpoint.CreateDate] == DBNull.Value ? null : objRow[conPaperSubViewpoint.CreateDate].ToString().Trim(); //建立日期
objPaperSubViewpointEN.ShareId = objRow[conPaperSubViewpoint.ShareId].ToString().Trim(); //分享Id
objPaperSubViewpointEN.TopicId = objRow[conPaperSubViewpoint.TopicId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.TopicId].ToString().Trim(); //主题Id
objPaperSubViewpointEN.AttitudesId = objRow[conPaperSubViewpoint.AttitudesId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.AttitudesId].ToString().Trim(); //态度Id
objPaperSubViewpointEN.VersionCount = objRow[conPaperSubViewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.VersionCount].ToString().Trim()); //版本统计
objPaperSubViewpointEN.CitationCount = objRow[conPaperSubViewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.CitationCount].ToString().Trim()); //引用统计
objPaperSubViewpointEN.CourseId = objRow[conPaperSubViewpoint.CourseId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.CourseId].ToString().Trim(); //课程Id
objPaperSubViewpointEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conPaperSubViewpoint.IsRecommend].ToString().Trim()); //是否推荐
objPaperSubViewpointEN.UpdDate = objRow[conPaperSubViewpoint.UpdDate] == DBNull.Value ? null : objRow[conPaperSubViewpoint.UpdDate].ToString().Trim(); //修改日期
objPaperSubViewpointEN.UpdUser = objRow[conPaperSubViewpoint.UpdUser] == DBNull.Value ? null : objRow[conPaperSubViewpoint.UpdUser].ToString().Trim(); //修改人
objPaperSubViewpointEN.Memo = objRow[conPaperSubViewpoint.Memo] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperSubViewpointEN.SubViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperSubViewpointEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsPaperSubViewpointEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsPaperSubViewpointEN> arrObjLst = new List<clsPaperSubViewpointEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperSubViewpointEN objPaperSubViewpointEN = new clsPaperSubViewpointEN();
try
{
objPaperSubViewpointEN.SubViewpointId = Int32.Parse(objRow[conPaperSubViewpoint.SubViewpointId].ToString().Trim()); //子观点Id
objPaperSubViewpointEN.SubViewpointContent = objRow[conPaperSubViewpoint.SubViewpointContent] == DBNull.Value ? null : objRow[conPaperSubViewpoint.SubViewpointContent].ToString().Trim(); //详情内容
objPaperSubViewpointEN.PaperRWId = objRow[conPaperSubViewpoint.PaperRWId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.PaperRWId].ToString().Trim(); //课文阅读
objPaperSubViewpointEN.PaperId = objRow[conPaperSubViewpoint.PaperId].ToString().Trim(); //论文Id
objPaperSubViewpointEN.IdCurrEduCls = objRow[conPaperSubViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperSubViewpointEN.UserId = objRow[conPaperSubViewpoint.UserId].ToString().Trim(); //用户ID
objPaperSubViewpointEN.SectionId = objRow[conPaperSubViewpoint.SectionId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.SectionId].ToString().Trim(); //节Id
objPaperSubViewpointEN.SubViewpointTypeId = objRow[conPaperSubViewpoint.SubViewpointTypeId].ToString().Trim(); //类型Id
objPaperSubViewpointEN.gsKnowledgeTypeId = objRow[conPaperSubViewpoint.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id
objPaperSubViewpointEN.RWTitle = objRow[conPaperSubViewpoint.RWTitle] == DBNull.Value ? null : objRow[conPaperSubViewpoint.RWTitle].ToString().Trim(); //读写标题
objPaperSubViewpointEN.ExplainTypeId = objRow[conPaperSubViewpoint.ExplainTypeId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.ExplainTypeId].ToString().Trim(); //说明类型Id
objPaperSubViewpointEN.ExplainContent = objRow[conPaperSubViewpoint.ExplainContent] == DBNull.Value ? null : objRow[conPaperSubViewpoint.ExplainContent].ToString().Trim(); //说明内容
objPaperSubViewpointEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conPaperSubViewpoint.IsPublic].ToString().Trim()); //是否公开
objPaperSubViewpointEN.LiteratureSourcesId = objRow[conPaperSubViewpoint.LiteratureSourcesId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.LiteratureSourcesId].ToString().Trim(); //文献来源
objPaperSubViewpointEN.OperationTypeId = objRow[conPaperSubViewpoint.OperationTypeId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.OperationTypeId].ToString().Trim(); //操作类型ID
objPaperSubViewpointEN.LevelId = objRow[conPaperSubViewpoint.LevelId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.LevelId].ToString().Trim(); //级别Id
objPaperSubViewpointEN.Conclusion = objRow[conPaperSubViewpoint.Conclusion] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Conclusion].ToString().Trim(); //结论
objPaperSubViewpointEN.Nationality = objRow[conPaperSubViewpoint.Nationality] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Nationality].ToString().Trim(); //国籍
objPaperSubViewpointEN.Achievement = objRow[conPaperSubViewpoint.Achievement] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Achievement].ToString().Trim(); //成就
objPaperSubViewpointEN.Major = objRow[conPaperSubViewpoint.Major] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Major].ToString().Trim(); //专业
objPaperSubViewpointEN.WorkUnit = objRow[conPaperSubViewpoint.WorkUnit] == DBNull.Value ? null : objRow[conPaperSubViewpoint.WorkUnit].ToString().Trim(); //工作单位
objPaperSubViewpointEN.PageNumber = objRow[conPaperSubViewpoint.PageNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.PageNumber].ToString().Trim()); //页码
objPaperSubViewpointEN.OrderNum = objRow[conPaperSubViewpoint.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.OrderNum].ToString().Trim()); //序号
objPaperSubViewpointEN.PdfContent = objRow[conPaperSubViewpoint.PdfContent] == DBNull.Value ? null : objRow[conPaperSubViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objPaperSubViewpointEN.selectSpanRange = objRow[conPaperSubViewpoint.selectSpanRange] == DBNull.Value ? null : objRow[conPaperSubViewpoint.selectSpanRange].ToString().Trim(); //选择Span范围
objPaperSubViewpointEN.PaperLineNum = objRow[conPaperSubViewpoint.PaperLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.PaperLineNum].ToString().Trim()); //论文行号
objPaperSubViewpointEN.PaperPageNum = objRow[conPaperSubViewpoint.PaperPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.PaperPageNum].ToString().Trim()); //论文页码
objPaperSubViewpointEN.AppraiseCount = objRow[conPaperSubViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.AppraiseCount].ToString().Trim()); //评论数
objPaperSubViewpointEN.OkCount = objRow[conPaperSubViewpoint.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.OkCount].ToString().Trim()); //点赞统计
objPaperSubViewpointEN.Score = objRow[conPaperSubViewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaperSubViewpoint.Score].ToString().Trim()); //评分
objPaperSubViewpointEN.StuScore = objRow[conPaperSubViewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaperSubViewpoint.StuScore].ToString().Trim()); //学生平均分
objPaperSubViewpointEN.TeaScore = objRow[conPaperSubViewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPaperSubViewpoint.TeaScore].ToString().Trim()); //教师评分
objPaperSubViewpointEN.CreateDate = objRow[conPaperSubViewpoint.CreateDate] == DBNull.Value ? null : objRow[conPaperSubViewpoint.CreateDate].ToString().Trim(); //建立日期
objPaperSubViewpointEN.ShareId = objRow[conPaperSubViewpoint.ShareId].ToString().Trim(); //分享Id
objPaperSubViewpointEN.TopicId = objRow[conPaperSubViewpoint.TopicId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.TopicId].ToString().Trim(); //主题Id
objPaperSubViewpointEN.AttitudesId = objRow[conPaperSubViewpoint.AttitudesId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.AttitudesId].ToString().Trim(); //态度Id
objPaperSubViewpointEN.VersionCount = objRow[conPaperSubViewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.VersionCount].ToString().Trim()); //版本统计
objPaperSubViewpointEN.CitationCount = objRow[conPaperSubViewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperSubViewpoint.CitationCount].ToString().Trim()); //引用统计
objPaperSubViewpointEN.CourseId = objRow[conPaperSubViewpoint.CourseId] == DBNull.Value ? null : objRow[conPaperSubViewpoint.CourseId].ToString().Trim(); //课程Id
objPaperSubViewpointEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conPaperSubViewpoint.IsRecommend].ToString().Trim()); //是否推荐
objPaperSubViewpointEN.UpdDate = objRow[conPaperSubViewpoint.UpdDate] == DBNull.Value ? null : objRow[conPaperSubViewpoint.UpdDate].ToString().Trim(); //修改日期
objPaperSubViewpointEN.UpdUser = objRow[conPaperSubViewpoint.UpdUser] == DBNull.Value ? null : objRow[conPaperSubViewpoint.UpdUser].ToString().Trim(); //修改人
objPaperSubViewpointEN.Memo = objRow[conPaperSubViewpoint.Memo] == DBNull.Value ? null : objRow[conPaperSubViewpoint.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperSubViewpointEN.SubViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperSubViewpointEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetPaperSubViewpoint(ref clsPaperSubViewpointEN objPaperSubViewpointEN)
{
bool bolResult = PaperSubViewpointDA.GetPaperSubViewpoint(ref objPaperSubViewpointEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngSubViewpointId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPaperSubViewpointEN GetObjBySubViewpointId(long lngSubViewpointId)
{
clsPaperSubViewpointEN objPaperSubViewpointEN = PaperSubViewpointDA.GetObjBySubViewpointId(lngSubViewpointId);
return objPaperSubViewpointEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsPaperSubViewpointEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsPaperSubViewpointEN objPaperSubViewpointEN = PaperSubViewpointDA.GetFirstObj(strWhereCond);
 return objPaperSubViewpointEN;
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
public static clsPaperSubViewpointEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsPaperSubViewpointEN objPaperSubViewpointEN = PaperSubViewpointDA.GetObjByDataRow(objRow);
 return objPaperSubViewpointEN;
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
public static clsPaperSubViewpointEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsPaperSubViewpointEN objPaperSubViewpointEN = PaperSubViewpointDA.GetObjByDataRow(objRow);
 return objPaperSubViewpointEN;
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
 /// <param name = "lngSubViewpointId">所给的关键字</param>
 /// <param name = "lstPaperSubViewpointObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPaperSubViewpointEN GetObjBySubViewpointIdFromList(long lngSubViewpointId, List<clsPaperSubViewpointEN> lstPaperSubViewpointObjLst)
{
foreach (clsPaperSubViewpointEN objPaperSubViewpointEN in lstPaperSubViewpointObjLst)
{
if (objPaperSubViewpointEN.SubViewpointId == lngSubViewpointId)
{
return objPaperSubViewpointEN;
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
 long lngSubViewpointId;
 try
 {
 lngSubViewpointId = new clsPaperSubViewpointDA().GetFirstID(strWhereCond);
 return lngSubViewpointId;
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
 arrList = PaperSubViewpointDA.GetID(strWhereCond);
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
bool bolIsExist = PaperSubViewpointDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngSubViewpointId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngSubViewpointId)
{
//检测记录是否存在
bool bolIsExist = PaperSubViewpointDA.IsExist(lngSubViewpointId);
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
 bolIsExist = clsPaperSubViewpointDA.IsExistTable();
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
 bolIsExist = PaperSubViewpointDA.IsExistTable(strTabName);
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
 /// <param name = "objPaperSubViewpointEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsPaperSubViewpointEN objPaperSubViewpointEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objPaperSubViewpointEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!论文Id = [{0}],类型Id = [{1}],用户ID = [{2}],详情内容 = [{3}]的数据已经存在!(in clsPaperSubViewpointBL.AddNewRecordBySql2)", objPaperSubViewpointEN.PaperId,objPaperSubViewpointEN.SubViewpointTypeId,objPaperSubViewpointEN.UserId,objPaperSubViewpointEN.SubViewpointContent);
throw new Exception(strMsg);
}
try
{
bool bolResult = PaperSubViewpointDA.AddNewRecordBySQL2(objPaperSubViewpointEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubViewpointBL.ReFreshCache(objPaperSubViewpointEN.IdCurrEduCls);

if (clsPaperSubViewpointBL.relatedActions != null)
{
clsPaperSubViewpointBL.relatedActions.UpdRelaTabDate(objPaperSubViewpointEN.SubViewpointId, "SetUpdDate");
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
 /// <param name = "objPaperSubViewpointEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsPaperSubViewpointEN objPaperSubViewpointEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objPaperSubViewpointEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!论文Id = [{0}],类型Id = [{1}],用户ID = [{2}],详情内容 = [{3}]的数据已经存在!(in clsPaperSubViewpointBL.AddNewRecordBySql2WithReturnKey)", objPaperSubViewpointEN.PaperId,objPaperSubViewpointEN.SubViewpointTypeId,objPaperSubViewpointEN.UserId,objPaperSubViewpointEN.SubViewpointContent);
throw new Exception(strMsg);
}
try
{
string strKey = PaperSubViewpointDA.AddNewRecordBySQL2WithReturnKey(objPaperSubViewpointEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubViewpointBL.ReFreshCache(objPaperSubViewpointEN.IdCurrEduCls);

if (clsPaperSubViewpointBL.relatedActions != null)
{
clsPaperSubViewpointBL.relatedActions.UpdRelaTabDate(objPaperSubViewpointEN.SubViewpointId, "SetUpdDate");
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
 /// <param name = "objPaperSubViewpointEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsPaperSubViewpointEN objPaperSubViewpointEN)
{
try
{
bool bolResult = PaperSubViewpointDA.Update(objPaperSubViewpointEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubViewpointBL.ReFreshCache(objPaperSubViewpointEN.IdCurrEduCls);

if (clsPaperSubViewpointBL.relatedActions != null)
{
clsPaperSubViewpointBL.relatedActions.UpdRelaTabDate(objPaperSubViewpointEN.SubViewpointId, "SetUpdDate");
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
 /// <param name = "objPaperSubViewpointEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsPaperSubViewpointEN objPaperSubViewpointEN)
{
 if (objPaperSubViewpointEN.SubViewpointId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = PaperSubViewpointDA.UpdateBySql2(objPaperSubViewpointEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubViewpointBL.ReFreshCache(objPaperSubViewpointEN.IdCurrEduCls);

if (clsPaperSubViewpointBL.relatedActions != null)
{
clsPaperSubViewpointBL.relatedActions.UpdRelaTabDate(objPaperSubViewpointEN.SubViewpointId, "SetUpdDate");
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
 /// <param name = "lngSubViewpointId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngSubViewpointId)
{
try
{
 clsPaperSubViewpointEN objPaperSubViewpointEN = clsPaperSubViewpointBL.GetObjBySubViewpointId(lngSubViewpointId);

if (clsPaperSubViewpointBL.relatedActions != null)
{
clsPaperSubViewpointBL.relatedActions.UpdRelaTabDate(objPaperSubViewpointEN.SubViewpointId, "SetUpdDate");
}
if (objPaperSubViewpointEN != null)
{
int intRecNum = PaperSubViewpointDA.DelRecord(lngSubViewpointId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objPaperSubViewpointEN.IdCurrEduCls);
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
/// <param name="lngSubViewpointId">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(long lngSubViewpointId , string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPaperSubViewpointDA.GetSpecSQLObj();
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
//删除与表:[PaperSubViewpoint]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conPaperSubViewpoint.SubViewpointId,
//lngSubViewpointId);
//        clsPaperSubViewpointBL.DelPaperSubViewpointsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPaperSubViewpointBL.DelRecord(lngSubViewpointId, strIdCurrEduCls, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPaperSubViewpointBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngSubViewpointId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngSubViewpointId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngSubViewpointId, string strIdCurrEduCls, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsPaperSubViewpointBL.relatedActions != null)
{
clsPaperSubViewpointBL.relatedActions.UpdRelaTabDate(lngSubViewpointId, "UpdRelaTabDate");
}
bool bolResult = PaperSubViewpointDA.DelRecord(lngSubViewpointId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrSubViewpointIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelPaperSubViewpoints(List<string> arrSubViewpointIdLst)
{
if (arrSubViewpointIdLst.Count == 0) return 0;
try
{
if (clsPaperSubViewpointBL.relatedActions != null)
{
foreach (var strSubViewpointId in arrSubViewpointIdLst)
{
long lngSubViewpointId = long.Parse(strSubViewpointId);
clsPaperSubViewpointBL.relatedActions.UpdRelaTabDate(lngSubViewpointId, "UpdRelaTabDate");
}
}
 clsPaperSubViewpointEN objPaperSubViewpointEN = clsPaperSubViewpointBL.GetObjBySubViewpointId(long.Parse(arrSubViewpointIdLst[0]));
int intDelRecNum = PaperSubViewpointDA.DelPaperSubViewpoint(arrSubViewpointIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objPaperSubViewpointEN.IdCurrEduCls);
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
public static int DelPaperSubViewpointsByCond(string strWhereCond)
{
try
{
if (clsPaperSubViewpointBL.relatedActions != null)
{
List<string> arrSubViewpointId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strSubViewpointId in arrSubViewpointId)
{
long lngSubViewpointId = long.Parse(strSubViewpointId);
clsPaperSubViewpointBL.relatedActions.UpdRelaTabDate(lngSubViewpointId, "UpdRelaTabDate");
}
}
List<string> arrIdCurrEduCls = GetFldValue(conPaperSubViewpoint.IdCurrEduCls, strWhereCond);
int intRecNum = PaperSubViewpointDA.DelPaperSubViewpoint(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[PaperSubViewpoint]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngSubViewpointId">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngSubViewpointId, string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPaperSubViewpointDA.GetSpecSQLObj();
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
//删除与表:[PaperSubViewpoint]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPaperSubViewpointBL.DelRecord(lngSubViewpointId, strIdCurrEduCls, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPaperSubViewpointBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngSubViewpointId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objPaperSubViewpointENS">源对象</param>
 /// <param name = "objPaperSubViewpointENT">目标对象</param>
 public static void CopyTo(clsPaperSubViewpointEN objPaperSubViewpointENS, clsPaperSubViewpointEN objPaperSubViewpointENT)
{
try
{
objPaperSubViewpointENT.SubViewpointId = objPaperSubViewpointENS.SubViewpointId; //子观点Id
objPaperSubViewpointENT.SubViewpointContent = objPaperSubViewpointENS.SubViewpointContent; //详情内容
objPaperSubViewpointENT.PaperRWId = objPaperSubViewpointENS.PaperRWId; //课文阅读
objPaperSubViewpointENT.PaperId = objPaperSubViewpointENS.PaperId; //论文Id
objPaperSubViewpointENT.IdCurrEduCls = objPaperSubViewpointENS.IdCurrEduCls; //教学班流水号
objPaperSubViewpointENT.UserId = objPaperSubViewpointENS.UserId; //用户ID
objPaperSubViewpointENT.SectionId = objPaperSubViewpointENS.SectionId; //节Id
objPaperSubViewpointENT.SubViewpointTypeId = objPaperSubViewpointENS.SubViewpointTypeId; //类型Id
objPaperSubViewpointENT.gsKnowledgeTypeId = objPaperSubViewpointENS.gsKnowledgeTypeId; //知识类型Id
objPaperSubViewpointENT.RWTitle = objPaperSubViewpointENS.RWTitle; //读写标题
objPaperSubViewpointENT.ExplainTypeId = objPaperSubViewpointENS.ExplainTypeId; //说明类型Id
objPaperSubViewpointENT.ExplainContent = objPaperSubViewpointENS.ExplainContent; //说明内容
objPaperSubViewpointENT.IsPublic = objPaperSubViewpointENS.IsPublic; //是否公开
objPaperSubViewpointENT.LiteratureSourcesId = objPaperSubViewpointENS.LiteratureSourcesId; //文献来源
objPaperSubViewpointENT.OperationTypeId = objPaperSubViewpointENS.OperationTypeId; //操作类型ID
objPaperSubViewpointENT.LevelId = objPaperSubViewpointENS.LevelId; //级别Id
objPaperSubViewpointENT.Conclusion = objPaperSubViewpointENS.Conclusion; //结论
objPaperSubViewpointENT.Nationality = objPaperSubViewpointENS.Nationality; //国籍
objPaperSubViewpointENT.Achievement = objPaperSubViewpointENS.Achievement; //成就
objPaperSubViewpointENT.Major = objPaperSubViewpointENS.Major; //专业
objPaperSubViewpointENT.WorkUnit = objPaperSubViewpointENS.WorkUnit; //工作单位
objPaperSubViewpointENT.PageNumber = objPaperSubViewpointENS.PageNumber; //页码
objPaperSubViewpointENT.OrderNum = objPaperSubViewpointENS.OrderNum; //序号
objPaperSubViewpointENT.PdfContent = objPaperSubViewpointENS.PdfContent; //Pdf内容
objPaperSubViewpointENT.selectSpanRange = objPaperSubViewpointENS.selectSpanRange; //选择Span范围
objPaperSubViewpointENT.PaperLineNum = objPaperSubViewpointENS.PaperLineNum; //论文行号
objPaperSubViewpointENT.PaperPageNum = objPaperSubViewpointENS.PaperPageNum; //论文页码
objPaperSubViewpointENT.AppraiseCount = objPaperSubViewpointENS.AppraiseCount; //评论数
objPaperSubViewpointENT.OkCount = objPaperSubViewpointENS.OkCount; //点赞统计
objPaperSubViewpointENT.Score = objPaperSubViewpointENS.Score; //评分
objPaperSubViewpointENT.StuScore = objPaperSubViewpointENS.StuScore; //学生平均分
objPaperSubViewpointENT.TeaScore = objPaperSubViewpointENS.TeaScore; //教师评分
objPaperSubViewpointENT.CreateDate = objPaperSubViewpointENS.CreateDate; //建立日期
objPaperSubViewpointENT.ShareId = objPaperSubViewpointENS.ShareId; //分享Id
objPaperSubViewpointENT.TopicId = objPaperSubViewpointENS.TopicId; //主题Id
objPaperSubViewpointENT.AttitudesId = objPaperSubViewpointENS.AttitudesId; //态度Id
objPaperSubViewpointENT.VersionCount = objPaperSubViewpointENS.VersionCount; //版本统计
objPaperSubViewpointENT.CitationCount = objPaperSubViewpointENS.CitationCount; //引用统计
objPaperSubViewpointENT.CourseId = objPaperSubViewpointENS.CourseId; //课程Id
objPaperSubViewpointENT.IsRecommend = objPaperSubViewpointENS.IsRecommend; //是否推荐
objPaperSubViewpointENT.UpdDate = objPaperSubViewpointENS.UpdDate; //修改日期
objPaperSubViewpointENT.UpdUser = objPaperSubViewpointENS.UpdUser; //修改人
objPaperSubViewpointENT.Memo = objPaperSubViewpointENS.Memo; //备注
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
 /// <param name = "objPaperSubViewpointEN">源简化对象</param>
 public static void SetUpdFlag(clsPaperSubViewpointEN objPaperSubViewpointEN)
{
try
{
objPaperSubViewpointEN.ClearUpdateState();
   string strsfUpdFldSetStr = objPaperSubViewpointEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conPaperSubViewpoint.SubViewpointId, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubViewpointEN.SubViewpointId = objPaperSubViewpointEN.SubViewpointId; //子观点Id
}
if (arrFldSet.Contains(conPaperSubViewpoint.SubViewpointContent, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubViewpointEN.SubViewpointContent = objPaperSubViewpointEN.SubViewpointContent == "[null]" ? null :  objPaperSubViewpointEN.SubViewpointContent; //详情内容
}
if (arrFldSet.Contains(conPaperSubViewpoint.PaperRWId, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubViewpointEN.PaperRWId = objPaperSubViewpointEN.PaperRWId == "[null]" ? null :  objPaperSubViewpointEN.PaperRWId; //课文阅读
}
if (arrFldSet.Contains(conPaperSubViewpoint.PaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubViewpointEN.PaperId = objPaperSubViewpointEN.PaperId; //论文Id
}
if (arrFldSet.Contains(conPaperSubViewpoint.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubViewpointEN.IdCurrEduCls = objPaperSubViewpointEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conPaperSubViewpoint.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubViewpointEN.UserId = objPaperSubViewpointEN.UserId; //用户ID
}
if (arrFldSet.Contains(conPaperSubViewpoint.SectionId, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubViewpointEN.SectionId = objPaperSubViewpointEN.SectionId == "[null]" ? null :  objPaperSubViewpointEN.SectionId; //节Id
}
if (arrFldSet.Contains(conPaperSubViewpoint.SubViewpointTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubViewpointEN.SubViewpointTypeId = objPaperSubViewpointEN.SubViewpointTypeId; //类型Id
}
if (arrFldSet.Contains(conPaperSubViewpoint.gsKnowledgeTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubViewpointEN.gsKnowledgeTypeId = objPaperSubViewpointEN.gsKnowledgeTypeId; //知识类型Id
}
if (arrFldSet.Contains(conPaperSubViewpoint.RWTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubViewpointEN.RWTitle = objPaperSubViewpointEN.RWTitle == "[null]" ? null :  objPaperSubViewpointEN.RWTitle; //读写标题
}
if (arrFldSet.Contains(conPaperSubViewpoint.ExplainTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubViewpointEN.ExplainTypeId = objPaperSubViewpointEN.ExplainTypeId == "[null]" ? null :  objPaperSubViewpointEN.ExplainTypeId; //说明类型Id
}
if (arrFldSet.Contains(conPaperSubViewpoint.ExplainContent, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubViewpointEN.ExplainContent = objPaperSubViewpointEN.ExplainContent == "[null]" ? null :  objPaperSubViewpointEN.ExplainContent; //说明内容
}
if (arrFldSet.Contains(conPaperSubViewpoint.IsPublic, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubViewpointEN.IsPublic = objPaperSubViewpointEN.IsPublic; //是否公开
}
if (arrFldSet.Contains(conPaperSubViewpoint.LiteratureSourcesId, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubViewpointEN.LiteratureSourcesId = objPaperSubViewpointEN.LiteratureSourcesId == "[null]" ? null :  objPaperSubViewpointEN.LiteratureSourcesId; //文献来源
}
if (arrFldSet.Contains(conPaperSubViewpoint.OperationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubViewpointEN.OperationTypeId = objPaperSubViewpointEN.OperationTypeId == "[null]" ? null :  objPaperSubViewpointEN.OperationTypeId; //操作类型ID
}
if (arrFldSet.Contains(conPaperSubViewpoint.LevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubViewpointEN.LevelId = objPaperSubViewpointEN.LevelId == "[null]" ? null :  objPaperSubViewpointEN.LevelId; //级别Id
}
if (arrFldSet.Contains(conPaperSubViewpoint.Conclusion, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubViewpointEN.Conclusion = objPaperSubViewpointEN.Conclusion == "[null]" ? null :  objPaperSubViewpointEN.Conclusion; //结论
}
if (arrFldSet.Contains(conPaperSubViewpoint.Nationality, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubViewpointEN.Nationality = objPaperSubViewpointEN.Nationality == "[null]" ? null :  objPaperSubViewpointEN.Nationality; //国籍
}
if (arrFldSet.Contains(conPaperSubViewpoint.Achievement, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubViewpointEN.Achievement = objPaperSubViewpointEN.Achievement == "[null]" ? null :  objPaperSubViewpointEN.Achievement; //成就
}
if (arrFldSet.Contains(conPaperSubViewpoint.Major, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubViewpointEN.Major = objPaperSubViewpointEN.Major == "[null]" ? null :  objPaperSubViewpointEN.Major; //专业
}
if (arrFldSet.Contains(conPaperSubViewpoint.WorkUnit, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubViewpointEN.WorkUnit = objPaperSubViewpointEN.WorkUnit == "[null]" ? null :  objPaperSubViewpointEN.WorkUnit; //工作单位
}
if (arrFldSet.Contains(conPaperSubViewpoint.PageNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubViewpointEN.PageNumber = objPaperSubViewpointEN.PageNumber; //页码
}
if (arrFldSet.Contains(conPaperSubViewpoint.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubViewpointEN.OrderNum = objPaperSubViewpointEN.OrderNum; //序号
}
if (arrFldSet.Contains(conPaperSubViewpoint.PdfContent, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubViewpointEN.PdfContent = objPaperSubViewpointEN.PdfContent == "[null]" ? null :  objPaperSubViewpointEN.PdfContent; //Pdf内容
}
if (arrFldSet.Contains(conPaperSubViewpoint.selectSpanRange, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubViewpointEN.selectSpanRange = objPaperSubViewpointEN.selectSpanRange == "[null]" ? null :  objPaperSubViewpointEN.selectSpanRange; //选择Span范围
}
if (arrFldSet.Contains(conPaperSubViewpoint.PaperLineNum, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubViewpointEN.PaperLineNum = objPaperSubViewpointEN.PaperLineNum; //论文行号
}
if (arrFldSet.Contains(conPaperSubViewpoint.PaperPageNum, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubViewpointEN.PaperPageNum = objPaperSubViewpointEN.PaperPageNum; //论文页码
}
if (arrFldSet.Contains(conPaperSubViewpoint.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubViewpointEN.AppraiseCount = objPaperSubViewpointEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(conPaperSubViewpoint.OkCount, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubViewpointEN.OkCount = objPaperSubViewpointEN.OkCount; //点赞统计
}
if (arrFldSet.Contains(conPaperSubViewpoint.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubViewpointEN.Score = objPaperSubViewpointEN.Score; //评分
}
if (arrFldSet.Contains(conPaperSubViewpoint.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubViewpointEN.StuScore = objPaperSubViewpointEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(conPaperSubViewpoint.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubViewpointEN.TeaScore = objPaperSubViewpointEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(conPaperSubViewpoint.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubViewpointEN.CreateDate = objPaperSubViewpointEN.CreateDate == "[null]" ? null :  objPaperSubViewpointEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(conPaperSubViewpoint.ShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubViewpointEN.ShareId = objPaperSubViewpointEN.ShareId; //分享Id
}
if (arrFldSet.Contains(conPaperSubViewpoint.TopicId, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubViewpointEN.TopicId = objPaperSubViewpointEN.TopicId == "[null]" ? null :  objPaperSubViewpointEN.TopicId; //主题Id
}
if (arrFldSet.Contains(conPaperSubViewpoint.AttitudesId, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubViewpointEN.AttitudesId = objPaperSubViewpointEN.AttitudesId == "[null]" ? null :  objPaperSubViewpointEN.AttitudesId; //态度Id
}
if (arrFldSet.Contains(conPaperSubViewpoint.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubViewpointEN.VersionCount = objPaperSubViewpointEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(conPaperSubViewpoint.CitationCount, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubViewpointEN.CitationCount = objPaperSubViewpointEN.CitationCount; //引用统计
}
if (arrFldSet.Contains(conPaperSubViewpoint.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubViewpointEN.CourseId = objPaperSubViewpointEN.CourseId == "[null]" ? null :  objPaperSubViewpointEN.CourseId; //课程Id
}
if (arrFldSet.Contains(conPaperSubViewpoint.IsRecommend, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubViewpointEN.IsRecommend = objPaperSubViewpointEN.IsRecommend; //是否推荐
}
if (arrFldSet.Contains(conPaperSubViewpoint.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubViewpointEN.UpdDate = objPaperSubViewpointEN.UpdDate == "[null]" ? null :  objPaperSubViewpointEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conPaperSubViewpoint.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubViewpointEN.UpdUser = objPaperSubViewpointEN.UpdUser == "[null]" ? null :  objPaperSubViewpointEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conPaperSubViewpoint.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubViewpointEN.Memo = objPaperSubViewpointEN.Memo == "[null]" ? null :  objPaperSubViewpointEN.Memo; //备注
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
 /// <param name = "objPaperSubViewpointEN">源简化对象</param>
 public static void AccessFldValueNull(clsPaperSubViewpointEN objPaperSubViewpointEN)
{
try
{
if (objPaperSubViewpointEN.SubViewpointContent == "[null]") objPaperSubViewpointEN.SubViewpointContent = null; //详情内容
if (objPaperSubViewpointEN.PaperRWId == "[null]") objPaperSubViewpointEN.PaperRWId = null; //课文阅读
if (objPaperSubViewpointEN.SectionId == "[null]") objPaperSubViewpointEN.SectionId = null; //节Id
if (objPaperSubViewpointEN.RWTitle == "[null]") objPaperSubViewpointEN.RWTitle = null; //读写标题
if (objPaperSubViewpointEN.ExplainTypeId == "[null]") objPaperSubViewpointEN.ExplainTypeId = null; //说明类型Id
if (objPaperSubViewpointEN.ExplainContent == "[null]") objPaperSubViewpointEN.ExplainContent = null; //说明内容
if (objPaperSubViewpointEN.LiteratureSourcesId == "[null]") objPaperSubViewpointEN.LiteratureSourcesId = null; //文献来源
if (objPaperSubViewpointEN.OperationTypeId == "[null]") objPaperSubViewpointEN.OperationTypeId = null; //操作类型ID
if (objPaperSubViewpointEN.LevelId == "[null]") objPaperSubViewpointEN.LevelId = null; //级别Id
if (objPaperSubViewpointEN.Conclusion == "[null]") objPaperSubViewpointEN.Conclusion = null; //结论
if (objPaperSubViewpointEN.Nationality == "[null]") objPaperSubViewpointEN.Nationality = null; //国籍
if (objPaperSubViewpointEN.Achievement == "[null]") objPaperSubViewpointEN.Achievement = null; //成就
if (objPaperSubViewpointEN.Major == "[null]") objPaperSubViewpointEN.Major = null; //专业
if (objPaperSubViewpointEN.WorkUnit == "[null]") objPaperSubViewpointEN.WorkUnit = null; //工作单位
if (objPaperSubViewpointEN.PdfContent == "[null]") objPaperSubViewpointEN.PdfContent = null; //Pdf内容
if (objPaperSubViewpointEN.selectSpanRange == "[null]") objPaperSubViewpointEN.selectSpanRange = null; //选择Span范围
if (objPaperSubViewpointEN.CreateDate == "[null]") objPaperSubViewpointEN.CreateDate = null; //建立日期
if (objPaperSubViewpointEN.TopicId == "[null]") objPaperSubViewpointEN.TopicId = null; //主题Id
if (objPaperSubViewpointEN.AttitudesId == "[null]") objPaperSubViewpointEN.AttitudesId = null; //态度Id
if (objPaperSubViewpointEN.CourseId == "[null]") objPaperSubViewpointEN.CourseId = null; //课程Id
if (objPaperSubViewpointEN.UpdDate == "[null]") objPaperSubViewpointEN.UpdDate = null; //修改日期
if (objPaperSubViewpointEN.UpdUser == "[null]") objPaperSubViewpointEN.UpdUser = null; //修改人
if (objPaperSubViewpointEN.Memo == "[null]") objPaperSubViewpointEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsPaperSubViewpointEN objPaperSubViewpointEN)
{
 PaperSubViewpointDA.CheckPropertyNew(objPaperSubViewpointEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsPaperSubViewpointEN objPaperSubViewpointEN)
{
 PaperSubViewpointDA.CheckProperty4Condition(objPaperSubViewpointEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_SubViewpointIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strIdCurrEduCls)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[子观点表]...","0");
List<clsPaperSubViewpointEN> arrPaperSubViewpointObjLst = GetAllPaperSubViewpointObjLstCache(strIdCurrEduCls); 
arrPaperSubViewpointObjLst = arrPaperSubViewpointObjLst.OrderBy(x=>x.OrderNum).ToList(); 
objDDL.DataValueField = conPaperSubViewpoint.SubViewpointId;
objDDL.DataTextField = conPaperSubViewpoint.SubViewpointContent;
objDDL.DataSource = arrPaperSubViewpointObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}


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
if (clsPaperSubViewpointBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperSubViewpointBL没有刷新缓存机制(clsPaperSubViewpointBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by SubViewpointId");
//if (arrPaperSubViewpointObjLstCache == null)
//{
//arrPaperSubViewpointObjLstCache = PaperSubViewpointDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngSubViewpointId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPaperSubViewpointEN GetObjBySubViewpointIdCache(long lngSubViewpointId, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsPaperSubViewpointEN._CurrTabName, strIdCurrEduCls);
List<clsPaperSubViewpointEN> arrPaperSubViewpointObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsPaperSubViewpointEN> arrPaperSubViewpointObjLst_Sel =
arrPaperSubViewpointObjLstCache
.Where(x=> x.SubViewpointId == lngSubViewpointId 
);
if (arrPaperSubViewpointObjLst_Sel.Count() == 0)
{
   clsPaperSubViewpointEN obj = clsPaperSubViewpointBL.GetObjBySubViewpointId(lngSubViewpointId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngSubViewpointId, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrPaperSubViewpointObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "lngSubViewpointId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetSubViewpointContentBySubViewpointIdCache(long lngSubViewpointId, string strIdCurrEduCls)
{
//获取缓存中的对象列表
clsPaperSubViewpointEN objPaperSubViewpoint = GetObjBySubViewpointIdCache(lngSubViewpointId, strIdCurrEduCls);
if (objPaperSubViewpoint == null) return "";
return objPaperSubViewpoint.SubViewpointContent;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "lngSubViewpointId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameBySubViewpointIdCache(long lngSubViewpointId, string strIdCurrEduCls)
{
//获取缓存中的对象列表
clsPaperSubViewpointEN objPaperSubViewpoint = GetObjBySubViewpointIdCache(lngSubViewpointId, strIdCurrEduCls);
if (objPaperSubViewpoint == null) return "";
return objPaperSubViewpoint.SubViewpointContent;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPaperSubViewpointEN> GetAllPaperSubViewpointObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsPaperSubViewpointEN> arrPaperSubViewpointObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrPaperSubViewpointObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPaperSubViewpointEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsPaperSubViewpointEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsPaperSubViewpointEN> arrPaperSubViewpointObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrPaperSubViewpointObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsPaperSubViewpointEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clsPaperSubViewpointEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsPaperSubViewpointEN._RefreshTimeLst.Count == 0) return "";
return clsPaperSubViewpointEN._RefreshTimeLst[clsPaperSubViewpointEN._RefreshTimeLst.Count - 1];
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
if (clsPaperSubViewpointBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsPaperSubViewpointEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clsPaperSubViewpointEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsPaperSubViewpointBL.objCommFun4BL.ReFreshCache(strIdCurrEduCls);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--PaperSubViewpoint(子观点表)
 /// 唯一性条件:PaperId_SubViewpointTypeId_UserId_SubViewpointContent
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objPaperSubViewpointEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsPaperSubViewpointEN objPaperSubViewpointEN)
{
//检测记录是否存在
string strResult = PaperSubViewpointDA.GetUniCondStr(objPaperSubViewpointEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngSubViewpointId, string strIdCurrEduCls)
{
if (strInFldName != conPaperSubViewpoint.SubViewpointId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conPaperSubViewpoint.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conPaperSubViewpoint.AttributeName));
throw new Exception(strMsg);
}
var objPaperSubViewpoint = clsPaperSubViewpointBL.GetObjBySubViewpointIdCache(lngSubViewpointId, strIdCurrEduCls);
if (objPaperSubViewpoint == null) return "";
return objPaperSubViewpoint[strOutFldName].ToString();
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
int intRecCount = clsPaperSubViewpointDA.GetRecCount(strTabName);
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
int intRecCount = clsPaperSubViewpointDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsPaperSubViewpointDA.GetRecCount();
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
int intRecCount = clsPaperSubViewpointDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objPaperSubViewpointCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsPaperSubViewpointEN objPaperSubViewpointCond)
{
 string strIdCurrEduCls = objPaperSubViewpointCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsPaperSubViewpointBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsPaperSubViewpointEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsPaperSubViewpointEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPaperSubViewpoint.AttributeName)
{
if (objPaperSubViewpointCond.IsUpdated(strFldName) == false) continue;
if (objPaperSubViewpointCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPaperSubViewpointCond[strFldName].ToString());
}
else
{
if (objPaperSubViewpointCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPaperSubViewpointCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPaperSubViewpointCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPaperSubViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPaperSubViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPaperSubViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPaperSubViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPaperSubViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPaperSubViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPaperSubViewpointCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPaperSubViewpointCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPaperSubViewpointCond[strFldName]));
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
 List<string> arrList = clsPaperSubViewpointDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = PaperSubViewpointDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = PaperSubViewpointDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = PaperSubViewpointDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsPaperSubViewpointDA.SetFldValue(clsPaperSubViewpointEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = PaperSubViewpointDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsPaperSubViewpointDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsPaperSubViewpointDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsPaperSubViewpointDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[PaperSubViewpoint] "); 
 strCreateTabCode.Append(" ( "); 
 // /**子观点Id*/ 
 strCreateTabCode.Append(" SubViewpointId bigint primary key identity, "); 
 // /**详情内容*/ 
 strCreateTabCode.Append(" SubViewpointContent varchar(500) Null, "); 
 // /**课文阅读*/ 
 strCreateTabCode.Append(" PaperRWId char(8) Null, "); 
 // /**论文Id*/ 
 strCreateTabCode.Append(" PaperId char(8) not Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) not Null, "); 
 // /**用户ID*/ 
 strCreateTabCode.Append(" UserId varchar(18) not Null, "); 
 // /**节Id*/ 
 strCreateTabCode.Append(" SectionId char(8) Null, "); 
 // /**类型Id*/ 
 strCreateTabCode.Append(" SubViewpointTypeId char(8) not Null, "); 
 // /**知识类型Id*/ 
 strCreateTabCode.Append(" gsKnowledgeTypeId char(2) not Null, "); 
 // /**读写标题*/ 
 strCreateTabCode.Append(" RWTitle varchar(50) Null, "); 
 // /**说明类型Id*/ 
 strCreateTabCode.Append(" ExplainTypeId char(2) Null, "); 
 // /**说明内容*/ 
 strCreateTabCode.Append(" ExplainContent varchar(5000) Null, "); 
 // /**是否公开*/ 
 strCreateTabCode.Append(" IsPublic bit Null, "); 
 // /**文献来源*/ 
 strCreateTabCode.Append(" LiteratureSourcesId char(8) Null, "); 
 // /**操作类型ID*/ 
 strCreateTabCode.Append(" OperationTypeId char(4) Null, "); 
 // /**级别Id*/ 
 strCreateTabCode.Append(" LevelId char(2) Null, "); 
 // /**结论*/ 
 strCreateTabCode.Append(" Conclusion varchar(5000) Null, "); 
 // /**国籍*/ 
 strCreateTabCode.Append(" Nationality varchar(50) Null, "); 
 // /**成就*/ 
 strCreateTabCode.Append(" Achievement varchar(5000) Null, "); 
 // /**专业*/ 
 strCreateTabCode.Append(" Major varchar(50) Null, "); 
 // /**工作单位*/ 
 strCreateTabCode.Append(" WorkUnit varchar(100) Null, "); 
 // /**页码*/ 
 strCreateTabCode.Append(" PageNumber int Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**Pdf内容*/ 
 strCreateTabCode.Append(" PdfContent varchar(2000) Null, "); 
 // /**选择Span范围*/ 
 strCreateTabCode.Append(" selectSpanRange varchar(50) Null, "); 
 // /**论文行号*/ 
 strCreateTabCode.Append(" PaperLineNum int Null, "); 
 // /**论文页码*/ 
 strCreateTabCode.Append(" PaperPageNum int Null, "); 
 // /**评论数*/ 
 strCreateTabCode.Append(" AppraiseCount int Null, "); 
 // /**点赞统计*/ 
 strCreateTabCode.Append(" OkCount int Null, "); 
 // /**评分*/ 
 strCreateTabCode.Append(" Score float Null, "); 
 // /**学生平均分*/ 
 strCreateTabCode.Append(" StuScore float Null, "); 
 // /**教师评分*/ 
 strCreateTabCode.Append(" TeaScore float Null, "); 
 // /**建立日期*/ 
 strCreateTabCode.Append(" CreateDate varchar(20) Null, "); 
 // /**分享Id*/ 
 strCreateTabCode.Append(" ShareId char(2) not Null, "); 
 // /**主题Id*/ 
 strCreateTabCode.Append(" TopicId char(8) Null, "); 
 // /**态度Id*/ 
 strCreateTabCode.Append(" AttitudesId char(2) Null, "); 
 // /**版本统计*/ 
 strCreateTabCode.Append(" VersionCount int Null, "); 
 // /**引用统计*/ 
 strCreateTabCode.Append(" CitationCount int Null, "); 
 // /**课程Id*/ 
 strCreateTabCode.Append(" CourseId char(8) Null, "); 
 // /**是否推荐*/ 
 strCreateTabCode.Append(" IsRecommend bit Null, "); 
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


 #region 排序相关函数

/// <summary>
/// 重新排序。根据分类字段：PaperRWId,SubViewpointTypeId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ReOrder)
/// </summary>
/// <param name="strPaperRWId">分类字段</param>
/// <param name="strSubViewpointTypeId">分类字段</param>
/// <returns></returns>
public static bool ReOrder(string strPaperRWId,string strSubViewpointTypeId)
{
try
{
string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conPaperSubViewpoint.PaperRWId, strPaperRWId);
strCondition += string.Format(" And {0} = '{1}' ", conPaperSubViewpoint.SubViewpointTypeId, strSubViewpointTypeId);
 strCondition += string.Format(" order by OrderNum ");
List<clsPaperSubViewpointEN> arrPaperSubViewpointObjList = new clsPaperSubViewpointDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsPaperSubViewpointEN objPaperSubViewpoint in arrPaperSubViewpointObjList)
{
objPaperSubViewpoint.OrderNum = intIndex;
UpdateBySql2(objPaperSubViewpoint);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("重序出错, {0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 调整所给关键字记录的序号。根据分类字段：PaperRWId,SubViewpointTypeId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_AdjustOrderNum)
/// </summary>
/// <param name="strDirect">方向：用"Up","Down"表示</param>
/// <param name="lngSubViewpointId">所给的关键字</param>
/// <param name="strPaperRWId">分类字段</param>
/// <param name="strSubViewpointTypeId">分类字段</param>
/// <returns>是否成功?</returns>
public static bool AdjustOrderNum(string strDirect, long lngSubViewpointId ,string strPaperRWId,string strSubViewpointTypeId)
{
try
{
//操作步骤：
//1、根据所给定的关键字[SubViewpointId],获取相应的序号[OrderNum]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//   3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字SubViewpointId
//5、把当前关键字SubViewpointId所对应记录的序号加(减)1
//6、把下(上)一个序号关键字SubViewpointId所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
long lngPrevSubViewpointId = 0;    //上一条序号的关键字SubViewpointId
long lngNextSubViewpointId = 0;    //下一条序号的关键字SubViewpointId
int intTabRecNum;       //当前表中字段的记录数
StringBuilder sbCondition = new StringBuilder();
//1、根据所给定的关键字[SubViewpointId],获取相应的序号[OrderNum]。

clsPaperSubViewpointEN objPaperSubViewpoint = clsPaperSubViewpointBL.GetObjBySubViewpointId(lngSubViewpointId);

intOrderNum = objPaperSubViewpoint.OrderNum ?? 0;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conPaperSubViewpoint.PaperRWId, strPaperRWId);
strCondition += string.Format(" And {0} = '{1}' ", conPaperSubViewpoint.SubViewpointTypeId, strSubViewpointTypeId);
intTabRecNum = clsPaperSubViewpointBL.GetRecCountByCond(clsPaperSubViewpointEN._CurrTabName, strCondition);    //获取当前表的记录数
switch (strDirect)
{
case "UP":
case "Up":
case "up":
//3、如果是末端序号,就退出；
//  3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	     即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
if (intOrderNum <= 1)
{
strMsg = string.Format("已经是第一条记录,不能再上移.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//		3.2 如果不是,即如果是向下移动,就判断当前序号是否“小于”当前表中的字段数,
//		    即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//		    如果是向上移动,就判断当前序号是否“大于”1,
//		    即不是最开始一个记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
sbCondition.AppendFormat(" {0} = {1} ", conPaperSubViewpoint.OrderNum, intOrderNum - 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conPaperSubViewpoint.PaperRWId, strPaperRWId);
sbCondition.AppendFormat(" And {0} = '{1}' ", conPaperSubViewpoint.SubViewpointTypeId, strSubViewpointTypeId);
//4、获取上一个序号字段的关键字SubViewpointId
lngPrevSubViewpointId = clsPaperSubViewpointBL.GetFirstID_S(sbCondition.ToString());
if (lngPrevSubViewpointId == 0)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字SubViewpointId所对应记录的序号减1
//6、把下(上)一个序号关键字SubViewpointId所对应的记录序号加1
clsPaperSubViewpointBL.SetFldValue(clsPaperSubViewpointEN._CurrTabName, conPaperSubViewpoint.OrderNum,
 	 	intOrderNum - 1,
  	 	string.Format("{0} = '{1}'", conPaperSubViewpoint.SubViewpointId, lngSubViewpointId));
clsPaperSubViewpointBL.SetFldValue(clsPaperSubViewpointEN._CurrTabName, conPaperSubViewpoint.OrderNum,
 	 	intPrevOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conPaperSubViewpoint.SubViewpointId, lngPrevSubViewpointId));
break;
case "DOWN":
case "Down":
case "down":
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
if (intOrderNum >= intTabRecNum)    //如果当前序号大于表记录数
{
strMsg = string.Format("已经是最后一条记录,不能再下移.(from {0})", clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
}

//4、获取下一个序号字段的关键字SubViewpointId
sbCondition.AppendFormat(" {0} = {1} ", conPaperSubViewpoint.OrderNum, intOrderNum + 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conPaperSubViewpoint.PaperRWId, strPaperRWId);
sbCondition.AppendFormat(" And {0} = '{1}' ", conPaperSubViewpoint.SubViewpointTypeId, strSubViewpointTypeId);

lngNextSubViewpointId = clsPaperSubViewpointBL.GetFirstID_S(sbCondition.ToString());
if (lngNextSubViewpointId == 0)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字SubViewpointId所对应记录的序号加1
//6、把下(上)一个序号关键字SubViewpointId所对应的记录序号减1
clsPaperSubViewpointBL.SetFldValue(clsPaperSubViewpointEN._CurrTabName, conPaperSubViewpoint.OrderNum,
 	 	intOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conPaperSubViewpoint.SubViewpointId, lngSubViewpointId));
clsPaperSubViewpointBL.SetFldValue(clsPaperSubViewpointEN._CurrTabName, conPaperSubViewpoint.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conPaperSubViewpoint.SubViewpointId, lngNextSubViewpointId));
break;
default:
strMsg = string.Format("方向参数出错!strDirect=[{0}]({1})",
 	 	strDirect,
 	 	clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
return true;
}
catch (Exception objException)
{
string strMsg = string.Format("调整记录次序出错!错误:[{0}]({1})",
 	 	objException.Message,
 	 	clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：PaperRWId,SubViewpointTypeId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoBottom)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoBottom(List<long> arrKeyId ,string strPaperRWId,string strSubViewpointTypeId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId);
string strCondition = string.Format("{0} in ({1})", conPaperSubViewpoint.SubViewpointId, strKeyList);
List<clsPaperSubViewpointEN> arrPaperSubViewpointLst = GetObjLst(strCondition);
foreach (clsPaperSubViewpointEN objPaperSubViewpoint in arrPaperSubViewpointLst)
{
objPaperSubViewpoint.OrderNum = objPaperSubViewpoint.OrderNum + 10000;
UpdateBySql2(objPaperSubViewpoint);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conPaperSubViewpoint.PaperRWId, strPaperRWId);
strCondition += string.Format(" And {0} = '{1}' ", conPaperSubViewpoint.SubViewpointTypeId, strSubViewpointTypeId);
 strCondition += string.Format(" order by OrderNum ");
List<clsPaperSubViewpointEN> arrPaperSubViewpointObjList = new clsPaperSubViewpointDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsPaperSubViewpointEN objPaperSubViewpoint in arrPaperSubViewpointObjList)
{
objPaperSubViewpoint.OrderNum = intIndex;
UpdateBySql2(objPaperSubViewpoint);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错, {0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：PaperRWId,SubViewpointTypeId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoTop)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <param name="strPaperRWId">分类字段</param>
/// <param name="strSubViewpointTypeId">分类字段</param>
/// <returns></returns>
public static bool GoTop(List<long> arrKeyId ,string strPaperRWId,string strSubViewpointTypeId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId);
string strCondition = string.Format("{0} in ({1})", conPaperSubViewpoint.SubViewpointId, strKeyList);
List<clsPaperSubViewpointEN> arrPaperSubViewpointLst = GetObjLst(strCondition);
foreach (clsPaperSubViewpointEN objPaperSubViewpoint in arrPaperSubViewpointLst)
{
objPaperSubViewpoint.OrderNum = objPaperSubViewpoint.OrderNum - 10000;
UpdateBySql2(objPaperSubViewpoint);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conPaperSubViewpoint.PaperRWId, strPaperRWId);
strCondition += string.Format(" And {0} = '{1}' ", conPaperSubViewpoint.SubViewpointTypeId, strSubViewpointTypeId);
 strCondition += string.Format(" order by OrderNum ");
List<clsPaperSubViewpointEN> arrPaperSubViewpointObjList = new clsPaperSubViewpointDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsPaperSubViewpointEN objPaperSubViewpoint in arrPaperSubViewpointObjList)
{
objPaperSubViewpoint.OrderNum = intIndex;
UpdateBySql2(objPaperSubViewpoint);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错,{0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}


 #endregion 排序相关函数
}
 /// <summary>
 /// 子观点表(PaperSubViewpoint)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4PaperSubViewpoint : clsCommFun4BLV2
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
clsPaperSubViewpointBL.ReFreshThisCache(strIdCurrEduCls);
}
}

}