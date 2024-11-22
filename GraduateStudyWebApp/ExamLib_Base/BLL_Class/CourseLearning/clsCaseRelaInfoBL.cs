
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCaseRelaInfoBL
 表名:CaseRelaInfo(01120389)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:07:54
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习(CourseLearning)
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
public static class  clsCaseRelaInfoBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsCaseRelaInfoEN GetObj(this K_IdCaseRelaInfo_CaseRelaInfo myKey)
{
clsCaseRelaInfoEN objCaseRelaInfoEN = clsCaseRelaInfoBL.CaseRelaInfoDA.GetObjByIdCaseRelaInfo(myKey.Value);
return objCaseRelaInfoEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCaseRelaInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCaseRelaInfoEN objCaseRelaInfoEN)
{
if (CheckUniqueness(objCaseRelaInfoEN) == false)
{
var strMsg = string.Format("记录已经存在!案例Id1 = [{0}],案例Id2 = [{1}],案例相关信息类型流水号 = [{2}]的数据已经存在!(in clsCaseRelaInfoBL.AddNewRecord)", objCaseRelaInfoEN.CaseId1,objCaseRelaInfoEN.CaseId2,objCaseRelaInfoEN.IdCaseRelaInfoType);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsCaseRelaInfoBL.CaseRelaInfoDA.AddNewRecordBySQL2(objCaseRelaInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseRelaInfoBL.ReFreshCache();

if (clsCaseRelaInfoBL.relatedActions != null)
{
clsCaseRelaInfoBL.relatedActions.UpdRelaTabDate(objCaseRelaInfoEN.IdCaseRelaInfo, objCaseRelaInfoEN.UpdUserId);
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
public static bool AddRecordEx(this clsCaseRelaInfoEN objCaseRelaInfoEN)
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
objCaseRelaInfoEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objCaseRelaInfoEN.CheckUniqueness() == false)
{
strMsg = string.Format("(案例Id1(CaseId1)=[{0}],案例Id2(CaseId2)=[{1}],案例相关信息类型流水号(IdCaseRelaInfoType)=[{2}])已经存在,不能重复!", objCaseRelaInfoEN.CaseId1, objCaseRelaInfoEN.CaseId2, objCaseRelaInfoEN.IdCaseRelaInfoType);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objCaseRelaInfoEN.AddNewRecord();
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
 /// <param name = "objCaseRelaInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsCaseRelaInfoEN objCaseRelaInfoEN)
{
if (CheckUniqueness(objCaseRelaInfoEN) == false)
{
var strMsg = string.Format("记录已经存在!案例Id1 = [{0}],案例Id2 = [{1}],案例相关信息类型流水号 = [{2}]的数据已经存在!(in clsCaseRelaInfoBL.AddNewRecordWithReturnKey)", objCaseRelaInfoEN.CaseId1,objCaseRelaInfoEN.CaseId2,objCaseRelaInfoEN.IdCaseRelaInfoType);
throw new Exception(strMsg);
}
try
{
string strKey = clsCaseRelaInfoBL.CaseRelaInfoDA.AddNewRecordBySQL2WithReturnKey(objCaseRelaInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseRelaInfoBL.ReFreshCache();

if (clsCaseRelaInfoBL.relatedActions != null)
{
clsCaseRelaInfoBL.relatedActions.UpdRelaTabDate(objCaseRelaInfoEN.IdCaseRelaInfo, objCaseRelaInfoEN.UpdUserId);
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
 /// <param name = "objCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseRelaInfoEN SetIdCaseRelaInfo(this clsCaseRelaInfoEN objCaseRelaInfoEN, long lngIdCaseRelaInfo, string strComparisonOp="")
	{
objCaseRelaInfoEN.IdCaseRelaInfo = lngIdCaseRelaInfo; //案例相关信息流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(conCaseRelaInfo.IdCaseRelaInfo) == false)
{
objCaseRelaInfoEN.dicFldComparisonOp.Add(conCaseRelaInfo.IdCaseRelaInfo, strComparisonOp);
}
else
{
objCaseRelaInfoEN.dicFldComparisonOp[conCaseRelaInfo.IdCaseRelaInfo] = strComparisonOp;
}
}
return objCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseRelaInfoEN SetFuncModuleId1(this clsCaseRelaInfoEN objCaseRelaInfoEN, string strFuncModuleId1, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId1, conCaseRelaInfo.FuncModuleId1);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId1, 4, conCaseRelaInfo.FuncModuleId1);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId1, 4, conCaseRelaInfo.FuncModuleId1);
}
objCaseRelaInfoEN.FuncModuleId1 = strFuncModuleId1; //功能模块Id1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(conCaseRelaInfo.FuncModuleId1) == false)
{
objCaseRelaInfoEN.dicFldComparisonOp.Add(conCaseRelaInfo.FuncModuleId1, strComparisonOp);
}
else
{
objCaseRelaInfoEN.dicFldComparisonOp[conCaseRelaInfo.FuncModuleId1] = strComparisonOp;
}
}
return objCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseRelaInfoEN SetCaseId1(this clsCaseRelaInfoEN objCaseRelaInfoEN, string strCaseId1, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaseId1, conCaseRelaInfo.CaseId1);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseId1, 8, conCaseRelaInfo.CaseId1);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCaseId1, 8, conCaseRelaInfo.CaseId1);
}
objCaseRelaInfoEN.CaseId1 = strCaseId1; //案例Id1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(conCaseRelaInfo.CaseId1) == false)
{
objCaseRelaInfoEN.dicFldComparisonOp.Add(conCaseRelaInfo.CaseId1, strComparisonOp);
}
else
{
objCaseRelaInfoEN.dicFldComparisonOp[conCaseRelaInfo.CaseId1] = strComparisonOp;
}
}
return objCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseRelaInfoEN SetCaseName1(this clsCaseRelaInfoEN objCaseRelaInfoEN, string strCaseName1, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaseName1, conCaseRelaInfo.CaseName1);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseName1, 100, conCaseRelaInfo.CaseName1);
}
objCaseRelaInfoEN.CaseName1 = strCaseName1; //案例名称1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(conCaseRelaInfo.CaseName1) == false)
{
objCaseRelaInfoEN.dicFldComparisonOp.Add(conCaseRelaInfo.CaseName1, strComparisonOp);
}
else
{
objCaseRelaInfoEN.dicFldComparisonOp[conCaseRelaInfo.CaseName1] = strComparisonOp;
}
}
return objCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseRelaInfoEN SetOwnerId1(this clsCaseRelaInfoEN objCaseRelaInfoEN, string strOwnerId1, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerId1, 20, conCaseRelaInfo.OwnerId1);
}
objCaseRelaInfoEN.OwnerId1 = strOwnerId1; //拥有者Id1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(conCaseRelaInfo.OwnerId1) == false)
{
objCaseRelaInfoEN.dicFldComparisonOp.Add(conCaseRelaInfo.OwnerId1, strComparisonOp);
}
else
{
objCaseRelaInfoEN.dicFldComparisonOp[conCaseRelaInfo.OwnerId1] = strComparisonOp;
}
}
return objCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseRelaInfoEN SetFuncModuleId2(this clsCaseRelaInfoEN objCaseRelaInfoEN, string strFuncModuleId2, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId2, conCaseRelaInfo.FuncModuleId2);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId2, 4, conCaseRelaInfo.FuncModuleId2);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId2, 4, conCaseRelaInfo.FuncModuleId2);
}
objCaseRelaInfoEN.FuncModuleId2 = strFuncModuleId2; //功能模块Id2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(conCaseRelaInfo.FuncModuleId2) == false)
{
objCaseRelaInfoEN.dicFldComparisonOp.Add(conCaseRelaInfo.FuncModuleId2, strComparisonOp);
}
else
{
objCaseRelaInfoEN.dicFldComparisonOp[conCaseRelaInfo.FuncModuleId2] = strComparisonOp;
}
}
return objCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseRelaInfoEN SetCaseId2(this clsCaseRelaInfoEN objCaseRelaInfoEN, string strCaseId2, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaseId2, conCaseRelaInfo.CaseId2);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseId2, 8, conCaseRelaInfo.CaseId2);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCaseId2, 8, conCaseRelaInfo.CaseId2);
}
objCaseRelaInfoEN.CaseId2 = strCaseId2; //案例Id2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(conCaseRelaInfo.CaseId2) == false)
{
objCaseRelaInfoEN.dicFldComparisonOp.Add(conCaseRelaInfo.CaseId2, strComparisonOp);
}
else
{
objCaseRelaInfoEN.dicFldComparisonOp[conCaseRelaInfo.CaseId2] = strComparisonOp;
}
}
return objCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseRelaInfoEN SetCaseName2(this clsCaseRelaInfoEN objCaseRelaInfoEN, string strCaseName2, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaseName2, conCaseRelaInfo.CaseName2);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseName2, 100, conCaseRelaInfo.CaseName2);
}
objCaseRelaInfoEN.CaseName2 = strCaseName2; //案例名称2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(conCaseRelaInfo.CaseName2) == false)
{
objCaseRelaInfoEN.dicFldComparisonOp.Add(conCaseRelaInfo.CaseName2, strComparisonOp);
}
else
{
objCaseRelaInfoEN.dicFldComparisonOp[conCaseRelaInfo.CaseName2] = strComparisonOp;
}
}
return objCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseRelaInfoEN SetOwnerId2(this clsCaseRelaInfoEN objCaseRelaInfoEN, string strOwnerId2, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerId2, 20, conCaseRelaInfo.OwnerId2);
}
objCaseRelaInfoEN.OwnerId2 = strOwnerId2; //拥有者Id2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(conCaseRelaInfo.OwnerId2) == false)
{
objCaseRelaInfoEN.dicFldComparisonOp.Add(conCaseRelaInfo.OwnerId2, strComparisonOp);
}
else
{
objCaseRelaInfoEN.dicFldComparisonOp[conCaseRelaInfo.OwnerId2] = strComparisonOp;
}
}
return objCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseRelaInfoEN SetRelationsDegree(this clsCaseRelaInfoEN objCaseRelaInfoEN, int intRelationsDegree, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intRelationsDegree, conCaseRelaInfo.RelationsDegree);
objCaseRelaInfoEN.RelationsDegree = intRelationsDegree; //关系度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(conCaseRelaInfo.RelationsDegree) == false)
{
objCaseRelaInfoEN.dicFldComparisonOp.Add(conCaseRelaInfo.RelationsDegree, strComparisonOp);
}
else
{
objCaseRelaInfoEN.dicFldComparisonOp[conCaseRelaInfo.RelationsDegree] = strComparisonOp;
}
}
return objCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseRelaInfoEN SetIdCaseRelaInfoType(this clsCaseRelaInfoEN objCaseRelaInfoEN, string strIdCaseRelaInfoType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdCaseRelaInfoType, conCaseRelaInfo.IdCaseRelaInfoType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCaseRelaInfoType, 4, conCaseRelaInfo.IdCaseRelaInfoType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCaseRelaInfoType, 4, conCaseRelaInfo.IdCaseRelaInfoType);
}
objCaseRelaInfoEN.IdCaseRelaInfoType = strIdCaseRelaInfoType; //案例相关信息类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(conCaseRelaInfo.IdCaseRelaInfoType) == false)
{
objCaseRelaInfoEN.dicFldComparisonOp.Add(conCaseRelaInfo.IdCaseRelaInfoType, strComparisonOp);
}
else
{
objCaseRelaInfoEN.dicFldComparisonOp[conCaseRelaInfo.IdCaseRelaInfoType] = strComparisonOp;
}
}
return objCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseRelaInfoEN SetBrowseCount(this clsCaseRelaInfoEN objCaseRelaInfoEN, int intBrowseCount, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intBrowseCount, conCaseRelaInfo.BrowseCount);
objCaseRelaInfoEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(conCaseRelaInfo.BrowseCount) == false)
{
objCaseRelaInfoEN.dicFldComparisonOp.Add(conCaseRelaInfo.BrowseCount, strComparisonOp);
}
else
{
objCaseRelaInfoEN.dicFldComparisonOp[conCaseRelaInfo.BrowseCount] = strComparisonOp;
}
}
return objCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseRelaInfoEN SetUpdDate(this clsCaseRelaInfoEN objCaseRelaInfoEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conCaseRelaInfo.UpdDate);
}
objCaseRelaInfoEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(conCaseRelaInfo.UpdDate) == false)
{
objCaseRelaInfoEN.dicFldComparisonOp.Add(conCaseRelaInfo.UpdDate, strComparisonOp);
}
else
{
objCaseRelaInfoEN.dicFldComparisonOp[conCaseRelaInfo.UpdDate] = strComparisonOp;
}
}
return objCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseRelaInfoEN SetUpdUserId(this clsCaseRelaInfoEN objCaseRelaInfoEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conCaseRelaInfo.UpdUserId);
}
objCaseRelaInfoEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(conCaseRelaInfo.UpdUserId) == false)
{
objCaseRelaInfoEN.dicFldComparisonOp.Add(conCaseRelaInfo.UpdUserId, strComparisonOp);
}
else
{
objCaseRelaInfoEN.dicFldComparisonOp[conCaseRelaInfo.UpdUserId] = strComparisonOp;
}
}
return objCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseRelaInfoEN SetMemo(this clsCaseRelaInfoEN objCaseRelaInfoEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCaseRelaInfo.Memo);
}
objCaseRelaInfoEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(conCaseRelaInfo.Memo) == false)
{
objCaseRelaInfoEN.dicFldComparisonOp.Add(conCaseRelaInfo.Memo, strComparisonOp);
}
else
{
objCaseRelaInfoEN.dicFldComparisonOp[conCaseRelaInfo.Memo] = strComparisonOp;
}
}
return objCaseRelaInfoEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objCaseRelaInfoEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsCaseRelaInfoEN objCaseRelaInfoEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objCaseRelaInfoEN.CheckPropertyNew();
clsCaseRelaInfoEN objCaseRelaInfoCond = new clsCaseRelaInfoEN();
string strCondition = objCaseRelaInfoCond
.SetIdCaseRelaInfo(objCaseRelaInfoEN.IdCaseRelaInfo, "<>")
.SetCaseId1(objCaseRelaInfoEN.CaseId1, "=")
.SetCaseId2(objCaseRelaInfoEN.CaseId2, "=")
.SetIdCaseRelaInfoType(objCaseRelaInfoEN.IdCaseRelaInfoType, "=")
.GetCombineCondition();
objCaseRelaInfoEN._IsCheckProperty = true;
bool bolIsExist = clsCaseRelaInfoBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(CaseId1_CaseId2_id_CaseRelaInfoType)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objCaseRelaInfoEN.Update();
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
 /// <param name = "objCaseRelaInfo">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsCaseRelaInfoEN objCaseRelaInfo)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsCaseRelaInfoEN objCaseRelaInfoCond = new clsCaseRelaInfoEN();
