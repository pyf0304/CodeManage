
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsMicroTeachCaseRelaInfoTypeBL
 表名:MicroTeachCaseRelaInfoType(01120317)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:19:32
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议(MicroTeachSenate)
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
public static class  clsMicroTeachCaseRelaInfoTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdMicroTeachCaseRelaInfoType">表关键字</param>
 /// <returns>表对象</returns>
public static clsMicroTeachCaseRelaInfoTypeEN GetObj(this K_IdMicroTeachCaseRelaInfoType_MicroTeachCaseRelaInfoType myKey)
{
clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoTypeEN = clsMicroTeachCaseRelaInfoTypeBL.MicroTeachCaseRelaInfoTypeDA.GetObjByIdMicroTeachCaseRelaInfoType(myKey.Value);
return objMicroTeachCaseRelaInfoTypeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objMicroTeachCaseRelaInfoTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoTypeEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsMicroTeachCaseRelaInfoTypeBL.IsExist(objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsMicroTeachCaseRelaInfoTypeBL.MicroTeachCaseRelaInfoTypeDA.AddNewRecordBySQL2(objMicroTeachCaseRelaInfoTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroTeachCaseRelaInfoTypeBL.ReFreshCache();

if (clsMicroTeachCaseRelaInfoTypeBL.relatedActions != null)
{
clsMicroTeachCaseRelaInfoTypeBL.relatedActions.UpdRelaTabDate(objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType, "SetUpdDate");
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
public static bool AddRecordEx(this clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoTypeEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsMicroTeachCaseRelaInfoTypeBL.IsExist(objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objMicroTeachCaseRelaInfoTypeEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objMicroTeachCaseRelaInfoTypeEN.AddNewRecord();
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
 /// <param name = "objMicroTeachCaseRelaInfoTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoTypeEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsMicroTeachCaseRelaInfoTypeBL.IsExist(objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsMicroTeachCaseRelaInfoTypeBL.MicroTeachCaseRelaInfoTypeDA.AddNewRecordBySQL2WithReturnKey(objMicroTeachCaseRelaInfoTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroTeachCaseRelaInfoTypeBL.ReFreshCache();

if (clsMicroTeachCaseRelaInfoTypeBL.relatedActions != null)
{
clsMicroTeachCaseRelaInfoTypeBL.relatedActions.UpdRelaTabDate(objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType, "SetUpdDate");
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
 /// <param name = "objMicroTeachCaseRelaInfoTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroTeachCaseRelaInfoTypeEN SetIdMicroTeachCaseRelaInfoType(this clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoTypeEN, string strIdMicroTeachCaseRelaInfoType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdMicroTeachCaseRelaInfoType, 4, conMicroTeachCaseRelaInfoType.IdMicroTeachCaseRelaInfoType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdMicroTeachCaseRelaInfoType, 4, conMicroTeachCaseRelaInfoType.IdMicroTeachCaseRelaInfoType);
}
objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType = strIdMicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroTeachCaseRelaInfoTypeEN.dicFldComparisonOp.ContainsKey(conMicroTeachCaseRelaInfoType.IdMicroTeachCaseRelaInfoType) == false)
{
objMicroTeachCaseRelaInfoTypeEN.dicFldComparisonOp.Add(conMicroTeachCaseRelaInfoType.IdMicroTeachCaseRelaInfoType, strComparisonOp);
}
else
{
objMicroTeachCaseRelaInfoTypeEN.dicFldComparisonOp[conMicroTeachCaseRelaInfoType.IdMicroTeachCaseRelaInfoType] = strComparisonOp;
}
}
return objMicroTeachCaseRelaInfoTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroTeachCaseRelaInfoTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroTeachCaseRelaInfoTypeEN SetMicroTeachCaseRelaInfoTypeID(this clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoTypeEN, string strMicroTeachCaseRelaInfoTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMicroTeachCaseRelaInfoTypeID, conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroTeachCaseRelaInfoTypeID, 4, conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMicroTeachCaseRelaInfoTypeID, 4, conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeID);
}
objMicroTeachCaseRelaInfoTypeEN.MicroTeachCaseRelaInfoTypeID = strMicroTeachCaseRelaInfoTypeID; //微格案例相关信息类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroTeachCaseRelaInfoTypeEN.dicFldComparisonOp.ContainsKey(conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeID) == false)
{
objMicroTeachCaseRelaInfoTypeEN.dicFldComparisonOp.Add(conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeID, strComparisonOp);
}
else
{
objMicroTeachCaseRelaInfoTypeEN.dicFldComparisonOp[conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeID] = strComparisonOp;
}
}
return objMicroTeachCaseRelaInfoTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroTeachCaseRelaInfoTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroTeachCaseRelaInfoTypeEN SetMicroTeachCaseRelaInfoTypeName(this clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoTypeEN, string strMicroTeachCaseRelaInfoTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMicroTeachCaseRelaInfoTypeName, conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroTeachCaseRelaInfoTypeName, 50, conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeName);
}
objMicroTeachCaseRelaInfoTypeEN.MicroTeachCaseRelaInfoTypeName = strMicroTeachCaseRelaInfoTypeName; //微格案例相关信息类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroTeachCaseRelaInfoTypeEN.dicFldComparisonOp.ContainsKey(conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeName) == false)
{
objMicroTeachCaseRelaInfoTypeEN.dicFldComparisonOp.Add(conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeName, strComparisonOp);
}
else
{
objMicroTeachCaseRelaInfoTypeEN.dicFldComparisonOp[conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeName] = strComparisonOp;
}
}
return objMicroTeachCaseRelaInfoTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroTeachCaseRelaInfoTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroTeachCaseRelaInfoTypeEN SetMicroTeachCaseRelaInfoTypeENName(this clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoTypeEN, string strMicroTeachCaseRelaInfoTypeENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroTeachCaseRelaInfoTypeENName, 50, conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeENName);
}
objMicroTeachCaseRelaInfoTypeEN.MicroTeachCaseRelaInfoTypeENName = strMicroTeachCaseRelaInfoTypeENName; //案例相关信息类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroTeachCaseRelaInfoTypeEN.dicFldComparisonOp.ContainsKey(conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeENName) == false)
{
objMicroTeachCaseRelaInfoTypeEN.dicFldComparisonOp.Add(conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeENName, strComparisonOp);
}
else
{
objMicroTeachCaseRelaInfoTypeEN.dicFldComparisonOp[conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeENName] = strComparisonOp;
}
}
return objMicroTeachCaseRelaInfoTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroTeachCaseRelaInfoTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroTeachCaseRelaInfoTypeEN SetCoursewareCaseRelaInfoTypeName(this clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoTypeEN, string strCoursewareCaseRelaInfoTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCoursewareCaseRelaInfoTypeName, 50, conMicroTeachCaseRelaInfoType.CoursewareCaseRelaInfoTypeName);
}
objMicroTeachCaseRelaInfoTypeEN.CoursewareCaseRelaInfoTypeName = strCoursewareCaseRelaInfoTypeName; //课件相关信息类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroTeachCaseRelaInfoTypeEN.dicFldComparisonOp.ContainsKey(conMicroTeachCaseRelaInfoType.CoursewareCaseRelaInfoTypeName) == false)
{
objMicroTeachCaseRelaInfoTypeEN.dicFldComparisonOp.Add(conMicroTeachCaseRelaInfoType.CoursewareCaseRelaInfoTypeName, strComparisonOp);
}
else
{
objMicroTeachCaseRelaInfoTypeEN.dicFldComparisonOp[conMicroTeachCaseRelaInfoType.CoursewareCaseRelaInfoTypeName] = strComparisonOp;
}
}
return objMicroTeachCaseRelaInfoTypeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objMicroTeachCaseRelaInfoTypeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoTypeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objMicroTeachCaseRelaInfoTypeEN.CheckPropertyNew();
clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoTypeCond = new clsMicroTeachCaseRelaInfoTypeEN();
string strCondition = objMicroTeachCaseRelaInfoTypeCond
.SetIdMicroTeachCaseRelaInfoType(objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType, "=")
.GetCombineCondition();
objMicroTeachCaseRelaInfoTypeEN._IsCheckProperty = true;
bool bolIsExist = clsMicroTeachCaseRelaInfoTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objMicroTeachCaseRelaInfoTypeEN.Update();
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
 /// <param name = "objMicroTeachCaseRelaInfoTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoTypeEN)
{
 if (string.IsNullOrEmpty(objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsMicroTeachCaseRelaInfoTypeBL.MicroTeachCaseRelaInfoTypeDA.UpdateBySql2(objMicroTeachCaseRelaInfoTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroTeachCaseRelaInfoTypeBL.ReFreshCache();

if (clsMicroTeachCaseRelaInfoTypeBL.relatedActions != null)
{
clsMicroTeachCaseRelaInfoTypeBL.relatedActions.UpdRelaTabDate(objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType, "SetUpdDate");
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
 /// <param name = "objMicroTeachCaseRelaInfoTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsMicroTeachCaseRelaInfoTypeBL.MicroTeachCaseRelaInfoTypeDA.UpdateBySql2(objMicroTeachCaseRelaInfoTypeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroTeachCaseRelaInfoTypeBL.ReFreshCache();

if (clsMicroTeachCaseRelaInfoTypeBL.relatedActions != null)
{
clsMicroTeachCaseRelaInfoTypeBL.relatedActions.UpdRelaTabDate(objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType, "SetUpdDate");
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
 /// <param name = "objMicroTeachCaseRelaInfoTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoTypeEN, string strWhereCond)
{
try
{
bool bolResult = clsMicroTeachCaseRelaInfoTypeBL.MicroTeachCaseRelaInfoTypeDA.UpdateBySqlWithCondition(objMicroTeachCaseRelaInfoTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroTeachCaseRelaInfoTypeBL.ReFreshCache();

if (clsMicroTeachCaseRelaInfoTypeBL.relatedActions != null)
{
clsMicroTeachCaseRelaInfoTypeBL.relatedActions.UpdRelaTabDate(objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType, "SetUpdDate");
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
 /// <param name = "objMicroTeachCaseRelaInfoTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoTypeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsMicroTeachCaseRelaInfoTypeBL.MicroTeachCaseRelaInfoTypeDA.UpdateBySqlWithConditionTransaction(objMicroTeachCaseRelaInfoTypeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroTeachCaseRelaInfoTypeBL.ReFreshCache();

if (clsMicroTeachCaseRelaInfoTypeBL.relatedActions != null)
{
clsMicroTeachCaseRelaInfoTypeBL.relatedActions.UpdRelaTabDate(objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType, "SetUpdDate");
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
 /// <param name = "strIdMicroTeachCaseRelaInfoType">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoTypeEN)
{
try
{
int intRecNum = clsMicroTeachCaseRelaInfoTypeBL.MicroTeachCaseRelaInfoTypeDA.DelRecord(objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroTeachCaseRelaInfoTypeBL.ReFreshCache();

if (clsMicroTeachCaseRelaInfoTypeBL.relatedActions != null)
{
clsMicroTeachCaseRelaInfoTypeBL.relatedActions.UpdRelaTabDate(objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType, "SetUpdDate");
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
 /// <param name = "objMicroTeachCaseRelaInfoTypeENS">源对象</param>
 /// <param name = "objMicroTeachCaseRelaInfoTypeENT">目标对象</param>
 public static void CopyTo(this clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoTypeENS, clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoTypeENT)
{
try
{
objMicroTeachCaseRelaInfoTypeENT.IdMicroTeachCaseRelaInfoType = objMicroTeachCaseRelaInfoTypeENS.IdMicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
objMicroTeachCaseRelaInfoTypeENT.MicroTeachCaseRelaInfoTypeID = objMicroTeachCaseRelaInfoTypeENS.MicroTeachCaseRelaInfoTypeID; //微格案例相关信息类型ID
objMicroTeachCaseRelaInfoTypeENT.MicroTeachCaseRelaInfoTypeName = objMicroTeachCaseRelaInfoTypeENS.MicroTeachCaseRelaInfoTypeName; //微格案例相关信息类型名称
objMicroTeachCaseRelaInfoTypeENT.MicroTeachCaseRelaInfoTypeENName = objMicroTeachCaseRelaInfoTypeENS.MicroTeachCaseRelaInfoTypeENName; //案例相关信息类型英文名
objMicroTeachCaseRelaInfoTypeENT.CoursewareCaseRelaInfoTypeName = objMicroTeachCaseRelaInfoTypeENS.CoursewareCaseRelaInfoTypeName; //课件相关信息类型名称
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
 /// <param name = "objMicroTeachCaseRelaInfoTypeENS">源对象</param>
 /// <returns>目标对象=>clsMicroTeachCaseRelaInfoTypeEN:objMicroTeachCaseRelaInfoTypeENT</returns>
 public static clsMicroTeachCaseRelaInfoTypeEN CopyTo(this clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoTypeENS)
{
try
{
 clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoTypeENT = new clsMicroTeachCaseRelaInfoTypeEN()
{
IdMicroTeachCaseRelaInfoType = objMicroTeachCaseRelaInfoTypeENS.IdMicroTeachCaseRelaInfoType, //微格案例相关信息类型流水号
MicroTeachCaseRelaInfoTypeID = objMicroTeachCaseRelaInfoTypeENS.MicroTeachCaseRelaInfoTypeID, //微格案例相关信息类型ID
MicroTeachCaseRelaInfoTypeName = objMicroTeachCaseRelaInfoTypeENS.MicroTeachCaseRelaInfoTypeName, //微格案例相关信息类型名称
MicroTeachCaseRelaInfoTypeENName = objMicroTeachCaseRelaInfoTypeENS.MicroTeachCaseRelaInfoTypeENName, //案例相关信息类型英文名
CoursewareCaseRelaInfoTypeName = objMicroTeachCaseRelaInfoTypeENS.CoursewareCaseRelaInfoTypeName, //课件相关信息类型名称
};
 return objMicroTeachCaseRelaInfoTypeENT;
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
public static void CheckPropertyNew(this clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoTypeEN)
{
 clsMicroTeachCaseRelaInfoTypeBL.MicroTeachCaseRelaInfoTypeDA.CheckPropertyNew(objMicroTeachCaseRelaInfoTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoTypeEN)
{
 clsMicroTeachCaseRelaInfoTypeBL.MicroTeachCaseRelaInfoTypeDA.CheckProperty4Condition(objMicroTeachCaseRelaInfoTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objMicroTeachCaseRelaInfoTypeCond.IsUpdated(conMicroTeachCaseRelaInfoType.IdMicroTeachCaseRelaInfoType) == true)
{
string strComparisonOpIdMicroTeachCaseRelaInfoType = objMicroTeachCaseRelaInfoTypeCond.dicFldComparisonOp[conMicroTeachCaseRelaInfoType.IdMicroTeachCaseRelaInfoType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroTeachCaseRelaInfoType.IdMicroTeachCaseRelaInfoType, objMicroTeachCaseRelaInfoTypeCond.IdMicroTeachCaseRelaInfoType, strComparisonOpIdMicroTeachCaseRelaInfoType);
}
if (objMicroTeachCaseRelaInfoTypeCond.IsUpdated(conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeID) == true)
{
string strComparisonOpMicroTeachCaseRelaInfoTypeID = objMicroTeachCaseRelaInfoTypeCond.dicFldComparisonOp[conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeID, objMicroTeachCaseRelaInfoTypeCond.MicroTeachCaseRelaInfoTypeID, strComparisonOpMicroTeachCaseRelaInfoTypeID);
}
if (objMicroTeachCaseRelaInfoTypeCond.IsUpdated(conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeName) == true)
{
string strComparisonOpMicroTeachCaseRelaInfoTypeName = objMicroTeachCaseRelaInfoTypeCond.dicFldComparisonOp[conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeName, objMicroTeachCaseRelaInfoTypeCond.MicroTeachCaseRelaInfoTypeName, strComparisonOpMicroTeachCaseRelaInfoTypeName);
}
if (objMicroTeachCaseRelaInfoTypeCond.IsUpdated(conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeENName) == true)
{
string strComparisonOpMicroTeachCaseRelaInfoTypeENName = objMicroTeachCaseRelaInfoTypeCond.dicFldComparisonOp[conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeENName, objMicroTeachCaseRelaInfoTypeCond.MicroTeachCaseRelaInfoTypeENName, strComparisonOpMicroTeachCaseRelaInfoTypeENName);
}
if (objMicroTeachCaseRelaInfoTypeCond.IsUpdated(conMicroTeachCaseRelaInfoType.CoursewareCaseRelaInfoTypeName) == true)
{
string strComparisonOpCoursewareCaseRelaInfoTypeName = objMicroTeachCaseRelaInfoTypeCond.dicFldComparisonOp[conMicroTeachCaseRelaInfoType.CoursewareCaseRelaInfoTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroTeachCaseRelaInfoType.CoursewareCaseRelaInfoTypeName, objMicroTeachCaseRelaInfoTypeCond.CoursewareCaseRelaInfoTypeName, strComparisonOpCoursewareCaseRelaInfoTypeName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_MicroTeachCaseRelaInfoType
{
public virtual bool UpdRelaTabDate(string strIdMicroTeachCaseRelaInfoType, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 根据表内容设置enum列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GeneEnumConstList)
 /// </summary>
public class enumMicroTeachCaseRelaInfoType
{
 /// <summary>
 /// 课堂录像
 /// </summary>
public const string ClassroomVideo_0003 = "0003";
 /// <summary>
 /// 多媒体课件
 /// </summary>
public const string MultimediaCourseware_0004 = "0004";
 /// <summary>
 /// 教师点评
 /// </summary>
public const string TeacherComment_0005 = "0005";
 /// <summary>
 /// 微格副视频
 /// </summary>
public const string MicroGridVideo_0006 = "0006";
 /// <summary>
 /// PPT课件
 /// </summary>
public const string PPT_0007 = "0007";
 /// <summary>
 /// 教案文档
 /// </summary>
public const string LessonPlanDocument_0008 = "0008";
 /// <summary>
 /// 其他资源
 /// </summary>
public const string OtherResources_0009 = "0009";
 /// <summary>
 /// 图片作品
 /// </summary>
public const string PictureWork_0010 = "0010";
 /// <summary>
 /// 封面图片
 /// </summary>
public const string CoverPic_0011 = "0011";
}
 /// <summary>
 /// 微格案例相关信息类型(MicroTeachCaseRelaInfoType)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsMicroTeachCaseRelaInfoTypeBL
{
public static RelatedActions_MicroTeachCaseRelaInfoType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsMicroTeachCaseRelaInfoTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsMicroTeachCaseRelaInfoTypeDA MicroTeachCaseRelaInfoTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsMicroTeachCaseRelaInfoTypeDA();
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
 public clsMicroTeachCaseRelaInfoTypeBL()
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
if (string.IsNullOrEmpty(clsMicroTeachCaseRelaInfoTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsMicroTeachCaseRelaInfoTypeEN._ConnectString);
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
public static DataTable GetDataTable_MicroTeachCaseRelaInfoType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = MicroTeachCaseRelaInfoTypeDA.GetDataTable_MicroTeachCaseRelaInfoType(strWhereCond);
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
objDT = MicroTeachCaseRelaInfoTypeDA.GetDataTable(strWhereCond);
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
objDT = MicroTeachCaseRelaInfoTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = MicroTeachCaseRelaInfoTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = MicroTeachCaseRelaInfoTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = MicroTeachCaseRelaInfoTypeDA.GetDataTable_Top(objTopPara);
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
objDT = MicroTeachCaseRelaInfoTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = MicroTeachCaseRelaInfoTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = MicroTeachCaseRelaInfoTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdMicroTeachCaseRelaInfoTypeLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsMicroTeachCaseRelaInfoTypeEN> GetObjLstByIdMicroTeachCaseRelaInfoTypeLst(List<string> arrIdMicroTeachCaseRelaInfoTypeLst)
{
List<clsMicroTeachCaseRelaInfoTypeEN> arrObjLst = new List<clsMicroTeachCaseRelaInfoTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdMicroTeachCaseRelaInfoTypeLst, true);
 string strWhereCond = string.Format("IdMicroTeachCaseRelaInfoType in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoTypeEN = new clsMicroTeachCaseRelaInfoTypeEN();
try
{
objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType = objRow[conMicroTeachCaseRelaInfoType.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objMicroTeachCaseRelaInfoTypeEN.MicroTeachCaseRelaInfoTypeID = objRow[conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objMicroTeachCaseRelaInfoTypeEN.MicroTeachCaseRelaInfoTypeName = objRow[conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objMicroTeachCaseRelaInfoTypeEN.MicroTeachCaseRelaInfoTypeENName = objRow[conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeENName] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeENName].ToString().Trim(); //案例相关信息类型英文名
objMicroTeachCaseRelaInfoTypeEN.CoursewareCaseRelaInfoTypeName = objRow[conMicroTeachCaseRelaInfoType.CoursewareCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfoType.CoursewareCaseRelaInfoTypeName].ToString().Trim(); //课件相关信息类型名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroTeachCaseRelaInfoTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdMicroTeachCaseRelaInfoTypeLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsMicroTeachCaseRelaInfoTypeEN> GetObjLstByIdMicroTeachCaseRelaInfoTypeLstCache(List<string> arrIdMicroTeachCaseRelaInfoTypeLst)
{
string strKey = string.Format("{0}", clsMicroTeachCaseRelaInfoTypeEN._CurrTabName);
List<clsMicroTeachCaseRelaInfoTypeEN> arrMicroTeachCaseRelaInfoTypeObjLstCache = GetObjLstCache();
IEnumerable <clsMicroTeachCaseRelaInfoTypeEN> arrMicroTeachCaseRelaInfoTypeObjLst_Sel =
arrMicroTeachCaseRelaInfoTypeObjLstCache
.Where(x => arrIdMicroTeachCaseRelaInfoTypeLst.Contains(x.IdMicroTeachCaseRelaInfoType));
return arrMicroTeachCaseRelaInfoTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsMicroTeachCaseRelaInfoTypeEN> GetObjLst(string strWhereCond)
{
List<clsMicroTeachCaseRelaInfoTypeEN> arrObjLst = new List<clsMicroTeachCaseRelaInfoTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoTypeEN = new clsMicroTeachCaseRelaInfoTypeEN();
try
{
objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType = objRow[conMicroTeachCaseRelaInfoType.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objMicroTeachCaseRelaInfoTypeEN.MicroTeachCaseRelaInfoTypeID = objRow[conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objMicroTeachCaseRelaInfoTypeEN.MicroTeachCaseRelaInfoTypeName = objRow[conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objMicroTeachCaseRelaInfoTypeEN.MicroTeachCaseRelaInfoTypeENName = objRow[conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeENName] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeENName].ToString().Trim(); //案例相关信息类型英文名
objMicroTeachCaseRelaInfoTypeEN.CoursewareCaseRelaInfoTypeName = objRow[conMicroTeachCaseRelaInfoType.CoursewareCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfoType.CoursewareCaseRelaInfoTypeName].ToString().Trim(); //课件相关信息类型名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroTeachCaseRelaInfoTypeEN);
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
public static List<clsMicroTeachCaseRelaInfoTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsMicroTeachCaseRelaInfoTypeEN> arrObjLst = new List<clsMicroTeachCaseRelaInfoTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoTypeEN = new clsMicroTeachCaseRelaInfoTypeEN();
try
{
objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType = objRow[conMicroTeachCaseRelaInfoType.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objMicroTeachCaseRelaInfoTypeEN.MicroTeachCaseRelaInfoTypeID = objRow[conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objMicroTeachCaseRelaInfoTypeEN.MicroTeachCaseRelaInfoTypeName = objRow[conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objMicroTeachCaseRelaInfoTypeEN.MicroTeachCaseRelaInfoTypeENName = objRow[conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeENName] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeENName].ToString().Trim(); //案例相关信息类型英文名
objMicroTeachCaseRelaInfoTypeEN.CoursewareCaseRelaInfoTypeName = objRow[conMicroTeachCaseRelaInfoType.CoursewareCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfoType.CoursewareCaseRelaInfoTypeName].ToString().Trim(); //课件相关信息类型名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroTeachCaseRelaInfoTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objMicroTeachCaseRelaInfoTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsMicroTeachCaseRelaInfoTypeEN> GetSubObjLstCache(clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoTypeCond)
{
List<clsMicroTeachCaseRelaInfoTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsMicroTeachCaseRelaInfoTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conMicroTeachCaseRelaInfoType.AttributeName)
{
if (objMicroTeachCaseRelaInfoTypeCond.IsUpdated(strFldName) == false) continue;
if (objMicroTeachCaseRelaInfoTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objMicroTeachCaseRelaInfoTypeCond[strFldName].ToString());
}
else
{
if (objMicroTeachCaseRelaInfoTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objMicroTeachCaseRelaInfoTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objMicroTeachCaseRelaInfoTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objMicroTeachCaseRelaInfoTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objMicroTeachCaseRelaInfoTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objMicroTeachCaseRelaInfoTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objMicroTeachCaseRelaInfoTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objMicroTeachCaseRelaInfoTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objMicroTeachCaseRelaInfoTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objMicroTeachCaseRelaInfoTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objMicroTeachCaseRelaInfoTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objMicroTeachCaseRelaInfoTypeCond[strFldName]));
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
public static List<clsMicroTeachCaseRelaInfoTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsMicroTeachCaseRelaInfoTypeEN> arrObjLst = new List<clsMicroTeachCaseRelaInfoTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoTypeEN = new clsMicroTeachCaseRelaInfoTypeEN();
try
{
objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType = objRow[conMicroTeachCaseRelaInfoType.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objMicroTeachCaseRelaInfoTypeEN.MicroTeachCaseRelaInfoTypeID = objRow[conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objMicroTeachCaseRelaInfoTypeEN.MicroTeachCaseRelaInfoTypeName = objRow[conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objMicroTeachCaseRelaInfoTypeEN.MicroTeachCaseRelaInfoTypeENName = objRow[conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeENName] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeENName].ToString().Trim(); //案例相关信息类型英文名
objMicroTeachCaseRelaInfoTypeEN.CoursewareCaseRelaInfoTypeName = objRow[conMicroTeachCaseRelaInfoType.CoursewareCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfoType.CoursewareCaseRelaInfoTypeName].ToString().Trim(); //课件相关信息类型名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroTeachCaseRelaInfoTypeEN);
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
public static List<clsMicroTeachCaseRelaInfoTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsMicroTeachCaseRelaInfoTypeEN> arrObjLst = new List<clsMicroTeachCaseRelaInfoTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoTypeEN = new clsMicroTeachCaseRelaInfoTypeEN();
try
{
objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType = objRow[conMicroTeachCaseRelaInfoType.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objMicroTeachCaseRelaInfoTypeEN.MicroTeachCaseRelaInfoTypeID = objRow[conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objMicroTeachCaseRelaInfoTypeEN.MicroTeachCaseRelaInfoTypeName = objRow[conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objMicroTeachCaseRelaInfoTypeEN.MicroTeachCaseRelaInfoTypeENName = objRow[conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeENName] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeENName].ToString().Trim(); //案例相关信息类型英文名
objMicroTeachCaseRelaInfoTypeEN.CoursewareCaseRelaInfoTypeName = objRow[conMicroTeachCaseRelaInfoType.CoursewareCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfoType.CoursewareCaseRelaInfoTypeName].ToString().Trim(); //课件相关信息类型名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroTeachCaseRelaInfoTypeEN);
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
List<clsMicroTeachCaseRelaInfoTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsMicroTeachCaseRelaInfoTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsMicroTeachCaseRelaInfoTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsMicroTeachCaseRelaInfoTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsMicroTeachCaseRelaInfoTypeEN> arrObjLst = new List<clsMicroTeachCaseRelaInfoTypeEN>(); 
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
	clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoTypeEN = new clsMicroTeachCaseRelaInfoTypeEN();
try
{
objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType = objRow[conMicroTeachCaseRelaInfoType.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objMicroTeachCaseRelaInfoTypeEN.MicroTeachCaseRelaInfoTypeID = objRow[conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objMicroTeachCaseRelaInfoTypeEN.MicroTeachCaseRelaInfoTypeName = objRow[conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objMicroTeachCaseRelaInfoTypeEN.MicroTeachCaseRelaInfoTypeENName = objRow[conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeENName] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeENName].ToString().Trim(); //案例相关信息类型英文名
objMicroTeachCaseRelaInfoTypeEN.CoursewareCaseRelaInfoTypeName = objRow[conMicroTeachCaseRelaInfoType.CoursewareCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfoType.CoursewareCaseRelaInfoTypeName].ToString().Trim(); //课件相关信息类型名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroTeachCaseRelaInfoTypeEN);
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
public static List<clsMicroTeachCaseRelaInfoTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsMicroTeachCaseRelaInfoTypeEN> arrObjLst = new List<clsMicroTeachCaseRelaInfoTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoTypeEN = new clsMicroTeachCaseRelaInfoTypeEN();
try
{
objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType = objRow[conMicroTeachCaseRelaInfoType.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objMicroTeachCaseRelaInfoTypeEN.MicroTeachCaseRelaInfoTypeID = objRow[conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objMicroTeachCaseRelaInfoTypeEN.MicroTeachCaseRelaInfoTypeName = objRow[conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objMicroTeachCaseRelaInfoTypeEN.MicroTeachCaseRelaInfoTypeENName = objRow[conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeENName] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeENName].ToString().Trim(); //案例相关信息类型英文名
objMicroTeachCaseRelaInfoTypeEN.CoursewareCaseRelaInfoTypeName = objRow[conMicroTeachCaseRelaInfoType.CoursewareCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfoType.CoursewareCaseRelaInfoTypeName].ToString().Trim(); //课件相关信息类型名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroTeachCaseRelaInfoTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsMicroTeachCaseRelaInfoTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsMicroTeachCaseRelaInfoTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsMicroTeachCaseRelaInfoTypeEN> arrObjLst = new List<clsMicroTeachCaseRelaInfoTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoTypeEN = new clsMicroTeachCaseRelaInfoTypeEN();
try
{
objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType = objRow[conMicroTeachCaseRelaInfoType.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objMicroTeachCaseRelaInfoTypeEN.MicroTeachCaseRelaInfoTypeID = objRow[conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objMicroTeachCaseRelaInfoTypeEN.MicroTeachCaseRelaInfoTypeName = objRow[conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objMicroTeachCaseRelaInfoTypeEN.MicroTeachCaseRelaInfoTypeENName = objRow[conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeENName] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeENName].ToString().Trim(); //案例相关信息类型英文名
objMicroTeachCaseRelaInfoTypeEN.CoursewareCaseRelaInfoTypeName = objRow[conMicroTeachCaseRelaInfoType.CoursewareCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfoType.CoursewareCaseRelaInfoTypeName].ToString().Trim(); //课件相关信息类型名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroTeachCaseRelaInfoTypeEN);
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
public static List<clsMicroTeachCaseRelaInfoTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsMicroTeachCaseRelaInfoTypeEN> arrObjLst = new List<clsMicroTeachCaseRelaInfoTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoTypeEN = new clsMicroTeachCaseRelaInfoTypeEN();
try
{
objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType = objRow[conMicroTeachCaseRelaInfoType.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objMicroTeachCaseRelaInfoTypeEN.MicroTeachCaseRelaInfoTypeID = objRow[conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objMicroTeachCaseRelaInfoTypeEN.MicroTeachCaseRelaInfoTypeName = objRow[conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objMicroTeachCaseRelaInfoTypeEN.MicroTeachCaseRelaInfoTypeENName = objRow[conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeENName] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeENName].ToString().Trim(); //案例相关信息类型英文名
objMicroTeachCaseRelaInfoTypeEN.CoursewareCaseRelaInfoTypeName = objRow[conMicroTeachCaseRelaInfoType.CoursewareCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfoType.CoursewareCaseRelaInfoTypeName].ToString().Trim(); //课件相关信息类型名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroTeachCaseRelaInfoTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsMicroTeachCaseRelaInfoTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsMicroTeachCaseRelaInfoTypeEN> arrObjLst = new List<clsMicroTeachCaseRelaInfoTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoTypeEN = new clsMicroTeachCaseRelaInfoTypeEN();
try
{
objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType = objRow[conMicroTeachCaseRelaInfoType.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objMicroTeachCaseRelaInfoTypeEN.MicroTeachCaseRelaInfoTypeID = objRow[conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objMicroTeachCaseRelaInfoTypeEN.MicroTeachCaseRelaInfoTypeName = objRow[conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objMicroTeachCaseRelaInfoTypeEN.MicroTeachCaseRelaInfoTypeENName = objRow[conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeENName] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeENName].ToString().Trim(); //案例相关信息类型英文名
objMicroTeachCaseRelaInfoTypeEN.CoursewareCaseRelaInfoTypeName = objRow[conMicroTeachCaseRelaInfoType.CoursewareCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfoType.CoursewareCaseRelaInfoTypeName].ToString().Trim(); //课件相关信息类型名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroTeachCaseRelaInfoTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objMicroTeachCaseRelaInfoTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetMicroTeachCaseRelaInfoType(ref clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoTypeEN)
{
bool bolResult = MicroTeachCaseRelaInfoTypeDA.GetMicroTeachCaseRelaInfoType(ref objMicroTeachCaseRelaInfoTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdMicroTeachCaseRelaInfoType">表关键字</param>
 /// <returns>表对象</returns>
public static clsMicroTeachCaseRelaInfoTypeEN GetObjByIdMicroTeachCaseRelaInfoType(string strIdMicroTeachCaseRelaInfoType)
{
if (strIdMicroTeachCaseRelaInfoType.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdMicroTeachCaseRelaInfoType]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdMicroTeachCaseRelaInfoType) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdMicroTeachCaseRelaInfoType]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoTypeEN = MicroTeachCaseRelaInfoTypeDA.GetObjByIdMicroTeachCaseRelaInfoType(strIdMicroTeachCaseRelaInfoType);
return objMicroTeachCaseRelaInfoTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsMicroTeachCaseRelaInfoTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoTypeEN = MicroTeachCaseRelaInfoTypeDA.GetFirstObj(strWhereCond);
 return objMicroTeachCaseRelaInfoTypeEN;
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
public static clsMicroTeachCaseRelaInfoTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoTypeEN = MicroTeachCaseRelaInfoTypeDA.GetObjByDataRow(objRow);
 return objMicroTeachCaseRelaInfoTypeEN;
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
public static clsMicroTeachCaseRelaInfoTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoTypeEN = MicroTeachCaseRelaInfoTypeDA.GetObjByDataRow(objRow);
 return objMicroTeachCaseRelaInfoTypeEN;
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
 /// <param name = "strIdMicroTeachCaseRelaInfoType">所给的关键字</param>
 /// <param name = "lstMicroTeachCaseRelaInfoTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsMicroTeachCaseRelaInfoTypeEN GetObjByIdMicroTeachCaseRelaInfoTypeFromList(string strIdMicroTeachCaseRelaInfoType, List<clsMicroTeachCaseRelaInfoTypeEN> lstMicroTeachCaseRelaInfoTypeObjLst)
{
foreach (clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoTypeEN in lstMicroTeachCaseRelaInfoTypeObjLst)
{
if (objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType == strIdMicroTeachCaseRelaInfoType)
{
return objMicroTeachCaseRelaInfoTypeEN;
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
 string strIdMicroTeachCaseRelaInfoType;
 try
 {
 strIdMicroTeachCaseRelaInfoType = new clsMicroTeachCaseRelaInfoTypeDA().GetFirstID(strWhereCond);
 return strIdMicroTeachCaseRelaInfoType;
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
 arrList = MicroTeachCaseRelaInfoTypeDA.GetID(strWhereCond);
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
bool bolIsExist = MicroTeachCaseRelaInfoTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdMicroTeachCaseRelaInfoType">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdMicroTeachCaseRelaInfoType)
{
if (string.IsNullOrEmpty(strIdMicroTeachCaseRelaInfoType) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdMicroTeachCaseRelaInfoType]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = MicroTeachCaseRelaInfoTypeDA.IsExist(strIdMicroTeachCaseRelaInfoType);
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
 bolIsExist = clsMicroTeachCaseRelaInfoTypeDA.IsExistTable();
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
 bolIsExist = MicroTeachCaseRelaInfoTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objMicroTeachCaseRelaInfoTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoTypeEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsMicroTeachCaseRelaInfoTypeBL.IsExist(objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = MicroTeachCaseRelaInfoTypeDA.AddNewRecordBySQL2(objMicroTeachCaseRelaInfoTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroTeachCaseRelaInfoTypeBL.ReFreshCache();

if (clsMicroTeachCaseRelaInfoTypeBL.relatedActions != null)
{
clsMicroTeachCaseRelaInfoTypeBL.relatedActions.UpdRelaTabDate(objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType, "SetUpdDate");
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
 /// <param name = "objMicroTeachCaseRelaInfoTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoTypeEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsMicroTeachCaseRelaInfoTypeBL.IsExist(objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = MicroTeachCaseRelaInfoTypeDA.AddNewRecordBySQL2WithReturnKey(objMicroTeachCaseRelaInfoTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroTeachCaseRelaInfoTypeBL.ReFreshCache();

if (clsMicroTeachCaseRelaInfoTypeBL.relatedActions != null)
{
clsMicroTeachCaseRelaInfoTypeBL.relatedActions.UpdRelaTabDate(objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType, "SetUpdDate");
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
 /// <param name = "objMicroTeachCaseRelaInfoTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoTypeEN)
{
try
{
bool bolResult = MicroTeachCaseRelaInfoTypeDA.Update(objMicroTeachCaseRelaInfoTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroTeachCaseRelaInfoTypeBL.ReFreshCache();

if (clsMicroTeachCaseRelaInfoTypeBL.relatedActions != null)
{
clsMicroTeachCaseRelaInfoTypeBL.relatedActions.UpdRelaTabDate(objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType, "SetUpdDate");
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
 /// <param name = "objMicroTeachCaseRelaInfoTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoTypeEN)
{
 if (string.IsNullOrEmpty(objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = MicroTeachCaseRelaInfoTypeDA.UpdateBySql2(objMicroTeachCaseRelaInfoTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroTeachCaseRelaInfoTypeBL.ReFreshCache();

if (clsMicroTeachCaseRelaInfoTypeBL.relatedActions != null)
{
clsMicroTeachCaseRelaInfoTypeBL.relatedActions.UpdRelaTabDate(objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType, "SetUpdDate");
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
 /// <param name = "strIdMicroTeachCaseRelaInfoType">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strIdMicroTeachCaseRelaInfoType)
{
try
{
 clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoTypeEN = clsMicroTeachCaseRelaInfoTypeBL.GetObjByIdMicroTeachCaseRelaInfoType(strIdMicroTeachCaseRelaInfoType);

if (clsMicroTeachCaseRelaInfoTypeBL.relatedActions != null)
{
clsMicroTeachCaseRelaInfoTypeBL.relatedActions.UpdRelaTabDate(objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType, "SetUpdDate");
}
if (objMicroTeachCaseRelaInfoTypeEN != null)
{
int intRecNum = MicroTeachCaseRelaInfoTypeDA.DelRecord(strIdMicroTeachCaseRelaInfoType);
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
/// <param name="strIdMicroTeachCaseRelaInfoType">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strIdMicroTeachCaseRelaInfoType )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsMicroTeachCaseRelaInfoTypeDA.GetSpecSQLObj();
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
//删除与表:[MicroTeachCaseRelaInfoType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conMicroTeachCaseRelaInfoType.IdMicroTeachCaseRelaInfoType,
//strIdMicroTeachCaseRelaInfoType);
//        clsMicroTeachCaseRelaInfoTypeBL.DelMicroTeachCaseRelaInfoTypesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsMicroTeachCaseRelaInfoTypeBL.DelRecord(strIdMicroTeachCaseRelaInfoType, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsMicroTeachCaseRelaInfoTypeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdMicroTeachCaseRelaInfoType, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strIdMicroTeachCaseRelaInfoType">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strIdMicroTeachCaseRelaInfoType, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsMicroTeachCaseRelaInfoTypeBL.relatedActions != null)
{
clsMicroTeachCaseRelaInfoTypeBL.relatedActions.UpdRelaTabDate(strIdMicroTeachCaseRelaInfoType, "UpdRelaTabDate");
}
bool bolResult = MicroTeachCaseRelaInfoTypeDA.DelRecord(strIdMicroTeachCaseRelaInfoType,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdMicroTeachCaseRelaInfoTypeLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelMicroTeachCaseRelaInfoTypes(List<string> arrIdMicroTeachCaseRelaInfoTypeLst)
{
if (arrIdMicroTeachCaseRelaInfoTypeLst.Count == 0) return 0;
try
{
if (clsMicroTeachCaseRelaInfoTypeBL.relatedActions != null)
{
foreach (var strIdMicroTeachCaseRelaInfoType in arrIdMicroTeachCaseRelaInfoTypeLst)
{
clsMicroTeachCaseRelaInfoTypeBL.relatedActions.UpdRelaTabDate(strIdMicroTeachCaseRelaInfoType, "UpdRelaTabDate");
}
}
int intDelRecNum = MicroTeachCaseRelaInfoTypeDA.DelMicroTeachCaseRelaInfoType(arrIdMicroTeachCaseRelaInfoTypeLst);
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
public static int DelMicroTeachCaseRelaInfoTypesByCond(string strWhereCond)
{
try
{
if (clsMicroTeachCaseRelaInfoTypeBL.relatedActions != null)
{
List<string> arrIdMicroTeachCaseRelaInfoType = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdMicroTeachCaseRelaInfoType in arrIdMicroTeachCaseRelaInfoType)
{
clsMicroTeachCaseRelaInfoTypeBL.relatedActions.UpdRelaTabDate(strIdMicroTeachCaseRelaInfoType, "UpdRelaTabDate");
}
}
int intRecNum = MicroTeachCaseRelaInfoTypeDA.DelMicroTeachCaseRelaInfoType(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[MicroTeachCaseRelaInfoType]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strIdMicroTeachCaseRelaInfoType">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strIdMicroTeachCaseRelaInfoType)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsMicroTeachCaseRelaInfoTypeDA.GetSpecSQLObj();
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
//删除与表:[MicroTeachCaseRelaInfoType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsMicroTeachCaseRelaInfoTypeBL.DelRecord(strIdMicroTeachCaseRelaInfoType, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsMicroTeachCaseRelaInfoTypeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdMicroTeachCaseRelaInfoType, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objMicroTeachCaseRelaInfoTypeENS">源对象</param>
 /// <param name = "objMicroTeachCaseRelaInfoTypeENT">目标对象</param>
 public static void CopyTo(clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoTypeENS, clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoTypeENT)
{
try
{
objMicroTeachCaseRelaInfoTypeENT.IdMicroTeachCaseRelaInfoType = objMicroTeachCaseRelaInfoTypeENS.IdMicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
objMicroTeachCaseRelaInfoTypeENT.MicroTeachCaseRelaInfoTypeID = objMicroTeachCaseRelaInfoTypeENS.MicroTeachCaseRelaInfoTypeID; //微格案例相关信息类型ID
objMicroTeachCaseRelaInfoTypeENT.MicroTeachCaseRelaInfoTypeName = objMicroTeachCaseRelaInfoTypeENS.MicroTeachCaseRelaInfoTypeName; //微格案例相关信息类型名称
objMicroTeachCaseRelaInfoTypeENT.MicroTeachCaseRelaInfoTypeENName = objMicroTeachCaseRelaInfoTypeENS.MicroTeachCaseRelaInfoTypeENName; //案例相关信息类型英文名
objMicroTeachCaseRelaInfoTypeENT.CoursewareCaseRelaInfoTypeName = objMicroTeachCaseRelaInfoTypeENS.CoursewareCaseRelaInfoTypeName; //课件相关信息类型名称
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
 /// <param name = "objMicroTeachCaseRelaInfoTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoTypeEN)
{
try
{
objMicroTeachCaseRelaInfoTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objMicroTeachCaseRelaInfoTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conMicroTeachCaseRelaInfoType.IdMicroTeachCaseRelaInfoType, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType = objMicroTeachCaseRelaInfoTypeEN.IdMicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
}
if (arrFldSet.Contains(conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroTeachCaseRelaInfoTypeEN.MicroTeachCaseRelaInfoTypeID = objMicroTeachCaseRelaInfoTypeEN.MicroTeachCaseRelaInfoTypeID; //微格案例相关信息类型ID
}
if (arrFldSet.Contains(conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroTeachCaseRelaInfoTypeEN.MicroTeachCaseRelaInfoTypeName = objMicroTeachCaseRelaInfoTypeEN.MicroTeachCaseRelaInfoTypeName; //微格案例相关信息类型名称
}
if (arrFldSet.Contains(conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroTeachCaseRelaInfoTypeEN.MicroTeachCaseRelaInfoTypeENName = objMicroTeachCaseRelaInfoTypeEN.MicroTeachCaseRelaInfoTypeENName == "[null]" ? null :  objMicroTeachCaseRelaInfoTypeEN.MicroTeachCaseRelaInfoTypeENName; //案例相关信息类型英文名
}
if (arrFldSet.Contains(conMicroTeachCaseRelaInfoType.CoursewareCaseRelaInfoTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroTeachCaseRelaInfoTypeEN.CoursewareCaseRelaInfoTypeName = objMicroTeachCaseRelaInfoTypeEN.CoursewareCaseRelaInfoTypeName == "[null]" ? null :  objMicroTeachCaseRelaInfoTypeEN.CoursewareCaseRelaInfoTypeName; //课件相关信息类型名称
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
 /// <param name = "objMicroTeachCaseRelaInfoTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoTypeEN)
{
try
{
if (objMicroTeachCaseRelaInfoTypeEN.MicroTeachCaseRelaInfoTypeENName == "[null]") objMicroTeachCaseRelaInfoTypeEN.MicroTeachCaseRelaInfoTypeENName = null; //案例相关信息类型英文名
if (objMicroTeachCaseRelaInfoTypeEN.CoursewareCaseRelaInfoTypeName == "[null]") objMicroTeachCaseRelaInfoTypeEN.CoursewareCaseRelaInfoTypeName = null; //课件相关信息类型名称
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
public static void CheckPropertyNew(clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoTypeEN)
{
 MicroTeachCaseRelaInfoTypeDA.CheckPropertyNew(objMicroTeachCaseRelaInfoTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoTypeEN)
{
 MicroTeachCaseRelaInfoTypeDA.CheckProperty4Condition(objMicroTeachCaseRelaInfoTypeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_IdMicroTeachCaseRelaInfoTypeCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[微格案例相关信息类型]...","0");
List<clsMicroTeachCaseRelaInfoTypeEN> arrMicroTeachCaseRelaInfoTypeObjLst = GetAllMicroTeachCaseRelaInfoTypeObjLstCache(); 
objDDL.DataValueField = conMicroTeachCaseRelaInfoType.IdMicroTeachCaseRelaInfoType;
objDDL.DataTextField = conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeName;
objDDL.DataSource = arrMicroTeachCaseRelaInfoTypeObjLst;
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
if (clsMicroTeachCaseRelaInfoTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroTeachCaseRelaInfoTypeBL没有刷新缓存机制(clsMicroTeachCaseRelaInfoTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdMicroTeachCaseRelaInfoType");
//if (arrMicroTeachCaseRelaInfoTypeObjLstCache == null)
//{
//arrMicroTeachCaseRelaInfoTypeObjLstCache = MicroTeachCaseRelaInfoTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdMicroTeachCaseRelaInfoType">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsMicroTeachCaseRelaInfoTypeEN GetObjByIdMicroTeachCaseRelaInfoTypeCache(string strIdMicroTeachCaseRelaInfoType)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsMicroTeachCaseRelaInfoTypeEN._CurrTabName);
List<clsMicroTeachCaseRelaInfoTypeEN> arrMicroTeachCaseRelaInfoTypeObjLstCache = GetObjLstCache();
IEnumerable <clsMicroTeachCaseRelaInfoTypeEN> arrMicroTeachCaseRelaInfoTypeObjLst_Sel =
arrMicroTeachCaseRelaInfoTypeObjLstCache
.Where(x=> x.IdMicroTeachCaseRelaInfoType == strIdMicroTeachCaseRelaInfoType 
);
if (arrMicroTeachCaseRelaInfoTypeObjLst_Sel.Count() == 0)
{
   clsMicroTeachCaseRelaInfoTypeEN obj = clsMicroTeachCaseRelaInfoTypeBL.GetObjByIdMicroTeachCaseRelaInfoType(strIdMicroTeachCaseRelaInfoType);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrMicroTeachCaseRelaInfoTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdMicroTeachCaseRelaInfoType">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetMicroTeachCaseRelaInfoTypeNameByIdMicroTeachCaseRelaInfoTypeCache(string strIdMicroTeachCaseRelaInfoType)
{
if (string.IsNullOrEmpty(strIdMicroTeachCaseRelaInfoType) == true) return "";
//获取缓存中的对象列表
clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoType = GetObjByIdMicroTeachCaseRelaInfoTypeCache(strIdMicroTeachCaseRelaInfoType);
if (objMicroTeachCaseRelaInfoType == null) return "";
return objMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdMicroTeachCaseRelaInfoType">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByIdMicroTeachCaseRelaInfoTypeCache(string strIdMicroTeachCaseRelaInfoType)
{
if (string.IsNullOrEmpty(strIdMicroTeachCaseRelaInfoType) == true) return "";
//获取缓存中的对象列表
clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoType = GetObjByIdMicroTeachCaseRelaInfoTypeCache(strIdMicroTeachCaseRelaInfoType);
if (objMicroTeachCaseRelaInfoType == null) return "";
return objMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsMicroTeachCaseRelaInfoTypeEN> GetAllMicroTeachCaseRelaInfoTypeObjLstCache()
{
//获取缓存中的对象列表
List<clsMicroTeachCaseRelaInfoTypeEN> arrMicroTeachCaseRelaInfoTypeObjLstCache = GetObjLstCache(); 
return arrMicroTeachCaseRelaInfoTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsMicroTeachCaseRelaInfoTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsMicroTeachCaseRelaInfoTypeEN._CurrTabName);
List<clsMicroTeachCaseRelaInfoTypeEN> arrMicroTeachCaseRelaInfoTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrMicroTeachCaseRelaInfoTypeObjLstCache;
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
string strKey = string.Format("{0}", clsMicroTeachCaseRelaInfoTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsMicroTeachCaseRelaInfoTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsMicroTeachCaseRelaInfoTypeEN._RefreshTimeLst.Count == 0) return "";
return clsMicroTeachCaseRelaInfoTypeEN._RefreshTimeLst[clsMicroTeachCaseRelaInfoTypeEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsMicroTeachCaseRelaInfoTypeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsMicroTeachCaseRelaInfoTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsMicroTeachCaseRelaInfoTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsMicroTeachCaseRelaInfoTypeBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性


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
public static string Func(string strInFldName, string strOutFldName, string strIdMicroTeachCaseRelaInfoType)
{
if (strInFldName != conMicroTeachCaseRelaInfoType.IdMicroTeachCaseRelaInfoType)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conMicroTeachCaseRelaInfoType.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conMicroTeachCaseRelaInfoType.AttributeName));
throw new Exception(strMsg);
}
var objMicroTeachCaseRelaInfoType = clsMicroTeachCaseRelaInfoTypeBL.GetObjByIdMicroTeachCaseRelaInfoTypeCache(strIdMicroTeachCaseRelaInfoType);
if (objMicroTeachCaseRelaInfoType == null) return "";
return objMicroTeachCaseRelaInfoType[strOutFldName].ToString();
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
int intRecCount = clsMicroTeachCaseRelaInfoTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsMicroTeachCaseRelaInfoTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsMicroTeachCaseRelaInfoTypeDA.GetRecCount();
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
int intRecCount = clsMicroTeachCaseRelaInfoTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objMicroTeachCaseRelaInfoTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsMicroTeachCaseRelaInfoTypeEN objMicroTeachCaseRelaInfoTypeCond)
{
List<clsMicroTeachCaseRelaInfoTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsMicroTeachCaseRelaInfoTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conMicroTeachCaseRelaInfoType.AttributeName)
{
if (objMicroTeachCaseRelaInfoTypeCond.IsUpdated(strFldName) == false) continue;
if (objMicroTeachCaseRelaInfoTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objMicroTeachCaseRelaInfoTypeCond[strFldName].ToString());
}
else
{
if (objMicroTeachCaseRelaInfoTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objMicroTeachCaseRelaInfoTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objMicroTeachCaseRelaInfoTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objMicroTeachCaseRelaInfoTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objMicroTeachCaseRelaInfoTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objMicroTeachCaseRelaInfoTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objMicroTeachCaseRelaInfoTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objMicroTeachCaseRelaInfoTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objMicroTeachCaseRelaInfoTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objMicroTeachCaseRelaInfoTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objMicroTeachCaseRelaInfoTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objMicroTeachCaseRelaInfoTypeCond[strFldName]));
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
 List<string> arrList = clsMicroTeachCaseRelaInfoTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = MicroTeachCaseRelaInfoTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = MicroTeachCaseRelaInfoTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = MicroTeachCaseRelaInfoTypeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsMicroTeachCaseRelaInfoTypeDA.SetFldValue(clsMicroTeachCaseRelaInfoTypeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = MicroTeachCaseRelaInfoTypeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsMicroTeachCaseRelaInfoTypeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsMicroTeachCaseRelaInfoTypeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsMicroTeachCaseRelaInfoTypeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[MicroTeachCaseRelaInfoType] "); 
 strCreateTabCode.Append(" ( "); 
 // /**微格案例相关信息类型流水号*/ 
 strCreateTabCode.Append(" IdMicroTeachCaseRelaInfoType char(4) primary key, "); 
 // /**微格案例相关信息类型ID*/ 
 strCreateTabCode.Append(" MicroTeachCaseRelaInfoTypeID char(4) not Null, "); 
 // /**微格案例相关信息类型名称*/ 
 strCreateTabCode.Append(" MicroTeachCaseRelaInfoTypeName varchar(50) not Null, "); 
 // /**案例相关信息类型英文名*/ 
 strCreateTabCode.Append(" MicroTeachCaseRelaInfoTypeENName varchar(50) Null, "); 
 // /**课件相关信息类型名称*/ 
 strCreateTabCode.Append(" CoursewareCaseRelaInfoTypeName varchar(50) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 微格案例相关信息类型(MicroTeachCaseRelaInfoType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4MicroTeachCaseRelaInfoType : clsCommFun4BL
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
clsMicroTeachCaseRelaInfoTypeBL.ReFreshThisCache();
}
}

}