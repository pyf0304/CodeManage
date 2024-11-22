
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsKnowledgeLearnDetailBL
 表名:KnowledgeLearnDetail(01120153)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:03:48
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
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
public static class  clsKnowledgeLearnDetailBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsKnowledgeLearnDetailEN GetObj(this K_mId_KnowledgeLearnDetail myKey)
{
clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN = clsKnowledgeLearnDetailBL.KnowledgeLearnDetailDA.GetObjBymId(myKey.Value);
return objKnowledgeLearnDetailEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objKnowledgeLearnDetailEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objKnowledgeLearnDetailEN) == false)
{
var strMsg = string.Format("记录已经存在!用户ID = [{0}],案例流水号 = [{1}],知识点Id = [{2}]的数据已经存在!(in clsKnowledgeLearnDetailBL.AddNewRecord)", objKnowledgeLearnDetailEN.UserId,objKnowledgeLearnDetailEN.IdCase,objKnowledgeLearnDetailEN.CourseKnowledgeId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsKnowledgeLearnDetailBL.KnowledgeLearnDetailDA.AddNewRecordBySQL2(objKnowledgeLearnDetailEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsKnowledgeLearnDetailBL.ReFreshCache(objKnowledgeLearnDetailEN.CourseId);

if (clsKnowledgeLearnDetailBL.relatedActions != null)
{
clsKnowledgeLearnDetailBL.relatedActions.UpdRelaTabDate(objKnowledgeLearnDetailEN.mId, objKnowledgeLearnDetailEN.UpdUser);
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
public static bool AddRecordEx(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN, bool bolIsNeedCheckUniqueness = true)
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
objKnowledgeLearnDetailEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objKnowledgeLearnDetailEN.CheckUniqueness() == false)
{
strMsg = string.Format("(用户ID(UserId)=[{0}],案例流水号(IdCase)=[{1}],知识点Id(CourseKnowledgeId)=[{2}])已经存在,不能重复!", objKnowledgeLearnDetailEN.UserId, objKnowledgeLearnDetailEN.IdCase, objKnowledgeLearnDetailEN.CourseKnowledgeId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objKnowledgeLearnDetailEN.AddNewRecord();
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
 /// <param name = "objKnowledgeLearnDetailEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objKnowledgeLearnDetailEN) == false)
{
var strMsg = string.Format("记录已经存在!用户ID = [{0}],案例流水号 = [{1}],知识点Id = [{2}]的数据已经存在!(in clsKnowledgeLearnDetailBL.AddNewRecordWithReturnKey)", objKnowledgeLearnDetailEN.UserId,objKnowledgeLearnDetailEN.IdCase,objKnowledgeLearnDetailEN.CourseKnowledgeId);
throw new Exception(strMsg);
}
try
{
string strKey = clsKnowledgeLearnDetailBL.KnowledgeLearnDetailDA.AddNewRecordBySQL2WithReturnKey(objKnowledgeLearnDetailEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsKnowledgeLearnDetailBL.ReFreshCache(objKnowledgeLearnDetailEN.CourseId);

if (clsKnowledgeLearnDetailBL.relatedActions != null)
{
clsKnowledgeLearnDetailBL.relatedActions.UpdRelaTabDate(objKnowledgeLearnDetailEN.mId, objKnowledgeLearnDetailEN.UpdUser);
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
 /// <param name = "objKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsKnowledgeLearnDetailEN SetmId(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN, long lngmId, string strComparisonOp="")
	{
objKnowledgeLearnDetailEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(conKnowledgeLearnDetail.mId) == false)
{
objKnowledgeLearnDetailEN.dicFldComparisonOp.Add(conKnowledgeLearnDetail.mId, strComparisonOp);
}
else
{
objKnowledgeLearnDetailEN.dicFldComparisonOp[conKnowledgeLearnDetail.mId] = strComparisonOp;
}
}
return objKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsKnowledgeLearnDetailEN SetUserId(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conKnowledgeLearnDetail.UserId);
}
objKnowledgeLearnDetailEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(conKnowledgeLearnDetail.UserId) == false)
{
objKnowledgeLearnDetailEN.dicFldComparisonOp.Add(conKnowledgeLearnDetail.UserId, strComparisonOp);
}
else
{
objKnowledgeLearnDetailEN.dicFldComparisonOp[conKnowledgeLearnDetail.UserId] = strComparisonOp;
}
}
return objKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsKnowledgeLearnDetailEN SetLearnDate(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN, string strLearnDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strLearnDate, conKnowledgeLearnDetail.LearnDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLearnDate, 20, conKnowledgeLearnDetail.LearnDate);
}
objKnowledgeLearnDetailEN.LearnDate = strLearnDate; //学习日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(conKnowledgeLearnDetail.LearnDate) == false)
{
objKnowledgeLearnDetailEN.dicFldComparisonOp.Add(conKnowledgeLearnDetail.LearnDate, strComparisonOp);
}
else
{
objKnowledgeLearnDetailEN.dicFldComparisonOp[conKnowledgeLearnDetail.LearnDate] = strComparisonOp;
}
}
return objKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsKnowledgeLearnDetailEN SetLearnModeId(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN, string strLearnModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strLearnModeId, conKnowledgeLearnDetail.LearnModeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLearnModeId, 4, conKnowledgeLearnDetail.LearnModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strLearnModeId, 4, conKnowledgeLearnDetail.LearnModeId);
}
objKnowledgeLearnDetailEN.LearnModeId = strLearnModeId; //学习模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(conKnowledgeLearnDetail.LearnModeId) == false)
{
objKnowledgeLearnDetailEN.dicFldComparisonOp.Add(conKnowledgeLearnDetail.LearnModeId, strComparisonOp);
}
else
{
objKnowledgeLearnDetailEN.dicFldComparisonOp[conKnowledgeLearnDetail.LearnModeId] = strComparisonOp;
}
}
return objKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsKnowledgeLearnDetailEN SetCourseKnowledgeId(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN, string strCourseKnowledgeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseKnowledgeId, 8, conKnowledgeLearnDetail.CourseKnowledgeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseKnowledgeId, 8, conKnowledgeLearnDetail.CourseKnowledgeId);
}
objKnowledgeLearnDetailEN.CourseKnowledgeId = strCourseKnowledgeId; //知识点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(conKnowledgeLearnDetail.CourseKnowledgeId) == false)
{
objKnowledgeLearnDetailEN.dicFldComparisonOp.Add(conKnowledgeLearnDetail.CourseKnowledgeId, strComparisonOp);
}
else
{
objKnowledgeLearnDetailEN.dicFldComparisonOp[conKnowledgeLearnDetail.CourseKnowledgeId] = strComparisonOp;
}
}
return objKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsKnowledgeLearnDetailEN SetIdCase(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN, string strIdCase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCase, 8, conKnowledgeLearnDetail.IdCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCase, 8, conKnowledgeLearnDetail.IdCase);
}
objKnowledgeLearnDetailEN.IdCase = strIdCase; //案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(conKnowledgeLearnDetail.IdCase) == false)
{
objKnowledgeLearnDetailEN.dicFldComparisonOp.Add(conKnowledgeLearnDetail.IdCase, strComparisonOp);
}
else
{
objKnowledgeLearnDetailEN.dicFldComparisonOp[conKnowledgeLearnDetail.IdCase] = strComparisonOp;
}
}
return objKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsKnowledgeLearnDetailEN SetIdCaseType(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN, string strIdCaseType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCaseType, 4, conKnowledgeLearnDetail.IdCaseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCaseType, 4, conKnowledgeLearnDetail.IdCaseType);
}
objKnowledgeLearnDetailEN.IdCaseType = strIdCaseType; //案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(conKnowledgeLearnDetail.IdCaseType) == false)
{
objKnowledgeLearnDetailEN.dicFldComparisonOp.Add(conKnowledgeLearnDetail.IdCaseType, strComparisonOp);
}
else
{
objKnowledgeLearnDetailEN.dicFldComparisonOp[conKnowledgeLearnDetail.IdCaseType] = strComparisonOp;
}
}
return objKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsKnowledgeLearnDetailEN SetIsRight(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN, bool bolIsRight, string strComparisonOp="")
	{
objKnowledgeLearnDetailEN.IsRight = bolIsRight; //是否正确
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(conKnowledgeLearnDetail.IsRight) == false)
{
objKnowledgeLearnDetailEN.dicFldComparisonOp.Add(conKnowledgeLearnDetail.IsRight, strComparisonOp);
}
else
{
objKnowledgeLearnDetailEN.dicFldComparisonOp[conKnowledgeLearnDetail.IsRight] = strComparisonOp;
}
}
return objKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsKnowledgeLearnDetailEN SetIsMaster(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN, bool bolIsMaster, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsMaster, conKnowledgeLearnDetail.IsMaster);
objKnowledgeLearnDetailEN.IsMaster = bolIsMaster; //是否掌握
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(conKnowledgeLearnDetail.IsMaster) == false)
{
objKnowledgeLearnDetailEN.dicFldComparisonOp.Add(conKnowledgeLearnDetail.IsMaster, strComparisonOp);
}
else
{
objKnowledgeLearnDetailEN.dicFldComparisonOp[conKnowledgeLearnDetail.IsMaster] = strComparisonOp;
}
}
return objKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsKnowledgeLearnDetailEN SetMasterDegree(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN, double dblMasterDegree, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(dblMasterDegree, conKnowledgeLearnDetail.MasterDegree);
objKnowledgeLearnDetailEN.MasterDegree = dblMasterDegree; //掌握程度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(conKnowledgeLearnDetail.MasterDegree) == false)
{
objKnowledgeLearnDetailEN.dicFldComparisonOp.Add(conKnowledgeLearnDetail.MasterDegree, strComparisonOp);
}
else
{
objKnowledgeLearnDetailEN.dicFldComparisonOp[conKnowledgeLearnDetail.MasterDegree] = strComparisonOp;
}
}
return objKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsKnowledgeLearnDetailEN SetMarkerId(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN, string strMarkerId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMarkerId, 20, conKnowledgeLearnDetail.MarkerId);
}
objKnowledgeLearnDetailEN.MarkerId = strMarkerId; //打分者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(conKnowledgeLearnDetail.MarkerId) == false)
{
objKnowledgeLearnDetailEN.dicFldComparisonOp.Add(conKnowledgeLearnDetail.MarkerId, strComparisonOp);
}
else
{
objKnowledgeLearnDetailEN.dicFldComparisonOp[conKnowledgeLearnDetail.MarkerId] = strComparisonOp;
}
}
return objKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsKnowledgeLearnDetailEN SetMarkTime(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN, string strMarkTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMarkTime, 14, conKnowledgeLearnDetail.MarkTime);
}
objKnowledgeLearnDetailEN.MarkTime = strMarkTime; //批改时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(conKnowledgeLearnDetail.MarkTime) == false)
{
objKnowledgeLearnDetailEN.dicFldComparisonOp.Add(conKnowledgeLearnDetail.MarkTime, strComparisonOp);
}
else
{
objKnowledgeLearnDetailEN.dicFldComparisonOp[conKnowledgeLearnDetail.MarkTime] = strComparisonOp;
}
}
return objKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsKnowledgeLearnDetailEN SetIsAnalysis(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN, bool bolIsAnalysis, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsAnalysis, conKnowledgeLearnDetail.IsAnalysis);
objKnowledgeLearnDetailEN.IsAnalysis = bolIsAnalysis; //是否分析
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(conKnowledgeLearnDetail.IsAnalysis) == false)
{
objKnowledgeLearnDetailEN.dicFldComparisonOp.Add(conKnowledgeLearnDetail.IsAnalysis, strComparisonOp);
}
else
{
objKnowledgeLearnDetailEN.dicFldComparisonOp[conKnowledgeLearnDetail.IsAnalysis] = strComparisonOp;
}
}
return objKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsKnowledgeLearnDetailEN SetCourseId(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, conKnowledgeLearnDetail.CourseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, conKnowledgeLearnDetail.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, conKnowledgeLearnDetail.CourseId);
}
objKnowledgeLearnDetailEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(conKnowledgeLearnDetail.CourseId) == false)
{
objKnowledgeLearnDetailEN.dicFldComparisonOp.Add(conKnowledgeLearnDetail.CourseId, strComparisonOp);
}
else
{
objKnowledgeLearnDetailEN.dicFldComparisonOp[conKnowledgeLearnDetail.CourseId] = strComparisonOp;
}
}
return objKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsKnowledgeLearnDetailEN SetUpdDate(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conKnowledgeLearnDetail.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conKnowledgeLearnDetail.UpdDate);
}
objKnowledgeLearnDetailEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(conKnowledgeLearnDetail.UpdDate) == false)
{
objKnowledgeLearnDetailEN.dicFldComparisonOp.Add(conKnowledgeLearnDetail.UpdDate, strComparisonOp);
}
else
{
objKnowledgeLearnDetailEN.dicFldComparisonOp[conKnowledgeLearnDetail.UpdDate] = strComparisonOp;
}
}
return objKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsKnowledgeLearnDetailEN SetUpdUser(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conKnowledgeLearnDetail.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conKnowledgeLearnDetail.UpdUser);
}
objKnowledgeLearnDetailEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(conKnowledgeLearnDetail.UpdUser) == false)
{
objKnowledgeLearnDetailEN.dicFldComparisonOp.Add(conKnowledgeLearnDetail.UpdUser, strComparisonOp);
}
else
{
objKnowledgeLearnDetailEN.dicFldComparisonOp[conKnowledgeLearnDetail.UpdUser] = strComparisonOp;
}
}
return objKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsKnowledgeLearnDetailEN SetMemo(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conKnowledgeLearnDetail.Memo);
}
objKnowledgeLearnDetailEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(conKnowledgeLearnDetail.Memo) == false)
{
objKnowledgeLearnDetailEN.dicFldComparisonOp.Add(conKnowledgeLearnDetail.Memo, strComparisonOp);
}
else
{
objKnowledgeLearnDetailEN.dicFldComparisonOp[conKnowledgeLearnDetail.Memo] = strComparisonOp;
}
}
return objKnowledgeLearnDetailEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objKnowledgeLearnDetailEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objKnowledgeLearnDetailEN.CheckPropertyNew();
clsKnowledgeLearnDetailEN objKnowledgeLearnDetailCond = new clsKnowledgeLearnDetailEN();
string strCondition = objKnowledgeLearnDetailCond
.SetmId(objKnowledgeLearnDetailEN.mId, "<>")
.SetUserId(objKnowledgeLearnDetailEN.UserId, "=")
.SetIdCase(objKnowledgeLearnDetailEN.IdCase, "=")
.SetCourseKnowledgeId(objKnowledgeLearnDetailEN.CourseKnowledgeId, "=")
.GetCombineCondition();
objKnowledgeLearnDetailEN._IsCheckProperty = true;
bool bolIsExist = clsKnowledgeLearnDetailBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(UserId_CourseKnowledgeId_Id_Case)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objKnowledgeLearnDetailEN.Update();
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
 /// <param name = "objKnowledgeLearnDetail">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetail)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsKnowledgeLearnDetailEN objKnowledgeLearnDetailCond = new clsKnowledgeLearnDetailEN();