string strCondition = objCaseRelaInfoCond
.SetCaseId1(objCaseRelaInfo.CaseId1, "=")
.SetCaseId2(objCaseRelaInfo.CaseId2, "=")
.SetIdCaseRelaInfoType(objCaseRelaInfo.IdCaseRelaInfoType, "=")
.GetCombineCondition();
objCaseRelaInfo._IsCheckProperty = true;
bool bolIsExist = clsCaseRelaInfoBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objCaseRelaInfo.IdCaseRelaInfo = clsCaseRelaInfoBL.GetFirstID_S(strCondition);
objCaseRelaInfo.UpdateWithCondition(strCondition);
}
else
{
objCaseRelaInfo.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objCaseRelaInfoEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCaseRelaInfoEN objCaseRelaInfoEN)
{
 if (objCaseRelaInfoEN.IdCaseRelaInfo == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCaseRelaInfoBL.CaseRelaInfoDA.UpdateBySql2(objCaseRelaInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseRelaInfoBL.ReFreshCache();

if (clsCaseRelaInfoBL.relatedActions != null)
{
clsCaseRelaInfoBL.relatedActions.UpdRelaTabDate(objCaseRelaInfoEN.IdCaseRelaInfo, objCaseRelaInfoEN.UpdUserId);
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
 /// <param name = "objCaseRelaInfoEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCaseRelaInfoEN objCaseRelaInfoEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objCaseRelaInfoEN.IdCaseRelaInfo == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCaseRelaInfoBL.CaseRelaInfoDA.UpdateBySql2(objCaseRelaInfoEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseRelaInfoBL.ReFreshCache();

if (clsCaseRelaInfoBL.relatedActions != null)
{
clsCaseRelaInfoBL.relatedActions.UpdRelaTabDate(objCaseRelaInfoEN.IdCaseRelaInfo, objCaseRelaInfoEN.UpdUserId);
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
 /// <param name = "objCaseRelaInfoEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCaseRelaInfoEN objCaseRelaInfoEN, string strWhereCond)
{
try
{
bool bolResult = clsCaseRelaInfoBL.CaseRelaInfoDA.UpdateBySqlWithCondition(objCaseRelaInfoEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseRelaInfoBL.ReFreshCache();

if (clsCaseRelaInfoBL.relatedActions != null)
{
clsCaseRelaInfoBL.relatedActions.UpdRelaTabDate(objCaseRelaInfoEN.IdCaseRelaInfo, objCaseRelaInfoEN.UpdUserId);
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
 /// <param name = "objCaseRelaInfoEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCaseRelaInfoEN objCaseRelaInfoEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsCaseRelaInfoBL.CaseRelaInfoDA.UpdateBySqlWithConditionTransaction(objCaseRelaInfoEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseRelaInfoBL.ReFreshCache();

if (clsCaseRelaInfoBL.relatedActions != null)
{
clsCaseRelaInfoBL.relatedActions.UpdRelaTabDate(objCaseRelaInfoEN.IdCaseRelaInfo, objCaseRelaInfoEN.UpdUserId);
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
 /// <param name = "lngIdCaseRelaInfo">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsCaseRelaInfoEN objCaseRelaInfoEN)
{
try
{
int intRecNum = clsCaseRelaInfoBL.CaseRelaInfoDA.DelRecord(objCaseRelaInfoEN.IdCaseRelaInfo);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseRelaInfoBL.ReFreshCache();

if (clsCaseRelaInfoBL.relatedActions != null)
{
clsCaseRelaInfoBL.relatedActions.UpdRelaTabDate(objCaseRelaInfoEN.IdCaseRelaInfo, objCaseRelaInfoEN.UpdUserId);
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
 /// <param name = "objCaseRelaInfoENS">源对象</param>
 /// <param name = "objCaseRelaInfoENT">目标对象</param>
 public static void CopyTo(this clsCaseRelaInfoEN objCaseRelaInfoENS, clsCaseRelaInfoEN objCaseRelaInfoENT)
{
try
{
objCaseRelaInfoENT.IdCaseRelaInfo = objCaseRelaInfoENS.IdCaseRelaInfo; //案例相关信息流水号
objCaseRelaInfoENT.FuncModuleId1 = objCaseRelaInfoENS.FuncModuleId1; //功能模块Id1
objCaseRelaInfoENT.CaseId1 = objCaseRelaInfoENS.CaseId1; //案例Id1
objCaseRelaInfoENT.CaseName1 = objCaseRelaInfoENS.CaseName1; //案例名称1
objCaseRelaInfoENT.OwnerId1 = objCaseRelaInfoENS.OwnerId1; //拥有者Id1
objCaseRelaInfoENT.FuncModuleId2 = objCaseRelaInfoENS.FuncModuleId2; //功能模块Id2
objCaseRelaInfoENT.CaseId2 = objCaseRelaInfoENS.CaseId2; //案例Id2
objCaseRelaInfoENT.CaseName2 = objCaseRelaInfoENS.CaseName2; //案例名称2
objCaseRelaInfoENT.OwnerId2 = objCaseRelaInfoENS.OwnerId2; //拥有者Id2
objCaseRelaInfoENT.RelationsDegree = objCaseRelaInfoENS.RelationsDegree; //关系度
objCaseRelaInfoENT.IdCaseRelaInfoType = objCaseRelaInfoENS.IdCaseRelaInfoType; //案例相关信息类型流水号
objCaseRelaInfoENT.BrowseCount = objCaseRelaInfoENS.BrowseCount; //浏览次数
objCaseRelaInfoENT.UpdDate = objCaseRelaInfoENS.UpdDate; //修改日期
objCaseRelaInfoENT.UpdUserId = objCaseRelaInfoENS.UpdUserId; //修改用户Id
objCaseRelaInfoENT.Memo = objCaseRelaInfoENS.Memo; //备注
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
 /// <param name = "objCaseRelaInfoENS">源对象</param>
 /// <returns>目标对象=>clsCaseRelaInfoEN:objCaseRelaInfoENT</returns>
 public static clsCaseRelaInfoEN CopyTo(this clsCaseRelaInfoEN objCaseRelaInfoENS)
{
try
{
 clsCaseRelaInfoEN objCaseRelaInfoENT = new clsCaseRelaInfoEN()
{
IdCaseRelaInfo = objCaseRelaInfoENS.IdCaseRelaInfo, //案例相关信息流水号
FuncModuleId1 = objCaseRelaInfoENS.FuncModuleId1, //功能模块Id1
CaseId1 = objCaseRelaInfoENS.CaseId1, //案例Id1
CaseName1 = objCaseRelaInfoENS.CaseName1, //案例名称1
OwnerId1 = objCaseRelaInfoENS.OwnerId1, //拥有者Id1
FuncModuleId2 = objCaseRelaInfoENS.FuncModuleId2, //功能模块Id2
CaseId2 = objCaseRelaInfoENS.CaseId2, //案例Id2
CaseName2 = objCaseRelaInfoENS.CaseName2, //案例名称2
OwnerId2 = objCaseRelaInfoENS.OwnerId2, //拥有者Id2
RelationsDegree = objCaseRelaInfoENS.RelationsDegree, //关系度
IdCaseRelaInfoType = objCaseRelaInfoENS.IdCaseRelaInfoType, //案例相关信息类型流水号
BrowseCount = objCaseRelaInfoENS.BrowseCount, //浏览次数
UpdDate = objCaseRelaInfoENS.UpdDate, //修改日期
UpdUserId = objCaseRelaInfoENS.UpdUserId, //修改用户Id
Memo = objCaseRelaInfoENS.Memo, //备注
};
 return objCaseRelaInfoENT;
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
public static void CheckPropertyNew(this clsCaseRelaInfoEN objCaseRelaInfoEN)
{
 clsCaseRelaInfoBL.CaseRelaInfoDA.CheckPropertyNew(objCaseRelaInfoEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsCaseRelaInfoEN objCaseRelaInfoEN)
{
 clsCaseRelaInfoBL.CaseRelaInfoDA.CheckProperty4Condition(objCaseRelaInfoEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCaseRelaInfoEN objCaseRelaInfoCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCaseRelaInfoCond.IsUpdated(conCaseRelaInfo.IdCaseRelaInfo) == true)
{
string strComparisonOpIdCaseRelaInfo = objCaseRelaInfoCond.dicFldComparisonOp[conCaseRelaInfo.IdCaseRelaInfo];
strWhereCond += string.Format(" And {0} {2} {1}", conCaseRelaInfo.IdCaseRelaInfo, objCaseRelaInfoCond.IdCaseRelaInfo, strComparisonOpIdCaseRelaInfo);
}
if (objCaseRelaInfoCond.IsUpdated(conCaseRelaInfo.FuncModuleId1) == true)
{
string strComparisonOpFuncModuleId1 = objCaseRelaInfoCond.dicFldComparisonOp[conCaseRelaInfo.FuncModuleId1];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseRelaInfo.FuncModuleId1, objCaseRelaInfoCond.FuncModuleId1, strComparisonOpFuncModuleId1);
}
if (objCaseRelaInfoCond.IsUpdated(conCaseRelaInfo.CaseId1) == true)
{
string strComparisonOpCaseId1 = objCaseRelaInfoCond.dicFldComparisonOp[conCaseRelaInfo.CaseId1];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseRelaInfo.CaseId1, objCaseRelaInfoCond.CaseId1, strComparisonOpCaseId1);
}
if (objCaseRelaInfoCond.IsUpdated(conCaseRelaInfo.CaseName1) == true)
{
string strComparisonOpCaseName1 = objCaseRelaInfoCond.dicFldComparisonOp[conCaseRelaInfo.CaseName1];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseRelaInfo.CaseName1, objCaseRelaInfoCond.CaseName1, strComparisonOpCaseName1);
}
if (objCaseRelaInfoCond.IsUpdated(conCaseRelaInfo.OwnerId1) == true)
{
string strComparisonOpOwnerId1 = objCaseRelaInfoCond.dicFldComparisonOp[conCaseRelaInfo.OwnerId1];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseRelaInfo.OwnerId1, objCaseRelaInfoCond.OwnerId1, strComparisonOpOwnerId1);
}
if (objCaseRelaInfoCond.IsUpdated(conCaseRelaInfo.FuncModuleId2) == true)
{
string strComparisonOpFuncModuleId2 = objCaseRelaInfoCond.dicFldComparisonOp[conCaseRelaInfo.FuncModuleId2];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseRelaInfo.FuncModuleId2, objCaseRelaInfoCond.FuncModuleId2, strComparisonOpFuncModuleId2);
}
if (objCaseRelaInfoCond.IsUpdated(conCaseRelaInfo.CaseId2) == true)
{
string strComparisonOpCaseId2 = objCaseRelaInfoCond.dicFldComparisonOp[conCaseRelaInfo.CaseId2];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseRelaInfo.CaseId2, objCaseRelaInfoCond.CaseId2, strComparisonOpCaseId2);
}
if (objCaseRelaInfoCond.IsUpdated(conCaseRelaInfo.CaseName2) == true)
{
string strComparisonOpCaseName2 = objCaseRelaInfoCond.dicFldComparisonOp[conCaseRelaInfo.CaseName2];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseRelaInfo.CaseName2, objCaseRelaInfoCond.CaseName2, strComparisonOpCaseName2);
}
if (objCaseRelaInfoCond.IsUpdated(conCaseRelaInfo.OwnerId2) == true)
{
string strComparisonOpOwnerId2 = objCaseRelaInfoCond.dicFldComparisonOp[conCaseRelaInfo.OwnerId2];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseRelaInfo.OwnerId2, objCaseRelaInfoCond.OwnerId2, strComparisonOpOwnerId2);
}
if (objCaseRelaInfoCond.IsUpdated(conCaseRelaInfo.RelationsDegree) == true)
{
string strComparisonOpRelationsDegree = objCaseRelaInfoCond.dicFldComparisonOp[conCaseRelaInfo.RelationsDegree];
strWhereCond += string.Format(" And {0} {2} {1}", conCaseRelaInfo.RelationsDegree, objCaseRelaInfoCond.RelationsDegree, strComparisonOpRelationsDegree);
}
if (objCaseRelaInfoCond.IsUpdated(conCaseRelaInfo.IdCaseRelaInfoType) == true)
{
string strComparisonOpIdCaseRelaInfoType = objCaseRelaInfoCond.dicFldComparisonOp[conCaseRelaInfo.IdCaseRelaInfoType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseRelaInfo.IdCaseRelaInfoType, objCaseRelaInfoCond.IdCaseRelaInfoType, strComparisonOpIdCaseRelaInfoType);
}
if (objCaseRelaInfoCond.IsUpdated(conCaseRelaInfo.BrowseCount) == true)
{
string strComparisonOpBrowseCount = objCaseRelaInfoCond.dicFldComparisonOp[conCaseRelaInfo.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conCaseRelaInfo.BrowseCount, objCaseRelaInfoCond.BrowseCount, strComparisonOpBrowseCount);
}
if (objCaseRelaInfoCond.IsUpdated(conCaseRelaInfo.UpdDate) == true)
{
string strComparisonOpUpdDate = objCaseRelaInfoCond.dicFldComparisonOp[conCaseRelaInfo.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseRelaInfo.UpdDate, objCaseRelaInfoCond.UpdDate, strComparisonOpUpdDate);
}
if (objCaseRelaInfoCond.IsUpdated(conCaseRelaInfo.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objCaseRelaInfoCond.dicFldComparisonOp[conCaseRelaInfo.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseRelaInfo.UpdUserId, objCaseRelaInfoCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objCaseRelaInfoCond.IsUpdated(conCaseRelaInfo.Memo) == true)
{
string strComparisonOpMemo = objCaseRelaInfoCond.dicFldComparisonOp[conCaseRelaInfo.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseRelaInfo.Memo, objCaseRelaInfoCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--CaseRelaInfo(案例相关信息), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:CaseId1_CaseId2_id_CaseRelaInfoType
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objCaseRelaInfoEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsCaseRelaInfoEN objCaseRelaInfoEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objCaseRelaInfoEN == null) return true;
if (objCaseRelaInfoEN.IdCaseRelaInfo == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CaseId1 = '{0}'", objCaseRelaInfoEN.CaseId1);
 sbCondition.AppendFormat(" and CaseId2 = '{0}'", objCaseRelaInfoEN.CaseId2);
 sbCondition.AppendFormat(" and IdCaseRelaInfoType = '{0}'", objCaseRelaInfoEN.IdCaseRelaInfoType);
if (clsCaseRelaInfoBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("IdCaseRelaInfo !=  {0}", objCaseRelaInfoEN.IdCaseRelaInfo);
 sbCondition.AppendFormat(" and CaseId1 = '{0}'", objCaseRelaInfoEN.CaseId1);
 sbCondition.AppendFormat(" and CaseId2 = '{0}'", objCaseRelaInfoEN.CaseId2);
 sbCondition.AppendFormat(" and IdCaseRelaInfoType = '{0}'", objCaseRelaInfoEN.IdCaseRelaInfoType);
if (clsCaseRelaInfoBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--CaseRelaInfo(案例相关信息), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:CaseId1_CaseId2_id_CaseRelaInfoType
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCaseRelaInfoEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsCaseRelaInfoEN objCaseRelaInfoEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCaseRelaInfoEN == null) return "";
if (objCaseRelaInfoEN.IdCaseRelaInfo == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CaseId1 = '{0}'", objCaseRelaInfoEN.CaseId1);
 sbCondition.AppendFormat(" and CaseId2 = '{0}'", objCaseRelaInfoEN.CaseId2);
 sbCondition.AppendFormat(" and IdCaseRelaInfoType = '{0}'", objCaseRelaInfoEN.IdCaseRelaInfoType);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("IdCaseRelaInfo !=  {0}", objCaseRelaInfoEN.IdCaseRelaInfo);
 sbCondition.AppendFormat(" and CaseId1 = '{0}'", objCaseRelaInfoEN.CaseId1);
 sbCondition.AppendFormat(" and CaseId2 = '{0}'", objCaseRelaInfoEN.CaseId2);
 sbCondition.AppendFormat(" and IdCaseRelaInfoType = '{0}'", objCaseRelaInfoEN.IdCaseRelaInfoType);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_CaseRelaInfo
{
public virtual bool UpdRelaTabDate(long lngIdCaseRelaInfo, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 案例相关信息(CaseRelaInfo)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsCaseRelaInfoBL
{
public static RelatedActions_CaseRelaInfo relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsCaseRelaInfoDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsCaseRelaInfoDA CaseRelaInfoDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsCaseRelaInfoDA();
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
 public clsCaseRelaInfoBL()
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
if (string.IsNullOrEmpty(clsCaseRelaInfoEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCaseRelaInfoEN._ConnectString);
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
public static DataTable GetDataTable_CaseRelaInfo(string strWhereCond)
{
DataTable objDT;
try
{
objDT = CaseRelaInfoDA.GetDataTable_CaseRelaInfo(strWhereCond);
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
objDT = CaseRelaInfoDA.GetDataTable(strWhereCond);
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
objDT = CaseRelaInfoDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = CaseRelaInfoDA.GetDataTable(strWhereCond, strTabName);
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
objDT = CaseRelaInfoDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = CaseRelaInfoDA.GetDataTable_Top(objTopPara);
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
objDT = CaseRelaInfoDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = CaseRelaInfoDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = CaseRelaInfoDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdCaseRelaInfoLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsCaseRelaInfoEN> GetObjLstByIdCaseRelaInfoLst(List<long> arrIdCaseRelaInfoLst)
{
List<clsCaseRelaInfoEN> arrObjLst = new List<clsCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdCaseRelaInfoLst);
 string strWhereCond = string.Format("IdCaseRelaInfo in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseRelaInfoEN objCaseRelaInfoEN = new clsCaseRelaInfoEN();
try
{
objCaseRelaInfoEN.IdCaseRelaInfo = Int32.Parse(objRow[conCaseRelaInfo.IdCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objCaseRelaInfoEN.FuncModuleId1 = objRow[conCaseRelaInfo.FuncModuleId1].ToString().Trim(); //功能模块Id1
objCaseRelaInfoEN.CaseId1 = objRow[conCaseRelaInfo.CaseId1].ToString().Trim(); //案例Id1
objCaseRelaInfoEN.CaseName1 = objRow[conCaseRelaInfo.CaseName1].ToString().Trim(); //案例名称1
objCaseRelaInfoEN.OwnerId1 = objRow[conCaseRelaInfo.OwnerId1] == DBNull.Value ? null : objRow[conCaseRelaInfo.OwnerId1].ToString().Trim(); //拥有者Id1
objCaseRelaInfoEN.FuncModuleId2 = objRow[conCaseRelaInfo.FuncModuleId2].ToString().Trim(); //功能模块Id2
objCaseRelaInfoEN.CaseId2 = objRow[conCaseRelaInfo.CaseId2].ToString().Trim(); //案例Id2
objCaseRelaInfoEN.CaseName2 = objRow[conCaseRelaInfo.CaseName2].ToString().Trim(); //案例名称2
objCaseRelaInfoEN.OwnerId2 = objRow[conCaseRelaInfo.OwnerId2] == DBNull.Value ? null : objRow[conCaseRelaInfo.OwnerId2].ToString().Trim(); //拥有者Id2
objCaseRelaInfoEN.RelationsDegree = Int32.Parse(objRow[conCaseRelaInfo.RelationsDegree].ToString().Trim()); //关系度
objCaseRelaInfoEN.IdCaseRelaInfoType = objRow[conCaseRelaInfo.IdCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号
objCaseRelaInfoEN.BrowseCount = Int32.Parse(objRow[conCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objCaseRelaInfoEN.UpdDate = objRow[conCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[conCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objCaseRelaInfoEN.UpdUserId = objRow[conCaseRelaInfo.UpdUserId] == DBNull.Value ? null : objRow[conCaseRelaInfo.UpdUserId].ToString().Trim(); //修改用户Id
objCaseRelaInfoEN.Memo = objRow[conCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[conCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseRelaInfoEN.IdCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseRelaInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdCaseRelaInfoLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsCaseRelaInfoEN> GetObjLstByIdCaseRelaInfoLstCache(List<long> arrIdCaseRelaInfoLst)
{
string strKey = string.Format("{0}", clsCaseRelaInfoEN._CurrTabName);
List<clsCaseRelaInfoEN> arrCaseRelaInfoObjLstCache = GetObjLstCache();
IEnumerable <clsCaseRelaInfoEN> arrCaseRelaInfoObjLst_Sel =
arrCaseRelaInfoObjLstCache
.Where(x => arrIdCaseRelaInfoLst.Contains(x.IdCaseRelaInfo));
return arrCaseRelaInfoObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCaseRelaInfoEN> GetObjLst(string strWhereCond)
{
List<clsCaseRelaInfoEN> arrObjLst = new List<clsCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseRelaInfoEN objCaseRelaInfoEN = new clsCaseRelaInfoEN();
try
{
objCaseRelaInfoEN.IdCaseRelaInfo = Int32.Parse(objRow[conCaseRelaInfo.IdCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objCaseRelaInfoEN.FuncModuleId1 = objRow[conCaseRelaInfo.FuncModuleId1].ToString().Trim(); //功能模块Id1
objCaseRelaInfoEN.CaseId1 = objRow[conCaseRelaInfo.CaseId1].ToString().Trim(); //案例Id1
objCaseRelaInfoEN.CaseName1 = objRow[conCaseRelaInfo.CaseName1].ToString().Trim(); //案例名称1
objCaseRelaInfoEN.OwnerId1 = objRow[conCaseRelaInfo.OwnerId1] == DBNull.Value ? null : objRow[conCaseRelaInfo.OwnerId1].ToString().Trim(); //拥有者Id1
objCaseRelaInfoEN.FuncModuleId2 = objRow[conCaseRelaInfo.FuncModuleId2].ToString().Trim(); //功能模块Id2
objCaseRelaInfoEN.CaseId2 = objRow[conCaseRelaInfo.CaseId2].ToString().Trim(); //案例Id2
objCaseRelaInfoEN.CaseName2 = objRow[conCaseRelaInfo.CaseName2].ToString().Trim(); //案例名称2
objCaseRelaInfoEN.OwnerId2 = objRow[conCaseRelaInfo.OwnerId2] == DBNull.Value ? null : objRow[conCaseRelaInfo.OwnerId2].ToString().Trim(); //拥有者Id2
objCaseRelaInfoEN.RelationsDegree = Int32.Parse(objRow[conCaseRelaInfo.RelationsDegree].ToString().Trim()); //关系度
objCaseRelaInfoEN.IdCaseRelaInfoType = objRow[conCaseRelaInfo.IdCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号
objCaseRelaInfoEN.BrowseCount = Int32.Parse(objRow[conCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objCaseRelaInfoEN.UpdDate = objRow[conCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[conCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objCaseRelaInfoEN.UpdUserId = objRow[conCaseRelaInfo.UpdUserId] == DBNull.Value ? null : objRow[conCaseRelaInfo.UpdUserId].ToString().Trim(); //修改用户Id
objCaseRelaInfoEN.Memo = objRow[conCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[conCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseRelaInfoEN.IdCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseRelaInfoEN);
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
public static List<clsCaseRelaInfoEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsCaseRelaInfoEN> arrObjLst = new List<clsCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseRelaInfoEN objCaseRelaInfoEN = new clsCaseRelaInfoEN();
try
{
objCaseRelaInfoEN.IdCaseRelaInfo = Int32.Parse(objRow[conCaseRelaInfo.IdCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objCaseRelaInfoEN.FuncModuleId1 = objRow[conCaseRelaInfo.FuncModuleId1].ToString().Trim(); //功能模块Id1
objCaseRelaInfoEN.CaseId1 = objRow[conCaseRelaInfo.CaseId1].ToString().Trim(); //案例Id1
objCaseRelaInfoEN.CaseName1 = objRow[conCaseRelaInfo.CaseName1].ToString().Trim(); //案例名称1
objCaseRelaInfoEN.OwnerId1 = objRow[conCaseRelaInfo.OwnerId1] == DBNull.Value ? null : objRow[conCaseRelaInfo.OwnerId1].ToString().Trim(); //拥有者Id1
objCaseRelaInfoEN.FuncModuleId2 = objRow[conCaseRelaInfo.FuncModuleId2].ToString().Trim(); //功能模块Id2
objCaseRelaInfoEN.CaseId2 = objRow[conCaseRelaInfo.CaseId2].ToString().Trim(); //案例Id2
objCaseRelaInfoEN.CaseName2 = objRow[conCaseRelaInfo.CaseName2].ToString().Trim(); //案例名称2
objCaseRelaInfoEN.OwnerId2 = objRow[conCaseRelaInfo.OwnerId2] == DBNull.Value ? null : objRow[conCaseRelaInfo.OwnerId2].ToString().Trim(); //拥有者Id2
objCaseRelaInfoEN.RelationsDegree = Int32.Parse(objRow[conCaseRelaInfo.RelationsDegree].ToString().Trim()); //关系度
objCaseRelaInfoEN.IdCaseRelaInfoType = objRow[conCaseRelaInfo.IdCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号
objCaseRelaInfoEN.BrowseCount = Int32.Parse(objRow[conCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objCaseRelaInfoEN.UpdDate = objRow[conCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[conCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objCaseRelaInfoEN.UpdUserId = objRow[conCaseRelaInfo.UpdUserId] == DBNull.Value ? null : objRow[conCaseRelaInfo.UpdUserId].ToString().Trim(); //修改用户Id
objCaseRelaInfoEN.Memo = objRow[conCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[conCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseRelaInfoEN.IdCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseRelaInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objCaseRelaInfoCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsCaseRelaInfoEN> GetSubObjLstCache(clsCaseRelaInfoEN objCaseRelaInfoCond)
{
List<clsCaseRelaInfoEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsCaseRelaInfoEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCaseRelaInfo.AttributeName)
{
if (objCaseRelaInfoCond.IsUpdated(strFldName) == false) continue;
if (objCaseRelaInfoCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCaseRelaInfoCond[strFldName].ToString());
}
else
{
if (objCaseRelaInfoCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCaseRelaInfoCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCaseRelaInfoCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCaseRelaInfoCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCaseRelaInfoCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCaseRelaInfoCond[strFldName]));
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
public static List<clsCaseRelaInfoEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsCaseRelaInfoEN> arrObjLst = new List<clsCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseRelaInfoEN objCaseRelaInfoEN = new clsCaseRelaInfoEN();
try
{
objCaseRelaInfoEN.IdCaseRelaInfo = Int32.Parse(objRow[conCaseRelaInfo.IdCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objCaseRelaInfoEN.FuncModuleId1 = objRow[conCaseRelaInfo.FuncModuleId1].ToString().Trim(); //功能模块Id1
objCaseRelaInfoEN.CaseId1 = objRow[conCaseRelaInfo.CaseId1].ToString().Trim(); //案例Id1
objCaseRelaInfoEN.CaseName1 = objRow[conCaseRelaInfo.CaseName1].ToString().Trim(); //案例名称1
objCaseRelaInfoEN.OwnerId1 = objRow[conCaseRelaInfo.OwnerId1] == DBNull.Value ? null : objRow[conCaseRelaInfo.OwnerId1].ToString().Trim(); //拥有者Id1
objCaseRelaInfoEN.FuncModuleId2 = objRow[conCaseRelaInfo.FuncModuleId2].ToString().Trim(); //功能模块Id2
objCaseRelaInfoEN.CaseId2 = objRow[conCaseRelaInfo.CaseId2].ToString().Trim(); //案例Id2
objCaseRelaInfoEN.CaseName2 = objRow[conCaseRelaInfo.CaseName2].ToString().Trim(); //案例名称2
objCaseRelaInfoEN.OwnerId2 = objRow[conCaseRelaInfo.OwnerId2] == DBNull.Value ? null : objRow[conCaseRelaInfo.OwnerId2].ToString().Trim(); //拥有者Id2
objCaseRelaInfoEN.RelationsDegree = Int32.Parse(objRow[conCaseRelaInfo.RelationsDegree].ToString().Trim()); //关系度
objCaseRelaInfoEN.IdCaseRelaInfoType = objRow[conCaseRelaInfo.IdCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号
objCaseRelaInfoEN.BrowseCount = Int32.Parse(objRow[conCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objCaseRelaInfoEN.UpdDate = objRow[conCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[conCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objCaseRelaInfoEN.UpdUserId = objRow[conCaseRelaInfo.UpdUserId] == DBNull.Value ? null : objRow[conCaseRelaInfo.UpdUserId].ToString().Trim(); //修改用户Id
objCaseRelaInfoEN.Memo = objRow[conCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[conCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseRelaInfoEN.IdCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseRelaInfoEN);
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
public static List<clsCaseRelaInfoEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsCaseRelaInfoEN> arrObjLst = new List<clsCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseRelaInfoEN objCaseRelaInfoEN = new clsCaseRelaInfoEN();
try
{
objCaseRelaInfoEN.IdCaseRelaInfo = Int32.Parse(objRow[conCaseRelaInfo.IdCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objCaseRelaInfoEN.FuncModuleId1 = objRow[conCaseRelaInfo.FuncModuleId1].ToString().Trim(); //功能模块Id1
objCaseRelaInfoEN.CaseId1 = objRow[conCaseRelaInfo.CaseId1].ToString().Trim(); //案例Id1
objCaseRelaInfoEN.CaseName1 = objRow[conCaseRelaInfo.CaseName1].ToString().Trim(); //案例名称1
objCaseRelaInfoEN.OwnerId1 = objRow[conCaseRelaInfo.OwnerId1] == DBNull.Value ? null : objRow[conCaseRelaInfo.OwnerId1].ToString().Trim(); //拥有者Id1
objCaseRelaInfoEN.FuncModuleId2 = objRow[conCaseRelaInfo.FuncModuleId2].ToString().Trim(); //功能模块Id2
objCaseRelaInfoEN.CaseId2 = objRow[conCaseRelaInfo.CaseId2].ToString().Trim(); //案例Id2
objCaseRelaInfoEN.CaseName2 = objRow[conCaseRelaInfo.CaseName2].ToString().Trim(); //案例名称2
objCaseRelaInfoEN.OwnerId2 = objRow[conCaseRelaInfo.OwnerId2] == DBNull.Value ? null : objRow[conCaseRelaInfo.OwnerId2].ToString().Trim(); //拥有者Id2
objCaseRelaInfoEN.RelationsDegree = Int32.Parse(objRow[conCaseRelaInfo.RelationsDegree].ToString().Trim()); //关系度
objCaseRelaInfoEN.IdCaseRelaInfoType = objRow[conCaseRelaInfo.IdCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号
objCaseRelaInfoEN.BrowseCount = Int32.Parse(objRow[conCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objCaseRelaInfoEN.UpdDate = objRow[conCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[conCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objCaseRelaInfoEN.UpdUserId = objRow[conCaseRelaInfo.UpdUserId] == DBNull.Value ? null : objRow[conCaseRelaInfo.UpdUserId].ToString().Trim(); //修改用户Id
objCaseRelaInfoEN.Memo = objRow[conCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[conCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseRelaInfoEN.IdCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseRelaInfoEN);
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
List<clsCaseRelaInfoEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsCaseRelaInfoEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsCaseRelaInfoEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsCaseRelaInfoEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsCaseRelaInfoEN> arrObjLst = new List<clsCaseRelaInfoEN>(); 
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
	clsCaseRelaInfoEN objCaseRelaInfoEN = new clsCaseRelaInfoEN();
try
{
objCaseRelaInfoEN.IdCaseRelaInfo = Int32.Parse(objRow[conCaseRelaInfo.IdCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objCaseRelaInfoEN.FuncModuleId1 = objRow[conCaseRelaInfo.FuncModuleId1].ToString().Trim(); //功能模块Id1
objCaseRelaInfoEN.CaseId1 = objRow[conCaseRelaInfo.CaseId1].ToString().Trim(); //案例Id1
objCaseRelaInfoEN.CaseName1 = objRow[conCaseRelaInfo.CaseName1].ToString().Trim(); //案例名称1
objCaseRelaInfoEN.OwnerId1 = objRow[conCaseRelaInfo.OwnerId1] == DBNull.Value ? null : objRow[conCaseRelaInfo.OwnerId1].ToString().Trim(); //拥有者Id1
objCaseRelaInfoEN.FuncModuleId2 = objRow[conCaseRelaInfo.FuncModuleId2].ToString().Trim(); //功能模块Id2
objCaseRelaInfoEN.CaseId2 = objRow[conCaseRelaInfo.CaseId2].ToString().Trim(); //案例Id2
objCaseRelaInfoEN.CaseName2 = objRow[conCaseRelaInfo.CaseName2].ToString().Trim(); //案例名称2
objCaseRelaInfoEN.OwnerId2 = objRow[conCaseRelaInfo.OwnerId2] == DBNull.Value ? null : objRow[conCaseRelaInfo.OwnerId2].ToString().Trim(); //拥有者Id2
objCaseRelaInfoEN.RelationsDegree = Int32.Parse(objRow[conCaseRelaInfo.RelationsDegree].ToString().Trim()); //关系度
objCaseRelaInfoEN.IdCaseRelaInfoType = objRow[conCaseRelaInfo.IdCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号
objCaseRelaInfoEN.BrowseCount = Int32.Parse(objRow[conCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objCaseRelaInfoEN.UpdDate = objRow[conCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[conCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objCaseRelaInfoEN.UpdUserId = objRow[conCaseRelaInfo.UpdUserId] == DBNull.Value ? null : objRow[conCaseRelaInfo.UpdUserId].ToString().Trim(); //修改用户Id
objCaseRelaInfoEN.Memo = objRow[conCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[conCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseRelaInfoEN.IdCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseRelaInfoEN);
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
public static List<clsCaseRelaInfoEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsCaseRelaInfoEN> arrObjLst = new List<clsCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseRelaInfoEN objCaseRelaInfoEN = new clsCaseRelaInfoEN();
try
{
objCaseRelaInfoEN.IdCaseRelaInfo = Int32.Parse(objRow[conCaseRelaInfo.IdCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objCaseRelaInfoEN.FuncModuleId1 = objRow[conCaseRelaInfo.FuncModuleId1].ToString().Trim(); //功能模块Id1
objCaseRelaInfoEN.CaseId1 = objRow[conCaseRelaInfo.CaseId1].ToString().Trim(); //案例Id1
objCaseRelaInfoEN.CaseName1 = objRow[conCaseRelaInfo.CaseName1].ToString().Trim(); //案例名称1
objCaseRelaInfoEN.OwnerId1 = objRow[conCaseRelaInfo.OwnerId1] == DBNull.Value ? null : objRow[conCaseRelaInfo.OwnerId1].ToString().Trim(); //拥有者Id1
objCaseRelaInfoEN.FuncModuleId2 = objRow[conCaseRelaInfo.FuncModuleId2].ToString().Trim(); //功能模块Id2
objCaseRelaInfoEN.CaseId2 = objRow[conCaseRelaInfo.CaseId2].ToString().Trim(); //案例Id2
objCaseRelaInfoEN.CaseName2 = objRow[conCaseRelaInfo.CaseName2].ToString().Trim(); //案例名称2
objCaseRelaInfoEN.OwnerId2 = objRow[conCaseRelaInfo.OwnerId2] == DBNull.Value ? null : objRow[conCaseRelaInfo.OwnerId2].ToString().Trim(); //拥有者Id2
objCaseRelaInfoEN.RelationsDegree = Int32.Parse(objRow[conCaseRelaInfo.RelationsDegree].ToString().Trim()); //关系度
objCaseRelaInfoEN.IdCaseRelaInfoType = objRow[conCaseRelaInfo.IdCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号
objCaseRelaInfoEN.BrowseCount = Int32.Parse(objRow[conCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objCaseRelaInfoEN.UpdDate = objRow[conCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[conCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objCaseRelaInfoEN.UpdUserId = objRow[conCaseRelaInfo.UpdUserId] == DBNull.Value ? null : objRow[conCaseRelaInfo.UpdUserId].ToString().Trim(); //修改用户Id
objCaseRelaInfoEN.Memo = objRow[conCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[conCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseRelaInfoEN.IdCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseRelaInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsCaseRelaInfoEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsCaseRelaInfoEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsCaseRelaInfoEN> arrObjLst = new List<clsCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseRelaInfoEN objCaseRelaInfoEN = new clsCaseRelaInfoEN();
try
{
objCaseRelaInfoEN.IdCaseRelaInfo = Int32.Parse(objRow[conCaseRelaInfo.IdCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objCaseRelaInfoEN.FuncModuleId1 = objRow[conCaseRelaInfo.FuncModuleId1].ToString().Trim(); //功能模块Id1
objCaseRelaInfoEN.CaseId1 = objRow[conCaseRelaInfo.CaseId1].ToString().Trim(); //案例Id1
objCaseRelaInfoEN.CaseName1 = objRow[conCaseRelaInfo.CaseName1].ToString().Trim(); //案例名称1
objCaseRelaInfoEN.OwnerId1 = objRow[conCaseRelaInfo.OwnerId1] == DBNull.Value ? null : objRow[conCaseRelaInfo.OwnerId1].ToString().Trim(); //拥有者Id1
objCaseRelaInfoEN.FuncModuleId2 = objRow[conCaseRelaInfo.FuncModuleId2].ToString().Trim(); //功能模块Id2
objCaseRelaInfoEN.CaseId2 = objRow[conCaseRelaInfo.CaseId2].ToString().Trim(); //案例Id2
objCaseRelaInfoEN.CaseName2 = objRow[conCaseRelaInfo.CaseName2].ToString().Trim(); //案例名称2
objCaseRelaInfoEN.OwnerId2 = objRow[conCaseRelaInfo.OwnerId2] == DBNull.Value ? null : objRow[conCaseRelaInfo.OwnerId2].ToString().Trim(); //拥有者Id2
objCaseRelaInfoEN.RelationsDegree = Int32.Parse(objRow[conCaseRelaInfo.RelationsDegree].ToString().Trim()); //关系度
objCaseRelaInfoEN.IdCaseRelaInfoType = objRow[conCaseRelaInfo.IdCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号
objCaseRelaInfoEN.BrowseCount = Int32.Parse(objRow[conCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objCaseRelaInfoEN.UpdDate = objRow[conCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[conCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objCaseRelaInfoEN.UpdUserId = objRow[conCaseRelaInfo.UpdUserId] == DBNull.Value ? null : objRow[conCaseRelaInfo.UpdUserId].ToString().Trim(); //修改用户Id
objCaseRelaInfoEN.Memo = objRow[conCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[conCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseRelaInfoEN.IdCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseRelaInfoEN);
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
public static List<clsCaseRelaInfoEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsCaseRelaInfoEN> arrObjLst = new List<clsCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseRelaInfoEN objCaseRelaInfoEN = new clsCaseRelaInfoEN();
try
{
objCaseRelaInfoEN.IdCaseRelaInfo = Int32.Parse(objRow[conCaseRelaInfo.IdCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objCaseRelaInfoEN.FuncModuleId1 = objRow[conCaseRelaInfo.FuncModuleId1].ToString().Trim(); //功能模块Id1
objCaseRelaInfoEN.CaseId1 = objRow[conCaseRelaInfo.CaseId1].ToString().Trim(); //案例Id1
objCaseRelaInfoEN.CaseName1 = objRow[conCaseRelaInfo.CaseName1].ToString().Trim(); //案例名称1
objCaseRelaInfoEN.OwnerId1 = objRow[conCaseRelaInfo.OwnerId1] == DBNull.Value ? null : objRow[conCaseRelaInfo.OwnerId1].ToString().Trim(); //拥有者Id1
objCaseRelaInfoEN.FuncModuleId2 = objRow[conCaseRelaInfo.FuncModuleId2].ToString().Trim(); //功能模块Id2
objCaseRelaInfoEN.CaseId2 = objRow[conCaseRelaInfo.CaseId2].ToString().Trim(); //案例Id2
objCaseRelaInfoEN.CaseName2 = objRow[conCaseRelaInfo.CaseName2].ToString().Trim(); //案例名称2
objCaseRelaInfoEN.OwnerId2 = objRow[conCaseRelaInfo.OwnerId2] == DBNull.Value ? null : objRow[conCaseRelaInfo.OwnerId2].ToString().Trim(); //拥有者Id2
objCaseRelaInfoEN.RelationsDegree = Int32.Parse(objRow[conCaseRelaInfo.RelationsDegree].ToString().Trim()); //关系度
objCaseRelaInfoEN.IdCaseRelaInfoType = objRow[conCaseRelaInfo.IdCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号
objCaseRelaInfoEN.BrowseCount = Int32.Parse(objRow[conCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objCaseRelaInfoEN.UpdDate = objRow[conCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[conCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objCaseRelaInfoEN.UpdUserId = objRow[conCaseRelaInfo.UpdUserId] == DBNull.Value ? null : objRow[conCaseRelaInfo.UpdUserId].ToString().Trim(); //修改用户Id
objCaseRelaInfoEN.Memo = objRow[conCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[conCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseRelaInfoEN.IdCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseRelaInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsCaseRelaInfoEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsCaseRelaInfoEN> arrObjLst = new List<clsCaseRelaInfoEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseRelaInfoEN objCaseRelaInfoEN = new clsCaseRelaInfoEN();
try
{
objCaseRelaInfoEN.IdCaseRelaInfo = Int32.Parse(objRow[conCaseRelaInfo.IdCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objCaseRelaInfoEN.FuncModuleId1 = objRow[conCaseRelaInfo.FuncModuleId1].ToString().Trim(); //功能模块Id1
objCaseRelaInfoEN.CaseId1 = objRow[conCaseRelaInfo.CaseId1].ToString().Trim(); //案例Id1
objCaseRelaInfoEN.CaseName1 = objRow[conCaseRelaInfo.CaseName1].ToString().Trim(); //案例名称1
objCaseRelaInfoEN.OwnerId1 = objRow[conCaseRelaInfo.OwnerId1] == DBNull.Value ? null : objRow[conCaseRelaInfo.OwnerId1].ToString().Trim(); //拥有者Id1
objCaseRelaInfoEN.FuncModuleId2 = objRow[conCaseRelaInfo.FuncModuleId2].ToString().Trim(); //功能模块Id2
objCaseRelaInfoEN.CaseId2 = objRow[conCaseRelaInfo.CaseId2].ToString().Trim(); //案例Id2
objCaseRelaInfoEN.CaseName2 = objRow[conCaseRelaInfo.CaseName2].ToString().Trim(); //案例名称2
objCaseRelaInfoEN.OwnerId2 = objRow[conCaseRelaInfo.OwnerId2] == DBNull.Value ? null : objRow[conCaseRelaInfo.OwnerId2].ToString().Trim(); //拥有者Id2
objCaseRelaInfoEN.RelationsDegree = Int32.Parse(objRow[conCaseRelaInfo.RelationsDegree].ToString().Trim()); //关系度
objCaseRelaInfoEN.IdCaseRelaInfoType = objRow[conCaseRelaInfo.IdCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号
objCaseRelaInfoEN.BrowseCount = Int32.Parse(objRow[conCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objCaseRelaInfoEN.UpdDate = objRow[conCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[conCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objCaseRelaInfoEN.UpdUserId = objRow[conCaseRelaInfo.UpdUserId] == DBNull.Value ? null : objRow[conCaseRelaInfo.UpdUserId].ToString().Trim(); //修改用户Id
objCaseRelaInfoEN.Memo = objRow[conCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[conCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseRelaInfoEN.IdCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseRelaInfoEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objCaseRelaInfoEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetCaseRelaInfo(ref clsCaseRelaInfoEN objCaseRelaInfoEN)
{
bool bolResult = CaseRelaInfoDA.GetCaseRelaInfo(ref objCaseRelaInfoEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsCaseRelaInfoEN GetObjByIdCaseRelaInfo(long lngIdCaseRelaInfo)
{
clsCaseRelaInfoEN objCaseRelaInfoEN = CaseRelaInfoDA.GetObjByIdCaseRelaInfo(lngIdCaseRelaInfo);
return objCaseRelaInfoEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsCaseRelaInfoEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsCaseRelaInfoEN objCaseRelaInfoEN = CaseRelaInfoDA.GetFirstObj(strWhereCond);
 return objCaseRelaInfoEN;
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
public static clsCaseRelaInfoEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsCaseRelaInfoEN objCaseRelaInfoEN = CaseRelaInfoDA.GetObjByDataRow(objRow);
 return objCaseRelaInfoEN;
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
public static clsCaseRelaInfoEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsCaseRelaInfoEN objCaseRelaInfoEN = CaseRelaInfoDA.GetObjByDataRow(objRow);
 return objCaseRelaInfoEN;
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
 /// <param name = "lngIdCaseRelaInfo">所给的关键字</param>
 /// <param name = "lstCaseRelaInfoObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCaseRelaInfoEN GetObjByIdCaseRelaInfoFromList(long lngIdCaseRelaInfo, List<clsCaseRelaInfoEN> lstCaseRelaInfoObjLst)
{
foreach (clsCaseRelaInfoEN objCaseRelaInfoEN in lstCaseRelaInfoObjLst)
{
if (objCaseRelaInfoEN.IdCaseRelaInfo == lngIdCaseRelaInfo)
{
return objCaseRelaInfoEN;
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
 long lngIdCaseRelaInfo;
 try
 {
 lngIdCaseRelaInfo = new clsCaseRelaInfoDA().GetFirstID(strWhereCond);
 return lngIdCaseRelaInfo;
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
 arrList = CaseRelaInfoDA.GetID(strWhereCond);
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
bool bolIsExist = CaseRelaInfoDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdCaseRelaInfo">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdCaseRelaInfo)
{
//检测记录是否存在
bool bolIsExist = CaseRelaInfoDA.IsExist(lngIdCaseRelaInfo);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngIdCaseRelaInfo">案例相关信息流水号</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngIdCaseRelaInfo, string strOpUser)
{
clsCaseRelaInfoEN objCaseRelaInfoEN = clsCaseRelaInfoBL.GetObjByIdCaseRelaInfo(lngIdCaseRelaInfo);
objCaseRelaInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objCaseRelaInfoEN.UpdUserId = strOpUser;
return clsCaseRelaInfoBL.UpdateBySql2(objCaseRelaInfoEN);
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
 bolIsExist = clsCaseRelaInfoDA.IsExistTable();
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
 bolIsExist = CaseRelaInfoDA.IsExistTable(strTabName);
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
 /// <param name = "objCaseRelaInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsCaseRelaInfoEN objCaseRelaInfoEN)
{
if (objCaseRelaInfoEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!案例Id1 = [{0}],案例Id2 = [{1}],案例相关信息类型流水号 = [{2}]的数据已经存在!(in clsCaseRelaInfoBL.AddNewRecordBySql2)", objCaseRelaInfoEN.CaseId1,objCaseRelaInfoEN.CaseId2,objCaseRelaInfoEN.IdCaseRelaInfoType);
throw new Exception(strMsg);
}
try
{
bool bolResult = CaseRelaInfoDA.AddNewRecordBySQL2(objCaseRelaInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseRelaInfoBL.ReFreshCache();

if (clsCaseRelaInfoBL.relatedActions != null)
{
clsCaseRelaInfoBL.relatedActions.UpdRelaTabDate(objCaseRelaInfoEN.IdCaseRelaInfo, objCaseRelaInfoEN.UpdUserId);
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
 /// <param name = "objCaseRelaInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsCaseRelaInfoEN objCaseRelaInfoEN)
{
if (objCaseRelaInfoEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!案例Id1 = [{0}],案例Id2 = [{1}],案例相关信息类型流水号 = [{2}]的数据已经存在!(in clsCaseRelaInfoBL.AddNewRecordBySql2WithReturnKey)", objCaseRelaInfoEN.CaseId1,objCaseRelaInfoEN.CaseId2,objCaseRelaInfoEN.IdCaseRelaInfoType);
throw new Exception(strMsg);
}
try
{
string strKey = CaseRelaInfoDA.AddNewRecordBySQL2WithReturnKey(objCaseRelaInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseRelaInfoBL.ReFreshCache();

if (clsCaseRelaInfoBL.relatedActions != null)
{
clsCaseRelaInfoBL.relatedActions.UpdRelaTabDate(objCaseRelaInfoEN.IdCaseRelaInfo, objCaseRelaInfoEN.UpdUserId);
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
 /// <param name = "objCaseRelaInfoEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsCaseRelaInfoEN objCaseRelaInfoEN)
{
try
{
bool bolResult = CaseRelaInfoDA.Update(objCaseRelaInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseRelaInfoBL.ReFreshCache();

if (clsCaseRelaInfoBL.relatedActions != null)
{
clsCaseRelaInfoBL.relatedActions.UpdRelaTabDate(objCaseRelaInfoEN.IdCaseRelaInfo, objCaseRelaInfoEN.UpdUserId);
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
 /// <param name = "objCaseRelaInfoEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsCaseRelaInfoEN objCaseRelaInfoEN)
{
 if (objCaseRelaInfoEN.IdCaseRelaInfo == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = CaseRelaInfoDA.UpdateBySql2(objCaseRelaInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseRelaInfoBL.ReFreshCache();

if (clsCaseRelaInfoBL.relatedActions != null)
{
clsCaseRelaInfoBL.relatedActions.UpdRelaTabDate(objCaseRelaInfoEN.IdCaseRelaInfo, objCaseRelaInfoEN.UpdUserId);
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
 /// <param name = "lngIdCaseRelaInfo">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngIdCaseRelaInfo)
{
try
{
 clsCaseRelaInfoEN objCaseRelaInfoEN = clsCaseRelaInfoBL.GetObjByIdCaseRelaInfo(lngIdCaseRelaInfo);

if (clsCaseRelaInfoBL.relatedActions != null)
{
clsCaseRelaInfoBL.relatedActions.UpdRelaTabDate(objCaseRelaInfoEN.IdCaseRelaInfo, objCaseRelaInfoEN.UpdUserId);
}
if (objCaseRelaInfoEN != null)
{
int intRecNum = CaseRelaInfoDA.DelRecord(lngIdCaseRelaInfo);
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
/// <param name="lngIdCaseRelaInfo">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngIdCaseRelaInfo )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCaseRelaInfoDA.GetSpecSQLObj();
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
//删除与表:[CaseRelaInfo]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conCaseRelaInfo.IdCaseRelaInfo,
//lngIdCaseRelaInfo);
//        clsCaseRelaInfoBL.DelCaseRelaInfosByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCaseRelaInfoBL.DelRecord(lngIdCaseRelaInfo, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCaseRelaInfoBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngIdCaseRelaInfo, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngIdCaseRelaInfo">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngIdCaseRelaInfo, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsCaseRelaInfoBL.relatedActions != null)
{
clsCaseRelaInfoBL.relatedActions.UpdRelaTabDate(lngIdCaseRelaInfo, "UpdRelaTabDate");
}
bool bolResult = CaseRelaInfoDA.DelRecord(lngIdCaseRelaInfo,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdCaseRelaInfoLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelCaseRelaInfos(List<string> arrIdCaseRelaInfoLst)
{
if (arrIdCaseRelaInfoLst.Count == 0) return 0;
try
{
if (clsCaseRelaInfoBL.relatedActions != null)
{
foreach (var strIdCaseRelaInfo in arrIdCaseRelaInfoLst)
{
long lngIdCaseRelaInfo = long.Parse(strIdCaseRelaInfo);
clsCaseRelaInfoBL.relatedActions.UpdRelaTabDate(lngIdCaseRelaInfo, "UpdRelaTabDate");
}
}
int intDelRecNum = CaseRelaInfoDA.DelCaseRelaInfo(arrIdCaseRelaInfoLst);
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
public static int DelCaseRelaInfosByCond(string strWhereCond)
{
try
{
if (clsCaseRelaInfoBL.relatedActions != null)
{
List<string> arrIdCaseRelaInfo = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdCaseRelaInfo in arrIdCaseRelaInfo)
{
long lngIdCaseRelaInfo = long.Parse(strIdCaseRelaInfo);
clsCaseRelaInfoBL.relatedActions.UpdRelaTabDate(lngIdCaseRelaInfo, "UpdRelaTabDate");
}
}
int intRecNum = CaseRelaInfoDA.DelCaseRelaInfo(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[CaseRelaInfo]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngIdCaseRelaInfo">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngIdCaseRelaInfo)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCaseRelaInfoDA.GetSpecSQLObj();
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
//删除与表:[CaseRelaInfo]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCaseRelaInfoBL.DelRecord(lngIdCaseRelaInfo, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCaseRelaInfoBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngIdCaseRelaInfo, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objCaseRelaInfoENS">源对象</param>
 /// <param name = "objCaseRelaInfoENT">目标对象</param>
 public static void CopyTo(clsCaseRelaInfoEN objCaseRelaInfoENS, clsCaseRelaInfoEN objCaseRelaInfoENT)
{
try
{
objCaseRelaInfoENT.IdCaseRelaInfo = objCaseRelaInfoENS.IdCaseRelaInfo; //案例相关信息流水号
objCaseRelaInfoENT.FuncModuleId1 = objCaseRelaInfoENS.FuncModuleId1; //功能模块Id1
objCaseRelaInfoENT.CaseId1 = objCaseRelaInfoENS.CaseId1; //案例Id1
objCaseRelaInfoENT.CaseName1 = objCaseRelaInfoENS.CaseName1; //案例名称1
objCaseRelaInfoENT.OwnerId1 = objCaseRelaInfoENS.OwnerId1; //拥有者Id1
objCaseRelaInfoENT.FuncModuleId2 = objCaseRelaInfoENS.FuncModuleId2; //功能模块Id2
objCaseRelaInfoENT.CaseId2 = objCaseRelaInfoENS.CaseId2; //案例Id2
objCaseRelaInfoENT.CaseName2 = objCaseRelaInfoENS.CaseName2; //案例名称2
objCaseRelaInfoENT.OwnerId2 = objCaseRelaInfoENS.OwnerId2; //拥有者Id2
objCaseRelaInfoENT.RelationsDegree = objCaseRelaInfoENS.RelationsDegree; //关系度
objCaseRelaInfoENT.IdCaseRelaInfoType = objCaseRelaInfoENS.IdCaseRelaInfoType; //案例相关信息类型流水号
objCaseRelaInfoENT.BrowseCount = objCaseRelaInfoENS.BrowseCount; //浏览次数
objCaseRelaInfoENT.UpdDate = objCaseRelaInfoENS.UpdDate; //修改日期
objCaseRelaInfoENT.UpdUserId = objCaseRelaInfoENS.UpdUserId; //修改用户Id
objCaseRelaInfoENT.Memo = objCaseRelaInfoENS.Memo; //备注
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
 /// <param name = "objCaseRelaInfoEN">源简化对象</param>
 public static void SetUpdFlag(clsCaseRelaInfoEN objCaseRelaInfoEN)
{
try
{
objCaseRelaInfoEN.ClearUpdateState();
   string strsfUpdFldSetStr = objCaseRelaInfoEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conCaseRelaInfo.IdCaseRelaInfo, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseRelaInfoEN.IdCaseRelaInfo = objCaseRelaInfoEN.IdCaseRelaInfo; //案例相关信息流水号
}
if (arrFldSet.Contains(conCaseRelaInfo.FuncModuleId1, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseRelaInfoEN.FuncModuleId1 = objCaseRelaInfoEN.FuncModuleId1; //功能模块Id1
}
if (arrFldSet.Contains(conCaseRelaInfo.CaseId1, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseRelaInfoEN.CaseId1 = objCaseRelaInfoEN.CaseId1; //案例Id1
}
if (arrFldSet.Contains(conCaseRelaInfo.CaseName1, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseRelaInfoEN.CaseName1 = objCaseRelaInfoEN.CaseName1; //案例名称1
}
if (arrFldSet.Contains(conCaseRelaInfo.OwnerId1, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseRelaInfoEN.OwnerId1 = objCaseRelaInfoEN.OwnerId1 == "[null]" ? null :  objCaseRelaInfoEN.OwnerId1; //拥有者Id1
}
if (arrFldSet.Contains(conCaseRelaInfo.FuncModuleId2, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseRelaInfoEN.FuncModuleId2 = objCaseRelaInfoEN.FuncModuleId2; //功能模块Id2
}
if (arrFldSet.Contains(conCaseRelaInfo.CaseId2, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseRelaInfoEN.CaseId2 = objCaseRelaInfoEN.CaseId2; //案例Id2
}
if (arrFldSet.Contains(conCaseRelaInfo.CaseName2, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseRelaInfoEN.CaseName2 = objCaseRelaInfoEN.CaseName2; //案例名称2
}
if (arrFldSet.Contains(conCaseRelaInfo.OwnerId2, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseRelaInfoEN.OwnerId2 = objCaseRelaInfoEN.OwnerId2 == "[null]" ? null :  objCaseRelaInfoEN.OwnerId2; //拥有者Id2
}
if (arrFldSet.Contains(conCaseRelaInfo.RelationsDegree, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseRelaInfoEN.RelationsDegree = objCaseRelaInfoEN.RelationsDegree; //关系度
}
if (arrFldSet.Contains(conCaseRelaInfo.IdCaseRelaInfoType, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseRelaInfoEN.IdCaseRelaInfoType = objCaseRelaInfoEN.IdCaseRelaInfoType; //案例相关信息类型流水号
}
if (arrFldSet.Contains(conCaseRelaInfo.BrowseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseRelaInfoEN.BrowseCount = objCaseRelaInfoEN.BrowseCount; //浏览次数
}
if (arrFldSet.Contains(conCaseRelaInfo.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseRelaInfoEN.UpdDate = objCaseRelaInfoEN.UpdDate == "[null]" ? null :  objCaseRelaInfoEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conCaseRelaInfo.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseRelaInfoEN.UpdUserId = objCaseRelaInfoEN.UpdUserId == "[null]" ? null :  objCaseRelaInfoEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conCaseRelaInfo.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseRelaInfoEN.Memo = objCaseRelaInfoEN.Memo == "[null]" ? null :  objCaseRelaInfoEN.Memo; //备注
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
 /// <param name = "objCaseRelaInfoEN">源简化对象</param>
 public static void AccessFldValueNull(clsCaseRelaInfoEN objCaseRelaInfoEN)
{
try
{
if (objCaseRelaInfoEN.OwnerId1 == "[null]") objCaseRelaInfoEN.OwnerId1 = null; //拥有者Id1
if (objCaseRelaInfoEN.OwnerId2 == "[null]") objCaseRelaInfoEN.OwnerId2 = null; //拥有者Id2
if (objCaseRelaInfoEN.UpdDate == "[null]") objCaseRelaInfoEN.UpdDate = null; //修改日期
if (objCaseRelaInfoEN.UpdUserId == "[null]") objCaseRelaInfoEN.UpdUserId = null; //修改用户Id
if (objCaseRelaInfoEN.Memo == "[null]") objCaseRelaInfoEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsCaseRelaInfoEN objCaseRelaInfoEN)
{
 CaseRelaInfoDA.CheckPropertyNew(objCaseRelaInfoEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsCaseRelaInfoEN objCaseRelaInfoEN)
{
 CaseRelaInfoDA.CheckProperty4Condition(objCaseRelaInfoEN);
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
if (clsCaseRelaInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseRelaInfoBL没有刷新缓存机制(clsCaseRelaInfoBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdCaseRelaInfo");
//if (arrCaseRelaInfoObjLstCache == null)
//{
//arrCaseRelaInfoObjLstCache = CaseRelaInfoDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdCaseRelaInfo">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCaseRelaInfoEN GetObjByIdCaseRelaInfoCache(long lngIdCaseRelaInfo)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsCaseRelaInfoEN._CurrTabName);
List<clsCaseRelaInfoEN> arrCaseRelaInfoObjLstCache = GetObjLstCache();
IEnumerable <clsCaseRelaInfoEN> arrCaseRelaInfoObjLst_Sel =
arrCaseRelaInfoObjLstCache
.Where(x=> x.IdCaseRelaInfo == lngIdCaseRelaInfo 
);
if (arrCaseRelaInfoObjLst_Sel.Count() == 0)
{
   clsCaseRelaInfoEN obj = clsCaseRelaInfoBL.GetObjByIdCaseRelaInfo(lngIdCaseRelaInfo);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrCaseRelaInfoObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCaseRelaInfoEN> GetAllCaseRelaInfoObjLstCache()
{
//获取缓存中的对象列表
List<clsCaseRelaInfoEN> arrCaseRelaInfoObjLstCache = GetObjLstCache(); 
return arrCaseRelaInfoObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCaseRelaInfoEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsCaseRelaInfoEN._CurrTabName);
List<clsCaseRelaInfoEN> arrCaseRelaInfoObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrCaseRelaInfoObjLstCache;
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
string strKey = string.Format("{0}", clsCaseRelaInfoEN._CurrTabName);
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
if (clsCaseRelaInfoBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCaseRelaInfoEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCaseRelaInfoBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--CaseRelaInfo(案例相关信息)
 /// 唯一性条件:CaseId1_CaseId2_id_CaseRelaInfoType
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCaseRelaInfoEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsCaseRelaInfoEN objCaseRelaInfoEN)
{
//检测记录是否存在
string strResult = CaseRelaInfoDA.GetUniCondStr(objCaseRelaInfoEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-08-24
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngIdCaseRelaInfo)
{
if (strInFldName != conCaseRelaInfo.IdCaseRelaInfo)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conCaseRelaInfo.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conCaseRelaInfo.AttributeName));
throw new Exception(strMsg);
}
var objCaseRelaInfo = clsCaseRelaInfoBL.GetObjByIdCaseRelaInfoCache(lngIdCaseRelaInfo);
if (objCaseRelaInfo == null) return "";
return objCaseRelaInfo[strOutFldName].ToString();
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
int intRecCount = clsCaseRelaInfoDA.GetRecCount(strTabName);
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
int intRecCount = clsCaseRelaInfoDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsCaseRelaInfoDA.GetRecCount();
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
int intRecCount = clsCaseRelaInfoDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objCaseRelaInfoCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsCaseRelaInfoEN objCaseRelaInfoCond)
{
List<clsCaseRelaInfoEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsCaseRelaInfoEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCaseRelaInfo.AttributeName)
{
if (objCaseRelaInfoCond.IsUpdated(strFldName) == false) continue;
if (objCaseRelaInfoCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCaseRelaInfoCond[strFldName].ToString());
}
else
{
if (objCaseRelaInfoCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCaseRelaInfoCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCaseRelaInfoCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCaseRelaInfoCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCaseRelaInfoCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCaseRelaInfoCond[strFldName]));
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
 List<string> arrList = clsCaseRelaInfoDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = CaseRelaInfoDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = CaseRelaInfoDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = CaseRelaInfoDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsCaseRelaInfoDA.SetFldValue(clsCaseRelaInfoEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = CaseRelaInfoDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsCaseRelaInfoDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsCaseRelaInfoDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsCaseRelaInfoDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[CaseRelaInfo] "); 
 strCreateTabCode.Append(" ( "); 
 // /**案例相关信息流水号*/ 
 strCreateTabCode.Append(" IdCaseRelaInfo bigint primary key identity, "); 
 // /**功能模块Id1*/ 
 strCreateTabCode.Append(" FuncModuleId1 char(4) not Null, "); 
 // /**案例Id1*/ 
 strCreateTabCode.Append(" CaseId1 char(8) not Null, "); 
 // /**案例名称1*/ 
 strCreateTabCode.Append(" CaseName1 varchar(100) not Null, "); 
 // /**拥有者Id1*/ 
 strCreateTabCode.Append(" OwnerId1 varchar(20) Null, "); 
 // /**功能模块Id2*/ 
 strCreateTabCode.Append(" FuncModuleId2 char(4) not Null, "); 
 // /**案例Id2*/ 
 strCreateTabCode.Append(" CaseId2 char(8) not Null, "); 
 // /**案例名称2*/ 
 strCreateTabCode.Append(" CaseName2 varchar(100) not Null, "); 
 // /**拥有者Id2*/ 
 strCreateTabCode.Append(" OwnerId2 varchar(20) Null, "); 
 // /**关系度*/ 
 strCreateTabCode.Append(" RelationsDegree int not Null, "); 
 // /**案例相关信息类型流水号*/ 
 strCreateTabCode.Append(" IdCaseRelaInfoType char(4) not Null, "); 
 // /**浏览次数*/ 
 strCreateTabCode.Append(" BrowseCount int not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 案例相关信息(CaseRelaInfo)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4CaseRelaInfo : clsCommFun4BL
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
clsCaseRelaInfoBL.ReFreshThisCache();
}
}

}