string strCondition = objKnowledgeLearnDetailCond
.SetUserId(objKnowledgeLearnDetail.UserId, "=")
.SetIdCase(objKnowledgeLearnDetail.IdCase, "=")
.SetCourseKnowledgeId(objKnowledgeLearnDetail.CourseKnowledgeId, "=")
.GetCombineCondition();
objKnowledgeLearnDetail._IsCheckProperty = true;
bool bolIsExist = clsKnowledgeLearnDetailBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objKnowledgeLearnDetail.mId = clsKnowledgeLearnDetailBL.GetFirstID_S(strCondition);
objKnowledgeLearnDetail.UpdateWithCondition(strCondition);
}
else
{
objKnowledgeLearnDetail.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objKnowledgeLearnDetailEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN)
{
 if (objKnowledgeLearnDetailEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsKnowledgeLearnDetailBL.KnowledgeLearnDetailDA.UpdateBySql2(objKnowledgeLearnDetailEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsKnowledgeLearnDetailBL.ReFreshCache(objKnowledgeLearnDetailEN.CourseId);

if (clsKnowledgeLearnDetailBL.relatedActions != null)
{
clsKnowledgeLearnDetailBL.relatedActions.UpdRelaTabDate(objKnowledgeLearnDetailEN.mId, objKnowledgeLearnDetailEN.UpdUser);
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
 /// <param name = "objKnowledgeLearnDetailEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objKnowledgeLearnDetailEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsKnowledgeLearnDetailBL.KnowledgeLearnDetailDA.UpdateBySql2(objKnowledgeLearnDetailEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsKnowledgeLearnDetailBL.ReFreshCache(objKnowledgeLearnDetailEN.CourseId);

if (clsKnowledgeLearnDetailBL.relatedActions != null)
{
clsKnowledgeLearnDetailBL.relatedActions.UpdRelaTabDate(objKnowledgeLearnDetailEN.mId, objKnowledgeLearnDetailEN.UpdUser);
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
 /// <param name = "objKnowledgeLearnDetailEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN, string strWhereCond)
{
try
{
bool bolResult = clsKnowledgeLearnDetailBL.KnowledgeLearnDetailDA.UpdateBySqlWithCondition(objKnowledgeLearnDetailEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsKnowledgeLearnDetailBL.ReFreshCache(objKnowledgeLearnDetailEN.CourseId);

if (clsKnowledgeLearnDetailBL.relatedActions != null)
{
clsKnowledgeLearnDetailBL.relatedActions.UpdRelaTabDate(objKnowledgeLearnDetailEN.mId, objKnowledgeLearnDetailEN.UpdUser);
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
 /// <param name = "objKnowledgeLearnDetailEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsKnowledgeLearnDetailBL.KnowledgeLearnDetailDA.UpdateBySqlWithConditionTransaction(objKnowledgeLearnDetailEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsKnowledgeLearnDetailBL.ReFreshCache(objKnowledgeLearnDetailEN.CourseId);

if (clsKnowledgeLearnDetailBL.relatedActions != null)
{
clsKnowledgeLearnDetailBL.relatedActions.UpdRelaTabDate(objKnowledgeLearnDetailEN.mId, objKnowledgeLearnDetailEN.UpdUser);
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
public static int Delete(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN)
{
try
{
int intRecNum = clsKnowledgeLearnDetailBL.KnowledgeLearnDetailDA.DelRecord(objKnowledgeLearnDetailEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsKnowledgeLearnDetailBL.ReFreshCache(objKnowledgeLearnDetailEN.CourseId);

if (clsKnowledgeLearnDetailBL.relatedActions != null)
{
clsKnowledgeLearnDetailBL.relatedActions.UpdRelaTabDate(objKnowledgeLearnDetailEN.mId, objKnowledgeLearnDetailEN.UpdUser);
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
 /// <param name = "objKnowledgeLearnDetailENS">源对象</param>
 /// <param name = "objKnowledgeLearnDetailENT">目标对象</param>
 public static void CopyTo(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailENS, clsKnowledgeLearnDetailEN objKnowledgeLearnDetailENT)
{
try
{
objKnowledgeLearnDetailENT.mId = objKnowledgeLearnDetailENS.mId; //mId
objKnowledgeLearnDetailENT.UserId = objKnowledgeLearnDetailENS.UserId; //用户ID
objKnowledgeLearnDetailENT.LearnDate = objKnowledgeLearnDetailENS.LearnDate; //学习日期
objKnowledgeLearnDetailENT.LearnModeId = objKnowledgeLearnDetailENS.LearnModeId; //学习模式Id
objKnowledgeLearnDetailENT.CourseKnowledgeId = objKnowledgeLearnDetailENS.CourseKnowledgeId; //知识点Id
objKnowledgeLearnDetailENT.IdCase = objKnowledgeLearnDetailENS.IdCase; //案例流水号
objKnowledgeLearnDetailENT.IdCaseType = objKnowledgeLearnDetailENS.IdCaseType; //案例类型流水号
objKnowledgeLearnDetailENT.IsRight = objKnowledgeLearnDetailENS.IsRight; //是否正确
objKnowledgeLearnDetailENT.IsMaster = objKnowledgeLearnDetailENS.IsMaster; //是否掌握
objKnowledgeLearnDetailENT.MasterDegree = objKnowledgeLearnDetailENS.MasterDegree; //掌握程度
objKnowledgeLearnDetailENT.MarkerId = objKnowledgeLearnDetailENS.MarkerId; //打分者
objKnowledgeLearnDetailENT.MarkTime = objKnowledgeLearnDetailENS.MarkTime; //批改时间
objKnowledgeLearnDetailENT.IsAnalysis = objKnowledgeLearnDetailENS.IsAnalysis; //是否分析
objKnowledgeLearnDetailENT.CourseId = objKnowledgeLearnDetailENS.CourseId; //课程Id
objKnowledgeLearnDetailENT.UpdDate = objKnowledgeLearnDetailENS.UpdDate; //修改日期
objKnowledgeLearnDetailENT.UpdUser = objKnowledgeLearnDetailENS.UpdUser; //修改人
objKnowledgeLearnDetailENT.Memo = objKnowledgeLearnDetailENS.Memo; //备注
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
 /// <param name = "objKnowledgeLearnDetailENS">源对象</param>
 /// <returns>目标对象=>clsKnowledgeLearnDetailEN:objKnowledgeLearnDetailENT</returns>
 public static clsKnowledgeLearnDetailEN CopyTo(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailENS)
{
try
{
 clsKnowledgeLearnDetailEN objKnowledgeLearnDetailENT = new clsKnowledgeLearnDetailEN()
{
mId = objKnowledgeLearnDetailENS.mId, //mId
UserId = objKnowledgeLearnDetailENS.UserId, //用户ID
LearnDate = objKnowledgeLearnDetailENS.LearnDate, //学习日期
LearnModeId = objKnowledgeLearnDetailENS.LearnModeId, //学习模式Id
CourseKnowledgeId = objKnowledgeLearnDetailENS.CourseKnowledgeId, //知识点Id
IdCase = objKnowledgeLearnDetailENS.IdCase, //案例流水号
IdCaseType = objKnowledgeLearnDetailENS.IdCaseType, //案例类型流水号
IsRight = objKnowledgeLearnDetailENS.IsRight, //是否正确
IsMaster = objKnowledgeLearnDetailENS.IsMaster, //是否掌握
MasterDegree = objKnowledgeLearnDetailENS.MasterDegree, //掌握程度
MarkerId = objKnowledgeLearnDetailENS.MarkerId, //打分者
MarkTime = objKnowledgeLearnDetailENS.MarkTime, //批改时间
IsAnalysis = objKnowledgeLearnDetailENS.IsAnalysis, //是否分析
CourseId = objKnowledgeLearnDetailENS.CourseId, //课程Id
UpdDate = objKnowledgeLearnDetailENS.UpdDate, //修改日期
UpdUser = objKnowledgeLearnDetailENS.UpdUser, //修改人
Memo = objKnowledgeLearnDetailENS.Memo, //备注
};
 return objKnowledgeLearnDetailENT;
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
public static void CheckPropertyNew(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN)
{
 clsKnowledgeLearnDetailBL.KnowledgeLearnDetailDA.CheckPropertyNew(objKnowledgeLearnDetailEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN)
{
 clsKnowledgeLearnDetailBL.KnowledgeLearnDetailDA.CheckProperty4Condition(objKnowledgeLearnDetailEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objKnowledgeLearnDetailCond.IsUpdated(conKnowledgeLearnDetail.mId) == true)
{
string strComparisonOpmId = objKnowledgeLearnDetailCond.dicFldComparisonOp[conKnowledgeLearnDetail.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conKnowledgeLearnDetail.mId, objKnowledgeLearnDetailCond.mId, strComparisonOpmId);
}
if (objKnowledgeLearnDetailCond.IsUpdated(conKnowledgeLearnDetail.UserId) == true)
{
string strComparisonOpUserId = objKnowledgeLearnDetailCond.dicFldComparisonOp[conKnowledgeLearnDetail.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKnowledgeLearnDetail.UserId, objKnowledgeLearnDetailCond.UserId, strComparisonOpUserId);
}
if (objKnowledgeLearnDetailCond.IsUpdated(conKnowledgeLearnDetail.LearnDate) == true)
{
string strComparisonOpLearnDate = objKnowledgeLearnDetailCond.dicFldComparisonOp[conKnowledgeLearnDetail.LearnDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKnowledgeLearnDetail.LearnDate, objKnowledgeLearnDetailCond.LearnDate, strComparisonOpLearnDate);
}
if (objKnowledgeLearnDetailCond.IsUpdated(conKnowledgeLearnDetail.LearnModeId) == true)
{
string strComparisonOpLearnModeId = objKnowledgeLearnDetailCond.dicFldComparisonOp[conKnowledgeLearnDetail.LearnModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKnowledgeLearnDetail.LearnModeId, objKnowledgeLearnDetailCond.LearnModeId, strComparisonOpLearnModeId);
}
if (objKnowledgeLearnDetailCond.IsUpdated(conKnowledgeLearnDetail.CourseKnowledgeId) == true)
{
string strComparisonOpCourseKnowledgeId = objKnowledgeLearnDetailCond.dicFldComparisonOp[conKnowledgeLearnDetail.CourseKnowledgeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKnowledgeLearnDetail.CourseKnowledgeId, objKnowledgeLearnDetailCond.CourseKnowledgeId, strComparisonOpCourseKnowledgeId);
}
if (objKnowledgeLearnDetailCond.IsUpdated(conKnowledgeLearnDetail.IdCase) == true)
{
string strComparisonOpIdCase = objKnowledgeLearnDetailCond.dicFldComparisonOp[conKnowledgeLearnDetail.IdCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKnowledgeLearnDetail.IdCase, objKnowledgeLearnDetailCond.IdCase, strComparisonOpIdCase);
}
if (objKnowledgeLearnDetailCond.IsUpdated(conKnowledgeLearnDetail.IdCaseType) == true)
{
string strComparisonOpIdCaseType = objKnowledgeLearnDetailCond.dicFldComparisonOp[conKnowledgeLearnDetail.IdCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKnowledgeLearnDetail.IdCaseType, objKnowledgeLearnDetailCond.IdCaseType, strComparisonOpIdCaseType);
}
if (objKnowledgeLearnDetailCond.IsUpdated(conKnowledgeLearnDetail.IsRight) == true)
{
if (objKnowledgeLearnDetailCond.IsRight == true)
{
strWhereCond += string.Format(" And {0} = '1'", conKnowledgeLearnDetail.IsRight);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conKnowledgeLearnDetail.IsRight);
}
}
if (objKnowledgeLearnDetailCond.IsUpdated(conKnowledgeLearnDetail.IsMaster) == true)
{
if (objKnowledgeLearnDetailCond.IsMaster == true)
{
strWhereCond += string.Format(" And {0} = '1'", conKnowledgeLearnDetail.IsMaster);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conKnowledgeLearnDetail.IsMaster);
}
}
//数据类型double(numeric)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objKnowledgeLearnDetailCond.IsUpdated(conKnowledgeLearnDetail.MarkerId) == true)
{
string strComparisonOpMarkerId = objKnowledgeLearnDetailCond.dicFldComparisonOp[conKnowledgeLearnDetail.MarkerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKnowledgeLearnDetail.MarkerId, objKnowledgeLearnDetailCond.MarkerId, strComparisonOpMarkerId);
}
if (objKnowledgeLearnDetailCond.IsUpdated(conKnowledgeLearnDetail.MarkTime) == true)
{
string strComparisonOpMarkTime = objKnowledgeLearnDetailCond.dicFldComparisonOp[conKnowledgeLearnDetail.MarkTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKnowledgeLearnDetail.MarkTime, objKnowledgeLearnDetailCond.MarkTime, strComparisonOpMarkTime);
}
if (objKnowledgeLearnDetailCond.IsUpdated(conKnowledgeLearnDetail.IsAnalysis) == true)
{
if (objKnowledgeLearnDetailCond.IsAnalysis == true)
{
strWhereCond += string.Format(" And {0} = '1'", conKnowledgeLearnDetail.IsAnalysis);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conKnowledgeLearnDetail.IsAnalysis);
}
}
if (objKnowledgeLearnDetailCond.IsUpdated(conKnowledgeLearnDetail.CourseId) == true)
{
string strComparisonOpCourseId = objKnowledgeLearnDetailCond.dicFldComparisonOp[conKnowledgeLearnDetail.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKnowledgeLearnDetail.CourseId, objKnowledgeLearnDetailCond.CourseId, strComparisonOpCourseId);
}
if (objKnowledgeLearnDetailCond.IsUpdated(conKnowledgeLearnDetail.UpdDate) == true)
{
string strComparisonOpUpdDate = objKnowledgeLearnDetailCond.dicFldComparisonOp[conKnowledgeLearnDetail.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKnowledgeLearnDetail.UpdDate, objKnowledgeLearnDetailCond.UpdDate, strComparisonOpUpdDate);
}
if (objKnowledgeLearnDetailCond.IsUpdated(conKnowledgeLearnDetail.UpdUser) == true)
{
string strComparisonOpUpdUser = objKnowledgeLearnDetailCond.dicFldComparisonOp[conKnowledgeLearnDetail.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKnowledgeLearnDetail.UpdUser, objKnowledgeLearnDetailCond.UpdUser, strComparisonOpUpdUser);
}
if (objKnowledgeLearnDetailCond.IsUpdated(conKnowledgeLearnDetail.Memo) == true)
{
string strComparisonOpMemo = objKnowledgeLearnDetailCond.dicFldComparisonOp[conKnowledgeLearnDetail.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKnowledgeLearnDetail.Memo, objKnowledgeLearnDetailCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--KnowledgeLearnDetail(知识点学习情况), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:UserId_CourseKnowledgeId_Id_Case
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objKnowledgeLearnDetailEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objKnowledgeLearnDetailEN == null) return true;
if (objKnowledgeLearnDetailEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objKnowledgeLearnDetailEN.UserId == null)
{
 sbCondition.AppendFormat(" and UserId is null", objKnowledgeLearnDetailEN.UserId);
}
else
{
 sbCondition.AppendFormat(" and UserId = '{0}'", objKnowledgeLearnDetailEN.UserId);
}
 if (objKnowledgeLearnDetailEN.IdCase == null)
{
 sbCondition.AppendFormat(" and IdCase is null", objKnowledgeLearnDetailEN.IdCase);
}
else
{
 sbCondition.AppendFormat(" and IdCase = '{0}'", objKnowledgeLearnDetailEN.IdCase);
}
 if (objKnowledgeLearnDetailEN.CourseKnowledgeId == null)
{
 sbCondition.AppendFormat(" and CourseKnowledgeId is null", objKnowledgeLearnDetailEN.CourseKnowledgeId);
}
else
{
 sbCondition.AppendFormat(" and CourseKnowledgeId = '{0}'", objKnowledgeLearnDetailEN.CourseKnowledgeId);
}
if (clsKnowledgeLearnDetailBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objKnowledgeLearnDetailEN.mId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objKnowledgeLearnDetailEN.UserId);
 sbCondition.AppendFormat(" and IdCase = '{0}'", objKnowledgeLearnDetailEN.IdCase);
 sbCondition.AppendFormat(" and CourseKnowledgeId = '{0}'", objKnowledgeLearnDetailEN.CourseKnowledgeId);
if (clsKnowledgeLearnDetailBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--KnowledgeLearnDetail(知识点学习情况), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:UserId_CourseKnowledgeId_Id_Case
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objKnowledgeLearnDetailEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objKnowledgeLearnDetailEN == null) return "";
if (objKnowledgeLearnDetailEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objKnowledgeLearnDetailEN.UserId == null)
{
 sbCondition.AppendFormat(" and UserId is null", objKnowledgeLearnDetailEN.UserId);
}
else
{
 sbCondition.AppendFormat(" and UserId = '{0}'", objKnowledgeLearnDetailEN.UserId);
}
 if (objKnowledgeLearnDetailEN.IdCase == null)
{
 sbCondition.AppendFormat(" and IdCase is null", objKnowledgeLearnDetailEN.IdCase);
}
else
{
 sbCondition.AppendFormat(" and IdCase = '{0}'", objKnowledgeLearnDetailEN.IdCase);
}
 if (objKnowledgeLearnDetailEN.CourseKnowledgeId == null)
{
 sbCondition.AppendFormat(" and CourseKnowledgeId is null", objKnowledgeLearnDetailEN.CourseKnowledgeId);
}
else
{
 sbCondition.AppendFormat(" and CourseKnowledgeId = '{0}'", objKnowledgeLearnDetailEN.CourseKnowledgeId);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objKnowledgeLearnDetailEN.mId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objKnowledgeLearnDetailEN.UserId);
 sbCondition.AppendFormat(" and IdCase = '{0}'", objKnowledgeLearnDetailEN.IdCase);
 sbCondition.AppendFormat(" and CourseKnowledgeId = '{0}'", objKnowledgeLearnDetailEN.CourseKnowledgeId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_KnowledgeLearnDetail
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 知识点学习情况(KnowledgeLearnDetail)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsKnowledgeLearnDetailBL
{
public static RelatedActions_KnowledgeLearnDetail relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsKnowledgeLearnDetailDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsKnowledgeLearnDetailDA KnowledgeLearnDetailDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsKnowledgeLearnDetailDA();
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
 public clsKnowledgeLearnDetailBL()
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
if (string.IsNullOrEmpty(clsKnowledgeLearnDetailEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsKnowledgeLearnDetailEN._ConnectString);
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
public static DataTable GetDataTable_KnowledgeLearnDetail(string strWhereCond)
{
DataTable objDT;
try
{
objDT = KnowledgeLearnDetailDA.GetDataTable_KnowledgeLearnDetail(strWhereCond);
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
objDT = KnowledgeLearnDetailDA.GetDataTable(strWhereCond);
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
objDT = KnowledgeLearnDetailDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = KnowledgeLearnDetailDA.GetDataTable(strWhereCond, strTabName);
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
objDT = KnowledgeLearnDetailDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = KnowledgeLearnDetailDA.GetDataTable_Top(objTopPara);
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
objDT = KnowledgeLearnDetailDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = KnowledgeLearnDetailDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = KnowledgeLearnDetailDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsKnowledgeLearnDetailEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsKnowledgeLearnDetailEN> arrObjLst = new List<clsKnowledgeLearnDetailEN>(); 
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
	clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN = new clsKnowledgeLearnDetailEN();
try
{
objKnowledgeLearnDetailEN.mId = Int32.Parse(objRow[conKnowledgeLearnDetail.mId].ToString().Trim()); //mId
objKnowledgeLearnDetailEN.UserId = objRow[conKnowledgeLearnDetail.UserId] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.UserId].ToString().Trim(); //用户ID
objKnowledgeLearnDetailEN.LearnDate = objRow[conKnowledgeLearnDetail.LearnDate].ToString().Trim(); //学习日期
objKnowledgeLearnDetailEN.LearnModeId = objRow[conKnowledgeLearnDetail.LearnModeId].ToString().Trim(); //学习模式Id
objKnowledgeLearnDetailEN.CourseKnowledgeId = objRow[conKnowledgeLearnDetail.CourseKnowledgeId] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.CourseKnowledgeId].ToString().Trim(); //知识点Id
objKnowledgeLearnDetailEN.IdCase = objRow[conKnowledgeLearnDetail.IdCase] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.IdCase].ToString().Trim(); //案例流水号
objKnowledgeLearnDetailEN.IdCaseType = objRow[conKnowledgeLearnDetail.IdCaseType] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.IdCaseType].ToString().Trim(); //案例类型流水号
objKnowledgeLearnDetailEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conKnowledgeLearnDetail.IsRight].ToString().Trim()); //是否正确
objKnowledgeLearnDetailEN.IsMaster = clsEntityBase2.TransNullToBool_S(objRow[conKnowledgeLearnDetail.IsMaster].ToString().Trim()); //是否掌握
objKnowledgeLearnDetailEN.MasterDegree = Double.Parse(objRow[conKnowledgeLearnDetail.MasterDegree].ToString().Trim()); //掌握程度
objKnowledgeLearnDetailEN.MarkerId = objRow[conKnowledgeLearnDetail.MarkerId] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.MarkerId].ToString().Trim(); //打分者
objKnowledgeLearnDetailEN.MarkTime = objRow[conKnowledgeLearnDetail.MarkTime] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.MarkTime].ToString().Trim(); //批改时间
objKnowledgeLearnDetailEN.IsAnalysis = clsEntityBase2.TransNullToBool_S(objRow[conKnowledgeLearnDetail.IsAnalysis].ToString().Trim()); //是否分析
objKnowledgeLearnDetailEN.CourseId = objRow[conKnowledgeLearnDetail.CourseId].ToString().Trim(); //课程Id
objKnowledgeLearnDetailEN.UpdDate = objRow[conKnowledgeLearnDetail.UpdDate].ToString().Trim(); //修改日期
objKnowledgeLearnDetailEN.UpdUser = objRow[conKnowledgeLearnDetail.UpdUser].ToString().Trim(); //修改人
objKnowledgeLearnDetailEN.Memo = objRow[conKnowledgeLearnDetail.Memo] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objKnowledgeLearnDetailEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objKnowledgeLearnDetailEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsKnowledgeLearnDetailEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strCourseId)
{
string strKey = string.Format("{0}_{1}", clsKnowledgeLearnDetailEN._CurrTabName, strCourseId);
List<clsKnowledgeLearnDetailEN> arrKnowledgeLearnDetailObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsKnowledgeLearnDetailEN> arrKnowledgeLearnDetailObjLst_Sel =
arrKnowledgeLearnDetailObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrKnowledgeLearnDetailObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsKnowledgeLearnDetailEN> GetObjLst(string strWhereCond)
{
List<clsKnowledgeLearnDetailEN> arrObjLst = new List<clsKnowledgeLearnDetailEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN = new clsKnowledgeLearnDetailEN();
try
{
objKnowledgeLearnDetailEN.mId = Int32.Parse(objRow[conKnowledgeLearnDetail.mId].ToString().Trim()); //mId
objKnowledgeLearnDetailEN.UserId = objRow[conKnowledgeLearnDetail.UserId] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.UserId].ToString().Trim(); //用户ID
objKnowledgeLearnDetailEN.LearnDate = objRow[conKnowledgeLearnDetail.LearnDate].ToString().Trim(); //学习日期
objKnowledgeLearnDetailEN.LearnModeId = objRow[conKnowledgeLearnDetail.LearnModeId].ToString().Trim(); //学习模式Id
objKnowledgeLearnDetailEN.CourseKnowledgeId = objRow[conKnowledgeLearnDetail.CourseKnowledgeId] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.CourseKnowledgeId].ToString().Trim(); //知识点Id
objKnowledgeLearnDetailEN.IdCase = objRow[conKnowledgeLearnDetail.IdCase] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.IdCase].ToString().Trim(); //案例流水号
objKnowledgeLearnDetailEN.IdCaseType = objRow[conKnowledgeLearnDetail.IdCaseType] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.IdCaseType].ToString().Trim(); //案例类型流水号
objKnowledgeLearnDetailEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conKnowledgeLearnDetail.IsRight].ToString().Trim()); //是否正确
objKnowledgeLearnDetailEN.IsMaster = clsEntityBase2.TransNullToBool_S(objRow[conKnowledgeLearnDetail.IsMaster].ToString().Trim()); //是否掌握
objKnowledgeLearnDetailEN.MasterDegree = Double.Parse(objRow[conKnowledgeLearnDetail.MasterDegree].ToString().Trim()); //掌握程度
objKnowledgeLearnDetailEN.MarkerId = objRow[conKnowledgeLearnDetail.MarkerId] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.MarkerId].ToString().Trim(); //打分者
objKnowledgeLearnDetailEN.MarkTime = objRow[conKnowledgeLearnDetail.MarkTime] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.MarkTime].ToString().Trim(); //批改时间
objKnowledgeLearnDetailEN.IsAnalysis = clsEntityBase2.TransNullToBool_S(objRow[conKnowledgeLearnDetail.IsAnalysis].ToString().Trim()); //是否分析
objKnowledgeLearnDetailEN.CourseId = objRow[conKnowledgeLearnDetail.CourseId].ToString().Trim(); //课程Id
objKnowledgeLearnDetailEN.UpdDate = objRow[conKnowledgeLearnDetail.UpdDate].ToString().Trim(); //修改日期
objKnowledgeLearnDetailEN.UpdUser = objRow[conKnowledgeLearnDetail.UpdUser].ToString().Trim(); //修改人
objKnowledgeLearnDetailEN.Memo = objRow[conKnowledgeLearnDetail.Memo] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objKnowledgeLearnDetailEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objKnowledgeLearnDetailEN);
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
public static List<clsKnowledgeLearnDetailEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsKnowledgeLearnDetailEN> arrObjLst = new List<clsKnowledgeLearnDetailEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN = new clsKnowledgeLearnDetailEN();
try
{
objKnowledgeLearnDetailEN.mId = Int32.Parse(objRow[conKnowledgeLearnDetail.mId].ToString().Trim()); //mId
objKnowledgeLearnDetailEN.UserId = objRow[conKnowledgeLearnDetail.UserId] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.UserId].ToString().Trim(); //用户ID
objKnowledgeLearnDetailEN.LearnDate = objRow[conKnowledgeLearnDetail.LearnDate].ToString().Trim(); //学习日期
objKnowledgeLearnDetailEN.LearnModeId = objRow[conKnowledgeLearnDetail.LearnModeId].ToString().Trim(); //学习模式Id
objKnowledgeLearnDetailEN.CourseKnowledgeId = objRow[conKnowledgeLearnDetail.CourseKnowledgeId] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.CourseKnowledgeId].ToString().Trim(); //知识点Id
objKnowledgeLearnDetailEN.IdCase = objRow[conKnowledgeLearnDetail.IdCase] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.IdCase].ToString().Trim(); //案例流水号
objKnowledgeLearnDetailEN.IdCaseType = objRow[conKnowledgeLearnDetail.IdCaseType] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.IdCaseType].ToString().Trim(); //案例类型流水号
objKnowledgeLearnDetailEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conKnowledgeLearnDetail.IsRight].ToString().Trim()); //是否正确
objKnowledgeLearnDetailEN.IsMaster = clsEntityBase2.TransNullToBool_S(objRow[conKnowledgeLearnDetail.IsMaster].ToString().Trim()); //是否掌握
objKnowledgeLearnDetailEN.MasterDegree = Double.Parse(objRow[conKnowledgeLearnDetail.MasterDegree].ToString().Trim()); //掌握程度
objKnowledgeLearnDetailEN.MarkerId = objRow[conKnowledgeLearnDetail.MarkerId] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.MarkerId].ToString().Trim(); //打分者
objKnowledgeLearnDetailEN.MarkTime = objRow[conKnowledgeLearnDetail.MarkTime] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.MarkTime].ToString().Trim(); //批改时间
objKnowledgeLearnDetailEN.IsAnalysis = clsEntityBase2.TransNullToBool_S(objRow[conKnowledgeLearnDetail.IsAnalysis].ToString().Trim()); //是否分析
objKnowledgeLearnDetailEN.CourseId = objRow[conKnowledgeLearnDetail.CourseId].ToString().Trim(); //课程Id
objKnowledgeLearnDetailEN.UpdDate = objRow[conKnowledgeLearnDetail.UpdDate].ToString().Trim(); //修改日期
objKnowledgeLearnDetailEN.UpdUser = objRow[conKnowledgeLearnDetail.UpdUser].ToString().Trim(); //修改人
objKnowledgeLearnDetailEN.Memo = objRow[conKnowledgeLearnDetail.Memo] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objKnowledgeLearnDetailEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objKnowledgeLearnDetailEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objKnowledgeLearnDetailCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsKnowledgeLearnDetailEN> GetSubObjLstCache(clsKnowledgeLearnDetailEN objKnowledgeLearnDetailCond)
{
 string strCourseId = objKnowledgeLearnDetailCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsKnowledgeLearnDetailBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsKnowledgeLearnDetailEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsKnowledgeLearnDetailEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conKnowledgeLearnDetail.AttributeName)
{
if (objKnowledgeLearnDetailCond.IsUpdated(strFldName) == false) continue;
if (objKnowledgeLearnDetailCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objKnowledgeLearnDetailCond[strFldName].ToString());
}
else
{
if (objKnowledgeLearnDetailCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objKnowledgeLearnDetailCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objKnowledgeLearnDetailCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objKnowledgeLearnDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objKnowledgeLearnDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objKnowledgeLearnDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objKnowledgeLearnDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objKnowledgeLearnDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objKnowledgeLearnDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objKnowledgeLearnDetailCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objKnowledgeLearnDetailCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objKnowledgeLearnDetailCond[strFldName]));
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
public static List<clsKnowledgeLearnDetailEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsKnowledgeLearnDetailEN> arrObjLst = new List<clsKnowledgeLearnDetailEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN = new clsKnowledgeLearnDetailEN();
try
{
objKnowledgeLearnDetailEN.mId = Int32.Parse(objRow[conKnowledgeLearnDetail.mId].ToString().Trim()); //mId
objKnowledgeLearnDetailEN.UserId = objRow[conKnowledgeLearnDetail.UserId] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.UserId].ToString().Trim(); //用户ID
objKnowledgeLearnDetailEN.LearnDate = objRow[conKnowledgeLearnDetail.LearnDate].ToString().Trim(); //学习日期
objKnowledgeLearnDetailEN.LearnModeId = objRow[conKnowledgeLearnDetail.LearnModeId].ToString().Trim(); //学习模式Id
objKnowledgeLearnDetailEN.CourseKnowledgeId = objRow[conKnowledgeLearnDetail.CourseKnowledgeId] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.CourseKnowledgeId].ToString().Trim(); //知识点Id
objKnowledgeLearnDetailEN.IdCase = objRow[conKnowledgeLearnDetail.IdCase] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.IdCase].ToString().Trim(); //案例流水号
objKnowledgeLearnDetailEN.IdCaseType = objRow[conKnowledgeLearnDetail.IdCaseType] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.IdCaseType].ToString().Trim(); //案例类型流水号
objKnowledgeLearnDetailEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conKnowledgeLearnDetail.IsRight].ToString().Trim()); //是否正确
objKnowledgeLearnDetailEN.IsMaster = clsEntityBase2.TransNullToBool_S(objRow[conKnowledgeLearnDetail.IsMaster].ToString().Trim()); //是否掌握
objKnowledgeLearnDetailEN.MasterDegree = Double.Parse(objRow[conKnowledgeLearnDetail.MasterDegree].ToString().Trim()); //掌握程度
objKnowledgeLearnDetailEN.MarkerId = objRow[conKnowledgeLearnDetail.MarkerId] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.MarkerId].ToString().Trim(); //打分者
objKnowledgeLearnDetailEN.MarkTime = objRow[conKnowledgeLearnDetail.MarkTime] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.MarkTime].ToString().Trim(); //批改时间
objKnowledgeLearnDetailEN.IsAnalysis = clsEntityBase2.TransNullToBool_S(objRow[conKnowledgeLearnDetail.IsAnalysis].ToString().Trim()); //是否分析
objKnowledgeLearnDetailEN.CourseId = objRow[conKnowledgeLearnDetail.CourseId].ToString().Trim(); //课程Id
objKnowledgeLearnDetailEN.UpdDate = objRow[conKnowledgeLearnDetail.UpdDate].ToString().Trim(); //修改日期
objKnowledgeLearnDetailEN.UpdUser = objRow[conKnowledgeLearnDetail.UpdUser].ToString().Trim(); //修改人
objKnowledgeLearnDetailEN.Memo = objRow[conKnowledgeLearnDetail.Memo] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objKnowledgeLearnDetailEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objKnowledgeLearnDetailEN);
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
public static List<clsKnowledgeLearnDetailEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsKnowledgeLearnDetailEN> arrObjLst = new List<clsKnowledgeLearnDetailEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN = new clsKnowledgeLearnDetailEN();
try
{
objKnowledgeLearnDetailEN.mId = Int32.Parse(objRow[conKnowledgeLearnDetail.mId].ToString().Trim()); //mId
objKnowledgeLearnDetailEN.UserId = objRow[conKnowledgeLearnDetail.UserId] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.UserId].ToString().Trim(); //用户ID
objKnowledgeLearnDetailEN.LearnDate = objRow[conKnowledgeLearnDetail.LearnDate].ToString().Trim(); //学习日期
objKnowledgeLearnDetailEN.LearnModeId = objRow[conKnowledgeLearnDetail.LearnModeId].ToString().Trim(); //学习模式Id
objKnowledgeLearnDetailEN.CourseKnowledgeId = objRow[conKnowledgeLearnDetail.CourseKnowledgeId] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.CourseKnowledgeId].ToString().Trim(); //知识点Id
objKnowledgeLearnDetailEN.IdCase = objRow[conKnowledgeLearnDetail.IdCase] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.IdCase].ToString().Trim(); //案例流水号
objKnowledgeLearnDetailEN.IdCaseType = objRow[conKnowledgeLearnDetail.IdCaseType] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.IdCaseType].ToString().Trim(); //案例类型流水号
objKnowledgeLearnDetailEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conKnowledgeLearnDetail.IsRight].ToString().Trim()); //是否正确
objKnowledgeLearnDetailEN.IsMaster = clsEntityBase2.TransNullToBool_S(objRow[conKnowledgeLearnDetail.IsMaster].ToString().Trim()); //是否掌握
objKnowledgeLearnDetailEN.MasterDegree = Double.Parse(objRow[conKnowledgeLearnDetail.MasterDegree].ToString().Trim()); //掌握程度
objKnowledgeLearnDetailEN.MarkerId = objRow[conKnowledgeLearnDetail.MarkerId] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.MarkerId].ToString().Trim(); //打分者
objKnowledgeLearnDetailEN.MarkTime = objRow[conKnowledgeLearnDetail.MarkTime] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.MarkTime].ToString().Trim(); //批改时间
objKnowledgeLearnDetailEN.IsAnalysis = clsEntityBase2.TransNullToBool_S(objRow[conKnowledgeLearnDetail.IsAnalysis].ToString().Trim()); //是否分析
objKnowledgeLearnDetailEN.CourseId = objRow[conKnowledgeLearnDetail.CourseId].ToString().Trim(); //课程Id
objKnowledgeLearnDetailEN.UpdDate = objRow[conKnowledgeLearnDetail.UpdDate].ToString().Trim(); //修改日期
objKnowledgeLearnDetailEN.UpdUser = objRow[conKnowledgeLearnDetail.UpdUser].ToString().Trim(); //修改人
objKnowledgeLearnDetailEN.Memo = objRow[conKnowledgeLearnDetail.Memo] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objKnowledgeLearnDetailEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objKnowledgeLearnDetailEN);
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
List<clsKnowledgeLearnDetailEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsKnowledgeLearnDetailEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsKnowledgeLearnDetailEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsKnowledgeLearnDetailEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsKnowledgeLearnDetailEN> arrObjLst = new List<clsKnowledgeLearnDetailEN>(); 
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
	clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN = new clsKnowledgeLearnDetailEN();
try
{
objKnowledgeLearnDetailEN.mId = Int32.Parse(objRow[conKnowledgeLearnDetail.mId].ToString().Trim()); //mId
objKnowledgeLearnDetailEN.UserId = objRow[conKnowledgeLearnDetail.UserId] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.UserId].ToString().Trim(); //用户ID
objKnowledgeLearnDetailEN.LearnDate = objRow[conKnowledgeLearnDetail.LearnDate].ToString().Trim(); //学习日期
objKnowledgeLearnDetailEN.LearnModeId = objRow[conKnowledgeLearnDetail.LearnModeId].ToString().Trim(); //学习模式Id
objKnowledgeLearnDetailEN.CourseKnowledgeId = objRow[conKnowledgeLearnDetail.CourseKnowledgeId] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.CourseKnowledgeId].ToString().Trim(); //知识点Id
objKnowledgeLearnDetailEN.IdCase = objRow[conKnowledgeLearnDetail.IdCase] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.IdCase].ToString().Trim(); //案例流水号
objKnowledgeLearnDetailEN.IdCaseType = objRow[conKnowledgeLearnDetail.IdCaseType] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.IdCaseType].ToString().Trim(); //案例类型流水号
objKnowledgeLearnDetailEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conKnowledgeLearnDetail.IsRight].ToString().Trim()); //是否正确
objKnowledgeLearnDetailEN.IsMaster = clsEntityBase2.TransNullToBool_S(objRow[conKnowledgeLearnDetail.IsMaster].ToString().Trim()); //是否掌握
objKnowledgeLearnDetailEN.MasterDegree = Double.Parse(objRow[conKnowledgeLearnDetail.MasterDegree].ToString().Trim()); //掌握程度
objKnowledgeLearnDetailEN.MarkerId = objRow[conKnowledgeLearnDetail.MarkerId] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.MarkerId].ToString().Trim(); //打分者
objKnowledgeLearnDetailEN.MarkTime = objRow[conKnowledgeLearnDetail.MarkTime] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.MarkTime].ToString().Trim(); //批改时间
objKnowledgeLearnDetailEN.IsAnalysis = clsEntityBase2.TransNullToBool_S(objRow[conKnowledgeLearnDetail.IsAnalysis].ToString().Trim()); //是否分析
objKnowledgeLearnDetailEN.CourseId = objRow[conKnowledgeLearnDetail.CourseId].ToString().Trim(); //课程Id
objKnowledgeLearnDetailEN.UpdDate = objRow[conKnowledgeLearnDetail.UpdDate].ToString().Trim(); //修改日期
objKnowledgeLearnDetailEN.UpdUser = objRow[conKnowledgeLearnDetail.UpdUser].ToString().Trim(); //修改人
objKnowledgeLearnDetailEN.Memo = objRow[conKnowledgeLearnDetail.Memo] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objKnowledgeLearnDetailEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objKnowledgeLearnDetailEN);
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
public static List<clsKnowledgeLearnDetailEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsKnowledgeLearnDetailEN> arrObjLst = new List<clsKnowledgeLearnDetailEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN = new clsKnowledgeLearnDetailEN();
try
{
objKnowledgeLearnDetailEN.mId = Int32.Parse(objRow[conKnowledgeLearnDetail.mId].ToString().Trim()); //mId
objKnowledgeLearnDetailEN.UserId = objRow[conKnowledgeLearnDetail.UserId] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.UserId].ToString().Trim(); //用户ID
objKnowledgeLearnDetailEN.LearnDate = objRow[conKnowledgeLearnDetail.LearnDate].ToString().Trim(); //学习日期
objKnowledgeLearnDetailEN.LearnModeId = objRow[conKnowledgeLearnDetail.LearnModeId].ToString().Trim(); //学习模式Id
objKnowledgeLearnDetailEN.CourseKnowledgeId = objRow[conKnowledgeLearnDetail.CourseKnowledgeId] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.CourseKnowledgeId].ToString().Trim(); //知识点Id
objKnowledgeLearnDetailEN.IdCase = objRow[conKnowledgeLearnDetail.IdCase] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.IdCase].ToString().Trim(); //案例流水号
objKnowledgeLearnDetailEN.IdCaseType = objRow[conKnowledgeLearnDetail.IdCaseType] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.IdCaseType].ToString().Trim(); //案例类型流水号
objKnowledgeLearnDetailEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conKnowledgeLearnDetail.IsRight].ToString().Trim()); //是否正确
objKnowledgeLearnDetailEN.IsMaster = clsEntityBase2.TransNullToBool_S(objRow[conKnowledgeLearnDetail.IsMaster].ToString().Trim()); //是否掌握
objKnowledgeLearnDetailEN.MasterDegree = Double.Parse(objRow[conKnowledgeLearnDetail.MasterDegree].ToString().Trim()); //掌握程度
objKnowledgeLearnDetailEN.MarkerId = objRow[conKnowledgeLearnDetail.MarkerId] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.MarkerId].ToString().Trim(); //打分者
objKnowledgeLearnDetailEN.MarkTime = objRow[conKnowledgeLearnDetail.MarkTime] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.MarkTime].ToString().Trim(); //批改时间
objKnowledgeLearnDetailEN.IsAnalysis = clsEntityBase2.TransNullToBool_S(objRow[conKnowledgeLearnDetail.IsAnalysis].ToString().Trim()); //是否分析
objKnowledgeLearnDetailEN.CourseId = objRow[conKnowledgeLearnDetail.CourseId].ToString().Trim(); //课程Id
objKnowledgeLearnDetailEN.UpdDate = objRow[conKnowledgeLearnDetail.UpdDate].ToString().Trim(); //修改日期
objKnowledgeLearnDetailEN.UpdUser = objRow[conKnowledgeLearnDetail.UpdUser].ToString().Trim(); //修改人
objKnowledgeLearnDetailEN.Memo = objRow[conKnowledgeLearnDetail.Memo] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objKnowledgeLearnDetailEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objKnowledgeLearnDetailEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsKnowledgeLearnDetailEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsKnowledgeLearnDetailEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsKnowledgeLearnDetailEN> arrObjLst = new List<clsKnowledgeLearnDetailEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN = new clsKnowledgeLearnDetailEN();
try
{
objKnowledgeLearnDetailEN.mId = Int32.Parse(objRow[conKnowledgeLearnDetail.mId].ToString().Trim()); //mId
objKnowledgeLearnDetailEN.UserId = objRow[conKnowledgeLearnDetail.UserId] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.UserId].ToString().Trim(); //用户ID
objKnowledgeLearnDetailEN.LearnDate = objRow[conKnowledgeLearnDetail.LearnDate].ToString().Trim(); //学习日期
objKnowledgeLearnDetailEN.LearnModeId = objRow[conKnowledgeLearnDetail.LearnModeId].ToString().Trim(); //学习模式Id
objKnowledgeLearnDetailEN.CourseKnowledgeId = objRow[conKnowledgeLearnDetail.CourseKnowledgeId] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.CourseKnowledgeId].ToString().Trim(); //知识点Id
objKnowledgeLearnDetailEN.IdCase = objRow[conKnowledgeLearnDetail.IdCase] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.IdCase].ToString().Trim(); //案例流水号
objKnowledgeLearnDetailEN.IdCaseType = objRow[conKnowledgeLearnDetail.IdCaseType] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.IdCaseType].ToString().Trim(); //案例类型流水号
objKnowledgeLearnDetailEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conKnowledgeLearnDetail.IsRight].ToString().Trim()); //是否正确
objKnowledgeLearnDetailEN.IsMaster = clsEntityBase2.TransNullToBool_S(objRow[conKnowledgeLearnDetail.IsMaster].ToString().Trim()); //是否掌握
objKnowledgeLearnDetailEN.MasterDegree = Double.Parse(objRow[conKnowledgeLearnDetail.MasterDegree].ToString().Trim()); //掌握程度
objKnowledgeLearnDetailEN.MarkerId = objRow[conKnowledgeLearnDetail.MarkerId] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.MarkerId].ToString().Trim(); //打分者
objKnowledgeLearnDetailEN.MarkTime = objRow[conKnowledgeLearnDetail.MarkTime] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.MarkTime].ToString().Trim(); //批改时间
objKnowledgeLearnDetailEN.IsAnalysis = clsEntityBase2.TransNullToBool_S(objRow[conKnowledgeLearnDetail.IsAnalysis].ToString().Trim()); //是否分析
objKnowledgeLearnDetailEN.CourseId = objRow[conKnowledgeLearnDetail.CourseId].ToString().Trim(); //课程Id
objKnowledgeLearnDetailEN.UpdDate = objRow[conKnowledgeLearnDetail.UpdDate].ToString().Trim(); //修改日期
objKnowledgeLearnDetailEN.UpdUser = objRow[conKnowledgeLearnDetail.UpdUser].ToString().Trim(); //修改人
objKnowledgeLearnDetailEN.Memo = objRow[conKnowledgeLearnDetail.Memo] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objKnowledgeLearnDetailEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objKnowledgeLearnDetailEN);
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
public static List<clsKnowledgeLearnDetailEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsKnowledgeLearnDetailEN> arrObjLst = new List<clsKnowledgeLearnDetailEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN = new clsKnowledgeLearnDetailEN();
try
{
objKnowledgeLearnDetailEN.mId = Int32.Parse(objRow[conKnowledgeLearnDetail.mId].ToString().Trim()); //mId
objKnowledgeLearnDetailEN.UserId = objRow[conKnowledgeLearnDetail.UserId] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.UserId].ToString().Trim(); //用户ID
objKnowledgeLearnDetailEN.LearnDate = objRow[conKnowledgeLearnDetail.LearnDate].ToString().Trim(); //学习日期
objKnowledgeLearnDetailEN.LearnModeId = objRow[conKnowledgeLearnDetail.LearnModeId].ToString().Trim(); //学习模式Id
objKnowledgeLearnDetailEN.CourseKnowledgeId = objRow[conKnowledgeLearnDetail.CourseKnowledgeId] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.CourseKnowledgeId].ToString().Trim(); //知识点Id
objKnowledgeLearnDetailEN.IdCase = objRow[conKnowledgeLearnDetail.IdCase] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.IdCase].ToString().Trim(); //案例流水号
objKnowledgeLearnDetailEN.IdCaseType = objRow[conKnowledgeLearnDetail.IdCaseType] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.IdCaseType].ToString().Trim(); //案例类型流水号
objKnowledgeLearnDetailEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conKnowledgeLearnDetail.IsRight].ToString().Trim()); //是否正确
objKnowledgeLearnDetailEN.IsMaster = clsEntityBase2.TransNullToBool_S(objRow[conKnowledgeLearnDetail.IsMaster].ToString().Trim()); //是否掌握
objKnowledgeLearnDetailEN.MasterDegree = Double.Parse(objRow[conKnowledgeLearnDetail.MasterDegree].ToString().Trim()); //掌握程度
objKnowledgeLearnDetailEN.MarkerId = objRow[conKnowledgeLearnDetail.MarkerId] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.MarkerId].ToString().Trim(); //打分者
objKnowledgeLearnDetailEN.MarkTime = objRow[conKnowledgeLearnDetail.MarkTime] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.MarkTime].ToString().Trim(); //批改时间
objKnowledgeLearnDetailEN.IsAnalysis = clsEntityBase2.TransNullToBool_S(objRow[conKnowledgeLearnDetail.IsAnalysis].ToString().Trim()); //是否分析
objKnowledgeLearnDetailEN.CourseId = objRow[conKnowledgeLearnDetail.CourseId].ToString().Trim(); //课程Id
objKnowledgeLearnDetailEN.UpdDate = objRow[conKnowledgeLearnDetail.UpdDate].ToString().Trim(); //修改日期
objKnowledgeLearnDetailEN.UpdUser = objRow[conKnowledgeLearnDetail.UpdUser].ToString().Trim(); //修改人
objKnowledgeLearnDetailEN.Memo = objRow[conKnowledgeLearnDetail.Memo] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objKnowledgeLearnDetailEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objKnowledgeLearnDetailEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsKnowledgeLearnDetailEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsKnowledgeLearnDetailEN> arrObjLst = new List<clsKnowledgeLearnDetailEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN = new clsKnowledgeLearnDetailEN();
try
{
objKnowledgeLearnDetailEN.mId = Int32.Parse(objRow[conKnowledgeLearnDetail.mId].ToString().Trim()); //mId
objKnowledgeLearnDetailEN.UserId = objRow[conKnowledgeLearnDetail.UserId] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.UserId].ToString().Trim(); //用户ID
objKnowledgeLearnDetailEN.LearnDate = objRow[conKnowledgeLearnDetail.LearnDate].ToString().Trim(); //学习日期
objKnowledgeLearnDetailEN.LearnModeId = objRow[conKnowledgeLearnDetail.LearnModeId].ToString().Trim(); //学习模式Id
objKnowledgeLearnDetailEN.CourseKnowledgeId = objRow[conKnowledgeLearnDetail.CourseKnowledgeId] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.CourseKnowledgeId].ToString().Trim(); //知识点Id
objKnowledgeLearnDetailEN.IdCase = objRow[conKnowledgeLearnDetail.IdCase] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.IdCase].ToString().Trim(); //案例流水号
objKnowledgeLearnDetailEN.IdCaseType = objRow[conKnowledgeLearnDetail.IdCaseType] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.IdCaseType].ToString().Trim(); //案例类型流水号
objKnowledgeLearnDetailEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conKnowledgeLearnDetail.IsRight].ToString().Trim()); //是否正确
objKnowledgeLearnDetailEN.IsMaster = clsEntityBase2.TransNullToBool_S(objRow[conKnowledgeLearnDetail.IsMaster].ToString().Trim()); //是否掌握
objKnowledgeLearnDetailEN.MasterDegree = Double.Parse(objRow[conKnowledgeLearnDetail.MasterDegree].ToString().Trim()); //掌握程度
objKnowledgeLearnDetailEN.MarkerId = objRow[conKnowledgeLearnDetail.MarkerId] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.MarkerId].ToString().Trim(); //打分者
objKnowledgeLearnDetailEN.MarkTime = objRow[conKnowledgeLearnDetail.MarkTime] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.MarkTime].ToString().Trim(); //批改时间
objKnowledgeLearnDetailEN.IsAnalysis = clsEntityBase2.TransNullToBool_S(objRow[conKnowledgeLearnDetail.IsAnalysis].ToString().Trim()); //是否分析
objKnowledgeLearnDetailEN.CourseId = objRow[conKnowledgeLearnDetail.CourseId].ToString().Trim(); //课程Id
objKnowledgeLearnDetailEN.UpdDate = objRow[conKnowledgeLearnDetail.UpdDate].ToString().Trim(); //修改日期
objKnowledgeLearnDetailEN.UpdUser = objRow[conKnowledgeLearnDetail.UpdUser].ToString().Trim(); //修改人
objKnowledgeLearnDetailEN.Memo = objRow[conKnowledgeLearnDetail.Memo] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objKnowledgeLearnDetailEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objKnowledgeLearnDetailEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objKnowledgeLearnDetailEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetKnowledgeLearnDetail(ref clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN)
{
bool bolResult = KnowledgeLearnDetailDA.GetKnowledgeLearnDetail(ref objKnowledgeLearnDetailEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsKnowledgeLearnDetailEN GetObjBymId(long lngmId)
{
clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN = KnowledgeLearnDetailDA.GetObjBymId(lngmId);
return objKnowledgeLearnDetailEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsKnowledgeLearnDetailEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN = KnowledgeLearnDetailDA.GetFirstObj(strWhereCond);
 return objKnowledgeLearnDetailEN;
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
public static clsKnowledgeLearnDetailEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN = KnowledgeLearnDetailDA.GetObjByDataRow(objRow);
 return objKnowledgeLearnDetailEN;
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
public static clsKnowledgeLearnDetailEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN = KnowledgeLearnDetailDA.GetObjByDataRow(objRow);
 return objKnowledgeLearnDetailEN;
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
 /// <param name = "lstKnowledgeLearnDetailObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsKnowledgeLearnDetailEN GetObjBymIdFromList(long lngmId, List<clsKnowledgeLearnDetailEN> lstKnowledgeLearnDetailObjLst)
{
foreach (clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN in lstKnowledgeLearnDetailObjLst)
{
if (objKnowledgeLearnDetailEN.mId == lngmId)
{
return objKnowledgeLearnDetailEN;
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
 lngmId = new clsKnowledgeLearnDetailDA().GetFirstID(strWhereCond);
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
 arrList = KnowledgeLearnDetailDA.GetID(strWhereCond);
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
bool bolIsExist = KnowledgeLearnDetailDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = KnowledgeLearnDetailDA.IsExist(lngmId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngmId">mId</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngmId, string strOpUser)
{
clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN = clsKnowledgeLearnDetailBL.GetObjBymId(lngmId);
objKnowledgeLearnDetailEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objKnowledgeLearnDetailEN.UpdUser = strOpUser;
return clsKnowledgeLearnDetailBL.UpdateBySql2(objKnowledgeLearnDetailEN);
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
 bolIsExist = clsKnowledgeLearnDetailDA.IsExistTable();
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
 bolIsExist = KnowledgeLearnDetailDA.IsExistTable(strTabName);
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
 /// <param name = "objKnowledgeLearnDetailEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objKnowledgeLearnDetailEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!用户ID = [{0}],案例流水号 = [{1}],知识点Id = [{2}]的数据已经存在!(in clsKnowledgeLearnDetailBL.AddNewRecordBySql2)", objKnowledgeLearnDetailEN.UserId,objKnowledgeLearnDetailEN.IdCase,objKnowledgeLearnDetailEN.CourseKnowledgeId);
throw new Exception(strMsg);
}
try
{
bool bolResult = KnowledgeLearnDetailDA.AddNewRecordBySQL2(objKnowledgeLearnDetailEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsKnowledgeLearnDetailBL.ReFreshCache(objKnowledgeLearnDetailEN.CourseId);

if (clsKnowledgeLearnDetailBL.relatedActions != null)
{
clsKnowledgeLearnDetailBL.relatedActions.UpdRelaTabDate(objKnowledgeLearnDetailEN.mId, objKnowledgeLearnDetailEN.UpdUser);
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
 /// <param name = "objKnowledgeLearnDetailEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objKnowledgeLearnDetailEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!用户ID = [{0}],案例流水号 = [{1}],知识点Id = [{2}]的数据已经存在!(in clsKnowledgeLearnDetailBL.AddNewRecordBySql2WithReturnKey)", objKnowledgeLearnDetailEN.UserId,objKnowledgeLearnDetailEN.IdCase,objKnowledgeLearnDetailEN.CourseKnowledgeId);
throw new Exception(strMsg);
}
try
{
string strKey = KnowledgeLearnDetailDA.AddNewRecordBySQL2WithReturnKey(objKnowledgeLearnDetailEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsKnowledgeLearnDetailBL.ReFreshCache(objKnowledgeLearnDetailEN.CourseId);

if (clsKnowledgeLearnDetailBL.relatedActions != null)
{
clsKnowledgeLearnDetailBL.relatedActions.UpdRelaTabDate(objKnowledgeLearnDetailEN.mId, objKnowledgeLearnDetailEN.UpdUser);
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
 /// <param name = "objKnowledgeLearnDetailEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN)
{
try
{
bool bolResult = KnowledgeLearnDetailDA.Update(objKnowledgeLearnDetailEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsKnowledgeLearnDetailBL.ReFreshCache(objKnowledgeLearnDetailEN.CourseId);

if (clsKnowledgeLearnDetailBL.relatedActions != null)
{
clsKnowledgeLearnDetailBL.relatedActions.UpdRelaTabDate(objKnowledgeLearnDetailEN.mId, objKnowledgeLearnDetailEN.UpdUser);
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
 /// <param name = "objKnowledgeLearnDetailEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN)
{
 if (objKnowledgeLearnDetailEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = KnowledgeLearnDetailDA.UpdateBySql2(objKnowledgeLearnDetailEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsKnowledgeLearnDetailBL.ReFreshCache(objKnowledgeLearnDetailEN.CourseId);

if (clsKnowledgeLearnDetailBL.relatedActions != null)
{
clsKnowledgeLearnDetailBL.relatedActions.UpdRelaTabDate(objKnowledgeLearnDetailEN.mId, objKnowledgeLearnDetailEN.UpdUser);
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
 clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN = clsKnowledgeLearnDetailBL.GetObjBymId(lngmId);

if (clsKnowledgeLearnDetailBL.relatedActions != null)
{
clsKnowledgeLearnDetailBL.relatedActions.UpdRelaTabDate(objKnowledgeLearnDetailEN.mId, objKnowledgeLearnDetailEN.UpdUser);
}
if (objKnowledgeLearnDetailEN != null)
{
int intRecNum = KnowledgeLearnDetailDA.DelRecord(lngmId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objKnowledgeLearnDetailEN.CourseId);
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
 /// <param name = "strCourseId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(long lngmId , string strCourseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsKnowledgeLearnDetailDA.GetSpecSQLObj();
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
//删除与表:[KnowledgeLearnDetail]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conKnowledgeLearnDetail.mId,
//lngmId);
//        clsKnowledgeLearnDetailBL.DelKnowledgeLearnDetailsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsKnowledgeLearnDetailBL.DelRecord(lngmId, strCourseId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsKnowledgeLearnDetailBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
public static bool DelRecord(long lngmId, string strCourseId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsKnowledgeLearnDetailBL.relatedActions != null)
{
clsKnowledgeLearnDetailBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = KnowledgeLearnDetailDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(strCourseId);
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
public static int DelKnowledgeLearnDetails(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsKnowledgeLearnDetailBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsKnowledgeLearnDetailBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
 clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN = clsKnowledgeLearnDetailBL.GetObjBymId(long.Parse(arrmIdLst[0]));
int intDelRecNum = KnowledgeLearnDetailDA.DelKnowledgeLearnDetail(arrmIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objKnowledgeLearnDetailEN.CourseId);
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
public static int DelKnowledgeLearnDetailsByCond(string strWhereCond)
{
try
{
if (clsKnowledgeLearnDetailBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsKnowledgeLearnDetailBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
List<string> arrCourseId = GetFldValue(conKnowledgeLearnDetail.CourseId, strWhereCond);
int intRecNum = KnowledgeLearnDetailDA.DelKnowledgeLearnDetail(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
arrCourseId.ForEach(x => ReFreshCache(x));
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[KnowledgeLearnDetail]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId, string strCourseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsKnowledgeLearnDetailDA.GetSpecSQLObj();
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
//删除与表:[KnowledgeLearnDetail]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsKnowledgeLearnDetailBL.DelRecord(lngmId, strCourseId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsKnowledgeLearnDetailBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objKnowledgeLearnDetailENS">源对象</param>
 /// <param name = "objKnowledgeLearnDetailENT">目标对象</param>
 public static void CopyTo(clsKnowledgeLearnDetailEN objKnowledgeLearnDetailENS, clsKnowledgeLearnDetailEN objKnowledgeLearnDetailENT)
{
try
{
objKnowledgeLearnDetailENT.mId = objKnowledgeLearnDetailENS.mId; //mId
objKnowledgeLearnDetailENT.UserId = objKnowledgeLearnDetailENS.UserId; //用户ID
objKnowledgeLearnDetailENT.LearnDate = objKnowledgeLearnDetailENS.LearnDate; //学习日期
objKnowledgeLearnDetailENT.LearnModeId = objKnowledgeLearnDetailENS.LearnModeId; //学习模式Id
objKnowledgeLearnDetailENT.CourseKnowledgeId = objKnowledgeLearnDetailENS.CourseKnowledgeId; //知识点Id
objKnowledgeLearnDetailENT.IdCase = objKnowledgeLearnDetailENS.IdCase; //案例流水号
objKnowledgeLearnDetailENT.IdCaseType = objKnowledgeLearnDetailENS.IdCaseType; //案例类型流水号
objKnowledgeLearnDetailENT.IsRight = objKnowledgeLearnDetailENS.IsRight; //是否正确
objKnowledgeLearnDetailENT.IsMaster = objKnowledgeLearnDetailENS.IsMaster; //是否掌握
objKnowledgeLearnDetailENT.MasterDegree = objKnowledgeLearnDetailENS.MasterDegree; //掌握程度
objKnowledgeLearnDetailENT.MarkerId = objKnowledgeLearnDetailENS.MarkerId; //打分者
objKnowledgeLearnDetailENT.MarkTime = objKnowledgeLearnDetailENS.MarkTime; //批改时间
objKnowledgeLearnDetailENT.IsAnalysis = objKnowledgeLearnDetailENS.IsAnalysis; //是否分析
objKnowledgeLearnDetailENT.CourseId = objKnowledgeLearnDetailENS.CourseId; //课程Id
objKnowledgeLearnDetailENT.UpdDate = objKnowledgeLearnDetailENS.UpdDate; //修改日期
objKnowledgeLearnDetailENT.UpdUser = objKnowledgeLearnDetailENS.UpdUser; //修改人
objKnowledgeLearnDetailENT.Memo = objKnowledgeLearnDetailENS.Memo; //备注
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
 /// <param name = "objKnowledgeLearnDetailEN">源简化对象</param>
 public static void SetUpdFlag(clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN)
{
try
{
objKnowledgeLearnDetailEN.ClearUpdateState();
   string strsfUpdFldSetStr = objKnowledgeLearnDetailEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conKnowledgeLearnDetail.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objKnowledgeLearnDetailEN.mId = objKnowledgeLearnDetailEN.mId; //mId
}
if (arrFldSet.Contains(conKnowledgeLearnDetail.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objKnowledgeLearnDetailEN.UserId = objKnowledgeLearnDetailEN.UserId == "[null]" ? null :  objKnowledgeLearnDetailEN.UserId; //用户ID
}
if (arrFldSet.Contains(conKnowledgeLearnDetail.LearnDate, new clsStrCompareIgnoreCase())  ==  true)
{
objKnowledgeLearnDetailEN.LearnDate = objKnowledgeLearnDetailEN.LearnDate; //学习日期
}
if (arrFldSet.Contains(conKnowledgeLearnDetail.LearnModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objKnowledgeLearnDetailEN.LearnModeId = objKnowledgeLearnDetailEN.LearnModeId; //学习模式Id
}
if (arrFldSet.Contains(conKnowledgeLearnDetail.CourseKnowledgeId, new clsStrCompareIgnoreCase())  ==  true)
{
objKnowledgeLearnDetailEN.CourseKnowledgeId = objKnowledgeLearnDetailEN.CourseKnowledgeId == "[null]" ? null :  objKnowledgeLearnDetailEN.CourseKnowledgeId; //知识点Id
}
if (arrFldSet.Contains(conKnowledgeLearnDetail.IdCase, new clsStrCompareIgnoreCase())  ==  true)
{
objKnowledgeLearnDetailEN.IdCase = objKnowledgeLearnDetailEN.IdCase == "[null]" ? null :  objKnowledgeLearnDetailEN.IdCase; //案例流水号
}
if (arrFldSet.Contains(conKnowledgeLearnDetail.IdCaseType, new clsStrCompareIgnoreCase())  ==  true)
{
objKnowledgeLearnDetailEN.IdCaseType = objKnowledgeLearnDetailEN.IdCaseType == "[null]" ? null :  objKnowledgeLearnDetailEN.IdCaseType; //案例类型流水号
}
if (arrFldSet.Contains(conKnowledgeLearnDetail.IsRight, new clsStrCompareIgnoreCase())  ==  true)
{
objKnowledgeLearnDetailEN.IsRight = objKnowledgeLearnDetailEN.IsRight; //是否正确
}
if (arrFldSet.Contains(conKnowledgeLearnDetail.IsMaster, new clsStrCompareIgnoreCase())  ==  true)
{
objKnowledgeLearnDetailEN.IsMaster = objKnowledgeLearnDetailEN.IsMaster; //是否掌握
}
if (arrFldSet.Contains(conKnowledgeLearnDetail.MasterDegree, new clsStrCompareIgnoreCase())  ==  true)
{
objKnowledgeLearnDetailEN.MasterDegree = objKnowledgeLearnDetailEN.MasterDegree; //掌握程度
}
if (arrFldSet.Contains(conKnowledgeLearnDetail.MarkerId, new clsStrCompareIgnoreCase())  ==  true)
{
objKnowledgeLearnDetailEN.MarkerId = objKnowledgeLearnDetailEN.MarkerId == "[null]" ? null :  objKnowledgeLearnDetailEN.MarkerId; //打分者
}
if (arrFldSet.Contains(conKnowledgeLearnDetail.MarkTime, new clsStrCompareIgnoreCase())  ==  true)
{
objKnowledgeLearnDetailEN.MarkTime = objKnowledgeLearnDetailEN.MarkTime == "[null]" ? null :  objKnowledgeLearnDetailEN.MarkTime; //批改时间
}
if (arrFldSet.Contains(conKnowledgeLearnDetail.IsAnalysis, new clsStrCompareIgnoreCase())  ==  true)
{
objKnowledgeLearnDetailEN.IsAnalysis = objKnowledgeLearnDetailEN.IsAnalysis; //是否分析
}
if (arrFldSet.Contains(conKnowledgeLearnDetail.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objKnowledgeLearnDetailEN.CourseId = objKnowledgeLearnDetailEN.CourseId; //课程Id
}
if (arrFldSet.Contains(conKnowledgeLearnDetail.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objKnowledgeLearnDetailEN.UpdDate = objKnowledgeLearnDetailEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conKnowledgeLearnDetail.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objKnowledgeLearnDetailEN.UpdUser = objKnowledgeLearnDetailEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conKnowledgeLearnDetail.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objKnowledgeLearnDetailEN.Memo = objKnowledgeLearnDetailEN.Memo == "[null]" ? null :  objKnowledgeLearnDetailEN.Memo; //备注
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
 /// <param name = "objKnowledgeLearnDetailEN">源简化对象</param>
 public static void AccessFldValueNull(clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN)
{
try
{
if (objKnowledgeLearnDetailEN.UserId == "[null]") objKnowledgeLearnDetailEN.UserId = null; //用户ID
if (objKnowledgeLearnDetailEN.CourseKnowledgeId == "[null]") objKnowledgeLearnDetailEN.CourseKnowledgeId = null; //知识点Id
if (objKnowledgeLearnDetailEN.IdCase == "[null]") objKnowledgeLearnDetailEN.IdCase = null; //案例流水号
if (objKnowledgeLearnDetailEN.IdCaseType == "[null]") objKnowledgeLearnDetailEN.IdCaseType = null; //案例类型流水号
if (objKnowledgeLearnDetailEN.MarkerId == "[null]") objKnowledgeLearnDetailEN.MarkerId = null; //打分者
if (objKnowledgeLearnDetailEN.MarkTime == "[null]") objKnowledgeLearnDetailEN.MarkTime = null; //批改时间
if (objKnowledgeLearnDetailEN.Memo == "[null]") objKnowledgeLearnDetailEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN)
{
 KnowledgeLearnDetailDA.CheckPropertyNew(objKnowledgeLearnDetailEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN)
{
 KnowledgeLearnDetailDA.CheckProperty4Condition(objKnowledgeLearnDetailEN);
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
if (clsKnowledgeLearnDetailBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsKnowledgeLearnDetailBL没有刷新缓存机制(clsKnowledgeLearnDetailBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrKnowledgeLearnDetailObjLstCache == null)
//{
//arrKnowledgeLearnDetailObjLstCache = KnowledgeLearnDetailDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsKnowledgeLearnDetailEN GetObjBymIdCache(long lngmId, string strCourseId)
{

if (string.IsNullOrEmpty(strCourseId) == true)
{
  var strMsg = string.Format("参数:[strCourseId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strCourseId.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strCourseId]的长度:[{0}]不正确!(In {1})", strCourseId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsKnowledgeLearnDetailEN._CurrTabName, strCourseId);
List<clsKnowledgeLearnDetailEN> arrKnowledgeLearnDetailObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsKnowledgeLearnDetailEN> arrKnowledgeLearnDetailObjLst_Sel =
arrKnowledgeLearnDetailObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrKnowledgeLearnDetailObjLst_Sel.Count() == 0)
{
   clsKnowledgeLearnDetailEN obj = clsKnowledgeLearnDetailBL.GetObjBymId(lngmId);
   if (obj != null)
 {
if (obj.CourseId == strCourseId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngmId, strCourseId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrKnowledgeLearnDetailObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsKnowledgeLearnDetailEN> GetAllKnowledgeLearnDetailObjLstCache(string strCourseId)
{
//获取缓存中的对象列表
List<clsKnowledgeLearnDetailEN> arrKnowledgeLearnDetailObjLstCache = GetObjLstCache(strCourseId); 
return arrKnowledgeLearnDetailObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsKnowledgeLearnDetailEN> GetObjLstCache(string strCourseId)
{

if (string.IsNullOrEmpty(strCourseId) == true)
{
  var strMsg = string.Format("参数:[strCourseId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strCourseId.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strCourseId]的长度:[{0}]不正确!(In {1})", strCourseId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsKnowledgeLearnDetailEN._CurrTabName, strCourseId);
string strCondition = string.Format("CourseId='{0}'", strCourseId);
List<clsKnowledgeLearnDetailEN> arrKnowledgeLearnDetailObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrKnowledgeLearnDetailObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strCourseId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsKnowledgeLearnDetailEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clsKnowledgeLearnDetailEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsKnowledgeLearnDetailEN._RefreshTimeLst.Count == 0) return "";
return clsKnowledgeLearnDetailEN._RefreshTimeLst[clsKnowledgeLearnDetailEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strCourseId)
{
if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("缓存分类字段:[CourseId]不能为空!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsKnowledgeLearnDetailBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsKnowledgeLearnDetailEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clsKnowledgeLearnDetailEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsKnowledgeLearnDetailBL.objCommFun4BL.ReFreshCache(strCourseId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--KnowledgeLearnDetail(知识点学习情况)
 /// 唯一性条件:UserId_CourseKnowledgeId_Id_Case
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objKnowledgeLearnDetailEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN)
{
//检测记录是否存在
string strResult = KnowledgeLearnDetailDA.GetUniCondStr(objKnowledgeLearnDetailEN);
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
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strCourseId)
{
if (strInFldName != conKnowledgeLearnDetail.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conKnowledgeLearnDetail.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conKnowledgeLearnDetail.AttributeName));
throw new Exception(strMsg);
}
var objKnowledgeLearnDetail = clsKnowledgeLearnDetailBL.GetObjBymIdCache(lngmId, strCourseId);
if (objKnowledgeLearnDetail == null) return "";
return objKnowledgeLearnDetail[strOutFldName].ToString();
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
int intRecCount = clsKnowledgeLearnDetailDA.GetRecCount(strTabName);
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
int intRecCount = clsKnowledgeLearnDetailDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsKnowledgeLearnDetailDA.GetRecCount();
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
int intRecCount = clsKnowledgeLearnDetailDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objKnowledgeLearnDetailCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsKnowledgeLearnDetailEN objKnowledgeLearnDetailCond)
{
 string strCourseId = objKnowledgeLearnDetailCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsKnowledgeLearnDetailBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsKnowledgeLearnDetailEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsKnowledgeLearnDetailEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conKnowledgeLearnDetail.AttributeName)
{
if (objKnowledgeLearnDetailCond.IsUpdated(strFldName) == false) continue;
if (objKnowledgeLearnDetailCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objKnowledgeLearnDetailCond[strFldName].ToString());
}
else
{
if (objKnowledgeLearnDetailCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objKnowledgeLearnDetailCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objKnowledgeLearnDetailCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objKnowledgeLearnDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objKnowledgeLearnDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objKnowledgeLearnDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objKnowledgeLearnDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objKnowledgeLearnDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objKnowledgeLearnDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objKnowledgeLearnDetailCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objKnowledgeLearnDetailCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objKnowledgeLearnDetailCond[strFldName]));
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
 List<string> arrList = clsKnowledgeLearnDetailDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = KnowledgeLearnDetailDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = KnowledgeLearnDetailDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = KnowledgeLearnDetailDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsKnowledgeLearnDetailDA.SetFldValue(clsKnowledgeLearnDetailEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = KnowledgeLearnDetailDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsKnowledgeLearnDetailDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsKnowledgeLearnDetailDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsKnowledgeLearnDetailDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[KnowledgeLearnDetail] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**用户ID*/ 
 strCreateTabCode.Append(" UserId varchar(18) Null, "); 
 // /**学习日期*/ 
 strCreateTabCode.Append(" LearnDate varchar(20) not Null, "); 
 // /**学习模式Id*/ 
 strCreateTabCode.Append(" LearnModeId char(4) not Null, "); 
 // /**知识点Id*/ 
 strCreateTabCode.Append(" CourseKnowledgeId char(8) Null, "); 
 // /**案例流水号*/ 
 strCreateTabCode.Append(" IdCase char(8) Null, "); 
 // /**案例类型流水号*/ 
 strCreateTabCode.Append(" IdCaseType char(4) Null, "); 
 // /**是否正确*/ 
 strCreateTabCode.Append(" IsRight bit Null, "); 
 // /**是否掌握*/ 
 strCreateTabCode.Append(" IsMaster bit not Null, "); 
 // /**掌握程度*/ 
 strCreateTabCode.Append(" MasterDegree numeric(20,2) not Null, "); 
 // /**打分者*/ 
 strCreateTabCode.Append(" MarkerId varchar(20) Null, "); 
 // /**批改时间*/ 
 strCreateTabCode.Append(" MarkTime varchar(14) Null, "); 
 // /**是否分析*/ 
 strCreateTabCode.Append(" IsAnalysis bit not Null, "); 
 // /**课程Id*/ 
 strCreateTabCode.Append(" CourseId char(8) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) not Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) not Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**知识点名称*/ 
 strCreateTabCode.Append(" KnowledgeName varchar(100) not Null, "); 
 // /**学习模式名*/ 
 strCreateTabCode.Append(" LearnModeName varchar(30) not Null, "); 
 // /**案例类型名称*/ 
 strCreateTabCode.Append(" CaseTypeName varchar(50) not Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 知识点学习情况(KnowledgeLearnDetail)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4KnowledgeLearnDetail : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strCourseId)
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
clsKnowledgeLearnDetailBL.ReFreshThisCache(strCourseId);
}
}

}